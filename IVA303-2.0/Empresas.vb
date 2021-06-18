Imports System.IO
Imports iTextSharp.text
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports WinSCP

Public Class Empresas

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim sessionOptions As New SessionOptions
    Dim rs As New Resizer

    Public Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With sessionOptions
            .Protocol = Protocol.Sftp
            .HostName = "192.168.0.178"
            .UserName = "root"
            .Password = "Iverson.3$iva"
            .SshHostKeyFingerprint = "ssh-ed25519 256 e3:69:af:9b:52:97:03:13:0a:0c:60:ef:47:7f:39:67"
        End With

        populateDatagridview()
        rs.FindAllControls(Me)

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Public Sub populateDatagridview()

        Dim searchQuery As String = "SELECT E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD, SUM(SUMA_IVA) AS IVA,
                                    ES.NOMBRE AS ESTADO, (SELECT MAX(FECHA) FROM ACTIVIDADES_EMPRESAS WHERE ID_EMPRESA = E.ID) AS ULTIMA_ACTIVIDAD
                                    FROM EMPRESAS E
                                    LEFT JOIN DOCUMENTOS D ON E.CIF = D.CIF
                                    LEFT JOIN ESTADOS_EMPRESAS ES ON E.ID_ESTADO = ES.ID
                                    WHERE D.ID_TIPO IN (1,2) AND D.ID_ESTADO IN (2,3,4)
                                    GROUP BY E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD
                                    ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC"

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)
        DGV_Empresas.DataSource = table

        Dim clientecommand As New MySqlCommand("select * from CLIENTES WHERE ACTIVO = 'SI'", connection)
        Dim clienteadapter As New MySqlDataAdapter(clientecommand)
        Dim clientetable As New DataTable()
        clienteadapter.Fill(clientetable)
        CB_cliente.DataSource = clientetable
        CB_cliente.DisplayMember = "NOMBRE_FISCAL"
        CB_cliente.ValueMember = "ID"

        Dim estadocommand As New MySqlCommand("select * from ESTADOS_EMPRESAS", connection)
        Dim estadoapadter As New MySqlDataAdapter(estadocommand)
        Dim estadotable As New DataTable()
        estadoapadter.Fill(estadotable)
        cb_Estado.DataSource = estadotable
        cb_Estado.DisplayMember = "NOMBRE"
        cb_Estado.ValueMember = "ID"

    End Sub

    Public Sub OBTENER_ID_DOCUMENTOS_PARA_EXPORTAR()

        Dim i = DGV_Empresas.CurrentRow.Index
        Dim j = 1
        Dim cif = DGV_Empresas.Item(j, i).Value

        Dim connection As New MySqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")
        Dim OBTENER_IDS As New MySqlCommand("SELECT ID FROM DOCUMENTOS D WHERE D.CIF = @CIF and d.ID_ESTADO = 2", connection)
        Dim OBTENER_RUTAS As New MySqlCommand("SELECT RUTA FROM DOCUMENTOS WHERE ID = @ID", connection)
        Dim updateQuery As New MySqlCommand("UPDATE DOCUMENTOS SET ID_ESTADO = 3 WHERE ID = @ID", connection)

        OBTENER_IDS.Parameters.Add("@CIF", MySqlDbType.VarChar).Value = DGV_Empresas.Item(j + 1, i).Value

        Dim adapter As New MySqlDataAdapter(OBTENER_IDS)
        Dim table_ids As New DataTable()
        adapter.Fill(table_ids)

        connection.Open()

        OBTENER_IDS.ExecuteNonQuery()

        Dim ID() As String
        Dim totalIDS As Integer

        'Count the number of rows
        totalIDS = table_ids.Rows.Count - 1

        ReDim ID(0 To totalIDS)
        For y = 0 To totalIDS
            ID(y) = table_ids.Rows(y)(0)
        Next

        Dim adapter2 As New MySqlDataAdapter(OBTENER_RUTAS)
        Dim tabla_rutas As New DataTable()


        For Each _id In ID.ToArray
            OBTENER_RUTAS.Parameters.Clear()
            OBTENER_RUTAS.Parameters.AddWithValue("@ID", DbNullOrStringValue(_id))
            OBTENER_RUTAS.ExecuteNonQuery()
            adapter2.Fill(tabla_rutas)
            updateQuery.Parameters.Clear()
            updateQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(_id))
            updateQuery.ExecuteNonQuery()
        Next

        Dim RUTA() As String
        Dim totalRUTAS As Integer
        Dim nueva_ruta() As String
        Dim PDFfile As New Document

        Dim nombrecarpeta As String = "C:\Remesas Empresas\" & DGV_Empresas.Item(j + 4, i).Value

        Directory.CreateDirectory(nombrecarpeta)

        'Count the number of rows
        totalRUTAS = table_ids.Rows.Count - 1

        ReDim RUTA(0 To totalRUTAS)
        ReDim nueva_ruta(0 To totalRUTAS)

        For i = 0 To totalRUTAS
            RUTA(i) = tabla_rutas.Rows(i)(0)
            nueva_ruta(i) = nombrecarpeta & "/" & Strings.Mid(RUTA(i), 8)
            ExtractPdfPage(RUTA(i), 1, nueva_ruta(i))
        Next

        connection.Close()

    End Sub

    Public Overloads Shared Sub ExtractPdfPage(ByVal sourcepdf As String, ByVal pageNumberToExtract As Integer, ByVal outPdf As String)

        Dim reader As iTextSharp.text.pdf.PdfReader = Nothing
        Dim doc As iTextSharp.text.Document = Nothing
        Dim pdfCpy As iTextSharp.text.pdf.PdfCopy = Nothing
        Dim page As iTextSharp.text.pdf.PdfImportedPage = Nothing
        Try
            reader = New iTextSharp.text.pdf.PdfReader(sourcepdf)
            doc = New iTextSharp.text.Document(reader.GetPageSizeWithRotation(1))
            pdfCpy = New iTextSharp.text.pdf.PdfCopy(doc, New System.IO.FileStream(outPdf, System.IO.FileMode.Create))
            doc.Open()
            page = pdfCpy.GetImportedPage(reader, pageNumberToExtract)
            pdfCpy.AddPage(page)
            doc.Close()
            reader.Close()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Certificacion3.Show()

    End Sub

    Private Sub BTN_LLAMAR_Click(sender As Object, e As EventArgs) Handles BTN_LLAMAR.Click

        AltaEmpresa.Show()

    End Sub

    Private Sub btn_Filtro_Cliente_Click(sender As Object, e As EventArgs) Handles btn_Filtro_Cliente.Click

        Dim searchQuery As New MySqlCommand("SELECT E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD, SUM(SUMA_IVA) AS IVA, ES.NOMBRE AS ESTADO, 
                                            (SELECT MAX(FECHA) FROM ACTIVIDADES_EMPRESAS WHERE ID_EMPRESA = E.ID) AS ULTIMA_ACTIVIDAD
                                            FROM EMPRESAS E
                                            LEFT JOIN DOCUMENTOS D ON E.CIF =  D.CIF
                                            LEFT JOIN ESTADOS_EMPRESAS ES ON E.ID_ESTADO = ES.ID
                                            WHERE ID_CLIENTE = @ID_CLIENTE AND D.ID_TIPO IN (1,2,3)
                                            GROUP BY E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD
                                            ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC", connection)

        searchQuery.Parameters.AddWithValue("@ID_CLIENTE", DbNullOrStringValue(CB_cliente.SelectedValue))

        Dim adapter As New MySqlDataAdapter(searchQuery)
        Dim table As New DataTable()
        adapter.Fill(table)
        DGV_Empresas.DataSource = table

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnGenera.Click

        Try

            GenerateInvoices()

            GenerateAccord()

            ExportToExcel()

            UpdateDocsState()

            MsgBox("Operación completada, baby.")

        Catch ex As Exception

        End Try
    End Sub

    Private Sub UpdateDocsState()

        Dim result As Integer = MessageBox.Show("¿Documentación enviada?", "Pollo a la parrilla", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim i = DGV_Empresas.CurrentRow.Index
            Dim j = 1
            Dim cif = DGV_Empresas.Item(j, i).Value

            Dim sqUpdateDocsState As New MySqlCommand("UPDATE DOCUMENTOS
                                                  SET ID_ESTADO = 4
                                                  WHERE CIF = @CIF AND
                                                  ID_TIPO IN (1, 2) AND
                                                  ID_ESTADO = 3", connection)

            sqUpdateDocsState.Parameters.AddWithValue("@CIF", DbNullOrStringValue(cif))

            connection.Open()
            sqUpdateDocsState.ExecuteNonQuery()
            connection.Close()
        End If

    End Sub

    Public Sub GenerateAccord()

        Dim i = DGV_Empresas.CurrentRow.Index
        Dim j = 1
        Dim cif = DGV_Empresas.Item(j, i).Value

        Dim sqEMPRESA As New MySqlCommand("SELECT NOMBRE_FISCAL, CIF, EMAIL, NOMBRE_COMERCIAL
                                        FROM EMPRESAS E 
                                        LEFT JOIN TIPOS_VIAS T ON E.ID_TIPO_VIA = T.ID
                                        WHERE CIF = @CIF", connection)

        sqEMPRESA.Parameters.AddWithValue("@CIF", DbNullOrStringValue(cif))
        Dim empresasadapter As New MySqlDataAdapter(sqEMPRESA)
        Dim empresastable As New DataTable()
        empresasadapter.Fill(empresastable)

        Dim oWord As Word.Application
        Dim oDoc As Word.Document

        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")
        oWord.Visible = False
        oDoc = oWord.Documents.Add("C:\MODELOACUERDO.docx")

        oDoc.Bookmarks.Item("bmNombreEmpresa").Range.Text = empresastable.Rows(0)("NOMBRE_FISCAL").ToString
        oDoc.Bookmarks.Item("bmNombreEmpresa1").Range.Text = empresastable.Rows(0)("NOMBRE_FISCAL").ToString
        oDoc.Bookmarks.Item("bmNombreEmpresa2").Range.Text = empresastable.Rows(0)("NOMBRE_FISCAL").ToString
        oDoc.Bookmarks.Item("bmNombreEmpresa3").Range.Text = empresastable.Rows(0)("NOMBRE_FISCAL").ToString
        oDoc.Bookmarks.Item("bmNombreEmpresa4").Range.Text = empresastable.Rows(0)("NOMBRE_FISCAL").ToString
        oDoc.Bookmarks.Item("bmCIF").Range.Text = empresastable.Rows(0)("CIF").ToString
        oDoc.Bookmarks.Item("bmFecha").Range.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        oDoc.Bookmarks.Item("bmCorreo").Range.Text = empresastable.Rows(0)("EMAIL").ToString

        oDoc.SaveAs2("ACUERDO.docx")
        oDoc.Close()

        Dim newPath2 As String = "C:\ENVIOS\" & empresastable.Rows(0)("NOMBRE_COMERCIAL").ToString()

        System.IO.Directory.CreateDirectory(newPath2)

        File.Move("C:\ENVIOS\" & "ACUERDO.docx", newPath2 & "\" & "ACUERDO.docx")

    End Sub

    Public Sub GenerateInvoices()

        Dim i = DGV_Empresas.CurrentRow.Index
        Dim j = 1
        Dim cif = DGV_Empresas.Item(j, i).Value

        Dim Fileslist2 As String() = Directory.GetFiles("C:\control303\")
        For Each item2 As String In Fileslist2
            System.IO.File.Delete(item2)
        Next

        Dim sqEMPRESA As New MySqlCommand("SELECT NOMBRE_FISCAL,
                                        CONCAT_WS( ' ',REPLACE(T.NOMBRE, '\r', ''), E.NOMBRE_VIA, E.NUMERO_VIA, E.PISO, E.LETRA_PISO) AS DIRECCION, 
                                        LOCALIDAD, PROVINCIA, CP, PAIS, CIF, NOMBRE_COMERCIAL
                                        FROM EMPRESAS E 
                                        LEFT JOIN TIPOS_VIAS T ON E.ID_TIPO_VIA = T.ID
                                        WHERE CIF = @CIF", connection)

        sqEMPRESA.Parameters.AddWithValue("@CIF", DbNullOrStringValue(cif))
        Dim empresasadapter As New MySqlDataAdapter(sqEMPRESA)
        Dim empresastable As New DataTable()
        empresasadapter.Fill(empresastable)

        Dim sqDOCUMENTOS As New MySqlCommand("SELECT D.ID, D.RUTA, D.REFERENCIA, D.FECHA, D.SUMA_BASE, D.SUMA_TOTAL, D.ID_CLIENTE, C.NOMBRE_FISCAL,
                                            CONCAT_WS( ' ',REPLACE(T.NOMBRE, '\r', ''), C.NOMBRE_VIA, C.NUMERO_VIA, C.PISO, C.LETRA_PISO) AS DIRECCION, 
                                            C.LOCALIDAD, C.PROVINCIA, C.CP, C.PAIS, C.CIF, D.ID_TIPO, C.NOMBRE_COMERCIAL
                                            FROM DOCUMENTOS D
                                            LEFT JOIN CLIENTES C ON D.ID_CLIENTE = C.ID
                                            LEFT JOIN TIPOS_VIAS T ON C.ID_TIPO_VIA = T.ID
                                            WHERE D.ID_TIPO IN (1, 2) AND D.CIF = @CIF AND D.ID_ESTADO = 3", connection)

        sqDOCUMENTOS.Parameters.AddWithValue("@CIF", DbNullOrStringValue(cif))
        Dim documentosadapter As New MySqlDataAdapter(sqDOCUMENTOS)
        Dim documentostable As New DataTable()
        documentosadapter.Fill(documentostable)

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim totalDocs = documentostable.Rows.Count - 1

        For y = 0 To totalDocs

            Dim sqUltimaaFactura As New MySqlCommand("SELECT ULTIMA_FACTURA FROM EMPRESAS
                                                    WHERE CIF = @CIF", connection)

            sqUltimaaFactura.Parameters.AddWithValue("@CIF", DbNullOrStringValue(cif))
            Dim ultimafactadapter As New MySqlDataAdapter(sqUltimaaFactura)
            Dim ultimafacttable As New DataTable()
            ultimafactadapter.Fill(ultimafacttable)

            Dim docName As String = documentostable.Rows(y)("RUTA").ToString() & ".pdf"

            'Start Word and open the document template.
            oWord = CreateObject("Word.Application")
            oWord.Visible = False
            oDoc = oWord.Documents.Add("C:\MODELOFACTURADECANJE1.docx")
            Dim fechaDoc As String = documentostable.Rows(y)("FECHA").ToString()
            Dim fechaSinSegundos As String = fechaDoc.Substring(0, 10)

            Dim fechaFact As String = Today.ToString
            Dim fechaFSinSegundos As String = fechaFact.Substring(0, 10)

            oDoc.Bookmarks.Item("bmNOMBREEMPRESA").Range.Text = empresastable.Rows(0)("NOMBRE_FISCAL").ToString()
            oDoc.Bookmarks.Item("bmDIRECCIONEMPRESA").Range.Text = empresastable.Rows(0)("DIRECCION").ToString()
            oDoc.Bookmarks.Item("bmLOCALIDADEMPRESA").Range.Text = empresastable.Rows(0)("LOCALIDAD").ToString()
            oDoc.Bookmarks.Item("bmPROVINCIAEMPRESA").Range.Text = empresastable.Rows(0)("PROVINCIA").ToString()
            oDoc.Bookmarks.Item("bmCPEMPRESA").Range.Text = empresastable.Rows(0)("CP").ToString()
            oDoc.Bookmarks.Item("bmPAISEMPRESA").Range.Text = empresastable.Rows(0)("PAIS").ToString()
            oDoc.Bookmarks.Item("bmCIFEMPRESA").Range.Text = empresastable.Rows(0)("CIF").ToString()

            If documentostable.Rows(y)("ID_TIPO").ToString() = 1 Then
                oDoc.Bookmarks.Item("bmTIPOFACTURA").Range.Text = "DE CANJE"
            ElseIf documentostable.Rows(y)("ID_TIPO").ToString() = 2 Then
                oDoc.Bookmarks.Item("bmTIPOFACTURA").Range.Text = "RECTIFICATIVA"
            Else
                MsgBox("Este tipo de documento no necesita canjearse")
            End If

            oDoc.Bookmarks.Item("bmFECHAFACTURA").Range.Text = fechaFSinSegundos
            oDoc.Bookmarks.Item("bmREFERENCIADOCUMENTO").Range.Text = documentostable.Rows(y)("REFERENCIA").ToString()
            oDoc.Bookmarks.Item("bmFECHADOCUMENTO").Range.Text = fechaSinSegundos
            If cif = "A15022650" Then
                oDoc.Bookmarks.Item("bmNUMEROFACTURA").Range.Text = empresastable.Rows(0)("CIF").ToString() & "-" & (ultimafacttable.Rows(0)("ULTIMA_FACTURA") + 1) & "C".ToString()
            Else
                oDoc.Bookmarks.Item("bmNUMEROFACTURA").Range.Text = empresastable.Rows(0)("CIF").ToString() & "-" & (ultimafacttable.Rows(0)("ULTIMA_FACTURA") + 1).ToString()
            End If
            oDoc.Bookmarks.Item("bmNOMBRECLIENTE").Range.Text = documentostable.Rows(y)("NOMBRE_FISCAL").ToString()
            oDoc.Bookmarks.Item("bmDIRECCIONCLIENTE").Range.Text = documentostable.Rows(y)("DIRECCION").ToString()
            oDoc.Bookmarks.Item("bmLOCALIDADCLIENTE").Range.Text = documentostable.Rows(y)("LOCALIDAD").ToString()
            oDoc.Bookmarks.Item("bmPROVINCIACLIENTE").Range.Text = documentostable.Rows(y)("PROVINCIA").ToString()
            oDoc.Bookmarks.Item("bmCPCLIENTE").Range.Text = documentostable.Rows(y)("CP").ToString()
            oDoc.Bookmarks.Item("bmPAISCLIENTE").Range.Text = documentostable.Rows(y)("PAIS").ToString()
            oDoc.Bookmarks.Item("bmCIFCLIENTE").Range.Text = documentostable.Rows(y)("CIF").ToString()

            Dim updateUltimaFactura As New MySqlCommand("UPDATE EMPRESAS
                                                        SET ULTIMA_FACTURA = ULTIMA_FACTURA + 1
                                                        WHERE CIF = @CIF", connection)

            updateUltimaFactura.Parameters.AddWithValue("@CIF", DbNullOrStringValue(cif))
            connection.Open()
            'updateUltimaFactura.ExecuteNonQuery()
            connection.Close()

            Dim sqLineasIVA10 As New MySqlCommand("SELECT * FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID_DOCUMENTO and TIPO = 10", connection)

            Dim sqLineasIVA21 As New MySqlCommand("SELECT * FROM LINEAS_IVA WHERE ID_DOCUMENTO = @ID_DOCUMENTO and TIPO = 21", connection)

            sqLineasIVA10.Parameters.AddWithValue("@ID_DOCUMENTO", DbNullOrStringValue(documentostable.Rows.Item(y).Item("ID")))

            sqLineasIVA21.Parameters.AddWithValue("@ID_DOCUMENTO", DbNullOrStringValue(documentostable.Rows.Item(y).Item("ID")))

            Dim lineas10adapter As New MySqlDataAdapter(sqLineasIVA10)
            Dim lineas10table As New DataTable()

            lineas10adapter.Fill(lineas10table)

            Dim lineas21adapter As New MySqlDataAdapter(sqLineasIVA21)
            Dim lineas21table As New DataTable()

            lineas21adapter.Fill(lineas21table)

            Dim total10 = lineas10table.Rows.Count
            Dim total21 = lineas21table.Rows.Count

            If total10 > 0 Then
                oDoc.Bookmarks.Item("bmBASE10").Range.Text = lineas10table.Rows(0)("BASE").ToString()
                oDoc.Bookmarks.Item("bmIVA10").Range.Text = lineas10table.Rows(0)("IVA").ToString()
            End If

            If total21 > 0 Then
                oDoc.Bookmarks.Item("bmBASE21").Range.Text = lineas21table.Rows(0)("BASE").ToString()
                oDoc.Bookmarks.Item("bmIVA21").Range.Text = lineas21table.Rows(0)("IVA").ToString()
            End If

            oDoc.Bookmarks.Item("bmTOTAL").Range.Text = documentostable.Rows(y)("SUMA_TOTAL").ToString()

            Dim RUTAKA As String = documentostable.Rows(y)("RUTA").ToString()
            ' COPY the file.

            Dim RUTAKA2 As String = "C:\control303\" & documentostable.Rows(y)("RUTA").ToString()
            File.Copy("S:\img\" & RUTAKA, RUTAKA2)

            'CONVERTIR A TIF EN C:\control303\

            'Process.Start("cmd", "mogrify -path C:\control303\ -format tif -density 300 -resize 1000x1000 C:\control303\*.pdf")

            Shell("cmd.exe /c magick mogrify -path C:\control303\ -format tif -density 300 -resize 1300x1600 C:\control303\*.pdf",, True)

            'METER EL TIF EN EL WORD Y CERRARLO GUARDANDOLO EN CARPETA PREDETERMINADA DE WORD, QUE SEÑALA A C:\Users\.net\Desktop\ENVIOS\

            Dim ruta As String = documentostable.Rows(y)("RUTA").ToString()
            Dim sinruta As String = ruta.Replace("pdf", "tif")

            ''oDoc.Bookmarks.Item("bmIMAGE").Range.InsertFile("C:\control303\" & sinruta & "png")

            oDoc.Tables(1).Rows(15).Cells(1).Range.InlineShapes.AddPicture(FileName:="C:\control303\" & sinruta, LinkToFile:=False, SaveWithDocument:=True)

            oDoc.SaveAs2(docName, Word.WdSaveFormat.wdFormatPDF)

            'BORRAR CONTENIDOS DE CARPETA C:\control303\
            Dim Fileslist As String() = Directory.GetFiles("C:\control303\")
            For Each item As String In Fileslist
                System.IO.File.Delete(item)
            Next

            Myobject(oDoc)
            Myobject(oWord)

            'CREA CARPETA CON NOMBRE COMERCIAL CLIENTE EN C:\Users\.net\Desktop\ENVIOS\ Y MUEVE EL ARCHIVO DENTRO
            Dim newPath2 As String = "C:\ENVIOS\" & empresastable.Rows(0)("NOMBRE_COMERCIAL").ToString()
            System.IO.Directory.CreateDirectory(newPath2)
            File.Move("C:\ENVIOS\" & docName, newPath2 & "\" & docName)
        Next
    End Sub

    Public Sub ExportToExcel()

        Dim i = DGV_Empresas.CurrentRow.Index
        Dim j = 1
        Dim cif = DGV_Empresas.Item(j, i).Value

        Dim sqExcel As New MySqlCommand("select D.ID AS ID_IVA303, C.NOMBRE_FISCAL AS CLIENTE, C.CIF AS CIF,
                                        CONCAT_WS( ' ',REPLACE(T.NOMBRE, '\r', ''), C.NOMBRE_VIA, C.NUMERO_VIA, C.PISO, C.LETRA_PISO) AS DOMICILIO_SOCIAL,
                                        C.LOCALIDAD, C.PROVINCIA, D.FECHA, D.REFERENCIA, D.SUMA_BASE AS BASE, D.SUMA_IVA AS IVA, D.SUMA_TOTAL AS TOTAL, E.NOMBRE_COMERCIAL AS EMPRESA
                                        from DOCUMENTOS D
                                        LEFT JOIN CLIENTES C ON D.ID_CLIENTE = C.ID
                                        LEFT JOIN EMPRESAS E ON D.CIF = E.CIF
                                        LEFT JOIN TIPOS_VIAS T ON C.ID_TIPO_VIA = T.ID
                                        WHERE D.CIF = @CIF AND D.ID_TIPO IN (1, 2) AND D.ID_ESTADO = 3", connection)

        sqExcel.Parameters.AddWithValue("@CIF", DbNullOrStringValue(cif))
        Dim sqExceladapter As New MySqlDataAdapter(sqExcel)
        Dim sqExcelDT As New DataTable
        sqExceladapter.Fill(sqExcelDT)

        'Excel
        Dim xlapp As Excel.Application
        Dim xlworkbook As Excel.Workbook
        Dim xlworksheet As Excel.Worksheet
        Dim misvalue As Object = Reflection.Missing.Value
        xlapp = New Excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlworkbook.Sheets("Sheet1")

        xlapp = CreateObject("Excel.Application")
        xlapp.Visible = False

        For y = 0 To sqExcelDT.Rows.Count - 1
            For z = 0 To sqExcelDT.Columns.Count - 1
                For k As Integer = 1 To sqExcelDT.Columns.Count
                    xlworksheet.Cells(1, k) = sqExcelDT.Columns(k - 1).ColumnName
                    xlworksheet.Cells(y + 2, z + 1) = sqExcelDT.Rows(y).Item(z)
                Next
            Next
        Next

        xlworkbook.SaveAs(sqExcelDT.Rows(0)("EMPRESA").ToString)
        xlworkbook.Close(SaveChanges:=True)

        xlapp.Quit()

        Myobject(xlapp)
        Myobject(xlworkbook)
        Myobject(xlworksheet)

        Dim newPath2 As String = "C:\ENVIOS\" & sqExcelDT.Rows(0)("EMPRESA").ToString
        File.Move("C:\ENVIOS\" & sqExcelDT.Rows(0)("EMPRESA").ToString & ".xlsx", newPath2 & "\" & sqExcelDT.Rows(0)("EMPRESA").ToString & ".xlsx")

        MessageBox.Show("Export to Excel succeded.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Myobject(ByRef obj As Object)
        Try
            Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            obj = Nothing
        Finally
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Private Sub btn_Filtro_Estado_Click(sender As Object, e As EventArgs) Handles btn_Filtro_Estado.Click

        Dim searchQuery As New MySqlCommand("SELECT E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD, SUM(SUMA_IVA) AS IVA, ES.NOMBRE AS ESTADO,
                                    (SELECT MAX(FECHA) FROM ACTIVIDADES_EMPRESAS WHERE ID_EMPRESA = E.ID) AS ULTIMA_ACTIVIDAD
                                    FROM EMPRESAS E
                                    LEFT JOIN DOCUMENTOS D ON E.CIF =  D.CIF
                                    LEFT JOIN ESTADOS_EMPRESAS ES ON E.ID_ESTADO = ES.ID
                                    WHERE E.ID_ESTADO = @ID_ESTADO AND D.ID_TIPO IN (1,2)
                                    GROUP BY E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD
                                    ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC", connection)

        searchQuery.Parameters.AddWithValue("@ID_ESTADO", DbNullOrStringValue(cb_Estado.SelectedValue))

        Dim adapter As New MySqlDataAdapter(searchQuery)
        Dim table As New DataTable()
        adapter.Fill(table)
        DGV_Empresas.DataSource = table

    End Sub

    Private Sub BTN_FILTRO_DOBLE_Click(sender As Object, e As EventArgs) Handles BTN_FILTRO_DOBLE.Click

        Dim searchQuery As New MySqlCommand("SELECT E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD, SUM(SUMA_IVA) AS IVA, ES.NOMBRE AS ESTADO,
                                    (SELECT MAX(FECHA) FROM ACTIVIDADES_EMPRESAS WHERE ID_EMPRESA = E.ID) AS ULTIMA_ACTIVIDAD
                                    FROM EMPRESAS E
                                    LEFT JOIN DOCUMENTOS D ON E.CIF =  D.CIF
                                    LEFT JOIN ESTADOS_EMPRESAS ES ON E.ID_ESTADO = ES.ID
                                    WHERE E.ID_ESTADO = @ID_ESTADO AND ID_CLIENTE = @ID_CLIENTE AND D.ID_TIPO IN (1,2) AND D.ID_ESTADO BETWEEN 1 AND 4
                                    GROUP BY E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD
                                    ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC", connection)

        searchQuery.Parameters.AddWithValue("@ID_ESTADO", DbNullOrStringValue(cb_Estado.SelectedValue))
        searchQuery.Parameters.AddWithValue("@ID_CLIENTE", DbNullOrStringValue(CB_cliente.SelectedValue))

        Dim adapter As New MySqlDataAdapter(searchQuery)
        Dim table As New DataTable()
        adapter.Fill(table)
        DGV_Empresas.DataSource = table

    End Sub

    Private Sub tbTelefono_TextChanged(sender As Object, e As EventArgs) Handles tbTelefono.TextChanged
        Try
            Dim specificQuery As New MySqlCommand("SELECT E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD, SUM(SUMA_IVA) AS IVA, ES.NOMBRE AS ESTADO,
                                    (SELECT MAX(FECHA) FROM ACTIVIDADES_EMPRESAS WHERE ID_EMPRESA = E.ID) AS ULTIMA_ACTIVIDAD
                                    FROM EMPRESAS E
                                    LEFT JOIN DOCUMENTOS D ON E.CIF =  D.CIF
                                    LEFT JOIN ESTADOS_EMPRESAS ES ON E.ID_ESTADO = ES.ID
                                    WHERE TELEFONO LIKE '%" & tbTelefono.Text & "%'
                                    GROUP BY E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD
                                    ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC", connection)

            Dim adapter As New MySqlDataAdapter(specificQuery)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Empresas.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbCIF_TextChanged(sender As Object, e As EventArgs) Handles tbCIF.TextChanged
        Try
            Dim specificQuery As New MySqlCommand("SELECT E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD, SUM(SUMA_IVA) AS IVA, ES.NOMBRE AS ESTADO,
                                    (SELECT MAX(FECHA) FROM ACTIVIDADES_EMPRESAS WHERE ID_EMPRESA = E.ID) AS ULTIMA_ACTIVIDAD
                                    FROM EMPRESAS E
                                    LEFT JOIN DOCUMENTOS D ON E.CIF =  D.CIF
                                    LEFT JOIN ESTADOS_EMPRESAS ES ON E.ID_ESTADO = ES.ID
                                    WHERE E.CIF LIKE '%" & tbCIF.Text & "%'
                                    GROUP BY E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD
                                    ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC", connection)

            Dim adapter As New MySqlDataAdapter(specificQuery)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Empresas.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbComercial_TextChanged(sender As Object, e As EventArgs) Handles tbComercial.TextChanged
        Try
            Dim specificQuery As New MySqlCommand("SELECT E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD, SUM(SUMA_IVA) AS IVA, ES.NOMBRE AS ESTADO,
                                    (SELECT MAX(FECHA) FROM ACTIVIDADES_EMPRESAS WHERE ID_EMPRESA = E.ID) AS ULTIMA_ACTIVIDAD
                                    FROM EMPRESAS E
                                    LEFT JOIN DOCUMENTOS D ON E.CIF =  D.CIF
                                    LEFT JOIN ESTADOS_EMPRESAS ES ON E.ID_ESTADO = ES.ID
                                    WHERE NOMBRE_COMERCIAL LIKE '%" & tbComercial.Text & "%'
                                    GROUP BY E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD
                                    ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC", connection)

            Dim adapter As New MySqlDataAdapter(specificQuery)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Empresas.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbFiscal_TextChanged(sender As Object, e As EventArgs) Handles tbFiscal.TextChanged
        Try
            Dim specificQuery As New MySqlCommand("SELECT E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD, SUM(SUMA_IVA) AS IVA, ES.NOMBRE AS ESTADO,
                                    (SELECT MAX(FECHA) FROM ACTIVIDADES_EMPRESAS WHERE ID_EMPRESA = E.ID) AS ULTIMA_ACTIVIDAD
                                    FROM EMPRESAS E
                                    LEFT JOIN DOCUMENTOS D ON E.CIF =  D.CIF
                                    LEFT JOIN ESTADOS_EMPRESAS ES ON E.ID_ESTADO = ES.ID
                                    WHERE NOMBRE_FISCAL LIKE '%" & tbFiscal.Text & "%'
                                    GROUP BY E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD
                                    ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC", connection)

            Dim adapter As New MySqlDataAdapter(specificQuery)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Empresas.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim revQuery As New MySqlCommand("SELECT E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD, SUM(SUMA_IVA) AS IVA, ES.NOMBRE AS ESTADO,
                                    (SELECT MAX(FECHA) FROM ACTIVIDADES_EMPRESAS WHERE ID_EMPRESA = E.ID) AS ULTIMA_ACTIVIDAD
                                    FROM EMPRESAS E
                                    LEFT JOIN DOCUMENTOS D ON E.CIF =  D.CIF
                                    LEFT JOIN ESTADOS_EMPRESAS ES ON E.ID_ESTADO = ES.ID
                                    WHERE E.ID_ESTADO = @ID_ESTADO AND ID_CLIENTE = @ID_CLIENTE AND D.ID_TIPO IN (1,2) AND D.ID_ESTADO = 2
                                    GROUP BY E.ID, E.CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, E.TELEFONO, E.EMAIL, E.LOCALIDAD
                                    ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC", connection)

        revQuery.Parameters.AddWithValue("@ID_ESTADO", DbNullOrStringValue(cb_Estado.SelectedValue))
        revQuery.Parameters.AddWithValue("@ID_CLIENTE", DbNullOrStringValue(CB_cliente.SelectedValue))

        Dim adapter As New MySqlDataAdapter(revQuery)
        Dim table As New DataTable()
        adapter.Fill(table)
        DGV_Empresas.DataSource = table
    End Sub
End Class
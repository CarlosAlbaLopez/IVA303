Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.Mail
Imports iTextSharp.text
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports WinSCP

Public Class Clientes

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim sessionOptions As New SessionOptions
    Dim rs As New Resizer

    Public Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

        Dim searchQuery As String = "SELECT C.ID, NOMBRE_FISCAL, NOMBRE_COMERCIAL, SUM(SUMA_IVA) AS IVA
                                    FROM CLIENTES C
                                    LEFT JOIN DOCUMENTOS D ON C.ID =  D.ID_CLIENTE
                                    WHERE D.ID_TIPO IN (3, 4) AND D.ID_ESTADO = 6 AND ACTIVO = 'SI'
                                    GROUP BY C.ID, NOMBRE_FISCAL, NOMBRE_COMERCIAL
                                    ORDER BY SUM(SUMA_IVA) DESC, NOMBRE_FISCAL DESC"

        Dim command As New MySqlCommand(searchQuery, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DGV_Clientes.AllowUserToAddRows = False

        DGV_Clientes.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DGV_Clientes.DataSource = table

    End Sub

    Public Sub OBTENER_ID_DOCUMENTOS_PARA_EXPORTAR()

        Dim i = DGV_Clientes.CurrentRow.Index
        Dim j = 0
        Dim id_cliente = DGV_Clientes.Item(j, i).Value

        Dim OBTENER_IDS As New MySqlCommand("SELECT ID FROM DOCUMENTOS D WHERE D.ID_CLIENTE = @ID_CLIENTE and D.ID_ESTADO = 2", connection)
        Dim OBTENER_RUTAS As New MySqlCommand("SELECT RUTA FROM DOCUMENTOS WHERE ID = @ID", connection)
        Dim updateQuery As New MySqlCommand("UPDATE DOCUMENTOS SET ID_ESTADO = 3 WHERE ID = @ID", connection)

        OBTENER_IDS.Parameters.AddWithValue("@ID", DbNullOrStringValue(id_cliente))

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

        Dim nombrecarpeta As String = "C:\Remesas Empresas\" & DGV_Clientes.Item(j + 4, i).Value

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

    Private Sub BTN_ALTA_Click(sender As Object, e As EventArgs) Handles Button2.Click

        AltaCliente.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DownloadInvoices()

        ExportToExcel()

        UpdateDocsState()

        MsgBox("Operación completada, baby.")

    End Sub

    Private Sub UpdateDocsState()

        Dim result As Integer = MessageBox.Show("¿Facturas enviadas?", "Pollo a la brasa", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim i = DGV_Clientes.CurrentRow.Index
            Dim j = 0
            Dim id = DGV_Clientes.Item(j, i).Value

            Dim sqUpdateDocsState As New MySqlCommand("UPDATE DOCUMENTOS
                                                  SET ID_ESTADO = 7
                                                  WHERE ID_CLIENTE = @ID_CLIENTE AND
                                                  ID_TIPO IN (3, 4) AND
                                                  ID_ESTADO = 6", connection)

            sqUpdateDocsState.Parameters.AddWithValue("@ID_CLIENTE", DbNullOrStringValue(id))

            connection.Open()
            sqUpdateDocsState.ExecuteNonQuery()
            connection.Close()
        End If

    End Sub

    Public Sub DownloadInvoices()

        Dim i = DGV_Clientes.CurrentRow.Index
        Dim j = 0
        Dim id = DGV_Clientes.Item(j, i).Value

        Dim Fileslist2 As String() = Directory.GetFiles("C:\control303\")
        For Each item2 As String In Fileslist2
            System.IO.File.Delete(item2)
        Next

        Dim sqCLIENTE As New MySqlCommand("SELECT NOMBRE_FISCAL,
                                        CONCAT_WS( ' ',REPLACE(T.NOMBRE, '\r', ''), C.NOMBRE_VIA, C.NUMERO_VIA, C.PISO, C.LETRA_PISO) AS DIRECCION, 
                                        LOCALIDAD, PROVINCIA, CP, PAIS, CIF, NOMBRE_COMERCIAL
                                        FROM CLIENTES C
                                        LEFT JOIN TIPOS_VIAS T ON C.ID_TIPO_VIA = T.ID
                                        WHERE C.ID = @ID", connection)

        sqCLIENTE.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
        Dim empresasadapter As New MySqlDataAdapter(sqCLIENTE)
        Dim empresastable As New DataTable()
        empresasadapter.Fill(empresastable)


        Dim sqDOCUMENTOS As New MySqlCommand("SELECT D.ID, D.RUTA, D.REFERENCIA, D.FECHA, D.SUMA_BASE, D.SUMA_TOTAL, D.ID_CLIENTE, C.NOMBRE_FISCAL,
                                            CONCAT_WS( ' ',REPLACE(T.NOMBRE, '\r', ''), C.NOMBRE_VIA, C.NUMERO_VIA, C.PISO, C.LETRA_PISO) AS DIRECCION, 
                                            C.LOCALIDAD, C.PROVINCIA, C.CP, C.PAIS, C.CIF, D.ID_TIPO, C.NOMBRE_COMERCIAL
                                            FROM DOCUMENTOS D
                                            LEFT JOIN CLIENTES C ON D.ID_CLIENTE = C.ID
                                            LEFT JOIN TIPOS_VIAS T ON C.ID_TIPO_VIA = T.ID
                                            WHERE D.ID_TIPO IN (3, 4) AND D.ID_CLIENTE = (SELECT ID FROM CLIENTES WHERE ID = @ID) AND D.ID_ESTADO = 6", connection)


        sqDOCUMENTOS.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
        Dim documentosadapter As New MySqlDataAdapter(sqDOCUMENTOS)
        Dim documentostable As New DataTable()
        documentosadapter.Fill(documentostable)

        Dim totalDocs = documentostable.Rows.Count - 1

        My.Computer.FileSystem.CreateDirectory("C:\ENVIOS\" & empresastable.Rows(0)("NOMBRE_COMERCIAL"))

        For y = 0 To totalDocs
            Dim RUTAKA As String = documentostable.Rows(y)("RUTA").ToString()
            ' COPY the file.

            Dim RUTAKA2 As String = "C:\ENVIOS\" & empresastable.Rows(0)("NOMBRE_COMERCIAL") & documentostable.Rows(y)("RUTA").ToString()
            File.Copy("S:\img\" & RUTAKA, RUTAKA2)

        Next

    End Sub

    Public Sub ExportToExcel()

        Dim i = DGV_Clientes.CurrentRow.Index
        Dim j = 0
        Dim id = DGV_Clientes.Item(j, i).Value

        Dim sqExcel As New MySqlCommand("select D.ID AS ID_IVA303, D.FECHA, D.REFERENCIA, D.SUMA_BASE AS BASE, D.SUMA_IVA AS IVA, D.SUMA_TOTAL AS TOTAL, E.NOMBRE_FISCAL, E.CIF,
                                        CONCAT_WS( ' ',REPLACE(T.NOMBRE, '\r', ''), E.NOMBRE_VIA, E.NUMERO_VIA, E.PISO, E.LETRA_PISO) AS DIRECCION, E.CP,
                                        E.LOCALIDAD, E.PROVINCIA
                                        from DOCUMENTOS D
                                        LEFT JOIN CLIENTES C ON D.ID_CLIENTE = C.ID
                                        LEFT JOIN EMPRESAS E ON D.CIF = E.CIF
                                        LEFT JOIN TIPOS_VIAS T ON E.ID_TIPO_VIA = T.ID
                                        WHERE C.ID = @ID AND D.ID_TIPO IN (3, 4) AND D.ID_ESTADO = 6", connection)

        sqExcel.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
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

        xlworkbook.SaveAs("FICHERO_CONTABLE" & ".xlsx")
        xlworkbook.Close(SaveChanges:=True)

        xlapp.Quit()

        Myobject(xlapp)
        Myobject(xlworkbook)
        Myobject(xlworksheet)

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

End Class
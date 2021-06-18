Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports WinSCP

Public Class SendEmails

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim sessionOptions As New SessionOptions
    Private Sub SendEmails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With sessionOptions
            .Protocol = Protocol.Sftp
            .HostName = "192.168.0.178"
            .UserName = "root"
            .Password = "Iverson.3$iva"
            .SshHostKeyFingerprint = "ssh-ed25519 256 e3:69:af:9b:52:97:03:13:0a:0c:60:ef:47:7f:39:67"
        End With
    End Sub

    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mailQuery As New MySqlCommand("SELECT * FROM EMPRESAS WHERE ID_ESTADO = 7", connection)
        Dim mailAdapter As New MySqlDataAdapter(mailQuery)
        Dim mailTable As New DataTable()
        mailAdapter.Fill(mailTable)

        Dim totalEmpresas As Integer
        totalEmpresas = mailTable.Rows.Count - 1
        For y = 0 To totalEmpresas
            Dim idEmpresa As String = mailTable.Rows(y)("ID").ToString
            GenerateAccord(idEmpresa)
            GenerateInvoices(idEmpresa)
            ExportToExcel(idEmpresa)
            GenerateEmail(idEmpresa)
            UpdateEmpresasState(idEmpresa)
            UpdateDocsState(idEmpresa)
        Next
    End Sub

    Public Sub GenerateAccord(id As String)

        Dim sqEMPRESA As New MySqlCommand("SELECT NOMBRE_FISCAL, CIF, EMAIL, NOMBRE_COMERCIAL
                                           FROM EMPRESAS E 
                                           LEFT JOIN TIPOS_VIAS T ON E.ID_TIPO_VIA = T.ID
                                           WHERE E.ID = @ID", connection)

        sqEMPRESA.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
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

    Public Sub GenerateInvoices(id As String)

        Dim Fileslist2 As String() = Directory.GetFiles("C:\control303\")
        For Each item2 As String In Fileslist2
            System.IO.File.Delete(item2)
        Next

        Dim sqEMPRESA As New MySqlCommand("SELECT NOMBRE_FISCAL,
                                        CONCAT_WS( ' ',REPLACE(T.NOMBRE, '\r', ''), E.NOMBRE_VIA, E.NUMERO_VIA, E.PISO, E.LETRA_PISO) AS DIRECCION, 
                                        LOCALIDAD, PROVINCIA, CP, PAIS, CIF, NOMBRE_COMERCIAL
                                        FROM EMPRESAS E 
                                        LEFT JOIN TIPOS_VIAS T ON E.ID_TIPO_VIA = T.ID
                                        WHERE E.ID = @ID", connection)

        sqEMPRESA.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
        Dim empresasadapter As New MySqlDataAdapter(sqEMPRESA)
        Dim empresastable As New DataTable()
        empresasadapter.Fill(empresastable)
        Dim CIF = empresastable.Rows(0)("CIF").ToString


        Dim sqDOCUMENTOS As New MySqlCommand("SELECT D.ID, D.RUTA, D.REFERENCIA, D.FECHA, D.SUMA_BASE, D.SUMA_TOTAL, D.ID_CLIENTE, C.NOMBRE_FISCAL,
                                            CONCAT_WS( ' ',REPLACE(T.NOMBRE, '\r', ''), C.NOMBRE_VIA, C.NUMERO_VIA, C.PISO, C.LETRA_PISO) AS DIRECCION, 
                                            C.LOCALIDAD, C.PROVINCIA, C.CP, C.PAIS, C.CIF, D.ID_TIPO, C.NOMBRE_COMERCIAL
                                            FROM DOCUMENTOS D
                                            LEFT JOIN CLIENTES C ON D.ID_CLIENTE = C.ID
                                            LEFT JOIN TIPOS_VIAS T ON C.ID_TIPO_VIA = T.ID
                                            WHERE D.ID_TIPO IN (1, 2) AND D.CIF = @CIF AND D.ID_ESTADO = 3", connection)


        sqDOCUMENTOS.Parameters.AddWithValue("@CIF", DbNullOrStringValue(CIF))
        Dim documentosadapter As New MySqlDataAdapter(sqDOCUMENTOS)
        Dim documentostable As New DataTable()
        documentosadapter.Fill(documentostable)


        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim totalDocs = documentostable.Rows.Count - 1

        For y = 0 To totalDocs

            Dim sqUltimaaFactura As New MySqlCommand("SELECT ULTIMA_FACTURA FROM EMPRESAS
                                                    WHERE ID = @ID", connection)

            sqUltimaaFactura.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
            Dim ultimafactadapter As New MySqlDataAdapter(sqUltimaaFactura)
            Dim ultimafacttable As New DataTable()
            ultimafactadapter.Fill(ultimafacttable)

            Dim docName As String = documentostable.Rows(y)("NOMBRE_COMERCIAL").ToString() & documentostable.Rows(y)("RUTA").ToString() & ".docx"

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
            If CIF = "A15022650" Then
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
                                                        WHERE ID = @ID", connection)

            updateUltimaFactura.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
            connection.Open()


            ''EJECUCION DE UPDATE ULTIMA FACTURA COMENTADO PARA PRUEBAS
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

            Shell("cmd.exe /c mogrify -path C:\control303\ -format tif -density 300 -resize 1300x1600 C:\control303\*.pdf",, True)

            'METER EL TIF EN EL WORD Y CERRARLO GUARDANDOLO EN CARPETA PREDETERMINADA DE WORD, QUE SEÑALA A C:\Users\.net\Desktop\ENVIOS\

            Dim ruta As String = documentostable.Rows(y)("RUTA").ToString()
            Dim sinruta As String = ruta.Replace("pdf", "tif")

            ''oDoc.Bookmarks.Item("bmIMAGE").Range.InsertFile("C:\control303\" & sinruta & "png")

            oDoc.Tables(1).Rows(15).Cells(1).Range.InlineShapes.AddPicture(FileName:="C:\control303\" & sinruta, LinkToFile:=False, SaveWithDocument:=True)

            oDoc.SaveAs2(docName)
            oDoc.Close()

            'BORRAR CONTENIDOS DE CARPETA C:\control303\

            'If System.IO.File.Exists("C:\control303\" & "*.*") = True Then

            'System.IO.File.Delete("C:\control303\")

            Dim Fileslist As String() = Directory.GetFiles("C:\control303\")
            For Each item As String In Fileslist
                System.IO.File.Delete(item)
            Next

            'End If

            Myobject(oDoc)
            Myobject(oWord)

            'CREA CARPETA CON NOMBRE COMERCIAL CLIENTE EN C:\Users\.net\Desktop\ENVIOS\ Y MUEVE EL ARCHIVO DENTRO

            Dim newPath2 As String = "C:\ENVIOS\" & empresastable.Rows(0)("NOMBRE_COMERCIAL").ToString()

            System.IO.Directory.CreateDirectory(newPath2)

            File.Move("C:\ENVIOS\" & docName, newPath2 & "\" & docName)

        Next
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

    Public Sub ExportToExcel(id As String)

        Dim findCIF As New MySqlCommand("SELECT CIF FROM EMPRESAS WHERE ID = @ID", connection)
        findCIF.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
        Dim findCIFAdapter As New MySqlDataAdapter(findCIF)
        Dim findCIFDT As New DataTable
        findCIFAdapter.Fill(findCIFDT)

        Dim sqExcel As New MySqlCommand("select D.ID AS ID_IVA303, C.NOMBRE_FISCAL AS CLIENTE, C.CIF AS CIF,
                                        CONCAT_WS( ' ',REPLACE(T.NOMBRE, '\r', ''), C.NOMBRE_VIA, C.NUMERO_VIA, C.PISO, C.LETRA_PISO) AS DOMICILIO_SOCIAL,
                                        C.LOCALIDAD, C.PROVINCIA, D.FECHA, D.REFERENCIA, D.SUMA_BASE AS BASE, D.SUMA_IVA AS IVA, D.SUMA_TOTAL AS TOTAL, E.NOMBRE_COMERCIAL AS EMPRESA
                                        from DOCUMENTOS D
                                        LEFT JOIN CLIENTES C ON D.ID_CLIENTE = C.ID
                                        LEFT JOIN EMPRESAS E ON D.CIF = E.CIF
                                        LEFT JOIN TIPOS_VIAS T ON C.ID_TIPO_VIA = T.ID
                                        WHERE D.CIF = @CIF AND D.ID_TIPO IN (1, 2) AND D.ID_ESTADO = 3", connection)

        sqExcel.Parameters.AddWithValue("@CIF", DbNullOrStringValue(findCIFDT.Rows(0)("CIF").ToString))
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
    End Sub

    Public Sub GenerateEmail(id As String)
        Dim sqEMPRESA As New MySqlCommand("SELECT EMAIL, NOMBRE_COMERCIAL FROM EMPRESAS
                                           WHERE ID = @ID", connection)

        sqEMPRESA.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
        Dim empresasadapter As New MySqlDataAdapter(sqEMPRESA)
        Dim empresastable As New DataTable()
        empresasadapter.Fill(empresastable)
        Dim emailEmpresa = empresastable.Rows(0)("EMAIL").ToString()

        Dim Smtp_Server As New SmtpClient
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New Net.NetworkCredential("administracion@iva303.es", "63JDxjp2")
        Smtp_Server.Port = 25
        Smtp_Server.EnableSsl = True
        Smtp_Server.Host = "mail.iva303.es"

        e_mail = New MailMessage()
        e_mail.From = New MailAddress("administracion@iva303.es")
        e_mail.To.Add(emailEmpresa)
        e_mail.CC.Add("administracion@iva303.es")
        e_mail.Subject = "Petición facturas para recuperar IVA"
        e_mail.IsBodyHtml = False
        e_mail.Body = "Buenos días,

Tras lo acordado por teléfono, adjunto los tickets de nuestro cliente, para los que solicitamos factura de canje y así poder recuperar el IVA de estos gastos.

Hemos preparado un borrador de cada factura por si les es más cómodo que hacerlas a mano. Si es así, no habría más que devolvernos el ACUERDO adjunto firmado o sellado, y archivar las facturas.

En caso contrario, la imagen de cada de ticket y los datos de nuestro cliente están dentro de cada factura. La factura de canje debe emitirse a fecha actual, haciendo referencia a la fecha del ticket, y con una numeración diferente a la habitual.

Si necesitas más información, quedamos a tu disposición.

Un saludo,

IVA303 - Dpto. Peticiones."
        Dim MyFile As String
        Dim Counter As Long

        'Create a dynamic array variable, and then declare its initial size
        Dim DirectoryListArray() As String
        ReDim DirectoryListArray(1000)

        'Loop through all the files in the directory by using Dir$ function
        MyFile = Dir$("c:\ENVIOS\" & empresastable.Rows(0)("NOMBRE_COMERCIAL").ToString() & "\")
        Do While MyFile <> ""
            DirectoryListArray(Counter) = MyFile
            MyFile = Dir$()
            Counter = Counter + 1
        Loop

        'Reset the size of the array without losing its values by using Redim Preserve 
        ReDim Preserve DirectoryListArray(Counter - 1)

        For Each item As String In DirectoryListArray
            Dim docPath As String = Path.GetFileName(item)
            Dim fullPath As String = "c:\ENVIOS\" & empresastable.Rows(0)("NOMBRE_COMERCIAL").ToString() & "\" & docPath
            Dim attachment = New Attachment(fullPath)
            e_mail.Attachments.Add(attachment)
        Next

        ServicePointManager.ServerCertificateValidationCallback = Function(s As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) True
        Smtp_Server.Send(e_mail)
    End Sub

    Public Sub UpdateEmpresasState(id As String)
        Dim updateEmpresaQuery As New MySqlCommand("UPDATE EMPRESAS SET ID_ESTADO = 2 WHERE ID = @ID", connection)
        updateEmpresaQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
        connection.Open()
        updateEmpresaQuery.ExecuteNonQuery()
        connection.Close()

        Dim registerActivity As New MySqlCommand("INSERT INTO ACTIVIDADES_EMPRESAS (ID_EMPRESA, TIPO, FECHA, INFO)
                                                  VALUES (@ID_EMPRESA, @TIPO, @FECHA, @INFO)", connection)
        registerActivity.Parameters.AddWithValue("@ID_EMPRESA", DbNullOrStringValue(id))
        registerActivity.Parameters.AddWithValue("@TIPO", DbNullOrStringValue("Envío mail"))
        registerActivity.Parameters.AddWithValue("@FECHA", DbNullOrStringValue(String.Format("{0:dd/MM/yyyy}", DateTime.Now)))
        registerActivity.Parameters.AddWithValue("@INFO", DbNullOrStringValue("ENVIO PETICION AUTO"))
        connection.Open()
        registerActivity.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub UpdateDocsState(id As String)
        Dim findCIF As New MySqlCommand("SELECT CIF FROM EMPRESAS WHERE ID = @ID", connection)
        findCIF.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
        Dim findCIFAdapter As New MySqlDataAdapter(findCIF)
        Dim findCIFDT As New DataTable
        findCIFAdapter.Fill(findCIFDT)

        Dim sqUpdateDocsState As New MySqlCommand("UPDATE DOCUMENTOS
                                                SET ID_ESTADO = 4
                                                WHERE CIF = @CIF AND
                                                ID_TIPO IN (1, 2) AND
                                                ID_ESTADO = 3", connection)

        sqUpdateDocsState.Parameters.AddWithValue("@CIF", DbNullOrStringValue(findCIFDT.Rows(0)("CIF").ToString))

        connection.Open()
        sqUpdateDocsState.ExecuteNonQuery()
        connection.Close()
    End Sub
End Class
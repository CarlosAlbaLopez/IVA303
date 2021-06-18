Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Linq
Imports iTextSharp.text.pdf
Imports iTextSharp.text

Public Class C_Empresas

    Public Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateDatagridview()
    End Sub

    Public Sub populateDatagridview()

        Dim connection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")

        Dim searchQuery As String = "SELECT e.ID, CIF, g.NOMBRE as GRUPO, NOMBRE_FISCAL, NOMBRE_COMERCIAL, ID_TIPO_VIA, NOMBRE_VIA, NUMERO_VIA, PISO, LETRA_PISO, PROVINCIA, LOCALIDAD, PAIS, CP, E.TELEFONO, E.EMAIL, WEB 
                                        From CCPP_EMPRESAS e
                                        left join GRUPOS_EMPRESAS g on e.ID_GRUPO = g.NOMBRE
                                        LEFT JOIN TIPOS_VIAS TV ON E.ID_TIPO_VIA = TV.ID"

        Dim command As New SqlCommand(searchQuery, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False

        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn
        DataGridView1.DataSource = table

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C_AltaEmpresa.Show()
    End Sub

    Public Sub OBTENER_ID_DOCUMENTOS_PARA_EXPORTAR()

        Dim i = DataGridView1.CurrentRow.Index
        Dim j = 0
        Dim connection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")
        Dim OBTENER_IDS As New SqlCommand("SELECT ID FROM CCPP_DOCUMENTOS D WHERE D.CIF = @CIF and d.ID_ESTADO = 2", connection)
        Dim OBTENER_RUTAS As New SqlCommand("SELECT RUTA FROM CCPP_DOCUMENTOS WHERE ID = @ID", connection)
        Dim updateQuery As New SqlCommand("UPDATE CCPP_DOCUMENTOS SET ID_ESTADO = 3 WHERE ID = @ID", connection)

        OBTENER_IDS.Parameters.Add("@CIF", SqlDbType.VarChar).Value = DataGridView1.Item(j + 1, i).Value

        Dim adapter As New SqlDataAdapter(OBTENER_IDS)
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

        Dim adapter2 As New SqlDataAdapter(OBTENER_RUTAS)
        Dim tabla_rutas As New DataTable()


        For Each _id In ID.ToArray
            'MsgBox(_id)
            OBTENER_RUTAS.Parameters.Clear()
            OBTENER_RUTAS.Parameters.Add("@ID", SqlDbType.Int).Value = _id
            OBTENER_RUTAS.ExecuteNonQuery()
            adapter2.Fill(tabla_rutas)
            updateQuery.Parameters.Clear()
            updateQuery.Parameters.Add("@ID", SqlDbType.Int).Value = _id
            updateQuery.ExecuteNonQuery()
        Next

        Dim RUTA() As String
        Dim totalRUTAS As Integer
        Dim nueva_ruta() As String
        Dim PDFfile As New Document


        Dim nombrecarpeta As String = "C:\Users\.net\Desktop\Remesas Empresas CCPP\" & DataGridView1.Item(j + 4, i).Value

        Directory.CreateDirectory(nombrecarpeta)



        'Count the number of rows
        totalRUTAS = table_ids.Rows.Count - 1

        ReDim RUTA(0 To totalRUTAS)
        ReDim nueva_ruta(0 To totalRUTAS)

        For i = 0 To totalRUTAS
            RUTA(i) = tabla_rutas.Rows(i)(0)
            nueva_ruta(i) = nombrecarpeta & "/" & Strings.Mid(RUTA(i), 8)
            'Dim createPDF As PdfWriter = PdfWriter.GetInstance(PDFfile, New FileStream(nueva_ruta(i).ToString,
            '                                            FileMode.Create))
            ExtractPdfPage(RUTA(i), 1, nueva_ruta(i))
        Next

        connection.Close()

    End Sub

    Public Overloads Shared Sub ExtractPdfPage(ByVal sourcepdf As String, ByVal pageNumberToExtract As Integer, ByVal outPdf As String)
        Dim reader As iTextSharp.text.pdf.PdfReader = Nothing
        Dim doc As iTextSharp.text.Document = Nothing
        'Dim doc As PdfManipulation.DocumentEx = Nothing
        Dim pdfCpy As iTextSharp.text.pdf.PdfCopy = Nothing
        Dim page As iTextSharp.text.pdf.PdfImportedPage = Nothing
        Try
            reader = New iTextSharp.text.pdf.PdfReader(sourcepdf)
            doc = New iTextSharp.text.Document(reader.GetPageSizeWithRotation(1))
            'doc = New PdfManipulation.DocumentEx(reader.GetPageSizeWithRotation(pageNumberToExtract))
            'Debug.WriteLine("Add producer: " & doc.AddProducer().ToString)
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
        OBTENER_ID_DOCUMENTOS_PARA_EXPORTAR()

    End Sub

End Class
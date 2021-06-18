'Imports System.Data.SqlClient
'Imports System.IO

'Public Class EnviosProveedor

'    Private Sub C_Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        Dim connection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")
'        Dim cmdTiposDoc As New SqlCommand("select * from TIPOS_DOCUMENTOS where ID in (2,3,4,5)", connection)

'        Dim adpTiposDoc As New SqlDataAdapter(cmdTiposDoc)
'        Dim tblTiposDoc As New DataTable()

'        adpTiposDoc.Fill(tblTiposDoc)

'        'Desplegable Tipo_Documento almacena id_tipo_documentos y muestra nombres asociados
'        CBX_TIPOS_DOC.DataSource = tblTiposDoc
'        CBX_TIPOS_DOC.DisplayMember = "NOMBRE"
'        CBX_TIPOS_DOC.ValueMember = "ID"

'        DataGridView1.DataSource = Fileinfo_To_DataTable("C:\SCAN\")

'    End Sub

'    Dim connection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")

'    Private Sub CBX_CLIENTES_LOAD(sender As Object, e As EventArgs) Handles MyBase.Load

'        Dim connection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")
'        Dim command As New SqlCommand("select * from CCPP_CLIENTES", connection)
'        Dim adapter As New SqlDataAdapter(command)
'        Dim table As New DataTable()

'        adapter.Fill(table)

'        CBX_CLIENTES.DataSource = table
'        CBX_CLIENTES.DisplayMember = "NOMBRE_FISCAL"
'        CBX_CLIENTES.ValueMember = "ID"

'        If CBX_CLIENTES.Items.Count > 0 Then
'            CBX_CLIENTES.SelectedIndex = 0    ' The first item has index 0 '
'        End If

'    End Sub

'    Private Sub CBX_LOCALES_LOAD(sender As Object, e As EventArgs) Handles MyBase.Load

'        Dim connection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")
'        Dim cmdLocales As New SqlCommand("select ID, NOMBRE_LOCAL from CCPP_LOCALES", connection)
'        Dim adpLocales As New SqlDataAdapter(cmdLocales)
'        Dim tblLocales As New DataTable()

'        adpLocales.Fill(tblLocales)

'        CBX_LOCALES.DataSource = tblLocales
'        CBX_LOCALES.DisplayMember = "NOMBRE_LOCAL"
'        CBX_LOCALES.ValueMember = "ID"

'    End Sub

'    Private Sub BTN_INSER_Click(sender As Object, e As EventArgs) Handles Button2.Click

'        Dim MyFile As String
'        Dim Counter As Long

'        'Create a dynamic array variable, and then declare its initial size
'        Dim DirectoryListArray() As String
'        ReDim DirectoryListArray(1000)

'        'Loop through all the files in the directory by using Dir$ function
'        MyFile = Dir$("c:\SCAN\")
'        Do While MyFile <> ""
'            DirectoryListArray(Counter) = MyFile
'            MyFile = Dir$()
'            Counter = Counter + 1
'        Loop

'        'Reset the size of the array without losing its values by using Redim Preserve 
'        ReDim Preserve DirectoryListArray(Counter - 1)

'        connection.Open()

'        For Each item As String In DirectoryListArray

'            Dim IMAGEPATH As String = Path.GetFileName(item)

'            Dim directoryPath As String = Path.GetDirectoryName(item)

'            Dim SourceDirectory As String = directoryPath
'            Dim SaveDirectory As String = item
'            Dim LatestFile As IO.FileInfo = Nothing

'            System.IO.File.Copy("C:\SCAN\" & IMAGEPATH, "C:\303\" & IMAGEPATH)

'            Dim command As New SqlCommand("insert into CCPP_DOCUMENTOS(ID_CLIENTE,CIF,ID_LOCAL,ID_TIPO,ID_ESTADO,FECHA_ALTA,RUTA)
'                                           values(@ID_CLIENTE,@CIF,@ID_LOCAL,@ID_TIPO,@ID_ESTADO,@FECHA_ALTA,@RUTA)", connection)

'            Dim ms As New MemoryStream

'            command.Parameters.Add("@ID_CLIENTE", SqlDbType.TinyInt).Value = CBX_CLIENTES.SelectedValue
'            command.Parameters.Add("@CIF", SqlDbType.VarChar).Value = TBEMPRESA.Text
'            command.Parameters.Add("@ID_LOCAL", SqlDbType.TinyInt).Value = CBX_CLIENTES.SelectedValue
'            command.Parameters.Add("@ID_TIPO", SqlDbType.TinyInt).Value = CBX_TIPOS_DOC.SelectedValue
'            command.Parameters.Add("@ID_ESTADO", SqlDbType.TinyInt).Value = "1"
'            command.Parameters.Add("@FECHA_ALTA", SqlDbType.Date).Value = Today
'            command.Parameters.Add("@RUTA", SqlDbType.VarChar).Value = "C:\303\" & item

'            command.ExecuteNonQuery()

'            System.IO.File.Delete("C:\SCAN\" & IMAGEPATH)

'        Next
'    End Sub

'    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

'        Dim index As Integer

'        ' get the index of the selected datagridview row
'        index = e.RowIndex

'        Dim selectedRow As DataGridViewRow
'        selectedRow = DataGridView1.Rows(index)

'        ' now show data from the selected row to textboxes

'        Try
'            AxAcroPDF1.LoadFile("C:\SCAN\" & selectedRow.Cells(0).Value.ToString())
'        Catch ex As Exception
'            MessageBox.Show(ex.Message)
'        End Try

'    End Sub

'    'Actualiza DataGridView1
'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

'        Fileinfo_To_DataTable("C:\SCAN\")
'        DataGridView1.DataSource = Fileinfo_To_DataTable("C:\SCAN\")

'    End Sub

'    'No funciona xq la funcion carpeta_datagridview tiene las imágenes almacenadas en una datatable (dt)
'    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

'        AxAcroPDF1.LoadFile(Nothing)
'        Kill("C:\SCAN\*.jpg")
'        DataGridView1.DataSource = Fileinfo_To_DataTable("C:\SCAN\")

'    End Sub

'    'Public Sub BuscaDocumentosaCanjear()

'    '    Dim BuscaDocumentosaCanjear As New SqlCommand("SELECT * FROM CCPP_DOCUMENTOS WHERE CIF = @CIF AND ID_ESTADO = 3 AND ID_CLIENTE = @CLIENTE", connection)
'    '    Dim adapter As New SqlDataAdapter(BuscaDocumentosaCanjear)
'    '    Dim table As New DataTable()
'    '    Dim RowsReturned As Integer

'    '    BuscaDocumentosaCanjear.Parameters.Add("@CIF", SqlDbType.VarChar).Value = TBEMPRESA.Text
'    '    BuscaDocumentosaCanjear.Parameters.Add("@CLIENTE", SqlDbType.Int).Value = CBX_CLIENTES.SelectedValue
'    '    BuscaDocumentosaCanjear.ExecuteNonQuery()
'    '    BuscaDocumentosaCanjear.CommandType = CommandType.Text

'    '    adapter.Fill(table)

'    '    RowsReturned = BuscaDocumentosaCanjear.ExecuteScalar()

'    '    If RowsReturned = 0 Then
'    '        MsgBox("Error fatal")
'    '    Else
'    '        Cruce.Show()
'    '    End If

'    '    connection.Close()

'    'End Sub

'End Class
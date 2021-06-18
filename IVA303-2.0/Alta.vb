Imports System.IO
'Imports iTextSharp.text.pdf
Imports MySql.Data.MySqlClient
Imports WinSCP
Imports Org.BouncyCastle.Crypto
'Imports Org.BouncyCastle.Pkcs
'Imports System.Security.Cryptography.X509Certificates
'Imports iTextSharp.text.pdf.security

Public Class mAlta

    Dim rs As New Resizer

    Private Sub Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test")

        Dim command As New MySqlCommand("select * from TIPOS_DOCUMENTOS", connection)

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        'Desplegable Tipo_Documento almacena id_tipo_documentos y muestra nombres asociados
        ComboBox2.DataSource = table
        ComboBox2.DisplayMember = "NOMBRE"
        ComboBox2.ValueMember = "ID"

        DataGridView1.DataSource = Fileinfo_To_DataTable("C:\SCAN\")

        rs.FindAllControls(Me)

    End Sub

    Private Sub Alta_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub ComboBox2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test")

        Dim command As New MySqlCommand("select * from CLIENTES WHERE ACTIVO = 'SI'", connection)

        Dim adapter As New MySqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        ComboBox1.DataSource = table

        ComboBox1.DisplayMember = "NOMBRE_FISCAL"
        ComboBox1.ValueMember = "ID"

    End Sub

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test")

    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Private Sub BTN_INSER_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim MyFile As String
        Dim Counter As Long

        'Create a dynamic array variable, and then declare its initial size
        Dim DirectoryListArray() As String
        ReDim DirectoryListArray(1000)

        'Loop through all the files in the directory by using Dir$ function
        MyFile = Dir$("c:\SCAN\")
        Do While MyFile <> ""
            DirectoryListArray(Counter) = MyFile
            MyFile = Dir$()
            Counter = Counter + 1
        Loop

        'Reset the size of the array without losing its values by using Redim Preserve 
        ReDim Preserve DirectoryListArray(Counter - 1)

        connection.Open()

        For Each item As String In DirectoryListArray

            Dim IMAGEPATH As String = Path.GetFileName(item)

            Dim directoryPath As String = Path.GetDirectoryName(item)

            Dim SourceDirectory As String = directoryPath
        Dim SaveDirectory As String = item
            Dim LatestFile As System.IO.FileInfo = Nothing

            'ssh para subir archivos de c:\scan a /img----------------------------------------------------------------------------------------------------------------------------------------------
            ' Setup session options
            Dim sessionOptions As New SessionOptions
        With sessionOptions
            .Protocol = Protocol.Sftp
            .HostName = "192.168.0.178"
                .UserName = "root"
                .Password = "Iverson.3$iva"
                .SshHostKeyFingerprint = "ssh-ed25519 256 e3:69:af:9b:52:97:03:13:0a:0c:60:ef:47:7f:39:67"
        End With

        Using session As New Session
            ' Connect
            session.Open(sessionOptions)

            ' Upload files
            Dim transferOptions As New TransferOptions
            transferOptions.TransferMode = TransferMode.Binary

            Dim transferResult As TransferOperationResult
            transferResult =
                session.PutFiles("C:\SCAN\" & IMAGEPATH, "/root/img/" & IMAGEPATH, False, transferOptions)

            ' Throw on any error
            transferResult.Check()

            ' Print results
            For Each transfer In transferResult.Transfers
                Console.WriteLine("Upload of {0} succeeded", transfer.FileName)
            Next
        End Using
        'Fin de ssh------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim command As New MySqlCommand("insert into DOCUMENTOS(ID_CLIENTE,ID_TIPO,ID_ESTADO,FECHA_ALTA,RUTA,CAJA,AZ,EMPLEADO,AÑO_CAJA,CIF) values(@ID_CLIENTE,@ID_TIPO,@ID_ESTADO,@FECHA_ALTA,@RUTA,@CAJA,@AZ,@EMPLEADO,@AÑO_CAJA,@CIF)", connection)

        Dim ms As New MemoryStream

        command.Parameters.AddWithValue("@CAJA", DbNullOrStringValue(TextBox1.Text))
        command.Parameters.AddWithValue("@AZ", DbNullOrStringValue(TextBox2.Text))
        command.Parameters.AddWithValue("@EMPLEADO", DbNullOrStringValue(TextBox4.Text))
        command.Parameters.AddWithValue("@AÑO_CAJA", DbNullOrStringValue(TextBox3.Text))
        command.Parameters.AddWithValue("@CIF", DbNullOrStringValue(TBEMPRESA.Text))
        command.Parameters.AddWithValue("@ID_CLIENTE", DbNullOrStringValue(ComboBox1.SelectedValue))
        command.Parameters.AddWithValue("@ID_TIPO", DbNullOrStringValue(ComboBox2.SelectedValue))
        command.Parameters.AddWithValue("@ID_ESTADO", DbNullOrStringValue("1"))
        command.Parameters.AddWithValue("@FECHA_ALTA", DbNullOrStringValue(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")))
        command.Parameters.AddWithValue("@RUTA", DbNullOrStringValue(item))

        command.ExecuteNonQuery()

        System.IO.File.Delete("C:\SCAN\" & IMAGEPATH)

        Next

        BuscaDocumentosaCanjear()

        Fileinfo_To_DataTable("C:\SCAN\")
        DataGridView1.DataSource = Fileinfo_To_DataTable("C:\SCAN\")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim index As Integer

        ' get the index of the selected datagridview row
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)

        ' now show data from the selected row to textboxes
        Try
            AxAcroPDF1.LoadFile("C:\SCAN\" & selectedRow.Cells(0).Value.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Actualiza DataGridView1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Fileinfo_To_DataTable("C:\SCAN\")
        DataGridView1.DataSource = Fileinfo_To_DataTable("C:\SCAN\")

    End Sub

    'Se utiliza el método de Empresas para indexar el DataGrid puesto que el botón está fuera del DataGrid
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        AxAcroPDF1.LoadFile(Nothing)

        Dim i = DataGridView1.CurrentRow.Index
        Dim j = 0
        Dim fileToDelete = DataGridView1.Item(j, i).Value

        Try
            System.IO.File.Delete("C:\SCAN\" & fileToDelete)
            MessageBox.Show("File Deleted")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        DataGridView1.DataSource = Fileinfo_To_DataTable("C:\SCAN\")

    End Sub

    Public Sub BuscaDocumentosaCanjear()

        Dim BuscaDocumentosaCanjear As New MySqlCommand("SELECT * FROM DOCUMENTOS WHERE CIF = @CIF AND ID_CLIENTE = @CLIENTE", connection)
        Dim adapter As New MySqlDataAdapter(BuscaDocumentosaCanjear)
        Dim table As New DataTable()
        Dim RowsReturned As Integer

        BuscaDocumentosaCanjear.Parameters.Add("@CIF", MySqlDbType.VarChar).Value = TBEMPRESA.Text
        BuscaDocumentosaCanjear.Parameters.Add("@CLIENTE", MySqlDbType.Int16).Value = ComboBox1.SelectedValue
        BuscaDocumentosaCanjear.ExecuteNonQuery()
        BuscaDocumentosaCanjear.CommandType = CommandType.Text

        adapter.Fill(table)

        RowsReturned = BuscaDocumentosaCanjear.ExecuteScalar()

        If RowsReturned = 0 Then
            MsgBox("OK")
        Else
            Cruce.Show()
        End If

        connection.Close()

    End Sub

End Class

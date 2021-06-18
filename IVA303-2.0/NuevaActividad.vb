Imports MySql.Data.MySqlClient
Imports WinSCP

Public Class NuevaActividad

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim sessionOptions As New SessionOptions
    Dim rs As New Resizer

    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Private Sub NuevaActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With sessionOptions
            .Protocol = Protocol.Sftp
            .HostName = "192.168.0.178"
            .UserName = "root"
            .Password = "Iverson.3$iva"
            .SshHostKeyFingerprint = "ssh-ed25519 256 e3:69:af:9b:52:97:03:13:0a:0c:60:ef:47:7f:39:67"
        End With

        cbTipos.Items.Add("Llamo")
        cbTipos.Items.Add("Contesto")
        cbTipos.Items.Add("Envío mail")
        cbTipos.Items.Add("Fras recibidas")
        cbTipos.Items.Add("Resp. mail")
        cbTipos.Items.Add("Otra")

        rs.FindAllControls(Me)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Application.OpenForms().OfType(Of AltaCliente).Any Then
            Dim findClient As New MySqlCommand("SELECT ID FROM CLIENTES WHERE ID = @ID", connection)
            findClient.Parameters.AddWithValue("@ID", DbNullOrStringValue(AltaCliente.tbID.Text))
            Dim findAdapter As New MySqlDataAdapter(findClient)
            Dim findTable As New DataTable()
            findAdapter.Fill(findTable)
            Dim idCliente = findTable.Rows(0)("ID").ToString()

            Dim insertActivityQuery As New MySqlCommand("INSERT INTO ACTIVIDADES (ID_CLIENTE, TIPO, FECHA, INFO)
                                                    VALUES (@ID_CLIENTE, @TIPO, @FECHA, @INFO)", connection)

            insertActivityQuery.Parameters.AddWithValue("@ID_CLIENTE", DbNullOrStringValue(idCliente))
            insertActivityQuery.Parameters.AddWithValue("@TIPO", DbNullOrStringValue(cbTipos.Text))
            insertActivityQuery.Parameters.AddWithValue("@FECHA", DbNullOrStringValue(Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss")))
            insertActivityQuery.Parameters.AddWithValue("@INFO", DbNullOrStringValue(TextBox1.Text))

            connection.Open()
            insertActivityQuery.ExecuteNonQuery()
            connection.Close()

            AltaCliente.populate_dgv_actividades()

            Me.Close()
        ElseIf Application.OpenForms().OfType(Of AltaEmpresa).Any Then
            Dim findEmpresa As New MySqlCommand("SELECT ID FROM EMPRESAS WHERE CIF = @CIF", connection)
            findEmpresa.Parameters.AddWithValue("@CIF", DbNullOrStringValue(AltaEmpresa.TB_CIF.Text))
            Dim findAdapter As New MySqlDataAdapter(findEmpresa)
            Dim findTable As New DataTable()
            findAdapter.Fill(findTable)
            Dim idEmpresa = findTable.Rows(0)("ID").ToString()

            Dim insertActivityQuery As New MySqlCommand("INSERT INTO ACTIVIDADES_EMPRESAS (ID_EMPRESA, TIPO, FECHA, INFO)
                                                    VALUES (@ID_EMPRESA, @TIPO, @FECHA, @INFO)", connection)

            insertActivityQuery.Parameters.AddWithValue("@ID_EMPRESA", DbNullOrStringValue(idEmpresa))
            insertActivityQuery.Parameters.AddWithValue("@TIPO", DbNullOrStringValue(cbTipos.Text))
            insertActivityQuery.Parameters.AddWithValue("@FECHA", DbNullOrStringValue(Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss")))
            insertActivityQuery.Parameters.AddWithValue("@INFO", DbNullOrStringValue(TextBox1.Text))

            connection.Open()
            insertActivityQuery.ExecuteNonQuery()
            connection.Close()

            AltaEmpresa.populate_dgvActividades()

            Me.Close()
        End If
    End Sub
End Class
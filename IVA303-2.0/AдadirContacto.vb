Imports MySql.Data.MySqlClient

Public Class AñadirContacto

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim findEmpresa As New MySqlCommand("SELECT ID FROM EMPRESAS WHERE CIF = @CIF", connection)
        findEmpresa.Parameters.AddWithValue("@CIF", DbNullOrStringValue(AltaEmpresa.TB_CIF.Text))
        Dim findAdapter As New MySqlDataAdapter(findEmpresa)
        Dim findTable As New DataTable()
        findAdapter.Fill(findTable)
        Dim idEmpresa = findTable.Rows(0)("ID").ToString()

        Dim insertContactQuery As New MySqlCommand("INSERT INTO CONTACTOS_EMPRESAS (ID_EMPRESA, CONTACTO, CARGO, TELEFONO, EMAIL)
                                                VALUES (@ID_EMPRESA, @CONTACTO, @CARGO, @TELEFONO, @EMAIL)", connection)

        insertContactQuery.Parameters.AddWithValue("@ID_EMPRESA", DbNullOrStringValue(idEmpresa))
        insertContactQuery.Parameters.AddWithValue("@CONTACTO", DbNullOrStringValue(tbNombre.Text))
        insertContactQuery.Parameters.AddWithValue("@CARGO", DbNullOrStringValue(tbCargo.Text))
        insertContactQuery.Parameters.AddWithValue("@TELEFONO", DbNullOrStringValue(tbTelefono.Text))
        insertContactQuery.Parameters.AddWithValue("@EMAIL", DbNullOrStringValue(tbEmail.Text))

        connection.Open()
        insertContactQuery.ExecuteNonQuery()
        connection.Close()

        AltaEmpresa.populate_dgvContactos()

        Me.Close()
    End Sub
    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function

    Private Sub NuevaActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs.FindAllControls(Me)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

End Class
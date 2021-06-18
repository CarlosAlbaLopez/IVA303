Imports MySql.Data.MySqlClient

Public Class ModificarActividad

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer
    Dim findActivity As New MySqlCommand("select *
                                            FROM ACTIVIDADES
                                            WHERE ID = @ID", connection)
    Dim findActivityEmpresa As New MySqlCommand("select *
                                            FROM ACTIVIDADES_EMPRESAS
                                            WHERE ID = @ID", connection)

    Private Sub ModificarActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cbTipos.Items.Add("Llamo")
        cbTipos.Items.Add("Contesto")
        cbTipos.Items.Add("Envío mail")
        cbTipos.Items.Add("Fras recibidas")
        cbTipos.Items.Add("Resp. mail")
        cbTipos.Items.Add("Otra")

        If Application.OpenForms().OfType(Of AltaCliente).Any Then
            Try
                Dim i = AltaCliente.dgvActividades.CurrentRow.Index
                Dim ID = AltaCliente.dgvActividades.Item(0, i).Value
                findActivity.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))

                Dim adapter As New MySqlDataAdapter(findActivity)
                Dim table As New DataTable()
                adapter.Fill(table)

                cbTipos.Text = table.Rows(0)("TIPO").ToString()
                DateTimePicker1.Value = table.Rows(0)("FECHA").ToString()
                TextBox1.Text = table.Rows(0)("INFO").ToString()
            Catch ex As Exception
            End Try
        ElseIf Application.OpenForms().OfType(Of AltaEmpresa).Any Then
            Try
                Dim i = AltaEmpresa.dgvActividades.CurrentRow.Index
                Dim ID = AltaEmpresa.dgvActividades.Item(0, i).Value
                findActivityEmpresa.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))

                Dim adapter As New MySqlDataAdapter(findActivityEmpresa)
                Dim table As New DataTable()
                adapter.Fill(table)

                cbTipos.Text = table.Rows(0)("TIPO").ToString()
                DateTimePicker1.Value = table.Rows(0)("FECHA").ToString()
                TextBox1.Text = table.Rows(0)("INFO").ToString()
            Catch ex As Exception
            End Try
        End If

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

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Application.OpenForms().OfType(Of AltaCliente).Any Then
            Dim i = AltaCliente.dgvActividades.CurrentRow.Index
            Dim ID = AltaCliente.dgvActividades.Item(0, i).Value
            findActivity.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))

            Dim updateActivityQuery As New MySqlCommand("UPDATE ACTIVIDADES
                                                        SET TIPO = @TIPO, FECHA = @FECHA, INFO = @INFO
                                                        WHERE ID = @ID", connection)

            updateActivityQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))
            updateActivityQuery.Parameters.AddWithValue("@TIPO", DbNullOrStringValue(cbTipos.Text))
            updateActivityQuery.Parameters.AddWithValue("@FECHA", DbNullOrStringValue(Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss")))
            updateActivityQuery.Parameters.AddWithValue("@INFO", DbNullOrStringValue(TextBox1.Text))

            connection.Open()
            updateActivityQuery.ExecuteNonQuery()
            connection.Close()

            AltaCliente.populate_dgv_actividades()

            Me.Close()
        ElseIf Application.OpenForms().OfType(Of AltaEmpresa).Any Then
            Dim i = AltaEmpresa.dgvActividades.CurrentRow.Index
            Dim ID = AltaEmpresa.dgvActividades.Item(0, i).Value
            findActivityEmpresa.Parameters.AddWithValue("@ID", DbNullOrStringValue(ID))

            Dim updateActivityQuery As New MySqlCommand("UPDATE ACTIVIDADES_EMPRESAS
                                                        SET TIPO = @TIPO, FECHA = @FECHA, INFO = @INFO
                                                        WHERE ID = @ID", connection)

            updateActivityQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(id))
            updateActivityQuery.Parameters.AddWithValue("@TIPO", DbNullOrStringValue(cbTipos.Text))
            updateActivityQuery.Parameters.AddWithValue("@FECHA", DbNullOrStringValue(Format(DateTimePicker1.Value, "yyyy-MM-dd HH:mm:ss")))
            updateActivityQuery.Parameters.AddWithValue("@INFO", DbNullOrStringValue(TextBox1.Text))

            connection.Open()
            updateActivityQuery.ExecuteNonQuery()
            connection.Close()

            AltaEmpresa.populate_dgvActividades()

            Me.Close()
        End If
    End Sub
End Class
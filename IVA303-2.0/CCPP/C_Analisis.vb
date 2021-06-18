
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization

Public Class C_Analisis

    Dim connection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")

    Private Sub F1CIF(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then
            e.Handled = True
            TBCIF.Focus()
            TBCIF.SelectAll()
        End If
    End Sub
    Private Sub F2REFERENCIA(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 Then
            e.Handled = True
            TBREFERENCIA.Focus()
            TBREFERENCIA.SelectAll()
        End If
    End Sub
    Private Sub F3FECHA(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            e.Handled = True
            TBFECHA.Focus()
            TBFECHA.SelectAll()
        End If
    End Sub

    Private Sub TBCIF_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBCIF.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TBREFERENCIA.Focus()
            BuscaCIF()
        End If
    End Sub
    Private Sub TBREFERENCIA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBREFERENCIA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TBFECHA.Focus()
        End If
    End Sub

    Private Sub TBFECHA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBFECHA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TBTIPOIVA.Focus()
        End If
    End Sub

    Private Sub TBTIPOIVA_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBTIPOIVA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            TBIMPORTE.Focus()
        End If
    End Sub

    Private Sub TBIMPORTE_JUMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TBIMPORTE.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            BTN_CALCULAR.Focus()
        End If
    End Sub

    Private Sub C_Analisis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populateDatagridview()

        populateDGV_LINEAS_IVA()

        Application.CurrentCulture = New CultureInfo("EN-US")
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellLeave
        Try
            Dim index As Integer

            ' get the index of the selected datagridview row
            index = e.RowIndex

            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)

            ' now show data from the selected row to textboxes
            AxAcroPDF1.LoadFile(selectedRow.Cells(7).Value.ToString())

            'AxAcroPDF1.Controls.
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DatosLoad()

        Dim i = DataGridView1.CurrentRow.Index
        Dim j = 0

        If DataGridView1.Item(j + 1, i).Value Is DBNull.Value Then
            TBCIF.Text = ""
        Else
            TBCIF.Text = DataGridView1.Item(j + 1, i).Value

        End If

        If DataGridView1.Item(j + 3, i).Value Is DBNull.Value Then
            TBREFERENCIA.Text = ""
        Else
            TBREFERENCIA.Text = DataGridView1.Item(j + 3, i).Value

        End If

        If DataGridView1.Item(j + 2, i).Value Is DBNull.Value Then
            TBFECHA.Text = ""
        Else
            TBFECHA.Text = DataGridView1.Item(j + 2, i).Value

        End If

        If DataGridView1.Item(j + 4, i).Value Is DBNull.Value Then
            TB_SUMA_BASE.Text = ""
        Else
            TB_SUMA_BASE.Text = DataGridView1.Item(j + 4, i).Value

        End If

        If DataGridView1.Item(j + 5, i).Value Is DBNull.Value Then
            TB_SUMA_IVA.Text = ""
        Else
            TB_SUMA_IVA.Text = DataGridView1.Item(j + 5, i).Value

        End If

        If DataGridView1.Item(j + 6, i).Value Is DBNull.Value Then
            TB_SUMA_TOTAL.Text = ""
        Else
            TB_SUMA_TOTAL.Text = DataGridView1.Item(j + 6, i).Value

        End If

    End Sub

    Private Sub DataGridView1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

        Try

            Dim index As Integer

            ' get the index of the selected datagridview row
            index = e.RowIndex

            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)

            ' now show data from the selected row to textboxes
            AxAcroPDF1.LoadFile(selectedRow.Cells(7).Value.ToString())
            DatosLoad()
            populateDGV_LINEAS_IVA()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub


    Public Sub ExecuteMyQuery(MyCommand As SqlCommand, MyMessage As String)

        connection.Open()

        If MyCommand.ExecuteNonQuery = 1 Then

            MessageBox.Show(MyMessage)

        Else

            MessageBox.Show("Query Not Executed")

        End If

        connection.Close()

        populateDatagridview()

    End Sub

    Private Sub BTN_DELETE_Click(sender As Object, e As EventArgs)

        Try

            Dim deleteQuery As String = "DELETE FROM Table_Images WHERE id = " & TBCIF.Text

            Dim command As New SqlCommand(deleteQuery, connection)

            ExecuteMyQuery(command, " Image Deleted ")

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub populateDatagridview()

        Try

            Dim searchQuery As String = "SELECT ID,CIF,FECHA,REFERENCIA,SUMA_BASE,SUMA_IVA,SUMA_TOTAL,RUTA From CCPP_DOCUMENTOS where ID_ESTADO in (1,2)"

            Dim command As New SqlCommand(searchQuery, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.AllowUserToAddRows = False

            DataGridView1.RowTemplate.Height = 100
            Dim imgc As New DataGridViewImageColumn
            DataGridView1.DataSource = table
            'DatosLoad()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub populateDGV_LINEAS_IVA()

        Try

            'Solamente actualiza datos si está seleccionado el campo ID en la DGV
            Dim i = DataGridView1.CurrentRow.Index
            Dim j = 0


            Dim command As New SqlCommand("SELECT ID, TIPO, BASE, IVA, TOTAL FROM CCPP_LINEAS_IVA WHERE ID_DOCUMENTO = @ID", connection)
            command.Parameters.Add("@ID", SqlDbType.Int).Value = DataGridView1.Item(j, i).Value
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)

            DGV_LINEAS_IVA.AllowUserToAddRows = False

            DGV_LINEAS_IVA.RowTemplate.Height = 100
            Dim imgc As New DataGridViewImageColumn
            DGV_LINEAS_IVA.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Public Sub GUARDAR_GRID_en_sql()

        Dim dt As DataTable = DirectCast(DGV_LINEAS_IVA.DataSource, DataTable)

    End Sub

    Private Sub BTN_CALCULAR_Click(sender As Object, e As EventArgs) Handles BTN_CALCULAR.Click
        Dim ms As New MemoryStream

        Dim img() As Byte
        img = ms.ToArray()
        Dim insertQuery As New SqlCommand("INSERT INTO CCPP_LINEAS_IVA (ID_DOCUMENTO, TIPO, BASE, IVA, TOTAL)
                                        VALUES (@ID, @TIPO, @BASE, @IVA, @TOTAL)", connection)

        'Solamente actualiza datos si está seleccionado el campo ID en la DGV
        Dim i = DataGridView1.CurrentRow.Index
        Dim j = 0

        insertQuery.Parameters.Add("@ID", SqlDbType.Int).Value = DataGridView1.Item(j, i).Value
        insertQuery.Parameters.Add("@TIPO", SqlDbType.Decimal).Value = TBTIPOIVA.Text

        If IMPORTEBASE.Checked Then
            insertQuery.Parameters.Add("@BASE", SqlDbType.Decimal).Value = TBIMPORTE.Text
            insertQuery.Parameters.Add("@IVA", SqlDbType.Decimal).Value = TBIMPORTE.Text * TBTIPOIVA.Text / 100
            insertQuery.Parameters.Add("@TOTAL", SqlDbType.VarChar).Value = TBIMPORTE.Text + (TBIMPORTE.Text * TBTIPOIVA.Text / 100)
        Else
            insertQuery.Parameters.Add("@TOTAL", SqlDbType.VarChar).Value = TBIMPORTE.Text
            insertQuery.Parameters.Add("@IVA", SqlDbType.Decimal).Value = TBIMPORTE.Text - (TBIMPORTE.Text / (1 + (TBTIPOIVA.Text / 100)))
            insertQuery.Parameters.Add("@BASE", SqlDbType.Decimal).Value = TBIMPORTE.Text / (1 + (TBTIPOIVA.Text / 100))
        End If

        connection.Open()

        insertQuery.ExecuteNonQuery()

        connection.Close()

        'Volver a poner en blanco los campos
        TBTIPOIVA.Text = ""
        TBIMPORTE.Text = ""

        populateDGV_LINEAS_IVA()



        '' SUMA DE LAS BASES
        Try
            Using cnn As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")

                ' Creamos un comando
                Dim cmd As SqlCommand = cnn.CreateCommand()

                ' Indicamos la consulta que vamos a ejecutar
                cmd.CommandText =
                "SELECT SUM(BASE) FROM CCPP_LINEAS_IVA WHERE ID_DOCUMENTO = @ID_IVA"

                ' Abrimos la conexión
                cnn.Open()

                cmd.Parameters.Add("@ID_IVA", SqlDbType.Int).Value = DataGridView1.Item(j, i).Value

                ' Ejecutamos la consulta
                Dim suma As Object = cmd.ExecuteScalar()

                ' Mostramos el resultado formateado en un control TextBox
                TB_SUMA_BASE.Text = String.Format("{0:0.00}", suma)

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        '' SUMA DE LOS IVAS

        Try
            Using cnn As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")

                ' Creamos un comando
                Dim cmd As SqlCommand = cnn.CreateCommand()

                ' Indicamos la consulta que vamos a ejecutar
                cmd.CommandText =
                "SELECT SUM(IVA) FROM CCPP_LINEAS_IVA WHERE ID_DOCUMENTO = @ID_IVA"

                ' Abrimos la conexión
                cnn.Open()

                cmd.Parameters.Add("@ID_IVA", SqlDbType.Int).Value = DataGridView1.Item(j, i).Value

                ' Ejecutamos la consulta
                Dim suma As Object = cmd.ExecuteScalar()

                ' Mostramos el resultado formateado en un control TextBox
                TB_SUMA_IVA.Text = String.Format("{0:0.00}", suma)

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


        '' SUMA DE LOS TOTALES

        Try
            Using cnn As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")

                ' Creamos un comando
                Dim cmd As SqlCommand = cnn.CreateCommand()

                ' Indicamos la consulta que vamos a ejecutar
                cmd.CommandText =
                "SELECT SUM(TOTAL) FROM CCPP_LINEAS_IVA WHERE ID_DOCUMENTO = @ID_IVA"

                ' Abrimos la conexión
                cnn.Open()

                cmd.Parameters.Add("@ID_IVA", SqlDbType.Int).Value = DataGridView1.Item(j, i).Value

                ' Ejecutamos la consulta
                Dim suma As Object = cmd.ExecuteScalar()

                ' Mostramos el resultado formateado en un control TextBox
                TB_SUMA_TOTAL.Text = String.Format("{0:0.00}", suma)

            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        BTN_UPDATE.Focus()
    End Sub

    Private Sub BTN_UPDATE_Click_1(sender As Object, e As EventArgs) Handles BTN_UPDATE.Click
        Dim ms As New MemoryStream

        Dim img() As Byte
        img = ms.ToArray()
        Dim updateQuery As New SqlCommand("UPDATE CCPP_DOCUMENTOS
                                        SET CIF = @CIF, FECHA = @FECHA, REFERENCIA = @REFERENCIA, SUMA_BASE = @SUMA_BASE, SUMA_IVA = @SUMA_IVA, SUMA_TOTAL = @SUMA_TOTAL, ID_ESTADO = 2
                                        WHERE ID = @ID", connection)

        Dim sumabase As New SqlCommand("SELECT SUM(BASE) FROM CCPP_LINEAS_IVA WHERE ID_DOCUMENTO = @ID", connection)
        Dim sumaiva As New SqlCommand("SELECT SUM(IVA) FROM CCPP_LINEAS_IVA WHERE ID_DOCUMENTO = @ID", connection)
        Dim sumatotal As New SqlCommand("SELECT SUM(TOTAL) FROM CCPP_LINEAS_IVA WHERE ID_DOCUMENTO = @ID", connection)


        'Solamente actualiza datos si está seleccionado el campo ID en la DGV
        Dim i = DataGridView1.CurrentRow.Index
        Dim j = 0

        Dim base As String = "SELECT SUM(BASE) FROM CCPP_LINEAS_IVA WHERE ID_DOCUMENTO = @ID"

        updateQuery.Parameters.Add("@ID", SqlDbType.Int).Value = DataGridView1.Item(j, i).Value
        updateQuery.Parameters.Add("@CIF", SqlDbType.VarChar).Value = TBCIF.Text
        updateQuery.Parameters.Add("@FECHA", SqlDbType.Date).Value = TBFECHA.Text
        updateQuery.Parameters.Add("@REFERENCIA", SqlDbType.VarChar).Value = TBREFERENCIA.Text
        updateQuery.Parameters.Add("@SUMA_BASE", SqlDbType.Decimal).Value = TB_SUMA_BASE.Text
        updateQuery.Parameters.Add("@SUMA_IVA", SqlDbType.Decimal).Value = TB_SUMA_IVA.Text
        updateQuery.Parameters.Add("@SUMA_TOTAL", SqlDbType.Decimal).Value = TB_SUMA_TOTAL.Text

        connection.Open()

        Try
            updateQuery.ExecuteNonQuery()
        Catch EX As Exception
            MsgBox("Error fatal")
        End Try

        populateDatagridview()

        Dim k = DataGridView1.CurrentRow.Index + 1

        If k = Nothing Then
            DataGridView1.CurrentCell = DataGridView1(j, i + 1)
        Else
            populateDatagridview()
        End If
        DatosLoad()

        TBCIF.Focus()

        connection.Close()

        populateDGV_LINEAS_IVA()

    End Sub

    Private Sub DGV_LINEAS_IVA_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_LINEAS_IVA.CellDoubleClick

        Dim deleteQuery As New SqlCommand("delete from CCPP_LINEAS_IVA where id = @id", connection)

        Dim i = DGV_LINEAS_IVA.CurrentRow.Index
        Dim j = 0

        deleteQuery.Parameters.Add("@ID", SqlDbType.Int).Value = DGV_LINEAS_IVA.Item(j, i).Value

        connection.Open()

        deleteQuery.ExecuteNonQuery()

        populateDGV_LINEAS_IVA()

        connection.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BTNREFRESCAR.Click

        DatosLoad()

    End Sub

    Private Sub BuscaCIF()

        Dim BuscaCIFQuery As New SqlCommand("SELECT * FROM CCPP_EMPRESAS WHERE CIF = @CIF", connection)
        Dim BuscaNombreFiscalQuery As New SqlCommand("SELECT NOMBRE_FISCAL FROM CCPP_EMPRESAS WHERE CIF = @CIF", connection)
        Dim RowsReturned As Integer
        Dim nombrefiscal As String

        connection.Open()

        BuscaCIFQuery.Parameters.Add("@CIF", SqlDbType.VarChar).Value = TBCIF.Text
        BuscaCIFQuery.ExecuteNonQuery()
        BuscaCIFQuery.CommandType = CommandType.Text
        BuscaNombreFiscalQuery.Parameters.Add("@CIF", SqlDbType.VarChar).Value = TBCIF.Text
        BuscaNombreFiscalQuery.ExecuteNonQuery()
        BuscaNombreFiscalQuery.CommandType = CommandType.Text

        RowsReturned = BuscaCIFQuery.ExecuteScalar()
        nombrefiscal = BuscaNombreFiscalQuery.ExecuteScalar()

        If RowsReturned = 0 Then
            AltaEmpresa.Show()
        Else
            TBRECONOCIMIENTOCIF.Text = nombrefiscal
        End If

        connection.Close()

    End Sub

End Class
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports WinSCP

Public Class Certificacion3

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test;Convert Zero Datetime=True")
    Dim rs As New Resizer

    Private Sub Certificacion3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tiposcommand As New MySqlCommand("select * from TIPOS_DOCUMENTOS", connection)

        Dim tiposadapter As New MySqlDataAdapter(tiposcommand)

        Dim tipostable As New DataTable()

        tiposadapter.Fill(tipostable)

        CB_TipoDoc.DataSource = tipostable

        CB_TipoDoc.DisplayMember = "NOMBRE"
        CB_TipoDoc.ValueMember = "ID"

        Dim estadoscommand As New MySqlCommand("select * from ESTADOS_DOCUMENTOS", connection)

        Dim estadosadapter As New MySqlDataAdapter(estadoscommand)

        Dim estadostable As New DataTable()

        estadosadapter.Fill(estadostable)

        CB_EstadoDoc.DataSource = estadostable

        CB_EstadoDoc.DisplayMember = "NOMBRE"
        CB_EstadoDoc.ValueMember = "ID"

        PopulateDGV()
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

    Public Sub PopulateDGV()

        If Application.OpenForms().OfType(Of AltaEmpresa).Any Then

            Dim searchQuery As New MySqlCommand("SELECT D.ID, D.ID_TIPO, D.CIF, D.FECHA, D.REFERENCIA, L.TIPO, D.SUMA_BASE, D.SUMA_IVA, D.SUMA_TOTAL, D.RUTA
                                                FROM DOCUMENTOS D LEFT JOIN LINEAS_IVA L ON D.ID = L.ID_DOCUMENTO
                                                WHERE D.ID_ESTADO = 2 AND D.CIF = @CIF AND D.ID_TIPO <> 5", connection)

            Dim adapter As New MySqlDataAdapter(searchQuery)
            Dim table As New DataTable()

            searchQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(AltaEmpresa.TB_CIF.Text))

            adapter.Fill(table)

            DGV_Tickets.RowTemplate.Height = 100
            Dim imgc As New DataGridViewImageColumn
            DGV_Tickets.DataSource = table

        Else

            Dim i = Empresas.DGV_Empresas.CurrentRow.Index
            Dim j = 1
            Dim cif = Empresas.DGV_Empresas.Item(j, i).Value

            If cif <> "" Then

                Try

                    Dim searchQuery As String = "SELECT D.ID, D.ID_TIPO, D.CIF, D.FECHA, D.REFERENCIA, L.TIPO, D.SUMA_BASE, D.SUMA_IVA, D.SUMA_TOTAL, D.RUTA
                                                FROM DOCUMENTOS D LEFT JOIN LINEAS_IVA L ON D.ID = L.ID_DOCUMENTO
                                                WHERE D.ID_ESTADO = 2 AND D.CIF = @CIF AND D.ID_TIPO <> 5"

                    Dim command As New MySqlCommand(searchQuery, connection)
                    Dim adapter As New MySqlDataAdapter(command)
                    Dim table As New DataTable()

                    command.Parameters.AddWithValue("@CIF", DbNullOrStringValue(cif))

                    adapter.Fill(table)

                    DGV_Tickets.AllowUserToAddRows = False

                    DGV_Tickets.RowTemplate.Height = 100
                    Dim imgc As New DataGridViewImageColumn
                    DGV_Tickets.DataSource = table


                Catch ex As Exception

                    MessageBox.Show(ex.Message)

                End Try

            End If

        End If

    End Sub

    Public Sub ShowImage(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Tickets.CellEnter
        Try
            Dim index As Integer

            ' get the index of the selected datagridview row
            index = e.RowIndex

            Dim selectedRow As DataGridViewRow
            selectedRow = DGV_Tickets.Rows(index)

            If System.IO.File.Exists("S:\img\" & selectedRow.Cells(9).Value.ToString()) Then

                Dim AbRuta As String = "S:\img\" & selectedRow.Cells(9).Value.ToString()
                AxAcroPDF1.LoadFile(AbRuta)

            Else

                MsgBox("No se encuentra la imagen")

            End If

            Try

                Panel1.Enabled = False
                DGV_Tickets.Focus()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub DGV_Tickets_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Tickets.CellDoubleClick

        Analisis.Show()

    End Sub

    Private Sub BTN_Buscar_Click(sender As Object, e As EventArgs) Handles BTN_Buscar.Click

        Try
            If TB_id.Text = "" Then

                Dim searchQuery As New MySqlCommand("SELECT D.ID, D.ID_TIPO, D.CIF, D.FECHA, D.REFERENCIA, L.TIPO, D.SUMA_BASE, D.SUMA_IVA, D.SUMA_TOTAL, D.RUTA
                                                    From DOCUMENTOS D LEFT JOIN LINEAS_IVA L ON D.ID = L.ID_DOCUMENTO
                                                    where D.CIF = @CIF
                                                    and D.ID_TIPO = @ID_TIPO
                                                    and D.ID_ESTADO = @ID_ESTADO", connection)

                Dim adapter As New MySqlDataAdapter(searchQuery)
                Dim table1 As New DataTable()

                Dim i = Empresas.DGV_Empresas.CurrentRow.Index
                Dim j = 1
                Dim cif = Empresas.DGV_Empresas.Item(j, i).Value

                searchQuery.Parameters.AddWithValue("@CIF", DbNullOrStringValue(cif))
                searchQuery.Parameters.AddWithValue("@ID_TIPO", DbNullOrStringValue(CB_TipoDoc.SelectedValue))
                searchQuery.Parameters.AddWithValue("@ID_ESTADO", DbNullOrStringValue(CB_EstadoDoc.SelectedValue))

                adapter.Fill(table1)

                DGV_Tickets.AllowUserToAddRows = False

                DGV_Tickets.RowTemplate.Height = 100
                Dim imgc As New DataGridViewImageColumn
                DGV_Tickets.DataSource = table1

            Else

                Dim searchById As String = "SELECT D.ID, D.ID_TIPO, D.CIF, D.FECHA, D.REFERENCIA, L.TIPO, D.SUMA_BASE, D.SUMA_IVA, D.SUMA_TOTAL, D.RUTA
                                            From DOCUMENTOS D LEFT JOIN LINEAS IVA L ON D.ID = L.ID_DOCUMENTO
                                            where D.ID = @ID"

                Dim command As New MySqlCommand(searchById, connection)
                Dim adapter As New MySqlDataAdapter(command)
                Dim table As New DataTable()

                command.Parameters.AddWithValue("@ID", DbNullOrStringValue(TB_id.Text))

                adapter.Fill(table)

                DGV_Tickets.AllowUserToAddRows = False

                DGV_Tickets.RowTemplate.Height = 100
                Dim imgc As New DataGridViewImageColumn
                DGV_Tickets.DataSource = table

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub BTN_Cambiar_Click(sender As Object, e As EventArgs) Handles BTN_Cambiar.Click

        CambiarTipoDoc.Show()

    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As System.EventArgs) Handles Panel2.MouseHover

        Panel1.Enabled = True

    End Sub

    Private Sub BTN_Procesar_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim numberOfRows As Integer
        Dim Counter As Long = 0
        Dim txt As String

        'Create a dynamic array variable, and then declare its initial size
        Dim IdsListArray() As String
        ReDim IdsListArray(1000)

        'Loop through all the files in the directory by using Dir$ function
        numberOfRows = DGV_Tickets.Rows.Count - 1
        Do While Counter <= numberOfRows
            IdsListArray(Counter) = DGV_Tickets.Rows(Counter).Cells(0).Value.ToString
            txt = IdsListArray(Counter)
            Counter = Counter + 1

            Dim isInvoiceQuery As New MySqlCommand("SELECT ID_TIPO FROM DOCUMENTOS WHERE ID = @ID", connection)

            isInvoiceQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(txt))

            connection.Open()
            Dim isInvoice = isInvoiceQuery.ExecuteScalar()
            connection.Close()

            If isInvoice = 1 Then
                Dim certificaQuery As New MySqlCommand("UPDATE DOCUMENTOS SET ID_ESTADO = 3 WHERE ID = @ID", connection)
                certificaQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(txt))
                connection.Open()
                certificaQuery.ExecuteNonQuery()
                connection.Close()
            ElseIf isInvoice = 2 Then
                Dim certificaQuery As New MySqlCommand("UPDATE DOCUMENTOS SET ID_ESTADO = 3 WHERE ID = @ID", connection)
                certificaQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(txt))
                connection.Open()
                certificaQuery.ExecuteNonQuery()
                connection.Close()
            Else
                Dim certificaQuery As New MySqlCommand("UPDATE DOCUMENTOS SET ID_ESTADO = 6 WHERE ID = @ID", connection)
                certificaQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(txt))
                connection.Open()
                certificaQuery.ExecuteNonQuery()
                connection.Close()
            End If
        Loop

        'Reset the size of the array without losing its values by using Redim Preserve 
        ReDim Preserve IdsListArray(Counter - 1)

        PopulateDGV()

    End Sub

End Class
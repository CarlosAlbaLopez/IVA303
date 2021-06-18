
Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class Cruce

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=jairo;Pwd=test")
    Dim rs As New Resizer

    Private Sub Clase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        Dim BuscaDocumentosaCanjear As New MySqlCommand("SELECT * FROM DOCUMENTOS WHERE CIF = @CIF AND ID_CLIENTE = @CLIENTE AND ID_TIPO IN (1,2) AND ID_ESTADO = 4", connection)

        connection.Open()

        Dim adapter As New MySqlDataAdapter(BuscaDocumentosaCanjear)
        Dim table As New DataTable()

        BuscaDocumentosaCanjear.Parameters.AddWithValue("@CIF", DbNullOrStringValue(mAlta.TBEMPRESA.Text))
        BuscaDocumentosaCanjear.Parameters.AddWithValue("@CLIENTE", DbNullOrStringValue(mAlta.ComboBox1.SelectedValue))
        BuscaDocumentosaCanjear.ExecuteNonQuery()
        adapter.Fill(table)

        DGV_CRUCE.DataSource = table

        connection.Close()

    End Sub

    Public Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CRUCE.CellContentClick

        Dim index As Integer

        'get the index of the selected datagridview row
        index = e.RowIndex

        Dim selectedRow As DataGridViewRow
        selectedRow = DGV_CRUCE.Rows(index)

        'now show data from the selected row to textboxes
        Try
            AxAcroPDF1.LoadFile("S:\img\" & selectedRow.Cells(1).Value.ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BTN_CRUCE_Click(sender As Object, e As EventArgs) Handles BTN_CRUCE.Click

        Dim MAXQuery As New MySqlCommand("SELECT MAX(ID) FROM DOCUMENTOS WHERE ID_TIPO = 4", connection)

        connection.Open()

        Dim id_factura = MAXQuery.ExecuteScalar

        Dim UPDATEQuery As New MySqlCommand("UPDATE DOCUMENTOS SET ID_FACTURA = @ID_FACTURA, ID_ESTADO = 5
                                            WHERE ID = @ID", connection)

        Dim i = DGV_CRUCE.CurrentRow.Index
        Dim j = 0

        UPDATEQuery.Parameters.AddWithValue("@ID_FACTURA", DbNullOrStringValue(id_factura))
        UPDATEQuery.Parameters.AddWithValue("@ID", DbNullOrStringValue(DGV_CRUCE.Item(j, i).Value))

        UPDATEQuery.ExecuteNonQuery()

        connection.Close()

        populateDatagridview()

        Me.Close()

    End Sub
End Class
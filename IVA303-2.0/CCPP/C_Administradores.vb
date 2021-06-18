'Imports System.Data.SqlClient
'Imports System.IO
'Imports System.Drawing.Imaging
'Imports System.Globalization
'Imports System.Linq
'Imports iTextSharp.text.pdf
'Imports iTextSharp.text

'Public Class C_Administradores

'    Public Sub Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        populateDatagridview()
'    End Sub

'    Public Sub populateDatagridview()

'        Dim connection As New SqlConnection("Server=(LocalDB)\303;Database=iva303;User=VISUAL;Pwd=303")

'        Dim searchQuery As String = "SELECT e.ID, CIF, NOMBRE_FISCAL, NOMBRE_COMERCIAL, m.NOMBRE as ESTADO, ID_TIPO_VIA, NOMBRE_VIA, NUMERO_VIA, PISO, LETRA_PISO, PROVINCIA, LOCALIDAD, PAIS, CP, E.TELEFONO, E.EMAIL, WEB 
'                                        From CCPP_ADMINISTRADORES e
'                                        LEFT JOIN ESTADOS_EMPRESAS m on e.ID_ESTADO = m.ID
'                                        LEFT JOIN TIPOS_VIAS TV ON E.ID_TIPO_VIA = TV.ID"

'        Dim command As New SqlCommand(searchQuery, connection)
'        Dim adapter As New SqlDataAdapter(command)
'        Dim table As New DataTable()
'        adapter.Fill(table)

'        DataGridView1.AllowUserToAddRows = False

'        DataGridView1.RowTemplate.Height = 100
'        Dim imgc As New DataGridViewImageColumn
'        DataGridView1.DataSource = table

'    End Sub
'    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'        AltaEmpresa.Show()
'    End Sub



'End Class
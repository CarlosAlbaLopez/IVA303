Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.Linq
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient


Public Class CambioTipoDocumento

    Dim connection As New MySqlConnection("Server=192.168.0.178;Database=iva303;Uid=root;Pwd=Iverson.3$iva;Convert Zero Datetime=True")

    Public Function DbNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value) Then
            Return DBNull.Value
        Else
            Return value
        End If
    End Function
    Private Sub btnSIMPLIFICADA_Click(sender As Object, e As EventArgs) Handles btnSIMPLIFICADA.Click

    End Sub

    Private Sub btnINCOMPLETA_Click(sender As Object, e As EventArgs) Handles btnINCOMPLETA.Click

    End Sub

    Private Sub btnCOMPLETA_Click(sender As Object, e As EventArgs) Handles btnCOMPLETA.Click

    End Sub

    Private Sub btnDECANJE_Click(sender As Object, e As EventArgs) Handles btnDECANJE.Click

    End Sub

    Private Sub btnNOFACTURA_Click(sender As Object, e As EventArgs) Handles btnNOFACTURA.Click

    End Sub
End Class
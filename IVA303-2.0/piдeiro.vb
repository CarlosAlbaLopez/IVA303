Public Class piñeiro

    Public Function TBNullOrStringValue(ByVal value As String) As Object
        If String.IsNullOrEmpty(value.ToString().Trim) = True Then
            Return DBNull.Value
        Else
            Return value.ToString
        End If
    End Function


 specificQuery.Parameters.AddWithValue("@SECTOR", TBNullOrStringValue(cbSector.Text))

End Class

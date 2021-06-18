Module Fileinfo
    Public Function Fileinfo_To_DataTable(ByVal directory As String) As DataTable
        Try
            'Create a new data table
            Dim dt As DataTable = New DataTable

            'Add the following columns:
            '                          Name
            '                          Length
            '                          Last Write Time
            ''                         Creation Time
            dt.Columns.AddRange({New DataColumn("NOMBRE")})

            'Loop through each file in the directory
            For Each file As IO.FileInfo In New IO.DirectoryInfo(directory).GetFiles
                'Create a new row
                Dim dr As DataRow = dt.NewRow

                'Set the data
                dr(0) = file.Name

                'Add the row to the data table
                dt.Rows.Add(dr)
            Next

            'Return the data table
            Return dt
        Catch ex As Exception
            Console.WriteLine(ex.ToString)

            'Return nothing if something fails
            Return Nothing
        End Try
    End Function
End Module
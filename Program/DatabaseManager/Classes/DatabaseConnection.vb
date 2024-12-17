Imports PTracker

Public Class DatabaseConnection
    Private _connectionString As String = DatabaseConfig.ConnectionString

    Public Function TestConnection() As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                conn.Open()
                Return True
            End Using
        Catch
            Return False
        End Try
    End Function

    Public Function GetTableList() As DataTable
        Using conn As New OleDbConnection(_connectionString)
            conn.Open()
            Dim schema = conn.GetSchema("Tables")
            Return schema.Select("TABLE_TYPE = 'TABLE'").CopyToDataTable()
        End Using
    End Function

    Public Function GetFieldList(tableName As String) As DataTable
        Using conn As New OleDbConnection(_connectionString)
            conn.Open()
            Dim schema = conn.GetSchema("Columns", New String() {Nothing, Nothing, tableName})
            Return schema
        End Using
    End Function
End Class


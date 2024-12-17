Imports ADODB
Imports PTracker

Public Class DatabaseConnection
    Private _connectionString As String = DatabaseConfig.ConnectionString

    Public Function TestConnection() As Boolean
        Try
            Dim conn As New ADODB.Connection
            conn.Open(_connectionString)
            conn.Close()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function GetTableList() As DataTable
        Dim dt As New DataTable
        Dim conn As New ADODB.Connection
        conn.Open(_connectionString)

        Dim rs As New ADODB.Recordset
        rs.Open("SELECT * FROM MSysObjects WHERE Type=1", conn)

        dt.Load(rs)
        Return dt
    End Function

    Public Function GetFieldList(tableName As String) As DataTable
        Dim dt As New DataTable
        Dim conn As New ADODB.Connection
        conn.Open(_connectionString)

        Dim rs As New ADODB.Recordset
        rs.Open($"SELECT * FROM {tableName} WHERE 1=0", conn)

        dt.Load(rs)
        Return dt
    End Function
End Class
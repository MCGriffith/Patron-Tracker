Imports ADODB
Imports PTracker
Imports System.Data.OleDb

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
        Dim conn As New OleDbConnection(_connectionString)
        '   Dim conn As New System.Data.OleDb.OleDbConnection(_connectionString)
        conn.Open()

        dt = conn.GetSchema("Tables")

        conn.Close()
        Return dt
    End Function

    Public Function GetFieldList(tableName As String) As DataTable
        Dim dt As New DataTable
        Dim conn As New OleDbConnection(_connectionString)
        conn.Open()

        Dim da As New OleDbDataAdapter($"SELECT * FROM {tableName} WHERE 1=0", conn)
        da.Fill(dt)

        conn.Close()
        Return dt
    End Function
End Class
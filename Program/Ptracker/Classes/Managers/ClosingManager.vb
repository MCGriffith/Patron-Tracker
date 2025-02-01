Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class ClosingManager
    Private ReadOnly _connectionString As String

    ' Constructor
    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    ' Structure to hold Closing data
    Public Structure FSCClosingData
        Public ClosingID As Integer
        Public StartDate As Date
        Public EndDate As Date
        Public ClosingType As String
        Public Description As String
        Public IsEmergency As Boolean
        Public Inactive As Boolean
    End Structure

    ' Function to add new closing
    Public Function AddClosing(startDate As Date, endDate As Date, closingType As String,
                         description As String, isEmergency As Boolean) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("INSERT INTO tblClosings (StartDate, EndDate, ClosingType, " &
                "Description, IsEmergency, Inactive) VALUES (?, ?, ?, ?, ?, ?)", conn)

                    cmd.Parameters.AddWithValue("?", startDate)
                    cmd.Parameters.AddWithValue("?", endDate)
                    cmd.Parameters.AddWithValue("?", closingType)
                    cmd.Parameters.AddWithValue("?", description)
                    cmd.Parameters.AddWithValue("?", isEmergency)
                    cmd.Parameters.AddWithValue("?", False)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error Adding Closing",
                       MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Function to get all active closings
    Public Function GetFSCClosings() As List(Of FSCClosingData)
        Dim fscClosings As New List(Of FSCClosingData)

        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("SELECT * FROM tblClosings WHERE Inactive = False ORDER BY StartDate", conn)
                    conn.Open()

                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    Dim schemaTable As DataTable = reader.GetSchemaTable()
                    For Each row As DataRow In schemaTable.Rows
                    Next

                    While reader.Read()

                        Dim fscClosing As New FSCClosingData With {
                        .ClosingID = Convert.ToInt32(reader("ClosingsID")),
                        .StartDate = Convert.ToDateTime(reader("StartDate")),
                        .EndDate = Convert.ToDateTime(reader("EndDate")),
                        .ClosingType = reader("ClosingType").ToString(),
                        .Description = reader("Description").ToString(),
                        .IsEmergency = Convert.ToBoolean(reader("IsEmergency")),
                        .Inactive = Convert.ToBoolean(reader("Inactive"))
                    }
                        fscClosings.Add(fscClosing)
                    End While
                End Using
            End Using
        Catch ex As Exception
        End Try

        Return fscClosings
    End Function

    ' Function to update existing closing
    Public Function UpdateFSCClosing(closingID As Integer, startDate As Date, endDate As Date,
                                closingType As String, description As String, isEmergency As Boolean) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("UPDATE tblClosings SET StartDate = ?, EndDate = ?, " &
                    "ClosingType = ?, Description = ?, IsEmergency = ? " &
                    "WHERE ClosingID = ?", conn)

                    cmd.Parameters.AddWithValue("?", startDate)
                    cmd.Parameters.AddWithValue("?", endDate)
                    cmd.Parameters.AddWithValue("?", closingType)
                    cmd.Parameters.AddWithValue("?", description)
                    cmd.Parameters.AddWithValue("?", isEmergency)
                    cmd.Parameters.AddWithValue("?", closingID)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Function to mark closing as inactive (soft delete)
    Public Function SetClosingInactive(closingId As Integer) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("UPDATE tblClosings SET Inactive = True WHERE ClosingsID = ?", conn)
                    cmd.Parameters.AddWithValue("?", closingId)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function UpdateClosing(closingId As Integer, startDate As Date, endDate As Date,
                            closingType As String, description As String, isEmergency As Boolean) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("UPDATE tblClosings SET StartDate = ?, EndDate = ?, " &
                    "ClosingType = ?, Description = ?, IsEmergency = ? WHERE ClosingsID = ?", conn)

                    cmd.Parameters.AddWithValue("?", startDate)
                    cmd.Parameters.AddWithValue("?", endDate)
                    cmd.Parameters.AddWithValue("?", closingType)
                    cmd.Parameters.AddWithValue("?", description)
                    cmd.Parameters.AddWithValue("?", isEmergency)
                    cmd.Parameters.AddWithValue("?", closingId)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
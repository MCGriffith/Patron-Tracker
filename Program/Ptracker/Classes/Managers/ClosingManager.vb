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
                    Debug.WriteLine("Database connection opened successfully")

                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    Debug.WriteLine("=== Column Names in tblClosings ===")
                    Dim schemaTable As DataTable = reader.GetSchemaTable()
                    For Each row As DataRow In schemaTable.Rows
                        Debug.WriteLine($"Column name: {row("ColumnName")}")
                    Next
                    Debug.WriteLine("================================")

                    While reader.Read()
                        Debug.WriteLine($"Reading row with values:")
                        For i As Integer = 0 To reader.FieldCount - 1
                            Debug.WriteLine($"Column {i}: {reader.GetName(i)} = {reader(i)}")
                        Next

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
                        Debug.WriteLine($"Successfully added closing ID {fscClosing.ClosingID} to list")
                    End While
                End Using
            End Using

            Debug.WriteLine($"Total closings retrieved: {fscClosings.Count}")
        Catch ex As Exception
            Debug.WriteLine($"Error in GetFSCClosings: {ex.Message}")
            Debug.WriteLine($"Stack Trace: {ex.StackTrace}")
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
            Debug.WriteLine($"Error setting closing inactive: {ex.Message}")
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
            Debug.WriteLine($"Error updating closing: {ex.Message}")
            Return False
        End Try
    End Function
End Class
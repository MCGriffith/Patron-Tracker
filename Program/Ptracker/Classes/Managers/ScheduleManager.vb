Imports System.Data.OleDb

Public Class ScheduleManager
    Private ReadOnly _connectionString As String

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Structure ScheduleData
        Public ScheduleID As Integer
        Public DayOfWeek As Integer
        Public StartTime As String
        Public EndTime As String
        Public IsActive As Boolean
    End Structure

    Public Function AddSchedule(dayOfWeek As Integer, startTime As String, endTime As String) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("INSERT INTO tblSchedule (DayOfWeek, StartTime, EndTime, IsActive) VALUES (?, ?, ?, ?)", conn)
                    cmd.Parameters.AddWithValue("?", dayOfWeek)
                    cmd.Parameters.AddWithValue("?", startTime)
                    cmd.Parameters.AddWithValue("?", endTime)
                    cmd.Parameters.AddWithValue("?", True)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine($"Error adding schedule: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function GetActiveSchedules() As List(Of ScheduleData)
        Dim schedules As New List(Of ScheduleData)

        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("SELECT * FROM tblSchedule WHERE IsActive = True ORDER BY DayOfWeek, StartTime", conn)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim schedule As New ScheduleData With {
                            .ScheduleID = Convert.ToInt32(reader("ScheduleID")),
                            .DayOfWeek = Convert.ToInt32(reader("DayOfWeek")),
                            .StartTime = reader("StartTime").ToString(),
                            .EndTime = reader("EndTime").ToString(),
                            .IsActive = Convert.ToBoolean(reader("IsActive"))
                        }
                        schedules.Add(schedule)
                    End While
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine($"Error getting schedules: {ex.Message}")
        End Try

        Return schedules
    End Function

    Public Function UpdateSchedule(scheduleId As Integer, dayOfWeek As Integer, startTime As String, endTime As String) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("UPDATE tblSchedule SET DayOfWeek = ?, StartTime = ?, EndTime = ? WHERE ScheduleID = ?", conn)
                    cmd.Parameters.AddWithValue("?", dayOfWeek)
                    cmd.Parameters.AddWithValue("?", startTime)
                    cmd.Parameters.AddWithValue("?", endTime)
                    cmd.Parameters.AddWithValue("?", scheduleId)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine($"Error updating schedule: {ex.Message}")
            Return False
        End Try
    End Function

    Public Function SetScheduleStatus(scheduleId As Integer, isActive As Boolean) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("UPDATE tblSchedule SET IsActive = ? WHERE ScheduleID = ?", conn)
                    cmd.Parameters.AddWithValue("?", isActive)
                    cmd.Parameters.AddWithValue("?", scheduleId)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Debug.WriteLine($"Error setting schedule status: {ex.Message}")
            Return False
        End Try
    End Function
End Class
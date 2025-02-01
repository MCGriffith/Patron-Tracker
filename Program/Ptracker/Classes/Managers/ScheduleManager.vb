Imports System.Data.OleDb

Public Class Schedule
    Public Property ScheduleID As Integer
    Public Property DayOfWeek As Integer
    Public Property StartTime As String
    Public Property EndTime As String
    Public Property IsActive As Boolean
End Class

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
        If String.IsNullOrEmpty(startTime) OrElse String.IsNullOrEmpty(endTime) Then
            Return False
        End If

        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("INSERT INTO tblSchedule (DayOfWeek, StartTime, EndTime, IsActive) VALUES (?, ?, ?, ?)", conn)
                    cmd.Parameters.Add("DayOfWeek", OleDbType.Integer).Value = dayOfWeek
                    cmd.Parameters.Add("StartTime", OleDbType.VarChar).Value = startTime
                    cmd.Parameters.Add("EndTime", OleDbType.VarChar).Value = endTime
                    cmd.Parameters.Add("IsActive", OleDbType.Boolean).Value = True
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetActiveSchedules() As List(Of Schedule)
        Dim schedules As New List(Of Schedule)
        Using conn As New OleDbConnection(_connectionString)
            Dim sql As String = "SELECT ScheduleID, DayOfWeek, Format(StartTime,'HH:mm') as StartTime, " &
                       "Format(EndTime,'HH:mm') as EndTime, IsActive " &
                       "FROM tblSchedule WHERE IsActive = True " &
                       "AND StartTime IS NOT NULL AND EndTime IS NOT NULL " &
                       "ORDER BY DayOfWeek, StartTime"

            Using cmd As New OleDbCommand(sql, conn)
                conn.Open()
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Try
                            If Not reader.IsDBNull(reader.GetOrdinal("StartTime")) AndAlso
                           Not reader.IsDBNull(reader.GetOrdinal("EndTime")) Then
                                schedules.Add(New Schedule With {
                                .ScheduleID = reader("ScheduleID"),
                                .DayOfWeek = reader("DayOfWeek"),
                                .StartTime = Convert.ToDateTime(reader("StartTime")).ToString("HH:mm"),
                                .EndTime = Convert.ToDateTime(reader("EndTime")).ToString("HH:mm"),
                                .IsActive = reader("IsActive")
                            })
                            End If
                        Catch ex As Exception
                            Continue While
                        End Try
                    End While
                End Using
            End Using
        End Using
        Return schedules
    End Function

    Public Function UpdateSchedule(scheduleId As Integer, dayOfWeek As Integer, startTime As String, endTime As String) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("UPDATE tblSchedule SET DayOfWeek = ?, StartTime = ?, EndTime = ? WHERE ScheduleID = ?", conn)
                    cmd.Parameters.Add("DayOfWeek", OleDbType.Integer).Value = dayOfWeek
                    cmd.Parameters.Add("StartTime", OleDbType.VarChar).Value = startTime
                    cmd.Parameters.Add("EndTime", OleDbType.VarChar).Value = endTime
                    cmd.Parameters.Add("ScheduleID", OleDbType.Integer).Value = scheduleId
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function SetScheduleStatus(scheduleId As Integer, isActive As Boolean) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("UPDATE tblSchedule SET IsActive = ? WHERE ScheduleID = ?", conn)
                    cmd.Parameters.Add("IsActive", OleDbType.Boolean).Value = isActive
                    cmd.Parameters.Add("ScheduleID", OleDbType.Integer).Value = scheduleId

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
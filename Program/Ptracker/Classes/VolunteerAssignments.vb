Imports System.Data.OleDb

Public Class VolunteerAssignments
    Private ReadOnly connectionString As String = DatabaseConfig.ConnectionString

    Public Function GetEligibleVolunteers() As DataTable
        Using connection As New OleDbConnection(connectionString)
            Dim sql As String = "SELECT c.FullName, l.LoginID " &
                           "FROM tblContacts c " &
                           "INNER JOIN tblLogin l ON c.LoginID = l.LoginID " &
                           "WHERE l.Role IN ('Staff', 'Director', 'Admin') " &
                           "ORDER BY c.FullName"

            Using adapter As New OleDbDataAdapter(sql, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    Public Function GetVolunteerSchedule(loginId As Integer) As DataTable
        Using connection As New OleDbConnection(connectionString)
            Dim sql As String = "SELECT vs.VolunteerScheduleID, vs.StartDate, vs.EndDate, " &
                               "s.DayOfWeek, s.StartTime, s.EndTime " &
                               "FROM tblVolunteerSchedule vs " &
                               "INNER JOIN tblSchedule s ON vs.ScheduleID = s.ScheduleID " &
                               "WHERE vs.LoginID = ? " &
                               "ORDER BY s.DayOfWeek, s.StartTime"

            Using adapter As New OleDbDataAdapter(sql, connection)
                adapter.SelectCommand.Parameters.AddWithValue("@LoginID", loginId)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    Public Function GetAvailableSchedules() As DataTable
        Using connection As New OleDbConnection(connectionString)
            Dim sql As String = "SELECT ScheduleID, DayOfWeek, StartTime, EndTime " &
                           "FROM tblSchedule " &
                           "WHERE IsActive = True " &
                           "ORDER BY DayOfWeek, StartTime"

            Using adapter As New OleDbDataAdapter(sql, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    Public Function AssignVolunteerSchedule(loginId As Integer, scheduleId As Integer, startDate As Date, endDate As Date) As Boolean
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim sql As String = "INSERT INTO tblVolunteerSchedule " &
                                  "(LoginID, ScheduleID, StartDate, EndDate) " &
                                  "VALUES (?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@LoginID", loginId)
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                    cmd.Parameters.AddWithValue("@StartDate", startDate)
                    cmd.Parameters.AddWithValue("@EndDate", endDate)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Function RemoveVolunteerAssignment(volunteerScheduleId As Integer) As Boolean
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim sql As String = "DELETE FROM tblVolunteerSchedule WHERE VolunteerScheduleID = ?"

                Using cmd As New OleDbCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@VolunteerScheduleID", volunteerScheduleId)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function
End Class
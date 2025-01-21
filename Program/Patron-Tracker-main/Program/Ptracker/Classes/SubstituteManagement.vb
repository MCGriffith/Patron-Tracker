Imports System.Data.OleDb

Public Class SubstituteManagement
    Private ReadOnly connectionString As String = DatabaseConfig.ConnectionString

    Public Function GetVolunteers() As DataTable
        Using connection As New OleDbConnection(connectionString)
            Dim sql As String = "SELECT DISTINCT c.FullName, l.LoginID " &
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
            Dim sql As String = "SELECT DISTINCT vs.VolunteerScheduleID, s.DayOfWeek, " &
                           "s.StartTime, s.EndTime " &
                           "FROM tblVolunteerSchedule vs " &
                           "INNER JOIN tblSchedule s ON vs.ScheduleID = s.ScheduleID " &
                           "WHERE vs.LoginID = ? " &
                           "ORDER BY s.DayOfWeek, s.StartTime"

            Using adapter As New OleDbDataAdapter(sql, connection)
                adapter.SelectCommand.Parameters.AddWithValue("?", loginId)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    Public Function AssignSubstitute(scheduleId As Integer, originalId As Integer, substituteId As Integer, substituteDate As Date) As Boolean
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()

                ' First verify the schedule exists
                Dim verifySQL As String = "SELECT COUNT(*) FROM tblSchedule WHERE ScheduleID = ?"
                Using cmdVerify As New OleDbCommand(verifySQL, connection)
                    cmdVerify.Parameters.AddWithValue("?", scheduleId)
                    Dim count As Integer = CInt(cmdVerify.ExecuteScalar())
                End Using

                ' Get the schedule times
                Dim getTimesSQL As String = "SELECT s.StartTime, s.EndTime " &
                                      "FROM tblSchedule s " &
                                      "WHERE s.ScheduleID = ?"

                Dim startTime As Date
                Dim endTime As Date

                Using cmdTimes As New OleDbCommand(getTimesSQL, connection)
                    cmdTimes.Parameters.AddWithValue("?", scheduleId)
                    Using reader As OleDbDataReader = cmdTimes.ExecuteReader()
                        If reader.Read() Then
                            startTime = reader.GetDateTime(0)
                            endTime = reader.GetDateTime(1)
                        Else
                            Return False
                        End If
                    End Using
                End Using

                Dim sql As String = "INSERT INTO tblSubstitutes " &
                              "(SubstituteDate, SubStartTime, SubEndTime, OriginalLoginID, SubstituteLoginID, ScheduleID) " &
                              "VALUES (?, ?, ?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sql, connection)
                    cmd.Parameters.AddWithValue("?", substituteDate)
                    cmd.Parameters.AddWithValue("?", startTime)
                    cmd.Parameters.AddWithValue("?", endTime)
                    cmd.Parameters.AddWithValue("?", originalId)
                    cmd.Parameters.AddWithValue("?", substituteId)
                    cmd.Parameters.AddWithValue("?", scheduleId)

                    Dim result = cmd.ExecuteNonQuery()
                    Return result > 0
                End Using
            Catch ex As Exception

                Return False
            End Try
        End Using
    End Function

    Public Function GetAllSubstitutions(loginId As Integer) As DataTable
        Using connection As New OleDbConnection(connectionString)
            Dim sql As String = "SELECT s.SubstituteID, " &
                           "orig.FullName AS OriginalVolunteer, " &
                           "sub.FullName AS SubstituteVolunteer, " &
                           "s.SubstituteDate, s.SubStartTime, s.SubEndTime, " &
                           "IIf(s.SubstituteDate >= Date(), 'Active', 'Completed') AS Status " &
                           "FROM ((tblSubstitutes s " &
                           "INNER JOIN tblContacts orig ON s.OriginalLoginID = orig.LoginID) " &
                           "INNER JOIN tblContacts sub ON s.SubstituteLoginID = sub.LoginID) " &
                           "WHERE (s.OriginalLoginID = ? OR s.SubstituteLoginID = ?) " &
                           "AND s.Inactive = False " &
                           "ORDER BY s.SubstituteDate, s.SubStartTime"

            Using adapter As New OleDbDataAdapter(sql, connection)
                adapter.SelectCommand.Parameters.AddWithValue("?", loginId)
                adapter.SelectCommand.Parameters.AddWithValue("?", loginId)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    'Public Function RemoveSubstitute(substituteId As Integer) As Boolean
    '    Using connection As New OleDbConnection(connectionString)
    '        Try
    '            connection.Open()
    '            Dim sql As String = "DELETE FROM tblSubstitutes WHERE SubstituteID = ?"

    '            Using cmd As New OleDbCommand(sql, connection)
    '                cmd.Parameters.AddWithValue("@SubstituteID", substituteId)
    '                Return cmd.ExecuteNonQuery() > 0
    '            End Using
    '        Catch ex As Exception
    '            Return False
    '        End Try
    '    End Using
    'End Function


    Public Function RemoveSubstitute(substituteId As Integer) As Boolean
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()

                ' Use Yes/No for Access Boolean field
                Dim sql As String = "UPDATE tblSubstitutes SET Inactive = Yes WHERE SubstituteID = ?"

                Using cmd As New OleDbCommand(sql, connection)
                    cmd.Parameters.AddWithValue("?", substituteId)
                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function


    Public Function GetOriginalSubstitutions(loginId As Integer) As DataTable
        Using connection As New OleDbConnection(connectionString)
            Dim sql As String = "SELECT s.SubstituteID, " &
                           "orig.FullName AS OriginalVolunteer, " &
                           "sub.FullName AS SubstituteVolunteer, " &
                           "s.SubstituteDate, s.SubStartTime, s.SubEndTime, " &
                           "IIf(s.SubstituteDate >= Date(), 'Active', 'Completed') AS Status " &
                           "FROM ((tblSubstitutes s " &
                           "INNER JOIN tblContacts orig ON s.OriginalLoginID = orig.LoginID) " &
                           "INNER JOIN tblContacts sub ON s.SubstituteLoginID = sub.LoginID) " &
                           "WHERE s.OriginalLoginID = ? " &
                           "AND s.Inactive = False " &
                           "ORDER BY s.SubstituteDate, s.SubStartTime"

            Using adapter As New OleDbDataAdapter(sql, connection)
                adapter.SelectCommand.Parameters.AddWithValue("?", loginId)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function

    Public Sub InactivatePastSubstitutions()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim sql As String = "UPDATE tblSubstitutes SET Inactive = True " &
                               "WHERE SubstituteDate < Date() AND Inactive = False"
                Using cmd As New OleDbCommand(sql, connection)
                    cmd.ExecuteNonQuery()
                End Using
            Catch ex As Exception
            End Try
        End Using
    End Sub

    Public Function GetScheduleWithSubstitute(loginId As Integer) As DataTable
        Using connection As New OleDbConnection(connectionString)
            Dim sql As String = "SELECT vs.VolunteerScheduleID, s.DayOfWeek, " &
                           "s.StartTime, s.EndTime, " &
                           "subs.SubstituteDate, " &
                           "sub.FullName AS SubstituteName " &
                           "FROM ((tblVolunteerSchedule vs " &
                           "INNER JOIN tblSchedule s ON vs.ScheduleID = s.ScheduleID) " &
                           "LEFT JOIN tblSubstitutes subs ON vs.ScheduleID = subs.ScheduleID) " &
                           "LEFT JOIN tblContacts sub ON subs.SubstituteLoginID = sub.LoginID " &
                           "WHERE vs.LoginID = ? " &
                           "ORDER BY s.DayOfWeek, s.StartTime"

            Using cmd As New OleDbCommand(sql, connection)
                cmd.Parameters.Add("?", OleDbType.Integer).Value = loginId
                Using adapter As New OleDbDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function
End Class
Imports System.Data.OleDb

Public Class VolunteerManager
    Private ReadOnly _connectionString As String
    Private ReadOnly _dayHelper As New DayOfWeekHelper()

    Public Sub New(connectionString As String)
        _connectionString = connectionString
    End Sub

    Public Structure VolunteerData
        Public VolunteerID As Integer
        Public ScheduleID As Integer
        Public ContactID As Integer
        Public StartDate As Date
        Public EndDate As Date
        Public IsActive As Boolean
    End Structure

    Public Function AddVolunteer(scheduleId As Integer, contactId As Integer, startDate As Date, endDate As Date) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("INSERT INTO tblVolunteer (ScheduleID, ContactID, StartDate, EndDate, IsActive) VALUES (?, ?, ?, ?, ?)", conn)
                    cmd.Parameters.AddWithValue("?", scheduleId)
                    cmd.Parameters.AddWithValue("?", contactId)
                    cmd.Parameters.AddWithValue("?", startDate)
                    cmd.Parameters.AddWithValue("?", endDate)
                    cmd.Parameters.AddWithValue("?", True)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetActiveVolunteers() As List(Of VolunteerData)
        Dim volunteers As New List(Of VolunteerData)

        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("SELECT * FROM tblVolunteer WHERE IsActive = True ORDER BY StartDate", conn)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim volunteer As New VolunteerData With {
                            .VolunteerID = Convert.ToInt32(reader("VolunteerID")),
                            .ScheduleID = Convert.ToInt32(reader("ScheduleID")),
                            .ContactID = Convert.ToInt32(reader("ContactID")),
                            .StartDate = Convert.ToDateTime(reader("StartDate")),
                            .EndDate = Convert.ToDateTime(reader("EndDate")),
                            .IsActive = Convert.ToBoolean(reader("IsActive"))
                        }
                        volunteers.Add(volunteer)
                    End While
                End Using
            End Using
        Catch ex As Exception
        End Try

        Return volunteers
    End Function

    Public Function GetVolunteersBySchedule(scheduleId As Integer) As List(Of VolunteerData)
        Dim volunteers As New List(Of VolunteerData)

        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("SELECT * FROM tblVolunteer WHERE ScheduleID = ? AND IsActive = True ORDER BY StartDate", conn)
                    cmd.Parameters.AddWithValue("?", scheduleId)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    While reader.Read()
                        Dim volunteer As New VolunteerData With {
                            .VolunteerID = Convert.ToInt32(reader("VolunteerID")),
                            .ScheduleID = Convert.ToInt32(reader("ScheduleID")),
                            .ContactID = Convert.ToInt32(reader("ContactID")),
                            .StartDate = Convert.ToDateTime(reader("StartDate")),
                            .EndDate = Convert.ToDateTime(reader("EndDate")),
                            .IsActive = Convert.ToBoolean(reader("IsActive"))
                        }
                        volunteers.Add(volunteer)
                    End While
                End Using
            End Using
        Catch ex As Exception
        End Try

        Return volunteers
    End Function

    Public Function UpdateVolunteer(volunteerId As Integer, startDate As Date, endDate As Date) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("UPDATE tblVolunteer SET StartDate = ?, EndDate = ? WHERE VolunteerID = ?", conn)
                    cmd.Parameters.AddWithValue("?", startDate)
                    cmd.Parameters.AddWithValue("?", endDate)
                    cmd.Parameters.AddWithValue("?", volunteerId)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function SetVolunteerStatus(volunteerId As Integer, isActive As Boolean) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Using cmd As New OleDbCommand("UPDATE tblVolunteer SET IsActive = ? WHERE VolunteerID = ?", conn)
                    cmd.Parameters.AddWithValue("?", isActive)
                    cmd.Parameters.AddWithValue("?", volunteerId)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function GetEligibleContacts() As DataTable
        Dim dt As New DataTable
        Try
            Using conn As New OleDbConnection(_connectionString)
                Dim sql As String = "SELECT ContactID, FullName FROM tblContacts C " &
                                   "INNER JOIN tblLogin L ON C.LoginID = L.LoginID " &
                                   "WHERE L.Role IN ('Staff', 'Director', 'Admin') " &
                                   "ORDER BY FullName"

                Using cmd As New OleDbCommand(sql, conn)
                    conn.Open()
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function GetSchedulesForCombo() As DataTable
        Dim dt As New DataTable
        Try
            Using conn As New OleDbConnection(_connectionString)
                Dim sql As String = "SELECT s.ScheduleID, s.DayOfWeek, " &
                               "Format(s.StartTime,'HH:mm') as StartTime, " &
                               "Format(s.EndTime,'HH:mm') as EndTime " &
                               "FROM tblSchedule s " &
                               "WHERE s.IsActive = True " &
                               "ORDER BY s.DayOfWeek, s.StartTime"

                Using cmd As New OleDbCommand(sql, conn)
                    conn.Open()
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using

                ' Add computed column for display
                dt.Columns.Add("DisplayText", GetType(String))
                For Each row As DataRow In dt.Rows
                    Dim dayName = _dayHelper.GetDayName(CInt(row("DayOfWeek")))
                    row("DisplayText") = $"{dayName} {row("StartTime")} - {row("EndTime")}"
                Next
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function GetVolunteerSchedules(contactId As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Using conn As New OleDbConnection(_connectionString)
                Dim sql As String = "SELECT s.ScheduleID, s.DayOfWeek, s.StartTime, s.EndTime, s.IsActive " &
                "FROM ((tblSchedule s " &
                "INNER JOIN tblVolunteerSchedule vs ON s.ScheduleID = vs.ScheduleID) " &
                "INNER JOIN tblLogin l ON l.LoginID = vs.LoginID) " &
                "INNER JOIN tblContacts c ON c.LoginID = l.LoginID " &
                "WHERE s.IsActive = True AND c.ContactID = ? " &
                "ORDER BY s.DayOfWeek, s.StartTime"

                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("ContactID", contactId)
                    conn.Open()
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function



    Public Function GetVolunteerSubstitutions(contactId As Integer) As DataTable
        Dim dt As New DataTable
        Try
            Using conn As New OleDbConnection(_connectionString)
                Dim sql As String = "SELECT c1.FullName AS Volunteer, c2.FullName AS Substitute, " &
                               "s.DayOfWeek, s.StartTime, s.EndTime, s.IsActive " &
                               "FROM tblSchedule s " &
                               "INNER JOIN tblVolunteer v ON s.ScheduleID = v.ScheduleID " &
                               "INNER JOIN tblContacts c1 ON v.ContactID = c1.ContactID " &
                               "INNER JOIN tblContacts c2 ON v.SubstituteID = c2.ContactID " &
                               "WHERE (v.ContactID = ? OR v.SubstituteID = ?) AND v.IsActive = True " &
                               "ORDER BY s.DayOfWeek, s.StartTime"

                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", contactId)
                    cmd.Parameters.AddWithValue("?", contactId)
                    conn.Open()
                    Using adapter As New OleDbDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dt
    End Function

    Public Function AssignScheduleToVolunteer(contactId As Integer, scheduleId As Integer) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                ' Get LoginID from ContactID
                Dim loginIdSql As String = "SELECT LoginID FROM tblContacts WHERE ContactID = ?"
                Dim loginId As Integer

                Using cmdLogin As New OleDbCommand(loginIdSql, conn)
                    cmdLogin.Parameters.AddWithValue("?", contactId)
                    conn.Open()
                    loginId = CInt(cmdLogin.ExecuteScalar())

                    ' Insert new volunteer schedule assignment
                    Dim insertSql As String = "INSERT INTO tblVolunteerSchedule (LoginID, ScheduleID) VALUES (?, ?)"
                    Using cmdInsert As New OleDbCommand(insertSql, conn)
                        cmdInsert.Parameters.AddWithValue("?", loginId)
                        cmdInsert.Parameters.AddWithValue("?", scheduleId)
                        cmdInsert.ExecuteNonQuery()
                    End Using
                End Using
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function DeactivateVolunteerSchedule(contactId As Integer, scheduleId As Integer) As Boolean
        Try
            Using conn As New OleDbConnection(_connectionString)
                Dim sql As String = "UPDATE tblVolunteerSchedule " &
                               "SET IsActive = False " &
                               "WHERE ScheduleID = ? AND LoginID = " &
                               "(SELECT LoginID FROM tblContacts WHERE ContactID = ?)"

                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", scheduleId)
                    cmd.Parameters.AddWithValue("?", contactId)
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
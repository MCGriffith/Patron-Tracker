Imports System.Data.OleDb

Public Class ScheduleQueries
    Private _relationships As New VolunteerRelationships()

    Public Function GetActiveVolunteerSchedules(volunteerId As Integer) As DataTable
        Dim sql As String = "SELECT VS.VolunteerScheduleID, VS.DayOfWeek, " &
                       "VS.StartTime, VS.EndTime, VS.StartDate, VS.EndDate, " &
                       "VS.SubstituteLoginID " &
                       "FROM tblVolunteerSchedule VS " &
                       "WHERE VS.VolunteerID = @VolunteerID " &
                       "AND VS.Active = True " &
                       "ORDER BY VS.DayOfWeek, VS.StartTime"

        Dim dt As New DataTable()
        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using da As New OleDbDataAdapter(sql, conn)
                da.SelectCommand.Parameters.AddWithValue("@VolunteerID", volunteerId)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function GetActiveVolunteerSchedulesWithSubstitutes() As DataTable
        Dim sql As String = "SELECT vs.VolunteerScheduleID, vs.StartDate, vs.EndDate, " &
                           "vs.LoginID, vs.ScheduleID, " &
                           "s.SubstituteLoginID, s.SubstituteDate " &
                           "FROM tblVolunteerSchedule vs " &
                           "LEFT JOIN tblSubstitutes s ON vs.ScheduleID = s.ScheduleID " &
                           "WHERE vs.EndDate >= Date() " &
                           "ORDER BY vs.StartDate, vs.LoginID"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Dim dt As New DataTable()
                conn.Open()
                dt.Load(cmd.ExecuteReader())
                Return dt
            End Using
        End Using
    End Function

    Public Function UpdateScheduleStatus(scheduleId As Integer, isActive As Boolean) As Boolean
        Dim sql As String = "UPDATE tblSchedule SET IsActive = @IsActive WHERE ScheduleID = @ScheduleID"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@IsActive", isActive)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function GetFormattedScheduleData() As DataTable
        Debug.WriteLine("=== Executing GetFormattedScheduleData ===")

        Dim sql As String = "SELECT VS.VolunteerScheduleID, VS.StartDate, VS.EndDate, " &
                       "VS.LoginID AS SubstituteLoginID, VS.ScheduleID, " &
                       "S.DayOfWeek, S.StartTime, S.EndTime " &
                       "FROM tblVolunteerSchedule VS " &
                       "INNER JOIN tblSchedule S ON VS.ScheduleID = S.ScheduleID"

        Debug.WriteLine($"SQL: {sql}")

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using da As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                Debug.WriteLine($"Rows retrieved: {dt.Rows.Count}")
                Return dt
            End Using
        End Using
    End Function

    Public Shared ReadOnly Property ConnectionString As String
        Get
            Debug.WriteLine("Getting connection string...")
            Return "Provider=Microsoft.ACE.OLEDB.12.0;" &
               "Data Source=" & Application.StartupPath & "\PTracker.accdb"
        End Get
    End Property

    Public Function GetSubstituteDetailsForSchedule(scheduleId As Integer) As DataTable
        Dim sql As String = "SELECT VS.SubstituteLoginID, VS.SubstituteDate " &
                       "FROM tblVolunteerSchedule VS " &
                       "WHERE VS.VolunteerScheduleID = @ScheduleID " &
                       "AND VS.Active = True " &
                       "AND VS.SubstituteLoginID IS NOT NULL"

        Dim dt As New DataTable()
        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using da As New OleDbDataAdapter(sql, conn)
                da.SelectCommand.Parameters.AddWithValue("@ScheduleID", scheduleId)
                da.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function ValidateSubstituteDate(scheduleId As Integer, substituteDate As Date) As Boolean
        Dim sql As String = "SELECT StartDate, EndDate " &
                       "FROM tblVolunteerSchedule " &
                       "WHERE VolunteerScheduleID = @ScheduleID"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                conn.Open()
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim startDate As Date = CDate(reader("StartDate"))
                        Dim endDate As Date = If(reader("EndDate") IsNot DBNull.Value,
                                           CDate(reader("EndDate")),
                                           DateTime.MaxValue)
                        Return substituteDate >= startDate AndAlso substituteDate <= endDate
                    End If
                End Using
            End Using
        End Using
        Return False
    End Function

    Public Function CheckExistingSubstitute(scheduleId As Integer, substituteDate As Date) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tblVolunteerSchedule " &
                       "WHERE VolunteerScheduleID = @ScheduleID " &
                       "AND SubstituteDate = @SubstituteDate " &
                       "AND SubstituteLoginID IS NOT NULL"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                cmd.Parameters.AddWithValue("@SubstituteDate", substituteDate)
                conn.Open()
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Public Function CreateSubstituteAssignment(scheduleId As Integer, originalId As Integer, substituteId As Integer, substituteDate As Date) As Boolean
        Dim sql As String = "UPDATE tblVolunteerSchedule " &
                       "SET SubstituteLoginID = @SubstituteID, " &
                       "SubstituteDate = @SubstituteDate " &
                       "WHERE VolunteerScheduleID = @ScheduleID " &
                       "AND VolunteerID = @OriginalID"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@SubstituteID", substituteId)
                cmd.Parameters.AddWithValue("@SubstituteDate", substituteDate)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                cmd.Parameters.AddWithValue("@OriginalID", originalId)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function RemoveSubstituteAssignment(scheduleId As Integer, substituteDate As Date) As Boolean
        Dim sql As String = "UPDATE tblVolunteerSchedule " &
                       "SET SubstituteLoginID = NULL, " &
                       "SubstituteDate = NULL " &
                       "WHERE VolunteerScheduleID = @ScheduleID " &
                       "AND SubstituteDate = @SubstituteDate"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                cmd.Parameters.AddWithValue("@SubstituteDate", substituteDate)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function ValidateSubstituteRemoval(scheduleId As Integer, substituteDate As Date) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tblSubstitutes " &
                           "WHERE ScheduleID = @ScheduleID " &
                           "AND SubstituteDate = @SubDate " &
                           "AND Inactive = False"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                cmd.Parameters.AddWithValue("@SubDate", substituteDate)
                conn.Open()
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    Public Function LogSubstituteHistory(scheduleId As Integer, originalId As Integer,
                                   substituteId As Integer, substituteDate As Date,
                                   action As String) As Boolean
        Dim sql As String = "INSERT INTO tblSubstituteHistory " &
                           "(ScheduleID, OriginalLoginID, SubstituteLoginID, " &
                           "SubstituteDate, Action, ActionDate) " &
                           "VALUES (@ScheduleID, @OriginalID, @SubstituteID, " &
                           "@SubDate, @Action, @ActionDate)"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                cmd.Parameters.AddWithValue("@OriginalID", originalId)
                cmd.Parameters.AddWithValue("@SubstituteID", substituteId)
                cmd.Parameters.AddWithValue("@SubDate", substituteDate)
                cmd.Parameters.AddWithValue("@Action", action)
                cmd.Parameters.AddWithValue("@ActionDate", DateTime.Now)

                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function GetSubstituteHistory(scheduleId As Integer) As DataTable
        Dim sql As String = "SELECT sh.SubstituteDate, " &
                           "oc.FullName AS OriginalVolunteer, " &
                           "sc.FullName AS SubstituteVolunteer, " &
                           "sh.Action, sh.ActionDate " &
                           "FROM tblSubstituteHistory sh " &
                           "INNER JOIN tblContacts oc ON sh.OriginalLoginID = oc.LoginID " &
                           "INNER JOIN tblContacts sc ON sh.SubstituteLoginID = sc.LoginID " &
                           "WHERE sh.ScheduleID = @ScheduleID " &
                           "ORDER BY sh.ActionDate DESC"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                Dim dt As New DataTable()
                conn.Open()
                dt.Load(cmd.ExecuteReader())
                Return dt
            End Using
        End Using
    End Function

    Public Function GetVolunteerName(loginId As Integer) As String
        Dim sql As String = "SELECT FullName FROM tblContacts WHERE LoginID = @LoginID"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@LoginID", loginId)
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                Return If(result IsNot Nothing, result.ToString(), String.Empty)
            End Using
        End Using
    End Function

    Public Function GetDayName(dayNumber As Integer) As String
        If dayNumber >= 1 AndAlso dayNumber <= 7 Then
            Return WeekdayName(dayNumber)
        Else
            Return "Invalid Day"
        End If
    End Function

    Public Function GetAllSchedules() As DataTable
        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Debug.WriteLine("=== Getting Schedules ===")
            Dim sql As String = "SELECT ScheduleID, DayOfWeek, StartTime, EndTime, IsActive " &
                       "FROM tblSchedule " &
                       "WHERE IsActive = True " &
                       "ORDER BY DayOfWeek, Format(StartTime, 'HH:mm')"
            Using cmd As New OleDbCommand(sql, conn)
                Dim dt As New DataTable()
                conn.Open()
                dt.Load(cmd.ExecuteReader())
                Return dt
            End Using
        End Using
    End Function

    Public Function UpdateSchedule(scheduleId As Integer, dayOfWeek As Integer, startTime As Date, endTime As Date) As Boolean
        Using connection As New OleDbConnection(DatabaseConfig.ConnectionString)
            Try
                connection.Open()
                Dim sql As String = "UPDATE tblSchedule SET DayOfWeek = ?, StartTime = ?, EndTime = ? WHERE ScheduleID = ?"
                Using cmd As New OleDbCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@DayOfWeek", dayOfWeek)
                    cmd.Parameters.AddWithValue("@StartTime", startTime)
                    cmd.Parameters.AddWithValue("@EndTime", endTime)
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleId)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Function AddSchedule(dayOfWeek As Integer, startTime As Date, endTime As Date, isActive As Boolean) As Integer
        Dim sql As String = "INSERT INTO tblSchedule (DayOfWeek, StartTime, EndTime, IsActive) VALUES (?, ?, ?, ?)"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                With cmd.Parameters
                    .Add("DayOfWeek", OleDbType.Integer).Value = dayOfWeek
                    .Add("StartTime", OleDbType.Date).Value = startTime
                    .Add("EndTime", OleDbType.Date).Value = endTime
                    .Add("IsActive", OleDbType.Boolean).Value = isActive
                End With

                conn.Open()
                cmd.ExecuteNonQuery()

                ' Get the new ID in a separate command
                cmd.CommandText = "SELECT @@IDENTITY"
                Return CInt(cmd.ExecuteScalar())
            End Using
        End Using
    End Function

    Public Function ValidateSchedule(dayOfWeek As Integer, startTime As Date, endTime As Date) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tblSchedule " &
                           "WHERE DayOfWeek = @DayOfWeek " &
                           "AND ((StartTime <= @StartTime AND EndTime > @StartTime) " &
                           "OR (StartTime < @EndTime AND EndTime >= @EndTime))"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@DayOfWeek", dayOfWeek)
                cmd.Parameters.AddWithValue("@StartTime", startTime)
                cmd.Parameters.AddWithValue("@EndTime", endTime)
                conn.Open()
                Return CInt(cmd.ExecuteScalar()) = 0
            End Using
        End Using
    End Function
End Class
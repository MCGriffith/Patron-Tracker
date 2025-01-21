Imports System.Data.OleDb

Public Class VolunteerRelationships
    ' Properties to manage the relationships
    Private _originalLoginID As Integer
    Private _substituteLoginID As Integer
    Private _scheduleID As Integer

    ' Method to validate volunteer-substitute relationship
    Public Function ValidateVolunteerSubstitute(originalID As Integer, substituteID As Integer) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM tblSubstitutes " &
                           "WHERE OriginalLoginID = @OriginalID " &
                           "AND SubstituteLoginID = @SubstituteID " &
                           "AND Inactive = False"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@OriginalID", originalID)
                cmd.Parameters.AddWithValue("@SubstituteID", substituteID)
                conn.Open()
                Return CInt(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function

    ' Method to create new volunteer-substitute relationship
    Public Function CreateVolunteerSubstituteLink(originalID As Integer, substituteID As Integer, scheduleID As Integer) As Boolean
        Dim sql As String = "INSERT INTO tblSubstitutes (OriginalLoginID, SubstituteLoginID, ScheduleID, Inactive) " &
                           "VALUES (@OriginalID, @SubstituteID, @ScheduleID, False)"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@OriginalID", originalID)
                cmd.Parameters.AddWithValue("@SubstituteID", substituteID)
                cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)
                conn.Open()
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
End Class
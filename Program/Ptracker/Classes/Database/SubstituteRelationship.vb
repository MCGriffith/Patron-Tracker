Imports System.Data.OleDb

Public Class SubstituteRelationship
    Private ReadOnly connectionString As String = DatabaseConfig.ConnectionString

    Public Function CreateSubstituteRelationship(originalLoginID As Integer, substituteLoginID As Integer, scheduleID As Integer, substituteDate As Date, startTime As Date, endTime As Date) As Boolean
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim sql As String = "INSERT INTO tblSubstitutes (ScheduleDate, SubStartTime, SubEndDate, OriginalLoginID, SubstituteID, ScheduleID) " &
                                  "VALUES (?, ?, ?, ?, ?, ?)"

                Using cmd As New OleDbCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@ScheduleDate", substituteDate)
                    cmd.Parameters.AddWithValue("@SubStartTime", startTime)
                    cmd.Parameters.AddWithValue("@SubEndDate", endTime)
                    cmd.Parameters.AddWithValue("@OriginalLoginID", originalLoginID)
                    cmd.Parameters.AddWithValue("@SubstituteID", substituteLoginID)
                    cmd.Parameters.AddWithValue("@ScheduleID", scheduleID)

                    Dim rowsAffected = cmd.ExecuteNonQuery()
                    Return rowsAffected > 0
                End Using
            Catch ex As Exception
                ' Log error here if needed
                Return False
            End Try
        End Using
    End Function

    Public Function ValidateRelationship(originalLoginID As Integer, substituteLoginID As Integer) As Boolean
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim sql As String = "SELECT COUNT(*) FROM tblLogin " &
                                  "WHERE LoginID IN (?, ?) " &
                                  "AND Role IN ('Staff', 'Director', 'Admin')"

                Using cmd As New OleDbCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@Original", originalLoginID)
                    cmd.Parameters.AddWithValue("@Substitute", substituteLoginID)

                    Dim count As Integer = CInt(cmd.ExecuteScalar())
                    Return count = 2
                End Using
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function
End Class

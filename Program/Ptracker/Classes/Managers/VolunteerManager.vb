Imports System.Data.OleDb

Public Class VolunteerManager
    Private ReadOnly _connectionString As String

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
            Debug.WriteLine($"Error adding volunteer: {ex.Message}")
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
            Debug.WriteLine($"Error getting volunteers: {ex.Message}")
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
            Debug.WriteLine($"Error getting volunteers by schedule: {ex.Message}")
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
            Debug.WriteLine($"Error updating volunteer: {ex.Message}")
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
            Debug.WriteLine($"Error setting volunteer status: {ex.Message}")
            Return False
        End Try
    End Function
End Class
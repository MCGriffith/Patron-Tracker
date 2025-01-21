Public Class DayOfWeekHelper
    Public Shared Function GetDayName(dayNumber As Integer) As String
        If dayNumber >= 1 AndAlso dayNumber <= 7 Then
            Return WeekdayName(dayNumber)
        End If
        Return "Invalid Day"
    End Function

    Public Shared Function GetDayValue(dayName As String) As Integer
        Select Case dayName.Trim().ToUpper()
            Case "SUNDAY" : Return 1
            Case "MONDAY" : Return 2
            Case "TUESDAY" : Return 3
            Case "WEDNESDAY" : Return 4
            Case "THURSDAY" : Return 5
            Case "FRIDAY" : Return 6
            Case "SATURDAY" : Return 7
            Case Else : Return 1
        End Select
    End Function
End Class
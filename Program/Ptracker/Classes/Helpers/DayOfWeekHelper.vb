Public Class DayOfWeekHelper

    Public Function GetDayName(dayNumber As Integer) As String
        Select Case dayNumber
            Case 1
                Return "Sunday"
            Case 2
                Return "Monday"
            Case 3
                Return "Tuesday"
            Case 4
                Return "Wednesday"
            Case 5
                Return "Thursday"
            Case 6
                Return "Friday"
            Case 7
                Return "Saturday"
            Case Else
                Return String.Empty
        End Select
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
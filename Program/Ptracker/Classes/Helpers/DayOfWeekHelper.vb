Public Class DayOfWeekHelper

    Public Function GetDayName(dayNumber As Integer) As String
        Select Case dayNumber
            Case 0
                Return "Sunday"
            Case 1
                Return "Monday"
            Case 2
                Return "Tuesday"
            Case 3
                Return "Wednesday"
            Case 4
                Return "Thursday"
            Case 5
                Return "Friday"
            Case 6
                Return "Saturday"
            Case Else
                Return String.Empty
        End Select
    End Function

    Public Shared Function GetDayValue(dayName As String) As Integer
        Select Case dayName.Trim().ToUpper()
            Case "SUNDAY" : Return 0
            Case "MONDAY" : Return 1
            Case "TUESDAY" : Return 2
            Case "WEDNESDAY" : Return 3
            Case "THURSDAY" : Return 4
            Case "FRIDAY" : Return 5
            Case "SATURDAY" : Return 6
            Case Else : Return 0
        End Select
    End Function
End Class
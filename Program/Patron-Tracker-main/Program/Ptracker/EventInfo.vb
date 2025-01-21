Public Class EventInfo
    Public Property EventID As Integer
    Public Property EventName As String
    Public Property EventDate As Date
    Public Property RegisterDate As Date
    Public Property Inactive As Boolean = False
    Public Property IsSelected As Boolean = False

    Public Overrides Function Equals(obj As Object) As Boolean
        If TypeOf obj Is EventInfo Then
            Dim other As EventInfo = DirectCast(obj, EventInfo)
            Return Me.EventID = other.EventID
        End If
        Return False
    End Function
End Class
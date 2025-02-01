Public Class ListViewColumnSorter
    Implements IComparer

    Private ColumnToSort As Integer
    Private OrderOfSort As SortOrder
    Private ObjectCompare As CaseInsensitiveComparer
    Private ReadOnly _dayHelper As New DayOfWeekHelper()

    Public Sub New()
        ColumnToSort = 0
        OrderOfSort = SortOrder.None
        ObjectCompare = New CaseInsensitiveComparer()
    End Sub

    Public Property SortColumn() As Integer
        Get
            Return ColumnToSort
        End Get
        Set(ByVal Value As Integer)
            ColumnToSort = Value
        End Set
    End Property

    Public Property Order() As SortOrder
        Get
            Return OrderOfSort
        End Get
        Set(ByVal Value As SortOrder)
            OrderOfSort = Value
        End Set
    End Property

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
        Dim itemX As ListViewItem = DirectCast(x, ListViewItem)
        Dim itemY As ListViewItem = DirectCast(y, ListViewItem)

        Dim dayX = DayOfWeekHelper.GetDayValue(itemX.Text)
        Dim dayY = DayOfWeekHelper.GetDayValue(itemY.Text)

        If dayX <> dayY Then Return dayX - dayY

        Return DateTime.Parse(itemX.SubItems(1).Text).TimeOfDay.CompareTo(DateTime.Parse(itemY.SubItems(1).Text).TimeOfDay)
    End Function
End Class


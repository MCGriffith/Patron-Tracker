Public Class ListViewColumnSorter
    Implements IComparer

    Private ColumnToSort As Integer
    Private OrderOfSort As SortOrder
    Private ObjectCompare As CaseInsensitiveComparer

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
        Dim compareResult As Integer
        Dim listviewX As ListViewItem
        Dim listviewY As ListViewItem

        listviewX = CType(x, ListViewItem)
        listviewY = CType(y, ListViewItem)

        compareResult = ObjectCompare.Compare(listviewX.SubItems(ColumnToSort).Text, listviewY.SubItems(ColumnToSort).Text)

        If OrderOfSort = SortOrder.Ascending Then
            Return compareResult
        ElseIf OrderOfSort = SortOrder.Descending Then
            Return (-compareResult)
        Else
            Return 0
        End If
    End Function
End Class


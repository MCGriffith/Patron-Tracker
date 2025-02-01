Public Class CustomCalendar
    Inherits Panel

    Private _currentDate As DateTime = DateTime.Today
    Private _cellWidth As Integer = 110
    Private _cellHeight As Integer = 70
    Private _headerHeight As Integer = 30
    Private _titleHeight As Integer = 40
    Private _dayHeaders() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}

    Public Event CalendarClicked(sender As Object, e As EventArgs)

    Public Sub New()
        DoubleBuffered = True
        Size = New Size(780, 500)  ' Reduced from 770 to 750
        BackColor = Color.White  ' Add this line
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        DrawCalendar(e.Graphics)
    End Sub

    Private Sub DrawCalendar(g As Graphics)
        ' Draw month and year title
        Dim titleRect As New Rectangle(0, 0, Width, _titleHeight)
        Dim monthTitle As String = _currentDate.ToString("MMMM yyyy")
        TextRenderer.DrawText(g, monthTitle, New Font(Font.FontFamily, 14, FontStyle.Bold),
                            titleRect, Color.Black,
                            TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)

        ' Draw day headers
        For i As Integer = 0 To 6
            Dim headerRect As New Rectangle(i * _cellWidth, _titleHeight, _cellWidth, _headerHeight)
            g.DrawRectangle(Pens.Gray, headerRect)
            TextRenderer.DrawText(g, _dayHeaders(i), Font, headerRect,
                                Color.Black, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        Next

        ' Calculate first day of month
        Dim firstDay As New DateTime(_currentDate.Year, _currentDate.Month, 1)
        Dim startingDayOfWeek As Integer = firstDay.DayOfWeek
        Dim daysInMonth As Integer = DateTime.DaysInMonth(_currentDate.Year, _currentDate.Month)

        ' Draw day cells
        Dim currentDay As Integer = 1
        For row As Integer = 0 To 5
            For col As Integer = 0 To 6
                Dim cellRect As New Rectangle(col * _cellWidth,
                                           (row * _cellHeight) + _headerHeight + _titleHeight,
                                           _cellWidth, _cellHeight)
                g.DrawRectangle(Pens.Gray, cellRect)

                If (row = 0 AndAlso col >= startingDayOfWeek) OrElse
                   (row > 0 AndAlso currentDay <= daysInMonth) Then
                    TextRenderer.DrawText(g, currentDay.ToString(), Font, cellRect,
                                        Color.Black, TextFormatFlags.Top Or TextFormatFlags.Left)
                    currentDay += 1
                End If
            Next
        Next
    End Sub

    Public Sub NavigateToMonth(forward As Boolean)
        If forward Then
            _currentDate = _currentDate.AddMonths(1)
        Else
            _currentDate = _currentDate.AddMonths(-1)
        End If
        Invalidate()
    End Sub

    Public Sub NavigateToCurrentMonth()
        _currentDate = DateTime.Today
        Invalidate()
    End Sub

    Public ReadOnly Property CurrentDate As DateTime
        Get
            Return _currentDate
        End Get
    End Property

    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        MyBase.OnMouseClick(e)
        RaiseEvent CalendarClicked(Me, e)
    End Sub

    Public Sub LoadClosures(currentMonth As DateTime)
        ' Placeholder for closure loading
        Invalidate()
    End Sub

    Public Sub LoadVolunteerSchedules(currentMonth As DateTime)
        ' Placeholder for volunteer schedule loading
        Invalidate()
    End Sub

    Protected Overrides Sub OnSizeChanged(e As EventArgs)
        MyBase.OnSizeChanged(e)

        ' Calculate cell dimensions based on control size
        _cellWidth = (Width - 1) \ 7
        _cellHeight = (Height - _titleHeight - _headerHeight - 1) \ 6

        Invalidate()
    End Sub
End Class


Public Class FrmCalendarView

    Private _currentViewDate As DateTime
    Private _expandedCalendar As CustomCalendar
    Private _btnPrevMonth As Button
    Private _btnNextMonth As Button

    Private Sub FrmCalendarView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeExpandedCalendar()
    End Sub

    Public Sub New(currentDate As DateTime)
        InitializeComponent()
        _currentViewDate = currentDate
    End Sub

    Private Sub InitializeExpandedCalendar()
        _expandedCalendar = New CustomCalendar()
        With _expandedCalendar
            .Location = New Point(50, 50)
            .Size = New Size(ClientSize.Width - 100, ClientSize.Height - 150)
        End With

        ' Add navigation buttons
        _btnPrevMonth = New Button()
        _btnNextMonth = New Button()

        With _btnPrevMonth
            .Text = "Previous Month"
            .Location = New Point(50, _expandedCalendar.Bottom + 10)
            .Size = New Size(120, 35)
            AddHandler .Click, AddressOf btnPrevMonth_Click
        End With

        With _btnNextMonth
            .Text = "Next Month"
            .Location = New Point(_btnPrevMonth.Right + 10, _btnPrevMonth.Top)
            .Size = New Size(120, 35)
            AddHandler .Click, AddressOf btnNextMonth_Click
        End With

        Controls.AddRange({_expandedCalendar, _btnPrevMonth, _btnNextMonth})
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs)
        _expandedCalendar.NavigateMonth(False)
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs)
        _expandedCalendar.NavigateMonth(True)
    End Sub
End Class
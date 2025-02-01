Public Class FrmCalendarView

    Private _currentViewDate As DateTime
    Private _expandedCalendar As CustomCalendar
    Private _btnPrevMonth As Button
    Private _btnCurrentMonth As Button
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
        _btnCurrentMonth = New Button()
        _btnNextMonth = New Button()

        ' Calculate button positions based on calendar bottom
        Dim buttonY As Integer = _expandedCalendar.Bottom + 10
        Dim buttonStartX As Integer = (_expandedCalendar.Width - (360 + 20)) \ 2 + _expandedCalendar.Left

        With _btnPrevMonth
            .Text = "Previous"
            .Location = New Point(20, buttonY)
            .Size = New Size(80, 30)
            AddHandler .Click, AddressOf btnPrevMonth_Click
        End With

        With _btnCurrentMonth
            .Text = "Current Month"
            .Location = New Point(110, buttonY)
            .Size = New Size(100, 30)
            AddHandler .Click, AddressOf btnCurrentMonth_Click
        End With

        With _btnNextMonth
            .Text = "Next"
            .Location = New Point(220, buttonY)
            .Size = New Size(80, 30)
            AddHandler .Click, AddressOf btnNextMonth_Click
        End With

        Controls.AddRange({_expandedCalendar, _btnPrevMonth, _btnCurrentMonth, _btnNextMonth})
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs)
        _expandedCalendar.NavigateToMonth(False)
    End Sub

    Private Sub btnCurrentMonth_Click(sender As Object, e As EventArgs)
        _expandedCalendar.NavigateToCurrentMonth()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs)
        _expandedCalendar.NavigateToMonth(True)
    End Sub
End Class
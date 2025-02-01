Imports System.Data.OleDb

Public Class FrmVolunteer

    Private WithEvents myCalendar As New CustomCalendar()

    Private ReadOnly _scheduleManager As New ScheduleManager(DatabaseConfig.ConnectionString)
    Private ReadOnly _volunteerManager As New VolunteerManager(DatabaseConfig.ConnectionString)
    Private ReadOnly _dayHelper As New DayOfWeekHelper()
    Private lvwScheduleSorter As New ListViewColumnSorter()
    Private lvwColumnSorter As ListViewColumnSorter
    Private btnPrev As New Button()
    Private btnNext As New Button()
    Private btnCurrent As New Button()

    Private Sub FrmVolunteer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeControls()
        LoadSchedules()
        SetupCalendarControls()
        '  LoadVolunteers()
    End Sub

    Private Sub InitializeControls()
        InitializeScheduleTab()
        InitializeVolunteerTab()
        InitializeSubstituteTab()
    End Sub

    Private Sub InitializeScheduleTab()
        With lvwSchedule
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Clear()
            .Columns.Add("Schedule Day", 100)
            .Columns.Add("Start Time", 100)
            .Columns.Add("End Time", 100)
            .Columns.Add("Status", 100)
        End With

        With cboSchedDay
            .Items.Clear()
            .Items.AddRange({"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        End With
    End Sub

    Private Sub InitializeVolunteerTab()
        With lvwVolunteer
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Clear()
            .Columns.Add("Day", 100)
            .Columns.Add("StartTime", 100)
            .Columns.Add("EndTime", 100)
            .Columns.Add("Status", 100)
            .Items.Clear()
        End With
        LoadVolunteerCombo()
        LoadScheduleCombo()
        cboVol.SelectedIndex = -1
        cboSched.SelectedIndex = -1
    End Sub

    Private Sub InitializeSubstituteTab()
        With lvwSubstitute
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Clear()
            .Columns.Add("Volunteer", 100)
            .Columns.Add("Substitute", 100)
            .Columns.Add("Day", 100)
            .Columns.Add("Start Time", 100)
            .Columns.Add("End Time", 100)
            .Columns.Add("Status", 100)
        End With
        LoadSubstituteCombo()
        LoadSubScheduleCombo()
    End Sub

    Private Sub SetupCalendarControls()
        ' Configure calendar position first
        myCalendar.Location = New Point(20, 10)

        ' Calculate button positions based on calendar bottom
        Dim buttonY As Integer = myCalendar.Location.Y + myCalendar.Height + 10

        ' Configure buttons below calendar
        btnPrev.Text = "Previous"
        btnPrev.Location = New Point(20, buttonY)
        btnPrev.Size = New Size(80, 30)

        btnCurrent.Text = "Current Month"
        btnCurrent.Location = New Point(110, buttonY)
        btnCurrent.Size = New Size(100, 30)

        btnNext.Text = "Next"
        btnNext.Location = New Point(220, buttonY)
        btnNext.Size = New Size(80, 30)

        ' Add controls individually
        tabCalendar.Controls.Add(myCalendar)
        tabCalendar.Controls.Add(btnPrev)
        tabCalendar.Controls.Add(btnCurrent)
        tabCalendar.Controls.Add(btnNext)

        ' Wire up events
        AddHandler btnPrev.Click, AddressOf btnPrev_Click
        AddHandler btnCurrent.Click, AddressOf btnCurrent_Click
        AddHandler btnNext.Click, AddressOf btnNext_Click
        AddHandler myCalendar.CalendarClicked, AddressOf myCalendar_CalendarClicked
    End Sub

    Private Sub myCalendar_CalendarClicked(sender As Object, e As EventArgs)
        Dim expandedView As New FrmCalendarView(myCalendar.CurrentDate)
        expandedView.Show()
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs)
        myCalendar.NavigateToMonth(False)
    End Sub

    Private Sub btnCurrent_Click(sender As Object, e As EventArgs)
        myCalendar.NavigateToCurrentMonth()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs)
        myCalendar.NavigateToMonth(True)
    End Sub

    'Private Sub myCalendar_CalendarClicked(sender As Object, e As EventArgs) Handles myCalendar.CalendarClicked
    '    Dim expandedView As New FrmCalendarView(myCalendar.CurrentDate)
    '    expandedView.Show()
    'End Sub

    Private Sub LoadSchedules()
        lvwSchedule.Items.Clear()
        lvwSchedule.ListViewItemSorter = lvwColumnSorter
        Dim schedules = _scheduleManager.GetActiveSchedules()

        For Each schedule In schedules
            Dim item As New ListViewItem(_dayHelper.GetDayName(schedule.DayOfWeek))
            item.SubItems.Add(schedule.StartTime)  ' No parsing needed - use the time string directly
            item.SubItems.Add(schedule.EndTime)    ' No parsing needed - use the time string directly
            item.SubItems.Add(If(schedule.IsActive, "Active", "Inactive"))
            item.Tag = schedule.ScheduleID
            lvwSchedule.Items.Add(item)
        Next

        lvwSchedule.Sort()
    End Sub

    Private Sub lvwSchedule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwSchedule.SelectedIndexChanged
        If lvwSchedule.SelectedItems.Count > 0 Then
            Dim selectedItem = lvwSchedule.SelectedItems(0)

            ' Set the day in combo box
            cboSchedDay.SelectedIndex = DayOfWeekHelper.GetDayValue(selectedItem.Text)

            ' Set the times in date time pickers
            dtpStartTime.Value = DateTime.Parse(selectedItem.SubItems(1).Text)
            dtpEndTime.Value = DateTime.Parse(selectedItem.SubItems(2).Text)
        End If
    End Sub


    Private Sub cboVol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVol.SelectedIndexChanged
        If cboVol.SelectedIndex >= 0 Then
            Debug.WriteLine("Volunteer selected")
            Dim contactId As Integer = DirectCast(DirectCast(cboVol.SelectedItem, DataRowView).Row("ContactID"), Integer)
            Debug.WriteLine($"ContactID: {contactId}")
            LoadVolunteerScheduleList(contactId)
            cboSched.SelectedIndex = -1
        End If
    End Sub

    Private Sub LoadVolunteerScheduleList(contactId As Integer)
        lvwVolunteer.Items.Clear()

        If contactId <= 0 Then
            Return
        End If

        Dim dt = _volunteerManager.GetVolunteerSchedules(contactId)
        Debug.WriteLine($"Rows returned from database: {dt.Rows.Count}")

        For Each row As DataRow In dt.Rows
            Dim item As New ListViewItem(_dayHelper.GetDayName(CInt(row("DayOfWeek"))))
            item.SubItems.Add(DateTime.Parse(row("StartTime").ToString).ToString("HH:mm"))
            item.SubItems.Add(DateTime.Parse(row("EndTime").ToString).ToString("HH:mm"))
            item.SubItems.Add(If(CBool(row("IsActive")), "Active", "Inactive"))
            item.Tag = row("ScheduleID")
            lvwVolunteer.Items.Add(item)
        Next
    End Sub

    Private Sub LoadVolunteerSubstitutionList(contactId As Integer)
        lvwSubstitute.Items.Clear()
        Dim dt = _volunteerManager.GetVolunteerSubstitutions(contactId)

        For Each row As DataRow In dt.Rows
            Dim item As New ListViewItem(row("Volunteer").ToString)
            item.SubItems.Add(row("Substitute").ToString)
            item.SubItems.Add(_dayHelper.GetDayName(CInt(row("DayOfWeek"))))
            item.SubItems.Add(DateTime.Parse(row("StartTime").ToString).ToString("HH:mm"))
            item.SubItems.Add(DateTime.Parse(row("EndTime").ToString).ToString("HH:mm"))
            item.SubItems.Add(If(CBool(row("IsActive")), "Active", "Inactive"))
            lvwSubstitute.Items.Add(item)
        Next
    End Sub


    Private Sub btnSchedAdd_Click(sender As Object, e As EventArgs) Handles btnSchedAdd.Click
        Dim dayValue As Integer = cboSchedDay.SelectedIndex
        Dim startTime As String = dtpStartTime.Value.ToString("HH:mm")
        Dim endTime As String = dtpEndTime.Value.ToString("HH:mm")

        If _scheduleManager.AddSchedule(dayValue, startTime, endTime) Then
            LoadSchedules()
            MessageBox.Show("Schedule added successfully")
        End If
    End Sub

    Private Sub btnSchedEdit_Click(sender As Object, e As EventArgs) Handles btnSchedEdit.Click
        If lvwSchedule.SelectedItems.Count > 0 Then
            Dim scheduleId As Integer = CInt(lvwSchedule.SelectedItems(0).Tag)
            Dim dayValue As Integer = cboSchedDay.SelectedIndex
            Dim startTime As String = dtpStartTime.Value.ToString("HH:mm")
            Dim endTime As String = dtpEndTime.Value.ToString("HH:mm")

            If _scheduleManager.UpdateSchedule(scheduleId, dayValue, startTime, endTime) Then
                LoadSchedules()
                MessageBox.Show("Schedule updated successfully")
            End If
        End If
    End Sub

    Private Sub btnSchedRemove_Click(sender As Object, e As EventArgs) Handles btnSchedRemove.Click
        If lvwSchedule.SelectedItems.Count > 0 Then
            Dim scheduleId As Integer = CInt(lvwSchedule.SelectedItems(0).Tag)
            If _scheduleManager.SetScheduleStatus(scheduleId, False) Then
                LoadSchedules()
                MessageBox.Show("Schedule removed successfully")
            End If
        End If
    End Sub

    Private Sub LoadVolunteerCombo()
        Dim dt = _volunteerManager.GetEligibleContacts()
        With cboVol
            .DataSource = dt
            .DisplayMember = "FullName"
            .ValueMember = "ContactID"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub LoadSubstituteCombo()
        Dim dt = _volunteerManager.GetEligibleContacts()
        With cboSub
            .DataSource = dt
            .DisplayMember = "FullName"
            .ValueMember = "ContactID"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub LoadScheduleCombo()
        Dim dt = _volunteerManager.GetSchedulesForCombo()
        With cboSched
            .DataSource = dt
            .DisplayMember = "DisplayText"
            .ValueMember = "ScheduleID"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub LoadSubScheduleCombo()
        Dim dt = _volunteerManager.GetSchedulesForCombo()
        With cboSubSched
            .DataSource = dt
            .DisplayMember = "DisplayText"
            .ValueMember = "ScheduleID"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub btnVolAdd_Click(sender As Object, e As EventArgs) Handles btnVolAdd.Click
        If cboVol.SelectedIndex >= 0 AndAlso cboSched.SelectedIndex >= 0 Then
            Dim contactId As Integer = DirectCast(DirectCast(cboVol.SelectedItem, DataRowView).Row("ContactID"), Integer)
            Dim scheduleId As Integer = DirectCast(DirectCast(cboSched.SelectedItem, DataRowView).Row("ScheduleID"), Integer)

            If _volunteerManager.AssignScheduleToVolunteer(contactId, scheduleId) Then
                LoadVolunteerScheduleList(contactId)
                cboSched.SelectedIndex = -1
                MessageBox.Show("Schedule assigned successfully")
            End If
        End If
    End Sub

    Private Sub btnVolRemove_Click(sender As Object, e As EventArgs) Handles btnVolRemove.Click
        If cboVol.SelectedIndex >= 0 AndAlso lvwVolunteer.SelectedItems.Count > 0 Then
            Dim contactId As Integer = DirectCast(DirectCast(cboVol.SelectedItem, DataRowView).Row("ContactID"), Integer)
            Dim scheduleId As Integer = CInt(lvwVolunteer.SelectedItems(0).Tag)

            If _volunteerManager.DeactivateVolunteerSchedule(contactId, scheduleId) Then
                LoadVolunteerScheduleList(contactId)
                MessageBox.Show("Schedule removed successfully")
            End If
        End If
    End Sub





End Class
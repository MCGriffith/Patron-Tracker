Imports System.Data.OleDb

Public Class FrmVolunteer
    Private ReadOnly _scheduleManager As New ScheduleManager(DatabaseConfig.ConnectionString)
    Private ReadOnly _volunteerManager As New VolunteerManager(DatabaseConfig.ConnectionString)
    Private ReadOnly _dayHelper As New DayOfWeekHelper()
    Private lvwScheduleSorter As New ListViewColumnSorter()

    Private Sub FrmVolunteer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeControls()
        LoadSchedules()
        LoadVolunteers()
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
            .Columns.Add("Day of Week", 100)
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
            .Columns.Add("VolDay", 100)
            .Columns.Add("VolStartTime", 100)
            .Columns.Add("VolEndTime", 100)
            .Columns.Add("VolStatus", 100)
        End With
        LoadVolunteerCombo()
    End Sub

    Private Sub InitializeSubstituteTab()
        With lvwSubstitute
            .View = View.Details
            .FullRowSelect = True
            .GridLines = True
            .Columns.Clear()
            .Columns.Add("SubVol", 100)
            .Columns.Add("SubSub", 100)
            .Columns.Add("SubDay", 100)
            .Columns.Add("SubStart", 100)
            .Columns.Add("SubEnd", 100)
            .Columns.Add("SubStatus", 100)
        End With
        LoadSubstituteCombo()
    End Sub

    Private Sub LoadSchedules()
        lvwSchedule.Items.Clear()
        Dim schedules = _scheduleManager.GetActiveSchedules()

        ' Convert to list for sorting
        Dim sortedSchedules = schedules.OrderBy(Function(s) s.DayOfWeek) _
                                 .ThenBy(Function(s) s.StartTime) _
                                 .ThenBy(Function(s) s.EndTime) _
                                 .ToList()

        For Each schedule In sortedSchedules
            Dim item As New ListViewItem(_dayHelper.GetDayName(schedule.DayOfWeek))
            item.SubItems.Add(DateTime.Parse(schedule.StartTime).ToString("HH:mm"))
            item.SubItems.Add(DateTime.Parse(schedule.EndTime).ToString("HH:mm"))
            item.SubItems.Add(If(schedule.IsActive, "Active", "Inactive"))
            item.Tag = schedule.ScheduleID
            lvwSchedule.Items.Add(item)
        Next
    End Sub

    Private Sub LoadVolunteers()
        lvwVolunteer.Items.Clear()
        Dim volunteers = _volunteerManager.GetActiveVolunteers()
        For Each vol In volunteers
            Dim item As New ListViewItem(vol.ContactID.ToString())
            item.SubItems.Add(vol.ScheduleID.ToString())
            item.SubItems.Add(vol.StartDate.ToShortDateString())
            item.SubItems.Add(vol.EndDate.ToShortDateString())
            item.SubItems.Add(If(vol.IsActive, "Active", "Inactive"))
            item.Tag = vol.VolunteerID
            lvwVolunteer.Items.Add(item)
        Next
    End Sub

    Private Sub btnSchedAdd_Click(sender As Object, e As EventArgs) Handles btnSchedAdd.Click
        Dim dayValue As Integer = cboSchedDay.SelectedIndex + 1
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
            Dim dayValue As Integer = cboSchedDay.SelectedIndex + 1
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

    Private Sub btnVolAdd_Click(sender As Object, e As EventArgs) Handles btnVolAdd.Click
        If cboVol.SelectedIndex >= 0 AndAlso cboSched.SelectedIndex >= 0 Then
            Dim contactId As Integer = CInt(cboVol.SelectedValue)
            Dim scheduleId As Integer = CInt(cboSched.SelectedValue)
            If _volunteerManager.AddVolunteer(scheduleId, contactId, Date.Today, Date.MaxValue) Then
                LoadVolunteers()
                MessageBox.Show("Volunteer assigned successfully")
            End If
        End If
    End Sub

    Private Sub btnVolRemove_Click(sender As Object, e As EventArgs) Handles btnVolRemove.Click
        If lvwVolunteer.SelectedItems.Count > 0 Then
            Dim volunteerId As Integer = CInt(lvwVolunteer.SelectedItems(0).Tag)
            If _volunteerManager.SetVolunteerStatus(volunteerId, False) Then
                LoadVolunteers()
                MessageBox.Show("Volunteer removed successfully")
            End If
        End If
    End Sub

    Private Sub LoadVolunteerCombo()
        ' Add code to load volunteer ComboBox from Contacts table
    End Sub

    Private Sub LoadSubstituteCombo()
        ' Add code to load substitute ComboBox from Contacts table
    End Sub
End Class
Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Access
Imports PTracker.ClosingManagement

Public Class FrmVolunteers


    Private selectedScheduleId As Integer = -1
    Private volunteerManager As New VolunteerAssignments
    Private selectedLoginId As Integer = -1
    Private substituteManager As New SubstituteManagement
    Private selectedOriginalId As Integer = -1
    Private _isEditMode As Boolean = False
    Private _currentEditId As Integer = -1
    Private _calendar As CustomCalendar
    Private currentScheduleId As Integer = -1
    Private _volunteerRelationships As New VolunteerRelationships()
    Private scheduleManager As New ScheduleQueries()


    Private Sub FrmVolunteers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("=== Starting FrmVolunteers_Load ===")
        Try
            Debug.WriteLine("Initializing Controls...")
            InitializeControls()

            Debug.WriteLine("Initializing Calendar...")
            InitializeCalendar()

            Debug.WriteLine("Setting Substitute Controls...")
            EnableSubstituteControls(False)

            Debug.WriteLine("Loading Day of Week Combo...")
            LoadDayOfWeekCombo()

            Debug.WriteLine("Loading Volunteer ComboBox...")
            LoadVolunteerComboBox()

            Debug.WriteLine("Loading Available Schedules...")
            LoadAvailableSchedules()

            Debug.WriteLine("Refreshing Schedule List...")
            RefreshScheduleList()

            Debug.WriteLine("Loading FSC Closings List...")
            LoadFSCClosingsList()

            Debug.WriteLine("Refreshing Original Schedule View...")
            RefreshOriginalScheduleView()

            Debug.WriteLine("Inactivating Past Substitutions...")
            substituteManager.InactivatePastSubstitutions()

            Debug.WriteLine("=== FrmVolunteers_Load Completed ===")
        Catch ex As Exception
            Debug.WriteLine($"Error in FrmVolunteers_Load: {ex.Message}")
            Debug.WriteLine($"Stack Trace: {ex.StackTrace}")
            MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    'Private Sub FrmVolunteers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'Basic initialization
    '    InitializeControls()
    '    InitializeCalendar()
    '    EnableSubstituteControls(False)

    '    'Load reference data
    '    LoadDayOfWeekCombo()
    '    LoadVolunteerComboBox()
    '    LoadAvailableSchedules()

    '    'Load display data
    '    RefreshScheduleList()
    '    LoadFSCClosingsList()
    '    RefreshOriginalScheduleView()
    '    substituteManager.InactivatePastSubstitutions()
    'End Sub

    Private Sub InitializeControls()
        LoadVolunteerComboBoxes()
    End Sub


    Private Sub LoadVolunteerComboBoxes()
        Try
            Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
                Dim sql As String = "SELECT LoginID, FullName FROM tblContacts ORDER BY FullName"
                Using da As New OleDbDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    Dim newRow As DataRow = dt.NewRow()
                    newRow("LoginID") = -1
                    newRow("FullName") = "-- Select Volunteer --"
                    dt.Rows.InsertAt(newRow, 0)

                    cboOriginalVolunteer.DataSource = dt.Copy()
                    cboOriginalVolunteer.DisplayMember = "FullName"
                    cboOriginalVolunteer.ValueMember = "LoginID"

                    cboSubstituteVolunteer.DataSource = dt.Copy()
                    cboSubstituteVolunteer.DisplayMember = "FullName"
                    cboSubstituteVolunteer.ValueMember = "LoginID"
                End Using
            End Using
        Catch ex As OleDbException
            ErrorHandler.HandleDatabaseError(ex, "loading volunteer list")
        Catch ex As Exception
            ErrorHandler.HandleSystemError(ex)
        End Try
    End Sub

    Private Sub LoadDayOfWeekCombo()
        cboDayOfWeek.Items.Clear()
        For i As Integer = 1 To 7
            cboDayOfWeek.Items.Add(scheduleManager.GetDayName(i))
        Next
        cboDayOfWeek.SelectedIndex = 0
    End Sub

    Private Sub RefreshScheduleList()
        lvwSchedule.Items.Clear()
        Dim dt As DataTable = scheduleManager.GetAllSchedules()
        For Each row As DataRow In dt.Rows
            Dim item As New ListViewItem(DayOfWeekHelper.GetDayName(CInt(row("DayOfWeek"))))
            item.SubItems.Add(CDate(row("StartTime")).ToString("HH:mm"))
            item.SubItems.Add(CDate(row("EndTime")).ToString("HH:mm"))
            item.SubItems.Add(If(CBool(row("IsActive")), "Active", "Inactive"))
            item.Tag = row("ScheduleID")
            lvwSchedule.Items.Add(item)
        Next
    End Sub

    Private Sub btnAddSchedule_Click(sender As Object, e As EventArgs) Handles btnAddSchedule.Click
        Try
            Dim dayValue As Integer = DayOfWeekHelper.GetDayValue(cboDayOfWeek.Text)
            Dim scheduleQueries As New ScheduleQueries()

            If btnAddSchedule.Text = "Update Schedule" Then
                ' Handle Update
                If scheduleQueries.UpdateSchedule(selectedScheduleId, dayValue, dtpStartTime.Value, dtpEndTime.Value) Then
                    RefreshScheduleList()
                    btnAddSchedule.Text = "Add Schedule"
                    selectedScheduleId = -1
                End If
            Else
                ' Handle Add
                Dim newScheduleId = scheduleQueries.AddSchedule(dayValue, dtpStartTime.Value, dtpEndTime.Value, True)
                If newScheduleId > 0 Then
                    RefreshScheduleList()
                End If
            End If

        Catch ex As OleDbException
            ErrorHandler.HandleDatabaseError(ex, "managing schedule")
        Catch ex As Exception
            ErrorHandler.HandleSystemError(ex)
        End Try
    End Sub

    Private Sub btnEditSchedule1_Click(sender As Object, e As EventArgs) Handles btnEditSchedule1.Click
        If lvwSchedule.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a schedule to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        selectedScheduleId = CInt(lvwSchedule.SelectedItems(0).Tag)
        Dim dayName As String = lvwSchedule.SelectedItems(0).SubItems(0).Text
        cboDayOfWeek.SelectedItem = dayName
        dtpStartTime.Value = DateTime.ParseExact(lvwSchedule.SelectedItems(0).SubItems(1).Text, "HH:mm", Nothing)
        dtpEndTime.Value = DateTime.ParseExact(lvwSchedule.SelectedItems(0).SubItems(2).Text, "HH:mm", Nothing)
        btnAddSchedule.Text = "Update Schedule"

        ' Add immediate refresh after update
        RefreshScheduleList()
    End Sub

    Private Sub btnDeactivate_Click(sender As Object, e As EventArgs) Handles btnDeactivate.Click
        If lvwSchedule.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a schedule to deactivate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim scheduleId As Integer = CInt(lvwSchedule.SelectedItems(0).Tag)
        If scheduleManager.UpdateScheduleStatus(scheduleId, False) Then
            RefreshScheduleList()
        End If
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        If lvwSchedule.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a schedule to activate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim scheduleId As Integer = CInt(lvwSchedule.SelectedItems(0).Tag)
        If scheduleManager.UpdateScheduleStatus(scheduleId, True) Then
            RefreshScheduleList()
        End If
    End Sub

    Private Sub LoadVolunteerComboBox()
        Using connection As New OleDbConnection(DatabaseConfig.ConnectionString)
            Dim sql As String = "SELECT c.FullName, l.LoginID " &
                           "FROM tblContacts c " &
                           "INNER JOIN tblLogin l ON c.LoginID = l.LoginID " &
                           "WHERE l.Role IN ('Staff', 'Director', 'Admin') " &
                           "ORDER BY c.FullName"

            Using cmd As New OleDbCommand(sql, connection)
                connection.Open()
                Dim dt As New DataTable()
                dt.Columns.Add("FullName", GetType(String))
                dt.Columns.Add("LoginID", GetType(Integer))

                ' Add blank row first
                dt.Rows.Add("", -1)

                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dt.Rows.Add(reader("FullName"), reader("LoginID"))
                    End While
                End Using

                cboVolunteer.DisplayMember = "FullName"
                cboVolunteer.ValueMember = "LoginID"
                cboVolunteer.DataSource = dt
            End Using
        End Using
    End Sub

    Private Sub cboVolunteer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVolunteer.SelectedIndexChanged
        If cboVolunteer.SelectedItem IsNot Nothing Then
            Dim selected = DirectCast(cboVolunteer.SelectedItem, DataRowView)
            selectedLoginId = CInt(selected("LoginID"))
        End If
    End Sub

    Private Sub LoadAvailableSchedules()
        Using connection As New OleDbConnection(DatabaseConfig.ConnectionString)
            Dim sql As String = "SELECT ScheduleID, DayOfWeek, StartTime, EndTime " &
                           "FROM tblSchedule " &
                           "WHERE IsActive = True " &
                           "ORDER BY DayOfWeek, StartTime"

            Using cmd As New OleDbCommand(sql, connection)
                connection.Open()
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    cboAvailableSchedule.Items.Clear()

                    ' Add blank item first
                    cboAvailableSchedule.Items.Add(New With {
                    .Display = "",
                    .Value = -1
                })

                    While reader.Read()
                        Dim dayName = scheduleManager.GetDayName(CInt(reader("DayOfWeek")))
                        Dim displayText = $"{dayName} {CDate(reader("StartTime")).ToString("HH:mm")} - {CDate(reader("EndTime")).ToString("HH:mm")}"
                        cboAvailableSchedule.Items.Add(New With {
                        .Display = displayText,
                        .Value = reader("ScheduleID")
                    })
                    End While
                End Using
            End Using
        End Using

        cboAvailableSchedule.DisplayMember = "Display"
        cboAvailableSchedule.SelectedIndex = 0
    End Sub

    Private Sub btnAssignSchedule_Click(sender As Object, e As EventArgs) Handles btnAssignSchedule.Click
        If selectedLoginId <= 0 Then
            MessageBox.Show("Please select a volunteer first.", "Selection Required")
            Return
        End If

        If cboAvailableSchedule.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a schedule to assign.", "Selection Required")
            Return
        End If

        Dim selected = DirectCast(cboAvailableSchedule.SelectedItem, Object)
        Dim scheduleId As Integer = selected.Value
        Dim startDate As Date = DateTime.Today
        Dim endDate As Date = startDate.AddYears(1)

        If volunteerManager.AssignVolunteerSchedule(selectedLoginId, scheduleId, startDate, endDate) Then
        End If
    End Sub

    Private Sub btnRemoveAssignment_Click(sender As Object, e As EventArgs) Handles btnRemoveAssignment.Click
        If lvwVolunteerSchedule.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a schedule assignment to remove.", "Selection Required")
            Return
        End If

        Dim scheduleId As Integer = CInt(lvwVolunteerSchedule.SelectedItems(0).Tag)
        If volunteerManager.RemoveVolunteerAssignment(scheduleId) Then
        End If
    End Sub

    Private Function ValidateSubstitution(originalId As Integer, substituteId As Integer) As Boolean
        If originalId = substituteId Then
            MessageBox.Show("A volunteer cannot substitute for themselves.", "Invalid Selection")
            Return False
        End If

        If substituteId = -1 Then
            MessageBox.Show("Please select a substitute volunteer.", "Invalid Selection")
            Return False
        End If

        Return True
    End Function

    Private Sub btnAssignSubstitute_Click(sender As Object, e As EventArgs) Handles btnAssignSubstitute.Click
        Try
            If Not ValidateSelections() Then Return

            Dim scheduleId As Integer = GetSelectedScheduleId()
            Dim substituteDate As Date = dtpSubDate.Value.Date
            Dim originalId As Integer = CInt(cboOriginalVolunteer.SelectedValue)
            Dim substituteId As Integer = CInt(cboSubstituteVolunteer.SelectedValue)

            If Not ValidateSubstituteAssignment(scheduleId, substituteDate) Then Return

            Dim scheduleQueries As New ScheduleQueries()
            If scheduleQueries.CreateSubstituteAssignment(scheduleId, originalId, substituteId, substituteDate) Then
                RefreshAfterSubstituteAssignment()
            End If
        Catch ex As OleDbException
            ErrorHandler.HandleDatabaseError(ex, "assigning substitute")
        Catch ex As Exception
            ErrorHandler.HandleSystemError(ex)
        End Try
    End Sub

    Private Sub btnRemoveSubstitute_Click(sender As Object, e As EventArgs) Handles btnRemoveSubstitute.Click
        Try
            Dim scheduleId As Integer = GetSelectedScheduleId()
            If scheduleId = -1 Then
                ErrorHandler.HandleValidationError("Please select a schedule first.")
                Return
            End If

            Dim substituteDate As Date = dtpSubDate.Value.Date
            Dim scheduleQueries As New ScheduleQueries()

            If MessageBox.Show("Are you sure you want to remove this substitute?",
                          "Confirm Removal",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question) = DialogResult.Yes Then

                If scheduleQueries.RemoveSubstituteAssignment(scheduleId, substituteDate) Then
                    RefreshAfterSubstituteAssignment()
                End If
            End If
        Catch ex As OleDbException
            ErrorHandler.HandleDatabaseError(ex, "removing substitute")
        Catch ex As Exception
            ErrorHandler.HandleSystemError(ex)
        End Try
    End Sub

    Private Sub cboOriginalVolunteer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOriginalVolunteer.SelectedIndexChanged
        If cboOriginalVolunteer.SelectedValue IsNot Nothing Then
            RefreshOriginalScheduleView()

            If lvwOrgs.Items.Count = 0 Then
                EnableSubstituteControls(False)
            End If
        End If
    End Sub

    Private Sub btnAddClosing1_Click(sender As Object, e As EventArgs) Handles btnAddClosing1.Click
        Dim closingMgr As New ClosingManagement(DatabaseConfig.ConnectionString)

        ' Get values from controls
        Dim startDate As Date = dtpStartDate.Value
        Dim endDate As Date = dtpEndDate.Value
        Dim closingType As String = cboClosingType.Text
        Dim isEmergency As Boolean = chkEmergency.Checked
        Dim description As String = txtDescription.Text

        ' Add the closing to database
        If closingMgr.AddClosing(startDate, endDate, closingType, description, isEmergency) Then
            ' Clear the form controls
            ClearClosingControls()

            ' Immediately refresh the ListView with all active closings
            LoadFSCClosingsList()

            MessageBox.Show("Closing added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to add closing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ClearClosingControls()
        dtpStartDate.Value = Date.Today
        dtpEndDate.Value = Date.Today
        cboClosingType.SelectedIndex = -1
        chkEmergency.Checked = False
        txtDescription.Clear()
    End Sub

    Private Sub LoadFSCClosingsList()
        Try
            Debug.WriteLine(vbNewLine & "=== Starting LoadFSCClosingsList ===")
            lvwClosings.Items.Clear()
            Debug.WriteLine("ListView cleared")

            Dim closingMgr As New ClosingManagement(DatabaseConfig.ConnectionString)
            Debug.WriteLine("Getting closings from database...")
            Dim fscClosings = closingMgr.GetFSCClosings()
            Debug.WriteLine($"Retrieved {fscClosings.Count} closings")

            For Each fscClosing In fscClosings
                Debug.WriteLine($"Processing closing ID: {fscClosing.ClosingID}")
                Dim item As New ListViewItem()
                With item
                    .Text = fscClosing.StartDate.ToShortDateString()        ' CloseStartDate
                    .SubItems.Add(fscClosing.EndDate.ToShortDateString())   ' CloseEndDate
                    .SubItems.Add(fscClosing.ClosingType)                   ' CloseType
                    .SubItems.Add(If(fscClosing.IsEmergency, "Yes", "No"))  ' CloseEmergency
                    .SubItems.Add(fscClosing.Description)                   ' CloseDescription
                    .Tag = fscClosing.ClosingID                             ' Maps to ClosingsID in database
                End With

                lvwClosings.Items.Add(item)
                Debug.WriteLine($"Added item to ListView: {item.Text}")
            Next

            Debug.WriteLine($"Final ListView count: {lvwClosings.Items.Count}")
            lvwClosings.Refresh()
        Catch ex As Exception
            Debug.WriteLine($"Error in LoadFSCClosingsList: {ex.Message}")
            Debug.WriteLine($"Stack Trace: {ex.StackTrace}")
            MessageBox.Show($"Error loading closings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRemoveClosing_Click(sender As Object, e As EventArgs) Handles btnRemoveClosing.Click
        If lvwClosings.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a closing to remove.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Add confirmation dialog
        If MessageBox.Show("Are you sure you want to remove the selected closing(s)?",
                      "Confirm Removal",
                      MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Dim closingMgr As New ClosingManagement(DatabaseConfig.ConnectionString)
        Dim successCount As Integer = 0

        For Each item As ListViewItem In lvwClosings.SelectedItems
            Dim closingId As Integer = CInt(item.Tag)
            If closingMgr.SetClosingInactive(closingId) Then
                successCount += 1
                lvwClosings.Items.Remove(item)
            End If
        Next

        If successCount > 0 Then
            MessageBox.Show($"{successCount} closing(s) removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tabClosing_Enter(sender As Object, e As EventArgs) Handles tabClosing.Enter
        LoadFSCClosingsList()
        SetEditMode(False)  ' This will hide Save/Cancel and enable regular buttons
    End Sub

    Private Sub SetEditMode(enabled As Boolean)
        ' Basic button states
        btnAddClosing.Enabled = Not enabled
        btnUpdateClosing.Enabled = Not enabled
        btnRemoveClosing.Enabled = Not enabled

        ' Save/Cancel buttons
        btnSaveChanges.Visible = enabled
        btnCancelEdit.Visible = enabled
    End Sub

    Private Sub lvwClosings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwClosings.SelectedIndexChanged
        Dim hasSelection = (lvwClosings.SelectedItems.Count > 0)
        btnAddClosing.Enabled = Not hasSelection
        btnUpdateClosing.Enabled = hasSelection
        btnRemoveClosing.Enabled = hasSelection
    End Sub

    Private Sub btnUpdateClosing_Click(sender As Object, e As EventArgs) Handles btnUpdateClosing.Click
        If lvwClosings.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a closing to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        btnAddClosing.Enabled = False  ' Disable Add immediately

        Dim selectedItem As ListViewItem = lvwClosings.SelectedItems(0)
        _currentEditId = CInt(selectedItem.Tag)  ' Store the ID for update

        ' Load data into fields
        dtpStartDate.Value = CDate(selectedItem.Text)
        dtpEndDate.Value = CDate(selectedItem.SubItems(1).Text)
        cboClosingType.Text = selectedItem.SubItems(2).Text
        chkEmergency.Checked = (selectedItem.SubItems(3).Text = "Yes")
        txtDescription.Text = selectedItem.SubItems(4).Text

        SetEditMode(True)
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        ' Create closing object with updated data
        Dim updatedClosing As New FSCClosingData With {
        .ClosingID = _currentEditId,
        .StartDate = dtpStartDate.Value,
        .EndDate = dtpEndDate.Value,
        .ClosingType = cboClosingType.Text,
        .IsEmergency = chkEmergency.Checked,
        .Description = txtDescription.Text
    }

        ' Save to database using DatabaseConfig
        If DatabaseConfig.UpdateClosing(updatedClosing) Then
            ' Refresh ListView
            LoadFSCClosingsList()
            SetEditMode(False)
            MessageBox.Show("Closing updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnCancelEdit_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
        SetEditMode(False)
        ClearClosingControls()
    End Sub


    Private Sub InitializeCalendar()
        _calendar = New CustomCalendar()
        tabCalendar.Controls.Add(_calendar)
        _calendar.Location = New Point(20, 20)

        ' Add navigation buttons
        Dim btnPrevMonth As New Button()
        Dim btnNextMonth As New Button()

        With btnPrevMonth
            .Text = "Previous Month"
            .Location = New Point(10, _calendar.Bottom + 10)
            .Size = New Size(100, 30)
            AddHandler .Click, AddressOf btnPrevMonth_Click
        End With

        With btnNextMonth
            .Text = "Next Month"
            .Location = New Point(btnPrevMonth.Right + 10, btnPrevMonth.Top)
            .Size = New Size(100, 30)
            AddHandler .Click, AddressOf btnNextMonth_Click
        End With

        tabCalendar.Controls.AddRange({btnPrevMonth, btnNextMonth})
        AddHandler _calendar.CalendarClicked, AddressOf ShowExpandedCalendar
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs)
        _calendar.NavigateMonth(False)
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs)
        _calendar.NavigateMonth(True)
    End Sub

    Private Sub ShowExpandedCalendar(sender As Object, e As EventArgs)
        Dim expandedView As New FrmCalendarView(_calendar.CurrentDate)
        expandedView.Show()
    End Sub

    Private Sub PopulateOriginalScheduleListView()
        Dim scheduleQueries As New ScheduleQueries()
        Dim scheduleData As DataTable = scheduleQueries.GetFormattedScheduleData()
        lvwOrgs.Items.Clear()
        For Each row As DataRow In scheduleData.Rows
            Dim item As New ListViewItem()
            item.Text = DayOfWeekHelper.GetDayName(CInt(row("DayOfWeek")))
            item.SubItems.Add(CDate(row("StartTime")).ToString("HH:mm"))
            item.SubItems.Add(CDate(row("EndTime")).ToString("HH:mm"))
            item.SubItems.Add("Active")
            item.SubItems.Add(CDate(row("StartDate")).ToString("MM/dd/yyyy"))
            If row("SubstituteLoginID") IsNot DBNull.Value Then
                item.SubItems.Add(scheduleQueries.GetVolunteerName(CInt(row("SubstituteLoginID"))))
            Else
                item.SubItems.Add(String.Empty)
            End If
            item.Tag = row("VolunteerScheduleID")
            lvwOrgs.Items.Add(item)
        Next
    End Sub

    Private Sub RefreshOriginalScheduleView()
        Try
            PopulateOriginalScheduleListView()

            If cboOriginalVolunteer.SelectedValue IsNot Nothing AndAlso
           TypeOf cboOriginalVolunteer.SelectedValue Is DataRowView Then

                Dim selectedRow As DataRowView = DirectCast(cboOriginalVolunteer.SelectedValue, DataRowView)
                Dim selectedId As Integer = Convert.ToInt32(selectedRow("LoginID"))

                If selectedId > -1 Then
                    Dim scheduleQueries As New ScheduleQueries()
                    Dim volunteerSchedule = scheduleQueries.GetActiveVolunteerSchedules(selectedId)

                    If volunteerSchedule IsNot Nothing AndAlso volunteerSchedule.Rows.Count > 0 Then
                        UpdateRelatedDisplays(volunteerSchedule)
                    End If
                End If
            End If
        Catch ex As OleDbException
            ErrorHandler.HandleDatabaseError(ex, "refreshing schedule view")
        Catch ex As Exception
            ErrorHandler.HandleSystemError(ex)
        End Try
    End Sub

    Private Sub UpdateSubstituteDisplay()
        If lvwOrgs.SelectedItems.Count > 0 Then
            LoadSubstituteDetails(CInt(lvwOrgs.SelectedItems(0).Tag))
        End If
    End Sub

    Private Sub UpdateAvailabilityIndicators()
        EnableSubstituteControls(lvwOrgs.SelectedItems.Count > 0)
    End Sub

    Private Sub UpdateRelatedDisplays(scheduleData As DataTable)
        If scheduleData IsNot Nothing AndAlso scheduleData.Rows.Count > 0 Then
            UpdateSubstituteDisplay()
            UpdateAvailabilityIndicators()
        End If
    End Sub


    Private Sub tabSchedule_Enter(sender As Object, e As EventArgs) Handles tabSchedule.Enter
        RefreshOriginalScheduleView()
        If lvwOrgs.Items.Count = 0 Then
            EnableSubstituteControls(False)
        End If
    End Sub

    Private Sub lvwOrgs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwOrgs.SelectedIndexChanged
        If lvwOrgs.SelectedItems.Count > 0 Then
            Dim scheduleId As Integer = GetSelectedScheduleId()
            EnableSubstituteControls(True)
            LoadSubstituteDetails(scheduleId)
            UpdateScheduleDisplay()
        Else
            EnableSubstituteControls(False)
            ClearSubstituteControls()
        End If
    End Sub

    Private Sub EnableSubstituteControls(enabled As Boolean)
        btnAssignSubstitute.Enabled = enabled AndAlso cboSubstituteVolunteer.SelectedIndex > 0
        btnRemoveSubstitute.Enabled = enabled AndAlso lvwOrgs.SelectedItems.Count > 0 AndAlso
                                 Not String.IsNullOrEmpty(lvwOrgs.SelectedItems(0).SubItems(5).Text)
        cboSubstituteVolunteer.Enabled = enabled
        dtpSubDate.Enabled = enabled
    End Sub

    Private Sub lvwOrgs_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvwOrgs.ColumnClick
        ' Sort the items based on column clicked
        Dim sorter As New ListViewColumnSorter()
        lvwOrgs.ListViewItemSorter = sorter
        sorter.SortColumn = e.Column
        lvwOrgs.Sort()
    End Sub

    Private Sub LoadSubstituteDetails(scheduleId As Integer)
        Try
            Dim scheduleQueries As New ScheduleQueries()
            Dim substituteData = scheduleQueries.GetSubstituteDetailsForSchedule(scheduleId)

            If substituteData IsNot Nothing AndAlso substituteData.Rows.Count > 0 Then
                Dim row As DataRow = substituteData.Rows(0)

                If row("SubstituteLoginID") IsNot DBNull.Value Then
                    cboSubstituteVolunteer.SelectedValue = row("SubstituteLoginID")
                    dtpSubDate.Value = CDate(row("SubstituteDate"))
                    btnRemoveSubstitute.Enabled = True
                    btnAssignSubstitute.Enabled = False
                End If
            Else
                ResetSubstituteInputs()
            End If
        Catch ex As OleDbException
            ErrorHandler.HandleDatabaseError(ex, "loading substitute details")
        Catch ex As Exception
            ErrorHandler.HandleSystemError(ex)
        End Try
    End Sub

    Private Sub DisplaySubstituteDetails(substituteData As DataTable)
        If substituteData.Rows.Count > 0 Then
            Dim row As DataRow = substituteData.Rows(0)

            ' Set the substitute volunteer in combo box
            cboSubstituteVolunteer.SelectedValue = row("SubstituteLoginID")

            ' Set the substitute date
            dtpSubDate.Value = CDate(row("SubstituteDate"))

            ' Enable remove button since there is a substitute
            btnRemoveSubstitute.Enabled = True
            btnAssignSubstitute.Enabled = False
        Else
            ' No substitute assigned
            cboSubstituteVolunteer.SelectedIndex = 0
            dtpSubDate.Value = DateTime.Today

            ' Enable assign button since there is no substitute
            btnRemoveSubstitute.Enabled = False
            btnAssignSubstitute.Enabled = True
        End If
    End Sub

    Private Function ValidateSubstituteAssignment(scheduleId As Integer, substituteDate As Date) As Boolean
        Try
            Dim scheduleQueries As New ScheduleQueries()

            If Not scheduleQueries.ValidateSubstituteDate(scheduleId, substituteDate) Then
                ErrorHandler.HandleValidationError("The substitute date must be within the schedule's date range.")
                Return False
            End If

            If Not ValidateSubstitution(CInt(cboOriginalVolunteer.SelectedValue),
                                  CInt(cboSubstituteVolunteer.SelectedValue)) Then
                Return False
            End If

            If scheduleQueries.CheckExistingSubstitute(scheduleId, substituteDate) Then
                ErrorHandler.HandleValidationError("A substitute is already assigned for this date.")
                Return False
            End If

            Return True
        Catch ex As OleDbException
            ErrorHandler.HandleDatabaseError(ex, "validating substitute assignment")
            Return False
        Catch ex As Exception
            ErrorHandler.HandleSystemError(ex)
            Return False
        End Try
    End Function

    Private Function ValidateNoExistingSubstitute(scheduleId As Integer, substituteDate As Date) As Boolean
        Dim scheduleQueries As New ScheduleQueries()
        If scheduleQueries.CheckExistingSubstitute(scheduleId, substituteDate) Then
            MessageBox.Show("A substitute is already assigned for this date.", "Duplicate Assignment")
            Return False
        End If
        Return True
    End Function

    Private Sub lvwOrgs_MouseClick(sender As Object, e As MouseEventArgs) Handles lvwOrgs.MouseClick
        If e.Button = MouseButtons.Right Then
            If lvwOrgs.SelectedItems.Count > 0 Then
                Dim scheduleId As Integer = CInt(lvwOrgs.SelectedItems(0).Tag)
                LoadSubstituteDetails(scheduleId)
            End If
        End If
    End Sub



    Private Sub RefreshAfterSubstituteAssignment()
        RefreshOriginalScheduleView()

        If lvwOrgs.SelectedItems.Count > 0 Then
            Dim scheduleId As Integer = GetSelectedScheduleId()
            LoadSubstituteDetails(scheduleId)
            UpdateScheduleDisplay()
        End If

        ResetSubstituteInputs()
    End Sub

    Private Sub ResetSubstituteInputs()
        If cboSubstituteVolunteer.Items.Count > 0 Then
            cboSubstituteVolunteer.SelectedIndex = 0
        End If
        dtpSubDate.Value = DateTime.Today
        EnableSubstituteControls(lvwOrgs.SelectedItems.Count > 0)
    End Sub

    Private Sub cboSubstituteVolunteer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSubstituteVolunteer.SelectedIndexChanged
        If lvwOrgs.SelectedItems.Count > 0 Then
            btnAssignSubstitute.Enabled = (cboSubstituteVolunteer.SelectedIndex > 0)
        End If
    End Sub

    Private Function GetSelectedScheduleId() As Integer
        If lvwOrgs.SelectedItems.Count > 0 Then
            Return CInt(lvwOrgs.SelectedItems(0).Tag)
        End If
        Return -1
    End Function

    Private Function ValidateSelections() As Boolean
        If GetSelectedScheduleId() = -1 Then
            MessageBox.Show("Please select a schedule first.", "Selection Required")
            Return False
        End If

        If cboSubstituteVolunteer.SelectedIndex <= 0 Then
            MessageBox.Show("Please select a substitute volunteer.", "Selection Required")
            Return False
        End If

        Return True
    End Function

    Private Sub UpdateScheduleDisplay()
        If lvwOrgs.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = lvwOrgs.SelectedItems(0)
            selectedItem.EnsureVisible()

            ' Update the substitute information display
            Dim hasSubstitute As Boolean = Not String.IsNullOrEmpty(selectedItem.SubItems(5).Text)
            btnRemoveSubstitute.Enabled = hasSubstitute
            btnAssignSubstitute.Enabled = Not hasSubstitute AndAlso cboSubstituteVolunteer.SelectedIndex > 0
        End If
    End Sub

    Private Sub HandleError(errorMessage As String)
        MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        RefreshAllDisplays()
    End Sub


    Private Sub RefreshAllDisplays()
        RefreshOriginalScheduleView()
        HandleScheduleSelection()
        UpdateScheduleDisplay()
    End Sub

    Private Sub ClearSubstituteControls()
        If cboSubstituteVolunteer.Items.Count > 0 Then
            cboSubstituteVolunteer.SelectedIndex = 0
        End If
        dtpSubDate.Value = DateTime.Today
        btnAssignSubstitute.Enabled = False
        btnRemoveSubstitute.Enabled = False
    End Sub

    Private Sub HandleScheduleSelection()
        Dim hasSelection = lvwOrgs.SelectedItems.Count > 0

        If hasSelection Then
            Dim scheduleId As Integer = GetSelectedScheduleId()
            ProcessSelectedSchedule(scheduleId)
        Else
            ResetScheduleDisplay()
        End If
    End Sub

    Private Sub ProcessSelectedSchedule(scheduleId As Integer)
        EnableSubstituteControls(True)
        LoadSubstituteDetails(scheduleId)
        UpdateScheduleDisplay()
    End Sub

    Private Sub ResetScheduleDisplay()
        ClearSubstituteControls()
        EnableSubstituteControls(False)
    End Sub

    Private Sub lvwSchedule_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvwSchedule.ColumnClick
        ' Create the sorting object
        Dim sorter As New ListViewColumnSorter()
        lvwSchedule.ListViewItemSorter = sorter

        ' Sort based on column clicked
        sorter.SortColumn = e.Column

        ' Toggle sort order
        If sorter.Order = SortOrder.Ascending Then
            sorter.Order = SortOrder.Descending
        Else
            sorter.Order = SortOrder.Ascending
        End If

        ' Perform the sort
        lvwSchedule.Sort()
    End Sub

End Class
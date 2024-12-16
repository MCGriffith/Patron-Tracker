Imports System.IO
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class FrmMain
    Dim connectionString As String = DatabaseConfig.ConnectionString

    ' Dictionary to store form instances
    Private formInstances As New Dictionary(Of Type, Form)

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeForm()
        ShowLoginForm()
    End Sub

    Private Sub InitializeForm()
        IsMdiContainer = True
        WindowState = FormWindowState.Maximized
        lblConnect.Left = ClientSize.Width - lblConnect.Width - 20
        lblConnect.Top = ClientSize.Height - lblConnect.Height - 20
        SetInitialMenuState()
        SetConnectionStatus()
    End Sub

    Private Sub SetInitialMenuState()
        mnuFile.Enabled = True
        mnuEdit.Enabled = False
        mnuView.Enabled = False
        mnuHelp.Enabled = True
        mnuPatron.Enabled = False
        mnuStaff.Enabled = False
        mnuDirector.Enabled = False
        mnuAdmin.Enabled = False
    End Sub

    Private Sub SetConnectionStatus()

        Using conn As New OleDbConnection(connectionString)
            Try
                conn.Open()
                lblConnect.Text = If(conn.State = ConnectionState.Open, "Connected", "Disconnected")
                lblConnect.BackColor = If(conn.State = ConnectionState.Open, Color.Green, Color.Red)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
                lblConnect.Text = "Disconnected"
                lblConnect.BackColor = Color.Red
            End Try
        End Using
    End Sub

    Private Sub ShowLoginForm()
        Dim loginForm As New FrmLogin()
        loginForm.Owner = Me
        If loginForm.ShowDialog() = DialogResult.OK Then
            UpdateMenuAccess()
        End If
    End Sub

    Public Sub UpdateMenuAccess()
        ' File and Help menus - always visible and enabled for all roles
        mnuFile.Visible = True
        mnuFile.Enabled = True
        mnuHelp.Visible = True
        mnuHelp.Enabled = True

        ' Edit and View menus - always visible but disabled
        mnuEdit.Visible = True
        mnuEdit.Enabled = False
        mnuView.Visible = True
        mnuView.Enabled = False

        ' Reset all role-based menus to visible but disabled
        mnuPatron.Visible = True
        mnuStaff.Visible = True
        mnuDirector.Visible = True
        mnuAdmin.Visible = True
        mnuPatron.Enabled = False
        mnuStaff.Enabled = False
        mnuDirector.Enabled = False
        mnuAdmin.Enabled = False

        ' Enable menus based on role
        Select Case GlobalVariables.CurrentUserRole
            Case "Admin"
                mnuPatron.Enabled = True
                mnuStaff.Enabled = True
                mnuDirector.Enabled = True
                mnuAdmin.Enabled = True
            Case "Director"
                mnuPatron.Enabled = True
                mnuStaff.Enabled = True
                mnuDirector.Enabled = True
            Case "Staff"
                mnuPatron.Enabled = True
                mnuStaff.Enabled = True
            Case "Patron"
                mnuPatron.Enabled = True
        End Select

        MenuStrip1.Refresh()
    End Sub

    Public Sub HandleLogout()
        UpdateMenuAccess()
        ShowLoginForm()
    End Sub

    Private Sub OpenSingleInstanceForm(Of T As {Form, New})()
        Try
            Dim formType As Type = GetType(T)
            If Not formInstances.ContainsKey(formType) OrElse formInstances(formType).IsDisposed Then
                Dim newForm As New T()
                newForm.MdiParent = Me
                AddHandler newForm.FormClosed, Sub(sender, e) formInstances.Remove(formType)
                newForm.Show()
                formInstances(formType) = newForm
            Else
                formInstances(formType).BringToFront()
            End If
        Catch ex As Exception
            MessageBox.Show($"Error opening form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mnuFileSwitchUser_Click(sender As Object, e As EventArgs) Handles mnuFileSwitchUser.Click
        ' Clear current user session
        GlobalVariables.CurrentUserRole = ""
        GlobalVariables.CurrentUserName = ""
        GlobalVariables.CurrentUserID = 0

        ' Close all child forms
        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

        ' Show login form and handle new login
        Dim loginForm As New FrmLogin()
        loginForm.Owner = Me
        If loginForm.ShowDialog() = DialogResult.OK Then
            UpdateMenuAccess()
        End If
    End Sub

    Private Sub mnuHelpDoc_Click(sender As Object, e As EventArgs) Handles mnuHelpDoc.Click
        If File.Exists(DocumentationConfig.DocumentationPath) Then
            Process.Start(DocumentationConfig.DocumentationPath)
        Else
            MessageBox.Show("Documentation file not found at: " & DocumentationConfig.DocumentationPath)
        End If
    End Sub


    'Patron Menus
    Private Sub mnuPatronPatron_Click(sender As Object, e As EventArgs) Handles mnuPatronPatron.Click
        OpenSingleInstanceForm(Of FrmProfileUpdate)()
    End Sub
    Private Sub mnuPatronLoginUpdate_Click(sender As Object, e As EventArgs) Handles mnuPatronLoginUpdate.Click
        OpenSingleInstanceForm(Of FrmLoginUpdate)()
    End Sub
    Private Sub mnuPatronReport_Click(sender As Object, e As EventArgs) Handles mnuPatronReport.Click
        OpenSingleInstanceForm(Of FrmPatronReport)()
    End Sub


    'Staff Menus
    Private Sub mnuStafLoginUpdate_Click(sender As Object, e As EventArgs) Handles mnuStafLoginUpdate.Click
        OpenSingleInstanceForm(Of FrmLoginUpdate)()
    End Sub
    Private Sub mnuStafPatron_Click(sender As Object, e As EventArgs) Handles mnuStafPatron.Click
        OpenSingleInstanceForm(Of FrmProfileUpdate)()
    End Sub
    Private Sub mnuStaffPatronReport_Click(sender As Object, e As EventArgs) Handles mnuStaffPatronReport.Click
        OpenSingleInstanceForm(Of FrmPatronReport)()
    End Sub

    'Director Menus
    Private Sub mnuDirectorAddEvents_Click(sender As Object, e As EventArgs) Handles mnuDirectorAddEvents.Click
        OpenSingleInstanceForm(Of FrmAddEvent)()
    End Sub
    Private Sub mnuDirectorLoginUpdate_Click(sender As Object, e As EventArgs) Handles mnuDirectorLoginUpdate.Click
        OpenSingleInstanceForm(Of FrmLoginUpdate)()
    End Sub
    Private Sub mnuDirectorPatron_Click(sender As Object, e As EventArgs) Handles mnuDirectorPatron.Click
        OpenSingleInstanceForm(Of FrmProfileUpdate)()
    End Sub
    Private Sub mnuDirectorReport_Click(sender As Object, e As EventArgs) Handles mnuDirectorReport.Click
        OpenSingleInstanceForm(Of FrmReports)()
    End Sub
    Private Sub mnuDirectorAttendFix_Click(sender As Object, e As EventArgs) Handles mnuDirectorAttendFix.Click
        OpenSingleInstanceForm(Of FrmAttendanceFix)()
    End Sub
    Private Sub mnuDirectorPatronReport_Click(sender As Object, e As EventArgs) Handles mnuDirectorPatronReport.Click
        OpenSingleInstanceForm(Of FrmPatronReport)()
    End Sub
    Private Sub mnuDirectorAttendanceAnalytics_Click(sender As Object, e As EventArgs) Handles mnuDirectorAttendanceAnalytics.Click
        OpenSingleInstanceForm(Of FrmAttendanceAnalytics)()
    End Sub


    'Admin Menus
    Private Sub mnuAdminAddEvents_Click(sender As Object, e As EventArgs) Handles mnuAdminAddEvents.Click
        OpenSingleInstanceForm(Of FrmAddEvent)()
    End Sub
    Private Sub mnuAdminLoginUpdate_Click(sender As Object, e As EventArgs) Handles mnuAdminLoginUpdate.Click
        OpenSingleInstanceForm(Of FrmLoginUpdate)()
    End Sub
    Private Sub mnuAdminPatron_Click(sender As Object, e As EventArgs) Handles mnuAdminPatron.Click
        OpenSingleInstanceForm(Of FrmProfileUpdate)()
    End Sub
    Private Sub mnuAdminReports_Click(sender As Object, e As EventArgs) Handles mnuAdminReports.Click
        OpenSingleInstanceForm(Of FrmReports)()
    End Sub

    Private Sub mnuAdminAbout_Click(sender As Object, e As EventArgs) Handles mnuAdminAbout.Click
        OpenSingleInstanceForm(Of FrmAboutFix)()
    End Sub
    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        OpenSingleInstanceForm(Of FrmAbout)()
    End Sub
    Private Sub mnuAdminAttendFix_Click(sender As Object, e As EventArgs) Handles mnuAdminAttendFix.Click
        OpenSingleInstanceForm(Of FrmAttendanceFix)()
    End Sub
    Private Sub mnuAdminSettings_Click(sender As Object, e As EventArgs) Handles mnuAdminSettings.Click
        OpenSingleInstanceForm(Of FrmSettings)()
    End Sub
    Private Sub mnuAdminPatronReport_Click(sender As Object, e As EventArgs) Handles mnuAdminPatronReport.Click
        OpenSingleInstanceForm(Of FrmPatronReport)()
    End Sub
    Private Sub mnuAdminAttendanceAnalytics_Click(sender As Object, e As EventArgs) Handles mnuAdminAttendanceAnalytics.Click
        OpenSingleInstanceForm(Of FrmAttendanceAnalytics)()
    End Sub
    Private Sub mnuAdminVolunteer_Click(sender As Object, e As EventArgs) Handles mnuAdminVolunteer.Click
        OpenSingleInstanceForm(Of FrmVolunteer)()
    End Sub

    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        ' Create a list to hold forms that need to be closed
        Dim formsToClose As New List(Of Form)

        ' Collect forms to close
        For Each frm As Form In Application.OpenForms
            If frm IsNot Me Then
                formsToClose.Add(frm)
            End If
        Next

        ' Close collected forms
        For Each frm As Form In formsToClose
            frm.Close()
        Next

        ' Using statement ensures proper disposal of connection
        Using connection As New OleDbConnection(connectionString)
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Using

        ' Close the main form
        Me.Close()

        ' Ensure application exits completely
        Application.Exit()
    End Sub
End Class

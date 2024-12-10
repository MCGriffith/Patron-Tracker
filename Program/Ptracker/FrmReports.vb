Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports Microsoft.Office.Interop

Public Class FrmReports
    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private tempFilePath As String = Path.Combine(Path.GetTempPath(), "TempReport")

    '   Public Sub New()
    '       InitializeComponent()
    '   End Sub

    Private Sub FrmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)

        ' Disable controls
        btnGenerate.Enabled = False
        btnPrint.Enabled = False
        btnSave.Enabled = False
        cboReport.Enabled = False
        cboEvent.Enabled = False
        dtpStartDate.Visible = False
        dtpEndDate.Visible = False
        WebBrowser1.Visible = False
        cboEventType.Enabled = False
        lblReport.Enabled = False
        lblEvent.Enabled = False
        lblType.Enabled = False
        lblStart.Enabled = False
        lblStop.Enabled = False
        cboDates.Enabled = False


        ' Enable select and close buttons
        btnSelect.Enabled = True
        btnClose.Enabled = True

        ' Populate cboReport
        PopulateReportComboBox()

        ' Populate cboEvent
        PopulateEventComboBox()

        ' Populate cboEventType
        PopulateEventTypeComboBox()

        'Populate cboDates
        PopulateDateComboBox()
    End Sub

    Private Sub PopulateReportComboBox()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT ReportName FROM tblReports", conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            cboReport.Items.Clear()
            While reader.Read()
                cboReport.Items.Add(reader("ReportName").ToString())
            End While
        End Using
    End Sub

    Private Sub PopulateEventComboBox()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            Dim sql As String = "SELECT EventName FROM tblEvents " &
                           "WHERE Inactive = False " &
                           "AND RegStart <= #" & DateTime.Today.ToString("MM/dd/yyyy") & "# " &
                           "AND RegStop >= #" & DateTime.Today.ToString("MM/dd/yyyy") & "# " &
                           "ORDER BY EventName"

            Dim cmd As New OleDbCommand(sql, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            cboEvent.Items.Clear()

            While reader.Read()
                cboEvent.Items.Add(reader.GetString(0))
            End While
        End Using
    End Sub

    Private Sub PopulateEventTypeComboBox()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT EventType FROM tblEventTypes", conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            cboEventType.Items.Clear()
            While reader.Read()
                cboEventType.Items.Add(reader("EventType").ToString())
            End While
        End Using
    End Sub

    Private Sub PopulateDateComboBox()
        Using conn As New OleDbConnection(connectionString)
            conn.Open()
            Dim cmd As New OleDbCommand("SELECT DateName FROM tblDates", conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            cboDates.Items.Clear()
            While reader.Read()
                cboDates.Items.Add(reader("DateName").ToString())
            End While
        End Using
    End Sub

    Private Sub cboDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDates.SelectedIndexChanged
        Select Case cboDates.SelectedItem.ToString()
            Case "Current Month"
                lblStart.Enabled = False
                lblStop.Enabled = False
                dtpStartDate.Visible = False
                dtpEndDate.Visible = False
                SetCurrentMonthDates()
            Case "Previous Month"
                lblStart.Enabled = False
                lblStop.Enabled = False
                dtpStartDate.Visible = False
                dtpEndDate.Visible = False
                SetPreviousMonthDates()
            Case "Custom Dates"
                lblStart.Enabled = True
                lblStop.Enabled = True
                dtpStartDate.Visible = True
                dtpEndDate.Visible = True
        End Select
    End Sub

    Private Sub SetCurrentMonthDates()
        Dim currentDate As Date = DateTime.Today
        dtpStartDate.Value = New Date(currentDate.Year, currentDate.Month, 1)
        dtpEndDate.Value = DateSerial(currentDate.Year, currentDate.Month + 1, 0)
    End Sub

    Private Sub SetPreviousMonthDates()
        Dim currentDate As Date = DateTime.Today
        dtpStartDate.Value = New Date(currentDate.Year, currentDate.Month - 1, 1)
        dtpEndDate.Value = DateSerial(currentDate.Year, currentDate.Month, 0)
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lblReport.Enabled = True
        cboReport.Enabled = True
        WebBrowser1.Visible = True
    End Sub

    Private Sub cboReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReport.SelectedIndexChanged
        ' Clear previous selections
        cboEvent.SelectedIndex = -1
        cboEventType.SelectedIndex = -1

        Select Case cboReport.SelectedItem.ToString()
            Case "Events"
                lblEvent.Enabled = True
                cboEvent.Enabled = True
                lblType.Enabled = True
                cboEventType.Enabled = True
                cboDates.Enabled = False
                lblStart.Enabled = False
                lblStop.Enabled = False
                dtpStartDate.Visible = False
                dtpEndDate.Visible = False
            Case "Attendance"
                lblReport.Enabled = True
                cboDates.Enabled = True
                cboEvent.Enabled = False
                cboEventType.Enabled = False
            Case "Mailing Labels"
                lblEvent.Enabled = False
                lblType.Enabled = False
                cboEvent.Enabled = False
                cboEventType.Enabled = False
                cboDates.Enabled = False
                lblStart.Enabled = False
                lblStop.Enabled = False
                dtpStartDate.Visible = False
                dtpEndDate.Visible = False
            Case "Contact List"
                lblEvent.Enabled = False
                lblType.Enabled = False
                cboEvent.Enabled = False
                cboEventType.Enabled = False
                cboDates.Enabled = False
                lblStart.Enabled = False
                lblStop.Enabled = False
                dtpStartDate.Visible = False
                dtpEndDate.Visible = False
        End Select

        btnGenerate.Enabled = True
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If cboReport.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a report type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim selectedReport As String = cboReport.SelectedItem.ToString()

        Select Case selectedReport
            Case "Events"
                If cboEvent.SelectedItem Is Nothing Then
                    MessageBox.Show("Please select an event.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
                If cboEventType.SelectedItem Is Nothing Then
                    MessageBox.Show("Please select an event type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                Dim selectedEvent As String = cboEvent.SelectedItem.ToString()
                GenerateEventReport(selectedEvent)

            Case "Attendance"
                GenerateAttendanceReport(dtpStartDate.Value, dtpEndDate.Value)

            Case "Mailing Labels"
                GenerateMailingLabelsReport()

            Case "Contact List"
                GenerateContactListReport()

            Case Else
                ' Handle other report types here
        End Select

        btnPrint.Enabled = True
        btnSave.Enabled = True
    End Sub

    Private Sub GenerateAttendanceReport(startDate As Date, endDate As Date)
        Using conn As New OleDbConnection(connectionString)
            conn.Open()

            ' Query to get all attendance records for the date range
            Dim sql As String = "SELECT People, FirstVisit, PrintFOR, Indexing, " &
                           "OnlineRsrch, SubWebsite, AttendClass, Other " &
                           "FROM tblAttendance " &
                           "WHERE LogDate BETWEEN @StartDate AND @EndDate"

            Dim cmd As New OleDbCommand(sql, conn)
            cmd.Parameters.AddWithValue("@StartDate", startDate)
            cmd.Parameters.AddWithValue("@EndDate", endDate)

            ' Initialize counters
            Dim peopleCount As Integer = 0
            Dim firstVisitCount As Integer = 0
            Dim printFORCount As Integer = 0
            Dim indexingCount As Integer = 0
            Dim onlineRsrchCount As Integer = 0
            Dim subWebsiteCount As Integer = 0
            Dim attendClassCount As Integer = 0
            Dim otherCount As Integer = 0

            ' Read and count all records
            Using reader As OleDbDataReader = cmd.ExecuteReader()
                While reader.Read()
                    ' Count total people visits
                    If CBool(reader("People")) Then peopleCount += 1

                    ' Count other fields
                    If CBool(reader("FirstVisit")) Then firstVisitCount += 1
                    If CBool(reader("PrintFOR")) Then printFORCount += 1
                    If CBool(reader("Indexing")) Then indexingCount += 1
                    If CBool(reader("OnlineRsrch")) Then onlineRsrchCount += 1
                    If CBool(reader("SubWebsite")) Then subWebsiteCount += 1
                    If CBool(reader("AttendClass")) Then attendClassCount += 1
                    If CBool(reader("Other")) Then otherCount += 1
                End While
            End Using

            ' Generate HTML report
            Dim html As New StringBuilder()
            html.AppendLine("<html><head>")
            html.AppendLine("<style>")
            html.AppendLine("body { font-family: Arial, sans-serif; margin: 20px; }")
            html.AppendLine("h1, h2 { text-align: center; }")
            html.AppendLine("table { width: 100%; border-collapse: collapse; margin-top: 20px; }")
            html.AppendLine("th { border-bottom: 2px solid #000; padding: 8px; text-align: center; }")
            html.AppendLine("td { border-bottom: 1px solid #ddd; padding: 8px; text-align: center; }")
            html.AppendLine("</style>")
            html.AppendLine("</head><body>")

            ' Add title and date range
            html.AppendLine("<h1>Attendance Report</h1>")
            html.AppendLine($"<h2>for: {startDate:MM/dd/yyyy} to {endDate:MM/dd/yyyy}</h2>")

            ' Create table with counts
            html.AppendLine("<table>")
            html.AppendLine("<tr>")
            html.AppendLine($"<th>People</th>")
            html.AppendLine($"<th>First Visit</th>")
            html.AppendLine($"<th>Print FOR</th>")
            html.AppendLine($"<th>Indexing</th>")
            html.AppendLine($"<th>Online<br>Research</th>")
            html.AppendLine($"<th>Websites</th>")
            html.AppendLine($"<th>Attend<br>Class</th>")
            html.AppendLine($"<th>Other</th>")
            html.AppendLine("</tr>")

            ' Add counts row
            html.AppendLine("<tr>")
            html.AppendLine($"<td>{peopleCount}</td>")
            html.AppendLine($"<td>{firstVisitCount}</td>")
            html.AppendLine($"<td>{printFORCount}</td>")
            html.AppendLine($"<td>{indexingCount}</td>")
            html.AppendLine($"<td>{onlineRsrchCount}</td>")
            html.AppendLine($"<td>{subWebsiteCount}</td>")
            html.AppendLine($"<td>{attendClassCount}</td>")
            html.AppendLine($"<td>{otherCount}</td>")
            html.AppendLine("</tr>")
            html.AppendLine("</table>")
            html.AppendLine("</body></html>")

            ' Save and display report
            File.WriteAllText(tempFilePath, html.ToString())
            WebBrowser1.Navigate(tempFilePath)
        End Using
    End Sub

    Private Sub GenerateEventReport(eventName As String)
        If cboEventType.SelectedItem.ToString() = "Name Labels" Then
            GenerateEventNameLabels(eventName)
            Return
        End If
        Dim html As New StringBuilder()

        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                ' Get event date
                Dim cmdDate As New OleDbCommand("SELECT TOP 1 EventDate FROM tblRegister WHERE EventName = @EventName", conn)
                cmdDate.Parameters.AddWithValue("@EventName", eventName)
                Dim eventDate As Object = cmdDate.ExecuteScalar()

                ' Start HTML document
                html.AppendLine("<html><head><style>")
                html.AppendLine("body { font-family: Arial, sans-serif; }")
                html.AppendLine("h1, h2 { text-align: center; }")
                html.AppendLine("table { width: 100%; border-collapse: collapse; }")
                html.AppendLine("th { border-bottom: 1px solid black; padding: 5px; }")
                html.AppendLine("td { padding: 5px; text-align: center; }")
                html.AppendLine("</style></head><body>")

                ' Add title
                html.AppendLine($"<h2>{eventName}</h2>")
                html.AppendLine($"<h2>Event Date: {If(eventDate IsNot Nothing AndAlso eventDate IsNot DBNull.Value, CDate(eventDate).ToShortDateString(), "Date not available")}</h2>")


                ' Create table
                html.AppendLine("<table>")
                html.AppendLine("<tr><th>Full Name</th><th>Phone Number</th><th>Email</th></tr>")

                ' Get event attendees
                Dim cmd As New OleDbCommand(
                  "SELECT DISTINCT r.LoginID, c.ContactID, c.FullName, l.Email " &
                  "FROM (tblRegister AS r " &
                  "INNER JOIN tblLogin AS l ON r.LoginID = l.LoginID) " &
                  "INNER JOIN tblContacts AS c ON l.LoginID = c.LoginID " &
                  "WHERE r.EventName = @EventName " &
                  "ORDER BY c.FullName", conn)
                cmd.Parameters.AddWithValue("@EventName", eventName)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim loginID As String = reader("LoginID").ToString()
                    Dim fullName As String = reader("FullName").ToString()
                    Dim email As String = reader("Email").ToString()

                    ' Get phone number
                    Dim phoneCmd As New OleDbCommand("SELECT TOP 1 PhoneNumber FROM tblPhone WHERE ContactID = @ContactID", conn)
                    phoneCmd.Parameters.AddWithValue("@ContactID", reader("ContactID")) ' Using ContactID from tblContacts
                    Dim phoneNumber As Object = phoneCmd.ExecuteScalar()

                    html.AppendLine("<tr>")
                    html.AppendLine($"<td>{fullName}</td>")
                    html.AppendLine($"<td>{If(phoneNumber IsNot Nothing AndAlso phoneNumber IsNot DBNull.Value, phoneNumber.ToString(), "N/A")}</td>")
                    html.AppendLine($"<td>{email}</td>")
                    html.AppendLine("</tr>")
                End While

                html.AppendLine("</table>")
                html.AppendLine("</body></html>")
            End Using

            ' Save HTML to temp file
            File.WriteAllText(tempFilePath, html.ToString())

            ' Display in WebBrowser control
            WebBrowser1.Navigate(tempFilePath)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerateEventNameLabels(eventName As String)
        Dim html As New StringBuilder()
        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                ' Start HTML document with proper Avery 5160 formatting
                html.AppendLine("<html><head>")
                html.AppendLine("<style>")
                html.AppendLine("@page { size: 8.5in 11in; margin: 0.5in 0.16in; }")
                html.AppendLine("body { font-family: Arial, sans-serif; margin: 0; padding: 0; }")
                html.AppendLine(".label-container { width: 8.5in; margin: 0 auto; }")
                html.AppendLine(".label { width: 2.625in; height: 1in; float: left; margin: 0; padding: 0.125in; box-sizing: border-box; text-align: center; }")
                html.AppendLine(".name { font-size: 14pt; font-weight: bold; margin-bottom: 5px; }")
                html.AppendLine(".event { font-size: 10pt; }")
                html.AppendLine("</style></head><body>")
                html.AppendLine("<div class='label-container'>")

                ' Get event attendees
                Dim cmd As New OleDbCommand(
                "SELECT DISTINCT c.FullName " &
                "FROM (tblRegister AS r " &
                "INNER JOIN tblLogin AS l ON r.LoginID = l.LoginID) " &
                "INNER JOIN tblContacts AS c ON l.LoginID = c.LoginID " &
                "WHERE r.EventName = @EventName " &
                "ORDER BY c.FullName", conn)
                cmd.Parameters.AddWithValue("@EventName", eventName)

                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                ' Generate labels
                While reader.Read()
                    html.AppendLine("<div class='label'>")
                    html.AppendLine($"<div class='name'>{reader("FullName")}</div>")
                    html.AppendLine($"<div class='event'>{eventName}</div>")
                    html.AppendLine("</div>")
                End While

                html.AppendLine("</div></body></html>")
            End Using

            ' Save HTML to temp file
            File.WriteAllText(tempFilePath & ".html", html.ToString())

            ' Display in WebBrowser control
            WebBrowser1.Navigate(tempFilePath & ".html")

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerateMailingLabelsReport()
        Dim html As New StringBuilder()

        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim cmd As New OleDbCommand("SELECT * FROM qryMLabels", conn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                ' Start HTML document
                html.AppendLine("<html><head><style>")
                html.AppendLine("body { font-family: Arial, sans-serif; }")
                html.AppendLine(".label { width: 2.625in; height: 1in; padding: 0.125in; margin: 0; float: left; overflow: hidden; }")
                html.AppendLine("</style></head><body>")

                ' Generate labels
                While reader.Read()
                    html.AppendLine("<div class='label'>")
                    html.AppendLine($"{reader("FullName")}<br>")
                    html.AppendLine($"{reader("Address")}<br>")
                    html.AppendLine($"{reader("City")}, {reader("State")} {reader("ZIP")}")
                    html.AppendLine("</div>")
                End While

                html.AppendLine("</body></html>")
            End Using

            ' Save HTML to temp file
            File.WriteAllText(tempFilePath, html.ToString())

            ' Display in WebBrowser control
            WebBrowser1.Navigate(tempFilePath)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GenerateContactListReport()
        Dim html As New StringBuilder()

        Try
            Using conn As New OleDbConnection(connectionString)
                conn.Open()

                ' Start HTML document with same styling as before
                html.AppendLine("<html><head><style>")
                html.AppendLine("body { font-family: Arial, sans-serif; margin: 0.5in; }")
                html.AppendLine(".label { width: 2.625in; height: 1.5in; padding: 0.125in; margin: 0; float: left; overflow: hidden; text-align: center; }")
                html.AppendLine(".name { font-size: 12pt; font-weight: bold; margin-bottom: 5px; }")
                html.AppendLine(".details { font-size: 10pt; }")
                html.AppendLine("h1 { text-align: center; margin-bottom: 20px; }")
                html.AppendLine("</style></head><body>")
                html.AppendLine("<h1>Contact List</h1>")

                ' Correct SQL query based on actual table structure
                Dim sql As String = "SELECT c.FullName, c.ContactID, l.Email, " &
                               "a.Address, a.City, a.State, a.Zip " &
                               "FROM ((tblContacts c " &
                               "LEFT JOIN tblLogin l ON c.LoginID = l.LoginID) " &
                               "LEFT JOIN tblAddress a ON c.ContactID = a.ContactID) " &
                               "ORDER BY c.FullName"

                Dim cmd As New OleDbCommand(sql, conn)
                Dim reader As OleDbDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ' Get phone number for each contact
                    Dim phoneCmd As New OleDbCommand("SELECT TOP 1 PhoneNumber FROM tblPhone WHERE ContactID = @ContactID", conn)
                    phoneCmd.Parameters.AddWithValue("@ContactID", reader("ContactID"))
                    Dim phoneNumber As Object = phoneCmd.ExecuteScalar()

                    html.AppendLine("<div class='label'>")
                    html.AppendLine($"<div class='name'>{reader("FullName")}</div>")
                    html.AppendLine("<div class='details'>")
                    If Not IsDBNull(reader("Address")) Then
                        html.AppendLine($"{reader("Address")}<br>")
                        html.AppendLine($"{reader("City")}, {reader("State")} {reader("Zip")}<br>")
                    End If
                    html.AppendLine($"Phone: {If(phoneNumber IsNot Nothing AndAlso phoneNumber IsNot DBNull.Value, phoneNumber.ToString(), "N/A")}<br>")
                    html.AppendLine($"Email: {If(Not IsDBNull(reader("Email")), reader("Email").ToString(), "N/A")}")
                    html.AppendLine("</div>")
                    html.AppendLine("</div>")
                End While

                html.AppendLine("</body></html>")
            End Using

            File.WriteAllText(tempFilePath, html.ToString())
            WebBrowser1.Navigate(tempFilePath)

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetReportContent() As String
        ' Convert your report data to string/HTML
        ' Example:
        Dim content As String = "<html><body>"
        ' Add your report data here
        content &= "</body></html>"
        Return content
    End Function

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        WebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            saveDialog.DefaultExt = "pdf"
            saveDialog.Title = "Save as PDF"
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

            If saveDialog.ShowDialog() = DialogResult.OK Then
                PDFHelper.CreatePDFFromWebBrowser(WebBrowser1, saveDialog.FileName)
            End If
        Catch ex As Exception
            MessageBox.Show("Error creating PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmReports_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Clean up temp file
        If File.Exists(tempFilePath) Then
            File.Delete(tempFilePath)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Clean up temp file
        If File.Exists(tempFilePath) Then
            File.Delete(tempFilePath)
        End If
        Me.Close()
    End Sub
End Class
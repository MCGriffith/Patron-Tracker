Imports System.Data.OleDb
Imports System.IO
Imports System.Text

Public Class FrmPatronReport
    Dim connectionString As String = DatabaseConfig.ConnectionString
    Private tempFilePath As String = Path.Combine(Path.GetTempPath(), "TempReport.html")
    Private conn As OleDbConnection
    Private currentRole As String
    Private currentUserName As String

    Private Sub Form_Load() Handles MyBase.Load
        EstablishConnection()
        lblRole.Text = GlobalVariables.CurrentUserRole
        DisableControls()
    End Sub

    Private Sub EstablishConnection()
        Try
            conn = New OleDbConnection(connectionString)
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Database connection failed: " & ex.Message)
        End Try
    End Sub

    Private Sub DisableControls()
        cboName.Enabled = False
        lblName.Enabled = False
        lblPIN.Enabled = False
        txtPIN.Enabled = False
        lblMatch.Enabled = False
        WebBrowser2.Visible = False
        btnPrint.Enabled = False
        btnSave.Enabled = False
        btnGenerateReport.Enabled = False
        btnSelectName.Enabled = True
        btnClose.Enabled = True
        lblMatch.Text = "No Match"
        lblMatch.ForeColor = Color.White
        lblMatch.BackColor = Color.Red
    End Sub

    Private Sub LoadAllNames()
        Try
            Using cmd As New OleDbCommand("SELECT FullName FROM tblContacts ORDER BY FullName", conn)
                Using da As New OleDbDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    Dim emptyRow As DataRow = dt.NewRow()
                    emptyRow("FullName") = ""
                    dt.Rows.InsertAt(emptyRow, 0)
                    cboName.DataSource = dt
                    cboName.DisplayMember = "FullName"
                    cboName.ValueMember = "FullName"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading names: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSelectName_Click(sender As Object, e As EventArgs) Handles btnSelectName.Click
        cboName.Enabled = True
        lblName.Enabled = True

        Select Case GlobalVariables.CurrentUserRole
            Case "Patron"
                ' Setup for Patron role
                cboName.DataSource = Nothing
                cboName.Items.Clear()
                cboName.Items.Add(GlobalVariables.CurrentUserName)
                cboName.SelectedIndex = 0
                cboName.Enabled = False

                ' Enable PIN controls for Patron
                lblPIN.Enabled = True
                txtPIN.Enabled = True
                lblMatch.Enabled = True
                WebBrowser2.Visible = False
                btnGenerateReport.Enabled = False

            Case "Staff", "Director", "Admin"
                ' Setup for non-Patron roles
                LoadAllNames()
                cboName.Enabled = True

                ' Disable PIN controls for non-Patron roles
                lblPIN.Enabled = False
                txtPIN.Enabled = False
                lblMatch.Enabled = True
                lblMatch.Text = "Not Required"
                lblMatch.ForeColor = Color.White
                lblMatch.BackColor = Color.Green

                ' Enable report generation immediately for non-Patron roles
                If Not String.IsNullOrEmpty(cboName.Text) Then
                    WebBrowser2.Visible = True
                    btnGenerateReport.Enabled = True
                End If
        End Select
    End Sub


    Private Sub txtPIN_TextChanged(sender As Object, e As EventArgs) Handles txtPIN.TextChanged
        ' Only verify PIN for Patron role
        If GlobalVariables.CurrentUserRole = "Patron" Then
            Try
                Dim sql As String = "SELECT PIN FROM tblLogin l, tblContacts c " &
                               "WHERE l.LoginID = c.LoginID " &
                               "And c.FullName = @FullName"
                Using cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        Dim storedPIN As String = result.ToString()
                        If txtPIN.Text = storedPIN Then
                            lblMatch.Text = "Match"
                            lblMatch.ForeColor = Color.White
                            lblMatch.BackColor = Color.Green
                            WebBrowser2.Visible = True
                            btnGenerateReport.Enabled = True
                        Else
                            lblMatch.Text = "No Match"
                            lblMatch.ForeColor = Color.White
                            lblMatch.BackColor = Color.Red
                            WebBrowser2.Visible = False
                            btnGenerateReport.Enabled = False
                        End If
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error verifying PIN: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub cboName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboName.SelectedIndexChanged
        If GlobalVariables.CurrentUserRole = "Patron" Then
            WebBrowser2.DocumentText = ""
            WebBrowser2.Visible = False
            btnGenerateReport.Enabled = False
            btnPrint.Enabled = False
            btnSave.Enabled = False
            txtPIN.Clear()
            lblMatch.Text = "No Match"
            lblMatch.ForeColor = Color.White
            lblMatch.BackColor = Color.Red
        Else
            If Not String.IsNullOrEmpty(cboName.Text) Then
                WebBrowser2.Visible = True
                btnGenerateReport.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        If Not WebBrowser2.Visible Then Exit Sub

        Try
            Dim html As New StringBuilder()
            html.AppendLine("<html><head><style>")
            html.AppendLine("body { font-family: Arial; margin: 20px; }")
            html.AppendLine("h1 { text-align: center; }")
            html.AppendLine(".date { text-align: center; margin-bottom: 20px; }")
            html.AppendLine("table { width: 100%; border-collapse: collapse; }")
            html.AppendLine("th, td { padding: 8px; text-align: left; border: 1px solid #ddd; }")
            html.AppendLine("</style></head><body>")
            html.AppendLine("<h1>Patron Class/Event List</h1>")
            html.AppendLine($"<div class='date'>Created: {DateTime.Now.ToShortDateString()}</div>")
            html.AppendLine($"<div>Patron: {cboName.Text}</div><br>")
            html.AppendLine("<table>")
            html.AppendLine("<tr><th>Event/Class Name</th><th>Event Date</th><th>Registered Date</th></tr>")

            Dim sql As String = "SELECT DISTINCT e.EventName, e.EventDate, MIN(r.RegisterDate) as RegisterDate " &
              "FROM ((tblRegister r " &
              "INNER JOIN tblLogin l ON r.loginID = l.loginID) " &
              "INNER JOIN tblContacts c ON l.loginID = c.loginID) " &
              "INNER JOIN tblEvents e ON r.EventID = e.EventID " &
              "WHERE c.FullName = @FullName " &
              "AND e.EventDate >= Date() " &
              "AND e.Inactive = False " &
              "AND r.Inactive = False " &
              "GROUP BY e.EventName, e.EventDate " &
              "ORDER BY e.EventDate"

            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@FullName", cboName.Text)
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        html.AppendLine("<tr>")
                        html.AppendLine($"<td>{reader("EventName")}</td>")
                        html.AppendLine($"<td>{Convert.ToDateTime(reader("EventDate")).ToShortDateString()}</td>")
                        html.AppendLine($"<td>{Convert.ToDateTime(reader("RegisterDate")).ToShortDateString()}</td>")
                        html.AppendLine("</tr>")
                    End While
                End Using
            End Using

            html.AppendLine("</table></body></html>")
            WebBrowser2.DocumentText = html.ToString()
            btnPrint.Enabled = True
            btnSave.Enabled = True

        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            saveDialog.DefaultExt = "pdf"
            saveDialog.Title = "Save Report as PDF"
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

            If saveDialog.ShowDialog() = DialogResult.OK Then
                PDFHelper.CreatePDFFromWebBrowser(WebBrowser2, saveDialog.FileName)
                MessageBox.Show("Report saved as PDF successfully!", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error creating PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf|HTML Files (*.html)|*.html|All Files (*.*)|*.*"
            saveDialog.DefaultExt = "pdf"
            saveDialog.Title = "Save Report"
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

            If saveDialog.ShowDialog() = DialogResult.OK Then
                If saveDialog.FileName.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase) Then
                    PDFHelper.CreatePDFFromWebBrowser(WebBrowser2, saveDialog.FileName)
                Else
                    File.WriteAllText(saveDialog.FileName, WebBrowser2.DocumentText)
                End If
                MessageBox.Show("Report saved successfully!", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error saving file: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Try
            ' Clean up database connection
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If

            ' Clean up temp file
            If File.Exists(tempFilePath) Then
                File.Delete(tempFilePath)
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error during cleanup: " & ex.Message, "Cleanup Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
        End Try
    End Sub

    Private Sub Form_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            Debug.WriteLine("Error during form closing: " & ex.Message)
        End Try
    End Sub
End Class

Imports System.IO
Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports iTextSharp.text
Imports iTextSharp.text.pdf


Public Class FrmAttendanceAnalytics
    Inherits Form
    Private Sub FrmAttendanceAnalytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)

        ' Setup ComboBox

        cboDateRange.Items.Clear()
        cboDateRange.Items.AddRange({"Daily", "Weekly", "Monthly", "Custom"})

        cboExport.Items.Clear()
        cboExport.Items.AddRange({"CSV", "Excel", "PDF"})

        ' Setup Chart
        chartAttendance.ChartAreas.Clear()
        chartAttendance.ChartAreas.Add(New ChartArea("MainArea"))
        chartAttendance.Legends.Clear()
        chartAttendance.Legends.Add(New Legend("MainLegend"))

        ' Set initial selection
        cboDateRange.SelectedIndex = 0
    End Sub

    Private Function BuildFilterQuery() As String
        Dim filters As New List(Of String)

        If cbxPeople.Checked Then filters.Add("People = True")
        If cbxFirstVisit.Checked Then filters.Add("FirstVisit = True")
        If cbxPrintFOR.Checked Then filters.Add("PrintFOR = True")
        If cbxIndexing.Checked Then filters.Add("Indexing = True")
        If cbxOnlineRsrch.Checked Then filters.Add("OnlineRsrch = True")
        If cbxSubWebsite.Checked Then filters.Add("SubWebsite = True")
        If cbxAttendClass.Checked Then filters.Add("AttendClass = True")
        If cbxOther.Checked Then filters.Add("Other = True")

        If filters.Count > 0 Then
            Return " AND " & String.Join(" AND ", filters)
        End If
        Return ""
    End Function

    Private Sub UpdateChart()
        Dim query As String = "SELECT LogDate, Format([LogTime],'HH') as HourOfDay, " &
                      "Sum(IIf([People],-1,0)) as PeopleCount, " &
                      "Sum(IIf([FirstVisit],-1,0)) as FirstVisitCount, " &
                      "Sum(IIf([PrintFOR],-1,0)) as PrintFORCount, " &
                      "Sum(IIf([Indexing],-1,0)) as IndexingCount, " &
                      "Sum(IIf([OnlineRsrch],-1,0)) as OnlineRsrchCount, " &
                      "Sum(IIf([SubWebsite],-1,0)) as SubWebsiteCount, " &
                      "Sum(IIf([AttendClass],-1,0)) as AttendClassCount, " &
                      "Sum(IIf([Other],-1,0)) as OtherCount " &
                      "FROM tblAttendance " &
                      "WHERE LogDate BETWEEN #" & dtpStartDate.Value.ToString("MM/dd/yyyy") & "# " &
                      "AND #" & dtpEndDate.Value.ToString("MM/dd/yyyy") & "#" &
                      BuildFilterQuery() &
                      " GROUP BY LogDate, Format([LogTime],'HH') " &
                      "ORDER BY LogDate, Format([LogTime],'HH')"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(query, conn)
                conn.Open()
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                UpdateChartSeries(dt)
            End Using
        End Using
    End Sub

    Private Sub UpdateChartSeries(dt As DataTable)
        chartAttendance.Series.Clear()

        ' Create series for each attendance type
        Dim seriesNames() As String = {"People", "FirstVisit", "PrintFOR", "Indexing",
                                  "OnlineRsrch", "SubWebsite", "AttendClass", "Other"}

        For Each seriesName In seriesNames
            Dim series As New Series(seriesName)
            series.ChartType = SeriesChartType.Column
            chartAttendance.Series.Add(series)

            ' Add data points
            For Each row As DataRow In dt.Rows
                series.Points.AddXY(row("HourOfDay").ToString() & ":00",
                              row(seriesName & "Count"))
            Next
        Next
    End Sub

    Private Function ShouldShowSeries(seriesName As String) As Boolean
        ' If no filters are checked, show all series
        If Not AnyFiltersChecked() Then Return True

        ' Check corresponding checkbox
        Select Case seriesName
            Case "People" : Return cbxPeople.Checked
            Case "FirstVisit" : Return cbxFirstVisit.Checked
            Case "PrintFOR" : Return cbxPrintFOR.Checked
            Case "Indexing" : Return cbxIndexing.Checked
            Case "OnlineRsrch" : Return cbxOnlineRsrch.Checked
            Case "SubWebsite" : Return cbxSubWebsite.Checked
            Case "AttendClass" : Return cbxAttendClass.Checked
            Case "Other" : Return cbxOther.Checked
            Case Else : Return False
        End Select
    End Function

    Private Function AnyFiltersChecked() As Boolean
        Return cbxPeople.Checked OrElse cbxFirstVisit.Checked OrElse
               cbxPrintFOR.Checked OrElse cbxIndexing.Checked OrElse
               cbxOnlineRsrch.Checked OrElse cbxSubWebsite.Checked OrElse
               cbxAttendClass.Checked OrElse cbxOther.Checked
    End Function

    Private Sub dtpStartDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartDate.ValueChanged
        If cboDateRange.SelectedItem.ToString() = "Monthly" Then
            SetMonthDates(dtpStartDate.Value)
        End If
        UpdateChart()
    End Sub

    Private Sub dtpEndDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndDate.ValueChanged
        UpdateChart()
    End Sub

    Private Sub SetMonthDates(selectedDate As DateTime)
        dtpStartDate.Value = New DateTime(selectedDate.Year, selectedDate.Month, 1)
        dtpEndDate.Value = dtpStartDate.Value.AddMonths(1).AddDays(-1)
    End Sub

    Private Sub cboDateRange_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDateRange.SelectedIndexChanged
        Select Case cboDateRange.SelectedItem.ToString()
            Case "Daily"
                dtpStartDate.Value = DateTime.Today
                dtpEndDate.Value = DateTime.Today
                dtpStartDate.Visible = True
                dtpEndDate.Visible = False
                lblStartDate.Visible = True
                lblEndDate.Visible = False

            Case "Weekly"
                dtpStartDate.Value = DateTime.Today.AddDays(-(CInt(DateTime.Today.DayOfWeek)))
                dtpEndDate.Value = dtpStartDate.Value.AddDays(6)
                dtpStartDate.Visible = True
                dtpEndDate.Visible = True
                lblStartDate.Visible = True
                lblEndDate.Visible = True

            Case "Monthly"
                SetMonthDates(DateTime.Today)
                dtpStartDate.Visible = True
                dtpEndDate.Visible = True
                lblStartDate.Visible = True
                lblEndDate.Visible = True

            Case "Custom"
                dtpStartDate.Visible = True
                dtpEndDate.Visible = True
                lblStartDate.Visible = True
                lblEndDate.Visible = True
        End Select

        UpdateChart()
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles _
            cbxPeople.CheckedChanged, cbxFirstVisit.CheckedChanged,
            cbxPrintFOR.CheckedChanged, cbxIndexing.CheckedChanged,
            cbxOnlineRsrch.CheckedChanged, cbxSubWebsite.CheckedChanged,
            cbxAttendClass.CheckedChanged, cbxOther.CheckedChanged
        UpdateChart()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboExport.SelectedIndex = -1 Then
            MessageBox.Show("Please select an export format.")
            Return
        End If

        Dim sfd As New SaveFileDialog()
        Select Case cboExport.SelectedItem.ToString()
            Case "Excel"
                sfd.Filter = "Excel Files|*.xlsx"
                sfd.DefaultExt = "xlsx"
            Case "CSV"
                sfd.Filter = "CSV Files|*.csv"
                sfd.DefaultExt = "csv"
            Case "PDF"
                sfd.Filter = "PDF Files|*.pdf"
                sfd.DefaultExt = "pdf"
        End Select

        If sfd.ShowDialog() = DialogResult.OK Then
            ExportData(sfd.FileName, cboExport.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            Try
                chartAttendance.Printing.PrintPreview()
            Catch ex As Exception
                MessageBox.Show("Error printing: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ExportData(fileName As String, format As String)
        Try
            ' Get data from database
            Dim query As String = "SELECT LogDate, LogTime, FirstVisit, PrintFOR, Indexing, " &
                                 "OnlineRsrch, SubWebsite, AttendClass, Other " &
                                 "FROM tblAttendance " &
                                 "WHERE LogDate BETWEEN @StartDate AND @EndDate" &
                                 BuildFilterQuery() &
                                 " ORDER BY LogDate, LogTime"

            Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
                Using cmd As New OleDbCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dtpStartDate.Value.Date)
                    cmd.Parameters.AddWithValue("@EndDate", dtpEndDate.Value.Date)

                    conn.Open()
                    Dim dt As New DataTable()
                    dt.Load(cmd.ExecuteReader())

                    Select Case format
                        Case "Excel"
                            ExportToExcel(dt, fileName)
                        Case "CSV"
                            ExportToCSV(dt, fileName)
                        Case "PDF"
                            ExportToPDF(dt, fileName)
                    End Select
                End Using
            End Using

            MessageBox.Show("Export completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error exporting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportToExcel(dt As DataTable, fileName As String)
        Dim excel As Object = CreateObject("Excel.Application")
        Try
            Dim workbook = excel.Workbooks.Add()
            Dim worksheet = workbook.Sheets(1)

            ' Add headers
            For col As Integer = 0 To dt.Columns.Count - 1
                worksheet.Cells(1, col + 1) = dt.Columns(col).ColumnName
            Next

            ' Add data
            For row As Integer = 0 To dt.Rows.Count - 1
                For col As Integer = 0 To dt.Columns.Count - 1
                    worksheet.Cells(row + 2, col + 1) = dt.Rows(row)(col)
                Next
            Next

            ' Save and close
            workbook.SaveAs(fileName)
            workbook.Close()
            excel.Quit()
        Finally
            ReleaseObject(excel)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ExportToCSV(dt As DataTable, fileName As String)
        Using sw As New StreamWriter(fileName)
            ' Write headers
            Dim headers = String.Join(",", dt.Columns.Cast(Of DataColumn).Select(Function(c) c.ColumnName))
            sw.WriteLine(headers)

            ' Write data rows
            For Each row As DataRow In dt.Rows
                Dim items = row.ItemArray.Select(Function(item) If(item Is Nothing, "", item.ToString()))
                sw.WriteLine(String.Join(",", items))
            Next
        End Using
    End Sub

    Private Sub ExportToPDF(dt As DataTable, fileName As String)
        Using fs As New FileStream(fileName, FileMode.Create)
            Using doc As New iTextSharp.text.Document()
                Dim writer = PdfWriter.GetInstance(doc, fs)
                doc.Open()

                ' Create table with specific number of columns
                Dim table As New PdfPTable(dt.Columns.Count)

                ' Add headers
                For Each column As DataColumn In dt.Columns
                    table.AddCell(New PdfPCell(New Phrase(column.ColumnName)))
                Next

                ' Add data
                For Each row As DataRow In dt.Rows
                    For Each item In row.ItemArray
                        table.AddCell(New PdfPCell(New Phrase(item.ToString())))
                    Next
                Next

                doc.Add(table)
                doc.Close()
            End Using
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
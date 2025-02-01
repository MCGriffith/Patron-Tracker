Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting
Imports Org.BouncyCastle.Tls


Public Class FrmAttendanceAnalytics
    Inherits Form
    Private printDocument As New PrintDocument()

    Private Enum ChartTypes
        BarChart
        LineChart
        PieChart
    End Enum

    Private Sub FrmAttendanceAnalytics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = CType(Application.OpenForms("FrmMain"), Form)

        ' Setup chart type combo box with friendly names
        cboChartType.Items.Clear()
        cboChartType.Items.Add("Bar Chart")
        cboChartType.Items.Add("Line Chart")
        cboChartType.Items.Add("Pie Chart")
        cboChartType.SelectedIndex = 0

        ' Setup ComboBox
        cboDateRange.Items.Clear()
        cboDateRange.Items.AddRange({"Daily", "Weekly", "Monthly", "Custom"})

        cboExport.Items.Clear()
        cboExport.Items.AddRange({"CSV", "Excel"})  ' Removed PDF

        ' Setup Chart - Modified version
        chartAttendance.ChartAreas.Clear()
        Dim mainArea As New ChartArea("MainArea")
        chartAttendance.ChartAreas.Add(mainArea)
        chartAttendance.Legends.Clear()
        chartAttendance.Legends.Add(New Legend("MainLegend"))
        mainArea.AxisY.IsReversed = False
        mainArea.AxisY.Minimum = 0

        ' Set initial selection
        cboDateRange.SelectedIndex = 0

        ' Configure chart axes
        With chartAttendance.ChartAreas("MainArea")
            .AxisX.Minimum = 0
            .AxisX.Maximum = 23
            .AxisX.Interval = 1
            .AxisX.MajorGrid.Enabled = True

            .AxisY.Minimum = 0
            .AxisY.MajorGrid.Enabled = True
            .AxisY.IsStartedFromZero = True
        End With
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


    Private ReadOnly SeriesColors As New Dictionary(Of String, Color) From {
        {"People", Color.Blue},
        {"FirstVisit", Color.Green},
        {"PrintFOR", Color.Red},
        {"Indexing", Color.Purple},
        {"OnlineRsrch", Color.Orange},
        {"SubWebsite", Color.Brown},
        {"AttendClass", Color.Magenta},
        {"Other", Color.Gray}
    }

    'Private Sub UpdateChart()
    '    ' Modified query to handle multiple filters correctly
    '    Dim query As String = "SELECT LogDate, Format([LogTime],'HH') as HourOfDay, " &
    '              "Sum(IIf([People]=True,1,0)) as PeopleCount, " &
    '              "Sum(IIf([FirstVisit]=True,1,0)) as FirstVisitCount, " &
    '              "Sum(IIf([PrintFOR]=True,1,0)) as PrintFORCount, " &
    '              "Sum(IIf([Indexing]=True,1,0)) as IndexingCount, " &
    '              "Sum(IIf([OnlineRsrch]=True,1,0)) as OnlineRsrchCount, " &
    '              "Sum(IIf([SubWebsite]=True,1,0)) as SubWebsiteCount, " &
    '              "Sum(IIf([AttendClass]=True,1,0)) as AttendClassCount, " &
    '              "Sum(IIf([Other]=True,1,0)) as OtherCount " &
    '              "FROM tblAttendance " &
    '              "WHERE LogDate BETWEEN #" & dtpStartDate.Value.ToString("MM/dd/yyyy") & "# " &
    '              "AND #" & dtpEndDate.Value.ToString("MM/dd/yyyy") & "#" &
    '              " GROUP BY LogDate, Format([LogTime],'HH') " &
    '              "ORDER BY Format([LogTime],'HH')"

    '    Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
    '        Using cmd As New OleDbCommand(query, conn)
    '            conn.Open()
    '            Dim dt As New DataTable()
    '            dt.Load(cmd.ExecuteReader())
    '            UpdateChartSeries(dt)
    '        End Using
    '    End Using
    'End Sub


    Private Sub UpdateChart()
        Dim sql As String = "SELECT LogDate, Format([LogTime],'HH') as HourOfDay, " &
        "COUNT(LoginID) as PeopleCount, " &
        "SUM(IIF(FirstVisit=True, 1, 0)) as FirstVisitCount, " &
        "SUM(IIF(PrintFOR=True, 1, 0)) as PrintFORCount, " &
        "SUM(IIF(Indexing=True, 1, 0)) as IndexingCount, " &
        "SUM(IIF(OnlineRsrch=True, 1, 0)) as OnlineRsrchCount, " &
        "SUM(IIF(SubWebsite=True, 1, 0)) as SubWebsiteCount, " &
        "SUM(IIF(AttendClass=True, 1, 0)) as AttendClassCount, " &
        "SUM(IIF(Other=True, 1, 0)) as OtherCount " &
        "FROM tblAttendance " &
        "WHERE LogDate BETWEEN #" & dtpStartDate.Value.ToString("MM/dd/yyyy") & "# " &
        "AND #" & dtpEndDate.Value.ToString("MM/dd/yyyy") & "# " &
        "GROUP BY LogDate, Format([LogTime],'HH') " &
        "ORDER BY LogDate, Format([LogTime],'HH')"

        Using conn As New OleDbConnection(DatabaseConfig.ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                conn.Open()
                Dim dt As New DataTable()
                dt.Load(cmd.ExecuteReader())
                UpdateChartSeries(dt)
            End Using
        End Using
    End Sub



    'Private Sub UpdateChartSeries(dt As DataTable)
    '    chartAttendance.Series.Clear()

    '    ' Convert friendly name to enum value
    '    Dim selectedChartType As ChartTypes
    '    Select Case cboChartType.SelectedItem.ToString()
    '        Case "Bar Chart"
    '            selectedChartType = ChartTypes.BarChart
    '        Case "Line Chart"
    '            selectedChartType = ChartTypes.LineChart
    '        Case "Pie Chart"
    '            selectedChartType = ChartTypes.PieChart
    '    End Select

    '    Select Case selectedChartType
    '        Case ChartTypes.BarChart
    '            ConfigureBarChart()
    '        Case ChartTypes.LineChart
    '            ConfigureLineChart()
    '        Case ChartTypes.PieChart
    '            ConfigurePieChart()
    '    End Select

    '    ' Get active series names
    '    Dim seriesNames() As String = {"People", "FirstVisit", "PrintFOR", "Indexing",
    '                      "OnlineRsrch", "SubWebsite", "AttendClass", "Other"}
    '    Dim activeSeriesNames = seriesNames.Where(Function(s) ShouldShowSeries(s)).ToArray()

    '    ' Create data dictionary
    '    Dim hourData As New Dictionary(Of Integer, Dictionary(Of String, Integer))
    '    For hour As Integer = 0 To 23
    '        hourData(hour) = New Dictionary(Of String, Integer)
    '        For Each seriesName In activeSeriesNames
    '            hourData(hour)(seriesName & "Count") = 0
    '        Next
    '    Next

    '    ' Fill data
    '    For Each row As DataRow In dt.Rows
    '        Dim hour As Integer
    '        If Integer.TryParse(row("HourOfDay").ToString(), hour) Then
    '            For Each seriesName In activeSeriesNames
    '                hourData(hour)(seriesName & "Count") = Convert.ToInt32(row(seriesName & "Count"))
    '            Next
    '        End If
    '    Next

    '    If selectedChartType = ChartTypes.PieChart Then
    '        ' Create a single series for pie chart
    '        Dim series As New Series("PieData")
    '        series.ChartType = SeriesChartType.Pie

    '        ' Create a dictionary to sum up totals for each category
    '        Dim categoryTotals As New Dictionary(Of String, Integer)

    '        ' Sum up all hours for each category
    '        For hour As Integer = 0 To 23
    '            For Each seriesName In activeSeriesNames
    '                If Not categoryTotals.ContainsKey(seriesName) Then
    '                    categoryTotals(seriesName) = 0
    '                End If
    '                categoryTotals(seriesName) += hourData(hour)(seriesName & "Count")
    '            Next
    '        Next

    '        ' Add a single point for each category with its total
    '        For Each category In categoryTotals
    '            If category.Value > 0 Then
    '                Dim point = series.Points.Add(category.Value)
    '                point.Color = SeriesColors(category.Key)
    '                point.LegendText = category.Key
    '                point.Label = $"{category.Key}: {category.Value}"
    '            End If
    '        Next

    '        series("PieLabelStyle") = "Outside"
    '        series("PieLineColor") = "Black"
    '        chartAttendance.Series.Add(series)

    '    Else
    '        ' Handle Bar and Line charts
    '        For Each seriesName In activeSeriesNames
    '            Dim series As New Series(seriesName)
    '            series.Color = SeriesColors(seriesName)

    '            Select Case selectedChartType
    '                Case ChartTypes.BarChart
    '                    series.ChartType = SeriesChartType.Column
    '                Case ChartTypes.LineChart
    '                    series.ChartType = SeriesChartType.Line
    '                    series.BorderWidth = 2
    '            End Select

    '            series.IsVisibleInLegend = True
    '            chartAttendance.Series.Add(series)

    '            For hour As Integer = 0 To 23
    '                series.Points.AddXY(hour.ToString("00"), hourData(hour)(seriesName & "Count"))
    '            Next
    '        Next
    '    End If
    'End Sub

    Private Sub UpdateChartSeries(dt As DataTable)
        chartAttendance.Series.Clear()

        ' Get active series names based on checkbox selections
        Dim seriesNames() As String = {"People", "FirstVisit", "PrintFOR", "Indexing",
                      "OnlineRsrch", "SubWebsite", "AttendClass", "Other"}
        Dim activeSeriesNames = seriesNames.Where(Function(s) ShouldShowSeries(s)).ToArray()

        ' Create data dictionary for hourly counts
        Dim hourData As New Dictionary(Of Integer, Dictionary(Of String, Integer))
        For hour As Integer = 0 To 23
            hourData(hour) = New Dictionary(Of String, Integer)
            For Each seriesName In activeSeriesNames
                hourData(hour)(seriesName & "Count") = 0
            Next
        Next

        ' Fill data from database results
        For Each row As DataRow In dt.Rows
            Dim hour As Integer
            If Integer.TryParse(row("HourOfDay").ToString(), hour) Then
                For Each seriesName In activeSeriesNames
                    hourData(hour)(seriesName & "Count") = Convert.ToInt32(row(seriesName & "Count"))
                Next
            End If
        Next

        ' Create series based on chart type
        Select Case cboChartType.SelectedItem.ToString()
            Case "Pie Chart"
                CreatePieChartSeries(hourData, activeSeriesNames)
            Case "Bar Chart"
                CreateBarChartSeries(hourData, activeSeriesNames)
            Case "Line Chart"
                CreateLineChartSeries(hourData, activeSeriesNames)
        End Select
    End Sub


    'Private Sub ConfigureBarChart()
    '    If chartAttendance.ChartAreas.Count = 0 Then
    '        chartAttendance.ChartAreas.Add(New ChartArea("MainArea"))
    '    End If

    '    ' Position the chart area first
    '    With chartAttendance.ChartAreas(0)
    '        .Position.X = 5
    '        .Position.Y = 15
    '        .Position.Width = 75
    '        .Position.Height = 75

    '        .AxisX.Interval = 1
    '        .AxisX.LabelStyle.Format = "00"
    '        .AxisY.Minimum = 0
    '        .Area3DStyle.Enable3D = False

    '        ' Add axis titles
    '        .AxisX.Title = "Hours of the Day"
    '        .AxisX.TitleAlignment = StringAlignment.Center

    '        .AxisY.Title = "Activities"
    '        .AxisY.TitleAlignment = StringAlignment.Center
    '        .AxisY.TextOrientation = TextOrientation.Rotated270
    '    End With

    '    ' Configure Legend
    '    With chartAttendance.Legends(0)
    '        .Title = "Legend"
    '        .TitleAlignment = StringAlignment.Center
    '        .TitleSeparator = LegendSeparatorStyle.Line
    '        .Docking = Docking.Right
    '        .Position.Auto = True  ' This will ensure the legend is visible
    '        .IsDockedInsideChartArea = False  ' This keeps it outside the chart area
    '    End With

    '    ' Set Chart Title and Subtitle
    '    chartAttendance.Titles.Clear()

    '    ' Create and configure main title
    '    Dim mainTitle As New Title()
    '    mainTitle.Text = "Attendance"
    '    mainTitle.Font = New Font("Arial", 12, FontStyle.Bold)
    '    mainTitle.Alignment = ContentAlignment.TopCenter
    '    mainTitle.Position.X = 5
    '    mainTitle.Position.Y = 1
    '    mainTitle.Position.Width = 75
    '    chartAttendance.Titles.Add(mainTitle)

    '    ' Create and configure date range subtitle
    '    Dim dateRangeText As String
    '    If cboDateRange.SelectedItem IsNot Nothing Then
    '        If cboDateRange.SelectedItem.ToString() = "Daily" Then
    '            dateRangeText = dtpStartDate.Value.ToString("MMMM dd, yyyy")
    '        Else
    '            dateRangeText = $"{dtpStartDate.Value.ToString("MMMM dd, yyyy")} - {dtpEndDate.Value.ToString("MMMM dd, yyyy")}"
    '        End If
    '    Else
    '        dateRangeText = dtpStartDate.Value.ToString("MMMM dd, yyyy")
    '    End If

    '    Dim subTitle As New Title(dateRangeText)
    '    subTitle.Font = New Font("Arial", 10)
    '    subTitle.Alignment = ContentAlignment.TopCenter
    '    subTitle.Position.X = 5
    '    subTitle.Position.Y = 7  ' Increased Y position for better spacing from main title
    '    subTitle.Position.Width = 75
    '    chartAttendance.Titles.Add(subTitle)
    'End Sub



    'Private Sub ConfigureLineChart()
    '    If chartAttendance.ChartAreas.Count = 0 Then
    '        chartAttendance.ChartAreas.Add(New ChartArea("MainArea"))
    '    End If

    '    With chartAttendance.ChartAreas("MainArea")
    '        .AxisX.Interval = 1
    '        .AxisX.LabelStyle.Format = "00"
    '        .AxisY.Minimum = 0
    '        .Area3DStyle.Enable3D = False
    '    End With
    'End Sub

    'Private Sub ConfigurePieChart()
    '    If chartAttendance.ChartAreas.Count = 0 Then
    '        chartAttendance.ChartAreas.Add(New ChartArea("MainArea"))
    '    End If

    '    With chartAttendance.ChartAreas(0)
    '        .Position.X = 5
    '        .Position.Y = 15
    '        .Position.Width = 75
    '        .Position.Height = 75
    '        .Area3DStyle.Enable3D = True
    '        .Area3DStyle.Inclination = 45
    '    End With

    '    ' Configure Legend
    '    With chartAttendance.Legends(0)
    '        .Title = "Legend"
    '        .TitleAlignment = StringAlignment.Center
    '        .TitleSeparator = LegendSeparatorStyle.Line
    '        .Docking = Docking.Right
    '        .Position.Auto = True
    '        .IsDockedInsideChartArea = False
    '    End With

    '    ' Set Chart Title and Subtitle
    '    chartAttendance.Titles.Clear()

    '    ' Create and configure main title
    '    Dim mainTitle As New Title()
    '    mainTitle.Text = "Attendance"
    '    mainTitle.Font = New Font("Arial", 12, FontStyle.Bold)
    '    mainTitle.Alignment = ContentAlignment.TopCenter
    '    mainTitle.Position.X = 5
    '    mainTitle.Position.Y = 1
    '    mainTitle.Position.Width = 75
    '    chartAttendance.Titles.Add(mainTitle)

    '    ' Create and configure date range subtitle
    '    Dim dateRangeText As String
    '    If cboDateRange.SelectedItem IsNot Nothing Then
    '        If cboDateRange.SelectedItem.ToString() = "Daily" Then
    '            dateRangeText = dtpStartDate.Value.ToString("MMMM dd, yyyy")
    '        Else
    '            dateRangeText = $"{dtpStartDate.Value.ToString("MMMM dd, yyyy")} - {dtpEndDate.Value.ToString("MMMM dd, yyyy")}"
    '        End If
    '    Else
    '        dateRangeText = dtpStartDate.Value.ToString("MMMM dd, yyyy")
    '    End If

    '    Dim subTitle As New Title(dateRangeText)
    '    subTitle.Font = New Font("Arial", 10)
    '    subTitle.Alignment = ContentAlignment.TopCenter
    '    subTitle.Position.X = 5
    '    subTitle.Position.Y = 7
    '    subTitle.Position.Width = 75
    '    chartAttendance.Titles.Add(subTitle)
    'End Sub

    Private Sub CreatePieChartSeries(hourData As Dictionary(Of Integer, Dictionary(Of String, Integer)), activeSeriesNames As String())
        Dim series As New Series("PieData")
        series.ChartType = SeriesChartType.Pie

        ' Create category totals dictionary
        Dim categoryTotals As New Dictionary(Of String, Integer)

        ' Sum up all hours for each category
        For hour As Integer = 0 To 23
            For Each seriesName In activeSeriesNames
                If Not categoryTotals.ContainsKey(seriesName) Then
                    categoryTotals(seriesName) = 0
                End If
                categoryTotals(seriesName) += hourData(hour)(seriesName & "Count")
            Next
        Next

        ' Add data points for each category
        For Each category In categoryTotals
            If category.Value > 0 Then
                Dim point = series.Points.Add(category.Value)
                point.Color = SeriesColors(category.Key)
                point.LegendText = category.Key
                point.Label = $"{category.Key}: {category.Value}"
            End If
        Next

        series("PieLabelStyle") = "Outside"
        series("PieLineColor") = "Black"
        chartAttendance.Series.Add(series)
    End Sub

    Private Sub CreateBarChartSeries(hourData As Dictionary(Of Integer, Dictionary(Of String, Integer)), activeSeriesNames As String())
        For Each seriesName In activeSeriesNames
            Dim series As New Series(seriesName)
            series.ChartType = SeriesChartType.Column
            series.Color = SeriesColors(seriesName)
            series.IsVisibleInLegend = True

            For hour As Integer = 0 To 23
                series.Points.AddXY(hour.ToString("00"), hourData(hour)(seriesName & "Count"))
            Next

            chartAttendance.Series.Add(series)
        Next

        ' Configure axis labels
        With chartAttendance.ChartAreas(0)
            .AxisX.Title = "Hour of Day"
            .AxisY.Title = "Count"
            .AxisX.Interval = 1
            .AxisX.LabelStyle.Format = "00"
        End With
    End Sub

    Private Sub CreateLineChartSeries(hourData As Dictionary(Of Integer, Dictionary(Of String, Integer)), activeSeriesNames As String())
        For Each seriesName In activeSeriesNames
            Dim series As New Series(seriesName)
            series.ChartType = SeriesChartType.Line
            series.Color = SeriesColors(seriesName)
            series.BorderWidth = 2
            series.MarkerStyle = MarkerStyle.Circle
            series.MarkerSize = 8
            series.IsVisibleInLegend = True

            For hour As Integer = 0 To 23
                series.Points.AddXY(hour.ToString("00"), hourData(hour)(seriesName & "Count"))
            Next

            chartAttendance.Series.Add(series)
        Next

        ' Configure axis labels
        With chartAttendance.ChartAreas(0)
            .AxisX.Title = "Hour of Day"
            .AxisY.Title = "Count"
            .AxisX.Interval = 1
            .AxisX.LabelStyle.Format = "00"
        End With
    End Sub



    Private Sub cboChartType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChartType.SelectedIndexChanged
        UpdateChart()
    End Sub

    Private Function ShouldShowSeries(seriesName As String) As Boolean
        ' If no filters are checked, show all series
        If Not AnyFiltersChecked() Then Return True

        ' Match series name to corresponding checkbox
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

    Private Sub ExportData(fileName As String, format As String)
        Try
            ' Modified query to format date and time
            Dim query As String = "SELECT Format(LogDate, 'mm/dd/yyyy') as LogDate, " &
                             "Format(LogTime, 'HH:nn') as LogTime, " &
                             "FirstVisit, PrintFOR, Indexing, " &
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


    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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
        End Select

        sfd.OverwritePrompt = True

        If sfd.ShowDialog() = DialogResult.OK Then
            If File.Exists(sfd.FileName) Then
                File.Delete(sfd.FileName)
            End If
            ExportData(sfd.FileName, cboExport.SelectedItem.ToString())
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim sfd As New SaveFileDialog()
        sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|BMP Image|*.bmp"
        sfd.DefaultExt = "png"
        sfd.OverwritePrompt = True

        If sfd.ShowDialog() = DialogResult.OK Then
            Try
                Select Case Path.GetExtension(sfd.FileName).ToLower()
                    Case ".png"
                        chartAttendance.SaveImage(sfd.FileName, ChartImageFormat.Png)
                    Case ".jpg"
                        chartAttendance.SaveImage(sfd.FileName, ChartImageFormat.Jpeg)
                    Case ".bmp"
                        chartAttendance.SaveImage(sfd.FileName, ChartImageFormat.Bmp)
                End Select
                MessageBox.Show("Chart saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error saving chart: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            ' Create print dialog
            Dim printDialog As New PrintDialog()
            printDialog.Document = chartAttendance.Printing.PrintDocument

            ' Show print dialog
            If printDialog.ShowDialog() = DialogResult.OK Then
                chartAttendance.Printing.Print(False)  ' Added False parameter
            End If
        Catch ex As Exception
            MessageBox.Show("Error printing: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
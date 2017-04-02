Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Imports System.Globalization

Public Class frmreportTrialBalance
    Dim rds As ReportDataSource
    Dim rpt As New dsTrialBalanceMain
    Dim rds1 As ReportDataSource
    Dim rptincome As New dsIncomeStatement
    Dim rds2 As ReportDataSource
    Dim rpt2 As New dsOwnersStatement
    'Dim rds As ReportDataSource
    'Dim rpt As New dsTrialBalanceMain
    Private Sub frmreportTrialBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimePickerReport.Value = DateSerial(Year(DateTimePickerReport.Value), Month(DateTimePickerReport.Value) + 1, 0)
        ReportViewerTrialBalance.Visible = True
        ReportViewerIncome.Visible = False
        ReportViewerOwners.Visible = False
        frmMain.Bar1.Visible = False
        frmMain.DateTimePicker1.Visible = False
        ' IncomeFilterReport()

    End Sub


    'Public Sub reportControl()
    '    Dim filter As String
    '    'filter = Me.btnFilter.Text

    '    Select Case filter

    '        Case "Filter Trial Balance"
    '            trialBalanceFilterReport()
    '        Case "Filter Owner's Equity Statement"
    '            ownersEquityStatementFilterReport()

    '        Case "Filter Income Statement"
    '            incomeReportFilter()
    '        Case "Update Receipt[F5]"
    '            ' updateCash()
    '        Case "Update Journal[F5]"
    '            updateGeneral()
    '        Case "Update Customer[F5]"
    '            updateCustomer()
    '        Case "Update Chart of Account[F5]"
    '            updateAccount()
    '        Case "Update Supplier[F5]"
    '            updateSupplier()
    '        Case Else
    '    End Select
    ' End Sub

    Private Sub tileTrialBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tileTrialBalance.Click
        'btnFilter.Text = "Filter Trial Balance"
        ReportViewerTrialBalance.Visible = True
        ReportViewerOwners.Visible = False
        ReportViewerIncome.Visible = False
        'rptGroupPanel.Text = "Trial Balance"
        ReportViewerOwners.RefreshReport()
        trialBalanceFilterReport()

    End Sub

    Private Sub tileIncomeStatement_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tileIncomeStatement.Click
        'btnFilter.Text = "Filter Income Statement"
        'rptGroupPanel.Text = "Income Statement"
        ReportViewerIncome.Visible = True
        ReportViewerOwners.Visible = False
        ReportViewerTrialBalance.Visible = False
        incomeReportFilter()
    End Sub

    Private Sub tileOwners_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tileOwners.Click
        'btnFilter.Text = "Filter Owner's Equity Statement"
        'rptGroupPanel.Text = "Owner's Equity Statement"
        ReportViewerOwners.Visible = True
        ReportViewerTrialBalance.Visible = False
        ReportViewerIncome.Visible = False
        ownersEquityStatementFilterReport()
    End Sub

    Private Sub tileBalanceSheet_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tileBalanceSheet.Click
        'btnFilter.Text = "Filter Balance Sheet"
        'rptGroupPanel.Text = "Balance Sheet"
    End Sub

    Public Sub incomeReportFilter()
        Try
            Me.ReportViewerIncome.RefreshReport()
            '   Me.ReportViewer1.Reset()
            sdaa = New SqlDataAdapter("", con)
            Dim incomedatevalue = DateTimePickerReport.Value.ToString("MMMM dd, yyyy")
            'Dim dtpmonth = DateTimePicker1.Value.Month
            'Dim dtpyear = DateTimePicker1.Value.Year
            'Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
            'Dim months As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
            ' Dim datee = dtpmonth & " " + day & " " & dtpyear

            With sdaa.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Connection = con
                .CommandText = "filterIncome"
                .Parameters.Clear()
                .Parameters.Add("@date", SqlDbType.Date).Value = DateTimePickerReport.Value.ToString("MMMM dd, yyyy")
            End With
            rptincome.filterIncome.Reset()
            sdaa.Fill(rptincome.filterIncome)
            'rpt.rptProduct.Reset()
            ' mda.Fill(rpt.rptProduct)

            rds1 = New ReportDataSource("dataIncomeStatement", rptincome.Tables("filterIncome"))
            Dim incomedate As New ReportParameter("incomeDate", incomedatevalue)
            With Me.ReportViewerIncome
                Cursor = Cursors.WaitCursor
                .LocalReport.ReportEmbeddedResource = "AJEGLS.rdlcIncomeStatement.rdlc"
                .LocalReport.SetParameters(incomedate)
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(rds1)
                .SetDisplayMode(DisplayMode.PrintLayout)
                .ZoomPercent = 90
                .RefreshReport()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Public Sub trialBalanceFilterReport()
        Try
            Me.ReportViewerTrialBalance.RefreshReport()
            '   Me.ReportViewer1.Reset()
            sdaa = New SqlDataAdapter("", con)
            Dim dtpmonth = DateTimePickerReport.Value.Month
            Dim dtpyear = DateTimePickerReport.Value.Year
            Dim trialdate = DateTimePickerReport.Value.ToString("MMMM dd, yyyy")
            'Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
            'Dim months As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
            ' Dim datee = dtpmonth & " " + day & " " & dtpyear

            With sdaa.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Connection = con
                .CommandText = "filtertrialbalance"
                .Parameters.Clear()
                .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
                .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
            End With

            rpt.filtertrialbalance.Reset()
            sdaa.Fill(rpt.filtertrialbalance)
            Dim trialbalancedate As New ReportParameter("trialBalanceDate", trialdate)

            rds = New ReportDataSource("dsTrialBalance", rpt.Tables("filtertrialbalance"))
            With Me.ReportViewerTrialBalance
                Cursor = Cursors.WaitCursor
                .LocalReport.ReportEmbeddedResource = "AJEGLS.rdlcTrialBalance.rdlc"
                .LocalReport.SetParameters(trialbalancedate)
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(rds)
                .SetDisplayMode(DisplayMode.PrintLayout)
                .ZoomPercent = 90
                .RefreshReport()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub ownersEquityStatementFilterReport()
        Try
            Me.ReportViewerOwners.RefreshReport()
            '   Me.ReportViewer1.Reset()
            Dim ownersdate = DateTimePickerReport.Value.ToString("MMMM dd, yyyy")
            sdaa = New SqlDataAdapter("", con)
            With sdaa.SelectCommand
                .CommandType = CommandType.StoredProcedure
                '.Connection = con
                .CommandText = "filterOwnersStatement"
                .Parameters.Clear()
                .Parameters.Add("@date", SqlDbType.Date).Value = DateTimePickerReport.Value.ToString
            End With

            rpt2.filterOwnersStatement.Reset()
            sdaa.Fill(rpt2.filterOwnersStatement)
            Dim ownersEquityDate As New ReportParameter("ownersDate", ownersdate)
            rds2 = New ReportDataSource("dataOwnersStatement", rpt2.Tables("filterOwnersStatement"))

            With Me.ReportViewerOwners
                Cursor = Cursors.WaitCursor
                .LocalReport.ReportEmbeddedResource = "AJEGLS.rdlcOwnersEquity.rdlc"
                .LocalReport.DataSources.Clear()
                .LocalReport.DataSources.Add(rds2)
                .LocalReport.SetParameters(ownersEquityDate)
                .SetDisplayMode(DisplayMode.PrintLayout)
                .ZoomPercent = 90
                .RefreshReport()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub DateTimePickerReport_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePickerReport.ValueChanged
        DateTimePickerReport.Value = DateSerial(Year(DateTimePickerReport.Value), Month(DateTimePickerReport.Value) + 1, 0)
    End Sub
    Public Property strReport As String
    Public Sub IncomeFilterReport()
        Try

            Dim rptDataSource As ReportDataSource
            Dim strReport = "IncomeStatementReport"
            With ReportViewerTrialBalance.LocalReport
                .ReportPath = "Reports\" & strReport & ".rdlc"
                .DataSources.Clear()
            End With

            Select strReport
                Case "IncomeStatementReport"

                    Dim ds As New AJEGLS.JournalEntryDataSet

                    Dim da As New AJEGLS.JournalEntryDataSetTableAdapters.incomerevenueTableAdapter

                    ' Add the handler for the subreport
                    AddHandler ReportViewerTrialBalance.LocalReport.SubreportProcessing, AddressOf SubreportProcessingEvent

                    da.Fill(ds.incomerevenue)

                    ' Use the same name as defined in the report Data Source Definition
                    rptDataSource = New ReportDataSource("Revenue", ds.Tables("incomerevenue"))
            End Select

            ' ReportViewerTrialBalance.LocalReport.DataSources.Add(rptDataSource)

            ReportViewerTrialBalance.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Sub SubreportProcessingEvent(ByVal sender As Object, ByVal e As SubreportProcessingEventArgs)
        Try
            Dim ds As New AJEGLS.Expense
            Dim da As New AJEGLS.ExpenseTableAdapters.incomeexpenseTableAdapter

            da.Fill(ds.incomeexpense)

            e.DataSources.Add(New ReportDataSource("Expense", ds.Tables("incomeexpense")))
        Catch ex As Exception
            MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
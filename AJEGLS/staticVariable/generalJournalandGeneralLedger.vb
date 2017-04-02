Imports System.Data.SqlClient
Module generalJournalandGeneralLedger
    'Retrieve to General Journal Datagridview
    Public Sub retrieveGeneralJournaltoGeneralLedger()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Dim dtpmonth = frmLedger.dtpGeneralJournal.Value.Month
        Dim dtpyear = frmLedger.dtpGeneralJournal.Value.Year
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterGeneralJournaltoGeneralLedger"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
                .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)

            'Fill the DataGrid
            frmLedger.dgGeneralJournal.DataSource = dt

            'Hide the Column
            frmLedger.dgGeneralJournal.Columns(0).Visible = False
            frmLedger.dgGeneralJournal.Columns(1).Visible = False


            'Change the HeaderText
            frmLedger.dgGeneralJournal.Columns(2).HeaderText = "Particulars"
            'Resize the Width of Column
            frmLedger.dgGeneralJournal.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    'Retrieve Accounts
    Public Sub retrieveAccountstoGeneralLedger()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Dim dtpmonth = frmLedger.dtpGeneralJournal.Value.Month
        Dim dtpyear = frmLedger.dtpGeneralJournal.Value.Year

        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterLedger"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@chartname", SqlDbType.VarChar).Value = frmLedger.txtAccount.Text.Trim
                .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
                .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear

            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)

            'Fill the DataGrid
            frmLedger.dgGeneralLedger.DataSource = dt

            'Hide the Column
            'frmLedger.dgGeneralJournal.Columns(0).Visible = False
            'frmLedger.dgGeneralJournal.Columns(1).Visible = False
            frmLedger.dgGeneralLedger.Columns(4).Visible = False
            frmLedger.dgGeneralLedger.Columns(0).Visible = False
            frmLedger.dgGeneralLedger.Columns(1).Visible = False

            'Change the HeaderText
            frmLedger.dgGeneralLedger.Columns(0).HeaderText = "Month"
            frmLedger.dgGeneralLedger.Columns(1).HeaderText = "year"
            frmLedger.dgGeneralLedger.Columns(2).HeaderText = "Date"
            frmLedger.dgGeneralLedger.Columns(3).HeaderText = "Remarks"
            '  frmLedger.dgGeneralLedger.Columns(2).HeaderText = "Particulars"
            frmLedger.dgGeneralLedger.Columns(4).HeaderText = "Particulars"
            frmLedger.dgGeneralLedger.Columns(5).HeaderText = "Debit"
            frmLedger.dgGeneralLedger.Columns(6).HeaderText = "Credit"
            frmLedger.dgGeneralLedger.Columns(7).HeaderText = "Balance"
            'Resize the Width of Column
            ' frmLedger.dgGeneralJournal.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmLedger.dgGeneralLedger.Columns(2).Width = 150
            frmLedger.dgGeneralLedger.Columns(3).Width = 250
            frmLedger.dgGeneralLedger.Columns(5).Width = 150
            frmLedger.dgGeneralLedger.Columns(6).Width = 150
            frmLedger.dgGeneralLedger.Columns(7).Width = 150
            frmLedger.totalEndingBalance()
            frmLedger.pesoSign()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    'Pass Data to General Ledger to General Journal
    Public Sub generalLedgerPassData()
        Try

            With frmPurchase
                Dim cell0 As Object = frmLedger.dgGeneralJournal.Rows(frmLedger.dgGeneralJournal.CurrentRow.Index).Cells(0).Value
                Dim cell1 As Object = frmLedger.dgGeneralJournal.Rows(frmLedger.dgGeneralJournal.CurrentRow.Index).Cells(1).Value
                Dim cell2 As Object = frmLedger.dgGeneralJournal.Rows(frmLedger.dgGeneralJournal.CurrentRow.Index).Cells(2).Value

                frmLedger.txtAccount.Text = cell2
            End With
        Catch ex As Exception

        End Try
    End Sub


End Module

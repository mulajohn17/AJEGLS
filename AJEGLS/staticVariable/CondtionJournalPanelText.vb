Imports System.Data.SqlClient
Module CondtionJournalPanelText
    '--------------------------------------------------------------------------------------------------------------
    'Condition for SelectItem in Combobox
    Public Sub showSalesJournalText()
        If frmSpecialJournal.comboJournalType.Text = "Sales Journal" Then
            frmSpecialJournal.groupJournalPanel.Text = "Sales Journal"
            frmSpecialJournal.comboSupplier.Enabled = False
            frmSpecialJournal.comboSupplier.Text = ""
            frmSpecialJournal.comboCustomer.Enabled = True
            frmSpecialJournal.checkCustomer.Visible = False
            frmSpecialJournal.checkSupplier.Visible = False
            retrieveSalesJournal()
            salestotal()
            frmSpecialJournal.groupJournalPanel.Focus()

        ElseIf frmSpecialJournal.comboJournalType.Text = "Cash Receipt Journal" Then
            frmSpecialJournal.groupJournalPanel.Text = "Cash Receipt Journal"
            frmSpecialJournal.comboSupplier.Enabled = False
            frmSpecialJournal.comboSupplier.Text = ""
            frmSpecialJournal.comboCustomer.Enabled = True
            frmSpecialJournal.checkCustomer.Visible = False
            frmSpecialJournal.checkSupplier.Visible = False
            retrieveCashReceiptJournal()
            cashReceipttotal()
            frmSpecialJournal.groupJournalPanel.Focus()

        ElseIf frmSpecialJournal.comboJournalType.Text = "Disbursement Journal" Then
            frmSpecialJournal.groupJournalPanel.Text = "Disbursement Journal"
            frmSpecialJournal.comboCustomer.Enabled = False
            frmSpecialJournal.comboCustomer.Text = ""
            frmSpecialJournal.comboSupplier.Enabled = True
            frmSpecialJournal.checkCustomer.Visible = False
            frmSpecialJournal.checkSupplier.Visible = False
            retrieveDisbursementJournal()
            disbursementtotal()
            frmSpecialJournal.groupJournalPanel.Focus()

        ElseIf frmSpecialJournal.comboJournalType.Text = "Purchase Journal" Then
            frmSpecialJournal.groupJournalPanel.Text = "Purchase Journal"
            frmSpecialJournal.comboCustomer.Enabled = False
            frmSpecialJournal.comboCustomer.Text = ""
            frmSpecialJournal.comboSupplier.Enabled = True
            frmSpecialJournal.checkCustomer.Visible = False
            frmSpecialJournal.checkSupplier.Visible = False
            retrievePurchaseJournal()
            purchasetotal()
            frmSpecialJournal.groupJournalPanel.Focus()

        ElseIf frmSpecialJournal.comboJournalType.Text = "General Journal" Then
            frmSpecialJournal.groupJournalPanel.Text = "General Journal"
            frmSpecialJournal.comboCustomer.Enabled = True
            frmSpecialJournal.comboSupplier.Text = ""
            frmSpecialJournal.comboSupplier.Enabled = True
            frmSpecialJournal.checkCustomer.Visible = True
            frmSpecialJournal.checkSupplier.Visible = True
            retrieveGeneralJournal()
            generaltotal()
            frmSpecialJournal.groupJournalPanel.Focus()

        Else
            frmSpecialJournal.groupJournalPanel.Text = ""
            retrieveNullValues()

        End If
    End Sub

    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve Null Values in Datagridview

    Public Sub retrieveNullValues()
      

            'Change the HeaderText
            frmSpecialJournal.dgSpecialJournal.Columns(0).HeaderText = "Date"
            frmSpecialJournal.dgSpecialJournal.Columns(1).HeaderText = "Particulars"
            frmSpecialJournal.dgSpecialJournal.Columns(2).HeaderText = "Debit"
            frmSpecialJournal.dgSpecialJournal.Columns(3).HeaderText = "Credit"


            'Resize the Width of Column
            frmSpecialJournal.dgSpecialJournal.Columns(0).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmSpecialJournal.dgSpecialJournal.Columns(2).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(3).Width = 200


    End Sub
    '--------------------------------------------------------------------------------------------------------------;


    '--------------------------------------------------------------------------------------------------------------
    'Retrieve Purchase Journal

    Public Sub retrievePurchaseJournal()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrievePurchaseJournal"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)

            'Fill the DataGrid
            frmSpecialJournal.dgSpecialJournal.DataSource = dt
            'Hide the Column
            frmSpecialJournal.dgSpecialJournal.Columns(4).Visible = False
            'Journal Type
            frmSpecialJournal.dgSpecialJournal.Columns(5).Visible = False
            'fullname
            frmSpecialJournal.dgSpecialJournal.Columns(6).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(7).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(8).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(9).Visible = False

            'Change the HeaderText
            frmSpecialJournal.dgSpecialJournal.Columns(0).HeaderText = "Date"
            frmSpecialJournal.dgSpecialJournal.Columns(1).HeaderText = "Particulars"
            frmSpecialJournal.dgSpecialJournal.Columns(2).HeaderText = "Debit"
            frmSpecialJournal.dgSpecialJournal.Columns(3).HeaderText = "Credit"


            'Resize the Width of Column
            frmSpecialJournal.dgSpecialJournal.Columns(0).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmSpecialJournal.dgSpecialJournal.Columns(2).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(3).Width = 200

            'Add Peso Sign on Column
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

           
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Total of Debit and Credit in Purchase Journal
    Public Sub purchasetotal()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            debit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(2).Value
        Next
        frmSpecialJournal.lbdebit.Text = debit

        If IsNumeric(frmSpecialJournal.lbdebit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbdebit.Text

            frmSpecialJournal.lbdebit.Text = "Ᵽ" & Format(temp, "N")

        End If

        Dim credit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            credit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(3).Value
        Next

        frmSpecialJournal.lbcredit.Text = credit

        If IsNumeric(frmSpecialJournal.lbcredit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbcredit.Text

            frmSpecialJournal.lbcredit.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve Disbursement Journal

    Public Sub retrieveDisbursementJournal()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveDisbursementJournal"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)

            'Fill the DataGrid
            frmSpecialJournal.dgSpecialJournal.DataSource = dt
            'Hide the Column
            frmSpecialJournal.dgSpecialJournal.Columns(4).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(5).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(6).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(7).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(8).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(9).Visible = False


            'Change the HeaderText
            frmSpecialJournal.dgSpecialJournal.Columns(0).HeaderText = "Date"
            frmSpecialJournal.dgSpecialJournal.Columns(1).HeaderText = "Particulars"
            frmSpecialJournal.dgSpecialJournal.Columns(2).HeaderText = "Debit"
            frmSpecialJournal.dgSpecialJournal.Columns(3).HeaderText = "Credit"


            'Resize the Width of Column
            frmSpecialJournal.dgSpecialJournal.Columns(0).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmSpecialJournal.dgSpecialJournal.Columns(2).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(3).Width = 200

            'Add Peso Sign on Column
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Total of Debit and Credit in Disbursement Journal
    Public Sub disbursementtotal()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            debit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(2).Value
        Next
        frmSpecialJournal.lbdebit.Text = debit

        If IsNumeric(frmSpecialJournal.lbdebit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbdebit.Text

            frmSpecialJournal.lbdebit.Text = "Ᵽ" & Format(temp, "N")

        End If

        Dim credit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            credit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(3).Value
        Next

        frmSpecialJournal.lbcredit.Text = credit

        If IsNumeric(frmSpecialJournal.lbcredit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbcredit.Text

            frmSpecialJournal.lbcredit.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve Cash Receipt Journal

    Public Sub retrieveCashReceiptJournal()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveCashReceiptJournal"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)

            'Fill the DataGrid
            frmSpecialJournal.dgSpecialJournal.DataSource = dt
            'Hide the Column
            frmSpecialJournal.dgSpecialJournal.Columns(4).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(5).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(6).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(7).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(8).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(9).Visible = False


            'Change the HeaderText
            frmSpecialJournal.dgSpecialJournal.Columns(0).HeaderText = "Date"
            frmSpecialJournal.dgSpecialJournal.Columns(1).HeaderText = "Particulars"
            frmSpecialJournal.dgSpecialJournal.Columns(2).HeaderText = "Debit"
            frmSpecialJournal.dgSpecialJournal.Columns(3).HeaderText = "Credit"


            'Resize the Width of Column
            frmSpecialJournal.dgSpecialJournal.Columns(0).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmSpecialJournal.dgSpecialJournal.Columns(2).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(3).Width = 200

            'Add Peso Sign on Column
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------;
    '--------------------------------------------------------------------------------------------------------------
    'Total of Debit and Credit in Cash Receipt Journal
    Public Sub cashReceipttotal()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            debit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(2).Value
        Next
        frmSpecialJournal.lbdebit.Text = debit

        If IsNumeric(frmSpecialJournal.lbdebit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbdebit.Text

            frmSpecialJournal.lbdebit.Text = "Ᵽ" & Format(temp, "N")

        End If

        Dim credit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            credit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(3).Value
        Next

        frmSpecialJournal.lbcredit.Text = credit

        If IsNumeric(frmSpecialJournal.lbcredit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbcredit.Text

            frmSpecialJournal.lbcredit.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve Sales Journal

    Public Sub retrieveSalesJournal()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveSalesJournal"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)

            'Fill the DataGrid
            frmSpecialJournal.dgSpecialJournal.DataSource = dt
            'Hide the Column
            frmSpecialJournal.dgSpecialJournal.Columns(4).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(5).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(6).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(7).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(8).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(9).Visible = False


            'Change the HeaderText
            frmSpecialJournal.dgSpecialJournal.Columns(0).HeaderText = "Date"
            frmSpecialJournal.dgSpecialJournal.Columns(1).HeaderText = "Particulars"
            frmSpecialJournal.dgSpecialJournal.Columns(2).HeaderText = "Debit"
            frmSpecialJournal.dgSpecialJournal.Columns(3).HeaderText = "Credit"


            'Resize the Width of Column
            frmSpecialJournal.dgSpecialJournal.Columns(0).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmSpecialJournal.dgSpecialJournal.Columns(2).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(3).Width = 200

            'Add Peso Sign on Column
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------;
    '--------------------------------------------------------------------------------------------------------------
    'Total of Debit and Credi in Sales Journal
    Public Sub salestotal()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            debit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(2).Value
        Next
        frmSpecialJournal.lbdebit.Text = debit

        If IsNumeric(frmSpecialJournal.lbdebit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbdebit.Text

            frmSpecialJournal.lbdebit.Text = "Ᵽ" & Format(temp, "N")

        End If

        Dim credit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            credit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(3).Value
        Next

        frmSpecialJournal.lbcredit.Text = credit

        If IsNumeric(frmSpecialJournal.lbcredit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbcredit.Text

            frmSpecialJournal.lbcredit.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve General Journal

    Public Sub retrieveGeneralJournal()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveGeneralJournal"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)

            'Fill the DataGrid
            frmSpecialJournal.dgSpecialJournal.DataSource = dt
            'Hide the Column
            frmSpecialJournal.dgSpecialJournal.Columns(4).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(5).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(6).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(7).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(8).Visible = False
            frmSpecialJournal.dgSpecialJournal.Columns(9).Visible = False


            'Change the HeaderText
            frmSpecialJournal.dgSpecialJournal.Columns(0).HeaderText = "Date"
            frmSpecialJournal.dgSpecialJournal.Columns(1).HeaderText = "Particulars"
            frmSpecialJournal.dgSpecialJournal.Columns(2).HeaderText = "Debit"
            frmSpecialJournal.dgSpecialJournal.Columns(3).HeaderText = "Credit"


            'Resize the Width of Column
            frmSpecialJournal.dgSpecialJournal.Columns(0).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            frmSpecialJournal.dgSpecialJournal.Columns(2).Width = 200
            frmSpecialJournal.dgSpecialJournal.Columns(3).Width = 200

            'Add Peso Sign on Column
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.Format = "C"
            frmSpecialJournal.dgSpecialJournal.Columns(2).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
            frmSpecialJournal.dgSpecialJournal.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    '--------------------------------------------------------------------------------------------------------------
    '--------------------------------------------------------------------------------------------------------------
    'Total of Debit and Credit in General Journal
    Public Sub generaltotal()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            debit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(2).Value
        Next
        frmSpecialJournal.lbdebit.Text = debit

        If IsNumeric(frmSpecialJournal.lbdebit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbdebit.Text

            frmSpecialJournal.lbdebit.Text = "Ᵽ" & Format(temp, "N")

        End If

        Dim credit As Decimal = 0.0
        For i As Decimal = 0.0 To frmSpecialJournal.dgSpecialJournal.RowCount - 1
            credit += frmSpecialJournal.dgSpecialJournal.Rows(i).Cells(3).Value
        Next

        frmSpecialJournal.lbcredit.Text = credit

        If IsNumeric(frmSpecialJournal.lbcredit.Text) Then

            Dim temp As Double = frmSpecialJournal.lbcredit.Text

            frmSpecialJournal.lbcredit.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Passing the data of special journal in datagridview
    Public Sub dataGridViewPassControl()
        Dim groupjournalpanel As String
        groupjournalpanel = frmSpecialJournal.groupJournalPanel.Text

        Select Case groupjournalpanel

            Case "Sales Journal"
                salesPassDatatoControls()
            Case "Purchase Journal"
                purchasePassDatatoControls()
            Case "Disbursement Journal"
                disbursementPassDatatoControls()
            Case "Cash Receipt Journal"
                cashReceipttPassDatatoControls()
            Case "General Journal"
                generalPassDatatoControls()
            Case Else
                MessageBox.Show("Undefine Data")
        End Select
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve Purchase from DataGridView to TextBox

    Public Sub purchasePassDatatoControls()
   
        With frmSpecialJournal
            Dim dateentry As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(0).Value
            Dim chartname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(1).Value
            Dim debit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(2).Value
            Dim credit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(3).Value
            Dim remarks As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(4).Value
            Dim journaltype As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(5).Value
            Dim fullname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(6).Value
            Dim companyname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(7).Value
            Dim chartype As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(8).Value
            Dim journalid As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(9).Value
            .dtp.Value = dateentry
            If debit.ToString = "0.00" Then
                .cbChart2.Text = chartname
                .cbChart1.ResetText()
                .cbChart1.Enabled = False
                .cbChart2.Enabled = True
                .txtDebit.Enabled = False
                .txtCredit.Enabled = True
                .cbDebit.Enabled = False
                .cbCredit.Enabled = True
                .cbCredit.Text = chartype
                .cbDebit.Text = ""

            Else
                .cbChart1.Text = chartname
                .cbChart2.ResetText()
                .cbChart1.Enabled = True
                .cbChart2.Enabled = False
                .txtCredit.Enabled = False
                .txtDebit.Enabled = True
                .cbDebit.Enabled = False
                .cbDebit.Enabled = True
                .cbDebit.Text = chartype
                .cbCredit.Text = ""
                .cbCredit.Enabled = False
            End If

            .txtDebit.Text = debit
            .txtCredit.Text = credit
            .txtRemarks.Text = remarks
            .txtJournalId.Text = journalid
            .comboSupplier.Text = companyname
            .comboJournalType.Text = journaltype
            'If frmSpecialJournal.txtJournalId.Text = Not Nothing Then
            '    frmMain.toolSaveRecord.Enabled = False
            '    frmMain.toolUpdateRecord.Enabled = True
            '    frmMain.toolCancel.Visible = False
            '    frmMain.toolAddRecord.Visible = True
            'End If
          
        End With
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve Sales from DataGridView to TextBox

    Public Sub salesPassDatatoControls()
        Try
            With frmSpecialJournal
                Dim dateentry As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(0).Value
                Dim chartname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(1).Value
                Dim debit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(2).Value
                Dim credit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(3).Value
                Dim remarks As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(4).Value
                Dim journaltype As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(5).Value
                Dim fullname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(6).Value
                Dim companyname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(7).Value
                Dim charttype As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(8).Value
                Dim journalid As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(9).Value
                .dtp.Value = dateentry
                'Credit will update
                If debit.ToString = "0.00" Then
                    .cbChart2.Text = chartname
                    .cbChart1.ResetText()
                    .cbChart1.Enabled = False
                    .cbChart2.Enabled = True
                    .txtDebit.Enabled = False
                    .txtCredit.Enabled = True

                    .cbCredit.Text = charttype
                    .cbDebit.Text = ""
                    .cbDebit.Enabled = False
                    .cbCredit.Enabled = True
                Else 'Debit will update
                    .cbChart1.Text = chartname
                    .cbChart2.ResetText()
                    .cbChart1.Enabled = True
                    .cbChart2.Enabled = False
                    .txtCredit.Enabled = False
                    .txtDebit.Enabled = True

                    .cbDebit.Text = charttype
                    .cbCredit.Text = ""
                    .cbCredit.Enabled = False
                    .cbDebit.Enabled = True
                End If

                .txtDebit.Text = debit
                .txtCredit.Text = credit
                .txtRemarks.Text = remarks
                .txtJournalId.Text = journalid
                .comboCustomer.Text = fullname
            End With
        Catch ex As Exception

        End Try
        
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve Disbursement from DataGridView to TextBox

    Public Sub disbursementPassDatatoControls()

        With frmSpecialJournal
            Dim dateentry As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(0).Value
            Dim chartname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(1).Value
            Dim debit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(2).Value
            Dim credit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(3).Value
            Dim remarks As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(4).Value
            Dim journaltype As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(5).Value
            Dim fullname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(6).Value
            Dim companyname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(7).Value
            Dim charttype As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(8).Value
            Dim journalid As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(9).Value
            .dtp.Value = dateentry
            'Credit will update
            If debit.ToString = "0.00" Then
                .cbChart2.Text = chartname
                .cbChart1.ResetText()
                .cbChart1.Enabled = False
                .cbChart2.Enabled = True
                .txtDebit.Enabled = False
                .txtCredit.Enabled = True

                .cbCredit.Text = charttype
                .cbDebit.Text = ""
                .cbDebit.Enabled = False
                .cbCredit.Enabled = True
            Else 'Debit will update
                .cbChart1.Text = chartname
                .cbChart2.ResetText()
                .cbChart1.Enabled = True
                .cbChart2.Enabled = False
                .txtCredit.Enabled = False
                .txtDebit.Enabled = True

                .cbDebit.Text = charttype
                .cbCredit.Text = ""
                .cbCredit.Enabled = False
                .cbDebit.Enabled = True
            End If

            .txtDebit.Text = debit
            .txtCredit.Text = credit
            .txtRemarks.Text = remarks
            .txtJournalId.Text = journalid
            .comboCustomer.Text = fullname
        End With
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve Cash Receipt from DataGridView to TextBox

    Public Sub cashReceipttPassDatatoControls()

        With frmSpecialJournal
            Dim dateentry As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(0).Value
            Dim chartname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(1).Value
            Dim debit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(2).Value
            Dim credit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(3).Value
            Dim remarks As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(4).Value
            Dim journaltype As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(5).Value
            Dim fullname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(6).Value
            Dim companyname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(7).Value
            Dim charttype As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(8).Value
            Dim journalid As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(9).Value
            .dtp.Value = dateentry
            'Credit will update
            If debit.ToString = "0.00" Then
                .cbChart2.Text = chartname
                .cbChart1.ResetText()
                .cbChart1.Enabled = False
                .cbChart2.Enabled = True
                .txtDebit.Enabled = False
                .txtCredit.Enabled = True

                .cbCredit.Text = charttype
                .cbDebit.Text = ""
                .cbDebit.Enabled = False
                .cbCredit.Enabled = True
            Else 'Debit will update
                .cbChart1.Text = chartname
                .cbChart2.ResetText()
                .cbChart1.Enabled = True
                .cbChart2.Enabled = False
                .txtCredit.Enabled = False
                .txtDebit.Enabled = True

                .cbDebit.Text = charttype
                .cbCredit.Text = ""
                .cbCredit.Enabled = False
                .cbDebit.Enabled = True
            End If

            .txtDebit.Text = debit
            .txtCredit.Text = credit
            .txtRemarks.Text = remarks
            .txtJournalId.Text = journalid
            .comboCustomer.Text = fullname
        End With
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieve General from DataGridView to TextBox

    Public Sub generalPassDatatoControls()

        With frmSpecialJournal
            Dim dateentry As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(0).Value
            Dim chartname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(1).Value
            Dim debit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(2).Value
            Dim credit As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(3).Value
            Dim remarks As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(4).Value
            Dim journaltypes As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(5).Value
            Dim fullname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(6).Value
            Dim companyname As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(7).Value
            Dim charttype As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(8).Value
            Dim journalid As Object = frmSpecialJournal.dgSpecialJournal.Rows(frmSpecialJournal.dgSpecialJournal.CurrentRow.Index).Cells(9).Value
            .dtp.Value = dateentry
            'Credit will update
            If debit.ToString = "0.00" Then
                .cbChart2.Text = chartname
                .cbChart1.ResetText()
                .cbChart1.Enabled = False
                .cbChart2.Enabled = True
                .txtDebit.Enabled = False
                .txtCredit.Enabled = True

                .cbCredit.Text = charttype
                .cbDebit.Text = ""
                .cbDebit.Enabled = False
                .cbCredit.Enabled = True
            Else 'Debit will update
                .cbChart1.Text = chartname
                .cbChart2.ResetText()
                .cbChart1.Enabled = True
                .cbChart2.Enabled = False
                .txtCredit.Enabled = False
                .txtDebit.Enabled = True

                .cbDebit.Text = charttype
                .cbCredit.Text = ""
                .cbCredit.Enabled = False
                .cbDebit.Enabled = True
            End If

            .txtDebit.Text = debit
            .txtCredit.Text = credit
            .txtRemarks.Text = remarks
            .txtJournalId.Text = journalid
            If fullname.ToString = "" Then
                .comboCustomer.Enabled = False
                .comboCustomer.Text = ""
            Else
                .comboCustomer.Text = fullname
                .comboCustomer.Enabled = True
            End If

            If companyname.ToString = "" Then
                .comboSupplier.Enabled = False
                .comboSupplier.Text = ""
            Else
                .comboSupplier.Text = companyname
                .comboSupplier.Enabled = True
            End If
            .comboJournalType.Text = journaltypes
        End With
    End Sub
    '--------------------------------------------------------------------------------------------------------------;
    '--------------------------------------------------------------------------------------------------------------
    Public Sub clearAllTextBox()
        'Clear all TextBox Control
        For Each ctrls As Control In frmSpecialJournal.controlPanel1.Controls
            If TypeOf ctrls Is TextBox Then
                ctrls.Text = ""
            End If
            If TypeOf ctrls Is ComboBox Then
                ctrls.Text = ""
            End If
        Next
        For Each ctrls As Control In frmSpecialJournal.controlPanel2.Controls
            If TypeOf ctrls Is TextBox Then
                ctrls.Text = ""
            End If
            If TypeOf ctrls Is ComboBox Then
                ctrls.Text = ""
            End If
        Next
        For Each ctrls As Control In frmSpecialJournal.controlPanel3.Controls
            If TypeOf ctrls Is TextBox Then
                ctrls.Text = ""
            End If
            If TypeOf ctrls Is ComboBox Then
                ctrls.Text = ""
            End If
            frmSpecialJournal.txtRemarks.Clear()
        Next
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Enable Controls
    Public Sub frmSpecialJournalControlEnable()
        With frmSpecialJournal
            .dtp.Enabled = True
            .txtDebit.Enabled = True
            .cbCredit.Enabled = True
            .cbChart1.Enabled = True
            .cbChart2.Enabled = True
            .cbCredit.Enabled = True
            .cbDebit.Enabled = True
            .txtRemarks.Enabled = True
            .comboSupplier.Enabled = True
            .comboCustomer.Enabled = True
            .txtCredit.Enabled = True
            .dgSpecialJournal.Enabled = True
            .comboJournalType.Enabled = True
            .comboJournalType.Focus()
        End With
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Disable Controls
    Public Sub frmSpecialJournalControlDisable()
        With frmSpecialJournal
            .dtp.Enabled = False
            .txtDebit.Enabled = False
            .cbCredit.Enabled = False
            .cbChart1.Enabled = False
            .cbChart2.Enabled = False
            .cbCredit.Enabled = False
            .cbDebit.Enabled = False
            .comboJournalType.Enabled = False
            .txtRemarks.Enabled = False
            .comboSupplier.Enabled = False
            .comboCustomer.Enabled = False
            .txtCredit.Enabled = False
            .dgSpecialJournal.Enabled = False
        End With
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieval of Second Debit Chart Type into Combobox
    Public Sub retrieveChartTypeforSpecialJournal()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveChartType"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)


            frmSpecialJournal.cbDebit.ValueMember = "typeid"
            frmSpecialJournal.cbDebit.DisplayMember = "charttype"
            frmSpecialJournal.cbDebit.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------------;

    '--------------------------------------------------------------------------------------------------------------
    'Retrieval of Second Credit Chart Type into Combobox
    Public Sub retrieveChartTypeforSpecialJournal2()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveChartType"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)


            frmSpecialJournal.cbCredit.ValueMember = "typeid"
            frmSpecialJournal.cbCredit.DisplayMember = "charttype"
            frmSpecialJournal.cbCredit.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    '--------------------------------------------------------------------------------------------------------------;
End Module

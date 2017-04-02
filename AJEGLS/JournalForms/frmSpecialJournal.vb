Imports System.Data.SqlClient
Public Class frmSpecialJournal

    Public Sub frmGeneralLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With con
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With

        'DataGridViewX1.Columns(2).DefaultCellStyle.Format = "C"
        'DataGridViewX1.Columns(3).DefaultCellStyle.Format = "C"
        'DataGridViewX1.Columns(2).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        'DataGridViewX1.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        ''  total()
        'DataGridViewX1.Columns(4).Visible = False
        'DataGridViewX1.Columns(5).Visible = False
        'DataGridViewX1.Columns(6).Visible = False
        'DataGridViewX1.Columns(7).Visible = False
        'GenerateID()
        If txtJournalId.Text Is Nothing Then
        Else
            frmMain.toolSaveRecord.Visible = False
            frmMain.toolUpdateRecord.Visible = True
            'frmMain.toolSaveRecord.Visible = False

        End If
        retrieveJournalType()
        retrieveSupplierName()
        retrieveCustomerName()
        retrieveChartTypeforSpecialJournal()
        retrieveChartTypeforSpecialJournal2()
        groupJournalPanel.Focus()
    End Sub

    Public Sub total()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To dgSpecialJournal.RowCount - 1
            debit += dgSpecialJournal.Rows(i).Cells(2).Value
        Next
        lbdebit.Text = debit

        If IsNumeric(lbdebit.Text) Then

            Dim temp As Double = lbdebit.Text

            lbdebit.Text = "Ᵽ" & Format(temp, "N")

        End If

        Dim credit As Decimal = 0.0
        For i As Decimal = 0.0 To dgSpecialJournal.RowCount - 1
            credit += dgSpecialJournal.Rows(i).Cells(3).Value
        Next

        lbcredit.Text = credit

        If IsNumeric(lbcredit.Text) Then

            Dim temp As Double = lbcredit.Text

            lbcredit.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub
    Public Sub GenerateID()

        Dim ar As String = "general-"
        Dim s As String
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "countgeneral"
            .Connection = con
            .Parameters.Clear()
        End With
        Dim result = cmd.ExecuteScalar

        'Dim calculateResult As Integer = 0
        s = ar & Val(result)
        '   txtGeneralId.Text = s

    End Sub

    Private Sub cbDebit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDebit.SelectedIndexChanged
        cbtypepasschartname()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub cbCredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCredit.SelectedIndexChanged
        cbtypepasschartname1()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub cbtypepasschartname1()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterchart"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@charttype", SqlDbType.VarChar).Value = cbCredit.Text
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
            'adapter.Dispose()
            'cmd.Dispose()
            'con.Close()


            cbChart2.ValueMember = "chartId"
            cbChart2.DisplayMember = "chartname"
            cbChart2.DataSource = dt
           
            'ComboBox1.DisplayMember = "chartname"
            'ComboBox1.ValueMember = "chartId"
            'ComboBox1.DataSource = dt



        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cbtypepasschartname()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterchart"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@charttype", SqlDbType.VarChar).Value = cbDebit.Text
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)


            cbChart1.ValueMember = "chartId"
            cbChart1.DisplayMember = "chartname"
            cbChart1.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub retrieveJournalType()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveJournalType"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)


            comboJournalType.ValueMember = "journalTypeId"
            comboJournalType.DisplayMember = "journalType"
            comboJournalType.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    'Public Sub retrieveSupplierName()
    '    Dim dt As New DataTable
    '    Dim ds As New DataSet()
    '    Dim adapter As New SqlDataAdapter()
    '    Try
    '        With cmd
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = "retrieveSupplier"
    '            .Connection = con
    '            .Parameters.Clear()
    '        End With
    '        adapter.SelectCommand = cmd
    '        adapter.Fill(dt)


    '        comboSupplier.ValueMember = "supplierID"
    '        comboSupplier.DisplayMember = "companyname"
    '        comboSupplier.DataSource = dt


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString)
    '    End Try
    'End Sub

    'Public Sub retrieveCustomerName()
    '    Dim dt As New DataTable
    '    Dim ds As New DataSet()
    '    Dim adapter As New SqlDataAdapter()
    '    Try
    '        With cmd
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = "retrieveCustomer"
    '            .Connection = con
    '            .Parameters.Clear()
    '        End With
    '        adapter.SelectCommand = cmd
    '        adapter.Fill(dt)


    '        comboCustomer.ValueMember = "customerId"
    '        comboCustomer.DisplayMember = "fullname"
    '        comboCustomer.DataSource = dt


    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString)
    '    End Try
    'End Sub

    Private Sub DataGridViewX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgSpecialJournal.Click
        dataGridViewPassControl()
        If txtJournalId.Text = "" Then
        Else
            frmMain.toolUpdateRecord.Visible = True
            frmMain.toolSaveRecord.Visible = False
            frmMain.toolCancel.Visible = False
            frmMain.toolAddRecord.Visible = True
        End If
    End Sub

    Private Sub DataGridViewX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgSpecialJournal.KeyDown, dgSpecialJournal.KeyUp
        dataGridViewPassControl()
        If txtJournalId.Text = "" Then
        Else
            frmMain.toolUpdateRecord.Visible = True
            frmMain.toolSaveRecord.Visible = False
            frmMain.toolCancel.Visible = False
            frmMain.toolAddRecord.Visible = True
        End If
    End Sub

    Private Sub txtDebit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress, txtCredit.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtDebit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDebit.LostFocus
        If txtJournalId.Text = "" Then
            txtCredit.Text = txtDebit.Text
        Else

        End If
    End Sub

    Private Sub txtDebit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebit.TextChanged
        If IsNumeric(txtDebit.Text) Then

            Dim temp As Double = txtDebit.Text

            txtDebit.Text = Format(temp, "N")

            txtDebit.SelectionStart = txtDebit.TextLength - 3
        End If
    End Sub

    Private Sub comboSupplier_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles comboSupplier.KeyPress, comboCustomer.KeyPress, cbChart2.KeyPress, cbChart1.KeyPress, cbCredit.KeyPress, cbDebit.KeyPress, comboJournalType.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub dtp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtRemarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub txtCredit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCredit.TextChanged
        If IsNumeric(txtCredit.Text) Then

            Dim temp As Double = txtCredit.Text

            txtCredit.Text = Format(temp, "N")

            txtCredit.SelectionStart = txtCredit.TextLength - 3
        End If
    End Sub

    Private Sub comboJournalType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboJournalType.SelectedIndexChanged
        showSalesJournalText()
    End Sub

    Private Sub comboSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboSupplier.SelectedIndexChanged
        
    End Sub

    Private Sub comboCustomer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboCustomer.SelectedIndexChanged
    End Sub


    Private Sub checkSupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkSupplier.CheckedChanged
        If checkSupplier.Checked = True Then
            checkCustomer.Enabled = False
            comboCustomer.Enabled = False
            comboCustomer.Text = ""

            comboSupplier.Enabled = True
        Else
            checkCustomer.Enabled = True
            comboCustomer.Enabled = True

            comboSupplier.Enabled = True
        End If

    End Sub

    Private Sub checkCustomer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCustomer.CheckedChanged
        If checkCustomer.Checked = True Then
            checkSupplier.Enabled = False
            comboSupplier.Enabled = False
            comboSupplier.Text = ""

            comboCustomer.Enabled = True
        Else
            checkSupplier.Enabled = True
            comboSupplier.Enabled = True

            comboCustomer.Enabled = True
        End If
    End Sub

   
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmCustomer.txtCustomerId.Visible = False
        frmCustomer.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        frmSupplier.txtSupplierId.Visible = False
        frmSupplier.ShowDialog()
    End Sub
End Class
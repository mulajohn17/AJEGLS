Imports System.Data.SqlClient
Public Class frmDisbursement

    Public Sub frmDisbursement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RetrieveDisburse.disbursejournaltbl' table. You can move, or remove it, as needed.
        Me.DisbursejournaltblTableAdapter.FilldisburseJournal(Me.RetrieveDisburse.disbursejournaltbl)

        '  Me.DebitchartTableAdapter.Fill(Me.Credit.debitchart)
        With con
            If .State = ConnectionState.Closed Then
                .Open()
            End If
        End With

        Me.CustomertblTableAdapter.Fill(Me.CustomerLname.customertbl)
        DataGridViewX1.Columns(4).Visible = False
        DataGridViewX1.Columns(5).Visible = False
        DataGridViewX1.Columns(6).Visible = False
        DataGridViewX1.Columns(7).Visible = False
        DataGridViewX1.Columns(2).DefaultCellStyle.Format = "C"
        DataGridViewX1.Columns(3).DefaultCellStyle.Format = "C"
        DataGridViewX1.Columns(2).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        DataGridViewX1.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        total()
        customerautocomplete()
        ' GenerateID()
    End Sub

    Public Sub total()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To DataGridViewX1.RowCount - 1
            debit += DataGridViewX1.Rows(i).Cells(2).Value
        Next
        lbdebit.Text = debit

        If IsNumeric(lbdebit.Text) Then

            Dim temp As Double = lbdebit.Text

            lbdebit.Text = "Ᵽ" & Format(temp, "N")

        End If

        Dim credit As Decimal = 0.0
        For i As Decimal = 0.0 To DataGridViewX1.RowCount - 1
            credit += DataGridViewX1.Rows(i).Cells(3).Value
        Next

        lbcredit.Text = credit
        If IsNumeric(lbcredit.Text) Then

            Dim temp As Double = lbcredit.Text

            lbcredit.Text = "Ᵽ" & Format(temp, "N")

        End If


    End Sub
    Public Sub GenerateID()

        Dim ar As String = "disburse-"
        Dim s As String
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "countdisburse"
            .Connection = con
            .Parameters.Clear()
        End With
        Dim result = cmd.ExecuteScalar

        'Dim calculateResult As Integer = 0
        s = ar & Val(result)
        ' txtDisburseId.Text = s

    End Sub
    Private Sub cbDebit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDebit.SelectedIndexChanged
        cbDebit1()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub cbCredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCredit.SelectedIndexChanged
        cbCredit1()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub cbCredit1()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterchart"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@charttype", SqlDbType.Text).Value = cbCredit.SelectedItem.ToString
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
            'adapter.Dispose()
            'cmd.Dispose()
            'con.Close()


            cbAccount2.ValueMember = "chartId"
            cbAccount2.DisplayMember = "chartname"
            cbAccount2.DataSource = dt

            'ComboBox1.DisplayMember = "chartname"
            'ComboBox1.ValueMember = "chartId"
            'ComboBox1.DataSource = dt



        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cbDebit1()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterchart"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@charttype", SqlDbType.Text).Value = cbDebit.SelectedItem.ToString
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)
            'adapter.Dispose()
            'cmd.Dispose()
            'con.Close()


            cbChart1.ValueMember = "chartId"
            cbChart1.DisplayMember = "chartname"
            cbChart1.DataSource = dt
            'ComboBox1.DisplayMember = "chartname"
            'ComboBox1.ValueMember = "chartId"
            'ComboBox1.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub DataGridViewX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewX1.Click
        disburesPassData()
    End Sub

    Private Sub DataGridViewX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX1.KeyDown, DataGridViewX1.KeyUp
        disburesPassData()
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
        If txtDisburseId.Text = "" Then
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

    Private Sub comboCustomerDisburse_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles comboCustomerDisburse.KeyPress, cbAccount2.KeyPress, cbChart1.KeyPress, cbCredit.KeyPress, cbDebit.KeyPress
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

    Private Sub txtRemarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRemarks.KeyPress
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
End Class
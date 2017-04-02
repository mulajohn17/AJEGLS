Imports System.Data.SqlClient
Public Class frmSalesJournal

    Private Sub txtDebit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDebit.KeyPress, txtCredit.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

    End Sub

    Public Sub frmSalesJournal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesRetrieveData.salesjournaltbl' table. You can move, or remove it, as needed.
        Me.SalesjournaltblTableAdapter.Fillsalesjournal(Me.SalesRetrieveData.salesjournaltbl)
  
        With con
            If .State = ConnectionState.Closed Then
                .Open()
            End If

        End With
        DataGridViewX1.Columns(2).DefaultCellStyle.Format = "C"
        DataGridViewX1.Columns(3).DefaultCellStyle.Format = "C"

        DataGridViewX1.Columns(2).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        DataGridViewX1.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        total()
        '  GenerateID()
        Me.DataGridViewX1.Columns(4).Visible = False
        Me.DataGridViewX1.Columns(5).Visible = False
        Me.DataGridViewX1.Columns(6).Visible = False
        Me.DataGridViewX1.Columns(7).Visible = False
        customerautocomplete()

  

    End Sub

    Public Sub total()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To DataGridViewX1.RowCount - 1
            debit += DataGridViewX1.Rows(i).Cells(2).Value
        Next
        lbdebit.Text = debit

        'To Add Decimal on Debit Grand Total
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

    Public Sub UpdateBinding()
        For Each ctrl As Control In GroupPanel5.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.DataBindings.Clear()
                ctrl.Text = ""
            End If
        Next
    End Sub

    Private Sub frmSalesJournal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'If con.State = ConnectionState.Open Then
        '    con.Close()
        'End If
    End Sub

    Public Sub GenerateID()

        Dim ar As String = "sales-"
        Dim s As String
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "countid"
            .Connection = con
            .Parameters.Clear()
        End With
        Dim result = cmd.ExecuteScalar

        'Dim calculateResult As Integer = 0
        s = ar & Val(result)
        'txtSalesId.Text = s

    End Sub


    Private Sub frmSalesJournal_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If con.State = ConnectionState.Open Then
            con.Close()
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

    Private Sub cbChart1FilterCustomerType()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()

        Dim dt1 As New DataTable
        Dim ds1 As New DataSet()
        Dim adapter1 As New SqlDataAdapter()
        Try
            If cbChart1.Text = "Sales-Regular" Or cbAccount2.Text = "Sales-Regular" Then
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "filterCustomerTypebyRegular"
                    .Connection = con
                    .Parameters.Clear()

                End With
                adapter.SelectCommand = cmd
                adapter.Fill(dt)
                

                comboCustomerSales.ValueMember = "customerId"
                comboCustomerSales.DisplayMember = "fullname"
                comboCustomerSales.DataSource = dt
            ElseIf cbChart1.Text = "Sales-Shipment" Or cbAccount2.Text = "Sales-Shipment" Then
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "filterCustomerTypebyShipment"
                    .Connection = con
                    .Parameters.Clear()

                End With
                adapter1.SelectCommand = cmd
                adapter1.Fill(dt1)


                comboCustomerSales.ValueMember = "customerId"
                comboCustomerSales.DisplayMember = "fullname"
                comboCustomerSales.DataSource = dt1

                End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub


    Private Sub cbCredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCredit.SelectedIndexChanged
        cbCredit1()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub cbDebit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDebit.SelectedIndexChanged
        cbDebit1()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub txtDebit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDebit.LostFocus
        If txtSalesId.Text = "" Then
            txtCredit.Text = txtDebit.Text
        Else

        End If

    End Sub

    Private Sub txtDebit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDebit.TextChanged
        'Dim val As Decimal = txtDebit.Text
        'txtDebit.Text = val.ToString("###,###")
        ' txtDebit.SelectionStart = txtDebit.Text.IndexOf(",")
        If IsNumeric(txtDebit.Text) Then

            Dim temp As Double = txtDebit.Text

            txtDebit.Text = Format(temp, "N")

            txtDebit.SelectionStart = txtDebit.TextLength - 3
        End If
        'txtDebit.Text = txtCredit.Text
    End Sub

    Private Sub DataGridViewX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewX1.Click
        salesPassData()
    End Sub

    Private Sub DataGridViewX1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX1.KeyDown, DataGridViewX1.KeyUp
        salesPassData()
    End Sub

    Private Sub comboCustomerSales_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles comboCustomerSales.KeyPress, cbChart1.KeyPress, cbCredit.KeyPress, cbDebit.KeyPress, cbAccount2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
        e.Handled = True
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

    Private Sub DataGridViewX1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridViewX1.KeyPress
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

    Private Sub cbChart1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbChart1.SelectedIndexChanged
        cbChart1FilterCustomerType()
    End Sub

    Private Sub cbAccount2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAccount2.SelectedIndexChanged
        cbChart1FilterCustomerType()
    End Sub
End Class
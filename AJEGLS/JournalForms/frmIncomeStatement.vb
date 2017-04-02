Public Class frmIncomeStatement

    Private Sub frmIncomeStatement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RetreiveExpense.retrievexpense' table. You can move, or remove it, as needed.
        Me.RetrievexpenseTableAdapter.FillExpense(Me.RetreiveExpense.retrievexpense)
        'TODO: This line of code loads data into the 'RetrieveIncomeStatement.IncomeStatement' table. You can move, or remove it, as needed.
        Me.IncomeStatementTableAdapter.FillRevenue(Me.RetrieveIncomeStatement.IncomeStatement)
        'TODO: This line of code loads data into the 'RetreiveExpense.retrievexpense' table. You can move, or remove it, as needed.
        ' Me.RetrievexpenseTableAdapter.FillExpense(Me.RetreiveExpense.retrievexpense)
        'TODO: This line of code loads data into the 'RetrieveIncomeStatement.IncomeStatement' table. You can move, or remove it, as needed.
        'Me.IncomeStatementTableAdapter.FillRevenue(Me.RetrieveIncomeStatement.IncomeStatement)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
     
        ' Me.DataGridViewX1.Columns(4).Visible = False

        dgIncomeStatementRevenu.Columns(2).Visible = False
        dgIncomeStatementRevenu.Columns(3).Visible = False
        dgIncomeStatementRevenu.Columns(4).Visible = False

        dgIncomeStatementExpense.Columns(2).Visible = False
        dgIncomeStatementExpense.Columns(3).Visible = False
        dgIncomeStatementExpense.Columns(4).Visible = False
        filterIncomeDate()
        '  DataGridViewX2.Columns(0).Visible = False
        ' DataGridViewX2.Columns(5).Visible = False
        dgIncomeStatementRevenu.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgIncomeStatementRevenu.ColumnHeadersVisible = False
        dgIncomeStatementExpense.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgIncomeStatementExpense.ColumnHeadersVisible = False
        total()
        pesoSign()
        filteriIncomeStatementbyMonth()
        filteriIncomeStatementbyMonth1()
        frmIncomeStatementTemporaryLabelHide()

        dgIncomeStatementRevenu.Enabled = False
        dgIncomeStatementExpense.Enabled = False
    End Sub
    Public Sub total()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To dgIncomeStatementExpense.RowCount - 1
            debit += dgIncomeStatementExpense.Rows(i).Cells(1).Value
        Next
        lbdebit.Text = debit
        lbtempexpense.Text = debit
        If IsNumeric(lbdebit.Text) Then

            Dim temp As Double = lbdebit.Text

            lbdebit.Text = "Ᵽ" & Format(temp, "N")

        End If
        ' "Ᵽ"
        Dim credit As Decimal = 0.0
        For i As Decimal = 0.0 To dgIncomeStatementRevenu.RowCount - 1
            credit += dgIncomeStatementRevenu.Rows(i).Cells(1).Value
        Next

        lbcredit.Text = credit
        lbtemprevenue.Text = credit
        If IsNumeric(lbcredit.Text) Then

            Dim temp As Double = lbcredit.Text

            lbcredit.Text = "Ᵽ" & Format(temp, "N")

        End If

        Dim totalnetincome As Decimal = 0.0
        totalnetincome = credit - debit
        lbIncome.Text = totalnetincome
        lbtempneticome.Text = totalnetincome
        If IsNumeric(lbIncome.Text) Then

            Dim temp As Double = lbIncome.Text

            lbIncome.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub
    Public Sub pesoSign()
        dgIncomeStatementRevenu.Columns(1).DefaultCellStyle.Format = "C"
        dgIncomeStatementRevenu.Columns(1).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        dgIncomeStatementExpense.Columns(1).DefaultCellStyle.Format = "C"
        dgIncomeStatementExpense.Columns(1).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")



    End Sub
End Class
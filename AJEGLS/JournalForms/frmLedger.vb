Public Class frmLedger

    Private Sub frmLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpGeneralJournal.Value = DateSerial(Year(dtpGeneralJournal.Value), Month(dtpGeneralJournal.Value) + 1, 0)
    End Sub

    Private Sub dtpGeneralJournal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpGeneralJournal.ValueChanged
        retrieveGeneralJournaltoGeneralLedger()
        retrieveAccountstoGeneralLedger()
        dtpGeneralJournal.Value = DateSerial(Year(dtpGeneralJournal.Value), Month(dtpGeneralJournal.Value) + 1, 0)
    End Sub

    Private Sub dgGeneralJournal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGeneralJournal.Click
        generalLedgerPassData()
        retrieveAccountstoGeneralLedger()
    End Sub


    Private Sub dgGeneralJournal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgGeneralJournal.KeyDown, dgGeneralJournal.KeyUp
        generalLedgerPassData()
        retrieveAccountstoGeneralLedger()

    End Sub

    Public Sub totalEndingBalance()
        Dim debit As Decimal = 0.0
        Dim total As Double = "0.00"
        For i As Decimal = 0.0 To dgGeneralLedger.RowCount - 1
            debit += dgGeneralLedger.Rows(i).Cells(7).Value
        Next
        txtEndingBalanceTotal.Text = debit

        If IsNumeric(txtEndingBalanceTotal.Text) Then

            Dim temp As Double = txtEndingBalanceTotal.Text

            txtEndingBalanceTotal.Text = "Ᵽ" & Format(temp, "N")

        End If
        '  txtdebitgrandtotal.Text = "Ᵽ" & debit

    End Sub
    Public Sub pesoSign()
        dgGeneralLedger.Columns(5).DefaultCellStyle.Format = "C"
        dgGeneralLedger.Columns(5).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        dgGeneralLedger.Columns(6).DefaultCellStyle.Format = "C"
        dgGeneralLedger.Columns(6).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        dgGeneralLedger.Columns(7).DefaultCellStyle.Format = "C"
        dgGeneralLedger.Columns(7).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

    End Sub
End Class
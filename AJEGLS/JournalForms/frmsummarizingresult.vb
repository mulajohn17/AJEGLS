Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmsummarizingresult

    Private Sub frmsummarizingresult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalResultsummarize.__finalresultofsummarize' table. You can move, or remove it, as needed.
        Me._finalresultofsummarizeTableAdapter.FilltrialBalance(Me.FinalResultsummarize.__finalresultofsummarize)
        'TODO: This line of code loads data into the 'FinalResultsummarize.__finalresultofsummarize' table. You can move, or remove it, as needed.
        
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Me.DataGridViewX1.Columns(0).Visible = False
        Me.DataGridViewX1.Columns(1).Visible = False
        Me.DataGridViewX1.Columns(5).Visible = False
        total()
        DataGridViewX1.Columns(3).DefaultCellStyle.Format = "C"
        DataGridViewX1.Columns(4).DefaultCellStyle.Format = "C"

        DataGridViewX1.Columns(3).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        DataGridViewX1.Columns(4).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")
        filterTrialBalancebyMonth()
        DataGridViewX1.Enabled = False
    End Sub

    Public Sub total()
        Dim debit As Decimal = 0.0
        For i As Decimal = 0.0 To DataGridViewX1.RowCount - 1
            debit += DataGridViewX1.Rows(i).Cells(3).Value
        Next
        lbdebit.Text = debit

        If IsNumeric(lbdebit.Text) Then

            Dim temp As Double = lbdebit.Text

            lbdebit.Text = "Ᵽ" & Format(temp, "N")

        End If
        Dim credit As Decimal = 0.0
        For i As Decimal = 0.0 To DataGridViewX1.RowCount - 1
            credit += DataGridViewX1.Rows(i).Cells(4).Value
        Next

        lbcredit.Text = credit

        If IsNumeric(lbcredit.Text) Then

            Dim temp As Double = lbcredit.Text

            lbcredit.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub

End Class
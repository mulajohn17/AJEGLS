Imports System.Data.SqlClient
Public Class frmSummarizingGeneral

    Public Sub frmSummarizingGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Journalsummarizeresult._journalsummarizeresult' table. You can move, or remove it, as needed.
        Me.JournalsummarizeresultTableAdapter.Fill(Me.Journalsummarizeresult._journalsummarizeresult)
        'TODO: This line of code loads data into the 'Journalsummarizeresult._journalsummarizeresult' table. You can move, or remove it, as needed.
        Me.JournalsummarizeresultTableAdapter.Fill(Me.Journalsummarizeresult._journalsummarizeresult)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'DataGridViewX2.Columns(0).Visible = False

        'saveupdate()
    End Sub

    Private Sub saveupdate()
        Dim dr As New System.Windows.Forms.DataGridViewRow

        For Each dr In DataGridViewX2.Rows
            Dim chartid As String = dr.Cells(0).Value
            Dim datee As String = dr.Cells(1).Value
            Dim particulars As String = dr.Cells(2).Value
            Dim debit As String = dr.Cells(3).Value
            Dim credit As String = dr.Cells(4).Value
            Dim balance As String = dr.Cells(5).Value

            Dim cm As New SqlCommand("select * from summarizinggltbl where chartId = @chartid and datee = @datee and particulars = @particulars and debit = @debit and credit = @credit and balance = @balance", con)
            '  cm.Parameters.AddWithValue("@summarizeid", "@summarizeid")
            cm.Parameters.AddWithValue("@chartid", chartid)
            cm.Parameters.AddWithValue("@datee", datee)
            cm.Parameters.AddWithValue("@particulars", particulars)
            cm.Parameters.AddWithValue("@debit", debit)
            cm.Parameters.AddWithValue("@credit", credit)
            cm.Parameters.AddWithValue("@balance", balance)
            ' frmSummarizingGeneral_Load(frmSummarizingGeneral, EventArgs.Empty)
            Dim da As New SqlDataAdapter(cm)
            Dim dtt As New DataTable
            da.Fill(dtt)
            If dtt.Rows.Count = 0 Then
                Dim cm2 As New SqlCommand("Insert into summarizinggltbl values(@chartid,@datee,@particulars,@debit,@credit,@balance)", con)
                cm2.Parameters.AddWithValue("@chartid", chartid)
                cm2.Parameters.AddWithValue("@datee", datee)
                cm2.Parameters.AddWithValue("@particulars", particulars)
                cm2.Parameters.AddWithValue("@debit", debit)
                cm2.Parameters.AddWithValue("@credit", credit)
                cm2.Parameters.AddWithValue("@balance", balance)
                cm2.ExecuteNonQuery()
                ' frmSummarizingGeneral.frmSummarizingGeneral_Load(frmSummarizingGeneral, EventArgs.Empty)
            Else
                Dim cm1 As New SqlCommand("UPDATE summarizinggltbl set chartId=@chartid,datee=@datee,particulars=@particulars,debit=@debit,credit=@credit,balance=@balance where chartId = @chartid and datee = @datee and particulars = @particulars and debit = @debit and credit = @credit and balance = @balance", con)
                '  cm1.Parameters.AddWithValue("@summarizeid", "@summarizeid")
                cm1.Parameters.AddWithValue("@chartid", chartid)
                cm1.Parameters.AddWithValue("@datee", datee)
                cm1.Parameters.AddWithValue("@particulars", particulars)
                cm1.Parameters.AddWithValue("@debit", debit)
                cm1.Parameters.AddWithValue("@credit", credit)
                cm1.Parameters.AddWithValue("@balance", balance)
                cm1.ExecuteNonQuery()
                ' frmSummarizingGeneral.frmSummarizingGeneral_Load(frmSummarizingGeneral, EventArgs.Empty)
            End If
            ' con.Close()

        Next
    End Sub
End Class
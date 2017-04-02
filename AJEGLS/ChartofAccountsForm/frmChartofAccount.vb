
Public Class frmChartofAccount

    Public Sub frmChartofAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Accountlist._accountlist' table. You can move, or remove it, as needed.
        Me.AccountlistTableAdapter.FillChartAccount(Me.Accountlist._accountlist)

        Me.DataGridViewX1.Columns(0).Visible = False
        retrieveChartStatus()
        retrieveChartType()
        AccountAutoComplete()
    End Sub

    Private Sub DataGridViewX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewX1.Click
        accountPassData1()
        If txtChartId.Text = "" Then
        Else
            frmMain.toolUpdateRecord.Visible = True
            frmMain.toolSaveRecord.Visible = False
            frmMain.toolCancel.Visible = False
            frmMain.toolAddRecord.Visible = True
        End If
    End Sub

    Private Sub DataGridViewX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX1.KeyDown, DataGridViewX1.KeyUp
        accountPassData1()
        If txtChartId.Text = "" Then
        Else
            frmMain.toolUpdateRecord.Visible = True
            frmMain.toolSaveRecord.Visible = False
            frmMain.toolCancel.Visible = False
            frmMain.toolAddRecord.Visible = True
        End If
    End Sub
End Class
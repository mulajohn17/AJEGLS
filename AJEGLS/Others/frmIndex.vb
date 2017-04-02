Public Class frmIndex

    'Private Sub btnSalesJournal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesJournal.Click
    '    Dim salejourna As New frmSalesJournal

    '    'salejourna.TopLevel = False
    '    'salejourna.TopMost = True
    '    'frmIndex = Application.OpenForms("frmSalesJournal"))
    '    'PanelEx1.Controls.Add(salejourna)
    '    frmSalesJournal.Show()
    'End Sub

    Private Sub MetroTileItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    'Public Sub DisplayForm(ByVal frm As Form, ByVal pnl As Panel)
    '    frm.Width = pnl.Width
    '    frm.Height = pnl.Height
    '    frm.TopLevel = False
    '    frm.Parent = pnl
    '    frm.Show()
    '    frm.BringToFront()

    'End Sub

    'Private Sub SideNavItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SideNavItem2.Click
    '    DisplayForm(frmSalesJournal, SideNavPanel1)
    '    frmSalesJournal.GenerateID()
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmSalesJournal.Show()
    End Sub
End Class
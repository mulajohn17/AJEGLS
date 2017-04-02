Module MainFormControl
    Public Sub Accountant()
        frmMain.AdministratorToolStripMenuItem.Visible = False
        frmMain.accountPanel.Visible = False
        frmMain.JournalToolStripMenuItem.Visible = True
        frmMain.ReportToolStripMenuItem.Visible = True
        frmMain.SummarizingToolStripMenuItem.Visible = True
        frmMain.GeneralLedgerToolStripMenuItem1.Visible = True
        frmMain.TrialBalanceToolStripMenuItem.Visible = True
        frmMain.MaintenanceToolStripMenuItem.Visible = True
        toolHide()
    End Sub
    Public Sub Administrator()
        frmMain.JournalToolStripMenuItem.Visible = False
        frmMain.ReportToolStripMenuItem.Visible = False
        frmMain.SummarizingToolStripMenuItem.Visible = False
        frmMain.AdministratorToolStripMenuItem.Visible = True
        frmMain.GeneralLedgerToolStripMenuItem1.Visible = False
        frmMain.TrialBalanceToolStripMenuItem.Visible = False
        frmMain.MaintenanceToolStripMenuItem.Visible = False
        frmMain.accountPanel.Visible = False
        toolHide()
    End Sub

    Public Sub Auditor()
        frmMain.JournalToolStripMenuItem.Visible = False
        frmMain.ReportToolStripMenuItem.Visible = True
        frmMain.SummarizingToolStripMenuItem.Visible = False
        frmMain.AdministratorToolStripMenuItem.Visible = False
        frmMain.GeneralLedgerToolStripMenuItem1.Visible = False
        frmMain.TrialBalanceToolStripMenuItem.Visible = False
        frmMain.MaintenanceToolStripMenuItem.Visible = False
        frmMain.accountPanel.Visible = False
        toolHide()
    End Sub

    Public Sub Logout()
        frmMain.MenuStrip1.Visible = False
        frmMain.ToolStrip1.Visible = False
        frmMain.accountPanel.Visible = True
    End Sub

    Public Sub MainForm()
        frmMain.MenuStrip1.Hide()
        frmMain.ToolStrip1.Hide()
    End Sub

    'Disable button of Main Form
    Public Sub moduleEnable()
        With frmMain
            .toolSaveRecord.Enabled = True
            .toolUpdateRecord.Enabled = True
            .toolSearchRecord.Enabled = True
            .toolChild.Enabled = True

            .JournalToolStripMenuItem.Enabled = True
            ' .PurchaseJournalToolStripMenuItem.Enabled = True

            .SummarizingToolStripMenuItem.Enabled = True
            .ReportToolStripMenuItem.Enabled = True
        End With

    End Sub

    Public Sub moduleDisable()
        With frmMain

            .JournalToolStripMenuItem.Enabled = False
            ' .PurchaseJournalToolStripMenuItem.Enabled = False
         
            .SummarizingToolStripMenuItem.Enabled = False
            .ReportToolStripMenuItem.Enabled = False


            .Timer1.Start()

        End With
        '; of disabling Button of Main Form
    End Sub

    Public Sub toolHide()
        frmMain.toolCancel.Visible = False
        frmMain.toolAddRecord.Visible = False
        frmMain.toolSaveRecord.Visible = False
        frmMain.toolUpdateRecord.Visible = False
        frmMain.toolSearchRecord.Visible = False
        frmMain.toolChild.Visible = False
    End Sub
End Module

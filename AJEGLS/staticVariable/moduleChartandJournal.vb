Module moduleChartandJournal

    'Disable textbox journal type in frmJournal Type
    Public Sub disableJournalType()
        frmJournalType.txtJournalType.Enabled = False
    End Sub

    'Enable textbox journal type in frmJournal Type
    Public Sub enableJournalType()
        frmJournalType.txtJournalType.Enabled = True
        frmJournalType.txtJournalType.Focus()
    End Sub
    'Clear textbox journal type in frmJournal Type
    Public Sub clearTextBoxInJounalType()
        frmJournalType.txtJournalType.Clear()
        frmJournalType.txtChartStatus.Clear()
        frmJournalType.txtChartType.Clear()
        frmJournalType.txtCustomerType.Clear()
    End Sub


    Public Sub hideJournaTypePanel()
        frmJournalType.journalGroupPanel.Visible = False
    End Sub

    Public Sub hideChartStatusandType()
        frmJournalType.chartGroupPanel.Visible = False
    End Sub

    Public Sub hidecustomerType()
        frmJournalType.customerTypePanel.Visible = False
    End Sub
    Public Sub ChangeTextonChartgroupPanel()
        If frmJournalType.checkChartStatus.Checked = True Then
            frmJournalType.chartGroupPanel.Text = "Account Status"
            frmJournalType.txtChartStatus.Enabled = True
            frmJournalType.checkChartStatus.Enabled = True
            frmJournalType.txtChartType.Enabled = False
            frmJournalType.checkChartType.Enabled = False

            frmMain.toolSaveRecord.Text = "Save Status[F4]"
            frmMain.toolAddRecord.Text = "New Status[F3]"
            frmMain.toolCancel.Text = "Cancel Status[Esc]"

            frmMain.toolAddRecord.Visible = False
            frmMain.toolCancel.Visible = True
            frmMain.toolSaveRecord.Visible = True
            frmJournalType.txtChartStatus.Focus()

        ElseIf frmJournalType.checkChartType.Checked = True Then
            frmJournalType.chartGroupPanel.Text = "Account Type"
            frmJournalType.txtChartType.Enabled = True
            frmJournalType.checkChartType.Enabled = True
            frmJournalType.txtChartStatus.Enabled = False
            frmJournalType.checkChartStatus.Enabled = False

            'Change the Text in Save Button
            frmMain.toolSaveRecord.Text = "Save Type[F4]"
            frmMain.toolAddRecord.Text = "New Type[F3]"
            frmMain.toolCancel.Text = "Cancel Type[Esc]"

            frmMain.toolAddRecord.Visible = False
            frmMain.toolCancel.Visible = True
            frmMain.toolSaveRecord.Visible = True
            frmJournalType.txtChartType.Focus()

        Else
            frmJournalType.chartGroupPanel.Text = "Account Status and Type"
            frmJournalType.txtChartStatus.Enabled = True
            frmJournalType.txtChartType.Enabled = True
            frmJournalType.checkChartStatus.Enabled = True
            frmJournalType.checkChartType.Enabled = True

            frmMain.toolSaveRecord.Text = "Save Status and Type[F4]"
            frmMain.toolAddRecord.Text = "New Status and Type[F3]"
            frmMain.toolCancel.Text = "Cancel Status and Type[Esc]"
            frmJournalType.txtChartType.Enabled = False
            frmJournalType.txtChartStatus.Enabled = False

        End If
        ' If frmJournalType.checkChartType.Checked = True And frmJournalType.checkChartStatus.Checked = True Then
    End Sub
End Module

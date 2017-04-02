Module mdiChildShow

    Public Sub showSpecialJournal()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Dispose()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmSpecialJournal
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            frmMain.toolAddRecord.Text = staticConfiguration.specialjournal
            frmMain.toolSaveRecord.Text = staticConfiguration.specialjournal1
            frmMain.toolUpdateRecord.Text = staticConfiguration.specialjournal2
            frmMain.toolCancel.Text = staticConfiguration.specialjournal3
            btnCRUDHide()
            frmSpecialJournalControlDisable()
            clearAllTextBox()
            frmSpecialJournal.txtJournalId.Visible = False
            frmMain.Bar1.Visible = True
            'frmIdHide()
            'frmSalesControlDisable()
            '' GenerateID()
        End With
    End Sub
    
    Public Sub showCustomer()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmCustomer
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            frmCustomer.btnLinkSave.Visible = False
            frmMain.toolAddRecord.Text = staticConfiguration.customer
            frmMain.toolUpdateRecord.Text = staticConfiguration.customerfrm1
            frmMain.toolSearchRecord.Text = staticConfiguration.customerfrm2
            frmMain.toolSaveRecord.Text = staticConfiguration.customerfrm3
            frmMain.toolCancel.Text = staticConfiguration.customerCancel
            btnCRUDHide()
            ' frmIdHide()
            frmCustomerControlDisable()
            frmMain.Bar1.Visible = True

        End With
    End Sub
    Public Sub showSupplier()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmSupplier
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            frmSupplier.btnLinkSave.Visible = False
            frmMain.toolAddRecord.Text = staticConfiguration.supplierfrm
            frmMain.toolUpdateRecord.Text = staticConfiguration.supplierfrm1
            frmMain.toolSearchRecord.Text = staticConfiguration.supplierfrm2
            frmMain.toolSaveRecord.Text = staticConfiguration.supplierfrm3
            frmMain.toolCancel.Text = staticConfiguration.supplierfrmCancel
            btnCRUDHide()
            frmIdHide()
            frmSupplierControlDisable()
            frmMain.Bar1.Visible = True
        End With
    End Sub

    Public Sub showSummarize()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmsummarizingresult
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            'toolUpdateRecord.Text = staticConfiguration.supplierfrm1
            'toolSearchRecord.Text = staticConfiguration.supplierfrm2
            'toolSaveRecord.Text = staticConfiguration.supplierfrm3
        End With
    End Sub

    Public Sub showAccount()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()

        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmChartofAccount
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            frmMain.toolAddRecord.Text = staticConfiguration.chartOfAccount
            frmMain.toolUpdateRecord.Text = staticConfiguration.chartOfAccount1
            frmMain.toolSearchRecord.Text = staticConfiguration.chartOfAccount2
            frmMain.toolSaveRecord.Text = staticConfiguration.chartOfAccount3
            frmMain.toolCancel.Text = staticConfiguration.chartOfAccountCancel
            btnCRUDHide()
            frmIdHide()
            frmAccountControlDisable()
            frmMain.Bar1.Visible = True
            clearchartofaccount()
        End With
    End Sub
    Public Sub showGeneral()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()

        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmSummarizingGeneral
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            frmMain.toolUpdateRecord.Text = staticConfiguration.jlSummarizing1
            frmMain.toolSearchRecord.Text = staticConfiguration.jlSummarizing2
            frmMain.toolSaveRecord.Text = staticConfiguration.jlSummarizing3
            btnCRUDShow()
            frmIdHide()
        End With
    End Sub

    Public Sub showTrialBalance()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmsummarizingresult
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            frmMain.toolAddRecord.Text = staticConfiguration.trialbalance
            frmMain.toolUpdateRecord.Text = staticConfiguration.tlSummarizing1
            frmMain.toolSearchRecord.Text = staticConfiguration.tlSummarizing2
            frmMain.toolSaveRecord.Text = staticConfiguration.tlSummarizing3
            frmMain.toolCancel.Text = staticConfiguration.trialbalanceCancel
            btnCRUDHide()
            frmIdHide()
            frmMain.dataPanel.Visible = True
            frmMain.DateTimePicker1.Visible = True
            frmMain.dataPanel.Location = New Point(1110, 33)
            'frmMain.DateTimePicker1.Location = New Point(1186, 36)

        End With
    End Sub


    Public Sub showIncomeStatement()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()

        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmIncomeStatement
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            frmMain.toolUpdateRecord.Text = staticConfiguration.income1
            frmMain.toolAddRecord.Text = staticConfiguration.income
            frmMain.toolSaveRecord.Text = staticConfiguration.income3
            frmMain.toolCancel.Text = staticConfiguration.incomeCancel
            btnCRUDHide()
            frmMain.dataPanel.Visible = True
            frmMain.DateTimePicker1.Visible = True
            frmMain.dataPanel.Location = New Point(1110, 33)
        End With
    End Sub

    Public Sub showOwners()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()

        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmOwners
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            'frmMain.toolUpdateRecord.Text = staticConfiguration.tlSummarizing1
            'frmMain.toolSearchRecord.Text = staticConfiguration.tlSummarizing2
            frmMain.toolAddRecord.Text = staticConfiguration.owner
            frmMain.toolSaveRecord.Text = staticConfiguration.owner3
            frmMain.toolCancel.Text = staticConfiguration.ownerCancel
            btnCRUDHide()
            frmMain.dataPanel.Visible = True
            frmMain.DateTimePicker1.Visible = True
            frmMain.dataPanel.Location = New Point(1110, 33)
        End With
    End Sub

    Public Sub showBalanceSheet()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmBalanceSheet
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            frmMain.toolAddRecord.Text = staticConfiguration.balancesheet
            frmMain.toolSaveRecord.Visible = False
            frmMain.toolSearchRecord.Visible = False
            frmMain.toolUpdateRecord.Visible = False
            frmMain.dataPanel.Visible = True
            frmMain.DateTimePicker1.Visible = True
            frmMain.dataPanel.Location = New Point(1110, 33)
        End With
    End Sub

    Public Sub showReportTrialBalance()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmreportTrialBalance
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            frmMain.DateTimePicker1.Visible = False
            frmMain.dataPanel.Visible = False
        End With
        ' frmMain.DateTimePicker1.Location = New Point(1186, 36)
    End Sub

    Public Sub showJournalType()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmJournalType
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            'frmMain.toolAddRecord.Text = staticConfiguration.journaltype
            'frmMain.toolSaveRecord.Text = staticConfiguration.journaltype1
            'frmMain.toolUpdateRecord.Text = staticConfiguration.journaltype2
            'frmMain.toolCancel.Text = staticConfiguration.journaltype3
            btnCRUDHide()
            disableJournalType()
            frmMain.toolSaveRecord.Text = "Save Journal Type[F4]"
            frmMain.toolAddRecord.Text = "New Journal Type[F3]"
            frmMain.toolCancel.Text = "Cancel Journal Type[Esc]"

        End With
    End Sub

    'Second Form
    Public Sub showChartStatusandType()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmJournalType
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            'frmMain.toolAddRecord.Text = staticConfiguration.journaltype
            'frmMain.toolSaveRecord.Text = staticConfiguration.journaltype1
            'frmMain.toolUpdateRecord.Text = staticConfiguration.journaltype2
            'frmMain.toolCancel.Text = staticConfiguration.journaltype3
            btnCRUDHide
            frmMain.toolSaveRecord.Text = "Save Status and Type[F4]"
            frmMain.toolAddRecord.Text = "New Status and Type[F3]"
            frmMain.toolCancel.Text = "Cancel Status and Type[Esc]"

            frmJournalType.txtChartType.Enabled = False
            frmJournalType.txtChartStatus.Enabled = False
        End With
    End Sub

    Public Sub showcustomerType()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmJournalType
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            'frmMain.toolAddRecord.Text = staticConfiguration.journaltype
            'frmMain.toolSaveRecord.Text = staticConfiguration.journaltype1
            'frmMain.toolUpdateRecord.Text = staticConfiguration.journaltype2
            'frmMain.toolCancel.Text = staticConfiguration.journaltype3
            btnCRUDHide()
            frmMain.toolSaveRecord.Text = "Save Customer Type[F4]"
            frmMain.toolAddRecord.Text = "New Customer Type[F3]"
            frmMain.toolCancel.Text = "Cancel Customer Type[Esc]"
            frmJournalType.txtCustomerType.Enabled = False
        End With
    End Sub

    Public Sub showGeneralLedger()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmLedger
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            'frmMain.toolAddRecord.Text = staticConfiguration.journaltype
            'frmMain.toolSaveRecord.Text = staticConfiguration.journaltype1
            'frmMain.toolUpdateRecord.Text = staticConfiguration.journaltype2
            'frmMain.toolCancel.Text = staticConfiguration.journaltype3
            'btnCRUDShow()
            frmMain.dataPanel.Visible = False
        End With
    End Sub
    'Show form Department
    Public Sub showDepartment()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmDepartment
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            btnCRUDHide()
            frmMain.toolSaveRecord.Text = "Save Department[F4]"
            frmMain.toolAddRecord.Text = "New Department[F3]"
            frmMain.toolCancel.Text = "Cancel Depatment[Esc]"

        End With
    End Sub
    'Show form Employee
    Public Sub showEmployee()
        'Focus the Form in Multiple Document Interface(MDI)
        For Each mainForm As Form In frmMain.MdiChildren
            If TypeOf mainForm Is frmMain Then
                mainForm.Focus()
                Return
            End If
        Next
        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In frmMain.MdiChildren
            child.Close()
        Next
        'Show the current click child form in Multiple Document Interface(MDI)
        With frmEmployee
            .MdiParent = frmMain
            .Dock = DockStyle.Fill
            .Show()
            btnCRUDHide()
            frmMain.toolSaveRecord.Text = "Save User[F4]"
            frmMain.toolAddRecord.Text = "New User[F3]"
            frmMain.toolCancel.Text = "Cancel User[Esc]"

        End With
    End Sub
End Module

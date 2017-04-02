Module btnControl
    'Disable Form Controls
    Public Sub frmCustomerControlDisable()
        With frmCustomer
            .txtCustomerId.Enabled = False
            .txtBarangay.Enabled = False
            .txtContact.Enabled = False
            .txtfname.Enabled = False
            .txtlname.Enabled = False
            .txtmname.Enabled = False
            .txtHouseNo.Enabled = False
            .checkPictures.Enabled = False
            .btnBrowse.Enabled = False
            .DataGridViewX1.Enabled = False
            .cbType.Enabled = False
            .txtMunicipality.Enabled = False
        End With
    End Sub
    Public Sub frmSupplierControlDisable()
        With frmSupplier
            .txtSupplierId.Enabled = False
            .txtPoblacion.Enabled = False
            .txtContact.Enabled = False
            .txtCompanyName.Enabled = False
            .txtCity.Enabled = False
            .txtBuildingNo.Enabled = False

            .DataGridViewX1.Enabled = False
            .checkLogo.Enabled = False
            .btnBrowse.Enabled = False
        End With
    End Sub
    Public Sub frmAccountControlDisable()
        With frmChartofAccount
            .txtChartName.Enabled = False
            .txtChartId.Enabled = False
            .cbChartStatus.Enabled = False
            .cbChartType.Enabled = False
            .DataGridViewX1.Enabled = False
        End With
    End Sub
    '; of Disabling of Controls

    'Enable of Controls

    Public Sub frmSalesControlEnable()
        With frmSalesJournal
            .dtp.Enabled = True
            .txtDebit.Enabled = True
            .cbCredit.Enabled = True
            .cbAccount2.Enabled = True
            .cbChart1.Enabled = True
            .cbCredit.Enabled = True
            .cbDebit.Enabled = True
            .txtRemarks.Enabled = True
            .comboCustomerSales.Enabled = True
            .txtCredit.Enabled = True
            .DataGridViewX1.Enabled = True
        End With
    End Sub
    Public Sub frmPurchaseControlEnable()
        With frmPurchase
            .dtp.Enabled = True
            .txtDebit.Enabled = True
            .cbCredit.Enabled = True
            .cbAccount2.Enabled = True
            .cbChart1.Enabled = True
            .cbCredit.Enabled = True
            .cbDebit.Enabled = True
            .txtRemarks.Enabled = True
            .comboSupplier.Enabled = True
            .txtCredit.Enabled = True
            .DataGridViewX1.Enabled = True
        End With
    End Sub
    Public Sub frmCashControlEnable()
        With frmCashReceipt
            .dtp.Enabled = True
            .txtDebit.Enabled = True
            .cbCredit.Enabled = True
            .cbAccount2.Enabled = True
            .cbChart1.Enabled = True
            .cbCredit.Enabled = True
            .cbDebit.Enabled = True
            .txtRemarks.Enabled = True
            .comboCustomerCash.Enabled = True
            .txtCredit.Enabled = True
            .DataGridViewX1.Enabled = True
        End With
    End Sub
    Public Sub frmDisburseControlEnable()
        With frmDisbursement
            .dtp.Enabled = True
            .txtDebit.Enabled = True
            .cbCredit.Enabled = True
            .cbAccount2.Enabled = True
            .cbChart1.Enabled = True
            .cbCredit.Enabled = True
            .cbDebit.Enabled = True
            .txtRemarks.Enabled = True
            .comboCustomerDisburse.Enabled = True
            .txtCredit.Enabled = True
            .DataGridViewX1.Enabled = True
        End With
    End Sub
    Public Sub frmGeneralControlEnable()
        With frmGeneralLedger
            .dtp.Enabled = True
            .txtDebit.Enabled = True
            .cbCredit.Enabled = True
            .cbAccount2.Enabled = True
            .cbChart1.Enabled = True
            .cbCredit.Enabled = True
            .cbDebit.Enabled = True
            .txtRemarks.Enabled = True
            .comboCustomerSales.Enabled = True
            .comboSupplier.Enabled = True
            .txtCredit.Enabled = True
            .DataGridViewX1.Enabled = True
        End With
    End Sub
    Public Sub frmCustomerControlEnable()
        With frmCustomer
            .txtBarangay.Enabled = True
            .txtContact.Enabled = True
            .txtfname.Enabled = True
            .txtlname.Enabled = True
            .txtmname.Enabled = True
            .txtHouseNo.Enabled = True
            .checkPictures.Enabled = True
            .btnBrowse.Enabled = True
            .DataGridViewX1.Enabled = True
            .cbType.Enabled = True
            .txtMunicipality.Enabled = True
        End With
    End Sub
    Public Sub frmSupplierControlEnable()
        With frmSupplier
            .txtPoblacion.Enabled = True
            .txtContact.Enabled = True
            .txtCompanyName.Enabled = True
            .txtCity.Enabled = True
            .txtBuildingNo.Enabled = True

            .DataGridViewX1.Enabled = True
            .checkLogo.Enabled = True
            .btnBrowse.Enabled = True
        End With
    End Sub
    Public Sub frmAccountControlEnable()
        With frmChartofAccount
            .txtChartName.Enabled = True
            .cbChartStatus.Enabled = True
            .cbChartType.Enabled = True
            .DataGridViewX1.Enabled = True
        End With
    End Sub


  

    'Private Sub purchaseControls()
    '    'Clear all TextBox Control
    '    For Each ctrls As Control In frmPurchase.txtGroupPanel.Controls
    '        If TypeOf ctrls Is TextBox Then
    '            ctrls.Text = ""
    '        End If
    '    Next
    'End Sub

    'To Clear combobox and Textbox


    'Private Sub cashControls()
    '    'Clear all TextBox Control
    '    For Each ctrls As Control In frmPurchase.txtGroupPanel.Controls
    '        If TypeOf ctrls Is TextBox Then
    '            ctrls.Text = ""
    '        End If
    '    Next
    'End Sub

    'Private Sub disburseControls()
    '    'Clear all TextBox Control
    '    For Each ctrls As Control In frmPurchase.txtGroupPanel.Controls
    '        If TypeOf ctrls Is TextBox Then
    '            ctrls.Text = ""
    '        End If
    '    Next
    'End Sub

    'Private Sub generalControls()
    '    'Clear all TextBox Control
    '    For Each ctrls As Control In frmPurchase.txtGroupPanel.Controls
    '        If TypeOf ctrls Is TextBox Then
    '            ctrls.Text = ""
    '        End If
    '    Next
    'End Sub

    Public Sub creditDebit()
        Dim saveRecord As String
        saveRecord = frmMain.toolSaveRecord.Text

        Select Case saveRecord

            Case "Save Sales[F4]"
                Dim sales As String = ".00"
                frmSalesJournal.txtDebit.Text = frmSalesJournal.txtDebit.Text & sales
                frmSalesJournal.txtCredit.Text = frmSalesJournal.txtDebit.Text
            Case "Save Purchase[F4]"
                frmPurchase.txtDebit.Text = frmPurchase.txtCredit.Text
            Case "Save Disbursement[F4]"
                frmDisbursement.txtDebit.Text = frmDisbursement.txtCredit.Text
            Case "Save Receipt[F4]"
                frmCashReceipt.txtDebit.Text = frmCashReceipt.txtCredit.Text
            Case "Save Journal[F4]"
                frmGeneralLedger.txtDebit.Text = frmGeneralLedger.txtCredit.Text
            Case Else
                MessageBox.Show("Undefine Data")
        End Select
    End Sub

    Public Sub EnableaddRecordControl()
        Dim addRecord As String
        addRecord = frmMain.toolAddRecord.Text

        Select Case addRecord

            Case "New Customer[F3]"


                frmMain.toolSaveRecord.Visible = True
                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                frmCustomerControlEnable()
                clearCustomerTextBox()
                frmCustomer.txtfname.Focus()

            Case "New Chart of Account[F3]"
                frmAccountControlEnable()
                frmMain.toolSaveRecord.Visible = True
                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                frmChartofAccount.txtChartName.Focus()
                clearchartofaccount()

            Case "New Supplier[F3]"
              
                frmSupplier.txtCompanyName.Focus()
                frmMain.toolSaveRecord.Visible = True
                frmMain.toolCancel.Visible = True
                frmMain.toolUpdateRecord.Visible = False
                frmMain.toolAddRecord.Visible = False
                frmSupplierControlEnable()
                clearSupplierTextBox()

            Case "New Income Statement[F3]"
                frmMain.toolSaveRecord.Visible = True
                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                frmOwners.GroupPanel3.Focus()
            Case "New Owner's Equity Statement[F3]"
                frmMain.toolSaveRecord.Visible = True
                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False

            Case "New Entry[F3]"
                clearAllTextBox()
                frmMain.toolSaveRecord.Visible = True

                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False

                frmSpecialJournalControlEnable()

            Case "New Journal Type[F3]"
                frmMain.toolSaveRecord.Visible = True

                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                enableJournalType()

            Case "New Status and Type[F3]"
                frmMain.toolSaveRecord.Visible = True

                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False

                frmJournalType.txtChartType.Enabled = True
                frmJournalType.txtChartStatus.Enabled = True
                frmJournalType.txtChartStatus.Focus()

            Case "New Customer Type[F3]"
                frmMain.toolSaveRecord.Visible = True

                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                frmJournalType.txtCustomerType.Enabled = True
                frmJournalType.txtCustomerType.Focus()

            Case "New Status[F3]"
                frmMain.toolSaveRecord.Visible = True

                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                frmJournalType.txtChartStatus.Enabled = True
                frmJournalType.txtChartStatus.Focus()

            Case "New Type[F3]"
                frmMain.toolSaveRecord.Visible = True

                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                frmJournalType.txtChartType.Enabled = True
                frmJournalType.txtChartType.Focus()

            Case "New Department[F3]"
                frmMain.toolSaveRecord.Visible = True

                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                frmDepartment.txtDepartment.Focus()

            Case "New User[F3]"
                frmMain.toolSaveRecord.Visible = True

                frmMain.toolCancel.Visible = True
                frmMain.toolAddRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                frmEmployee.txtfname.Focus()
            Case Else

        End Select
    End Sub

    'To Update Record 
    Public Sub updateRecordControl()
        Dim updateRecord As String
        updateRecord = frmMain.toolUpdateRecord.Text

        Select Case updateRecord

            Case "Update Sales[F5]"
                '  updateSales()
            Case "Update Purchase[F5]"
                ' updatePurchase()
            Case "Update Disbursement[F5]"
                ' updateDisburse()
            Case "Update Receipt[F5]"
                'updateCash()
            Case "Update Journal[F5]"
                '  updateGeneral()
            Case "Update Customer[F5]"
                updateCustomer()
            Case "Update Chart of Account[F5]"
                updateAccount()
            Case "Update Supplier[F5]"
                updateSupplier()
            Case Else
        End Select
    End Sub
    'Filter by Supplier AND CUSTOMER AND JOURNAL CATEGORY
    Public Sub searchRecordControl()
        Dim searchRecord As String
        searchRecord = frmMain.toolUpdateRecord.Text

        Select Case searchRecord

            Case "Update Sales[F5]"
                salesDataGridViewSearch()
                frmSalesJournal.total()
            Case "Update Purchase[F5]"
                purchaseDataGridViewSearch()
                frmPurchase.total()
            Case "Update Disbursement[F5]"
                DisburseDataGridViewSearch()
                frmDisbursement.total()
            Case "Update Receipt[F5]"
                CashDataGridViewSearch()
                frmCashReceipt.total()
            Case "Update Journal[F5]"
                generalDataGridViewSearch()
                frmGeneralLedger.total()
            Case "Update Customer[F5]"
                'customerautocomplete()
                searchCustomer()

            Case "Update Chart of Account[F5]"
                'updateAccount()
            Case "Update Supplier[F5]"
                searchSupplier()
            Case Else
                'MessageBox.Show("Undefine Data")
        End Select
    End Sub
    'FILTER BY MONTH AND YEAR IN 
    Public Sub filterDateRecordControl()
        Dim searchRecord As String
        searchRecord = frmMain.toolAddRecord.Text

        Select Case searchRecord

            Case "New Journal[F3]"
                generalDataGridViewSearch()
            Case "Trial Balance"
                filterTrialBalancebyMonth()

            Case "New Income Statement[F3]"
                filterIncomeDate()
                filteriIncomeStatementbyMonth()
                filteriIncomeStatementbyMonth1()
                frmIncomeStatement.total()
            Case "New Owner's Equity Statement[F3]"
                filterOwnersDate()
                filterOwnersWithdrawal()
                filterOwnersNetIncome()
            Case "Balance Sheet"
                filterBalanceSheetAsset()
                filterBalanceSheetLiabilities()
                filterBalanceSheetOwnerEquity()
                frmBalanceSheet.total()
            Case Else
                'MessageBox.Show("Undefine Data")
        End Select
    End Sub

   
    Public Sub cancelAddRecordControl()
        Dim cancelAddRecord As String
        cancelAddRecord = frmMain.toolSaveRecord.Text

        Select Case cancelAddRecord

            Case "Save Customer[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False
                frmCustomerControlDisable()
                clearCustomerTextBox()

            Case "Save Chart of Account[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False
                frmAccountControlDisable()

            Case "Save Supplier[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False
                frmSupplierControlDisable()
                clearSupplierTextBox()

            Case "Save Income Income Statement[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False

            Case "Save Owner's Equity Statement[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False

            Case "Save Entry[F4]"

                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False
                frmMain.toolUpdateRecord.Visible = False
                frmSpecialJournalControlDisable()

            Case "Save Journal Type[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False
                disableJournalType()
                clearTextBoxInJounalType()

            Case "Save Status and Type[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False
                frmJournalType.txtChartStatus.Enabled = False
                frmJournalType.txtChartType.Enabled = False
                ' disableJournalType()
                clearTextBoxInJounalType()

            Case "Save Status[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False
                frmJournalType.txtChartStatus.Enabled = False
                frmJournalType.checkChartStatus.Checked = False
                ' disableJournalType()
                clearTextBoxInJounalType()

            Case "Save Type[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False
                frmJournalType.txtChartType.Enabled = False
                frmJournalType.checkChartType.Checked = False
                ' disableJournalType()
                clearTextBoxInJounalType()

            Case "Save Customer Type[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False

                frmJournalType.txtCustomerType.Enabled = False
                ' disableJournalType()
                clearTextBoxInJounalType()

            Case "Save Department[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False

            Case "Save User[F4]"
                frmMain.toolAddRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolSaveRecord.Visible = False

            Case Else
                MessageBox.Show("Undefine Data")
        End Select
    End Sub

    Public Sub ownersdefault()
        With frmOwners
            .lbtempnetincome.Text = "0.00"
            .lbtemwithdrawal.Text = "0.00"
            .lbtemptotal.Text = "0.00"
            .lbtempendingcapital.Text = "0.00"

            .lbnetincome.Text = .lbtempnetincome.Text
            .lbwithdrawal.Text = .lbtemwithdrawal.Text
            .lbnetcapittotal.Text = .lbtemptotal.Text
            .lbendingcapital.Text = .lbtempendingcapital.Text
        End With
    End Sub
End Module

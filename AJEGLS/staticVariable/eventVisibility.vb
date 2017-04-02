Module eventVisibility
    Public Sub forBtnSave()
        frmMain.toolSaveRecord.Visible = False
        frmMain.toolAddRecord.Visible = True
        frmMain.toolCancel.Visible = False
    End Sub
    Public Sub frmIdHide()
        frmChartofAccount.txtChartId.Visible = False
        frmSupplier.txtSupplierId.Visible = False
        frmCustomer.txtCustomerId.Visible = False
    End Sub
    Public Sub btnCRUDHide()
        frmMain.toolAddRecord.Visible = True
        frmMain.toolChild.Visible = True
        frmMain.toolSaveRecord.Visible = False
        frmMain.toolUpdateRecord.Visible = False
        frmMain.toolSearchRecord.Visible = False
        frmMain.toolCancel.Visible = False
        frmMain.Bar1.Visible = False
        frmMain.dataPanel.Visible = False
    End Sub
    Public Sub btnCRUDShow()
        frmMain.toolAddRecord.Visible = True
        frmMain.toolSaveRecord.Visible = True
        frmMain.toolUpdateRecord.Visible = True
        frmMain.toolSearchRecord.Visible = False
        frmMain.toolChild.Visible = True
        frmMain.toolCancel.Visible = False
        frmMain.DateTimePicker1.Visible = True
        frmMain.Bar1.Visible = True
    End Sub

    Public Sub formCloseCRUDHide()
        frmMain.toolAddRecord.Visible = False
        frmMain.toolSaveRecord.Visible = False
        frmMain.toolUpdateRecord.Visible = False
        frmMain.toolSearchRecord.Visible = False
        frmMain.toolChild.Visible = False
        frmMain.toolCancel.Visible = False
        frmMain.DateTimePicker1.Visible = False
        frmMain.Bar1.Visible = False
    End Sub
    Public Sub frmIncomeStatementTemporaryLabelHide()
        With frmIncomeStatement
            .lbtempexpense.Visible = False
            .lbtempneticome.Visible = False
            .lbtemprevenue.Visible = False

        End With
    End Sub
    Public Sub frmOwnersEquityTemporaryLabelHide()
        With frmOwners
            .lbtempnetincome.Visible = False
            .lbtempbcapital.Visible = False
            .lbtemptotal.Visible = False
            .lbtemwithdrawal.Visible = False
            .lbtempendingcapital.Visible = False
        End With
    End Sub
    'Main Form
    Public Sub btnCRUDHideMain()
        frmMain.toolAddRecord.Visible = False
        frmMain.toolChild.Visible = True
        frmMain.toolSaveRecord.Visible = False
        frmMain.toolUpdateRecord.Visible = False
        frmMain.toolSearchRecord.Visible = False
        frmMain.toolCancel.Visible = False
        frmMain.Bar1.Visible = False
        frmMain.dataPanel.Visible = False
    End Sub
End Module

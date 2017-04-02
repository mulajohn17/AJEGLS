Imports System.Data.SqlClient
Module fromDataGridtoTextBoxData
    Public Sub salesPassData()
        'Dim cell4 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(4).Value
        'Dim cell5 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(5).Value
        With frmSalesJournal
            Dim cell0 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(0).Value
            Dim cell1 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(1).Value
            Dim cell2 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(2).Value
            Dim cell3 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(3).Value
            Dim cell4 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(4).Value
            Dim cell5 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(5).Value
            Dim cell6 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(6).Value
            Dim cell7 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(7).Value
            .dtp.Value = cell0
            If cell3.ToString = "0.00" Then
                .cbChart1.Text = cell1
                .txtDebit.Enabled = True
                .cbAccount2.ResetText()
                .cbChart1.Enabled = True
                .cbAccount2.Enabled = False
                '
                .txtCredit.Enabled = False
                .cbDebit.Enabled = True
                .cbDebit.Text = cell7
                .cbCredit.Text = ""
                .cbCredit.Enabled = False
            Else
                .cbAccount2.Text = cell1
                .cbChart1.ResetText()
                .cbChart1.Enabled = False
                .cbAccount2.Enabled = True
                .txtDebit.Enabled = False
                '
                .txtCredit.Enabled = True
                .cbCredit.Enabled = True
                .cbCredit.Text = cell7
                .cbDebit.Text = ""
                .cbDebit.Enabled = False
                '.cbChart1.Text = cell1
                '.cbAccount2.ResetText()
                '.cbChart1.Enabled = True
                '.cbAccount2.Enabled = False
                '.txtCredit.Enabled = False
                '.txtDebit.Enabled = True
            End If

            .txtDebit.Text = cell2
            .txtCredit.Text = cell3
            .txtRemarks.Text = cell4
            .comboCustomerSales.Text = cell5
            .txtSalesId.Text = cell6

        End With
    End Sub
    'Purchase Journal PassData
    Public Sub purchasePassData()
        Try

            'Dim cell4 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(4).Value
            'Dim cell5 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(5).Value
            With frmPurchase
                Dim cell0 As Object = frmPurchase.DataGridViewX1.Rows(frmPurchase.DataGridViewX1.CurrentRow.Index).Cells(0).Value
                Dim cell1 As Object = frmPurchase.DataGridViewX1.Rows(frmPurchase.DataGridViewX1.CurrentRow.Index).Cells(1).Value
                Dim cell2 As Object = frmPurchase.DataGridViewX1.Rows(frmPurchase.DataGridViewX1.CurrentRow.Index).Cells(2).Value
                Dim cell3 As Object = frmPurchase.DataGridViewX1.Rows(frmPurchase.DataGridViewX1.CurrentRow.Index).Cells(3).Value
                Dim cell4 As Object = frmPurchase.DataGridViewX1.Rows(frmPurchase.DataGridViewX1.CurrentRow.Index).Cells(4).Value
                Dim cell5 As Object = frmPurchase.DataGridViewX1.Rows(frmPurchase.DataGridViewX1.CurrentRow.Index).Cells(5).Value
                Dim cell6 As Object = frmPurchase.DataGridViewX1.Rows(frmPurchase.DataGridViewX1.CurrentRow.Index).Cells(6).Value
                Dim cell7 As Object = frmPurchase.DataGridViewX1.Rows(frmPurchase.DataGridViewX1.CurrentRow.Index).Cells(7).Value
                .dtp.Value = cell0
                If cell2.ToString = "0.00" Then
                    .cbAccount2.Text = cell1
                    .cbChart1.ResetText()
                    .cbChart1.Enabled = False
                    .cbAccount2.Enabled = True
                    .txtDebit.Enabled = False
                    .txtCredit.Enabled = True
                    .cbDebit.Enabled = False
                    .cbCredit.Enabled = True
                    .cbCredit.Text = cell7
                    .cbDebit.Text = ""
       
                Else
                    .cbChart1.Text = cell1
                    .cbAccount2.ResetText()
                    .cbChart1.Enabled = True
                    .cbAccount2.Enabled = False
                    .txtCredit.Enabled = False
                    .txtDebit.Enabled = True
                    .cbDebit.Enabled = False
                    .cbDebit.Enabled = True
                    .cbDebit.Text = cell7
                    .cbCredit.Text = ""
                    .cbCredit.Enabled = False
                End If

                .txtDebit.Text = cell2
                .txtCredit.Text = cell3
                .txtRemarks.Text = cell4
                .txtPurchaseId.Text = cell6
                .comboSupplier.Text = cell5
            End With
        Catch ex As Exception

        End Try
    End Sub

    'Cash Receipt pass Data

    Public Sub cashPassData()
        Try

            'Dim cell4 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(4).Value
            'Dim cell5 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(5).Value
            With frmCashReceipt
                Dim cell0 As Object = frmCashReceipt.DataGridViewX1.Rows(frmCashReceipt.DataGridViewX1.CurrentRow.Index).Cells(0).Value
                Dim cell1 As Object = frmCashReceipt.DataGridViewX1.Rows(frmCashReceipt.DataGridViewX1.CurrentRow.Index).Cells(1).Value
                Dim cell2 As Object = frmCashReceipt.DataGridViewX1.Rows(frmCashReceipt.DataGridViewX1.CurrentRow.Index).Cells(2).Value
                Dim cell3 As Object = frmCashReceipt.DataGridViewX1.Rows(frmCashReceipt.DataGridViewX1.CurrentRow.Index).Cells(3).Value
                Dim cell4 As Object = frmCashReceipt.DataGridViewX1.Rows(frmCashReceipt.DataGridViewX1.CurrentRow.Index).Cells(4).Value
                Dim cell5 As Object = frmCashReceipt.DataGridViewX1.Rows(frmCashReceipt.DataGridViewX1.CurrentRow.Index).Cells(5).Value
                Dim cell6 As Object = frmCashReceipt.DataGridViewX1.Rows(frmCashReceipt.DataGridViewX1.CurrentRow.Index).Cells(6).Value
                Dim cell7 As Object = frmCashReceipt.DataGridViewX1.Rows(frmCashReceipt.DataGridViewX1.CurrentRow.Index).Cells(7).Value
                .dtp.Value = cell0
                'Credit will update
                If cell2.ToString = "0.00" Then
                    .cbAccount2.Text = cell1
                    .cbChart1.ResetText()
                    .cbChart1.Enabled = False
                    .cbAccount2.Enabled = True
                    .txtDebit.Enabled = False
                    .txtCredit.Enabled = True

                    .cbCredit.Text = cell7
                    .cbDebit.Text = ""
                    .cbDebit.Enabled = False
                    .cbCredit.Enabled = True
                Else 'Debit will update
                    .cbChart1.Text = cell1
                    .cbAccount2.ResetText()
                    .cbChart1.Enabled = True
                    .cbAccount2.Enabled = False
                    .txtCredit.Enabled = False
                    .txtDebit.Enabled = True

                    .cbDebit.Text = cell7
                    .cbCredit.Text = ""
                    .cbCredit.Enabled = False
                    .cbDebit.Enabled = True
                End If

                .txtDebit.Text = cell2
                .txtCredit.Text = cell3
                .txtRemarks.Text = cell4
                .txtCashId.Text = cell6
                .comboCustomerCash.Text = cell5
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub disburesPassData()
        Try

            'Dim cell4 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(4).Value
            'Dim cell5 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(5).Value
            With frmDisbursement
                Dim cell0 As Object = frmDisbursement.DataGridViewX1.Rows(frmDisbursement.DataGridViewX1.CurrentRow.Index).Cells(0).Value
                Dim cell1 As Object = frmDisbursement.DataGridViewX1.Rows(frmDisbursement.DataGridViewX1.CurrentRow.Index).Cells(1).Value
                Dim cell2 As Object = frmDisbursement.DataGridViewX1.Rows(frmDisbursement.DataGridViewX1.CurrentRow.Index).Cells(2).Value
                Dim cell3 As Object = frmDisbursement.DataGridViewX1.Rows(frmDisbursement.DataGridViewX1.CurrentRow.Index).Cells(3).Value
                Dim cell4 As Object = frmDisbursement.DataGridViewX1.Rows(frmDisbursement.DataGridViewX1.CurrentRow.Index).Cells(4).Value
                Dim cell5 As Object = frmDisbursement.DataGridViewX1.Rows(frmDisbursement.DataGridViewX1.CurrentRow.Index).Cells(5).Value
                Dim cell6 As Object = frmDisbursement.DataGridViewX1.Rows(frmDisbursement.DataGridViewX1.CurrentRow.Index).Cells(6).Value
                Dim cell7 As Object = frmDisbursement.DataGridViewX1.Rows(frmDisbursement.DataGridViewX1.CurrentRow.Index).Cells(7).Value
                .dtp.Value = cell0
                If cell2.ToString = "0.00" Then
                    .cbAccount2.Text = cell1
                    .cbChart1.ResetText()
                    .cbChart1.Enabled = False
                    .cbAccount2.Enabled = True
                    .txtDebit.Enabled = False
                    .txtCredit.Enabled = True

                    .cbCredit.Text = cell7
                    .cbDebit.Text = ""
                    .cbDebit.Enabled = False
                    .cbCredit.Enabled = True
                Else
                    .cbChart1.Text = cell1
                    .cbAccount2.ResetText()
                    .cbChart1.Enabled = True
                    .cbAccount2.Enabled = False
                    .txtCredit.Enabled = False
                    .txtDebit.Enabled = True

                    .cbDebit.Text = cell7
                    .cbCredit.Text = ""
                    .cbCredit.Enabled = False
                    .cbDebit.Enabled = True
                End If

                .txtDebit.Text = cell2
                .txtCredit.Text = cell3
                .txtRemarks.Text = cell4
                .txtDisburseId.Text = cell6
                .comboCustomerDisburse.Text = cell5
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub generalPassData()
        Try

            'Dim cell4 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(4).Value
            'Dim cell5 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(5).Value
            With frmGeneralLedger
                Dim cell0 As Object = frmGeneralLedger.DataGridViewX1.Rows(frmGeneralLedger.DataGridViewX1.CurrentRow.Index).Cells(0).Value
                Dim cell1 As Object = frmGeneralLedger.DataGridViewX1.Rows(frmGeneralLedger.DataGridViewX1.CurrentRow.Index).Cells(1).Value
                Dim cell2 As Object = frmGeneralLedger.DataGridViewX1.Rows(frmGeneralLedger.DataGridViewX1.CurrentRow.Index).Cells(2).Value
                Dim cell3 As Object = frmGeneralLedger.DataGridViewX1.Rows(frmGeneralLedger.DataGridViewX1.CurrentRow.Index).Cells(3).Value
                Dim cell4 As Object = frmGeneralLedger.DataGridViewX1.Rows(frmGeneralLedger.DataGridViewX1.CurrentRow.Index).Cells(4).Value
                Dim cell5 As Object = frmGeneralLedger.DataGridViewX1.Rows(frmGeneralLedger.DataGridViewX1.CurrentRow.Index).Cells(5).Value

                '  Dim cell6 As Object = frmGeneralLedger.DataGridViewX1.Rows(frmGeneralLedger.DataGridViewX1.CurrentRow.Index).Cells(6).Value
                .dtp.Value = cell0
                If cell2.ToString = "0.00" Then
                    .cbAccount2.Text = cell1
                    .cbChart1.ResetText()
                    .cbChart1.Enabled = False
                    .cbAccount2.Enabled = True
                    .txtDebit.Enabled = False
                    .txtCredit.Enabled = True
                Else
                    .cbChart1.Text = cell1
                    .cbAccount2.ResetText()
                    .cbChart1.Enabled = True
                    .cbAccount2.Enabled = False
                    .txtCredit.Enabled = False
                    .txtDebit.Enabled = True
                End If

                .txtDebit.Text = cell2
                .txtCredit.Text = cell3
                .txtRemarks.Text = cell4
                .txtJournalCategory.Text = cell5
                '.txtSalesId.Text = cell6
                '.comboCustomerSales.Text = cell5
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub accountPassData1()
        Try

            'Dim cell4 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(4).Value
            'Dim cell5 As Object = frmSalesJournal.DataGridViewX1.Rows(frmSalesJournal.DataGridViewX1.CurrentRow.Index).Cells(5).Value
            With frmChartofAccount
                Dim cell0 As Object = frmChartofAccount.DataGridViewX1.Rows(frmChartofAccount.DataGridViewX1.CurrentRow.Index).Cells(0).Value
                Dim cell1 As Object = frmChartofAccount.DataGridViewX1.Rows(frmChartofAccount.DataGridViewX1.CurrentRow.Index).Cells(1).Value
                Dim cell2 As Object = frmChartofAccount.DataGridViewX1.Rows(frmChartofAccount.DataGridViewX1.CurrentRow.Index).Cells(2).Value
                Dim cell3 As Object = frmChartofAccount.DataGridViewX1.Rows(frmChartofAccount.DataGridViewX1.CurrentRow.Index).Cells(3).Value

                .txtChartId.Text = cell0
                .txtChartName.Text = cell1
                .cbChartStatus.Text = cell2
                .cbChartType.Text = cell3
                '  Dim cell6 As Object = frmGeneralLedger.DataGridViewX1.Rows(frmGeneralLedger.DataGridViewX1.CurrentRow.Index).Cells(6).Value
                '.txtSalesId.Text = cell6
                '.comboCustomerSales.Text = cell5
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub customerPassData()
        Try
            With frmCustomer
                Dim cell0 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(0).Value
                Dim cell1 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(1).Value
                Dim cell2 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(2).Value
                Dim cell3 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(3).Value
                Dim cell4 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(4).Value
                Dim cell5 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(5).Value
                Dim cell6 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(6).Value
                Dim cell7 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(7).Value
                Dim cell8 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(8).Value
                Dim cell9 As Object = frmCustomer.DataGridViewX1.Rows(frmCustomer.DataGridViewX1.CurrentRow.Index).Cells(9).Value

                .txtCustomerId.Text = cell0
                .txtfname.Text = cell1
                .txtlname.Text = cell3
                .txtmname.Text = cell2
                .txtContact.Text = cell5
                .txtHouseNo.Text = cell6
                .txtBarangay.Text = cell7
                .txtMunicipality.Text = cell8
                .cbType.Text = cell9

                Dim cmdd As New SqlCommand
                With cmdd
                    .CommandText = "select pictures from customertbl where customerId = '" + frmCustomer.txtCustomerId.Text + "' "
                    .Connection = con
                    .Parameters.Clear()
                End With
                Dim da As New SqlDataAdapter(cmdd)
                Dim dss As New DataSet
                da.Fill(dss, "customertbl")
                Dim c As Integer = dss.Tables(0).Rows.Count
                If c > 0 Then
                    Dim p() As Byte = dss.Tables(0).Rows(c - 1)("pictures")
                    Dim ms As New IO.MemoryStream(p)
                    frmCustomer.picImage.Image = Image.FromStream(ms)
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub supplierPassData()
        Try
            With frmSupplier
                Dim cell0 As Object = frmSupplier.DataGridViewX1.Rows(frmSupplier.DataGridViewX1.CurrentRow.Index).Cells(0).Value
                Dim cell1 As Object = frmSupplier.DataGridViewX1.Rows(frmSupplier.DataGridViewX1.CurrentRow.Index).Cells(1).Value
                Dim cell2 As Object = frmSupplier.DataGridViewX1.Rows(frmSupplier.DataGridViewX1.CurrentRow.Index).Cells(2).Value
                Dim cell3 As Object = frmSupplier.DataGridViewX1.Rows(frmSupplier.DataGridViewX1.CurrentRow.Index).Cells(3).Value
                Dim cell4 As Object = frmSupplier.DataGridViewX1.Rows(frmSupplier.DataGridViewX1.CurrentRow.Index).Cells(4).Value
                Dim cell5 As Object = frmSupplier.DataGridViewX1.Rows(frmSupplier.DataGridViewX1.CurrentRow.Index).Cells(5).Value
                Dim cell6 As Object = frmSupplier.DataGridViewX1.Rows(frmSupplier.DataGridViewX1.CurrentRow.Index).Cells(6).Value



                .txtSupplierId.Text = cell0
                .txtCompanyName.Text = cell1
                .txtContact.Text = cell2
                .txtBuildingNo.Text = cell3
                .txtPoblacion.Text = cell4
                .txtCity.Text = cell5
                Dim cmdd As New SqlCommand
                With cmdd
                    .CommandText = "select pic from suppliertbl where supplierId = '" + frmSupplier.txtSupplierId.Text + "' "
                    .Connection = con
                    .Parameters.Clear()
                End With
                Dim da As New SqlDataAdapter(cmdd)
                Dim dss As New DataSet
                da.Fill(dss, "suppliertbl")
                Dim c As Integer = dss.Tables(0).Rows.Count
                If c > 0 Then
                    Dim p() As Byte = dss.Tables(0).Rows(c - 1)("pic")
                    Dim ms As New IO.MemoryStream(p)
                    frmSupplier.picImage.Image = Image.FromStream(ms)
                End If
                'bs.DataSource = .CustomerlistTableAdapter.Fill(.CustomerList._customerlist)
                'bs.Position = .DataGridViewX1.Rows(.DataGridViewX1.CurrentRow.Index).Cells(11).Value

                '.picImage.DataBindings.Add("Image", bs, "pictures", True)
                'Dim ms As New MemoryStream
                'Dim img As Bitmap
                'img = DataGridViewX1.CurrentRow.Cells(10).Value
                ''  img.Save(ms, "")

                '.txtChartId.Text = cell0
                '.txtChartName.Text = cell1
                '.cbChartStatus.Text = cell2
                '.cbChartType.Text = cell3
                ''  Dim cell6 As Object = frmGeneralLedger.DataGridViewX1.Rows(frmGeneralLedger.DataGridViewX1.CurrentRow.Index).Cells(6).Value
                '.txtSalesId.Text = cell6
                '.comboCustomerSales.Text = cell5
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub ownersPassData()
        Try

            With frmOwners
                Dim cell0 As Object = frmOwners.DataGridViewX1.Rows(frmOwners.DataGridViewX1.CurrentRow.Index).Cells(1).Value

                .lbwithdrawal.Text = cell0
                .lbtemwithdrawal.Text = cell0
            End With
        Catch ex As Exception

        End Try
    End Sub
    Public Sub owners1PassData()
        Try
            With frmOwners
                Dim cell1 As Object = frmOwners.DataGridViewX2.Rows(frmOwners.DataGridViewX2.CurrentRow.Index).Cells(3).Value

                .lbnetincome.Text = cell1
                .lbtempnetincome.Text = cell1
            End With
        Catch ex As Exception

        End Try
    End Sub

    Public Sub balancesheetOwnersEquityPassData()
        Try
            With frmBalanceSheet

                Dim cell1 As Object = .DataGridViewX2.Rows(.DataGridViewX2.CurrentRow.Index).Cells(0).Value

                .ecapitaltotal.Text = cell1
                '  .lbtempecapital.Text = cell1
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Public Sub balancesheetLiabilitiesPassData()
        Try
            With frmBalanceSheet
                Dim cell1 As Object = .DataGridViewX3.Rows(.DataGridViewX2.CurrentRow.Index).Cells(3).Value

                .txttotalcredit.Text = cell1
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Module

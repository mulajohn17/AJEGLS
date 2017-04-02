Imports System.IO
Module updateRecord

    Public Sub updateSalesModule()
        Try

            If frmSpecialJournal.cbChart2.Text = "" Then
                With cmd

                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "updatesales"
                    .Parameters.Clear()
                    .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                    .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                    .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                    .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                    .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtCredit.Text.Trim
                    .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                    .Parameters.Add("@journalid", SqlDbType.Int).Value = frmSpecialJournal.txtJournalId.Text.Trim
                End With
            Else
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "updatecash"
                    .Parameters.Clear()
                    .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                    .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                    .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                    .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                    .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtCredit.Text.Trim
                    .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                    .Parameters.Add("@journalid", SqlDbType.Int).Value = frmSpecialJournal.txtJournalId.Text.Trim
                    '  .Parameters.Add("@Image", SqlDbType.Image).Value = IO.File.ReadAllBytes(browse.FileName)
                End With
            End If
            If MessageBox.Show("Are you sure you want to save ", _
                            "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim i As Integer = cmd.ExecuteNonQuery()
                '  Dim ii As Integer = cmd1.ExecuteNonQuery()
                '   Dim iii As Integer = cmd2.ExecuteNonQuery()
                '    Dim iiii As Integer = cmd3.ExecuteNonQuery()

                If i > 0 Then
                    MessageBox.Show("Data Has Been Updated")
                    frmSpecialJournalControlDisable()
                    clearAllTextBox()
                    retrieveSalesJournal()
                    salestotal()
                    con.Close()
                Else
                    MessageBox.Show("Failed to save")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error", ex.Message.ToString())
        End Try
    End Sub

    Public Sub updatePurchaseModule()
        Try

            If frmSpecialJournal.cbChart2.Text = "" Then
                With cmd

                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "updatepurchase"
                    .Parameters.Clear()
                    .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                    .Parameters.Add("@supplierid", SqlDbType.Int).Value = frmSpecialJournal.comboSupplier.SelectedValue.ToString()
                    .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                    .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                    .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtCredit.Text.Trim
                    .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                    .Parameters.Add("@journalid", SqlDbType.Int).Value = frmSpecialJournal.txtJournalId.Text.Trim
                End With
            Else
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "updatepurchase"
                    .Parameters.Clear()
                    .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                    .Parameters.Add("@supplierid", SqlDbType.Int).Value = frmSpecialJournal.comboSupplier.SelectedValue.ToString()
                    .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                    .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                    .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtCredit.Text.Trim
                    .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                    .Parameters.Add("@journalid", SqlDbType.Int).Value = frmSpecialJournal.txtJournalId.Text.Trim
                    '  .Parameters.Add("@Image", SqlDbType.Image).Value = IO.File.ReadAllBytes(browse.FileName)
                End With
            End If
            If MessageBox.Show("Are you sure you want to save ", _
                            "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim i As Integer = cmd.ExecuteNonQuery()
                '  Dim ii As Integer = cmd1.ExecuteNonQuery()
                '   Dim iii As Integer = cmd2.ExecuteNonQuery()
                '    Dim iiii As Integer = cmd3.ExecuteNonQuery()

                If i > 0 Then
                    MessageBox.Show("Data Has Been Updated")
                    frmSpecialJournalControlDisable()
                    clearAllTextBox()
                    ' retrievePurchaseJournal()
                    purchasetotal()
                    con.Close()
                Else
                    MessageBox.Show("Failed to save")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error", ex.Message.ToString())
        End Try
    End Sub

    Public Sub updateCashModule()
        Try

            If frmSpecialJournal.cbChart2.Text = "" Then
                With cmd

                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "updatecash"
                    .Parameters.Clear()
                    .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                    .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                    .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                    .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                    .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtCredit.Text.Trim
                    .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                    .Parameters.Add("@journalid", SqlDbType.Int).Value = frmSpecialJournal.txtJournalId.Text.Trim
                End With
            Else
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "updatecash"
                    .Parameters.Clear()
                    .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                    .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                    .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                    .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                    .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtCredit.Text.Trim
                    .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                    .Parameters.Add("@journalid", SqlDbType.Int).Value = frmSpecialJournal.txtJournalId.Text.Trim
                    '  .Parameters.Add("@Image", SqlDbType.Image).Value = IO.File.ReadAllBytes(browse.FileName)
                End With
            End If
            If MessageBox.Show("Are you sure you want to save ", _
                            "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim i As Integer = cmd.ExecuteNonQuery()
                '  Dim ii As Integer = cmd1.ExecuteNonQuery()
                '   Dim iii As Integer = cmd2.ExecuteNonQuery()
                '    Dim iiii As Integer = cmd3.ExecuteNonQuery()

                If i > 0 Then
                    MessageBox.Show("Data Has Been Updated")
                    frmSpecialJournalControlDisable()
                    clearAllTextBox()
                    retrieveCashReceiptJournal()
                    cashReceipttotal()
                    con.Close()
                Else
                    MessageBox.Show("Failed to save")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error", ex.Message.ToString())
        End Try
    End Sub

    Public Sub updateDisburseModule()
        Try

            If frmSpecialJournal.cbChart2.Text = "" Then
                With cmd

                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "updatedisburse"
                    .Parameters.Clear()
                    .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                    .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                    .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                    .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                    .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtCredit.Text.Trim
                    .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                    .Parameters.Add("@journalid", SqlDbType.Int).Value = frmSpecialJournal.txtJournalId.Text.Trim
                End With
            Else
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "updatecash"
                    .Parameters.Clear()
                    .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                    .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                    .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                    .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                    .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtCredit.Text.Trim
                    .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                    .Parameters.Add("@journalid", SqlDbType.Int).Value = frmSpecialJournal.txtJournalId.Text.Trim
                    '  .Parameters.Add("@Image", SqlDbType.Image).Value = IO.File.ReadAllBytes(browse.FileName)
                End With
            End If
            If MessageBox.Show("Are you sure you want to save ", _
                            "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim i As Integer = cmd.ExecuteNonQuery()
                '  Dim ii As Integer = cmd1.ExecuteNonQuery()
                '   Dim iii As Integer = cmd2.ExecuteNonQuery()
                '    Dim iiii As Integer = cmd3.ExecuteNonQuery()

                If i > 0 Then
                    MessageBox.Show("Data Has Been Updated")
                    frmSpecialJournalControlDisable()
                    clearAllTextBox()
                    retrieveDisbursementJournal()
                    disbursementtotal()
                    con.Close()
                Else
                    MessageBox.Show("Failed to save")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error", ex.Message.ToString())
        End Try
    End Sub


    Public Sub updateGeneral()
        Try
            Dim saveRecord As String

            saveRecord = frmGeneralLedger.txtJournalCategory.Text
            Select Case saveRecord
                Case "General Journal"
                    If frmGeneralLedger.cbAccount2.Text = "" Then
                        With cmd
                            .CommandType = CommandType.StoredProcedure
                            .Connection = con
                            .CommandText = "updategeneral"
                            .Parameters.Clear()
                            .Parameters.Add("@datee", SqlDbType.Date).Value = frmGeneralLedger.dtp.Value.ToString("yyyy/MM/dd")
                            .Parameters.Add("@chartid", SqlDbType.Int).Value = frmGeneralLedger.cbChart1.SelectedValue.ToString.Trim
                            .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmGeneralLedger.txtDebit.Text
                            .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmGeneralLedger.txtCredit.Text
                            .Parameters.Add("@remarks", SqlDbType.Text).Value = frmGeneralLedger.txtRemarks.Text.Trim
                            .Parameters.Add("@generalid", SqlDbType.Int).Value = frmGeneralLedger.txtGeneralId.Text.Trim
                            '  .Parameters.Add("@Image", SqlDbType.Image).Value = IO.File.ReadAllBytes(browse.FileName)
                        End With
                    Else
                        With cmd
                            .CommandType = CommandType.StoredProcedure
                            .Connection = con
                            .CommandText = "updategeneral"
                            .Parameters.Clear()
                            .Parameters.Add("@datee", SqlDbType.Date).Value = frmGeneralLedger.dtp.Value.ToString("yyyy/MM/dd")
                            .Parameters.Add("@chartid", SqlDbType.Int).Value = frmGeneralLedger.cbAccount2.SelectedValue.ToString.Trim
                            .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmGeneralLedger.txtDebit.Text
                            .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmGeneralLedger.txtCredit.Text
                            .Parameters.Add("@remarks", SqlDbType.Text).Value = frmGeneralLedger.txtRemarks.Text.Trim
                            .Parameters.Add("@generalid", SqlDbType.Int).Value = frmGeneralLedger.txtGeneralId.Text.Trim
                            '  .Parameters.Add("@Image", SqlDbType.Image).Value = IO.File.ReadAllBytes(browse.FileName)
                        End With
                    End If

                    If MessageBox.Show("Are you sure you want to save ", _
                           "Confirm", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        '  Dim ii As Integer = cmd1.ExecuteNonQuery()
                        '   Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '    Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 Then
                            Dim SAFI
                            SAFI = CreateObject("SAPI.spvoice")
                            SAFI.speak("Data Has Been Updated")
                            ' UpdateBinding()
                            con.Close()
                            frmGeneralLedger.frmGeneralLedger_Load(frmGeneralLedger, EventArgs.Empty)
                        Else
                            Dim SAFI
                            SAFI = CreateObject("SAPI.spvoice")
                            SAFI.speak("Failed to save")
                        End If
                    End If
                Case Else
                    MessageBox.Show("Unable To Update" & " " & frmGeneralLedger.txtJournalCategory.Text & " " & "To Update This Category Please Proceed According to Given Category")

            End Select

           

        Catch ex As Exception
            MessageBox.Show("Error", ex.Message.ToString())
        End Try
    End Sub

    Public Sub updateAccount()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "updateaccount"
                .Parameters.Clear()
                .Parameters.Add("@chartname", SqlDbType.Text).Value = frmChartofAccount.txtChartName.Text.Trim
                .Parameters.Add("@chartstatus", SqlDbType.Int).Value = frmChartofAccount.cbChartStatus.SelectedValue.ToString
                .Parameters.Add("@charttype", SqlDbType.Int).Value = frmChartofAccount.cbChartType.SelectedValue.ToString
                .Parameters.Add("@chartid", SqlDbType.Int).Value = Val(frmChartofAccount.txtChartId.Text.Trim)
            End With
            If MessageBox.Show("Are you sure you want to save ", _
                            "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Chart of Account Data has Been Updated")
                    ' UpdateBinding()
                    con.Close()
                    frmChartofAccount.frmChartofAccount_Load(frmChartofAccount, EventArgs.Empty)
                Else
                    MessageBox.Show("Failed to Update")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error", ex.Message.ToString)
        End Try

    End Sub

    Public Sub updateCustomer()
        Try
            'Picture converstion to Binary
            'load the current (no image default)
            If picStr = vbNullString Then
                'save the current image default (noimage)
                frmCustomer.picImage.Image.Save(".png", Imaging.ImageFormat.Png)
                'reload current " Noimage" to a binary
                picStr = Application.StartupPath + ("\noimage.png")
            End If

            'set image object to value
            IMG = (Nothing)
            IMG = Image.FromFile(picStr)
            'fill mystream into image binary
            MyStream = New MemoryStream
            IMG.Save(MyStream, Imaging.ImageFormat.Png)


            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "updatecustomer"
                .Parameters.Clear()
                .Parameters.Add("@customerid", SqlDbType.Int).Value = frmCustomer.txtCustomerId.Text
                .Parameters.Add("@lname", SqlDbType.Text).Value = frmCustomer.txtlname.Text
                .Parameters.Add("@mname", SqlDbType.Text).Value = frmCustomer.txtmname.Text
                .Parameters.Add("@fname", SqlDbType.Text).Value = frmCustomer.txtfname.Text
                .Parameters.Add("@fullname", SqlDbType.Text).Value = frmCustomer.txtlname.Text & " " & frmCustomer.txtmname.Text & " " & frmCustomer.txtfname.Text
                .Parameters.Add("@contact", SqlDbType.Text).Value = frmCustomer.txtContact.Text
                .Parameters.Add("@houseNo", SqlDbType.Text).Value = frmCustomer.txtHouseNo.Text
                .Parameters.Add("@barangay", SqlDbType.Text).Value = frmCustomer.txtBarangay.Text
                .Parameters.Add("@municipal", SqlDbType.Text).Value = frmCustomer.txtMunicipality.Text
                .Parameters.Add("@type", SqlDbType.Int).Value = frmCustomer.cbType.SelectedValue.ToString
                .Parameters.Add("@picture", SqlDbType.Image).Value = MyStream.GetBuffer
                '  .Parameters.Add("@Image", SqlDbType.Image).Value = IO.File.ReadAllBytes(browse.FileName)
            End With

            If MessageBox.Show("Are you sure you want to save ", _
                            "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Customer Data has Been Update")
              
                    'con.Close()
                    frmCustomer.frmCustomer_Load(frmCustomer, EventArgs.Empty)
                    MyStream.Close()
                    MyStream = Nothing
                Else
                    MessageBox.Show("Failed to update")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error", ex.Message.ToString)
        End Try

    End Sub

    Public Sub updateSupplier()
        Try
            'Picture converstion to Binary
            'load the current (no image default)
            If picStr = vbNullString Then
                'save the current image default (noimage)
                frmSupplier.picImage.Image.Save(".png", Imaging.ImageFormat.Png)
                'reload current " Noimage" to a binary
                picStr = Application.StartupPath + ("\noimage.png")
            End If

            'set image object to value
            IMG = (Nothing)
            IMG = Image.FromFile(picStr)
            'fill mystream into image binary
            MyStream = New MemoryStream
            IMG.Save(MyStream, Imaging.ImageFormat.Png)


            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "updatesupplier"
                .Parameters.Clear()
                .Parameters.Add("@supplierid", SqlDbType.Int).Value = frmSupplier.txtSupplierId.Text.Trim
                .Parameters.Add("@companyname", SqlDbType.Text).Value = frmSupplier.txtCompanyName.Text.Trim
                .Parameters.Add("@contact", SqlDbType.Text).Value = frmSupplier.txtContact.Text.Trim
                .Parameters.Add("@buildingno", SqlDbType.Text).Value = frmSupplier.txtBuildingNo.Text.Trim
                .Parameters.Add("@poblacion", SqlDbType.Text).Value = frmSupplier.txtPoblacion.Text.Trim
                .Parameters.Add("@city", SqlDbType.Text).Value = frmSupplier.txtCity.Text.Trim
                .Parameters.Add("@pictures", SqlDbType.Image).Value = MyStream.GetBuffer
                '  .Parameters.Add("@Image", SqlDbType.Image).Value = IO.File.ReadAllBytes(browse.FileName)
            End With

            If MessageBox.Show("Are you sure you want to save ", _
                            "Confirm", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim i As Integer = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MsgBox("Supplier Data Has Been Update")
                    con.Close()
                    frmSupplier.frmSupplier_Load(frmSupplier, EventArgs.Empty)
                    MyStream.Close()
                    MyStream = Nothing
                Else
           
                    MsgBox("Failed to save")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error", ex.Message.ToString)
        End Try

    End Sub

    'To Update Record 
    Public Sub updateRecordModule()
        Dim updateRecord As String
        updateRecord = frmSpecialJournal.groupJournalPanel.Text

        Select Case updateRecord

            Case "Sales Journal"
                updateSalesModule()
            Case "Purchase Journal"
                updatePurchaseModule()
            Case "Disbursement Journal"
                updateDisburseModule()
            Case "Cash Receipt Journal"
                updateCashModule()
            Case "Update Journal[F5]"
                'updateGeneral()
            Case Else
        End Select
    End Sub

End Module

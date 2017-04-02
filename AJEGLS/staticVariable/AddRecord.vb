Imports System.Data.SqlClient
Imports System.IO
Module AddRecord
    
    Public Sub addSummarizing()
        Dim dr As New System.Windows.Forms.DataGridViewRow

        For Each dr In frmSummarizingGeneral.DataGridViewX2.Rows
            Dim chartid As String = dr.Cells(0).Value
            Dim particulars As String = dr.Cells(1).Value
            Dim debit As String = dr.Cells(2).Value
            Dim credit As String = dr.Cells(3).Value
            Dim balance As String = dr.Cells(4).Value

            Dim cm As New SqlCommand("select * from summarizinggltbl where chartId = @chartid and particulars = @particulars and debit = @debit and credit = @credit and balance = @balance", con)
            cm.Parameters.AddWithValue("@chartid", chartid)
            cm.Parameters.AddWithValue("@particulars", particulars)
            cm.Parameters.AddWithValue("@debit", debit)
            cm.Parameters.AddWithValue("@credit", credit)
            cm.Parameters.AddWithValue("@balance", balance)
            frmSummarizingGeneral.frmSummarizingGeneral_Load(frmSummarizingGeneral, EventArgs.Empty)
            Dim da As New SqlDataAdapter(cm)
            Dim dtt As New DataTable
            da.Fill(dtt)
            If dtt.Rows.Count = 0 Then
                Dim cm2 As New SqlCommand("Insert into summarizinggltbl values(@chartid,@particulars,@debit,@credit,@balance)", con)
                cm2.Parameters.AddWithValue("@chartid", chartid)
                cm2.Parameters.AddWithValue("@particulars", particulars)
                cm2.Parameters.AddWithValue("@debit", debit)
                cm2.Parameters.AddWithValue("@credit", credit)
                cm2.Parameters.AddWithValue("@balance", balance)
                cm2.ExecuteNonQuery()
                frmSummarizingGeneral.frmSummarizingGeneral_Load(frmSummarizingGeneral, EventArgs.Empty)
            Else
                Dim cm1 As New SqlCommand("UPDATE summarizinggltbl set chartId=@chartid,particulars=@particulars,debit=@debit,credit=@credit,balance=@balance where chartId = @chartid and particulars = @particulars and debit = @debit and credit = @credit and balance = @balance", con)
                cm1.Parameters.AddWithValue("@chartid", chartid)
                cm1.Parameters.AddWithValue("@particulars", particulars)
                cm1.Parameters.AddWithValue("@debit", debit)
                cm1.Parameters.AddWithValue("@credit", credit)
                cm1.Parameters.AddWithValue("@balance", balance)
                cm1.ExecuteNonQuery()
                frmSummarizingGeneral.frmSummarizingGeneral_Load(frmSummarizingGeneral, EventArgs.Empty)
            End If
            con.Close()

        Next
    End Sub

    Public Sub addCustomer()
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
            Dim cm As New SqlCommand("select * from customertbl where fname = @fname1 and mname = @mname1 and lname = @lname1", con)
            cm.Parameters.AddWithValue("@fname1", frmCustomer.txtfname.Text.Trim)
            cm.Parameters.AddWithValue("@mname1", frmCustomer.txtmname.Text.Trim)
            cm.Parameters.AddWithValue("@lname1", frmCustomer.txtlname.Text.Trim)
            Dim da As New SqlDataAdapter(cm)
            Dim dtt As New DataTable
            da.Fill(dtt)

            If dtt.Rows.Count = 0 Then
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "insertcustomer"
                    .Parameters.Clear()
                    '  .Parameters.Add("@customerid", SqlDbType.Int).Value = frmCustomer.txtCustomerId.Text
                    .Parameters.Add("@lname", SqlDbType.Text).Value = frmCustomer.txtlname.Text
                    .Parameters.Add("@mname", SqlDbType.Text).Value = frmCustomer.txtmname.Text
                    .Parameters.Add("@fname", SqlDbType.Text).Value = frmCustomer.txtfname.Text
                    .Parameters.Add("@fullname", SqlDbType.Text).Value = frmCustomer.txtlname.Text & ", " & frmCustomer.txtmname.Text & " " & frmCustomer.txtfname.Text
                    .Parameters.Add("@contact", SqlDbType.Text).Value = frmCustomer.txtContact.Text
                    .Parameters.Add("@houseNo", SqlDbType.Text).Value = frmCustomer.txtHouseNo.Text
                    .Parameters.Add("@barangay", SqlDbType.Text).Value = frmCustomer.txtBarangay.Text
                    .Parameters.Add("@municipal", SqlDbType.Text).Value = frmCustomer.txtMunicipality.Text
                    .Parameters.Add("@customertypeid", SqlDbType.Int).Value = frmCustomer.cbType.SelectedValue.ToString
                    .Parameters.Add("@picture", SqlDbType.Image).Value = MyStream.GetBuffer
                    '  .Parameters.Add("@Image", SqlDbType.Image).Value = IO.File.ReadAllBytes(browse.FileName)
                End With

                If MessageBox.Show("Are you sure you want to save ", _
                                "Confirm", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If i > 0 Then
                        MsgBox("Customer Has Been Saved")
                        ' UpdateBinding()
                        'con.Close()
                        MyStream.Close()
                        MyStream = Nothing
                        frmCustomer.frmCustomer_Load(frmCustomer, EventArgs.Empty)
                    Else
                        MsgBox("Failed to save")
                    End If
                End If
            Else
                MessageBox.Show(frmCustomer.txtfname.Text & " " & frmCustomer.txtmname.Text.Trim & " " & frmCustomer.txtlname.Text.Trim & " Already Exist")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Sub addAccount()
        Try
            Dim cm As New SqlCommand("select * from charttbl where chartname = @chartname and statusid = @statusid and typeid = @typeid", con)
            cm.Parameters.AddWithValue("@chartname", frmChartofAccount.txtChartName.Text)
            cm.Parameters.AddWithValue("@statusid", frmChartofAccount.cbChartStatus.SelectedValue.ToString)
            cm.Parameters.AddWithValue("@typeid", frmChartofAccount.cbChartType.SelectedValue.ToString)
            Dim da As New SqlDataAdapter(cm)
            Dim dtt As New DataTable
            da.Fill(dtt)

            If dtt.Rows.Count = 0 Then
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "insertchart"
                    .Parameters.Clear()
                    .Parameters.Add("@chartname", SqlDbType.Text).Value = frmChartofAccount.txtChartName.Text
                    .Parameters.Add("@statusid", SqlDbType.Int).Value = frmChartofAccount.cbChartStatus.SelectedValue.ToString
                    .Parameters.Add("@typeid", SqlDbType.Int).Value = frmChartofAccount.cbChartType.SelectedValue.ToString
                    '.Parameters.Add("@chartid", SqlDbType.Int).Value = Val(frmChartofAccount.txtChartId.Text.Trim)
                End With
                If MessageBox.Show("Are you sure you want to save ", _
                                "Confirm", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If i > 0 Then
                        MsgBox("Chart Has Been Saved")
                        ' UpdateBinding()
                        'con.Close()
                        frmChartofAccount.frmChartofAccount_Load(frmChartofAccount, EventArgs.Empty)
                    Else
                        MsgBox("Failed to save")
                    End If
                End If
            Else
                MessageBox.Show("Account Name: " & frmChartofAccount.txtChartName.Text & " | Account Status: " & frmChartofAccount.cbChartStatus.Text & " | Account Type: " & frmChartofAccount.cbChartType.Text & " Already Exist")
            End If
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub addSupplier()
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

            Dim cm As New SqlCommand("select * from suppliertbl where companyname = @companyname", con)
            cm.Parameters.AddWithValue("@companyname", frmSupplier.txtCompanyName.Text.Trim)
            Dim da As New SqlDataAdapter(cm)
            Dim dtt As New DataTable
            da.Fill(dtt)

            If dtt.Rows.Count = 0 Then
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "insertsupplier"
                    .Parameters.Clear()
                    '  .Parameters.Add("@supplierid", SqlDbType.Text).Value = frmSupplier.txtSupplierId.Text.Trim
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
                        MsgBox("Supplier Has Been Saved")
                        ' UpdateBinding()
                        'con.Close()
                        MyStream.Close()
                        MyStream = Nothing
                        frmSupplier.frmSupplier_Load(frmSupplier, EventArgs.Empty)
                    Else
                        MsgBox("Failed to save")
                    End If
                End If
            Else
                MessageBox.Show(frmSupplier.txtCompanyName.Text.Trim & " Already Exist")
            End If

           

        Catch ex As Exception
            MessageBox.Show("Error", "Require to Fill")
        End Try

    End Sub

    Public Sub addIncome()

        Try
            Dim revenue As Decimal = frmIncomeStatement.lbtemprevenue.Text
            Dim expense As Decimal = frmIncomeStatement.lbtempexpense.Text
            Dim netincome As Decimal = frmIncomeStatement.lbtempneticome.Text
            Dim savedate = frmMain.DateTimePicker1.Value.ToString("MMMM dd yyyy")
            Dim cm As New SqlCommand("select * from incometbl where savedate = @date", con)
            cm.Parameters.AddWithValue("@date", savedate)

            Dim da As New SqlDataAdapter(cm)
            Dim dtt As New DataTable
            da.Fill(dtt)
            If dtt.Rows.Count = 0 Then
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "insertincome"
                    .Parameters.Clear()
                    .Parameters.Add("@totaldebit", SqlDbType.Decimal).Value = frmIncomeStatement.lbtempexpense.Text
                    .Parameters.Add("@totalcredit", SqlDbType.Decimal).Value = frmIncomeStatement.lbtemprevenue.Text
                    .Parameters.Add("@netincome", SqlDbType.Decimal).Value = frmIncomeStatement.lbtempneticome.Text
                    .Parameters.Add("@date", SqlDbType.Date).Value = frmMain.DateTimePicker1.Value.ToString("MMMM dd yyyy")
                    '.Parameters.Add("@chartid", SqlDbType.Int).Value = Val(frmChartofAccount.txtChartId.Text.Trim)
                End With
                If MessageBox.Show("Are you sure you want to save ", _
                                "Confirm", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If i > 0 Then
                        MsgBox("Income Statement Has Been Saved")
                        ' UpdateBinding()
                        'con.Close()
                        '   frmChartofAccount.frmChartofAccount_Load(frmChartofAccount, EventArgs.Empty)
                    Else
                        MsgBox("Failed to save")
                    End If
                End If

            Else

                Dim cm1 As New SqlCommand("UPDATE incometbl set revenue=@revenue,expense=@expense,netincome=@netincome,savedate=@date where savedate=@date", con)
                cm1.Parameters.AddWithValue("@date", savedate)
                cm1.Parameters.AddWithValue("@revenue", revenue)
                cm1.Parameters.AddWithValue("@expense", expense)
                cm1.Parameters.AddWithValue("@netincome", netincome)
                If MessageBox.Show("Income Statement" & " " & frmMain.DateTimePicker1.Value.ToString("MMMM dd yyyy") & " " & " Already Exist Do you want to override?", _
                                "Confirm", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim i As Integer = cm1.ExecuteNonQuery()
                    If i > 0 Then
                        MsgBox("Income Statement Has Been Updated")

                        ' UpdateBinding()
                        'con.Close()
                        '   frmChartofAccount.frmChartofAccount_Load(frmChartofAccount, EventArgs.Empty)
                    Else
                        MsgBox("Failed to save")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try        
    End Sub

    
    Public Sub addOwners()
     
        Try
            Dim beginningcapital As Decimal = frmOwners.lbtempbcapital.Text
            Dim neticome As Decimal = frmOwners.lbtempnetincome.Text
            Dim withdrawal As Decimal = frmOwners.lbtemwithdrawal.Text
            Dim endingcapital As Decimal = frmOwners.lbtempendingcapital.Text
            Dim savedate = frmMain.DateTimePicker1.Value.ToString("MMMM dd yyyy")
            Dim cm As New SqlCommand("select * from ownerstbl where savedate = @date", con)
            cm.Parameters.AddWithValue("@date", savedate)

            Dim da As New SqlDataAdapter(cm)
            Dim dtt As New DataTable
            da.Fill(dtt)
            If dtt.Rows.Count = 0 Then
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "insertowners"
                    .Parameters.Clear()
                    .Parameters.Add("@bcapital", SqlDbType.Decimal).Value = Val(frmOwners.lbtempbcapital.Text)
                    .Parameters.Add("@netincome", SqlDbType.Decimal).Value = Val(frmOwners.lbtempnetincome.Text)
                    .Parameters.Add("@lesswithdraw", SqlDbType.Decimal).Value = Val(frmOwners.lbtemwithdrawal.Text)
                    .Parameters.Add("@ecapital", SqlDbType.Decimal).Value = Val(frmOwners.lbtempendingcapital.Text)
                    .Parameters.Add("@date", SqlDbType.Date).Value = frmMain.DateTimePicker1.Value.ToString("MMMM dd yyyy")
                    '.Parameters.Add("@chartid", SqlDbType.Int).Value = Val(frmChartofAccount.txtChartId.Text.Trim)
                End With
                If MessageBox.Show("Are you sure you want to save ", _
                                "Confirm", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    If i > 0 Then
                        MsgBox("Owner's Equity Statement Has Been Saved")
                        ' UpdateBinding()
                        'con.Close()
                        '  frmChartofAccount.frmChartofAccount_Load(frmChartofAccount, EventArgs.Empty)
                    Else
                        MsgBox("Failed to save")
                    End If
                End If


            Else

                Dim cm1 As New SqlCommand("UPDATE ownerstbl set bcapital=@bcapital,netincome=@netincome,lesswithdraw=@withdraw,ecapital=@ecapital,savedate=@date where savedate=@date", con)
                cm1.Parameters.AddWithValue("@bcapital", beginningcapital)
                cm1.Parameters.AddWithValue("@netincome", neticome)
                cm1.Parameters.AddWithValue("@withdraw", withdrawal)
                cm1.Parameters.AddWithValue("@ecapital", endingcapital)
                cm1.Parameters.AddWithValue("@date", savedate)
                If MessageBox.Show("Owner's Equity Statement" & " " & frmMain.DateTimePicker1.Value.ToString("MMMM dd yyyy") & " " & " Already Exist Do you want to override?", _
                                "Confirm", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim i As Integer = cm1.ExecuteNonQuery()
                    If i > 0 Then
                        MsgBox("Owner's Equity Statement Has Been Updated")

                        ' UpdateBinding()
                        'con.Close()
                        '   frmChartofAccount.frmChartofAccount_Load(frmChartofAccount, EventArgs.Empty)
                    Else
                        MsgBox("Failed to Update")
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub addSpecialJournal()
        Try
            'Sales Journal
            If frmSpecialJournal.txtRemarks.Text = "" And frmSpecialJournal.txtCredit.Text = "" And frmSpecialJournal.txtDebit.Text = "" Then
                MessageBox.Show("Required Field")
            Else
                If frmSpecialJournal.groupJournalPanel.Text = "Sales Journal" Then
                    Dim supplier As String = ""
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = Val(supplier)
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()

                    End With

                    With cmd1
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = Val(supplier)
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()
                    End With
                    If MessageBox.Show("Are you sure you want to save ", _
                                    "Confirm", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        Dim ii As Integer = cmd1.ExecuteNonQuery()
                        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 And ii > 0 Then
                            MsgBox("Journal Has Been Saved")
                            ' UpdateBinding()
                            con.Close()
                            frmSpecialJournal.frmGeneralLedger_Load(frmSpecialJournal, EventArgs.Empty)
                            'frmSalesJournal.frmSalesJournal_Load(frmSalesJournal, EventArgs.Empty)
                            'frmMain.toolSaveRecord.Enabled = False
                            'frmSalesControlDisable()
                            'salesControls()
                        Else
                            MsgBox("Failed to save")
                        End If
                    End If


                    'Purchase Journal
                ElseIf frmSpecialJournal.groupJournalPanel.Text = "Purchase Journal" Then
                    Dim customer As String = ""
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = Val(customer)
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = frmSpecialJournal.comboSupplier.SelectedValue.ToString()
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()

                    End With
                    With cmd1
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = Val(customer)
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = frmSpecialJournal.comboSupplier.SelectedValue.ToString()
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()
                    End With
                    If MessageBox.Show("Are you sure you want to save ", _
                                    "Confirm", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        Dim ii As Integer = cmd1.ExecuteNonQuery()
                        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 And ii > 0 Then
                            MsgBox("Journal Has Been Saved")
                            ' UpdateBinding()
                            con.Close()
                            frmSpecialJournal.frmGeneralLedger_Load(frmSpecialJournal, EventArgs.Empty)
                            'frmSalesJournal.frmSalesJournal_Load(frmSalesJournal, EventArgs.Empty)
                            'frmMain.toolSaveRecord.Enabled = False
                            'frmSalesControlDisable()
                            'salesControls()
                        Else
                            MsgBox("Failed to save")
                        End If
                    End If

                    'Cash Receipt Journal
                ElseIf frmSpecialJournal.groupJournalPanel.Text = "Cash Receipt Journal" Then
                    Dim supplier As String = ""
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = Val(supplier)
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()

                    End With

                    With cmd1
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = Val(supplier)
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()
                    End With
                    If MessageBox.Show("Are you sure you want to save ", _
                                    "Confirm", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        Dim ii As Integer = cmd1.ExecuteNonQuery()
                        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 And ii > 0 Then
                            MsgBox("Journal Has Been Saved")
                            ' UpdateBinding()
                            con.Close()
                            frmSpecialJournal.frmGeneralLedger_Load(frmSpecialJournal, EventArgs.Empty)
                            'frmSalesJournal.frmSalesJournal_Load(frmSalesJournal, EventArgs.Empty)
                            'frmMain.toolSaveRecord.Enabled = False
                            'frmSalesControlDisable()
                            'salesControls()
                        Else
                            MsgBox("Failed to save")
                        End If
                    End If
                    'Disbursement Journal
                ElseIf frmSpecialJournal.groupJournalPanel.Text = "Disbursement Journal" Then
                    Dim customer As String = ""
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = Val(customer)
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = frmSpecialJournal.comboSupplier.SelectedValue.ToString()
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()

                    End With

                    With cmd1
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = Val(customer)
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = frmSpecialJournal.comboSupplier.SelectedValue.ToString()
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()
                    End With
                    If MessageBox.Show("Are you sure you want to save ", _
                                    "Confirm", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        Dim ii As Integer = cmd1.ExecuteNonQuery()
                        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 And ii > 0 Then
                            MsgBox("Journal Has Been Saved")
                            ' UpdateBinding()
                            con.Close()
                            frmSpecialJournal.frmGeneralLedger_Load(frmSpecialJournal, EventArgs.Empty)
                            'frmSalesJournal.frmSalesJournal_Load(frmSalesJournal, EventArgs.Empty)
                            'frmMain.toolSaveRecord.Enabled = False
                            'frmSalesControlDisable()
                            'salesControls()
                        Else
                            MsgBox("Failed to save")
                        End If
                    End If
                    'General Journal check Customer
                ElseIf frmSpecialJournal.groupJournalPanel.Text = "General Journal" And frmSpecialJournal.checkCustomer.Checked = True Then
                    Dim supplier As String = ""
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = Val(supplier)
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()

                    End With

                    With cmd1
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = frmSpecialJournal.comboCustomer.SelectedValue.ToString()
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = Val(supplier)
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()
                    End With
                    If MessageBox.Show("Are you sure you want to save ", _
                                    "Confirm", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        Dim ii As Integer = cmd1.ExecuteNonQuery()
                        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 And ii > 0 Then
                            MsgBox("Journal Has Been Saved")
                            ' UpdateBinding()
                            con.Close()
                            frmSpecialJournal.frmGeneralLedger_Load(frmSpecialJournal, EventArgs.Empty)
                            'frmSalesJournal.frmSalesJournal_Load(frmSalesJournal, EventArgs.Empty)
                            'frmMain.toolSaveRecord.Enabled = False
                            'frmSalesControlDisable()
                            'salesControls()
                        Else
                            MsgBox("Failed to save")
                        End If
                    End If
                    'General Journal check Supplier
                ElseIf frmSpecialJournal.groupJournalPanel.Text = "General Journal" And frmSpecialJournal.checkSupplier.Checked = True Then
                    Dim customer As String = ""
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart1.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = Val(customer)
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = frmSpecialJournal.comboSupplier.SelectedValue.ToString()
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()

                    End With
                    With cmd1
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertSpecialJournal"
                        .Parameters.Clear()
                        .Parameters.Add("@chartid", SqlDbType.Int).Value = frmSpecialJournal.cbChart2.SelectedValue.ToString.Trim()
                        .Parameters.Add("@customerid", SqlDbType.Int).Value = Val(customer)
                        .Parameters.Add("@supplierid", SqlDbType.Int).Value = frmSpecialJournal.comboSupplier.SelectedValue.ToString()
                        .Parameters.Add("@dateEntry", SqlDbType.Date).Value = frmSpecialJournal.dtp.Value.ToString("yyyy/MM/dd")
                        .Parameters.Add("@debit", SqlDbType.Decimal).Value = "0.00"
                        .Parameters.Add("@credit", SqlDbType.Decimal).Value = frmSpecialJournal.txtDebit.Text.Trim
                        .Parameters.Add("@remarks", SqlDbType.VarChar).Value = frmSpecialJournal.txtRemarks.Text.Trim
                        .Parameters.Add("@journaltypeid", SqlDbType.Int).Value = frmSpecialJournal.comboJournalType.SelectedValue.ToString()
                    End With
                    If MessageBox.Show("Are you sure you want to save ", _
                                    "Confirm", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        Dim ii As Integer = cmd1.ExecuteNonQuery()
                        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 And ii > 0 Then
                            MsgBox("Journal Has Been Saved")
                            ' UpdateBinding()
                            con.Close()
                            frmSpecialJournal.frmGeneralLedger_Load(frmSpecialJournal, EventArgs.Empty)
                            clearAllTextBox()
                            'frmSalesJournal.frmSalesJournal_Load(frmSalesJournal, EventArgs.Empty)
                            'frmMain.toolSaveRecord.Enabled = False
                            'frmSalesControlDisable()
                            'salesControls()
                        Else
                            MsgBox("Failed to save")
                        End If
                    End If

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub addJournalType()
        Try
            If frmJournalType.txtJournalType.Text = "" Then
                MessageBox.Show("Required Field")
            Else
                Dim cm As New SqlCommand("select * from journaltypetbl where journalType = @journaltype", con)
                cm.Parameters.AddWithValue("@journaltype", frmJournalType.txtJournalType.Text.Trim)

                Dim da As New SqlDataAdapter(cm)
                Dim dtt As New DataTable
                da.Fill(dtt)
                If dtt.Rows.Count = 0 Then
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertjournaltype"
                        .Parameters.Clear()
                        .Parameters.Add("@journaltype", SqlDbType.VarChar).Value = frmJournalType.txtJournalType.Text.Trim

                    End With

                    If MessageBox.Show("Are you sure you want to save ", _
                                    "Confirm", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 Then
                            MsgBox("Journal Type Has Been Saved")
                            ' UpdateBinding()
                            con.Close()
                            frmJournalType.frmJournalType_Load(frmJournalType, EventArgs.Empty)
                            'frmSalesJournal.frmSalesJournal_Load(frmSalesJournal, EventArgs.Empty)
                            'frmMain.toolSaveRecord.Enabled = False
                            'frmSalesControlDisable()
                            'salesControls()
                        Else
                            MsgBox("Failed to save")
                        End If
                    End If

                Else
                    MessageBox.Show(frmJournalType.txtJournalType.Text.Trim & " Already Exist")

                End If
            End If
            

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub addChartStatus()
        Try
            If frmJournalType.txtChartStatus.Text = "" Then
                MessageBox.Show("Required Field")
            Else
                Dim cm As New SqlCommand("select * from chartstatustbl where chartstatus = @status", con)
                cm.Parameters.AddWithValue("@status", frmJournalType.txtChartStatus.Text.Trim)

                Dim da As New SqlDataAdapter(cm)
                Dim dtt As New DataTable
                da.Fill(dtt)
                If dtt.Rows.Count = 0 Then
                    If frmJournalType.checkChartStatus.Checked = True Then
                        With cmd
                            .CommandType = CommandType.StoredProcedure
                            .Connection = con
                            .CommandText = "insertChartStatus"
                            .Parameters.Clear()
                            .Parameters.Add("@chartstatus", SqlDbType.VarChar).Value = frmJournalType.txtChartStatus.Text.Trim

                        End With

                        If MessageBox.Show("Are you sure you want to save ", _
                                        "Confirm", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            Dim i As Integer = cmd.ExecuteNonQuery()
                            '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                            '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                            If i > 0 Then
                                MsgBox("Chart Status Has Been Saved")
                                ' UpdateBinding()
                                con.Close()
                                frmJournalType.frmJournalType_Load(frmJournalType, EventArgs.Empty)
                            Else
                                MsgBox("Failed to save")
                            End If
                        End If

                    End If
                Else
                    MessageBox.Show(frmJournalType.txtChartStatus.Text.Trim & " Status " & " Already Exist")
                End If
            End If
            

            'ElseIf frmJournalType.checkChartType.Checked = True Then
            '    With cmd
            '        .CommandType = CommandType.StoredProcedure
            '        .Connection = con
            '        .CommandText = "insertChartType"
            '        .Parameters.Clear()
            '        .Parameters.Add("@charttype", SqlDbType.VarChar).Value = frmJournalType.txtChartType.Text.Trim

            '    End With

            '    If MessageBox.Show("Are you sure you want to save ", _
            '                    "Confirm", MessageBoxButtons.YesNo,
            '                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '        Dim i As Integer = cmd.ExecuteNonQuery()
            '        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
            '        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

            '        If i > 0 Then
            '            MsgBox("Chart Type Has Been Saved")
            '            ' UpdateBinding()
            '            con.Close()
            '            frmJournalType.frmJournalType_Load(frmJournalType, EventArgs.Empty)
            '        Else
            '            MsgBox("Failed to save")
            '        End If
            '    End If
            '    'Another If
            'Else
            '    With cmd
            '        .CommandType = CommandType.StoredProcedure
            '        .Connection = con
            '        .CommandText = "insertChartStatus"
            '        .Parameters.Clear()
            '        .Parameters.Add("@chartstatus", SqlDbType.VarChar).Value = frmJournalType.txtChartStatus.Text.Trim

            '    End With

            '    With cmd1
            '        .CommandType = CommandType.StoredProcedure
            '        .Connection = con
            '        .CommandText = "insertChartType"
            '        .Parameters.Clear()
            '        .Parameters.Add("@charttype", SqlDbType.VarChar).Value = frmJournalType.txtChartType.Text.Trim

            '    End With

            '    If MessageBox.Show("Are you sure you want to save ", _
            '                    "Confirm", MessageBoxButtons.YesNo,
            '                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            '        Dim i As Integer = cmd.ExecuteNonQuery()
            '        Dim ii As Integer = cmd1.ExecuteNonQuery()
            '        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
            '        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

            '        If i > 0 And i > 0 Then
            '            MsgBox("Chart Status and Type Has Been Saved")
            '            ' UpdateBinding()
            '            con.Close()
            '            frmJournalType.frmJournalType_Load(frmJournalType, EventArgs.Empty)
            '        Else
            '            MsgBox("Failed to save")
            '        End If
            '    End If

            'End If



            'Another If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Add Chart Type


    Public Sub addChartType()
        Try
            If frmJournalType.txtChartType.Text = "" Then
                MessageBox.Show("Required Field")
            Else
                Dim cm As New SqlCommand("select * from charttypetbl where charttype = @type", con)
                cm.Parameters.AddWithValue("@type", frmJournalType.txtChartType.Text.Trim)

                Dim da As New SqlDataAdapter(cm)
                Dim dtt As New DataTable
                da.Fill(dtt)
                If dtt.Rows.Count = 0 Then
                    If frmJournalType.checkChartType.Checked = True Then
                        With cmd
                            .CommandType = CommandType.StoredProcedure
                            .Connection = con
                            .CommandText = "insertChartType"
                            .Parameters.Clear()
                            .Parameters.Add("@charttype", SqlDbType.VarChar).Value = frmJournalType.txtChartType.Text.Trim

                        End With

                        If MessageBox.Show("Are you sure you want to save ", _
                                        "Confirm", MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            Dim i As Integer = cmd.ExecuteNonQuery()
                            '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                            '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                            If i > 0 Then
                                MsgBox("Chart Type Has Been Saved")
                                ' UpdateBinding()
                                con.Close()
                                frmJournalType.frmJournalType_Load(frmJournalType, EventArgs.Empty)
                            Else
                                MsgBox("Failed to save")
                            End If
                        End If

                    End If
                Else
                    MessageBox.Show(frmJournalType.txtChartType.Text.Trim & " Type " & " Already Exist")
                End If
            End If
            

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    'Add Chart Type and Status

    Public Sub addChartTypeandStatus()
        Try
            Dim cm1 As New SqlCommand("select * from chartstatustbl where chartstatus = @status", con)
            cm1.Parameters.AddWithValue("@status", frmJournalType.txtChartStatus.Text.Trim)

            Dim da1 As New SqlDataAdapter(cm1)
            Dim dtt1 As New DataTable
            da1.Fill(dtt1)

            Dim cm As New SqlCommand("select * from charttypetbl where charttype = @type", con)
            cm.Parameters.AddWithValue("@type", frmJournalType.txtChartType.Text.Trim)

            Dim da As New SqlDataAdapter(cm)
            Dim dtt As New DataTable
            da.Fill(dtt)
            If dtt.Rows.Count = 0 Then
                If frmJournalType.checkChartType.Checked = True Then
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertChartType"
                        .Parameters.Clear()
                        .Parameters.Add("@charttype", SqlDbType.VarChar).Value = frmJournalType.txtChartType.Text.Trim

                    End With
                    If MessageBox.Show("Are you sure you want to save ", _
                                "Confirm", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 Then
                            MsgBox("Chart Type Has Been Saved")
                            frmJournalType.frmJournalType_Load(frmJournalType, EventArgs.Empty)
                        Else
                            MsgBox("Failed to save")
                        End If
                    End If
                End If

            ElseIf dtt1.Rows.Count = 0 Then
                With cmd1
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "insertChartStatus"
                    .Parameters.Clear()
                    .Parameters.Add("@chartstatus", SqlDbType.VarChar).Value = frmJournalType.txtChartStatus.Text.Trim

                End With

                If MessageBox.Show("Are you sure you want to save ", _
                                "Confirm", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Dim ii As Integer = cmd1.ExecuteNonQuery()
                    '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                    '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                    If ii > 0 Then
                        MsgBox("Chart Status Has Been Saved")
                        frmJournalType.frmJournalType_Load(frmJournalType, EventArgs.Empty)

                    Else
                        MsgBox("Failed to save")
                    End If
                    End If
                Else
                MessageBox.Show(frmJournalType.txtChartStatus.Text.Trim & " Status " & " And " & frmJournalType.txtChartType.Text.Trim & " Type " & " Already Exist ")
                End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    'Insert Customer Type
    Public Sub addCustomerType()
        Try
            Dim cm As New SqlCommand("select * from customertypetbl where customertype = @customertype", con)
            cm.Parameters.AddWithValue("@customertype", frmJournalType.txtCustomerType.Text.Trim)

            Dim da As New SqlDataAdapter(cm)
            Dim dtt As New DataTable
            da.Fill(dtt)
            If dtt.Rows.Count = 0 Then
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Connection = con
                    .CommandText = "insertCustomerType"
                    .Parameters.Clear()
                    .Parameters.Add("@customertype", SqlDbType.VarChar).Value = frmJournalType.txtCustomerType.Text.Trim

                End With

                If MessageBox.Show("Are you sure you want to save ", _
                                "Confirm", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim i As Integer = cmd.ExecuteNonQuery()
                    '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                    '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                    If i > 0 Then
                        MsgBox("Customer Type Has Been Saved")
                        ' UpdateBinding()
                        con.Close()
                    Else
                        MsgBox("Failed to save")
                    End If
                End If
            Else
                MessageBox.Show(frmJournalType.txtCustomerType.Text & " Type Already Exist")
            End If
            

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'Add Department
    Public Sub addDepartment()
        Try
            If frmDepartment.txtDepartment.Text = "" Then
                MessageBox.Show(" Required Fill")
            Else
                Dim cm As New SqlCommand("select * from departmenttbl where departmentname = @departmentname", con)
                cm.Parameters.AddWithValue("@departmentname", frmDepartment.txtDepartment.Text.Trim)

                Dim da As New SqlDataAdapter(cm)
                Dim dtt As New DataTable
                da.Fill(dtt)
                If dtt.Rows.Count = 0 Then
                    With cmd
                        .CommandType = CommandType.StoredProcedure
                        .Connection = con
                        .CommandText = "insertdepartment"
                        .Parameters.Clear()
                        .Parameters.Add("@department", SqlDbType.VarChar).Value = frmDepartment.txtDepartment.Text.Trim


                    End With

                    If MessageBox.Show("Are you sure you want to save ", _
                                    "Confirm", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Dim i As Integer = cmd.ExecuteNonQuery()
                        '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                        '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                        If i > 0 Then
                            MsgBox("New Department Has Been Saved")
                            ' UpdateBinding()
                            con.Close()
                        Else
                            MsgBox("Failed to save")
                        End If
                    End If
                Else
                    MessageBox.Show(frmDepartment.txtDepartment.Text.Trim & " Department Already Exist")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'Register Employee

    Public Sub addEmployee()
        Try
            For Each ctrls As Control In frmEmployee.GroupPanel1.Controls
                If TypeOf ctrls Is TextBox Then
                    ctrls.Text = ""
                    MessageBox.Show("Required Fill")
                Else
                    If ctrls.Text = "" Then
                        Dim cm As New SqlCommand("select * from usertbl where empfname = @empfname and empmname = @empmname and emplname = @emplname", con)
                        cm.Parameters.AddWithValue("@empfname", frmEmployee.txtfname.Text.Trim)
                        cm.Parameters.AddWithValue("@empmname", frmEmployee.txtmname.Text.Trim)
                        cm.Parameters.AddWithValue("@emplname", frmEmployee.txtlname.Text.Trim)

                        Dim da As New SqlDataAdapter(cm)
                        Dim dtt As New DataTable
                        da.Fill(dtt)
                        If dtt.Rows.Count = 0 Then
                            With cmd
                                .CommandType = CommandType.StoredProcedure
                                .Connection = con
                                .CommandText = "insertuser"
                                .Parameters.Clear()
                                .Parameters.Add("@departmentid", SqlDbType.Int).Value = frmEmployee.cbDepartment.SelectedValue.ToString
                                .Parameters.Add("@empfname", SqlDbType.VarChar).Value = frmEmployee.txtfname.Text.Trim
                                .Parameters.Add("@empmname", SqlDbType.VarChar).Value = frmEmployee.txtmname.Text.Trim
                                .Parameters.Add("@emplname", SqlDbType.VarChar).Value = frmEmployee.txtlname.Text.Trim
                                .Parameters.Add("@empcontact", SqlDbType.VarChar).Value = frmEmployee.txtcontact.Text.Trim
                                .Parameters.Add("@position", SqlDbType.VarChar).Value = frmEmployee.txtposition.Text.Trim
                                .Parameters.Add("@password", SqlDbType.VarChar).Value = frmEmployee.txtlname.Text.Trim & frmEmployee.txtfname.Text.Trim


                            End With

                            If MessageBox.Show("Are you sure you want to save ", _
                                            "Confirm", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                                Dim i As Integer = cmd.ExecuteNonQuery()
                                '        Dim iii As Integer = cmd2.ExecuteNonQuery()
                                '         Dim iiii As Integer = cmd3.ExecuteNonQuery()

                                If i > 0 Then
                                    MsgBox("New User Has Been Saved")
                                    ' UpdateBinding()
                                    con.Close()
                                Else
                                    MsgBox("Failed to save")
                                End If
                            End If
                        Else
                            MessageBox.Show(frmEmployee.txtfname.Text.Trim & " " & frmEmployee.txtmname.Text.Trim & " " & frmEmployee.txtlname.Text.Trim & " " & " Department Already Exist")
                        End If
                    End If
                End If
                
                frmSpecialJournal.txtRemarks.Clear()

            Next

          


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    'To Add Record
    Public Sub addRecordControl()
        Dim saveRecord As String
        saveRecord = frmMain.toolSaveRecord.Text

        Select Case saveRecord
            Case "Save Customer[F4]"
                addCustomer()
            Case "Save Chart of Account[F4]"
                addAccount()
            Case "Save Supplier[F4]"
                addSupplier()
            Case "Save Income Income Statement[F4]"
                addIncome()
            Case "Save Owner's Equity Statement[F4]"
                addOwners()
            Case "Save Entry[F4]"
                addSpecialJournal()
                forBtnSave()
                clearAllTextBox()
                frmSpecialJournalControlDisable()
            Case "Save Journal Type[F4]"
                addJournalType()
                clearTextBoxInJounalType()
                disableJournalType()
                forBtnSave()
            Case "Save Status[F4]"
                addChartStatus()
            Case "Save Type[F4]"
                addChartType()
            Case "Save Status and Type[F4]"
                addChartTypeandStatus()
            Case "Save Customer Type[F4]"
                addCustomerType()
            Case "Save Department[F4]"
                addDepartment()
            Case "Save User[F4]"
                addEmployee()
            Case Else
                MessageBox.Show("Undefine Data")
        End Select

    End Sub
End Module

Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing

Public Class frmMain

    Private Sub SupplierToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        showSupplier()
    End Sub
    Private Sub MenuSummarizeResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        showTrialBalance()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolChild.Click

        'Close the Current Active Child Form ni Multiple Document Interface(MDI)
        For Each child As Form In Me.MdiChildren
            child.Close()

            formCloseCRUDHide()
            'If con.State = ConnectionState.Open Then
            '    con.Close()
            'End If
            ' frmSalesJournal.UpdateBinding()
        Next
        'If con.State = ConnectionState.Open Then
        '    con.Close()
        'End If
        'Show the current click child form in Multiple Document Interface(MDI)

    End Sub

    Public Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' LoadMainFrmRecordControl()
        DateTimePicker1.Value = DateSerial(Year(DateTimePicker1.Value), Month(DateTimePicker1.Value) + 1, 0)
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        accountPanel.Visible = True
 
        btnCRUDHideMain()
        MainForm()
    End Sub


    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub



    Private Sub toolSaveRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolSaveRecord.Click
        addRecordControl()
        'chartSaveRecord()
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'Using shortcut Function to add,update,save Record
        ' Case Keys.F5
        'toolUpdateRecord_Click(Me, EventArgs.Empty)
        If toolSaveRecord.Enabled = True And toolSaveRecord.Visible = True Then
            Select Case keyData
                Case Keys.F4
                    toolSaveRecord_Click(Me, EventArgs.Empty)
                Case Else
                    'Do Nothing
            End Select
        Else

        End If
        If toolUpdateRecord.Enabled = True And toolUpdateRecord.Visible = True Then
            Select Case keyData

                Case Keys.F5
                    toolUpdateRecord_Click(Me, EventArgs.Empty)
                Case Else
                    'Do Nothing
            End Select
        Else

        End If
        'ElseIf toolAddRecord.Enabled = True Then
        If toolAddRecord.Visible = True Then
            Select Case keyData
                Case Keys.F3
                    toolAddRecord_Click(Me, EventArgs.Empty)
                Case Else

            End Select
        Else

        End If
        
        If toolCancel.Visible = True Then
            Select Case keyData
                Case Keys.Escape
                    toolCancel_Click(Me, EventArgs.Empty)
                    clearAllTextBox()
            End Select
        Else

        End If
        
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    ' case statement for insert record in database
    
    'live running time using timer event
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        toolTime.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try

            Dim cmd As New SqlCommand("SELECT dbo.usertbl.emplname,dbo.usertbl.position, dbo.usertbl.userpassword, dbo.departmenttbl.departmentname FROM  dbo.departmenttbl INNER JOIN dbo.usertbl ON dbo.departmenttbl.departmentid = dbo.usertbl.departmentid WHERE emplname = '" + txtUsername.Text + "' AND userpassword = '" + txtPassword.Text + "' ", con)
            Dim myreaders As SqlDataReader
            myreaders = cmd.ExecuteReader
            myreaders.Read()

            'With cmd
            '    .CommandType = CommandType.StoredProcedure
            '    .CommandText = "login"
            '    .Connection = con
            '    .Parameters.Clear()
            '    ' .Parameters.Add("@purchaseid", SqlDbType.Text).Value = frmPurchase.txtPurchaseId.Text
            '    .Parameters.Add("@username", SqlDbType.Text).Value = txtUsername.Text.Trim
            '    .Parameters.Add("@password", SqlDbType.Text).Value = txtPassword.Text.Trim
            'End With
            'Dim myreaders As SqlDataReader
            'myreaders = cmd.ExecuteReader
            'myreaders.Read()

            If myreaders.HasRows Then
                accountPanel.Visible = False

                ' Dim usenamef As String
                'username = Me.Status.Items(1).Text.Substring(0, 1).ToUpper + Me.Status.Items(1).Text.Substring(1)
                MsgBox("Login Successful!", vbInformation, "Note")
                Me.Status.Items(1).Text = myreaders.Item("emplname").ToString
                Me.Status.Items(3).Text = myreaders.Item("position").ToString

                If Me.Status.Items(3).Text = "Accountant" Then
                    MenuStrip1.Show()
                    ToolStrip1.Show()
                    Accountant()
                ElseIf Me.Status.Items(3).Text = "Auditor" Then
                    Auditor()
                    MenuStrip1.Show()
                    ToolStrip1.Show()
                ElseIf Me.Status.Items(3).Text = "Administrator" Then
                    MenuStrip1.Show()
                    ToolStrip1.Show()
                    Administrator()

                End If

            Else
                MsgBox("Login Failed")
            End If
            toolChild.Visible = False
            myreaders.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    'disable all module

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to Logout ", _
                              "Confirm", MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            For Each ctr As Control In accountPanel.Controls
                If TypeOf ctr Is TextBox Then
                    ctr.Text = ""
                End If
            Next
            Me.Status.Items(1).Text = ""
            Me.Status.Items(3).Text = ""
            Logout()
            
            For Each child As Form In MdiChildren
                child.Close()

            Next
        Else

        End If
        Bar1.Visible = False
        dataPanel.Visible = False
    End Sub

    Private Sub closeConnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Private Sub NewReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewReportToolStripMenuItem.Click
        showReportTrialBalance()
    End Sub

    Private Sub toolUpdateRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolUpdateRecord.Click
        updateRecordControl()
        updateRecordModule()
    End Sub

    Private Sub ButtonItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If reader.IsClosed Then
        '    reader.Read()
        'End If
        ' Dim frmCustomer As String = "Customer"
        'Search()
    End Sub

    Private Sub TextBoxX1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            searchRecordControl()
            TextBoxX1.Clear()
        End If      
    End Sub

    Private Sub IncomeStatementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncomeStatementToolStripMenuItem.Click
        showIncomeStatement()
    End Sub

    Private Sub OwnersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OwnersToolStripMenuItem.Click
        showOwners()
    End Sub

    Private Sub BalanceSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BalanceSheetToolStripMenuItem.Click
        showBalanceSheet()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        ' Dim searchRecord As String
        'searchRecord = DateTimePicker1.Value.ToString("MMMM dd yyyy")
        DateTimePicker1.Value = DateSerial(Year(DateTimePicker1.Value), Month(DateTimePicker1.Value) + 1, 0)
        filterDateRecordControl()
            '  frmOwners.DateTimePicker1.Value = frmOwners.DateTimePicker1.Value.AddMonths(-1)


    End Sub

    Public Sub toolAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolAddRecord.Click
        EnableaddRecordControl()
        'Cancel Adding of Record
        'CancelRecordControl()

    End Sub


    Private Sub toolCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolCancel.Click
        cancelAddRecordControl()
        clearAllTextBox()
    End Sub

    Private Sub SpecialJournalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialJournalToolStripMenuItem.Click
        showSpecialJournal()
    End Sub

    Private Sub AddNewDepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewDepartmentToolStripMenuItem.Click
        showDepartment()
    End Sub

    Private Sub RegisterUserAccountToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterUserAccountToolStripMenuItem.Click
        showEmployee()
    End Sub

    Private Sub GeneralLedgerToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralLedgerToolStripMenuItem2.Click
        showGeneralLedger()
    End Sub

    Private Sub TrialBalanceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrialBalanceToolStripMenuItem1.Click
        showTrialBalance()
    End Sub


    Private Sub AddSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSupplierToolStripMenuItem.Click
        showSupplier()
    End Sub

    Private Sub AddCustomerInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomerInfoToolStripMenuItem.Click
        showCustomer()
    End Sub

    Private Sub AddChartOfAccountToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddChartOfAccountToolStripMenuItem1.Click
        showAccount()
    End Sub

    Private Sub JournalTypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JournalTypeToolStripMenuItem.Click
        showJournalType()
        hideChartStatusandType()
        hidecustomerType()
    End Sub

    Private Sub CustomerTypeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerTypeToolStripMenuItem1.Click
        showcustomerType()
        hideJournaTypePanel()
        hideChartStatusandType()
    End Sub

    Private Sub AccountTypeAndStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccountTypeAndStatusToolStripMenuItem.Click
        showChartStatusandType()
        hideJournaTypePanel()
        hidecustomerType()
    End Sub
End Class

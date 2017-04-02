Imports System.Data.SqlClient
Public Class frmLogin

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        sdaa = New SqlDataAdapter("select status from logintbl WHERE userName = '" + txtUsername.Text + "' AND passWord = '" + txtPassword.Text + "' ", con)
        dt = New DataTable()
        sdaa.Fill(dt)
        If dt.Rows.Count = 1 Then

            MsgBox("Login Successful!", vbInformation, "Note")
            frmMain.Status.Items(1).Text = Trim(txtUsername.Text).Substring(0, 1).ToUpper + Trim(txtUsername.Text).Substring(1)
            frmMain.Status.Items(2).Text = Trim(txtPassword.Text)
            Dim datenow As Date = Now
            'frmMain.Status.Items(6).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
            Me.Hide()
            frmMain.Show()

            If frmMain.Status.Items(1).Text = "mula" Or frmMain.Status.Items(2).Text = "argie" Then
                disable()
            Else
                'cbo_role .Text ="Manager" then
                'frmMain.Button3.Enabled = False
                'frmMain.Button11.Enabled = False

            End If
        End If

        ''Try
        ''    If Trim(txtUsername.Text) = "" Or Trim(txtPassword.Text) = "" Then
        ''        MsgBox("Please fill all Fields!", vbInformation, "Note")
        ''    Else
        ''        ' con.Open()
        ''        Dim Oledb = "SELECT userName,passWord FROM logintbl WHERE userName = '" & txtUsername.Text & "' AND passWord = '" & txtPassword.Text & "' "

        ''        Dim cmds = New SqlCommand(Oledb, con)
        ''        Dim drs As SqlDataReader = cmds.ExecuteReader

        ''        'Try
        ''        If drs.Read = False Then
        ''            MsgBox("Login Failed!", vbCritical, "Note")
        ''        Else
        ''            MsgBox("Login Successful!", vbInformation, "Note")
        ''            frmMain.Status.Items(2).Text = Trim(txtUsername.Text)
        ''            frmMain.Status.Items(3).Text = Trim(txtPassword.Text)
        ''            Dim datenow As Date = Now
        ''            'frmMain.Status.Items(6).Text = "Date and Time : " & datenow.ToString("MMMM dd, yyyy") & " " & TimeOfDay
        ''            con.Close()
        ''            Me.Hide()

        ''            'Control authentication
        ''            ''If cbo_role.Text = "Accountant" Or cbo_role.Text = "Teller" Then
        ''            ''    disable()
        ''            ''Else
        ''            ''    'cbo_role .Text ="Manager" then
        ''            ''    'frmMain.Button3.Enabled = False
        ''            ''    'frmMain.Button11.Enabled = False
        ''            ''    frmMain1.Button2.Enabled = False
        ''            ''End If

        ''            frmMain.ShowDialog()
        ''        End If

        ''        con.Close()

        ''    End If
        ''Catch ex As Exception
        ''    MsgBox("Please make sure you are connected to the network", ex.Message.ToString)
        ''End Try
    End Sub
    Private Sub disable()
        frmMain.JournalToolStripMenuItem.Enabled = False


        frmMain.SummarizingToolStripMenuItem.Enabled = False
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class
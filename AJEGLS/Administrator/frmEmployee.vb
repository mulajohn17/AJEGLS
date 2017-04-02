Public Class frmEmployee

    Private Sub frmEmployee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        retrieveDepartment()
    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress, txtlname.KeyPress, txtmname.KeyPress, txtposition.KeyPress
        Dim notAllowed As String = "`~!@#$%^&*()_=+[{[};:'\|<,>?/0123456789"

        If e.KeyChar <> ControlChars.Back = True Then
            If notAllowed.IndexOf(e.KeyChar) = -1 = False Then
                MessageBox.Show("Invalid input, Please input letters only!")

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcontact_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcontact.KeyPress
      
    End Sub

End Class
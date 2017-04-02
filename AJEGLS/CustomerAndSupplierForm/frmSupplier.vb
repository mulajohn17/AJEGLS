Public Class frmSupplier

    Public Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'TODO: This line of code loads data into the 'SupplierList._supplierlist' table. You can move, or remove it, as needed.
        Me.SupplierlistTableAdapter.Fill(Me.SupplierList._supplierlist)
        DataGridViewX1.Columns(0).Visible = False
        DataGridViewX1.Columns(3).Visible = False
        DataGridViewX1.Columns(4).Visible = False
        DataGridViewX1.Columns(6).Visible = False
        supplierautocomplete()
        autoSupplierFrm()
    End Sub

    Private Sub DataGridViewX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewX1.Click
        supplierPassData()
        If txtSupplierId.Text = "" Then
        Else

            frmMain.toolUpdateRecord.Visible = True
            frmMain.toolCancel.Visible = False
            frmMain.toolAddRecord.Visible = True
            frmMain.toolSaveRecord.Visible = False
        End If
    End Sub

    Private Sub DataGridViewX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX1.KeyDown, DataGridViewX1.KeyUp
        supplierPassData()
        If txtSupplierId.Text = "" Then
        Else
            
                frmMain.toolUpdateRecord.Visible = True
                frmMain.toolCancel.Visible = False
                frmMain.toolAddRecord.Visible = True
                frmMain.toolSaveRecord.Visible = False
        End If
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim imgdlg As FileDialog = New OpenFileDialog()
        If String.IsNullOrEmpty(txtSupplierId.Text = "") Then
            Exit Sub
        Else
            imgdlg.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png"
            If imgdlg.ShowDialog() = DialogResult.OK Then
                picStr = imgdlg.FileName
            Else
                picStr = ""
                Exit Sub
            End If
            picImage.Image = Bitmap.FromFile(picStr)
        End If
    End Sub
    Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
        Dim item = CType(sender, ToolStripMenuItem)
        Dim selection = CInt(item.Tag)

    End Sub

    Private Sub PanelEx1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PanelEx1.MouseUp, DataGridViewX1.MouseUp, GroupPanel1.MouseUp, GroupPanel2.MouseUp, panelSupplier.MouseUp
        If e.Button <> Windows.Forms.MouseButtons.Right Then Return
        Dim cms = New ContextMenuStrip
        Dim item1 = cms.Items.Add("Refresh")
        item1.Tag = 1
        AddHandler item1.Click, AddressOf menuChoice
        frmSupplier_Load(sender, e)
        cms.Show(PanelEx1, e.Location)
    End Sub

    Private Sub checkLogo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkLogo.CheckedChanged
        If checkLogo.Checked = True Then
            picImage.Image = My.Resources.noimage
            btnBrowse.Enabled = False
        Else
            btnBrowse.Enabled = True
        End If
    End Sub

    Private Sub txtCompanyName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCompanyName.KeyPress, txtBuildingNo.KeyPress, txtCity.KeyPress, txtContact.KeyPress, txtPoblacion.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub checkLogo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles checkLogo.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnBrowse.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub btnLinkSave_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles btnLinkSave.LinkClicked
        addSupplier()
        retrieveSupplierName()
        frmSpecialJournal.comboSupplier.Text = txtCompanyName.Text
    End Sub
End Class
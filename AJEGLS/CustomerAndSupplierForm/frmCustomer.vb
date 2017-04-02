Imports System.IO
Imports System.Math
Imports System.Drawing.Imaging
Imports System.Data.SqlClient

Public Class frmCustomer


    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        Dim imgdlg As FileDialog = New OpenFileDialog()
        If String.IsNullOrEmpty(txtCustomerId.Text = "") Then
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

    Public Sub frmCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomerList._customerlist' table. You can move, or remove it, as needed.
        Me.CustomerlistTableAdapter.FillCustomer(Me.CustomerList._customerlist)
        'TODO: This line of code loads data into the 'CustomerList._customerlist' table. You can move, or remove it, as needed.
        '  Me.CustomerlistTableAdapter.FillCustomer(Me.CustomerList._customerlist)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
 
        DataGridViewX1.Columns(0).Visible = False
        DataGridViewX1.Columns(4).Visible = False
        DataGridViewX1.Columns(6).Visible = False
        DataGridViewX1.Columns(7).Visible = False
        DataGridViewX1.Columns(8).Visible = False
        DataGridViewX1.Columns(10).Visible = False
        customerautocomplete()
        retrieveCustomerType()
        customerFrmAuto()
    End Sub

    Private Sub DataGridViewX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewX1.Click

        Try
            customerPassData()

            Dim ms As New MemoryStream(changeimage(CInt(DataGridViewX1.Rows(DataGridViewX1.CurrentRow.Index).Cells(11).Value)))
            picImage.Image = Image.FromStream(ms)

        Catch ex As Exception

        End Try
        If txtCustomerId.Text = "" Then
        Else
            frmMain.toolUpdateRecord.Visible = True
            frmMain.toolCancel.Visible = False
            frmMain.toolAddRecord.Visible = True
            frmMain.toolSaveRecord.Visible = False
        End If
      
    End Sub

    Function changeimage(ByVal photo As Integer) As Byte()
        With cmd
            .CommandType = CommandType.Text
            .Connection = con
            ' .CommandText = "select pictures from customertbl where customerId =" & DataGridViewX1.SelectedRows(0).Cells(11).Value
            .CommandText = "select pictures from customertbl where customerId =" & DataGridViewX1.Rows(DataGridViewX1.CurrentRow.Index).Cells(11).Value
        End With
        sdaa.SelectCommand = cmd
        Dim myphoto() As Byte = CType(cmd.ExecuteScalar(), Byte())
        con.Close()
        Return myphoto
    End Function

    Private Sub DataGridViewX1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX1.KeyDown, DataGridViewX1.KeyUp
        Try
            customerPassData()
            Dim ms As New MemoryStream(changeimage(CInt(DataGridViewX1.SelectedCells(10).Value)))
            picImage.Image = Image.FromStream(ms)
        Catch ex As Exception

        End Try
        If txtCustomerId.Text = "" Then
        Else
            frmMain.toolUpdateRecord.Visible = True
            frmMain.toolCancel.Visible = False
            frmMain.toolAddRecord.Visible = True
            frmMain.toolSaveRecord.Visible = False
        End If
    End Sub

    Private Sub retrieveparameters()
        If Not (picImage.Image Is Nothing) Then
            Dim ms As New MemoryStream
            picImage.Image.Save(ms, Drawing.Imaging.ImageFormat.Bmp)
            Dim pic() As Byte = ms.ToArray()
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("pictures", pic)
        End If
        Dim sql As String
        sql = "select pictures from customertbl where customerId = "

    End Sub


    Private Sub RetrieveCustomer()

        'sql = "select * from customertbl"
        'cmd = New SqlCommand(sql, con)
        'sdaa = New SqlDataAdapter(cmd)
        'ds = New DataSet
        'sdaa.Fill(ds, "customertbl")
        'ds.Tables(0).DefaultView.Sort = "customerId"

        '  bs.DataSource = Me.CustomerlistTableAdapter.FillCustomer(Me.CustomerList._customerlist)
        bs.Position = DataGridViewX1.Rows(DataGridViewX1.CurrentRow.Index).Cells(11).Value

        picImage.DataBindings.Add("Image", bs, "pictures", True)

    End Sub

    Private Sub checkPictures_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkPictures.CheckedChanged
        If checkPictures.Checked = True Then
            picImage.Image = My.Resources.noimage
            btnBrowse.Enabled = False
        Else
            btnBrowse.Enabled = True
        End If
    End Sub

    Private Sub txtfname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfname.KeyPress, txtlname.KeyPress, txtmname.KeyPress, txtBarangay.KeyPress, txtContact.KeyPress, txtHouseNo.KeyPress, txtMunicipality.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub cbType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbType.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub checkPictures_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles checkPictures.KeyPress
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
        addCustomer()
        retrieveCustomerName()
        frmSpecialJournal.comboCustomer.Text = txtlname.Text + "," + txtfname.Text + " " + txtfname.Text
    End Sub
End Class
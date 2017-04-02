<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndex
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SideBarPanelItem1 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.SideBarPanelItem2 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem6 = New DevComponents.DotNetBar.ButtonItem()
        Me.SideBarPanelItem3 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.SideBarPanelItem4 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem8 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.SideBarPanelItem5 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem9 = New DevComponents.DotNetBar.ButtonItem()
        Me.SideBarPanelItem6 = New DevComponents.DotNetBar.SideBarPanelItem()
        Me.ButtonItem11 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem13 = New DevComponents.DotNetBar.ButtonItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SideBarPanelItem1
        '
        Me.SideBarPanelItem1.FontBold = True
        Me.SideBarPanelItem1.Name = "SideBarPanelItem1"
        Me.SideBarPanelItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2, Me.ButtonItem3, Me.ButtonItem4, Me.ButtonItem5})
        Me.SideBarPanelItem1.Text = "Journals"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Text = "Sales Journal"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Text = "Purchase Journal"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Text = "&Cash Receipt Journal"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Text = "Cash &Disbursement Journal"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.Text = "General Journal"
        '
        'SideBarPanelItem2
        '
        Me.SideBarPanelItem2.FontBold = True
        Me.SideBarPanelItem2.Name = "SideBarPanelItem2"
        Me.SideBarPanelItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem6})
        Me.SideBarPanelItem2.Text = "Supplier"
        '
        'ButtonItem6
        '
        Me.ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem6.Name = "ButtonItem6"
        Me.ButtonItem6.Text = "Supplier"
        '
        'SideBarPanelItem3
        '
        Me.SideBarPanelItem3.FontBold = True
        Me.SideBarPanelItem3.Name = "SideBarPanelItem3"
        Me.SideBarPanelItem3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem7})
        Me.SideBarPanelItem3.Text = "Customer"
        '
        'ButtonItem7
        '
        Me.ButtonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem7.Name = "ButtonItem7"
        Me.ButtonItem7.Text = "Customer"
        '
        'SideBarPanelItem4
        '
        Me.SideBarPanelItem4.FontBold = True
        Me.SideBarPanelItem4.Name = "SideBarPanelItem4"
        Me.SideBarPanelItem4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem8, Me.ButtonItem10})
        Me.SideBarPanelItem4.Text = "Summarize Journal"
        '
        'ButtonItem8
        '
        Me.ButtonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem8.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem8.Name = "ButtonItem8"
        Me.ButtonItem8.Text = "Summarize Journals"
        '
        'ButtonItem10
        '
        Me.ButtonItem10.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem10.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem10.Name = "ButtonItem10"
        Me.ButtonItem10.Text = "Trial Balance"
        '
        'SideBarPanelItem5
        '
        Me.SideBarPanelItem5.FontBold = True
        Me.SideBarPanelItem5.Name = "SideBarPanelItem5"
        Me.SideBarPanelItem5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem9})
        Me.SideBarPanelItem5.Text = "Chart of Accounts"
        '
        'ButtonItem9
        '
        Me.ButtonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem9.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem9.Name = "ButtonItem9"
        Me.ButtonItem9.Text = "Accounts"
        '
        'SideBarPanelItem6
        '
        Me.SideBarPanelItem6.FontBold = True
        Me.SideBarPanelItem6.Name = "SideBarPanelItem6"
        Me.SideBarPanelItem6.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem11, Me.ButtonItem12, Me.ButtonItem13})
        Me.SideBarPanelItem6.Text = "Reports"
        '
        'ButtonItem11
        '
        Me.ButtonItem11.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem11.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem11.Name = "ButtonItem11"
        Me.ButtonItem11.Text = "Income Statement Report"
        '
        'ButtonItem12
        '
        Me.ButtonItem12.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem12.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem12.Name = "ButtonItem12"
        Me.ButtonItem12.Text = "Balance Sheet Report"
        '
        'ButtonItem13
        '
        Me.ButtonItem13.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem13.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top
        Me.ButtonItem13.Name = "ButtonItem13"
        Me.ButtonItem13.Text = "Owner's Equity Report"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(533, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmIndex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 510)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmIndex"
        Me.Text = "frmIndex"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SideBarPanelItem1 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SideBarPanelItem2 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SideBarPanelItem3 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SideBarPanelItem4 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem8 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SideBarPanelItem5 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem9 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents SideBarPanelItem6 As DevComponents.DotNetBar.SideBarPanelItem
    Friend WithEvents ButtonItem11 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem13 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJournalType
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgJournalType = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.journalGroupPanel = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtJournalType = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chartGroupPanel = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.checkChartType = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.checkChartStatus = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.txtChartType = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChartStatus = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.customerTypePanel = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtCustomerType = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.dgJournalType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.journalGroupPanel.SuspendLayout()
        Me.chartGroupPanel.SuspendLayout()
        Me.customerTypePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.customerTypePanel)
        Me.PanelEx1.Controls.Add(Me.GroupPanel1)
        Me.PanelEx1.Controls.Add(Me.journalGroupPanel)
        Me.PanelEx1.Controls.Add(Me.chartGroupPanel)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1106, 480)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.dgJournalType)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(270, 135)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(679, 216)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 2
        '
        'dgJournalType
        '
        Me.dgJournalType.AllowUserToAddRows = False
        Me.dgJournalType.AllowUserToDeleteRows = False
        Me.dgJournalType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgJournalType.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgJournalType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgJournalType.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgJournalType.Location = New System.Drawing.Point(0, 0)
        Me.dgJournalType.Name = "dgJournalType"
        Me.dgJournalType.ReadOnly = True
        Me.dgJournalType.Size = New System.Drawing.Size(673, 210)
        Me.dgJournalType.TabIndex = 0
        '
        'journalGroupPanel
        '
        Me.journalGroupPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.journalGroupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.journalGroupPanel.Controls.Add(Me.txtJournalType)
        Me.journalGroupPanel.Controls.Add(Me.Label1)
        Me.journalGroupPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.journalGroupPanel.Location = New System.Drawing.Point(270, 75)
        Me.journalGroupPanel.Name = "journalGroupPanel"
        Me.journalGroupPanel.Size = New System.Drawing.Size(679, 54)
        '
        '
        '
        Me.journalGroupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.journalGroupPanel.Style.BackColorGradientAngle = 90
        Me.journalGroupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.journalGroupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.journalGroupPanel.Style.BorderBottomWidth = 1
        Me.journalGroupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.journalGroupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.journalGroupPanel.Style.BorderLeftWidth = 1
        Me.journalGroupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.journalGroupPanel.Style.BorderRightWidth = 1
        Me.journalGroupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.journalGroupPanel.Style.BorderTopWidth = 1
        Me.journalGroupPanel.Style.CornerDiameter = 4
        Me.journalGroupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.journalGroupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.journalGroupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.journalGroupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.journalGroupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.journalGroupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.journalGroupPanel.TabIndex = 5
        Me.journalGroupPanel.Text = "Journal Type"
        '
        'txtJournalType
        '
        '
        '
        '
        Me.txtJournalType.Border.Class = "TextBoxBorder"
        Me.txtJournalType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJournalType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJournalType.Location = New System.Drawing.Point(118, 3)
        Me.txtJournalType.Name = "txtJournalType"
        Me.txtJournalType.PreventEnterBeep = True
        Me.txtJournalType.Size = New System.Drawing.Size(296, 26)
        Me.txtJournalType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Journal Type:"
        '
        'chartGroupPanel
        '
        Me.chartGroupPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.chartGroupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.chartGroupPanel.Controls.Add(Me.checkChartType)
        Me.chartGroupPanel.Controls.Add(Me.checkChartStatus)
        Me.chartGroupPanel.Controls.Add(Me.txtChartType)
        Me.chartGroupPanel.Controls.Add(Me.Label3)
        Me.chartGroupPanel.Controls.Add(Me.txtChartStatus)
        Me.chartGroupPanel.Controls.Add(Me.Label2)
        Me.chartGroupPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.chartGroupPanel.Location = New System.Drawing.Point(270, 76)
        Me.chartGroupPanel.Name = "chartGroupPanel"
        Me.chartGroupPanel.Size = New System.Drawing.Size(679, 54)
        '
        '
        '
        Me.chartGroupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.chartGroupPanel.Style.BackColorGradientAngle = 90
        Me.chartGroupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.chartGroupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.chartGroupPanel.Style.BorderBottomWidth = 1
        Me.chartGroupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.chartGroupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.chartGroupPanel.Style.BorderLeftWidth = 1
        Me.chartGroupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.chartGroupPanel.Style.BorderRightWidth = 1
        Me.chartGroupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.chartGroupPanel.Style.BorderTopWidth = 1
        Me.chartGroupPanel.Style.CornerDiameter = 4
        Me.chartGroupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.chartGroupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.chartGroupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.chartGroupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.chartGroupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.chartGroupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chartGroupPanel.TabIndex = 4
        '
        'checkChartType
        '
        '
        '
        '
        Me.checkChartType.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkChartType.Location = New System.Drawing.Point(649, 8)
        Me.checkChartType.Name = "checkChartType"
        Me.checkChartType.Size = New System.Drawing.Size(14, 23)
        Me.checkChartType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkChartType.TabIndex = 5
        '
        'checkChartStatus
        '
        '
        '
        '
        Me.checkChartStatus.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkChartStatus.Location = New System.Drawing.Point(320, 6)
        Me.checkChartStatus.Name = "checkChartStatus"
        Me.checkChartStatus.Size = New System.Drawing.Size(14, 23)
        Me.checkChartStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkChartStatus.TabIndex = 4
        '
        'txtChartType
        '
        '
        '
        '
        Me.txtChartType.Border.Class = "TextBoxBorder"
        Me.txtChartType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtChartType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChartType.Location = New System.Drawing.Point(449, 5)
        Me.txtChartType.Name = "txtChartType"
        Me.txtChartType.PreventEnterBeep = True
        Me.txtChartType.Size = New System.Drawing.Size(194, 26)
        Me.txtChartType.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(340, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Chart Type:"
        '
        'txtChartStatus
        '
        '
        '
        '
        Me.txtChartStatus.Border.Class = "TextBoxBorder"
        Me.txtChartStatus.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtChartStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChartStatus.Location = New System.Drawing.Point(118, 4)
        Me.txtChartStatus.Name = "txtChartStatus"
        Me.txtChartStatus.PreventEnterBeep = True
        Me.txtChartStatus.Size = New System.Drawing.Size(195, 26)
        Me.txtChartStatus.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Chart Status:"
        '
        'customerTypePanel
        '
        Me.customerTypePanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.customerTypePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.customerTypePanel.Controls.Add(Me.txtCustomerType)
        Me.customerTypePanel.Controls.Add(Me.Label4)
        Me.customerTypePanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.customerTypePanel.Location = New System.Drawing.Point(269, 75)
        Me.customerTypePanel.Name = "customerTypePanel"
        Me.customerTypePanel.Size = New System.Drawing.Size(679, 54)
        '
        '
        '
        Me.customerTypePanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.customerTypePanel.Style.BackColorGradientAngle = 90
        Me.customerTypePanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.customerTypePanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.customerTypePanel.Style.BorderBottomWidth = 1
        Me.customerTypePanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.customerTypePanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.customerTypePanel.Style.BorderLeftWidth = 1
        Me.customerTypePanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.customerTypePanel.Style.BorderRightWidth = 1
        Me.customerTypePanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.customerTypePanel.Style.BorderTopWidth = 1
        Me.customerTypePanel.Style.CornerDiameter = 4
        Me.customerTypePanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.customerTypePanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.customerTypePanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.customerTypePanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.customerTypePanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.customerTypePanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.customerTypePanel.TabIndex = 6
        Me.customerTypePanel.Text = "Customer Type"
        '
        'txtCustomerType
        '
        '
        '
        '
        Me.txtCustomerType.Border.Class = "TextBoxBorder"
        Me.txtCustomerType.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCustomerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerType.Location = New System.Drawing.Point(131, 3)
        Me.txtCustomerType.Name = "txtCustomerType"
        Me.txtCustomerType.PreventEnterBeep = True
        Me.txtCustomerType.Size = New System.Drawing.Size(296, 26)
        Me.txtCustomerType.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Customer Type:"
        '
        'frmJournalType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1106, 480)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmJournalType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.dgJournalType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.journalGroupPanel.ResumeLayout(False)
        Me.journalGroupPanel.PerformLayout()
        Me.chartGroupPanel.ResumeLayout(False)
        Me.chartGroupPanel.PerformLayout()
        Me.customerTypePanel.ResumeLayout(False)
        Me.customerTypePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtJournalType As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dgJournalType As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents chartGroupPanel As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtChartType As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtChartStatus As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents checkChartType As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checkChartStatus As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents journalGroupPanel As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents customerTypePanel As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtCustomerType As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceSheet
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel5 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lbtempecapital = New DevComponents.DotNetBar.LabelX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.txtcreditgrandtotal = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.EndingCapitalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SavedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnersequityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OwnersEquity = New AJEGLS.OwnersEquity()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DataGridViewX3 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ecapitaltotal = New DevComponents.DotNetBar.LabelX()
        Me.txttotalcredit = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txttotaldebit = New DevComponents.DotNetBar.LabelX()
        Me.lbcredit = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.OwnersequityTableAdapter = New AJEGLS.OwnersEquityTableAdapters.ownersequityTableAdapter()
        Me.LoadLiabities = New AJEGLS.LoadLiabities()
        Me.LoadliabilitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadliabilitiesTableAdapter = New AJEGLS.LoadLiabitiesTableAdapters.loadliabilitiesTableAdapter()
        Me.Loadassetsandliabilities = New AJEGLS.loadassetsandliabilities()
        Me.AssetsandliabilitiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssetsandliabilitiesTableAdapter = New AJEGLS.loadassetsandliabilitiesTableAdapters.assetsandliabilitiesTableAdapter()
        Me.ParticularsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParticularsDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharttypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEARDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel5.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnersequityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnersEquity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel4.SuspendLayout()
        CType(Me.DataGridViewX3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadLiabities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadliabilitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Loadassetsandliabilities, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssetsandliabilitiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel5)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1191, 527)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'GroupPanel5
        '
        Me.GroupPanel5.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel5.Controls.Add(Me.lbtempecapital)
        Me.GroupPanel5.Controls.Add(Me.Line1)
        Me.GroupPanel5.Controls.Add(Me.txtcreditgrandtotal)
        Me.GroupPanel5.Controls.Add(Me.GroupPanel2)
        Me.GroupPanel5.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel5.Controls.Add(Me.LabelX5)
        Me.GroupPanel5.Controls.Add(Me.GroupPanel4)
        Me.GroupPanel5.Controls.Add(Me.LabelX2)
        Me.GroupPanel5.Controls.Add(Me.ecapitaltotal)
        Me.GroupPanel5.Controls.Add(Me.txttotalcredit)
        Me.GroupPanel5.Controls.Add(Me.LabelX4)
        Me.GroupPanel5.Controls.Add(Me.txttotaldebit)
        Me.GroupPanel5.Controls.Add(Me.lbcredit)
        Me.GroupPanel5.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel5.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel5.Name = "GroupPanel5"
        Me.GroupPanel5.Size = New System.Drawing.Size(1191, 527)
        '
        '
        '
        Me.GroupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel5.Style.BackColorGradientAngle = 90
        Me.GroupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderBottomWidth = 1
        Me.GroupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderLeftWidth = 1
        Me.GroupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderRightWidth = 1
        Me.GroupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel5.Style.BorderTopWidth = 1
        Me.GroupPanel5.Style.CornerDiameter = 4
        Me.GroupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel5.TabIndex = 53
        Me.GroupPanel5.Text = "Balance Sheet"
        '
        'lbtempecapital
        '
        '
        '
        '
        Me.lbtempecapital.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbtempecapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtempecapital.Location = New System.Drawing.Point(859, 486)
        Me.lbtempecapital.Name = "lbtempecapital"
        Me.lbtempecapital.Size = New System.Drawing.Size(120, 23)
        Me.lbtempecapital.TabIndex = 54
        Me.lbtempecapital.Text = "0.00"
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(9, 421)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(1167, 16)
        Me.Line1.TabIndex = 53
        Me.Line1.Text = "Line1"
        '
        'txtcreditgrandtotal
        '
        '
        '
        '
        Me.txtcreditgrandtotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtcreditgrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcreditgrandtotal.Location = New System.Drawing.Point(1037, 434)
        Me.txtcreditgrandtotal.Name = "txtcreditgrandtotal"
        Me.txtcreditgrandtotal.Size = New System.Drawing.Size(120, 23)
        Me.txtcreditgrandtotal.TabIndex = 52
        Me.txtcreditgrandtotal.Text = "0.00"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.DataGridViewX2)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(593, 241)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(564, 158)
        '
        '
        '
        Me.GroupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel2.Style.BackColorGradientAngle = 90
        Me.GroupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderBottomWidth = 1
        Me.GroupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderLeftWidth = 1
        Me.GroupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderRightWidth = 1
        Me.GroupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel2.Style.BorderTopWidth = 1
        Me.GroupPanel2.Style.CornerDiameter = 4
        Me.GroupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel2.TabIndex = 41
        Me.GroupPanel2.Text = "Owner's Equity"
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.AutoGenerateColumns = False
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EndingCapitalDataGridViewTextBoxColumn, Me.SavedateDataGridViewTextBoxColumn})
        Me.DataGridViewX2.DataSource = Me.OwnersequityBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.ReadOnly = True
        Me.DataGridViewX2.Size = New System.Drawing.Size(558, 137)
        Me.DataGridViewX2.TabIndex = 0
        '
        'EndingCapitalDataGridViewTextBoxColumn
        '
        Me.EndingCapitalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EndingCapitalDataGridViewTextBoxColumn.DataPropertyName = "EndingCapital"
        Me.EndingCapitalDataGridViewTextBoxColumn.HeaderText = "Ending Capital"
        Me.EndingCapitalDataGridViewTextBoxColumn.Name = "EndingCapitalDataGridViewTextBoxColumn"
        Me.EndingCapitalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SavedateDataGridViewTextBoxColumn
        '
        Me.SavedateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SavedateDataGridViewTextBoxColumn.DataPropertyName = "savedate"
        Me.SavedateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.SavedateDataGridViewTextBoxColumn.Name = "SavedateDataGridViewTextBoxColumn"
        Me.SavedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OwnersequityBindingSource
        '
        Me.OwnersequityBindingSource.DataMember = "ownersequity"
        Me.OwnersequityBindingSource.DataSource = Me.OwnersEquity
        '
        'OwnersEquity
        '
        Me.OwnersEquity.DataSetName = "OwnersEquity"
        Me.OwnersEquity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(14, 2)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(570, 400)
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
        Me.GroupPanel1.TabIndex = 40
        Me.GroupPanel1.Text = "Assets"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewX1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParticularsDataGridViewTextBoxColumn, Me.DebitDataGridViewTextBoxColumn, Me.CharttypeDataGridViewTextBoxColumn, Me.MonthDataGridViewTextBoxColumn, Me.YEARDataGridViewTextBoxColumn})
        Me.DataGridViewX1.DataSource = Me.AssetsandliabilitiesBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(564, 379)
        Me.DataGridViewX1.TabIndex = 0
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(859, 434)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(75, 23)
        Me.LabelX5.TabIndex = 50
        Me.LabelX5.Text = "Total:"
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.DataGridViewX3)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Location = New System.Drawing.Point(590, 2)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(564, 205)
        '
        '
        '
        Me.GroupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel4.Style.BackColorGradientAngle = 90
        Me.GroupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderBottomWidth = 1
        Me.GroupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderLeftWidth = 1
        Me.GroupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderRightWidth = 1
        Me.GroupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel4.Style.BorderTopWidth = 1
        Me.GroupPanel4.Style.CornerDiameter = 4
        Me.GroupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel4.TabIndex = 41
        Me.GroupPanel4.Text = "Liabilities"
        '
        'DataGridViewX3
        '
        Me.DataGridViewX3.AllowUserToAddRows = False
        Me.DataGridViewX3.AllowUserToDeleteRows = False
        Me.DataGridViewX3.AutoGenerateColumns = False
        Me.DataGridViewX3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewX3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridViewX3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParticularsDataGridViewTextBoxColumn1, Me.CreditDataGridViewTextBoxColumn1, Me.MonthDataGridViewTextBoxColumn1, Me.CharttypeDataGridViewTextBoxColumn1, Me.YEARDataGridViewTextBoxColumn1})
        Me.DataGridViewX3.DataSource = Me.LoadliabilitiesBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewX3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX3.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX3.Name = "DataGridViewX3"
        Me.DataGridViewX3.ReadOnly = True
        Me.DataGridViewX3.Size = New System.Drawing.Size(558, 184)
        Me.DataGridViewX3.TabIndex = 0
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(398, 434)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(49, 23)
        Me.LabelX2.TabIndex = 47
        Me.LabelX2.Text = "Total:"
        '
        'ecapitaltotal
        '
        '
        '
        '
        Me.ecapitaltotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ecapitaltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ecapitaltotal.Location = New System.Drawing.Point(1037, 401)
        Me.ecapitaltotal.Name = "ecapitaltotal"
        Me.ecapitaltotal.Size = New System.Drawing.Size(120, 23)
        Me.ecapitaltotal.TabIndex = 46
        Me.ecapitaltotal.Text = "0.00"
        '
        'txttotalcredit
        '
        '
        '
        '
        Me.txttotalcredit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttotalcredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalcredit.Location = New System.Drawing.Point(1037, 210)
        Me.txttotalcredit.Name = "txttotalcredit"
        Me.txttotalcredit.Size = New System.Drawing.Size(120, 23)
        Me.txttotalcredit.TabIndex = 48
        Me.txttotalcredit.Text = "0.00"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(859, 401)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(161, 23)
        Me.LabelX4.TabIndex = 45
        Me.LabelX4.Text = "Total Owner's Equity:"
        '
        'txttotaldebit
        '
        '
        '
        '
        Me.txttotaldebit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txttotaldebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotaldebit.Location = New System.Drawing.Point(479, 434)
        Me.txttotaldebit.Name = "txttotaldebit"
        Me.txttotaldebit.Size = New System.Drawing.Size(120, 23)
        Me.txttotaldebit.TabIndex = 40
        Me.txttotaldebit.Text = "0.00"
        '
        'lbcredit
        '
        '
        '
        '
        Me.lbcredit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbcredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcredit.Location = New System.Drawing.Point(914, 210)
        Me.lbcredit.Name = "lbcredit"
        Me.lbcredit.Size = New System.Drawing.Size(118, 23)
        Me.lbcredit.TabIndex = 41
        Me.lbcredit.Text = "Total Liabilities:"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(69, 98)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1207, 527)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 4
        '
        'OwnersequityTableAdapter
        '
        Me.OwnersequityTableAdapter.ClearBeforeFill = True
        '
        'LoadLiabities
        '
        Me.LoadLiabities.DataSetName = "LoadLiabities"
        Me.LoadLiabities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoadliabilitiesBindingSource
        '
        Me.LoadliabilitiesBindingSource.DataMember = "loadliabilities"
        Me.LoadliabilitiesBindingSource.DataSource = Me.LoadLiabities
        '
        'LoadliabilitiesTableAdapter
        '
        Me.LoadliabilitiesTableAdapter.ClearBeforeFill = True
        '
        'Loadassetsandliabilities
        '
        Me.Loadassetsandliabilities.DataSetName = "loadassetsandliabilities"
        Me.Loadassetsandliabilities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AssetsandliabilitiesBindingSource
        '
        Me.AssetsandliabilitiesBindingSource.DataMember = "assetsandliabilities"
        Me.AssetsandliabilitiesBindingSource.DataSource = Me.Loadassetsandliabilities
        '
        'AssetsandliabilitiesTableAdapter
        '
        Me.AssetsandliabilitiesTableAdapter.ClearBeforeFill = True
        '
        'ParticularsDataGridViewTextBoxColumn
        '
        Me.ParticularsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ParticularsDataGridViewTextBoxColumn.DataPropertyName = "Particulars"
        Me.ParticularsDataGridViewTextBoxColumn.HeaderText = "Particulars"
        Me.ParticularsDataGridViewTextBoxColumn.Name = "ParticularsDataGridViewTextBoxColumn"
        Me.ParticularsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DebitDataGridViewTextBoxColumn
        '
        Me.DebitDataGridViewTextBoxColumn.DataPropertyName = "Debit"
        Me.DebitDataGridViewTextBoxColumn.HeaderText = "Debit"
        Me.DebitDataGridViewTextBoxColumn.Name = "DebitDataGridViewTextBoxColumn"
        Me.DebitDataGridViewTextBoxColumn.ReadOnly = True
        Me.DebitDataGridViewTextBoxColumn.Width = 250
        '
        'CharttypeDataGridViewTextBoxColumn
        '
        Me.CharttypeDataGridViewTextBoxColumn.DataPropertyName = "charttype"
        Me.CharttypeDataGridViewTextBoxColumn.HeaderText = "charttype"
        Me.CharttypeDataGridViewTextBoxColumn.Name = "CharttypeDataGridViewTextBoxColumn"
        Me.CharttypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MonthDataGridViewTextBoxColumn
        '
        Me.MonthDataGridViewTextBoxColumn.DataPropertyName = "Month"
        Me.MonthDataGridViewTextBoxColumn.HeaderText = "Month"
        Me.MonthDataGridViewTextBoxColumn.Name = "MonthDataGridViewTextBoxColumn"
        Me.MonthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'YEARDataGridViewTextBoxColumn
        '
        Me.YEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.HeaderText = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.Name = "YEARDataGridViewTextBoxColumn"
        Me.YEARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ParticularsDataGridViewTextBoxColumn1
        '
        Me.ParticularsDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ParticularsDataGridViewTextBoxColumn1.DataPropertyName = "Particulars"
        Me.ParticularsDataGridViewTextBoxColumn1.HeaderText = "Particulars"
        Me.ParticularsDataGridViewTextBoxColumn1.Name = "ParticularsDataGridViewTextBoxColumn1"
        Me.ParticularsDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CreditDataGridViewTextBoxColumn1
        '
        Me.CreditDataGridViewTextBoxColumn1.DataPropertyName = "Credit"
        Me.CreditDataGridViewTextBoxColumn1.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn1.Name = "CreditDataGridViewTextBoxColumn1"
        Me.CreditDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CreditDataGridViewTextBoxColumn1.Width = 250
        '
        'MonthDataGridViewTextBoxColumn1
        '
        Me.MonthDataGridViewTextBoxColumn1.DataPropertyName = "Month"
        Me.MonthDataGridViewTextBoxColumn1.HeaderText = "Month"
        Me.MonthDataGridViewTextBoxColumn1.Name = "MonthDataGridViewTextBoxColumn1"
        Me.MonthDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CharttypeDataGridViewTextBoxColumn1
        '
        Me.CharttypeDataGridViewTextBoxColumn1.DataPropertyName = "charttype"
        Me.CharttypeDataGridViewTextBoxColumn1.HeaderText = "charttype"
        Me.CharttypeDataGridViewTextBoxColumn1.Name = "CharttypeDataGridViewTextBoxColumn1"
        Me.CharttypeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'YEARDataGridViewTextBoxColumn1
        '
        Me.YEARDataGridViewTextBoxColumn1.DataPropertyName = "YEAR"
        Me.YEARDataGridViewTextBoxColumn1.HeaderText = "YEAR"
        Me.YEARDataGridViewTextBoxColumn1.Name = "YEARDataGridViewTextBoxColumn1"
        Me.YEARDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'frmBalanceSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 527)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmBalanceSheet"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel5.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnersequityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnersEquity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel4.ResumeLayout(False)
        CType(Me.DataGridViewX3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadLiabities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadliabilitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Loadassetsandliabilities, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssetsandliabilitiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents OwnersEquity As AJEGLS.OwnersEquity
    Friend WithEvents OwnersequityBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OwnersequityTableAdapter As AJEGLS.OwnersEquityTableAdapters.ownersequityTableAdapter
    Friend WithEvents GroupPanel5 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtcreditgrandtotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents EndingCapitalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SavedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DataGridViewX3 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ecapitaltotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents txttotalcredit As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txttotaldebit As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbcredit As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents lbtempecapital As DevComponents.DotNetBar.LabelX
    Friend WithEvents LoadLiabities As AJEGLS.LoadLiabities
    Friend WithEvents LoadliabilitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadliabilitiesTableAdapter As AJEGLS.LoadLiabitiesTableAdapters.loadliabilitiesTableAdapter
    Friend WithEvents Loadassetsandliabilities As AJEGLS.loadassetsandliabilities
    Friend WithEvents AssetsandliabilitiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AssetsandliabilitiesTableAdapter As AJEGLS.loadassetsandliabilitiesTableAdapters.assetsandliabilitiesTableAdapter
    Friend WithEvents ParticularsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharttypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YEARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ParticularsDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharttypeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YEARDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

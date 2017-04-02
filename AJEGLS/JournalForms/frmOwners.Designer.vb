<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOwners
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
        Me.lbendingcapital = New DevComponents.DotNetBar.LabelX()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lbtempendingcapital = New DevComponents.DotNetBar.LabelX()
        Me.lbtemwithdrawal = New DevComponents.DotNetBar.LabelX()
        Me.lbtemptotal = New DevComponents.DotNetBar.LabelX()
        Me.lbtempnetincome = New DevComponents.DotNetBar.LabelX()
        Me.lbtempbcapital = New DevComponents.DotNetBar.LabelX()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.Line4 = New DevComponents.DotNetBar.Controls.Line()
        Me.Line3 = New DevComponents.DotNetBar.Controls.Line()
        Me.lbnetcapittotal = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.Line2 = New DevComponents.DotNetBar.Controls.Line()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.dtpbenningbalance = New System.Windows.Forms.DateTimePicker()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.lbwithdrawal = New DevComponents.DotNetBar.LabelX()
        Me.lbnetincome = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.lbbeginningcapital = New DevComponents.DotNetBar.LabelX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewX2 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.IncomeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RevenueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpenseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NetincomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SavedateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LoadincomeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadIncome = New AJEGLS.loadIncome()
        Me.LoadincomeTableAdapter = New AJEGLS.loadIncomeTableAdapters.loadincomeTableAdapter()
        Me.ParticularsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OwnersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Owners = New AJEGLS.owners()
        Me.OwnersTableAdapter = New AJEGLS.ownersTableAdapters.ownersTableAdapter()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.countId = New DevComponents.DotNetBar.LabelX()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadincomeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadIncome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Owners, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbendingcapital
        '
        '
        '
        '
        Me.lbendingcapital.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbendingcapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbendingcapital.Location = New System.Drawing.Point(320, 300)
        Me.lbendingcapital.Name = "lbendingcapital"
        Me.lbendingcapital.Size = New System.Drawing.Size(120, 23)
        Me.lbendingcapital.TabIndex = 46
        Me.lbendingcapital.Text = "0.00"
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParticularsDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.MonthDataGridViewTextBoxColumn, Me.CharttypeDataGridViewTextBoxColumn})
        Me.DataGridViewX1.DataSource = Me.OwnersBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(563, 426)
        Me.DataGridViewX1.TabIndex = 0
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(126, 300)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(153, 23)
        Me.LabelX4.TabIndex = 45
        Me.LabelX4.Text = "CDC Ending Capital:"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1175, 549)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.GroupPanel2)
        Me.PanelEx2.Controls.Add(Me.GroupPanel3)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(30, 12)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1118, 453)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 4
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.countId)
        Me.GroupPanel2.Controls.Add(Me.LabelX6)
        Me.GroupPanel2.Controls.Add(Me.lbtempendingcapital)
        Me.GroupPanel2.Controls.Add(Me.lbtemwithdrawal)
        Me.GroupPanel2.Controls.Add(Me.lbtemptotal)
        Me.GroupPanel2.Controls.Add(Me.lbtempnetincome)
        Me.GroupPanel2.Controls.Add(Me.lbtempbcapital)
        Me.GroupPanel2.Controls.Add(Me.LabelX9)
        Me.GroupPanel2.Controls.Add(Me.LabelX8)
        Me.GroupPanel2.Controls.Add(Me.LabelX7)
        Me.GroupPanel2.Controls.Add(Me.Line4)
        Me.GroupPanel2.Controls.Add(Me.Line3)
        Me.GroupPanel2.Controls.Add(Me.lbnetcapittotal)
        Me.GroupPanel2.Controls.Add(Me.LabelX3)
        Me.GroupPanel2.Controls.Add(Me.Line2)
        Me.GroupPanel2.Controls.Add(Me.LabelX1)
        Me.GroupPanel2.Controls.Add(Me.LabelX4)
        Me.GroupPanel2.Controls.Add(Me.dtpbenningbalance)
        Me.GroupPanel2.Controls.Add(Me.lbendingcapital)
        Me.GroupPanel2.Controls.Add(Me.LabelX5)
        Me.GroupPanel2.Controls.Add(Me.lbwithdrawal)
        Me.GroupPanel2.Controls.Add(Me.lbnetincome)
        Me.GroupPanel2.Controls.Add(Me.LabelX2)
        Me.GroupPanel2.Controls.Add(Me.lbbeginningcapital)
        Me.GroupPanel2.Controls.Add(Me.Line1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(572, 3)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(543, 447)
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
        Me.GroupPanel2.TabIndex = 57
        Me.GroupPanel2.Text = "Statement of Owner's Equity"
        '
        'lbtempendingcapital
        '
        '
        '
        '
        Me.lbtempendingcapital.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbtempendingcapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtempendingcapital.Location = New System.Drawing.Point(262, 400)
        Me.lbtempendingcapital.Name = "lbtempendingcapital"
        Me.lbtempendingcapital.Size = New System.Drawing.Size(78, 23)
        Me.lbtempendingcapital.TabIndex = 69
        Me.lbtempendingcapital.Text = "0.00"
        '
        'lbtemwithdrawal
        '
        '
        '
        '
        Me.lbtemwithdrawal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbtemwithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtemwithdrawal.Location = New System.Drawing.Point(205, 400)
        Me.lbtemwithdrawal.Name = "lbtemwithdrawal"
        Me.lbtemwithdrawal.Size = New System.Drawing.Size(78, 23)
        Me.lbtemwithdrawal.TabIndex = 68
        Me.lbtemwithdrawal.Text = "0.00"
        '
        'lbtemptotal
        '
        '
        '
        '
        Me.lbtemptotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbtemptotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtemptotal.Location = New System.Drawing.Point(151, 400)
        Me.lbtemptotal.Name = "lbtemptotal"
        Me.lbtemptotal.Size = New System.Drawing.Size(78, 23)
        Me.lbtemptotal.TabIndex = 67
        Me.lbtemptotal.Text = "0.00"
        '
        'lbtempnetincome
        '
        '
        '
        '
        Me.lbtempnetincome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbtempnetincome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtempnetincome.Location = New System.Drawing.Point(88, 400)
        Me.lbtempnetincome.Name = "lbtempnetincome"
        Me.lbtempnetincome.Size = New System.Drawing.Size(78, 23)
        Me.lbtempnetincome.TabIndex = 66
        Me.lbtempnetincome.Text = "0.00"
        '
        'lbtempbcapital
        '
        '
        '
        '
        Me.lbtempbcapital.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbtempbcapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtempbcapital.Location = New System.Drawing.Point(21, 400)
        Me.lbtempbcapital.Name = "lbtempbcapital"
        Me.lbtempbcapital.Size = New System.Drawing.Size(78, 23)
        Me.lbtempbcapital.TabIndex = 65
        Me.lbtempbcapital.Text = "0.00"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(216, 69)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(165, 23)
        Me.LabelX9.TabIndex = 64
        Me.LabelX9.Text = "For the Month of"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(205, 11)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(162, 23)
        Me.LabelX8.TabIndex = 63
        Me.LabelX8.Text = "CDC Dairy and Farm"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(192, 40)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(204, 23)
        Me.LabelX7.TabIndex = 62
        Me.LabelX7.Text = "Statement of Owner's Equity"
        '
        'Line4
        '
        Me.Line4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line4.Location = New System.Drawing.Point(302, 328)
        Me.Line4.Name = "Line4"
        Me.Line4.Size = New System.Drawing.Size(120, 10)
        Me.Line4.TabIndex = 61
        Me.Line4.Text = "Line4"
        '
        'Line3
        '
        Me.Line3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line3.Location = New System.Drawing.Point(302, 322)
        Me.Line3.Name = "Line3"
        Me.Line3.Size = New System.Drawing.Size(120, 10)
        Me.Line3.TabIndex = 60
        Me.Line3.Text = "Line3"
        '
        'lbnetcapittotal
        '
        '
        '
        '
        Me.lbnetcapittotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbnetcapittotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnetcapittotal.Location = New System.Drawing.Point(320, 227)
        Me.lbnetcapittotal.Name = "lbnetcapittotal"
        Me.lbnetcapittotal.Size = New System.Drawing.Size(120, 23)
        Me.lbnetcapittotal.TabIndex = 59
        Me.lbnetcapittotal.Text = "0.00"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(126, 227)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(89, 23)
        Me.LabelX3.TabIndex = 58
        Me.LabelX3.Text = "Total:"
        '
        'Line2
        '
        Me.Line2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line2.Location = New System.Drawing.Point(304, 211)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(120, 10)
        Me.Line2.TabIndex = 57
        Me.Line2.Text = "Line2"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(126, 144)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(131, 23)
        Me.LabelX1.TabIndex = 35
        Me.LabelX1.Text = "CDC Capital:"
        '
        'dtpbenningbalance
        '
        Me.dtpbenningbalance.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpbenningbalance.CustomFormat = "MMMM dd yyyy"
        Me.dtpbenningbalance.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpbenningbalance.Location = New System.Drawing.Point(334, 110)
        Me.dtpbenningbalance.Name = "dtpbenningbalance"
        Me.dtpbenningbalance.Size = New System.Drawing.Size(156, 20)
        Me.dtpbenningbalance.TabIndex = 42
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(126, 257)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(131, 23)
        Me.LabelX5.TabIndex = 47
        Me.LabelX5.Text = "Less Withdrawal:"
        '
        'lbwithdrawal
        '
        '
        '
        '
        Me.lbwithdrawal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbwithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbwithdrawal.Location = New System.Drawing.Point(320, 258)
        Me.lbwithdrawal.Name = "lbwithdrawal"
        Me.lbwithdrawal.Size = New System.Drawing.Size(120, 23)
        Me.lbwithdrawal.TabIndex = 48
        Me.lbwithdrawal.Text = "0.00"
        '
        'lbnetincome
        '
        '
        '
        '
        Me.lbnetincome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbnetincome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbnetincome.Location = New System.Drawing.Point(321, 182)
        Me.lbnetincome.Name = "lbnetincome"
        Me.lbnetincome.Size = New System.Drawing.Size(120, 23)
        Me.lbnetincome.TabIndex = 41
        Me.lbnetincome.Text = "0.00"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(126, 182)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(131, 23)
        Me.LabelX2.TabIndex = 36
        Me.LabelX2.Text = "Add; Net Income:"
        '
        'lbbeginningcapital
        '
        '
        '
        '
        Me.lbbeginningcapital.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbbeginningcapital.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbbeginningcapital.Location = New System.Drawing.Point(320, 144)
        Me.lbbeginningcapital.Name = "lbbeginningcapital"
        Me.lbbeginningcapital.Size = New System.Drawing.Size(120, 23)
        Me.lbbeginningcapital.TabIndex = 40
        Me.lbbeginningcapital.Text = "0.00"
        '
        'Line1
        '
        Me.Line1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Line1.Location = New System.Drawing.Point(302, 286)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(120, 10)
        Me.Line1.TabIndex = 37
        Me.Line1.Text = "Line1"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel3.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(3, 3)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(569, 447)
        '
        '
        '
        Me.GroupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel3.Style.BackColorGradientAngle = 90
        Me.GroupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderBottomWidth = 1
        Me.GroupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderLeftWidth = 1
        Me.GroupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderRightWidth = 1
        Me.GroupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel3.Style.BorderTopWidth = 1
        Me.GroupPanel3.Style.CornerDiameter = 4
        Me.GroupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel3.TabIndex = 39
        Me.GroupPanel3.Text = "Withdrawal"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.DateTimePicker2)
        Me.GroupPanel1.Controls.Add(Me.DataGridViewX2)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(-3, 190)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(569, 233)
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
        Me.GroupPanel1.TabIndex = 43
        Me.GroupPanel1.Text = "Net Income"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMMM yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(3, 254)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 42
        '
        'DataGridViewX2
        '
        Me.DataGridViewX2.AllowUserToAddRows = False
        Me.DataGridViewX2.AllowUserToDeleteRows = False
        Me.DataGridViewX2.AutoGenerateColumns = False
        Me.DataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IncomeidDataGridViewTextBoxColumn, Me.RevenueDataGridViewTextBoxColumn, Me.ExpenseDataGridViewTextBoxColumn, Me.NetincomeDataGridViewTextBoxColumn, Me.SavedateDataGridViewTextBoxColumn})
        Me.DataGridViewX2.DataSource = Me.LoadincomeBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX2.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridViewX2.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX2.Name = "DataGridViewX2"
        Me.DataGridViewX2.ReadOnly = True
        Me.DataGridViewX2.Size = New System.Drawing.Size(563, 209)
        Me.DataGridViewX2.TabIndex = 1
        '
        'IncomeidDataGridViewTextBoxColumn
        '
        Me.IncomeidDataGridViewTextBoxColumn.DataPropertyName = "incomeid"
        Me.IncomeidDataGridViewTextBoxColumn.HeaderText = "incomeid"
        Me.IncomeidDataGridViewTextBoxColumn.Name = "IncomeidDataGridViewTextBoxColumn"
        Me.IncomeidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RevenueDataGridViewTextBoxColumn
        '
        Me.RevenueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RevenueDataGridViewTextBoxColumn.DataPropertyName = "revenue"
        Me.RevenueDataGridViewTextBoxColumn.HeaderText = "Revenue"
        Me.RevenueDataGridViewTextBoxColumn.Name = "RevenueDataGridViewTextBoxColumn"
        Me.RevenueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ExpenseDataGridViewTextBoxColumn
        '
        Me.ExpenseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ExpenseDataGridViewTextBoxColumn.DataPropertyName = "expense"
        Me.ExpenseDataGridViewTextBoxColumn.HeaderText = "Expense"
        Me.ExpenseDataGridViewTextBoxColumn.Name = "ExpenseDataGridViewTextBoxColumn"
        Me.ExpenseDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NetincomeDataGridViewTextBoxColumn
        '
        Me.NetincomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NetincomeDataGridViewTextBoxColumn.DataPropertyName = "netincome"
        Me.NetincomeDataGridViewTextBoxColumn.HeaderText = "Net Income"
        Me.NetincomeDataGridViewTextBoxColumn.Name = "NetincomeDataGridViewTextBoxColumn"
        Me.NetincomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SavedateDataGridViewTextBoxColumn
        '
        Me.SavedateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SavedateDataGridViewTextBoxColumn.DataPropertyName = "savedate"
        Me.SavedateDataGridViewTextBoxColumn.HeaderText = "Month"
        Me.SavedateDataGridViewTextBoxColumn.Name = "SavedateDataGridViewTextBoxColumn"
        Me.SavedateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LoadincomeBindingSource
        '
        Me.LoadincomeBindingSource.DataMember = "loadincome"
        Me.LoadincomeBindingSource.DataSource = Me.LoadIncome
        '
        'LoadIncome
        '
        Me.LoadIncome.DataSetName = "loadIncome"
        Me.LoadIncome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LoadincomeTableAdapter
        '
        Me.LoadincomeTableAdapter.ClearBeforeFill = True
        '
        'ParticularsDataGridViewTextBoxColumn
        '
        Me.ParticularsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ParticularsDataGridViewTextBoxColumn.DataPropertyName = "Particulars"
        Me.ParticularsDataGridViewTextBoxColumn.HeaderText = "Particulars"
        Me.ParticularsDataGridViewTextBoxColumn.Name = "ParticularsDataGridViewTextBoxColumn"
        Me.ParticularsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "Credit"
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreditDataGridViewTextBoxColumn.Width = 200
        '
        'MonthDataGridViewTextBoxColumn
        '
        Me.MonthDataGridViewTextBoxColumn.DataPropertyName = "Month"
        Me.MonthDataGridViewTextBoxColumn.HeaderText = "Month"
        Me.MonthDataGridViewTextBoxColumn.Name = "MonthDataGridViewTextBoxColumn"
        Me.MonthDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CharttypeDataGridViewTextBoxColumn
        '
        Me.CharttypeDataGridViewTextBoxColumn.DataPropertyName = "charttype"
        Me.CharttypeDataGridViewTextBoxColumn.HeaderText = "charttype"
        Me.CharttypeDataGridViewTextBoxColumn.Name = "CharttypeDataGridViewTextBoxColumn"
        Me.CharttypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OwnersBindingSource
        '
        Me.OwnersBindingSource.DataMember = "owners"
        Me.OwnersBindingSource.DataSource = Me.Owners
        '
        'Owners
        '
        Me.Owners.DataSetName = "owners"
        Me.Owners.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OwnersTableAdapter
        '
        Me.OwnersTableAdapter.ClearBeforeFill = True
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(124, 109)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(204, 23)
        Me.LabelX6.TabIndex = 70
        Me.LabelX6.Text = "Select for Beginning Balance"
        '
        'countId
        '
        '
        '
        '
        Me.countId.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.countId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countId.Location = New System.Drawing.Point(21, 40)
        Me.countId.Name = "countId"
        Me.countId.Size = New System.Drawing.Size(94, 23)
        Me.countId.TabIndex = 71
        '
        'frmOwners
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 549)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOwners"
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx2.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.DataGridViewX2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadincomeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadIncome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Owners, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbendingcapital As DevComponents.DotNetBar.LabelX
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dtpbenningbalance As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbnetincome As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbbeginningcapital As DevComponents.DotNetBar.LabelX
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbwithdrawal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewX2 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Line4 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents Line3 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents lbnetcapittotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Line2 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbtempendingcapital As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbtemwithdrawal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbtemptotal As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbtempnetincome As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbtempbcapital As DevComponents.DotNetBar.LabelX
    Friend WithEvents Owners As AJEGLS.owners
    Friend WithEvents OwnersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OwnersTableAdapter As AJEGLS.ownersTableAdapters.ownersTableAdapter
    Friend WithEvents ParticularsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharttypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LoadIncome As AJEGLS.loadIncome
    Friend WithEvents LoadincomeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LoadincomeTableAdapter As AJEGLS.loadIncomeTableAdapters.loadincomeTableAdapter
    Friend WithEvents IncomeidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RevenueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExpenseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NetincomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SavedateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents countId As DevComponents.DotNetBar.LabelX
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncomeStatement
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbIncome = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.lbcredit = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.dgIncomeStatementRevenu = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel4 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lbtempneticome = New System.Windows.Forms.Label()
        Me.lbtempexpense = New System.Windows.Forms.Label()
        Me.lbtemprevenue = New System.Windows.Forms.Label()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX8 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.lbdebit = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgIncomeStatementExpense = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.RetrieveIncomeStatement = New AJEGLS.retrieveIncomeStatement()
        Me.IncomeStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IncomeStatementTableAdapter = New AJEGLS.retrieveIncomeStatementTableAdapters.IncomeStatementTableAdapter()
        Me.RetreiveExpense = New AJEGLS.RetreiveExpense()
        Me.RetrievexpenseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetrievexpenseTableAdapter = New AJEGLS.RetreiveExpenseTableAdapters.retrievexpenseTableAdapter()
        Me.ChartnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharttypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartnameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CharttypeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YEARDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgIncomeStatementRevenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel4.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dgIncomeStatementExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetrieveIncomeStatement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncomeStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetreiveExpense, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetrievexpenseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbIncome
        '
        '
        '
        '
        Me.lbIncome.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIncome.Location = New System.Drawing.Point(817, 444)
        Me.lbIncome.Name = "lbIncome"
        Me.lbIncome.Size = New System.Drawing.Size(120, 23)
        Me.lbIncome.TabIndex = 46
        Me.lbIncome.Text = "0.00"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(720, 444)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(91, 23)
        Me.LabelX4.TabIndex = 45
        Me.LabelX4.Text = "Net Income:"
        '
        'lbcredit
        '
        '
        '
        '
        Me.lbcredit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbcredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcredit.Location = New System.Drawing.Point(809, 255)
        Me.lbcredit.Name = "lbcredit"
        Me.lbcredit.Size = New System.Drawing.Size(120, 23)
        Me.lbcredit.TabIndex = 41
        Me.lbcredit.Text = "0.00"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(717, 254)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 35
        Me.LabelX1.Text = "Revenue:"
        '
        'dgIncomeStatementRevenu
        '
        Me.dgIncomeStatementRevenu.AllowUserToAddRows = False
        Me.dgIncomeStatementRevenu.AllowUserToDeleteRows = False
        Me.dgIncomeStatementRevenu.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIncomeStatementRevenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgIncomeStatementRevenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIncomeStatementRevenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChartnameDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.MonthDataGridViewTextBoxColumn, Me.CharttypeDataGridViewTextBoxColumn, Me.YEARDataGridViewTextBoxColumn})
        Me.dgIncomeStatementRevenu.DataSource = Me.IncomeStatementBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgIncomeStatementRevenu.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgIncomeStatementRevenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIncomeStatementRevenu.EnableHeadersVisualStyles = False
        Me.dgIncomeStatementRevenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgIncomeStatementRevenu.Location = New System.Drawing.Point(0, 0)
        Me.dgIncomeStatementRevenu.Margin = New System.Windows.Forms.Padding(0)
        Me.dgIncomeStatementRevenu.Name = "dgIncomeStatementRevenu"
        Me.dgIncomeStatementRevenu.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIncomeStatementRevenu.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgIncomeStatementRevenu.Size = New System.Drawing.Size(679, 144)
        Me.dgIncomeStatementRevenu.TabIndex = 0
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = False
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel4)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1249, 504)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'GroupPanel4
        '
        Me.GroupPanel4.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel4.Controls.Add(Me.lbtempneticome)
        Me.GroupPanel4.Controls.Add(Me.lbtempexpense)
        Me.GroupPanel4.Controls.Add(Me.lbtemprevenue)
        Me.GroupPanel4.Controls.Add(Me.LabelX9)
        Me.GroupPanel4.Controls.Add(Me.LabelX8)
        Me.GroupPanel4.Controls.Add(Me.LabelX7)
        Me.GroupPanel4.Controls.Add(Me.lbdebit)
        Me.GroupPanel4.Controls.Add(Me.lbIncome)
        Me.GroupPanel4.Controls.Add(Me.LabelX4)
        Me.GroupPanel4.Controls.Add(Me.LabelX2)
        Me.GroupPanel4.Controls.Add(Me.LabelX1)
        Me.GroupPanel4.Controls.Add(Me.GroupPanel1)
        Me.GroupPanel4.Controls.Add(Me.GroupPanel2)
        Me.GroupPanel4.Controls.Add(Me.lbcredit)
        Me.GroupPanel4.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel4.Name = "GroupPanel4"
        Me.GroupPanel4.Size = New System.Drawing.Size(1249, 504)
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
        Me.GroupPanel4.TabIndex = 5
        Me.GroupPanel4.Text = "Income Statemenet"
        '
        'lbtempneticome
        '
        Me.lbtempneticome.AutoSize = True
        Me.lbtempneticome.Location = New System.Drawing.Point(1082, 8)
        Me.lbtempneticome.Name = "lbtempneticome"
        Me.lbtempneticome.Size = New System.Drawing.Size(28, 13)
        Me.lbtempneticome.TabIndex = 70
        Me.lbtempneticome.Text = "0.00"
        '
        'lbtempexpense
        '
        Me.lbtempexpense.AutoSize = True
        Me.lbtempexpense.Location = New System.Drawing.Point(958, 8)
        Me.lbtempexpense.Name = "lbtempexpense"
        Me.lbtempexpense.Size = New System.Drawing.Size(28, 13)
        Me.lbtempexpense.TabIndex = 69
        Me.lbtempexpense.Text = "0.00"
        '
        'lbtemprevenue
        '
        Me.lbtemprevenue.AutoSize = True
        Me.lbtemprevenue.Location = New System.Drawing.Point(836, 8)
        Me.lbtemprevenue.Name = "lbtemprevenue"
        Me.lbtemprevenue.Size = New System.Drawing.Size(28, 13)
        Me.lbtemprevenue.TabIndex = 68
        Me.lbtemprevenue.Text = "0.00"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(523, 60)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(147, 23)
        Me.LabelX9.TabIndex = 67
        Me.LabelX9.Text = "For the Month of"
        '
        'LabelX8
        '
        '
        '
        '
        Me.LabelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX8.Location = New System.Drawing.Point(515, 34)
        Me.LabelX8.Name = "LabelX8"
        Me.LabelX8.Size = New System.Drawing.Size(162, 23)
        Me.LabelX8.TabIndex = 66
        Me.LabelX8.Text = "CDC Dairy and Farm"
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX7.Location = New System.Drawing.Point(522, 8)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(152, 23)
        Me.LabelX7.TabIndex = 65
        Me.LabelX7.Text = "Income Statement"
        '
        'lbdebit
        '
        '
        '
        '
        Me.lbdebit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbdebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdebit.Location = New System.Drawing.Point(816, 412)
        Me.lbdebit.Name = "lbdebit"
        Me.lbdebit.Size = New System.Drawing.Size(120, 23)
        Me.lbdebit.TabIndex = 43
        Me.lbdebit.Text = "0.00"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(720, 412)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 42
        Me.LabelX2.Text = "Expense:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.dgIncomeStatementRevenu)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(248, 87)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupPanel1.Size = New System.Drawing.Size(685, 165)
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
        Me.GroupPanel1.TabIndex = 3
        Me.GroupPanel1.Text = "Revenue"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.dgIncomeStatementExpense)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(251, 275)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupPanel2.Size = New System.Drawing.Size(679, 134)
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
        Me.GroupPanel2.TabIndex = 4
        Me.GroupPanel2.Text = "Expense"
        '
        'dgIncomeStatementExpense
        '
        Me.dgIncomeStatementExpense.AllowUserToAddRows = False
        Me.dgIncomeStatementExpense.AllowUserToDeleteRows = False
        Me.dgIncomeStatementExpense.AutoGenerateColumns = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIncomeStatementExpense.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgIncomeStatementExpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgIncomeStatementExpense.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChartnameDataGridViewTextBoxColumn1, Me.DebitDataGridViewTextBoxColumn, Me.MonthDataGridViewTextBoxColumn1, Me.CharttypeDataGridViewTextBoxColumn1, Me.YEARDataGridViewTextBoxColumn1})
        Me.dgIncomeStatementExpense.DataSource = Me.RetrievexpenseBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgIncomeStatementExpense.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgIncomeStatementExpense.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIncomeStatementExpense.EnableHeadersVisualStyles = False
        Me.dgIncomeStatementExpense.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgIncomeStatementExpense.Location = New System.Drawing.Point(0, 0)
        Me.dgIncomeStatementExpense.Margin = New System.Windows.Forms.Padding(0)
        Me.dgIncomeStatementExpense.Name = "dgIncomeStatementExpense"
        Me.dgIncomeStatementExpense.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgIncomeStatementExpense.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgIncomeStatementExpense.Size = New System.Drawing.Size(673, 113)
        Me.dgIncomeStatementExpense.TabIndex = 0
        '
        'RetrieveIncomeStatement
        '
        Me.RetrieveIncomeStatement.DataSetName = "retrieveIncomeStatement"
        Me.RetrieveIncomeStatement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IncomeStatementBindingSource
        '
        Me.IncomeStatementBindingSource.DataMember = "IncomeStatement"
        Me.IncomeStatementBindingSource.DataSource = Me.RetrieveIncomeStatement
        '
        'IncomeStatementTableAdapter
        '
        Me.IncomeStatementTableAdapter.ClearBeforeFill = True
        '
        'RetreiveExpense
        '
        Me.RetreiveExpense.DataSetName = "RetreiveExpense"
        Me.RetreiveExpense.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetrievexpenseBindingSource
        '
        Me.RetrievexpenseBindingSource.DataMember = "retrievexpense"
        Me.RetrievexpenseBindingSource.DataSource = Me.RetreiveExpense
        '
        'RetrievexpenseTableAdapter
        '
        Me.RetrievexpenseTableAdapter.ClearBeforeFill = True
        '
        'ChartnameDataGridViewTextBoxColumn
        '
        Me.ChartnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChartnameDataGridViewTextBoxColumn.DataPropertyName = "chartname"
        Me.ChartnameDataGridViewTextBoxColumn.HeaderText = "Particulars"
        Me.ChartnameDataGridViewTextBoxColumn.Name = "ChartnameDataGridViewTextBoxColumn"
        Me.ChartnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "Credit"
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreditDataGridViewTextBoxColumn.Width = 250
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
        'YEARDataGridViewTextBoxColumn
        '
        Me.YEARDataGridViewTextBoxColumn.DataPropertyName = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.HeaderText = "YEAR"
        Me.YEARDataGridViewTextBoxColumn.Name = "YEARDataGridViewTextBoxColumn"
        Me.YEARDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ChartnameDataGridViewTextBoxColumn1
        '
        Me.ChartnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ChartnameDataGridViewTextBoxColumn1.DataPropertyName = "chartname"
        Me.ChartnameDataGridViewTextBoxColumn1.HeaderText = "Particulars"
        Me.ChartnameDataGridViewTextBoxColumn1.Name = "ChartnameDataGridViewTextBoxColumn1"
        Me.ChartnameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DebitDataGridViewTextBoxColumn
        '
        Me.DebitDataGridViewTextBoxColumn.DataPropertyName = "Debit"
        Me.DebitDataGridViewTextBoxColumn.HeaderText = "Debit"
        Me.DebitDataGridViewTextBoxColumn.Name = "DebitDataGridViewTextBoxColumn"
        Me.DebitDataGridViewTextBoxColumn.ReadOnly = True
        Me.DebitDataGridViewTextBoxColumn.Width = 250
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
        'frmIncomeStatement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1249, 504)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIncomeStatement"
        CType(Me.dgIncomeStatementRevenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel4.ResumeLayout(False)
        Me.GroupPanel4.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dgIncomeStatementExpense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetrieveIncomeStatement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncomeStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetreiveExpense, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetrievexpenseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbcredit As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dgIncomeStatementRevenu As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents lbIncome As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dgIncomeStatementExpense As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents GroupPanel4 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lbdebit As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX8 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbtempneticome As System.Windows.Forms.Label
    Friend WithEvents lbtempexpense As System.Windows.Forms.Label
    Friend WithEvents lbtemprevenue As System.Windows.Forms.Label
    Friend WithEvents RetrieveIncomeStatement As AJEGLS.retrieveIncomeStatement
    Friend WithEvents IncomeStatementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IncomeStatementTableAdapter As AJEGLS.retrieveIncomeStatementTableAdapters.IncomeStatementTableAdapter
    Friend WithEvents RetreiveExpense As AJEGLS.RetreiveExpense
    Friend WithEvents RetrievexpenseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RetrievexpenseTableAdapter As AJEGLS.RetreiveExpenseTableAdapters.retrievexpenseTableAdapter
    Friend WithEvents ChartnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharttypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YEARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChartnameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MonthDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CharttypeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YEARDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

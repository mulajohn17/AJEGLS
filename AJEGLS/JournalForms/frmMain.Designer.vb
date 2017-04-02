<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialJournalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralLedgerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralLedgerToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrialBalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrialBalanceToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerTypeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCustomerInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddChartOfAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountTypeAndStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddChartOfAccountToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JournalTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SummarizingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncomeStatementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OwnersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BalanceSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterUserAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolCancel = New System.Windows.Forms.ToolStripButton()
        Me.toolAddRecord = New System.Windows.Forms.ToolStripButton()
        Me.toolSaveRecord = New System.Windows.Forms.ToolStripButton()
        Me.toolUpdateRecord = New System.Windows.Forms.ToolStripButton()
        Me.toolSearchRecord = New System.Windows.Forms.ToolStripButton()
        Me.toolChild = New System.Windows.Forms.ToolStripButton()
        Me.Status = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.accountPanel = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtUsername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.btnLogin = New DevComponents.DotNetBar.ButtonX()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.lbSearch = New DevComponents.DotNetBar.LabelItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.dataPanel = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Status.SuspendLayout()
        Me.accountPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.dataPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JournalToolStripMenuItem, Me.GeneralLedgerToolStripMenuItem1, Me.TrialBalanceToolStripMenuItem, Me.MaintenanceToolStripMenuItem, Me.SummarizingToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AdministratorToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1354, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JournalToolStripMenuItem
        '
        Me.JournalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpecialJournalToolStripMenuItem})
        Me.JournalToolStripMenuItem.Name = "JournalToolStripMenuItem"
        Me.JournalToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.JournalToolStripMenuItem.Text = "General Journal"
        '
        'SpecialJournalToolStripMenuItem
        '
        Me.SpecialJournalToolStripMenuItem.Name = "SpecialJournalToolStripMenuItem"
        Me.SpecialJournalToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SpecialJournalToolStripMenuItem.Text = "Journal Entry"
        '
        'GeneralLedgerToolStripMenuItem1
        '
        Me.GeneralLedgerToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralLedgerToolStripMenuItem2})
        Me.GeneralLedgerToolStripMenuItem1.Name = "GeneralLedgerToolStripMenuItem1"
        Me.GeneralLedgerToolStripMenuItem1.Size = New System.Drawing.Size(108, 20)
        Me.GeneralLedgerToolStripMenuItem1.Text = "General Ledger"
        '
        'GeneralLedgerToolStripMenuItem2
        '
        Me.GeneralLedgerToolStripMenuItem2.Name = "GeneralLedgerToolStripMenuItem2"
        Me.GeneralLedgerToolStripMenuItem2.Size = New System.Drawing.Size(164, 22)
        Me.GeneralLedgerToolStripMenuItem2.Text = "General Ledger"
        '
        'TrialBalanceToolStripMenuItem
        '
        Me.TrialBalanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrialBalanceToolStripMenuItem1})
        Me.TrialBalanceToolStripMenuItem.Name = "TrialBalanceToolStripMenuItem"
        Me.TrialBalanceToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.TrialBalanceToolStripMenuItem.Text = "Trial Balance"
        '
        'TrialBalanceToolStripMenuItem1
        '
        Me.TrialBalanceToolStripMenuItem1.Name = "TrialBalanceToolStripMenuItem1"
        Me.TrialBalanceToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.TrialBalanceToolStripMenuItem1.Text = "Trial Balance"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomerToolStripMenuItem, Me.AddSupplierToolStripMenuItem, Me.AddChartOfAccountToolStripMenuItem, Me.JournalTypeToolStripMenuItem})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'AddCustomerToolStripMenuItem
        '
        Me.AddCustomerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CustomerTypeToolStripMenuItem1, Me.AddCustomerInfoToolStripMenuItem})
        Me.AddCustomerToolStripMenuItem.Name = "AddCustomerToolStripMenuItem"
        Me.AddCustomerToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddCustomerToolStripMenuItem.Text = "Customer"
        '
        'CustomerTypeToolStripMenuItem1
        '
        Me.CustomerTypeToolStripMenuItem1.Name = "CustomerTypeToolStripMenuItem1"
        Me.CustomerTypeToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.CustomerTypeToolStripMenuItem1.Text = "Add Customer Type"
        '
        'AddCustomerInfoToolStripMenuItem
        '
        Me.AddCustomerInfoToolStripMenuItem.Name = "AddCustomerInfoToolStripMenuItem"
        Me.AddCustomerInfoToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AddCustomerInfoToolStripMenuItem.Text = "Add Customer Info"
        '
        'AddSupplierToolStripMenuItem
        '
        Me.AddSupplierToolStripMenuItem.Name = "AddSupplierToolStripMenuItem"
        Me.AddSupplierToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddSupplierToolStripMenuItem.Text = "Supplier"
        '
        'AddChartOfAccountToolStripMenuItem
        '
        Me.AddChartOfAccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountTypeAndStatusToolStripMenuItem, Me.AddChartOfAccountToolStripMenuItem1})
        Me.AddChartOfAccountToolStripMenuItem.Name = "AddChartOfAccountToolStripMenuItem"
        Me.AddChartOfAccountToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AddChartOfAccountToolStripMenuItem.Text = "Chart of Account"
        '
        'AccountTypeAndStatusToolStripMenuItem
        '
        Me.AccountTypeAndStatusToolStripMenuItem.Name = "AccountTypeAndStatusToolStripMenuItem"
        Me.AccountTypeAndStatusToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.AccountTypeAndStatusToolStripMenuItem.Text = "Add Account Type and Status"
        '
        'AddChartOfAccountToolStripMenuItem1
        '
        Me.AddChartOfAccountToolStripMenuItem1.Name = "AddChartOfAccountToolStripMenuItem1"
        Me.AddChartOfAccountToolStripMenuItem1.Size = New System.Drawing.Size(248, 22)
        Me.AddChartOfAccountToolStripMenuItem1.Text = "Add Chart of Account"
        '
        'JournalTypeToolStripMenuItem
        '
        Me.JournalTypeToolStripMenuItem.Name = "JournalTypeToolStripMenuItem"
        Me.JournalTypeToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.JournalTypeToolStripMenuItem.Text = "Journal Type"
        '
        'SummarizingToolStripMenuItem
        '
        Me.SummarizingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncomeStatementToolStripMenuItem, Me.OwnersToolStripMenuItem, Me.BalanceSheetToolStripMenuItem})
        Me.SummarizingToolStripMenuItem.Name = "SummarizingToolStripMenuItem"
        Me.SummarizingToolStripMenuItem.Size = New System.Drawing.Size(143, 20)
        Me.SummarizingToolStripMenuItem.Text = "Financial Statemenet"
        '
        'IncomeStatementToolStripMenuItem
        '
        Me.IncomeStatementToolStripMenuItem.Name = "IncomeStatementToolStripMenuItem"
        Me.IncomeStatementToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.IncomeStatementToolStripMenuItem.Text = "Income Statement"
        '
        'OwnersToolStripMenuItem
        '
        Me.OwnersToolStripMenuItem.Name = "OwnersToolStripMenuItem"
        Me.OwnersToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.OwnersToolStripMenuItem.Text = "Owner's Equity Statement"
        '
        'BalanceSheetToolStripMenuItem
        '
        Me.BalanceSheetToolStripMenuItem.Name = "BalanceSheetToolStripMenuItem"
        Me.BalanceSheetToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.BalanceSheetToolStripMenuItem.Text = "Balance Sheet"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewReportToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'NewReportToolStripMenuItem
        '
        Me.NewReportToolStripMenuItem.Name = "NewReportToolStripMenuItem"
        Me.NewReportToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NewReportToolStripMenuItem.Text = "Produce Report"
        '
        'AdministratorToolStripMenuItem
        '
        Me.AdministratorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterUserAccountToolStripMenuItem, Me.AddNewDepartmentToolStripMenuItem})
        Me.AdministratorToolStripMenuItem.Name = "AdministratorToolStripMenuItem"
        Me.AdministratorToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.AdministratorToolStripMenuItem.Text = "Manage Account"
        '
        'RegisterUserAccountToolStripMenuItem
        '
        Me.RegisterUserAccountToolStripMenuItem.Name = "RegisterUserAccountToolStripMenuItem"
        Me.RegisterUserAccountToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.RegisterUserAccountToolStripMenuItem.Text = "Register User Account"
        '
        'AddNewDepartmentToolStripMenuItem
        '
        Me.AddNewDepartmentToolStripMenuItem.Name = "AddNewDepartmentToolStripMenuItem"
        Me.AddNewDepartmentToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.AddNewDepartmentToolStripMenuItem.Text = "Add New Department"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(12, 20)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(12, 20)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolCancel, Me.toolAddRecord, Me.toolSaveRecord, Me.toolUpdateRecord, Me.toolSearchRecord, Me.toolChild})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1354, 43)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toolCancel
        '
        Me.toolCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolCancel.Image = CType(resources.GetObject("toolCancel.Image"), System.Drawing.Image)
        Me.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolCancel.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.toolCancel.Name = "toolCancel"
        Me.toolCancel.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.toolCancel.Size = New System.Drawing.Size(57, 40)
        Me.toolCancel.Text = "Cancel"
        '
        'toolAddRecord
        '
        Me.toolAddRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolAddRecord.Image = CType(resources.GetObject("toolAddRecord.Image"), System.Drawing.Image)
        Me.toolAddRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolAddRecord.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.toolAddRecord.Name = "toolAddRecord"
        Me.toolAddRecord.Size = New System.Drawing.Size(65, 40)
        Me.toolAddRecord.Text = "New Entry"
        '
        'toolSaveRecord
        '
        Me.toolSaveRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolSaveRecord.Image = Global.AJEGLS.My.Resources.Resources.add
        Me.toolSaveRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolSaveRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSaveRecord.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.toolSaveRecord.Name = "toolSaveRecord"
        Me.toolSaveRecord.Size = New System.Drawing.Size(75, 40)
        Me.toolSaveRecord.Text = "Save Record"
        '
        'toolUpdateRecord
        '
        Me.toolUpdateRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolUpdateRecord.Image = Global.AJEGLS.My.Resources.Resources.update
        Me.toolUpdateRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolUpdateRecord.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.toolUpdateRecord.Name = "toolUpdateRecord"
        Me.toolUpdateRecord.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.toolUpdateRecord.Size = New System.Drawing.Size(91, 40)
        Me.toolUpdateRecord.Text = "Update Record"
        '
        'toolSearchRecord
        '
        Me.toolSearchRecord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolSearchRecord.Image = CType(resources.GetObject("toolSearchRecord.Image"), System.Drawing.Image)
        Me.toolSearchRecord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolSearchRecord.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.toolSearchRecord.Name = "toolSearchRecord"
        Me.toolSearchRecord.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.toolSearchRecord.Size = New System.Drawing.Size(88, 40)
        Me.toolSearchRecord.Text = "Search Record"
        '
        'toolChild
        '
        Me.toolChild.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolChild.Image = CType(resources.GetObject("toolChild.Image"), System.Drawing.Image)
        Me.toolChild.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolChild.Margin = New System.Windows.Forms.Padding(10, 1, 0, 2)
        Me.toolChild.Name = "toolChild"
        Me.toolChild.Size = New System.Drawing.Size(47, 40)
        Me.toolChild.Text = "Cancel"
        '
        'Status
        '
        Me.Status.AutoSize = False
        Me.Status.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.toolTime})
        Me.Status.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.Status.Location = New System.Drawing.Point(0, 546)
        Me.Status.Margin = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(1354, 35)
        Me.Status.TabIndex = 20
        Me.Status.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Image = Global.AJEGLS.My.Resources.Resources.users
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(53, 30)
        Me.ToolStripStatusLabel1.Text = "User:"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 30)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Image = Global.AJEGLS.My.Resources.Resources.type
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(62, 30)
        Me.ToolStripStatusLabel3.Text = "Status:"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(0, 30)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Image = Global.AJEGLS.My.Resources.Resources.time
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(57, 30)
        Me.ToolStripStatusLabel5.Text = "Time:"
        '
        'toolTime
        '
        Me.toolTime.Name = "toolTime"
        Me.toolTime.Size = New System.Drawing.Size(120, 30)
        Me.toolTime.Text = "ToolStripStatusLabel6"
        '
        'accountPanel
        '
        Me.accountPanel.BackColor = System.Drawing.Color.White
        Me.accountPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.accountPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.accountPanel.Controls.Add(Me.PictureBox1)
        Me.accountPanel.Controls.Add(Me.txtPassword)
        Me.accountPanel.Controls.Add(Me.txtUsername)
        Me.accountPanel.Controls.Add(Me.btnLogin)
        Me.accountPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.accountPanel.Location = New System.Drawing.Point(455, 198)
        Me.accountPanel.Name = "accountPanel"
        Me.accountPanel.Size = New System.Drawing.Size(355, 175)
        '
        '
        '
        Me.accountPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.accountPanel.Style.BackColorGradientAngle = 90
        Me.accountPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.accountPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.accountPanel.Style.BorderBottomWidth = 1
        Me.accountPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.accountPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.accountPanel.Style.BorderLeftWidth = 1
        Me.accountPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.accountPanel.Style.BorderRightWidth = 1
        Me.accountPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.accountPanel.Style.BorderTopWidth = 1
        Me.accountPanel.Style.CornerDiameter = 4
        Me.accountPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.accountPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.accountPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.accountPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.accountPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.accountPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.accountPanel.TabIndex = 22
        Me.accountPanel.Text = "Account Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.AJEGLS.My.Resources.Resources.account
        Me.PictureBox1.Location = New System.Drawing.Point(3, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(106, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtPassword.Border.Class = "TextBoxBorder"
        Me.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPassword.DisabledBackColor = System.Drawing.Color.White
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.Location = New System.Drawing.Point(115, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PreventEnterBeep = True
        Me.txtPassword.Size = New System.Drawing.Size(175, 22)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.WatermarkText = "Password"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.txtUsername.Border.Class = "TextBoxBorder"
        Me.txtUsername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtUsername.DisabledBackColor = System.Drawing.Color.White
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.Location = New System.Drawing.Point(115, 31)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PreventEnterBeep = True
        Me.txtUsername.Size = New System.Drawing.Size(175, 22)
        Me.txtUsername.TabIndex = 1
        Me.txtUsername.WatermarkText = "Username"
        '
        'btnLogin
        '
        Me.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnLogin.Location = New System.Drawing.Point(155, 105)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.AutoHide = True
        Me.Bar1.Controls.Add(Me.TextBoxX1)
        Me.Bar1.FadeEffect = True
        Me.Bar1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Bar1.IsMaximized = False
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ControlContainerItem1, Me.lbSearch})
        Me.Bar1.Location = New System.Drawing.Point(1128, 30)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(214, 28)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 24
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Location = New System.Drawing.Point(3, 2)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.PreventEnterBeep = True
        Me.TextBoxX1.Size = New System.Drawing.Size(153, 23)
        Me.TextBoxX1.TabIndex = 25
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = False
        Me.ControlContainerItem1.Control = Me.TextBoxX1
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'lbSearch
        '
        Me.lbSearch.Name = "lbSearch"
        Me.lbSearch.Text = "Search"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM dd yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(84, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(156, 22)
        Me.DateTimePicker1.TabIndex = 26
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'dataPanel
        '
        Me.dataPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.dataPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dataPanel.Controls.Add(Me.LabelX1)
        Me.dataPanel.Controls.Add(Me.DateTimePicker1)
        Me.dataPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.dataPanel.Location = New System.Drawing.Point(880, 30)
        Me.dataPanel.Name = "dataPanel"
        Me.dataPanel.Size = New System.Drawing.Size(245, 28)
        Me.dataPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.dataPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dataPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dataPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.dataPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.dataPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.dataPanel.Style.GradientAngle = 90
        Me.dataPanel.TabIndex = 28
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(7, 3)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(75, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Filter Month"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = Global.AJEGLS.My.Resources.Resources.Journal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 581)
        Me.Controls.Add(Me.dataPanel)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.accountPanel)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated Journal Entry for General Ledger System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Status.ResumeLayout(False)
        Me.Status.PerformLayout()
        Me.accountPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.dataPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents JournalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents toolChild As System.Windows.Forms.ToolStripButton
    Friend WithEvents NewReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolUpdateRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolSearchRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolSaveRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents Status As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents accountPanel As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtPassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtUsername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnLogin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents toolTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummarizingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents lbSearch As DevComponents.DotNetBar.LabelItem
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents IncomeStatementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OwnersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BalanceSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents toolAddRecord As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents SpecialJournalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministratorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterUserAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dataPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GeneralLedgerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralLedgerToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrialBalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrialBalanceToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddChartOfAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerTypeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountTypeAndStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JournalTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddCustomerInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddChartOfAccountToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpecialJournal
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.groupJournalPanel = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.controlPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.txtRemarks = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJournalId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.controlPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.checkCustomer = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.comboJournalType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.checkSupplier = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboCustomer = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.comboSupplier = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.controlPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.cbDebit = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbChart2 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.cbCredit = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCredit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbChart1 = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.txtDebit = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel3 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.lbcredit = New DevComponents.DotNetBar.LabelX()
        Me.lbdebit = New DevComponents.DotNetBar.LabelX()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.dgSpecialJournal = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ComboItem4 = New DevComponents.Editors.ComboItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PanelEx2.SuspendLayout()
        Me.groupJournalPanel.SuspendLayout()
        Me.controlPanel1.SuspendLayout()
        Me.controlPanel3.SuspendLayout()
        Me.controlPanel2.SuspendLayout()
        Me.GroupPanel3.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.dgSpecialJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.groupJournalPanel)
        Me.PanelEx2.Controls.Add(Me.GroupPanel3)
        Me.PanelEx2.Controls.Add(Me.GroupPanel2)
        Me.PanelEx2.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx2.Location = New System.Drawing.Point(1, 0)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(1174, 510)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 15
        '
        'groupJournalPanel
        '
        Me.groupJournalPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.groupJournalPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.groupJournalPanel.Controls.Add(Me.controlPanel1)
        Me.groupJournalPanel.Controls.Add(Me.controlPanel3)
        Me.groupJournalPanel.Controls.Add(Me.controlPanel2)
        Me.groupJournalPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.groupJournalPanel.Location = New System.Drawing.Point(12, 3)
        Me.groupJournalPanel.Name = "groupJournalPanel"
        Me.groupJournalPanel.Size = New System.Drawing.Size(1150, 183)
        '
        '
        '
        Me.groupJournalPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.groupJournalPanel.Style.BackColorGradientAngle = 90
        Me.groupJournalPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.groupJournalPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupJournalPanel.Style.BorderBottomWidth = 1
        Me.groupJournalPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.groupJournalPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupJournalPanel.Style.BorderLeftWidth = 1
        Me.groupJournalPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupJournalPanel.Style.BorderRightWidth = 1
        Me.groupJournalPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.groupJournalPanel.Style.BorderTopWidth = 1
        Me.groupJournalPanel.Style.CornerDiameter = 4
        Me.groupJournalPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.groupJournalPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.groupJournalPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.groupJournalPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.groupJournalPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.groupJournalPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.groupJournalPanel.TabIndex = 0
        Me.groupJournalPanel.Text = "General Journal"
        '
        'controlPanel1
        '
        Me.controlPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.controlPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.controlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.controlPanel1.Controls.Add(Me.txtRemarks)
        Me.controlPanel1.Controls.Add(Me.Label7)
        Me.controlPanel1.Controls.Add(Me.txtJournalId)
        Me.controlPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.controlPanel1.Location = New System.Drawing.Point(3, 107)
        Me.controlPanel1.Name = "controlPanel1"
        Me.controlPanel1.Size = New System.Drawing.Size(1138, 44)
        '
        '
        '
        Me.controlPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.controlPanel1.Style.BackColorGradientAngle = 90
        Me.controlPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.controlPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel1.Style.BorderBottomWidth = 1
        Me.controlPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.controlPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel1.Style.BorderLeftWidth = 1
        Me.controlPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel1.Style.BorderRightWidth = 1
        Me.controlPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel1.Style.BorderTopWidth = 1
        Me.controlPanel1.Style.CornerDiameter = 4
        Me.controlPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.controlPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.controlPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.controlPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.controlPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.controlPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.controlPanel1.TabIndex = 2
        '
        'txtRemarks
        '
        '
        '
        '
        Me.txtRemarks.Border.Class = "TextBoxBorder"
        Me.txtRemarks.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(92, 2)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.PreventEnterBeep = True
        Me.txtRemarks.Size = New System.Drawing.Size(448, 24)
        Me.txtRemarks.TabIndex = 1
        Me.txtRemarks.WatermarkText = "Remarks"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(10, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Remarks:"
        '
        'txtJournalId
        '
        '
        '
        '
        Me.txtJournalId.Border.Class = "TextBoxBorder"
        Me.txtJournalId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtJournalId.Location = New System.Drawing.Point(1097, 17)
        Me.txtJournalId.Name = "txtJournalId"
        Me.txtJournalId.PreventEnterBeep = True
        Me.txtJournalId.Size = New System.Drawing.Size(24, 20)
        Me.txtJournalId.TabIndex = 30
        '
        'controlPanel3
        '
        Me.controlPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.controlPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.controlPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.controlPanel3.Controls.Add(Me.LinkLabel2)
        Me.controlPanel3.Controls.Add(Me.LinkLabel1)
        Me.controlPanel3.Controls.Add(Me.checkCustomer)
        Me.controlPanel3.Controls.Add(Me.comboJournalType)
        Me.controlPanel3.Controls.Add(Me.checkSupplier)
        Me.controlPanel3.Controls.Add(Me.Label4)
        Me.controlPanel3.Controls.Add(Me.comboCustomer)
        Me.controlPanel3.Controls.Add(Me.comboSupplier)
        Me.controlPanel3.Controls.Add(Me.dtp)
        Me.controlPanel3.Controls.Add(Me.Label2)
        Me.controlPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.controlPanel3.Location = New System.Drawing.Point(6, 9)
        Me.controlPanel3.Name = "controlPanel3"
        Me.controlPanel3.Size = New System.Drawing.Size(1135, 45)
        '
        '
        '
        Me.controlPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.controlPanel3.Style.BackColorGradientAngle = 90
        Me.controlPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.controlPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel3.Style.BorderBottomWidth = 1
        Me.controlPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.controlPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel3.Style.BorderLeftWidth = 1
        Me.controlPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel3.Style.BorderRightWidth = 1
        Me.controlPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel3.Style.BorderTopWidth = 1
        Me.controlPanel3.Style.CornerDiameter = 4
        Me.controlPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.controlPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.controlPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.controlPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.controlPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.controlPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.controlPanel3.TabIndex = 0
        '
        'checkCustomer
        '
        '
        '
        '
        Me.checkCustomer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkCustomer.Location = New System.Drawing.Point(892, 3)
        Me.checkCustomer.Name = "checkCustomer"
        Me.checkCustomer.Size = New System.Drawing.Size(14, 23)
        Me.checkCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkCustomer.TabIndex = 33
        '
        'comboJournalType
        '
        Me.comboJournalType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboJournalType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboJournalType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboJournalType.DisplayMember = "supplierID"
        Me.comboJournalType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboJournalType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboJournalType.FormattingEnabled = True
        Me.comboJournalType.ItemHeight = 19
        Me.comboJournalType.Location = New System.Drawing.Point(102, 4)
        Me.comboJournalType.Name = "comboJournalType"
        Me.comboJournalType.Size = New System.Drawing.Size(174, 25)
        Me.comboJournalType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.comboJournalType.TabIndex = 1
        Me.comboJournalType.ValueMember = "supplierID"
        Me.comboJournalType.WatermarkText = "Journal Type"
        '
        'checkSupplier
        '
        '
        '
        '
        Me.checkSupplier.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkSupplier.Location = New System.Drawing.Point(575, 3)
        Me.checkSupplier.Name = "checkSupplier"
        Me.checkSupplier.Size = New System.Drawing.Size(15, 23)
        Me.checkSupplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkSupplier.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Journal Type:"
        '
        'comboCustomer
        '
        Me.comboCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboCustomer.DisplayMember = "customerId"
        Me.comboCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCustomer.FormattingEnabled = True
        Me.comboCustomer.ItemHeight = 19
        Me.comboCustomer.Location = New System.Drawing.Point(724, 6)
        Me.comboCustomer.Name = "comboCustomer"
        Me.comboCustomer.Size = New System.Drawing.Size(162, 25)
        Me.comboCustomer.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.comboCustomer.TabIndex = 3
        Me.comboCustomer.ValueMember = "customerId"
        Me.comboCustomer.WatermarkText = "Fullname"
        '
        'comboSupplier
        '
        Me.comboSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comboSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comboSupplier.DisplayMember = "supplierID"
        Me.comboSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comboSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboSupplier.FormattingEnabled = True
        Me.comboSupplier.ItemHeight = 19
        Me.comboSupplier.Location = New System.Drawing.Point(397, 5)
        Me.comboSupplier.Name = "comboSupplier"
        Me.comboSupplier.Size = New System.Drawing.Size(175, 25)
        Me.comboSupplier.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.comboSupplier.TabIndex = 2
        Me.comboSupplier.ValueMember = "supplierID"
        Me.comboSupplier.WatermarkText = "Company Name"
        '
        'dtp
        '
        Me.dtp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp.Location = New System.Drawing.Point(952, 4)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(175, 24)
        Me.dtp.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(902, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Date:"
        '
        'controlPanel2
        '
        Me.controlPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.controlPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.controlPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.controlPanel2.Controls.Add(Me.cbDebit)
        Me.controlPanel2.Controls.Add(Me.cbChart2)
        Me.controlPanel2.Controls.Add(Me.cbCredit)
        Me.controlPanel2.Controls.Add(Me.Label5)
        Me.controlPanel2.Controls.Add(Me.txtCredit)
        Me.controlPanel2.Controls.Add(Me.Label3)
        Me.controlPanel2.Controls.Add(Me.cbChart1)
        Me.controlPanel2.Controls.Add(Me.txtDebit)
        Me.controlPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.controlPanel2.Location = New System.Drawing.Point(6, 57)
        Me.controlPanel2.Name = "controlPanel2"
        Me.controlPanel2.Size = New System.Drawing.Size(1135, 45)
        '
        '
        '
        Me.controlPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.controlPanel2.Style.BackColorGradientAngle = 90
        Me.controlPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.controlPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel2.Style.BorderBottomWidth = 1
        Me.controlPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.controlPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel2.Style.BorderLeftWidth = 1
        Me.controlPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel2.Style.BorderRightWidth = 1
        Me.controlPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.controlPanel2.Style.BorderTopWidth = 1
        Me.controlPanel2.Style.CornerDiameter = 4
        Me.controlPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.controlPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.controlPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.controlPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.controlPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.controlPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.controlPanel2.TabIndex = 1
        '
        'cbDebit
        '
        Me.cbDebit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbDebit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbDebit.DisplayMember = "Text"
        Me.cbDebit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDebit.FormattingEnabled = True
        Me.cbDebit.ItemHeight = 19
        Me.cbDebit.Location = New System.Drawing.Point(3, 2)
        Me.cbDebit.Name = "cbDebit"
        Me.cbDebit.Size = New System.Drawing.Size(175, 25)
        Me.cbDebit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbDebit.TabIndex = 1
        Me.cbDebit.WatermarkText = "Account Type"
        '
        'cbChart2
        '
        Me.cbChart2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbChart2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbChart2.DisplayMember = "chartId"
        Me.cbChart2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbChart2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChart2.FormattingEnabled = True
        Me.cbChart2.ItemHeight = 17
        Me.cbChart2.Location = New System.Drawing.Point(757, 3)
        Me.cbChart2.Name = "cbChart2"
        Me.cbChart2.Size = New System.Drawing.Size(177, 23)
        Me.cbChart2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbChart2.TabIndex = 5
        Me.cbChart2.ValueMember = "chartId"
        Me.cbChart2.WatermarkText = "Account Name"
        '
        'cbCredit
        '
        Me.cbCredit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbCredit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCredit.DisplayMember = "Text"
        Me.cbCredit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCredit.FormattingEnabled = True
        Me.cbCredit.ItemHeight = 19
        Me.cbCredit.Location = New System.Drawing.Point(579, 2)
        Me.cbCredit.Name = "cbCredit"
        Me.cbCredit.Size = New System.Drawing.Size(177, 25)
        Me.cbCredit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbCredit.TabIndex = 4
        Me.cbCredit.WatermarkText = "Account Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(936, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Credit:"
        '
        'txtCredit
        '
        '
        '
        '
        Me.txtCredit.Border.Class = "TextBoxBorder"
        Me.txtCredit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredit.Location = New System.Drawing.Point(994, 3)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.PreventEnterBeep = True
        Me.txtCredit.Size = New System.Drawing.Size(125, 24)
        Me.txtCredit.TabIndex = 6
        Me.txtCredit.WatermarkText = "Credit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(358, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Debit:"
        '
        'cbChart1
        '
        Me.cbChart1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbChart1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbChart1.DisplayMember = "chartId"
        Me.cbChart1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbChart1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbChart1.FormattingEnabled = True
        Me.cbChart1.ItemHeight = 17
        Me.cbChart1.Location = New System.Drawing.Point(180, 3)
        Me.cbChart1.Name = "cbChart1"
        Me.cbChart1.Size = New System.Drawing.Size(175, 23)
        Me.cbChart1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbChart1.TabIndex = 2
        Me.cbChart1.ValueMember = "chartId"
        Me.cbChart1.WatermarkText = "Account Name"
        '
        'txtDebit
        '
        '
        '
        '
        Me.txtDebit.Border.Class = "TextBoxBorder"
        Me.txtDebit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebit.Location = New System.Drawing.Point(412, 2)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.PreventEnterBeep = True
        Me.txtDebit.Size = New System.Drawing.Size(125, 24)
        Me.txtDebit.TabIndex = 3
        Me.txtDebit.WatermarkText = "Debit"
        '
        'GroupPanel3
        '
        Me.GroupPanel3.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel3.Controls.Add(Me.lbcredit)
        Me.GroupPanel3.Controls.Add(Me.lbdebit)
        Me.GroupPanel3.Controls.Add(Me.Line1)
        Me.GroupPanel3.Controls.Add(Me.LabelX2)
        Me.GroupPanel3.Controls.Add(Me.LabelX1)
        Me.GroupPanel3.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel3.Location = New System.Drawing.Point(12, 403)
        Me.GroupPanel3.Name = "GroupPanel3"
        Me.GroupPanel3.Size = New System.Drawing.Size(1151, 77)
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
        Me.GroupPanel3.TabIndex = 38
        '
        'lbcredit
        '
        Me.lbcredit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.lbcredit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbcredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbcredit.Location = New System.Drawing.Point(988, 15)
        Me.lbcredit.Name = "lbcredit"
        Me.lbcredit.Size = New System.Drawing.Size(120, 23)
        Me.lbcredit.TabIndex = 41
        Me.lbcredit.Text = "Credit"
        '
        'lbdebit
        '
        Me.lbdebit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.lbdebit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbdebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdebit.Location = New System.Drawing.Point(757, 15)
        Me.lbdebit.Name = "lbdebit"
        Me.lbdebit.Size = New System.Drawing.Size(120, 23)
        Me.lbdebit.TabIndex = 40
        Me.lbdebit.Text = "Debit"
        '
        'Line1
        '
        Me.Line1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Line1.Location = New System.Drawing.Point(3, 39)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(1141, 10)
        Me.Line1.TabIndex = 37
        Me.Line1.Text = "Line1"
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(888, 15)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(94, 23)
        Me.LabelX2.TabIndex = 36
        Me.LabelX2.Text = "Total Credit:"
        '
        'LabelX1
        '
        Me.LabelX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(669, 15)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(84, 23)
        Me.LabelX1.TabIndex = 35
        Me.LabelX1.Text = "Total Debit:"
        '
        'GroupPanel2
        '
        Me.GroupPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.dgSpecialJournal)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 192)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1150, 208)
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
        Me.GroupPanel2.TabIndex = 2
        '
        'dgSpecialJournal
        '
        Me.dgSpecialJournal.AllowUserToAddRows = False
        Me.dgSpecialJournal.AllowUserToDeleteRows = False
        Me.dgSpecialJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSpecialJournal.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgSpecialJournal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSpecialJournal.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgSpecialJournal.Location = New System.Drawing.Point(0, 0)
        Me.dgSpecialJournal.Name = "dgSpecialJournal"
        Me.dgSpecialJournal.ReadOnly = True
        Me.dgSpecialJournal.Size = New System.Drawing.Size(1144, 202)
        Me.dgSpecialJournal.TabIndex = 0
        '
        'ComboItem4
        '
        Me.ComboItem4.Text = "Account Receivable"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(596, 8)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(128, 20)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Customer Name:"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(277, 8)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(117, 20)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Supplier Name:"
        '
        'frmSpecialJournal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1175, 507)
        Me.Controls.Add(Me.PanelEx2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSpecialJournal"
        Me.Text = "frmGeneralLedger"
        Me.PanelEx2.ResumeLayout(False)
        Me.groupJournalPanel.ResumeLayout(False)
        Me.controlPanel1.ResumeLayout(False)
        Me.controlPanel1.PerformLayout()
        Me.controlPanel3.ResumeLayout(False)
        Me.controlPanel3.PerformLayout()
        Me.controlPanel2.ResumeLayout(False)
        Me.controlPanel2.PerformLayout()
        Me.GroupPanel3.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.dgSpecialJournal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents dgSpecialJournal As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCredit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtDebit As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cbChart1 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents ComboItem4 As DevComponents.Editors.ComboItem
    Friend WithEvents GroupPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents lbcredit As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbdebit As DevComponents.DotNetBar.LabelX
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents groupJournalPanel As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents controlPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbChart2 As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbDebit As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents cbCredit As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtJournalId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents comboSupplier As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents comboCustomer As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comboJournalType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents txtRemarks As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents controlPanel3 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents controlPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents checkCustomer As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents checkSupplier As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class

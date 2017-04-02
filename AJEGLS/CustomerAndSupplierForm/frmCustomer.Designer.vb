<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.CustomerIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HouseNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BarangayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MunicipalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomertypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PicturesDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CustomerlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerList = New AJEGLS.customerList()
        Me.panelRegularCustomer = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.checkPictures = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbType = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtContact = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtMunicipality = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtBarangay = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtHouseNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.txtlname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtmname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtfname = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCustomerId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.CustomerlistTableAdapter = New AJEGLS.customerListTableAdapters.customerlistTableAdapter()
        Me.btnLinkSave = New System.Windows.Forms.LinkLabel()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRegularCustomer.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.panelRegularCustomer)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1230, 535)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 186)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1142, 288)
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
        Me.GroupPanel2.TabIndex = 16
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIdDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.MnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.FullnameDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.HouseNoDataGridViewTextBoxColumn, Me.BarangayDataGridViewTextBoxColumn, Me.MunicipalityDataGridViewTextBoxColumn, Me.CustomertypeDataGridViewTextBoxColumn, Me.PicturesDataGridViewImageColumn})
        Me.DataGridViewX1.DataSource = Me.CustomerlistBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(1136, 282)
        Me.DataGridViewX1.TabIndex = 0
        '
        'CustomerIdDataGridViewTextBoxColumn
        '
        Me.CustomerIdDataGridViewTextBoxColumn.DataPropertyName = "customerId"
        Me.CustomerIdDataGridViewTextBoxColumn.HeaderText = "customerId"
        Me.CustomerIdDataGridViewTextBoxColumn.Name = "CustomerIdDataGridViewTextBoxColumn"
        Me.CustomerIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "fname"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        Me.FnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MnameDataGridViewTextBoxColumn
        '
        Me.MnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MnameDataGridViewTextBoxColumn.DataPropertyName = "mname"
        Me.MnameDataGridViewTextBoxColumn.HeaderText = "Middlename"
        Me.MnameDataGridViewTextBoxColumn.Name = "MnameDataGridViewTextBoxColumn"
        Me.MnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "lname"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        Me.LnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullnameDataGridViewTextBoxColumn
        '
        Me.FullnameDataGridViewTextBoxColumn.DataPropertyName = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.HeaderText = "fullname"
        Me.FullnameDataGridViewTextBoxColumn.Name = "FullnameDataGridViewTextBoxColumn"
        Me.FullnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HouseNoDataGridViewTextBoxColumn
        '
        Me.HouseNoDataGridViewTextBoxColumn.DataPropertyName = "houseNo"
        Me.HouseNoDataGridViewTextBoxColumn.HeaderText = "houseNo"
        Me.HouseNoDataGridViewTextBoxColumn.Name = "HouseNoDataGridViewTextBoxColumn"
        Me.HouseNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BarangayDataGridViewTextBoxColumn
        '
        Me.BarangayDataGridViewTextBoxColumn.DataPropertyName = "Barangay"
        Me.BarangayDataGridViewTextBoxColumn.HeaderText = "Barangay"
        Me.BarangayDataGridViewTextBoxColumn.Name = "BarangayDataGridViewTextBoxColumn"
        Me.BarangayDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MunicipalityDataGridViewTextBoxColumn
        '
        Me.MunicipalityDataGridViewTextBoxColumn.DataPropertyName = "municipality"
        Me.MunicipalityDataGridViewTextBoxColumn.HeaderText = "municipality"
        Me.MunicipalityDataGridViewTextBoxColumn.Name = "MunicipalityDataGridViewTextBoxColumn"
        Me.MunicipalityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustomertypeDataGridViewTextBoxColumn
        '
        Me.CustomertypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CustomertypeDataGridViewTextBoxColumn.DataPropertyName = "customertype"
        Me.CustomertypeDataGridViewTextBoxColumn.HeaderText = "Customer Type"
        Me.CustomertypeDataGridViewTextBoxColumn.Name = "CustomertypeDataGridViewTextBoxColumn"
        Me.CustomertypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PicturesDataGridViewImageColumn
        '
        Me.PicturesDataGridViewImageColumn.DataPropertyName = "pictures"
        Me.PicturesDataGridViewImageColumn.HeaderText = "pictures"
        Me.PicturesDataGridViewImageColumn.Name = "PicturesDataGridViewImageColumn"
        Me.PicturesDataGridViewImageColumn.ReadOnly = True
        '
        'CustomerlistBindingSource
        '
        Me.CustomerlistBindingSource.DataMember = "customerlist"
        Me.CustomerlistBindingSource.DataSource = Me.CustomerList
        '
        'CustomerList
        '
        Me.CustomerList.DataSetName = "customerList"
        Me.CustomerList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panelRegularCustomer
        '
        Me.panelRegularCustomer.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelRegularCustomer.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.panelRegularCustomer.Controls.Add(Me.btnLinkSave)
        Me.panelRegularCustomer.Controls.Add(Me.checkPictures)
        Me.panelRegularCustomer.Controls.Add(Me.cbType)
        Me.panelRegularCustomer.Controls.Add(Me.LabelX9)
        Me.panelRegularCustomer.Controls.Add(Me.LabelX6)
        Me.panelRegularCustomer.Controls.Add(Me.txtContact)
        Me.panelRegularCustomer.Controls.Add(Me.txtMunicipality)
        Me.panelRegularCustomer.Controls.Add(Me.txtBarangay)
        Me.panelRegularCustomer.Controls.Add(Me.LabelX5)
        Me.panelRegularCustomer.Controls.Add(Me.txtHouseNo)
        Me.panelRegularCustomer.Controls.Add(Me.LabelX4)
        Me.panelRegularCustomer.Controls.Add(Me.txtlname)
        Me.panelRegularCustomer.Controls.Add(Me.LabelX3)
        Me.panelRegularCustomer.Controls.Add(Me.LabelX2)
        Me.panelRegularCustomer.Controls.Add(Me.txtmname)
        Me.panelRegularCustomer.Controls.Add(Me.txtfname)
        Me.panelRegularCustomer.Controls.Add(Me.txtCustomerId)
        Me.panelRegularCustomer.Controls.Add(Me.GroupPanel1)
        Me.panelRegularCustomer.DisabledBackColor = System.Drawing.Color.Empty
        Me.panelRegularCustomer.Location = New System.Drawing.Point(12, 12)
        Me.panelRegularCustomer.Name = "panelRegularCustomer"
        Me.panelRegularCustomer.Size = New System.Drawing.Size(1142, 168)
        '
        '
        '
        Me.panelRegularCustomer.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelRegularCustomer.Style.BackColorGradientAngle = 90
        Me.panelRegularCustomer.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelRegularCustomer.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelRegularCustomer.Style.BorderBottomWidth = 1
        Me.panelRegularCustomer.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelRegularCustomer.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelRegularCustomer.Style.BorderLeftWidth = 1
        Me.panelRegularCustomer.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelRegularCustomer.Style.BorderRightWidth = 1
        Me.panelRegularCustomer.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelRegularCustomer.Style.BorderTopWidth = 1
        Me.panelRegularCustomer.Style.CornerDiameter = 4
        Me.panelRegularCustomer.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.panelRegularCustomer.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.panelRegularCustomer.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelRegularCustomer.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.panelRegularCustomer.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.panelRegularCustomer.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.panelRegularCustomer.TabIndex = 15
        '
        'checkPictures
        '
        '
        '
        '
        Me.checkPictures.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkPictures.Location = New System.Drawing.Point(49, 129)
        Me.checkPictures.Name = "checkPictures"
        Me.checkPictures.Size = New System.Drawing.Size(113, 23)
        Me.checkPictures.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkPictures.TabIndex = 9
        Me.checkPictures.Text = "No Picture"
        '
        'cbType
        '
        Me.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbType.DisplayMember = "Text"
        Me.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbType.FormattingEnabled = True
        Me.cbType.ItemHeight = 21
        Me.cbType.Location = New System.Drawing.Point(295, 59)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(185, 27)
        Me.cbType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbType.TabIndex = 4
        Me.cbType.WatermarkText = "Type of Customer"
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX9.Location = New System.Drawing.Point(175, 61)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(124, 23)
        Me.LabelX9.TabIndex = 30
        Me.LabelX9.Text = "Customer Type"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(496, 61)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(82, 23)
        Me.LabelX6.TabIndex = 28
        Me.LabelX6.Text = "Contact No"
        '
        'txtContact
        '
        '
        '
        '
        Me.txtContact.Border.Class = "TextBoxBorder"
        Me.txtContact.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(583, 59)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PreventEnterBeep = True
        Me.txtContact.Size = New System.Drawing.Size(163, 26)
        Me.txtContact.TabIndex = 5
        Me.txtContact.WatermarkText = "Contact Number"
        '
        'txtMunicipality
        '
        '
        '
        '
        Me.txtMunicipality.Border.Class = "TextBoxBorder"
        Me.txtMunicipality.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtMunicipality.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMunicipality.Location = New System.Drawing.Point(607, 107)
        Me.txtMunicipality.Name = "txtMunicipality"
        Me.txtMunicipality.PreventEnterBeep = True
        Me.txtMunicipality.Size = New System.Drawing.Size(447, 26)
        Me.txtMunicipality.TabIndex = 8
        Me.txtMunicipality.WatermarkText = "Municipality"
        '
        'txtBarangay
        '
        '
        '
        '
        Me.txtBarangay.Border.Class = "TextBoxBorder"
        Me.txtBarangay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBarangay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarangay.Location = New System.Drawing.Point(411, 107)
        Me.txtBarangay.Name = "txtBarangay"
        Me.txtBarangay.PreventEnterBeep = True
        Me.txtBarangay.Size = New System.Drawing.Size(178, 26)
        Me.txtBarangay.TabIndex = 7
        Me.txtBarangay.WatermarkText = "Barangay"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(173, 109)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(86, 23)
        Me.LabelX5.TabIndex = 24
        Me.LabelX5.Text = "Address"
        '
        'txtHouseNo
        '
        '
        '
        '
        Me.txtHouseNo.Border.Class = "TextBoxBorder"
        Me.txtHouseNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtHouseNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNo.Location = New System.Drawing.Point(294, 107)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.PreventEnterBeep = True
        Me.txtHouseNo.Size = New System.Drawing.Size(93, 26)
        Me.txtHouseNo.TabIndex = 6
        Me.txtHouseNo.WatermarkText = "House No"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(773, 20)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(78, 23)
        Me.LabelX4.TabIndex = 22
        Me.LabelX4.Text = "Lastname"
        '
        'txtlname
        '
        '
        '
        '
        Me.txtlname.Border.Class = "TextBoxBorder"
        Me.txtlname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(852, 18)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.PreventEnterBeep = True
        Me.txtlname.Size = New System.Drawing.Size(189, 26)
        Me.txtlname.TabIndex = 3
        Me.txtlname.WatermarkText = "Lastname"
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(485, 20)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(96, 23)
        Me.LabelX3.TabIndex = 20
        Me.LabelX3.Text = "Middlename"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(176, 20)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(75, 23)
        Me.LabelX2.TabIndex = 19
        Me.LabelX2.Text = "Firstname"
        '
        'txtmname
        '
        '
        '
        '
        Me.txtmname.Border.Class = "TextBoxBorder"
        Me.txtmname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtmname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmname.Location = New System.Drawing.Point(582, 18)
        Me.txtmname.Name = "txtmname"
        Me.txtmname.PreventEnterBeep = True
        Me.txtmname.Size = New System.Drawing.Size(183, 26)
        Me.txtmname.TabIndex = 2
        Me.txtmname.WatermarkText = "Middlename"
        '
        'txtfname
        '
        '
        '
        '
        Me.txtfname.Border.Class = "TextBoxBorder"
        Me.txtfname.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(296, 18)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.PreventEnterBeep = True
        Me.txtfname.Size = New System.Drawing.Size(183, 26)
        Me.txtfname.TabIndex = 1
        Me.txtfname.WatermarkText = "Firstname"
        '
        'txtCustomerId
        '
        '
        '
        '
        Me.txtCustomerId.Border.Class = "TextBoxBorder"
        Me.txtCustomerId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCustomerId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerId.Location = New System.Drawing.Point(762, 59)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.PreventEnterBeep = True
        Me.txtCustomerId.Size = New System.Drawing.Size(56, 26)
        Me.txtCustomerId.TabIndex = 15
        Me.txtCustomerId.WatermarkText = "Customer ID"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnBrowse)
        Me.GroupPanel1.Controls.Add(Me.picImage)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(49, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(113, 123)
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
        Me.GroupPanel1.TabIndex = 10
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowse.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnBrowse.Location = New System.Drawing.Point(0, 87)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(107, 30)
        Me.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBrowse.TabIndex = 10
        Me.btnBrowse.Text = "Browse"
        '
        'picImage
        '
        Me.picImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picImage.Image = CType(resources.GetObject("picImage.Image"), System.Drawing.Image)
        Me.picImage.Location = New System.Drawing.Point(0, 0)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(107, 88)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 0
        Me.picImage.TabStop = False
        '
        'CustomerlistTableAdapter
        '
        Me.CustomerlistTableAdapter.ClearBeforeFill = True
        '
        'btnLinkSave
        '
        Me.btnLinkSave.AutoSize = True
        Me.btnLinkSave.Location = New System.Drawing.Point(173, 0)
        Me.btnLinkSave.Name = "btnLinkSave"
        Me.btnLinkSave.Size = New System.Drawing.Size(79, 13)
        Me.btnLinkSave.TabIndex = 31
        Me.btnLinkSave.TabStop = True
        Me.btnLinkSave.Text = "Save Customer"
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1230, 535)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRegularCustomer.ResumeLayout(False)
        Me.panelRegularCustomer.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents panelRegularCustomer As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents txtContact As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtMunicipality As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBarangay As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtHouseNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtlname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtmname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtfname As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCustomerId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents btnBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbType As DevComponents.DotNetBar.Controls.ComboBoxEx
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents checkPictures As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CustomerList As AJEGLS.customerList
    Friend WithEvents CustomerlistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerlistTableAdapter As AJEGLS.customerListTableAdapters.customerlistTableAdapter
    Friend WithEvents CustomerIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HouseNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarangayDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MunicipalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomertypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PicturesDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnLinkSave As System.Windows.Forms.LinkLabel
End Class

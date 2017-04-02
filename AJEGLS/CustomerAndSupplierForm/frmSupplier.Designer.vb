<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupPanel2 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.DataGridViewX1 = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuildingnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoblacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PicDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SupplierlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierList = New AJEGLS.supplierList()
        Me.panelSupplier = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.checkLogo = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.txtContact = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtCity = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtPoblacion = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.txtBuildingNo = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.txtCompanyName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtSupplierId = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.btnBrowse = New DevComponents.DotNetBar.ButtonX()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.SupplierlistTableAdapter = New AJEGLS.supplierListTableAdapters.supplierlistTableAdapter()
        Me.btnLinkSave = New System.Windows.Forms.LinkLabel()
        Me.PanelEx1.SuspendLayout()
        Me.GroupPanel2.SuspendLayout()
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSupplier.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupPanel2)
        Me.PanelEx1.Controls.Add(Me.panelSupplier)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1150, 526)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 4
        '
        'GroupPanel2
        '
        Me.GroupPanel2.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel2.Controls.Add(Me.DataGridViewX1)
        Me.GroupPanel2.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel2.Location = New System.Drawing.Point(12, 178)
        Me.GroupPanel2.Name = "GroupPanel2"
        Me.GroupPanel2.Size = New System.Drawing.Size(1123, 289)
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
        Me.GroupPanel2.TabIndex = 17
        '
        'DataGridViewX1
        '
        Me.DataGridViewX1.AllowUserToAddRows = False
        Me.DataGridViewX1.AllowUserToDeleteRows = False
        Me.DataGridViewX1.AutoGenerateColumns = False
        Me.DataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewX1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.CompanynameDataGridViewTextBoxColumn, Me.ContactDataGridViewTextBoxColumn, Me.BuildingnoDataGridViewTextBoxColumn, Me.PoblacionDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.PicDataGridViewImageColumn})
        Me.DataGridViewX1.DataSource = Me.SupplierlistBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewX1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewX1.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.DataGridViewX1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewX1.Name = "DataGridViewX1"
        Me.DataGridViewX1.ReadOnly = True
        Me.DataGridViewX1.Size = New System.Drawing.Size(1117, 283)
        Me.DataGridViewX1.TabIndex = 0
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "supplierID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CompanynameDataGridViewTextBoxColumn
        '
        Me.CompanynameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CompanynameDataGridViewTextBoxColumn.DataPropertyName = "companyname"
        Me.CompanynameDataGridViewTextBoxColumn.HeaderText = "Company Name"
        Me.CompanynameDataGridViewTextBoxColumn.Name = "CompanynameDataGridViewTextBoxColumn"
        Me.CompanynameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContactDataGridViewTextBoxColumn
        '
        Me.ContactDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ContactDataGridViewTextBoxColumn.DataPropertyName = "contact"
        Me.ContactDataGridViewTextBoxColumn.HeaderText = "Contact"
        Me.ContactDataGridViewTextBoxColumn.Name = "ContactDataGridViewTextBoxColumn"
        Me.ContactDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuildingnoDataGridViewTextBoxColumn
        '
        Me.BuildingnoDataGridViewTextBoxColumn.DataPropertyName = "buildingno"
        Me.BuildingnoDataGridViewTextBoxColumn.HeaderText = "Building Number"
        Me.BuildingnoDataGridViewTextBoxColumn.Name = "BuildingnoDataGridViewTextBoxColumn"
        Me.BuildingnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PoblacionDataGridViewTextBoxColumn
        '
        Me.PoblacionDataGridViewTextBoxColumn.DataPropertyName = "poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.HeaderText = "poblacion"
        Me.PoblacionDataGridViewTextBoxColumn.Name = "PoblacionDataGridViewTextBoxColumn"
        Me.PoblacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        Me.CityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PicDataGridViewImageColumn
        '
        Me.PicDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PicDataGridViewImageColumn.DataPropertyName = "pic"
        Me.PicDataGridViewImageColumn.HeaderText = "Company Logo"
        Me.PicDataGridViewImageColumn.Name = "PicDataGridViewImageColumn"
        Me.PicDataGridViewImageColumn.ReadOnly = True
        '
        'SupplierlistBindingSource
        '
        Me.SupplierlistBindingSource.DataMember = "supplierlist"
        Me.SupplierlistBindingSource.DataSource = Me.SupplierList
        '
        'SupplierList
        '
        Me.SupplierList.DataSetName = "supplierList"
        Me.SupplierList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panelSupplier
        '
        Me.panelSupplier.CanvasColor = System.Drawing.SystemColors.Control
        Me.panelSupplier.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.panelSupplier.Controls.Add(Me.btnLinkSave)
        Me.panelSupplier.Controls.Add(Me.checkLogo)
        Me.panelSupplier.Controls.Add(Me.LabelX6)
        Me.panelSupplier.Controls.Add(Me.txtContact)
        Me.panelSupplier.Controls.Add(Me.txtCity)
        Me.panelSupplier.Controls.Add(Me.txtPoblacion)
        Me.panelSupplier.Controls.Add(Me.LabelX5)
        Me.panelSupplier.Controls.Add(Me.txtBuildingNo)
        Me.panelSupplier.Controls.Add(Me.LabelX2)
        Me.panelSupplier.Controls.Add(Me.txtCompanyName)
        Me.panelSupplier.Controls.Add(Me.txtSupplierId)
        Me.panelSupplier.Controls.Add(Me.GroupPanel1)
        Me.panelSupplier.DisabledBackColor = System.Drawing.Color.Empty
        Me.panelSupplier.Location = New System.Drawing.Point(12, 12)
        Me.panelSupplier.Name = "panelSupplier"
        Me.panelSupplier.Size = New System.Drawing.Size(1123, 160)
        '
        '
        '
        Me.panelSupplier.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelSupplier.Style.BackColorGradientAngle = 90
        Me.panelSupplier.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelSupplier.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelSupplier.Style.BorderBottomWidth = 1
        Me.panelSupplier.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelSupplier.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelSupplier.Style.BorderLeftWidth = 1
        Me.panelSupplier.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelSupplier.Style.BorderRightWidth = 1
        Me.panelSupplier.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.panelSupplier.Style.BorderTopWidth = 1
        Me.panelSupplier.Style.CornerDiameter = 4
        Me.panelSupplier.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.panelSupplier.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.panelSupplier.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelSupplier.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.panelSupplier.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.panelSupplier.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.panelSupplier.TabIndex = 0
        '
        'checkLogo
        '
        '
        '
        '
        Me.checkLogo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.checkLogo.Location = New System.Drawing.Point(8, 131)
        Me.checkLogo.Name = "checkLogo"
        Me.checkLogo.Size = New System.Drawing.Size(113, 23)
        Me.checkLogo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.checkLogo.TabIndex = 7
        Me.checkLogo.Text = "No Logo"
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(130, 71)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(90, 23)
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
        Me.txtContact.Location = New System.Drawing.Point(255, 69)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.PreventEnterBeep = True
        Me.txtContact.Size = New System.Drawing.Size(145, 26)
        Me.txtContact.TabIndex = 2
        Me.txtContact.WatermarkText = "Contact Number"
        '
        'txtCity
        '
        '
        '
        '
        Me.txtCity.Border.Class = "TextBoxBorder"
        Me.txtCity.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(556, 116)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.PreventEnterBeep = True
        Me.txtCity.Size = New System.Drawing.Size(467, 26)
        Me.txtCity.TabIndex = 6
        Me.txtCity.WatermarkText = "Municipality"
        '
        'txtPoblacion
        '
        '
        '
        '
        Me.txtPoblacion.Border.Class = "TextBoxBorder"
        Me.txtPoblacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtPoblacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoblacion.Location = New System.Drawing.Point(368, 116)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.PreventEnterBeep = True
        Me.txtPoblacion.Size = New System.Drawing.Size(179, 26)
        Me.txtPoblacion.TabIndex = 5
        Me.txtPoblacion.WatermarkText = "Barangay"
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(124, 118)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(96, 23)
        Me.LabelX5.TabIndex = 24
        Me.LabelX5.Text = "Address"
        '
        'txtBuildingNo
        '
        '
        '
        '
        Me.txtBuildingNo.Border.Class = "TextBoxBorder"
        Me.txtBuildingNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtBuildingNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuildingNo.Location = New System.Drawing.Point(255, 116)
        Me.txtBuildingNo.Name = "txtBuildingNo"
        Me.txtBuildingNo.PreventEnterBeep = True
        Me.txtBuildingNo.Size = New System.Drawing.Size(107, 26)
        Me.txtBuildingNo.TabIndex = 4
        Me.txtBuildingNo.WatermarkText = "Building No"
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(126, 17)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(122, 23)
        Me.LabelX2.TabIndex = 19
        Me.LabelX2.Text = "Company Name"
        '
        'txtCompanyName
        '
        '
        '
        '
        Me.txtCompanyName.Border.Class = "TextBoxBorder"
        Me.txtCompanyName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(255, 15)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.PreventEnterBeep = True
        Me.txtCompanyName.Size = New System.Drawing.Size(407, 26)
        Me.txtCompanyName.TabIndex = 1
        Me.txtCompanyName.WatermarkText = "Company Name"
        '
        'txtSupplierId
        '
        '
        '
        '
        Me.txtSupplierId.Border.Class = "TextBoxBorder"
        Me.txtSupplierId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtSupplierId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplierId.Location = New System.Drawing.Point(676, 14)
        Me.txtSupplierId.Name = "txtSupplierId"
        Me.txtSupplierId.PreventEnterBeep = True
        Me.txtSupplierId.Size = New System.Drawing.Size(53, 26)
        Me.txtSupplierId.TabIndex = 15
        Me.txtSupplierId.WatermarkText = "Supplier ID"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.btnBrowse)
        Me.GroupPanel1.Controls.Add(Me.picImage)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(5, 3)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(113, 128)
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
        Me.GroupPanel1.TabIndex = 14
        '
        'btnBrowse
        '
        Me.btnBrowse.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnBrowse.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnBrowse.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnBrowse.Location = New System.Drawing.Point(0, 92)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(107, 30)
        Me.btnBrowse.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse Logo"
        '
        'picImage
        '
        Me.picImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.picImage.Image = CType(resources.GetObject("picImage.Image"), System.Drawing.Image)
        Me.picImage.Location = New System.Drawing.Point(0, 0)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(107, 91)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 0
        Me.picImage.TabStop = False
        '
        'SupplierlistTableAdapter
        '
        Me.SupplierlistTableAdapter.ClearBeforeFill = True
        '
        'btnLinkSave
        '
        Me.btnLinkSave.AutoSize = True
        Me.btnLinkSave.Location = New System.Drawing.Point(126, 1)
        Me.btnLinkSave.Name = "btnLinkSave"
        Me.btnLinkSave.Size = New System.Drawing.Size(73, 13)
        Me.btnLinkSave.TabIndex = 29
        Me.btnLinkSave.TabStop = True
        Me.btnLinkSave.Text = "Save Supplier"
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 526)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupPanel2.ResumeLayout(False)
        CType(Me.DataGridViewX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSupplier.ResumeLayout(False)
        Me.panelSupplier.PerformLayout()
        Me.GroupPanel1.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panelSupplier As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtContact As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtCity As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtCompanyName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtSupplierId As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents btnBrowse As DevComponents.DotNetBar.ButtonX
    Friend WithEvents picImage As System.Windows.Forms.PictureBox
    Friend WithEvents txtPoblacion As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtBuildingNo As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents GroupPanel2 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents DataGridViewX1 As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents SupplierList As AJEGLS.supplierList
    Friend WithEvents SupplierlistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierlistTableAdapter As AJEGLS.supplierListTableAdapters.supplierlistTableAdapter
    Friend WithEvents checkLogo As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanynameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuildingnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoblacionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PicDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents btnLinkSave As System.Windows.Forms.LinkLabel
End Class

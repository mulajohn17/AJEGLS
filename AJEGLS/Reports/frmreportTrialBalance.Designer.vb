<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreportTrialBalance
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.filtertrialbalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsTrialBalanceMain = New AJEGLS.dsTrialBalanceMain()
        Me.filterOwnersStatementBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsOwnersStatement = New AJEGLS.dsOwnersStatement()
        Me.DateTimePickerReport = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewerTrialBalance = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptGroupPanel = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.ReportViewerOwners = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ReportViewerIncome = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.rptMainPanel = New DevComponents.DotNetBar.PanelEx()
        Me.reportcategorypanel = New DevComponents.DotNetBar.PanelEx()
        Me.MetroTilePanel1 = New DevComponents.DotNetBar.Metro.MetroTilePanel()
        Me.reportCategoryContainer = New DevComponents.DotNetBar.ItemContainer()
        Me.tileTrialBalance = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.tileIncomeStatement = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.tileOwners = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.tileBalanceSheet = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.filtertrialbalanceTableAdapter = New AJEGLS.dsTrialBalanceMainTableAdapters.filtertrialbalanceTableAdapter()
        Me.dsIncomeStatement = New AJEGLS.dsIncomeStatement()
        Me.filterOwnersStatementTableAdapter = New AJEGLS.dsOwnersStatementTableAdapters.filterOwnersStatementTableAdapter()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        CType(Me.filtertrialbalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsTrialBalanceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filterOwnersStatementBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsOwnersStatement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rptGroupPanel.SuspendLayout()
        Me.rptMainPanel.SuspendLayout()
        Me.reportcategorypanel.SuspendLayout()
        CType(Me.dsIncomeStatement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'filtertrialbalanceBindingSource
        '
        Me.filtertrialbalanceBindingSource.DataMember = "filtertrialbalance"
        Me.filtertrialbalanceBindingSource.DataSource = Me.dsTrialBalanceMain
        '
        'dsTrialBalanceMain
        '
        Me.dsTrialBalanceMain.DataSetName = "dsTrialBalanceMain"
        Me.dsTrialBalanceMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'filterOwnersStatementBindingSource
        '
        Me.filterOwnersStatementBindingSource.DataMember = "filterOwnersStatement"
        Me.filterOwnersStatementBindingSource.DataSource = Me.dsOwnersStatement
        '
        'dsOwnersStatement
        '
        Me.dsOwnersStatement.DataSetName = "dsOwnersStatement"
        Me.dsOwnersStatement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateTimePickerReport
        '
        Me.DateTimePickerReport.CustomFormat = "MMMM dd, yyyy"
        Me.DateTimePickerReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerReport.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerReport.Location = New System.Drawing.Point(118, 5)
        Me.DateTimePickerReport.Name = "DateTimePickerReport"
        Me.DateTimePickerReport.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePickerReport.TabIndex = 1
        '
        'ReportViewerTrialBalance
        '
        Me.ReportViewerTrialBalance.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsTrialBalance"
        ReportDataSource1.Value = Me.filtertrialbalanceBindingSource
        Me.ReportViewerTrialBalance.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewerTrialBalance.LocalReport.ReportEmbeddedResource = "AJEGLS.rdlcTrialBalance.rdlc"
        Me.ReportViewerTrialBalance.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerTrialBalance.Name = "ReportViewerTrialBalance"
        Me.ReportViewerTrialBalance.Size = New System.Drawing.Size(627, 475)
        Me.ReportViewerTrialBalance.TabIndex = 2
        '
        'rptGroupPanel
        '
        Me.rptGroupPanel.BackColor = System.Drawing.Color.Transparent
        Me.rptGroupPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.rptGroupPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.rptGroupPanel.Controls.Add(Me.ReportViewerOwners)
        Me.rptGroupPanel.Controls.Add(Me.ReportViewerIncome)
        Me.rptGroupPanel.Controls.Add(Me.ReportViewerTrialBalance)
        Me.rptGroupPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.rptGroupPanel.Location = New System.Drawing.Point(413, 0)
        Me.rptGroupPanel.Name = "rptGroupPanel"
        Me.rptGroupPanel.Size = New System.Drawing.Size(633, 481)
        '
        '
        '
        Me.rptGroupPanel.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.rptGroupPanel.Style.BackColorGradientAngle = 90
        Me.rptGroupPanel.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.rptGroupPanel.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.rptGroupPanel.Style.BorderBottomWidth = 1
        Me.rptGroupPanel.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.rptGroupPanel.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.rptGroupPanel.Style.BorderLeftWidth = 1
        Me.rptGroupPanel.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.rptGroupPanel.Style.BorderRightWidth = 1
        Me.rptGroupPanel.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.rptGroupPanel.Style.BorderTopWidth = 1
        Me.rptGroupPanel.Style.CornerDiameter = 4
        Me.rptGroupPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.rptGroupPanel.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.rptGroupPanel.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.rptGroupPanel.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.rptGroupPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.rptGroupPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.rptGroupPanel.TabIndex = 3
        '
        'ReportViewerOwners
        '
        Me.ReportViewerOwners.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "dataOwnersStatement"
        ReportDataSource2.Value = Me.filterOwnersStatementBindingSource
        Me.ReportViewerOwners.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewerOwners.LocalReport.ReportEmbeddedResource = "AJEGLS.rdlcOwnersEquity.rdlc"
        Me.ReportViewerOwners.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerOwners.Name = "ReportViewerOwners"
        Me.ReportViewerOwners.Size = New System.Drawing.Size(627, 475)
        Me.ReportViewerOwners.TabIndex = 4
        '
        'ReportViewerIncome
        '
        Me.ReportViewerIncome.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "dsTrialBalance"
        ReportDataSource3.Value = Me.filtertrialbalanceBindingSource
        Me.ReportViewerIncome.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewerIncome.LocalReport.ReportEmbeddedResource = "AJEGLS.rdlcIncomeStatement.rdlc"
        Me.ReportViewerIncome.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewerIncome.Name = "ReportViewerIncome"
        Me.ReportViewerIncome.Size = New System.Drawing.Size(627, 475)
        Me.ReportViewerIncome.TabIndex = 3
        '
        'rptMainPanel
        '
        Me.rptMainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.rptMainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.rptMainPanel.Controls.Add(Me.reportcategorypanel)
        Me.rptMainPanel.Controls.Add(Me.rptGroupPanel)
        Me.rptMainPanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.rptMainPanel.Location = New System.Drawing.Point(0, 0)
        Me.rptMainPanel.Name = "rptMainPanel"
        Me.rptMainPanel.Size = New System.Drawing.Size(1046, 484)
        Me.rptMainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.rptMainPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.rptMainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.rptMainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.rptMainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.rptMainPanel.Style.GradientAngle = 90
        Me.rptMainPanel.TabIndex = 4
        '
        'reportcategorypanel
        '
        Me.reportcategorypanel.CanvasColor = System.Drawing.SystemColors.Control
        Me.reportcategorypanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.reportcategorypanel.Controls.Add(Me.LabelX1)
        Me.reportcategorypanel.Controls.Add(Me.MetroTilePanel1)
        Me.reportcategorypanel.Controls.Add(Me.DateTimePickerReport)
        Me.reportcategorypanel.DisabledBackColor = System.Drawing.Color.Empty
        Me.reportcategorypanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.reportcategorypanel.Location = New System.Drawing.Point(0, 0)
        Me.reportcategorypanel.Name = "reportcategorypanel"
        Me.reportcategorypanel.Size = New System.Drawing.Size(407, 484)
        Me.reportcategorypanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.reportcategorypanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.reportcategorypanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.reportcategorypanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.reportcategorypanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.reportcategorypanel.Style.GradientAngle = 90
        Me.reportcategorypanel.TabIndex = 5
        '
        'MetroTilePanel1
        '
        '
        '
        '
        Me.MetroTilePanel1.BackgroundStyle.Class = "MetroTilePanel"
        Me.MetroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTilePanel1.ContainerControlProcessDialogKey = True
        Me.MetroTilePanel1.DragDropSupport = True
        Me.MetroTilePanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.reportCategoryContainer})
        Me.MetroTilePanel1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
        Me.MetroTilePanel1.Location = New System.Drawing.Point(-2, 37)
        Me.MetroTilePanel1.Name = "MetroTilePanel1"
        Me.MetroTilePanel1.Size = New System.Drawing.Size(436, 329)
        Me.MetroTilePanel1.TabIndex = 4
        Me.MetroTilePanel1.Text = "MetroTilePanel1"
        '
        'reportCategoryContainer
        '
        '
        '
        '
        Me.reportCategoryContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.reportCategoryContainer.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Center
        Me.reportCategoryContainer.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.reportCategoryContainer.MultiLine = True
        Me.reportCategoryContainer.Name = "reportCategoryContainer"
        Me.reportCategoryContainer.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.tileTrialBalance, Me.tileIncomeStatement, Me.tileOwners, Me.tileBalanceSheet})
        '
        '
        '
        Me.reportCategoryContainer.TitleStyle.Class = "MetroTileGroupTitle"
        Me.reportCategoryContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.reportCategoryContainer.TitleStyle.TextShadowColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.reportCategoryContainer.TitleText = "Report Category"
        '
        'tileTrialBalance
        '
        Me.tileTrialBalance.Name = "tileTrialBalance"
        Me.tileTrialBalance.SymbolColor = System.Drawing.Color.Empty
        Me.tileTrialBalance.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.tileTrialBalance.TileSize = New System.Drawing.Size(200, 90)
        '
        '
        '
        Me.tileTrialBalance.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tileTrialBalance.TitleText = "Trial Balance "
        Me.tileTrialBalance.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.tileTrialBalance.TitleTextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tileIncomeStatement
        '
        Me.tileIncomeStatement.Name = "tileIncomeStatement"
        Me.tileIncomeStatement.SymbolColor = System.Drawing.Color.Empty
        Me.tileIncomeStatement.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.tileIncomeStatement.TileSize = New System.Drawing.Size(200, 90)
        '
        '
        '
        Me.tileIncomeStatement.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tileIncomeStatement.TitleText = "Income Statement"
        Me.tileIncomeStatement.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.tileIncomeStatement.TitleTextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tileOwners
        '
        Me.tileOwners.Name = "tileOwners"
        Me.tileOwners.SymbolColor = System.Drawing.Color.Empty
        Me.tileOwners.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.tileOwners.TileSize = New System.Drawing.Size(200, 90)
        '
        '
        '
        Me.tileOwners.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tileOwners.TitleText = "Owner's Equity Statement"
        Me.tileOwners.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.tileOwners.TitleTextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'tileBalanceSheet
        '
        Me.tileBalanceSheet.Name = "tileBalanceSheet"
        Me.tileBalanceSheet.SymbolColor = System.Drawing.Color.Empty
        Me.tileBalanceSheet.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.tileBalanceSheet.TileSize = New System.Drawing.Size(200, 90)
        '
        '
        '
        Me.tileBalanceSheet.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tileBalanceSheet.TitleText = "Balance Sheet"
        Me.tileBalanceSheet.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.tileBalanceSheet.TitleTextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'filtertrialbalanceTableAdapter
        '
        Me.filtertrialbalanceTableAdapter.ClearBeforeFill = True
        '
        'dsIncomeStatement
        '
        Me.dsIncomeStatement.DataSetName = "dsIncomeStatement"
        Me.dsIncomeStatement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'filterOwnersStatementTableAdapter
        '
        Me.filterOwnersStatementTableAdapter.ClearBeforeFill = True
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(7, 5)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(105, 23)
        Me.LabelX1.TabIndex = 5
        Me.LabelX1.Text = "Select Month:"
        '
        'frmreportTrialBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 486)
        Me.Controls.Add(Me.rptMainPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmreportTrialBalance"
        CType(Me.filtertrialbalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsTrialBalanceMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filterOwnersStatementBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsOwnersStatement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rptGroupPanel.ResumeLayout(False)
        Me.rptMainPanel.ResumeLayout(False)
        Me.reportcategorypanel.ResumeLayout(False)
        CType(Me.dsIncomeStatement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DateTimePickerReport As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewerTrialBalance As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents filtertrialbalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsTrialBalanceMain As AJEGLS.dsTrialBalanceMain
    Friend WithEvents filtertrialbalanceTableAdapter As AJEGLS.dsTrialBalanceMainTableAdapters.filtertrialbalanceTableAdapter
    Friend WithEvents rptGroupPanel As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rptMainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents MetroTilePanel1 As DevComponents.DotNetBar.Metro.MetroTilePanel
    Friend WithEvents reportCategoryContainer As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents tileTrialBalance As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents tileIncomeStatement As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents tileOwners As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents tileBalanceSheet As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents reportcategorypanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents dsIncomeStatement As AJEGLS.dsIncomeStatement
    Friend WithEvents ReportViewerOwners As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents filterOwnersStatementBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsOwnersStatement As AJEGLS.dsOwnersStatement
    Friend WithEvents ReportViewerIncome As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents filterOwnersStatementTableAdapter As AJEGLS.dsOwnersStatementTableAdapters.filterOwnersStatementTableAdapter
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class

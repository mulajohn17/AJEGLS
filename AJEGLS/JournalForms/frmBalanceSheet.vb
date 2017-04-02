Public Class frmBalanceSheet

    Private Sub frmBalanceSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Loadassetsandliabilities.assetsandliabilities' table. You can move, or remove it, as needed.
        Me.AssetsandliabilitiesTableAdapter.FillAssets(Me.Loadassetsandliabilities.assetsandliabilities)
        'TODO: This line of code loads data into the 'LoadLiabities.loadliabilities' table. You can move, or remove it, as needed.
        Me.LoadliabilitiesTableAdapter.FillLiabilities(Me.LoadLiabities.loadliabilities)
        'TODO: This line of code loads data into the 'Loadassetsandliabilities.assetsandliabilities' table. You can move, or remove it, as needed.
        Me.AssetsandliabilitiesTableAdapter.FillAssets(Me.Loadassetsandliabilities.assetsandliabilities)

        total()
        pesoSign()
        DataGridConfig()
        filterBalanceSheetAsset()
        filterBalanceSheetLiabilities()
        filterBalanceSheetOwnerEquity()
        GroupPanel2.Select()
    End Sub
    Public Sub total()
        Dim debit As Decimal = 0.0
        Dim total As Double = "0.00"
        For i As Decimal = 0.0 To DataGridViewX1.RowCount - 1
            debit += DataGridViewX1.Rows(i).Cells(1).Value
        Next
        txttotaldebit.Text = debit

        If IsNumeric(txttotaldebit.Text) Then

            Dim temp As Double = txttotaldebit.Text

            txttotaldebit.Text = "Ᵽ" & Format(temp, "N")

        End If
        '  txtdebitgrandtotal.Text = "Ᵽ" & debit

        Dim credit As Double = "0.00"
        For i As Double = 0.0 To DataGridViewX3.RowCount - 1
            credit += DataGridViewX3.Rows(i).Cells(1).Value
        Next

        txttotalcredit.Text = credit
        total = Val(txttotalcredit.Text) + Val(ecapitaltotal.Text)
        txtcreditgrandtotal.Text = total

        If IsNumeric(ecapitaltotal.Text) Then

            Dim temp As Double = ecapitaltotal.Text

            ecapitaltotal.Text = "Ᵽ" & Format(temp, "N")

        End If

        If IsNumeric(txttotalcredit.Text) Then

            Dim temp As Double = txttotalcredit.Text

            txttotalcredit.Text = "Ᵽ" & Format(temp, "N")

        End If

        If IsNumeric(txtcreditgrandtotal.Text) Then

            Dim temp As Double = txtcreditgrandtotal.Text

            txtcreditgrandtotal.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub

    Private Sub DataGridViewX2_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX2.CellClick
        balancesheetOwnersEquityPassData()
        total()
    End Sub

    Private Sub DataGridViewX2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX2.KeyDown, DataGridViewX2.KeyUp
        balancesheetOwnersEquityPassData()
    End Sub

    Private Sub DataGridViewX1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX1.CellContentClick

    End Sub

    Private Sub DataGridViewX3_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewX3.CellClick
        balancesheetLiabilitiesPassData()
    End Sub
    Private Sub DataGridViewX3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX3.KeyDown, DataGridViewX3.KeyUp
        balancesheetLiabilitiesPassData()
    End Sub
    Public Sub pesoSign()
        DataGridViewX1.Columns(1).DefaultCellStyle.Format = "C"
        DataGridViewX1.Columns(1).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

        DataGridViewX3.Columns(1).DefaultCellStyle.Format = "C"
        DataGridViewX3.Columns(1).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")

    End Sub
    Public Sub DataGridConfig()
        DataGridViewX1.Columns(2).Visible = False
        DataGridViewX1.Columns(3).Visible = False
        DataGridViewX1.Columns(4).Visible = False

        DataGridViewX3.Columns(2).Visible = False
        DataGridViewX3.Columns(3).Visible = False
        DataGridViewX3.Columns(4).Visible = False
        '  DataGridViewX2.Columns(0).Visible = False
        ' DataGridViewX2.Columns(5).Visible = False
        DataGridViewX1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewX1.ColumnHeadersVisible = False
        DataGridViewX3.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewX3.ColumnHeadersVisible = False
        DataGridViewX1.Enabled = False
        DataGridViewX3.Enabled = False    
    End Sub

End Class
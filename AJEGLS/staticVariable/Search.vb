Imports System.Data.SqlClient
Imports System.Globalization
Module Search
    'AutoComplete TextBox Search
    Public Sub customerautocomplete()
        Dim autocomplete As New AutoCompleteStringCollection()
        Dim cmdauto As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds As New DataSet

        With cmdauto
            .CommandType = CommandType.Text
            .CommandText = "Select fullname from customertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap As New SqlDataAdapter(cmdauto)
        sqladap.Fill(ds)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            autocomplete.Add(ds.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmMain.TextBoxX1.AutoCompleteMode = AutoCompleteMode.Suggest
        frmMain.TextBoxX1.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmMain.TextBoxX1.AutoCompleteCustomSource = autocomplete

    End Sub
    'AutoComplete TextBoxSearch
    Public Sub supplierautocomplete()
        Dim autocomplete As New AutoCompleteStringCollection()
        Dim cmdauto As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds As New DataSet

        With cmdauto
            .CommandType = CommandType.Text
            .CommandText = "Select companyname from suppliertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap As New SqlDataAdapter(cmdauto)
        sqladap.Fill(ds)
        For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
            autocomplete.Add(ds.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmMain.TextBoxX1.AutoCompleteMode = AutoCompleteMode.Suggest
        frmMain.TextBoxX1.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmMain.TextBoxX1.AutoCompleteCustomSource = autocomplete

    End Sub
    'Search By Customer Fullname
    Public Sub searchCustomer()
        Dim reader As SqlDataReader
        Try
            Dim cmd3 As New SqlCommand
            With cmd3
                .CommandText = "SELECT dbo.customertbl.customerId, dbo.customertbl.fname, dbo.customertbl.mname, dbo.customertbl.lname, dbo.customertbl.contact, dbo.customertbl.houseNo, dbo.customertbl.Barangay, dbo.customertbl.municipality,  dbo.customertypetbl.customertype FROM  dbo.customertbl INNER JOIN  dbo.customertypetbl ON dbo.customertbl.customertypeid = dbo.customertypetbl.customertypeid where fullname = @p"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@p", SqlDbType.VarChar).Value = frmMain.TextBoxX1.Text
                reader = .ExecuteReader
            End With



            '  reader.Read()
            While reader.Read()
                ' autocomplete.Add(reader("fullname"))
                frmCustomer.txtCustomerId.Text = reader.GetValue(0)
                frmCustomer.txtfname.Text = reader.GetValue(1)
                frmCustomer.txtmname.Text = reader.GetValue(2)
                frmCustomer.txtlname.Text = reader.GetValue(3)
                frmCustomer.txtContact.Text = reader.GetValue(5)
                frmCustomer.txtHouseNo.Text = reader.GetValue(6)
                frmCustomer.txtBarangay.Text = reader.GetValue(7)
                frmCustomer.txtMunicipality.Text = reader.GetValue(8)
                frmCustomer.cbType.Text = reader.GetValue(9)
                'frmCustomer.txtfname.Text = reader.GetValue(11)
                '  con.Close()

            End While
            reader.Close()
            ' Dim fname As String
            ' fname = reader.GetValue("fullname")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        Finally


        End Try
        retrievecustomerimage()

    End Sub
    Public Sub retrievecustomerimage()
        Dim cmdd As New SqlCommand
        With cmdd
            .CommandText = "select pictures from customertbl where customerId = '" + frmCustomer.txtCustomerId.Text + "' "
            .Connection = con
            .Parameters.Clear()
        End With
        Dim da As New SqlDataAdapter(cmdd)
        Dim dss As New DataSet
        da.Fill(dss, "customertbl")
        Dim c As Integer = dss.Tables(0).Rows.Count
        If c > 0 Then
            Dim p() As Byte = dss.Tables(0).Rows(c - 1)("pictures")
            Dim ms As New IO.MemoryStream(p)
            frmCustomer.picImage.Image = Image.FromStream(ms)
        End If
    End Sub
    'Search Supplier By CompanyName
    Public Sub searchSupplier()
        Dim reader As SqlDataReader
        Try
            Dim cmd3 As New SqlCommand
            With cmd3
                .CommandText = "select * from suppliertbl where companyname = @p"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@p", SqlDbType.VarChar).Value = frmMain.TextBoxX1.Text
                reader = .ExecuteReader
            End With



            '  reader.Read()
            While reader.Read()
                ' autocomplete.Add(reader("fullname"))

                frmSupplier.txtSupplierId.Text = reader.GetValue(0)
                frmSupplier.txtCompanyName.Text = reader.GetValue(1)
                frmSupplier.txtContact.Text = reader.GetValue(2)
                frmSupplier.txtBuildingNo.Text = reader.GetValue(3)
                frmSupplier.txtPoblacion.Text = reader.GetValue(4)
                frmSupplier.txtCity.Text = reader.GetValue(5)

                'frmCustomer.txtfname.Text = reader.GetValue(11)
                '  con.Close()

            End While
            reader.Close()
            ' Dim fname As String
            ' fname = reader.GetValue("fullname")
            retrievesupplierimage()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            '
        End Try

    End Sub
    Public Sub retrievesupplierimage()
        Dim cmdd As New SqlCommand
        With cmdd
            .CommandText = "select pic from suppliertbl where supplierID = '" + frmSupplier.txtSupplierId.Text + "' "
            .Connection = con
            .Parameters.Clear()
        End With
        Dim da As New SqlDataAdapter(cmdd)
        Dim dss As New DataSet
        da.Fill(dss, "suppliertbl")
        Dim c As Integer = dss.Tables(0).Rows.Count
        If c > 0 Then
            Dim p() As Byte = dss.Tables(0).Rows(c - 1)("pic")
            Dim ms As New IO.MemoryStream(p)
            frmSupplier.picImage.Image = Image.FromStream(ms)
        End If
    End Sub

    'Search Sales By Customer
    Public Sub salesDataGridViewSearch()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda2 As New SqlDataAdapter
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterSalesJournal"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@searchname", SqlDbType.Text).Value = frmMain.TextBoxX1.Text
            End With
            sda2.SelectCommand = cmd
            dt.Clear()
            sda2.Fill(dt)
            frmSalesJournal.DataGridViewX1.DataSource = dt
            ' total()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub
    'Search Purchase By Supplier
    Public Sub purchaseDataGridViewSearch()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda2 As New SqlDataAdapter
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterPurchaseJournal"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@searchname", SqlDbType.Text).Value = frmMain.TextBoxX1.Text
            End With
            sda2.SelectCommand = cmd
            dt.Clear()
            sda2.Fill(dt)
            frmPurchase.DataGridViewX1.DataSource = dt
            ' total()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub
    'Search Cash By Customer
    Public Sub CashDataGridViewSearch()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda2 As New SqlDataAdapter
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterCashJournal"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@searchname", SqlDbType.Text).Value = frmMain.TextBoxX1.Text
            End With
            sda2.SelectCommand = cmd
            dt.Clear()
            sda2.Fill(dt)
            frmCashReceipt.DataGridViewX1.DataSource = dt
            ' total()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub
    'Search Disburse By Customer
    Public Sub DisburseDataGridViewSearch()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda2 As New SqlDataAdapter
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filterDisburseJournal"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@searchname", SqlDbType.Text).Value = frmMain.TextBoxX1.Text
            End With
            sda2.SelectCommand = cmd
            dt.Clear()
            sda2.Fill(dt)
            frmDisbursement.DataGridViewX1.DataSource = dt
            ' total()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub

    'Search General By Journal Category
    Public Sub generalDataGridViewSearch()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda2 As New SqlDataAdapter

        'Dim dtpmonth = frmMain.DateTimePicker1.Value.Month
        'Dim dtpyear = frmMain.DateTimePicker1.Value.Year
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "filtergeneralJournal"
                .Connection = con
                .Parameters.Clear()
                .Parameters.Add("@searchname", SqlDbType.Text).Value = frmMain.TextBoxX1.Text
            End With
            sda2.SelectCommand = cmd
            dt.Clear()
            sda2.Fill(dt)
            frmGeneralLedger.DataGridViewX1.DataSource = dt
            ' total()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub
    Public Sub filterIncomeDate()
        With frmMain
            frmIncomeStatement.LabelX9.Text = " " & .DateTimePicker1.Value.ToString("MMMM dd yyyy")
        End With

    End Sub
    Public Sub filterOwnersDate()
        With frmMain
            frmOwners.LabelX9.Text = " " & .DateTimePicker1.Value.ToString("MMMM dd yyyy")
        End With

    End Sub
    Public Sub filterTrialBalancebyMonth()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda1 As New SqlDataAdapter
        '  Dim val As String = DataGridViewX1.CurrentRow.Cells(0).Value
        Dim dtpmonth = frmMain.DateTimePicker1.Value.Month
        Dim dtpyear = frmMain.DateTimePicker1.Value.Year
        '  Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
        Dim month As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "filtertrialbalance"
                .Parameters.Clear()
                .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
                .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With
            '  cellSelect = dgRecord.SelectedCells
            sda1.SelectCommand = cmd
            ' TextBoxX1.Text = month
            ' ds.Clear()
            dt.Clear()
            sda1.Fill(dt)
            frmsummarizingresult.DataGridViewX1.DataSource = dt
            frmsummarizingresult.total()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub

    Public Sub filteriIncomeStatementbyMonth()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda1 As New SqlDataAdapter

        '  Dim val As String = DataGridViewX1.CurrentRow.Cells(0).Value
        Dim dtpmonth = frmMain.DateTimePicker1.Value.Month
        Dim dtpyear = frmMain.DateTimePicker1.Value.Year
        '  Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
        Dim month As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "filterincomeStatementbalance"
                .Parameters.Clear()
                .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
                .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With

            sda1.SelectCommand = cmd
            dt.Clear()
            sda1.Fill(dt)
            frmIncomeStatement.dgIncomeStatementRevenu.DataSource = dt
            frmIncomeStatement.total()

            ' frmsummarizingresult.total()
            '    con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub
    Public Sub filteriIncomeStatementbyMonth1()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda1 As New SqlDataAdapter

        '  Dim val As String = DataGridViewX1.CurrentRow.Cells(0).Value
        Dim dtpmonth = frmMain.DateTimePicker1.Value.Month
        Dim dtpyear = frmMain.DateTimePicker1.Value.Year
        '  Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
        Dim month As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "filterincomeStatementbalance1"
                .Parameters.Clear()
                .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
                .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With

            sda1.SelectCommand = cmd
            dt.Clear()
            sda1.Fill(dt)
            frmIncomeStatement.dgIncomeStatementExpense.DataSource = dt
            frmIncomeStatement.total()
            ' frmsummarizingresult.total()
            ' con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub

    Public Sub filterOwnersWithdrawal()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda1 As New SqlDataAdapter

        '  Dim val As String = DataGridViewX1.CurrentRow.Cells(0).Value
        Dim dtpmonth = frmMain.DateTimePicker1.Value.Month
        Dim dtpyear = frmMain.DateTimePicker1.Value.Year
        '  Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
        Dim month As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "filterOwnersWithdrawal"
                .Parameters.Clear()
                .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
                .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With
            sda1.SelectCommand = cmd
            dt.Clear()
            sda1.Fill(dt)
            frmOwners.DataGridViewX1.DataSource = dt
            ownersdefault()
            frmOwners.calculateendingcapital()
            ' frmsummarizingresult.total()
            ' con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub

    Public Sub filterOwnersNetIncome()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda1 As New SqlDataAdapter

        '  Dim val As String = DataGridViewX1.CurrentRow.Cells(0).Value
        'Dim dtpmonth = frmMain.DateTimePicker1.Value.Month
        'Dim dtpyear = frmMain.DateTimePicker1.Value.Year
        ''  Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
        ' Dim month As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "filterOwnersNetIncome"
                .Parameters.Clear()
                .Parameters.Add("@date", SqlDbType.Date).Value = frmMain.DateTimePicker1.Value
                ' .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With

            sda1.SelectCommand = cmd
            dt.Clear()
            sda1.Fill(dt)
            frmOwners.DataGridViewX2.DataSource = dt
            ownersdefault()
            frmOwners.calculateendingcapital()
            ' frmsummarizingresult.total()
            ' con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub

    Public Sub filterBalanceSheetAsset()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda1 As New SqlDataAdapter

        '  Dim val As String = DataGridViewX1.CurrentRow.Cells(0).Value
        Dim dtpmonth = frmMain.DateTimePicker1.Value.Month
        Dim dtpyear = frmMain.DateTimePicker1.Value.Year
        '  Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
        Dim month As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "filterBalanceSheetAsset"
                .Parameters.Clear()
                .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
                .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With

            sda1.SelectCommand = cmd
            dt.Clear()
            sda1.Fill(dt)
            frmBalanceSheet.DataGridViewX1.DataSource = dt
            frmBalanceSheet.total()
            ' frmsummarizingresult.total()
            ' con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub

    Public Sub filterBalanceSheetLiabilities()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda1 As New SqlDataAdapter

        '  Dim val As String = DataGridViewX1.CurrentRow.Cells(0).Value
        Dim dtpmonth = frmMain.DateTimePicker1.Value.Month
        Dim dtpyear = frmMain.DateTimePicker1.Value.Year
        '  Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
        Dim month As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "filterBalanceSheetLiabilities"
                .Parameters.Clear()
                .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
                .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With

            sda1.SelectCommand = cmd
            dt.Clear()
            sda1.Fill(dt)
            frmBalanceSheet.DataGridViewX3.DataSource = dt
            frmBalanceSheet.total()

            ' frmsummarizingresult.total()
            ' con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub

    Public Sub filterBalanceSheetOwnerEquity()
        Dim dt As New DataTable
        Dim ds As New DataSet
        Dim sda1 As New SqlDataAdapter

        '  Dim val As String = DataGridViewX1.CurrentRow.Cells(0).Value
        'Dim dtpmonth = frmMain.DateTimePicker1.Value.Month
        'Dim dtpyear = frmMain.DateTimePicker1.Value.Year
        ''  Dim day = New DateTime(DateTimePicker1.Value.Year, DateTimePicker1.Value.Month, 1).AddMonths(1).AddDays(-1).Day
        ' Dim month As String = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtpmonth)
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Connection = con
                .CommandText = "filterBalanceSheetOwnerEquity"
                .Parameters.Clear()
                .Parameters.Add("@date", SqlDbType.Date).Value = frmMain.DateTimePicker1.Value
                frmBalanceSheet.total()
                frmBalanceSheet.ecapitaltotal.Text = "0.00"
                ' .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With

            sda1.SelectCommand = cmd
            dt.Clear()
            sda1.Fill(dt)
            frmBalanceSheet.DataGridViewX2.DataSource = dt
            frmBalanceSheet.total()
            ' frmsummarizingresult.total()
            ' con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        ' TextBoxX1.Text = day
    End Sub

End Module

Imports System.Data.SqlClient
Module customerAndSupplierCondition
    Public Sub retrieveCustomerType()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveCustomerType"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)


            frmCustomer.cbType.ValueMember = "customertypeid"
            frmCustomer.cbType.DisplayMember = "customertype"
            frmCustomer.cbType.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    'Clear All Customer TextBox

    Public Sub clearCustomerTextBox()
        'Clear all TextBox Control
        For Each ctrls As Control In frmCustomer.panelRegularCustomer.Controls
            If TypeOf ctrls Is TextBox Then
                ctrls.Text = ""
            End If
        Next
        For Each ctrls As Control In frmCustomer.panelRegularCustomer.Controls
            If TypeOf ctrls Is ComboBox Then
                ctrls.Text = ""
            End If
        Next
        frmCustomer.checkPictures.Checked = False
    End Sub

    Public Sub clearSupplierTextBox()
        'Clear all TextBox Control
        For Each ctrls As Control In frmSupplier.panelSupplier.Controls
            If TypeOf ctrls Is TextBox Then
                ctrls.Text = ""
            End If
        Next
        For Each ctrls As Control In frmSupplier.panelSupplier.Controls
            If TypeOf ctrls Is ComboBox Then
                ctrls.Text = ""
            End If
        Next
        frmSupplier.checkLogo.Checked = False
    End Sub

    '----------------------------------------------------------------------------------------

    'AutoComplete TextBox Search
    Public Sub customerFrmAuto()
        Dim autocomplete As New AutoCompleteStringCollection()
        Dim cmdauto As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds As New DataSet
        'Firstname
        With cmdauto
            .CommandType = CommandType.Text
            .CommandText = "Select fname from customertbl"
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
        frmCustomer.txtfname.AutoCompleteMode = AutoCompleteMode.Suggest
        frmCustomer.txtfname.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmCustomer.txtfname.AutoCompleteCustomSource = autocomplete

        Dim autocomplete1 As New AutoCompleteStringCollection()
        Dim cmdauto1 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds1 As New DataSet
        'Midddlename
        With cmdauto1
            .CommandType = CommandType.Text
            .CommandText = "Select mname from customertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap1 As New SqlDataAdapter(cmdauto1)
        sqladap1.Fill(ds1)
        For b As Integer = 0 To ds1.Tables(0).Rows.Count - 1
            autocomplete1.Add(ds1.Tables(0).Rows(b)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmCustomer.txtmname.AutoCompleteMode = AutoCompleteMode.Suggest
        frmCustomer.txtmname.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmCustomer.txtmname.AutoCompleteCustomSource = autocomplete1

        Dim autocomplete2 As New AutoCompleteStringCollection()
        Dim cmdauto2 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds2 As New DataSet
        'Lastname
        With cmdauto2
            .CommandType = CommandType.Text
            .CommandText = "Select lname from customertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap2 As New SqlDataAdapter(cmdauto2)
        sqladap2.Fill(ds2)
        For i As Integer = 0 To ds2.Tables(0).Rows.Count - 1
            autocomplete2.Add(ds2.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmCustomer.txtlname.AutoCompleteMode = AutoCompleteMode.Suggest
        frmCustomer.txtlname.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmCustomer.txtlname.AutoCompleteCustomSource = autocomplete2

        Dim autocomplete3 As New AutoCompleteStringCollection()
        Dim cmdauto3 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds3 As New DataSet
        'Contact
        With cmdauto3
            .CommandType = CommandType.Text
            .CommandText = "Select contact from customertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap3 As New SqlDataAdapter(cmdauto3)
        sqladap3.Fill(ds3)
        For i As Integer = 0 To ds3.Tables(0).Rows.Count - 1
            autocomplete3.Add(ds3.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmCustomer.txtContact.AutoCompleteMode = AutoCompleteMode.Suggest
        frmCustomer.txtContact.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmCustomer.txtContact.AutoCompleteCustomSource = autocomplete3

        Dim autocomplete4 As New AutoCompleteStringCollection()
        Dim cmdauto4 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds4 As New DataSet
        'House No
        With cmdauto4
            .CommandType = CommandType.Text
            .CommandText = "Select houseNo from customertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap4 As New SqlDataAdapter(cmdauto4)
        sqladap4.Fill(ds4)
        For i As Integer = 0 To ds4.Tables(0).Rows.Count - 1
            autocomplete4.Add(ds4.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmCustomer.txtHouseNo.AutoCompleteMode = AutoCompleteMode.Suggest
        frmCustomer.txtHouseNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmCustomer.txtHouseNo.AutoCompleteCustomSource = autocomplete4

        Dim autocomplete5 As New AutoCompleteStringCollection()
        Dim cmdauto5 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds5 As New DataSet
        'Barangay
        With cmdauto5
            .CommandType = CommandType.Text
            .CommandText = "Select Barangay from customertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap5 As New SqlDataAdapter(cmdauto5)
        sqladap5.Fill(ds5)
        For i As Integer = 0 To ds5.Tables(0).Rows.Count - 1
            autocomplete5.Add(ds5.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmCustomer.txtBarangay.AutoCompleteMode = AutoCompleteMode.Suggest
        frmCustomer.txtBarangay.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmCustomer.txtBarangay.AutoCompleteCustomSource = autocomplete5

        Dim autocomplete6 As New AutoCompleteStringCollection()
        Dim cmdauto6 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds6 As New DataSet
        'Municipality
        With cmdauto6
            .CommandType = CommandType.Text
            .CommandText = "Select municipality from customertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap6 As New SqlDataAdapter(cmdauto6)
        sqladap6.Fill(ds6)
        For i As Integer = 0 To ds6.Tables(0).Rows.Count - 1
            autocomplete6.Add(ds6.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmCustomer.txtMunicipality.AutoCompleteMode = AutoCompleteMode.Suggest
        frmCustomer.txtMunicipality.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmCustomer.txtMunicipality.AutoCompleteCustomSource = autocomplete6


    End Sub
    ''AutoComplete TextBoxSearch
    Public Sub autoSupplierFrm()
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
        frmSupplier.txtCompanyName.AutoCompleteMode = AutoCompleteMode.Suggest
        frmSupplier.txtCompanyName.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmSupplier.txtCompanyName.AutoCompleteCustomSource = autocomplete

        Dim autocomplete1 As New AutoCompleteStringCollection()
        Dim cmdauto1 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds1 As New DataSet

        With cmdauto1
            .CommandType = CommandType.Text
            .CommandText = "Select contact from suppliertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap1 As New SqlDataAdapter(cmdauto1)
        sqladap1.Fill(ds1)
        For i As Integer = 0 To ds1.Tables(0).Rows.Count - 1
            autocomplete1.Add(ds1.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmSupplier.txtContact.AutoCompleteMode = AutoCompleteMode.Suggest
        frmSupplier.txtContact.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmSupplier.txtContact.AutoCompleteCustomSource = autocomplete1


        Dim autocomplete2 As New AutoCompleteStringCollection()
        Dim cmdauto2 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds2 As New DataSet

        With cmdauto2
            .CommandType = CommandType.Text
            .CommandText = "Select buildingno from suppliertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap2 As New SqlDataAdapter(cmdauto2)
        sqladap2.Fill(ds2)
        For i As Integer = 0 To ds2.Tables(0).Rows.Count - 1
            autocomplete2.Add(ds2.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmSupplier.txtBuildingNo.AutoCompleteMode = AutoCompleteMode.Suggest
        frmSupplier.txtBuildingNo.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmSupplier.txtBuildingNo.AutoCompleteCustomSource = autocomplete2


        Dim autocomplete3 As New AutoCompleteStringCollection()
        Dim cmdauto3 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds3 As New DataSet

        With cmdauto3
            .CommandType = CommandType.Text
            .CommandText = "Select poblacion from suppliertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap3 As New SqlDataAdapter(cmdauto3)
        sqladap3.Fill(ds3)
        For i As Integer = 0 To ds3.Tables(0).Rows.Count - 1
            autocomplete3.Add(ds3.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmSupplier.txtPoblacion.AutoCompleteMode = AutoCompleteMode.Suggest
        frmSupplier.txtPoblacion.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmSupplier.txtPoblacion.AutoCompleteCustomSource = autocomplete3

        Dim autocomplete4 As New AutoCompleteStringCollection()
        Dim cmdauto4 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds4 As New DataSet

        With cmdauto4
            .CommandType = CommandType.Text
            .CommandText = "Select city from suppliertbl"
            .Connection = con
            'r = .ExecuteReader
        End With
        Dim sqladap4 As New SqlDataAdapter(cmdauto4)
        sqladap4.Fill(ds4)
        For i As Integer = 0 To ds4.Tables(0).Rows.Count - 1
            autocomplete4.Add(ds4.Tables(0).Rows(i)(0).ToString())
        Next
        'While r.Read()
        '    autocomplete.Add(r("fullname"))
        'End While
        'r.Close()
        frmSupplier.txtCity.AutoCompleteMode = AutoCompleteMode.Suggest
        frmSupplier.txtCity.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmSupplier.txtCity.AutoCompleteCustomSource = autocomplete4


    End Sub





    Public Sub retrieveSupplierName()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveSupplier"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)


            frmSpecialJournal.comboSupplier.ValueMember = "supplierID"
            frmSpecialJournal.comboSupplier.DisplayMember = "companyname"
            frmSpecialJournal.comboSupplier.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Public Sub retrieveCustomerName()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveCustomer"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)


            frmSpecialJournal.comboCustomer.ValueMember = "customerId"
            frmSpecialJournal.comboCustomer.DisplayMember = "fullname"
            frmSpecialJournal.comboCustomer.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub


End Module

Imports System.Data.SqlClient
Module accountCondition
    'Retrieve Chart Status into Combobox
    Public Sub retrieveChartStatus()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveChartStatus"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)


            frmChartofAccount.cbChartStatus.ValueMember = "statusid"
            frmChartofAccount.cbChartStatus.DisplayMember = "chartstatus"
            frmChartofAccount.cbChartStatus.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    'Retrieve Chart Type into Combobox
    Public Sub retrieveChartType()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrieveChartType"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)


            frmChartofAccount.cbChartType.ValueMember = "typeid"
            frmChartofAccount.cbChartType.DisplayMember = "charttype"
            frmChartofAccount.cbChartType.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Public Sub clearchartofaccount()
        frmChartofAccount.txtChartName.Clear()
        frmChartofAccount.cbChartStatus.Text = ""
        frmChartofAccount.cbChartType.Text = ""
    End Sub

    Public Sub autoChartAndStatusFrm()
        Dim autocomplete As New AutoCompleteStringCollection()
        Dim cmdauto As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds As New DataSet

        With cmdauto
            .CommandType = CommandType.Text
            .CommandText = "Select charttype from charttypetbl"
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
        frmJournalType.txtChartType.AutoCompleteMode = AutoCompleteMode.Suggest
        frmJournalType.txtChartType.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmJournalType.txtChartType.AutoCompleteCustomSource = autocomplete

        Dim autocomplete1 As New AutoCompleteStringCollection()
        Dim cmdauto1 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds1 As New DataSet

        With cmdauto1
            .CommandType = CommandType.Text
            .CommandText = "Select chartstatus from chartstatustbl"
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
        frmJournalType.txtChartStatus.AutoCompleteMode = AutoCompleteMode.Suggest
        frmJournalType.txtChartStatus.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmJournalType.txtChartStatus.AutoCompleteCustomSource = autocomplete1


        Dim autocomplete2 As New AutoCompleteStringCollection()
        Dim cmdauto2 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds2 As New DataSet

        With cmdauto2
            .CommandType = CommandType.Text
            .CommandText = "Select customertype from customertypetbl"
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
        frmJournalType.txtCustomerType.AutoCompleteMode = AutoCompleteMode.Suggest
        frmJournalType.txtCustomerType.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmJournalType.txtCustomerType.AutoCompleteCustomSource = autocomplete2


        Dim autocomplete3 As New AutoCompleteStringCollection()
        Dim cmdauto3 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds3 As New DataSet

        With cmdauto3
            .CommandType = CommandType.Text
            .CommandText = "Select journalType from journaltypetbl"
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
        frmJournalType.txtJournalType.AutoCompleteMode = AutoCompleteMode.Suggest
        frmJournalType.txtJournalType.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmJournalType.txtJournalType.AutoCompleteCustomSource = autocomplete3


    End Sub


    Public Sub AccountAutoComplete()
        Dim autocomplete2 As New AutoCompleteStringCollection()
        Dim cmdauto2 As New SqlCommand
        ' Dim r As SqlDataReader
        Dim ds2 As New DataSet

        With cmdauto2
            .CommandType = CommandType.Text
            .CommandText = "Select chartname from charttbl"
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
        frmChartofAccount.txtChartName.AutoCompleteMode = AutoCompleteMode.Suggest
        frmChartofAccount.txtChartName.AutoCompleteSource = AutoCompleteSource.CustomSource
        frmChartofAccount.txtChartName.AutoCompleteCustomSource = autocomplete2


    End Sub
End Module

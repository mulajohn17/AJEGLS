Imports System.Data.SqlClient
Public Class frmOwners

    Private Sub frmOwners_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoadIncome._loadincome' table. You can move, or remove it, as needed.
        Me.LoadincomeTableAdapter.Fillincome(Me.LoadIncome._loadincome)
        'TODO: This line of code loads data into the 'Owners._owners' table. You can move, or remove it, as needed.
        Me.OwnersTableAdapter.FillbyOwnersWithdrawal(Me.Owners._owners)

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
 
        'TODO: This line of code loads data into the 'Owners._owners' table. You can move, or remove it, as needed.
        '  Me.OwnersTableAdapter.Fill(Me.Owners._owners)
        DataGridViewX1.Columns(2).Visible = False
        DataGridViewX1.Columns(3).Visible = False
        DataGridViewX2.Columns(0).Visible = False
        '   DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        ' loadBeginningCapital()

        DataGridViewX1.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewX1.ColumnHeadersVisible = False
        loadBeginningCapital()
        pesoSign()
        filterOwnersDate()
        filterOwnersNetIncome()
        filterOwnersWithdrawal()
        calculateendingcapital()
        frmOwnersEquityTemporaryLabelHide()
        dtpbenningbalance.Value = DateSerial(Year(dtpbenningbalance.Value), Month(dtpbenningbalance.Value) + 1, 0)
        ' DateTimePicker3.Value = New DateTime(DateTimePicker3.Value.Year, DateTimePicker3.Value.Month, 30)
        ' DateTimePicker3.Value = DateSerial(Year(DateTimePicker3.Value), Month(DateTimePicker3.Value) + 1, 0)

        '  calculateendingcapital()
        GenerateID()
        countId.Visible = False
    End Sub
    Public Sub loadBeginningCapital()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            Dim sda1 As New SqlDataAdapter

            Dim dtpmonth = dtpbenningbalance.Value.Month
            Dim dtpyear = dtpbenningbalance.Value.Year
            '            If Val(countId.Text.ToString) <= 1 Then

            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "loadbeginningbalance"
                .Connection = con
                .Parameters.Clear()
                '.Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
                '.Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            End With

            Dim myreaders As SqlDataReader
            myreaders = cmd.ExecuteReader
            myreaders.Read()


            If myreaders.HasRows Then
                lbbeginningcapital.Text = myreaders.Item("credit")
                dtpbenningbalance.Visible = False
                If IsNumeric(lbbeginningcapital.Text) Then

                    Dim temp As Double = lbbeginningcapital.Text

                    lbbeginningcapital.Text = "Ᵽ" & Format(temp, "N")

                End If
                lbtempbcapital.Text = myreaders.Item("credit")
            Else
                dtpbenningbalance.Visible = True
            End If
            myreaders.Close()
            ' Else
            'With cmd
            '    .CommandType = CommandType.StoredProcedure
            '    .CommandText = "loadownerscapital"
            '    .Connection = con
            '    .Parameters.Clear()
            '    .Parameters.Add("@month", SqlDbType.Int).Value = dtpmonth
            '    .Parameters.Add("@year", SqlDbType.Int).Value = dtpyear
            'End With

            'Dim myreaders As SqlDataReader
            'myreaders = cmd.ExecuteReader
            'myreaders.Read()

            'If myreaders.HasRows Then
            '    lbbeginningcapital.Text = myreaders.Item("ecapital")
            '    dtpbenningbalance.Visible = False
            '    If IsNumeric(lbbeginningcapital.Text) Then

            '        Dim temp As Double = lbbeginningcapital.Text

            '        lbbeginningcapital.Text = "Ᵽ" & Format(temp, "N")

            '    End If
            '    lbtempbcapital.Text = myreaders.Item("ecapital")
            'Else
            '    dtpbenningbalance.Visible = True
            'End If
            'myreaders.Close()

            'End If



        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally

        End Try

    End Sub
    Private Sub DataGridViewX1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewX1.Click
        ownersPassData()
        calculateendingcapital()
    End Sub

    Private Sub DataGridViewX1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX1.KeyDown, DataGridViewX1.KeyUp
        ownersPassData()
        '   calculateendingcapital()
    End Sub


    Private Sub DataGridViewX2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewX2.Click
        owners1PassData()
        calculateendingcapital()
    End Sub

    Private Sub DataGridViewX2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridViewX2.KeyDown, DataGridViewX2.KeyUp
        owners1PassData()
        '   calculateendingcapital()
    End Sub
    Public Sub calculateendingcapital()
        Dim totalbeginning As Decimal = Val(lbtempbcapital.Text)
        Dim totalnetnicome As Decimal = Val(lbtempnetincome.Text)
        Dim grandTotalforBeginningandnetincome As Decimal = 0.0

        Dim grandTotal As Decimal = 0.0
        grandTotalforBeginningandnetincome = totalbeginning + totalnetnicome
        lbnetcapittotal.Text = grandTotalforBeginningandnetincome
        lbtemptotal.Text = grandTotalforBeginningandnetincome

        grandTotal = grandTotalforBeginningandnetincome - Val(lbtemwithdrawal.Text)
        lbendingcapital.Text = grandTotal
        lbtempendingcapital.Text = grandTotal
        'Temporary pass data
        If IsNumeric(lbnetincome.Text) Then

            Dim temp As Double = lbnetincome.Text

            lbnetincome.Text = "Ᵽ" & Format(temp, "N")

        End If

        If IsNumeric(lbnetcapittotal.Text) Then

            Dim temp As Double = lbnetcapittotal.Text

            lbnetcapittotal.Text = "Ᵽ" & Format(temp, "N")

        End If

        If IsNumeric(lbwithdrawal.Text) Then

            Dim temp As Double = lbwithdrawal.Text

            lbwithdrawal.Text = "Ᵽ" & Format(temp, "N")

        End If

        If IsNumeric(lbendingcapital.Text) Then

            Dim temp As Double = lbendingcapital.Text

            lbendingcapital.Text = "Ᵽ" & Format(temp, "N")

        End If

    End Sub

    Public Sub pesoSign()
        DataGridViewX1.Columns(1).DefaultCellStyle.Format = "C"
        DataGridViewX1.Columns(1).DefaultCellStyle.FormatProvider = Globalization.CultureInfo.GetCultureInfo("en-PH")


    End Sub

    Private Sub dtpbenningbalance_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpbenningbalance.ValueChanged
        dtpbenningbalance.Value = DateSerial(Year(dtpbenningbalance.Value), Month(dtpbenningbalance.Value) + 1, 0)
        loadBeginningCapital()
    End Sub

    Public Sub GenerateID()

        '  Dim s As String
        With cmd
            .CommandType = CommandType.StoredProcedure
            .CommandText = "countbalance"
            .Connection = con
            .Parameters.Clear()
        End With
        Dim result = cmd.ExecuteScalar

        'Dim calculateResult As Integer = 0
        ' s = ar & Val(result)
        'txtSalesId.Text = s
        countId.Text = result
    End Sub
End Class
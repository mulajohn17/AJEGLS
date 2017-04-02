Imports System.Data.SqlClient
Module administratorModule

    Public Sub retrieveDepartment()
        Dim dt As New DataTable
        Dim ds As New DataSet()
        Dim adapter As New SqlDataAdapter()
        Try
            With cmd
                .CommandType = CommandType.StoredProcedure
                .CommandText = "retrievedepartment"
                .Connection = con
                .Parameters.Clear()
            End With
            adapter.SelectCommand = cmd
            adapter.Fill(dt)

            frmEmployee.cbDepartment.ValueMember = "departmentid"
            frmEmployee.cbDepartment.DisplayMember = "departmentname"
            frmEmployee.cbDepartment.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub


End Module

Public Class frmJournalType

    Public Sub frmJournalType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        autoChartAndStatusFrm()
    End Sub

    Private Sub checkChartStatus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkChartStatus.CheckedChanged, checkChartType.CheckedChanged
        ChangeTextonChartgroupPanel()
    End Sub
End Class
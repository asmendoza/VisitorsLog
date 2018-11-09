Public Class frmAdminLanding

    Private Sub lstMenu_Click(sender As Object, e As EventArgs) Handles lstMenu.Click
        Select Case (lstMenu.Items(lstMenu.SelectedIndex).ToString.ToUpper)
            Case "USERS"
                frmUsers.Show(Me)
            Case "KEYS"
                frmKeys.Show(Me)
            Case "APPLICATION SETTINGS"
                frmAppSettings.Show(Me)
            Case "EVENTS"
                frmEVisitors.Show(Me)
            Case "PEOPLE MANAGEMENT"
                frmPeopleManagement.Show(Me)
            Case "COMPUTERS"
                frmComputers.Show(Me)
            Case "USER DASHBOARD"
                frmDashboard.Show(Me)
            Case "REPORTS"
                Reports.Show(Me)
        End Select
    End Sub
End Class
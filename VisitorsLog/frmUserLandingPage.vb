Public Class frmUserLandingPage
    Private Sub frmUserLandingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHeader.Text = String.Format("Welcome [{0}]! (Gate {1})", u, gate)
    End Sub

    Private Sub btnVisitors_Click(sender As Object, e As EventArgs) Handles btnVisitors.Click
        frmDashboard.Show(Me)
    End Sub

    Private Sub btnKeys_Click(sender As Object, e As EventArgs) Handles btnKeys.Click
        frmKeyBorrowing.Show(Me)
    End Sub

    Private Sub btnCars_Click(sender As Object, e As EventArgs) Handles btnCars.Click
        frmCarVisitors.Show(Me)
    End Sub

    Private Sub btnInOut_Click(sender As Object, e As EventArgs) Handles btnInOut.Click
        frmPeopleInOut.Show(Me)
    End Sub

    Private Sub logout()
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo) = vbYes Then
            u = ""
            fname = ""
            isAdmin = False
            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Call logout()
    End Sub

    Private Sub frmUserLandingPage_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        u = ""
        fname = ""
        isAdmin = False
        frmLogin.Show()
    End Sub
End Class
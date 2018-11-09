Public Class frmAppSettings
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmAppSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtServer.Text = My.Settings.dbaseServer
        txtDatabase.Text = My.Settings.dbaseSchema
        txtPort.Text = My.Settings.dbasePort
        txtUsername.Text = My.Settings.dbaseUser
        txtPassword.Text = My.Settings.dbasePwd
        txtMode.Text = My.Settings.computerMode
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        My.Settings.dbaseServer = txtServer.Text
        My.Settings.dbaseSchema = txtDatabase.Text
        My.Settings.dbasePort = Val(txtPort.Text)
        My.Settings.dbaseUser = txtUsername.Text
        My.Settings.dbasePwd = txtPassword.Text
        My.Settings.computerMode = txtMode.Text
        My.Settings.Save()

        MsgBox("Settings has been updated.", vbInformation + vbOKOnly)
    End Sub
End Class
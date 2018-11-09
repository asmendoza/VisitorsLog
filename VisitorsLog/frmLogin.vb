Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim userEdit, passEdit As Boolean
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If UCase(Trim(txtUsername.Text)) = "" And userEdit = False Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.DimGray
            txtUsername.Font = initialFont
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If UCase(Trim(txtPassword.Text)) = "" And passEdit = False Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.DimGray
            txtPassword.Font = initialFont
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        If UCase(Trim(txtUsername.Text)) = "USERNAME" _
            And (
                (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) _
                Or (Asc(e.KeyChar) >= 45 And Asc(e.KeyChar) <= 46) _
                Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) _
                Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) _
                Or (Asc(e.KeyChar) = 95)
            ) Then
            userEdit = True
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
            txtUsername.Font = inputFont
        End If
        userEdit = False
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        Dim command As New MySqlCommand
        Dim rs As MySqlDataReader

        If connect() Then
            command.Connection = conn
            command.CommandText = String.Format("SELECT username, fullname, isAdmin 
            FROM v_users WHERE username='{0}' and password='{1}';" _
                , txtUsername.Text, txtPassword.Text)
            rs = command.ExecuteReader

            Try
                If rs.Read Then
                    u = rs.GetString("username")
                    fname = rs.GetString("fullname")
                    isAdmin = rs.GetBoolean("isAdmin")
                    MsgBox(String.Format("Welcome {0}({1})", fname, u), vbInformation + vbOKOnly)
                    If isAdmin Then
                        'landing page for admins
                        frmAdminLanding.Show()
                    Else
                        frmUserLandingPage.Show()
                    End If

                    Me.Hide()
                    txtUsername.Text = ""
                    txtPassword.Text = ""
                Else
                    MsgBox("Username or Password not correct.", vbExclamation + vbOKOnly)
                End If
            Catch ex As Exception
                MsgBox("Something is wrong with the connection.", vbExclamation + vbOKOnly)
            Finally
                rs.Close()
                rs = Nothing
                command = Nothing
                disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim command As New MySqlCommand
        Dim rs As MySqlDataReader

        If connect() Then
            command.Connection = conn
            command.CommandText = String.Format("SELECT gate FROM gates WHERE computer_name='{0}'", My.Computer.Name)

            Try
                rs = command.ExecuteReader
                If Not rs.HasRows Then
                    MsgBox("This computer is not allowed to use this system." &
                           vbCrLf & vbCrLf & "This application will exit now.", vbCritical + vbOKOnly)
                    End
                Else
                    While rs.Read
                        gate = rs.GetInt32("gate")
                    End While
                End If
            Catch ex As Exception
                MsgBox("There is something wrong with the connection.", vbExclamation + vbOKOnly)
            Finally
                rs.Close()
                rs = Nothing
                command = Nothing
                Call disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If UCase(Trim(txtPassword.Text)) = "PASSWORD" _
            And (
                (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) _
                Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) _
                Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122)
            ) Then
            passEdit = True
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.Font = inputFont
            txtPassword.PasswordChar = "*"
        End If
        passEdit = False
    End Sub
End Class


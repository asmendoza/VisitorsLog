Imports MySql.Data.MySqlClient

Public Class frmUsers
    Dim userEdit, nameEdit, passEdit, rePassEdit, recordEdit As Boolean
    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If UCase(Trim(txtUsername.Text)) = "" And userEdit = False Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Silver
            txtUsername.Font = initialFont
        End If
    End Sub
    Private Sub txtFullName_TextChanged(sender As Object, e As EventArgs) Handles txtFullName.TextChanged
        If UCase(Trim(txtFullName.Text)) = "" And nameEdit = False Then
            txtFullName.Text = "Full Name"
            txtFullName.ForeColor = Color.Silver
            txtFullName.Font = initialFont
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If UCase(Trim(txtPassword.Text)) = "" And passEdit = False Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Silver
            txtPassword.Font = initialFont
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub txtRePassword_TextChanged(sender As Object, e As EventArgs) Handles txtRePassword.TextChanged
        If UCase(Trim(txtRePassword.Text)) = "" And rePassEdit = False Then
            txtRePassword.Text = "Retype Password"
            txtRePassword.ForeColor = Color.Silver
            txtRePassword.Font = initialFont
            txtRePassword.PasswordChar = ""
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

    Private Sub txtFullName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullName.KeyPress
        If UCase(Trim(txtFullName.Text)) = "FULL NAME" Then
            nameEdit = True
            txtFullName.Text = ""
            txtFullName.ForeColor = Color.Black
            txtFullName.Font = inputFont
        End If
        nameEdit = False
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnMUSave.Click
        Call SaveData()
    End Sub

    Private Sub txtRePassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRePassword.KeyPress
        If UCase(Trim(txtRePassword.Text)) = "RETYPE PASSWORD" _
            And (
                (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) _
                Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) _
                Or (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122)
            ) Then
            rePassEdit = True
            txtRePassword.Text = ""
            txtRePassword.ForeColor = Color.Black
            txtRePassword.Font = inputFont
            txtRePassword.PasswordChar = "*"
        End If
        rePassEdit = False
    End Sub

    Private Sub btnMUClose_Click(sender As Object, e As EventArgs) Handles btnMUClose.Click
        Me.Close()
    End Sub
    Private Sub btnMUAdd_Click(sender As Object, e As EventArgs) Handles btnMUAdd.Click
        Call clearContents()
        btnMUAdd.Enabled = False
        btnMUDelete.Enabled = False

        recordEdit = False
    End Sub
    Private Sub btnMUDelete_Click(sender As Object, e As EventArgs) Handles btnMUDelete.Click
        Dim sqlComm As MySqlCommand
        If Trim(txtUsername.Text) = u Then
            MsgBox("You cannot delete your own username.", vbCritical + vbOKOnly)
            Exit Sub
        End If

        If MsgBox(String.Format("Are you sure you want to delete the selected user '{0}'?", txtUsername.Text), vbQuestion + vbYesNo) = vbYes Then
            If connect() Then
                sqlComm = New MySqlCommand
                sqlComm.Connection = conn
                sqlComm.CommandText = String.Format("DELETE FROM v_users WHERE username='{0}'", txtUsername.Text)
                Try
                    sqlComm.ExecuteNonQuery()
                    MsgBox(String.Format("User '{0}' has been deleted.", txtUsername.Text), vbInformation + vbOKOnly)
                    Call clearContents()
                    btnMUAdd.Enabled = False
                    btnMUDelete.Enabled = False
                Catch ex As Exception
                    MsgBox("There is something wrong with the connection.", vbExclamation + vbOKOnly)
                Finally
                    sqlComm = Nothing
                    disconnect()
                End Try
                Call LoadUserData()
            Else
                MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
            End If
        End If
    End Sub
    Private Sub clearContents()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtRePassword.Text = ""
        txtFullName.Text = ""
        chkIsAdmin.Checked = False

        txtUsername.Enabled = True
    End Sub

    Private Sub LoadUserData()
        Dim theRow As String
        Dim SQLComm As New MySqlCommand
        Dim rs As MySqlDataReader

        If connect() Then
            SQLComm.Connection = conn
            SQLComm.CommandText = "SELECT username, fullname, isAdmin FROM v_users;"

            Try
                rs = SQLComm.ExecuteReader()

                dgUsers.Columns.Clear()
                dgUsers.Rows.Clear()

                'index of datagrid view starts with 0
                If rs.HasRows Then
                    For i = 0 To rs.FieldCount - 1
                        'rs.getname(i).tostring will get the columnheader name of the record field
                        dgUsers.Columns.Add(rs.GetName(i).ToString, rs.GetName(i).ToString)
                    Next
                    'resize the column item width
                    dgUsers.Columns.Item(1).Width = 200
                End If
                While rs.Read()
                    'append all columns in a single string, separated by "|"
                    theRow = rs.Item(0)
                    For i = 1 To rs.FieldCount - 1
                        theRow = theRow & "|" & rs.Item(i)
                    Next
                    'use Split function to generate an array of String
                    dgUsers.Rows.Add(Split(theRow, "|"))
                End While
            Catch ex As Exception
                MsgBox("Something is wrong with the connection", vbExclamation + vbOKOnly)
            Finally
                rs.Close()
                rs = Nothing
                SQLComm = Nothing
                disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database.", vbCritical + vbOKOnly)
        End If

    End Sub

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadUserData()
    End Sub

    Private Sub DGUserClick()
        txtUsername.Text = dgUsers.Item(0, dgUsers.CurrentCell.RowIndex).Value
        txtFullName.Text = dgUsers.Item(1, dgUsers.CurrentCell.RowIndex).Value
        chkIsAdmin.Checked = dgUsers.Item(2, dgUsers.CurrentCell.RowIndex).Value
        btnMUDelete.Enabled = True

        txtUsername.Enabled = False
        txtUsername.Font = inputFont
        txtUsername.ForeColor = Color.Black
        txtFullName.Font = inputFont
        txtFullName.ForeColor = Color.Black

        recordEdit = True
    End Sub
    'hanldes user clicks on each row header in the datagrid view
    Private Sub dgUsers_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgUsers.RowHeaderMouseClick
        Call DGUserClick()
    End Sub

    'handles user clicks on each cell in the data grid view
    Private Sub dgUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsers.CellClick
        Call DGUserClick()
    End Sub

    Private Sub SaveData()
        Dim sqlComm As MySqlCommand
        Dim rs As MySqlDataReader
        Dim sqlText As String = ""

        If recordEdit Then
            If (Trim(txtPassword.Text) <> "Password" Or Trim(txtRePassword.Text) <> "Retype Password") And
                    Trim(txtPassword.Text) <> Trim(txtRePassword.Text) Then
                MsgBox("Password doesn't match.", vbExclamation + vbOKOnly)
                txtPassword.Focus()
                Exit Sub
            End If

            If Trim(txtPassword.Text) = "Password" And Trim(txtRePassword.Text) = "Retype Password" Then
                sqlText = String.Format("UPDATE v_users SET fullname='{0}', isadmin={1} WHERE username='{2}';",
                                        txtFullName.Text, chkIsAdmin.Checked, txtUsername.Text)
            Else
                sqlText = String.Format("UPDATE v_users SET fullname='{0}', password='{1}', isadmin={2} WHERE username='{3}';",
                                        txtFullName.Text, txtPassword.Text, chkIsAdmin.Checked, txtUsername.Text)
            End If

            If connect() Then
                sqlComm = New MySqlCommand
                sqlComm.Connection = conn
                sqlComm.CommandText = sqlText
                Try
                    sqlComm.ExecuteNonQuery()
                    recordEdit = False
                    MsgBox("Record updated!", vbInformation + vbOKOnly)
                Catch ex As Exception
                    System.Console.WriteLine(ex.Data.ToString)
                    MsgBox("Something is wrong with the connection", vbExclamation + vbOKOnly)
                Finally
                    sqlComm = Nothing
                    Call disconnect()
                End Try
            Else
                MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
            End If
        Else
            If Trim(txtUsername.Text) = "" Then
                MsgBox("Enter an appropriate username.", vbExclamation + vbOKOnly)
                txtUsername.Focus()
                Exit Sub
            End If

            If Trim(txtFullName.Text) = "" Then
                MsgBox("Enter the name of user.", vbExclamation + vbOKOnly)
                txtFullName.Focus()
                Exit Sub
            End If

            If Trim(txtPassword.Text) = "" Or Trim(UCase(txtPassword.Text)) = "PASSWORD" Then
                MsgBox("Enter password.", vbExclamation + vbOKOnly)
                txtPassword.Focus()
                Exit Sub
            End If

            If Trim(txtRePassword.Text) = "" Or Trim(UCase(txtRePassword.Text)) = "RETYPE PASSWORD" Then
                MsgBox("Re-enter the password.", vbExclamation + vbOKOnly)
                txtRePassword.Focus()
                Exit Sub
            End If

            If Trim(txtRePassword.Text) <> Trim(txtPassword.Text) Then
                MsgBox("Passwords don't match.", vbExclamation + vbOKOnly)
                txtPassword.Focus()
                Exit Sub
            End If

            If MsgBox("Are you sure all entries are correct?", vbQuestion + vbYesNo) = vbYes Then
                If connect() Then
                    sqlComm = New MySqlCommand
                    sqlComm.Connection = conn
                    sqlComm.CommandText = String.Format("SELECT username FROM v_users WHERE username='{0}';", txtUsername.Text)
                    Try
                        rs = sqlComm.ExecuteReader
                        If rs.HasRows Then
                            MsgBox("Username already taken. Create a new one.", vbExclamation + vbOKOnly)
                            txtUsername.Focus()
                            rs.Close()
                            rs = Nothing
                        Else
                            rs.Close()
                            rs = Nothing
                            sqlComm = Nothing

                            sqlComm = New MySqlCommand
                            sqlComm.Connection = conn
                            sqlComm.CommandText = String.Format("INSERT INTO v_users (username, fullname, password, isadmin) VALUES('{0}', '{1}', '{2}', {3});" _
                                            , txtUsername.Text, txtFullName.Text, txtPassword.Text, chkIsAdmin.Checked)
                            sqlComm.ExecuteNonQuery()
                            MsgBox("New user is now saved.", vbInformation + vbOKOnly)
                        End If
                    Catch ex As MySqlException
                        System.Console.WriteLine(ex.Message)
                        MsgBox("Something is wrong with the connection.", vbExclamation + vbOKOnly)
                    Finally
                        sqlComm = Nothing
                        Call disconnect()
                    End Try
                Else
                    MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
                End If
            End If
        End If
        Call clearContents()
        Call LoadUserData()
    End Sub
End Class
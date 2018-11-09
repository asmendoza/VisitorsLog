Imports MySql.Data.MySqlClient

Public Class frmPeopleInOut
    Private ReadOnly autoinout As Boolean = My.Settings.AUTO_IN_OUT
    Private person_type As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = UCase(Format(Now, "dd-MMM-yyyy"))
        lblTime.Text = Format(Now, "hh:mm:ss tt")
    End Sub

    Private Sub frmPeopleInOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        lblMode.Text = My.Settings.computerMode
        txtID.Focus()
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call LoadPersonInfo(txtID.Text)
            txtID.Text = ""
            txtID.Focus()
            Call LogInOut(lblID.Text, autoinout)
        End If
    End Sub

    Private Sub LogInOut(key As String, Optional auto As Boolean = False)
        If auto Then
            If IsIn(key) Then
                Call PersonOut(key, auto)
                lblMode.Text = "OUT"
            Else
                Call PersonIn(key, auto)
                lblMode.Text = "IN"
            End If
        Else
            If mode = "IN" Then
                Call PersonIn(key)
            ElseIf mode = "OUT" Then
                Call PersonOut(key)
            End If
        End If
    End Sub

    Private Function PersonIn(key As String, Optional auto As Boolean = False) As Boolean
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim success As Boolean = False

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            If auto Then
                sql.CommandText = String.Format("INSERT INTO in_out (id_no, gate, usr, time_in) VALUES('{0}', {1}, '{2}', now())", key, gate, u)
            Else
                sql.CommandText = String.Format("INSERT INTO in_out (mode, id_no, mode_time, gate, usr) VALUES('IN', '{0}', now(), {1}, '{2}')", key, gate, u)
            End If

            Try
                sql.ExecuteNonQuery()
                success = True
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If

        PersonIn = success
    End Function

    Private Function PersonOut(key As String, Optional auto As Boolean = False) As Boolean
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim success As Boolean = False

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            If auto Then
                sql.CommandText = String.Format("UPDATE in_out SET time_out = now(), gate={0}, usr='{1}' WHERE id_no='{2}' AND time_in IS NOT NULL AND time_out IS NULL", gate, u, key)
            Else
                sql.CommandText = String.Format("INSERT INTO in_out (mode, id_no, mode_time, gate, usr) VALUES('OUT', '{0}', now(), {1}, '{2}')", key, gate, u)
            End If

            Try
                sql.ExecuteNonQuery()
                success = True
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If

        PersonOut = success
    End Function

    Private Sub LoadPersonInfo(key As String)
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT person_ID, person_name, person_dept, person_type FROM person WHERE person_id = '{0}' OR person_rfid='{1}'", key, key)

            Try
                r = sql.ExecuteReader
                While r.Read
                    lblID.Text = r.GetString("person_id")
                    lblName.Text = r.GetString("person_name")
                    lblDept.Text = r.GetString("person_dept")
                    person_type = r.GetString("person_type")
                    If UCase(person_type) = "STUDENT" Then
                        btnViolation.Visible = True
                    Else
                        btnViolation.Visible = False
                    End If
                End While
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                If Not r Is Nothing Then r.Close()
                r = Nothing
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Function IsIn(key As String) As Boolean
        Dim reallyIn As Boolean = False
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT id_no FROM in_out WHERE id_no = '{0}'", key)

            Try
                r = sql.ExecuteReader
                If r.HasRows Then
                    reallyIn = True
                End If
            Catch ex As Exception
                MsgBox("Something is wrong with the connection.", vbExclamation + vbOKOnly)
            Finally
                If Not r Is Nothing Then r.Close()
                r = Nothing
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If

        IsIn = reallyIn
    End Function

    Private Sub frmPeopleInOut_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtID.Focus()
    End Sub

    Private Sub btnViolation_Click(sender As Object, e As EventArgs) Handles btnViolation.Click
        frmStudentViolation.Show(Me)
        With frmStudentViolation
            .txtStudID.Text = lblID.Text
            .lblName.Text = lblName.Text
            .lblDept.Text = lblDept.text
        End With
    End Sub
End Class
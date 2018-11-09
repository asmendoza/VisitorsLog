Imports MySql.Data.MySqlClient

Public Class frmKeyBorrowing
    Private Sub txtKeyID_TextChanged(sender As Object, e As EventArgs) Handles txtKeyID.TextChanged
        Call TextBoxTextChange(txtKeyID, "Key ID")
    End Sub

    Private Sub txtKeyID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeyID.KeyPress
        Call TextBoxKeyPress(txtKeyID, "Key ID", False, e)
        If Asc(e.KeyChar) = 13 Then
            If Not ReturnKey(txtKeyID.Text) Then
                Call LoadKeyInfo(txtKeyID.Text)
                pnlBorrower.Visible = True
            Else
                MsgBox("Key has been returned.", vbInformation + vbOKOnly)
                Call LoadBorrowed()
            End If
        End If
    End Sub

    Private Sub txtBorrowerID_TextChanged(sender As Object, e As EventArgs) Handles txtBorrowerID.TextChanged
        Call TextBoxTextChange(txtBorrowerID, "Borrower ID")
    End Sub

    Private Sub txtBorrowerID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBorrowerID.KeyPress
        Call TextBoxKeyPress(txtBorrowerID, "Borrower ID", False, e)
        If Asc(e.KeyChar) = 13 Then
            Call LoadBorrowerInfo(txtBorrowerID.Text)
        End If
    End Sub

    Private Function ReturnKey(key As String) As Boolean
        Dim returned As Boolean = False
        Dim c As MySqlConnection
        Dim sql, exe As MySqlCommand
        Dim r As MySqlDataReader
        Dim remarks As String

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT id, remarks FROM key_borrowing WHERE key_id = (SELECT id FROM keys where id = {0} OR key_rfid='{1}') AND datetime_returned IS null", Val(key), key)

            Try
                r = sql.ExecuteReader

                If r.HasRows Then
                    exe = New MySqlCommand
                    exe.Connection = c
                    While r.Read()
                        remarks = r.GetString("remarks")
                        remarks = Format(Now(), "[yyyy-MM-dd HH:mm:ss] ") & InputBox("Put your remarks here.", "Add Remarks", "none") & vbCrLf & remarks
                        exe.CommandText = String.Format("UPDATE key_borrowing SET datetime_returned = now(), remarks='{0}' WHERE id={1}", remarks, r.GetInt32("id"))
                        exe.ExecuteNonQuery()
                        returned = True
                    End While
                End If
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                exe = Nothing
                If Not r Is Nothing Then r.Close()
                r = Nothing
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
        ReturnKey = returned
    End Function

    Private Sub LoadKeyInfo(key As String)
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT id, key_desc FROM keys WHERE id = {0} OR key_rfid='{1}'", Val(key), key)

            Try
                r = sql.ExecuteReader
                While r.Read
                    txtKeyID.Text = r.GetInt32("id")
                    lblKeyDesc.Text = r.GetString("key_desc")
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

    Private Sub LoadBorrowerInfo(key As String)
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT person_ID, person_name, person_dept FROM person WHERE person_id = '{0}' OR person_rfid='{1}'", key, key)

            Try
                r = sql.ExecuteReader
                While r.Read
                    txtBorrowerID.Text = r.GetString("person_id")
                    lblBorrowerName.Text = r.GetString("person_name")
                    lblBorrowerDept.Text = r.GetString("person_dept")
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

    Private Sub LoadBorrowed()
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim sqlRow As String

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = "SELECT id, key_desc, borrower_name, datetime_borrowed FROM borrowed_keys"

            Try
                r = sql.ExecuteReader

                dgBorrowedKeys.Rows.Clear()
                dgBorrowedKeys.Columns.Clear()

                For i = 0 To r.FieldCount - 1
                    dgBorrowedKeys.Columns.Add(r.GetName(i).ToString, r.GetName(i).ToString)
                Next
                dgBorrowedKeys.Columns.Item(0).Width = 50
                dgBorrowedKeys.Columns.Item(1).Width = 200
                dgBorrowedKeys.Columns.Item(2).Width = 200
                dgBorrowedKeys.Columns.Item(3).Width = 150

                If r.HasRows Then
                    While r.Read
                        sqlRow = r.GetInt32("id")
                        sqlRow = sqlRow & "|" & r.GetString("key_desc")
                        sqlRow = sqlRow & "|" & r.GetString("borrower_name")
                        sqlRow = sqlRow & "|" & Format(r.GetDateTime("datetime_borrowed"), "yyyy-MM-dd HH:mm:ss")

                        dgBorrowedKeys.Rows.Add(Split(sqlRow, "|"))
                    End While
                End If
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

    Private Sub btnSaveBorrow_Click(sender As Object, e As EventArgs) Handles btnSaveBorrow.Click
        Call SaveBorrowed()
        pnlBorrower.Visible = False
        Call LoadBorrowed()
    End Sub

    Private Sub SaveBorrowed()
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim remarks As String

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            remarks = Format(Now(), "[yyyy-MM-dd HH:mm:ss] ") & InputBox("Put your remarks here.", "Add Remarks", "none")
            sql.CommandText = String.Format("INSERT INTO key_borrowing (key_id, key_desc, borrower_id, borrower_name, datetime_borrowed, processed_by, processed_gate, remarks) VALUES ({0}, '{1}', '{2}', '{3}', now(), '{4}', '{5}', '{6}')", txtKeyID.Text, lblKeyDesc.Text, txtBorrowerID.Text, lblBorrowerName.Text, u, gate, remarks)

            Try
                sql.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to database server.", vbCritical + vbOKOnly)
        End If
    End Sub
End Class
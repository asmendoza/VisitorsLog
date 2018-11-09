Imports MySql.Data.MySqlClient

Public Class frmKeys
    Private Sub frmKeys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadKeys()
    End Sub

    Private Sub LoadKeys()
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim sqlRow As String

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = "SELECT id, key_desc, key_rfid FROM key_main"

            Try
                r = sql.ExecuteReader

                dgBorrowedKeys.Rows.Clear()
                dgBorrowedKeys.Columns.Clear()

                For i = 0 To r.FieldCount - 1
                    dgBorrowedKeys.Columns.Add(r.GetName(i).ToString, r.GetName(i).ToString)
                Next
                Dim bc As New DataGridViewButtonColumn()
                bc.HeaderText = ""
                bc.Text = "Delete"
                dgBorrowedKeys.Columns.Add(bc)

                dgBorrowedKeys.Columns.Item(0).Width = 50
                dgBorrowedKeys.Columns.Item(1).Width = 200
                dgBorrowedKeys.Columns.Item(2).Width = 100
                dgBorrowedKeys.Columns.Item(3).Width = 75

                If r.HasRows Then
                    While r.Read
                        sqlRow = r.GetInt32("id")
                        sqlRow = sqlRow & "|" & r.GetString("key_desc")
                        sqlRow = sqlRow & "|" & r.GetString("key_rfid")
                        sqlRow = sqlRow & "|" & "Delete"

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

    Private Sub DGBorrowedKeysClick()
        lblKeyID.Text = dgBorrowedKeys.Item(0, dgBorrowedKeys.CurrentCell.RowIndex).Value
        txtKeyDesc.Text = dgBorrowedKeys.Item(1, dgBorrowedKeys.CurrentCell.RowIndex).Value
        txtKeyRFID.Text = dgBorrowedKeys.Item(2, dgBorrowedKeys.CurrentCell.RowIndex).Value
    End Sub

    Private Sub ClearText()
        lblKeyID.Text = ""
        txtKeyDesc.Text = ""
        txtKeyRFID.Text = ""
    End Sub

    Private Sub SaveKeys()
        Dim c As MySqlConnection = connect2()
        Dim sql As New MySqlCommand

        If txtKeyDesc.Text.Trim = "" Or txtKeyDesc.Text.ToUpper.Trim = "KEY DESCRIPTION" Then
            MsgBox("Enter valid description.", vbExclamation + vbOKOnly)
            txtKeyDesc.Focus()
            Exit Sub
        End If

        If txtKeyRFID.Text.Trim = "" Or txtKeyRFID.Text.ToUpper.Trim = "KEY RFID" Then
            MsgBox("Enter valid RFID serial number.", vbExclamation + vbOKOnly)
            txtKeyRFID.Focus()
            Exit Sub
        End If

        If Not c Is Nothing Then
            sql.Connection = c

            If lblKeyID.Text.Trim = "" Then
                sql.CommandText = String.Format("INSERT INTO key_main (key_desc, key_rfid) VALUES ('{0}', '{1}')", txtKeyDesc.Text, txtKeyRFID.Text)
            Else
                sql.CommandText = String.Format("UPDATE key_main SET key_desc='{0}', key_rfid='{1}' WHERE id={2}", txtKeyDesc.Text, txtKeyRFID.Text, Val(lblKeyID.Text))
            End If

            Try
                sql.ExecuteNonQuery()
                MsgBox("Successfully saved/updated!", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("Something is wrong with the connection. " & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub DeleteKeys(key As Integer)
        Dim c As MySqlConnection = connect2()
        Dim sql As New MySqlCommand

        If Not c Is Nothing Then
            sql.Connection = c

            sql.CommandText = String.Format("DELETE FROM key_main WHERE id={0}", key)

            Try
                sql.ExecuteNonQuery()
                MsgBox("Successfully deleted!", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("Something is wrong with the connection. " & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub dgBorrowedKeys_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBorrowedKeys.CellClick
        If dgBorrowedKeys.CurrentCell.ColumnIndex = 3 Then
            If MsgBox("Are you sure you want to delete this record?", vbQuestion + vbYesNo) = vbYes Then
                Call DeleteKeys(dgBorrowedKeys.Item(0, dgBorrowedKeys.SelectedRows(0).Index).Value)
                Call LoadKeys()
            End If
        Else
            Call DGBorrowedKeysClick()
        End If
    End Sub

    Private Sub dgBorrowedKeys_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgBorrowedKeys.RowHeaderMouseClick
        Call DGBorrowedKeysClick()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If MsgBox("Are you sure all entries are correct?", vbQuestion + vbYesNo) = vbYes Then
            Call SaveKeys()
            Call ClearText()
            Call LoadKeys()
        End If
    End Sub

    Private Sub txtKeyDesc_TextChanged(sender As Object, e As EventArgs) Handles txtKeyDesc.TextChanged
        TextBoxTextChange(txtKeyDesc, "Key Description")
    End Sub

    Private Sub txtKeyRFID_TextChanged(sender As Object, e As EventArgs) Handles txtKeyRFID.TextChanged
        TextBoxTextChange(txtKeyRFID, "Key RFID")
    End Sub

    Private Sub txtKeyDesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeyDesc.KeyPress
        TextBoxKeyPress(txtKeyDesc, "Key Description", False, e)
    End Sub

    Private Sub txtKeyRFID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKeyRFID.KeyPress
        TextBoxKeyPress(txtKeyRFID, "Key RFID", False, e)
    End Sub
End Class
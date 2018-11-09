Imports MySql.Data.MySqlClient

Public Class frmStudentViolation
    Private Sub frmStudentViolation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadViolationList()
        Call LoadStudentViolationList()
    End Sub

    Private Sub LoadViolationList()
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT violation_name FROM violations", txtStudID.Text)

            Try
                r = sql.ExecuteReader

                cboViolation.Items.Clear()

                If r.HasRows Then
                    While r.Read
                        cboViolation.Items.Add(r.GetString("violation_name"))
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

    Private Sub LoadStudentViolationList()
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim sqlRow As String

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT txn_id as ID, violation_datetime as DateTime, violation as Desc FROM student_violations WHERE id_no='{0}' AND (is_settled = false OR is_settled is null)", txtStudID.Text)

            Try
                r = sql.ExecuteReader

                dgViolation.Rows.Clear()
                dgViolation.Columns.Clear()

                For i = 0 To r.FieldCount - 1
                    dgViolation.Columns.Add(r.GetName(i).ToString, r.GetName(i).ToString)
                Next
                Dim btnSettle As New DataGridViewButtonColumn
                dgViolation.Columns.Add(btnSettle)

                dgViolation.Columns.Item(0).Width = 50
                dgViolation.Columns.Item(1).Width = 100
                dgViolation.Columns.Item(2).Width = 200
                dgViolation.Columns.Item(3).Width = 150

                If r.HasRows Then
                    While r.Read
                        sqlRow = r.GetInt32("ID")
                        sqlRow = sqlRow & "|" & r.GetString("DateTime")
                        sqlRow = sqlRow & "|" & r.GetString("Desc")
                        sqlRow = sqlRow & "|" & "SETTLE"

                        dgViolation.Rows.Add(Split(sqlRow, "|"))
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

    Private Sub dgViolation_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgViolation.CellClick
        If dgViolation.CurrentCell.ColumnIndex = 3 Then
            If SettleViolation(dgViolation.Item(3, dgViolation.CurrentCell.RowIndex).Value) Then
                MsgBox(dgViolation.Item(2, dgViolation.CurrentCell.RowIndex).Value & " violation for the current student has been settled.", vbInformation + vbOKOnly)
                Call LoadStudentViolationList()
            End If
        End If
    End Sub

    Private Function SettleViolation(txnID As Integer) As Boolean
        Dim updated As Boolean = False
        Dim c As MySqlConnection
        Dim sql As MySqlCommand

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("UPDATE student_violations SET is_settled = true, settled_datetime = now(), settled_usr = '{0}', settled_gate = {1} WHERE txn_id={2}", u, gate, txnID)

            Try
                sql.ExecuteNonQuery()
                updated = True
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database.", vbCritical + vbOKOnly)
        End If

        SettleViolation = updated
    End Function
End Class
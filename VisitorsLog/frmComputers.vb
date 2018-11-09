Imports MySql.Data.MySqlClient

Public Class frmComputers
    Dim cellChanged As Boolean
    Dim cellClicked As Boolean = False

    Private Sub LoadContents()
        Dim command As New MySqlCommand
        Dim rs As MySqlDataReader
        Dim theRow As String
        Dim colBtn As DataGridViewButtonColumn

        If connect() Then
            command.Connection = conn
            command.CommandText = "SELECT gate, computer_name FROM gates"

            Try
                rs = command.ExecuteReader
                dgComputers.Columns.Clear()
                dgComputers.Rows.Clear()

                'index of datagrid view starts with 0
                If rs.HasRows Then
                    colBtn = New DataGridViewButtonColumn
                    colBtn.HeaderText = ""
                    colBtn.Text = "DEL"
                    dgComputers.Columns.Add(colBtn)

                    For i = 0 To rs.FieldCount - 1
                        'rs.getname(i).tostring will get the columnheader name of the record field
                        dgComputers.Columns.Add(rs.GetName(i).ToString, rs.GetName(i).ToString)
                    Next
                    'resize the column item width
                    dgComputers.Columns.Item(0).Width = 75
                    dgComputers.Columns.Item(1).Width = 50
                    dgComputers.Columns.Item(2).Width = 200
                End If

                While rs.Read()
                    'append all columns in a single string, separated by "|"
                    theRow = "DELETE"
                    For i = 0 To rs.FieldCount - 1
                        theRow = theRow & "|" & rs.Item(i)
                    Next

                    'use Split function to generate an array of String
                    dgComputers.Rows.Add(Split(theRow, "|"))
                End While
            Catch ex As Exception
                MsgBox("There is something wrong with the connection." & vbCrLf & ex.Message, vbInformation + vbOKOnly)
            End Try

        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub frmComputers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadContents()
    End Sub

    Private Sub dgComputers_RowLeave(sender As Object, e As DataGridViewCellEventArgs)
        MsgBox("Leaving row " & e.RowIndex, vbInformation + vbOKOnly)
    End Sub

    Private Sub btnVClose_Click(sender As Object, e As EventArgs) Handles btnVClose.Click
        Me.Close()
    End Sub

    Private Sub DeleteComputer(computer As String, gate As Integer)
        Dim command As New MySqlCommand

        If connect() Then
            command.Connection = conn
            command.CommandText = String.Format("DELETE FROM gates WHERE computer_name='{0}' AND gate={1}", computer, gate)

            Try
                command.ExecuteNonQuery()
                MsgBox(computer & " has been deleted from your list.", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                command = Nothing
                disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub dgComputers_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 27 Then
            If MsgBox("Are you sure you want to cancel adding/editing? All changes will be discarded. Continue?", vbQuestion + vbYesNo) = vbYes Then
                Call LoadContents()
            End If
        End If
    End Sub

    Private Sub dgComputers_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        If Trim(dgComputers.Item(e.ColumnIndex, e.RowIndex).Value) <> "" Then
            cellChanged = True
            Console.WriteLine(cellChanged.ToString)
        End If
    End Sub

    Private Sub dgComputers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgComputers.CellClick
        If dgComputers.CurrentCell.ColumnIndex = 0 Then
            If dgComputers.CurrentRow.Cells("computer_name").Value = My.Computer.Name Then
                MsgBox("You cannot delete your computer from the list.", vbExclamation + vbOKOnly)
                Exit Sub
            Else
                If MsgBox("Are you sure you want to delete '" & dgComputers.SelectedRows(0).Cells("computer_name").Value & "' from the list?", vbQuestion + vbOKOnly) = vbYes Then
                    'call delete function
                    Call DeleteComputer(dgComputers.SelectedRows(0).Cells("computer_name").Value, dgComputers.SelectedRows(0).Cells("gate").Value)
                    Call LoadContents()
                End If
            End If
        Else
            Call DGComputersClick()
        End If
    End Sub

    Private Sub DGComputersClick()
        txtGateNo.Text = dgComputers.CurrentRow.Cells("gate").Value
        txtComputer.Text = dgComputers.CurrentRow.Cells("computer_name").Value
        cellClicked = True
    End Sub

    Private Sub ClearText()
        txtGateNo.Text = ""
        txtComputer.Text = ""
    End Sub

    Private Sub txtGateNo_TextChanged(sender As Object, e As EventArgs) Handles txtGateNo.TextChanged
        TextBoxTextChange(txtGateNo, "Gate No")
    End Sub

    Private Sub txtGateNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGateNo.KeyPress
        TextBoxKeyPress(txtGateNo, "Gate No", False, e)
    End Sub

    Private Sub txtComputer_TextChanged(sender As Object, e As EventArgs) Handles txtComputer.TextChanged
        TextBoxTextChange(txtComputer, "Computer Name")
    End Sub

    Private Sub txtComputer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComputer.KeyPress
        TextBoxKeyPress(txtComputer, "Computer Name", False, e)
    End Sub

    Private Sub dgComputers_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgComputers.RowHeaderMouseClick
        Call DGComputersClick()
    End Sub

    Private Sub SaveGates()
        Dim c As MySqlConnection = connect2()
        Dim sql As New MySqlCommand

        If txtGateNo.Text.Trim = "" Or txtGateNo.Text.ToUpper.Trim = "GATE NO" Then
            MsgBox("Enter valid description.", vbExclamation + vbOKOnly)
            txtGateNo.Focus()
            Exit Sub
        End If

        If txtComputer.Text.Trim = "" Or txtComputer.Text.ToUpper.Trim = "COMPUTER NAME" Then
            MsgBox("Enter valid RFID serial number.", vbExclamation + vbOKOnly)
            txtComputer.Focus()
            Exit Sub
        End If

        If Not c Is Nothing Then
            sql.Connection = c

            If cellClicked Then
                sql.CommandText = String.Format("UPDATE gates SET gate={0}, computer_name='{1}' WHERE gate={3} AND computer_name='{4}'",
                                                Val(txtGateNo.Text),
                                                txtComputer.Text,
                                                Val(dgComputers.CurrentRow.Cells("gate").Value),
                                                dgComputers.CurrentRow.Cells("computer_name").Value)
            Else
                sql.CommandText = String.Format("INSERT INTO gates VALUES({0},'{1}')", Val(txtGateNo.Text), txtComputer.Text)
            End If

            Try
                sql.ExecuteNonQuery()
                MsgBox("Successfully saved/updated!", vbInformation + vbOKOnly)
                cellClicked = False
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveGates()
        Call ClearText()
        Call LoadContents()
    End Sub
End Class
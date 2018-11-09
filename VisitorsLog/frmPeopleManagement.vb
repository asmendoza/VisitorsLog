Imports MySql.Data.MySqlClient

Public Class frmPeopleManagement

    Private Sub frmPeopleManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadPeople()
        Call ClearTexts()
        Call EnableButtons(True)
    End Sub

    Private Sub LoadPeople()
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim sqlRow As String

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT person_id as ID, person_name as FullName, person_dept as Department, person_rfid as RFID, person_type as Type, person_remarks as Remarks, person_task as Task, person_designation AS Designation FROM person WHERE person_id LIKE '%{0}%' OR person_name LIKE '%{1}%' OR person_dept LIKE '%{2}%' OR person_rfid LIKE '%{3}%'",
                                            IIf(Trim(txtIDNumber.Text) = "ID NUMBER", "", txtIDNumber.Text),
                                            IIf(Trim(txtName.Text) = "NAME", "", txtName.Text),
                                            IIf(Trim(cboDept.Text) = "DEPARTMENT", "", cboDept.Text),
                                            IIf(Trim(txtRFID.Text) = "RFID SN", "", txtRFID.Text))

            Try
                r = sql.ExecuteReader

                dgPeople.Rows.Clear()
                dgPeople.Columns.Clear()

                For i = 0 To r.FieldCount - 1
                    dgPeople.Columns.Add(r.GetName(i).ToString, r.GetName(i).ToString)
                Next
                dgPeople.Columns.Item(0).Width = 100
                dgPeople.Columns.Item(1).Width = 200
                dgPeople.Columns.Item(2).Width = 200
                dgPeople.Columns.Item(3).Width = 10
                dgPeople.Columns.Item(4).Width = 100
                dgPeople.Columns.Item(5).Width = 100
                dgPeople.Columns.Item(6).Width = 100
                dgPeople.Columns.Item(7).Width = 100

                If r.HasRows Then
                    While r.Read
                        sqlRow = r.GetString("ID")
                        sqlRow = sqlRow & "|" & r.GetString("FullName")
                        sqlRow = sqlRow & "|" & r.GetString("Department")

                        If r.IsDBNull(3) Then
                            sqlRow = sqlRow & "|"
                        Else
                            sqlRow = sqlRow & "|" & r.GetString("RFID")
                        End If
                        'sqlRow = sqlRow & "|" & IIf(IsNothing(r.GetString("RFID")), "", r.GetString("RFID"))
                        sqlRow = sqlRow & "|" & r.GetString("Type")
                        sqlRow = sqlRow & "|" & r.GetString("Remarks")
                        sqlRow = sqlRow & "|" & r.GetString("Task")
                        sqlRow = sqlRow & "|" & r.GetString("Designation")

                        dgPeople.Rows.Add(Split(sqlRow, "|"))
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

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnPMSearch.Click
        Call LoadPeople()
        Call EnableButtons(True)
    End Sub

    Private Sub AddPerson()
        If Trim(txtIDNumber.Text) = "ID" Or Trim(txtIDNumber.Text) = "" Then
            MsgBox("Enter ID Number.", vbExclamation + vbOKOnly)
            txtIDNumber.Focus()
            Exit Sub
        End If

        If Trim(txtName.Text) = "NAME" Or Trim(txtName.Text) = "" Then
            MsgBox("Enter Name", vbExclamation + vbOKOnly)
            txtName.Focus()
            Exit Sub
        End If

        If Trim(cboDept.Text) = "DEPARTMENT" Or Trim(cboDept.Text) = "" Then
            MsgBox("Select a Department.", vbExclamation + vbOKOnly)
            cboDept.Focus()
            Exit Sub
        End If

        'If Trim(txtRFID.Text) = "rfid sn" Or Trim(txtRFID.Text) = "" Then
        '    MsgBox("enter rfid serial number.", vbExclamation + vbOKOnly)
        '    txtRFID.Focus()
        'End If

        'If rbEmployee.Checked = False And rbStudent.Checked = False Then
        If rbEmployee.Checked = False And rbStudent.Checked = False And rbContractor.Checked = False Then
            'MsgBox("Select if Employee or Student.", vbExclamation + vbOKOnly)
            MsgBox("Select if Employee, Student, or Contractor.", vbExclamation + vbOKOnly)
            rbEmployee.Focus()
            Exit Sub
        End If

        If rbContractor.Checked = True Then
            If txtTask.Text.Trim.Equals("") Then
                MsgBox("Enter contractor's job/task.", vbExclamation + vbOKOnly)
                txtTask.Focus()
                Exit Sub
            End If
        End If

        Dim c As MySqlConnection
        Dim sql As MySqlCommand

        If MsgBox("Are you sure all entries are correct?", vbQuestion + vbYesNo) = vbYes Then
            c = connect2()

            If Not c Is Nothing Then
                sql = New MySqlCommand
                sql.Connection = c
                If rbEmployee.Checked Then
                    sql.CommandText = String.Format("INSERT INTO employees VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', now(), '{6}', 0, null)",
                                                    txtIDNumber.Text,
                                                    txtName.Text,
                                                    cboDept.Text,
                                                    IIf(Trim(txtRFID.Text) = "RFID SN" Or Trim(txtRFID.Text) = "", "", txtRFID.Text),
                                                    txtDesignation.Text,
                                                    u,
                                                    txtRemarks.Text)
                ElseIf rbStudent.Checked Then
                    sql.CommandText = String.Format("INSERT INTO students VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', now(), '{6}')",
                                                    txtIDNumber.Text,
                                                    txtName.Text,
                                                    cboDept.Text,
                                                    IIf(Trim(txtRFID.Text) = "RFID SN" Or Trim(txtRFID.Text) = "", "", txtRFID.Text),
                                                    txtDesignation.Text,
                                                    u,
                                                    txtRemarks.Text)
                ElseIf rbEmployee.Checked Then
                    sql.CommandText = String.Format("INSERT INTO employees VALUES('{0}', '{1}', '{2}', '{3}', 'contractual', '{4}', now(), '{5}', 1, '{6}')",
                                                    txtIDNumber.Text,
                                                    txtName.Text,
                                                    cboDept.Text,
                                                    IIf(Trim(txtRFID.Text) = "RFID SN" Or Trim(txtRFID.Text) = "", "", txtRFID.Text),
                                                    u,
                                                    txtRemarks.Text,
                                                    txtTask.Text)
                End If


                Try
                    sql.ExecuteNonQuery()
                    MsgBox("Saved Successfully.", vbInformation + vbOKOnly)
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
        End If
    End Sub

    Private Sub UpdatePerson()
        If Trim(txtIDNumber.Text) = "ID" Or Trim(txtIDNumber.Text) = "" Then
            MsgBox("Enter ID Number.", vbExclamation + vbOKOnly)
            txtIDNumber.Focus()
        End If

        If Trim(txtName.Text) = "NAME" Or Trim(txtName.Text) = "" Then
            MsgBox("Enter Name", vbExclamation + vbOKOnly)
            txtName.Focus()
        End If

        If Trim(cboDept.Text) = "DEPARTMENT" Or Trim(cboDept.Text) = "" Then
            MsgBox("Select a Department.", vbExclamation + vbOKOnly)
            cboDept.Focus()
        End If

        'If Trim(txtRFID.Text) = "rfid sn" Or Trim(txtRFID.Text) = "" Then
        '    MsgBox("enter rfid serial number.", vbExclamation + vbOKOnly)
        '    txtRFID.Focus()
        'End If

        'If rbEmployee.Checked = False And rbStudent.Checked = False Then
        If rbEmployee.Checked = False And rbStudent.Checked = False And rbContractor.Checked = False Then
            'MsgBox("Select if Employee or Student.", vbExclamation + vbOKOnly)
            MsgBox("Select if Employee, Student, or Contractual.", vbExclamation + vbOKOnly)
            rbEmployee.Focus()
        End If

        Dim c As MySqlConnection
        Dim sql As MySqlCommand

        If MsgBox("Are you sure all entries are correct?", vbQuestion + vbYesNo) = vbYes Then
            c = connect2()

            If Not c Is Nothing Then
                sql = New MySqlCommand
                sql.Connection = c
                If rbEmployee.Checked Then
                    sql.CommandText = String.Format("UPDATE employees SET employee_name='{0}', employee_dept='{1}', employee_rfid='{2}', updated_by='{3}', employee_remarks='{4}', employee_designation='{5}', updated_datetime=now() WHERE employee_id='{6}'",
                                                    txtName.Text,
                                                    cboDept.Text,
                                                    IIf(Trim(txtRFID.Text) = "RFID SN" Or Trim(txtRFID.Text) = "", "", txtRFID.Text),
                                                    u,
                                                    txtRemarks.Text,
                                                    txtDesignation.Text,
                                                    txtIDNumber.Text)
                ElseIf rbStudent.Checked Then
                    sql.CommandText = String.Format("UPDATE students SET student_name='{0}', student_dept='{1}', student_rfid='{2}', updated_by='{3}', student_remarks='{4}', student_designation='{5}', updated_datetime=now() WHERE student_id='{6}'",
                                                    txtName.Text,
                                                    cboDept.Text,
                                                    IIf(Trim(txtRFID.Text) = "RFID SN" Or Trim(txtRFID.Text) = "", "", txtRFID.Text),
                                                    u,
                                                    txtRemarks.Text,
                                                    txtDesignation.Text,
                                                    txtIDNumber.Text)
                ElseIf rbContractor.Checked Then
                    sql.CommandText = String.Format("UPDATE employees SET employee_name='{0}', employee_dept='{1}', employee_rfid='{2}', updated_by='{3}', employee_remarks='{4}', employee_task='{5}', updated_datetime=now() WHERE employee_id='{6}'",
                                                    txtName.Text,
                                                    cboDept.Text,
                                                    IIf(Trim(txtRFID.Text) = "RFID SN" Or Trim(txtRFID.Text) = "", "", txtRFID.Text),
                                                    u,
                                                    txtRemarks.Text,
                                                    txtTask.Text,
                                                    txtIDNumber.Text)
                End If


                Try
                    sql.ExecuteNonQuery()
                    MsgBox("Updated Successfully.", vbInformation + vbOKOnly)
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
        End If
    End Sub

    Private Sub DeletePerson()
        If Trim(txtIDNumber.Text) = "ID" Or Trim(txtIDNumber.Text) = "" Then
            MsgBox("Enter ID Number.", vbExclamation + vbOKOnly)
            txtIDNumber.Focus()
        End If

        'If Trim(txtName.Text) = "NAME" Or Trim(txtName.Text) = "" Then
        '    MsgBox("Enter Name", vbExclamation + vbOKOnly)
        '    txtName.Focus()
        'End If

        'If Trim(cboDept.Text) = "DEPARTMENT" Or Trim(cboDept.Text) = "" Then
        '    MsgBox("Select a Department.", vbExclamation + vbOKOnly)
        '    cboDept.Focus()
        'End If

        'If Trim(txtRFID.Text) = "rfid sn" Or Trim(txtRFID.Text) = "" Then
        '    MsgBox("enter rfid serial number.", vbExclamation + vbOKOnly)
        '    txtRFID.Focus()
        'End If

        'If rbEmployee.Checked = False And rbStudent.Checked = False Then
        If rbEmployee.Checked = False And rbStudent.Checked = False And rbContractor.Checked = False Then
            'MsgBox("Select if Employee or Student.", vbExclamation + vbOKOnly)
            MsgBox("Select if Employee, Student, or Contractor.", vbExclamation + vbOKOnly)
            rbEmployee.Focus()
        End If

        Dim c As MySqlConnection
        Dim sql As MySqlCommand

        If MsgBox("Are you sure all entries are correct?", vbQuestion + vbYesNo) = vbYes Then
            c = connect2()

            If Not c Is Nothing Then
                sql = New MySqlCommand
                sql.Connection = c
                If rbEmployee.Checked Or rbContractor.Checked Then
                    sql.CommandText = String.Format("DELETE FROM employees WHERE employee_ID='{0}'",
                                                    txtIDNumber.Text)
                ElseIf rbStudent.Checked Then
                    sql.CommandText = String.Format("DELETE FROM students WHERE student_ID='{0}'",
                                                    txtIDNumber.Text)
                End If


                Try
                    sql.ExecuteNonQuery()
                    MsgBox("Deleted Successfully.", vbInformation + vbOKOnly)
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
        End If
    End Sub

    Private Sub txtIDNumber_TextChanged(sender As Object, e As EventArgs) Handles txtIDNumber.TextChanged
        Call TextBoxTextChange(txtIDNumber, "ID")
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Call TextBoxTextChange(txtName, "NAME")
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        Call TextBoxKeyPress(txtName, "NAME", False, e)
    End Sub

    Private Sub cboDept_TextChanged(sender As Object, e As EventArgs) Handles cboDept.TextChanged
        Call ComboBoxTextChange(cboDept, "DEPARTMENT")
    End Sub

    Private Sub cboDept_Click(sender As Object, e As EventArgs) Handles cboDept.Click
        Call ComboBoxClick(cboDept, "DEPARTMENT", e)
    End Sub

    Private Sub txtRFID_TextChanged(sender As Object, e As EventArgs) Handles txtRFID.TextChanged
        Call TextBoxTextChange(txtRFID, "RFID SN", True)
    End Sub

    Private Sub txtRFID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRFID.KeyPress
        Call TextBoxKeyPress(txtRFID, "RFID SN", True, e)
    End Sub

    Private Sub dgPeople_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPeople.CellClick
        Call DGPeopleClick()
        Call EnableButtons(False)
    End Sub

    Private Sub dgPeople_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgPeople.RowHeaderMouseClick
        Call DGPeopleClick()
        Call EnableButtons(False)
    End Sub

    Private Sub DGPeopleClick()
        txtIDNumber.Text = dgPeople.Item(0, dgPeople.CurrentCell.RowIndex).Value
        txtName.Text = dgPeople.Item(1, dgPeople.CurrentCell.RowIndex).Value
        cboDept.Text = dgPeople.Item(2, dgPeople.CurrentCell.RowIndex).Value
        txtRFID.Text = dgPeople.Item(3, dgPeople.CurrentCell.RowIndex).Value
        txtRemarks.Text = dgPeople.Item(5, dgPeople.CurrentCell.RowIndex).Value
        txtRemarks.Text = dgPeople.Item(6, dgPeople.CurrentCell.RowIndex).Value
        txtDesignation.Text = dgPeople.Item(7, dgPeople.CurrentCell.RowIndex).Value

        If dgPeople.Item(4, dgPeople.CurrentCell.RowIndex).Value.ToString.ToUpper = "EMPLOYEE" Then
            rbEmployee.Checked = True
            rbStudent.Checked = False
            rbContractor.Checked = False
        ElseIf dgPeople.Item(4, dgPeople.CurrentCell.RowIndex).Value.ToString.ToUpper = "CONTRACTUAL" Then
            rbEmployee.Checked = False
            rbStudent.Checked = False
            rbContractor.Checked = True
        Else
            rbStudent.Checked = True
            rbEmployee.Checked = False
            rbContractor.Checked = False
        End If

        btnPMAdd.Enabled = False
        btnPMSearch.Enabled = False
    End Sub

    Private Sub btnPMAdd_Click(sender As Object, e As EventArgs) Handles btnPMAdd.Click
        Call AddPerson()
        Call EnableButtons()
    End Sub

    Private Sub EnableButtons(Optional en As Boolean = True)
        txtIDNumber.Enabled = en
        btnPMSearch.Enabled = en
        btnPMAdd.Enabled = en
        btnPMDelete.Enabled = Not en
        btnPMSave.Enabled = Not en
    End Sub

    Private Sub ClearTexts()
        txtIDNumber.Text = ""
        txtName.Text = ""
        cboDept.Text = ""
        txtRFID.Text = ""
        rbEmployee.Checked = False
        rbStudent.Checked = False
    End Sub

    Private Sub btnPMDelete_Click(sender As Object, e As EventArgs) Handles btnPMDelete.Click
        Call DeletePerson()
        Call EnableButtons()
        Call ClearTexts()
    End Sub

    Private Sub btnPMSave_Click(sender As Object, e As EventArgs) Handles btnPMSave.Click
        Call UpdatePerson()
        Call EnableButtons()
        Call ClearTexts()
    End Sub

    Private Sub btnPMClose_Click(sender As Object, e As EventArgs) Handles btnPMClose.Click
        Me.Close()
    End Sub

    Private Sub cboDept_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDept.KeyPress
        Call ComboBoxKeyPress(cboDept, "DEPARTMENT", e)
    End Sub

    Private Sub txtIDNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDNumber.KeyPress
        Call TextBoxKeyPress(txtIDNumber, "ID", False, e)
    End Sub

    Private Sub txtRemarks_TextChanged(sender As Object, e As EventArgs) Handles txtRemarks.TextChanged
        Call TextBoxTextChange(txtRemarks, "REMARKS")
    End Sub

    Private Sub txtRemarks_KeyPress(sender As Object, e As EventArgs) Handles txtRemarks.KeyPress
        Call TextBoxKeyPress(txtRemarks, "REMARKS", False, e)
    End Sub

    Private Sub txtTask_TextChanged(sender As Object, e As EventArgs) Handles txtTask.TextChanged
        Call TextBoxTextChange(txtTask, "TASK")
    End Sub

    Private Sub txtTask_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTask.KeyPress
        Call TextBoxKeyPress(txtTask, "TASK", False, e)
    End Sub

    Private Sub txtDesignation_TextChanged(sender As Object, e As EventArgs) Handles txtDesignation.TextChanged
        Call TextBoxTextChange(txtDesignation, "DESIGNATION")
    End Sub

    Private Sub txtDesignation_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesignation.KeyPress
        Call TextBoxKeyPress(txtDesignation, "DESIGNATION", False, e)
    End Sub

    Private Sub rbContractor_CheckedChanged(sender As Object, e As EventArgs) Handles rbContractor.CheckedChanged
        If rbContractor.Checked Then
            txtTask.Visible = True
        Else
            txtTask.Visible = False
        End If
    End Sub
End Class
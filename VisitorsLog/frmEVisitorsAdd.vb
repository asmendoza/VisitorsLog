Imports MySql.Data.MySqlClient

Public Class frmEVisitorsAdd
    Public eventID As Integer
    Public dateFrom As Date
    Public dateTo As Date

    Private Sub txtCompany_TextChanged(sender As Object, e As EventArgs) Handles txtCompany.TextChanged
        TextBoxTextChange(txtCompany, "Company")
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        TextBoxTextChange(txtLastName, "Last Name")
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        TextBoxTextChange(txtAddress, "Address")
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        TextBoxTextChange(txtFirstName, "First Name")
    End Sub

    Private Sub txtCompany_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompany.KeyPress
        TextBoxKeyPress(txtCompany, "Company", False, e)
    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        TextBoxKeyPress(txtAddress, "Address", False, e)
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        TextBoxKeyPress(txtLastName, "Last Name", False, e)
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        TextBoxKeyPress(txtFirstName, "First Name", False, e)
    End Sub

    Private Sub btnSaveAdd_Click(sender As Object, e As EventArgs) Handles btnSaveAdd.Click
        Call SaveData()
    End Sub

    Private Sub SaveData()
        Dim sqlComm As MySqlCommand

        If Trim(txtFirstName.Text) = "" Or UCase(Trim(txtFirstName.Text)) = "FIRST NAME" Then
            MsgBox("Enter first name of attendee.", vbExclamation + vbOKOnly)
            txtFirstName.Focus()
            Exit Sub
        End If

        If Trim(txtLastName.Text) = "" Or UCase(Trim(txtLastName.Text)) = "LAST NAME" Then
            MsgBox("Enter last name of attendee.", vbExclamation + vbOKOnly)
            txtLastName.Focus()
            Exit Sub
        End If

        If Trim(txtCompany.Text) = "" Or UCase(Trim(txtCompany.Text)) = "COMPANY" Then
            MsgBox("Enter company of origin of attendee.", vbExclamation + vbOKOnly)
            txtCompany.Focus()
            Exit Sub
        End If

        If Trim(txtAddress.Text) = "" Or UCase(Trim(txtAddress.Text)) = "ADDRESS" Then
            MsgBox("Enter the address of attendee.", vbExclamation + vbOKOnly)
            txtAddress.Focus()
            Exit Sub
        End If

        If chkAttendAll.Checked = False And
            (Trim(cboDateAttend.Text) = "" _
            Or UCase(Trim(cboDateAttend.Text)) = "DATE TO ATTEND") Then
            MsgBox("Select a date when the attendee will attend the event.", vbExclamation + vbOKOnly)

            Exit Sub
        End If

        Dim i As Integer

        If connect() Then
            Try
                If chkAttendAll.Checked Then
                    For i = 0 To cboDateAttend.Items.Count - 1
                        sqlComm = Nothing
                        sqlComm = New MySqlCommand
                        sqlComm.Connection = conn
                        sqlComm.CommandText = String.Format("INSERT INTO visitor (date_visit, " &
                            "firstName, lastName, address, company, person_to_visit, department, " &
                            "reason_to_visit, event_id, gate_processed, processed_by) VALUES ('{0}'," &
                            "'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', " &
                            "'{7}', {8}, '{9}', '{10}')", cboDateAttend.Items.Item(i).ToString,
                            txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCompany.Text, lblContactPerson.Text, lblHost.Text,
                            lblEvent.Text, eventID, My.Computer.Name, u)
                        sqlComm.ExecuteNonQuery()
                    Next
                Else
                    sqlComm = New MySqlCommand
                    sqlComm.Connection = conn
                    sqlComm.CommandText = String.Format("INSERT INTO visitor (date_visit, " &
                        "firstName, lastName, address, company, person_to_visit, department, " &
                        "reason_to_visit, event_id, gate_processed, processed_by) VALUES ('{0}'," &
                        "'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', " &
                        "'{7}', {8}, '{9}', '{10}')", cboDateAttend.Text,
                        txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCompany.Text, lblContactPerson.Text, lblHost.Text,
                        lblEvent.Text, eventID, My.Computer.Name, u)
                    sqlComm.ExecuteNonQuery()
                End If

                MsgBox("Attendee information saved.", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("There is something wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sqlComm = Nothing
                Call disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub ClearContents()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtCompany.Text = ""
        cboDateAttend.Text = ""
        chkAttendAll.Checked = True
    End Sub

    Private Sub cboDateAttend_Click(sender As Object, e As EventArgs) Handles cboDateAttend.Click
        ComboBoxClick(cboDateAttend, "Date to attend", e)
    End Sub

    Private Sub cboDateAttend_TextChanged(sender As Object, e As EventArgs) Handles cboDateAttend.TextChanged
        ComboBoxTextChange(cboDateAttend, "Date to attend")
    End Sub

    Private Sub chkAttendAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkAttendAll.CheckedChanged
        If chkAttendAll.Checked Then
            cboDateAttend.Enabled = False
        Else
            cboDateAttend.Enabled = True
        End If
    End Sub

    Private Sub frmEVisitorsAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim dateStart As Date
        dateStart = dateFrom

        cboDateAttend.Items.Clear()

        For i = 0 To DateDiff(DateInterval.Day, dateFrom, dateTo)
            cboDateAttend.Items.Add(Format(dateStart, "yyyy-MM-dd"))
            dateStart = DateAdd(DateInterval.Day, 1, dateStart)
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call ClearContents()
    End Sub

    Private Sub btnSaveClose_Click(sender As Object, e As EventArgs) Handles btnSaveClose.Click
        Call SaveData()
        Call frmEVisitors.LoadAttendees()
        Me.Close()
    End Sub
End Class
Imports Emgu.CV
Imports MySql.Data.MySqlClient

Public Class frmVisitors
    Dim cap As Capture
    Dim sqlComm As MySqlCommand
    Dim rs As MySqlDataReader

    Private Sub txtIDType_TextChanged(sender As Object, e As EventArgs) Handles txtIDType.TextChanged
        Call TextBoxTextChange(txtIDType, "ID Type")
    End Sub

    Private Sub txtIDNo_TextChanged(sender As Object, e As EventArgs) Handles txtIDNo.TextChanged
        Call TextBoxTextChange(txtIDNo, "ID No")
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        Call TextBoxTextChange(txtFirstName, "First Name")
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Call TextBoxTextChange(txtLastName, "Last Name")
    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged
        Call TextBoxTextChange(txtAddress, "Address")
    End Sub

    Private Sub txtCompany_TextChanged(sender As Object, e As EventArgs) Handles txtCompany.TextChanged
        Call TextBoxTextChange(txtCompany, "Company")
    End Sub

    Private Sub txtCompany_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompany.KeyPress
        Call TextBoxKeyPress(txtCompany, "Company", False, e)
    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress
        Call TextBoxKeyPress(txtAddress, "Address", False, e)
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        Call TextBoxKeyPress(txtLastName, "Last Name", False, e)
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        Call TextBoxKeyPress(txtFirstName, "First Name", False, e)
    End Sub

    Private Sub txtIDNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDNo.KeyPress
        Call TextBoxKeyPress(txtIDNo, "ID No", False, e)
    End Sub

    Private Sub txtIDType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDType.KeyPress
        Call TextBoxKeyPress(txtIDType, "ID Type", False, e)
    End Sub

    Private Sub btnVID_Click(sender As Object, e As EventArgs) Handles btnVID.Click
        If Trim(UCase(btnVID.Text)) = "TURN ON CAMERA" Then
            cap = New Capture()
            Timer1.Enabled = True
        End If
        If Trim(UCase(btnVID.Text)) = "TAKE A PHOTO" Then
            btnVID.Text = "Recapture"
            Timer1.Enabled = False
            cap.Dispose()
            cap = Nothing
        Else
            cap = New Capture()
            If Not picID.Image Is Nothing Then picID.Image.Dispose()
            picID.Image = Nothing
            Timer1.Enabled = True
            btnVID.Text = "Take a Photo"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            picID.Image = cap.QueryFrame.ToBitmap
        Catch ex As Exception
            System.Console.WriteLine(ex.Message)
            cap.Dispose()
            If Not picID.Image Is Nothing Then picID.Image.Dispose()
            picID.Image = Nothing
            btnVID.Text = "Turn on Camera"
        End Try
    End Sub

    Private Sub LoadComboBoxData()
        If connect() Then
            sqlComm = New MySqlCommand
            sqlComm.Connection = conn
            sqlComm.CommandText = String.Format("SELECT DISTINCT department FROM persons_to_visit")
            Try
                rs = sqlComm.ExecuteReader

                cboDept.Items.Clear()
                While rs.Read
                    cboDept.Items.Add(rs.GetString("department"))
                End While
                cboDept.Font = inputFont
                cboDept.ForeColor = Color.Black

                rs.Close()
                rs = Nothing

                sqlComm = Nothing
                sqlComm = New MySqlCommand
                sqlComm.Connection = conn
                sqlComm.CommandText = String.Format("SELECT reason FROM reasons_of_visit")

                rs = sqlComm.ExecuteReader

                cboReason.Items.Clear()
                While rs.Read
                    cboReason.Items.Add(rs.GetString("reason"))
                End While
                cboReason.Font = inputFont
                cboReason.ForeColor = Color.Black
            Catch ex As Exception
                MsgBox("There is something wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                rs.Close()
                rs = Nothing
                sqlComm = Nothing
                disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCr + vbOKOnly)
        End If
    End Sub

    Private Sub frmVisitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
        Call LoadComboBoxData()
    End Sub

    Private Sub tabVisitor_Click(sender As Object, e As EventArgs) Handles tabVisitor.Click
        If tabVisitor.SelectedTab.Text = "Sign In" Then
            If Not cap Is Nothing Then
                cap.Dispose()
                cap = Nothing
            End If
            btnVID.Text = "Turn On Camera"
        ElseIf tabVisitor.SelectedTab.Text = "Sign Out" Then
            txtRFID_OUT.Text = ""
            txtRFID_OUT.Focus()
        End If
    End Sub

    Private Sub btnVClose_Click(sender As Object, e As EventArgs) Handles btnVClose.Click
        Me.Close()
    End Sub

    Private Sub ClearVisitorData()
        picID.Image.Dispose()
        picID.Image = Nothing

        txtIDType.Text = ""
        txtIDNo.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtCompany.Text = ""

        cboDept.Text = ""
        cboPerson.Text = ""
        cboReason.Text = ""

        If Not cap Is Nothing Then
            cap.Dispose()
            cap = Nothing
        End If
        btnVID.Text = "Turn On Camera"
    End Sub

    Private Sub btnVClear_Click(sender As Object, e As EventArgs) Handles btnVClear.Click
        Call ClearVisitorData()
    End Sub

    Private Sub cboDept_TextChanged(sender As Object, e As EventArgs) Handles cboDept.TextChanged
        Call ComboBoxTextChange(cboDept, "Department")
    End Sub

    Private Sub cboPerson_TextChanged(sender As Object, e As EventArgs) Handles cboPerson.TextChanged
        Call ComboBoxTextChange(cboPerson, "Person to Visit")
    End Sub

    Private Sub cboReason_TextChanged(sender As Object, e As EventArgs) Handles cboReason.TextChanged
        Call ComboBoxTextChange(cboReason, "Reason of Visit")
    End Sub

    Private Sub cboDept_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboDept.SelectedValueChanged
        Call ComboBoxClick(cboDept, "Department", e)
    End Sub

    Private Sub cboPerson_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPerson.SelectedValueChanged
        Call ComboBoxClick(cboPerson, "Person to Visit", e)
    End Sub

    Private Sub cboReason_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboReason.SelectedValueChanged
        Call ComboBoxClick(cboReason, "Reason of Visit", e)
    End Sub

    Private Sub cboPerson_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboPerson.KeyPress
        Call ComboBoxKeyPress(cboPerson, "Person to Visit", e)
    End Sub

    Private Sub cboReason_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboReason.KeyPress
        Call ComboBoxKeyPress(cboReason, "Reason of Visit", e)
    End Sub

    Private Sub cboDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDept.SelectedIndexChanged
        If connect() Then
            sqlComm = New MySqlCommand
            sqlComm.Connection = conn
            sqlComm.CommandText = String.Format("SELECT person_name FROM persons_to_visit WHERE department='{0}';", cboDept.Text)

            Try
                rs = sqlComm.ExecuteReader

                cboPerson.Items.Clear()
                While rs.Read
                    cboPerson.Items.Add(rs.GetString("person_name"))
                End While
                cboPerson.Font = inputFont
                cboPerson.ForeColor = Color.Black

            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                rs.Close()
                rs = Nothing
                sqlComm = Nothing
                disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub SaveProcess()
        If picID.Image Is Nothing Then
            MsgBox("Capture a photo of a valid ID.", vbExclamation + vbOKOnly)
            btnVID.Focus()
            Exit Sub
        End If

        If Trim(txtIDType.Text) = "" Or Trim(txtIDType.Text) = "ID Type" Then
            MsgBox("Enter the type of ID surrendered.", vbExclamation + vbOKOnly)
            txtIDType.Focus()
            Exit Sub
        End If

        If Trim(txtIDNo.Text) = "" Or Trim(txtIDNo.Text) = "ID No" Then
            MsgBox("Enter the ID number indicated in the surrendered ID.", vbExclamation + vbOKOnly)
            txtIDNo.Focus()
            Exit Sub
        End If

        If Trim(txtFirstName.Text) = "" Or Trim(txtFirstName.Text) = "First Name" Then
            MsgBox("Enter the first name of visitor.", vbExclamation + vbOKOnly)
            txtFirstName.Focus()
            Exit Sub
        End If

        If Trim(txtLastName.Text) = "" Or Trim(txtLastName.Text) = "Last Name" Then
            MsgBox("Enter the last name of visitor.", vbExclamation + vbOKOnly)
            txtLastName.Focus()
            Exit Sub
        End If

        If Trim(txtAddress.Text) = "" Or Trim(txtAddress.Text) = "Address" Then
            MsgBox("Enter the visitor's address.", vbExclamation + vbOKOnly)
            txtAddress.Focus()
            Exit Sub
        End If

        If Trim(txtCompany.Text) = "" Or Trim(txtCompany.Text) = "Company" Then
            MsgBox("Enter the visitor's company name.", vbExclamation + vbOKOnly)
            txtCompany.Focus()
            Exit Sub
        End If

        If Trim(cboDept.Text) = "" Or Trim(cboDept.Text) = "Department" Then
            MsgBox("Select the office where the visitor wishes to visit.", vbExclamation + vbOKOnly)
            cboDept.Focus()
            Exit Sub
        End If

        If Trim(cboPerson.Text) = "" Or Trim(cboPerson.Text) = "Person to Visit" Then
            MsgBox("Select or enter the person the visitor wishes to visit.", vbExclamation + vbOKOnly)
            cboPerson.Focus()
            Exit Sub
        End If

        If Trim(cboReason.Text) = "" Or Trim(cboReason.Text) = "Reason of Visit" Then
            MsgBox("Select or enter the reason of visitor for the visit.", vbExclamation + vbOKOnly)
            cboReason.Focus()
            Exit Sub
        End If

        'TODO: "scan the RFID card" process
        pnlRFIDIn.Parent = pnlVisitors
        pnlRFIDIn.Dock = DockStyle.Fill

        pnlRFIDIn.Visible = True
        txtRFID.Focus()


    End Sub
    Private Function SaveData(Optional rfid As String = "1234567890") As Boolean
        Dim isSaved As Boolean = False

        If connect() Then
            sqlComm = New MySqlCommand
            sqlComm.Connection = conn
            'TODO: fill up the following:
            '1. RFID serial no
            '2. Gate information
            sqlComm.CommandText = String.Format("INSERT INTO visitor (date_visit, firstName, lastName, address, company, " &
                "person_to_visit, department, reason_to_visit, id_type, id_no, rfid_no, logINdatetime, photo, " &
                "gate_processed, processed_by) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}', " &
                "(SELECT rfid_no FROM rfid WHERE rfid_sn='{10}' OR rfid_no={11}), now(), @PHOTO, '{12}', '{13}')", Format(Now, "yyyy-MM-dd"),
                                                txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtCompany.Text,
                                                cboPerson.Text, cboDept.Text, cboReason.Text, txtIDType.Text, txtIDNo.Text,
                                                rfid, Val(rfid), gate, u)
            sqlComm.Parameters.AddWithValue("@PHOTO", ImageToByte(picID.Image))
            Try
                sqlComm.ExecuteNonQuery()
                MsgBox("Visitor information has been saved.", vbInformation + vbOKOnly)
                Call ClearVisitorData()
                isSaved = True
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sqlComm = Nothing
                disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If

        SaveData = isSaved
    End Function
    Private Sub btnVSave_Click(sender As Object, e As EventArgs) Handles btnVSave.Click
        Call SaveProcess()
    End Sub

    Private Sub txtRFID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRFID.KeyPress
        Dim isvalid As Boolean
        Dim rf As String
        Dim ret As Integer

        If Asc(e.KeyChar) = 32 Then
            pnlRFIDIn.Dock = DockStyle.None
            pnlRFIDIn.Visible = False
            pnlVisitors.Dock = DockStyle.Fill
            btnVSave.Focus()
            Exit Sub
        End If

        If Asc(e.KeyChar) = 13 Then
            Do
                isvalid = Not RFIDInUse(txtRFID.Text)
                If isvalid Then
                    rf = txtRFID.Text
                    txtRFID.Text = ""
                Else
                    txtRFID.Text = ""
                    ret = MsgBox("Invalid RFID / RFID already in use. Try again?", vbQuestion + vbYesNo)
                    txtRFID.Focus()
                End If
            Loop While isvalid = False And ret = vbyes

            If isvalid Then
                If SaveData(rf) = True Then
                    Call UseRFID(rf)
                    Me.Close()
                End If
            Else
                pnlRFIDIn.Dock = DockStyle.None
                pnlRFIDIn.Visible = False
                pnlVisitors.Dock = DockStyle.Fill
                btnVSave.Focus()
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        picIDOut.Image = Nothing
        lblCompany.Text = "Name"
        lblName.Text = "Name"
        pnlVisitorDet.Visible = False
        txtRFID_OUT.Focus()
    End Sub

    Private Sub txtRFID_OUT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRFID_OUT.KeyPress
        Dim isvalid As Boolean
        Dim rf As String
        Dim ret As Integer

        If Asc(e.KeyChar) = 13 Then
            isvalid = RFIDInUse(txtRFID_OUT.Text)

            If isvalid Then
                rf = txtRFID_OUT.Text
                txtRFID_OUT.Text = ""
                If connect() Then
                    sqlComm = New MySqlCommand
                    sqlComm.Connection = conn
                    sqlComm.CommandText =
                        String.Format("SELECT firstName, lastName, company, photo FROM visitor " &
                        "WHERE rfid_no = (SELECT rfid_no FROM rfid WHERE rfid_sn='{0}' OR rfid_no={1}) " &
                        "and logOUTdatetime is null", rf, Val(rf))

                    Try
                        rs = sqlComm.ExecuteReader
                        If rs.HasRows Then
                            While rs.Read
                                lblName.Text = rs.GetString("firstName") & " " & rs.GetString("lastName")
                                lblCompany.Text = rs.GetString("company")
                                picIDOut.Image = ByteToImage(rs.GetValue(3)) 'photo
                            End While
                            pnlVisitorDet.Visible = True
                        End If

                        rs.Close()
                        rs = Nothing
                        sqlComm = Nothing

                        sqlComm = New MySqlCommand
                        sqlComm.Connection = conn
                        sqlComm.CommandText =
                            String.Format("UPDATE visitor SET logOUTdatetime=now() " &
                            "WHERE logOUTdatetime is null " &
                            "and rfid_no = (SELECT rfid_no FROM rfid WHERE rfid_sn='{0}' OR rfid_no={1})",
                                          rf, Val(rf))
                        sqlComm.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox("Something Is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
                    Finally
                        sqlComm = Nothing
                        Call disconnect()
                    End Try

                    If isvalid Then
                        Call UseRFID(rf, False)
                    End If
                Else
                    MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
                End If
            Else
                ret = MsgBox("Invalid RFID / RFID (" & txtRFID_OUT.Text & ") Not in use. Try again.", vbExclamation + vbOKOnly)
                txtRFID_OUT.Text = ""
                txtRFID_OUT.Focus()
            End If


            If Not isvalid Then
                txtRFID_OUT.Focus()
            End If
        End If
    End Sub
End Class
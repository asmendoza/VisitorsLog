Imports MySql.Data.MySqlClient

Public Class frmCarVisitors
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'save the record in the database
        Call SaveCarVisit()
        Call Clear()
        Call LoadCarVisit()
    End Sub

    Private Sub txtPlateNo_TextChanged(sender As Object, e As EventArgs) Handles txtPlateNo.TextChanged
        TextBoxTextChange(txtPlateNo, "PLATE NO")
    End Sub

    Private Sub txtPlateNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlateNo.KeyPress
        TextBoxKeyPress(txtPlateNo, "PLATE NO", False, e)

        If Asc(e.KeyChar) = 13 Then
            If Not CarOut(txtPlateNo.Text) Then
                txtDriver.Focus()
            Else
                MsgBox("Car [{0}] has been logged out.", vbInformation + vbOKOnly)
                Call Clear()
                Call LoadCarVisit()
            End If
        End If
    End Sub

    Private Sub txtDriver_TextChanged(sender As Object, e As EventArgs) Handles txtDriver.TextChanged
        TextBoxTextChange(txtDriver, "ID NO / DRIVER NAME")
    End Sub

    Private Sub txtDriver_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDriver.KeyPress
        TextBoxKeyPress(txtDriver, "ID NO / DRIVER NAME", False, e)
        If Asc(e.KeyChar) = 13 Then
            'check the student no / employee number record in the database.
            lblName.Text = GetName(txtDriver.Text)
        End If
    End Sub

    Private Function GetName(theID As String) As String
        Dim theName As String = ""

        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT person_name FROM person WHERE person_ID='{0}'", theID)

            Try
                r = sql.ExecuteReader
                If r.HasRows Then
                    While r.Read
                        theName = r.GetString("person_name")
                    End While
                End If
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message,
                        vbExclamation + vbOKOnly)
            Finally
                If Not r Is Nothing Then r.Close()
                r = Nothing
                sql = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the databse server.", vbCritical + vbOKOnly)
        End If

        GetName = theName
    End Function

    Private Sub SaveCarVisit()
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim theName As String
        Dim theID As String

        If Trim(txtPlateNo.Text) = "" Or UCase(txtPlateNo.Text) = "PLATE NO" Then
            MsgBox("Enter the plate no of the car.", vbExclamation + vbOKOnly)
            txtPlateNo.Focus()
            Exit Sub
        End If

        If Trim(txtDriver.Text) = "" Or UCase(txtDriver.Text) = "ID NO / DRIVER NAME" Then
            MsgBox("ThenEnter the driver's name / ID number.", vbExclamation + vbOKOnly)
            txtDriver.Focus()
            Exit Sub
        End If

        If Trim(lblName.Text) = "" Then
            theName = txtDriver.Text
            theID = ""
        Else
            theID = txtDriver.Text
            theName = lblName.Text
        End If

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("INSERT INTO car_visitors (car_plateno, car_drivername, car_driverID, car_visitdatetime, car_processedby, car_processedin) VALUES ({0}, '{1}', '{2}',  now(), '{3}', '{4}')", txtPlateNo.Text, theName, theID, u, gate)

            Try
                sql.ExecuteNonQuery()
                MsgBox("Successfully saved.", vbInformation + vbOKOnly)
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

    Private Sub LoadCarVisit()
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim sqlRow As String

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = "SELECT carvisits_id as ID, car_plateno as PlateNo, car_drivername as Driver, car_visitdatetime as DateTime FROM car_visitors"

            Try
                r = sql.ExecuteReader

                dgCarVisit.Rows.Clear()
                dgCarVisit.Columns.Clear()

                For i = 0 To r.FieldCount - 1
                    dgCarVisit.Columns.Add(r.GetName(i).ToString, r.GetName(i).ToString)
                Next
                dgCarVisit.Columns.Item(0).Width = 50
                dgCarVisit.Columns.Item(1).Width = 100
                dgCarVisit.Columns.Item(2).Width = 200
                dgCarVisit.Columns.Item(3).Width = 150

                If r.HasRows Then
                    While r.Read
                        sqlRow = r.GetInt32("ID")
                        sqlRow = sqlRow & "|" & r.GetString("PlateNo")
                        sqlRow = sqlRow & "|" & r.GetString("Driver")
                        sqlRow = sqlRow & "|" & Format(r.GetDateTime("DateTime"), "yyyy-MM-dd HH:mm:ss")

                        dgCarVisit.Rows.Add(Split(sqlRow, "|"))
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

    Private Sub Clear()
        txtDriver.Text = ""
        txtPlateNo.Text = ""
        lblName.Text = ""
    End Sub

    Private Function CarOut(plateNo As String) As Boolean
        Dim out As Boolean = False
        Dim c As MySqlConnection
        Dim sql, exe As MySqlCommand
        Dim r As MySqlDataReader

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT carvisits_id FROM car_visitors WHERE car_plateno = '{0}' AND car_outdatetime IS null", plateNo)

            Try
                r = sql.ExecuteReader

                If r.HasRows Then
                    exe = New MySqlCommand
                    exe.Connection = c
                    While r.Read()
                        exe.CommandText = String.Format("UPDATE car_visitors SET car_outdatetime = now() WHERE id={0}", r.GetInt32("id"))
                        exe.ExecuteNonQuery()
                        out = True
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
        CarOut = out
    End Function

    Private Sub frmCarVisitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadCarVisit()
    End Sub
End Class
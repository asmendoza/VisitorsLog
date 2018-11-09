Imports MySql.Data.MySqlClient

Public Class frmEvents
    Dim sqlComm As MySqlCommand

    Private Sub dtDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtDateFrom.ValueChanged
        dtDateTo.Value = dtDateFrom.Value
    End Sub

    Private Sub dtTimeFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtTimeFrom.ValueChanged
        dtTimeTo.Value = dtTimeFrom.Value
    End Sub

    Private Sub dtDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtDateTo.ValueChanged
        If dtDateTo.Value < dtDateFrom.Value Then
            MsgBox("Date-To cannot have a date less than Date-From.", vbExclamation + vbOKOnly)
            dtDateTo.Value = dtDateFrom.Value
            dtDateTo.Focus()
        End If
    End Sub

    Private Sub dtTimeTo_ValueChanged(sender As Object, e As EventArgs) Handles dtTimeTo.ValueChanged
        If dtTimeTo.Value < dtTimeFrom.Value Then
            MsgBox("Time-To cannot have a time less than Time-From.", vbExclamation + vbOKOnly)
            dtTimeTo.Value = dtTimeFrom.Value
            dtTimeTo.Focus()
        End If
    End Sub

    Private Sub frmEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtDateFrom.Value = Now
        dtTimeFrom.Value = Now

        Call LoadHosts()
    End Sub

    Private Sub LoadHosts()
        If connect() Then
            Dim rs As MySqlDataReader
            sqlComm = New MySqlCommand
            sqlComm.Connection = conn
            sqlComm.CommandText = "SELECT * FROM hosts"

            Try
                rs = sqlComm.ExecuteReader
                cboHost.Items.Clear()

                While rs.Read
                    cboHost.Items.Add(rs.GetString("department"))
                End While
            Catch ex As Exception
                MsgBox("There is something wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                If Not rs Is Nothing Then rs.Close()
                rs = Nothing
                sqlComm = Nothing
                Call disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub SaveEventData()
        If Trim(txtEventName.Text) = "" Then
            MsgBox("Enter Event name.", vbExclamation + vbOKOnly)
            txtEventName.Focus()
            Exit Sub
        End If

        If Trim(cboHost.Text) = "" Then
            MsgBox("Select the host department/office.", vbExclamation + vbOKOnly)

            Exit Sub
        End If

        If Trim(txtHostContact.Text) = "" Then
            MsgBox("Enter contact person of host.", vbExclamation + vbOKOnly)
            txtHostContact.Focus()
            Exit Sub
        End If

        If connect() Then
            sqlComm = New MySqlCommand
            sqlComm.Connection = conn
            sqlComm.CommandText = String.Format("INSERT INTO events " &
                  "(event_name, event_date_from, event_date_to, event_time_from, event_time_to, " &
                  "event_host, contact_person, processed_by, processed_datetime) " &
                  "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')",
                  txtEventName.Text, Format(dtDateFrom.Value, "yyyy-MM-dd"), Format(dtDateTo.Value, "yyyy-MM-dd"),
                  Format(dtTimeFrom.Value, "HH:mm:ss"), Format(dtTimeTo.Value, "HH:mm:ss"), cboHost.Text,
                  txtHostContact.Text, u, Format(Now(), "yyyy-MM-dd HH:mm:ss"))

            Try
                sqlComm.ExecuteNonQuery()

                MsgBox("Event saved successfully!", vbInformation + vbOKOnly)
                Call ClearContents()
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sqlComm = Nothing
                disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub ClearContents()
        txtEventName.Text = ""
        dtDateFrom.Value = Now
        dtDateTo.Value = Now
        dtTimeFrom.Value = Now
        dtTimeTo.Value = Now
        cboHost.Text = ""
        txtHostContact.Text = ""
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call SaveEventData()
        Call frmEVisitors.LoadEvents()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to cancel transaction?", vbQuestion + vbYesNo) = vbYes Then
            Call ClearContents()
            Me.Close()
        End If
    End Sub
End Class
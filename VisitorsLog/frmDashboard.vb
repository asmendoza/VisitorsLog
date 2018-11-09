Imports MySql.Data.MySqlClient

Public Class frmDashboard
    Private Sub btnUsers_Click(sender As Object, e As EventArgs)
        frmUsers.Show(Me)
        'hide all other panels
    End Sub

    Private Sub logout()
        If MsgBox("Are you sure you want to logout?", vbQuestion + vbYesNo) = vbYes Then
            u = ""
            fname = ""
            isAdmin = False
            Me.Close()
            frmLogin.Show()
        End If
    End Sub

    Private Sub lblLogout_Click(sender As Object, e As EventArgs) Handles lblLogout.Click
        Call logout()
    End Sub

    Private Sub frmDashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmUserLandingPage.Show()
    End Sub

    Private Sub btnVisitor_Click(sender As Object, e As EventArgs) Handles btnVisitor.Click
        frmVisitors.Show(Me)
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Call RefreshCounter()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDay.Text = Format(Now, "dddd")
        lblDate.Text = Format(Now, "MMMM dd, yyyy")
        lblTime.Text = Format(Now, "long time")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Call RefreshCounter()
    End Sub
    Private Sub RefreshCounter()
        Dim c As MySqlConnection
        Dim sqlcomm As MySqlCommand
        Dim rs As MySqlDataReader
        c = connect2()

        If Not c Is Nothing Then
            sqlcomm = New MySqlCommand
            sqlcomm.Connection = c
            sqlcomm.CommandText = "SELECT * FROM visitors_count"

            Try
                rs = sqlcomm.ExecuteReader
                If rs.HasRows Then
                    While rs.Read
                        lblDVisitorIn.Text = rs.GetInt32("VisitorsInside")
                        lblDExpected.Text = rs.GetInt32("VisitorsExpected")
                        lblDTtlVisits.Text = rs.GetInt32("VisitorsVisited")
                    End While
                End If
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                If Not rs Is Nothing Then rs.Close()
                rs = Nothing
                sqlcomm = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
        Call LoadEvents()
    End Sub
    Private Sub LoadEvents()
        Dim theRow As String
        Dim SQLComm As New MySqlCommand
        Dim rs As MySqlDataReader
        Dim btn As DataGridViewButtonColumn
        Dim c As MySqlConnection

        c = connect2()

        If Not c Is Nothing Then
            SQLComm.Connection = c
            SQLComm.CommandText = "SELECT * FROM current_events;"

            Try
                rs = SQLComm.ExecuteReader()

                dgEvents.Columns.Clear()
                dgEvents.Rows.Clear()

                For i = 0 To rs.FieldCount - 1
                    'rs.getname(i).tostring will get the columnheader name of the record field
                    dgEvents.Columns.Add(rs.GetName(i).ToString, rs.GetName(i).ToString)
                    If i = 0 Then
                        dgEvents.Columns.Item(i).Width = 40
                    ElseIf i = 1 Then
                        dgEvents.Columns.Item(i).Width = 200
                    Else
                        dgEvents.Columns.Item(i).Width = 1
                    End If
                Next

                'index of datagrid view starts with 0
                If rs.HasRows Then
                    While rs.Read()
                        'append all columns in a single string, separated by "|"
                        theRow = rs.GetString("ID").ToString
                        theRow = theRow & "|" & rs.GetString("Event")
                        theRow = theRow & "|" & Format(rs.GetDateTime("Date_From"), "yyyy-MM-dd")
                        theRow = theRow & "|" & Format(rs.GetDateTime("Date_To"), "yyyy-MM-dd")
                        theRow = theRow & "|" & Format(TimeValue(rs.GetTimeSpan("Time_From").ToString), "HH:mm:ss")
                        theRow = theRow & "|" & Format(TimeValue(rs.GetTimeSpan("Time_To").ToString), "HH:mm:ss")
                        theRow = theRow & "|" & rs.GetString("Host")
                        theRow = theRow & "|" & rs.GetString("Contact_Person")

                        'use Split function to generate an array of String
                        dgEvents.Rows.Add(Split(theRow, "|"))
                    End While
                End If
            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                If Not rs Is Nothing Then rs.Close()
                rs = Nothing
                SQLComm = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub btnCloseAttendees_Click(sender As Object, e As EventArgs) Handles btnCloseAttendees.Click
        gbAttendees.Visible = False
    End Sub

    Private Sub dgEvents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEvents.CellClick
        Call DGEvents_Click(dgEvents.Item(0, dgEvents.CurrentCell.RowIndex).Value)
    End Sub

    Private Sub dgEvents_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEvents.RowHeaderMouseClick
        Call DGEvents_Click(dgEvents.Item(0, dgEvents.SelectedRows(0).Index).Value)
    End Sub

    Private Sub DGEvents_Click(eventID As Integer)
        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim rowString As String

        c = connect2()

        If Not c Is Nothing Then
            sql = New MySqlCommand
            sql.Connection = c
            sql.CommandText = String.Format("SELECT visitorNo, firstName + ' ' + lastName as vistorName, company, logINdatetime, logOUTdatetime FROM visitor WHERE event_id={0} and date_visit = curdate()", eventID)

            Try
                r = sql.ExecuteReader

                Dim btnLog As New DataGridViewButtonColumn
                btnLog.HeaderText = ""
                dgEventAttendees.Columns.Add(btnLog)
                dgEventAttendees.Columns.Add("visitorNo", "ID")
                dgEventAttendees.Columns.Add("visitorName", "NAME")
                dgEventAttendees.Columns.Add("company", "Company")

                dgEventAttendees.Columns.Item(0).Width = 50
                dgEventAttendees.Columns.Item(1).Width = 40
                dgEventAttendees.Columns.Item(2).Width = 200
                dgEventAttendees.Columns.Item(3).Width = 200

                If r.HasRows Then
                    While r.Read
                        rowString = ""

                        If r.Item("logINdatetime").Equals(Nothing) And r.Item("logOUTdatetime").Equals(Nothing) Then
                            rowString = "LOG IN"
                        ElseIf Not r.Item("logINdatetime").Equals(Nothing) And r.Item("logOUTdatetime").Equals(Nothing) Then
                            rowString = "LOG OUT"
                        ElseIf Not r.Item("logINdatetime").Equals(Nothing) And Not r.Item("logOUTdatetime").Equals(Nothing) Then
                            rowString = "OK"
                        Else
                            rowString = "Err"
                        End If

                        rowString = rowString & "|" & r.GetInt32("visitorNo")
                        rowString = rowString & "|" & r.GetString("visitorName")
                        rowString = rowString & "|" & r.GetString("company")

                        dgEventAttendees.Rows.Add(Split(rowString, "|"))
                    End While
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
    End Sub

    Private Sub dgEventAttendees_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEventAttendees.CellClick
        If dgEventAttendees.CurrentCell.ColumnIndex = 0 Then
            If dgEventAttendees.CurrentCell.Value = "LOG IN" Then
                If UpdateLogDateTime(
                    dgEventAttendees.Item(1, dgEventAttendees.CurrentCell.RowIndex).Value _
                    , dgEventAttendees.CurrentCell.Value) Then
                    dgEventAttendees.CurrentCell.Value = "LOG OUT"
                End If
            ElseIf dgEventAttendees.CurrentCell.Value = "LOG OUT" Then
                If UpdateLogDateTime(
                    dgEventAttendees.Item(1, dgEventAttendees.CurrentCell.RowIndex).Value _
                    , dgEventAttendees.CurrentCell.Value) Then
                    dgEventAttendees.CurrentCell.Value = "OK"
                End If
            End If
        End If
    End Sub

    Private Function UpdateLogDateTime(visitorID As Integer, log As String) As Boolean
        Dim col As String
        Dim updated As Boolean = False
        Dim c As MySqlConnection
        Dim sql As MySqlCommand

        If log Like "LOG *" Then
            If log = "LOG IN" Then
                col = "logINdatetime"
            ElseIf log = "LOG OUT" Then
                col = "logOUTdatetime"
            End If

            c = connect2()

            If Not c Is Nothing Then
                sql = New MySqlCommand
                sql.Connection = c
                sql.CommandText = String.Format("UPDATE visitor SET {0} = now() WHERE visitorID={1}", col, visitorID)

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

        End If

        UpdateLogDateTime = updated
    End Function

End Class
Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Excel

Public Class frmEVisitors
    Dim selEventID As Integer
    Dim selEventName As String
    Dim selEventDateFrom As String
    Dim selEventDateTo As String
    Dim selEventHost As String
    Dim selEventContact As String
    Dim s As DataTable

    Dim excelApp As Application
    Dim wb As Workbook
    Dim ws As Worksheet

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        frmEvents.Show(Me)
    End Sub

    Public Sub LoadEvents()
        Dim theRow As String
        Dim SQLComm As New MySqlCommand
        Dim rs As MySqlDataReader
        Dim btn As DataGridViewButtonColumn

        If connect() Then
            SQLComm.Connection = conn
            SQLComm.CommandText = "SELECT * FROM current_events;"

            Try
                rs = SQLComm.ExecuteReader()

                dgEvents.Columns.Clear()
                dgEvents.Rows.Clear()

                btn = New DataGridViewButtonColumn
                btn.HeaderText = ""
                dgEvents.Columns.Add(btn)
                For i = 0 To rs.FieldCount - 1
                    'rs.getname(i).tostring will get the columnheader name of the record field
                    dgEvents.Columns.Add(rs.GetName(i).ToString, rs.GetName(i).ToString)
                    If i = 0 Then
                        dgEvents.Columns.Item(i).Width = 50
                    ElseIf i = 1 Then
                        dgEvents.Columns.Item(i).Width = 40
                    ElseIf i = 2 Then
                        dgEvents.Columns.Item(i).Width = 200
                    Else
                        dgEvents.Columns.Item(i).Width = 1
                    End If
                Next
                dgEvents.Columns.Item(rs.FieldCount).Width = 1

                'index of datagrid view starts with 0
                If rs.HasRows Then
                    While rs.Read()
                        'append all columns in a single string, separated by "|"
                        theRow = "GEN"
                        theRow = theRow & "|" & rs.GetString("ID").ToString
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
                rs.Close()
                rs = Nothing
                SQLComm = Nothing
                disconnect()
            End Try
        Else
            MsgBox("Cannot connect to the database.", vbCritical + vbOKOnly)
        End If

    End Sub

    Private Sub frmEventVisitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadEvents()
    End Sub

    Public Sub LoadAttendees()
        selEventID = Val(dgEvents.Item(1, dgEvents.CurrentRow.Index).Value)
        selEventName = dgEvents.Item(2, dgEvents.CurrentRow.Index).Value
        selEventDateFrom = dgEvents.Item(3, dgEvents.CurrentRow.Index).Value
        selEventDateTo = dgEvents.Item(4, dgEvents.CurrentRow.Index).Value
        selEventHost = dgEvents.Item(7, dgEvents.CurrentRow.Index).Value
        selEventContact = dgEvents.Item(8, dgEvents.CurrentRow.Index).Value

        Dim sqlComm As MySqlCommand
        Dim r As MySqlDataReader
        'Dim v As DataView
        Dim theRow As String


        lblEvent.Text = selEventID & " | " & selEventName

        If connect() Then
            sqlComm = New MySqlCommand
            sqlComm.Connection = conn
            sqlComm.CommandText = String.Format("SELECT visitorNo, date_visit, firstName, lastName, address, company FROM visitor WHERE event_id={0}", selEventID)
            Try
                r = sqlComm.ExecuteReader
                dgEventVisitor.Columns.Clear()
                dgEventVisitor.Rows.Clear()

                Dim btnDel As New DataGridViewButtonColumn
                'btnDel.HeaderText = "Delete"
                btnDel.Text = "DEL"
                btnDel.Frozen = True
                dgEventVisitor.Columns.Add(btnDel)
                For i = 0 To r.FieldCount - 1
                    'rs.getname(i).tostring will get the columnheader name of the record field
                    dgEventVisitor.Columns.Add(r.GetName(i).ToString, r.GetName(i).ToString)
                    If i = 0 Or i = 1 Then
                        dgEventVisitor.Columns.Item(i).Width = 40
                    ElseIf i = 2 Then
                        dgEventVisitor.Columns.Item(i).Width = 100
                    Else
                        dgEventVisitor.Columns.Item(i).Width = 150
                    End If
                Next
                dgEventVisitor.Columns.Item(r.FieldCount).Width = 150

                If r.HasRows Then
                    While r.Read()
                        'append all columns in a single string, separated by "|"
                        theRow = "DEL"
                        theRow = theRow & "|" & r.GetString("visitorNo")
                        theRow = theRow & "|" & r.GetString("date_visit")
                        theRow = theRow & "|" & r.GetString("firstName")
                        theRow = theRow & "|" & r.GetString("lastName")
                        theRow = theRow & "|" & r.GetString("address").ToString
                        theRow = theRow & "|" & r.GetString("company").ToString


                        'use Split function to generate an array of String
                        dgEventVisitor.Rows.Add(Split(theRow, "|"))
                    End While
                End If

            Catch ex As Exception
                MsgBox("Something is wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally

            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
        End If
    End Sub

    Private Sub dgEvents_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEvents.RowHeaderMouseClick
        Call LoadAttendees()
    End Sub

    Private Sub btnAddVisitors_Click(sender As Object, e As EventArgs) Handles btnAddVisitors.Click

        With frmEVisitorsAdd
            .eventID = selEventID
            .lblEvent.Text = selEventName
            .lblHost.Text = selEventHost
            .lblContactPerson.Text = selEventContact
            .dateFrom = DateValue(selEventDateFrom)
            .dateTo = DateValue(selEventDateTo)
        End With
        frmEVisitorsAdd.Show(Me)
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        opdVisitors.Filter = "Excel Files | *.xlsx; *.xls"
        opdVisitors.ShowDialog()
        lblFile.Text = opdVisitors.FileName
    End Sub

    Private Sub btnVClose_Click(sender As Object, e As EventArgs) Handles btnVClose.Click
        Me.Close()
    End Sub

    Private Sub dgEvents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgEvents.CellClick
        If dgEvents.Rows.Count <= 0 Then
            Exit Sub
        End If
        If dgEvents.CurrentCell.ColumnIndex = 0 Then
            excelApp = New Application
            wb = excelApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Reports\EventVisitorList.xlsx")
            ws = wb.Worksheets(1)
            ws.Range("EventID").Value = dgEvents.Item(1, dgEvents.CurrentRow.Index).Value
            ws.Range("EventName").Value = dgEvents.Item(2, dgEvents.CurrentRow.Index).Value
            ws.Range("DateFrom").Value = dgEvents.Item(3, dgEvents.CurrentRow.Index).Value
            ws.Range("DateTo").Value = dgEvents.Item(4, dgEvents.CurrentRow.Index).Value
            ws.Range("TimeFrom").Value = dgEvents.Item(5, dgEvents.CurrentRow.Index).Value
            ws.Range("TimeTo").Value = dgEvents.Item(6, dgEvents.CurrentRow.Index).Value
            ws.Range("Host").Value = dgEvents.Item(7, dgEvents.CurrentRow.Index).Value
            ws.Range("ContactPerson").Value = dgEvents.Item(8, dgEvents.CurrentRow.Index).Value

            MsgBox("Save the worksheet that will appear to your desired folder location.", vbInformation + vbOKOnly)
            excelApp.Visible = True
            ws = Nothing
            wb = Nothing
            excelApp = Nothing
        Else
            Call LoadAttendees()
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Call ProcessVisitors()
    End Sub

    Private Sub ProcessVisitors()
        Dim startRow As Integer
        Dim sqlComm As MySqlCommand

        If Trim(lblFile.Text) = "" Then
            MsgBox("Select the visitor list Excel file with filled up contents for processing.", vbExclamation + vbOKOnly)
            Exit Sub
        End If

        excelApp = New Application
        wb = excelApp.Workbooks.Open(lblFile.Text)
        ws = wb.Worksheets(1)

        startRow = ws.Range("VisitorHeader").Row + 1

        If connect() Then
            Try
                While Trim(ws.Cells(startRow, 1).value) <> ""
                    sqlComm = Nothing
                    sqlComm = New MySqlCommand
                    sqlComm.Connection = conn
                    sqlComm.CommandText = String.Format("INSERT INTO visitor (date_visit, firstName, lastName, address, company, " &
                "person_to_visit, department, reason_to_visit, event_id, " &
                "gate_processed, processed_by) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}', " &
                "(SELECT gate FROM gates WHERE computer_name='{9}') ,'{10}')", Format(ws.Cells(startRow, 1).value, "yyyy-MM-dd"),
                                                ws.Cells(startRow, 2).value, ws.Cells(startRow, 3).value, ws.Cells(startRow, 5).value, ws.Cells(startRow, 4).value,
                                                ws.Range("ContactPerson").Value, ws.Range("Host").Value, ws.Range("EventName").Value, ws.Range("EventID").Value,
                                                My.Computer.Name, u)
                    sqlComm.ExecuteNonQuery()
                    startRow = startRow + 1
                End While

                MsgBox("Attendees saved successfully.", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("There is something wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                sqlComm = Nothing
                Call disconnect()
                ws = Nothing
                wb.Close()
                wb = Nothing
                excelApp.Quit()
                excelApp = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCritical + vbOKOnly)
            ws = Nothing
            wb.Close()
            wb = Nothing
            excelApp.Quit()
            excelApp = Nothing
        End If
    End Sub


End Class
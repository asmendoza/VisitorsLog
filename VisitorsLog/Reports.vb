Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class Reports
    Private Sub dtpFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpFrom.ValueChanged
        dtpTo.Value = dtpFrom.Value
    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFrom.Value = Format(Now(), "yyyy/MM/dd")
        LoadComboBoxData()
    End Sub

    Private Sub LoadComboBoxData()
        Dim c As MySqlConnection
        Dim sqlComm As MySqlCommand
        Dim rs As MySqlDataReader

        c = connect2()

        If Not c Is Nothing Then
            sqlComm = New MySqlCommand
            sqlComm.Connection = conn
            sqlComm.CommandText = String.Format("SELECT department FROM hosts")
            Try
                rs = sqlComm.ExecuteReader

                cboDept.Items.Clear()
                While rs.Read
                    cboDept.Items.Add(rs.GetString("department"))
                End While
            Catch ex As Exception
                MsgBox("There is something wrong with the connection." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                If Not rs Is Nothing Then rs.Close()
                rs = Nothing
                sqlComm = Nothing
                c.Close()
                c = Nothing
            End Try
        Else
            MsgBox("Cannot connect to the database server.", vbCr + vbOKOnly)
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Select Case cboReport.SelectedText.ToUpper
            Case "STUDENT VIOLATION"
                Call RPT_StudentViolation()
            Case "VISITOR LOGS"
                Call RPT_VisitorLogs()
            Case "CONTRACTUAL"
                If auto Then
                    Call RPT_Contractual_Auto()
                Else
                    Call RPT_Contractual_Mode()
                End If
            Case "KEY BORROWING"
                Call RPT_KeyBorrowing()
            Case "VEHICLE LOGS"
                Call RPT_CarVisitor()
        End Select
    End Sub

    Private Sub cboReport_Click(sender As Object, e As EventArgs) Handles cboReport.Click
        Call ComboBoxClick(cboReport, "REPORT TYPE", e)
    End Sub

    Private Sub cboReport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboReport.KeyPress
        Call ComboBoxKeyPress(cboReport, "REPORT TYPE", e)
    End Sub

    Private Sub cboReport_TextChanged(sender As Object, e As EventArgs) Handles cboReport.TextChanged
        Call ComboBoxTextChange(cboReport, "REPORT TYPE")
    End Sub

    Private Sub cboDept_TextChanged(sender As Object, e As EventArgs) Handles cboDept.TextChanged
        Call ComboBoxTextChange(cboDept, "DEPARTMENT")
    End Sub

    Private Sub cboDept_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboDept.KeyPress
        Call ComboBoxKeyPress(cboDept, "DEPARTMENT", e)
    End Sub

    Private Sub cboDept_Click(sender As Object, e As EventArgs) Handles cboDept.Click
        Call ComboBoxClick(cboDept, "DEPARTMENT", e)
    End Sub

    Private Sub cboReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReport.SelectedIndexChanged
        Select Case cboReport.SelectedText.ToUpper
            Case "STUDENT VIOLATION", "VISITOR LOGS"
                cboDept.Visible = True
            Case "CONTRACTUAL", "KEY BORROWING", "VEHICLE LOGS"
                cboDept.Visible = False
        End Select
    End Sub

    Private Sub RPT_StudentViolation()
        Dim excelApp As Excel.Application = New Excel.Application
        Dim wb As Workbook
        Dim ws As Worksheet

        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim saveDir As String = "%UserProfile%\Desktop\"

        Dim row As Integer

        c = connect2()

        If Not c Is Nothing Then
            wb = excelApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Reports\StudentViolations.xlsx")

            sql = New MySqlCommand()
            sql.Connection = c
            sql.CommandText = String.Format("SELECT id_no, fullname, violation, course, processed FROM rpt_studentviolation WHERE department='{0}' AND violation_datetime>='{1}'", cboDept.Text, Format(dtpFrom.Value, "yyyy-MM-dd"))
            Try
                r = sql.ExecuteReader
                ws = wb.Worksheets(1)

                ws.Range("ReportDate").Value = Format(dtpFrom.Value, "MMMM d, yyyy")
                ws.Range("Department").Value = cboDept.Text
                row = ws.Range("Header").Row + 1
                While r.Read
                    ws.Cells.Item(row, 1).value = "[" & r.GetString("id_no") & "] " & r.GetString("fullname")
                    ws.Cells.Item(row, 2).value = r.GetString("course")
                    ws.Cells.Item(row, 3).value = r.GetString("violation")
                    ws.Cells.Item(row, 4).value = r.GetString("processed")

                    row = row + 1
                End While
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeLeft)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeRight)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeTop)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeBottom)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideVertical)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideHorizontal)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                wb.SaveAs(saveDir & "StudentViolation_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx")
                lblPath.Text = saveDir & "StudentViolation_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx"
                MsgBox("Report has been generated successfully.", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("Something wrong happened." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                ws = Nothing
                If Not wb Is Nothing Then wb.Close()
                wb = Nothing
                excelApp.Quit()
                excelApp = Nothing

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

    Private Sub RPT_KeyBorrowing()
        Dim excelApp As Excel.Application = New Excel.Application
        Dim wb As Workbook
        Dim ws As Worksheet

        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim saveDir As String = "%UserProfile%\Desktop\"

        Dim row As Integer

        c = connect2()

        If Not c Is Nothing Then
            wb = excelApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Reports\KeyBorrowing.xlsx")

            sql = New MySqlCommand()
            sql.Connection = c
            sql.CommandText = String.Format("SELECT datetime_borrowed, datetime_returned, key_desc, borrower_name, remarks, processed_by FROM rpt_keycontrol WHERE (datetime_borrowed>='{0}' OR datetime_returned>='01}'", Format(dtpFrom.Value, "yyyy-MM-dd"))
            Try
                r = sql.ExecuteReader
                ws = wb.Worksheets(1)

                ws.Range("ReportDate").Value = Format(dtpFrom.Value, "MMMM d, yyyy")
                'ws.Range("Department").Value = cboDept.Text
                row = ws.Range("Header").Row + 1
                While r.Read
                    ws.Cells.Item(row, 1).value = r.GetString("datetime_borrowed")
                    ws.Cells.Item(row, 2).value = r.GetString("datetime_returned")
                    ws.Cells.Item(row, 3).value = r.GetString("key_desc")
                    ws.Cells.Item(row, 4).value = r.GetString("borrower_name")
                    ws.Cells.Item(row, 5).value = IIf(ws.Cells.Item(row, 2).value.ToString.Trim.Equals(""), "", r.GetString("borrower_name"))
                    ws.Cells.Item(row, 6).value = r.GetString("remarks")
                    row = row + 1
                End While
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeLeft)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeRight)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeTop)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeBottom)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideVertical)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideHorizontal)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                wb.SaveAs(saveDir & "KeyBorrowing_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx")
                lblPath.Text = saveDir & "KeyBorrowing_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx"
                MsgBox("Report has been generated successfully.", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("Something wrong happened." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                ws = Nothing
                If Not wb Is Nothing Then wb.Close()
                wb = Nothing
                excelApp.Quit()
                excelApp = Nothing

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

    Private Sub RPT_CarVisitor()
        Dim excelApp As Excel.Application = New Excel.Application
        Dim wb As Workbook
        Dim ws As Worksheet

        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim saveDir As String = "%UserProfile%\Desktop\"

        Dim row As Integer

        c = connect2()

        If Not c Is Nothing Then
            wb = excelApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Reports\VehicleLogs.xlsx")

            sql = New MySqlCommand()
            sql.Connection = c
            sql.CommandText = String.Format("SELECT car_visitdatetime, car_plateno, car_drivername, car_outdatetime FROM rpt_carvisitors WHERE car_visitdatetime>='{0}'", Format(dtpFrom.Value, "yyyy-MM-dd"))
            Try
                r = sql.ExecuteReader
                ws = wb.Worksheets(1)

                ws.Range("ReportDate").Value = Format(dtpFrom.Value, "MMMM d, yyyy")
                'ws.Range("Department").Value = cboDept.Text
                row = ws.Range("Header").Row + 1
                While r.Read
                    ws.Cells.Item(row, 1).value = r.GetString("car_plateno")
                    ws.Cells.Item(row, 2).value = r.GetString("car_drivername")
                    ws.Cells.Item(row, 3).value = r.GetString("car_visitdatetime")
                    ws.Cells.Item(row, 4).value = r.GetString("car_outdatetime")

                    row = row + 1
                End While
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeLeft)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeRight)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeTop)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeBottom)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideVertical)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideHorizontal)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                wb.SaveAs(saveDir & "VehicleLogs_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx")
                lblPath.Text = saveDir & "VehicleLogs_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx"
                MsgBox("Report has been generated successfully.", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("Something wrong happened." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                ws = Nothing
                If Not wb Is Nothing Then wb.Close()
                wb = Nothing
                excelApp.Quit()
                excelApp = Nothing

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

    Private Sub RPT_VisitorLogs()
        Dim excelApp As Excel.Application = New Excel.Application
        Dim wb As Workbook
        Dim ws As Worksheet

        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim saveDir As String = "%UserProfile%\Desktop\"

        Dim row As Integer

        c = connect2()

        If Not c Is Nothing Then
            wb = excelApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Reports\VisitorLog.xlsx")

            sql = New MySqlCommand()
            sql.Connection = c
            sql.CommandText = String.Format("SELECT FullName, address, company, person_to_visit, reason_to_visit, PassNo FROM rpt_visitorlogs WHERE department='{0}' AND date_visit>='{1}'", cboDept.Text, Format(dtpFrom.Value, "yyyy-MM-dd"))
            Try
                r = sql.ExecuteReader
                ws = wb.Worksheets(1)

                ws.Range("ReportDate").Value = Format(dtpFrom.Value, "MMMM d, yyyy")
                ws.Range("Department").Value = cboDept.Text
                row = ws.Range("Header").Row + 1
                While r.Read
                    ws.Cells.Item(row, 1).value = "IFERROR(A" & row - 1 & "+1,1)"
                    ws.Cells.Item(row, 2).value = r.GetString("FullName")
                    ws.Cells.Item(row, 3).value = r.GetString("address")
                    ws.Cells.Item(row, 4).value = r.GetString("company")
                    ws.Cells.Item(row, 5).value = r.GetString("person_to_visit")
                    ws.Cells.Item(row, 6).value = r.GetString("reason_to_visit")
                    ws.Cells.Item(row, 7).value = r.GetString("PassNo")

                    row = row + 1
                End While
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeLeft)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeRight)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeTop)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeBottom)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideVertical)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideHorizontal)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                wb.SaveAs(saveDir & "VisitorLog_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx")
                lblPath.Text = saveDir & "VisitorLog_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx"
                MsgBox("Report has been generated successfully.", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("Something wrong happened." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                ws = Nothing
                If Not wb Is Nothing Then wb.Close()
                wb = Nothing
                excelApp.Quit()
                excelApp = Nothing

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

    Private Sub RPT_Contractual_Mode()
        Dim excelApp As Excel.Application = New Excel.Application
        Dim wb As Workbook
        Dim ws As Worksheet

        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim saveDir As String = "%UserProfile%\Desktop\"

        Dim row As Integer

        c = connect2()

        If Not c Is Nothing Then
            wb = excelApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Reports\Contractual_mode.xlsx")

            sql = New MySqlCommand()
            sql.Connection = c
            sql.CommandText = String.Format("SELECT id_no, fullname, mode, mode_date, mode_time FROM rpt_contractual_mode WHERE person_type='contractual' AND mode_time>='{0}'", Format(dtpFrom.Value, "yyyy-MM-dd"))
            Try
                r = sql.ExecuteReader
                ws = wb.Worksheets("Data")
                ws.Select()
                'ws.Range("ReportDate").Value = Format(dtpFrom.Value, "MMMM d, yyyy")
                'ws.Range("Department").Value = cboDept.Text
                row = ws.Range("Header").Row + 1
                While r.Read
                    ws.Cells.Item(row, 1).value = "[" & r.GetString("id_no") & "] " & r.GetString("fullname")
                    ws.Cells.Item(row, 2).value = r.GetString("mode")
                    ws.Cells.Item(row, 3).value = r.GetString("mode_date")
                    ws.Cells.Item(row, 3).value = r.GetString("mode_time")

                    row = row + 1
                End While
                ws = wb.Worksheets("Pivot")
                ws.Select()
                ws.Range("A2").Select()
                ws.PivotTables("pvtAttendance").ChangePivotCache(
                    wb.PivotCaches.Create(SourceType:=XlPivotTableSourceType.xlDatabase,
                                            SourceData:=wb.Worksheets("Data").range(wb.Worksheets("Data").range("Header"), wb.Worksheets("Data").range("Header").end(XlDirection.xlToRight).End(XlDirection.xlDown)),
                                            Version:=6))
                With ws.PivotTables("pvtAttendance").PivotFields("Header")
                    .Orientation = XlPivotFieldOrientation.xlRowField
                    .Position = 1
                End With
                ws.PivotTables("pvtAttendance").PivotFields("Header").Caption = "Full Name"

                wb.SaveAs(saveDir & "Contractual_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx")
                lblPath.Text = saveDir & "Contractual_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx"
                MsgBox("Report has been generated successfully.", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("Something wrong happened." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                ws = Nothing
                If Not wb Is Nothing Then wb.Close()
                wb = Nothing
                excelApp.Quit()
                excelApp = Nothing

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

    Private Sub RPT_Contractual_Auto()
        Dim excelApp As Excel.Application = New Excel.Application
        Dim wb As Workbook
        Dim ws As Worksheet

        Dim c As MySqlConnection
        Dim sql As MySqlCommand
        Dim r As MySqlDataReader
        Dim saveDir As String = "%UserProfile%\Desktop\"

        Dim row As Integer

        c = connect2()

        If Not c Is Nothing Then
            wb = excelApp.Workbooks.Open(My.Application.Info.DirectoryPath & "\Reports\Contractual.xlsx")

            sql = New MySqlCommand()
            sql.Connection = c
            sql.CommandText = String.Format("SELECT id_no, fullname, time_in, time_out FROM rpt_contractual_mode WHERE person_type='contractual' AND time_in>='{0}'", Format(dtpFrom.Value, "yyyy-MM-dd"))
            Try
                r = sql.ExecuteReader
                ws = wb.Worksheets(1)

                ws.Range("ReportDate").Value = Format(dtpFrom.Value, "MMMM d, yyyy")
                'ws.Range("Department").Value = cboDept.Text
                row = ws.Range("Header").Row + 1
                While r.Read
                    ws.Cells.Item(row, 1).value = "[" & r.GetString("id_no") & "] " & r.GetString("fullname")
                    ws.Cells.Item(row, 2).value = r.GetString("time_in")
                    ws.Cells.Item(row, 3).value = r.GetString("time_out")

                    row = row + 1
                End While
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeLeft)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeRight)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeTop)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlEdgeBottom)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideVertical)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                With ws.Range(ws.Range("Header"), ws.Range("Header").End(XlDirection.xlToRight).End(XlDirection.xlDown)).Borders(XlBordersIndex.xlInsideHorizontal)
                    .LineStyle = XlLineStyle.xlContinuous
                    .ColorIndex = 0
                    .TintAndShade = 0
                    .Weight = XlBorderWeight.xlThin
                End With
                wb.SaveAs(saveDir & "Contractual_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx")
                lblPath.Text = saveDir & "Contractual_" & Format(Now, "yyyyMMdd-HHmmss") & ".xlsx"
                MsgBox("Report has been generated successfully.", vbInformation + vbOKOnly)
            Catch ex As Exception
                MsgBox("Something wrong happened." & vbCrLf & ex.Message, vbExclamation + vbOKOnly)
            Finally
                ws = Nothing
                If Not wb Is Nothing Then wb.Close()
                wb = Nothing
                excelApp.Quit()
                excelApp = Nothing

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

    Private Sub btnOpenReport_Click(sender As Object, e As EventArgs) Handles btnOpenReport.Click
        Shell("excel " & lblPath.Text)
    End Sub
End Class
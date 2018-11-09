<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnVisitor = New System.Windows.Forms.Button()
        Me.pnlMainTop = New System.Windows.Forms.Panel()
        Me.lblLogout = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMainBottom = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlDTodayIn = New System.Windows.Forms.Panel()
        Me.pnlDLoggedIn = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlDVIn = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDVisitorIn = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlDExpected = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDExpected = New System.Windows.Forms.Label()
        Me.picExpected = New System.Windows.Forms.PictureBox()
        Me.pnlDTotalVisits = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDTtlVisits = New System.Windows.Forms.Label()
        Me.picTotal = New System.Windows.Forms.PictureBox()
        Me.pnlDToday = New System.Windows.Forms.Panel()
        Me.pnlDDate = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.picCalendar = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.gbEvents = New System.Windows.Forms.GroupBox()
        Me.dgEvents = New System.Windows.Forms.DataGridView()
        Me.gbAttendees = New System.Windows.Forms.GroupBox()
        Me.btnCloseAttendees = New System.Windows.Forms.Button()
        Me.dgEventAttendees = New System.Windows.Forms.DataGridView()
        Me.pnlMainTop.SuspendLayout()
        Me.pnlMainBottom.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlDTodayIn.SuspendLayout()
        Me.pnlDLoggedIn.SuspendLayout()
        Me.pnlDVIn.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDExpected.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.picExpected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDTotalVisits.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.picTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDToday.SuspendLayout()
        Me.pnlDDate.SuspendLayout()
        CType(Me.picCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEvents.SuspendLayout()
        CType(Me.dgEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAttendees.SuspendLayout()
        CType(Me.dgEventAttendees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVisitor
        '
        Me.btnVisitor.AutoSize = True
        Me.btnVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitor.Location = New System.Drawing.Point(12, 14)
        Me.btnVisitor.Name = "btnVisitor"
        Me.btnVisitor.Size = New System.Drawing.Size(84, 30)
        Me.btnVisitor.TabIndex = 0
        Me.btnVisitor.Text = "&VISITOR"
        Me.btnVisitor.UseVisualStyleBackColor = True
        '
        'pnlMainTop
        '
        Me.pnlMainTop.BackColor = System.Drawing.Color.Maroon
        Me.pnlMainTop.Controls.Add(Me.lblLogout)
        Me.pnlMainTop.Controls.Add(Me.Label1)
        Me.pnlMainTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMainTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlMainTop.Name = "pnlMainTop"
        Me.pnlMainTop.Size = New System.Drawing.Size(801, 56)
        Me.pnlMainTop.TabIndex = 2
        '
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblLogout.ForeColor = System.Drawing.Color.White
        Me.lblLogout.LinkColor = System.Drawing.Color.White
        Me.lblLogout.Location = New System.Drawing.Point(761, 0)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(40, 13)
        Me.lblLogout.TabIndex = 1
        Me.lblLogout.TabStop = True
        Me.lblLogout.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard"
        '
        'pnlMainBottom
        '
        Me.pnlMainBottom.Controls.Add(Me.btnVisitor)
        Me.pnlMainBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlMainBottom.Location = New System.Drawing.Point(0, 409)
        Me.pnlMainBottom.Name = "pnlMainBottom"
        Me.pnlMainBottom.Size = New System.Drawing.Size(801, 56)
        Me.pnlMainBottom.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pnlDTodayIn)
        Me.Panel1.Controls.Add(Me.pnlDExpected)
        Me.Panel1.Controls.Add(Me.pnlDTotalVisits)
        Me.Panel1.Controls.Add(Me.pnlDToday)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 69)
        Me.Panel1.TabIndex = 4
        '
        'pnlDTodayIn
        '
        Me.pnlDTodayIn.BackColor = System.Drawing.Color.YellowGreen
        Me.pnlDTodayIn.Controls.Add(Me.pnlDLoggedIn)
        Me.pnlDTodayIn.Controls.Add(Me.PictureBox1)
        Me.pnlDTodayIn.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDTodayIn.Location = New System.Drawing.Point(201, 0)
        Me.pnlDTodayIn.Name = "pnlDTodayIn"
        Me.pnlDTodayIn.Size = New System.Drawing.Size(200, 69)
        Me.pnlDTodayIn.TabIndex = 5
        '
        'pnlDLoggedIn
        '
        Me.pnlDLoggedIn.Controls.Add(Me.Label3)
        Me.pnlDLoggedIn.Controls.Add(Me.pnlDVIn)
        Me.pnlDLoggedIn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDLoggedIn.Location = New System.Drawing.Point(73, 0)
        Me.pnlDLoggedIn.Name = "pnlDLoggedIn"
        Me.pnlDLoggedIn.Size = New System.Drawing.Size(127, 69)
        Me.pnlDLoggedIn.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(0, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Currently Signed In"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlDVIn
        '
        Me.pnlDVIn.Controls.Add(Me.Label2)
        Me.pnlDVIn.Controls.Add(Me.lblDVisitorIn)
        Me.pnlDVIn.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDVIn.Location = New System.Drawing.Point(0, 0)
        Me.pnlDVIn.Name = "pnlDVIn"
        Me.pnlDVIn.Size = New System.Drawing.Size(127, 33)
        Me.pnlDVIn.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Visitor/s"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDVisitorIn
        '
        Me.lblDVisitorIn.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDVisitorIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDVisitorIn.Location = New System.Drawing.Point(0, 0)
        Me.lblDVisitorIn.Name = "lblDVisitorIn"
        Me.lblDVisitorIn.Size = New System.Drawing.Size(51, 33)
        Me.lblDVisitorIn.TabIndex = 0
        Me.lblDVisitorIn.Text = "0"
        Me.lblDVisitorIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlDExpected
        '
        Me.pnlDExpected.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlDExpected.Controls.Add(Me.Panel3)
        Me.pnlDExpected.Controls.Add(Me.picExpected)
        Me.pnlDExpected.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDExpected.Location = New System.Drawing.Point(401, 0)
        Me.pnlDExpected.Name = "pnlDExpected"
        Me.pnlDExpected.Size = New System.Drawing.Size(200, 69)
        Me.pnlDExpected.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(73, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(127, 69)
        Me.Panel3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Location = New System.Drawing.Point(0, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Expected Visitors"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.lblDExpected)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(127, 33)
        Me.Panel4.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 33)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Visitor/s"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDExpected
        '
        Me.lblDExpected.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDExpected.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDExpected.Location = New System.Drawing.Point(0, 0)
        Me.lblDExpected.Name = "lblDExpected"
        Me.lblDExpected.Size = New System.Drawing.Size(53, 33)
        Me.lblDExpected.TabIndex = 0
        Me.lblDExpected.Text = "0"
        Me.lblDExpected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picExpected
        '
        Me.picExpected.Dock = System.Windows.Forms.DockStyle.Left
        Me.picExpected.Location = New System.Drawing.Point(0, 0)
        Me.picExpected.Name = "picExpected"
        Me.picExpected.Size = New System.Drawing.Size(73, 69)
        Me.picExpected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picExpected.TabIndex = 0
        Me.picExpected.TabStop = False
        '
        'pnlDTotalVisits
        '
        Me.pnlDTotalVisits.BackColor = System.Drawing.Color.PaleVioletRed
        Me.pnlDTotalVisits.Controls.Add(Me.Panel6)
        Me.pnlDTotalVisits.Controls.Add(Me.picTotal)
        Me.pnlDTotalVisits.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlDTotalVisits.Location = New System.Drawing.Point(601, 0)
        Me.pnlDTotalVisits.Name = "pnlDTotalVisits"
        Me.pnlDTotalVisits.Size = New System.Drawing.Size(200, 69)
        Me.pnlDTotalVisits.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(73, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(127, 69)
        Me.Panel6.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Location = New System.Drawing.Point(0, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 26)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Total Visits"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.lblDTtlVisits)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(127, 33)
        Me.Panel7.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(49, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 33)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Visitor/s"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDTtlVisits
        '
        Me.lblDTtlVisits.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblDTtlVisits.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDTtlVisits.Location = New System.Drawing.Point(0, 0)
        Me.lblDTtlVisits.Name = "lblDTtlVisits"
        Me.lblDTtlVisits.Size = New System.Drawing.Size(49, 33)
        Me.lblDTtlVisits.TabIndex = 0
        Me.lblDTtlVisits.Text = "0"
        Me.lblDTtlVisits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picTotal
        '
        Me.picTotal.Dock = System.Windows.Forms.DockStyle.Left
        Me.picTotal.Location = New System.Drawing.Point(0, 0)
        Me.picTotal.Name = "picTotal"
        Me.picTotal.Size = New System.Drawing.Size(73, 69)
        Me.picTotal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picTotal.TabIndex = 0
        Me.picTotal.TabStop = False
        '
        'pnlDToday
        '
        Me.pnlDToday.Controls.Add(Me.pnlDDate)
        Me.pnlDToday.Controls.Add(Me.picCalendar)
        Me.pnlDToday.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlDToday.Location = New System.Drawing.Point(0, 0)
        Me.pnlDToday.Name = "pnlDToday"
        Me.pnlDToday.Size = New System.Drawing.Size(295, 69)
        Me.pnlDToday.TabIndex = 0
        '
        'pnlDDate
        '
        Me.pnlDDate.Controls.Add(Me.lblTime)
        Me.pnlDDate.Controls.Add(Me.lblDate)
        Me.pnlDDate.Controls.Add(Me.lblDay)
        Me.pnlDDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDDate.Location = New System.Drawing.Point(81, 0)
        Me.pnlDDate.Name = "pnlDDate"
        Me.pnlDDate.Size = New System.Drawing.Size(214, 69)
        Me.pnlDDate.TabIndex = 5
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(0, 51)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(86, 18)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "Time Today"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(0, 15)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(123, 25)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date Today"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(0, 0)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(28, 15)
        Me.lblDay.TabIndex = 0
        Me.lblDay.Text = "Day"
        '
        'picCalendar
        '
        Me.picCalendar.Dock = System.Windows.Forms.DockStyle.Left
        Me.picCalendar.Location = New System.Drawing.Point(0, 0)
        Me.picCalendar.Name = "picCalendar"
        Me.picCalendar.Size = New System.Drawing.Size(81, 69)
        Me.picCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picCalendar.TabIndex = 0
        Me.picCalendar.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 30720
        '
        'gbEvents
        '
        Me.gbEvents.Controls.Add(Me.dgEvents)
        Me.gbEvents.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbEvents.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEvents.Location = New System.Drawing.Point(0, 125)
        Me.gbEvents.Name = "gbEvents"
        Me.gbEvents.Size = New System.Drawing.Size(274, 284)
        Me.gbEvents.TabIndex = 5
        Me.gbEvents.TabStop = False
        Me.gbEvents.Text = "Events Today"
        '
        'dgEvents
        '
        Me.dgEvents.AllowUserToAddRows = False
        Me.dgEvents.AllowUserToDeleteRows = False
        Me.dgEvents.AllowUserToResizeColumns = False
        Me.dgEvents.AllowUserToResizeRows = False
        Me.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEvents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgEvents.Location = New System.Drawing.Point(3, 18)
        Me.dgEvents.Name = "dgEvents"
        Me.dgEvents.ReadOnly = True
        Me.dgEvents.Size = New System.Drawing.Size(268, 263)
        Me.dgEvents.TabIndex = 2
        '
        'gbAttendees
        '
        Me.gbAttendees.Controls.Add(Me.btnCloseAttendees)
        Me.gbAttendees.Controls.Add(Me.dgEventAttendees)
        Me.gbAttendees.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbAttendees.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbAttendees.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAttendees.Location = New System.Drawing.Point(274, 125)
        Me.gbAttendees.Name = "gbAttendees"
        Me.gbAttendees.Size = New System.Drawing.Size(524, 284)
        Me.gbAttendees.TabIndex = 6
        Me.gbAttendees.TabStop = False
        Me.gbAttendees.Text = "Attendees"
        Me.gbAttendees.Visible = False
        '
        'btnCloseAttendees
        '
        Me.btnCloseAttendees.Location = New System.Drawing.Point(443, 18)
        Me.btnCloseAttendees.Name = "btnCloseAttendees"
        Me.btnCloseAttendees.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseAttendees.TabIndex = 3
        Me.btnCloseAttendees.Text = "Close"
        Me.btnCloseAttendees.UseVisualStyleBackColor = True
        '
        'dgEventAttendees
        '
        Me.dgEventAttendees.AllowUserToAddRows = False
        Me.dgEventAttendees.AllowUserToDeleteRows = False
        Me.dgEventAttendees.AllowUserToResizeColumns = False
        Me.dgEventAttendees.AllowUserToResizeRows = False
        Me.dgEventAttendees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEventAttendees.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgEventAttendees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgEventAttendees.Location = New System.Drawing.Point(3, 47)
        Me.dgEventAttendees.Name = "dgEventAttendees"
        Me.dgEventAttendees.ReadOnly = True
        Me.dgEventAttendees.Size = New System.Drawing.Size(518, 234)
        Me.dgEventAttendees.TabIndex = 2
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 465)
        Me.Controls.Add(Me.gbAttendees)
        Me.Controls.Add(Me.gbEvents)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlMainBottom)
        Me.Controls.Add(Me.pnlMainTop)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlMainTop.ResumeLayout(False)
        Me.pnlMainTop.PerformLayout()
        Me.pnlMainBottom.ResumeLayout(False)
        Me.pnlMainBottom.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.pnlDTodayIn.ResumeLayout(False)
        Me.pnlDLoggedIn.ResumeLayout(False)
        Me.pnlDVIn.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDExpected.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.picExpected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDTotalVisits.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.picTotal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDToday.ResumeLayout(False)
        Me.pnlDDate.ResumeLayout(False)
        Me.pnlDDate.PerformLayout()
        CType(Me.picCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEvents.ResumeLayout(False)
        CType(Me.dgEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAttendees.ResumeLayout(False)
        CType(Me.dgEventAttendees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVisitor As Button
    Friend WithEvents pnlMainTop As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlMainBottom As Panel
    Friend WithEvents lblLogout As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlDTodayIn As Panel
    Friend WithEvents pnlDLoggedIn As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlDVIn As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDVisitorIn As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnlDExpected As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblDExpected As Label
    Friend WithEvents picExpected As PictureBox
    Friend WithEvents pnlDTotalVisits As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDTtlVisits As Label
    Friend WithEvents picTotal As PictureBox
    Friend WithEvents pnlDToday As Panel
    Friend WithEvents pnlDDate As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents picCalendar As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents gbEvents As GroupBox
    Friend WithEvents dgEvents As DataGridView
    Friend WithEvents gbAttendees As GroupBox
    Friend WithEvents dgEventAttendees As DataGridView
    Friend WithEvents btnCloseAttendees As Button
End Class

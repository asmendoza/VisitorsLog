<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEVisitorsAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.chkAttendAll = New System.Windows.Forms.CheckBox()
        Me.cboDateAttend = New System.Windows.Forms.ComboBox()
        Me.btnSaveClose = New System.Windows.Forms.Button()
        Me.btnSaveAdd = New System.Windows.Forms.Button()
        Me.lblContactPerson = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.chkAttendAll)
        Me.Panel1.Controls.Add(Me.cboDateAttend)
        Me.Panel1.Controls.Add(Me.btnSaveClose)
        Me.Panel1.Controls.Add(Me.btnSaveAdd)
        Me.Panel1.Controls.Add(Me.lblContactPerson)
        Me.Panel1.Controls.Add(Me.lblHost)
        Me.Panel1.Controls.Add(Me.lblEvent)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.txtCompany)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 357)
        Me.Panel1.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(6, 322)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'chkAttendAll
        '
        Me.chkAttendAll.AutoSize = True
        Me.chkAttendAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAttendAll.Location = New System.Drawing.Point(193, 283)
        Me.chkAttendAll.Name = "chkAttendAll"
        Me.chkAttendAll.Size = New System.Drawing.Size(131, 24)
        Me.chkAttendAll.TabIndex = 13
        Me.chkAttendAll.Text = "Attend all date"
        Me.chkAttendAll.UseVisualStyleBackColor = True
        '
        'cboDateAttend
        '
        Me.cboDateAttend.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDateAttend.FormattingEnabled = True
        Me.cboDateAttend.Location = New System.Drawing.Point(6, 281)
        Me.cboDateAttend.Name = "cboDateAttend"
        Me.cboDateAttend.Size = New System.Drawing.Size(181, 28)
        Me.cboDateAttend.TabIndex = 12
        '
        'btnSaveClose
        '
        Me.btnSaveClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveClose.Location = New System.Drawing.Point(253, 322)
        Me.btnSaveClose.Name = "btnSaveClose"
        Me.btnSaveClose.Size = New System.Drawing.Size(112, 23)
        Me.btnSaveClose.TabIndex = 11
        Me.btnSaveClose.Text = "Save and Close"
        Me.btnSaveClose.UseVisualStyleBackColor = True
        '
        'btnSaveAdd
        '
        Me.btnSaveAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAdd.Location = New System.Drawing.Point(93, 322)
        Me.btnSaveAdd.Name = "btnSaveAdd"
        Me.btnSaveAdd.Size = New System.Drawing.Size(154, 23)
        Me.btnSaveAdd.TabIndex = 10
        Me.btnSaveAdd.Text = "Save and Add Another"
        Me.btnSaveAdd.UseVisualStyleBackColor = True
        '
        'lblContactPerson
        '
        Me.lblContactPerson.AutoSize = True
        Me.lblContactPerson.Location = New System.Drawing.Point(6, 90)
        Me.lblContactPerson.Name = "lblContactPerson"
        Me.lblContactPerson.Size = New System.Drawing.Size(80, 13)
        Me.lblContactPerson.TabIndex = 9
        Me.lblContactPerson.Text = "Contact Person"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHost.Location = New System.Drawing.Point(6, 75)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(100, 15)
        Me.lblHost.TabIndex = 8
        Me.lblHost.Text = "Host/Department"
        '
        'lblEvent
        '
        Me.lblEvent.AutoSize = True
        Me.lblEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvent.Location = New System.Drawing.Point(6, 48)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(82, 16)
        Me.lblEvent.TabIndex = 7
        Me.lblEvent.Text = "Event Name"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtAddress.Location = New System.Drawing.Point(6, 194)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(359, 26)
        Me.txtAddress.TabIndex = 5
        Me.txtAddress.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(2, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ATTENDEE'S INFORMATION"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Silver
        Me.txtFirstName.Location = New System.Drawing.Point(6, 118)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(359, 26)
        Me.txtFirstName.TabIndex = 3
        Me.txtFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtLastName.Location = New System.Drawing.Point(6, 150)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(359, 26)
        Me.txtLastName.TabIndex = 4
        Me.txtLastName.Text = "Last Name"
        '
        'txtCompany
        '
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCompany.Location = New System.Drawing.Point(6, 242)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(359, 26)
        Me.txtCompany.TabIndex = 6
        Me.txtCompany.Text = "Company"
        '
        'frmEVisitorsAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(404, 381)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(420, 420)
        Me.MinimizeBox = False
        Me.Name = "frmEVisitorsAdd"
        Me.Text = "frmEVisitorsAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents lblHost As Label
    Friend WithEvents lblEvent As Label
    Friend WithEvents lblContactPerson As Label
    Friend WithEvents btnSaveAdd As Button
    Friend WithEvents btnSaveClose As Button
    Friend WithEvents chkAttendAll As CheckBox
    Friend WithEvents cboDateAttend As ComboBox
    Friend WithEvents btnClear As Button
End Class

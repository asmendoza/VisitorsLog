<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisitors
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlVisitors = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlRFIDIn = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRFID = New System.Windows.Forms.TextBox()
        Me.txtIDNo = New System.Windows.Forms.TextBox()
        Me.btnVID = New System.Windows.Forms.Button()
        Me.picID = New System.Windows.Forms.PictureBox()
        Me.txtIDType = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.cboReason = New System.Windows.Forms.ComboBox()
        Me.cboPerson = New System.Windows.Forms.ComboBox()
        Me.cboDept = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnVSave = New System.Windows.Forms.Button()
        Me.btnVClear = New System.Windows.Forms.Button()
        Me.btnVClose = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabVisitor = New System.Windows.Forms.TabControl()
        Me.tabVisitor_SI = New System.Windows.Forms.TabPage()
        Me.tabVisitor_SO = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlVisitorDet = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picIDOut = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtRFID_OUT = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlVisitors.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlRFIDIn.SuspendLayout()
        CType(Me.picID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.tabVisitor.SuspendLayout()
        Me.tabVisitor_SI.SuspendLayout()
        Me.tabVisitor_SO.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlVisitorDet.SuspendLayout()
        CType(Me.picIDOut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlVisitors
        '
        Me.pnlVisitors.Controls.Add(Me.Panel11)
        Me.pnlVisitors.Controls.Add(Me.Panel10)
        Me.pnlVisitors.Controls.Add(Me.Panel12)
        Me.pnlVisitors.Controls.Add(Me.Panel13)
        Me.pnlVisitors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVisitors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlVisitors.Location = New System.Drawing.Point(3, 3)
        Me.pnlVisitors.Name = "pnlVisitors"
        Me.pnlVisitors.Size = New System.Drawing.Size(817, 380)
        Me.pnlVisitors.TabIndex = 12
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel2)
        Me.Panel11.Controls.Add(Me.Panel1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 37)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(567, 311)
        Me.Panel11.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtIDNo)
        Me.Panel2.Controls.Add(Me.btnVID)
        Me.Panel2.Controls.Add(Me.picID)
        Me.Panel2.Controls.Add(Me.txtIDType)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 311)
        Me.Panel2.TabIndex = 2
        '
        'pnlRFIDIn
        '
        Me.pnlRFIDIn.BackColor = System.Drawing.Color.White
        Me.pnlRFIDIn.Controls.Add(Me.Label5)
        Me.pnlRFIDIn.Controls.Add(Me.Label4)
        Me.pnlRFIDIn.Controls.Add(Me.txtRFID)
        Me.pnlRFIDIn.Location = New System.Drawing.Point(0, 0)
        Me.pnlRFIDIn.Name = "pnlRFIDIn"
        Me.pnlRFIDIn.Size = New System.Drawing.Size(823, 378)
        Me.pnlRFIDIn.TabIndex = 13
        Me.pnlRFIDIn.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(288, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(254, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Press Escape (ESC) key to cancel."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(153, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(521, 73)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "TAP RFID CARD"
        '
        'txtRFID
        '
        Me.txtRFID.Location = New System.Drawing.Point(301, 172)
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(218, 26)
        Me.txtRFID.TabIndex = 0
        '
        'txtIDNo
        '
        Me.txtIDNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNo.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtIDNo.Location = New System.Drawing.Point(8, 245)
        Me.txtIDNo.Name = "txtIDNo"
        Me.txtIDNo.Size = New System.Drawing.Size(243, 26)
        Me.txtIDNo.TabIndex = 2
        Me.txtIDNo.Text = "ID No"
        '
        'btnVID
        '
        Me.btnVID.BackColor = System.Drawing.Color.SteelBlue
        Me.btnVID.ForeColor = System.Drawing.Color.White
        Me.btnVID.Location = New System.Drawing.Point(8, 162)
        Me.btnVID.Name = "btnVID"
        Me.btnVID.Size = New System.Drawing.Size(243, 33)
        Me.btnVID.TabIndex = 0
        Me.btnVID.Text = "Turn On Camera"
        Me.btnVID.UseVisualStyleBackColor = False
        '
        'picID
        '
        Me.picID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picID.Location = New System.Drawing.Point(8, 12)
        Me.picID.Name = "picID"
        Me.picID.Size = New System.Drawing.Size(243, 144)
        Me.picID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picID.TabIndex = 0
        Me.picID.TabStop = False
        '
        'txtIDType
        '
        Me.txtIDType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDType.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtIDType.Location = New System.Drawing.Point(8, 213)
        Me.txtIDType.Name = "txtIDType"
        Me.txtIDType.Size = New System.Drawing.Size(243, 26)
        Me.txtIDType.TabIndex = 1
        Me.txtIDType.Text = "ID Type"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.txtCompany)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(283, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 311)
        Me.Panel1.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtAddress.Location = New System.Drawing.Point(6, 144)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(272, 26)
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
        Me.Label1.Size = New System.Drawing.Size(231, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PERSONAL INFORMATION"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.Silver
        Me.txtFirstName.Location = New System.Drawing.Point(6, 68)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(272, 26)
        Me.txtFirstName.TabIndex = 3
        Me.txtFirstName.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtLastName.Location = New System.Drawing.Point(6, 100)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(272, 26)
        Me.txtLastName.TabIndex = 4
        Me.txtLastName.Text = "Last Name"
        '
        'txtCompany
        '
        Me.txtCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCompany.Location = New System.Drawing.Point(6, 192)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(272, 26)
        Me.txtCompany.TabIndex = 6
        Me.txtCompany.Text = "Company"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.cboReason)
        Me.Panel10.Controls.Add(Me.cboPerson)
        Me.Panel10.Controls.Add(Me.cboDept)
        Me.Panel10.Controls.Add(Me.Label2)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(567, 37)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(250, 311)
        Me.Panel10.TabIndex = 4
        '
        'cboReason
        '
        Me.cboReason.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReason.ForeColor = System.Drawing.Color.Silver
        Me.cboReason.FormattingEnabled = True
        Me.cboReason.Location = New System.Drawing.Point(6, 162)
        Me.cboReason.Name = "cboReason"
        Me.cboReason.Size = New System.Drawing.Size(239, 28)
        Me.cboReason.TabIndex = 9
        Me.cboReason.Text = "Reason of Visit"
        '
        'cboPerson
        '
        Me.cboPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPerson.ForeColor = System.Drawing.Color.Silver
        Me.cboPerson.FormattingEnabled = True
        Me.cboPerson.Location = New System.Drawing.Point(6, 116)
        Me.cboPerson.Name = "cboPerson"
        Me.cboPerson.Size = New System.Drawing.Size(239, 28)
        Me.cboPerson.TabIndex = 8
        Me.cboPerson.Text = "Person to Visit"
        '
        'cboDept
        '
        Me.cboDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDept.ForeColor = System.Drawing.Color.Silver
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(6, 68)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(239, 28)
        Me.cboDept.TabIndex = 7
        Me.cboDept.Text = "Department"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "VISIT INFORMATION"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.btnVSave)
        Me.Panel12.Controls.Add(Me.btnVClear)
        Me.Panel12.Controls.Add(Me.btnVClose)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 348)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(817, 32)
        Me.Panel12.TabIndex = 5
        '
        'btnVSave
        '
        Me.btnVSave.AutoSize = True
        Me.btnVSave.BackColor = System.Drawing.Color.Green
        Me.btnVSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVSave.ForeColor = System.Drawing.Color.White
        Me.btnVSave.Location = New System.Drawing.Point(481, 0)
        Me.btnVSave.Name = "btnVSave"
        Me.btnVSave.Size = New System.Drawing.Size(112, 32)
        Me.btnVSave.TabIndex = 10
        Me.btnVSave.Text = "&SAVE"
        Me.btnVSave.UseVisualStyleBackColor = False
        '
        'btnVClear
        '
        Me.btnVClear.AutoSize = True
        Me.btnVClear.BackColor = System.Drawing.Color.Red
        Me.btnVClear.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVClear.ForeColor = System.Drawing.Color.White
        Me.btnVClear.Location = New System.Drawing.Point(593, 0)
        Me.btnVClear.Name = "btnVClear"
        Me.btnVClear.Size = New System.Drawing.Size(112, 32)
        Me.btnVClear.TabIndex = 11
        Me.btnVClear.Text = "&CLEAR"
        Me.btnVClear.UseVisualStyleBackColor = False
        '
        'btnVClose
        '
        Me.btnVClose.AutoSize = True
        Me.btnVClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVClose.Location = New System.Drawing.Point(705, 0)
        Me.btnVClose.Name = "btnVClose"
        Me.btnVClose.Size = New System.Drawing.Size(112, 32)
        Me.btnVClose.TabIndex = 12
        Me.btnVClose.Text = "CLOS&E"
        Me.btnVClose.UseVisualStyleBackColor = True
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.Label3)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(817, 37)
        Me.Panel13.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Visitors Pass"
        '
        'tabVisitor
        '
        Me.tabVisitor.Controls.Add(Me.tabVisitor_SI)
        Me.tabVisitor.Controls.Add(Me.tabVisitor_SO)
        Me.tabVisitor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabVisitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabVisitor.Location = New System.Drawing.Point(0, 0)
        Me.tabVisitor.Name = "tabVisitor"
        Me.tabVisitor.SelectedIndex = 0
        Me.tabVisitor.Size = New System.Drawing.Size(831, 419)
        Me.tabVisitor.TabIndex = 0
        '
        'tabVisitor_SI
        '
        Me.tabVisitor_SI.AllowDrop = True
        Me.tabVisitor_SI.Controls.Add(Me.pnlRFIDIn)
        Me.tabVisitor_SI.Controls.Add(Me.pnlVisitors)
        Me.tabVisitor_SI.Location = New System.Drawing.Point(4, 29)
        Me.tabVisitor_SI.Name = "tabVisitor_SI"
        Me.tabVisitor_SI.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVisitor_SI.Size = New System.Drawing.Size(823, 386)
        Me.tabVisitor_SI.TabIndex = 0
        Me.tabVisitor_SI.Text = "Sign In"
        Me.tabVisitor_SI.UseVisualStyleBackColor = True
        '
        'tabVisitor_SO
        '
        Me.tabVisitor_SO.Controls.Add(Me.Panel3)
        Me.tabVisitor_SO.Location = New System.Drawing.Point(4, 29)
        Me.tabVisitor_SO.Name = "tabVisitor_SO"
        Me.tabVisitor_SO.Padding = New System.Windows.Forms.Padding(3)
        Me.tabVisitor_SO.Size = New System.Drawing.Size(823, 386)
        Me.tabVisitor_SO.TabIndex = 1
        Me.tabVisitor_SO.Text = "Sign Out"
        Me.tabVisitor_SO.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.pnlVisitorDet)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtRFID_OUT)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(817, 380)
        Me.Panel3.TabIndex = 14
        '
        'pnlVisitorDet
        '
        Me.pnlVisitorDet.Controls.Add(Me.btnClose)
        Me.pnlVisitorDet.Controls.Add(Me.lblCompany)
        Me.pnlVisitorDet.Controls.Add(Me.lblName)
        Me.pnlVisitorDet.Controls.Add(Me.picIDOut)
        Me.pnlVisitorDet.Location = New System.Drawing.Point(169, 49)
        Me.pnlVisitorDet.Name = "pnlVisitorDet"
        Me.pnlVisitorDet.Size = New System.Drawing.Size(508, 302)
        Me.pnlVisitorDet.TabIndex = 3
        Me.pnlVisitorDet.Visible = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(230, 249)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 28)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "C&LOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblCompany
        '
        Me.lblCompany.Location = New System.Drawing.Point(72, 214)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(389, 32)
        Me.lblCompany.TabIndex = 3
        Me.lblCompany.Text = "Company"
        Me.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(72, 178)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(389, 32)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picIDOut
        '
        Me.picIDOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picIDOut.Location = New System.Drawing.Point(143, 17)
        Me.picIDOut.Name = "picIDOut"
        Me.picIDOut.Size = New System.Drawing.Size(243, 144)
        Me.picIDOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIDOut.TabIndex = 1
        Me.picIDOut.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(521, 73)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "TAP RFID CARD"
        '
        'txtRFID_OUT
        '
        Me.txtRFID_OUT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRFID_OUT.ForeColor = System.Drawing.Color.White
        Me.txtRFID_OUT.Location = New System.Drawing.Point(326, 171)
        Me.txtRFID_OUT.Name = "txtRFID_OUT"
        Me.txtRFID_OUT.Size = New System.Drawing.Size(218, 19)
        Me.txtRFID_OUT.TabIndex = 0
        '
        'Timer1
        '
        '
        'frmVisitors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 419)
        Me.Controls.Add(Me.tabVisitor)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVisitors"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmVisitors"
        Me.pnlVisitors.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlRFIDIn.ResumeLayout(False)
        Me.pnlRFIDIn.PerformLayout()
        CType(Me.picID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.tabVisitor.ResumeLayout(False)
        Me.tabVisitor_SI.ResumeLayout(False)
        Me.tabVisitor_SO.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlVisitorDet.ResumeLayout(False)
        CType(Me.picIDOut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlVisitors As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents txtIDType As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnVSave As Button
    Friend WithEvents btnVClear As Button
    Friend WithEvents btnVClose As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents tabVisitor As TabControl
    Friend WithEvents tabVisitor_SI As TabPage
    Friend WithEvents tabVisitor_SO As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents picID As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboReason As ComboBox
    Friend WithEvents cboPerson As ComboBox
    Friend WithEvents cboDept As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIDNo As TextBox
    Friend WithEvents btnVID As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pnlRFIDIn As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRFID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtRFID_OUT As TextBox
    Friend WithEvents pnlVisitorDet As Panel
    Friend WithEvents picIDOut As PictureBox
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnClose As Button
End Class

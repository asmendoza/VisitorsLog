<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Me.pnlUsers = New System.Windows.Forms.Panel()
        Me.pnlUsersFill = New System.Windows.Forms.Panel()
        Me.dgUsers = New System.Windows.Forms.DataGridView()
        Me.pnlUsersRight = New System.Windows.Forms.Panel()
        Me.pnlUsersRightTop = New System.Windows.Forms.Panel()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.chkIsAdmin = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtRePassword = New System.Windows.Forms.TextBox()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.pnlUsersRightBottom = New System.Windows.Forms.Panel()
        Me.btnMUClose = New System.Windows.Forms.Button()
        Me.btnMUDelete = New System.Windows.Forms.Button()
        Me.btnMUAdd = New System.Windows.Forms.Button()
        Me.btnMUSave = New System.Windows.Forms.Button()
        Me.pnlUsersTop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlUsers.SuspendLayout()
        Me.pnlUsersFill.SuspendLayout()
        CType(Me.dgUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsersRight.SuspendLayout()
        Me.pnlUsersRightTop.SuspendLayout()
        Me.pnlUsersRightBottom.SuspendLayout()
        Me.pnlUsersTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUsers
        '
        Me.pnlUsers.Controls.Add(Me.pnlUsersFill)
        Me.pnlUsers.Controls.Add(Me.pnlUsersRight)
        Me.pnlUsers.Controls.Add(Me.pnlUsersTop)
        Me.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlUsers.Location = New System.Drawing.Point(0, 0)
        Me.pnlUsers.Name = "pnlUsers"
        Me.pnlUsers.Size = New System.Drawing.Size(687, 383)
        Me.pnlUsers.TabIndex = 5
        '
        'pnlUsersFill
        '
        Me.pnlUsersFill.Controls.Add(Me.dgUsers)
        Me.pnlUsersFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUsersFill.Location = New System.Drawing.Point(0, 37)
        Me.pnlUsersFill.Name = "pnlUsersFill"
        Me.pnlUsersFill.Size = New System.Drawing.Size(473, 346)
        Me.pnlUsersFill.TabIndex = 10
        '
        'dgUsers
        '
        Me.dgUsers.AllowUserToAddRows = False
        Me.dgUsers.AllowUserToDeleteRows = False
        Me.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUsers.Location = New System.Drawing.Point(0, 0)
        Me.dgUsers.Name = "dgUsers"
        Me.dgUsers.ReadOnly = True
        Me.dgUsers.Size = New System.Drawing.Size(473, 346)
        Me.dgUsers.TabIndex = 6
        '
        'pnlUsersRight
        '
        Me.pnlUsersRight.Controls.Add(Me.pnlUsersRightTop)
        Me.pnlUsersRight.Controls.Add(Me.pnlUsersRightBottom)
        Me.pnlUsersRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlUsersRight.Location = New System.Drawing.Point(473, 37)
        Me.pnlUsersRight.Name = "pnlUsersRight"
        Me.pnlUsersRight.Size = New System.Drawing.Size(214, 346)
        Me.pnlUsersRight.TabIndex = 9
        '
        'pnlUsersRightTop
        '
        Me.pnlUsersRightTop.Controls.Add(Me.txtUsername)
        Me.pnlUsersRightTop.Controls.Add(Me.chkIsAdmin)
        Me.pnlUsersRightTop.Controls.Add(Me.txtPassword)
        Me.pnlUsersRightTop.Controls.Add(Me.txtRePassword)
        Me.pnlUsersRightTop.Controls.Add(Me.txtFullName)
        Me.pnlUsersRightTop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUsersRightTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlUsersRightTop.Name = "pnlUsersRightTop"
        Me.pnlUsersRightTop.Size = New System.Drawing.Size(214, 200)
        Me.pnlUsersRightTop.TabIndex = 10
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Silver
        Me.txtUsername.Location = New System.Drawing.Point(3, 3)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(207, 26)
        Me.txtUsername.TabIndex = 0
        Me.txtUsername.Text = "Username"
        '
        'chkIsAdmin
        '
        Me.chkIsAdmin.AutoSize = True
        Me.chkIsAdmin.Location = New System.Drawing.Point(49, 131)
        Me.chkIsAdmin.Name = "chkIsAdmin"
        Me.chkIsAdmin.Size = New System.Drawing.Size(122, 24)
        Me.chkIsAdmin.TabIndex = 4
        Me.chkIsAdmin.Text = "Administrator"
        Me.chkIsAdmin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPassword.Location = New System.Drawing.Point(3, 67)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(207, 26)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = "Password"
        '
        'txtRePassword
        '
        Me.txtRePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRePassword.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtRePassword.Location = New System.Drawing.Point(3, 99)
        Me.txtRePassword.Name = "txtRePassword"
        Me.txtRePassword.Size = New System.Drawing.Size(207, 26)
        Me.txtRePassword.TabIndex = 3
        Me.txtRePassword.Text = "Retype Password"
        '
        'txtFullName
        '
        Me.txtFullName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFullName.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtFullName.Location = New System.Drawing.Point(3, 35)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(207, 26)
        Me.txtFullName.TabIndex = 1
        Me.txtFullName.Text = "Full Name"
        '
        'pnlUsersRightBottom
        '
        Me.pnlUsersRightBottom.Controls.Add(Me.btnMUClose)
        Me.pnlUsersRightBottom.Controls.Add(Me.btnMUDelete)
        Me.pnlUsersRightBottom.Controls.Add(Me.btnMUAdd)
        Me.pnlUsersRightBottom.Controls.Add(Me.btnMUSave)
        Me.pnlUsersRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlUsersRightBottom.Location = New System.Drawing.Point(0, 200)
        Me.pnlUsersRightBottom.Name = "pnlUsersRightBottom"
        Me.pnlUsersRightBottom.Size = New System.Drawing.Size(214, 146)
        Me.pnlUsersRightBottom.TabIndex = 8
        '
        'btnMUClose
        '
        Me.btnMUClose.AutoSize = True
        Me.btnMUClose.Location = New System.Drawing.Point(3, 110)
        Me.btnMUClose.Name = "btnMUClose"
        Me.btnMUClose.Size = New System.Drawing.Size(207, 30)
        Me.btnMUClose.TabIndex = 8
        Me.btnMUClose.Text = "&CLOSE"
        Me.btnMUClose.UseVisualStyleBackColor = True
        '
        'btnMUDelete
        '
        Me.btnMUDelete.AutoSize = True
        Me.btnMUDelete.Enabled = False
        Me.btnMUDelete.Location = New System.Drawing.Point(3, 38)
        Me.btnMUDelete.Name = "btnMUDelete"
        Me.btnMUDelete.Size = New System.Drawing.Size(207, 30)
        Me.btnMUDelete.TabIndex = 7
        Me.btnMUDelete.Text = "&DELETE USER"
        Me.btnMUDelete.UseVisualStyleBackColor = True
        '
        'btnMUAdd
        '
        Me.btnMUAdd.AutoSize = True
        Me.btnMUAdd.Location = New System.Drawing.Point(3, 2)
        Me.btnMUAdd.Name = "btnMUAdd"
        Me.btnMUAdd.Size = New System.Drawing.Size(207, 30)
        Me.btnMUAdd.TabIndex = 6
        Me.btnMUAdd.Text = "&ADD USER"
        Me.btnMUAdd.UseVisualStyleBackColor = True
        '
        'btnMUSave
        '
        Me.btnMUSave.AutoSize = True
        Me.btnMUSave.Location = New System.Drawing.Point(3, 74)
        Me.btnMUSave.Name = "btnMUSave"
        Me.btnMUSave.Size = New System.Drawing.Size(207, 30)
        Me.btnMUSave.TabIndex = 5
        Me.btnMUSave.Text = "&SAVE USER"
        Me.btnMUSave.UseVisualStyleBackColor = True
        '
        'pnlUsersTop
        '
        Me.pnlUsersTop.Controls.Add(Me.Label2)
        Me.pnlUsersTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUsersTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlUsersTop.Name = "pnlUsersTop"
        Me.pnlUsersTop.Size = New System.Drawing.Size(687, 37)
        Me.pnlUsersTop.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Manage Users"
        '
        'frmUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(687, 383)
        Me.Controls.Add(Me.pnlUsers)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUsers"
        Me.pnlUsers.ResumeLayout(False)
        Me.pnlUsersFill.ResumeLayout(False)
        CType(Me.dgUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsersRight.ResumeLayout(False)
        Me.pnlUsersRightTop.ResumeLayout(False)
        Me.pnlUsersRightTop.PerformLayout()
        Me.pnlUsersRightBottom.ResumeLayout(False)
        Me.pnlUsersRightBottom.PerformLayout()
        Me.pnlUsersTop.ResumeLayout(False)
        Me.pnlUsersTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlUsers As Panel
    Friend WithEvents pnlUsersFill As Panel
    Friend WithEvents dgUsers As DataGridView
    Friend WithEvents pnlUsersRight As Panel
    Friend WithEvents pnlUsersRightTop As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents chkIsAdmin As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtRePassword As TextBox
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents pnlUsersRightBottom As Panel
    Friend WithEvents btnMUClose As Button
    Friend WithEvents btnMUDelete As Button
    Friend WithEvents btnMUAdd As Button
    Friend WithEvents btnMUSave As Button
    Friend WithEvents pnlUsersTop As Panel
    Friend WithEvents Label2 As Label
End Class

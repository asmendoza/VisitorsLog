<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputers
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlUsersTop = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnVClose = New System.Windows.Forms.Button()
        Me.dgComputers = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtComputer = New System.Windows.Forms.TextBox()
        Me.txtGateNo = New System.Windows.Forms.TextBox()
        Me.pnlUsersTop.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.dgComputers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlUsersTop
        '
        Me.pnlUsersTop.Controls.Add(Me.Label2)
        Me.pnlUsersTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUsersTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlUsersTop.Name = "pnlUsersTop"
        Me.pnlUsersTop.Size = New System.Drawing.Size(547, 37)
        Me.pnlUsersTop.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Computer-Gates"
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.btnVClose)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 345)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(547, 32)
        Me.Panel12.TabIndex = 10
        '
        'btnVClose
        '
        Me.btnVClose.AutoSize = True
        Me.btnVClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVClose.Location = New System.Drawing.Point(435, 0)
        Me.btnVClose.Name = "btnVClose"
        Me.btnVClose.Size = New System.Drawing.Size(112, 32)
        Me.btnVClose.TabIndex = 12
        Me.btnVClose.Text = "CLOS&E"
        Me.btnVClose.UseVisualStyleBackColor = True
        '
        'dgComputers
        '
        Me.dgComputers.AllowUserToAddRows = False
        Me.dgComputers.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgComputers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgComputers.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgComputers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgComputers.Location = New System.Drawing.Point(0, 184)
        Me.dgComputers.Name = "dgComputers"
        Me.dgComputers.ReadOnly = True
        Me.dgComputers.Size = New System.Drawing.Size(547, 161)
        Me.dgComputers.TabIndex = 11
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(234, 129)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 27)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtComputer
        '
        Me.txtComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComputer.ForeColor = System.Drawing.Color.Silver
        Me.txtComputer.Location = New System.Drawing.Point(159, 97)
        Me.txtComputer.Name = "txtComputer"
        Me.txtComputer.Size = New System.Drawing.Size(231, 26)
        Me.txtComputer.TabIndex = 13
        Me.txtComputer.Text = "Computer Name"
        '
        'txtGateNo
        '
        Me.txtGateNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGateNo.ForeColor = System.Drawing.Color.Silver
        Me.txtGateNo.Location = New System.Drawing.Point(159, 65)
        Me.txtGateNo.Name = "txtGateNo"
        Me.txtGateNo.Size = New System.Drawing.Size(231, 26)
        Me.txtGateNo.TabIndex = 12
        Me.txtGateNo.Text = "Gate No"
        '
        'frmComputers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(547, 377)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtComputer)
        Me.Controls.Add(Me.txtGateNo)
        Me.Controls.Add(Me.dgComputers)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.pnlUsersTop)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(563, 416)
        Me.MinimizeBox = False
        Me.Name = "frmComputers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmComputers"
        Me.pnlUsersTop.ResumeLayout(False)
        Me.pnlUsersTop.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.dgComputers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlUsersTop As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnVClose As Button
    Friend WithEvents dgComputers As DataGridView
    Friend WithEvents btnSave As Button
    Friend WithEvents txtComputer As TextBox
    Friend WithEvents txtGateNo As TextBox
End Class

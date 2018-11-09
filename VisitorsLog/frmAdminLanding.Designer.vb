<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminLanding
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
        Me.pnlUsersTop = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lstMenu = New System.Windows.Forms.ListBox()
        Me.pnlUsersTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlUsersTop
        '
        Me.pnlUsersTop.Controls.Add(Me.lblHeader)
        Me.pnlUsersTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUsersTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlUsersTop.Name = "pnlUsersTop"
        Me.pnlUsersTop.Size = New System.Drawing.Size(544, 37)
        Me.pnlUsersTop.TabIndex = 10
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(3, 4)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(110, 25)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Selection"
        '
        'lstMenu
        '
        Me.lstMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMenu.FormattingEnabled = True
        Me.lstMenu.ItemHeight = 20
        Me.lstMenu.Items.AddRange(New Object() {"Users", "Keys", "Application Settings", "Events", "People Management", "Computers", "--", "User Dashboard", "Reports"})
        Me.lstMenu.Location = New System.Drawing.Point(12, 46)
        Me.lstMenu.Name = "lstMenu"
        Me.lstMenu.Size = New System.Drawing.Size(236, 324)
        Me.lstMenu.TabIndex = 11
        '
        'frmAdminLanding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 382)
        Me.Controls.Add(Me.lstMenu)
        Me.Controls.Add(Me.pnlUsersTop)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 421)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 421)
        Me.Name = "frmAdminLanding"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdminLanding"
        Me.pnlUsersTop.ResumeLayout(False)
        Me.pnlUsersTop.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlUsersTop As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents lstMenu As ListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserLandingPage
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
        Me.btnVisitors = New System.Windows.Forms.Button()
        Me.btnKeys = New System.Windows.Forms.Button()
        Me.btnCars = New System.Windows.Forms.Button()
        Me.btnInOut = New System.Windows.Forms.Button()
        Me.pnlUsersTop = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblLogout = New System.Windows.Forms.LinkLabel()
        Me.pnlUsersTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVisitors
        '
        Me.btnVisitors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitors.Location = New System.Drawing.Point(51, 108)
        Me.btnVisitors.Name = "btnVisitors"
        Me.btnVisitors.Size = New System.Drawing.Size(431, 32)
        Me.btnVisitors.TabIndex = 0
        Me.btnVisitors.Text = "VISITORS"
        Me.btnVisitors.UseVisualStyleBackColor = True
        '
        'btnKeys
        '
        Me.btnKeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeys.Location = New System.Drawing.Point(51, 171)
        Me.btnKeys.Name = "btnKeys"
        Me.btnKeys.Size = New System.Drawing.Size(431, 32)
        Me.btnKeys.TabIndex = 1
        Me.btnKeys.Text = "KEYS"
        Me.btnKeys.UseVisualStyleBackColor = True
        '
        'btnCars
        '
        Me.btnCars.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCars.Location = New System.Drawing.Point(51, 236)
        Me.btnCars.Name = "btnCars"
        Me.btnCars.Size = New System.Drawing.Size(431, 32)
        Me.btnCars.TabIndex = 2
        Me.btnCars.Text = "CARS"
        Me.btnCars.UseVisualStyleBackColor = True
        '
        'btnInOut
        '
        Me.btnInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInOut.Location = New System.Drawing.Point(51, 306)
        Me.btnInOut.Name = "btnInOut"
        Me.btnInOut.Size = New System.Drawing.Size(431, 32)
        Me.btnInOut.TabIndex = 3
        Me.btnInOut.Text = "IN - OUT"
        Me.btnInOut.UseVisualStyleBackColor = True
        '
        'pnlUsersTop
        '
        Me.pnlUsersTop.Controls.Add(Me.lblHeader)
        Me.pnlUsersTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlUsersTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlUsersTop.Name = "pnlUsersTop"
        Me.pnlUsersTop.Size = New System.Drawing.Size(544, 37)
        Me.pnlUsersTop.TabIndex = 9
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
        'lblLogout
        '
        Me.lblLogout.AutoSize = True
        Me.lblLogout.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblLogout.ForeColor = System.Drawing.Color.Black
        Me.lblLogout.LinkColor = System.Drawing.Color.Black
        Me.lblLogout.Location = New System.Drawing.Point(504, 37)
        Me.lblLogout.Name = "lblLogout"
        Me.lblLogout.Size = New System.Drawing.Size(40, 13)
        Me.lblLogout.TabIndex = 10
        Me.lblLogout.TabStop = True
        Me.lblLogout.Text = "Logout"
        '
        'frmUserLandingPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 382)
        Me.Controls.Add(Me.lblLogout)
        Me.Controls.Add(Me.pnlUsersTop)
        Me.Controls.Add(Me.btnInOut)
        Me.Controls.Add(Me.btnCars)
        Me.Controls.Add(Me.btnKeys)
        Me.Controls.Add(Me.btnVisitors)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 421)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 421)
        Me.Name = "frmUserLandingPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUserLandingPage"
        Me.pnlUsersTop.ResumeLayout(False)
        Me.pnlUsersTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnVisitors As Button
    Friend WithEvents btnKeys As Button
    Friend WithEvents btnCars As Button
    Friend WithEvents btnInOut As Button
    Friend WithEvents pnlUsersTop As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblLogout As LinkLabel
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEVisitors
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
        Me.pnlVisitors = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.pnlEventVisitors = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAddVisitors = New System.Windows.Forms.Button()
        Me.dgEventVisitor = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblEvent = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgEvents = New System.Windows.Forms.DataGridView()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.btnVClose = New System.Windows.Forms.Button()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.opdVisitors = New System.Windows.Forms.OpenFileDialog()
        Me.pnlVisitors.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.pnlEventVisitors.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgEventVisitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlVisitors
        '
        Me.pnlVisitors.Controls.Add(Me.Panel11)
        Me.pnlVisitors.Controls.Add(Me.Panel12)
        Me.pnlVisitors.Controls.Add(Me.Panel13)
        Me.pnlVisitors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVisitors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlVisitors.Location = New System.Drawing.Point(0, 0)
        Me.pnlVisitors.Name = "pnlVisitors"
        Me.pnlVisitors.Size = New System.Drawing.Size(984, 407)
        Me.pnlVisitors.TabIndex = 14
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.pnlEventVisitors)
        Me.Panel11.Controls.Add(Me.Panel2)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 37)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(984, 338)
        Me.Panel11.TabIndex = 10
        '
        'pnlEventVisitors
        '
        Me.pnlEventVisitors.Controls.Add(Me.Panel3)
        Me.pnlEventVisitors.Controls.Add(Me.Panel1)
        Me.pnlEventVisitors.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlEventVisitors.Location = New System.Drawing.Point(321, 0)
        Me.pnlEventVisitors.Name = "pnlEventVisitors"
        Me.pnlEventVisitors.Size = New System.Drawing.Size(663, 338)
        Me.pnlEventVisitors.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnAddVisitors)
        Me.Panel3.Controls.Add(Me.dgEventVisitor)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 36)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(663, 302)
        Me.Panel3.TabIndex = 6
        '
        'btnAddVisitors
        '
        Me.btnAddVisitors.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAddVisitors.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAddVisitors.ForeColor = System.Drawing.Color.White
        Me.btnAddVisitors.Location = New System.Drawing.Point(0, 269)
        Me.btnAddVisitors.Name = "btnAddVisitors"
        Me.btnAddVisitors.Size = New System.Drawing.Size(663, 33)
        Me.btnAddVisitors.TabIndex = 4
        Me.btnAddVisitors.Text = "Add Visitors"
        Me.btnAddVisitors.UseVisualStyleBackColor = False
        '
        'dgEventVisitor
        '
        Me.dgEventVisitor.AllowUserToAddRows = False
        Me.dgEventVisitor.AllowUserToDeleteRows = False
        Me.dgEventVisitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEventVisitor.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgEventVisitor.Location = New System.Drawing.Point(0, 0)
        Me.dgEventVisitor.Margin = New System.Windows.Forms.Padding(20)
        Me.dgEventVisitor.Name = "dgEventVisitor"
        Me.dgEventVisitor.ReadOnly = True
        Me.dgEventVisitor.Size = New System.Drawing.Size(663, 269)
        Me.dgEventVisitor.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.lblEvent)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 36)
        Me.Panel1.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(439, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 28)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.Text = "[Visit Date]"
        Me.ComboBox1.Visible = False
        '
        'lblEvent
        '
        Me.lblEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEvent.Location = New System.Drawing.Point(3, 3)
        Me.lblEvent.Name = "lblEvent"
        Me.lblEvent.Size = New System.Drawing.Size(309, 26)
        Me.lblEvent.TabIndex = 4
        Me.lblEvent.Text = "Events Visitors"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgEvents)
        Me.Panel2.Controls.Add(Me.btnEvents)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 338)
        Me.Panel2.TabIndex = 2
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
        Me.dgEvents.Location = New System.Drawing.Point(0, 0)
        Me.dgEvents.Name = "dgEvents"
        Me.dgEvents.ReadOnly = True
        Me.dgEvents.Size = New System.Drawing.Size(283, 305)
        Me.dgEvents.TabIndex = 1
        '
        'btnEvents
        '
        Me.btnEvents.BackColor = System.Drawing.Color.SteelBlue
        Me.btnEvents.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnEvents.ForeColor = System.Drawing.Color.White
        Me.btnEvents.Location = New System.Drawing.Point(0, 305)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(283, 33)
        Me.btnEvents.TabIndex = 0
        Me.btnEvents.Text = "Add Events"
        Me.btnEvents.UseVisualStyleBackColor = False
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.btnOpen)
        Me.Panel12.Controls.Add(Me.btnProcess)
        Me.Panel12.Controls.Add(Me.lblFile)
        Me.Panel12.Controls.Add(Me.btnVClose)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 375)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(984, 32)
        Me.Panel12.TabIndex = 5
        '
        'btnOpen
        '
        Me.btnOpen.AutoSize = True
        Me.btnOpen.BackColor = System.Drawing.Color.Coral
        Me.btnOpen.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOpen.ForeColor = System.Drawing.Color.White
        Me.btnOpen.Location = New System.Drawing.Point(640, 0)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(120, 32)
        Me.btnOpen.TabIndex = 15
        Me.btnOpen.Text = "SE&LECT FILE"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnProcess
        '
        Me.btnProcess.AutoSize = True
        Me.btnProcess.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnProcess.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnProcess.ForeColor = System.Drawing.Color.White
        Me.btnProcess.Location = New System.Drawing.Point(760, 0)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(112, 32)
        Me.btnProcess.TabIndex = 14
        Me.btnProcess.Text = "&PROCESS"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'lblFile
        '
        Me.lblFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFile.Location = New System.Drawing.Point(4, 3)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(629, 25)
        Me.lblFile.TabIndex = 13
        '
        'btnVClose
        '
        Me.btnVClose.AutoSize = True
        Me.btnVClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnVClose.Location = New System.Drawing.Point(872, 0)
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
        Me.Panel13.Size = New System.Drawing.Size(984, 37)
        Me.Panel13.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Events Visitors"
        '
        'frmEVisitors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 407)
        Me.Controls.Add(Me.pnlVisitors)
        Me.MaximumSize = New System.Drawing.Size(1000, 446)
        Me.MinimizeBox = False
        Me.Name = "frmEVisitors"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEVisitors"
        Me.pnlVisitors.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.pnlEventVisitors.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgEventVisitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlVisitors As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents pnlEventVisitors As Panel
    Friend WithEvents lblEvent As Label
    Friend WithEvents dgEventVisitor As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgEvents As DataGridView
    Friend WithEvents btnEvents As Button
    Friend WithEvents Panel12 As Panel
    Friend WithEvents btnVClose As Button
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddVisitors As Button
    Friend WithEvents btnOpen As Button
    Friend WithEvents btnProcess As Button
    Friend WithEvents lblFile As Label
    Friend WithEvents opdVisitors As OpenFileDialog
End Class

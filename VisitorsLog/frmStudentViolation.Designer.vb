<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentViolation
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDept = New System.Windows.Forms.Label()
        Me.cboViolation = New System.Windows.Forms.ComboBox()
        Me.dgViolation = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.dgViolation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(122, 90)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(321, 23)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "STUDENT NAME"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStudID
        '
        Me.txtStudID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStudID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStudID.Enabled = False
        Me.txtStudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.ForeColor = System.Drawing.Color.Silver
        Me.txtStudID.Location = New System.Drawing.Point(122, 57)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(321, 26)
        Me.txtStudID.TabIndex = 5
        Me.txtStudID.Text = "STUDENT ID"
        Me.txtStudID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Student Violations"
        '
        'lblDept
        '
        Me.lblDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDept.Location = New System.Drawing.Point(122, 113)
        Me.lblDept.Name = "lblDept"
        Me.lblDept.Size = New System.Drawing.Size(321, 23)
        Me.lblDept.TabIndex = 8
        Me.lblDept.Text = "DEPARTMENT"
        Me.lblDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboViolation
        '
        Me.cboViolation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboViolation.FormattingEnabled = True
        Me.cboViolation.Location = New System.Drawing.Point(122, 140)
        Me.cboViolation.Name = "cboViolation"
        Me.cboViolation.Size = New System.Drawing.Size(321, 28)
        Me.cboViolation.TabIndex = 9
        '
        'dgViolation
        '
        Me.dgViolation.AllowUserToAddRows = False
        Me.dgViolation.AllowUserToDeleteRows = False
        Me.dgViolation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgViolation.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgViolation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgViolation.Location = New System.Drawing.Point(0, 226)
        Me.dgViolation.Name = "dgViolation"
        Me.dgViolation.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgViolation.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgViolation.Size = New System.Drawing.Size(544, 156)
        Me.dgViolation.TabIndex = 10
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = True
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(194, 174)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(168, 32)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "&ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmStudentViolation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 382)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgViolation)
        Me.Controls.Add(Me.cboViolation)
        Me.Controls.Add(Me.lblDept)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtStudID)
        Me.MaximumSize = New System.Drawing.Size(560, 421)
        Me.MinimumSize = New System.Drawing.Size(560, 421)
        Me.Name = "frmStudentViolation"
        Me.Text = "frmStudentViolation"
        CType(Me.dgViolation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDept As Label
    Friend WithEvents cboViolation As ComboBox
    Friend WithEvents dgViolation As DataGridView
    Friend WithEvents btnAdd As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeopleManagement
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
        Me.dgPeople = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cboDept = New System.Windows.Forms.ComboBox()
        Me.txtRFID = New System.Windows.Forms.TextBox()
        Me.pnlUsersRightBottom = New System.Windows.Forms.Panel()
        Me.btnPMSearch = New System.Windows.Forms.Button()
        Me.btnPMClose = New System.Windows.Forms.Button()
        Me.btnPMDelete = New System.Windows.Forms.Button()
        Me.btnPMAdd = New System.Windows.Forms.Button()
        Me.btnPMSave = New System.Windows.Forms.Button()
        Me.rbEmployee = New System.Windows.Forms.RadioButton()
        Me.rbStudent = New System.Windows.Forms.RadioButton()
        Me.rbContractor = New System.Windows.Forms.RadioButton()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        CType(Me.dgPeople, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUsersRightBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgPeople
        '
        Me.dgPeople.AllowUserToAddRows = False
        Me.dgPeople.AllowUserToDeleteRows = False
        Me.dgPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPeople.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgPeople.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgPeople.Location = New System.Drawing.Point(0, 303)
        Me.dgPeople.Name = "dgPeople"
        Me.dgPeople.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPeople.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgPeople.Size = New System.Drawing.Size(800, 147)
        Me.dgPeople.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 27)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Employee / Student List Management"
        '
        'txtIDNumber
        '
        Me.txtIDNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIDNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIDNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDNumber.ForeColor = System.Drawing.Color.Silver
        Me.txtIDNumber.Location = New System.Drawing.Point(17, 47)
        Me.txtIDNumber.Name = "txtIDNumber"
        Me.txtIDNumber.Size = New System.Drawing.Size(193, 26)
        Me.txtIDNumber.TabIndex = 12
        Me.txtIDNumber.Text = "ID NUMBER"
        Me.txtIDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Silver
        Me.txtName.Location = New System.Drawing.Point(216, 47)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(572, 26)
        Me.txtName.TabIndex = 13
        Me.txtName.Text = "NAME"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboDept
        '
        Me.cboDept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDept.ForeColor = System.Drawing.Color.Silver
        Me.cboDept.FormattingEnabled = True
        Me.cboDept.Location = New System.Drawing.Point(17, 79)
        Me.cboDept.Name = "cboDept"
        Me.cboDept.Size = New System.Drawing.Size(421, 28)
        Me.cboDept.TabIndex = 14
        Me.cboDept.Text = "DEPARTMENT"
        '
        'txtRFID
        '
        Me.txtRFID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRFID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.Silver
        Me.txtRFID.Location = New System.Drawing.Point(444, 81)
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(344, 26)
        Me.txtRFID.TabIndex = 15
        Me.txtRFID.Text = "RFID SN"
        Me.txtRFID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pnlUsersRightBottom
        '
        Me.pnlUsersRightBottom.Controls.Add(Me.btnPMSearch)
        Me.pnlUsersRightBottom.Controls.Add(Me.btnPMClose)
        Me.pnlUsersRightBottom.Controls.Add(Me.btnPMDelete)
        Me.pnlUsersRightBottom.Controls.Add(Me.btnPMAdd)
        Me.pnlUsersRightBottom.Controls.Add(Me.btnPMSave)
        Me.pnlUsersRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlUsersRightBottom.Location = New System.Drawing.Point(0, 266)
        Me.pnlUsersRightBottom.Name = "pnlUsersRightBottom"
        Me.pnlUsersRightBottom.Size = New System.Drawing.Size(800, 37)
        Me.pnlUsersRightBottom.TabIndex = 16
        '
        'btnPMSearch
        '
        Me.btnPMSearch.AutoSize = True
        Me.btnPMSearch.Location = New System.Drawing.Point(3, 4)
        Me.btnPMSearch.Name = "btnPMSearch"
        Me.btnPMSearch.Size = New System.Drawing.Size(96, 30)
        Me.btnPMSearch.TabIndex = 9
        Me.btnPMSearch.Text = "&SEARCH"
        Me.btnPMSearch.UseVisualStyleBackColor = True
        '
        'btnPMClose
        '
        Me.btnPMClose.AutoSize = True
        Me.btnPMClose.Location = New System.Drawing.Point(701, 3)
        Me.btnPMClose.Name = "btnPMClose"
        Me.btnPMClose.Size = New System.Drawing.Size(96, 30)
        Me.btnPMClose.TabIndex = 8
        Me.btnPMClose.Text = "&CLOSE"
        Me.btnPMClose.UseVisualStyleBackColor = True
        '
        'btnPMDelete
        '
        Me.btnPMDelete.AutoSize = True
        Me.btnPMDelete.Enabled = False
        Me.btnPMDelete.Location = New System.Drawing.Point(497, 3)
        Me.btnPMDelete.Name = "btnPMDelete"
        Me.btnPMDelete.Size = New System.Drawing.Size(96, 30)
        Me.btnPMDelete.TabIndex = 7
        Me.btnPMDelete.Text = "&DELETE"
        Me.btnPMDelete.UseVisualStyleBackColor = True
        '
        'btnPMAdd
        '
        Me.btnPMAdd.AutoSize = True
        Me.btnPMAdd.Location = New System.Drawing.Point(395, 3)
        Me.btnPMAdd.Name = "btnPMAdd"
        Me.btnPMAdd.Size = New System.Drawing.Size(96, 30)
        Me.btnPMAdd.TabIndex = 6
        Me.btnPMAdd.Text = "&ADD"
        Me.btnPMAdd.UseVisualStyleBackColor = True
        '
        'btnPMSave
        '
        Me.btnPMSave.AutoSize = True
        Me.btnPMSave.Location = New System.Drawing.Point(599, 3)
        Me.btnPMSave.Name = "btnPMSave"
        Me.btnPMSave.Size = New System.Drawing.Size(96, 30)
        Me.btnPMSave.TabIndex = 5
        Me.btnPMSave.Text = "&UPDATE"
        Me.btnPMSave.UseVisualStyleBackColor = True
        '
        'rbEmployee
        '
        Me.rbEmployee.AutoSize = True
        Me.rbEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEmployee.Location = New System.Drawing.Point(17, 143)
        Me.rbEmployee.Name = "rbEmployee"
        Me.rbEmployee.Size = New System.Drawing.Size(115, 24)
        Me.rbEmployee.TabIndex = 17
        Me.rbEmployee.TabStop = True
        Me.rbEmployee.Text = "EMPLOYEE"
        Me.rbEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbEmployee.UseVisualStyleBackColor = True
        '
        'rbStudent
        '
        Me.rbStudent.AutoSize = True
        Me.rbStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbStudent.Location = New System.Drawing.Point(17, 173)
        Me.rbStudent.Name = "rbStudent"
        Me.rbStudent.Size = New System.Drawing.Size(102, 24)
        Me.rbStudent.TabIndex = 18
        Me.rbStudent.TabStop = True
        Me.rbStudent.Text = "STUDENT"
        Me.rbStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbStudent.UseVisualStyleBackColor = True
        '
        'rbContractor
        '
        Me.rbContractor.AutoSize = True
        Me.rbContractor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbContractor.Location = New System.Drawing.Point(17, 203)
        Me.rbContractor.Name = "rbContractor"
        Me.rbContractor.Size = New System.Drawing.Size(145, 24)
        Me.rbContractor.TabIndex = 19
        Me.rbContractor.TabStop = True
        Me.rbContractor.Text = "CONTRACTUAL"
        Me.rbContractor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbContractor.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.Silver
        Me.txtRemarks.Location = New System.Drawing.Point(193, 143)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(595, 84)
        Me.txtRemarks.TabIndex = 21
        Me.txtRemarks.Text = "REMARKS"
        '
        'txtTask
        '
        Me.txtTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTask.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTask.ForeColor = System.Drawing.Color.Silver
        Me.txtTask.Location = New System.Drawing.Point(17, 233)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.Size = New System.Drawing.Size(771, 26)
        Me.txtTask.TabIndex = 22
        Me.txtTask.Text = "TASK"
        Me.txtTask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesignation
        '
        Me.txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesignation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesignation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesignation.ForeColor = System.Drawing.Color.Silver
        Me.txtDesignation.Location = New System.Drawing.Point(17, 111)
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(771, 26)
        Me.txtDesignation.TabIndex = 23
        Me.txtDesignation.Text = "DESIGNATION"
        Me.txtDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmPeopleManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtDesignation)
        Me.Controls.Add(Me.txtTask)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.rbContractor)
        Me.Controls.Add(Me.rbStudent)
        Me.Controls.Add(Me.rbEmployee)
        Me.Controls.Add(Me.pnlUsersRightBottom)
        Me.Controls.Add(Me.txtRFID)
        Me.Controls.Add(Me.cboDept)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtIDNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgPeople)
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "frmPeopleManagement"
        Me.Text = "frmPeopleManagement"
        CType(Me.dgPeople, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUsersRightBottom.ResumeLayout(False)
        Me.pnlUsersRightBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgPeople As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDNumber As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents cboDept As ComboBox
    Friend WithEvents txtRFID As TextBox
    Friend WithEvents pnlUsersRightBottom As Panel
    Friend WithEvents btnPMSearch As Button
    Friend WithEvents btnPMClose As Button
    Friend WithEvents btnPMDelete As Button
    Friend WithEvents btnPMAdd As Button
    Friend WithEvents btnPMSave As Button
    Friend WithEvents rbEmployee As RadioButton
    Friend WithEvents rbStudent As RadioButton
    Friend WithEvents rbContractor As RadioButton
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents txtTask As TextBox
    Friend WithEvents txtDesignation As TextBox
End Class

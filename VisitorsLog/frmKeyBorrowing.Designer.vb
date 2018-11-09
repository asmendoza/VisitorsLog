<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKeyBorrowing
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
        Me.dgBorrowedKeys = New System.Windows.Forms.DataGridView()
        Me.txtKeyID = New System.Windows.Forms.TextBox()
        Me.lblKeyDesc = New System.Windows.Forms.Label()
        Me.pnlBorrower = New System.Windows.Forms.Panel()
        Me.btnSaveBorrow = New System.Windows.Forms.Button()
        Me.lblBorrowerDept = New System.Windows.Forms.Label()
        Me.lblBorrowerName = New System.Windows.Forms.Label()
        Me.txtBorrowerID = New System.Windows.Forms.TextBox()
        CType(Me.dgBorrowedKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBorrower.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgBorrowedKeys
        '
        Me.dgBorrowedKeys.AllowUserToAddRows = False
        Me.dgBorrowedKeys.AllowUserToDeleteRows = False
        Me.dgBorrowedKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgBorrowedKeys.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgBorrowedKeys.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgBorrowedKeys.Location = New System.Drawing.Point(0, 175)
        Me.dgBorrowedKeys.Name = "dgBorrowedKeys"
        Me.dgBorrowedKeys.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBorrowedKeys.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgBorrowedKeys.Size = New System.Drawing.Size(544, 207)
        Me.dgBorrowedKeys.TabIndex = 0
        '
        'txtKeyID
        '
        Me.txtKeyID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyID.ForeColor = System.Drawing.Color.Silver
        Me.txtKeyID.Location = New System.Drawing.Point(192, 12)
        Me.txtKeyID.Name = "txtKeyID"
        Me.txtKeyID.Size = New System.Drawing.Size(160, 26)
        Me.txtKeyID.TabIndex = 1
        Me.txtKeyID.Text = "Key ID"
        '
        'lblKeyDesc
        '
        Me.lblKeyDesc.Location = New System.Drawing.Point(192, 41)
        Me.lblKeyDesc.Name = "lblKeyDesc"
        Me.lblKeyDesc.Size = New System.Drawing.Size(160, 19)
        Me.lblKeyDesc.TabIndex = 2
        Me.lblKeyDesc.Text = "Key Description"
        '
        'pnlBorrower
        '
        Me.pnlBorrower.Controls.Add(Me.btnSaveBorrow)
        Me.pnlBorrower.Controls.Add(Me.lblBorrowerDept)
        Me.pnlBorrower.Controls.Add(Me.lblBorrowerName)
        Me.pnlBorrower.Controls.Add(Me.txtBorrowerID)
        Me.pnlBorrower.Location = New System.Drawing.Point(119, 63)
        Me.pnlBorrower.Name = "pnlBorrower"
        Me.pnlBorrower.Size = New System.Drawing.Size(317, 106)
        Me.pnlBorrower.TabIndex = 3
        Me.pnlBorrower.Visible = False
        '
        'btnSaveBorrow
        '
        Me.btnSaveBorrow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveBorrow.Location = New System.Drawing.Point(123, 75)
        Me.btnSaveBorrow.Name = "btnSaveBorrow"
        Me.btnSaveBorrow.Size = New System.Drawing.Size(75, 27)
        Me.btnSaveBorrow.TabIndex = 6
        Me.btnSaveBorrow.Text = "Save"
        Me.btnSaveBorrow.UseVisualStyleBackColor = True
        '
        'lblBorrowerDept
        '
        Me.lblBorrowerDept.Location = New System.Drawing.Point(3, 51)
        Me.lblBorrowerDept.Name = "lblBorrowerDept"
        Me.lblBorrowerDept.Size = New System.Drawing.Size(311, 21)
        Me.lblBorrowerDept.TabIndex = 5
        Me.lblBorrowerDept.Text = "Department/Office"
        '
        'lblBorrowerName
        '
        Me.lblBorrowerName.Location = New System.Drawing.Point(3, 32)
        Me.lblBorrowerName.Name = "lblBorrowerName"
        Me.lblBorrowerName.Size = New System.Drawing.Size(311, 19)
        Me.lblBorrowerName.TabIndex = 4
        Me.lblBorrowerName.Text = "Name"
        '
        'txtBorrowerID
        '
        Me.txtBorrowerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBorrowerID.ForeColor = System.Drawing.Color.Silver
        Me.txtBorrowerID.Location = New System.Drawing.Point(3, 3)
        Me.txtBorrowerID.Name = "txtBorrowerID"
        Me.txtBorrowerID.Size = New System.Drawing.Size(311, 26)
        Me.txtBorrowerID.TabIndex = 3
        Me.txtBorrowerID.Text = "Borrower ID"
        '
        'frmKeyBorrowing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 382)
        Me.Controls.Add(Me.pnlBorrower)
        Me.Controls.Add(Me.lblKeyDesc)
        Me.Controls.Add(Me.txtKeyID)
        Me.Controls.Add(Me.dgBorrowedKeys)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 421)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 421)
        Me.Name = "frmKeyBorrowing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKeyBorrowing"
        CType(Me.dgBorrowedKeys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBorrower.ResumeLayout(False)
        Me.pnlBorrower.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgBorrowedKeys As DataGridView
    Friend WithEvents txtKeyID As TextBox
    Friend WithEvents lblKeyDesc As Label
    Friend WithEvents pnlBorrower As Panel
    Friend WithEvents btnSaveBorrow As Button
    Friend WithEvents lblBorrowerDept As Label
    Friend WithEvents lblBorrowerName As Label
    Friend WithEvents txtBorrowerID As TextBox
End Class

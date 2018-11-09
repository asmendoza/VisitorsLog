<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKeys
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKeyDesc = New System.Windows.Forms.TextBox()
        Me.txtKeyRFID = New System.Windows.Forms.TextBox()
        Me.lblKeyID = New System.Windows.Forms.Label()
        Me.dgBorrowedKeys = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.dgBorrowedKeys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Keys"
        '
        'txtKeyDesc
        '
        Me.txtKeyDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyDesc.ForeColor = System.Drawing.Color.Silver
        Me.txtKeyDesc.Location = New System.Drawing.Point(162, 77)
        Me.txtKeyDesc.Name = "txtKeyDesc"
        Me.txtKeyDesc.Size = New System.Drawing.Size(231, 26)
        Me.txtKeyDesc.TabIndex = 3
        Me.txtKeyDesc.Text = "Key Description"
        '
        'txtKeyRFID
        '
        Me.txtKeyRFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyRFID.ForeColor = System.Drawing.Color.Silver
        Me.txtKeyRFID.Location = New System.Drawing.Point(162, 109)
        Me.txtKeyRFID.Name = "txtKeyRFID"
        Me.txtKeyRFID.Size = New System.Drawing.Size(231, 26)
        Me.txtKeyRFID.TabIndex = 4
        Me.txtKeyRFID.Text = "Key RFID"
        '
        'lblKeyID
        '
        Me.lblKeyID.Location = New System.Drawing.Point(159, 59)
        Me.lblKeyID.Name = "lblKeyID"
        Me.lblKeyID.Size = New System.Drawing.Size(234, 15)
        Me.lblKeyID.TabIndex = 5
        Me.lblKeyID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgBorrowedKeys.Location = New System.Drawing.Point(0, 197)
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
        Me.dgBorrowedKeys.Size = New System.Drawing.Size(544, 185)
        Me.dgBorrowedKeys.TabIndex = 6
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(237, 141)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 27)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmKeys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(544, 382)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgBorrowedKeys)
        Me.Controls.Add(Me.lblKeyID)
        Me.Controls.Add(Me.txtKeyRFID)
        Me.Controls.Add(Me.txtKeyDesc)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(560, 421)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(560, 421)
        Me.Name = "frmKeys"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKeys"
        CType(Me.dgBorrowedKeys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtKeyDesc As TextBox
    Friend WithEvents txtKeyRFID As TextBox
    Friend WithEvents lblKeyID As Label
    Friend WithEvents dgBorrowedKeys As DataGridView
    Friend WithEvents btnSave As Button
End Class

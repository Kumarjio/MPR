<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Freeze_ClosingStock
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFormHeading = New System.Windows.Forms.Label()
        Me.dtpMRSTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpMRSFrom = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdclstklist = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSelectAll = New System.Windows.Forms.Button()
        Me.btnDeselectAll = New System.Windows.Forms.Button()
        Me.btInverseSelect = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdclstklist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblFormHeading)
        Me.GroupBox1.Controls.Add(Me.dtpMRSTo)
        Me.GroupBox1.Controls.Add(Me.dtpMRSFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(894, 108)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnShow
        '
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(448, 38)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(127, 31)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(236, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "To :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From :"
        '
        'lblFormHeading
        '
        Me.lblFormHeading.AutoSize = True
        Me.lblFormHeading.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormHeading.ForeColor = System.Drawing.Color.White
        Me.lblFormHeading.Location = New System.Drawing.Point(646, 9)
        Me.lblFormHeading.Name = "lblFormHeading"
        Me.lblFormHeading.Size = New System.Drawing.Size(244, 25)
        Me.lblFormHeading.TabIndex = 3
        Me.lblFormHeading.Text = "Freeze Closing Stock"
        '
        'dtpMRSTo
        '
        Me.dtpMRSTo.CalendarForeColor = System.Drawing.Color.White
        Me.dtpMRSTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpMRSTo.CustomFormat = "dd-MMM-yyyy"
        Me.dtpMRSTo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMRSTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMRSTo.Location = New System.Drawing.Point(281, 43)
        Me.dtpMRSTo.Name = "dtpMRSTo"
        Me.dtpMRSTo.Size = New System.Drawing.Size(134, 21)
        Me.dtpMRSTo.TabIndex = 1
        '
        'dtpMRSFrom
        '
        Me.dtpMRSFrom.CalendarForeColor = System.Drawing.Color.White
        Me.dtpMRSFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpMRSFrom.CustomFormat = "dd-MMM-yyyy"
        Me.dtpMRSFrom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpMRSFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMRSFrom.Location = New System.Drawing.Point(70, 43)
        Me.dtpMRSFrom.Name = "dtpMRSFrom"
        Me.dtpMRSFrom.Size = New System.Drawing.Size(134, 21)
        Me.dtpMRSFrom.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grdclstklist)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(894, 448)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'grdclstklist
        '
        Me.grdclstklist.AllowUserToAddRows = False
        Me.grdclstklist.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grdclstklist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdclstklist.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grdclstklist.Location = New System.Drawing.Point(6, 13)
        Me.grdclstklist.Name = "grdclstklist"
        Me.grdclstklist.RowHeadersVisible = False
        Me.grdclstklist.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.grdclstklist.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdclstklist.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.grdclstklist.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange
        Me.grdclstklist.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.grdclstklist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdclstklist.Size = New System.Drawing.Size(882, 428)
        Me.grdclstklist.TabIndex = 0
        '
        'btnUpdate
        '
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(337, 576)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(135, 31)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSelectAll
        '
        Me.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectAll.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectAll.ForeColor = System.Drawing.Color.White
        Me.btnSelectAll.Location = New System.Drawing.Point(478, 576)
        Me.btnSelectAll.Name = "btnSelectAll"
        Me.btnSelectAll.Size = New System.Drawing.Size(135, 31)
        Me.btnSelectAll.TabIndex = 2
        Me.btnSelectAll.Text = "Select All"
        Me.btnSelectAll.UseVisualStyleBackColor = True
        '
        'btnDeselectAll
        '
        Me.btnDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeselectAll.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeselectAll.ForeColor = System.Drawing.Color.White
        Me.btnDeselectAll.Location = New System.Drawing.Point(619, 576)
        Me.btnDeselectAll.Name = "btnDeselectAll"
        Me.btnDeselectAll.Size = New System.Drawing.Size(135, 31)
        Me.btnDeselectAll.TabIndex = 2
        Me.btnDeselectAll.Text = "Deselect All"
        Me.btnDeselectAll.UseVisualStyleBackColor = True
        '
        'btInverseSelect
        '
        Me.btInverseSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btInverseSelect.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInverseSelect.ForeColor = System.Drawing.Color.White
        Me.btInverseSelect.Location = New System.Drawing.Point(760, 576)
        Me.btInverseSelect.Name = "btInverseSelect"
        Me.btInverseSelect.Size = New System.Drawing.Size(135, 31)
        Me.btInverseSelect.TabIndex = 2
        Me.btInverseSelect.Text = "Inverse Select"
        Me.btInverseSelect.UseVisualStyleBackColor = True
        '
        'frm_Freeze_ClosingStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.btInverseSelect)
        Me.Controls.Add(Me.btnDeselectAll)
        Me.Controls.Add(Me.btnSelectAll)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_Freeze_ClosingStock"
        Me.Size = New System.Drawing.Size(910, 630)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdclstklist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpMRSTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMRSFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grdclstklist As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSelectAll As System.Windows.Forms.Button
    Friend WithEvents btnDeselectAll As System.Windows.Forms.Button
    Friend WithEvents btInverseSelect As System.Windows.Forms.Button
    Friend WithEvents lblFormHeading As System.Windows.Forms.Label

End Class

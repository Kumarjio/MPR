﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DebtorsOS
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtDateSearch = New System.Windows.Forms.DateTimePicker()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblFormHeading = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblFormHeading)
        Me.GroupBox6.Controls.Add(Me.txtDateSearch)
        Me.GroupBox6.Controls.Add(Me.btnShow)
        Me.GroupBox6.Controls.Add(Me.cmbSupplier)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(9, 27)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(890, 211)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        '
        'txtDateSearch
        '
        Me.txtDateSearch.CalendarForeColor = System.Drawing.Color.White
        Me.txtDateSearch.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDateSearch.CustomFormat = "dd-MMM-yyyy"
        Me.txtDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateSearch.Location = New System.Drawing.Point(143, 124)
        Me.txtDateSearch.Name = "txtDateSearch"
        Me.txtDateSearch.Size = New System.Drawing.Size(142, 20)
        Me.txtDateSearch.TabIndex = 9
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(666, 124)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(185, 27)
        Me.btnShow.TabIndex = 8
        Me.btnShow.Text = "SHOW CUSTOMER O/S"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'cmbSupplier
        '
        Me.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbSupplier.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.ForeColor = System.Drawing.Color.White
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(143, 76)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(708, 25)
        Me.cmbSupplier.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(32, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Date:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(32, 81)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Select Customer :"
        '
        'lblFormHeading
        '
        Me.lblFormHeading.AutoSize = True
        Me.lblFormHeading.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormHeading.ForeColor = System.Drawing.Color.White
        Me.lblFormHeading.Location = New System.Drawing.Point(615, 25)
        Me.lblFormHeading.Name = "lblFormHeading"
        Me.lblFormHeading.Size = New System.Drawing.Size(245, 25)
        Me.lblFormHeading.TabIndex = 43
        Me.lblFormHeading.Text = "Debtors Outstanding"
        '
        'frm_DebtorsOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "frm_DebtorsOS"
        Me.Size = New System.Drawing.Size(910, 630)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents txtDateSearch As DateTimePicker
    Friend WithEvents btnShow As Button
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblFormHeading As Label
End Class

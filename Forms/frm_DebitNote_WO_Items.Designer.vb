<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_DebitNote_WO_Items
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DebitNote_WO_Items))
        Me.TbRMRN = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBRMWPM = New System.Windows.Forms.GroupBox()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TaxDetails = New System.Windows.Forms.GroupBox()
        Me.lblTotalTaxAmt = New System.Windows.Forms.Label()
        Me.txt28Per = New System.Windows.Forms.TextBox()
        Me.lbl28Per = New System.Windows.Forms.Label()
        Me.txt18Per = New System.Windows.Forms.TextBox()
        Me.lbl18Per = New System.Windows.Forms.Label()
        Me.txt12Per = New System.Windows.Forms.TextBox()
        Me.lbl12Per = New System.Windows.Forms.Label()
        Me.txt5Per = New System.Windows.Forms.TextBox()
        Me.lbl5Per = New System.Windows.Forms.Label()
        Me.txt3Per = New System.Windows.Forms.TextBox()
        Me.lbl3Per = New System.Windows.Forms.Label()
        Me.lblTaxAmt = New System.Windows.Forms.Label()
        Me.txtDebitAmt = New System.Windows.Forms.TextBox()
        Me.lblDebitAmt = New System.Windows.Forms.Label()
        Me.dtpRefDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRefDate = New System.Windows.Forms.Label()
        Me.txtRefNo = New System.Windows.Forms.TextBox()
        Me.lblRefNo = New System.Windows.Forms.Label()
        Me.lblAddressText = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.cmbsupplier = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_DNDate = New System.Windows.Forms.Label()
        Me.lblDN_Code = New System.Windows.Forms.Label()
        Me.lblReverseCode = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lbl_Remarks = New System.Windows.Forms.Label()
        Me.lblReceivedDate = New System.Windows.Forms.Label()
        Me.lblFormHeading = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.C1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TbRMRN.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GBRMWPM.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TaxDetails.SuspendLayout()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbRMRN
        '
        Me.TbRMRN.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TbRMRN.Controls.Add(Me.TabPage1)
        Me.TbRMRN.Controls.Add(Me.TabPage2)
        Me.TbRMRN.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TbRMRN.ImageList = Me.ImageList1
        Me.TbRMRN.Location = New System.Drawing.Point(0, 0)
        Me.TbRMRN.Name = "TbRMRN"
        Me.TbRMRN.SelectedIndex = 0
        Me.TbRMRN.Size = New System.Drawing.Size(910, 630)
        Me.TbRMRN.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DimGray
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GBRMWPM)
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(902, 600)
        Me.TabPage1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(864, 76)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.White
        Me.txtSearch.Location = New System.Drawing.Point(89, 32)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(741, 18)
        Me.txtSearch.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Search By :"
        '
        'GBRMWPM
        '
        Me.GBRMWPM.Controls.Add(Me.dgvList)
        Me.GBRMWPM.ForeColor = System.Drawing.Color.White
        Me.GBRMWPM.Location = New System.Drawing.Point(17, 108)
        Me.GBRMWPM.Name = "GBRMWPM"
        Me.GBRMWPM.Size = New System.Drawing.Size(867, 471)
        Me.GBRMWPM.TabIndex = 0
        Me.GBRMWPM.TabStop = False
        Me.GBRMWPM.Text = "List of Debit Notes"
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.AllowUserToResizeColumns = False
        Me.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvList.GridColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvList.Location = New System.Drawing.Point(3, 16)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowHeadersVisible = False
        Me.dgvList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvList.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White
        Me.dgvList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOrange
        Me.dgvList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(861, 452)
        Me.dgvList.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DimGray
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.ForeColor = System.Drawing.Color.White
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(902, 600)
        Me.TabPage2.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TaxDetails)
        Me.GroupBox1.Controls.Add(Me.txtDebitAmt)
        Me.GroupBox1.Controls.Add(Me.lblDebitAmt)
        Me.GroupBox1.Controls.Add(Me.dtpRefDate)
        Me.GroupBox1.Controls.Add(Me.lblRefDate)
        Me.GroupBox1.Controls.Add(Me.txtRefNo)
        Me.GroupBox1.Controls.Add(Me.lblRefNo)
        Me.GroupBox1.Controls.Add(Me.lblAddressText)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.cmbsupplier)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl_DNDate)
        Me.GroupBox1.Controls.Add(Me.lblDN_Code)
        Me.GroupBox1.Controls.Add(Me.lblReverseCode)
        Me.GroupBox1.Controls.Add(Me.txtRemarks)
        Me.GroupBox1.Controls.Add(Me.lbl_Remarks)
        Me.GroupBox1.Controls.Add(Me.lblReceivedDate)
        Me.GroupBox1.Controls.Add(Me.lblFormHeading)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 574)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Debit Note Detail"
        '
        'TaxDetails
        '
        Me.TaxDetails.Controls.Add(Me.lblTotalTaxAmt)
        Me.TaxDetails.Controls.Add(Me.txt28Per)
        Me.TaxDetails.Controls.Add(Me.lbl28Per)
        Me.TaxDetails.Controls.Add(Me.txt18Per)
        Me.TaxDetails.Controls.Add(Me.lbl18Per)
        Me.TaxDetails.Controls.Add(Me.txt12Per)
        Me.TaxDetails.Controls.Add(Me.lbl12Per)
        Me.TaxDetails.Controls.Add(Me.txt5Per)
        Me.TaxDetails.Controls.Add(Me.lbl5Per)
        Me.TaxDetails.Controls.Add(Me.txt3Per)
        Me.TaxDetails.Controls.Add(Me.lbl3Per)
        Me.TaxDetails.Controls.Add(Me.lblTaxAmt)
        Me.TaxDetails.Location = New System.Drawing.Point(12, 395)
        Me.TaxDetails.Name = "TaxDetails"
        Me.TaxDetails.Size = New System.Drawing.Size(872, 173)
        Me.TaxDetails.TabIndex = 266
        Me.TaxDetails.TabStop = False
        Me.TaxDetails.Text = "Tax Details"
        '
        'lblTotalTaxAmt
        '
        Me.lblTotalTaxAmt.AutoSize = True
        Me.lblTotalTaxAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTaxAmt.Location = New System.Drawing.Point(141, 74)
        Me.lblTotalTaxAmt.Name = "lblTotalTaxAmt"
        Me.lblTotalTaxAmt.Size = New System.Drawing.Size(32, 13)
        Me.lblTotalTaxAmt.TabIndex = 276
        Me.lblTotalTaxAmt.Text = "0.00"
        '
        'txt28Per
        '
        Me.txt28Per.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt28Per.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt28Per.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt28Per.ForeColor = System.Drawing.Color.White
        Me.txt28Per.Location = New System.Drawing.Point(733, 32)
        Me.txt28Per.MaxLength = 0
        Me.txt28Per.Name = "txt28Per"
        Me.txt28Per.Size = New System.Drawing.Size(101, 19)
        Me.txt28Per.TabIndex = 275
        '
        'lbl28Per
        '
        Me.lbl28Per.AutoSize = True
        Me.lbl28Per.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl28Per.Location = New System.Drawing.Point(692, 33)
        Me.lbl28Per.Name = "lbl28Per"
        Me.lbl28Per.Size = New System.Drawing.Size(35, 15)
        Me.lbl28Per.TabIndex = 274
        Me.lbl28Per.Text = "28% "
        '
        'txt18Per
        '
        Me.txt18Per.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt18Per.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt18Per.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt18Per.ForeColor = System.Drawing.Color.White
        Me.txt18Per.Location = New System.Drawing.Point(570, 32)
        Me.txt18Per.MaxLength = 0
        Me.txt18Per.Name = "txt18Per"
        Me.txt18Per.Size = New System.Drawing.Size(101, 19)
        Me.txt18Per.TabIndex = 273
        '
        'lbl18Per
        '
        Me.lbl18Per.AutoSize = True
        Me.lbl18Per.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl18Per.Location = New System.Drawing.Point(534, 35)
        Me.lbl18Per.Name = "lbl18Per"
        Me.lbl18Per.Size = New System.Drawing.Size(35, 15)
        Me.lbl18Per.TabIndex = 272
        Me.lbl18Per.Text = "18% "
        '
        'txt12Per
        '
        Me.txt12Per.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt12Per.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt12Per.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt12Per.ForeColor = System.Drawing.Color.White
        Me.txt12Per.Location = New System.Drawing.Point(414, 31)
        Me.txt12Per.MaxLength = 0
        Me.txt12Per.Name = "txt12Per"
        Me.txt12Per.Size = New System.Drawing.Size(101, 19)
        Me.txt12Per.TabIndex = 271
        '
        'lbl12Per
        '
        Me.lbl12Per.AutoSize = True
        Me.lbl12Per.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl12Per.Location = New System.Drawing.Point(373, 31)
        Me.lbl12Per.Name = "lbl12Per"
        Me.lbl12Per.Size = New System.Drawing.Size(35, 15)
        Me.lbl12Per.TabIndex = 270
        Me.lbl12Per.Text = "12% "
        '
        'txt5Per
        '
        Me.txt5Per.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt5Per.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt5Per.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5Per.ForeColor = System.Drawing.Color.White
        Me.txt5Per.Location = New System.Drawing.Point(269, 31)
        Me.txt5Per.MaxLength = 0
        Me.txt5Per.Name = "txt5Per"
        Me.txt5Per.Size = New System.Drawing.Size(101, 19)
        Me.txt5Per.TabIndex = 269
        '
        'lbl5Per
        '
        Me.lbl5Per.AutoSize = True
        Me.lbl5Per.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5Per.Location = New System.Drawing.Point(244, 31)
        Me.lbl5Per.Name = "lbl5Per"
        Me.lbl5Per.Size = New System.Drawing.Size(28, 15)
        Me.lbl5Per.TabIndex = 268
        Me.lbl5Per.Text = "5% "
        '
        'txt3Per
        '
        Me.txt3Per.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt3Per.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt3Per.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt3Per.ForeColor = System.Drawing.Color.White
        Me.txt3Per.Location = New System.Drawing.Point(131, 32)
        Me.txt3Per.MaxLength = 0
        Me.txt3Per.Name = "txt3Per"
        Me.txt3Per.Size = New System.Drawing.Size(101, 19)
        Me.txt3Per.TabIndex = 267
        '
        'lbl3Per
        '
        Me.lbl3Per.AutoSize = True
        Me.lbl3Per.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3Per.Location = New System.Drawing.Point(107, 33)
        Me.lbl3Per.Name = "lbl3Per"
        Me.lbl3Per.Size = New System.Drawing.Size(28, 15)
        Me.lbl3Per.TabIndex = 266
        Me.lbl3Per.Text = "3% "
        '
        'lblTaxAmt
        '
        Me.lblTaxAmt.AutoSize = True
        Me.lblTaxAmt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxAmt.Location = New System.Drawing.Point(22, 72)
        Me.lblTaxAmt.Name = "lblTaxAmt"
        Me.lblTaxAmt.Size = New System.Drawing.Size(104, 15)
        Me.lblTaxAmt.TabIndex = 264
        Me.lblTaxAmt.Text = "Total Tax Amount :"
        '
        'txtDebitAmt
        '
        Me.txtDebitAmt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDebitAmt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDebitAmt.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDebitAmt.ForeColor = System.Drawing.Color.White
        Me.txtDebitAmt.Location = New System.Drawing.Point(145, 349)
        Me.txtDebitAmt.MaxLength = 0
        Me.txtDebitAmt.Name = "txtDebitAmt"
        Me.txtDebitAmt.Size = New System.Drawing.Size(572, 19)
        Me.txtDebitAmt.TabIndex = 263
        '
        'lblDebitAmt
        '
        Me.lblDebitAmt.AutoSize = True
        Me.lblDebitAmt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebitAmt.Location = New System.Drawing.Point(25, 349)
        Me.lblDebitAmt.Name = "lblDebitAmt"
        Me.lblDebitAmt.Size = New System.Drawing.Size(86, 15)
        Me.lblDebitAmt.TabIndex = 262
        Me.lblDebitAmt.Text = "Debit Amount :"
        '
        'dtpRefDate
        '
        Me.dtpRefDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpRefDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpRefDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpRefDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpRefDate.Location = New System.Drawing.Point(512, 115)
        Me.dtpRefDate.Name = "dtpRefDate"
        Me.dtpRefDate.Size = New System.Drawing.Size(205, 20)
        Me.dtpRefDate.TabIndex = 261
        '
        'lblRefDate
        '
        Me.lblRefDate.AutoSize = True
        Me.lblRefDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefDate.Location = New System.Drawing.Point(407, 116)
        Me.lblRefDate.Name = "lblRefDate"
        Me.lblRefDate.Size = New System.Drawing.Size(99, 15)
        Me.lblRefDate.TabIndex = 260
        Me.lblRefDate.Text = "Reference Date :"
        '
        'txtRefNo
        '
        Me.txtRefNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRefNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRefNo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefNo.ForeColor = System.Drawing.Color.White
        Me.txtRefNo.Location = New System.Drawing.Point(145, 116)
        Me.txtRefNo.MaxLength = 0
        Me.txtRefNo.Name = "txtRefNo"
        Me.txtRefNo.Size = New System.Drawing.Size(222, 19)
        Me.txtRefNo.TabIndex = 259
        '
        'lblRefNo
        '
        Me.lblRefNo.AutoSize = True
        Me.lblRefNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefNo.Location = New System.Drawing.Point(28, 120)
        Me.lblRefNo.Name = "lblRefNo"
        Me.lblRefNo.Size = New System.Drawing.Size(89, 15)
        Me.lblRefNo.TabIndex = 258
        Me.lblRefNo.Text = "Reference No :"
        '
        'lblAddressText
        '
        Me.lblAddressText.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddressText.ForeColor = System.Drawing.Color.White
        Me.lblAddressText.Location = New System.Drawing.Point(147, 81)
        Me.lblAddressText.Name = "lblAddressText"
        Me.lblAddressText.Size = New System.Drawing.Size(570, 24)
        Me.lblAddressText.TabIndex = 257
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(28, 85)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(101, 15)
        Me.lblAddress.TabIndex = 50
        Me.lblAddress.Text = "Address Details :"
        '
        'cmbsupplier
        '
        Me.cmbsupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbsupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsupplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsupplier.ForeColor = System.Drawing.Color.White
        Me.cmbsupplier.FormattingEnabled = True
        Me.cmbsupplier.Location = New System.Drawing.Point(145, 50)
        Me.cmbsupplier.Name = "cmbsupplier"
        Me.cmbsupplier.Size = New System.Drawing.Size(572, 23)
        Me.cmbsupplier.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Select Supplier :"
        '
        'lbl_DNDate
        '
        Me.lbl_DNDate.AutoSize = True
        Me.lbl_DNDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DNDate.Location = New System.Drawing.Point(298, 17)
        Me.lbl_DNDate.Name = "lbl_DNDate"
        Me.lbl_DNDate.Size = New System.Drawing.Size(84, 13)
        Me.lbl_DNDate.TabIndex = 26
        Me.lbl_DNDate.Text = "Debit Note Date"
        '
        'lblDN_Code
        '
        Me.lblDN_Code.AutoSize = True
        Me.lblDN_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDN_Code.Location = New System.Drawing.Point(82, 18)
        Me.lblDN_Code.Name = "lblDN_Code"
        Me.lblDN_Code.Size = New System.Drawing.Size(86, 13)
        Me.lblDN_Code.TabIndex = 16
        Me.lblDN_Code.Text = "Debit Note Code"
        '
        'lblReverseCode
        '
        Me.lblReverseCode.AutoSize = True
        Me.lblReverseCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReverseCode.Location = New System.Drawing.Point(28, 16)
        Me.lblReverseCode.Name = "lblReverseCode"
        Me.lblReverseCode.Size = New System.Drawing.Size(50, 15)
        Me.lblReverseCode.TabIndex = 15
        Me.lblReverseCode.Text = "DN No :"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRemarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRemarks.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.ForeColor = System.Drawing.Color.White
        Me.txtRemarks.Location = New System.Drawing.Point(145, 166)
        Me.txtRemarks.MaxLength = 500
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(572, 163)
        Me.txtRemarks.TabIndex = 14
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(28, 168)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(64, 15)
        Me.lbl_Remarks.TabIndex = 13
        Me.lbl_Remarks.Text = "Remarks :"
        '
        'lblReceivedDate
        '
        Me.lblReceivedDate.AutoSize = True
        Me.lblReceivedDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceivedDate.Location = New System.Drawing.Point(207, 15)
        Me.lblReceivedDate.Name = "lblReceivedDate"
        Me.lblReceivedDate.Size = New System.Drawing.Size(63, 15)
        Me.lblReceivedDate.TabIndex = 11
        Me.lblReceivedDate.Text = "DN  Date :"
        '
        'lblFormHeading
        '
        Me.lblFormHeading.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormHeading.ForeColor = System.Drawing.Color.White
        Me.lblFormHeading.Location = New System.Drawing.Point(737, 15)
        Me.lblFormHeading.Name = "lblFormHeading"
        Me.lblFormHeading.Size = New System.Drawing.Size(147, 102)
        Me.lblFormHeading.TabIndex = 10
        Me.lblFormHeading.Text = "Debit Note WithOut Items"
        Me.lblFormHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Zoom_search_find_magnifying_glass.png")
        Me.ImageList1.Images.SetKeyName(1, "Inventory_box_shipment_product.png")
        '
        'C1FlexGrid1
        '
        Me.C1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me.C1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1FlexGrid1.Name = "C1FlexGrid1"
        Me.C1FlexGrid1.Rows.DefaultSize = 17
        Me.C1FlexGrid1.Size = New System.Drawing.Size(0, 0)
        Me.C1FlexGrid1.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("C1FlexGrid1.Styles"))
        Me.C1FlexGrid1.TabIndex = 0
        '
        'frm_DebitNote_WO_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.TbRMRN)
        Me.Name = "frm_DebitNote_WO_Items"
        Me.Size = New System.Drawing.Size(910, 630)
        Me.TbRMRN.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GBRMWPM.ResumeLayout(False)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TaxDetails.ResumeLayout(False)
        Me.TaxDetails.PerformLayout()
        CType(Me.C1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TbRMRN As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFormHeading As System.Windows.Forms.Label
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents lblReceivedDate As System.Windows.Forms.Label
    Friend WithEvents lblDN_Code As System.Windows.Forms.Label
    Friend WithEvents lblReverseCode As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents GBRMWPM As System.Windows.Forms.GroupBox
    Friend WithEvents C1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents lbl_DNDate As System.Windows.Forms.Label
    Friend WithEvents dgvList As System.Windows.Forms.DataGridView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbsupplier As System.Windows.Forms.ComboBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblAddressText As Label
    Friend WithEvents lblRefNo As Label
    Friend WithEvents txtRefNo As TextBox
    Friend WithEvents lblRefDate As Label
    Friend WithEvents dtpRefDate As DateTimePicker
    Friend WithEvents lblDebitAmt As Label
    Friend WithEvents txtDebitAmt As TextBox
    Friend WithEvents lblTaxAmt As Label
    Friend WithEvents TaxDetails As GroupBox
    Friend WithEvents txt3Per As TextBox
    Friend WithEvents lbl3Per As Label
    Friend WithEvents lbl5Per As Label
    Friend WithEvents txt12Per As TextBox
    Friend WithEvents lbl12Per As Label
    Friend WithEvents txt5Per As TextBox
    Friend WithEvents txt28Per As TextBox
    Friend WithEvents lbl28Per As Label
    Friend WithEvents txt18Per As TextBox
    Friend WithEvents lbl18Per As Label
    Friend WithEvents lblTotalTaxAmt As Label
End Class

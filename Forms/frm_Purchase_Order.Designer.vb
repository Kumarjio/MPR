<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Purchase_Order
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Purchase_Order))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.flxPOList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPoStatus = New System.Windows.Forms.Label()
        Me.cmdPoStatus = New System.Windows.Forms.ComboBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.txtPONumber = New System.Windows.Forms.TextBox()
        Me.dtpoToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpoFromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbFilterSupp = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpTransMode = New System.Windows.Forms.ComboBox()
        Me.dtpPriceBasis = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFreight = New System.Windows.Forms.ComboBox()
        Me.dtpOctroi = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtOtherCharges = New System.Windows.Forms.TextBox()
        Me.txtDiscountAmount = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPaymentTerms = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lnkSelectItemswithoutIndent = New System.Windows.Forms.LinkLabel()
        Me.flxItemList = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.lnkCalculatePOAmt = New System.Windows.Forms.LinkLabel()
        Me.lnkSelectItems = New System.Windows.Forms.LinkLabel()
        Me.txtPORemarks = New System.Windows.Forms.TextBox()
        Me.cmbDeliveryRate = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_VatCal = New System.Windows.Forms.CheckBox()
        Me.txtPOPrefix = New System.Windows.Forms.TextBox()
        Me.txtPONO = New System.Windows.Forms.TextBox()
        Me.CHK_OPEN_PO_QTY = New System.Windows.Forms.CheckBox()
        Me.lblFormHeading = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpPODate = New System.Windows.Forms.DateTimePicker()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.cmbPOType = New System.Windows.Forms.ComboBox()
        Me.lblCap8 = New System.Windows.Forms.Label()
        Me.lblCap7 = New System.Windows.Forms.Label()
        Me.lblCap4 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCap = New System.Windows.Forms.Label()
        Me.lblCap2 = New System.Windows.Forms.Label()
        Me.lblCap1 = New System.Windows.Forms.Label()
        Me.cmbQualityRate = New System.Windows.Forms.ComboBox()
        Me.lblNetAmount = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblVatAmount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblItemValue = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCap6 = New System.Windows.Forms.Label()
        Me.lblCap9 = New System.Windows.Forms.Label()
        Me.lblCap5 = New System.Windows.Forms.Label()
        Me.lblCap10 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.erp = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtBarcodeSearch = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.flxPOList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.flxItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(910, 630)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DimGray
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(902, 600)
        Me.TabPage1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.flxPOList)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(6, 117)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(890, 477)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "List of Purchase Order"
        '
        'flxPOList
        '
        Me.flxPOList.BackColor = System.Drawing.Color.Silver
        Me.flxPOList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
        Me.flxPOList.ColumnInfo = "10,1,0,0,0,90,Columns:"
        Me.flxPOList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flxPOList.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.flxPOList.Location = New System.Drawing.Point(3, 17)
        Me.flxPOList.Name = "flxPOList"
        Me.flxPOList.Rows.DefaultSize = 18
        Me.flxPOList.Size = New System.Drawing.Size(884, 457)
        Me.flxPOList.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("flxPOList.Styles"))
        Me.flxPOList.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblPoStatus)
        Me.GroupBox3.Controls.Add(Me.cmdPoStatus)
        Me.GroupBox3.Controls.Add(Me.btnShow)
        Me.GroupBox3.Controls.Add(Me.txtPONumber)
        Me.GroupBox3.Controls.Add(Me.dtpoToDate)
        Me.GroupBox3.Controls.Add(Me.dtpoFromDate)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.cmbFilterSupp)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(890, 105)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Options"
        '
        'lblPoStatus
        '
        Me.lblPoStatus.AutoSize = True
        Me.lblPoStatus.Location = New System.Drawing.Point(449, 71)
        Me.lblPoStatus.Name = "lblPoStatus"
        Me.lblPoStatus.Size = New System.Drawing.Size(68, 15)
        Me.lblPoStatus.TabIndex = 6
        Me.lblPoStatus.Text = "PO Status :"
        '
        'cmdPoStatus
        '
        Me.cmdPoStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPoStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPoStatus.ForeColor = System.Drawing.Color.White
        Me.cmdPoStatus.FormattingEnabled = True
        Me.cmdPoStatus.Location = New System.Drawing.Point(530, 65)
        Me.cmdPoStatus.Name = "cmdPoStatus"
        Me.cmdPoStatus.Size = New System.Drawing.Size(193, 23)
        Me.cmdPoStatus.TabIndex = 5
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(776, 55)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(97, 33)
        Me.btnShow.TabIndex = 4
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'txtPONumber
        '
        Me.txtPONumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPONumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPONumber.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPONumber.ForeColor = System.Drawing.Color.White
        Me.txtPONumber.Location = New System.Drawing.Point(529, 27)
        Me.txtPONumber.Name = "txtPONumber"
        Me.txtPONumber.Size = New System.Drawing.Size(194, 18)
        Me.txtPONumber.TabIndex = 3
        '
        'dtpoToDate
        '
        Me.dtpoToDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpoToDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpoToDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpoToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpoToDate.Location = New System.Drawing.Point(312, 63)
        Me.dtpoToDate.Name = "dtpoToDate"
        Me.dtpoToDate.Size = New System.Drawing.Size(119, 21)
        Me.dtpoToDate.TabIndex = 2
        '
        'dtpoFromDate
        '
        Me.dtpoFromDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpoFromDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpoFromDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpoFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpoFromDate.Location = New System.Drawing.Point(112, 64)
        Me.dtpoFromDate.Name = "dtpoFromDate"
        Me.dtpoFromDate.Size = New System.Drawing.Size(113, 21)
        Me.dtpoFromDate.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(237, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "PO Date To"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "PO Date from :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(449, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "PO No. :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Supplier :"
        '
        'cmbFilterSupp
        '
        Me.cmbFilterSupp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbFilterSupp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFilterSupp.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFilterSupp.ForeColor = System.Drawing.Color.White
        Me.cmbFilterSupp.FormattingEnabled = True
        Me.cmbFilterSupp.Location = New System.Drawing.Point(112, 24)
        Me.cmbFilterSupp.Name = "cmbFilterSupp"
        Me.cmbFilterSupp.Size = New System.Drawing.Size(319, 25)
        Me.cmbFilterSupp.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DimGray
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.dtpTransMode)
        Me.TabPage2.Controls.Add(Me.dtpPriceBasis)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.dtpFreight)
        Me.TabPage2.Controls.Add(Me.dtpOctroi)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Panel5)
        Me.TabPage2.Controls.Add(Me.Panel4)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Controls.Add(Me.txtOtherCharges)
        Me.TabPage2.Controls.Add(Me.txtDiscountAmount)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.txtPaymentTerms)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.txtPORemarks)
        Me.TabPage2.Controls.Add(Me.cmbDeliveryRate)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.cmbQualityRate)
        Me.TabPage2.Controls.Add(Me.lblNetAmount)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.lblVatAmount)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.lblItemValue)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.lblCap6)
        Me.TabPage2.Controls.Add(Me.lblCap9)
        Me.TabPage2.Controls.Add(Me.lblCap5)
        Me.TabPage2.Controls.Add(Me.lblCap10)
        Me.TabPage2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.ForeColor = System.Drawing.Color.White
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(902, 600)
        Me.TabPage2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 452)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 15)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Transport Mode :"
        '
        'dtpTransMode
        '
        Me.dtpTransMode.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpTransMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dtpTransMode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransMode.ForeColor = System.Drawing.Color.White
        Me.dtpTransMode.FormattingEnabled = True
        Me.dtpTransMode.Items.AddRange(New Object() {"On Party behalf", "On Ourbehalf"})
        Me.dtpTransMode.Location = New System.Drawing.Point(123, 448)
        Me.dtpTransMode.Name = "dtpTransMode"
        Me.dtpTransMode.Size = New System.Drawing.Size(166, 23)
        Me.dtpTransMode.TabIndex = 37
        '
        'dtpPriceBasis
        '
        Me.dtpPriceBasis.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpPriceBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dtpPriceBasis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPriceBasis.ForeColor = System.Drawing.Color.White
        Me.dtpPriceBasis.FormattingEnabled = True
        Me.dtpPriceBasis.Items.AddRange(New Object() {"Ex-works,Godown", "F.O.R Destination"})
        Me.dtpPriceBasis.Location = New System.Drawing.Point(387, 449)
        Me.dtpPriceBasis.Name = "dtpPriceBasis"
        Me.dtpPriceBasis.Size = New System.Drawing.Size(162, 23)
        Me.dtpPriceBasis.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(298, 454)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Price Basis :"
        '
        'dtpFreight
        '
        Me.dtpFreight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpFreight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dtpFreight.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFreight.ForeColor = System.Drawing.Color.White
        Me.dtpFreight.FormattingEnabled = True
        Me.dtpFreight.Items.AddRange(New Object() {"By Us", "By You"})
        Me.dtpFreight.Location = New System.Drawing.Point(387, 418)
        Me.dtpFreight.Name = "dtpFreight"
        Me.dtpFreight.Size = New System.Drawing.Size(162, 23)
        Me.dtpFreight.TabIndex = 36
        '
        'dtpOctroi
        '
        Me.dtpOctroi.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpOctroi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dtpOctroi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOctroi.ForeColor = System.Drawing.Color.White
        Me.dtpOctroi.FormattingEnabled = True
        Me.dtpOctroi.Items.AddRange(New Object() {"By Us", "By You"})
        Me.dtpOctroi.Location = New System.Drawing.Point(123, 417)
        Me.dtpOctroi.Name = "dtpOctroi"
        Me.dtpOctroi.Size = New System.Drawing.Size(166, 23)
        Me.dtpOctroi.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(298, 421)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Freight :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 421)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 15)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Octroi :"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Location = New System.Drawing.Point(722, 466)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(117, 1)
        Me.Panel6.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Location = New System.Drawing.Point(722, 497)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(117, 1)
        Me.Panel5.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Location = New System.Drawing.Point(722, 436)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(117, 1)
        Me.Panel4.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Location = New System.Drawing.Point(722, 408)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(117, 1)
        Me.Panel3.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(722, 377)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(117, 1)
        Me.Panel2.TabIndex = 13
        '
        'txtOtherCharges
        '
        Me.txtOtherCharges.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOtherCharges.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtherCharges.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherCharges.ForeColor = System.Drawing.Color.White
        Me.txtOtherCharges.Location = New System.Drawing.Point(760, 442)
        Me.txtOtherCharges.Name = "txtOtherCharges"
        Me.txtOtherCharges.Size = New System.Drawing.Size(118, 18)
        Me.txtOtherCharges.TabIndex = 4
        Me.txtOtherCharges.Text = "0.00"
        Me.txtOtherCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDiscountAmount.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountAmount.ForeColor = System.Drawing.Color.White
        Me.txtDiscountAmount.Location = New System.Drawing.Point(760, 475)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.ReadOnly = True
        Me.txtDiscountAmount.Size = New System.Drawing.Size(118, 18)
        Me.txtDiscountAmount.TabIndex = 5
        Me.txtDiscountAmount.Text = "0.00"
        Me.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(599, 388)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 200)
        Me.Panel1.TabIndex = 11
        '
        'txtPaymentTerms
        '
        Me.txtPaymentTerms.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPaymentTerms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaymentTerms.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentTerms.ForeColor = System.Drawing.Color.White
        Me.txtPaymentTerms.Location = New System.Drawing.Point(123, 537)
        Me.txtPaymentTerms.Multiline = True
        Me.txtPaymentTerms.Name = "txtPaymentTerms"
        Me.txtPaymentTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPaymentTerms.Size = New System.Drawing.Size(426, 51)
        Me.txtPaymentTerms.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lnkSelectItemswithoutIndent)
        Me.GroupBox2.Controls.Add(Me.flxItemList)
        Me.GroupBox2.Controls.Add(Me.lnkCalculatePOAmt)
        Me.GroupBox2.Controls.Add(Me.lnkSelectItems)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(6, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(890, 246)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail"
        '
        'lnkSelectItemswithoutIndent
        '
        Me.lnkSelectItemswithoutIndent.AutoSize = True
        Me.lnkSelectItemswithoutIndent.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkSelectItemswithoutIndent.LinkColor = System.Drawing.Color.DarkOrange
        Me.lnkSelectItemswithoutIndent.Location = New System.Drawing.Point(603, 221)
        Me.lnkSelectItemswithoutIndent.Name = "lnkSelectItemswithoutIndent"
        Me.lnkSelectItemswithoutIndent.Size = New System.Drawing.Size(166, 15)
        Me.lnkSelectItemswithoutIndent.TabIndex = 2
        Me.lnkSelectItemswithoutIndent.TabStop = True
        Me.lnkSelectItemswithoutIndent.Text = "Insert Items (without Indent)"
        '
        'flxItemList
        '
        Me.flxItemList.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.flxItemList.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        Me.flxItemList.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None
        Me.flxItemList.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
        Me.flxItemList.AutoClipboard = True
        Me.flxItemList.BackColor = System.Drawing.Color.Silver
        Me.flxItemList.ColumnInfo = "10,1,0,0,0,90,Columns:"
        Me.flxItemList.Dock = System.Windows.Forms.DockStyle.Top
        Me.flxItemList.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
        Me.flxItemList.HighLight = C1.Win.C1FlexGrid.HighLightEnum.WithFocus
        Me.flxItemList.Location = New System.Drawing.Point(3, 17)
        Me.flxItemList.Name = "flxItemList"
        Me.flxItemList.Rows.DefaultSize = 18
        Me.flxItemList.Size = New System.Drawing.Size(884, 201)
        Me.flxItemList.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("flxItemList.Styles"))
        Me.flxItemList.TabIndex = 0
        '
        'lnkCalculatePOAmt
        '
        Me.lnkCalculatePOAmt.AutoSize = True
        Me.lnkCalculatePOAmt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkCalculatePOAmt.LinkColor = System.Drawing.Color.DarkOrange
        Me.lnkCalculatePOAmt.Location = New System.Drawing.Point(10, 221)
        Me.lnkCalculatePOAmt.Name = "lnkCalculatePOAmt"
        Me.lnkCalculatePOAmt.Size = New System.Drawing.Size(127, 15)
        Me.lnkCalculatePOAmt.TabIndex = 1
        Me.lnkCalculatePOAmt.TabStop = True
        Me.lnkCalculatePOAmt.Text = "Calculate PO Amount"
        '
        'lnkSelectItems
        '
        Me.lnkSelectItems.AutoSize = True
        Me.lnkSelectItems.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkSelectItems.LinkColor = System.Drawing.Color.DarkOrange
        Me.lnkSelectItems.Location = New System.Drawing.Point(805, 221)
        Me.lnkSelectItems.Name = "lnkSelectItems"
        Me.lnkSelectItems.Size = New System.Drawing.Size(75, 15)
        Me.lnkSelectItems.TabIndex = 1
        Me.lnkSelectItems.TabStop = True
        Me.lnkSelectItems.Text = "Insert Items"
        '
        'txtPORemarks
        '
        Me.txtPORemarks.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPORemarks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPORemarks.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPORemarks.ForeColor = System.Drawing.Color.White
        Me.txtPORemarks.Location = New System.Drawing.Point(123, 480)
        Me.txtPORemarks.Multiline = True
        Me.txtPORemarks.Name = "txtPORemarks"
        Me.txtPORemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPORemarks.Size = New System.Drawing.Size(426, 51)
        Me.txtPORemarks.TabIndex = 2
        '
        'cmbDeliveryRate
        '
        Me.cmbDeliveryRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbDeliveryRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeliveryRate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDeliveryRate.ForeColor = System.Drawing.Color.White
        Me.cmbDeliveryRate.FormattingEnabled = True
        Me.cmbDeliveryRate.Location = New System.Drawing.Point(387, 387)
        Me.cmbDeliveryRate.Name = "cmbDeliveryRate"
        Me.cmbDeliveryRate.Size = New System.Drawing.Size(162, 23)
        Me.cmbDeliveryRate.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBarcodeSearch)
        Me.GroupBox1.Controls.Add(Me.Label52)
        Me.GroupBox1.Controls.Add(Me.chk_VatCal)
        Me.GroupBox1.Controls.Add(Me.txtPOPrefix)
        Me.GroupBox1.Controls.Add(Me.txtPONO)
        Me.GroupBox1.Controls.Add(Me.CHK_OPEN_PO_QTY)
        Me.GroupBox1.Controls.Add(Me.lblFormHeading)
        Me.GroupBox1.Controls.Add(Me.dtpEndDate)
        Me.GroupBox1.Controls.Add(Me.dtpStartDate)
        Me.GroupBox1.Controls.Add(Me.dtpPODate)
        Me.GroupBox1.Controls.Add(Me.cmbSupplier)
        Me.GroupBox1.Controls.Add(Me.cmbPOType)
        Me.GroupBox1.Controls.Add(Me.lblCap8)
        Me.GroupBox1.Controls.Add(Me.lblCap7)
        Me.GroupBox1.Controls.Add(Me.lblCap4)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblStatus)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblCap)
        Me.GroupBox1.Controls.Add(Me.lblCap2)
        Me.GroupBox1.Controls.Add(Me.lblCap1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chk_VatCal
        '
        Me.chk_VatCal.AutoSize = True
        Me.chk_VatCal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_VatCal.Location = New System.Drawing.Point(633, 73)
        Me.chk_VatCal.Name = "chk_VatCal"
        Me.chk_VatCal.Size = New System.Drawing.Size(153, 19)
        Me.chk_VatCal.TabIndex = 6
        Me.chk_VatCal.Text = "Calculate Vat on Excise"
        Me.chk_VatCal.UseVisualStyleBackColor = True
        Me.chk_VatCal.Visible = False
        '
        'txtPOPrefix
        '
        Me.txtPOPrefix.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPOPrefix.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPOPrefix.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOPrefix.Location = New System.Drawing.Point(618, 26)
        Me.txtPOPrefix.Name = "txtPOPrefix"
        Me.txtPOPrefix.Size = New System.Drawing.Size(100, 18)
        Me.txtPOPrefix.TabIndex = 20
        Me.txtPOPrefix.Visible = False
        '
        'txtPONO
        '
        Me.txtPONO.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPONO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPONO.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPONO.Location = New System.Drawing.Point(616, 6)
        Me.txtPONO.Name = "txtPONO"
        Me.txtPONO.Size = New System.Drawing.Size(100, 18)
        Me.txtPONO.TabIndex = 9
        Me.txtPONO.Visible = False
        '
        'CHK_OPEN_PO_QTY
        '
        Me.CHK_OPEN_PO_QTY.AutoSize = True
        Me.CHK_OPEN_PO_QTY.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_OPEN_PO_QTY.Location = New System.Drawing.Point(633, 50)
        Me.CHK_OPEN_PO_QTY.Name = "CHK_OPEN_PO_QTY"
        Me.CHK_OPEN_PO_QTY.Size = New System.Drawing.Size(123, 19)
        Me.CHK_OPEN_PO_QTY.TabIndex = 5
        Me.CHK_OPEN_PO_QTY.Text = "Open Quantity PO"
        Me.CHK_OPEN_PO_QTY.UseVisualStyleBackColor = True
        '
        'lblFormHeading
        '
        Me.lblFormHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblFormHeading.Font = New System.Drawing.Font("Verdana", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormHeading.ForeColor = System.Drawing.Color.White
        Me.lblFormHeading.Location = New System.Drawing.Point(762, 6)
        Me.lblFormHeading.Name = "lblFormHeading"
        Me.lblFormHeading.Size = New System.Drawing.Size(122, 58)
        Me.lblFormHeading.TabIndex = 3
        Me.lblFormHeading.Text = "Purchase Order"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpEndDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpEndDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEndDate.Location = New System.Drawing.Point(515, 74)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(111, 21)
        Me.dtpEndDate.TabIndex = 2
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpStartDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpStartDate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartDate.Location = New System.Drawing.Point(515, 44)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(111, 21)
        Me.dtpStartDate.TabIndex = 1
        '
        'dtpPODate
        '
        Me.dtpPODate.CalendarForeColor = System.Drawing.Color.White
        Me.dtpPODate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpPODate.CustomFormat = "dd-MMM-yyyy"
        Me.dtpPODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPODate.Location = New System.Drawing.Point(318, 97)
        Me.dtpPODate.Name = "dtpPODate"
        Me.dtpPODate.Size = New System.Drawing.Size(120, 21)
        Me.dtpPODate.TabIndex = 4
        '
        'cmbSupplier
        '
        Me.cmbSupplier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplier.ForeColor = System.Drawing.Color.White
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(71, 21)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(367, 23)
        Me.cmbSupplier.TabIndex = 0
        '
        'cmbPOType
        '
        Me.cmbPOType.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbPOType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPOType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPOType.ForeColor = System.Drawing.Color.White
        Me.cmbPOType.FormattingEnabled = True
        Me.cmbPOType.Location = New System.Drawing.Point(71, 96)
        Me.cmbPOType.Name = "cmbPOType"
        Me.cmbPOType.Size = New System.Drawing.Size(174, 23)
        Me.cmbPOType.TabIndex = 3
        '
        'lblCap8
        '
        Me.lblCap8.AutoSize = True
        Me.lblCap8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap8.Location = New System.Drawing.Point(447, 77)
        Me.lblCap8.Name = "lblCap8"
        Me.lblCap8.Size = New System.Drawing.Size(64, 15)
        Me.lblCap8.TabIndex = 0
        Me.lblCap8.Text = "End Date :"
        '
        'lblCap7
        '
        Me.lblCap7.AutoSize = True
        Me.lblCap7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap7.Location = New System.Drawing.Point(447, 49)
        Me.lblCap7.Name = "lblCap7"
        Me.lblCap7.Size = New System.Drawing.Size(67, 15)
        Me.lblCap7.TabIndex = 0
        Me.lblCap7.Text = "Start Date :"
        '
        'lblCap4
        '
        Me.lblCap4.AutoSize = True
        Me.lblCap4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap4.Location = New System.Drawing.Point(251, 99)
        Me.lblCap4.Name = "lblCap4"
        Me.lblCap4.Size = New System.Drawing.Size(59, 15)
        Me.lblCap4.TabIndex = 0
        Me.lblCap4.Text = "PO Date :"
        '
        'lblAddress
        '
        Me.lblAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(71, 51)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(367, 42)
        Me.lblAddress.TabIndex = 7
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(512, 21)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(47, 13)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "lblStatus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(447, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "PO Status :"
        '
        'lblCap
        '
        Me.lblCap.AutoSize = True
        Me.lblCap.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap.Location = New System.Drawing.Point(6, 100)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(58, 15)
        Me.lblCap.TabIndex = 0
        Me.lblCap.Text = "PO Type :"
        '
        'lblCap2
        '
        Me.lblCap2.AutoSize = True
        Me.lblCap2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap2.Location = New System.Drawing.Point(6, 53)
        Me.lblCap2.Name = "lblCap2"
        Me.lblCap2.Size = New System.Drawing.Size(59, 15)
        Me.lblCap2.TabIndex = 0
        Me.lblCap2.Text = "Address :"
        '
        'lblCap1
        '
        Me.lblCap1.AutoSize = True
        Me.lblCap1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap1.Location = New System.Drawing.Point(6, 23)
        Me.lblCap1.Name = "lblCap1"
        Me.lblCap1.Size = New System.Drawing.Size(59, 15)
        Me.lblCap1.TabIndex = 0
        Me.lblCap1.Text = "Supplier :"
        '
        'cmbQualityRate
        '
        Me.cmbQualityRate.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmbQualityRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQualityRate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbQualityRate.ForeColor = System.Drawing.Color.White
        Me.cmbQualityRate.FormattingEnabled = True
        Me.cmbQualityRate.Location = New System.Drawing.Point(123, 387)
        Me.cmbQualityRate.Name = "cmbQualityRate"
        Me.cmbQualityRate.Size = New System.Drawing.Size(166, 23)
        Me.cmbQualityRate.TabIndex = 0
        '
        'lblNetAmount
        '
        Me.lblNetAmount.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetAmount.ForeColor = System.Drawing.Color.Orange
        Me.lblNetAmount.Location = New System.Drawing.Point(765, 513)
        Me.lblNetAmount.Name = "lblNetAmount"
        Me.lblNetAmount.Size = New System.Drawing.Size(118, 20)
        Me.lblNetAmount.TabIndex = 0
        Me.lblNetAmount.Text = "0.00"
        Me.lblNetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(646, 513)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Net Amount :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(646, 478)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Discount Amt :"
        '
        'lblVatAmount
        '
        Me.lblVatAmount.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatAmount.ForeColor = System.Drawing.Color.Orange
        Me.lblVatAmount.Location = New System.Drawing.Point(765, 411)
        Me.lblVatAmount.Name = "lblVatAmount"
        Me.lblVatAmount.Size = New System.Drawing.Size(118, 20)
        Me.lblVatAmount.TabIndex = 0
        Me.lblVatAmount.Text = "0.00"
        Me.lblVatAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(646, 445)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Other Charges :"
        '
        'lblItemValue
        '
        Me.lblItemValue.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemValue.ForeColor = System.Drawing.Color.Orange
        Me.lblItemValue.Location = New System.Drawing.Point(765, 383)
        Me.lblItemValue.Name = "lblItemValue"
        Me.lblItemValue.Size = New System.Drawing.Size(118, 20)
        Me.lblItemValue.TabIndex = 0
        Me.lblItemValue.Text = "0.00"
        Me.lblItemValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(646, 416)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "GST  Amount :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(646, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Item Value :"
        '
        'lblCap6
        '
        Me.lblCap6.AutoSize = True
        Me.lblCap6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap6.Location = New System.Drawing.Point(16, 480)
        Me.lblCap6.Name = "lblCap6"
        Me.lblCap6.Size = New System.Drawing.Size(84, 15)
        Me.lblCap6.TabIndex = 0
        Me.lblCap6.Text = "PO Remarks :"
        '
        'lblCap9
        '
        Me.lblCap9.AutoSize = True
        Me.lblCap9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap9.Location = New System.Drawing.Point(16, 537)
        Me.lblCap9.Name = "lblCap9"
        Me.lblCap9.Size = New System.Drawing.Size(99, 15)
        Me.lblCap9.TabIndex = 0
        Me.lblCap9.Text = "Payment Terms :"
        '
        'lblCap5
        '
        Me.lblCap5.AutoSize = True
        Me.lblCap5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap5.Location = New System.Drawing.Point(16, 392)
        Me.lblCap5.Name = "lblCap5"
        Me.lblCap5.Size = New System.Drawing.Size(79, 15)
        Me.lblCap5.TabIndex = 0
        Me.lblCap5.Text = "Quality Rate :"
        '
        'lblCap10
        '
        Me.lblCap10.AutoSize = True
        Me.lblCap10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCap10.Location = New System.Drawing.Point(298, 394)
        Me.lblCap10.Name = "lblCap10"
        Me.lblCap10.Size = New System.Drawing.Size(85, 15)
        Me.lblCap10.TabIndex = 0
        Me.lblCap10.Text = "Delivery Rate :"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Zoom_search_find_magnifying_glass.png")
        Me.ImageList1.Images.SetKeyName(1, "Inventory_box_shipment_product.png")
        '
        'erp
        '
        Me.erp.ContainerControl = Me
        '
        'txtBarcodeSearch
        '
        Me.txtBarcodeSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBarcodeSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBarcodeSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcodeSearch.ForeColor = System.Drawing.Color.White
        Me.txtBarcodeSearch.Location = New System.Drawing.Point(514, 101)
        Me.txtBarcodeSearch.MaxLength = 100
        Me.txtBarcodeSearch.Name = "txtBarcodeSearch"
        Me.txtBarcodeSearch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBarcodeSearch.Size = New System.Drawing.Size(272, 19)
        Me.txtBarcodeSearch.TabIndex = 38
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.White
        Me.Label52.Location = New System.Drawing.Point(449, 104)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(59, 15)
        Me.Label52.TabIndex = 37
        Me.Label52.Text = "Barcode :"
        '
        'frm_Purchase_Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_Purchase_Order"
        Me.Size = New System.Drawing.Size(910, 630)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.flxPOList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.flxItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCap10 As System.Windows.Forms.Label
    Friend WithEvents lblCap8 As System.Windows.Forms.Label
    Friend WithEvents lblCap7 As System.Windows.Forms.Label
    Friend WithEvents lblCap4 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCap As System.Windows.Forms.Label
    Friend WithEvents lblCap5 As System.Windows.Forms.Label
    Friend WithEvents lblCap2 As System.Windows.Forms.Label
    Friend WithEvents lblCap1 As System.Windows.Forms.Label
    Friend WithEvents txtPORemarks As System.Windows.Forms.TextBox
    Friend WithEvents dtpPODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbPOType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCap9 As System.Windows.Forms.Label
    Friend WithEvents lblCap6 As System.Windows.Forms.Label
    Friend WithEvents txtPaymentTerms As System.Windows.Forms.TextBox
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbQualityRate As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDeliveryRate As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFormHeading As System.Windows.Forms.Label
    Friend WithEvents lnkSelectItems As System.Windows.Forms.LinkLabel
    Private WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents flxItemList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDiscountAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblNetAmount As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblVatAmount As System.Windows.Forms.Label
    Friend WithEvents lblItemValue As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents flxPOList As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbFilterSupp As System.Windows.Forms.ComboBox
    Friend WithEvents dtpoFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpoToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOtherCharges As System.Windows.Forms.TextBox
    Friend WithEvents txtPONumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lnkCalculatePOAmt As System.Windows.Forms.LinkLabel
    Friend WithEvents erp As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpTransMode As System.Windows.Forms.ComboBox
    Friend WithEvents dtpPriceBasis As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFreight As System.Windows.Forms.ComboBox
    Friend WithEvents dtpOctroi As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblPoStatus As System.Windows.Forms.Label
    Friend WithEvents cmdPoStatus As System.Windows.Forms.ComboBox
    Friend WithEvents CHK_OPEN_PO_QTY As System.Windows.Forms.CheckBox
    Friend WithEvents lnkSelectItemswithoutIndent As System.Windows.Forms.LinkLabel
    Friend WithEvents txtPOPrefix As System.Windows.Forms.TextBox
    Friend WithEvents txtPONO As System.Windows.Forms.TextBox
    Friend WithEvents chk_VatCal As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txtBarcodeSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
End Class

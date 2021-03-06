Imports System.Data
Imports System.Data.SqlClient
Imports C1.Win.C1FlexGrid
Imports MMSPlus.DebitNote

Public Class frm_DebitNote_WO_Items

    Implements IForm
    Dim obj As New CommonClass
    Dim flag As String
    '  Dim group_id As Integer
    Dim dtable_Item_List As DataTable
    Dim dtable As DataTable
    Dim supplierTable As DataTable = Nothing
    ' Dim dTable_IndentItems As DataTable
    ' Dim grdMaterial_Rowindex As Int16
    ' Dim RMRSID As Int16
    Dim FLXGRD_PO_Items_Rowindex As Int16
    '  Dim intColumnIndex As Integer

    Dim rights As Form_Rights
    Dim Pre As String

    Dim DN_Code As String
    Dim DN_No As Integer
    Dim DN_Id As Integer
    Dim clsObj As New DebitNote.cls_DebitNote_Master
    Dim prpty As New DebitNote.cls_DebitNote_Prop

    Dim _rights As Form_Rights
    Public Sub New(ByVal rights As Form_Rights)
        _rights = rights
        InitializeComponent()
    End Sub

    Private Enum enmPODetail
        ItemId = 0
        ItemCode = 1
        ItemName = 2
        UOM = 3
        ItemRate = 4
        VatPer = 5
        ExePer = 6
        BatchNo = 7
        ExpiryDate = 8
        BatchQty = 9

    End Enum



    Private Sub set_new_initilize()
        lbl_DNDate.Text = Now.ToString("dd-MMM-yyyy")
        GetDNCode()
        lblDN_Code.Text = DN_Code & DN_No
        txtRemarks.Text = ""
        'txt_INVNo.Text = ""
        'txt_INVDate.Text = ""
        txtRefNo.Text = ""
        'txtTaxAmt.Text = ""
        lblTotalTaxAmt.Text = "0.00"
        lblAddressText.Text = ""

        'dtable_Item_List = FLXGRD_MaterialItem.DataSource

        'lblAmount.Text = 0
        'lblVatAmount.Text = 0
        'lblDebit.Text = 0
        'If Not dtable_Item_List Is Nothing Then dtable_Item_List.Rows.Clear()
        TbRMRN.SelectTab(1)
        ' intColumnIndex = -1

        FillGrid()

        flag = "save"
    End Sub

    Private Sub GetDNCode()

        Dim ds As New DataSet()
        ds = clsObj.fill_Data_set("GET_DebitNote_No", "@DIV_ID", v_the_current_division_id)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Debit note series does not exists", MsgBoxStyle.Information, gblMessageHeading)
            ds.Dispose()
            Exit Sub
        Else
            If ds.Tables(0).Rows(0)(0).ToString() = "-1" Then
                MsgBox("Debit Note series does not exists", MsgBoxStyle.Information, gblMessageHeading)
                ds.Dispose()
                Exit Sub
            ElseIf ds.Tables(0).Rows(0)(0).ToString() = "-2" Then
                MsgBox("Debit Note series has been completed", MsgBoxStyle.Information, gblMessageHeading)
                ds.Dispose()
                Exit Sub
            Else
                DN_Code = ds.Tables(0).Rows(0)(0).ToString()
                DN_No = Convert.ToDecimal(ds.Tables(0).Rows(0)(1).ToString()) + 1
                ds.Dispose()
            End If
        End If

    End Sub

    Public Sub CloseClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.CloseClick

    End Sub

    Public Sub DeleteClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.DeleteClick

    End Sub

    Public Sub NewClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.NewClick
        Try
            TbRMRN.SelectTab(1)
            'FLXGRD_MaterialItem.DataSource = Nothing
            'Grid_styles()
            flag = "save"
            set_new_initilize()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error newClick --> frm_Indent_Master")
            MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
        End Try
    End Sub

    Private Sub FillGrid(Optional ByVal condition As String = "")
        Try
            obj.GridBind(dgvList, "SELECT  * FROM    ( SELECT    DebitNote_Id ,DebitNote_Code + CAST(DebitNote_No AS VARCHAR(10)) AS DebitNote_No ,  dbo.fn_format(DebitNote_Date) AS DebitNote_Date ,DN_Amount ,ACC_NAME , DM.Remarks ,DM.Created_by,DM.DebitNote_Type FROM      DebitNote_Master Dm INNER JOIN dbo.ACCOUNT_MASTER AM ON am.ACC_ID = dm.DN_CustId) tb  WHERE tb.DebitNote_Type='Open' and (tb.DebitNote_No+tb.DebitNote_Date+tb.Remarks+tb.Created_by+ACC_NAME + CAST(DN_Amount as varchar(50))) LIKE '%" & condition & "%'")
            dgvList.Width = 100
            dgvList.Columns(0).Visible = False 'Reverse_ID
            dgvList.Columns(0).Width = 100
            dgvList.Columns(1).HeaderText = "Debit Note No."
            dgvList.Columns(1).Width = 100
            dgvList.Columns(2).HeaderText = "Debit Note Date"
            dgvList.Columns(2).Width = 100
            dgvList.Columns(3).HeaderText = "Dn. Amount"
            dgvList.Columns(3).Width = 100
            dgvList.Columns(4).HeaderText = "Supplier"
            dgvList.Columns(4).Width = 170
            dgvList.Columns(5).HeaderText = "Remarks"
            dgvList.Columns(5).Width = 200
            dgvList.Columns(6).HeaderText = "User"
            dgvList.Columns(6).Width = 50
        Catch ex As Exception
            MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
        End Try
    End Sub
    Public Sub RefreshClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.RefreshClick
        FillGrid()
        TbRMRN.SelectTab(0)
    End Sub

    Private Function validate_data() As Boolean
        'Dim iRow As Int32
        'Dim int_RowIndex As Int32
        Dim dtCheck As New DataTable
        Dim blnIsExist As Boolean
        blnIsExist = False

        If String.IsNullOrEmpty(txtRemarks.Text) Then
            MsgBox("Please fill the Remarks", vbExclamation, gblMessageHeading)
            txtRemarks.Focus()
            validate_data = False
            Exit Function
        End If

        'If cmbMRNNo.SelectedIndex <= 0 Then
        '    MsgBox("Select MRN to create debit note.", vbExclamation, gblMessageHeading)
        '    cmbMRNNo.Focus()
        '    validate_data = False
        '    Exit Function
        'End If

        'dtCheck = FLXGRD_MaterialItem.DataSource
        'int_RowIndex = dtCheck.Rows.Count
        'For iRow = 0 To int_RowIndex - 1
        '    If dtCheck.Rows(iRow)("Item_Qty") > 0 Then
        '        blnIsExist = True
        '    End If
        'Next iRow

        'If blnIsExist = False Then
        '    validate_data = False
        '    MsgBox("Enter atleast one debit quantity.", vbExclamation, gblMessageHeading)
        '    Exit Function
        'Else
        validate_data = True
        'End If
    End Function

    Public Sub SaveClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.SaveClick
        CalculateAmount()
        Dim cmd As SqlCommand

        cmd = obj.MyCon_BeginTransaction

        txtRemarks.Focus()
        Try
            If flag = "save" And validate_data() Then

                GetDNCode()
                DN_Id = Convert.ToInt32(obj.getMaxValue("DebitNote_ID", "DebitNote_MASTER"))
                prpty.DebitNote_ID = Convert.ToInt32(DN_Id)
                prpty.DebitNote_Code = DN_Code ' GetDebitNoteCode()
                prpty.DebitNote_No = DN_No ' Convert.ToInt32(DebitNoteID)
                prpty.DebitNote_Date = Now 'Convert.ToDateTime(lbl_PODate.Text).ToString()
                prpty.MRN_ID = 0
                prpty.Remarks = txtRemarks.Text
                prpty.Created_By = v_the_current_logged_in_user_name
                prpty.Creation_Date = Now
                prpty.Modified_By = ""
                prpty.Modification_Date = NULL_DATE
                prpty.Division_ID = v_the_current_division_id
                prpty.Dn_Amount = txtDebitAmt.Text
                prpty.DN_CustId = cmbsupplier.SelectedValue
                prpty.INV_No = 0
                prpty.INV_Date = dtpRefDate.Value
                prpty.DN_ItemValue = 0
                prpty.DN_ItemTax = 0
                prpty.DN_Type = "Open"
                prpty.Ref_No = txtRefNo.Text
                prpty.Ref_Date = dtpRefDate.Value
                prpty.Tax_Num = lblTotalTaxAmt.Text


                clsObj.insert_DebitNote_MASTER(prpty, cmd)

                'Dim iRowCount As Int32
                'Dim iRow As Int32
                'iRowCount = FLXGRD_MaterialItem.Rows.Count - 1

                'For iRow = 1 To iRowCount
                '    If FLXGRD_MaterialItem.Item(iRow, "Item_Qty") > 0 Then
                If Val(txt3Per.Text) <> 0 Then
                    prpty.DebitNote_ID = Convert.ToInt32(DN_Id)
                    prpty.Item_ID = 0

                    prpty.Item_Qty = 0
                    prpty.Item_Rate = txt3Per.Text
                    prpty.Item_Tax = 3.0
                    prpty.Stock_Detail_ID = 0
                    prpty.Created_By = v_the_current_logged_in_user_name
                    prpty.Creation_Date = Now
                    prpty.Modified_By = v_the_current_logged_in_user_name
                    prpty.Modification_Date = Now
                    prpty.Division_ID = v_the_current_division_id
                    clsObj.insert_DebitNote_WO_Items_DETAIL(prpty, cmd)
                End If

                If Val(txt5Per.Text) <> 0 Then
                    prpty.DebitNote_ID = Convert.ToInt32(DN_Id)
                    prpty.Item_ID = 0

                    prpty.Item_Qty = 0
                    prpty.Item_Rate = txt5Per.Text
                    prpty.Item_Tax = 5.0
                    prpty.Stock_Detail_ID = 0
                    prpty.Created_By = v_the_current_logged_in_user_name
                    prpty.Creation_Date = Now
                    prpty.Modified_By = v_the_current_logged_in_user_name
                    prpty.Modification_Date = Now
                    prpty.Division_ID = v_the_current_division_id
                    clsObj.insert_DebitNote_WO_Items_DETAIL(prpty, cmd)
                End If

                If Val(txt12Per.Text) <> 0 Then
                    prpty.DebitNote_ID = Convert.ToInt32(DN_Id)
                    prpty.Item_ID = 0

                    prpty.Item_Qty = 0
                    prpty.Item_Rate = txt12Per.Text
                    prpty.Item_Tax = 12.0
                    prpty.Stock_Detail_ID = 0
                    prpty.Created_By = v_the_current_logged_in_user_name
                    prpty.Creation_Date = Now
                    prpty.Modified_By = v_the_current_logged_in_user_name
                    prpty.Modification_Date = Now
                    prpty.Division_ID = v_the_current_division_id
                    clsObj.insert_DebitNote_WO_Items_DETAIL(prpty, cmd)
                End If

                If Val(txt18Per.Text) <> 0 Then
                    prpty.DebitNote_ID = Convert.ToInt32(DN_Id)
                    prpty.Item_ID = 0

                    prpty.Item_Qty = 0
                    prpty.Item_Rate = txt18Per.Text
                    prpty.Item_Tax = 18.0
                    prpty.Stock_Detail_ID = 0
                    prpty.Created_By = v_the_current_logged_in_user_name
                    prpty.Creation_Date = Now
                    prpty.Modified_By = v_the_current_logged_in_user_name
                    prpty.Modification_Date = Now
                    prpty.Division_ID = v_the_current_division_id
                    clsObj.insert_DebitNote_WO_Items_DETAIL(prpty, cmd)
                End If

                If Val(txt28Per.Text) <> 0 Then
                    prpty.DebitNote_ID = Convert.ToInt32(DN_Id)
                    prpty.Item_ID = 0

                    prpty.Item_Qty = 0
                    prpty.Item_Rate = txt28Per.Text
                    prpty.Item_Tax = 28.0
                    prpty.Stock_Detail_ID = 0
                    prpty.Created_By = v_the_current_logged_in_user_name
                    prpty.Creation_Date = Now
                    prpty.Modified_By = v_the_current_logged_in_user_name
                    prpty.Modification_Date = Now
                    prpty.Division_ID = v_the_current_division_id
                    clsObj.insert_DebitNote_WO_Items_DETAIL(prpty, cmd)
                End If




                'End If
                '    End If
                'Next iRow

                MsgBox("Debit note saved with No. " & DN_Code & DN_No, MsgBoxStyle.Information, gblMessageHeading)
                obj.MyCon_CommitTransaction(cmd)

                If flag = "save" Then
                        If MsgBox(vbCrLf & "Do You Want to Print Preview.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, gblMessageHeading) = MsgBoxResult.Yes Then
                            obj.RptShow(enmReportName.RptDebitNoteWOItemPrint, "DN_ID", CStr(prpty.DebitNote_ID), CStr(enmDataType.D_int))
                        End If
                    Else
                    End If

                    set_new_initilize()

                    cmbsupplier.SelectedValue = 0
                    ' cmbMRNNo.SelectedValue = 0
                End If
        Catch ex As Exception
            obj.MyCon_RollBackTransaction(cmd)
            MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
        End Try

    End Sub

    Public Function GetReceivedCode() As String

        Dim CCID As String
        Dim POCode As String
        Pre = obj.getPrefixCode("RMRN_Prefix", "DIVISION_SETTINGS")
        CCID = obj.getMaxValue("Reverse_ID", "REVERSEMATERIAL_RECIEVED_WITHOUT_PO_MASTER")
        POCode = Pre & "" & CCID
        Return POCode
    End Function

    Public Sub ViewClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.ViewClick
        Try
            If TbRMRN.SelectedIndex = 0 Then
                If dgvList.SelectedRows.Count > 0 Then

                    obj.RptShow(enmReportName.RptDebitNoteWOItemPrint, "DN_ID", CStr(dgvList("DebitNote_Id", dgvList.CurrentCell.RowIndex).Value()), CStr(enmDataType.D_int))
                End If
            Else
                If flag <> "save" Then
                    obj.RptShow(enmReportName.RptDebitNoteWOItemPrint, "DN_ID", CStr(DN_Id), CStr(enmDataType.D_int))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Private Sub Grid_styles()
    '    If Not dtable_Item_List Is Nothing Then dtable_Item_List.Dispose()

    '    dtable_Item_List = New DataTable()
    '    dtable_Item_List.Columns.Add("Item_ID", GetType(System.Int32))
    '    dtable_Item_List.Columns.Add("Item_Code", GetType(System.String))
    '    dtable_Item_List.Columns.Add("Item_Name", GetType(System.String))
    '    dtable_Item_List.Columns.Add("UM_Name", GetType(System.String))
    '    dtable_Item_List.Columns.Add("Prev_Item_Qty", GetType(System.Double))
    '    dtable_Item_List.Columns.Add("MRN_Qty", GetType(System.Double))
    '    dtable_Item_List.Columns.Add("Item_Rate", GetType(System.Double))
    '    dtable_Item_List.Columns.Add("Vat_Per", GetType(System.Double))
    '    dtable_Item_List.Columns.Add("Item_Qty", GetType(System.Double))
    '    dtable_Item_List.Columns.Add("Stock_Detail_Id", GetType(System.Double))


    '    FLXGRD_MaterialItem.DataSource = dtable_Item_List
    '    dtable_Item_List.Rows.Add(dtable_Item_List.NewRow)
    '    FLXGRD_MaterialItem.Cols(0).Width = 10
    '    SetGridSettingValues()


    'End Sub

    'Private Sub SetGridSettingValues()

    '    FLXGRD_MaterialItem.Cols("Item_ID").Visible = False
    '    FLXGRD_MaterialItem.Cols("Item_Code").Caption = "Item Code"
    '    FLXGRD_MaterialItem.Cols("Item_Name").Caption = "Item Name"
    '    FLXGRD_MaterialItem.Cols("UM_Name").Caption = "UOM"
    '    FLXGRD_MaterialItem.Cols("Prev_Item_Qty").Caption = "Current Stock"
    '    FLXGRD_MaterialItem.Cols("MRN_Qty").Caption = "MRN Item Qty"
    '    FLXGRD_MaterialItem.Cols("Item_Rate").Caption = "Item Rate"
    '    FLXGRD_MaterialItem.Cols("Vat_Per").Caption = "Tax %"

    '    FLXGRD_MaterialItem.Cols("Item_Qty").Caption = "Item Qty"

    '    FLXGRD_MaterialItem.Cols("Stock_Detail_Id").Visible = False

    '    FLXGRD_MaterialItem.Cols("Item_Code").AllowEditing = False
    '    FLXGRD_MaterialItem.Cols("Item_Name").AllowEditing = False
    '    FLXGRD_MaterialItem.Cols("UM_Name").AllowEditing = False
    '    FLXGRD_MaterialItem.Cols("Prev_Item_Qty").AllowEditing = False
    '    FLXGRD_MaterialItem.Cols("MRN_Qty").AllowEditing = False
    '    FLXGRD_MaterialItem.Cols("Item_Rate").AllowEditing = False
    '    FLXGRD_MaterialItem.Cols("Vat_Per").AllowEditing = False

    '    FLXGRD_MaterialItem.Cols("Item_Qty").AllowEditing = True

    '    FLXGRD_MaterialItem.Cols("Stock_Detail_Id").AllowEditing = False

    '    FLXGRD_MaterialItem.Cols("Item_Code").Width = 60
    '    FLXGRD_MaterialItem.Cols("Item_Name").Width = 300
    '    FLXGRD_MaterialItem.Cols("UM_Name").Width = 40
    '    FLXGRD_MaterialItem.Cols("Prev_Item_Qty").Width = 90

    '    FLXGRD_MaterialItem.Cols("MRN_Qty").Width = 90
    '    FLXGRD_MaterialItem.Cols("Item_Rate").Width = 90
    '    FLXGRD_MaterialItem.Cols("Vat_Per").Width = 90

    '    FLXGRD_MaterialItem.Cols("Item_Qty").Width = 100
    '    FLXGRD_MaterialItem.Cols("Stock_Detail_Id").Width = 200



    '    Dim cs As C1.Win.C1FlexGrid.CellStyle
    '    cs = Me.FLXGRD_MaterialItem.Styles.Add("Item_Qty")
    '    cs.ForeColor = Color.White
    '    cs.BackColor = Color.Green
    '    cs.Border.Style = BorderStyleEnum.Raised

    '    Dim i As Integer
    '    For i = 1 To FLXGRD_MaterialItem.Rows.Count - 1
    '        FLXGRD_MaterialItem.SetCellStyle(i, FLXGRD_MaterialItem.Cols("Item_Qty").SafeIndex, cs)
    '    Next

    'End Sub


    'Private Sub FLXGRD_MaterialItem_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs)
    '    If IsNumeric(FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty")) = True Then
    '        If FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") > FLXGRD_MaterialItem.Rows(e.Row)("Prev_Item_Qty") Then
    '            FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") = 0
    '        Else
    '            FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") = Math.Round(Convert.ToDouble(FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty")), 4)

    '            Dim itemqty As Decimal = Math.Round(Convert.ToDouble(FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty")), 4)
    '            Dim itemRate As Decimal = Math.Round(Convert.ToDouble(FLXGRD_MaterialItem.Rows(e.Row)("Item_Rate")), 2)
    '            Dim Vat As Decimal = Math.Round(Convert.ToDouble(FLXGRD_MaterialItem.Rows(e.Row)("Vat_Per")), 2)

    '            CalculateAmount()

    '        End If
    '    Else
    '        FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") = 0
    '    End If
    'End Sub

    Private Sub FLXGRD_MaterialItem_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub FLXGRD_MaterialItem_RowColChange(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '  intColumnIndex = fl

    End Sub

    Private Sub FLXGRD_MaterialItem_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub dgvList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub getMRNDetail(ByVal Receive_ID As Integer)


    End Sub

    'Private Sub cmbMRNNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Try
    '        set_new_initilize()
    '        Dim ds As DataSet
    '        Dim ds1 As DataSet
    '        Dim MRNNo As Int32
    '        MRNNo = Convert.ToInt32(cmbMRNNo.SelectedValue)
    '        ds = clsObj.fill_Data_set("Get_MRN_Details_DebitNote", "@V_MRN_NO", MRNNo)
    '        If ds.Tables(0).Rows.Count > 0 Then
    '            dtable_Item_List = ds.Tables(0).Copy
    '            FLXGRD_MaterialItem.DataSource = dtable_Item_List
    '            SetGridSettingValues()
    '        End If

    '        Dim Query As String = " SELECT Invoice_No ,CONVERT(VARCHAR (20),Invoice_date,106)AS Invoice_date FROM dbo.MATERIAL_RECEIVED_AGAINST_PO_MASTER WHERE MRN_NO=" & MRNNo & " AND Division_ID =   " & v_the_current_division_id &
    '       "UNION ALL SELECT Invoice_No ,CONVERT(VARCHAR (20),Invoice_date,106)AS Invoice_date FROM dbo.MATERIAL_RECIEVED_WITHOUT_PO_MASTER WHERE MRN_NO=" & MRNNo


    '        ds1 = clsObj.FillDataSet(Query)
    '        If ds1.Tables(0).Rows.Count > 0 Then
    '            txt_INVNo.Text = ds1.Tables(0).Rows(0)(0)
    '            txt_INVDate.Text = ds1.Tables(0).Rows(0)(1)
    '        End If
    '        TbRMRN.SelectTab(1)
    '    Catch ex As Exception
    '        MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
    '    End Try
    '    lblAmount.Text = 0
    '    lblVatAmount.Text = 0
    '    lblDebit.Text = 0

    'End Sub

    Private Sub frm_DebitNote_WO_Items_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        set_new_initilize()
        BindSupplierCombo()
        'BindMRNCombo()
        'Grid_styles()
        FillGrid()

    End Sub

    'Private Sub BindMRNCombo()

    '    Dim Query As String
    '    Dim Dt As DataTable
    '    Dim Dtrow As DataRow
    '    Query = " SELECT MRN_NO AS MRN_ID,MRN_PREFIX+CAST(MRN_NO AS VARCHAR(20))AS MRN_NO FROM dbo.MATERIAL_RECEIVED_AGAINST_PO_MASTER WHERE PO_ID IN (SELECT PO_ID FROM dbo.PO_MASTER WHERE PO_SUPP_ID=" & cmbsupplier.SelectedValue & ") AND Division_ID =   " & v_the_current_division_id &
    '        "UNION ALL SELECT MRN_NO AS MRN_ID , MRN_PREFIX + CAST(MRN_NO AS VARCHAR(20)) AS MRN_NO FROM dbo.MATERIAL_RECIEVED_WITHOUT_PO_MASTER WHERE Vendor_ID=" & cmbsupplier.SelectedValue & " ORDER BY MRN_id"
    '    Dt = clsObj.Fill_DataSet(Query).Tables(0)
    '    Dtrow = Dt.NewRow
    '    Dtrow("MRN_ID") = -1
    '    Dtrow("MRN_NO") = "Select MRN No"
    '    Dt.Rows.InsertAt(Dtrow, 0)
    '    'cmbMRNNo.DisplayMember = "MRN_NO"
    '    'cmbMRNNo.ValueMember = "MRN_ID"
    '    'cmbMRNNo.DataSource = Dt
    '    'cmbMRNNo.SelectedIndex = 0

    'End Sub

    Private Sub BindSupplierCombo()
        cmbsupplier.ValueMember = "ACC_ID"
        cmbsupplier.DisplayMember = "ACC_NAME"
        Dim Query As String
        Query = "select 0 as ACC_ID,'--Select--' as ACC_NAME ,'' AS Address union Select ACC_ID,ACC_NAME, ADDRESS_PRIM AS Address from ACCOUNT_MASTER WHERE AG_ID=2 Order by ACC_NAME "

        'obj.ComboBind(cmbsupplier, Query, "ACC_NAME", "ACC_ID")
        supplierTable = obj.FillDataSet(Query).Tables(0)
        cmbsupplier.DataSource = supplierTable

    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        FillGrid(txtSearch.Text.Trim())
    End Sub

    Private Sub cmbsupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsupplier.SelectedIndexChanged
        'BindMRNCombo()
        'lblAmount.Text = 0
        'lblVatAmount.Text = 0
        'lblDebit.Text = 0

        Dim dr() As DataRow = supplierTable.Select("ACC_ID = " & cmbsupplier.SelectedValue)
        If dr.Length > 0 Then
            lblAddressText.Text = String.Format(dr(0)("Address"))
        End If
    End Sub

    Private Sub lnkCalculateDebitAmt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        CalculateAmount()
    End Sub


    Private Function CalculateAmount() As String
        Dim i As Integer
        Dim Str As String

        Dim total_item_value As Double
        Dim total_vat_amount As Double
        Dim total_exice_amount As Double
        Dim tot_amt As Double
        total_exice_amount = 0
        total_item_value = 0
        total_vat_amount = 0
        tot_amt = 0


        'For i = 1 To FLXGRD_MaterialItem.Rows.Count - 1
        '    total_item_value = total_item_value + (FLXGRD_MaterialItem.Rows(i).Item("Item_Qty") * FLXGRD_MaterialItem.Rows(i).Item("item_rate"))
        '    total_vat_amount = total_vat_amount + ((FLXGRD_MaterialItem.Rows(i).Item("item_rate") * FLXGRD_MaterialItem.Rows.Item(i)("Item_Qty")) * FLXGRD_MaterialItem.Rows(i).Item("Vat_Per") / 100)

        'Next

        'lblAmount.Text = total_item_value.ToString("#0.00")
        'lblVatAmount.Text = total_vat_amount.ToString("#0.00")
        'lblDebit.Text = (total_item_value + total_vat_amount + total_exice_amount).ToString("#0.00")
        Str = total_item_value.ToString("#0.00") + "," + total_vat_amount.ToString("#0.00") + "," + total_exice_amount.ToString()
        Return Str

    End Function

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub txt3Per_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt3Per.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txt3Per_Validated(sender As Object, e As EventArgs) Handles txt3Per.Validated
        CalCulateTax()
    End Sub

    Private Sub txt5Per_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt5Per.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txt5Per_Validated(sender As Object, e As EventArgs) Handles txt5Per.Validated
        CalCulateTax()
    End Sub
    Private Sub CalCulateTax()
        lblTotalTaxAmt.Text = "0.00"
        lblTotalTaxAmt.Text = Convert.ToDouble(Val(lblTotalTaxAmt.Text)) + Convert.ToDouble(Val(txt3Per.Text)) + Convert.ToDouble(Val(txt5Per.Text)) + Convert.ToDouble(Val(txt12Per.Text)) + Convert.ToDouble(Val(txt18Per.Text)) + Convert.ToDouble(Val(txt28Per.Text))
    End Sub

    Private Sub txt12Per_Validated(sender As Object, e As EventArgs) Handles txt12Per.Validated
        CalCulateTax()
    End Sub

    Private Sub txt18Per_Validated(sender As Object, e As EventArgs) Handles txt18Per.Validated
        CalCulateTax()
    End Sub

    Private Sub txt28Per_Validated(sender As Object, e As EventArgs) Handles txt28Per.Validated
        CalCulateTax()
    End Sub

    Private Sub txt12Per_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt12Per.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txt18Per_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt18Per.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txt28Per_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt28Per.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub
End Class

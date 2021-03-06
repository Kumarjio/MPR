Imports MMSPlus.CreditNote
Imports System.Data.SqlClient
Imports System.Data
Imports C1.Win.C1FlexGrid

Public Class frm_CreditNote

    Implements IForm
    Dim obj As New CommonClass
    Dim flag As String
    Dim dtable_Item_List As DataTable
    Dim dtable As DataTable
    Dim FLXGRD_PO_Items_Rowindex As Int16
    Dim rights As Form_Rights
    Dim Pre As String
    Dim CN_Code As String
    Dim CN_No As Integer
    Dim CN_Id As Integer
    Dim clsObj As New CreditNote.cls_Credit_note_Master
    Dim prpty As New CreditNote.cls_Credit_note_Prop
    Dim _rights As Form_Rights
    Public Sub New(ByVal rights As Form_Rights)
        _rights = rights
        InitializeComponent()
    End Sub

    'Private Enum enmPODetail
    '    ItemId = 0
    '    ItemCode = 1
    '    ItemName = 2
    '    UOM = 3
    '    ItemRate = 4
    '    VatPer = 5
    '    ExePer = 6
    '    BatchNo = 7
    '    ExpiryDate = 8
    '    BatchQty = 9

    'End Enum



    Private Sub set_new_initilize()
        lbl_CNDate.Text = Now.ToString("dd-MMM-yyyy")
        GetCNCode()
        lblCN_Code.Text = CN_Code & CN_No
        txtRemarks.Text = ""
        dtable_Item_List = FLXGRD_MaterialItem.DataSource
        If Not dtable_Item_List Is Nothing Then dtable_Item_List.Rows.Clear()
        TbRMRN.SelectTab(1)
        ' intColumnIndex = -1
        FillGrid()
        flag = "save"
        lblAmount.Text = 0
        lblVatAmount.Text = 0
        lblCredit.Text = 0
    End Sub

    Private Sub GetCNCode()

        Dim ds As New DataSet()
        ds = clsObj.fill_Data_set("GET_CreditNote_No", "@DIV_ID", v_the_current_division_id)
        If ds.Tables(0).Rows.Count = 0 Then
            MsgBox("Credit note series does not exists", MsgBoxStyle.Information, gblMessageHeading)
            ds.Dispose()
            Exit Sub
        Else
            If ds.Tables(0).Rows(0)(0).ToString() = "-1" Then
                MsgBox("Credit Note series does not exists", MsgBoxStyle.Information, gblMessageHeading)
                ds.Dispose()
                Exit Sub
            ElseIf ds.Tables(0).Rows(0)(0).ToString() = "-2" Then
                MsgBox("Credit Note series has been completed", MsgBoxStyle.Information, gblMessageHeading)
                ds.Dispose()
                Exit Sub
            Else
                CN_Code = ds.Tables(0).Rows(0)(0).ToString()
                CN_No = Convert.ToDecimal(ds.Tables(0).Rows(0)(1).ToString()) + 1
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
            FLXGRD_MaterialItem.DataSource = Nothing
            Grid_styles()
            flag = "save"
            set_new_initilize()
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error newClick --> frm_Indent_Master")
            MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
        End Try
    End Sub

    Private Sub FillGrid(Optional ByVal condition As String = "")
        Try
            obj.GridBind(dgvList, "SELECT  *FROM (SELECT CreditNote_Id,  CreditNote_Code + CAST(CreditNote_No AS VARCHAR(10)) AS CreditNoteNo , dbo.fn_format(CreditNote_Date) AS CreditNote_Date , SI_ID, SIM.SI_CODE+CAST(sim.SI_NO AS VARCHAR(50))AS INVNo,CN_Amount , ACC_NAME ,cnm.Remarks, cnm.Created_by FROM CreditNote_Master CNM JOIN dbo.SALE_INVOICE_MASTER SIM ON CNM.INVId=sim.SI_ID  INNER JOIN dbo.ACCOUNT_MASTER AM ON am.ACC_ID = CNM.CN_CustId )tb where (tb.CreditNoteNo+tb.CreditNote_Date+INVNo+tb.Remarks+CAST(tb.CN_Amount AS VARCHAR(20)) +tb.ACC_NAME+tb.Created_by) LIKE '%" & condition & "%'")
            dgvList.Width = 100
            dgvList.Columns(0).Visible = False 'Reverse_ID
            dgvList.Columns(0).Width = 100
            dgvList.Columns(1).HeaderText = "Credit Note No."
            dgvList.Columns(1).Width = 100
            dgvList.Columns(2).HeaderText = "Credit Note Date"
            dgvList.Columns(2).Width = 100
            dgvList.Columns(3).HeaderText = "INV Id"
            dgvList.Columns(3).Width = 70
            dgvList.Columns(3).Visible = False
            dgvList.Columns(4).HeaderText = "INV No."
            dgvList.Columns(4).Width = 100

            dgvList.Columns(5).HeaderText = "CN. Amount"
            dgvList.Columns(5).Width = 100

            dgvList.Columns(6).HeaderText = "Customer"
            dgvList.Columns(6).Width = 170

            dgvList.Columns(7).HeaderText = "Remarks"
            dgvList.Columns(7).Width = 200
            dgvList.Columns(8).HeaderText = "User"
            dgvList.Columns(8).Width = 50

        Catch ex As Exception
            MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
        End Try
    End Sub
    Public Sub RefreshClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.RefreshClick
        FillGrid()
        TbRMRN.SelectTab(0)
    End Sub

    Private Function validate_data() As Boolean
        Dim iRow As Int32
        Dim int_RowIndex As Int32
        Dim dtCheck As New DataTable
        Dim blnIsExist As Boolean
        blnIsExist = False

        If String.IsNullOrEmpty(txtRemarks.Text) Then
            MsgBox("Please fill the Remarks", vbExclamation, gblMessageHeading)
            txtRemarks.Focus()
            validate_data = False
            Exit Function
        End If

        If cmbINVNo.SelectedIndex <= 0 Then
            MsgBox("Select INV to create Credit note.", vbExclamation, gblMessageHeading)
            cmbINVNo.Focus()
            validate_data = False
            Exit Function
        End If

        dtCheck = FLXGRD_MaterialItem.DataSource
        int_RowIndex = dtCheck.Rows.Count
        For iRow = 0 To int_RowIndex - 1
            If dtCheck.Rows(iRow)("Item_Qty") > 0 Then
                blnIsExist = True
            End If
        Next iRow

        If blnIsExist = False Then
            validate_data = False
            MsgBox("Enter atleast one Credit quantity.", vbExclamation, gblMessageHeading)
            Exit Function
        Else
            validate_data = True
        End If
    End Function

    Public Sub SaveClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.SaveClick


        Dim cmd As SqlCommand



        txtRemarks.Focus()
        Try
            If flag = "save" And validate_data() Then
                cmd = obj.MyCon_BeginTransaction
                CalculateAmount()

                GetCNCode()
                CN_Id = Convert.ToInt32(obj.getMaxValue("CreditNote_ID", "CreditNote_MASTER"))
                prpty.CreditNote_ID = Convert.ToInt32(CN_Id)
                prpty.CreditNote_Code = CN_Code
                prpty.CreditNote_No = CN_No
                prpty.CreditNote_Date = Now
                prpty.INV_ID = cmbINVNo.SelectedValue
                prpty.Remarks = txtRemarks.Text
                prpty.Created_By = v_the_current_logged_in_user_name
                prpty.Creation_Date = Now
                prpty.Modified_By = ""
                prpty.Modification_Date = NULL_DATE
                prpty.Division_ID = v_the_current_division_id
                prpty.Cn_Amount = lblCredit.Text
                prpty.CN_CustId = cmbCustomer.SelectedValue
                prpty.INV_No = lblInvNo.Text
                prpty.INV_Date = lblInvdate.Text
                prpty.CN_ItemValue = lblAmount.Text
                prpty.CN_ItemTax = lblVatAmount.Text
                prpty.CN_Type = "Item"
                prpty.Ref_No = ""
                prpty.Ref_Date = DateTime.Now()
                prpty.Tax_Amt = 0
                clsObj.insert_CreditNote_MASTER(prpty, cmd)

                Dim iRowCount As Int32
                Dim iRow As Int32
                iRowCount = FLXGRD_MaterialItem.Rows.Count - 1

                For iRow = 1 To iRowCount
                    If FLXGRD_MaterialItem.Item(iRow, "Item_Qty") > 0 Then
                        prpty.CreditNote_ID = Convert.ToInt32(CN_Id)
                        prpty.Item_ID = FLXGRD_MaterialItem.Item(iRow, "Item_Id")

                        prpty.Item_Qty = Convert.ToDouble(FLXGRD_MaterialItem.Item(iRow, "Item_Qty")).ToString()
                        prpty.Item_Rate = Convert.ToDouble(FLXGRD_MaterialItem.Item(iRow, "Item_rate")).ToString()
                        prpty.Item_Tax = Convert.ToDouble(FLXGRD_MaterialItem.Item(iRow, "Vat_Per")).ToString()
                        prpty.Stock_Detail_ID = Convert.ToDouble(FLXGRD_MaterialItem.Item(iRow, "Stock_Detail_Id")).ToString()
                        prpty.Created_By = v_the_current_logged_in_user_name
                        prpty.Creation_Date = Now
                        prpty.Modified_By = v_the_current_logged_in_user_name
                        prpty.Modification_Date = Now
                        prpty.Division_ID = v_the_current_division_id
                        clsObj.insert_CreditNote_DETAIL(prpty, cmd)
                        'End If
                    End If
                Next iRow

                MsgBox("Credit note saved with No. " & CN_Code & CN_No, MsgBoxStyle.Information, gblMessageHeading)
                obj.MyCon_CommitTransaction(cmd)

                If flag = "save" Then
                    If MsgBox(vbCrLf & "Do You Want to Print Preview.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, gblMessageHeading) = MsgBoxResult.Yes Then
                        obj.RptShow(enmReportName.RptCreditNotePrint, "CN_ID", CStr(prpty.CreditNote_ID), CStr(enmDataType.D_int))
                    End If
                Else
                End If

                set_new_initilize()
                cmbCustomer.SelectedValue = 0
                cmbINVNo.SelectedValue = 0
            End If
        Catch ex As Exception
            obj.MyCon_RollBackTransaction(cmd)
            MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
        End Try

    End Sub

    'Public Function GetReceivedCode() As String

    '    Dim CCID As String
    '    Dim POCode As String
    '    Pre = obj.getPrefixCode("RMRN_Prefix", "DIVISION_SETTINGS")
    '    CCID = obj.getMaxValue("Reverse_ID", "REVERSEMATERIAL_RECIEVED_WITHOUT_PO_MASTER")
    '    POCode = Pre & "" & CCID
    '    Return POCode
    'End Function

    Public Sub ViewClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.ViewClick
        Try
            If TbRMRN.SelectedIndex = 0 Then
                If dgvList.SelectedRows.Count > 0 Then

                    obj.RptShow(enmReportName.RptCreditNotePrint, "CN_ID", CStr(dgvList("CreditNote_Id", dgvList.CurrentCell.RowIndex).Value()), CStr(enmDataType.D_int))
                End If
            Else
                If flag <> "save" Then
                    obj.RptShow(enmReportName.RptCreditNotePrint, "CN_ID", CStr(CN_Id), CStr(enmDataType.D_int))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grid_styles()
        If Not dtable_Item_List Is Nothing Then dtable_Item_List.Dispose()

        dtable_Item_List = New DataTable()
        dtable_Item_List.Columns.Add("Item_ID", GetType(System.Int32))
        dtable_Item_List.Columns.Add("Item_Code", GetType(System.String))
        dtable_Item_List.Columns.Add("Item_Name", GetType(System.String))
        dtable_Item_List.Columns.Add("UM_Name", GetType(System.String))
        dtable_Item_List.Columns.Add("Prev_Item_Qty", GetType(System.Double))

        dtable_Item_List.Columns.Add("INV_Qty", GetType(System.Double))
        dtable_Item_List.Columns.Add("Item_Rate", GetType(System.Double))
        dtable_Item_List.Columns.Add("Vat_Per", GetType(System.Double))
        dtable_Item_List.Columns.Add("Item_Qty", GetType(System.Double))
        dtable_Item_List.Columns.Add("Stock_Detail_Id", GetType(System.Double))
        dtable_Item_List.Columns.Add("INvDate", GetType(System.Double))
        dtable_Item_List.Columns.Add("SiNo", GetType(System.Double))



        FLXGRD_MaterialItem.DataSource = dtable_Item_List
        dtable_Item_List.Rows.Add(dtable_Item_List.NewRow)
        FLXGRD_MaterialItem.Cols(0).Width = 10
        SetGridSettingValues()


    End Sub

    Private Sub SetGridSettingValues()

        FLXGRD_MaterialItem.Cols("Item_ID").Visible = False
        FLXGRD_MaterialItem.Cols("Item_Code").Caption = "Item Code"
        FLXGRD_MaterialItem.Cols("Item_Name").Caption = "Item Name"
        FLXGRD_MaterialItem.Cols("UM_Name").Caption = "UOM"
        FLXGRD_MaterialItem.Cols("Prev_Item_Qty").Caption = "Current Stock"
        FLXGRD_MaterialItem.Cols("INV_Qty").Caption = "INV Item Qty"
        FLXGRD_MaterialItem.Cols("Item_Rate").Caption = "Item Rate"
        FLXGRD_MaterialItem.Cols("Vat_Per").Caption = "Tax %"


        FLXGRD_MaterialItem.Cols("Item_Qty").Caption = "Item Qty"

        FLXGRD_MaterialItem.Cols("Stock_Detail_Id").Visible = False

        FLXGRD_MaterialItem.Cols("Item_Code").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Item_Name").AllowEditing = False
        FLXGRD_MaterialItem.Cols("UM_Name").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Prev_Item_Qty").AllowEditing = False
        FLXGRD_MaterialItem.Cols("INV_Qty").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Item_Rate").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Vat_Per").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Item_Qty").AllowEditing = True

        FLXGRD_MaterialItem.Cols("Stock_Detail_Id").AllowEditing = False

        FLXGRD_MaterialItem.Cols("INvDate").Visible = False
        FLXGRD_MaterialItem.Cols("SiNo").Visible = False

        FLXGRD_MaterialItem.Cols("Item_Code").Width = 60
        FLXGRD_MaterialItem.Cols("Item_Name").Width = 300
        FLXGRD_MaterialItem.Cols("UM_Name").Width = 40
        FLXGRD_MaterialItem.Cols("Prev_Item_Qty").Width = 90

        FLXGRD_MaterialItem.Cols("INV_Qty").Width = 90
        FLXGRD_MaterialItem.Cols("Item_Rate").Width = 90
        FLXGRD_MaterialItem.Cols("Vat_Per").Width = 90

        FLXGRD_MaterialItem.Cols("Item_Qty").Width = 100
        FLXGRD_MaterialItem.Cols("Stock_Detail_Id").Width = 200

        Dim cs As C1.Win.C1FlexGrid.CellStyle
        cs = Me.FLXGRD_MaterialItem.Styles.Add("Item_Qty")
        cs.ForeColor = Color.White
        cs.BackColor = Color.Green
        cs.Border.Style = BorderStyleEnum.Raised

        Dim i As Integer
        For i = 1 To FLXGRD_MaterialItem.Rows.Count - 1
            FLXGRD_MaterialItem.SetCellStyle(i, FLXGRD_MaterialItem.Cols("Item_Qty").SafeIndex, cs)
        Next

    End Sub

    Private Sub FLXGRD_MaterialItem_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles FLXGRD_MaterialItem.AfterEdit
        If IsNumeric(FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty")) = True Then
            If FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") > FLXGRD_MaterialItem.Rows(e.Row)("INV_Qty") Then
                FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") = 0
            Else
                FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") = Math.Round(Convert.ToDouble(FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty")), 4)
            End If
        Else
            FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") = 0

        End If
        CalculateAmount()
    End Sub

    Private Sub FLXGRD_MaterialItem_EnterCell(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FLXGRD_MaterialItem.EnterCell
    End Sub

    Private Sub FLXGRD_MaterialItem_RowColChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FLXGRD_MaterialItem.RowColChange
        '  intColumnIndex = fl

    End Sub

    Private Sub FLXGRD_MaterialItem_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FLXGRD_MaterialItem.KeyPress

    End Sub

    Private Sub dgvList_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub dgvList_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub getMRNDetail(ByVal Receive_ID As Integer)


    End Sub

    Private Sub cmbINV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbINVNo.SelectedIndexChanged
        Try
            set_new_initilize()
            Dim ds As DataSet
            Dim INVNo As Int32
            INVNo = Convert.ToInt32(cmbINVNo.SelectedValue)
            ds = clsObj.fill_Data_set("Get_INV_Details_CreditNote", "@Si_ID", INVNo)
            If ds.Tables(0).Rows.Count > 0 Then
                dtable_Item_List = ds.Tables(0).Copy
                FLXGRD_MaterialItem.DataSource = dtable_Item_List
                lblInvdate.Text = ds.Tables(0).Rows(0)(10)
                lblInvNo.Text = ds.Tables(0).Rows(0)(11)
                SetGridSettingValues()
            End If
            TbRMRN.SelectTab(1)
        Catch ex As Exception
            MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
        End Try
    End Sub

    Private Sub frm_DebitNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        set_new_initilize()
        BindCustomerCombo()
        BindINVCombo()
        Grid_styles()
        FillGrid()
    End Sub

    Private Sub BindCustomerCombo()
        obj.ComboBind(cmbCustomer, "select 0 as ACC_ID,'--Select--' as ACC_NAME union Select ACC_ID,ACC_NAME from ACCOUNT_MASTER WHERE AG_ID=1 Order by ACC_NAME ", "ACC_NAME", "ACC_ID")

    End Sub

    Private Sub BindINVCombo()
        Dim Query As String
        Dim Dt As DataTable
        Dim Dtrow As DataRow
        Dim ds As DataSet

        ds = clsObj.FillDataSet("SELECT Isnull(ADDRESS_PRIM +ADDRESS_SEC,'') AS Address FROM dbo.ACCOUNT_MASTER WHERE ACC_ID=" & cmbCustomer.SelectedValue)
        If ds.Tables(0).Rows.Count > 0 Then
            lblAddress.Text = ds.Tables(0).Rows(0)(0)

        End If

        Query = "  SELECT SI_ID,SI_CODE+CAST(SI_NO as varchar(20)) AS SiNo FROM dbo.SALE_INVOICE_MASTER WHERE CUST_ID=" & cmbCustomer.SelectedValue & " and DIVISION_ID = " & v_the_current_division_id
        Dt = clsObj.Fill_DataSet(Query).Tables(0)
        Dtrow = Dt.NewRow
        Dtrow("SI_ID") = -1
        Dtrow("SiNo") = "Select INV No"
        Dt.Rows.InsertAt(Dtrow, 0)
        cmbINVNo.DisplayMember = "SiNo"
        cmbINVNo.ValueMember = "SI_ID"
        cmbINVNo.DataSource = Dt
        cmbINVNo.SelectedIndex = 0

    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        FillGrid(txtSearch.Text.Trim())
    End Sub

    Private Sub cmbCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomer.SelectedIndexChanged
        BindINVCombo()
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


        For i = 1 To FLXGRD_MaterialItem.Rows.Count - 1
            total_item_value = total_item_value + (FLXGRD_MaterialItem.Rows(i).Item("Item_Qty") * FLXGRD_MaterialItem.Rows(i).Item("item_rate"))
            total_vat_amount = total_vat_amount + ((FLXGRD_MaterialItem.Rows(i).Item("item_rate") * FLXGRD_MaterialItem.Rows.Item(i)("Item_Qty")) * FLXGRD_MaterialItem.Rows(i).Item("Vat_Per") / 100)

        Next

        lblAmount.Text = total_item_value.ToString("#0.00")
        lblVatAmount.Text = total_vat_amount.ToString("#0.00")
        lblCredit.Text = (total_item_value + total_vat_amount + total_exice_amount).ToString("#0.00")
        Str = total_item_value.ToString("#0.00") + "," + total_vat_amount.ToString("#0.00") + "," + total_exice_amount.ToString()
        Return Str

    End Function

    Private Sub lnkCalculateDebitAmt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCalculateDebitAmt.LinkClicked
        CalculateAmount()
    End Sub
End Class

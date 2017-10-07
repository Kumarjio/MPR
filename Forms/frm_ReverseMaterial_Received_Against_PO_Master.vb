Imports System.Data.SqlClient
Imports System.Data

Public Class frm_ReverseMaterial_Received_Against_PO_Master

    Implements IForm
    Dim obj As New CommonClass
    Dim clsObj As New ReverseMaterial_Recieved_Against_Po_Master.cls_ReverseMaterial_Recieved_Against_Po_Master
    Dim prpty As New ReverseMaterial_Recieved_Against_Po_Master.cls_ReverseMaterial_Recieved_Against_Po_Master_Prop
    Dim flag As String
    Dim group_id As Integer
    Dim dtable_Item_List As DataTable
    Dim dtable_Item_List_Stockable As DataTable

    Dim dtable As DataTable

    Dim dTable_IndentItems As DataTable
    Dim grdMaterial_Rowindex As Int16
    Dim RMRSID As Int16
    Dim FLXGRD_PO_Items_Rowindex As Int16
    Dim intColumnIndex As Integer
    Dim Pre As String

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
        If cmbMRNNo.Items.Count > 0 Then
            cmbMRNNo.SelectedIndex = 0
        End If
        lbl_ReverseDate.Text = now.ToString("dd/MMM/yyyy")
        lblReverse_Code.Text = GetRMRNCode()
        txtMrnRemarks.Text = ""
        FLXGRD_MaterialItem.DataSource = Nothing
        'FLXGRD_REV_NONSTOCKABLE_ITEMS.DataSource = Nothing
        dtable_Item_List = dgvList.DataSource
        'If dtable_Item_List Is Nothing Then dtable_Item_List.Rows.Clear()
        TbRMRN.SelectTab(1)
        intColumnIndex = -1
        flag = "save"
    End Sub

    Public Function GetRMRNCode() As String

        Dim Pre As String ' Store RMRN prefix 
        Dim RPMRNID As String 'store new Reverse no.
        Dim RPMRNCode As String
        Pre = obj.getPrefixCode("RPMRN_Prefix", "DIVISION_SETTINGS")
        RPMRNID = obj.getMaxValue("Reverse_ID", "ReverseMATERIAL_RECIEVED_Against_PO_MASTER")
        RPMRNCode = Pre & "" & RPMRNID
        Return RPMRNCode

    End Function
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
            obj.GridBind(dgvList, "SELECT  RMM.Reverse_ID,RMM.Reverse_Code + CAST(Reverse_No AS VARCHAR(20)) AS ReverseNo,dbo.fn_format(RMM.Reverse_Date) as Reverse_Date,MM.MRN_PREFIX + CAST(MM.mrn_no AS VARCHAR(20)) AS MRN_NO,MM.Receipt_Date AS  MRN_DATE,dbo.ACCOUNT_MASTER.ACC_NAME AS Vendor,RMM.Remarks AS Reverse_Remarks  FROM    ReverseMATERIAL_RECIEVED_Against_PO_MASTER RMM INNER JOIN MATERIAL_RECEIVED_AGAINST_PO_MASTER MM  INNER JOIN dbo.PO_MASTER ON dbo.PO_MASTER.PO_ID = mm.PO_ID INNER JOIN dbo.ACCOUNT_MASTER ON dbo.ACCOUNT_MASTER.ACC_ID = dbo.PO_MASTER.PO_SUPP_ID ON MM.Receipt_ID = RMM.received_ID " & condition & "    order by Reverse_No desc")
            dgvList.Width = 1000
            dgvList.Columns("Reverse_ID").Visible = False 'Reverse_ID
            dgvList.Columns(0).Visible = False 'Reverse_ID
            dgvList.Columns("Reverse_ID").HeaderText = "Reverse_ID"
            dgvList.Columns("Reverse_ID").Width = 10
            'dgvList.Columns(1).HeaderText = "Reverse_ID"
            'dgvList.Columns(1).Width = 150
            dgvList.Columns("ReverseNo").HeaderText = "Reverse No"
            dgvList.Columns("ReverseNo").Width = 100

            dgvList.Columns("Reverse_Date").HeaderText = "Reverse Date"
            dgvList.Columns("Reverse_Date").Width = 120

            dgvList.Columns("MRN_NO").HeaderText = "MRN No."
            dgvList.Columns("MRN_NO").Width = 100

            dgvList.Columns("MRN_DATE").HeaderText = "MRN Date"
            dgvList.Columns("MRN_DATE").Width = 115

            dgvList.Columns("Vendor").HeaderText = "Vendor"
            dgvList.Columns("Vendor").Width = 250

            dgvList.Columns("Reverse_Remarks").HeaderText = "Reverse Remarks"
            dgvList.Columns("Reverse_Remarks").Width = 150
        Catch ex As Exception
            MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
        End Try
    End Sub
    Public Sub RefreshClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.RefreshClick
        FillGrid()
        TbRMRN.SelectTab(0)
    End Sub
    Private Function validation() As Boolean
        validation = True
        Dim int_RowIndex As Int32
        Dim iindex As Int32
        Dim blnIsExist As Boolean
        Dim dtCheck As New DataTable

        lblReverse_Code.Focus() ' to execute grid's after exist event 
        If cmbMRNNo.SelectedIndex <= 0 Then
            MsgBox("Select MRN No.", vbExclamation, gblMessageHeading)
            validation = False
            cmbMRNNo.Focus()
            Exit Function
        End If
        blnIsExist = False
        dtCheck = FLXGRD_MaterialItem.DataSource
        int_RowIndex = dtCheck.Rows.Count
        For iindex = 0 To int_RowIndex - 1
            'atleast one record exist for saving
            If dtCheck.Rows(iindex)("Item_Qty") >= 0 Then
                blnIsExist = True
            End If
            ''Check there should be enough balance qty in stock to made changes
            'If dtCheck.Rows(iindex)("Item_Qty") - dtCheck.Rows(iindex)("Prev_Item_Qty") + dtCheck.Rows(iindex)("Balance_Qty") < 0 Then
            '    validation()
            'End If
        Next iindex

        If blnIsExist = False Then
            validation = False
            MsgBox("enter atleast one reverse quantity.", vbExclamation, gblMessageHeading)
            Exit Function
        End If
    End Function
    Public Sub SaveClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.SaveClick
        Dim cmd As SqlCommand
        If _rights.allow_trans = "N" Then
            RightsMsg()
            Exit Sub
        End If

        '' ''If validation() = False Then
        '' ''    Exit Sub
        '' ''End If
        FLXGRD_MaterialItem.FinishEditing()
        FLXGRD_REV_NONSTOCKABLE_ITEMS.FinishEditing()

        Dim dtDetail As New DataTable
        dtDetail = FLXGRD_MaterialItem.DataSource

        Dim dtDetail_REV_NON_STOCKABLE_ITEMS As New DataTable
        dtDetail_REV_NON_STOCKABLE_ITEMS = FLXGRD_REV_NONSTOCKABLE_ITEMS.DataSource

        For rowcount As Integer = rowcount To dtDetail.Rows.Count - 1
            If Convert.ToDouble(dtDetail.Rows(rowcount)("Item_Rate")) <= 0 Then
                MsgBox("Item Rate cannot be zero.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Next

        For rowcount As Integer = rowcount To dtDetail_REV_NON_STOCKABLE_ITEMS.Rows.Count - 1
            If Convert.ToDouble(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(rowcount)("Item_Rate")) <= 0 Then
                MsgBox("Item Rate cannot be zero.", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Next

        cmd = obj.MyCon_BeginTransaction
        Try
            If flag = "save" Then
                Dim RMRN_ID As Integer
                Dim RMRN_Code As String
                RMRN_Code = obj.getPrefixCode("RMRN_PREFIX", "DIVISION_SETTINGS")
                RMRN_ID = Convert.ToInt32(obj.getMaxValue("Reverse_ID", "REVERSEMATERIAL_RECIEVED_Against_PO_MASTER"))
                'If grdMRNDetail.Rows.Count - 1 Then
                prpty.Reverse_ID = RMRN_ID
                prpty.Reverse_Code = RMRN_Code  ' GetRMRSCode()
                prpty.Reverse_No = RMRN_ID
                prpty.received_ID = cmbMRNNo.SelectedValue
                prpty.Reverse_Date = Now 'Convert.ToDateTime(dtpMIODate.Text).ToString()
                prpty.Remarks = txtMrnRemarks.Text
                prpty.Created_By = v_the_current_logged_in_user_name
                prpty.Creation_Date = now
                prpty.Modified_By = v_the_current_logged_in_user_name
                prpty.Modification_Date = now
                prpty.Division_ID = v_the_current_division_id
                clsObj.insert_ReverseMATERIAL_RECIEVED_Against_PO_MASTER(prpty, cmd)

                Dim iRowCount As Int32
                Dim iRow As Int32


                'Dim dtDetail As New DataTable
                'dtDetail = FLXGRD_MaterialItem.DataSource
                iRowCount = dtDetail.Rows.Count
                For iRow = 0 To iRowCount - 1
                    If (dtDetail.Rows(iRow)("Prev_Item_Qty") - dtDetail.Rows(iRow)("Item_Qty")) <> 0 Or (dtDetail.Rows(iRow)("Prev_Item_vat") - dtDetail.Rows(iRow)("Vat_Per")) <> 0 Then
                        prpty.Reverse_ID = RMRN_ID
                        prpty.Item_ID = dtDetail.Rows(iRow)("Item_Id")
                        prpty.Prev_Item_Qty = Convert.ToDouble(dtDetail.Rows(iRow)("Prev_Item_Qty")) '.ToString()
                        prpty.Item_Qty = Convert.ToDouble(dtDetail.Rows(iRow)("Item_Qty")) '.ToString()
                        prpty.Prev_Item_Rate = Convert.ToDouble(dtDetail.Rows(iRow)("Prev_Item_Rate"))
                        prpty.Item_Rate = Convert.ToDouble(dtDetail.Rows(iRow)("Item_Rate"))
                        prpty.Prev_Item_vat = Convert.ToDouble(dtDetail.Rows(iRow)("Prev_Item_vat"))
                        prpty.Item_vat = Convert.ToDouble(dtDetail.Rows(iRow)("Vat_Per"))
                        If dtDetail.Rows(iRow)("Prev_Item_exice").ToString() = "" Then
                            prpty.Prev_Item_exice = 0
                        Else
                            prpty.Prev_Item_exice = Convert.ToDouble(dtDetail.Rows(iRow)("Prev_Item_exice"))
                        End If
                        If dtDetail.Rows(iRow)("exe_per").ToString() = "" Then
                            prpty.Item_exice = 0
                        Else
                            prpty.Item_exice = Convert.ToDouble(dtDetail.Rows(iRow)("exe_Per"))
                        End If

                        prpty.StockDetail_Id = Convert.ToDouble(dtDetail.Rows(iRow)("Stock_Detail_Id"))
                        prpty.Batch_No = dtDetail.Rows(iRow)("Batch_No").ToString()
                        prpty.Expiry_Date = Convert.ToDateTime(dtDetail.Rows(iRow)("Expiry_Date"))
                        prpty.TransType = Transaction_Type.ReverseMaterialRecievedAgainstPO
                        prpty.MRNId = cmbMRNNo.SelectedValue

                        'prpty.TransDate = now
                        prpty.TransType = Transaction_Type.ReverseMaterialRecievedAgainstPO
                        clsObj.insert_ReverseMATERIAL_RECIEVED_Against_PO_Detail(prpty, cmd)


                    End If
                Next iRow


                '--------------------------------------------------------'
                '-------ENTRY INTO REVERSE_NON_STOCKABLE_ITEMS_AGAINST_PO-----------'
                '--------------------------------------------------------'
                'Dim dtDetail_REV_NON_STOCKABLE_ITEMS As New DataTable
                ' dtDetail_REV_NON_STOCKABLE_ITEMS = FLXGRD_REV_NONSTOCKABLE_ITEMS.DataSource
                iRowCount = dtDetail_REV_NON_STOCKABLE_ITEMS.Rows.Count
                For iRow = 0 To iRowCount - 1
                    prpty.Reverse_ID = RMRN_ID
                    prpty.Item_ID = dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Item_Id")
                    prpty.CostCenter_ID = dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("CostCenter_ID")
                    prpty.Item_Qty = Convert.ToDouble(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Item_Qty")) '.ToString()
                    prpty.Item_Rate = Convert.ToDouble(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Item_Rate"))
                    prpty.Item_vat = Convert.ToDouble(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Vat_Per"))
                    prpty.Item_exice = Convert.ToDouble(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("exe_Per"))
                    prpty.Prev_Item_Qty = Convert.ToDouble(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Prev_Item_Qty"))
                    prpty.Prev_Item_Rate = Convert.ToDouble(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Prev_Item_Rate"))
                    prpty.Prev_Item_vat = Convert.ToDouble(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Prev_Item_vat"))
                    prpty.Prev_Item_exice = Convert.ToDouble(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Prev_Item_exice"))
                    prpty.Batch_No = dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Batch_No").ToString()
                    prpty.Expiry_Date = Convert.ToDateTime(dtDetail_REV_NON_STOCKABLE_ITEMS.Rows(iRow)("Expiry_Date"))
                    prpty.MRNId = cmbMRNNo.SelectedValue


                    'prpty.TransDate = now
                    prpty.TransType = Transaction_Type.MaterialReturnAgainstIssue
                    clsObj.insert_ReverseNON_STOCKABLE_MATERIAL_RECIEVED_WITHOUT_PO(prpty, cmd)


                Next iRow
                '--------------------------------------------------------'
                '-------ENTRY INTO REVERSE_NON_STOCKABLE_ITEMS_AGAINST_PO-----------'
                '--------------------------------------------------------'
            End If
            obj.MyCon_CommitTransaction(cmd)
            If flag = "save" Then
                Dim Msg As String = "Reverse Material infromation saved with no. " & prpty.Reverse_Code & prpty.Reverse_No
                If MsgBox(Msg & vbCrLf & "Do You Want to Print Preview.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, gblMessageHeading) = MsgBoxResult.Yes Then
                    obj.RptShow(enmReportName.RptReverseMaterialAgainstPO, "reverse_id", CStr(prpty.Reverse_ID), CStr(enmDataType.D_int))
                End If
                set_new_initilize()
                FillGrid()
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
        CCID = obj.getMaxValue("Reverse_ID", "REVERSEMATERIAL_RECIEVED_Against_PO_MASTER")
        POCode = Pre & "" & CCID
        Return POCode
    End Function
    Public Sub ViewClick(ByVal sender As Object, ByVal e As System.EventArgs) Implements IForm.ViewClick
        'Try
        '    If TbRMRN.SelectedIndex = 0 Then
        '        obj.RptShow(enmReportName.RptReverseMaterialAgainstPO, "Reverse_ID", CStr(dgvList("Reverse_ID", dgvList.CurrentCell.RowIndex).Value()), CStr(enmDataType.D_int))
        '    Else
        '        If flag <> "save" Then
        '            obj.RptShow(enmReportName.RptReverseMaterialAgainstPO, "Reverse_ID", CStr(dgvList("Reverse_ID", dgvList.CurrentCell.RowIndex).Value()), CStr(enmDataType.D_int))
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        Try
            'If TbRMRN.SelectedIndex = 0 Then
            If FLXGRD_MaterialItem.Rows.Count > 0 Then
                obj.RptShow(enmReportName.RptReverseMaterialAgainstPO, "Reverse_ID", CStr(dgvList("Reverse_ID", dgvList.CurrentCell.RowIndex).Value()), CStr(enmDataType.D_int))
            Else
                MsgBox("No Records To Print", MsgBoxStyle.Information, gblMessageHeading)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'obj.RptShow(35, "Recieved_ID", CStr("1"), CStr(enmDataType.D_int))
    End Sub
    Private Sub Grid_styles()
        If Not dtable_Item_List Is Nothing Then dtable_Item_List.Dispose()

        dtable_Item_List = New DataTable()
        dtable_Item_List.Columns.Add("Item_ID", GetType(System.Int32))
        dtable_Item_List.Columns.Add("Item_Code", GetType(System.String))
        dtable_Item_List.Columns.Add("Item_Name", GetType(System.String))
        dtable_Item_List.Columns.Add("UM_Name", GetType(System.String))
        dtable_Item_List.Columns.Add("Prev_Item_Qty", GetType(System.Double))
        dtable_Item_List.Columns.Add("Item_Qty", GetType(System.Double))
        dtable_Item_List.Columns.Add("Prev_Item_Rate", GetType(System.Double))
        dtable_Item_List.Columns.Add("Item_Rate", GetType(System.Double))
        dtable_Item_List.Columns.Add("Prev_Item_vat", GetType(System.Double))
        dtable_Item_List.Columns.Add("Vat_Per", GetType(System.Double))
        dtable_Item_List.Columns.Add("Prev_Item_exice", GetType(System.Double))
        dtable_Item_List.Columns.Add("exe_Per", GetType(System.Double))
        dtable_Item_List.Columns.Add("Batch_No", GetType(System.String))
        dtable_Item_List.Columns.Add("Expiry_Date", GetType(System.DateTime))
        dtable_Item_List.Columns.Add("Stock_Detail_Id", GetType(System.Double))
        dtable_Item_List.Columns.Add("Balance_Qty", GetType(System.Double))
        FLXGRD_MaterialItem.DataSource = dtable_Item_List

        dtable_Item_List_Stockable = New DataTable()
        dtable_Item_List_Stockable.Columns.Add("Item_ID", GetType(System.Int32))
        dtable_Item_List_Stockable.Columns.Add("CostCenter_Id", GetType(System.Int32))
        dtable_Item_List_Stockable.Columns.Add("CostCenter_Code", GetType(System.String))
        dtable_Item_List_Stockable.Columns.Add("Item_Code", GetType(System.String))
        dtable_Item_List_Stockable.Columns.Add("Item_Name", GetType(System.String))
        dtable_Item_List_Stockable.Columns.Add("UM_Name", GetType(System.String))
        dtable_Item_List_Stockable.Columns.Add("CostCenter_Name", GetType(System.String))
        dtable_Item_List_Stockable.Columns.Add("Prev_Item_Qty", GetType(System.Double))
        dtable_Item_List_Stockable.Columns.Add("Item_Qty", GetType(System.Double))
        dtable_Item_List_Stockable.Columns.Add("Prev_Item_Rate", GetType(System.Double))
        dtable_Item_List_Stockable.Columns.Add("Item_Rate", GetType(System.Double))
        dtable_Item_List_Stockable.Columns.Add("Prev_Item_vat", GetType(System.Double))
        dtable_Item_List_Stockable.Columns.Add("Vat_Per", GetType(System.Double))
        dtable_Item_List_Stockable.Columns.Add("Prev_Item_exice", GetType(System.Double))
        dtable_Item_List_Stockable.Columns.Add("exe_Per", GetType(System.Double))
        dtable_Item_List_Stockable.Columns.Add("Batch_No", GetType(System.String))
        dtable_Item_List_Stockable.Columns.Add("Expiry_Date", GetType(System.DateTime))
        'dtable_Item_List_Stockable.Columns.Add("Stock_Detail_Id", GetType(System.Double))
        'dtable_Item_List_Stockable.Columns.Add("Balance_Qty", GetType(System.Double))
        'FLXGRD_REV_NONSTOCKABLE_ITEMS.DataSource = dtable_Item_List_Stockable


        dtable_Item_List.Rows.Add(dtable_Item_List.NewRow)
        FLXGRD_MaterialItem.Cols(0).Width = 10

        dtable_Item_List_Stockable.Rows.Add(dtable_Item_List_Stockable.NewRow)
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols(0).Width = 10
        FLXGRD_REV_NONSTOCKABLE_ITEMS.DataSource = dtable_Item_List_Stockable


        SetGridSettingValues()


    End Sub
    Private Sub SetGridSettingValues()

        FLXGRD_MaterialItem.Cols("Item_ID").Visible = False
        FLXGRD_MaterialItem.Cols("Item_Code").Caption = "Item Code"
        FLXGRD_MaterialItem.Cols("Item_Name").Caption = "Item Name"
        FLXGRD_MaterialItem.Cols("UM_Name").Caption = "UOM"
        FLXGRD_MaterialItem.Cols("Prev_Item_Qty").Caption = "Prev Item Qty"
        FLXGRD_MaterialItem.Cols("Item_Qty").Caption = "Item Qty"
        FLXGRD_MaterialItem.Cols("Prev_Item_Rate").Caption = "Prev Item Rate"
        FLXGRD_MaterialItem.Cols("Item_Rate").Caption = "Item Rate"
        FLXGRD_MaterialItem.Cols("Prev_Item_vat").Caption = "Prev GST%"
        FLXGRD_MaterialItem.Cols("Vat_Per").Caption = "GST%"

        FLXGRD_MaterialItem.Cols("Prev_Item_exice").Caption = "Prev EXICE%"
        FLXGRD_MaterialItem.Cols("exe_Per").Caption = "EXICE%"
        FLXGRD_MaterialItem.Cols("Prev_Item_exice").Visible = False
        FLXGRD_MaterialItem.Cols("exe_Per").Visible = False




        FLXGRD_MaterialItem.Cols("BATCH_NO").Caption = "Batch No."
        FLXGRD_MaterialItem.Cols("EXPIRY_DATE").Caption = "Expiry Date"

        FLXGRD_MaterialItem.Cols("Prev_Item_Rate").Visible = False
        FLXGRD_MaterialItem.Cols("Prev_Item_vat").Visible = True
        FLXGRD_MaterialItem.Cols("Vat_Per").Visible = True
        FLXGRD_MaterialItem.Cols("Prev_Item_exice").Visible = True
        FLXGRD_MaterialItem.Cols("exe_Per").Visible = True
        FLXGRD_MaterialItem.Cols("BATCH_NO").Visible = False
        FLXGRD_MaterialItem.Cols("EXPIRY_DATE").Visible = False

        FLXGRD_MaterialItem.Cols("Stock_Detail_Id").Visible = False
        FLXGRD_MaterialItem.Cols("Balance_Qty").Visible = True


        FLXGRD_MaterialItem.Cols("Item_Code").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Item_Name").AllowEditing = False
        FLXGRD_MaterialItem.Cols("UM_Name").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Prev_Item_Qty").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Item_Qty").AllowEditing = True
        FLXGRD_MaterialItem.Cols("Prev_Item_Rate").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Item_Rate").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Prev_Item_vat").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Vat_Per").AllowEditing = True
        FLXGRD_MaterialItem.Cols("Prev_Item_exice").AllowEditing = False
        FLXGRD_MaterialItem.Cols("exe_Per").AllowEditing = False
        FLXGRD_MaterialItem.Cols("BATCH_NO").AllowEditing = False
        FLXGRD_MaterialItem.Cols("EXPIRY_DATE").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Stock_Detail_Id").AllowEditing = False
        FLXGRD_MaterialItem.Cols("Balance_Qty").AllowEditing = False

        FLXGRD_MaterialItem.Cols("Item_Code").Width = 60
        FLXGRD_MaterialItem.Cols("Item_Name").Width = 150
        FLXGRD_MaterialItem.Cols("UM_Name").Width = 40
        FLXGRD_MaterialItem.Cols("Prev_Item_Qty").Width = 90
        FLXGRD_MaterialItem.Cols("Item_Qty").Width = 60
        FLXGRD_MaterialItem.Cols("Prev_Item_Rate").Width = 90
        FLXGRD_MaterialItem.Cols("Item_Rate").Width = 60
        FLXGRD_MaterialItem.Cols("Prev_Item_vat").Width = 90
        FLXGRD_MaterialItem.Cols("Vat_Per").Width = 60
        FLXGRD_MaterialItem.Cols("Prev_Item_exice").Width = 90
        FLXGRD_MaterialItem.Cols("exe_Per").Width = 60
        FLXGRD_MaterialItem.Cols("BATCH_NO").Width = 60
        FLXGRD_MaterialItem.Cols("EXPIRY_DATE").Width = 90
        FLXGRD_MaterialItem.Cols("Stock_Detail_Id").Width = 20
        FLXGRD_MaterialItem.Cols("Balance_Qty").Width = 100

        FLXGRD_MaterialItem.Rows(0).Height = 30
        '---------------Non Stockable Grid Formating ---------------'

        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_ID").Visible = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("CostCenter_Id").Visible = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("CostCenter_Code").Visible = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Code").Caption = "Item Code"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Name").Caption = "Item Name"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("UM_Name").Caption = "UOM"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("CostCenter_Name").Caption = "CostCenter"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_Qty").Caption = "Prev Item Qty"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Qty").Caption = "Item Qty"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_Rate").Caption = "Prev Item Rate"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Rate").Caption = "Item Rate"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_vat").Caption = "Prev GST%"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Vat_Per").Caption = "GST%"

        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_exice").Caption = "Prev EXICE%"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("exe_Per").Caption = "EXICE%"
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_exice").Visible = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("exe_Per").Visible = False





        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("BATCH_NO").Caption = "Batch No."
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("EXPIRY_DATE").Caption = "Expiry Date"
        'FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Stock_Detail_Id").Visible = False
        'FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Balance_Qty").Visible = True


        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Code").AllowEditing = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Name").AllowEditing = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("UM_Name").AllowEditing = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("CostCenter_Name").AllowEditing = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_Qty").AllowEditing = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Qty").AllowEditing = True
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_Rate").AllowEditing = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Rate").AllowEditing = True
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_vat").AllowEditing = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Vat_Per").AllowEditing = True
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_exice").AllowEditing = False
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("exe_Per").AllowEditing = True
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("BATCH_NO").AllowEditing = True
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("EXPIRY_DATE").AllowEditing = True
        'FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Stock_Detail_Id").AllowEditing = False
        'FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Balance_Qty").AllowEditing = False

        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Code").Width = 40
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Name").Width = 110
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("UM_Name").Width = 30
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("CostCenter_Name").Width = 90
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_Qty").Width = 60
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Qty").Width = 60
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_Rate").Width = 60
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Item_Rate").Width = 60
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_vat").Width = 60
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Vat_Per").Width = 60
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Prev_Item_exice").Width = 60
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("exe_Per").Width = 60
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("BATCH_NO").Width = 60
        FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("EXPIRY_DATE").Width = 90
        'FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Stock_Detail_Id").Width = 20
        'FLXGRD_REV_NONSTOCKABLE_ITEMS.Cols("Balance_Qty").Width = 100

        FLXGRD_REV_NONSTOCKABLE_ITEMS.Rows(0).Height = 30


    End Sub

    Private Sub FLXGRD_MaterialItem_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles FLXGRD_MaterialItem.AfterEdit
        'New Item qry-Prev Item Qty + Actual Balance Qty >=0
        If FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") - FLXGRD_MaterialItem.Rows(e.Row)("Prev_Item_Qty") + FLXGRD_MaterialItem.Rows(e.Row)("Balance_Qty") < 0 Then
            FLXGRD_MaterialItem.Rows(e.Row)("Item_Qty") = FLXGRD_MaterialItem.Rows(e.Row)("Prev_Item_Qty")
        End If
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

    Private Sub cmbMRNNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMRNNo.SelectedIndexChanged
        Try
            ' set_new_initilize()
            Dim ds As DataSet
            Dim MRNNo As Int32
            MRNNo = Convert.ToInt32(cmbMRNNo.SelectedValue)
            ds = clsObj.fill_Data_set("Get_MRN_AgainstPO_Details", "@V_Receive_ID", MRNNo)
            If ds.Tables.Count > 0 Then
                dtable_Item_List = ds.Tables(0).Copy
                FLXGRD_MaterialItem.DataSource = dtable_Item_List

                dtable_Item_List_Stockable = ds.Tables(1).Copy
                FLXGRD_REV_NONSTOCKABLE_ITEMS.DataSource = dtable_Item_List_Stockable


                SetGridSettingValues()
            End If
            TbRMRN.SelectTab(1)
        Catch ex As Exception
            MsgBox(gblMessageHeading_Error & vbCrLf & gblMessage_ContactInfo & vbCrLf & ex.Message, MsgBoxStyle.Critical, gblMessageHeading)
        End Try
    End Sub

    Private Sub frm_ReverseMaterial_Received_Against_PO_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindMRNCombo()
        Grid_styles()
        FillGrid()
        set_new_initilize()
    End Sub

    Private Sub BindMRNCombo()
        Try

            RemoveHandler cmbMRNNo.SelectedIndexChanged, AddressOf cmbMRNNo_SelectedIndexChanged
            Dim Query As String
            Dim Dt As DataTable
            Dim Dtrow As DataRow
            Query = " SELECT Receipt_ID,MRN_PREFIX + CAST(MRN_NO AS VARCHAR(20)) AS Received_NO FROM MATERIAL_RECEIVED_AGAINST_PO_MASTER WHERE Division_ID =   " & v_the_current_division_id & " order by Received_NO"
            Dt = clsObj.Fill_DataSet(Query).Tables(0)
            Dtrow = Dt.NewRow
            Dtrow("Receipt_ID") = -1
            Dtrow("Received_NO") = "--Select MRN--"
            Dt.Rows.InsertAt(Dtrow, 0)
            cmbMRNNo.DisplayMember = "Received_NO"
            cmbMRNNo.ValueMember = "Receipt_ID"
            cmbMRNNo.DataSource = Dt
            cmbMRNNo.SelectedIndex = 0

            AddHandler cmbMRNNo.SelectedIndexChanged, AddressOf cmbMRNNo_SelectedIndexChanged

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgvList_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvList.DoubleClick
        'Dim Reverse_Id As Integer
        'Dim dtMaster As New DataTable
        'Dim dtDetail As New DataTable
        'Dim ds As New DataSet


        'Reverse_Id = Convert.ToInt32(dgvListRows.Rows(e.RowIndex).Cells("ITEM_ID").Value)
        'flag = "update"
        'ds = obj.fill_Data_set("Get_ReverseMaterial_Issue_FillDetail", "@V_RMIO_ID", Reverse_Id)

        'If ds.Tables.Count > 0 Then

        '    dtMaster = ds.Tables(0)

        '    cmbMRNNo.SelectedValue = dtMaster.Rows(0)("Issue_Id")

        '    txtMrnRemarks.Text = dtMaster.Rows(0)("RMIO_REMARKS")



        '    dtable_Item_List = ds.Tables(1).Copy
        '    FLXGRD_MaterialItem.DataSource = dtable_Item_List

        '    TbRMRN.SelectTab(1)

        '    ds.Dispose()
        'End If
    End Sub

    Private Sub dgvList_CellDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellDoubleClick
        Dim reverseId As Integer

        Dim dtMaster As New DataTable
        Dim dtDetail As New DataTable
        Dim ds As New DataSet
        If e.RowIndex <> -1 Then
            reverseId = dgvList.Rows(e.RowIndex).Cells("Reverse_ID").Value
            flag = "update"
            ds = obj.fill_Data_set("GET_ReverseMaterial_received_Against_PO_info", "@v_ReverseId", reverseId)

            If ds.Tables.Count > 0 Then

                dtMaster = ds.Tables(0)

                cmbMRNNo.SelectedValue = dtMaster.Rows(0)("Received_ID")
                lblReverse_Code.Text = dtMaster.Rows(0)("Reverse_Code") & dtMaster.Rows(0)("Reverse_No")
                txtMrnRemarks.Text = dtMaster.Rows(0)("Remarks")



                dtable_Item_List = ds.Tables(1).Copy
                FLXGRD_MaterialItem.DataSource = dtable_Item_List
                SetGridSettingValues()
                TbRMRN.SelectTab(1)

                ds.Dispose()
            End If
            TbRMRN.SelectTab(1)
        Else
            reverseId = 0
        End If
    End Sub

    Private Sub dgvList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvList.CellContentClick

    End Sub


    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Try
            'Call obj.GridBind(dgvList, "SELECT ITEM_MASTER.ITEM_ID,ITEM_MASTER.ITEM_CODE," _
            '  & " ITEM_MASTER.ITEM_NAME,UNIT_MASTER.UM_Name,ITEM_CATEGORY.ITEM_CAT_NAME FROM ITEM_MASTER " _
            '  & " INNER JOIN  UNIT_MASTER ON ITEM_MASTER.UM_ID = UNIT_MASTER.UM_ID INNER JOIN ITEM_CATEGORY " _
            '  & " ON ITEM_MASTER.ITEM_CATEGORY_ID = ITEM_CATEGORY.ITEM_CAT_ID where (item_master.item_code + " _
            '& " item_master.item_name + ITEM_CATEGORY.item_cat_name + UNIT_MASTER.um_name ) " _
            '& " like '%" & txtSearch.Text & "%'")
            Dim condition As String
            condition = "WHERE (ISNULL(RMM.Reverse_Code + CAST(Reverse_No AS VARCHAR(20)),'') + ISNULL(MM.MRN_PREFIX + CAST(MM.MRN_NO AS VARCHAR(20)),'') + ISNULL(ACCOUNT_MASTER.ACC_NAME ,'')) LIKE '%" & txtSearch.Text.Trim & "%'"
            FillGrid(condition)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error --> FillGrid")

        End Try
    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub
End Class

Imports LFERP.Library.Production.Datasetting
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.Library.ProductionField
Imports LFERP.Library.Production.ProductionFieldDaySummary
Imports LFERP.Library.WareHouse
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.Production.ProductionAffair

Public Class frmProductionFieldCode1
    Dim ds As New DataSet
    Dim mc As New ProductionDataSettingControl
    Dim mpc As New ProductController
    Dim ppc As New ProcessMainControl

    Private Sub frmProductionFieldCode1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()      '調用創建表過程
        dteFP_Date.EditValue = Now
    End Sub

    ''' <summary>
    ''' 創建表
    ''' </summary>
    ''' 此過程被以下過程調用
    ''' frmProductionFieldCode1_Load()
    Sub CreateTable()
        With ds.Tables.Add("Production")
            .Columns.Add("Pro_Type", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))

            .Columns.Add("PS_Name1", GetType(String))
            .Columns.Add("FP_OutType", GetType(String))
            .Columns.Add("FP_Qty", GetType(Integer))
            .Columns.Add("FP_Weight", GetType(Single))
            .Columns.Add("WI_Qty", GetType(Integer))

            .Columns.Add("PO_NO", GetType(String))
            .Columns.Add("FP_Remark", GetType(String))
        End With
        Grid.DataSource = ds.Tables("Production")


    End Sub

    ''' <summary>
    ''' 生成收發單號
    ''' </summary>
    ''' <returns></returns>
    ''' 此函數被以下過程調用
    ''' btnOK_Click()
    Function GetNO() As String

        Dim pi As New ProductionFieldInfo
        Dim pc As New ProductionFieldControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionField_GetNO(strA)

        If pi Is Nothing Then
            GetNO = "PF" & strA & "000001"
        Else
            GetNO = "PF" + strA + Mid((CInt(Mid(pi.FP_NO, 7)) + 1000001), 2)
        End If

    End Function
    ''' <summary>
    ''' 生成流水號
    ''' </summary>
    ''' <returns></returns>
    ''' 此函數被以下過程調用
    ''' btnOK_Click()
    Function GetNum() As String

        Dim pi As New ProductionFieldInfo
        Dim pc As New ProductionFieldControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionField_GetNO(strA)

        If pi Is Nothing Then
            GetNum = strA & "000001"
        Else
            GetNum = strA + Mid((CInt(Mid(pi.FP_Num, 5)) + 1000001), 2)
        End If

    End Function
    ''' <summary>
    ''' 單擊右鍵菜單"添加"
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click
        Dim row As DataRow
        row = ds.Tables("Production").NewRow

        row("Pro_Type") = rcboPro_type.Items.Item(0)
        row("FP_OutType") = rcboFP_OutType.Items.Item(0)
        row("FP_Qty") = 0
        row("FP_Weight") = 0
        row("WI_Qty") = 0

        row("PO_NO") = ""
        row("FP_Remark") = ""

        ds.Tables("Production").Rows.Add(row)

        rgluPM_M_Code.DisplayMember = "PM_M_Code"
        rgluPM_M_Code.ValueMember = "PM_M_Code"
        If mc.ProductionUser_GetList(txtDepID_Out.Tag, Nothing).Count > 0 Then            '判斷是否有權限限制,減少載入數據
            rgluPM_M_Code.DataSource = mc.ProductionUser_GetList(txtDepID_Out.Tag, Nothing)
        Else
            rgluPM_M_Code.DataSource = ppc.ProcessMain_GetList3(Nothing, Nothing)
        End If

    End Sub
    ''' <summary>
    ''' 單擊右鍵"刪除"菜單,刪除選中行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDelete.Click
        If GridView1.RowCount = 0 Then Exit Sub

        ds.Tables("Production").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))

    End Sub
    ''' <summary>
    ''' 產品編號改變時,重新賦值
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rgluPM_M_Code_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rgluPM_M_Code.EditValueChanged
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("PM_Type") = ""
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("PS_Name") = ""
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("PS_Name1") = ""
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("FP_Qty") = 0
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("FP_Weight") = 0
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("WI_Qty") = 0
        gridPS_NO.DataSource = Nothing
        GridView1.Focus()
    End Sub
    ''' <summary>
    ''' 單擊取消按鈕,退出窗體
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 單擊類型表格,傳值到主表格
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用:
    ''' gridPM_Type_View_KeyDown()
    Private Sub gridPM_Type_View_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridPM_Type_View.Click
        On Error Resume Next

        If gridPM_Type_View.RowCount > 0 Then
            GridView1.SetFocusedRowCellValue(PM_Type, gridPM_Type_View.GetFocusedRowCellValue("Type3ID"))       '傳值
            PopupContainerControl1.OwnerEdit.ClosePopup()
            GridView1.Focus()
        End If
        '重新賦值
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("PS_Name") = ""
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("PS_Name1") = ""
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("FP_Qty") = 0
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("FP_Weight") = 0
        ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("WI_Qty") = 0
    End Sub
    ''' <summary>
    ''' 單擊工序表格,傳值到主表格
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用:
    ''' gridPS_NO_View_KeyDown()
    Private Sub gridPS_NO_View_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridPS_NO_View.Click
        On Error Resume Next
        If gridPS_NO_View.RowCount > 0 Then
            Dim i%
            '判斷主表格中是否已存在相同工序
            For i = 0 To ds.Tables("Production").Rows.Count - 1
                '工序為空且行號與焦點行相等時不進行判斷
                If IsDBNull(ds.Tables("Production").Rows(i)("PS_NO")) = False And i <> GridView1.FocusedRowHandle Then
                    If ds.Tables("Production").Rows(i)("PS_NO") = gridPS_NO_View.GetFocusedRowCellValue("PS_NO") Then
                        PopupContainerControl2.OwnerEdit.ClosePopup()
                        MsgBox("工序已存在,不能添加相同的工序!", 64, "提示")
                        Exit Sub
                    End If
                End If
            Next

            '選擇工序與原工序相等時不重新賦值
            If gridPS_NO_View.GetFocusedRowCellValue("PS_NO") <> GridView1.GetFocusedRowCellValue("PS_NO") Then
                GridView1.SetFocusedRowCellValue(FP_Qty, 0)
                GridView1.SetFocusedRowCellValue(FP_Weight, 0)
                GridView1.SetFocusedRowCellValue(PS_Name, gridPS_NO_View.GetFocusedRowCellValue("PS_Name"))
                GridView1.SetFocusedRowCellValue(PS_Name1, gridPS_NO_View.GetFocusedRowCellValue("PS_Name"))
                GridView1.SetFocusedRowCellValue(PS_NO, gridPS_NO_View.GetFocusedRowCellValue("PS_NO"))
            End If
            PopupContainerControl2.OwnerEdit.ClosePopup()
            GridView1.Focus()

            '查找當前工序的部門庫存數,並賦給結余數量
            Dim fdc As New ProductionDPTWareInventoryControl
            Dim fdi As List(Of ProductionDPTWareInventoryInfo)

            fdi = fdc.ProductionDPTWareInventory_GetList(txtDepID_Out.Tag, GridView1.GetFocusedRowCellValue("PS_NO"), Nothing)

            If fdi.Count > 0 Then
                ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("WI_Qty") = fdi(0).WI_Qty
            Else
                ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("WI_Qty") = 0
            End If
        End If
    End Sub
    ''' <summary>
    ''' 當發出數量改變時,重量也跟著改變
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rcaeFP_Qty_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rcaeFP_Qty.EditValueChanged
        Dim pc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)

        pci = pc.ProcessSub_GetList(Nothing, ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("PS_NO").ToString, Nothing, Nothing, Nothing, Nothing)
        If pci.Count = 0 Then
            ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("FP_Weight") = 0
        Else
            Dim AllWeight, strWeight, strG As Single

            strWeight = pci(0).PS_Weight  '克/個  單重
            strG = strWeight * CInt(sender.text)
            AllWeight = strG / 1000  '當前數量的重量(KG)
            ds.Tables("Production").Rows(GridView1.FocusedRowHandle)("FP_Weight") = Format(AllWeight, "0.00") '(轉化為兩位小數)
        End If
    End Sub
    ''' <summary>
    ''' 單擊確定按鈕,添加數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim i, j%

        For i = 0 To ds.Tables("Production").Rows.Count - 1
            If IsDBNull(ds.Tables("Production").Rows(i)("PS_NO")) = True Then
                GridView1.FocusedRowHandle = i
                MsgBox("請輸入發料工序!", 64, "提示")
                Exit Sub
            End If

            If ds.Tables("Production").Rows(i)("FP_Qty") <= 0 Then
                GridView1.FocusedRowHandle = i
                MsgBox("發出數量不能小於等於0,請重新輸入!", 64, "提示")
                Exit Sub
            End If

            If ds.Tables("Production").Rows(i)("FP_Qty") > ds.Tables("Production").Rows(i)("WI_Qty") Then
                GridView1.FocusedRowHandle = i
                MsgBox("當前結余數量小於發出數量,不能發出!", 64, "提示")
                Exit Sub
            End If

            If ds.Tables("Production").Rows(i)("PO_NO") = "" Then
                GridView1.FocusedRowHandle = i
                MsgBox("請輸入PO單號!", 64, "提示")
                Exit Sub
            End If

            Dim psi As List(Of LFERP.Library.ProductionSchedule.ProductionScheduleInfo)
            Dim psc As New LFERP.Library.ProductionSchedule.ProductionScheduleControl

            psi = psc.ProductionSchedule_GetList(Nothing, ds.Tables("Production").Rows(i)("Pro_Type"), Nothing, ds.Tables("Production").Rows(i)("PM_M_Code").ToString, ds.Tables("Production").Rows(i)("PM_Type").ToString, (Format(CDate(dteFP_Date.Text), "yyyy/MM/dd")), Format(CDate(dteFP_Date.Text), "yyyy/MM/dd"), Nothing)
            If psi.Count = 0 Then
                GridView1.FocusedRowHandle = i
                MsgBox("當前工序生產部不存在選定日期的生產計劃，請先添加生產計劃！", 64, "提示")
                Exit Sub
            End If
        Next

        Dim pi As New ProductionFieldInfo
        Dim pc As New ProductionFieldControl

        For j = 0 To ds.Tables("Production").Rows.Count - 1
            pi.FP_NO = GetNO()
            pi.FP_Num = GetNum()
            pi.Pro_Type = ds.Tables("Production").Rows(j)("Pro_Type")
            pi.PM_M_Code = ds.Tables("Production").Rows(j)("PM_M_Code").ToString
            pi.PM_Type = ds.Tables("Production").Rows(j)("PM_Type").ToString

            pi.Pro_Type1 = ds.Tables("Production").Rows(j)("Pro_Type")
            pi.PM_M_Code1 = ds.Tables("Production").Rows(j)("PM_M_Code").ToString
            pi.PM_Type1 = ds.Tables("Production").Rows(j)("PM_Type").ToString
            pi.Pro_NO = ds.Tables("Production").Rows(j)("PS_NO").ToString
            pi.Pro_NO1 = ds.Tables("Production").Rows(j)("PS_NO").ToString

            pi.FP_Qty = ds.Tables("Production").Rows(j)("FP_Qty")
            pi.FP_Weight = ds.Tables("Production").Rows(j)("FP_Weight")
            pi.FP_Date = dteFP_Date.EditValue
            pi.FP_Detail = "PT13"
            pi.FP_OutDep = txtDepID_Out.Tag

            pi.FP_InDep = txtDepID.Tag
            pi.FP_Remark = ds.Tables("Production").Rows(j)("PO_NO").ToString & vbCrLf & ds.Tables("Production").Rows(j)("FP_Remark").ToString
            pi.FP_OutAction = InUserID
            pi.FP_OutType = ds.Tables("Production").Rows(j)("FP_OutType")
            pi.FP_OutOK = True

            pi.FP_SendType = "正常"


            If pc.ProductionField_Add(pi) = False Then
                GridView1.FocusedRowHandle = j
                If MsgBox("當前記錄保存失敗,是否要繼續保存下一條記錄?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "提示") = MsgBoxResult.No Then
                    Exit Sub
                End If
            Else                 '添加成功，直接變更庫存數據
                Dim pai As New ProductionAffairInfo
                Dim pac As New ProductionAffairControl
                Dim pdi As List(Of ProductionDPTWareInventoryInfo)
                Dim pdc As New ProductionDPTWareInventoryControl
                Dim pdsi As List(Of ProductionFieldDaySummaryInfo)
                Dim pdsc As New ProductionFieldDaySummaryControl

                Dim strQty, strReQty As Integer  '發出部門結餘數信息

                Dim strShouLiao, strJiaCun, strQuCun, strFaLiao, strCunHuo, strFanXiuIn, strFanXiuOut, strLiuBan, strSunHuai, strDiuShi, strBuNiang, strCunCang, strQuCang, strChuHuo, strWaiFaIn, strWaiFaOut, strAccIn, strAccOut, strRePairOut, strZuheOut As Integer '發出部門

                pdi = pdc.ProductionDPTWareInventory_GetList(txtDepID_Out.Tag, pi.Pro_NO, Nothing)

                If pdi.Count = 0 Then
                    strQty = 0
                    strReQty = 0
                Else
                    strQty = pdi(0).WI_Qty
                    strReQty = pdi(0).WI_ReQty
                End If

                pdsi = pdsc.ProductionFieldDaySummary_GetList(Nothing, Nothing, Nothing, pi.Pro_NO, txtDepID_Out.Tag, Nothing, dteFP_Date.Text, dteFP_Date.Text)
                If pdsi.Count = 0 Then
                    strShouLiao = 0
                    strJiaCun = 0
                    strQuCun = 0
                    strFaLiao = 0
                    strCunHuo = 0
                    strFanXiuIn = 0
                    strFanXiuOut = 0
                    strLiuBan = 0
                    strSunHuai = 0
                    strDiuShi = 0
                    strBuNiang = 0
                    strCunCang = 0
                    strQuCang = 0
                    strChuHuo = 0
                    strWaiFaIn = 0
                    strWaiFaOut = 0
                    strAccIn = 0
                    strAccOut = 0
                    strRePairOut = 0
                    strZuheOut = 0
                Else
                    strShouLiao = pdsi(0).ShouLiao
                    strJiaCun = pdsi(0).JiaCun
                    strQuCun = pdsi(0).QuCun
                    strFaLiao = pdsi(0).FaLiao
                    strCunHuo = pdsi(0).CunHuo
                    strFanXiuIn = pdsi(0).FanXiuIn
                    strFanXiuOut = pdsi(0).FanXiuOut
                    strLiuBan = pdsi(0).LiuBan
                    strSunHuai = pdsi(0).SunHuai
                    strDiuShi = pdsi(0).DiuShi
                    strBuNiang = pdsi(0).BuNiang
                    strCunCang = pdsi(0).CunCang
                    strQuCang = pdsi(0).QuCang
                    strChuHuo = pdsi(0).ChuHuo
                    strWaiFaIn = pdsi(0).WaiFaIn
                    strWaiFaOut = pdsi(0).WaiFaOut
                    strAccIn = pdsi(0).AccIn
                    strAccOut = pdsi(0).AccOut
                    strRePairOut = pdsi(0).RePairOut
                    strZuheOut = pdsi(0).ZuheOut
                End If

                '------------------------------------------------------收入部門信息

                'Dim wii As List(Of WareInventory.WareInventoryInfo)
                'Dim wic As New WareInventory.WareInventoryMTController

                'Dim Qty3 As Single

                'wii = wic.WareInventory_GetList3(Transfer(pi.Pro_NO), txtDepID.Tag)

                'If wii.Count = 0 Then
                '    Qty3 = 0
                'Else
                '    Qty3 = wii(0).WI_Qty
                'End If

                'Dim spc As New SharePurchaseController
                'Dim spi As New SharePurchaseInfo

                'spi.M_Code = Transfer(pi.Pro_NO) '將工序編號轉化為物料編碼信息
                'spi.WH_ID = txtDepID.Tag

                'spi.WI_Qty = Qty3 + CSng(pi.FP_Qty) '確認發料

                'spc.UpdateWareInventory_WIQty2(spi)  '物料在當前倉庫的變更

                Dim pic As New ProductInventoryController
                Dim pii As List(Of ProductInventoryInfo)
                Dim pii1 As New ProductInventoryInfo
                Dim strM_Code As String

                strM_Code = Transfer(pi.Pro_NO)

                pii = pic.ProductInventory_GetList(ds.Tables("Production").Rows(j)("PM_M_Code").ToString, strM_Code, txtDepID.Tag, Nothing)

                pii1.PM_M_Code = ds.Tables("Production").Rows(j)("PM_M_Code").ToString
                pii1.M_Code = strM_Code
                pii1.WH_ID = txtDepID.Tag

                If pii.Count > 0 Then
                    pii1.PI_Qty = pii(0).PI_Qty + CInt(ds.Tables("Production").Rows(j)("FP_Qty"))
                Else
                    pii1.PI_Qty = CInt(ds.Tables("Production").Rows(j)("FP_Qty"))
                End If
                pic.ProductInventory_Update(pii1)

                '----------------------------------------------------------------------------------------------------

                pai.FP_Detail = "PT13"
                pai.FP_NO = pi.FP_NO
                pai.FP_Type = "收料"
                pai.FP_InAction = InUserID
                pai.FP_InCheck = True
                pai.FP_InCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
                pai.CardID = ""

                pai.FP_OutDep = txtDepID_Out.Tag
                pai.Pro_NO = pi.Pro_NO
                pai.WI_Qty = strQty - CInt(pi.FP_Qty)
                pai.WI_ReQty = strReQty


                pai.Pro_Type = pi.Pro_Type
                pai.PM_M_Code = pi.PM_M_Code
                pai.PM_Type = pi.PM_Type


                pai.ShouLiao = strShouLiao
                pai.JiaCun = strJiaCun
                pai.QuCun = strQuCun
                pai.FaLiao = strFaLiao
                pai.CunHuo = strCunHuo
                pai.FanXiuIn = strFanXiuIn
                pai.FanXiuOut = strFanXiuOut
                pai.LiuBan = strLiuBan
                pai.SunHuai = strSunHuai
                pai.DiuShi = strDiuShi
                pai.BuNiang = strBuNiang
                pai.CunCang = strCunCang
                pai.QuCang = strQuCang
                pai.ChuHuo = strChuHuo + CInt(pi.FP_Qty)
                pai.WaiFaIn = strWaiFaIn
                pai.WaiFaOut = strWaiFaOut
                pai.AccIn = strAccIn
                pai.AccOut = strAccOut
                pai.RePairOut = strRePairOut
                pai.ZuheOut = strZuheOut
                pai.PM_Date = Format(Now, "yyyy/MM/dd")

                If pac.UpdateProductionCheck_Qty(pai) = True Then
                    Dim pfi As New ProductionFieldInfo
                    Dim pfc As New ProductionFieldControl

                    pfi.FP_NO = pi.FP_NO
                    pfi.FP_Check = True

                    pfi.FP_CheckAction = InUserID
                    pfi.FP_CheckRemark = ""

                    pfc.ProductionField_UpdateCheck(pfi)
                End If

            End If
        Next
        MsgBox("保存成功!", 64, "提示")
        Me.Close()
    End Sub
    Function Transfer(ByVal PS_NO As String) As String  '將工序編號轉化為產品工藝信息中的原始編碼(物料編碼,物料名稱)
        Dim pc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)

        pci = pc.ProcessSub_GetList(Nothing, PS_NO, Nothing, Nothing, Nothing, Nothing)
        If pci.Count = 0 Then
            MsgBox("當前不存在此工序編碼,請確認輸入正確!")
            Transfer = Nothing
            Exit Function
        Else
            Transfer = pci(0).M_Code    '對應的物料編碼信息
        End If

    End Function
    ''' <summary>
    ''' 當類型控件獲得焦點時,類型表格重新加載數據,避免類型表格總是記錄最後一次加載的數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rpcePM_Type_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpcePM_Type.Enter
        If GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_M_Code").ToString = "" Then   '產品編號為空時,類型表格也為空
            gridPM_Type.DataSource = Nothing
        Else
            gridPM_Type.DataSource = ppc.ProcessMain_GetList2(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Pro_Type").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_M_Code").ToString)
        End If
    End Sub
    ''' <summary>
    ''' 當發出工序控件獲得焦點時,工序表格重新加載數據,避免工序表格總是記錄最後一次加載的數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rpcePS_Name_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles rpcePS_Name.Enter
        '判斷工序是否有權限限制
        If mc.ProductionIssue_GetList(txtDepID_Out.Tag, txtDepID_Out.Tag, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Pro_Type").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_M_Code").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_Type").ToString, Nothing).Count > 0 Then
            gridPS_NO.DataSource = mc.ProductionIssue_GetList(txtDepID_Out.Tag, txtDepID_Out.Tag, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Pro_Type").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_M_Code").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_Type").ToString, Nothing)
        Else
            '判斷工序是否存在
            If ppc.ProcessMain_GetList(Nothing, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_M_Code").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Pro_Type").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_Type").ToString, Nothing, True).Count > 0 Then
                gridPS_NO.DataSource = ppc.ProcessMain_GetList(Nothing, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_M_Code").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Pro_Type").ToString, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "PM_Type").ToString, Nothing, True)
            Else
                gridPS_NO.DataSource = Nothing
            End If
        End If
    End Sub
    ''' <summary>
    ''' 按下空格鍵時,顯示下拉菜單
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rgluPM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rgluPM_M_Code.KeyDown, rpcePM_Type.KeyDown, rpcePS_Name.KeyDown, rcboPro_type.KeyDown, rcboFP_OutType.KeyDown, RepositoryItemMemoExEdit1.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
    ''' <summary>
    ''' 類型表格中按下回車鍵時,調用類型表格的單擊事件,實現回車鍵傳值
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gridPM_Type_View_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridPM_Type_View.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridPM_Type_View_Click(Nothing, Nothing)
        End If
    End Sub
    ''' <summary>
    ''' 工序表格中按下回車鍵時,調用工序表格的單擊事件,實現回車鍵傳值
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gridPS_NO_View_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridPS_NO_View.KeyDown
        If e.KeyCode = Keys.Enter Then
            gridPS_NO_View_Click(Nothing, Nothing)
        End If
    End Sub
End Class
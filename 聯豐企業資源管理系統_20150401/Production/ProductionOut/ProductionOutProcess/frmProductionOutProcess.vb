Imports LFERP.Library.Production.ProductionType
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.DataSetting
Imports LFERP.Library.Material
Imports LFERP.Library.ProductionOutProcess

Public Class frmProductionOutProcess
    Dim poc As New ProductionOutProcessControl
    Dim pdc As New ProductionDPTWareInventoryControl
    Dim ds As New DataSet
    Dim strError As String
    Public strPO_Type As String
    Dim strPM_M_Code As String
    Dim strPM_Type As String

    Private Sub frmProductionOutProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '加載外發供應商信息
        Dim mtd As New SuppliersControler
        gluS_SupplierName.Properties.DisplayMember = "S_SupplierName"
        gluS_SupplierName.Properties.ValueMember = "S_Supplier"
        gluS_SupplierName.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")

        CreateTable()       '調用創建表過程

        Select Case Microsoft.VisualBasic.Right(lblTittle.Text, 2)
            Case "新增"
                If strPO_Type = "外發返修" Then
                    lblPO_ID.Text = "外發返修單號(&I):"
                End If
                Me.Text = strPO_Type & "單 - -新增"
                txtPO_UserName.Text = UserName
                dtePO_OutDate.DateTime = Format(Now, "yyyy/MM/dd")
                txtPO_ID.Text = GetID()     '調用自動生成外發加工單號過程
                XtraTabPage2.PageVisible = False
            Case "修改"
                If strPO_Type = "外發返修" Then
                    lblPO_ID.Text = "外發返修單號(&I):"
                End If
                Me.Text = strPO_Type & "單--修改"
                XtraTabPage2.PageVisible = False
                LoadData()      '調用加載數據過程
            Case "查看"
                If strPO_Type = "外發返修" Then
                    lblPO_ID.Text = "外發返修單號(&I):"
                End If
                Me.Text = strPO_Type & "單--查看"
                cmdOK.Visible = False       '隱藏確定按鈕
                LoadData()      '調用加載數據過程
                Grid.ContextMenuStrip.Enabled = False    '右鍵菜單無效
            Case "審核"
                If strPO_Type = "外發返修" Then
                    lblPO_ID.Text = "外發返修單號(&I):"
                End If
                Me.Text = strPO_Type & "單--審核"
                XtraTabPage2.PageVisible = True
                XtraTabControl1.SelectedTabPageIndex = 1

                '所有數據都為只讀
                gluS_SupplierName.Properties.ReadOnly = True
                txtPO_UserName.Properties.ReadOnly = True
                dtePO_OutDate.Properties.ReadOnly = True
                txtPO_Remark.Properties.ReadOnly = True

                OW_Do.OptionsColumn.ReadOnly = True
                PO_ProAttribute.OptionsColumn.ReadOnly = True
                PO_Qty.OptionsColumn.ReadOnly = True
                PO_PM_Remark.OptionsColumn.ReadOnly = True

                Grid.ContextMenuStrip.Enabled = False       '右鍵菜單無效

                LoadData()      '調用加載數據過程

                lblPO_CheckUserName.Text = UserName
                lblPO_CheckDate.Text = Format(Now, "yyyy/MM/dd")

                cmdOK.Enabled = False   '確定按鈕無效
        End Select

    End Sub

    '創建表
    '此過程被以下過程調用：
    'frmProductionOutProcess_Load()
    Sub CreateTable()
        ds.Tables.Clear()

        '創建外發加工單信息表
        With ds.Tables.Add("ProductionOutProcess")

            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))

            .Columns.Add("OW_Do", GetType(String))
            .Columns.Add("PO_ProAttribute", GetType(String))
            .Columns.Add("PO_Qty", GetType(Integer))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("PO_PM_Remark", GetType(String)) '
            .Columns.Add("PM_JiYu", GetType(String)) 'PM_JiYu

        End With
        Grid.DataSource = ds.Tables("ProductionOutProcess")     '綁定表到Grid控件

        '創建刪除信息表，用於修改時刪除數據用
        With ds.Tables.Add("DelOutProcess")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("PO_ID", GetType(String))
        End With
    End Sub

    '在表ProductionOutProcess中添加數據
    '此過程被以下過程調用：
    'MenuAdd_Click()
    Sub AddRow(ByVal M_Code As String) '通過工序編號導入相應信息(工藝類型,產品編號,類型,工序名稱等)

        If M_Code <> "" Then

            '2012-7-27
            Dim pdi1 As List(Of ProductionDPTWareInventoryInfo)
            Dim pdc1 As New ProductionDPTWareInventoryControl
            pdi1 = pdc1.ProductionDPTWareInventory_GetList("F101", M_Code, Nothing)
            If pdi1.Count <= 0 Then
                MsgBox("外發部庫存無此工序存在!")
                Exit Sub
            End If


            Dim pic As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)

            pci = pic.ProcessSub_GetList(Nothing, M_Code, Nothing, Nothing, Nothing, Nothing)
            If pci.Count = 0 Then Exit Sub
            Dim i As Integer

            ''一張單不允許有重復相同工序編碼信息
            'For i = 0 To ds.Tables("ProductionOutProcess").Rows.Count - 1
            '    If M_Code = ds.Tables("ProductionOutProcess").Rows(i)("PS_NO") Then
            '        MsgBox("一張單不允許有重復相同工序編碼信息....")
            '        Exit Sub
            '    End If

            'Next

            For i = 0 To pci.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductionOutProcess").NewRow

                row("AutoID") = Nothing
                row("PM_M_Code") = pci(i).PM_M_Code
                row("PM_Type") = pci(i).Type3ID  '實際類型

                row("PM_JiYu") = pci(i).PM_JiYu

                If LoadProductionType(pci(i).PM_M_Code, pci(i).Type3ID) = True Then
                    GoTo A
                Else
                    Exit Sub
                End If
A:              If strPO_Type = "外發返修" Then
                    RepositoryItemComboBox2.Items.Clear()
                    RepositoryItemComboBox2.Items.Add("返修")
                    RepositoryItemComboBox2.Items.Add("返修-脫色")
                    RepositoryItemComboBox2.Items.Add("返修-對電")
                End If


                row("PS_NO") = M_Code
                row("PS_Name") = pci(i).PS_Name
                row("OW_Do") = RepositoryItemComboBox1.Items.Item(0)
                row("PO_ProAttribute") = RepositoryItemComboBox2.Items.Item(0)

                Dim pdi As List(Of ProductionDPTWareInventoryInfo)
                pdi = pdc.ProductionDPTWareInventory_GetList("F101", M_Code, Nothing)

                If pdi.Count > 0 Then
                    row("PO_Qty") = pdi(0).WI_Qty
                Else
                    row("PO_Qty") = 0
                End If

                row("PO_PM_Remark") = ""
                ds.Tables("ProductionOutProcess").Rows.Add(row)

            Next
        End If
        GridView1.MoveLast()
    End Sub

    '加載加工要求信息
    '此過程被以下過程調用：
    'AddRow()
    'LoadData()
    'RepositoryItemComboBox1_Enter()
    Function LoadProductionType(ByVal strCode As String, ByVal strType As String) As Boolean
        Dim ptc As New ProductionOutWardTypeControl
        Dim pti As List(Of ProductionOutWardTypeInfo)

        pti = ptc.ProductionOutWardType_GetList(Nothing, strCode, strType, Nothing, Nothing)
        RepositoryItemComboBox1.Items.Clear()

        If pti.Count = 0 Then
            MsgBox("當前產品此類型未建立加工要求,請先添加！", 64, "提示")
            LoadProductionType = False
            Exit Function
        Else
            LoadProductionType = True
            Dim i As Integer
            For i = 0 To pti.Count - 1
                RepositoryItemComboBox1.Items.Add(pti(i).OW_Do)
            Next
        End If


    End Function

    '單擊右鍵菜單“新增”,添加產品信息
    Private Sub MenuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAdd.Click
        tempCode = ""
        tempValue2 = "外發單管理"
        tempValue3 = "發料"
        frmProductionSelect.ShowDialog()
        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempCode, ",")      '把字符串分割填充到數組中
            n = Len(Replace(tempCode, ",", "," & "*")) - Len(tempCode)      '計算數組長度
            For i = 0 To n
                If arr(i) = "" Then
                    Exit Sub
                End If
                AddRow(arr(i))      '調用添加數據過程
            Next

        End If
        tempCode = ""
    End Sub

    '單擊取消按鈕，退出窗體
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    '單擊確定按鈕,保存數據
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Dim i, j, k%

        If gluS_SupplierName.Text.Trim = "" Then
            MsgBox("外發供應商不能為空，請選擇外發供應商!", 64, "提示")
            gluS_SupplierName.Focus()
            Exit Sub
        ElseIf txtPO_UserName.Text.Trim = "" Then
            MsgBox("發貨人不能為空，請輸入發貨人!", 64, "提示")
            txtPO_UserName.Focus()
            Exit Sub
        ElseIf dtePO_OutDate.Text.Trim = "" Then
            MsgBox("發貨日期不能為空，請輸入發貨日期!", 64, "提示")
            dtePO_OutDate.Focus()
            Exit Sub
        End If

        For i = 0 To GridView1.RowCount - 1
            '輸入數量不能小於等於0
            If ds.Tables("ProductionOutProcess").Rows(i)("PO_Qty") <= 0 Then
                MsgBox("數量輸入有誤，請輸入正整數數量!", 64, "提示")
                Grid.Focus()
                GridView1.FocusedRowHandle = i
                Exit Sub
            End If

            Dim pdi As List(Of ProductionDPTWareInventoryInfo)
            Dim intPO_Qty As Integer

            pdi = pdc.ProductionDPTWareInventory_GetList("F101", ds.Tables("ProductionOutProcess").Rows(i)("PS_NO"), Nothing)

            If pdi.Count <= 0 Then
                MsgBox("工序不存在!", 64, "提示")
                Exit Sub
            Else
                '@2012/7/2 修改　同一張單中允許存在相同工序，但加工要求不能相同
                intPO_Qty = ds.Tables("ProductionOutProcess").Rows(i)("PO_Qty")
                For k = 0 To GridView1.RowCount - 1
                    If k <> i Then
                        If ds.Tables("ProductionOutProcess").Rows(i)("PS_NO") = ds.Tables("ProductionOutProcess").Rows(k)("PS_NO") And ds.Tables("ProductionOutProcess").Rows(i)("OW_DO") = ds.Tables("ProductionOutProcess").Rows(k)("OW_DO") Then
                            MsgBox("同一張單中不能存在工序相同且加工要求也相同的記錄！", 64, "提示")
                            GridView1.FocusedRowHandle = i
                            Exit Sub
                        End If

                        ' ''累加相同工序的外發數量
                        ''If ds.Tables("ProductionOutProcess").Rows(i)("PS_NO") = ds.Tables("ProductionOutProcess").Rows(k)("PS_NO") Then
                        ''    intPO_Qty = intPO_Qty + ds.Tables("ProductionOutProcess").Rows(k)("PO_Qty")
                        ''End If

                        ' ''相同工序我發總數量不能大於庫存數
                        ''If pdi(0).WI_Qty < intPO_Qty Then
                        ''    MsgBox("記錄" & ds.Tables("ProductionOutProcess").Rows(i)("PM_M_Code") & "/" & ds.Tables("ProductionOutProcess").Rows(i)("PM_Type") _
                        ''     & "/" & ds.Tables("ProductionOutProcess").Rows(i)("PS_Name") & vbCrLf & "輸入數量大於庫存數量，不能外發!", 64, "提示")
                        ''    GridView1.FocusedRowHandle = i
                        ''    Exit Sub
                        ''End If

                    End If
                Next
            End If
        Next

        Select Case Microsoft.VisualBasic.Right(lblTittle.Text, 2)
            Case "新增"
                If DataNew() = True Then        '調用新增數據函數
                    MsgBox("添加記錄成功!", 64, "提示")
                    Me.Close()
                End If
            Case "修改"
                If DataEdit() = True Then       '調用修改數據函數
                    MsgBox("修改記錄成功!", 64, "提示")
                    Me.Close()
                End If
            Case "審核"
                Dim poi As New ProductionOutProcessInfo
                poi.PO_ID = txtPO_ID.Text
                poi.PO_Check = True
                poi.PO_CheckUserID = InUserID
                poi.PO_CheckDate = Format(Now, "yyyy/MM/dd")
                poi.PO_CheckRemark = txtPO_CheckRemark.Text.Trim

                If poc.ProductionOutProcess_Check(poi) = True Then      '判斷審核信息是否更新完成
                    Dim pdi As List(Of ProductionDPTWareInventoryInfo)
                    Dim pdiUpdate As New ProductionDPTWareInventoryInfo

                    '扣減庫存數量
                    For j = 0 To GridView1.RowCount - 1
                        pdi = pdc.ProductionDPTWareInventory_GetList("F101", ds.Tables("ProductionOutProcess").Rows(j)("PS_NO"), Nothing)

                        If pdi.Count > 0 Then
                            pdiUpdate.M_Code = ds.Tables("ProductionOutProcess").Rows(j)("PS_NO")
                            pdiUpdate.DPT_ID = "F101"
                            pdiUpdate.WI_Qty = pdi(0).WI_Qty - ds.Tables("ProductionOutProcess").Rows(j)("PO_Qty")
                            If pdc.UpdateProductionField_Qty(pdiUpdate) = False Then
                                MsgBox("扣減庫存數量失敗!", 64, "提示")
                                Exit Sub
                            End If
                        End If
                    Next

                    MsgBox("審核完成!", 64, "提示")
                    Me.Close()
                Else
                    MsgBox("審核失敗!", 64, "提示")
                End If
        End Select
    End Sub

    ''' <summary>
    ''' 自動外發加工單號
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    ''' DataNew()
    ''' frmProductionOutProcess_Load()
    Function GetID() As String
        Dim str As String = ""
        If strPO_Type = "外發返修" Then
            str = "PR" & CStr(Format(Now, "yyMM"))
        ElseIf strPO_Type = "外發加工" Then
            str = "PO" & CStr(Format(Now, "yyMM"))
        End If

        Dim poi As List(Of ProductionOutProcessInfo)
        poi = poc.ProductionOutProcess_GetList(Nothing, str, strPO_Type, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If poi.Count <= 0 Then
            GetID = str & "0001"
        Else
            GetID = str & Mid((CInt(Mid(poi(0).PO_ID, 7)) + 10001), 2)
        End If
    End Function

    ''' <summary>
    ''' 新增數據
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' cmdOK_Click()
    Function DataNew() As Boolean
        Dim poi As New ProductionOutProcessInfo
        Dim i As Integer

        Try
            Dim popi As List(Of ProductionOutProcessInfo)
            popi = poc.ProductionOutProcess_GetList(Nothing, txtPO_ID.Text.Trim, strPO_Type, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            '判斷外發加工單號是否已存在
            If popi.Count > 0 Then
                MsgBox(strPO_Type & "單號已存在，需重新生成，請確定重新生成" & strPO_Type & "單號!", 64, "提示")
                txtPO_ID.Text = GetID()     '重新生成外發加工單號
                MsgBox(strPO_Type & "單號已重新生成，請確定保存信息!", 64, "提示")
            End If

            poi.PO_ID = txtPO_ID.Text.Trim
            poi.PO_Type = strPO_Type
            poi.S_Supplier = gluS_SupplierName.EditValue
            poi.PO_UserName = txtPO_UserName.Text.Trim
            poi.PO_OutDate = dtePO_OutDate.EditValue

            poi.PO_Remark = txtPO_Remark.Text.Trim
            poi.AddUserID = InUserID
            poi.AddDate = Now

            For i = 0 To ds.Tables("ProductionOutProcess").Rows.Count - 1
                poi.PM_M_Code = ds.Tables("ProductionOutProcess").Rows(i)("PM_M_Code")
                poi.PM_Type = ds.Tables("ProductionOutProcess").Rows(i)("PM_Type")
                poi.PS_NO = ds.Tables("ProductionOutProcess").Rows(i)("PS_NO")
                poi.PS_Name = ds.Tables("ProductionOutProcess").Rows(i)("PS_Name")
                poi.OW_Do = ds.Tables("ProductionOutProcess").Rows(i)("OW_Do")

                poi.PO_ProAttribute = ds.Tables("ProductionOutProcess").Rows(i)("PO_ProAttribute")
                poi.PO_Qty = ds.Tables("ProductionOutProcess").Rows(i)("PO_Qty")
                poi.PO_PM_Remark = ds.Tables("ProductionOutProcess").Rows(i)("PO_PM_Remark")

                If poc.ProductionOutProcess_Add(poi) = False Then   '判斷數據是否添加完成
                    MsgBox("記錄" & ds.Tables("ProductionOutProcess").Rows(i)("PM_M_Code") & "/" & ds.Tables("ProductionOutProcess").Rows(i)("PM_Type") _
                     & "/" & ds.Tables("ProductionOutProcess").Rows(i)("PS_Name") & "添加失敗!", 64, "提示")
                    DataNew = False
                    Exit Function
                Else
                    DataNew = True
                End If
            Next
        Catch ex As Exception
            DataNew = False
            MsgBox("添加記錄失敗!" & vbCrLf & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' 修改數據
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' cmdOK_Click()
    Function DataEdit() As Boolean
        Dim poi As New ProductionOutProcessInfo
        Dim i, j As Integer

        Try
            '判斷刪除表中是否有需要刪除的信息，有則刪除數據庫中相應信息
            If ds.Tables("DelOutProcess").Rows.Count > 0 Then
                For j = 0 To ds.Tables("DelOutProcess").Rows.Count - 1
                    poc.ProductionOutProcess_Delete(ds.Tables("DelOutProcess").Rows(i)("AutoID"), Nothing)
                Next
            End If

            poi.PO_ID = txtPO_ID.Text.Trim
            poi.PO_Type = strPO_Type
            poi.S_Supplier = gluS_SupplierName.EditValue
            poi.PO_UserName = txtPO_UserName.Text.Trim
            poi.PO_OutDate = dtePO_OutDate.DateTime

            poi.PO_Remark = txtPO_Remark.Text.Trim
            poi.ModifyUserID = InUserID
            poi.ModifyDate = Now

            For i = 0 To ds.Tables("ProductionOutProcess").Rows.Count - 1
                '判斷修改中是否有新增
                If IsDBNull(ds.Tables("ProductionOutProcess").Rows(i)("AutoID")) Then
                    poi.PM_M_Code = ds.Tables("ProductionOutProcess").Rows(i)("PM_M_Code")
                    poi.PM_Type = ds.Tables("ProductionOutProcess").Rows(i)("PM_Type")
                    poi.PS_NO = ds.Tables("ProductionOutProcess").Rows(i)("PS_NO")
                    poi.PS_Name = ds.Tables("ProductionOutProcess").Rows(i)("PS_Name")
                    poi.OW_Do = ds.Tables("ProductionOutProcess").Rows(i)("OW_Do")

                    poi.PO_ProAttribute = ds.Tables("ProductionOutProcess").Rows(i)("PO_ProAttribute")
                    poi.PO_Qty = ds.Tables("ProductionOutProcess").Rows(i)("PO_Qty")
                    poi.PO_NoSendQty = ds.Tables("ProductionOutProcess").Rows(i)("PO_Qty")
                    poi.PO_PM_Remark = ds.Tables("ProductionOutProcess").Rows(i)("PO_PM_Remark")
                    poi.AddUserID = InUserID

                    poi.AddDate = Now

                    If poc.ProductionOutProcess_Add(poi) = False Then
                        MsgBox("記錄" & ds.Tables("ProductionOutProcess").Rows(i)("PM_M_Code") & "/" & ds.Tables("ProductionOutProcess").Rows(i)("PM_Type") _
                         & "/" & ds.Tables("ProductionOutProcess").Rows(i)("PS_Name") & "添加失敗!", 64, "提示")
                        DataEdit = False
                        Exit Function
                    Else
                        DataEdit = True
                    End If
                Else
                    poi.AutoID = ds.Tables("ProductionOutProcess").Rows(i)("AutoID")
                    poi.PM_M_Code = ds.Tables("ProductionOutProcess").Rows(i)("PM_M_Code")
                    poi.PM_Type = ds.Tables("ProductionOutProcess").Rows(i)("PM_Type")
                    poi.PS_NO = ds.Tables("ProductionOutProcess").Rows(i)("PS_NO")
                    poi.PS_Name = ds.Tables("ProductionOutProcess").Rows(i)("PS_Name")

                    poi.OW_Do = ds.Tables("ProductionOutProcess").Rows(i)("OW_Do")
                    poi.PO_ProAttribute = ds.Tables("ProductionOutProcess").Rows(i)("PO_ProAttribute")
                    poi.PO_Qty = ds.Tables("ProductionOutProcess").Rows(i)("PO_Qty")
                    poi.PO_NoSendQty = ds.Tables("ProductionOutProcess").Rows(i)("PO_Qty")
                    poi.PO_PM_Remark = ds.Tables("ProductionOutProcess").Rows(i)("PO_PM_Remark")

                    If poc.ProductionOutProcess_Update(poi) = False Then
                        MsgBox("記錄" & ds.Tables("ProductionOutProcess").Rows(i)("PM_M_Code") & "/" & ds.Tables("ProductionOutProcess").Rows(i)("PM_Type") _
                         & "/" & ds.Tables("ProductionOutProcess").Rows(i)("PS_Name") & "修改失敗!", 64, "提示")
                        DataEdit = False
                        Exit Function
                    Else
                        DataEdit = True
                    End If
                End If

            Next
        Catch ex As Exception
            DataEdit = False
            MsgBox("添加記錄失敗!" & vbCrLf & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' 加載數據
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' frmProductionOutProcess_Load()
    Sub LoadData()
        Dim i%
        Dim row As DataRow
        Dim poi As List(Of ProductionOutProcessInfo)
        poi = poc.ProductionOutProcess_GetList(Nothing, txtPO_ID.Text, strPO_Type, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        '判斷數據庫中是否存在此外發加工單(外發加工單有可能被人刪除掉)
        If poi.Count <= 0 Then
            MsgBox("外發加工單:" & txtPO_ID.Text & "已被刪除!", 64, "提示")
            Exit Sub
        End If

        gluS_SupplierName.EditValue = poi(0).S_Supplier
        txtPO_UserName.Text = poi(0).PO_UserName
        dtePO_OutDate.DateTime = poi(0).PO_OutDate
        txtPO_Remark.Text = poi(0).PO_Remark
        chkPO_Check.Checked = poi(0).PO_Check

        lblPO_CheckUserName.Text = poi(0).PO_CheckUserName
        lblPO_CheckDate.Text = poi(0).PO_CheckDate
        txtPO_CheckRemark.Text = poi(0).PO_CheckRemark

        ds.Tables("ProductionOutProcess").Clear()       '清空表
        For i = 0 To poi.Count - 1

            row = ds.Tables("ProductionOutProcess").NewRow

            row("AutoID") = poi(i).AutoID
            row("PM_M_Code") = poi(i).PM_M_Code
            row("PM_Type") = poi(i).PM_Type
            row("PS_No") = poi(i).PS_NO
            row("PS_Name") = poi(i).PS_Name
            row("PM_JiYu") = poi(i).PM_JiYu

            LoadProductionType(poi(i).PM_M_Code, poi(i).PM_Type)
            If strPO_Type = "外發返修" Then
                RepositoryItemComboBox2.Items.Clear()
                RepositoryItemComboBox2.Items.Add("返修")
                RepositoryItemComboBox2.Items.Add("返修-脫色")
                RepositoryItemComboBox2.Items.Add("返修-對電")
            End If
            row("OW_Do") = poi(i).OW_Do
            row("PO_ProAttribute") = poi(i).PO_ProAttribute
            row("PO_Qty") = poi(i).PO_Qty
            row("PO_PM_Remark") = poi(i).PO_PM_Remark

            ds.Tables("ProductionOutProcess").Rows.Add(row)
        Next
    End Sub

    ''' <summary>
    ''' 單擊右鍵“刪除”菜單，刪除表格中數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄，以便確定時刪除數據庫中記錄
            Dim row As DataRow = ds.Tables("DelOutProcess").NewRow

            row("AutoID") = ds.Tables("ProductionOutProcess").Rows(GridView1.FocusedRowHandle)("AutoID")

            ds.Tables("DelOutProcess").Rows.Add(row)
        End If
        ds.Tables("ProductionOutProcess").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    ''' <summary>
    ''' 確認復選框值改變
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkPO_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPO_Check.CheckedChanged
        cmdOK.Enabled = Not cmdOK.Enabled       '復選框被選中時，確定按鈕才可用
    End Sub

    '按空格鍵顯示外發供應商選項
    Private Sub gluS_SupplierName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluS_SupplierName.KeyDown
        If e.KeyCode = Keys.Space Then
            gluS_SupplierName.ShowPopup()
        End If
    End Sub

    'Private Sub RepositoryItemComboBox1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemComboBox1.EditValueChanged
    '    Dim i%
    '    Dim strPS_NO, strOW_DO As String
    '    strPS_NO = GridView1.GetFocusedRowCellValue("PS_NO").ToString
    '    strOW_DO = GridView1.GetFocusedRowCellValue("OW_DO").ToString
    '    For i = 0 To GridView1.RowCount - 1
    '        If GridView1.FocusedRowHandle <> i Then
    '            If ds.Tables("ProductionOutProcess").Rows(i)("PS_NO") = strPS_NO And ds.Tables("ProductionOutProcess").Rows(i)("OW_DO") = strOW_DO Then
    '                MsgBox("同一張單中不能存在相同工序且加工要求也相同的記錄！", 64, "提示")
    '            End If
    '        End If
    '    Next
    'End Sub

    '加工要求列表框獲得焦點時，重新加載項目
    Private Sub RepositoryItemComboBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemComboBox1.Enter
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        Dim strA, strB As String

        strA = GridView1.GetFocusedRowCellValue("PM_M_Code")
        strB = GridView1.GetFocusedRowCellValue("PM_Type")

        If strPM_M_Code <> strA Or strPM_Type <> strB Then
            strPM_M_Code = strA
            strPM_Type = strB
            LoadProductionType(strA, strB)
        End If
    End Sub

    '按空格鍵顯示加工要求/加工屬性選項
    Private Sub RepositoryItemComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RepositoryItemComboBox1.KeyDown, RepositoryItemComboBox2.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.showpopup()
        End If
    End Sub

End Class
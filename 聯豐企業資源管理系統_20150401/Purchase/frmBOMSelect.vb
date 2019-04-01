Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.Library.Product
Imports LFERP.SystemManager
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.ProductProcess


Public Class frmBOMSelect
    Dim MPController As New MaterialParamController
    Dim mtc As New Material.MaterialTypeController
    Dim mc As New MaterialController

    Dim strCode As String
    Dim dl As New DataSet
    Dim ds As New DataSet
    Dim isShowFirstPage As Boolean '只顯示第一個標簽頁
    Dim isShowThirdPage As Boolean = False
    Dim dsNew As New DataSet

    Dim BatchLoad As String

    '@ 2013/3/26 添加 權限控制
    Sub UserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "800208")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                isShowFirstPage = True
            Else
                isShowFirstPage = False
            End If
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505009") '505009
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                isShowThirdPage = True
            Else
                isShowThirdPage = False
            End If
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click


        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            ''2013-5-11
            If BatchLoad = "B" Then
                If GridView1.RowCount <= 0 Then
                    Exit Sub
                End If

                If ds.Tables("MaterialCode").Rows.Count <= 0 Then
                    MsgBox("無數據載入!")
                    Exit Sub
                End If

                tempValue = Nothing

                Dim x As Integer
                For x = 0 To ds.Tables("MaterialCode").Rows.Count - 1
                    If ds.Tables("MaterialCode").Rows(x)("GoINM_code") = True Then
                        If tempValue = Nothing Then
                            tempValue = ds.Tables("MaterialCode").Rows(x)("M_Code")
                        Else
                            tempValue = tempValue & "," & ds.Tables("MaterialCode").Rows(x)("M_Code")
                        End If
                    End If
                Next

            Else
                strCode = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")
            End If


            'strCode = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")


            'If Label5.Text = "外發" Then
            '    Dim wtc As New WareInventoryMTController
            '    Dim wti As List(Of WareInventoryInfo)
            '    wti = wtc.WareInventory_GetList(strCode, Label4.Text)
            '    If wti.Count = 0 Then
            '        MsgBox(Label4.Text & "倉庫中不存在此物料！")
            '        Exit Sub
            '    Else
            '        tempValue4 = wti(0).WI_Qty
            '    End If
            'End If

        ElseIf XtraTabControl1.SelectedTabPageIndex = 1 Then

            'strCode = Grid2.FocusedNode.GetValue("M_Code")

            tempValue = ""
            Dim i, n As Integer
            n = 0
            Select Case Label5.Text
                Case "產品訂單管理"
                    For i = 0 To Grid2.Nodes.Count - 1

                        If Grid2.Nodes.Item(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = Grid2.Nodes.Item(i)("M_Code").ToString
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & Grid2.Nodes.Item(i)("M_Code").ToString
                                n = n + 1
                            End If

                        End If

                    Next

                Case "報價管理"
                    For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

                        If ds.Tables("OrdersBom").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If

                    Next

                Case "採購管理"
                    Dim j As Integer
                    For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

                        If ds.Tables("OrdersBom").Rows(i)("OB_Product") = "需採購" And ds.Tables("OrdersBom").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        Else
                            j = j + 1
                        End If
                    Next
                Case "外發"
                    For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1


                        If ds.Tables("OrdersBom").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If

                    Next
                Case "倉庫管理"
                    For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

                        If ds.Tables("OrdersBom").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If
                    Next

                Case "倉庫庫存查詢"
                    For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

                        If ds.Tables("OrdersBom").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If

                    Next
                Case "出廠管理"

                    For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

                        If ds.Tables("OrdersBom").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If

                    Next
                Case "送貨管理"

                    For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

                        If ds.Tables("OrdersBom").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If

                    Next
                Case "開料管理"
                    For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

                        If ds.Tables("OrdersBom").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & ds.Tables("OrdersBom").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If

                    Next
            End Select

            If tempValue = "" Then
                MsgBox("請選擇需要導入的資料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                Exit Sub
            End If
            tempValue2 = txtMo.Text
        ElseIf XtraTabControl1.SelectedTabPageIndex = 2 Then
            tempValue = ""
            Dim i, n As Integer
            n = 0
            Select Case Label5.Text

                Case "產品訂單管理"
                    For i = 0 To TreeList1.Nodes.Count - 1

                        If TreeList1.Nodes(i).Item("GoIn") = True Then
                            If n = 0 Then
                                tempValue = TreeList1.Nodes.Item(i)("M_Code").ToString
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & TreeList1.Nodes.Item(i)("M_Code").ToString
                                n = n + 1
                            End If

                        End If
                    Next
                Case "報價管理"
                    For i = 0 To dl.Tables("Pro_Mounting_New").Rows.Count - 1


                        If dl.Tables("Pro_Mounting_New").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If

                    Next
                Case "採購管理"
                    For i = 0 To dl.Tables("Pro_Mounting_New").Rows.Count - 1


                        If dl.Tables("Pro_Mounting_New").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If

                    Next
                Case "外發"
                    For i = 0 To dl.Tables("Pro_Mounting_New").Rows.Count - 1


                        If dl.Tables("Pro_Mounting_New").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If

                    Next
                Case "倉庫管理"
                    For i = 0 To dl.Tables("Pro_Mounting_New").Rows.Count - 1

                        If dl.Tables("Pro_Mounting_New").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If
                    Next

                Case "倉庫庫存查詢"
                    For i = 0 To dl.Tables("Pro_Mounting_New").Rows.Count - 1

                        If dl.Tables("Pro_Mounting_New").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If
                    Next

                Case "開料管理"
                    For i = 0 To dl.Tables("Pro_Mounting_New").Rows.Count - 1

                        If dl.Tables("Pro_Mounting_New").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                MsgBox("當前只允許添加一種物料!")
                                Exit Sub
                                'tempValue = tempValue & "," & dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                'n = n + 1
                            End If
                        End If
                    Next
                Case "出貨管理"

                    For i = 0 To dl.Tables("Pro_Mounting_New").Rows.Count - 1

                        If dl.Tables("Pro_Mounting_New").Rows(i)("GoIn") = True Then
                            If n = 0 Then
                                tempValue = dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            Else
                                tempValue = tempValue & "," & dl.Tables("Pro_Mounting_New").Rows(i)("M_Code")
                                n = n + 1
                            End If
                        End If
                    Next
                Case "申購單管理"       '@ 2012/3/19 添加 生產管理-申購單管理   
                    RepositoryItemCheckEdit6_Leave(Nothing, Nothing)    '調用復選框失去焦點事件，判斷選中物料是否有子物料

                    For i = 0 To dl.Tables("Pro_Mounting_New").Rows.Count - 1   '把選中物料的物料編碼，添加到數組列表arlM_Code
                        If dl.Tables("Pro_Mounting_New").Rows(i)("GoIn") = True Then
                            arlM_Code.Add(dl.Tables("Pro_Mounting_New").Rows(i)("M_Code"))
                        End If
                    Next
                Case "生產倉庫調撥"
                    strCode = dl.Tables("Pro_Mounting_New").Rows(0)("M_Code").ToString
                    For i = 0 To dl.Tables("Pro_Mounting_New").Rows.Count - 1   '把選中物料的物料編碼，添加到數組列表arlM_Code
                        If dl.Tables("Pro_Mounting_New").Rows(i)("GoIn") = True Then
                            arlM_Code.Add(dl.Tables("Pro_Mounting_New").Rows(i)("M_Code"))
                        End If
                    Next
            End Select

            If tempValue = "" And arlM_Code.Count <= 0 Then
                MsgBox("請選擇需要導入的資料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
                Exit Sub
            End If
            tempValue3 = txtLFID.Text
        End If

        tempCode = strCode    '--公用M_Code
        'tempCode = tempValue  '--今後待開發！！
        tempValue7 = tempValue  '--針對配件批次--批次
        tempValue8 = tempValue  '--針對配件批次--產品編號

        Me.Close()

    End Sub

    Private Sub frmBOMSelect_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Grid.DataSource = Nothing
    End Sub

    Private Sub frmBOMSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        XtraTabPage1.PageVisible = True
        XtraTabPage2.PageVisible = True
        XtraTabPage3.PageVisible = True

        UserPower()

        mtc.LoadNodes(tv1, ErpUser.MaterialType)


        ''---------跟物料編碼一樣--------------------------------------------------------
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100113")
        If pmwiL.Count > 0 Then
            If pmwiL(0).PMWS_Value.ToString <> "" Then
                mtc.LoadNodes(tv1, pmwiL(0).PMWS_Value.ToString)    '只選擇成品類
            Else
                mtc.LoadNodes(tv1, ErpUser.MaterialType)
            End If
        Else
            mtc.LoadNodes(tv1, ErpUser.MaterialType)
        End If


        ''------2013-10-18--------------------------------------------------------------
        If tempValue13 = Nothing Then
            Dim pc As New ProductController
            txtLFID.Properties.DataSource = pc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            txtLFID.Properties.DisplayMember = "PM_M_Code"
            txtLFID.Properties.ValueMember = "PM_M_Code"
        Else
            LoadPM_M_Code(tempValue13)
        End If

        tempValue13 = Nothing

        '-----------------2013-5-11------------------------------------------------
        BatchLoad = tempValue12
        tempValue12 = Nothing

        If BatchLoad = "B" Then
            Me.GridView1.OptionsBehavior.Editable = True
            'GridView1.OptionsFilter.AllowFilterEditor = True
            SelectButtonAll.Visible = True
            GoINM_code.Visible = True
            XtraTabPage2.PageVisible = False
            XtraTabPage3.PageVisible = False


            CreateMaterialCode()
            Me.SelectButtonAll.Text = "全選"
        Else
            Me.GridView1.OptionsBehavior.Editable = False
            ' GridView1.OptionsFilter.AllowFilterEditor = False
            GoINM_code.Visible = False
            SelectButtonAll.Visible = False
        End If
        '----------------------------------------------------------------------------


        Label4.Text = tempValue5
        Label5.Text = tempValue6
        Label6.Text = tempValue7
        If Label6.Text = "Copy" Then
            txtMo.Text = tempValue8
        Else
            txtMo.Text = ""
        End If
        If Label5.Text = "倉庫庫存查詢" Then
            cmdWare.Visible = True
            If isShowThirdPage = True Then
                XtraTabPage1.PageVisible = False
                XtraTabPage2.PageVisible = False
                XtraTabPage3.PageVisible = True
            Else
                XtraTabPage1.PageVisible = True
                XtraTabPage2.PageVisible = False
                XtraTabPage3.PageVisible = True
            End If

        Else
            cmdWare.Visible = False

        End If
        If Label5.Text = "倉庫管理" Or Label5.Text = "倉庫庫存查詢" Then
            cmdAll.Visible = True
        Else
            cmdAll.Visible = False
        End If

        If Label5.Text = "生產倉庫調撥" Or (Label5.Text = "倉庫管理" And isShowThirdPage = True) Then
            XtraTabPage1.PageVisible = False
            XtraTabPage2.PageVisible = False
            XtraTabPage3.PageVisible = True
            txtLFID.Select()
        ElseIf Label5.Text = "倉庫管理" And isShowFirstPage = True Then
            XtraTabPage1.PageVisible = True
            XtraTabPage2.PageVisible = False
            XtraTabPage3.PageVisible = False
        ElseIf Label5.Text = "開料管理" Then
            txtLFID.Text = tempValue9
            XtraTabControl1.SelectedTabPageIndex = 2
            XtraTabPage2.PageVisible = False
        End If
        Grid.DataSource = Nothing
        Grid2.DataSource = Nothing
        GridControl1.Visible = False
        TreeList1.DataSource = ""
        txtLFID.Text = tempValue9
        tempValue5 = ""
        tempValue6 = ""
        tempValue7 = ""
        tempValue8 = ""
        'Me.Left = MDIMain.Width - Me.Width - 10
        'Me.Top = (MDIMain.Height - Me.Height) / 2
        txtName.Select()


    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub tv1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tv1.DoubleClick
        PopupContainerEdit1.EditValue = tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub

    Private Sub cmdSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeek.Click
        'Dim strCode, strName, strTypeID, strGauge, strSupplierNo As String

        'If CheckEdit7.Checked = True Then
        '    If PopupContainerEdit1.EditValue Is Nothing Then
        '        MsgBox("沒有選擇類別,請選擇!", , "提示")
        '        Exit Sub
        '    Else
        '        strTypeID = PopupContainerEdit1.EditValue
        '    End If
        'Else
        '    strTypeID = Nothing 'ErpUser.MaterialType

        'End If
        'If CheckEdit4.Checked = True Then
        '    If Len(txtCode.EditValue) = 0 Then
        '        MsgBox("沒有輸入物料編碼,請輸入!", , "提示")
        '        Exit Sub
        '    Else
        '        strCode = txtCode.EditValue
        '    End If
        'Else
        '    strCode = Nothing
        'End If
        'If CheckEdit6.Checked = True Then
        '    If Len(txtName.EditValue) = 0 Then
        '        MsgBox("沒有輸入物料名稱,請輸入!", , "提示")
        '        Exit Sub
        '    Else
        '        strName = txtName.EditValue
        '    End If
        'Else
        '    strName = Nothing
        'End If
        'If CheckEdit2.Checked = True Then
        '    If Len(txtGauge.EditValue) = 0 Then
        '        MsgBox("沒有輸入物料規格,請輸入!", , "提示")
        '        Exit Sub
        '    Else
        '        strGauge = txtGauge.EditValue
        '    End If
        'Else
        '    strGauge = Nothing
        'End If

        'If CheckEdit1.Checked = True Then
        '    If Len(TextEdit2.EditValue) = 0 Then
        '        MsgBox("沒有輸入供應商編號,請輸入!", , "提示")
        '        Exit Sub
        '    Else
        '        strSupplierNo = TextEdit2.EditValue
        '    End If
        'Else
        '    strSupplierNo = Nothing
        'End If

        ''***判斷用戶是擁有特殊類的權限
        'Dim pmws2 As New PermissionModuleWarrantSubController
        'Dim pmwiL2 As List(Of PermissionModuleWarrantSubInfo)
        'Dim Stra As String
        'Stra = "否"
        'pmwiL2 = pmws2.PermissionModuleWarrantSub_GetList(InUserID, "100115")

        'If pmwiL2.Item(0).PMWS_Value = "是" Then
        '    Stra = "是"
        'End If

        ''************

        'Grid.DataSource = mc.MaterialCode_GetList(strCode, strName, strGauge, strTypeID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strSupplierNo, Stra)
        If Label6.Text = "出庫作業" Then
            CreateMaterialCode()
            LoadInventoryData()
        Else
            CreateMaterialCode()
            LoadMaterialCodeData()
        End If
    
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim ob As New Orders.OrdersBomController

        If txtMo.Text = "" Then
            MsgBox("批次編號不能為空，請輸入！")
            Exit Sub
        End If
        CreateBatchTable()
        LoadDataOrdersBom()

        'Grid2.DataSource = ob.OrdersBom_GetList(Nothing, txtMo.Text)
        'Grid2.ExpandAll()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim pbc As New ProductBomController

        If txtLFID.Text = "" Then
            MsgBox("產品編號不能為空，請輸入！")
            Exit Sub
        End If
        CreateLFIDTable()
        LoadProductBomData()
        'TreeList1.DataSource = pbc.ProductBom_GetList(txtLFID.Text, Nothing, Nothing, Nothing, Nothing)
        'TreeList1.ExpandAll()
    End Sub

    Sub CreateBatchTable()
        ds.Tables.Clear()
        With ds.Tables.Add("OrdersBom")

            .Columns.Add("OS_BatchID", GetType(Integer))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("OB_PID", GetType(String))
            .Columns.Add("OB_Key", GetType(String))
            .Columns.Add("OB_Qty", GetType(Double))
            .Columns.Add("OB_MainQty", GetType(Double))
            .Columns.Add("OB_Price", GetType(Double))
            .Columns.Add("OB_Supplier", GetType(String))
            .Columns.Add("OB_SupplierNo", GetType(String))
            .Columns.Add("OB_Product", GetType(String))
            .Columns.Add("OB_ProductNo", GetType(String))
            .Columns.Add("OB_ProductRemark", GetType(String))
            .Columns.Add("OB_AccountCheck", GetType(Boolean))
            .Columns.Add("OB_Make", GetType(Boolean))
            .Columns.Add("OB_MarkRemark", GetType(String))
            .Columns.Add("OB_ID", GetType(Integer))
            .Columns.Add("PM_LVL", GetType(Integer))
            .Columns.Add("M_CodeType", GetType(String))
            .Columns.Add("M_CodeMouldNO", GetType(String))
            .Columns.Add("OB_MakeDepartment", GetType(String))
            .Columns.Add("OB_MModeCusterNO", GetType(String))

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))

            .Columns.Add("GoIn", GetType(Boolean))

        End With

        Grid2.DataSource = ds.Tables("OrdersBom")

    End Sub
    Sub LoadDataOrdersBom()
        '載入物料清單

        Dim osi As List(Of Orders.OrdersSubInfo)
        Dim osc As New Orders.OrdersSubController
        osi = osc.OrdersSub_GetList(Nothing, txtMo.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If osi.Count = 0 Then Exit Sub
        'If osi(0).OS_Check = True Then
        '    Dim obc As New Orders.OrdersBomController
        '    Dim tlist As List(Of Orders.OrdersBomInfo)
        '    ds.Tables("OrdersBom").Rows.Clear()
        '    tlist = obc.OrdersBom_GetList(Nothing, txtMo.Text, True, Nothing)
        '    If tlist Is Nothing Then Exit Sub

        '    On Error Resume Next
        '    Dim i As Integer
        '    Dim row As DataRow
        '    For i = 0 To tlist.Count - 1
        '        row = ds.Tables("OrdersBom").NewRow

        '        row("M_Code") = tlist(i).M_Code
        '        row("OB_Qty") = tlist(i).OB_Qty
        '        row("OB_MakeRemark") = tlist(i).OB_MakeRemark
        '        row("OB_Make") = tlist(i).OB_Make

        '        row("OB_Supplier") = tlist(i).OB_Supplier
        '        row("OB_SupplierNo") = tlist(i).OB_SupplierNo
        '        row("M_Name") = tlist(i).M_Name
        '        row("M_Gauge") = tlist(i).M_Gauge
        '        '    row("M_Unit") = tList(i).M_Unit
        '        '  row("PM_LVL") = tList(i).PM_LVL
        '        row("OB_AccountCheck") = tlist(i).OB_AccountCheck
        '        row("OB_Key") = tlist(i).OB_Key
        '        row("OB_PID") = tlist(i).OB_PID
        '        row("PM_LVL") = tlist(i).PM_LVL
        '        row("M_CodeType") = tlist(i).M_CodeType
        '        row("M_CodeMouldNO") = tlist(i).M_CodeMouldNO
        '        row("OB_MakeDepartment") = tlist(i).OB_MakeDepartment
        '        row("OB_MModeCusterNO") = tlist(i).OB_MModeCusterNO
        '        row("OB_Product") = tlist(i).OB_Product
        '        row("GoIn") = False
        '        ds.Tables("OrdersBom").Rows.Add(row)
        '    Next

        '    Grid2.ExpandAll()

        '    If ds.Tables("OrdersBom").Rows.Count = 0 Then
        '        MsgBox("未載入產品配件資料或產品資料配件未建立！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)

        '    End If
        'Else
        '    MsgBox("此批次未經審核或無物料清單", , "提示")
        'End If

        Dim obc As New Orders.OrdersBomController
        Dim tlist As List(Of Orders.OrdersBomInfo)
        ds.Tables("OrdersBom").Rows.Clear()
        tlist = obc.OrdersBom_GetList(Nothing, txtMo.Text, Nothing, Nothing)
        If tlist Is Nothing Then Exit Sub

        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To tlist.Count - 1
            row = ds.Tables("OrdersBom").NewRow

            row("M_Code") = tlist(i).M_Code
            row("OB_Qty") = tlist(i).OB_Qty
            row("OB_MakeRemark") = tlist(i).OB_MakeRemark
            row("OB_Make") = tlist(i).OB_Make

            row("OB_Supplier") = tlist(i).OB_Supplier
            row("OB_SupplierNo") = tlist(i).OB_SupplierNo
            row("M_Name") = tlist(i).M_Name
            row("M_Gauge") = tlist(i).M_Gauge
            '    row("M_Unit") = tList(i).M_Unit
            '  row("PM_LVL") = tList(i).PM_LVL
            row("OB_AccountCheck") = tlist(i).OB_AccountCheck
            row("OB_Key") = tlist(i).OB_Key
            row("OB_PID") = tlist(i).OB_PID
            row("PM_LVL") = tlist(i).PM_LVL
            row("M_CodeType") = tlist(i).M_CodeType
            row("M_CodeMouldNO") = tlist(i).M_CodeMouldNO
            row("OB_MakeDepartment") = tlist(i).OB_MakeDepartment
            row("OB_MModeCusterNO") = tlist(i).OB_MModeCusterNO
            row("OB_Product") = tlist(i).OB_Product
            row("GoIn") = False
            ds.Tables("OrdersBom").Rows.Add(row)
        Next

        Grid2.ExpandAll()

        If ds.Tables("OrdersBom").Rows.Count = 0 Then
            MsgBox("未載入產品配件資料或產品資料配件未建立！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)

        End If

    End Sub

    Sub CreateLFIDTable()
        dl.Tables.Clear()
        With dl.Tables.Add("Pro_Mounting_New")

            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_ID", GetType(Integer))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_CodePID", GetType(String))
            .Columns.Add("PM_Qty", GetType(Double))
            .Columns.Add("PM_MakeRemark", GetType(String))
            .Columns.Add("PM_Make", GetType(Boolean))
            .Columns.Add("PM_Check", GetType(Boolean))
            .Columns.Add("M_Supplier", GetType(String))
            .Columns.Add("M_SupplierNo", GetType(String))
            .Columns.Add("PM_Key", GetType(String))
            .Columns.Add("PM_PID", GetType(String))
            .Columns.Add("PM_LVL", GetType(Integer))
            .Columns.Add("M_CodeType", GetType(String))
            .Columns.Add("M_CodeMouldNO", GetType(String))

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))

            .Columns.Add("GoIn", GetType(Boolean))

        End With
        TreeList1.DataSource = dl.Tables("Pro_Mounting_New")
    End Sub
    Sub LoadProductBomData()
        Dim pi As List(Of ProductBomInfo)
        Dim pbc As New ProductBomController
        dl.Tables("Pro_Mounting_New").Rows.Clear()
        If Label5.Text = "生產倉庫調撥" Then
            pi = pbc.Prod_Mounting_New_GetList(txtLFID.Text.Trim, Nothing, Nothing, 1, Nothing, Nothing, True)
        Else
            pi = pbc.ProductBom_GetList(txtLFID.Text, Nothing, Nothing, Nothing, Nothing, True)
        End If

        If pi.Count <= 0 Then
            MsgBox("產品資料配件未建立！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow

        row = dl.Tables("Pro_Mounting_New").NewRow

        row("M_Code") = txtLFID.Text
        row("M_CodePID") = pi(0).M_CodePID
        row("PM_Qty") = pi(0).PM_Qty
        row("PM_MakeRemark") = pi(0).PM_MakeRemark

        row("PM_Make") = pi(0).PM_Make
        row("M_Supplier") = pi(0).M_Supplier
        row("M_SupplierNo") = pi(0).M_SupplierNo
        row("M_Name") = txtLFID.Text
        'row("M_Gauge") = pi(0).M_Gauge
        '    row("M_Unit") = tList(i).M_Unit
        '  row("PM_LVL") = tList(i).PM_LVL
        row("PM_Check") = pi(0).PM_Check
        row("PM_Key") = pi(0).PM_PID
        row("PM_PID") = "dd"
        'row("PM_LVL") = 0
        row("M_CodeType") = pi(0).M_CodeType

        row("M_CodeMouldNO") = pi(0).M_CodeMouldNO
        row("GoIn") = False

        dl.Tables("Pro_Mounting_New").Rows.Add(row)

        For i = 0 To pi.Count - 1
            row = dl.Tables("Pro_Mounting_New").NewRow

            'row("PM_M_Code") = pi(i).PM_M_Code
            row("M_Code") = pi(i).M_Code
            row("M_CodePID") = pi(i).M_CodePID
            row("PM_Qty") = pi(i).PM_Qty
            row("PM_MakeRemark") = pi(i).PM_MakeRemark

            row("PM_Make") = pi(i).PM_Make
            row("M_Supplier") = pi(i).M_Supplier
            row("M_SupplierNo") = pi(i).M_SupplierNo
            row("M_Name") = pi(i).M_Name
            row("M_Gauge") = pi(i).M_Gauge
            '    row("M_Unit") = tList(i).M_Unit
            '  row("PM_LVL") = tList(i).PM_LVL
            row("PM_Check") = pi(i).PM_Check
            row("PM_Key") = pi(i).PM_Key
            row("PM_PID") = pi(i).PM_PID
            row("PM_LVL") = pi(i).PM_LVL
            row("M_CodeType") = pi(i).M_CodeType

            row("M_CodeMouldNO") = pi(i).M_CodeMouldNO
            row("GoIn") = False

            dl.Tables("Pro_Mounting_New").Rows.Add(row)
        Next
        TreeList1.ExpandAll()
    End Sub

    Private Sub Grid2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid2.MouseUp
        If Grid2.Nodes.Count = 0 Then Exit Sub
        If Label5.Text = "採購管理" Then
            If Grid2.FocusedNode("OB_Product").ToString = "不需採購" Or Grid2.FocusedNode("OB_Product").ToString = "待復" Then
                GoIn.OptionsColumn.AllowEdit = False
                MsgBox("此物料目前還不能被採購", , "提示")
                Exit Sub
            Else
                GoIn.OptionsColumn.AllowEdit = True
            End If
        Else
            GoIn.OptionsColumn.AllowEdit = True
        End If
    End Sub


    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pic As New ProductInventoryController
        Dim wtc As New WareInventoryMTController

        GridControl1.Visible = True
        If Label4.Text = "W1101" Then
            GridControl1.DataSource = pic.ProductInventory_GetList(GridView1.GetFocusedRowCellValue("M_Code").ToString, Nothing, Label4.Text, Nothing)
        Else
            GridControl1.DataSource = wtc.WareInventory_GetList3(GridView1.GetFocusedRowCellValue("M_Code").ToString, Label4.Text, "True")
        End If

    End Sub
    '指定物料集
    Private Sub cmdWare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdWare.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim i As Integer
        Dim str As String
        str = Nothing
        For i = 0 To ds.Tables("MaterialCode").Rows.Count - 1
            str = str & "," & "'" & ds.Tables("MaterialCode").Rows(i)("M_Code") & "'"
        Next
        'tempCode = Mid(str, 2, Len(str))
        tempCode = str
        Me.Close()
    End Sub
    Sub CreateMaterialCode()
        ds.Tables.Clear()
        With ds.Tables.Add("MaterialCode")
            .Columns.Add("GoINM_code", GetType(Boolean))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("M_SupplierNo", GetType(String))

        End With
        Grid.DataSource = ds.Tables("MaterialCode")
    End Sub
    Sub LoadMaterialCodeData()

        Dim mi As List(Of MaterialInfo)
        Dim mc As New MaterialController
        Dim strCode, strName, strTypeID, strGauge, strSupplierNo As String

        If CheckEdit7.Checked = True Then
            If PopupContainerEdit1.EditValue Is Nothing Then
                MsgBox("沒有選擇類別,請選擇!", , "提示")
                Exit Sub
            Else
                strTypeID = PopupContainerEdit1.EditValue
            End If
        Else
            strTypeID = Nothing 'ErpUser.MaterialType

        End If
        If CheckEdit4.Checked = True Then
            If Len(txtCode.EditValue) = 0 Then
                MsgBox("沒有輸入物料編碼,請輸入!", , "提示")
                Exit Sub
            Else
                strCode = txtCode.EditValue
            End If
        Else
            strCode = Nothing
        End If
        If CheckEdit6.Checked = True Then
            If Len(txtName.EditValue) = 0 Then
                MsgBox("沒有輸入物料名稱,請輸入!", , "提示")
                Exit Sub
            Else
                strName = txtName.EditValue
            End If
        Else
            strName = Nothing
        End If
        If CheckEdit2.Checked = True Then
            If Len(txtGauge.EditValue) = 0 Then
                MsgBox("沒有輸入物料規格,請輸入!", , "提示")
                Exit Sub
            Else
                strGauge = txtGauge.EditValue
            End If
        Else
            strGauge = Nothing
        End If

        If CheckEdit1.Checked = True Then
            If Len(TextEdit2.EditValue) = 0 Then
                MsgBox("沒有輸入供應商編號,請輸入!", , "提示")
                Exit Sub
            Else
                strSupplierNo = TextEdit2.EditValue
            End If
        Else
            strSupplierNo = Nothing
        End If

        '***判斷用戶是擁有特殊類的權限
        Dim pmws2 As New PermissionModuleWarrantSubController
        Dim pmwiL2 As List(Of PermissionModuleWarrantSubInfo)
        Dim Stra As String
        Stra = "否"
        pmwiL2 = pmws2.PermissionModuleWarrantSub_GetList(InUserID, "100115")

        If pmwiL2.Item(0).PMWS_Value = "是" Then
            Stra = "是"
        End If

        '************
        mi = mc.MaterialCode_GetList(strCode, strName, strGauge, strTypeID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strSupplierNo, Stra)
        If mi.Count = 0 Then Exit Sub

        Dim i As Integer
        Dim row As DataRow
        ds.Tables("MaterialCode").Clear()

        For i = 0 To mi.Count - 1
            row = ds.Tables("MaterialCode").NewRow
            row("GoINM_code") = False
            row("M_Code") = mi(i).M_Code
            row("M_Name") = mi(i).M_Name
            row("M_Gauge") = mi(i).M_Gauge
            row("M_Unit") = mi(i).M_Unit
            row("M_SupplierNo") = mi(i).M_SupplierNo

            ds.Tables("MaterialCode").Rows.Add(row)
        Next

    End Sub

    Sub LoadInventoryData()
        Dim mi As List(Of WareInventoryInfo)
        Dim mc As New WareInventoryMTController
        Dim strCode, strName, strTypeID, strGauge As String

        If CheckEdit7.Checked = True Then
            If PopupContainerEdit1.EditValue Is Nothing Then
                MsgBox("沒有選擇類別,請選擇!", , "提示")
                Exit Sub
            Else
                strTypeID = PopupContainerEdit1.EditValue
            End If
        Else
            strTypeID = Nothing 'ErpUser.MaterialType

        End If
        If CheckEdit4.Checked = True Then
            If Len(txtCode.EditValue) = 0 Then
                MsgBox("沒有輸入物料編碼,請輸入!", , "提示")
                Exit Sub
            Else
                strCode = txtCode.EditValue
            End If
        Else
            strCode = Nothing
        End If
        If CheckEdit6.Checked = True Then
            If Len(txtName.EditValue) = 0 Then
                MsgBox("沒有輸入物料名稱,請輸入!", , "提示")
                Exit Sub
            Else
                strName = txtName.EditValue
            End If
        Else
            strName = Nothing
        End If
        If CheckEdit2.Checked = True Then
            If Len(txtGauge.EditValue) = 0 Then
                MsgBox("沒有輸入物料規格,請輸入!", , "提示")
                Exit Sub
            Else
                strGauge = txtGauge.EditValue
            End If
        Else
            strGauge = Nothing
        End If


        mi = mc.WareInventory_SelectCode(strCode, strName, strGauge, Label4.Text)
        If mi.Count = 0 Then Exit Sub

        Dim i As Integer
        Dim row As DataRow

        For i = 0 To mi.Count - 1
            row = ds.Tables("MaterialCode").NewRow
            row("GoINM_code") = False
            row("M_Code") = mi(i).M_Code
            row("M_Name") = mi(i).M_Name
            row("M_Gauge") = mi(i).M_Gauge
            row("M_Unit") = mi(i).M_Unit
            row("M_SupplierNo") = mi(i).M_SupplierNo

            ds.Tables("MaterialCode").Rows.Add(row)
        Next
    End Sub

    Private Sub txtName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtName.KeyDown, txtCode.KeyDown, txtGauge.KeyDown, TextEdit2.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSeek_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtLFID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            SimpleButton2_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        cmdSave_Click(Nothing, Nothing)
    End Sub

    Private Sub CheckEdit7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit7.CheckedChanged
        If CheckEdit7.Checked = True Then
            PopupContainerEdit1.Focus()
        End If
    End Sub

    Private Sub CheckEdit4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit4.CheckedChanged
        If CheckEdit4.Checked = True Then
            txtCode.Focus()
        End If
    End Sub

    Private Sub CheckEdit6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit6.CheckedChanged
        If CheckEdit6.Checked = True Then
            txtName.Focus()
        End If
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked = True Then
            txtGauge.Focus()
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            TextEdit2.Focus()
        End If
    End Sub

    Private Sub cmdAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAll.Click
        LoadMaterialCodeData()
    End Sub

    Private Sub RepositoryItemCheckEdit6_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit6.CheckedChanged
        If Label5.Text = "申購單管理" Then
            If sender.checked = True Then
                If TreeList1.FocusedNode.FirstNode Is Nothing Then

                Else
                    If MsgBox("物料(" & TreeList1.FocusedNode("M_Name") & ")存在子物料，是否要採購？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "提示") = MsgBoxResult.No Then
                        TreeList1.FocusedNode("GoIn") = False
                    End If
                End If
            End If
        End If
    End Sub

    '@ 2012/3/19 添加
    '復選框失去焦點事件，判斷選中物料是否有子物料
    Private Sub RepositoryItemCheckEdit6_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit6.Leave
        'If Label5.Text = "申購單管理" Then
        '    If TreeList1.FocusedNode("GoIn") = True Then
        '        If TreeList1.FocusedNode.FirstNode Is Nothing Then

        '        Else
        '            If MsgBox("物料(" & TreeList1.FocusedNode("M_Name") & ")存在子物料，是否要採購？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "提示") = MsgBoxResult.No Then
        '                TreeList1.FocusedNode("GoIn") = False
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    '@ 2013/3/18 添加
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSave_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub SelectButtonAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectButtonAll.Click
        If BatchLoad = "B" Then

            If GridView1.RowCount <= 0 Then
                Exit Sub
            End If

            If ds.Tables("MaterialCode").Rows.Count <= 0 Then
                Exit Sub
            End If

            Dim x As Integer
            If SelectButtonAll.Text = "全選" Then
                For x = 0 To ds.Tables("MaterialCode").Rows.Count - 1
                    ds.Tables("MaterialCode").Rows(x)("GoINM_code") = True
                Next
                SelectButtonAll.Text = "全部取消"
            Else
                For x = 0 To ds.Tables("MaterialCode").Rows.Count - 1
                    ds.Tables("MaterialCode").Rows(x)("GoINM_code") = False
                Next
                SelectButtonAll.Text = "全選"
            End If

        End If
    End Sub


    Sub LoadPM_M_Code(ByVal strGluDep As String)
        ''2013-10-18產品動態增加
        dsNew.Clear()
        With dsNew.Tables.Add("PM_M_Code")
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_JiYu", GetType(String))
        End With
        txtLFID.Properties.ValueMember = "PM_M_Code"
        txtLFID.Properties.DisplayMember = "PM_M_Code"
        txtLFID.Properties.DataSource = dsNew.Tables("PM_M_Code")
        '-------------------------------------------------------------------------
        Dim mi As New List(Of LFERP.Library.Production.Datasetting.ProductionDataSettingInfo)
        Dim mc As New LFERP.Library.Production.Datasetting.ProductionDataSettingControl
        mi = mc.ProductionUser_GetList(strGluDep, Nothing)

        dsNew.Tables("PM_M_Code").Clear()

        If mi.Count > 0 Then    '判斷是否有權限限制
            Dim row As DataRow
            Dim j As Integer
            For j = 0 To mi.Count - 1
                row = dsNew.Tables("PM_M_Code").NewRow
                row("PM_M_Code") = mi(j).PM_M_Code
                row("PM_JiYu") = mi(j).PM_JiYu '
                dsNew.Tables("PM_M_Code").Rows.Add(row)
            Next
        Else
            Dim row As DataRow
            Dim j As Integer

            Dim mpi As New List(Of ProcessMainInfo)
            Dim mpc As New ProcessMainControl
            mpi = mpc.ProcessMain_GetList3(Nothing, Nothing)

            If mpi.Count > 0 Then
                For j = 0 To mpi.Count - 1
                    row = dsNew.Tables("PM_M_Code").NewRow
                    row("PM_M_Code") = mpi(j).PM_M_Code
                    row("PM_JiYu") = mpi(j).PM_JiYu '
                    dsNew.Tables("PM_M_Code").Rows.Add(row)
                Next
            End If

        End If
    End Sub


End Class
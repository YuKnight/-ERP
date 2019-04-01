Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.DataSetting
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess

Imports LFERP.SystemManager

Public Class frmProduct
    Private fs As IO.FileStream
    Dim mtc As New Material.MaterialTypeController
    Dim mtd As New CusterControler
    Dim mSupplier As New SuppliersControler
    Dim mc As New MaterialController
    Dim intTempID As Integer
    Dim mtP As New ProductController

    Dim pmc As New ProcessMainControl

    Dim OldM_Gauge As String

    Dim OldpopTypeID As String
    Dim OldCheck As Boolean
    Dim boolSample As Boolean = False '李超新增


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tempValue = ""
        Me.Close()

    End Sub

    Private Sub frmProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '需要判斷是磨刀部使用，還是其他廠區使用。
        '磨刀部使用時物料類型為60.其他均為40  2012/12/12

        '   mtc.LoadNodes(tv1, "40")
        Dim mtc As New Material.MaterialTypeController

        '' 為磨刀部
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200112")
        If pmwiL.Count > 0 Then
            If pmwiL(0).PMWS_Value.ToString <> "" Then
                mtc.LoadNodes(tv1, pmwiL(0).PMWS_Value.ToString)    '只選擇成品類
            Else
                mtc.LoadNodes(tv1, "40")    '只選擇成品類
            End If
        Else
            mtc.LoadNodes(tv1, "40")    '只選擇成品類
        End If

        ''''''''''''''''''''''''''''''''''''''''''''李超新增
        Me.popTypeID.Properties.PopupControl = Me.PopupContainerControl1
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200117") '樣辦
        If pmwiL.Count > 0 Then
            boolSample = True
            Me.XtraTabPage1.PageVisible = False
            Me.XtraTabPage4.PageVisible = True
            Me.XtraTabControl1.SelectedTabPage = XtraTabPage4
            txtLFID1.Focus()
            Me.popTypeID1.Properties.PopupControl = Me.PopupContainerControl1
        End If

        Dim mtd As New CusterControler
        Dim cclist As New List(Of CusterInfo)
        cclist = mtd.GetCusterList(Nothing, Nothing, Nothing)
        gluCuster.Properties.DisplayMember = "C_CusterID"
        gluCuster.Properties.ValueMember = "C_CusterID"
        gluCuster.Properties.DataSource = cclist

        gluCuster1.Properties.DisplayMember = "C_CusterID"
        gluCuster1.Properties.ValueMember = "C_CusterID"
        gluCuster1.Properties.DataSource = cclist
        ''''''''''''''''''''''''''''''''''''''''''''

        rgluSupplier.DisplayMember = "S_Supplier"
        rgluSupplier.ValueMember = "S_Supplier"
        '  rgluSupplier.DataSource = mSupplier.GetSupplierList(Nothing, Nothing, ErpUser.SupplierType)
        rgluSupplier.DataSource = mSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")

        CreateTables()
        Label4.Text = tempValue
        tempValue = ""

        Select Case Label4.Text

            Case "Product"
                If Edit = False Then
                    Label1.Text = "產品資料--新增"
                    TreeListColumn8.OptionsColumn.AllowEdit = False
                    getAutoPM_M_Code()
                Else
                    Label1.Text = "產品資料--修改"
                    txtLFID.Enabled = False
                    txtLFID1.Enabled = False
                    'popTypeID.Enabled = False

                    trere.OptionsColumn.AllowEdit = True
                    TreeListColumn8.OptionsColumn.AllowEdit = False

                    If LoadData(txtLFID.EditValue) = False Then Me.Close()
                End If
                txtLFID.Select()
            Case "Copy"
                txtLFID.Enabled = True
                txtLFID1.Enabled = True
                Label1.Text = "產品資料--復制"

                popTypeID.Enabled = False
                popTypeID1.Enabled = False
                If LoadData(txtLFID.EditValue) = False Then Me.Close()
                TreeListColumn8.OptionsColumn.AllowEdit = False
                txtLFID.Enabled = True
                txtLFID.Text = ""
                txtLFID.Select()
            Case "PreView"
                Label1.Text = "產品資料--查看"
                LoadData(txtLFID.EditValue)
                cmdSave.Visible = False
                txtLFID.Enabled = False
                txtLFID1.Enabled = False
            Case "Check"
                Label1.Text = "產品資料--核對資料"
                LoadData(txtLFID.EditValue)

                trere.OptionsColumn.AllowEdit = False
                TreeListColumn8.OptionsColumn.AllowEdit = True
                ViewEnable()
            Case "ProCheck"

                Label1.Text = "產品資料--鎖定"
                LoadData(txtLFID.EditValue)

                trere.OptionsColumn.AllowEdit = False
                TreeListColumn8.OptionsColumn.AllowEdit = False
                ViewEnable()

                Panel2.Visible = True

        End Select

        Me.Text = Label1.Text

    End Sub

    Private Sub tv1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tv1.MouseDoubleClick
        '獲取選擇的類別編號
        If tv1.SelectedNode.Level = 3 Then
            If boolSample Then '李超修改
                popTypeID1.Tag = tv1.SelectedNode.Tag
                popTypeID1.EditValue = tv1.SelectedNode.Text
            Else
                popTypeID.Tag = tv1.SelectedNode.Tag
                popTypeID.EditValue = tv1.SelectedNode.Text
            End If

            txtJiYu.Text = tv1.SelectedNode.Text

            PopupContainerControl1.OwnerEdit.ClosePopup()
        End If
    End Sub

    Private Sub cmdOpenPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpenPhoto.Click
        On Error Resume Next
        Dim ofd As New OpenFileDialog
        ofd.Filter = "圖片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp"
        ofd.ShowDialog()
        If ofd.FileName.ToString = "" Then Exit Sub
        fs = New IO.FileStream(ofd.FileName.ToString, IO.FileMode.Open, IO.FileAccess.Read)
        pPhoto.Image = Image.FromFile(ofd.FileName.ToString)

    End Sub

    Private Sub cmdDelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelPhoto.Click
        pPhoto.Image = Nothing
    End Sub

    Sub CreateTables()
        '子物料數據
        dsBom.Tables.Clear()
        '創建數據表
        With dsBom.Tables.Add("Prod_Mounting_New")
            .Columns.Add("PM_M_Code", GetType(String)) '聯豐編號
            .Columns.Add("PM_ID", GetType(Integer))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_CodePID", GetType(String))
            .Columns.Add("PM_Qty", GetType(Double))
            .Columns.Add("PM_MakeRemark", GetType(String))
            .Columns.Add("PM_Make", GetType(Boolean))
            .Columns.Add("PM_Check", GetType(Boolean))
            .Columns.Add("M_Supplier", GetType(String))
            .Columns.Add("M_SupplierNo", GetType(String))
            .Columns.Add("IsNew", GetType(Boolean))    '是否新增

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("PM_LVL", GetType(Integer))
            .Columns.Add("PM_Key", GetType(String))
            .Columns.Add("PM_PID", GetType(String))
            .Columns.Add("M_CodeType", GetType(String))
            .Columns.Add("M_CodeMouldNO", GetType(String))
            .Columns.Add("M_Weight", GetType(Single))


        End With
        '創建刪除數據表
        With dsBom.Tables.Add("DelData")
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Key", GetType(String))
        End With
        '綁定表格
        Grid.DataSource = dsBom.Tables("Prod_Mounting_New")

    End Sub


    Sub LoadBomNewSubToTable(ByVal tList As List(Of ProductBomInfo))
        '導入選定配件下的所有子物料
        '沒有子物料則退出
        If tList Is Nothing Then Exit Sub

        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To tList.Count - 1
            row = dsBom.Tables("Prod_Mounting_New").NewRow
            row("PM_M_Code") = tList(i).PM_M_Code
            row("PM_ID") = intTempID
            row("M_Code") = tList(i).M_Code
            row("M_CodePID") = tList(i).M_CodePID
            row("PM_Qty") = tList(i).PM_Qty
            row("PM_MakeRemark") = tList(i).PM_MakeRemark
            row("PM_Make") = False
            row("PM_Check") = False
            row("M_Supplier") = tList(i).M_Supplier
            row("M_SupplierNo") = tList(i).M_SupplierNo
            row("IsNew") = True
            row("M_Name") = tList(i).M_Name
            row("M_Gauge") = tList(i).M_Gauge
            row("M_Unit") = tList(i).M_Unit
            row("PM_LVL") = tList(i).PM_LVL
            row("PM_Key") = tList(i).PM_Key
            row("PM_PID") = tList(i).PM_PID

            row("M_CodeType") = tList(i).M_CodeType
            row("M_CodeMouldNO") = tList(i).M_CodeMouldNO
            row("M_Weight") = tList(i).M_Weight

            dsBom.Tables("Prod_Mounting_New").Rows.Add(row)
        Next


    End Sub

    


    Sub AddRow(ByVal strCode As String)
        If strCode = "" Then
        Else
            Dim objInfo As New MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)
            Dim row As DataRow
            row = dsBom.Tables("Prod_Mounting_New").NewRow

            ''row("PM_M_Code") = txtLFID.Text
            'intTempID = GetP_ID()
            intTempID = 1

            row("PM_ID") = intTempID
            row("M_Code") = objInfo.M_Code
            If Me.boolSample Then
                row("M_CodePID") = txtLFID1.Text
            Else
                row("M_CodePID") = txtLFID.Text
            End If

            row("PM_Qty") = 0
            row("PM_MakeRemark") = ""
            row("PM_Make") = False
            row("PM_Check") = False
            row("M_Supplier") = objInfo.M_Supplier
            row("M_SupplierNo") = objInfo.M_SupplierNo
            row("IsNew") = True
            row("M_Name") = objInfo.M_Name
            row("M_Gauge") = objInfo.M_Gauge
            row("M_Unit") = objInfo.M_Unit
            row("PM_LVL") = 0
            row("PM_Key") = objInfo.M_Code & "."
            If Me.boolSample Then
                row("PM_PID") = txtLFID1.Text
            Else
                row("PM_PID") = txtLFID.Text
            End If

            row("M_CodeType") = ""
            row("M_CodeMouldNO") = ""
            row("M_Weight") = 0

            dsBom.Tables("Prod_Mounting_New").Rows.Add(row)

        End If
    End Sub

    Private Sub popBomAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBomAdd.Click
        On Error Resume Next
        tempCode = ""
        Dim fr As frmBiaMai
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmBiaMai Then
                'fr.Activate()
                fr.Close()
                Exit Sub
            End If
        Next
        fr = New frmBiaMai
        ' fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.ShowIcon = False
        fr.ShowInTaskbar = False
        fr.cmdAddSub.Visible = True
        fr.cmdCopy.Visible = False
        fr.cmdNew.Visible = False
        fr.ShowDialog()


        If tempCode = "" Then Exit Sub

        '增加記錄

        If tempCode = txtLFID.Text Or tempCode = txtLFID1.Text Then
            MsgBox("不可以選擇主物料編碼!", , "提示")
            Exit Sub
        Else
            If CheckSelectBom(tempCode) = True Then
                MsgBox("此配件已加入,不可以重復,請重新選擇", , "警告")
                Exit Sub
            Else
                AddRow(tempCode)
                Dim mPB As New ProductBomController
                '取得子物料
                LoadBomNewSubToTable(mPB.GetMaterialCodeSubList(tempCode))
                Grid.ExpandAll()
            End If

        End If
        tempCode = ""
    End Sub
    Function GetP_ID() As Integer
        '取得序號
        On Error Resume Next
        Dim i As Long
        Dim l As Long
        For i = 0 To dsBom.Tables("Prod_Mounting_New").Rows.Count - 1
            If dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_LVL") = 0 Then
                l = l + 1
            End If
        Next
        GetP_ID = l + 1
    End Function
    Function CheckSelectBom(ByVal strCode) As Boolean
        '檢查選擇的子物料是否已加入
        Dim i As Long
        CheckSelectBom = False
        For i = 0 To dsBom.Tables("Prod_Mounting_New").Rows.Count - 1
            If dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_LVL") = 0 Then
                If dsBom.Tables("Prod_Mounting_New").Rows(i)("M_Code") = strCode Then
                    MsgBox(dsBom.Tables("Prod_Mounting_New").Rows(i)("M_Code"))
                    CheckSelectBom = True
                    Exit Function
                Else
                    CheckSelectBom = False
                End If
            End If
        Next

    End Function

    'Sub AddDelData(ByVal strKey As String)
    '    '添加要刪除的記錄到DelData表
    '    Dim i As Long
    '    Dim l As Long
    '    Dim row As DataRow
    '    l = Len(strKey)
    '    For i = 0 To dsBom.Tables("DelData").Rows.Count - 1
    '        If Mid(dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Key"), l) = strKey Then
    '            row = dsBom.Tables("Prod_Mounting_New").NewRow
    '            row("PM_Key") = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Key")
    '            row("PM_M_Code") = txtLFID.Text
    '            dsBom.Tables("DelData").Rows.Add(row)
    '        End If
    '    Next

    'End Sub

    Private Sub popBomDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popBomDel.Click

        Dim strTemp As String
        strTemp = ""
        If Not Grid.FocusedNode Is Nothing Then
            If Grid.FocusedNode.Level > 0 Then
                MsgBox("這不是第一層,請選擇第一層配件!", , "提示")
            Else

                Dim pmi As List(Of ProcessMainInfo)

                pmi = pmc.ProcessMain_GetList1(Nothing, txtLFID.Text, Nothing, Grid.FocusedNode.Item("M_Code").ToString)

                If pmi.Count > 0 Then
                    MsgBox("此物料在生產中已建立工藝流程,不允許刪除!")
                    Exit Sub
                End If

                '在刪除表中增加被刪除的記錄
                Dim row As DataRow = dsBom.Tables("DelData").NewRow
                'row("AutoID") = DelTemp
                row("PM_M_Code") = txtLFID.Text
                row("PM_Key") = Grid.FocusedNode.Item("PM_Key").ToString
                strTemp = Grid.FocusedNode.Item("PM_Key").ToString
                dsBom.Tables("DelData").Rows.Add(row)
            End If

            '檢查DataSet中相同的記錄,并刪除
            For Each DR As DataRow In dsBom.Tables("Prod_Mounting_New").Select("PM_Key Like '" & strTemp & "%'")
                dsBom.Tables("Prod_Mounting_New").Rows.Remove(DR)
            Next



        End If
    End Sub

    

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If boolSample Then
            If Len(txtLFID1.Text) = 0 Then
                MsgBox("沒有輸入產品編號!")
                Exit Sub
            ElseIf Len(popTypeID1.Text) = 0 Then
                MsgBox("沒有選擇產品類型!")
                Exit Sub
            End If
        Else
            If Len(txtLFID.Text) = 0 Then
                MsgBox("沒有輸入產品編號!")
                Exit Sub
            ElseIf Len(popTypeID.Text) = 0 Then
                MsgBox("沒有選擇產品類型!")
                Exit Sub
            End If
        End If


        If txtLFID.Enabled = True Or txtLFID1.Enabled = True Then
            '檢查是否已存在此編號
            If boolSample Then
                If mc.MaterialCode_Get(txtLFID1.Text) Is Nothing Then
                Else
                    MsgBox("此產品編號已存在，請重新輸入新編號", , "提示")
                    txtLFID1.Text = ""
                    txtLFID1.Focus()
                    Exit Sub
                End If
            Else
                If mc.MaterialCode_Get(txtLFID.Text) Is Nothing Then
                Else
                    MsgBox("此產品編號已存在，請重新輸入新編號", , "提示")
                    txtLFID.Text = ""
                    txtLFID.Focus()
                    Exit Sub
                End If
            End If
        End If

        '----------------------------------------------------------------------
        Dim StratCheck As Boolean = False
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200116")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then StratCheck = True
        End If

        ''ProCheck  在保存時界面停留,其它人審核
        If boolSample Then
            If Label4.Text <> "ProCheck" And StratCheck = False Then
                Dim ol As ProductInfo
                Dim oc As New ProductController

                ol = oc.Product_Get(txtLFID1.Text)
                If ol Is Nothing Then
                Else
                    If ol.M_IsEnabled = True Then
                        MsgBox("不能修改,此編號已審核!")
                    End If
                End If
            End If
        Else
            If Label4.Text <> "ProCheck" And StratCheck = False Then
                Dim ol As ProductInfo
                Dim oc As New ProductController

                ol = oc.Product_Get(txtLFID.Text)
                If ol Is Nothing Then
                Else
                    If ol.M_IsEnabled = True Then
                        MsgBox("不能修改,此編號已審核!")
                    End If
                End If
            End If
        End If
 
        '-------------------------------------------




        Select Case Label4.Text

            Case "Product"
                If boolSample Then
                    ''針對磨刀部 加檢查規格信息2013-5-9
                    If CheckM_Gauge(Me.TxtM_Gauge1.Text) = False Then
                        Exit Sub
                    End If

                    If Edit = True And OldpopTypeID <> "" Then  ''2013-7-9修改時要檢查,不能跨大類
                        If Mid(OldpopTypeID, 1, 2) <> Mid(popTypeID1.Tag, 1, 2) Then
                            popTypeID1.Select()
                            MsgBox("不能跨大類修改,類別！")
                            Exit Sub
                        End If
                    End If
                Else
                    ''針對磨刀部 加檢查規格信息2013-5-9
                    If CheckM_Gauge(Me.TxtM_Gauge.Text) = False Then
                        Exit Sub
                    End If

                    If Edit = True And OldpopTypeID <> "" Then  ''2013-7-9修改時要檢查,不能跨大類
                        If Mid(OldpopTypeID, 1, 2) <> Mid(popTypeID.Tag, 1, 2) Then
                            popTypeID.Select()
                            MsgBox("不能跨大類修改,類別！")
                            Exit Sub
                        End If
                    End If
                End If



                If Edit = False Then
                    SaveDataNew()
                Else
                    SaveDataEdit()
                End If

            Case "Copy"
                Dim i As Integer
                If boolSample Then
                    For i = 0 To dsBom.Tables("Prod_Mounting_New").Rows.Count - 1
                        dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_M_Code") = txtLFID1.Text
                        If dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodePID") = tempValue2 Then dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodePID") = txtLFID1.Text
                        dsBom.Tables("Prod_Mounting_New").Rows(i)("IsNew") = True
                        If dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_PID") = tempValue2 Then dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_PID") = txtLFID1.Text
                        dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Check") = False
                    Next
                Else
                    For i = 0 To dsBom.Tables("Prod_Mounting_New").Rows.Count - 1
                        dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_M_Code") = txtLFID.Text
                        If dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodePID") = tempValue2 Then dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodePID") = txtLFID.Text
                        dsBom.Tables("Prod_Mounting_New").Rows(i)("IsNew") = True
                        If dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_PID") = tempValue2 Then dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_PID") = txtLFID.Text
                        dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Check") = False
                    Next
                End If
  

                SaveDataNew()
                tempValue = ""
            Case "Check"
                UpdateCheck()

            Case "ProCheck" ''對整張單鎖定
                If OldCheck = Me.CheckBoxCheck.Checked Then
                    MsgBox("沒有變更審核狀態,請檢查!")
                    Exit Sub
                End If

                UpdateProCheck()


        End Select

        'If Edit = False Then
        '    SaveDataNew()
        'Else
        '    If tempValue = "Copy" Then
        '        '如果是復制的情況
        '        Dim i As Integer
        '        For i = 0 To dsBom.Tables("Prod_Mounting_New").Rows.Count - 1
        '            dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_M_Code") = txtLFID.Text
        '            If dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodePID") = tempValue2 Then dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodePID") = txtLFID.Text
        '            dsBom.Tables("Prod_Mounting_New").Rows(i)("IsNew") = True
        '            If dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_PID") = tempValue2 Then dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_PID") = txtLFID.Text
        '            dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Check") = False
        '        Next

        '        SaveDataNew()
        '        tempValue = ""
        '    ElseIf tempValue = "Check" Then
        '        UpdateCheck()
        '    Else
        '        SaveDataEdit()
        '    End If

        'End If
    End Sub

    Sub SaveDataNew()
        '保存新增資料
        Dim objInfo As New ProductInfo
        If boolSample Then
            objInfo.PM_M_Code = txtLFID1.EditValue
            objInfo.PM_CusterID = gluCuster1.EditValue
            objInfo.PM_CusterNO = txtCusterNo1.EditValue
            objInfo.PM_Weight = txtWeight1.EditValue
            objInfo.PM_Remark = txtRemark1.EditValue
            objInfo.M_Gauge = Me.TxtM_Gauge1.EditValue
            objInfo.Type3ID = popTypeID1.Tag
        Else
            objInfo.PM_M_Code = txtLFID.EditValue
            objInfo.PM_CusterID = gluCuster.EditValue
            objInfo.PM_CusterNO = txtCusterNo.EditValue
            objInfo.PM_Weight = txtWeight.EditValue
            objInfo.PM_Remark = txtRemark.EditValue
            objInfo.M_Gauge = Me.TxtM_Gauge.EditValue
            objInfo.Type3ID = popTypeID.Tag
        End If

        objInfo.PM_Action = InUserID
        objInfo.PM_Check = ""
        objInfo.PM_Rank = txtRank.EditValue
        objInfo.PM_JiYu = txtJiYu.EditValue
        objInfo.PM_BoWei = txtBoWei.EditValue
        objInfo.PM_FangShui = txtFangShui.EditValue
        objInfo.PM_ZhuHe = txtZhuHe.EditValue
        objInfo.PM_Dai = txtDai.EditValue
        objInfo.PM_Spare = CSng(txtSpare.EditValue)
        objInfo.PM_Price = 0
        objInfo.PM_DiNaZi = txtDiNaZi.EditValue
        objInfo.PM_DiWaiZi = txtDiWaiZi.EditValue
        objInfo.PM_EditDate = Now
        objInfo.PM_AddDate = Now
        objInfo.PM_Image = ImageToByte(pPhoto.Image)


        If mtP.Product_Add(objInfo) = True Then
            '保存子物料
            UpdateProductBom()
            'MsgBox("保存成功", , "提示")
            Me.Close()
        Else
            'MsgBox("保存失敗,請檢查錯誤!", , "提示")
        End If


    End Sub
    Sub SaveDataEdit()
        '保存新增資料
        Dim objInfo As New ProductInfo

        If boolSample Then
            objInfo.PM_M_Code = txtLFID1.EditValue
            objInfo.PM_CusterID = gluCuster1.EditValue
            objInfo.PM_CusterNO = txtCusterNo1.EditValue
            objInfo.PM_Weight = txtWeight1.EditValue
            objInfo.PM_Remark = txtRemark1.EditValue
            objInfo.M_Gauge = Me.TxtM_Gauge1.EditValue
            objInfo.Type3ID = popTypeID1.Tag
        Else
            objInfo.PM_M_Code = txtLFID.EditValue
            objInfo.PM_CusterID = gluCuster.EditValue
            objInfo.PM_CusterNO = txtCusterNo.EditValue
            objInfo.PM_Weight = txtWeight.EditValue
            objInfo.PM_Remark = txtRemark.EditValue
            objInfo.M_Gauge = Me.TxtM_Gauge.EditValue
            objInfo.Type3ID = popTypeID.Tag
        End If

        objInfo.PM_Action = InUserID
        objInfo.PM_Check = ""
        objInfo.PM_Rank = txtRank.EditValue
        objInfo.PM_JiYu = txtJiYu.EditValue
        objInfo.PM_BoWei = txtBoWei.EditValue
        objInfo.PM_FangShui = txtFangShui.EditValue
        objInfo.PM_ZhuHe = txtZhuHe.EditValue
        objInfo.PM_Dai = txtDai.EditValue
        objInfo.PM_Spare = CSng(txtSpare.EditValue)
        objInfo.PM_Price = 0
        objInfo.PM_DiNaZi = txtDiNaZi.EditValue
        objInfo.PM_DiWaiZi = txtDiWaiZi.EditValue
        objInfo.PM_EditDate = Now
        objInfo.PM_AddDate = Now
        objInfo.PM_Image = ImageToByte(pPhoto.Image)


        If mtP.Product_Update(objInfo) = True Then
            '保存子物料
            If UpdateProductBom() = True Then
                'MsgBox("保存成功", , "提示")
                Me.Close()
            Else
                MsgBox("子物料保存出現錯誤,請檢查后再試")
            End If


        Else
            MsgBox("保存失敗,請檢查錯誤!", , "提示")

        End If


    End Sub
    Sub UpdateCheck()
        '子配件審核操作
        Dim i As Integer
        Dim mtBom As New ProductBomController
        For i = 0 To dsBom.Tables("Prod_Mounting_New").Rows.Count - 1

            Dim objinfo As New ProductBomInfo
            If boolSample Then
                objinfo.PM_M_Code = txtLFID1.Text
            Else
                objinfo.PM_M_Code = txtLFID.Text
            End If

            objinfo.M_Code = dsBom.Tables("Prod_Mounting_New").Rows(i)("M_Code")
            objinfo.M_CodePID = dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodePID")
            objinfo.PM_Check = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Check")

            mtBom.ProductBom_UpdateCheck(objinfo)

        Next
        MsgBox("審核產品資料完成！")
        Me.Close()

    End Sub
    ''' <summary>
    ''' 更新子配件
    ''' </summary>
    ''' <remarks></remarks>
    Function UpdateProductBom() As Boolean
        '更新子配件
        Dim i As Integer
        Dim mtBom As New ProductBomController
        UpdateProductBom = True
        Try
            For i = 0 To dsBom.Tables("Prod_Mounting_New").Rows.Count - 1
                Dim objInfo As New ProductBomInfo
                If boolSample Then
                    objInfo.PM_M_Code = txtLFID1.EditValue
                Else
                    objInfo.PM_M_Code = txtLFID.EditValue
                End If

                objInfo.PM_ID = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_ID")
                objInfo.M_Code = dsBom.Tables("Prod_Mounting_New").Rows(i)("M_Code")
                objInfo.M_CodePID = dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodePID")
                objInfo.PM_Qty = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Qty")
                objInfo.PM_MakeRemark = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_MakeRemark").ToString
                objInfo.PM_Make = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Make")
                objInfo.PM_Check = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Check")
                If dsBom.Tables("Prod_Mounting_New").Rows(i)("M_Supplier") = "" Or dsBom.Tables("Prod_Mounting_New").Rows(i)("M_Supplier") Is Nothing Then
                    objInfo.M_Supplier = Nothing
                Else
                    objInfo.M_Supplier = dsBom.Tables("Prod_Mounting_New").Rows(i)("M_Supplier")
                End If
                If dsBom.Tables("Prod_Mounting_New").Rows(i)("M_SupplierNo") = "" Or dsBom.Tables("Prod_Mounting_New").Rows(i)("M_SupplierNo") Is Nothing Then
                    objInfo.M_SupplierNo = Nothing
                Else
                    objInfo.M_SupplierNo = dsBom.Tables("Prod_Mounting_New").Rows(i)("M_SupplierNo")
                End If
                objInfo.PM_Key = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_Key")
                objInfo.PM_PID = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_PID")
                objInfo.PM_LVL = dsBom.Tables("Prod_Mounting_New").Rows(i)("PM_LVL")

                If IsDBNull(dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodeMouldNO")) Then
                    objInfo.M_CodeMouldNO = Nothing
                Else
                    objInfo.M_CodeMouldNO = dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodeMouldNO")
                End If
                If IsDBNull(dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodeType")) Then
                    objInfo.M_CodeType = Nothing
                Else
                    objInfo.M_CodeType = dsBom.Tables("Prod_Mounting_New").Rows(i)("M_CodeType")
                End If

                If IsDBNull(dsBom.Tables("Prod_Mounting_New").Rows(i)("M_Weight")) Then
                    objInfo.M_Weight = 0
                Else
                    objInfo.M_Weight = dsBom.Tables("Prod_Mounting_New").Rows(i)("M_Weight")
                End If


                If dsBom.Tables("Prod_Mounting_New").Rows(i)("IsNew") = "1" Then
                    '新記錄
                    mtBom.ProductBom_Add(objInfo)
                Else
                    '修改記錄                    
                    mtBom.ProductBom_Update(objInfo)
                End If
            Next
            '刪除記錄

            For i = 0 To dsBom.Tables("DelData").Rows.Count - 1
                Dim objInfo As New ProductBomInfo
                If boolSample Then
                    objInfo.PM_M_Code = txtLFID1.EditValue
                Else
                    objInfo.PM_M_Code = txtLFID.EditValue
                End If

                objInfo.PM_Key = dsBom.Tables("DelData").Rows(i)("PM_Key").ToString
                mtBom.ProductBom_Delete(objInfo.PM_M_Code, objInfo.PM_Key)
            Next
        Catch ex As Exception
            UpdateProductBom = False
            MsgBox(ex.Message)
        End Try
       

    End Function

    Private Sub txtLFID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLFID.LostFocus
        ' ''檢查是否已存在此編號
        ''If mc.MaterialCode_Get(txtLFID.Text) Is Nothing Then
        ''Else
        ''    MsgBox("此產品編號已存在，請重新輸入新編號", , "提示")
        ''    txtLFID.Text = ""
        ''    txtLFID.Focus()
        ''    Exit Sub
        ''End If
    End Sub
    '導入數據
    Function LoadData(ByVal PM_M_Code As String) As Boolean


        LoadData = True
        Dim objInfo As New ProductInfo
        Try
            objInfo = mtP.Product_Get(PM_M_Code)
            If objInfo Is Nothing Then
                '沒有數據
                LoadData = False
                Exit Function
            End If

            If boolSample Then
                txtLFID1.EditValue = objInfo.PM_M_Code
                gluCuster1.EditValue = objInfo.PM_CusterID
                txtCusterNo1.EditValue = objInfo.PM_CusterNO
                txtWeight1.EditValue = objInfo.PM_Weight
                popTypeID1.Tag = objInfo.Type3ID
                txtRemark1.EditValue = objInfo.PM_Remark
                TxtM_Gauge1.EditValue = objInfo.M_Gauge
                popTypeID1.EditValue = objInfo.Type3Name

            Else
                txtLFID.EditValue = objInfo.PM_M_Code
                gluCuster.EditValue = objInfo.PM_CusterID
                txtCusterNo.EditValue = objInfo.PM_CusterNO
                txtWeight.EditValue = objInfo.PM_Weight
                popTypeID.Tag = objInfo.Type3ID
                txtRemark.EditValue = objInfo.PM_Remark
                TxtM_Gauge.EditValue = objInfo.M_Gauge
                popTypeID.EditValue = objInfo.Type3Name
            End If



            'objInfo.PM_Action = InUser
            'objInfo.PM_Check = ""



            OldpopTypeID = objInfo.Type3ID

            txtRank.EditValue = objInfo.PM_Rank
            txtJiYu.EditValue = objInfo.PM_JiYu
            txtBoWei.EditValue = objInfo.PM_BoWei
            txtFangShui.EditValue = objInfo.PM_FangShui
            txtZhuHe.EditValue = objInfo.PM_ZhuHe
            txtDai.EditValue = objInfo.PM_Dai
            txtSpare.EditValue = CSng(objInfo.PM_Spare)
            ' objInfo.PM_Price = 0
            txtDiNaZi.EditValue = objInfo.PM_DiNaZi
            txtDiWaiZi.EditValue = objInfo.PM_DiWaiZi
            'objInfo.PM_EditDate = Now
            'objInfo.PM_AddDate = Now
            ' objInfo.PM_Image = ImageToByte(pPhoto.Image)

            pPhoto.Image = ByteToImage(objInfo.PM_Image)
            '導入子報表


            '2013-8-8
            Me.CheckBoxCheck.Checked = objInfo.M_IsEnabled
            OldCheck = objInfo.M_IsEnabled
            Me.Label17.Text = "審核人:" & objInfo.Prod_CheckName
            Me.Label18.Text = "審核日期:" & objInfo.Prod_CheckDate


            OldM_Gauge = objInfo.M_Gauge

            Dim mcBom As New ProductBomController
            dsBom.Tables("Prod_Mounting_New").Rows.Clear()

            LoadBomSubToTable(mcBom.ProductBom_GetList(PM_M_Code, Nothing, Nothing, Nothing, Nothing, Nothing))
        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try



    End Function
    '導入選定配件下的所有子物料
    Sub LoadBomSubToTable(ByVal tList As List(Of ProductBomInfo))

        '沒有子物料則退出
        If tList Is Nothing Then Exit Sub

        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To tList.Count - 1
            row = dsBom.Tables("Prod_Mounting_New").NewRow
            row("PM_M_Code") = tList(i).PM_M_Code
            row("PM_ID") = intTempID
            row("M_Code") = tList(i).M_Code
            row("M_CodePID") = tList(i).M_CodePID
            row("PM_Qty") = Format(tList(i).PM_Qty, "0.0000")
            row("PM_MakeRemark") = tList(i).PM_MakeRemark
            row("PM_Make") = tList(i).PM_Make
            row("PM_Check") = tList(i).PM_Check
            row("M_Supplier") = tList(i).M_Supplier
            row("M_SupplierNo") = tList(i).M_SupplierNo
            row("IsNew") = False
            row("M_Name") = tList(i).M_Name
            row("M_Gauge") = tList(i).M_Gauge
            row("M_Unit") = tList(i).M_Unit
            row("PM_LVL") = tList(i).PM_LVL
            row("PM_Key") = tList(i).PM_Key
            row("PM_PID") = tList(i).PM_PID
            row("M_CodeType") = tList(i).M_CodeType
            row("M_CodeMouldNO") = tList(i).M_CodeMouldNO
            row("M_Weight") = tList(i).M_Weight
            dsBom.Tables("Prod_Mounting_New").Rows.Add(row)
        Next

        Grid.ExpandAll()
    End Sub
    Sub ViewEnable()
        txtLFID.Enabled = False
        gluCuster.Enabled = False
        txtCusterNo.Enabled = False
        popTypeID.Enabled = False
        txtRemark.Enabled = False
        '----------------------------
        txtLFID1.Enabled = False
        gluCuster1.Enabled = False
        txtCusterNo1.Enabled = False
        popTypeID1.Enabled = False
        txtRemark1.Enabled = False
        '----------------------------

        txtZhuHe.Enabled = False
        txtBoWei.Enabled = False
        txtJiYu.Enabled = False
        txtSpare.Enabled = False
        txtRank.Enabled = False
        txtFangShui.Enabled = False
        txtDai.Enabled = False
        txtDiNaZi.Enabled = False
        txtDiWaiZi.Enabled = False
        TreeListColumn4.OptionsColumn.AllowEdit = False
        TreeListColumn5.OptionsColumn.AllowEdit = False
        TreeListColumn1.OptionsColumn.AllowEdit = False
        TreeListColumn2.OptionsColumn.AllowEdit = False
        TreeListColumn3.OptionsColumn.AllowEdit = False
        TreeListColumn6.OptionsColumn.AllowEdit = False
        TreeListColumn7.OptionsColumn.AllowEdit = False
        TreeListColumn9.OptionsColumn.AllowEdit = False
    End Sub
 
    Private Sub txtWeight_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWeight.KeyUp
        Dim m As New System.Text.RegularExpressions.Regex("^+?(\d+(\.\d*)?|\.\d+)$")  '顯示整數,正浮點數正則表達式
        If m.IsMatch(txtWeight.Text) = True Then
        Else
            txtWeight.Text = Nothing
            Exit Sub
        End If
    End Sub
    Private Sub txtWeight1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWeight1.KeyUp
        Dim m As New System.Text.RegularExpressions.Regex("^+?(\d+(\.\d*)?|\.\d+)$")  '顯示整數,正浮點數正則表達式
        If m.IsMatch(txtWeight1.Text) = True Then
        Else
            txtWeight1.Text = Nothing
            Exit Sub
        End If
    End Sub


    ''2013-5-9
    Function CheckM_Gauge(ByVal strM_Gauge As String) As Boolean

        CheckM_Gauge = True

        Dim pmws As New PermissionModuleWarrantSubController   '有權限時保存
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200113")
        If pmwiL.Count > 0 Then
            If pmwiL(0).PMWS_Value.ToString = "是" Then
            Else
                Exit Function
            End If
        Else
            Exit Function
        End If


        If Edit = True And Label4.Text = "Product" Then
            If OldM_Gauge = Me.TxtM_Gauge.EditValue And OldM_Gauge <> "" Then
                Exit Function
            End If
        End If


        Dim Poc As New ProductController

        If Poc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strM_Gauge).Count > 0 Then
            If MsgBox("規格" & strM_Gauge & "已存在,是否繼續保存!", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then
                CheckM_Gauge = False
                Exit Function
            End If

        End If

    End Function

    Sub getAutoPM_M_Code()

        Dim pmws As New PermissionModuleWarrantSubController   '有權限時保存
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "200114")
        If pmwiL.Count > 0 Then
            If pmwiL(0).PMWS_Value.ToString = "是" Then
            Else
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        Dim Mc As New MaterialController
        Dim strTemp As String
        strTemp = Mc.MaterialCodeProd_Main_New_Get("S", "60001010001")

        If strTemp = "" Then
            strTemp = "S00001"
        Else
            strTemp = "S" & Format((CInt(Mid(strTemp, 2, Len(strTemp) - 1)) + 1), "00000")
        End If
        If boolSample Then
            txtLFID1.Text = strTemp
        Else
            txtLFID.Text = strTemp
        End If
    End Sub


    Private Sub txtLFID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLFID.EditValueChanged

    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click, ButtonAdd1.Click
        If boolSample Then
            If Len(Me.txtLFID1.Text) = 0 Then
                MsgBox("產品編號沒有輸入!", , "提示")
                Exit Sub
            End If

            If Len(popTypeID1.Tag) <> 11 Then
                MsgBox("沒有選擇物料類別,不能輸入!", , "提示")
                Exit Sub
            End If
            tempValue = txtLFID1.Text
            frmMaterialGaugeNew.strGauge = TxtM_Gauge1.Text
            frmMaterialGaugeNew.Label2.Text = Mid(popTypeID1.Tag, 1, 8) '@ 2012/1/7 修改

        Else
            If Len(Me.txtLFID.Text) = 0 Then
                MsgBox("產品編號沒有輸入!", , "提示")
                Exit Sub
            End If

            If Len(popTypeID.Tag) <> 11 Then
                MsgBox("沒有選擇物料類別,不能輸入!", , "提示")
                Exit Sub
            End If
            tempValue = txtLFID.Text
            frmMaterialGaugeNew.strGauge = TxtM_Gauge.Text
            frmMaterialGaugeNew.Label2.Text = Mid(popTypeID.Tag, 1, 8) '@ 2012/1/7 修改
        End If



        frmMaterialGaugeNew.ShowDialog()


        If frmMaterialGaugeNew.strGauge = "取消" Then
        Else
            If boolSample Then
                Me.TxtM_Gauge1.Text = frmMaterialGaugeNew.strGauge
            Else
                Me.TxtM_Gauge.Text = frmMaterialGaugeNew.strGauge
            End If

        End If

        frmMaterialGaugeNew.Dispose()
    End Sub





    ''--------------------------------2013-8-8--------------------------------

    Sub UpdateProCheck()
        '子配件審核操作
        Dim oi As New ProductInfo
        Dim oc As New ProductController
        If Me.boolSample Then
            oi.PM_M_Code = txtLFID1.Text
        Else
            oi.PM_M_Code = txtLFID.Text
        End If

        oi.Prod_CheckDate = Format(Now, "yyyy/MM/dd")
        oi.Prod_CheckID = InUserID
        oi.Prod_Check = Me.CheckBoxCheck.Checked

        If oc.Prod_Main_New_UpdateCheck(oi) = False Then
            Exit Sub
        End If

        MsgBox("審核產品資料完成！")
        Me.Close()
    End Sub


    Private Sub ToolStripAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripAll.Click
        On Error Resume Next
        tempCode = ""
        tempValue2 = "All"
        Dim fr As frmBiaMai
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmBiaMai Then
                'fr.Activate()
                fr.Close()
                Exit Sub
            End If
        Next
        fr = New frmBiaMai
        ' fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.ShowIcon = False
        fr.ShowInTaskbar = False
        fr.cmdAddSub.Visible = True
        fr.cmdCopy.Visible = False
        fr.cmdNew.Visible = False
        fr.ShowDialog()


        If tempCode = "" Then Exit Sub

        Dim i, n As Integer
        Dim arr(n) As String
        arr = Split(tempCode, ",")
        n = Len(Replace(tempCode, ",", "," & "*")) - Len(tempCode)
        For i = 0 To n
            If arr(i) = "" Then
                Exit Sub
            End If
            '增加記錄-----------------------
            If arr(i) = txtLFID.Text Then
                Exit Sub
            Else
                If CheckSelectBom(arr(i)) = True Then
                    Exit Sub
                Else
                    AddRow(arr(i))
                    Dim mPB As New ProductBomController
                    '取得子物料
                    LoadBomNewSubToTable(mPB.GetMaterialCodeSubList(arr(i)))
                    Grid.ExpandAll()

                End If
            End If
        Next
        tempCode = ""
        tempValue2 = Nothing
    End Sub

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect

    End Sub
End Class
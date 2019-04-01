Imports System.IO
Imports System.Windows.Forms
Imports LFERP.Library.MaterialParam
Imports LFERP.SystemManager
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.DataSetting
Imports LFERP.TwainMdl

Public Class frmMaterialCode
    Private fs As FileStream
    Dim mtc As New Material.MaterialTypeController
    Dim mc As New MaterialController
    Dim mtsCurrency As New CurrencyControler
    Dim mtsUnit As New UnitController
    Dim mtd As New SuppliersControler
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub
    '@ 2012/1/7 修改，使popTypeID控件顯示物料類別名稱，Label24控件顯示物料類別全名稱，物料類別ID保存在popTypeID.Tag
    Private Sub frmMaterialCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        rdoAccountCheck.SelectedIndex = 1
        CreateTables()

        lueCurrency.Properties.DataSource = mtsCurrency.GetCurrencyList(Nothing)
        lueUnit.Properties.DataSource = mtsUnit.GetUnitList(Nothing)
        gluSupplier.Properties.DisplayMember = "S_Supplier"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        '   gluSupplier.Properties.DataSource = mtd.GetSupplierList(Nothing, Nothing, ErpUser.SupplierType)
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")

        Label28.Text = tempCode
        Label27.Text = tempValue5
        txtCode.Text = Label27.Text
        Label29.Text = tempValue

        tempValue5 = ""
        tempCode = ""

        'mtc.LoadNodes(tv1, ErpUser.MaterialType)
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

        Select Case Label28.Text

            Case "AddOrEdit"
                If Edit = False Then
                    Me.Text = "物料編碼-新增"
                    popTypeID.Enabled = True
                    txtSaveKuCun.Text = "0"
                    txtWeight.Text = "0"
                    If Label29.Text = "復制新增" Then
                        popTypeID.Enabled = True
                        'LoadData(txtCode.Text)
                        txtName.Text = tempValue2
                        txtGauge.Text = tempValue3
                        lueUnit.EditValue = tempValue4
                        popTypeID.Tag = tempValue6 '@ 2012/1/7 修改

                    End If
                ElseIf Edit = True Then
                    Me.Text = "物料編碼-修改"
                    popTypeID.Enabled = True
                    LoadData(Label27.Text)
                End If

            Case "Check"
                Me.Text = "物料編碼-審核"
                LoadData(Label27.Text)
                Panel2.Enabled = False
                Grid.Enabled = False
                cmdOpenPhoto.Enabled = False
                cmdDelPhoto.Enabled = False
                Panel3.Enabled = False
            Case "OnlyPreView"
                Me.Text = "物料編碼-查看"
                LoadData(Label27.Text)
                cmdSave.Visible = False
                Panel3.Enabled = False
                txtPrice.Visible = False
            Case "Photo"
                Me.Text = "物料編碼-載入圖片"
                LoadData(Label27.Text)
                'Panel3.Enabled = False
                'Panel2.Enabled = False
                txtName.Enabled = False
                txtCode.Enabled = False
                txtGauge.Enabled = False
                lueUnit.Enabled = True
                txtMaker.Enabled = False
                txtRemark.Enabled = False
                popTypeID.Enabled = True
                'popCodeSubAdd.Enabled = False
                'popCodeSubDel.Enabled = False
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                cmdOpenPhoto.Enabled = True
                cmdDelPhoto.Enabled = True
                cmdSave.Visible = True
                gluSupplier.Enabled = False
                txtSupplierNo.Enabled = False
                lueCurrency.Enabled = False
                txtSaveKuCun.Enabled = False
                txtBlocCode.Enabled = True
                cmdGauge.Enabled = False
                lueUnit.Enabled = False

            Case "PurchaseView"
                Me.Text = "物料編碼-查看"
                LoadData(Label27.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                cmdSave.Visible = False
                Panel3.Enabled = False
                txtPrice.Visible = False
            Case "QuotationView"
                Me.Text = "物料編碼-查看"
                LoadData(Label27.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                cmdSave.Visible = False
                Panel3.Enabled = False
                txtPrice.Visible = False
            Case "AuditEdit"
                Me.Text = "物料編碼-審計部修改"
                LoadData(Label27.Text)
                popTypeID.Enabled = False
        End Select

        'If Edit = False Then
        '    Me.Text = "物料編碼-新增"
        '    popTypeID.Enabled = True
        '    txtSaveKuCun.Text = "0"
        '    txtWeight.Text = "0"
        '    If tempValue = "復制新增" Then
        '        popTypeID.Enabled = True
        '        LoadData(txtCode.Text)

        '    End If
        'Else
        '    Me.Text = "物料編碼-修改"
        '    popTypeID.Enabled = True
        '    LoadData(txtCode.Text)

        'End If

        'If tempCode = "AddOrEdit" Then
        '    rdoAccountCheck.Enabled = False
        '    rdoIsEnabled.Enabled = False
        'End If

        'If tempCode = "Check" Then
        '    Panel2.Enabled = False
        '    Grid.Enabled = False
        '    cmdOpenPhoto.Enabled = False
        '    cmdDelPhoto.Enabled = False
        '    Panel3.Enabled = False
        'End If
        'If tempCode = "OnlyPreView" Then
        '    Me.Text = "物料編碼-查看"
        '    LoadData(txtCode.Text)
        '    cmdSave.Visible = False
        '    Panel3.Enabled = False
        '    txtPrice.Visible = False
        'End If
        Label25.Visible = False
        Label26.Visible = False
        txtWeight.Visible = False
        cbWeight.Visible = False
        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue6 = ""
    End Sub

    Private Sub popCodeSubAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popCodeSubAdd.Click

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

        '增加記錄
        If tempCode = txtCode.Text Then
            MsgBox("不可以選擇主物料編碼!", , "提示")
            Exit Sub
        Else
            AddRow(tempCode)
        End If
        tempCode = ""

    End Sub

    Sub AddRow(ByVal strCode As String)
        If strCode = "" Then
        Else
            Dim objInfo As New MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)
            Dim row As DataRow
            row = CodeSubData.Tables("CodeSub").NewRow
            'CodeSubData.Tables("CodeSub").NewRow()
            row("AutoID") = "0"
            row("M_CodeSub") = objInfo.M_Code
            row("M_Qty") = 0
            row("M_Name") = objInfo.M_Name
            row("M_Unit") = objInfo.M_Unit
            row("M_Gauge") = objInfo.M_Gauge
            CodeSubData.Tables("CodeSub").Rows.Add(row)
            GridView1.MoveLast()
        End If
    End Sub
    Sub UpdateCodeSub(ByVal strCode As String)
        '更新子配件
        Dim i As Integer
        For i = 0 To CodeSubData.Tables("CodeSub").Rows.Count - 1
            Dim objInfo As New MaterialSubInfo
            If CodeSubData.Tables("CodeSub").Rows(i)("AutoID") = "0" Then
                '新記錄
                objInfo.M_Code = strCode
                objInfo.M_CodeSub = CodeSubData.Tables("CodeSub").Rows(i)("M_CodeSub")
                objInfo.M_Qty = CodeSubData.Tables("CodeSub").Rows(i)("M_Qty")
                mc.MaterialCodeSub_Add(objInfo)
            Else
                '修改記錄
                objInfo.M_Code = strCode
                objInfo.M_CodeSub = CodeSubData.Tables("CodeSub").Rows(i)("M_CodeSub")
                objInfo.M_Qty = CodeSubData.Tables("CodeSub").Rows(i)("M_Qty")
                'mc.MaterialCodeSub_Add(objInfo)
                mc.MaterialCodeSub_Update(objInfo)
            End If
        Next
        '刪除記錄
        For i = 0 To CodeSubData.Tables("DelData").Rows.Count - 1
            Dim objInfo As New MaterialSubInfo
            objInfo.M_Code = strCode
            objInfo.M_CodeSub = CodeSubData.Tables("DelData").Rows(i)("M_CodeSub")
            mc.MaterialCodeSub_Delete(objInfo.M_Code, objInfo.M_CodeSub)
        Next

    End Sub

    Sub CreateTables()
        '子物料數據
        CodeSubData.Tables.Clear()
        '創建數據表
        With CodeSubData.Tables.Add("CodeSub")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_CodeSub", GetType(String))
            .Columns.Add("M_Qty", GetType(Integer))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
        End With
        '創建刪除數據表
        With CodeSubData.Tables.Add("DelData")
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_CodeSub", GetType(String))
        End With
        '綁定表格
        Grid.DataSource = CodeSubData.Tables("CodeSub")
    End Sub
    Sub LoadDataToTable(ByVal tList As List(Of MaterialInfo))
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To tList.Count - 1
            row = CodeSubData.Tables("CodeSub").NewRow
            row("AutoID") = "1"
            'row("M_Code") = txtCode.Text
            row("M_CodeSub") = tList(i).M_Code
            row("M_Qty") = tList(i).M_Qty
            row("M_Name") = tList(i).M_Name
            row("M_Unit") = tList(i).M_Unit
            row("M_Gauge") = tList(i).M_Gauge
            CodeSubData.Tables("CodeSub").Rows.Add(row)
        Next


    End Sub

    Private Sub cmdOpenPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpenPhoto.Click
        Dim ofd As New OpenFileDialog
        Dim i As Integer
        ofd.Filter = "圖片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp"
        ofd.ShowDialog()
        If ofd.FileName.ToString = "" Then Exit Sub
        fs = New IO.FileStream(ofd.FileName.ToString, IO.FileMode.Open, IO.FileAccess.Read)
        pPhoto.Image = Image.FromFile(ofd.FileName.ToString)

        Select Case CInt(ofd.OpenFile.Length / 1024)
            Case Is < 80 : i = 0
            Case Is > 80 < 100 : i = 100
            Case Is > 100 < 150 : i = 85
            Case Is > 300 : i = 65
        End Select

        Dim ci As New CompressImage
        If i = 0 Then
        Else
            ci.GetJPEG(pPhoto.Image, pPhoto, i)
        End If

    End Sub
  
    Private Sub cmdGauge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGauge.Click
        If popTypeID.Text = "" Then
            MsgBox("沒有選擇物料類別,不能輸入!", , "提示")
            Exit Sub

        End If
        frmMaterialGauge.strGauge = txtGauge.Text
        frmMaterialGauge.Label2.Text = popTypeID.Tag '@ 2012/1/7 修改
        frmMaterialGauge.ShowDialog()

        If frmMaterialGauge.strGauge = "取消" Then
        Else
            Me.txtGauge.Text = frmMaterialGauge.strGauge
        End If


    End Sub

    Private Sub cmdDelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelPhoto.Click
        pPhoto.Image = Nothing

    End Sub
  
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Mid(popTypeID.Tag.ToString, 1, 5) = "20024" Then '@ 2012/1/7 修改
            '***判斷用戶是擁有特殊類的權限
            Dim pmws2 As New PermissionModuleWarrantSubController
            Dim pmwiL2 As List(Of PermissionModuleWarrantSubInfo)

            pmwiL2 = pmws2.PermissionModuleWarrantSub_GetList(InUserID, "100115")
            If pmwiL2.Item(0).PMWS_Value = "否" Then
                ' If pmwiL.Item(0).PMWS_Value = "是" Then popMaterialMainAdd.Enabled = True
                MsgBox("你沒有特殊類的相關權限,請重新選擇物料類別")

                Exit Sub
            End If

            '************

        End If

        If popTypeID.EditValue.ToString = "" Then
            MsgBox("沒有建立物料編碼，請確認!", 64, "提示")
            popTypeID.Focus()
            Exit Sub
        End If

        '@ 2012/11/21 添加
        If Val(txtSaveKuCun.Text) < 0 Then
            MsgBox("安全庫存不能小於零!", 64, "提示")
            XtraTabControl1.SelectedTabPage = XtraTabPage3
            txtSaveKuCun.Focus()
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To CodeSubData.Tables("CodeSub").Rows.Count - 1
            If CodeSubData.Tables("CodeSub").Rows(i)("M_Qty") = 0 Or _
                Len(CodeSubData.Tables("CodeSub").Rows(i)("M_Qty")) = 0 Then
                MsgBox("子物料有數量為0,請修正!", , "提示")
                Exit Sub
            Else
            End If

        Next


        '***判斷用戶是擁有新增10，20，還是30的權限
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100113")
        If pmwiL.Count > 0 Then
            ' If pmwiL.Item(0).PMWS_Value = "是" Then popMaterialMainAdd.Enabled = True
            If InStr(pmwiL.Item(0).PMWS_Value, Mid(popTypeID.Tag, 1, 2)) = 0 Then '@ 2012/1/7 修改
                MsgBox("你沒有此類型的新增或修改權限")
                Exit Sub
            End If

        End If

        If CStr(txtBlocCode.Text) <> "" Then
            If Len(txtBlocCode.Text) <> 17 Then
                MsgBox("集團編碼輸入有誤，集團編碼只能是17位!", 64, "提示")
                txtBlocCode.Focus()
                Exit Sub
            End If
        End If
        '************
        Select Case Label28.Text

            Case "AddOrEdit"
                If Edit = False Then '新增

                    If Label29.Text = "復制新增" Then
                        If txtName.Text = tempValue2 And txtGauge.Text = tempValue3 And lueUnit.EditValue = tempValue4 Then
                            MsgBox("物料名稱,規格,單位中必須有所變動才能建立新物料！")
                            Exit Sub
                        Else
                            SaveDataNew()
                        End If
                    ElseIf Label29.Text = "新增" Then

                        SaveDataNew()

                    End If

                Else         '修改
                    SaveDataEdit()

                End If
            Case "Photo"
                DesignPhoto()
            Case "AuditEdit"
                SaveDataEdit()
        End Select

    End Sub

    Sub SaveDataNew()
        '保存新增資料
        Dim objInfo As New MaterialInfo
        '如果為成品類則由手動編號
        If Mid(popTypeID.Tag, 1, 2) = "40" Then '@ 2012/1/7 修改

        Else
            txtCode.Text = mc.MaterialCode_GetID(popTypeID.Tag) '@ 2012/1/7 修改
        End If


        objInfo.M_Code = txtCode.Text
        objInfo.M_Name = txtName.Text
        objInfo.M_AddDate = CStr(Format(Now, "yyyy-MM-dd hh:mm:ss"))
        objInfo.M_EditDate = Nothing
        objInfo.M_Gauge = txtGauge.Text
        objInfo.Type3ID = popTypeID.Tag '@ 2012/1/7 修改
        objInfo.M_Unit = lueUnit.EditValue
        objInfo.M_Currency = lueCurrency.EditValue
        objInfo.M_Maker = txtMaker.Text
        objInfo.M_Supplier = gluSupplier.EditValue
        objInfo.M_SupplierNo = txtSupplierNo.EditValue

        objInfo.M_Weight = txtWeight.Text
        objInfo.M_WeightUnit = cbWeight.EditValue

        If Len(txtSaveKuCun.Text) = 0 Then
            objInfo.M_SaveKuCun = "0"
        Else
            objInfo.M_SaveKuCun = txtSaveKuCun.Text
        End If

        If Len(txtPrice.Text) = 0 Then
            objInfo.M_Price = 0
        Else
            objInfo.M_Price = CSng(txtPrice.Text)
        End If

        objInfo.BlocCode = CStr(txtBlocCode.Text)       '@ 2012/6/2 添加 集團編碼

        objInfo.M_Remark = txtRemark.Text
        objInfo.InUser = InUserID

        If rodIsSub.SelectedIndex = 0 Then
            objInfo.M_IsSub = True
        Else
            objInfo.M_IsSub = False
        End If
        If rdoAccountCheck.SelectedIndex = 0 Then
            objInfo.M_AccountCheck = True
        Else
            objInfo.M_AccountCheck = False
        End If

        If rdoIsEnabled.SelectedIndex = 1 Then
            objInfo.M_IsEnabled = False
        Else
            objInfo.M_IsEnabled = True
        End If
      


        '保存圖片
        'If pPhoto.Image Is Nothing Then
        '    objInfo.M_Photo = Nothing
        'Else
        '    Dim photoData(fs.Length) As Byte
        '    fs.Read(photoData, 0, Int(fs.Length))
        '    objInfo.M_Photo = photoData
        'End If


        ''保存圖片
        'If pPhoto.Image Is Nothing Then
        '    objInfo.M_Photo = Nothing
        'Else
        '    If fs Is Nothing Then
        '        '未加入圖片時,保存控件中的圖片
        '        objInfo.M_Photo = Nothing
        '        Dim output As New MemoryStream
        '        Dim iImage As Drawing.Image = Nothing
        '        Dim mem As New MemoryStream
        '        Dim myBitmap As New Bitmap(Me.pPhoto.Image)
        '        myBitmap.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg)
        '        Dim Buf(CInt(mem.Length - 1)) As Byte

        '        mem.Position = 0
        '        mem.Read(Buf, 0, CInt(mem.Length))
        '        mem.Close()
        '        objInfo.M_Photo = Buf

        '    Else
        '        Dim photoData(fs.Length) As Byte
        '        fs.Read(photoData, 0, Int(fs.Length))
        '        fs.Close()
        '        objInfo.M_Photo = photoData
        '    End If

        'End If
        objInfo.M_Photo = ImageToByte(pPhoto.Image)
        objInfo.M_CheckRemark = txtM_CheckRemark.Text.Trim    '@ 2013/3/26 添加

        If mc.MaterialCode_Add(objInfo) = True Then
            '保存子物料
            UpdateCodeSub(txtCode.Text)

            'If Mid(txtCode.Text, 1, 2) = "20" Then
            '    objInfo.M_Code = txtCode.Text
            '    objInfo.M_Price = 0
            '    objInfo.M_Currency = lueCurrency.EditValue
            '    objInfo.M_ChangeDate = Format(Now, "yyyy/MM/dd")

            '    mc.MaterialPrice_Add(objInfo) '如果是物料類 則在價格表中添加記錄
            'End If

            'MsgBox("保存成功", , "提示")
            Me.Close()
        Else
            MsgBox("保存失敗,請檢查錯誤!", , "提示")
        End If


    End Sub

    Sub MaterialPriceNew(ByVal strCode As String)

    End Sub

    Sub SaveDataEdit()
        '保存修改數據
        Dim objInfo As New MaterialInfo
        objInfo.M_Code = Label27.Text
        objInfo.M_Name = txtName.Text
        objInfo.M_EditDate = CStr(Format(Now, "yyyy-MM-dd hh:mm:ss"))
        objInfo.M_AddDate = Nothing
        objInfo.M_Gauge = txtGauge.Text
        objInfo.Type3ID = popTypeID.Tag '@ 2012/1/7 修改
        objInfo.M_Unit = lueUnit.EditValue
        objInfo.M_Currency = lueCurrency.EditValue
        objInfo.M_Maker = txtMaker.Text
        objInfo.M_Supplier = gluSupplier.EditValue
        objInfo.M_SupplierNo = txtSupplierNo.EditValue

        objInfo.M_Weight = txtWeight.Text
        objInfo.M_WeightUnit = cbWeight.EditValue

        If Len(txtSaveKuCun.Text) = 0 Then
            objInfo.M_SaveKuCun = "0"
        Else
            objInfo.M_SaveKuCun = txtSaveKuCun.Text
        End If

        objInfo.BlocCode = CStr(txtBlocCode.Text)       '@ 2012/6/2 添加 集團編碼

        If Len(txtPrice.Text) = 0 Then
            objInfo.M_Price = 0
        Else
            objInfo.M_Price = CSng(txtPrice.Text)
        End If
        objInfo.M_Remark = txtRemark.Text
        objInfo.InUser = InUserID
        If rodIsSub.SelectedIndex = 0 Then
            objInfo.M_IsSub = True
        Else
            objInfo.M_IsSub = False
        End If
        If rdoAccountCheck.SelectedIndex = 0 Then
            objInfo.M_AccountCheck = True
        Else
            objInfo.M_AccountCheck = False
        End If

        If rdoIsEnabled.SelectedIndex = 1 Then
            objInfo.M_IsEnabled = False
        Else
            objInfo.M_IsEnabled = True
        End If

        '保存圖片
        'If pPhoto.Image Is Nothing Then
        '    objInfo.M_Photo = Nothing
        'Else
        '    If fs Is Nothing Then
        '        '未加入圖片時,保存控件中的圖片
        '        objInfo.M_Photo = Nothing
        '        Dim output As New MemoryStream
        '        Dim iImage As Drawing.Image = Nothing
        '        Dim mem As New MemoryStream
        '        Dim myBitmap As New Bitmap(Me.pPhoto.Image)
        '        myBitmap.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg)
        '        Dim Buf(CInt(mem.Length - 1)) As Byte

        '        mem.Position = 0
        '        mem.Read(Buf, 0, CInt(mem.Length))
        '        mem.Close()
        '        objInfo.M_Photo = Buf

        '    Else
        '        Dim photoData(fs.Length) As Byte
        '        fs.Read(photoData, 0, Int(fs.Length))
        '        fs.Close()
        '        objInfo.M_Photo = photoData
        '    End If

        'End If
        objInfo.M_Photo = ImageToByte(pPhoto.Image)
        objInfo.M_CheckRemark = txtM_CheckRemark.Text.Trim    '@ 2013/3/26 添加

        If mc.MaterialCode_Update(objInfo) = True Then
            '保存子物料
            UpdateCodeSub(txtCode.Text)
            'MsgBox("修改成功", , "提示")
            Me.Close()
        Else
            MsgBox("保存失敗,請檢查錯誤!", , "提示")
        End If

    End Sub

    Sub DesignPhoto()
        Dim objInfo As New MaterialInfo
        objInfo.M_Code = Label27.Text
        objInfo.M_Name = txtName.Text
        objInfo.M_EditDate = CStr(Format(Now, "yyyy-MM-dd hh:mm:ss"))
        objInfo.M_AddDate = Nothing
        objInfo.M_Gauge = txtGauge.Text
        objInfo.Type3ID = popTypeID.Tag '@ 2012/1/7 修改
        objInfo.M_Unit = lueUnit.EditValue
        objInfo.M_Currency = lueCurrency.EditValue
        objInfo.M_Maker = txtMaker.Text
        objInfo.M_Supplier = gluSupplier.EditValue
        objInfo.M_SupplierNo = txtSupplierNo.EditValue

        objInfo.M_Weight = txtWeight.Text
        objInfo.M_WeightUnit = cbWeight.EditValue

        If Len(txtSaveKuCun.Text) = 0 Then
            objInfo.M_SaveKuCun = "0"
        Else
            objInfo.M_SaveKuCun = txtSaveKuCun.Text
        End If

        objInfo.BlocCode = CStr(txtBlocCode.Text)       '@ 2012/6/2 添加 集團編碼

        If Len(txtPrice.Text) = 0 Then
            objInfo.M_Price = 0
        Else
            objInfo.M_Price = CSng(txtPrice.Text)
        End If
        objInfo.M_Remark = txtRemark.Text
        objInfo.InUser = InUserID
        If rodIsSub.SelectedIndex = 0 Then
            objInfo.M_IsSub = True
        Else
            objInfo.M_IsSub = False
        End If
        If rdoAccountCheck.SelectedIndex = 0 Then
            objInfo.M_AccountCheck = True
        Else
            objInfo.M_AccountCheck = False
        End If
        If rdoIsEnabled.SelectedIndex = 0 Then
            objInfo.M_IsEnabled = True
        Else
            objInfo.M_IsEnabled = False
        End If

        objInfo.M_Photo = ImageToByte(pPhoto.Image)
        objInfo.M_CheckRemark = txtM_CheckRemark.Text.Trim    '@ 2013/3/26 添加

        If mc.MaterialCode_Update(objInfo) = True Then
            UpdateCodeSub(Label27.Text)
            MsgBox("保存成功！")
            Me.Close()
        Else
            MsgBox("保存失敗，請檢查原因！")
        End If
    End Sub

    Sub LoadData(ByVal strCode As String)
        '導入數據
        On Error Resume Next
        Dim objInfo As New MaterialInfo
        objInfo = mc.MaterialCode_Get(strCode)
        txtCode.Text = objInfo.M_Code
        txtName.Text = objInfo.M_Name
        'objInfo.M_EditDate = CStr(Format(Now, "yyyy-MM-dd hh:mm:ss"))
        'objInfo.M_EditDate = Nothing
        txtGauge.Text = objInfo.M_Gauge
        popTypeID.Tag = objInfo.Type3ID '@ 2012/1/7 修改
        popTypeID.EditValue = objInfo.Type3Name '@ 2012/1/7 修改
        lueUnit.EditValue = objInfo.M_Unit
        lueCurrency.EditValue = objInfo.M_Currency
        txtMaker.Text = objInfo.M_Maker
        txtRemark.Text = objInfo.M_Remark
        'InUser=objInfo.InUser  
        txtPrice.Text = objInfo.M_Price
        Label17.Text = objInfo.M_AddDate
        Label18.Text = objInfo.M_EditDate
        Label19.Text = objInfo.InUser
        gluSupplier.EditValue = objInfo.M_Supplier
        txtSupplierNo.EditValue = objInfo.M_SupplierNo
        txtSaveKuCun.Text = objInfo.M_SaveKuCun
        txtBlocCode.Text = objInfo.BlocCode     '@ 2012/6/2 添加 顯示集團編碼

        txtWeight.Text = objInfo.M_Weight
        cbWeight.EditValue = objInfo.M_WeightUnit

        If objInfo.M_IsSub = True Then
            rodIsSub.SelectedIndex = 0
        Else
            rodIsSub.SelectedIndex = 1
        End If
        If objInfo.M_AccountCheck = True Then
            rdoAccountCheck.SelectedIndex = 0
        Else
            rdoAccountCheck.SelectedIndex = 1
        End If
        If objInfo.M_IsEnabled = True Then
            rdoIsEnabled.SelectedIndex = 0
        Else
            rdoIsEnabled.SelectedIndex = 1
        End If
        '導入圖片
        'If objInfo.M_Photo Is Nothing Then
        'Else
        '    Dim stmphoto As New MemoryStream(objInfo.M_Photo)
        '    pPhoto.Image = Image.FromStream(stmphoto)
        'End If
        pPhoto.Image = ByteToImage(objInfo.M_Photo)
        txtM_CheckRemark.Text = objInfo.M_CheckRemark     '@ 2013/3/26 添加


        If objInfo.M_supplier = Nothing Then
        Else
            gluSupplier.Text = objInfo.M_supplier
            GridLookUpEdit1View.StartIncrementalSearch(objInfo.M_supplier)
        End If

        ''導入物件類別TypeID1+TypeID2+TypeID3
        Dim tc As New MaterialTypeController
        Dim ti As New MaterialTypeInfo
        Dim ti1 As New MaterialTypeInfo1
        Dim ti2 As New MaterialTypeInfo2
        Dim ti3 As New MaterialTypeInfo3
        'ti = tc.MaterialTypeGet(Mid(popTypeID.Text, 1, 2))
        ti1 = tc.MaterialType1_Get(Mid(popTypeID.Tag, 1, 5)) '@ 2012/1/7 修改
        ti2 = tc.MaterialType2_Get(Mid(popTypeID.Tag, 1, 8)) '@ 2012/1/7 修改
        ti3 = tc.MaterialType3_Get(Mid(popTypeID.Tag, 1, 11)) '@ 2012/1/7 修改


        Label24.Text = ti1.Type1Name & "+" & ti2.Type2Name & "+" & ti3.Type3Name
        'cmdExit.Text = ti.MaterialTypeName
        'cmdSave.Text = Mid(popTypeID.Text, 1, 2)


        '導入子報表
        LoadDataToTable(mc.MaterialCodeSub_GetList(strCode))

    End Sub

    Private Sub tv1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tv1.MouseDoubleClick
        If tv1.SelectedNode.Level = 3 Then
            popTypeID.Tag = tv1.SelectedNode.Tag '@ 2012/1/7 修改
            popTypeID.EditValue = tv1.SelectedNode.Text '@ 2012/1/7 修改
            PopupContainerControl1.OwnerEdit.ClosePopup()

        End If
    End Sub

    Private Sub popTypeID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popTypeID.EditValueChanged
        On Error Resume Next

        If Edit = False Then
            If Mid(popTypeID.Tag, 1, 2) = "40" Then '@ 2012/1/7 修改
                txtCode.Enabled = True
                txtCode.Text = ""
            Else
                txtCode.Enabled = False
                txtCode.Text = ""
            End If
            'txtName.Text = tv1.SelectedNode.Text

        End If

        ''導入物件類別TypeID1+TypeID2+TypeID3
        Dim tc As New MaterialTypeController
        Dim ti As New MaterialTypeInfo
        Dim ti1 As New MaterialTypeInfo1
        Dim ti2 As New MaterialTypeInfo2
        Dim ti3 As New MaterialTypeInfo3
        ti = tc.MaterialType_Get(Mid(popTypeID.Tag, 1, 2)) '@ 2012/1/7 修改
        ti1 = tc.MaterialType1_Get(Mid(popTypeID.Tag, 1, 5)) '@ 2012/1/7 修改
        ti2 = tc.MaterialType2_Get(Mid(popTypeID.Tag, 1, 8)) '@ 2012/1/7 修改
        ti3 = tc.MaterialType3_Get(Mid(popTypeID.Tag, 1, 11)) '@ 2012/1/7 修改
        Label24.Text = ti.MaterialTypeName & "+" & ti1.Type1Name & "+" & ti2.Type2Name & "+" & ti3.Type3Name
    End Sub

    Private Sub popCodeSubDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popCodeSubDel.Click
        If CodeSubData.Tables("CodeSub").Rows.Count = 0 Then
            Exit Sub
        End If
        If GridView1.RowCount = 0 Then Exit Sub
        'DataRow.Delete()
        Dim DelTemp As String
        DelTemp = CodeSubData.Tables("CodeSub").Rows(GridView1.FocusedRowHandle)("AutoID")
        If DelTemp = "0" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = CodeSubData.Tables("DelData").NewRow
            'row("AutoID") = DelTemp
            row("M_Code") = txtCode.Text
            row("M_CodeSub") = CodeSubData.Tables("CodeSub").Rows(GridView1.FocusedRowHandle)("M_CodeSub")
            CodeSubData.Tables("DelData").Rows.Add(row)
        End If
        CodeSubData.Tables("CodeSub").Rows.RemoveAt(GridView1.FocusedRowHandle)

    End Sub

  

  
 
    'Private Sub txtCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.EditValueChanged
    '    '檢查是否已存在此編號
    '    If mc.MaterialCode_Get(txtCode.Text) Is Nothing Then
    '    Else
    '        MsgBox("此聯豐編號已存在，請重新輸入新編號", , "提示")
    '        txtCode.Focus()
    '        Exit Sub


    '    End If
    'End Sub
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If pPhoto.Image Is Nothing Then
            MsgBox("無圖片信息,不能導出！")
            Exit Sub
        End If

        Dim tempName As String
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.InitialDirectory = "c:\"
        SaveFileDialog1.Filter = "txt files (*.jpg)|*.jpg | (*.bmp)|*.bmp | (*.png)|*.png "
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tempName = SaveFileDialog1.FileName
        Else
            Exit Sub
        End If

        pPhoto.Image.Save(tempName)

        MsgBox("圖片已保存!")
    End Sub
End Class
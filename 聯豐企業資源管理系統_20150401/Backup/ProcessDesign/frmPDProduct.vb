Imports System
Imports System.IO
Imports System.Windows.Forms
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Product
Imports LFERP.Library.ProductionField
Imports LFERP.SystemManager

Public Class frmPDProduct

    Dim ds As New DataSet
    Private fs As IO.FileStream
    Dim TempCode As String
    Dim TempType3ID As String

    Dim CheckKaiLiao As Boolean = False
    Dim CheckPro As Boolean = False


    Private Sub ButtonEdit1_ButtonPressed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonPressed
        On Error Resume Next
        Dim fr As New frmPDProductPMSelect
        fr.ShowDialog()
        ButtonEdit1.Text = fr.PMName

        Dim pc As New ProductController
        Dim piL As List(Of ProductInfo)
        piL = pc.Product_GetList(ButtonEdit1.Text.ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)


        If piL Is Nothing Then Exit Sub
        If ButtonEdit1.Text <> "" Then
            TextEdit1.Text = piL(0).PM_CusterID

            TextEdit3.Text = piL(0).PM_JiYu
        End If

        Dim pbc As New ProductBomController
        Dim pbiL As List(Of ProductBomInfo)
        pbiL = pbc.ProductBom_GetList(ButtonEdit1.Text.ToString, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pbiL Is Nothing Then
            MsgBox("產品配件為空！")
        End If
        SubRowAdd(pbiL)
    End Sub
    Private Sub SubRowAdd(ByVal pbil As List(Of ProductBomInfo))
        Dim pc As New ProductController
        Dim piL As List(Of ProductInfo)
        piL = pc.Product_GetList(ButtonEdit1.Text.ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        ds.Tables("ProductSub").Clear()
        Dim row As DataRow
        row = ds.Tables("ProductSub").NewRow
        row("M_Name") = ButtonEdit1.Text.ToString
        row("M_Code") = piL(0).PM_M_Code
        row("M_PID") = "0~"
        row("M_KEY") = pbil(0).PM_PID
        ds.Tables("ProductSub").Rows.Add(row)

        For i As Integer = 0 To pbil.Count - 1
            row = ds.Tables("ProductSub").NewRow
            row("M_Name") = pbil(i).M_Name
            row("M_Code") = pbil(i).M_Code
            row("M_PID") = pbil(i).PM_PID
            row("M_KEY") = pbil(i).PM_Key
            ds.Tables("ProductSub").Rows.Add(row)
        Next
        Me.TreeList1.ExpandAll()
    End Sub
    Private Sub pupPDProductAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupPDProductAdd.Click

        Dim row As DataRow
        row = ds.Tables("ProcessSub").NewRow
        row("PS_Check") = False
        If ds.Tables("ProcessSub").Rows.Count = 0 Then
            row("PS_Num") = 1
            row("PS_Name") = "開料"
            'row("PS_PaiXu") = 1
            row("PS_OutPut") = 0
            row("PS_Type") = "大貨"
            row("PS_Weight") = 0
            row("PS_Enable") = True
        Else
            row("PS_Num") = ds.Tables("ProcessSub").Rows(ds.Tables("ProcessSub").Rows.Count - 1)("PS_Num") + 1
            'row("PS_PaiXu") = ds.Tables("ProcessSub").Rows(ds.Tables("ProcessSub").Rows.Count - 1)("PS_PaiXu") + 1
            row("PS_OutPut") = 0
            row("PS_Type") = "大貨"
            row("PS_Weight") = 0
            row("PS_Enable") = True
        End If
        ds.Tables("ProcessSub").Rows.Add(row)
    End Sub

    Private Sub frmPDProduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label24.Text = tempValue
        txtOMID.Text = tempValue2
        txtOMID.Enabled = False

        tempValue = ""
        tempValue2 = ""
        CreateTable()


        PowerUser()

        Dim pc As New ProcessMainControl
        Dim pi As New ProcessMainInfo
        Dim ptc As New ProductController
        Dim ptcon As New ProcessTypeControl

        ImageInput.Properties.DataSource = ptc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        ImageInput.Properties.DisplayMember = "PM_M_Code"
        ImageInput.Properties.ValueMember = "PM_M_Code"

        Me.RepositoryItemLookUpEdit1.DataSource = pc.ProDepartMent_GetList(Nothing, tempValue3)
        Me.RepositoryItemLookUpEdit1.DisplayMember = "D_Dep"
        Me.RepositoryItemLookUpEdit1.ValueMember = "D_ID"

        If Panel2.Visible = True Then
            gluProcessType.Properties.DataSource = ptcon.ProcessTypeA_GetList(Nothing, Nothing)
            gluProcessType.Properties.DisplayMember = "D_Type"
            gluProcessType.Properties.ValueMember = "D_Type"
        End If

        Select Case Label24.Text
            Case "產品資料工藝流程單"
                If Edit = False Then
                    GetEnable(True, False)
                    Me.popEnable.Visible = False
                    Me.Text = "工藝流程單--新增"
                    ComboBoxEdit1.EditValue = tempValue3
                    tempValue3 = ""
                Else
                    GetEnable(True, False)
                    ButtonEdit1.Enabled = False
                    ComboBoxEdit1.Enabled = False
                    PopupContainerEdit1.Enabled = False
                    TextEdit1.Enabled = False
                    TextEdit2.Enabled = False
                    TextEdit3.Enabled = False
                    Me.Text = "工藝流程單--修改"
                    LoadData(txtOMID.Text)
                End If

                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "查看"
                GetEnable(False, False)
                Me.Text = "工藝流程單--查看" & "[" & txtOMID.Text & "]"
                LoadData(txtOMID.Text)
                txtOMID.Enabled = False
                cmdSave.Visible = False

                XtraTabControl1.SelectedTabPage = XtraTabPage1
                XtraTabPage3.PageVisible = True
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Case "審核"
                GetEnable(False, True)
                Me.Text = "審核" & "[" & txtOMID.Text & "]"
                LoadData(txtOMID.Text)
                txtOMID.Enabled = False
                XtraTabPage3.PageVisible = True
                XtraTabControl1.SelectedTabPage = XtraTabPage3
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False

            Case "ModifyPsName" '修改工序名稱
                ButtonEdit1.Enabled = False
                TextEdit1.Enabled = False
                TextEdit3.Enabled = False

                TextEdit2.Enabled = False
                ComboBoxEdit1.Enabled = False
                MemoEdit1.Enabled = False
                MemoEdit2.Enabled = False
                SimpleButton1.Enabled = False

                CheckEdit1.Enabled = False
                CheckRemark.Enabled = False

                XtraTabPage2.PageVisible = False
                XtraTabPage3.PageVisible = False

                pupPDProduct.Enabled = False

                GridColumn1.OptionsColumn.ReadOnly = True
                GridColumn2.OptionsColumn.ReadOnly = True
                'GridColumn3.OptionsColumn.ReadOnly = True
                PS_Type.OptionsColumn.ReadOnly = True
                'GridColumn5.OptionsColumn.ReadOnly = True
                GridColumn6.OptionsColumn.ReadOnly = True
                GridColumn9.OptionsColumn.ReadOnly = True
                GridColumn10.OptionsColumn.ReadOnly = True
                GridColumn11.OptionsColumn.ReadOnly = True
                GridColumn12.OptionsColumn.ReadOnly = True

                Me.Text = "工藝流程單--工序名稱修改" & "[" & txtOMID.Text & "]"
                LoadData(txtOMID.Text)

            Case Else
                Exit Select
        End Select


    End Sub
    Private Sub GetEnable(ByVal a As Boolean, ByVal b As Boolean)
        ButtonEdit1.Enabled = a
        TextEdit1.Enabled = a
        TextEdit3.Enabled = a
        PopupContainerEdit1.Enabled = a
        TextEdit2.Enabled = a
        ComboBoxEdit1.Enabled = a
        MemoEdit1.Enabled = a
        MemoEdit2.Enabled = a
        SimpleButton1.Enabled = a

        CheckEdit1.Enabled = b
        CheckRemark.Enabled = b
    End Sub
    Private Function LoadData(ByVal Pro_NO As String) As Boolean
        Dim pc As New ProcessMainControl
        Dim piL As List(Of ProcessMainInfo)

        piL = pc.ProcessMain_GetList1(Pro_NO, Nothing, Nothing, Nothing)

        ButtonEdit1.Text = piL(0).PM_M_Code
        TempCode = piL(0).M_Code

        'Dim ps As New ProductBomController
        'Dim psi As List(Of ProductBomInfo)

        'psi = ps.ProductBom_GetList(ButtonEdit1.Text.ToString, Nothing, Nothing, Nothing, Nothing, Nothing)

        'If psi.Count > 0 Then

        '    TempCode = psi(0).M_Code
        'End If

        PopupContainerEdit1.EditValue = piL(0).PM_Type
        TextEdit1.Text = piL(0).CustomerNO
        TextEdit2.Text = piL(0).Type3ID
        TextEdit3.Text = piL(0).PM_JiYu
        TextEdit4.Text = piL(0).Pro_Weight
        TextEdit5.Text = piL(0).Pro_Rate
        ComboBoxEdit1.Text = piL(0).Pro_Type
        MemoEdit1.Text = piL(0).Pro_Remark
        MemoEdit2.Text = piL(0).Pro_Describe

        pPhoto.Image = ByteToImage(piL(0).Pro_Photo)

        CheckEdit1.Checked = piL(0).Pro_Check
        CheckDate.Text = piL(0).Pro_CheckDate
        CheckAction.Text = piL(0).Pro_CheckAction
        CheckRemark.Text = piL(0).Pro_CheckRemark

        LoadSubData(pc.ProcessSub_GetList(Pro_NO, Nothing, Nothing, Nothing, Nothing, Nothing))

    End Function
    Private Function LoadSubData(ByVal PsL As List(Of ProcessMainInfo)) As Boolean
        If PsL Is Nothing Then Exit Function
        Dim Row As DataRow
        Dim pc As New ProcessMainControl
        Me.RepositoryItemLookUpEdit1.DataSource = pc.ProDepartMent_GetList(Nothing, ComboBoxEdit1.Text)
        Me.RepositoryItemLookUpEdit1.DisplayMember = "D_Dep"
        Me.RepositoryItemLookUpEdit1.ValueMember = "D_ID"

        For i As Integer = 0 To PsL.Count - 1
            Row = ds.Tables("ProcessSub").NewRow
            Row("PS_NO") = PsL(i).PS_NO
            Row("PS_Num") = PsL(i).PS_Num
            Row("D_Name") = PsL(i).D_ID
            Row("PS_Type") = PsL(i).PS_Type
            Row("PS_Name") = PsL(i).PS_Name
            Row("PS_Remark") = PsL(i).PS_Remark
            Row("Pro_NO") = PsL(i).Pro_NO
            Row("PS_Check") = PsL(i).PS_Check

            'Row("PS_PaiXu") = PsL(i).PS_PaiXu
            Row("PS_Enable") = PsL(i).PS_Enable
            Row("PS_OutPut") = PsL(i).PS_OutPut
            Row("PS_Weight") = PsL(i).PS_Weight

            ds.Tables("ProcessSub").Rows.Add(Row)
        Next

    End Function
    Private Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("ProcessSub") '子表

            .Columns.Add("Pro_M_NO", GetType(String))
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Num", GetType(String))
            .Columns.Add("D_Name", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
            .Columns.Add("PS_Type", GetType(String))
            .Columns.Add("PS_Remark", GetType(String))
            .Columns.Add("Pro_NO", GetType(String))
            .Columns.Add("PS_Check", GetType(Boolean))
            '.Columns.Add("PS_PaiXu", GetType(String))
            .Columns.Add("PS_Enable", GetType(Boolean))
            .Columns.Add("PS_OutPut", GetType(String))
            .Columns.Add("PS_Weight", GetType(Double))
        End With
        '創建刪除數據表
        With ds.Tables.Add("DelData")

            .Columns.Add("PS_NO", GetType(String))

        End With
        With ds.Tables.Add("ProductSub") '子配件表
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_PID", GetType(String))
            .Columns.Add("M_KEY", GetType(String))
        End With


        '綁定表格
        GridControl1.DataSource = ds.Tables("ProcessSub")
        Me.TreeList1.DataSource = ds.Tables("ProductSub")
    End Sub

    Private Sub pupPDProductDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupPDProductDel.Click
        If ds.Tables("ProcessSub").Rows.Count = 0 Then Exit Sub
        Dim pfc As New ProductionFieldControl
        Dim str As String

        If IsDBNull(ds.Tables("ProcessSub").Rows(GridView1.FocusedRowHandle)("PS_NO")) Then
            str = Nothing
        Else
            str = ds.Tables("ProcessSub").Rows(GridView1.FocusedRowHandle)("PS_NO")
            If pfc.ProductionField_GetList1(Nothing, Nothing, Nothing, Nothing, str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count > 0 Then
                MsgBox("此工藝已經進入物料收發，不能刪除！")
                Exit Sub
            End If

            Dim row As DataRow = ds.Tables("DelData").NewRow
            row("PS_NO") = ds.Tables("ProcessSub").Rows(GridView1.FocusedRowHandle)("PS_NO")
            ds.Tables("DelData").Rows.Add(row)

        End If

        ' ds.Tables("ProcessSub").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))

        ''------------2012-4-17改刪除更新工序序號
        '先將選中記錄以下的編號更新一下，再刪除選中記錄
        For i As Integer = CInt(GridView1.GetFocusedRowCellValue("PS_Num")) To ds.Tables("ProcessSub").Rows.Count - 1 Step 1
            ds.Tables("ProcessSub").Rows(i)("PS_NUM") = i
        Next
        ds.Tables("ProcessSub").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))


    End Sub

    Private Sub pupPDProductInt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupPDProductInt.Click
        On Error Resume Next
        Dim row As DataRow = ds.Tables("ProcessSub").NewRow
        If ds.Tables("ProcessSub").Rows.Count = 0 Then
            row("PS_Num") = 1
            row("PS_Name") = "開料"
            row("PS_Check") = False
            'row("PS_PaiXu") = 1
            row("PS_Type") = "大貨"
            row("PS_OutPut") = 0
            row("PS_Enable") = True
        Else
            row("PS_Num") = ds.Tables("ProcessSub").Rows(ds.Tables("ProcessSub").Rows.Count - 1)("PS_Num") + 1
            row("PS_Check") = False
            'row("PS_PaiXu") = ds.Tables("ProcessSub").Rows(ds.Tables("ProcessSub").Rows.Count - 1)("PS_PaiXu")
            row("PS_OutPut") = 0
            row("PS_Type") = "大貨"
            row("PS_Enable") = True
        End If

        ds.Tables("ProcessSub").Rows.Add(row)

        For i As Integer = ds.Tables("ProcessSub").Rows.Count - 1 To CInt(GridView1.GetFocusedRowCellValue("PS_Num")) Step -1

            If IsDBNull(ds.Tables("ProcessSub").Rows(i - 1)("PS_NO")) Then
                ds.Tables("ProcessSub").Rows(i)("PS_NO") = Nothing
            Else
                ds.Tables("ProcessSub").Rows(i)("PS_NO") = ds.Tables("ProcessSub").Rows(i - 1)("PS_NO")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i - 1)("D_Name")) Then
                ds.Tables("ProcessSub").Rows(i)("D_Name") = Nothing
            Else
                ds.Tables("ProcessSub").Rows(i)("D_Name") = ds.Tables("ProcessSub").Rows(i - 1)("D_Name")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i - 1)("PS_Name")) Then
                ds.Tables("ProcessSub").Rows(i)("PS_Name") = Nothing
            Else
                ds.Tables("ProcessSub").Rows(i)("PS_Name") = ds.Tables("ProcessSub").Rows(i - 1)("PS_Name")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i - 1)("PS_Remark")) Then
                ds.Tables("ProcessSub").Rows(i)("PS_Remark") = Nothing
            Else
                ds.Tables("ProcessSub").Rows(i)("PS_Remark") = ds.Tables("ProcessSub").Rows(i - 1)("PS_Remark")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i - 1)("PS_Weight")) Then
                ds.Tables("ProcessSub").Rows(i)("PS_Weight") = Nothing
            Else
                ds.Tables("ProcessSub").Rows(i)("PS_Weight") = ds.Tables("ProcessSub").Rows(i - 1)("PS_Weight")
            End If
            'If IsDBNull(ds.Tables("ProcessSub").Rows(i - 1)("PS_PaiXu")) Then
            '    ds.Tables("ProcessSub").Rows(i)("PS_PaiXu") = Nothing
            'Else
            '    ds.Tables("ProcessSub").Rows(i)("PS_PaiXu") = ds.Tables("ProcessSub").Rows(i - 1)("PS_PaiXu")
            'End If

            If ds.Tables("ProcessSub").Rows(i - 1)("PS_OutPut") = 0 Then
                ds.Tables("ProcessSub").Rows(i)("PS_OutPut") = 0
            Else
                ds.Tables("ProcessSub").Rows(i)("PS_OutPut") = ds.Tables("ProcessSub").Rows(i - 1)("PS_OutPut")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i - 1)("PS_Enable")) Then
                ds.Tables("ProcessSub").Rows(i)("PS_Enable") = False
            Else
                ds.Tables("ProcessSub").Rows(i)("PS_Enable") = ds.Tables("ProcessSub").Rows(i - 1)("PS_Enable")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i - 1)("PS_Check")) Then
                ds.Tables("ProcessSub").Rows(i)("PS_Check") = False
            Else
                ds.Tables("ProcessSub").Rows(i)("PS_Check") = ds.Tables("ProcessSub").Rows(i - 1)("PS_Check")
            End If

            ''2012-4-16
            If IsDBNull(ds.Tables("ProcessSub").Rows(i - 1)("PS_Type")) Then
                ds.Tables("ProcessSub").Rows(i)("PS_Type") = Nothing
            Else
                ds.Tables("ProcessSub").Rows(i)("PS_Type") = ds.Tables("ProcessSub").Rows(i - 1)("PS_Type")
            End If

        Next

        Dim j As Integer = CInt(GridView1.GetFocusedRowCellValue("PS_Num")) - 1
        If IsDBNull(ds.Tables("ProcessSub").Rows(j)("PS_NO")) = False Then
            'MsgBox(ds.Tables("ProcessSub").Rows(j)("PS_NO"))
            ds.Tables("ProcessSub").Rows(j)("PS_NO") = Nothing
        End If
        If IsDBNull(ds.Tables("ProcessSub").Rows(j)("D_Name")) = False Then
            ds.Tables("ProcessSub").Rows(j)("D_Name") = Nothing
        End If
        If IsDBNull(ds.Tables("ProcessSub").Rows(j)("PS_Name")) = False Then
            ds.Tables("ProcessSub").Rows(j)("PS_Name") = Nothing
        End If
        If IsDBNull(ds.Tables("ProcessSub").Rows(j)("PS_Remark")) = False Then
            ds.Tables("ProcessSub").Rows(j)("PS_Remark") = Nothing
        End If
        'If IsDBNull(ds.Tables("ProcessSub").Rows(j)("PS_PaiXu")) = False Then
        '    ds.Tables("ProcessSub").Rows(j)("PS_PaiXu") = ds.Tables("ProcessSub").Rows.Count
        'End If
        If IsDBNull(ds.Tables("ProcessSub").Rows(j)("PS_OutPut")) = False Then
            ds.Tables("ProcessSub").Rows(j)("PS_OutPut") = 0
        End If
        If IsDBNull(ds.Tables("ProcessSub").Rows(j)("PS_Weight")) = False Then
            ds.Tables("ProcessSub").Rows(j)("PS_Weight") = 0
        End If
        If IsDBNull(ds.Tables("ProcessSub").Rows(j)("PS_Enable")) = False Then
            ds.Tables("ProcessSub").Rows(j)("PS_Enable") = True
        End If
        If IsDBNull(ds.Tables("ProcessSub").Rows(j)("PS_Check")) = False Then
            ds.Tables("ProcessSub").Rows(j)("PS_Check") = False
        End If

        ''2012-4-16
        If IsDBNull(ds.Tables("ProcessSub").Rows(j)("PS_Type")) = False Then
            ds.Tables("ProcessSub").Rows(j)("PS_Type") = Nothing
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label24.Text
            Case "產品資料工藝流程單"

                If CheckData() = False Then Exit Sub

                If Edit = False Then
                    SaveNew()
                Else
                    SaveEdit()
                End If
            Case "審核"
                UpdateCheck()

            Case "ModifyPsName" '修改工序名稱

                UpdateModifyPsName()

            Case Else
                Exit Select
        End Select
    End Sub

    Sub UpdateModifyPsName()
        Dim pc As New ProcessMainControl
        Dim pi As New ProcessMainInfo
        pi.Pro_NO = txtOMID.Text

        For i As Integer = 0 To ds.Tables("ProcessSub").Rows.Count - 1
            pi.PS_Name = ds.Tables("ProcessSub").Rows(i)("PS_Name").ToString
            pi.PS_NO = ds.Tables("ProcessSub").Rows(i)("PS_NO").ToString
            pi.PS_Remark = ds.Tables("ProcessSub").Rows(i)("PS_Remark").ToString
            pi.D_Name = ds.Tables("ProcessSub").Rows(i)("D_Name").ToString
            If pc.ProcessSub_UpdatePS_NameDep(pi) = False Then
                MsgBox("部分保存失敗,請檢查!")
                Exit Sub
            End If
        Next

        MsgBox("保存成功！")

        Me.Close()

    End Sub

    Private Sub UpdateCheck()
        Dim pc As New ProcessMainControl
        Dim pi As New ProcessMainInfo
        pi.Pro_NO = txtOMID.Text
        pi.Pro_Check = CheckEdit1.Checked
        pi.Pro_CheckAction = InUserID
        pi.Pro_CheckDate = Format(Now, "yyyy/MM/dd")
        pi.Pro_CheckRemark = CheckRemark.Text

        If pc.ProcessMain_UpdateCheck(pi) Then
            MsgBox("審核成功!")
        Else
            MsgBox("審核失敗!")
        End If
        Me.Close()
    End Sub
    Private Sub SaveNew()
        Dim pc As New ProcessMainControl
        Dim pi As New ProcessMainInfo
        Dim pmi As New ProcessMainInfo

        'If CheckData() = False Then

        '    Exit Sub
        'End If

        txtOMID.Text = GetNO()     '單號
        If Len(txtOMID.Text) = 0 Then
            MsgBox("不能生成單號，無法保存")
            Exit Sub
        End If
        pi.Pro_NO = txtOMID.Text
        pi.PM_M_Code = ButtonEdit1.Text
        pi.M_Code = TempCode
        pi.PM_Type = PopupContainerEdit1.Text
        pi.Pro_Type = ComboBoxEdit1.Text
        pi.Pro_Weight = TextEdit4.Text
        pi.Pro_Rate = TextEdit5.Text
        pi.Type3ID = TextEdit2.Text
        pi.Pro_Remark = MemoEdit1.Text
        pi.Pro_Describe = MemoEdit2.Text
        pi.Pro_Action = InUserID
        pi.Pro_Photo = ImageToByte(pPhoto.Image)
        pi.Pro_AddDate = Format(Now, "yyyy/MM/dd")
        pi.Pro_EditDate = Format(Now, "yyyy/MM/dd")

        If pc.ProcessMain_Add(pi) = False Then
            MsgBox("主表保存失敗!")
            Exit Sub
        End If
        If GridView1.RowCount = 0 Then Exit Sub
        If IsDBNull(ds.Tables("ProcessSub").Rows(0)("PS_Name")) Then
            MsgBox("工序第一項必須是'開料'")
            Exit Sub
        End If
        If ds.Tables("ProcessSub").Rows(0)("PS_Name") = "開料" Or CheckKaiLiao = True Then
        Else
            MsgBox("工序第一項必須是'開料'")
            Exit Sub
        End If
        'If Mid(ds.Tables("ProcessSub").Rows(ds.Tables("ProcessSub").Rows.Count - 1)("PS_Name"), 1, 2) = "全檢" Then

        'Else
        '    MsgBox("工序最後一項必須是以'全檢'開頭")
        '    Exit Sub
        'End If

        For i As Integer = 0 To ds.Tables("ProcessSub").Rows.Count - 1

            pmi.M_Code = GetNum()    '工藝編碼

            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                pmi.M_Name = Nothing
            Else
                pmi.M_Name = PopupContainerEdit1.Text & "_" & ds.Tables("ProcessSub").Rows(i)("PS_Name")
            End If

            pmi.Type3ID = TempType3ID
            pmi.M_Unit = "PCS"
            '...............................
            pi.PS_NO = pmi.M_Code    '流水號
            pi.Pro_NO = txtOMID.Text

            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Num")) Then
                pi.PS_Num = Nothing
            Else
                pi.PS_Num = ds.Tables("ProcessSub").Rows(i)("PS_Num")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("D_Name")) Then
                pi.D_Name = Nothing
            Else
                pi.D_Name = ds.Tables("ProcessSub").Rows(i)("D_Name")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                pi.PS_Name = Nothing
            Else
                pi.PS_Name = ds.Tables("ProcessSub").Rows(i)("PS_Name")
            End If
            pi.PS_Type = ds.Tables("ProcessSub").Rows(i)("PS_Type")

            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Remark")) Then
                pi.PS_Remark = Nothing
            Else
                pi.PS_Remark = ds.Tables("ProcessSub").Rows(i)("PS_Remark")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Check")) Then
                pi.PS_Check = False
            Else
                pi.PS_Check = ds.Tables("ProcessSub").Rows(i)("PS_Check")
            End If
            'If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")) Then
            '    pi.PS_PaiXu = Nothing
            'Else
            '    pi.PS_PaiXu = ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")
            'End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Enable")) Then
                pi.PS_Enable = False
            Else
                pi.PS_Enable = ds.Tables("ProcessSub").Rows(i)("PS_Enable")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_OutPut")) Then
                pi.PS_OutPut = 0
            Else
                pi.PS_OutPut = ds.Tables("ProcessSub").Rows(i)("PS_OutPut")
            End If
            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Weight")) Then
                pi.PS_Weight = 0
            Else
                pi.PS_Weight = ds.Tables("ProcessSub").Rows(i)("PS_Weight")
            End If
            If pc.MaterialCode2_Add(pmi) = False Then
                MsgBox("編碼表保存失敗!")
                Exit Sub
            End If

            If pc.ProcessSub_Add(pi) = False Then
                MsgBox("子表保存失敗!")
                Exit Sub
            End If
        Next
        Me.Close()
    End Sub
    Private Function GetNum() As String
        Dim pc As New ProcessMainControl
        Dim pi As New ProcessMainInfo
        Dim str As String
        If ComboBoxEdit1.Text = "裝配出貨" Then
            str = "50001"
        ElseIf ComboBoxEdit1.Text = "生產加工" Then
            str = "50002"
        ElseIf ComboBoxEdit1.Text = "胚部加工" Then
            str = "50003"
        ElseIf ComboBoxEdit1.Text = "品質檢查" Then
            str = "50004"
        Else
            MsgBox("物料編碼生成出錯!")
            GetNum = Nothing
            Exit Function
        End If
        TempType3ID = str & "001001"


        pi = pc.ProcessSub_GetNum(str)
        If pi Is Nothing Then
            GetNum = TempType3ID & "000001"
        Else
            GetNum = TempType3ID & CStr(Microsoft.VisualBasic.Right(CInt(Microsoft.VisualBasic.Right(pi.M_Code, 6)) + 1000001, 6))
        End If
       
    End Function
    Private Function GetNO() As String
        Dim pc As New ProcessMainControl
        Dim pi As New ProcessMainInfo
        Dim str As String
        str = CStr(Format(Now, "yyMMdd"))
        pi = pc.ProcessMain_GetNO(str)
        If pi Is Nothing Then
            GetNo = "PRO" & str & "00001"
        Else
            GetNo = "PRO" & str & Mid((CInt(Mid(pi.Pro_NO, 10)) + 100001), 2)
        End If

    End Function
    Private Function CheckData() As Boolean
        CheckData = False
       
      
        ''If Edit = True Then
        ''            For i As Integer = 0 To ds.Tables("ProcessSub").Rows.Count - 1

        ''                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_NO")) Then
        ''                    str = Nothing
        ''                Else
        ''                    str = ds.Tables("ProcessSub").Rows(i)("PS_NO")
        ''                End If

        ''                If str = Nothing Then GoTo back

        ''                If pfc.ProductionField_GetList(Nothing, str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count > 0 Then
        ''                    'MsgBox("此單有工藝已經進入物料收發，不能修改,只能新增！")
        ''                    Exit Function
        ''                End If
        ''back:
        ''            Next
        ''End If
        If ButtonEdit1.Text = "" Then
            MsgBox("產品編號不能為空")
            ButtonEdit1.Focus()
            Exit Function
        End If

        If TextEdit2.Text = "" Then
            MsgBox("類型不能為空")
            TextEdit2.Focus()
            Exit Function
        End If

        If ComboBoxEdit1.Text = "" Then
            MsgBox("工藝分類不能為空", 64, "提示")
            ComboBoxEdit1.Focus()
            Exit Function
        End If

        If TextEdit4.Text = "" Then
            MsgBox("重量不能為空!", 64, "提示")
            TextEdit4.Focus()
            Exit Function
        ElseIf CDbl(TextEdit4.Text.Trim) < 0 Then
            MsgBox("重量不能小於零!", 64, "提示")
            TextEdit4.Focus()
            Exit Function
        End If

        If TextEdit5.Text = "" Then
            MsgBox("數量比例不能為空!", 64, "提示")
            TextEdit5.Focus()
            Exit Function
        ElseIf CDbl(TextEdit5.Text.Trim) < 0 Then
            MsgBox("數量比例不能小於零!", 64, "提示")
            TextEdit5.Focus()
            Exit Function
        End If

        If Edit = False Then
            Dim pc As New ProcessMainControl
            Dim pi As New ProcessMainInfo
            If pc.ProcessMain_GetList(Nothing, ButtonEdit1.Text, ComboBoxEdit1.Text, TextEdit2.Text, Nothing, Nothing).Count > 0 Then
                MsgBox("類型命名重複,請重新命名!", 64, "提示")
                TextEdit2.Focus()
                Exit Function
            End If

            '2013-11-08
            If CheckPro = True Then ''限制一個產品一個工藝流程
                If pc.ProcessMain_GetList(Nothing, ButtonEdit1.Text, ComboBoxEdit1.Text, Nothing, Nothing, Nothing).Count > 0 Then
                    MsgBox(ButtonEdit1.Text & ",已存在產品工藝流程!", 64, "提示")
                    ButtonEdit1.Focus()
                    Exit Function
                End If
            End If


        End If

        For i As Integer = 0 To ds.Tables("ProcessSub").Rows.Count - 1
            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Weight")) Then
                MsgBox("工藝重量不能為空!", 64, "提示")
                GridView1.FocusedRowHandle = i
                Exit Function
            End If

            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                MsgBox("工序名稱不能為空!", 64, "提示")
                GridView1.FocusedRowHandle = i
                Exit Function
            ElseIf Trim(ds.Tables("ProcessSub").Rows(i)("PS_Name")) = "" Then
                MsgBox("工序名稱不能為空!", 64, "提示")
                GridView1.FocusedRowHandle = i
                Exit Function
            End If
        Next

        CheckData = True

    End Function
    ''程序更改原因
    ''當工序編碼存在物料收發記錄表中時的處理（
    Private Sub SaveAdd2()
        Dim pc As New ProcessMainControl
        Dim pi As New ProcessMainInfo

        Dim pc1 As New ProcessMainControl
        Dim pi1 As New ProcessMainInfo

        Dim pc2 As New ProcessMainControl
        Dim pi2 As New ProcessMainInfo

        Dim pmi As New ProcessMainInfo

        Dim Sign_OK As String ''是否已進入有工藝已經進入物料收發

        If ds.Tables("DelData").Rows.Count > 0 Then '更新刪除子表記錄
            For i As Integer = 0 To ds.Tables("DelData").Rows.Count - 1
                pc.ProcessSub_Delete(Nothing, CStr(ds.Tables("DelData").Rows(i)("PS_NO")))
            Next
        End If
        If ds.Tables("DelData").Rows.Count > 0 Then '更新刪除物料編碼表記錄
            For i As Integer = 0 To ds.Tables("DelData").Rows.Count - 1
                pc.MaterialCode2_Del(CStr(ds.Tables("DelData").Rows(i)("PS_NO")))
            Next
        End If

        For i As Integer = 0 To ds.Tables("ProcessSub").Rows.Count - 1
            Dim str As String
            Dim pfc As New ProductionFieldControl
            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_NO")) Then
                str = Nothing
            Else
                str = ds.Tables("ProcessSub").Rows(i)("PS_NO")
            End If

            Sign_OK = ""

            If pfc.ProductionField_GetList(Nothing, str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count > 0 And Not IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_NO")) Then
                Sign_OK = "B"
            Else
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_NO")) Then
                    Sign_OK = "A"
                Else
                    Sign_OK = "C"
                End If
            End If


            '更新時分三種情況  2012-4-17
            '1.在(物料收發表中, 工序編碼中都不存在)    Sign_OK = "A"  更新表要ADD

            '2.在物料收發中存在，工序編碼中存在      Sign_OK = "B"     只更新PS_NUM

            '3.在物料收發中不存在，工序編碼中存在      Sign_OK = "C"   本記錄全部更新  


            If Sign_OK = "A" Then
                pmi.M_Code = GetNum()    '工藝編碼

                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                    pmi.M_Name = Nothing
                Else
                    pmi.M_Name = PopupContainerEdit1.Text & "_" & ds.Tables("ProcessSub").Rows(i)("PS_Name")
                End If
                pmi.Type3ID = TempType3ID
                '...............................
                pi.PS_NO = pmi.M_Code    '流水號
                pi.Pro_NO = txtOMID.Text

                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Num")) Then
                    pi.PS_Num = Nothing
                Else
                    pi.PS_Num = ds.Tables("ProcessSub").Rows(i)("PS_Num")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("D_Name")) Then
                    pi.D_Name = Nothing
                Else
                    pi.D_Name = ds.Tables("ProcessSub").Rows(i)("D_Name")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                    pi.PS_Name = Nothing
                Else
                    pi.PS_Name = ds.Tables("ProcessSub").Rows(i)("PS_Name")
                End If

                'pi.PS_Type = ds.Tables("ProcessSub").Rows(i)("PS_Type")
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Type")) Then
                    pi.PS_Type = Nothing
                Else
                    pi.PS_Type = ds.Tables("ProcessSub").Rows(i)("PS_Type")
                End If

                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Remark")) Then
                    pi.PS_Remark = Nothing
                Else
                    pi.PS_Remark = ds.Tables("ProcessSub").Rows(i)("PS_Remark")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Check")) Then
                    pi.PS_Check = False
                Else
                    pi.PS_Check = ds.Tables("ProcessSub").Rows(i)("PS_Check")
                End If
                'If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")) Then
                '    pi.PS_PaiXu = Nothing
                'Else
                '    pi.PS_PaiXu = ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")
                'End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Enable")) Then
                    pi.PS_Enable = False
                Else
                    pi.PS_Enable = ds.Tables("ProcessSub").Rows(i)("PS_Enable")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_OutPut")) Then
                    pi.PS_OutPut = 0
                Else
                    pi.PS_OutPut = ds.Tables("ProcessSub").Rows(i)("PS_OutPut")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Weight")) Then
                    pi.PS_Weight = 0
                Else
                    pi.PS_Weight = ds.Tables("ProcessSub").Rows(i)("PS_Weight")
                End If

                If pc.MaterialCode2_Add(pmi) = False Then
                    MsgBox("編碼表保存失敗!")
                    ' Exit Sub
                End If
                If pc.ProcessSub_Add(pi) Then
                    MsgBox("此物料已經進入物料流轉,保存工藝新增部份成功!")
                    'Exit Sub
                End If
            End If

            If Sign_OK = "B" Then   ''只更新一下
                pi1.PS_NO = ds.Tables("ProcessSub").Rows(i)("PS_NO")   '流水號
                pi1.Pro_NO = txtOMID.Text

                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Num")) Then
                    pi1.PS_Num = Nothing
                Else
                    pi1.PS_Num = ds.Tables("ProcessSub").Rows(i)("PS_Num")
                End If

                If pc1.ProcessSub_Update3(pi1) = False Then
                    MsgBox("子表保存失敗!")
                End If
            End If

            If Sign_OK = "C" Then
                pmi.M_Code = ds.Tables("ProcessSub").Rows(i)("PS_NO")    '工藝編碼
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                    pmi.M_Name = Nothing
                Else
                    pmi.M_Name = PopupContainerEdit1.Text & "_" & ds.Tables("ProcessSub").Rows(i)("PS_Name")
                End If
                pmi.Type3ID = Nothing

                pi2.PS_NO = ds.Tables("ProcessSub").Rows(i)("PS_NO")
                pi2.Pro_NO = txtOMID.Text

                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Num")) Then
                    pi2.PS_Num = Nothing
                Else
                    pi2.PS_Num = ds.Tables("ProcessSub").Rows(i)("PS_Num")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("D_Name")) Then
                    pi2.D_Name = Nothing
                Else
                    pi2.D_Name = ds.Tables("ProcessSub").Rows(i)("D_Name")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                    pi2.PS_Name = Nothing
                Else
                    pi2.PS_Name = ds.Tables("ProcessSub").Rows(i)("PS_Name")
                End If

                'pi2.PS_Type = ds.Tables("ProcessSub").Rows(i)("PS_Type")
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Type")) Then
                    pi2.PS_Type = Nothing
                Else
                    pi2.PS_Type = ds.Tables("ProcessSub").Rows(i)("PS_Type")
                End If

                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Remark")) Then
                    pi2.PS_Remark = Nothing
                Else
                    pi2.PS_Remark = ds.Tables("ProcessSub").Rows(i)("PS_Remark")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Check")) Then
                    pi2.PS_Check = False
                Else
                    pi2.PS_Check = ds.Tables("ProcessSub").Rows(i)("PS_Check")
                End If
                'If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")) Then
                '    pi.PS_PaiXu = Nothing
                'Else
                '    pi.PS_PaiXu = ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")
                'End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Enable")) Then
                    pi2.PS_Enable = False
                Else
                    pi2.PS_Enable = ds.Tables("ProcessSub").Rows(i)("PS_Enable")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_OutPut")) Then
                    pi2.PS_OutPut = 0
                Else
                    pi2.PS_OutPut = ds.Tables("ProcessSub").Rows(i)("PS_OutPut")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Weight")) Then
                    pi2.PS_Weight = 0
                Else
                    pi2.PS_Weight = ds.Tables("ProcessSub").Rows(i)("PS_Weight")
                End If

                If pc2.MaterialCode2_Update(pmi) = False Then
                    MsgBox("編碼表修改失敗!")
                    Exit Sub
                End If
                If pc2.ProcessSub_Update(pi2) = False Then
                    MsgBox("子表保存失敗!")
                    Exit Sub
                End If
            End If

        Next

        Me.Close()
    End Sub
    Private Sub SaveEdit()
        Dim pc As New ProcessMainControl
        Dim pi As New ProcessMainInfo
        Dim pmi As New ProcessMainInfo

        Dim pfc As New ProductionFieldControl

        pi.Pro_NO = txtOMID.Text
        pi.PM_M_Code = ButtonEdit1.Text
        pi.M_Code = TempCode
        pi.PM_Type = PopupContainerEdit1.Text
        pi.Pro_Weight = TextEdit4.Text
        pi.Pro_Rate = TextEdit5.Text
        pi.Pro_Type = ComboBoxEdit1.Text
        pi.Type3ID = TextEdit2.Text
        pi.Pro_Remark = MemoEdit1.Text
        pi.Pro_Describe = MemoEdit2.Text
        pi.Pro_Action = InUserID
        pi.Pro_Photo = ImageToByte(pPhoto.Image)
        pi.Pro_AddDate = Nothing
        pi.Pro_EditDate = Format(Now, "yyyy/MM/dd")

        If pc.ProcessMain_Update(pi) = False Then
            MsgBox("主表保存失敗!")
            Exit Sub
        End If

        For i As Integer = 0 To ds.Tables("ProcessSub").Rows.Count - 1
            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_NO")) = False Then
                If pfc.ProductionField_GetList(Nothing, ds.Tables("ProcessSub").Rows(i)("PS_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count > 0 Then
                    Call SaveAdd2()
                    Exit Sub
                End If
            End If
        Next


        'If CheckData() = False Then
        '    Call SaveAdd2()
        '    Exit Sub
        'End If

        If GridView1.RowCount = 0 Then Exit Sub


        If ds.Tables("ProcessSub").Rows(0)("PS_Name") = "開料" Or CheckKaiLiao = True Then
        Else
            MsgBox("工序第一項必須是'開料'")
            Exit Sub
        End If
        'If Mid(ds.Tables("ProcessSub").Rows(ds.Tables("ProcessSub").Rows.Count - 1)("PS_Name"), 1, 2) = "全檢" Then

        'Else
        '    MsgBox("工序最後一項必須是以'全檢'開頭")
        '    Exit Sub
        'End If


        If ds.Tables("DelData").Rows.Count > 0 Then '更新刪除子表記錄
            For i As Integer = 0 To ds.Tables("DelData").Rows.Count - 1
                pc.ProcessSub_Delete(Nothing, CStr(ds.Tables("DelData").Rows(i)("PS_NO")))
            Next
        End If
        If ds.Tables("DelData").Rows.Count > 0 Then '更新刪除物料編碼表記錄
            For i As Integer = 0 To ds.Tables("DelData").Rows.Count - 1
                pc.MaterialCode2_Del(CStr(ds.Tables("DelData").Rows(i)("PS_NO")))
            Next
        End If
        For i As Integer = 0 To ds.Tables("ProcessSub").Rows.Count - 1

            If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_NO")) Then

                pmi.M_Code = GetNum()    '工藝編碼

                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                    pmi.M_Name = Nothing
                Else
                    pmi.M_Name = PopupContainerEdit1.Text & "_" & ds.Tables("ProcessSub").Rows(i)("PS_Name")
                End If
                pmi.Type3ID = TempType3ID
                '...............................
                pi.PS_NO = pmi.M_Code    '流水號
                pi.Pro_NO = txtOMID.Text

                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Num")) Then
                    pi.PS_Num = Nothing
                Else
                    pi.PS_Num = ds.Tables("ProcessSub").Rows(i)("PS_Num")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("D_Name")) Then
                    pi.D_Name = Nothing
                Else
                    pi.D_Name = ds.Tables("ProcessSub").Rows(i)("D_Name")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                    pi.PS_Name = Nothing
                Else
                    pi.PS_Name = ds.Tables("ProcessSub").Rows(i)("PS_Name")
                End If
                pi.PS_Type = ds.Tables("ProcessSub").Rows(i)("PS_Type")
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Remark")) Then
                    pi.PS_Remark = Nothing
                Else
                    pi.PS_Remark = ds.Tables("ProcessSub").Rows(i)("PS_Remark")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Check")) Then
                    pi.PS_Check = False
                Else
                    pi.PS_Check = ds.Tables("ProcessSub").Rows(i)("PS_Check")
                End If
                'If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")) Then
                '    pi.PS_PaiXu = Nothing
                'Else
                '    pi.PS_PaiXu = ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")
                'End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Enable")) Then
                    pi.PS_Enable = False
                Else
                    pi.PS_Enable = ds.Tables("ProcessSub").Rows(i)("PS_Enable")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_OutPut")) Then
                    pi.PS_OutPut = 0
                Else
                    pi.PS_OutPut = ds.Tables("ProcessSub").Rows(i)("PS_OutPut")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Weight")) Then
                    pi.PS_Weight = 0
                Else
                    pi.PS_Weight = ds.Tables("ProcessSub").Rows(i)("PS_Weight")
                End If
                If pc.MaterialCode2_Add(pmi) = False Then
                    MsgBox("編碼表保存失敗!")
                    Exit Sub
                End If
                If pc.ProcessSub_Add(pi) = False Then
                    MsgBox("子表保存失敗!")
                    Exit Sub
                End If
            Else

                pmi.M_Code = ds.Tables("ProcessSub").Rows(i)("PS_NO")    '工藝編碼
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                    pmi.M_Name = Nothing
                Else
                    pmi.M_Name = PopupContainerEdit1.Text & "_" & ds.Tables("ProcessSub").Rows(i)("PS_Name")
                End If
                pmi.Type3ID = Nothing

                pi.PS_NO = ds.Tables("ProcessSub").Rows(i)("PS_NO")
                pi.Pro_NO = txtOMID.Text

                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Num")) Then
                    pi.PS_Num = Nothing
                Else
                    pi.PS_Num = ds.Tables("ProcessSub").Rows(i)("PS_Num")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("D_Name")) Then
                    pi.D_Name = Nothing
                Else
                    pi.D_Name = ds.Tables("ProcessSub").Rows(i)("D_Name")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Name")) Then
                    pi.PS_Name = Nothing
                Else
                    pi.PS_Name = ds.Tables("ProcessSub").Rows(i)("PS_Name")
                End If
                pi.PS_Type = ds.Tables("ProcessSub").Rows(i)("PS_Type")
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Remark")) Then
                    pi.PS_Remark = Nothing
                Else
                    pi.PS_Remark = ds.Tables("ProcessSub").Rows(i)("PS_Remark")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Check")) Then
                    pi.PS_Check = False
                Else
                    pi.PS_Check = ds.Tables("ProcessSub").Rows(i)("PS_Check")
                End If
                'If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")) Then
                '    pi.PS_PaiXu = Nothing
                'Else
                '    pi.PS_PaiXu = ds.Tables("ProcessSub").Rows(i)("PS_PaiXu")
                'End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Enable")) Then
                    pi.PS_Enable = False
                Else
                    pi.PS_Enable = ds.Tables("ProcessSub").Rows(i)("PS_Enable")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_OutPut")) Then
                    pi.PS_OutPut = 0
                Else
                    pi.PS_OutPut = ds.Tables("ProcessSub").Rows(i)("PS_OutPut")
                End If
                If IsDBNull(ds.Tables("ProcessSub").Rows(i)("PS_Weight")) Then
                    pi.PS_Weight = 0
                Else
                    pi.PS_Weight = ds.Tables("ProcessSub").Rows(i)("PS_Weight")
                End If

                If pc.MaterialCode2_Update(pmi) = False Then
                    MsgBox("編碼表修改失敗!")
                    Exit Sub
                End If
                If pc.ProcessSub_Update(pi) = False Then
                    MsgBox("子表保存失敗!")
                    Exit Sub
                End If
            End If

        Next

        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
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

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pPhoto.Image = Nothing
    End Sub

    Private Sub TreeList1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeList1.MouseDoubleClick

        PopupContainerEdit1.EditValue = TreeList1.FocusedNode.GetValue("M_Name")
        TempCode = TreeList1.FocusedNode.GetValue("M_Code")
        PopupContainerControl1.OwnerEdit.ClosePopup()
        If Edit = False Then
            TextEdit2.Text = PopupContainerEdit1.Text
        End If

    End Sub

    Private Sub PopupContainerEdit1_ButtonPressed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles PopupContainerEdit1.ButtonPressed
        On Error Resume Next
        Dim pbc As New ProductBomController
        Dim pbiL As List(Of ProductBomInfo)
        pbiL = pbc.ProductBom_GetList(ButtonEdit1.Text.ToString, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pbiL Is Nothing Then
            MsgBox("產品配件為空！")
        End If
        SubRowAdd(pbiL)
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        pPhoto.Image = Nothing
    End Sub


    Private Sub ImageInput_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageInput.EditValueChanged
        On Error Resume Next
        Dim ptc As New ProductController
        Dim ptiL As New List(Of ProductInfo)
        ptiL = ptc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If ptiL.Count > 0 Then
            pPhoto.Image = ByteToImage(ptiL(0).PM_Image)
        Else
            MsgBox("產品編號圖片為空！")
        End If
    End Sub

    'Private Sub GridView1_RowStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles GridView1.RowStyle
    '    For i As Integer = 0 To ds.Tables("ProcessSub").Rows.Count - 1
    '        MsgBox(GridView1.GetRowCellDisplayText(1, "PS_Enable"))
    '        If GridView1.GetRowCellDisplayText(i, "PS_Enable") = False Then
    '            If e.RowHandle = i Then
    '                e.Appearance.BackColor = Color.Blue
    '            End If
    '        End If

    '    Next

    'End Sub

    Private Sub popEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popEnable.Click

        If GridView1.RowCount = 0 Then Exit Sub
        If IsDBNull(ds.Tables("ProcessSub").Rows(GridView1.FocusedRowHandle)("PS_NO")) Then
            MsgBox("請保存后在啟用!")
            Exit Sub
        End If
        If ds.Tables("ProcessSub").Rows(GridView1.FocusedRowHandle)("PS_Enable") = True Then

            ds.Tables("ProcessSub").Rows(GridView1.FocusedRowHandle)("PS_Enable") = False
        Else
            ds.Tables("ProcessSub").Rows(GridView1.FocusedRowHandle)("PS_Enable") = True
        End If

        Dim pc As New ProcessMainControl
        Dim pi As New ProcessMainInfo
        pi.PS_NO = ds.Tables("ProcessSub").Rows(GridView1.FocusedRowHandle)("PS_NO")
        pi.Pro_NO = txtOMID.Text
        pi.PS_Enable = ds.Tables("ProcessSub").Rows(GridView1.FocusedRowHandle)("PS_Enable")

        pc.ProcessSub_Update2(pi)

    End Sub

    'Private Sub TextEdit4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit4.KeyUp
    '    Dim m As New System.Text.RegularExpressions.Regex("^+?(\d+(\.\d*)?|\.\d+)$")  '顯示整數,正浮點數正則表達式

    '    If m.IsMatch(TextEdit4.Text) = True Then

    '    Else

    '        TextEdit4.Text = Nothing
    '        Exit Sub
    '    End If
    'End Sub

    'Private Sub TextEdit5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit5.KeyUp
    '    If (e.KeyValue > 47 And e.KeyValue < 58) Or (e.KeyValue > 95 And e.KeyValue < 106) Or (e.KeyValue = 8) Or (e.KeyValue = 45) Or (e.KeyValue = 46) Then

    '    Else
    '        TextEdit5.Text = Nothing
    '        Exit Sub
    '    End If
    'End Sub

    ''' <summary>
    ''' '載入權限
    ''' </summary>
    ''' <remarks></remarks>
    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850108") '取消判斷開料
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                CheckKaiLiao = True
            Else
                CheckKaiLiao = False
            End If
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850109") '顯示模板工藝
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                Panel2.Visible = True
            Else
                Panel2.Visible = False
            End If
        End If

        '2013-10-08
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "850110") '顯示產品
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                CheckPro = True
            Else
                CheckPro = False
            End If
        End If

    End Sub

    Private Sub cmdProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcess.Click

        If Label24.Text = "產品資料工藝流程單" Then
            If Edit = True Then
                MsgBox("修改狀態不能,加載工藝模板!")
                Exit Sub
            End If
        End If


        Dim intRow = ds.Tables("ProcessSub").Rows.Count
        Dim i As Integer
        For i = 0 To intRow - 1
            ds.Tables("ProcessSub").Rows.RemoveAt(0)
        Next
        '-------------------------
        Dim ptcon As New ProcessTypeControl
        Dim ptlist As New List(Of ProcessTypeInfo)
        ptlist = ptcon.ProcessType_GetList(Nothing, gluProcessType.Text, Nothing)

        For i = 0 To ptlist.Count - 1
            Dim row As DataRow
            row = ds.Tables("ProcessSub").NewRow
            row("PS_Check") = False
            row("PS_Num") = i + 1
            row("D_Name") = ptlist(i).D_ID
            row("PS_Name") = ptlist(i).D_ProcessName
            row("PS_OutPut") = 0
            row("PS_Type") = "大貨"
            row("PS_Weight") = 0
            row("PS_Enable") = True
            row("PS_Remark") = ptlist(i).Remarks
            ds.Tables("ProcessSub").Rows.Add(row)
        Next
    End Sub

    Private Sub ButtonSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSet.Click
       
        frmPDProductTypeSet.ShowDialog()
        frmPDProductTypeSet.Dispose()
    End Sub
End Class
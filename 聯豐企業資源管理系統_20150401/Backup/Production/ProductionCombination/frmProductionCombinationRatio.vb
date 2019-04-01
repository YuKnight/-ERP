Imports LFERP.Library.ProductionField
Imports LFERP.DataSetting
Imports LFERP.SystemManager
Imports LFERP.Library.Product
Imports LFERP.Library.WareHouse
Imports LFERP.Library.ProductionWareHouse
Imports LFERP.Library.ProductionSchedule
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionFieldType
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.ProductionKaiLiao
Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.Production.ProductionFieldDaySummary
Imports System.Threading
Imports LFERP.Library.Production.ProductionAffair
Imports LFERP.Library.ProductionCombination
Imports LFERP.Library.Production.ProductionRatio


Public Class frmProductionCombinationRatio

    Dim uc As New SystemUser.SystemUserController
    Dim dc As New DepartmentControler
    Dim fc As New LFERP.Library.PieceProcess.PersonnelControl
    Dim pc As New ProductionCombinationControl
    Dim prc As New ProductionRatioControl

    Dim ds As New DataSet
    Dim upi As List(Of UserPowerInfo)
    Dim upc As New UserPowerControl

    Dim OldCheck As Boolean
    Dim DeclareQty As Single
    Public strPro_NO As String
    Dim isAdd As Boolean        '記錄是否是新增

    Private Sub frmProductionCombination_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()       '調用創建表過程

        '加載產品編號
        Dim mc As New ProcessMainControl
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)
        isAdd = False

        Select Case lblTittle.Text
            Case "工序組合比例-新增"
                isAdd = True
            Case "工序組合比例-修改"
                Me.Text = lblTittle.Text
                LoadData()      '調用加載數據過程

            Case "工序組合比例-查看"
                Me.Text = lblTittle.Text
                cmdSave.Enabled = False
                LoadData()      '調用加載數據過程
                Grid.ContextMenuStrip.Enabled = False
            Case "工序組合比例-審核"
                Me.Text = lblTittle.Text
                LoadData()      '調用加載數據過程
                lblPR_CheckDate.Text = Format(Now, "yyyy/MM/dd")
                lblPR_CheckUserName.Text = UserName
                cbType.Enabled = False
                PM_M_Code.Enabled = False
                gluType.Enabled = False
                GluEdit1.Enabled = False
                MemoEdit1.Enabled = False
                PR_Ratio.OptionsColumn.ReadOnly = True
                Grid.ContextMenuStrip.Enabled = False
        End Select

    End Sub
    ''' <summary>
    ''' 創建表
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' frmProductionCombination_Load()
    Sub CreateTable()
        ds.Tables.Clear()

        '配件名稱表
        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluType.Properties.ValueMember = "PM_Type"
        gluType.Properties.DisplayMember = "PM_Type"
        gluType.Properties.DataSource = ds.Tables("ProductType")

        '工序名稱表
        With ds.Tables.Add("Process")
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
        End With
        GluEdit1.Properties.ValueMember = "PS_NO"
        GluEdit1.Properties.DisplayMember = "PS_Name"
        GluEdit1.Properties.DataSource = ds.Tables("Process")

        '比例信息表
        With ds.Tables.Add("Combination")

            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("Pro_Type1", GetType(String))
            .Columns.Add("PM_M_Code1", GetType(String))
            .Columns.Add("PM_Type1", GetType(String))
            .Columns.Add("PS_Name1", GetType(String))
            .Columns.Add("Pro_NO1", GetType(String))
            .Columns.Add("PR_Ratio", GetType(Integer))

        End With
        Grid.DataSource = ds.Tables("Combination")

        '刪除表(用於修改時刪除數據用)
        With ds.Tables.Add("DelCombination")
            .Columns.Add("AutoID", GetType(String))
        End With
    End Sub
    ''' <summary>
    ''' 加載數據過程
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    ''' frmProductionCombination_Load()
    Function LoadData() As Boolean
        LoadData = True

        ds.Tables("Combination").Clear()

        Dim pri As List(Of ProductionRatioInfo)

        pri = prc.ProductionRatio_GetList(Nothing, strPro_NO, Nothing, Nothing)
        '判斷工序編號是否存在
        If pri.Count = 0 Then
            LoadData = False
        Else
            cbType.EditValue = pri(0).Pro_Type
            PM_M_Code.EditValue = pri(0).PM_M_Code
            gluType.EditValue = pri(0).PM_Type
            GluEdit1.EditValue = pri(0).Pro_NO
            MemoEdit1.EditValue = pri(0).PR_Remark
            chkPR_Check.Checked = pri(0).PR_Check
            lblPR_CheckUserName.Text = pri(0).PR_CheckUserName
            lblPR_CheckDate.Text = Format(pri(0).PR_CheckDate, "yyyy/MM/dd")

            Dim row As DataRow
            Dim i As Integer
            For i = 0 To pri.Count - 1

                row = ds.Tables("Combination").NewRow

                row("AutoID") = pri(i).AutoID
                row("Pro_Type1") = pri(i).Pro_Type1
                row("PM_M_Code1") = pri(i).PM_M_Code1
                row("PM_Type1") = pri(i).PM_Type1
                row("Pro_NO1") = pri(i).Pro_NO1 '隱藏不顯示
                row("PS_Name1") = pri(i).PS_Name1
                row("PR_Ratio") = pri(i).PR_Ratio

                ds.Tables("Combination").Rows.Add(row)
            Next

            If chkPR_Check.Checked = True Or lblTittle.Text = "工序組合比例-審核" Then
                chkPR_Check.Visible = True
                Panel1.Visible = True
            End If
        End If

    End Function
    ''' <summary>
    ''' 保存新增數據過程
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' cmdSave_Click()
    Sub DataNew()
        Dim i, j As Integer
        Dim pri As New ProductionRatioInfo

        '判斷工序組合是否已存在
        For j = 0 To ds.Tables("Combination").Rows.Count - 1
            If prc.ProductionRatio_GetList(Nothing, GluEdit1.EditValue, ds.Tables("Combination").Rows(j)("Pro_NO1"), Nothing).Count > 0 Then
                GridView1.FocusedRowHandle = j
                MsgBox("已存在此工序組合!", 64, "提示")
                Exit Sub
            End If
        Next

        pri.Pro_Type = cbType.EditValue
        pri.PM_M_Code = PM_M_Code.EditValue
        pri.PM_Type = gluType.EditValue
        pri.Pro_NO = GluEdit1.EditValue

        pri.PR_AddDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        pri.PR_Remark = MemoEdit1.EditValue
        pri.PR_AddUserID = InUserID

        For i = 0 To ds.Tables("Combination").Rows.Count - 1

            pri.Pro_Type1 = ds.Tables("Combination").Rows(i)("Pro_Type1")
            pri.PM_M_Code1 = ds.Tables("Combination").Rows(i)("PM_M_Code1")
            pri.PM_Type1 = ds.Tables("Combination").Rows(i)("PM_Type1")
            pri.Pro_NO1 = ds.Tables("Combination").Rows(i)("Pro_NO1")
            pri.PS_Name1 = ds.Tables("Combination").Rows(i)("PS_Name1")
            pri.PR_Ratio = ds.Tables("Combination").Rows(i)("PR_Ratio")

            prc.ProductionRatio_Add(pri)

        Next

        MsgBox("新增完成!", 64, "提示")
        Me.Close()

    End Sub
    ''' <summary>
    ''' 保存修改數據過程
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' cmdSave_Click()
    Sub DataEdit()
        Dim i, j As Integer
        Dim pri As New ProductionRatioInfo

        '判斷刪除表中是否有需要刪除的信息，有則刪除數據庫中相應信息
        If ds.Tables("DelCombination").Rows.Count > 0 Then
            For j = 0 To ds.Tables("DelCombination").Rows.Count - 1
                prc.ProductionRatio_Delete(ds.Tables("DelCombination").Rows(j)("AutoID"), Nothing)
            Next
        End If

        pri.Pro_Type = cbType.EditValue
        pri.PM_M_Code = PM_M_Code.EditValue
        pri.PM_Type = gluType.EditValue
        pri.Pro_NO = GluEdit1.EditValue

        pri.PR_ModifyDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        pri.PR_Remark = MemoEdit1.EditValue
        pri.PR_ModifyUserID = InUserID

        For i = 0 To ds.Tables("Combination").Rows.Count - 1
            If ds.Tables("Combination").Rows(i)("AutoID") Is DBNull.Value Then      '判斷是否有新增數據
                pri.Pro_Type1 = ds.Tables("Combination").Rows(i)("Pro_Type1")
                pri.PM_M_Code1 = ds.Tables("Combination").Rows(i)("PM_M_Code1")
                pri.PM_Type1 = ds.Tables("Combination").Rows(i)("PM_Type1")
                pri.Pro_NO1 = ds.Tables("Combination").Rows(i)("Pro_NO1")
                pri.PS_Name1 = ds.Tables("Combination").Rows(i)("PS_Name1")
                pri.PR_Ratio = ds.Tables("Combination").Rows(i)("PR_Ratio")

                pri.PR_AddDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
                pri.PR_AddUserID = InUserID

                prc.ProductionRatio_Add(pri)
            Else
                pri.AutoID = ds.Tables("Combination").Rows(i)("AutoID")
                pri.Pro_Type1 = ds.Tables("Combination").Rows(i)("Pro_Type1")
                pri.PM_M_Code1 = ds.Tables("Combination").Rows(i)("PM_M_Code1")
                pri.PM_Type1 = ds.Tables("Combination").Rows(i)("PM_Type1")
                pri.Pro_NO1 = ds.Tables("Combination").Rows(i)("Pro_NO1")
                pri.PS_Name1 = ds.Tables("Combination").Rows(i)("PS_Name1")
                pri.PR_Ratio = ds.Tables("Combination").Rows(i)("PR_Ratio")

                prc.ProductionRatio_Update(pri)
            End If
        Next

        MsgBox("修改完成!", 64, "提示")
        Me.Close()

    End Sub
    ''' <summary>
    ''' 保存審核信息過程
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' cmdSave_Click()
    Sub DataCheck()
        Dim pri As New ProductionRatioInfo

        pri.Pro_NO = GluEdit1.EditValue
        pri.PR_Check = chkPR_Check.Checked
        pri.PR_CheckUserID = InUserID
        pri.PR_CheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

        If prc.ProductionRatio_Check(pri) = True Then
            MsgBox("審核完成!", 64, "提示")
            Me.Close()
        Else
            MsgBox("審核失敗!", 64, "提示")
        End If

    End Sub
    ''' <summary>
    ''' 單擊確定按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i As Integer
        If GluEdit1.Text.Trim = "" Then
            MsgBox("工序名稱不能為空!", 64, "提示")
            GluEdit1.Focus()
            Exit Sub
        End If
        For i = 0 To ds.Tables("Combination").Rows.Count - 1
            If ds.Tables("Combination").Rows(i)("PR_Ratio") < 1 Then
                GridView1.FocusedRowHandle = i
                MsgBox("工序比例不能小於1！")
                Exit Sub
            End If
        Next

        If ds.Tables("Combination").Rows.Count = 1 Then
            If ds.Tables("Combination").Rows(0)("PR_Ratio") = 1 Then
                MsgBox("只有一個工序組合時，工序比例不能等於1！")
                Exit Sub
            End If
        End If

        Select Case lblTittle.Text
            Case "工序組合比例-新增"
                DataNew()

            Case "工序組合比例-修改"
                DataEdit()

            Case "工序組合比例-審核"
                DataCheck()

        End Select
    End Sub
    ''' <summary>
    ''' 單擊取消按鈕,關閉窗體
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“添加”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click
        tempCode = ""
     
        tempValue2 = "工序拆分管理"

        frmProductionSelect.ShowDialog()
        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempCode, ",")
            n = Len(Replace(tempCode, ",", "," & "*")) - Len(tempCode)
            For i = 0 To n
                If arr(i) = "" Then
                    Exit Sub
                End If
                AddRow(arr(i))
            Next
        End If
        tempCode = ""
    End Sub
    ''' <summary>
    ''' 向比例信息表填充數據過程
    ''' </summary>
    ''' <param name="M_Code"></param>
    '''此過程被以下過程調用：
    ''' cmsAdd_Click()
    Sub AddRow(ByVal M_Code As String) '通過工序編號導入相應信息(工藝類型,產品編號,類型,工序名稱等)

        If M_Code = "" Then
        Else
            If GluEdit1.EditValue = M_Code Then   '@ 2012/7/25 添加　
                MsgBox("工序：" & GluEdit1.Text & " 與大工序相同，不能添加!", 64, "提示")
                Exit Sub
            End If

            Dim pic As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)
            pci = pic.ProcessSub_GetList(Nothing, M_Code, Nothing, Nothing, Nothing, Nothing)
            If pci.Count = 0 Then Exit Sub

            Dim i As Integer
            '判斷工序是否已存在
            For i = 0 To ds.Tables("Combination").Rows.Count - 1
                If M_Code = ds.Tables("Combination").Rows(i)("Pro_NO1") Then
                    MsgBox("工序：" & ds.Tables("Combination").Rows(i)("PS_Name1") & " 已存在!", 64, "提示")
                    Exit Sub
                End If
            Next

            For i = 0 To pci.Count - 1

                Dim row As DataRow
                row = ds.Tables("Combination").NewRow

                row("Pro_Type1") = pci(i).Pro_Type
                row("PM_M_Code1") = pci(i).PM_M_Code
                row("PM_Type1") = pci(i).Type3ID  '實際類型
                row("Pro_NO1") = M_Code
                row("PS_Name1") = pci(i).PS_Name
                row("PR_Ratio") = 1

                ds.Tables("Combination").Rows.Add(row)
            Next
        End If
        GridView1.MoveLast()
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“刪除”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelCombination").NewRow

            row("AutoID") = ds.Tables("Combination").Rows(GridView1.FocusedRowHandle)("AutoID")

            ds.Tables("DelCombination").Rows.Add(row)
        End If
        ds.Tables("Combination").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub
    ''' <summary>
    ''' 產品編號改變時，加載相應的配件名稱信息
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用：
    ''' cbType_SelectedIndexChanged()
    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged
        On Error Resume Next

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)
        gluType.Text = ""
        ds.Tables("ProductType").Clear()
        ds.Tables("Process").Clear()
        ppi = ppc.ProcessMain_GetList2(cbType.EditValue, PM_M_Code.EditValue)
        If ppi.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To ppi.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductType").NewRow
                row("PM_Type") = ppi(i).Type3ID
                ds.Tables("ProductType").Rows.Add(row)
            Next
            GluEdit1.EditValue = Nothing
        End If

    End Sub
    ''' <summary>
    ''' 配件名稱改變時，加載相應的工序名稱信息
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluType.EditValueChanged
        Dim pc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)
        pci = pc.ProcessMain_GetList(Nothing, PM_M_Code.EditValue, cbType.EditValue, gluType.EditValue, Nothing, True)

        Try

            GluEdit1.Text = ""
            ds.Tables("Process").Clear()

            If pci.Count = 0 Then Exit Sub

            Dim i As Integer
            For i = 0 To pci.Count - 1
                Dim row As DataRow
                row = ds.Tables("Process").NewRow

                row("PS_NO") = pci(i).PS_NO
                row("PS_Name") = pci(i).PS_Name

                ds.Tables("Process").Rows.Add(row)

            Next

        Catch ex As Exception

        End Try
    End Sub
    ''' <summary>
    ''' 工藝類型改變時，調用產品編號改變過程
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbType.SelectedIndexChanged
        PM_M_Code_EditValueChanged(Nothing, Nothing)    '調用產品編號改變過程
    End Sub
    ''' <summary>
    ''' 大工序改變時，判斷該工序是否已存在組合，存在則加載
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' @ 2012/7/25 添加
    Private Sub GluEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GluEdit1.EditValueChanged
        If GluEdit1.EditValue Is Nothing Then Exit Sub

        If isAdd = True Then    '判斷是否是新增
            ds.Tables("Combination").Rows.Clear()

            chkPR_Check.Visible = False
            chkPR_Check.Enabled = True
            Panel1.Visible = False
            cmdSave.Enabled = True
            Grid.ContextMenuStrip.Enabled = True

            Dim pri As List(Of ProductionRatioInfo)
            pri = prc.ProductionRatio_GetList(Nothing, GluEdit1.EditValue, Nothing, Nothing)
            If pri.Count > 0 Then
                Dim i%

                chkPR_Check.Checked = pri(0).PR_Check
                lblPR_CheckUserName.Text = pri(0).PR_CheckUserName
                lblPR_CheckDate.Text = pri(0).PR_CheckDate

                For i = 0 To pri.Count - 1

                    Dim row As DataRow
                    row = ds.Tables("Combination").NewRow

                    row("AutoID") = pri(i).AutoID
                    row("Pro_Type1") = pri(i).Pro_Type1
                    row("PM_M_Code1") = pri(i).PM_M_Code1
                    row("PM_Type1") = pri(i).PM_Type1
                    row("Pro_NO1") = pri(i).Pro_NO1 '隱藏不顯示
                    row("PS_Name1") = pri(i).PS_Name1
                    row("PR_Ratio") = pri(i).PR_Ratio

                    ds.Tables("Combination").Rows.Add(row)
                Next

                If pri(0).PR_Check = True Then
                    MsgBox("工序組合已存在，且已審核，因此不能進行操作！", 64, "提示")

                    chkPR_Check.Visible = True
                    chkPR_Check.Enabled = False
                    Panel1.Visible = True
                    cmdSave.Enabled = False
                    Grid.ContextMenuStrip.Enabled = False
                Else
                    MsgBox("工序組合已存在！", 64, "提示")
                    lblTittle.Text = "工序組合比例-修改"
                    Me.Text = "工序組合比例-修改"
                End If
            Else
                lblTittle.Text = "工序組合比例-新增"
                Me.Text = "工序組合比例-新增"
            End If
        End If
    End Sub
End Class
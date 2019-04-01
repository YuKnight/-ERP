Imports System
Imports System.IO
Imports LFERP.SystemManager
Imports LFERP.DataSetting
Imports LFERP.SystemManager.SystemUser
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Product
Imports LFERP.Library.PieceProcessMoSub

Public Class FrmPieceProcessMainSub
    Dim ds As New DataSet
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub pupPDProductAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupPDProductAdd.Click

        Dim row As DataRow
        row = ds.Tables("PieceProcessMainSub").NewRow
        row("PM_Factor") = 1
        row("PM_Type") = "大貨"
        row("PM_DayNight") = "白班"
        row("PM_Enable") = True
        If ds.Tables("PieceProcessMainSub").Rows.Count = 0 Then
            row("PS_Num") = 1
        Else
            row("PS_Num") = ds.Tables("PieceProcessMainSub").Rows(ds.Tables("PieceProcessMainSub").Rows.Count - 1)("PS_Num") + 1
        End If
        ds.Tables("PieceProcessMainSub").Rows.Add(row)
    End Sub
    Private Sub GetEnable(ByVal a As Boolean, ByVal b As Boolean)
        TextEdit1.Enabled = a
        TextEdit2.Enabled = a
        TextEdit3.Enabled = a
        MemoEdit1.Enabled = a

        CheckEdit1.Enabled = b
        CheckRemark.Enabled = b
    End Sub
    Private Sub FrmPieceProcessMainSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label24.Text = tempValue
        txtOMID.Text = tempValue2
        txtOMID.Enabled = False

        tempValue = ""
        tempValue2 = ""
        CreateTable()
        PowerUser()
        Select Case Label24.Text

            Case "計件工藝流程單"

                GetEnable(True, False)
                TextEdit1.Enabled = False
                TextEdit2.Enabled = False
                TextEdit3.Enabled = False
                Me.Text = "計件單價工序--修改"
                LoadData(txtOMID.Text)

            Case "查看"
                GetEnable(False, False)
                Me.Text = "計件單價工序--查看" & "[" & txtOMID.Text & "]"
                LoadData(txtOMID.Text)
                txtOMID.Enabled = False
                cmdSave.Visible = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1

                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Case "審核"
                GetEnable(False, True)
                Me.Text = "審核" & "[" & txtOMID.Text & "]"
                LoadData(txtOMID.Text)
                txtOMID.Enabled = False
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Case Else
                Exit Select
        End Select

    End Sub
    '查權限
    Sub PowerUser()
        'Dim pmws As New PermissionModuleWarrantSubController
        'Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "860305")
        'If pmwiL.Count > 0 Then
        'Else
        '    Exit Sub
        'End If
        'Dim StrAarray As Array = Split(pmwiL.Item(0).PMWS_Value, ",")
        'If UBound(StrAarray) > 1 Then
        '    MsgBox("權限重複,請通知電腦部重新設置!")
        '    Exit Sub
        'End If
        'Select Case pmwiL.Item(0).PMWS_Value
        '    Case "統計"
        '        GridView1.Columns("PM_CheckPrice").OptionsColumn.AllowEdit = False
        '        GridView1.Columns("PM_CheckFactor").OptionsColumn.AllowEdit = False
        '        GridView1.Columns("PM_Enable").OptionsColumn.AllowEdit = False

        '        GridView1.Columns("PM_Name").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_DepNO").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_Price").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_Explain").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_Factor").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_Type").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_DayNight").OptionsColumn.AllowEdit = True
        '    Case "生產部"
        '        GridView1.Columns("PM_CheckPrice").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_CheckFactor").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_Enable").OptionsColumn.AllowEdit = True

        '        GridView1.Columns("PM_Name").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_DepNO").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_Price").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_Explain").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_Factor").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_Type").OptionsColumn.AllowEdit = True
        '        GridView1.Columns("PM_DayNight").OptionsColumn.AllowEdit = True
        'Case "管理"

        'GridView1.Columns("PM_CheckPrice").OptionsColumn.AllowEdit = True
        'GridView1.Columns("PM_CheckFactor").OptionsColumn.AllowEdit = True
        'GridView1.Columns("PM_Enable").OptionsColumn.AllowEdit = True

        'GridView1.Columns("PM_Name").OptionsColumn.AllowEdit = False
        'GridView1.Columns("PM_DepNO").OptionsColumn.AllowEdit = False
        'GridView1.Columns("PM_Price").OptionsColumn.AllowEdit = False
        'GridView1.Columns("PM_Explain").OptionsColumn.AllowEdit = False
        'GridView1.Columns("PM_Factor").OptionsColumn.AllowEdit = False
        'GridView1.Columns("PM_Type").OptionsColumn.AllowEdit = False
        'GridView1.Columns("PM_DayNight").OptionsColumn.AllowEdit = False
        'End Select
    End Sub
    Private Sub LoadData(ByVal Str As String)
        Dim pc As New PieceProcessMoSubControl
        Dim piL As New List(Of PieceProcessMoSubInfo)

        piL = pc.PieceProcessMo_GetList(Str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        txtOMID.Text = piL(0).PM_NO()
        TextEdit1.Text = piL(0).PM_M_Code
        TextEdit2.Text = piL(0).Pro_Type
        TextEdit3.Text = piL(0).Type3ID
        MemoEdit1.Text = piL(0).PM_Remark

        CheckEdit1.Checked = piL(0).PM_Check
        CheckDate.Text = piL(0).PM_CheckDate
        CheckAction.Text = piL(0).PM_CheckAction
        CheckRemark.Text = piL(0).PM_CheckRemark

        LoadSubData(pc.PieceProcessMoSub_GetList(txtOMID.Text, Nothing, Nothing))

    End Sub
    Private Function LoadSubData(ByVal PsL As List(Of PieceProcessMoSubInfo)) As Boolean

        If PsL.Count = 0 Then Exit Function

        Dim row As DataRow
        Dim plc As New LFERP.Library.PieceProcess.PersonnelControl
        Dim pliL As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)
        Dim pliL2 As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)
        Dim pliL3 As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)
        Dim pliL4 As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)

        'Dim pmws As New PermissionModuleWarrantSubController
        'Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)
        Dim puc As New LFERP.DataSetting.UserPowerControl
        Dim puiL As New List(Of LFERP.DataSetting.UserPowerInfo)

        Dim ppc As New LFERP.Library.ProductProcess.ProcessMainControl
        Dim pciL As New List(Of LFERP.Library.ProductProcess.ProcessMainInfo)
        pciL = ppc.ProcessMain_GetList(Nothing, TextEdit1.Text, TextEdit2.Text, TextEdit3.Text, Nothing, Nothing)


        For i As Integer = 0 To pciL.Count - 1
            row = ds.Tables("ProcessSub").NewRow
            row("工序序號") = pciL(i).PS_Num
            row("工序名稱") = pciL(i).PS_Name
            row("工序編碼") = pciL(i).PS_NO
            ds.Tables("ProcessSub").Rows.Add(row)
        Next

        puiL = puc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)
        'pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "860305")
        pliL = plc.DepFacUser_GetList(Nothing, Nothing, Nothing, Nothing, InUserID, Nothing, Nothing)

        pliL2 = plc.DepFac_GetList(pliL(0).DepID, Nothing, Nothing, Nothing)
        pliL3 = plc.DepFac_GetList(Nothing, Nothing, pliL(0).FacID, Nothing)
        pliL4 = plc.DepFac_GetList(Nothing, Nothing, Nothing, Nothing)
        'MsgBox(puiL.Item(0).UserRank)

        If puiL.Count > 0 Then

            Select Case puiL.Item(0).UserRank

                Case "統計"

                    For i As Integer = 0 To pliL2.Count - 1
                        row = ds.Tables("FacBriSearch").NewRow
                        row("部門編號") = pliL2(i).DepID
                        row("部門名稱") = pliL2(i).DepName
                        row("廠別名稱") = pliL2(i).FacName
                        ds.Tables("FacBriSearch").Rows.Add(row)
                    Next

                Case "生產部"
                    For i As Integer = 0 To pliL3.Count - 1
                        row = ds.Tables("FacBriSearch").NewRow
                        row("部門編號") = pliL3(i).DepID
                        row("部門名稱") = pliL3(i).DepName
                        row("廠別名稱") = pliL3(i).FacName
                        ds.Tables("FacBriSearch").Rows.Add(row)
                    Next

                Case "管理"

                    For i As Integer = 0 To pliL4.Count - 1

                        row = ds.Tables("FacBriSearch").NewRow
                        row("部門編號") = pliL4(i).DepID
                        row("部門名稱") = pliL4(i).DepName
                        row("廠別名稱") = pliL4(i).FacName
                        ds.Tables("FacBriSearch").Rows.Add(row)
                    Next

            End Select
        Else
            MsgBox("此工號尚未分配權限", , "提示")
            Exit Function
        End If

        For i As Integer = 0 To PsL.Count - 1

            row = ds.Tables("PieceProcessMainSub").NewRow

            row("PM_Num") = PsL(i).PM_Num
            row("PS_Num") = PsL(i).PS_Num
            row("PS_NO") = PsL(i).PS_NO
            row("PM_Name") = PsL(i).PM_Name
            row("PM_DepNO") = PsL(i).PM_DepNO
            row("PM_DepName") = PsL(i).PM_DepName
            row("PM_Price") = PsL(i).PM_Price
            row("PM_Explain") = PsL(i).PM_Explain
            row("PM_CheckPrice") = PsL(i).PM_CheckPrice
            row("PM_Factor") = PsL(i).PM_Factor
            row("PM_CheckFactor") = PsL(i).PM_CheckFactor
            row("PM_Type") = PsL(i).PM_Type
            row("PM_DayNight") = PsL(i).PM_DayNight
            row("PM_Enable") = PsL(i).PM_Enable

            ds.Tables("PieceProcessMainSub").Rows.Add(row)
        Next

    End Function
    Private Sub CreateTable()

        With ds.Tables.Add("PieceProcessMainSub") '子表

            .Columns.Add("PM_Num", GetType(String))
            .Columns.Add("PS_Num", GetType(String))
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PM_Name", GetType(String))
            .Columns.Add("PM_DepNO", GetType(String))
            .Columns.Add("PM_DepName", GetType(String))
            .Columns.Add("PM_Price", GetType(String))
            .Columns.Add("PM_Explain", GetType(String))
            .Columns.Add("PM_CheckPrice", GetType(Boolean))
            .Columns.Add("PM_Factor", GetType(String))
            .Columns.Add("PM_CheckFactor", GetType(Boolean))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("PM_DayNight", GetType(String))
            .Columns.Add("PM_Enable", GetType(Boolean))

        End With
        '創建刪除數據表
        With ds.Tables.Add("DelData")
            .Columns.Add("PM_Num", GetType(String))
        End With
        With ds.Tables.Add("FacBriSearch")      '部門廠別表
            .Columns.Add("部門編號", GetType(String))
            .Columns.Add("部門名稱", GetType(String))
            .Columns.Add("廠別名稱", GetType(String))
        End With
        With ds.Tables.Add("ProcessSub")      '部門廠別表
            .Columns.Add("工序序號", GetType(String))
            .Columns.Add("工序名稱", GetType(String))
            .Columns.Add("工序編碼", GetType(String))
        End With
        '綁定表格
        Grid.DataSource = ds.Tables("PieceProcessMainSub")

        Me.RepositoryItemGridLookUpEdit1.DataSource = ds.Tables("FacBriSearch")
        Me.RepositoryItemGridLookUpEdit1.DisplayMember = "部門名稱"
        Me.RepositoryItemGridLookUpEdit1.ValueMember = "部門編號"

        Me.RepositoryItemGridLookUpEdit2.DataSource = ds.Tables("ProcessSub")
        Me.RepositoryItemGridLookUpEdit2.DisplayMember = "工序名稱"
        Me.RepositoryItemGridLookUpEdit2.ValueMember = "工序編碼"
        Me.RepositoryItemGridLookUpEdit2.View.Columns("工序編碼").Visible = False
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Select Case Label24.Text

            Case "計件工藝流程單"
                If Edit = True Then
                    PowerUser()
                    SaveEdit()
                End If

            Case "審核"
                UpdateCheck()
            Case Else
                Exit Select
        End Select
    End Sub
    Private Function CheckData() As Boolean
        CheckData = True
    End Function
    Private Sub SaveEdit()
        Dim pc As New PieceProcessMoSubControl
        Dim pi As New PieceProcessMoSubInfo

        If CheckData() = False Then
            Exit Sub
        End If
        pi.PM_NO = txtOMID.Text
        pi.PM_M_Code = TextEdit1.Text
        pi.Pro_M_NO = TextEdit2.Text
        pi.Pro_NO = TextEdit3.Text
        pi.PM_Remark = MemoEdit1.Text
        pi.PM_Action = InUserID

        If pc.PieceProcessMo_Update(pi) = False Then
            MsgBox("主表保存失敗!")
            Exit Sub
        End If

        If ds.Tables("DelData").Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables("DelData").Rows.Count - 1
                pc.PieceProcessMoSub_Del(txtOMID.Text, CStr(ds.Tables("DelData").Rows(i)("PM_Num")))
            Next
        End If

        For i As Integer = 0 To ds.Tables("PieceProcessMainSub").Rows.Count - 1

            If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Num")) Then
                pi.PM_Num = GetNum()    '流水號

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PS_NO")) Then
                    pi.PS_NO = Nothing
                Else
                    pi.PS_NO = ds.Tables("PieceProcessMainSub").Rows(i)("PS_NO")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PS_Num")) Then
                    pi.PS_Num = Nothing
                Else
                    pi.PS_Num = ds.Tables("PieceProcessMainSub").Rows(i)("PS_Num")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_DepNO")) Then
                    pi.PM_DepNO = Nothing
                Else
                    pi.PM_DepNO = ds.Tables("PieceProcessMainSub").Rows(i)("PM_DepNO")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_DepName")) Then
                    pi.PM_DepName = Nothing
                Else
                    pi.PM_DepName = ds.Tables("PieceProcessMainSub").Rows(i)("PM_DepName")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Name")) Then
                    pi.PM_Name = Nothing
                Else
                    pi.PM_Name = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Name")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Price")) Then
                    pi.PM_Price = Nothing
                Else
                    pi.PM_Price = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Price")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Explain")) Then
                    pi.PM_Explain = Nothing
                Else
                    pi.PM_Explain = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Explain")
                End If
                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_CheckPrice")) Then
                    pi.PM_CheckPrice = Nothing
                Else
                    pi.PM_CheckPrice = ds.Tables("PieceProcessMainSub").Rows(i)("PM_CheckPrice")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Factor")) Then
                    pi.PM_Factor = Nothing
                Else
                    pi.PM_Factor = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Factor")
                End If
                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_CheckFactor")) Then
                    pi.PM_CheckFactor = False
                Else
                    pi.PM_CheckFactor = ds.Tables("PieceProcessMainSub").Rows(i)("PM_CheckFactor")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Type")) Then
                    pi.PM_Type = Nothing
                Else
                    pi.PM_Type = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Type")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_DayNight")) Then
                    pi.PM_DayNight = Nothing
                Else
                    pi.PM_DayNight = ds.Tables("PieceProcessMainSub").Rows(i)("PM_DayNight")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Enable")) Then
                    pi.PM_Enable = False
                Else
                    pi.PM_Enable = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Enable")
                End If
                If pc.PieceProcessMoSub_Add(pi) = False Then
                    MsgBox("子表保存失敗!")
                    Exit Sub
                End If
            Else


                pi.PM_Num = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Num")

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PS_NO")) Then
                    pi.PS_NO = Nothing
                Else
                    pi.PS_NO = ds.Tables("PieceProcessMainSub").Rows(i)("PS_NO")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PS_Num")) Then
                    pi.PS_Num = Nothing
                Else
                    pi.PS_Num = ds.Tables("PieceProcessMainSub").Rows(i)("PS_Num")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_DepNO")) Then
                    pi.PM_DepNO = Nothing
                Else
                    pi.PM_DepNO = ds.Tables("PieceProcessMainSub").Rows(i)("PM_DepNO")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_DepName")) Then
                    pi.PM_DepName = Nothing
                Else
                    pi.PM_DepName = ds.Tables("PieceProcessMainSub").Rows(i)("PM_DepName")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Name")) Then
                    pi.PM_Name = Nothing
                Else
                    pi.PM_Name = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Name")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Price")) Then
                    pi.PM_Price = Nothing
                Else
                    pi.PM_Price = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Price")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Explain")) Then
                    pi.PM_Explain = Nothing
                Else
                    pi.PM_Explain = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Explain")

                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_CheckPrice")) Then
                    pi.PM_CheckPrice = False
                Else
                    pi.PM_CheckPrice = ds.Tables("PieceProcessMainSub").Rows(i)("PM_CheckPrice")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Factor")) Then
                    pi.PM_Factor = Nothing
                Else
                    pi.PM_Factor = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Factor")
                End If
                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_CheckFactor")) Then
                    pi.PM_CheckFactor = False
                Else
                    pi.PM_CheckFactor = ds.Tables("PieceProcessMainSub").Rows(i)("PM_CheckFactor")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Type")) Then
                    pi.PM_Type = Nothing
                Else
                    pi.PM_Type = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Type")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_DayNight")) Then
                    pi.PM_DayNight = Nothing
                Else
                    pi.PM_DayNight = ds.Tables("PieceProcessMainSub").Rows(i)("PM_DayNight")
                End If

                If IsDBNull(ds.Tables("PieceProcessMainSub").Rows(i)("PM_Enable")) Then
                    pi.PM_Enable = False
                Else
                    pi.PM_Enable = ds.Tables("PieceProcessMainSub").Rows(i)("PM_Enable")
                End If

                If pc.PieceProcessMoSub_Update(pi) = False Then
                    MsgBox("子表保存失敗!")
                    Exit Sub
                End If
            End If

        Next

        Me.Close()
    End Sub
    Private Sub UpdateCheck()
        Dim pc As New PieceProcessMoSubControl
        Dim pi As New PieceProcessMoSubInfo

        pi.PM_NO = txtOMID.Text
        pi.PM_Check = CheckEdit1.Checked
        pi.PM_CheckAction = InUserID
        pi.PM_CheckDate = Format(Now, "yyyy/MM/dd")
        pi.PM_CheckRemark = CheckRemark.Text

        If pc.PieceProcessMo_UpdateCheck(pi) Then
            MsgBox("審核成功!")
        Else
            MsgBox("審核失敗!")
        End If
        Me.Close()
    End Sub
    
    Private Function GetNum() As String
        Dim pc As New PieceProcessMoSubControl
        Dim pi As New PieceProcessMoSubInfo
        pi = pc.PieceProcessMoSub_GetNum(txtOMID.Text)
        If pi Is Nothing Then
            GetNum = Trim(txtOMID.Text) & "-" & "01"
        Else
            GetNum = Trim(txtOMID.Text) & "-" & CStr(Microsoft.VisualBasic.Right(CInt(Microsoft.VisualBasic.Right(pi.PM_Num, 2)) + 101, 2))
        End If

    End Function
   

    Private Sub pupPDProductDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pupPDProductDel.Click
        If ds.Tables("PieceProcessMainSub").Rows.Count = 0 Then Exit Sub
        Dim row As DataRow = ds.Tables("DelData").NewRow
        row("PM_Num") = ds.Tables("PieceProcessMainSub").Rows(GridView1.FocusedRowHandle)("PM_Num")
        ds.Tables("DelData").Rows.Add(row)

        ds.Tables("PieceProcessMainSub").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub


    Private Sub RepositoryItemGridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemGridLookUpEdit1.EditValueChanged
        Dim plc As New LFERP.Library.PieceProcess.PersonnelControl
        Dim pliL As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)
        Dim Re As New DevExpress.XtraEditors.GridLookUpEdit
        Re = CType(sender, DevExpress.XtraEditors.GridLookUpEdit)
        pliL = plc.DepFac_GetList(Re.EditValue, Nothing, Nothing, Nothing)
        ds.Tables("PieceProcessMainSub").Rows(GridView1.FocusedRowHandle)("PM_DepNO") = pliL(0).DepName
        ds.Tables("PieceProcessMainSub").Rows(GridView1.FocusedRowHandle)("PM_DepName") = pliL(0).FacName
    End Sub

    Private Sub RepositoryItemGridLookUpEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemGridLookUpEdit2.EditValueChanged
       
        Dim ppc As New LFERP.Library.ProductProcess.ProcessMainControl
        Dim pciL As New List(Of LFERP.Library.ProductProcess.ProcessMainInfo)
        Dim Re As New DevExpress.XtraEditors.GridLookUpEdit
        Re = CType(sender, DevExpress.XtraEditors.GridLookUpEdit)
        pciL = ppc.ProcessSub_GetList(Nothing, Re.EditValue, Nothing, Nothing, Nothing, Nothing)
        ds.Tables("PieceProcessMainSub").Rows(GridView1.FocusedRowHandle)("PM_Name") = pciL(0).PS_Name
    End Sub
End Class
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.ProductionPieceProcess
Imports LFERP.DataSetting
Imports LFERP.Library.Production.Datasetting

Public Class frmProductionPieceProcess
    Dim ds As New DataSet
    Dim ppc As New ProductionPieceProcessControl
    Dim fc As New FacControler
    Dim isSameRow As Boolean '判斷是否有相同的記錄行

    Dim StrPM_M_Code As String
    Dim StrPM_Type As String
    Dim StrPro_Type As String

    Private Sub frmProductionPieceProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RepositoryItemCalcEdit1.DisplayFormat.FormatString = "###0.0#####"
        RepositoryItemCalcEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        RepositoryItemCalcEdit1.Mask.EditMask = "###0.0#####"
        RepositoryItemCalcEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        RepositoryItemCalcEdit1.Mask.UseMaskAsDisplayFormat = True


        StrPro_Type = tempValue
        StrPM_M_Code = tempValue2
        StrPM_Type = tempValue3


        'Dim mc As New ProductController
        Dim pdsi As List(Of ProductionDataSettingInfo)
        Dim pdsc As New ProductionDataSettingControl
        Dim pc As New ProcessMainControl

        CreateTable()   '調用創建表過程

        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = pc.ProcessMain_GetList3(Nothing, Nothing)

        If strInUserRank = "統計" Then
            pdsi = pdsc.ProductionUser_GetList(strInDepIDFull, Nothing)
            If pdsi.Count > 0 Then
                gluPM_M_Code.Properties.DataSource = pdsc.ProductionUser_GetList(strInDepIDFull, Nothing)
            End If
        End If

        Select Case lblTittle.Text
            Case "計件工藝單--新增"
                txtPP_ActionUser.Text = UserName
                dtePP_ActionDate.DateTime = Format(Now, "yyyy/MM/dd")
                txtPP_ID.Text = GetID()

                PP_PriceCheck.Visible = False
                PP_FactorCheck.Visible = False

            Case "計件工藝單--修改"
                LoadData()      '調用加載數據過程
                cboPro_Type.Enabled = False
                gluPM_M_Code.Enabled = False
                gluPM_Type.Enabled = False

                PP_PriceCheck.Visible = False
                PP_FactorCheck.Visible = False
            Case "計件工藝單--審核"
                LoadData()      '調用加載數據過程
                GroupBox1.Enabled = False
                cboPro_Type.Properties.ReadOnly = True
                gluPM_M_Code.Properties.ReadOnly = True
                gluPM_Type.Properties.ReadOnly = True
                txtPP_ActionUser.Properties.ReadOnly = True
                dtePP_ActionDate.Properties.ReadOnly = True
                txtPP_Remark.Properties.ReadOnly = True
                PP_N_Name.OptionsColumn.ReadOnly = True
                DPT_PName.OptionsColumn.ReadOnly = True
                DPT_Name.OptionsColumn.ReadOnly = True
                PP_Price.OptionsColumn.ReadOnly = True
                PP_Factor.OptionsColumn.ReadOnly = True
                PP_Type.OptionsColumn.ReadOnly = True
                PP_Explain.OptionsColumn.ReadOnly = True
                PP_BeginUseDate.OptionsColumn.ReadOnly = True
                PP_EndUseDate.OptionsColumn.ReadOnly = True
                PP_BeginUse.OptionsColumn.ReadOnly = False
                chkPP_Check.Enabled = True
                btnAllUse.Enabled = True
                lblPP_CheckUserName.Visible = True
                lblPP_CheckDate.Visible = True
                lblCheckName.Visible = True
                lblCheckDate.Visible = True
                lblPP_CheckUserName.Text = UserName
                lblPP_CheckDate.Text = Format(Now, "yyyy/MM/dd")
                btnAllUse.Visible = True
                chkPP_Check.Visible = True
                PP_BeginUse.Visible = True
                Grid.ContextMenuStrip.Enabled = False
                btnOK.Enabled = False

                PP_PriceCheck.Visible = False
                PP_FactorCheck.Visible = False

                PP_Price.OptionsColumn.ReadOnly = True
                PP_Factor.OptionsColumn.ReadOnly = True


            Case "計件工藝單--查看"
                LoadData()      '調用加載數據過程
                btnOK.Visible = False
                btnAllUse.Visible = True
                chkPP_Check.Visible = True
                PP_BeginUse.Visible = True
                Grid.ContextMenuStrip.Enabled = False

                cboPro_Type.Enabled = False

            Case "計件工藝單--單價錄入"
                LoadData()      '調用加載數據過程
                cboPro_Type.Properties.ReadOnly = True
                gluPM_M_Code.Properties.ReadOnly = True
                gluPM_Type.Properties.ReadOnly = True
                txtPP_ActionUser.Properties.ReadOnly = True
                dtePP_ActionDate.Properties.ReadOnly = True
                txtPP_Remark.Properties.ReadOnly = True
                PP_N_Name.OptionsColumn.ReadOnly = True
                DPT_PName.OptionsColumn.ReadOnly = True
                DPT_Name.OptionsColumn.ReadOnly = True

                PP_Type.OptionsColumn.ReadOnly = True
                PP_Explain.OptionsColumn.ReadOnly = True
                PP_BeginUseDate.OptionsColumn.ReadOnly = True
                PP_EndUseDate.OptionsColumn.ReadOnly = True
                PP_BeginUse.OptionsColumn.ReadOnly = True
                chkPP_Check.Enabled = True
                btnAllUse.Enabled = True
                lblPP_CheckUserName.Visible = True
                lblPP_CheckDate.Visible = True
                lblCheckName.Visible = True
                lblCheckDate.Visible = True
                btnAllUse.Visible = True
                chkPP_Check.Visible = True
                PP_BeginUse.Visible = True
                Grid.ContextMenuStrip.Enabled = False

                PP_Price.OptionsColumn.ReadOnly = False
                PP_Factor.OptionsColumn.ReadOnly = False

                PP_PriceCheck.OptionsColumn.ReadOnly = True
                PP_FactorCheck.OptionsColumn.ReadOnly = True

                btnOK.Enabled = True

                btnAllUse.Visible = False
                chkPP_Check.Visible = False
                Panel1.Visible = False

            Case "計件工藝單--單價審核"
                LoadData()      '調用加載數據過程
                cboPro_Type.Properties.ReadOnly = True
                gluPM_M_Code.Properties.ReadOnly = True
                gluPM_Type.Properties.ReadOnly = True
                txtPP_ActionUser.Properties.ReadOnly = True
                dtePP_ActionDate.Properties.ReadOnly = True
                txtPP_Remark.Properties.ReadOnly = True
                PP_N_Name.OptionsColumn.ReadOnly = True
                DPT_PName.OptionsColumn.ReadOnly = True
                DPT_Name.OptionsColumn.ReadOnly = True

                PP_Type.OptionsColumn.ReadOnly = True
                PP_Explain.OptionsColumn.ReadOnly = True
                PP_BeginUseDate.OptionsColumn.ReadOnly = True
                PP_EndUseDate.OptionsColumn.ReadOnly = True
                PP_BeginUse.OptionsColumn.ReadOnly = True
                chkPP_Check.Enabled = True
                btnAllUse.Enabled = True
                lblPP_CheckUserName.Visible = True
                lblPP_CheckDate.Visible = True
                lblCheckName.Visible = True
                lblCheckDate.Visible = True
                btnAllUse.Visible = True
                chkPP_Check.Visible = True
                PP_BeginUse.Visible = True
                Grid.ContextMenuStrip.Enabled = False

                PP_Price.OptionsColumn.ReadOnly = True
                PP_Factor.OptionsColumn.ReadOnly = True

                PP_PriceCheck.OptionsColumn.ReadOnly = False
                PP_FactorCheck.OptionsColumn.ReadOnly = False

                LabelControl9.Visible = True
                LabPP_PriceCheckUserID.Visible = True
                LabelControl7.Visible = True
                LabPP_PriceCheckDate.Visible = True


                btnAllUse.Visible = False
                chkPP_Check.Visible = False
                Panel1.Visible = False
            Case "計件工藝單--錄入"  '2013-3-19


                LoadData()      '調用加載數據過程
                cboPro_Type.Properties.ReadOnly = True
                gluPM_M_Code.Properties.ReadOnly = True
                gluPM_Type.Properties.ReadOnly = True
                txtPP_ActionUser.Properties.ReadOnly = True
                dtePP_ActionDate.Properties.ReadOnly = True
                txtPP_Remark.Properties.ReadOnly = True
                PP_PriceCheck.Visible = False
                PP_FactorCheck.Visible = False

                btnAllUse.Visible = False
                chkPP_Check.Visible = False
                Panel1.Visible = False
        End Select

        LoadPS_NO()


    End Sub
    ''' <summary>
    ''' 創建表
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTable()
        ds.Tables.Clear()

        '計件工藝表
        With ds.Tables.Add("PieceProcess")
            .Columns.Add("AutoID", GetType(Integer))
            .Columns.Add("PP_Num", GetType(Integer))
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
            .Columns.Add("PP_N_Name", GetType(String))

            .Columns.Add("DPT_PName", GetType(String))
            .Columns.Add("DPT_ID", GetType(String))
            .Columns.Add("DPT_Name", GetType(String))
            .Columns.Add("PP_Price", GetType(Single))
            .Columns.Add("PP_Factor", GetType(Single))

            .Columns.Add("PP_Type", GetType(String))
            .Columns.Add("PP_Explain", GetType(String))
            .Columns.Add("PP_BeginUseDate", GetType(Date))
            .Columns.Add("PP_EndUseDate", GetType(Date))
            .Columns.Add("RemnantDays", GetType(Integer))

            .Columns.Add("PP_BeginUse", GetType(Boolean))


            .Columns.Add("PP_PriceCheck", GetType(Boolean))
            .Columns.Add("PP_FactorCheck", GetType(Boolean))

        End With

        Grid.DataSource = ds.Tables("PieceProcess")

        '配件名稱表
        With ds.Tables.Add("ProductType")
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluPM_Type.Properties.DisplayMember = "PM_Type"
        gluPM_Type.Properties.ValueMember = "PM_Type"
        gluPM_Type.Properties.DataSource = ds.Tables("ProductType")

        '創建刪除信息表，用於修改時刪除數據用
        With ds.Tables.Add("DelPieceProcess")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("PP_ID", GetType(String))
        End With

    End Sub

    ''' <summary>
    ''' 自動計件工藝單號
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    ''' AddData()
    ''' frmProductionPieceProcess_Load()
    Function GetID() As String
        Dim str As String

        str = "PP" & CStr(Format(Now, "yyMM"))

        Dim ppi As List(Of ProductionPieceProcessInfo)
        ppi = ppc.ProductionPieceProcess_GetList(Nothing, str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If ppi.Count <= 0 Then
            GetID = str & "0001"
        Else
            GetID = str & Mid((CInt(Mid(ppi(0).PP_ID, 7)) + 10001), 2)
        End If
    End Function

    ''' <summary>
    ''' 加載數據
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' frmProductionPieceProcess_Load()
    Sub LoadData()
        'On Error Resume Next

        Dim ppi As New List(Of ProductionPieceProcessInfo)
        Dim ts As TimeSpan
        'Dim usc As New UserPowerControl
        'Dim usi As List(Of UserPowerInfo)

        'usi = usc.UserPower_GetList(InUserID, Nothing, Nothing, Nothing)

        If Me.lblTittle.Text = "計件工藝單--錄入" Then
            ppi = ppc.ProductionPieceProcess_GetList(Nothing, Nothing, StrPro_Type, StrPM_M_Code, StrPM_Type, Nothing, Nothing, strInDepID, True, Nothing, Nothing, Nothing)
        Else
            ppi = ppc.ProductionPieceProcess_GetList(Nothing, txtPP_ID.Text.Trim, Nothing, Nothing, Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing)
        End If


        If ppi.Count > 0 Then
            txtPP_ID.Text = ppi(0).PP_ID ''讀取流水號

            cboPro_Type.Text = ppi(0).Pro_Type
            gluPM_M_Code.EditValue = ppi(0).PM_M_Code
            gluPM_Type.Text = ppi(0).PM_Type
            txtPP_ActionUser.Text = ppi(0).PP_ActionUser
            dtePP_ActionDate.EditValue = ppi(0).PP_ActionDate

            txtPP_Remark.Text = ppi(0).PP_Remark
            chkPP_Check.EditValue = ppi(0).PP_Check

            Me.LabPP_PriceCheckDate.Text = ppi(0).PP_PriceCheckDate
            Me.LabPP_PriceCheckUserID.Text = ppi(0).PP_PriceCheckUserName

            Me.LabelCheckID.Text = ppi(0).PP_CheckUserID
            Me.lblPP_CheckDate.Text = ppi(0).PP_CheckDate

            If ppi(0).PP_Check = True Then
                btnAllUse.Text = "全部不啟用(&A)"
                lblPP_CheckUserName.Visible = True
                lblPP_CheckDate.Visible = True
                lblCheckName.Visible = True
                lblCheckDate.Visible = True
                lblPP_CheckUserName.Text = ppi(0).PP_CheckUserName
                lblPP_CheckDate.Text = ppi(0).PP_CheckDate
            End If
            Dim row As DataRow
            Dim i%

            ds.Tables("PieceProcess").Clear()
            For i = 0 To ppi.Count - 1
                row = ds.Tables("PieceProcess").NewRow()

                row("AutoID") = ppi(i).AutoID
                row("PP_Num") = ppi(i).PP_Num
                row("PS_NO") = ppi(i).PS_NO
                row("PS_Name") = ppi(i).PS_Name
                row("PP_N_Name") = ppi(i).PP_N_Name

                '加載廠別名稱
                RepositoryItemLookUpEdit1.DisplayMember = "FacName"
                RepositoryItemLookUpEdit1.ValueMember = "FacID"
                RepositoryItemLookUpEdit1.DataSource = fc.GetFacList(strInFacID, Nothing)

                row("DPT_PName") = Mid(ppi(i).DPT_ID, 1, 1)
                row("DPT_ID") = ppi(i).DPT_ID
                row("DPT_Name") = ppi(i).DPT_Name
                row("PP_Price") = ppi(i).PP_Price
                row("PP_Factor") = ppi(i).PP_Factor

                row("PP_Type") = ppi(i).PP_Type
                row("PP_Explain") = ppi(i).PP_Explain
                row("PP_BeginUseDate") = ppi(i).PP_BeginUseDate
                row("PP_EndUseDate") = ppi(i).PP_EndUseDate


                row("PP_PriceCheck") = ppi(i).PP_PriceCheck
                row("PP_FactorCheck") = ppi(i).PP_FactorCheck

                '計算剩余天數
                If Now > ppi(i).PP_BeginUseDate Then    '判斷當前日期是否大於啟用日期
                    ts = ppi(i).PP_EndUseDate - CDate(Format(Now, "yyyy/MM/dd"))    '剩余天數為結束日期減去當前日期
                Else
                    ts = ppi(i).PP_EndUseDate - ppi(i).PP_BeginUseDate              '剩余天數為結束日期減去啟用日期
                End If

                row("RemnantDays") = ts.Days + 1    '剩余天數包括兩端點日期，因此需加1
                row("PP_BeginUse") = ppi(i).PP_BeginUse

                ds.Tables("PieceProcess").Rows.Add(row)
            Next
        Else
            If Me.lblTittle.Text = "計件工藝單--錄入" Then
                Dim ppi1 As New List(Of ProductionPieceProcessInfo)

                ppi1 = ppc.ProductionPieceProcess_GetList(Nothing, Nothing, StrPro_Type, StrPM_M_Code, StrPM_Type, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing)

                If ppi1.Count > 0 Then
                    txtPP_ID.Text = ppi1(0).PP_ID ''讀取流水號

                    cboPro_Type.Text = ppi1(0).Pro_Type
                    gluPM_M_Code.EditValue = ppi1(0).PM_M_Code
                    gluPM_Type.Text = ppi1(0).PM_Type
                    txtPP_ActionUser.Text = ppi1(0).PP_ActionUser
                    dtePP_ActionDate.EditValue = ppi1(0).PP_ActionDate

                    txtPP_Remark.Text = ppi1(0).PP_Remark
                    chkPP_Check.EditValue = ppi1(0).PP_Check

                    Me.LabPP_PriceCheckDate.Text = ppi1(0).PP_PriceCheckDate
                    Me.LabPP_PriceCheckUserID.Text = ppi1(0).PP_PriceCheckUserName

                    Me.LabelCheckID.Text = ppi1(0).PP_CheckUserID
                    Me.lblPP_CheckDate.Text = ppi1(0).PP_CheckDate
                Else
                    MsgBox("此產品,無已審核的工藝！")
                    Me.Close()
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' 保存添加數據
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    ''' btnOK_Click()
    Function AddData() As Boolean
        Dim ppi As New ProductionPieceProcessInfo
        Dim i%

        Dim pi As List(Of ProductionPieceProcessInfo)
        pi = ppc.ProductionPieceProcess_GetList(Nothing, txtPP_ID.Text.Trim, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        '判斷計件工藝單號是否已存在
        If pi.Count > 0 Then
            MsgBox("計件工藝單號已存在，需重新生成，請確定重新生成計件工藝單號!", 64, "提示")
            txtPP_ID.Text = GetID()     '重新生成計件工藝單號
            MsgBox("計件工藝單號已重新生成，請確定保存信息!", 64, "提示")
        End If

        ppi.PP_ID = txtPP_ID.Text
        ppi.Pro_Type = cboPro_Type.Text
        ppi.PM_M_Code = gluPM_M_Code.EditValue
        ppi.PM_Type = gluPM_Type.Text
        ppi.PP_ActionUser = txtPP_ActionUser.Text

        ppi.PP_ActionDate = dtePP_ActionDate.EditValue
        ppi.PP_Remark = txtPP_Remark.Text

        For i = 0 To ds.Tables("PieceProcess").Rows.Count - 1
            ppi.PP_Num = ds.Tables("PieceProcess").Rows(i)("PP_Num")
            ppi.PS_NO = ds.Tables("PieceProcess").Rows(i)("PS_NO")
            ppi.PP_N_Name = ds.Tables("PieceProcess").Rows(i)("PP_N_Name")
            ppi.DPT_ID = ds.Tables("PieceProcess").Rows(i)("DPT_ID")
            ppi.PP_Price = ds.Tables("PieceProcess").Rows(i)("PP_Price")

            ppi.PP_Factor = ds.Tables("PieceProcess").Rows(i)("PP_Factor")
            ppi.PP_Explain = ds.Tables("PieceProcess").Rows(i)("PP_Explain")
            ppi.PP_Type = ds.Tables("PieceProcess").Rows(i)("PP_Type")
            ppi.PP_BeginUseDate = ds.Tables("PieceProcess").Rows(i)("PP_BeginUseDate")
            ppi.PP_EndUseDate = ds.Tables("PieceProcess").Rows(i)("PP_EndUseDate")

            ppi.AddUserID = InUserID
            ppi.AddDate = Format(Now, "yyyy/MM/dd")

            Try
                If ppc.ProductionPieceProcess_Add(ppi) = True Then
                    AddData = True
                End If
            Catch ex As Exception
                If MsgBox("次序為：" & ds.Tables("PieceProcess").Rows(i)("PP_Num") & " 記錄添加失敗,是否要繼續添加其後的記錄？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.No Then
                    AddData = False
                    Exit Function
                End If
            End Try
        Next
    End Function
    ''' <summary>
    ''' 保存修改數據
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    ''' btnOK_Click()
    Function EditData() As Boolean
        Dim ppi As New ProductionPieceProcessInfo
        Dim i, j As Integer

        '判斷刪除表中是否有需要刪除的信息，有則刪除數據庫中相應信息
        If ds.Tables("DelPieceProcess").Rows.Count > 0 Then
            For j = 0 To ds.Tables("DelPieceProcess").Rows.Count - 1
                ppc.ProductionPieceProcess_Delete(ds.Tables("DelPieceProcess").Rows(i)("AutoID"), Nothing)
            Next
        End If

        ppi.PP_ID = txtPP_ID.Text
        ppi.Pro_Type = cboPro_Type.Text
        ppi.PM_M_Code = gluPM_M_Code.EditValue
        ppi.PM_Type = gluPM_Type.Text
        ppi.PP_ActionUser = txtPP_ActionUser.Text

        ppi.PP_ActionDate = dtePP_ActionDate.EditValue
        ppi.PP_Remark = txtPP_Remark.Text
        For i = 0 To ds.Tables("PieceProcess").Rows.Count - 1
            '判斷是否有新增數據,AutoID為空時，則有新增數據
            If ds.Tables("PieceProcess").Rows(i)("AutoID") Is DBNull.Value Then

                ppi.PP_Num = ds.Tables("PieceProcess").Rows(i)("PP_Num")
                ppi.PS_NO = ds.Tables("PieceProcess").Rows(i)("PS_NO")
                ppi.PP_N_Name = ds.Tables("PieceProcess").Rows(i)("PP_N_Name")
                ppi.DPT_ID = ds.Tables("PieceProcess").Rows(i)("DPT_ID")
                ppi.PP_Price = ds.Tables("PieceProcess").Rows(i)("PP_Price")

                ppi.PP_Factor = ds.Tables("PieceProcess").Rows(i)("PP_Factor")
                ppi.PP_Explain = ds.Tables("PieceProcess").Rows(i)("PP_Explain")
                ppi.PP_Type = ds.Tables("PieceProcess").Rows(i)("PP_Type")
                ppi.PP_BeginUseDate = ds.Tables("PieceProcess").Rows(i)("PP_BeginUseDate")
                ppi.PP_EndUseDate = ds.Tables("PieceProcess").Rows(i)("PP_EndUseDate")

                ppi.AddUserID = InUserID
                ppi.AddDate = Format(Now, "yyyy/MM/dd")

                If ppc.ProductionPieceProcess_Add(ppi) = True Then
                    EditData = True
                Else
                    If MsgBox("次序為：" & ds.Tables("PieceProcess").Rows(i)("PP_Num") & " 新增記錄添加失敗,是否要繼續保存其後的記錄？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.No Then
                        EditData = False
                        Exit Function
                    End If
                End If
            Else
                ppi.AutoID = ds.Tables("PieceProcess").Rows(i)("AutoID")
                ppi.PP_Num = ds.Tables("PieceProcess").Rows(i)("PP_Num")
                ppi.PS_NO = ds.Tables("PieceProcess").Rows(i)("PS_NO")
                ppi.PP_N_Name = ds.Tables("PieceProcess").Rows(i)("PP_N_Name")
                ppi.DPT_ID = ds.Tables("PieceProcess").Rows(i)("DPT_ID")

                ppi.PP_Price = ds.Tables("PieceProcess").Rows(i)("PP_Price")
                ppi.PP_Factor = ds.Tables("PieceProcess").Rows(i)("PP_Factor")
                ppi.PP_Explain = ds.Tables("PieceProcess").Rows(i)("PP_Explain")
                ppi.PP_Type = ds.Tables("PieceProcess").Rows(i)("PP_Type")
                ppi.PP_BeginUseDate = ds.Tables("PieceProcess").Rows(i)("PP_BeginUseDate")

                ppi.PP_EndUseDate = ds.Tables("PieceProcess").Rows(i)("PP_EndUseDate")
                ppi.ModifyUserID = InUserID
                ppi.ModifyDate = Format(Now, "yyyy/MM/dd")

                If ppc.ProductionPieceProcess_Update(ppi) = True Then
                    EditData = True
                Else
                    If MsgBox("次序為：" & ds.Tables("PieceProcess").Rows(i)("PP_Num") & " 記錄修改失敗,是否要繼續修改其後的記錄？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.No Then
                        EditData = False
                        Exit Function
                    End If
                End If
            End If
        Next
    End Function
    ''' <summary>
    ''' 產品編號值改變,在gluPM_Type中加載相應的配件名稱
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用:
    ''' cboPro_Type_SelectedIndexChanged()
    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        On Error Resume Next

        Dim pcc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)

        pci = pcc.ProcessMain_GetList1(Nothing, gluPM_M_Code.EditValue, cboPro_Type.Text, Nothing)

        If pci.Count = 0 Then
            ds.Tables("ProductType").Clear()
            ds.Tables("PieceProcess").Clear()
        Else
            ds.Tables("ProductType").Clear()
            Dim i As Integer
            For i = 0 To pci.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductType").NewRow
                row("M_Code") = pci(i).M_Code
                row("PM_Type") = pci(i).Type3ID

                ds.Tables("ProductType").Rows.Add(row)
            Next
            gluPM_Type.Text = ""
        End If
    End Sub
    ''' <summary>
    ''' 配件名稱改變時，加載相應數據到計件工藝表
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluPM_Type_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_Type.EditValueChanged
        If lblTittle.Text = "計件工藝單--新增" Then
            If cboPro_Type.Text.Trim = "" Or gluPM_M_Code.Text.Trim = "" Or gluPM_Type.Text.Trim = "" Then
                ds.Tables("PieceProcess").Clear()
            Else
                If ppc.ProductionPieceProcess_GetList(Nothing, Nothing, cboPro_Type.Text, gluPM_M_Code.EditValue, gluPM_Type.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count > 0 Then
                    MsgBox("該產品配件工序工價已存在！", 64, "提示")
                    Exit Sub
                End If

                LoadPS_NO()

                Dim pc As New ProcessMainControl
                Dim pci As List(Of ProcessMainInfo)
                pci = pc.ProcessMain_GetList(Nothing, gluPM_M_Code.EditValue, cboPro_Type.Text, gluPM_Type.EditValue, Nothing, Nothing)

                If pci.Count > 0 Then
                    ds.Tables("PieceProcess").Clear()
                    Dim i%
                    Dim ts As TimeSpan

                    For i = 0 To pci.Count - 1
                        Dim row As DataRow
                        row = ds.Tables("PieceProcess").NewRow()

                        row("PP_Num") = pci(i).PS_Num
                        row("PS_NO") = pci(i).PS_NO
                        row("PS_Name") = pci(i).PS_Name
                        row("PP_N_Name") = pci(i).PS_Name
                        row("PP_Price") = 0

                        row("PP_Factor") = 1
                        row("DPT_PName") = ""
                        row("DPT_ID") = ""
                        row("DPT_Name") = ""
                        row("PP_Explain") = ""

                        row("PP_Type") = RepositoryItemComboBox1.Items(0)
                        row("PP_BeginUseDate") = Format(Now, "yyyy/MM/dd")
                        row("PP_EndUseDate") = Date.Parse(Now.AddMonths(1).ToString("yyyy/MM") & "/01").AddDays(-1) '當前月的最後一天

                        ts = Date.Parse(Now.AddMonths(1).ToString("yyyy/MM") & "/01").AddDays(-1) - CDate(Format(Now, "yyyy/MM/dd"))
                        row("RemnantDays") = ts.Days + 1

                        '加載廠別名稱
                        RepositoryItemLookUpEdit1.DisplayMember = "FacName"
                        RepositoryItemLookUpEdit1.ValueMember = "FacID"
                        RepositoryItemLookUpEdit1.DataSource = fc.GetFacList(strInFacID, Nothing)

                        ds.Tables("PieceProcess").Rows.Add(row)
                    Next
                End If
            End If
        End If

    End Sub
    ''' <summary>
    ''' 單擊“取消”按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 部門名稱獲得焦點時，加載相應數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RepositoryItemPopupContainerEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemPopupContainerEdit1.Enter
        Dim dc As New DepartmentControler
        '當廠別名稱為空時，不加載數據
        If IsDBNull(GridView2.GetFocusedRowCellValue("DPT_PName")) Then
            Grid1.DataSource = Nothing
        Else
            ' Grid1.DataSource = dc.BriName_GetList(Nothing, Nothing, ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("DPT_PName"))
            If strInUserRank = "統計" Then
                Grid1.DataSource = dc.BriName_GetList(strInDepID, Nothing, ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("DPT_PName"))
            Else
                Grid1.DataSource = dc.BriName_GetList(Nothing, Nothing, ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("DPT_PName"))
            End If
        End If
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“新增”，複制最後一行，在最後新增一行數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAdd.Click

        Dim row As DataRow
        row = ds.Tables("PieceProcess").NewRow

        If GridView2.RowCount <= 0 And Me.lblTittle.Text = "計件工藝單--錄入" Then

            'Dim row As DataRow

            'row = ds.Tables("PieceProcess").NewRow

            row("PP_Num") = 1
            row("PS_NO") = Nothing
            row("PS_Name") = Nothing
            row("PP_N_Name") = Nothing
            row("PP_Price") = 0

            row("PP_Factor") = 1
            row("DPT_PName") = Nothing
            row("DPT_ID") = Nothing
            row("DPT_Name") = Nothing
            row("PP_Explain") = ""

            row("PP_Type") = "大貨"
            row("PP_BeginUseDate") = Format(Now, "yyyy/MM/dd")
            row("PP_EndUseDate") = Format(Now, "yyyy/MM/dd")
            row("RemnantDays") = 0

            row("PP_BeginUse") = True

            RepositoryItemLookUpEdit1.DisplayMember = "FacName"
            RepositoryItemLookUpEdit1.ValueMember = "FacID"
            RepositoryItemLookUpEdit1.DataSource = fc.GetFacList(strInFacID, Nothing)

            ds.Tables("PieceProcess").Rows.Add(row)
        Else
            'Dim row As DataRow

            'row = ds.Tables("PieceProcess").NewRow

            row("PP_Num") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("PP_Num") + 1
            row("PS_NO") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("PS_NO")
            row("PS_Name") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("PS_Name")
            row("PP_N_Name") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("PP_N_Name")
            row("PP_Price") = 0

            row("PP_Factor") = 1
            row("DPT_PName") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("DPT_PName")
            row("DPT_ID") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("DPT_ID")
            row("DPT_Name") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("DPT_Name")
            row("PP_Explain") = ""

            row("PP_Type") = RepositoryItemComboBox1.Items(0)
            row("PP_BeginUseDate") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("PP_BeginUseDate")
            row("PP_EndUseDate") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("PP_EndUseDate")
            row("RemnantDays") = ds.Tables("PieceProcess").Rows(ds.Tables("PieceProcess").Rows.Count - 1)("RemnantDays")


            If Me.lblTittle.Text = "計件工藝單--錄入" Then
                row("PP_BeginUse") = True
            Else
                row("PP_BeginUse") = False
            End If

            RepositoryItemLookUpEdit1.DisplayMember = "FacName"
            RepositoryItemLookUpEdit1.ValueMember = "FacID"
            RepositoryItemLookUpEdit1.DataSource = fc.GetFacList(strInFacID, Nothing)

            ds.Tables("PieceProcess").Rows.Add(row)
        End If
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“插入”，複制當前焦點行，在當前行下麵新增一行數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuInsert.Click
        If GridView2.RowCount <= 0 Then Exit Sub

        Dim row As DataRow
        Dim i%

        row = ds.Tables("PieceProcess").NewRow

        row("PP_Num") = GridView2.GetFocusedRowCellValue("PP_Num") + 1
        row("PS_NO") = GridView2.GetFocusedRowCellValue("PS_NO")
        row("PS_Name") = GridView2.GetFocusedRowCellValue("PS_Name")
        row("PP_N_Name") = GridView2.GetFocusedRowCellValue("PP_N_Name")
        row("PP_Price") = 0

        row("PP_Factor") = 1
        row("DPT_PName") = GridView2.GetFocusedRowCellValue("DPT_PName")
        row("DPT_ID") = GridView2.GetFocusedRowCellValue("DPT_ID")
        row("DPT_Name") = GridView2.GetFocusedRowCellValue("DPT_Name")
        row("PP_Explain") = ""

        row("PP_Type") = RepositoryItemComboBox1.Items(0)
        row("PP_BeginUseDate") = GridView2.GetFocusedRowCellValue("PP_BeginUseDate")
        row("PP_EndUseDate") = GridView2.GetFocusedRowCellValue("PP_EndUseDate")
        row("RemnantDays") = GridView2.GetFocusedRowCellValue("RemnantDays")

        If Me.lblTittle.Text = "計件工藝單--錄入" Then
            row("PP_BeginUse") = True
        Else
            row("PP_BeginUse") = False
        End If

        '加載廠別名稱
        RepositoryItemLookUpEdit1.DisplayMember = "FacName"
        RepositoryItemLookUpEdit1.ValueMember = "FacID"
        RepositoryItemLookUpEdit1.DataSource = fc.GetFacList(strInFacID, Nothing)

        ds.Tables("PieceProcess").Rows.InsertAt(row, GridView2.FocusedRowHandle + 1)    '於當前行下方插入一行數據

        '修改次序，從焦點行開始修改
        For i = GridView2.GetFocusedRowCellValue("PP_Num") To ds.Tables("PieceProcess").Rows.Count - 1
            ds.Tables("PieceProcess").Rows(i)("PP_Num") = i + 1
        Next
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“刪除”，刪除選中的數據行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub MenuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDel.Click
        On Error Resume Next

        Dim i%

        If GridView2.RowCount = 0 Then Exit Sub
        ''----------------------------------------------------------------------------------------

        If Me.lblTittle.Text = "計件工藝單--錄入" Then
            If IsDBNull(GridView2.GetFocusedRowCellValue("AutoID")) = True Then
                ds.Tables("PieceProcess").Rows.RemoveAt(CInt(ArrayToString(GridView2.GetSelectedRows())))
                ''-----------------------------------------------------------------------
                '修改次序，從焦點行開始修改
                For i = GridView2.GetFocusedRowCellValue("PP_Num") - 1 To ds.Tables("PieceProcess").Rows.Count
                    ds.Tables("PieceProcess").Rows(i - 1)("PP_Num") = i
                Next
            Else
                MsgBox("不能刪除已保存的計件工序!")
            End If
            Exit Sub
        End If
        ''----------------------------------------------------------------------------------------

        '判斷AutoID是否為空，若不為空，剛把選中行的AutoID添加到刪除信息表中
        If IsDBNull(GridView2.GetFocusedRowCellValue("AutoID")) Then
        Else
            '在刪除表中增加被刪除的記錄，以便確定時刪除數據庫中記錄
            Dim row As DataRow = ds.Tables("DelPieceProcess").NewRow

            row("AutoID") = ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("AutoID")

            ds.Tables("DelPieceProcess").Rows.Add(row)
        End If

        ''---------------------------------------------------------------------------------
        'If IsDBNull(GridView2.GetFocusedRowCellValue("PP_Num")) Then
        'Else
        '    If CSng(GridView2.GetFocusedRowCellValue("PP_Num")) > 0 Then
        '        ds.Tables("PieceProcess").Rows.RemoveAt(CSng(GridView2.GetFocusedRowCellValue("PP_Num")) - 1)
        '    End If
        'End If
        ds.Tables("PieceProcess").Rows.RemoveAt(CInt(ArrayToString(GridView2.GetSelectedRows())))
        ''-----------------------------------------------------------------------

        '修改次序，從焦點行開始修改
        For i = GridView2.GetFocusedRowCellValue("PP_Num") - 1 To ds.Tables("PieceProcess").Rows.Count
            ds.Tables("PieceProcess").Rows(i - 1)("PP_Num") = i
        Next
    End Sub
    ''' <summary>
    ''' 單擊GridView3，把部門名稱和編號傳到GridView2中
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GridView3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView3.Click
        On Error Resume Next
        '當審核時，此操作無效
        If GridView3.RowCount > 0 And lblTittle.Text <> "計件工藝單--審核" Then
            GridView2.SetFocusedRowCellValue(DPT_Name, GridView3.GetFocusedRowCellValue("DepName"))
            GridView2.SetFocusedRowCellValue(DPT_ID, GridView3.GetFocusedRowCellValue("DepID"))
            PopupContainerControl1.OwnerEdit.ClosePopup()
            GridView2.Focus()
        End If
    End Sub
    ''' <summary>
    ''' 當廠別名稱改變時，部門名稱和編號為空
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RepositoryItemLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged
        ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("DPT_Name") = ""
        ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("DPT_ID") = ""
        'GridView2.SetFocusedRowCellValue(DPT_Name, Nothing)
        'GridView2.SetFocusedRowCellValue(DPT_ID, Nothing)
    End Sub
    ''' <summary>
    ''' 工藝類型值改變時,在gluPM_Type中加載相應的配件名稱
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboPro_Type_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPro_Type.EditValueChanged
        gluPM_M_Code_EditValueChanged(Nothing, Nothing)     '調用產品編號值改變過程
    End Sub
    ''' <summary>
    ''' 單擊“確定”按鈕，保存數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim ppi As New ProductionPieceProcessInfo
        Dim j, i, k%
        isSameRow = False

        If gluPM_M_Code.Text = "" Then
            MsgBox("產品編號不能為空，請選擇產品編號!", 64, "提示")
            gluPM_M_Code.Focus()
            Exit Sub
        ElseIf gluPM_Type.Text = "" Then
            MsgBox("配件名稱不能為空，請選擇配件名稱!", 64, "提示")
            gluPM_Type.Focus()
            Exit Sub
        ElseIf txtPP_ActionUser.Text = "" Then
            MsgBox("操作人不能為空，請輸入操作人!", 64, "提示")
            txtPP_ActionUser.Focus()
            Exit Sub
        ElseIf dtePP_ActionDate.Text = "" Then
            MsgBox("建立日期不能為空，請輸入建立日期!", 64, "提示")
            dtePP_ActionDate.Focus()
            Exit Sub
        End If

        For i = 0 To GridView2.RowCount - 1
            GridView2.FocusedRowHandle = i
            If ds.Tables("PieceProcess").Rows(i)("PP_N_Name") = "" Then
                MsgBox("小工序名稱不能為空，請輸入小工序名稱!", 64, "提示")
                Exit Sub
            End If

            If Me.lblTittle.Text <> "計件工藝單--錄入" Then  '添加工藝時不判斷
                If ds.Tables("PieceProcess").Rows(i)("PP_Price") < 0 Then
                    MsgBox("工價不能小於等於0，請重新輸入工價!", 64, "提示")
                    Exit Sub
                End If
            End If


            If ds.Tables("PieceProcess").Rows(i)("PP_BeginUseDate") Is DBNull.Value Then
                MsgBox("啟用日期不能為空，請輸入啟用日期!", 64, "提示")
                Exit Sub
            End If
            If ds.Tables("PieceProcess").Rows(i)("PP_EndUseDate") Is DBNull.Value Then
                MsgBox("結束日期不能為空，請輸入結束日期!", 64, "提示")
                Exit Sub
            End If
            RepositoryItemCalcEdit1_Leave(Nothing, Nothing)     '調用工價失去焦點過程
            If isSameRow = True Then    '判斷是否存在相同記錄
                Exit Sub
            End If
            If ds.Tables("PieceProcess").Rows(i)("PP_BeginUseDate") > ds.Tables("PieceProcess").Rows(i)("PP_EndUseDate") Then
                MsgBox("輸入日期有誤，啟用日期不能大於結束日期!", 64, "提示")
                Exit Sub
            End If
            If lblTittle.Text = "計件工藝單--審核" Or lblTittle.Text = "計件工藝單--錄入" Then
                For k = 0 To ds.Tables("PieceProcess").Rows.Count - 1
                    If i <> k Then
                        If ds.Tables("PieceProcess").Rows(i)("PS_NO") = ds.Tables("PieceProcess").Rows(k)("PS_NO") _
                            And ds.Tables("PieceProcess").Rows(i)("PP_N_Name") = ds.Tables("PieceProcess").Rows(k)("PP_N_Name") _
                            And ds.Tables("PieceProcess").Rows(i)("DPT_ID") = ds.Tables("PieceProcess").Rows(k)("DPT_ID") _
                            And ds.Tables("PieceProcess").Rows(i)("PP_BeginUse") = True _
                            And ds.Tables("PieceProcess").Rows(k)("PP_BeginUse") = True Then
                            MsgBox("同一張單中工序相同且部門也相同的記錄不能同時啟用！", 64, "提示")
                            Exit Sub
                        End If
                    End If
                Next
            End If

        Next


        If lblTittle.Text = "計件工藝單--新增" Then
            If AddData() = True Then
                MsgBox("記錄添加完成!", 64, "提示")
                Me.Close()
            End If
        ElseIf lblTittle.Text = "計件工藝單--修改" Then
            If EditData() = True Then

                MsgBox("記錄修改完成!", 64, "提示")
                Me.Close()
            End If
        ElseIf lblTittle.Text = "計件工藝單--審核" Then
            ppi.PP_Check = chkPP_Check.EditValue
            ppi.PP_CheckUserID = InUserID
            ppi.PP_CheckDate = Now
            For j = 0 To ds.Tables("PieceProcess").Rows.Count - 1
                GridView2.FocusedRowHandle = j
                ppi.AutoID = ds.Tables("PieceProcess").Rows(j)("AutoID")
                ppi.PP_BeginUse = ds.Tables("PieceProcess").Rows(j)("PP_BeginUse")
                If ppc.ProductionPieceProcess_Check(ppi) = False Then
                    If MsgBox("次序為：" & ds.Tables("PieceProcess").Rows(j)("PP_Num") & " 的記錄審核失敗,是否要繼續審核其後的記錄？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
            Next
            MsgBox("記錄審核完成!", 64, "提示")
            Me.Close()

        ElseIf lblTittle.Text = "計件工藝單--單價錄入" Then
            If EditData() = True Then
                MsgBox("記錄修改完成!", 64, "提示")
                Me.Close()
            End If
        ElseIf lblTittle.Text = "計件工藝單--單價審核" Then

            ppi.PP_PriceCheckDate = Now
            ppi.PP_PriceCheckUserID = InUserID
            For j = 0 To ds.Tables("PieceProcess").Rows.Count - 1
                GridView2.FocusedRowHandle = j
                ppi.AutoID = ds.Tables("PieceProcess").Rows(j)("AutoID")
                ppi.PP_PriceCheck = ds.Tables("PieceProcess").Rows(j)("PP_PriceCheck")
                ppi.PP_FactorCheck = ds.Tables("PieceProcess").Rows(j)("PP_FactorCheck")

                ppi.PP_Price = ds.Tables("PieceProcess").Rows(j)("PP_Price")
                ppi.PP_Factor = ds.Tables("PieceProcess").Rows(j)("PP_Factor")

                If ppc.ProductionPieceProcessPrice_Check1(ppi) = False Then
                    If MsgBox("次序為：" & ds.Tables("PieceProcess").Rows(j)("PP_Num") & " 的單價審核失敗,是否要繼續審核其後的記錄？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
            Next
            MsgBox("單價審核完成!", 64, "提示")
            Me.Close()



        ElseIf Me.lblTittle.Text = "計件工藝單--錄入" Then
            If EditDataRecord() = True Then
                MsgBox("保存成功!")
                Me.Close()
            End If

        End If
    End Sub
    ''' <summary>
    ''' 結束日期值改變時，剩余天數也跟著改變
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RepositoryItemDateEdit2_DateTimeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemDateEdit2.DateTimeChanged
        If ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("PP_BeginUseDate") Is DBNull.Value Then Exit Sub

        Dim ts As TimeSpan
        '判斷當前日期是否大於啟用日期
        If Now > CDate(GridView2.GetFocusedRowCellValue("PP_BeginUseDate")) Then
            ts = CDate(sender.Text) - CDate(Format(Now, "yyyy/MM/dd"))      '剩余天數為結束日期減去當前日期
        Else
            ts = CDate(sender.Text) - CDate(GridView2.GetFocusedRowCellValue("PP_BeginUseDate"))    '剩余天數為結束日期減去啟用日期
        End If

        ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("RemnantDays") = ts.Days + 1     '剩余天數包括兩端點日期，因此需加1
    End Sub
    ''' <summary>
    ''' 啟用日期值改變時，剩余天數也跟著改變
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RepositoryItemDateEdit1_DateTimeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemDateEdit1.DateTimeChanged
        If ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("PP_EndUseDate") Is DBNull.Value Then Exit Sub

        Dim ts As TimeSpan
        '判斷當前日期是否大於啟用日期
        If Now > CDate(sender.Text) Then
            ts = CDate(GridView2.GetFocusedRowCellValue("PP_EndUseDate")) - CDate(Format(Now, "yyyy/MM/dd"))    '剩余天數為結束日期減去當前日期
        Else
            ts = CDate(GridView2.GetFocusedRowCellValue("PP_EndUseDate")) - CDate(sender.Text)      '剩余天數為結束日期減去啟用日期
        End If
        ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("RemnantDays") = ts.Days + 1     '剩余天數包括兩端點日期，因此需加1
    End Sub
    ''' <summary>
    ''' 工價控件失去焦點時，判斷是否有相同工序，相同部門的相同工價
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RepositoryItemCalcEdit1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCalcEdit1.Leave
        Dim i%
        isSameRow = False   '初始化變量為False
        For i = 0 To ds.Tables("PieceProcess").Rows.Count - 1
            If GridView2.GetFocusedRowCellValue("PP_Num") <> ds.Tables("PieceProcess").Rows(i)("PP_Num") Then
                If GridView2.GetFocusedRowCellValue("PS_NO") = ds.Tables("PieceProcess").Rows(i)("PS_NO") _
                    And GridView2.GetFocusedRowCellValue("PP_N_Name") = ds.Tables("PieceProcess").Rows(i)("PP_N_Name") _
                    And GridView2.GetFocusedRowCellValue("DPT_ID") = ds.Tables("PieceProcess").Rows(i)("DPT_ID") _
                    And GridView2.GetFocusedRowCellValue("PP_Price") = ds.Tables("PieceProcess").Rows(i)("PP_Price") Then
                    MsgBox("同一張單中相同的工序，相同的部門不能有相同的工價!", 64, "提示")
                    ds.Tables("PieceProcess").Rows(GridView2.FocusedRowHandle)("PP_Price") = 0
                    isSameRow = True    '存在相同記錄
                End If
            End If
        Next
    End Sub
    ''' <summary>
    ''' 單擊“全部啟用”按鈕，啟用所有工序
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAllUse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllUse.Click
        Dim i%
        If btnAllUse.Text = "全部啟用(&A)" Then
            For i = 0 To ds.Tables("PieceProcess").Rows.Count - 1
                ds.Tables("PieceProcess").Rows(i)("PP_BeginUse") = True
            Next
            btnAllUse.Text = "全部不啟用(&A)"
        ElseIf btnAllUse.Text = "全部不啟用(&A)" Then
            For i = 0 To ds.Tables("PieceProcess").Rows.Count - 1
                ds.Tables("PieceProcess").Rows(i)("PP_BeginUse") = False
            Next
            btnAllUse.Text = "全部啟用(&A)"
        End If
    End Sub
    ''' <summary>
    ''' 按空格鍵顯示下拉列表
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluPM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPM_M_Code.KeyDown, cboPro_Type.KeyDown, gluPM_Type.KeyDown, RepositoryItemComboBox1.KeyDown, RepositoryItemPopupContainerEdit1.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.showpopup()
        End If
    End Sub

    Private Sub chkPP_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPP_Check.CheckedChanged
        If lblTittle.Text = "計件工藝單--審核" Then
            btnOK.Enabled = Not btnOK.Enabled
        End If
    End Sub


    Private Sub GridView2_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles GridView2.RowCellStyle
        Dim strA, strB As Boolean
        On Error Resume Next

        If lblTittle.Text = "計件工藝單--單價審核" Or lblTittle.Text = "計件工藝單--審核" Then

            If lblTittle.Text = "計件工藝單--單價審核" Then
                strA = GridView2.GetFocusedRowCellValue("PP_PriceCheck")
                strB = GridView2.GetFocusedRowCellValue("PP_FactorCheck")

                If strA = True Then
                    PP_Price.OptionsColumn.ReadOnly = False
                Else
                    PP_Price.OptionsColumn.ReadOnly = True
                End If

                If strB = True Then
                    PP_Factor.OptionsColumn.ReadOnly = False
                Else
                    PP_Factor.OptionsColumn.ReadOnly = True
                End If
            End If
        Else

            strA = GridView2.GetFocusedRowCellValue("PP_PriceCheck")
            strB = GridView2.GetFocusedRowCellValue("PP_FactorCheck")

            If strA = True Then
                PP_Price.OptionsColumn.ReadOnly = True
                'PP_PriceCheck.OptionsColumn.ReadOnly = True
            Else
                PP_Price.OptionsColumn.ReadOnly = False
                'PP_PriceCheck.OptionsColumn.ReadOnly = False
            End If

            If strB = True Then
                PP_Factor.OptionsColumn.ReadOnly = True
                'PP_FactorCheck.OptionsColumn.ReadOnly = True
            Else
                PP_Factor.OptionsColumn.ReadOnly = False
                'PP_FactorCheck.OptionsColumn.ReadOnly = False 
            End If

            If strA = True Or strB = True Then
                PS_NO.OptionsColumn.ReadOnly = True
                DPT_PName.OptionsColumn.ReadOnly = True
                DPT_Name.OptionsColumn.ReadOnly = True
                'PP_N_Name.OptionsColumn.ReadOnly = True

                PP_Type.OptionsColumn.ReadOnly = True
                PP_Explain.OptionsColumn.ReadOnly = True
                'PP_BeginUseDate.OptionsColumn.ReadOnly = True
                'PP_EndUseDate.OptionsColumn.ReadOnly = True
                PP_BeginUse.OptionsColumn.ReadOnly = True
            Else
                PS_NO.OptionsColumn.ReadOnly = False
                DPT_PName.OptionsColumn.ReadOnly = False
                DPT_Name.OptionsColumn.ReadOnly = False
                PP_N_Name.OptionsColumn.ReadOnly = False


                PP_Type.OptionsColumn.ReadOnly = False
                PP_Explain.OptionsColumn.ReadOnly = False
                'PP_BeginUseDate.OptionsColumn.ReadOnly = False
                'PP_EndUseDate.OptionsColumn.ReadOnly = False
                PP_BeginUse.OptionsColumn.ReadOnly = False
            End If


        End If



    End Sub
    ''' <summary>
    ''' 統計修改記錄在增加時要修改（審核狀態）
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function EditDataRecord() As Boolean
        Dim ppi As New ProductionPieceProcessInfo
        Dim i As Integer


        ppi.PP_ID = txtPP_ID.Text
        ppi.Pro_Type = cboPro_Type.Text
        ppi.PM_M_Code = gluPM_M_Code.EditValue
        ppi.PM_Type = gluPM_Type.Text
        ppi.PP_ActionUser = txtPP_ActionUser.Text

        ppi.PP_ActionDate = dtePP_ActionDate.EditValue
        ppi.PP_Remark = txtPP_Remark.Text
        For i = 0 To ds.Tables("PieceProcess").Rows.Count - 1
            '判斷是否有新增數據,AutoID為空時，則有新增數據
            If ds.Tables("PieceProcess").Rows(i)("AutoID") Is DBNull.Value Then

                ppi.PP_Num = ds.Tables("PieceProcess").Rows(i)("PP_Num")
                ppi.PS_NO = ds.Tables("PieceProcess").Rows(i)("PS_NO")
                ppi.PP_N_Name = ds.Tables("PieceProcess").Rows(i)("PP_N_Name")
                ppi.DPT_ID = ds.Tables("PieceProcess").Rows(i)("DPT_ID")
                ppi.PP_Price = ds.Tables("PieceProcess").Rows(i)("PP_Price")

                ppi.PP_Factor = ds.Tables("PieceProcess").Rows(i)("PP_Factor")
                ppi.PP_Explain = ds.Tables("PieceProcess").Rows(i)("PP_Explain")
                ppi.PP_Type = ds.Tables("PieceProcess").Rows(i)("PP_Type")
                ppi.PP_BeginUseDate = ds.Tables("PieceProcess").Rows(i)("PP_BeginUseDate")
                ppi.PP_EndUseDate = ds.Tables("PieceProcess").Rows(i)("PP_EndUseDate")

                ppi.AddUserID = InUserID
                ppi.AddDate = Format(Now, "yyyy/MM/dd")

                ppi.PP_Check = True
                ppi.PP_BeginUse = True

                ''---------------20130327---------------------------------------------
                If Me.LabelCheckID.Text = "" Then
                Else
                    ppi.PP_CheckUserID = Me.LabelCheckID.Text
                End If

                If lblPP_CheckDate.Text <> "" Then
                    ppi.PP_CheckDate = Format(CDate(lblPP_CheckDate.Text), "yyyy-MM-dd")
                End If
                ''---------------------------------------------------------------------

                If ppc.ProductionPieceProcess_Add1(ppi) = True Then
                    EditDataRecord = True
                Else
                    If MsgBox("次序為：" & ds.Tables("PieceProcess").Rows(i)("PP_Num") & " 新增記錄添加失敗,是否要繼續保存其後的記錄？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.No Then
                        EditDataRecord = False
                        Exit Function
                    End If
                End If
            Else
                ppi.AutoID = ds.Tables("PieceProcess").Rows(i)("AutoID")
                ppi.PP_Num = ds.Tables("PieceProcess").Rows(i)("PP_Num")
                ppi.PS_NO = ds.Tables("PieceProcess").Rows(i)("PS_NO")
                ppi.PP_N_Name = ds.Tables("PieceProcess").Rows(i)("PP_N_Name")
                ppi.DPT_ID = ds.Tables("PieceProcess").Rows(i)("DPT_ID")

                ppi.PP_Price = ds.Tables("PieceProcess").Rows(i)("PP_Price")
                ppi.PP_Factor = ds.Tables("PieceProcess").Rows(i)("PP_Factor")
                ppi.PP_Explain = ds.Tables("PieceProcess").Rows(i)("PP_Explain")
                ppi.PP_Type = ds.Tables("PieceProcess").Rows(i)("PP_Type")
                ppi.PP_BeginUseDate = ds.Tables("PieceProcess").Rows(i)("PP_BeginUseDate")

                ppi.PP_EndUseDate = ds.Tables("PieceProcess").Rows(i)("PP_EndUseDate")
                ppi.ModifyUserID = InUserID
                ppi.ModifyDate = Format(Now, "yyyy/MM/dd")

                If ppc.ProductionPieceProcess_Update(ppi) = True Then
                    EditDataRecord = True
                Else
                    If MsgBox("次序為：" & ds.Tables("PieceProcess").Rows(i)("PP_Num") & " 記錄修改失敗,是否要繼續修改其後的記錄？", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "提示") = MsgBoxResult.No Then
                        EditDataRecord = False
                        Exit Function
                    End If
                End If
            End If
        Next
    End Function

    Function LoadPS_NO() As Boolean '2013-3-19

        If cboPro_Type.Text.Trim = "" Or gluPM_M_Code.Text.Trim = "" Or gluPM_Type.Text.Trim = "" Then
            Exit Function
        End If

        Dim pc As New ProcessMainControl

        RepositoryItemLookUpEdit5.DisplayMember = "PS_Name"
        RepositoryItemLookUpEdit5.ValueMember = "PS_NO"
        RepositoryItemLookUpEdit5.DataSource = pc.ProcessMain_GetList(Nothing, gluPM_M_Code.EditValue, cboPro_Type.Text, gluPM_Type.EditValue, Nothing, Nothing)
    End Function



    Private Sub RepositoryItemCalcEdit1_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles RepositoryItemCalcEdit1.Spin
        e.Handled = True

    End Sub

    Private Sub RepositoryItemCalcEdit2_Spin(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.SpinEventArgs) Handles RepositoryItemCalcEdit2.Spin
        e.Handled = True
    End Sub

End Class
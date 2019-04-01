Imports LFERP.Library.NmetalSampleManager.NmetalSampleBorrow
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.NmetalSampleManager.NmetalSampleOrdersMain
Imports LFERP.Library.NmetalSampleManager.NmetalSampleWareInventory
Public Class frmNmetalSampleRepay

#Region "字段屬性"
    Dim src As New NmetalSampleRepayController
    Dim sbc As New NmetalSampleBorrowController
    Dim pncon As New PersonnelControl
    Dim cc As New NmetalSampleOrdersMainControler
    Dim swcon As New NmetalSampleWareInventoryControler
    Dim socon As New NmetalSampleOrdersMainControler
    Dim boCheck As Boolean = False         '用來判斷審核狀態是否有改變
    Dim ds As New DataSet
    Private _EditItem As String
    Private _RepayID As String
    Private _D_ID As String
    Property EditItem() As String '屬性
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property

    Property RepayID() As String '屬性
        Get
            Return _RepayID
        End Get
        Set(ByVal value As String)
            _RepayID = value
        End Set
    End Property
    Property D_ID() As String '屬性
        Get
            Return _D_ID
        End Get
        Set(ByVal value As String)
            _D_ID = value
        End Set
    End Property
#End Region


    Private Sub frmSampleRepay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataToLookUpEdit()
        Select Case EditItem
            Case EditEnumType.ADD
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.ADD)
                Me.gluD_ID.EditValue = D_ID
                txtRepayID.EditValue = "自动编号"
                dteRepayDate.EditValue = Now.ToString("yyyy/MM/dd")
                SetControlEnable(True, False)
            Case EditEnumType.EDIT
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.EDIT)
                dteRepayDate.EditValue = Now.ToString("yyyy/MM/dd")
                SetControlEnable(True, False)
                LoadData(RepayID)
            Case EditEnumType.VIEW
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.VIEW)
                SetControlEnable(False, False)
                btnSave.Enabled = False
                LoadData(RepayID)
            Case EditEnumType.CHECK
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.CHECK)
                SetControlEnable(False, True)
                LoadData(RepayID)
        End Select
        Me.Text = lblTitle.Text
    End Sub

    Private Sub LoadDataToLookUpEdit()
        Dim pmlist As New List(Of PersonnelInfo)
        pmlist = pncon.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)
        gluD_ID.Properties.DataSource = pmlist

        Dim sblist As New List(Of NmetalSampleBorrowInfo)
        sblist = sbc.NmetalSampleBorrowD_ID_GetList(D_ID)
        gluPM_M_Code.Properties.DataSource = sblist
    End Sub

    Private Sub SetControlEnable(ByVal a As Boolean, ByVal b As Boolean)
        gluD_ID.Enabled = b
        gluPM_M_Code.Enabled = a
        caeRepayQty.Enabled = a
        txtSO_SampleID.Enabled = b
        dteRepayDate.Enabled = b
        txtRemarks.Enabled = a
        gbCheck.Visible = b
    End Sub
#Region "加載數據"
    Private Sub LoadData(ByVal PO As String)
        '----------------------------------------------------------------主档
        Dim objInfo As New NmetalSampleRepayInfo
        objInfo = src.NmetalSampleRepay_GetList(RepayID, Nothing, Nothing, Nothing, Nothing, Nothing, False)(0)
        txtRepayID.EditValue = objInfo.RepayID
        gluD_ID.EditValue = objInfo.D_ID
        txtCardID.EditValue = objInfo.InCardID
        gluPM_M_Code.EditValue = objInfo.PM_M_Code
        txtRemarks.EditValue = objInfo.Remarks
        caeRepayQty.EditValue = objInfo.RepayQty
        dteRepayDate.EditValue = objInfo.RepayDate
        txtSO_SampleID.EditValue = objInfo.SO_SampleID

        chkCheck.Checked = objInfo.CheckBit
        boCheck = chkCheck.Checked
        lblCheckUser.Text += objInfo.CheckUserName
        lblCheckDate.Text += Format(objInfo.CreateDate, "yyyy/MM/dd")
    End Sub
#End Region

#Region "保存、退出事件"
#Region "保存前檢查輸入數據是否正確"
    Private Function CheckSave() As Boolean
        Dim bo As Boolean = False
        CheckSave = True
        If gluD_ID.EditValue = Nothing Then
            MsgBox("请选择部门", MsgBoxStyle.Information, "提示")
            gluD_ID.Focus()
            bo = True
        ElseIf gluPM_M_Code.EditValue = Nothing Then
            MsgBox("请选择产品编号", MsgBoxStyle.Information, "提示")
            gluPM_M_Code.Focus()
            bo = True
        ElseIf Me.gluPS_NO.EditValue = Nothing Then
            MsgBox("请选择工序", MsgBoxStyle.Information, "提示")
            gluPM_M_Code.Focus()
            bo = True
        ElseIf caeRepayQty.EditValue = Nothing Or CInt(caeRepayQty.EditValue) <= 0 Then
            MsgBox("请填写还料数量", MsgBoxStyle.Information, "提示")
            caeRepayQty.Focus()
            bo = True
        ElseIf txtSO_SampleID.EditValue = Nothing Then
            MsgBox("样办单号不能为空！", MsgBoxStyle.Information, "提示")
            txtSO_SampleID.Focus()
            bo = True
        ElseIf txtCardID.EditValue = Nothing Then
            MsgBox("刷卡人员不能为空", MsgBoxStyle.Information, "提示")
            txtCardID.Focus()
            bo = True
        ElseIf caeRepayQty.EditValue = String.Empty Then
            MsgBox("还回数量不能为空", MsgBoxStyle.Information, "提示")
            caeRepayQty.Focus()
            bo = True
        ElseIf CDec(caeRepayQty.EditValue).Equals(0) Then
            MsgBox("还回数量不能为0", MsgBoxStyle.Information, "提示")
            caeRepayQty.Focus()
            bo = True
        ElseIf CDec(caeQty.EditValue).Equals(0) Then
            MsgBox("此产品没有领料", MsgBoxStyle.Information, "提示")
            caeRepayQty.Focus()
            bo = True
        ElseIf CDec(caeRepayQty.EditValue) > CDec(caeQty.EditValue) Then
            MsgBox("还料数量大于您的借料数量,请重新输入", MsgBoxStyle.Information, "提示")
            caeRepayQty.Focus()
            caeRepayQty.EditValue = 0
            bo = True
        ElseIf EditItem = EditEnumType.CHECK And boCheck = chkCheck.Checked Then
            MsgBox("审核状态没有变化,无法保存", MsgBoxStyle.Information, "提示")
            chkCheck.Focus()
            bo = True
        End If
        If EditItem <> EditEnumType.ADD And EditItem <> EditEnumType.EDIT Then
            If bo = True Then
                CheckSave = False
            End If
            Exit Function
        End If
        If bo = True Then
            CheckSave = False
            Exit Function
        End If
    End Function
#End Region

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (CheckSave() = False) Then
            Exit Sub
        End If

        Select Case EditItem
            Case EditEnumType.ADD
                SaveData(EditEnumType.ADD)
            Case EditEnumType.EDIT
                SaveData(EditEnumType.EDIT)
            Case EditEnumType.CHECK
                Dim sri As New NmetalSampleRepayInfo
                sri.RepayID = txtRepayID.EditValue
                sri.CheckBit = chkCheck.Checked
                sri.CheckAction = InUserID
                If src.NmetalSampleRepay_UpdateCheck(sri) = True Then
                    MsgBox("审核状态修改成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("审核状态修改成功", MsgBoxStyle.Information, "提示")
                End If
        End Select
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub SaveData(ByVal editItem As String)
        Try
            Dim strGetID As String = String.Empty
            Dim sri As New NmetalSampleRepayInfo
            sri.D_ID = gluD_ID.EditValue
            sri.InCardID = txtCardID.EditValue
            sri.PM_M_Code = gluPM_M_Code.EditValue
            sri.RepayQty = caeRepayQty.EditValue
            sri.RepayDate = dteRepayDate.EditValue
            sri.Remarks = txtRemarks.EditValue
            sri.SO_ID = Me.txtSO_ID.Text
            sri.PS_NO = Me.gluPS_NO.EditValue

            If editItem = EditEnumType.ADD Then
                strGetID = src.NmetalSampleRepay_GetID()
                txtRepayID.EditValue = strGetID
                sri.RepayID = strGetID
                sri.CreateDate = Format(Now, "yyyy/MM/dd")
                sri.CreateUserID = InUserID
                If src.NmetalSampleRepay_Add(sri) = True Then
                    MsgBox("生产还料成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("生产还料失败", MsgBoxStyle.Information, "提示")
                End If
            ElseIf editItem = EditEnumType.EDIT Then
                sri.RepayID = txtRepayID.EditValue
                sri.ModifyDate = Format(Now, "yyyy/MM/dd")
                sri.ModifyUserID = InUserID
                If src.NmetalSampleRepay_Update(sri) = True Then
                    MsgBox("生产还料修改成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("生产还料修改失敗", MsgBoxStyle.Information, "提示")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SaveMrpPurchaseOrder方法出錯")
        End Try
    End Sub



#End Region

    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        If EditItem = EditEnumType.ADD Or EditItem = EditEnumType.EDIT Or EditItem = EditEnumType.VIEW Then
            If txtCardID.EditValue = String.Empty And gluPM_M_Code.EditValue <> String.Empty Then
                MsgBox("请您先刷卡,要确认您借了多少！", MsgBoxStyle.Information, "提示")
                gluPM_M_Code.EditValue = String.Empty
                Exit Sub
            End If

            Dim solist As New List(Of NmetalSampleOrdersMainInfo)
            solist = socon.NmetalSampleOrdersMain_GetList(Nothing, Nothing, gluPM_M_Code.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If solist.Count > 0 Then
                txtSO_SampleID.Text = solist(0).SO_SampleID
                txtSO_ID.Text = solist(0).SO_ID
                txtMaterialTypeID.Text = solist(0).MaterialTypeName
            End If
            '2.出现工序
            Dim swlist As New List(Of NmetalSampleWareInventoryInfo)
            swlist = swcon.NmetalSampleWareInventoryA_Getlist(Me.gluD_ID.EditValue, Nothing, Me.gluPM_M_Code.EditValue, Nothing)
            gluPS_NO.Properties.DataSource = swlist
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If InUserID = "13021010" Then
            txtCardID.Text = "13021010"
        End If

        If EditItem = EditEnumType.ADD Or EditItem = EditEnumType.EDIT Then
            Dim strCardID As String = Nothing
            If txtCardID.Text = String.Empty Then
                strCardID = Nothing
            Else
                strCardID = txtCardID.Text
            End If

            'Dim swlist As New List(Of SampleBorrowInfo)
            'swlist = sbc.SampleBorrowA_GetList(Me.gluD_ID.EditValue, gluPS_NO.EditValue, Nothing, strCardID, Nothing)
            'If swlist.Count > 0 Then
            caeQty.EditValue = 0
            'End If
        End If
    End Sub

    Private Sub gluPS_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPS_NO.EditValueChanged
        If EditItem = EditEnumType.ADD Or EditItem = EditEnumType.EDIT Then
            Dim strCardID As String = Nothing
            If txtCardID.Text = String.Empty Then
                strCardID = Nothing
            Else
                strCardID = txtCardID.Text
            End If

            Dim swlist As New List(Of NmetalSampleBorrowInfo)
            swlist = sbc.NmetalSampleBorrowA_GetList(Me.gluD_ID.EditValue, gluPS_NO.EditValue, Nothing, strCardID, Nothing, False)
            If swlist.Count > 0 Then
                caeQty.EditValue = swlist(0).NoBorrow_Qty
            Else
                caeQty.EditValue = 0
            End If
        End If
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        txtCardID.Text = ReadCard() '讀取卡號李超
        If txtCardID.Text <> "" Then
            If EditItem = EditEnumType.ADD Or EditItem = EditEnumType.EDIT Then
                Dim strCardID As String = Nothing
                If txtCardID.Text = String.Empty Then
                    strCardID = Nothing
                Else
                    strCardID = txtCardID.Text
                End If
                caeQty.EditValue = 0
                'Dim swlist As New List(Of SampleBorrowInfo)
                'swlist = sbc.SampleBorrowA_GetList(Me.gluD_ID.EditValue, gluPS_NO.EditValue, Nothing, strCardID, Nothing)
                'If swlist.Count > 0 Then
                '    caeQty.EditValue = swlist(0).NoBorrow_Qty
                'End If
            End If
        End If
    End Sub
    Private Sub caeRepayQty_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles caeRepayQty.KeyUp
        Dim m As New System.Text.RegularExpressions.Regex("^\+?[1-9][0-9]*$")  '顯示整數,正浮點數正則表達式

        If m.IsMatch(caeRepayQty.Text) = True Then
        Else
            caeRepayQty.Text = Nothing
            Exit Sub
        End If
    End Sub
End Class
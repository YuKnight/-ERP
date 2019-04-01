Imports LFERP.Library.SampleManager.SampleBorrow
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.SampleManager.SampleOrdersMain
Imports LFERP.Library.SampleManager.SampleWareInventory

Public Class frmSampleBorrow
    Dim sbc As New SampleBorrowController
    Dim pncon As New PersonnelControl
    Dim SOM As New SampleOrdersMainControler
    Dim cc As New SampleOrdersMainControler
    Dim swcon As New SampleWareInventoryControler
    Dim socon As New SampleOrdersMainControler
    Dim boCheck As Boolean = False         '用來判斷審核狀態是否有改變
    Private _EditItem As String
    Private _BorrowID As String
    Private _D_ID As String

    Property EditItem() As String '屬性
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property

    Property BorrowID() As String '屬性
        Get
            Return _BorrowID
        End Get
        Set(ByVal value As String)
            _BorrowID = value
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

    Private Sub frmSampleBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDataToLookUpEdit()
        Select Case EditItem
            Case EditEnumType.ADD
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.ADD)
                Me.gluD_ID.EditValue = D_ID
                txt_BorrowID.EditValue = "自動編號"
                dteRepayDate.EditValue = Format(Now, "yyyy/MM/dd HH:mm:ss")
                SetControlEnable(True, False)
            Case EditEnumType.EDIT
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.EDIT)
                dteRepayDate.EditValue = Format(Now, "yyyy/MM/dd HH:mm:ss")
                SetControlEnable(True, False)
                LoadData(BorrowID)
            Case EditEnumType.VIEW
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.VIEW)
                SetControlEnable(False, False)
                cmdSave.Enabled = False
                LoadData(BorrowID)
            Case EditEnumType.CHECK
                lblTitle.Text = Me.Text + EditEnumValue(EditEnumType.CHECK)
                SetControlEnable(False, True)
                LoadData(BorrowID)
        End Select

        Me.Text = lblTitle.Text
        Try
            '李超
            Dim reset As New ResetPassWords.SetPassWords
            reset.SetPassWords()
        Catch
        End Try
    End Sub

    Private Sub LoadDataToLookUpEdit()
        '1.部门
        Dim pmlist As New List(Of PersonnelInfo)
        pmlist = pncon.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)
        gluD_ID.Properties.DataSource = pmlist
        '2.产品编号
        Dim sblist As New List(Of SampleBorrowInfo)
        sblist = sbc.SampleBorrowD_ID_GetList(D_ID)
        gluPM_M_Code.Properties.DataSource = sblist

    End Sub

    Private Sub SetControlEnable(ByVal a As Boolean, ByVal b As Boolean)
        gluD_ID.Enabled = b
        gluPM_M_Code.Enabled = a
        txtSO_SampleID.Enabled = b
        gluPS_NO.Enabled = a
        txtSO_ID.Enabled = b
        txt_Borrow_Qty.Enabled = a
        txt_Remark.Enabled = a
        gbCheck.Visible = b
    End Sub

#Region "加載數據"
    Private Sub LoadData(ByVal PO As String)
        Dim objlist As New List(Of SampleBorrowInfo)
        objlist = sbc.SampleBorrow_GetList(BorrowID, Nothing, Nothing, Nothing, Nothing, Nothing, False)
        If objlist.Count > 0 Then
            txt_BorrowID.EditValue = objlist(0).BorrowID
            gluD_ID.EditValue = objlist(0).D_ID
            txtCardID.EditValue = objlist(0).OutCardID
            gluPM_M_Code.EditValue = objlist(0).PM_M_Code
            txt_Borrow_Qty.EditValue = objlist(0).Borrow_Qty
            txt_Remark.EditValue = objlist(0).Remark
            gluPS_NO.EditValue = objlist(0).MaterialTypeID
            txtSO_SampleID.Text = objlist(0).SO_SampleID

            ce_IsCheck.Checked = objlist(0).CheckBit
            boCheck = ce_IsCheck.Checked
            lblCheckUser.Text += objlist(0).CheckUserName
            lblCheckDate.Text += Format(objlist(0).CreateDate, "yyyy/MM/dd")
        End If
    End Sub
#End Region

#Region "保存、退出事件"
#Region "保存前檢查輸入數據是否正確"
    Private Function CheckSave() As Boolean
        Dim bo As Boolean = False
        CheckSave = True

        If txtSO_SampleID.EditValue = Nothing Then
            MsgBox("樣辦單號不能為空！", MsgBoxStyle.Information, "提示")
            txtSO_SampleID.Focus()
            bo = True
        ElseIf txt_Borrow_Qty.EditValue = Nothing Then
            MsgBox("請填寫借出數量！", MsgBoxStyle.Information, "提示")
            txt_Borrow_Qty.Focus()
            bo = True
        ElseIf gluD_ID.EditValue = Nothing Then
            MsgBox("請選擇還回部門！", MsgBoxStyle.Information, "提示")
            gluD_ID.Focus()
            bo = True
        ElseIf gluPM_M_Code.EditValue = Nothing Then
            MsgBox("請選擇物料編碼！", MsgBoxStyle.Information, "提示")
            gluPM_M_Code.Focus()
            bo = True
        ElseIf txtCardID.EditValue = Nothing Then
            MsgBox("刷卡人員不能為空！", MsgBoxStyle.Information, "提示")
            txtCardID.Focus()
            bo = True
        ElseIf txt_Borrow_Qty.EditValue = String.Empty Then
            MsgBox("领料數量不能為空！", MsgBoxStyle.Information, "提示")
            txt_Borrow_Qty.Focus()
            bo = True
        ElseIf CDec(txt_Borrow_Qty.EditValue).Equals(0) Then
            MsgBox("领料數量不能為0！", MsgBoxStyle.Information, "提示")
            txt_Borrow_Qty.Focus()
            bo = True
        ElseIf CDec(caeAvailableQty.EditValue).Equals(0) Then
            MsgBox("可领料數量為0,不能领料！", MsgBoxStyle.Information, "提示")
            caeAvailableQty.Focus()
            bo = True
        ElseIf CDec(txt_Borrow_Qty.EditValue) > CInt(caeAvailableQty.EditValue) Then
            MsgBox("可领料数量不够！", MsgBoxStyle.Information, "提示")
            txt_Borrow_Qty.EditValue = 0
            txt_Borrow_Qty.Focus()
            bo = True
        ElseIf EditItem = EditEnumType.CHECK And boCheck = ce_IsCheck.Checked Then
            MsgBox("審核狀態沒有變化,無法保存！", MsgBoxStyle.Information, "提示")
            ce_IsCheck.Focus()
            bo = True
        End If

        If bo = True Then
            CheckSave = False
            Exit Function
        End If
    End Function
#End Region

    Private Sub SaveData(ByVal editItem As String)
        Try
            Dim sbi As New SampleBorrowInfo
            sbi.D_ID = gluD_ID.EditValue
            sbi.OutCardID = txtCardID.EditValue
            sbi.PM_M_Code = gluPM_M_Code.EditValue
            sbi.Borrow_Qty = txt_Borrow_Qty.EditValue
            sbi.SO_SampleID = txtSO_SampleID.Text
            sbi.BorrowDate = Now
            sbi.Remark = txt_Remark.EditValue
            sbi.MaterialTypeID = Me.gluPS_NO.EditValue
            sbi.SO_SampleID = Me.txtSO_SampleID.EditValue
            sbi.SO_ID = txtSO_ID.Text
            sbi.PS_NO = Me.gluPS_NO.EditValue
            sbi.CreateDate = dteRepayDate.EditValue

            If editItem = EditEnumType.ADD Then
                txt_BorrowID.EditValue = sbc.SampleBorrow_GetNewID()
                sbi.BorrowID = txt_BorrowID.EditValue
                sbi.CreateUserID = InUserID
                If sbc.SampleBorrow_Add(sbi) = True Then
                    MsgBox("添加成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("添加失敗", MsgBoxStyle.Information, "提示")
                End If
            ElseIf editItem = EditEnumType.EDIT Then
                sbi.BorrowID = txt_BorrowID.EditValue
                sbi.ModifyDate = Format(Now, "yyyy/MM/dd")
                sbi.ModifyUserID = InUserID
                If sbc.SampleBorrow_Update(sbi) = True Then
                    MsgBox("修改成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("修改失敗", MsgBoxStyle.Information, "提示")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "數據值驗證"
    Private Sub CalcEdit1_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
        If (CDec(e.NewValue) > 999999999 Or CDec(e.NewValue) < 0) Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub
#End Region

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If (CheckSave() = False) Then
            Exit Sub
        End If

        Select Case EditItem
            Case EditEnumType.ADD
                SaveData(EditEnumType.ADD)
            Case EditEnumType.EDIT
                SaveData(EditEnumType.EDIT)
            Case EditEnumType.CHECK
                Dim sbi As New SampleBorrowInfo
                sbi.BorrowID = txt_BorrowID.EditValue
                sbi.CheckBit = ce_IsCheck.Checked
                sbi.CheckUserID = InUserID
                If sbc.SampleBorrow_UpdateCheck(sbi) = True Then
                    MsgBox("審核狀態修改成功", MsgBoxStyle.Information, "提示")
                Else
                    MsgBox("審核狀態修改失敗", MsgBoxStyle.Information, "提示")
                End If
        End Select
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub glu_OutD_ID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If sender.EditValue <> Nothing Then
            'If glu_OutD_ID.EditValue = glu_InD_ID.EditValue Then
            '    MsgBox("借出部门不能和借入部门相同", MsgBoxStyle.Information, "提示")
            '    glu_InD_ID.EditValue = String.Empty
            'End If
        End If
    End Sub

    Private Sub GridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'pceMaterial.EditValue = GridView1.GetFocusedRowCellValue("PM_M_Code")
        'pceMaterial.ClosePopup()
        'gluMaterialType.EditValue = GridView1.GetFocusedRowCellValue("MaterialTypeID")
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If InUserID = "13021010" Then
            txtCardID.Text = "13021010"
        End If
    End Sub

    Private Sub gluMaterialType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If gluPM_M_Code.EditValue <> String.Empty Then
            Dim sblist As List(Of SampleBorrowInfo)
            sblist = sbc.SampleBorrowPM_M_Code_GetList(gluPM_M_Code.EditValue)
            If sblist.Count > 0 Then
                If sender.EditValue <> sblist(0).MaterialTypeID Then
                    MsgBox("产品编号存在材料", MsgBoxStyle.Information, "提示")
                    gluPS_NO.EditValue = sblist(0).MaterialTypeID
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        txtCardID.Text = ReadCard() '讀取卡號李超
        If txtCardID.Text <> "" Then
            'chkFP_OutOK.Checked = True
        End If
    End Sub

    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        If EditItem = EditEnumType.ADD Or EditItem = EditEnumType.EDIT Then
            Dim solist As New List(Of SampleOrdersMainInfo)
            solist = socon.SampleOrdersMain_GetList(Nothing, Nothing, gluPM_M_Code.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If solist.Count > 0 Then
                txtSO_SampleID.Text = solist(0).SO_SampleID
                txtSO_ID.Text = solist(0).SO_ID
                txtMaterialTypeID.Text = solist(0).MaterialTypeName
            End If
            '2.出现工序
            Dim swlist As New List(Of SampleWareInventoryInfo)
            swlist = swcon.SampleWareInventoryA_Getlist(Me.gluD_ID.EditValue, Nothing, Me.gluPM_M_Code.EditValue, Nothing)
            gluPS_NO.Properties.DataSource = swlist
        End If
    End Sub

    Private Sub gluPS_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPS_NO.EditValueChanged
        If EditItem = EditEnumType.ADD Or EditItem = EditEnumType.EDIT Then
            Dim swlist As New List(Of SampleWareInventoryInfo)
            swlist = swcon.SampleWareInventoryA_Getlist(Me.gluD_ID.EditValue, gluPS_NO.EditValue, Me.gluPM_M_Code.EditValue, Nothing)
            If swlist.Count > 0 Then
                caeAvailableQty.EditValue = swlist(0).AvailableQty
            Else
                caeAvailableQty.EditValue = 0
            End If
        End If
    End Sub


    Private Sub txt_Borrow_Qty_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Borrow_Qty.KeyUp
        Dim m As New System.Text.RegularExpressions.Regex("^\+?[1-9][0-9]*$")  '顯示整數,正浮點數正則表達式

        If m.IsMatch(txt_Borrow_Qty.Text) = True Then
        Else
            txt_Borrow_Qty.Text = Nothing
            Exit Sub
        End If
    End Sub
End Class
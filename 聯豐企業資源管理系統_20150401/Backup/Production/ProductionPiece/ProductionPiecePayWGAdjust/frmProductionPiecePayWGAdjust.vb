Imports LFERP.Library.ProductionSumPieceWorkGroup
Imports LFERP.Library.ProductionPieceWorkGroup
Imports LFERP.Library.ProductionPiecePayWGAdjust

Public Class frmProductionPiecePayWGAdjust
    Dim StrTypeLabel As String '類型 
    Dim OldCheck As Boolean

    Private Sub frmProductionPiecePayWGAdjust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        LabAutoID.Text = tempValue2
        tempValue2 = Nothing

        StrTypeLabel = MTypeName
        MTypeName = Nothing

        Clr_Text()

        Dim pc As New ProductionPieceWorkGroupControl
        GluOUT_G_NO.Properties.DisplayMember = "G_NOName"
        GluOUT_G_NO.Properties.ValueMember = "G_NO"
        GluOUT_G_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing)

        GluIN_G_NO.Properties.DisplayMember = "G_NOName"
        GluIN_G_NO.Properties.ValueMember = "G_NO"
        GluIN_G_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing)


        Select Case StrTypeLabel
            Case "AdjustAdd"
                Ad_Check.Visible = False
                labCheckName.Visible = False

            Case "AdjustEdit"
                Ad_Check.Visible = False
                labCheckName.Visible = False
                LoadData()
            Case "AdjustCheck"
                Ad_Check.Visible = True
                labCheckName.Visible = True
                LoadData()
            Case "AdjustView"
                Ad_Check.Visible = True
                'labCheckName.Enabled = False
                'Ad_Check.Enabled = False
                cmdSave.Visible = False


                GluOUT_G_NO.Properties.ReadOnly = True
                GluIN_G_NO.Properties.ReadOnly = True

                txtAd_YYMM.Properties.ReadOnly = True
                txtAmount.Properties.ReadOnly = True
                txtAd_Reason.Properties.ReadOnly = True


                LoadData()
        End Select



    End Sub



    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If StrTypeLabel = "AdjustAdd" Then
            If checkData() = True Then
                SaveNew()
            End If

        End If

        If StrTypeLabel = "AdjustEdit" Then
            If checkData() = True Then
                SaveEdit()
            End If
        End If

        If StrTypeLabel = "AdjustCheck" Then
            If checkData() = True Then
                SaveCheckData()
            End If
        End If
    End Sub

    Function checkData() As Boolean
        checkData = True

        If GluOUT_G_NO.EditValue Is DBNull.Value Or GluOUT_G_NO.EditValue = "" Then
            checkData = False
            GluOUT_G_NO.Select()
            MsgBox("請輸入轉出組別編號！")
            Exit Function
        End If

        If GluIN_G_NO.EditValue Is DBNull.Value Or GluIN_G_NO.EditValue = "" Then
            checkData = False
            GluIN_G_NO.Select()
            MsgBox("請輸入轉入組別編號！")
            Exit Function
        End If

        If Val(txtAmount.Text) <= 0 Then
            checkData = False
            txtAmount.Select()
            MsgBox("金額不能小於等於0!")
            Exit Function
        End If

        If txtAd_Reason.Text = "" Then
            checkData = False
            txtAd_Reason.Select()
            MsgBox("請輸入備注信息！")
            Exit Function
        End If


        If GluOUT_G_NO.EditValue = GluIN_G_NO.EditValue Then
            checkData = False
            GluOUT_G_NO.Select()
            MsgBox("轉入轉出組別不能相同！")
            Exit Function
        End If


        Dim pc As New ProductionPieceWorkGroupControl
        Dim pcil As New List(Of ProductionPieceWorkGroupInfo)
        pcil = pc.ProductionPieceWorkGroup_GetList(GluOUT_G_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pcil.Count <= 0 Then
            checkData = False
            Exit Function
        End If


        Dim pcA As New LFERP.Library.ProductionSumLock.ProductionSumLockControl
        Dim plA As New List(Of LFERP.Library.ProductionSumLock.ProductionSumLockInfo)
        plA = pcA.ProductionSumLock_GetList(Nothing, Nothing, pcil(0).DepID, Format(CDate(txtAd_YYMM.EditValue), "yyyy/MM"))

        If plA.Count > 0 Then
            If plA(0).LockCheck = True Then
                checkData = False
                MsgBox("保存失敗,轉出部門組別,記錄已鎖定!")
                Exit Function
            End If
        End If

        Dim pdc As New LFERP.Library.ProductionPiecePayWGMain.ProductionPiecePayWGMainControl
        Dim pdcl As New List(Of LFERP.Library.ProductionPiecePayWGMain.ProductionPiecePayWGMainInfo)

        pdcl = pdc.ProductionPiecePayWGMain_GetList(Nothing, Nothing, GluOUT_G_NO.EditValue, Format(CDate(txtAd_YYMM.EditValue), "yyyy/MM"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True)

        If pdcl.Count > 0 Then   ''有記錄
            MsgBox("保存失敗,轉出組別" & Format(CDate(txtAd_YYMM.EditValue), "yyyy/MM") & "的計件工資已審核!")
            checkData = False
            Exit Function
        End If
        ''---------------------------------------------------------------------------

        Dim pc2 As New ProductionPieceWorkGroupControl
        Dim pcil2 As New List(Of ProductionPieceWorkGroupInfo)
        pcil2 = pc2.ProductionPieceWorkGroup_GetList(GluIN_G_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pcil2.Count <= 0 Then
            checkData = False
            Exit Function
        End If

        Dim pcA2 As New LFERP.Library.ProductionSumLock.ProductionSumLockControl
        Dim plA2 As New List(Of LFERP.Library.ProductionSumLock.ProductionSumLockInfo)
        plA2 = pcA2.ProductionSumLock_GetList(Nothing, Nothing, pcil2(0).DepID, Format(CDate(txtAd_YYMM.EditValue), "yyyy/MM"))

        If plA2.Count > 0 Then
            If plA2(0).LockCheck = True Then
                checkData = False
                MsgBox("保存失敗,轉入部門組別,記錄已鎖定!")
                Exit Function
            End If
        End If

        Dim pdc2 As New LFERP.Library.ProductionPiecePayWGMain.ProductionPiecePayWGMainControl
        Dim pdcl2 As New List(Of LFERP.Library.ProductionPiecePayWGMain.ProductionPiecePayWGMainInfo)

        pdcl2 = pdc2.ProductionPiecePayWGMain_GetList(Nothing, Nothing, GluIN_G_NO.EditValue, Format(CDate(txtAd_YYMM.EditValue), "yyyy/MM"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True)

        If pdcl2.Count > 0 Then   ''有記錄
            MsgBox("保存失敗,轉出組別" & Format(CDate(txtAd_YYMM.EditValue), "yyyy/MM") & "的計件工資已審核!")
            checkData = False
            Exit Function
        End If
        ''---------------------------------------------------------------------------


        If StrTypeLabel = "AdjustAdd" Then
            Dim AC As New ProductionPiecePayWGAdjustControl
            Dim AL As New List(Of ProductionPiecePayWGAdjustInfo)

            AL = AC.ProductionPiecePayWGAdjust_GetList(Nothing, GluOUT_G_NO.EditValue, Nothing, Nothing, GluIN_G_NO.EditValue, Nothing, Nothing, Format(CDate(txtAd_YYMM.EditValue), "yyyy/MM"), Nothing, Nothing, Nothing)

            If AL.Count > 0 Then
                MsgBox("當月存在相同轉出組別,轉入組別的記錄.")
                checkData = False
                Exit Function
            End If

        End If



    End Function




    ''' <summary>
    ''' 清空數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clr_Text()
        GluOUT_G_NO.EditValue = Nothing
        GluIN_G_NO.EditValue = Nothing

        txtAd_YYMM.EditValue = Format(Now, "yyyy年MM月")
        txtAmount.Text = ""
        txtAd_Reason.Text = ""

    End Sub

    ''' <summary>
    ''' 載入數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData()
        Dim AC As New ProductionPiecePayWGAdjustControl
        Dim AL As New List(Of ProductionPiecePayWGAdjustInfo)

        AL = AC.ProductionPiecePayWGAdjust_GetList(LabAutoID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If AL.Count <= 0 Then
            MsgBox("無數據存在,請檢查!")
            Exit Sub
        End If
        GluOUT_G_NO.EditValue = AL(0).OUT_G_NO
        GluIN_G_NO.EditValue = AL(0).IN_G_NO
        txtAd_YYMM.EditValue = Format(CDate(AL(0).Ad_YYMM), "yyyy年MM月")

        txtAmount.Text = AL(0).Amount

        txtAd_Reason.Text = AL(0).Ad_Reason

        Me.Ad_Check.Checked = AL(0).Ad_Check

        Me.labCheckName.Text = "審核人: " & AL(0).Ad_CheckUserName

        OldCheck = AL(0).Ad_Check



    End Sub


    ''' <summary>
    ''' 添加數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveNew()
        Dim AC As New ProductionPiecePayWGAdjustControl
        Dim Ai As New ProductionPiecePayWGAdjustInfo

        Ai.OUT_G_NO = GluOUT_G_NO.EditValue
        '--------------------------------------------------------
        Dim pc As New ProductionPieceWorkGroupControl
        Dim pcil As New List(Of ProductionPieceWorkGroupInfo)
        pcil = pc.ProductionPieceWorkGroup_GetList(GluOUT_G_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pcil.Count <= 0 Then
            Exit Sub
        End If

        Ai.OUT_FacID = pcil(0).FacID
        Ai.OUT_DepID = pcil(0).DepID
        '--------------------------------------------------------

        Ai.IN_G_NO = GluIN_G_NO.EditValue
        '--------------------------------------------------------
        Dim pc2 As New ProductionPieceWorkGroupControl
        Dim pcil2 As New List(Of ProductionPieceWorkGroupInfo)
        pcil2 = pc2.ProductionPieceWorkGroup_GetList(GluIN_G_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pcil2.Count <= 0 Then
            Exit Sub
        End If

        Ai.IN_FacID = pcil2(0).FacID
        Ai.IN_DepID = pcil2(0).DepID
        '--------------------------------------------------------
        Ai.Amount = Val(txtAmount.Text)
        Ai.Ad_YYMM = Format(CDate(Me.txtAd_YYMM.EditValue), "yyyy/MM")

        Ai.Ad_Reason = txtAd_Reason.Text
        Ai.AddUserID = InUserID
        Ai.AddDate = Format(Now, "yyyy-MM-dd HH:mm:ss")


        If AC.ProductionPiecePayWGAdjust_Add(Ai) = True Then
            MsgBox("保存成功！")
            Me.Close()
        Else
            MsgBox("保存失敗!")
        End If

    End Sub
    ''' <summary>
    ''' 保存數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveEdit()
        Dim AC As New ProductionPiecePayWGAdjustControl
        Dim Ai As New ProductionPiecePayWGAdjustInfo

        Ai.AutoID = Me.LabAutoID.Text

        Ai.OUT_G_NO = GluOUT_G_NO.EditValue
        '--------------------------------------------------------
        Dim pc As New ProductionPieceWorkGroupControl
        Dim pcil As New List(Of ProductionPieceWorkGroupInfo)
        pcil = pc.ProductionPieceWorkGroup_GetList(GluOUT_G_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pcil.Count <= 0 Then
            Exit Sub
        End If

        Ai.OUT_FacID = pcil(0).DepID
        Ai.OUT_DepID = pcil(0).FacID
        '--------------------------------------------------------

        Ai.IN_G_NO = GluIN_G_NO.EditValue
        '--------------------------------------------------------
        Dim pc2 As New ProductionPieceWorkGroupControl
        Dim pcil2 As New List(Of ProductionPieceWorkGroupInfo)
        pcil2 = pc2.ProductionPieceWorkGroup_GetList(GluIN_G_NO.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If pcil2.Count <= 0 Then
            Exit Sub
        End If

        Ai.OUT_FacID = pcil2(0).DepID
        Ai.OUT_DepID = pcil2(0).FacID
        '--------------------------------------------------------
        Ai.Amount = Val(txtAmount.Text)
        Ai.Ad_YYMM = Format(CDate(Me.txtAd_YYMM.EditValue), "yyyy/MM")

        Ai.Ad_Reason = txtAd_Reason.Text
        Ai.AddUserID = InUserID
        Ai.AddDate = Format(Now, "yyyy-MM-dd HH:mm:ss")


        If AC.ProductionPiecePayWGAdjust_Update(Ai) = True Then
            MsgBox("保存成功！")
            Me.Close()
        Else
            MsgBox("保存失敗!")
        End If

    End Sub

    ''' <summary>
    ''' 審核數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveCheckData()
        Dim Acc As New ProductionPiecePayWGAdjustControl
        Dim Aii As New ProductionPiecePayWGAdjustInfo

        Aii.AutoID = Me.LabAutoID.Text

        If Me.Ad_Check.Checked = True Then
            Aii.Ad_Check = True
        Else
            Aii.Ad_Check = False
        End If

        Aii.Ad_CheckDate = Format(Now, "yyyy-MM-dd HH:mm:ss")
        Aii.Ad_CheckUserID = InUserID

        If Acc.ProductionPiecePayWGAdjust_UpdateCheck(Aii) = True Then
            MsgBox("保存成功！")
            Me.Close()
        Else
            MsgBox("保存失敗!")
        End If

    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
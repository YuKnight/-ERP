Imports LFERP.Library.ProductionPieceWorkGroup

Public Class frmProductionPieceWorkGroup

    Private Sub ProductionPieceWorkGroup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtG_NO.Text = tempValue2
        CaoTypeLabel.Text = MTypeName


        Dim pc As New ProductionPieceWorkGroupControl
        txtDepID.Properties.DataSource = pc.DepFac_GetList1(strInDepID, Nothing, Nothing, Nothing)
        txtDepID.Properties.DisplayMember = "UserDep_Fac"
        txtDepID.Properties.ValueMember = "DepID"

        MTypeName = Nothing
        tempValue2 = Nothing

        labFacID.Text = ""

        Select Case CaoTypeLabel.Text
            Case "WGAdd"
                Me.Text = "組別--增加"
                lblTittle.Text = "組別--增加"
                txtDepID.Enabled = True
            Case "WGEdit"
                If LoadData(TxtG_NO.Text) = False Then Exit Sub

                Me.Text = "組別--修改" & "[" & TxtG_NO.Text & "]"
                lblTittle.Text = "組別--修改"
                cmdAdd.Visible = False

            Case "WGView"

                If LoadData(TxtG_NO.Text) = False Then Exit Sub
                '查看
                cmdSave.Visible = False
                cmdAdd.Visible = False
                Me.Text = "組別--查看" & "[" & TxtG_NO.Text & "]"
                lblTittle.Text = "組別--查看"
        End Select

        TxtG_NO.Enabled = False

        'txtFacID.Enabled = False
        'txtDepID.Enabled = False


    End Sub
    ''' <summary>
    ''' 加載數據
    ''' </summary>
    ''' <param name="Str_G_no"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LoadData(ByVal Str_G_no As String) As Boolean
        LoadData = False

        Dim objInfo As New ProductionPieceWorkGroupInfo
        Dim objList As New List(Of ProductionPieceWorkGroupInfo)
        Dim oc As New ProductionPieceWorkGroupControl

        objList = oc.ProductionPieceWorkGroup_GetList(Str_G_no, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If objList.Count <= 0 Then
            MsgBox("數據庫中不存在此數據！", 64, "提示")
            LoadData = False
            Exit Function
        Else
            txtDepID.EditValue = objList(0).DepID
            labFacID.Text = objList(0).FacID
            txtG_Name.Text = objList(0).G_Name ''組別名稱
            txtG_Manager.Text = objList(0).G_Manager  ''組別負責人
            MemoG_Remark.Text = objList(0).G_Remark

            LoadData = True

        End If

    End Function
    ''' <summary>
    ''' 檢查數據輸入正確
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckData() As Boolean
        CheckData = True

        If txtDepID.EditValue = "" Then
            MsgBox("請選擇部門!", 64, "提示")
            txtDepID.Select()
            CheckData = False
            Exit Function
        End If

        If txtG_Name.Text = "" Then
            MsgBox("請填寫組別名稱!", 64, "提示")
            txtG_Name.Focus()
            CheckData = False
            Exit Function   '
        End If

        If txtG_Manager.Text = "" Then
            MsgBox("請填寫組別負責人!", 64, "提示")
            txtG_Manager.Focus()
            CheckData = False
            Exit Function
        End If

    End Function
    ''' <summary>
    ''' 新增數據
    ''' </summary>
    ''' <param name="S_model"></param>
    ''' <remarks></remarks>
    Private Sub SaveNew(ByVal S_model As String)

        Dim gc As New ProductionPieceWorkGroupControl
        Dim gi As New ProductionPieceWorkGroupInfo
        Dim pgi As List(Of ProductionPieceWorkGroupInfo)

        pgi = gc.ProductionPieceWorkGroup_GetList(Nothing, txtG_Name.Text.Trim, Nothing, txtDepID.EditValue, labFacID.Text, Nothing, Nothing, Nothing)
        '判斷組別名稱是否已存在
        If pgi.Count > 0 Then
            MsgBox("組別名稱已存在，請重新輸入!", 64, "提示")
            txtG_Name.Focus()
            txtG_Name.SelectAll()
            Exit Sub
        End If

        TxtG_NO.Text = GetWorkGroupNO() ''獲取驗收單號

        If TxtG_NO.Text = "" Then
            MsgBox("組別單號新增失敗，請檢查", 64, "提示")
            Exit Sub
        End If

        gi.G_NO = TxtG_NO.Text.Trim  ''組別編號
        gi.G_Name = txtG_Name.Text.Trim  ''組別名稱

        gi.DepID = txtDepID.EditValue  ''部門編號
        gi.FacID = labFacID.Text

        gi.G_Manager = txtG_Manager.Text.Trim

        gi.G_Remark = MemoG_Remark.Text
        gi.G_Action = InUserID
        gi.G_Date = Format(Now, "yyyy/MM/dd")

        If S_model = "S" Then
            If gc.ProductionPieceWorkGroup_Add(gi) = True Then
                MsgBox("數據新增成功", 64, "提示")
                Me.Close()
            End If
        Else
            If gc.ProductionPieceWorkGroup_Add(gi) = False Then
                MsgBox("數據新增失敗", 64, "提示")
            Else
                Clr_Text()
            End If
        End If
    End Sub
    ''' <summary>
    ''' 當保存不退出時，變量，數據框清空
    ''' </summary>
    ''' <remarks></remarks>
    Sub Clr_Text()
        TxtG_NO.Text = ""
        txtG_Name.Text = ""
        txtG_Manager.Text = ""
        MemoG_Remark.Text = ""
    End Sub

    ''' <summary>
    ''' 獲取流水基數號
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetWorkGroupNO() As String

        Dim gc As New ProductionPieceWorkGroupControl
        Dim gi As New ProductionPieceWorkGroupInfo

        gi = gc.ProductionPieceWorkGroup_GetNO(txtDepID.EditValue) '' 讀取基數

        If gi Is Nothing Then
            GetWorkGroupNO = txtDepID.EditValue & "001"
        Else
            GetWorkGroupNO = txtDepID.EditValue & Mid((CInt(Microsoft.VisualBasic.Right(gi.G_NO, 3)) + 1001), 2)
        End If
    End Function
    ''' <summary>
    ''' 修改數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveEdit()
        Dim gc As New ProductionPieceWorkGroupControl
        Dim gi As New ProductionPieceWorkGroupInfo
        Dim pgi As List(Of ProductionPieceWorkGroupInfo)

        pgi = gc.ProductionPieceWorkGroup_GetList(Nothing, txtG_Name.Text.Trim, Nothing, txtDepID.EditValue, labFacID.Text, Nothing, Nothing, Nothing)
        '判斷組別名稱是否已存在
        If pgi.Count > 0 Then
            MsgBox("組別名稱已存在，請重新輸入!", 64, "提示")
            txtG_Name.Focus()
            txtG_Name.SelectAll()
            Exit Sub
        End If

        If TxtG_NO.Text = "" Then
            MsgBox("組別單號修改失敗，請檢查")
            Exit Sub
        End If

        gi.G_NO = TxtG_NO.Text.Trim  ''組別編號
        gi.G_Name = txtG_Name.Text.Trim  ''組別名稱

        gi.DepID = txtDepID.EditValue   ''部門編號
        gi.FacID = labFacID.Text    ''廠別

        gi.G_Manager = txtG_Manager.Text.Trim

        gi.G_Remark = MemoG_Remark.Text
        gi.G_Action = InUserID
        gi.G_Date = Format(Now, "yyyy/MM/dd")


        If gc.ProductionPieceWorkGroup_Update(gi) = True Then
            MsgBox("數據修改成功")
            Me.Close()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If CheckData() = False Then Exit Sub

        Select Case CaoTypeLabel.Text
            Case "WGAdd"
                Call SaveNew("S")
            Case "WGEdit"
                Call SaveEdit()
        End Select
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckData() = False Then Exit Sub

        If CaoTypeLabel.Text = "WGAdd" Then
            Call SaveNew("A")
            txtG_Name.Select()
        End If
    End Sub

    Private Sub txtDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepID.EditValueChanged
        If txtDepID.EditValue <> "" Then
            Dim pc As New ProductionPieceWorkGroupControl
            Dim piList As New List(Of ProductionPieceWorkGroupInfo)

            piList = pc.DepFac_GetList1(txtDepID.EditValue, Nothing, Nothing, Nothing)

            If piList.Count > 0 Then
            Else
                Exit Sub
            End If

            labFacID.Text = piList(0).FacID
        End If
    End Sub
End Class
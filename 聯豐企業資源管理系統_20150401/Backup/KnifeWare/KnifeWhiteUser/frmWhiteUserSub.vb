Imports LFERP.Library.KnifeWare
Imports LFERP.SystemManager

Public Class frmWhiteUserSub

#Region "字段屬性"

    Private _WHID As String             ''獲取對應倉庫的ID
    Private _EditType As String         ''判斷是新增、修改還是查看
    Private _userID As String           ''獲取白名單的工號
    Private _WareType As String         ''獲取倉庫類型
    Private _isEdit As Boolean = False  ''確定是否對某一資料有更改
    Private _isNew As Boolean = False   ''確定是否添加資料
    Private _AutoID As String

    Public Property AutoID() As String
        Get
            Return _AutoID
        End Get
        Set(ByVal value As String)
            _AutoID = value
        End Set
    End Property

    Public Property WHID() As String
        Get
            Return _WHID
        End Get
        Set(ByVal value As String)
            _WHID = value
        End Set
    End Property

    Public Property EditType() As String
        Get
            Return _EditType
        End Get
        Set(ByVal value As String)
            _EditType = value
        End Set
    End Property

    Public Property userID() As String
        Get
            Return _userID
        End Get
        Set(ByVal value As String)
            _userID = value
        End Set
    End Property

    Public Property WareType() As String
        Get
            Return _WareType
        End Get
        Set(ByVal value As String)
            _WareType = value
        End Set
    End Property

    Public Property isEdit() As Boolean
        Get
            Return _isEdit
        End Get
        Set(ByVal value As Boolean)
            _isEdit = value
        End Set
    End Property

    Public Property isNew() As Boolean
        Get
            Return _isNew
        End Get
        Set(ByVal value As Boolean)
            _isNew = value
        End Set
    End Property

    Dim FindKaoQing As Boolean = False

#End Region



    Private Sub frmWhiteUserSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510919")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then FindKaoQing = True
        End If

        If FindKaoQing = True Then
            txt_UserName.Enabled = True
            txt_FacName.Enabled = True
            txtDepName.Enabled = True
        End If

        ''------以上2014-02-14---------------------------------------------------------------------


        Dim wuc As New KnifeWhiteUserController
        Dim fr As New frmWhiteUser
        Dim winfo As List(Of KnifeWhiteUserInfo)

        If EditType = "newAdd" Then
            lblMain.Text = "白名單--新增"
            txt_WH_ID.Text = WHID
            lblWType.Text = WareType
            txt_WMax.Text = 0
        Else
            lblMain.Text = "白名單--修改"
            cmdNew.Enabled = False
            txt_UserID.Enabled = False
            winfo = wuc.WhiteUser_GetList(AutoID, Nothing, Nothing, Nothing, Nothing, False)


            txt_UserID.Text = winfo(0).W_UserID
            txt_UserName.Text = winfo(0).W_UserName
            txt_WMax.Text = winfo(0).WMax
            txt_FacName.Text = winfo(0).FacName
            txtDepName.Text = winfo(0).DepName
            txt_Remark.Text = winfo(0).W_Remark
            txt_WH_ID.Text = winfo(0).WH_ID
            lblWType.Text = winfo(0).WType
            txt_AutoID.Text = winfo(0).AutoID
        End If

    End Sub

    Private Sub txt_UserID_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_UserID.KeyDown

        If e.KeyCode = Keys.Enter Then

            If txt_UserID.Text.Trim = Nothing Then
                MsgBox("請輸入工號！", 64, "提示")
                Exit Sub
            Else
                Dim wuc As New KnifeWhiteUserController
                Dim fr As New frmWhiteUser
                Dim winfo As List(Of KnifeWhiteUserInfo)

                winfo = wuc.WhiteUser_GetList(Nothing, txt_UserID.Text, Nothing, Nothing, Nothing, False)
                If winfo.Count = 0 Then
                    EditType = "newAdd"
                    txt_WMax.Text = 0
                    txt_Remark.Text = ""

                    If FindKaoQing = False Then '2014-02-14 不連考勤
                        Call GetNameDep(txt_UserID.Text)


                        If strKQdata = "haveData" Then
                            txt_UserName.Text = strKQName
                            txt_FacName.Text = strKQFacName
                            txtDepName.Text = strKQDepName
                        Else
                            MsgBox("不存在對應工號的用戶，請重新輸入！", 64, "提示")
                            txt_UserID.Text = ""
                            Exit Sub
                        End If

                    End If
                Else
                    MsgBox("該用戶在倉庫: " + winfo(0).WH_Name + " 中已經存在！", 64, "提示")
                    EditType = "update"
                    lblMain.Text = "白名單--修改"
                    cmdNew.Enabled = False
                    txt_UserID.Enabled = False
                    txt_UserName.Text = winfo(0).W_UserName
                    txt_WMax.Text = winfo(0).WMax
                    txt_FacName.Text = winfo(0).FacName
                    txtDepName.Text = winfo(0).DepName
                    txt_Remark.Text = winfo(0).W_Remark
                    txt_WH_ID.Text = winfo(0).WH_ID
                    lblWType.Text = winfo(0).WH_Name
                    txt_AutoID.Text = winfo(0).AutoID
                End If
                txt_WMax.Focus()
                End If
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        isEdit = False
        Me.Close()

    End Sub

    Function CheckSave() As Boolean

        CheckSave = True

        If txt_UserID.Text.Trim = Nothing Then
            MsgBox("請輸入工號！", 64, "提示")
            CheckSave = False
            Exit Function
        ElseIf txt_UserName.Text.Trim = Nothing Then
            MsgBox("輸入工號后請按下Enter！", 64, "提示")
            CheckSave = False
            Exit Function
        ElseIf CDbl(txt_WMax.Text) < 0 Then
            MsgBox("可領上限有誤，請檢查！", 64, "提示")
            CheckSave = False
            Exit Function
        End If

        '2013-11-21
        Dim wuc As New KnifeWhiteUserController
        Dim winfo As New List(Of KnifeWhiteUserInfo)
        winfo = wuc.WhiteUser_GetList(Nothing, txt_UserID.Text, Nothing, "刀具倉", Nothing, Nothing)

        If winfo.Count > 0 Then
            MsgBox("當前員工已在," & winfo(0).WH_Name & "存在白名單.", 64, "提示")
            CheckSave = False
            Exit Function
        End If


    End Function

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click

        Dim wuc As New KnifeWhiteUserController
        Dim winfo As New KnifeWhiteUserInfo

        If CheckSave() = True Then
            winfo.W_UserID = txt_UserID.Text
            winfo.W_UserName = txt_UserName.Text
            winfo.WMax = txt_WMax.Text
            winfo.FacName = txt_FacName.Text
            winfo.DepName = txtDepName.Text
            winfo.WType = "刀具倉"
            winfo.W_Remark = txt_Remark.Text
            winfo.DPT_ID = ""
            winfo.WH_ID = txt_WH_ID.Text
            winfo.GNO = txt_GNO.Text
            If wuc.WhiteUser_Add(winfo) = True Then
                MsgBox("新增成功！", 64, "提示")
                txt_UserID.Text = ""
                txt_WMax.Text = ""
                txt_Remark.Text = ""
                txt_UserName.Text = ""
                txt_FacName.Text = ""
                txtDepName.Text = ""
                txt_UserID.Focus()
                isNew = True
            Else
                MsgBox("新增失敗，請檢查原因！", 64, "提示")
            End If
        Else
            Exit Sub
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Dim wuc As New KnifeWhiteUserController
        Dim winfo As New KnifeWhiteUserInfo

        Select Case EditType
            Case "newAdd"
                If CheckSave() = True Then

                    winfo.W_UserID = txt_UserID.Text
                    winfo.W_UserName = txt_UserName.Text
                    winfo.WMax = txt_WMax.Text
                    winfo.FacName = txt_FacName.Text
                    winfo.DepName = txtDepName.Text
                    winfo.WType = "刀具倉"
                    winfo.W_Remark = txt_Remark.Text
                    winfo.DPT_ID = ""
                    winfo.WH_ID = txt_WH_ID.Text
                    winfo.GNO = txt_GNO.Text
                    If wuc.WhiteUser_Add(winfo) = True Then
                        isNew = True
                    Else
                        MsgBox("新增失敗，請檢查原因！", 64, "提示")
                    End If
                Else
                    Exit Sub
                End If
            Case "update"
                If wuc.WhiteUser_Update(txt_AutoID.Text, txt_Remark.Text, txt_WMax.Text) = True Then
                    isEdit = True
                    MsgBox("修改成功!", 64, "提示")
                Else
                    MsgBox("保存失敗，請檢查原因！", 64, "提示")
                End If
        End Select
        Me.Close()

    End Sub

    Private Sub txt_WMax_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_WMax.KeyDown

        If e.KeyCode = Keys.Enter Then
            txt_Remark.Focus()
        End If

    End Sub

    Private Sub txt_Remark_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Remark.KeyDown

        If e.KeyCode = Keys.Enter Then
            If EditType = "newAdd" Then
                cmdNew.Focus()
            Else
                cmdSave.Focus()
            End If
        End If

    End Sub

    Private Sub FindButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindButton.Click
        If txt_UserID.Text = "" Then
            MsgBox("請輸入工號！")
            txt_UserID.Select()
            Exit Sub
        End If

        Call GetNameDep(txt_UserID.Text)

        If strKQdata = "haveData" Then
            txt_UserName.Text = strKQName
            txt_FacName.Text = strKQFacName
            txtDepName.Text = strKQDepName
        Else
            MsgBox("不存在對應工號的用戶，請重新輸入！", 64, "提示")
            txt_UserID.Text = ""
            txt_UserName.Text = ""
            txt_FacName.Text = ""
            txtDepName.Text = ""
            Exit Sub
        End If
    End Sub
End Class
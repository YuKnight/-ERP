Imports LFERP.Library.WareHouse
Imports LFERP.Library.KnifeWare

Public Class frmWhiteUserSelect

#Region "獲取查詢窗體中的工號"

    Private _strUserID As String
    Private _strData As String
    Private _strWH_ID As String
    Private _whiteSelectList As List(Of KnifeWhiteUserInfo)

    Public Property strUserID() As String
        Get
            Return _strUserID
        End Get
        Set(ByVal value As String)
            _strUserID = value
        End Set
    End Property

    Public Property strData() As String
        Get
            Return _strData
        End Get
        Set(ByVal value As String)
            _strData = value
        End Set
    End Property

    Public Property strWH_ID() As String
        Get
            Return _strWH_ID
        End Get
        Set(ByVal value As String)
            _strWH_ID = value
        End Set
    End Property

    Public Property whiteSelectList() As List(Of KnifeWhiteUserInfo)
        Get
            Return _whiteSelectList
        End Get
        Set(ByVal value As List(Of KnifeWhiteUserInfo))
            _whiteSelectList = value
        End Set
    End Property

#End Region

    Private Sub frmWhiteUserSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mt As New WareHouseController
        ' mt.WareHouse_LoadToTreeView(tv1, WareSelect(InUserID, "510205"))
        mt.WareHouse_LoadToTreeView(tv1, WareSelect(InUserID, "510904"))

        CreateFacNameTables()

    End Sub

    Sub CreateFacNameTables()

        Dim ds As New DataSet
        ds.Tables.Clear()
        With ds.Tables.Add("FacName")
            .Columns.Add("fac_name", GetType(String))
        End With
        ds = GetFacName()

        EditFacName.Properties.DataSource = ds.Tables("FacName")
        EditFacName.Properties.DisplayMember = "fac_name"
        EditFacName.Properties.ValueMember = "fac_name"

    End Sub

    Sub CreateDepNameTables()

        Dim ds As New DataSet
        ds.Tables.Clear()
        With ds.Tables.Add("DepName")
            .Columns.Add("bri_name", GetType(String))
        End With
        ds = GetDepName(EditFacName.EditValue)

        EditDepName.Properties.DataSource = ds.Tables("DepName")
        EditDepName.Properties.DisplayMember = "bri_name"
        EditDepName.Properties.ValueMember = "bri_name"

    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click

        Dim fr As New frmWhiteUser
        Dim wuc As New KnifeWhiteUserController
        Dim strUser As String
        Dim strUserName As String
        Dim strFacName As String
        Dim strDepName As String
        Dim strWare As String
        Dim strWMax As Double

        strUser = txt_UserID.Text.ToString.Trim
        strUserName = txt_UserName.Text.ToString.Trim
        strFacName = EditFacName.EditValue
        strDepName = EditDepName.EditValue
        strWare = PopupContainerEditWare.EditValue
        strWMax = EditWMax.EditValue

        If CheckUserID.Checked = True And strUser = Nothing Then
            MsgBox("請輸入工號！", 64, "提示")
            txt_UserID.Focus()
            Exit Sub
        ElseIf CheckUserID.Checked = False Then
            strUser = Nothing
        End If

        If CheckUserName.Checked = True And strUserName = Nothing Then
            MsgBox("請輸入姓名！", 64, "提示")
            txt_UserName.Focus()
            Exit Sub
        ElseIf CheckUserName.Checked = False Then
            strUserName = Nothing
        End If

        If CheckFacName.Checked = True And strFacName = Nothing Then
            MsgBox("請輸入廠別！", 64, "提示")
            EditFacName.Focus()
            Exit Sub
        ElseIf CheckFacName.Checked = False Then
            strFacName = Nothing
        End If

        If CheckDepName.Checked = True And strDepName = Nothing Then
            MsgBox("請輸入部門！", 64, "提示")
            EditDepName.Focus()
            Exit Sub
        ElseIf CheckDepName.Checked = False Then
            strDepName = Nothing
        End If

        If CheckWare.Checked = True And strWare Is Nothing Then
            MsgBox("請輸入倉庫！", 64, "提示")
            PopupContainerEditWare.Focus()
            Exit Sub
        ElseIf CheckWare.Checked = False Then
            strWare = Nothing
        End If

        If CheckWMax.Checked = True And strWMax = Nothing Then
            MsgBox("請輸入上限！", 64, "提示")
            EditWMax.Focus()
            Exit Sub
        ElseIf CheckWMax.Checked = False Then
            strWMax = Nothing
        End If

        whiteSelectList = wuc.WhiteUser_SelectGetList(strUser, strUserName, strFacName, strDepName, strWare, strWMax)

        If whiteSelectList.Count = 0 Then

            MsgBox("找不到對應用戶，請重新輸入條件查找!", 64, "提示")
            txt_UserID.Text = ""
            txt_UserName.Text = ""
            EditFacName.EditValue = ""
            EditDepName.EditValue = ""
            PopupContainerEditWare.EditValue = ""
            EditWMax.EditValue = Nothing
            Exit Sub
        Else
            strData = "havedata"
            Me.Close()
        End If

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click

        Me.Close()

    End Sub

    Private Sub tv1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tv1.DoubleClick

        PopupContainerEditWare.EditValue = tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()

    End Sub

    Private Sub EditFacName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditFacName.EditValueChanged

        CreateDepNameTables()

    End Sub

End Class
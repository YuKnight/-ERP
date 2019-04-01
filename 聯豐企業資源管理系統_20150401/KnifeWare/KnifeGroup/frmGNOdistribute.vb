Imports LFERP.Library.KnifeWare
Public Class frmGNOdistribute

    Dim strW_UserID As String
    Dim strWHID As String
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmGNOdistribute_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strW_UserID = tempValue
        strWHID = tempValue2
        tempValue = Nothing
        tempValue2 = Nothing

        Dim wc As New KnifeGroupControl
        GridLookGNO.Properties.DisplayMember = "G_Name"
        GridLookGNO.Properties.ValueMember = "G_NO"
        GridLookGNO.Properties.DataSource = wc.KnifeGroup_GetList(Nothing, Nothing, strWHID)

        LoadData()

    End Sub
    ''' <summary>
    ''' 載入數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData()
        Dim GC As New KnifeWhiteUserController
        Dim gl As New List(Of KnifeWhiteUserInfo)
        gl = GC.WhiteUser_GetList(Nothing, strW_UserID, strWHID, Nothing, Nothing, False)

        If gl.Count <= 0 Then
            MsgBox("無數據存在!", 64, "提示")
            Me.Close()
        ElseIf gl.Count > 1 Then
            MsgBox("當前白名單在同一倉中存在,多條記錄!", 64, "提示")
            Me.Close()
        End If

        txtWH.Text = gl(0).WH_Name
        txtWH.Tag = gl(0).WH_ID

        txtW_UserID.Text = gl(0).W_UserID
        txtW_UserName.Text = gl(0).W_UserName
        GridLookGNO.EditValue = gl(0).GNO

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If GridLookGNO.Text = "" Then
            MsgBox("組別編號為空,請檢查！", 64, "提示")
            Exit Sub
        End If

        SaveData()

    End Sub

    Sub SaveData()
        Dim GC As New KnifeWhiteUserController
        Dim gl As New KnifeWhiteUserInfo

        If GC.WhiteUser_UpdateGNOA(strW_UserID, strWHID, GridLookGNO.EditValue) = True Then
            MsgBox("保存成功!", 64, "提示")
            Me.Close()
        Else
            MsgBox("保存失敗,請檢查!", 64, "提示")
        End If


    End Sub


End Class
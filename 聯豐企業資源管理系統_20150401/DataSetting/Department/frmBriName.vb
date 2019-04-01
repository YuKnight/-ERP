Imports LFERP.DataSetting
Imports LFERP.SystemManager


Public Class frmBriName

    Dim dc As New DepartmentControler
    Dim sc As New SystemManager.SystemUser.SystemUserController


    Private Sub frmBriName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label4.Text = tempValue
        Label5.Text = tempValue2
        Label6.Text = tempValue3

        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        Select Case Label5.Text

            Case "ID"
                TextEdit1.Text = Label4.Text
                TextEdit2.Text = Label6.Text
                TextEdit2.Enabled = False
            Case "Name"
                TextEdit1.Text = Label4.Text
                TextEdit2.Text = Label6.Text
                TextEdit1.Enabled = False

            Case Else

                TextEdit1.Select()

        End Select

    End Sub

    Sub DataNew()     '新增部門信息

        Dim di As New DepartmentInfo

        di.DepID = TextEdit1.Text.Trim
        di.DepName = TextEdit2.Text.Trim

        di.FacID = Mid(TextEdit1.Text.Trim, 1, 1)

        If dc.BriName_Add(di) = True Then

            MsgBox("添加部門信息成功！", 60, "提示")
        Else
            MsgBox("添加部門信息失敗，請檢查原因！", 60, "提示")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Sub DataEditID()   '變更部門ID信息（）

    End Sub

    Sub DataEditName()    '變更部門名稱（由於當前部門辦公地點移動等情況）

        Dim di As New DepartmentInfo

        di.DepID = TextEdit1.Text.Trim
        di.DepName = TextEdit2.Text.Trim


        If dc.BriName_UpdateName(di) = True Then         '變更BriName表中記錄

            Dim sci As List(Of SystemUser.SystemUserInfo)
            Dim si As New SystemUser.SystemUserInfo

            sci = sc.SystemUser_GetList(TextEdit1.Text.Trim, Nothing, Nothing)

            If sci.Count > 0 Then

                Dim strID, strName, strPWD, strDID As String
                Dim strkey As Byte()

                strID = sci(0).U_ID
                strName = sci(0).U_Name
                strPWD = sci(0).U_PassWord
                strDID = sci(0).DPT_ID
                strkey = sci(0).U_KeyImage

                sc.SystemUser_Delete(TextEdit1.Text.Trim)

                si.U_ID = strID
                si.U_KeyImage = sci(0).U_KeyImage
                si.U_Name = strName
                si.U_PassWord = sci(0).U_PassWord
                si.DPT_ID = strDID

                sc.SystemUser_Add(si)    '修改當前用戶顯示名稱信息

            End If

            Dim sci1 As List(Of SystemUser.SystemUserInfo)

            sci1 = sc.UserPower_GetList(Nothing, Nothing, Nothing, TextEdit1.Text.Trim)

            Dim si1 As New SystemUser.SystemUserInfo

            If sci1.Count > 0 Then    '當前變更的部門信息在生產權限用戶表中存在執行以下代碼--變更當前已存在用戶部門屬性

                Dim strUserID, strUserName, strUserRank, strDepID, strUserType As String  'UserPower表信息變更

                strUserID = sci1(0).UserID
                strUserName = sci1(0).UserName
                strUserRank = sci1(0).UserRank
                strDepID = sci1(0).DepID
                strUserType = sci1(0).UserType

                si1.UserID = strUserID    '登錄ID
                si1.UserName = TextEdit2.Text.Trim    '部門信息
                si1.UserRank = strUserRank   '生產權限等級
                si1.DepID = strDepID       '所在部門
                si1.UserType = strUserType  '工藝類型

                sc.UserPower_Update(si1)    '修改當前UserPower表中部門信息UserName 信息

            End If

            MsgBox("修改部門信息成功！", 60, "提示")
        Else
            MsgBox("修改部門信息失敗，請檢查原因！", 60, "提示")
            Exit Sub
        End If

        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Select Case Label5.Text

            Case "ID"

            Case "Name"   '部門名稱變更
                If Edit = True Then
                    DataEditName()
                End If
            Case Else

                If CheckData() = True Then
                    If Edit = False Then
                        DataNew()
                    End If
                End If
        End Select

    End Sub

    '判斷當前部門ID是否存在，如果已存在不允許再次添加

    Function CheckData() As Boolean

        CheckData = True    '賦初始值 為1

        Dim di As List(Of DepartmentInfo)
        di = dc.BriName_GetList(TextEdit1.Text.Trim, Nothing, Nothing)
        If di.Count > 0 Then
            MsgBox("此部門編號已存在，請重新添加！", 60, "提示")
            TextEdit1.Text = ""
            TextEdit1.Select()

            CheckData = False
            Exit Function
        End If

    End Function

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


End Class
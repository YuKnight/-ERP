Imports Microsoft.VisualBasic
Imports LFERP.Library.KnifeWare

Public Class frmKnifeTypeGroupAdd
    Dim strType As String
    Dim strID As String

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If txtName.Text = "" Then
            MsgBox("名稱不能為空!", 64, "提示")
            txtName.Select()
            Exit Sub
        End If
        '------------------------------------------------
        Dim Kc As New KnifeTypeGroupControl
        Dim Ki As New KnifeTypeGroupInfo
        Ki.KnifeID = txtID.Text
        Ki.KnifePID = LabelName.Tag
        Ki.KnifeType = txtName.Text

        Select Case strType
            Case "Add", "AddNext"
                If Kc.KnifeTypeGroup_Add(Ki) = True Then
                    MsgBox("新增成功!", 64, "提示")
                Else
                    MsgBox("新增失敗!", 64, "提示")
                    Exit Sub
                End If

            Case "Update"
                If Kc.KnifeTypeGroup_Update(Ki) = True Then
                    MsgBox("保存成功!", 64, "提示")
                Else
                    MsgBox("保存失敗!", 64, "提示")
                    Exit Sub
                End If
        End Select

        Me.Close()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmKnifeTypeGroupAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim KC As New KnifeTypeGroupControl
        strID = tempValue
        strType = tempValue4 'Update

        tempValue4 = Nothing
        tempValue = Nothing

        Dim kl As New List(Of KnifeTypeGroupInfo)
        kl = KC.KnifeTypeGroup_GetList(Nothing, Nothing, Nothing, strID)

        If kl.Count <= 0 Then
            Exit Sub
        End If

        Select Case strType
            Case "Add"
                '由本級ID查詢,獲取本級名稱,上級編號
                LabelName.Text = kl(0).KnifePIDName
                LabelName.Tag = kl(0).KnifePID
                Me.txtID.Text = KnifeTypeGroup_GetID(kl(0).KnifePID)

            Case "Update"
                '從編號查詢出本級名稱
                LabelName.Text = kl(0).KnifePIDName
                LabelName.Tag = kl(0).KnifePID
                txtID.Text = kl(0).KnifeID
                txtName.Text = kl(0).KnifeType

            Case "AddNext"
                LabelName.Text = kl(0).KnifeType
                LabelName.Tag = kl(0).KnifeID
                txtID.Text = Trim(kl(0).KnifeID & "01")

        End Select

    End Sub
    ''' <summary>
    ''' 得到要增加的編碼
    ''' </summary>
    ''' <param name="StrPID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function KnifeTypeGroup_GetID(ByVal StrPID As String) As String
        KnifeTypeGroup_GetID = ""
        Dim tempID As String = ""

        Dim DC As New KnifeTypeGroupControl
        Dim Di As New KnifeTypeGroupInfo

        Di = DC.KnifeTypeGroup_GetID(StrPID)
        If Di Is Nothing Then
            tempID = Trim(StrPID & "01")
        Else
            Dim temRight As String
            temRight = Microsoft.VisualBasic.Right(Di.KnifeID, 2)
            tempID = Trim(Mid(Di.KnifeID, 1, Len(Di.KnifeID) - 2) + Format(Val(temRight) + 1, "00"))
        End If

        KnifeTypeGroup_GetID = tempID
    End Function
End Class
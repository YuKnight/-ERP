Imports LFERP.Library.KnifeWare
Public Class frmKnifeGroupAdd

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtG_Name.Text = "" Then
            MsgBox("組別名稱不能為空!", 64, "提示")
            Exit Sub
        End If

        If txtWH.Tag = "" Then
            MsgBox("請選擇倉庫!", 64, "提示")
            Exit Sub
        End If

        ''-----------------------------------------------------------
        Dim kiL As New List(Of KnifeGroupInfo)
        Dim kcL As New KnifeGroupControl
        kiL = kcL.KnifeGroup_GetList(txtWH.Tag & Me.txtG_Name.Text, Nothing, txtWH.Tag)
        If kiL.Count <= 0 Then
        Else
            MsgBox("當前倉庫:" & txtWH.Text & "   已存此組別,請檢查！", 64, "提示")
            Exit Sub
        End If
        ''-----------------------------------------------------------
        Dim ki As New KnifeGroupInfo
        Dim kc As New KnifeGroupControl
        ki.WH_ID = txtWH.Tag
        ki.G_Name = Me.txtG_Name.Text
        ki.G_NO = txtWH.Tag & Me.txtG_Name.Text
        ki.Remark = Format(Now, "yyyy/MM/dd HH:mm:ss" & ";" & InUserID & "操作")

        If kc.KnifeGroup_Add(ki) = True Then
            MsgBox("保存成功!", 64, "提示")
            Me.Close()
        Else
            MsgBox("保存失敗,請檢查！", 64, "提示")
        End If

    End Sub

    Private Sub frmKnifeGroupAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtWH.Enabled = False
        txtWH.Tag = tempValue
        txtWH.Text = tempValue2

        tempValue = Nothing
        tempValue2 = Nothing

        txtG_Name.Select()

    End Sub
End Class
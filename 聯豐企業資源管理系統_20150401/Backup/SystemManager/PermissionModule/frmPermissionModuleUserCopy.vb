Imports LFERP.SystemManager

Public Class frmPermissionModuleUserCopy

    Public uu As New SystemUser.SystemUserController

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim us As SystemUser.SystemUserInfo = uu.SystemUser_Get(TextEdit2.Text)
        If us Is Nothing Then
            MsgBox("用戶不存在！")
            Exit Sub
        Else
            DataNew()
        End If

        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmPermissionModuleUserCopy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextEdit1.Text = tempValue4
        tempValue4 = ""
        TextEdit2.Text = ""
    End Sub

    Sub DataNew()  '新增新的用戶權限

        Dim pmu As New PermissionController
        Dim pmi As New List(Of PermissionInfo)

        Dim pmui As New PermissionInfo

        pmi = pmu.PermissionModuleUser_GetList(TextEdit1.Text)
        pmu.PermissionModuleUser_Delete(TextEdit2.Text, Nothing)

        Dim pwsc As New PermissionModuleWarrantSubController
        Dim pwsiL As New List(Of PermissionModuleWarrantSubInfo)

        Dim pwsi As New PermissionModuleWarrantSubInfo


        pwsiL = pwsc.PermissionModuleWarrantSub_Get(TextEdit1.Text)
        pwsc.PermissionModuleWarrantSub_Delete(TextEdit2.Text, Nothing)

        Dim i As Integer
        For i = 0 To pmi.Count - 1 '----復製模塊權限

            pmui.PM_ID = pmi(i).PM_ID
            pmui.PM_Image = pmi(i).PM_Image
            pmui.PM_Level = pmi(i).PM_Level
            pmui.PM_Name = pmi(i).PM_Name
            pmui.PM_PID = pmi(i).PM_PID
            pmui.PM_SelectImage = pmi(i).PM_SelectImage
            pmui.PM_Sub = pmi(i).PM_Sub
            pmui.PMU_Value = pmi(i).PMU_Value
            pmui.U_ID = TextEdit2.Text

            pmu.PermissionModuleUser_Update(pmui, TextEdit2.Text)


        Next
        '------------------------------------------------------------

        Dim j As Integer
        For j = 0 To pwsiL.Count - 1 '----復製模塊下操作權限

            pwsi.U_ID = TextEdit2.Text
            pwsi.PMS_ID = pwsiL(j).PMS_ID
            pwsi.PMWS_Value = pwsiL(j).PMWS_Value

            pwsc.PermissionModuleWarrantSub_Add(pwsi)

        Next
        MsgBox("復製權限成功！")

    End Sub

End Class
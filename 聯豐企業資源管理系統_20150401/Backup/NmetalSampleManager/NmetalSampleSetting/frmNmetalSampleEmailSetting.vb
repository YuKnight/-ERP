Imports LFERP.Library.NmetalSampleManager.NmetalSampleEmailSetting
Imports LFERP.SystemManager
Public Class frmNmetalSampleEmailSetting
    Dim ds As New DataSet
    Private Sub frmSampleEmailSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PowerUser()
        CreateTable()
        LoadTable()

        '操作日志 2014.4.21 劉祥松
        'G_LogInfo.FormName = Me.Text
        'G_LogInfo.OperationType = "進入"
        'InsertOperationLog()
    End Sub

    Private Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("EmailSetting")
            .Columns.Add("AutoID", GetType(Integer))
            .Columns.Add("Email_UserID", GetType(String))
            .Columns.Add("Email_UserName", GetType(String))
            .Columns.Add("Email", GetType(String))
            .Columns.Add("CheckOrder", GetType(Integer))
            .Columns.Add("StateAlarmTime", GetType(Integer))
            .Columns.Add("EndAlarmTime", GetType(Integer))
            .Columns.Add("Remark", GetType(String))
            '2014-04-18 姚駿

            .Columns.Add("StoreTime", GetType(String))
            .Columns.Add("CycleTime", GetType(String))

            '2014-08-13     Mark
            .Columns.Add("StoreCycleTime", GetType(Integer))
        End With
        Grid1.DataSource = ds.Tables("EmailSetting")
    End Sub

    Private Sub LoadTable()
        Dim pmeiCon As New NmetalSampleEmailSettingController
        Dim pmeiList As New List(Of NmetalSampleEmailSettingInfo)
        pmeiList = pmeiCon.NmetalSampleEmailSetting_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
        If pmeiList.Count > 0 Then
            For i As Integer = 0 To pmeiList.Count - 1
                Dim Row As DataRow
                Row = ds.Tables("EmailSetting").NewRow
                Row("AutoID") = pmeiList(i).AutoID
                Row("Email_UserID") = pmeiList(i).Email_UserID
                Row("Email_UserName") = pmeiList(i).Email_UserName
                Row("Email") = pmeiList(i).Email
                Row("CheckOrder") = pmeiList(i).CheckOrder
                Row("StateAlarmTime") = pmeiList(i).StateAlarmTime
                Row("EndAlarmTime") = pmeiList(i).EndAlarmTime
                Row("Remark") = pmeiList(i).Remark

                Row("StoreTime") = pmeiList(i).StoreTime
                Row("CycleTime") = pmeiList(i).CycleTime

                '2014-08-13     Mark
                Row("StoreCycleTime") = pmeiList(i).StoreCycleTime

                ds.Tables("EmailSetting").Rows.Add(Row)
            Next i
        End If
    End Sub

    Private Sub cmdAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click, cmdEdit.Click, cmdDel.Click, cmdRef.Click, cmdEdit1.Click
        Dim strEmail_UserName As String = String.Empty
        Dim strAutoID As String = String.Empty
        If GridView1.RowCount > 0 Then
            strEmail_UserName = GridView1.GetFocusedRowCellValue("Email_UserName").ToString
            strAutoID = GridView1.GetFocusedRowCellValue("AutoID").ToString
        End If

        Select Case sender.name
            Case "cmdAdd"
                Dim fr As New frmNmetalSampleEmailSettingAdd
                fr.EditItem = "Add"
                fr.EditValue = 0
                fr.ShowDialog()
                frmSampleEmailSetting_Load(Nothing, Nothing)
            Case "cmdDel"
                If GridView1.RowCount = 0 Then Exit Sub
                Dim pmei As New NmetalSampleEmailSettingInfo
                Dim pmeiCon As New NmetalSampleEmailSettingController
                '--------------------------------------------------------
                If MsgBox("確定要刪除郵箱信息嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.Yes Then
                    If pmeiCon.NmetalSampleEmailSetting_Delete(Nothing, strAutoID) Then
                        frmSampleEmailSetting_Load(Nothing, Nothing)
                    Else
                        MsgBox("刪除當前選定記錄失敗，請檢查原因！", 60, "提示")
                        Exit Sub
                    End If
                End If
            Case "cmdRef"
                frmSampleEmailSetting_Load(Nothing, Nothing)
            Case "cmdEdit"
                If GridView1.RowCount = 0 Then Exit Sub
                Dim fr As New frmNmetalSampleEmailSettingAdd
                fr.EditItem = "Edit"
                fr.EditValue = strAutoID
                fr.ShowDialog()
        End Select
    End Sub

    Sub PowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "861201")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdAdd.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "861202")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdEdit.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "861203")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdDel.Enabled = True
        End If
    End Sub

    Private Sub frmSampleEmailSetting_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        '操作日志 2014.4.21 劉祥松
        'G_LogInfo.FormName = Me.Text
        'UpdateOperationLog()
    End Sub
End Class
Imports LFERP.Library.MrpManager.MrpMaterialCode
Imports LFERP.Library.MrpManager.MrpSelect
Imports LFERP.Library.MrpManager.MrpSetting
Public Class frmMrpMaterialCodeMain
    Dim MMCcon As New MrpMaterialCodeController
    Private Sub frmMrpMaterialCodeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim msi As New List(Of MrpSettingInfo)
        Dim msc As New MrpSettingController

        Dim StrCheck As String = Nothing
        Dim StrUser As String = Nothing

        msi = msc.MrpSetting_GetList(InUserID)
        If msi.Count > 0 Then
            Select Case msi(0).materialCheckType
                Case "0,1"
                    StrCheck = Nothing
                Case "1"
                    StrCheck = "1"
                Case "0"
                    StrCheck = "0"
            End Select

            If msi(0).materialCreateUserID = "All" Then
                StrUser = Nothing
            Else
                StrUser = msi(0).materialCreateUserID
            End If

            Grid.DataSource = MMCcon.MrpMaterialCode_GetList(Nothing, msi(0).materialBeginDate, StrCheck, StrUser, Nothing)
        Else
            Grid.DataSource = MMCcon.MrpMaterialCode_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
        End If
        'Grid.DataSource = MMCcon.MrpMaterialCode_GetList(Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub cmsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click
        On Error Resume Next
        Dim fr As frmMrpMaterialCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMrpMaterialCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMrpMaterialCode
        fr.MdiParent = MDIMain
        fr.lblinfo.Text = "物料編碼表——新增"
        fr.EditItem = "Add"
        '獲得已經添加的物料編碼
        Dim M_Codelist As New List(Of String)
        Dim i As Integer
        For i = 0 To GridView1.RowCount - 1
            M_Codelist.Add(GridView1.GetRowCellValue(i, "M_Code").ToString)
            Dim a As String = GridView1.GetRowCellValue(i, "M_Code")
        Next
        fr.M_Code_List = M_Codelist
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsEdit.Click
        On Error Resume Next
        Dim StrM_Code As String = GridView1.GetFocusedRowCellValue("M_Code").ToString()
        If MMCcon.MrpMaterialCode_GetList(StrM_Code, Nothing, Nothing, Nothing, Nothing)(0).CheckBit = False Then
            Dim fr As frmMrpMaterialCode
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmMrpMaterialCode Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmMrpMaterialCode
            fr.MdiParent = MDIMain
            fr.lblinfo.Text = "物料編碼表——修改"
            fr.EditItem = "Edit"
            fr.EditValue = StrM_Code
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("已經審核不能修改！", 60, "提示")
        End If
    End Sub

    Private Sub cmsDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDel.Click
        Dim StrAutoID As String = GridView1.GetFocusedRowCellValue("AutoID").ToString()
        Dim StrM_Code As String = GridView1.GetFocusedRowCellValue("M_Code").ToString()
        If MMCcon.MrpMaterialCode_GetList(StrM_Code, Nothing, Nothing, Nothing, Nothing)(0).CheckBit = False Then
            Dim result As Windows.Forms.DialogResult = MessageBox.Show("確認刪除該信息么？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If (result = Windows.Forms.DialogResult.Yes) Then
                If MMCcon.MrpMaterialCode_Delete(StrAutoID) = True Then
                    cmsReflash_Click(Nothing, Nothing)
                Else
                    MsgBox("刪除失敗！", 60, "提示")
                End If
            End If
        Else
            MsgBox("已經審核不能刪除！", 60, "提示")
        End If
    End Sub

    Private Sub cmsReflash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsReflash.Click
        frmMrpMaterialCodeMain_Load(Nothing, Nothing)
    End Sub

    Private Sub cmsLook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsLook.Click
        On Error Resume Next
        Dim fr As frmMrpMaterialCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMrpMaterialCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMrpMaterialCode
        fr.MdiParent = MDIMain
        fr.lblinfo.Text = "物料編碼表——查看"
        fr.EditItem = "Look"
        fr.EditValue = GridView1.GetFocusedRowCellValue("M_Code").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCheck.Click
        On Error Resume Next
        Dim fr As frmMrpMaterialCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMrpMaterialCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMrpMaterialCode
        fr.MdiParent = MDIMain
        fr.lblinfo.Text = "物料編碼表——審核"
        fr.EditItem = "Check"
        fr.EditValue = GridView1.GetFocusedRowCellValue("M_Code").ToString
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsPrint.Click
        Dim dss As New DataSet
        Dim ltc As New CollectionToDataSet
        'Dim strSO_ID As String = GridView1.GetFocusedRowCellValue("AutoId").ToString
        ltc.CollToDataSet(dss, "MrpMaterialCode", MMCcon.MrpMaterialCode_GetList(Nothing, Nothing, Nothing, Nothing, Nothing))
        PreviewRPT(dss, "rptMrpMaterialCode", "庫存記錄表", True, True)
        ltc = Nothing
        Me.Close()
    End Sub

    Private Sub cmsFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsFind.Click
        Dim fr As New frmMrpSelect
        fr = New frmMrpSelect
        fr.EditItem = "MrpMaterialCode"
        'fr.EditValue = "MrpMaterialCode"
        fr.lblinfo.Text = "物料編碼表——查詢"
        fr.ShowDialog()
        Select Case tempValue
            Case "固定樣式"
                Grid.DataSource = MMCcon.MrpMaterialCode_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing)
            Case "自定義樣式"
                Dim MScon As New MrpSelect_Controller
                Grid.DataSource = MScon.MrpMaterialCode_Select_GetList("MrpMaterialCode", tempValue2)
        End Select
    End Sub
End Class
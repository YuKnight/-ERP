Imports LFERP.Library.Outward

Public Class frmOutwardChangeMain

    Dim occ As New OutwardChangeControl

    Private Sub frmOutwardChangeMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Grid1.DataSource = occ.OutwardChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, False)
    End Sub
    '設置用戶此模塊權限
    Sub LoadPowerUser()


    End Sub

    Private Sub popChangeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmOutwardChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOutwardChange Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "更改單"
        fr = New frmOutwardChange
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub
    '修改
    Private Sub popChangeEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeEdit.Click
        On Error Resume Next
        Edit = True
        If GridView1.RowCount = 0 Then Exit Sub
        Dim ci1 As List(Of OutwardChangeInfo)
        ci1 = occ.OutwardChange_GetList(GridView1.GetFocusedRowCellValue("OC_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing)
        If ci1(0).OC_Check = True Then
            MsgBox("此更改單已審核，不允許修改")
            Exit Sub
        Else
            Dim fr As frmOutwardChange
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmOutwardChange Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            tempValue = "更改單"
            tempValue3 = GridView1.GetFocusedRowCellValue("OC_NO").ToString
            fr = New frmOutwardChange
            fr.MdiParent = MDIMain
            fr.Show()
        End If
    End Sub
    '刪除
    Private Sub popChangeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim ci1 As List(Of OutwardChangeInfo)
        ci1 = occ.OutwardChange_GetList(GridView1.GetFocusedRowCellValue("OC_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing)
        If ci1(0).OC_Check = True Then
            MsgBox("此更改單已審核,不允許刪除！")
            Exit Sub
        Else
            If MsgBox("確定刪除單號為" & GridView1.GetFocusedRowCellValue("OC_NO").ToString & "的全部記錄？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If occ.OutwardChange_Delete(GridView1.GetFocusedRowCellValue("OC_NO").ToString, Nothing) = True Then

                    '*----------------若涉及到附檔則需刪除此更改單中附檔信息---------------------*

                    '*---------------------------------------------------------------------------*

                    MsgBox("刪除成功！")
                    Grid1.DataSource = occ.OutwardChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, False)
                Else
                    MsgBox("刪除失敗，請檢查原因！")
                    Exit Sub
                End If
            End If
        End If
    End Sub
    '查看
    Private Sub popChangeView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeView.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmOutwardChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOutwardChange Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "PreView"
        tempValue3 = GridView1.GetFocusedRowCellValue("OC_NO").ToString
        fr = New frmOutwardChange
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub
    '審核
    Private Sub popChangeCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeCheck.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmOutwardChange
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmOutwardChange Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue = "Check"
        tempValue3 = GridView1.GetFocusedRowCellValue("OC_NO").ToString
        fr = New frmOutwardChange
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub
    '刷新
    Private Sub popChangeRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeRef.Click
        Grid1.DataSource = occ.OutwardChange_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, False)
    End Sub
    '查詢
    Private Sub popChangeSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeSeek.Click
        Dim myfrm As New frmOutwardChangeSelect
        myfrm.ShowDialog()

        Grid1.DataSource = occ.OutwardChange_GetList(tempValue, tempValue2, tempValue3, tempValue4, tempValue5, tempValue6)

        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue5 = ""
        tempValue6 = ""

    End Sub
    '當前更改單一覽表
    Private Sub popChangePrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangePrint.Click

    End Sub
    '載入附檔
    Private Sub popChangeFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popChangeFile.Click

    End Sub
End Class
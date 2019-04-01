Imports LFERP
Imports LFERP.Library
Imports LFERP.Library.Purchase.Quotation
Imports System
Imports LFERP.SystemManager
Public Class frmQuotationFWMain
    Dim qt As New Purchase.Quotation.QuotationController
    Dim qi As New Purchase.Quotation.QuotationInfo

    Private Sub MenuItemAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAdd.Click
        On Error Resume Next
        Edit = False
        Dim fr As frmQuotationFW
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmQuotationFW Then
                fr.Activate()
                Exit Sub
            End If
        Next

        tempValue2 = "範圍報價"
        fr = New frmQuotationFW
        fr.MdiParent = MDIMain
        fr.Show()

    End Sub

    Private Sub MenuItemEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemEdit.Click
        On Error Resume Next
        'Dim qiL As List(Of Purchase.Quotation.QuotationInfo)
        'qiL = qt.QuotationFW_GetList(Nothing, Nothing, GridView1.GetFocusedRowCellValue("QuotationID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'If qiL(0).Checked Then
        '    MsgBox("此報價流程單已審核，不允許修改！")
        '    Exit Sub
        'End If
        Edit = True
        Dim fr As frmQuotationFW
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmQuotationFW Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "範圍報價"
        tempValue3 = GridView1.GetFocusedRowCellValue("QuotationID")
        fr = New frmQuotationFW
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub frmQuotationFWMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        PowerUser()
    End Sub
    '設置權限
    Sub PowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400701")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then MenuItemAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400702")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then MenuItemEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400703")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then MenuItemDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400704")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then MenuItemCheck.Enabled = True
        End If

    End Sub
    Private Sub MenuItemDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim qiL As List(Of Purchase.Quotation.QuotationInfo)
        qiL = qt.QuotationFW_GetList(Nothing, Nothing, GridView1.GetFocusedRowCellValue("QuotationID"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If qiL(0).Checked Then
            MsgBox("此報價流程單已審核，不允許刪除！")
            Exit Sub
        End If
        Dim strA As String, strB As String
        strA = GridView1.GetFocusedRowCellValue("CodeMain")
        strB = GridView1.GetFocusedRowCellValue("QuotationID")
        If MsgBox("你確定刪除範圍報價單號為  '" & strA & "'  的全部記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If qt.QuotationFW_Delete(strB) Then
                GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub MenuItemCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCheck.Click
        On Error Resume Next
        Dim fr As frmQuotationFW
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmQuotationFW Then
                fr.Activate()
                Exit Sub
            End If
        Next
        tempValue2 = "範圍報價審核"
        tempValue3 = GridView1.GetFocusedRowCellValue("QuotationID")
        fr = New frmQuotationFW
        fr.MdiParent = MDIMain
        fr.Show()
    End Sub

    Private Sub MenuItemRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemRel.Click
        GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub MenuItemSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemSelect.Click
        Dim fr As New frmQuotationFWSelect
        fr.ShowDialog()
        Select Case tempValue
            Case "1"
                GridControl1.DataSource = qt.QuotationFW_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "2"
                GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "3"
                GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing)
            Case "4"
                GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing)
            Case "5"
                GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing)
            Case "6"
                GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing)
            Case "7"
                GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "8"
                GridControl1.DataSource = qt.QuotationFW_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2)
        End Select
    End Sub
End Class
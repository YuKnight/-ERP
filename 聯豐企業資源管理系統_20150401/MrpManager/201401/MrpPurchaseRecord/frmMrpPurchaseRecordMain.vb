Imports System
Imports LFERP.SystemManager
Imports LFERP.Library.Product
Imports LFERP.Library.Production.ProuctionWareOutB
Imports LFERP.Library.MrpManager.MrpPurchaseRecord
Public Class frmMrpPurchaseRecordMain
    Dim mpreCon As New MrpPurchaseRecordEntryController
    Dim mprCon As New MrpPurchaseRecordController
    Private Sub frmMrpPurchaseRecordMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridControl1.DataSource = mprCon.MrpPurchaseRecord_GetList(Nothing)
    End Sub
    Private Sub tsmNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmNew.Click
        On Error Resume Next
        Dim fr As frmMrpPurchaseRecord
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMrpPurchaseRecord Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMrpPurchaseRecord
        fr.Type = "Add"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub tsmDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelete.Click
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If
        Dim strDelect As String
        Try
            strDelect = GridView1.GetFocusedRowCellValue("MrpPurchaseID").ToString()
            mprCon.MrpPurchaseRecord_Delete(Nothing, GridView1.GetFocusedRowCellValue("AutoID").ToString())
            mpreCon.MrpPurchaseRecordEntry_Delete(strDelect, Nothing)
            GridControl1.DataSource = mprCon.MrpPurchaseRecord_GetList(Nothing)
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub tsmEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmEdit.Click
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If
        On Error Resume Next
        Dim fr As frmMrpPurchaseRecord
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMrpPurchaseRecord Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMrpPurchaseRecord
        fr.Type = "Edit"
        fr.MrpPurchaseID = GridView1.GetFocusedRowCellValue("MrpPurchaseID")
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub tsmView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmView.Click
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If
        On Error Resume Next
        Dim fr As frmMrpPurchaseRecord
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMrpPurchaseRecord Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMrpPurchaseRecord
        fr.Type = "View"
        fr.MrpPurchaseID = GridView1.GetFocusedRowCellValue("MrpPurchaseID")
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub tsmCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmCheck.Click
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If
        On Error Resume Next
        Dim fr As frmMrpPurchaseRecord
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMrpPurchaseRecord Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMrpPurchaseRecord
        fr.Type = "Check"
        fr.MrpPurchaseID = GridView1.GetFocusedRowCellValue("MrpPurchaseID")
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub tsmRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmRefresh.Click
        GridControl1.DataSource = mprCon.MrpPurchaseRecord_GetList(Nothing)
    End Sub

    Private Sub tsmPaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmPaint.Click

    End Sub

    Private Sub tsm_Excel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Excel.Click

    End Sub

    Private Sub tsmFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmFind.Click

    End Sub

    Private Sub GridView1_FocusedRowChanged_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        GridControl2.DataSource = mpreCon.MrpPurchaseRecordEntry_GetList(GridView1.GetFocusedRowCellValue("MrpPurchaseID"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim fr As frmMrpPurchase
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMrpPurchase Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMrpPurchase
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
End Class
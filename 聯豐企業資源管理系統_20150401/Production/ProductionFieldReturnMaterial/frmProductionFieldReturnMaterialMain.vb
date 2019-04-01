Imports LFERP.Library.Production.ProductionFieldReturnMaterial
Imports LFERP.SystemManager
Imports LFERP.DataSetting

Public Class frmProductionFieldReturnMaterialMain

    Private Sub frmProductionFieldReturnMaterialMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PowerUser()
        cmsProductionRef_Click(Nothing, Nothing)
        DateFill(0)
    End Sub

    Private Sub cmsProductionRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionRef.Click
        Dim PC As New ProductionFieldReturnMaterialControl

        Dim WareSelectIn As String = FunWareSelect("8802006")
        Dim WareSelectOut As String = FunDepSelect()

        Me.Grid.DataSource = PC.ProductionFieldReturnMaterial_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, WareSelectOut, WareSelectIn, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub ToolStripRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripRefresh.Click
        Dim PC As New ProductionFieldReturnMaterialControl

        Dim WareSelectIn As String = FunWareSelect("8802006")
        Dim WareSelectOut As String = FunDepSelect()
        Me.Grid2.DataSource = PC.ProductionFieldReturnMaterial_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, WareSelectOut, WareSelectIn, Nothing, Nothing, Nothing, True, Nothing)
    End Sub

    Private Sub cmsProductionAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionAdd.Click
        On Error Resume Next

        Dim fr As frmProductionFieldReturnMaterial
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldReturnMaterial Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionFieldReturnMaterial
        fr.EditItem = "Add"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsProductionEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionEdit.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As New List(Of ProductionFieldReturnMaterialInfo)
        Dim pkc As New ProductionFieldReturnMaterialControl
        pi = pkc.ProductionFieldReturnMaterial_GetList(GridView1.GetFocusedRowCellValue("R_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi.Count <= 0 Then
            Exit Sub
        End If

        If pi(0).RCheck = True Then
            MsgBox("此單已審核,不允許修改!")
            Exit Sub
        End If

        On Error Resume Next
        Dim fr As frmProductionFieldReturnMaterial
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldReturnMaterial Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionFieldReturnMaterial
        fr.EditItem = "Update"
        fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsProductionDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim pi As New List(Of ProductionFieldReturnMaterialInfo)
        Dim pkc As New ProductionFieldReturnMaterialControl
        pi = pkc.ProductionFieldReturnMaterial_GetList(GridView1.GetFocusedRowCellValue("R_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi.Count <= 0 Then
            Exit Sub
        End If

        If pi(0).RCheck = True Then
            MsgBox("此單已審核,不允許刪除!")
            Exit Sub
        End If

        
        If MsgBox("確定要刪除編號為" & GridView1.GetFocusedRowCellValue("R_NO").ToString & "的退料單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then
            If pkc.ProductionFieldReturnMaterial_Delete(GridView1.GetFocusedRowCellValue("R_NO").ToString) = True Then
                MsgBox("刪除當前退料單成功!")
            Else
                MsgBox("刪除失敗,請檢查原因!")
            End If

            cmsProductionRef_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub cmsProductionCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionCheck.Click
        ''修改
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As New List(Of ProductionFieldReturnMaterialInfo)
        Dim pkc As New ProductionFieldReturnMaterialControl
        pi = pkc.ProductionFieldReturnMaterial_GetList(GridView1.GetFocusedRowCellValue("R_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi.Count <= 0 Then
            Exit Sub
        End If

        If pi(0).RInCheck = True Then
            MsgBox("此單已收料確認,不允許審核!")
            Exit Sub
        End If
        On Error Resume Next
        Dim fr As frmProductionFieldReturnMaterial
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldReturnMaterial Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionFieldReturnMaterial
        fr.EditItem = "Check"
        fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmsProductionView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionView.Click
        If GridView1.RowCount = 0 Then Exit Sub

        On Error Resume Next

        Dim fr As frmProductionFieldReturnMaterial
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldReturnMaterial Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionFieldReturnMaterial
        fr.EditItem = "View"
        fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Sub PowerUser()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802001")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionAdd.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802002")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionEdit.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802003")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionDel.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802004")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionCheck.Enabled = True
            End If
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802005")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                cmsProductionPrint.Enabled = True
            End If
        End If

        '----------------------------------------------------------------------
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "8802007")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                ToolStripInOK.Enabled = True
            End If
        End If

    End Sub

    Function FunWareSelect(ByVal FunWare As String) As String
        Dim a As New LFERP.SystemManager.PermissionModuleWarrantSubController
        Dim b As New List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)
        b = a.PermissionModuleWarrantSub_GetList(InUserID, FunWare)
        Dim i, n As Integer
        Dim arr(n) As String

        Dim WareSelect As String = ""
        If b.Count > 0 Then
            arr = Split(b.Item(0).PMWS_Value, ",")
            n = Len(Replace(b.Item(0).PMWS_Value, ",", "," & "*")) - Len(b.Item(0).PMWS_Value)
            For i = 0 To n
                If i = 0 Then
                    WareSelect = "'" & arr(i) & "'"
                Else
                    WareSelect = WareSelect & ",'" & arr(i) & "'"
                End If
            Next
        End If
        FunWareSelect = WareSelect
    End Function


    Function FunDepSelect() As String

        FunDepSelect = ""

        Dim fc As New LFERP.Library.ProductionController.ProductionFieldControl
        Dim fl As New List(Of LFERP.Library.ProductionController.ProductionFieldControlInfo)

        fl = fc.ProductionFieldControl_GetList(InUserID, Nothing)
        Dim i As Integer

        If fl.Count <= 0 Then
            Exit Function
        End If

        For i = 0 To fl.Count - 1
            If i = 0 Then
                FunDepSelect = "'" & fl(i).ControlDep & "'"
            Else
                FunDepSelect = FunDepSelect & ",'" & fl(i).ControlDep & "'"
            End If
        Next

    End Function


    Private Sub ToolStripView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripView.Click
        If GridView2.RowCount = 0 Then Exit Sub

        On Error Resume Next

        Dim fr As frmProductionFieldReturnMaterial
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldReturnMaterial Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionFieldReturnMaterial
        fr.EditItem = "View"
        fr.EditValue = GridView1.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub ToolStripInOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripInOK.Click
        ''修改
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub

        Dim pi As New List(Of ProductionFieldReturnMaterialInfo)
        Dim pkc As New ProductionFieldReturnMaterialControl
        pi = pkc.ProductionFieldReturnMaterial_GetList(GridView2.GetFocusedRowCellValue("R_NO").ToString, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pi.Count <= 0 Then
            Exit Sub
        End If

        If pi(0).RCheck = False Then
            MsgBox("此單已未審核,不允許收料!")
            Exit Sub
        End If

        If pi(0).RInCheck = True Then
            MsgBox("此單已收料確認,不允許再收料!")
            Exit Sub
        End If
        On Error Resume Next
        Dim fr As frmProductionFieldReturnMaterial
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionFieldReturnMaterial Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmProductionFieldReturnMaterial
        fr.EditItem = "InCheck"
        fr.EditValue = GridView2.GetFocusedRowCellValue("R_NO").ToString
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub



    Private Sub DateFill(ByVal indexA As Integer)
        Dim PC As New ProductionFieldReturnMaterialControl
        Dim WareSelectIn As String = FunWareSelect("8802006")
        Dim WareSelectOut As String = FunDepSelect()

        Select Case indexA
            Case 0
                '-------------------------------------------------
                Dim IntCheck As Integer = 0
                IntCheck = PC.ProductionFieldReturnMaterial_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, WareSelectOut, WareSelectIn, Nothing, Nothing, Nothing, False, Nothing).Count
                If IntCheck > 0 Then
                    lblCheck.Text = "(" + CStr(IntCheck) + "筆)" + "末審核"
                Else
                    lblCheck.Text = String.Empty
                End If

                cmsProductionRef_Click(Nothing, Nothing)
            Case 1
                '-------------------------------------------------
                Dim IntCheck As Integer = 0
                IntCheck = PC.ProductionFieldReturnMaterial_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, WareSelectOut, WareSelectIn, Nothing, Nothing, Nothing, True, False).Count
                If IntCheck > 0 Then
                    lblCheck.Text = "(" + CStr(IntCheck) + "筆)" + "末收料"
                Else
                    lblCheck.Text = String.Empty
                End If

                ToolStripRefresh_Click(Nothing, Nothing)

        End Select
    End Sub

    Private Sub XtraTabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XtraTabControl1.Click
        DateFill(Me.XtraTabControl1.SelectedTabPageIndex)
    End Sub

    Private Sub cmsProductionSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsProductionSelect.Click
        frmProductionFieldReturnMaterialSelect.ShowDialog()
        Dim WareSelectIn As String = FunWareSelect("8802006")
        Dim WareSelectOut As String = FunDepSelect()

        If tempValue = Nothing Then Exit Sub

        Dim pf As New ProductionFieldReturnMaterialControl
        Me.Grid.DataSource = pf.ProductionFieldReturnMaterial_GetList(tempValue2, Nothing, tempValue4, Nothing, Nothing, WareSelectOut, WareSelectIn, Nothing, tempValue6, tempValue7, tempValue5, Nothing)
        frmProductionFieldReturnMaterialSelect.Dispose()
    End Sub

    Private Sub ToolStripFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripFind.Click
        frmProductionFieldReturnMaterialSelect.ShowDialog()
        Dim WareSelectIn As String = FunWareSelect("8802006")
        Dim WareSelectOut As String = FunDepSelect()

        If tempValue = Nothing Then Exit Sub

        Dim pf As New ProductionFieldReturnMaterialControl
        Me.Grid2.DataSource = pf.ProductionFieldReturnMaterial_GetList(tempValue2, Nothing, tempValue4, Nothing, Nothing, WareSelectOut, WareSelectIn, Nothing, tempValue6, tempValue7, True, tempValue5)
        frmProductionFieldReturnMaterialSelect.Dispose()
    End Sub
End Class
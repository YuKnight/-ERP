Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.SystemManager

Public Class frmMaterialParam
    Dim MPController As New MaterialParamController
    Dim mtc As New Material.MaterialTypeController

    Dim dt As New DataTable
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub frmMaterialParam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '不自動增加所有資料行
        On Error Resume Next
        Me.dGrid.AutoGenerateColumns = False
        Me.dGrid2.AutoGenerateColumns = False
        dGrid.DataSource = MPController.MaterialParamType_GetList()

        dt.Rows.Clear()
        dt.Columns.Add("ParamID")
        dt.Columns.Add("ParamName")
        dt.Columns.Add("ParamGauge")
        'dt.NewRow()


        dGrid2.DataSource = dt



        '   mtc.LoadNodes(tv1, ErpUser.MaterialType)
        '' 為磨刀部
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100201")
        If pmwiL.Count > 0 Then
            If pmwiL(0).PMWS_Value.ToString <> "" Then
                mtc.LoadNodes(tv1, pmwiL(0).PMWS_Value.ToString)    '只選擇成品類
            Else
                mtc.LoadNodes(tv1, "10,20,30")
            End If
        Else
            mtc.LoadNodes(tv1, "10,20,30")
        End If


    End Sub


    Sub ListToDataTable(ByVal tList As List(Of MaterialParamInfo), ByVal datatable As DataTable)
        Dim i As Integer
        While dt.Rows.Count > 0
            datatable.Rows.Remove(datatable.Rows(0))
        End While
        For i = 0 To tList.Count - 1
            RowAdd(tList(i).ParamID, tList(i).ParamName, tList(i).ParamGauge)
        Next

    End Sub

    Private Sub dGrid2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGrid2.CellContentClick

    End Sub

    Sub RowAdd(ByVal id As Integer, ByVal name As String, ByVal gauge As String)
        Dim dtRow As DataRow
        dtRow = dt.NewRow
        dtRow(0) = id
        dtRow(1) = name
        dtRow(2) = gauge
        dt.Rows.Add(dtRow)

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        RowAdd(dGrid2.RowCount + 1, dGrid.CurrentRow.Cells("ParamName").Value.ToString, dGrid.CurrentRow.Cells("ParamGauge").Value.ToString)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        On Error Resume Next
        dt.Rows(Me.BindingContext(dt).Position()).Delete()


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If tv1.SelectedNode.Level = 2 Or tv1.SelectedNode.Level = 3 Then
            MPController.MaterialParam_Delete(tv1.SelectedNode.Tag)
            Dim i As Integer
            For i = 0 To dt.Rows.Count - 1
                Dim objInfo As New MaterialParamInfo
                objInfo.Type3ID = tv1.SelectedNode.Tag
                objInfo.ParamID = i
                objInfo.ParamName = dt.Rows(i)("ParamName")
                objInfo.ParamGauge = dt.Rows(i)("ParamGauge")
                MPController.MaterialParam_Add(objInfo)
            Next

            MsgBox("保存成功", , "提示")
        End If



    End Sub

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect

        If tv1.SelectedNode.Level = 2 Or tv1.SelectedNode.Level = 3 Then
            'MsgBox(tv1.SelectedNode.Tag)
            cmdSave.Enabled = True
            ListToDataTable(MPController.MaterialParam_Get(tv1.SelectedNode.Tag), dt)
        Else
            cmdSave.Enabled = False

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        While dt.Rows.Count > 0
            dt.Rows.Remove(dt.Rows(0))
        End While
    End Sub



    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click

        '更新物料類型及參數
        dGrid.DataSource = MPController.MaterialParamType_GetList()
        'mtc.LoadNodes(tv1, ErpUser.MaterialType)

        '' 為磨刀部
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100201")
        If pmwiL.Count > 0 Then
            If pmwiL(0).PMWS_Value.ToString <> "" Then
                mtc.LoadNodes(tv1, pmwiL(0).PMWS_Value.ToString)    '只選擇成品類
            Else
                mtc.LoadNodes(tv1, "10,20,30")
            End If
        Else
            mtc.LoadNodes(tv1, "10,20,30")
        End If
    End Sub
End Class
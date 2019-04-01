Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.Library.Material
Imports LFERP.SystemManager.SystemUser
Imports LFERP.DataSetting

Public Class frmWareInventorySafeRpt

    Dim strWH As String

    Private Sub frmWareInventorySafeRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strWH = tempValue3

    End Sub

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        frmWareHouseSelect.SelectWareID = ""
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = Me.Left + ButtonEdit1.Left + 2
        frmWareHouseSelect.Top = Me.Top + ButtonEdit1.Top + ButtonEdit1.Height + 21
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            ButtonEdit1.Text = frmWareHouseSelect.SelectWareID
            '      txtWH.Enabled = False

        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If ButtonEdit1.EditValue = "" Then
            MsgBox("請選擇倉庫!", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If strWH = "50080601" Then
            Dim ds As New DataSet
            Dim ltc As New CollectionToDataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc2 As New CollectionToDataSet

            Dim uit As New UnitController
            Dim wh As New WareHouseController
            Dim wic As New WareInventory.WareInventoryMTController

            ds.Tables.Clear()

            If wic.WareInventory_GetList(Nothing, ButtonEdit1.EditValue).Count = 0 Then
                MsgBox("當前倉庫無物料記錄!")
                Exit Sub
            End If
            ltc.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            ltc1.CollToDataSet(ds, "Unit", uit.GetUnitList(Nothing))
            ltc2.CollToDataSet(ds, "WareInventory", wic.WareInventory_GetList(Nothing, ButtonEdit1.EditValue))

            PreviewRPT(ds, "rptWareInventorySafe", "安全庫存設置一覽表", True, True)
            ltc = Nothing
            ltc1 = Nothing
            ltc2 = Nothing

        ElseIf strWH = "50080701" Then '需申購物料一覽表
            Dim ds As New DataSet
            Dim ltc As New CollectionToDataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc2 As New CollectionToDataSet

            Dim uit As New UnitController
            Dim wh As New WareHouseController
            Dim wic As New WareInventory.WareInventoryMTController

            ds.Tables.Clear()

            If wic.WareInventory_GetList2(Nothing, ButtonEdit1.EditValue).Count = 0 Then
                MsgBox("當前倉庫無物料記錄!")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            'ltc1.CollToDataSet(ds, "Unit", uit.GetUnitList(Nothing))
            ltc2.CollToDataSet(ds, "WareInventory", wic.WareInventory_GetList2(Nothing, ButtonEdit1.EditValue))

            PreviewRPT(ds, "rptWareInventoryApplySafe", "需申購物料一覽表", True, True)
            ltc = Nothing
            ltc1 = Nothing
            ltc2 = Nothing
        End If

        tempValue3 = ""
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

End Class
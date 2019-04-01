Imports LFERP.Library.ProductionWareHouse
Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.DataSetting


Public Class frmDepartmentHouseMain

    Dim strID As String
    Dim ui As List(Of UserPowerInfo)
    Dim uc As New UserPowerControl
    Dim pdc As New ProductionDPTWareInventoryControl
    Public strDPT As String

    Private Sub frmDepartmentHouseMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If InUserID = "admin" Then
            GridColumn5.Visible = True
        End If


        Dim fc As New LFERP.Library.ProductionController.ProductionFieldControl
        GridControl2.DataSource = fc.ProductionFieldControl_GetList(InUserID, Nothing)

        GridView2.Focus()

        strDPT = GridView2.GetFocusedRowCellValue("ControlDep").ToString()

    End Sub

    Private Sub GridControl2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridControl2.MouseUp

        If GridView2.RowCount = 0 Then Exit Sub
        strDPT = GridView2.GetFocusedRowCellValue("ControlDep").ToString()

        Grid.DataSource = pdc.ProductionDPTWareInventory_GetList1(strDPT, Nothing, Nothing)

    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click

    End Sub
End Class
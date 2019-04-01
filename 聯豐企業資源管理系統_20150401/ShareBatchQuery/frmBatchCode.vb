Imports LFERP.Library.Orders

Public Class frmBatchCode

    Dim ds As New DataSet

    Private Sub frmBatchCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = tempValue3
        tempValue3 = ""
        CreateTable()
        LoadDataOrdersBom(Label2.Text)
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("Prod_Mounting_New")

            .Columns.Add("AutoID", GetType(String))

            .Columns.Add("PM_M_Code", GetType(String)) '聯豐編號
            .Columns.Add("PM_ID", GetType(Integer))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_CodePID", GetType(String))
            .Columns.Add("PM_Qty", GetType(Integer))
            .Columns.Add("PM_MakeRemark", GetType(String))
            .Columns.Add("PM_Make", GetType(Boolean))
            .Columns.Add("PM_Check", GetType(Boolean))
            .Columns.Add("M_Supplier", GetType(String))
            .Columns.Add("M_SupplierNo", GetType(String))
            .Columns.Add("IsNew", GetType(Boolean))    '是否新增

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("PM_LVL", GetType(Integer))
            .Columns.Add("PM_Key", GetType(String))
            .Columns.Add("PM_PID", GetType(String))
            .Columns.Add("M_CodeType", GetType(String))
            .Columns.Add("M_CodeMouldNO", GetType(String))
            .Columns.Add("OB_MakeDepartment", GetType(String))
            .Columns.Add("OB_MModeCusterNO", GetType(String))

        End With
        Grid.DataSource = ds.Tables("Prod_Mounting_New")

    End Sub

    Sub LoadDataOrdersBom(ByVal BatchID As String)
        '載入物料清單

        Dim obc As New OrdersBomController
        Dim tlist As List(Of OrdersBomInfo)
        ds.Tables("Prod_Mounting_New").Rows.Clear()

        tlist = obc.OrdersBom_GetList(Nothing, BatchID, Nothing, Nothing)
        If tlist Is Nothing Then Exit Sub

        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To tlist.Count - 1
            row = ds.Tables("Prod_Mounting_New").NewRow

            row("AutoID") = tlist(i).AutoID
            row("PM_ID") = 0
            row("M_Code") = tlist(i).M_Code
            row("PM_Qty") = tlist(i).OB_Qty
            row("PM_MakeRemark") = tlist(i).OB_MakeRemark
            row("PM_Make") = tlist(i).OB_Make

            row("M_Supplier") = tlist(i).OB_Supplier
            row("M_SupplierNo") = tlist(i).OB_SupplierNo
            row("IsNew") = False
            row("M_Name") = tlist(i).M_Name
            row("M_Gauge") = tlist(i).M_Gauge

            row("PM_Check") = tlist(i).OB_AccountCheck '通過批次審核后單個批次物料審核信息

            '    row("M_Unit") = tList(i).M_Unit
            '  row("PM_LVL") = tList(i).PM_LVL
            row("PM_Key") = tlist(i).OB_Key
            row("PM_PID") = tlist(i).OB_PID
            row("PM_LVL") = tlist(i).PM_LVL
            row("M_CodeType") = tlist(i).M_CodeType
            row("M_CodeMouldNO") = tlist(i).M_CodeMouldNO
            row("OB_MakeDepartment") = tlist(i).OB_MakeDepartment
            row("OB_MModeCusterNO") = tlist(i).OB_MModeCusterNO
            ds.Tables("Prod_Mounting_New").Rows.Add(row)
        Next

        Grid.ExpandAll()

        If ds.Tables("Prod_Mounting_New").Rows.Count = 0 Then
            MsgBox("未載入產品配件資料或產品資料配件未建立！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)

        End If


    End Sub
    Private Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If Grid.Nodes.Count = 0 Then Exit Sub
        SetSelectBatchGrid(Label2.Text, Grid.FocusedNode.Item("M_Code").ToString, tcList.SelectedTabPage.Text, GridSub)
    End Sub
    Private Sub tcList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcList.Click
        SetSelectBatchGrid(Label2.Text, Grid.FocusedNode.Item("M_Code").ToString, tcList.SelectedTabPage.Text, GridSub)
    End Sub

End Class
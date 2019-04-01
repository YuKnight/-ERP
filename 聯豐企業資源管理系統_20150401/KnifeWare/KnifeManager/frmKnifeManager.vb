Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.Library.Product
Imports LFERP.Library.KnifeWare
Public Class frmKnifeManager

    Dim ds As New DataSet

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tv1.Nodes.Clear()
        tv2.Nodes.Clear()

        Dim mtc As New Material.MaterialTypeController
        mtc.LoadNodes(tv1, "60")    '只選擇成品類
        tv1.ExpandAll()
        tv1.ShowRootLines = True
        ''--------------------------------------------
        tv1.SelectedNode = tv1.Nodes(0)

        '
        LabM_Name.Text = ""
        LabGuiGe.Text = ""
        'CompanyID
        CreateTables()

    End Sub

#Region "載入自定義規格"

    Function LoadDefault(ByVal tv As TreeView, ByVal Type3ID As String, ByVal Type3IDName As String) As Boolean
        tv.Nodes.Clear()
        Dim kc As New KnifeTypeGroupControl
        Dim kl As New List(Of KnifeTypeGroupInfo)
        kl = kc.KnifeMaterialCode_DistGetList(Nothing, Type3ID)

        If kl.Count <= 0 Then
            Exit Function
        End If

        Dim j As Integer
        'tv.Nodes.Add(Type3IDName).Tag = Type3ID
        For j = 0 To kl.Count - 1
            '查詢出父節點
            Dim kpc As New KnifeTypeGroupControl
            Dim kpl As New List(Of KnifeTypeGroupInfo)
            kpl = kpc.KnifeTypeGroup_GetList(Nothing, Nothing, Nothing, kl(j).KnifeID)

            tv.Nodes.Add(kpl(0).KnifePIDName).Tag = kpl(0).KnifePID
            '-----------------------------------------
            Dim tNodes As New TreeNode
            tNodes.Tag = kl(j).KnifeID
            tNodes.Text = kl(j).KnifeIDName
            tv.Nodes.Item(j).Nodes.Add(tNodes)
        Next

        tv.ExpandAll()

    End Function

#End Region

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        If Len(tv1.SelectedNode.Tag) = 11 Then
            LabMsg.Text = "刀具信息一覽表 [" & tv1.SelectedNode.Text & "]"
            LoadDefault(tv2, tv1.SelectedNode.Tag, tv1.SelectedNode.Text)
            'Dim wc As New KnifeWareInventorySubControl
            'Me.GridInvent.DataSource = wc.KnifeWareInventory_GetList(tv1.SelectedNode.Tag, Nothing, Nothing, Nothing)

            Dim WC As New KnifeManagerControl
            Me.GridInvent.DataSource = WC.KnifeManagerInventorySub_GetList(Nothing, Nothing, tv1.SelectedNode.Tag)

        End If

    End Sub

    Private Sub tv2_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv2.AfterSelect
        If Len(tv2.SelectedNode.Tag) = 6 Then
            LabMsg.Text = "刀具信息一覽表 [" & tv1.SelectedNode.Text & " | " & tv2.SelectedNode.Text & "]"
            'Dim wc As New KnifeWareInventorySubControl
            'Me.GridInvent.DataSource = wc.KnifeWareInventory_GetList(Nothing, Nothing, Nothing, tv2.SelectedNode.Tag)
            Dim WC As New KnifeManagerControl
            Me.GridInvent.DataSource = WC.KnifeManagerInventorySub_GetList(Nothing, tv2.SelectedNode.Tag, Nothing)
        End If
    End Sub

#Region "顯示圖片"
    Function LoadPicture(ByVal PM_M_Code As String) As Boolean
        PictureBoxKnife.Image = Nothing

        Dim mtP As New ProductController
        Dim objInfo As New ProductInfo
        objInfo = mtP.Product_Get(PM_M_Code)
        If objInfo Is Nothing Then
            Exit Function
        End If
        PictureBoxKnife.Image = ByteToImage(objInfo.PM_Image)
    End Function

    Private Sub GridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        GridInvent_Click(Nothing, Nothing)
    End Sub

    Private Sub GridInvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridInvent.Click
        If Me.GridView1.RowCount <= 0 Then
            Exit Sub
        End If
        LoadPicture(Me.GridView1.GetFocusedRowCellValue("M_Code").ToString)

        Me.txtM_Code.Text = Me.GridView1.GetFocusedRowCellValue("M_Code").ToString
        Me.LabGuiGe.Text = Me.GridView1.GetFocusedRowCellValue("M_Gauge").ToString
        Me.LabM_Name.Text = Me.GridView1.GetFocusedRowCellValue("M_Name").ToString

        ButtonFind_Click(Nothing, Nothing)
        ''-------------------------------
    End Sub
#End Region

    Private Sub ButtonFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFind.Click

        Dim kc As New KnifeWareInventorySubControl
        GridMyInvent.DataSource = kc.KnifeWareInventorySub_GetListItem(Me.txtM_Code.Text, Nothing)

        '載入全集團庫存'---------------------------------
        ds.Tables("AllInvent").Clear()
        Dim wc As New KnifeManagerControl
        Dim wl As New List(Of KnifeManagerInfo)

        wl = wc.KnifeManagerInventorySub_GetList(Me.txtM_Code.Text, Nothing, Nothing)
        If wl.Count > 0 Then
            Me.LabGuiGe.Text = wl(0).M_Gauge
            Me.LabM_Name.Text = wl(0).M_Name
            Dim row As DataRow
            row = ds.Tables("AllInvent").NewRow
            row("CompanyID") = "MG"
            row("WI_SQty") = wl(0).WI_SQty
            row("WI_SReQty") = wl(0).WI_SReQty
            ds.Tables("AllInvent").Rows.Add(row)
        Else
            MsgBox("無符合條件的數據", 64, "提示")
        End If
        '-----------------------------------------------
        GridUserKnife.DataSource = wc.KnifeManagerNoReurnUser_GetList()
    End Sub


    Sub CreateTables()
        '創建刪除數據表
        With ds.Tables.Add("AllInvent")
            .Columns.Add("CompanyID", GetType(String))
            .Columns.Add("WI_SQty", GetType(Int32))
            .Columns.Add("WI_SReQty", GetType(Int32))
        End With
        '綁定表格
        GridAllInvent.DataSource = ds.Tables("AllInvent")
    End Sub
End Class

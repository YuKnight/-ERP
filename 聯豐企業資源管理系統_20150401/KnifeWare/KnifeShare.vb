Imports System.Data.SqlClient
Imports LFERP.Library.WareHouse
Imports LFERP.SystemManager

Module KnifeShare

    Public strKQName As String
    Public strKQDepName As String
    Public strKQFacName As String
    Public strKQdata As String


    Public KnifeWareTreeView As TreeView
    Public KnifeWareBarManager As DevExpress.XtraBars.BarManager

    'Public Sub KnifeWareLoad(ByVal ImageList1 As ImageList, ByVal PMS_ID As String)

    '    Dim WH_Name, WH_ID As String
    '    Dim mt As New WareHouseController
    '    Dim objInfo As New List(Of WareHouseInfo)
    '    Dim i As Integer

    '    Dim str As String = WareSelect(InUserID, PMS_ID)
    '    If (str = "''") Then
    '        Dim BarLargeButtonItem As New DevExpress.XtraBars.BarLargeButtonItem
    '        KnifeWareBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {BarLargeButtonItem})
    '        Dim bar1 As DevExpress.XtraBars.Bar = KnifeWareBarManager.Bars.Item(0)
    '        bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(BarLargeButtonItem)})
    '        BarLargeButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
    '        BarLargeButtonItem.Id = i
    '        BarLargeButtonItem.Glyph = ImageList1.Images(0)
    '        BarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
    '        BarLargeButtonItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
    '        Exit Sub
    '    End If
    '    objInfo = mt.WareHouse_GetList(str)
    '    If objInfo Is Nothing Then Exit Sub
    '    For i = 0 To objInfo.Count - 1
    '        If objInfo(i).WH_ID = "W4001" Or objInfo(i).WH_ID = "W50" Then
    '        Else
    '            Continue For
    '        End If
    '        WH_Name = objInfo(i).WH_Name
    '        WH_ID = objInfo(i).WH_ID

    '        Dim BarLargeButtonItem As New DevExpress.XtraBars.BarLargeButtonItem
    '        KnifeWareBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {BarLargeButtonItem})
    '        Dim bar1 As DevExpress.XtraBars.Bar = KnifeWareBarManager.Bars.Item(0)
    '        bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(BarLargeButtonItem)})
    '        BarLargeButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
    '        BarLargeButtonItem.Id = i
    '        BarLargeButtonItem.Glyph = ImageList1.Images(0)
    '        BarLargeButtonItem.Caption = WH_Name
    '        BarLargeButtonItem.Tag = WH_ID
    '        BarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
    '        BarLargeButtonItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003

    '        AddHandler BarLargeButtonItem.ItemClick, AddressOf KnifeWareLoadEvent
    '    Next
    '    If KnifeWareBarManager.Items.Count > 0 Then
    '        Loadtree(KnifeWareBarManager.Items(0).Tag)
    '    End If

    'End Sub

    Public Sub KnifeWareLoad(ByVal ImageList1 As ImageList, ByVal PMS_ID As String)
        Dim mt As New WareHouseController
        Dim mtl As New List(Of WareHouseInfo)
        mtl = mt.WareHouse_GetList(WareSelect(InUserID, PMS_ID))

        If mtl.Count <= 0 Then
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To mtl.Count - 1
            ''-------------------------------------------
            If mtl(i).WH_PID = "" Then
                Dim BarLargeButtonItem As New DevExpress.XtraBars.BarLargeButtonItem
                KnifeWareBarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {BarLargeButtonItem})
                Dim bar1 As DevExpress.XtraBars.Bar = KnifeWareBarManager.Bars.Item(0)
                bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(BarLargeButtonItem)})
                BarLargeButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
                BarLargeButtonItem.Id = i
                BarLargeButtonItem.Glyph = ImageList1.Images(0)
                BarLargeButtonItem.Caption = mtl(i).WH_Name
                BarLargeButtonItem.Tag = mtl(i).WH_ID
                BarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
                BarLargeButtonItem.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003

                AddHandler BarLargeButtonItem.ItemClick, AddressOf KnifeWareLoadEvent
            End If
        Next

        If KnifeWareBarManager.Items.Count > 0 Then
            Loadtree(KnifeWareBarManager.Items(0).Tag)
        End If
    End Sub

    Private Sub Loadtree(ByVal sTag As String)
        Dim i As Integer
        Dim mc As New WareHouseController
        Dim mi As New List(Of WareHouseInfo)
        mi = mc.WareHouse_GetList("'" & sTag & "'")
        KnifeWareTreeView.Nodes.Clear()
        If mi.Count < 1 Then
            Exit Sub
        End If

        For i = 0 To mi.Count - 1
            If mi(i).WH_PID = "" Then
            Else
                KnifeWareTreeView.Nodes.Add(mi(i).WH_Name).Tag = mi(i).WH_ID
            End If
        Next
        KnifeWareTreeView.SelectedNode = KnifeWareTreeView.Nodes(0)
    End Sub

    Private Sub KnifeWareLoadEvent(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim i As Integer
        Dim sTag As String = CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Tag
        For i = 0 To KnifeWareBarManager.Bars(0).ItemLinks.Count - 1
            If CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Id = i Then
                CType(sender.PressedLink.Item, DevExpress.XtraBars.BarLargeButtonItem).Down = True
            Else
                CType(KnifeWareBarManager.Bars(0).ItemLinks(i).Item, DevExpress.XtraBars.BarLargeButtonItem).Down = False
            End If
        Next
        Dim mc As New WareHouseController
        Dim mi As New List(Of WareHouseInfo)
        mi = mc.WareHouse_GetList("'" & sTag & "'")
        KnifeWareTreeView.Nodes.Clear()
        If mi.Count < 1 Then
            Exit Sub
        End If

        For i = 0 To mi.Count - 1
            If mi(i).WH_PID = "" Then
            Else
                KnifeWareTreeView.Nodes.Add(mi(i).WH_Name).Tag = mi(i).WH_ID
            End If
        Next
        KnifeWareTreeView.SelectedNode = KnifeWareTreeView.Nodes(0)
    End Sub


    Public Function GetFacName() As DataSet

        Dim sda As New SqlDataAdapter
        Dim myConn As New SqlConnection(KaoQinConn)
        Dim ds As New DataSet
        myConn.Open()
        Dim strSql As String = "select distinct fac_name from EmployeeFull"
        Dim myCommand As SqlCommand = New SqlCommand(strSql, myConn)
        sda = New SqlDataAdapter(myCommand)
        sda.Fill(ds, "FacName")
        Return ds

    End Function

    Public Function GetNameDep(ByVal strCardID As String) As String
        'Dim strConn As String = ""
        GetNameDep = ""
        strKQName = ""
        strKQDepName = ""
        strKQFacName = ""

        Dim myCommand As SqlCommand
        Dim strSql As String

        Dim myConn As New SqlConnection(KaoQinConn)

        myConn.Open()
        strSql = "select * from EmployeeFull where BadgeID='" & strCardID & "'"
        myCommand = New SqlCommand(strSql, myConn)
        Dim rdr As SqlDataReader = myCommand.ExecuteReader
        If rdr.HasRows = True Then      '判斷是否存在符合條件的記錄
            Do While rdr.Read()
                strKQName = rdr("name")
                strKQDepName = rdr("bri_name")
                strKQFacName = rdr("fac_name")
            Loop
            strKQdata = "haveData"
        Else
            strKQdata = "noData"
        End If
        myConn.Close()
    End Function

    Public Function GetDepName(ByVal FAC_NAME As String) As DataSet

        Dim sda As New SqlDataAdapter
        Dim myConn As New SqlConnection(KaoQinConn)
        Dim ds As New DataSet
        myConn.Open()
        Dim strSql As String = "select distinct bri_name from EmployeeFull where fac_name='" & FAC_NAME & "'"
        Dim myCommand As SqlCommand = New SqlCommand(strSql, myConn)
        sda = New SqlDataAdapter(myCommand)
        sda.Fill(ds, "DepName")
        Return ds

    End Function



    ''' <summary>
    ''' 判斷是否是夜班倉
    ''' </summary>
    ''' <param name="StrWHID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetNightWareHouse(ByVal StrWHID As String) As Boolean
        Dim strWHRemark As String
        GetNightWareHouse = False

        Dim wc As New WareHouseController
        Dim wl As New List(Of WareHouseInfo)
        wl = wc.WareHouse_Get(StrWHID)
        strWHRemark = wl(0).WH_Remark  '如果是夜班倉

        If strWHRemark = "夜班倉" Or strWHRemark = "Night" Then
            GetNightWareHouse = True
        End If
    End Function



    Function ReportDataSet(ByVal strSQL As String, ByVal strTable As String) As DataSet
        Dim dsR As New DataSet

        Dim da As SqlDataAdapter
        Dim cn As New LFERPDB.LFERPDataBase
        Dim strCn As New SqlConnection(cn.LoadConnStr)
        strCn.Open()
        da = New SqlDataAdapter(strSQL, strCn)
        da.Fill(dsR, strTable)
        strCn.Close()

        Return dsR
    End Function


    Function GetPMWS_Value(ByVal strPMID As String) As Boolean
        GetPMWS_Value = False
        ''多條記錄
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, strPMID)
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                GetPMWS_Value = True
            End If
        End If
    End Function


End Module

Imports LFERP.Library.WareHouse
Imports LFERP.Library.Shared
Imports LFERP.DataSetting
Imports LFERP.Library.ProductionWareHouse

Public Class frmWareHouseSelect
    Public SelectWareID As String
    Public SelectWareName As String
    Public SelectWareUpName As String
    Public blnSelectParentNode As Boolean

    Private Sub frmWareHouseSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '2013-2-20 加選擇多倉庫
        Labelxx.Visible = False
        Labelxx.Text = tempValue2

        If Labelxx.Text = "500401" Or Labelxx.Text = "500408" Or Labelxx.Text = "500409" Then
            tw.CheckBoxes = True
        Else
            tw.CheckBoxes = False
        End If
        tempValue2 = Nothing

        ''----------------------------------------------------------------------------

        Dim mt As New WareHouseController

        If tempValue3 = "" Then

            mt.WareHouse_LoadToTreeView(tw, ErpUser.WareHouseList)
        Else
            'exceed.lee加
            If Me.Labelxx.Text = "880502" Or Me.Labelxx.Text = "8802006" Or Labelxx.Text = "880705" Or Labelxx.Text = "880708" Or Labelxx.Text = "880806" Or Labelxx.Text = "880807" Or Labelxx.Text = "880906" Or Labelxx.Text = "880907" Or Labelxx.Text = "881005" Or Labelxx.Text = "881008" Or Labelxx.Text = "510308" Then
                Dim a As New LFERP.SystemManager.PermissionModuleWarrantSubController
                Dim b As New List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)
                b = a.PermissionModuleWarrantSub_GetList(InUserID, tempValue3)

                mt.WareHouse_LoadToTreeViewIn(tw, WareInSelect(InUserID, tempValue3), b.Item(0).PMWS_Value)

                ' MsgBox(WareInSelect(InUserID, tempValue3) & "-------" & b.Item(0).PMWS_Value)
            Else
                mt.WareHouse_LoadToTreeView(tw, WareSelect(InUserID, tempValue3))
            End If

        End If

        tempValue3 = ""
        tw.ExpandAll()
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        ' 2013-8-20李超新增
        If tw.SelectedNode Is Nothing Then
            MsgBox("請選擇正確的倉庫", , "提示")
            Exit Sub
        End If

        '2013-2-20 加選擇多倉庫
        If Labelxx.Text = "500401" Or Labelxx.Text = "500408" Or Labelxx.Text = "500409" Then

            SelectWareID = ""
            SelectWareName = ""

            Dim i, j As Integer
            For i = 0 To tw.Nodes.Count - 1
                For j = 0 To tw.Nodes(i).Nodes.Count - 1
                    If tw.Nodes(i).Nodes(j).Checked = True Then
                        SelectWareID = SelectWareID & "," & tw.Nodes(i).Nodes(j).Tag
                        SelectWareName = SelectWareName & "," & tw.Nodes(i).Text & "-" & tw.Nodes(i).Nodes(j).Text
                    End If
                Next
            Next


            If Len(SelectWareID) > 0 Then
                SelectWareID = Mid(SelectWareID, 2, Len(SelectWareID))
                SelectWareName = Mid(SelectWareName, 2, Len(SelectWareName))
                Me.Close()
            Else
                MsgBox("請選擇正確的倉庫", , "提示")
            End If
            Exit Sub
        End If
        ''------------------------------------------------------------------------------------------------------
        '調用報表時

       
        If tw.SelectedNode.Level = 1 Then
            SelectWareID = tw.SelectedNode.Tag
            SelectWareName = tw.SelectedNode.Text
            SelectWareUpName = tw.SelectedNode.Parent.Text
            '<<<<<<<<<<報表調用時
            If tempValue4 = "倉庫領料白名單" Then
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim ltc1 As New CollectionToDataSet
                Dim ltc3 As New CollectionToDataSet


                Dim pmc As New WhiteUserListController
                Dim uc As New DepartmentControler
                Dim wh As New WareHouseController


                ds.Tables.Clear()

                If pmc.WhiteUserList_GetList(Nothing, Mid(SelectWareID, 1, 3)).Count = 0 Then
                    MsgBox("此倉庫當前無領料白名單記錄!")
                    Exit Sub
                End If

                ltc.CollToDataSet(ds, "WhiteUserList", pmc.WhiteUserList_GetList(Nothing, Mid(SelectWareID, 1, 3)))
                ltc1.CollToDataSet(ds, "Department", uc.Department_GetList(Nothing, Nothing, Nothing))
                ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))


                PreviewRPT(ds, "rptWhiteuserList", "領料人員白名單", True, True)
                ltc = Nothing
                ltc1 = Nothing
                ltc3 = Nothing
                Exit Sub

            End If
            '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            Me.Close()
        Else
            If blnSelectParentNode = True Then
                SelectWareID = tw.SelectedNode.Tag
                SelectWareName = tw.SelectedNode.Text
                blnSelectParentNode = False
                Me.Close()
            Else
                SelectWareID = ""
                MsgBox("請選擇正確的倉庫", , "提示")
            End If
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click


        SelectWareID = ""
        SelectWareName = ""
        SelectWareUpName = ""
        Me.Close()

    End Sub

    Private Sub tw_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tw.AfterSelect

    End Sub

    Private Sub tw_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tw.NodeMouseClick
        '2013-2-20 加選擇多倉庫
        Dim i As Integer
        If Labelxx.Text = "500401" Or Labelxx.Text = "500408" Or Labelxx.Text = "500409" Then
            If e.Node.Level = 0 Then
                If e.Node.Checked = True Then
                    For i = 0 To e.Node.Nodes.Count - 1
                        e.Node.Nodes(i).Checked = True
                    Next
                Else
                    For i = 0 To e.Node.Nodes.Count - 1
                        e.Node.Nodes(i).Checked = False
                    Next
                End If
            End If
        End If
    End Sub
End Class
Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.SystemManager

Public Class frmMaterialTypeManger

    Dim MPController As New MaterialParamController
    Dim mtc As New Material.MaterialTypeController

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        Me.Close()

    End Sub

    Private Sub frmMaterialParam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '不自動增加所有資料行
        On Error Resume Next
        'mtc.LoadNodes(tv1, ErpUser.MaterialType)
       
        '' 為磨刀部
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100401")
        If pmwiL.Count > 0 Then
            If pmwiL(0).PMWS_Value.ToString <> "" Then
                mtc.LoadNodes(tv1, pmwiL(0).PMWS_Value.ToString)    '只選擇成品類
            Else
                mtc.LoadNodes(tv1, "10,20,30,40,50")
            End If
        Else
            mtc.LoadNodes(tv1, "10,20,30,40,50")
        End If

        ' tv1.ExpandAll()

    End Sub



  

    Private Sub cmenuMaterialTypeAdd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmenuMaterialTypeAdd0.Click
        On Error Resume Next
        Edit = False
        frmMaterialType.EditType = "大類"
        Select Case tv1.SelectedNode.Level
            Case 0
                frmMaterialType.TypeTopID = tv1.SelectedNode.Tag
                frmMaterialType.Label5.Text = tv1.SelectedNode.Text
            Case 1
                frmMaterialType.TypeTopID = tv1.SelectedNode.Parent.Tag
                frmMaterialType.Label5.Text = tv1.SelectedNode.Parent.Text
            Case 2
                frmMaterialType.TypeTopID = tv1.SelectedNode.Parent.Parent.Tag
                frmMaterialType.Label5.Text = tv1.SelectedNode.Parent.Parent.Text
            Case 3
                frmMaterialType.TypeTopID = tv1.SelectedNode.Parent.Parent.Parent.Tag
                frmMaterialType.Label5.Text = tv1.SelectedNode.Parent.Parent.Parent.Text
        End Select

        frmMaterialType.ShowDialog()
        'mtc.LoadNodes(tv1, ErpUser.MaterialType)

    End Sub

    Function CheckNode(ByVal type As String) As String
        '
        Dim tTemp As String = ""
        Select Case tv1.SelectedNode.Level
            Case 0
                Select Case type
                    Case "大類"
                        tTemp = Trim(tv1.SelectedNode.Tag)
                    Case "中類"
                    Case "小類"
                End Select
            Case 1
                Select Case type
                    Case "大類"
                        tTemp = Trim(tv1.SelectedNode.Parent.Tag)
                    Case "中類"
                        tTemp = Trim(tv1.SelectedNode.Tag)
                    Case "小類"
                End Select
            Case 2
                Select Case type
                    Case "大類"
                        tTemp = Trim(tv1.SelectedNode.Parent.Parent.Tag)
                    Case "中類"
                        tTemp = Trim(tv1.SelectedNode.Parent.Tag)
                    Case "小類"
                        tTemp = Trim(tv1.SelectedNode.Tag)
                End Select

            Case 3
                Select Case type
                    Case "大類"
                        tTemp = Trim(tv1.SelectedNode.Parent.Parent.Parent.Tag)
                    Case "中類"
                        tTemp = Trim(tv1.SelectedNode.Parent.Parent.Tag)
                    Case "小類"
                        tTemp = Trim(tv1.SelectedNode.Parent.Tag)
                End Select
        End Select
        CheckNode = tTemp
    End Function

    Private Sub cmenuMaterialTypeAdd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmenuMaterialTypeAdd1.Click
        On Error Resume Next
        Edit = False
        frmMaterialType.EditType = "中類"
        Select Case tv1.SelectedNode.Level
            Case 0
            Case 1
                frmMaterialType.TypeTopID = tv1.SelectedNode.Tag
                frmMaterialType.Label5.Text = tv1.SelectedNode.Text
                frmMaterialType.ShowDialog()
            Case 2
                frmMaterialType.TypeTopID = tv1.SelectedNode.Parent.Tag
                frmMaterialType.Label5.Text = tv1.SelectedNode.Parent.Text
                frmMaterialType.ShowDialog()
            Case 3
                frmMaterialType.TypeTopID = tv1.SelectedNode.Parent.Parent.Tag
                frmMaterialType.Label5.Text = tv1.SelectedNode.Parent.Parent.Text
                frmMaterialType.ShowDialog()
        End Select

        'mtc.LoadNodes(tv1, ErpUser.MaterialType)

    End Sub

    Private Sub cmenuMaterialTypeAdd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmenuMaterialTypeAdd2.Click
        On Error Resume Next
        Edit = False
        frmMaterialType.EditType = "小類"
        Select Case tv1.SelectedNode.Level
            Case 0
            Case 1

            Case 2
                frmMaterialType.TypeTopID = tv1.SelectedNode.Tag
                frmMaterialType.Label5.Text = tv1.SelectedNode.Text
                frmMaterialType.ShowDialog()
            Case 3
                frmMaterialType.TypeTopID = tv1.SelectedNode.Parent.Tag
                frmMaterialType.Label5.Text = tv1.SelectedNode.Parent.Text
                frmMaterialType.ShowDialog()
        End Select

        'mtc.LoadNodes(tv1, ErpUser.MaterialType)

    End Sub

    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click
        ' mtc.LoadNodes(tv1, "10,20,30,40,50,60")
        ' mtc.LoadNodes(tv1, ErpUser.MaterialType)

        '' 為磨刀部
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "100401")
        If pmwiL.Count > 0 Then
            mtc.LoadNodes(tv1, pmwiL(0).PMWS_Value.ToString)    '只選擇成品類
        Else
            mtc.LoadNodes(tv1, "10,20,30,40,50")
        End If

    End Sub


  
    Private Sub cmenuMaterialTypeEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmenuMaterialTypeEdit.Click
        On Error Resume Next
        Edit = True

        Select Case tv1.SelectedNode.Level
            Case 0

            Case 1
                frmMaterialType.EditType = "大類"
                frmMaterialType.txtID.Text = tv1.SelectedNode.Tag
                frmMaterialType.ShowDialog()
            Case 2
                frmMaterialType.EditType = "中類"
                frmMaterialType.txtID.Text = tv1.SelectedNode.Tag
                frmMaterialType.ShowDialog()
            Case 3
                frmMaterialType.EditType = "小類"
                frmMaterialType.txtID.Text = tv1.SelectedNode.Tag
                frmMaterialType.ShowDialog()
        End Select

    End Sub

    Private Sub cmenuMaterialTypeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmenuMaterialTypeDel.Click

        ''2012-6-30
        If Delete_Check(tv1.SelectedNode.Level, Trim(tv1.SelectedNode.Tag)) = False Then
            Exit Sub
        End If

        If MsgBox("你確定要刪除這個類型嗎?", MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then Exit Sub
        Select Case tv1.SelectedNode.Level
            Case 0

            Case 1
                mtc.MaterialType1_Delete(tv1.SelectedNode.Tag)
            Case 2
                mtc.MaterialType2_Delete(tv1.SelectedNode.Tag)
            Case 3
                mtc.MaterialType3_Delete(tv1.SelectedNode.Tag)
        End Select
    End Sub

    Function Delete_Check(ByVal tv1SelectedNodLevel As Integer, ByVal tv1SelectedNodeTag As String) As Boolean
        Delete_Check = True

        Dim mc As New MaterialTypeController
        Dim mcc As New MaterialController

        Select Case tv1SelectedNodLevel
            Case 1
                If mc.MaterialType2_GetList(Nothing, Nothing, tv1SelectedNodeTag).Count > 0 Then
                    Delete_Check = False
                    MsgBox("不能刪除,此類別有子類型存在!")
                End If
            Case 2
                If mc.MaterialType3_GetList(Nothing, Nothing, tv1SelectedNodeTag).Count > 0 Then
                    Delete_Check = False
                    MsgBox("不能刪除,此類別有子類型存在!")
                End If
            Case 3
                If mcc.MaterialCode_GetList(Nothing, Nothing, Nothing, tv1SelectedNodeTag, Nothing).Count > 0 Then
                    Delete_Check = False
                    MsgBox("不能刪除,此類別已存在物料編碼中!")
                End If
        End Select

    End Function

    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        Select Case tv1.SelectedNode.Level
            Case 0
                cmenuMaterialTypeAdd0.Visible = True
                cmenuMaterialTypeAdd1.Visible = False
                cmenuMaterialTypeAdd2.Visible = False
                cmenuMaterialTypeDel.Visible = False
                cmenuMaterialTypeEdit.Visible = False
            Case 1
                cmenuMaterialTypeAdd0.Visible = False
                cmenuMaterialTypeAdd1.Visible = True
                cmenuMaterialTypeAdd2.Visible = False
                cmenuMaterialTypeDel.Visible = True
                cmenuMaterialTypeEdit.Visible = True
            Case 2
                cmenuMaterialTypeAdd0.Visible = False
                cmenuMaterialTypeAdd1.Visible = False
                cmenuMaterialTypeAdd2.Visible = True
                cmenuMaterialTypeDel.Visible = True
                cmenuMaterialTypeEdit.Visible = True
            Case 3
                cmenuMaterialTypeAdd0.Visible = False
                cmenuMaterialTypeAdd1.Visible = False
                cmenuMaterialTypeAdd2.Visible = True
                cmenuMaterialTypeDel.Visible = True
                cmenuMaterialTypeEdit.Visible = True
        End Select
    End Sub
End Class
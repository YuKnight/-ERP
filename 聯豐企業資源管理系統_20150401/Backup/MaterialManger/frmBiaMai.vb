Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.Library.Product
Imports LFERP.SystemManager

Public Class frmBiaMai
    Dim MPController As New MaterialParamController
    Dim mtc As New Material.MaterialTypeController
    Dim mc As New MaterialController

    Dim TempType As String
    Dim ds As New DataSet

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tempCode = ""
        Me.Close()

    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        On Error Resume Next
        Dim fr As frmMaterialCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMaterialCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMaterialCode
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        tempValue = "新增"
        Edit = False
        fr.Show()

    End Sub

    Private Sub frmBiaMai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mtc.LoadNodes(tv1, ErpUser.MaterialType)
        'tv1.Nodes(2).Expand()
        'tv1.Nodes(1).Expand()
        'tv1.Nodes(0).Expand()
        txtName.Select()

        ''----------------------------
        TempType = tempValue2
        If TempType = "All" Then
            GoIN.Visible = True
            Me.GridView1.OptionsBehavior.Editable = True
        Else
            GoIN.Visible = False
            Me.GridView1.OptionsBehavior.Editable = False
        End If

        tempValue2 = Nothing


        CreateTables()

    End Sub

    Private Sub tv1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tv1.DoubleClick
        PopupContainerEdit1.EditValue = tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeek.Click
        Dim strCode, strName, strTypeID, strGauge, strSupplierNo As String

        If CheckEdit1.Checked = True Then
            If PopupContainerEdit1.EditValue Is Nothing Then
                MsgBox("沒有選擇類別,請選擇!", , "提示")
                Exit Sub
            Else
                strTypeID = PopupContainerEdit1.EditValue
            End If
        Else
            strTypeID = Nothing 'ErpUser.MaterialType

        End If
        If CheckEdit4.Checked = True Then
            If Len(txtCode.EditValue) = 0 Then
                MsgBox("沒有輸入物料編碼,請輸入!", , "提示")
                Exit Sub
            Else
                strCode = txtCode.EditValue
            End If
        Else
            strCode = Nothing
        End If
        If CheckEdit2.Checked = True Then
            If Len(txtName.EditValue) = 0 Then
                MsgBox("沒有輸入物料名稱,請輸入!", , "提示")
                Exit Sub
            Else
                strName = txtName.EditValue
            End If
        Else
            strName = Nothing
        End If
        If CheckEdit3.Checked = True Then
            If Len(txtGauge.EditValue) = 0 Then
                MsgBox("沒有輸入物料規格,請輸入!", , "提示")
                Exit Sub
            Else
                strGauge = txtGauge.EditValue
            End If
        Else
            strGauge = Nothing
        End If

        If CheckEdit5.Checked = True Then
            If Len(TextEdit1.EditValue) = 0 Then
                MsgBox("沒有輸入供應商編號,請輸入!", , "提示")
                Exit Sub
            Else
                strSupplierNo = TextEdit1.EditValue
            End If
        Else
            strSupplierNo = Nothing
        End If


        '***判斷用戶是擁有特殊類的權限
        Dim pmws2 As New PermissionModuleWarrantSubController
        Dim pmwiL2 As List(Of PermissionModuleWarrantSubInfo)
        Dim Stra As String
        Stra = "否"
        pmwiL2 = pmws2.PermissionModuleWarrantSub_GetList(InUserID, "100115")


        If pmwiL2.Item(0).PMWS_Value = "是" Then
            Stra = "是"
        End If

        '************

        ' Grid.DataSource = mc.MaterialCode_GetList(strCode, strName, strGauge, strTypeID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strSupplierNo, Stra)

        ds.Tables("Code").Clear()
        Dim ml As New List(Of MaterialInfo)
        ml = mc.MaterialCode_GetList(strCode, strName, strGauge, strTypeID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strSupplierNo, Stra)
        If ml.Count > 0 Then
            Dim j As Integer
            For j = 0 To ml.Count - 1
               
                Dim row As DataRow
                row = ds.Tables("Code").NewRow
                'CodeSubData.Tables("CodeSub").NewRow()
                row("GoIN") = False
                row("M_Code") = ml(j).M_Code
                row("M_Name") = ml(j).M_Name
                row("M_Unit") = ml(j).M_Unit

                row("M_Gauge") = ml(j).M_Gauge
                row("M_SupplierNo") = ml(j).M_SupplierNo
                ds.Tables("Code").Rows.Add(row)
            Next

        End If


    End Sub

    '@ 2012/1/7 修改，使frmMaterialCodepopTypeID控件顯示物料類別名稱，frmMaterialCodeLabel24控件顯示物料類別全名稱
    Private Sub cmdCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click
        Dim TypeName As String
        Dim TypeName1 As String
        Dim TypeName2 As String

        If GridView1.RowCount = 0 Then Exit Sub
        Edit = False
        tempValue = "復制新增"
        tempCode = "AddOrEdit"
        On Error Resume Next
        Dim fr As frmMaterialCode
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMaterialCode Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmMaterialCode
        fr.MdiParent = MDIMain
        fr.txtCode.Text = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")
        fr.WindowState = FormWindowState.Maximized
        tempValue2 = mc.MaterialCode_Get(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")).M_Name.ToString
        tempValue3 = mc.MaterialCode_Get(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")).M_Gauge.ToString
        tempValue4 = mc.MaterialCode_Get(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")).M_Unit.ToString
        tempValue6 = mc.MaterialCode_Get(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")).Type3ID.ToString
        TypeName = mtc.MaterialType_Get(Mid(tempValue6, 1, 2)).MaterialTypeName.ToString
        TypeName1 = mtc.MaterialType1_Get(Mid(tempValue6, 1, 5)).Type1Name.ToString
        TypeName2 = mtc.MaterialType2_Get(Mid(tempValue6, 1, 8)).Type2Name.ToString
        fr.popTypeID.EditValue = mtc.MaterialType3_Get(tempValue6).Type3Name.ToString
        fr.Label24.Text = TypeName & "+" & TypeName1 & "+" & TypeName2 & "+" & fr.popTypeID.EditValue
        fr.Show()
    End Sub

    Private Sub cmdAddSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddSub.Click

        If TempType = "All" Then
            If GridView1.RowCount > 0 Then
                Dim StrCode As String = ""
                Dim i As Integer
                For i = 0 To ds.Tables("Code").Rows.Count - 1

                    If ds.Tables("Code").Rows(i)("GoIN") = True Then
                        If StrCode = "" Then
                            StrCode = ds.Tables("Code").Rows(i)("M_Code").ToString
                        Else
                            StrCode = StrCode + "," + ds.Tables("Code").Rows(i)("M_Code").ToString
                        End If
                    End If
                Next

                If StrCode = "" Then
                    MsgBox("沒有選擇任何編碼！")
                    Exit Sub
                End If

                tempCode = StrCode
            End If
        Else
            tempCode = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")
        End If
        ''  frmMaterialCode.AddRow(tempCode)
        Me.Close()

    End Sub

    Private Sub Grid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid.Click
        ' GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")
        On Error Resume Next
        GridSub.Columns.Clear()
        'SetSelectTypeGrid(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code"), "產品資料共用", GridSub)
        SetSelectTypeGrid(GridView1.GetFocusedRowCellValue("M_Code").ToString, tcList.SelectedTabPage.Text, GridSub)
    End Sub

    Private Sub tcList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tcList.Click
        If GridView1.RowCount > 0 Then
            SetSelectTypeGrid(GridView1.GetFocusedRowCellValue("M_Code").ToString, tcList.SelectedTabPage.Text, GridSub)
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            PopupContainerEdit1.Focus()
        End If
    End Sub

    Private Sub CheckEdit4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit4.CheckedChanged
        If CheckEdit4.Checked = True Then
            txtCode.Focus()
        End If
    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit2.CheckedChanged
        If CheckEdit2.Checked = True Then
            txtName.Focus()
        End If
    End Sub

    Private Sub CheckEdit3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit3.CheckedChanged
        If CheckEdit3.Checked = True Then
            txtGauge.Focus()
        End If
    End Sub

    Private Sub CheckEdit5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit5.CheckedChanged
        If CheckEdit5.Checked = True Then
            TextEdit1.Focus()
        End If
    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown, txtName.KeyDown, txtGauge.KeyDown, TextEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1_Click(Nothing, Nothing)
        End If
    End Sub


    ''----------------------------------------------------

    Sub CreateTables()
        '子物料數據
        ds.Tables.Clear()
        '創建數據表
        With ds.Tables.Add("Code")
            .Columns.Add("GoIN", GetType(Boolean))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_SupplierNo", GetType(String))
        End With

        '綁定表格
        Grid.DataSource = ds.Tables("Code")
    End Sub


End Class
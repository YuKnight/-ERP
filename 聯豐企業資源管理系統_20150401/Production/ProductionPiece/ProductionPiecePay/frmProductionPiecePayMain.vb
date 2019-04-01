Imports LFERP.Library.ProductionPiecePayPersonnel
Imports LFERP.Library.ProductionPiecePayWGMain
Imports LFERP.Library.ProductionPiecePayWGSub
Imports LFERP.Library.ProductionPiecePersonnel

Imports LFERP.Library.ProductionPayPersonnel

Public Class frmProductionPiecePayMain
    Dim ds As New DataSet

    Dim DoublClickBZ As String

    Private Sub frmProductionPiecePayPersonnelMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ButtonPer_Click(Nothing, Nothing)
        'CreateTable(ds)

        PowerUser()
    End Sub

    ''' <summary>
    ''' 權限------------
    ''' </summary>
    ''' <remarks></remarks>
    Sub PowerUser()

        cmdCollect.Enabled = False
        cmdEdit.Enabled = False
        cmdDel.Enabled = False
        cmdCheck.Enabled = False
        cmdPrintNoPrice.Enabled = False

        cmdCollect2.Enabled = False
        cmdEdit2.Enabled = False
        cmdDel2.Enabled = False
        cmdCheck2.Enabled = False
        cmdPrintNoPrice2.Enabled = False

        cmdPrintNoPrice3.Enabled = False

        Dim pmws As New LFERP.SystemManager.PermissionModuleWarrantSubController
        Dim pmwiL As List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88161001")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdCollect.Enabled = True : cmdCollect2.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88161002")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdEdit.Enabled = True : cmdEdit2.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88161003")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdDel.Enabled = True : cmdDel2.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88161004")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdCheck.Enabled = True : cmdCheck2.Enabled = True : ToolStripMenuLoad.Enabled = True

        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88161005")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then cmdPrintNoPrice.Enabled = True : cmdPrintNoPrice2.Enabled = True : cmdPrintNoPrice3.Enabled = True
        End If


        '88161006
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88161006")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ToolStripMenuSameSamp.Visible = True
        End If

    End Sub

    Private Sub cmdRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef.Click
        Dim pdc As New ProductionPiecePayPersonnelContol
        ' Grid1.DataSource = pdc.ProductionPiecePayPersonnel_GetList(Nothing, Nothing, Nothing, Format(Now, "yyyy/MM"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        Grid1.DataSource = pdc.ProductionPiecePayPersonnel_GetList1(Nothing, Nothing, Nothing, Format(Now, "yyyy/MM"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, False)

    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        ''刪除數據
        Dim pdc As New ProductionPiecePayPersonnelContol
        Dim pdcl As New List(Of ProductionPiecePayPersonnelInfo)
        Dim strA, strB As String

        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("AutoID").ToString
        strB = GridView1.GetFocusedRowCellValue("Per_Name").ToString

        pdcl = pdc.ProductionPiecePayPersonnel_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pdcl.Count > 0 Then   ''有記錄
        Else
            Exit Sub
        End If

        If pdcl(0).PL_Check = True Then
            MsgBox("此單已審核，不能刪除!")
            Exit Sub
        End If

        If MsgBox("你確定刪除員工姓名為:  '" & strB & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If pdc.ProductionPiecePayPersonnel_Delete(strA) = True Then
                MsgBox("刪除成功")
                cmdRef_Click(Nothing, Nothing) '刷新
            Else
                MsgBox("刪除失敗")
            End If
        End If
    End Sub

    Private Sub cmdCollect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCollect.Click
        'tempValue = "add"

        tempValue = "P"
        FrmPieceSumPayPersonnelLoad.ShowDialog()
        FrmPieceSumPayPersonnelLoad.Dispose()

    End Sub

    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Dim strA As String
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("AutoID").ToString

        tempValue = "view"
        tempValue2 = strA

        frmProductionPiecePayPersonnel.ShowDialog()
        frmProductionPiecePayPersonnel.Dispose()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click

        Dim pdc As New ProductionPiecePayPersonnelContol
        Dim pdcl As New List(Of ProductionPiecePayPersonnelInfo)
        Dim strA As String

        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("AutoID").ToString

        pdcl = pdc.ProductionPiecePayPersonnel_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pdcl.Count > 0 Then   ''有記錄
        Else
            Exit Sub
        End If

        If pdcl(0).PL_Check = True Then
            MsgBox("此單已審核，不能修改!")
            Exit Sub
        End If

        tempValue = "edit"
        tempValue2 = strA

        frmProductionPiecePayPersonnel.ShowDialog()
        frmProductionPiecePayPersonnel.Dispose()

        'Dim fr As New Form
        'For Each fr In MDIMain.MdiChildren
        '    If TypeOf fr Is frmProductionPiecePayPersonnel Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next
        'fr = New frmProductionPiecePayPersonnel

        'fr.MdiParent = MDIMain
        'fr.WindowState = FormWindowState.Maximized
        'fr.Show()


    End Sub

    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click

        Dim strA As String
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("AutoID").ToString

        tempValue = "check"
        tempValue2 = strA

        frmProductionPiecePayPersonnel.ShowDialog()
        frmProductionPiecePayPersonnel.Dispose()


        'Dim fr As New Form
        'For Each fr In MDIMain.MdiChildren
        '    If TypeOf fr Is frmProductionPiecePayPersonnel Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next
        'fr = New frmProductionPiecePayPersonnel

        'fr.MdiParent = MDIMain
        'fr.WindowState = FormWindowState.Maximized
        'fr.Show()
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click

        'tempValue2 = "個人計件薪金查詢"

        'frmProductionPiecePayFind.ShowDialog()

        'If tempValue = "F" Then
        '    Dim pfc As New ProductionPiecePayPersonnelContol
        '    Grid1.DataSource = pfc.ProductionPiecePayPersonnel_GetList(Nothing, tempValue5, Nothing, tempValue6, tempValue4, tempValue7, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue3)
        'End If

        'frmProductionPiecePayFind.Dispose()

        'tempValue = Nothing
        'tempValue2 = Nothing
        'tempValue3 = Nothing
        'tempValue4 = Nothing
        'tempValue5 = Nothing
        'tempValue6 = Nothing
        'tempValue7 = Nothing

        ''2012-8-16
        tempValue = "個人計件薪金"
        ProductionPieceSelectAll.ShowDialog()

        Dim pfc As New ProductionPiecePayPersonnelContol

        Select Case tempValue
            Case "0" '自定義
                Dim PPS As New LFERP.Library.ProductionPiece_Select.ProductionPiece_SelectControl
                Grid1.DataSource = PPS.ProductionPiecePayPersonnel_GetListSelect("個人計件薪金", tempValue2)

            Case "1" '固定模式
                If tempValue3 = "廠証編號" Then
                    Grid1.DataSource = pfc.ProductionPiecePayPersonnel_GetList(Nothing, tempValue2, Nothing, tempValue4, strInDepID, tempValue6, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    'Grid1.DataSource = pfc.ProductionPiecePayPersonnel_GetList1(Nothing, tempValue2, Nothing, tempValue4, strInDepID, tempValue6, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                End If
            Case "2" '廠別 部門
                'Grid1.DataSource = pfc.ProductionPiecePayPersonnel_GetList(Nothing, Nothing, Nothing, tempValue4, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue7)
                Grid1.DataSource = pfc.ProductionPiecePayPersonnel_GetList1(Nothing, Nothing, Nothing, tempValue4, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue7, tempValue8)

        End Select

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing

        tempValue7 = Nothing
        tempValue8 = Nothing

        ProductionPieceSelectAll.Dispose()

    End Sub

    ''' <summary>
    ''' 個人件薪匯總
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonPer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPer.Click
        DoublClickBZ = "MenuStrip1"
        Grid1.DataSource = Nothing

        Grid1.ContextMenuStrip = MenuStrip1
        GridView1.Columns.Clear()

        Dim StrA As String, StrB As String

        StrA = "自動編號, 廠證編號, 姓名, 班制, 年月, 廠別名稱, 部門編號, 部門名稱, 日薪, 上班天數, 平時加班, 假日加班, 應補金額, 應扣金額, 工資, 審核, 操作員"
        StrB = "AutoID, Per_NO, Per_Name, Per_Class ,PL_YYMM, PL_FacName, DepID, PL_DepName, Per_DayPrice, PL_OnDutyDays, PL_UsualOverHours, PL_HolidayOVerHours, PL_CompensateSum, PL_SubtractSum, PL_MeritedPay, PL_Check, PL_AddUserName"

        Dim StrAarray As Array = Split(StrA, ",")
        Dim StrBarray As Array = Split(StrB, ",")

        GridView1.OptionsCustomization.AllowColumnResizing = True
        GridView1.OptionsView.ShowAutoFilterRow = True


        For i As Integer = 0 To UBound(StrAarray)
            Dim Coll As New DevExpress.XtraGrid.Columns.GridColumn
            Coll.Caption = Trim(StrAarray(i))
            Coll.FieldName = Trim(StrBarray(i))
            Coll.OptionsColumn.AllowEdit = False

            If i = 1 Then
                Coll.SummaryItem.DisplayFormat = "記錄數：{0}"
                Coll.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            End If

            If i = 0 Or i = 5 Then  '不顯示
                Coll.Visible = False
                Coll.VisibleIndex = -1
            Else
                Coll.Visible = True
                Coll.VisibleIndex = GridView1.Columns.Count
            End If

            If i = 15 Then
                Dim rpsEdit As New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
                Coll.ColumnEdit = rpsEdit
            End If

            'Coll.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False

            GridView1.Columns.Add(Coll)
        Next

        cmdRef_Click(Nothing, Nothing)

    End Sub

    Private Sub ButtonGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGroup.Click
        DoublClickBZ = "MenuStrip2"
        Grid1.ContextMenuStrip = MenuStrip2
        GridView1.Columns.Clear()
        Dim StrA As String, StrB As String

        StrA = "自動編號,單號,組別編號,組別名稱,年月,廠別名稱,部門名稱,完成總金額,耗用總金額,計時總金額,計件總金額,應補金額,應扣金額,審核,操作員 "
        StrB = "AutoID, PY_ID, G_NO, PY_G_Name, PY_YYMM, PY_FacName, PY_DepName, PY_CompleteSum, PY_UseSum, PY_TimeSum, PY_PieceSum, PY_CompensateSum, PY_SubtractSum,PY_Check,PY_AddUserName"

        Dim StrAarray As Array = Split(StrA, ",")
        Dim StrBarray As Array = Split(StrB, ",")

        GridView1.OptionsCustomization.AllowColumnResizing = True
        GridView1.OptionsView.ShowAutoFilterRow = True

        For i As Integer = 0 To UBound(StrAarray)
            Dim Coll As New DevExpress.XtraGrid.Columns.GridColumn

            Coll.Caption = Trim(StrAarray(i))
            Coll.FieldName = Trim(StrBarray(i))
            Coll.OptionsColumn.AllowEdit = True
            If i = 0 Then  '不顯示
                Coll.Visible = False
                Coll.VisibleIndex = -1
            Else
                Coll.Visible = True
                Coll.VisibleIndex = GridView1.Columns.Count
            End If

            If i = 1 Then
                Coll.Width = 100
                Coll.SummaryItem.DisplayFormat = "記錄數：{0}"
                Coll.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            End If

            If i = 1 Or i = 7 Or i = 8 Or i = 9 Or i = 10 Or i = 11 Then
                Coll.Width = 85
            End If

            'Coll.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False

            Coll.OptionsColumn.AllowEdit = False
            GridView1.Columns.Add(Coll)
        Next

        Grid1.DataSource = Nothing

        cmdRef2_Click(Nothing, Nothing)

    End Sub


    Private Sub ButtonPerWG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPerWG.Click
        DoublClickBZ = "MenuStrip3"
        Grid1.ContextMenuStrip = MenuStrip3
        GridView1.Columns.Clear()
        Dim StrA As String, StrB As String

        StrA = "員工編號,員工姓名,部門,廠別,年月,組別計件工資,個人計件工資,薪金合計"
        StrB = "Per_NO,Per_Name,Per_DepName,Per_FacName,PaySum_YYMM,PYS_MeritedPaySum,PL_MeritedPaySum,TotalSum"

        Dim StrAarray As Array = Split(StrA, ",")
        Dim StrBarray As Array = Split(StrB, ",")

        GridView1.OptionsCustomization.AllowColumnResizing = True
        GridView1.OptionsView.ShowAutoFilterRow = True

        For i As Integer = 0 To UBound(StrAarray)
            Dim Coll As New DevExpress.XtraGrid.Columns.GridColumn

            Coll.Caption = Trim(StrAarray(i))
            Coll.FieldName = Trim(StrBarray(i))
            Coll.OptionsColumn.AllowEdit = True

            Coll.Visible = True
            Coll.VisibleIndex = GridView1.Columns.Count
            If i = 5 Or i = 6 Or i = 7 Then
                Coll.Width = 120
                ' Coll.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
            Else
                Coll.Width = 85
            End If

            If i = 0 Then
                Coll.SummaryItem.DisplayFormat = "記錄數：{0}"
                Coll.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            End If

            Coll.OptionsColumn.AllowEdit = False
            GridView1.Columns.Add(Coll)
        Next

        Grid1.DataSource = Nothing

        cmdRef3_Click(Nothing, Nothing)
    End Sub

    Private Sub cmdCollect2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCollect2.Click

        FrmPieceSumPayGroupLoad.ShowDialog()
        FrmPieceSumPayGroupLoad.Dispose()
    End Sub

    Private Sub cmdRef2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef2.Click
        Dim ppay As New ProductionPiecePayWGMainControl
        Grid1.DataSource = ppay.ProductionPiecePayWGMain_GetList(Nothing, Nothing, Nothing, Format(Now, "yyyy/MM"), Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing)  '
    End Sub

    Private Sub cmdEdit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit2.Click

        Dim strA, strB As String
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        Dim pdc As New ProductionPiecePayWGMainControl
        Dim pdcl As New List(Of ProductionPiecePayWGMainInfo)

        strA = GridView1.GetFocusedRowCellValue("PY_ID").ToString
        strB = GridView1.GetFocusedRowCellValue("AutoID").ToString

        pdcl = pdc.ProductionPiecePayWGMain_GetList(strB, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        ''-----------------------------------------------------------
        If pdcl.Count > 0 Then   ''有記錄
        Else
            Exit Sub
        End If

        If pdcl(0).PY_Check = True Then
            MsgBox("此單已審核，不能修改!")
            Exit Sub
        End If
        ''----------------------------------------------------------------------------------
        tempValue2 = strA
        tempValue = "edit"

        Dim fr As New Form
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionPiecePayGroup Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionPiecePayGroup

        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Private Sub cmdDel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel2.Click
        ''刪除數據
        Dim pdc As New ProductionPiecePayWGMainControl
        Dim pdcl As New List(Of ProductionPiecePayWGMainInfo)

        Dim pdcs As New ProductionPiecePayWGSubControl

        Dim strA, strB, strC As String

        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("AutoID").ToString
        strB = GridView1.GetFocusedRowCellValue("G_NO").ToString
        strC = GridView1.GetFocusedRowCellValue("PY_ID").ToString '

        pdcl = pdc.ProductionPiecePayWGMain_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pdcl.Count > 0 Then   ''有記錄
        Else
            Exit Sub
        End If

        If pdcl(0).PY_Check = True Then
            MsgBox("此單已審核，不能刪除!")
            Exit Sub
        End If

        If MsgBox("你確定刪除組別為:  '" & strB & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            ''先刪除子表信息----------------------
            If pdcs.ProductionPiecePayWGSub_Delete(Nothing, strC) = True Then

                If pdc.ProductionPiecePayWGMain_Delete(strA) = True Then '再刪除主表 
                    MsgBox("刪除成功")
                    cmdRef2_Click(Nothing, Nothing) '刷新
                Else
                    MsgBox("刪除失敗")
                End If
            Else
                MsgBox("刪除失敗")
            End If
        End If
    End Sub
    ''' <summary>
    ''' 審核
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmdCheck2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck2.Click
        Dim strA As String
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("PY_ID").ToString

        tempValue2 = strA
        tempValue = "check"

        Dim fr As New Form
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionPiecePayGroup Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionPiecePayGroup

        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub cmdView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView2.Click
        Dim strA As String
        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("PY_ID").ToString

        tempValue2 = strA
        tempValue = "view"

        Dim fr As New Form
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmProductionPiecePayGroup Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmProductionPiecePayGroup

        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub



    '    Public Function CreateTable(ByVal _ds As DataSet) As String
    '        CreateTable = ""
    '        With _ds.Tables.Add("PerWG")  '具體 人員的薪金記錄
    '            .Columns.Add("Per_NOSum", GetType(String))
    '            .Columns.Add("Per_NameSum", GetType(String))
    '            .Columns.Add("Dep_IDSum", GetType(String))
    '            .Columns.Add("Fac_IDSum", GetType(String))
    '            .Columns.Add("YYMMSum", GetType(String))
    '            .Columns.Add("PYS_MeritedPaySum", GetType(String))
    '            .Columns.Add("PL_MeritedPaySum", GetType(String))
    '            .Columns.Add("TotalSum", GetType(String))
    '            .Columns.Add("Dep_NameSum", GetType(String))
    '            .Columns.Add("Fac_NameSum", GetType(String))

    '        End With
    '    End Function
    '    ''' <summary>
    '    ''' 根據 員工基本表。 查詢出員工編號，姓名 查詢 出個人計件總額，組別計件總額
    '    ''' </summary>
    '    ''' <param name="_Per_NO"></param>
    '    ''' <param name="_Dep_ID"></param>
    '    ''' <param name="_Fac_ID"></param>
    '    ''' <param name="_YYMMSum"></param>
    '    ''' <param name="_ds"></param>
    '    ''' <returns></returns>
    '    ''' <remarks></remarks>
    '    Public Function AddRow(ByVal _Per_NO As String, ByVal _Dep_ID As String, ByVal _Fac_ID As String, ByVal _YYMMSum As String, ByVal _ds As DataSet) As Boolean   ''
    '        AddRow = True

    '        Dim i As Integer

    '        Dim pppc As New ProductionPiecePersonnelControl
    '        Dim pppL As New List(Of ProductionPiecePersonnelInfo)

    '        _ds.Clear()

    '        pppL = pppc.ProductionPiecePersonnel_GetList(Nothing, _Per_NO, Nothing, Nothing, _Dep_ID, _Fac_ID, Nothing, Nothing, Nothing, "False", Nothing)

    '        If pppL.Count > 0 Then
    '        Else
    '            Exit Function
    '        End If

    '        For i = 0 To pppL.Count - 1
    '            Dim row1 As DataRow = _ds.Tables("PerWG").NewRow

    '            row1("Per_NOSum") = pppL(i).Per_NO
    '            row1("Per_NameSum") = pppL(i).Per_Name

    '            row1("Dep_IDSum") = pppL(i).DepID
    '            row1("Fac_IDSum") = pppL(i).FacID

    '            row1("Dep_NameSum") = pppL(i).Per_DepName
    '            row1("Fac_NameSum") = pppL(i).Per_FacName

    '            row1("YYMMSum") = _YYMMSum
    '            Dim DoublePYS_MeritedPaySum As Double
    '            Dim DoublePL_MeritedPaySum As Double

    '            DoublePYS_MeritedPaySum = Get_PYS_MeritedPaySum(pppL(i).Per_NO, Nothing, Nothing, _YYMMSum) '合計所有記錄
    '            DoublePL_MeritedPaySum = Get_PL_MeritedPaySum(pppL(i).Per_NO, Nothing, Nothing, _YYMMSum)

    '            row1("PYS_MeritedPaySum") = DoublePYS_MeritedPaySum
    '            row1("PL_MeritedPaySum") = DoublePL_MeritedPaySum

    '            row1("TotalSum") = DoublePYS_MeritedPaySum + DoublePL_MeritedPaySum

    '            _ds.Tables("PerWG").Rows.Add(row1)
    '        Next

    '        Grid1.DataSource = _ds.Tables("PerWG")


    '    End Function   ''已不用


    '    ''' <summary>
    '    ''' 組別計件的人員 薪金
    '    ''' </summary>
    '    ''' <param name="_Per_NO"></param>
    '    ''' <param name="_Dep_ID"></param>
    '    ''' <param name="_YYMMSum"></param>
    '    ''' <returns></returns>
    '    ''' <remarks></remarks>
    '    Function Get_PYS_MeritedPaySum(ByVal _Per_NO As String, ByVal _Dep_ID As String, ByVal _Fac_ID As String, ByVal _YYMMSum As String) As Double '已不用
    '        Get_PYS_MeritedPaySum = 0

    '        Dim i, j As Integer

    '        Dim PPWGC As New ProductionPiecePayWGMainControl
    '        Dim PPWGL As New List(Of ProductionPiecePayWGMainInfo)

    '        ''查詢主表
    '        PPWGL = PPWGC.ProductionPiecePayWGMain_GetList(Nothing, Nothing, Nothing, _YYMMSum, Nothing, Nothing, _Dep_ID, Nothing, Nothing, Nothing, "True")

    '        If PPWGL.Count <= 0 Then
    '            Exit Function
    '        End If

    '        For i = 0 To PPWGL.Count - 1

    '            Dim PPWGCs As New ProductionPiecePayWGSubControl
    '            Dim PPWGLs As New List(Of ProductionPiecePayWGSubInfo)

    '            PPWGLs = PPWGCs.ProductionPiecePayWGSub_GetList(Nothing, PPWGL(i).PY_ID, _Per_NO, Nothing)

    '            If PPWGLs.Count <= 0 Then
    '                GoTo AA
    '            End If

    '            For j = 0 To PPWGLs.Count - 1
    '                Get_PYS_MeritedPaySum = Get_PYS_MeritedPaySum + PPWGLs(j).PYS_MeritedPay
    '            Next

    'AA:
    '        Next

    '    End Function '已不用
    '    ''' <summary>
    '    ''' 個人計件公資組合
    '    ''' </summary>
    '    ''' <param name="_Per_NO"></param>
    '    ''' <param name="_Dep_ID"></param>
    '    ''' <param name="_Fac_ID"></param>
    '    ''' <param name="_YYMMSum"></param>
    '    ''' <returns></returns>
    '    ''' <remarks></remarks>
    '    Function Get_PL_MeritedPaySum(ByVal _Per_NO As String, ByVal _Dep_ID As String, ByVal _Fac_ID As String, ByVal _YYMMSum As String) As Double '已不用
    '        Get_PL_MeritedPaySum = 0

    '        Dim i As Integer

    '        Dim PayC As New ProductionPiecePayPersonnelContol
    '        Dim PayL As New List(Of ProductionPiecePayPersonnelInfo)

    '        ''查詢主表
    '        PayL = PayC.ProductionPiecePayPersonnel_GetList(Nothing, _Per_NO, Nothing, _YYMMSum, _Dep_ID, "True", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    '        If PayL.Count <= 0 Then
    '            Exit Function
    '        End If

    '        For i = 0 To PayL.Count - 1
    '            Get_PL_MeritedPaySum = Get_PL_MeritedPaySum + PayL(i).PL_MeritedPay
    '        Next

    '    End Function '已不用

    Private Sub cmdQuery3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery3.Click
        'tempValue2 = "個人薪金查詢"

        'frmProductionPiecePayFind.ShowDialog()

        'If tempValue = "F" Then

        '    Dim payp As New ProductionPayPersonnelContol
        '    Grid1.DataSource = payp.ProductionPieceMeritedPaySum_View(tempValue6, tempValue4, tempValue3, tempValue5, tempValue7)
        'End If

        'frmProductionPiecePayFind.Dispose()

        'tempValue = Nothing
        'tempValue2 = Nothing
        'tempValue3 = Nothing
        'tempValue4 = Nothing
        'tempValue5 = Nothing
        'tempValue6 = Nothing
        'tempValue7 = Nothing

        tempValue = "個人計件薪金匯總"
        ProductionPieceSelectAll.ShowDialog()

        Dim payp As New ProductionPayPersonnelContol

        Select Case tempValue
            Case "0" '自定義  (不用自定義)

            Case "1" '固定模式
                If tempValue3 = "廠証編號" Then
                    Grid1.DataSource = payp.ProductionPieceMeritedPaySum_View(tempValue4, strInDepID, Nothing, tempValue2, tempValue6)
                End If
            Case "2" '廠別 部門
                Grid1.DataSource = payp.ProductionPieceMeritedPaySum_View(tempValue4, tempValue2, Nothing, Nothing, tempValue6)

        End Select

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing

        ProductionPieceSelectAll.Dispose()

    End Sub

    Private Sub cmdRef3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRef3.Click
        Dim payp As New ProductionPayPersonnelContol
        Grid1.DataSource = payp.ProductionPieceMeritedPaySum_View(Format(Now, "yyyy/MM"), strInDepID, Nothing, Nothing, "True")
    End Sub

    Private Sub cmdQuery2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery2.Click
        'tempValue2 = "組別計件薪金查詢"

        'frmProductionPiecePayFind.ShowDialog()

        'If tempValue = "F" Then
        '    Dim pfc As New ProductionPiecePayWGMainControl
        '    Grid1.DataSource = pfc.ProductionPiecePayWGMain_GetList(Nothing, Nothing, tempValue5, tempValue6, Nothing, Nothing, tempValue4, tempValue3, Nothing, Nothing, tempValue7)
        'End If

        'frmProductionPiecePayFind.Dispose()

        'tempValue = Nothing
        'tempValue2 = Nothing
        'tempValue3 = Nothing
        'tempValue4 = Nothing
        'tempValue5 = Nothing
        'tempValue6 = Nothing
        'tempValue7 = Nothing

        '2012-8-16
        tempValue = "組別計件薪金"
        ProductionPieceSelectAll.ShowDialog()

        Dim pfc As New ProductionPiecePayWGMainControl

        Select Case tempValue
            Case "0" '自定義
                Dim PPS As New LFERP.Library.ProductionPiece_Select.ProductionPiece_SelectControl
                Grid1.DataSource = PPS.ProductionPiecePayWGMain_GetListSelect("組別計件薪金", tempValue2)

            Case "1" '固定模式
                If tempValue3 = "組別編號" Then
                    Grid1.DataSource = pfc.ProductionPiecePayWGMain_GetList(Nothing, Nothing, tempValue2, tempValue4, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, tempValue6)
                End If
            Case "2" '廠別 部門
                Grid1.DataSource = pfc.ProductionPiecePayWGMain_GetList(Nothing, Nothing, Nothing, tempValue4, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, tempValue6)
        End Select

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing

        ProductionPieceSelectAll.Dispose()
    End Sub

    Private Sub cmdPrintNoPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintNoPrice.Click
        'Dim strA As String
        'If GridView1.RowCount > 0 Then
        '    strA = GridView1.GetFocusedRowCellValue("Per_NO")
        '    tempValue8 = strA
        'End If


        'tempValue2 = "個人計件薪金打印"
        'frmProductionPiecePayFind.ShowDialog()

        'frmProductionPiecePayFind.Dispose()

        'tempValue = Nothing
        'tempValue2 = Nothing
        'tempValue3 = Nothing
        'tempValue4 = Nothing
        'tempValue5 = Nothing
        'tempValue6 = Nothing
        'tempValue7 = Nothing

        '2012-8-16
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("Per_NO")

        tempValue = "個人計件薪金列印"
        tempValue8 = strA
        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()


    End Sub

    Private Sub cmdPrintNoPrice2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintNoPrice2.Click

        'Dim strA As String
        'If GridView1.RowCount > 0 Then
        '    strA = GridView1.GetFocusedRowCellValue("G_NO")
        '    tempValue8 = strA
        'End If


        'tempValue2 = "組別計件薪金打印"
        'frmProductionPiecePayFind.ShowDialog()

        'frmProductionPiecePayFind.Dispose()

        'tempValue = Nothing
        'tempValue2 = Nothing
        'tempValue3 = Nothing
        'tempValue4 = Nothing
        'tempValue5 = Nothing
        'tempValue6 = Nothing
        'tempValue7 = Nothing

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("G_NO")
        tempValue8 = strA

        tempValue = "組別計件薪金列印"

        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()
    End Sub

    Private Sub cmdPrintNoPrice3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintNoPrice3.Click
        'Dim strA As String
        'If GridView1.RowCount > 0 Then
        '    strA = GridView1.GetFocusedRowCellValue("Per_NOSum")
        '    tempValue8 = strA
        'End If

        ' ''個人工資
        'tempValue2 = "個人薪金打印"

        'frmProductionPiecePayFind.ShowDialog()
        'frmProductionPiecePayFind.Dispose()

        'tempValue = Nothing
        'tempValue2 = Nothing
        'tempValue3 = Nothing
        'tempValue4 = Nothing
        'tempValue5 = Nothing
        'tempValue6 = Nothing
        'tempValue7 = Nothing

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("Per_NO")

        tempValue = "個人計件薪金匯總列印"
        tempValue8 = strA
        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()


    End Sub



    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        'If DoublClickBZ = "MenuStrip1" Then
        '    cmdView_Click(Nothing, Nothing)
        'End If

        'If DoublClickBZ = "MenuStrip2" Then
        '    cmdView2_Click(Nothing, Nothing)
        'End If

        If DoublClickBZ = "MenuStrip1" Then
            If cmdCheck.Enabled = True Then
                cmdCheck_Click(Nothing, Nothing)
            Else
                cmdView_Click(Nothing, Nothing)
            End If

        End If

        If DoublClickBZ = "MenuStrip2" Then
            If cmdCheck2.Enabled = True Then
                cmdCheck2_Click(Nothing, Nothing)
            Else
                cmdView2_Click(Nothing, Nothing)
            End If
        End If

    End Sub


    Private Sub ExpotExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpotExcelToolStripMenuItem.Click
        Dim StrA As String, StrB As String

        StrA = "廠證編號, 姓名, 年月,班制, 廠別名稱, 部門編號, 部門名稱, 日薪, 上班天數, 平時加班, 假日加班, 應補金額, 應扣金額, 工資, 審核, 操作員,"
        StrB = "Per_NO, Per_Name, PL_YYMM, Per_Class, PL_FacName, DepID, PL_DepName, Per_DayPrice, PL_OnDutyDays, PL_UsualOverHours, PL_HolidayOVerHours, PL_CompensateSum, PL_SubtractSum, PL_MeritedPay, PL_Check, PL_AddUserName,"
        DtToXlsOK(Me.GridView1, "個人計件清單", "2007", StrB, StrA)

    End Sub

    Private Sub ExpotExcelToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpotExcelToolStripMenuItem2.Click
        Dim StrA As String, StrB As String
        StrA = "員工編號,員工姓名,部門,廠別,年月,組別計件工資,個人計件工資,薪金合計,"
        StrB = "Per_NO,Per_Name,Per_DepName,Per_FacName,PaySum_YYMM,PYS_MeritedPaySum,PL_MeritedPaySum,TotalSum,"
        DtToXlsOK(Me.GridView1, "個人計件薪金清單", "2007", StrB, StrA)
    End Sub

    Private Sub ExpotExcelToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpotExcelToolStripMenuItem1.Click
        Dim StrA As String, StrB As String

        StrA = "單號,組別編號,組別名稱,年月,廠別名稱,部門名稱,完成總金額,耗用總金額,計時總金額,計件總金額,應補金額,應扣金額,審核,操作員,"
        StrB = "PY_ID, G_NO, PY_G_Name, PY_YYMM, PY_FacName, PY_DepName, PY_CompleteSum, PY_UseSum, PY_TimeSum, PY_PieceSum, PY_CompensateSum, PY_SubtractSum, PY_Check, PY_AddUserName,"
        DtToXlsOK(Me.GridView1, "組別計件清單", "2007", StrB, StrA)
    End Sub

    Private Sub ToolPiecePersonelCollect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPiecePersonelCollect.Click
        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("Per_NO")

        tempValue = "個人日計件匯總列印"
        tempValue8 = strA
        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()
    End Sub

    Private Sub ToolPieceWGCollect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPieceWGCollect.Click

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("G_NO")

        tempValue = "組別計件日匯總列印"
        tempValue8 = strA
        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()
    End Sub

    Private Sub ToolPieceWGPersonelDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPieceWGPersonelDetail.Click

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("G_NO")
        tempValue8 = strA

        tempValue = "組別計件個人明細列印"

        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()
    End Sub

    Private Sub ToolPiecePersonelCollectDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPiecePersonelCollectDay.Click
        tempValue = "個人日計件匯總部門列印"

        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing

        ProductionPieceSelectAll.Dispose()
    End Sub

    Private Sub ToolPieceWGPersonelMoth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPieceWGPersonelMoth.Click

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("G_NO")
        tempValue8 = strA
        tempValue = "組別名單匯總列印"
        ProductionPieceSelectAll.ShowDialog()

        tempValue = Nothing
        tempValue8 = Nothing
        ProductionPieceSelectAll.Dispose()
    End Sub

    Private Sub ToolStripMenuLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuLoad.Click
        frmProductionPiecePayGroupLoad.ShowDialog()
        frmProductionPiecePayGroupLoad.Dispose()
    End Sub

    Private Sub ToolStripMenuSameSamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuSameSamp.Click
        frmProductionPiecePaySampType.ShowDialog()
        frmProductionPiecePaySampType.Dispose()
    End Sub
End Class
Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionPiecePayPersonnel
Imports LFERP.DataSetting

Imports lferp.Library.ProductionSumPiecePersonnel
Imports LFERP.Library.ProductionSumTimePersonnel
Imports LFERP.Library.ProductionSumTimeWorkGroup
Imports LFERP.Library.ProductionSumPieceWorkGroup
Imports LFERP.Library.ProductionPiecePersonnelDay



Public Class frmProductionPieceUnusual
    Dim ds As New DataSet
    Dim ds1 As New DataSet

    Dim Load_OK As String ''確定Load事件是否已載入完畢

    Private Sub frmProductionPieceUnusual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '加載廠別名稱()
        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)

        Start_Date.EditValue = Format(Now, "yyyy/MM/dd")
        End_Date.EditValue = Format(Now, "yyyy/MM/dd")

        Create_Table()

        Load_OK = "OK"

        ''--------------------查詢時用戶權限------------------------
        If strInUserRank = "生產部" Then
            lueFacID.EditValue = strInFacIDFull
        ElseIf strInUserRank = "管理" Then
        ElseIf strInUserRank = "統計" Then
            lueFacID.EditValue = strInFacIDFull
            lueDepID.EditValue = strInDepIDFull
        End If

    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Dim dc As New DepartmentControler
        If lueFacID.EditValue Is Nothing Then Exit Sub

        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)
    End Sub

    Private Sub lueDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDepID.EditValueChanged
        If lueFacID.EditValue Is Nothing Then Exit Sub
        If lueDepID.EditValue Is Nothing Then Exit Sub

        Dim ptc As New ProductionPiecePersonnelControl  ''載入 員工編號---姓名---部門
        txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing, "False", Nothing, Nothing)
        txtPer_NO.Properties.DisplayMember = "Per_Name"
        txtPer_NO.Properties.ValueMember = "Per_NO"
    End Sub

    Sub Create_Table()
        With ds.Tables.Add("PieceUnusual")
            .Columns.Add("TPer_NOName", GetType(String))
            .Columns.Add("TID", GetType(String))
            .Columns.Add("TPID", GetType(String))
        End With
        TreeList1.DataSource = ds.Tables("PieceUnusual")
        '組別計件 同一天，同一個人兩個組工作
        With ds.Tables.Add("SumPieceWorkGroup")
            .Columns.Add("GP_NO", GetType(String))
            .Columns.Add("G_NO", GetType(String))
            .Columns.Add("GP_G_Name", GetType(String))
            .Columns.Add("GP_DepName", GetType(String))

            .Columns.Add("GP_FacName", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("PS_Name", GetType(String))

            .Columns.Add("PS_NameS", GetType(String))
            .Columns.Add("GP_Qty", GetType(String))
            .Columns.Add("GP_Date", GetType(String))
            .Columns.Add("GP_ActionName", GetType(String))
        End With
        Grid3.DataSource = ds.Tables("SumPieceWorkGroup")

    End Sub
    ''' <summary>
    ''' 列出  個人計時，計件。組別計時，計件中同一天內，存在兩種以上的作業 的人員名單(用了6個視圖)
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function FindPieceUnusualPerWG() As String
        FindPieceUnusualPerWG = ""
        Dim i As Integer

        Dim strLS1, strLS2 As String
        strLS1 = ""
        strLS2 = ""

        ds.Tables("PieceUnusual").Clear()
        clr_Data()


        Dim PWGC As New ProductionPiecePayPersonnelContol
        Dim PWGL As New List(Of ProductionPiecePayPersonnelInfo)

        PWGL = PWGC.ProductionSumPieceTimePerWGView(txtPer_NO.EditValue, lueFacID.EditValue, lueDepID.EditValue, Start_Date.EditValue, End_Date.EditValue)

        If PWGL.Count <= 0 Then Exit Function

        For i = 0 To PWGL.Count - 1

            Dim ppc As New ProductionPiecePersonnelControl
            Dim pl As New List(Of ProductionPiecePersonnelInfo)
            pl = ppc.ProductionPiecePersonnel_GetList(Nothing, PWGL(i).Per_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, False, Nothing, Nothing)
            If pl.Count <= 0 Then Exit Function

            If strLS2 <> PWGL(i).Per_NO Then
                Dim row1 As DataRow
                row1 = ds.Tables("PieceUnusual").NewRow()
                row1("TID") = PWGL(i).Per_NO '主字段
                row1("TPID") = Nothing '從字段
                row1("TPer_NOName") = pl(0).Per_Name
                ds.Tables("PieceUnusual").Rows.Add(row1)
            End If

            ''----------------------------------------------------------------------
            Dim row As DataRow
            row = ds.Tables("PieceUnusual").NewRow()
            If strLS1 <> PWGL(i).WPdate And strLS2 = PWGL(i).Per_NO Then
                row("TID") = Trim(PWGL(i).Per_NO & "," & PWGL(i).WPdate) '主字段
                row("TPID") = PWGL(i).Per_NO '從字段
                row("TPer_NOName") = PWGL(i).WPdate
            Else
                If strLS2 <> PWGL(i).Per_NO Then
                    row("TID") = Trim(PWGL(i).Per_NO & "," & PWGL(i).WPdate)
                    row("TPID") = PWGL(i).Per_NO
                    row("TPer_NOName") = PWGL(i).WPdate
                End If
            End If
            ds.Tables("PieceUnusual").Rows.Add(row)
            ''----------------------------------------------------------------------
            strLS1 = PWGL(i).WPdate
            strLS2 = PWGL(i).Per_NO
        Next
    End Function

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        FindPieceUnusualPerWG() 'FindPieceUnusual()
    End Sub

    Private Sub TreeList1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.Click
        '列出詳細
        If TreeList1.Nodes.Count <= 0 Then Exit Sub

        Dim strA As String
        If Load_OK = "OK" Then
            strA = TreeList1.FocusedNode.Item("TID").ToString()
            If InStr(strA, ",", CompareMethod.Text) > 0 Then
                Dim StrAarray As Array = Split(strA, ",")
                Refresh_Grid(Trim(StrAarray(0)), Trim(StrAarray(1)))
            End If
        End If
    End Sub

    Sub clr_Data()

        XtraTabPage1.Text = "個人計件"
        XtraTabPage2.Text = "個人計時"
        XtraTabPage3.Text = "組別計件"
        XtraTabPage4.Text = "組別計時"

        Grid1.DataSource = Nothing
        Grid2.DataSource = Nothing
        Grid3.DataSource = Nothing
        Grid4.DataSource = Nothing

        ds.Tables("SumPieceWorkGroup").Clear()
    End Sub

    Function Refresh_Grid(ByVal _Per_NO As String, ByVal _Date As String) As String
        Refresh_Grid = ""

        clr_Data()

        XtraTabPage1.PageVisible = False
        XtraTabPage2.PageVisible = False
        XtraTabPage3.PageVisible = False
        XtraTabPage4.PageVisible = False

        ''刷新個人計件
        Dim perPC As New ProductionSumPiecePersonnelControl
        Dim perPL As New List(Of ProductionSumPiecePersonnelInfo)

        perPL = perPC.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, _Per_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _Date, Nothing, _Date, Nothing)
        Grid1.DataSource = perPL

        If perPL.Count > 0 Then
            XtraTabPage1.PageVisible = True
            XtraTabPage1.Text = XtraTabPage1.Text & "(" & perPL.Count & ")"
        End If

        ''刷新個人計時
        Dim perTC As New ProductionSumTimePersonnelControl
        Dim perTL As New List(Of ProductionSumTimePersonnelInfo)

        perTL = perTC.ProductionSumTimePersonnel_GetList(Nothing, _Per_NO, Nothing, Nothing, Nothing, _Date, Nothing, _Date, Nothing, Nothing, Nothing)
        Grid2.DataSource = perTL

        If perTL.Count > 0 Then
            XtraTabPage2.PageVisible = True
            XtraTabPage2.Text = XtraTabPage2.Text & "(" & perTL.Count & ")"
        End If

        ''''刷新組別計時

        Dim wgTC As New ProductionSumTimeWorkGroupControl
        Dim wgTL As New List(Of ProductionSumTimeWorkGroupInfo)

        wgTL = wgTC.ProductionSumTimeWorkGroup_GetList(Nothing, _Per_NO, Nothing, Nothing, Nothing, _Date, Nothing, _Date, Nothing, Nothing)
        Grid4.DataSource = wgTL

        If wgTL.Count > 0 Then
            XtraTabPage4.PageVisible = True
            XtraTabPage4.Text = XtraTabPage4.Text & "(" & wgTL.Count & ")"
        End If

        ''組別計件，先從每日人員名單中查詢出，某天的記錄中的組別編號 ，再在組別計件中查詢
        Dim wgPdayc As New ProductionPiecePersonnelDayControl
        Dim wgPdayl As New List(Of ProductionPiecePersonnelDayInfo)
        Dim i, j As Integer

        wgPdayl = wgPdayc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, _Per_NO, Nothing, Nothing, Nothing, Nothing, Nothing, _Date, Nothing, False, _Date, Nothing)
        If wgPdayl.Count > 0 Then
            For i = 0 To wgPdayl.Count - 1
                Dim wgPC As New ProductionSumPieceWorkGroupControl
                Dim wgPL As New List(Of ProductionSumPieceWorkGroupInfo)

                wgPL = wgPC.ProductionSumPieceWorkGroup_GetList(Nothing, Nothing, Nothing, wgPdayl(i).G_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, _Date, Nothing, _Date, Nothing)

                If wgPL.Count > 0 Then
                    For j = 0 To wgPL.Count - 1
                        Dim row1 As DataRow
                        row1 = ds.Tables("SumPieceWorkGroup").NewRow()
                        row1("GP_NO") = wgPL(j).GP_NO
                        row1("G_NO") = wgPL(j).G_NO
                        row1("GP_G_Name") = wgPL(j).GP_G_Name
                        row1("GP_DepName") = wgPL(j).GP_DepName

                        row1("GP_FacName") = wgPL(j).GP_FacName
                        row1("PM_M_Code") = wgPL(j).PM_M_Code
                        row1("PM_Type") = wgPL(j).PM_Type
                        row1("PS_Name") = wgPL(j).PS_Name

                        row1("PS_NameS") = wgPL(j).PS_NameS
                        row1("GP_Qty") = wgPL(j).GP_Qty
                        row1("GP_Date") = wgPL(j).GP_Date
                        row1("GP_ActionName") = wgPL(j).GP_ActionName

                        ds.Tables("SumPieceWorkGroup").Rows.Add(row1)
                    Next
                End If
            Next
        End If

        If ds.Tables("SumPieceWorkGroup").Rows.Count > 0 Then
            XtraTabPage3.PageVisible = True
            XtraTabPage3.Text = XtraTabPage3.Text & "(" & ds.Tables("SumPieceWorkGroup").Rows.Count & ")"
        End If

        Grid3.DataSource = ds.Tables("SumPieceWorkGroup")


    End Function

    ''個人計件查看
    Private Sub Grid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.DoubleClick
        If GridView1.RowCount <= 0 Then Exit Sub
        MTypeName = "PPView" ''查看
        tempValue2 = GridView1.GetFocusedRowCellValue("PP_NO").ToString
        ProductionSumPiecePersonnel.ShowDialog()
        ProductionSumPiecePersonnel.Dispose()
    End Sub

    ''組別計件
    Private Sub Grid3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid3.DoubleClick
        If GridView3.RowCount <= 0 Then Exit Sub
        MTypeName = "GPView" ''查看
        tempValue2 = GridView3.GetFocusedRowCellValue("GP_NO").ToString
        ProductionSumPieceWorkGroup.ShowDialog()
        ProductionSumPieceWorkGroup.Dispose()
    End Sub

    '組別計時
    Private Sub Grid4_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid4.DoubleClick
        If GridView2.RowCount <= 0 Then Exit Sub
        MTypeName = "GTView" ''查看
        tempValue2 = GridView2.GetFocusedRowCellValue("GT_NO").ToString

        ProductionSumTimeWorkGroup.ShowDialog()
        ProductionSumTimePersonnel.Dispose()
    End Sub


    '個人計時查看 
    Private Sub Grid2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid2.DoubleClick
        If GridView4.RowCount <= 0 Then Exit Sub
        MTypeName = "PTView" ''查看
        tempValue2 = GridView4.GetFocusedRowCellValue("PT_NO").ToString
        tempValue4 = strInDepID
        ProductionSumTimePersonnel.ShowDialog()
        ProductionSumTimePersonnel.Dispose()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        '''''''查詢出人員名單/日期
        Dim _strPer_NO As String
        Dim _strFacID As String
        Dim _strDepID As String
        Dim _strStartDate As String
        Dim _strEndDate As String

        _strPer_NO = txtPer_NO.EditValue
        _strFacID = lueFacID.EditValue
        _strDepID = lueDepID.EditValue
        _strStartDate = Start_Date.EditValue
        _strEndDate = End_Date.EditValue

        DS1.Tables.Clear()

        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet
        Dim ltc5 As New CollectionToDataSet
        Dim ltc6 As New CollectionToDataSet
        Dim ltc7 As New CollectionToDataSet
        Dim ltc8 As New CollectionToDataSet

        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim pppc As New ProductionPiecePersonnelControl
        Dim PWGC As New ProductionPiecePayPersonnelContol
        Dim ppdc As New ProductionPiecePersonnelDayControl
        Dim PPWGC As New ProductionSumPieceWorkGroupControl
        Dim PTWGC As New ProductionSumTimeWorkGroupControl
        Dim PPPerC As New ProductionSumPiecePersonnelControl
        Dim PTPerC As New ProductionSumTimePersonnelControl

        If PWGC.ProductionSumPieceTimePerWGView(_strPer_NO, _strFacID, _strDepID, _strStartDate, _strEndDate).Count <= 0 Then
            MsgBox("無異常數據存在!")
            Exit Sub
        End If

        ltc1.CollToDataSet(ds1, "Company", mcCompany.Company_Getlist(Mid(strInDPT_ID, 1, 4), Nothing, Nothing, Nothing))
        ltc2.CollToDataSet(ds1, "ProductionSumPieceTimePerWGView", PWGC.ProductionSumPieceTimePerWGView(_strPer_NO, _strFacID, _strDepID, _strStartDate, _strEndDate))
        ltc3.CollToDataSet(ds1, "ProductionPiecePersonnel", pppc.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        '組別計件
        ltc4.CollToDataSet(ds1, "ProductionPiecePersonnelDay", ppdc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        ltc5.CollToDataSet(ds1, "ProductionSumPieceWorkGroup", PPWGC.ProductionSumPieceWorkGroup_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        '組別計時
        ltc6.CollToDataSet(ds1, "ProductionSumTimeWorkGroup", PTWGC.ProductionSumTimeWorkGroup_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        '個人計件
        ltc7.CollToDataSet(ds1, "ProductionSumPiecePersonnel", PPPerC.ProductionSumPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        '個人計時
        ltc8.CollToDataSet(ds1, "ProductionSumTimePersonnel", PTPerC.ProductionSumTimePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        PreviewRPT(ds1, "rptProductionPieceUnusual", "計件異常清單", True, True)
        
        ltc1 = Nothing
        ltc2 = Nothing
        ltc3 = Nothing
        ltc4 = Nothing
        ltc5 = Nothing
        ltc6 = Nothing
        ltc7 = Nothing
        ltc8 = Nothing

    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged

    End Sub
End Class
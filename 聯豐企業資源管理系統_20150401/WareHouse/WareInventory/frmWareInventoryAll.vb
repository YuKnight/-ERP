Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.WareHouseDetail
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.Library.WareHouse.WareMove
Imports LFERP.Library.WareHouse.WareInput


Public Class frmWareInventoryAll

    Private Sub frmWareInventoryAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = tempValue
        txtCode.Focus()
        txtCode.Text = tempValue2
        tempValue = ""
        tempValue2 = ""
        'Grid.DataSource = Nothing
        'Grid1.DataSource = Nothing
        'Grid2.DataSource = Nothing
        'Grid3.DataSource = Nothing
        'Grid4.DataSource = Nothing

        DateEdit1.Text = Format(Now, "yyyy/MM/dd")
        DateEdit2.Text = Format(Now, "yyyy/MM/dd")
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False

    End Sub

    'Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
    '    If DateEdit1.Text = "" Then
    '        MsgBox("開始日期不能為空!")
    '        Exit Sub
    '    End If
    '    If DateEdit2.Text = "" Then
    '        MsgBox("截止日期不能為空!")
    '        Exit Sub
    '    End If

    '    If Len(txtCode.Text.Trim) = 0 Then
    '        'tempValue = Nothing
    '        MsgBox("請輸入物料編碼信息!")
    '        Exit Sub
    '    Else
    '        If Len(txtCode.Text) <> 17 Then
    '            MsgBox("請正確輸入物料編碼")
    '            txtCode.Text = ""
    '            Exit Sub
    '        Else
    '            tempValue = "'" & txtCode.Text & "'"
    '        End If
    '    End If
    '    Dim wi As List(Of WareInventoryInfo)
    '    Dim wc As New WareInventoryMTController

    '    Dim wic As New WareInputContraller
    '    Dim woc As New WareOutController
    '    Dim wmc As New WareMoveController

    '    wi = wc.WareHouseCode_GetList(Label3.Text, txtCode.Text, DateEdit1.Text, DateEdit2.Text)
    '    If wi.Count = 0 Then
    '        MsgBox("當前物料在此日期範圍內無任何操作記錄!")
    '        Grid.DataSource = ""
    '        Exit Sub
    '    Else
    '        Grid.DataSource = wc.WareHouseCode_GetList(Label3.Text, txtCode.Text, DateEdit1.Text, DateEdit2.Text)
    '        '當前物料入庫明細
    '        Grid1.DataSource = wic.WareInput_Getlist(Nothing, Nothing, txtCode.Text, Nothing, Label3.Text, Nothing, DateEdit1.Text, DateEdit2.Text, Nothing, Nothing)
    '        '當前物料出庫明細
    '        Grid2.DataSource = woc.WareOut_GetList1(Nothing, Label3.Text, txtCode.Text, Nothing, Nothing, DateEdit1.Text, DateEdit2.Text, Nothing, Nothing)
    '        '當前物料調撥收入明細
    '        Grid3.DataSource = wmc.WareMove_GetList1(Nothing, txtCode.Text, Nothing, Label3.Text, Nothing, "收料", Nothing, Nothing, "2", DateEdit1.Text, DateEdit2.Text)
    '        '當前物料調撥發出明細
    '        Grid4.DataSource = wmc.WareMove_GetList1(Nothing, txtCode.Text, Nothing, Label3.Text, Nothing, "發料", Nothing, Nothing, "2", DateEdit1.Text, DateEdit2.Text)
    '    End If

    'End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdPrint_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim ds As New DataSet

        Dim pdi As New Library.Production.ProductionFieldDaySummary.ProductionFieldDaySummaryInfo
        Dim pdc As New Library.Production.ProductionFieldDaySummary.ProductionFieldDaySummaryControl

        Dim strDateEdit1 As String
        Dim strDateEdit2 As String
        Dim strDateA As String

        If CheckBoxAll.Checked = True Then
            strDateEdit1 = Nothing
            strDateEdit2 = Nothing
            strDateA = ""
        Else
            If DateEdit1.Text = "" Then
                MsgBox("開始日期不能為空!")
                Exit Sub
            End If
            If DateEdit2.Text = "" Then
                MsgBox("截止日期不能為空!")
                Exit Sub
            End If
            strDateEdit1 = DateEdit1.Text
            strDateEdit2 = DateEdit2.Text
            strDateA = strDateEdit1 & "至" & strDateEdit2
        End If

    

        If Len(txtCode.Text.Trim) = 0 Then
            'tempValue = Nothing
            MsgBox("請輸入物料編碼信息!")
            Exit Sub
        Else
            If Len(txtCode.Text) <= 0 Then
                MsgBox("請正確輸入物料編碼")
                txtCode.Text = ""
                Exit Sub
            Else
                tempValue = "'" & txtCode.Text & "'"
            End If
        End If

        'pdi.Str1 = strDateEdit1
        'pdi.Str2 = strDateEdit2

        'pdc.Temp3_Add(pdi)


        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        'Dim ltc3 As New CollectionToDataSet



        Dim pmc As New Library.WareHouse.WareInventory.WareInventoryMTController
        Dim wdc As New WareHouseDetailControl

        If pmc.WareInventory_GetList3(txtCode.Text, Label3.Text, "True").Count = 0 Then
            MsgBox("在當前倉庫中不存在此物料信息!請核查!")
            Exit Sub
        End If

        If wdc.WareHouseDetail_GetList1(Label3.Text, txtCode.Text, strDateEdit1, strDateEdit2).Count = 0 Then
            MsgBox("當前物料此日期範圍內,無任何操作記錄!")
            Exit Sub
        End If

        '
        ltc.CollToDataSet(ds, "WareInventory", pmc.WareInventory_GetList3(txtCode.Text, Label3.Text, "True"))


        If RadioButton1.Checked = True Then
            ltc1.CollToDataSet(ds, "WareInventorySearch", wdc.WareHouseDetail_GetList5(Label3.Text, txtCode.Text, strDateEdit1, strDateEdit2, "OUT"))
            PreviewRPTDialog1(ds, "rptWareHoustDetail1", "物料數據變更記錄", strDateA, "出庫", True, True)
        ElseIf RadioButton2.Checked = True Then
            ltc1.CollToDataSet(ds, "WareInventorySearch", wdc.WareHouseDetail_GetList5(Label3.Text, txtCode.Text, strDateEdit1, strDateEdit2, "IN"))
            PreviewRPTDialog1(ds, "rptWareHoustDetail1", "物料數據變更記錄", strDateA, "入庫", True, True)
        ElseIf RadioButton3.Checked = True Then
            ltc2.CollToDataSet(ds, "Temp3", pdc.Temp3_GetList(Nothing, Nothing))


            ltc1.CollToDataSet(ds, "WareInventorySearch", wdc.WareHouseDetail_GetList1(Label3.Text, txtCode.Text, strDateEdit1, strDateEdit2))
            PreviewRPTDialog1(ds, "rptWareHoustDetail", "物料數據變更記錄", strDateA, "", True, True)
        End If
        ltc = Nothing
        ltc1 = Nothing
        ltc2 = Nothing
       
       

    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        'tempCode = ""
        'tempValue6 = "倉庫庫存查詢"
        'frmBOMSelect.ShowDialog()

        'txtCode.Text = tempCode
        'tempCode = ""

        ''2013-11-21-----------------------

        tempCode = ""
        tempValue6 = "倉庫庫存查詢"
        frmBOMSelect.ShowDialog()

        If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 2 Then
            txtCode.Text = tempValue
            tempValue = Nothing
        Else
            txtCode.Text = tempCode
            tempCode = Nothing
        End If

        



    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        ' ''Dim wi As New List(Of WareInventoryInfo)
        ' ''Dim wc As New WareInventoryMTController
        ' ''If CheckBoxAll.Checked = True Then
        ' ''    wi = wc.WareHouseCode_GetList(Label3.Text, txtCode.Text, "2000/01/01", Format(Now, "yyyy/MM/dd"))
        ' ''Else
        ' ''    wi = wc.WareHouseCode_GetList(Label3.Text, txtCode.Text, DateEdit1.Text, DateEdit2.Text)
        ' ''End If

        ' ''If wi.Count = 0 Then
        ' ''    Label7.Text = "0"
        ' ''    Label8.Text = "0"
        ' ''Else
        ' ''    Label7.Text = wi(0).OutQty
        ' ''    Label8.Text = wi(0).InQty
        ' ''End If

        Label7.Text = "0"
        Label8.Text = "0"

        Dim wdc As New WareHouseDetailControl
        Dim wdlOut As New List(Of WareHouseDetailInfo)
        Dim wdlIn As New List(Of WareHouseDetailInfo)
        If CheckBoxAll.Checked = True Then
            wdlOut = wdc.WareHouseDetail_GetListQty(Label3.Text, txtCode.Text, Nothing, Nothing, "OUT")
            wdlIn = wdc.WareHouseDetail_GetListQty(Label3.Text, txtCode.Text, Nothing, Nothing, "IN")
        Else
            wdlOut = wdc.WareHouseDetail_GetListQty(Label3.Text, txtCode.Text, DateEdit1.Text, DateEdit2.Text, "OUT")
            wdlIn = wdc.WareHouseDetail_GetListQty(Label3.Text, txtCode.Text, DateEdit1.Text, DateEdit2.Text, "IN")
        End If

        If wdlOut.Count > 0 Then Label7.Text = wdlOut(0).Qty
        If wdlIn.Count > 0 Then Label8.Text = wdlIn(0).Qty
        '-----------------------------------------

        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

    End Sub
End Class
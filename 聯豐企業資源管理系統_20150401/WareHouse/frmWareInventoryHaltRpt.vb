Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.Library.Material
Imports LFERP.SystemManager.SystemUser
Imports LFERP.DataSetting
Imports LFERP.Library.WareHouseDetail
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop

Public Class frmWareInventoryHaltRpt
    Dim strWH As String

    Private Sub frmWareInventoryHaltRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strWH = tempValue3
        Me.Text = tempValue4
        tempValue3 = Nothing
        tempValue4 = Nothing

        If strWH = "50081001" Then
            RadioButton2.Visible = True
            RadioButton1.Visible = True
            RadioButton1.Checked = True
        ElseIf strWH = "500208" Then
            RadioButton2.Visible = False
            RadioButton1.Visible = False
            cmdSave.Text = "導出(&L)"

            Me.DateEdit1.EditValue = Format(Now, "yyyy-MM") & "-01"
            Me.DateEdit2.EditValue = Format(Now, "yyyy-MM-dd")
        Else
            RadioButton2.Visible = False
            RadioButton1.Visible = False
        End If


    End Sub
    'Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick

    '    frmWareHouseSelect.SelectWareID = ""

    '    frmWareHouseSelect.ShowDialog()
    '    If frmWareHouseSelect.SelectWareID = "" Then
    '    Else
    '        ButtonEdit1.Text = frmWareHouseSelect.SelectWareID
    '    End If

    'End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If strWH = "50081001" Then      '呆滯物料一覽表
            If Me.ButtonEdit1.Text = "" Then
                MsgBox("倉庫不為空")
                Exit Sub
            End If
            If Me.DateEdit1.Text = "" Or Me.DateEdit2.Text = "" Then
                MsgBox("時間不為空")
                Exit Sub
            End If

            ''打印報表
            If RadioButton1.Checked = True Then
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim ltc1 As New CollectionToDataSet
                Dim ltc2 As New CollectionToDataSet


                'Dim wh As New WareHouseController
                'Dim wic As New WareInventory.WareInventoryMTController

                'If wic.WareInventory_GetHalt(ButtonEdit1.EditValue, DateEdit1.Text, DateEdit2.Text).Count = 0 Then
                '    MsgBox("呆滯物料為空,請重新設置查詢條件!")
                '    Exit Sub
                'End If

                'ds.Tables.Clear()

                'ltc.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
                'ltc2.CollToDataSet(ds, "WareInventory", wic.WareInventory_GetHalt(ButtonEdit1.EditValue, DateEdit1.Text, DateEdit2.Text))

                'PreviewRPT(ds, "rptWareInventoryGetHalt", "呆滯物料一覽表", True, True)
                'ltc = Nothing
                'ltc2 = Nothing


                Dim mcCompany As New LFERP.DataSetting.CompanyControler
                Dim strCompany As String
                strCompany = Mid(strInDPT_ID, 1, 4)   '獲得登錄者所屬公司ID,以返回公司名稱，LOGO
                Dim wic As New WareInventory.WareInventoryMTController

                If wic.WareInventory_NOUserGetList(ButtonEdit1.EditValue, DateEdit1.Text, DateEdit2.Text).Count = 0 Then
                    MsgBox("呆滯物料為空,請重新設置查詢條件!")
                    Exit Sub
                End If

                ds.Tables.Clear()

                ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing))
                ltc2.CollToDataSet(ds, "WareInventory", wic.WareInventory_NOUserGetList(ButtonEdit1.EditValue, DateEdit1.Text, DateEdit2.Text))
                PreviewRPT1(ds, "rptWareInventory_NOUser", "呆滯物料一覽表", DateEdit1.Text, DateEdit2.Text, True, True)

                ltc = Nothing
                ltc2 = Nothing

                Me.Close()
            End If

            ''導出excel  2012/8/9
            If RadioButton2.Checked = True Then
                ExpotExcel()
            End If

            '@ 2012/5/2 添加 負數出入庫記錄表
        ElseIf strWH = "500811" Then        '負數出入庫記錄表
            Dim ds As New DataSet
            Dim ltc As New CollectionToDataSet

            Dim wh As New WareHouseDetailControl

            If DateEdit1.Text = "" Then
                tempValue3 = Nothing
            Else
                tempValue3 = DateEdit1.Text
            End If
            If DateEdit2.Text = "" Then
                tempValue4 = Nothing
            Else
                tempValue4 = DateEdit2.Text
            End If

            If wh.WareINandOutQty_V_GetList(Nothing, ButtonEdit1.Text, tempValue3, tempValue4).Count = 0 Then
                MsgBox("查詢內容為空,請重新設置查詢條件!")
                Exit Sub
            End If

            ds.Tables.Clear()


            ltc.CollToDataSet(ds, "WareInventorySearch", wh.WareINandOutQty_V_GetList(Nothing, ButtonEdit1.Text, tempValue3, tempValue4))

            PreviewRPT(ds, "rptWareInAndOutQty", "負數出入庫記錄表", True, True)
            ltc = Nothing

            Me.Close()
        ElseIf strWH = "500208" Then
            ''-------------------------------------------------------------  出庫月匯總數據

            WareOutExpotExcel()

        End If

    End Sub

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        frmWareHouseSelect.SelectWareID = ""
        tempValue3 = "500401"
        frmWareHouseSelect.SelectWareID = ""
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = Me.Left + ButtonEdit1.Left + 2
        frmWareHouseSelect.Top = Me.Top + ButtonEdit1.Top + ButtonEdit1.Height + 21
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            ButtonEdit1.Text = frmWareHouseSelect.SelectWareID
        End If

    End Sub



    Sub ExpotExcel()
        Dim strCompany, CompanyName As String
        strCompany = Mid(strInDPT_ID, 1, 4)   '獲得登錄者所屬公司ID,以返回公司名稱，LOGO
        ''-----------------------------------------------------------------
        Dim mcCompany As New LFERP.DataSetting.CompanyControler
        Dim mLCompany As New List(Of LFERP.DataSetting.CompanyInfo)
        mLCompany = mcCompany.Company_Getlist(strCompany, Nothing, Nothing, Nothing)
        CompanyName = mLCompany(0).CO_ChsName
        ''----------------------------------------------------------------------------------

        Dim wic As New WareInventory.WareInventoryMTController
        Dim wl As New List(Of WareInventory.WareInventoryInfo)
        Dim CountJS As Integer
        wl = wic.WareInventory_NOUserGetList(ButtonEdit1.EditValue, DateEdit1.Text, DateEdit2.Text)
        CountJS = wl.Count

        If CountJS <= 0 Then
            MsgBox("呆滯物料為空,請重新設置查詢條件!")
            Exit Sub
        End If

        Dim i As Integer
        Dim exapp As New Excel.Application   '定義一個excel對象
        Dim exbook As Excel.Workbook     '定義一個excel活頁
        Dim exsheet As Excel.Worksheet   '定義一個excel工作區

        exapp = CreateObject("Excel.Application")   '生成一個excel對象
        exbook = exapp.Workbooks.Open(Application.StartupPath & "\ModuleFile\MaterialNOUse.xls")
        exsheet = exbook.Worksheets(1)

        exsheet.Cells(1, 1) = CompanyName
        exsheet.Cells(2, 1) = "呆滯物料一覽表" & DateEdit1.EditValue & "~" & DateEdit2.EditValue

        'exsheet.Cells(3, 1) = "倉庫名稱:" & wl(0).WH_Name & "  " & wl(0).WH_SName
        'exsheet.Cells(3, 6) = "倉庫編號:" & wl(0).WH_ID
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = CountJS

        For i = 0 To CountJS - 1
            exsheet.Cells(5 + i, 1) = wl(i).Type3Name
            exsheet.Cells(5 + i, 2) = wl(i).M_Code
            exsheet.Cells(5 + i, 3) = wl(i).M_Name
            exsheet.Cells(5 + i, 4) = wl(i).M_Gauge
            exsheet.Cells(5 + i, 5) = wl(i).WI_Qty
            exsheet.Cells(5 + i, 6) = wl(i).M_Unit
            exsheet.Cells(5 + i, 7) = wl(i).DateIn
            exsheet.Cells(5 + i, 8) = wl(i).DateOut

            exbook.ActiveSheet.range(exsheet.Cells(5 + i, 1), exsheet.Cells(5 + i, 8)).borders(1).linestyle = 1
            exbook.ActiveSheet.range(exsheet.Cells(5 + i, 1), exsheet.Cells(5 + i, 8)).borders(2).linestyle = 1
            exbook.ActiveSheet.range(exsheet.Cells(5 + i, 1), exsheet.Cells(5 + i, 8)).borders(3).linestyle = 1
            exbook.ActiveSheet.range(exsheet.Cells(5 + i, 1), exsheet.Cells(5 + i, 8)).borders(4).linestyle = 1

            ProgressBar1.Value = i
        Next


        exsheet.Cells(5 + CountJS + 1, 1) = "注:   1.入庫包括入庫作業.調撥入庫.拆分入庫.拆合入庫"
        exsheet.Cells(5 + CountJS + 2, 1) = "      2.出庫包括出庫作業.調撥出庫.拆分出庫.拆合出庫"

        ProgressBar1.Visible = False

        Dim tempName As String

        SaveFileDialog1.InitialDirectory = "c:\"
        SaveFileDialog1.Filter = "txt files (*.xls)|*.xls"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tempName = SaveFileDialog1.FileName
        Else
            Exit Sub
        End If

        exsheet.SaveAs(tempName)

        exapp.Quit()
        exsheet = Nothing
        exbook = Nothing
        exapp = Nothing

        MsgBox("導出成功!")

        Me.Close()
    End Sub

    Sub WareOutExpotExcel()

        If Me.ButtonEdit1.EditValue = "" Then
            MsgBox("倉庫不為空")
            Exit Sub
        End If

        If Me.DateEdit1.EditValue Is Nothing Or Me.DateEdit2.EditValue Is Nothing Then
            MsgBox("時間不為空")
            Exit Sub
        End If

        Dim wic As New WareOut.WareOutController
        Dim wl As New List(Of WareOut.WareOutInfo)
        Dim CountJS As Integer
        wl = wic.WareOut_Getlist4(ButtonEdit1.EditValue, DateEdit1.EditValue, DateEdit2.EditValue)

        CountJS = wl.Count

        If CountJS <= 0 Then
            MsgBox("無出庫記錄存在,請檢查!")
            Exit Sub
        End If

        Dim i As Integer
        Dim exapp As New Excel.Application   '定義一個excel對象
        Dim exbook As Excel.Workbook     '定義一個excel活頁
        Dim exsheet As Excel.Worksheet   '定義一個excel工作區

        exapp = CreateObject("Excel.Application")   '生成一個excel對象
        exbook = exapp.Workbooks.Open(Application.StartupPath & "\ModuleFile\module.xls")
        exsheet = exbook.Worksheets(1)

        ProgressBar1.Visible = True
        ProgressBar1.Maximum = CountJS

        exsheet.Cells(1, 1) = "領料廠別"
        exsheet.Cells(1, 2) = "領料部門"
        exsheet.Cells(1, 3) = "物料編碼"
        exsheet.Cells(1, 4) = "物料名稱"
        exsheet.Cells(1, 5) = "規格"
        exsheet.Cells(1, 6) = "出庫總數"
        exsheet.Cells(1, 7) = "幣別"
        exsheet.Cells(1, 8) = "單價"
        exsheet.Cells(1, 9) = "總金額"
        exsheet.Cells(1, 10) = "總金額(人民幣)"

        For i = 0 To CountJS - 1
            exsheet.Cells(2 + i, 1) = wl(i).DPT_PName
            exsheet.Cells(2 + i, 2) = wl(i).DPT_Name
            exsheet.Cells(2 + i, 3) = wl(i).M_Code
            exsheet.Cells(2 + i, 4) = wl(i).M_Name
            exsheet.Cells(2 + i, 5) = wl(i).M_Gauge
            exsheet.Cells(2 + i, 6) = wl(i).WO_Qty
            exsheet.Cells(2 + i, 7) = wl(i).M_Currency
            exsheet.Cells(2 + i, 8) = CStr(FormatNumber(wl(i).M_Price, 4, TriState.True))
            exsheet.Cells(2 + i, 9) = CStr(FormatNumber(Val(wl(i).M_Price) * Val(wl(i).WO_Qty), 4, TriState.True))
            exsheet.Cells(2 + i, 10) = Format(wl(i).SumHKD, "0.0000")
            ProgressBar1.Value = i
        Next

        exbook.ActiveSheet.range(exsheet.Cells(1, 1), exsheet.Cells(CountJS + 1, 10)).borders(1).linestyle = 1
        exbook.ActiveSheet.range(exsheet.Cells(1, 1), exsheet.Cells(CountJS + 1, 10)).borders(2).linestyle = 1
        exbook.ActiveSheet.range(exsheet.Cells(1, 1), exsheet.Cells(CountJS + 1, 10)).borders(3).linestyle = 1
        exbook.ActiveSheet.range(exsheet.Cells(1, 1), exsheet.Cells(CountJS + 1, 10)).borders(4).linestyle = 1

        ProgressBar1.Visible = False

        Dim tempName As String

        SaveFileDialog1.InitialDirectory = "c:\"
        SaveFileDialog1.Filter = "txt files (*.xls)|*.xls"
        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tempName = SaveFileDialog1.FileName
            exsheet.SaveAs(tempName)
        Else
            Exit Sub
        End If


        exapp.Quit()
        exsheet = Nothing
        exbook = Nothing
        exapp = Nothing

        MsgBox("導出成功!")
    End Sub

End Class
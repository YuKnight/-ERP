Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.Material
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports LFERP.DataSetting

Public Class frmWareInventoryOutRpt

    Dim strWHID As String '倉庫代號 調用倉庫表
    Dim strM_Code As String       '記錄物料編碼
    Dim mtc As New MaterialTypeController
    Dim wic As New WareInventoryMTController
    Dim mcCompany As New CompanyControler

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmWareInventoryOutRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pceM_Type.Tag = ""
        mtc.LoadNodes(tv1, ErpUser.MaterialType)      '調用加載物料類型事件
    End Sub
    ''' <summary>
    ''' 單擊確定按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet

        ds.Tables.Clear()

        If bteWH_ID.EditValue = "" Then
            MsgBox("倉庫名稱不能為空，請輸入倉庫名稱!", 64, "提示")
            bteWH_ID.Focus()
            Exit Sub
        End If

        '當物料類型不為空且物料編碼為空時，物料編碼等於物料類型(相當於模糊查找物料編碼)﹔
        If pceM_Type.Tag <> "" And bteM_Code.Text.Trim = "" Then
            strM_Code = pceM_Type.Tag
        Else
            strM_Code = bteM_Code.Text.Trim
        End If

        '存儲過程當中沒有進行空值判斷，只能賦空字符串
        If strM_Code = Nothing Then
            strM_Code = ""
        End If
        If strWHID = Nothing Then
            strWHID = ""
        End If

        If wic.WareInventoryOut_GetList(strWHID, strM_Code, Format(DateAdd("m", -1, Now), "yyMM"), Format(DateAdd("m", -2, Now), "yyMM"), Format(DateAdd("m", -3, Now), "yyMM")).Count = 0 Then
            MsgBox("物料出庫數據匯總為空,請重新設置匯總條件!")
            Exit Sub
        End If

        ltc.CollToDataSet(ds, "WareNum", wic.WareInventoryOut_GetList(strWHID, strM_Code, Format(DateAdd("m", -1, Now), "yyMM"), Format(DateAdd("m", -2, Now), "yyMM"), Format(DateAdd("m", -3, Now), "yyMM")))
        ltc1.CollToDataSet(ds, "Company", mcCompany.Company_Getlist(strInCompany, Nothing, Nothing, Nothing))

        PreviewRPT1(ds, "rptWareInventoryOut", "物料出庫數據匯總表", bteWH_ID.Text, Format(DateAdd("m", -1, Now), "MM"), True, True)

        ltc = Nothing
        ltc1 = Nothing
        Me.Close()
    End Sub
    ''' <summary>
    ''' 單擊倉庫名稱框中的按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub bteWH_ID_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bteWH_ID.ButtonClick
    
        tempValue3 = "50081301"

        frmWareHouseSelect.SelectWareID = ""
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = Me.Left + bteWH_ID.Left + 7
        frmWareHouseSelect.Top = Me.Top + bteWH_ID.Top + bteWH_ID.Height + 31
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            bteWH_ID.Text = frmWareHouseSelect.SelectWareUpName & "-" & frmWareHouseSelect.SelectWareName
            strWHID = frmWareHouseSelect.SelectWareID
        End If
    End Sub
    ''' <summary>
    ''' 單擊物料編碼框中的按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub bteM_Code_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles bteM_Code.ButtonClick
        tempCode = ""
        frmBOMSelect.XtraTabPage2.PageVisible = False
        frmBOMSelect.XtraTabPage3.PageVisible = False
        frmBOMSelect.ShowDialog()
        bteM_Code.Text = tempCode
        tempCode = ""
    End Sub
    ''' <summary>
    ''' 雙擊選擇物料類型
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tv1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tv1.DoubleClick
        pceM_Type.Tag = Trim(tv1.SelectedNode.Tag)
        If tv1.SelectedNode.Level <> 0 Then
            pceM_Type.Text = tv1.SelectedNode.Parent.Text & "-" & tv1.SelectedNode.Text
        Else
            pceM_Type.Text = tv1.SelectedNode.Text
        End If
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub
    ''' <summary>
    ''' 單擊導出按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnExportExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExportExcel.Click
        If FunExportExcel() = True Then        '調用導出到Excel函數
            Me.Close()
        End If
    End Sub
    ''' <summary>
    ''' 導出到Excel
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    ''' btnExportExcel_Click()
    Function FunExportExcel() As Boolean
        Try
            Dim wii As List(Of WareInventoryInfo)
            Dim mci As List(Of CompanyInfo)
            Dim Row_Count As Integer
            Dim i As Integer
            Dim exapp As New Excel.Application   '定義一個excel對象
            Dim exbook As Excel.Workbook     '定義一個excel活頁
            Dim exsheet As Excel.Worksheet   '定義一個excel工作區

            If pceM_Type.Tag <> "" And bteM_Code.Text.Trim = "" Then
                strM_Code = pceM_Type.Tag
            Else
                strM_Code = bteM_Code.Text.Trim
            End If

            If strM_Code = Nothing Then
                strM_Code = ""
            End If
            If strWHID = Nothing Then
                strWHID = ""
            End If

            wii = wic.WareInventoryOut_GetList(strWHID, strM_Code, Format(DateAdd("m", -1, Now), "yyMM"), Format(DateAdd("m", -2, Now), "yyMM"), Format(DateAdd("m", -3, Now), "yyMM"))

            If wii.Count = 0 Then
                MsgBox("物料出庫數據匯總為空,請重新設置匯總條件!")
                Exit Function
            End If

            Row_Count = wii.Count

            ProgressBar1.Visible = True
            ProgressBar1.Maximum = Row_Count

            If Row_Count <= 0 Then Exit Function

            mci = mcCompany.Company_Getlist(strInCompany, Nothing, Nothing, Nothing)

            exapp = CreateObject("Excel.Application")   '生成一個excel對象
            exbook = exapp.Workbooks.Open(Application.StartupPath & "\ModuleFile\WareInventoryOutRpt.xls")
            exsheet = exbook.Worksheets(1)

            'exsheet.Cells(1, 1) = ByteToImage(mci(0).CO_Logo)
            exsheet.Cells(1, 2) = mci(0).CO_ChsName
            exsheet.Cells(3, 1) = "倉庫名稱：" & bteWH_ID.Text
            exsheet.Cells(3, 8) = Format(Now, "yyyy/MM/dd")
            exsheet.Cells(5, 7) = CInt(Format(DateAdd("m", -1, Now), "MM")) & "月"
            exsheet.Cells(5, 8) = CInt(Format(DateAdd("m", -2, Now), "MM")) & "月"
            exsheet.Cells(5, 9) = CInt(Format(DateAdd("m", -3, Now), "MM")) & "月"


            For i = 0 To Row_Count - 1
                exsheet.Cells(6 + i, 1) = CStr(wii(i).M_Code)
                exsheet.Cells(6 + i, 2) = wii(i).M_Name
                exsheet.Cells(6 + i, 3) = wii(i).M_Gauge
                exsheet.Cells(6 + i, 4) = wii(i).WI_Qty
                exsheet.Cells(6 + i, 5) = wii(i).M_Unit

                exsheet.Cells(6 + i, 6) = wii(i).WI_SafeQty
                exsheet.Cells(6 + i, 7) = wii(i).WO_Qty1
                exsheet.Cells(6 + i, 8) = wii(i).WO_Qty2
                exsheet.Cells(6 + i, 9) = wii(i).WO_Qty3

                exbook.ActiveSheet.range(exsheet.Cells(6 + i, 1), exsheet.Cells(6 + i, 9)).borders(1).linestyle = 1
                exbook.ActiveSheet.range(exsheet.Cells(6 + i, 1), exsheet.Cells(6 + i, 9)).borders(2).linestyle = 1
                exbook.ActiveSheet.range(exsheet.Cells(6 + i, 1), exsheet.Cells(6 + i, 9)).borders(3).linestyle = 1
                exbook.ActiveSheet.range(exsheet.Cells(6 + i, 1), exsheet.Cells(6 + i, 9)).borders(4).linestyle = 1

                ProgressBar1.Value = i
            Next

            ProgressBar1.Visible = False
            Dim tempName As String

            SaveFileDialog1.InitialDirectory = "c:\"

            SaveFileDialog1.Filter = "Excel files (*.xls)|*.xls"
            SaveFileDialog1.FileName = "物料出庫數據匯總表(" & Format(Now, "yyyyMMdd") & ")"

            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                tempName = SaveFileDialog1.FileName
                exsheet.SaveAs(tempName)
                exapp.Quit()
                MsgBox("導出成功! 至" & tempName)
                FunExportExcel = True
            Else
                FunExportExcel = False
            End If

            exsheet = Nothing
            exbook = Nothing
            exapp = Nothing
        Catch ex As Exception
            FunExportExcel = False
            MsgBox(ex.Message, 64, "提示")
        End Try
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim frm As New frmWareInventoryOut
        frm.MdiParent = MDIMain
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub
End Class
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.Material
Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Imports LFERP.DataSetting

Public Class frmWareInventoryOut
    Dim strWHID As String '倉庫代號 調用倉庫表
    Dim strM_Code As String       '記錄物料編碼
    Dim mtc As New MaterialTypeController
    Dim wic As New WareInventoryMTController
    Dim mcCompany As New CompanyControler

    Private Sub frmWareInventoryOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mci As List(Of CompanyInfo)
        mci = mcCompany.Company_Getlist(strInCompany, Nothing, Nothing, Nothing)
        bandCompany.Caption = mci(0).CO_ChsName
        pceM_Type.Tag = ""
        bandDate.Caption = "匯總日期：" & Format(Now, "yyyy/MM/dd")
        bandWO_Qty1.Caption = CInt(Format(DateAdd("m", -1, Now), "MM")) & "月"
        bandWO_Qty2.Caption = CInt(Format(DateAdd("m", -2, Now), "MM")) & "月"
        bandWO_Qty3.Caption = CInt(Format(DateAdd("m", -3, Now), "MM")) & "月"
        'GridView1.IndicatorWidth = 30
        mtc.LoadNodes(tv1, ErpUser.MaterialType)      '調用加載物料類型事件
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
        frmWareHouseSelect.Left = Me.Left + bteWH_ID.Left + MDIMain.tvModule.Width + 10
        frmWareHouseSelect.Top = Me.Top + bteWH_ID.Top + bteWH_ID.Height + 135
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

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
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

        GridControl1.DataSource = wic.WareInventoryOut_GetList(strWHID, strM_Code, Format(DateAdd("m", -1, Now), "yyMM"), Format(DateAdd("m", -2, Now), "yyMM"), Format(DateAdd("m", -3, Now), "yyMM"))

    End Sub

    Private Sub cmsExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsExportExcel.Click
        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Title = "導出Excel"

        saveFileDialog.Filter = "Excel文件(*.xls)|*.xls"

        Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)

        saveFileDialog.FileName = "物料出庫數據匯總" & Format(Now, "yyyy/MM/dd")
        If dialogResult__1 = Windows.Forms.DialogResult.OK Then

            GridControl1.ExportToXls(saveFileDialog.FileName)

            DevExpress.XtraEditors.XtraMessageBox.Show("導出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub bteWH_ID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bteWH_ID.EditValueChanged
        bandWH_Name.Caption = "倉庫名稱：" & bteWH_ID.Text
    End Sub

    Private Sub AdvBandedGridView1_CustomDrawRowIndicator(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles AdvBandedGridView1.CustomDrawRowIndicator
        If e.Info.IsRowIndicator And e.RowHandle >= 0 Then
            e.Info.DisplayText = (e.RowHandle + 1).ToString()
        End If
    End Sub
End Class
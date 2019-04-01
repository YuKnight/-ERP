Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.Purchase.Purchase
Imports LFERP.DataSetting
Imports LFERP.SystemManager

Public Class frmAcceptanceGather
    Dim isPrint As Boolean
    Dim isExport As Boolean

    ''' <summary>
    ''' 單擊取消按鈕，退出窗體
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 加載窗體
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAcceptanceGather_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        '加載供應商 
        gluS_Supplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        gluS_Supplier.Properties.DisplayMember = "S_SupplierName"
        gluS_Supplier.Properties.ValueMember = "S_Supplier"
    End Sub
    ''' <summary>
    ''' 單擊確定按鈕，匯總記錄
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim ds As New DataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ac As New AcceptanceController
        Dim strA_AccountCheck, strA_PayCheck As String
        isPrint = False
        isExport = False

        If cboA_AccountCheck.Text = "全部" Then
            strA_AccountCheck = Nothing
        ElseIf cboA_AccountCheck.Text = "已審核" Then
            strA_AccountCheck = "True"
        ElseIf cboA_AccountCheck.Text = "未審核" Then
            strA_AccountCheck = "False"
        End If

        If cboA_PayCheck.Text = "全部" Then
            strA_PayCheck = Nothing
        ElseIf cboA_PayCheck.Text = "已確認" Then
            strA_PayCheck = "True"
        ElseIf cboA_PayCheck.Text = "未確認" Then
            strA_PayCheck = "False"
        End If

        If ac.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, "True", strA_AccountCheck, Nothing, Nothing, gluS_Supplier.EditValue, strA_PayCheck, dteA_SendDateBegin.EditValue, dteA_SendDateEnd.EditValue).Count <= 0 Then
            MsgBox("此匯總條件無匯總記錄！", 64, "提示")
            gluS_Supplier.Focus()
            Exit Sub
        End If

        '判斷是否有打印，導出權限
        If gluS_Supplier.Text.Trim <> "" Then     '供應商為空時，不允許打印，導出
            If gluS_Supplier.EditValue = "S0177" Or gluS_Supplier.EditValue = "S0558" Or gluS_Supplier.EditValue = "S0861" Then    '只有指定的供應商才可以打印，導出
                Dim pmws As New PermissionModuleWarrantSubController
                Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

                pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400319")
                If pmwiL.Count > 0 Then
                    If pmwiL.Item(0).PMWS_Value = "是" Then
                        isPrint = True
                        isExport = True
                    End If
                End If
            End If
        End If

        ds.Tables.Clear()

        ltc1.CollToDataSet(ds, "Acceptance", ac.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, "True", strA_AccountCheck, Nothing, Nothing, gluS_Supplier.EditValue, strA_PayCheck, dteA_SendDateBegin.EditValue, dteA_SendDateEnd.EditValue))

        PreviewRPT1(ds, "rptAcceptance1", "驗收記錄匯總表", dteA_SendDateBegin.Text, dteA_SendDateEnd.Text, isPrint, isExport)
        ltc1 = Nothing

        Me.Close()
    End Sub
    ''' <summary>
    ''' 供應商名稱輸入框中按空格鍵彈出下拉菜單
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluS_Supplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluS_Supplier.KeyDown
        If e.KeyCode = Keys.Space Then
            gluS_Supplier.ShowPopup()
        End If
    End Sub
End Class
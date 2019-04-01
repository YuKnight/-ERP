Imports LFERP.DataSetting
Imports LFERP.Library.Product
Imports LFERP.Library.Orders

Public Class frmOutWardsFind
    Public isClickbtnOK As Boolean     '記錄是否單擊了查詢按鈕

    Private Sub frmOutWardsFind_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        isClickbtnOK = False

        If Me.Text = "批次資料--查詢" Then
            LabelControl1.Text = "訂單編號(&I)："
        End If

        '載入客戶代號
        If tempValue10 = "MG" Then
            C_CusterID.FieldName = "OC_CustomerID"
            C_EngName.Visible = False
            C_ChsName.Visible = False
            Dim occ As New OrderCustomerController
            gluOM_CusterID.Properties.DisplayMember = "OC_CustomerID"
            gluOM_CusterID.Properties.ValueMember = "OC_CustomerID"
            gluOM_CusterID.Properties.DataSource = occ.OrderCustomer_GetCustomerID
        Else
            Dim mtd As New CusterControler
            gluOM_CusterID.Properties.DisplayMember = "C_CusterID"
            gluOM_CusterID.Properties.ValueMember = "C_CusterID"
            gluOM_CusterID.Properties.DataSource = mtd.GetCusterList(Nothing, Nothing, Nothing)
        End If


        '載入產品編號
        Dim mc As New ProductController
        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        tempValue10 = ""
    End Sub

    '單擊查詢按鈕
    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        isClickbtnOK = True
        If txtOW_NO.Text.Trim = "" Then                      '送貨單號
            tempValue = Nothing
        Else
            tempValue = txtOW_NO.Text.Trim
        End If

        tempValue3 = gluOM_CusterID.EditValue         '客戶代號

        If txtOS_BatchID.Text.Trim = "" Then                 '批次編號
            tempValue2 = Nothing
        Else
            tempValue2 = txtOS_BatchID.Text.Trim
        End If

        If txtOM_CusterNO.Text.Trim = "" Then             '客戶編號
            tempValue4 = Nothing
        Else
            tempValue4 = txtOM_CusterNO.Text.Trim
        End If

        If txtOM_CusterPO.Text.Trim = "" Then             '客戶PO NO.
            tempValue5 = Nothing
        Else
            tempValue5 = txtOM_CusterPO.Text.Trim
        End If

        tempValue6 = gluPM_M_Code.EditValue           '產品編號

        If cboOW_Check.Text = "全部" Then               '審核狀態
            tempValue7 = Nothing
        ElseIf cboOW_Check.Text = "已審核" Then
            tempValue7 = True
        ElseIf cboOW_Check.Text = "未審核" Then
            tempValue7 = False
        End If

        If dteOW_DateBegin.Text = "" Then                   '送貨開始日期
            tempValue8 = Nothing
        Else
            tempValue8 = dteOW_DateBegin.Text
        End If

        If dteOW_DateEnd.Text = "" Then                      '送貨結束日期
            tempValue9 = Nothing
        Else
            tempValue9 = dteOW_DateEnd.Text
        End If

        Me.Close()
    End Sub

    '單擊取消按鈕，關閉窗體
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    '單擊空格鍵，顯示下拉菜單
    Private Sub gluOM_CusterID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluOM_CusterID.KeyDown, gluPM_M_Code.KeyDown, cboOW_Check.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class
Public Class frmOrdersSubNeedFind
    Public isClickcmdFind As Boolean

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        If txtON_ID.Text.Trim = "" Then                          '需求單號
            tempValue = Nothing
        Else
            tempValue = txtON_ID.Text.Trim
        End If

        If txtOS_BatchID.Text.Trim = "" Then                 '批次編號
            tempValue2 = Nothing
        Else
            tempValue2 = txtOS_BatchID.Text.Trim
        End If

        If txtM_Code.Text.Trim = "" Then                        '物料編碼
            tempValue3 = Nothing
        Else
            tempValue3 = txtM_Code.Text.Trim
        End If

        If txtM_Name.Text.Trim = "" Then                       '物料名稱
            tempValue4 = Nothing
        Else
            tempValue4 = txtM_Name.Text.Trim
        End If

        If cboM_CodeType.Text = "全部" Then               '配件類型
            tempValue5 = Nothing
        Else
            tempValue5 = cboM_CodeType.Text.Trim
        End If

        If cboON_PurchaseState.Text = "全部" Then               '採購狀態
            tempValue6 = Nothing
        Else
            tempValue6 = cboON_PurchaseState.Text.Trim
        End If

        If cboON_SalesDptCheck.Text = "全部" Then               '營業部審核
            tempValue7 = Nothing
        ElseIf cboON_SalesDptCheck.Text = "已審核" Then
            tempValue7 = "True"
        ElseIf cboON_SalesDptCheck.Text = "未審核" Then
            tempValue7 = "False"
        End If

        If cboON_OperationDptCheck.Text = "全部" Then               '營運部審核
            tempValue8 = Nothing
        ElseIf cboON_OperationDptCheck.Text = "已審核" Then
            tempValue8 = "True"
        ElseIf cboON_OperationDptCheck.Text = "未審核" Then
            tempValue8 = "False"
        End If

        If dteON_AddDateBegin.Text = "" Then                   '開始建立日期
            tempValue9 = Nothing
        Else
            tempValue9 = dteON_AddDateBegin.Text
        End If

        If dteON_AddDateEnd.Text = "" Then                      '結束建立日期
            tempValue10 = Nothing
        Else
            tempValue10 = dteON_AddDateEnd.Text
        End If

        isClickcmdFind = True
        Me.Close()
    End Sub

    Private Sub frmOrdersSubNeedFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isClickcmdFind = False
    End Sub
End Class
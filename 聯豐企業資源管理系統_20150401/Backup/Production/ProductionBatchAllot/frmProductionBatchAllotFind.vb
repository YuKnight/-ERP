Imports LFERP.DataSetting

Public Class frmProductionBatchAllotFind
    Dim fac As New FacControler
    Public isClickbtnFind As Boolean = False

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub frmProductionBatchAllotFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gluFacID.Properties.DisplayMember = "FacName"
        gluFacID.Properties.ValueMember = "FacID"
        gluFacID.Properties.DataSource = fac.GetFacList(Nothing, Nothing)

    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If txtPBA_ID.Text.Trim = "" Then                          '派工單號
            tempValue = Nothing
        Else
            tempValue = txtPBA_ID.Text.Trim
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

        If gluFacID.EditValue = "" Then               '廠別名稱
            tempValue5 = Nothing
        Else
            tempValue5 = gluFacID.EditValue
        End If

        If cboPBA_Check.Text = "全部" Then               '審核
            tempValue6 = Nothing
        ElseIf cboPBA_Check.Text = "已審核" Then
            tempValue6 = "True"
        ElseIf cboPBA_Check.Text = "未審核" Then
            tempValue6 = "False"
        End If

        If dtePBA_AddDateBegin.Text = "" Then                   '開始建立日期
            tempValue7 = Nothing
        Else
            tempValue7 = dtePBA_AddDateBegin.Text
        End If

        If dtePBA_AddDateEnd.Text = "" Then                      '結束建立日期
            tempValue8 = Nothing
        Else
            tempValue8 = dtePBA_AddDateEnd.Text
        End If

        isClickbtnFind = True
        Me.Close()
    End Sub
End Class
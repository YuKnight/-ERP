Imports LFERP.Library.ProductionSchedule
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.DataSetting

Public Class frmProductionScheduleFind
    Dim ds As New DataSet

    '設置gluPM_M_Code數據源
    Sub LoadProductNo()
        'Dim mc As New ProductController
        Dim mc As New ProcessMainControl
        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)
    End Sub

    '創建ProductType表
    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluPM_Type.Properties.ValueMember = "PM_Type"
        gluPM_Type.Properties.DisplayMember = "PM_Type"
        gluPM_Type.Properties.DataSource = ds.Tables("ProductType")
    End Sub

    Private Sub frmProductionScheduleFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        LoadProductNo()

        Dim fc As New FacControler
        gluFacID.Properties.DataSource = fc.GetFacList(Nothing, Nothing)
        gluFacID.Properties.DisplayMember = "FacName"
        gluFacID.Properties.ValueMember = "FacID"

        gluFacID.EditValue = strInFacID
        If strInUserRank = "管理" Then
            gluFacID.Enabled = True
        End If
    End Sub



    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        If detPS_DateBegin.DateTime > detPS_DateEnd.DateTime And detPS_DateEnd.Text.Trim <> "" Then
            MsgBox("輸入計劃日期順序有誤，請重新輸入!", 64, "提示")
            detPS_DateBegin.Focus()
        Else
            '判斷各輸入條件是否為空, 為空則賦值Nothing
            If txtPS_NO.Text.Trim = "" Then
                tempValue = Nothing
            Else
                tempValue = txtPS_NO.Text.Trim
            End If

            If gluFacID.EditValue = "" Then
                tempValue7 = Nothing
            Else
                tempValue7 = gluFacID.EditValue
            End If

            If cboPro_Type.EditValue = "" Then
                tempValue2 = Nothing
            Else
                tempValue2 = cboPro_Type.EditValue
            End If

            If gluPM_M_Code.EditValue = "" Then
                tempValue3 = Nothing
            Else
                tempValue3 = gluPM_M_Code.EditValue
            End If

            If gluPM_Type.EditValue = "" Then
                tempValue4 = Nothing
            Else
                tempValue4 = gluPM_Type.EditValue
            End If

            If detPS_DateBegin.Text.Trim = "" Then
                tempValue5 = Nothing
            Else
                tempValue5 = detPS_DateBegin.Text.Trim
            End If

            If detPS_DateEnd.Text.Trim = "" Then
                tempValue6 = Nothing
            Else
                tempValue6 = detPS_DateEnd.Text.Trim
            End If

            tempValue8 = "F"

            Me.Close()
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        tempValue8 = Nothing
        Me.Close()
    End Sub

    '@ 2012/8/10 添加 按空格鍵彈出下拉菜單
    Private Sub cboPro_Type_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPro_Type.KeyDown, gluPM_Type.KeyDown, gluPM_M_Code.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    '改變工藝類型時，根據產品編號與工藝類型加載類型
    Private Sub cboPro_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPro_Type.SelectedIndexChanged

        gluPM_M_Code_EditValueChanged(Nothing, Nothing)     '調用產品編號改變事件

    End Sub

    '改變產品編號時，根據產品編號與工藝類型加載類型
    '此過程被以下過程調用：
    'cboPro_Type_SelectedIndexChanged()

    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        On Error Resume Next

        If gluPM_M_Code.Text.Trim = "" Then   '@ 2012/8/10 添加
            ds.Tables("ProductType").Clear()
            Exit Sub
        End If

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)

        ds.Tables("ProductType").Clear()
        ppi = ppc.ProcessMain_GetList2(cboPro_Type.EditValue, gluPM_M_Code.EditValue)
        If ppi.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To ppi.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductType").NewRow
                row("PM_Type") = ppi(i).Type3ID
                ds.Tables("ProductType").Rows.Add(row)
            Next
        End If
    End Sub
End Class
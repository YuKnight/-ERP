Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess

Public Class frmProductionApplyFind
    Public strDPT_ID As String
    Public isClickcmdOK As Boolean  '判斷是否單擊了cmdOK按鈕

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    '單擊部門選擇控件，顯示部門選擇窗體
    Private Sub betDpt_Name_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles betDpt_Name.Click
        frmDepartmentSelect.DptID = ""
        frmDepartmentSelect.DptName = ""
        frmDepartmentSelect.UpDptName = ""
        betDpt_Name.Text = ""
        frmDepartmentSelect.StartPosition = FormStartPosition.Manual
        frmDepartmentSelect.Left = Me.Left + betDpt_Name.Left + 13
        frmDepartmentSelect.Top = Me.Top + 214
        frmDepartmentSelect.Size = New Size(213, 245)
        frmDepartmentSelect.ShowDialog()
        strDPT_ID = ""
        If frmDepartmentSelect.DptID = "" Then

        Else
            strDPT_ID = frmDepartmentSelect.DptID       '保存部門ID
            betDpt_Name.Text = frmDepartmentSelect.UpDptName & "-" & frmDepartmentSelect.DptName        '保存部門名稱(包括上一級部門名稱)
        End If
    End Sub

    '單擊查詢按鈕
    Private Sub cmdFind_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        If detPA_ApplyDateBegin.DateTime > detPA_ApplyDateEnd.DateTime And detPA_ApplyDateEnd.Text <> "" Then
            MsgBox("輸入申購日期順序有誤，請重新輸入!", 64, "提示")
            detPA_ApplyDateBegin.Focus()
        Else
            '判斷各輸入條件是否為空, 為空則賦值Nothing
            If txtPA_ID.Text.Trim = "" Then
                tempValue = Nothing
            Else
                tempValue = txtPA_ID.Text.Trim
            End If

            If gluPM_M_Code.Text.Trim = "" Then
                tempValue2 = Nothing
            Else
                tempValue2 = gluPM_M_Code.Text.Trim
            End If

            If txtM_Code.Text.Trim = "" Then
                tempValue3 = Nothing
            Else
                tempValue3 = txtM_Code.Text.Trim
            End If

            If txtM_Name.Text.Trim = "" Then
                tempValue4 = Nothing
            Else
                tempValue4 = txtM_Name.Text.Trim
            End If

            If txtM_Gauge.Text.Trim = "" Then
                tempValue5 = Nothing
            Else
                tempValue5 = txtM_Gauge.Text.Trim
            End If

            If strDPT_ID.Trim = "" Then
                tempValue6 = Nothing
            Else
                tempValue6 = strDPT_ID.Trim
            End If

            If detPA_ApplyDateBegin.Text.Trim = "" Then
                tempValue7 = Nothing
            Else
                tempValue7 = detPA_ApplyDateBegin.Text.Trim
            End If

            If detPA_ApplyDateEnd.Text.Trim = "" Then
                tempValue8 = Nothing
            Else
                tempValue8 = detPA_ApplyDateEnd.Text.Trim
            End If

            isClickcmdOK = True
            Me.Close()
        End If
    End Sub

    Private Sub frmProductionApplyFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '初始化變量
        strDPT_ID = ""
        isClickcmdOK = False

        Dim mc As New ProcessMainControl
        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)
    End Sub

    '@ 2012/8/13 添加 按空格鍵彈出下拉菜單
    Private Sub gluPM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPM_M_Code.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class
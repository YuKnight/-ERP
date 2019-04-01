Imports LFERP.Library.Purchase.WareQuality

Public Class frmWareQualityFind
    Dim mqc As New WareQualityController

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Dim strAddDateBegin, strAddDateEnd As String
        If dteAddDateBegin.Text.Trim = "" Then      '判斷輸入日期是否為空，因存儲過程中不做空字符串判斷
            strAddDateBegin = Nothing               '存儲過程中只做了空值(NULL)判斷，因此沒有輸入日期時，只能賦空值(NULL)
        Else
            strAddDateBegin = Format(CDate(dteAddDateBegin.Text), "yyyy/MM/dd")        '把日期格式轉換為固定格式
        End If
        If dteAddDateEnd.Text.Trim = "" Then
            strAddDateEnd = Nothing
        Else
            strAddDateEnd = Format(CDate(dteAddDateEnd.Text), "yyyy/MM/dd")
        End If
        frmWareQualityMain.Grid.DataSource = mqc.WareQuality_GetList(Trim(txtWQ_Code.Text), Trim(txtM_Code.Text), Trim(txtM_Name.Text), Trim(txtM_Gauge.Text), Trim(txtWO_ID.Text), strAddDateBegin, strAddDateEnd)
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub frmWareQualityFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i%
        For i = 0 To 6      '清空所有文本框內容
            GroupBox1.Controls.Item(i).Text = ""
        Next
        txtWQ_Code.Focus()
    End Sub
End Class
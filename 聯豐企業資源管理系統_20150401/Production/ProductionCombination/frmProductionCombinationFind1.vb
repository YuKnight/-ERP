Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Production.ProductionRatio

Public Class frmProductionCombinationFind1
    Dim ds As New DataSet
    Public isClickbtnFind As Boolean

    Private Sub frmProductionCombinationFind1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()       '調用創建表過程

        '加載產品編號
        Dim mc As New ProcessMainControl
        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)
        isClickbtnFind = False
    End Sub
    ''' <summary>
    ''' 創建表過程
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' frmProductionCombinationFind1_Load()
    Sub CreateTable()
        ds.Tables.Clear()

        '配件名稱表
        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluPM_Type.Properties.ValueMember = "PM_Type"
        gluPM_Type.Properties.DisplayMember = "PM_Type"
        gluPM_Type.Properties.DataSource = ds.Tables("ProductType")

        '大工序名稱表
        With ds.Tables.Add("Process")
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
        End With
        gluPro_NO.Properties.ValueMember = "PS_NO"
        gluPro_NO.Properties.DisplayMember = "PS_Name"
        gluPro_NO.Properties.DataSource = ds.Tables("Process")

        '小工序名稱表
        With ds.Tables.Add("ProcessSub")
            .Columns.Add("Pro_NO1", GetType(String))
            .Columns.Add("PS_Name1", GetType(String))
        End With
        gluPro_NO1.Properties.ValueMember = "Pro_NO1"
        gluPro_NO1.Properties.DisplayMember = "PS_Name1"
        gluPro_NO1.Properties.DataSource = ds.Tables("ProcessSub")
    End Sub
    ''' <summary>
    ''' 產品編號改變時，加載相應的配件名稱信息
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用：
    ''' cbType_SelectedIndexChanged
    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        On Error Resume Next

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)

        gluPM_Type.Text = ""
        ds.Tables("ProductType").Clear()
        ds.Tables("Process").Clear()
        ds.Tables("ProcessSub").Clear()

        ppi = ppc.ProcessMain_GetList2(cbType.EditValue, gluPM_M_Code.EditValue)
        If ppi.Count = 0 Then
        Else

            Dim i As Integer
            For i = 0 To ppi.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductType").NewRow
                row("PM_Type") = ppi(i).Type3ID
                ds.Tables("ProductType").Rows.Add(row)
            Next
            gluPro_NO.EditValue = Nothing
        End If
    End Sub
    ''' <summary>
    ''' 配件名稱改變時，加載相應的大工序名稱信息
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluPM_Type_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_Type.EditValueChanged
        On Error Resume Next

        Dim pc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)
        pci = pc.ProcessMain_GetList(Nothing, gluPM_M_Code.EditValue, cbType.EditValue, gluPM_Type.EditValue, Nothing, True)

        gluPro_NO.Text = ""
        ds.Tables("Process").Clear()
        ds.Tables("ProcessSub").Clear()

        If pci.Count = 0 Then Exit Sub

        Dim i As Integer
        For i = 0 To pci.Count - 1
            Dim row As DataRow
            row = ds.Tables("Process").NewRow

            row("PS_NO") = pci(i).PS_NO
            row("PS_Name") = pci(i).PS_Name

            ds.Tables("Process").Rows.Add(row)
        Next
    End Sub
    ''' <summary>
    ''' 大工序名稱改變時，加載相應的小工序名稱信息
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluPro_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPro_NO.EditValueChanged
        On Error Resume Next

        Dim prc As New ProductionRatioControl
        Dim pri As List(Of ProductionRatioInfo)
        pri = prc.ProductionRatio_GetList(Nothing, gluPro_NO.EditValue, Nothing, Nothing)

        gluPro_NO1.Text = ""
        ds.Tables("ProcessSub").Clear()

        If pri.Count = 0 Then Exit Sub

        Dim i As Integer
        For i = 0 To pri.Count - 1
            Dim row As DataRow
            row = ds.Tables("ProcessSub").NewRow

            row("Pro_NO1") = pri(i).Pro_NO1
            row("PS_Name1") = pri(i).PS_Name1

            ds.Tables("ProcessSub").Rows.Add(row)
        Next
    End Sub
    ''' <summary>
    ''' 單擊取消按鈕，關閉窗體
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 單擊查詢按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If gluPro_NO.Text.Trim = "" Then
            MsgBox("請輸入大工序名稱!", 64, "提示")
            gluPro_NO.Focus()
            Exit Sub
        End If

        tempValue = gluPro_NO.EditValue
        If gluPro_NO1.Text.Trim = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = gluPro_NO1.EditValue
        End If
        isClickbtnFind = True
        Me.Close()
    End Sub
    ''' <summary>
    ''' 工藝類型改變時，調用產品編號改變過程
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbType.SelectedIndexChanged
        gluPM_M_Code_EditValueChanged(Nothing, Nothing)     '調用產品編號改變過程
    End Sub

    '@ 2012/8/10 添加 按空格鍵彈出下拉菜單
    Private Sub gluPM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPM_M_Code.KeyDown, gluPM_Type.KeyDown, cbType.KeyDown, gluPro_NO.KeyDown, gluPro_NO1.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class
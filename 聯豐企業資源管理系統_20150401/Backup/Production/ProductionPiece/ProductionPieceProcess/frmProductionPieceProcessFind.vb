Imports LFERP.Library.Product
Imports LFERP.Library.ProductionPieceProcess
Imports LFERP.Library.ProductProcess

Public Class frmProductionPieceProcessFind
    Dim mc As New ProductController
    Dim ppc As New ProductionPieceProcessControl
    Dim ds As New DataSet
    Public isClickbtnFind As Boolean  '判斷是否單擊了btnFind按鈕

    Private Sub frmProductionPieceProcessFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()   '調用創建表過程
        isClickbtnFind = False

        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    ''' <summary>
    ''' 創建表
    ''' </summary>
    ''' 此過程被以下過程調用:
    ''' frmProductionPieceProcessFind_Load()
    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductType")       '配件名稱表
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluPM_Type.Properties.DisplayMember = "PM_Type"
        gluPM_Type.Properties.ValueMember = "PM_Type"
        gluPM_Type.Properties.DataSource = ds.Tables("ProductType")

    End Sub
    ''' <summary>
    ''' 單擊“取消”按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 產品編號值改變,在gluPM_Type中加載相應的配件名稱
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' 此過程被以下過程調用:
    ''' cboPro_Type_SelectedIndexChanged()
    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        On Error Resume Next

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
    ''' <summary>
    ''' 單擊“查詢”按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If txtPP_ID.Text.Trim = "" Then
            tempValue = Nothing
        Else
            tempValue = txtPP_ID.Text.Trim
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

        If dtePP_ActionDateBegin.Text.Trim = "" Then
            tempValue5 = Nothing
        Else
            tempValue5 = dtePP_ActionDateBegin.Text.Trim
        End If

        If dtePP_ActionDateEnd.Text.Trim = "" Then
            tempValue6 = Nothing
        Else
            tempValue6 = dtePP_ActionDateEnd.Text.Trim
        End If

        isClickbtnFind = True

        Me.Close()
    End Sub
    ''' <summary>
    ''' 按空格鍵顯示下拉列表
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluPM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPM_M_Code.KeyDown, cboPro_Type.KeyDown, gluPM_Type.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
    ''' <summary>
    ''' 工藝類型值改變,在gluPM_Type中加載相應的配件名稱
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cboPro_Type_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPro_Type.SelectedIndexChanged
        gluPM_M_Code_EditValueChanged(Nothing, Nothing) '調用gluPM_M_Code_EditValueChanged()過程
    End Sub
End Class
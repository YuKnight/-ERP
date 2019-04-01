Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.Library.Purchase.Retrocede

Public Class frmAcceptanceBatchCheck
    Dim ac As New AcceptanceController
    Dim ds As New DataSet
    Dim strSupplier, strDateBegin, strDateEnd As String

    ''' <summary>
    ''' 單擊審核按鈕，審核所有驗收單
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim i As Integer

        '驗收單批量審核
        If Me.lblTittle.Text = "驗收單批量審核" Then
            For i = 0 To GridView1.RowCount - 1
                Dim ai As New AcceptanceInfo
                ai.A_NO = GridView1.GetRowCellValue(i, "A_NO")
                ai.A_AccountCheck = True
                ai.A_AccountCheckType = "確認無誤"
                ai.A_AccountCheckDate = Format(Now, "yyyy/MM/dd")
                ai.A_AccountCheckAction = InUserID
                ai.A_AccountCheckRemark = ""

                ac.Acceptance_UpdateAccountCheck(ai)
            Next
            MsgBox("審核完成!", 64, "提示")

            '驗收單批量付款確認
        ElseIf Me.lblTittle.Text = "驗收單批量付款確認" Then
            For i = 0 To GridView1.RowCount - 1
                Dim ai As New AcceptanceInfo
                ai.A_NO = GridView1.GetRowCellValue(i, "A_NO")
                ai.A_PayCheck = True
                ai.A_PayCheckDate = Format(Now, "yyyy/MM/dd")
                ai.A_PayCheckAction = InUserID
                ai.A_PayCheckRemark = ""

                Dim rc As New RetrocedeController
                Dim riList As New List(Of RetrocedeInfo)

                riList = rc.Retrocede_GetList(Nothing, GridView1.GetRowCellValue(i, "A_AcceptanceNO"), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                If riList.Count > 0 Then
                    '如果有退貨記錄的情況下
                    ai.A_Detail = "退貨未處理"
                Else
                    '如果沒有退貨記錄的情況下
                    ai.A_Detail = "已結單"
                End If
                ac.Acceptance_UpdatePay(ai)
            Next
            MsgBox("付款確認完成！", 64, "提示")

        End If
        Me.Close()
    End Sub
    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("Acceptance")
            .Columns.Add("A_NO")
            .Columns.Add("A_AcceptanceNO")
            .Columns.Add("PM_NO")
            .Columns.Add("M_Code")
            .Columns.Add("M_Name")
            .Columns.Add("A_SendNO")
            .Columns.Add("A_Qty")
            .Columns.Add("A_SendDate")
            .Columns.Add("S_SupplierName")
            .Columns.Add("Status")
        End With
        Grid.DataSource = ds.Tables("Acceptance")
    End Sub

    ''' <summary>
    ''' 加載窗體
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmAcceptanceBatchCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        '加載供應商 
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"

        If Me.lblTittle.Text = "驗收單批量審核" Then

        ElseIf Me.lblTittle.Text = "驗收單批量付款確認" Then
            Me.Text = "驗收單批量付款確認"
            btnCheck.Text = "確認(&O)"
            CreateTable()
        End If
    End Sub
    ''' <summary>
    ''' 單擊查詢按鈕，查詢驗收單
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        If gluSupplier.Text.Trim = "" And dteA_SendDateBegin.Text.Trim = "" And dteA_SendDateEnd.Text.Trim = "" Then
            MsgBox("請輸入篩選條件!", 64, "提示")
            gluSupplier.Focus()
            Exit Sub
        End If

        If dteA_SendDateBegin.DateTime > dteA_SendDateEnd.DateTime And dteA_SendDateEnd.Text.Trim <> "" Then
            MsgBox("輸入送貨日期順序有誤，請重新輸入!", 64, "提示")
            dteA_SendDateBegin.Focus()
            Exit Sub
        End If

        If gluSupplier.Text.Trim = "" Then
            strSupplier = Nothing
        Else
            strSupplier = gluSupplier.EditValue
        End If

        If dteA_SendDateBegin.Text.Trim = "" Then
            strDateBegin = Nothing
        Else
            strDateBegin = dteA_SendDateBegin.Text.Trim
        End If

        If dteA_SendDateEnd.Text.Trim = "" Then
            strDateEnd = Nothing
        Else
            strDateEnd = dteA_SendDateEnd.Text.Trim
        End If
        If Me.lblTittle.Text = "驗收單批量審核" Then
            Grid.DataSource = ac.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, "True", "False", Nothing, Nothing, strSupplier, Nothing, strDateBegin, strDateEnd)
        ElseIf Me.lblTittle.Text = "驗收單批量付款確認" Then
            Dim ai As List(Of AcceptanceInfo)
            Dim row As DataRow
            Dim i%
            ai = ac.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, "True", "True", Nothing, Nothing, strSupplier, "False", strDateBegin, strDateEnd)

            If ai.Count <= 0 Then
                Grid.DataSource = Nothing
                Exit Sub
            End If

            For i = 0 To ai.Count - 1
                row = ds.Tables("Acceptance").NewRow
                row("A_NO") = ai(i).A_NO
                row("A_AcceptanceNO") = ai(i).A_AcceptanceNO
                row("PM_NO") = ai(i).PM_NO
                row("M_Code") = ai(i).M_Code
                row("M_Name") = ai(i).M_Name
                row("A_SendNO") = ai(i).A_SendNO
                row("A_Qty") = ai(i).A_Qty
                row("A_SendDate") = ai(i).A_SendDate
                row("S_SupplierName") = ai(i).S_SupplierName

                '判斷是否有退貨記錄
                Dim rc As New RetrocedeController
                Dim riList As New List(Of RetrocedeInfo)
                riList = rc.Retrocede_GetList(Nothing, ai(i).A_AcceptanceNO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, ai(i).M_Code, Nothing, Nothing, Nothing)
                If riList.Count > 0 Then
                    row("Status") = "存在退貨記錄"
                End If
                ds.Tables("Acceptance").Rows.Add(row)
            Next
        End If

    End Sub
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
    ''' 單擊右鍵刪除菜單，刪除與選中項相同的所有驗收單
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsDelete.Click
        Dim i, j%
        Dim strA_AcceptanceNO As String
        strA_AcceptanceNO = GridView1.GetFocusedRowCellValue("A_AcceptanceNO")     '記錄選中項的驗收單號
        For j = 0 To GridView1.RowCount - 1        '兩次For循環實現刪除與選中項相同的所有驗收單
            For i = 0 To GridView1.RowCount - 1
                If strA_AcceptanceNO = GridView1.GetRowCellValue(i, "A_AcceptanceNO") Then      '判斷是否有與選中項相同的驗收單號
                    GridView1.DeleteRow(i)      '刪除行
                End If
            Next
        Next
    End Sub
    ''' <summary>
    ''' 單擊右鍵查看菜單，查看選中驗收單信息
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsView.Click
        On Error Resume Next

        If GridView1.RowCount = 0 Then Exit Sub
        Dim fr As frmAcceptance

        tempValue2 = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        MTypeName = "AcceptanceView"

        fr = New frmAcceptance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub
    ''' <summary>
    ''' 供應商名稱輸入框中按空格鍵彈出下拉菜單
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluSupplier.KeyDown
        If e.KeyCode = Keys.Space Then
            gluSupplier.ShowPopup()
        End If
    End Sub
End Class
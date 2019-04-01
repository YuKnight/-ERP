Imports LFERP.Library.WareHouse.WareBorrowReturn
Imports LFERP.Library.Shared

Public Class frmWareNOReturn

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim ds As New DataSet
        Dim strA As String

        Dim ltc As New CollectionToDataSet
        strA = tempValue
        tempValue = Nothing

        Dim strWB_PerID As String = Nothing
        If Me.TextEdit1.Text = "" Then
            strWB_PerID = Nothing
        Else
            strWB_PerID = TextEdit1.Text
        End If

        Dim bc As New WareBorrowReturnControl
        If bc.WareBorrowReturnNOReturn_GetList1(Format(CDate(DateEdit1.EditValue), "yyyy/MM/dd"), Nothing, strWB_PerID).Count <= 0 Then
            MsgBox("無數據存在!")
            Exit Sub
        End If

        ltc.CollToDataSet(ds, "WareBorrowReturn", bc.WareBorrowReturnNOReturn_GetList1(Format(CDate(DateEdit1.EditValue), "yyyy/MM/dd"), Nothing, strWB_PerID))

        Dim printstr As String
        printstr = Format(CDate(DateEdit1.EditValue), "yyyy/MM/dd") & "之前未還刀具."

        PreviewRPT1(ds, "rptWareNOReturn", "指定時間未還刀", printstr, "", True, True)
        ltc = Nothing

        Me.Close()
    End Sub

    Private Sub frmWareNOReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.EditValue = Format(Now, "yyyy/MM" & "/01")
    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged

    End Sub

    '2014-03-04mao
    Private Sub TextEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit1.KeyDown
        If e.KeyCode = Keys.Enter And TextEdit1.Text <> "" Then

            Dim wulc As New WhiteUserListController
            Dim wuliL As New List(Of WhiteuserListInfo)
            wuliL = wulc.WhiteUserList_GetList(TextEdit1.Text, Nothing)
            If wuliL.Count <= 0 Then
                MsgBox("請確認此員工，是否在白名單中!")
            Else
                Label4.Text = wuliL.Item(0).W_UserName
            End If
        End If
    End Sub
End Class
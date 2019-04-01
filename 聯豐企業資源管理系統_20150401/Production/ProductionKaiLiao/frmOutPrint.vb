Imports LFERP.Library.ProductionKaiLiao

Public Class frmOutPrint

    Dim pkc As New ProductionKaiLiaoControl
    Dim strdate1, strdate2 As String

    Private Sub frmOutPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextEdit1.Text = tempValue
        tempValue = ""
        CheckBox1.Checked = True
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")
        DateEdit2.Text = Format(Now, "yyyy/MM/dd")

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click


        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet

        ds.Tables.Clear()
        Dim strA As String
        strA = TextEdit1.Text

        If CheckBox1.Checked = True Then
            strdate1 = DateEdit1.Text
            strdate2 = DateEdit2.Text
        Else
            strdate1 = Nothing
            strdate2 = Nothing
        End If

        If pkc.KaiLiaoManagement_GetList(Nothing, Nothing, Nothing, strA, Nothing, "原材料", strdate1, strdate2, Nothing).Count = 0 Then
            MsgBox("當前無此開料單領出記錄!")
            Exit Sub
        End If

        ltc.CollToDataSet(ds, "KaiLiaoManagement", pkc.KaiLiaoManagement_GetList(Nothing, Nothing, Nothing, strA, Nothing, "原材料", strdate1, strdate2, Nothing))

        PreviewRPT(ds, "rptKaiLiaoTotal", "部門領料記錄", True, True)

        ltc = Nothing
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DateEdit1.Enabled = True
            DateEdit2.Enabled = True
        Else
            DateEdit1.Enabled = False
            DateEdit2.Enabled = False
        End If
    End Sub
End Class
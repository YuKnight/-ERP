Imports LFERP.Library.SampleManager.SamplePacking

Public Class frmSamplePackingPrint
    Dim pkc As New SamplePackingController
    Dim strdate1, strdate2 As String

    Private Sub frmOutPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
 
        strdate1 = DateEdit1.Text
        strdate2 = DateEdit2.Text

        If pkc.SamplePacking_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, strdate1, strdate2, Nothing).Count = 0 Then
            MsgBox("沒有資料可列印！")
            Exit Sub
        End If

        ltc.CollToDataSet(ds, "SamplePacking", pkc.SamplePacking_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, strdate1, strdate2, Nothing))

        PreviewRPT1(ds, "rptSamplePackingAll", "包裝明細資料", strdate1 + "至" + strdate2, InUserID, True, True)

        ltc = Nothing
        Me.Close()
    End Sub

End Class
Imports LFERP.Library.KnifeWare
Public Class frmKnifeChangeLoad
    Dim ds As New DataSet

    Private Sub frmKnifeChangeLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabWH_ID.Text = tempValue '倉庫編號

        If tempValue2 = "KT3" Then
            XtraTabControl1.SelectedTabPage = XtraTabPage1
            XtraTabControl1.TabPages(1).PageVisible = False
        ElseIf tempValue2 = "KT4" Then
            XtraTabControl1.SelectedTabPage = XtraTabPage1
            XtraTabControl1.TabPages(1).PageVisible = True
        ElseIf tempValue2 = "KT5" Then
        End If


        tempValue = Nothing
        tempValue2 = Nothing
        GoIN.Visible = False


        CreateTables()

        Me.TextBrrow.Text = "KF000000001"
    End Sub
    ''' <summary>
    ''' 建表結構
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("KnifeChangeLoad")
            .Columns.Add("GoIN", GetType(Boolean))
            .Columns.Add("B_Num", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("B_Qty", GetType(Int32))
            .Columns.Add("R_Qty", GetType(Int32))
            .Columns.Add("BPer_Name", GetType(String))
        End With

        Grid3.DataSource = ds.Tables("KnifeChangeLoad")

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonLoadBnum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoadBnum1.Click

        ds.Tables("KnifeChangeLoad").Clear()

        Dim cb As New List(Of KnifeBorrowInfo)
        Dim cc As New KnifeBorrowControl
        cb = cc.KnifeBorrow_GetList(TextBrrow.Text, Nothing, Nothing, LabWH_ID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If cb.Count = 1 Then
        Else
            MsgBox("此領刀單輸入有誤!", 64, "提示")
            Exit Sub
        End If

        Dim row As DataRow
        row = ds.Tables("KnifeChangeLoad").NewRow
        row("GoIN") = False
        row("B_Num") = cb(0).B_Num
        row("M_Code") = cb(0).M_Code
        row("M_Name") = cb(0).M_Name

        row("B_Qty") = cb(0).B_Qty
        row("R_Qty") = cb(0).R_Qty
        row("BPer_Name") = cb(0).BPer_Name

        ds.Tables("KnifeChangeLoad").Rows.Add(row)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If ds.Tables("KnifeChangeLoad").Rows.Count <= 0 Then
            MsgBox("無數據存在!", 64, "提示")
            Exit Sub
        End If
    End Sub
End Class
Imports LFERP.Library.BroadCastManager.BroadCastMessage
Imports LFERP.Library.BroadCastManager.BroadCastFactory
Public Class frmBroadCastBrigade

    Dim ds As New DataSet

    Private Sub frmBroadCastBrigade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NavBarItem1_LinkClicked(Nothing, Nothing)
    End Sub

    Private Sub NavBarItem1_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem1.LinkClicked
        CreateTablesMain()
    End Sub

    Sub CreateTablesMain()
        ds.Tables.Clear()
        With ds.Tables.Add("broadMessage")
            .Columns.Add("M_Type", GetType(String))
            .Columns.Add("M_Date", GetType(String))
            .Columns.Add("M_Time", GetType(String))
            .Columns.Add("M_Out", GetType(String))
            .Columns.Add("M_Message", GetType(String))
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("M_Status", GetType(String))
            .Columns.Add("GridColumn1", GetType(Image))
        End With
        gridBroadCastBrigade.DataSource = ds.Tables("broadMessage")
        LoadDataMain()
    End Sub

    Sub LoadDataMain()
        Dim bcb As New BroadCastMessageControler()
        Dim ci As New List(Of BroadCastMessageInfo)
        ci = bcb.BroadCastMessage_Getlist(Nothing, InUser, Nothing, False, Nothing)
        If ci.Count = 0 Then
            Exit Sub
        End If
        Dim i As Integer
        For i = 0 To ci.Count - 1
            Dim row As DataRow
            row = ds.Tables("broadMessage").NewRow
            row("M_Type") = ci(i).M_Type
            row("M_Date") = Format(CDate(ci(i).M_Date), "yyyy-MM-dd")
            row("M_Time") = Format(CDate(ci(i).M_Date), "HH:mm:ss")
            row("M_Out") = ci(i).M_Out
            row("M_Message") = ci(i).M_Message
            row("AutoID") = ci(i).AutoID
            row("M_Status") = ci(i).M_Status
            Select Case ci(i).M_Status
                Case "new"
                    Select Case ci(i).M_Type
                        Case "¤@¯ë"
                            row("GridColumn1") = Global.LFERP.My.Resources.Resources.Acommon

                        Case "ºò«æ"
                            row("GridColumn1") = Global.LFERP.My.Resources.Resources.Aurgency 'Image.FromFile("Image\urgency.ico")
                        Case "³qª¾"
                            row("GridColumn1") = Global.LFERP.My.Resources.Resources.Ainform 'Image.FromFile("Image\inform.ico")
                    End Select
                Case "check"
                    row("GridColumn1") = Global.LFERP.My.Resources.Resources.Acheck
                Case "reply"
                    row("GridColumn1") = Global.LFERP.My.Resources.Resources.Areply1
            End Select
            ds.Tables("broadMessage").Rows.Add(row)
        Next

    End Sub

    Private Sub NavBarItem2_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        frmOut.isResponse = "isSend"
        frmOut.ShowDialog()
    End Sub

    Private Sub gridBroadCastBrigade_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridBroadCastBrigade.DoubleClick
        If gridView1.RowCount = 0 Then Exit Sub
        frmView.EditItem = gridView1.GetFocusedRowCellValue("AutoID").ToString
        frmView.MessageIn = gridView1.GetFocusedRowCellValue("M_Out").ToString
        frmView.mdate = gridView1.GetFocusedRowCellValue("M_Date").ToString
        frmView.mtime = gridView1.GetFocusedRowCellValue("M_Time").ToString
        frmOut.autoid = gridView1.GetFocusedRowCellValue("AutoID").ToString
        Dim bcm As New BroadCastMessageControler
        Dim bm As New List(Of BroadCastMessageInfo)
        bm = bcm.BroadCastMessage_Getlist(Nothing, Nothing, Nothing, False, gridView1.GetFocusedRowCellValue("AutoID").ToString)
        If bm.Count <= 0 Then
            Exit Sub
        Else
            Dim bcmi As New BroadCastMessageInfo
            bcmi.AutoID = bm(0).AutoID
            bcmi.M_Adddate = Format(CDate(bm(0).M_Adddate), "yyyy/MM/dd")
            bcmi.M_AdduserID = bm(0).M_AdduserID
            bcmi.M_Affirm = bm(0).M_Affirm
            bcmi.M_Date = bm(0).M_Date
            bcmi.M_In = bm(0).M_In
            bcmi.M_Message = bm(0).M_Message
            bcmi.M_ModifyDate = bm(0).M_ModifyDate
            bcmi.M_ModifyUserID = bm(0).M_ModifyUserID
            bcmi.M_Out = bm(0).M_Out
            bcmi.M_Time = bm(0).M_Time
            bcmi.M_Type = bm(0).M_Type
            If bm(0).M_Status <> "reply" Then
                bcmi.M_Status = "check"
            Else
                bcmi.M_Status = bm(0).M_Status
            End If
            bcm.BroadCastMessage_Update(bcmi)
        End If
        frmView.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        NavBarItem1_LinkClicked(Nothing, Nothing)
    End Sub

    Private Sub gridView1_CustomDrawCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
        If e.Column.FieldName = "M_Type" Then
            If e.CellValue = "ºò«æ" Then
                e.Appearance.ForeColor = Color.Red
            End If
        End If
    End Sub
End Class
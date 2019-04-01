Imports LFERP.Library.PieceProcess
Public Class FrmSumWorkGroupSub
    Dim pc As New LFERP.Library.PieceProcess.WorkGroupControl
    Dim piL As New List(Of LFERP.Library.PieceProcess.WorkGroupInfo)
    Dim ppc As New LFERP.Library.PieceProcessMoSub.PieceProcessMoSubControl
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub FrmSumWorkGroupSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelControl8.Text = tempValue
        tempValue = ""
        Select Case tempValue2
            Case "組別計件錄入"
                If Edit = False Then
                    Me.Text = "組別計件新增"
                    TextEdit2.Text = "1"
                    DateEdit2.Text = Format(Now, "yyyy/MM/dd")
                Else
                    Me.Text = "組別計件修改"
                    DateEdit2.Enabled = False
                    LoadData(LabelControl8.Text)
                End If
            Case "View"
                TextEdit1.Enabled = False
                TextEdit2.Enabled = False
                TextEdit4.Enabled = False
                GridLookUpEdit1.Enabled = False
                GridLookUpEdit2.Enabled = False
                DateEdit2.Enabled = False
                MemoEdit1.Enabled = False
                cmdSave.Enabled = False
                LoadData(LabelControl8.Text)
        End Select
        tempValue2 = ""

        GridLookUpEdit1.Properties.DataSource = pc.PieceMoWorkGroup_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "Wg_Name"
        GridLookUpEdit1.Properties.ValueMember = "Wg_NO"

        GridLookUpEdit2.Properties.DataSource = ppc.PieceProcessMoSub_GetList(TextEdit1.Text, Nothing, Nothing)
        GridLookUpEdit2.Properties.DisplayMember = "PM_Name"
        GridLookUpEdit2.Properties.ValueMember = "PM_Num"

    End Sub
    Private Sub LoadData(ByVal PG_NO As String)

        piL = pc.PieceSumWorkGroup_GetList(PG_NO, Nothing, Nothing, Nothing, Nothing)
        TextEdit1.Text = piL(0).PM_NO
        TextEdit2.Text = piL(0).PG_Factor
        GridLookUpEdit1.EditValue = piL(0).Wg_NO
        GridLookUpEdit2.EditValue = piL(0).PM_Num
        DateEdit2.Text = piL(0).PG_AddDate
        TextEdit4.Text = piL(0).PG_Qty
        MemoEdit1.Text = piL(0).PG_Remark

        GridLookUpEdit1.Properties.DataSource = pc.PieceMoWorkGroup_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "Wg_Name"
        GridLookUpEdit1.Properties.ValueMember = "Wg_NO"

        GridLookUpEdit2.Properties.DataSource = ppc.PieceProcessMoSub_GetList(TextEdit1.Text, Nothing, Nothing)
        GridLookUpEdit2.Properties.DisplayMember = "PM_Name"
        GridLookUpEdit2.Properties.ValueMember = "PM_Num"

    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Edit = False Then
            SaveNew()
        Else
            SaveEdit()
        End If
    End Sub
    Private Sub SaveNew()
        Dim pi As New LFERP.Library.PieceProcess.WorkGroupInfo

        pi.PG_NO = GetNO()
        pi.PM_NO = TextEdit1.Text
        pi.Wg_NO = GridLookUpEdit1.EditValue
        pi.PM_Num = GridLookUpEdit2.EditValue
        pi.PG_Factor = TextEdit2.Text
        pi.PG_Qty = TextEdit4.Text
        pi.PG_AddDate = DateEdit2.Text
        pi.PG_Remark = MemoEdit1.Text
        pi.PG_Action = InUserID

        If pc.PieceSumWorkGroup_Add(pi) = False Then
            MsgBox("添加失敗")
            Exit Sub
        End If
        Me.Close()

    End Sub
    Private Sub SaveEdit()
        Dim pi As New LFERP.Library.PieceProcess.WorkGroupInfo

        pi.PG_NO = LabelControl8.Text
        pi.PM_NO = TextEdit1.Text
        pi.Wg_NO = GridLookUpEdit1.EditValue
        pi.PM_Num = GridLookUpEdit2.EditValue
        pi.PG_Factor = TextEdit2.Text
        pi.PG_Qty = TextEdit4.Text
        pi.PG_AddDate = DateEdit2.Text
        pi.PG_Remark = MemoEdit1.Text
        pi.PG_Action = InUserID

        If pc.PieceSumWorkGroup_Update(pi) = False Then
            MsgBox("保存失敗")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Function GetNO() As String
        Dim pi As New LFERP.Library.PieceProcess.WorkGroupInfo

        Dim str As String
        str = CStr(Format(Now, "yyMMdd"))
        pi = pc.PieceSumWorkGroup_GetNO(str)

        If pi Is Nothing Then
            GetNO = "PG" & str & "00001"
        Else
            GetNO = "PG" & str & Mid((CInt(Mid(pi.PG_NO, 9)) + 100001), 2)
        End If

    End Function

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged

        Dim piL2 As New List(Of LFERP.Library.PieceProcess.WorkGroupInfo)
        piL2 = pc.PieceMoWorkGroup_GetList(GridLookUpEdit1.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing)
        LabelControl12.Text = piL2(0).Wg_Manager

    End Sub
    Private Sub TextEdit1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.TextChanged, TextEdit2.TextChanged
        GridLookUpEdit2.Properties.DataSource = ppc.PieceProcessMoSub_GetList(TextEdit1.Text, Nothing, Nothing)
        GridLookUpEdit2.Properties.DisplayMember = "PM_Name"
        GridLookUpEdit2.Properties.ValueMember = "PM_Num"
    End Sub
End Class
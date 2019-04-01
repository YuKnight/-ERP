Imports LFERP.Library.PieceProcess
Imports LFERP.DataSetting
Imports LFERP.Library.PieceProcessMoSub
Public Class FrmSumPersonnelSub

    Dim pc As New LFERP.Library.PieceProcess.PersonnelControl
    Dim piL As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)
    Dim puc As New LFERP.DataSetting.UserPowerControl
    Dim ppc As New LFERP.Library.PieceProcessMoSub.PieceProcessMoSubControl

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Edit = False Then
            SaveNew()
        Else
            SaveEdit()
        End If

    End Sub
    Private Sub SaveNew()
        Dim i As Integer
        Dim pi As New LFERP.Library.PieceProcess.PersonnelInfo
        If SimpleButton1.Text = "單項" Then
            pi.PP_NO = GetNO()
            pi.Per_NO = GridLookUpEdit1.EditValue
            pi.PM_Num = GridLookUpEdit2.EditValue
            pi.PM_NO = TextEdit1.Text
            pi.PP_Qty = TextEdit4.Text
            pi.PP_AddDate = DateEdit2.Text
            pi.PP_Remark = MemoEdit1.Text
            pi.PP_Action = InUserID
            If pc.PieceSumPersonnel_Add(pi) = False Then
                MsgBox("添加失敗")
                Exit Sub
            End If
        Else
            For i = 0 To Me.GridView2.RowCount - 1
                If GridView2.GetRowCellValue(i, "Choose") = True Then
                    pi.PP_NO = GetNO()
                    pi.Per_NO = GridLookUpEdit1.EditValue
                    pi.PM_Num = GridView2.GetRowCellValue(i, "PM_Num")
                    pi.PM_NO = TextEdit1.Text
                    pi.PP_Qty = TextEdit4.Text
                    pi.PP_AddDate = DateEdit2.Text
                    pi.PP_Remark = MemoEdit1.Text
                    pi.PP_Action = InUserID
                    pc.PieceSumPersonnel_Add(pi)
                End If
            Next
        End If
        Me.Close()

    End Sub
    Private Sub SaveEdit()
        Dim pi As New LFERP.Library.PieceProcess.PersonnelInfo

        pi.PP_NO = LabelControl8.Text
        pi.Per_NO = GridLookUpEdit1.EditValue
        pi.PM_Num = GridLookUpEdit2.EditValue
        pi.PM_NO = TextEdit1.Text
        pi.PP_Qty = TextEdit4.Text
        pi.PP_AddDate = DateEdit2.Text
        pi.PP_Remark = MemoEdit1.Text
        pi.PP_Action = InUserID

        If pc.PieceSumPersonnel_Update(pi) = False Then
            MsgBox("保存失敗")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub FrmSumPersonnelSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Select Case tempValue2
            Case "員工計件"
                If Edit = False Then

                    Me.Text = "計件新增"
                    DateEdit2.Text = Format(Now, "yyyy/MM/dd")
                Else
                    Me.Text = "計件修改"
                    DateEdit2.Enabled = False
                    LabelControl8.Text = tempValue
                    tempValue = ""
                    LoadData(LabelControl8.Text)
                End If
            Case "View"
                TextEdit1.Enabled = False
                GridLookUpEdit1.Enabled = False
                GridLookUpEdit2.Enabled = False
                DateEdit2.Enabled = False
                MemoEdit1.Enabled = False
                cmdSave.Enabled = False
                LoadData(LabelControl8.Text)
        End Select
        tempValue2 = ""

        GridLookUpEdit1.Properties.DataSource = pc.PieceMoPersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "Per_Name"
        GridLookUpEdit1.Properties.ValueMember = "Per_NO"

        GridLookUpEdit2.Properties.DataSource = ppc.PieceProcessMoSub_GetList(TextEdit1.Text, Nothing, Nothing)
        GridLookUpEdit2.Properties.DisplayMember = "PM_Name"
        GridLookUpEdit2.Properties.ValueMember = "PM_Num"
    End Sub
    Private Sub LoadData(ByVal PP_No As String)
        Dim piL2 As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)

        piL = pc.PieceSumPersonnel_GetList(PP_No, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        piL2 = pc.PieceMoPersonnel_GetList(GridLookUpEdit1.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        LabelControl10.Text = piL2(0).DepName
        LabelControl12.Text = piL2(0).Per_NO
        TextEdit1.Text = piL(0).PM_NO
        GridLookUpEdit1.EditValue = piL(0).Per_NO
        GridLookUpEdit2.EditValue = piL(0).PM_NUM
        DateEdit2.Text = piL(0).PP_AddDate
        TextEdit4.Text = piL(0).PP_Qty
        MemoEdit1.Text = piL(0).PP_Remark

        GridLookUpEdit1.Properties.DataSource = pc.PieceMoPersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "Per_Name"
        GridLookUpEdit1.Properties.ValueMember = "Per_NO"

        GridLookUpEdit2.Properties.DataSource = ppc.PieceProcessMoSub_GetList(TextEdit1.Text, Nothing, Nothing)
        GridLookUpEdit2.Properties.DisplayMember = "PM_Name"
        GridLookUpEdit2.Properties.ValueMember = "PM_Num"
    End Sub
    Private Function GetNO() As String

        Dim pi As New LFERP.Library.PieceProcess.PersonnelInfo

        Dim str As String
        str = CStr(Format(Now, "yyMMdd"))
        pi = pc.PieceSumPersonnel_GetNO(str)

        If pi Is Nothing Then
            GetNO = "PP" & str & "00001"
        Else
            GetNO = "PP" & str & Mid((CInt(Mid(pi.PP_NO, 9)) + 100001), 2)
        End If

    End Function

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
        Dim piL2 As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)
        piL2 = pc.PieceMoPersonnel_GetList(GridLookUpEdit1.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        LabelControl10.Text = piL2(0).DepName
        LabelControl12.Text = piL2(0).Per_NO

    End Sub

    Private Sub TextEdit1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.TextChanged
        GridLookUpEdit2.Properties.DataSource = ppc.PieceProcessMoSub_GetList(TextEdit1.Text, Nothing, Nothing)
        GridLookUpEdit2.Properties.DisplayMember = "PM_Name"
        GridLookUpEdit2.Properties.ValueMember = "PM_Num"
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If SimpleButton1.Text = "單項" Then
            SimpleButton1.Text = "多項"
            Me.Width = "564"
        Else
            SimpleButton1.Text = "單項"
            Me.Width = "319"
        End If
    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged
        Dim pc As New LFERP.Library.PieceProcessMoSub.PieceProcessMoSubControl
        Me.GridControl1.DataSource = pc.PieceProcessMo_GetList(Trim(TextEdit1.Text), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "1", Nothing)
    End Sub
End Class
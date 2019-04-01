Imports LFERP.Library.PieceProcess
Imports LFERP.DataSetting

Public Class FrmTimeWorkGroupSub
    Dim pc As New LFERP.Library.PieceProcess.WorkGroupControl
    Dim piL As New List(Of LFERP.Library.PieceProcess.WorkGroupInfo)
    Dim puc As New LFERP.Library.PieceProcess.PersonnelControl

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
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
        pi.PT_NO = GetNO()
        pi.Per_NO = GridLookUpEdit2.EditValue
        pi.Wg_NO = GridLookUpEdit1.EditValue
        pi.PT_AddDate = DateEdit1.Text
        pi.PT_BeginDate = TextEdit1.Text
        pi.PT_EndDate = TextEdit2.Text
        pi.PT_QtyTime = TextEdit3.Text
        pi.PT_Remark = MemoEdit1.Text
        pi.PT_Action = InUserID

        If pc.PieceTimeWorkGroup_Add(pi) = False Then
            MsgBox("添加失敗")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub SaveEdit()
        Dim pi As New LFERP.Library.PieceProcess.WorkGroupInfo
        pi.PT_NO = LabelControl7.Text
        pi.Per_NO = GridLookUpEdit2.EditValue
        pi.Wg_NO = GridLookUpEdit1.EditValue
        pi.PT_EditDate = Format(Now, "yyyy/MM/dd")
        pi.PT_BeginDate = TextEdit1.Text
        pi.PT_EndDate = TextEdit2.Text
        pi.PT_QtyTime = TextEdit3.Text
        pi.PT_Remark = MemoEdit1.Text
        pi.PT_Action = InUserID

        If pc.PieceTimeWorkGroup_Update(pi) = False Then
            MsgBox("保存失敗")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub FrmTimeWorkGroupSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")
        DateEdit1.Enabled = False
        LabelControl7.Text = tempValue
        tempValue = ""
        Select Case tempValue2
            Case "組別計時錄入"
                If Edit = False Then
                    Me.Text = "員工新增"
                Else
                    Me.Text = "員工修改"
                    GridLookUpEdit2.Enabled = False
                    GridLookUpEdit1.Enabled = False
                    LoadData(LabelControl7.Text)
                End If
            Case "View"
                TextEdit1.Enabled = False
                TextEdit2.Enabled = False
                TextEdit3.Enabled = False
                MemoEdit1.Enabled = False
                GridLookUpEdit2.Enabled = False
                GridLookUpEdit1.Enabled = False
                LoadData(LabelControl7.Text)
        End Select
        tempValue2 = ""

        GridLookUpEdit2.Properties.DataSource = puc.PieceMoPersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit2.Properties.DisplayMember = "Per_Name"
        GridLookUpEdit2.Properties.ValueMember = "Per_NO"

        GridLookUpEdit1.Properties.DataSource = pc.PieceMoWorkGroup_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "Wg_Name"
        GridLookUpEdit1.Properties.ValueMember = "Wg_NO"
    End Sub
    Private Sub LoadData(ByVal PT_No As String)

        GridLookUpEdit2.Properties.DataSource = puc.PieceMoPersonnel_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit2.Properties.DisplayMember = "Per_Name"
        GridLookUpEdit2.Properties.ValueMember = "Per_NO"

        GridLookUpEdit1.Properties.DataSource = pc.PieceMoWorkGroup_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "Wg_Name"
        GridLookUpEdit1.Properties.ValueMember = "Wg_NO"

        piL = pc.PieceTimeWorkGroup_GetList(PT_No, Nothing, Nothing)
        GridLookUpEdit2.EditValue = piL(0).Per_NO
        GridLookUpEdit1.EditValue = piL(0).Wg_NO
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")
        TextEdit1.Text = piL(0).PT_BeginDate
        TextEdit2.Text = piL(0).PT_EndDate
        TextEdit3.Text = piL(0).PT_QtyTime
        MemoEdit1.Text = piL(0).PT_Remark
    End Sub
    Private Function GetNO() As String
        Dim pi As New LFERP.Library.PieceProcess.WorkGroupInfo
        Dim str As String
        str = CStr(Format(Now, "yyMMdd"))
        pi = pc.PieceTimeWorkGroup_GetNO(str)
        If pi Is Nothing Then
            GetNO = "PT" & str & "00001"
        Else
            GetNO = "PT" & str & Mid((CInt(Mid(pi.PT_NO, 9)) + 100001), 2)
        End If

    End Function
End Class
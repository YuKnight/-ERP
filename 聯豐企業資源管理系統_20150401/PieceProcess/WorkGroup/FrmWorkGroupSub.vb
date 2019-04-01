Imports LFERP.Library.PieceProcess

Public Class FrmWorkGroupSub

    Dim pc As New LFERP.Library.PieceProcess.WorkGroupControl
    Dim plc As New LFERP.Library.PieceProcess.PersonnelControl
    Dim piL As New List(Of LFERP.Library.PieceProcess.WorkGroupInfo)
    Dim pli As New LFERP.Library.PieceProcess.PersonnelInfo

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub FrmWorkGroupSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelControl7.Text = tempValue
        tempValue = ""
        Select Case tempValue2
            Case "組別錄入"
                If Edit = False Then
                    Me.Text = "組別新增"
                Else
                    Me.Text = "組別修改"
                    'TextEdit1.Enabled = False
                    'TextEdit2.Enabled = False
                    LoadData(LabelControl7.Text)
                End If
            Case "View"

                TextEdit1.Enabled = False
                TextEdit2.Enabled = False
                GridLookUpEdit1.Enabled = False
                MemoEdit1.Enabled = False

                LoadData(LabelControl7.Text)
        End Select
        tempValue2 = ""
        GridLookUpEdit1.Properties.DataSource = plc.DepFac_GetList(Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "DepName"
        GridLookUpEdit1.Properties.ValueMember = "DepID"
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
        pi.Wg_NO = GetNO()
        pi.Wg_Name = TextEdit1.Text
        pi.Wg_Manager = TextEdit2.Text
        pi.DepNO = GridLookUpEdit1.EditValue
        pi.Wg_Remark = MemoEdit1.Text
        pi.Wg_AddDate = Format(Now, "yyyy/MM/dd")
        pi.Wg_Action = InUserID

        If pc.PieceMoWorkGroup_Add(pi) = False Then
            MsgBox("添加失敗")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub SaveEdit()
        Dim pi As New LFERP.Library.PieceProcess.WorkGroupInfo
        pi.Wg_NO = LabelControl7.Text
        pi.Wg_Name = TextEdit1.Text
        pi.Wg_Manager = TextEdit2.Text
        pi.DepNO = GridLookUpEdit1.EditValue
        pi.Wg_Remark = MemoEdit1.Text
        pi.Wg_AddDate = Format(Now, "yyyy/MM/dd")
        pi.Wg_Action = InUserID

        If pc.PieceMoWorkGroup_Update(pi) = False Then
            MsgBox("保存失敗")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub LoadData(ByVal Wg_No As String)

        GridLookUpEdit1.Properties.DataSource = plc.DepFac_GetList(Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "DepName"
        GridLookUpEdit1.Properties.ValueMember = "DepID"

        piL = pc.PieceMoWorkGroup_GetList(LabelControl7.Text, Nothing, Nothing, Nothing, Nothing, Nothing)
        TextEdit1.Text = piL(0).Wg_Name
        TextEdit2.Text = piL(0).Wg_Manager

        GridLookUpEdit1.EditValue = piL(0).DepID
        MemoEdit1.Text = piL(0).Wg_Remark

    End Sub
    Private Function GetNO() As String
        Dim pi As New LFERP.Library.PieceProcess.WorkGroupInfo
        Dim str As String
        str = CStr(Format(Now, "yyMM"))
        pi = pc.PieceMoWorkGroup_GetNO(str)
        If pi Is Nothing Then
            GetNO = "WG" & str & "00001"
        Else
            GetNO = "WG" & str & Mid((CInt(Mid(pi.Wg_NO, 9)) + 100001), 2)
        End If

    End Function
End Class
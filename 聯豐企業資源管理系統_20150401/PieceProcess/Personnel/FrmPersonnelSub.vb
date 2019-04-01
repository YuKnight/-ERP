Imports LFERP.Library.PieceProcess

Public Class FrmPersonnelSub
    Dim pc As New LFERP.Library.PieceProcess.PersonnelControl
    Dim pi As New LFERP.Library.PieceProcess.PersonnelInfo
    Dim piL As New List(Of LFERP.Library.PieceProcess.PersonnelInfo)
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
        pi.Per_NO = TextEdit1.Text
        pi.Per_Name = TextEdit2.Text
        pi.DepNO = GridLookUpEdit1.EditValue
        pi.Wg_NO = GridLookUpEdit2.EditValue
        pi.Per_Pay = TextEdit4.Text
        pi.Per_Remark = MemoEdit1.Text
        pi.Per_PayType = ComboBoxEdit1.Text
        pi.Per_AddDate = Format(Now, "yyyy/MM/dd")
        pi.Per_Action = InUserID

        If pc.PieceMoPersonnel_Add(pi) = False Then
            MsgBox("添加失敗")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub SaveEdit()
        pi.Per_NO = TextEdit1.Text
        pi.Per_Name = TextEdit2.Text
        pi.DepNO = GridLookUpEdit1.EditValue
        pi.Wg_NO = GridLookUpEdit2.EditValue
        pi.Per_Pay = TextEdit4.Text
        pi.Per_Remark = MemoEdit1.Text
        pi.Per_PayType = ComboBoxEdit1.Text
        pi.Per_Action = InUserID

        If pc.PieceMoPersonnel_Update(pi) = False Then
            MsgBox("保存失敗")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub FrmPersonnelSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LabelControl7.Text = tempValue
        tempValue = ""
        Select Case tempValue2
            Case "員工錄入"
                If Edit = False Then
                    Me.Text = "員工新增"
                Else
                    Me.Text = "員工修改"
                    TextEdit1.Enabled = False
                    TextEdit2.Enabled = False
                    GridLookUpEdit2.Enabled = False
                    LoadData(LabelControl7.Text)
                End If
            Case "View"

                ComboBoxEdit1.Enabled = False
                TextEdit1.Enabled = False
                TextEdit2.Enabled = False
                TextEdit4.Enabled = False
                GridLookUpEdit1.Enabled = False
                MemoEdit1.Enabled = False
                cmdSave.Enabled = False

                LoadData(LabelControl7.Text)
        End Select
        tempValue2 = ""
        GridLookUpEdit1.Properties.DataSource = pc.DepFacUser_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "DepName"
        GridLookUpEdit1.Properties.ValueMember = "DepID"
    End Sub
    Private Sub LoadData(ByVal PerNo As String)

        GridLookUpEdit1.Properties.DataSource = pc.DepFacUser_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "DepName"
        GridLookUpEdit1.Properties.ValueMember = "DepID"

        piL = pc.PieceMoPersonnel_GetList(PerNo, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        TextEdit1.Text = piL(0).Per_NO
        TextEdit2.Text = piL(0).Per_Name
        GridLookUpEdit1.EditValue = piL(0).DepID
        GridLookUpEdit2.EditValue = piL(0).Wg_NO
        TextEdit4.Text = piL(0).Per_Pay
        MemoEdit1.Text = piL(0).Per_Remark
        ComboBoxEdit1.Text = piL(0).Per_PayType
    End Sub

    Private Sub GridLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridLookUpEdit1.EditValueChanged
        Dim wgc As New LFERP.Library.PieceProcess.WorkGroupControl
        If wgc.PieceMoWorkGroup_GetList(Nothing, Nothing, GridLookUpEdit1.EditValue, Nothing, Nothing, Nothing).Count < 0 Then
            GridLookUpEdit2.EditValue = "無"
            Exit Sub
        End If
        GridLookUpEdit2.Properties.DataSource = wgc.PieceMoWorkGroup_GetList(Nothing, Nothing, GridLookUpEdit1.EditValue, Nothing, Nothing, Nothing)
        GridLookUpEdit2.Properties.DisplayMember = "Wg_Name"
        GridLookUpEdit2.Properties.ValueMember = "Wg_NO"

    End Sub

    Private Sub TextEdit1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.MouseLeave

    End Sub
End Class
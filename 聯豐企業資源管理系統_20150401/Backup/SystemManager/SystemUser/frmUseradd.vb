Imports LFERP.SystemManager.SystemUser
Imports LFERP.DataSetting

Imports LFERP.Library.PieceProcess
Public Class frmUseradd
    Private fs As IO.FileStream
    Public uu As New SystemUserController
    Public us As New SystemUserInfo
    Dim ui As New SystemUserInfo
    Dim up As New List(Of SystemUserInfo)

    Dim pc As New LFERP.Library.PieceProcess.PersonnelControl

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Edit = True Then
            us.U_ID = txtuserid.Text.ToString
            us.U_Name = txtusername.Text.ToString
            us.U_PassWord = txtuserpsw.Text.ToString
            us.DPT_ID = PopDPT.EditValue
            us.U_KeyImage = ImageToByte(pPhoto.Image)

            ui.UserID = txtuserid.Text.ToString
            ui.UserName = GridLookUpEdit1.Text
            ui.UserRank = ComboBoxEdit1.Text
            ui.DepID = GridLookUpEdit1.EditValue
            ui.UserType = ComboBoxEdit2.EditValue
            If CheckEdit1.Checked = False Then
                If uu.SystemUser_Update(us) = True Then
                    MsgBox("修改成功")
                    Me.Close()
                End If
            ElseIf CheckEdit1.Checked = True Then
                If uu.UserPower_GetList(txtuserid.Text.Trim, Nothing, Nothing, Nothing).Count = 0 Then
                    If uu.SystemUser_Update(us) And uu.UserPower_Add(ui) Then
                        MsgBox("修改成功")
                        Me.Close()
                    End If
                Else
                    If uu.SystemUser_Update(us) And uu.UserPower_Update(ui) Then
                        MsgBox("修改成功")
                        Me.Close()
                    End If
                End If
             
            End If
        Else
            If uu.SystemUser_GetList(Trim(txtuserid.Text.ToString), Nothing, Nothing).Count > 0 Then
                MsgBox("已有此用戶,請查詢!")
                Exit Sub
            End If
            us.U_ID = txtuserid.Text.ToString
            us.U_Name = txtusername.Text.ToString
            us.U_PassWord = txtuserpsw.Text.ToString
            us.DPT_ID = PopDPT.EditValue
            us.U_KeyImage = ImageToByte(pPhoto.Image)

            ui.UserID = txtuserid.Text.ToString
            ui.UserName = GridLookUpEdit1.Text
            ui.UserRank = ComboBoxEdit1.Text
            ui.DepID = GridLookUpEdit1.EditValue
            ui.UserType = ComboBoxEdit2.EditValue
            If CheckEdit1.Checked = False Then
                If uu.SystemUser_Add(us) Then
                    MsgBox("添加成功")
                    Me.Close()
                End If
            ElseIf CheckEdit1.Checked = True Then
                If uu.SystemUser_Add(us) And uu.UserPower_Add(ui) Then
                    MsgBox("添加成功")
                    txtuserid.Focus()
                    Me.Close()
                End If
            End If

        End If
    End Sub

    Private Sub frmUseradd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dpm As New DepartmentControler
        dpm.GetDepartmentModule(tv1)

        GridLookUpEdit1.Properties.DataSource = pc.DepFac_GetList(Nothing, Nothing, Nothing, Nothing)
        GridLookUpEdit1.Properties.DisplayMember = "DepName"
        GridLookUpEdit1.Properties.ValueMember = "DepID"

        If Edit = False Then

            Label1.Text = "添加用戶"
            txtuserid.Enabled = True
            txtuserid.Text = ""
            txtusername.Text = ""
            txtuserpsw.Text = ""
            GridLookUpEdit1.EditValue = ""
            ComboBoxEdit1.EditValue = ""
            pPhoto.Image = Nothing

        Else

            Label1.Text = "修改用戶"
            txtuserid.Text = tempValue
            tempValue = ""
            GridLookUpEdit1.EditValue = ""
            ComboBoxEdit1.EditValue = ""
            txtuserid.Enabled = False
            If loadedit(txtuserid.Text) = False Then Me.Close()

        End If

        If CheckEdit1.Checked = True Then
            Me.Height = 460
        Else
            Me.Height = 332
        End If

    End Sub
    Function loadedit(ByVal uid As String) As Boolean
        On Error Resume Next

        us = uu.SystemUser_Get(uid)
        If us Is Nothing Then
            loadedit = False
            Exit Function
        End If
        txtusername.Text = us.U_Name
        txtuserpsw.Text = us.U_PassWord
        PopDPT.EditValue = us.DPT_ID
        pPhoto.Image = ByteToImage(us.U_KeyImage)

        If Edit = True Then
            up = uu.UserPower_GetList(uid, Nothing, Nothing, Nothing)
            GridLookUpEdit1.EditValue = up(0).DepID
            ComboBoxEdit1.Text = up(0).UserRank
            ComboBoxEdit2.EditValue = up(0).UserType
        End If
        loadedit = True
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pPhoto.Image = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        Dim ofd As New OpenFileDialog
        ofd.Filter = "圖片文件(*.jpg,*.gif,*.bmp,*.png)|*.jpg;*.gif;*.bmp;*.png"
        ofd.ShowDialog()
        If ofd.FileName.ToString = "" Then Exit Sub
        fs = New IO.FileStream(ofd.FileName.ToString, IO.FileMode.Open, IO.FileAccess.Read)
        pPhoto.Image = Image.FromFile(ofd.FileName.ToString)
    End Sub

    Private Sub CheckEdit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.Click
        If CheckEdit1.Checked = True Then
            Me.Height = 332
        Else
            Me.Height = 460
        End If

    End Sub

    Private Sub tv1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tv1.DoubleClick
        'tv1.Nodes(0).Expand()

        'If strInCompany = "1001" Then
        '    tv1.Nodes(0).Nodes(0).ExpandAll()
        'ElseIf strInCompany = "1002" Then
        '    tv1.Nodes(0).Nodes(1).ExpandAll()
        'Else
        '    tv1.Nodes(0).Nodes(2).ExpandAll()
        'End If

        PopDPT.EditValue = tv1.SelectedNode.Tag

        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub

    Private Sub tv1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tv1.GotFocus
        On Error Resume Next

        tv1.Nodes(0).Expand()
        If strInCompany = "1001" Then
            tv1.Nodes(0).Nodes(0).Expand()
        ElseIf strInCompany = "1002" Then
            tv1.Nodes(0).Nodes(1).Expand()
        Else
            tv1.Nodes(0).Nodes(2).Expand()
        End If


    End Sub
End Class
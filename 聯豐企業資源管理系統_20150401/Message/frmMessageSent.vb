Imports LFERP.Library.MessageMain
Imports LFERP.SystemManager.SystemUser

Public Class frmMessageSent

    Private Sub frmMessageSent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim mt As New MessageMainControl
        Dim mc As New MessageMainInfo


        Select Case tempValue


            Case "新增"                     '此處是在其他模塊引用此頁面的時候才是“新增”，新發一個信息沒有處理
                Dim li As ListViewItem
                li = ListView2.Items.Add(tempValue3, 0)
                li.SubItems.Add(tempValue4)
                li.SubItems.Add(tempValue5)
                li.SubItems.Add(tempValue6)



            Case "回復"
                loadedit(tempValue2)
                ListView1.Items.Clear()
                mc = mt.MessageMain_Get(tempValue2)

                Dim li As ListViewItem
                li = ListView1.Items.Add(mc.MS_FromName)
                li.SubItems.Add(mc.MS_From)

            Case "全部回復"
                loadedit(tempValue2)
            Case "轉寄"
                loadedit(tempValue2)
                ListView1.Items.Clear()
            Case "草稿"
                Label2.Text = tempValue2
                loaddraft(tempValue2)

        End Select

        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
        tempValue4 = ""
        tempValue5 = ""
    End Sub

    Sub loaddraft(ByVal tt As String)
        On Error Resume Next
        Dim mt As New MessageMainControl
        Dim mc As New MessageMainInfo
        Dim dlist As New List(Of MessageMainInfo)
        mc = mt.MessageMain_Get(tt)
        dlist = mt.Attachment_GetList(tt)
        If mc Is Nothing Then
            Exit Sub
        Else

            TextBox1.Text = mc.MS_Subject

            Dim i, n As Integer
            Dim arr(n) As String

            Dim smc As New SystemUserController
            Dim smi As New SystemUserInfo
            Dim li As ListViewItem
            ListView1.Items.Clear()

            arr = Split(mc.MS_To, ",")
            n = Len(Replace(mc.MS_To, ",", "," & "*")) - Len(mc.MS_To)
            For i = 0 To n
                smi = smc.SystemUser_Get(arr(i))
                li = ListView1.Items.Add(smi.U_Name)
                li.SubItems.Add(smi.U_ID)
            Next

            RichTextBox1.Text = mc.MS_Content

            If dlist.Count = 0 Then Exit Sub
            For i = 0 To dlist.Count - 1
                Dim li1 As ListViewItem
                li = ListView2.Items.Add(dlist(i).MS_AttachName, 0)
                li.SubItems.Add(dlist(i).MS_DanJuID)
                li.SubItems.Add(dlist(i).MS_ModuleID)
                li.SubItems.Add(dlist(i).MS_SendType)
            Next

        End If
    End Sub

    Sub loadedit(ByVal tt As String)
        On Error Resume Next
        Dim mt As New MessageMainControl
        Dim mc As New MessageMainInfo
        mc = mt.MessageMain_Get(tt)
        If mc Is Nothing Then

            Exit Sub

        Else

            TextBox1.Text = "RE:" & mc.MS_Subject

            Dim i, n As Integer
            Dim arr(n) As String
            Dim strname As String
            Dim smc As New SystemUserController
            Dim smi As New SystemUserInfo
            Dim li As ListViewItem
            ListView1.Items.Clear()

            strname = Chr(13) & "--------------------------------------------------------------------------------------------"
            strname = strname & Chr(13) & "寄件者:  " & mc.MS_FromName & Chr(13) & "收件者:  "

            arr = Split(mc.MS_To, ",")
            n = Len(Replace(mc.MS_To, ",", "," & "*")) - Len(mc.MS_To)

            For i = 0 To n
                smi = smc.SystemUser_Get(arr(i))

                li = ListView1.Items.Add(smi.U_Name)

                strname = strname & smi.U_Name & ","
                li.SubItems.Add(smi.U_ID)

            Next

            strname = strname & Chr(13) & "主旨:      " & mc.MS_Subject & Chr(13) & "日期:      " & mc.MS_SendDate & Chr(13) & " " & Chr(13) & mc.MS_Content
            RichTextBox1.Text = strname

        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim i As Integer
        Dim LI As ListViewItem
        Dim fr As New frmMsgUserSelect
        fr.ShowDialog()



        For i = 0 To fr.MsgUserrray.GetUpperBound(0)
            If fr.MsgUserrray(i, 0) Is Nothing Then

            Else
                LI = ListView1.Items.Add(fr.MsgUserrray(i, 0))
                LI.SubItems.Add(fr.MsgUserrray(i, 1))
            End If


        Next

    End Sub

    Function GetMsg_ID() As String
        '生成新pS
        Dim mt As New MessageMainControl
        Dim mc As New MessageMainInfo
        mc = mt.MessageMain_Get(Nothing)

        If mc Is Nothing Then
            GetMsg_ID = "M0000000001"
        Else
            GetMsg_ID = "M" & Mid((CInt(Mid(mc.MS_ID, 2)) + 10000000001), 2)
        End If

    End Function

    Private Sub msgsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msgsend.Click

        Dim mt As New MessageMainControl
        Dim mc As New MessageMainInfo

        If ListView1.Items.Count = 0 Then
            MsgBox("請選擇收件者")
            Exit Sub
        End If

        Dim i As Integer
        Dim str As String
        str = ""
        For i = 0 To ListView1.Items.Count - 1
            str = str & ListView1.Items(i).SubItems(1).Text & ","
        Next
        mc.MS_From = InUserID
        mc.MS_Priority = 0

        mc.MS_Attachment = 0
        mc.MS_Subject = TextBox1.Text
        mc.MS_To = str
        mc.MS_SendDate = Now
        mc.MS_Content = RichTextBox1.Text

        mc.MS_Read = 1
        mc.MS_TypeID = "1003"   '寄件備份
        mc.MS_InUserID = InUserID
        If Label2.Text <> "MS_ID" Then
            mc.MS_ID = Label2.Text
            If ListView2.Items.Count <> 0 Then
                mc.MS_Attachment = 1
                mc.MS_AttachID = 1
                mc.MS_ModuleID = ListView2.Items(0).SubItems(2).Text
                mc.MS_DanJuID = ListView2.Items(0).SubItems(1).Text
                mc.MS_AttachName = ListView2.Items(0).Text
                mc.MS_SendType = ListView2.Items(0).SubItems(3).Text
                mt.Attachment_Update(mc)
            Else
                mt.Attachment_Delete(mc.MS_ID, "1")
            End If

            mt.MessageMain_Update(mc)
        Else

            mc.MS_ID = GetMsg_ID()

            If ListView2.Items.Count <> 0 Then
                mc.MS_Attachment = 1
                mc.MS_AttachID = 1
                mc.MS_ModuleID = ListView2.Items(0).SubItems(2).Text
                mc.MS_DanJuID = ListView2.Items(0).SubItems(1).Text
                mc.MS_AttachName = ListView2.Items(0).Text
                mc.MS_SendType = ListView2.Items(0).SubItems(3).Text
                mt.Attachment_add(mc)
            End If
            mt.MessageMain_add(mc)
        End If

        mc.MS_Read = 0
        mc.MS_TypeID = "1001"   '收件匣

        For i = 0 To ListView1.Items.Count - 1
            mc.MS_InUserID = ListView1.Items(i).SubItems(1).Text
            mc.MS_ID = GetMsg_ID()
            If ListView2.Items.Count <> 0 Then
                mc.MS_Attachment = 1
                mc.MS_AttachID = 1
                mc.MS_ModuleID = ListView2.Items(0).SubItems(2).Text
                mc.MS_DanJuID = ListView2.Items(0).SubItems(1).Text
                mc.MS_AttachName = ListView2.Items(0).Text
                mc.MS_SendType = ListView2.Items(0).SubItems(3).Text
                mt.Attachment_add(mc)

            End If

            If mt.MessageMain_add(mc) = False Then
                MsgBox("發送失敗" & ListView1.Items(i).Text)
                Exit Sub
            End If
        Next

        Me.Close()
    End Sub

    Private Sub msgsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msgsave.Click
        Dim mt As New MessageMainControl
        Dim mc As New MessageMainInfo

        Dim i As Integer
        Dim str As String
        str = ""
        For i = 0 To ListView1.Items.Count - 1
            str = str & ListView1.Items(i).SubItems(1).Text & ","
        Next
        mc.MS_From = InUserID
        mc.MS_Priority = 0
        mc.MS_Read = 0
        mc.MS_Attachment = 0
        mc.MS_Subject = TextBox1.Text
        mc.MS_To = str
        mc.MS_SendDate = Nothing
        mc.MS_Content = RichTextBox1.Text

        mc.MS_Read = 1
        mc.MS_TypeID = "1002"
        mc.MS_InUserID = InUserID

        If Label2.Text <> "MS_ID" Then
            mc.MS_ID = Label2.Text

            If ListView2.Items.Count <> 0 Then
                mc.MS_Attachment = 1
                mc.MS_AttachID = 1
                mc.MS_ModuleID = ListView2.Items(0).SubItems(2).Text
                mc.MS_DanJuID = ListView2.Items(0).SubItems(1).Text
                mc.MS_AttachName = ListView2.Items(0).Text
                mc.MS_SendType = ListView2.Items(0).SubItems(3).Text
                mt.Attachment_Update(mc)
            Else
                mt.Attachment_Delete(mc.MS_ID, "1")
            End If


            mt.MessageMain_Update(mc)
        Else
            mc.MS_ID = GetMsg_ID()

            If ListView2.Items.Count <> 0 Then
                mc.MS_Attachment = 1
                mc.MS_AttachID = 1
                mc.MS_ModuleID = ListView2.Items(0).SubItems(2).Text
                mc.MS_DanJuID = ListView2.Items(0).SubItems(1).Text
                mc.MS_AttachName = ListView2.Items(0).Text
                mc.MS_SendType = ListView2.Items(0).SubItems(3).Text
                mt.Attachment_add(mc)
            End If

            mt.MessageMain_add(mc)
        End If

        Me.Close()

    End Sub

    Private Sub ListView1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyUp

        If e.KeyCode = Keys.Delete Then
            If ListView1.SelectedItems.Count = 0 Then
                Exit Sub
            Else
                Dim litem As ListViewItem
                For Each litem In ListView1.SelectedItems
                    ListView1.Items.Remove(litem)
                Next


            End If
        End If

    End Sub




    Private Sub StripCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StripCopy.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub StripPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StripPaste.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub StripCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StripCut.Click
        RichTextBox1.Cut()
    End Sub
End Class
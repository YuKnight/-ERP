Imports LFERP.Library.MessageMain
Imports LFERP.SystemManager.SystemUser
Imports LFERP.Library.Purchase
Imports LFERP.SystemManager
Imports LFERP.Library.Purchase.Change

Public Class frmMessageRead

    Private Sub frmMessageRead_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        Dim mc As New MessageMainControl
        Dim mt As New MessageMainInfo

        Dim dlist As New List(Of MessageMainInfo)
        mt = mc.MessageMain_Get(tempValue2)

        dlist = mc.Attachment_GetList(tempValue2)



        tempValue2 = ""
        MsgID.Text = mt.MS_ID
        TextBox2.Text = mt.MS_FromName
        RichTextBox1.Text = mt.MS_Content
        TextBox1.Text = mt.MS_Subject

        Dim i, n As Integer
        Dim arr(n) As String
        Dim strname As String
        Dim smc As New SystemUserController
        Dim smi As New SystemUserInfo
        Dim li2 As ListViewItem



        strname = ""
        arr = Split(mt.MS_To, ",")
        n = Len(Replace(mt.MS_To, ",", "," & "*")) - Len(mt.MS_To)
        For i = 0 To n
            smi = smc.SystemUser_Get(arr(i))
            li2 = ListView1.Items.Add(smi.U_Name)
        Next

        If dlist.Count = 0 Then Exit Sub
        For i = 0 To dlist.Count - 1

            If IsDBNull(dlist(i).MS_DanJuID) = False Then
                Dim li As ListViewItem
                li = ListView2.Items.Add(dlist(i).MS_AttachName, 0)
                li.SubItems.Add(dlist(i).MS_DanJuID)
                li.SubItems.Add(dlist(i).MS_ModuleID)
                li.SubItems.Add(dlist(i).MS_SendType)
            End If
        Next


    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        On Error Resume Next
        Dim fr As frmMessageSent
        tempValue = "確"
        tempValue2 = MsgID.Text
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMessageSent Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmMessageSent
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub


    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        On Error Resume Next

        Dim fr As frmMessageSent
        tempValue = "场確"
        tempValue2 = MsgID.Text
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMessageSent Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmMessageSent
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()





    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        On Error Resume Next
        Dim fr As frmMessageSent
        tempValue = "锣盚"
        tempValue2 = MsgID.Text
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmMessageSent Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New frmMessageSent
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub ListView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick
        On Error Resume Next
        If ListView2.Items.Count = 0 Then Exit Sub
        ' MsgBox(ListView2.SelectedItems(0).SubItems(2).Text)



        Select Case ListView2.SelectedItems(0).SubItems(2).Text
            Case "4001"

                If ListView2.SelectedItems(0).SubItems(3).Text = "琩" Then


                    Dim fr As frmQuotation
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmQuotation Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next

                    tempValue2 = "琩"
                    tempValue = ListView2.SelectedItems(0).SubItems(1).Text
                    fr = New frmQuotation
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Normal

                    fr.Show()



                ElseIf ListView2.SelectedItems(0).SubItems(3).Text = "场糵" Then

                    If LoadPermission("4001", "场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If

                    Dim qc As New Quotation.QuotationController
                    Dim qi As New Quotation.QuotationInfo
                    qi = qc.Quotation_Get(ListView2.SelectedItems(0).SubItems(1).Text)
                    If IsDBNull(qi.Q_AccCheck) = True Or qi.Q_AccCheck = False Then

                        Dim fr As frmQuotation
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmQuotation Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next
                        tempValue2 = "场糵"
                        tempValue = ListView2.SelectedItems(0).SubItems(1).Text
                        fr = New frmQuotation
                        fr.MdiParent = MDIMain

                        fr.WindowState = FormWindowState.Normal
                        fr.Show()
                    Else
                        MsgBox("虫砆穦璸场糵ぃす砛巨")
                        Exit Sub
                    End If

                ElseIf ListView2.SelectedItems(0).SubItems(3).Text = "穦璸场糵" Then

                    If LoadPermission("4001", "穦璸场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If


                    Dim qc As New Quotation.QuotationController
                    Dim qi As New List(Of Quotation.QuotationInfo)
                    Dim QQcheck As New Boolean
                    Dim i As Integer
                    QQcheck = False
                    qi = qc.Quotation_Getlist(ListView2.SelectedItems(0).SubItems(1).Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
                    For i = 0 To qi.Count - 1
                        If qi(i).Q_Check = True Then
                            QQcheck = True
                        End If
                    Next

                    If QQcheck = True Then
                        Dim fr As frmQuotation
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmQuotation Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next
                        tempValue2 = "穦璸场糵"

                        fr = New frmQuotation
                        fr.MdiParent = MDIMain
                        tempValue = ListView2.SelectedItems(0).SubItems(1).Text

                        fr.WindowState = FormWindowState.Normal
                        fr.Show()
                    Else
                        MsgBox("虫ゼ竒筁场糵ぃす砛巨")
                        Exit Sub
                    End If


                End If


            Case "4002"
                If ListView2.SelectedItems(0).SubItems(3).Text = "琩" Then

                    Dim fr As frmPurchase
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmPurchase Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next

                    tempValue2 = "琩"
                    tempValue = ListView2.SelectedItems(0).SubItems(1).Text
                    fr = New frmPurchase
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()


                ElseIf ListView2.SelectedItems(0).SubItems(3).Text = "场糵" Then

                    If LoadPermission("4002", "场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If


                    Dim pc As New Purchase.PurchaseMainController
                    Dim pi As New Purchase.PurchaseMainInfo
                    pi = pc.PurchaseMain_Get(ListView2.SelectedItems(0).SubItems(1).Text)
                    If pi.PM_AccountCheck = False Or IsDBNull(pi.PM_AccountCheck) = True Then

                        Dim fr As frmPurchase
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmPurchase Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next
                        tempValue2 = "场糵"

                        fr = New frmPurchase
                        fr.MdiParent = MDIMain
                        tempValue = ListView2.SelectedItems(0).SubItems(1).Text

                        fr.WindowState = FormWindowState.Maximized
                        fr.Show()
                    Else
                        MsgBox("虫砆穦璸场糵ぃす砛巨")
                        Exit Sub
                    End If

                ElseIf ListView2.SelectedItems(0).SubItems(3).Text = "穦璸场糵" Then

                    If LoadPermission("4002", "穦璸场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If


                    Dim pc As New Purchase.PurchaseMainController
                    Dim pi As New Purchase.PurchaseMainInfo
                    pi = pc.PurchaseMain_Get(ListView2.SelectedItems(0).SubItems(1).Text)
                    If pi.PM_Check = True Then

                        Dim fr As frmPurchase
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmPurchase Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next

                        tempValue2 = "穦璸场糵"
                        tempValue = ListView2.SelectedItems(0).SubItems(1).Text

                        fr = New frmPurchase
                        fr.MdiParent = MDIMain
                        fr.WindowState = FormWindowState.Maximized
                        fr.Show()
                    Else
                        MsgBox("虫ゼ竒筁场糵ぃす砛巨")
                        Exit Sub
                    End If
                End If

            Case "4008"
                If ListView2.SelectedItems(0).SubItems(3).Text = "琩" Then

                    Dim fr As frmPurchase
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmPurchase Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next

                    tempValue2 = "琩"
                    tempValue = ListView2.SelectedItems(0).SubItems(1).Text
                    fr = New frmPurchase
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()


                ElseIf ListView2.SelectedItems(0).SubItems(3).Text = "场糵" Then

                    If LoadPermission("4008", "场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If


                    Dim pc As New Purchase.PurchaseMainController
                    Dim pi As New Purchase.PurchaseMainInfo
                    pi = pc.PurchaseMain_Get(ListView2.SelectedItems(0).SubItems(1).Text)
                    If pi.PM_AccountCheck = False Or IsDBNull(pi.PM_AccountCheck) = True Then

                        Dim fr As frmPurchase
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmPurchase Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next
                        tempValue2 = "场糵"

                        fr = New frmPurchase
                        fr.MdiParent = MDIMain
                        tempValue = ListView2.SelectedItems(0).SubItems(1).Text

                        fr.WindowState = FormWindowState.Maximized
                        fr.Show()
                    Else
                        MsgBox("虫砆穦璸场糵ぃす砛巨")
                        Exit Sub
                    End If

                ElseIf ListView2.SelectedItems(0).SubItems(3).Text = "穦璸场糵" Then

                    If LoadPermission("4008", "穦璸场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If


                    Dim pc As New Purchase.PurchaseMainController
                    Dim pi As New Purchase.PurchaseMainInfo
                    pi = pc.PurchaseMain_Get(ListView2.SelectedItems(0).SubItems(1).Text)
                    If pi.PM_Check = True Then

                        Dim fr As frmPurchase
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmPurchase Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next

                        tempValue2 = "穦璸场糵"
                        tempValue = ListView2.SelectedItems(0).SubItems(1).Text

                        fr = New frmPurchase
                        fr.MdiParent = MDIMain
                        fr.WindowState = FormWindowState.Maximized
                        fr.Show()
                    Else
                        MsgBox("虫ゼ竒筁场糵ぃす砛巨")
                        Exit Sub
                    End If
                End If
            Case "4005"
                If ListView2.SelectedItems(0).SubItems(3).Text = "琩" Then

                    Dim fr As frmChange
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmChange Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next

                    tempValue = "琩"
                    tempValue3 = ListView2.SelectedItems(0).SubItems(1).Text
                    fr = New frmChange
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                ElseIf ListView2.SelectedItems(0).SubItems(3).Text = "场糵" Then

                    If LoadPermission("4005", "场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If

                    Dim ci1 As List(Of ChangeInfo)
                    Dim cc As New ChangeControl
                    ci1 = cc.Change_GetList(ListView2.SelectedItems(0).SubItems(1).Text, Nothing, Nothing, Nothing)
                    If ci1(0).C_Check = True Then
                        MsgBox("虫砆糵ぃす砛巨")
                        Exit Sub
                    Else
                        Dim fr As frmChange
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmChange Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next
                        tempValue = "糵"

                        fr = New frmChange
                        fr.MdiParent = MDIMain
                        tempValue3 = ListView2.SelectedItems(0).SubItems(1).Text
                        fr.WindowState = FormWindowState.Maximized
                        fr.Show()

                    End If

                End If
        End Select

    End Sub

    Function LoadPermission(ByVal MODELid As String, ByVal CheckType As String) As Boolean
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        LoadPermission = False

        Select Case MODELid

            Case "4001"

                If CheckType = "场糵" Then
                    pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400104")
                    If pmwiL.Count > 0 Then
                        If pmwiL.Item(0).PMWS_Value = "琌" Then LoadPermission = True
                    End If
                ElseIf CheckType = "穦璸场糵" Then
                    pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400105")
                    If pmwiL.Count > 0 Then
                        If pmwiL.Item(0).PMWS_Value = "琌" Then LoadPermission = True
                    End If
                End If


            Case "4002"
                If CheckType = "场糵" Then
                    pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400204")
                    If pmwiL.Count > 0 Then
                        If pmwiL.Item(0).PMWS_Value = "琌" Then LoadPermission = True
                    End If
                ElseIf CheckType = "穦璸场糵" Then
                    pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400205")
                    If pmwiL.Count > 0 Then
                        If pmwiL.Item(0).PMWS_Value = "琌" Then LoadPermission = True
                    End If
                End If
            Case "4008"
                If CheckType = "场糵" Then
                    pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400804")
                    If pmwiL.Count > 0 Then
                        If pmwiL.Item(0).PMWS_Value = "琌" Then LoadPermission = True
                    End If
                ElseIf CheckType = "穦璸场糵" Then
                    pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400805")
                    If pmwiL.Count > 0 Then
                        If pmwiL.Item(0).PMWS_Value = "琌" Then LoadPermission = True
                    End If
                End If
            Case "4005"
                If CheckType = "场糵" Then
                    pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "400504")
                    If pmwiL.Count > 0 Then
                        If pmwiL.Item(0).PMWS_Value = "琌" Then LoadPermission = True
                    End If
                End If
        End Select

    End Function


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
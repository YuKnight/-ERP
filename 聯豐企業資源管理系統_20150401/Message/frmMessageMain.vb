Imports LFERP.Library.MessageMain
Imports LFERP.SystemManager.SystemUser
Imports LFERP.SystemManager
Imports LFERP.Library.Purchase
Imports LFERP.Library.Purchase.Change


Public Class frmMessageMain

    Private Sub gridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridControl1.Click


        Dim mc As New MessageMainControl
        Dim mt As New MessageMainInfo
        Dim dlist As New List(Of MessageMainInfo)
        Dim i As Integer

        If gridView1.RowCount = 0 Then Exit Sub
        mt = mc.MessageMain_Get(gridView1.GetFocusedRowCellValue("MS_ID").ToString)
        RichTextBox1.Text = mt.MS_Content


        dlist = mc.Attachment_GetList(gridView1.GetFocusedRowCellValue("MS_ID").ToString)
        ListView1.Items.Clear()
        If dlist.Count = 0 Then Exit Sub
        For i = 0 To dlist.Count - 1

            If IsDBNull(dlist(i).MS_DanJuID) = False Then
                Dim li As ListViewItem
                li = ListView1.Items.Add(dlist(i).MS_AttachName, 0)
                li.SubItems.Add(dlist(i).MS_DanJuID)
                li.SubItems.Add(dlist(i).MS_ModuleID)
                li.SubItems.Add(dlist(i).MS_SendType)
            End If
        Next




    End Sub

    Private Sub gridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridControl1.DoubleClick

        On Error Resume Next
        Dim mc As New MessageMainControl
        Dim mt As New MessageMainInfo
        If gridView1.RowCount = 0 Then Exit Sub

        If tv1.SelectedNode.Tag = "1002" Then

            Dim fr1 As frmMessageSent

            tempValue = "絑"
            tempValue2 = gridView1.GetFocusedRowCellValue("MS_ID").ToString


            For Each fr1 In MDIMain.MdiChildren
                If TypeOf fr1 Is frmMessageSent Then
                    fr1.Activate()
                    Exit Sub
                End If
            Next

            fr1 = New frmMessageSent
            fr1.MdiParent = MDIMain
            fr1.WindowState = FormWindowState.Maximized
            fr1.Show()


        Else


            tempValue2 = gridView1.GetFocusedRowCellValue("MS_ID").ToString

            mt = mc.MessageMain_Get(gridView1.GetFocusedRowCellValue("MS_ID").ToString)
            RichTextBox1.Text = mt.MS_Content
            If mt.MS_Read = "0" Then
                mt.MS_Read = "1"
                mt.MS_ReceivedDate = Now
                mc.MessageMain_Update(mt)
                gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "MS_Read", "1")
            End If


            Dim fr As frmMessageRead

            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmMessageRead Then
                    fr.Activate()
                    Exit Sub
                End If
            Next

            fr = New frmMessageRead
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()

        End If

    End Sub

    Private Sub frmMessageMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim mc As New MessageModuleControl
        Dim mt As New MessageMainControl

        mc.MessageModule_LoadToTree(tv1)

        gridControl1.DataSource = mt.MessageMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, "1001", InUserID)

        Dim snodes As TreeNode
        snodes = tv1.Nodes(0).Nodes.Item(0)

        tv1.SelectedNode = snodes

    End Sub




    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect

        Dim mt As New MessageMainControl
        If e.Node.Level = 1 Then
            gridControl1.DataSource = mt.MessageMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, InUserID)
        End If

        Select Case e.Node.Tag

            Case "1002"
                EditDraft.Enabled = True
                MsgReply.Enabled = False
                MsgZF.Enabled = False
                ReplyAll.Enabled = False
            Case Else

                EditDraft.Enabled = False
                MsgReply.Enabled = True
                MsgZF.Enabled = True
                ReplyAll.Enabled = True


        End Select

    End Sub



    Private Sub tv1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tv1.NodeMouseClick
        Dim mt As New MessageMainControl
        If e.Node.Level = 1 Then
            gridControl1.DataSource = mt.MessageMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, tv1.SelectedNode.Tag, InUserID)
        End If

    End Sub



    Private Sub MsgAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgAdd.Click

        On Error Resume Next

        Dim fr As frmMessageSent
        tempValue = ""
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

    Private Sub MsgReply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgReply.Click
        On Error Resume Next
        Dim fr As frmMessageSent

        If gridView1.RowCount = 0 Then Exit Sub
        tempValue = "確"
        tempValue2 = gridView1.GetFocusedRowCellValue("MS_ID").ToString

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

    Private Sub MsgZF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsgZF.Click

        On Error Resume Next
        Dim fr As frmMessageSent
        If gridView1.RowCount = 0 Then Exit Sub
        tempValue = "锣盚"
        tempValue2 = gridView1.GetFocusedRowCellValue("MS_ID").ToString

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


    Private Sub ReceiveSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiveSend.Click
        Dim mt As New MessageMainControl
        'Dim dlist As New List(Of MessageMainInfo)
        '' tv1.SelectedNode.Tag = "1001"

        'dlist = mt.MessageMain_Getlist(Nothing, Nothing, "0", Nothing, InUserID, "1001")
        'MsgBox(dlist.Count)
        'MsgBox(tv1.Nodes.Item)
        'If dlist.Count <> 0 Then
        '    tv1.Nodes.Item("1001").Text = "Μン (" & dlist.Count & ")"

        'Else
        '    tv1.Nodes.Item("1001").Text = "Μン"
        'End If
        If tv1.SelectedNode.Tag = "1001" Then
            gridControl1.DataSource = mt.MessageMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, "1001", InUserID)

        End If

    End Sub


    Private Sub ReplyAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplyAll.Click

        On Error Resume Next
        Dim fr As frmMessageSent
        If gridView1.RowCount = 0 Then Exit Sub
        tempValue = "场確"
        tempValue2 = gridView1.GetFocusedRowCellValue("MS_ID").ToString


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




    Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged

        On Error Resume Next
        Dim mc As New MessageMainControl
        Dim mt As New MessageMainInfo

        mt = mc.MessageMain_Get(gridView1.GetRowCellValue(e.PrevFocusedRowHandle, "MS_ID").ToString)
        If mt.MS_Read = "0" Then
            mt.MS_Read = "1"
            mt.MS_ReceivedDate = Now
            mc.MessageMain_Update(mt)
            gridView1.SetRowCellValue(e.PrevFocusedRowHandle, "MS_Read", "1")
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim mt As New MessageMainControl
        'If tv1.SelectedNode.Tag = "1001" Then
        '    gridControl1.DataSource = mt.MessageMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, "1001", InUserID)
        'End If
    End Sub

    Private Sub EditDraft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditDraft.Click
        On Error Resume Next
        Dim fr As frmMessageSent
        If gridView1.RowCount = 0 Then Exit Sub
        tempValue = "絑"
        tempValue2 = gridView1.GetFocusedRowCellValue("MS_ID").ToString


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

    Private Sub popmsgdel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popmsgdel.Click
        Dim mc As New MessageMainControl
        Dim mt As New MessageMainInfo

        Select Case tv1.SelectedNode.Tag

            Case "1004"
                If MsgBox("絋粄璶ッ埃硂兵癘魁", MsgBoxStyle.YesNo + vbQuestion, "矗ボ") = MsgBoxResult.Yes Then
                    mc.MessageMain_Delete(gridView1.GetFocusedRowCellValue("MS_ID").ToString)
                    mc.Attachment_Delete(gridView1.GetFocusedRowCellValue("MS_ID").ToString, Nothing)
                    gridView1.DeleteSelectedRows()
                End If

            Case Else
                If MsgBox("絋粄璶ッ埃硂兵癘魁", MsgBoxStyle.YesNo + vbQuestion, "矗ボ") = MsgBoxResult.Yes Then
                    mt = mc.MessageMain_Get(gridView1.GetFocusedRowCellValue("MS_ID").ToString)
                    mt.MS_TypeID = "1004"
                    mc.MessageMain_Update(mt)
                    gridView1.DeleteSelectedRows()
                End If
        End Select

    End Sub



    Private Sub ListView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        On Error Resume Next
        If ListView1.Items.Count = 0 Then Exit Sub
        ' MsgBox(ListView1.SelectedItems(0).SubItems(2).Text)


        If tv1.SelectedNode.Tag <> "1001" Then Exit Sub

        Select Case ListView1.SelectedItems(0).SubItems(2).Text
            Case "4001"

                If ListView1.SelectedItems(0).SubItems(3).Text = "琩" Then


                    Dim fr As frmQuotation
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmQuotation Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next

                    tempValue2 = "琩"
                    tempValue = ListView1.SelectedItems(0).SubItems(1).Text
                    fr = New frmQuotation
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Normal

                    fr.Show()



                ElseIf ListView1.SelectedItems(0).SubItems(3).Text = "场糵" Then

                    If LoadPermission("4001", "场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If

                    Dim qc As New Quotation.QuotationController
                    Dim qi As New Quotation.QuotationInfo
                    qi = qc.Quotation_Get(ListView1.SelectedItems(0).SubItems(1).Text)
                    If IsDBNull(qi.Q_AccCheck) = True Or qi.Q_AccCheck = False Then

                        Dim fr As frmQuotation
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmQuotation Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next
                        tempValue2 = "场糵"
                        tempValue = ListView1.SelectedItems(0).SubItems(1).Text
                        fr = New frmQuotation
                        fr.MdiParent = MDIMain

                        fr.WindowState = FormWindowState.Normal
                        fr.Show()
                    Else
                        MsgBox("虫砆穦璸场糵ぃす砛巨")
                        Exit Sub
                    End If

                ElseIf ListView1.SelectedItems(0).SubItems(3).Text = "穦璸场糵" Then

                    If LoadPermission("4001", "穦璸场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If

                    Dim qc As New Quotation.QuotationController
                    Dim qi As New List(Of Quotation.QuotationInfo)
                    Dim QQcheck As New Boolean
                    Dim i As Integer
                    QQcheck = False
                    qi = qc.Quotation_Getlist(ListView1.SelectedItems(0).SubItems(1).Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
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
                        tempValue = ListView1.SelectedItems(0).SubItems(1).Text

                        fr.WindowState = FormWindowState.Normal
                        fr.Show()
                    Else
                        MsgBox("虫ゼ竒筁场糵ぃす砛巨")
                        Exit Sub
                    End If


                End If


            Case "4002"
                If ListView1.SelectedItems(0).SubItems(3).Text = "琩" Then

                    Dim fr As frmPurchase
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmPurchase Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next

                    tempValue2 = "琩"
                    tempValue = ListView1.SelectedItems(0).SubItems(1).Text
                    fr = New frmPurchase
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()


                ElseIf ListView1.SelectedItems(0).SubItems(3).Text = "场糵" Then

                    If LoadPermission("4002", "场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If


                    Dim pc As New Purchase.PurchaseMainController
                    Dim pi As New Purchase.PurchaseMainInfo
                    pi = pc.PurchaseMain_Get(ListView1.SelectedItems(0).SubItems(1).Text)
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
                        tempValue = ListView1.SelectedItems(0).SubItems(1).Text

                        fr.WindowState = FormWindowState.Maximized
                        fr.Show()
                    Else
                        MsgBox("虫砆穦璸场糵ぃす砛巨")
                        Exit Sub
                    End If

                ElseIf ListView1.SelectedItems(0).SubItems(3).Text = "穦璸场糵" Then

                    If LoadPermission("4002", "穦璸场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If


                    Dim pc As New Purchase.PurchaseMainController
                    Dim pi As New Purchase.PurchaseMainInfo
                    pi = pc.PurchaseMain_Get(ListView1.SelectedItems(0).SubItems(1).Text)
                    If pi.PM_Check = True Then

                        Dim fr As frmPurchase
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmPurchase Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next

                        tempValue2 = "穦璸场糵"
                        tempValue = ListView1.SelectedItems(0).SubItems(1).Text

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
                If ListView1.SelectedItems(0).SubItems(3).Text = "琩" Then

                    Dim fr As frmPurchase
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmPurchase Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next

                    tempValue2 = "琩"
                    tempValue = ListView1.SelectedItems(0).SubItems(1).Text
                    fr = New frmPurchase
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()


                ElseIf ListView1.SelectedItems(0).SubItems(3).Text = "场糵" Then

                    If LoadPermission("4008", "场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If


                    Dim pc As New Purchase.PurchaseMainController
                    Dim pi As New Purchase.PurchaseMainInfo
                    pi = pc.PurchaseMain_Get(ListView1.SelectedItems(0).SubItems(1).Text)
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
                        tempValue = ListView1.SelectedItems(0).SubItems(1).Text

                        fr.WindowState = FormWindowState.Maximized
                        fr.Show()
                    Else
                        MsgBox("虫砆穦璸场糵ぃす砛巨")
                        Exit Sub
                    End If

                ElseIf ListView1.SelectedItems(0).SubItems(3).Text = "穦璸场糵" Then

                    If LoadPermission("4008", "穦璸场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If


                    Dim pc As New Purchase.PurchaseMainController
                    Dim pi As New Purchase.PurchaseMainInfo
                    pi = pc.PurchaseMain_Get(ListView1.SelectedItems(0).SubItems(1).Text)
                    If pi.PM_Check = True Then

                        Dim fr As frmPurchase
                        For Each fr In MDIMain.MdiChildren
                            If TypeOf fr Is frmPurchase Then
                                fr.Activate()
                                Exit Sub
                            End If
                        Next

                        tempValue2 = "穦璸场糵"
                        tempValue = ListView1.SelectedItems(0).SubItems(1).Text

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
                If ListView1.SelectedItems(0).SubItems(3).Text = "琩" Then

                    Dim fr As frmChange
                    For Each fr In MDIMain.MdiChildren
                        If TypeOf fr Is frmChange Then
                            fr.Activate()
                            Exit Sub
                        End If
                    Next

                    tempValue = "琩"
                    tempValue3 = ListView1.SelectedItems(0).SubItems(1).Text
                    fr = New frmChange
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                ElseIf ListView1.SelectedItems(0).SubItems(3).Text = "场糵" Then

                    If LoadPermission("4005", "场糵") = False Then
                        MsgBox("⊿Τ糵舦")
                        Exit Sub
                    End If

                    Dim ci1 As List(Of ChangeInfo)
                    Dim cc As New ChangeControl
                    ci1 = cc.Change_GetList(ListView1.SelectedItems(0).SubItems(1).Text, Nothing, Nothing, Nothing)
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
                        tempValue3 = ListView1.SelectedItems(0).SubItems(1).Text
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


    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class
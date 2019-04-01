Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareOut

Public Class WareInventoryWarningMsg

    Private Sub WareInventoryWarningMsg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        On Error Resume Next

        Dim w As Integer, h As Integer
        w = Screen.PrimaryScreen.Bounds.Width
        h = Screen.PrimaryScreen.Bounds.Height
        Me.Location = New Point(w - Me.Width, h - Me.Height - 30)
        Label2.Text = "以下倉庫存在庫存數量小於安全庫存物料," + vbCrLf + "    請及時查看！"


        Dim arr(50) As String
        Dim j, js As Integer

        Dim wic As New WareInventory.WareInventoryMTController
        Dim wil As New List(Of WareInventory.WareInventoryInfo)
        Dim Ls As String = ""
        Dim i As Integer
        wil = wic.WareInventory_GetList2(Nothing, Nothing)

        Me.ListBoxMsg.Items.Clear()

        If wil.Count > 0 Then
            For i = 0 To wil.Count - 1
                If Mid(wil(i).WH_ID, 1, 3) = "W03" Or Mid(wil(i).WH_ID, 1, 3) = "W06" Or Mid(wil(i).WH_ID, 1, 3) = "W30" Then
                    If Ls <> wil(i).WH_ID Then
                        Ls = wil(i).WH_ID
                        ListBoxMsg.Items.Add(wil(i).WH_ID & "-" & wil(i).WH_Name)
                    End If
                End If
            Next
        End If



        WareWarningMsgShowBZ = "N"

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        WareWarningMsgShowBZ = "N"

        Me.Close()
    End Sub

    Private Sub ListBoxMsg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBoxMsg.DoubleClick
        If ListBoxMsg.SelectedItem.ToString <> "" Then
        Else
            Exit Sub
        End If


        Dim strWHID As String
        strWHID = ListBoxMsg.SelectedItem.ToString()
        strWHID = Mid(strWHID, 1, InStr(strWHID, "-", CompareMethod.Text) - 1)

        tempValue = strWHID

        Dim fr As New Form
        'For Each fr In Me.MdiChildren
        '    If TypeOf fr Is frmWareInventoryMainNew Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next
        'fr = New frmWareInventoryMainNew
        'fr.MdiParent = MDIMain
        'fr.WindowState = FormWindowState.Maximized
        'fr.Show()

        fr = frmWareInventoryMainNew
        fr.Show()
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        Exit Sub


    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        WareWarningMsgShowBZ = "Y"

        Me.Close()
    End Sub

    Private Sub ListBoxMsg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxMsg.SelectedIndexChanged

    End Sub
End Class
Imports LFERP.SystemManager
Public Class frmKnifeSetting

    Private Sub ButtonWhite_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWhite.Click
        Dim fr As New Form
        fr = New frmWhiteUser
        CreatePage(fr, "")   ''''白名單
        my_tabpage.ItemSize = New Size(0, 1)
    End Sub

    Private Sub ButtonMCodeGroup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMCodeGroup.Click
        Dim fr As New Form
        fr = New frmKnifeTypeGroupMain
        CreatePage(fr, "")   '''' 刀具分組
        my_tabpage.ItemSize = New Size(0, 1)
    End Sub

    Private Sub ButtonReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReport.Click
        Me.ContextMenuStrip1.Show(sender, 0, sender.height)
        Dim i As Integer
        If my_tabpage.TabCount = 0 Then
            Exit Sub
        End If
        For i = 0 To my_tabpage.TabCount - 1
            my_tabpage.TabPages.RemoveAt(0)
        Next
    End Sub

    Private Sub CreatePage(ByVal form As Form, ByVal as_text As String)
        'If checkpage(my_tabpage, as_text) Then
        '    Exit Sub
        'End If
        Dim i As Integer
        If my_tabpage.TabCount = 0 Then
        Else
            For i = 0 To my_tabpage.TabCount - 1
                my_tabpage.TabPages.RemoveAt(0)
            Next
        End If
        my_tabpage.TabPages.Add(as_text)
        my_tabpage.SelectTab(my_tabpage.TabPages.Count - 1)
        form.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        form.TopLevel = False
        form.Size = my_tabpage.Size
        form.Show()
        form.Parent = my_tabpage.SelectedTab

    End Sub

    ''' <summary>
    ''' 檢查是否已經存在頁面page
    ''' </summary>
    ''' <param name="tab"></param>
    ''' <param name="tabName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckTabPage(ByVal tab As System.Windows.Forms.TabControl, ByVal tabName As String) As Boolean
        Dim i As Integer
        If tab.TabCount = 0 Then Exit Function
        For i = 0 To tab.TabCount - 1
            If tab.TabPages(i).Text = tabName Then
                tab.SelectedIndex = i
                Return True
            End If
        Next
        Return False
    End Function


    Private Sub ContextMenuStrip1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click, ToolStripMenuItem19.Click, ToolStripMenuItem18.Click, ToolStripMenuItem17.Click, ToolStripMenuItem16.Click, ToolStripMenuItem15.Click, ToolStripMenuItem14.Click, ToolStripMenuItem13.Click, ToolStripMenuItem12.Click, ToolStripMenuItem08.Click, ToolStripMenuItem05.Click, ToolStripMenuItem03.Click, ToolStripMenuItem02.Click, ToolStripMenuItem01.Click, ToolStripMenuItem00.Click, ToolStripMenuItem04.Click
        Dim TempreportName As String = sender.tag


        If TempreportName = "TimeNoReturn" Then
            Dim frmTheTimeNoReturnShow As New frmTheTimeNoReturn
            frmTheTimeNoReturnShow.ShowDialog()
            Exit Sub
        End If

        '-------------------------------------------
        Dim fr As New frmTheRequirement
        fr.reportName = TempreportName
        fr.reportChiniseName = sender.text

        fr.ShowDialog()

    End Sub

    Private Sub frmKnifeSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadUserPower()
    End Sub

    Sub LoadUserPower()
        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510901")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ButtonWhite.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510902")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ButtonMCodeGroup.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "510903")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then ButtonReport.Enabled = True
        End If
    End Sub
End Class
Imports System.Windows.Forms
Imports LFERP.SystemManager
'Imports LFERP.ERPSafe
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.IO
Imports System.Data
Imports LFERP.TwainLib
Imports LFERP.GdiPlusLib
Imports LFERP.Library.MessageMain

Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.SystemManager.UserLoginLog

Public Class MDIMain
    Implements IMessageFilter
    Dim mcs As New PermissionModule

    Private msgfilter As Boolean
    Dim bmi As BITMAPINFOHEADER
    'Private tw As Twain 
    Private picnumber As Integer = 0
    Dim strtemp2 As String = Application.StartupPath & "\vb6\ReadIC.exe "
    Dim CommPath As String = Application.StartupPath & "\ReadComNew.txt "

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: 在此加入開啟檔案的程式碼。

        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: 在此加入程式碼，將表單目前的內容儲存成檔案。

        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' 使用 My.Computer.Clipboard 將選取的文字或影像插入剪貼簿
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' 使用 My.Computer.Clipboard 將選取的文字或影像插入剪貼簿
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        '使用 My.Computer.Clipboard.GetText() 或 My.Computer.Clipboard.GetData 從剪貼簿擷取資訊。

    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' 關閉父表單的所有子表單。

        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next

    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub LoadErpUser()
        '導入系統用戶權限及相關資料

        ErpUser.MaterialType = "10,20,30"
        ErpUser.SupplierType = "采購部,包裝部"
        ErpUser.WareHouseList = "'W01','W02'"

    End Sub

    Private Sub MDIMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'On Error Resume Next

        '刪除臨時目錄中的文件
        Dim a() As String = IO.Directory.GetFiles(Application.StartupPath & "\TempFile\")
        Dim i As Integer
        For Each a(i) In a
            '更改文件屬性為普通，如果為只讀時出錯，不許允刪除，然后關不掉資源

            File.SetAttributes(a(i), FileAttributes.Normal)
            File.Delete(a(i))
        Next
        Login.Close()
        'File.Delete(Application.StartupPath & "\TempFile\011.pdf")

    End Sub



    Private Sub MDIMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = Me.Text & "[" & strVer & "]"
        ToolStripStatusLabel2.Text = InUserID & "(" & UserName & ")"
        ToolStripStatusLabel7.Text = Now
        LoadErpUser()

        ' mcs.GetPermissionModule(tvModule)
        mcs.GetPermissionModuleUser(tvModule, InUserID)

        Timer1.Start()

        ''讀取串口路徑-----------------------------

        If IO.File.Exists(CommPath) = True Then
            Dim sw As New StreamReader(CommPath)
            Do While sw.Peek <> -1
                ReadComm = Val(sw.ReadLine)
            Loop
            sw.Close()
        End If

        ' MsgBox(ReadComm)

        If ReadComm <= 0 Then
            ReadComm = 1
        End If

        '  MsgBox(ReadComm)
        '-------------------------------------------

    End Sub

    '@ 2012/8/21  添加 按回車鍵加載窗體
    Private Sub tvModule_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tvModule.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadModule(tvModule.SelectedNode.Tag)
        End If
    End Sub

    

    Private Sub tvModule_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tvModule.MouseDoubleClick

        LoadModule(tvModule.SelectedNode.Tag)

    End Sub

    Private Sub ViewtvModule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewtvModule.Click

        If tvModule.Visible = True Then
            tvModule.Visible = False
        Else
            tvModule.Visible = True

        End If
    End Sub



    Private Sub 模塊管理ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 模塊管理ToolStripMenuItem.Click
        Dim MyFrm As New FrmPermissionModule
        MyFrm.Show()
    End Sub

    Private Sub ToolStripStatusLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel5.Click

    End Sub

    Private Sub 測試窗口ToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles 測試窗口ToolStripMenuItem.Click
        'Dim Myfrm As New Test
        'Myfrm.Show()

    End Sub

    Public Sub New()

        ' 此為 Windows Form 設計工具所需的呼叫。

        InitializeComponent()
        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。

      

    End Sub

#Region "處理掃描過程"
    Private Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
        Dim cmd As TwainLib.TwainCommand = tw.PassMessage(m)
        If cmd = TwainLib.TwainCommand.[Not] Then
            Return False
        End If

        Select Case cmd
            Case TwainLib.TwainCommand.CloseRequest
                If True Then
                    EndingScan()
                    tw.CloseSrc()
                    Exit Select
                End If
            Case TwainLib.TwainCommand.CloseOk
                If True Then
                    EndingScan()
                    tw.CloseSrc()
                    Exit Select
                End If
            Case TwainLib.TwainCommand.DeviceEvent
                If True Then
                    Exit Select
                End If
            Case TwainLib.TwainCommand.TransferReady
                If True Then
                    Dim pics As ArrayList = tw.TransferPictures()
                    EndingScan()
                    tw.CloseSrc()
                    picnumber += 1
                    For i As Integer = 0 To pics.Count - 1
                        Dim img As IntPtr = DirectCast(pics(i), IntPtr)
                        Dim newpic As New PicForm(img)
                        newpic.MdiParent = Me
                        'Dim picnum As Integer = i + 1
                        'newpic.Text = ("ScanPass" & picnumber.ToString() & "_Pic") + picnum.ToString()
                        'newpic.Show()
                    Next
                    Exit Select
                End If
        End Select

        Return True
    End Function

    Public Sub ScanFile()
        If Not msgfilter Then
            Me.Enabled = False
            'Me.Enabled = True
            msgfilter = True
            Application.AddMessageFilter(Me)
        End If
        tw.Acquire()
    End Sub
    Public Sub EndingScan()
        If msgfilter Then
            Application.RemoveMessageFilter(Me)
            msgfilter = False
            Me.Enabled = True
            Me.Activate()
        End If
    End Sub
    Public Sub SelectScan()
        tw.Selected()
    End Sub
#End Region


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim mc As New MessageMainControl
        Dim mt As New MessageMainInfo
        Dim dlist As New List(Of MessageMainInfo)
        dlist = mc.MessageMain_Getlist(Nothing, Nothing, "0", Nothing, Nothing, "1001", InUserID) 'Then 'Is Nothing Then
        'MsgBox(dlist.Count)
        If dlist.Count = 0 Then
            '  Exit Sub
        Else
            tempValue = dlist.Count
            frmMessageReminding.Show()
        End If


        
        If WareWarningMsgShowBZ <> "N" Then
            Dim pmws As New PermissionModuleWarrantSubController
            Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

            pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "505008")
            If pmwiL.Count <= 0 Then
                Exit Sub
                WareWarningMsgShowBZ = "N"
            End If

            If pmwiL.Item(0).PMWS_Value = "是" Then
            Else
                Exit Sub
                WareWarningMsgShowBZ = "N"
            End If

            Dim wh As New WareHouseController
            Dim wic As New WareInventory.WareInventoryMTController
            If wic.WareInventory_GetList2(Nothing, Nothing).Count > 0 Then
                WareInventoryWarningMsg.Show()
                Exit Sub
            Else
                WareWarningMsgShowBZ = "Y"
            End If
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Shell(strtemp2, AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub MDIMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("要退出程序嗎?", vbYesNo + vbQuestion, "退出程序") = vbNo Then e.Cancel = True
    End Sub

    Private Sub CustomizeDeskToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomizeDeskToolStripMenuItem.Click
        On Error Resume Next
        Dim fr As CustomizeDest
        For Each fr In Me.MdiChildren
            If TypeOf fr Is CustomizeDest Then
                fr.Activate()
                Exit Sub
            End If
        Next

        fr = New CustomizeDest
        fr.MdiParent = Me
        fr.Show()
    End Sub

    Private Sub tvModule_DrawNode(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawTreeNodeEventArgs) Handles tvModule.DrawNode
        'On Error Resume Next
        'Dim fr As CustomizeDest
        'For Each fr In Me.MdiChildren
        '    If TypeOf fr Is CustomizeDest Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next

        'fr = New CustomizeDest
        'fr.MdiParent = Me
        'fr.Show()
        'fr.test.Text = e.Node.Text

    End Sub

    Private Sub MDIMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Dim Wmi As New System.Management.ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapterConfiguration")
        Dim ulc As New UserLoginLogController
        Dim uli As New UserLoginLogInfo

        uli.U_ID = InUserID
        uli.UL_InTime = strUserLoginTime
        uli.UL_ExitTime = Format(Now, "yyyy/MM/dd HH:mm:ss")

        For Each WmiObj As Management.ManagementObject In Wmi.Get
            If CBool(WmiObj("IPEnabled")) Then
                uli.UL_Mac = Replace(WmiObj("MACAddress"), ":", "-")
                uli.UL_IP = WmiObj("IPAddress")(0)
            End If
        Next

        ulc.UserLoginLog_Add(uli)
    End Sub

    'AppDomain.CurrentDomain.ProcessExit 

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        frmOptions.ShowDialog()
    End Sub
End Class

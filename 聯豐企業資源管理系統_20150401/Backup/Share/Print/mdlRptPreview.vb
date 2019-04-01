Module mdlRptPreview
    ''' <summary>
    ''' 打印報表
    ''' </summary>
    ''' <param name="ds">數據源</param>
    ''' <param name="RptFileName">報表文件名(不要加路徑和后綴)如:test,如有下層目錄則為:testFile\test</param>
    ''' <param name="RptHeadName">報表窗口顯示名稱</param>
    ''' <param name="ShowPrint">是否顯示打印按鈕</param>
    ''' <param name="ShowExport">是否顯示輸出按鈕</param>
    ''' <remarks></remarks>
    Public Sub PreviewRPT(ByVal ds As DataSet, ByVal RptFileName As String, ByVal RptHeadName As String, ByVal ShowPrint As Boolean, ByVal ShowExport As Boolean)
        'On Error Resume Next
        RptHeadName = "預覽報表 - [ " & RptHeadName & " ]"
        Dim frTemp As New Form

        For Each frTemp In MDIMain.MdiChildren
            If TypeOf frTemp Is frmRptPreview Then
                If frTemp.Text = RptHeadName Then
                    frTemp.Activate()
                    Exit Sub
                End If
            End If
        Next
        frTemp = Nothing


        Dim fr As New frmRptPreview
        '調用報表
        Dim FilePath As String
        FilePath = Application.StartupPath & "\Report\" & RptFileName & ".rpt"
        fr.rptDoc.Load(FilePath)
        fr.rptDoc.SetDataSource(ds)
        fr.crView.ReportSource = fr.rptDoc
        fr.Text = RptHeadName
        '打印及輸出按鈕權限
        fr.crView.ShowPrintButton = ShowPrint
        fr.crView.ShowExportButton = ShowExport

        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub
    ''' <summary>
    ''' 打印報表
    ''' </summary>
    ''' <param name="ds">數據源</param>
    ''' <param name="RptFileName">報表文件名(不要加路徑和后綴)如:test,如有下層目錄則為:testFile\test</param>
    ''' <param name="RptHeadName">報表窗口顯示名稱</param>
    ''' <param name="ShowPrint">是否顯示打印按鈕</param>
    ''' <param name="ShowExport">是否顯示輸出按鈕</param>
    ''' <remarks></remarks>
    Public Sub PreviewRPT1(ByVal ds As DataSet, ByVal RptFileName As String, ByVal RptHeadName As String, ByVal str1 As String, ByVal str2 As String, ByVal ShowPrint As Boolean, ByVal ShowExport As Boolean)
        'On Error Resume Next
        RptHeadName = "預覽報表 - [ " & RptHeadName & " ]"
        Dim frTemp As New Form

        For Each frTemp In MDIMain.MdiChildren
            If TypeOf frTemp Is frmRptPreview Then
                If frTemp.Text = RptHeadName Then
                    frTemp.Activate()
                    Exit Sub
                End If
            End If
        Next
        frTemp = Nothing


        Dim fr As New frmRptPreview
        '調用報表
        Dim FilePath As String
        Dim DiscreteVal1 = New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim DiscreteVal2 = New CrystalDecisions.Shared.ParameterDiscreteValue
        DiscreteVal1.Value = str1
        DiscreteVal2.Value = str2

        FilePath = Application.StartupPath & "\Report\" & RptFileName & ".rpt"
        fr.rptDoc.Load(FilePath)
        fr.rptDoc.SetDataSource(ds)
        fr.crView.ReportSource = fr.rptDoc
        fr.crView.ParameterFieldInfo(0).AllowCustomValues = False
        fr.crView.ParameterFieldInfo(1).AllowCustomValues = False
        fr.crView.ParameterFieldInfo(0).CurrentValues.Add(DiscreteVal1)
        fr.crView.ParameterFieldInfo(1).CurrentValues.Add(DiscreteVal2)

        fr.Text = RptHeadName
        '打印及輸出按鈕權限
        fr.crView.ShowPrintButton = ShowPrint
        fr.crView.ShowExportButton = ShowExport

        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub
    'PreviewRPTDialog
    Public Sub PreviewRPTDialog(ByVal ds As DataSet, ByVal RptFileName As String, ByVal RptHeadName As String, ByVal ShowPrint As Boolean, ByVal ShowExport As Boolean)
        'On Error Resume Next
        RptHeadName = "預覽報表 - [ " & RptHeadName & " ]"
        Dim frTemp As New Form

        For Each frTemp In MDIMain.MdiChildren
            If TypeOf frTemp Is frmRptPreview Then
                If frTemp.Text = RptHeadName Then
                    frTemp.Activate()
                    Exit Sub
                End If
            End If
        Next
        frTemp = Nothing


        Dim fr As New frmRptPreview
        '調用報表
        Dim FilePath As String
        FilePath = Application.StartupPath & "\Report\" & RptFileName & ".rpt"
        fr.rptDoc.Load(FilePath)
        fr.rptDoc.SetDataSource(ds)
        fr.crView.ReportSource = fr.rptDoc
        fr.Text = RptHeadName
        '打印及輸出按鈕權限
        fr.crView.ShowPrintButton = ShowPrint
        fr.crView.ShowExportButton = ShowExport

        fr.FormBorderStyle = FormBorderStyle.FixedSingle
        fr.WindowState = FormWindowState.Maximized
        fr.ShowDialog()

    End Sub

    Public Sub PreviewRPTDialog1(ByVal ds As DataSet, ByVal RptFileName As String, ByVal RptHeadName As String, ByVal str1 As String, ByVal str2 As String, ByVal ShowPrint As Boolean, ByVal ShowExport As Boolean)
        'On Error Resume Next
        RptHeadName = "預覽報表 - [ " & RptHeadName & " ]"

        Dim fr As New frmRptPreview
        '調用報表
        Dim FilePath As String
        Dim DiscreteVal1 = New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim DiscreteVal2 = New CrystalDecisions.Shared.ParameterDiscreteValue
        DiscreteVal1.Value = str1
        DiscreteVal2.Value = str2

        FilePath = Application.StartupPath & "\Report\" & RptFileName & ".rpt"
        fr.rptDoc.Load(FilePath)
        fr.rptDoc.SetDataSource(ds)
        fr.crView.ReportSource = fr.rptDoc
        fr.crView.ParameterFieldInfo(0).AllowCustomValues = False
        fr.crView.ParameterFieldInfo(1).AllowCustomValues = False
        fr.crView.ParameterFieldInfo(0).CurrentValues.Add(DiscreteVal1)
        fr.crView.ParameterFieldInfo(1).CurrentValues.Add(DiscreteVal2)

        fr.Text = RptHeadName
        '打印及輸出按鈕權限
        fr.crView.ShowPrintButton = ShowPrint
        fr.crView.ShowExportButton = ShowExport

        fr.FormBorderStyle = FormBorderStyle.FixedSingle
        fr.WindowState = FormWindowState.Maximized
        fr.ShowDialog()

    End Sub

    Public Sub PreviewRPTDialog5(ByVal ds As DataSet, ByVal RptFileName As String, ByVal RptHeadName As String, ByVal str1 As String, ByVal str2 As String, ByVal str3 As String, ByVal str4 As String, ByVal str5 As String, ByVal str6 As String, ByVal ShowPrint As Boolean, ByVal ShowExport As Boolean)
        'On Error Resume Next
        RptHeadName = "預覽報表 - [ " & RptHeadName & " ]"

        Dim fr As New frmRptPreview
        '調用報表
        Dim FilePath As String
        Dim DiscreteVal1 = New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim DiscreteVal2 = New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim DiscreteVal3 = New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim DiscreteVal4 = New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim DiscreteVal5 = New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim DiscreteVal6 = New CrystalDecisions.Shared.ParameterDiscreteValue

        If str1 <> "" Then DiscreteVal1.Value = str1
        If str2 <> "" Then DiscreteVal2.Value = str2
        If str3 <> "" Then DiscreteVal1.Value = str3
        If str4 <> "" Then DiscreteVal2.Value = str4
        If str5 <> "" Then DiscreteVal1.Value = str5
        If str6 <> "" Then DiscreteVal2.Value = str6

        FilePath = Application.StartupPath & "\Report\" & RptFileName & ".rpt"
        fr.rptDoc.Load(FilePath)
        fr.rptDoc.SetDataSource(ds)
        fr.crView.ReportSource = fr.rptDoc

        If str1 <> "" Then fr.crView.ParameterFieldInfo(0).AllowCustomValues = False
        If str2 <> "" Then fr.crView.ParameterFieldInfo(1).AllowCustomValues = False
        If str3 <> "" Then fr.crView.ParameterFieldInfo(2).AllowCustomValues = False
        If str4 <> "" Then fr.crView.ParameterFieldInfo(3).AllowCustomValues = False
        If str5 <> "" Then fr.crView.ParameterFieldInfo(4).AllowCustomValues = False
        If str6 <> "" Then fr.crView.ParameterFieldInfo(5).AllowCustomValues = False

        If str1 <> "" Then fr.crView.ParameterFieldInfo(0).CurrentValues.Add(DiscreteVal1)
        If str2 <> "" Then fr.crView.ParameterFieldInfo(1).CurrentValues.Add(DiscreteVal2)
        If str3 <> "" Then fr.crView.ParameterFieldInfo(2).CurrentValues.Add(DiscreteVal3)
        If str4 <> "" Then fr.crView.ParameterFieldInfo(3).CurrentValues.Add(DiscreteVal4)
        If str5 <> "" Then fr.crView.ParameterFieldInfo(4).CurrentValues.Add(DiscreteVal5)
        If str6 <> "" Then fr.crView.ParameterFieldInfo(5).CurrentValues.Add(DiscreteVal6)


        fr.Text = RptHeadName
        '打印及輸出按鈕權限
        fr.crView.ShowPrintButton = ShowPrint
        fr.crView.ShowExportButton = ShowExport

        fr.FormBorderStyle = FormBorderStyle.FixedSingle
        fr.WindowState = FormWindowState.Maximized
        fr.ShowDialog()

    End Sub


    ''' <summary>
    ''' 導出。。暫時停用
    ''' </summary>
    ''' <param name="Orpt"></param>
    ''' <param name="FileName"></param>
    ''' <param name="FileType"></param>
    ''' <remarks></remarks>
    Public Sub ExportFile(ByVal Orpt As System.Object, ByVal FileName As String, ByVal FileType As Integer)
        Dim CrExportOptions As New CrystalDecisions.Shared.ExportOptions
        Dim crDiskFileDestinationOptions As New CrystalDecisions.Shared.DiskFileDestinationOptions

        Dim DiskOpts As CrystalDecisions.Shared.DiskFileDestinationOptions = New CrystalDecisions.Shared.DiskFileDestinationOptions
        'Dim excelFormatOpts As New ExcelFormatOptions

        CrExportOptions = Orpt.ExportOptions
        CrExportOptions.DestinationOptions = crDiskFileDestinationOptions

        Dim contenttype As String
        Select Case FileType
            Case 1
                CrExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                CrExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.Excel
                contenttype = "application/vnd.ms-excel"
                'FileName = FileName & ".xls"
            Case 2
                CrExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                CrExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
                contenttype = "application/pdf"
                'FileName = FileName & ".pdf"
            Case 3
                CrExportOptions.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
                CrExportOptions.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.WordForWindows
                contenttype = "application/msword"
                'FileName = FileName & ".doc"
        End Select
        crDiskFileDestinationOptions.DiskFileName = FileName
        Orpt.Export()

    End Sub

    Public Function SendEmail(ByVal Subject As String, ByVal ToEmail As String, ByVal Body As String, ByVal AttPath As String) As Boolean
        ''建立郵件
        'On Error Resume Next
        'Dim ol As New Microsoft.Office.Interop.Outlook.Application
        'Dim NewMessage As Object
        'Dim strBody As String
        'SendEmail = False

        '' Create a new MailItem
        'NewMessage = ol.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
        '' Embed a file into the new message
        ''strBody = " 你好!" & Chr(13) & "    這是" & Date & "生成的更新數據!" & Chr(13) & "請准備一張空白軟盤,然后將" _
        ''        & "附件保存到軟盤中，再使用AP系統更新!"
        'With NewMessage
        '    .Subject = Subject
        '    .To = ToEmail
        '    .Body = Body
        '    .Attachments.Add(AttPath)
        '    .ReadReceiptRequested = True   '是否要回復
        'End With
        '' Display the message
        'NewMessage.Display()
        'SendEmail = True
        'ol = Nothing
        'NewMessage = Nothing

    End Function
    Public Function ExportToPDF(ByVal ds As DataSet, ByVal RptFileName As String, ByVal ReportDoc As ReportDocument, ByVal PDFFileName As String) As Boolean

        Dim logOnInfo As New CrystalDecisions.Shared.TableLogOnInfo()
        Dim FileOPS As New CrystalDecisions.Shared.DiskFileDestinationOptions()
        Dim ExOPS As CrystalDecisions.Shared.ExportOptions
        '調用報表
        Dim FilePath As String
        FilePath = Application.StartupPath & "\Report\" & RptFileName & ".rpt"
        Try
            ReportDoc.Load(FilePath)
            ReportDoc.SetDataSource(ds)
            FileOPS.DiskFileName = PDFFileName
            ExOPS = ReportDoc.ExportOptions
            ExOPS.DestinationOptions = FileOPS
            ExOPS.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile
            ExOPS.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.PortableDocFormat
            ReportDoc.Export()
            Return True

        Catch

        End Try

        Return False
    End Function


    Public Sub PreviewRPTShow(ByVal ds As DataSet, ByVal RptFileName As String, ByVal RptHeadName As String, ByVal ShowPrint As Boolean, ByVal ShowExport As Boolean)
        'On Error Resume Next
        RptHeadName = "預覽報表 - [ " & RptHeadName & " ]"
        Dim frTemp As New Form

        For Each frTemp In MDIMain.MdiChildren
            If TypeOf frTemp Is frmRptPreview Then
                If frTemp.Text = RptHeadName Then
                    frTemp.Activate()
                    Exit Sub
                End If
            End If
        Next
        frTemp = Nothing


        Dim fr As New frmRptPreview
        '調用報表
        Dim FilePath As String
        FilePath = Application.StartupPath & "\Report\" & RptFileName & ".rpt"
        fr.rptDoc.Load(FilePath)
        fr.rptDoc.SetDataSource(ds)
        fr.crView.ReportSource = fr.rptDoc
        fr.Text = RptHeadName
        '打印及輸出按鈕權限
        fr.crView.ShowPrintButton = ShowPrint
        fr.crView.ShowExportButton = ShowExport

        fr.FormBorderStyle = FormBorderStyle.FixedSingle
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub

    Public Sub PreviewRPTShow1(ByVal ds As DataSet, ByVal RptFileName As String, ByVal RptHeadName As String, ByVal str1 As String, ByVal str2 As String, ByVal ShowPrint As Boolean, ByVal ShowExport As Boolean)
        'On Error Resume Next
        RptHeadName = "預覽報表 - [ " & RptHeadName & " ]"

        Dim fr As New frmRptPreview
        '調用報表
        Dim FilePath As String
        Dim DiscreteVal1 = New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim DiscreteVal2 = New CrystalDecisions.Shared.ParameterDiscreteValue
        DiscreteVal1.Value = str1
        DiscreteVal2.Value = str2

        FilePath = Application.StartupPath & "\Report\" & RptFileName & ".rpt"
        fr.rptDoc.Load(FilePath)
        fr.rptDoc.SetDataSource(ds)
        fr.crView.ReportSource = fr.rptDoc
        fr.crView.ParameterFieldInfo(0).AllowCustomValues = False
        fr.crView.ParameterFieldInfo(1).AllowCustomValues = False
        fr.crView.ParameterFieldInfo(0).CurrentValues.Add(DiscreteVal1)
        fr.crView.ParameterFieldInfo(1).CurrentValues.Add(DiscreteVal2)

        fr.Text = RptHeadName
        '打印及輸出按鈕權限
        fr.crView.ShowPrintButton = ShowPrint
        fr.crView.ShowExportButton = ShowExport

        fr.FormBorderStyle = FormBorderStyle.FixedSingle
        fr.WindowState = FormWindowState.Maximized
        fr.Show()

    End Sub



End Module

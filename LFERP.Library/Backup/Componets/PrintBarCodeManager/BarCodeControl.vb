Imports System.Net.FtpWebRequest
Imports System.Net.FtpStatusCode
Imports System.IO
Imports EncodeMy
Imports LFERP.Library.Barcode

Namespace LFERP.Library.BarCode

    Public Class BarCodeControl

        Public Const GENERIC_WRITE = &H40000000

        Public Const OPEN_EXISTING = 3

        Public Const FILE_SHARE_WRITE = &H2

        Dim hPort As Integer

        Public Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" ( _
            ByVal lpFileName As String, ByVal dwDesiredAccess As Integer, _
            ByVal dwShareMode As Integer, _
            <Runtime.InteropServices.MarshalAs(Runtime.InteropServices.UnmanagedType.Struct)> ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES, _
            ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer, _
            ByVal hTemplateFile As Integer) As Integer

        Public Declare Function CloseHandle Lib "kernel32" Alias "CloseHandle" (ByVal hObject As Integer) As Integer

        Dim retval As Integer
        Dim strLen As Integer
        Dim strBar As String


        <Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> Public Structure SECURITY_ATTRIBUTES

            Private nLength As Integer

            Private lpSecurityDescriptor As Integer

            Private bInheritHandle As Integer

        End Structure

        '小標籤(6*2)
        Sub PrintSBar(ByVal M_Code As String, ByVal M_Name As String, ByVal PrintPort As String)

            On Error Resume Next

            Dim SA As SECURITY_ATTRIBUTES

            Dim outFile As IO.FileStream
            Dim hPortP As IntPtr

            hPort = CreateFile(PrintPort, GENERIC_WRITE, FILE_SHARE_WRITE, SA, OPEN_EXISTING, 0, 0)

            hPortP = New IntPtr(hPort) 'convert Integer to IntPtr 

            outFile = New FileStream(hPortP, FileAccess.Write, False) 'Create FileStream using Handle 


            Dim fileWriter As New IO.StreamWriter(outFile, System.Text.Encoding.GetEncoding("GB2312"))

            strLen = M_Name.Length
            If strLen <= 3 Then
                strBar = "A200,5,0,8,1,1,N,"
            ElseIf strLen >= 4 And strLen <= 5 Then
                strBar = "A170,5,0,8,1,1,N,"
            ElseIf strLen >= 6 And strLen < 8 Then
                strBar = "A150,5,0,8,1,1,N,"
            ElseIf strLen >= 8 And strLen <= 9 Then
                strBar = "A130,5,0,8,1,1,N,"
            ElseIf strLen > 9 And strLen <= 11 Then
                strBar = "A100,5,0,8,1,1,N,"
            ElseIf strLen > 11 And strLen <= 14 Then
                strBar = "A80,5,0,8,1,1,N,"
            ElseIf strLen >= 15 And strLen <= 16 Then
                strBar = "A50,5,0,8,1,1,N,"
            Else
                strBar = "A20,5,0,8,1,1,N,"
            End If
            fileWriter.WriteLine(" ")
            fileWriter.WriteLine("N")

            fileWriter.Write(strBar)
            fileWriter.Write(Chr(34))
            fileWriter.Write(BIG5TOGB(ToSBC(M_Name)))   '名稱
            fileWriter.Write(Chr(34))
            fileWriter.Write(Chr(13))
            fileWriter.Write(Chr(10))

            fileWriter.Write("B100,45,0,1,2,2,60,B,")
            fileWriter.Write(Chr(34))
            fileWriter.Write(M_Code)   '條碼
            fileWriter.Write(Chr(34))
            fileWriter.Write(Chr(13))
            fileWriter.Write(Chr(10))

            fileWriter.WriteLine("P1")

            fileWriter.Flush()

            fileWriter.Close()

            outFile.Close()

            retval = CloseHandle(hPort)
        
        End Sub
        '大標籤---本地(6*4)---（主要應用QC抽檢）Zebra888-TT--2010/07/30
        Sub PrintQCLBar(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal OS_BatchID As String, ByVal WQS_Qty As String, ByVal A_AcceptanceNO As String, ByVal WQS_NO As String, ByVal PrintPort As String)
            Dim SA As SECURITY_ATTRIBUTES

            Dim outFile As IO.FileStream
            Dim hPortP As IntPtr

            hPort = CreateFile(PrintPort, GENERIC_WRITE, FILE_SHARE_WRITE, SA, OPEN_EXISTING, 0, 0)
            hPortP = New IntPtr(hPort) 'convert Integer to IntPtr 
            outFile = New FileStream(hPortP, FileAccess.Write, False) 'Create FileStream using Handle 

            Dim fileWriter As New IO.StreamWriter(outFile, System.Text.Encoding.GetEncoding("GB2312"))
            strLen = M_Name.Length

            If strLen <= 3 Then
                strBar = "A200,130,0,8,1,1,N,"
            ElseIf strLen >= 4 And strLen <= 5 Then
                strBar = "A170,130,0,8,1,1,N,"
            ElseIf strLen >= 6 And strLen < 8 Then
                strBar = "A150,130,0,8,1,1,N,"
            ElseIf strLen >= 8 And strLen <= 9 Then
                strBar = "A130,130,0,8,1,1,N,"
            ElseIf strLen > 9 And strLen <= 11 Then
                strBar = "A100,130,0,8,1,1,N,"
            ElseIf strLen > 11 And strLen <= 14 Then
                strBar = "A80,130,0,8,1,1,N,"
            ElseIf strLen >= 15 And strLen <= 16 Then
                strBar = "A50,130,0,8,1,1,N,"
            Else
                strBar = "A20,130,0,8,1,1,N,"
            End If
            fileWriter.WriteLine(" ")
            fileWriter.WriteLine("N")

            fileWriter.Write("A150,5,0,8,1,1,N,")
            fileWriter.Write(Chr(34))
            fileWriter.Write(BIG5TOGB("QC抽檢專用"))   '標題
            fileWriter.Write(Chr(34))
            fileWriter.Write(Chr(13))
            fileWriter.Write(Chr(10))

            fileWriter.Write(strBar)
            fileWriter.Write(Chr(34))
            fileWriter.Write(BIG5TOGB(ToSBC(M_Name)))   '名稱
            fileWriter.Write(Chr(34))
            fileWriter.Write(Chr(13))
            fileWriter.Write(Chr(10))

            fileWriter.Write("B100,45,0,1,2,2,60,B,")
            fileWriter.Write(Chr(34))
            fileWriter.Write(M_Code)   '條碼
            fileWriter.Write(Chr(34))
            fileWriter.Write(Chr(13))
            fileWriter.Write(Chr(10))

            fileWriter.Write("A100,170,0,3,1,1,N,")
            fileWriter.Write(Chr(34))
            fileWriter.Write(BIG5TOGB("Gauge : " & M_Gauge))
            fileWriter.Write(Chr(13))   '規格
            fileWriter.Write(Chr(10))

            fileWriter.Write("A100,200,0,3,1,1,N,")
            fileWriter.Write(Chr(34))
            fileWriter.Write(BIG5TOGB("Batch : " & OS_BatchID))
            fileWriter.Write(Chr(13))   '批次
            fileWriter.Write(Chr(10))

            fileWriter.Write("A100,230,0,3,1,1,N,")
            fileWriter.Write(Chr(34))
            fileWriter.Write(BIG5TOGB("Qty   : " & WQS_Qty))
            fileWriter.Write(Chr(13))  '數量
            fileWriter.Write(Chr(10))

            fileWriter.Write("A100,260,0,3,1,1,N,")
            fileWriter.Write(Chr(34))
            fileWriter.Write(BIG5TOGB("ANO   : " & A_AcceptanceNO))
            fileWriter.Write(Chr(13))  '驗收單號
            fileWriter.Write(Chr(10))

            fileWriter.Write("A100,290,0,3,1,1,N,")
            fileWriter.Write(Chr(34))
            fileWriter.Write(BIG5TOGB("QNO   : " & WQS_NO))
            fileWriter.Write(Chr(13))  '抽檢單號
            fileWriter.Write(Chr(10))

            fileWriter.WriteLine("P1")
            fileWriter.Flush()
            fileWriter.Close()
            outFile.Close()
            retval = CloseHandle(hPort)

        End Sub
        '大標籤---本地(6*4)---（Zebra ZM400）
        Sub PrintLBar(ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal LongString As String, ByVal PrintDate As String, ByVal PrintPort As String)

            CreateLPTFile(PrintPort, StringTxt(M_Code, M_Name, M_Gauge, LongString, PrintDate))

        End Sub
        '大標籤---網絡(6*4) -----通過ftp.ext進行批處理上傳至服務器打印
        Sub PrintNetBar(ByVal ftpname As String)
            Dim psi As New System.Diagnostics.ProcessStartInfo
            Dim ftpFileName As String
            psi.FileName = "ftp.exe"
            psi.RedirectStandardInput = False
            psi.RedirectStandardOutput = True
            psi.UseShellExecute = False
            ftpFileName = ftpname
            psi.Arguments = "-s:" & ftpFileName
            Dim proc As New System.Diagnostics.Process
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            proc = System.Diagnostics.Process.Start(psi)

            'Wait process
            proc.WaitForExit()
            Console.WriteLine(proc.StandardOutput)
            Console.ReadLine()
        End Sub
        Function BIG5TOGB(ByVal BIG5Code As String) As String
            '轉碼繁體轉簡體
            Dim gb As New EncodeRobert
            BIG5TOGB = gb.SCTCConvert(ConvertType.Traditional, ConvertType.Simplified, BIG5Code)
        End Function

        Public Function ToSBC(ByVal input As String) As String
            '半角轉全角： 
            Dim c As Char() = input.ToCharArray()
            For i As Integer = 0 To c.Length - 1
                'If c(i) = ChrW(32) Then
                '    c(i) = CChar(ChrW(12288))
                '    Continue For
                'End If
                If c(i) = ChrW(34) Then
                    c(i) = CChar(ChrW((CInt(AscW(c(i))) + 65248)))
                End If
            Next
            Return New String(c)
        End Function

        Private Sub CreateLPTFile(ByVal PrintPort As String, ByVal str As String)
            Try
                Dim SA As SECURITY_ATTRIBUTES
                Dim hPort As Integer = CreateFile(PrintPort, GENERIC_WRITE, FILE_SHARE_WRITE, SA, OPEN_EXISTING, 0, 0)
                'Dim hPort As Integer = Open()
                Dim hPortP As System.IntPtr = New IntPtr(hPort)
                Dim fs As FileStream
                fs = New FileStream(hPortP, FileAccess.Write, False)
                Dim writer As New StreamWriter(fs)
                writer.AutoFlush = False
                writer.WriteLine(str)
                writer.Flush()
                writer.Close()
                fs.Close()
                CloseHandle(hPort)
            Catch
                'statusBar1.Panels[0].Text = "I/O錯誤:請檢查打印機是否打開連接!" + eIO.Message; 
                MsgBox("請檢查打印機是否已連接！")
            End Try
        End Sub

        '分隔規格字符串
        Private Shared Function deal(ByVal str As String) As List(Of String)
            Dim len As Integer = str.Length
            Dim result As New List(Of String)()
            Dim resultStr As Char() = New Char(35) {}
            Dim max As Integer = 36
            Dim num As Integer = 0
            Dim index As Integer = 0

            For i As Integer = 0 To len - 1
                Dim ch As Char = str(i)
                Dim code As Integer = CInt(AscW(ch))
                Dim half As Integer = 0
                If code > 0 AndAlso code <= 255 Then
                    half = 1
                ElseIf code > 255 Then
                    half = 2
                End If

                If (num + half) > max Then
                    Dim s As String = String.Empty
                    s = New String(resultStr)
                    s = s.TrimEnd(ControlChars.NullChar)
                    result.Add(s)
                    resultStr = New Char(35) {}
                    num = 0
                    index = 0
                End If

                resultStr(index) = ch
                index += 1
                num += half
            Next

            Dim s1 As String = New String(resultStr)
            s1 = s1.TrimEnd(ControlChars.NullChar)
            result.Add(s1)
            Return result
        End Function
        Function StringTxt(ByVal M_code As String, ByVal M_name As String, ByVal M_gauge As String, ByVal LongString As String, ByVal Printdate As String) As String
            Dim bc As New BarCode.StringTxtInfo

            Dim str As List(Of String)
            str = deal(M_gauge)

            Dim sCmd As String = ""
            Dim i As Integer
            Dim cmd1 As String = ""
            Dim cmd2 As String = ""
            Dim cmd3 As String = ""
            Dim cmd4 As String = ""
            Dim cmd5 As String = ""

            sCmd = "^XA" & Chr(13)
            sCmd += "^MD" & "30" & Chr(13)
            sCmd += "^LH" & "10" & "," & "10" & Chr(13)
            sCmd += "^FO" & "05" & "," & "10" & Chr(13)
            sCmd += "^GB" & "670" & "," & "400" & "," & "2^FS" & Chr(13)
            sCmd += "^FO" & "05" & "," & "10" & "^GB" & "330" & "," & "150" & "," & "2^FS" & Chr(13)
            sCmd += "^FO" & "335" & "," & "10" & "^GB" & "340" & "," & "150" & "," & "2^FS" & Chr(13)
            sCmd += "^ACN" & "," & "18" & "," & "10" & Chr(13)
            sCmd += "^BY" & "1.4" & "," & "3" & "," & "100" & Chr(13)
            sCmd += "^BCN" & "," & "100" & "," & "Y" & "," & "N" & "," & "N" & Chr(13)
            sCmd += "^FO" & "60" & "," & "25" & "," & "^FD" & M_code & "^FS" & Chr(13)
            bc.Text = M_name
            bc.Convert()
            sCmd += bc.Convert.ToString & Chr(13)
            Dim l As Integer
            l = bc.Text.Length
            If l = 1 Then
                sCmd += "^FO" & "445" & "," + "70" & "^XGOUTSTR01,1,1^FS" & Chr(13)
            ElseIf l = 2 Or 3 Or 4 Then
                sCmd += "^FO" & "430" & "," + "70" & "^XGOUTSTR01,1,1^FS" & Chr(13)
            ElseIf l = 5 Then
                sCmd += "^FO" & "395" & "," + "70" & "^XGOUTSTR01,1,1^FS" & Chr(13)
            ElseIf l = 6 Then
                sCmd += "^FO" & "385" & "," + "70" & "^XGOUTSTR01,1,1^FS" & Chr(13)
            ElseIf l = 7 Then
                sCmd += "^FO" & "375" & "," + "70" & "^XGOUTSTR01,1,1^FS" & Chr(13)
            ElseIf l = 8 Then
                sCmd += "^FO" & "365" & "," + "70" & "^XGOUTSTR01,1,1^FS" & Chr(13)
            ElseIf l = 9 Then
                sCmd += "^FO" & "355" & "," + "70" & "^XGOUTSTR01,1,1^FS" & Chr(13)
            Else
                sCmd += "^FO" & "335" & "," + "70" & "^XGOUTSTR01,1,1^FS" & Chr(13)
            End If
            For i = 0 To str.Count - 1

                bc.Text = str.Item(i).ToString()
                bc.Convert()
                cmd1 = bc.Convert.ToString

                sCmd += cmd1 & Chr(13)
                sCmd += "^FO" & "0" & "," + (45 * i + 180).ToString & "^XGOUTSTR01,1,1^FS" & Chr(13)

            Next
            sCmd += "^ACN" & "," & "18" & "," & "10" & Chr(13)
            sCmd += "^FO" & "10" & "," + "425" & "^FDLuenFung Watch Case Factory Ltd.^FS" & Chr(13)

            sCmd += "^ACN" & "," & "18" & "," & "10" & Chr(13)
            sCmd += "^FO" & "420" & "," + "425" & "^FDPrintDate:^FS" & Chr(13)
            sCmd += "^ACN" & "," & "18" & "," & "10" & Chr(13)
            sCmd += "^FO550,425" & "^FD" & Printdate & "^FS" & Chr(13)
            If LongString = Nothing Then
                '不列印
                sCmd += "^XZ"
            Else
                '列印
                Dim str1 As List(Of String)
                str1 = deal(LongString)
                Dim j As Integer
                'For j = 0 To str1.Count - 1
                '    bc.Text = str1.Item(j).ToString
                '    bc.Convert()
                '    cmd4 = bc.Convert.ToString
                '    sCmd += "^ACN" & "," & "18" & "," & "10" & Chr(13)
                '    sCmd += cmd4 & Chr(13)
                '    sCmd += "^FO" & "0" & "," + (45 * (str.Count + j) + 180).ToString & "^XGOUTSTR01,1,1^FS^FS" & Chr(13)
                'Next
                For j = 0 To str1.Count - 1
                    cmd4 = str1.Item(j).ToString
                    sCmd += "^MD" & "30" & Chr(13)
                    sCmd += "^ACN" & "," & "20" & "," & "12" & Chr(13)
                    sCmd += "^FO" & "20" & "," + (45 * str.Count + j * 30 + 180).ToString & "^FD" & "Unit:" & "^FS" & Chr(13)
                    sCmd += "^ACN" & "," & "20" & "," & "12" & Chr(13)
                    sCmd += "^FO" & "80" & "," + (45 * str.Count + j * 30 + 180).ToString & "^FD" & cmd4 & "^FS" & Chr(13)
                Next

                sCmd += "^XZ"
            End If
            Return sCmd
        End Function

        '　PrinterType為打印機選擇，TransMethod為本地或網絡選擇
        Public Sub PrintBarCode(ByVal PrinterType As String, ByVal TransMethod As String, ByVal PrintPort As String, ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal LongString As String, ByVal PrintDate As String, ByVal FtpName As String)
            If PrinterType = "ZM400" Then
                If TransMethod = "本地" Then
                    PrintLBar(M_Code, M_Name, M_Gauge, LongString, PrintDate, PrintPort)
                Else
                    PrintNetBar(FtpName)
                End If

            ElseIf PrinterType = "888-TT" Then
                PrintSBar(M_Code, M_Name, PrintPort)
            End If

        End Sub
        Sub PrintSBar1(ByVal M_Code As String, ByVal M_Name As String, ByVal PrintPort As String, ByVal InQty As Integer)
            Try

         
                Dim SA As SECURITY_ATTRIBUTES

                Dim outFile As IO.FileStream
                Dim hPortP As IntPtr

                hPort = CreateFile(PrintPort, GENERIC_WRITE, FILE_SHARE_WRITE, SA, OPEN_EXISTING, 0, 0)

                hPortP = New IntPtr(hPort) 'convert Integer to IntPtr 

                outFile = New FileStream(hPortP, FileAccess.Write, False) 'Create FileStream using Handle 

                Dim fileWriter As New IO.StreamWriter(outFile, System.Text.Encoding.GetEncoding("GB2312"))

                strLen = M_Name.Length
                If strLen <= 3 Then
                    strBar = "A200,5,0,8,1,1,N,"
                ElseIf strLen >= 4 And strLen <= 5 Then
                    strBar = "A170,5,0,8,1,1,N,"
                ElseIf strLen >= 6 And strLen < 8 Then
                    strBar = "A150,5,0,8,1,1,N,"
                ElseIf strLen >= 8 And strLen <= 9 Then
                    strBar = "A130,5,0,8,1,1,N,"
                ElseIf strLen > 9 And strLen <= 11 Then
                    strBar = "A100,5,0,8,1,1,N,"
                ElseIf strLen > 11 And strLen <= 14 Then
                    strBar = "A80,5,0,8,1,1,N,"
                ElseIf strLen >= 15 And strLen <= 16 Then
                    strBar = "A50,5,0,8,1,1,N,"
                Else
                    strBar = "A20,5,0,8,1,1,N,"
                End If
                fileWriter.WriteLine(" ")
                fileWriter.WriteLine("N")

                fileWriter.Write(strBar)
                fileWriter.Write(Chr(34))
                fileWriter.Write(BIG5TOGB(ToSBC(M_Name)))   '名稱
                fileWriter.Write(Chr(34))
                fileWriter.Write(Chr(13))
                fileWriter.Write(Chr(10))

                fileWriter.Write("B100,45,0,1,2,2,60,B,")
                fileWriter.Write(Chr(34))
                fileWriter.Write(M_Code)   '條碼
                fileWriter.Write(Chr(34))
                fileWriter.Write(Chr(13))
                fileWriter.Write(Chr(10))

                Dim strA As String
                strA = "P" & InQty

                fileWriter.WriteLine(strA)

                fileWriter.Flush()

                fileWriter.Close()

                outFile.Close()

                retval = CloseHandle(hPort)
            Catch ex As Exception

            End Try
        End Sub
    End Class
End Namespace
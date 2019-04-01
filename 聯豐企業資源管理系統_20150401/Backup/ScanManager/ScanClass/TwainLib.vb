
Imports System 
Imports System.Collections 
Imports System.Runtime.InteropServices 
Imports System.Windows.Forms 

Namespace TwainLib
    Public Enum TwainCommand
        [Not] = -1
        Null = 0
        TransferReady = 1
        CloseRequest = 2
        CloseOk = 3
        DeviceEvent = 4
    End Enum
    Public Class Twain
        Private Const CountryUSA As Short = 1
        Private Const LanguageUSA As Short = 13
       
        Public Sub New()
            appid = New TwIdentity()
            appid.Id = IntPtr.Zero
            appid.Version.MajorNum = 1
            appid.Version.MinorNum = 1
            appid.Version.Language = LanguageUSA
            appid.Version.Country = CountryUSA
            appid.Version.Info = "Hack 1"
            appid.ProtocolMajor = TwProtocol.Major
            appid.ProtocolMinor = TwProtocol.Minor
            appid.SupportedGroups = CInt((TwDG.Image Or TwDG.Control))
            appid.Manufacturer = "NETMaster"
            appid.ProductFamily = "Freeware"
            appid.ProductName = "Hack"

            srcds = New TwIdentity()
            srcds.Id = IntPtr.Zero

            evtmsg.EventPtr = Marshal.AllocHGlobal(Marshal.SizeOf(win))
        End Sub

        Protected Overrides Sub Finalize()
            Try
                Marshal.FreeHGlobal(evtmsg.EventPtr)
            Finally
                MyBase.Finalize()
            End Try
        End Sub

        Public Sub Init(ByVal hwndp As IntPtr)
            Finish()
            Dim rc As TwRC = DSMparent(appid, IntPtr.Zero, TwDG.Control, TwDAT.Parent, TwMSG.OpenDSM, hwndp)
            If rc = TwRC.Success Then
                rc = DSMident(appid, IntPtr.Zero, TwDG.Control, TwDAT.Identity, TwMSG.GetDefault, srcds)
                If rc = TwRC.Success Then
                    hwnd = hwndp
                Else
                    rc = DSMparent(appid, IntPtr.Zero, TwDG.Control, TwDAT.Parent, TwMSG.CloseDSM, hwndp)
                End If
            End If
        End Sub
        Public Sub Selected()
            Dim rc As TwRC
            CloseSrc()
            If appid.Id = IntPtr.Zero Then
                Init(hwnd)
                If appid.Id = IntPtr.Zero Then
                    Exit Sub
                End If
            End If
            rc = DSMident(appid, IntPtr.Zero, TwDG.Control, TwDAT.Identity, TwMSG.UserSelect, srcds)
        End Sub
        Public Sub Acquire()
            Dim rc As TwRC
            CloseSrc()
            If appid.Id = IntPtr.Zero Then
                Init(hwnd)
                If appid.Id = IntPtr.Zero Then
                    Exit Sub
                End If
            End If
            rc = DSMident(appid, IntPtr.Zero, TwDG.Control, TwDAT.Identity, TwMSG.OpenDS, srcds)
            If rc <> TwRC.Success Then
                MsgBox("沒有安裝掃描儀!", , "提示!")
                CloseSrc()
                Exit Sub
            End If

            Dim cap As New TwCapability(TwCap.XferCount, 1)
            rc = DScap(appid, srcds, TwDG.Control, TwDAT.Capability, TwMSG.[Set], cap)
            If rc <> TwRC.Success Then
                CloseSrc()
                Exit Sub
            End If
            Dim guif As New TwUserInterface()
            guif.ShowUI = 1
            guif.ModalUI = 1
            guif.ParentHand = hwnd
            rc = DSuserif(appid, srcds, TwDG.Control, TwDAT.UserInterface, TwMSG.EnableDS, guif)
            If rc <> TwRC.Success Then
                CloseSrc()
                Exit Sub
            End If
        End Sub
        Public Function TransferPictures() As ArrayList
            Dim pics As New ArrayList()
            If srcds.Id = IntPtr.Zero Then
                Return pics
            End If

            Dim rc As TwRC
            Dim hbitmap As IntPtr = IntPtr.Zero
            Dim pxfr As New TwPendingXfers()

            Do
                pxfr.Count = 0
                hbitmap = IntPtr.Zero

                Dim iinf As New TwImageInfo()
                rc = DSiinf(appid, srcds, TwDG.Image, TwDAT.ImageInfo, TwMSG.[Get], iinf)
                If rc <> TwRC.Success Then
                    CloseSrc()
                    Return pics
                End If

                rc = DSixfer(appid, srcds, TwDG.Image, TwDAT.ImageNativeXfer, TwMSG.[Get], hbitmap)
                If rc <> TwRC.XferDone Then
                    CloseSrc()
                    Return pics
                End If

                rc = DSpxfer(appid, srcds, TwDG.Control, TwDAT.PendingXfers, TwMSG.EndXfer, pxfr)
                If rc <> TwRC.Success Then
                    CloseSrc()
                    Return pics
                End If

                pics.Add(hbitmap)
            Loop While pxfr.Count <> 0

            rc = DSpxfer(appid, srcds, TwDG.Control, TwDAT.PendingXfers, TwMSG.Reset, pxfr)
            Return pics
        End Function
        Public Function PassMessage(ByRef m As Message) As TwainCommand
            If srcds.Id = IntPtr.Zero Then
                Return TwainCommand.[Not]
            End If

            Dim pos As Integer = GetMessagePos()

            win.hwnd = m.HWnd
            win.message = m.Msg
            win.wParam = m.WParam
            win.lParam = m.LParam
            win.time = GetMessageTime()
            win.x = CLng(pos)
            win.y = CLng((pos >> 16))

            Marshal.StructureToPtr(win, evtmsg.EventPtr, False)
            evtmsg.Message = 0
            Dim rc As TwRC = DSevent(appid, srcds, TwDG.Control, TwDAT.[Event], TwMSG.ProcessEvent, evtmsg)
            If rc = TwRC.NotDSEvent Then
                Return TwainCommand.[Not]
            End If
            If evtmsg.Message = CShort(TwMSG.XFerReady) Then
                Return TwainCommand.TransferReady
            End If
            If evtmsg.Message = CShort(TwMSG.CloseDSReq) Then
                Return TwainCommand.CloseRequest
            End If
            If evtmsg.Message = CShort(TwMSG.CloseDSOK) Then
                Return TwainCommand.CloseOk
            End If
            If evtmsg.Message = CShort(TwMSG.DeviceEvent) Then
                Return TwainCommand.DeviceEvent
            End If

            Return TwainCommand.Null
        End Function
        Public Sub CloseSrc()
            Dim rc As TwRC
            If srcds.Id <> IntPtr.Zero Then
                Dim guif As New TwUserInterface()
                rc = DSuserif(appid, srcds, TwDG.Control, TwDAT.UserInterface, TwMSG.DisableDS, guif)
                rc = DSMident(appid, IntPtr.Zero, TwDG.Control, TwDAT.Identity, TwMSG.CloseDS, srcds)
            End If
        End Sub
        Public Sub Finish()
            Dim rc As TwRC
            CloseSrc()
            If appid.Id <> IntPtr.Zero Then
                rc = DSMparent(appid, IntPtr.Zero, TwDG.Control, TwDAT.Parent, TwMSG.CloseDSM, hwnd)
            End If
            appid.Id = IntPtr.Zero
        End Sub

        Private hwnd As IntPtr
        Private appid As TwIdentity
        Private srcds As TwIdentity
        Private evtmsg As TwEvent
        Private win As WINMSG

        ' ------ DSM entry point DAT_ variants: 
        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DSMparent(<[In](), Out()> ByVal origin As TwIdentity, ByVal zeroptr As IntPtr, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, ByRef refptr As IntPtr) As TwRC
        End Function

        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DSMident(<[In](), Out()> ByVal origin As TwIdentity, ByVal zeroptr As IntPtr, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal idds As TwIdentity) As TwRC
        End Function

        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DSMstatus(<[In](), Out()> ByVal origin As TwIdentity, ByVal zeroptr As IntPtr, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal dsmstat As TwStatus) As TwRC
        End Function
        ' ------ DSM entry point DAT_ variants to DS: 
        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DSuserif(<[In](), Out()> ByVal origin As TwIdentity, <[In](), Out()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, ByVal guif As TwUserInterface) As TwRC
        End Function
        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DSevent(<[In](), Out()> ByVal origin As TwIdentity, <[In](), Out()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, ByRef evt As TwEvent) As TwRC
        End Function
        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DSstatus(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal dsmstat As TwStatus) As TwRC
        End Function
        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DScap(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal capa As TwCapability) As TwRC
        End Function
        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DSiinf(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal imginf As TwImageInfo) As TwRC
        End Function
        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DSixfer(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, ByRef hbitmap As IntPtr) As TwRC
        End Function
        <DllImport("twain_32.dll", EntryPoint:="#1")> _
        Private Shared Function DSpxfer(<[In](), Out()> ByVal origin As TwIdentity, <[In]()> ByVal dest As TwIdentity, ByVal dg As TwDG, ByVal dat As TwDAT, ByVal msg As TwMSG, <[In](), Out()> ByVal pxfr As TwPendingXfers) As TwRC
        End Function
        <DllImport("kernel32.dll", ExactSpelling:=True)> _
        Friend Shared Function GlobalAlloc(ByVal flags As Integer, ByVal size As Integer) As IntPtr
        End Function
        <DllImport("kernel32.dll", ExactSpelling:=True)> _
        Friend Shared Function GlobalLock(ByVal handle As IntPtr) As IntPtr
        End Function
        <DllImport("kernel32.dll", ExactSpelling:=True)> _
        Friend Shared Function GlobalUnlock(ByVal handle As IntPtr) As Boolean
        End Function
        <DllImport("kernel32.dll", ExactSpelling:=True)> _
        Friend Shared Function GlobalFree(ByVal handle As IntPtr) As IntPtr
        End Function
        <DllImport("user32.dll", ExactSpelling:=True)> _
        Private Shared Function GetMessagePos() As Integer
        End Function
        <DllImport("user32.dll", ExactSpelling:=True)> _
        Private Shared Function GetMessageTime() As Integer
        End Function
        <DllImport("gdi32.dll", ExactSpelling:=True)> _
        Private Shared Function GetDeviceCaps(ByVal hDC As IntPtr, ByVal nIndex As Integer) As Integer
        End Function
        <DllImport("gdi32.dll", CharSet:=CharSet.Auto)> _
        Private Shared Function CreateDC(ByVal szdriver As String, ByVal szdevice As String, ByVal szoutput As String, ByVal devmode As IntPtr) As IntPtr
        End Function
        <DllImport("gdi32.dll", ExactSpelling:=True)> _
        Private Shared Function DeleteDC(ByVal hdc As IntPtr) As Boolean
        End Function
        Public Shared ReadOnly Property ScreenBitDepth() As Integer
            Get
                Dim screenDC As IntPtr = CreateDC("DISPLAY", Nothing, Nothing, IntPtr.Zero)
                Dim bitDepth As Integer = GetDeviceCaps(screenDC, 12)
                bitDepth *= GetDeviceCaps(screenDC, 14)
                DeleteDC(screenDC)
                Return bitDepth
            End Get
        End Property
        <StructLayout(LayoutKind.Sequential, Pack:=4)> _
        Friend Structure WINMSG
            Public hwnd As IntPtr
            Public message As Integer
            Public wParam As IntPtr
            Public lParam As IntPtr
            Public time As Integer
            Public x As Integer
            Public y As Integer
        End Structure
    End Class
    ' class Twain 
End Namespace
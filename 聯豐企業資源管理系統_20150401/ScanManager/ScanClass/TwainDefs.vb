Imports System
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace TwainLib

    Public Class TwProtocol
        ' TWON_PROTOCOL... 
        Public Const Major As Short = 1
        Public Const Minor As Short = 9
    End Class

    <Flags()> _
    Friend Enum TwDG As Short
        ' DG_..... 
        Control = &H1
        Image = &H2
        Audio = &H4
    End Enum
    Friend Enum TwDAT As Short
        ' DAT_.... 
        Null = &H0
        Capability = &H1
        [Event] = &H2
        Identity = &H3
        Parent = &H4
        PendingXfers = &H5
        SetupMemXfer = &H6
        SetupFileXfer = &H7
        Status = &H8
        UserInterface = &H9
        XferGroup = &HA
        TwunkIdentity = &HB
        CustomDSData = &HC
        DeviceEvent = &HD
        FileSystem = &HE
        PassThru = &HF

        ImageInfo = &H101
        ImageLayout = &H102
        ImageMemXfer = &H103
        ImageNativeXfer = &H104
        ImageFileXfer = &H105
        CieColor = &H106
        GrayResponse = &H107
        RGBResponse = &H108
        JpegCompression = &H109
        Palette8 = &H10A
        ExtImageInfo = &H10B

        SetupFileXfer2 = &H301
    End Enum
    Friend Enum TwMSG As Short
        ' MSG_..... 
        Null = &H0
        [Get] = &H1
        GetCurrent = &H2
        GetDefault = &H3
        GetFirst = &H4
        GetNext = &H5
        [Set] = &H6
        Reset = &H7
        QuerySupport = &H8

        XFerReady = &H101
        CloseDSReq = &H102
        CloseDSOK = &H103
        DeviceEvent = &H104

        CheckStatus = &H201

        OpenDSM = &H301
        CloseDSM = &H302

        OpenDS = &H401
        CloseDS = &H402
        UserSelect = &H403

        DisableDS = &H501
        EnableDS = &H502
        EnableDSUIOnly = &H503

        ProcessEvent = &H601

        EndXfer = &H701
        StopFeeder = &H702

        ChangeDirectory = &H801
        CreateDirectory = &H802
        Delete = &H803
        FormatMedia = &H804
        GetClose = &H805
        GetFirstFile = &H806
        GetInfo = &H807
        GetNextFile = &H808
        Rename = &H809
        Copy = &H80A
        AutoCaptureDir = &H80B

        PassThru = &H901
    End Enum
    Friend Enum TwRC As Short
        ' TWRC_.... 
        Success = &H0
        Failure = &H1
        CheckStatus = &H2
        Cancel = &H3
        DSEvent = &H4
        NotDSEvent = &H5
        XferDone = &H6
        EndOfList = &H7
        InfoNotSupported = &H8
        DataNotAvailable = &H9
    End Enum
    Friend Enum TwCC As Short
        ' TWCC_.... 
        Success = &H0
        Bummer = &H1
        LowMemory = &H2
        NoDS = &H3
        MaxConnections = &H4
        OperationError = &H5
        BadCap = &H6
        BadProtocol = &H9
        BadValue = &HA
        SeqError = &HB
        BadDest = &HC
        CapUnsupported = &HD
        CapBadOperation = &HE
        CapSeqError = &HF
        Denied = &H10
        FileExists = &H11
        FileNotFound = &H12
        NotEmpty = &H13
        PaperJam = &H14
        PaperDoubleFeed = &H15
        FileWriteError = &H16
        CheckDeviceOnline = &H17
    End Enum
    Friend Enum TwOn As Short
        ' TWON_.... 
        Array = &H3
        [Enum] = &H4
        One = &H5
        Range = &H6
        DontCare = -1
    End Enum
    Friend Enum TwType As Short
        ' TWTY_.... 
        Int8 = &H0
        Int16 = &H1
        Int32 = &H2
        UInt8 = &H3
        UInt16 = &H4
        UInt32 = &H5
        Bool = &H6
        Fix32 = &H7
        Frame = &H8
        Str32 = &H9
        Str64 = &HA
        Str128 = &HB
        Str255 = &HC
        Str1024 = &HD
        Str512 = &HE
    End Enum
    Friend Enum TwCap As Short
        XferCount = &H1
        ' CAP_XFERCOUNT 
        ICompression = &H100
        ' ICAP_... 
        IPixelType = &H101
        IUnits = &H102
        IXferMech = &H103
    End Enum

    ' ------------------- STRUCTS -------------------------------------------- 

    <StructLayout(LayoutKind.Sequential, Pack:=2, CharSet:=CharSet.Ansi)> _
    Friend Class TwIdentity
        ' TW_IDENTITY 
        Public Id As IntPtr
        Public Version As TwVersion
        Public ProtocolMajor As Short
        Public ProtocolMinor As Short
        Public SupportedGroups As Integer
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=34)> _
        Public Manufacturer As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=34)> _
        Public ProductFamily As String
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=34)> _
        Public ProductName As String
    End Class
    <StructLayout(LayoutKind.Sequential, Pack:=2, CharSet:=CharSet.Ansi)> _
    Friend Structure TwVersion
        ' TW_VERSION 
        Public MajorNum As Short
        Public MinorNum As Short
        Public Language As Short
        Public Country As Short
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=34)> _
        Public Info As String
    End Structure
    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
    Friend Class TwUserInterface
        ' TW_USERINTERFACE 
        Public ShowUI As Short
        ' bool is strictly 32 bit, so use short 
        Public ModalUI As Short
        Public ParentHand As IntPtr
    End Class
    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
    Friend Class TwStatus
        ' TW_STATUS 
        Public ConditionCode As Short
        ' TwCC 
        Public Reserved As Short
    End Class
    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
    Friend Structure TwEvent
        ' TW_EVENT 
        Public EventPtr As IntPtr
        Public Message As Short
    End Structure
    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
    Friend Class TwImageInfo
        ' TW_IMAGEINFO 
        Public XResolution As Integer
        Public YResolution As Integer
        Public ImageWidth As Integer
        Public ImageLength As Integer
        Public SamplesPerPixel As Short
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=8)> _
        Public BitsPerSample As Short()
        Public BitsPerPixel As Short
        Public Planar As Short
        Public PixelType As Short
        Public Compression As Short
    End Class
    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
    Friend Class TwPendingXfers
        ' TW_PENDINGXFERS 
        Public Count As Short
        Public EOJ As Integer
    End Class
    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
    Friend Structure TwFix32
        ' TW_FIX32 
        Public Whole As Short
        Public Frac As UShort

        Public Function ToFloat() As Single
            Return CSng(Whole) + (CSng(Frac) / 65536.0F)
        End Function
        Public Sub FromFloat(ByVal f As Single)
            Dim i As Integer = CInt(((f * 65536.0F) + 0.5F))
            Whole = CShort((i >> 16))
            Frac = CUShort((i And &HFFFF))
        End Sub
    End Structure
    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
       Friend Class TwCapability
        ' TW_CAPABILITY 
        Public Sub New(ByVal cap__1 As TwCap)
            Cap = CLng(cap__1)
            ConType = -1
        End Sub
        Public Sub New(ByVal cap__1 As TwCap, ByVal sval As Short)
            Cap = CLng(cap__1)
            ConType = CLng(TwOn.One)
            Handle = Twain.GlobalAlloc(&H42, 6)
            Dim pv As IntPtr = Twain.GlobalLock(Handle)
            Marshal.WriteInt16(pv, 0, CLng(TwType.Int16))
            Marshal.WriteInt32(pv, 2, CInt(sval))
            Twain.GlobalUnlock(Handle)
        End Sub
        Protected Overrides Sub Finalize()
            Try
                If Handle <> IntPtr.Zero Then
                    Twain.GlobalFree(Handle)
                End If
            Finally
                MyBase.Finalize()
            End Try
        End Sub
        Public Cap As Short
        Public ConType As Short
        Public Handle As IntPtr
    End Class


End Namespace

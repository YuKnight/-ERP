Imports System.Runtime.InteropServices
Imports lferp.TwainLib
Imports lferp.GdiPlusLib
Module TwainMdl
    Public bmi As BITMAPINFOHEADER
    Public bmprect As Rectangle
    Public tw As TwainLib.Twain
    Public picnumber As Integer = 0
    Public msgfilter As Boolean

    <DllImport("gdi32.dll", ExactSpelling:=True)> _
    Public Function SetDIBitsToDevice(ByVal hdc As IntPtr, ByVal xdst As Integer, ByVal ydst As Integer, ByVal width As Integer, ByVal height As Integer, ByVal xsrc As Integer, _
      ByVal ysrc As Integer, ByVal start As Integer, ByVal lines As Integer, ByVal bitsptr As IntPtr, ByVal bmiptr As IntPtr, ByVal color As Integer) As Integer
    End Function
    <DllImport("kernel32.dll", ExactSpelling:=True)> _
    Public Function GlobalLock(ByVal handle As IntPtr) As IntPtr
    End Function
    <DllImport("kernel32.dll", ExactSpelling:=True)> _
    Public Function GlobalFree(ByVal handle As IntPtr) As IntPtr
    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto)> _
    Public Sub OutputDebugString(ByVal outstr As String)
    End Sub

    <StructLayout(LayoutKind.Sequential, Pack:=2)> _
Public Class BITMAPINFOHEADER
        Public biSize As Integer
        Public biWidth As Integer
        Public biHeight As Integer
        Public biPlanes As Short
        Public biBitCount As Short
        Public biCompression As Integer
        Public biSizeImage As Integer
        Public biXPelsPerMeter As Integer
        Public biYPelsPerMeter As Integer
        Public biClrUsed As Integer
        Public biClrImportant As Integer
    End Class
    Public Function GetPixelInfo(ByVal bmpptr As IntPtr) As IntPtr
        bmi = New BITMAPINFOHEADER()
        Marshal.PtrToStructure(bmpptr, bmi)

        bmprect.X = bmprect.Y = 0
        bmprect.Width = bmi.biWidth
        bmprect.Height = bmi.biHeight
        If bmi.biSizeImage = 0 Then
            bmi.biSizeImage = ((((bmi.biWidth * bmi.biBitCount) + 31) And Not 31) >> 3) * bmi.biHeight
        End If

        Dim p As Integer = bmi.biClrUsed

        If (p = 0) AndAlso (bmi.biBitCount <= 8) Then
            p = 1 << bmi.biBitCount
        End If
        p = (p * 4) + bmi.biSize + CInt(bmpptr)
        Return p


    End Function
    ''' <summary>
    ''' 轉換圖片大小
    ''' </summary>
    ''' <param name="MaxPic"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetMinPic(ByVal MaxPic As System.Drawing.Image) As System.Drawing.Image
        '依提供的大小轉換圖片
        Const Int_SmallSize As Integer = 2000
        Dim MinWidth, MinHeight As Long
        If MaxPic.Height > Int_SmallSize Or MaxPic.Width > Int_SmallSize Then
            If MaxPic.Height > MaxPic.Width Then
                MinWidth = MaxPic.Width / (MaxPic.Height / Int_SmallSize)
                MinHeight = Int_SmallSize
            Else
                MinWidth = Int_SmallSize
                MinHeight = MaxPic.Height / (MaxPic.Width / Int_SmallSize)
            End If
            Return MaxPic.GetThumbnailImage(CInt(MinWidth), CInt(MinHeight), Nothing, New System.IntPtr())
        Else
            Return MaxPic
        End If

    End Function
    Public Function GetEncodPic(ByVal Pic As System.Drawing.Image) As System.Drawing.Image
        '依比例轉換圖片
        Dim codecs() As Imaging.ImageCodecInfo = Imaging.ImageCodecInfo.GetImageEncoders()
        Dim ici As Imaging.ImageCodecInfo = Nothing
        Dim codec As Imaging.ImageCodecInfo

        Dim compressPic As New Bitmap(Pic)
        Dim ep As Imaging.EncoderParameters = New Imaging.EncoderParameters()
        For Each codec In codecs
            If (codec.MimeType = "image/jpeg") Then
                ici = codec
            End If
        Next

        ep.Param(0) = New Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 80)
        Pic.Save("d:\Test2.jpg", ici, ep)
        Dim tImage As System.Drawing.Image
        tImage = Image.FromFile("d:\Test2.jpg")
        Dim bmp As System.Drawing.Image = New Bitmap(tImage)

        tImage.Dispose()

        compressPic.Dispose()

        Return (bmp)


    End Function
    <STAThread()> _
Public Sub Main()
        If Twain.ScreenBitDepth < 15 Then
            MessageBox.Show("Need high/true-color video mode!", "Screen Bit Depth", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim mf As New MDIMain()
        Application.Run(mf)
    End Sub


End Module

Imports System.IO
Imports System.IO.File
Imports System.Drawing
Imports System.Drawing.Imaging
Public Class CompressImage
    Dim fs As IO.FileStream
    Const Int_SmallLSize As Integer = 1024 '分辨率大小
    Const Int_SmallHSize As Integer = 768
    Public Function GetMinPic(ByVal MaxPic As System.Drawing.Image) As System.Drawing.Image '等比例壓縮 但是測試效果不是很好
        Dim MinWidth As Integer, MinHeight As Integer

        If MaxPic.Height > Int_SmallHSize Or MaxPic.Width > Int_SmallLSize Then
            If MaxPic.Height > MaxPic.Width Then
                MinWidth = MaxPic.Width / (MaxPic.Height / Int_SmallHSize)
                MinHeight = Int_SmallHSize
            Else
                MinWidth = Int_SmallLSize
                MinHeight = MaxPic.Height / (MaxPic.Width / Int_SmallLSize)
            End If
            Return MaxPic.GetThumbnailImage(CInt(MinWidth), CInt(MinHeight), Nothing, New System.IntPtr())
        Else
            Return MaxPic
        End If

    End Function
    Public Sub GetJPEG(ByVal picturebox_image As System.Drawing.Image, ByVal picturebox As PictureBox, ByVal i As Integer) '編碼參數壓縮,效果較好
        '壓縮前線判斷圖片大小,圖片過大壓縮比率採用65，小則採用100
        'Dim ofd As New OpenFileDialog
        'ofd.Filter = "圖片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp"
        'ofd.ShowDialog()
        'ofd.OpenFile.Length/1024 =*MB   

        Dim codecs() As Imaging.ImageCodecInfo = Imaging.ImageCodecInfo.GetImageEncoders()
        Dim ici As Imaging.ImageCodecInfo = Nothing
        Dim codec As Imaging.ImageCodecInfo

        Dim compressPic As New Bitmap(picturebox_image)
        Dim ep As Imaging.EncoderParameters = New Imaging.EncoderParameters()
        For Each codec In codecs
            If (codec.MimeType = "image/jpeg") Then
                ici = codec
            End If
        Next
        ep.Param(0) = New Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, i)
        ' 此處參數i代表壓縮率，建議設置65-85之間,範圍0-100,100代表圖片質量最優，但壓縮率最低
        picturebox_image.Save(Application.StartupPath & "\TempFile\" & "ok.jpg", ici, ep)
        compressPic.Dispose()
        picturebox.ImageLocation = Application.StartupPath & "\TempFile\" & "ok.jpg"
    End Sub
End Class

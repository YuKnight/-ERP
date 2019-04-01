Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports lferp.GdiPlusLib
Imports System.IO
Imports iTextSharp.text.pdf


Public Class PicForm


    Private dibhand As IntPtr
    Private bmpptr As IntPtr
    Private pixptr As IntPtr
   


    Public Sub New(ByVal dibhandp As IntPtr)
        InitializeComponent()

        SetStyle(ControlStyles.DoubleBuffer, False)
        SetStyle(ControlStyles.AllPaintingInWmPaint, True)
        SetStyle(ControlStyles.Opaque, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        SetStyle(ControlStyles.UserPaint, True)

        bmprect = New Rectangle(0, 0, 0, 0)
        dibhand = dibhandp
        bmpptr = GlobalLock(dibhand)
        pixptr = GetPixelInfo(bmpptr)

        Me.AutoScrollMinSize = New System.Drawing.Size(bmprect.Width, bmprect.Height)

        Gdip.SaveDIBAs(Me.Text, bmpptr, pixptr)
        Dim FilePath As String
        FilePath = Application.StartupPath & "\TempFile\ScanTemp.jpg"
        'Dim picturebox1 As New PictureBox
        Dim tImage As System.Drawing.Image
        tImage = Image.FromFile(FilePath)
        '一定要轉換,否則圖片會一直被占用
        Dim bmp As System.Drawing.Image = New Bitmap(tImage)
        tImage.Dispose()
        '將圖片轉小
        bmp = GetMinPic(bmp)
        '將圖片壓縮
        ' bmp = GetEncodPic(bmp)



        Dim row As DataRow
        row = frmScan.ds.Tables("Image").NewRow
        row("Image") = ImageToByte(bmp)
        row("Page") = frmScan.ds.Tables("Image").Rows.Count
        frmScan.ds.Tables("Image").Rows.Add(row)
        'frmScan.pic.Image = ByteToImage(frmScan.ds.Tables("Image").Rows(frmScan.ds.Tables("Image").Rows.Count)("Image"))

        tImage.Dispose()
        File.Delete(FilePath)
        Me.Close()






    End Sub

    Protected Overloads Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim cltrect As Rectangle = ClientRectangle
        Dim clprect As Rectangle = e.ClipRectangle
        Dim scrol As Point = AutoScrollPosition

        Dim realrect As Rectangle = clprect
        realrect.X -= scrol.X
        realrect.Y -= scrol.Y

        Dim brbg As New SolidBrush(Color.Black)
        If realrect.Right > bmprect.Width Then
            Dim bgri As Rectangle = clprect
            Dim ovri As Integer = bmprect.Width - realrect.X
            If ovri > 0 Then
                bgri.X += ovri
                bgri.Width -= ovri
            End If
            e.Graphics.FillRectangle(brbg, bgri)
        End If

        If realrect.Bottom > bmprect.Height Then
            Dim bgbo As Rectangle = clprect
            Dim ovbo As Integer = bmprect.Height - realrect.Y
            If ovbo > 0 Then
                bgbo.Y += ovbo
                bgbo.Height -= ovbo
            End If
            e.Graphics.FillRectangle(brbg, bgbo)
        End If

        realrect.Intersect(bmprect)
        If Not realrect.IsEmpty Then
            Dim bot As Integer = bmprect.Height - realrect.Bottom
            Dim hdc As IntPtr = e.Graphics.GetHdc()
            SetDIBitsToDevice(hdc, clprect.X, clprect.Y, realrect.Width, realrect.Height, realrect.X, _
            bot, 0, bmprect.Height, pixptr, bmpptr, 0)
            e.Graphics.ReleaseHdc(hdc)
        End If
    End Sub

    Protected Overloads Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        Me.Menu.MenuItems.Clear()
        MyBase.OnClosing(e)
    End Sub

    Private Sub menuItemClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItemClose.Click
        Close()
    End Sub

   
    Private Sub PicForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    



End Class



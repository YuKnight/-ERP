Imports System.IO
Imports System.Windows.Forms
Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.DataSetting


Public Class FrmCompanyAdd
    Private fs As FileStream
    Private Sub cmdDelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelPhoto.Click
        Dim objinfo As New LFERP.DataSetting.CompanyInfo
        Dim objct As New LFERP.DataSetting.CompanyControler
        objinfo.CO_ID = "CB"
        objinfo.CO_ChsName = "採煌有限公司"
        objinfo.CO_EngName = "CB"
        objinfo.CO_ChsAddress = "深圳市寶安區龍華鎮第五工業區上塘東二村"
        objinfo.CO_ChsTel = "0755-27748020"
        objinfo.CO_ChsFax = "0755-27749753"
        objinfo.CO_Logo = ImageToByte(pPhoto.Image)
        If objct.Company_Update(objinfo) = True Then
            MsgBox("CB-OK")
        End If

    End Sub

    Private Sub cmdOpenPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpenPhoto.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "圖片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp"
        ofd.ShowDialog()


        If ofd.FileName.ToString = "" Then Exit Sub
        fs = New FileStream(ofd.FileName.ToString, FileMode.Open, FileAccess.Read)
        pPhoto.Image = Image.FromFile(ofd.FileName.ToString)
    End Sub

    Private Sub FrmCompanyAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim objinfo As New LFERP.DataSetting.CompanyInfo
        Dim objct As New LFERP.DataSetting.CompanyControler
        objinfo.CO_ID = "LF"
        objinfo.CO_ChsName = "聯豐表殼廠有限公司"
        objinfo.CO_EngName = "LuenFungWatch"
        objinfo.CO_ChsAddress = "深圳市寶安區龍華鎮第五工業區上塘東二村"
        objinfo.CO_ChsTel = "0755-27748020"
        objinfo.CO_ChsFax = "0755-27749753"
        objinfo.CO_Logo = ImageToByte(pPhoto.Image)
        If objct.Company_Update(objinfo) = True Then
            MsgBox("LF-OK")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim objinfo As New LFERP.DataSetting.CompanyInfo
        Dim objct As New LFERP.DataSetting.CompanyControler
        objinfo.CO_ID = "MG"
        objinfo.CO_ChsName = "米亞精密金屬有限公司"
        objinfo.CO_EngName = "MeGa"
        objinfo.CO_ChsAddress = "東莞市鳳崗鎮玉泉工業區"
        objinfo.CO_ChsTel = "0769-86802888"
        objinfo.CO_ChsFax = "0769-86803888"
        objinfo.CO_Logo = ImageToByte(pPhoto.Image)
        If objct.Company_Update(objinfo) = True Then
            MsgBox("MG-OK")
        End If
    End Sub
End Class
Imports System.IO
Imports System.Windows.Forms
Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.DataSetting


Public Class FrmCompany
    Private fs As FileStream
    'Private Sub cmdDelPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelPhoto.Click
    '    Dim objinfo As New LFERP.DataSetting.CompanyInfo
    '    Dim objct As New LFERP.DataSetting.CompanyControler
    '    objinfo.CO_ID = "CB"
    '    objinfo.CO_ChsName = "採煌有限公司"
    '    objinfo.CO_EngName = "CB"
    '    objinfo.CO_ChsAddress = "深圳市寶安區龍華鎮第五工業區上塘東二村"
    '    objinfo.CO_ChsTel = "0755-27748020"
    '    objinfo.CO_ChsFax = "0755-27749753"
    '    objinfo.CO_Logo = ImageToByte(pPhoto.Image)
    '    If objct.Company_Update(objinfo) = True Then
    '        MsgBox("CB-OK")
    '    End If

    'End Sub


    Private Sub FrmCompanyAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clr_text()

        Dim CC As New CompanyControler
        Grid1.DataSource = CC.Company_Getlist(Nothing, Nothing, Nothing, Nothing)
    End Sub


    Sub Clr_text()
        txtCO_ID.Text = ""
        txtCO_ChsName.Text = ""
        txtCO_EngName.Text = ""
        txtCO_ChsAddress.Text = ""
        txtCO_EngAddress.Text = ""

        txtCO_ChsTel.Text = ""
        txtCO_EngTel.Text = ""
        txtCO_ChsFax.Text = ""
        txtCO_EngFax.Text = ""

        pPhoto.Image = Nothing


        txtCO_ID.Focus()
    End Sub

    ' Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Dim objinfo As New LFERP.DataSetting.CompanyInfo
    'Dim objct As New LFERP.DataSetting.CompanyControler
    'objinfo.CO_ID = "LF"
    'objinfo.CO_ChsName = "聯豐表殼廠有限公司"
    'objinfo.CO_EngName = "LuenFungWatch"
    'objinfo.CO_ChsAddress = "深圳市寶安區龍華鎮第五工業區上塘東二村"
    'objinfo.CO_ChsTel = "0755-27748020"
    'objinfo.CO_ChsFax = "0755-27749753"
    'objinfo.CO_Logo = ImageToByte(pPhoto.Image)
    'If objct.Company_Update(objinfo) = True Then
    '    MsgBox("LF-OK")
    'End If
    ' End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    Dim objinfo As New LFERP.DataSetting.CompanyInfo
    '    Dim objct As New LFERP.DataSetting.CompanyControler
    '    objinfo.CO_ID = "MG"
    '    objinfo.CO_ChsName = "米亞精密金屬有限公司"
    '    objinfo.CO_EngName = "MeGa"
    '    objinfo.CO_ChsAddress = "東莞市鳳崗鎮玉泉工業區"
    '    objinfo.CO_ChsTel = "0769-86802888"
    '    objinfo.CO_ChsFax = "0769-86803888"
    '    objinfo.CO_Logo = ImageToByte(pPhoto.Image)
    '    If objct.Company_Update(objinfo) = True Then
    '        MsgBox("MG-OK")
    '    End If
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    Dim objinfo As New LFERP.DataSetting.CompanyInfo
    '    Dim objct As New LFERP.DataSetting.CompanyControler


    '    objinfo.DPT_ID = "1002"
    '    objinfo.CO_ID = "DGMG"
    '    objinfo.CO_ChsName = "米亞精密金屬科技(東莞)有限公司"
    '    objinfo.CO_EngName = "MeGa"
    '    objinfo.CO_ChsAddress = "東莞市鳳崗鎮玉泉工業區"
    '    objinfo.CO_ChsTel = "0769-86802888"
    '    objinfo.CO_ChsFax = "0769-86803888"
    '    objinfo.CO_Logo = ImageToByte(pPhoto.Image)
    '    If objct.Company_Update(objinfo) = True Then
    '        MsgBox("DGMG-OK")
    '    End If
    'End Sub

    ''' <summary>
    ''' 載入數據
    ''' </summary>
    ''' <param name="_CO_ID"></param>
    ''' <remarks></remarks>
    Sub LoadData(ByVal _CO_ID As String)

        Clr_text()

        Dim objList As New List(Of LFERP.DataSetting.CompanyInfo)
        Dim objct As New LFERP.DataSetting.CompanyControler
        objList = objct.Company_Getlist(Nothing, _CO_ID, Nothing, Nothing)

        If objList.Count <= 0 Then Exit Sub

        txtCO_ID.Text = objList(0).CO_ID

        txtCO_ChsName.Text = objList(0).CO_ChsName
        txtCO_EngName.Text = objList(0).CO_EngName

        txtCO_ChsAddress.Text = objList(0).CO_ChsAddress
        txtCO_EngAddress.Text = objList(0).CO_EngAddress

        txtCO_ChsTel.Text = objList(0).CO_ChsTel
        txtCO_EngTel.Text = objList(0).CO_EngTel

        txtCO_ChsFax.Text = objList(0).CO_ChsFax
        txtCO_EngFax.Text = objList(0).CO_EngFax

        If objList(0).CO_Logo Is Nothing Then
            pPhoto.Image = Nothing
        Else
            pPhoto.Image = ByteToImage(objList(0).CO_Logo)
        End If

        txtCO_ID.SelectionStart = Len(txtCO_ID.Text)

    End Sub
    ''' <summary>
    ''' 保存數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub Save_Edit()
        Dim Save_State As String

        ''先判斷此記錄是否存在，若存在則更新一下,若不存在則增加一條記錄
        If txtCO_ID.Text = "" Then
            MsgBox("公司代號不能為空，請檢查！")
            Exit Sub
        End If

        Dim Fc As New CompanyControler
        Dim Fil As New List(Of CompanyInfo)

        Fil = Fc.Company_Getlist(Nothing, txtCO_ID.Text.Trim, Nothing, Nothing)

        If Fil.Count > 0 Then
            Save_State = "Update"
            If MsgBox("此公司代號信息已存在,是否繼續保存?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Else
                Exit Sub
            End If
        Else
            Save_State = "Add"
        End If


        Dim objct As New CompanyControler
        Dim objinfo As New CompanyInfo

        objinfo.CO_ID = txtCO_ID.Text

        objinfo.CO_ChsName = txtCO_ChsName.Text
        objinfo.CO_EngName = txtCO_EngName.Text

        objinfo.CO_ChsAddress = txtCO_ChsAddress.Text
        objinfo.CO_EngAddress = txtCO_EngAddress.Text

        objinfo.CO_ChsTel = txtCO_ChsTel.Text
        objinfo.CO_EngTel = txtCO_EngTel.Text

        objinfo.CO_ChsFax = txtCO_ChsFax.Text
        objinfo.CO_EngFax = txtCO_EngFax.Text


        objinfo.CO_Logo = ImageToByte(pPhoto.Image) '保存圖象(二進制)

        If Save_State = "Update" Then
            If objct.Company_Update(objinfo) = True Then
                MsgBox("數據更新成功!")
                'Clr_text()
            End If
        Else
            If objct.Company_Add(objinfo) = True Then
                MsgBox("數據添加成功!")
                Dim CC As New CompanyControler
                Grid1.DataSource = CC.Company_Getlist(Nothing, Nothing, Nothing, Nothing)
                Clr_text()
            End If
        End If
    End Sub


    ''' <summary>
    ''' 顯示內容
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        Dim strA As String

        If GridView1.RowCount <= 0 Then Exit Sub
        strA = GridView1.GetFocusedRowCellValue("CO_ID")

        LoadData(strA)

    End Sub
    ''' <summary>
    ''' 載入LOGO圖片
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoad.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "圖片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp"
        ofd.ShowDialog()


        If ofd.FileName.ToString = "" Then Exit Sub
        fs = New FileStream(ofd.FileName.ToString, FileMode.Open, FileAccess.Read)
        pPhoto.Image = Image.FromFile(ofd.FileName.ToString)
    End Sub
    ''' <summary>
    ''' 刪除記錄
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DelToolStrip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelToolStrip.Click

        Dim strA As String

        If GridView1.RowCount <= 0 Then Exit Sub

        strA = GridView1.GetFocusedRowCellValue("CO_ID")

        If strA = "" Then Exit Sub

        If MsgBox("你確定刪除公司代號為:  '" & strA & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim dc As New CompanyControler
            Dim di As New CompanyInfo
            di.CO_ID = strA
            If dc.Company_Del(di) = True Then
                MsgBox("刪除成功！")

                Clr_text()
                Dim CC As New CompanyControler
                Grid1.DataSource = CC.Company_Getlist(Nothing, Nothing, Nothing, Nothing)

            Else
                MsgBox("刪除失敗！")
            End If
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Save_Edit()
    End Sub

    Private Sub BottonClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BottonClr.Click
        pPhoto.Image = Nothing
    End Sub


End Class
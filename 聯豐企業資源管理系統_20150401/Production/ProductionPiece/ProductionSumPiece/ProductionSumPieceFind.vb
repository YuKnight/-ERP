Imports LFERP.DataSetting
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionPieceWorkGroup

Public Class ProductionSumPieceFind

    Dim Str_Choice As String ''組別計件查詢 還是 個人計件查詢
    Dim ds As New DataSet

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        '配件名稱表
        With ds.Tables.Add("ProductType")
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
        End With

        gluPM_Type.Properties.DisplayMember = "PM_Type"
        gluPM_Type.Properties.ValueMember = "PM_Type"
        gluPM_Type.Properties.DataSource = ds.Tables("ProductType")

    End Sub

    Sub CreateTable1() ''記錄輸入的信息

        txtPer_NO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        txtPer_NO.Properties.Buttons.Clear()

        ' ds.Tables.Clear()

        With ds.Tables.Add("Per_NOEdit")
            .Columns.Add("Per_NO", GetType(String))
        End With

        txtPer_NO.Properties.DisplayMember = "Per_NO"
        txtPer_NO.Properties.ValueMember = "Per_NO"
        txtPer_NO.Properties.DataSource = ds.Tables("Per_NOEdit")
    End Sub

    Sub WriteRecod()  ''
        ds.Tables("Per_NOEdit").Clear()
        Dim row As DataRow
        row = ds.Tables("Per_NOEdit").NewRow
        row("Per_NO") = txtPer_NO.Text
        ds.Tables("Per_NOEdit").Rows.Add(row)
    End Sub

    Private Sub txtPer_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPer_NO.EditValueChanged
        'If Str_Choice = "P" Then
        '    WriteRecod()
        'End If
    End Sub

    Private Sub ProductionSumPieceFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Str_Choice = tempValue
        tempValue = Nothing

        Start_Date.Text = Format(Now, "yyyy/MM/dd")
        End_Date.Text = Format(Now, "yyyy/MM/dd")

        CreateTable()

        Dim mc As New ProductController
        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        '加載廠別名稱
        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)

        If Str_Choice = "P" Then

            ' CreateTable1() ''改為手動輸入編號
           

            LabCaption.Text = "個人計件查詢"
        ElseIf Str_Choice = "G" Then

            Per_NO.Caption = "編號"
            Per_NO.FieldName = "G_NO"
            Per_Name.Caption = "名稱"
            Per_Name.FieldName = "G_Name"

            LabPer_NO.Text = "組別編號(&I)"

            'Dim pc As New ProductionPieceWorkGroupControl
            'txtPer_NO.Properties.DisplayMember = "G_Name"
            'txtPer_NO.Properties.ValueMember = "G_NO"
            'txtPer_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing)

            LabCaption.Text = "組別計件查詢"
        End If


        lueFacID.Focus()
        lueFacID.Select()

        ''--------------------查詢時用戶權限------------------------
        If strInUserRank = "生產部" Then
            lueFacID.EditValue = strInFacIDFull
        ElseIf strInUserRank = "管理" Then
        ElseIf strInUserRank = "統計" Then
            lueFacID.EditValue = strInFacIDFull
            lueDepID.EditValue = strInDepIDFull
        End If

    End Sub

    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        If gluPM_M_Code.EditValue <> "" Then
            Dim pcc As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)

            pci = pcc.ProcessMain_GetList1(Nothing, gluPM_M_Code.EditValue, cboPro_Type.Text, Nothing)
            If pci.Count = 0 Then
                ds.Tables("ProductType").Clear()
            Else
                ds.Tables("ProductType").Clear()
                Dim i As Integer
                For i = 0 To pci.Count - 1
                    Dim row As DataRow
                    row = ds.Tables("ProductType").NewRow
                    row("M_Code") = pci(i).M_Code
                    row("PM_Type") = pci(i).Type3ID

                    ds.Tables("ProductType").Rows.Add(row)
                Next
            End If
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If txtPer_NO.EditValue Is Nothing Then
            tempValue2 = Nothing
        Else
            tempValue2 = txtPer_NO.EditValue
        End If

        If cboPro_Type.EditValue Is Nothing Then
            tempValue3 = Nothing
        Else
            tempValue3 = cboPro_Type.EditValue
        End If

        If gluPM_M_Code.EditValue Is Nothing Then
            tempValue4 = gluPM_M_Code.EditValue
        Else
            tempValue4 = Nothing
        End If

        If gluPM_Type.EditValue Is Nothing Then
            tempValue5 = Nothing
        Else
            tempValue5 = gluPM_Type.EditValue
        End If

        If Start_Date.EditValue Is Nothing Then
            tempValue6 = Nothing
        Else
            tempValue6 = Start_Date.EditValue
        End If

        If End_Date.EditValue Is Nothing Then
            tempValue7 = Nothing
        Else
            tempValue7 = End_Date.EditValue
        End If

        If lueFacID.EditValue Is Nothing Then
            tempValue8 = Nothing
        Else
            tempValue8 = lueFacID.EditValue
        End If

        If lueDepID.EditValue Is Nothing Then
            tempValue9 = Nothing
        Else
            tempValue9 = lueDepID.EditValue
        End If


        tempValue = "F"
        Me.Close()

    End Sub

    Private Sub txtPer_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPer_NO.KeyDown, cboPro_Type.KeyDown, gluPM_M_Code.KeyDown, gluPM_Type.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub


    Private Sub lueDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDepID.EditValueChanged

        If lueDepID.EditValue Is Nothing Then Exit Sub


        If Str_Choice = "P" Then
            Dim Ppc As New ProductionPiecePersonnelControl
            txtPer_NO.Properties.DataSource = Ppc.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing, "False", Nothing, Nothing)
            txtPer_NO.Properties.DisplayMember = "Per_NOName"
            txtPer_NO.Properties.ValueMember = "Per_NO"
        Else
            Dim pc As New ProductionPieceWorkGroupControl
            txtPer_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing)
            txtPer_NO.Properties.ValueMember = "G_NO"
            txtPer_NO.Properties.DisplayMember = "G_NOName"
        End If

      

    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Dim dc As New DepartmentControler
        If lueFacID.EditValue Is Nothing Then Exit Sub

        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)
    End Sub
End Class
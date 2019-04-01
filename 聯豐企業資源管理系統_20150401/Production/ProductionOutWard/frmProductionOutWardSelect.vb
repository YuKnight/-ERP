Imports LFERP.Library.Production.ProductionOutWard
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Production.ProductionType
Imports LFERP.Library.Product

Public Class frmProductionOutWardSelect

    Dim ds As New DataSet
    Public isClickcmdSave As Boolean

    Sub LoadProductNo()  '產品編號

        Dim mc As New ProcessMainControl
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

        Dim ptc As New ProductionOutWardTypeControl

        GluOutWard.Properties.DataSource = ptc.ProductionOutWardType_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
        GluOutWard.Properties.DisplayMember = "OW_Do"
        GluOutWard.Properties.ValueMember = "OW_Do"

    End Sub

    Private Sub frmProductionOutWardSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()

        LoadProductNo()

        ComboBoxEdit1.EditValue = "生產加工"
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")
        DateEdit2.Text = Format(Now, "yyyy/MM/dd")
        ComboBoxEdit2.EditValue = ""
        ComboBoxEdit3.EditValue = ""

        isClickcmdSave = False
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With
        GluType.Properties.ValueMember = "PM_Type"
        GluType.Properties.DisplayMember = "PM_Type"
        GluType.Properties.DataSource = ds.Tables("ProductType")


        With ds.Tables.Add("Process")
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
        End With

        GluEdit1.Properties.ValueMember = "PS_NO"
        GluEdit1.Properties.DisplayMember = "PS_Name"
        GluEdit1.Properties.DataSource = ds.Tables("Process")

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Len(TextEdit1.Text.Trim) = 0 Then
            tempValue = Nothing
        Else
            tempValue = TextEdit1.Text ' 單號信息
        End If
        If PM_M_Code.EditValue = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = PM_M_Code.EditValue '產品編號
        End If
        If GluType.EditValue = "" Then
            tempValue3 = Nothing
        Else
            tempValue3 = GluType.EditValue '配件名稱
        End If
        If GluEdit1.EditValue = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = GluEdit1.EditValue '加工工序
        End If
        If GluOutWard.EditValue = "" Then
            tempValue5 = Nothing
        Else
            tempValue5 = GluOutWard.EditValue '加工要求
        End If
        If ComboBoxEdit2.EditValue = "" Then
            tempValue6 = Nothing
        Else
            tempValue6 = ComboBoxEdit2.EditValue '類型
        End If
        If ComboBoxEdit3.EditValue = "" Then
            tempValue7 = Nothing
        Else
            tempValue7 = ComboBoxEdit3.EditValue '是否需回
        End If
        If Len(TextEdit2.Text.Trim) = 0 Then
            tempValue8 = Nothing
        Else
            tempValue8 = TextEdit2.Text '收貨人
        End If
        If Len(TextEdit3.Text.Trim) = 0 Then
            tempValue9 = Nothing
        Else
            tempValue9 = TextEdit3.Text '發貨人
        End If
        tempValue10 = DateEdit1.Text '開始日期
        tempCode = DateEdit2.Text '截止日期

        isClickcmdSave = True
        Me.Close()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged
        On Error Resume Next

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)
        ds.Tables("ProductType").Clear()
        ds.Tables("Process").Clear()

        If PM_M_Code.Text.Trim = "" Then Exit Sub '@ 2012/8/11 添加

        'If ComboBoxEdit1.EditValue = "" Then
        '    MsgBox("工藝類型不能為空!")
        '    Exit Sub
        'End If
        ppi = ppc.ProcessMain_GetList2(ComboBoxEdit1.EditValue, PM_M_Code.EditValue)
        If ppi.Count = 0 Then
        Else

            Dim i As Integer
            For i = 0 To ppi.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductType").NewRow
                row("PM_Type") = ppi(i).Type3ID
                ds.Tables("ProductType").Rows.Add(row)

            Next
        End If

        GluType.Text = ""        '@ 2012/8/11 添加
    End Sub

    Private Sub GluType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GluType.EditValueChanged
        On Error Resume Next

        ds.Tables("Process").Clear()

        If GluType.Text = "" Then Exit Sub '@ 2012/8/11 添加

        Dim pc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)
        pci = pc.ProcessMain_GetList(Nothing, PM_M_Code.EditValue, ComboBoxEdit1.EditValue, GluType.EditValue, Nothing, True)

        If pci.Count = 0 Then Exit Sub

        Dim i As Integer
        For i = 0 To pci.Count - 1
            Dim row As DataRow
            row = ds.Tables("Process").NewRow

            row("PS_NO") = pci(i).PS_NO
            row("PS_Name") = pci(i).PS_Name

            ds.Tables("Process").Rows.Add(row)

        Next
    End Sub

    '@ 2012/8/11 添加
    Private Sub ComboBoxEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxEdit1.KeyDown, ComboBoxEdit2.KeyDown, ComboBoxEdit3.KeyDown, GluEdit1.KeyDown, GluOutWard.KeyDown, GluType.KeyDown, PM_M_Code.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    '@ 2012/8/11 添加
    Private Sub ComboBoxEdit1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.SelectedIndexChanged
        PM_M_Code_EditValueChanged(Nothing, Nothing)
    End Sub

End Class
Imports LFERP.Library.Production.ProductionOutWard
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Production.ProductionType
Imports LFERP.Library.Product
Imports LFERP.DataSetting

Public Class frmProductionOutProcessFind
    Dim ds As New DataSet
    Public isClickcmdFind As Boolean  '判斷是否單擊了cmdOK按鈕
    Public strPo_Type As String

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluPM_Type.Properties.ValueMember = "PM_Type"
        gluPM_Type.Properties.DisplayMember = "PM_Type"
        gluPM_Type.Properties.DataSource = ds.Tables("ProductType")


        With ds.Tables.Add("Process")
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
        End With

        gluPS_Name.Properties.ValueMember = "PS_NO"
        gluPS_Name.Properties.DisplayMember = "PS_Name"
        gluPS_Name.Properties.DataSource = ds.Tables("Process")

    End Sub

    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        On Error Resume Next

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)

        ds.Tables("ProductType").Clear()
        ds.Tables("Process").Clear()

        If gluPM_M_Code.Text = "" Then Exit Sub

        ppi = ppc.ProcessMain_GetList2("生產加工", gluPM_M_Code.EditValue)
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

        gluPM_Type.Text = ""
    End Sub

    Private Sub gluPM_Type_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_Type.EditValueChanged
        On Error Resume Next

        Dim pc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)

        ds.Tables("Process").Clear()

        If gluPM_Type.Text = "" Then Exit Sub

        pci = pc.ProcessMain_GetList(Nothing, gluPM_M_Code.EditValue, "生產加工", gluPM_Type.EditValue, Nothing, True)

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

    Private Sub frmProductionOutProcessFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If strPO_Type = "外發返修" Then
            lblPO_ID.Text = "外發返修單號(&I)："
        End If

        CreateTable()
        isClickcmdFind = False

        '加載外發供應商信息
        Dim mtd As New SuppliersControler
        gluS_SupplierName.Properties.DisplayMember = "S_SupplierName"
        gluS_SupplierName.Properties.ValueMember = "S_Supplier"
        gluS_SupplierName.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")

        Dim mc As New ProcessMainControl
        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        If txtPO_ID.Text.Trim = "" Then
            tempValue = Nothing
        Else
            tempValue = txtPO_ID.Text.Trim
        End If

        If gluPM_M_Code.EditValue = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = gluPM_M_Code.EditValue
        End If

        If gluPM_Type.EditValue = "" Then
            tempValue3 = Nothing
        Else
            tempValue3 = gluPM_Type.EditValue
        End If

        If gluPS_Name.EditValue = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = gluPS_Name.EditValue
        End If

        If gluS_SupplierName.EditValue = "" Then
            tempValue5 = Nothing
        Else
            tempValue5 = gluS_SupplierName.EditValue
        End If

        If dtePO_OutDateBegin.Text.Trim = "" Then
            tempValue6 = Nothing
        Else
            tempValue6 = dtePO_OutDateBegin.Text.Trim
        End If

        If dtePO_OutDateEnd.Text.Trim = "" Then
            tempValue7 = Nothing
        Else
            tempValue7 = dtePO_OutDateEnd.Text.Trim
        End If

        isClickcmdFind = True

        Me.Close()
    End Sub

    Private Sub gluPM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPM_M_Code.KeyDown, gluPM_Type.KeyDown, gluPS_Name.KeyDown, gluS_SupplierName.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    'Private Sub gluPM_Type_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPM_Type.KeyDown
    '    If e.KeyCode = Keys.Space Then
    '        gluPM_Type.ShowPopup()
    '    End If
    'End Sub

    'Private Sub gluPS_Name_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPS_Name.KeyDown
    '    If e.KeyCode = Keys.Space Then
    '        gluPS_Name.ShowPopup()
    '    End If
    'End Sub

    'Private Sub gluS_SupplierName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluS_SupplierName.KeyDown
    '    If e.KeyCode = Keys.Space Then
    '        gluS_SupplierName.ShowPopup()
    '    End If
    'End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
Imports LFERP.Library.ProductionOWPAcceptance
Imports LFERP.Library.ProductProcess


Public Class FrmProductionOWPAcceptanceFind
    Dim ds As New DataSet


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Trim(txtA_AcceptanceNO.Text) <> "" Then ''驗收單
            tempValue2 = Trim(txtA_AcceptanceNO.Text)
        Else
            tempValue2 = Nothing
        End If

        If Trim(txtO_NO.Text) <> "" Then ''外發單號
            tempValue3 = Trim(txtO_NO.Text)
        Else
            tempValue3 = Nothing
        End If

        If Trim(txtSend_NO.Text) <> "" Then ''送貨單
            tempValue4 = Trim(txtSend_NO.Text)
        Else
            tempValue4 = Nothing
        End If

        If Trim(gluSupplier.EditValue) <> "" Then ''供應商
            tempValue5 = Trim(gluSupplier.EditValue)
        Else
            tempValue5 = Nothing
        End If

        If Trim(PM_M_Code.EditValue) <> "" Then ''產品編號
            tempValue6 = Trim(PM_M_Code.EditValue)
        Else
            tempValue6 = Nothing
        End If

        If Trim(GluType.EditValue) <> "" Then '類型
            tempValue7 = Trim(GluType.EditValue)
        Else
            tempValue7 = Nothing
        End If

        If Trim(GlookP_Name.EditValue) <> "" Then '工序
            tempValue8 = Trim(GlookP_Name.EditValue)
        Else
            tempValue8 = Nothing
        End If

        If Trim(EditA_SendDateS.EditValue) <> "" Then '時間S
            tempValue9 = Trim(EditA_SendDateS.EditValue)
        Else
            tempValue9 = Nothing
        End If

        If Trim(EditA_SendDateE.EditValue) <> "" Then '時間E
            tempValue10 = Trim(EditA_SendDateE.EditValue)
        Else
            tempValue10 = Nothing
        End If

        tempValue = "F"

        Me.Close()

    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing
        tempValue7 = Nothing
        tempValue8 = Nothing
        tempValue9 = Nothing
        tempValue10 = Nothing

        Me.Close()
    End Sub


    Private Sub FrmProductionOWPAcceptanceFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")

        'EditA_SendDateS.EditValue = Format(DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), "yyyy/MM/dd")
        'EditA_SendDateE.EditValue = Format(Now, "yyyy/MM/dd")

        CreateTable()
        Load_List()

        txtA_AcceptanceNO.Focus()
        ''
    End Sub

    ''' <summary>
    ''' 載入產品編號
    ''' </summary>
    ''' <remarks></remarks>
    Sub Load_List()
        Dim oc As New ProductionOWPAcceptanceControl
        Dim objList As New List(Of ProductionOWPAcceptanceInfo)

        Dim i As Integer
        Dim Count As Double
        Dim row As DataRow
        ds.Tables("PM_M_Code_S").Rows.Clear()
        objList = oc.ProductionOWPAcceptance_GetList1(Nothing, Nothing, Nothing, Nothing, 1)

        Count = objList.Count
        If Count <= 0 Then
            Exit Sub
        End If

        For i = 0 To Count - 1
            row = ds.Tables("PM_M_Code_S").NewRow
            row("PM_M_Code") = objList(i).PM_M_Code
            row("PM_JiYu") = objList(i).PM_JiYu
            ds.Tables("PM_M_Code_S").Rows.Add(row)
        Next

    End Sub
    ''' <summary>
    ''' 建立列控件下拉單
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("PM_M_Code_S")
            .Columns.Add("PM_M_Code", GetType(String))  '
            .Columns.Add("PM_JiYu", GetType(String))
        End With
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = ds.Tables("PM_M_Code_S")

        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With

        GluType.Properties.DisplayMember = "PM_Type"
        GluType.Properties.ValueMember = "PM_Type"
        GluType.Properties.DataSource = ds.Tables("ProductType")


        With ds.Tables.Add("PS_Name_S")
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
        End With

        GlookP_Name.Properties.DisplayMember = "PS_Name"
        GlookP_Name.Properties.ValueMember = "PS_NO"
        GlookP_Name.Properties.DataSource = ds.Tables("PS_Name_S")

    End Sub

    'Private Sub txtA_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtA_AcceptanceNO.KeyDown
    '    If e.KeyCode = Keys.Escape Then
    '        Me.Close()
    '    End If
    'End Sub


    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged
        On Error Resume Next

        ''列數據表中的“類型”
        ds.Tables("ProductType").Rows.Clear()

        If PM_M_Code.EditValue <> "" Then
            Dim oc As New ProductionOWPAcceptanceControl
            Dim objList As New List(Of ProductionOWPAcceptanceInfo)

            Dim i As Integer
            Dim Count As Double
            Dim row As DataRow

            objList = oc.ProductionOWPAcceptance_GetList1(PM_M_Code.Text, Nothing, Nothing, Nothing, 2)

            Count = objList.Count
            If Count <= 0 Then
                Exit Sub
            End If

            For i = 0 To Count - 1
                row = ds.Tables("ProductType").NewRow
                row("PM_Type") = objList(i).PM_Type
                ds.Tables("ProductType").Rows.Add(row)
            Next
        End If
        GluType.Text = ""
    End Sub

    Private Sub GluType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GluType.EditValueChanged
        On Error Resume Next

        ''列數據 表中的工序
        GlookP_Name.Properties.DataSource = Nothing      '@ 2012/8/13 添加

        If PM_M_Code.EditValue <> "" And GluType.EditValue <> "" Then
            GlookP_Name.Properties.DisplayMember = "PS_Name"
            GlookP_Name.Properties.ValueMember = "PS_NO"
            Dim pc As New ProcessMainControl
            GlookP_Name.Properties.DataSource = pc.ProcessMain_GetList(Nothing, PM_M_Code.EditValue, "生產加工", GluType.EditValue, Nothing, True)
        End If

    End Sub

    '@ 2012/8/13 添加 按空格鍵彈出下拉菜單
    Private Sub gluSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluSupplier.KeyDown, GluType.KeyDown, GlookP_Name.KeyDown, PM_M_Code.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class
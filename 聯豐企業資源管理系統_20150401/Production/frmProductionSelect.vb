Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Product
Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.Library.Production.Datasetting

Public Class frmProductionSelect

    Dim ds As New DataSet
    Dim pc As New ProcessMainControl
    Dim strCode As String

    Sub LoadProductNo()
        'Dim mc As New ProductController
        'PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        'PM_M_Code.Properties.ValueMember = "PM_M_Code"
        'PM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        Dim pc As New ProcessMainControl
        Dim pdsi As List(Of ProductionDataSettingInfo)
        Dim pdsc As New ProductionDataSettingControl

        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        'PM_M_Code.Properties.DataSource = pc.ProcessMain_GetList1(Nothing, Nothing, Nothing, Nothing)
        PM_M_Code.Properties.DataSource = pc.ProcessMain_GetList3(Nothing, Nothing)
        ' ProcessMain_GetList3


        If strInUserRank = "統計" Then
            pdsi = pdsc.ProductionUser_GetList(strInDepIDFull, Nothing)
            If pdsi.Count > 0 Then
                PM_M_Code.Properties.DataSource = pdsc.ProductionUser_GetList(strInDepIDFull, Nothing)
            End If
        End If


        'PM_M_Code.Properties.DataSource = pc.ProcessMain_GetList1(Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub frmProductionSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbType.EditValue = "生產加工"
        PM_M_Code.EditValue = ""
        gluType.EditValue = ""

        CreateTable()
        LoadProductNo()
        Label5.Text = tempValue2  '載入類型信息--選擇一項或多項工序
        tempValue2 = ""
        Label6.Text = tempValue3
        tempValue3 = ""
        Label7.Text = tempValue4 '載入部門 導入對應部門當前工序數量
        tempValue4 = ""

        If Label5.Text = "外發單管理" Then
            If Label6.Text = "發料" Then
                GridColumn6.Visible = False
                WI_ReQty.Visible = True
                WI_Qty.Visible = True
            Else
                GridColumn6.Visible = False
                WI_Qty.Visible = False
                WI_ReQty.Visible = False
            End If

        ElseIf Label5.Text = "工序組合管理" Then
            GridColumn6.Visible = False
            WI_Qty.Visible = True
        Else

            GridColumn6.Visible = False
            WI_Qty.Visible = False
        End If

        PM_M_Code.Focus()
        PM_M_Code.Select()
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("Material")
            .Columns.Add("M_Code", GetType(String))  '工序編碼--物料編碼
            .Columns.Add("M_Name", GetType(String))  '工序名稱--物料名稱

            .Columns.Add("DPT_ID", GetType(String)) '部門ID--外發部門
            .Columns.Add("WI_Qty", GetType(Double)) '當前外發部門工序數量
            .Columns.Add("WI_ReQty", GetType(Double)) '當前外發部門工序數量


            .Columns.Add("GoIn", GetType(Boolean))
        End With

        Grid.DataSource = ds.Tables("Material")

        With ds.Tables.Add("ProductType")
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluType.Properties.DisplayMember = "PM_Type"
        gluType.Properties.ValueMember = "PM_Type"
        gluType.Properties.DataSource = ds.Tables("ProductType")

    End Sub

    '查詢操作
    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click

        If cbType.EditValue = "" Then
            MsgBox("工藝類型不能為空!")
            Exit Sub
        End If
        If PM_M_Code.EditValue = "" Then
            MsgBox("產品編號不能為空!")
            Exit Sub
        End If
        If gluType.EditValue = "" Then
            MsgBox("類型不能為空!")
            Exit Sub
        End If

        Dim pc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)
        pci = pc.ProcessMain_GetList(Nothing, PM_M_Code.EditValue, cbType.EditValue, gluType.EditValue, Nothing, "True")

        Try
            If pci.Count = 0 Then Exit Sub
            ds.Tables("Material").Clear()
            Dim i As Integer
            For i = 0 To pci.Count - 1
                Dim row As DataRow
                row = ds.Tables("Material").NewRow

                row("M_Code") = pci(i).PS_NO
                row("M_Name") = pci(i).PS_Name

                If Label5.Text = "外發單管理" Then
                    If Label6.Text = "發料" Then
                        Dim pdi As List(Of ProductionDPTWareInventoryInfo)
                        Dim pdc As New ProductionDPTWareInventoryControl
                        pdi = pdc.ProductionDPTWareInventory_GetList("F101", pci(i).PS_NO, Nothing)

                        If pdi.Count = 0 Then
                            row("DPT_ID") = "F101"
                            row("WI_Qty") = 0
                            row("WI_ReQty") = 0
                        Else
                            row("WI_ReQty") = pdi(0).WI_ReQty
                            row("DPT_ID") = "F101"
                            row("WI_Qty") = pdi(0).WI_Qty
                        End If
                    End If
                ElseIf Label5.Text = "工序組合管理" Then
                    Dim pdi As List(Of ProductionDPTWareInventoryInfo)
                    Dim pdc As New ProductionDPTWareInventoryControl
                    pdi = pdc.ProductionDPTWareInventory_GetList(Label7.Text, pci(i).PS_NO, Nothing)

                    If pdi.Count = 0 Then
                        row("DPT_ID") = Label7.Text
                        row("WI_Qty") = 0
                    Else
                        row("DPT_ID") = Label7.Text
                        row("WI_Qty") = pdi(0).WI_Qty
                    End If
                End If

                row("GoIn") = False

                ds.Tables("Material").Rows.Add(row)
            Next
        Catch ex As Exception

        End Try

    End Sub

    '載入到公用部份
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Label5.Text = "外發單管理" Then
            GridView1.Columns("GoIn").OptionsColumn.AllowEdit = True

            tempValue = ""
            Dim i, n As Integer
            n = 0

            If Label6.Text = "收料" Then

                For i = 0 To ds.Tables("Material").Rows.Count - 1

                    If ds.Tables("Material").Rows(i)("GoIn") = True Then

                        If n = 0 Then
                            tempValue = ds.Tables("Material").Rows(i)("M_Code")
                            n = n + 1
                        Else
                            tempValue = tempValue & "," & ds.Tables("Material").Rows(i)("M_Code")
                            n = n + 1
                        End If
                    End If
                Next
                tempCode = tempValue
                tempValue = ""
            Else
                For i = 0 To ds.Tables("Material").Rows.Count - 1

                    If ds.Tables("Material").Rows(i)("GoIn") = True Then
                        'If ds.Tables("Material").Rows(i)("WI_Qty") <> 0 Then   '2012-7-27
                        If n = 0 Then
                            tempValue = ds.Tables("Material").Rows(i)("M_Code")
                            n = n + 1
                        Else
                            tempValue = tempValue & "," & ds.Tables("Material").Rows(i)("M_Code")
                            n = n + 1
                        End If
                        'Else
                        '    MsgBox("當前工序在外發部庫存為0,不允許進行外發操作!")
                        '    Exit Sub
                        'End If

                    End If
                Next
                tempCode = tempValue
                tempValue = ""
            End If

        ElseIf Label5.Text = "更改單管理" Then
            GridView1.Columns("GoIn").OptionsColumn.AllowEdit = True

            tempValue = ""
            Dim i, n As Integer
            n = 0

            For i = 0 To ds.Tables("Material").Rows.Count - 1

                If ds.Tables("Material").Rows(i)("GoIn") = True Then

                    If n = 0 Then
                        tempValue = ds.Tables("Material").Rows(i)("M_Code")
                        n = n + 1
                    Else
                        tempValue = tempValue & "," & ds.Tables("Material").Rows(i)("M_Code")
                        n = n + 1
                    End If
                End If
            Next
            tempCode = tempValue
            tempValue = ""
        ElseIf Label5.Text = "工序組合管理" Then
            GridView1.Columns("GoIn").OptionsColumn.AllowEdit = True

            tempValue = ""
            Dim i, n As Integer
            n = 0

            For i = 0 To ds.Tables("Material").Rows.Count - 1

                If ds.Tables("Material").Rows(i)("GoIn") = True Then
                    If ds.Tables("Material").Rows(i)("WI_Qty") <> 0 Then
                        If n = 0 Then
                            tempValue = ds.Tables("Material").Rows(i)("M_Code")
                            n = n + 1
                        Else
                            tempValue = tempValue & "," & ds.Tables("Material").Rows(i)("M_Code")
                            n = n + 1
                        End If
                    Else
                        MsgBox("當前工序在選定部門的庫存為0,不允許進行組合操作!")
                        Exit Sub
                    End If

                End If
            Next
            tempCode = tempValue
            tempValue = ""
        ElseIf Label5.Text = "工序拆分管理" Then
            GridView1.Columns("GoIn").OptionsColumn.AllowEdit = True

            tempValue = ""
            Dim i, n As Integer
            n = 0

            For i = 0 To ds.Tables("Material").Rows.Count - 1

                If ds.Tables("Material").Rows(i)("GoIn") = True Then

                    If n = 0 Then
                        tempValue = ds.Tables("Material").Rows(i)("M_Code")
                        n = n + 1
                    Else
                        tempValue = tempValue & "," & ds.Tables("Material").Rows(i)("M_Code")
                        n = n + 1
                    End If

                End If
            Next
            tempCode = tempValue
            tempValue = ""
        Else
            GridView1.Columns("GoIn").OptionsColumn.AllowEdit = False

            strCode = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Code")
            tempCode = strCode  'tempCode全局共用變量
            tempValue9 = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "M_Name")  '@2012/7/27 添加

        End If

        Me.Close()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged
        On Error Resume Next

        Dim pcc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)

        ds.Tables("ProductType").Clear()

        pci = pcc.ProcessMain_GetList1(Nothing, PM_M_Code.EditValue, cbType.EditValue, Nothing)
        If pci.Count = 0 Then Exit Sub

        Dim i As Integer
        For i = 0 To pci.Count - 1
            Dim row As DataRow
            row = ds.Tables("ProductType").NewRow
            row("M_Code") = pci(i).M_Code
            row("PM_Type") = pci(i).Type3ID

            ds.Tables("ProductType").Rows.Add(row)
        Next
    End Sub

    '@2012/4/13 添加 按空格鍵顯示下拉菜單
    Private Sub gluType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluType.KeyDown, PM_M_Code.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.showpopup()
        End If
    End Sub

    Private Sub gluType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluType.EditValueChanged
        If cbType.EditValue = "" Then
            Exit Sub
        End If
        If PM_M_Code.EditValue = "" Then
            Exit Sub
        End If

        cmdSelect_Click(Nothing, Nothing)
    End Sub

    '@ 2012/1/7 添加，當控件內容發生改變，且PM_M_Code控件內容不為空時，加載相應的內容到gluType控件
    '此過程調用以下過程：
    'PM_M_Code_EditValueChanged()
    Private Sub cbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbType.SelectedIndexChanged
        If PM_M_Code.Text <> "" Then
            PM_M_Code_EditValueChanged(Nothing, Nothing)
        End If
    End Sub

    '@ 2012/7/27 添加
    Private Sub RepositoryItemCheckEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.EditValueChanged
        If Label5.Text = "物料出庫轉工序" Then
            If sender.checked = True Then
                Dim i%
                For i = 0 To GridView1.RowCount - 1
                    If i <> GridView1.FocusedRowHandle Then
                        If GridView1.GetRowCellValue(i, "GoIn") = True Then
                            MsgBox("只能選擇一個工序！", 64, "提示")
                            sender.checked = False
                            Exit Sub
                        End If
                    End If
                Next
            End If
        End If
    End Sub
End Class
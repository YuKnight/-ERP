Imports LFERP.Library.Orders

Public Class frmOrdersSubNeed
    Dim onc As New OrdersSubNeedController
    Dim ds As New DataSet

    Private Sub frmOrdersSubNeed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()

        If Me.lblTittle.Text = "批次需求單-新增" Then
            Dim i%

            Me.Text = "批次需求單-新增"
            txtON_ID.Text = GetID()
            'ON_Remark.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None

            LoadAddData()

        ElseIf Me.lblTittle.Text = "批次需求單-查看" Then
            Me.Text = "批次需求單-查看"
            LoadData()
            ON_SalesDptCheck.Visible = True
            ON_SalesDptCheck.OptionsColumn.ReadOnly = True
            ON_OperationDptCheck.Visible = True
            ON_OperationDptCheck.OptionsColumn.ReadOnly = True
            ON_Remark.OptionsColumn.ReadOnly = True
            btnOK.Enabled = False
        ElseIf Me.lblTittle.Text = "批次需求單-營業部審核" Then
            Me.Text = "批次需求單-營業部審核"
            LoadData()
            ON_SalesDptCheck.Visible = True
            ON_Remark.OptionsColumn.ReadOnly = True
        ElseIf Me.lblTittle.Text = "批次需求單-營運部審核" Then
            Me.Text = "批次需求單-營運部審核"
            LoadData()
            ON_SalesDptCheck.Visible = True
            ON_SalesDptCheck.OptionsColumn.ReadOnly = True
            ON_OperationDptCheck.Visible = True
            ON_Remark.OptionsColumn.ReadOnly = True
        End If
    End Sub

    Function GetID() As String
        Dim oni As List(Of OrdersSubNeedInfo)
        Dim strID As String
        strID = "ON" & Format(Now, "yyMM")
        oni = onc.OrdersSubNeed_GetList(Nothing, strID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If oni.Count <= 0 Then
            GetID = strID & "001"
        Else
            GetID = strID & Mid((CInt(Mid(oni(0).ON_ID, 7)) + 1001), 2)
        End If

    End Function

    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("OrdersSubNeed").Columns
            .Add("AutoID", GetType(String))
            .Add("M_Code", GetType(String))
            .Add("M_Name", GetType(String))
            .Add("M_Gauge", GetType(String))
            .Add("M_Unit", GetType(String))

            .Add("M_Weight", GetType(String))
            .Add("ON_NeedQty", GetType(String))
            .Add("M_CodeType", GetType(String))
            .Add("WI_Qty", GetType(String))
            .Add("WI_UsableQty", GetType(String))

            .Add("ON_PrepareQty", GetType(String))
            .Add("ON_NeedPurchaseQty", GetType(String))
            .Add("ON_Remark", GetType(String))
            .Add("ON_SalesDptCheck", GetType(String))
            .Add("ON_OperationDptCheck", GetType(String))
        End With

        GridControl1.DataSource = ds.Tables("OrdersSubNeed")
    End Sub

    Sub LoadAddData()
        Dim oni As List(Of OrdersSubNeedInfo)
        Dim row As DataRow
        Dim i%

        oni = onc.OrdersSubNeed_AddGetList(txtOS_BatchID.Text, "W0301", "'原材料','輔助材料'")
        For i = 0 To oni.Count - 1
            row = ds.Tables("OrdersSubNeed").NewRow

            row("M_Code") = oni(i).M_Code
            row("M_Name") = oni(i).M_Name
            row("M_Gauge") = oni(i).M_Gauge
            row("M_Unit") = oni(i).M_Unit
            row("M_Weight") = Val(oni(i).M_Weight)

            row("ON_NeedQty") = Val(oni(i).ON_NeedQty)
            row("M_CodeType") = oni(i).M_CodeType
            row("WI_Qty") = Val(oni(i).WI_Qty)
            If Val(oni(i).WI_UsableQty) < 0 Then
                row("WI_UsableQty") = 0
            Else
                row("WI_UsableQty") = Val(oni(i).WI_UsableQty)
            End If


            If Val(row("WI_UsableQty")) >= Val(oni(i).ON_NeedQty) Then
                row("ON_PrepareQty") = Val(row("WI_UsableQty"))
                row("ON_NeedPurchaseQty") = 0
            Else
                row("ON_PrepareQty") = Val(row("WI_UsableQty"))
                row("ON_NeedPurchaseQty") = oni(i).ON_NeedQty - row("WI_UsableQty")
            End If

            row("ON_Remark") = ""

            ds.Tables("OrdersSubNeed").Rows.Add(row)
        Next

    End Sub

    Sub AddDateSave()
        Dim oni As New OrdersSubNeedInfo
        Dim i As Integer

        oni.ON_ID = txtON_ID.Text
        oni.OS_BatchID = Me.txtOS_BatchID.Text
        oni.OS_Qty = Me.txtOS_Qty.Text
        oni.ON_AddUser = InUserID
        oni.ON_AddDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

        For i = 0 To GridView1.RowCount - 1
            oni.M_Code = GridView1.GetRowCellValue(i, "M_Code")
            oni.M_Weight = GridView1.GetRowCellValue(i, "M_Weight")
            oni.ON_NeedQty = GridView1.GetRowCellValue(i, "ON_NeedQty")
            oni.M_CodeType = GridView1.GetRowCellValue(i, "M_CodeType")
            oni.ON_PrepareQty = GridView1.GetRowCellValue(i, "ON_PrepareQty")

            oni.ON_NeedPurchaseQty = GridView1.GetRowCellValue(i, "ON_NeedPurchaseQty")
            oni.ON_PurchaseState = "處理中"
            oni.ON_Remark = GridView1.GetRowCellValue(i, "ON_Remark")

            If onc.OrdersSubNeed_Add(oni) = False Then
                MsgBox("新增失敗!", 64, "提示")
                Exit Sub
            End If
        Next

        MsgBox("新增完成!", 64, "提示")
        Me.Close()
    End Sub

    Sub CheckDateSave()
        Dim onii As New OrdersSubNeedInfo
        Dim i As Integer

        For i = 0 To GridView1.RowCount - 1
            onii.AutoID = GridView1.GetRowCellValue(i, "AutoID")
            If Me.lblTittle.Text = "批次需求單-營業部審核" Then
                onii.ON_SalesDptCheck = GridView1.GetRowCellValue(i, "ON_SalesDptCheck")
                onii.ON_SalesDptCheckUser = InUserID
                onii.ON_SalesDptCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
            ElseIf Me.lblTittle.Text = "批次需求單-營運部審核" Then
                onii.ON_SalesDptCheck = GridView1.GetRowCellValue(i, "ON_SalesDptCheck")
                '因為ON_SalesDptCheck類型是Boolean,賦nothing值時自動轉換為false,因此需要重新傳值

                onii.ON_OperationDptCheck = GridView1.GetRowCellValue(i, "ON_OperationDptCheck")
                onii.ON_OperationDptCheckUser = InUserID
                onii.ON_OperationDptCheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

                If onii.ON_OperationDptCheck = True Then
                    onii.ON_PurchaseState = "已遞交採購"
                Else
                    onii.ON_PurchaseState = "處理中"
                End If

            End If

            If onc.OrdersSubNeed_Update(onii) = False Then
                MsgBox("審核失敗!", 64, "提示")
                Exit Sub
            End If
        Next

        MsgBox("審核完成!", 64, "提示")
        Me.Close()
    End Sub

    Sub LoadData()
        Dim oni As List(Of OrdersSubNeedInfo)
        'Dim i As Integer
        If Me.lblTittle.Text = "批次需求單-營業部審核" Then
            oni = onc.OrdersSubNeed_GetList(Nothing, txtON_ID.Text, Nothing, Nothing, Nothing, "W0301", Nothing, Nothing, Nothing, Nothing, Nothing, "False")
        Else
            oni = onc.OrdersSubNeed_GetList(Nothing, txtON_ID.Text, Nothing, Nothing, Nothing, "W0301", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        End If

        If oni.Count > 0 Then
            Me.txtOS_BatchID.Text = oni(0).OS_BatchID
            txtOS_Qty.Text = oni(0).OS_Qty
            GridControl1.DataSource = oni
        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            If GridView1.RowCount <= 0 Then Exit Sub

            If Me.lblTittle.Text = "批次需求單-新增" Then
                AddDateSave()
            Else
                CheckDateSave()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub RepositoryItemCheckEdit2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit2.CheckedChanged
        If sender.checked = True Then
            If GridView1.GetFocusedRowCellValue(ON_SalesDptCheck) = False Then
                MsgBox("此記錄營業部尚未審核，不能進行下一級審核!", 64, "提示")
                sender.checked = False
            End If
        End If
    End Sub
End Class
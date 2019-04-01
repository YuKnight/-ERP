Imports LFERP.Library.WareHouse.WareInput
Imports LFERP.Library.WareHouse.WareOut


Public Class frmBatchCodeSelect

    Dim ds As New DataSet

    Private Sub frmBatchCodeSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Label3.Text = tempValue
        txtCode.Focus()
        txtCode.Text = ""
        tempValue = ""
        Grid.DataSource = Nothing
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")
        DateEdit2.Text = Format(Now, "yyyy/MM/dd")

        If Mid(Label3.Text, 1, 3) = "W05" Then
            OS_BatchID.Visible = True
        Else
            OS_BatchID.Visible = False
        End If

    End Sub

    '創建當前表
    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("BatchWareHouse")

            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("InputQty", GetType(String))
            .Columns.Add("OutputQty", GetType(String))
            .Columns.Add("ExtralQty", GetType(String))

        End With
        Grid.DataSource = ds.Tables("BatchWareHouse")
    End Sub

    '查詢當前物料編碼所有批次入庫出庫記錄（前提條件：必須存在入庫記錄）
    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        CreateTable()

        If DateEdit1.Text = "" Then
            MsgBox("開始日期不能為空!")
            Exit Sub
        End If
        If DateEdit2.Text = "" Then
            MsgBox("截止日期不能為空!")
            Exit Sub
        End If

        If Len(txtCode.Text.Trim) = 0 Then
            tempValue = Nothing
        Else
            If Len(txtCode.Text) <> 17 Then
                MsgBox("請正確輸入物料編碼")
                txtCode.Text = ""
                Exit Sub
            Else
                tempValue = txtCode.Text
            End If
        End If


        Dim wi As List(Of WareInputInfo)
        Dim wc As New WareInputContraller
        Dim wo As List(Of WareOutInfo)
        Dim woc As New WareOutController

        If Mid(Label3.Text, 1, 3) = "W05" Then
            wi = wc.WareInput_GetQty1(Nothing, tempValue, Label3.Text, True, DateEdit1.Text, DateEdit2.Text)
            wo = woc.WareOut_GetQty1(Nothing, tempValue, Label3.Text, True, DateEdit1.Text, DateEdit2.Text)

            If wi.Count = 0 Then
                MsgBox("此日期範圍內沒有此物料相關的批次入庫記錄!")
                Exit Sub
            Else
                Dim i As Integer
                For i = 0 To wi.Count - 1
                    Dim inputQty, outputQty As Single

                    Dim row As DataRow
                    row = ds.Tables("BatchWareHouse").NewRow

                    Dim mc As New LFERP.Library.Material.MaterialController
                    Dim objInfo As New LFERP.Library.Material.MaterialInfo
                    objInfo = mc.MaterialCode_Get(txtCode.Text)

                    row("M_Code") = objInfo.M_Code
                    row("M_Name") = objInfo.M_Name
                    row("M_Gauge") = objInfo.M_Gauge
                    row("OS_BatchID") = wi(i).OS_BatchID

                    Dim wi1 As List(Of WareInputInfo)
                    wi1 = wc.WareInput_GetQty1(wi(i).OS_BatchID, txtCode.Text, Label3.Text, True, DateEdit1.Text, DateEdit2.Text)
                    If wi1.Count = 0 Then
                        inputQty = 0
                    Else
                        inputQty = wi1(0).GetQty1
                    End If
                    row("InputQty") = inputQty
                    Dim wo1 As List(Of WareOutInfo)
                    wo1 = woc.WareOut_GetQty1(wi(i).OS_BatchID, txtCode.Text, Label3.Text, True, DateEdit1.Text, DateEdit2.Text)
                    If wo1.Count = 0 Then
                        outputQty = 0
                    Else
                        outputQty = wo1(0).OutGetQty1
                    End If
                    row("OutputQty") = outputQty
                    row("ExtralQty") = inputQty - outputQty

                    ds.Tables("BatchWareHouse").Rows.Add(row)

                Next

            End If
        Else
            wi = wc.WareInput_GetQty2(tempValue, Label3.Text, True, DateEdit1.Text, DateEdit2.Text)
            wo = woc.WareOut_GetQty2(tempValue, Label3.Text, True, DateEdit1.Text, DateEdit2.Text)


            If wi.Count = 0 Then
                MsgBox("此日期範圍內沒有此物料入庫記錄!")
                Exit Sub
            Else
                Dim i As Integer
                For i = 0 To wi.Count - 1
                    Dim inputQty, outputQty As Single

                    Dim row As DataRow
                    row = ds.Tables("BatchWareHouse").NewRow

                    Dim mc As New LFERP.Library.Material.MaterialController
                    Dim objInfo As New LFERP.Library.Material.MaterialInfo
                    objInfo = mc.MaterialCode_Get(wi(i).M_Code)

                    row("M_Code") = objInfo.M_Code
                    row("M_Name") = objInfo.M_Name
                    row("M_Gauge") = objInfo.M_Gauge
                    row("OS_BatchID") = ""

                    Dim wi1 As List(Of WareInputInfo)
                    wi1 = wc.WareInput_GetQty2(wi(i).M_Code, Label3.Text, True, DateEdit1.Text, DateEdit2.Text)
                    If wi1.Count = 0 Then
                        inputQty = 0
                    Else
                        inputQty = wi1(0).GetQty1
                    End If
                    row("InputQty") = inputQty
                    Dim wo1 As List(Of WareOutInfo)
                    wo1 = woc.WareOut_GetQty2(wi(i).M_Code, Label3.Text, True, DateEdit1.Text, DateEdit2.Text)
                    If wo1.Count = 0 Then
                        outputQty = 0
                    Else
                        outputQty = wo1(0).OutGetQty1
                    End If
                    row("OutputQty") = outputQty
                    row("ExtralQty") = inputQty - outputQty

                    ds.Tables("BatchWareHouse").Rows.Add(row)

                Next

            End If
        End If

        tempValue = ""

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = Chr(13) Then
            cmdSelect_Click(Nothing, Nothing)
        End If
    End Sub

End Class
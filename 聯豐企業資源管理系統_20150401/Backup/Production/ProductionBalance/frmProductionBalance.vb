Imports LFERP.Library.ProductionBalance
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionDPTWareInventory

Public Class frmProductionBalance

    Dim ds As New DataSet

    Dim uc As New WorkGroupControl

    Sub LoadBriName()
        Me.RepositoryItemLookUpEdit1.DataSource = uc.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing, Nothing)
        Me.RepositoryItemLookUpEdit1.DisplayMember = "DepName"
        Me.RepositoryItemLookUpEdit1.ValueMember = "DepID"
    End Sub

    Private Sub frmProductionBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        LoadBriName()

        Label12.Text = tempValue3 '編號
        Label13.Text = tempValue2 '類型
        tempValue2 = ""
        tempValue3 = ""
        txtID.Enabled = False
        Select Case Label3.Text
            Case "部門變更單"
                If Edit = False Then
                    DateEdit1.Text = Format(Now, "yyyy/MM/dd")
                    Label5.Text = UserName
                Else
                    LoadData(Label2.Text)
                    Me.Text = "變更單--修改" & txtID.Text
                End If
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "Preview"
                LoadData(Label2.Text)
                cmdSave.Visible = False
                Me.Text = "變更單--查看" & txtID.Text
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "Check"
                LoadData(Label2.Text)
                Me.Text = "變更單--審核" & txtID.Text
                XtraTabControl1.SelectedTabPage = XtraTabPage2
        End Select

    End Sub

    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("Balance")

            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("Type3ID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
            .Columns.Add("WI_Qty", GetType(Single))
            .Columns.Add("WI_ReQty", GetType(Single))
            .Columns.Add("B_Remark", GetType(String))
            .Columns.Add("DPT_ID", GetType(String))

        End With

        With ds.Tables.Add("DelBalance")
            .Columns.Add("B_ID", GetType(String))
            .Columns.Add("AutoID", GetType(String))
        End With
        Grid.DataSource = ds.Tables("Balance")

    End Sub

    Sub LoadData(ByVal B_ID As String)
        ds.Tables("Balance").Clear()
        Dim pbi As List(Of ProductionBalanceInfo)
        Dim pbc As New ProductionBalanceControl
        pbi = pbc.ProductionBalance_GetList(B_ID, Nothing, Nothing, Nothing, Nothing)

        If pbi.Count = 0 Then
            MsgBox("沒有此單數據記錄!")
            Exit Sub
        Else

            txtID.Text = pbi(0).B_ID
            DateEdit1.Text = Format(pbi(0).B_AddDate, "yyyy/MM/dd")
            Label5.Text = pbi(0).ActionName   '顯示的操作員姓名
            CheckEdit1.Checked = pbi(0).B_Check
            Label8.Text = pbi(0).CheckActionName
            Label10.Text = Format(pbi(0).B_CheckDate, "yyyy/MM/dd HH:mm:ss")
            MemoEdit1.Text = pbi(0).B_CheckRemark


            Dim row As DataRow
            Dim i As Integer
            For i = 0 To pbi.Count - 1

                row = ds.Tables("Balance").NewRow

                row("AutoID") = pbi(i).AutoID
                row("PM_M_Code") = pbi(i).PM_M_Code
                row("Type3ID") = pbi(i).Type3ID
                row("DPT_ID") = pbi(i).DPT_ID
                row("M_Code") = pbi(i).M_Code
                row("PS_Name") = pbi(i).PS_Name
                row("WI_Qty") = pbi(i).WI_Qty
                row("WI_ReQty") = pbi(i).WI_ReQty
                row("B_Remark") = pbi(i).B_Remark

                ds.Tables("Balance").Rows.Add(row)

            Next

        End If


    End Sub

    Public Function GetID() As String

        Dim pbi As New ProductionBalanceInfo
        Dim pbc As New ProductionBalanceControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pbi = pbc.ProductionBalance_GetID(strA)
        If pbi Is Nothing Then
            GetID = "PB" & strA & "0001"
        Else
            GetID = "PB" + strA + Mid((CInt(Mid(pbi.B_ID, 7)) + 10001), 2)
        End If

    End Function

    Sub DataNew()
        Dim pi As New ProductionBalanceInfo
        Dim pc As New ProductionBalanceControl

        txtID.Text = GetID()
        pi.B_ID = txtID.Text
        pi.B_Action = InUserID
        pi.B_AddDate = DateEdit1.Text

        Dim i As Integer
        For i = 0 To ds.Tables("Balance").Rows.Count - 1

            pi.DPT_ID = ds.Tables("Balance").Rows(i)("DPT_ID")
            pi.M_Code = ds.Tables("Balance").Rows(i)("M_Code")
            pi.WI_Qty = ds.Tables("Balance").Rows(i)("WI_Qty")
            pi.WI_ReQty = ds.Tables("Balance").Rows(i)("WI_ReQty")
            pi.B_Remark = ds.Tables("Balance").Rows(i)("B_Remark")

            pc.ProductionBalance_Add(pi)
        Next
        MsgBox("已保存,單號: " & txtID.Text & " ")
        Me.Close()
    End Sub

    Sub DataEdit()

        Dim pi As New ProductionBalanceInfo
        Dim pc As New ProductionBalanceControl

        pi.B_ID = txtID.Text
        pi.B_Action = InUserID
        pi.B_AddDate = DateEdit1.Text

        '更新刪除的記錄
        If ds.Tables("DelBalance").Rows.Count > 0 Then
            Dim m As Integer
            For m = 0 To ds.Tables("DelBalance").Rows.Count - 1

                If Not IsDBNull(ds.Tables("DelBalance").Rows(m)("AutoID")) Then
                    pc.ProductionBalance_Delete(Nothing, ds.Tables("DelBalance").Rows(m)("AutoID"))
                End If
            Next m
        End If

        '判斷當前記錄中部門信息是否有空值~~!!
        Dim j As Integer

        For j = 0 To ds.Tables("Balance").Rows.Count - 1
            If Len(ds.Tables("Balance").Rows(j)("DPT_ID")) = 0 Then
                MsgBox("部門編號不能為空! ")
                Exit Sub
            End If
        Next

        Dim i As Integer
        For i = 0 To ds.Tables("Balance").Rows.Count - 1

            If Not IsDBNull(ds.Tables("Balance").Rows(i)("AutoID")) Then

                pi.AutoID = ds.Tables("Balance").Rows(i)("AutoID")
                pi.DPT_ID = ds.Tables("Balance").Rows(i)("DPT_ID")
                pi.M_Code = ds.Tables("Balance").Rows(i)("M_Code")
                pi.WI_Qty = ds.Tables("Balance").Rows(i)("WI_Qty")
                pi.WI_ReQty = ds.Tables("Balance").Rows(i)("WI_ReQty")
                pi.B_Remark = ds.Tables("Balance").Rows(i)("B_Remark")

                pc.ProductionBalance_Update(pi)

            ElseIf IsDBNull(ds.Tables("Balance").Rows(i)("AutoID")) Then

                pi.DPT_ID = ds.Tables("Balance").Rows(i)("DPT_ID")
                pi.M_Code = ds.Tables("Balance").Rows(i)("M_Code")
                pi.WI_Qty = ds.Tables("Balance").Rows(i)("WI_Qty")
                pi.WI_ReQty = ds.Tables("Balance").Rows(i)("WI_ReQty")
                pi.B_Remark = ds.Tables("Balance").Rows(i)("B_Remark")

                pc.ProductionBalance_Add(pi)
            End If
        Next
        MsgBox("已保存,單號: " & txtID.Text & " ")
        Me.Close()
    End Sub

    Sub UpdateCheck() '審核操作--完成部門結餘數的變更(一旦變更此單不允許在此操作!)

        Dim pi As New ProductionBalanceInfo
        Dim pc As New ProductionBalanceControl

        pi.B_ID = txtID.Text
        pi.B_Check = CheckEdit1.Checked
        pi.B_CheckAction = InUserID
        pi.B_CheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        pi.B_CheckRemark = MemoEdit1.Text

        pc.ProductionBalance_UpdateCheck(pi) ''審核完成

        If CheckEdit1.Checked = True Then
            Dim i As Integer

            '--------------------------------------------變更當前工序部門結餘數
            For i = 0 To ds.Tables("Balance").Rows.Count - 1

                Dim Qty, Qty1 As Single '定義數量(得到當前部門此工序數量)
                Dim pdi As List(Of ProductionDPTWareInventoryInfo)
                Dim pdc As New ProductionDPTWareInventoryControl

                pdi = pdc.ProductionDPTWareInventory_GetList(ds.Tables("Balance").Rows(i)("DPT_ID"), ds.Tables("Balance").Rows(i)("M_Code"), Nothing)

                If pdi.Count = 0 Then
                    Qty = 0
                    Qty1 = 0
                Else
                    Qty = pdi(0).WI_Qty '大貨結餘
                    Qty1 = pdi(0).WI_ReQty  '返修結餘
                End If

                Dim pdi1 As New ProductionDPTWareInventoryInfo

                pdi1.DPT_ID = ds.Tables("Balance").Rows(i)("DPT_ID")  '當前某條記錄部門
                pdi1.M_Code = ds.Tables("Balance").Rows(i)("M_Code") '當前某條記錄工序編號(物料編碼)
                'pdi1.WI_Qty = Qty + CSng(ds.Tables("Balance").Rows(i)("WI_Qty")) '當前某條記錄數量,一旦審核此部門工序數量變更為此數量且不允許再次更改!!
                'pdi1.WI_ReQty = Qty1 + CSng(ds.Tables("Balance").Rows(i)("WI_ReQty"))

                pdi1.WI_Qty = CSng(ds.Tables("Balance").Rows(i)("WI_Qty")) '直接變更數據
                pdi1.WI_ReQty = CSng(ds.Tables("Balance").Rows(i)("WI_ReQty"))

                pdc.UpdateProductionField_Qty(pdi1)

            Next

        End If
        '--------------------------------------------

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label3.Text
            Case "部門變更單"
                If Edit = False Then
                    DataNew()
                Else
                    DataEdit()
                End If
            Case "Check"
                UpdateCheck()
        End Select

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    '添加子項目(需變更的部門工序數量)
    Private Sub MenuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAdd.Click
        tempCode = ""
        tempValue2 = "更改單管理"

        frmProductionSelect.ShowDialog()
        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempCode, ",")
            n = Len(Replace(tempCode, ",", "," & "*")) - Len(tempCode)
            For i = 0 To n
                If arr(i) = "" Then
                    Exit Sub
                End If
                AddRow(arr(i))
            Next

            'AddRow(tempCode)
        End If
        tempCode = ""
    End Sub

    Sub AddRow(ByVal M_Code As String) '通過工序編號導入相應信息(工藝類型,產品編號,類型,工序名稱等)

        If M_Code = "" Then
        Else
            Dim pic As New ProcessMainControl
            Dim pci As List(Of ProcessMainInfo)
            pci = pic.ProcessSub_GetList(Nothing, M_Code, Nothing, Nothing, Nothing, Nothing)
            If pci.Count = 0 Then Exit Sub
            Dim i As Integer

            For i = 0 To ds.Tables("Balance").Rows.Count - 1
                If M_Code = ds.Tables("Balance").Rows(i)("M_Code") Then
                    MsgBox("一張單不允許有重復相同工序編碼信息....")
                    Exit Sub
                End If
            Next

            For i = 0 To pci.Count - 1

                Dim row As DataRow
                row = ds.Tables("Balance").NewRow

                'row("Pro_Type") = pci(i).Pro_Type
                row("PM_M_Code") = pci(i).PM_M_Code
                row("PM_Type") = pci(i).Type3ID  '實際類型
                row("M_Code") = M_Code
                row("PS_Name") = pci(i).PS_Name
                row("WI_Qty") = 0
                row("WI_ReQty") = 0
                row("DPT_ID") = ""
                row("B_Remark") = ""

                ds.Tables("Balance").Rows.Add(row)
            Next
        End If
        GridView1.MoveLast()
    End Sub

    '刪除子項目(取消需變更的部門工序數量)
    Private Sub MenuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDel.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelBalance").NewRow

            row("AutoID") = ds.Tables("Balance").Rows(GridView1.FocusedRowHandle)("AutoID")

            ds.Tables("DelBalance").Rows.Add(row)
        End If
        ds.Tables("Balance").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub
End Class
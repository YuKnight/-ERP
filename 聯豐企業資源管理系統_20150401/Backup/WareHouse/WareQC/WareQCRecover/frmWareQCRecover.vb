Imports LFERP.Library.WareHouse.WareQCRecover
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.WareHouse.WareQCSend


Public Class frmWareQCRecover

    Dim ds As New DataSet

    Private Sub frmWareQCRecover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label9.Text = tempValue
        txtNO.Text = tempValue2
        tempValue = ""
        tempValue2 = ""
        txtWHID.EditValue = "W0102"
        txtWHID.Enabled = False
        Label5.Text = UserName
        CreateTable()

        Select Case Label9.Text

            Case "抽檢歸還"

                If Edit = True Then
                    Me.Text = "抽檢歸還--修改" & "[" & txtNO.Text & "]"
                    LoadData(txtNO.Text)

                    txtNO.Enabled = False
                    txtWHID.Enabled = False
                Else
                    Me.Text = "抽檢歸還--新增"
                    txtDate.Text = Format(Now, "yyyy/MM/dd")
                    txtNO.Text = ""
                End If

            Case "PreView"
                Me.Text = "抽檢歸還--查看" & "[" & txtNO.Text & "]"
                LoadData(txtNO.Text)
                cmdSave.Visible = False
            Case "Check"
                Me.Text = "抽檢歸還--審核" & "[" & txtNO.Text & "]"
                LoadData(txtNO.Text)
                WareQCRecoverSubAdd.Enabled = False
                WareQCRecoverSubDel.Enabled = False
        End Select


    End Sub
    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("WareQCRecover")

            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("WQS_NO", GetType(String))
            .Columns.Add("WQR_NO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("WQR_Qty", GetType(Single))
            .Columns.Add("WH_ID", GetType(String))
            .Columns.Add("WQR_Date", GetType(String))
            .Columns.Add("WQR_Action", GetType(String))
            .Columns.Add("WQR_Check", GetType(Boolean))
            .Columns.Add("WQR_CheckActon", GetType(String))
            .Columns.Add("WQR_Remark", GetType(String))

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))

        End With

        With ds.Tables.Add("DelData")
            .Columns.Add("WQR_NO", GetType(String))
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
        End With

        Grid1.DataSource = ds.Tables("WareQCRecover")

    End Sub

    Function LoadData(ByVal WQR_NO As String) As Boolean
        LoadData = True
        Dim qi As New List(Of WareQCRecoverInfo)
        Dim qc As New WareQCRecoverController
        Try
            qi = qc.WareQCRecover_GetList(WQR_NO, Nothing, Nothing, Nothing, Nothing, Nothing)
            If qi Is Nothing Then
                '沒有數據
                LoadData = False
                Exit Function
            End If
            txtWHID.Text = qi(0).WH_ID
            txtDate.EditValue = Format(qi(0).WQR_Date, "yyyy/MM/dd")
            Label5.Text = qi(0).UserName
            If qi(0).WQR_Check = False Then
                CheckEdit1.Checked = False
            Else
                CheckEdit1.Checked = True
            End If
            Label8.Text = qi(0).WQR_CheckAction

            ds.Tables("WareQCRecover").Rows.Clear()

            LoadSub(qc.WareQCRecover_GetList(WQR_NO, Nothing, Nothing, Nothing, Nothing, Nothing))

        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try

    End Function

    Sub LoadSub(ByVal dlist As List(Of WareQCRecoverInfo))
        On Error Resume Next

        If dlist Is Nothing Then Exit Sub

        Dim i As Integer
        Dim row As DataRow

        For i = 0 To dlist.Count - 1

            row = ds.Tables("WareQCRecover").NewRow

            row("WQS_NO") = dlist(i).WQS_NO

            row("AutoID") = dlist(i).AutoID

            row("M_Code") = dlist(i).M_Code
            row("M_Name") = dlist(i).M_Name
            row("M_Gauge") = dlist(i).M_Gauge

            row("WQR_Qty") = dlist(i).WQR_Qty
            row("WQR_Remark") = dlist(i).WQR_Remark

            ds.Tables("WareQCRecover").Rows.Add(row)

        Next

    End Sub

    Public Function GetRNO() As String

        Dim wqi As New WareQCRecoverInfo
        Dim wqc As New WareQCRecoverController
        Dim str As String
        str = Format(Now, "yyMM")
        wqi = wqc.WareQCRecover_GetNO(str)
        If wqi Is Nothing Then
            GetRNO = "WQR" & str & "0001"
        Else
            GetRNO = "WQR" & str & Mid((CInt(Mid(wqi.WQR_NO, 8)) + 10001), 2)
        End If
    End Function
    Public Function GetAutoID() As String
        Dim wqi As New WareQCRecoverInfo
        Dim wqc As New WareQCRecoverController
        Dim str As String
        str = "A"
        wqi = wqc.WareQCRecover_GetAutoID(str)
        If wqi Is Nothing Then
            GetAutoID = str & "000000001"
        Else
            GetAutoID = str & Mid((CInt(Mid(wqi.AutoID, 2)) + 1000000001), 2)
        End If

    End Function

    Sub DataNew()
        Dim wqi As New WareQCRecoverInfo
        Dim wqc As New WareQCRecoverController

        txtNO.Text = GetRNO()

        wqi.WQR_NO = txtNO.Text
        wqi.WH_ID = txtWHID.Text
        wqi.WQR_Date = txtDate.Text
        Label5.Text = UserName
        wqi.WQR_Action = InUserID

        Dim i As Integer

        For i = 0 To ds.Tables("WareQCRecover").Rows.Count - 1

            wqi.WQS_NO = ds.Tables("WareQCRecover").Rows(i)("WQS_NO")

            ds.Tables("WareQCRecover").Rows(i)("AutoID") = GetAutoID()
            wqi.AutoID = ds.Tables("WareQCRecover").Rows(i)("AutoID")

            wqi.M_Code = ds.Tables("WareQCRecover").Rows(i)("M_Code")

            If IsDBNull(ds.Tables("WareQCRecover").Rows(i)("WQR_Qty")) Then
                wqi.WQR_Qty = Nothing
            Else
                wqi.WQR_Qty = CSng(ds.Tables("WareQCRecover").Rows(i)("WQR_Qty"))
            End If
            wqi.WQR_Remark = ds.Tables("WareQCRecover").Rows(i)("WQR_Remark")

            wqc.WareQCRecover_Add(wqi)

        Next

        MsgBox("添加成功", , "提示")
        Me.Close()

    End Sub

    Sub DataEdit()

        Dim wqi As New WareQCRecoverInfo
        Dim wqc As New WareQCRecoverController

        If ds.Tables("DelData").Rows.Count > 0 Then
            Dim j As Integer
            For j = 0 To ds.Tables("DelData").Rows.Count - 1

                If Not IsDBNull(ds.Tables("DelData").Rows(j)("AutoID")) Then

                    wqc.WareQCRecover_Delete(Nothing, Nothing, ds.Tables("DelData").Rows(j)("AutoID"))
                End If
            Next j
        End If

        wqi.WQR_NO = txtNO.Text
        wqi.WH_ID = txtWHID.Text
        wqi.WQR_Date = txtDate.Text
        Label5.Text = UserName
        wqi.WQR_Action = InUserID
        Dim i As Integer

        For i = 0 To ds.Tables("WareQCRecover").Rows.Count - 1

            If IsDBNull(ds.Tables("WareQCRecover").Rows(i)("AutoID")) Then

                wqi.WQS_NO = ds.Tables("WareQCRecover").Rows(i)("WQS_NO")

                ds.Tables("WareQCRecover").Rows(i)("AutoID") = GetAutoID()
                wqi.AutoID = ds.Tables("WareQCRecover").Rows(i)("AutoID")

                wqi.M_Code = ds.Tables("WareQCRecover").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("WareQCRecover").Rows(i)("WQR_Qty")) Then
                    wqi.WQR_Qty = Nothing
                Else
                    wqi.WQR_Qty = CSng(ds.Tables("WareQCRecover").Rows(i)("WQR_Qty"))
                End If
                wqi.WQR_Remark = ds.Tables("WareQCRecover").Rows(i)("WQR_Remark")

                wqc.WareQCRecover_Add(wqi)


            ElseIf Not IsDBNull(ds.Tables("WareQCRecover").Rows(i)("AutoID")) Then

                wqi.WQS_NO = ds.Tables("WareQCRecover").Rows(i)("WQS_NO")
                wqi.AutoID = ds.Tables("WareQCRecover").Rows(i)("AutoID")

                wqi.M_Code = ds.Tables("WareQCRecover").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("WareQCRecover").Rows(i)("WQR_Qty")) Then
                    wqi.WQR_Qty = Nothing
                Else
                    wqi.WQR_Qty = CSng(ds.Tables("WareQCRecover").Rows(i)("WQR_Qty"))
                End If
                wqi.WQR_Remark = ds.Tables("WareQCRecover").Rows(i)("WQR_Remark")

                wqc.WareQCRecover_Update(wqi)

            End If
        Next
        MsgBox("修改成功！")
    End Sub

    Sub UpdateCheck()

        Dim qi As New WareQCRecoverInfo
        Dim qc As New WareQCRecoverController

        qi.WQR_NO = txtNO.Text
        qi.WQR_Check = CheckEdit1.Checked
        qi.WQR_CheckAction = InUserID
        If qc.WareQCRecover_Check(qi) = True Then
            MsgBox("審核完成！")
        Else
            MsgBox("審核失敗，請檢查原因！")
        End If
        '---------------------------------------------以下涉及到審核扣數情況
        Dim i As Integer
        For i = 0 To ds.Tables("WareQCRecover").Rows.Count - 1
            Dim spc As New SharePurchaseController
            Dim spi As New SharePurchaseInfo

            Dim wqi As New WareQCSendInfo
            Dim wqc As New WareQCSendController

            spi.WH_ID = txtWHID.EditValue
            spi.M_Code = ds.Tables("WareQCRecover").Rows(i)("M_Code")

            Dim Qty As Single
            Dim wi As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi = wc.WareInventory_GetSub(ds.Tables("WareQCRecover").Rows(i)("M_Code"), txtWHID.EditValue)

            If wi Is Nothing Then
                Qty = 0
            Else
                Qty = wi.WI_Qty
            End If

            If CheckEdit1.Checked = False Then
                'spi.WI_Qty = "-" & ds.Tables("WareQCRecover").Rows(i)("WQR_Qty")
                spi.WI_Qty = Qty - CSng(ds.Tables("WareQCRecover").Rows(i)("WQR_Qty"))
            Else
                'spi.WI_Qty = ds.Tables("WareQCRecover").Rows(i)("WQR_Qty")
                spi.WI_Qty = Qty + CSng(ds.Tables("WareQCRecover").Rows(i)("WQR_Qty"))
            End If
          
            wqi.WQS_NO = ds.Tables("WareQCRecover").Rows(i)("WQS_NO")
            wqi.M_Code = ds.Tables("WareQCRecover").Rows(i)("M_Code")

            'spc.UpdateWareInventory_WIQty(spi)   '倉庫數量加減
            spc.UpdateWareInventory_WIQty2(spi)   '倉庫數量加減
            wqc.UpdateWareQC_NotRecoverQty(wqi)  '抽檢發出未歸還數量加減

        Next

        MsgBox("驗收狀態已改變！")
        Me.Close()
        '---------------------------------------------
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label9.Text
            Case "抽檢歸還"
                If Edit = True Then
                    DataEdit()
                Else
                    DataNew()
                End If
            Case "Check"
                UpdateCheck()
        End Select
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub WareQCRecoverSubAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareQCRecoverSubAdd.Click

        Dim i, n As Integer
        Dim myfrm As New frmWareQCLoadNO
        myfrm.ShowDialog()
        If RefreshT = True Then
            Dim arr(n) As String
            arr = Split(tempValue, ",")
            n = Len(Replace(tempValue, ",", "," & "*")) - Len(tempValue)

            For i = 0 To n

                Dim pst As New Library.WareHouse.WareQCSend.WareQCSendController
                Dim psi As New Library.WareHouse.WareQCSend.WareQCSendInfo

                psi = pst.WareQCSend_GetSub(arr(i))
               
                Dim mi As New Library.Material.MaterialInfo
                Dim mc As New Library.Material.MaterialController

                mi = mc.MaterialCode_Get(psi.M_Code)

                Dim row As DataRow = ds.Tables("WareQCRecover").NewRow

                row("AutoID") = Nothing

                row("WQS_NO") = psi.WQS_NO
                row("M_Code") = psi.M_Code
                row("M_Name") = mi.M_Name
                row("M_Gauge") = mi.M_Gauge
                row("WQR_Qty") = psi.WQS_Qty
                row("WQR_Remark") = ""

                ds.Tables("WareQCRecover").Rows.Add(row)
                GridView1.MoveLast()
            Next
        End If
        tempValue = ""
        RefreshT = False
    End Sub

    Private Sub WareQCRecoverSubDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareQCRecoverSubDel.Click
        If ds.Tables("WareQCRecover").Rows.Count = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "M_Code")

        If DelTemp = "M_Code" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelData").NewRow
            row("AutoID") = ds.Tables("WareQCRecover").Rows(GridView1.FocusedRowHandle)("AutoID")
            row("WQR_NO") = ds.Tables("WareQCRecover").Rows(GridView1.FocusedRowHandle)("WQR_NO")
            row("M_Code") = DelTemp
            ds.Tables("DelData").Rows.Add(row)
        End If
        ds.Tables("WareQCRecover").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

End Class
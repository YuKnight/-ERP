Imports LFERP.Library.WareHouse.WareQCSend
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.BarCode

Public Class frmWareQCSend

    Dim ds As New DataSet

    Private Sub frmWareQCSend_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label10.Text = tempValue
        txtNO.Text = tempValue2
        CreateTable()
        tempValue = ""
        tempValue2 = ""
        txtWhID.EditValue = "W0102"
        txtWhID.Enabled = False
        Label9.Text = UserName
        Select Case Label10.Text

            Case "抽檢發出"
                If Edit = True Then
                    Me.Text = "抽檢發出--修改" & "[" & txtNO.Text & "]"
                    LoadData(txtNO.Text)

                    txtNO.Enabled = False
                    txtWhID.Enabled = False
                Else
                    Me.Text = "抽檢發出--新增"
                    txtDate.Text = Format(Now, "yyyy/MM/dd")
                    txtNO.Text = ""
                End If

            Case "PreView"
                Me.Text = "抽檢發出--查看" & "[" & txtNO.Text & "]"
                LoadData(txtNO.Text)
                cmdSave.Visible = False
            Case "Check"
                Me.Text = "抽檢發出--審核" & "[" & txtNO.Text & "]"
                LoadData(txtNO.Text)
                SendSubAdd.Enabled = False
                SendSubDel.Enabled = False
        End Select
    End Sub

    Sub CreateTable()

        ds.Tables.Clear()

        With ds.Tables.Add("WareQCSend")

            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("WQS_NO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("WQS_Qty", GetType(Single))
            .Columns.Add("WQS_NotRecoverQty", GetType(Double))
            .Columns.Add("A_AcceptanceNO", GetType(String))
            .Columns.Add("WH_ID", GetType(String))
            .Columns.Add("WQS_Date", GetType(String))
            .Columns.Add("WQS_Action", GetType(String))
            .Columns.Add("WQS_Check", GetType(Boolean))
            .Columns.Add("WQS_CheckActon", GetType(String))
            .Columns.Add("WQS_Remark", GetType(String))

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))

        End With

        '創建刪除數據表
        With ds.Tables.Add("DelData")

            .Columns.Add("WQS_NO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("AutoID", GetType(String))
        End With
        '綁定表格
        Grid1.DataSource = ds.Tables("WareQCSend")

    End Sub

    Function LoadData(ByVal WQS_NO As String) As Boolean
        LoadData = True
        Dim qi As New List(Of WareQCSendInfo)
        Dim qc As New WareQCSendController
        Try
            qi = qc.WareQCSend_GetList(WQS_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If qi Is Nothing Then
                '沒有數據
                LoadData = False
                Exit Function
            End If

            txtWhID.Text = qi(0).WH_ID
            txtDate.EditValue = Format(qi(0).WQS_Date, "yyyy/MM/dd")
            Label9.Text = qi(0).UserName

            If qi(0).WQS_Check = False Then
                CheckEdit1.Checked = False
            Else
                CheckEdit1.Checked = True
            End If
            Label7.Text = qi(0).WQS_CheckAction

            ds.Tables("WareQCSend").Rows.Clear()

            LoadSub(qc.WareQCSend_GetList(WQS_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

        Catch ex As Exception

            LoadData = False
            MsgBox(ex.Message)
        End Try

    End Function

    Sub LoadSub(ByVal dlist As List(Of WareQCSendInfo))
        On Error Resume Next

        If dlist Is Nothing Then Exit Sub

        Dim i As Integer
        Dim row As DataRow

        For i = 0 To dlist.Count - 1

            row = ds.Tables("WareQCSend").NewRow

            row("WQS_NO") = dlist(i).WQS_NO

            row("A_AcceptanceNO") = dlist(i).A_AcceptanceNO
            row("AutoID") = dlist(i).AutoID
            row("M_Code") = dlist(i).M_Code
            row("M_Name") = dlist(i).M_Name
            row("M_Gauge") = dlist(i).M_Gauge

            row("WQS_Qty") = dlist(i).WQS_Qty
            row("WQS_Remark") = dlist(i).WQS_Remark

            ds.Tables("WareQCSend").Rows.Add(row)

        Next

    End Sub

    Public Function GetNO() As String

        Dim wqi As New WareQCSendInfo
        Dim wqc As New WareQCSendController
        Dim str As String
        str = CStr(Format(Now, "yyMM"))
        wqi = wqc.WareQCSend_GetNO(str)
        If wqi Is Nothing Then
            GetNO = "WQS" & str & "0001"
        Else
            GetNO = "WQS" & str & Mid((CInt(Mid(wqi.WQS_NO, 8)) + 10001), 2)
        End If

    End Function
    Public Function GetAutoID() As String
        Dim wqi As New WareQCSendInfo
        Dim wqc As New WareQCSendController
        Dim str As String
        str = "A"
        wqi = wqc.WareQCSend_GetAutoID(str)
        If wqi Is Nothing Then
            GetAutoID = str & "000000001"
        Else
            GetAutoID = str & Mid((CInt(Mid(wqi.AutoID, 2)) + 1000000001), 2)
        End If

    End Function


    Sub DataNew()

        Dim qi As New WareQCSendInfo
        Dim qc As New WareQCSendController

        txtNO.Text = GetNO()

        qi.WQS_NO = txtNO.Text
        qi.WH_ID = txtWhID.Text
        qi.WQS_Date = txtDate.Text
        Label9.Text = UserName
        qi.WQS_Action = InUserID

        Dim i As Integer
        For i = 0 To ds.Tables("WareQCSend").Rows.Count - 1

            ds.Tables("WareQCSend").Rows(i)("AutoID") = GetAutoID()
            qi.AutoID = ds.Tables("WareQCSend").Rows(i)("AutoID")

            If IsDBNull(ds.Tables("WareQCSend").Rows(i)("WQS_Qty")) Then
                qi.WQS_Qty = Nothing
            Else
                qi.WQS_Qty = CSng(ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))
            End If
            qi.WQS_NotRecoverQty = CSng(ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))

            qi.A_AcceptanceNO = ds.Tables("WareQCSend").Rows(i)("A_AcceptanceNO")
            qi.WQS_Remark = ds.Tables("WareQCSend").Rows(i)("WQS_Remark")

            qi.M_Code = ds.Tables("WareQCSend").Rows(i)("M_Code")

            qc.WareQCSend_Add(qi)

        Next
        MsgBox("添加成功", , "提示")
        Me.Close()
    End Sub

    Sub DataEdit()

        Dim qi As New WareQCSendInfo
        Dim qc As New WareQCSendController

        If ds.Tables("DelData").Rows.Count > 0 Then
            Dim j As Integer
            For j = 0 To ds.Tables("DelData").Rows.Count - 1

                If Not IsDBNull(ds.Tables("DelData").Rows(j)("AutoID")) Then

                    qc.WareQCSend_Delete(Nothing, Nothing, ds.Tables("DelData").Rows(j)("AutoID"))
                End If
            Next j
        End If

        qi.WQS_NO = txtNO.Text
        qi.WH_ID = txtWhID.Text
        qi.WQS_Date = txtDate.Text
        qi.WQS_Action = InUserID

        Dim i As Integer
        For i = 0 To ds.Tables("WareQCSend").Rows.Count - 1

            If IsDBNull(ds.Tables("WareQCSend").Rows(i)("AutoID")) Then  '新增子物料信息

                qi.AutoID = GetAutoID()

                qi.A_AcceptanceNO = ds.Tables("WareQCSend").Rows(i)("A_AcceptanceNO")
                qi.M_Code = ds.Tables("WareQCSend").Rows(i)("M_Code")
                If IsDBNull(ds.Tables("WareQCSend").Rows(i)("WQS_Qty")) Then
                    qi.WQS_Qty = 0
                Else
                    qi.WQS_Qty = CSng(ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))
                End If
                qi.WQS_NotRecoverQty = CSng(ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))
                qi.WQS_Remark = ds.Tables("WareQCSend").Rows(i)("WQS_Remark")

                qc.WareQCSend_Add(qi)


            ElseIf Not IsDBNull(ds.Tables("WareQCSend").Rows(i)("AutoID")) Then '修改子物料信息

                qi.AutoID = ds.Tables("WareQCSend").Rows(i)("AutoID")

                qi.A_AcceptanceNO = ds.Tables("WareQCSend").Rows(i)("A_AcceptanceNO")

                qi.M_Code = ds.Tables("WareQCSend").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("WareQCSend").Rows(i)("WQS_Qty")) Then
                    qi.WQS_Qty = 0
                Else
                    qi.WQS_Qty = CSng(ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))
                End If
                qi.WQS_NotRecoverQty = CDbl(ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))
                qi.WQS_Remark = ds.Tables("WareQCSend").Rows(i)("WQS_Remark")

                qc.WareQCSend_Update(qi)

            End If
        Next
        MsgBox("修改成功！")

    End Sub

    Sub UpdateCheck()
        Dim qi As New WareQCSendInfo
        Dim qc As New WareQCSendController

        qi.WQS_NO = txtNO.Text
        qi.WQS_Check = CheckEdit1.Checked
        qi.WQS_CheckAction = InUserID
        If qc.WareQCSend_Check(qi) = True Then
            MsgBox("審核完成！")
        Else
            MsgBox("審核失敗，請檢查原因！")
        End If
        Dim mt As New SharePurchaseController
        Dim mm As New SharePurchaseInfo


        mm.WH_ID = txtWhID.EditValue


        For i As Integer = 0 To ds.Tables("WareQCSend").Rows.Count - 1

            mm.M_Code = ds.Tables("WareQCSend").Rows(i)("M_Code")

            Dim Qty As Single
            Dim wi As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi = wc.WareInventory_GetSub(ds.Tables("WareQCSend").Rows(i)("M_Code"), txtWhID.EditValue)

            If wi Is Nothing Then
                Qty = 0
            Else
                Qty = wi.WI_Qty
            End If

            If CheckEdit1.Checked = False Then
                'mm.WI_Qty = CSng(ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))
                mm.WI_Qty = Qty + CSng(ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))
            ElseIf CheckEdit1.Checked = True Then
                'mm.WI_Qty = CSng("-" & ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))
                mm.WI_Qty = Qty - CSng(ds.Tables("WareQCSend").Rows(i)("WQS_Qty"))
            End If
            'mt.UpdateWareInventory_WIQty(mm)
            mt.UpdateWareInventory_WIQty2(mm)

        Next

        Me.Close()

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label10.Text
            Case "抽檢發出"
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

    Private Sub SendSubAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendSubAdd.Click
        Dim i, n As Integer
        Dim myfrm As New frmRetrocedeSelect
        tempValue4 = "QC抽檢"
        myfrm.ShowDialog()
        If RefreshT = True Then
            Dim arr(n) As String
            arr = Split(tempValue, ",")
            n = Len(Replace(tempValue, ",", "," & "*")) - Len(tempValue)

            For i = 0 To n

                Dim pst As New Library.Purchase.Acceptance.AcceptanceController
                Dim psi As New Library.Purchase.Acceptance.AcceptanceInfo

                psi = pst.Acceptance_GetSub(arr(i))

                Dim row As DataRow = ds.Tables("WareQCSend").NewRow

                row("AutoID") = Nothing
                row("WQS_NO") = Nothing

                row("A_AcceptanceNO") = psi.A_AcceptanceNO
                row("M_Code") = psi.M_Code
                row("M_Name") = psi.M_Name
                row("M_Gauge") = psi.M_Gauge
                row("WQS_Qty") = psi.A_Qty
                row("WQS_Remark") = ""

                ds.Tables("WareQCSend").Rows.Add(row)
                GridView1.MoveLast()
            Next
        End If
        tempValue = ""
        RefreshT = False
    End Sub

    Private Sub SendSubDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendSubDel.Click
        If ds.Tables("WareQCSend").Rows.Count = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "M_Code")

        If DelTemp = "M_Code" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelData").NewRow
            row("AutoID") = ds.Tables("WareQCSend").Rows(GridView1.FocusedRowHandle)("AutoID")
            row("WQS_NO") = ds.Tables("WareQCSend").Rows(GridView1.FocusedRowHandle)("WQS_NO")
            row("M_Code") = DelTemp
            ds.Tables("DelData").Rows.Add(row)
        End If
        ds.Tables("WareQCSend").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub


    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click

        'Dim bc As New BarCodeControl

        Dim i As Integer
        For i = 0 To ds.Tables("WareQCSend").Rows.Count - 1

            Dim str1, str2, str3, str4, str5, str6, str7 As String

            str1 = ds.Tables("WareQCSend").Rows(i)("M_Code")
            str2 = ds.Tables("WareQCSend").Rows(i)("M_Name")
            str3 = ds.Tables("WareQCSend").Rows(i)("M_Gauge")

            str5 = ds.Tables("WareQCSend").Rows(i)("WQS_Qty")
            str6 = ds.Tables("WareQCSend").Rows(i)("A_AcceptanceNO")

            Dim ai As New Library.Purchase.Acceptance.AcceptanceInfo
            Dim ac As New Library.Purchase.Acceptance.AcceptanceController
            ai = ac.Acceptance_Get(str6)
            str4 = ai.OS_BatchID
            str7 = txtNO.Text
            'MsgBox(str1 & str2 & str3 & str4 & str5 & str6 & str7)

            PrintQCBar(str1, str2, str3, str4, str5, str6, str7) '當前公用類中

        Next
        'Dim myFrm As New frmBarCode
        'tempValue3 = "QC抽檢作業"
        'tempValue4 = txtNO.Text
        'myFrm.ShowDialog()


    End Sub

    '得到QC抽檢的倉庫名稱以及倉庫代號
    Private Sub txtWhID_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWhID.ButtonClick


    End Sub
End Class
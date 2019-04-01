Imports LFERP.Library.Outward

Public Class frmOutwardChange

    Dim ds As New DataSet

    Private Sub frmOutwardChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label13.Text = tempValue
        txtNO.Text = tempValue3
        tempValue = ""
        tempValue3 = ""

        CreateTable()
        Select Case Label13.Text

            Case "更改單"
                If Edit = False Then
                    Me.Text = "更改單--暫改"
                    DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                    txtNO.Text = ""
                    txtNO.Enabled = False
                    Label5.Text = UserName
                Else
                    Me.Text = "更改單--修改"
                    txtNO.Enabled = False
                    LoadData(txtNO.Text)
                End If
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "PreView"
                Me.Text = "更改單--查看"
                LoadData(txtNO.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "Check"
                Me.Text = "更改單--審核"
                LoadData(txtNO.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
        End Select
    End Sub

    Sub CreateTable()

        ds.Tables.Clear()

        With ds.Tables.Add("OutwardChange")

            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("OC_NO", GetType(String))
            .Columns.Add("O_NO", GetType(String))
            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("OS_Qty", GetType(Double))
            .Columns.Add("OS_NoSendQty", GetType(Double))
            .Columns.Add("OC_Qty", GetType(Double))
            .Columns.Add("OC_Reason", GetType(String))

        End With

        With ds.Tables.Add("DelChange")
            .Columns.Add("OC_NO", GetType(String))
            .Columns.Add("AutoID", GetType(String))
        End With

        GridControl1.DataSource = ds.Tables("OutwardChange")

    End Sub

    Function LoadData(ByVal OC_NO As String) As Boolean
        LoadData = True
        Dim oci As List(Of OutwardChangeInfo)
        Dim occ As New OutwardChangeControl
        Dim i As Integer
        Dim row As DataRow
        Try
            oci = occ.OutwardChange_GetList(OC_NO, Nothing, Nothing, Nothing, Nothing, Nothing)
            If oci Is Nothing Then
                Exit Function    '沒有數據
            Else
                DateEdit1.EditValue = Format(oci(0).OC_AddDate, "yyyy/MM/dd")
                Label5.Text = oci(0).ActionName
                MemoEdit1.Text = oci(0).OC_Remark

                If oci(0).OC_Check = False Then
                    CheckEdit1.Checked = False
                Else
                    CheckEdit1.Checked = True
                End If

                Label9.Text = oci(0).CheckActionName
                Label12.Text = Format(oci(0).OC_CheckDate, "yyyy/MM/dd")
                MemoEdit2.Text = oci(0).OC_CheckRemark

                For i = 0 To oci.Count - 1

                    row = ds.Tables("OutwardChange").NewRow

                    row("AutoID") = oci(i).AutoID
                    row("OC_NO") = OC_NO
                    row("O_NO") = oci(i).O_NO
                    row("OS_BatchID") = oci(i).OS_BatchID
                    row("PM_M_Code") = oci(i).PM_M_Code
                    row("M_Code") = oci(i).M_Code
                    row("M_Name") = oci(i).M_Name
                    row("M_Gauge") = oci(i).M_Gauge
                    row("OS_Qty") = oci(i).OS_Qty
                    row("OS_NoSendQty") = oci(i).OS_NoSendQty
                    row("OC_Qty") = oci(i).OC_Qty
                    row("OC_Reason") = oci(i).OC_Reason

                    ds.Tables("OutwardChange").Rows.Add(row)

                Next

                End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
     
    End Function

    Public Function GetNO() As String
        Dim str As String
        str = CStr(Format(Now, "yyMM"))
        Dim ai As New OutwardChangeInfo
        Dim ac As New OutwardChangeControl

        ai = ac.OutwardChange_GetNO(str)

        If ai Is Nothing Then
            GetNO = "OC" & str & "00001"
        Else
            GetNO = "OC" & str & Mid((CInt(Mid(ai.OC_NO, 7)) + 100001), 2)
        End If

    End Function

    Sub DataNew()    '新增操作

        Dim oci As New OutwardChangeInfo
        Dim oc As New OutwardChangeControl

        oci.OC_NO = GetNO()
        oci.OC_AddDate = Format(Now, "yyyy/MM/dd")
        oci.OC_EditDate = Format(Now, "yyyy/MM/dd")
        oci.OC_Action = InUserID
        oci.OC_Remark = MemoEdit1.Text

        Dim i As Integer

        For i = 0 To ds.Tables("OutwardChange").Rows.Count - 1

            oci.O_NO = ds.Tables("OutwardChange").Rows(i)("O_NO")

            If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OS_BatchID")) Then
                oci.OS_BatchID = Nothing
            Else
                oci.OS_BatchID = ds.Tables("OutwardChange").Rows(i)("OS_BatchID")
            End If
            If IsDBNull(ds.Tables("OutwardChange").Rows(i)("PM_M_Code")) Then
                oci.PM_M_Code = Nothing
            Else
                oci.PM_M_Code = ds.Tables("OutwardChange").Rows(i)("PM_M_Code")
            End If
            oci.M_Code = ds.Tables("OutwardChange").Rows(i)("M_Code")
            oci.M_Name = ds.Tables("OutwardChange").Rows(i)("M_Name")

            If IsDBNull(ds.Tables("OutwardChange").Rows(i)("M_Gauge")) Then
                oci.M_Gauge = Nothing
            Else
                oci.M_Gauge = ds.Tables("OutwardChange").Rows(i)("M_Gauge")
            End If

            If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OS_Qty")) Then
                oci.OS_Qty = 0
            Else
                oci.OS_Qty = ds.Tables("OutwardChange").Rows(i)("OS_Qty")
            End If
            If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OS_NoSendQty")) Then
                oci.OS_NoSendQty = 0
            Else
                oci.OS_NoSendQty = ds.Tables("OutwardChange").Rows(i)("OS_NoSendQty")
            End If
            If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OC_Qty")) Then
                oci.OC_Qty = 0
            Else
                oci.OC_Qty = ds.Tables("OutwardChange").Rows(i)("OC_Qty")
            End If
            If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OC_Reason")) Then
                oci.OC_Reason = Nothing
            Else
                oci.OC_Reason = ds.Tables("OutwardChange").Rows(i)("OC_Reason")
            End If
            oc.OutwardChange_Add(oci)
        Next
        MsgBox("已保存,單號: " & GetNO() & " ")
        Me.Close()
    End Sub

    Sub DataEdit()

        '更新刪除的記錄
        If ds.Tables("DelChange").Rows.Count > 0 Then
            Dim j As Integer
            For j = 0 To ds.Tables("DelChange").Rows.Count - 1

                Dim odc As New OutwardChangeControl

                If Not IsDBNull(ds.Tables("DelChange").Rows(j)("AutoID")) Then
                    odc.OutwardChange_Delete(Nothing, ds.Tables("DelChange").Rows(j)("AutoID"))
                End If
            Next j
        End If
        '--------------------------------------以上為刪除ds中數據

        Dim oci As New OutwardChangeInfo
        Dim oc As New OutwardChangeControl

        oci.OC_EditDate = Format(Now, "yyyy/MM/dd")
        oci.OC_Action = InUserID
        oci.OC_Remark = MemoEdit1.Text

        Dim i As Integer

        For i = 0 To ds.Tables("OutwardChange").Rows.Count - 1

            If Not IsDBNull(ds.Tables("OutwardChange").Rows(i)("AutoID")) Then  '只修改

                oci.AutoID = ds.Tables("OutwardChange").Rows(i)("AutoID")

                If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OC_Qty")) Then
                    oci.OC_Qty = 0
                Else
                    oci.OC_Qty = ds.Tables("OutwardChange").Rows(i)("OC_Qty")
                End If
                If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OC_Reason")) Then
                    oci.OC_Reason = Nothing
                Else
                    oci.OC_Reason = ds.Tables("OutwardChange").Rows(i)("OC_Reason")
                End If
                oc.OutwardChange_Update(oci)

            ElseIf IsDBNull(ds.Tables("OutwardChange").Rows(i)("AutoID")) Then  '修改新增

                oci.OC_NO = txtNO.Text
                oci.OC_AddDate = DateEdit1.EditValue

                oci.O_NO = ds.Tables("OutwardChange").Rows(i)("O_NO")

                If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OS_BatchID")) Then
                    oci.OS_BatchID = Nothing
                Else
                    oci.OS_BatchID = ds.Tables("OutwardChange").Rows(i)("OS_BatchID")
                End If
                If IsDBNull(ds.Tables("OutwardChange").Rows(i)("PM_M_Code")) Then
                    oci.PM_M_Code = Nothing
                Else
                    oci.PM_M_Code = ds.Tables("OutwardChange").Rows(i)("PM_M_Code")
                End If
                oci.M_Code = ds.Tables("OutwardChange").Rows(i)("M_Code")
                oci.M_Name = ds.Tables("OutwardChange").Rows(i)("M_Name")

                If IsDBNull(ds.Tables("OutwardChange").Rows(i)("M_Gauge")) Then
                    oci.M_Gauge = Nothing
                Else
                    oci.M_Gauge = ds.Tables("OutwardChange").Rows(i)("M_Gauge")
                End If

                If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OS_Qty")) Then
                    oci.OS_Qty = 0
                Else
                    oci.OS_Qty = ds.Tables("OutwardChange").Rows(i)("OS_Qty")
                End If
                If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OS_NoSendQty")) Then
                    oci.OS_NoSendQty = 0
                Else
                    oci.OS_NoSendQty = ds.Tables("OutwardChange").Rows(i)("OS_NoSendQty")
                End If
                If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OC_Qty")) Then
                    oci.OC_Qty = 0
                Else
                    oci.OC_Qty = ds.Tables("OutwardChange").Rows(i)("OC_Qty")
                End If
                If IsDBNull(ds.Tables("OutwardChange").Rows(i)("OC_Reason")) Then
                    oci.OC_Reason = Nothing
                Else
                    oci.OC_Reason = ds.Tables("OutwardChange").Rows(i)("OC_Reason")
                End If
                oc.OutwardChange_Add(oci)
            End If

        Next
        MsgBox("已保存,單號: " & GetNO() & " ")
        Me.Close()
    End Sub

    Sub UpdateCheck()

        Dim oci As New OutwardChangeInfo
        Dim oc As New OutwardChangeControl

        oci.OC_NO = txtNO.Text
        oci.OC_Check = CheckEdit1.Checked
        oci.OC_CheckAction = InUserID
        Label9.Text = UserName
        oci.OC_CheckDate = Format(Now, "yyyy/MM/dd")
        Label12.Text = Format(Now, "yyyy/MM/dd")
        oci.OC_CheckRemark = MemoEdit2.Text

        If oc.OutwardChange_UpdateCheck(oci) = True Then  '完成審核. 更改外發未交數中數量 一旦更改不允許再次操作

            Dim i As Integer
            For i = 0 To ds.Tables("OutwardChange").Rows.Count - 1
                oci.O_NO = ds.Tables("OutwardChange").Rows(i)("O_NO")
                oci.OS_BatchID = ds.Tables("OutwardChange").Rows(i)("OS_BatchID")
                oci.M_Code = ds.Tables("OutwardChange").Rows(i)("M_Code")
                oci.OS_NoSendQty = ds.Tables("OutwardChange").Rows(i)("OC_Qty")

                oc.UpdateOutwardChange_NoSendQty(oci)
            Next
            MsgBox("審核成功，外發單中未交數將更改為此單中數量！")
        Else
            MsgBox("審核失敗，請檢查原因！")
        End If
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Select Case Label13.Text

            Case "更改單"
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

    Private Sub cmsChangeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsChangeAdd.Click
        Dim i, n As Integer
        Dim YanZeng As Boolean    '驗証,看載入各項未交數是否為0或負數
        Dim myfrm As New FormAcceptanceSelect
        Dim oc As New OutwardController
        Dim oi As New List(Of OutwardInfo)

        myfrm.ShowDialog()
        YanZeng = True
        If RefreshT = True Then
            Dim arr(n) As String
            arr = Split(tempValue, ",")
            n = Len(Replace(tempValue, ",", "," & "*")) - Len(tempValue)

            For i = 0 To n

                Dim opc As New OutwardController
                Dim opiL As List(Of OutwardInfo)
                opiL = opc.OutwardSub_GetList(Nothing, arr(i), Nothing, Nothing, Nothing)

                Dim row As DataRow = ds.Tables("OutwardChange").NewRow

                row("O_NO") = opiL(0).O_NO
                row("M_Code") = opiL(0).M_Code
                row("M_Name") = opiL(0).M_Name
                row("M_Gauge") = opiL(0).M_Gauge
                row("OS_BatchID") = opiL(0).OS_BatchID
                row("PM_M_Code") = opiL(0).PM_M_Code
                row("OS_Qty") = opiL(0).OS_Qty
                row("OS_NoSendQty") = opiL(0).OS_NoSendQty
              
                row("OC_Qty") = opiL(0).OS_NoSendQty  '默認情況下更改後的跟以前相同

                If opiL(0).OS_NoSendQty <= 0 Then YanZeng = False

                ds.Tables("OutwardChange").Rows.Add(row)
                AdvBandedGridView1.MoveLast()
          
            Next

        End If
        tempValue5 = ""
        tempValue = ""
        RefreshT = False
        If YanZeng = False Then
            MsgBox("某物料未交數已經為0或負數,無法再驗收!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If
    End Sub

    Private Sub cmsChangeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsChangeDel.Click
        If AdvBandedGridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = AdvBandedGridView1.GetRowCellDisplayText(ArrayToString(AdvBandedGridView1.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelChange").NewRow
            row("OC_NO") = txtNO.Text
            row("AutoID") = DelTemp
            ds.Tables("DelChange").Rows.Add(row)
        End If
        ds.Tables("OutwardChange").Rows.RemoveAt(CInt(ArrayToString(AdvBandedGridView1.GetSelectedRows())))
    End Sub
    '當前更改單載入附檔

    Private Sub popFileShowOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popFileShowOpen.Click

    End Sub
End Class
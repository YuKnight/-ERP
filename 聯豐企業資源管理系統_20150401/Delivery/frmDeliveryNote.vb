Imports LFERP.Library.Delivery
Imports LFERP.Library.SingleFactory
Imports LFERP.DataSetting

Public Class frmDeliveryNote

    Dim ds As New DataSet
    Dim strWHID As String

    Private Sub frmDeliveryNote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label23.Text = tempValue
        txtID.Text = tempValue2
        tempValue = ""
        tempValue2 = ""
        CreateTable()


        Dim mtd As New CusterControler
        gluCuster.Properties.DisplayMember = "C_CusterID"
        gluCuster.Properties.ValueMember = "C_CusterID"
        gluCuster.Properties.DataSource = mtd.GetCusterList(Nothing, Nothing, Nothing)
        Select Case Label23.Text

            Case "送貨單"
                If Edit = False Then
                    'txtID.Text = GetID()
                    DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
                    Me.Text = "送貨單--新增"
                    Label12.Text = UserName
                Else
                    LoadData(txtID.Text)
                    Me.Text = "送貨單--修改" & "[" & txtID.Text & "]"
                End If
                txtID.Enabled = False
                DeliveryPackingAdd.Enabled = True
                DeliveryPackingDel.Enabled = True
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "PreView"
                LoadData(txtID.Text)
                cmdSave.Visible = False
                Me.Text = "送貨單--查看" & "[" & txtID.Text & "]"
                txtID.Enabled = False
                DeliveryPackingAdd.Enabled = False
                DeliveryPackingDel.Enabled = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1

            Case "Check"
                LoadData(txtID.Text)
                Me.Text = "送貨單--審核" & "[" & txtID.Text & "]"
                DeliveryPackingAdd.Enabled = False
                DeliveryPackingDel.Enabled = False
                txtID.Enabled = False
                XtraTabControl1.SelectedTabPage = XtraTabPage2
            Case "AccCheck"
                LoadData(txtID.Text)
                Me.Text = "送貨單--復核" & "[" & txtID.Text & "]"
                DeliveryPackingAdd.Enabled = False
                DeliveryPackingDel.Enabled = False
                txtID.Enabled = False
                XtraTabControl1.SelectedTabPage = XtraTabPage3
        End Select

    End Sub
    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("Delivery")
            .Columns.Add("IndexNO", GetType(Integer))
            .Columns.Add("DN_ID", GetType(String))
            .Columns.Add("P_NO", GetType(String))
            .Columns.Add("DNS_NO", GetType(String))
            .Columns.Add("P_Type", GetType(String))
            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("DN_Qty", GetType(Double))
            .Columns.Add("DN_SP", GetType(Double))
            .Columns.Add("DN_Help", GetType(String))
            .Columns.Add("R_NO", GetType(String))

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
        End With
    
        With ds.Tables.Add("DelDelivery")
            .Columns.Add("DN_ID", GetType(String))
            .Columns.Add("DNS_NO", GetType(String))
        End With
        GridControl1.DataSource = ds.Tables("Delivery")

    End Sub
    Public Function LoadData(ByVal DN_ID As String) As Boolean
        LoadData = True
        Dim di As New List(Of DeliveryInfo)
        Dim dc As New DeliveryControl
        Try
            di = dc.DeliveryNote_GetList(DN_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If di Is Nothing Then
                LoadData = True
                Exit Function
            End If
            txtID.Text = di(0).DN_ID
            strWHID = di(0).WH_ID
            ButtonEdit1.EditValue = di(0).WH_Name
            gluCuster.EditValue = di(0).DN_CusterNO
            Label12.Text = di(0).ActionName
            cbType.EditValue = di(0).DN_Type
            DateEdit1.EditValue = Format(di(0).DN_Date, "yyyy/MM/dd")
            cbCharge.EditValue = di(0).DN_Charge
            If di(0).DN_Invoice = True Then
                CheckEdit1.Checked = True
            Else
                CheckEdit1.Checked = False
            End If
            If di(0).DN_Return = True Then
                CheckEdit2.Checked = True
            Else
                CheckEdit2.Checked = False
            End If
            MemoEdit1.EditValue = di(0).DN_Remark
            '-------------------------------------------------------------------載入基本信息
            If di(0).DN_Check = True Then
                CheckEdit3.Checked = True
            Else
                CheckEdit3.Checked = False
            End If
            Label14.Text = di(0).DN_CheckDate
            Label16.Text = di(0).ActionName
            MemoEdit2.EditValue = di(0).DN_CheckRemark
            '--------------------------------------------------------------------載入審核信息
            If di(0).DN_AccCheck = True Then
                CheckEdit4.Checked = True
            Else
                CheckEdit4.Checked = False
            End If
            Label21.Text = di(0).DN_AccCheckDate
            cbAccChecktype.EditValue = di(0).DN_AccCheckType
            Label19.Text = di(0).AccCheckActionName
            MemoEdit3.EditValue = di(0).DN_AccCheckRemark
            '---------------------------------------------------------------------載入復核信息
            ds.Tables("Delivery").Clear()

            LoadSub(dc.DeliveryNote_GetList(DN_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))     '得到送貨單裝箱表信息

        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try

    End Function

    Public Sub LoadSub(ByVal dlist As List(Of DeliveryInfo))
        On Error Resume Next

        If dlist Is Nothing Then Exit Sub
        Dim i As Integer
        Dim row As DataRow

        For i = 0 To dlist.Count - 1

            row = ds.Tables("Delivery").NewRow

            row("IndexNO") = dlist(i).IndexNO
            row("DN_ID") = dlist(i).DN_ID
            row("P_NO") = dlist(i).P_NO
            row("DNS_NO") = dlist(i).DNS_NO
            row("P_Type") = dlist(i).P_Type
            row("OS_BatchID") = dlist(i).OS_BatchID
            row("M_Code") = dlist(i).M_Code

            row("M_Name") = dlist(i).M_Name
            row("M_Gauge") = dlist(i).M_Gauge

            row("DN_Qty") = dlist(i).DN_Qty
            row("DN_SP") = dlist(i).DN_SP
            row("DN_Help") = dlist(i).DN_Help
            row("R_NO") = dlist(i).R_NO
         
            ds.Tables("Delivery").Rows.Add(row)
        Next

    End Sub


    Public Function GetID() As String

        Dim dc As New DeliveryControl
        Dim di As New DeliveryInfo
        Dim str As String
        str = Format(Now, "yyMM")
        di = dc.DeliveryNote_GetNO(str)
        If di Is Nothing Then
            GetID = "D" & str & "0001"
        Else
            GetID = "D" & str & Mid((CInt(Mid(di.DN_ID, 6)) + 10001), 2)
        End If
    End Function

    Sub DataNew()

        Dim di As New DeliveryInfo
        Dim dc As New DeliveryControl

        txtID.Text = GetID()
        di.DN_ID = txtID.Text
        di.DN_Date = DateEdit1.EditValue

        ''di.WH_ID = ButtonEdit1.EditValue
        di.WH_ID = strWHID

        di.DN_Action = InUserID
        di.DN_Type = cbType.EditValue
        di.DN_CusterNO = gluCuster.EditValue
        di.DN_Charge = cbCharge.EditValue
        di.DN_Invoice = CheckEdit1.Checked
        di.DN_Return = CheckEdit2.Checked
        di.DN_Remark = MemoEdit1.EditValue

        If dc.DeliveryNote_Add(di) = False Then
            MsgBox("添加失敗，請檢查原因！")
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To ds.Tables("Delivery").Rows.Count - 1

            Dim di1 As New DeliveryInfo

            di1.DN_ID = txtID.Text

            di1.P_NO = ds.Tables("Delivery").Rows(i)("P_NO")

            If i < 10 Then
                di1.DNS_NO = txtID.Text & "0" & i + 1
            Else
                di1.DNS_NO = txtID.Text & i + 1
            End If
            'di1.DNS_NO = txtID.Text & i + 1
            'If IsDBNull(ds.Tables("Delivery").Rows(i)("DNS_NO")) Then
            '    di1.DNS_NO = Nothing
            'Else

            '    di1.DNS_NO = ds.Tables("Delivery").Rows(i)("DNS_NO")
            'End If

            di1.P_Type = ds.Tables("Delivery").Rows(i)("P_Type")

            If IsDBNull(ds.Tables("Delivery").Rows(i)("OS_BatchID")) Then
                di1.OS_BatchID = Nothing
            Else
                di1.OS_BatchID = ds.Tables("Delivery").Rows(i)("OS_BatchID")
            End If
            If IsDBNull(ds.Tables("Delivery").Rows(i)("M_Code")) Then
                di1.M_Code = Nothing
            Else
                di1.M_Code = ds.Tables("Delivery").Rows(i)("M_Code")
            End If
            If IsDBNull(ds.Tables("Delivery").Rows(i)("DN_Qty")) Then
                di1.DN_Qty = 0
            Else
                di1.DN_Qty = ds.Tables("Delivery").Rows(i)("DN_Qty")
            End If
            If IsDBNull(ds.Tables("Delivery").Rows(i)("DN_SP")) Then
                di1.DN_SP = 0
            Else
                di1.DN_SP = ds.Tables("Delivery").Rows(i)("DN_SP")
            End If
            If IsDBNull(ds.Tables("Delivery").Rows(i)("DN_Help")) Then
                di1.DN_Help = Nothing
            Else
                di1.DN_Help = ds.Tables("Delivery").Rows(i)("DN_Help")
            End If
            If IsDBNull(ds.Tables("Delivery").Rows(i)("R_NO")) Then
                di1.R_NO = Nothing
            Else
                di1.R_NO = ds.Tables("Delivery").Rows(i)("R_NO")
            End If
            If dc.DeliveryPacking_Add(di1) = False Then
                MsgBox("添加失敗，請檢查原因！")
                Exit Sub
            End If

        Next
        Me.Close()
    End Sub

    Sub DataEdit()

        '更新刪除列表記錄
        If ds.Tables("DelDelivery").Rows.Count > 0 Then
            Dim j As Integer
            For j = 0 To ds.Tables("DelDelivery").Rows.Count - 1
                Dim dc1 As New DeliveryControl
                dc1.DeliveryPacking_Delete(Nothing, ds.Tables("DelDelivery").Rows(j)("DNS_NO"), Nothing) '刪除送貨裝箱表
                Dim di1 As New List(Of DeliveryInfo)
                di1 = dc1.DeliveryPackingSub_GetList(ds.Tables("DelDelivery").Rows(j)("DNS_NO"), Nothing)
                If di1.Count > 0 Then
                    Dim m As Integer
                    For m = 0 To di1.Count - 1
                        dc1.DeliveryPackingSub_Delete(di1(m).DNS_NO, Nothing) '刪除當前送貨單裝箱編號下配件表
                    Next
                End If
            Next
        End If

        Dim di As New DeliveryInfo
        Dim dc As New DeliveryControl

        di.DN_ID = txtID.Text
        di.DN_Date = DateEdit1.EditValue

        di.WH_ID = strWHID

        'di.WH_ID = ButtonEdit1.EditValue

        di.DN_Action = InUserID
        di.DN_Type = cbType.EditValue
        di.DN_CusterNO = gluCuster.EditValue
        di.DN_Charge = cbCharge.EditValue
        di.DN_Invoice = CheckEdit1.Checked
        di.DN_Return = CheckEdit2.Checked
        di.DN_Remark = MemoEdit1.EditValue

        If dc.DeliveryNote_Update(di) = False Then
            MsgBox("添加失敗，請檢查原因！")
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To ds.Tables("Delivery").Rows.Count - 1

            If IsDBNull(ds.Tables("Delivery").Rows(i)("IndexNO")) Then '修改中新增
                Dim di1 As New DeliveryInfo


                di1.DN_ID = txtID.Text
                di1.P_NO = ds.Tables("Delivery").Rows(i)("P_NO")

                If i < 10 Then
                    di1.DNS_NO = txtID.Text & "0" & i + 1
                Else
                    di1.DNS_NO = txtID.Text & i + 1
                End If
                di1.P_Type = ds.Tables("Delivery").Rows(i)("P_Type")

                If IsDBNull(ds.Tables("Delivery").Rows(i)("OS_BatchID")) Then
                    di1.OS_BatchID = Nothing
                Else
                    di1.OS_BatchID = ds.Tables("Delivery").Rows(i)("OS_BatchID")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("M_Code")) Then
                    di1.M_Code = Nothing
                Else
                    di1.M_Code = ds.Tables("Delivery").Rows(i)("M_Code")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("DN_Qty")) Then
                    di1.DN_Qty = 0
                Else
                    di1.DN_Qty = ds.Tables("Delivery").Rows(i)("DN_Qty")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("DN_SP")) Then
                    di1.DN_SP = 0
                Else
                    di1.DN_SP = ds.Tables("Delivery").Rows(i)("DN_SP")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("DN_Help")) Then
                    di1.DN_Help = Nothing
                Else
                    di1.DN_Help = ds.Tables("Delivery").Rows(i)("DN_Help")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("R_NO")) Then
                    di1.R_NO = Nothing
                Else
                    di1.R_NO = ds.Tables("Delivery").Rows(i)("R_NO")
                End If
                If dc.DeliveryPacking_Add(di1) = False Then
                    MsgBox("添加失敗，請檢查原因！")
                    Exit Sub
                End If
            ElseIf Not IsDBNull(ds.Tables("Delivery").Rows(i)("IndexNO")) Then '只修改
                Dim di1 As New DeliveryInfo

                di1.IndexNO = ds.Tables("Delivery").Rows(i)("IndexNO")
                di1.DN_ID = ds.Tables("Delivery").Rows(i)("DN_ID")
                di1.P_NO = ds.Tables("Delivery").Rows(i)("P_NO")

                If IsDBNull(ds.Tables("Delivery").Rows(i)("DNS_NO")) Then
                    di1.DNS_NO = Nothing
                Else

                    di1.DNS_NO = ds.Tables("Delivery").Rows(i)("DNS_NO")
                End If

                di1.P_Type = ds.Tables("Delivery").Rows(i)("P_Type")

                If IsDBNull(ds.Tables("Delivery").Rows(i)("OS_BatchID")) Then
                    di1.OS_BatchID = Nothing
                Else
                    di1.OS_BatchID = ds.Tables("Delivery").Rows(i)("OS_BatchID")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("M_Code")) Then
                    di1.M_Code = Nothing
                Else
                    di1.M_Code = ds.Tables("Delivery").Rows(i)("M_Code")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("DN_Qty")) Then
                    di1.DN_Qty = 0
                Else
                    di1.DN_Qty = ds.Tables("Delivery").Rows(i)("DN_Qty")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("DN_SP")) Then
                    di1.DN_SP = 0
                Else
                    di1.DN_SP = ds.Tables("Delivery").Rows(i)("DN_SP")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("DN_Help")) Then
                    di1.DN_Help = Nothing
                Else
                    di1.DN_Help = ds.Tables("Delivery").Rows(i)("DN_Help")
                End If
                If IsDBNull(ds.Tables("Delivery").Rows(i)("R_NO")) Then
                    di1.R_NO = Nothing
                Else
                    di1.R_NO = ds.Tables("Delivery").Rows(i)("R_NO")
                End If
                If dc.DeliveryPacking_Update(di1) = False Then
                    MsgBox("添加失敗，請檢查原因！")
                    Exit Sub
                End If
            End If

        Next
        Me.Close()
    End Sub

    Sub UpdateCheck()

        Dim di As New DeliveryInfo
        Dim dc As New DeliveryControl
        di.DN_ID = txtID.Text
        di.DN_Check = CheckEdit3.Checked
        di.DN_CheckAction = InUserID
        di.DN_CheckDate = Format(Now, "yyyy/MM/dd")
        di.DN_CheckRemark = MemoEdit2.EditValue
        If dc.DeliveryNote_UpdateCheck(di) = True Then
            MsgBox("已保存審核信息！")
        Else
            MsgBox("審核失敗，請檢查原因！")

        End If
        Me.Close()
    End Sub

    Sub UpdateAccCheck()

        Dim di As New DeliveryInfo
        Dim dc As New DeliveryControl
        di.DN_ID = txtID.Text
        di.DN_AccCheck = CheckEdit4.Checked
        di.DN_AccCheckAction = InUserID
        di.DN_AccCheckDate = Format(Now, "yyyy/MM/dd")
        di.DN_AccCheckRemark = MemoEdit3.EditValue
        di.DN_AccCheckType = cbAccChecktype.EditValue

        If dc.DeliveryNote_UpdateAccCheck(di) = True Then
            MsgBox("已保存審核信息！")
        Else
            MsgBox("審核失敗，請檢查原因！")
        End If
        '------------------------------------------------------涉及到扣數問題
        '------------------------------------------------------
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Select Case Label23.Text
            Case "送貨單"
                If Edit = False Then
                    DataNew()
                Else
                    DataEdit()
                End If
            Case "Check"
                UpdateCheck()
            Case "AccCheck"
                UpdateAccCheck()
        End Select

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    '添加送貨單中裝箱表
    Private Sub DeliveryPackingAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryPackingAdd.Click
        '在公用模塊frmBOMSelect中載入批次及物料

        tempCode = ""
        tempValue6 = "送貨管理"
        frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 1
        frmBOMSelect.ShowDialog()

        If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 1 Then
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue7, ",")
            n = Len(Replace(tempValue7, ",", "," & "*")) - Len(tempValue7)
            For i = 0 To n

                Dim j As Integer

                For j = 0 To ds.Tables("Delivery").Rows.Count - 1
                    If arr(i) = ds.Tables("Delivery").Rows(j)("M_Code") And tempValue2 = ds.Tables("Delivery").Rows(j)("OS_BatchID") Then
                        MsgBox("一張單不允許同一批次存在相同物料編碼....")
                        Exit Sub
                    End If
                Next
                If arr(i) = "" Then
                    Exit Sub
                End If
                Dim mc As New LFERP.Library.Material.MaterialController
                Dim objInfo As New LFERP.Library.Material.MaterialInfo
                objInfo = mc.MaterialCode_Get(arr(i))

                Dim row As DataRow = ds.Tables("Delivery").NewRow

                row("M_Code") = objInfo.M_Code
                row("M_Name") = objInfo.M_Name
                row("M_Gauge") = objInfo.M_Gauge
                row("P_Type") = ""
                row("OS_BatchID") = tempValue2
                row("DN_Qty") = 0
                row("DN_SP") = 0
                row("DN_Help") = ""

                ds.Tables("Delivery").Rows.Add(row)
            Next

        End If
        tempValue2 = ""
        tempValue7 = ""
    
    End Sub
    '刪除送貨單中裝箱表
    Private Sub DeliveryPackingDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryPackingDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "DNS_NO")
        If DelTemp = "DNS_NO" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelDelivery").NewRow
            row("DNS_NO") = DelTemp
            row("DN_ID") = txtID.Text
            ds.Tables("DelDelivery").Rows.Add(row)
        End If
        ds.Tables("Delivery").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub
    '通過掃描標籤獲得裝箱編號
    Private Sub DeliveryPackingScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryPackingScan.Click
        Dim frm As New frmDeliveryScan
        frm.ShowDialog()

        Dim si As New List(Of SingleFactoryInfo)
        Dim sc As New SingleFactoryControl
        If tempValue3 = "" Then
            Exit Sub
        Else
            si = sc.Packing_GetList(tempValue3, Nothing, Nothing)

            If si.Count = 0 Then
                MsgBox("此裝箱編號沒有記錄！")
                Exit Sub
            Else
                Dim row As DataRow

                Dim i As Integer
                For i = 0 To si.Count - 1

                    row = ds.Tables("Delivery").NewRow


                    row("P_NO") = si(i).P_NO
                    row("P_Type") = si(i).P_Type

                    'If i < 10 Then
                    '    row("DNS_NO") = txtID.Text & "0" & i + 1
                    'Else
                    '    row("DNS_NO") = txtID.Text & i + 1
                    'End If

                    row("OS_BatchID") = si(i).OS_BatchID
                    row("DN_Qty") = si(i).P_Qty
                    row("DN_SP") = si(i).P_SP
                    row("M_Code") = si(i).M_Code
                    row("M_Name") = si(i).M_Name
                    row("M_Gauge") = si(i).M_Gauge
                    row("DN_Help") = si(i).P_Help

                    If row("P_Type") = "B" Then
                        Dim si1 As New List(Of SingleFactoryInfo)

                        si1 = sc.PackingSub_GetList(si(i).PB_NO, Nothing)
                        If si1 Is Nothing Then Exit Sub
                        Dim j As Integer

                        For j = 0 To si1.Count - 1

                            Dim di As New DeliveryInfo
                            Dim dc As New DeliveryControl

                            di.DNS_NO = row("DNS_NO")
                            di.M_Code = si1(j).M_Code
                            di.DS_Qty = si1(j).PB_Qty
                            di.DS_SP = si1(j).PB_SP

                            dc.DeliveryPackingSub_Add(di)

                        Next

                    End If

                    ds.Tables("Delivery").Rows.Add(row)

                Next
            End If
            tempValue3 = ""
        End If

    End Sub
    '得到當前裝箱編號中的裝箱配件表
    Private Sub RepositoryItemButtonEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemButtonEdit1.Click
        On Error Resume Next
        If GridView1.GetFocusedRowCellValue("P_Type").ToString = "B" Then

            tempValue2 = GridView1.GetFocusedRowCellValue("DNS_NO").ToString
            tempValue4 = Label23.Text
            EditSub = Edit

            Dim fr As frmDeliveryPackingSub
            For Each fr In MDIMain.MdiChildren
                If TypeOf fr Is frmDeliveryPackingSub Then
                    fr.Activate()
                    Exit Sub
                End If
            Next
            fr = New frmDeliveryPackingSub
            fr.MdiParent = MDIMain
            fr.WindowState = FormWindowState.Maximized
            fr.Show()
        Else
            MsgBox("此類型不允許選擇散件!")
            Exit Sub
        End If

    End Sub

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        frmWareHouseSelect.SelectWareID = ""
        tempValue3 = "800206"
        frmWareHouseSelect.ShowDialog()

        If frmWareHouseSelect.SelectWareID = "" Then

        Else
            ButtonEdit1.Text = frmWareHouseSelect.SelectWareName
            strWHID = frmWareHouseSelect.SelectWareID
        End If
    End Sub
End Class
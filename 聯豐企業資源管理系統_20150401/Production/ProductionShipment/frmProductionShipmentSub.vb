
Imports lferp.Library.ProductionShipment

Public Class frmProductionShipmentSub
    Dim strWHOutID, strWHInID As String
    Dim ds As New DataSet
    Dim oldCheck As Boolean


    Private Sub ShipmentWareOutMainSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = tempValue2
        Label3.Text = tempValue3
        tempValue2 = ""
        tempValue3 = ""
        CreateTable()

        txtWIPID.Enabled = False
        DateEdit1.Text = Format(Now, "yyyy/MM/dd")

        Select Case Label5.Text

            Case "出貨單"
                If Edit = False Then
                    Me.Text = "送貨單--新增"
                    Me.Label1.Text = "送貨單--新增"
                    CheckEdit1.Enabled = False
                    CheckRemark.Enabled = False
                Else
                    txtWIPID.Text = Label3.Text
                    LoadData(Label3.Text)
                    CheckEdit1.Enabled = False
                    CheckRemark.Enabled = False
                    Me.Text = "送貨單--修改" & Label3.Text
                    Me.Label1.Text = "送貨單--修改"
                End If
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "PreView"
                Me.Text = "送貨單--查看" & Label3.Text
                Me.Label1.Text = "送貨單--查看"
                LoadData(Label3.Text)
                cmdSave.Visible = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "Check"
                Me.Text = "送貨單--審核" & Label3.Text
                Me.Label1.Text = "送貨單--審核"
                txtWH.Enabled = False

                cbType.Enabled = False
                DateEdit1.Enabled = False
                txtRemark.Enabled = False
                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False

                LoadData(Label3.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
        End Select

        cmdGuideAdd.Visible = False

        txtWH.Focus()

    End Sub

    Sub CreateTable()

        ds.Tables.Clear()

        With ds.Tables.Add("ShipmentWareOutSub")

            .Columns.Add("SPM_M_Code", GetType(String))
            .Columns.Add("SM_Code", GetType(String))
            .Columns.Add("SM_Name", GetType(String))
            .Columns.Add("SM_Gauge", GetType(String))
            .Columns.Add("SPWO_Qty", GetType(Integer))
            .Columns.Add("SM_Unit", GetType(String))
            .Columns.Add("SPS_Type", GetType(String))
            .Columns.Add("SPS_SubRemark", GetType(String))
            .Columns.Add("SPS_NO_Sub", GetType(String))

        End With
        Grid.DataSource = ds.Tables("ShipmentWareOutSub")

        With ds.Tables.Add("DelShipmentWareOutSub")     '用作修改，已保存了多個物料的單，記錄刪除的某一個，或几個物料
            .Columns.Add("Del_PS_NO", GetType(String))
            .Columns.Add("Del_PS_SUB_NO", GetType(String))
        End With

        RepositoryItemComboBox1.Items.Clear()
        RepositoryItemComboBox1.Items.Add("正常")
        RepositoryItemComboBox1.Items.Add("返修")


    End Sub


    Private Sub txtWH_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        tempCode = "生產倉庫"         ''還需要設置，要權限表中
        frmWareHouseSelect.SelectWareID = ""
        tempValue3 = "881409"
        frmWareHouseSelect.ShowDialog()

        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            strWHOutID = frmWareHouseSelect.SelectWareID
            txtWH.Text = frmWareHouseSelect.SelectWareName
        End If
    End Sub


    Private Sub cmsCodeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCodeAdd.Click
        tempCode = ""
        tempValue6 = "出貨管理"

        frmBOMSelect.XtraTabPage1.PageVisible = True
        frmBOMSelect.XtraTabPage2.PageVisible = False
        frmBOMSelect.XtraTabPage3.PageVisible = True
        'frmBOMSelect.txtLFID.Text = "MG1020-2"
        frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 2

        frmBOMSelect.ShowDialog()

        '增加記錄
        If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 0 Then
            If tempCode = "" Then
                Exit Sub
            Else
                AddRow(tempCode)
            End If
        ElseIf frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 2 Then   '聯豐編號
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue8, ",")
            n = Len(Replace(tempValue8, ",", "," & "*")) - Len(tempValue8)
            For i = 0 To n

                Dim j As Integer

                For j = 0 To ds.Tables("ShipmentWareOutSub").Rows.Count - 1
                    If arr(i) = ds.Tables("ShipmentWareOutSub").Rows(j)("SM_Code") Then
                        MsgBox("一張單不允許有重復物料編碼....")
                        Exit Sub
                    End If
                Next
                If arr(i) = "" Then
                    Exit Sub
                End If

                Dim mc As New LFERP.Library.Material.MaterialController
                Dim objInfo As New LFERP.Library.Material.MaterialInfo

                objInfo = mc.MaterialCode_Get(arr(i))
                Dim row As DataRow
                row = ds.Tables("ShipmentWareOutSub").NewRow

                row("SPM_M_Code") = tempValue3
                row("SM_Code") = objInfo.M_Code
                row("SM_Name") = objInfo.M_Name
                row("SM_Gauge") = objInfo.M_Gauge
                row("SM_Unit") = objInfo.M_Unit
                row("SPWO_Qty") = 0
                row("SPS_Type") = "正常"

                ds.Tables("ShipmentWareOutSub").Rows.Add(row)
                GridView1.MoveLast()
            Next
        End If
        tempValue2 = ""
        tempValue7 = ""
        tempValue8 = ""
        tempValue3 = ""
    End Sub


    Sub AddRow(ByVal strCode As String)
        If strCode = "" Then
        Else

            Dim i As Integer

            For i = 0 To ds.Tables("ShipmentWareOutSub").Rows.Count - 1
                If strCode = ds.Tables("ShipmentWareOutSub").Rows(i)("SM_Code") Then
                    MsgBox("一張單不允許有重復物料編碼....")
                    Exit Sub
                End If
            Next
            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)
            Dim row As DataRow
            row = ds.Tables("ShipmentWareOutSub").NewRow

            If Mid(objInfo.M_Code, 1, 2) = "MG" Then
                row("SPM_M_Code") = objInfo.M_Code
            Else
                row("SPM_M_Code") = ""
            End If

            row("SM_Code") = objInfo.M_Code
            row("SM_Name") = objInfo.M_Name
            row("SM_Unit") = objInfo.M_Unit
            row("SM_Gauge") = objInfo.M_Gauge
            row("SPWO_Qty") = 0
            row("SPS_Type") = "正常"

            ds.Tables("ShipmentWareOutSub").Rows.Add(row)

            GridView1.MoveLast()
        End If
    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label5.Text
            Case "出貨單"
                If Edit = False Then
                    If CheckData() = True Then
                        DataNew()
                    End If
                Else
                    If CheckData() = True Then   ''以前沒加
                        DataEdit()
                    End If
                End If
            Case "Check"  ''審核
                If CheckData() = True Then
                    UpdateCheck()
                End If

        End Select
    End Sub


    Function CheckData() As Boolean  '判斷當前發出倉庫物料是否夠數
        CheckData = True

        If txtWH.Text = "" Then
            MsgBox("倉庫不能為空")
            CheckData = False
            txtWH.Focus()
            Exit Function
        End If

        If DateEdit1.Text = "" Then
            MsgBox("出貨日期不能為空")
            CheckData = False
            DateEdit1.Focus()
            Exit Function
        End If


        'If cbType.Text = "" Then
        '    MsgBox("類型不能為空")
        '    CheckData = False
        '    cbType.Focus()
        '    Exit Function
        'End If


        Dim i As Integer

        For i = 0 To ds.Tables("ShipmentWareOutSub").Rows.Count - 1

            If ds.Tables("ShipmentWareOutSub").Rows(i)("SPWO_Qty") <= 0 Then
                MsgBox("出貨數量不能為0！")
                CheckData = False
                GridView1.FocusedRowHandle = i '移、至錯誤碼行
                GridView1.FocusedColumn = GridView1.Columns("SPWO_Qty")
                Exit Function
            End If

            If ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_Type") = "" Then
                MsgBox("請選擇包裝出貨類型！")
                CheckData = False
                GridView1.FocusedRowHandle = i
                GridView1.FocusedColumn = GridView1.Columns("SPS_Type")
                Exit Function
            End If

            ''--------------------檢查庫存中的安全數量---------------------------------------------------------------
            ''檢查庫存數-------

            Dim Safe_Qty As Single
            Dim Qty As Single
            Dim wi As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi = wc.WareInventory_GetSub(ds.Tables("ShipmentWareOutSub").Rows(i)("SM_Code"), strWHOutID)

            If wi Is Nothing Then
                Qty = 0
                Safe_Qty = 0
            Else
                Qty = wi.WI_Qty
                Safe_Qty = wi.WI_SafeQty '安全庫存
            End If

            If Qty >= ds.Tables("ShipmentWareOutSub").Rows(i)("SPWO_Qty") Then

                If Qty - ds.Tables("ShipmentWareOutSub").Rows(0)("SPWO_Qty") < Safe_Qty Then
                    MsgBox("當前選定倉庫庫存數量小於安全庫存,請確認！")
                    CheckData = False
                    GridView1.FocusedRowHandle = i
                    Exit Function

                Else
                    CheckData = True
                End If
            Else
                GridView1.FocusedRowHandle = i
                MsgBox("當前選定倉庫庫存數量小於發出數量,請確認！")
                CheckData = False
                Exit Function
            End If
        Next

    End Function



    Sub DataNew()
        Dim pi As New ProductionShipmentInfo
        Dim pc As New ProductionShipmentControl

        txtWIPID.Text = GetPSNO()
        pi.PS_NO = txtWIPID.Text
        pi.PS_WareID = strWHOutID
        pi.PS_Date = DateEdit1.Text
        pi.PS_Remark = txtRemark.Text
        pi.PS_Action = InUserID
        pi.PM_Type = cbType.EditValue


        Dim i As Integer

        For i = 0 To ds.Tables("ShipmentWareOutSub").Rows.Count - 1
            pi.PS_NO_Sub = GetSubNO()

            pi.PM_M_Code = ds.Tables("ShipmentWareOutSub").Rows(i)("SPM_M_Code")

            pi.M_Code = ds.Tables("ShipmentWareOutSub").Rows(i)("SM_Code")

            If IsDBNull(ds.Tables("ShipmentWareOutSub").Rows(i)("SPWO_Qty")) Then
                pi.PS_Qty = 0
            Else
                pi.PS_Qty = ds.Tables("ShipmentWareOutSub").Rows(i)("SPWO_Qty")
            End If

            If IsDBNull(ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_Type")) Then
                pi.PS_Type = Nothing
            Else
                pi.PS_Type = ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_Type")
            End If


            If IsDBNull(ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_SubRemark")) Then
                pi.PS_SubRemark = Nothing
            Else
                pi.PS_SubRemark = ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_SubRemark")
            End If

            pc.ProductionShipment_Add(pi)
        Next

        MsgBox("已保存,單號: " & txtWIPID.Text & " ")
        Me.Close()

    End Sub
    Private Function GetPSNO() As String
        Dim pi As New ProductionShipmentInfo
        Dim pc As New ProductionShipmentControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionShipment_GetNO(strA)
        If pi Is Nothing Then
            GetPSNO = "S" & strA & "0001"
        Else
            GetPSNO = "S" + strA + Mid((CInt(Mid(pi.PS_NO, 6)) + 10001), 2)
        End If

    End Function

    Private Function GetSubNO() As String
        Dim pi As New ProductionShipmentInfo
        Dim pc As New ProductionShipmentControl
        Dim strA As String
        strA = Format(Now, "yyMM")
        pi = pc.ProductionShipment_GetSubNO(strA)
        If pi Is Nothing Then
            GetSubNO = "SS" & strA & "0001"
        Else
            GetSubNO = "SS" + strA + Mid((CInt(Mid(pi.PS_NO_Sub, 7)) + 10001), 2)
        End If

    End Function

    Public Function LoadData(ByVal PS_NO As String) As Boolean
        LoadData = True

        ds.Tables("ShipmentWareOutSub").Clear()

        Dim piL As List(Of ProductionShipmentInfo)
        Dim pc As New ProductionShipmentControl
        piL = pc.ProductionShipment_GetList(PS_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        Try
            If piL.Count = 0 Then
                MsgBox("沒有數據")
                LoadData = False
                Exit Function
            Else
                strWHOutID = piL(0).PS_WareID
                txtWIPID.Text = piL(0).PS_NO
                txtWH.EditValue = piL(0).PS_OutName
                cbType.EditValue = piL(0).PM_Type
                DateEdit1.EditValue = piL(0).PS_Date
                txtRemark.Text = piL(0).PS_Remark
                CheckEdit1.Checked = piL(0).PS_Check
                CheckAction.Text = piL(0).PS_CheckAction_N

                If CheckEdit1.Checked = True Then
                    oldCheck = True
                Else
                    oldCheck = False
                End If

                CheckDate.Text = piL(0).PS_CheckDate
                CheckRemark.Text = piL(0).PS_CheckRemark

                Dim i As Integer
                Dim row As DataRow
                For i = 0 To piL.Count - 1

                    row = ds.Tables("ShipmentWareOutSub").NewRow
                    row("SPM_M_Code") = piL(i).PM_M_Code
                    row("SM_Code") = piL(i).M_Code
                    row("SM_Name") = piL(i).PS_M_Name
                    row("SPS_Type") = piL(i).PS_Type
                    row("SM_Gauge") = piL(i).PS_M_Gauge
                    row("SM_Unit") = piL(i).PS_M_Unit
                    row("SPWO_Qty") = piL(i).PS_Qty
                    row("SPS_NO_Sub") = piL(i).PS_NO_Sub
                    row("SPS_SubRemark") = piL(i).PS_SubRemark

                    ds.Tables("ShipmentWareOutSub").Rows.Add(row)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Sub UpdateCheck()

        Dim pi As New ProductionShipmentInfo
        Dim pc As New ProductionShipmentControl

        If oldCheck = CheckEdit1.Checked Then
            MsgBox("審核狀態未改變，請更改狀態後再保存…")
            Exit Sub
        End If

        pi.PS_NO = txtWIPID.Text   ''審核的一些基本信息
        pi.PS_Check = CheckEdit1.Checked
        pi.PS_CheckAction = InUserID
        pi.PS_CheckDate = Format(Now, "yyyy/MM/dd")
        pi.PS_CheckRemark = CheckRemark.Text

        If pc.ProductionShipment_UpdateCheck(pi) = True Then
            MsgBox("審核狀態已改變!")
        Else
            MsgBox("審核失敗,請檢查原因!")
            Exit Sub   ''核查失敗應不能減庫存
        End If
        '--------------------------------------------------------------------------出貨記錄扣數信息
        Dim ui As New LFERP.Library.Purchase.SharePurchase.SharePurchaseInfo
        Dim uc As New LFERP.Library.Purchase.SharePurchase.SharePurchaseController

        Dim i As Integer
        ui.WH_ID = strWHOutID ''倉庫號

        For i = 0 To ds.Tables("ShipmentWareOutSub").Rows.Count - 1
            ui.M_Code = ds.Tables("ShipmentWareOutSub").Rows(i)("SM_Code")  ''物料編碼

            If CheckEdit1.Checked = False Then
                ui.WI_Qty = CSng(ds.Tables("ShipmentWareOutSub").Rows(i)("SPWO_Qty"))
            ElseIf CheckEdit1.Checked = True Then
                ui.WI_Qty = -CSng(ds.Tables("ShipmentWareOutSub").Rows(i)("SPWO_Qty"))
            End If

            uc.UpdateWareInventory_WIQty(ui)
        Next


        '--------------------------------------------------------------------------

    End Sub
    Private Sub cmsCodeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsCodeDel.Click
        On Error Resume Next
        If GridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "SPS_NO_Sub")   ''記錄刪除記錄

        If DelTemp = "SM_Code" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelShipmentWareOutSub").NewRow
            row("Del_PS_NO") = txtWIPID.Text
            row("Del_PS_SUB_NO") = DelTemp
            ds.Tables("DelShipmentWareOutSub").Rows.Add(row)
        End If
        ds.Tables("ShipmentWareOutSub").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Sub DataEdit()

        Dim i As Integer
        Dim pi As New ProductionShipmentInfo
        Dim pc As New ProductionShipmentControl

        '更新刪除的記錄
        If ds.Tables("DelShipmentWareOutSub").Rows.Count > 0 Then   ''更新刪除已修改的記錄
            Dim j As Integer
            For j = 0 To ds.Tables("DelShipmentWareOutSub").Rows.Count - 1
                If Not IsDBNull(ds.Tables("DelShipmentWareOutSub").Rows(j)("Del_PS_SUB_NO")) Then
                    'MsgBox(ds.Tables("DelShipmentWareOutSub").Rows(j)("Del_PS_SUB_NO"))
                    pc.ProductionShipment_Delete(ds.Tables("DelShipmentWareOutSub").Rows(j)("Del_PS_NO"), ds.Tables("DelShipmentWareOutSub").Rows(j)("Del_PS_SUB_NO"))
                End If
            Next j
        End If

        For i = 0 To ds.Tables("ShipmentWareOutSub").Rows.Count - 1

            pi.PS_NO = txtWIPID.Text
            pi.PS_WareID = strWHOutID
            pi.PS_Date = DateEdit1.Text
            pi.PS_Remark = txtRemark.Text
            pi.PS_Action = InUserID
            pi.PM_Type = cbType.EditValue

            pi.PM_M_Code = ds.Tables("ShipmentWareOutSub").Rows(i)("SPM_M_Code")

            pi.M_Code = ds.Tables("ShipmentWareOutSub").Rows(i)("SM_Code")

            If IsDBNull(ds.Tables("ShipmentWareOutSub").Rows(i)("SPWO_Qty")) Then
                pi.PS_Qty = 0
            Else
                pi.PS_Qty = ds.Tables("ShipmentWareOutSub").Rows(i)("SPWO_Qty")
            End If

            If IsDBNull(ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_Type")) Then
                pi.PS_Type = Nothing
            Else
                pi.PS_Type = ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_Type")
            End If

            If IsDBNull(ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_SubRemark")) Then
                pi.PS_SubRemark = Nothing
            Else
                pi.PS_SubRemark = ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_SubRemark")
            End If

            'MsgBox(ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_SubRemark"))

            If IsDBNull(ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_NO_Sub")) Then    ''修改中增加前面沒有加的物料編碼------------
                pi.PS_NO_Sub = GetSubNO()
                pc.ProductionShipment_Add(pi)          ''更新或增加條件為(出貨單號，子單號(物料編碼))
            ElseIf Not IsDBNull(ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_NO_Sub")) Then
                pi.PS_NO_Sub = ds.Tables("ShipmentWareOutSub").Rows(i)("SPS_NO_Sub")
                pc.ProductionShipment_update(pi)
            End If
        Next

        MsgBox("已保存,單號: " & txtWIPID.Text & " ")
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
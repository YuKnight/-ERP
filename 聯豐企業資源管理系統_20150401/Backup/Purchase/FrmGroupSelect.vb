Imports LFERP.SystemManager
Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library

Public Class FrmGroupSelect
    Dim mtc As New Material.MaterialTypeController
    Dim ds As New DataSet
    Dim StrCode As String, StrSupplier As String, StrDate1 As String, StrDate2 As String, strType As String, strPurchaseType As String, strPmActor As String
    Dim StrPurActor As String
    Private Sub FrmGroupSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CreateTable()
        Dim mtd As New LFERP.DataSetting.SuppliersControler
        Dim uls As New SystemUser.SystemUserController

        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")

        GridLookUpEdit1.Properties.DisplayMember = "U_Name"
        GridLookUpEdit1.Properties.ValueMember = "U_ID"
        GridLookUpEdit1.Properties.DataSource = uls.SystemUser_GetList(Nothing, Nothing, "10010103")

        mtc.LoadNodes(tv1, ErpUser.MaterialType)
        DateEdit1.EditValue = Now
        DateEdit2.EditValue = Now
        ComboBoxEdit1.Select()
    End Sub
    Private Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("S_Supply")
            .Columns.Add("S_Supplier", GetType(String))
            .Columns.Add("S_SupplierName", GetType(String))
        End With
        GridControl1.DataSource = ds.Tables("S_Supply")
    End Sub
    Private Sub tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv1.AfterSelect
        PopupContainerEdit1.EditValue = tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim rptds As New DataSet
        Dim ltc As New CollectionToDataSet
        Dim ltc1 As New CollectionToDataSet
        Dim ltc2 As New CollectionToDataSet
        Dim ltc3 As New CollectionToDataSet
        Dim ltc4 As New CollectionToDataSet
        Dim ltc5 As New CollectionToDataSet
        If ComboBoxEdit1.Text = "" Then
            MsgBox("請輸入採購類型")
            Exit Sub
        End If

        If CheckEdit3.Checked = True Then
            StrDate1 = Format(DateEdit1.EditValue, "yyyy/MM/dd")
            StrDate2 = Format(DateEdit2.EditValue, "yyyy/MM/dd")
        Else
            StrDate1 = Nothing
            StrDate2 = Nothing
        End If

        If CheckEdit2.Checked = True Then
            StrSupplier = ""
            If GridView2.RowCount > 0 Then
                If GridView2.RowCount = 1 Then
                    StrSupplier = "'" & ds.Tables("S_Supply").Rows(0)("S_Supplier") & "'"
                Else
                    For i As Integer = 0 To ds.Tables("S_Supply").Rows.Count - 1
                        If i = 0 Then
                            StrSupplier = "'" & ds.Tables("S_Supply").Rows(i)("S_Supplier") & "'"
                        Else
                            StrSupplier = StrSupplier & ", '" & ds.Tables("S_Supply").Rows(i)("S_Supplier") & "'"
                        End If
                    Next
                End If
            Else
                MsgBox("請選擇供應商!", 64, "提示")
                gluSupplier.Focus()
                Exit Sub
            End If
        Else
            StrSupplier = Nothing
        End If

        If CheckEdit5.Checked = True Then
            If GridLookUpEdit1.Text = "" Then
                MsgBox("請選擇採購員!", 64, "提示")
                GridLookUpEdit1.Focus()
                Exit Sub
            End If
            StrPurActor = GridLookUpEdit1.EditValue
        Else
            StrPurActor = Nothing
        End If

        If CheckEdit6.Checked = False Then
            strPurchaseType = Mid(ComboBoxEdit1.Text, 5)
            strType = strPurchaseType

            If strType = "全部" Then strType = Nothing

            If CheckEdit1.Checked = True Then
                If PopupContainerEdit1.Text = "" Then
                    MsgBox("請選擇物料類別!", 64, "提示")
                    PopupContainerEdit1.Focus()
                    Exit Sub
                End If
                StrCode = PopupContainerEdit1.EditValue
            Else
                StrCode = Nothing
            End If

            If strType = "更改單" Then
                Dim Mcc As New LFERP.Library.Material.MaterialController
                Dim Cmc As New LFERP.Library.Purchase.Change.ChangeControl
                Dim suc As New LFERP.SystemManager.SystemUser.SystemUserController
                Dim sc As New LFERP.DataSetting.SuppliersControler

                ltc.CollToDataSet(rptds, "MaterialCode", Mcc.MaterialCode_GetList(Nothing, Nothing, Nothing))
                ltc1.CollToDataSet(rptds, "Change", Cmc.ChangeGroup_GetList(StrDate1, StrDate2, StrSupplier, StrCode))
                ltc2.CollToDataSet(rptds, "SystemUser", suc.SystemUser_GetList(Nothing, Nothing, Nothing))
                ltc3.CollToDataSet(rptds, "Suppliers", sc.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))

                PreviewRPT(rptds, "rptChangeGroup", "更改單匯總", True, True)

            ElseIf strType = "退貨單" Then

                Dim mcCompany As New LFERP.DataSetting.CompanyControler
                Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
                Dim mcRetrocede As New LFERP.Library.Purchase.Retrocede.RetrocedeController
                Dim mcsysuser As New LFERP.SystemManager.SystemUser.SystemUserController

                ltc.CollToDataSet(rptds, "Company", mcCompany.Company_Getlist(Nothing, Nothing, Nothing, Nothing))
                ltc1.CollToDataSet(rptds, "Suppliers", mcSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
                ltc2.CollToDataSet(rptds, "Retrocede", mcRetrocede.RetrocedeGroup_GetList(StrDate1, StrDate2, StrSupplier, StrCode))
                ltc3.CollToDataSet(rptds, "SystemUser", mcsysuser.SystemUser_GetList(Nothing, Nothing, Nothing))

                PreviewRPT(rptds, "rptRetrocedeGroup", "退貨單匯總", True, False)

            ElseIf strType = "驗收單" Then

                Dim pmc As New LFERP.Library.Purchase.Purchase.PurchaseMainController
                Dim ac As New LFERP.Library.Purchase.Acceptance.AcceptanceController
                Dim uc As New LFERP.DataSetting.UnitController
                Dim suc As New SystemUser.SystemUserController
                Dim cc As New LFERP.DataSetting.CompanyControler

                ltc.CollToDataSet(rptds, "PurchaseMain", pmc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
                ltc1.CollToDataSet(rptds, "Acceptance", ac.AcceptanceGroup_GetList(StrDate1, StrDate2, StrSupplier, StrCode))
                ltc2.CollToDataSet(rptds, "Unit", uc.GetUnitList(Nothing))
                ltc3.CollToDataSet(rptds, "SystemUser", suc.SystemUser_GetList(Nothing, Nothing, Nothing))
                ltc4.CollToDataSet(rptds, "Company", cc.Company_Getlist(Nothing, Nothing, Nothing, Nothing))

                PreviewRPT(rptds, "rptAcceptanceGroup", "驗收單匯總", True, True)

            ElseIf strType = Nothing Then

                Dim mcCompany As New LFERP.DataSetting.CompanyControler
                Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
                Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
                Dim mcsysuser As New LFERP.SystemManager.SystemUser.SystemUserController
                Dim mctarriff As New LFERP.DataSetting.TarriffController
                Dim mcunit As New LFERP.DataSetting.UnitController

                'MsgBox(StrCode)
                ltc.CollToDataSet(rptds, "Company", mcCompany.Company_Getlist(Nothing, Nothing, Nothing, Nothing))
                ltc1.CollToDataSet(rptds, "Suppliers", mcSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
                ltc2.CollToDataSet(rptds, "PurchaseMain", mcPurchase.PurchaseMainGroup_GetList3(Nothing, Nothing, Nothing, StrCode, Nothing, Nothing, Nothing, StrDate1, StrDate2, StrSupplier, StrPurActor, Nothing, True, Nothing, Nothing, Nothing))
                ltc3.CollToDataSet(rptds, "SystemUser", mcsysuser.SystemUser_GetList(Nothing, Nothing, Nothing))
                ltc4.CollToDataSet(rptds, "Tarriff", mctarriff.TarriffGetList(Nothing))
                ltc5.CollToDataSet(rptds, "Unit", mcunit.GetUnitList(Nothing))

                PreviewRPT(rptds, "rptPurchaseMainAllGroup", "採購單--" & strType & "匯總", True, True)
            Else

                Dim mcCompany As New LFERP.DataSetting.CompanyControler
                Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
                Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
                Dim mcsysuser As New LFERP.SystemManager.SystemUser.SystemUserController
                Dim mctarriff As New LFERP.DataSetting.TarriffController
                Dim mcunit As New LFERP.DataSetting.UnitController

                If strType = "手開採購單" Then
                    strPurchaseType = "物料"
                Else
                    strType = "采購作業"
                End If

                ltc.CollToDataSet(rptds, "Company", mcCompany.Company_Getlist(Nothing, Nothing, Nothing, Nothing))
                ltc1.CollToDataSet(rptds, "Suppliers", mcSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
                ltc2.CollToDataSet(rptds, "PurchaseMain", mcPurchase.PurchaseMainGroup_GetList(strType, strPurchaseType, StrDate1, StrDate2, StrSupplier, StrCode))
                ltc3.CollToDataSet(rptds, "SystemUser", mcsysuser.SystemUser_GetList(Nothing, Nothing, Nothing))
                ltc4.CollToDataSet(rptds, "Tarriff", mctarriff.TarriffGetList(Nothing))
                ltc5.CollToDataSet(rptds, "Unit", mcunit.GetUnitList(Nothing))

                PreviewRPT(rptds, "rptPurchaseMainGroup", "採購單--" & strType & "匯總", True, True)
            End If
        Else
            If ComboBoxEdit2.Text = "" Then
                MsgBox("請選擇匯總類別!", 64, "提示")
                ComboBoxEdit2.Focus()
                Exit Sub
            End If

            Dim mcCompany As New LFERP.DataSetting.CompanyControler
            Dim mcSupplier As New LFERP.DataSetting.SuppliersControler
            Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
            Dim mcsysuser As New LFERP.SystemManager.SystemUser.SystemUserController
            Dim mctarriff As New LFERP.DataSetting.TarriffController
            Dim mcunit As New LFERP.DataSetting.UnitController
            'Dim pi As List(Of LFERP.Library.Purchase.Purchase.PurchaseMainInfo)
            'pi = mcPurchase.PurchaseMain_Getlist2(PopupContainerEdit1.EditValue, StrPurActor, StrDate1, StrDate2, StrSupplier)
            'If pi.Count > 0 Then

            '    ll.Text = pi.Item(0).BeginPurchaseDate & pi.Item(0).EndPurchaseDate

            'End If

            ltc.CollToDataSet(rptds, "Company", mcCompany.Company_Getlist(Nothing, Nothing, Nothing, Nothing))
            ltc1.CollToDataSet(rptds, "Suppliers", mcSupplier.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(rptds, "SystemUser", mcsysuser.SystemUser_GetList(Nothing, Nothing, Nothing))
            ltc4.CollToDataSet(rptds, "Tarriff", mctarriff.TarriffGetList(Nothing))
            ltc5.CollToDataSet(rptds, "Unit", mcunit.GetUnitList(Nothing))
            If Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 1 Then
                CheckEdit1.Enabled = False
                CheckEdit2.Enabled = False
                ltc2.CollToDataSet(rptds, "PurchaseMain", mcPurchase.PurchaseMain_Getlist1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, StrDate1, StrDate2, Nothing, StrPurActor, Nothing, True, Nothing, Nothing, Nothing))
                PreviewRPT(rptds, "rptPurchasePrice", "採購單--" & strType & "匯總", True, True)
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 2 Then
                CheckEdit1.Enabled = False
                'CheckEdit2.Enabled = False
                ltc2.CollToDataSet(rptds, "PurchaseMain", mcPurchase.PurchaseMainGroup_GetList3(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, StrDate1, StrDate2, StrSupplier, StrPurActor, Nothing, True, Nothing, Nothing, Nothing))
                PreviewRPT(rptds, "rptPurchaseSupplies", "採購單--" & strType & "匯總", True, True)
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 3 Then
                CheckEdit1.Enabled = False
                CheckEdit2.Enabled = False
                ltc2.CollToDataSet(rptds, "PurchaseMain", mcPurchase.PurchaseMain_Getlist1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, StrDate1, StrDate2, Nothing, StrPurActor, Nothing, True, Nothing, Nothing, Nothing))
                PreviewRPT(rptds, "rptPurchasePmActor", "採購單--" & strType & "匯總", True, True)
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 4 Then
                CheckEdit1.Enabled = False
                CheckEdit2.Enabled = False
                ltc2.CollToDataSet(rptds, "PurchaseMain", mcPurchase.PurchaseMain_Getlist1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, StrDate1, StrDate2, Nothing, StrPurActor, Nothing, True, Nothing, Nothing, Nothing))
                PreviewRPT(rptds, "rptPurchasePmActorSupplies", "採購單--" & strType & "匯總", True, True)
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 5 Then
                CheckEdit1.Enabled = False
                CheckEdit2.Enabled = False
                ltc2.CollToDataSet(rptds, "PurchaseMain", mcPurchase.PurchaseMain_Getlist1(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, StrDate1, StrDate2, Nothing, StrPurActor, Nothing, True, Nothing, Nothing, Nothing))
                PreviewRPT(rptds, "rptPurchaseActorsPmCode", "採購單--" & strType & "匯總", True, True)
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 6 Then
                If PopupContainerEdit1.Text = "" Then
                    MsgBox("請選擇物料類別!", 64, "提示")
                Else
                    ltc2.CollToDataSet(rptds, "PurchaseMain", mcPurchase.PurchaseMain_Getlist2(PopupContainerEdit1.EditValue, StrPurActor, StrDate1, StrDate2, StrSupplier))
                    PreviewRPT(rptds, "rptPurchaseMTypeGroup", "採購單--" & strType & "匯總", True, True)
                End If
            End If
            End If

            rptds.Tables.Clear()

            ltc = Nothing
            ltc1 = Nothing
            ltc2 = Nothing
            ltc3 = Nothing
            ltc4 = Nothing
            ltc5 = Nothing
            'Me.Close()
    End Sub

    ''' <summary>
    ''' 右鍵菜單刪除事件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DelMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DelMenuItem.Click

        If GridView1.RowCount > 0 And GridView2.SelectedRowsCount > 0 Then
            ds.Tables("S_Supply").Rows.RemoveAt(CInt(ArrayToString(GridView2.GetSelectedRows())))
            GridView2.Focus()
            GridView2.SelectRow(0) '選擇第一行
            GridView2.FocusedRowHandle = 0 '焦點落在第一行
        End If

    End Sub

    ''' <summary>
    ''' 添加供應商，存在一缺陷，當控件gluSupplier中的內容不改變時，供應商添加不上
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluSupplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluSupplier.EditValueChanged
        'On Error Resume Next
        If CheckEdit2.Checked = True Then
            If Trim(gluSupplier.Text) <> "" Then
                If ds.Tables("S_Supply").Rows.Count - 1 > 0 Then
                    Dim i%
                    For i = 0 To ds.Tables("S_Supply").Rows.Count - 1
                        If ds.Tables("S_Supply").Rows(i)("S_Supplier") = gluSupplier.EditValue Then
                            MsgBox("該供應商已選定,不需再選!", 64, "提示")
                            Exit Sub
                        End If
                    Next
                End If
                Dim row As DataRow
                row = ds.Tables("S_Supply").NewRow
                row("S_Supplier") = gluSupplier.EditValue
                row("S_SupplierName") = gluSupplier.Text
                ds.Tables("S_Supply").Rows.Add(row)
            End If
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged, CheckEdit2.CheckedChanged, CheckEdit3.CheckedChanged, CheckEdit5.CheckedChanged, CheckEdit6.CheckedChanged
        Select Case sender.name
            Case "CheckEdit6"
                If CheckEdit6.Checked = True Then
                    ComboBoxEdit2.Enabled = True
                    ComboBoxEdit2.Focus()
                Else
                    ComboBoxEdit2.Enabled = False
                    ComboBoxEdit2.Text = ""
                    CheckEdit1.Enabled = True
                    CheckEdit2.Enabled = True
                    CheckEdit5.Enabled = True
                End If
            Case "CheckEdit1"
                If CheckEdit1.Checked = True Then
                    PopupContainerEdit1.Enabled = True
                    PopupContainerEdit1.Focus()
                Else
                    PopupContainerEdit1.Text = ""
                    PopupContainerEdit1.Enabled = False
                End If
            Case "CheckEdit5"
                If CheckEdit5.Checked = True Then
                    GridLookUpEdit1.Enabled = True
                    GridLookUpEdit1.Focus()
                Else
                    GridLookUpEdit1.Text = ""
                    GridLookUpEdit1.Enabled = False
                End If
            Case "CheckEdit2"
                If CheckEdit2.Checked = True Then
                    gluSupplier.Enabled = True
                    gluSupplier.Focus()
                    CreateTable()
                Else
                    gluSupplier.Enabled = False
                    gluSupplier.Text = ""
                    gluSupplier.EditValue = ""
                    GridControl1.DataSource = Nothing
                End If
            Case "CheckEdit3"
                If CheckEdit3.Checked = True Then
                    DateEdit1.Enabled = True
                    DateEdit2.Enabled = True
                    DateEdit1.EditValue = Now
                    DateEdit2.EditValue = Now
                    DateEdit1.Focus()
                Else
                    DateEdit1.Enabled = False
                    DateEdit2.Enabled = False
                    DateEdit1.EditValue = ""
                    DateEdit2.EditValue = ""
                End If
        End Select

    End Sub

    Private Sub GridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.Click
        'If CheckEdit2.Checked = True Then
        '    If Trim(gluSupplier.Text) <> "" Then
        'On Error Resume Next
        'If ds.Tables("S_Supply").Rows.Count > 0 And GridView1.SelectedRowsCount > 1 Then
        '    Dim i%
        '    For i = 0 To ds.Tables("S_Supply").Rows.Count - 1
        '        If ds.Tables("S_Supply").Rows(i)("S_Supplier") = GridView1.GetFocusedRowCellValue("S_Supplier").ToString Then
        '            MsgBox("該供應商已選定,不需再選!", 64, "提示")
        '            Exit Sub
        '        End If
        '    Next
        'End If
        'Dim row As DataRow
        'row = ds.Tables("S_Supply").NewRow
        'row("S_Supplier") = GridView1.GetFocusedRowCellValue("S_Supplier").ToString
        'row("S_SupplierName") = GridView1.GetFocusedRowCellValue("S_SupplierName").ToString
        'ds.Tables("S_Supply").Rows.Add(row)
        ''    End If
        'End If
    End Sub

    Private Sub GridView1_GridMenuItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs) Handles GridView1.GridMenuItemClick

    End Sub

    ''' <summary>
    ''' 按Delete鍵刪除GridView2中選中的供應商，調用右鍵菜單刪除事件
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub GridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        If e.KeyCode = Keys.Delete Then
            DelMenuItem_Click(Nothing, Nothing)
        End If
    End Sub

    '@ 2012/1/13 添加選項限制
    Private Sub ComboBoxEdit2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxEdit2.SelectedIndexChanged
        If Trim(ComboBoxEdit2.Text.ToString) <> "" Then
            If Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 1 Then
                CheckEdit1.Checked = False
                CheckEdit2.Checked = False
                CheckEdit1.Enabled = False
                CheckEdit2.Enabled = False
                CheckEdit5.Enabled = True
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 2 Then
                CheckEdit1.Checked = False
                CheckEdit2.Checked = False
                CheckEdit5.Checked = False
                CheckEdit1.Enabled = False
                CheckEdit2.Enabled = True
                CheckEdit5.Enabled = False
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 3 Then
                CheckEdit1.Checked = False
                CheckEdit2.Checked = False
                CheckEdit1.Enabled = False
                CheckEdit2.Enabled = False
                CheckEdit5.Enabled = True
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 4 Then
                CheckEdit1.Checked = False
                CheckEdit2.Checked = False
                CheckEdit1.Enabled = False
                CheckEdit2.Enabled = False
                CheckEdit5.Enabled = True
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 5 Then
                CheckEdit1.Checked = False
                CheckEdit2.Checked = False
                CheckEdit1.Enabled = False
                CheckEdit2.Enabled = False
                CheckEdit5.Enabled = True
            ElseIf Mid(Trim(ComboBoxEdit2.Text.ToString), 1, 1) = 6 Then
                CheckEdit1.Enabled = True
                CheckEdit2.Enabled = True
                CheckEdit5.Enabled = True
            End If
        End If
    End Sub
End Class
Imports LFERP.Library.MrpManager.MrpSupplierQuotation
Imports LFERP.Library.MrpManager.MrpMaterialCode
Imports LFERP.DataSetting
Imports LFERP.Library.Material
Imports LFERP.Library.WareHouse

Public Class frmMrpMaterialCodeQuotation

#Region "屬性"
    Private _EditItem As String
    Private _Type As Boolean
    Private _StrMcode As String
    Public Property EditItem()
        Get
            Return _EditItem
        End Get
        Set(ByVal value)
            _EditItem = value
        End Set
    End Property

    Public Property Type() As Boolean
        Get
            Return _Type
        End Get
        Set(ByVal value As Boolean)
            _Type = value
        End Set
    End Property

    Private _StrMrpSQID As String
    Public Property StrMrpSQID()
        Get
            Return _StrMrpSQID
        End Get
        Set(ByVal value)
            _StrMrpSQID = value
        End Set
    End Property

    Public Property StrMcode() As String
        Get
            Return _StrMcode
        End Get
        Set(ByVal value As String)
            _StrMcode = value
        End Set
    End Property
    Private IsCheck As Boolean
    Dim ds As New DataSet
    Dim mrpSQcon As New MrpSupplierQuotationController
    Dim sccon As New SuppliersControler
    Dim mmcCon As New MrpMaterialCodeController
    Dim mtrCon As New MaterialController
    Dim whCon As New WareHouseController
#End Region

#Region "窗體載入"
    Private Sub frmMrpMaterialCodeQuotation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        GridControl1.DataSource = sccon.Suppliers_GetDataTable(Nothing)


        GLU_MCode.Properties.DisplayMember = "M_Code"
        GLU_MCode.Properties.ValueMember = "M_Code"
        GLU_MCode.Properties.DataSource = mtrCon.MaterialCode_GetDataTable(Nothing)


        glu_MC_WH_ID.Properties.DisplayMember = "WH_Name"
        glu_MC_WH_ID.Properties.ValueMember = "WH_ID"
        glu_MC_WH_ID.Properties.DataSource = whCon.WareHouse_GetDataTable(Nothing)


        Select Case EditItem
            Case EditEnumType.ADD
                If Type = False Then
                    txt_CreateUserID.Text = InUserID
                    GLU_MCode.EditValue = True
                Else
                    LoadTable()
                    GroupBox1.Enabled = False
                End If
            Case EditEnumType.EDIT
                LoadTable()
                If Type = False Then
                    tsmNew.Visible = False
                    tsmDelete.Visible = False
                    tsm_Check.Visible = False
                Else
                    GroupBox1.Enabled = False
                End If
            Case EditEnumType.CHECK
                LoadTable()
                GroupBox1.Enabled = False
                tsmNew.Visible = False
                tsmDelete.Visible = False
                tsm_Check.Visible = False
                GridView.OptionsBehavior.Editable = False
                If Type = False Then
                    xtpCheck.PageVisible = True
                    lblCheckDate.Text = Format(Now, "yyyy/MM/dd")
                    lblCheckUserID.Text = InUserID
                    xtcTable.SelectedTabPage = xtpCheck
                Else
                    tsm_Check.Visible = True
                End If
            Case EditEnumType.VIEW
                LoadTable()
                GroupBox1.Enabled = False
                GridView.OptionsBehavior.Editable = False
                tsmNew.Visible = False
                tsmDelete.Visible = False
                tsm_Check.Visible = False
        End Select
        If GridView.RowCount > 0 Then
            GridView.Columns("CheckBit").Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Dim colorFix As New Color
            colorFix = Color.FromArgb(224, 224, 224)

            GridView.Columns("S_SupplierName").AppearanceCell.BackColor = colorFix
            GridView.Columns("Contacts").AppearanceCell.BackColor = colorFix
            GridView.Columns("Tel").AppearanceCell.BackColor = colorFix
            GridView.Columns("Fax").AppearanceCell.BackColor = colorFix
            GridView.Columns("Email").AppearanceCell.BackColor = colorFix
            GridView.Columns("PaymentType").AppearanceCell.BackColor = colorFix
            GridView.Columns("CurrencyName").AppearanceCell.BackColor = colorFix
            GridView.Columns("M_Unit").AppearanceCell.BackColor = colorFix
            GridView.Columns("CheckBit").AppearanceCell.BackColor = colorFix
        End If
    End Sub
#End Region

#Region "按鍵事件"
    '1.退出事件
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    '2.保存事件
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckEmtry() = False Then
            Exit Sub
        End If
        Select Case EditItem
            Case EditEnumType.ADD
                SaveData()
            Case EditEnumType.EDIT
                SaveData()
            Case EditEnumType.CHECK
                SaveCheck()
        End Select
    End Sub
#End Region

#Region "表格菜單事件"
    Private Sub tsmNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmNew.Click
        Dim mmcList As New List(Of MrpMaterialCodeInfo)
        mmcList = mmcCon.MrpMaterialCode_GetList(StrMcode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If mmcList.Count <= 0 Then
            Exit Sub
        End If
        Dim row As DataRow = ds.Tables("MrpMaterialCodeQuotation").NewRow
        row("M_Name") = mmcList(0).M_Name
        row("M_Gauge") = mmcList(0).M_Gauge
        row("MCode") = mmcList(0).M_Code
        row("M_Source") = mmcList(0).MC_Source
        row("M_Unit") = mmcList(0).M_Unit
        row("CheckBit") = False
        row("AutoID") = 0
        ds.Tables("MrpMaterialCodeQuotation").Rows.Add(row)
        GridView.FocusedRowHandle = GridView.RowCount - 1
    End Sub

    Private Sub tsmDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmDelete.Click
        If GridView.RowCount <= 0 Then
            Exit Sub
        End If
        Dim row As DataRow
        row = ds.Tables("DelTable").NewRow
        row("AutoID") = GridView.GetFocusedRowCellValue("AutoID")
        ds.Tables("DelTable").Rows.Add(row)
        GridView.DeleteRow(GridView.FocusedRowHandle())
        GridView.FocusedRowHandle = GridView.RowCount - 1
    End Sub
#End Region

#Region "創建臨時子表"
    Private Sub CreateTable()
        ds.Tables.Clear()
        '創建臨時子表
        With ds.Tables.Add("MrpMaterialCodeQuotation")
            .Columns.Add("MCode", GetType(String))
            .Columns.Add("S_Supplier", GetType(String))
            .Columns.Add("EconomicQty", GetType(String))
            .Columns.Add("OrderQty", GetType(String))
            .Columns.Add("DeliveryDate", GetType(String))
            .Columns.Add("MaxQty", GetType(String))
            .Columns.Add("MinQty", GetType(String))
            .Columns.Add("ResponsibleUserID", GetType(String))
            .Columns.Add("UnitPrice", GetType(String))
            .Columns.Add("Remark", GetType(String))
            .Columns.Add("CreateUserID", GetType(String))
            .Columns.Add("CreateDate", GetType(Date))
            .Columns.Add("CreateUserName", GetType(String))
            .Columns.Add("ModifyUserID", GetType(String))
            .Columns.Add("ModifyDate", GetType(Date))
            .Columns.Add("ModifyUserName", GetType(String))
            .Columns.Add("CheckUserID", GetType(String))
            .Columns.Add("CheckBit", GetType(Boolean))
            .Columns.Add("CheckUserName", GetType(String))
            .Columns.Add("CheckRemark", GetType(String))
            .Columns.Add("MrpSQID", GetType(String))
            .Columns.Add("S_SupplierName", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Source", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("PaymentType", GetType(String))
            .Columns.Add("Tel", GetType(String))
            .Columns.Add("Contacts", GetType(String))
            .Columns.Add("CurrencyName", GetType(String))
            .Columns.Add("Fax", GetType(String))
            .Columns.Add("Email", GetType(String))
            .Columns.Add("AutoID", GetType(Decimal))

        End With
        Grid1.DataSource = ds.Tables("MrpMaterialCodeQuotation")
        '創建臨時刪除表
        With ds.Tables.Add("DelTable")
            .Columns.Add("AutoID", GetType(Decimal))
        End With
    End Sub
#End Region

#Region "返回數據"
    Private Sub LoadTable()
      
        '1.主表
        Dim mmcList As New List(Of MrpMaterialCodeInfo)
        mmcList = mmcCon.MrpMaterialCode_GetList(StrMcode, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If mmcList.Count <= 0 Then
            Exit Sub
        End If
        GLU_MCode.EditValue = mmcList(0).M_Code
        txt_M_Name.Text = mmcList(0).M_Name
        txt_M_Unit.Text = mmcList(0).M_Unit
        txt_MC_Source.Text = mmcList(0).MC_Source
        txt_M_Gauge.Text = mmcList(0).M_Gauge
        txt_MC_SecInv.Text = mmcList(0).MC_SecInv
        txt_MC_LowLimit.Text = mmcList(0).MC_LowLimit
        check_MC_MRPCon.Checked = mmcList(0).MC_MRPCon
        chk_CheckBit.Checked = mmcList(0).CheckBit
        IsCheck = mmcList(0).CheckBit
        txt_CheckRemark.Text = mmcList(0).CheckRemark
        glu_MC_WH_ID.EditValue = mmcList(0).MC_WH_ID
        txt_CreateUserID.Text = mmcList(0).CreateUserID
        met_MC_Remark.Text = mmcList(0).MC_Remark

        '2.子表
        Dim msList As New List(Of MrpSupplierQuotationInfo)
        ds.Tables("MrpMaterialCodeQuotation").Clear()
        If StrMcode <> String.Empty Then
            msList = mrpSQcon.MRPSupplierQuotation_GetList(StrMcode, Nothing, Nothing)
            If msList.Count = 0 Then
                Exit Sub
            End If
        End If
        Dim i As Integer
        For i = 0 To msList.Count - 1
            Dim row As DataRow
            row = ds.Tables("MrpMaterialCodeQuotation").NewRow
            row("AutoID") = msList(i).AutoID
            row("CheckBit") = msList(i).CheckBit
            row("CheckRemark") = msList(i).CheckRemark
            row("CheckUserID") = msList(i).CheckUserID
            row("CheckUserName") = msList(i).CheckUserName
            row("CreateDate") = msList(i).CreateDate
            row("CreateUserID") = msList(i).CreateUserID
            row("CreateUserName") = msList(i).CreateUserName
            row("DeliveryDate") = msList(i).DeliveryDate
            row("EconomicQty") = msList(i).EconomicQty
            row("M_Gauge") = msList(i).M_Gauge
            row("M_Name") = msList(i).M_Name
            row("M_Source") = msList(i).M_Source
            row("M_Unit") = msList(i).M_Unit
            row("MaxQty") = msList(i).MaxQty
            row("MCode") = msList(i).MCode
            row("MinQty") = msList(i).MinQty
            row("ModifyDate") = msList(i).ModifyDate
            row("ModifyUserID") = msList(i).ModifyUserID
            row("ModifyUserName") = msList(i).ModifyUserName
            row("MrpSQID") = msList(i).MrpSQID
            row("OrderQty") = msList(i).OrderQty
            row("Remark") = msList(i).Remark
            row("ResponsibleUserID") = msList(i).ResponsibleUserID
            row("S_Supplier") = msList(i).S_Supplier
            row("S_SupplierName") = msList(i).S_SupplierName
            row("UnitPrice") = msList(i).UnitPrice
            row("PaymentType") = msList(i).PaymentType
            row("Tel") = msList(i).Tel
            row("Contacts") = msList(i).Contacts
            row("CurrencyName") = msList(i).CurrencyName
            row("Fax") = msList(i).Fax
            row("Email") = msList(i).Email

            ds.Tables("MrpMaterialCodeQuotation").Rows.Add(row)
        Next

    End Sub
#End Region

#Region "表格事件"
    Private Sub GridView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView1.Click
        Dim Str As String = String.Empty
        Str = GridView1.GetFocusedRowCellValue("S_Supplier")
        For i As Integer = 0 To ds.Tables("MrpMaterialCodeQuotation").Rows.Count - 1
            If IsDBNull(ds.Tables("MrpMaterialCodeQuotation").Rows(i)("S_Supplier")) Then
                Continue For
            End If
            If ds.Tables("MrpMaterialCodeQuotation").Rows(i)("S_Supplier") = Str Then
                MsgBox("此供應商報價已經添加！")
                Exit Sub
            End If
        Next
        GridView.SetFocusedRowCellValue(GridView.Columns("S_Supplier"), GridView1.GetFocusedRowCellValue("S_Supplier"))
        GridView.SetFocusedRowCellValue(GridView.Columns("S_SupplierName"), GridView1.GetFocusedRowCellValue("S_SupplierName"))
        GridView.SetFocusedRowCellValue(GridView.Columns("Contacts"), GridView1.GetFocusedRowCellValue("S_Associate"))
        GridView.SetFocusedRowCellValue(GridView.Columns("Tel"), GridView1.GetFocusedRowCellValue("S_Tel"))
        GridView.SetFocusedRowCellValue(GridView.Columns("Fax"), GridView1.GetFocusedRowCellValue("S_Fax"))
        GridView.SetFocusedRowCellValue(GridView.Columns("Email"), GridView1.GetFocusedRowCellValue("S_Email"))
        GridView.SetFocusedRowCellValue(GridView.Columns("PaymentType"), GridView1.GetFocusedRowCellValue("S_ToFrom"))
        GridView.SetFocusedRowCellValue(GridView.Columns("CurrencyName"), GridView1.GetFocusedRowCellValue("CurrencyName"))
    End Sub
#Region "物料控件賦值事件"
    Private Sub GridView6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView6.Click
        Dim SrtM_Code As String = String.Empty
        SrtM_Code = GridView6.GetFocusedRowCellValue("M_Code")
        Dim listmmc As New List(Of MrpMaterialCodeInfo)
        listmmc = mmcCon.MrpMaterialCode_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If listmmc.Count < 1 Then
            Exit Sub
        End If
        For i As Integer = 0 To listmmc.Count - 1
            If SrtM_Code = listmmc(i).M_Code Then
                MsgBox("此物料信息已經添加！")
                Exit Sub
            End If
        Next

        txt_M_Name.Text = GridView6.GetFocusedRowCellValue("M_Name")
        txt_M_Unit.Text = GridView6.GetFocusedRowCellValue("M_Unit")
        txt_M_Gauge.Text = GridView6.GetFocusedRowCellValue("M_Gauge")
        Select Case Mid(SrtM_Code, 1, 1)
            Case "M"
                txt_MC_Source.Text = "C"
            Case "3"
                txt_MC_Source.Text = "T"
            Case Else
                txt_MC_Source.Text = "P"
        End Select
    End Sub
#End Region

    Private Sub GridView_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView.FocusedRowChanged
        For j As Integer = 0 To GridView.Columns.Count - 1
            If IsDBNull(GridView.GetFocusedRowCellValue("CheckBit")) Then
                GridView.Columns(j).OptionsColumn.AllowEdit = True
                Continue For
            End If
            If GridView.GetFocusedRowCellValue("CheckBit") = True Then
                GridView.Columns(j).OptionsColumn.AllowEdit = False
            Else
                GridView.Columns(j).OptionsColumn.AllowEdit = True
            End If
        Next
    End Sub

    Private Sub RepositoryItemCalcEdit1_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles RepositoryItemCalcEdit1.EditValueChanging
        Dim a As String = e.NewValue.ToString
        If (CDec(e.NewValue) > 999999999 Or CDec(e.NewValue) < 0) Then
            e.Cancel = True
        End If
    End Sub

#End Region

#Region "新增修改事件"
    Private Sub SaveData()
        Dim boolresult As Boolean = False
        If Type = False Then
            Dim mmcInfo As New MrpMaterialCodeInfo
            mmcInfo.M_Code = GLU_MCode.EditValue
            mmcInfo.MC_WH_ID = glu_MC_WH_ID.EditValue
            mmcInfo.MC_SecInv = txt_MC_SecInv.Text
            mmcInfo.MC_LowLimit = txt_MC_LowLimit.Text
            mmcInfo.MC_MRPCon = check_MC_MRPCon.Checked
            mmcInfo.CreateUserID = txt_CreateUserID.Text
            mmcInfo.MC_Remark = met_MC_Remark.Text
            mmcInfo.MC_Source = txt_MC_Source.Text
            Select Case EditItem
                Case EditEnumType.ADD
                    boolresult = mmcCon.MrpMaterialCode_Insert(mmcInfo)
                Case EditEnumType.EDIT
                    boolresult = mmcCon.MrpMaterialCode_Update(mmcInfo)
            End Select

            If boolresult Then
                MsgBox("保存成功！")
                Me.Close()
            Else
                MsgBox("保存失敗！")
            End If
        Else
            boolresult = True
            Dim msqInfo As New MrpSupplierQuotationInfo
            For i As Integer = 0 To ds.Tables("DelTable").Rows.Count - 1
                With ds.Tables("DelTable")
                    msqInfo.AutoID = .Rows(i)("AutoID")
                    boolresult = mrpSQcon.MRPSupplierQuotation_Delete(Nothing, msqInfo.AutoID)
                End With
            Next
            If boolresult = False Then
                MsgBox("1.刪除子表出錯！")
                Exit Sub
            End If

            For i As Integer = 0 To ds.Tables("MrpMaterialCodeQuotation").Rows.Count - 1
                With ds.Tables("MrpMaterialCodeQuotation")
                    msqInfo.CreateUserID = InUserID
                    msqInfo.DeliveryDate = IIf(IsDBNull(.Rows(i)("DeliveryDate")), Nothing, .Rows(i)("DeliveryDate"))
                    msqInfo.MrpSQID = mrpSQcon.MRPSupplierQuotation_GetNewMrpSQID()
                    msqInfo.EconomicQty = IIf(IsDBNull(.Rows(i)("EconomicQty")), Nothing, .Rows(i)("EconomicQty"))
                    msqInfo.MaxQty = IIf(IsDBNull(.Rows(i)("MaxQty")), Nothing, .Rows(i)("MaxQty"))
                    msqInfo.MCode = IIf(IsDBNull(.Rows(i)("MCode")), Nothing, .Rows(i)("MCode"))
                    msqInfo.MinQty = IIf(IsDBNull(.Rows(i)("MinQty")), Nothing, .Rows(i)("MinQty"))
                    msqInfo.OrderQty = IIf(IsDBNull(.Rows(i)("OrderQty")), Nothing, .Rows(i)("OrderQty"))
                    msqInfo.Remark = IIf(IsDBNull(.Rows(i)("Remark")), Nothing, .Rows(i)("Remark"))
                    msqInfo.ResponsibleUserID = IIf(IsDBNull(.Rows(i)("ResponsibleUserID")), Nothing, .Rows(i)("ResponsibleUserID"))
                    msqInfo.S_Supplier = IIf(IsDBNull(.Rows(i)("S_Supplier")), Nothing, .Rows(i)("S_Supplier"))
                    msqInfo.UnitPrice = IIf(IsDBNull(.Rows(i)("UnitPrice")), Nothing, .Rows(i)("UnitPrice"))
                    msqInfo.AutoID = IIf(IsDBNull(.Rows(i)("AutoID")), 0, .Rows(i)("AutoID"))
                    If .Rows(i)("AutoID") = 0 Then
                        boolresult = mrpSQcon.MRPSupplierQuotation_Add(msqInfo) And boolresult
                    Else
                        If .Rows(i)("CheckBit") = False Then
                            boolresult = mrpSQcon.MRPSupplierQuotation_Update(msqInfo) And boolresult
                        End If
                    End If
                End With
            Next
            If boolresult = False Then
                MsgBox("2.保存出錯！")
            Else
                MsgBox("保存成功！")
                Me.Close()
            End If
        End If

    End Sub
  
#End Region

#Region "審核事件"
    Private Sub SaveCheck()
        Dim boolresult As Boolean = False
        If Type = False Then
            If IsCheck = chk_CheckBit.Checked Then
                MsgBox("審核狀態沒有改變！")
                Exit Sub
            End If
            Dim mmcInfo As New MrpMaterialCodeInfo
            mmcInfo.M_Code = GLU_MCode.EditValue
            mmcInfo.CheckBit = chk_CheckBit.Checked
            mmcInfo.CheckRemark = txt_CheckRemark.Text
            mmcInfo.CheckUserID = InUserID
            boolresult = mmcCon.MrpMaterialCode_UpdateCheck(mmcInfo)
            If boolresult = True Then
                MsgBox("保存成功！")
                Me.Close()
            Else
                MsgBox("審核出錯！")
            End If
        Else
            boolresult = True
            Dim msqInfo As New MrpSupplierQuotationInfo
            For i As Integer = 0 To ds.Tables("MrpMaterialCodeQuotation").Rows.Count - 1
                With ds.Tables("MrpMaterialCodeQuotation")
                    msqInfo.CheckBit = .Rows(i)("CheckBit")
                    'msqInfo.CheckRemark = txt_CheckRemark.Text
                    msqInfo.CheckUserID = InUserID
                    msqInfo.AutoID = .Rows(i)("AutoID")
                    msqInfo.MrpSQID = .Rows(i)("MrpSQID")
                    boolresult = mrpSQcon.MRPSupplierQuotation_Check(msqInfo) And boolresult
                End With
            Next

            If boolresult = True Then
                MsgBox("保存成功！")
                Me.Close()
            Else
                MsgBox("審核出錯！")
            End If
        End If
    End Sub

#End Region

#Region "是否為空"
    Private Function CheckEmtry() As Boolean
        For i As Integer = 0 To GridView.RowCount - 1
            If IsDBNull(GridView.GetRowCellValue(i, "S_Supplier")) Then
                MsgBox(" 第 " & i + 1 & " 行的供應商編號不能為空！")
                GridView.FocusedRowHandle = i
                Return False
                Exit Function
            End If
            If GridView.GetRowCellValue(i, "S_Supplier") = String.Empty Then
                MsgBox(" 第 " & i + 1 & " 行的供應商編號不能為空！")
                GridView.FocusedRowHandle = i
                Return False
                Exit Function
            End If
            If IsDBNull(GridView.GetRowCellValue(i, "UnitPrice")) Then
                MsgBox(" 第 " & i + 1 & " 行的單價不能為空！")
                GridView.FocusedRowHandle = i
                Return False
                Exit Function
            End If
            If GridView.GetRowCellValue(i, "UnitPrice") = String.Empty Then
                MsgBox(" 第 " & i + 1 & " 行的單價不能為空！")
                GridView.FocusedRowHandle = i
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function
#End Region

    Private Sub tsm_Check_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsm_Check.Click
        Dim boolIsCheck As Boolean = False
        If IsDBNull(GridView.GetFocusedRowCellValue("CheckBit")) Then
            GridView.SetFocusedRowCellValue(GridView.Columns("CheckBit"), True)
            Exit Sub
        End If
        boolIsCheck = GridView.GetFocusedRowCellValue("CheckBit")
        boolIsCheck = Not boolIsCheck
        GridView.SetFocusedRowCellValue(GridView.Columns("CheckBit"), boolIsCheck)
    End Sub
End Class
Imports LFERP.Library.MrpManager.MrpSupplierQuotation
Imports LFERP.Library.MrpManager.MrpMaterialCode
Imports LFERP.DataSetting

Public Class frmMRPSupplierQuotation
    Private _EditItem As String
    Private _Type As String
    Private _StrMcode As String
    Public Property Type() As String
        Get
            Return _Type
        End Get
        Set(ByVal value As String)
            _Type = value
        End Set
    End Property
    Public Property EditItem()
        Get
            Return _EditItem
        End Get
        Set(ByVal value)
            _EditItem = value
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
    Dim mrpSQinfo As New MrpSupplierQuotationInfo
    Dim mrpSQcon As New MrpSupplierQuotationController
    Private Sub frmMRPSupplierQuotation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load      
        Dim sccon As New SuppliersControler
        Dim mmccon As New MrpMaterialCodeController

        txt_S_Supplier.Properties.DisplayMember = "S_Supplier"    'txt
        txt_S_Supplier.Properties.ValueMember = "S_Supplier"   'EditValue
        txt_S_Supplier.Properties.DataSource = sccon.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        GLU_MCode.Properties.DisplayMember = "M_Code"    'txt
        GLU_MCode.Properties.ValueMember = "M_Code"   'EditValue
        'GLU_MCode.Properties.DataSource = mmccon.MrpMaterialCode_GetListBySource("原物料")

        Select Case EditItem
            Case EditEnumType.ADD
                txtMrpSQID.Text = mrpSQcon.MRPSupplierQuotation_GetNewMrpSQID()
            Case EditEnumType.EDIT
                GetMrpSQinfo()
                
                'If Type = "SQSelect" Then
                '    txt_S_Supplier.Enabled = True
                '    GLU_MCode.Enabled = False
                '    txt_OrderQty.Enabled = False
                '    txt_DeliveryDate.Enabled = False
                '    txt_MaxQty.Enabled = False
                '    txt_MinQty.Enabled = False
                '    txt_ResponsibleUserName.Enabled = False
                '    txt_EconomicQty.Enabled = False
                'End If
            Case EditEnumType.CHECK
                GetMrpSQinfo()
                xtpCheck.Show()

            Case EditEnumType.VIEW
                GetMrpSQinfo()


        End Select
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case EditItem
            Case EditEnumType.ADD
                SaveAdd()
            Case EditEnumType.EDIT
                SaveEdit()
            Case EditEnumType.CHECK
                Check()
        End Select
        MsgBox("操作成功！")
        Me.Close()
    End Sub
    Private Sub SaveAdd()
        mrpSQinfo.CreateUserID = InUserID
        mrpSQinfo.DeliveryDate = CInt(txt_DeliveryDate.Text)
        If txt_EconomicQty.Text = String.Empty Then
            mrpSQinfo.EconomicQty = 0
        Else
            mrpSQinfo.EconomicQty = CDec(txt_EconomicQty.Text)
        End If
        If txt_MaxQty.Text = String.Empty Then
            mrpSQinfo.MaxQty = 0
        Else
            mrpSQinfo.MaxQty = txt_MaxQty.Text
        End If
        If txt_MinQty.Text = String.Empty Then
            mrpSQinfo.MinQty = 0
        Else
            mrpSQinfo.MinQty = txt_MinQty.Text
        End If
        If txt_OrderQty.Text = String.Empty Then
            mrpSQinfo.OrderQty = 0
        Else
            mrpSQinfo.OrderQty = txt_OrderQty.Text
        End If
        mrpSQinfo.MCode = GLU_MCode.EditValue

        mrpSQinfo.MrpSQID = txtMrpSQID.Text

        mrpSQinfo.ResponsibleUserID = txt_ResponsibleUserName.Text
        'mrpSQinfo.Remark = ""
        mrpSQinfo.S_Supplier = txt_S_Supplier.EditValue
        mrpSQinfo.UnitPrice = txt_UnitPrice.Text
        If CheckDateEmpty() = False Then
            Exit Sub
        End If
        mrpSQcon.MRPSupplierQuotation_Add(mrpSQinfo)


    End Sub
    Private Sub SaveEdit()
        mrpSQinfo.ModifyUserID = InUserID
        mrpSQinfo.DeliveryDate = txt_OrderQty.Text
        mrpSQinfo.EconomicQty = txt_EconomicQty.Text
        mrpSQinfo.MaxQty = txt_MaxQty.Text
        mrpSQinfo.MCode = GLU_MCode.EditValue
        mrpSQinfo.MinQty = txt_MinQty.Text
        mrpSQinfo.MrpSQID = txtMrpSQID.Text
        mrpSQinfo.OrderQty = txt_OrderQty.Text
        mrpSQinfo.ResponsibleUserID = txt_ResponsibleUserName.Text
        'mrpSQinfo.Remark = ""
        mrpSQinfo.S_Supplier = txt_S_Supplier.EditValue
        mrpSQinfo.UnitPrice = txt_UnitPrice.Text
        If CheckDateEmpty() = False Then
            Exit Sub
        End If
        mrpSQcon.MRPSupplierQuotation_Update(mrpSQinfo)



    End Sub
    Private Sub Check()
        mrpSQinfo.CheckUserID = InUserID
        mrpSQinfo.CheckBit = chkCheckBit.Checked
        mrpSQinfo.MrpSQID = txtMrpSQID.Text
        mrpSQinfo.CheckRemark = txtCheckRemark.Text
        mrpSQcon.MRPSupplierQuotation_Check(mrpSQinfo)
     
    End Sub
    Private Function CheckDateEmpty() As Boolean
        Return True
    End Function

   
    Private Sub GetMrpSQinfo()
        mrpSQinfo = mrpSQcon.MRPSupplierQuotation_GetList(Nothing, StrMrpSQID, Nothing)(0)
        txt_OrderQty.Text = mrpSQinfo.DeliveryDate
        txt_EconomicQty.Text = mrpSQinfo.EconomicQty
        txt_MaxQty.Text = mrpSQinfo.MaxQty
        GLU_MCode.EditValue = mrpSQinfo.MCode
        GLU_MCode.Properties.DisplayMember = mrpSQinfo.MCode
        txt_M_Name.Text = mrpSQinfo.M_Name
        txt_M_Unit.Text = mrpSQinfo.M_Unit
        txt_M_Source.Text = mrpSQinfo.M_Source
        txt_M_Gauge.Text = mrpSQinfo.M_Gauge
        txt_MinQty.Text = mrpSQinfo.MinQty
        txtMrpSQID.Text = mrpSQinfo.MrpSQID
        txt_OrderQty.Text = mrpSQinfo.OrderQty
        txt_ResponsibleUserName.Text = mrpSQinfo.ResponsibleUserID
        'mrpSQinfo.Remark = ""
        txt_S_Supplier.EditValue = mrpSQinfo.S_Supplier
        txt_UnitPrice.Text = mrpSQinfo.UnitPrice
    End Sub
  
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub GridView4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView4.Click
        txt_M_Name.Text = GridView4.GetFocusedRowCellValue("M_Name").ToString
        txt_M_Unit.Text = GridView4.GetFocusedRowCellValue("M_Unit").ToString
        txt_M_Source.Text = GridView4.GetFocusedRowCellValue("Source").ToString
        txt_M_Gauge.Text = GridView4.GetFocusedRowCellValue("M_Gauge").ToString
    End Sub
    Private Sub GridView2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView2.Click
        txt_S_SupplierName.Text = GridView2.GetFocusedRowCellValue("S_SupplierName").ToString
    End Sub


    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub
End Class
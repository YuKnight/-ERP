Imports LFERP.DataSetting
Imports LFERP.Library.Orders
Imports LFERP.Library.Product
Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library

Public Class frmWLList

    Dim ds As New DataSet

    Private Sub frmWLList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = tempValue2
        CreateTable()
        LoadDataOrdersBom()
        Dim pc As New SuppliersControler
        Me.RepositoryItemLookUpEdit1.DisplayMember = "S_SupplierName"
        Me.RepositoryItemLookUpEdit1.ValueMember = "S_Supplier"
        Me.RepositoryItemLookUpEdit1.DataSource = pc.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, "True")
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        UpdateProductCheck()
        Me.Close()
    End Sub
    Sub UpdateProductCheck()
        Dim i As Integer
        i = 0
        Dim obi As New OrdersBomInfo
        Dim obc As New OrdersBomController

        For i = 0 To ds.Tables("Prod_Mounting_New").Rows.Count - 1
            obi.OS_BatchID = Label2.Text
            obi.M_Code = ds.Tables("Prod_Mounting_New").Rows(i)("M_Code")

            If IsDBNull(ds.Tables("Prod_Mounting_New").Rows(i)("OB_Product")) Then
                obi.OB_Product = Nothing
            Else
                obi.OB_Product = ds.Tables("Prod_Mounting_New").Rows(i)("OB_Product")
            End If
            If IsDBNull(ds.Tables("Prod_Mounting_New").Rows(i)("M_SupplierNo")) Then
                obi.OB_SupplierNo = Nothing
            Else
                obi.OB_SupplierNo = ds.Tables("Prod_Mounting_New").Rows(i)("M_SupplierNo")
            End If
            obi.OS_ProductAction = InUserID

            If IsDBNull(ds.Tables("Prod_Mounting_New").Rows(i)("M_Supplier")) Then
                obi.OB_Supplier = Nothing
            Else
                obi.OB_Supplier = ds.Tables("Prod_Mounting_New").Rows(i)("M_Supplier")
            End If


            If IsDBNull(ds.Tables("Prod_Mounting_New").Rows(i)("OB_ProductRemark")) Then
                obi.OB_ProductRemark = Nothing
            Else
                obi.OB_ProductRemark = ds.Tables("Prod_Mounting_New").Rows(i)("OB_ProductRemark")
            End If
            obc.OrdersBom_UpdateProduct(obi)
        Next
        MsgBox("狀態審核成功！", , "提示")
    End Sub
    Sub CreateTable()
        With ds.Tables.Add("Prod_Mounting_New")

            .Columns.Add("AutoID", GetType(String))

            .Columns.Add("PM_M_Code", GetType(String)) '聯豐編號
            .Columns.Add("PM_ID", GetType(Integer))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_CodePID", GetType(String))
            .Columns.Add("PM_Qty", GetType(Integer))
            .Columns.Add("PM_MakeRemark", GetType(String))
            .Columns.Add("PM_Make", GetType(Boolean))
            .Columns.Add("PM_Check", GetType(Boolean))
            .Columns.Add("M_Supplier", GetType(String))
            .Columns.Add("M_SupplierNo", GetType(String))
            .Columns.Add("IsNew", GetType(Boolean))    '是否新增

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("PM_LVL", GetType(Integer))
            .Columns.Add("PM_Key", GetType(String))
            .Columns.Add("PM_PID", GetType(String))
            .Columns.Add("M_CodeType", GetType(String))
            .Columns.Add("M_CodeMouldNO", GetType(String))
            .Columns.Add("OB_MakeDepartment", GetType(String))
            .Columns.Add("OB_MModeCusterNO", GetType(String))
            .Columns.Add("OB_Product", GetType(String))
            .Columns.Add("OB_ProductRemark", GetType(String))
        End With
        TreeList1.DataSource = ds.Tables("Prod_Mounting_New")
    End Sub
    Sub LoadDataOrdersBom()
        '載入物料清單

        Dim obc As New OrdersBomController
        Dim tlist As List(Of OrdersBomInfo)
        ds.Tables("Prod_Mounting_New").Rows.Clear()

        tlist = obc.OrdersBom_GetList(Nothing, Label2.Text, True, Nothing)
        If tlist Is Nothing Then Exit Sub

        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To tlist.Count - 1
            row = ds.Tables("Prod_Mounting_New").NewRow

            row("AutoID") = tlist(i).AutoID
            row("PM_ID") = 0
            row("M_Code") = tlist(i).M_Code
            row("PM_Qty") = tlist(i).OB_Qty
            row("PM_MakeRemark") = tlist(i).OB_MakeRemark
            row("PM_Make") = tlist(i).OB_Make

            row("M_Supplier") = tlist(i).OB_Supplier
            row("M_SupplierNo") = tlist(i).OB_SupplierNo
            row("IsNew") = False
            row("M_Name") = tlist(i).M_Name
            row("M_Gauge") = tlist(i).M_Gauge

            row("PM_Check") = tlist(i).OB_AccountCheck '通過批次審核后單個批次物料審核信息

            '    row("M_Unit") = tList(i).M_Unit
            '  row("PM_LVL") = tList(i).PM_LVL
            row("PM_Key") = tlist(i).OB_Key
            row("PM_PID") = tlist(i).OB_PID
            row("PM_LVL") = tlist(i).PM_LVL
            row("M_CodeType") = tlist(i).M_CodeType
            row("M_CodeMouldNO") = tlist(i).M_CodeMouldNO
            row("OB_MakeDepartment") = tlist(i).OB_MakeDepartment
            row("OB_MModeCusterNO") = tlist(i).OB_MModeCusterNO
            row("OB_Product") = tlist(i).OB_Product
            row("OB_ProductRemark") = tlist(i).OB_ProductRemark

            ds.Tables("Prod_Mounting_New").Rows.Add(row)
        Next
        TreeList1.ExpandAll()

        If ds.Tables("Prod_Mounting_New").Rows.Count = 0 Then
            MsgBox("未載入產品配件資料或產品資料配件未建立！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
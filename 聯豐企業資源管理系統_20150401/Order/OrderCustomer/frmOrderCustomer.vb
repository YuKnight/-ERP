Imports LFERP.Library.Product
Imports LFERP.Library.Orders

Public Class frmOrderCustomer
    Public strAutoID As String
    Dim ds As New DataSet
    Dim occ As New OrderCustomerController

    Private Sub frmOrderCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mc As New ProductController

        CreateTables()

        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        LoadOC_CustomerID()

        If lblTittle.Text = "客戶訂單資料-新增" Then

        ElseIf lblTittle.Text = "客戶訂單資料-修改" Then
            LoadData()
            Me.Text = "客戶訂單資料-修改"
        ElseIf lblTittle.Text = "客戶訂單資料-查看" Then
            btnSave.Enabled = False
            GroupBox1.Enabled = False
            LoadData()
            Me.Text = "客戶訂單資料-查看"
        End If
    End Sub

    Sub CreateTables()

        ds.Tables.Clear()

        With ds.Tables.Add("ProductM_Code")
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
        End With
        gluM_Code.Properties.DisplayMember = "M_Name"
        gluM_Code.Properties.ValueMember = "M_Code"
        gluM_Code.Properties.DataSource = ds.Tables("ProductM_Code")

    End Sub

    Sub LoadData()
        Dim oci As List(Of OrderCustomerInfo)

        oci = occ.OrderCustomer_GetList(strAutoID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If oci.Count > 0 Then
            txtOC_ID.Text = oci(0).OC_ID
            gluPM_M_Code.EditValue = oci(0).PM_M_Code
            gluM_Code.EditValue = oci(0).M_Code
            cboOC_CustomerID.Text = oci(0).OC_CustomerID
            txtOC_CustomerPO.Text = oci(0).OC_CustomerPO

            txtOC_CustomerNo.Text = oci(0).OC_CustomerNo
            txtOC_Qty.Text = oci(0).OC_Qty
            txtOC_Spare.Text = oci(0).OC_Spare
            dteOC_PODate.Text = oci(0).OC_PODate
            txtOC_Index.Text = oci(0).OC_Index

            txtOC_Remark.Text = oci(0).OC_Remark
        End If
    End Sub

    Sub LoadOC_CustomerID()
        Dim oci As List(Of OrderCustomerInfo)
        Dim i As Integer

        oci = occ.OrderCustomer_GetCustomerID

        If oci.Count > 0 Then
            For i = 0 To oci.Count - 1
                cboOC_CustomerID.Properties.Items.Add(oci(i).OC_CustomerID)
            Next
        End If
    End Sub

    Private Sub gluPM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluPM_M_Code.EditValueChanged
        Dim pbc As New ProductBomController
        Dim pbi As List(Of ProductBomInfo)
        Dim row3 As DataRow
        Dim i%

        gluM_Code.Text = ""
        If IsDBNull(gluPM_M_Code.EditValue) = False And gluPM_M_Code.EditValue <> "" Then
            ds.Tables("ProductM_Code").Clear()

            row3 = ds.Tables("ProductM_Code").NewRow
            row3("M_Code") = gluPM_M_Code.EditValue
            row3("M_Name") = gluPM_M_Code.EditValue

            ds.Tables("ProductM_Code").Rows.Add(row3)

            pbi = pbc.Prod_Mounting_New_GetList(gluPM_M_Code.EditValue, Nothing, Nothing, 0, Nothing, Nothing, Nothing)

            If pbi.Count > 0 Then
                For i = 0 To pbi.Count - 1
                    Dim row1 As DataRow
                    row1 = ds.Tables("ProductM_Code").NewRow
                    row1("M_Code") = pbi(i).M_Code
                    row1("M_Name") = pbi(i).M_Name

                    ds.Tables("ProductM_Code").Rows.Add(row1)
                Next
            End If
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim oci As New OrderCustomerInfo
        Dim ociGet As List(Of OrderCustomerInfo)

        If txtOC_ID.Text.Trim = "" Then
            MsgBox("請輸入訂單編號!", 64, "提示")
            txtOC_ID.Focus()
            Exit Sub
        End If
        If gluPM_M_Code.Text.Trim = "" Then
            MsgBox("請輸入產品編號!", 64, "提示")
            gluPM_M_Code.Focus()
            Exit Sub
        End If
        If gluM_Code.Text.Trim = "" Then
            MsgBox("請輸入配件名稱!", 64, "提示")
            gluM_Code.Focus()
            Exit Sub
        End If
        If cboOC_CustomerID.Text.Trim = "" Then
            MsgBox("請輸入客戶代號!", 64, "提示")
            cboOC_CustomerID.Focus()
            Exit Sub
        End If
        If txtOC_CustomerPO.Text.Trim = "" Then
            MsgBox("請輸入客戶PO!", 64, "提示")
            txtOC_CustomerPO.Focus()
            Exit Sub
        End If
        If txtOC_CustomerNo.Text.Trim = "" Then
            MsgBox("請輸入客戶編號!", 64, "提示")
            txtOC_CustomerNo.Focus()
            Exit Sub
        End If
        If txtOC_Qty.Text.Trim = "" Then
            MsgBox("請輸入訂單數量!", 64, "提示")
            txtOC_Qty.Focus()
            Exit Sub
        End If
        If txtOC_Spare.Text.Trim = "" Then
            MsgBox("請輸入士啤!", 64, "提示")
            txtOC_Spare.Focus()
            Exit Sub
        End If
        If dteOC_PODate.Text = "" Then
            MsgBox("請輸入PO日期!", 64, "提示")
            dteOC_PODate.Focus()
            Exit Sub
        End If
        If txtOC_Index.Text.Trim = "" Then
            MsgBox("請輸入流水號!", 64, "提示")
            txtOC_Index.Focus()
            Exit Sub
        End If

        If lblTittle.Text = "客戶訂單資料-新增" Then
            ociGet = occ.OrderCustomer_GetList(Nothing, txtOC_ID.Text.Trim, gluPM_M_Code.EditValue, gluM_Code.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If ociGet.Count > 0 Then
                If MsgBox("已存在一條訂單單號，產品編號和配件名稱都相同的記錄，是否要繼續添加該記錄？", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "提示") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If

        oci.OC_ID = txtOC_ID.Text.Trim
        oci.PM_M_Code = gluPM_M_Code.EditValue
        oci.M_Code = gluM_Code.EditValue
        oci.OC_CustomerID = cboOC_CustomerID.Text
        oci.OC_CustomerPO = txtOC_CustomerPO.Text.Trim

        oci.OC_CustomerNo = txtOC_CustomerNo.Text.Trim
        oci.OC_Qty = txtOC_Qty.Text.Trim
        oci.OC_NoSendQty = txtOC_Qty.Text
        oci.OC_Spare = txtOC_Spare.Text
        oci.OC_PODate = Format(dteOC_PODate.DateTime, "yyyy/MM/dd")

        oci.OC_Index = txtOC_Index.Text.Trim
        oci.OC_Remark = txtOC_Remark.Text.Trim

        If lblTittle.Text = "客戶訂單資料-新增" Then
            oci.OC_AddDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
            oci.OC_AddUser = UserName

            If occ.OrderCustomer_Add(oci) = True Then
                MsgBox("訂單新增完成!", 64, "提示")
                Me.Close()
            End If
        ElseIf lblTittle.Text = "客戶訂單資料-修改" Then
            oci.AutoID = strAutoID
            oci.OC_ModifyDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
            oci.OC_ModifyUser = UserName

            If occ.OrderCustomer_Update(oci) = True Then
                MsgBox("訂單修改完成!", 64, "提示")
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '單擊空格鍵，顯示下拉菜單
    Private Sub gluPM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPM_M_Code.KeyDown, gluM_Code.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class
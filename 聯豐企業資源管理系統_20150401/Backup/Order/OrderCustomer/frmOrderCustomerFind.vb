Imports LFERP.Library.Product
Imports LFERP.Library.Orders

Public Class frmOrderCustomerFind
    Dim ds As New DataSet
    Dim occ As New OrderCustomerController
    Public isClickbtnFind As Boolean     '記錄是否單擊了查詢按鈕

    Private Sub frmOrderCustomerFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mc As New ProductController

        CreateTables()
        LoadOC_CustomerID()

        isClickbtnFind = False

        gluPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        gluPM_M_Code.Properties.ValueMember = "PM_M_Code"
        gluPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
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

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        isClickbtnFind = True
        If txtOC_ID.Text.Trim = "" Then                                  '訂單編號
            tempValue = Nothing
        Else
            tempValue = txtOC_ID.Text.Trim
        End If
        If gluPM_M_Code.EditValue = "" Then                        '產品編號
            tempValue2 = Nothing
        Else
            tempValue2 = gluPM_M_Code.EditValue
        End If
        If gluM_Code.EditValue = "" Then                                   '物料編號(物料名稱)
            tempValue3 = Nothing
        Else
            tempValue3 = gluM_Code.EditValue
        End If
        If cboOC_CustomerID.Text.Trim = "" Then                      '客戶代號
            tempValue4 = Nothing
        Else
            tempValue4 = cboOC_CustomerID.Text.Trim
        End If
        If txtOC_CustomerPO.Text.Trim = "" Then                      '客戶PO
            tempValue5 = Nothing
        Else
            tempValue5 = txtOC_CustomerPO.Text.Trim
        End If
        If txtOC_CustomerNo.Text.Trim = "" Then                      '客戶編號
            tempValue6 = Nothing
        Else
            tempValue6 = txtOC_CustomerNo.Text.Trim
        End If
        If dteOC_PODateBegin.Text = "" Then                      'PO開始日期
            tempValue7 = Nothing
        Else
            tempValue7 = dteOC_PODateBegin.Text
        End If
        If dteOC_PODateEnd.Text = "" Then                      'PO結束日期
            tempValue8 = Nothing
        Else
            tempValue8 = dteOC_PODateEnd.Text
        End If

        Me.Close()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    '單擊空格鍵，顯示下拉菜單
    Private Sub gluPM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluPM_M_Code.KeyDown, gluM_Code.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class
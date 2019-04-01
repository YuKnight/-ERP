Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.SystemManager.SystemUser
Public Class FrmpurSelectCondition
    Dim Temp As String
    Dim mtc As New Material.MaterialTypeController
    Private Sub FrmpurSelectCondition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Temp = tempValue
        tempValue = ""

        Select Case Temp
            Case "物料類型"
                XtraTabControl1.TabPages(0).PageEnabled = True
            Case "供應商"
                XtraTabControl1.TabPages(1).PageEnabled = True
            Case "部門審核"
                XtraTabControl1.TabPages(2).PageEnabled = True
            Case "會計審核"
                XtraTabControl1.TabPages(3).PageEnabled = True
            Case "操作員"
                XtraTabControl1.TabPages(4).PageEnabled = True
            Case "未交數"
                XtraTabControl1.TabPages(5).PageEnabled = True
            Case "稅率"
                XtraTabControl1.TabPages(6).PageEnabled = True
            Case "幣別"
                XtraTabControl1.TabPages(7).PageEnabled = True
            Case "付款確認"
                XtraTabControl1.TabPages(8).PageEnabled = True
            Case "付款類型"
                XtraTabControl1.TabPages(9).PageEnabled = True

        End Select

        Dim mtd As New LFERP.DataSetting.SuppliersControler
        gluSupplier.Properties.DisplayMember = "S_SupplierName"
        gluSupplier.Properties.ValueMember = "S_Supplier"
        gluSupplier.Properties.DataSource = mtd.GetSuppliersList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        Dim us As New SystemUserController
        gluAction.Properties.DisplayMember = "U_Name"
        gluAction.Properties.ValueMember = "U_ID"
        gluAction.Properties.DataSource = us.SystemUser_GetList(Nothing, Nothing, "10010103")

        Dim ccs As New LFERP.DataSetting.CurrencyControler
        gluCurrency.Properties.DataSource = ccs.GetCurrencyList(Nothing)
        gluCurrency.Properties.DisplayMember = "C_Name"
        gluCurrency.Properties.ValueMember = "C_ID"

        mtc.LoadNodes(Tv1, ErpUser.MaterialType)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                tempValue2 = PopupContainerEdit1.Text
            Case 1
                tempValue2 = gluSupplier.EditValue
            Case 2
                tempValue2 = ComboBoxEdit1.Text
            Case 3
                tempValue2 = ComboBoxEdit2.Text
            Case 4
                tempValue2 = gluAction.EditValue
            Case 5
                tempValue2 = ComboBoxEdit3.Text
            Case 6
                tempValue2 = ComboBoxEdit4.Text
            Case 7
                tempValue2 = gluCurrency.EditValue
            Case 8
                tempValue2 = ComboBoxEdit5.Text
            Case 9
                tempValue2 = ComboBoxEdit6.Text
        End Select
        Me.Close()
    End Sub

    Private Sub Tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Tv1.AfterSelect
        PopupContainerEdit1.EditValue = Tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub
End Class
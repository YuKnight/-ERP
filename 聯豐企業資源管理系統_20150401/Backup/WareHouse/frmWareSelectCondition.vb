Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.SystemManager.SystemUser
Imports LFERP.DataSetting

Public Class frmWareSelectCondition
    Dim Temp As String
    Dim mtc As New Material.MaterialTypeController

    Sub LoadDepartment()
        Dim dc As New DepartmentControler

        GluDep.Properties.DisplayMember = "DPT_Name"
        GluDep.Properties.ValueMember = "DPT_ID"
        GluDep.Properties.DataSource = dc.Department_GetList1(Nothing, Nothing, Nothing)

    End Sub

    Private Sub FrmpurSelectCondition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Temp = tempValue
        tempValue = ""

        Select Case Temp
            Case "物料類別"
                XtraTabControl1.TabPages(0).PageEnabled = True
              
            Case "部門審核"
                XtraTabControl1.TabPages(1).PageEnabled = True
            Case "會計審核"
                XtraTabControl1.TabPages(2).PageEnabled = True
            Case "復核"
                XtraTabControl1.TabPages(2).PageEnabled = True
                'Case "操作員"
                '    XtraTabControl1.TabPages(3).PageEnabled = True
            Case "申領部門"
                XtraTabPage2.PageEnabled = True
            Case "部門"
                XtraTabPage2.PageEnabled = True

        End Select
        LoadDepartment()
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
                tempValue2 = ComboBoxEdit1.Text
            Case 2
                tempValue2 = ComboBoxEdit2.Text
            Case 3
                tempValue2 = gluAction.EditValue
            Case 4
                tempValue2 = GluDep.EditValue
        End Select
        Me.Close()
    End Sub

    Private Sub Tv1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles Tv1.AfterSelect
        PopupContainerEdit1.EditValue = Tv1.SelectedNode.Tag
        PopupContainerControl1.OwnerEdit.ClosePopup()
    End Sub
End Class
Imports LFERP.SystemManager.SystemUser
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionShipment

Public Class frmProductionShipmenttSelect



    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckEditA.Checked = True Then
            If TextEditA.Text.Trim = "" Then
                tempValue2 = Nothing
            Else
                tempValue2 = TextEditA.Text
            End If

        Else
            tempValue2 = Nothing
        End If

        If CheckEditE.Checked = True Then
            tempValue4 = Format(DateEditE.EditValue, "yyyy/MM/dd")
            tempValue3 = ComboBoxEditE.EditValue
        Else
            tempValue3 = Nothing
            tempValue4 = Nothing
        End If


        If CheckEditF.Checked = True Then
            tempValue5 = GridLookUpEditF.EditValue
        Else
            tempValue5 = Nothing
        End If
        If CheckEditG.Checked = True Then
            If ComboBoxEditG.EditValue = "已審核" Then
                tempValue6 = True
            Else
                tempValue6 = False
            End If

        Else
            tempValue6 = Nothing
        End If


        If CheckEditB.Checked = True Then   ''產品編號
            tempValue7 = PM_M_CodeB.EditValue
        Else
            tempValue7 = Nothing
        End If


        If CheckEditD.Checked = True Then   ''出貨類型
            tempValue8 = ComboBoxEditD.Text
        Else
            tempValue8 = Nothing
        End If

        If CheckEditc.Checked = True Then   ''產品名稱
            tempValue9 = GridLookUpEditc.EditValue
        Else
            tempValue9 = Nothing
        End If



        Me.Close()
    End Sub

    Private Sub ShipmentWareOutSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim us As New SystemUserController
        GridLookUpEditF.Properties.DisplayMember = "U_Name"
        GridLookUpEditF.Properties.ValueMember = "U_ID"
        GridLookUpEditF.Properties.DataSource = us.SystemUser_GetList(Nothing, Nothing, Nothing)

        Dim mc As New ProcessMainControl
        PM_M_CodeB.Properties.DisplayMember = "PM_M_Code"
        PM_M_CodeB.Properties.ValueMember = "PM_M_Code"
        PM_M_CodeB.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

        Dim ps As New ProductionShipmentControl
        GridLookUpEditc.Properties.DisplayMember = "PS_M_Name"
        GridLookUpEditc.Properties.ValueMember = "PS_M_Name"
        GridLookUpEditc.Properties.DataSource = ps.ProductionShipment_Get()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
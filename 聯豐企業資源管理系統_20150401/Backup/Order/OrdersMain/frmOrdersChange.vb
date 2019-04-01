Imports LFERP.DataSetting
Imports LFERP.Library.Orders
Imports DevExpress.XtraGrid.Columns
Imports LFERP.Library.Product
Imports LFERP.Library.OrdersChange
Imports LFERP.Library.Outwards

Public Class frmOrdersChange

    Dim strType As String


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If labOM_ID.Text = "" Then
            MsgBox("訂單流水號為空!")
            Exit Sub
        End If

        If strType = "M" Then ''修改產品編號
            If GridLookNewCode.EditValue = "" Then
                GridLookNewCode.Focus()
                MsgBox("新編碼不能為空！")
                Exit Sub
            End If

            If txtOldm_code.EditValue = "" Then
                txtOldm_code.Focus()
                MsgBox("舊編碼不能為空！")
                Exit Sub
            End If


            If GridLookNewCode.EditValue = txtOldm_code.Text Then
                GridLookNewCode.Focus()
                MsgBox("新編碼,與舊編碼不能相同！")
                Exit Sub
            End If

            If txtRemark.Text = "" Then
                txtRemark.Select()
                MsgBox("請輸入備注信息!")
                Exit Sub
            End If


            '-------------------------------------------------------

            Dim OW As New OutWardsController
            Dim OL As New List(Of OutWardsInfo)
            OL = OW.OutWards_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, labOM_ID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            If OL.Count <= 0 Then
            Else
                MsgBox("此訂單流水號,已有送貨記錄!")
                Exit Sub
            End If

            Dim osc As New OrdersSubController
            Dim osl As New List(Of OrdersSubInfo)

            osl = osc.OrdersSub_GetList(labOM_ID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            If osl.Count > 0 Then
                Dim k As Integer

                For k = 0 To osl.Count - 1
                    Dim obomc As New OrdersBomController
                    Dim obocl As New List(Of OrdersBomInfo)
                    obocl = obomc.OrdersBom_GetList(Nothing, osl(k).OS_BatchID, Nothing, Nothing)

                    If obocl.Count > 0 Then
                        MsgBox("此訂單流水號,相關批次已在物料清單中存在!")
                        Exit Sub
                    End If
                Next
            End If

            '---------------------------------------------------------------------
        End If


        If strType = "Q" Then ''修改未交數
            If txtNOSendold.Text = "" Then
                txtNOSendold.Focus()
                MsgBox("修改前數量不能為空！")
                Exit Sub
            End If

            If txtNOSendnew.EditValue = "" Or Val(txtNOSendnew.Text) < 0 Then
                txtNOSendnew.Focus()
                MsgBox("修改后的數量輸入有誤！")
                Exit Sub
            End If


            If Val(txtNOSendold.Text) <= Val(txtNOSendnew.Text) Then
                txtNOSendnew.Focus()
                MsgBox("修改后數量不能大於等於修改前數量！")
                Exit Sub
            End If

            If txtRrmarkQ.Text = "" Then
                txtRrmarkQ.Select()
                MsgBox("請輸入備注信息!")
                Exit Sub
            End If
        End If



        Dim oc As New OrdersChangeControl
        Dim oi As New OrdersChangeInfo

        oi.OM_ID = labOM_ID.Text


        If strType = "M" Then ''修改未交數
            oi.PM_M_CodeNew = GridLookNewCode.EditValue
            oi.PM_M_CodeOld = txtOldm_code.Text
            oi.Remark = txtRemark.Text
        End If

        If strType = "Q" Then ''修改未交數
            oi.PM_M_CodeNew = txtNOSendnew.Text
            oi.PM_M_CodeOld = txtNOSendold.Text
            oi.Remark = txtRrmarkQ.Text
        End If


        oi.OrderDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        oi.ChangeType = strType
        oi.U_ID = InUserID

        If oc.OrdersChange_Add1(oi) = True Then
            MsgBox("保存成功！")
        Else
            MsgBox("保存失敗！")
            Exit Sub
        End If

        Me.Close()


    End Sub

    Private Sub frmOrdersChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        labOM_ID.Text = ""


        strType = tempValue3
        If strType = "M" Then
            Dim mc As New ProductController
            GridLookNewCode.Properties.DisplayMember = "PM_M_Code"
            GridLookNewCode.Properties.ValueMember = "PM_M_Code"
            GridLookNewCode.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            labOM_ID.Text = tempValue
            txtOldm_code.EditValue = tempValue2

            Me.XtraTabPage1.PageVisible = True
            Me.XtraTabPage2.PageVisible = False

        ElseIf strType = "Q" Then
            labOM_ID.Text = tempValue
            txtNOSendold.EditValue = tempValue2
            Me.XtraTabPage2.PageVisible = True
            Me.XtraTabPage1.PageVisible = False
        End If

        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        '----------------------------------------------------


    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

 
End Class
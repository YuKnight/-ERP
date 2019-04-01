Imports LFERP.Library.Orders
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.Library.WareHouse.WareInput


Public Class frmLoadingBatchID

    Private Sub frmLoadingBatchID_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = tempValue4
        tempValue4 = ""
        txtBatchID.Text = ""
        gluCode.EditValue = ""
        txtQty.Text = ""
        txtBatchID.Focus()
        Label5.Visible = False
        Label6.Visible = False
        gluCode.Properties.DataSource = Nothing

    End Sub

    Private Sub txtBatchID_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBatchID.LostFocus
        CheckBatchID()

    End Sub
    Sub CheckBatchID()

        Dim oc As New OrdersBomController
        Dim oi As List(Of OrdersBomInfo)
        oi = oc.OrdersBom_GetList(Nothing, txtBatchID.Text, Nothing, Nothing)
        If oi.Count = 0 Then
            txtBatchID.Text = ""
            Exit Sub
        Else
            Me.gluCode.Properties.DataSource = oc.OrdersBom_GetList(Nothing, txtBatchID.Text, Nothing, "0")
            gluCode.Properties.DisplayMember = "M_Name"
            gluCode.Properties.ValueMember = "M_Code"
            Label5.Visible = True
            Dim omc As New OrdersSubController
            Dim omi As List(Of OrdersSubInfo)
            omi = omc.OrdersSub_GetList(Nothing, Nothing, oi(0).PM_M_Code, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Label5.Text = "殼號,客戶編號：" & oi(0).PM_M_Code & "," & omi(0).OM_CusterNo

        End If

    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then

            If IsNumeric(txtQty.Text) = False Then
                MsgBox("請輸入數字！")
                txtQty.Text = Nothing
                txtQty.Focus()
                Exit Sub
            End If

            If txtBatchID.Text = "" Or gluCode.EditValue = "" Or txtQty.Text = "" Then Exit Sub
            tempValue = txtBatchID.Text
            tempValue2 = gluCode.EditValue
            tempValue3 = txtQty.Text
            Me.Close()
        End If

    End Sub

    Private Sub cmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoad.Click
        If txtBatchID.Text = "" Or gluCode.EditValue = "" Or txtQty.Text = "" Then
            MsgBox("數據填寫不完整,請確認輸入正確！")
            Exit Sub
        Else
            tempValue = txtBatchID.Text
            tempValue2 = gluCode.EditValue
            tempValue3 = txtQty.Text
            Me.Close()
        End If

    End Sub
    Public Function IsNumeric(ByVal str As String) As Boolean
        '判斷是否為數字(包括小數) 
        Dim reg1 As New System.Text.RegularExpressions.Regex("\d|\.")
        Return reg1.IsMatch(str)
    End Function

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub gluCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluCode.EditValueChanged
        Dim wi As List(Of WareInventoryInfo)
        Dim wic As New WareInventoryMTController

        Dim wii As List(Of WareInputInfo)
        Dim wiic As New WareInputContraller
        Dim woi As List(Of WareOutInfo)
        Dim woc As New WareOutController

        ''選定批次物料入庫出庫數量總數
        wii = wiic.WareInput_GetQty(txtBatchID.Text, gluCode.EditValue, Label4.Text, True)
        woi = woc.WareOut_GetQty(txtBatchID.Text, gluCode.EditValue, Label4.Text, True)

        Dim InputQty, OutputQty As Single
        If wii.Count = 0 Then
            InputQty = 0
        Else
            InputQty = wii(0).GetQty
        End If
        If woi.Count = 0 Then
            OutputQty = 0
        Else
            OutputQty = woi(0).OutGetQty
        End If
        Label6.Visible = True
        Label6.Text = "入庫總數：" & InputQty & "," & "出庫總數：" & OutputQty & "," & "結餘：" & InputQty - OutputQty

        wi = wic.WareInventory_GetList(gluCode.EditValue, Label4.Text)

        If wi.Count = 0 Then
            txtBatchID.Focus()
            txtQty.Text = 0
            Exit Sub
        Else
            If InputQty - OutputQty > wi(0).WI_Qty Then
                MsgBox("當前批次此物料的結餘數大於倉庫庫存數，此時導入倉庫庫存數！", , "提醒")
                txtQty.Text = wi(0).WI_Qty
            Else
                txtQty.Text = InputQty - OutputQty  '當前批次此物料的結餘數
            End If
            cmdLoad.Focus()
        End If
    End Sub

End Class
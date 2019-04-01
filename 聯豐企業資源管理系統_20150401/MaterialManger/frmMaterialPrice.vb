Imports LFERP.Library.Material
Imports LFERP.DataSetting

Public Class frmMaterialPrice
    Dim mc As New MaterialController
    Dim mtsCurrency As New CurrencyControler

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmMaterialPrice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCode.Text = tempValue
        tempValue = Nothing
        lueCurrency.Properties.DataSource = mtsCurrency.GetCurrencyList(Nothing)
        LoadData()

        txtPrice.Select()
        txtPrice.Focus()
    End Sub

    Sub LoadData()
        Dim ml As New MaterialInfo
        ml = mc.MaterialCode_Get(Me.txtCode.Text)
        If ml.M_Code Is Nothing Then
            MsgBox("此編碼不存在")
            Exit Sub
        End If

        Me.txtGauge.Text = ml.M_Gauge
        Me.txtName.Text = ml.M_Name
        Me.txtPrice.Text = ml.M_Price
        Me.lueCurrency.EditValue = ml.M_Currency

    End Sub

    Sub UpdataPrice()
        If mc.MaterialCode_UpdatePrice1(Me.txtCode.Text, Val(Me.txtPrice.Text), Me.lueCurrency.EditValue) = True Then
            MsgBox("保存成功!")
            Me.Close()
        Else
            MsgBox("保存失敗,請檢查!")
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        UpdataPrice()
    End Sub
End Class
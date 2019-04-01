Imports LFERP.DataSetting
Imports LFERP.Library.NmetalSampleManager.NmetalSampleOrdersMain
Imports LFERP.Library.NmetalSampleManager.NmetalSampleCollection
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.NmetalSampleManager.NmetalSampleProcess
Imports LFERP.Library.NmetalSampleManager.NmetalSampleWareInventory
Imports LFERP.Library.NmetalSampleManager.NmetalSampInventoryCheck

Public Class frmNmetalSampleWareInventoryChange
    Dim socon As New NmetalSampleOrdersMainControler
    Dim scCon As New NmetalSampleCollectionControler
    Dim pncon As New PersonnelControl
    Dim SwCon As New NmetalSampleWareInventoryControler
    Dim prcon As New NmetalSampleProcessControl
    Dim sicom As New NmetalSampInventoryCheckControl

    Public strD_ID As String
    Public strPM_M_CodeA As String
    Public strPS_NO As String

    Private Sub frmSampleWareInventoryChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '載入訂單編號
        Dim mtd As New NmetalSampleOrdersMainControler
        gluSO_ID.Properties.DisplayMember = "PM_M_Code"
        gluSO_ID.Properties.ValueMember = "PM_M_Code"
        gluSO_ID.Properties.DataSource = mtd.NmetalSampleOrdersMain_GetListItem(Nothing, Nothing, Nothing, True)

        Dim pmlist As New List(Of PersonnelInfo) '部門分享
        pmlist = pncon.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)
        gluStateD_ID.Properties.DisplayMember = "DepName"
        gluStateD_ID.Properties.ValueMember = "DepID"
        gluStateD_ID.Properties.DataSource = pmlist

        gluStateD_ID.EditValue = strD_ID
        gluSO_ID.EditValue = strPM_M_CodeA
        gluStatePS_NO.EditValue = strPS_NO

        TextEdit2.Select()

    End Sub

    Private Sub SimpleOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleOK.Click
        If Val(TextEdit2.Text) < 0 Then
            MsgBox("調整后的數據不能小於0.")
            Exit Sub
        End If

        If Val(TextEdit1.Text) = Val(TextEdit2.Text) Then
            MsgBox("調整前數量不能等於調整后數量！")
            Exit Sub
        End If

        If gluStatePS_NO.Text = "" Then
            MsgBox("工序不能為空！")
            Exit Sub
        End If

        If gluStateD_ID.Text = "" Then
            MsgBox("調整部門不能為空！")
            Exit Sub
        End If

        Dim SLL As New List(Of NmetalSampleWareInventoryInfo)
        SLL = SwCon.NmetalSampleWareInventory_Getlist(Nothing, Nothing, gluStatePS_NO.EditValue, Nothing, Nothing, gluStateD_ID.EditValue)

        If SLL.Count <= 0 Then
            MsgBox("數據不存在,不能保存!")
            Exit Sub
        End If

        If Val(TextEdit1.Text) <> SLL(0).SWI_Qty Then
            MsgBox("調整前數量與當前庫存不相符！")
            Exit Sub
        End If

        '---------------------------------
        Dim wi As New NmetalSampleWareInventoryInfo

        wi.SWI_Qty = Val(TextEdit2.Text)
        wi.ModifyDate = Format(Now, "yyyy/MM/dd")
        wi.ModifyUserID = InUserID
        wi.D_ID = Me.gluStateD_ID.EditValue
        wi.PS_NO = Me.gluStatePS_NO.EditValue

        If SwCon.NmetalSampleWareInventory_Update(wi) = True Then
            MsgBox("修改成功！")
        End If

        '-------------------------------------------------------------------------------------------------
        '-------------------------------------------------------------------------------------------------

        Dim wcc As New NmetalSampleWareInventoryControler
        Dim wci As New NmetalSampleWareInventoryInfo

        wci.D_ID = Me.gluStateD_ID.EditValue
        wci.PS_NO = Me.gluStatePS_NO.EditValue
        wci.SWI_QtyQ = Val(TextEdit1.Text)
        wci.SWI_QtyH = Val(TextEdit2.Text)
        wci.AddUserID = InUserID
        wci.AddDate = Format(Now, "yyyy/MM/dd")

        If wcc.NmetalSampleWareInventoryChange_Add(wci) = True Then

        End If

        TextEdit1.Text = ""
        TextEdit2.Text = ""

    End Sub

    Private Sub gluStatePS_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluStatePS_NO.EditValueChanged
        If gluStatePS_NO.EditValue <> "" And gluStateD_ID.EditValue <> "" Then
        Else
            Exit Sub
        End If

        TextEdit1.Text = ""

        Dim SL As New List(Of NmetalSampleWareInventoryInfo)
        SL = SwCon.NmetalSampleWareInventory_Getlist(Nothing, Nothing, gluStatePS_NO.EditValue, Nothing, Nothing, gluStateD_ID.EditValue)

        If SL.Count <= 0 Then
            MsgBox("數據不存在!")
            Exit Sub
        End If

        '-----------------------
        TextEdit1.Text = SL(0).SWI_Qty
    End Sub

    Private Sub gluStateD_ID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluStateD_ID.EditValueChanged
        gluStatePS_NO_EditValueChanged(Nothing, Nothing)
    End Sub

    Private Sub gluSO_ID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluSO_ID.EditValueChanged
        If gluSO_ID.Text <> "" Then
        Else
            Exit Sub
        End If

        '----------------------------------------工藝
        Dim splist As New List(Of NmetalSampleProcessInfo)
        splist = prcon.NmetalSampleProcessMain_GetList(Nothing, gluSO_ID.EditValue, Nothing, Nothing, Nothing, Nothing, Nothing)

        gluStatePS_NO.Properties.ValueMember = "PS_NO"
        gluStatePS_NO.Properties.DisplayMember = "PS_Name"
        gluStatePS_NO.Properties.DataSource = splist
        '--------------------------------------
    End Sub
End Class
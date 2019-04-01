Imports LFERP.Library.Material
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.WareHouse.WareHouseSplit
Imports LFERP.Library.Purchase.Purchase

Public Class frmWareChaiFen

    Function GetID() As String  '生成新ID
        Dim swc As New WareHouseSplitControl
        Dim swi As List(Of WareHouseSplitInfo)
        Dim ndate As String
        ndate = "WS" + Format(Now(), "yyMM")
        swi = swc.WareHouseSplit_GetList(ndate, Nothing, Nothing, Nothing, Nothing, Nothing)
        If swi.Count <= 0 Then
            GetID = ndate + "0001"
        Else
            GetID = ndate + Mid((CInt(Mid(swi(0).S_ID, 7)) + 10001), 2)
        End If
    End Function

    Private Sub txtWH_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        frmWareHouseSelect.SelectWareID = ""
        tempValue3 = "500701"
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.Left + MDIMain.tvModule.Width + Me.Left + txtWH.Left + 16
        frmWareHouseSelect.Top = MDIMain.Top + Me.Top + 176
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            txtWH.Tag = frmWareHouseSelect.SelectWareID
            txtWH.Text = frmWareHouseSelect.SelectWareUpName & "-" & frmWareHouseSelect.SelectWareName
            txtWH.Enabled = False
        End If

    End Sub

    Private Sub ButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit1.ButtonClick
        tempCode = ""
        tempValue5 = txtWH.Tag

        frmBOMSelect.ShowDialog()
        '取得需拆分物料編碼
        If tempCode = "" Then
        Else
            ButtonEdit1.Text = tempCode
            'ButtonEdit1.Enabled = False
            Label7.Text = tempCode
            '栽入需拆分物料的編碼信息
            Dim mc As New MaterialController
            Dim mcL As New List(Of MaterialInfo)
            mcL = mc.MaterialCode_GetList(ButtonEdit1.Text)
            Label9.Text = mcL.Item(0).M_Gauge
            Label11.Text = mcL.Item(0).M_Unit

            Dim mw As New WareInventoryMTController
            Dim mwiL As List(Of WareInventoryInfo)

            Dim strA As String
            strA = "'" & ButtonEdit1.Text & "'"

            mwiL = mw.WareInventory_GetMaterial(Nothing, txtWH.Tag, strA)
            If mwiL.Count = 0 Then
                Label14.Text = 0
            Else
                Label14.Text = mwiL(0).WI_Qty

            End If
            '------------------------------------------------------  子物料的編碼以及數量
            Dim mcl1 As New MaterialSubInfo
            mcl1 = mc.MaterialCodeSub_Get(ButtonEdit1.Text, Nothing)

            If mcl1 Is Nothing Then
                MsgBox("當前選擇的物料不存在子物料")
                'TextEdit1.Enabled = False
                Exit Sub
            End If

            ButtonEdit2.EditValue = mcl1.M_CodeSub
            TextEdit1.Text = mcl1.M_Qty
            'ButtonEdit2.Enabled = False
            TextEdit1.Enabled = False
            '------------------------------------------------------ 子物料的名稱以及規格
            Dim mc2 As New MaterialController
            Dim mcL2 As List(Of MaterialInfo)

            mcL2 = mc2.MaterialCode_GetList(mcl1.M_CodeSub)
            Label21.Text = mcl1.M_CodeSub
            Label19.Text = mcL2.Item(0).M_Gauge
            Label17.Text = mcL2.Item(0).M_Unit
            '------------------------------------------------------ 子物料在當前倉庫的庫存數
            Dim mw2 As New WareInventoryMTController
            Dim mwiL2 As List(Of WareInventoryInfo)

            Dim strB As String
            strB = "'" & ButtonEdit2.Text & "'"

            mwiL2 = mw2.WareInventory_GetMaterial(Nothing, txtWH.Tag, strB)
            If mwiL2.Count = 0 Then
                Label15.Text = 0
            Else
                Label15.Text = mwiL2(0).WI_Qty
            End If




            ''栽入可供拆合物料的編碼信息

            'Dim mc2 As New MaterialController
            'Dim mcL2 As New List(Of MaterialInfo)
            'Dim mcl3 As New List(Of MaterialInfo)
            ''   mcl3=mc2.
            'mcL2 = mc2.MaterialCode_GetList(tempCode)
            'Label19.Text = mcL.Item(0).M_Gauge
            'Label17.Text = mcL.Item(0).M_Unit
            'Dim mw2 As New WareInventoryMTController
            'Dim mwiL2 As New List(Of WareInventoryInfo)
            'mwiL2 = mw2.WareInventory_GetMaterial(Nothing, txtWH.tag, tempCode)
            'If mwiL.Count = 0 Then
            '    Label14.Text = "0"
            'Else
            '    Label14.Text = mwiL.Item(0).WI_Qty
            'End If
            GroupBox2.Visible = True
            GroupBox3.Visible = True
        End If
        tempCode = ""
    End Sub

    Function DataNew() As Boolean   '拆分記錄添加

        Dim swi As New WareHouseSplitInfo
        Dim swc As New WareHouseSplitControl
        swi.S_ID = GetID()
        swi.WH_ID = txtWH.Tag
        swi.M_LCode = ButtonEdit1.Text
        swi.M_SCode = ButtonEdit2.Text
        swi.S_Type = "拆分"
        swi.S_Qty = TextEdit2.Text
        swi.S_Ratio = TextEdit1.Text
        swi.WI_LQty = CDbl(Label14.Text) - CDbl(TextEdit2.Text)
        swi.WI_SQty = CDbl(Label15.Text) + CDbl(txtQuoID.Text)
        swi.S_AddDate = Now
        swi.S_Action = InUserID
        swi.S_Remark = txtS_Remark.Text.Trim

        If swc.WareHouseSplit_Add(swi) = False Then
            DataNew = False
        Else
            DataNew = True
        End If

    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtWH.Text = "" Then
            MsgBox("操作倉庫名稱不能為空，請輸入操作倉庫名稱!", 64, "提示")
            txtWH.Focus()
            Exit Sub
        End If
        If ButtonEdit1.Text = "" Then
            MsgBox("大單位主物料不能為空，請輸入大單位主物料!", 64, "提示")
            ButtonEdit1.Focus()
            Exit Sub
        End If
        If TextEdit2.Text = "" Then
            MsgBox("拆分數量不能為空，請輸入拆分數量!", 64, "提示")
            TextEdit2.Focus()
            Exit Sub
        End If

        Dim mt As New Library.Purchase.SharePurchase.SharePurchaseController
        Dim mm As New Library.Purchase.SharePurchase.SharePurchaseInfo
        Dim mm1 As New Library.Purchase.SharePurchase.SharePurchaseInfo

        Dim strqty As Double

        Dim mw2 As New WareInventoryMTController
        Dim mwiL2 As List(Of WareInventoryInfo)
        mwiL2 = mw2.WareInventory_GetList3(ButtonEdit1.Text, txtWH.Tag, "True")

        If mwiL2.Count = 0 Then
            strqty = 0
        Else
            strqty = mwiL2(0).WI_Qty
        End If
        If CDbl(TextEdit2.Text) > strqty Then   '判斷當前物料是否可以拆分(判斷大單位物料在當前倉庫的庫存數)
            MsgBox("當前倉庫此拆分物料小於拆分數量!")
            Exit Sub
        End If

        If DataNew() = True Then        '添加操作記錄

            mm.WH_ID = txtWH.Tag
            mm.M_Code = Label21.Text       '拆合后的物料
            mm.WI_Qty = CDbl(txtQuoID.Text)

            mt.UpdateWareInventory_WIQty(mm)

            mm1.WH_ID = txtWH.Tag
            mm1.M_Code = Label7.Text  '被拆合的物料
            mm1.WI_Qty = CDbl("-" & TextEdit2.Text)
            If mt.UpdateWareInventory_WIQty(mm1) = False Then
                MsgBox("庫存操作失敗，請檢查原因！")
            End If

            '-----------------------------------------------------拆分完成后更新子物料單價操作
            Dim mc As New MaterialController
            Dim mci As New MaterialSubInfo

            Dim pc As New PurchaseMainController
            Dim pci As List(Of PurchaseMainInfo)
            pci = pc.PurchaseMain_Getlist(Nothing, Nothing, Nothing, Label7.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, Nothing, Nothing)

            If pci.Count > 0 Then  '判斷主物料是否有採購記錄.如果有進行下面操作
                mci = mc.MaterialCodeSub_Get(Label7.Text, Label21.Text)
                If mci Is Nothing Then
                Else
                    Dim i As Integer
                    Dim CPrice As Double
                    Dim strA, strB, strC As String

                    i = mci.M_Qty
                    CPrice = mc.MaterialCode_Get(Label7.Text).M_Price / i  '子物料價格(根據比例來更新)
                    strA = mc.MaterialCode_Get(Label21.Text).M_Currency  '子物料本身信息不變更
                    strB = mc.MaterialCode_Get(Label21.Text).M_Supplier
                    strC = mc.MaterialCode_Get(Label21.Text).M_SupplierNo

                    mc.MaterialCode_UpdatePrice(Label21.Text, CPrice, strA, strB, strC)

                End If
            End If
            MsgBox("拆分完成！", 64, "提示")
            Me.Close()
        Else
            MsgBox("拆分失敗！", 64, "提示")
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub ButtonEdit2_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit2.ButtonClick
        tempCode = ""
        tempValue5 = txtWH.Tag
        frmBOMSelect.ShowDialog()

        '取得需拆合物料編碼
        If tempCode = "" Then
        Else
            ButtonEdit2.Text = tempCode
            Dim mc2 As New MaterialController
            Dim mcL2 As New List(Of MaterialInfo)
            Dim mcl3 As New List(Of MaterialInfo)
            '   mcl3=mc2.
            mcL2 = mc2.MaterialCode_GetList(ButtonEdit2.Text)
            Label21.Text = tempCode
            Label19.Text = mcL2.Item(0).M_Gauge
            Label17.Text = mcL2.Item(0).M_Unit
            Dim mw2 As New WareInventoryMTController
            Dim mwiL2 As List(Of WareInventoryInfo)

            Dim strA As String
            strA = "'" & ButtonEdit2.Text & "'"

            mwiL2 = mw2.WareInventory_GetMaterial(Nothing, txtWH.Tag, strA)
            If mwiL2.Count = 0 Then
                Label15.Text = 0
            Else
                Label15.Text = mwiL2(0).WI_Qty
            End If
        End If
        tempCode = ""
    End Sub

    Private Sub TextEdit1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit1.KeyUp
        If IsNumeric(TextEdit1.Text) = True Then
            '拆合--個數*比例
            If CDbl(TextEdit2.Text) > CDbl(Label15.Text) Then
                MsgBox("輸入的數量不能大於當前倉庫庫存數")
                TextEdit2.Text = Nothing
                Exit Sub
            Else
                txtQuoID.Text = CDbl(TextEdit2.Text) * CDbl(TextEdit1.Text)
            End If

        Else
            MsgBox("請正確輸入數值！")
            TextEdit1.Text = Nothing
            Exit Sub
        End If
    End Sub

    Private Sub TextEdit2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEdit2.KeyUp
        If (e.KeyValue > 47 And e.KeyValue < 58) Or (e.KeyValue > 95 And e.KeyValue < 106) Or (e.KeyValue = 8) Or (e.KeyValue = 45) Or (e.KeyValue = 46) Then
            '拆合--個數*比例
            txtQuoID.Text = CDbl(TextEdit2.Text) * CDbl(TextEdit1.Text)
        Else
            MsgBox("只能輸入整數數字！")
            TextEdit2.Text = Nothing
            Exit Sub
        End If
        'If IsNumeric(TextEdit1.Text) = True Then
        '    '拆合--個數*比例
        '    txtQuoID.Text = CSng(TextEdit2.Text) * CSng(TextEdit1.Text)
        'Else
        '    MsgBox("請正確輸入數值！")
        '    TextEdit1.Text = Nothing
        '    Exit Sub
        'End If
    End Sub
    Private Shared Function IsNumeric(ByVal str As String) As Boolean
        '判斷是否為數字（包括小數點)  
        Dim reg1 As New System.Text.RegularExpressions.Regex("\d+(\.\d+)?")
        Return reg1.IsMatch(str)
    End Function

    Private Sub frmWareChaiFen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ButtonEdit1.KeyDown
        If e.KeyCode = Keys.Space Then
            ButtonEdit1_ButtonClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub txtWH_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtWH.KeyDown
        If e.KeyCode = Keys.Space Then
            txtWH_ButtonClick(Nothing, Nothing)
        End If
    End Sub
End Class
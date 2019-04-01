Imports LFERP.Library.KnifeWare

Public Class frmTheRequirement

    Public reportName As String
    Public reportChiniseName As String

    Private m_BolSelect As Boolean = False

    Private Sub tbController_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmTheRequirement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "[" & reportChiniseName & "]" & "---列印條件"


        dtEditStart.Text = Format(DateTime.Now, "yyyy/MM/dd")
        Dim dt As DateTime = DateTime.Now.AddDays(30)
        dtEditEnd.Text = Format(dt, "yyyy/MM/dd")

        cbEdit.Text = cbEdit.Properties.Items(0)



        Select Case reportName
            Case "ScatterInventory"
                'dtEditStart.Enabled = True
                'dtEditStart.Properties.DisplayFormat.FormatString = "y"
                'dtEditStart.Properties.EditMask = "y"
                'dtEditStart.Properties.DisplayFormat.FormatString = "yyyy-MM"

                dtMonth.Visible = True
                dtMonth.Enabled = True
                dtMonth.Text = DateTime.Now.ToString("yyyy-MM")
                'dtEditStart.Visible = False
                'lblStartTime.Text = "月份"

            Case "KnifeInventory"

                gridEdit1.Enabled = True
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"
            Case "TechnicianInventory"
                m_BolSelect = True
                gridEdit1.Enabled = True
                gridEdit2.Enabled = True
                cbEdit.Enabled = True
                txtM_Code.Enabled = True '新增
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"
            Case "KnifeCheck"
                gridEdit1.Enabled = True
                gridEdit3.Enabled = True
                gridEdit4.Enabled = True
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"
            Case "MonthUseKnifeMoney"
                'dtEditStart.Enabled = True
                gridEdit1.Enabled = True
                cbEdit.Enabled = True

                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"


                dtMonth.Visible = True
                dtMonth.Enabled = True
                dtMonth.Text = DateTime.Now.ToString("yyyy-MM")
                'dtEditStart.Visible = False
                'lblStartTime.Text = "月份"


            Case "KnifeUseCondition"
                'dtEditStart.Enabled = True
                gridEdit1.Enabled = True
                cbEdit.Enabled = True


                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"

                'dtEditStart.Properties.DisplayFormat.FormatString = "y"

                dtMonth.Visible = True
                dtMonth.Enabled = True
                dtMonth.Text = DateTime.Now.ToString("yyyy-MM")
                'dtEditStart.Visible = False
                'lblStartTime.Text = "月份"

            Case "KnifeReturnRecord"
                'dtEditStart.Enabled = True


                'dtEditStart.Properties.DisplayFormat.FormatString = "y"
                dtMonth.Visible = True
                dtMonth.Enabled = True
                dtMonth.Text = DateTime.Now.ToString("yyyy-MM")
                'dtEditStart.Visible = False
                'lblStartTime.Text = "月份"
            Case "KnifeInventoryBefore"
                m_BolSelect = True
                dtEditStart.Enabled = True
                gridEdit3.Enabled = True
                gridEdit4.Enabled = True
                dtEditStart.Properties.DisplayFormat.FormatString = "y"
                Dim kibc As New KnifeInventoryBeforeControllerKnife
                gridEdit3.Properties.DataSource = kibc.GetKnifeInventoryBeforeM_Name()
                gridEdit3.Properties.DisplayMember = "M_Name"
                gridEdit3.Properties.ValueMember = "M_Name"
            Case "KnifeBorrow"                            '借刀
                m_BolSelect = True
                dtEditStart.Enabled = True
                gridEdit1.Enabled = True
                cbEdit.Enabled = True
                txtM_Code.Enabled = True '新增
                dtEditStart.Properties.DisplayFormat.FormatString = "y"
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"
                dtEditEnd.Enabled = True

            Case "KnifeReturn"                           '還刀
                m_BolSelect = True
                dtEditStart.Enabled = True
                gridEdit1.Enabled = True
                cbEdit.Enabled = True
                txtM_Code.Enabled = True '新增
                dtEditStart.Properties.DisplayFormat.FormatString = "y"
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"

                dtEditEnd.Enabled = True



            Case "InventoryKnifeMoney"
                gridEdit1.Enabled = True
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"
            Case "UseKnifeScatter"
                gridEdit1.Enabled = True
                gridEdit3.Enabled = True
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"
            Case "UseKnifeQty"
                gridEdit1.Enabled = True
                gridEdit3.Enabled = True
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"
            Case "SomeoneNoReturn"
                m_BolSelect = True
                gridEdit1.Enabled = True        '新增
                gridEdit2.Enabled = True
                Dim snrc As New SomeoneNoReturnControllerKnife
                gridEdit2.Properties.DataSource = snrc.GetSomeoneNoReturnPer()
                gridEdit2.Properties.DisplayMember = "Per_ID"
                gridEdit2.Properties.ValueMember = "Per_Name"
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"
            Case "KnifeUse"
                gridEdit3.Enabled = True
                dtEditStart.Enabled = True
                dtEditEnd.Enabled = True
                LabelControl7.Visible = True
                LabelControl7.Text = "到"
                dtEditEnd.Visible = True
                dtEditStart.Properties.EditMask = "D"
                dtEditEnd.Properties.EditMask = "D"
                dtEditStart.Properties.DisplayFormat.FormatString = "D"
                dtEditEnd.Properties.DisplayFormat.FormatString = "D"
                Dim kuc As New KnifeUseControllerKnife
                gridEdit3.Properties.DataSource = kuc.GetKnifeUseMname()
                gridEdit3.Properties.DisplayMember = "M_Name"
                gridEdit3.Properties.ValueMember = "M_Name"
            Case "StaffKnifeMoney"
                m_BolSelect = True
                dtEditStart.Enabled = True
                gridEdit1.Enabled = True
                gridEdit2.Enabled = True
                LabelControl7.Visible = True
                gridTeam.Visible = True
                dtEditStart.Properties.DisplayFormat.FormatString = "Y"
                Dim kic As New KnifeInventoryControllerKnife
                gridEdit1.Properties.DataSource = kic.GetKnifeInventoryWH()
                gridEdit1.Properties.DisplayMember = "WH_Name"
                gridEdit1.Properties.ValueMember = "WH_ID"
            Case Else
                MsgBox("請重新選擇打印報表", 64, "提示")
                Me.Close()
        End Select

    End Sub

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click



        Select Case reportName
            Case "ScatterInventory"
                '
                Dim sic As New ScatterInventoryControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim siinfo As New List(Of ScatterInventoryInfoKnife)
                If dtMonth.EditValue Is Nothing Then
                    MsgBox("請輸入月份", 64, "提示")
                    Exit Sub
                End If

                'siinfo = sic.GetScatteInventory(Format$(dtEditStart.EditValue, "yyyy-MM"))

                siinfo = sic.GetScatteInventory(dtMonth.Text)
                If siinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "KnifeInventory", siinfo)
                    PreviewRPTDialog(ds, "00rptSactterInventory", "盤點以往庫存", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing


            Case "KnifeInventory"
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("請選擇倉庫", 64, "提示")
                    Exit Sub
                End If
                Dim kic As New KnifeInventoryControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim kiinfo As New List(Of KnifeInventoryInfoKnife)
                kiinfo = kic.GetKnifeInventory(gridEdit1.EditValue)
                If kiinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "KnifeInventory", kiinfo)
                    PreviewRPTDialog(ds, "01rptKnifeInventory", "刀具倉庫庫存", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "TechnicianInventory"
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("請選擇倉庫", 64, "提示")
                    Exit Sub
                End If

                If gridEdit2.Text = "" Then
                    MsgBox("請選擇工號", 64, "提示")
                    Exit Sub
                End If
                If cbEdit.Text.Trim = "" Then
                    MsgBox("請選擇類型", 64, "提示")
                    Exit Sub
                End If

                If (txtM_Code.Text = "") Or txtM_Code.Text.Length > 30 Then
                    MsgBox("請輸入編碼或者編碼超出長度", 64, "提示")
                    Exit Sub
                End If

                Dim tic As New TechnicianInventoryControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim tiinfo As New List(Of TechnicianInventoryInfoKnife)
                tiinfo = tic.GetTechnicianInventory(gridEdit1.EditValue, gridEdit2.Text, cbEdit.EditValue, txtM_Code.Text)
                If tiinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "TechnicianInventory", tiinfo)
                    ''''''''''''''''''''''''2013-11-7 姚駿新增''''''''''''''''''''''''''''''''
                    If cbEdit.EditValue <> "所有刀具" Then
                        PreviewRPTDialog(ds, "02rptTechnicianInventory", "技術員庫存", True, True)
                    Else
                        PreviewRPTDialog(ds, "02rptTechnicianInventoryAll", "技術員庫存", True, True)
                    End If
                    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "KnifeCheck"
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("請選擇部門", 64, "提示")
                    Exit Sub
                End If
                If gridEdit3.EditValue = Nothing Then
                    MsgBox("請選擇名稱", 64, "提示")
                    Exit Sub
                End If
                If gridEdit4.EditValue = Nothing Then
                    MsgBox("請選擇規格", 64, "提示")
                    Exit Sub
                End If
                Dim kcc As New KnifeCheckControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim kcinfo As New List(Of KnifeCheckInfoKnife)
                kcinfo = kcc.GetKnifeCheck(gridEdit1.EditValue, gridEdit3.EditValue, gridEdit4.EditValue)
                If kcinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "KnifeCheck", kcinfo)
                    PreviewRPTDialog(ds, "03rptKnifeCheck", "刀具盤點表", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "MonthUseKnifeMoney"
                If dtMonth.EditValue = Nothing Then
                    MsgBox("請選擇月份", 64, "提示")
                    Exit Sub
                End If
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("請選擇倉庫", 64, "提示")
                    Exit Sub
                End If
                If cbEdit.EditValue = Nothing Then
                    MsgBox("請選擇刀具類型", 64, "提示")
                    Exit Sub
                End If
                Dim mukmc As New MonthUseKnifeMoneyControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim mukminfo As New List(Of MonthUseKnifeMoneyInfoKnife)
                mukminfo = mukmc.GetMonthUseKnifeMoney(dtMonth.Text, gridEdit1.EditValue, cbEdit.EditValue)
                If mukminfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "MonthUseKnifeMoney", mukminfo)
                    PreviewRPTDialog(ds, "04rptMonthUseKnifeMoney", "每月刀具領用金額匯總", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "KnifeUseCondition"
                If dtMonth.EditValue = Nothing Then
                    MsgBox("請選擇月份", 64, "提示")
                    Exit Sub
                End If
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    gridEdit1.EditValue = Nothing
                    Exit Sub
                End If
                If gridEdit1.EditValue = "all" Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    gridEdit1.EditValue = Nothing
                    Exit Sub
                End If
                If cbEdit.EditValue = Nothing Then
                    MsgBox("請選擇刀具類型", 64, "提示")
                    Exit Sub
                End If

                Dim kucc As New KnifeUseConditionControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim kucinfo As New List(Of KnifeUseConditionInfoKnife)
                'kucinfo = kucc.GetKnifeUseCondition(Format$(dtEditStart.EditValue, "yyyy-MM"), gridEdit1.EditValue, cbEdit.EditValue)
                kucinfo = kucc.GetKnifeUseCondition(dtMonth.Text, gridEdit1.EditValue, cbEdit.EditValue)
                If kucinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "KnifeUseCondition", kucinfo)
                    PreviewRPTDialog(ds, "05rptKnifeUseCondition", "每月道具領用狀況", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "KnifeReturnRecord"
                If dtMonth.EditValue = Nothing Then
                    MsgBox("請選擇月份", 64, "提示")
                    Exit Sub
                End If
                Dim krrc As New KnifeReturnRecordControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim krrinfo As New List(Of KnifeReturnRecordInfoKnife)
                'krrinfo = krrc.GetKnifeReturnRecord(Format$(dtEditStart.EditValue, "yyyy-MM"))
                krrinfo = krrc.GetKnifeReturnRecord(dtMonth.Text)
                If krrinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "KnifeReturnRecord", krrinfo)
                    PreviewRPTDialog(ds, "08rptKnifeReturnRecord", "回收記錄一覽表", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "KnifeInventoryBefore"
                MsgBox("暫時還未做", 64, "提示")
            Case "KnifeBorrow"
                If dtEditStart.EditValue = Nothing Then
                    MsgBox("請選擇月份", 64, "提示")
                    Exit Sub
                End If
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    gridEdit1.EditValue = Nothing
                    Exit Sub
                End If
                If gridEdit1.EditValue = "all" Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    gridEdit1.EditValue = Nothing
                    Exit Sub
                End If
                If cbEdit.EditValue = Nothing Then
                    MsgBox("請選擇刀具類型", 64, "提示")
                    Exit Sub
                End If

                If (txtM_Code.Text = "") Or txtM_Code.Text.Length > 30 Then
                    MsgBox("請輸入編碼或者編碼超出長度", 64, "提示")
                    Exit Sub
                End If


                If gridEdit2.Text = "" Then
                    MsgBox("請選擇工號", 64, "提示") '
                    Exit Sub
                End If

                Dim kbc As New KnifeBorrowControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim kbinfo As New List(Of KnifeBorrowInfoKnife)
                'kbinfo = kbc.GetKnifeBorrow(Format$(dtEditStart.EditValue, "yyyy-MM"), gridEdit1.EditValue, cbEdit.EditValue)
                kbinfo = kbc.GetKnifeBorrow(dtEditStart.EditValue, dtEditEnd.EditValue, gridEdit1.EditValue, cbEdit.EditValue, gridEdit2.Text, txtM_Code.Text)
                If kbinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "KnifeBorrow", kbinfo)
                    If cbEdit.EditValue <> "所有刀具" Then
                        PreviewRPTDialog(ds, "12rptKnifeBorrow", "刀具領取記錄", True, True)
                    Else
                        PreviewRPTDialog(ds, "12rptKnifeBorrowAll", "刀具領取記錄", True, True)
                    End If

                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "KnifeReturn"
                If dtEditStart.EditValue = Nothing Then
                    MsgBox("請選擇月份", 64, "提示")
                    Exit Sub
                End If
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    gridEdit1.EditValue = Nothing
                    Exit Sub
                End If
                If gridEdit1.EditValue = "all" Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    gridEdit1.EditValue = Nothing
                    Exit Sub
                End If
                If cbEdit.EditValue = Nothing Then
                    MsgBox("請選擇刀具類型", 64, "提示")
                    Exit Sub
                End If


                If gridEdit2.Text = "" Then
                    MsgBox("請選擇工號", 64, "提示")
                    Exit Sub
                End If

                If (txtM_Code.Text = "") Or txtM_Code.Text.Length > 30 Then
                    MsgBox("請輸入編碼或者編碼超出長度", 64, "提示")
                    Exit Sub
                End If

                Dim krc As New KnifeReturnControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim krinfo As New List(Of KnifeReturnInfoKnife)
                'krinfo = krc.GetKnifeReturn(Format$(dtEditStart.EditValue, "yyyy-MM"), gridEdit1.EditValue, cbEdit.EditValue)
                krinfo = krc.GetKnifeReturn(dtEditStart.EditValue, dtEditEnd.EditValue, gridEdit1.EditValue, cbEdit.EditValue, gridEdit2.Text, txtM_Code.Text)
                If krinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "KnifeReturn", krinfo)
                    If cbEdit.EditValue <> "所有刀具" Then
                        PreviewRPTDialog(ds, "13rptKnifeReturn", "刀具歸還記錄", True, True)
                    Else
                        PreviewRPTDialog(ds, "13rptKnifeReturnAll", "刀具歸還記錄", True, True)
                    End If

                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "InventoryKnifeMoney"
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("請選擇倉庫", 64, "提示")
                    Exit Sub
                End If
                Dim ikmc As New InventoryKnifeMoneyControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim ikminfo As New List(Of InventoryKnifeMoneyInfoKnife)
                ikminfo = ikmc.GetInventoryKnifeMoney(gridEdit1.EditValue)
                If ikminfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "InventoryKnifeMoney", ikminfo)
                    PreviewRPTDialog(ds, "14rptInventoryKnifeMoney", "在庫刀具單價表", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "UseKnifeScatter"
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    Exit Sub
                End If
                If gridEdit1.EditValue = "all" Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    Exit Sub
                End If
                If gridEdit3.EditValue = Nothing Then
                    MsgBox("請選擇名稱", 64, "提示")
                    Exit Sub
                End If
                Dim uksc As New UseKnifeScatterControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim uksinfo As New List(Of UseKnifeScatterInfoKnife)
                uksinfo = uksc.GetUseKnifeScatter(gridEdit1.EditValue, gridEdit3.EditValue)
                If uksinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "UseKnifeScatter", uksinfo)
                    PreviewRPTDialog(ds, "15rptUseKnifeScatter", "在用刀具分佈一覽", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "UseKnifeQty"
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    Exit Sub
                End If
                If gridEdit1.EditValue = "all" Then
                    MsgBox("倉庫不允許為空和全部", 64, "提示")
                    Exit Sub
                End If
                If gridEdit3.EditValue = Nothing Then
                    MsgBox("請選擇名稱", 64, "提示")
                    Exit Sub
                End If
                Dim ukqc As New UseKnifeQtyControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim ukqinfo As New List(Of UseKnifeQtyInfoKnife)
                ukqinfo = ukqc.GetUseKnifeQty(gridEdit1.EditValue, gridEdit3.EditValue)
                If ukqinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "UseKnifeQty", ukqinfo)
                    PreviewRPTDialog(ds, "16rptUseKnifeQty", "在用刀具數量統計", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "SomeoneNoReturn"

                If gridEdit1.EditValue = Nothing Then
                    MsgBox("倉庫不允許為空", 64, "提示")
                    Exit Sub
                End If

                If gridEdit2.Visible = False Then
                    MsgBox("請選擇倉庫", 64, "提示")
                    Exit Sub
                End If


                If gridEdit2.Text = "" Then
                    MsgBox("請選擇您需要查詢的工號", 64, "提示")
                    Exit Sub
                End If
                Dim snrc As New SomeoneNoReturnControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim snrinfo As New List(Of SomeoneNoReturnInfoKnife)
                snrinfo = snrc.GetSomeoneNoReturn(gridEdit2.Text)
                If snrinfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "SomeoneNoReturn", snrinfo)
                    PreviewRPTDialog(ds, "17rptSomeoneNoReturn", "人員欠刀情況", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case "KnifeUse"
                If gridEdit3.EditValue = Nothing Then
                    MsgBox("請選擇刀具名稱", 64, "提示")
                    Exit Sub
                End If
                Dim kuc As New KnifeUseControllerKnife
                Dim ds As New DataSet
                Dim ltc1 As New CollectionToDataSet
                Dim ltc2 As New CollectionToDataSet
                Dim kuinfo As New List(Of KnifeUseInfoKnife)
                Dim kusubinfo As New List(Of KnifeUseInfoKnife)
                kuinfo = kuc.GetKnifeUse(gridEdit3.EditValue)
                kusubinfo = kuc.GetKnifeUseSub(dtEditStart.EditValue, dtEditEnd.EditValue)
                If kuinfo.Count > 0 And kusubinfo.Count > 0 Then
                    ltc1.CollToDataSet(ds, "KnifeUse", kuinfo)
                    If kusubinfo.Count > 0 Then
                        ltc2.CollToDataSet(ds, "KnifeUseSub", kusubinfo)
                    End If
                    PreviewRPTDialog(ds, "18rptKnifeUse", "刀具耗用表", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc1 = Nothing
                ltc2 = Nothing
            Case "StaffKnifeMoney"
                If gridEdit1.EditValue = Nothing Then
                    MsgBox("請選擇倉庫", 64, "提示")
                    Exit Sub
                End If
                If dtEditStart.EditValue = Nothing Then
                    MsgBox("請選擇月份", 64, "提示")
                    Exit Sub
                End If
                If gridEdit2.Text = "" Then
                    MsgBox("請選擇工號", 64, "提示")
                    Exit Sub
                End If
                Dim skmc As New StaffKnifeMoneyControllerKnife
                Dim ds As New DataSet
                Dim ltc As New CollectionToDataSet
                Dim skminfo As New List(Of StaffKnifeMoneyInfoKnife)
                skminfo = skmc.GetStaffKnifeMoney(gridEdit1.EditValue, Format$(dtEditStart.EditValue, "yyyy-MM"), gridEdit2.Text)
                If skminfo.Count > 0 Then
                    ltc.CollToDataSet(ds, "StaffKnifeMoney", skminfo)
                    PreviewRPTDialog(ds, "19rptStaffKnifeMoney", "員工領刀金額", True, True)
                Else
                    MsgBox("沒有符合條件的數據", 64, "提示")
                    Exit Sub
                End If
                ltc = Nothing
            Case Else
                MsgBox("請重新選擇打印報表", 64, "提示")
        End Select
        '  Me.Close()
    End Sub

    Private Sub gridEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridEdit1.EditValueChanged
        Select Case reportName
            Case "TechnicianInventory"
                Dim gpatc As New GetPerAndTeamControllerKnife
                gridEdit2.Properties.DataSource = gpatc.GetPerByWHID(gridEdit1.EditValue)
                gridEdit2.Properties.DisplayMember = "Per_ID"
                gridEdit2.Properties.ValueMember = "Per_Name"
            Case "KnifeCheck"
                Dim kcc As New KnifeCheckControllerKnife
                gridEdit3.Properties.DataSource = kcc.GetKnifeCheckMName(gridEdit1.EditValue)
                gridEdit3.Properties.DisplayMember = "M_Name"
                gridEdit3.Properties.ValueMember = "M_Name"
                gridEdit3.EditValue = Nothing
            Case "UseKnifeScatter"
                Dim uksc As New UseKnifeScatterControllerKnife
                gridEdit3.Properties.DataSource = uksc.GetUseKnifeScatterMname(gridEdit1.EditValue)
                gridEdit3.Properties.DisplayMember = "M_Name"
                gridEdit3.Properties.ValueMember = "M_Name"
            Case "UseKnifeQty"
                Dim ukqc As New UseKnifeQtyControllerKnife
                gridEdit3.Properties.DataSource = ukqc.GetUseKnifeQtyMname(gridEdit1.EditValue)
                gridEdit3.Properties.DisplayMember = "M_Name"
                gridEdit3.Properties.ValueMember = "M_Name"
            Case "StaffKnifeMoney"
                Dim gpatc As New GetPerAndTeamControllerKnife
                gridTeam.EditValue = Nothing
                gridEdit2.EditValue = Nothing
                gridTeam.Properties.DataSource = gpatc.GetTeam(gridEdit1.EditValue)
                gridTeam.Properties.DisplayMember = "G_Name"
                gridTeam.Properties.ValueMember = "G_NO"
                gridEdit2.Properties.DataSource = gpatc.GetPerByWHID(gridEdit1.EditValue)
                gridEdit2.Properties.DisplayMember = "Per_ID"
                gridEdit2.Properties.ValueMember = "Per_Name"
        End Select
        '******************************************************2013-11-14 姚駿新增***********************************************
        '************************************************************************************************************************


        If gridEdit1.Text = "" Or Not m_BolSelect Then
            Return
        End If
        Dim strWH_ID As String = GridLookUpEdit1View.GetFocusedRowCellValue("WH_ID")
        gridEdit2.Enabled = True
        gridEdit2.Visible = True
        LabelControl2.Visible = True
        Dim kwu As New KnifeWhiteUserController
        gridEdit2.Properties.DataSource = kwu.WhiteUserSeting_GetListAll(Nothing, Nothing, strWH_ID, Nothing, Nothing, Nothing, Nothing)
        gridEdit2.Properties.DisplayMember = "Per_ID"
        gridEdit2.Properties.ValueMember = "Per_Name"


        '**************************************************************************************************************************
    End Sub

    Private Sub gridEdit3_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridEdit3.EditValueChanged
        Select Case reportName
            Case "KnifeCheck"
                Dim kcc As New KnifeCheckControllerKnife
                gridEdit4.Properties.DataSource = kcc.GetKnifeCheckMGauge(gridEdit3.EditValue)
                gridEdit4.Properties.DisplayMember = "M_Gauge"
                gridEdit4.Properties.ValueMember = "M_Gauge"
                gridEdit4.EditValue = Nothing
            Case "KnifeInventoryBefore"
                Dim kibc As New KnifeInventoryBeforeControllerKnife
                gridEdit4.Properties.DataSource = kibc.GetKnifeInventoryBeforeM_Gauge(gridEdit3.EditValue)
                gridEdit4.Properties.DisplayMember = "M_Gauge"
                gridEdit4.Properties.ValueMember = "M_Gauge"
        End Select
    End Sub

    Private Sub canButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles canButton.Click
        Me.Close()
    End Sub

    Private Sub gridTeam_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gridTeam.EditValueChanged

        gridEdit2.EditValue = Nothing
        Dim gpatc As New GetPerAndTeamControllerKnife
        gridEdit2.Properties.DataSource = gpatc.GetPerByTeam(gridTeam.EditValue, gridEdit1.EditValue)
        gridEdit2.Properties.DisplayMember = "Per_ID"
        gridEdit2.Properties.ValueMember = "Per_Name"

    End Sub

    Private Sub gridEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If gridEdit1.Text = "" Then
        '    MessageBox.Show("請先選擇倉庫")
        '    Return
        'End If

        'gridEdit2.Enabled = True
        'Dim kwu As New KnifeWhiteUserController
        'gridEdit2.Properties.DataSource = kwu.WhiteUserSeting_GetListAll(Nothing, Nothing, Nothing, Nothing, Nothing, gridEdit1.Text, Nothing)
        'gridEdit2.Properties.DisplayMember = "Per_ID"
        'gridEdit2.Properties.ValueMember = "Per_Name"
    End Sub

    Private Sub gridEdit2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

End Class
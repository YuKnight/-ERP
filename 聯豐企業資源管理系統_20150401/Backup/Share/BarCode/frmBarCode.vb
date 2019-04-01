Imports LFERP.DataSetting
Imports LFERP.Library.Purchase.Acceptance
Imports LFERP.SystemManager
Imports LFERP.Library.BarCode
Imports System.IO
Imports LFERP.Library.WareHouse.WareInput
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.Library.Outward.OutwardAcceptance
Imports LFERP.Library.WareHouse.WareInventory


Imports LFERP.Library.Material

Public Class frmBarCode
    Dim pi As New PrinterControl
    Dim ds As New DataSet
    Dim ID As String
    Private Sub frmBarCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        check.Text = tempValue3
        ID = tempValue4
        tempValue3 = ""
        tempValue4 = ""

        Select Case check.Text

            Case "驗收作業"

                LoadAcceptanceData(ID)

            Case "外發加工驗收作業"
                LoadOutwardData(ID)

            Case "出庫作業"

                LoadWareOutData(ID)

            Case "入庫作業"

                LoadWareInPutData(ID)

            Case "調拔作業"

                'Case "QC抽檢作業"
            Case "指定倉庫打印"
                LoadWareInventoryData(ID)

            Case "磨刀部指定打印"   '2013/2/22
                Qty.Visible = True
                Label3.Visible = False
                CalcEdit1.Visible = False
                ComboBoxEdit1.Enabled = False
                glPrinter.Enabled = False
                LoadMDMaterial(ID)
                glPrinter.EditValue = "ZM400"

            Case "磨刀部指定倉庫"
                Qty.Visible = True
                Label3.Visible = False
                CalcEdit1.Visible = False
                ComboBoxEdit1.Enabled = False
                glPrinter.Enabled = False

                LoadMDWareInventory(ID)
                glPrinter.EditValue = "ZM400"
            Case "磨刀部入庫作業"
                Qty.Visible = True
                Label3.Visible = False
                CalcEdit1.Visible = False
                ComboBoxEdit1.Enabled = False
                glPrinter.Enabled = False
                LoadWareInPutDataMD(ID)
                glPrinter.EditValue = "ZM400"

        End Select

        glPrinter.Properties.DisplayMember = "P_IP"
        glPrinter.Properties.ValueMember = "P_Name"
        glPrinter.Properties.DataSource = pi.Printer_GetList(Nothing)
        ComboBoxEdit1.EditValue = "A-小條碼（本地）"

        'If check.Text = "QC抽檢作業" Then
        '    ComboBoxEdit1.EditValue = "QC抽檢專用（本地）"
        'End If
    End Sub
    Sub CreateTable()

        With ds.Tables.Add("PrintCode")
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))

            .Columns.Add("PrQty", GetType(Integer))
            .Columns.Add("Qty", GetType(Integer))
        End With
        With ds.Tables.Add("DelData")
            .Columns.Add("M_Code", GetType(String))
        End With
        '綁定表格
        Grid1.DataSource = ds.Tables("PrintCode")

    End Sub

    Sub AddRow(ByVal strCode As String)
        If strCode = "" Then
        Else

            Dim i As Integer

            For i = 0 To ds.Tables("PrintCode").Rows.Count - 1
                If strCode = ds.Tables("PrintCode").Rows(i)("M_Code") Then
                    MsgBox("不允許有重復物料編碼....")
                    Exit Sub
                End If
            Next
            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)
            Dim row As DataRow
            row = ds.Tables("PrintCode").NewRow


            row("M_Code") = objInfo.M_Code
            row("M_Name") = objInfo.M_Name
            row("M_Gauge") = objInfo.M_Gauge
            row("M_Unit") = objInfo.M_Unit

            ds.Tables("PrintCode").Rows.Add(row)

            GridView1.MoveLast()
        End If
    End Sub

    Private Sub CodeAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeAdd.Click
        tempCode = ""
        frmBOMSelect.ShowDialog()
        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            AddRow(tempCode)
        End If
    End Sub

    Private Sub CodeDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeDel.Click
        If ds.Tables("PrintCode").Rows.Count = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "M_Code")

        If DelTemp = "M_Code" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelData").NewRow

            row("M_Code") = DelTemp
            ds.Tables("DelData").Rows.Add(row)
        End If
        ds.Tables("PrintCode").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click


        If InStr(check.Text, "磨刀部", CompareMethod.Text) > 0 Then
            '磨刀部 單獨打印

            PrintBarMD()

            '---------------------------------------------------------------------------------------------------
        Else


            If ComboBoxEdit1.EditValue = "A-小條碼（本地）" And glPrinter.EditValue = "888-TT" Then
                If CalcEdit1.Text = "" Then
                    CalcEdit1.Text = "1"
                End If
                If CInt(CalcEdit1.Text) < 1 Then
                    MsgBox("打印小條碼不能小於一條!")
                    Exit Sub
                End If
            End If

            Dim bc As New BarCodeControl


            Dim i As Integer
            For i = 0 To ds.Tables("PrintCode").Rows.Count - 1
                Dim str1, str2, str3, str4 As String
                str1 = ds.Tables("PrintCode").Rows(i)("M_Code")
                str2 = ds.Tables("PrintCode").Rows(i)("M_Name")
                str3 = ds.Tables("PrintCode").Rows(i)("M_Gauge")
                str4 = ds.Tables("PrintCode").Rows(i)("M_Unit")

                '    bc.StringTxt(str1, str2, str3, "", "", Format(Now, "yyyy/MM/dd"))

                If ComboBoxEdit1.EditValue = "A-小條碼（本地）" Then
                    bc.PrintSBar1(str1, str2, "LPT1", CalcEdit1.Text)

                    Threading.Thread.Sleep(1000)  '延時秒觸發

                    'bc.PrintBarCode(glPrinter.EditValue, "本地", "LPT1", str1, str2, "", "", "", "")

                ElseIf ComboBoxEdit1.EditValue = "大條碼(本地)" Then
                    bc.PrintLBar(str1, str2, str3, "", Format(Now, "yyyy/MM/dd"), "LPT1")
                    'bc.PrintSBar1(str1, str2, "LPT3", CalcEdit1.Text)
                    'bc.PrintBarCode(glPrinter.EditValue, "本地", str1, str2, str3, "", Format(Now, "yyyy/MM/dd"), "")
                Else
                    Dim TxtPath As String
                    TxtPath = "C:\lferp\聯豐企業資源管理系統\BarCode.txt" '保存ZPL路徑
                    If Not File.Exists(TxtPath) Then
                        MsgBox("不存在此路徑！")
                        Exit Sub
                    Else
                        File.Delete(TxtPath)
                        Using sw As StreamWriter = File.AppendText(TxtPath)

                            sw.WriteLine(bc.StringTxt(str1, str2, str3, str4, Format(Now, "yyyy/MM/dd")))

                        End Using
                    End If
                    bc.PrintBarCode(glPrinter.EditValue, "網絡", "", "", "", "", "", "", "C:\lferp\聯豐企業資源管理系統\ftp.txt")
                End If
            Next
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub glPrinter_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles glPrinter.EditValueChanged
        If InStr(check.Text, "磨刀部", CompareMethod.Text) > 0 Then
            Exit Sub
        End If


        If glPrinter.EditValue = "888-TT" Then

            ComboBoxEdit1.EditValue = "A-小條碼（本地）"
        Else

            ComboBoxEdit1.EditValue = "B-大條碼（網絡）"
        End If
    End Sub
    Sub LoadAcceptanceData(ByVal AcceptanceID As String)  '驗收單
        Dim ai As New AcceptanceInfo
        Dim ac As New AcceptanceController
        ai = ac.Acceptance_Get(AcceptanceID)
        If ai Is Nothing Then
            Exit Sub
        Else
            ds.Tables("PrintCode").Rows.Clear()
            LoadSubData(ac.Acceptance_GetList(Nothing, AcceptanceID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        End If

    End Sub
    Sub LoadWareInPutData(ByVal WipID As String)   '入庫作業
        Dim wi As New WareInputInfo
        Dim wc As New WareInputContraller
        wi = wc.WareInput_Get(WipID)
        If wi Is Nothing Then
            Exit Sub
        Else
            ds.Tables("PrintCode").Rows.Clear()
            LoadSubData1(wc.WareInput_Getlist(WipID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        End If
    End Sub
    Sub LoadOutwardData(ByVal OutwardAcceptanceID As String)  '外發驗收作業

        Dim oai As List(Of OutwardAcceptanceInfo)
        Dim oac As New OutwardAcceptanceControl
        oai = oac.OutwardAcceptance_GetList(OutwardAcceptanceID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If oai.Count = 0 Then
            Exit Sub
        Else
            ds.Tables("PrintCode").Rows.Clear()
            LoadSubData2(oac.OutwardAcceptance_GetList(OutwardAcceptanceID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        End If

    End Sub
    Sub LoadWareOutData(ByVal WO_ID As String) '出庫作業
        Dim woi As List(Of WareOutInfo)
        Dim woc As New WareOutController
        woi = woc.WareOut_Getlist5(WO_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If woi.Count = 0 Then
            Exit Sub
        Else
            ds.Tables("PrintCode").Rows.Clear()
            LoadSubData3(woc.WareOut_Getlist5(WO_ID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing))
        End If
    End Sub
    Sub LoadWareInventoryData(ByVal WO_ID As String) '指定倉庫打印

        Dim woi As List(Of WareInventoryInfo)
        Dim woc As New WareInventoryMTController
        woi = woc.WareInventory_GetList2(Nothing, WO_ID)
        If woi.Count = 0 Then
            Exit Sub
        Else
            ds.Tables("PrintCode").Rows.Clear()
            LoadSubData4(woc.WareInventory_GetList2(Nothing, WO_ID))
        End If

    End Sub
    Sub LoadSubData(ByVal dlist As List(Of AcceptanceInfo))
        If dlist Is Nothing Then Exit Sub
        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To dlist.Count - 1
            row = ds.Tables("PrintCode").NewRow
            row("M_Code") = dlist(i).M_Code
            row("M_Name") = dlist(i).M_Name
            row("M_Gauge") = dlist(i).M_Gauge
            row("M_Unit") = dlist(i).M_Unit
            ds.Tables("PrintCode").Rows.Add(row)
            GridView1.MoveLast()
        Next
    End Sub
    Sub LoadSubData1(ByVal dlist As List(Of WareInputInfo))
        If dlist Is Nothing Then Exit Sub
        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To dlist.Count - 1
            row = ds.Tables("PrintCode").NewRow
            row("M_Code") = dlist(i).M_Code
            row("M_Name") = dlist(i).M_Name
            row("M_Gauge") = dlist(i).M_Gauge
            row("M_Unit") = dlist(i).M_Unit
            ds.Tables("PrintCode").Rows.Add(row)
            GridView1.MoveLast()
        Next
    End Sub
    Sub LoadSubData2(ByVal dlist As List(Of OutwardAcceptanceInfo))
        If dlist Is Nothing Then Exit Sub
        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To dlist.Count - 1
            row = ds.Tables("PrintCode").NewRow
            row("M_Code") = dlist(i).M_Code
            row("M_Name") = dlist(i).M_Name
            row("M_Gauge") = dlist(i).M_Gauge
            row("M_Unit") = dlist(i).M_Unit
            ds.Tables("PrintCode").Rows.Add(row)
            GridView1.MoveLast()
        Next
    End Sub
    Sub LoadSubData3(ByVal dlist As List(Of WareOutInfo))
        If dlist Is Nothing Then Exit Sub
        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To dlist.Count - 1
            row = ds.Tables("PrintCode").NewRow
            row("M_Code") = dlist(i).M_Code
            row("M_Name") = dlist(i).M_Name
            row("M_Gauge") = dlist(i).M_Gauge
            row("M_Unit") = dlist(i).M_Unit
            ds.Tables("PrintCode").Rows.Add(row)
            GridView1.MoveLast()
        Next
    End Sub
    Sub LoadSubData4(ByVal dlist As List(Of WareInventoryInfo))
        If dlist Is Nothing Then Exit Sub
        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To dlist.Count - 1
            row = ds.Tables("PrintCode").NewRow
            row("M_Code") = dlist(i).M_Code
            row("M_Name") = dlist(i).M_Name
            row("M_Gauge") = dlist(i).M_Gauge
            row("M_Unit") = dlist(i).M_Unit
            ds.Tables("PrintCode").Rows.Add(row)
            GridView1.MoveLast()
        Next
    End Sub



    Private Sub ComboBoxEdit1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxEdit1.SelectedValueChanged

        If InStr(check.Text, "磨刀部", CompareMethod.Text) > 0 Then
            Exit Sub
        End If

        If ComboBoxEdit1.EditValue = "A-小條碼（本地）" Then
            glPrinter.EditValue = "888-TT"
            CalcEdit1.Enabled = True
            CalcEdit1.Text = 1
        Else
            CalcEdit1.Enabled = False
            glPrinter.EditValue = "ZM400"
        End If
    End Sub

    '-------------------------------------------------------------------------


    Sub PrintBarMD()
        Dim i, j As Integer
        Dim bz As String = ""

        If ds.Tables("PrintCode").Rows.Count > 0 Then
        Else
            MsgBox("無數據,不能打印！")
            Exit Sub
        End If

        For j = 0 To ds.Tables("PrintCode").Rows.Count - 1
            If ds.Tables("PrintCode").Rows(j)("Qty") > 0 Then
                bz = "Y"
            End If
        Next

        If bz = "" Then
            MsgBox("條碼打印數量為0,不能打印!")
            Exit Sub
        End If

        Dim printstr As String = ""

        For i = 0 To ds.Tables("PrintCode").Rows.Count - 1
            'PrQty
            If ds.Tables("PrintCode").Rows(i)("Qty") > 0 Then
                If ds.Tables("PrintCode").Rows(i)("Qty") Mod 2 = 0 Then
                    ds.Tables("PrintCode").Rows(i)("PrQty") = ds.Tables("PrintCode").Rows(i)("Qty") / 2
                Else
                    ds.Tables("PrintCode").Rows(i)("PrQty") = Int(ds.Tables("PrintCode").Rows(i)("Qty") / 2) + 1
                End If

                If ds.Tables("PrintCode").Rows(i)("Qty") = 1 Then
                    ds.Tables("PrintCode").Rows(i)("PrQty") = 1
                End If

                printstr = StringTxtTest(ds.Tables("PrintCode").Rows(i)("M_Gauge").ToString, ds.Tables("PrintCode").Rows(i)("M_Code").ToString, ds.Tables("PrintCode").Rows(i)("PrQty").ToString)

                Dim bc As New BarCodeControl
                CreateLPTFile("LPT1", printstr)

            End If
        Next
    End Sub
    ''' <summary>
    ''' 全部倉庫 記錄
    ''' </summary>
    ''' <param name="WH_ID"></param>
    ''' <remarks></remarks>
    Sub LoadMDWareInventory(ByVal WH_ID As String)

        ds.Tables("PrintCode").Clear()
        Dim i As Integer

        Dim mt As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
        Dim mL As New List(Of LFERP.Library.WareHouse.WareInventory.WareInventoryInfo)
        mL = mt.WareInventory_GetMaterial(Nothing, WH_ID, Nothing)

        If mL.Count > 0 Then
            For i = 0 To mL.Count - 1
                Dim row As DataRow
                row = ds.Tables("PrintCode").NewRow
                row("M_Code") = mL(i).M_Code
                row("M_Name") = mL(i).M_Name
                row("M_Gauge") = mL(i).M_Gauge
                row("M_Unit") = mL(i).M_Unit

                row("Qty") = mL(i).WI_Qty
                ds.Tables("PrintCode").Rows.Add(row)
            Next
        End If
    End Sub

    ''' <summary>
    ''' 單個物料編碼打印
    ''' </summary>
    ''' <param name="M_code"></param>
    ''' <remarks></remarks>
    Sub LoadMDMaterial(ByVal M_code As String)
        ds.Tables("PrintCode").Clear()

        Dim wl As New MaterialInfo
        Dim wic As New MaterialController


        wl = wic.MaterialCode_Get(M_code)

        Dim row As DataRow
        If wl Is Nothing Then
        Else
            row = ds.Tables("PrintCode").NewRow
            row("M_Code") = wl.M_Code
            row("M_Name") = wl.M_Name
            row("M_Gauge") = wl.M_Gauge
            row("M_Unit") = wl.M_Unit

            row("Qty") = 0
            ds.Tables("PrintCode").Rows.Add(row)
        End If
    End Sub

    ''' <summary>
    ''' 磨刀部入庫作業
    ''' </summary>
    ''' <param name="WipID"></param>
    ''' <remarks></remarks>
    Sub LoadWareInPutDataMD(ByVal WipID As String)   '入庫作業
        Dim wL As New List(Of WareInputInfo)
        Dim wc As New WareInputContraller
        Dim I As Integer

        ds.Tables("PrintCode").Clear()

        wL = wc.WareInput_Getlist(WipID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If wL.Count > 0 Then
            For I = 0 To wL.Count - 1
                Dim row As DataRow
                row = ds.Tables("PrintCode").NewRow
                row("M_Code") = wL(I).M_Code
                row("M_Name") = wL(I).M_Name
                row("M_Gauge") = wL(I).M_Gauge
                row("M_Unit") = wL(I).M_Unit

                row("Qty") = 0
                ds.Tables("PrintCode").Rows.Add(row)

            Next
        End If

    End Sub

 
End Class
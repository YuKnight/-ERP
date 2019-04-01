Imports LFERP.DataSetting
Imports LFERP.Library.Outwards
Imports LFERP.Library.Orders
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Product

Public Class frmOutWards
    Dim owc As New OutWardsController
    Dim osc As New OrdersSubController
    Dim pmc As New ProcessMainControl
    Dim pic As New ProductInventoryController
    Dim ds As New DataSet
    Dim isPressEnter As Boolean         '記錄是否按下回車鍵
    Dim LoadBZ As String
    Dim StrgluOM_CusterID As String

    Private Sub frmOutWards_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mtd As New CusterControler
        gluOM_CusterID.Properties.DisplayMember = "C_CusterID"
        gluOM_CusterID.Properties.ValueMember = "C_CusterID"
        gluOM_CusterID.Properties.DataSource = mtd.GetCusterList(Nothing, Nothing, Nothing)

        isPressEnter = False

        CreateTable()      '調用創建表過程

        Select Case Me.lblTittle.Text
            Case "送貨--新增"
                dteOW_Date.EditValue = Format(Now, "yyyy/MM/dd")
                txtOW_NO.Text = GetOW_NO()       '調用生成送貨單號函數
            Case "送貨--修改"
                LoadData()                                          '調用加載數據過程

            Case "送貨--查看"
                btnOK.Enabled = False
                LoadData()                                          '調用加載數據過程

            Case "送貨--審核"
                LoadData()                                          '調用加載數據過程
                lblOW_CheckUserName.Text = InUser
                lblOW_CheckDate.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
                Panel1.Visible = True

                cboOW_Detail.Enabled = False
                dteOW_Date.Enabled = False
                gluOM_CusterID.Enabled = False
                txtOW_Address.Enabled = False
                GridView1.OptionsBehavior.Editable = False
                btnOK.Enabled = False
        End Select

        LoadBZ = "Y"

    End Sub
    ''' <summary>
    ''' 創建表
    ''' </summary>
    ''' 此過程被以下過程調用：
    ''' frmOutWards_Load()
    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("OutWards")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("OM_ID", GetType(String))
            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("OS_Plate", GetType(String))
            .Columns.Add("OW_Qty", GetType(Integer))
            .Columns.Add("OS_Sprace", GetType(Single))
            .Columns.Add("OS_NoSendQty", GetType(Integer))
            .Columns.Add("PI_Qty", GetType(Integer))
            .Columns.Add("OW_Remark", GetType(String))
            .Columns.Add("OW_Sprace", GetType(Int32))
        End With
        Grid.DataSource = ds.Tables("OutWards")

        '創建刪除數據表
        With ds.Tables.Add("DelData")
            .Columns.Add("AutoID", GetType(String))
        End With

        With ds.Tables.Add("Out_PM_Type")
            .Columns.Add("M_Name", GetType(String))
        End With
        GridControl1.DataSource = ds.Tables("Out_PM_Type")
    End Sub
    ''' <summary>
    '''  '生成送貨單號
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    '''  frmOutWards_Load()
    ''' btnOK_Click()
    Function GetOW_NO() As String
        Dim owi As List(Of OutWardsInfo)
        Dim strOW_NO As String

        strOW_NO = "OW" & Format(Now, "yyMM")
        owi = owc.OutWards_GetList(strOW_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If owi.Count <= 0 Then
            GetOW_NO = strOW_NO & "001"
        Else
            GetOW_NO = strOW_NO & Mid((CInt(Mid(owi(0).OW_NO, 7)) + 1001), 2)
        End If

    End Function
    ''' <summary>
    ''' 加載數據
    ''' </summary>
    ''' 此過程被以下過程調用：
    '''  frmOutWards_Load()
    Sub LoadData()
        Dim owi As List(Of OutWardsInfo)
        Dim i%

        owi = owc.OutWards_GetList(txtOW_NO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If owi.Count > 0 Then      '判斷單號是否存在
            gluOM_CusterID.EditValue = owi(0).OM_CusterID
            txtOW_Address.Text = owi(0).OW_Address
            cboOW_Detail.Text = owi(0).OW_Detail
            dteOW_Date.Text = Format(owi(0).OW_Date, "yyyy/MM/dd")

            If owi(0).OW_Check = True Then              '判斷單號是否已審核
                chkOW_Check.Checked = True
                lblOW_CheckUserName.Text = owi(0).OW_CheckUserName
                lblOW_CheckDate.Text = owi(0).OW_CheckDate
                Panel1.Visible = True                              '顯示審核信息
            End If

            ds.Tables("OutWards").Clear()

            For i = 0 To owi.Count - 1
                Dim row As DataRow
                row = ds.Tables("OutWards").NewRow

                row("AutoID") = owi(i).AutoID
                row("OM_ID") = owi(i).OM_ID
                row("OS_BatchID") = owi(i).OS_BatchID
                row("PM_M_Code") = owi(i).PM_M_Code
                row("M_Code") = owi(i).M_Code

                row("PM_Type") = owi(i).PM_Type
                row("OS_Plate") = owi(i).OS_Plate
                row("OW_Qty") = owi(i).OW_Qty
                row("OS_Sprace") = owi(i).OS_Sprace
                row("OW_Sprace") = owi(i).OW_Sprace
                row("OS_NoSendQty") = owi(i).OS_NoSendQty

                'row("PI_Qty") = owi(i).PI_Qty
                row("OW_Remark") = owi(i).OW_Remark

                ''-------------2013-7-9------------------------------------------------------------
                Dim DoubleQty As Double = 0
                Dim wi1 As List(Of LFERP.Library.WareHouse.WareInventory.WareInventoryInfo)
                Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                wi1 = wc1.WareInventory_GetList(owi(i).PM_M_Code, "W2201")
                If wi1.Count <= 0 Then
                Else
                    DoubleQty = wi1(0).WI_Qty
                End If

                row("PI_Qty") = DoubleQty
                ''-------------------------------------------------------------------------

                ds.Tables("OutWards").Rows.Add(row)
            Next
        End If
    End Sub
    ''' <summary>
    ''' 保存新增數據
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    ''' btnOK_Click()
    Function AddData() As Boolean
        Dim owi As New OutWardsInfo
        Dim i%

        owi.OW_NO = txtOW_NO.Text
        owi.WH_ID = "W2201"
        owi.OW_Address = txtOW_Address.Text.Trim
        owi.OW_Detail = cboOW_Detail.Text
        owi.OW_Date = dteOW_Date.Text
        owi.OW_AddUserID = InUserID
        owi.OW_AddDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

        For i = 0 To ds.Tables("OutWards").Rows.Count - 1
            owi.OS_BatchID = ds.Tables("OutWards").Rows(i)("OS_BatchID").ToString
            owi.OM_ID = ds.Tables("OutWards").Rows(i)("OM_ID").ToString
            owi.OW_Remark = ds.Tables("OutWards").Rows(i)("OW_Remark").ToString
            owi.PM_M_Code = ds.Tables("OutWards").Rows(i)("PM_M_Code").ToString
            owi.M_Code = ds.Tables("OutWards").Rows(i)("M_Code").ToString
            owi.PM_Type = ds.Tables("OutWards").Rows(i)("PM_Type").ToString
            owi.OW_Qty = ds.Tables("OutWards").Rows(i)("OW_Qty")
            owi.OW_Sprace = ds.Tables("OutWards").Rows(i)("OW_Sprace")

            If owc.OutWards_Add(owi) = False Then
                MsgBox("批次單號為： " & ds.Tables("OutWards").Rows(i)("OS_BatchID").ToString & "  的記錄新增失敗！", 64, "提示")
                AddData = False
                Exit Function
            Else
                AddData = True
            End If
        Next
    End Function
    ''' <summary>
    ''' 保存修改數據
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    ''' btnOK_Click()
    Function EditData() As Boolean
        Dim owi As New OutWardsInfo
        Dim i, j%

        '刪除修改中刪除的數據
        For j = 0 To ds.Tables("DelData").Rows.Count - 1
            If IsDBNull(ds.Tables("DelData").Rows(j)("AutoID").ToString) = False Then                    '只刪除數據庫中存在的數據
                owc.OutWards_Delete(ds.Tables("DelData").Rows(j)("AutoID").ToString, Nothing)
            End If
        Next

        owi.OW_NO = txtOW_NO.Text
        owi.WH_ID = "W2201"
        owi.OW_Address = txtOW_Address.Text.Trim
        owi.OW_Detail = cboOW_Detail.Text
        owi.OW_Date = dteOW_Date.Text
        owi.OW_AddUserID = InUserID
        owi.OW_AddDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
        owi.OW_ModifyUserID = InUserID
        owi.OW_ModifyDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

        For i = 0 To ds.Tables("OutWards").Rows.Count - 1

            owi.AutoID = ds.Tables("OutWards").Rows(i)("AutoID").ToString
            owi.OS_BatchID = ds.Tables("OutWards").Rows(i)("OS_BatchID").ToString
            owi.OM_ID = ds.Tables("OutWards").Rows(i)("OM_ID").ToString
            owi.OW_Remark = ds.Tables("OutWards").Rows(i)("OW_Remark").ToString
            owi.PM_M_Code = ds.Tables("OutWards").Rows(i)("PM_M_Code").ToString
            owi.M_Code = ds.Tables("OutWards").Rows(i)("M_Code").ToString
            owi.PM_Type = ds.Tables("OutWards").Rows(i)("PM_Type").ToString
            owi.OW_Qty = ds.Tables("OutWards").Rows(i)("OW_Qty")

            owi.OW_Sprace = ds.Tables("OutWards").Rows(i)("OW_Sprace")

            If IsDBNull(ds.Tables("OutWards").Rows(i)("AutoID")) = True Then         '判斷是否是修改中新增的數據
                If owc.OutWards_Add(owi) = False Then
                    MsgBox("批次單號為： " & ds.Tables("OutWards").Rows(i)("OS_BatchID").ToString & "  的記錄新增失敗！", 64, "提示")
                    EditData = False
                    Exit Function
                End If
            Else
                If owc.OutWards_Update(owi) = False Then
                    MsgBox("批次單號為： " & ds.Tables("OutWards").Rows(i)("OS_BatchID").ToString & "  的記錄修改失敗！", 64, "提示")
                    EditData = False
                    Exit Function
                End If
            End If
        Next

        EditData = True
    End Function
    ''' <summary>
    ''' 保存審核信息
    ''' </summary>
    ''' <returns></returns>
    ''' 此過程被以下過程調用：
    ''' btnOK_Click()
    Function UpdateCheck() As Boolean
        Try
            Dim owi As New OutWardsInfo
            Dim i%

            owi.OW_Check = chkOW_Check.Checked
            owi.OW_CheckUserID = InUserID
            owi.OW_CheckDate = lblOW_CheckDate.Text
            For i = 0 To ds.Tables("OutWards").Rows.Count - 1
                owi.AutoID = ds.Tables("OutWards").Rows(i)("AutoID").ToString
                If owc.OutWards_UpdateCheck(owi) = False Then
                    UpdateCheck = False
                    Exit Function
                Else
                    UpdateCheck = True
                End If
            Next
        Catch ex As Exception
            UpdateCheck = False
        End Try

    End Function
    Sub LoadPM_Type()
        Dim j%
        Dim pmi As List(Of ProcessMainInfo)
        If IsDBNull(ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code")) Then Exit Sub

        pmi = pmc.ProcessMain_GetList1(Nothing, ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code"), Nothing, ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("M_Code"))
        rcboPM_Type.Items.Clear()
        rcboPM_Type.Items.Add(ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code"))
        If pmi.Count > 0 Then
            For j = 0 To pmi.Count - 1
                rcboPM_Type.Items.Add(pmi(j).M_Name)
                'rcboPM_Type.Items.Add("SSS")
            Next
        End If

        'ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_Type") = rcboPM_Type.Items.Item(0)
    End Sub
    ''' <summary>
    ''' 批次編號的文本框中按下回車鍵，加載相應數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rtxtOS_BatchID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtxtOS_BatchID.KeyDown
        'Dim i%

        'If e.KeyCode = Keys.Enter Then
        '    If gluOM_CusterID.Text.Trim = "" Or gluOM_CusterID.Text Is Nothing Then Exit Sub
        '    If sender.text = "" Then Exit Sub

        '    isPressEnter = True

        '    Dim osi As New OrdersSubInfo
        '    osi = osc.OrdersSub_Get(sender.text)
        '    If osi Is Nothing Then
        '        MsgBox("此批次單號不存在，請重新輸入！", 64, "提示")
        '        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        '        sender.text = ""
        '        Exit Sub
        '    Else
        '        If osi.OS_Check = False Then
        '            MsgBox("此批次單號尚未審核，不能出貨！", 64, "提示")
        '            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        '            sender.text = ""
        '            Exit Sub
        '        End If
        '        If osi.OM_CusterID <> gluOM_CusterID.EditValue Then
        '            MsgBox("此批次單號不屬于已選定客戶，只能輸入屬于已選定客戶的批次單號！", 64, "提示")
        '            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        '            sender.text = ""
        '            Exit Sub
        '        End If
        '        If osi.OS_NoSendQty <= 0 Then
        '            MsgBox("此批次單號已完全送貨，不能再送貨！", 64, "提示")
        '            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        '            sender.text = ""
        '            Exit Sub
        '        End If

        '        For i = 0 To ds.Tables("OutWards").Rows.Count - 1
        '            If i <> GridView1.FocusedRowHandle Then
        '                If IsDBNull(ds.Tables("OutWards").Rows(i)("OS_BatchID")) = False Then
        '                    If ds.Tables("OutWards").Rows(i)("OS_BatchID") = sender.text Then
        '                        MsgBox("同一張出貨單中不能存在相同的批次單號！", 64, "提示")
        '                        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        '                        sender.text = ""
        '                        Exit Sub
        '                    End If
        '                End If
        '            End If
        '        Next

        '        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OM_ID") = osi.OM_ID
        '        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = osi.PM_M_Code
        '        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("M_Code") = osi.M_Code
        '        'ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_Type") = ""
        '        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_Plate") = osi.OS_Plate
        '        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_Sprace") = osi.OS_Sprace
        '        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_NoSendQty") = osi.OS_NoSendQty

        '        RepositoryItemPopupContainerEdit1_Enter(Nothing, Nothing)
        '        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_Type") = ds.Tables("Out_PM_Type").Rows(0)("M_Name").ToString

        '        '加載庫存數據


        '        ''Dim pii As List(Of ProductInventoryInfo)
        '        ''pii = pic.ProductInventory_GetList(osi.PM_M_Code, osi.M_Code, "W1101", Nothing)
        '        ''If pii.Count > 0 Then
        '        ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = pii(0).PI_Qty
        '        ''Else
        '        ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = 0
        '        ''End If

        '        '查詢是否相應的倉庫中夠數  2013-5-24
        '        Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
        '        Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
        '        wi1 = wc1.WareInventory_GetSub(osi.PM_M_Code, "W1101")
        '        If wi1 Is Nothing Then
        '            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = 0
        '        Else
        '            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = wi1.WI_Qty
        '        End If




        '    End If
        '    GridView1.SetFocusedRowCellValue(OS_BatchID, sender.text)
        'End If
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“新增”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsAdd.Click
        Dim row As DataRow
        'Dim osi As List(Of OrdersSubInfo)
        'Dim i%

        If gluOM_CusterID.EditValue Is Nothing Then
            MsgBox("請輸入客戶代號！", 64, "提示")
            gluOM_CusterID.Focus()
            Exit Sub
        End If

        row = ds.Tables("OutWards").NewRow

        row("OW_Qty") = 0
        row("OS_Sprace") = 0
        row("OW_Sprace") = 0

        ds.Tables("OutWards").Rows.Add(row)

        'rlueOS_BatchID.DisplayMember = "OS_BatchID"
        'rlueOS_BatchID.ValueMember = "OS_BatchID"
        'rlueOS_BatchID.DataSource = osc.OrdersSub_GetList3(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, gluOM_CusterID.EditValue, Nothing, Nothing, DateAdd(DateInterval.Day, -900, CDate(Format(Now, "yyyy/MM/dd"))), Nothing, "True")

        'osi = osc.OrdersSub_GetList3(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, gluOM_CusterID.EditValue, Nothing, Nothing, DateAdd(DateInterval.Day, -900, CDate(Format(Now, "yyyy/MM/dd"))), Nothing, "True")
        'If osi.Count > 0 Then
        '    For i = 0 To osi.Count - 1
        '        rcboOS_BatchID.Items.Add(osi(i).OS_BatchID)
        '    Next
        'End If

        '表格第一列獲得焦點
        GridView1.Focus()
        GridView1.FocusedColumn = OS_BatchID
    End Sub
    ''' <summary>
    ''' 單擊右鍵菜單“刪除”
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmsDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmsDelete.Click
        If ds.Tables("OutWards").Rows.Count = 0 Then Exit Sub
        '在刪除表中增加被刪除的記錄，以便確定時，在數據庫中刪除此記錄
        Dim row As DataRow = ds.Tables("DelData").NewRow

        row("AutoID") = ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("AutoID")
        ds.Tables("DelData").Rows.Add(row)

        ds.Tables("OutWards").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub
    ''' <summary>
    ''' 單擊取消按鈕，關閉本窗體
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCanecl_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCanecl.Click
        Me.Close()
    End Sub
    ''' <summary>
    ''' 備注文本框中按下空格鍵，顯示下拉文本框
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub RepositoryItemMemoExEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RepositoryItemMemoExEdit1.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
    ''' <summary>
    ''' 單擊確定按鈕
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim i, j, sum%

        If Me.lblTittle.Text <> "送貨--審核" Then
            If GridView1.RowCount <= 0 Then
                MsgBox("請增加數據信息！", 64, "提示")
                GridView1.Focus()
                Exit Sub
            End If
            If dteOW_Date.Text = "" Then
                MsgBox("請輸入送貨日期！", 64, "提示")
                dteOW_Date.Focus()
                Exit Sub
            End If
            If txtOW_Address.Text.Trim = "" Then
                MsgBox("請輸入送貨地點！", 64, "提示")
                txtOW_Address.Focus()
                Exit Sub
            End If

            For i = 0 To ds.Tables("OutWards").Rows.Count - 1
                If IsDBNull(ds.Tables("OutWards").Rows(i)("OS_BatchID")) = True Or ds.Tables("OutWards").Rows(i)("OS_BatchID") = "" Then
                    GridView1.FocusedRowHandle = i
                    MsgBox("批次單號不能為空，請輸入批次單號！", 64, "提示")
                    Exit Sub
                End If
                If IsDBNull(ds.Tables("OutWards").Rows(i)("PM_M_Code")) = True Then
                    GridView1.FocusedRowHandle = i
                    MsgBox("產品編號不能為空，請輸入產品編號！", 64, "提示")
                    Exit Sub
                End If
                If IsDBNull(ds.Tables("OutWards").Rows(i)("PM_Type")) = True Then
                    GridView1.FocusedRowHandle = i
                    MsgBox("配件名稱不能為空，請輸入配件名稱！", 64, "提示")
                    Exit Sub
                End If
                If ds.Tables("OutWards").Rows(i)("OW_Qty") <= 0 Then
                    GridView1.FocusedRowHandle = i
                    MsgBox("送貨數量不能小於等於零，請重新輸入送貨數量！", 64, "提示")
                    Exit Sub
                End If
                If ds.Tables("OutWards").Rows(i)("OW_Qty") > ds.Tables("OutWards").Rows(i)("OS_NoSendQty") Then
                    GridView1.FocusedRowHandle = i
                    MsgBox("送貨數量不能大於未交貨數量，請重新輸入送貨數量！", 64, "提示")
                    Exit Sub
                End If

                sum = ds.Tables("OutWards").Rows(i)("OW_Qty")
                For j = 0 To ds.Tables("OutWards").Rows.Count - 1
                    If i <> j Then
                        If ds.Tables("OutWards").Rows(i)("PM_M_Code").ToString = ds.Tables("OutWards").Rows(j)("PM_M_Code").ToString And ds.Tables("OutWards").Rows(i)("M_Code").ToString = ds.Tables("OutWards").Rows(j)("M_Code").ToString Then
                            sum = sum + ds.Tables("OutWards").Rows(j)("OW_Qty")
                        End If
                    End If
                Next

                '暫時去
                Dim DoubleQty As Double = 0
                Dim wi1 As List(Of LFERP.Library.WareHouse.WareInventory.WareInventoryInfo)
                Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                wi1 = wc1.WareInventory_GetList(ds.Tables("OutWards").Rows(i)("PM_M_Code").ToString, "W2201")
                If wi1.Count <= 0 Then
                Else
                    DoubleQty = wi1(0).WI_Qty
                End If

                If sum > DoubleQty Then
                    GridView1.FocusedRowHandle = i
                    MsgBox("同一款產品送貨總數量不能大於庫存數量，請重新輸入送貨數量！", 64, "提示")
                    Exit Sub
                End If


            Next
        End If

        Select Case Me.lblTittle.Text
            Case "送貨--新增"
                If owc.OutWards_GetList(txtOW_NO.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing).Count > 0 Then
                    MsgBox("送貨單號已存在，請確定重新生成送貨單號！", 64, "提示")
                    txtOW_NO.Text = GetOW_NO()
                    MsgBox("已重新生成送貨單號，請重新保存數據！", 64, "提示")
                    Exit Sub
                End If

                If AddData() = True Then
                    MsgBox("數據新增成功！", 64, "提示")
                    Me.Close()
                End If
            Case "送貨--修改"
                If EditData() = True Then
                    MsgBox("數據修改成功！", 64, "提示")
                    Me.Close()
                End If
            Case "送貨--審核"
                If UpdateCheck() = True Then
                    MsgBox("審核完成！", 64, "提示")
                    Me.Close()
                End If
        End Select
    End Sub
    ''' <summary>
    ''' 當客戶代號改變后，鍞定客戶代號，不允許再修改
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub gluOM_CusterID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluOM_CusterID.EditValueChanged
        If IsDBNull(gluOM_CusterID.EditValue) = True And LoadBZ <> "" Then Exit Sub

        If ds.Tables("OutWards").Rows.Count <= 0 Or StrgluOM_CusterID = "" Or (gluOM_CusterID.EditValue = StrgluOM_CusterID And StrgluOM_CusterID <> "") Then
            StrgluOM_CusterID = gluOM_CusterID.EditValue
        Else
            gluOM_CusterID.EditValue = StrgluOM_CusterID
            MsgBox("不能修改,已存在其它客戶送貨信息!")
            Exit Sub
        End If

        Dim mtd As New CusterControler
        Dim mtdl As New List(Of CusterInfo)
        mtdl = mtd.GetCusterList(gluOM_CusterID.EditValue, Nothing, Nothing)
        txtOW_Address.Text = mtdl(0).C_Adder1

        Dim osc As New OrdersSubController
        Me.GridControl2.DataSource = osc.OrdersSub_GetList4(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, gluOM_CusterID.EditValue, Nothing, Nothing, Nothing, Nothing, True)


        ' gluOM_CusterID.Enabled = False
    End Sub
    ''' <summary>
    ''' 確認無誤復選框改變時，確定按鈕也跟著相應改變
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub chkOW_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOW_Check.CheckedChanged
        If Me.lblTittle.Text = "送貨--審核" Then            '只有審核時作此設置
            btnOK.Enabled = Not btnOK.Enabled
        End If
    End Sub
    ''' <summary>
    ''' 批次按鈕文本框失去焦點時，加載相應數據
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rtxtOS_BatchID_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rtxtOS_BatchID.Leave
        ''Dim i%

        ''If isPressEnter = True Then       '在文本框中按下過回車鍵，則不執行此過程
        ''    isPressEnter = False
        ''    Exit Sub
        ''End If

        ''If gluOM_CusterID.EditValue = "" Or gluOM_CusterID.EditValue Is Nothing Then Exit Sub

        ''Dim osi As New OrdersSubInfo
        ''osi = osc.OrdersSub_Get(sender.text)
        ''If osi Is Nothing Then          '判斷批次是否存在
        ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        ''    'ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_BatchID") = ""
        ''    sender.text = ""
        ''    Exit Sub
        ''Else
        ''    If osi.OS_Check = False Then               '判斷批次是否已審核
        ''        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        ''        'ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_BatchID") = ""
        ''        sender.text = ""
        ''        Exit Sub
        ''    End If

        ''    If osi.OM_CusterID <> gluOM_CusterID.EditValue Then          '判斷批次是否屬于選定客戶
        ''        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        ''        'ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_BatchID") = ""
        ''        sender.text = ""
        ''        Exit Sub
        ''    End If

        ''    If osi.OS_NoSendQty <= 0 Then        '判斷批次未交數量是否小於等於0，若是則此批次不能再出貨
        ''        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        ''        'ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_BatchID") = ""
        ''        sender.text = ""
        ''        Exit Sub
        ''    End If

        ''    '判斷是否存在相同批次
        ''    For i = 0 To ds.Tables("OutWards").Rows.Count - 1
        ''        If i <> GridView1.FocusedRowHandle Then
        ''            If IsDBNull(ds.Tables("OutWards").Rows(i)("OS_BatchID")) = False Then
        ''                If ds.Tables("OutWards").Rows(i)("OS_BatchID") = sender.text Then
        ''                    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
        ''                    'ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_BatchID") = ""
        ''                    sender.text = ""
        ''                    Exit Sub
        ''                End If
        ''            End If
        ''        End If
        ''    Next

        ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OM_ID") = osi.OM_ID
        ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = osi.PM_M_Code
        ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("M_Code") = osi.M_Code
        ''    'ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_Type") = ""
        ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_Plate") = osi.OS_Plate
        ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_Sprace") = osi.OS_Sprace
        ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_NoSendQty") = osi.OS_NoSendQty

        ''    'LoadPM_Type()

        ''    '加載庫存數據
        ''    ''Dim pii As List(Of ProductInventoryInfo)
        ''    ''pii = pic.ProductInventory_GetList(osi.PM_M_Code, osi.M_Code, "W1101", Nothing)
        ''    ''If pii.Count > 0 Then
        ''    ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = pii(0).PI_Qty
        ''    ''Else
        ''    ''    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = 0
        ''    ''End If

        ''    '2013-5-24
        ''    Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
        ''    Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
        ''    wi1 = wc1.WareInventory_GetSub(osi.PM_M_Code, "W1101")
        ''    If wi1 Is Nothing Then
        ''        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = 0
        ''    Else
        ''        ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = wi1.WI_Qty
        ''    End If

        ''End If
    End Sub

    Private Sub RepositoryItemPopupContainerEdit1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemPopupContainerEdit1.Enter
        Dim j%
        Dim pmi As List(Of ProcessMainInfo)
        Dim row As DataRow

        ds.Tables("Out_PM_Type").Clear()

        If IsDBNull(ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code")) Then Exit Sub

        pmi = pmc.ProcessMain_GetList1(Nothing, ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code"), "生產加工", ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("M_Code"))

        If pmi.Count > 0 Then
            For j = 0 To pmi.Count - 1
                row = ds.Tables("Out_PM_Type").NewRow
                row("M_Name") = pmi(j).Type3ID
                ds.Tables("Out_PM_Type").Rows.Add(row)
            Next
        Else
            row = ds.Tables("Out_PM_Type").NewRow
            row("M_Name") = ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code")
            ds.Tables("Out_PM_Type").Rows.Add(row)
        End If

    End Sub

    Private Sub GridView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.Click
        GridView1.SetFocusedRowCellValue(PM_Type, GridView2.GetFocusedRowCellValue("M_Name"))
        GridView1.Focus()
    End Sub

    Private Sub gluOM_CusterID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluOM_CusterID.KeyDown, cboOW_Detail.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    Private Sub GridView3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView3.Click
        Dim i%

        If GridView3.GetFocusedRowCellValue("OS_BatchID") Is Nothing Then
            Exit Sub
        End If


        Dim StrOS_Batch As String
        StrOS_Batch = GridView3.GetFocusedRowCellValue("OS_BatchID").ToString

        If gluOM_CusterID.Text.Trim = "" Or gluOM_CusterID.Text Is Nothing Then Exit Sub

        Dim osi As New OrdersSubInfo
        osi = osc.OrdersSub_Get(StrOS_Batch)
        If osi Is Nothing Then
            MsgBox("此批次單號不存在，請重新輸入！", 64, "提示")
            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
            sender.text = ""
            Exit Sub
        Else
            If osi.OS_Check = False Then
                MsgBox("此批次單號尚未審核，不能出貨！", 64, "提示")
                ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing

                Exit Sub
            End If
            If osi.OM_CusterID <> gluOM_CusterID.EditValue Then
                MsgBox("此批次單號不屬于已選定客戶，只能輸入屬于已選定客戶的批次單號！", 64, "提示")
                ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing
                sender.text = ""
                Exit Sub
            End If
            If osi.OS_NoSendQty <= 0 Then
                MsgBox("此批次單號已完全送貨，不能再送貨！", 64, "提示")
                ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing

                Exit Sub
            End If

            For i = 0 To ds.Tables("OutWards").Rows.Count - 1
                If i <> GridView1.FocusedRowHandle Then
                    If IsDBNull(ds.Tables("OutWards").Rows(i)("OS_BatchID")) = False Then
                        If ds.Tables("OutWards").Rows(i)("OS_BatchID") = StrOS_Batch Then
                            MsgBox("同一張出貨單中不能存在相同的批次單號！", 64, "提示")
                            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = Nothing

                            Exit Sub
                        End If
                    End If
                End If
            Next

            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OM_ID") = osi.OM_ID
            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_M_Code") = osi.PM_M_Code
            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("M_Code") = osi.M_Code
            'ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_Type") = ""
            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_Plate") = osi.OS_Plate
            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_Sprace") = osi.OS_Sprace
            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OW_Sprace") = osi.OS_Sprace
            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("OS_NoSendQty") = osi.OS_NoSendQty

            RepositoryItemPopupContainerEdit1_Enter(Nothing, Nothing)
            ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PM_Type") = ds.Tables("Out_PM_Type").Rows(0)("M_Name").ToString

            '查詢是否相應的倉庫中夠數  2013-5-24
            'Dim wi1 As LFERP.Library.WareHouse.WareInventory.WareInventoryInfo
            'Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            'wi1 = wc1.WareInventory_GetSub(osi.PM_M_Code, "W1101")
            'If wi1 Is Nothing Then
            '    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = 0
            'Else
            '    ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = wi1.WI_Qty
            'End If

            Dim wi1 As List(Of LFERP.Library.WareHouse.WareInventory.WareInventoryInfo)
            Dim wc1 As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
            wi1 = wc1.WareInventory_GetList(osi.PM_M_Code, "W2201")
            If wi1.Count <= 0 Then
                ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = 0
            Else
                ds.Tables("OutWards").Rows(GridView1.FocusedRowHandle)("PI_Qty") = wi1(0).WI_Qty
            End If

        End If
        GridView1.SetFocusedRowCellValue(OS_BatchID, StrOS_Batch)

    End Sub
End Class
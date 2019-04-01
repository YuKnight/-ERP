Imports LFERP.Library.ProductionApply

Public Class frmProductionApply
    Dim ds As New DataSet
    Dim pac As New ProductionApplyControl
    Dim strDpt_ID As String
    Dim strAddUserID As String
    Dim strAddDate As String

    Private Sub frmProductionApply_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CreateTable()
        Select Case lblTitle.Text
            Case "申購單--新增"
                Me.Text = "申購單--新增"
                txtPA_ApplyPersonName.Text = UserName
                detPA_ApplyDate.DateTime = Format(Now, "yyyy/MM/dd")
                txtPA_ID.Text = GetApplyID()
                XtraTabPage2.PageVisible = False
            Case "申購單--修改"
                Me.Text = "申購單--修改"
                LoadData()
                XtraTabPage2.PageVisible = False
            Case "申購單--查看"
                Me.Text = "申購單--查看"
                LoadData()
                cmdOK.Visible = False
                Grid.ContextMenuStrip.Enabled = False
            Case "申購單--審核"
                Me.Text = "申購單--審核"
                LoadData()
                XtraTabControl1.SelectedTabPageIndex = 1
                betDpt_Name.Enabled = False
                txtPA_ApplyPersonName.Properties.ReadOnly = True
                detPA_ApplyDate.Properties.ReadOnly = True
                txtPA_ApplyReason.Properties.ReadOnly = True
                PA_Qty.OptionsColumn.ReadOnly = True
                PA_Remark.OptionsColumn.ReadOnly = True
                Grid.ContextMenuStrip.Enabled = False
                cmdOK.Enabled = False
                lblPA_CheckUserName.Text = InUser
                lblPA_CheckDate.Text = Format(Now, "yyyy/MM/dd")
                chkPA_Check.Select()

        End Select

    End Sub
    ''' <summary>
    ''' 創建表
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("ProductionApply")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("PA_ID", GetType(String))
            .Columns.Add("Dpt_ID", GetType(String))
            .Columns.Add("PA_ApplyPersonName", GetType(String))
            .Columns.Add("PA_ApplyDate", GetType(String))

            .Columns.Add("PA_ApplyReason", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Name", GetType(String))

            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("PA_Qty", GetType(Single))
            .Columns.Add("PA_Remark", GetType(String))
        End With

        '創建刪除數據表，修改時刪除數據用
        With ds.Tables.Add("DelData")
            .Columns.Add("AutoID", GetType(String))
        End With

        Grid.DataSource = ds.Tables("ProductionApply")
    End Sub
    ''' <summary>
    ''' 添加物料
    ''' </summary>
    ''' <param name="strPM_M_Code"></param>
    ''' <param name="strM_Code"></param>
    ''' <remarks></remarks>
    Sub AddRow(ByVal strPM_M_Code As String, ByVal strM_Code As String)
        Dim row As DataRow
        row = ds.Tables("ProductionApply").NewRow

        If strPM_M_Code <> "" And strM_Code <> "" Then

            Dim i As Integer

            For i = 0 To ds.Tables("ProductionApply").Rows.Count - 1
                If strPM_M_Code = ds.Tables("ProductionApply").Rows(i)("PM_M_Code") And strM_Code = ds.Tables("ProductionApply").Rows(i)("M_Code") Then
                    MsgBox("此(" & strPM_M_Code & " / " & strM_Code & ")產品/物料已添加，不需再添加!", 64, "提示")
                    Exit Sub
                End If
            Next

            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strM_Code)

            If objInfo Is Nothing Then Exit Sub

            row("PM_M_Code") = strPM_M_Code
            row("M_Code") = objInfo.M_Code
            row("M_Name") = objInfo.M_Name
            row("M_Unit") = objInfo.M_Unit
            row("M_Gauge") = objInfo.M_Gauge
            row("PA_Qty") = 0
            row("PA_Remark") = ""

            ds.Tables("ProductionApply").Rows.Add(row)
        End If
        GridView1.MoveLast()
    End Sub

    ''' <summary>
    ''' 自動申購單號
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetApplyID() As String
        Dim str As String
        str = "PA" & CStr(Format(Now, "yyMM"))
        Dim pai As List(Of ProductionApplyInfo)
        pai = pac.ProductionApply_GetList(str, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If pai.Count <= 0 Then
            GetApplyID = str & "0001"
        Else
            GetApplyID = str & Mid((CInt(Mid(pai(0).PA_ID, 7)) + 10001), 2)
        End If
    End Function
    ''' <summary>
    ''' 加載數據
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadData()
        Dim i%
        Dim row As DataRow
        Dim pai As List(Of ProductionApplyInfo)
        pai = pac.ProductionApply_GetList(txtPA_ID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        strDpt_ID = pai(0).Dpt_ID
        betDpt_Name.Text = pai(0).Dpt_Name
        txtPA_ApplyPersonName.Text = pai(0).PA_ApplyPersonName
        detPA_ApplyDate.DateTime = pai(0).PA_ApplyDate
        txtPA_ApplyReason.Text = pai(0).PA_ApplyReason
        strAddUserID = pai(0).PA_AddUserID
        strAddDate = pai(0).PA_AddDate

        chkPA_Check.Checked = pai(0).PA_Check
        lblPA_CheckUserName.Text = pai(0).PA_CheckUserName
        lblPA_CheckDate.Text = pai(0).PA_CheckDate

        If IsDBNull(pai(0).PA_CheckType) = False Then
            If pai(0).PA_CheckType <> "" Then
                cboPA_CheckType.Text = pai(0).PA_CheckType
            End If
        End If

        txtPA_CheckRemark.Text = pai(0).PA_CheckRemark

        ds.Tables("ProductionApply").Clear()
        For i = 0 To pai.Count - 1
            row = ds.Tables("ProductionApply").NewRow
            row("AutoID") = pai(i).AutoID
            row("PA_ID") = pai(i).PA_ID
            row("Dpt_ID") = pai(i).Dpt_ID
            row("PA_ApplyPersonName") = pai(i).PA_ApplyPersonName
            row("PA_ApplyDate") = pai(i).PA_ApplyDate

            row("PA_ApplyReason") = pai(i).PA_ApplyReason
            row("PM_M_Code") = pai(i).PM_M_Code
            row("M_Code") = pai(i).M_Code
            row("M_Name") = pai(i).M_Name
            row("M_Gauge") = pai(i).M_Gauge

            row("M_Unit") = pai(i).M_Unit
            row("PA_Qty") = pai(i).PA_Qty
            row("PA_Remark") = pai(i).PA_Remark

            ds.Tables("ProductionApply").Rows.Add(row)
        Next
    End Sub

    '單擊確定按鈕
    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Dim i, j%
        Dim pai As New ProductionApplyInfo

        If betDpt_Name.Text = "" Then
            MsgBox("部門不能為空，請選擇部門!", 64, "提示")
            betDpt_Name.Focus()
            Exit Sub
        ElseIf txtPA_ApplyPersonName.Text.Trim = "" Then
            MsgBox("申購人不能為空，請輸入申購人!", 64, "提示")
            txtPA_ApplyPersonName.Select()
            Exit Sub
        ElseIf detPA_ApplyDate.Text.Trim = "" Then
            MsgBox("申購日期不能為空，請輸入申購日期!", 64, "提示")
            detPA_ApplyDate.Select()
            Exit Sub
        ElseIf GridView1.RowCount <= 0 Then
            MsgBox("申購物料不能為空，請添加申購物料!", 64, "提示")
            GridView1.Focus()
            Exit Sub
        End If

        For i = 0 To GridView1.RowCount - 1
            If CSng(GridView1.GetRowCellValue(i, "PA_Qty")) <= 0 Then
                MsgBox("申購數量不能小於或等於0，請重新輸入申購數量!", 64, "提示")
                GridView1.Focus()
                Exit Sub
            End If
        Next i


        '新增
        If lblTitle.Text = "申購單--新增" Then
            Dim painfo As List(Of ProductionApplyInfo)
            painfo = pac.ProductionApply_GetList(txtPA_ID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If painfo.Count > 0 Then        '判斷申購單號是否已存在
                MsgBox("申購單號已存在，需重新生成申購單號，" & vbCr & "請確定重新生成申購單號!", 64, "提示")
                txtPA_ID.Text = GetApplyID()        '存在，則調用GetApplyID()過程，重新生成申購單號
                MsgBox("申購單號已重新生成，請重新確定保存!", 64, "提示")
            Else
                pai.PA_ID = txtPA_ID.Text
                pai.Dpt_ID = strDpt_ID
                pai.PA_ApplyPersonName = txtPA_ApplyPersonName.Text.Trim
                pai.PA_ApplyDate = detPA_ApplyDate.Text
                pai.PA_ApplyReason = txtPA_ApplyReason.Text.Trim
                pai.PA_AddUserID = InUserID
                pai.PA_AddDate = Format(Now, "yyyy/MM/dd")

                For j = 0 To GridView1.RowCount - 1
                    pai.PM_M_Code = ds.Tables("ProductionApply").Rows(j)("PM_M_Code")
                    pai.M_Code = ds.Tables("ProductionApply").Rows(j)("M_Code")
                    pai.M_Name = ds.Tables("ProductionApply").Rows(j)("M_Name")
                    pai.M_Gauge = ds.Tables("ProductionApply").Rows(j)("M_Gauge")
                    pai.PA_Qty = ds.Tables("ProductionApply").Rows(j)("PA_Qty")
                    pai.M_Unit = ds.Tables("ProductionApply").Rows(j)("M_Unit")

                    pai.PA_Remark = ds.Tables("ProductionApply").Rows(j)("PA_Remark")

                    If pac.ProductionApply_Add(pai) = False Then
                        MsgBox(ds.Tables("ProductionApply").Rows(j)("PM_M_Code") & "/" & ds.Tables("ProductionApply").Rows(j)("M_Code") & " 物料添加失敗!", 64, "提示")

                        Exit Sub
                    End If
                Next
                MsgBox("數據添加完成!", 64, "提示")
                Me.Close()
            End If


            '修改
        ElseIf lblTitle.Text = "申購單--修改" Then

            If ds.Tables("DelData").Rows.Count > 0 Then
                Dim k As Integer
                '從數據庫中刪除修改時要刪除的數據
                For k = 0 To ds.Tables("DelData").Rows.Count - 1
                    If Not IsDBNull(ds.Tables("DelData").Rows(k)("AutoID")) Then
                        pac.ProductionApply_Delete(ds.Tables("DelData").Rows(k)("AutoID"), txtPA_ID.Text)
                    End If
                Next
            End If

            pai.PA_ID = txtPA_ID.Text
            pai.Dpt_ID = strDpt_ID
            pai.PA_ApplyPersonName = txtPA_ApplyPersonName.Text.Trim
            pai.PA_ApplyDate = detPA_ApplyDate.Text
            pai.PA_ApplyReason = txtPA_ApplyReason.Text.Trim
            pai.PA_ModifyUserID = InUserID
            pai.PA_ModifyDate = Format(Now, "yyyy/MM/dd")

            For j = 0 To GridView1.RowCount - 1
                If IsDBNull(ds.Tables("ProductionApply").Rows(j)("AutoID")) Then        '添加修改時新增的數據
                    pai.PM_M_Code = ds.Tables("ProductionApply").Rows(j)("PM_M_Code")
                    pai.M_Code = ds.Tables("ProductionApply").Rows(j)("M_Code")
                    pai.M_Name = ds.Tables("ProductionApply").Rows(j)("M_Name")
                    pai.M_Gauge = ds.Tables("ProductionApply").Rows(j)("M_Gauge")
                    pai.PA_Qty = ds.Tables("ProductionApply").Rows(j)("PA_Qty")
                    pai.M_Unit = ds.Tables("ProductionApply").Rows(j)("M_Unit")
                    pai.PA_Remark = ds.Tables("ProductionApply").Rows(j)("PA_Remark")
                    pai.PA_AddUserID = InUserID
                    pai.PA_AddDate = Format(Now, "yyyy/MM/dd")

                    If pac.ProductionApply_Add(pai) = False Then
                        MsgBox(ds.Tables("ProductionApply").Rows(j)("PM_M_Code") & "/" & ds.Tables("ProductionApply").Rows(j)("M_Code") & " 物料新增失敗!", 64, "提示")
                        Exit Sub
                    End If
                Else        '修改數據
                    pai.AutoID = ds.Tables("ProductionApply").Rows(j)("AutoID")
                    pai.PM_M_Code = ds.Tables("ProductionApply").Rows(j)("PM_M_Code")
                    pai.M_Code = ds.Tables("ProductionApply").Rows(j)("M_Code")
                    pai.M_Name = ds.Tables("ProductionApply").Rows(j)("M_Name")
                    pai.M_Gauge = ds.Tables("ProductionApply").Rows(j)("M_Gauge")
                    pai.PA_Qty = ds.Tables("ProductionApply").Rows(j)("PA_Qty")
                    pai.M_Unit = ds.Tables("ProductionApply").Rows(j)("M_Unit")

                    pai.PA_Remark = ds.Tables("ProductionApply").Rows(j)("PA_Remark")

                    If pac.ProductionApply_Update(pai) = False Then
                        MsgBox(ds.Tables("ProductionApply").Rows(j)("PM_M_Code") & "/" & ds.Tables("ProductionApply").Rows(j)("M_Code") & " 物料修改失敗!", 64, "提示")
                        Exit Sub
                    End If
                End If
            Next
            MsgBox("數據修改完成!", 64, "提示")
            Me.Close()


            '審核
        ElseIf lblTitle.Text = "申購單--審核" Then
            If cboPA_CheckType.Text.Trim = "" Then
                MsgBox("請選擇審核類型!", 64, "提示")
                cboPA_CheckType.Focus()
            Else
                pai.PA_ID = txtPA_ID.Text
                pai.PA_Check = True
                pai.PA_CheckType = cboPA_CheckType.Text.Trim
                pai.PA_CheckUserID = InUserID
                pai.PA_CheckDate = Format(Now, "yyyy/MM/dd")
                pai.PA_CheckRemark = txtPA_CheckRemark.Text.Trim

                If pac.ProductionApply_Check(pai) = True Then
                    If cboPA_CheckType.Text = "確認無誤" Then   '確認無誤后把數據保存為xml文件
                        ' 建立 XmlWriter 物件 
                        Dim setting As New Xml.XmlWriterSettings()
                        setting.Encoding = System.Text.Encoding.UTF8
                        setting.CloseOutput = True

                        Dim writer As Xml.XmlWriter = Xml.XmlWriter.Create(Application.StartupPath & "\FTP\XML_Out\" & txtPA_ID.Text & ".xml")
                        writer.Close() '退出資源    

                        '寫入XML文件中
                        ds.WriteXml(Application.StartupPath & "\FTP\XML_Out\" & txtPA_ID.Text & ".xml")
                    End If

                    MsgBox("已保存審核信息!", 64, "提示")
                    Me.Close()
                Else
                    MsgBox("保存審核信息失敗!", 64, "提示")
                End If
            End If
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub betDpt_Name_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles betDpt_Name.Click
        Dim frmDptSelect As New frmDepartmentSelect
        frmDptSelect.DptID = ""
        frmDptSelect.DptName = ""
        frmDptSelect.StartPosition = FormStartPosition.Manual        '把模塊顯示模式設置為手動模式
        '設置模塊的顯示位置
        frmDptSelect.Left = MDIMain.tvModule.Width + betDpt_Name.Left + MDIMain.Left + Me.Left + 13
        frmDptSelect.Top = betDpt_Name.Top + GroupBox1.Top + betDpt_Name.Height + 96 + MDIMain.Top + Me.Top
        frmDptSelect.ShowDialog()        '顯示部門選擇模塊

        If frmDptSelect.DptID <> "" Then     '判斷是否已選擇部門
            strDpt_ID = frmDptSelect.DptID        '保存部門ID
            betDpt_Name.Text = frmDptSelect.UpDptName & "-" & frmDptSelect.DptName      '顯示部門名稱
        End If
    End Sub

    '單擊右鍵菜單"新增"
    Private Sub popAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popAdd.Click
        Dim frm As New frmBOMSelect

        tempValue3 = ""
        arlM_Code.Clear()
        tempValue6 = "申購單管理"

        frm.XtraTabPage1.PageVisible = False
        frm.XtraTabPage2.PageVisible = False
        frm.Width = 825
        frm.txtLFID.Select()
        frm.ShowDialog()
        '增加記錄
        If tempValue3 = "" Or arlM_Code.Count <= 0 Then
            Exit Sub
        Else
            Dim i%
            For i = 0 To arlM_Code.Count - 1
                AddRow(tempValue3, arlM_Code(i))
            Next
        End If
    End Sub

    '單擊右鍵菜單"刪除"
    Private Sub popDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popDel.Click
        If ds.Tables("ProductionApply").Rows.Count = 0 Then Exit Sub
        '在刪除表中增加被刪除的記錄，以便確定時，在數據庫中刪除此記錄
        Dim row As DataRow = ds.Tables("DelData").NewRow

        row("AutoID") = ds.Tables("ProductionApply").Rows(GridView1.FocusedRowHandle)("AutoID")
        ds.Tables("DelData").Rows.Add(row)

        ds.Tables("ProductionApply").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub
    '確認復選框狀態改變
    Private Sub chkPA_Check_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPA_Check.CheckedChanged
        cmdOK.Enabled = Not cmdOK.Enabled       '只有確認復選框被選中時，確定按鈕才可用
    End Sub

    Private Sub betDpt_Name_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles betDpt_Name.EditValueChanged

    End Sub
End Class
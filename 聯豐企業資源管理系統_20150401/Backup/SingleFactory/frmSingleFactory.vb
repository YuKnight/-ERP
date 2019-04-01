Imports LFERP.Library.SingleFactory


Public Class frmSingleFactory

    Public ds As New DataSet

    Private Sub frmSingleFactory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label14.Text = tempValue
        txtID.Text = tempValue2
        CreateTable()
        tempValue = ""
        tempValue2 = ""
        Select Case Label14.Text
            Case "出廠單"
                If Edit = True Then
                    Me.Text = "出廠單--修改" & "[" & txtID.Text & "]"
                    LoadData(txtID.Text)
                    txtID.Enabled = False
                    'txtDate.Enabled = False
                    Label1.Text = "出廠單--修改"

                Else
                    Me.Text = "出廠單--新增"
                    txtDate.Text = Format(Now, "yyyy/MM/dd")
                    'txtID.Text = GetNO()
                    txtID.Enabled = False
                    Label7.Text = UserName
                    Label1.Text = "出廠單--新增"
                    'txtDate.Enabled = False
                End If
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                PackingAdd.Enabled = True
                PackingDel.Enabled = True
                PackingSubAdd.Enabled = True
                PackingSubDel.Enabled = True
            Case "PreView"
                Me.Text = "出廠單--查看" & "[" & txtID.Text & "]"
                LoadData(txtID.Text)
                cmdSave.Visible = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1
                Label1.Text = "出廠單--查看"
                PackingAdd.Enabled = False
                PackingDel.Enabled = False
                PackingSubAdd.Enabled = False
                PackingSubDel.Enabled = False
            Case "Check"
                Me.Text = "出廠單--審核" & "[" & txtID.Text & "]"
                LoadData(txtID.Text)
                XtraTabControl1.SelectedTabPage = XtraTabPage2
                Label1.Text = "出廠單--審核"
                PackingAdd.Enabled = False
                PackingDel.Enabled = False
                PackingSubAdd.Enabled = False
                PackingSubDel.Enabled = False
        End Select

    End Sub


    Sub CreateTables(ByVal TableName As String)

        With ds.Tables.Add(TableName)
            .Columns.Add("IndexNO", GetType(Integer))
            .Columns.Add("IDSub", GetType(Integer))
            .Columns.Add("P_NO", GetType(String))
            .Columns.Add("P_Type", GetType(String))
            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("P_Qty", GetType(Double))
            .Columns.Add("P_SP", GetType(Double))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("PB_NO", GetType(String))
            .Columns.Add("P_Help", GetType(String))

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))

        End With
        Grid2.DataSource = ds.Tables(TableName)
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()
     
        With ds.Tables.Add("SingleFactory")

            .Columns.Add("AutoID", GetType(Integer))
            .Columns.Add("ID", GetType(Integer))
            .Columns.Add("P_NO", GetType(String))
            .Columns.Add("P_Detail", GetType(String))
            .Columns.Add("P_Remark", GetType(String))
        End With
        With ds.Tables.Add("Packing")

            .Columns.Add("IndexNO", GetType(Integer))
            .Columns.Add("IDSub", GetType(Integer))
            .Columns.Add("P_NO", GetType(String))
            .Columns.Add("P_Type", GetType(String))
            .Columns.Add("OS_BatchID", GetType(String))
            .Columns.Add("P_Qty", GetType(Double))
            .Columns.Add("P_SP", GetType(Double))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("PB_NO", GetType(String))
            .Columns.Add("P_Help", GetType(String))
        End With

        With ds.Tables.Add("DelSingleFactory")
            .Columns.Add("SF_ID", GetType(String))
            .Columns.Add("P_NO", GetType(String))
            .Columns.Add("ID", GetType(Integer))
        End With
        With ds.Tables.Add("DelPacking")
            .Columns.Add("P_NO", GetType(String))
            .Columns.Add("PB_NO", GetType(String))
            .Columns.Add("IDSub", GetType(Integer))
        End With

        Grid1.DataSource = ds.Tables("SingleFactory")
        'Grid2.DataSource = ds.Tables("Packing")


    End Sub

    Public Function LoadData(ByVal SF_ID As String) As Boolean
        LoadData = True
        Dim sfc As New SingleFactoryControl
        Dim sfi As New List(Of SingleFactoryInfo)
        Try
            sfi = sfc.SingleFactory_GetList(SF_ID, Nothing, Nothing, Nothing, Nothing, Nothing)
            If sfi Is Nothing Then
                LoadData = False
                Exit Function
            End If
            txtAddress.Text = sfi(0).SF_Address
            txtDate.DateTime = sfi(0).SF_Date
            Label7.Text = sfi(0).SF_ActionName
            txtRemark.Text = sfi(0).SF_Remark
            If sfi(0).SF_Check = True Then
                CheckEdit1.Checked = True
            Else
                CheckEdit1.Checked = False
            End If
            Label11.Text = sfi(0).SF_CheckDate
            Label13.Text = sfi(0).SF_CheckActionName
            ComboBoxEdit1.EditValue = sfi(0).SF_CheckType
            MemoEdit2.Text = sfi(0).SF_CheckRemark

            ds.Tables("SingleFactory").Clear()
            LoadSub(sfc.SingleFactory_GetList(SF_ID, Nothing, Nothing, Nothing, Nothing, Nothing))

        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try
      
    End Function
  
    Sub LoadSub(ByVal dlist As List(Of SingleFactoryInfo))
        On Error Resume Next

        If dlist Is Nothing Then Exit Sub

        Dim i As Integer
        Dim row As DataRow

        For i = 0 To dlist.Count - 1

            row = ds.Tables("SingleFactory").NewRow

            row("ID") = dlist(i).ID
            row("AutoID") = dlist(i).AutoID
            row("P_NO") = dlist(i).P_NO
            row("P_Detail") = dlist(i).P_Detail
            row("P_Remark") = dlist(i).P_Remark

            ds.Tables("SingleFactory").Rows.Add(row)

            'CreateTables(row("P_NO"))
            CreateTables(row("ID"))
            LoadPackingSub(row("P_NO"), row("ID"))
        Next

    End Sub

    Sub LoadPackingSub(ByVal P_NO As String, ByVal ID As String)
        On Error Resume Next

        ds.Tables(ID).Rows.Clear()
        Dim sfc As New SingleFactoryControl
        Dim sfi As List(Of SingleFactoryInfo)

        If P_NO = "" Then Exit Sub
        sfi = sfc.Packing_GetList(P_NO, Nothing, Nothing)

        If sfi Is Nothing Then Exit Sub
        Dim i As Integer
        Dim row As DataRow

        For i = 0 To sfi.Count - 1

            row = ds.Tables(ID).NewRow

            row("IndexNO") = sfi(i).IndexNO
            row("IDSub") = sfi(i).IDSub
            row("P_NO") = sfi(i).P_NO
            row("P_Type") = sfi(i).P_Type
            row("OS_BatchID") = sfi(i).OS_BatchID
            row("P_Qty") = sfi(i).P_Qty
            row("P_SP") = sfi(i).P_SP
            row("M_Code") = sfi(i).M_Code
            row("PB_NO") = sfi(i).PB_NO
            row("P_Help") = sfi(i).P_Help

            row("M_Name") = sfi(i).M_Name
            row("M_Gauge") = sfi(i).M_Gauge

            ds.Tables(ID).Rows.Add(row)
        Next
    End Sub

    Public Function GetNO() As String '獲得出廠單號
        Dim sfc As New SingleFactoryControl
        Dim sfi As New SingleFactoryInfo
        Dim str As String
        str = Format(Now, "yyMM")
        sfi = sfc.SingleFactory_GetNO(str)
        If sfi Is Nothing Then
            GetNO = "C" & str & "0001"
        Else
            GetNO = "C" & str & Mid((CInt(Mid(sfi.SF_ID, 6)) + 10001), 2)
        End If

    End Function

    Public Function GetSingleNO(ByVal SF_ID As String) As String '獲得裝箱編號
        Dim sfc As New SingleFactoryControl
        Dim sfi As New SingleFactoryInfo

        sfi = sfc.Packing_GetPNO(SF_ID)
        If sfi Is Nothing Then
            GetSingleNO = SF_ID & "01"
        Else
            GetSingleNO = SF_ID & Mid((CInt(Mid(sfi.P_NO, 10)) + 101), 2)
        End If
    End Function

    Public Function GetPackingNO(ByVal P_NO As String) As String '獲得裝箱項目編號
        Dim sfc As New SingleFactoryControl
        Dim sfi As New SingleFactoryInfo
   
        sfi = sfc.Packing_GetNo(P_NO)
        If sfi Is Nothing Then
            GetPackingNO = P_NO & "01"
        Else
            GetPackingNO = P_NO & Mid((CInt(Mid(sfi.PB_NO, 12)) + 101), 2)
        End If
    End Function

    Sub DataNew()
        Dim sfi As New SingleFactoryInfo
        Dim sfc As New SingleFactoryControl

        txtID.Text = GetNO()
        sfi.SF_ID = txtID.Text
        sfi.SF_Address = txtAddress.Text
        sfi.SF_Date = txtDate.EditValue
        sfi.SF_Action = InUserID
        sfi.SF_Remark = txtRemark.Text

        Dim i As Integer
        For i = 0 To ds.Tables("SingleFactory").Rows.Count - 1

            'sfi.P_NO = ds.Tables("SingleFactory").Rows(i)("P_NO")
            'If i < 9 Then
            '    sfi.P_NO = GetNO() & "0" & i + 1
            'Else
            '    sfi.P_NO = GetNO() & i + 1
            'End If
            sfi.ID = ds.Tables("SingleFactory").Rows(i)("ID")
            sfi.P_NO = txtID.Text & ds.Tables("SingleFactory").Rows(i)("ID")

            If IsDBNull(ds.Tables("SingleFactory").Rows(i)("P_Detail")) Then
                sfi.P_Detail = Nothing
            Else
                sfi.P_Detail = ds.Tables("SingleFactory").Rows(i)("P_Detail")
            End If
            If IsDBNull(ds.Tables("SingleFactory").Rows(i)("P_Remark")) Then
                sfi.P_Remark = Nothing
            Else
                sfi.P_Remark = ds.Tables("SingleFactory").Rows(i)("P_Remark")
            End If

            If sfc.SingleFactory_Add(sfi) = False Then
                MsgBox("保存失敗,請檢查原因！")
                Exit Sub
            End If

        Next
        Dim sfc1 As New SingleFactoryControl
        Dim sfi1 As New SingleFactoryInfo

        Dim j As Integer

        For j = 0 To ds.Tables("SingleFactory").Rows.Count - 1
            Dim m As Integer
            Dim strName As String

            'strName = ds.Tables("SingleFactory").Rows(j)("P_NO")
            strName = ds.Tables("SingleFactory").Rows(j)("ID")

            'strName = sfi.P_NO
            For m = 0 To ds.Tables(strName).Rows.Count - 1

                'sfi1.P_NO = ds.Tables(strName).Rows(m)("P_NO")
                sfi1.P_NO = txtID.Text & strName

                sfi1.IDSub = ds.Tables(strName).Rows(m)("IDSub")
                'sfi1.P_NO = strName
                'If m < 9 Then
                '    sfi1.PB_NO = strName & "0" & m + 1
                'Else
                '    sfi1.PB_NO = strName & m + 1
                'End If

                'sfi1.PB_NO = ds.Tables(strName).Rows(m)("PB_NO")
                sfi1.PB_NO = sfi1.P_NO & ds.Tables(strName).Rows(m)("IDSub")

                If IsDBNull(ds.Tables(strName).Rows(m)("P_Type")) Then
                    MsgBox("裝箱類型 不能為空！")
                    Exit Sub
                Else
                    sfi1.P_Type = Microsoft.VisualBasic.Left(ds.Tables(strName).Rows(m)("P_Type"), 1)
                End If
                If IsDBNull(ds.Tables(strName).Rows(m)("OS_BatchID")) Then
                    sfi1.OS_BatchID = Nothing
                Else
                    sfi1.OS_BatchID = ds.Tables(strName).Rows(m)("OS_BatchID")
                End If

                If IsDBNull(ds.Tables(strName).Rows(m)("P_Qty")) Then
                    sfi1.P_Qty = 0
                Else
                    sfi1.P_Qty = ds.Tables(strName).Rows(m)("P_Qty")
                End If
                If IsDBNull(ds.Tables(strName).Rows(m)("P_SP")) Then
                    sfi1.P_SP = 0
                Else
                    sfi1.P_SP = ds.Tables(strName).Rows(m)("P_SP")
                End If
                If IsDBNull(ds.Tables(strName).Rows(m)("M_Code")) Then
                    sfi1.M_Code = Nothing
                Else
                    sfi1.M_Code = ds.Tables(strName).Rows(m)("M_Code")
                End If

                sfi1.P_Help = ""
                If sfc1.Packing_Add(sfi1) = False Then
                    MsgBox("保存失敗,請檢查原因！")
                    Exit Sub
                End If

            Next

            MsgBox(frmPackingSub.ds3.Tables("PackingSub").Rows.Count)
            '待測試!!
            '-----------------------------------------------------------------------------------------------
            If frmPackingSub.ds3.Tables("PackingSub").Rows.Count = 0 Then Exit Sub

            Dim sfc2 As New SingleFactoryControl
            Dim sfi2 As New SingleFactoryInfo

            Dim x As Integer

            For x = 0 To frmPackingSub.ds3.Tables("PackingSub").Rows.Count - 1

                sfi2.PB_NO = txtID.Text & frmPackingSub.ds3.Tables("PackingSub").Rows(x)("PB_NO")
                sfi2.M_Code = frmPackingSub.ds3.Tables("PackingSub").Rows(x)("M_Code")
                sfi2.PB_Qty = frmPackingSub.ds3.Tables("PackingSub").Rows(x)("PB_Qty")
                sfi2.PB_SP = frmPackingSub.ds3.Tables("PackingSub").Rows(x)("PB_SP")

                If sfc2.PackingSub_Add(sfi2) = False Then
                    MsgBox("保存失敗,請檢查原因！")
                    Exit Sub
                End If
            Next
            '-----------------------------------------------------------------------------------------------
        Next

        Me.Close()
    End Sub

    Sub DataEdit()

        '更新刪除的記錄
        If ds.Tables("DelSingleFactory").Rows.Count > 0 Then
            Dim k As Integer
            For k = 0 To ds.Tables("DelSingleFactory").Rows.Count - 1

                Dim odc As New SingleFactoryControl

                If Not IsDBNull(ds.Tables("DelSingleFactory").Rows(k)("P_NO")) Then
                    odc.SingleFactory_Delete(Nothing, ds.Tables("DelSingleFactory").Rows(k)("ID"), ds.Tables("DelSingleFactory").Rows(k)("P_NO")) '刪除出廠單子表
                    odc.Packing_Delete(ds.Tables("DelSingleFactory").Rows(k)("P_NO"), Nothing, Nothing)  '刪除裝箱表

                    '刪除裝箱配件表~~~~~
                    Dim odi As New List(Of SingleFactoryInfo)
                    odi = odc.Packing_GetList(ds.Tables("DelSingleFactory").Rows(k)("P_NO"), Nothing, Nothing)

                    If odi.Count > 0 Then
                        Dim n As Integer
                        For n = 0 To odi.Count - 1
                            odc.PackingSub_Delete(odi(n).PB_NO, Nothing)
                        Next
                    End If

                End If
            Next k
        End If
        If ds.Tables("DelPacking").Rows.Count > 0 Then
            Dim m As Integer
            For m = 0 To ds.Tables("DelPacking").Rows.Count - 1

                Dim odc As New SingleFactoryControl

                If Not IsDBNull(ds.Tables("DelPacking").Rows(m)("PB_NO")) Then
                    odc.Packing_Delete(Nothing, ds.Tables("DelPacking").Rows(m)("PB_NO"), ds.Tables("DelPacking").Rows(m)("IDSub")) '刪除裝箱表
                    odc.PackingSub_Delete(ds.Tables("DelPacking").Rows(m)("PB_NO"), Nothing) '刪除裝箱表下配件表
                End If
            Next m
        End If

        Dim sfi As New SingleFactoryInfo
        Dim sfc As New SingleFactoryControl

        sfi.SF_ID = txtID.Text
        sfi.SF_Address = txtAddress.Text
        sfi.SF_Date = txtDate.EditValue
        sfi.SF_Action = InUserID
        sfi.SF_Remark = txtRemark.Text

        Dim i As Integer
        For i = 0 To ds.Tables("SingleFactory").Rows.Count - 1

            If Not IsDBNull(ds.Tables("SingleFactory").Rows(i)("AutoID")) Then  ''只修改

                sfi.P_NO = ds.Tables("SingleFactory").Rows(i)("P_NO")
                If IsDBNull(ds.Tables("SingleFactory").Rows(i)("P_Detail")) Then
                    sfi.P_Detail = Nothing
                Else
                    sfi.P_Detail = ds.Tables("SingleFactory").Rows(i)("P_Detail")
                End If
                If IsDBNull(ds.Tables("SingleFactory").Rows(i)("P_Remark")) Then
                    sfi.P_Remark = Nothing
                Else
                    sfi.P_Remark = ds.Tables("SingleFactory").Rows(i)("P_Remark")
                End If

                If sfc.SingleFactory_Update(sfi) = False Then
                    MsgBox("保存失敗,請檢查原因！")
                    Exit Sub
                End If
            ElseIf IsDBNull(ds.Tables("SingleFactory").Rows(i)("AutoID")) Then  '修改新增

                'sfi.P_NO = ds.Tables("SingleFactory").Rows(i)("P_NO")
                sfi.ID = ds.Tables("SingleFactory").Rows(i)("ID")
                sfi.P_NO = txtID.Text & ds.Tables("SingleFactory").Rows(i)("ID")
                If IsDBNull(ds.Tables("SingleFactory").Rows(i)("P_Detail")) Then
                    sfi.P_Detail = Nothing
                Else
                    sfi.P_Detail = ds.Tables("SingleFactory").Rows(i)("P_Detail")
                End If
                If IsDBNull(ds.Tables("SingleFactory").Rows(i)("P_Remark")) Then
                    sfi.P_Remark = Nothing
                Else
                    sfi.P_Remark = ds.Tables("SingleFactory").Rows(i)("P_Remark")
                End If

                If sfc.SingleFactory_Add(sfi) = False Then
                    MsgBox("保存失敗,請檢查原因！")
                    Exit Sub
                End If

            End If
        Next

        Dim j As Integer
        For j = 0 To ds.Tables("SingleFactory").Rows.Count - 1

            Dim sfc1 As New SingleFactoryControl
            Dim sfi1 As New SingleFactoryInfo
            Dim m As Integer

            Dim strName As String
            'strName = ds.Tables("SingleFactory").Rows(j)("P_NO")
            strName = ds.Tables("SingleFactory").Rows(j)("ID")
            For m = 0 To ds.Tables(strName).Rows.Count - 1

                If Not IsDBNull(ds.Tables(strName).Rows(m)("IndexNO")) Then

                    sfi1.P_NO = ds.Tables(strName).Rows(m)("P_NO")
                    sfi1.PB_NO = ds.Tables(strName).Rows(m)("PB_NO")
                    If IsDBNull(ds.Tables(strName).Rows(m)("P_Type")) Then
                        MsgBox("裝箱類型不能為空！")
                        Exit Sub
                    Else
                        sfi1.P_Type = Microsoft.VisualBasic.Left(ds.Tables(strName).Rows(m)("P_Type"), 1)
                    End If
                    If IsDBNull(ds.Tables(strName).Rows(m)("OS_BatchID")) Then
                        sfi1.OS_BatchID = Nothing
                    Else
                        sfi1.OS_BatchID = ds.Tables(strName).Rows(m)("OS_BatchID")
                    End If
                    If IsDBNull(ds.Tables(strName).Rows(m)("P_Qty")) Then
                        sfi1.P_Qty = Nothing
                    Else
                        sfi1.P_Qty = ds.Tables(strName).Rows(m)("P_Qty")
                    End If
                    If IsDBNull(ds.Tables(strName).Rows(m)("P_SP")) Then
                        sfi1.P_SP = Nothing
                    Else
                        sfi1.P_SP = ds.Tables(strName).Rows(m)("P_SP")
                    End If
                    If IsDBNull(ds.Tables(strName).Rows(m)("M_Code")) Then
                        sfi1.M_Code = Nothing
                    Else
                        sfi1.M_Code = ds.Tables(strName).Rows(m)("M_Code")
                    End If

                    sfi1.P_Help = ""
                    If sfc1.Packing_Update(sfi1) = False Then
                        MsgBox("保存失敗,請檢查原因！")
                        Exit Sub
                    End If

                ElseIf IsDBNull(ds.Tables(strName).Rows(m)("IndexNO")) Then
                    'sfi1.P_NO = ds.Tables(strName).Rows(m)("P_NO")
                    sfi1.P_NO = txtID.Text & strName

                    'sfi1.PB_NO = ds.Tables(strName).Rows(m)("PB_NO")
                    sfi1.IDSub = ds.Tables(strName).Rows(m)("IDSub")

                    sfi1.PB_NO = sfi1.P_NO & ds.Tables(strName).Rows(m)("IDSub")
                    If IsDBNull(ds.Tables(strName).Rows(m)("P_Type")) Then
                        MsgBox("裝箱類型不能為空！")
                        Exit Sub
                    Else
                        sfi1.P_Type = Microsoft.VisualBasic.Left(ds.Tables(strName).Rows(m)("P_Type"), 1)
                    End If
                    If IsDBNull(ds.Tables(strName).Rows(m)("OS_BatchID")) Then
                        sfi1.OS_BatchID = Nothing
                    Else
                        sfi1.OS_BatchID = ds.Tables(strName).Rows(m)("OS_BatchID")
                    End If
                    If IsDBNull(ds.Tables(strName).Rows(m)("P_Qty")) Then
                        sfi1.P_Qty = Nothing
                    Else
                        sfi1.P_Qty = ds.Tables(strName).Rows(m)("P_Qty")
                    End If
                    If IsDBNull(ds.Tables(strName).Rows(m)("P_SP")) Then
                        sfi1.P_SP = Nothing
                    Else
                        sfi1.P_SP = ds.Tables(strName).Rows(m)("P_SP")
                    End If
                    If IsDBNull(ds.Tables(strName).Rows(m)("M_Code")) Then
                        sfi1.M_Code = Nothing
                    Else
                        sfi1.M_Code = ds.Tables(strName).Rows(m)("M_Code")
                    End If

                    sfi1.P_Help = ""
                    If sfc1.Packing_Add(sfi1) = False Then
                        MsgBox("保存失敗,請檢查原因！")
                        Exit Sub
                    End If

                    '待測試
                    '-----------------------------------------------------------------------------------------------
                   
                    'If frmPackingSub.ds3.Tables("PackingSub").Rows.Count = 0 Then Exit Sub

                    'Dim sfc2 As New SingleFactoryControl
                    'Dim sfi2 As New SingleFactoryInfo

                    'Dim x As Integer

                    'For x = 0 To frmPackingSub.ds3.Tables("PackingSub").Rows.Count - 1

                    '    sfi2.PB_NO = sfi1.P_NO & ds.Tables(strName).Rows(m)("IDSub")
                    '    sfi2.M_Code = frmPackingSub.ds3.Tables("PackingSub").Rows(x)("M_Code")
                    '    sfi2.PB_Qty = frmPackingSub.ds3.Tables("PackingSub").Rows(x)("PB_Qty")
                    '    sfi2.PB_SP = frmPackingSub.ds3.Tables("PackingSub").Rows(x)("PB_SP")

                    '    If sfc2.PackingSub_Add(sfi2) = False Then
                    '        MsgBox("保存失敗,請檢查原因！")
                    '        Exit Sub
                    '    End If
                    'Next
                    '-----------------------------------------------------------------------------------------------

                End If
            Next

        Next
        Me.Close()
    End Sub

    Sub UpdateCheck()
        Dim sfc As New SingleFactoryControl
        Dim sfi As New SingleFactoryInfo

        sfi.SF_ID = txtID.Text
        sfi.SF_Check = CheckEdit1.Checked
        sfi.SF_CheckDate = Format(Now, "yyyy/MM/dd")
        sfi.SF_CheckType = ComboBoxEdit1.EditValue
        sfi.SF_CheckAction = InUserID
        sfi.SF_CheckRemark = MemoEdit2.Text

        If sfc.SingleFactory_UpdateCheck(sfi) = True Then
            MsgBox("已保持審核信息")
        Else
            MsgBox("審核失敗,請檢查原因！")
        End If
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label14.Text
            Case "出廠單"
                If Edit = True Then
                    DataEdit()
                Else
                    DataNew()
                End If
            Case "Check"
                UpdateCheck()
        End Select

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Dim strTable As String
    Private Sub PackingAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackingAdd.Click
        On Error Resume Next

        Dim row As DataRow = ds.Tables("SingleFactory").NewRow()

        If ds.Tables("SingleFactory").Rows.Count = 0 Then
            row("ID") = 1
        Else
            row("ID") = ds.Tables("SingleFactory").Rows(ds.Tables("SingleFactory").Rows.Count - 1)("ID") + 1
        End If

        strTable = row("ID")
        ds.Tables("SingleFactory").Rows.Add(row)

        CreateTables(strTable)
    End Sub

    Private Sub PackingDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackingDel.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "P_NO")
        If DelTemp = "P_NO" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelSingleFactory").NewRow
            row("P_NO") = DelTemp
            row("ID") = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "ID")

            row("SF_ID") = txtID.Text
            ds.Tables("DelSingleFactory").Rows.Add(row)
        End If
        ds.Tables("SingleFactory").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))

    End Sub

    'Sub AddRow(ByVal Table As String, ByVal strCode As String)
    '    If strCode = "" Then Exit Sub
    '    Dim i As Integer

    '    For i = 0 To ds.Tables(Table).Rows.Count - 1
    '        If strCode = ds.Tables(Table).Rows(i)("M_Code") Then
    '            MsgBox("一張單不允許有重復物料編碼....")
    '            Exit Sub
    '        End If
    '    Next
    '    Dim mc As New LFERP.Library.Material.MaterialController
    '    Dim objInfo As New LFERP.Library.Material.MaterialInfo
    '    objInfo = mc.MaterialCode_Get(strCode)
    '    Dim row As DataRow
    '    row = ds.Tables(Table).NewRow

    '    If ds.Tables(Table).Rows.Count = 0 Then
    '        row("IDSub") = 1
    '    Else
    '        row("IDSub") = ds.Tables(Table).Rows.Count + 1
    '    End If

    '    row("M_Code") = objInfo.M_Code
    '    row("M_Name") = objInfo.M_Name
    '    row("M_Gauge") = objInfo.M_Gauge
    '    row("P_NO") = Table
    '    row("PB_NO") = Table
    '    row("P_Type") = ""
    '    row("OS_BatchID") = ""
    '    row("P_Qty") = 0
    '    row("P_SP") = 0
    '    row("P_Help") = ""

    '    ds.Tables(Table).Rows.Add(row)

    'End Sub
    Private Sub PackingSubAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackingSubAdd.Click

        If GridView1.RowCount = 0 Then
            MsgBox("請先填寫裝箱內容！")
    
            Exit Sub
        End If

        tempCode = ""
        tempValue6 = "出廠管理"
        frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 1
        frmBOMSelect.ShowDialog()
        Dim strNO As String
        'strNO = GridView1.GetFocusedRowCellValue("P_NO").ToString
        strNO = GridView1.GetFocusedRowCellValue("ID").ToString

      
        If frmBOMSelect.XtraTabControl1.SelectedTabPageIndex = 1 Then
            Dim i, n As Integer
            Dim arr(n) As String
            arr = Split(tempValue7, ",")
            n = Len(Replace(tempValue7, ",", "," & "*")) - Len(tempValue7)
            For i = 0 To n

                Dim j As Integer

                For j = 0 To ds.Tables(strNO).Rows.Count - 1
                    If arr(i) = ds.Tables(strNO).Rows(j)("M_Code") And tempValue2 = ds.Tables(strNO).Rows(j)("OS_BatchID") Then
                        MsgBox("一張單不允許同一批次存在相同物料編碼....")
                        Exit Sub
                    End If
                Next
                If arr(i) = "" Then
                    Exit Sub
                End If
                Dim mc As New LFERP.Library.Material.MaterialController
                Dim objInfo As New LFERP.Library.Material.MaterialInfo
                objInfo = mc.MaterialCode_Get(arr(i))
                Dim row As DataRow
                row = ds.Tables(strNO).NewRow

                If ds.Tables(strNO).Rows.Count = 0 Then
                    row("IDSub") = 1
                Else
                    'row("IDSub") = ds.Tables(strNO).Rows.Count + 1
                    row("IDSub") = ds.Tables(strNO).Rows(ds.Tables(strNO).Rows.Count - 1)("IDSub") + 1
                End If

                row("M_Code") = objInfo.M_Code
                row("M_Name") = objInfo.M_Name
                row("M_Gauge") = objInfo.M_Gauge
                row("P_Type") = ""
                row("OS_BatchID") = tempValue2
                row("P_Qty") = 0
                row("P_SP") = 0
                row("P_Help") = ""

                ds.Tables(strNO).Rows.Add(row)
            Next
        End If
        tempValue2 = ""
        tempValue7 = ""
    End Sub

    Private Sub PackingSubDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PackingSubDel.Click
        If GridView2.RowCount = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView2.GetRowCellDisplayText(ArrayToString(GridView2.GetSelectedRows()), "PB_NO")
        If DelTemp = "PB_NO" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelPacking").NewRow
            row("PB_NO") = DelTemp
            row("IDSub") = GridView2.GetRowCellDisplayText(ArrayToString(GridView2.GetSelectedRows()), "IDSub")
            row("P_NO") = GridView2.GetFocusedRowCellValue("P_NO").ToString
            ds.Tables("DelPacking").Rows.Add(row)
        End If
        ds.Tables(GridView1.GetFocusedRowCellValue("ID").ToString).Rows.RemoveAt(CInt(ArrayToString(GridView2.GetSelectedRows())))
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.RowCount = 0 Then Exit Sub
        Dim str, str1 As String
        Dim sfc As New SingleFactoryControl

        str = GridView1.GetFocusedRowCellValue("P_NO").ToString
        str1 = GridView1.GetFocusedRowCellValue("ID").ToString

        Select Case Label14.Text

            Case "出廠單"

                If Edit = False Then

                    LoadPackingDataSouce(str1)
                Else
                    LoadPackingSub(str, str1)
                    LoadPackingDataSouce(str1)

                End If

            Case Else
                LoadPackingSub(str, str1)
                LoadPackingDataSouce(str1)

        End Select

    End Sub
    Sub LoadPackingDataSouce(ByVal P_NO As String)
        Grid2.DataSource = ds.Tables(P_NO)
    End Sub
    '生成每箱的條碼標籤
    Private Sub cmdPrintBar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintBar.Click
        Dim str1, str2, str3, str4, str5 As String
        str1 = txtID.Text
        Dim i As Integer
        For i = 0 To ds.Tables("SingleFactory").Rows.Count - 1
            str2 = ds.Tables("SingleFactory").Rows(i)("P_NO")
            Dim sfc As New SingleFactoryControl
            Dim sfi As List(Of SingleFactoryInfo)
            sfi = sfc.Packing_GetList(ds.Tables("SingleFactory").Rows(i)("P_NO"), Nothing, Nothing)
            Dim j As Integer
            For j = 0 To sfi.Count - 1
                str3 = sfi(j).P_Type
                str4 = sfi(j).OS_BatchID
                str5 = sfi(j).P_Qty
            Next

            '-------------------------------------------------------
            '編寫列印條碼代碼


            '-------------------------------------------------------

        Next
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick
        If Microsoft.VisualBasic.Left(GridView2.GetFocusedRowCellValue("P_Type").ToString, 1) = "B" Then
            On Error Resume Next

            'tempValue3 = GridView2.GetFocusedRowCellValue("PB_NO").ToString
            'tempValue4 = Label14.Text
            'tempValue5 = GridView2.GetFocusedRowCellValue("OS_BatchID").ToString
            'tempValue6 = GridView2.GetFocusedRowCellValue("IndexNO").ToString

            'EditSub = Edit

            'Dim fr As frmPackingSub

            'For Each fr In MDIMain.MdiChildren
            '    If TypeOf fr Is frmPackingSub Then
            '        fr.Activate()
            '        Exit Sub
            '    End If
            'Next
            'fr = New frmPackingSub
            'fr.MdiParent = MDIMain
            'fr.WindowState = FormWindowState.Maximized
            'fr.Show()

            EditSub = Edit

            If Edit = False Then
                tempValue4 = Label14.Text
                tempValue5 = GridView2.GetFocusedRowCellValue("OS_BatchID").ToString
                tempValue7 = GridView1.GetFocusedRowCellValue("ID").ToString
                tempValue8 = GridView2.GetFocusedRowCellValue("IDSub").ToString
                tempValue6 = GridView2.GetFocusedRowCellValue("IndexNO").ToString

            Else
                tempValue3 = GridView2.GetFocusedRowCellValue("PB_NO").ToString
                tempValue4 = Label14.Text
                tempValue5 = GridView2.GetFocusedRowCellValue("OS_BatchID").ToString
                tempValue6 = GridView2.GetFocusedRowCellValue("IndexNO").ToString

            End If

            'Dim fr As frmPackingSub

            'For Each fr In MDIMain.MdiChildren
            '    If TypeOf fr Is frmPackingSub Then
            '        fr.Activate()
            '        Exit Sub
            '    End If
            'Next
            'fr = New frmPackingSub
            'fr.MdiParent = MDIMain
            'fr.WindowState = FormWindowState.Maximized
            'fr.Show()
            frmPackingSub.Show()
        
        Else
            MsgBox("此類型不允許選擇散件！")
            Exit Sub

        End If
    End Sub


End Class
Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionPiecePersonnelDay


Public Class ProductionPiecePersonnelDay

    Dim ds As New DataSet
    Dim StrCaoType As String


    Private Sub ProductionPiecePersonnelDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFacID.Text = tempValue2
        lblDepID.Text = tempValue3
        LblG_NO.Text = tempValue4

        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing

        CreateTables()

        Per_DateEdit.EditValue = Format(Now, "yyyy/MM/dd")

        'If LoadData() = True Then
        'End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub LoadDateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadDateButton.Click
        ProductionPiecePersonnelDate.ShowDialog()
        If tempValue = "OK" Then
            AddRowD(tempValue2)
            Find_Row()
        End If

        tempValue = Nothing
        tempValue2 = Nothing

        ProductionPiecePersonnelDate.Dispose()
    End Sub


    Private Sub CreateTables()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductionPiecePersonnelDay")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("Per_NO", GetType(String))
            .Columns.Add("Per_Name", GetType(String))
            .Columns.Add("G_NO", GetType(String))
            .Columns.Add("Per_G_Name", GetType(String))

            .Columns.Add("Per_PayType", GetType(String))
            .Columns.Add("Per_DayPrice", GetType(Double))
            .Columns.Add("Per_Remark", GetType(String))

            .Columns.Add("BZ", GetType(String))  '區分數據是載入load 的還是增加的 add
            .Columns.Add("Msg", GetType(String)) '用於顯示 ToolTipController1

        End With

        Grid1.DataSource = ds.Tables("ProductionPiecePersonnelDay")

        With ds.Tables.Add("ProductionPiecePersonnelDayDelete")
            .Columns.Add("Per_NO", GetType(String))
            .Columns.Add("G_NO", GetType(String))
            .Columns.Add("AutoID", GetType(String))
        End With

        With ds.Tables.Add("Type")
            .Columns.Add("Per_PayType")
            .Columns.Add("Remark")
        End With
        RepositoryItemLookUpEdit3.DataSource = ds.Tables("Type")
        RepositoryItemLookUpEdit3.DisplayMember = "Per_PayType"
        RepositoryItemLookUpEdit3.ValueMember = "Per_PayType"

        RepositoryItemGridLookUpEdit1.DataSource = ds.Tables("Type")
        RepositoryItemGridLookUpEdit1.DisplayMember = "Per_PayType"
        RepositoryItemGridLookUpEdit1.ValueMember = "Per_PayType"

        AddRow()

    End Sub

    Sub AddRow()
        Dim row As DataRow
        ds.Tables("Type").Clear()
        row = ds.Tables("Type").NewRow()
        row("Per_PayType") = "計件"
        row("Remark") = "工序計件類"
        ds.Tables("Type").Rows.Add(row)
        row = ds.Tables("Type").NewRow()
        row("Per_PayType") = "計時"
        row("Remark") = "車床及CNC計時類"
        ds.Tables("Type").Rows.Add(row)
        row = ds.Tables("Type").NewRow()
        row("Per_PayType") = "日薪"
        row("Remark") = "承包組內日薪員工"
        ds.Tables("Type").Rows.Add(row)
    End Sub


    Private Sub AddRowB()
        Dim i As Integer

        Dim objList As New List(Of ProductionPiecePersonnelInfo)
        Dim oc As New ProductionPiecePersonnelControl

        objList = oc.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, LblG_NO.Text, lblDepID.Text, lblFacID.Text, Nothing, Nothing, Nothing, False, Nothing, Nothing)

        If objList.Count <= 0 Then
            MsgBox("沒有數據！")
            Exit Sub
        End If

        ds.Tables("ProductionPiecePersonnelDay").Clear()

        For i = 0 To objList.Count - 1
            Dim row1 As DataRow = ds.Tables("ProductionPiecePersonnelDay").NewRow

            row1("Per_NO") = objList(i).Per_NO
            row1("Per_Name") = objList(i).Per_Name
            row1("Per_PayType") = objList(i).Per_PayType
            row1("Per_DayPrice") = objList(i).Per_DayPrice
            row1("Per_Remark") = ""
            row1("BZ") = "load"

            ds.Tables("ProductionPiecePersonnelDay").Rows.Add(row1)

            GridView2.MoveLast()
            GridView2.Columns("Per_NO").View.Focus()
        Next

    End Sub


    Private Sub AddRowD(ByVal Date1 As String)
        Dim i As Integer



        Dim objList As New List(Of ProductionPiecePersonnelDayInfo)
        Dim oc As New ProductionPiecePersonnelDayControl

        objList = oc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, Nothing, Nothing, LblG_NO.Text, lblDepID.Text, lblFacID.Text, Nothing, Date1, Nothing, Nothing, Date1, Nothing)

        If objList.Count <= 0 Then
            MsgBox("沒有數據！")
            Exit Sub
        End If

        ds.Tables("ProductionPiecePersonnelDay").Clear()
        For i = 0 To objList.Count - 1

            Dim row1 As DataRow = ds.Tables("ProductionPiecePersonnelDay").NewRow

            row1("Per_NO") = objList(i).Per_NO
            row1("Per_Name") = objList(i).Per_Name
            row1("Per_PayType") = objList(i).Per_PayType
            row1("Per_DayPrice") = objList(i).Per_DayPrice
            row1("Per_Remark") = ""
            row1("BZ") = "load"

            ds.Tables("ProductionPiecePersonnelDay").Rows.Add(row1)

            GridView2.MoveLast()
            GridView2.Columns("Per_NO").View.Focus()

        Next

    End Sub

    Private Sub LoadBaseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBaseButton.Click
        AddRowB()
        Find_Row()
    End Sub




    Private Sub popDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popDel.Click
        If GridView2.RowCount = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView2.GetRowCellDisplayText(ArrayToString(GridView2.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("ProductionPiecePersonnelDayDelete").NewRow
            row("AutoID") = DelTemp

            ds.Tables("ProductionPiecePersonnelDayDelete").Rows.Add(row)
            ds.Tables("ProductionPiecePersonnelDay").Rows.RemoveAt(CInt(ArrayToString(GridView2.GetSelectedRows())))

        End If

    End Sub
    ''' <summary>
    ''' 保存已要導入的數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveNew()

        Dim i As Integer

        Dim pi As New ProductionPiecePersonnelDayInfo
        Dim pc As New ProductionPiecePersonnelDayControl

        pi.Per_Date = Per_DateEdit.Text
        pi.Per_Action = InUserID

        pi.DepID = lblDepID.Text
        pi.FacID = lblFacID.Text

        pi.G_NO = LblG_NO.Text

        TextNum.Text = Get_ProductionPiecePersonnelDayNO()

        If TextNum.Text = "" Then
            MsgBox("獲取流水號失敗,請檢查")
            Exit Sub
        End If

        pi.Per_Num = TextNum.Text.Trim

        For i = 0 To ds.Tables("ProductionPiecePersonnelDay").Rows.Count - 1

            pi.Per_NO = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_NO")
            pi.Per_Name = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_Name")


            If ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_PayType") Is DBNull.Value Then
                pi.Per_PayType = Nothing
            Else
                pi.Per_PayType = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_PayType")
            End If

            pi.Per_DayPrice = CDbl(ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_DayPrice"))

            If ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_Remark") Is DBNull.Value Then
                pi.Per_Remark = Nothing
            Else
                pi.Per_Remark = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_Remark")
            End If

            If pc.ProductionPiecePersonnelDay_Add(pi) = False Then
                MsgBox("數據保存失敗")
                Exit Sub
            End If
        Next

        MsgBox("數據保存成功")
        Me.Close()

    End Sub
    ''' <summary>
    ''' 數據修改
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveEdit()

        Dim i As Integer
        Dim pi As New ProductionPiecePersonnelDayInfo
        Dim pc As New ProductionPiecePersonnelDayControl

        pi.Per_Date = Per_DateEdit.Text
        pi.Per_Action = InUserID

        pi.DepID = lblDepID.Text
        pi.FacID = lblFacID.Text

        pi.G_NO = LblG_NO.Text

        If TextNum.Text = "" Then
            MsgBox("獲取流水號失敗,請檢查")
            Exit Sub
        End If

        pi.Per_Num = TextNum.Text.Trim

        For i = 0 To ds.Tables("ProductionPiecePersonnelDay").Rows.Count - 1

            pi.Per_NO = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_NO")
            pi.Per_Name = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_Name")


            If ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_PayType") Is DBNull.Value Then
                pi.Per_PayType = Nothing
            Else
                pi.Per_PayType = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_PayType")
            End If

            pi.Per_DayPrice = CDbl(ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_DayPrice"))

            If ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_Remark") Is DBNull.Value Then
                pi.Per_Remark = Nothing
            Else
                pi.Per_Remark = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_Remark")
            End If

            If ds.Tables("ProductionPiecePersonnelDay").Rows(i)("AutoID") Is DBNull.Value Then
                If pc.ProductionPiecePersonnelDay_Add(pi) = False Then
                    MsgBox("數據保存失敗")
                    Exit Sub
                End If
            Else
                pi.AutoID = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("AutoID")

                If pc.ProductionPiecePersonnelDay_Update(pi) = False Then
                    MsgBox("數據保存失敗")
                    Exit Sub
                End If
            End If

        Next


        Dim pcd As New ProductionPiecePersonnelDayControl

        Dim j As Integer
        If ds.Tables("ProductionPiecePersonnelDayDelete").Rows.Count > 0 Then 'AutoID
            For j = 0 To ds.Tables("ProductionPiecePersonnelDayDelete").Rows.Count - 1
                If ds.Tables("ProductionPiecePersonnelDayDelete").Rows(j)("AutoID") Is DBNull.Value Then
                Else
                    pcd.ProductionPiecePersonnelDay_Delete(ds.Tables("ProductionPiecePersonnelDayDelete").Rows(j)("AutoID"))
                End If
            Next
        End If


        MsgBox("數據保存成功")
        Me.Close()
    End Sub

    Function Get_ProductionPiecePersonnelDayNO() As String
        Get_ProductionPiecePersonnelDayNO = ""

        Dim Str1, Str2, Stra As String
        Dim gc1 As New ProductionPiecePersonnelDayControl
        Dim gi1 As New ProductionPiecePersonnelDayInfo

        Str1 = Format(Now, "yyMMdd")
        Str2 = lblDepID.Text

        Stra = Trim(Str1 + Str2)

        gi1 = gc1.ProductionPiecePersonnelDay_GetNO(Stra) '' 讀取基數

        If gi1 Is Nothing Then
            Get_ProductionPiecePersonnelDayNO = Stra & "0001"
        Else
            Get_ProductionPiecePersonnelDayNO = Stra & Mid((CInt(Microsoft.VisualBasic.Right(gi1.Per_Num, 4)) + 10001), 2)
        End If
    End Function


    Function LoadData() As Boolean
        Dim i As Integer

        On Error Resume Next   ''當時間格式出現錯誤 要注意
        ds.Tables("ProductionPiecePersonnelDay").Clear()


        Dim objInfo As New ProductionPiecePersonnelDayInfo
        Dim objList As New List(Of ProductionPiecePersonnelDayInfo)
        Dim oc As New ProductionPiecePersonnelDayControl
        objList = oc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, Nothing, Nothing, LblG_NO.Text, lblDepID.Text, lblFacID.Text, Nothing, Per_DateEdit.Text, Nothing, Nothing, Per_DateEdit.Text, Nothing)

        LoadData = False



        If objList.Count > 0 Then
        Else
            'MsgBox("沒有數據.")
            Exit Function
        End If

        lblDepID.Text = objList(0).DepID
        lblFacID.Text = objList(0).FacID

        TextNum.Text = objList(0).Per_Num

        For i = 0 To objList.Count - 1

            Dim row1 As DataRow = ds.Tables("ProductionPiecePersonnelDay").NewRow
            row1("AutoID") = objList(i).AutoID

            row1("Per_NO") = objList(i).Per_NO
            row1("Per_Name") = objList(i).Per_Name

            row1("Per_PayType") = objList(i).Per_PayType
            row1("Per_DayPrice") = objList(i).Per_DayPrice
            row1("Per_Remark") = objList(i).Per_Remark

            ds.Tables("ProductionPiecePersonnelDay").Rows.Add(row1)

            LoadData = True
        Next

        Find_Row()

    End Function


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If CheckData() = False Then Exit Sub

        If TextNum.Text <> "" Then
            SaveEdit() '修改
        Else
            SaveNew() '新增
        End If
    End Sub



    Private Sub RepositoryItemButtonEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemButtonEdit1.Click
        ''輸入了員工編號，從基本表中載入人員信息
        'Dim StrPer_NO As String
        'Dim row1 As Integer
        'Dim StrBZ As String

        'If GridView2.RowCount <= 0 Then
        '    Exit Sub
        'End If

        'row1 = CDbl(GridView2.FocusedRowHandle)
        'StrPer_NO = GridView2.GetFocusedRowCellValue("Per_NO").ToString
        'StrBZ = GridView2.GetFocusedRowCellValue("BZ").ToString

        'If StrPer_NO <> "" And StrBZ = "add" Then
        '    Load_Row(StrPer_NO, row1)
        'End If

    End Sub

    Private Sub popAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popAdd.Click
        Dim row1 As DataRow = ds.Tables("ProductionPiecePersonnelDay").NewRow
        row1("Per_PayType") = "計件"
        row1("Per_Remark") = ""
        row1("BZ") = "add"
        ds.Tables("ProductionPiecePersonnelDay").Rows.Add(row1)

        GridView2.MoveLast()
        GridView2.Columns("Per_NO").View.Focus()
    End Sub

    Function Load_Row(ByVal _Per_NO As String, ByVal _row As Integer) As String
        Dim i As Integer
        Load_Row = ""

        i = _row

        Dim objInfo As New ProductionPiecePersonnelInfo
        Dim objList As New List(Of ProductionPiecePersonnelInfo)
        Dim oc As New ProductionPiecePersonnelControl
        objList = oc.ProductionPiecePersonnel_GetList(Nothing, _Per_NO, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, False, Nothing, Nothing)


        If objList.Count > 0 Then
        Else
            'MsgBox("沒有數據.")
            Exit Function
        End If

        Dim Sign1 As String
        Sign1 = ""
        'MsgBox(ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_Name").ToString)

        If ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_Name") Is DBNull.Value Then
            Sign1 = "S"
        End If

        ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_Name") = objList(0).Per_Name
        ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_PayType") = objList(0).Per_PayType
        ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_DayPrice") = objList(0).Per_DayPrice
        
        If Sign1 <> "" Then
            GridView2.MoveFirst()
        End If


    End Function

    Private Function CheckData() As Boolean
        CheckData = True

        If lblDepID.Text = "" Then
            MsgBox("請選擇部門")
            CheckData = False
            Exit Function
        End If


        If Per_DateEdit.Text = "" Then
            MsgBox("員工信息建立時間不能為空")
            Per_DateEdit.Focus()
            CheckData = False
            Exit Function
        End If

        'If ds.Tables("ProductionPiecePersonnelDay").Rows.Count > 0 Then
        'Else
        '    MsgBox("請先載入數據")
        '    CheckData = False
        '    Exit Function
        'End If

        If ds.Tables("ProductionPiecePersonnelDay").Rows.Count > 0 Then  ''當無人員時，可全部刪除
        Else
            If TextNum.Text <> "" Then
                If MsgBox("無人員信息存在,是否繼續保存?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Exit Function
                Else
                    CheckData = False
                End If
                Exit Function
            Else
                MsgBox("請先載入數據")
                CheckData = False
                Exit Function
            End If
        End If

        Dim j As Integer
        ''判斷同一員同一組別不能兩條記錄
        For j = 0 To ds.Tables("ProductionPiecePersonnelDay").Rows.Count - 1


            If ds.Tables("ProductionPiecePersonnelDay").Rows(j)("Per_NO") Is DBNull.Value Then
                GridView2.FocusedRowHandle = j '移、至錯誤碼行
                MsgBox("員工編號不能為空")
                CheckData = False
                Exit Function
            End If

            If ds.Tables("ProductionPiecePersonnelDay").Rows(j)("Per_Name") Is DBNull.Value Then
                GridView2.FocusedRowHandle = j '移、至錯誤碼行
                MsgBox("員工姓名不能為空")
                CheckData = False
                Exit Function
            End If



            If ds.Tables("ProductionPiecePersonnelDay").Rows(j)("AutoID") Is DBNull.Value Then  ''若AutoID 存在
                ''判斷一下當天的名單-同一組
                Dim StrG_NO As String
                Dim StrPer_NO As String

                StrG_NO = LblG_NO.Text
                StrPer_NO = ds.Tables("ProductionPiecePersonnelDay").Rows(j)("Per_NO")

                Dim plist As List(Of ProductionPiecePersonnelDayInfo)
                Dim pc As New ProductionPiecePersonnelDayControl
                plist = pc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, StrPer_NO, Nothing, StrG_NO, lblDepID.Text, lblFacID.Text, Nothing, Per_DateEdit.Text, Nothing, "False", Per_DateEdit.EditValue, Nothing)

                If plist.Count > 0 Then
                    GridView2.FocusedRowHandle = j '移、至錯誤碼行
                    MsgBox("編號為:" & StrPer_NO & "的員工已加入本組，請檢查.")
                    CheckData = False
                    Exit Function
                End If
            End If
        Next
        ''----------------------------------------------------------------------------------

        Dim i1, j1 As Integer

        For j1 = 0 To ds.Tables("ProductionPiecePersonnelDay").Rows.Count - 1
            For i1 = j1 + 1 To ds.Tables("ProductionPiecePersonnelDay").Rows.Count - 1
                If ds.Tables("ProductionPiecePersonnelDay").Rows(i1)("Per_NO") = ds.Tables("ProductionPiecePersonnelDay").Rows(j1)("Per_NO") Then
                    GridView2.FocusedRowHandle = j1 '移、至錯誤碼行
                    MsgBox("員工編號為:" & ds.Tables("ProductionPiecePersonnelDay").Rows(i1)("Per_NO") & "已加入，請檢查.")
                    CheckData = False
                    Exit Function
                End If
            Next
        Next

    End Function



    ''用於顯示指定日期，指定員工是否存在多個組
    Private Sub GridView2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.Click
        Dim StrA, StrB As String

        If GridView2.RowCount <= 0 Then
            Exit Sub
        End If

        If GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Msg") Is DBNull.Value Then Exit Sub
        If GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Per_Name") Is DBNull.Value Then Exit Sub

        StrA = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Msg")
        StrB = GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Per_Name")

        If StrA <> "" Then
            ToolTipController1.ShowHint(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Msg"), StrB & vbCrLf & Per_DateEdit.EditValue & "存在於以下組別:")
        Else
            ToolTipController1.ShowHint(GridView2.GetRowCellValue(GridView2.FocusedRowHandle, "Msg"), Nothing)
        End If

    End Sub

    Private Sub GridView2_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GridView2.CustomDrawCell
        If GridView2.RowCount <= 0 Then
            Exit Sub
        End If

        Dim strTemp As String
        strTemp = GridView2.GetRowCellValue(e.RowHandle, "Msg").ToString().Trim()
        If strTemp <> "" Then
            e.Appearance.ForeColor = Color.Red
        End If

    End Sub

    ''查詢每一列，當天是否存在其它 組別中。
    ''若有則 本行字段顯示為紅色  
    'ToolTipController1 得用顯示藞的其它 組別名

    Function Find_Row() As String
        Dim i, j As Integer
        Find_Row = ""
        Dim _Per_NO As String
        Dim StrMsg As String

        '  MsgBox(ds.Tables("ProductionPiecePersonnelDay").Rows.Count)

        If ds.Tables("ProductionPiecePersonnelDay").Rows.Count <= 0 Then Exit Function

        For i = 0 To ds.Tables("ProductionPiecePersonnelDay").Rows.Count - 1
            StrMsg = ""

            Dim objInfo As New ProductionPiecePersonnelDayInfo
            Dim objList As New List(Of ProductionPiecePersonnelDayInfo)
            Dim oc As New ProductionPiecePersonnelDayControl


            If ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_NO") Is DBNull.Value Then Exit For

            _Per_NO = ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Per_NO")

            objList = oc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, _Per_NO, Nothing, Nothing, lblDepID.Text, lblFacID.Text, Nothing, Per_DateEdit.EditValue, Nothing, False, Per_DateEdit.EditValue, Nothing)

            If ds.Tables("ProductionPiecePersonnelDay").Rows(i)("AutoID") Is DBNull.Value Then
                If objList.Count > 0 Then
                Else
                    GoTo AAA
                End If
            Else
                If objList.Count > 1 Then
                Else
                    GoTo AAA
                End If
            End If

            For j = 0 To objList.Count - 1
                StrMsg = StrMsg & "編號:" & objList(j).G_NO & "名稱:" & objList(j).Per_G_Name & vbCrLf
            Next

            ds.Tables("ProductionPiecePersonnelDay").Rows(i)("Msg") = StrMsg
AAA:


        Next

    End Function

    'Private Sub RepositoryItemButtonEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RepositoryItemButtonEdit1.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        RepositoryItemButtonEdit1_Click(Nothing, Nothing)
    '        GridView2.FocusedRowHandle = 0
    '    End If
    'End Sub


    Private Sub GridView2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView2.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    RepositoryItemButtonEdit1_Click(Nothing, Nothing)
        'End If
    End Sub

    Private Sub Per_DateEdit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Per_DateEdit.EditValueChanged
        If Per_DateEdit.EditValue Is Nothing Then Exit Sub
        LoadData()
    End Sub

    Private Sub Per_DateEdit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Per_DateEdit.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Per_DateEdit.EditValue Is Nothing Then Exit Sub
            LoadData()
        End If
    End Sub

    Private Sub Grid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid1.Click

    End Sub

    Private Sub RepositoryItemButtonEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RepositoryItemButtonEdit1.KeyDown

        '輸入了員工編號，從基本表中載入人員信息
        If e.KeyCode = Keys.Enter Then
            Dim StrPer_NO As String
            Dim row1 As Integer
            Dim StrBZ As String

            If GridView2.RowCount <= 0 Then
                Exit Sub
            End If

            row1 = CDbl(GridView2.FocusedRowHandle)
            StrPer_NO = sender.EditValue
            StrBZ = GridView2.GetFocusedRowCellValue("BZ").ToString

            If StrPer_NO <> "" And StrBZ = "add" Then
                Load_Row(StrPer_NO, row1)
            End If
        End If
    End Sub
End Class
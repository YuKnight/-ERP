Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionPieceWorkGroup

Public Class ProductionPiecePersonnel
    Dim ds As New DataSet

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub ProductionPiecePersonnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LabAutoID.Text = tempValue2
        CaoTypeLabel.Text = MTypeName

        MTypeName = Nothing
        tempValue2 = Nothing

        Dim pc1 As New ProductionPieceWorkGroupControl
        txtDepID.Properties.DataSource = pc1.DepFac_GetList1(strInDepID, Nothing, Nothing, Nothing)
        txtDepID.Properties.DisplayMember = "UserDep_Fac"
        txtDepID.Properties.ValueMember = "DepID"

        TxtPer_NO.Properties.ReadOnly = False

        CreateTable()
        AddRow()

        Select Case CaoTypeLabel.Text
            Case "PerAdd"
                Me.Text = "員工名單-增加"
                LabCaption.Text = "員工名單-增加"
            Case "PerEdit"
                If LoadData(LabAutoID.Text) = False Then Exit Sub
                Me.Text = "員工名單-修改" & "[" & LabAutoID.Text & "]"
                LabCaption.Text = "員工名單-修改"
                cmdAdd.Visible = False
                TxtPer_NO.Enabled = False
                TxtPer_NO.Properties.ReadOnly = True

            Case "PerView"
                If LoadData(LabAutoID.Text) = False Then Exit Sub
                '查看
                luePer_PayType.Enabled = False
                cmdSave.Visible = False
                cmdAdd.Visible = False
                GluG_NO.Enabled = False
                TxtPer_NO.Enabled = False
                txtDepID.Enabled = False
                TxtPer_Name.Enabled = False
                txtPer_DayPrice.Enabled = False
                MemoPer_Remark.Enabled = False
                cboPer_Class.Enabled = False

                Me.Text = "員工名單-查看" & "[" & LabAutoID.Text & "]"
                LabCaption.Text = "員工名單-查看"
        End Select

        PowerUser()

    End Sub

    Sub PowerUser()
        Dim pmws As New LFERP.SystemManager.PermissionModuleWarrantSubController
        Dim pmwiL As List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)

        txtPer_DayPrice.Enabled = True

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160306")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
            Else
                txtPer_DayPrice.Properties.PasswordChar = "*"
                txtPer_DayPrice.Enabled = False
            End If
        End If

    End Sub


    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("Type")
            .Columns.Add("Per_PayType")
            .Columns.Add("Remark")
        End With
        luePer_PayType.Properties.DataSource = ds.Tables("Type")
        luePer_PayType.Properties.DisplayMember = "Per_PayType"
        luePer_PayType.Properties.ValueMember = "Per_PayType"


        ''增加無組別員工，進行個人計件的2012-5-8

        With ds.Tables.Add("G_NOName")
            .Columns.Add("G_NO")
            .Columns.Add("G_Name")
        End With
        GluG_NO.Properties.DisplayMember = "G_Name"
        GluG_NO.Properties.ValueMember = "G_NO"
        GluG_NO.Properties.DataSource = ds.Tables("G_NOName")

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

    ''' <summary>
    ''' 載入數據
    ''' </summary>
    ''' <param name="Str_AutoID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LoadData(ByVal Str_AutoID As String) As Boolean
        LoadData = False

        Dim objInfo As New ProductionPiecePersonnelInfo
        Dim objList As New List(Of ProductionPiecePersonnelInfo)
        Dim oc As New ProductionPiecePersonnelControl

        objList = oc.ProductionPiecePersonnel_GetList(Str_AutoID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If objList.Count <= 0 Then
            MsgBox("沒有數據！")
            LoadData = False
            Exit Function
        Else

            txtFacID.Text = objList(0).FacID

            luePer_PayType.Text = objList(0).Per_PayType  ''薪金類型
            TxtPer_NO.Text = objList(0).Per_NO '員工編號
            TxtPer_Name.Text = objList(0).Per_Name '員工姓名


            txtPer_DayPrice.Text = objList(0).Per_DayPrice '  /日薪         
            MemoPer_Remark.Text = objList(0).Per_Remark '     /備注

            txtDepID.EditValue = objList(0).DepID
            GluG_NO.EditValue = objList(0).G_NO  ''組別名
            cboPer_Class.Text = objList(0).Per_Class  '班制

            LoadData = True
        End If

    End Function

    ''' <summary>
    ''' 檢查數據輸入正確
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckData() As Boolean
        CheckData = True

        If txtDepID.EditValue = "" Then
            MsgBox("請選擇部門")
            txtDepID.Select()
            CheckData = False
            Exit Function
        End If

        If TxtPer_NO.Text = "" Then
            MsgBox("員工編號不能為空")
            TxtPer_NO.Focus()
            CheckData = False
            Exit Function   '
        End If

        If TxtPer_Name.Text = "" Then
            MsgBox("員工姓名不能為空")
            TxtPer_Name.Focus()
            CheckData = False
            Exit Function
        End If

        If GluG_NO.EditValue = "" Then
            MsgBox("員工組別信息不能空")
            GluG_NO.Focus()
            CheckData = False
            Exit Function
        End If

        If cboPer_Class.Text = "" Then
            MsgBox("班制信息不能空")
            cboPer_Class.Focus()
            CheckData = False
            Exit Function
        End If

        If luePer_PayType.Text = "" Then
            MsgBox("薪金類型輸入有誤")
            luePer_PayType.Focus()
            CheckData = False
            Exit Function
        End If


        ''如果不是計件時，一定要輸入薪金類型 2012-9-4

        If luePer_PayType.EditValue <> "計件" Then
            If Val(txtPer_DayPrice.Text) <= 0 Then
                MsgBox("請輸入日薪！")
                luePer_PayType.Focus()
                CheckData = False
                Exit Function
            End If
        End If



        ''加判斷此人只在人員表中只存在一條記錄  2012-6-5
        If CaoTypeLabel.Text = "PerEdit" Then ''修改時不判斷，但不能修改編號
        Else
            Dim objL As New List(Of ProductionPiecePersonnelInfo)
            Dim objc As New ProductionPiecePersonnelControl

            objL = objc.ProductionPiecePersonnel_GetList(Nothing, TxtPer_NO.Text.Trim, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            If objL.Count > 0 Then
                MsgBox("此員工編號已存在,請檢查!")
                TxtPer_NO.Focus()
                CheckData = False
                Exit Function
            End If
        End If


    End Function
    ''' <summary>
    ''' 數據增加
    ''' </summary>
    ''' <param name="S_model"></param>
    ''' <remarks></remarks>
    Private Sub SaveNew(ByVal S_model As String)
        Dim gc As New ProductionPiecePersonnelControl
        Dim gi As New ProductionPiecePersonnelInfo

        gi.Per_PayType = luePer_PayType.Text  ''薪 金 類別

        gi.DepID = txtDepID.EditValue  ''部門編號
        gi.FacID = txtFacID.Text  '廠別

        gi.Per_NO = TxtPer_NO.Text.Trim '員工工號
        gi.Per_Name = TxtPer_Name.Text.Trim '/員工名稱
        gi.G_NO = GluG_NO.EditValue '組別組別編號
        gi.Per_DayPrice = Val(txtPer_DayPrice.Text) '日薪
        gi.Per_Remark = MemoPer_Remark.Text '備注
        gi.Per_Action = InUserID
        gi.Per_Date = Format(Now, "yyyy/MM/dd")
        gi.Per_Class = cboPer_Class.Text

        If S_model = "S" Then
            If gc.ProductionPiecePersonnel_Add(gi) = True Then
                MsgBox("數據保存成功")
                Me.Close()
            End If
        Else
            If gc.ProductionPiecePersonnel_Add(gi) = False Then
                MsgBox("數據保存失敗")
                Me.Close()
            End If
        End If
    End Sub

    ''' <summary>
    ''' 修改數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SaveEdit()
        Dim gc As New ProductionPiecePersonnelControl
        Dim gi As New ProductionPiecePersonnelInfo

        gi.AutoID = LabAutoID.Text.Trim

        gi.Per_PayType = luePer_PayType.Text ''薪 金 類別

        gi.DepID = txtDepID.EditValue  ''部門編號
        gi.FacID = txtFacID.Text

        gi.Per_NO = TxtPer_NO.Text.Trim
        gi.Per_Name = TxtPer_Name.Text.Trim
        gi.G_NO = GluG_NO.EditValue '組別
        gi.Per_DayPrice = Val(txtPer_DayPrice.Text)
        gi.Per_Remark = MemoPer_Remark.Text
        gi.Per_Class = cboPer_Class.Text

        gi.Per_Action = InUserID
        gi.Per_Date = Format(Now, "yyyy/MM/dd")

        If gc.ProductionPiecePersonnel_Update(gi) = True Then
            MsgBox("數據保存成功")
            Me.Close()
        End If
    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckData() = False Then Exit Sub

        If CaoTypeLabel.Text = "PerAdd" Then '
            Call SaveNew("A")
            'Dim i%
            'For i = 1 To 6
            '    GroupBox1.Controls.Item(i).Text = ""
            'Next


            TxtPer_NO.Text = ""
            TxtPer_Name.Text = ""


            TxtPer_NO.Select()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckData() = False Then Exit Sub

        Select Case CaoTypeLabel.Text
            Case "PerAdd"
                Call SaveNew("S")
            Case "PerEdit"
                Call SaveEdit()
        End Select
    End Sub

    Private Sub txtDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepID.EditValueChanged
        If txtDepID.EditValue <> "" Then
        Else
            Exit Sub
        End If

        Dim pc1 As New ProductionPieceWorkGroupControl
        Dim piList As New List(Of ProductionPieceWorkGroupInfo)

        piList = pc1.DepFac_GetList1(txtDepID.EditValue, Nothing, Nothing, Nothing)

        If piList.Count <= 0 Then Exit Sub

        txtFacID.Text = piList(0).FacID '查詢出廠別

        'GluG_NO.Properties.DisplayMember = "G_Name"
        'GluG_NO.Properties.ValueMember = "G_NO"
        'GluG_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, txtDepID.EditValue, Nothing, Nothing, Nothing, Nothing)

        Dim pc As New ProductionPieceWorkGroupControl
        Dim pcL As List(Of ProductionPieceWorkGroupInfo)

        ds.Tables("G_NOName").Clear()

        Dim row1 As DataRow
        row1 = ds.Tables("G_NOName").NewRow
        row1("G_NO") = "無"
        row1("G_Name") = "無"
        ds.Tables("G_NOName").Rows.Add(row1)
        pcL = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, txtDepID.EditValue, txtFacID.Text, Nothing, Nothing, Nothing)
        If pcL.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To pcL.Count - 1
                Dim row As DataRow
                row = ds.Tables("G_NOName").NewRow
                row("G_NO") = pcL(i).G_NO
                row("G_Name") = pcL(i).G_Name
                ds.Tables("G_NOName").Rows.Add(row)
            Next
        End If

    End Sub

    Private Sub txtDepID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDepID.KeyDown, GluG_NO.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub

    Private Sub TxtPer_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPer_NO.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPer_Name.Text = GetName(TxtPer_NO.Text.Trim)
            ' luePer_PayType.EditValue = strPayType
            'txtDepID.EditValue = strDepID
            'MsgBox(strDepID)
            If TxtPer_Name.Text <> "" Then
                luePer_PayType.Focus()
                'txtDepID.Focus()
                'txtDepID.ShowPopup()
            End If

        End If
    End Sub


    Private Sub txtPer_DayPrice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPer_DayPrice.KeyUp
        Dim m As New System.Text.RegularExpressions.Regex("^+?(\d+(\.\d*)?|\.\d+)$")  '顯示整數,正浮點數正則表達式

        If m.IsMatch(txtPer_DayPrice.Text) = True Then
        Else
            txtPer_DayPrice.Text = Nothing
            Exit Sub
        End If
    End Sub
End Class
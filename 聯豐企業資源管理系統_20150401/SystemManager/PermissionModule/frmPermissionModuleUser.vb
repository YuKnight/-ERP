Imports LFERP.SystemManager
Imports DevExpress.XtraEditors.Repository
Imports LFERP.DataSetting

Public Class frmPermissionModuleUser

    Dim mt As New LFERP.SystemManager.PermissionController
    Dim dc As New DepartmentControler

    Private gridEditors As GridEditorCollection

    Private Sub frmPermissionModuleUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Griduser.DataSource = uls.SystemUser_GetList(Nothing, Nothing, Nothing)

        'GridControl2.DataSource = uls.SystemUser_GetList(Nothing, Nothing, Nothing)
        TreeList2.DataSource = dc.Department_GetList(Nothing, Nothing, Nothing)
        TreeList2.Nodes(0).Expanded = True

        If strInCompany = "1001" Then
            TreeList2.Nodes(0).Nodes(0).ExpandAll()
        ElseIf strInCompany = "1002" Then
            TreeList2.Nodes(0).Nodes(1).ExpandAll()
        Else
            TreeList2.Nodes(0).Nodes(2).ExpandAll()
        End If
        'TreeList2.ExpandAll()

    End Sub

    Sub CreateTables()
        '子物料數據
        ds.Tables.Clear()
        '創建數據表
        With ds.Tables.Add("PermissionModuleUser")
            .Columns.Add("PM_ID", GetType(String))
            .Columns.Add("PM_Name", GetType(String))
            .Columns.Add("PM_PID", GetType(String))
            .Columns.Add("PM_Level", GetType(Integer))
            .Columns.Add("PM_Sub", GetType(Boolean))
            .Columns.Add("PM_Image", GetType(Integer))
            .Columns.Add("PM_SelectImage", GetType(Integer))
            .Columns.Add("PMU_Value", GetType(Boolean))
            .Columns.Add("U_ID", GetType(String))
        End With
        '綁定表格

        LoadPermissionModule(mt.PermissionModule_GetList(Nothing, Nothing, Nothing))

        TreeList1.DataSource = ds.Tables("PermissionModuleUser")

    End Sub
    Sub LoadPermissionModule(ByVal objInfo As List(Of PermissionInfo))
        If objInfo Is Nothing Then Exit Sub
        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To objInfo.Count - 1
            row = ds.Tables("PermissionModuleUser").NewRow
            row("PM_ID") = objInfo(i).PM_ID
            row("PM_Name") = objInfo(i).PM_Name
            row("PM_PID") = objInfo(i).PM_PID
            row("PM_Level") = objInfo(i).PM_Level
            row("PM_Sub") = objInfo(i).PM_Sub
            row("PM_Image") = objInfo(i).PM_Image
            row("PM_SelectImage") = objInfo(i).PM_SelectImage
            row("PMU_Value") = False
            ds.Tables("PermissionModuleUser").Rows.Add(row)
        Next
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        On Error Resume Next
        Dim i As Integer
        For i = 0 To ds.Tables("PermissionModuleUser").Rows.Count - 1
            ds.Tables("PermissionModuleUser").Rows(i)("PMU_Value") = True
        Next

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        On Error Resume Next
        Dim i As Integer
        For i = 0 To ds.Tables("PermissionModuleUser").Rows.Count - 1
            ds.Tables("PermissionModuleUser").Rows(i)("PMU_Value") = False
        Next
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error Resume Next
        Dim i As Integer
        For i = 0 To ds.Tables("PermissionModuleUser").Rows.Count - 1
            'ds.Tables("PermissionModuleUser").Rows(i)("PMU_Value") = False
            ' mt.PermissionModuleUser_Update()
            Dim ms As New PermissionInfo
            ms.PM_ID = ds.Tables("PermissionModuleUser").Rows(i)("PM_ID")
            ms.PM_Name = ds.Tables("PermissionModuleUser").Rows(i)("PM_Name")
            ms.PM_PID = ds.Tables("PermissionModuleUser").Rows(i)("PM_PID")
            ms.PM_Level = ds.Tables("PermissionModuleUser").Rows(i)("PM_Level")
            ms.PM_Sub = ds.Tables("PermissionModuleUser").Rows(i)("PM_Sub")
            ms.PM_Image = ds.Tables("PermissionModuleUser").Rows(i)("PM_Image")
            ms.PM_SelectImage = ds.Tables("PermissionModuleUser").Rows(i)("PM_SelectImage")
            ms.U_ID = ds.Tables("PermissionModuleUser").Rows(i)("U_ID")
            ms.PMU_Value = ds.Tables("PermissionModuleUser").Rows(i)("PMU_Value")
            mt.PermissionModuleUser_Update(ms, GridView2.GetFocusedRowCellValue("U_ID").ToString)

        Next
        MsgBox("保存完成")

    End Sub

    Function GetValue(ByVal U_ID As String, ByVal PM_ID As String) As Boolean
        '檢查選擇用戶的權限
        Try
            Dim objInfo As New PermissionInfo
            objInfo = mt.PermissionModuleUser_Get(PM_ID, U_ID)
            If objInfo Is Nothing Then
                GetValue = False
            Else
                GetValue = objInfo.PMU_Value
            End If
        Catch ex As Exception
            GetValue = False
        End Try

    End Function

    Sub CheckValue()
        'On Error Resume Next
        Dim i As Integer
        For i = 0 To ds.Tables("PermissionModuleUser").Rows.Count - 1
            ds.Tables("PermissionModuleUser").Rows(i)("PMU_Value") = GetValue(GridView2.GetFocusedRowCellValue("U_ID").ToString, ds.Tables("PermissionModuleUser").Rows(i)("PM_ID"))
        Next

    End Sub

    Private Sub GridControl2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl2.Click
        If GridView2.RowCount = 0 Then
            Exit Sub
        End If
        CreateTables()
        TreeList1.ExpandAll()
        CheckValue()
    End Sub

    'Private Sub Griduser_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    CreateTables()
    '    TreeList1.ExpandAll()
    '    CheckValue()

    'End Sub

    Private Sub InitInplaceEditors()
        'Me.gridEditors.Add(Me.repositoryItemTextEdit, "Text Edit", "The simplest Edit")
        'Me.gridEditors.Add(Me.repositoryItemButtonEdit, "Button Edit", "Click me...")
        'Me.gridEditors.Add(Me.repositoryItemCheckEdit, "Check Edit", False)
        'Me.gridEditors.Add(Me.repositoryItemSpinEdit, "Spin Edit", 20)
        'Me.gridEditors.Add(Me.repositoryItemDateEdit, "Date Edit", System.DateTime.Now)
        'Me.gridEditors.Add(Me.repositoryItemTimeEdit, "Time Edit", System.DateTime.Now)
        'Me.gridEditors.Add(Me.repositoryItemLookUpEdit, "Lookup Edit", 3)
        'Me.gridEditors.Add(Me.repositoryItemPopupContainerEdit, "Popup Container", 3)
        'Me.gridEditors.Add(Me.repositoryItemProgressBar, "Progress Bar", 30)
        'Me.gridEditors.Add(Me.repositoryItemComboBox, "ComboBox", "United States")
        'Me.gridEditors.Add(Me.repositoryItemImageComboBox, "ImageComboBox", 2)
        'Me.gridEditors.Add(Me.repositoryItemMRUEdit, "MRU Edit", "What's your favorite color?")
        'Me.gridEditors.Add(Me.repositoryItemPictureEdit, "Picture", Me.pictureBox1.Image)
        'Me.gridEditors.Add(Me.repositoryItemMemoEdit, "Memo Edit", "Robbins studied drama at UCLA where he graduated with honors in 1981. That same year, he formed the Actors' Gang, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater.")
        'Me.gridEditors.Add(Me.repositoryItemImageEdit, "Image Edit", Me.pictureBox1.Image)
        'Me.gridEditors.Add(Me.repositoryItemMemoExEdit, "MemoEx Edit", "Robbins studied drama at UCLA where he graduated with honors in 1981. That same year, he formed the Actors' Gang, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater.")
        'Me.gridEditors.Add(Me.repositoryItemRadioGroup, "Radio Group", 1)
        'Me.gridEditors.Add(Me.repositoryItemHyperLinkEdit, "Hyper link", "http://www.devexpress.com")
        'Me.gridEditors.Add(Me.repositoryItemCalcEdit, "Calculator", 100.25)
        'Me.gridEditors.Add(Me.repositoryItemColorEdit, "Color Edit", System.Drawing.Color.Blue)
        'Me.gridEditors.Add(Me.RepositoryItemTrackBar1, "Track Bar", 4)
    End Sub

    Private Sub gridView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1.Click
        Dim pmsc As New PermissionModuleSubController
        Dim pmsiL As New List(Of PermissionModuleSubInfo)

        pmsiL = pmsc.PermissionModuleSub_GetList(Nothing, gridView1.GetFocusedRowCellDisplayText("ID"))
        If gridView1.RowCount > 0 Then
            MemoEdit1.Text = pmsiL.Item(0).PMS_Remark
        Else
            MsgBox("項目沒有數據或此項目未設置子權限！")
        End If

    End Sub
    Private Sub gridView1_CustomRowCellEdit(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs) Handles gridView1.CustomRowCellEdit
        If e.Column Is Me.gridEditorValue Then
            Dim item As GridEditorItem = Nothing
            If TypeOf gridView1.GetRow(e.RowHandle) Is GridEditorItem Then item = CType(gridView1.GetRow(e.RowHandle), GridEditorItem)
            If Not item Is Nothing Then
                e.RepositoryItem = item.RepositoryItem
            End If
        End If
    End Sub
    Private Sub repositoryItemButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repositoryItemButtonEdit.ButtonClick
        'System.Windows.Forms.MessageBox.Show("You've clicked the button!", Application.ProductName)
        'On Error Resume Next
        'tempValue = ds.Tables("Purchase").Rows(gridView1.FocusedRowHandle)("M_Code").ToString
        'tempValue2 = gluSupplier.EditValue
        'FrmQuotationSelect.ShowDialog()
        'If Len(FrmQuotationSelect.SelectQuoID) <> 0 Then
        '    ds.Tables("Purchase").Rows(gridView1.FocusedRowHandle)("Q_QuoID") = FrmQuotationSelect.SelectQuoID
        'End If
        'If Len(FrmQuotationSelect.SelectSupplierNo) <> 0 Then
        '    ds.Tables("Purchase").Rows(gridView1.FocusedRowHandle)("S_SupplierNo") = FrmQuotationSelect.SelectSupplierNo
        'End If
        'If FrmQuotationSelect.SelectPrice <> 0 Then
        '    ds.Tables("Purchase").Rows(gridView1.FocusedRowHandle)("PS_Price") = FrmQuotationSelect.SelectPrice
        'End If
        tempValue = gridView1.GetFocusedRowCellDisplayText("Name")
        tempValue2 = gridView1.GetFocusedRowCellDisplayText("ID")
        tempValue3 = gridView1.GetFocusedRowCellDisplayText("Value")
        Dim myfrm As New FrmPermissionModuleUserSelect
        myfrm.ShowDialog()
        gridView1.SetFocusedRowCellValue(gridView1.Columns.Item("Value"), tempValue3)

        tempValue = ""
        tempValue2 = ""
        tempValue3 = ""
    End Sub

    Public Sub New()

        ' 此為 Windows Form 設計工具所需的呼叫。
        InitializeComponent()

        ' 在 InitializeComponent() 呼叫之後加入任何初始設定。
        'InitLookupDataTable()
        Me.gridEditors = New GridEditorCollection()
        InitInplaceEditors()
        Me.gridControl1.DataSource = gridEditors

    End Sub
    'Private Sub gridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridView1.FocusedRowChanged
    '    Dim pmsc As New PermissionModuleSubController
    '    Dim pmsiL As New List(Of PermissionModuleSubInfo)

    '    pmsiL = pmsc.PermissionModuleSub_GetList(Nothing, gridView1.GetFocusedRowCellDisplayText("ID"))
    '    Label1.Text = gridView1.GetFocusedRowCellDisplayText("ID")
    '    MemoEdit1.Text = pmsiL.Item(0).PMS_Remark
    'End Sub

    Private Sub cmdSaveSub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaveSub.Click
        'Me.gridEditors.Add(Me.repositoryItemCheckEdit, "1001", "新增", "新增軟件", False)
        'Me.gridEditors.Add(Me.repositoryItemCheckEdit, "1002", "修改", "修改軟件", False)
        'Me.gridEditors.Add(Me.repositoryItemCheckEdit, "1003", "刪除", "刪除軟件", False)
        'Me.gridEditors.Add(Me.repositoryItemButtonEdit, "1004", "選擇倉庫", "選擇軟件", "Click me...")
        'Me.gridEditors.Add(Me.repositoryItemComboBox, "1005", "項目", "管理軟件", "United States")



        'LoadSystemPermissionModuleSub("1002", "布爾", "新的測試", "測試", "真")

        'LoadSystemPermissionModuleSub("1002", "單項選擇", "新的測試", "測試", "沒有")

        'gridView1.RefreshData()

        Dim i As Integer
        For i = 0 To gridView1.RowCount - 1
            Dim pwsc As New PermissionModuleWarrantSubController
            Dim pwsiL As New List(Of PermissionModuleWarrantSubInfo)
            Dim pwsi As New PermissionModuleWarrantSubInfo

            Dim strA, strB As String

            strA = GridView2.GetFocusedRowCellValue("U_ID").ToString
            strB = gridView1.GetRowCellValue(i, "ID")
            pwsiL = pwsc.PermissionModuleWarrantSub_GetList(strA, strB)

            If pwsiL.Count = 0 Then
                '原來此用戶權限表沒此權限,新增
                pwsi.U_ID = strA
                pwsi.PMS_ID = strB
                Select Case gridView1.GetRowCellValue(i, "Value").ToString
                    Case "True"
                        pwsi.PMWS_Value = "是"
                    Case "False"
                        pwsi.PMWS_Value = "否"
                    Case Else
                        pwsi.PMWS_Value = gridView1.GetRowCellValue(i, "Value").ToString
                End Select
                'If gridView1.GetRowCellValue(i, "Value").ToString = "True" Then
                '    pwsi.PMWS_Value = "是"
                'End If
                'If gridView1.GetRowCellValue(i, "Value").ToString = "False" Then
                '    pwsi.PMWS_Value = "否"
                'End If


                pwsc.PermissionModuleWarrantSub_Add(pwsi)

            End If


            If pwsiL.Count > 0 Then
                '原來此用戶權限表有此權限,修改
                pwsi.U_ID = strA
                pwsi.PMS_ID = strB

                Select Case gridView1.GetRowCellValue(i, "Value").ToString
                    Case "True"
                        pwsi.PMWS_Value = "是"
                    Case "False"
                        pwsi.PMWS_Value = "否"
                    Case Else
                        pwsi.PMWS_Value = gridView1.GetRowCellValue(i, "Value").ToString
                End Select
                'If gridView1.GetRowCellValue(i, "Value").ToString = "True" Then
                '    pwsi.PMWS_Value = "是"
                'End If
                'If gridView1.GetRowCellValue(i, "Value").ToString = "False" Then
                '    pwsi.PMWS_Value = "否"
                'End If
                pwsc.PermissionModuleWarrantSub_Update(pwsi)
            End If
        Next
        MsgBox("已保存此模塊用戶權限")
    End Sub


    ''' <summary>
    ''' 導入系統選定模塊列表
    ''' </summary>
    ''' <param name="PMS_ID"></param>
    ''' <param name="PMS_Type"></param>
    ''' <param name="PMS_Name"></param>
    ''' <param name="PMS_Remark"></param>
    ''' <param name="PMS_Valuse"></param>
    ''' <remarks></remarks>
    Sub LoadSystemPermissionModuleSub(ByVal PMS_ID As String, ByVal PMS_Type As String, ByVal PMS_Name As String, ByVal PMS_Remark As String, ByVal PMS_Valuse As String)
        Dim rti As New RepositoryItem
        Select Case PMS_Type
            Case "布爾"
                rti = Me.repositoryItemCheckEdit
                If PMS_Valuse = "真" Then
                    Me.gridEditors.Add(rti, PMS_ID, PMS_Name, PMS_Remark, True)
                Else
                    Me.gridEditors.Add(rti, PMS_ID, PMS_Name, PMS_Remark, False)
                End If
            Case "文字"
                rti = Me.repositoryItemTextEdit
                Me.gridEditors.Add(rti, PMS_ID, PMS_Name, PMS_Remark, PMS_Valuse)
            Case "單項選擇"
                rti = Me.repositoryItemButtonEdit
                Me.gridEditors.Add(rti, PMS_ID, PMS_Name, PMS_Remark, PMS_Valuse)
            Case "多項選擇"
                rti = Me.repositoryItemButtonEdit
                Me.gridEditors.Add(rti, PMS_ID, PMS_Name, PMS_Remark, PMS_Valuse)
        End Select


    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        On Error GoTo A
        Dim i, n As Integer

        If gridView1.RowCount <> 0 Then
            For n = 0 To gridView1.RowCount - 1
                gridView1.DeleteRow(0)
            Next
        End If

        '從PermissionModuleSub載入到Gridview1
        Dim pmc As New PermissionModuleSubController
        Dim pmiL As New List(Of PermissionModuleSubInfo)

        pmiL = pmc.PermissionModuleSub_GetList(TreeList1.FocusedNode.Item("PM_ID").ToString(), Nothing)

        For i = 0 To pmiL.Count - 1
            Dim strA, strB, strC, strD, strE As String
            strA = pmiL.Item(i).PMS_ID
            strB = pmiL.Item(i).PMS_Type
            strC = pmiL.Item(i).PMS_Name
            strD = pmiL.Item(i).PMS_Value
            strE = pmiL.Item(i).PMS_Value
            LoadSystemPermissionModuleSub(strA, strB, strC, strD, strE)
        Next



        ''從PermissionModuleWarrantSub載入相應用戶的權限
        For n = 0 To gridView1.RowCount - 1
            Dim pmwc As New PermissionModuleWarrantSubController
            Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)
            pmwiL = pmwc.PermissionModuleWarrantSub_GetList(GridView2.GetFocusedRowCellValue("U_ID").ToString, gridView1.GetRowCellValue(n, "ID").ToString)

            Select Case pmwiL.Item(0).PMWS_Value
                Case "是"
                    gridView1.SetRowCellValue(n, "Value", True)

                Case "否"
                    gridView1.SetRowCellValue(n, "Value", False)

                Case Else
                    gridView1.SetRowCellValue(n, "Value", pmwiL.Item(0).PMWS_Value)

            End Select
        Next
A:      gridView1.RefreshData()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        TreeList1.Width = TreeList1.Width + 1
    End Sub

    Private Sub cmdCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click

        tempValue4 = GridView2.GetFocusedRowCellValue("U_ID").ToString

        frmPermissionModuleUserCopy.ShowDialog()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        On Error Resume Next
        Dim n As Integer
        For n = 0 To gridView1.RowCount - 1
            'Dim pmwc As New PermissionModuleWarrantSubController
            'Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)
            'pmwiL = pmwc.PermissionModuleWarrantSub_GetList(GridView2.GetFocusedRowCellValue("U_ID").ToString, gridView1.GetRowCellValue(n, "ID").ToString)

            'Select Case pmwiL.Item(0).PMWS_Value
            '    Case "是"
            '        gridView1.SetRowCellValue(n, "Value", True)

            '    Case "否"
            '        gridView1.SetRowCellValue(n, "Value", True)

            '    Case Else
            '        gridView1.SetRowCellValue(n, "Value", True)

            'End Select
            gridView1.SetRowCellValue(n, "Value", True)
        Next

    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        On Error Resume Next
        Dim n As Integer
        For n = 0 To gridView1.RowCount - 1
            'Dim pmwc As New PermissionModuleWarrantSubController
            'Dim pmwiL As New List(Of PermissionModuleWarrantSubInfo)
            'pmwiL = pmwc.PermissionModuleWarrantSub_GetList(GridView2.GetFocusedRowCellValue("U_ID").ToString, gridView1.GetRowCellValue(n, "ID").ToString)

            'Select Case pmwiL.Item(0).PMWS_Value
            '    Case "是"
            '        gridView1.SetRowCellValue(n, "Value", False)

            '    Case "否"
            '        gridView1.SetRowCellValue(n, "Value", False)

            'End Select
            gridView1.SetRowCellValue(n, "Value", False)
        Next
    End Sub

    Private Sub TreeList2_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList2.FocusedNodeChanged
        Dim str As String
        Dim uls As New SystemUser.SystemUserController

        str = TreeList2.FocusedNode.Item("DPT_ID").ToString()
        Dim uli As List(Of SystemUser.SystemUserInfo)
        uli = uls.SystemUser_GetList(Nothing, Nothing, str)
        If uli Is Nothing Then
            GridControl2.DataSource = ""
        Else
            GridControl2.DataSource = uls.SystemUser_GetList(Nothing, Nothing, str)
        End If


    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        frmProjectFile.ShowDialog()
        frmProjectFile.Dispose()
    End Sub
End Class

Public Class GridEditorItem
    Private fID As String
    Private fName As String
    Private fValue As Object
    Private fRemark As String
    Private fRepositoryItem As RepositoryItem
    Public Sub New(ByVal fRepositoryItem As RepositoryItem, ByVal fID As String, ByVal fName As String, ByVal fRemark As String, ByVal fValue As Object)
        Me.fRepositoryItem = fRepositoryItem
        Me.fName = fName
        Me.fValue = fValue
        Me.fID = fID
        Me.fRemark = fRemark
    End Sub
    Public ReadOnly Property ID() As String
        Get
            Return Me.fID
        End Get
    End Property
    Public ReadOnly Property Name() As String
        Get
            Return Me.fName
        End Get
    End Property
    Public Property Value() As Object
        Get
            Return Me.fValue
        End Get
        Set(ByVal Value As Object)

            Me.fValue = Value
        End Set
    End Property
    Public ReadOnly Property Remark() As String
        Get
            Return Me.fRemark
        End Get
    End Property
    Public ReadOnly Property RepositoryItem() As RepositoryItem
        Get
            Return Me.fRepositoryItem
        End Get
    End Property

End Class
Friend Class GridEditorCollection
    Inherits ArrayList

    Public Sub New()
    End Sub
    Default Public Shadows ReadOnly Property Item(ByVal index As Integer) As GridEditorItem
        Get
            Return CType(MyBase.Item(index), GridEditorItem)
        End Get
    End Property
    Public Overloads Sub Add(ByVal fRepositoryItem As RepositoryItem, ByVal fID As String, ByVal fName As String, ByVal fRemark As String, ByVal fValue As Object)
        MyBase.Add(New GridEditorItem(fRepositoryItem, fID, fName, fRemark, fValue))
    End Sub
End Class

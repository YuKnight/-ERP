Imports LFERP.Library.Positive
Imports LFERP.SystemManager

Public Class frmPositiveDeliverMain


#Region "緩存參數"

    Private m_DoCtrl As New PositiveDeliverController
    Private m_DsListInfo As New List(Of PositiveDeliverInfo)

    Private m_PoCtrl As New PositiveOrdersController
    Private m_PsInfo As New PositiveOrdersInfo
    Private m_PsListInfo As New List(Of PositiveOrdersInfo)



#Region "陽極送貨參數"
    ''' <summary>
    ''' 送貨單號
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared m_StrD_NO As String

    Public Shared Property StrD_NO() As String
        Get
            Return m_StrD_NO
        End Get
        Set(ByVal value As String)
            m_StrD_NO = value
        End Set
    End Property

    ''' <summary>
    ''' 產品編號
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared m_StrPOMP_M_Code As String

    Public Shared Property StrPOMP_M_Code() As String
        Get
            Return m_StrPOMP_M_Code
        End Get
        Set(ByVal value As String)
            m_StrPOMP_M_Code = value
        End Set
    End Property

    ''' <summary>
    ''' 下單起始時間
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared m_StrPositiveDeliverStart As String

    Public Shared Property StrPositiveDeliverStart() As String
        Get
            Return m_StrPositiveDeliverStart
        End Get
        Set(ByVal value As String)
            m_StrPositiveDeliverStart = value
        End Set
    End Property


    ''' <summary>
    ''' 下單截至時間
    ''' </summary>
    ''' <remarks></remarks>
    Private Shared m_StrPositiveDeliverEnd As String

    Public Shared Property StrPositiveDeliverEnd() As String
        Get
            Return m_StrPositiveDeliverEnd
        End Get
        Set(ByVal value As String)
            m_StrPositiveDeliverEnd = value
        End Set
    End Property

#End Region

#Region "清空緩存參數"
    Private Sub ClearParam()
        m_StrD_NO = Nothing
        m_StrPOMP_M_Code = Nothing
        m_StrPositiveDeliverStart = Nothing
        m_StrPositiveDeliverEnd = Nothing
    End Sub
#End Region

#End Region

#Region "刷新"
    ''' <summary>
    ''' 刷新
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub RefreshPositiveDeliverData()
        dgPositiveDeliver.DataSource = m_DoCtrl.PositiveDeliver_GetListTopFiveHundred(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub
#End Region

#Region "右鍵菜單事件"
    Private Sub popPositiveDeliverMain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPositiveDeliverAdd.Click, popPositiveDeliverMainView.Click, PopPositiveDeliverMainRefresh.Click, popPositiveDeliverMainEdit.Click, popPositiveDeliverMainDel.Click, popPositiveDeliverMainCheck.Click
        On Error Resume Next

        Dim frmObject As frmPositiveDeliver

        For Each frmObject In MDIMain.MdiChildren
            If TypeOf frmObject Is frmPositiveDeliver Then
                frmObject.Activate()
                Exit Sub
            End If
        Next

        frmObject = New frmPositiveDeliver

        m_DsListInfo.Clear()


        Select Case sender.Name

            Case "popPositiveDeliverAdd"

                frmObject.EditItemDescrip = "Add"

                frmObject.DOMID = dgvPositiveDeliver.GetFocusedRowCellValue("D_NO").ToString()

            Case "PopPositiveDeliverMainRefresh"

                RefreshPositiveDeliverData()
                Exit Sub

            Case Else



                '  m_DsListInfo = m_DoCtrl.PositiveDeliver_GetList(dgvPositiveDeliver.GetFocusedRowCellValue("D_NO").ToString(), Nothing, Nothing, Nothing, Nothing, Nothing)

                If m_DsListInfo Is Nothing Then
                    Exit Sub
                End If

                If m_DsListInfo.Count <= 0 Then
                    Exit Sub
                End If


                Select Case sender.Name

                    Case "popPositiveDeliverMainEdit"

                        If m_DsListInfo(0).D_Check Then
                            MsgBox("陽極送貨訂單已經審核!不允許修改", 64, "提示")
                            Exit Sub
                        End If

                        frmObject.EditItemDescrip = "Modify"

                    Case "popPositiveDeliverMainView"

                        frmObject.EditItemDescrip = "View"

                    Case "popPositiveDeliverMainDel"

                        If m_DsListInfo(0).D_Check Then
                            MsgBox("陽極送貨訂單已經審核!不允許刪除", 64, "提示")
                            Exit Sub
                        End If

                        If MsgBox("確定要刪除編號為" & dgvPositiveDeliver.GetFocusedRowCellValue("D_NO").ToString & "的訂單嗎？", MsgBoxStyle.YesNo, "刪除提示") = MsgBoxResult.Yes Then

                            If m_DoCtrl.PositiveDeliver_DeleteByDOMNum(dgvPositiveDeliver.GetFocusedRowCellValue("D_NO").ToString()) Then
                                MsgBox("刪除當前送貨訂單成功!")
                                RefreshPositiveDeliverData()
                            Else
                                MsgBox("刪除當前送貨訂單失敗,請檢查原因!")
                            End If

                        End If

                        Exit Sub

                    Case "popPositiveDeliverMainCheck"

                        'If m_DsListInfo(0).D_Check Then
                        '    MsgBox("陽極送貨訂單已經審核!不允許審核", 64, "提示")
                        '    Exit Sub
                        'End If
                        frmObject.BolFalg = m_DsListInfo(0).D_Check
                        frmObject.EditItemDescrip = "Check"

                End Select

                frmObject.DOMID = dgvPositiveDeliver.GetFocusedRowCellValue("D_NO").ToString()

        End Select

        frmObject.MdiParent = MDIMain
        frmObject.WindowState = FormWindowState.Maximized
        frmObject.Show()

    End Sub
#End Region

#Region "加載權限"
    Private Sub LoadPowerUser()

        Dim pmws As New PermissionModuleWarrantSubController
        Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "9402101")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPositiveDeliverAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "9402102")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPositiveDeliverMainEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "9402103")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPositiveDeliverMainDel.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "9402105")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPositiveDeliverMainView.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "9402106")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then PopPositiveDeliverMainRefresh.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "9402104")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPositiveDeliverMainCheck.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "9402107")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPositiveDeliverMainQuery.Enabled = True
        End If

    End Sub
#End Region

#Region "初始化加載數據"
    Private Sub dgPositiveDeliver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgPositiveDeliver.Load

        RefreshPositiveDeliverData()

        LoadPowerUser()

    End Sub
#End Region

#Region "列印訂貨單"
    Private Sub popPositiveDeliverMainPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPositiveDeliverMainPrint.Click

        Dim ltc As New CollectionToDataSet
        Dim dsPositiveDeliver As New DataSet
        m_DsListInfo.Clear()

        '  m_DsListInfo = m_DoCtrl.PositiveDeliver_GetList(dgvPositiveDeliver.GetFocusedRowCellValue("D_NO").ToString(), Nothing, Nothing, Nothing, Nothing, Nothing)

        If m_DsListInfo.Count <= 0 Then
            MsgBox("沒有符合要求的數據！", 64, "提示")
            Exit Sub
        End If

        ltc.CollToDataSet(dsPositiveDeliver, "PositiveDeliver", m_DsListInfo)
        PreviewRPTDialog(dsPositiveDeliver, "rptPositiveDeliver", "陽極送貨訂單", True, True)
    End Sub
#End Region

#Region "送貨單查詢"
    ''' <summary>
    ''' 送貨單查詢
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popPositiveDeliverMainQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPositiveDeliverMainQuery.Click
        ClearParam()
        Dim frmQuery As New frmPositiveOrdersQuery
        frmQuery.StrQuery = "PositiveDeliver"
        frmQuery.ShowDialog()

        If Not frmPositiveOrdersQuery.BolFlag Then
            dgPositiveDeliver.DataSource = m_DoCtrl.PositiveDeliver_GetListTopFiveHundred(m_StrD_NO, Nothing, m_StrPOMP_M_Code, m_StrPositiveDeliverStart, m_StrPositiveDeliverEnd, Nothing)
        End If
    End Sub
#End Region

End Class
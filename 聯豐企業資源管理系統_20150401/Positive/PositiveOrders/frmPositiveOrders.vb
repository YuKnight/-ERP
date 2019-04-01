Imports LFERP.DataSetting
Imports LFERP.Library.Positive
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Product

Public Class frmPositiveOrders

#Region "緩存的參數"

    Private m_DoCtrl As New PositiveDeliverController
    Private m_DsListInfo As New List(Of PositiveDeliverInfo)


    Private m_PoCtrl As New PositiveOrdersController
    Private m_PsListInfo As New List(Of PositiveOrdersInfo)

    Private m_DataSet As New DataSet                '數據集

    Private m_EditItemDescrip As String             '描述

    Public Property EditItemDescrip() As String
        Get
            Return m_EditItemDescrip
        End Get
        Set(ByVal value As String)
            m_EditItemDescrip = value
        End Set
    End Property


    Private m_POMID As String                       '訂單編號

    Public Property POMID() As String
        Get
            Return m_POMID
        End Get
        Set(ByVal value As String)
            m_POMID = value
        End Set
    End Property


    Private m_BolFalg As Boolean

    Public Property BolFalg() As String
        Get
            Return m_BolFalg
        End Get
        Set(ByVal value As String)
            m_BolFalg = value
        End Set
    End Property

#End Region

#Region "關閉窗體程序"
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
#End Region

#Region "生成新訂單號"
    ''' <summary>
    ''' 生成新訂單號
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetPOI_No() As String

        Dim m_PsInfo As New PositiveOrdersInfo

        m_PsInfo = m_PoCtrl.PositiveOrders_GetNO("POI" + Now.ToString("yyMM"), Nothing)

        If m_PsInfo Is Nothing Then
            Return "POI" & Now.ToString("yy") & Now.ToString("MM") & "0001"
        Else
            Return "POI" & Now.ToString("yy") & Now.ToString("MM") & Mid((CInt(Mid(m_PsInfo.P_OM_ID, 6)) + 10001), 2)
        End If

    End Function
#End Region

#Region "生成訂單流水號"
    ''' <summary>
    ''' 生成訂單流水號
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function PON_Num() As String

        Dim m_PsInfo As New PositiveOrdersInfo

        m_PsInfo = m_PoCtrl.PositiveOrders_GetNO(Nothing, "PON" + Now.ToString("yyMM"))

        If m_PsInfo Is Nothing Then
            Return "PON" & Now.ToString("yy") & Now.ToString("MM") & "0001"
        Else
            Return "PON" & Now.ToString("yy") & Now.ToString("MM") & Mid((CInt(Mid(m_PsInfo.P_OM_Num, 6)) + 10001), 2)
        End If

    End Function

#End Region

#Region "創建臨時表"
    Private Sub CreateTables()

        m_DataSet.Tables.Clear()
        With m_DataSet.Tables.Add("PositiveOrders")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("P_OM_Num", GetType(String))
            .Columns.Add("P_OM_ID", GetType(String))
            .Columns.Add("P_OM_CusterPO", GetType(String))
            .Columns.Add("P_OM_CusterNo", GetType(String))
            .Columns.Add("P_M_Code", GetType(String))
            .Columns.Add("PartNumber", GetType(String))
            .Columns.Add("Qty", GetType(Integer))
            .Columns.Add("NoSendQty", GetType(String))
            .Columns.Add("P_OM_AddDate", GetType(String))
            .Columns.Add("P_OM_AddAction", GetType(String))
            .Columns.Add("P_OM_Check", GetType(String))
            .Columns.Add("P_OM_CheckAction", GetType(String))
            .Columns.Add("P_OM_CheckDate", GetType(String))
            .Columns.Add("P_SalesPrice", GetType(String))
            .Columns.Add("P_ProductPrice", GetType(String))
            .Columns.Add("P_Remark", GetType(String))
            .Columns.Add("P_CheckRemark", GetType(String))
        End With
        dgPositiveOrders.DataSource = m_DataSet.Tables("PositiveOrders")

        '創建刪除數據表
        With m_DataSet.Tables.Add("DelData")
            .Columns.Add("P_OM_Num", GetType(String))
        End With

    End Sub
#End Region

#Region "加載修改數據"
    Private Function LoadModifyData() As Boolean
        LoadModifyData = False

        txtP_OM_ID.Text = m_POMID

        m_PsListInfo.Clear()

        '  m_PsListInfo = m_PoCtrl.PositiveOrders_GetList(txtP_OM_ID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If m_PsListInfo Is Nothing Then
            Exit Function
        End If

        If m_PsListInfo.Count <= 0 Then
            Exit Function
        End If


        gluCuster.EditValue = m_PsListInfo(0).P_OM_CusterNo
        txtP_OM_AddAction.Text = m_PsListInfo(0).ActionName
        txtP_OM_CusterPO.Text = m_PsListInfo(0).P_OM_CusterPO
        dtOrdersStart.Text = m_PsListInfo(0).P_OM_AddDate
        txtP_OMRemark.Text = m_PsListInfo(0).P_OMRemark
        dtOrderComplate.Text = m_PsListInfo(0).P_OMComplateDate
        '加載審核數據

        chkCheck.Checked = m_PsListInfo(0).P_OM_Check
        lblCheckDateTime.Text = m_PsListInfo(0).P_OM_CheckDate

        If m_PsListInfo(0).CheckActionName = String.Empty Then
            lblCheckAction.Text = UserName
        Else
            lblCheckAction.Text = m_PsListInfo(0).CheckActionName
        End If

        txtCheckRemark.Text = m_PsListInfo(0).P_CheckRemark


        Dim nIndex As Integer
        For nIndex = 0 To m_PsListInfo.Count - 1
            Dim row As DataRow
            row = m_DataSet.Tables("PositiveOrders").NewRow

            row("P_OM_Num") = m_PsListInfo(nIndex).P_OM_Num

            row("P_M_Code") = m_PsListInfo(nIndex).P_M_Code

            row("PartNumber") = m_PsListInfo(nIndex).PartNumber

            row("Qty") = m_PsListInfo(nIndex).Qty

            row("NoSendQty") = m_PsListInfo(nIndex).NoSendQty

            row("P_SalesPrice") = m_PsListInfo(nIndex).P_SalesPrice

            row("P_ProductPrice") = m_PsListInfo(nIndex).P_ProductPrice

            row("P_Remark") = m_PsListInfo(nIndex).P_Remark

            m_DataSet.Tables("PositiveOrders").Rows.Add(row)
        Next

        LoadModifyData = True
    End Function
#End Region

#Region "初始化加載數據"
    Private Sub frmPositiveOrders_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        CreateTables()
        LoadgluCuster()

        r_PM_M_Code.VisibleIndex = 0
        r_PM_M_Code.Width = 100


        Dim pcMainCtrl As New ProductController
        rGrid.DisplayMember = "PM_M_Code"
        rGrid.ValueMember = "PM_M_Code"
        rGrid.DataSource = pcMainCtrl.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)


        Select Case m_EditItemDescrip
            Case "Add"
                txtP_OM_ID.Text = GetPOI_No()
                txtP_OM_AddAction.Text = UserName
                dtOrdersStart.Text = Now.ToString("yyyy/MM/dd")
                dtOrderComplate.Text = Now.ToString("yyyy/MM/dd")
                XtraTabPage2.PageVisible = False
                Me.Text = "訂單-新增"
            Case "Modify"
                LoadModifyData()
                pnlCheck.Enabled = False
                XtraTabPage2.PageEnabled = False
                Me.Text = "訂單-修改"
            Case "Check"
                LoadModifyData()
                GroupBox1.Enabled = False
                popOrder.Enabled = False
                dgvPositiveOrders.OptionsBehavior.Editable = False

                lblCheckDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
                Me.Text = "訂單-審核"
                XtraTabControl1.SelectedTabPage = XtraTabPage2
            Case "View"
                LoadModifyData()
                GroupBox1.Enabled = False
                popOrder.Enabled = False
                cmdSave.Enabled = False
                pnlCheck.Enabled = False
                dgvPositiveOrders.OptionsBehavior.Editable = False
                dgvPositiveOrders.Columns("NoSendQty").Visible = True
                dgvPositiveOrders.Columns("NoSendQty").VisibleIndex = 3
                Me.Text = "訂單-查看"
            Case "Price"
                LoadModifyData()
                pnlCheck.Enabled = False
                XtraTabPage2.PageEnabled = False
                InvalidPrice()
                Me.Text = "訂單-修改單價"
        End Select
    End Sub

    Private Sub InvalidPrice()
        dgvPositiveOrders.Columns("P_SalesPrice").Visible = True
        dgvPositiveOrders.Columns("P_SalesPrice").VisibleIndex = 3
        dgvPositiveOrders.Columns("P_ProductPrice").Visible = True
        dgvPositiveOrders.Columns("P_ProductPrice").VisibleIndex = 4
        GroupBox1.Enabled = False
        popOrder.Enabled = False
        pnlCheck.Enabled = False


        dgvPositiveOrders.Columns("P_M_Code").OptionsColumn.AllowEdit = False
        dgvPositiveOrders.Columns("PartNumber").OptionsColumn.AllowEdit = False
        dgvPositiveOrders.Columns("Qty").OptionsColumn.AllowEdit = False
        dgvPositiveOrders.Columns("P_Remark").OptionsColumn.AllowEdit = False

        popOrder.Enabled = True
        popPositiveOrdersAdd.Enabled = False
    End Sub

#End Region

#Region "加載客戶代號"
    Private Sub LoadgluCuster()
        Dim cusCtrl As New CusterControler

        gluCuster.Properties.DisplayMember = "C_CusterID"
        gluCuster.Properties.ValueMember = "C_CusterID"
        gluCuster.Properties.DataSource = cusCtrl.GetCusterList(Nothing, Nothing, Nothing)

    End Sub
   
#End Region

#Region "檢查數據"
    Private Function CheckData() As Boolean
        CheckData = False

        If m_DataSet.Tables("PositiveOrders").Rows.Count <= 0 Then
            MsgBox("訂單產品不能為空!", 64, "提示")
            Exit Function
        End If

        If m_EditItemDescrip = "Modify" Then
            Dim nIndexModify As Integer

            m_DsListInfo.Clear()

            m_PsListInfo.Clear()


            '  m_PsListInfo = m_PoCtrl.PositiveOrders_GetList(txtP_OM_ID.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            If m_PsListInfo Is Nothing Then
                MsgBox("該訂單已經不存在", 64, "提示")
                Exit Function
            End If

            If m_PsListInfo.Count <= 0 Then
                MsgBox("該訂單已經不存在", 64, "提示")
                Exit Function
            End If

            If m_PsListInfo(0).P_OM_Check Then
                MsgBox("該訂單已經審核不允許修改", 64, "提示")
                Exit Function
            End If

            For nIndexModify = 0 To m_DataSet.Tables("PositiveOrders").Rows.Count - 1

                If m_DataSet.Tables("PositiveOrders").Rows(nIndexModify)("P_OM_Num").ToString() = String.Empty Then
                    Continue For
                End If

                ' m_DsListInfo = m_DoCtrl.PositiveDeliver_GetList(Nothing, m_DataSet.Tables("PositiveOrders").Rows(nIndexModify)("P_OM_Num"), Nothing, Nothing, Nothing, Nothing)

                If m_DsListInfo.Count > 0 Then
                    MsgBox("該訂單已有送貨記錄不允許修改!", 64, "提示")
                    Exit Function
                End If
            Next
        End If


        Dim nIndex_I As Integer
        Dim nIndex_J As Integer

        If m_DataSet.Tables("PositiveOrders").Rows.Count > 1 Then
            '冒泡查找算法
            For nIndex_I = 0 To m_DataSet.Tables("PositiveOrders").Rows.Count - 1
                For nIndex_J = 1 + nIndex_I To m_DataSet.Tables("PositiveOrders").Rows.Count - 1
                    If m_DataSet.Tables("PositiveOrders").Rows(nIndex_J)("P_M_Code").ToString() = m_DataSet.Tables("PositiveOrders").Rows(nIndex_I)("P_M_Code").ToString() Then
                        If m_DataSet.Tables("PositiveOrders").Rows(nIndex_J)("PartNumber").ToString() = m_DataSet.Tables("PositiveOrders").Rows(nIndex_I)("PartNumber").ToString() Then
                            MsgBox("同一張單不能出現相同的產品!", 64, "提示")
                            Exit Function
                        End If
                    End If
                Next
            Next
        End If



        If gluCuster.EditValue = "" Or Len(gluCuster.EditValue) > 50 Then
            MsgBox("客戶代號不能為空或者超出了長度!", 64, "提示")
            gluCuster.Focus()
            Exit Function
        End If

        If txtP_OM_AddAction.Text = "" Or Len(txtP_OM_AddAction.Text) > 20 Then
            MsgBox("工號不能為空或者超出了長度!", 64, "提示")
            txtP_OM_AddAction.Focus()
            Exit Function
        End If

        If txtP_OM_CusterPO.Text = "" Or Len(txtP_OM_CusterPO.Text) > 50 Then
            MsgBox("客戶PO不能為空或者超出了長度!", 64, "提示")
            txtP_OM_CusterPO.Focus()
            Exit Function
        End If

        If CDate(dtOrdersStart.Text) > CDate(dtOrderComplate.Text) Then
            MsgBox("下單日期不能大於交貨日期!", 64, "提示")
            Exit Function
        End If

        Try
            Dim nIndex As Integer
            For nIndex = 0 To m_DataSet.Tables("PositiveOrders").Rows.Count - 1


                If IsDBNull(m_DataSet.Tables("PositiveOrders").Rows(nIndex)("Qty")) Then
                    MsgBox("訂單數量不能為空!", 64, "提示")
                    Exit Function
                End If



                If IsDBNull(m_DataSet.Tables("PositiveOrders").Rows(nIndex)("PartNumber")) Then
                    MsgBox("料號不能為空!", 64, "提示")
                    Exit Function
                End If

                If Not CheckQty(m_DataSet.Tables("PositiveOrders").Rows(nIndex)("Qty").ToString(), "訂單數量") Then
                    Exit Function
                End If

                If m_EditItemDescrip = "Price" Then

                    If IsDBNull(m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_SalesPrice")) Then
                        MsgBox("銷售單價不能為空!", 64, "提示")
                        Exit Function
                    End If

                    If IsDBNull(m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_ProductPrice")) Then
                        MsgBox("成本價不能為空!", 64, "提示")
                        Exit Function
                    End If

                    If Not CheckQty(m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_SalesPrice").ToString(), "銷售單價") Then
                        Exit Function
                    End If

                    If Not CheckQty(m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_ProductPrice").ToString(), "成本價") Then
                        Exit Function
                    End If
                End If


                If m_DataSet.Tables("PositiveOrders").Rows(nIndex)("PartNumber").ToString() = "" Or Len(m_DataSet.Tables("PositiveOrders").Rows(nIndex)("PartNumber").ToString()) > 50 Then
                    MsgBox("料號不能為空或者超出了長度!", 64, "提示")
                    Exit Function
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString(), 64, "提示")
            Exit Function
        End Try

        CheckData = True
    End Function

    Private Function CheckQty(ByVal strParam As String, ByVal strName As String) As Boolean

        CheckQty = False

        Try
            If strParam <> String.Empty Then
                If CDbl(strParam) <= 0 Then
                    MsgBox(strName & "不能小於等於零!", 64, "提示")
                    Exit Function
                End If
            Else
                MsgBox(strName & "不能為空!", 64, "提示")
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(strName & "超出範圍!", 64, "提示")
            Exit Function
        End Try

        CheckQty = True

    End Function
#End Region

#Region "保存數據"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case m_EditItemDescrip
            Case "Add"
                If CheckData() Then
                    SaveData("Add", "新增")
                End If
            Case "Modify"
                If CheckData() Then
                    SaveData("Modify", "修改")
                End If
            Case "Check"
                UpdateCheck()
            Case "Price"
                If CheckData() Then
                    SavePrice()
                End If
        End Select
    End Sub

    ''' <summary>
    ''' 保存單價
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SavePrice()
        Dim m_PsInfo As New PositiveOrdersInfo

        m_PsInfo.P_OM_ID = txtP_OM_ID.Text

        Dim nIndex As Integer

        For nIndex = 0 To m_DataSet.Tables("PositiveOrders").Rows.Count - 1
            m_PsInfo.P_OM_Num = m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_OM_Num")

            m_PsInfo.P_SalesPrice = m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_SalesPrice")

            m_PsInfo.P_ProductPrice = m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_ProductPrice")

            If Not (m_PoCtrl.PositiveOrders_UpdatePrice(m_PsInfo)) Then
                MsgBox("陽極訂單單價更改失敗!", 64, "提示")
                Exit Sub
            End If
        Next


     

        MsgBox("單價修改成功", 64, "提示")
        Me.Close()
    End Sub


    ''' <summary>
    ''' 審核數據
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub UpdateCheck()

        If m_BolFalg = chkCheck.Checked Then
            MsgBox("請改變審核狀態！")
            Exit Sub
        End If

        Dim m_PsInfo As New PositiveOrdersInfo

        m_PsInfo.P_OM_ID = txtP_OM_ID.Text

        m_PsInfo.P_OM_Check = chkCheck.Checked

        If chkCheck.Checked Then
            m_PsInfo.P_OM_CheckAction = InUserID

            m_PsInfo.P_OM_CheckDate = Format(Now, "yyyy/MM/dd HH:mm:ss")

            m_PsInfo.P_Remark = txtCheckRemark.Text
        Else
            m_PsInfo.P_OM_CheckAction = String.Empty

            m_PsInfo.P_OM_CheckDate = Nothing

            m_PsInfo.P_Remark = String.Empty

        End If
       

        If m_PoCtrl.PositiveOrders_Check(m_PsInfo) Then
            MsgBox("審核狀態已改變!", 64, "提示")
        Else
            MsgBox("審核失敗,請檢查原因!", 64, "提示")
        End If

        Me.Close()
    End Sub

    ''' <summary>
    ''' 保存數據
    ''' </summary>
    ''' <param name="strTemp"></param>
    ''' <remarks></remarks>
    Private Sub SaveData(ByVal strTemp As String, ByVal strDescreption As String)
        Dim m_PsInfo As New PositiveOrdersInfo

        Select Case strTemp
            Case "Add"
                m_PsInfo.P_OM_ID = GetPOI_No()
            Case "Modify"
                m_PsInfo.P_OM_ID = txtP_OM_ID.Text
        End Select

        m_PsInfo.P_OM_CusterNo = gluCuster.EditValue

        m_PsInfo.P_OM_AddAction = InUserID

        m_PsInfo.P_OM_CusterPO = txtP_OM_CusterPO.Text

        m_PsInfo.P_OMRemark = txtP_OMRemark.Text

        m_PsInfo.P_OMComplateDate = dtOrderComplate.Text

        m_PsInfo.P_OM_AddDate = dtOrdersStart.Text

        Dim nIndex As Integer

        For nIndex = 0 To m_DataSet.Tables("PositiveOrders").Rows.Count - 1

            m_PsInfo.P_M_Code = m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_M_Code")

            m_PsInfo.PartNumber = m_DataSet.Tables("PositiveOrders").Rows(nIndex)("PartNumber")

            m_PsInfo.Qty = m_DataSet.Tables("PositiveOrders").Rows(nIndex)("Qty")

            m_PsInfo.NoSendQty = m_DataSet.Tables("PositiveOrders").Rows(nIndex)("Qty")

            If IsDBNull(m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_Remark")) Then
                m_PsInfo.P_Remark = String.Empty
            Else
                m_PsInfo.P_Remark = m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_Remark")
            End If



            Select Case strTemp
                Case "Add"
                    m_PsInfo.P_OM_Num = PON_Num()
                    If Not (m_PoCtrl.PositiveOrders_Add(m_PsInfo)) Then
                        MsgBox("失敗" & strDescreption & "陽極訂單!", 64, "提示")
                        Exit Sub
                    End If
                Case "Modify"

                    If m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_OM_Num").ToString() = String.Empty Then

                        m_PsInfo.P_OM_Num = PON_Num()
                        If Not (m_PoCtrl.PositiveOrders_Add(m_PsInfo)) Then
                            MsgBox("失敗" & strDescreption & "陽極訂單!", 64, "提示")
                            Exit Sub
                        End If
                    Else

                        m_PsInfo.P_OM_Num = m_DataSet.Tables("PositiveOrders").Rows(nIndex)("P_OM_Num")
                        If Not (m_PoCtrl.PositiveOrders_Update(m_PsInfo)) Then
                            MsgBox("失敗" & strDescreption & "陽極訂單!", 64, "提示")
                            Exit Sub
                        End If
                    End If
            End Select


        Next

        If m_DataSet.Tables("DelData").Rows.Count > 0 Then
            For i As Integer = 0 To m_DataSet.Tables("DelData").Rows.Count - 1
                m_PoCtrl.PositiveOrders_DeleteByPONum(m_DataSet.Tables("DelData").Rows(i)("P_OM_Num"))
            Next i
        End If


        MsgBox("完成" & strDescreption & "陽極訂單!", 64, "提示")
        Me.Close()

    End Sub

#End Region

#Region "右鍵菜單選項"
    ''' <summary>
    ''' 新增
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popPositiveOrdersAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPositiveOrdersAdd.Click
        Dim row As DataRow = m_DataSet.Tables("PositiveOrders").NewRow()
        row("Qty") = 0
        row("NoSendQty") = 0
        row("P_SalesPrice") = 0
        row("P_ProductPrice") = 0
        m_DataSet.Tables("PositiveOrders").Rows.Add(row)
        dgvPositiveOrders.MoveLast()
    End Sub
    ''' <summary>
    ''' 刪除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub popPositiveOrdersDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPositiveOrdersDel.Click
        If dgvPositiveOrders.RowCount = 0 Then Exit Sub
        Dim delTemp As String
        Try
            delTemp = dgvPositiveOrders.GetRowCellDisplayText(ArrayToString(dgvPositiveOrders.GetSelectedRows()), "P_OM_Num")

            If delTemp = "P_OM_Num" Then
            Else
                '在刪除表中增加被刪除的記錄
                Dim row As DataRow = m_DataSet.Tables("DelData").NewRow
                row("P_OM_Num") = delTemp
                m_DataSet.Tables("DelData").Rows.Add(row)
            End If
            m_DataSet.Tables("PositiveOrders").Rows.RemoveAt(CInt(ArrayToString(dgvPositiveOrders.GetSelectedRows())))
        Catch ex As Exception

        End Try

    End Sub

#End Region



End Class
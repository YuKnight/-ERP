Imports LFERP.DataSetting
Imports LFERP.Library.Product

Public Class frmPositiveOrdersQuery

    Dim mc As New ProductController
    Dim mtd As New CusterControler


    ''' <summary>
    ''' 查詢描述
    ''' </summary>
    ''' <remarks></remarks>
    Private m_StrQuery As String

    Public Property StrQuery() As String
        Get
            Return m_StrQuery
        End Get
        Set(ByVal value As String)
            m_StrQuery = value
        End Set
    End Property

    Private Shared m_BolFlag As Boolean

    Public Shared Property BolFlag() As Boolean
        Get
            Return m_BolFlag
        End Get
        Set(ByVal value As Boolean)
            m_BolFlag = value
        End Set
    End Property

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        m_BolFlag = True
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        m_BolFlag = False
        Select Case m_StrQuery
            Case "PositiveOrders"
                If txtP_OM_ID.Text <> String.Empty Then
                    frmPositiveOrdersMain.StrP_OM_ID = txtP_OM_ID.Text
                End If

                If GridLookPM_M_Code.EditValue <> String.Empty Then
                    frmPositiveOrdersMain.StrP_M_Code = GridLookPM_M_Code.EditValue
                End If

                If gluCuster.EditValue <> String.Empty Then
                    frmPositiveOrdersMain.StrP_OM_CusterNo = gluCuster.EditValue
                End If

                If orderEdit.Checked Then
                    frmPositiveOrdersMain.StrP_OM_AddDateStart = dtPositiveOrdersStart.Text
                    frmPositiveOrdersMain.StrP_OM_AddDateEnd = dtPositiveOrdersEnd.Text
                End If

                If sendEdit.Checked Then
                    frmPositiveOrdersMain.StrP_OMComplateDateStart = dtPositiveOrdersStart.Text
                    frmPositiveOrdersMain.StrP_OMComplateDateEnd = dtPositiveOrdersEnd.Text
                End If
            Case "PositiveDeliver"
                If txtD_NO.Text <> String.Empty Then
                    frmPositiveDeliverMain.StrD_NO = txtD_NO.Text
                End If

                If GridLookUpEdit2.EditValue <> String.Empty Then
                    frmPositiveDeliverMain.StrPOMP_M_Code = GridLookUpEdit2.EditValue
                End If

                If dtPositiveDeliverStart.Text <> String.Empty Then
                    frmPositiveDeliverMain.StrPositiveDeliverStart = dtPositiveDeliverStart.Text
                End If

                If dtPositiveDeliverEnd.Text <> String.Empty Then
                    frmPositiveDeliverMain.StrPositiveDeliverEnd = dtPositiveDeliverEnd.Text
                End If

        End Select

        Me.Close()
    End Sub

#Region "初始化加載查詢條件"
    Private Sub frmPositiveOrdersQuery_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Select Case m_StrQuery
            Case "PositiveOrders"
                XtraTabPage2.PageVisible = False
                dtPositiveOrdersStart.EditValue = Format(Now, "yyyy/MM/" & "01")
                dtPositiveOrdersEnd.EditValue = Format(Now, "yyyy/MM/dd")

                gluCuster.Properties.DisplayMember = "C_CusterID"
                gluCuster.Properties.ValueMember = "C_CusterID"
                gluCuster.Properties.DataSource = mtd.GetCusterList(Nothing, Nothing, Nothing)

                GridLookPM_M_Code.Properties.DisplayMember = "PM_M_Code"
                GridLookPM_M_Code.Properties.ValueMember = "PM_M_Code"
                GridLookPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "PositiveDeliver"
                XtraTabPage1.PageVisible = False
                dtPositiveDeliverStart.EditValue = Format(Now, "yyyy/MM/" & "01")
                dtPositiveDeliverEnd.EditValue = Format(Now, "yyyy/MM/dd")

                GridLookUpEdit2.Properties.DisplayMember = "PM_M_Code"
                GridLookUpEdit2.Properties.ValueMember = "PM_M_Code"
                GridLookUpEdit2.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        End Select
    End Sub
#End Region

End Class
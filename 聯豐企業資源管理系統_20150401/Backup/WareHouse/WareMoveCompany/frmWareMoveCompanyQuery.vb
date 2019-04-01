Public Class frmWareMoveCompanyQuery

    Private Shared m_BolFlag As Boolean

    Public Shared Property BolFlag() As Boolean
        Get
            Return m_BolFlag
        End Get
        Set(ByVal value As Boolean)
            m_BolFlag = value
        End Set
    End Property

    ''' <summary>
    ''' ¤½¥q
    ''' </summary>
    ''' <remarks></remarks>
    Private m_StrCompany As String

    Public Property StrCompany() As String
        Get
            Return m_StrCompany
        End Get
        Set(ByVal value As String)
            m_StrCompany = value
        End Set
    End Property

    ''' <summary>
    ''' ­Ü®w¦WºÙ
    ''' </summary>
    ''' <remarks></remarks>
    Private m_StrWareHourse As String

    Public Property StrWareHourse() As String
        Get
            Return m_StrWareHourse
        End Get
        Set(ByVal value As String)
            m_StrWareHourse = value
        End Set
    End Property

    ''' <summary>
    ''' ­Ü®wID
    ''' </summary>
    ''' <remarks></remarks>
    Private m_StrWHID As String

    Public Property StrWHID() As String
        Get
            Return m_StrWHID
        End Get
        Set(ByVal value As String)
            m_StrWHID = value
        End Set
    End Property


    Private Sub frmWareMoveCompanyQuery_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dtWareMoveStart.EditValue = Format(Now, "yyyy/MM/" & "01")
        dtWareMoveEnd.EditValue = Format(Now, "yyyy/MM/dd")

        txtCompany.Text = m_StrCompany
        txtWareHourse.Text = m_StrWareHourse
        cbType.SelectedIndex = 0

        txtP_OM_ID.Focus()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        m_BolFlag = False

        If txtP_OM_ID.Text <> String.Empty Then
            frmWareMoveCompanyMain.StrD_NO = txtP_OM_ID.Text
        End If

        If txtM_Code.Text <> String.Empty Then
            frmWareMoveCompanyMain.StrM_Code = txtM_Code.Text
        End If

        If dtWareMoveStart.Text <> String.Empty Then
            frmWareMoveCompanyMain.StrWareMoveStart = dtWareMoveStart.Text
        End If

        If dtWareMoveEnd.Text <> String.Empty Then
            frmWareMoveCompanyMain.StrWareMoveEnd = dtWareMoveEnd.Text
        End If

        frmWareMoveCompanyMain.StrCompany = txtCompany.Text
        frmWareMoveCompanyMain.StrWareHourse = txtWareHourse.Text
        frmWareMoveCompanyMain.StrWHID = m_StrWHID
        frmWareMoveCompanyMain.StrCType = cbType.Text

        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        m_BolFlag = True
        Me.Close()
    End Sub
End Class
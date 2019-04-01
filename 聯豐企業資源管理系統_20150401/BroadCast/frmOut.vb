Imports LFERP.Library.BroadCastManager.BroadCastMessage
Imports LFERP.Library.BroadCastManager.BroadCastFactory

Public Class frmOut
    Dim bcm As New BroadCastMessageControler
    Dim ds As New DataSet
#Region "判斷是發送消息及消息類型"
    Private _responseTo As String
    Private _isResponse As String
    Private _autoid As String
    ''' <summary>
    ''' 發送消息給誰
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property responseTo() As String
        Get
            Return _responseTo
        End Get
        Set(ByVal value As String)
            _responseTo = value
        End Set
    End Property
    ''' <summary>
    ''' 消息類型
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property isResponse() As String
        Get
            Return _isResponse
        End Get
        Set(ByVal value As String)
            _isResponse = value
        End Set
    End Property
    ''' <summary>
    ''' 獲取回覆消息的autoid
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property autoid() As String
        Get
            Return _autoid
        End Get
        Set(ByVal value As String)
            _autoid = value
        End Set
    End Property
#End Region
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Savebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Savebutton.Click
        If txt_Out.Text = String.Empty Then
            MsgBox("您還沒有選擇發送人！", MsgBoxStyle.OkOnly, "提示")
            txt_Out.Focus()
            Exit Sub
        End If
        If Me.txtMessage.Text.Trim() = String.Empty Then
            MsgBox("您還沒有輸入內容！", MsgBoxStyle.OkOnly, "提示")
            txtMessage.Focus()
            Exit Sub
        End If
        SaveData()
        If isResponse = "isResponse" Then
            Dim bcm As New BroadCastMessageControler
            Dim bm As New List(Of BroadCastMessageInfo)
            bm = bcm.BroadCastMessage_Getlist(Nothing, Nothing, Nothing, False, autoid)
            If bm.Count <= 0 Then
                Exit Sub
            Else
                Dim bcmi As New BroadCastMessageInfo
                bcmi.AutoID = bm(0).AutoID
                bcmi.M_Adddate = Format(CDate(bm(0).M_Adddate), "yyyy/MM/dd")
                bcmi.M_AdduserID = bm(0).M_AdduserID
                bcmi.M_Affirm = bm(0).M_Affirm
                bcmi.M_Date = bm(0).M_Date
                bcmi.M_In = bm(0).M_In
                bcmi.M_Message = bm(0).M_Message
                bcmi.M_ModifyDate = bm(0).M_ModifyDate
                bcmi.M_ModifyUserID = bm(0).M_ModifyUserID
                bcmi.M_Out = bm(0).M_Out
                bcmi.M_Time = bm(0).M_Time
                bcmi.M_Type = bm(0).M_Type
                bcmi.M_Status = "reply"
                bcm.BroadCastMessage_Update(bcmi)
            End If

        End If

    End Sub
    Sub SaveData()
        Dim bcmi As New BroadCastMessageInfo
        bcmi.M_Adddate = Format(Now, "yyyy/MM/dd")
        bcmi.M_AdduserID = InUserID
        bcmi.M_Affirm = False

        Dim i As Integer
        Dim testArray() As String = Me.txt_Out.Text.Split(",")

        bcmi.M_Message = Me.txtMessage.Text
        bcmi.M_Out = InUser
        bcmi.M_Type = Me.cob_M_Type.Text
        bcmi.M_Status = "new"

        For i = 0 To testArray.Length - 1
            bcmi.M_In = testArray(i)
            bcm.BroadCastMessage_Add(bcmi)
        Next

        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub frmOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case isResponse
            Case "isResponse"
                Me.txt_Out.Text = responseTo
                Me.txt_Out.Enabled = False
                Me.cob_M_Type.Text = "一般"
                txtMessage.Text = ""
            Case "isSend"
                Me.txt_Out.Enabled = True
                Me.cob_M_Type.Text = "一般"
                Me.txt_Out.Text = ""
                txtMessage.Text = ""

                Dim bbc As New BroadCastFactoryControler
                Dim mm As New List(Of BroadCastFactoryInfo)
                Me.TreeList1.DataSource = bbc.BroadCastBrigade_GetListItem(strInCompany, Nothing)
                Me.TreeList1.ExpandAll()
        End Select
    End Sub
    Private Sub TreeList1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeList1.MouseDoubleClick
        Dim strKey As String
        Dim strString As String = String.Empty
        strKey = TreeList1.FocusedNode.GetValue("M_KEY")

        Dim BBC As New BroadCastFactoryControler()
        Dim MMM As New List(Of BroadCastFactoryInfo)
        MMM = BBC.BroadCastBrigade_GetListItem(strKey, "USER")
        If MMM.Count > 0 Then
            For i As Integer = 0 To MMM.Count - 1
                If i <> MMM.Count - 1 Then
                    strString = strString + MMM(i).U_Name + ","
                Else
                    strString = strString + MMM(i).U_Name
                End If
            Next
            txt_Out.EditValue = String.Empty
            txt_Out.EditValue = strString
        Else
            If TreeList1.FocusedNode.GetValue("Type") = "USER" Then
                txt_Out.EditValue = String.Empty
                txt_Out.EditValue = TreeList1.FocusedNode.GetValue("U_Name")
            Else
                txt_Out.EditValue = String.Empty
            End If
        End If
        PopupContainerControl1.OwnerEdit.ClosePopup()
        Me.TreeList1.ExpandAll()
    End Sub


    Private Sub txt_Out_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Out.EditValueChanged
        Me.TreeList1.ExpandAll()
    End Sub
End Class
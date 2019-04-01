Imports LFERP.DataSetting
Public Class FrmCusterAdd
    Private _EditItem As String
    Private _EditValue As String

    Public Property EditItem() As String
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property
    Public Property EditValue() As String
        Get
            Return _EditValue
        End Get
        Set(ByVal value As String)
            _EditValue = value
        End Set
    End Property

    Private Sub FrmCusterAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dateCreateDate.Text = Format(Now, "yyyy/MM/dd")
        Select Case EditItem
            Case "Add"
                Label1.Text = Text + "--新增"
                Exit Select
            Case "Edit"
                Label1.Text = Text + "--修改"
                Me.txtCustomer.Enabled = False
                LoadDate(EditValue)
                Exit Select
            Case "Copy"
                Label1.Text = Text + "--複製"
                Me.txtCustomer.Enabled = False
                LoadDate(EditValue)
                Exit Select
            Case "View"
                Label1.Text = Text + "--查看"
                LoadDate(EditValue)
                Me.txtCustomer.Enabled = False
                Me.txtC_EngName.Enabled = False
                Me.TextEdit1.Enabled = False
                Me.TextEdit2.Enabled = False
                Me.TextEdit3.Enabled = False
                Me.TextEdit4.Enabled = False
                Me.TextEdit5.Enabled = False
                Me.dateCreateDate.Enabled = False
                Me.TextEdit10.Enabled = False
                Me.TextEdit9.Enabled = False
                Me.TextEdit8.Enabled = False
                Me.TextEdit6.Enabled = False
                Exit Select
        End Select
    End Sub

    Sub LoadDate(ByVal strCuster As String)
        Dim cuCont As New CusterControler
        Dim cuList As New List(Of CusterInfo)
        cuList = cuCont.GetCusterList(strCuster, Nothing, Nothing)
        If cuList.Count > 0 Then
            If EditItem = "Copy" Then
                Me.txtCustomer.Text = GetCusterID(cuList(0).C_CusterID)
            Else
                Me.txtCustomer.Text = cuList(0).C_CusterID
            End If
            Me.txtC_EngName.Text = cuList(0).C_EngName
            Me.TextEdit1.Text = cuList(0).C_Email
            Me.TextEdit2.Text = cuList(0).C_ChsName
            Me.TextEdit3.Text = cuList(0).C_Link
            Me.TextEdit4.Text = cuList(0).C_LinkTel
            Me.TextEdit5.Text = cuList(0).C_Fax
            Me.dateCreateDate.Text = Format(cuList(0).C_AddDate, "yyyy/MM/dd")
            Me.TextEdit10.Text = cuList(0).C_Adder1
            Me.TextEdit9.Text = cuList(0).C_Adder2
            Me.TextEdit8.Text = cuList(0).C_Adder3
            Me.TextEdit6.Text = cuList(0).C_Department
        End If
    End Sub


    Private Sub Savebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Savebutton.Click
        If CheckDate() = False Then
            Exit Sub
        End If
        Select Case EditItem
            Case "Add"
                If DateSava() = True Then
                    MsgBox("保存成功!", , "提示")
                    Me.Close()
                End If
            Case "Edit"
                If DateSava() = True Then
                    MsgBox("修改成功!", , "提示")
                    Me.Close()
                End If
            Case "Copy"
                If DateSava() = True Then
                    MsgBox("複製成功!", , "提示")
                    Me.Close()
                End If
        End Select
    End Sub
    Private Function DateSava() As Boolean
        DateSava = True
        Dim mtd As New CusterControler
        Dim cuinfo As New CusterInfo
        cuinfo.C_Email = Me.TextEdit1.Text
        cuinfo.C_EngName = Me.txtC_EngName.Text
        cuinfo.C_ChsName = Me.TextEdit2.Text
        cuinfo.C_Link = Me.TextEdit3.Text
        cuinfo.C_LinkTel = Me.TextEdit4.Text
        cuinfo.C_Fax = Me.TextEdit5.Text
        cuinfo.C_AddDate = Format(Now, "yyyy/MM/dd").ToString
        cuinfo.C_Adder1 = Me.TextEdit10.Text
        cuinfo.C_Adder2 = Me.TextEdit9.Text
        cuinfo.C_Adder3 = Me.TextEdit8.Text
        cuinfo.C_Department = Me.TextEdit6.Text
        Select Case EditItem
            Case "Add"
                cuinfo.C_CusterID = Me.txtCustomer.Text
                If mtd.Custer_Add(cuinfo) = False Then
                    MsgBox("保存失敗!", , "提示")
                    DateSava = False
                End If
            Case "Edit"
                cuinfo.C_CusterID = EditValue
                If mtd.Custer_Update(cuinfo) = False Then
                    MsgBox("修改失敗!", , "提示")
                    DateSava = False
                End If
            Case "Copy"
                cuinfo.C_CusterID = GetCusterID(Me.txtCustomer.Text.Trim)
                If mtd.Custer_Add(cuinfo) = False Then
                    MsgBox("複製失敗!", , "提示")
                    DateSava = False
                End If
        End Select
    End Function

    Function GetCusterID(ByVal Customer As String) As String
        Dim StrCust As String = String.Empty
        If InStr(Customer, "-") Then
            StrCust = Mid(Customer, 1, Customer.Length - 4)
        Else
            StrCust = Customer
        End If
        Dim mtd As New CusterControler
        Dim cuinfo As New CusterInfo
        cuinfo = mtd.Custer_GetNo(StrCust)
        If InStr(cuinfo.C_CusterID, "-") Then
            GetCusterID = Mid(cuinfo.C_CusterID, 1, cuinfo.C_CusterID.Length - 4) + "-" + Mid(CStr(CInt(Mid(cuinfo.C_CusterID, cuinfo.C_CusterID.Length - 2)) + 1001), 2)
        Else
            GetCusterID = StrCust + "-001"
        End If
        Return GetCusterID
    End Function

    Function CheckDate() As Boolean
        CheckDate = True
        If Me.txtCustomer.Text = "" Then
            MsgBox("您還沒有輸入客戶代號！", MsgBoxStyle.OkOnly, "提示")
            txtCustomer.Focus()
            CheckDate = False
            Exit Function
        End If

        If Me.txtC_EngName.Text = "" Then
            MsgBox("您還沒有輸入英名名字！", MsgBoxStyle.OkOnly, "提示")
            txtC_EngName.Focus()
            CheckDate = False
            Exit Function
        End If
        If Me.TextEdit3.Text = "" Then
            MsgBox("您還沒有輸入聯系人！", MsgBoxStyle.OkOnly, "提示")
            TextEdit3.Focus()
            CheckDate = False
            Exit Function
        End If
        If Me.TextEdit6.Text = "" Then
            MsgBox("您還沒有輸入部門！", MsgBoxStyle.OkOnly, "提示")
            TextEdit6.Focus()
            CheckDate = False
            Exit Function
        End If
    End Function


    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub txtCustomer_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.Leave
        Dim cuCont As New CusterControler
        Dim cuList As New List(Of CusterInfo)
        cuList = cuCont.GetCusterList(sender.Text, Nothing, Nothing)
        If cuList.Count > 0 Then
            txtCustomer.Text = ""
            txtCustomer.Focus()
            MsgBox("您輸入的客戶代號相同！", MsgBoxStyle.OkOnly, "提示")
            Exit Sub
        End If
    End Sub
End Class
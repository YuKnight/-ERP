Imports LFERP.DataSetting

Public Class frmDepartment_Add

    Dim dpti As New DepartmentInfo
    Dim dptc As New DepartmentControler

    Private Sub frmDepartment_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Edit = False Then
            TextEdit1.Enabled = False
            TextEdit3.Enabled = False
            TextEdit1.Text = GetNo(tempValue2)
            TextEdit3.Text = tempValue2
        Else
            TextEdit3.Text = tempValue3
            TextEdit1.Enabled = False
            TextEdit3.Enabled = False
        End If
    End Sub
    Function GetNo(ByVal PID As String) As String
        Dim i As Integer
        Dim di As New DepartmentInfo
        Dim dc As New DepartmentControler
        di = dc.Department_GetID(PID)
        If di Is Nothing Then
            GetNo = tempValue2 & "01"
        Else
            i = Len(dc.Department_GetID(PID).DPT_PID)
            Select Case i
                Case 2
                    GetNo = di.DPT_PID & Mid((CInt(Mid(di.DPT_ID, 3)) + 101), 2)
                Case 4
                    GetNo = di.DPT_PID & Mid((CInt(Mid(di.DPT_ID, 5)) + 101), 2)
                Case 6
                    GetNo = di.DPT_PID & Mid((CInt(Mid(di.DPT_ID, 7)) + 101), 2)
            End Select
        End If
    End Function

    Sub AddDepartment()
        dpti.DPT_ID = TextEdit1.Text
        dpti.DPT_Name = TextEdit2.Text
        dpti.DPT_PID = TextEdit3.Text
        If dptc.Department_Add(dpti) = True Then
            MsgBox("添加部門成功")
            tempValue = "RE"
        Else
            MsgBox("添加部門失敗，請檢查原因！")
        End If
    End Sub
    Sub EditDepartment()
        dpti.DPT_ID = TextEdit1.Text
        dpti.DPT_Name = TextEdit2.Text
        dpti.DPT_PID = TextEdit3.Text
        If dptc.Department_Update(dpti) = True Then
            MsgBox("修改部門信息成功")
            tempValue = "RE"
        Else
            MsgBox("修改部門信息失敗，請檢查原因！")
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Edit = False Then
            AddDepartment()
        Else
            EditDepartment()
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
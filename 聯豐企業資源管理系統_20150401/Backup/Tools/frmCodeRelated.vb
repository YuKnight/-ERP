Imports LFERP.Library.Material
Imports System

Public Class frmCodeRelated


    Dim mc As New MaterialController

    Private Sub frmCodeRelated_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label8.Text = "0"
    End Sub

    '主物料
    Private Sub txtMainCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMainCode.LostFocus
        Dim mi As New MaterialInfo
        mi = mc.MaterialCode_Get(txtMainCode.Text)
        If mi Is Nothing Then
            MsgBox("此物料編碼不存在!")
            Label4.Text = Nothing
            Label5.Text = Nothing
            Exit Sub
        Else
            If Mid(mi.Type3ID, 1, 2) = "20" Then

                Label4.Visible = True
                Label5.Visible = True
                Label4.Text = "名稱:" & mi.M_Name
                Label5.Text = "規格:" & mi.M_Gauge

                Dim mi1 As New MaterialSubInfo
                mi1 = mc.MaterialCodeSub_Get(txtMainCode.Text, Nothing)

                If mi1 Is Nothing Then
                Else
                    txtSubCode.Text = mi1.M_CodeSub
                    txtRatio.Text = mi1.M_Qty
                    Label8.Text = mi1.AutoID
                    Label6.Text = "名稱:" & mc.MaterialCode_Get(mi1.M_CodeSub).M_Name
                    Label7.Text = "規格:" & mc.MaterialCode_Get(mi1.M_CodeSub).M_Gauge
                End If
            Else
                MsgBox("請輸入類型為物料的物料編碼!")
                txtMainCode.Text = Nothing
                txtMainCode.Focus()

            End If

         
        End If
    End Sub
    '子物料
    Private Sub txtSubCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubCode.LostFocus
        Dim mi As New MaterialInfo
        mi = mc.MaterialCode_Get(txtSubCode.Text)
        If mi Is Nothing Then
            MsgBox("此物料編碼不存在,請輸入正確編碼!")
            Exit Sub
        Else
            Label6.Visible = True
            Label7.Visible = True
            Label6.Text = "名稱:" & mi.M_Name
            Label7.Text = "規格:" & mi.M_Gauge
        End If
    End Sub

    Private pattern As String = "^[0-9]*$"

    Private Sub txtRatio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRatio.TextChanged
        Dim m As New System.Text.RegularExpressions.Regex(pattern)
        ' 匹配正則表達式
        If m.IsMatch(txtRatio.Text) = False Then
            ' 輸入的不是數字
            Me.txtRatio.Text = Nothing
            ' textBox內容不變
            ' 將光標定位到文本框最後
            Me.txtRatio.SelectionStart = Me.txtRatio.Text.Length

        End If

    End Sub

    Sub DataNew()

        Dim objinfo As New MaterialSubInfo

        objinfo.M_Code = txtMainCode.Text
        objinfo.M_CodeSub = txtSubCode.Text
        objinfo.M_Qty = txtRatio.Text

        If mc.MaterialCodeSub_Add(objinfo) = True Then
            MsgBox("保存成功!", , "提示")
        Else
            MsgBox("保存失敗,請檢查錯誤!", , "提示")
        End If

    End Sub

    Sub DataEdit()

        Dim objinfo As New MaterialSubInfo

        objinfo.M_Code = txtMainCode.Text
        objinfo.M_CodeSub = txtSubCode.Text
        objinfo.M_Qty = txtRatio.Text

        If mc.MaterialCodeSub_Update(objinfo) = True Then
            MsgBox("保存成功!", , "提示")
        Else
            MsgBox("保存失敗,請檢查錯誤!", , "提示")
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If CInt(Label8.Text) > 0 Then
            DataEdit()
        Else
            DataNew()
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
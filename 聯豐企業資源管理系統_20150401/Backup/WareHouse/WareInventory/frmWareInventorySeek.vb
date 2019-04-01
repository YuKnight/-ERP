Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.Library.WareHouse
Imports LFERP.Library.Shared
Imports LFERP.SystemManager
Imports LFERP.DataSetting
Public Class frmWareInventorySeek


    Private Sub txtWH_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        frmWareHouseSelect.SelectWareID = ""
        tempValue3 = "500401"
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            txtWH.Text = frmWareHouseSelect.SelectWareID
        End If
    End Sub


    '@ 2012/1/12 添加年月份輸入判斷

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If tempValue4 = "50080301" Then
            If RadioButton1.Checked = True Then
                tempValue4 = ""
                Dim ds As New DataSet
                If txtWH.Text = "" Then
                    MsgBox("請選擇正確的倉庫！", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If

                Dim TC As New TempController
                Dim Ti As New TempInfo
                Ti.Str1 = "現時"
                TC.Temp2_Add(Ti)

                Dim ltc As New CollectionToDataSet
                Dim ltc1 As New CollectionToDataSet
                Dim ltc3 As New CollectionToDataSet
                Dim ltc4 As New CollectionToDataSet



                Dim pmc As New WareInventory.WareInventoryMTController
                Dim uc As New UnitController
                Dim wh As New WareHouseController


                ds.Tables.Clear()
                Dim strA As String
                strA = txtWH.Text

                If pmc.WareInventory_GetMaterial(Nothing, strA, Nothing).Count = 0 Then
                    MsgBox("當前倉庫沒有物料記錄!")
                    Exit Sub
                End If

                ltc.CollToDataSet(ds, "WareInventory", pmc.WareInventory_GetMaterial(Nothing, strA, Nothing))
                ltc1.CollToDataSet(ds, "Unit", uc.GetUnitList(Nothing))
                ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
                ltc4.CollToDataSet(ds, "Temp2", TC.Temp2_GetList(Nothing, Nothing, Nothing))


                ' PreviewRPT(ds, "rptWareInventory2", "在庫物料單價表", True, True)
                PreviewRPT1(ds, "rptWareInventory2", "在庫物料單價表", UserName, "1", True, True)

                ltc = Nothing
                ltc1 = Nothing
                ltc3 = Nothing
                ltc4 = Nothing
            End If
            If RadioButton2.Checked = True Then

                If TextEdit1.Text.Trim = "" Then
                    MsgBox("請輸入年份!", 64, "提示")
                    TextEdit1.Focus()
                    Exit Sub
                End If
                If TextEdit2.Text.Trim = "" Then
                    MsgBox("請輸入月份!", 64, "提示")
                    TextEdit2.Focus()
                    Exit Sub
                End If
                If CheckIsNum(TextEdit1.Text, True) = False Or Len(Trim(TextEdit1.Text)) <> 2 Then
                    MsgBox("輸入年份有誤，請重新輸入!", 64, "提示")
                    TextEdit1.Focus()
                    TextEdit1.SelectAll()
                    Exit Sub
                ElseIf CheckIsNum(TextEdit2.Text, True) = False Or (Len(Trim(TextEdit2.Text)) = 1 And Trim(TextEdit2.Text) = "0") Or Len(Trim(TextEdit2.Text)) > 2 Then
                    MsgBox("輸入月份有誤，請重新輸入!", 64, "提示")
                    TextEdit2.Focus()
                    TextEdit2.SelectAll()
                    Exit Sub
                ElseIf Trim(TextEdit2.Text) > 12 Or (Len(Trim(TextEdit2.Text)) = 2 And Trim(TextEdit2.Text) = "00") Then
                    MsgBox("輸入月份有誤，請重新輸入!", 64, "提示")
                    TextEdit2.Focus()
                    TextEdit2.SelectAll()
                    Exit Sub
                End If
                Dim strx, odate1, odate2 As String
                If Len(TextEdit2.Text) = 1 Then
                    strx = "0" & Mid(TextEdit2.Text, 1, 1)
                Else
                    strx = Mid(TextEdit2.Text, 1, 2)
                End If
                odate1 = Label4.Text & TextEdit1.Text & "/" & TextEdit2.Text & "/01"
                odate2 = Label4.Text & TextEdit1.Text & "/" & TextEdit2.Text & "/15"

                tempValue4 = ""
                Dim ds As New DataSet
                If txtWH.Text = "" Then
                    MsgBox("請選擇正確的倉庫！", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If

                Dim TC As New TempController
                Dim Ti As New TempInfo
                Ti.Str1 = Label4.Text & TextEdit1.Text & "/" & TextEdit2.Text & "/01"
                TC.Temp2_Add(Ti)

                Dim ltc As New CollectionToDataSet
                Dim ltc1 As New CollectionToDataSet
                Dim ltc3 As New CollectionToDataSet
                Dim ltc4 As New CollectionToDataSet


                Dim pmc As New WareInventory.WareInventoryMTController
                Dim uc As New UnitController
                Dim wh As New WareHouseController



                Dim strA As String
                strA = txtWH.Text

                If pmc.WareInventoryBackup_GetMaterial(Nothing, txtWH.Text, Nothing, odate1, odate2).Count = 0 Then
                    MsgBox("當前倉庫無指定年月在庫物料記錄,請確認是否備份!")
                    Exit Sub
                End If

                ltc.CollToDataSet(ds, "WareInventory", pmc.WareInventoryBackup_GetMaterial(Nothing, txtWH.Text, Nothing, odate1, odate2))
                ltc1.CollToDataSet(ds, "Unit", uc.GetUnitList(Nothing))
                ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
                ltc4.CollToDataSet(ds, "Temp2", TC.Temp2_GetList(Nothing, Nothing, Nothing))

                PreviewRPT1(ds, "rptWareInventory2", "在庫物料單價表", UserName, "1", True, True)


                ltc = Nothing
                ltc1 = Nothing
                ltc3 = Nothing
                ltc4 = Nothing
            End If
        Else
            tempValue = txtWH.Text

            If radBasic.Checked = True Then
                tempValue8 = "基本表"
            ElseIf radCheckUse.Checked = True Then
                tempValue8 = "盤點用表"
            End If

            If RadioButton2.Checked = True Then

                If TextEdit1.Text.Trim = "" Then
                    MsgBox("請輸入年份!", 64, "提示")
                    TextEdit1.Focus()
                    Exit Sub
                End If
                If TextEdit2.Text.Trim = "" Then
                    MsgBox("請輸入月份!", 64, "提示")
                    TextEdit2.Focus()
                    Exit Sub
                End If
                If CheckIsNum(TextEdit1.Text, True) = False Or Len(Trim(TextEdit1.Text)) <> 2 Then
                    MsgBox("輸入年份有誤，請重新輸入!", 64, "提示")
                    TextEdit1.Focus()
                    TextEdit1.SelectAll()
                    Exit Sub
                ElseIf CheckIsNum(TextEdit2.Text, True) = False Or (Len(Trim(TextEdit2.Text)) = 1 And Trim(TextEdit2.Text) = "0") Or Len(Trim(TextEdit2.Text)) > 2 Then
                    MsgBox("輸入月份有誤，請重新輸入!", 64, "提示")
                    TextEdit2.Focus()
                    TextEdit2.SelectAll()
                    Exit Sub
                ElseIf Trim(TextEdit2.Text) > 12 Or (Len(Trim(TextEdit2.Text)) = 2 And Trim(TextEdit2.Text) = "00") Then
                    MsgBox("輸入月份有誤，請重新輸入!", 64, "提示")
                    TextEdit2.Focus()
                    TextEdit2.SelectAll()
                    Exit Sub
                End If

                tempValue5 = Label4.Text & TextEdit1.Text & "/" & TextEdit2.Text & "/01"
                tempValue6 = Label4.Text & TextEdit1.Text & "/" & TextEdit2.Text & "/01"
                tempValue7 = Label4.Text & TextEdit1.Text & "/" & TextEdit2.Text & "/15"
            End If

            If RadioButton1.Checked = True Then tempValue5 = "現時"
            isClickButton = True
            Me.Close()
        End If



    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextEdit1.Enabled = True
            TextEdit2.Enabled = True
            TextEdit1.Focus()
        Else
            TextEdit1.Enabled = False
            TextEdit2.Enabled = False
            TextEdit1.Text = ""
            TextEdit2.Text = ""
        End If
    End Sub

    Private Sub frmWareInventorySeek_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        isClickButton = False
        If tempValue4 = "50080301" Then
            radBasic.Visible = False
            radCheckUse.Visible = False
        End If

    End Sub

    Private Sub radCheckUse_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radCheckUse.CheckedChanged
        If radCheckUse.Checked = True Then
            RadioButton1.Checked = True
            RadioButton2.Enabled = False
        End If
    End Sub

    Private Sub radBasic_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles radBasic.CheckedChanged
        If radBasic.Checked = True Then
            RadioButton2.Enabled = True
        End If
    End Sub

    Private Sub txtWH_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWH.EditValueChanged

    End Sub
End Class
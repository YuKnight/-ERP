Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareOut
Imports LFERP.Library.Material
Imports LFERP.SystemManager.SystemUser
Imports LFERP.DataSetting
Imports LFERP.SystemManager

Public Class frmWareOutRptSelect
    Dim rptType As String
    Dim ds As New DataSet

    Private Sub txtWH_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtWH.ButtonClick
        frmWareHouseSelect.blnSelectParentNode = True
        frmWareHouseSelect.SelectWareID = ""
        frmWareHouseSelect.StartPosition = FormStartPosition.Manual
        frmWareHouseSelect.Left = MDIMain.tvModule.Width + 8 + Me.txtWH.Left + Me.Left
        frmWareHouseSelect.Top = Me.txtWH.Top + Me.txtWH.Height + Me.Top + 92
        tempValue3 = rptType
        frmWareHouseSelect.ShowDialog()
        If frmWareHouseSelect.SelectWareID = "" Then
        Else
            txtWH.Text = frmWareHouseSelect.SelectWareID
            '      txtWH.Enabled = False
        End If

    End Sub

    Private Sub ButtonEdit2_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ButtonEdit2.ButtonClick
        frmDepartmentSelect.DptID = ""
        frmDepartmentSelect.DptName = ""
        frmDepartmentSelect.blnSelectParentNode = True
        frmDepartmentSelect.StartPosition = FormStartPosition.Manual
        frmDepartmentSelect.Left = MDIMain.tvModule.Width + 8 + Me.ButtonEdit2.Left + Me.Left
        frmDepartmentSelect.Top = Me.ButtonEdit2.Top + Me.ButtonEdit2.Height + Me.Top + 92
        frmDepartmentSelect.ShowDialog()




        If frmDepartmentSelect.DptID = "" Then

        Else

            If rptType <> "50080501" Then ButtonEdit2.Text = frmDepartmentSelect.DptID
            If rptType = "50080501" Then ButtonEdit2.Text = Mid(frmDepartmentSelect.DptID, 1, 6)


        End If

        '------------------------------------------------------------------------

        '' ''2013-1-7
        ' ''Dim pmws As New PermissionModuleWarrantSubController
        ' ''Dim pmwiL As List(Of PermissionModuleWarrantSubInfo)

        ' ''pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "500107")
        ' ''If pmwiL.Count > 0 Then
        ' ''    If pmwiL.Item(0).PMWS_Value <> "" Then
        ' ''        frmDepartmentSelect1.DptID = ""
        ' ''        frmDepartmentSelect1.DptName = ""
        ' ''        'frmDepartmentSelect1.blnSelectParentNode = True
        ' ''        frmDepartmentSelect1.StartPosition = FormStartPosition.Manual
        ' ''        frmDepartmentSelect1.Left = MDIMain.tvModule.Width + 8 + Me.ButtonEdit2.Left + Me.Left
        ' ''        frmDepartmentSelect1.Top = Me.ButtonEdit2.Top + Me.ButtonEdit2.Height + Me.Top + 92
        ' ''        frmDepartmentSelect1.Height = 245
        ' ''        frmDepartmentSelect1.Width = 213

        ' ''        frmDepartmentSelect1.DptID = ""
        ' ''        frmDepartmentSelect1.DptName = ""
        ' ''        tempValue = pmwiL.Item(0).PMWS_Value

        ' ''        frmDepartmentSelect1.ShowDialog()
        ' ''        If frmDepartmentSelect1.DptID = "" Then
        ' ''        Else
        ' ''            If rptType <> "50080501" Then ButtonEdit2.Text = frmDepartmentSelect1.DptID
        ' ''            If rptType = "50080501" Then ButtonEdit2.Text = Mid(frmDepartmentSelect1.DptID, 1, 6)
        ' ''        End If

        ' ''        Exit Sub

        ' ''    End If
        ' ''End If
        '' ''------------------------------------------------------------------------
        ' ''frmDepartmentSelect.DptID = ""
        ' ''frmDepartmentSelect.DptName = ""
        ' ''frmDepartmentSelect.blnSelectParentNode = True
        ' ''frmDepartmentSelect.StartPosition = FormStartPosition.Manual
        ' ''frmDepartmentSelect.Left = MDIMain.tvModule.Width + 8 + Me.ButtonEdit2.Left + Me.Left
        ' ''frmDepartmentSelect.Top = Me.ButtonEdit2.Top + Me.ButtonEdit2.Height + Me.Top + 92
        ' ''frmDepartmentSelect.ShowDialog()

        ' ''If frmDepartmentSelect.DptID = "" Then

        ' ''Else

        ' ''    If rptType <> "50080501" Then ButtonEdit2.Text = frmDepartmentSelect.DptID
        ' ''    If rptType = "50080501" Then ButtonEdit2.Text = Mid(frmDepartmentSelect.DptID, 1, 6)


        ' ''End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    '@ 2012/1/12 添加年月份輸入判斷
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        'If Trim(TextEdit1.Text = "") Then
        '    MsgBox("請輸入年份!", 64, "提示")
        '    TextEdit1.Focus()
        '    Exit Sub
        'ElseIf Trim(TextEdit2.Text = "") Then
        '    MsgBox("請輸入月份!", 64, "提示")
        '    TextEdit2.Focus()
        '    Exit Sub
        'ElseIf Trim(txtWH.Text = "") Then
        '    MsgBox("請選擇倉庫!", 64, "提示")
        '    txtWH.Focus()
        '    Exit Sub
        'ElseIf Trim(ButtonEdit2.Text = "") Then
        '    MsgBox("請選擇部門!", 64, "提示")
        '    ButtonEdit2.Focus()
        '    Exit Sub
        'ElseIf CheckIsNum(TextEdit1.Text, True) = False Or Len(Trim(TextEdit1.Text)) <> 2 Then
        '    MsgBox("輸入年份有誤，請重新輸入!", 64, "提示")
        '    TextEdit1.Focus()
        '    TextEdit1.SelectAll()
        '    Exit Sub
        'ElseIf CheckIsNum(TextEdit2.Text, True) = False Or (Len(Trim(TextEdit2.Text)) = 1 And Trim(TextEdit2.Text) = "0") Or Len(Trim(TextEdit2.Text)) > 2 Then
        '    MsgBox("輸入月份有誤，請重新輸入!", 64, "提示")
        '    TextEdit2.Focus()
        '    TextEdit2.SelectAll()
        '    Exit Sub
        'ElseIf Trim(TextEdit2.Text) > 12 Or (Len(Trim(TextEdit2.Text)) = 2 And Trim(TextEdit2.Text) = "00") Then
        '    MsgBox("輸入月份有誤，請重新輸入!", 64, "提示")
        '    TextEdit2.Focus()
        '    TextEdit2.SelectAll()
        '    Exit Sub
        'End If

        'Dim strx As String
        'If TextEdit2.Text <> "" And TextEdit1.Text <> "" Then
        '    If Len(TextEdit2.Text) = 1 Then
        '        strx = "0" & Mid(TextEdit2.Text, 1, 1)
        '    Else
        '        strx = Mid(TextEdit2.Text, 1, 2)
        '    End If
        '    Label8.Text = "WO" & TextEdit1.Text & strx
        'End If

        If Trim(txtWH.Text = "") Then
            MsgBox("請選擇倉庫!", 64, "提示")
            txtWH.Focus()
            Exit Sub
        End If

        Label8.Text = "WO" & Format(CDate(YearDate.EditValue), "yyMM")


        Dim strType3IDGridLookUp As String = ""

        If Type3IDGridLookUp.EditValue = "*" Then
            strType3IDGridLookUp = Nothing
        Else
            strType3IDGridLookUp = Type3IDGridLookUp.EditValue
        End If

        If rptType = "50080201" Then
            '部門領料價值明細
            Dim ds As New DataSet
            Dim ltc As New CollectionToDataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc3 As New CollectionToDataSet
            Dim ltc4 As New CollectionToDataSet
            Dim ltc5 As New CollectionToDataSet



            Dim uc As New MaterialController
            Dim wh As New WareHouseController
            Dim wo As New WareOutController
            Dim uit As New UnitController
            Dim uc2 As New DepartmentControler

            ds.Tables.Clear()

            If wo.WareOut_Getlist5(Label8.Text, Nothing, Nothing, Nothing, txtWH.Text, ButtonEdit2.Text, Nothing, Nothing, Nothing, True, Nothing, strType3IDGridLookUp).Count = 0 Then
                MsgBox("當前倉庫此月份無此部門領料記錄!")
                Exit Sub
            End If
           
            ltc.CollToDataSet(ds, "Department", uc2.Department_GetList(Nothing, Nothing, Nothing))
            ltc1.CollToDataSet(ds, "MaterialPrice", uc.MaterialPrice_GetList(Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            ltc4.CollToDataSet(ds, "WareOut", wo.WareOut_Getlist5(Label8.Text, Nothing, Nothing, Nothing, txtWH.Text, ButtonEdit2.Text, Nothing, Nothing, Nothing, True, Nothing, strType3IDGridLookUp))
            ltc5.CollToDataSet(ds, "Unit", uit.GetUnitList(Nothing))
            If RadioButton1.Checked = True Then
                PreviewRPT(ds, "rptWareOutPrice", "部門領料價值明細", True, True)
            ElseIf RadioButton2.Checked = True Then
                PreviewRPT(ds, "rptWareOutPrice4", "部門領料價值明細", True, True)
            End If
            ltc = Nothing
            ltc1 = Nothing
            ltc3 = Nothing
            ltc4 = Nothing
            ltc5 = Nothing
            Exit Sub
        End If

        If rptType = "50080401" Then
            '部門領料記錄
            Dim ds As New DataSet
            Dim ltc As New CollectionToDataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc3 As New CollectionToDataSet
            Dim ltc4 As New CollectionToDataSet
            Dim ltc5 As New CollectionToDataSet


            Dim uc As New MaterialController
            Dim wh As New WareHouseController
            Dim wo As New WareOutController
            Dim uit As New UnitController
            Dim uc2 As New DepartmentControler

            ds.Tables.Clear()

            If wo.WareOut_Getlist5(Label8.Text, Nothing, Nothing, Nothing, txtWH.Text, ButtonEdit2.Text, Nothing, Nothing, Nothing, True, Nothing, strType3IDGridLookUp).Count = 0 Then
                MsgBox("當前倉庫此月份無此部門領料記錄!")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "Department", uc2.Department_GetList(Nothing, Nothing, Nothing))
            ltc1.CollToDataSet(ds, "MaterialCode", uc.MaterialCode_GetList(Nothing))
            ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            ltc4.CollToDataSet(ds, "WareOut", wo.WareOut_Getlist5(Label8.Text, Nothing, Nothing, Nothing, txtWH.Text, ButtonEdit2.Text, Nothing, Nothing, Nothing, True, Nothing, strType3IDGridLookUp))
            ltc5.CollToDataSet(ds, "Unit", uit.GetUnitList(Nothing))
            PreviewRPT(ds, "rptWareOutPrice2", "部門領料記錄", True, True)

            ltc = Nothing
            '  ltc1 = Nothing
            ltc3 = Nothing
            ltc4 = Nothing
            ltc5 = Nothing
            Exit Sub
        End If

        If rptType = "50080501" Then
            '部門領料金額匯總
            Dim ds As New DataSet
            Dim ltc As New CollectionToDataSet
            Dim ltc1 As New CollectionToDataSet
            Dim ltc3 As New CollectionToDataSet
            Dim ltc4 As New CollectionToDataSet
            Dim ltc5 As New CollectionToDataSet



            Dim uc As New MaterialController
            Dim wh As New WareHouseController
            Dim wo As New WareOutController
            Dim uit As New UnitController
            Dim uc2 As New DepartmentControler

            ds.Tables.Clear()

            If wo.WareOut_Getlist5(Label8.Text, Nothing, Nothing, Nothing, txtWH.Text, ButtonEdit2.Text, Nothing, Nothing, Nothing, True, Nothing, strType3IDGridLookUp).Count = 0 Then
                MsgBox("當前倉庫此月份無此部門領料記錄!")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "Department", uc2.Department_GetList(Nothing, Nothing, Nothing))
            ltc1.CollToDataSet(ds, "MaterialPrice", uc.MaterialPrice_GetList(Nothing, Nothing, Nothing))
            ltc3.CollToDataSet(ds, "WareHouse", wh.WareHouse_GetList(Nothing))
            ltc4.CollToDataSet(ds, "WareOut", wo.WareOut_Getlist5(Label8.Text, Nothing, Nothing, Nothing, txtWH.Text, ButtonEdit2.Text, Nothing, Nothing, Nothing, True, Nothing, strType3IDGridLookUp))
            ltc5.CollToDataSet(ds, "Unit", uit.GetUnitList(Nothing))

            PreviewRPT(ds, "rptWareOutPrice3", "部門領料金額匯總", True, True)
            ltc = Nothing
            ltc1 = Nothing
            ltc3 = Nothing
            ltc4 = Nothing
            ltc5 = Nothing
            Exit Sub
        End If
        tempValue3 = ""

        Me.Close()
    End Sub

    Private Sub frmWareOutRptSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rptType = tempValue3
        If rptType = "50080201" Then
            Label10.Text = "部門領料價值明細"
            RadioButton1.Visible = True
            RadioButton2.Visible = True
        End If

        If rptType = "50080401" Then Label10.Text = "部門領料記錄"
        If rptType = "50080501" Then Label10.Text = "部門領料金額匯總"
        tempValue3 = ""

        YearDate.EditValue = Format(Now, "yyyy年MM月")

        Createtable()

    End Sub

    Private Sub txtWH_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtWH.GotFocus
        'If TextEdit1.Text = "" Or TextEdit2.Text = "" Then
        '    MsgBox("請先選擇月份!", MsgBoxStyle.OkOnly)
        '    Exit Sub
        'End If
        ''Dim strx As String
        ''If TextEdit2.Text <> "" And TextEdit1.Text <> "" Then
        ''    If Len(TextEdit2.Text) = 1 Then
        ''        strx = "0" & Mid(TextEdit2.Text, 1, 1)
        ''    Else
        ''        strx = Mid(TextEdit2.Text, 1, 2)
        ''    End If
        ''    Label8.Text = "WO" & TextEdit1.Text & strx
        ''End If
    End Sub

    Private Sub ButtonEdit2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonEdit2.GotFocus
        'Dim strx As String
        'If TextEdit2.Text <> "" And TextEdit1.Text <> "" Then
        '    If Len(TextEdit2.Text) = 1 Then
        '        strx = "0" & Mid(TextEdit2.Text, 1, 1)
        '    Else
        '        strx = Mid(TextEdit2.Text, 1, 2)
        '    End If
        '    Label8.Text = "WO" & TextEdit1.Text & strx
        'End If
    End Sub


    Private Sub YearDate_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearDate.EditValueChanged
        If YearDate.EditValue Is Nothing Then
            Exit Sub
        Else
        End If
        Label8.Text = "WO" & Format(CDate(YearDate.EditValue), "yyMM")
    End Sub

    Sub Createtable()
        With ds.Tables.Add("Type3IDName")
            .Columns.Add("Type3ID", GetType(String))
            .Columns.Add("Type3Name", GetType(String))
        End With

        Type3IDGridLookUp.Properties.ValueMember = "Type3ID"
        Type3IDGridLookUp.Properties.DisplayMember = "Type3Name"
        Type3IDGridLookUp.Properties.DataSource = ds.Tables("Type3IDName")


        Dim mc As New MaterialTypeController
        Dim ml As New List(Of MaterialTypeInfo3)

        ml = mc.MaterialType3_GetList(Nothing, Nothing, Nothing)

        Dim i As Integer
        If ml.Count > 0 Then
        Else
            Exit Sub
        End If

        Dim row As DataRow
        row = ds.Tables("Type3IDName").NewRow
        row("Type3ID") = "*"
        row("Type3Name") = "全部"
        ds.Tables("Type3IDName").Rows.Add(row)

        For i = 0 To ml.Count - 1
            Dim row1 As DataRow
            row1 = ds.Tables("Type3IDName").NewRow
            row1("Type3ID") = ml(i).Type3ID
            row1("Type3Name") = ml(i).Type3Name
            ds.Tables(0).Rows.Add(row1)
        Next

        Type3IDGridLookUp.EditValue = "*"

    End Sub

    Private Sub ButtonEdit2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit2.EditValueChanged

    End Sub
End Class
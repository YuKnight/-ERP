Imports LFERP.Library.ProductionKaiLiao
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionMaterial


Public Class frmLoadKaiLiao

    Dim pki As List(Of ProductionKaiLiaoInfo)
    Dim pkc As New ProductionKaiLiaoControl

    Dim strQty As Single
    Dim strRest As Single
    Dim strM_Code As String
    Dim strProType, strCode, strType As String

    Private Sub frmLoadKaiLiao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label14.Text = tempValue5
        tempValue5 = ""
        Me.Height = 75
        Me.Width = 390
        G1.Height = 49
        G1.Width = 380
        TextEdit1.Text = ""
        txtQty.Text = ""
        txtTheroy.Text = ""
        txtActual.Text = ""
        cmdInsert.Visible = False
        cmdQuit.Visible = False
        'cmdExit.Visible = True
        TextEdit1.Select()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click


        pki = pkc.ProductionKaiLiao_GetList(TextEdit1.Text, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing)
        If pki.Count = 0 Then
            MsgBox("不存在此領料單號,請重新輸入!")
            TextEdit1.Text = Nothing
            Exit Sub
        Else

            Label9.Text = pki(0).C_Weight  '開料重量
            strM_Code = pki(0).M_Code

            If pki(0).M_Unit = "KG" Or pki(0).M_Unit = "公斤" Or pki(0).M_Unit = "千克" Or pki(0).M_Unit = "斤" Or pki(0).M_Unit = "Catty" Or pki(0).M_Unit = "t" Or pki(0).M_Unit = "吨" Or pki(0).M_Unit = "條" Or pki(0).M_Unit = "Bar" Or pki(0).M_Unit = "支" Then

                If pki(0).M_Unit = "條" Or pki(0).M_Unit = "Bar" Or pki(0).M_Unit = "支" Then
                    Label6.Text = "條"
                    Label7.Text = "條"
                    Label10.Text = "條"
                    Label12.Text = "條"
                End If

                Dim ppi As List(Of ProductionKaiLiaoInfo)
                ppi = pkc.KaiLiaoManagement_GetList(Nothing, Nothing, Nothing, TextEdit1.Text, Nothing, "原材料", Nothing, Nothing, True)

                If ppi.Count = 0 Then

                    Me.Height = 424
                    Me.Width = 523
                    G1.Height = 148
                    'cmdExit.Visible = False
                    cmdInsert.Visible = True
                    cmdQuit.Visible = True
                    txtQty.Select()
                    Dim pmi As List(Of ProcessMainInfo)
                    Dim pmc As New ProcessMainControl

                    strProType = pki(0).Pro_Type
                    strCode = pki(0).PM_M_Code
                    strType = pki(0).PM_Type

                    pmi = pmc.ProcessMain_GetList(Nothing, strCode, strProType, strType, Nothing, Nothing)

                    If pmi.Count = 0 Then
                        MsgBox("不存在此類型的工藝流程!")
                        Exit Sub
                    Else
                        strQty = pmi(0).Pro_Rate
                    End If

                Else
                    MsgBox("此開料單號已結單,不允許再開料!")
                    Exit Sub
                End If

                Grid.DataSource = pkc.KaiLiaoManagement_GetList(Nothing, Nothing, Nothing, TextEdit1.Text, Nothing, "原材料", Nothing, Nothing, Nothing)

                If GridView1.RowCount = 0 Then
                    strRest = CSng(Label9.Text)
                Else
                    Dim j As Integer

                    Dim account As Single

                    For j = 0 To GridView1.RowCount - 1

                        account = account + GridView1.GetRowCellValue(j, "KL_ActualWeight")

                    Next

                    strRest = CSng(Label9.Text) - account

                End If
                Label13.Text = strRest


            Else
                If pki(0).C_ReCheck = True Then
                    MsgBox("此開料單已被記錄,請重新輸入")
                    Exit Sub
                Else

                    If pkc.KaiLiaoManagement_GetList(Nothing, Nothing, Nothing, TextEdit1.Text, Nothing, "配件", Nothing, Nothing, True).Count > 0 Then
                        MsgBox("此開料單號已結單,不允許再開料!")
                        Exit Sub
                    End If

                    ''－－－－－－－－－－－－－－－－－－－－－
                    'Dim pi As New ProductionKaiLiaoInfo

                    'pi.KL_NO = TextEdit1.Text
                    'pi.M_Code = pki(0).M_Code
                    'pi.M_Type = "配件"
                    'pi.KL_Qty = pki(0).C_Qty '開料數量
                    'pi.KL_TheoryWeight = 0
                    'pi.KL_ActualWeight = 0
                    'pi.KL_Action = InUserID
                    'pi.KL_Date = Format(Now, "yyyy/MM/dd")
                    'pi.KL_Check = CheckEdit1.Checked

                    'pkc.KaiLiaoManagement_Add(pi)
                    ''－－－－－－－－－－－－－－－－－－－－－
                    'On Error Resume Next
                    Edit = False
                    Dim fr As frmProductionFieldCodeIn
                    'For Each fr In MDIMain.MdiChildren
                    '    If TypeOf fr Is frmProductionFieldCodeIn Then
                    '        fr.Activate()
                    '        Exit Sub
                    '    End If
                    'Next
                    fr = New frmProductionFieldCodeIn
                    tempValue = "CodeIn"
                    tempValue3 = TextEdit1.Text  ''開料單號
                    tempValue2 = "PT03"
                    tempValue7 = "1"
                    tempCode = 1
                    tempValue5 = Label14.Text  '當前操作部門信息
                    tempValue10 = "配件"
                    fr.MdiParent = MDIMain
                    fr.WindowState = FormWindowState.Maximized
                    fr.Show()
                    Me.Close()
                End If
            End If

        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub TextEdit1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextEdit1.KeyPress

        If e.KeyChar = Chr(13) Then

            cmdSave_Click(Nothing, Nothing)

        End If
    End Sub

    Private Sub cmdQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuit.Click
        Me.Close()
    End Sub

    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        Dim pi As New ProductionKaiLiaoInfo

        If CSng(txtActual.Text) > Label13.Text Then
            MsgBox("當前開料數量大於此開料單中剩餘數量,請重新輸入!")
            Exit Sub
        End If

        If Len(txtActual.Text.Trim) = 0 Then
            MsgBox("請輸入實際用量!")
            Exit Sub
        End If

        'pi.KL_NO = TextEdit1.Text
        'pi.M_Code = strM_Code
        'pi.M_Type = "原材料"
        'pi.KL_Qty = txtQty.Text
        'pi.KL_TheoryWeight = txtTheroy.Text
        'pi.KL_ActualWeight = txtActual.Text
        'pi.KL_Action = InUserID
        'pi.KL_Date = Format(Now, "yyyy/MM/dd")
        'pi.KL_Check = CheckEdit1.Checked

        'If pkc.KaiLiaoManagement_Add(pi) = True Then

        Grid.DataSource = pkc.KaiLiaoManagement_GetList(Nothing, Nothing, Nothing, TextEdit1.Text, Nothing, "原材料", Nothing, Nothing, Nothing)

        ''------------------------------------------------記錄生產開料后實際生產部門的領料記錄(區別于倉庫領料--便於計算實際的損耗狀態信息)
        'Dim pmi As List(Of ProductionMaterialInfo)
        'Dim pmi1 As New ProductionMaterialInfo
        'Dim pmc As New ProductionMaterialControl

        'pmi = pmc.ProductionMaterial_GetList(strProType, strCode, strType, strM_Code)

        'Dim MaterialQty As Single
        'If pmi.Count = 0 Then
        '    MaterialQty = 0
        'Else
        '    MaterialQty = pmi(0).M_Qty
        'End If

        'pmi1.Pro_Type = strProType
        'pmi1.PM_M_Code = strCode
        'pmi1.PM_Type = strType
        'pmi1.M_Code = strM_Code
        'pmi1.M_Qty = MaterialQty - CSng(txtActual.Text)

        'pmc.UpdateProductionMaterialQty(pmi1)   '變更當前實際的領料結餘數

        ''------------------------------------------------
        'On Error Resume Next
        Edit = False
        Dim fr As frmProductionFieldCodeIn
        'For Each fr In MDIMain.MdiChildren
        '    If TypeOf fr Is frmProductionFieldCodeIn Then
        '        fr.Activate()
        '        Exit Sub
        '    End If
        'Next
        fr = New frmProductionFieldCodeIn
        tempValue = "CodeIn"
        tempValue3 = TextEdit1.Text  ''開料單號
        tempValue7 = "2"
        tempValue2 = "PT03"
        tempValue6 = txtQty.Text
        tempValue5 = Label14.Text  '當前操作部門信息
        tempValue8 = txtActual.Text '記錄當前輸入重量
        tempValue9 = txtTheroy.Text '理論使用數量
        tempValue11 = Label6.Text   '單位

        If CheckEdit1.Checked = True Then
            tempCode = 1 '是否結單
        Else
            tempCode = 0 '是否結單
        End If

        tempValue10 = "原材料"
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
        Me.Close()
        '--------------------------------------------------

        'Else
        'MsgBox("開料失敗請檢查原因!")
        'Exit Sub
        'End If


    End Sub

    '@ 2012/1/5修改為用正則表達式判斷輸入的是否為數字
    Private Sub txtQty_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyUp

        Dim m As New System.Text.RegularExpressions.Regex("^[1-9]+\d*$")  '顯示正整數,正整數正則表達式

        If m.IsMatch(txtQty.Text) = True Then

            Dim strint As Single

            strint = txtQty.Text / strQty

            txtTheroy.Text = Format(strint, "0.00")

        Else
            txtQty.Text = ""
            Exit Sub
        End If
    End Sub

    '只能輸入大於的數值
    Private Sub txtActual_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtActual.KeyUp

        Dim m As New System.Text.RegularExpressions.Regex("^+?(\d+(\.\d*)?|\.\d+)$")  '顯示整數,正浮點數正則表達式

        If m.IsMatch(txtActual.Text) = True Then

            If CSng(txtActual.Text) > Label9.Text Then
                MsgBox("當前實際開料用料不能大於總開料數量！")
                txtActual.Text = Nothing
                Exit Sub
            End If

        Else

            txtActual.Text = Nothing
            Exit Sub
        End If
    End Sub
End Class
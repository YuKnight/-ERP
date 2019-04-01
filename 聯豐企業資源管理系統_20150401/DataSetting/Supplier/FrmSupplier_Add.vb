Imports LFERP.DataSetting
Public Class FrmSupplier_Add

    Dim CheckDateStr As String
    Dim S_CheckActionStr As String

    Private Sub FrmSupplier_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        LoadSuppliersType()
        LoadCurrency()
        If MTypeName = "SupplierAddEdit" Then
            SimpleButton3.Enabled = False
            Select Case Edit
                Case False
                    Me.Text = "供應商新增"

                Case True
                    Me.Text = "供應商修改"

                    LoadSuppliers(tempValue)
            End Select
        End If

        If MTypeName = "SupplierCheck" Then
            Me.Text = "供應商審核"
            LoadSuppliers(tempValue)
            SimpleButton1.Enabled = False
            CheckBox1.Enabled = True
            txtDai.Enabled = True

            GridLookUpEdit1.Enabled = False
            ComboBoxEdit1.Enabled = False
            TextEdit2.Enabled = False
            TextEdit3.Enabled = False
            TextEdit6.Enabled = False
            TextEdit7.Enabled = False
            TextEdit8.Enabled = False
            TextEdit9.Enabled = False
            TextEdit10.Enabled = False
            TextEdit17.Enabled = False
            TextEdit16.Enabled = False
            TextEdit15.Enabled = False
            TextEdit14.Enabled = False
            TextEdit13.Enabled = False
            TextEdit23.Enabled = False
            TextEdit22.Enabled = False
            TextEdit21.Enabled = False
            TextEdit20.Enabled = False
            TextEdit19.Enabled = False
            PopupContainerEdit1.Enabled = False
            MemoEdit1.Enabled = False
            MemoEdit2.Enabled = False
            MemoEdit3.Enabled = False
            MemoEdit4.Enabled = False
        End If

        '@ 2012/7/5 添加　終審功能
        If MTypeName = "SupplierReCheck" Then
            Me.Text = "供應商終審"
            LoadSuppliers(tempValue)
            SimpleButton1.Enabled = False
            CheckBox1.Enabled = False
            SimpleButton3.Enabled = False
            btnReCheck.Visible = True
            chkReCheck.Visible = True

            If chkReCheck.Checked = True Then
                txtDai.Properties.Items.RemoveAt(0)
            End If

            GridLookUpEdit1.Enabled = False
            ComboBoxEdit1.Enabled = False
            TextEdit2.Enabled = False
            TextEdit3.Enabled = False
            TextEdit6.Enabled = False
            TextEdit7.Enabled = False
            TextEdit8.Enabled = False
            TextEdit9.Enabled = False
            TextEdit10.Enabled = False
            TextEdit17.Enabled = False
            TextEdit16.Enabled = False
            TextEdit15.Enabled = False
            TextEdit14.Enabled = False
            TextEdit13.Enabled = False
            TextEdit23.Enabled = False
            TextEdit22.Enabled = False
            TextEdit21.Enabled = False
            TextEdit20.Enabled = False
            TextEdit19.Enabled = False
            PopupContainerEdit1.Enabled = False
            MemoEdit1.Enabled = False
            MemoEdit2.Enabled = False
            MemoEdit3.Enabled = False
            MemoEdit4.Enabled = False
        End If

        If MTypeName = "SupplierView" Then
            Me.Text = "供應商查看"
            LoadSuppliers(tempValue)
            SimpleButton1.Enabled = False
            SimpleButton3.Enabled = False
            btnReCheck.Visible = True
            btnReCheck.Enabled = False
            chkReCheck.Visible = True
            chkReCheck.Enabled = False
            txtDai.Enabled = False
            GridLookUpEdit1.Enabled = False
            ComboBoxEdit1.Enabled = False
            TextEdit2.Enabled = True
            TextEdit3.Enabled = False
            TextEdit6.Enabled = True
            TextEdit7.Enabled = True
            TextEdit8.Enabled = True
            TextEdit9.Enabled = True
            TextEdit10.Enabled = True
            TextEdit17.Enabled = False
            TextEdit16.Enabled = False
            TextEdit15.Enabled = False
            TextEdit14.Enabled = False
            TextEdit13.Enabled = False
            TextEdit23.Enabled = False
            TextEdit22.Enabled = False
            TextEdit21.Enabled = False
            TextEdit20.Enabled = False
            TextEdit19.Enabled = False
            PopupContainerEdit1.Enabled = False
            MemoEdit1.Enabled = False
            MemoEdit2.Enabled = True
            MemoEdit3.Enabled = False
            MemoEdit4.Enabled = False
        End If
        tempValue = ""

    End Sub

    ''' <summary>
    ''' 載入供應商類型
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadSuppliersType()
        Dim mc As New SuppliersTypeControler
        'gluCuster.Properties.DisplayMember = "S_TypeID"
        'gluCuster.Properties.ValueMember = "S_TypeID"
        TreeList1.DataSource = mc.SuppliersType_GetList(Nothing, Nothing, Nothing)

    End Sub

    ''' <summary>
    ''' 載入幣別
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadCurrency()
        Dim mc As New CurrencyControler
        GridLookUpEdit1.Properties.DisplayMember = "C_ID"
        GridLookUpEdit1.Properties.ValueMember = "C_ID"
        GridLookUpEdit1.Properties.DataSource = mc.GetCurrencyList(Nothing)
    End Sub


    ''' <summary>
    ''' 新增供應商資料
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveNew()
        Dim mi As New SuppliersInfo
        Dim mc As New SuppliersControler

        mi.S_SupplierName = TextEdit2.Text
        mi.S_Associate = TextEdit6.Text
        mi.S_Associate1 = TextEdit17.Text
        mi.S_Associate2 = TextEdit23.Text
        mi.S_Tel = TextEdit7.Text
        mi.S_Tel1 = TextEdit16.Text
        mi.S_Tel2 = TextEdit22.Text
        mi.S_Phone = TextEdit8.Text
        mi.S_Phone1 = TextEdit15.Text
        mi.S_Phone2 = TextEdit21.Text
        mi.S_Fax = TextEdit9.Text
        mi.S_Fax1 = TextEdit14.Text
        mi.S_Fax2 = TextEdit20.Text
        mi.S_Email = TextEdit10.Text
        mi.S_Email1 = TextEdit13.Text
        mi.S_Email2 = TextEdit19.Text
        mi.S_Address = MemoEdit2.Text
        mi.S_Address1 = MemoEdit3.Text
        mi.S_Address2 = MemoEdit4.Text
        mi.S_Web = TextEdit3.Text
        mi.S_TypeID = PopupContainerEdit1.Text
        mi.S_Currency = GridLookUpEdit1.Text
        mi.S_Remark = MemoEdit1.Text
        mi.S_ToFrom = ComboBoxEdit1.Text
        mi.S_Rank = Trim(Microsoft.VisualBasic.Left(txtDai.Text, 1))
        mi.S_RankRemark = TextEdit4.Text
        mi.S_Check = False
        mi.S_Action = UserName
        mi.S_CheckAction = Nothing
        mi.S_AddDate = Format(Now, "short Date")
        mi.S_EditDate = Nothing

        mi.S_Type = "採購部"  '載入進來默認為採購部

        If mc.Suppliers_Add(mi) = True Then
            MsgBox("記錄已保存", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            tempValue = "RE"
        Else
            MsgBox("失敗,請檢查數據", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        End If


    End Sub


    ''' <summary>
    ''' 修改供應商資料
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveEdit()
        Dim mi As New SuppliersInfo
        Dim mc As New SuppliersControler
        mi.S_Supplier = TextEdit1.Text
        mi.S_SupplierName = TextEdit2.Text
        mi.S_Associate = TextEdit6.Text
        mi.S_Associate1 = TextEdit17.Text
        mi.S_Associate2 = TextEdit23.Text
        mi.S_Tel = TextEdit7.Text
        mi.S_Tel1 = TextEdit16.Text
        mi.S_Tel2 = TextEdit22.Text
        mi.S_Phone = TextEdit8.Text
        mi.S_Phone1 = TextEdit15.Text
        mi.S_Phone2 = TextEdit21.Text
        mi.S_Fax = TextEdit9.Text
        mi.S_Fax1 = TextEdit14.Text
        mi.S_Fax2 = TextEdit20.Text
        mi.S_Email = TextEdit10.Text
        mi.S_Email1 = TextEdit13.Text
        mi.S_Email2 = TextEdit19.Text
        mi.S_Address = MemoEdit2.Text
        mi.S_Address1 = MemoEdit3.Text
        mi.S_Address2 = MemoEdit4.Text
        mi.S_Web = TextEdit3.Text
        mi.S_TypeID = PopupContainerEdit1.Text
        mi.S_Currency = GridLookUpEdit1.Text
        mi.S_Remark = MemoEdit1.Text
        mi.S_ToFrom = ComboBoxEdit1.Text
        mi.S_Rank = Trim(Microsoft.VisualBasic.Left(txtDai.Text, 1))
        mi.S_RankRemark = TextEdit4.Text
        mi.S_Check = False
        mi.S_Action = UserName
        mi.S_CheckAction = Nothing
        mi.S_EditDate = Format(Now, "short Date")

        mi.S_Type = "採購部"  '載入進來默認為採購部

        mi.S_EditUser = UserName

        If mc.Suppliers_Update(mi) = True Then
            MsgBox("記錄已保存", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)


        Else
            MsgBox("失敗,請檢查數據", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        End If
    End Sub
    ''' <summary>
    ''' 審核
    ''' </summary>
    ''' <remarks></remarks>
    Sub SaveCheck()
        Dim mi As New SuppliersInfo
        Dim mc As New SuppliersControler
        Dim si As New SuppliersInfo
        mi.S_Supplier = TextEdit1.Text

        If CheckBox1.Checked = False Then
            mi.S_Check = False
        End If
        If CheckBox1.Checked = True Then
            mi.S_Check = True
        End If
        mi.S_CheckAction = UserName
        mi.S_Rank = Trim(Microsoft.VisualBasic.Left(txtDai.Text, 1))
        mi.S_RankRemark = TextEdit4.Text
        mi.S_CheckDate = Format(Now, "short Date")

        '@ 2012/7/5 添加　判斷審核信息是否改變
        si = mc.Suppliers_Get(TextEdit1.Text, Nothing)
        If si.S_Check = mi.S_Check And si.S_Rank = mi.S_Rank And si.S_RankRemark = mi.S_RankRemark Then
            MsgBox("審核信息未改變，不能保存！", 64, "提示")
            Exit Sub
        End If

        If mc.Suppliers_UpdateCheck(mi) = True Then
            MsgBox("記錄已保存", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        Else
            MsgBox("失敗,請檢查數據", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        End If
    End Sub


    ''' <summary>
    ''' 載入相應的供應商資料
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadSuppliers(ByVal S_Supplier As String)
        On Error Resume Next
        Dim mi As New SuppliersInfo
        Dim mc As New SuppliersControler
        mi = mc.Suppliers_Get(tempValue, Nothing)
        '  Grid.DataSource = mc.GetSuppliersList(tempValue, Nothing, Nothing)
        TextEdit1.Text = mi.S_Supplier
        TextEdit2.Text = mi.S_SupplierName
        TextEdit6.Text = mi.S_Associate
        TextEdit17.Text = mi.S_Associate1
        TextEdit23.Text = mi.S_Associate2
        TextEdit7.Text = mi.S_Tel
        TextEdit16.Text = mi.S_Tel1
        TextEdit22.Text = mi.S_Tel2
        TextEdit8.Text = mi.S_Phone
        TextEdit15.Text = mi.S_Phone1
        TextEdit21.Text = mi.S_Phone2
        TextEdit9.Text = mi.S_Fax
        TextEdit14.Text = mi.S_Fax1
        TextEdit20.Text = mi.S_Fax2
        TextEdit10.Text = mi.S_Email
        TextEdit13.Text = mi.S_Email1
        TextEdit19.Text = mi.S_Email2
        MemoEdit2.Text = mi.S_Address
        MemoEdit3.Text = mi.S_Address1
        MemoEdit4.Text = mi.S_Address2
        TextEdit3.Text = mi.S_Web
        If mi.S_Check = False Then
            CheckBox1.Checked = False
        End If
        If mi.S_Check = True Then
            CheckBox1.Checked = True
        End If

        chkReCheck.Checked = mi.S_ReCheck

        PopupContainerEdit1.Text = mi.S_TypeID
        GridLookUpEdit1.Text = mi.S_Currency
        MemoEdit1.Text = mi.S_Remark
        ComboBoxEdit1.Text = mi.S_ToFrom
        txtDai.Text = mi.S_Rank
        TextEdit4.Text = mi.S_RankRemark

        CheckDateStr = mi.S_CheckDate
        S_CheckActionStr = mi.S_CheckAction


    End Sub


    Private Sub SimpleButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Select Case Edit
            Case False
                SaveNew()
            

            Case True
                SaveEdit()
             
        End Select
    
        Me.Close()
    End Sub


    Private Sub popSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles popSelect.Click
        PopupContainerEdit1.Text = TreeList1.FocusedNode.Item("S_TypeName").ToString()
        TextEdit3.Text = "sdfsfds"
    End Sub



    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        PopupContainerEdit1.Text = TreeList1.FocusedNode.Item("S_TypeID").ToString()

    End Sub


    Private Sub TextEdit2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit2.LostFocus
        If MTypeName = "SupplierAddEdit" Then
            If TextEdit2.Text <> "" Then
                Dim mi As New SuppliersInfo
                Dim mc As New SuppliersControler
                mi = mc.Suppliers_Get(Nothing, TextEdit2.EditValue)
                If mi Is Nothing Then
                Else
                    MsgBox("此供應商名稱已存在，請重新輸入......")
                End If
            End If
        End If
    End Sub

    Private Sub PopupContainerEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PopupContainerEdit1.EditValueChanged

        Dim sc As New SuppliersTypeControler
        Dim si1 As New SuppliersTypeInfo
        Dim si2 As New SuppliersTypeInfo
        Dim si3 As New SuppliersTypeInfo
        Dim strA As String
        strA = PopupContainerEdit1.Text
        If strA.Length = 6 Then
            si1 = sc.SuppliersType_Get(Mid(strA, 1, 2))
            Label28.Text = si1.S_TypeName

            si2 = sc.SuppliersType_Get(Mid(strA, 1, 4))
            Label28.Text = Label28.Text & "--" & si2.S_TypeName

            si3 = sc.SuppliersType_Get(Mid(strA, 1, 6))
            Label28.Text = Label28.Text & "--" & si3.S_TypeName

        End If


        If strA.Length = 4 Then
            si1 = sc.SuppliersType_Get(Mid(strA, 1, 2))
            Label28.Text = si1.S_TypeName

            si2 = sc.SuppliersType_Get(Mid(strA, 1, 4))
            Label28.Text = Label28.Text & "--" & si2.S_TypeName

        End If


        If strA.Length = 2 Then
            si1 = sc.SuppliersType_Get(Mid(strA, 1, 2))
            Label28.Text = si1.S_TypeName

        End If
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        '  SaveEdit()
        SaveCheck()
        Me.Close()
    End Sub

    ''' <summary>
    ''' 單擊終審保存按鈕，保存終審信息 /2012/11/22  假設終審取消，同時審核亦取消
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' @ 2012/7/5 添加
    Private Sub btnReCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReCheck.Click
        Dim mi As New SuppliersInfo
        Dim mc As New SuppliersControler
        mi.S_Supplier = TextEdit1.Text
        mi.S_ReCheck = chkReCheck.Checked
        mi.S_ReCheckAction = UserName
        mi.S_Rank = Trim(Microsoft.VisualBasic.Left(txtDai.Text, 1))
        mi.S_RankRemark = TextEdit4.Text
        mi.S_ReCheckDate = Format(Now, "short Date")

        If mc.Suppliers_UpdateReCheck(mi) = True Then


            If chkReCheck.Checked = False Then

                ''Dim mi1 As New SuppliersInfo
                ''Dim mc1 As New SuppliersControler

                ''mi1.S_Supplier = TextEdit1.Text

                ''mi.S_Check = False

                ''If S_CheckActionStr = "" Then
                ''    mi1.S_CheckAction = Nothing
                ''Else
                ''    mi1.S_CheckAction = UserName
                ''End If



                ''mi1.S_Rank = Trim(Microsoft.VisualBasic.Left(txtDai.Text, 1))
                ''mi1.S_RankRemark = TextEdit4.Text

                ''If CheckDateStr = "" Then '2013-4-19
                ''    mi1.S_CheckDate = Nothing
                ''Else
                ''    mi1.S_CheckDate = Format(Now, "short Date")
                ''End If

                ' ''mi1.S_CheckDate = Format(Now, "short Date")

                ''mc1.Suppliers_UpdateCheck(mi1)

            End If

            MsgBox("終審狀態已改變！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox("終審狀態改變失敗！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
        End If
    End Sub
    ''' <summary>
    ''' 已終審復選框狀態改變時
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' ＠ 2012/7/5 添加
    Private Sub chkReCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReCheck.CheckedChanged
        If MTypeName = "SupplierReCheck" Then
            Dim sc As New SuppliersControler
            Dim si As New SuppliersInfo
            si = sc.Suppliers_Get(TextEdit1.Text, Nothing)

            If si.S_ReCheck = True Then
                If chkReCheck.Checked = True Then
                    txtDai.Text = "A"
                    txtDai.Enabled = False
                    btnReCheck.Enabled = False
                Else
                    txtDai.Text = "B"
                    txtDai.Enabled = True
                    btnReCheck.Enabled = True
                End If
            Else
                If chkReCheck.Checked = True Then
                    txtDai.Text = "A"
                    btnReCheck.Enabled = True
                Else
                    txtDai.Text = si.S_Rank
                    btnReCheck.Enabled = False
                End If
            End If
        End If
    End Sub

End Class
Imports LFERP.SystemManager.SystemUser
Imports LFERP.Library.ProductionPiecePersonnel

Public Class ProductionPiecePersonnelMain
    Dim upp As New ERPSafe
    Dim pi As New ProductionPiecePersonnelControl

    Private Sub ProductionPiecePersonnelMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PopPiecePersonnelPrint.Visible = False '2012-8-16 停用
        ToolStripMenuItem1.Visible = False


        PowerUser()
        popPiecePersonnelRef_Click(Nothing, Nothing)
    End Sub



    Sub PowerUser()

        popPiecePersonnelAdd.Enabled = False
        popPiecePersonnelEdit.Enabled = False

        popPiecePersonnelDel.Enabled = False

        popPiecePersonnelResign.Enabled = False
        popPiecePersonnelResignRe.Enabled = False

        PopPiecePersonnelPrint.Enabled = False
        LoadPiece.Enabled = False

        Dim pmws As New LFERP.SystemManager.PermissionModuleWarrantSubController
        Dim pmwiL As List(Of LFERP.SystemManager.PermissionModuleWarrantSubInfo)

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160301")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPiecePersonnelAdd.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160302")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPiecePersonnelEdit.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160303")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPiecePersonnelDel.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160304")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then popPiecePersonnelResignRe.Enabled = True : popPiecePersonnelResign.Enabled = True
        End If
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160305")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then PopPiecePersonnelPrint.Enabled = True
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160307")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then LoadPiece.Enabled = True
        End If


        ''加日薪顯示
        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160306")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then
                Per_DayPrice.Visible = True
            Else
                Per_DayPrice.Visible = False
                'txtPer_DayPrice.Properties.PasswordChar = "*"
                'txtPer_DayPrice.Enabled = False
            End If
        End If

        pmwiL = pmws.PermissionModuleWarrantSub_GetList(InUserID, "88160308")
        If pmwiL.Count > 0 Then
            If pmwiL.Item(0).PMWS_Value = "是" Then KaoQinToolStripMenuItem.Visible = True
        End If


    End Sub


    Private Sub popPiecePersonnelAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelAdd.Click
        MTypeName = "PerAdd"
        Dim fr As New ProductionPiecePersonnel
        fr.ShowDialog()
    End Sub


    Private Sub popPiecePersonnelEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelEdit.Click
        If GridView1.RowCount <= 0 Then Exit Sub

        Dim strA As String
        strA = GridView1.GetFocusedRowCellValue("AutoID")
        Dim gc1 As New ProductionPiecePersonnelControl
        Dim gilist As New List(Of ProductionPiecePersonnelInfo)
        gilist = gc1.ProductionPiecePersonnel_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If gilist.Count <= 0 Then
            Exit Sub
        End If

        If gilist(0).Per_Resign = True Then
            MsgBox("此員工已辭工處理，不能修改")
            Exit Sub
        End If

        MTypeName = "PerEdit" ''修改
        tempValue2 = GridView1.GetFocusedRowCellValue("AutoID")
        Dim fr As New ProductionPiecePersonnel
        fr.ShowDialog()
    End Sub

    Private Sub popPiecePersonnelView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelView.Click
        If GridView1.RowCount <= 0 Then Exit Sub
        MTypeName = "PerView" ''查看
        tempValue2 = GridView1.GetFocusedRowCellValue("AutoID").ToString
        Dim fr As New ProductionPiecePersonnel
        fr.ShowDialog()
    End Sub

    Private Sub popPiecePersonnelRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelRef.Click
        ''載入數據
        Grid1.DataSource = pi.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, strInDepID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub popPiecePersonnelDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelDel.Click
        ''刪除數據
        Dim gc As New ProductionPiecePersonnelControl
        Dim gi As New ProductionPiecePersonnelInfo
        Dim strA, strB As String

        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("AutoID")
        strB = GridView1.GetFocusedRowCellValue("Per_Name")

        Dim gc1 As New ProductionPiecePersonnelControl
        Dim gilist As New List(Of ProductionPiecePersonnelInfo)
        gilist = gc1.ProductionPiecePersonnel_GetList(strA, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

        If gilist.Count <= 0 Then
            Exit Sub
        End If

        If gilist(0).Per_Resign = True Then
            MsgBox("此員工已辭工處理，不能刪除")
            Exit Sub
        End If

       
        If MsgBox("你確定刪除員工姓名為:  '" & strB & "'  的記錄嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If gc.ProductionPiecePersonnel_Delete(strA) = True Then

                MsgBox("刪除成功")
                popPiecePersonnelRef_Click(Nothing, Nothing) '刷新
            Else
                MsgBox("刪除失敗")
            End If
        End If

    End Sub

    Private Sub popPiecePersonnelResign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelResign.Click
        ' Per_NO = @Per_NO and Per_Date = @Per_Date  and G_NO=@G_NO

        '辭工處理
        Dim gc As New ProductionPiecePersonnelControl
        Dim gi As New ProductionPiecePersonnelInfo
        Dim strA, strB As String

        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("Per_NO")
        strB = GridView1.GetFocusedRowCellValue("Per_Name")
        If MsgBox("你確定要對員工姓名為:  '" & strB & "'  的員工,進行辭工處理嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            gi.Per_NO = strA
            gi.Per_Date = Format(Now, "yyyy/MM/dd")
            gi.Per_Action = InUserID
            gi.Per_Resign = True

            If gc.ProductionPiecePersonnel_ResignUpdate(gi) = True Then
                MsgBox("處理成功")
                popPiecePersonnelRef_Click(Nothing, Nothing) '刷新
            Else
                MsgBox("處理失敗")
            End If
        End If

    End Sub

    Private Sub popPiecePersonnelResignRe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelResignRe.Click
        '辭工還原
        Dim gc As New ProductionPiecePersonnelControl
        Dim gi As New ProductionPiecePersonnelInfo
        Dim strA, strB As String

        If GridView1.RowCount <= 0 Then
            Exit Sub
        End If

        strA = GridView1.GetFocusedRowCellValue("Per_NO")
        strB = GridView1.GetFocusedRowCellValue("Per_Name")
        If MsgBox("你確定要對員工姓名為:  '" & strB & "'  的員工,進行辭工還原嗎?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            gi.Per_NO = strA
            gi.Per_Date = Format(Now, "yyyy/MM/dd")
            gi.Per_Action = InUserID
            gi.Per_Resign = False

            If gc.ProductionPiecePersonnel_ResignUpdate(gi) = True Then
                MsgBox("還原成功")
                popPiecePersonnelRef_Click(Nothing, Nothing) '刷新
            Else
                MsgBox("還原失敗")
            End If
        End If
    End Sub

    Private Sub popPiecePersonnelSeek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popPiecePersonnelSeek.Click
        'Dim fr As New ProductionPiecePersonnelFind

        'fr.ShowDialog()
        'If fr.isClickbtnFind = True Then
        '    Grid1.DataSource = pi.ProductionPiecePersonnel_GetList(Nothing, tempValue, tempValue2, tempValue5, tempValue4, tempValue3, tempValue6, tempValue7, Nothing, tempValue9, tempValue8)
        '    tempValue = ""
        '    tempValue2 = ""
        '    tempValue3 = ""
        '    tempValue4 = ""
        '    tempValue5 = ""
        '    tempValue6 = ""
        '    tempValue7 = ""
        '    tempValue8 = ""
        '    tempValue9 = ""
        'End If

        tempValue = "員工名單"
        ProductionPieceSelectAll.ShowDialog()

        Dim pi As New ProductionPiecePersonnelControl

        Select Case tempValue
            Case "0" '自定義
                Dim PPS As New LFERP.Library.ProductionPiece_Select.ProductionPiece_SelectControl
                Grid1.DataSource = PPS.ProductionPiecePersonnel_GetListSelect("員工名單", tempValue2)

            Case "1" '固定模式
                If tempValue3 = "廠証編號" Then
                    Grid1.DataSource = pi.ProductionPiecePersonnel_GetList(Nothing, tempValue2, Nothing, Nothing, strInDepID, Nothing, Nothing, tempValue4, Nothing, Nothing, tempValue5, Nothing)
                ElseIf tempValue3 = "員工姓名" Then
                    Grid1.DataSource = pi.ProductionPiecePersonnel_GetList(Nothing, Nothing, tempValue2, Nothing, strInDepID, Nothing, Nothing, tempValue4, Nothing, Nothing, tempValue5, Nothing)
                ElseIf tempValue3 = "組別編號" Then
                    Grid1.DataSource = pi.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, tempValue2, strInDepID, Nothing, Nothing, tempValue4, Nothing, Nothing, tempValue5, Nothing)
                ElseIf tempValue3 = "薪金類型" Then
                    Grid1.DataSource = pi.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, strInDepID, Nothing, tempValue2, tempValue4, Nothing, Nothing, tempValue5, Nothing)
                End If
            Case "2" '廠別 部門
                Grid1.DataSource = pi.ProductionPiecePersonnel_GetList2(Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue7)
        End Select


        tempValue = Nothing
        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing


        ProductionPieceSelectAll.Dispose()
    End Sub

    Private Sub PopPiecePersonnelPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopPiecePersonnelPrint.Click
        tempValue = "B"
        rptProductionPiecePersonnel.ShowDialog()
        rptProductionPiecePersonnel.Dispose()
    End Sub

    Private Sub LoadPiece_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadPiece.Click
        ProductionPeiceLoad.ShowDialog()
        ProductionPeiceLoad.Dispose()
    End Sub

    Private Sub PopPiecePersonnelExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PopPiecePersonnelExport.Click
        If GridView1.RowCount = 0 Then Exit Sub
        'ExportGridToXls()

        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Title = "導出Excel"

        saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
        '|Excel2007及以上文件(*.xlsx)|*.xlsx  '當前測試2007 以及以上版本有誤！

        Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)

        If dialogResult__1 = Windows.Forms.DialogResult.OK Then

            GridView1.BestFitColumns()

            Grid1.ExportToExcelOld(saveFileDialog.FileName)

            DevExpress.XtraEditors.XtraMessageBox.Show("導出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub KaoQinToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaoQinToolStripMenuItem.Click
        frmProductionPieceKaoQin.ShowDialog()
        frmProductionPieceKaoQin.Dispose()
    End Sub
End Class
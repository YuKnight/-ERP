Imports LFERP.Library.WareHouse
Imports LFERP.Library.Shared
Imports LFERP.DataSetting
Imports LFERP.Library.ProductionWareHouse
Imports LFERP.Library.WareHouseDetail

Public Class frmWareOutINDetails

    Private Sub frmWareOutINDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tw.CheckBoxes = True

        Dim mt As New WareHouseController
        mt.WareHouse_LoadToTreeView(tw, WareSelect(InUserID, "500401"))

        Me.DateEdit2.EditValue = Format(Now, "yyyy/MM/dd")
        Me.DateEdit1.EditValue = Format(DateAdd(DateInterval.Month, -1, CDate(Now)), "yyyy/MM/dd")

        Me.txtM_Code.EditValue = tempValue2


    End Sub

    Private Sub txtM_Code_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtM_Code.ButtonClick
        tempCode = ""
        tempValue6 = "倉庫庫存查詢"


        frmBOMSelect.ShowDialog()

        frmBOMSelect.XtraTabPage2.PageVisible = False
        frmBOMSelect.XtraTabPage3.PageVisible = False

        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            'tempCode
            Me.txtM_Code.EditValue = tempCode
        End If
    End Sub

    Private Sub txtM_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtM_Code.EditValueChanged

    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click

        Dim str, str1, str2, str3, str4 As String
        Dim tempStr As String = ""

        str = ""

        Dim i, j As Integer
        For i = 0 To tw.Nodes.Count - 1
            For j = 0 To tw.Nodes(i).Nodes.Count - 1
                If tw.Nodes(i).Nodes(j).Checked = True Then
                    str = str & "," & "'" & tw.Nodes(i).Nodes(j).Tag & "'"
                Else
                    tempStr = tempStr & "," & "'" & tw.Nodes(i).Nodes(j).Tag & "'"
                End If
            Next
        Next


        If Len(str) > 0 Then
            str = Mid(str, 2, Len(str))
        Else
            str = Mid(tempStr, 2, Len(tempStr))
        End If

        ''---------------------

        If Me.txtM_Code.EditValue = "" Then
            str1 = Nothing
        Else
            str1 = txtM_Code.EditValue
        End If

        If Me.DateEdit1.Text = "" Then
            str2 = Nothing
        Else
            str2 = Format(CDate(DateEdit1.EditValue), "yyyy-MM-dd")
        End If



        If Me.DateEdit2.Text = "" Then
            str3 = Nothing
        Else
            str3 = Format(CDate(DateEdit2.EditValue), "yyyy-MM-dd")
        End If


        If Me.txtCardID.Text = "" Then
            str4 = Nothing
        Else
            str4 = txtCardID.Text
        End If


        Dim WC As New WareHouseDetailControl
        Me.Grid1.DataSource = WC.WareHouseDetail_GetList2(str, str1, str2, str3, str4)

    End Sub

    Private Sub tw_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tw.NodeMouseClick
        '2013-2-20 加選擇多倉庫

        Dim i As Integer
        If e.Node.Level = 0 Then
            If e.Node.Checked = True Then
                For i = 0 To e.Node.Nodes.Count - 1
                    e.Node.Nodes(i).Checked = True
                Next
            Else
                For i = 0 To e.Node.Nodes.Count - 1
                    e.Node.Nodes(i).Checked = False
                Next
            End If
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

  
    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click

        If GridView2.RowCount = 0 Then Exit Sub

        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.Title = "導出Excel"

        saveFileDialog.Filter = "Excel2003文件(*.xls)|*.xls"
        '|Excel2007及以上文件(*.xlsx)|*.xlsx  '當前測試2007 以及以上版本有誤！

        Dim dialogResult__1 As DialogResult = saveFileDialog.ShowDialog(Me)

        If dialogResult__1 = Windows.Forms.DialogResult.OK Then

            Grid1.ExportToExcelOld(saveFileDialog.FileName)

            DevExpress.XtraEditors.XtraMessageBox.Show("保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class
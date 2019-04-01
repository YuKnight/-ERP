Imports LFERP.DataSetting
Imports LFERP.Library.ProductionField
Imports LFERP.Library.Production.ProductionFieldDaySummary

Public Class frmProductionDeparmentReport

    Dim upc As New UserPowerControl
    Dim pc As New LFERP.Library.PieceProcess.PersonnelControl
    Dim pdc As New ProductionFieldDaySummaryControl
    Public strDate As String

    Sub LoadDepartment()   '部門信息

        GluDep.Properties.DataSource = pc.FacBriSearch_GetList(strInFacID, Nothing, strInDepID, Nothing) '原始部門
        GluDep.Properties.DisplayMember = "DepName"
        GluDep.Properties.ValueMember = "DepID"

    End Sub


    Private Sub frmProductionDeparmentReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDepartment() '導入部門信息

        DateEdit1.Text = Format(DateAdd(DateInterval.Day, -7, CDate(Format(Now, "yyyy/MM/dd"))), "yyyy/MM/dd")  '默認計算一個星期記錄(包涵當天記錄)
        DateEdit2.Text = Format(Now, "yyyy/MM/dd")

    End Sub

    '記錄當前查詢信息--(當前測試僅使用一個)
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If GluDep.EditValue = "" Then
                MsgBox("部門不能為空,請選擇部門!")
                Exit Sub
            End If
            If DateEdit1.Text = "" Or DateEdit2.Text = "" Then
                MsgBox("日期不能為空,請選擇查詢日期!")
                Exit Sub
            End If

            Dim ds As New DataSet
            Dim ltc As New CollectionToDataSet

            Dim pfc As New ProductionFieldControl

            ds.Tables.Clear()

            Dim str1, str2 As String

            str1 = DateEdit1.Text
            str2 = DateEdit2.Text
 
            If pfc.ProductionField_GetList1(Nothing, Nothing, Nothing, Nothing, Nothing, "發料", Nothing, GluDep.EditValue, Nothing, True, True, str1, str2, Nothing, Nothing).Count = 0 Then
                MsgBox("當前部門在此日期範圍內無物料發出記錄!")
                Exit Sub
            End If

            ltc.CollToDataSet(ds, "ProductionField", pfc.ProductionField_GetList1(Nothing, Nothing, Nothing, Nothing, Nothing, "發料", Nothing, GluDep.EditValue, Nothing, True, True, str1, str2, Nothing, Nothing))
            PreviewRPT(ds, "rptProductionDetail", "部門生產工藝完成匯總", True, True)

            ltc = Nothing
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
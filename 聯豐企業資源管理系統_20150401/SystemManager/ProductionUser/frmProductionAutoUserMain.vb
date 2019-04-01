Imports LFERP.Library.Production.Datasetting
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.DataSetting

Public Class frmNmetalProductionAutoUserMain

    Dim pc As New LFERP.Library.PieceProcess.PersonnelControl
    Dim ds As New DataSet
    Dim pc1 As New UserPowerControl
    Dim strDep As String

    Sub LoadProductNo()  '產品編號
        'Dim mc As New ProductController
        Dim pcm As New ProcessMainControl
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        'PM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        'PM_M_Code.Properties.DataSource = pcm.ProcessMain_GetList1(Nothing, Nothing, Nothing, Nothing)
        PM_M_Code.Properties.DataSource = pcm.ProcessMain_GetList3(Nothing, Nothing)
    End Sub

    Sub LoadDepartment()   '部門信息

        gluDep1.Properties.DataSource = pc.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)  '變更部門
        gluDep1.Properties.DisplayMember = "DepName"
        gluDep1.Properties.ValueMember = "DepID"

    End Sub

    Private Sub frmProductionAutoUserMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()

        Grid2.DataSource = pc1.UserPower_GetList(Nothing, Nothing, Nothing, Nothing)  '生產中使用部門
        PM_JiYu.Caption = strJIYU
        PM_JiYuP.Caption = strJIYU

    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluType.Properties.ValueMember = "PM_Type"
        gluType.Properties.DisplayMember = "PM_Type"
        gluType.Properties.DataSource = ds.Tables("ProductType")

        With ds.Tables.Add("ProductionDatasetting")

            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_JiYu", GetType(String))
            .Columns.Add("GoIn", GetType(Boolean))
        End With

        Grid.DataSource = ds.Tables("ProductionDatasetting")  '產品編號信息

        With ds.Tables.Add("ProductionIssue")
            .Columns.Add("Pro_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
            .Columns.Add("GoIn1", GetType(Boolean))

        End With
        Grid1.DataSource = ds.Tables("ProductionIssue")  '工序信息

        With ds.Tables.Add("ProductionIncome")
            .Columns.Add("FP_InDep", GetType(String))
            .Columns.Add("FP_InName", GetType(String))
            .Columns.Add("GoIn2", GetType(Boolean))

        End With

        Grid3.DataSource = ds.Tables("ProductionIncome")  '設置部門信息

    End Sub

    Sub LoadProduct()
        'Dim mi As List(Of ProductInfo)
        'Dim mc As New ProductController

        Dim mi As List(Of ProcessMainInfo)
        Dim mc As New ProcessMainControl

        'mi = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        mi = mc.ProcessMain_GetList3(Nothing, Nothing)

        ds.Tables("ProductionDatasetting").Clear()

        If mi.Count = 0 Then
        Else

            Dim i As Integer
            For i = 0 To mi.Count - 1

                Dim row As DataRow
                row = ds.Tables("ProductionDatasetting").NewRow
                row("PM_M_Code") = mi(i).PM_M_Code
                row("PM_JiYu") = mi(i).PM_JiYu

                ds.Tables("ProductionDatasetting").Rows.Add(row)

                Dim di As List(Of ProductionDataSettingInfo)
                Dim dc As New ProductionDataSettingControl

                di = dc.ProductionUser_GetList(strDep, mi(i).PM_M_Code)
                If di.Count = 0 Then
                    row("GoIn") = False
                Else
                    row("GoIn") = True
                End If

            Next

        End If
    End Sub

    Sub LoadBriName()  '讀取當前部門信息

        Dim pi As List(Of LFERP.Library.PieceProcess.PersonnelInfo)

        pi = pc.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)
        ds.Tables("ProductionIncome").Clear()

        If pi.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To pi.Count - 1

                Dim row As DataRow
                row = ds.Tables("ProductionIncome").NewRow

                row("FP_InDep") = pi(i).DepID
                row("FP_InName") = pi(i).DepName

                ds.Tables("ProductionIncome").Rows.Add(row)

                Dim di As List(Of ProductionDataSettingInfo)
                Dim dc As New ProductionDataSettingControl

                di = dc.ProductionIncome_GetList(strDep, pi(i).DepID)

                If di.Count = 0 Then
                    row("GoIn2") = False
                Else
                    row("GoIn2") = True
                End If
            Next

        End If

    End Sub

    '部門--工序信息設置
    Private Sub gluDep1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If gluDep1.EditValue = "" Then Exit Sub

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        '保存當前用戶產品應用信息；保存當前使用部門--產品編號--類型--工序信息

        Dim di As New ProductionDataSettingInfo
        Dim dc As New ProductionDataSettingControl

        dc.ProductionUser_Delete(strDep, Nothing)
        dc.ProductionIncome_Delete(strDep, Nothing)
        dc.ProductionIssue_Delete(strDep, gluDep1.EditValue, PM_M_Code.EditValue, gluType.EditValue, Nothing)

        Dim i As Integer

        For i = 0 To ds.Tables("ProductionDatasetting").Rows.Count - 1

            If ds.Tables("ProductionDatasetting").Rows(i)("GoIn") = True Then

                di.UserID = strDep
                di.PM_M_Code = ds.Tables("ProductionDatasetting").Rows(i)("PM_M_Code")
                ' MsgBox(strDep)
                dc.ProductionUser_Add(di)
            End If
        Next

        Dim j As Integer

        For j = 0 To ds.Tables("ProductionIssue").Rows.Count - 1

            If ds.Tables("ProductionIssue").Rows(j)("GoIn1") = True Then

                di.UserID = strDep
                di.FP_OutDep = gluDep1.EditValue
                'di.Pro_Type = "生產加工" cbType
                di.Pro_Type = cbType.EditValue
                di.PM_M_Code = PM_M_Code.EditValue
                di.PM_Type = gluType.EditValue
                di.Pro_NO = ds.Tables("ProductionIssue").Rows(j)("Pro_NO")

                dc.ProductionIssue_Add(di)
            End If
        Next

        Dim m As Integer

        For m = 0 To ds.Tables("ProductionIncome").Rows.Count - 1

            If ds.Tables("ProductionIncome").Rows(m)("GoIn2") = True Then
                di.UserID = strDep
                di.FP_InDep = ds.Tables("ProductionIncome").Rows(m)("FP_InDep")

                dc.ProductionIncome_Add(di)

            End If
        Next
        MsgBox("保存生產模塊用智能權限完成!")
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub Grid2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid2.MouseUp
        If GridView8.RowCount = 0 Then Exit Sub

        strDep = GridView8.GetFocusedRowCellValue("DepID").ToString

        LoadProductNo()  '設置工序需要的產品編號
        LoadDepartment() '部門表信息
        LoadProduct() '導入所有產品信息
        LoadBriName()

        If IsDBNull(GridView8.GetFocusedRowCellValue("UserType")) = True Then '2013-8-29
            cbType.EditValue = "生產加工"
        ElseIf GridView8.GetFocusedRowCellValue("UserType").ToString = "" Then
            cbType.EditValue = "生產加工"
        Else
            cbType.EditValue = GridView8.GetFocusedRowCellValue("UserType").ToString
        End If

        gluDep1.EditValue = strDep

    End Sub


    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged
        On Error Resume Next

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)
        ds.Tables("ProductType").Clear()

        '        ppi = ppc.ProcessMain_GetList2("生產加工", PM_M_Code.EditValue) 'cbType
        ppi = ppc.ProcessMain_GetList2(cbType.EditValue, PM_M_Code.EditValue)
        If ppi.Count = 0 Then
        Else

            Dim i As Integer
            For i = 0 To ppi.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductType").NewRow
                row("PM_Type") = ppi(i).Type3ID
                ds.Tables("ProductType").Rows.Add(row)

            Next
        End If
    End Sub

    Private Sub gluType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluType.EditValueChanged

        If PM_M_Code.EditValue = "" Then Exit Sub

        Dim pc As New ProcessMainControl
        Dim pci As List(Of ProcessMainInfo)
        'pci = pc.ProcessMain_GetList(Nothing, PM_M_Code.EditValue, "生產加工", gluType.EditValue, Nothing, True)'
        pci = pc.ProcessMain_GetList(Nothing, PM_M_Code.EditValue, cbType.EditValue, gluType.EditValue, Nothing, True) 'cbType

        ds.Tables("ProductionIssue").Clear()

        Try
            If pci.Count = 0 Then Exit Sub

            Dim i As Integer
            For i = 0 To pci.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductionIssue").NewRow

                row("Pro_NO") = pci(i).PS_NO
                row("PS_Name") = pci(i).PS_Name

                Dim di As List(Of ProductionDataSettingInfo)
                Dim dc As New ProductionDataSettingControl

                di = dc.ProductionIssue_GetList(strDep, gluDep1.EditValue, cbType.EditValue, PM_M_Code.EditValue, gluType.EditValue, pci(i).PS_NO)

                If di.Count = 0 Then
                    row("GoIn1") = False
                Else
                    row("GoIn1") = True
                End If

                ds.Tables("ProductionIssue").Rows.Add(row)

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub gluDep1_EditValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluDep1.EditValueChanged

    End Sub

    Private Sub Grid2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Grid2.Click

    End Sub
End Class
Imports LFERP.Library.ProductionField
Imports LFERP.Library.ProductionController

Imports LFERP.Library
Imports LFERP

Public Class frmProductionFieldLBJC

    Dim strPM_M_Code As String
    Dim strcbType As String
    Dim strgluType As String
    Dim strPS_NO As String
    Dim strDepID As String
    Dim ds As New DataSet

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        SaveData()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmProductionFieldLBJC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strPM_M_Code = tempValue2
        strcbType = tempValue3
        strgluType = tempValue4
        strPS_NO = tempValue5
        strDepID = tempValue6

        tempValue2 = Nothing
        tempValue3 = Nothing
        tempValue4 = Nothing
        tempValue5 = Nothing
        tempValue6 = Nothing

        CreateTable()

        LoadData()
    End Sub

    Sub CreateTable()
        '創建類型表
        With ds.Tables.Add("FP_LiuBan")
            .Columns.Add("GoIN", GetType(Boolean))
            .Columns.Add("FP_NO", GetType(String))
            .Columns.Add("Pro_Type", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("Pro_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
            .Columns.Add("FP_Qty", GetType(Int32))
            .Columns.Add("ReturnQty", GetType(Int32))
            .Columns.Add("Remark", GetType(String))
            .Columns.Add("FP_Date", GetType(Date))
            .Columns.Add("DepInName", GetType(String))
            '
        End With

        Grid1.DataSource = ds.Tables("FP_LiuBan")

    End Sub
    Sub LoadData()
        ds.Tables("FP_LiuBan").Clear()

        Dim a As New Library.ProductionField.ProductionFieldControl
        Dim b As New List(Of ProductionFieldInfo)

        b = a.ProductionField_GetList1(Nothing, strcbType, strPM_M_Code, strgluType, strPS_NO, Nothing, strDepID, Nothing, "PT06", True, True, Nothing, Nothing, Nothing, Nothing)
        If b.Count > 0 Then
        Else
            MsgBox("無留辦信息!")
            Me.Close()
        End If
        '--------------------------------------------------------------------------------------------------------------------
        Dim row As DataRow
        Dim j As Integer
        For j = 0 To b.Count - 1

            If b(j).FP_Qty > b(j).ReturnQty Then
                row = ds.Tables("FP_LiuBan").NewRow

                row("GoIN") = False
                row("FP_NO") = b(j).FP_NO
                row("Pro_Type") = b(j).Pro_Type
                row("PM_M_Code") = b(j).PM_M_Code
                row("PM_Type") = b(j).PM_Type
                row("Pro_NO") = b(j).Pro_NO

                row("PS_Name") = b(j).PS_Name
                row("FP_Qty") = b(j).FP_Qty
                row("ReturnQty") = b(j).ReturnQty
                row("Remark") = b(j).FP_Remark
                row("FP_Date") = b(j).FP_Date
                row("DepInName") = b(j).DepInName
                ds.Tables("FP_LiuBan").Rows.Add(row)
            End If
        Next

    End Sub


    Sub SaveData()
        If ds.Tables("FP_LiuBan").Rows.Count <= 0 Then
            MsgBox("無數據存在!")
            Exit Sub
        End If

        Dim js As Integer = 0
        Dim j As Integer

        For j = 0 To ds.Tables("FP_LiuBan").Rows.Count - 1
            If ds.Tables("FP_LiuBan").Rows(j)("GoIN") = True Then
                js = js + 1
                tempValue7 = ds.Tables("FP_LiuBan").Rows(j)("FP_NO").ToString
                tempValue8 = ds.Tables("FP_LiuBan").Rows(j)("FP_Qty") - ds.Tables("FP_LiuBan").Rows(j)("ReturnQty")
                tempValue9 = ds.Tables("FP_LiuBan").Rows(j)("FP_Qty")
            End If
        Next

        If js = 0 Then
            MsgBox("無數據選擇！")
            Exit Sub
        End If

        If js > 1 Then
            MsgBox("只能加載一條單號！")
            Exit Sub
        End If

        Me.Close()

    End Sub



End Class
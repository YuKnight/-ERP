Imports LFERP.Library.ProductionField
Imports LFERP.DataSetting
Imports LFERP.SystemManager
Imports LFERP.Library.Product
Imports LFERP.Library.WareHouse
Imports LFERP.Library.ProductionWareHouse
Imports LFERP.Library.ProductionSchedule
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.ProductionFieldType
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.ProductionKaiLiao
Imports LFERP.Library.ProductionDPTWareInventory
Imports LFERP.Library.Purchase.SharePurchase
Imports LFERP.Library.Production.ProductionFieldDaySummary
Imports System.Threading
Imports LFERP.Library.Production.ProductionAffair
Imports LFERP.Library.Production.ProductionType



Public Class frmProductionOutWardType


    Dim ds As New DataSet

    Sub LoadProductNo()  '產品編號
        Dim mc As New ProcessMainControl
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

    End Sub

    Private Sub frmProductionOutWardType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadProductNo()
        CreateTable()
        Label6.Text = tempValue2
        Label7.Text = tempValue
        tempValue = ""
        tempValue2 = ""

        Select Case Label7.Text
            Case "OutWardType"
                If Edit = False Then

                Else
                    LoadData(Label6.Text)
                End If

        End Select

    End Sub
    Sub CreateTable()

        With ds.Tables.Add("ProductType")
            .Columns.Add("PM_Type", GetType(String))
        End With
        gluType.Properties.ValueMember = "PM_Type"
        gluType.Properties.DisplayMember = "PM_Type"
        gluType.Properties.DataSource = ds.Tables("ProductType")

    End Sub

    Function LoadData(ByVal ID As String) As Boolean
        LoadData = True
        Dim pti As List(Of ProductionOutWardTypeInfo)
        Dim ptc As New ProductionOutWardTypeControl

        pti = ptc.ProductionOutWardType_GetList(ID, Nothing, Nothing, Nothing, Nothing)

        If pti.Count = 0 Then
            LoadData = False
            Exit Function
        Else

            PM_M_Code.EditValue = pti(0).PM_M_Code
            gluType.EditValue = pti(0).PM_Type
            MemoEdit1.Text = pti(0).OW_Do
            ComboBoxEdit1.EditValue = pti(0).OW_Return

        End If

    End Function

    Private Sub PM_M_Code_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code.EditValueChanged
        On Error Resume Next

        Dim ppc As New ProcessMainControl
        Dim ppi As List(Of ProcessMainInfo)
        ds.Tables("ProductType").Clear()
        ppi = ppc.ProcessMain_GetList2("生產加工", PM_M_Code.EditValue)
        If ppi.Count = 0 Then
        Else

            Dim i As Integer
            For i = 0 To ppi.Count - 1
                Dim row As DataRow
                row = ds.Tables("ProductType").NewRow
                row("PM_Type") = ppi(i).Type3ID
                ds.Tables("ProductType").Rows.Add(row)

                '-------------------------------------------------
            Next
        End If

    End Sub

    Sub DataNew()

        Dim pti As New ProductionOutWardTypeInfo
        Dim ptc As New ProductionOutWardTypeControl
        Dim pti1 As List(Of ProductionOutWardTypeInfo)

        If PM_M_Code.EditValue = "" Then
            MsgBox("產品資料不能為空！")
            Exit Sub

        End If
        If gluType.EditValue = "" Then
            MsgBox("類型不能為空！")
            Exit Sub
        End If
        If MemoEdit1.Text = "" Then
            MsgBox("加工要求不能為空！")
            Exit Sub
        End If
        If ComboBoxEdit1.EditValue = "" Then
            MsgBox("需回信息不能為空！")
            Exit Sub
        End If

        pti.PM_M_Code = PM_M_Code.EditValue
        pti.PM_Type = gluType.EditValue
        pti.OW_Do = MemoEdit1.Text
        pti.OW_Return = ComboBoxEdit1.EditValue
        pti.OW_ReQty = 0

        pti1 = ptc.ProductionOutWardType_GetList(Nothing, PM_M_Code.EditValue, gluType.EditValue, MemoEdit1.Text, Nothing)
        If pti1.Count > 0 Then
            MsgBox("此產品配件加工要求已存在，不允許重複添加！")
            Exit Sub
        Else
            If ptc.ProductionOutWardType_Add(pti) = True Then
                MsgBox("添加加工要求信息完成！")

            Else
                MsgBox("添加加工要求信息失敗，請檢查原因！")
                Exit Sub
            End If
        End If
        Me.Close()

    End Sub

    Sub DataEdit()
        Dim pti As New ProductionOutWardTypeInfo
        Dim ptc As New ProductionOutWardTypeControl
        Dim pti1 As List(Of ProductionOutWardTypeInfo)


        If PM_M_Code.EditValue = "" Then
            MsgBox("產品資料不能為空！")
            Exit Sub

        End If
        If gluType.EditValue = "" Then
            MsgBox("類型不能為空！")
            Exit Sub
        End If
        If MemoEdit1.Text = "" Then
            MsgBox("加工要求不能為空！")
            Exit Sub
        End If
        If ComboBoxEdit1.EditValue = "" Then
            MsgBox("需回信息不能為空！")
            Exit Sub
        End If


        pti.AutoID = Label6.Text
        pti.PM_M_Code = PM_M_Code.EditValue
        pti.PM_Type = gluType.EditValue
        pti.OW_Do = MemoEdit1.Text
        pti.OW_Return = ComboBoxEdit1.EditValue
        pti.OW_ReQty = 0

        pti1 = ptc.ProductionOutWardType_GetList(Label6.Text, Nothing, Nothing, Nothing, Nothing)
        If pti1.Count > 0 Then

            If pti1(0).OW_ReQty > 0 Then
                MsgBox("當前產品配件已進行過外發操作，不允許修改！")
                Exit Sub
            Else
                If ptc.ProductionOutWardType_Update(pti) = True Then
                    MsgBox("修改當前加工要求信息完成！")

                Else
                    MsgBox("修改當前加工要求信息失敗，請檢查原因！")
                    Exit Sub
                End If
            End If
          
        End If
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Edit = False Then
            DataNew()
        Else
            DataEdit()
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
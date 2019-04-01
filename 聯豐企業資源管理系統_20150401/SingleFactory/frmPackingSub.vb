Imports LFERP.Library.SingleFactory
Imports LFERP.Library.Orders


Public Class frmPackingSub

    Public ds3 As New DataSet
    Dim ds As New DataSet

    Private Sub frmPackingSub_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        Label3.Text = tempValue4
        Label4.Text = tempValue5
        tempValue4 = ""
        tempValue5 = ""
        LoadBomData(Label4.Text.Trim)
        Select Case Label3.Text

            Case "出廠單"
                If EditSub = True Then

                    Label2.Text = tempValue3
                    tempValue3 = Nothing
                    If Len(tempValue6) > 0 Then
                        LoadPackingSubData(Label2.Text)
                    End If

                Else
                    Label2.Text = tempValue7 & tempValue8

                End If
                cmdSave.Visible = True
            Case "PreView"
                Label2.Text = tempValue3
                tempValue3 = ""
                LoadPackingSubData(Label2.Text)
                cmdSave.Visible = False
            Case "Check"
                Label2.Text = tempValue3
                tempValue3 = ""
                LoadPackingSubData(Label2.Text)
                cmdSave.Visible = False
        End Select

        'Label2.Text = tempValue3
        'Label3.Text = tempValue4
        'Label4.Text = tempValue5
        'tempValue3 = ""
        'tempValue4 = ""
        'tempValue5 = ""
        'LoadBomData(Label4.Text.Trim)

        'Select Case Label3.Text
        '    Case "出廠單"
        '        If EditSub = True Then

        '            If Len(tempValue6) = 0 Then

        '            ElseIf Len(tempValue6) > 0 Then

        '                LoadPackingSubData(Label2.Text)
        '            End If

        '        Else
        '            'LoadPackingSubData(Label2.Text)
        '        End If
        '        cmdSave.Visible = True

        '    Case "PreView"

        '        LoadPackingSubData(Label2.Text)
        '        cmdSave.Visible = False

        '    Case "Check"

        '        LoadPackingSubData(Label2.Text)
        '        cmdSave.Visible = False

        'End Select


    End Sub

    Sub LoadData(ByVal PB_NO As String)

        Dim sfc As New SingleFactoryControl
        Dim sfi As New List(Of SingleFactoryInfo)

        Try
            sfi = sfc.PackingSub_GetList(PB_NO, Nothing)
            If sfi Is Nothing Then Exit Sub
            Dim i As Integer
            Dim row As DataRow
            ds3.Tables("PackingSub").Clear()
            For i = 0 To sfi.Count - 1

                row = ds3.Tables("PackingSub").NewRow

                row("IndexNum") = sfi(i).IndexNum
                row("PB_NO") = sfi(i).PB_NO
                row("M_Code") = sfi(i).M_Code
                row("M_Name") = sfi(i).M_Name
                row("M_Gauge") = sfi(i).M_Gauge
                row("PB_Qty") = sfi(i).PB_Qty
                row("PB_SP") = sfi(i).PB_SP

                ds3.Tables("PackingSub").Rows.Add(row)

            Next

        Catch ex As Exception

        End Try

    End Sub

    Sub LoadPackingSubData(ByVal PB_NO As String)
        Dim sfc As New SingleFactoryControl
        Dim sfi As New List(Of SingleFactoryInfo)

        sfi = sfc.PackingSub_GetList(PB_NO, Nothing)
        If sfi Is Nothing Then Exit Sub
        Dim i As Integer
        Dim row As DataRow
        ds.Tables("OrdersBom").Clear()
        For i = 0 To sfi.Count - 1

            row = ds.Tables("OrdersBom").NewRow

            row("IndexNum") = sfi(i).IndexNum
            row("PB_NO") = sfi(i).PB_NO
            row("M_Code") = sfi(i).M_Code
            row("M_Name") = sfi(i).M_Name
            row("M_Gauge") = sfi(i).M_Gauge
            row("PB_Qty") = sfi(i).PB_Qty
            row("PB_SP") = sfi(i).PB_SP

            If sfi(i).PB_Qty > 0 Then
                row("GoIn") = True
            End If

            ds.Tables("OrdersBom").Rows.Add(row)

        Next

    End Sub

    Sub LoadBomData(ByVal OS_BatchID As String)

        Dim obc As New OrdersBomController
        Dim tlist As List(Of OrdersBomInfo)
        ds.Tables("OrdersBom").Rows.Clear()
        tlist = obc.OrdersBom_GetList(Nothing, OS_BatchID, Nothing, "0")
        If tlist Is Nothing Then Exit Sub

        On Error Resume Next
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To tlist.Count - 1
            row = ds.Tables("OrdersBom").NewRow

            row("M_Code") = tlist(i).M_Code
            row("OB_Qty") = tlist(i).OB_Qty
            row("OB_MakeRemark") = tlist(i).OB_MakeRemark
            row("OB_Make") = tlist(i).OB_Make

            row("OB_Supplier") = tlist(i).OB_Supplier
            row("OB_SupplierNo") = tlist(i).OB_SupplierNo
            row("M_Name") = tlist(i).M_Name
            row("M_Gauge") = tlist(i).M_Gauge

            row("OB_AccountCheck") = tlist(i).OB_AccountCheck
            row("OB_Key") = tlist(i).OB_Key
            row("OB_PID") = tlist(i).OB_PID
            row("PM_LVL") = tlist(i).PM_LVL
            row("M_CodeType") = tlist(i).M_CodeType
            row("M_CodeMouldNO") = tlist(i).M_CodeMouldNO
            row("OB_MakeDepartment") = tlist(i).OB_MakeDepartment
            row("OB_MModeCusterNO") = tlist(i).OB_MModeCusterNO
            row("OB_Product") = tlist(i).OB_Product
            row("GoIn") = False
            row("PB_Qty") = 0
            row("PB_SP") = 0

            ds.Tables("OrdersBom").Rows.Add(row)

        Next


        If ds.Tables("OrdersBom").Rows.Count = 0 Then
            MsgBox("未載入產品配件資料或產品資料配件未建立！", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)

        End If
    End Sub

    Sub CreateTable()

        ds3.Tables.Clear()
        ds.Tables.Clear()

        With ds3.Tables.Add("PackingSub")

            .Columns.Add("IndexNum", GetType(Integer))
            .Columns.Add("PB_NO", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("PB_Qty", GetType(Double))
            .Columns.Add("PB_SP", GetType(Double))

        End With

        With ds.Tables.Add("OrdersBom")

            .Columns.Add("OS_BatchID", GetType(Integer))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("OB_PID", GetType(String))
            .Columns.Add("OB_Key", GetType(String))
            .Columns.Add("OB_Qty", GetType(Double))
            .Columns.Add("OB_MainQty", GetType(Double))
            .Columns.Add("OB_Price", GetType(Double))
            .Columns.Add("OB_Supplier", GetType(String))
            .Columns.Add("OB_SupplierNo", GetType(String))
            .Columns.Add("OB_Product", GetType(String))
            .Columns.Add("OB_ProductNo", GetType(String))
            .Columns.Add("OB_ProductRemark", GetType(String))
            .Columns.Add("OB_AccountCheck", GetType(Boolean))
            .Columns.Add("OB_Make", GetType(Boolean))
            .Columns.Add("OB_MarkRemark", GetType(String))
            .Columns.Add("OB_ID", GetType(Integer))
            .Columns.Add("PM_LVL", GetType(Integer))
            .Columns.Add("M_CodeType", GetType(String))
            .Columns.Add("M_CodeMouldNO", GetType(String))
            .Columns.Add("OB_MakeDepartment", GetType(String))
            .Columns.Add("OB_MModeCusterNO", GetType(String))

            .Columns.Add("OB_NoSendQty", GetType(Double))
            .Columns.Add("OB_NoOutQty", GetType(Double))

            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))

            .Columns.Add("GoIn", GetType(Boolean))
            .Columns.Add("PB_SP", GetType(Double))
            .Columns.Add("PB_Qty", GetType(Double))
            .Columns.Add("PB_NO", GetType(String))
            .Columns.Add("IndexNum", GetType(Integer))

        End With

        GridControl1.DataSource = ds.Tables("OrdersBom")

    End Sub

    Sub DataNew()
        Dim sfi As New SingleFactoryInfo
        Dim sfc As New SingleFactoryControl

        sfi.PB_NO = Label2.Text

        Dim i As Integer
        For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

            sfi.M_Code = ds.Tables("OrdersBom").Rows(i)("M_Code")

            If IsDBNull(ds.Tables("OrdersBom").Rows(i)("PB_Qty")) Then
                sfi.PB_Qty = 0
            Else
                sfi.PB_Qty = ds.Tables("OrdersBom").Rows(i)("PB_Qty")
            End If
            If IsDBNull(ds.Tables("OrdersBom").Rows(i)("PB_SP")) Then
                sfi.PB_SP = 0
            Else
                sfi.PB_SP = ds.Tables("OrdersBom").Rows(i)("PB_SP")
            End If
            If sfc.PackingSub_Add(sfi) = False Then
                MsgBox("添加失敗，請檢查原因！")
                Exit Sub
            End If
        Next

    End Sub
    Sub DataNew1()

        Dim i As Integer

        For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

            Dim row As DataRow

            row = ds3.Tables("PackingSub").NewRow

            row("PB_NO") = Label2.Text

            row("M_Code") = ds.Tables("OrdersBom").Rows(i)("M_Code")

            If IsDBNull(ds.Tables("OrdersBom").Rows(i)("PB_Qty")) Then
                row("PB_Qty") = 0
            Else
                row("PB_Qty") = ds.Tables("OrdersBom").Rows(i)("PB_Qty")
            End If
            If IsDBNull(ds.Tables("OrdersBom").Rows(i)("PB_SP")) Then
                row("PB_SP") = 0
            Else
                row("PB_SP") = ds.Tables("OrdersBom").Rows(i)("PB_SP")
            End If

            ds3.Tables("PackingSub").Rows.Add(row)

        Next

    End Sub
    Sub DataEdit()

        '更新刪除的記錄

        Dim sfi As New SingleFactoryInfo
        Dim sf As New SingleFactoryControl
        Dim i As Integer
        For i = 0 To ds.Tables("OrdersBom").Rows.Count - 1

            sfi.PB_NO = Label2.Text

            If Not IsDBNull(ds.Tables("OrdersBom").Rows(i)("IndexNum")) Then   '只修改

                sfi.M_Code = ds.Tables("OrdersBom").Rows(i)("M_Code")

                If IsDBNull(ds.Tables("OrdersBom").Rows(i)("PB_Qty")) Then
                    sfi.PB_Qty = 0
                Else
                    sfi.PB_Qty = ds.Tables("OrdersBom").Rows(i)("PB_Qty")
                End If
                If IsDBNull(ds.Tables("OrdersBom").Rows(i)("PB_SP")) Then
                    sfi.PB_SP = 0
                Else
                    sfi.PB_SP = ds.Tables("OrdersBom").Rows(i)("PB_SP")
                End If
                If sf.PackingSub_Update(sfi) = False Then
                    MsgBox("保存失敗，請檢查原因！")
                    Exit Sub
                End If


            End If

        Next

    End Sub

    Public Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        'If Label3.Text = "出廠單" Then
        '    If EditSub = False Then
        '        DataNew()
        '    Else

        '        If Len(tempValue6) = 0 Then
        '            DataNew()
        '        ElseIf Len(tempValue6) > 0 Then
        '            DataEdit()
        '        End If

        '    End If
        'End If
        If Label3.Text = "出廠單" Then
            If EditSub = False Then
                DataNew1()
            Else
                If Len(tempValue6) = 0 Then
                    DataNew1()
                ElseIf Len(tempValue6) > 0 Then
                    DataEdit()
                End If
            End If
        End If

        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


End Class
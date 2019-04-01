Imports LFERP.SystemManager
Imports LFERP.Library
Imports LFERP.Library.Product
Imports LFERP.Library.ProductProcess
Imports LFERP.Library.Production.ProductionProductInner
Public Class frmProductionProductInner
    Dim pc As New ProcessMainControl
    Dim ds As New DataSet
    Dim LoadBz As String


    Private Sub frmProductionProductInner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbType.EditValue = "生產加工"
        Me.Grid1.DataSource = pc.ProcessMain_GetList4(cbType.EditValue, Nothing, Nothing)

        CreateTable()

        LoadBz = "Y"

    End Sub

    Private Sub cbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbType.SelectedIndexChanged

        If LoadBz <> "Y" Then Exit Sub

        ds.Tables("Product").Clear()
        ds.Tables("ProductDel").Clear()

        PM_M_Code2.EditValue = Nothing
        gluType2.EditValue = Nothing

        Me.Grid1.DataSource = pc.ProcessMain_GetList4(cbType.EditValue, Nothing, Nothing)
        ' Me.Grid2.DataSource = pc.ProcessMain_GetList1(Nothing, Nothing, cbType.EditValue, Nothing)

    End Sub


    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub


    Sub CreateTable()
        '創建類型表
        With ds.Tables.Add("Product")
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("Pro_Type", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))

            .Columns.Add("Pro_Type1", GetType(String))
            .Columns.Add("PM_M_Code1", GetType(String))
            .Columns.Add("PM_Type1", GetType(String))
        End With

        Grid2.DataSource = ds.Tables("Product")

        '創建類型表
        With ds.Tables.Add("ProductDel")
            .Columns.Add("AutoID", GetType(String))
        End With
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click

        Dim strPM_M_Code As String
        Dim strPM_Type As String

        Try
            strPM_M_Code = GridView1.GetFocusedRowCellValue("PM_M_Code").ToString
            strPM_Type = GridView1.GetFocusedRowCellValue("PM_Type").ToString
        Catch ex As Exception
            Me.Grid1.Select()
            MsgBox("請先選擇[左側]被關聯的產品編號!")
            Exit Sub
        End Try


        If strPM_M_Code = PM_M_Code2.EditValue Then
            MsgBox("相同產品編號,無需設置!")
            Exit Sub
        End If

        Dim i As Integer
        If ds.Tables("Product").Rows.Count > 0 Then
            For i = 0 To ds.Tables("Product").Rows.Count - 1
                If strPM_M_Code = ds.Tables("Product").Rows(i)("PM_M_Code").ToString And strPM_Type = ds.Tables("Product").Rows(i)("PM_Type").ToString _
                And PM_M_Code2.EditValue = ds.Tables("Product").Rows(i)("PM_M_Code1").ToString And gluType2.EditValue = ds.Tables("Product").Rows(i)("PM_Type1").ToString _
                And cbType.EditValue = ds.Tables("Product").Rows(i)("Pro_Type").ToString And cbType2.EditValue = ds.Tables("Product").Rows(i)("Pro_Type1").ToString Then
                    MsgBox("此工藝,產品編號.類型已加入!")
                    Exit Sub
                End If
            Next
        End If
        '-------------------

        If cbType2.EditValue = "" Or cbType2.Text = "" Then
            cbType2.Select()
            MsgBox("請先選擇[右側]關聯的工藝類型!")
            Exit Sub
        End If

        If PM_M_Code2.EditValue = "" Or PM_M_Code2.Text = "" Then
            PM_M_Code2.Select()
            MsgBox("請先選擇[右側]關聯的產品編號!")
            Exit Sub
        End If

        If gluType2.EditValue = "" Or gluType2.Text = "" Then
            gluType2.Select()
            MsgBox("請先選擇[右側]關聯的類型!")
            Exit Sub
        End If
        '-------------------------------------------------------------------
        Dim row1 As DataRow
        row1 = ds.Tables("Product").NewRow

        row1("Pro_Type") = cbType.EditValue
        row1("PM_M_Code") = strPM_M_Code
        row1("PM_Type") = strPM_Type


        row1("Pro_Type1") = cbType2.EditValue
        row1("PM_M_Code1") = PM_M_Code2.EditValue
        row1("PM_Type1") = gluType2.EditValue


        ds.Tables("Product").Rows.Add(row1)
    End Sub

    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        SaveData()
    End Sub

    Private Sub PM_M_Code2_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PM_M_Code2.EditValueChanged
        'On Error Resume Next
        If PM_M_Code2.EditValue = "" Or PM_M_Code2.EditValue Is Nothing Then Exit Sub

        Dim ppc As New ProcessMainControl
    
        gluType2.Properties.ValueMember = "Type3ID"
        gluType2.Properties.DisplayMember = "Type3ID"
        gluType2.Properties.DataSource = ppc.ProcessMain_GetList2(cbType2.EditValue, PM_M_Code2.EditValue)

    End Sub

    Private Sub ToolStripDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDelete.Click
        If Me.GridView2.RowCount <= 0 Then Exit Sub
        If GridView1.RowCount = 0 Then Exit Sub

        Dim DelTemp As String
        DelTemp = GridView2.GetRowCellDisplayText(ArrayToString(GridView2.GetSelectedRows()), "AutoID")

        If DelTemp = "AutoID" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("ProductDel").NewRow
            row("AutoID") = ds.Tables("Product").Rows(GridView2.FocusedRowHandle)("AutoID")
            ds.Tables("ProductDel").Rows.Add(row)
        End If
        ds.Tables("Product").Rows.RemoveAt(CInt(ArrayToString(GridView2.GetSelectedRows())))

    End Sub

    Sub SaveData()
        Dim j, k As Integer

        If ds.Tables("Product").Rows.Count <= 0 And ds.Tables("ProductDel").Rows.Count <= 0 Then
            MsgBox("無數據存在！")
            Exit Sub
        End If

        Dim PC As New ProductionProductInnerControl
        If ds.Tables("ProductDel").Rows.Count > 0 Then
            For k = 0 To ds.Tables("ProductDel").Rows.Count - 1
                PC.ProductionProductInner_Delete(ds.Tables("ProductDel").Rows(k)("AutoID").ToString)
            Next
        End If
        '------------------------
        For j = 0 To ds.Tables("Product").Rows.Count - 1
            Dim pi As New ProductionProductInnerInfo

            pi.Pro_Type = ds.Tables("Product").Rows(j)("Pro_Type").ToString
            pi.PM_M_Code = ds.Tables("Product").Rows(j)("PM_M_Code").ToString
            pi.PM_Type = ds.Tables("Product").Rows(j)("PM_Type").ToString

            pi.Pro_Type1 = ds.Tables("Product").Rows(j)("Pro_Type1").ToString
            pi.PM_M_Code1 = ds.Tables("Product").Rows(j)("PM_M_Code1").ToString
            pi.PM_Type1 = ds.Tables("Product").Rows(j)("PM_Type1").ToString

            pi.AddDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
            pi.AddAction = InUserID

            If PC.ProductionProductInner_Add(pi) = True Then
            Else
                MsgBox("部分保存失敗請檢查!")
                Exit Sub
            End If
        Next

        MsgBox("保存成功!")

    End Sub


    Sub LoadData(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String)
        ds.Tables("Product").Clear()
        ds.Tables("ProductDel").Clear()

        Dim Pcc As New ProductionProductInnerControl
        Dim Pil As New List(Of ProductionProductInnerInfo)

        Pil = Pcc.ProductionProductInner_GetList(Pro_Type, PM_M_Code, PM_Type, Nothing, Nothing, Nothing)

        If Pil.Count <= 0 Then
            Exit Sub
        End If

        Dim row As DataRow
        Dim j As Integer
        For j = 0 To Pil.Count - 1
            row = ds.Tables("Product").NewRow
            row("AutoID") = Pil(j).AutoID

            row("Pro_Type") = Pil(j).Pro_Type
            row("PM_M_Code") = Pil(j).PM_M_Code
            row("PM_Type") = Pil(j).PM_Type

            row("Pro_Type1") = Pil(j).Pro_Type1
            row("PM_M_Code1") = Pil(j).PM_M_Code1
            row("PM_Type1") = Pil(j).PM_Type1

            ds.Tables("Product").Rows.Add(row)
        Next

    End Sub



    Private Sub Grid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid1.Click
        If LoadBz = "Y" Then
        Else
            Exit Sub
        End If

        Dim strPM_M_Code As String
        Dim strPM_Type As String

        Try
            strPM_M_Code = GridView1.GetFocusedRowCellValue("PM_M_Code").ToString
            strPM_Type = GridView1.GetFocusedRowCellValue("PM_Type").ToString
        Catch ex As Exception
            Me.Grid1.Select()
            MsgBox("請先選擇[左側]被關聯的產品編號!")
            Exit Sub
        End Try


        PM_M_Code2.EditValue = Nothing
        gluType2.EditValue = Nothing

        LoadData(cbType.EditValue, strPM_M_Code, strPM_Type)
    End Sub

    Private Sub cbType2_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbType2.EditValueChanged
        If LoadBz <> "Y" Then Exit Sub
        If cbType2.EditValue = "" Then Exit Sub

        PM_M_Code2.Properties.ValueMember = "PM_M_Code"
        PM_M_Code2.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code2.Properties.DataSource = pc.ProcessMain_GetList3(Nothing, Nothing)

        PM_M_Code2_EditValueChanged(Nothing, Nothing)
        gluType2.EditValue = Nothing

    End Sub

    Private Sub cbType2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbType2.SelectedIndexChanged

    End Sub
End Class
Imports LFERP.DataSetting
Imports LFERP.Library.ProductionPieceWorkGroup

Public Class ProductionPiecePersonnelDayFind
    Dim ds As New DataSet

    Private Sub ProductionPiecePersonnelDayFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        AddRow()


        '加載廠別名稱
        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)


        Start_Date.Text = Format(Now, "yyyy/MM/dd")
        End_Date.Text = Format(Now, "yyyy/MM/dd")

    End Sub


    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("Type")
            .Columns.Add("Per_PayType")
            .Columns.Add("Remark")
        End With
        luePer_PayType.Properties.DataSource = ds.Tables("Type")
        luePer_PayType.Properties.DisplayMember = "Per_PayType"
        luePer_PayType.Properties.ValueMember = "Per_PayType"


        '' ''增加無組別員工，進行個人計件的2012-5-8
        With ds.Tables.Add("G_NOName")
            .Columns.Add("G_NO")
            .Columns.Add("G_Name")
        End With
        gluDepID.Properties.DisplayMember = "G_Name"
        gluDepID.Properties.ValueMember = "G_NO"
        gluDepID.Properties.DataSource = ds.Tables("G_NOName")

    End Sub
    Sub AddRow()
        Dim row As DataRow
        ds.Tables("Type").Clear()
        row = ds.Tables("Type").NewRow()
        row("Per_PayType") = "計件"
        row("Remark") = "工序計件類"
        ds.Tables("Type").Rows.Add(row)
        row = ds.Tables("Type").NewRow()
        row("Per_PayType") = "計時"
        row("Remark") = "車床及CNC計時類"
        ds.Tables("Type").Rows.Add(row)
        row = ds.Tables("Type").NewRow()
        row("Per_PayType") = "日薪"
        row("Remark") = "承包組內日薪員工"
        ds.Tables("Type").Rows.Add(row)
    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Dim dc As New DepartmentControler
        If lueFacID.EditValue Is Nothing Then Exit Sub

        gluDepID.Properties.DisplayMember = "DepName"
        gluDepID.Properties.ValueMember = "DepID"
        gluDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)
    End Sub

    Private Sub gluDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluDepID.EditValueChanged
        'Dim gc As New ProductionPieceWorkGroupControl
        If gluDepID.EditValue Is Nothing Then Exit Sub

        'lueG_NO.Properties.DisplayMember = "G_Name"
        'lueG_NO.Properties.ValueMember = "G_NO"
        'lueG_NO.Properties.DataSource = gc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, gluDepID.EditValue, Nothing, Nothing, Nothing, Nothing)

        Dim pc As New ProductionPieceWorkGroupControl
        Dim pcL As List(Of ProductionPieceWorkGroupInfo)

        ds.Tables("G_NOName").Clear()

        Dim row1 As DataRow
        row1 = ds.Tables("G_NOName").NewRow
        row1("G_NO") = "無"
        row1("G_Name") = "無"
        ds.Tables("G_NOName").Rows.Add(row1)
        pcL = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, gluDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing)
        If pcL.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To pcL.Count - 1
                Dim row As DataRow
                row = ds.Tables("G_NOName").NewRow
                row("G_NO") = pcL(i).G_NO
                row("G_Name") = pcL(i).G_Name
                ds.Tables("G_NOName").Rows.Add(row)
            Next
        End If

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtPer_NO.Text.Trim = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = txtPer_NO.Text.Trim
        End If

        If txtPer_Name.EditValue = "" Then
            tempValue3 = Nothing
        Else
            tempValue4 = txtPer_Name.EditValue
        End If

        If lueFacID.EditValue = "" Then
            tempValue4 = strInFacID
        Else
            tempValue4 = lueFacID.EditValue
        End If
        If gluDepID.EditValue = "" Then
            tempValue5 = strInDepID
        Else
            tempValue5 = gluDepID.EditValue
        End If

        If lueG_NO.EditValue = "" Then
            tempValue6 = Nothing
        Else
            tempValue6 = lueG_NO.EditValue
        End If

        If luePer_PayType.EditValue = "" Then
            tempValue7 = Nothing
        Else
            tempValue7 = luePer_PayType.EditValue
        End If

        If Start_Date.Text.Trim = "" Then
            tempValue8 = Nothing
        Else
            tempValue8 = Start_Date.Text.Trim
        End If

        If End_Date.Text.Trim = "" Then
            tempValue9 = Nothing
        Else
            tempValue9 = End_Date.Text.Trim
        End If

        tempValue = "F"

        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
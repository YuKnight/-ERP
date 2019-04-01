Imports LFERP.DataSetting
Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionPieceWorkGroup


Public Class ProductionSumTimeFind
    Dim Str_Choice As String
    Dim ds As New DataSet


    Private Sub ProductionSumTimeFind_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Str_Choice = tempValue

        '更紅嘿
        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)


        If Str_Choice = "G" Then
            GluG_NO.Enabled = True
            LabCaption.Text = "舱璸琩高"
            Me.Text = "舱璸琩高"
            CreateTable()
            ds.Tables("Record").Clear()
            txtPer_NO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Else
            LabCaption.Text = "璸琩高"
            Me.Text = "璸琩高"
            GluG_NO.Enabled = False
        End If
        Start_Date.EditValue = Format(Now, "yyyy/MM/dd")
        End_Date.EditValue = Format(Now, "yyyy/MM/dd")

        lueFacID.Select()
        lueFacID.Focus()

        ''--------------------琩高ノめ舦------------------------
        If strInUserRank = "ネ玻场" Then
            lueFacID.EditValue = strInFacIDFull
        ElseIf strInUserRank = "恨瞶" Then
        ElseIf strInUserRank = "参璸" Then
            lueFacID.EditValue = strInFacIDFull
            lueDepID.EditValue = strInDepIDFull
        End If
        ''-------------------------------------------------
    End Sub

    Sub CreateTable()
        '' ''糤礚舱秈︽璸ン2012-5-8

        With ds.Tables.Add("Record")
            .Columns.Add("R_Per_NO")
        End With

        txtPer_NO.Properties.DataSource = ds.Tables("Record")
        txtPer_NO.Properties.ValueMember = "R_Per_NO"
        txtPer_NO.Properties.DisplayMember = "R_Per_NO"
    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Dim dc As New DepartmentControler
        If lueFacID.EditValue Is Nothing Then Exit Sub

        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If txtPer_NO.EditValue = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = txtPer_NO.EditValue
        End If

        If Str_Choice = "G" Then  ''舱璸琩高
            If GluG_NO.EditValue = Nothing Then
                tempValue3 = Nothing
            Else
                tempValue3 = GluG_NO.EditValue
            End If
        Else
            tempValue3 = Nothing
        End If

        If lueFacID.EditValue = "" Then
            tempValue5 = Nothing
        Else
            tempValue5 = lueFacID.EditValue
        End If

        If lueDepID.EditValue = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = lueDepID.EditValue
        End If


        If Start_Date.Text = "" Then
            tempValue6 = Nothing
        Else
            tempValue6 = Start_Date.Text
        End If

        If End_Date.Text = "" Then
            tempValue7 = Nothing
        Else
            tempValue7 = End_Date.Text
        End If

        tempValue = "F"
        Me.Close()

    End Sub

    Private Sub lueDepID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDepID.EditValueChanged

        If lueDepID.EditValue Is Nothing Or lueFacID.EditValue Is Nothing Then Exit Sub

        If Str_Choice = "P" Then
            Dim ptc As New ProductionPiecePersonnelControl  ''更 絪腹---﹎---场
            txtPer_NO.Properties.DataSource = ptc.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing, "False", Nothing, Nothing)
            txtPer_NO.Properties.DisplayMember = "Per_NOName"
            txtPer_NO.Properties.ValueMember = "Per_NO"
        Else
            Dim pc As New ProductionPieceWorkGroupControl
            GluG_NO.Properties.DataSource = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, lueDepID.EditValue, lueFacID.EditValue, Nothing, Nothing, Nothing)
            GluG_NO.Properties.DisplayMember = "G_NOName"
            GluG_NO.Properties.ValueMember = "G_NO"
        End If
    End Sub

    Private Sub txtPer_NO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPer_NO.EditValueChanged
        If txtPer_NO.EditValue <> "" And Str_Choice = "G" Then
            Dim row1 As DataRow
            row1 = ds.Tables("Record").NewRow()
            row1("R_Per_NO") = txtPer_NO.Text
            ds.Tables("Record").Rows.Add(row1)
        End If
    End Sub
End Class
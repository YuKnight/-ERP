Imports LFERP.Library.Product
Imports LFERP.DataSetting
Imports LFERP.Library.ProductionField
Imports LFERP.Library.ProductProcess

Public Class ProductionWareOutSelect

    Private Sub ProductionWareOutSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '加載廠別名稱
        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)

        Dim mc As New ProcessMainControl
        PM_M_Code.Properties.DisplayMember = "PM_M_Code"
        PM_M_Code.Properties.ValueMember = "PM_M_Code"
        PM_M_Code.Properties.DataSource = mc.ProcessMain_GetList3(Nothing, Nothing)

        DateEdit1.EditValue = Format(Now, "yyyy/MM/dd")
        DateEdit2.EditValue = Format(Now, "yyyy/MM/dd")


        lueFacID.EditValue = strInFacIDFull
        lueDepID.EditValue = strInDepIDFull

        lueFacID.Select()
    End Sub



    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tempValue = Nothing
        Me.Close()
    End Sub



    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Dim dc As New DepartmentControler
        If lueFacID.EditValue Is Nothing Then Exit Sub

        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(Nothing, Nothing, lueFacID.EditValue)
        lueDepID.EditValue = Nothing     '@ 2012/8/13 添加
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        tempValue = "F"

        If lueFacID.EditValue Is Nothing Or lueFacID.EditValue = "" Then
            tempValue2 = Nothing
        Else
            tempValue2 = lueFacID.EditValue
        End If

        If lueDepID.EditValue Is Nothing Or lueDepID.EditValue = "" Then
            tempValue3 = Nothing
        Else
            tempValue3 = lueDepID.EditValue
        End If

        If TextEdit1.Text = "" Then
            tempValue4 = Nothing
        Else
            tempValue4 = TextEdit1.EditValue
        End If

        If PM_M_Code.EditValue Is Nothing Or PM_M_Code.EditValue = "" Then
            tempValue5 = Nothing
        Else
            tempValue5 = PM_M_Code.EditValue
        End If


        tempValue6 = DateEdit1.EditValue
        tempValue7 = DateEdit2.EditValue

        If ComboBoxEdit1.Text = "未審核" Then
            tempValue8 = "False"
        ElseIf ComboBoxEdit1.Text = "已審核" Then
            tempValue8 = "True"
        ElseIf ComboBoxEdit1.Text = "全部" Then
            tempValue8 = Nothing
        End If


        Me.Close()

    End Sub

    '@ 2012/8/13 添加  按空格鍵彈出下拉菜單
    Private Sub PM_M_Code_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PM_M_Code.KeyDown, ComboBoxEdit1.KeyDown
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class
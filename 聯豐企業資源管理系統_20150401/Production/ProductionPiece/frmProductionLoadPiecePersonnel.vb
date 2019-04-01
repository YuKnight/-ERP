Imports LFERP.DataSetting

Public Class frmProductionLoadPiecePersonnel

    Dim strPDepID, strPFacID, strPDepName, strPFacName As String

    Private Sub frmProductionLoadPiecePersonnel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tempValue = Nothing
        strPFacID = tempValue2
        strPDepID = tempValue3

        tempValue2 = Nothing
        tempValue3 = Nothing

        '加載廠別名稱
        Dim fc As New FacControler
        lueFacID.Properties.DisplayMember = "FacName"
        lueFacID.Properties.ValueMember = "FacID"
        lueFacID.Properties.DataSource = fc.GetFacList(strInFacID, Nothing)

        lueFacID.EditValue = strPFacID
        lueDepID.EditValue = strPDepID
        ''

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tempValue = Nothing
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If TextEditPerNO.Text = "" Then
            MsgBox("廠証編號不能為空！")
            Exit Sub
        End If

        If lueFacID.EditValue Is Nothing Then
            MsgBox("請選擇要加入的廠別！")
            Exit Sub
        End If

        If lueDepID.EditValue Is Nothing Then
            MsgBox("請選擇要加入的部門！")
            Exit Sub
        End If

        tempValue = TextEditPerNO.Text
        tempValue2 = lueFacID.EditValue
        tempValue3 = lueDepID.EditValue

        Me.Close()

    End Sub

    Private Sub TextEditPerNO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextEditPerNO.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSave_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub lueFacID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFacID.EditValueChanged
        Dim dc As New DepartmentControler
        If lueFacID.EditValue Is Nothing Then Exit Sub

        lueDepID.Properties.DisplayMember = "DepName"
        lueDepID.Properties.ValueMember = "DepID"
        lueDepID.Properties.DataSource = dc.BriName_GetList(strInDepID, Nothing, lueFacID.EditValue)



    End Sub

    Private Sub lueFacID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lueFacID.KeyDown
        If e.KeyCode = Keys.Space Then
            lueFacID.ShowPopup()
        End If
    End Sub

    Private Sub lueDepID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lueDepID.KeyDown
        If e.KeyCode = Keys.Space Then
            lueDepID.ShowPopup()
        End If
    End Sub
End Class
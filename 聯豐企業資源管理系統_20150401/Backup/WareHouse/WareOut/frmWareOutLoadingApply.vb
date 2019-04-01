Imports LFERP.Library.Purchase.Apply
Imports LFERP.Library.WareHouse.WareInventory
Imports LFERP.DataSetting


Public Class frmWareOutLoadingApply

    Dim apc As New ApplyControl
    Dim ds As New DataSet
    Dim StrCompany As String
    Dim mc As New LFERP.DataSetting.MeGaShareControl

    Private Sub frmWareOutLoadingApply_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        gluCompany.Properties.DisplayMember = "Company_Name"
        gluCompany.Properties.ValueMember = "Company_ID"
        gluCompany.Properties.DataSource = mc.CompanyUnion_GetList(Nothing, Nothing, strInCompany)
        gluCompany.EditValue = mc.CompanyUnion_GetList(Nothing, Nothing, strInCompany)(0).Company_ID

        StrCompany = gluCompany.EditValue

        gluSupplier.Properties.DisplayMember = "Department_Name"
        gluSupplier.Properties.ValueMember = "Department_ID"
        gluSupplier.Properties.DataSource = mc.DepartmentMeGa_GetList(Nothing, StrCompany, Nothing)

        Label3.Text = tempValue3
        CreateTable()
        tempValue3 = ""

    End Sub

    Sub CreateTable()

        ds.Tables.Clear()

        With ds.Tables.Add("Apply")

            .Columns.Add("AM_ID", GetType(String))
            .Columns.Add("M_ID", GetType(String))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Qty", GetType(Double))
            .Columns.Add("M_SendQty", GetType(Double))
            .Columns.Add("WI_Qty", GetType(Double))
            .Columns.Add("tuihuanhuonum", GetType(Double))
            .Columns.Add("M_Department", GetType(String))
            .Columns.Add("M_UserID", GetType(String))
            .Columns.Add("GoIn", GetType(Boolean))

        End With

        Grid.DataSource = ds.Tables("Apply")

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        
        ds.Tables("Apply").Clear()

        Dim strNo, strName, strAM_ID_Pri, strM_Department_Pri, strM_UserID_Pri As String

        If Len(txtPM_NO.Text.Trim) = 0 Then
            strNo = Nothing
        Else
            strNo = txtPM_NO.Text
        End If

        If Len(txtName.Text.Trim) = 0 Then
            strName = Nothing
        Else
            strName = txtName.Text
        End If

        If gluSupplier.EditValue = "" Then
            gluSupplier.EditValue = Nothing
        End If

        If txtAM_ID_Pri.Text.Trim = "" Then
            strAM_ID_Pri = Nothing
        Else
            strAM_ID_Pri = txtAM_ID_Pri.Text.Trim
        End If

        If txtM_UserID_Pri.Text.Trim = "" Then
            strM_UserID_Pri = Nothing
        Else
            strM_UserID_Pri = txtM_UserID_Pri.Text.Trim
        End If

        If txtM_Department_Pri.Text.Trim = "" Then
            strM_Department_Pri = Nothing
        Else
            strM_Department_Pri = txtM_Department_Pri.Text.Trim
        End If

        Dim ai As List(Of ApplyInfo)
        Dim aic As New ApplyControl

        ai = aic.Apply_GetList1(strNo, Nothing, Nothing, Nothing, gluSupplier.EditValue, strName, "N", strAM_ID_Pri, strM_Department_Pri, strM_UserID_Pri)
        If ai.Count = 0 Then
            MsgBox("不存在此查詢條件的申領信息,請確認!")
            Exit Sub
        Else
            Dim i As Integer

            For i = 0 To ai.Count - 1
                Dim row As DataRow

                row = ds.Tables("Apply").NewRow

                row("AM_ID") = ai(i).AM_ID
                row("M_ID") = ai(i).M_ID
                row("M_Code") = ai(i).M_Code
                row("M_Name") = ai(i).M_Name
                row("M_Qty") = ai(i).M_Qty
                row("M_SendQty") = ai(i).M_SendQty
                row("tuihuanhuonum") = ai(i).Tuihuanhuonum

                Dim wi As WareInventoryInfo
                Dim wic As New WareInventoryMTController
                wi = wic.WareInventory_GetSub(ai(i).M_Code, Label3.Text)

                If wi Is Nothing Then
                    row("WI_Qty") = 0
                Else
                    row("WI_Qty") = wi.WI_Qty
                End If

                row("M_Department") = ai(i).M_Department
                row("M_UserID") = ai(i).M_UserID
                row("GoIn") = False

                ds.Tables("Apply").Rows.Add(row)

                GridView1.MoveLast()
            Next

        End If


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If GridView1.RowCount = 0 Then Exit Sub

        Dim i As Integer
        For i = 0 To ds.Tables("Apply").Rows.Count - 1
            If ds.Tables("Apply").Rows(i)("GoIn") = True Then
                arl1.Add(ds.Tables("Apply").Rows(i)("AM_ID").ToString)
                arl2.Add(ds.Tables("Apply").Rows(i)("M_ID").ToString)
            End If
        Next
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtAM_ID_Pri_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAM_ID_Pri.KeyDown, txtPM_NO.KeyDown, txtName.KeyDown, txtM_UserID_Pri.KeyDown, txtM_Department_Pri.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub gluCompany_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gluCompany.EditValueChanged
        On Error Resume Next
        StrCompany = gluCompany.EditValue

        gluSupplier.Properties.DisplayMember = "Department_Name"
        gluSupplier.Properties.ValueMember = "Department_ID"
        gluSupplier.Properties.DataSource = mc.DepartmentMeGa_GetList(Nothing, StrCompany, Nothing)

    End Sub

    Private Sub RepositoryItemCheckEdit1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RepositoryItemCheckEdit1.CheckedChanged
        Dim i%
        For i = 0 To GridView1.RowCount - 1
            If i <> GridView1.FocusedRowHandle Then
                If sender.checked = True Then
                    If ds.Tables("Apply").Rows(i)("M_Code").ToString = ds.Tables("Apply").Rows(GridView1.FocusedRowHandle)("M_Code").ToString And ds.Tables("Apply").Rows(i)("GoIn") = True Then
                        MsgBox("同一張出庫單中不能導入相同的出庫物料！", 64, "提示")
                        sender.checked = False
                        Exit Sub
                    End If
                End If
            End If
        Next

        '-----------------------------------變更申領記錄以前判斷當前申領單號是否存在有加簽記錄--------
        Dim ei As List(Of EndorsementInfo)
        Dim ec As New EndorsementControl

        ei = ec.Endorsement_GetList(GridView1.GetFocusedRowCellValue("AM_ID"), Nothing, Nothing)
        If ei.Count > 0 Then
            If ei(0).AM_Type = "審核通過" And ei(0).AM_Check = True Then

            ElseIf ei(0).AM_Type = "審核退回" And ei(0).AM_Check = True Then
                MsgBox("此申領單加簽記錄被退回,不允許發貨!")
                sender.checked = False
            Else
                MsgBox("此申領單存在加簽記錄且未審核,不允許發貨!")
                sender.checked = False
            End If

        End If
    End Sub

    Private Sub gluSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gluSupplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            SimpleButton1_Click(Nothing, Nothing)
        End If
        If e.KeyCode = Keys.Space Then
            sender.ShowPopup()
        End If
    End Sub
End Class
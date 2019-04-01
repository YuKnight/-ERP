Imports LFERP.Library.Purchase.ApplyPurchase

Public Class frmPurchaseApply
    Dim apc As New ApplyPurchaseControl
    Dim ds As New DataSet

    Sub CreateTable()
        ds.Tables.Clear()
        With ds.Tables.Add("ApplyPurchase")

            .Columns.Add("AP_ID", GetType(String))
            .Columns.Add("AP_Num", GetType(String))
            .Columns.Add("AP_ApplyID", GetType(String))
            .Columns.Add("AP_M_Code", GetType(String))
            .Columns.Add("AP_M_Gauge", GetType(String))
            .Columns.Add("AP_M_Name", GetType(String))
            .Columns.Add("AP_M_Unit", GetType(String))
            .Columns.Add("AP_Qty", GetType(String))
            .Columns.Add("AP_P_Qty", GetType(String))
            .Columns.Add("AP_CheckWare", GetType(Boolean))
            .Columns.Add("AP_Applyreason", GetType(String))
            .Columns.Add("AP_ApplyDate", GetType(String))
            .Columns.Add("AP_ApplyDptID", GetType(String))
            .Columns.Add("AP_ApplyDptName", GetType(String))
            .Columns.Add("AP_ApplyPersonName", GetType(String))
            .Columns.Add("AP_CheckPurchase", GetType(Boolean))
        End With

        Grid1.DataSource = ds.Tables("ApplyPurchase")
    End Sub

    Sub LoadApplyPurchase()
        Dim ai As List(Of ApplyPurchaseInfo)
        ds.Tables("ApplyPurchase").Clear()
        ai = apc.ApplyPurchase_GetList2(txtID.Text, txtCode.Text, txtName.Text)
        If ai Is Nothing Then Exit Sub
        Dim i As Integer
        Dim row As DataRow
        For i = 0 To ai.Count - 1
            row = ds.Tables("ApplyPurchase").NewRow
            row("AP_ID") = ai(i).AP_ID
            row("AP_Num") = ai(i).AP_Num
            row("AP_M_Code") = ai(i).AP_M_Code
            row("AP_M_Gauge") = ai(i).AP_M_Gauge
            row("AP_M_Name") = ai(i).AP_M_Name
            row("AP_P_Qty") = ai(i).AP_P_Qty
            row("AP_Qty") = ai(i).AP_Qty
            row("AP_M_Unit") = ai(i).AP_M_Unit
            row("AP_Applyreason") = ai(i).AP_Applyreason
            row("AP_ApplyDptName") = ai(i).AP_ApplyDptName
            row("AP_ApplyPersonName") = ai(i).AP_ApplyPersonName
            row("AP_CheckPurchase") = False
            ds.Tables("ApplyPurchase").Rows.Add(row)
        Next
    End Sub

    Private Sub frmPurchaseApply_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtID.Text = ""
        txtCode.Text = ""
        txtName.Text = ""
        'CreateTable()
        'LoadApplyPurchase()
        Grid1.DataSource = Nothing
        Me.Left = MDIMain.Width - Me.Width - 30
        Me.Top = (MDIMain.Height - Me.Height) / 2
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        CreateTable()
        LoadApplyPurchase()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Dim i, n%
        tempAPNum = ""
        n = 0
        For i = 0 To ds.Tables("ApplyPurchase").Rows.Count - 1
            If ds.Tables("ApplyPurchase").Rows(i)("AP_CheckPurchase") = True Then
                If n = 0 Then
                    tempAPNum = ds.Tables("ApplyPurchase").Rows(i)("AP_Num")
                    n = 1
                Else
                    tempAPNum = tempAPNum & "," & ds.Tables("ApplyPurchase").Rows(i)("AP_Num")
                End If
            End If
        Next
        If tempAPNum = "" Then
            MsgBox("請選擇採購物料!", 64, "提示")
        Else
            Me.Close()
        End If

    End Sub

    Private Sub txtID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtID.KeyDown, txtCode.KeyDown, txtName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdFind_Click(Nothing, Nothing)
        End If
    End Sub
End Class
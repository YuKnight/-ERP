Imports LFERP.Library.ProductionOutProcess

Public Class FrmProductionOWPAcceptanceSelect
    Dim ds As New DataSet
    ''' <summary>
    ''' 載入數據表
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTables()   '
        ds.Tables.Clear()
        With ds.Tables.Add("Add_OutWare")
            .Columns.Add("PO_ID", GetType(String))
            .Columns.Add("PM_M_Code", GetType(String))
            .Columns.Add("PM_Type", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
            .Columns.Add("AutoID", GetType(String))
        End With

        DataGridView1.DataSource = ds.Tables("Add_OutWare")
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        '  On Error Resume Next
        tempValue = ""
        If txtPM_NO.Text = "" Then
            tempValue5 = ""
        Else
            tempValue5 = txtPM_NO.Text
        End If
        Dim i, n As Integer
        n = 0

        For i = 0 To DataGridView1.RowCount - 1

            If DataGridView1.Rows(i).Cells("GoIn").Value = True Then
                If n = 0 Then
                    tempValue = DataGridView1.Rows(i).Cells("AutoID").Value.ToString
                    n = n + 1
                Else
                    tempValue = tempValue & "," & DataGridView1.Rows(i).Cells("AutoID").Value.ToString
                    n = n + 1
                End If
            End If

        Next
        If tempValue = "" Then
            MsgBox("請選擇加入的物料!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            Exit Sub
        End If

        RefreshT = True
        Me.Close()
    End Sub

    Private Sub FrmProductionOWPAcceptanceSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Columns("AutoID").Visible = False
        CreateTables()
    End Sub

    Private Sub CmdLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLoad.Click
        ' On Error Resume Next
        If txtPM_NO.Text = "" Then

        Else
            'txtPM_NO.Enabled = False
            Dim psc As New ProductionOutProcessControl
            Dim psi As New List(Of ProductionOutProcessInfo)

            psi = psc.ProductionOutProcess_GetList(Nothing, Trim(txtPM_NO.Text), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            If psi.Count > 0 Then
            Else
                Exit Sub
            End If
            If psi(0).PO_Check = True Then
                DataGridView1.AutoGenerateColumns = False
                DataGridView1.DataSource = psc.ProductionOutProcess_GetList(Nothing, Trim(txtPM_NO.Text), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Else
                Exit Sub
            End If
        End If
    End Sub
    Private Sub txtPM_NO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPM_NO.KeyDown

        If e.KeyCode = Keys.Enter Then
            CmdLoad_Click(Nothing, Nothing)
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        RefreshT = False
        Me.Close()
    End Sub
End Class
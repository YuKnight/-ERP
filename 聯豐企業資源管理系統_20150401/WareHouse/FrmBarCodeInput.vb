Imports LFERP.Library.WareHouse.WareInput
Imports LFERP.Library

Public Class FrmBarCodeInput
    Public Mcoderray As Array
    Public Qtyrray As Array
    Public ds As New DataSet
    Dim tempStr As String
    Private Sub FrmBarCodeInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tempStr = tempValue4
        tempValue4 = ""
        CreateTables()
        AddRow("")
        GridView1.Focus()
        GridView1.FocusedColumn = GridView1.Columns("M_Code")

    End Sub

    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("BarCode")
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("WIP_Qty", GetType(Single))
        End With
        Grid.DataSource = ds.Tables("BarCode")

    End Sub
    Sub AddRow(ByVal strCode As String)

        Dim row As DataRow
        row = ds.Tables("BarCode").NewRow

        If strCode = "" Then


            row("WIP_Qty") = 0
            ds.Tables("BarCode").Rows.Add(row)

        End If
        GridView1.MoveLast()
    End Sub
    Sub celloadmsg(ByVal strCode As String)
        Dim i As Integer
        If strCode = "" Then
        Else

            For i = ds.Tables("BarCode").Rows.Count - 2 To 0 Step -1
                If ds.Tables("BarCode").Rows(ds.Tables("BarCode").Rows.Count - 1)("M_Code") = ds.Tables("BarCode").Rows(i)("M_Code") Then
                    ds.Tables("BarCode").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
                    MsgBox("一張單不允許有重復物料編碼.,已經刪除此單!")
                    Exit Sub
                End If
            Next
            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)

            ds.Tables("BarCode").Rows(GridView1.FocusedRowHandle)("M_Name") = objInfo.M_Name
            ds.Tables("BarCode").Rows(GridView1.FocusedRowHandle)("M_Unit") = objInfo.M_Unit
            ds.Tables("BarCode").Rows(GridView1.FocusedRowHandle)("M_Gauge") = objInfo.M_Gauge

            If IsDBNull(ds.Tables("BarCode").Rows(GridView1.FocusedRowHandle)("M_Code")) Then

            Else
                Dim wc As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                Dim wiL As New LFERP.Library.WareHouse.WareInventory.WareInventoryInfo

                wiL = wc.WareInventory_GetSub(ds.Tables("BarCode").Rows(GridView1.FocusedRowHandle)("M_Code"), tempStr)
                ds.Tables("BarCode").Rows(GridView1.FocusedRowHandle)("WIP_Qty") = wiL.WI_Qty

            End If

            GridView1.RefreshData()

        End If
    End Sub
    Private Sub MCodeText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MCodeText.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            GridView1.FocusedColumn = GridView1.Columns("WIP_Qty")

        End If
       
    End Sub

    Private Sub QtyEdit_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles QtyEdit.KeyDown
        If e.KeyCode = Keys.Enter Then
            AddRow("")
            GridView1.FocusedColumn = GridView1.Columns("M_Code")

        End If
    End Sub


    Private Sub GridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles GridView1.FocusedColumnChanged
        On Error Resume Next
        If e.PrevFocusedColumn.FieldName = "M_Code" Then

            celloadmsg(ds.Tables("BarCode").Rows(GridView1.FocusedRowHandle)("M_Code").ToString)
            GridView1.FocusedColumn = GridView1.Columns("WIP_Qty")
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        ds.Tables("BarCode").Clear()
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        Me.Close()

    End Sub

    Private Sub DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE.Click
        ds.Tables("BarCode").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub GridView1_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.RowCountChanged
        If GridView1.RowCount > 0 Then
            DELETE.Enabled = True
        Else
            DELETE.Enabled = False
        End If
    End Sub
End Class

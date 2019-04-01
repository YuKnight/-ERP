Imports LFERP.Library.WareHouse
Imports LFERP.Library.WareHouse.WareBorrowReturn

Public Class frmWareReturnLoad
    Public DSA As New DataSet


    Private Sub frmWareReturnLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tempValue = Nothing
        txtPerNO.Text = tempValue2
        tempValue2 = Nothing
        CreateTables()
        Me.Text = "還刀信息載入"
    End Sub

    Sub CreateTables()
        DSA.Tables.Clear()
        With DSA.Tables.Add("ReturnLoad")
            .Columns.Add("GOIN", GetType(Boolean))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("M_Unit", GetType(String))
            .Columns.Add("Qty", GetType(Single))
            .Columns.Add("Qty1", GetType(Single))
        End With

        Grid.DataSource = DSA.Tables("ReturnLoad")
    End Sub

    Private Sub ButtonLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoad.Click
        LoadData()
    End Sub

    Sub LoadData()

        DSA.Tables("ReturnLoad").Clear()

        Dim rcc As New WareBorrowReturnControl
        Dim Rcl As New List(Of WareBorrowReturnInfo)

        If RadioPerID.Checked = True Then
            Rcl = rcc.WareBorrowReturn_Sum("借刀", Nothing, txtPerNO.Text, Nothing)
        End If

        If RadioWBNO.Checked = True Then
            If txtWRNO.Text = "" Then

                MsgBox("借刀單不能為空!")
                txtWRNO.Focus()
                txtWRNO.Select()
                Exit Sub
            End If
            Rcl = rcc.WareBorrowReturn_Sum("借刀", Nothing, txtPerNO.Text, txtWRNO.Text)
        End If

        If RadioM_Code.Checked = True Then
            If txtWRNO.Text = "" Then
                MsgBox("刀具編碼不能為空!")
                txtWRNO.Focus()
                txtWRNO.Select()
                Exit Sub
            End If
            Rcl = rcc.WareBorrowReturn_Sum("借刀", txtM_Code.Text, txtPerNO.Text, Nothing)
        End If


        If Rcl.Count <= 0 Then
            MsgBox("指定條件無借刀記錄!")
            Exit Sub
        End If

        Dim j As Integer

        For j = 0 To Rcl.Count - 1
            If Rcl(j).SumNO_ReQty <> 0 Then
                Dim row As DataRow
                row = DSA.Tables("ReturnLoad").NewRow
                row("GOIN") = False
                row("M_Code") = Rcl(j).M_Code
                row("M_Name") = Rcl(j).M_Name
                row("M_Gauge") = Rcl(j).M_Gauge
                row("M_Unit") = Rcl(j).M_Unit
                row("Qty") = Rcl(j).SumNO_ReQty

                Dim rcc1 As New WareBorrowReturnControl
                Dim Rcl1 As New List(Of WareBorrowReturnInfo)
                Rcl1 = rcc1.WareBorrowReturn_Sum("還刀", Rcl(j).M_Code, txtPerNO.Text, Nothing)
                If Rcl1.Count > 0 Then
                    row("Qty1") = Rcl(j).SumQty - Rcl1(0).SumQty
                Else
                    row("Qty1") = Rcl(j).SumQty
                End If

                DSA.Tables("ReturnLoad").Rows.Add(row)
            End If
        Next
    End Sub


    Private Sub RadioPerID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioPerID.CheckedChanged, RadioWBNO.CheckedChanged, RadioM_Code.CheckedChanged
        If RadioPerID.Checked = True Then
            txtPerNO.Enabled = False
            txtWRNO.Enabled = False
            txtM_Code.Enabled = False
        End If

        If RadioWBNO.Checked = True Then
            txtPerNO.Enabled = False
            txtWRNO.Enabled = True
            txtM_Code.Enabled = False

            txtWRNO.Focus()
        End If

        If RadioM_Code.Checked = True Then
            txtPerNO.Enabled = False
            txtWRNO.Enabled = False
            txtM_Code.Enabled = True

            txtM_Code.Focus()
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        tempValue = Nothing
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If DSA.Tables("ReturnLoad").Rows.Count <= 0 Then
            MsgBox("無數據存在!")
            Exit Sub
        End If

        Dim i As Integer
        Dim bz As String = ""
        For i = 0 To DSA.Tables("ReturnLoad").Rows.Count - 1
            If DSA.Tables("ReturnLoad").Rows(i)("GOIN") = True Then
                bz = "Y"
            End If
        Next
        If bz = "" Then
            MsgBox("沒有選中任何數據!")
            Exit Sub
        End If
        ''--------------------------------------------------------------------

        tempValue = "Y"
        Me.Close()
    End Sub




End Class
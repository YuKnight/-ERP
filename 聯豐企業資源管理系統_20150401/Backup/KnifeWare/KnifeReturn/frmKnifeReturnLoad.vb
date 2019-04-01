Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.SystemManager
Imports LFERP.Library.KnifeWare

Public Class frmKnifeReturnLoad
    Dim mtc As New Material.MaterialTypeController

    Dim strWH_ID As String
    Public DSA As New DataSet

    Private Sub frmKnifeReturnLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtB_ID.Text = tempValue2
        strWH_ID = tempValue3
        tempValue2 = Nothing
        tempValue3 = Nothing

        mtc.LoadNodes(tv1, "60")
        CreateTables()


    End Sub
    Private Sub tv1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tv1.MouseDoubleClick
        '獲取選擇的類別編號
        If tv1.SelectedNode.Level = 3 Then
            popTypeID.Tag = tv1.SelectedNode.Tag
            popTypeID.EditValue = tv1.SelectedNode.Text
            PopupContainerControl1.OwnerEdit.ClosePopup()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub CreateTables()
        DSA.Tables.Clear()
        With DSA.Tables.Add("KnifeReturnLoad")
            .Columns.Add("GOIN", GetType(Boolean))
            .Columns.Add("M_Code", GetType(String))
            .Columns.Add("M_Name", GetType(String))
            .Columns.Add("M_Gauge", GetType(String))
            .Columns.Add("Qty", GetType(Double))
            .Columns.Add("Qty1", GetType(Double))
        End With

        Grid.DataSource = DSA.Tables("KnifeReturnLoad")
    End Sub

    Private Sub RadioPerID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioPerID.CheckedChanged, RadioM_Code.CheckedChanged, RadioType.CheckedChanged
        If RadioPerID.Checked = True Then
            txtB_ID.Enabled = False
            txtM_Code.Enabled = False
            popTypeID.Enabled = False
        End If

        If RadioM_Code.Checked = True Then
            txtB_ID.Enabled = False
            txtM_Code.Enabled = True
            popTypeID.Enabled = False

            txtM_Code.Focus()
        End If

        If RadioType.Checked = True Then
            txtB_ID.Enabled = False
            txtM_Code.Enabled = False
            popTypeID.Enabled = True

            popTypeID.Focus()
        End If
    End Sub

    Private Sub ButtonLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoad.Click
        LoadData()
    End Sub

    Sub LoadData()

        DSA.Tables("KnifeReturnLoad").Clear()

        Dim rcc As New KnifeReturnControl
        Dim Rcl As New List(Of KnifeReturnInfo)

        If RadioPerID.Checked = True Then
            Rcl = rcc.KnifeBorrow_NOReturnGroupGetList(txtB_ID.Text, Nothing, strWH_ID, Nothing, Nothing)
        End If

        If RadioM_Code.Checked = True Then
            If txtM_Code.Text = "" Then

                MsgBox("刀具編碼不能為空!", 64, "提示")
                txtM_Code.Focus()
                txtM_Code.Select()
                Exit Sub
            End If
            Rcl = rcc.KnifeBorrow_NOReturnGroupGetList(txtB_ID.Text, txtM_Code.Text, strWH_ID, Nothing, Nothing)
        End If

        If RadioType.Checked = True Then
            If popTypeID.Text = "" Then
                MsgBox("刀具類別不能為空!", 64, "提示")
                popTypeID.Focus()
                popTypeID.Select()
                Exit Sub
            End If
            Rcl = rcc.KnifeBorrow_NOReturnGroupGetList(txtB_ID.Text, Nothing, strWH_ID, Nothing, popTypeID.Tag)
        End If


        If Rcl.Count <= 0 Then
            MsgBox("指定條件無借刀記錄!", 64, "提示")
            Exit Sub
        End If

        Dim j As Integer

        For j = 0 To Rcl.Count - 1
            Dim row As DataRow
            row = DSA.Tables("KnifeReturnLoad").NewRow
            row("GOIN") = False
            row("M_Code") = Rcl(j).M_Code
            row("M_Name") = Rcl(j).M_Name
            row("M_Gauge") = Rcl(j).M_Gauge
            row("Qty") = Rcl(j).SumNOReturn

            Dim rcc1 As New KnifeReturnControl
            Dim Rcl1 As New List(Of KnifeReturnInfo)
            Rcl1 = rcc1.KnifeReturn_ALLSum(txtB_ID.Text, Rcl(j).M_Code, strWH_ID, Nothing)
            If Rcl1.Count > 0 Then
                row("Qty1") = Rcl(j).SumB_QTY - Rcl1(0).SumCountR_Qty
            Else
                row("Qty1") = Rcl(j).SumB_QTY
            End If

            DSA.Tables("KnifeReturnLoad").Rows.Add(row)
        Next
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If DSA.Tables("KnifeReturnLoad").Rows.Count <= 0 Then
            MsgBox("無數據存在!", 64, "提示")
            Exit Sub
        End If

        Dim i As Integer
        Dim bz As String = ""
        For i = 0 To DSA.Tables("KnifeReturnLoad").Rows.Count - 1
            If DSA.Tables("KnifeReturnLoad").Rows(i)("GOIN") = True Then
                bz = "Y"

                If DSA.Tables("KnifeReturnLoad").Rows(i)("Qty") <> DSA.Tables("KnifeReturnLoad").Rows(i)("Qty1") Then
                    If MsgBox(DSA.Tables("KnifeReturnLoad").Rows(i)("M_Code").ToString & "刀具編碼借還數量異常,是否繼續.(請及時與電腦部聯系)", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If

            End If
        Next
        If bz = "" Then
            MsgBox("沒有選中任何數據!", 64, "提示")
            Exit Sub
        End If
        ''--------------------------------------------------------------------

        tempValue = "Y"
        Me.Close()
    End Sub
End Class
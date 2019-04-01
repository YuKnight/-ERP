Imports LFERP.Library.ProductionController
Imports LFERP.DataSetting

Public Class frmProductionUserMain

    Dim pc As New UserPowerControl
    Dim ds As New DataSet
    Dim bc As New DepartmentControler

    Private Sub frmProductionUserMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Grid2.DataSource = pc.UserPower_GetList(Nothing, Nothing, Nothing, Nothing)  '生產中使用部門
        CreateTable()
    End Sub

    Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("UserPower")

            .Columns.Add("UserID", GetType(String))
            .Columns.Add("ControlDep", GetType(String))
            .Columns.Add("DepName", GetType(String))
            .Columns.Add("Check", GetType(Boolean))

            .Columns.Add("FacName", GetType(String))
        End With

        Grid1.DataSource = ds.Tables("UserPower")

    End Sub

    Private Sub Grid2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid2.MouseUp
        If GridView2.RowCount = 0 Then Exit Sub

        Dim strA As String
        strA = GridView2.GetFocusedRowCellValue("UserID").ToString

        Dim pi As List(Of DepartmentInfo)

        pi = bc.BriName_GetList(Nothing, Nothing, Nothing)

        ds.Tables("UserPower").Clear()

        Dim i As Integer
        Dim row As DataRow
        For i = 0 To pi.Count - 1

            row = ds.Tables("UserPower").NewRow

            row("UserID") = strA
            row("ControlDep") = pi(i).DepID
            row("DepName") = pi(i).DepName
            row("FacName") = pi(i).FacName

            Dim pfc As New ProductionFieldControl
            Dim pfi As List(Of ProductionFieldControlInfo)

            pfi = pfc.ProductionFieldControl_GetList(strA, pi(i).DepID)
            If pfi.Count = 0 Then
                row("Check") = False
            Else
                row("Check") = True
            End If

            ds.Tables("UserPower").Rows.Add(row)
        Next

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        '保存前---先刪除ProductionFieldControl表中記錄
        '保存后---得到最新的人員用戶擁有的部門權限
        Dim pfc As New ProductionFieldControl
        Dim pfi As New ProductionFieldControlInfo

        Dim strA As String
        strA = GridView2.GetFocusedRowCellValue("UserID").ToString
        pfc.ProductionFieldControl_Delete(strA)  '先刪除當前用戶表中記錄

        Dim i As Integer

        For i = 0 To ds.Tables("UserPower").Rows.Count - 1

            If ds.Tables("UserPower").Rows(i)("Check") = True Then

                pfi.UserID = strA
                pfi.ControlDep = ds.Tables("UserPower").Rows(i)("ControlDep")

                pfc.ProductionFieldControl_Add(pfi)
            End If
        Next
        MsgBox("保存" & strA & "生產模塊權限完成!")
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
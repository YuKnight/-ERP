Imports LFERP.Library.Purchase.Acceptance

Public Class frmWareQCStatusMain

    Private Sub popQCStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popQCStatus.Click
        On Error Resume Next
        tempValue2 = GridView1.GetFocusedRowCellValue("A_AcceptanceNO").ToString
        MTypeName = "AcceptanceQCCheck"
        Edit = True

        Dim fr As frmAcceptance
        For Each fr In MDIMain.MdiChildren
            If TypeOf fr Is frmAcceptance Then
                fr.Activate()
                Exit Sub
            End If
        Next
        fr = New frmAcceptance
        fr.MdiParent = MDIMain
        fr.WindowState = FormWindowState.Maximized
        fr.Show()
    End Sub

    Private Sub popRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popRef.Click
        Dim mc As New AcceptanceController

        Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, " ", "已結單", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

    Private Sub frmWareQCStatusMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mc As New AcceptanceController

        Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, " ", "已結單", Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Private Sub popQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles popQuery.Click
        Dim mc As New AcceptanceController
        Dim myfrm As New frmA_AcceptanceSelect2
        myfrm.ShowDialog()
        Select Case tempValue
            Case "1"
                Grid1.DataSource = mc.Acceptance_GetList(Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

            Case "2"
                Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing)
            Case "3"
                Grid1.DataSource = mc.Acceptance_GetList(tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "4"
                Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            Case "5"
                Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing)
            Case "6"
                Grid1.DataSource = mc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, tempValue2, Nothing, Nothing, Nothing, Nothing, Nothing)

        End Select

        tempValue = ""
        tempValue2 = "'"
    End Sub
End Class
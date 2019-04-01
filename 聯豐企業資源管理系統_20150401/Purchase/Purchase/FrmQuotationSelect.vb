Imports LFERP.Library.Purchase.Quotation

Public Class FrmQuotationHistory
    Public SelectQuoID As String
    Public SelectSupplierNo As String
    Public SelectPrice As Single
    Public SelectStandardPack As Integer
    Public SelectMOQ As Integer

    Dim strTopID As String

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        SelectQuoID = ""
        SelectSupplierNo = ""
        SelectPrice = 0
        SelectStandardPack = 0
        SelectMOQ = 0

        Me.Close()

    End Sub

    Private Sub FrmQuotationSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next

        Dim qc As New QuotationController

        'Dim qlist As New List(Of QuotationInfo)

        Label2.Text = tempValue
        Label3.Text = tempValue2
        tempValue = ""
        tempValue2 = ""
        Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 15
        'qlist = qc.Quotation_GetlistTop10(Nothing, Label2.Text, Label3.Text, True, True)

        Grid.DataSource = qc.Quotation_GetlistTop10(Nothing, Label2.Text, Label3.Text, True, True)
        'If qlist Is Nothing Then
        '    Exit Sub
        'Else
        '    Grid.DataSource = qc.Quotation_Getlist(qlist(0).Q_QuoID, qlist(0).M_Code, Nothing, Nothing, Nothing, True, True)

        'End If

        '---------------------------------------------------------
   


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Grid.Rows.Count <> 0 Then

            Dim qlist As New List(Of QuotationInfo)
            Dim qca As New QuotationController
            qlist = qca.Quotation_GetlistTop10(Nothing, Label2.Text, Label3.Text, True, True)
            strTopID = ""
            If qlist.Count > 0 Then
                strTopID = qlist(0).Q_QuoID
            End If

            'SelectQuoID = Grid.CurrentRow.Cells("Q_QuoID").Value.ToString
            'SelectSupplierNo = Grid.CurrentRow.Cells("Q_SupplierNo").Value.ToString
            'SelectPrice = Grid.CurrentRow.Cells("Q_Price").Value
            'SelectStandardPack = Grid.CurrentRow.Cells("Q_StandardPack").Value
            'SelectMOQ = Grid.CurrentRow.Cells("Q_MOQ").Value

            If strTopID = Grid.CurrentRow.Cells("Q_QuoID").Value.ToString Then  '2013-8-5
                SelectQuoID = Grid.CurrentRow.Cells("Q_QuoID").Value.ToString
                SelectSupplierNo = Grid.CurrentRow.Cells("Q_SupplierNo").Value.ToString
                SelectPrice = Grid.CurrentRow.Cells("Q_Price").Value
                SelectStandardPack = Grid.CurrentRow.Cells("Q_StandardPack").Value
                SelectMOQ = Grid.CurrentRow.Cells("Q_MOQ").Value
            Else
                MsgBox("請選擇最新報價記錄!")
                Exit Sub
            End If
        Else

            SelectQuoID = ""
            SelectSupplierNo = ""
            SelectPrice = 0
            SelectStandardPack = 0
            SelectMOQ = 0
            MsgBox("沒有數據....")

        End If
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        'On Error Resume Next

        Dim qc As New QuotationController
        Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 15


        Grid.DataSource = qc.Quotation_GetlistTop10(Nothing, Label2.Text, Label3.Text, True, True)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim qcc As New QuotationController
        Dim ddlist As List(Of QuotationInfo)
        Grid.AutoGenerateColumns = False
        Grid.RowHeadersWidth = 15

        ddlist = qcc.QuotationFW_GetList(Nothing, Label2.Text, Nothing, "True", Nothing, Nothing, Nothing, Nothing, Nothing)
        If ddlist.Count > 0 Then
            Grid.DataSource = qcc.Quotation_GetlistTop10(Nothing, ddlist(0).CodeMain, Label3.Text, True, True)

        End If
    End Sub

End Class
Imports LFERP.Library.Production.ProductionWareShipped

Public Class frmWarePrint

#Region "屬性"
    Dim pws As New ProductionWareShippedControl
    Dim strdate1, strdate2 As String
    Private _EditItem As String
    Public Property EditItem() As String
        Get
            Return _EditItem
        End Get
        Set(ByVal value As String)
            _EditItem = value
        End Set
    End Property
#End Region

    Private Sub frmWarePrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Text = EditItem
        Select Case EditItem
            Case "ProductionRetrocede"
                GroupBox1.Text = "裝配退貨匯總"
            Case "ProductionWareShipped"
                GroupBox1.Text = "裝配倉出貨匯總"
            Case "ProductionWareOutA"
                GroupBox1.Text = "生產倉出貨匯總"
        End Select
        DateEdit1.Text = Format(DateAdd("M", -1, Now()), "yyyy/MM/dd")
        DateEdit2.Text = Format(Now, "yyyy/MM/dd")
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet

        ds.Tables.Clear()

        strdate1 = DateEdit1.Text
        strdate2 = DateEdit2.Text
        Dim StrPost As String
        Dim TableNum As Integer



        Select Case EditItem
            Case "ProductionRetrocede"
                TableNum = 1
                strName = "裝配退貨"
            Case "ProductionWareShipped"
                TableNum = 2
                strName = "裝配出貨"
            Case "ProductionWareOutA"
                TableNum = 3
                strName = "生產出貨"
        End Select

        StrPost = strName + Format(CDate(strdate1), "yyyy/MM/dd") + Format(CDate(strdate2), "yyyy/MM/dd")


        ltc.CollToDataSet(ds, "ProductionTHreeTable", pws.ProductionTHreeTable_GetList(TableNum, strdate1, strdate2))

        PreviewRPT1(ds, "rptProductionThree", "綜合匯總報表", StrPost, InUser, True, True)

            ltc = Nothing
            Me.Close()
    End Sub
End Class
Imports LFERP.Library.Orders
Imports LFERP.Library.Outwards
Imports LFERP.Library.Product

Public Class frmOutWardsColl
    Dim ds As New DataSet

    Sub CreateTablesMain()
        ds.Tables.Clear()
        With ds.Tables.Add("OM_Custer")
            .Columns.Add("OM_CusterID", GetType(String))
        End With
        custeridEdit.Properties.DataSource = ds.Tables("OM_Custer")
        custeridEdit.Properties.DisplayMember = "OM_CusterID"
        custeridEdit.Properties.ValueMember = "OM_CusterID"
        LoadDataMain()


        '更玻珇絪腹
        Dim mc As New ProductController
        GridLookPM_M_Code.Properties.DisplayMember = "PM_M_Code"
        GridLookPM_M_Code.Properties.ValueMember = "PM_M_Code"
        GridLookPM_M_Code.Properties.DataSource = mc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)

    End Sub

    Sub LoadDataMain()
        Dim oc As New OrdersMainController
        Dim ci As New List(Of OrdersMainInfo)

        ci = oc.OrdersMainAndSub_GetCusterID()

        If ci.Count = 0 Then
            Exit Sub
        End If
        Dim i As Integer = 0

        Dim row As DataRow
        row = ds.Tables("OM_Custer").NewRow
        row("OM_CusterID") = "场"
        ds.Tables("OM_Custer").Rows.Add(row)
        '--------------------------------------

        For i = 0 To ci.Count - 1
            row = ds.Tables("OM_Custer").NewRow
            row("OM_CusterID") = ci(i).OM_CusterID
            ds.Tables("OM_Custer").Rows.Add(row)
        Next

    End Sub
    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub frmOutWardsColl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTablesMain()

        dateEdit1.EditValue = Format(Now, "yyyy/MM/" & "01")
        dateEdit2.EditValue = Format(Now, "yyyy/MM/dd")
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Dim ds As New DataSet
        Dim ltc As New CollectionToDataSet
        Dim oc As New OutWardsController
        Dim custerid, Date1, Date2, strCheck, strPM_M_Code As String
        Dim PrintDate As String = ""

        custerid = Nothing
        Date1 = Nothing
        Date2 = Nothing
        strCheck = Nothing
        strPM_M_Code = Nothing
        '------------------------------------------------------------------
        If custeridEdit.EditValue = "场" Then
            custerid = Nothing
        Else
            custerid = IIf(custeridEdit.Text = "", Nothing, custeridEdit.EditValue)
        End If

        If GridLookPM_M_Code.EditValue = "" Then
            strPM_M_Code = Nothing
        Else
            strPM_M_Code = GridLookPM_M_Code.EditValue
        End If
        '------------------------------------------------------------------

        Date1 = IIf(dateEdit1.Text = "", Nothing, dateEdit1.Text)
        Date2 = IIf(dateEdit2.Text = "", Nothing, dateEdit2.Text)

        If Date1 <> "" And Date2 <> "" Then
            PrintDate = "癳砯ら戳:" & Date1 & "" & Date2
        End If

        If ComboBoxCheck.Text = "场" Then
            strCheck = Nothing
        ElseIf ComboBoxCheck.Text = "ゼ糵" Then
            strCheck = "False"
        ElseIf ComboBoxCheck.Text = "糵" Then
            strCheck = "True"
        End If

        ' MsgBox(custerid & Date1 & Date2 & strCheck & strPM_M_Code)
  
        If oc.OutWards_GetList(Nothing, Nothing, custerid, Nothing, Nothing, Nothing, Nothing, strPM_M_Code, Nothing, strCheck, Date1, Date2).Count > 0 Then
        Else
            MsgBox("⊿Τ才璶―计沮", 64, "矗ボ")
            Exit Sub
        End If

        ltc.CollToDataSet(ds, "OutWards", oc.OutWards_GetList(Nothing, Nothing, custerid, Nothing, Nothing, Nothing, Nothing, strPM_M_Code, Nothing, strCheck, Date1, Date2))
        PreviewRPTDialog1(ds, "rptOutWardsColl", "縤场---癳砯", PrintDate, "", True, True)
        ltc = Nothing
    End Sub
End Class
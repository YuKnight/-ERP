Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionPiecePersonnelDay
Imports LFERP.Library.ProductionPieceWorkGroup

Public Class ProductionPiecePersonnelDaylLoad
    Dim Model As String
    Dim ds As New DataSet

    Private Sub ProductionPiecePersonnelLoad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LabDepID.Text = tempValue3
        LabFac.Text = tempValue4
        tempValue3 = Nothing
        tempValue4 = Nothing

        'Dim pi As New LFERP.Library.ProductionPieceWorkGroup.ProductionPieceWorkGroupControl
        'GluG_NOD.Properties.DataSource = pi.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, LabDepID.Text, LabFac.Text, Nothing, Nothing, Nothing)
        'GluG_NOD.Properties.DisplayMember = "G_Name"
        'GluG_NOD.Properties.ValueMember = "G_NO"

        'GluG_NOB.Properties.DataSource = pi.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, LabDepID.Text, LabFac.Text, Nothing, Nothing, Nothing)
        'GluG_NOB.Properties.DisplayMember = "G_Name"
        'GluG_NOB.Properties.ValueMember = "G_NO"

        CreateTables()

        Dim pc As New ProductionPieceWorkGroupControl
        Dim pcL As List(Of ProductionPieceWorkGroupInfo)

        ds.Tables("G_NOName").Clear()

        Dim row1 As DataRow
        row1 = ds.Tables("G_NOName").NewRow
        row1("G_NO") = "無"
        row1("G_Name") = "無"
        ds.Tables("G_NOName").Rows.Add(row1)
        pcL = pc.ProductionPieceWorkGroup_GetList(Nothing, Nothing, Nothing, LabDepID.Text, LabFac.Text, Nothing, Nothing, Nothing)
        If pcL.Count = 0 Then
        Else
            Dim i As Integer
            For i = 0 To pcL.Count - 1
                Dim row As DataRow
                row = ds.Tables("G_NOName").NewRow
                row("G_NO") = pcL(i).G_NO
                row("G_Name") = pcL(i).G_Name
                ds.Tables("G_NOName").Rows.Add(row)
            Next
        End If

        Per_DateEdit.Text = DateAdd(DateInterval.Day, -1, CDate(Format(Now, "yyyy/MM/dd")))  ''得到前一開日期


    End Sub

    ''' <summary>
    ''' 載入數據表結構
    ''' </summary>
    ''' <remarks></remarks>
    Sub CreateTables()
        ds.Tables.Clear()

        With ds.Tables.Add("ProductionPiecePersonnelLoad")
            .Columns.Add("GoIn", GetType(Boolean))
            .Columns.Add("AutoID", GetType(String))
            .Columns.Add("Per_NO", GetType(String))
            .Columns.Add("Per_Name", GetType(String))
            .Columns.Add("Per_DepName", GetType(String))

            .Columns.Add("G_NO", GetType(String))
            .Columns.Add("Per_G_Name", GetType(String))
            .Columns.Add("Per_Date", GetType(String))
            .Columns.Add("Per_ActionName", GetType(String))
        End With

        Grid1.DataSource = ds.Tables("ProductionPiecePersonnelLoad")

        '' ''增加無組別員工，進行個人計件的2012-5-8
        With ds.Tables.Add("G_NOName")
            .Columns.Add("G_NO")
            .Columns.Add("G_Name")
        End With

        GluG_NOD.Properties.DisplayMember = "G_Name"
        GluG_NOD.Properties.ValueMember = "G_NO"
        GluG_NOD.Properties.DataSource = ds.Tables("G_NOName")

        GluG_NOB.Properties.DisplayMember = "G_Name"
        GluG_NOB.Properties.ValueMember = "G_NO"
        GluG_NOB.Properties.DataSource = ds.Tables("G_NOName")


    End Sub
    ''' <summary>
    ''' 載入要求導入的數據 B,從基本表中導入 ,D從日常表中指定日期導入
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LoadData_D() As Boolean
        LoadData_D = False
        Dim i As Integer


        ''若載入的日期與被載入日期相同不允許載入----------------------------------------
        Dim Cha As TimeSpan
        Dim Cha_d As Double

        Dim strDate1 As DateTime
        Dim strDate2 As DateTime


        strDate1 = DateTime.Parse(Per_DateEdit.EditValue)
        strDate2 = DateTime.Parse(Format(Now, "yyyy/MM/dd"))

        Cha = strDate2 - strDate1
        Cha_d = Format(Cha.Days, "0")

        If Val(Cha_d) <= 0 Then
            MsgBox("建立日期輸入有誤,不能為當天")
            Per_DateEdit.Select()
            Exit Function
        End If
        ''-----------------------------------------------------------------------------

        Dim objInfo As New ProductionPiecePersonnelDayInfo
        Dim objList As New List(Of ProductionPiecePersonnelDayInfo)
        Dim oc As New ProductionPiecePersonnelDayControl
        objList = oc.ProductionPiecePersonnelDay_GetList(Nothing, Nothing, Nothing, Nothing, GluG_NOD.EditValue, LabDepID.Text, LabFac.Text, Nothing, Per_DateEdit.Text, Nothing, False, Per_DateEdit.Text, Nothing)


        ds.Tables("ProductionPiecePersonnelLoad").Clear()

        If objList.Count <= 0 Then
            MsgBox("沒有數據！")
            LoadData_D = False
            Exit Function
        Else
            For i = 0 To objList.Count - 1
                Dim row1 As DataRow = ds.Tables("ProductionPiecePersonnelLoad").NewRow

                row1("GOIn") = False

                row1("AutoID") = objList(i).AutoID

                row1("Per_NO") = objList(i).Per_NO
                row1("Per_Name") = objList(i).Per_Name

                row1("Per_G_Name") = objList(i).Per_G_Name
                row1("G_NO") = objList(i).G_NO
                row1("Per_DepName") = objList(i).Per_DepName

                row1("Per_ActionName") = objList(i).Per_ActionName
                row1("Per_Date") = objList(i).Per_Date

                ds.Tables("ProductionPiecePersonnelLoad").Rows.Add(row1)

                LoadData_D = True
            Next
        End If

    End Function
    ''' <summary>
    ''' 基本表
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function LoadData_B() As Boolean
        LoadData_B = False
        Dim i As Integer


        Dim objInfo As New ProductionPiecePersonnelDayInfo
        Dim objList As New List(Of ProductionPiecePersonnelInfo)
        Dim oc As New ProductionPiecePersonnelControl



        objList = oc.ProductionPiecePersonnel_GetList(Nothing, Nothing, Nothing, GluG_NOB.EditValue, LabDepID.Text, LabFac.Text, Nothing, Nothing, Nothing, False, Nothing, Nothing)

        ds.Tables("ProductionPiecePersonnelLoad").Clear()

        If objList.Count <= 0 Then
            MsgBox("沒有數據！")
            LoadData_B = False
            Exit Function
        Else
            For i = 0 To objList.Count - 1
                Dim row1 As DataRow = ds.Tables("ProductionPiecePersonnelLoad").NewRow

                row1("GOIn") = False

                row1("AutoID") = objList(i).AutoID
                row1("Per_NO") = objList(i).Per_NO
                row1("Per_Name") = objList(i).Per_Name

                row1("Per_G_Name") = objList(i).Per_G_Name
                row1("G_NO") = objList(i).G_NO
                row1("Per_DepName") = objList(i).Per_DepName

                row1("Per_ActionName") = objList(i).Per_ActionName
                row1("Per_Date") = objList(i).Per_Date

                ds.Tables("ProductionPiecePersonnelLoad").Rows.Add(row1)

                LoadData_B = True
            Next
        End If

    End Function

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim i, n As Integer  ''tempValue

        For i = 0 To ds.Tables("ProductionPiecePersonnelLoad").Rows.Count - 1
            If ds.Tables("ProductionPiecePersonnelLoad").Rows(i)("GoIn") = True Then
                If n = 0 Then
                    tempValue2 = ds.Tables("ProductionPiecePersonnelLoad").Rows(i)("AutoID")
                    n = n + 1
                Else
                    tempValue2 = tempValue2 & "," & ds.Tables("ProductionPiecePersonnelLoad").Rows(i)("AutoID")
                    n = n + 1
                End If
            End If
        Next

        If n <= 0 Then
            MsgBox("請選擇要載入的數據")
            Exit Sub
        End If

        tempValue = Model

        Me.Close()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdLoadD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadD.Click
        ''指定日期導入
        If LoadData_D() = True Then
            Model = "D"
        End If
    End Sub

    Private Sub cmdLoadB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadB.Click
        '基本數據表中導入
        If LoadData_B() = True Then
            Model = "B"
        End If
    End Sub

    Private Sub cmdSelALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelALL.Click
        Dim i As Integer

        If ds.Tables("ProductionPiecePersonnelLoad").Rows.Count > 0 Then
        Else
            Exit Sub
        End If

        For i = 0 To ds.Tables("ProductionPiecePersonnelLoad").Rows.Count - 1
            ds.Tables("ProductionPiecePersonnelLoad").Rows(i)("GoIn") = True
        Next

    End Sub

    Private Sub cmdQselectALL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQselectALL.Click
        Dim i As Integer

        If ds.Tables("ProductionPiecePersonnelLoad").Rows.Count > 0 Then
        Else
            Exit Sub
        End If

        For i = 0 To ds.Tables("ProductionPiecePersonnelLoad").Rows.Count - 1
            ds.Tables("ProductionPiecePersonnelLoad").Rows(i)("GoIn") = False
        Next
    End Sub


End Class
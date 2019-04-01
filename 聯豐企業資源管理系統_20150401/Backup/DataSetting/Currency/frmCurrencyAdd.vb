Imports LFERP.DataSetting

Public Class frmCurrencyAdd
    Dim cc As New CurrencyControler
    Dim ds As New DataSet

    Private Sub frmCurrencyAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'PM_M_Code.Properties.DataSource = cc.GetCurrencyList(Nothing)
        'PM_M_Code.Properties.DisplayMember = "C_Name"
        'PM_M_Code.Properties.ValueMember = "C_ID"

        Label3.Text = tempValue2   'ID
        Label6.Text = tempValue   '類型
        tempValue2 = ""
        tempValue = ""

        CreateTables()

        Select Case Label6.Text

            Case "YearAdd"
                SpinEdit1.Visible = False
                SpinEdit2.Text = Format(Now, "yyyy")

                LoadCurrency()
                Me.Text = "匯率[按年新增]"


            Case "MonthAdd"
                LoadCurrency()
                Me.Text = "匯率[按月新增]"
                SpinEdit2.Text = Format(Now, "yyyy")
                SpinEdit1.Text = Format(Now, "MM")

            Case "Edit"
                SpinEdit1.Enabled = False
                SpinEdit2.Enabled = False
                LoadData(Label3.Text)
                Me.Text = "匯率[修改]"
        End Select
    End Sub
    ''' <summary>
    ''' 載入數據
    ''' </summary>
    ''' <param name="strID"></param>
    ''' <remarks></remarks>
    Sub LoadData(ByVal strID As String)

        Dim ci As List(Of CurrencyInfo)
        ci = cc.ExChangeRate_GetList(strID, Nothing, Nothing, Nothing)
        If ci.Count = 0 Then
            Exit Sub
        End If
        If Mid(ci(0).StrYM, 5, 1) = "0" Then
            SpinEdit1.Text = Mid(ci(0).StrYM, 6, 1)
        Else
            SpinEdit1.Text = Mid(ci(0).StrYM, 5, 2)
        End If

        SpinEdit2.Text = Mid(ci(0).StrYM, 1, 4)

        Dim i As Integer
        For i = 0 To ci.Count - 1
            Dim row As DataRow
            row = ds.Tables("Rate").NewRow
            row("C_ID") = ci(i).C_ID
            row("C_Name") = ci(i).C_Name
            row("Ex_Rate") = ci(i).Ex_Rate
            row("AutoID") = ci(i).AutoID
            ds.Tables("Rate").Rows.Add(row)
        Next


    End Sub
    ''新增時載入以幣別表加的記錄

    Sub LoadCurrency()
        Dim cl As New List(Of CurrencyInfo)
        cl = cc.GetCurrencyList(Nothing)
        If cl.Count <= 0 Then
            Exit Sub
        End If

        Dim i As Integer
        For i = 0 To cl.Count - 1
            Dim row As DataRow
            row = ds.Tables("Rate").NewRow
            row("C_ID") = cl(i).C_ID
            row("C_Name") = cl(i).C_Name
            row("Ex_Rate") = 0
            ds.Tables("Rate").Rows.Add(row)
        Next

    End Sub

    Sub CreateTables()
        ds.Tables.Clear()
        With ds.Tables.Add("Rate")
            .Columns.Add("StrYM", GetType(String))
            .Columns.Add("C_ID", GetType(String))
            .Columns.Add("C_Name", GetType(String))
            .Columns.Add("Ex_Rate", GetType(Double))
            .Columns.Add("AutoID", GetType(String))
        End With

        Grid1.DataSource = ds.Tables("Rate")

    End Sub


    Function CheckDate() As Boolean

        CheckDate = True

        If ds.Tables("Rate").Rows.Count <= 0 Then
            CheckDate = False
            MsgBox("無數據保存！")
            Exit Function
        End If

        Dim i As Integer

        For i = 0 To ds.Tables("Rate").Rows.Count - 1
            If ds.Tables("Rate").Rows(i)("Ex_Rate") = 0 Then
                CheckDate = False
                MsgBox("匯率不能為0！")
                Exit Function
            End If
        Next

        ''---------------------------------------------------------------
        Dim strA As String = ""

        If Label6.Text = "Edit" Then
            Exit Function
        End If

        If Label6.Text = "YearAdd" Then
            strA = SpinEdit2.Text
        End If

        If Label6.Text = "MonthAdd" Then
            strA = SpinEdit2.Text & Format(Val(SpinEdit1.Text), "00")
        End If

        Dim cci As New List(Of CurrencyInfo)
        cci = cc.ExChangeRate_GetList(Nothing, strA, Nothing, Nothing)

        If cci.Count > 0 Then
            If MsgBox("當前保存記錄中,部分記錄已存在,是否繼續？", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Else
                CheckDate = False
                Exit Function
            End If
        End If

    End Function



    Sub DataYearNew()

        Dim ci As New CurrencyInfo
        Dim cci As List(Of CurrencyInfo)

        Dim i, j As Integer

        For i = 1 To 12

            For j = 0 To ds.Tables("Rate").Rows.Count - 1

                Dim strA As String


                strA = Trim(SpinEdit2.Text & Format(i, "00")) 'C_ID


                cci = cc.ExChangeRate_GetList(Nothing, strA, ds.Tables("Rate").Rows(j)("C_ID"), Nothing)

                If cci.Count > 0 Then
                    cc.ExChangeRate_Delete(cci(0).AutoID)
                End If

                ci.C_ID = ds.Tables("Rate").Rows(j)("C_ID")
                ci.C_Name = ds.Tables("Rate").Rows(j)("C_Name")
                ci.StrYM = strA
                ci.Ex_Rate = ds.Tables("Rate").Rows(j)("Ex_Rate")

                If cc.ExChangeRate_Add(ci) = False Then
                    MsgBox("部分保存失敗！")
                    Exit Sub
                End If
            Next

        Next

        MsgBox("添加整年的匯率成功！", 60, "提示")


        Me.Close()
    End Sub


    Sub DataMonthNew()

        Dim ci As New CurrencyInfo
        Dim cci As List(Of CurrencyInfo)


        Dim strA As String

        If Len(SpinEdit1.Text) = 1 Then
            strA = SpinEdit2.Text & "0" & SpinEdit1.Text
        Else
            strA = SpinEdit2.Text & SpinEdit1.Text
        End If

        Dim j As Integer

        For j = 0 To ds.Tables("Rate").Rows.Count - 1



            ci.C_ID = ds.Tables("Rate").Rows(j)("C_ID")
            ci.C_Name = ds.Tables("Rate").Rows(j)("C_Name")
            ci.StrYM = strA
            ci.Ex_Rate = ds.Tables("Rate").Rows(j)("Ex_Rate")

            cci = cc.ExChangeRate_GetList(Nothing, strA, ds.Tables("Rate").Rows(j)("C_ID"), Nothing)

            If cci.Count > 0 Then
                ci.AutoID = cci(0).AutoID
                If cc.ExChangeRate_Update(ci) = False Then
                    MsgBox(ds.Tables("Rate").Rows(j)("C_Name") & "，請檢查原因！", 60, "提示")
                End If
            Else
                If cc.ExChangeRate_Add(ci) = False Then
                    MsgBox(ds.Tables("Rate").Rows(j)("C_Name") & "，請檢查原因！", 60, "提示")
                End If
            End If
        Next

        MsgBox("添加整月的匯率成功！", 60, "提示")

        Me.Close()
    End Sub



    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click


        Select Case Label6.Text

            Case "YearAdd"
                If CheckDate() = False Then
                    Exit Sub
                End If

                DataYearNew()

            Case "MonthAdd"
                If CheckDate() = False Then
                    Exit Sub
                End If

                DataMonthNew()

            Case "Edit"
                If CheckDate() = False Then
                    Exit Sub
                End If

                DataEdit()
        End Select
    End Sub

    ''' <summary>
    ''' 修改
    ''' </summary>
    ''' <remarks></remarks>
    Sub DataEdit()

        Dim ci As New CurrencyInfo


        Dim strA As String

        If Len(SpinEdit1.Text) = 1 Then
            strA = SpinEdit2.Text & "0" & SpinEdit1.Text
        Else
            strA = SpinEdit2.Text & SpinEdit1.Text
        End If

        ci.C_ID = ds.Tables("Rate").Rows(0)("C_ID")
        ci.C_Name = ds.Tables("Rate").Rows(0)("C_Name")

        ci.StrYM = strA

        ci.Ex_Rate = ds.Tables("Rate").Rows(0)("Ex_Rate")

        If cc.ExChangeRate_Update(ci) = True Then
            MsgBox("修改當月貨幣匯率信息成功！", 60, "提示")
        Else
            MsgBox("修改失敗，請檢查原因!", 60, "提示")
        End If
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
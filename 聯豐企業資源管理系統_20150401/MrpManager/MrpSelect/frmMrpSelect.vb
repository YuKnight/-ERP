Public Class frmMrpSelect


#Region "字段屬性"
    Private dtCondition As DataTable = Nothing  '篩選條件表  
    Private _FormText As String
    Private _TableName As String  '表名
    Private _ID As String  '表中的流水號ID

    Property FormText() As String
        Get
            Return _FormText
        End Get
        Set(ByVal value As String)
            _FormText = value
        End Set
    End Property

    Property TableName() As String
        Get
            Return _TableName
        End Get
        Set(ByVal value As String)
            _TableName = value
        End Set
    End Property

    Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property
#End Region

#Region "創建臨時表"
    Private Sub CreateTable()
        dtCondition = New DataTable
        dtCondition.Columns.Add("ConditionValue", GetType(String))
        dtCondition.Columns.Add("ConditionText", GetType(String))
        GridCondition.DataSource = dtCondition
    End Sub

#End Region
    Private Sub frmMrpSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateTable()
        Me.Text = _FormText + "--查詢"
        lblTitle.Text = _FormText + "--查詢"
        LoadDataToGrid()
    End Sub

#Region "為Grid加載數據源"
    Private Sub LoadDataToGrid()
        Dim dt As New DataTable
        Dim sqlStr As String = "select TableName=OBJECT_NAME(C.object_id),ColID=C.column_id,ColName=C.name,FieldType=T.name,Descr=("
        sqlStr += "case charindex(',',CONVERT(nvarchar,E.value)) when '0' then E.value else left(CONVERT(nvarchar,E.value),"
        sqlStr += "charindex(',',CONVERT(nvarchar,E.value))-1) end) from sys.columns as C "
        sqlStr += "inner join sys.extended_properties As E on E.major_id=C.object_id and C.column_id=E.minor_id "
        sqlStr += "inner join sys.types as T on C.user_type_id=T.user_type_id where C.object_id=OBJECT_ID('" + _TableName + "')"
        dt = ExecuteDataSet(sqlStr).Tables(0)

        GridColumn.DataSource = dt
        ViewColumn.ActiveFilterString = "Descr <> ''"
        'ViewColumn.RowFilter = 

        For Each row As DataRow In dt.Rows
            If row("ColName").ToString.ToLower = _ID.ToLower Then
                lbltip.Text = "請選擇" + row("Descr").ToString + ":"
                ViewID.Columns(0).FieldName = _ID
                ViewID.Columns(0).Caption = row("Descr").ToString
                gluID.Properties.DisplayMember = _ID
                gluID.Properties.ValueMember = _ID
                gluID.Location = New System.Drawing.Point(lbltip.Location.X + lbltip.Size.Width, lbltip.Location.Y - 2)
                gluID.Properties.DataSource = ExecuteDataSet("select " + _ID + " from " + _TableName).Tables(0)
            End If
        Next

    End Sub
#End Region

#Region "根據字段類型選擇相應的XtraTabPage"
    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles ViewColumn.FocusedRowChanged
        Select Case ViewColumn.GetFocusedRowCellValue("FieldType").ToString
            Case "nvarchar"
                SetXtraTabEnable(xtpText)
            Case "varchar"
                SetXtraTabEnable(xtpText)
            Case "ntext"
                SetXtraTabEnable(xtpText)

            Case "int"
                SetXtraTabEnable(xtpNumber)
            Case "numeric"
                SetXtraTabEnable(xtpNumber)
            Case "tinyint"
                SetXtraTabEnable(xtpNumber)
            Case "decimal"
                SetXtraTabEnable(xtpNumber)
            Case "float"
                SetXtraTabEnable(xtpNumber)
            Case "real"
                SetXtraTabEnable(xtpNumber)

            Case "smalldatetime"
                SetXtraTabEnable(xtpDate)
            Case "datetime"
                SetXtraTabEnable(xtpDate)
            Case "date"
                SetXtraTabEnable(xtpDate)

            Case "bit"
                SetXtraTabEnable(xtpBoolean)

            Case Else
                MsgBox("此字段類型沒有定義，請聯系管理員", MsgBoxStyle.Information, "提示")
        End Select
    End Sub

    Private Sub SetXtraTabEnable(ByVal xtpPage As DevExpress.XtraTab.XtraTabPage)
        For Each xtp As DevExpress.XtraTab.XtraTabPage In XtraTab.TabPages
            If xtp Is xtpPage Then
                xtp.PageEnabled = True
                XtraTab.SelectedTabPage = xtp
            Else
                xtp.PageEnabled = False
            End If
        Next
    End Sub
#End Region

    Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnText.Click, btnDate.Click, btnNumber.Click, btnBoolean.Click
        Dim enSymbol, chSymbol, value As String
        Select Case sender.name
            Case "btnText"
                AddCondition(" like ", "類似", "%" + txtText.Text + "%")

            Case "btnDate"
                enSymbol = cboDate.EditValue.ToString.Remove(1)
                chSymbol = cboDate.EditValue.ToString.Substring(2, 2)
                value = IIf(dteDate.EditValue = Nothing, String.Empty, Format(dteDate.EditValue, "yyyy/MM/dd"))
                AddCondition(enSymbol, chSymbol, value)

            Case "btnNumber"
                enSymbol = cboNumber.EditValue.ToString.Remove(1)
                chSymbol = cboNumber.EditValue.ToString.Substring(2, 2)
                value = IIf(clcNumber.EditValue = Nothing, String.Empty, clcNumber.EditValue)
                AddCondition(enSymbol, chSymbol, value)

            Case "btnBoolean"
                AddCondition("=", "等于", cboBoolean.EditValue.ToString)

        End Select
    End Sub

    Private Sub AddCondition(ByVal enSymbol As String, ByVal chSymbol As String, ByVal value As String)
        Dim row As DataRow = dtCondition.NewRow
        Dim strCondition As String = cboCondition.EditValue.ToString
        row("ConditionValue") = strCondition.Remove(5) + ViewColumn.GetFocusedRowCellValue("ColName").ToString
        row("ConditionText") = strCondition.Substring(strCondition.Length - 3, 2) + " " + ViewColumn.GetFocusedRowCellValue("Descr").ToString + " "
        If String.IsNullOrEmpty(value.Replace("%", "")) Then
            MsgBox("請輸入要查詢的條件！")
            Exit Sub
        End If
        If XtraTab.SelectedTabPage Is xtpBoolean Then
            If cboBoolean.SelectedIndex = 0 Then
                row("ConditionValue") += enSymbol + "'True'"
            Else
                row("ConditionValue") += enSymbol + "'False'"
            End If
        ElseIf XtraTab.SelectedTabPage Is xtpDate Then
            row("ConditionValue") = strCondition.Remove(5) + " DATEDIFF(day,'" + value + "'," + ViewColumn.GetFocusedRowCellValue("ColName").ToString + ")" + enSymbol + "0"
        Else
            row("ConditionValue") += enSymbol + "'" + value + "'"
        End If

        row("ConditionText") += chSymbol + " '" + value.Replace("%", "").Trim + "'"
        dtCondition.Rows.Add(row)
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            If dtCondition.Rows.Count < 1 Then Exit Sub
            dtCondition.Rows.RemoveAt(viewCondition.FocusedRowHandle)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "提示")
        End Try

    End Sub

    Private Sub cmdSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSubmit.Click
        Try
            Dim sqlStr As String = String.Empty
            If XtraTabControl1.SelectedTabPage Is XtraTabPage1 Then
                If gluID.EditValue = Nothing Then
                    MsgBox(lbltip.Text.Substring(0, lbltip.Text.Length - 1), MsgBoxStyle.Information, "提示")
                    Exit Sub
                Else
                    tempValue = " and [" + _ID + "]='" + gluID.EditValue.ToString + "'"
                    Me.Close()
                End If
            Else
                If dtCondition.Rows.Count < 1 Then
                    MsgBox("篩選條件不能空", MsgBoxStyle.Information, "提示")
                    Exit Sub
                Else
                    Dim str As String = String.Empty
                    For Each row As DataRow In dtCondition.Rows
                        str += row("ConditionValue")
                    Next
                    tempValue = str
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "提示")
        End Try
    End Sub

    Private Sub cmdCancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancle.Click
        tempValue = String.Empty
        Me.Close()
    End Sub

    Public Function ExecuteDataSet(ByVal sqlStr As String) As DataSet
        Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        Dim dbComm As Data.Common.DbCommand = db.GetSqlStringCommand(sqlStr)
        Return db.ExecuteDataSet(dbComm)
    End Function

End Class
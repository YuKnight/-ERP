Imports LFERP.Library
Imports LFERP.Library.Purchase.Quotation
Imports LFERP.Library.Material

Public Class frmQuotationFW

    Dim ds As New DataSet
    Dim codeNum As Integer

    Dim qt As New Purchase.Quotation.QuotationController
    Dim qi As New Purchase.Quotation.QuotationInfo
    Private Sub frmQuotationFW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CreateTable()
        Label6.Text = tempValue2
        txtQuoID.Enabled = False
        Select Case tempValue2
            Case "範圍報價"
                cmdAdd.Enabled = True
                cmdDel.Enabled = True
                If Edit = False Then
                    Me.Text = "範圍報價新增"
                Else
                    Me.Text = "範圍報價修改"
                    Me.txtMcode.Enabled = False
                    Me.txtGauge.Enabled = False
                    Me.txtName.Enabled = False
                    Me.txtUnit.Enabled = False
                    GridView2.OptionsBehavior.Editable = False
                    txtQuoID.Text = tempValue3
                    LoadData(tempValue3)
                End If
            Case "範圍報價審核"
                Me.Text = "範圍報價審核"
                Me.txtMcode.Enabled = False
                Me.txtGauge.Enabled = False
                Me.txtName.Enabled = False
                Me.txtUnit.Enabled = False
                cmdAdd.Enabled = False
                cmdDel.Enabled = False
                txtQuoID.Text = tempValue3
                LoadData(tempValue3)
        End Select
        tempValue2 = ""
        tempValue3 = ""

    End Sub
    Function LoadData(ByVal QuotationID As String) As Boolean
        LoadData = True
        Dim objInfo As List(Of QuotationInfo)
        Dim qfc As New QuotationController
        Dim i As Integer
        Dim row As DataRow
        ds.Tables("QuotationFW").Rows.Clear()
        Try
            objInfo = qfc.QuotationFW_GetList(Nothing, Nothing, QuotationID, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
            If objInfo Is Nothing Then
                '沒有數據
                LoadData = False
                Exit Function
            End If
            txtMcode.Text = objInfo(0).CodeMain
            txtName.Text = objInfo(0).CodeMain_Name
            Me.txtUnit.Text = objInfo(0).CodeMain_Unit
            Me.txtGauge.Text = objInfo(0).CodeMain_Gauge

            For i = 0 To objInfo.Count - 1
                'txtMcode.EditValue = objInfo(i).CodeMain

                row = ds.Tables("QuotationFW").NewRow

                row("TagID") = objInfo(i).TagID
                row("CodeSub") = objInfo(i).CodeSub
                row("CodeSub_Gauge") = objInfo(i).CodeSub_Gauge
                row("CodeSub_Name") = objInfo(i).CodeSub_Name
                row("CodeSub_Unit") = objInfo(i).CodeSub_Unit
                row("UserID") = objInfo(i).UserID
                row("Code_UserName") = objInfo(i).Code_UserName
                row("Checked") = objInfo(i).Checked

                ds.Tables("QuotationFW").Rows.Add(row)
            Next

        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try

    End Function

    Public Sub CreateTable()
        ds.Tables.Clear()

        With ds.Tables.Add("QuotationFW")
            .Columns.Add("TagID", GetType(String))
            .Columns.Add("CodeMain", GetType(String))
            .Columns.Add("CodeSub", GetType(String))
            .Columns.Add("CodeSub_Name", GetType(String))
            .Columns.Add("CodeSub_Unit", GetType(String))
            .Columns.Add("CodeSub_Gauge", GetType(String))
            .Columns.Add("UserID", GetType(String))
            .Columns.Add("Code_UserName", GetType(String))
            .Columns.Add("Checked", GetType(Boolean))
        End With
        '創建刪除數據表
        With ds.Tables.Add("DelData")
            .Columns.Add("CodeMain", GetType(String))
            .Columns.Add("CodeSub", GetType(String))
            .Columns.Add("TagID", GetType(String))
        End With
        GridControl1.DataSource = ds.Tables("QuotationFW")
    End Sub
    Sub AddRow(ByVal strCode As String)
        Dim row As DataRow
        row = ds.Tables("QuotationFW").NewRow
        If strCode = "" Then
        Else
            Dim i As Integer

            For i = 0 To ds.Tables("QuotationFW").Rows.Count - 1
                If strCode = ds.Tables("QuotationFW").Rows(i)("CodeSub") Then
                    MsgBox("不允許有重復物料編碼....")
                    Exit Sub
                End If
            Next
            Dim mc As New LFERP.Library.Material.MaterialController
            Dim objInfo As New LFERP.Library.Material.MaterialInfo
            objInfo = mc.MaterialCode_Get(strCode)

            row("CodeMain") = ""
            row("CodeSub") = objInfo.M_Code
            row("CodeSub_Name") = objInfo.M_Name
            row("CodeSub_Unit") = objInfo.M_Unit
            row("CodeSub_Gauge") = objInfo.M_Gauge



            ds.Tables("QuotationFW").Rows.Add(row)
        End If
        GridView2.MoveLast()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        tempCode = ""
        frmBOMSelect.ShowDialog()
        '增加記錄
        If tempCode = "" Then
            Exit Sub
        Else
            AddRow(tempCode)

        End If
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
      
        If ds.Tables("QuotationFW").Rows.Count = 0 Then Exit Sub

        If GridView2.GetFocusedRowCellValue("Checked") = True Then
            MsgBox("此項已審核，不允許刪除！")
            Exit Sub
        End If
        Dim DelTemp As String
        DelTemp = GridView2.GetRowCellDisplayText(ArrayToString(GridView2.GetSelectedRows()), "CodeSub")

        If DelTemp = "CodeSub" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelData").NewRow

            row("CodeMain") = ds.Tables("QuotationFW").Rows(GridView2.FocusedRowHandle)("CodeMain")
            row("TagID") = ds.Tables("QuotationFW").Rows(GridView2.FocusedRowHandle)("TagID")
            row("CodeSub") = DelTemp
            ds.Tables("DelData").Rows.Add(row)
        End If
        ds.Tables("QuotationFW").Rows.RemoveAt(CInt(ArrayToString(GridView2.GetSelectedRows())))
    End Sub
    Private Sub DataNew()

        Dim qfi As New QuotationInfo
        Dim qfc As New QuotationController

        If txtMcode.EditValue = "" Then
            MsgBox("主物料編碼不能為空!")
            Exit Sub
        End If


        txtQuoID.Text = GetQuotationID()

        Dim i As Integer
        For i = 0 To ds.Tables("QuotationFW").Rows.Count - 1

            qfi.CodeMain = txtMcode.EditValue
            qfi.QuotationID = txtQuoID.Text
            qfi.TagID = GetFWID()
            qfi.Checked = False
            qfi.CodeSub = ds.Tables("QuotationFW").Rows(i)("CodeSub")
            qfi.UserID = InUserID
            If qfc.QuotationFW_Add(qfi) = False Then
                MsgBox("添加失敗!", , "提示")
            End If
        Next

        Me.Close()
    End Sub
    Private Sub DataChecked()
        Dim qfi As New QuotationInfo
        Dim qfc As New QuotationController

        For i As Integer = 0 To ds.Tables("QuotationFW").Rows.Count - 1

            qfi.QuotationID = txtQuoID.Text
            qfi.TagID = ds.Tables("QuotationFW").Rows(i)("TagID")
            qfi.Checked = ds.Tables("QuotationFW").Rows(i)("Checked")

            If qfc.QuotationFW_Checked(qfi) = False Then
                MsgBox("審核失敗!", , "提示")
            End If
        Next

        Me.Close()
    End Sub
    Private Sub DataEdit()

        Dim qfi As New QuotationInfo
        Dim qfc As New QuotationController
        If txtMcode.EditValue = "" Then
            MsgBox("主物料編碼不能為空!")
            Exit Sub
        End If

        If ds.Tables("DelData").Rows.Count > 0 Then
            Dim j As Integer
            For j = 0 To ds.Tables("DelData").Rows.Count - 1

                If Not IsDBNull(ds.Tables("DelData").Rows(j)("TagID")) Then

                    qfc.QuotationFW_SubDelete(Nothing, ds.Tables("DelData").Rows(j)("TagID"))

                End If
            Next j
        End If
        qfi.CodeMain = txtMcode.EditValue
        qfi.QuotationID = txtQuoID.Text
        Dim i As Integer

        For i = 0 To ds.Tables("QuotationFW").Rows.Count - 1

            If IsDBNull(ds.Tables("QuotationFW").Rows(i)("TagID")) Then    '新增物料詳細信息

                qfi.TagID = GetFWID()

                'ds.Tables("QuotationFW").Rows(i)("CodeMain") = txtMcode.EditValue
                qfi.CodeSub = ds.Tables("QuotationFW").Rows(i)("CodeSub")
                qfi.UserID = InUserID
                If qfc.QuotationFW_Add(qfi) = False Then
                    MsgBox("修改失敗!")
                End If
            Else
                qfi.TagID = ds.Tables("QuotationFW").Rows(i)("TagID")
                qfi.CodeSub = ds.Tables("QuotationFW").Rows(i)("CodeSub")
                qfi.UserID = InUserID
                If qfc.QuotationFW_Update(qfi) = False Then
                    MsgBox("修改失敗!")
                End If
                'ds.Tables("QuotationFW").Rows(i)("TagID") = qfi.TagID
            End If
        Next
        Me.Close()

    End Sub
    Function GetFWID() As String
        Dim qfi As New QuotationInfo
        Dim qfc As New QuotationController

        qfi = qfc.QuotationFW_GetNum(txtQuoID.Text)
        If qfi Is Nothing Then
            GetFWID = txtQuoID.Text & "-" & "01"
        Else
            GetFWID = qfi.QuotationID & "-" & CStr(Microsoft.VisualBasic.Right(CInt(Microsoft.VisualBasic.Right(qfi.TagID, 2)) + 101, 2))
        End If

    End Function
    Function GetQuotationID() As String
        Dim str As String
        str = CStr(Format(Now, "yyMMdd"))
        Dim qfi As New QuotationInfo
        Dim qfc As New QuotationController

        qfi = qfc.QuotationFW_GetID(str)
        If qfi Is Nothing Then
            GetQuotationID = "FW" & str & "00001"
        Else
            GetQuotationID = "FW" & str & Mid((CInt(Mid(qfi.QuotationID, 9)) + 100001), 2)
        End If
    End Function
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Select Case Label6.Text
            Case "範圍報價"
                If Edit = False Then
                    DataNew()
                Else
                    DataEdit()
                End If
            Case "範圍報價審核"
                DataChecked()
        End Select

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtMcode_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtMcode.ButtonClick
        tempCode = ""
        frmBOMSelect.ShowDialog()

        If tempCode = "" Then
            Exit Sub
        Else

            txtMcode.EditValue = tempCode

        End If
    End Sub

 
    Private Sub txtMcode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMcode.LostFocus

        On Error Resume Next
        Dim qfi As New List(Of QuotationInfo)
        Dim qfc As New QuotationController

        If Len(txtMcode.EditValue) = 0 Then
            txtGauge.Text = ""
            txtName.Text = ""
            txtUnit.Text = ""
            ds.Tables("QuotationFW").Rows.Clear()
            Exit Sub
        End If

        Dim mi As New MaterialInfo
        Dim mc As New MaterialController
        mi = mc.MaterialCode_Get(txtMcode.EditValue)
        txtGauge.Text = mi.M_Gauge
        txtName.Text = mi.M_Name
        txtUnit.Text = mi.M_Unit
        ds.Tables("QuotationFW").Rows.Clear()
       
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Label6.Text = "範圍報價審核" Then
            For i As Integer = 0 To ds.Tables("QuotationFW").Rows.Count - 1
                ds.Tables("QuotationFW").Rows(i)("Checked") = True
            Next
        Else
        End If

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Label6.Text = "範圍報價審核" Then
            For i As Integer = 0 To ds.Tables("QuotationFW").Rows.Count - 1
                ds.Tables("QuotationFW").Rows(i)("Checked") = False
            Next
        Else
        End If

    End Sub
End Class
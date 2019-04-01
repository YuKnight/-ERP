Imports System
Imports System.IO
Imports System.Windows.Forms
Imports LFERP.Library.ProductProcess

Public Class frmPDProductComplaint
    Private fs As IO.FileStream
    Dim ds As New DataSet

    Private Sub frmPDProductComplaint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtNO.Text = tempValue2
        Label9.Text = tempValue
        tempValue = ""
        tempValue2 = ""
        CreateTable()

        Dim ptc As New LFERP.Library.Product.ProductController
        ImageInput.Properties.DataSource = ptc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        ImageInput.Properties.DisplayMember = "PM_M_Code"
        ImageInput.Properties.ValueMember = "PM_M_Code"

        Dim pc As New ProcessMainControl

        Select Case Label9.Text

            Case "工藝流程投訴"
                Getenable(True)
                If Edit = False Then
                    txtNO.Enabled = False
                    Label6.Text = UserName

                Else
                    txtNO.Enabled = False
                    LoadData(txtNO.Text)
                End If
                XtraTabControl1.SelectedTabPage = XtraTabPage1
            Case "PreView"
                Getenable(False)
                txtNO.Enabled = False
                LoadData(txtNO.Text)
                cmdSave.Visible = False
                XtraTabControl1.SelectedTabPage = XtraTabPage1

                GridView1.OptionsBehavior.AutoSelectAllInEditor = False
                GridView1.OptionsBehavior.Editable = False
                GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        End Select

    End Sub
    Sub Getenable(ByVal a As Boolean)
        TextEdit2.Enabled = a
        TextEdit3.Enabled = a
        MemoEdit1.Enabled = a
    End Sub
    Sub CreateTable()

        ds.Tables.Clear()
        With ds.Tables.Add("Complaint")

            .Columns.Add("IndexNO", GetType(Integer))
            .Columns.Add("PS_Num", GetType(String))
            .Columns.Add("PS_NO", GetType(String))
            .Columns.Add("PS_Name", GetType(String))
            .Columns.Add("D_Name", GetType(String))
            .Columns.Add("PS_Question", GetType(String))
            .Columns.Add("PC_NO", GetType(String))
            .Columns.Add("PS_Photo", GetType(Byte()))

        End With
        With ds.Tables.Add("DelComplaint")

            .Columns.Add("PC_NO", GetType(String))
            .Columns.Add("PS_Num", GetType(String))

        End With
        Grid.DataSource = ds.Tables("Complaint")

    End Sub

    Function LoadData(ByVal PC_NO As String) As Boolean
        LoadData = True
        Dim pc As New ProductComplaintMainControl
        Dim pci As List(Of ProductComplaintMainInfo)

        Try
            pci = pc.ProductComplaintMain_GetList(PC_NO, Nothing, Nothing)
            If pci Is Nothing Then
                LoadData = False
                Exit Function
            End If

            txtNO.Text = pci(0).PC_NO
            TextEdit2.Text = pci(0).Pro_NO
            TextEdit3.Text = pci(0).PM_M_Code
            Label6.Text = pci(0).ActionName
            MemoEdit1.Text = pci(0).PC_Remark

            Dim pmc As New ProcessMainControl
            RepositoryItemLookUpEdit1.DataSource = pmc.ProcessSub_GetList(pci(0).Pro_NO, Nothing, Nothing, Nothing, Nothing, Nothing)

            RepositoryItemLookUpEdit1.DisplayMember = "PS_NO"
            RepositoryItemLookUpEdit1.ValueMember = "PS_NO"

            ds.Tables("Complaint").Rows.Clear()

            LoadSub(pc.ProductComplaintSub_GetList(PC_NO, Nothing, Nothing))

        Catch ex As Exception
            LoadData = False
            MsgBox(ex.Message)
        End Try

    End Function

    Sub LoadSub(ByVal dlist As List(Of ProductComplaintMainInfo))
        On Error Resume Next

        If dlist Is Nothing Then Exit Sub

        Dim i As Integer
        Dim row As DataRow

        For i = 0 To dlist.Count - 1

            row = ds.Tables("Complaint").NewRow

            row("IndexNO") = dlist(i).IndexNO

            row("PC_NO") = dlist(i).PC_NO
            row("PS_Num") = dlist(i).PS_Num
            row("PS_NO") = dlist(i).PS_NO
            row("PS_Name") = dlist(i).PS_Name
            row("D_Name") = dlist(i).D_Name
            row("PS_Question") = dlist(i).PS_Question
            row("PS_Photo") = dlist(i).PS_Photo

            ds.Tables("Complaint").Rows.Add(row)

        Next

    End Sub

    Public Function GetNO() As String

        Dim wqi As New ProductComplaintMainInfo
        Dim wqc As New ProductComplaintMainControl

        Dim str As String
        str = CStr(Format(Now, "yyMM"))
        wqi = wqc.ProductComplaintMain_GetNO(str)

        If wqi Is Nothing Then
            GetNO = "PC" & str & "0001"
        Else
            GetNO = "PC" & str & Mid((CInt(Mid(wqi.PC_NO, 7)) + 10001), 2)
        End If
    End Function

    Sub DataNew()

        Dim pi As New ProductComplaintMainInfo
        Dim pc As New ProductComplaintMainControl

        txtNO.Text = GetNO()
        pi.PC_NO = txtNO.Text
        pi.Pro_NO = TextEdit2.Text
        pi.PM_M_Code = TextEdit3.Text
        pi.PC_Action = InUserID
        pi.PC_Remark = MemoEdit1.Text
        pi.PC_AddDate = Format(Now, "yyyy/MM/dd")
        pi.PC_EditDate = Format(Now, "yyyy/MM/dd")

        If pc.ProductComplaintMain_Add(pi) = False Then
            MsgBox("添加失敗，請檢查原因！")
            Exit Sub
        End If
        Dim i As Integer

        For i = 0 To ds.Tables("Complaint").Rows.Count - 1

            pi.PC_NO = txtNO.Text

            pi.PS_Num = ds.Tables("Complaint").Rows(i)("PS_Num")
            pi.PS_NO = ds.Tables("Complaint").Rows(i)("PS_NO")
            pi.PS_Name = ds.Tables("Complaint").Rows(i)("PS_Name")
            pi.D_Name = ds.Tables("Complaint").Rows(i)("D_Name")

            If IsDBNull(ds.Tables("Complaint").Rows(i)("PS_Question")) Then
                pi.PS_Question = Nothing
            Else
                pi.PS_Question = ds.Tables("Complaint").Rows(i)("PS_Question")
            End If

            If IsDBNull(ds.Tables("Complaint").Rows(i)("PS_Photo")) Then
                pi.PS_Photo = Nothing
            Else
                pi.PS_Photo = ds.Tables("Complaint").Rows(i)("PS_Photo")
            End If

            If pc.ProductComplaintSub_Add(pi) = False Then
                MsgBox("子表保存失敗!")
                Exit Sub
            End If
        Next
        Me.Close()
    End Sub

    Sub DataEdit()
        Dim pi As New ProductComplaintMainInfo
        Dim pc As New ProductComplaintMainControl

        pi.PC_NO = txtNO.Text
        pi.Pro_NO = TextEdit2.Text
        pi.PM_M_Code = TextEdit3.Text
        pi.PC_Action = InUserID
        pi.PC_Remark = MemoEdit1.Text
        pi.PC_EditDate = Format(Now, "yyyy/MM/dd")

        If pc.ProductComplaintMain_Update(pi) = False Then
            MsgBox("添加失敗，請檢查原因！")
            Exit Sub
        End If

        If ds.Tables("DelComplaint").Rows.Count > 0 Then
            For i As Integer = 0 To ds.Tables("DelComplaint").Rows.Count - 1
                pc.ProductComplaintSub_Delete(txtNO.Text, CStr(ds.Tables("DelComplaint").Rows(i)("PS_Num")))
            Next
        End If

        For j As Integer = 0 To ds.Tables("Complaint").Rows.Count - 1

            If IsDBNull(ds.Tables("Complaint").Rows(j)("IndexNO")) Then  '修改中新增

                pi.PC_NO = txtNO.Text

                pi.PS_Num = ds.Tables("Complaint").Rows(j)("PS_Num")
                pi.PS_NO = ds.Tables("Complaint").Rows(j)("PS_NO")
                pi.PS_Name = ds.Tables("Complaint").Rows(j)("PS_Name")
                pi.D_Name = ds.Tables("Complaint").Rows(j)("D_Name")
                If IsDBNull(ds.Tables("Complaint").Rows(j)("PS_Question")) Then
                    pi.PS_Question = Nothing
                Else
                    pi.PS_Question = ds.Tables("Complaint").Rows(j)("PS_Question")
                End If

                If IsDBNull(ds.Tables("Complaint").Rows(j)("PS_Photo")) Then
                    pi.PS_Photo = Nothing
                Else
                    pi.PS_Photo = ds.Tables("Complaint").Rows(j)("PS_Photo")
                End If


                If pc.ProductComplaintSub_Add(pi) = False Then
                    MsgBox("子表保存失敗!")
                    Exit Sub
                End If
            ElseIf Not IsDBNull(ds.Tables("Complaint").Rows(j)("IndexNO")) Then

                pi.PC_NO = ds.Tables("Complaint").Rows(j)("PC_NO")
                pi.PS_Num = ds.Tables("Complaint").Rows(j)("PS_Num")
                pi.PS_NO = ds.Tables("Complaint").Rows(j)("PS_NO")
                pi.PS_Name = ds.Tables("Complaint").Rows(j)("PS_Name")
                pi.D_Name = ds.Tables("Complaint").Rows(j)("D_Name")

                If IsDBNull(ds.Tables("Complaint").Rows(j)("PS_Question")) Then
                    pi.PS_Question = Nothing
                Else
                    pi.PS_Question = ds.Tables("Complaint").Rows(j)("PS_Question")
                End If

                If IsDBNull(ds.Tables("Complaint").Rows(j)("PS_Photo")) Then
                    pi.PS_Photo = Nothing
                Else
                    pi.PS_Photo = ds.Tables("Complaint").Rows(j)("PS_Photo")
                End If

                If pc.ProductComplaintSub_Update(pi) = False Then
                    MsgBox("子表保存失敗!")
                    Exit Sub
                End If
            End If
        Next
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Label9.Text = "工藝流程投訴" Then
            If Edit = False Then
                DataNew()
            Else
                DataEdit()
            End If
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmsMenuAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMenuAdd.Click
        Dim row As DataRow
        row = ds.Tables("Complaint").NewRow
        If ds.Tables("Complaint").Rows.Count = 0 Then
            row("PS_Num") = 1
        Else
            row("PS_Num") = ds.Tables("Complaint").Rows.Count + 1
        End If
        ds.Tables("Complaint").Rows.Add(row)
    End Sub

    Private Sub cmsMenuDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmsMenuDel.Click
        If ds.Tables("Complaint").Rows.Count = 0 Then Exit Sub
        Dim DelTemp As String
        DelTemp = GridView1.GetRowCellDisplayText(ArrayToString(GridView1.GetSelectedRows()), "PS_Num")

        If DelTemp = "PS_Num" Then
        Else
            '在刪除表中增加被刪除的記錄
            Dim row As DataRow = ds.Tables("DelComplaint").NewRow

            row("PC_NO") = ds.Tables("Complaint").Rows(GridView1.FocusedRowHandle)("PC_NO")
            row("PS_Num") = DelTemp
            ds.Tables("DelComplaint").Rows.Add(row)
        End If
        ds.Tables("Complaint").Rows.RemoveAt(CInt(ArrayToString(GridView1.GetSelectedRows())))
    End Sub

    Private Sub TextEdit2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit2.LostFocus
        Dim pmi As List(Of ProcessMainInfo)
        Dim pmc As New ProcessMainControl
        pmi = pmc.ProcessMain_GetList1(TextEdit2.Text, Nothing, Nothing, Nothing)
        If pmi.Count = 0 Then Exit Sub
        TextEdit3.Text = pmi(0).PM_M_Code
        RepositoryItemLookUpEdit1.DataSource = pmc.ProcessSub_GetList(TextEdit2.Text, Nothing, Nothing, Nothing, Nothing, Nothing)
        RepositoryItemLookUpEdit1.DisplayMember = "PS_NO"
        RepositoryItemLookUpEdit1.ValueMember = "PS_NO"

    End Sub


    Private Sub RepositoryItemLookUpEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryItemLookUpEdit1.EditValueChanged

        Dim Rlue As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        Dim pmc As New ProcessMainControl
        Dim pc As New ProcessMainControl

        ds.Tables("Complaint").Rows((GridView1.FocusedRowHandle)).Item("PS_Name") = pmc.ProcessSub_GetList(Trim(TextEdit2.Text).ToString, Rlue.EditValue, Nothing, Nothing, Nothing, Nothing)(0).PS_Name
        ds.Tables("Complaint").Rows((GridView1.FocusedRowHandle)).Item("D_Name") = pmc.ProcessSub_GetList(Trim(TextEdit2.Text).ToString, Rlue.EditValue, Nothing, Nothing, Nothing, Nothing)(0).D_Dep
    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepositoryItemButtonEdit1.ButtonClick

      
        MsgBox("右邊添加此工序圖片！")

    End Sub

  
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If pPhoto.Image Is Nothing Then
            ds.Tables("Complaint").Rows(GridView1.FocusedRowHandle)("PS_Photo") = Nothing
        Else
            ds.Tables("Complaint").Rows(GridView1.FocusedRowHandle)("PS_Photo") = ImageToByte(pPhoto.Image)
        End If
        pPhoto.Image = Nothing
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If GridView1.RowCount = 0 Then Exit Sub
        Dim ofd As New OpenFileDialog
        Dim i As Integer
        ofd.Filter = "圖片文件(*.jpg,*.gif,*.bmp)|*.jpg;*.gif;*.bmp"
        ofd.ShowDialog()
        If ofd.FileName.ToString = "" Then Exit Sub
        fs = New IO.FileStream(ofd.FileName.ToString, IO.FileMode.Open, IO.FileAccess.Read)
        pPhoto.Image = Image.FromFile(ofd.FileName.ToString)

        Select Case CInt(ofd.OpenFile.Length / 1024)
            Case Is < 80 : i = 0
            Case Is > 80 < 100 : i = 100
            Case Is > 100 < 150 : i = 85
            Case Is > 300 : i = 65
        End Select

        Dim ci As New CompressImage
        If i = 0 Then
        Else
            ci.GetJPEG(pPhoto.Image, pPhoto, i)
        End If
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        pPhoto.Image = Nothing
    End Sub

    Private Sub ImageInput_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImageInput.EditValueChanged
        On Error Resume Next
        Dim ptc As New LFERP.Library.Product.ProductController
        Dim ptiL As New List(Of LFERP.Library.Product.ProductInfo)
        ptiL = ptc.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
        If ptiL.Count > 0 Then
            If ptiL(0).PM_Image Is Nothing Then
            Else
                pPhoto.Image = ByteToImage(ptiL(0).PM_Image)
            End If
        Else
            MsgBox("產品編號圖片為空！")
        End If
    End Sub

 
    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If IsDBNull(ds.Tables("Complaint").Rows(GridView1.FocusedRowHandle)("PS_Photo")) Then
            pPhoto.Image = Nothing
        Else
            pPhoto.Image = ByteToImage(ds.Tables("Complaint").Rows(GridView1.FocusedRowHandle)("PS_Photo"))
        End If
    End Sub
End Class
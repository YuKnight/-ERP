Imports LFERP.Library.Material
Imports LFERP.Library

Public Class frmMaterialType
    Public EditType As String = ""
    Public TypeTopID As String = ""


    Dim mc As New MaterialTypeController

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()

    End Sub

    Private Sub frmMaterialType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        txtName.Text = ""
        txtRemark.Text = ""
        txtEngName.Text = ""
        ' Label5.Text = frmMaterialParam.tv1.SelectedNode.FullPath

        txtID.Enabled = False
        If Edit = False Then
            txtID.Text = ""
            Select Case EditType
                Case "大類"
                    txtID.Text = mc.MaterialType1_GetID(TypeTopID)
                Case "中類"
                    txtID.Text = mc.MaterialType2_GetID(TypeTopID)
                Case "小類"
                    txtID.Text = mc.MaterialType3_GetID(TypeTopID)
            End Select
        Else
            LoadData()
        End If




    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtName.Text = "" Then
            MsgBox("沒有輸入名稱,請輸入", , "提示")
            Exit Sub
        End If

        Dim tSave As Boolean
        If Edit = False Then     '新增
            Select Case EditType
                Case "大類"
                    Dim objInfo1 As New MaterialTypeInfo1
                    objInfo1.MaterialTypeID = TypeTopID
                    objInfo1.Type1ID = txtID.Text
                    objInfo1.Type1Name = txtName.Text
                    objInfo1.Type1Remark = txtRemark.Text
                    objInfo1.MaterialTypeNameEng = txtEngName.Text
                    tSave = mc.MaterialType1_Add(objInfo1)
                Case "中類"
                    Dim objInfo2 As New MaterialTypeInfo2
                    objInfo2.Type1ID = TypeTopID
                    objInfo2.Type2ID = txtID.Text
                    objInfo2.Type2Name = txtName.Text
                    objInfo2.Type2Remark = txtRemark.Text
                    objInfo2.MaterialTypeNameEng = txtEngName.Text
                    tSave = mc.MaterialType2_Add(objInfo2)
                Case "小類"
                    Dim objInfo3 As New MaterialTypeInfo3
                    objInfo3.Type2ID = TypeTopID
                    objInfo3.Type3ID = txtID.Text
                    objInfo3.Type3Name = txtName.Text
                    objInfo3.Type3Remark = txtRemark.Text
                    objInfo3.MaterialTypeNameEng = txtEngName.Text
                    tSave = mc.MaterialType3_Add(objInfo3)
            End Select

        Else     '修改
            Select Case EditType
                Case "大類"
                    Dim objInfo1 As New MaterialTypeInfo1
                    objInfo1.MaterialTypeID = TypeTopID
                    objInfo1.Type1ID = txtID.Text
                    objInfo1.Type1Name = txtName.Text
                    objInfo1.Type1Remark = txtRemark.Text
                    objInfo1.MaterialTypeNameEng = txtEngName.Text

                    tSave = mc.MaterialType1_Update(objInfo1)
                Case "中類"
                    Dim objInfo2 As New MaterialTypeInfo2
                    objInfo2.Type1ID = TypeTopID
                    objInfo2.Type2ID = txtID.Text
                    objInfo2.Type2Name = txtName.Text
                    objInfo2.Type2Remark = txtRemark.Text
                    objInfo2.MaterialTypeNameEng = txtEngName.Text
                    tSave = mc.MaterialType2_Update(objInfo2)
                Case "小類"
                    Dim objInfo3 As New MaterialTypeInfo3
                    objInfo3.Type2ID = TypeTopID
                    objInfo3.Type3ID = txtID.Text
                    objInfo3.Type3Name = txtName.Text
                    objInfo3.Type3Remark = txtRemark.Text
                    objInfo3.MaterialTypeNameEng = txtEngName.Text
                    tSave = mc.MaterialType3_Update(objInfo3)
            End Select



        End If
        If tSave = False Then
            MsgBox("保存失敗,請檢查錯誤!")
        Else
            Me.Close()
        End If

    End Sub

    Sub LoadData()
        Select Case EditType

            Case "大類"
                Dim objInfo1 As New MaterialTypeInfo1
                objInfo1 = mc.MaterialType1_Get(txtID.Text)
                TypeTopID = objInfo1.MaterialTypeID
                txtID.Text = objInfo1.Type1ID
                txtName.Text = objInfo1.Type1Name
                txtRemark.Text = objInfo1.Type1Remark
                txtEngName.Text = objInfo1.MaterialTypeNameEng
            Case "中類"
                Dim objInfo2 As New MaterialTypeInfo2
                objInfo2 = mc.MaterialType2_Get(txtID.Text)
                TypeTopID = objInfo2.Type1ID
                txtID.Text = objInfo2.Type2ID
                txtName.Text = objInfo2.Type2Name
                txtRemark.Text = objInfo2.Type2Remark
                txtEngName.Text = objInfo2.MaterialTypeNameEng

            Case "小類"
                Dim objInfo3 As New MaterialTypeInfo3
                objInfo3 = mc.MaterialType3_Get(txtID.Text)
                TypeTopID = objInfo3.Type2ID
                txtID.Text = objInfo3.Type3ID
                txtName.Text = objInfo3.Type3Name
                txtRemark.Text = objInfo3.Type3Remark
                txtEngName.Text = objInfo3.MaterialTypeNameEng
        End Select


    End Sub


End Class
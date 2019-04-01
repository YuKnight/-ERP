Imports LFERP.Library.WareHouse.WareInventoryNGType

Public Class frmWareInventoryNGType

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmWareInventoryNGType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtM_Code.Text = tempValue
        tempValue = Nothing

        LoadData()
    End Sub

    Sub LoadData()
        Dim rc As New WareInventoryNGTypeControl
        Dim rl As New List(Of WareInventoryNGTypeInfo)
        rl = rc.WareInventoryNGType_GetList(TxtM_Code.Text)

        If rl.Count <= 0 Then
            Exit Sub
        End If

        txtNGType.Text = rl(0).NGType
        txtNGName.Text = rl(0).NGName

        txtNGMaterial.Text = rl(0).NGMaterial
        txtRemark.Text = rl(0).Remark
    End Sub


    Sub SaveData()
        Dim rc As New WareInventoryNGTypeControl
        Dim rl As New List(Of WareInventoryNGTypeInfo)
        rl = rc.WareInventoryNGType_GetList(TxtM_Code.Text)

        Dim ri As New WareInventoryNGTypeInfo
        ri.M_Code = TxtM_Code.Text
        ri.NGType = txtNGType.Text
        ri.NGName = txtNGName.Text

        ri.NGMaterial = txtNGMaterial.Text
        ri.Remark = txtRemark.Text

        If rl.Count <= 0 Then
            ri.AddAction = InUserID
            ri.AddDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
            If rc.WareInventoryNGType_Add(ri) = True Then
            Else
                Exit Sub
            End If
        Else
            ri.UpdateAction = InUserID
            ri.UpdateDate = Format(Now, "yyyy/MM/dd HH:mm:ss")
            If rc.WareInventoryNGType_Update(ri) = True Then
            Else
                Exit Sub
            End If
        End If

        MsgBox("保存成功")
        Me.Close()

    End Sub



    Private Sub cmdInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInsert.Click
        SaveData()
    End Sub
End Class
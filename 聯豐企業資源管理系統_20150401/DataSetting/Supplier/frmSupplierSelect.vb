Imports LFERP.DataSetting
Public Class frmSupplierSelect

    Private Sub frmSupplierSelect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSuppliersType()
    End Sub



    ''' <summary>
    ''' 載入供應商類型
    ''' </summary>
    ''' <remarks></remarks>
    Sub LoadSuppliersType()
        Dim mc As New SuppliersTypeControler
        'gluCuster.Properties.DisplayMember = "S_TypeID"
        'gluCuster.Properties.ValueMember = "S_TypeID"
        TreeList1.DataSource = mc.SuppliersType_GetList(Nothing, Nothing, Nothing)

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged

        PopupContainerEdit1.Text = TreeList1.FocusedNode.Item("S_TypeID").ToString()

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click


        If RadioButton1.Checked = True Then
            tempValue = "1"
            tempValue2 = TextEdit1.Text
        End If

        If RadioButton2.Checked = True Then
            tempValue = "2"
            tempValue2 = TextEdit2.Text
        End If

        If RadioButton3.Checked = True Then
            tempValue = "3"
            tempValue2 = PopupContainerEdit1.Text
        End If

        If RadioButton4.Checked = True Then
            tempValue = "4"
            tempValue2 = Trim(Microsoft.VisualBasic.Left(txtDai.Text, 1))
        End If

        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
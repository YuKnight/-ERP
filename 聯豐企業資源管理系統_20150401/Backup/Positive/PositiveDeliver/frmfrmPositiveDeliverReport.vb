Imports LFERP.Library.Positive
Imports LFERP.DataSetting

Public Class frmfrmPositiveDeliverReport


    ''' <summary>
    ''' 加載產品編號
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadP_Mcode()
        Dim pcMainCtrl As New Library.Product.ProductController
        P_M_Code.Properties.DisplayMember = "PM_M_Code"
        P_M_Code.Properties.ValueMember = "PM_M_Code"
        P_M_Code.Properties.DataSource = pcMainCtrl.Product_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing)
    End Sub

#Region "初始化加載時間"
    Private Sub frmfrmPositiveDeliverReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadP_Mcode()

        dtStart.EditValue = Format(Now, "yyyy/MM/" & "01")
        dtEnd.EditValue = Format(Now, "yyyy/MM/dd")
    End Sub
#End Region

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click

    End Sub

    Private Sub ButtonExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class
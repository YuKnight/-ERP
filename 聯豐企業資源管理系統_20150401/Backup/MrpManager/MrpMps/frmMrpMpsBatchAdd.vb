Public Class frmMrpMpsBatchAdd

#Region "¦r¬qÄÝ©Ê"
    Private _BeginDate As Date
    Property BeginDate() As Date
        Get
            Return _BeginDate
        End Get
        Set(ByVal value As Date)
            _BeginDate = value
        End Set
    End Property


    Private _PlanQty As Integer
    Public Property PlanQty() As Integer
        Get
            Return _PlanQty
        End Get
        Set(ByVal value As Integer)
            _PlanQty = value
        End Set
    End Property


    Private _BatchAddQty As Integer
    Public ReadOnly Property BatchAddQty() As Integer
        Get
            Return _BatchAddQty
        End Get
        'Set(ByVal value As Integer)
        '    _BatchAddQty = value
        'End Set
    End Property

#End Region

    Private Sub frmMrpMpsBatchAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dteBeginDate.EditValue = IIf(_BeginDate.Year = 1, Now, _BeginDate)
        clcPlanQty.EditValue = _PlanQty
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        _BeginDate = dteBeginDate.EditValue
        _PlanQty = clcPlanQty.EditValue
        _BatchAddQty = clcBatchAddQty.EditValue
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub clcPlanQty_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles clcPlanQty.EditValueChanging
        If (CDec(e.NewValue) > 999999999 Or CDec(e.NewValue) < 0) Then
            e.Cancel = True
        End If
    End Sub
End Class
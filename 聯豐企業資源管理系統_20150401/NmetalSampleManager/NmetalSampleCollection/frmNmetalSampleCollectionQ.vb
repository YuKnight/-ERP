Imports LFERP.Library.MaterialParam
Imports LFERP.Library.Material
Imports LFERP.Library
Imports LFERP.DataSetting
Imports LFERP.Library.Product
Imports LFERP.Library.PieceProcess
Imports LFERP.Library.NmetalSampleManager.NmetalSampleTransaction
Public Class frmNmetalSampleCollectionQ
    Dim mc As New ProductController
    Dim mtd As New CusterControler
    Dim pncon As New PersonnelControl
    Dim stcon As New NmetalSampleTransactionControler

    Private Sub frmSampleCollectionQ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pmlist As New List(Of PersonnelInfo)
        pmlist = pncon.FacBriSearch_GetList(Nothing, Nothing, Nothing, Nothing)
        gluSE_OutD_ID.Properties.DisplayMember = "DepName"
        gluSE_OutD_ID.Properties.ValueMember = "DepID"
        gluSE_OutD_ID.Properties.DataSource = pmlist
        '---------------------------------------------------------------------
        Dim stlist As New List(Of NmetalSampleTransactionInfo)
        stlist = stcon.NmetalSampleTransactionType_GetList(Nothing, Nothing)
        gluStatusType.Properties.DisplayMember = "StatusTypeName"
        gluStatusType.Properties.ValueMember = "StatusType"
        gluStatusType.Properties.DataSource = stlist

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        tempValue = Nothing
        tempValue2 = Nothing
        Select Case Mid(cboCodeType.EditValue, 1, 3)
            Case "[A]"
                tempValue = txtCode_ID.Text
            Case "[B]"
                tempValue = txtCode_ID.Text
            Case "[C]"
                tempValue = gluSE_OutD_ID.EditValue
            Case "[D]"
                tempValue = gluStatusType.EditValue
        End Select

        tempValue2 = cboCodeType.EditValue
        Me.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cboCodeType_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCodeType.EditValueChanged
        Select Case Mid(cboCodeType.EditValue, 1, 3)
            Case "[A]"
                txtCode_ID.Enabled = True
                gluSE_OutD_ID.Enabled = False
                gluStatusType.Enabled = False
            Case "[B]"
                txtCode_ID.Enabled = True
                gluSE_OutD_ID.Enabled = False
                gluStatusType.Enabled = False
            Case "[C]"
                txtCode_ID.Enabled = False
                gluSE_OutD_ID.Enabled = True
                gluStatusType.Enabled = False
            Case "[D]"
                txtCode_ID.Enabled = False
                gluSE_OutD_ID.Enabled = False
                gluStatusType.Enabled = True
        End Select
    End Sub
End Class
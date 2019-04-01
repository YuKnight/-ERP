Imports LFERP.Library.MrpManager.MrpPurchaseRecord
Imports LFERP.Library.MrpManager.MrpInfo
Imports LFERP.Library.MrpManager.MrpMaterialCode
Imports System.Math
Public Class frmMrpPurchase
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Public Property StrMrpID() As String
        Get
            Return _StrMrpID
        End Get
        Set(ByVal value As String)
            _StrMrpID = value
        End Set
    End Property
    Private _StrMrpID As String


    Private Sub frmMrpPurchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mprcon As New MrpPurchaseRecordController
        '來源別
        Dim ds As New DataSet
        ds = mprcon.MrpPurchaseRecord_GetMrpID()
        GLU_MRPID.Properties.DisplayMember = "MRP_ID"    'txt
        GLU_MRPID.Properties.ValueMember = "MRP_ID"   'EditValue
        GLU_MRPID.Properties.DataSource = ds.Tables(0)

    End Sub
    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        If GLU_MRPID.Text = String.Empty Then
            Exit Sub
        End If
        GridControl.DataSource = Nothing
        BandedGridView.Bands.Clear()
        BandedGridView.Columns.Clear()
        Dim mpCon As New MrpPurchaseController
        Dim mprCon As New MrpPurchaseRecordController
        Dim mmcCon As New MrpMaterialCodeController
        Dim mmcInfo As New MrpMaterialCodeInfo
        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim YearWeek1 As Int32
        Dim AddWeek As Int32
        Dim YearWeek2 As Int32
        Dim ProductionWeek As Int32 = 1
        dt1 = mprCon.Mrp_GetDependReqWeek(GLU_MRPID.EditValue)
        Dim time As Integer = dt1.Columns.Count - 1
        Dim SumQty As Decimal
        For i As Integer = 0 To dt1.Rows.Count - 1
            If mmcCon.MrpMaterialCode_GetList(dt1.Rows(i)(1).ToString, Nothing, Nothing, Nothing, Nothing).Count <= 0 Then
                Exit For
            End If
            mmcInfo = mmcCon.MrpMaterialCode_GetList(dt1.Rows(i)(1).ToString, Nothing, Nothing, Nothing, Nothing)(0)
            AddWeek = Round(mmcInfo.MC_OrderInterVal / 7, 0) + ProductionWeek
            SumQty = mprCon.MrpPurchase_GetByM_codeAndMRP_ID(GLU_MRPID.EditValue, dt1.Rows(i)(1).ToString)
            Dim Num As Decimal = SumQty
            For j As Integer = time To 6 Step -1
                YearWeek1 = CInt(dt1.Columns(j).ColumnName)
                YearWeek2 = YearWeek1 - AddWeek
                If IsDBNull(dt1.Rows(i)(j)) = False Then
                    Dim col As New DataColumn
                    col.ColumnName = YearWeek2.ToString & ".1"
                    Try
                        dt1.Columns.Add(col)
                    Catch ex As Exception
                    End Try
                    If Num >= dt1.Rows(i)(j) Then
                        dt1.Rows(i)(col.ColumnName) = dt1.Rows(i)(j)
                        Num = Num - dt1.Rows(i)(j)
                    Else
                        dt1.Rows(i)(col.ColumnName) = Num
                        Num = 0
                    End If
                End If
            Next
        Next
        For i As Integer = 6 To dt1.Columns.Count - 2
            For j As Integer = dt1.Columns.Count - 1 To i + 1 Step -1
                If CDbl(dt1.Columns(j).ColumnName) < CDbl(dt1.Columns(j - 1).ColumnName) Then
                    dt1.Columns(dt1.Columns(j).ColumnName).SetOrdinal(j - 1)
                End If
            Next
        Next
        BandedGridView.Bands.AddBand("物料信息")
        GridControl.DataSource = dt1
        For i As Integer = 0 To 1
            BandedGridView.Columns(i).Width = 150
        Next
        For i As Integer = 6 To dt1.Columns.Count - 1
            If CDbl(dt1.Columns(i).ColumnName) > CInt(dt1.Columns(i).ColumnName) Then
                BandedGridView.Columns(i).Caption = "採購數量"
                BandedGridView.Columns(i).Width = 150
            Else
                BandedGridView.Columns(i).Caption = "需求數量"
                BandedGridView.Columns(i).Width = 150
            End If
        Next
        BandedGridView.Columns("MRP_ID").Visible = False

        For i As Integer = 1 To 5
            BandedGridView.Bands(0).Columns.Add(BandedGridView.Columns(dt1.Columns(i).ColumnName))
        Next
        BandedGridView.Bands.AddBand(Mid(dt1.Columns(6).ColumnName, 1, 4).ToString & "年" + Mid(dt1.Columns(6).ColumnName, 5, 2).ToString & "周")
        BandedGridView.Bands(BandedGridView.Bands.Count - 1).Columns.Add(BandedGridView.Columns(dt1.Columns(6).ColumnName))
        For i As Integer = 7 To dt1.Columns.Count - 1
            If CInt(dt1.Columns(i).ColumnName) > CInt(dt1.Columns(i - 1).ColumnName) Then
                BandedGridView.Bands.AddBand(Mid(dt1.Columns(i).ColumnName, 1, 4).ToString & "年" + Mid(dt1.Columns(i).ColumnName, 5, 2).ToString & "周")
                BandedGridView.Bands(BandedGridView.Bands.Count - 1).Columns.Add(BandedGridView.Columns(dt1.Columns(i).ColumnName))
            Else
                BandedGridView.Bands(BandedGridView.Bands.Count - 1).Columns.Add(BandedGridView.Columns(dt1.Columns(i).ColumnName))
            End If
        Next


    End Sub
End Class
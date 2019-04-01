Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.Positive
    Public Class PositiveQuotationEntryController
        Friend Function FillPositiveQuotationEntry(ByVal reader As IDataReader) As PositiveQuotationEntryInfo
            Dim objInfo As New PositiveQuotationEntryInfo
            objInfo.AutoID = reader("AutoID")
            objInfo.BillNo = reader("BillNo").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            If reader("EffectiveDate") Is DBNull.Value Then
                objInfo.EffectiveDate = Nothing
            Else
                objInfo.EffectiveDate = Format(CDate(reader("EffectiveDate")), "yyyy/MM/dd")
            End If
            If reader("ExpiryDate") Is DBNull.Value Then
                objInfo.ExpiryDate = Nothing
            Else
                objInfo.ExpiryDate = Format(CDate(reader("ExpiryDate")), "yyyy/MM/dd")
            End If
            objInfo.PartNo = reader("PartNo").ToString
            objInfo.UnitID = reader("UnitID").ToString 
            objInfo.Color = reader("Color").ToString
            If reader("QtyRangeFrom") Is DBNull.Value Then
                objInfo.QtyRangeFrom = Nothing
            Else
                objInfo.QtyRangeFrom = CDbl(reader("QtyRangeFrom").ToString)
            End If
            If reader("QtyRangeTo") Is DBNull.Value Then
                objInfo.QtyRangeTo = Nothing
            Else
                objInfo.QtyRangeTo = CDbl(reader("QtyRangeTo").ToString)
            End If
            If reader("Price") Is DBNull.Value Then
                objInfo.Price = Nothing
            Else
                objInfo.Price = CDbl(reader("Price").ToString)
            End If
            objInfo.CurrencyID = reader("CurrencyID").ToString
            If reader("Discount") Is DBNull.Value Then
                objInfo.Discount = Nothing
            Else
                objInfo.Discount = CDbl(reader("Discount").ToString)
            End If
            objInfo.TaxType = reader("TaxType").ToString
            If reader("TaxRate") Is DBNull.Value Then
                objInfo.TaxRate = Nothing
            Else
                objInfo.TaxRate = CDbl(reader("TaxRate").ToString)
            End If
            objInfo.Remarks = reader("Remarks").ToString
            Return objInfo
        End Function


        'Public Function PositiveQuotationEntry_GetList(ByVal BillNo As String) As List(Of PositiveQuotationEntryInfo)
        '    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        '    Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotationEntry_GetList")
        '    db.AddInParameter(dbComm, "@BillNo", DbType.String, BillNo)
        '    Dim FeatureList As New List(Of PositiveQuotationEntryInfo)
        '    Using reader As IDataReader = db.ExecuteReader(dbComm)
        '        While reader.Read
        '            FeatureList.Add(FillPositiveQuotationEntry(reader))
        '        End While
        '        Return FeatureList
        '    End Using
        'End Function

        Public Function PositiveQuotationEntry_GetTable(ByVal BillNo As String) As DataTable
            Dim ds As New DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotationEntry_GetList")
            db.AddInParameter(dbComm, "@BillNo", DbType.String, BillNo)
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function

        Public Function PositiveQuotationEntry_Delete(ByVal AutoID As String, ByVal BillNo As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotationEntry_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@BillNo", DbType.String, BillNo)
                db.ExecuteNonQuery(dbComm)
                PositiveQuotationEntry_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotationEntry_Delete = False
            End Try
        End Function


        Public Function PositiveQuotationEntry_Update(ByVal objinfo As PositiveQuotationEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotationEntry_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, objinfo.AutoID)
                db.AddInParameter(dbComm, "@BillNo", DbType.String, objinfo.BillNo)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, objinfo.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objinfo.M_Gauge)
                If objinfo.EffectiveDate = Nothing Then
                    db.AddInParameter(dbComm, "@EffectiveDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@EffectiveDate", DbType.Date, objinfo.EffectiveDate)
                End If
                If objinfo.ExpiryDate = Nothing Then
                    db.AddInParameter(dbComm, "@ExpiryDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ExpiryDate", DbType.Date, objinfo.ExpiryDate)
                End If
                db.AddInParameter(dbComm, "@PartNo", DbType.String, objinfo.PartNo)
                db.AddInParameter(dbComm, "@UnitID", DbType.String, objinfo.UnitID)
                db.AddInParameter(dbComm, "@Color", DbType.String, objinfo.Color)
                db.AddInParameter(dbComm, "@QtyRangeFrom", DbType.Decimal, objinfo.QtyRangeFrom)
                db.AddInParameter(dbComm, "@QtyRangeTo", DbType.Decimal, objinfo.QtyRangeTo)
                db.AddInParameter(dbComm, "@Price", DbType.Decimal, objinfo.Price)
                db.AddInParameter(dbComm, "@CurrencyID", DbType.String, objinfo.CurrencyID)
                db.AddInParameter(dbComm, "@Discount", DbType.Decimal, objinfo.Discount)
                db.AddInParameter(dbComm, "@TaxType", DbType.String, objinfo.TaxType)
                db.AddInParameter(dbComm, "@TaxRate", DbType.Decimal, objinfo.TaxRate)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                PositiveQuotationEntry_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotationEntry_Update = False
            End Try
        End Function


        Public Function PositiveQuotationEntry_Add(ByVal objInfo As PositiveQuotationEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotationEntry_Add")
                db.AddInParameter(dbComm, "@BillNo", DbType.String, objInfo.BillNo)
                db.AddInParameter(dbComm, "@M_Name", DbType.String, objInfo.M_Name)
                db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objInfo.M_Gauge)
                If objInfo.EffectiveDate = Nothing Then
                    db.AddInParameter(dbComm, "@EffectiveDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@EffectiveDate", DbType.Date, objInfo.EffectiveDate)
                End If
                If objInfo.ExpiryDate = Nothing Then
                    db.AddInParameter(dbComm, "@ExpiryDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ExpiryDate", DbType.Date, objInfo.ExpiryDate)
                End If
                db.AddInParameter(dbComm, "@PartNo", DbType.String, objInfo.PartNo)
                db.AddInParameter(dbComm, "@UnitID", DbType.String, objInfo.UnitID)
                db.AddInParameter(dbComm, "@Color", DbType.String, objInfo.Color)
                db.AddInParameter(dbComm, "@QtyRangeFrom", DbType.Decimal, objInfo.QtyRangeFrom)
                db.AddInParameter(dbComm, "@QtyRangeTo", DbType.Decimal, objInfo.QtyRangeTo)
                db.AddInParameter(dbComm, "@Price", DbType.Decimal, objInfo.Price)
                db.AddInParameter(dbComm, "@CurrencyID", DbType.String, objInfo.CurrencyID)
                db.AddInParameter(dbComm, "@Discount", DbType.Decimal, objInfo.Discount)
                db.AddInParameter(dbComm, "@TaxType", DbType.String, objInfo.TaxType)
                db.AddInParameter(dbComm, "@TaxRate", DbType.Decimal, objInfo.TaxRate)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                PositiveQuotationEntry_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotationEntry_Add = False
            End Try
        End Function

        ''' <summary>
        ''' 驗證指定條件下是否已存在報價
        ''' </summary>
        ''' <param name="CustomerID"></param>
        ''' <param name="PartNo"></param>
        ''' <param name="Color"></param>
        ''' <param name="BeginDate"></param>
        ''' <param name="EndDate"></param>
        ''' <param name="BeginQty"></param>
        ''' <param name="EndQty"></param>
        ''' <returns>True表示已存在報價</returns>
        ''' <remarks></remarks>
        Public Function PositiveQuotationEntry_VerifyValue(ByVal AutoID As String, ByVal CustomerID As String, ByVal PartNo As String, ByVal Color As String, ByVal BeginDate As DateTime, ByVal EndDate As DateTime, ByVal BeginQty As Decimal, ByVal EndQty As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotationEntry_VerifyValue")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@CustomerID", DbType.String, CustomerID)
                db.AddInParameter(dbComm, "@PartNo", DbType.String, PartNo)
                db.AddInParameter(dbComm, "@Color", DbType.String, Color)
                db.AddInParameter(dbComm, "@BeginDate", DbType.DateTime, BeginDate)
                db.AddInParameter(dbComm, "@EndDate", DbType.DateTime, EndDate)
                db.AddInParameter(dbComm, "@BeginQty", DbType.Decimal, BeginQty)
                db.AddInParameter(dbComm, "@EndQty", DbType.Decimal, EndQty)

                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    Return reader.Read()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotationEntry_VerifyValue = False
            End Try
        End Function

        '取得指定條件下的報價
        Public Function PositiveQuotationEntry_GetQuotation(ByVal CustomerID As String, ByVal PartNo As String, ByVal Color As String, ByVal OrderDate As Date, ByVal Qty As Decimal) As PositiveQuotationEntryInfo
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotationEntry_GetQuotation")
                db.AddInParameter(dbComm, "@CustomerID", DbType.String, CustomerID)
                db.AddInParameter(dbComm, "@PartNo", DbType.String, PartNo)
                db.AddInParameter(dbComm, "@Color", DbType.String, Color)
                db.AddInParameter(dbComm, "@OrderDate", DbType.Date, OrderDate)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, Qty)

                Dim bo As Boolean = False
                Dim Info As New PositiveQuotationEntryInfo
                Using reader As SqlDataReader = db.ExecuteReader(dbComm)
                    If reader.HasRows = False Then
                        Return Nothing
                    End If
                    While reader.Read
                        If bo Then
                            MsgBox("銷售報價中存在多條對應的報價")
                            Info = Nothing
                        Else
                            Info = FillPositiveQuotationEntry(reader)
                            bo = True
                        End If
                    End While
                    Return Info
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotationEntry_GetQuotation = Nothing
            End Try
        End Function

        '取得指定客戶顏色的報價信息
        Public Function PositiveQuotationEntry_GetPartNO(ByVal CustomerID As String, ByVal Color As String) As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PositiveQuotationEntry_GetPartNO")
                db.AddInParameter(dbComm, "@CustomerID", DbType.String, CustomerID)
                db.AddInParameter(dbComm, "@Color", DbType.String, Color)
                Dim ds As DataSet = db.ExecuteDataSet(dbComm)
                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                PositiveQuotationEntry_GetPartNO = Nothing
            End Try
        End Function
    End Class
End Namespace
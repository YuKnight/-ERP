Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpPurchaseRecord
    Public Class MrpPurchaseRecordEntryController
        Friend Function FillMrpPurchaseRecordEntry(ByVal reader As IDataReader) As MrpPurchaseRecordEntryInfo
            On Error Resume Next
            Dim objInfo As New MrpPurchaseRecordEntryInfo
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.MPI_CreateUserName = reader("MPI_CreateUserName").ToString
            objInfo.MPI_ModifyUserName = reader("MPI_ModifyUserName").ToString
            objInfo.MPI_CreateDate = IIf(IsDBNull(reader("MPI_CreateDate")), Nothing, reader("MPI_CreateDate"))
            objInfo.MPI_CreateUserID = reader("MPI_CreateUserID").ToString
            objInfo.MPI_ModifyDate = IIf(IsDBNull(reader("MPI_ModifyDate")), Nothing, reader("MPI_ModifyDate"))
            objInfo.MPI_ModifyUserID = reader("MPI_ModifyUserID").ToString
            objInfo.MPI_NeedQty = reader("MPI_NeedQty").ToString
            objInfo.MRP_ID = reader("MRP_ID").ToString
            objInfo.MrpPurchaseID = reader("MrpPurchaseID").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Source = reader("M_Source").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.MPI_NeedDate = IIf(IsDBNull(reader("MPI_NeedDate")), Nothing, reader("MPI_NeedDate"))
            objInfo.MPI_Remark = reader("MPI_Remark").ToString
            objInfo.S_Supplier = reader("S_Supplier").ToString
            objInfo.S_SupplierName = reader("S_SupplierName").ToString
            objInfo.UnitPrice = reader("UnitPrice")
            If IsDBNull(reader("ForecastDate")) Then
                objInfo.ForecastDate = Nothing
            Else
                objInfo.ForecastDate = reader("ForecastDate")
            End If
            Return objInfo
        End Function

        Public Function MrpPurchaseRecordEntry_GetList(ByVal MrpPurchaseID As String) As List(Of MrpPurchaseRecordEntryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecordEntry_GetList")
            db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, MrpPurchaseID)
            Dim FeatureList As New List(Of MrpPurchaseRecordEntryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpPurchaseRecordEntry(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpPurchaseRecordEntry_Delete(ByVal MrpPurchaseID As String, ByVal AutoID As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecordEntry_Delete")
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, MrpPurchaseID)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecordEntry_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecordEntry_Delete = False
            End Try
        End Function

        Public Function MrpPurchaseRecordEntry_Update(ByVal objinfo As MrpPurchaseRecordEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecordEntry_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, objinfo.AutoID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@MPI_ModifyUserID", DbType.String, objinfo.MPI_ModifyUserID)
                db.AddInParameter(dbComm, "@MPI_NeedQty", DbType.Decimal, objinfo.MPI_NeedQty)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, objinfo.MrpPurchaseID)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objinfo.S_Supplier)
                If objinfo.MPI_NeedDate = Nothing Then
                    db.AddInParameter(dbComm, "@MPI_NeedDate", DbType.Date, Nothing)
                Else
                    db.AddInParameter(dbComm, "@MPI_NeedDate", DbType.Date, objinfo.MPI_NeedDate)
                End If
                db.AddInParameter(dbComm, "@MPI_Remark", DbType.String, objinfo.MPI_Remark)
                If objinfo.ForecastDate = Nothing Then
                    db.AddInParameter(dbComm, "@ForecastDate", DbType.Date, Nothing)
                Else
                    db.AddInParameter(dbComm, "@ForecastDate", DbType.Date, objinfo.ForecastDate)
                End If
                db.AddInParameter(dbComm, "@UnitPrice", DbType.Decimal, objinfo.UnitPrice)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecordEntry_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecordEntry_Update = False
            End Try
        End Function
     

        Public Function MrpPurchaseRecordEntry_Add(ByVal objInfo As MrpPurchaseRecordEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecordEntry_Add")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@MPI_CreateUserID", DbType.String, objInfo.MPI_CreateUserID)
                db.AddInParameter(dbComm, "@MPI_NeedQty", DbType.Decimal, objInfo.MPI_NeedQty)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, objInfo.MrpPurchaseID)
                If objInfo.MPI_NeedDate = Nothing Then
                    db.AddInParameter(dbComm, "@MPI_NeedDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MPI_NeedDate", DbType.Date, objInfo.MPI_NeedDate)
                End If
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objInfo.S_Supplier)
                db.AddInParameter(dbComm, "@MPI_Remark", DbType.String, objInfo.MPI_Remark)
                If objInfo.ForecastDate = Nothing Then
                    db.AddInParameter(dbComm, "@ForecastDate", DbType.Date, Nothing)
                Else
                    db.AddInParameter(dbComm, "@ForecastDate", DbType.Date, objInfo.ForecastDate)
                End If
                db.AddInParameter(dbComm, "@UnitPrice", DbType.Decimal, objInfo.UnitPrice)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecordEntry_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecordEntry_Add = False
            End Try
        End Function

        Public Function MrpCode_GetList() As DataSet
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("M_Code_GetList")
                Dim ds As New DataSet
                ds = db.ExecuteDataSet(dbComm)
                Return ds
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function MrpPurchaseRecordEntry_UpdateQuotation(ByVal objinfo As MrpPurchaseRecordEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecordEntry_UpdateQuotation")
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, objinfo.MrpPurchaseID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objinfo.S_Supplier)
                db.AddInParameter(dbComm, "@UnitPrice", DbType.Decimal, objinfo.UnitPrice)
                db.ExecuteNonQuery(dbComm)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
    End Class
End Namespace


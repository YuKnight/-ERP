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
            objInfo.MP_CreateUserName = reader("MP_CreateUserName").ToString
            objInfo.MP_ModifyUserName = reader("MP_ModifyUserName").ToString
            objInfo.MPI_CreateDate = reader("MPI_CreateDate").ToString
            objInfo.MPI_CreateUserID = reader("MPI_CreateUserID").ToString
            objInfo.MPI_ModifyDate = reader("MPI_ModifyDate").ToString
            objInfo.MPI_ModifyUserID = reader("MPI_ModifyUserID").ToString
            objInfo.MPI_NeedQty = reader("MPI_NeedQty").ToString
            objInfo.MRP_ID = reader("MRP_ID").ToString
            objInfo.MrpPurchaseID = reader("MrpPurchaseID").ToString

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
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecordEntry_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecordEntry_Add = False
            End Try
        End Function
    End Class
End Namespace


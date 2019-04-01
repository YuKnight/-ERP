Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpPurchaseRecord

    Public Class MrpPurchaseRecordController
        Friend Function FillMrpPurchaseRecord(ByVal reader As IDataReader) As MrpPurchaseRecordInfo
            On Error Resume Next
            Dim objInfo As New MrpPurchaseRecordInfo
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.CheckBit = reader("CheckBit").ToString
            objInfo.MPP_CreateDate = reader("MPP_CreateDate").ToString
            objInfo.MPP_CreateUserID = reader("MPP_CreateUserID").ToString
            objInfo.MPP_ModifyDate = reader("MPP_ModifyDate").ToString
            objInfo.MPP_ModifyUserID = reader("MPP_ModifyUserID").ToString
            objInfo.MRP_ID = reader("MRP_ID").ToString
            objInfo.MrpPurchaseID = reader("MrpPurchaseID").ToString
            objInfo.MPP_CreateUserName = reader("MPP_CreateUserName").ToString
            objInfo.MPP_ModifyUserName = reader("MPP_ModifyUserName").ToString
            objInfo.MPP_CheckUserName = reader("MPP_CheckUserName").ToString
            objInfo.MPP_CreateDate = reader("MPP_CreateDate").ToString
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.IsPurchase = reader("IsPurchase").ToString
            Return objInfo
        End Function
        Public Function MrpPurchaseRecord_GetList(ByVal MrpPurchaseID As String) As List(Of MrpPurchaseRecordInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_GetList")
            db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, MrpPurchaseID)
            Dim FeatureList As New List(Of MrpPurchaseRecordInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpPurchaseRecord(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function MrpPurchaseRecord_Delete(ByVal MrpPurchaseID As String, ByVal AutoID As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_Delete")
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, MrpPurchaseID)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecord_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecord_Delete = False
            End Try
        End Function
        Public Function MrpPurchaseRecord_Update(ByVal objinfo As MrpPurchaseRecordInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_Update")
                db.AddInParameter(dbComm, "@MPP_ModifyUserID", DbType.String, objinfo.MPP_ModifyUserID)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, objinfo.MrpPurchaseID)
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, objinfo.AutoID)
                db.AddInParameter(dbComm, "@IsPurchase", DbType.Boolean, objinfo.IsPurchase)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecord_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecord_Update = False
            End Try
        End Function
        Public Function MrpPurchaseRecord_Check(ByVal AutoID As String, ByVal MrpPurchaseID As String, ByVal CheckBit As Boolean, ByVal CheckRemark As String, ByVal MPP_CheckUserID As String, ByVal MPP_CheckDate As Date) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_Check")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, MrpPurchaseID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, CheckRemark)
                db.AddInParameter(dbComm, "@MPP_CheckUserID", DbType.String, MPP_CheckUserID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecord_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecord_Check = False
            End Try
        End Function
        Public Function MrpPurchaseRecord_Add(ByVal objInfo As MrpPurchaseRecordInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_Add")
                db.AddInParameter(dbComm, "@MPP_CreateUserID", DbType.String, objInfo.MPP_CreateUserID)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, objInfo.MrpPurchaseID)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecord_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecord_Add = False
            End Try
        End Function

        Public Function MrpPurchaseRecord_GetMrpID() As DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_GetMrpID")
            Dim ds As New DataSet
            ds = db.ExecuteDataSet(dbComm)
            Return ds
        End Function


        Public Function MrpPurchase_GetByM_codeAndMRP_ID(ByVal MRP_ID As String, ByVal M_code As String) As String
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchase_GetByM_code-MRP_ID")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@M_code", DbType.String, M_code)

                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        Return reader("MP_MRPQty").ToString
                    End While
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function Mrp_GetDependReqWeek(ByVal MRP_ID As String) As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_GetDependReqWeek")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                Dim dt As New DataTable
                dt = db.ExecuteDataSet(dbComm).Tables(0)

                Return dt
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function
    End Class


End Namespace
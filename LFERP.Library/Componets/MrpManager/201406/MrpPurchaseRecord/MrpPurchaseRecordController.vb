Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpPurchaseRecord
    Public Class MrpPurchaseRecordController
        Friend Function FillMrpPurchaseRecord(ByVal reader As IDataReader) As MrpPurchaseRecordInfo
            On Error Resume Next
            Dim objInfo As New MrpPurchaseRecordInfo
            objInfo.MRP_ID = reader("MRP_ID")
            objInfo.MrpPurchaseID = reader("MrpPurchaseID")
            objInfo.AutoID = reader("AutoID")
            objInfo.CheckBit = reader("CheckBit")
            objInfo.MPP_CreateDate = IIf(IsDBNull(reader("MPP_CreateDate")), Nothing, reader("MPP_CreateDate"))
            objInfo.MPP_CreateUserID = reader("MPP_CreateUserID")
            objInfo.MPP_ModifyDate = IIf(IsDBNull(reader("MPP_ModifyDate")), Nothing, reader("MPP_ModifyDate"))
            objInfo.MPP_ModifyUserID = reader("MPP_ModifyUserID")
            objInfo.MPP_CreateUserName = reader("MPP_CreateUserName")
            objInfo.MPP_ModifyUserName = reader("MPP_ModifyUserName")
            objInfo.MPP_CheckUserName = reader("MPP_CheckUserName")
            objInfo.MPP_CheckDate = reader("MPP_CheckDate")
            objInfo.MPP_CheckUserID = reader("MPP_CheckUserID")
            objInfo.CheckRemark = reader("CheckRemark")
            objInfo.IsPurchase = reader("IsPurchase")
            objInfo.MPP_Remark = reader("MPP_Remark")

            If reader("PurchaseDate") Is DBNull.Value Then
                objInfo.PurchaseDate = Nothing
            Else
                objInfo.PurchaseDate = reader("PurchaseDate")
            End If
            objInfo.PurchaseUserID = reader("PurchaseUserID")
            objInfo.IsUrgent = reader("IsUrgent")
            objInfo.PurchaseDepartment = reader("PurchaseDepartment")
            objInfo.PurchaseUserName = reader("PurchaseUserName")
            objInfo.PurchaseDepartName = reader("PurchaseDepartName")
            objInfo.WareHouseID = reader("WareHouseID")
            objInfo.WareHouseName = reader("WareHouseName")
            Return objInfo
        End Function

        Public Function MrpPurchaseRecord_GetList(ByVal MrpPurchaseID As String, ByVal Mrp_ID As String, ByVal MPP_CreateUserID As String, ByVal MPP_CreateDate As Date, ByVal MPP_Remark As String, ByVal MPP_ModifyUserID As String, ByVal AutoID As Integer, ByVal CheckBit As String, ByVal CheckRemark As String, ByVal PurchaseUserID As String, ByVal IsUrgent As String, ByVal PurchaseDepartment As String, ByVal BeginDate As Date, ByVal EndDate As Date, ByVal IsPurchase As String, ByVal DisplayNum As Decimal) As List(Of MrpPurchaseRecordInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_GetList")
            If MrpPurchaseID <> Nothing Then
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, MrpPurchaseID)
            End If
            If Mrp_ID <> Nothing Then
                db.AddInParameter(dbComm, "@Mrp_ID", DbType.String, Mrp_ID)
            End If
            If MPP_CreateUserID <> Nothing Then
                db.AddInParameter(dbComm, "@MPP_CreateUserID", DbType.String, MPP_CreateUserID)
            End If
            If MPP_CreateDate <> Nothing Then
                db.AddInParameter(dbComm, "@MPP_CreateDate", DbType.Date, MPP_CreateDate)
            End If
            If MPP_Remark <> Nothing Then
                db.AddInParameter(dbComm, "@MPP_Remark", DbType.String, MPP_Remark)
            End If
            If MPP_ModifyUserID <> Nothing Then
                db.AddInParameter(dbComm, "@MPP_ModifyUserID", DbType.String, MPP_ModifyUserID)
            End If
            db.AddInParameter(dbComm, "@MPP_ModifyUserID", DbType.String, MPP_ModifyUserID)
            If AutoID <> Nothing Then
                db.AddInParameter(dbComm, "@AutoID", DbType.Int64, AutoID)
            End If
            If CheckBit <> Nothing Then
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
            End If
            If CheckRemark <> Nothing Then
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, CheckRemark)
            End If
            If PurchaseUserID <> Nothing Then
                db.AddInParameter(dbComm, "@PurchaseUserID", DbType.String, PurchaseUserID)
            End If
            If IsUrgent <> Nothing Then
                db.AddInParameter(dbComm, "@IsUrgent ", DbType.Boolean, IsUrgent)
            End If
            If PurchaseDepartment <> Nothing Then
                db.AddInParameter(dbComm, "@PurchaseDepartment", DbType.String, PurchaseDepartment)
            End If
            If BeginDate <> Nothing Then
                db.AddInParameter(dbComm, "@BeginDate", DbType.DateTime, BeginDate)
            End If
            If EndDate <> Nothing Then
                db.AddInParameter(dbComm, "@EndDate", DbType.DateTime, EndDate)
            End If
            If IsPurchase <> Nothing Then
                db.AddInParameter(dbComm, "@IsPurchase", DbType.Boolean, IsPurchase)
            End If
            db.AddInParameter(dbComm, "@DisplayNum ", DbType.Decimal, DisplayNum)
            Dim FeatureList As New List(Of MrpPurchaseRecordInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpPurchaseRecord(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpPurchaseRecord_PreDelete(ByVal PR As String) As Boolean
            Dim list As New List(Of String)
            list.Add("select PO from MrpPurchaseOrder where PR='" + PR + "'")
            list.Add("的采購單中存在該請購單號(" + PR + ")，無法刪除")

            Return MRP_PreDelete(list)
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
                db.AddInParameter(dbComm, "@IsPurchase", DbType.Boolean, objinfo.IsPurchase)
                db.AddInParameter(dbComm, "@MPP_Remark", DbType.String, objinfo.MPP_Remark)
                db.AddInParameter(dbComm, "@PurchaseUserID", DbType.String, objinfo.PurchaseUserID)
                If objinfo.IsUrgent = Nothing Then
                    db.AddInParameter(dbComm, "@IsUrgent ", DbType.Boolean, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@IsUrgent ", DbType.Boolean, objinfo.IsUrgent)
                End If
                db.AddInParameter(dbComm, "@PurchaseDepartment", DbType.String, objinfo.PurchaseDepartment)
                db.AddInParameter(dbComm, "@WareHouseID", DbType.String, objinfo.WareHouseID)
                If objinfo.PurchaseDate = Nothing Then
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.Date, Nothing)
                Else
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.Date, objinfo.PurchaseDate)
                End If
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecord_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecord_Update = False
            End Try
        End Function

        Public Function MrpPurchaseRecord_UpdateUrgent(ByVal PR As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetSqlStringCommand("update MrpPurchaseRecord set IsPurchase=1 where MrpPurchaseID='" + PR + "'")
                db.ExecuteNonQuery(dbComm)
                Return True
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function

        Public Function MrpPurchaseRecord_Check(ByVal objinfo As MrpPurchaseRecordInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_Check")
                db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, objinfo.MrpPurchaseID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.AddInParameter(dbComm, "@MPP_CheckUserID", DbType.String, objinfo.MPP_CheckUserID)
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
                db.AddInParameter(dbComm, "@MPP_Remark", DbType.String, objInfo.MPP_Remark)
                db.AddInParameter(dbComm, "@PurchaseUserID", DbType.String, objInfo.PurchaseUserID)
                If objInfo.IsUrgent = Nothing Then
                    db.AddInParameter(dbComm, "@IsUrgent ", DbType.Boolean, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@IsUrgent ", DbType.Boolean, objInfo.IsUrgent)
                End If
                db.AddInParameter(dbComm, "@PurchaseDepartment", DbType.String, objInfo.PurchaseDepartment)
                db.AddInParameter(dbComm, "@WareHouseID", DbType.String, objInfo.WareHouseID)
                If objInfo.PurchaseDate = Nothing Then
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.Date, Nothing)
                Else
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.Date, objInfo.PurchaseDate)
                End If
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseRecord_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseRecord_Add = False
            End Try
        End Function

        Public Function MrpPurchaseRecord_GetMrpID() As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_GetMrpID")
                Dim dt As New DataTable
                dt = db.ExecuteDataSet(dbComm).Tables(0)
                Return dt
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
           
        End Function

        Public Function MrpPurchaseRecord_GetNewMrpID() As String
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_GetNewMrpPurchID")
                Dim Str As String = String.Empty
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        Str = reader("newMrpPurchaseID").ToString
                    End While
                End Using
                Return Str
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function MrpPurchase_GetByM_codeAndMRP_ID(ByVal MRP_ID As String, ByVal M_code As String) As String
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchase_GetByM_code-MRP_ID")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@M_code", DbType.String, M_code)
                Dim Qty As Decimal
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        Qty = CDec(reader("MP_MRPQty").ToString)
                    End While
                End Using
                Return Qty
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

        Public Function MrpPurchaseRecord_GetPRList() As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetSqlStringCommand("select MrpPurchaseID  from MrpPurchaseRecord ")
            Return db.ExecuteDataSet(dbComm).Tables(0)
        End Function

        Public Function MrpPurchaseRecord_GetAllTable(ByVal MrpPurchaseID As String) As DataTable
            Dim ds As New DataSet
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseRecord_GetAllTable")
            db.AddInParameter(dbComm, "@MrpPurchaseID", DbType.String, MrpPurchaseID)
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace
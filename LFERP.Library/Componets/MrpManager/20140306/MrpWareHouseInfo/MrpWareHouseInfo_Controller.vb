Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpWareHouseInfo
    Public Class MrpWareHouseInfoController
        Friend Function FillMrpWareHouseInfo(ByVal reader As IDataReader) As MrpWareHouseInfoInfo
            Dim objInfo As New MrpWareHouseInfoInfo
            objInfo.Ware_ID = reader("Ware_ID").ToString
            objInfo.MRP_ID = reader("MRP_ID").ToString
            If reader("MD_ISMrp") Is DBNull.Value Then
                objInfo.MD_ISMrp = Nothing
            Else
                objInfo.MD_ISMrp = reader("MD_ISMrp")
            End If
            If reader("MD_RecordCreateDate") Is DBNull.Value Then
                objInfo.MD_RecordCreateDate = Nothing
            Else
                objInfo.MD_RecordCreateDate = Format(CDate(reader("MD_RecordCreateDate")), "yyyy/MM/dd")
            End If
            If reader("CheckUserID") Is DBNull.Value Then
                objInfo.CheckUserID = Nothing
            Else
                objInfo.CheckUserID = CStr(reader("CheckUserID").ToString)
            End If
            If reader("CheckUserName") Is DBNull.Value Then
                objInfo.CheckUserName = Nothing
            Else
                objInfo.CheckUserName = CStr(reader("CheckUserName").ToString)
            End If
            If reader("CheckBit") Is DBNull.Value Then
                objInfo.CheckBit = Nothing
            Else
                objInfo.CheckBit = reader("CheckBit")
            End If
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.CreateUserID = reader("CreateUserName").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserName").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            objInfo.AutoID = reader("AutoID").ToString
            Return objInfo
        End Function

        'Friend Function FillMRPID(ByVal reader As IDataReader) As MrpWareHouseInfoInfo
        '    Dim objInfo As New MrpWareHouseInfoInfo
        '    objInfo.MRP_ID = reader("MRP_ID").ToString
        '    Return objInfo
        'End Function

        Public Function MrpWareHouseInfo_GetList(ByVal Ware_ID As String, ByVal CheckBit As String, ByVal CreateUserID As String, ByVal CreateDate As DateTime) As List(Of MrpWareHouseInfoInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfo_GetList")
            db.AddInParameter(dbComm, "@Ware_ID", DbType.String, Ware_ID)
            db.AddInParameter(dbComm, "@CheckBit", DbType.String, CheckBit)
            db.AddInParameter(dbComm, "@CreateUserID", DbType.String, CreateUserID)
            If CreateDate = Nothing Then
                db.AddInParameter(dbComm, "@CreateDate", DbType.DateTime, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@CreateDate", DbType.DateTime, CreateDate)
            End If

            Dim FeatureList As New List(Of MrpWareHouseInfoInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpWareHouseInfo(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function MrpWareHouseInfo_Delete(ByVal AutoID As Double) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfo_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)

                db.ExecuteNonQuery(dbComm)
                MrpWareHouseInfo_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpWareHouseInfo_Delete = False
            End Try
        End Function


        Public Function MrpWareHouseInfo_Update(ByVal objinfo As MrpWareHouseInfoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfo_Update")
                db.AddInParameter(dbComm, "@Ware_ID", DbType.String, objinfo.Ware_ID)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@MD_ISMrp", DbType.Boolean, objinfo.MD_ISMrp)
                If objinfo.MD_RecordCreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@MD_RecordCreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MD_RecordCreateDate", DbType.Date, objinfo.MD_RecordCreateDate)
                End If
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                If objinfo.ModifyDate = Nothing Then
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                End If
                db.ExecuteNonQuery(dbComm)
                MrpWareHouseInfo_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpWareHouseInfo_Update = False
            End Try
        End Function
        ''' <summary>
        ''' 更新
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpWareHouseInfo_UpdateCheck(ByVal objinfo As MrpWareHouseInfoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfo_UpdateCheck")
                db.AddInParameter(dbComm, "@Ware_ID", DbType.String, objinfo.Ware_ID)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.ExecuteNonQuery(dbComm)
                MrpWareHouseInfo_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpWareHouseInfo_UpdateCheck = False
            End Try
        End Function
        ''' <summary>
        ''' 添加
        ''' </summary>
        ''' <param name="objInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpWareHouseInfo_Insert(ByVal objInfo As MrpWareHouseInfoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfo_Insert")
                db.AddInParameter(dbComm, "@Ware_ID", DbType.String, objInfo.Ware_ID)
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@MD_ISMrp", DbType.Boolean, objInfo.MD_ISMrp)
                If objInfo.MD_RecordCreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@MD_RecordCreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MD_RecordCreateDate", DbType.Date, objInfo.MD_RecordCreateDate)
                End If
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objInfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objInfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objInfo.CheckRemark)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                If objInfo.CreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                End If
                db.ExecuteNonQuery(dbComm)
                MrpWareHouseInfo_Insert = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpWareHouseInfo_Insert = False
            End Try
        End Function
        ''' <summary>
        ''' 獲得WareID--流水號
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpWareHouseInfo_GetWareID(ByVal WIyymm As String) As String
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpWareHouseInfo_GetWareID")
            Dim WareID As String = ""
            db.AddInParameter(dbComm, "@yymm", DbType.String, WIyymm)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    WareID = IIf(IsDBNull(reader("Ware_ID")), String.Empty, reader("Ware_ID").ToString)
                End While
                Return WareID
            End Using
        End Function


#Region "MRP運算模塊使用"
        Public Function MrpWareHouseInfo_DeleteByMRPID(ByVal MRPID As String) As Boolean
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetSqlStringCommand("delete from MrpWareHouseInfo where MRP_ID='" + MRPID + "'")
            db.ExecuteNonQuery(dbComm)
            MrpWareHouseInfo_DeleteByMRPID = True
        End Function

        Public Function MrpWareHouseInfo_MRPIDExists(ByVal MRPID As String) As String
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetSqlStringCommand("select Ware_ID from MrpWareHouseInfo where MRP_ID='" + MRPID + "'")
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                If reader.Read() Then
                    Return reader(0).ToString
                End If
                Return Nothing
            End Using
        End Function

        Public Function MrpWareHouseInfo_WareIDExists(ByVal WareID As String) As Boolean
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetSqlStringCommand("select count(*) from MrpWareHouseInfo where Ware_ID='" + WareID + "'")
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                reader.Read()
                Return CInt(reader(0)) > 0
            End Using
        End Function

        Public Function MrpWareHouseInfo_updateMRPID(ByVal BeforeMrpID As String, ByVal MrpID As String) As Boolean
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetSqlStringCommand("update MrpWareHouseInfo set MRP_ID='" + MrpID + "' where MRP_ID='" + BeforeMrpID + "'")
            db.ExecuteNonQuery(dbComm)
            MrpWareHouseInfo_updateMRPID = True
        End Function
#End Region

    End Class
End Namespace
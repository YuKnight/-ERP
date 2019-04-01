Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_InfoController
        Friend Function FillMrpInfo(ByVal reader As IDataReader) As Mrp_InfoInfo
            On Error Resume Next
            Dim objInfo As New Mrp_InfoInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString
            objInfo.FNeedBeginDate = reader("FNeedBeginDate")
            objInfo.FNeedEndDate = reader("FNeedEndDate")
            objInfo.FType = reader("FType").ToString
            objInfo.FWayBeginDate = reader("FWayBeginDate")
            objInfo.SchemeID = reader("SchemeID").ToString
            objInfo.FLogTxt = reader("FLogTxt").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate")
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.AutoID = reader("AutoID")
            Return objInfo
        End Function

        Public Function Mrp_Info_GetList(ByVal MRP_ID As String) As List(Of Mrp_InfoInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfo_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)

                Dim FeatureList As New List(Of Mrp_InfoInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpInfo(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_WorkCalendar(ByVal DeptID As String, ByVal ORI_DATE As Date, ByVal FixLeadTime As Integer) As Date
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_WorkCalendar")
                db.AddInParameter(dbComm, "@DeptID", DbType.String, DeptID)
                db.AddInParameter(dbComm, "@ORI_DATE", DbType.Date, ORI_DATE)
                db.AddInParameter(dbComm, "@FixLeadTime", DbType.Int32, FixLeadTime)

                Dim WorkDate As Date
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    WorkDate = reader("NewDate")
                    Return WorkDate
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Bom_LowLevelCode() As Integer
            Dim MaxLayerCount As Integer = 0
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_LowLevelCode")

                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        MaxLayerCount = reader("MaxLayerCount")
                        Return MaxLayerCount
                    End While
                End Using
            Catch ex As Exception
                Return 0
            End Try
        End Function

        Public Function MrpInfo_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfo_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                MrpInfo_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                MrpInfo_Delete = False
            End Try
        End Function

        Public Function Mrp_Info_Update(ByVal objinfo As Mrp_InfoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_Info_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@FNeedBeginDate", DbType.Date, objinfo.FNeedBeginDate)
                db.AddInParameter(dbComm, "@FNeedEndDate", DbType.Date, objinfo.FNeedEndDate)
                db.AddInParameter(dbComm, "@FType", DbType.String, objinfo.FType)
                db.AddInParameter(dbComm, "@FWayBeginDate", DbType.Date, objinfo.FWayBeginDate)
                db.AddInParameter(dbComm, "@SchemeID ", DbType.String, objinfo.SchemeID)
                db.AddInParameter(dbComm, "@FLogTxt", DbType.String, objinfo.FLogTxt)
                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)
                db.ExecuteNonQuery(dbComm)
                Mrp_Info_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_Info_Update = False
            End Try
        End Function

        Public Function Mrp_Info_Add(ByVal objInfo As Mrp_InfoInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_Info_Add")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@FNeedBeginDate", DbType.Date, objInfo.FNeedBeginDate)
                db.AddInParameter(dbComm, "@FNeedEndDate", DbType.Date, objInfo.FNeedEndDate)
                db.AddInParameter(dbComm, "@FType", DbType.String, objInfo.FType)
                db.AddInParameter(dbComm, "@FWayBeginDate", DbType.Date, objInfo.FWayBeginDate)
                db.AddInParameter(dbComm, "@SchemeID ", DbType.String, objInfo.SchemeID)
                db.AddInParameter(dbComm, "@FLogTxt", DbType.String, objInfo.FLogTxt)
                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate ", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_Info_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_Info_Add = False
            End Try
        End Function

        Public Function Mrp_Info_GetID() As String
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MRP_Info_GetID")
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        Return reader("MRP_ID").ToString
                    Else
                        Return Nothing
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

    End Class
End Namespace
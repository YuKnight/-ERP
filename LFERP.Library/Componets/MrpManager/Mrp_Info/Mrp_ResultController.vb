Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_ResultController
        Friend Function Mrp_Resultfill(ByVal reader As IDataReader) As Mrp_ResultInfo
            On Error Resume Next
            Dim objInfo As New Mrp_ResultInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString

            objInfo.FPlanOrderNo = reader("FPlanOrderNo").ToString
            objInfo.FSourceID = reader("FSourceID").ToString
            objInfo.FPlanBeginDate = reader("FPlanBeginDate")
            objInfo.FPlanEndDate = reader("FPlanEndDate")
            objInfo.FNeedDate = reader("FNeedDate")
            objInfo.FItemType = reader("FItemType").ToString
            objInfo.FAuxNeedQty = reader("FAuxNeedQty")
            objInfo.FAuxPlanQty = reader("FAuxPlanQty")
            objInfo.FTranType = reader("FTranType").ToString
            objInfo.FMrpDate = reader("FMrpDate")
            objInfo.FStatus = reader("FStatus").ToString
            objInfo.FMrpClosed = reader("FMrpClosed").ToString
            objInfo.FType = reader("FType").ToString

            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.SoureType = reader("SoureType").ToString

            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate")
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.AutoID = reader("AutoID")

            Return objInfo
        End Function


        Public Function Mrp_ResultMain_GetList(ByVal WH_ID As String, ByVal PM_M_Code As String, ByVal BitType As Boolean) As List(Of Mrp_ResultInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_ResultMain_GetList")
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_ResultInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_Resultfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function


        Public Function Mrp_Result_GetList(ByVal MRP_ID As String, ByVal FPlanOrderNo As String) As List(Of Mrp_ResultInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_Result_GetList")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@FPlanOrderNo", DbType.String, FPlanOrderNo)

                Dim FeatureList As New List(Of Mrp_ResultInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_Resultfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_Result_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_Result_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                Mrp_Result_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Mrp_Result_Delete = False
            End Try
        End Function

        Public Function Mrp_Result_Update(ByVal objinfo As Mrp_ResultInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_Result_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)

                db.AddInParameter(dbComm, "@FPlanOrderNo", DbType.String, objinfo.FPlanOrderNo)
                db.AddInParameter(dbComm, "@FSourceID", DbType.String, objinfo.FSourceID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@FPlanBeginDate", DbType.Date, objinfo.FPlanBeginDate)
                db.AddInParameter(dbComm, "@FPlanEndDate", DbType.Date, objinfo.FPlanEndDate)
                db.AddInParameter(dbComm, "@FNeedDate", DbType.Date, objinfo.FNeedDate)
                db.AddInParameter(dbComm, "@FItemType ", DbType.String, objinfo.FItemType)
                db.AddInParameter(dbComm, "@FAuxNeedQty", DbType.Decimal, objinfo.FAuxNeedQty)
                db.AddInParameter(dbComm, "@FAuxPlanQty", DbType.Decimal, objinfo.FAuxPlanQty)
                db.AddInParameter(dbComm, "@FTranType", DbType.String, objinfo.FTranType)
                db.AddInParameter(dbComm, "@FMrpDate", DbType.Date, objinfo.FMrpDate)
                db.AddInParameter(dbComm, "@FStatus", DbType.String, objinfo.FStatus)
                db.AddInParameter(dbComm, "@FMrpClosed", DbType.String, objinfo.FMrpClosed)
                db.AddInParameter(dbComm, "@FType", DbType.String, objinfo.FType)

                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_Result_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_Result_Update = False
            End Try
        End Function

        Public Function Mrp_Result_UpdateStatus(ByVal FPlanOrderNo As String, ByVal FStatus As String, ByVal FMrpClosed As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_Result_UpdateStatus")

                db.AddInParameter(dbComm, "@FPlanOrderNo", DbType.String, FPlanOrderNo)
                db.AddInParameter(dbComm, "@FStatus", DbType.String, FStatus)
                db.AddInParameter(dbComm, "@FMrpClosed", DbType.String, FMrpClosed)

                db.ExecuteNonQuery(dbComm)
                Mrp_Result_UpdateStatus = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_Result_UpdateStatus = False
            End Try
        End Function

        Public Function Mrp_Result_GetID() As String
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_Result_GetID")
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        Return reader("FPlanOrderNo").ToString
                    Else
                        Return Nothing
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpInfo_GetID方法出錯")
                Return Nothing
            End Try
        End Function

        Public Function Mrp_Result_Add(ByVal objInfo As Mrp_ResultInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_Result_Add")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)

                db.AddInParameter(dbComm, "@FPlanOrderNo", DbType.String, objInfo.FPlanOrderNo)
                db.AddInParameter(dbComm, "@FSourceID", DbType.String, objInfo.FSourceID)

                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@FPlanBeginDate", DbType.Date, objInfo.FPlanBeginDate)
                db.AddInParameter(dbComm, "@FPlanEndDate", DbType.Date, objInfo.FPlanEndDate)
                db.AddInParameter(dbComm, "@FNeedDate", DbType.Date, objInfo.FNeedDate)
                db.AddInParameter(dbComm, "@FItemType ", DbType.String, objInfo.FItemType)
                db.AddInParameter(dbComm, "@FAuxNeedQty", DbType.Decimal, objInfo.FAuxNeedQty)
                db.AddInParameter(dbComm, "@FAuxPlanQty", DbType.Decimal, objInfo.FAuxPlanQty)
                db.AddInParameter(dbComm, "@FTranType", DbType.String, objInfo.FTranType)
                db.AddInParameter(dbComm, "@FMrpDate", DbType.Date, objInfo.FMrpDate)
                db.AddInParameter(dbComm, "@FStatus", DbType.String, objInfo.FStatus)
                db.AddInParameter(dbComm, "@FMrpClosed", DbType.String, objInfo.FMrpClosed)
                db.AddInParameter(dbComm, "@FType", DbType.String, objInfo.FType)

                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate ", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_Result_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_Result_Add = False
            End Try
        End Function
    End Class

End Namespace
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_InfoMainController

        Friend Function FillMrp_InfoMain(ByVal reader As IDataReader) As Mrp_InfoMainInfo
            On Error Resume Next
            Dim objInfo As New Mrp_InfoMainInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString

            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString

            objInfo.FixLeadTime = reader("FixLeadTime")
            objInfo.SafetyTime = reader("SafetyTime")
            objInfo.SafetyStock = reader("SafetyStock")
            objInfo.FixedQty = reader("FixedQty")
            objInfo.MinOrderQty = reader("MinOrderQty")
            objInfo.MaxOrderQty = reader("MaxOrderQty")
            objInfo.SoureType = reader("SoureType")
            objInfo.SoureTypeName = reader("SoureTypeName").ToString()
            objInfo.M_LowestBomCode = reader("M_LowestBomCode")
            objInfo.OrderStrategy = reader("OrderStrategy")
            objInfo.OrderStrategyName = reader("OrderStrategyName").ToString()
            objInfo.DemandType = reader("DemandType").ToString

            objInfo.ReOrderPoint = reader("ReOrderPoint")
            objInfo.OrderInterval = reader("OrderInterval")
            objInfo.IncreasBatch = reader("IncreasBatch")

            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate")
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.AutoID = reader("AutoID")

            Return objInfo
        End Function

        Public Function Mrp_InfoMain_GetList(ByVal MRP_ID As String) As List(Of Mrp_InfoMainInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InfoMain_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)

                Dim FeatureList As New List(Of Mrp_InfoMainInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrp_InfoMain(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_InfoMaterialCode_GetList(ByVal M_Code As String) As List(Of Mrp_InfoMainInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InfoMaterialCode_GetList")
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

                Dim FeatureList As New List(Of Mrp_InfoMainInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrp_InfoMain(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function


        Public Function MrpInfoMain_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfoMain_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                MrpInfoMain_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                MrpInfoMain_Delete = False
            End Try
        End Function

        Public Function Mrp_InfoMain_Update(ByVal objinfo As Mrp_InfoMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InfoMain_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)

                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@FixLeadTime", DbType.Int32, objinfo.FixLeadTime)
                db.AddInParameter(dbComm, "@SafetyTime", DbType.Int32, objinfo.SafetyTime)

                db.AddInParameter(dbComm, "@SafetyStock", DbType.Decimal, objinfo.SafetyStock)
                db.AddInParameter(dbComm, "@FixedQty", DbType.Decimal, objinfo.FixedQty)
                db.AddInParameter(dbComm, "@MinOrderQty", DbType.Decimal, objinfo.MinOrderQty)
                db.AddInParameter(dbComm, "@MaxOrderQty ", DbType.Decimal, objinfo.MaxOrderQty)
                db.AddInParameter(dbComm, "@SoureType", DbType.Decimal, objinfo.SoureType)
                db.AddInParameter(dbComm, "@M_LowestBomCode", DbType.Int32, objinfo.M_LowestBomCode)
                db.AddInParameter(dbComm, "@DemandType", DbType.String, objinfo.DemandType)

                db.AddInParameter(dbComm, "@ReOrderPoint", DbType.Int32, objinfo.ReOrderPoint)
                db.AddInParameter(dbComm, "@OrderInterval", DbType.Int32, objinfo.OrderInterval)
                db.AddInParameter(dbComm, "@IncreasBatch", DbType.Int32, objinfo.IncreasBatch)

                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_InfoMain_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_InfoMain_Update = False
            End Try
        End Function

        Public Function Mrp_InfoMain_Add(ByVal objInfo As Mrp_InfoMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InfoMain_Add")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)

                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@FixLeadTime", DbType.Int32, objInfo.FixLeadTime)
                db.AddInParameter(dbComm, "@SafetyTime", DbType.Int32, objInfo.SafetyTime)

                db.AddInParameter(dbComm, "@SafetyStock", DbType.Decimal, objInfo.SafetyStock)
                db.AddInParameter(dbComm, "@FixedQty", DbType.Decimal, objInfo.FixedQty)
                db.AddInParameter(dbComm, "@MinOrderQty", DbType.Decimal, objInfo.MinOrderQty)
                db.AddInParameter(dbComm, "@MaxOrderQty ", DbType.Decimal, objInfo.MaxOrderQty)
                db.AddInParameter(dbComm, "@SoureType", DbType.Decimal, objInfo.SoureType)
                db.AddInParameter(dbComm, "@M_LowestBomCode", DbType.Int32, objInfo.M_LowestBomCode)
                db.AddInParameter(dbComm, "@DemandType", DbType.String, objInfo.DemandType)

                db.AddInParameter(dbComm, "@ReOrderPoint", DbType.Int32, objInfo.ReOrderPoint)
                db.AddInParameter(dbComm, "@OrderInterval", DbType.Int32, objInfo.OrderInterval)
                db.AddInParameter(dbComm, "@IncreasBatch", DbType.Int32, objInfo.IncreasBatch)

                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate ", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_InfoMain_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_InfoMain_Add = False
            End Try
        End Function
    End Class
End Namespace
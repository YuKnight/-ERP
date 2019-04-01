Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_InfoSubController
        Friend Function FillMrpInfoSub(ByVal reader As IDataReader) As Mrp_InfoSubInfo
            On Error Resume Next
            Dim objInfo As New Mrp_InfoSubInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString

            objInfo.YearCount = reader("YearCount")
            objInfo.WeekCount = reader("WeekCount")
            objInfo.Week = reader("Week")
            objInfo.WeekEndDate = reader("WeekEndDate")
            objInfo.WeekStratDate = reader("WeekStratDate")

            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString

            objInfo.MrpDate = reader("MrpDate")
            objInfo.DemandQty = reader("DemandQty")
            objInfo.DependentQty = reader("DependentQty")
            objInfo.GrossDemandQty = reader("GrossDemandQty")

            objInfo.StockQty = reader("StockQty")
            objInfo.AssignQty = reader("AssignQty")
            objInfo.PurchaseQty = reader("PurchaseQty")
            objInfo.InWayQty = reader("InWayQty")
            objInfo.TempQty = reader("TempQty")
            objInfo.PlanProduceQty = reader("PlanProduceQty")
            objInfo.NetDemandQty = reader("NetDemandQty")
            objInfo.PlanReceiveQty = reader("PlanReceiveQty")
            objInfo.PlanIssueQty = reader("PlanIssueQty")
            objInfo.ForecastAvailableQty = reader("ForecastAvailableQty")

            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate")
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.AutoID = reader("AutoID")

            Return objInfo
        End Function

        Public Function Mrp_InfoSub_GetList(ByVal MRP_ID As String, ByVal PM_M_Code As String) As List(Of Mrp_InfoSubInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InfoSub_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

                Dim FeatureList As New List(Of Mrp_InfoSubInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillMrpInfoSub(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Function MrpInfoSub_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpInfoSub_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                MrpInfoSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                MrpInfoSub_Delete = False
            End Try
        End Function

        Public Function Mrp_InfoSub_Update(ByVal objinfo As Mrp_InfoSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InfoSub_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)

                db.AddInParameter(dbComm, "@YearCount", DbType.Int32, objinfo.YearCount)
                db.AddInParameter(dbComm, "@WeekCount", DbType.Int32, objinfo.WeekCount)
                db.AddInParameter(dbComm, "@Week", DbType.Int32, objinfo.Week)
                db.AddInParameter(dbComm, "@WeekStratDate", DbType.Date, objinfo.WeekStratDate)
                db.AddInParameter(dbComm, "@WeekEndDate", DbType.Date, objinfo.WeekEndDate)

                db.AddInParameter(dbComm, "@MrpDate", DbType.Date, objinfo.MrpDate)
                db.AddInParameter(dbComm, "@DemandQty", DbType.Decimal, objinfo.DemandQty)

                db.AddInParameter(dbComm, "@DependentQty", DbType.Decimal, objinfo.DependentQty)
                db.AddInParameter(dbComm, "@GrossDemandQty", DbType.Decimal, objinfo.GrossDemandQty)

                db.AddInParameter(dbComm, "@StockQty", DbType.Decimal, objinfo.StockQty)
                db.AddInParameter(dbComm, "@AssignQty", DbType.Decimal, objinfo.AssignQty)
                db.AddInParameter(dbComm, "@PurchaseQty", DbType.Decimal, objinfo.PurchaseQty)
                db.AddInParameter(dbComm, "@InWayQty", DbType.Decimal, objinfo.InWayQty)
                db.AddInParameter(dbComm, "@TempQty", DbType.Decimal, objinfo.TempQty)
                db.AddInParameter(dbComm, "@PlanProduceQty", DbType.Decimal, objinfo.PlanProduceQty)
                db.AddInParameter(dbComm, "@NetDemandQty", DbType.Decimal, objinfo.NetDemandQty)
                db.AddInParameter(dbComm, "@PlanReceiveQty", DbType.Decimal, objinfo.PlanReceiveQty)
                db.AddInParameter(dbComm, "@PlanIssueQty", DbType.Decimal, objinfo.PlanIssueQty)
                db.AddInParameter(dbComm, "@ForecastAvailableQty", DbType.Decimal, objinfo.ForecastAvailableQty)

                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)
                db.ExecuteNonQuery(dbComm)
                Mrp_InfoSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_InfoSub_Update = False
            End Try
        End Function

        Public Function Mrp_InfoSub_Add(ByVal objInfo As Mrp_InfoSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InfoSub_Add")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objInfo.PM_M_Code)

                db.AddInParameter(dbComm, "@YearCount ", DbType.Int32, objInfo.YearCount)
                db.AddInParameter(dbComm, "@WeekCount ", DbType.Int32, objInfo.WeekCount)
                db.AddInParameter(dbComm, "@Week", DbType.Int32, objInfo.Week)
                If objInfo.WeekStratDate = Nothing Then
                    db.AddInParameter(dbComm, "@WeekStratDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WeekStratDate", DbType.Date, objInfo.WeekStratDate)
                End If

                If objInfo.WeekEndDate = Nothing Then
                    db.AddInParameter(dbComm, "@WeekEndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WeekEndDate", DbType.Date, objInfo.WeekEndDate)
                End If


                If objInfo.MrpDate = Nothing Then
                    db.AddInParameter(dbComm, "@MrpDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MrpDate", DbType.Date, objInfo.MrpDate)
                End If

                db.AddInParameter(dbComm, "@DemandQty", DbType.Decimal, objInfo.DemandQty)
                db.AddInParameter(dbComm, "@DependentQty", DbType.Decimal, objInfo.DependentQty)
                db.AddInParameter(dbComm, "@GrossDemandQty", DbType.Decimal, objInfo.GrossDemandQty)
                db.AddInParameter(dbComm, "@StockQty", DbType.Decimal, objInfo.StockQty)
                db.AddInParameter(dbComm, "@AssignQty", DbType.Decimal, objInfo.AssignQty)
                db.AddInParameter(dbComm, "@PurchaseQty", DbType.Decimal, objInfo.PurchaseQty)
                db.AddInParameter(dbComm, "@InWayQty", DbType.Decimal, objInfo.InWayQty)
                db.AddInParameter(dbComm, "@TempQty", DbType.Decimal, objInfo.TempQty)
                db.AddInParameter(dbComm, "@PlanProduceQty", DbType.Decimal, objInfo.PlanProduceQty)
                db.AddInParameter(dbComm, "@NetDemandQty", DbType.Decimal, objInfo.NetDemandQty)
                db.AddInParameter(dbComm, "@PlanReceiveQty", DbType.Decimal, objInfo.PlanReceiveQty)
                db.AddInParameter(dbComm, "@PlanIssueQty", DbType.Decimal, objInfo.PlanIssueQty)
                db.AddInParameter(dbComm, "@ForecastAvailableQty", DbType.Decimal, objInfo.ForecastAvailableQty)

                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate ", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_InfoSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_InfoSub_Add = False
            End Try
        End Function
    End Class

End Namespace
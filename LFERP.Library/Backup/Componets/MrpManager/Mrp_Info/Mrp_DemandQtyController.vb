Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_DemandQtyController
        Friend Function Mrp_DemandQtyfill(ByVal reader As IDataReader) As Mrp_DemandQtyInfo
            On Error Resume Next
            Dim objInfo As New Mrp_DemandQtyInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString
            objInfo.BillsType = reader("BillsType").ToString
            objInfo.OM_ID = reader("OM_ID").ToString
            objInfo.Number = reader("Number").ToString
            objInfo.CusterID = reader("CusterID").ToString
            objInfo.CusterName = reader("CusterName").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Qty = reader("Qty")

            objInfo.OM_SendDate = reader("OM_SendDate")
            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate")
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.AutoID = reader("AutoID")
            Return objInfo
        End Function

        Public Function Mrp_DemandQty_GetList(ByVal MRP_ID As String, ByVal PM_M_Code As String, ByVal OM_SendDate As Date, ByVal BitType As Integer) As List(Of Mrp_DemandQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DemandQty_GetList")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

                If OM_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.Date, OM_SendDate)
                End If

                db.AddInParameter(dbComm, "@BitType", DbType.Int32, BitType)

                Dim FeatureList As New List(Of Mrp_DemandQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_DemandQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_DemandQtyMain_GetList(ByVal MRP_ID As String, ByVal StateDate As String, ByVal EndDate As String, ByVal PM_M_Code As String, ByVal BitType As Integer) As List(Of Mrp_DemandQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DemandQtyMain_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@StateDate", DbType.String, StateDate)
                db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@BitType", DbType.Int32, BitType)

                Dim FeatureList As New List(Of Mrp_DemandQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_DemandQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_DemandQty_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DemandQty_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                Mrp_DemandQty_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Mrp_DemandQty_Delete = False
            End Try
        End Function

        Public Function Mrp_DemandQty_Update(ByVal objinfo As Mrp_DemandQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DemandQty_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)

                db.AddInParameter(dbComm, "@BillsType", DbType.String, objinfo.BillsType)
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objinfo.OM_ID)
                db.AddInParameter(dbComm, "@Number", DbType.String, objinfo.Number)
                db.AddInParameter(dbComm, "@CusterID", DbType.String, objinfo.CusterID)
                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objinfo.Qty)

                db.AddInParameter(dbComm, "@OM_SendDate", DbType.Date, objinfo.OM_SendDate)

                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_DemandQty_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_DemandQty_Update = False
            End Try
        End Function

        Public Function Mrp_DemandQty_Add(ByVal objInfo As Mrp_DemandQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DemandQty_Add")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)

                db.AddInParameter(dbComm, "@BillsType", DbType.String, objInfo.BillsType)
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objInfo.OM_ID)
                db.AddInParameter(dbComm, "@Number", DbType.String, objInfo.Number)
                db.AddInParameter(dbComm, "@CusterID", DbType.String, objInfo.CusterID)
                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objInfo.PM_M_Code)

                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objInfo.Qty)
                If objInfo.OM_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.Date, objInfo.OM_SendDate)
                End If

                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate ", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_DemandQty_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_DemandQty_Add = False
            End Try
        End Function
    End Class
End Namespace
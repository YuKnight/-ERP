Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info

    Public Class Mrp_StockQtyController
        Friend Function Mrp_StockQtyfill(ByVal reader As IDataReader) As Mrp_StockQtyInfo

            On Error Resume Next
            Dim objInfo As New Mrp_StockQtyInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString
            objInfo.BillsType = reader("BillsType").ToString
            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.PS_NO = reader("PS_NO").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Qty = reader("Qty")
            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate")
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.AutoID = reader("AutoID")
            Return objInfo

        End Function


        Public Function Mrp_StockQtyMain_GetList(ByVal WH_ID As String, ByVal PM_M_Code As String, ByVal BitType As Boolean) As List(Of Mrp_StockQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_StockQtyMain_GetList")
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_StockQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_StockQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function


        Public Function Mrp_StockQty_GetList(ByVal MRP_ID As String, ByVal PM_M_Code As String, ByVal BitType As String) As List(Of Mrp_StockQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_StockQty_GetList")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_StockQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_StockQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_StockQty_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_StockQty_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                Mrp_StockQty_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Mrp_StockQty_Delete = False
            End Try
        End Function

        Public Function Mrp_StockQty_Update(ByVal objinfo As Mrp_StockQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_StockQty_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)

                db.AddInParameter(dbComm, "@BillsType", DbType.String, objinfo.BillsType)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objinfo.Qty)

                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_StockQty_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_StockQty_Update = False
            End Try
        End Function

        Public Function Mrp_StockQty_Add(ByVal objInfo As Mrp_StockQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_StockQty_Add")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)

                db.AddInParameter(dbComm, "@BillsType", DbType.String, objInfo.BillsType)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objInfo.WH_ID)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objInfo.PS_NO)
                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objInfo.Qty)

                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate ", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_StockQty_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_StockQty_Add = False
            End Try
        End Function

    End Class
End Namespace
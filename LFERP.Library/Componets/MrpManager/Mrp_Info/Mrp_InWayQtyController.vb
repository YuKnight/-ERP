Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_InWayQtyController
        Friend Function Mrp_InWayQtyfill(ByVal reader As IDataReader) As Mrp_InWayQtyInfo
            On Error Resume Next
            Dim objInfo As New Mrp_InWayQtyInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString
            objInfo.BillsType = reader("BillsType").ToString
            objInfo.SingleNo = reader("SingleNo").ToString
            objInfo.SupplierID = reader("SupplierID").ToString
            objInfo.Item = reader("Item").ToString

            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Qty = reader("Qty")

            objInfo.DeliveryDate = reader("DeliveryDate")
            objInfo.PurchaseDate = reader("PurchaseDate")

            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate")
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.AutoID = reader("AutoID")
            Return objInfo
        End Function

        Public Function Mrp_InWayQtyMain_GetList(ByVal StateDate As String, ByVal EndDate As String, ByVal PM_M_Code As String, ByVal BitType As String) As List(Of Mrp_InWayQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InWayQtyMain_GetList")
                db.AddInParameter(dbComm, "@StateDate", DbType.String, StateDate)
                db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_InWayQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_InWayQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_InWayQty_GetList(ByVal MRP_ID As String, ByVal PM_M_Code As String, ByVal DeliveryDate As Date, ByVal BitType As String) As List(Of Mrp_InWayQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InWayQty_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

                If DeliveryDate = Nothing Then
                    db.AddInParameter(dbComm, "@DeliveryDate ", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@DeliveryDate ", DbType.Date, DeliveryDate)
                End If

                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_InWayQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_InWayQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function


        Public Function Mrp_InWayQty_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InWayQty_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                Mrp_InWayQty_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Mrp_InWayQty_Delete = False
            End Try
        End Function

        Public Function Mrp_InWayQty_Update(ByVal objinfo As Mrp_InWayQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InWayQty_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@BillsType", DbType.String, objinfo.BillsType)
                db.AddInParameter(dbComm, "@SingleNo", DbType.String, objinfo.SingleNo)
                db.AddInParameter(dbComm, "@Item", DbType.String, objinfo.Item)
                db.AddInParameter(dbComm, "@SupplierID", DbType.String, objinfo.SupplierID)

                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objinfo.Qty)


                If objinfo.DeliveryDate = Nothing Then
                    db.AddInParameter(dbComm, "@DeliveryDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@DeliveryDate", DbType.Date, objinfo.DeliveryDate)
                End If
                If objinfo.PurchaseDate = Nothing Then
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.Date, objinfo.PurchaseDate)
                End If

                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_InWayQty_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_InWayQty_Update = False
            End Try
        End Function

        Public Function Mrp_InWayQty_Add(ByVal objInfo As Mrp_InWayQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_InWayQty_Add")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@BillsType", DbType.String, objInfo.BillsType)
                db.AddInParameter(dbComm, "@SingleNo", DbType.String, objInfo.SingleNo)
                db.AddInParameter(dbComm, "@Item", DbType.String, objInfo.Item)
                db.AddInParameter(dbComm, "@SupplierID", DbType.String, objInfo.SupplierID)

                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objInfo.Qty)

                If objInfo.DeliveryDate = Nothing Then
                    db.AddInParameter(dbComm, "@DeliveryDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@DeliveryDate", DbType.Date, objInfo.DeliveryDate)
                End If
                If objInfo.PurchaseDate = Nothing Then
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.Date, objInfo.PurchaseDate)
                End If

                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate ", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_InWayQty_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_InWayQty_Add = False
            End Try
        End Function
    End Class
End Namespace
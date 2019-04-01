Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpPurchaseOrder
    Public Class MrpPurchaseOrderController

        Friend Function FillMrpPurchaseOrder(ByVal reader As IDataReader) As MrpPurchaseOrderInfo
            Dim objInfo As New MrpPurchaseOrderInfo
            objInfo.PO = reader("PO").ToString
            objInfo.PR = reader("PR").ToString
            objInfo.DeptID = reader("DeptID").ToString
            objInfo.DeptName = reader("DeptName").ToString
            objInfo.CurrencyName = IIf(IsDBNull(reader("CurrencyName")), Nothing, reader("CurrencyName").ToString())
            objInfo.PaymentType = IIf(IsDBNull(reader("PaymentType")), Nothing, reader("PaymentType").ToString())
            If reader("PurchaseDate") Is DBNull.Value Then
                objInfo.PurchaseDate = Nothing
            Else
                objInfo.PurchaseDate = Format(CDate(reader("PurchaseDate")), "yyyy/MM/dd")
            End If
            objInfo.RequestUserID = reader("RequestUserID").ToString
            If reader("RequestDate") Is DBNull.Value Then
                objInfo.RequestDate = Nothing
            Else
                objInfo.RequestDate = Format(CDate(reader("RequestDate")), "yyyy/MM/dd")
            End If
            objInfo.RequestUserName = reader("RequestUserName").ToString
            objInfo.SupplierID = reader("SupplierID").ToString
            objInfo.SupplierName = reader("SupplierName").ToString
            objInfo.WareHouseID = reader("WareHouseID").ToString
            objInfo.WareHouseName = reader("WareHouseName").ToString
            If reader("CheckBit") Is DBNull.Value Then
                objInfo.CheckBit = Nothing
            Else
                objInfo.CheckBit = reader("CheckBit")
            End If
            objInfo.CheckRemark = IIf(IsDBNull(reader("CheckRemark")), Nothing, reader("CheckRemark").ToString)
            If reader("CheckDate") Is DBNull.Value Then
                objInfo.CheckDate = Nothing
            Else
                objInfo.CheckDate = Format(CDate(reader("CheckDate")), "yyyy/MM/dd")
            End If
            objInfo.CheckUserID = IIf(IsDBNull(reader("CheckUserID")), Nothing, reader("CheckUserID").ToString)
            objInfo.CheckUserName = IIf(IsDBNull(reader("CheckUserName")), Nothing, reader("CheckUserName").ToString)
            If reader("ReCheckBit") Is DBNull.Value Then
                objInfo.ReCheckBit = Nothing
            Else
                objInfo.ReCheckBit = reader("ReCheckBit")
            End If
            objInfo.ReCheckRemark = IIf(IsDBNull(reader("ReCheckRemark")), Nothing, reader("ReCheckRemark").ToString)
            objInfo.ReCheckUserID = IIf(IsDBNull(reader("ReCheckUserID")), Nothing, reader("ReCheckUserID").ToString)
            objInfo.ReCheckUserName = IIf(IsDBNull(reader("ReCheckUserName")), Nothing, reader("ReCheckUserName").ToString)
            If reader("ReCheckDate") Is DBNull.Value Then
                objInfo.ReCheckDate = Nothing
            Else
                objInfo.ReCheckDate = Format(CDate(reader("ReCheckDate")), "yyyy/MM/dd")
            End If
            objInfo.DeliveryType = IIf(IsDBNull(reader("DeliveryType")), Nothing, reader("DeliveryType").ToString)
            objInfo.Remarks = IIf(IsDBNull(reader("Remarks")), Nothing, reader("Remarks").ToString)
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateUserName = IIf(IsDBNull(reader("CreateUserName")), Nothing, reader("CreateUserName").ToString)
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = IIf(IsDBNull(reader("ModifyUserID")), Nothing, reader("ModifyUserID").ToString)
            objInfo.IsUrgency = reader("IsUrgency")
            Return objInfo
        End Function

        Public Function MrpPurchaseOrder_GetList(ByVal PO As String, ByVal BeginDate As DateTime, ByVal CheckType As String, ByVal ReCheckType As String, ByVal DeptID As String, ByVal CreateUserID As String, ByVal PR As String, ByVal SupplierID As String, ByVal EndDate As Date, ByVal CheckBit As String, ByVal IsUrgency As String, ByVal ReCheckBit As String, ByVal DisplayNum As Decimal) As List(Of MrpPurchaseOrderInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrder_GetList")
            db.AddInParameter(dbComm, "@PO", DbType.String, PO)
            If BeginDate <> Nothing Then
                db.AddInParameter(dbComm, "@BeginDate", DbType.Date, BeginDate)
            End If
            If CheckType <> Nothing Then
                db.AddInParameter(dbComm, "@CheckType", DbType.String, CheckType)
            End If
            If ReCheckType <> Nothing Then
                db.AddInParameter(dbComm, "@ReCheckType", DbType.String, ReCheckType)
            End If
            If DeptID <> Nothing Then
                db.AddInParameter(dbComm, "@DeptID", DbType.String, DeptID)
            End If
            If CreateUserID <> Nothing Then
                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, CreateUserID)
            End If
            If PR <> Nothing Then
                db.AddInParameter(dbComm, "@PR ", DbType.String, PR)
            End If
            If SupplierID <> Nothing Then
                db.AddInParameter(dbComm, "@SupplierID ", DbType.String, SupplierID)
            End If
            If EndDate <> Nothing Then
                db.AddInParameter(dbComm, "@EndDate ", DbType.DateTime, EndDate)
            End If
            If CheckBit <> Nothing Then
                db.AddInParameter(dbComm, "@CheckBit ", DbType.Boolean, CheckBit)
            End If
            If IsUrgency <> Nothing Then
                db.AddInParameter(dbComm, "@IsUrgency ", DbType.Boolean, IsUrgency)
            End If
            If ReCheckBit <> Nothing Then
                db.AddInParameter(dbComm, "@ReCheckBit ", DbType.Boolean, ReCheckBit)
            End If
            db.AddInParameter(dbComm, "@DisplayNum ", DbType.Decimal, DisplayNum)
            Dim FeatureList As New List(Of MrpPurchaseOrderInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpPurchaseOrder(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpPurchaseOrder_Delete(ByVal PO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrder_Delete")
                db.AddInParameter(dbComm, "@PO", DbType.String, PO)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseOrder_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseOrder_Delete = False
            End Try
        End Function

        Public Function MrpPurchaseOrder_Update(ByVal objinfo As MrpPurchaseOrderInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrder_Update")
                db.AddInParameter(dbComm, "@PO", DbType.String, objinfo.PO)
                db.AddInParameter(dbComm, "@PR", DbType.String, objinfo.PR)
                db.AddInParameter(dbComm, "@DeptID", DbType.String, objinfo.DeptID)
                If objinfo.PurchaseDate = Nothing Then
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.DateTime, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.DateTime, objinfo.PurchaseDate)
                End If
                db.AddInParameter(dbComm, "@RequestUserID", DbType.String, objinfo.RequestUserID)
                If objinfo.RequestDate = Nothing Then
                    db.AddInParameter(dbComm, "@RequestDate", DbType.DateTime, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@RequestDate", DbType.DateTime, objinfo.RequestDate)
                End If
                db.AddInParameter(dbComm, "@DeliveryType", DbType.String, objinfo.DeliveryType)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.AddInParameter(dbComm, "@SupplierID", DbType.String, objinfo.SupplierID)
                db.AddInParameter(dbComm, "@WareHouseID", DbType.String, objinfo.WareHouseID)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@IsUrgency", DbType.Boolean, objinfo.IsUrgency)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseOrder_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseOrder_Update = False
            End Try
        End Function

        Public Function MrpPurchaseOrder_Add(ByVal objInfo As MrpPurchaseOrderInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrder_Add")
                db.AddInParameter(dbComm, "@PO", DbType.String, objInfo.PO)
                db.AddInParameter(dbComm, "@PR", DbType.String, objInfo.PR)
                db.AddInParameter(dbComm, "@DeptID", DbType.String, objInfo.DeptID)
                If objInfo.PurchaseDate = Nothing Then
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.DateTime, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@PurchaseDate", DbType.DateTime, objInfo.PurchaseDate)
                End If
                db.AddInParameter(dbComm, "@RequestUserID", DbType.String, objInfo.RequestUserID)
                If objInfo.RequestDate = Nothing Then
                    db.AddInParameter(dbComm, "@RequestDate", DbType.DateTime, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@RequestDate", DbType.DateTime, objInfo.RequestDate)
                End If
                db.AddInParameter(dbComm, "@DeliveryType", DbType.String, objInfo.DeliveryType)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.AddInParameter(dbComm, "@SupplierID", DbType.String, objInfo.SupplierID)
                db.AddInParameter(dbComm, "@WareHouseID", DbType.String, objInfo.WareHouseID)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@IsUrgency", DbType.Boolean, objInfo.IsUrgency)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseOrder_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseOrder_Add = False
            End Try
        End Function

        Public Function MrpPurchaseOrder_GetID() As String
            Try
                Dim ndate = "PO" + Format(Now(), "yyMM")
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrder_GetID")
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        Return ndate + Mid((CInt(Mid(reader("PO").ToString, 7)) + 10001), 2)
                    Else
                        Return ndate + "0001"
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "中間層:MrpPurchaseOrder_GetID方法出錯")
                Return Nothing
            End Try
        End Function

        Public Function MrpPurchaseOrder_UpdateCheck(ByVal objinfo As MrpPurchaseOrderInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpPurchaseOrder_UpdateCheck")
                db.AddInParameter(dbComm, "@PO", DbType.String, objinfo.PO)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.AddInParameter(dbComm, "@ReCheckUserID", DbType.String, objinfo.ReCheckUserID)
                db.AddInParameter(dbComm, "@ReCheckBit", DbType.Boolean, objinfo.ReCheckBit)
                db.AddInParameter(dbComm, "@ReCheckRemark", DbType.String, objinfo.ReCheckRemark)
                db.ExecuteNonQuery(dbComm)
                MrpPurchaseOrder_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpPurchaseOrder_UpdateCheck = False
            End Try
        End Function
    End Class
End Namespace
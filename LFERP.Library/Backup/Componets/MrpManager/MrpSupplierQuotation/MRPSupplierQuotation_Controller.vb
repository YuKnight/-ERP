Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpSupplierQuotation
    Public Class MrpSupplierQuotationController

        Friend Function FillMRPSupplierQuotation(ByVal reader As IDataReader) As MrpSupplierQuotationInfo
            Dim objInfo As New MrpSupplierQuotationInfo
            Try
                objInfo.MCode = IIf(IsDBNull(reader("MCode")), Nothing, reader("MCode").ToString)
                objInfo.S_Supplier = IIf(IsDBNull(reader("S_Supplier")), Nothing, reader("S_Supplier").ToString)
                If reader("EconomicQty") Is DBNull.Value Then
                    objInfo.EconomicQty = Nothing
                Else
                    objInfo.EconomicQty = CDbl(reader("EconomicQty"))
                End If
                If reader("OrderQty") Is DBNull.Value Then
                    objInfo.OrderQty = Nothing
                Else
                    objInfo.OrderQty = CDbl(reader("OrderQty"))
                End If
                objInfo.DeliveryDate = reader("DeliveryDate")
                If reader("MaxQty") Is DBNull.Value Then
                    objInfo.MaxQty = Nothing
                Else
                    objInfo.MaxQty = CDbl(reader("MaxQty"))
                End If
                If reader("MinQty") Is DBNull.Value Then
                    objInfo.MinQty = Nothing
                Else
                    objInfo.MinQty = CDbl(reader("MinQty"))
                End If
                objInfo.ResponsibleUserID = IIf(IsDBNull(reader("ResponsibleUserID")), Nothing, reader("ResponsibleUserID").ToString)
                If reader("UnitPrice") Is DBNull.Value Then
                    objInfo.UnitPrice = Nothing
                Else
                    objInfo.UnitPrice = CDbl(reader("UnitPrice"))
                End If
                objInfo.Remark = IIf(IsDBNull(reader("Remark")), Nothing, reader("Remark").ToString)
                objInfo.CreateUserID = IIf(IsDBNull(reader("CreateUserID")), Nothing, reader("CreateUserID").ToString)
                If reader("CreateDate") Is DBNull.Value Then
                    objInfo.CreateDate = Nothing
                Else
                    objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
                End If
                objInfo.ModifyUserID = IIf(IsDBNull(reader("ModifyUserID")), Nothing, reader("ModifyUserID").ToString)
                If reader("ModifyDate") Is DBNull.Value Then
                    objInfo.ModifyDate = Nothing
                Else
                    objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
                End If
                objInfo.CheckUserID = IIf(IsDBNull(reader("CheckUserID")), Nothing, reader("CheckUserID").ToString)
                If reader("CheckBit") Is DBNull.Value Then
                    objInfo.CheckBit = Nothing
                Else
                    objInfo.CheckBit = reader("CheckBit")
                End If

                If reader("DefaultBit") Is DBNull.Value Then
                    objInfo.DefaultBit = Nothing
                Else
                    objInfo.DefaultBit = reader("DefaultBit")
                End If

                objInfo.CheckRemark = IIf(IsDBNull(reader("CheckRemark")), Nothing, reader("CheckRemark").ToString)
                objInfo.MrpSQID = IIf(IsDBNull(reader("MrpSQID")), Nothing, reader("MrpSQID").ToString)
                objInfo.S_SupplierName = IIf(IsDBNull(reader("S_SupplierName")), Nothing, reader("S_SupplierName").ToString)
                objInfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
                objInfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
                objInfo.M_Source = IIf(IsDBNull(reader("M_Source")), Nothing, reader("M_Source").ToString)
                objInfo.M_Unit = IIf(IsDBNull(reader("M_Unit")), Nothing, reader("M_Unit").ToString)
                objInfo.PaymentType = IIf(IsDBNull(reader("PaymentType")), Nothing, reader("PaymentType").ToString)
                objInfo.Tel = IIf(IsDBNull(reader("Tel")), Nothing, reader("Tel").ToString)
                objInfo.Contacts = IIf(IsDBNull(reader("Contacts")), Nothing, reader("Contacts").ToString)
                objInfo.CurrencyName = IIf(IsDBNull(reader("CurrencyName")), Nothing, reader("CurrencyName").ToString)
                objInfo.Fax = IIf(IsDBNull(reader("Fax")), Nothing, reader("Fax").ToString)
                objInfo.Email = IIf(IsDBNull(reader("Email")), Nothing, reader("Email").ToString)
                objInfo.AutoID = reader("AutoID")

                Return objInfo
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function



        Public Function MRPSupplierQuotation_GetList(ByVal MCode As String, ByVal MrpSQID As String, ByVal IsCheck As Boolean) As List(Of MrpSupplierQuotationInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSupplierQuotation_GetList")
            db.AddInParameter(dbComm, "@MCode", DbType.String, MCode)
            db.AddInParameter(dbComm, "@MrpSQID", DbType.String, MrpSQID)
            If IsCheck = Nothing Then
                db.AddInParameter(dbComm, "@IsCheck ", DbType.Boolean, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@IsCheck ", DbType.Boolean, IsCheck)
            End If

            Dim FeatureList As New List(Of MrpSupplierQuotationInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMRPSupplierQuotation(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MRPSupplierQuotation_GetIsCheck(ByVal MrpSQID As String) As Boolean
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSupplierQuotation_GetIsCheck")
            db.AddInParameter(dbComm, "@MrpSQID", DbType.String, MrpSQID)
            Dim FeatureList As New List(Of MrpSupplierQuotationInfo)
            Dim IsCheck As Boolean = False

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    If isdbnull(reader("CheckBit")) = True Then
                        IsCheck = Nothing
                    Else
                        IsCheck = reader("CheckBit")
                    End If
                End While
                Return IsCheck
            End Using
        End Function
        Public Function MRPSupplierQuotation_GetNewMrpSQID() As String
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSupplierQuotation_GetNewMrpSQID")
            Dim NewMrpSQID As String = String.Empty
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    NewMrpSQID = reader("newMrpSQID")
                End While
                Return NewMrpSQID
            End Using
        End Function


        Public Function MRPSupplierQuotation_Delete(ByVal MCode As String, ByVal AutoID As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSupplierQuotation_Delete")
                db.AddInParameter(dbComm, "@MCode", DbType.String, MCode)
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)

                db.ExecuteNonQuery(dbComm)
                MRPSupplierQuotation_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MRPSupplierQuotation_Delete = False
            End Try
        End Function


        Public Function MRPSupplierQuotation_Update(ByVal objinfo As MrpSupplierQuotationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSupplierQuotation_Update")
                db.AddInParameter(dbComm, "@MCode", DbType.String, objinfo.MCode)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objinfo.S_Supplier)
                db.AddInParameter(dbComm, "@EconomicQty", DbType.Decimal, objinfo.EconomicQty)
                db.AddInParameter(dbComm, "@OrderQty", DbType.Decimal, objinfo.OrderQty)
                db.AddInParameter(dbComm, "@DeliveryDate", DbType.Int16, objinfo.DeliveryDate)
                db.AddInParameter(dbComm, "@MaxQty", DbType.Decimal, objinfo.MaxQty)
                db.AddInParameter(dbComm, "@MinQty", DbType.Decimal, objinfo.MinQty)
                db.AddInParameter(dbComm, "@ResponsibleUserID", DbType.String, objinfo.ResponsibleUserID)
                db.AddInParameter(dbComm, "@UnitPrice", DbType.Decimal, objinfo.UnitPrice)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark) 
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@DefaultBit", DbType.Boolean, objinfo.DefaultBit)
                db.ExecuteNonQuery(dbComm)
                MRPSupplierQuotation_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MRPSupplierQuotation_Update = False
            End Try
        End Function

        Public Function MRPSupplierQuotation_Check(ByVal objinfo As MrpSupplierQuotationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSupplierQuotation_Check")
               
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.AddInParameter(dbComm, "@MrpSQID", DbType.String, objinfo.MrpSQID)
                db.ExecuteNonQuery(dbComm)
                MRPSupplierQuotation_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MRPSupplierQuotation_Check = False
            End Try
        End Function

        Public Function MRPSupplierQuotation_Add(ByVal objInfo As MrpSupplierQuotationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpSupplierQuotation_Add")
                db.AddInParameter(dbComm, "@MCode", DbType.String, objInfo.MCode)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objInfo.S_Supplier)
                db.AddInParameter(dbComm, "@EconomicQty", DbType.Decimal, objInfo.EconomicQty)
                db.AddInParameter(dbComm, "@OrderQty", DbType.Decimal, objInfo.OrderQty)
                db.AddInParameter(dbComm, "@DeliveryDate", DbType.Int32, objInfo.DeliveryDate)
                db.AddInParameter(dbComm, "@MaxQty", DbType.Decimal, objInfo.MaxQty)
                db.AddInParameter(dbComm, "@MinQty", DbType.Decimal, objInfo.MinQty)
                db.AddInParameter(dbComm, "@ResponsibleUserID", DbType.String, objInfo.ResponsibleUserID)
                db.AddInParameter(dbComm, "@UnitPrice", DbType.Decimal, objInfo.UnitPrice)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@MrpSQID", DbType.String, objInfo.MrpSQID)
                db.AddInParameter(dbComm, "@DefaultBit", DbType.Boolean, objInfo.DefaultBit)

                db.ExecuteNonQuery(dbComm)
                MRPSupplierQuotation_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MRPSupplierQuotation_Add = False
            End Try
        End Function
    End Class
End Namespace

Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info

    Public Class Mrp_TempQtyController
        Friend Function Mrp_TempQtyfill(ByVal reader As IDataReader) As Mrp_TempQtyInfo
            On Error Resume Next
            Dim objInfo As New Mrp_TempQtyInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString
            objInfo.BillsType = reader("BillsType").ToString
            objInfo.SingleNo = reader("SingleNo").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Qty = reader("Qty")

            objInfo.TempDate = reader("TempDate")

            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate")
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.AutoID = reader("AutoID")
            Return objInfo

        End Function


        Public Function Mrp_TempQtyMain_GetList(ByVal PM_M_Code As String, ByVal BitType As Boolean) As List(Of Mrp_TempQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_TempQtyMain_GetList")

                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_TempQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_TempQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function


        Public Function Mrp_TempQty_GetList(ByVal MRP_ID As String, ByVal PM_M_Code As String, ByVal TempDate As Date, ByVal BitType As String) As List(Of Mrp_TempQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_TempQty_GetList")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

                If TempDate = Nothing Then
                    db.AddInParameter(dbComm, "@TempDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@TempDate", DbType.Date, TempDate)
                End If

                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_TempQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_TempQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_TempQty_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_TempQty_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                Mrp_TempQty_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Mrp_TempQty_Delete = False
            End Try
        End Function

        Public Function Mrp_TempQty_Update(ByVal objinfo As Mrp_TempQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_TempQty_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@BillsType", DbType.String, objinfo.BillsType)
                db.AddInParameter(dbComm, "@SingleNo", DbType.String, objinfo.SingleNo)
                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objinfo.Qty)



                If objinfo.TempDate = Nothing Then
                    db.AddInParameter(dbComm, "@TempDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@TempDate", DbType.Date, objinfo.TempDate)
                End If

                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_TempQty_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_TempQty_Update = False
            End Try
        End Function

        Public Function Mrp_TempQty_Add(ByVal objInfo As Mrp_TempQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_TempQty_Add")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@BillsType", DbType.String, objInfo.BillsType)
                db.AddInParameter(dbComm, "@SingleNo", DbType.String, objInfo.SingleNo)
                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objInfo.Qty)


                If objInfo.TempDate = Nothing Then
                    db.AddInParameter(dbComm, "@TempDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@TempDate", DbType.Date, objInfo.TempDate)
                End If

                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate ", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_TempQty_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_TempQty_Add = False
            End Try
        End Function

    End Class
End Namespace
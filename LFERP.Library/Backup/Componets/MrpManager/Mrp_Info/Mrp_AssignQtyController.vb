Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info

    Public Class Mrp_AssignQtyController
        Friend Function Mrp_AssignQtyfill(ByVal reader As IDataReader) As Mrp_AssignQtyInfo
            On Error Resume Next
            Dim objInfo As New Mrp_AssignQtyInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString
            objInfo.BillsType = reader("BillsType").ToString
            objInfo.SingleNo = reader("SingleNo").ToString
            objInfo.D_ID = reader("D_ID").ToString
            objInfo.PS_NO = reader("PS_NO").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Qty = reader("Qty")
            objInfo.StartDate = reader("StartDate")
            objInfo.EndDate = reader("EndDate")

            objInfo.CreateUserID = reader("CreateUserID").ToString
            objInfo.CreateDate = reader("CreateDate")
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate")
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.ModifyUserName = reader("ModifyUserName").ToString
            objInfo.AutoID = reader("AutoID")
            Return objInfo

        End Function


        Public Function Mrp_AssignQtyMain_GetList(ByVal D_ID As String, ByVal PS_NO As String, ByVal PM_M_Code As String, ByVal BitType As Boolean) As List(Of Mrp_AssignQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_AssignQtyMain_GetList")

                db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_AssignQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_AssignQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function


        Public Function Mrp_AssignQty_GetList(ByVal MRP_ID As String, ByVal PM_M_Code As String, ByVal StartDate As Date, ByVal BitType As String) As List(Of Mrp_AssignQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_AssignQty_GetList")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

                If StartDate = Nothing Then
                    db.AddInParameter(dbComm, "@StartDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@StartDate", DbType.Date, StartDate)
                End If

                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)


                Dim FeatureList As New List(Of Mrp_AssignQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_AssignQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_AssignQty_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_AssignQty_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                Mrp_AssignQty_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Mrp_AssignQty_Delete = False
            End Try
        End Function

        Public Function Mrp_AssignQty_Update(ByVal objinfo As Mrp_AssignQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_AssignQty_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)
                db.AddInParameter(dbComm, "@BillsType", DbType.String, objinfo.BillsType)
                db.AddInParameter(dbComm, "@SingleNo", DbType.String, objinfo.SingleNo)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objinfo.D_ID)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objinfo.Qty)

                If objinfo.StartDate = Nothing Then
                    db.AddInParameter(dbComm, "@StartDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@StartDate", DbType.Date, objinfo.StartDate)
                End If

                If objinfo.EndDate = Nothing Then
                    db.AddInParameter(dbComm, "@EndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@EndDate", DbType.Date, objinfo.EndDate)
                End If

                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_AssignQty_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_AssignQty_Update = False
            End Try
        End Function

        Public Function Mrp_AssignQty_Add(ByVal objInfo As Mrp_AssignQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_AssignQty_Add")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)
                db.AddInParameter(dbComm, "@BillsType", DbType.String, objInfo.BillsType)
                db.AddInParameter(dbComm, "@SingleNo", DbType.String, objInfo.SingleNo)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objInfo.D_ID)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objInfo.PS_NO)
                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objInfo.Qty)


                If objInfo.StartDate = Nothing Then
                    db.AddInParameter(dbComm, "@StartDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@StartDate", DbType.Date, objInfo.StartDate)
                End If

                If objInfo.EndDate = Nothing Then
                    db.AddInParameter(dbComm, "@EndDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@EndDate", DbType.Date, objInfo.EndDate)
                End If

                db.AddInParameter(dbComm, "@CreateUserID ", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate ", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_AssignQty_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_AssignQty_Add = False
            End Try
        End Function

    End Class
End Namespace
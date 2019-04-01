Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Collections
Imports LFERP.Library.MrpManager.MrpSetting

Namespace LFERP.Library.MrpManager.Mrp_Info
    Public Class Mrp_DependentQtyController
        Friend Function Mrp_DependentQtyfill(ByVal reader As IDataReader) As Mrp_DependentQtyInfo
            On Error Resume Next
            Dim objInfo As New Mrp_DependentQtyInfo
            objInfo.MRP_ID = reader("MRP_ID").ToString

            objInfo.ParentGroup = reader("ParentGroup").ToString
            objInfo.GroupName = reader("GroupName").ToString
            objInfo.Item = reader("Item").ToString
            objInfo.M_LowestBomCode = reader("M_LowestBomCode")
            objInfo.LossRate = reader("LossRate")

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

        Public Function Mrp_DependentQty_GetList(ByVal MRP_ID As String, ByVal PM_M_Code As String, ByVal OM_SendDate As Date, ByVal BitType As String) As List(Of Mrp_DependentQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DependentQty_GetList")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

                If OM_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@OM_SendDate", DbType.Date, OM_SendDate)
                End If


                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_DependentQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_DependentQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_DependentBomQty_GetList(ByVal ParentGroup As String) As List(Of Mrp_DependentQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DependentBomQty_GetList")
                db.AddInParameter(dbComm, "@ParentGroup", DbType.String, ParentGroup)
                Dim FeatureList As New List(Of Mrp_DependentQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_DependentQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_DependentQtyMain_GetList(ByVal StateDate As String, ByVal EndDate As String, ByVal PM_M_Code As String, ByVal BitType As String) As List(Of Mrp_DependentQtyInfo)
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DependentQtyMain_GetList")
                db.AddInParameter(dbComm, "@StateDate", DbType.String, StateDate)
                db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@BitType", DbType.Boolean, BitType)

                Dim FeatureList As New List(Of Mrp_DependentQtyInfo)
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(Mrp_DependentQtyfill(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function Mrp_DependentQty_Delete(ByVal MRP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DependentQty_Delete")
                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, MRP_ID)
                db.ExecuteNonQuery(dbComm)
                Mrp_DependentQty_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                Mrp_DependentQty_Delete = False
            End Try
        End Function

        Public Function Mrp_DependentQty_Update(ByVal objinfo As Mrp_DependentQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DependentQty_Update")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objinfo.MRP_ID)


                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objinfo.LossRate)
                db.AddInParameter(dbComm, "@M_LowestBomCode", DbType.Int32, objinfo.M_LowestBomCode)
                db.AddInParameter(dbComm, "@Item", DbType.String, objinfo.Item)
                db.AddInParameter(dbComm, "@ParentGroup", DbType.String, objinfo.ParentGroup)

                db.AddInParameter(dbComm, "@PM_M_Code ", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objinfo.Qty)

                db.AddInParameter(dbComm, "@OM_SendDate", DbType.Date, objinfo.OM_SendDate)

                db.AddInParameter(dbComm, "@ModifyUserID ", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate ", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                Mrp_DependentQty_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_DependentQty_Update = False
            End Try
        End Function

        Public Function Mrp_DependentQty_Add(ByVal objInfo As Mrp_DependentQtyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Mrp_DependentQty_Add")

                db.AddInParameter(dbComm, "@MRP_ID", DbType.String, objInfo.MRP_ID)

                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objInfo.LossRate)
                db.AddInParameter(dbComm, "@M_LowestBomCode", DbType.Int32, objInfo.M_LowestBomCode)
                db.AddInParameter(dbComm, "@Item", DbType.String, objInfo.Item)
                db.AddInParameter(dbComm, "@ParentGroup", DbType.String, objInfo.ParentGroup)

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
                Mrp_DependentQty_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Mrp_DependentQty_Add = False
            End Try
        End Function
    End Class
End Namespace
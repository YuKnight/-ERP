
Namespace LFERP.Library.ProductionBalance

    Public Class ProductionBalanceControl

        Public Function ProductionBalance_GetID(ByVal NDate As String) As ProductionBalanceInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionBalance_GetID")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionBalance(reader)
                End While
                Return Nothing
            End Using

        End Function

        Public Function ProductionBalance_Add(ByVal objinfo As ProductionBalanceInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionBalance_Add")


                db.AddInParameter(dbComm, "@B_ID", DbType.String, objinfo.B_ID)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objinfo.DPT_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WI_Qty", DbType.Single, objinfo.WI_Qty)
                db.AddInParameter(dbComm, "@WI_ReQty", DbType.Single, objinfo.WI_ReQty)
                db.AddInParameter(dbComm, "@B_Action", DbType.Single, objinfo.B_Action)
                db.AddInParameter(dbComm, "@B_AddDate", DbType.Date, objinfo.B_AddDate)
                db.AddInParameter(dbComm, "@B_Remark", DbType.String, objinfo.B_Remark)
       

                db.ExecuteNonQuery(dbComm)
                ProductionBalance_Add = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionBalance_Add = False

            End Try

        End Function

        Public Function ProductionBalance_Update(ByVal objinfo As ProductionBalanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionBalance_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@B_ID", DbType.String, objinfo.B_ID)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objinfo.DPT_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WI_Qty", DbType.Single, objinfo.WI_Qty)
                db.AddInParameter(dbComm, "@WI_ReQty", DbType.Single, objinfo.WI_ReQty)
                db.AddInParameter(dbComm, "@B_Action", DbType.Single, objinfo.B_Action)
                db.AddInParameter(dbComm, "@B_AddDate", DbType.Date, objinfo.B_AddDate)
                db.AddInParameter(dbComm, "@B_Remark", DbType.String, objinfo.B_Remark)

                db.ExecuteNonQuery(dbComm)
                ProductionBalance_Update = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionBalance_Update = False

            End Try
        End Function

        Public Function ProductionBalance_Delete(ByVal B_ID As String, ByVal AutoID As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionBalance_Delete")

                db.AddInParameter(dbComm, "@B_ID", DbType.String, B_ID)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                ProductionBalance_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionBalance_Delete = False
            End Try
        End Function

        Public Function ProductionBalance_GetList(ByVal B_ID As String, ByVal DPT_ID As String, ByVal B_Action As String, ByVal B_CheckAction As String, ByVal B_Check As String) As List(Of ProductionBalanceInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionBalance_GetList")

            db.AddInParameter(dbComm, "@B_ID", DbType.String, B_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@B_Action", DbType.String, B_Action)
            db.AddInParameter(dbComm, "@B_CheckAction", DbType.String, B_CheckAction)
            db.AddInParameter(dbComm, "@B_Check", DbType.String, B_Check)
       
            Dim FeatureList As New List(Of ProductionBalanceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionBalance(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionBalance_UpdateCheck(ByVal objinfo As ProductionBalanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionBalance_UpdateCheck")

                db.AddInParameter(dbComm, "@B_ID", DbType.String, objinfo.B_ID)
                db.AddInParameter(dbComm, "@B_Check", DbType.Boolean, objinfo.B_Check)
                db.AddInParameter(dbComm, "@B_CheckAction", DbType.String, objinfo.B_CheckAction)
                db.AddInParameter(dbComm, "@B_CheckDate", DbType.Date, objinfo.B_CheckDate)
                db.AddInParameter(dbComm, "@B_CheckRemark", DbType.String, objinfo.B_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionBalance_UpdateCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionBalance_UpdateCheck = False
            End Try
        End Function

        Public Function FillProductionBalance(ByVal reader As IDataReader) As ProductionBalanceInfo
            On Error Resume Next

            Dim bi As New ProductionBalanceInfo

            bi.AutoID = reader("AutoID").ToString
            bi.B_ID = reader("B_ID").ToString
            bi.DPT_ID = reader("DPT_ID").ToString
            bi.M_Code = reader("M_Code").ToString

            If reader("WI_Qty") Is DBNull.Value Then
                bi.WI_Qty = 0
            Else
                bi.WI_Qty = CSng(reader("WI_Qty"))
            End If
            If reader("WI_ReQty") Is DBNull.Value Then
                bi.WI_ReQty = 0
            Else
                bi.WI_ReQty = CSng(reader("WI_ReQty"))
            End If

            bi.B_Action = reader("B_Action").ToString

            If reader("B_AddDate") Is DBNull.Value Then
                bi.B_AddDate = Nothing
            Else
                bi.B_AddDate = CStr(reader("B_AddDate"))
            End If

            bi.B_Remark = reader("B_Remark").ToString

            If reader("B_Check") Is DBNull.Value Then
                bi.B_Check = Nothing
            Else
                bi.B_Check = CStr(reader("B_Check"))
            End If
            bi.B_CheckAction = reader("B_CheckAction").ToString

            If reader("B_CheckDate") Is DBNull.Value Then
                bi.B_CheckDate = Nothing
            Else
                bi.B_CheckDate = CStr(reader("B_CheckDate"))
            End If

            bi.B_CheckRemark = reader("B_CheckRemark").ToString


            bi.ActionName = reader("ActionName").ToString
            bi.CheckActionName = reader("CheckActionName").ToString
            bi.PS_Name = reader("PS_Name").ToString
            bi.DepName = reader("DepName").ToString

            bi.PM_M_Code = reader("PM_M_Code").ToString
            bi.Pro_Type = reader("Pro_Type").ToString
            bi.Type3ID = reader("Type3ID").ToString

            Return bi

        End Function

    End Class

End Namespace


Namespace LFERP.Library.Production.ProuctionWareOutB
    Public Class ProductionWareOutBControl


        Public Function ProductionWareOutB_GetNO(ByVal NDate As String) As ProductionWareOutBInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOutB_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionWareOutB(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionWareOutB_Add(ByVal objinfo As ProductionWareOutBInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOutB_Add")

                db.AddInParameter(dbComm, "@P_NO", DbType.String, objinfo.P_NO)

                db.AddInParameter(dbComm, "@P_WareIN", DbType.String, objinfo.P_WareIN)
                db.AddInParameter(dbComm, "@Pro_TypeIN", DbType.String, objinfo.Pro_TypeIN)
                db.AddInParameter(dbComm, "@PM_M_CodeIN", DbType.String, objinfo.PM_M_CodeIN)
                db.AddInParameter(dbComm, "@PM_TypeIN", DbType.String, objinfo.PM_TypeIN)
                db.AddInParameter(dbComm, "@M_CodeIN", DbType.String, objinfo.M_CodeIN)

                db.AddInParameter(dbComm, "@P_WareOut", DbType.String, objinfo.P_WareOut)
                db.AddInParameter(dbComm, "@Pro_TypeOut", DbType.String, objinfo.Pro_TypeOut)
                db.AddInParameter(dbComm, "@PM_M_CodeOut", DbType.String, objinfo.PM_M_CodeOut)
                db.AddInParameter(dbComm, "@PM_TypeOut", DbType.String, objinfo.PM_TypeOut)
                db.AddInParameter(dbComm, "@M_CodeOut", DbType.String, objinfo.M_CodeOut)
                db.AddInParameter(dbComm, "@P_Qty", DbType.Int32, objinfo.P_Qty)

                db.AddInParameter(dbComm, "@P_EndINQty", DbType.Int32, objinfo.P_EndINQty)
                db.AddInParameter(dbComm, "@P_EndOutQty", DbType.Int32, objinfo.P_EndOutQty)

                db.AddInParameter(dbComm, "@P_AddDate", DbType.Date, objinfo.P_AddDate)
                db.AddInParameter(dbComm, "@P_Action", DbType.String, objinfo.P_Action)
                db.AddInParameter(dbComm, "@P_Remark", DbType.String, objinfo.P_Remark)

                db.ExecuteNonQuery(dbComm)
                ProductionWareOutB_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareOutB_Add = False
            End Try
        End Function

        Public Function ProductionWareOutB_Update(ByVal objinfo As ProductionWareOutBInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOutB_Update")

                db.AddInParameter(dbComm, "@P_NO", DbType.String, objinfo.P_NO)

                db.AddInParameter(dbComm, "@P_WareIN", DbType.String, objinfo.P_WareIN)
                db.AddInParameter(dbComm, "@Pro_TypeIN", DbType.String, objinfo.Pro_TypeIN)
                db.AddInParameter(dbComm, "@PM_M_CodeIN", DbType.String, objinfo.PM_M_CodeIN)
                db.AddInParameter(dbComm, "@PM_TypeIN", DbType.String, objinfo.PM_TypeIN)
                db.AddInParameter(dbComm, "@M_CodeIN", DbType.String, objinfo.M_CodeIN)

                db.AddInParameter(dbComm, "@P_WareOut", DbType.String, objinfo.P_WareOut)
                db.AddInParameter(dbComm, "@Pro_TypeOut", DbType.String, objinfo.Pro_TypeOut)
                db.AddInParameter(dbComm, "@PM_M_CodeOut", DbType.String, objinfo.PM_M_CodeOut)
                db.AddInParameter(dbComm, "@PM_TypeOut", DbType.String, objinfo.PM_TypeOut)
                db.AddInParameter(dbComm, "@M_CodeOut", DbType.String, objinfo.M_CodeOut)

                db.AddInParameter(dbComm, "@P_Qty", DbType.Int32, objinfo.P_Qty)
                db.AddInParameter(dbComm, "@P_EndINQty", DbType.Int32, objinfo.P_EndINQty)
                db.AddInParameter(dbComm, "@P_EndOutQty", DbType.Int32, objinfo.P_EndOutQty)

                db.AddInParameter(dbComm, "@P_ModifyDate", DbType.Date, objinfo.P_ModifyDate)
                db.AddInParameter(dbComm, "@P_ModifyAction", DbType.String, objinfo.P_ModifyAction)
                db.AddInParameter(dbComm, "@P_Remark", DbType.String, objinfo.P_Remark)

                db.ExecuteNonQuery(dbComm)
                ProductionWareOutB_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareOutB_Update = False
            End Try
        End Function


        Public Function ProductionWareOutB_Delete(ByVal P_NO As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOutB_Delete")

                db.AddInParameter(dbComm, "@P_NO", DbType.String, P_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionWareOutB_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareOutB_Delete = False
            End Try
        End Function


        Public Function ProductionWareOutB_UpdateCheck(ByVal objinfo As ProductionWareOutBInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOutB_UpdateCheck")

                db.AddInParameter(dbComm, "@P_NO", DbType.String, objinfo.P_NO)
                db.AddInParameter(dbComm, "@P_Check", DbType.Boolean, objinfo.P_Check)
                db.AddInParameter(dbComm, "@P_CheckDate", DbType.Date, objinfo.P_CheckDate)
                db.AddInParameter(dbComm, "@P_CheckAction", DbType.String, objinfo.P_CheckAction)
                db.AddInParameter(dbComm, "@P_CheckRemark", DbType.String, objinfo.P_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionWareOutB_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareOutB_UpdateCheck = False
            End Try
        End Function

        Public Function ProductionWareOutB_UpdateInCheck(ByVal objinfo As ProductionWareOutBInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOutB_UpdateInCheck")

                db.AddInParameter(dbComm, "@P_NO", DbType.String, objinfo.P_NO)
                db.AddInParameter(dbComm, "@P_InCheck", DbType.Boolean, objinfo.P_InCheck)
                db.AddInParameter(dbComm, "@P_InCheckDate", DbType.Date, objinfo.P_InCheckDate)
                db.AddInParameter(dbComm, "@P_InCheckAction", DbType.String, objinfo.P_InCheckAction)

                db.ExecuteNonQuery(dbComm)
                ProductionWareOutB_UpdateInCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareOutB_UpdateInCheck = False
            End Try
        End Function
        Public Function ProductionWareOutB_UpdateEndQty(ByVal objinfo As ProductionWareOutBInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOutB_UpdateEndQty")

                db.AddInParameter(dbComm, "@P_NO", DbType.String, objinfo.P_NO)
                db.AddInParameter(dbComm, "@P_EndINQty", DbType.Int32, objinfo.P_EndINQty)
                db.AddInParameter(dbComm, "@P_EndOutQty", DbType.Int32, objinfo.P_EndOutQty)

                db.ExecuteNonQuery(dbComm)
                ProductionWareOutB_UpdateEndQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareOutB_UpdateEndQty = False
            End Try
        End Function



        Public Function ProductionWareOutB_GetList(ByVal P_NO As String, ByVal P_WareIN As String, _
        ByVal Pro_TypeIN As String, ByVal PM_M_CodeIN As String, ByVal PM_TypeIN As String, ByVal M_CodeIN As String, _
        ByVal P_WareOut As String, ByVal Pro_TypeOut As String, ByVal PM_M_CodeOut As String, ByVal PM_TypeOut As String, ByVal M_CodeOut As String, _
 ByVal P_AddDate1 As String, ByVal P_AddDate2 As String, ByVal P_Check As String, ByVal P_InCheck As String, ByVal SelectOutWare As String, ByVal SelectInWare As String) As List(Of ProductionWareOutBInfo)


            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOutB_GetList")

            db.AddInParameter(dbComm, "@P_NO", DbType.String, P_NO)

            db.AddInParameter(dbComm, "@P_WareIN", DbType.String, P_WareIN)
            db.AddInParameter(dbComm, "@Pro_TypeIN", DbType.String, Pro_TypeIN)
            db.AddInParameter(dbComm, "@PM_M_CodeIN", DbType.String, PM_M_CodeIN)
            db.AddInParameter(dbComm, "@PM_TypeIN", DbType.String, PM_TypeIN)
            db.AddInParameter(dbComm, "@M_CodeIN", DbType.String, M_CodeIN)

            db.AddInParameter(dbComm, "@P_WareOut", DbType.String, P_WareOut)
            db.AddInParameter(dbComm, "@Pro_TypeOut", DbType.String, Pro_TypeOut)
            db.AddInParameter(dbComm, "@PM_M_CodeOut", DbType.String, PM_M_CodeOut)
            db.AddInParameter(dbComm, "@PM_TypeOut", DbType.String, PM_TypeOut)
            db.AddInParameter(dbComm, "@M_CodeOut", DbType.String, M_CodeOut)

            db.AddInParameter(dbComm, "@P_AddDate1", DbType.String, P_AddDate1)
            db.AddInParameter(dbComm, "@P_AddDate2", DbType.String, P_AddDate2)
            db.AddInParameter(dbComm, "@P_Check", DbType.Boolean, P_Check)
            db.AddInParameter(dbComm, "@P_InCheck", DbType.Boolean, P_InCheck)

            db.AddInParameter(dbComm, "@SelectOutWare", DbType.String, SelectOutWare)
            db.AddInParameter(dbComm, "@SelectInWare", DbType.String, SelectInWare)

            Dim FeatureList As New List(Of ProductionWareOutBInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareOutB(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function FillProductionWareOutB(ByVal reader As IDataReader) As ProductionWareOutBInfo
            On Error Resume Next
            Dim pwoi As New ProductionWareOutBInfo

            pwoi.AutoID = reader("AutoID").ToString
            pwoi.P_NO = reader("P_NO").ToString

            pwoi.P_WareIN = reader("P_WareIN").ToString
            pwoi.P_WareINName = reader("P_WareINName").ToString
            pwoi.Pro_TypeIN = reader("Pro_TypeIN").ToString
            pwoi.PM_M_CodeIN = reader("PM_M_CodeIN").ToString
            pwoi.PM_TypeIN = reader("PM_TypeIN").ToString
            pwoi.M_CodeIN = reader("M_CodeIN").ToString
            pwoi.P_Qty = reader("P_Qty")
            pwoi.P_EndINQty = reader("P_EndINQty")
            pwoi.P_EndOutQty = reader("P_EndOutQty")

            pwoi.P_WareOut = reader("P_WareOut").ToString
            pwoi.P_WareOutName = reader("P_WareOutName").ToString
            pwoi.Pro_TypeOut = reader("Pro_TypeOut").ToString
            pwoi.PM_M_CodeOut = reader("PM_M_CodeOut").ToString
            pwoi.PM_TypeOut = reader("PM_TypeOut").ToString
            pwoi.M_CodeOut = reader("M_CodeOut").ToString

            pwoi.P_AddDate = reader("P_AddDate")
            pwoi.P_Action = reader("P_Action").ToString
            pwoi.P_Remark = reader("P_Remark").ToString
            pwoi.P_ModifyDate = reader("P_ModifyDate")
            pwoi.P_ModifyAction = reader("P_ModifyAction").ToString

            pwoi.P_Check = reader("P_Check")
            pwoi.P_CheckDate = reader("P_CheckDate")
            pwoi.P_CheckAction = reader("P_CheckAction").ToString
            pwoi.P_CheckRemark = reader("P_CheckRemark").ToString

            pwoi.P_InCheck = reader("P_InCheck")
            pwoi.P_InCheckDate = reader("P_InCheckDate")
            pwoi.P_InCheckAction = reader("P_InCheckAction").ToString

            pwoi.P_ActionName = reader("P_ActionName").ToString
            pwoi.P_CheckActionName = reader("P_CheckActionName").ToString
            pwoi.P_InCheckActionName = reader("P_InCheckActionName").ToString
            pwoi.P_ModifyActionName = reader("P_ModifyActionName").ToString

            pwoi.PM_JiYuIn = reader("PM_JiYuIn").ToString
            pwoi.PM_JiYuOut = reader("PM_JiYuOut").ToString

            Return pwoi

        End Function

    End Class

End Namespace
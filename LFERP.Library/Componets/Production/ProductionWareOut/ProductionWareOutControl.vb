Namespace LFERP.Library.Production.ProuctionWareOut


    Public Class ProductionWareOutControl

        Public Function ProductionWareOut_GetNo(ByVal NDate As String) As ProductionWareOutInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOut_GetNo")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionWareOut(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionWareOut_GetSubNO(ByVal NDate As String) As ProductionWareOutInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOut_GetSubNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionWareOut(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionWareOut_Add(ByVal objinfo As ProductionWareOutInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOut_Add")

                db.AddInParameter(dbComm, "@PWO_NO", DbType.String, objinfo.PWO_NO)
                db.AddInParameter(dbComm, "@PWO_WareID", DbType.String, objinfo.PWO_WareID)
                db.AddInParameter(dbComm, "@PWO_DepID", DbType.String, objinfo.PWO_DepID)
                db.AddInParameter(dbComm, "@PWO_Remark", DbType.String, objinfo.PWO_Remark)
                db.AddInParameter(dbComm, "@PWO_SubNO", DbType.String, objinfo.PWO_SubNO)
                db.AddInParameter(dbComm, "@PWO_SubType", DbType.String, objinfo.PWO_SubType)
                db.AddInParameter(dbComm, "@PWO_SubRemark", DbType.String, objinfo.PWO_SubRemark)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PWO_M_Code", DbType.String, objinfo.PWO_M_Code)
                db.AddInParameter(dbComm, "@PWO_Qty", DbType.Int32, objinfo.PWO_Qty)
                db.AddInParameter(dbComm, "@PWO_Type", DbType.String, objinfo.PWO_Type)
                db.AddInParameter(dbComm, "@PWO_Action", DbType.String, objinfo.PWO_Action)
                db.AddInParameter(dbComm, "@PWO_AddDate", DbType.Date, objinfo.PWO_AddDate)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.ExecuteNonQuery(dbComm)

                ProductionWareOut_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareOut_Add = False
            End Try
        End Function

        Public Function ProductionWareOut_Update(ByVal objinfo As ProductionWareOutInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOut_Update")

                db.AddInParameter(dbComm, "@PWO_NO", DbType.String, objinfo.PWO_NO)
                db.AddInParameter(dbComm, "@PWO_WareID", DbType.String, objinfo.PWO_WareID)
                db.AddInParameter(dbComm, "@PWO_DepID", DbType.String, objinfo.PWO_DepID)
                db.AddInParameter(dbComm, "@PWO_Remark", DbType.String, objinfo.PWO_Remark)
                db.AddInParameter(dbComm, "@PWO_SubNO", DbType.String, objinfo.PWO_SubNO)
                db.AddInParameter(dbComm, "@PWO_SubType", DbType.String, objinfo.PWO_SubType)
                db.AddInParameter(dbComm, "@PWO_SubRemark", DbType.String, objinfo.PWO_SubRemark)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PWO_M_Code", DbType.String, objinfo.PWO_M_Code)
                db.AddInParameter(dbComm, "@PWO_Qty", DbType.Int32, objinfo.PWO_Qty)
                db.AddInParameter(dbComm, "@PWO_Type", DbType.String, objinfo.PWO_Type)
                db.AddInParameter(dbComm, "@PWO_Action", DbType.String, objinfo.PWO_Action)
                db.AddInParameter(dbComm, "@PWO_AddDate", DbType.Date, objinfo.PWO_AddDate)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.ExecuteNonQuery(dbComm)
                ProductionWareOut_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareOut_Update = False

            End Try

        End Function

        Public Function ProductionWareOut_Delete(ByVal PWO_NO As String, ByVal PWO_SubNO As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOut_Delete")

                db.AddInParameter(dbComm, "@PWO_NO", DbType.String, PWO_NO)
                db.AddInParameter(dbComm, "@PWO_SubNO", DbType.String, PWO_SubNO)

                db.ExecuteNonQuery(dbComm)
                ProductionWareOut_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareOut_Delete = False
            End Try
        End Function



        Public Function ProductionWareOut_UpdateCheck(ByVal objinfo As ProductionWareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOut_UpdateCheck")

                db.AddInParameter(dbComm, "@PWO_NO", DbType.String, objinfo.PWO_NO)
                db.AddInParameter(dbComm, "@PWO_Check", DbType.Boolean, objinfo.PWO_Check)
                db.AddInParameter(dbComm, "@PWO_CheckDate", DbType.Date, objinfo.PWO_CheckDate)
                db.AddInParameter(dbComm, "@PWO_CheckAction", DbType.String, objinfo.PWO_CheckAction)
                db.AddInParameter(dbComm, "@PWO_CheckRemark", DbType.String, objinfo.PWO_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionWareOut_UpdateCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionWareOut_UpdateCheck = False
            End Try
        End Function

        Public Function ProductionWareOut_GetList(ByVal PWO_NO As String, ByVal PWO_WareID As String, ByVal PWO_DepID As String, ByVal PWO_SubNO As String, ByVal PM_M_Code As String, ByVal PWO_M_Code As String, ByVal PWO_Type As String, ByVal PWO_AddDate1 As String, ByVal PWO_AddDate2 As String, ByVal FacID As String, ByVal PWO_Check As String) As List(Of ProductionWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareOut_GetList")

            db.AddInParameter(dbComm, "@PWO_NO", DbType.String, PWO_NO)
            db.AddInParameter(dbComm, "@PWO_WareID", DbType.String, PWO_WareID)
            db.AddInParameter(dbComm, "@PWO_DepID", DbType.String, PWO_DepID)
            db.AddInParameter(dbComm, "@PWO_SubNO", DbType.String, PWO_SubNO)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PWO_M_Code", DbType.String, PWO_M_Code)
            db.AddInParameter(dbComm, "@PWO_Type", DbType.String, PWO_Type)
            db.AddInParameter(dbComm, "@PWO_AddDate1", DbType.String, PWO_AddDate1)
            db.AddInParameter(dbComm, "@PWO_AddDate2", DbType.String, PWO_AddDate2)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@PWO_Check", DbType.String, PWO_Check)

            Dim FeatureList As New List(Of ProductionWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareOut(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionWareOut(ByVal reader As IDataReader) As ProductionWareOutInfo

            On Error Resume Next

            Dim pwoi As New ProductionWareOutInfo

            If reader("PM_JiYu") Is DBNull.Value Then
                pwoi.PM_JiYu = Nothing
            Else
                pwoi.PM_JiYu = reader("PM_JiYu")
            End If


            pwoi.PWO_NO = reader("PWO_NO").ToString
            pwoi.PWO_WareID = reader("PWO_WareID").ToString
            pwoi.PWO_DepID = reader("PWO_DepID").ToString
            pwoi.PWO_Type = reader("PWO_Type").ToString
            pwoi.PWO_Remark = reader("PWO_Remark").ToString
            pwoi.PWO_SubNO = reader("PWO_SubNO").ToString
            pwoi.PWO_SubType = reader("PWO_SubType").ToString
            pwoi.PWO_SubRemark = reader("PWO_SubRemark").ToString
            pwoi.PWO_M_Code = reader("PWO_M_Code").ToString

            pwoi.PM_M_Code = reader("PM_M_Code").ToString

            pwoi.PWO_OutName = reader("PWO_OutName").ToString
            pwoi.PWO_DepName = reader("PWO_DepName").ToString

            If reader("PWO_Qty") Is DBNull.Value Then
                pwoi.PWO_Qty = 0
            Else
                pwoi.PWO_Qty = CInt(reader("PWO_Qty"))
            End If

            If reader("PWO_AddDate") Is DBNull.Value Then
                pwoi.PWO_AddDate = Nothing
            Else
                pwoi.PWO_AddDate = CStr(reader("PWO_AddDate"))
            End If

            pwoi.PWO_CheckAction = reader("PWO_CheckAction").ToString
            pwoi.PWO_CheckRemark = reader("PWO_CheckRemark").ToString

            If reader("PWO_Check") Is DBNull.Value Then
                pwoi.PWO_Check = Nothing
            Else
                pwoi.PWO_Check = CStr(reader("PWO_Check"))
            End If

            If reader("PWO_CheckDate") Is DBNull.Value Then
                pwoi.PWO_CheckDate = Nothing
            Else
                pwoi.PWO_CheckDate = CStr(reader("PWO_CheckDate"))
            End If

            pwoi.M_Code = reader("M_Code").ToString
            pwoi.M_Gauge = reader("M_Gauge").ToString
            pwoi.M_Name = reader("M_Name").ToString
            pwoi.M_Unit = reader("M_Unit").ToString
            pwoi.PWO_ActionName = reader("PWO_ActionName").ToString
            pwoi.PWO_CheckActionName = reader("PWO_CheckActionName").ToString

            pwoi.FacID = reader("FacID").ToString
            pwoi.FacName = reader("FacName").ToString

            If reader("PM_Type") Is DBNull.Value Then
                pwoi.PM_Type = Nothing
            Else
                pwoi.PM_Type = CStr(reader("PM_Type"))
            End If

            Return pwoi

        End Function
    End Class
End Namespace
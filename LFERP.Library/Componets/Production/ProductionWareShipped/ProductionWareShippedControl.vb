Namespace LFERP.Library.Production.ProductionWareShipped
    Public Class ProductionWareShippedControl
        Public Function ProductionWareShipped_GetNo(ByVal NDate As String) As ProductionWareShippedInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_GetNo")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionWareShipped(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionWareShipped_GetSubNO(ByVal NDate As String) As ProductionWareShippedInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_GetSubNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionWareShipped(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionWareShipped_Add(ByVal objinfo As ProductionWareShippedInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_Add")
                db.AddInParameter(dbComm, "@PWS_NO", DbType.String, objinfo.PWS_NO)
                db.AddInParameter(dbComm, "@PWS_WareID", DbType.String, objinfo.PWS_WareID)
                db.AddInParameter(dbComm, "@PWS_DepID", DbType.String, objinfo.PWS_DepID)
                db.AddInParameter(dbComm, "@PWS_Remark", DbType.String, objinfo.PWS_Remark)
                db.AddInParameter(dbComm, "@PWS_SubNO", DbType.String, objinfo.PWS_SubNO)
                db.AddInParameter(dbComm, "@PWS_SubType", DbType.String, objinfo.PWS_SubType)
                db.AddInParameter(dbComm, "@PWS_SubRemark", DbType.String, objinfo.PWS_SubRemark)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PWS_M_Code", DbType.String, objinfo.PWS_M_Code)
                db.AddInParameter(dbComm, "@PWS_Qty", DbType.Int32, objinfo.PWS_Qty)
                db.AddInParameter(dbComm, "@PWS_Type", DbType.String, objinfo.PWS_Type)
                db.AddInParameter(dbComm, "@PWS_Action", DbType.String, objinfo.PWS_Action)
                db.AddInParameter(dbComm, "@PWS_AddDate", DbType.Date, objinfo.PWS_AddDate)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PWS_InWareID", DbType.String, objinfo.PWS_InWareID)

                db.ExecuteNonQuery(dbComm)

                ProductionWareShipped_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareShipped_Add = False
            End Try
        End Function

        Public Function ProductionWareShipped_Update(ByVal objinfo As ProductionWareShippedInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_Update")

                db.AddInParameter(dbComm, "@PWS_NO", DbType.String, objinfo.PWS_NO)
                db.AddInParameter(dbComm, "@PWS_WareID", DbType.String, objinfo.PWS_WareID)
                db.AddInParameter(dbComm, "@PWS_DepID", DbType.String, objinfo.PWS_DepID)
                db.AddInParameter(dbComm, "@PWS_Remark", DbType.String, objinfo.PWS_Remark)
                db.AddInParameter(dbComm, "@PWS_SubNO", DbType.String, objinfo.PWS_SubNO)
                db.AddInParameter(dbComm, "@PWS_SubType", DbType.String, objinfo.PWS_SubType)
                db.AddInParameter(dbComm, "@PWS_SubRemark", DbType.String, objinfo.PWS_SubRemark)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PWS_M_Code", DbType.String, objinfo.PWS_M_Code)
                db.AddInParameter(dbComm, "@PWS_Qty", DbType.Int32, objinfo.PWS_Qty)
                db.AddInParameter(dbComm, "@PWS_Type", DbType.String, objinfo.PWS_Type)
                db.AddInParameter(dbComm, "@PWS_Action", DbType.String, objinfo.PWS_Action)
                db.AddInParameter(dbComm, "@PWS_AddDate", DbType.Date, objinfo.PWS_AddDate)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PWS_InWareID", DbType.String, objinfo.PWS_InWareID)

                db.ExecuteNonQuery(dbComm)
                ProductionWareShipped_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareShipped_Update = False

            End Try

        End Function

        Public Function ProductionWareShipped_Delete(ByVal PWS_NO As String, ByVal PWS_SubNO As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_Delete")

                db.AddInParameter(dbComm, "@PWS_NO", DbType.String, PWS_NO)
                db.AddInParameter(dbComm, "@PWS_SubNO", DbType.String, PWS_SubNO)

                db.ExecuteNonQuery(dbComm)
                ProductionWareShipped_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareShipped_Delete = False
            End Try
        End Function



        Public Function ProductionWareShipped_UpdateCheck(ByVal objinfo As ProductionWareShippedInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_UpdateCheck")

                db.AddInParameter(dbComm, "@PWS_NO", DbType.String, objinfo.PWS_NO)
                db.AddInParameter(dbComm, "@PWS_Check", DbType.Boolean, objinfo.PWS_Check)
                db.AddInParameter(dbComm, "@PWS_CheckDate", DbType.Date, objinfo.PWS_CheckDate)
                db.AddInParameter(dbComm, "@PWS_CheckAction", DbType.String, objinfo.PWS_CheckAction)
                db.AddInParameter(dbComm, "@PWS_CheckRemark", DbType.String, objinfo.PWS_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionWareShipped_UpdateCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionWareShipped_UpdateCheck = False
            End Try
        End Function
        Public Function ProductionWareShipped_UpdateInCheck(ByVal objinfo As ProductionWareShippedInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_UpdateInCheck")

                db.AddInParameter(dbComm, "@PWS_NO", DbType.String, objinfo.PWS_NO)
                db.AddInParameter(dbComm, "@PWS_InCheck", DbType.Boolean, objinfo.PWS_InCheck)
                db.AddInParameter(dbComm, "@PWS_InAction", DbType.String, objinfo.PWS_InAction)
                db.AddInParameter(dbComm, "@PWS_InAddDate", DbType.Date, objinfo.PWS_InAddDate)

                db.ExecuteNonQuery(dbComm)
                ProductionWareShipped_UpdateInCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionWareShipped_UpdateInCheck = False
            End Try
        End Function


        Public Function ProductionWareShipped_GetList(ByVal PWS_NO As String, ByVal PWS_WareID As String, ByVal PWS_DepID As String, ByVal PWS_SubNO As String, ByVal PM_M_Code As String, ByVal PWS_M_Code As String, ByVal PWS_Type As String, ByVal PWS_AddDate1 As String, ByVal PWS_AddDate2 As String, ByVal FacID As String, ByVal PWS_Check As String, ByVal PWS_InCheck As String, ByVal SelectOutWare As String, ByVal SelectInWare As String) As List(Of ProductionWareShippedInfo)


            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_GetList")

            db.AddInParameter(dbComm, "@PWS_NO", DbType.String, PWS_NO)
            db.AddInParameter(dbComm, "@PWS_WareID", DbType.String, PWS_WareID)
            db.AddInParameter(dbComm, "@PWS_DepID", DbType.String, PWS_DepID)
            db.AddInParameter(dbComm, "@PWS_SubNO", DbType.String, PWS_SubNO)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PWS_M_Code", DbType.String, PWS_M_Code)
            db.AddInParameter(dbComm, "@PWS_Type", DbType.String, PWS_Type)
            db.AddInParameter(dbComm, "@PWS_AddDate1", DbType.String, PWS_AddDate1)

            db.AddInParameter(dbComm, "@PWS_AddDate2", DbType.String, PWS_AddDate2)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@PWS_Check", DbType.String, PWS_Check)
            db.AddInParameter(dbComm, "@PWS_InCheck", DbType.String, PWS_InCheck)
            db.AddInParameter(dbComm, "@SelectOutWare", DbType.String, SelectOutWare)
            db.AddInParameter(dbComm, "@SelectInWare", DbType.String, SelectInWare)

            Dim FeatureList As New List(Of ProductionWareShippedInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareShipped(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''綜合報表
        Public Function ProductionTHreeTable_GetList(ByVal TableNum As String, ByVal StratDate As String, ByVal EndDate As String) As List(Of ProductionWareShippedInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionTHreeTable_GetList")

            db.AddInParameter(dbComm, "@TableNum", DbType.Int16, TableNum)
            db.AddInParameter(dbComm, "@StratDate", DbType.Date, StratDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.Date, EndDate)

            Dim FeatureList As New List(Of ProductionWareShippedInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareShipped(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionWareShipped(ByVal reader As IDataReader) As ProductionWareShippedInfo
            On Error Resume Next
            Dim PWSi As New ProductionWareShippedInfo

            If reader("PM_JiYu") Is DBNull.Value Then
                PWSi.PM_JiYu = Nothing
            Else
                PWSi.PM_JiYu = reader("PM_JiYu")
            End If
            PWSi.PWS_NO = reader("PWS_NO").ToString
            PWSi.PWS_WareID = reader("PWS_WareID").ToString
            PWSi.PWS_DepID = reader("PWS_DepID").ToString
            PWSi.PWS_Type = reader("PWS_Type").ToString
            PWSi.PWS_Remark = reader("PWS_Remark").ToString
            PWSi.PWS_SubNO = reader("PWS_SubNO").ToString
            PWSi.PWS_SubType = reader("PWS_SubType").ToString
            PWSi.PWS_SubRemark = reader("PWS_SubRemark").ToString
            PWSi.PWS_M_Code = reader("PWS_M_Code").ToString

            PWSi.PM_M_Code = reader("PM_M_Code").ToString

            PWSi.PWS_OutName = reader("PWS_OutName").ToString
            PWSi.PWS_DepName = reader("PWS_DepName").ToString

            If reader("PWS_Qty") Is DBNull.Value Then
                PWSi.PWS_Qty = 0
            Else
                PWSi.PWS_Qty = CInt(reader("PWS_Qty"))
            End If
            If reader("Qty") Is DBNull.Value Then
                PWSi.Qty = 0
            Else
                PWSi.Qty = CInt(reader("Qty"))
            End If

            If reader("PWS_AddDate") Is DBNull.Value Then
                PWSi.PWS_AddDate = Nothing
            Else
                PWSi.PWS_AddDate = CStr(reader("PWS_AddDate"))
            End If

            PWSi.PWS_CheckAction = reader("PWS_CheckAction").ToString
            PWSi.PWS_CheckRemark = reader("PWS_CheckRemark").ToString

            If reader("PWS_Check") Is DBNull.Value Then
                PWSi.PWS_Check = Nothing
            Else
                PWSi.PWS_Check = CStr(reader("PWS_Check"))
            End If

            If reader("PWS_CheckDate") Is DBNull.Value Then
                PWSi.PWS_CheckDate = Nothing
            Else
                PWSi.PWS_CheckDate = CStr(reader("PWS_CheckDate"))
            End If

            PWSi.M_Code = reader("M_Code").ToString
            PWSi.M_Gauge = reader("M_Gauge").ToString
            PWSi.M_Name = reader("M_Name").ToString
            PWSi.M_Unit = reader("M_Unit").ToString
            PWSi.PWS_ActionName = reader("PWS_ActionName").ToString
            PWSi.PWS_CheckActionName = reader("PWS_CheckActionName").ToString

            PWSi.FacID = reader("FacID").ToString
            PWSi.FacName = reader("FacName").ToString

            If reader("PM_Type") Is DBNull.Value Then
                PWSi.PM_Type = Nothing
            Else
                PWSi.PM_Type = CStr(reader("PM_Type"))
            End If
            '------------------李超
            PWSi.PWS_InName = reader("PWS_InName").ToString
            PWSi.PWS_InWareID = reader("PWS_InWareID").ToString
            PWSi.PWS_InAction = reader("PWS_InAction").ToString
            PWSi.PWS_InActionName = reader("PWS_InActionName").ToString

            PWSi.InName = reader("InName").ToString
            PWSi.OutName = reader("OutName").ToString

            If reader("PWS_InAddDate") Is DBNull.Value Then
                PWSi.PWS_InAddDate = Nothing
            Else
                PWSi.PWS_InAddDate = CStr(reader("PWS_InAddDate"))
            End If

            If reader("PWS_InCheck") Is DBNull.Value Then
                PWSi.PWS_InCheck = Nothing
            Else
                PWSi.PWS_InCheck = CStr(reader("PWS_InCheck"))
            End If
            '--------------------------
            PWSi.PWS_EndQty = reader("PWS_EndQty")
            PWSi.PWS_EndQty1 = reader("PWS_EndQty1")
            PWSi.AutoID = reader("AutoID")

            Return PWSi

        End Function


        Public Function ProductionWareShipped_UpdateInCheck1(ByVal objinfo As ProductionWareShippedInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_UpdateInCheck1")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PWS_InCheck", DbType.Boolean, objinfo.PWS_InCheck)
                db.AddInParameter(dbComm, "@PWS_InAction", DbType.String, objinfo.PWS_InAction)
                db.AddInParameter(dbComm, "@PWS_InAddDate", DbType.Date, objinfo.PWS_InAddDate)

                db.AddInParameter(dbComm, "@PWS_EndQty", DbType.Double, objinfo.PWS_EndQty)  '--收料的節余
                db.AddInParameter(dbComm, "@PWS_EndQty1", DbType.Double, objinfo.PWS_EndQty1) '--發料節余  

                db.ExecuteNonQuery(dbComm)
                ProductionWareShipped_UpdateInCheck1 = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionWareShipped_UpdateInCheck1 = False
            End Try
        End Function


        Public Function ProductionWareShipped_GetListTop50(ByVal PWS_NO As String, ByVal PWS_WareID As String, ByVal PWS_DepID As String, ByVal PWS_SubNO As String, ByVal PM_M_Code As String, ByVal PWS_M_Code As String, ByVal PWS_Type As String, ByVal PWS_AddDate1 As String, ByVal PWS_AddDate2 As String, ByVal FacID As String, ByVal PWS_Check As String, ByVal PWS_InCheck As String, ByVal SelectOutWare As String, ByVal SelectInWare As String) As List(Of ProductionWareShippedInfo)


            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareShipped_GetListTop50")

            db.AddInParameter(dbComm, "@PWS_NO", DbType.String, PWS_NO)
            db.AddInParameter(dbComm, "@PWS_WareID", DbType.String, PWS_WareID)
            db.AddInParameter(dbComm, "@PWS_DepID", DbType.String, PWS_DepID)
            db.AddInParameter(dbComm, "@PWS_SubNO", DbType.String, PWS_SubNO)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PWS_M_Code", DbType.String, PWS_M_Code)
            db.AddInParameter(dbComm, "@PWS_Type", DbType.String, PWS_Type)
            db.AddInParameter(dbComm, "@PWS_AddDate1", DbType.String, PWS_AddDate1)

            db.AddInParameter(dbComm, "@PWS_AddDate2", DbType.String, PWS_AddDate2)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@PWS_Check", DbType.String, PWS_Check)
            db.AddInParameter(dbComm, "@PWS_InCheck", DbType.String, PWS_InCheck)
            db.AddInParameter(dbComm, "@SelectOutWare", DbType.String, SelectOutWare)
            db.AddInParameter(dbComm, "@SelectInWare", DbType.String, SelectInWare)

            Dim FeatureList As New List(Of ProductionWareShippedInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareShipped(reader))
                End While
                Return FeatureList
            End Using
        End Function


    End Class
End Namespace
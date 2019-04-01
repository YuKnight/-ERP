Namespace LFERP.Library.SampleManager.SampInventoryCheck
    Public Class SampInventoryCheckControl
        Public Function SampInventoryCheck_Add(ByVal objinfo As SampInventoryCheckInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheck_Add")

                db.AddInParameter(dbComm, "@CheckNO", DbType.String, objinfo.CheckNO)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int32, objinfo.Qty)
                db.AddInParameter(dbComm, "@CheckAction", DbType.String, objinfo.CheckAction)
                db.AddInParameter(dbComm, "@CheckDate", DbType.String, objinfo.CheckDate)

                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objinfo.D_ID)

                db.ExecuteNonQuery(dbComm)
                SampInventoryCheck_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampInventoryCheck_Add = False
            End Try
        End Function

        Public Function SampInventoryCheck_Update(ByVal objinfo As SampInventoryCheckInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheck_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@CheckNO", DbType.String, objinfo.CheckNO)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int32, objinfo.Qty)
                db.AddInParameter(dbComm, "@CheckAction", DbType.String, objinfo.CheckAction)

                db.AddInParameter(dbComm, "@CheckDate", DbType.String, objinfo.CheckDate)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objinfo.D_ID)

                db.ExecuteNonQuery(dbComm)
                SampInventoryCheck_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampInventoryCheck_Update = False
            End Try
        End Function

        Public Function SampleInventoryTatalA_GetList(ByVal PM_M_Code As String, ByVal MaterialTypeID As String, ByVal D_ID As String) As DataTable
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleInventoryTatalA_GetList")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)

                ds = db.ExecuteDataSet(dbComm)
                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function SampleInventoryTatalB_GetList(ByVal PM_M_Code As String, ByVal MaterialTypeID As String, ByVal BitPutInTotalQty As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleInventoryTatalB_GetList")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
                db.AddInParameter(dbComm, "@BitPutInTotalQty", DbType.Boolean, BitPutInTotalQty)

                ds = db.ExecuteDataSet(dbComm)
                ds.Tables(0).TableName = "SampleInventoryTatalB"
                If ds.Tables.Count > 0 Then
                    Return ds
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function SampleWareInventoryAnnal2_GetList(ByVal PM_M_Code As String, ByVal PS_NO As String, ByVal D_ID As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleWareInventoryAnnal2_GetList")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)

                ds = db.ExecuteDataSet(dbComm)
                ds.Tables(0).TableName = "SampleWareInventoryAnnal2"
                If ds.Tables.Count > 0 Then
                    Return ds
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function SampleWareInventoryAnnal3_GetList(ByVal PM_M_Code As String, ByVal PS_NO As String, ByVal D_ID As String, ByVal StratDate As String, ByVal EndDate As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleWareInventoryAnnal3_GetList")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)
                db.AddInParameter(dbComm, "@StratDate", DbType.String, StratDate)
                db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)

                ds = db.ExecuteDataSet(dbComm)
                ds.Tables(0).TableName = "SampleWareInventoryAnnal3"
                If ds.Tables.Count > 0 Then
                    Return ds
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function SampleWareInventoryAnnal4_GetList(ByVal PM_M_Code As String, ByVal PS_NO As String, ByVal D_ID As String, ByVal StrD_IDM As String, ByVal StrD_IDN As String, ByVal StratDate As String, ByVal EndDate As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleWareInventoryAnnal4_GetList")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)
                db.AddInParameter(dbComm, "@StrD_IDM", DbType.String, StrD_IDM)
                db.AddInParameter(dbComm, "@StrD_IDN", DbType.String, StrD_IDN)
                db.AddInParameter(dbComm, "@StratDate", DbType.String, StratDate)
                db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)

                ds = db.ExecuteDataSet(dbComm)
                ds.Tables(0).TableName = "SampleWareInventoryAnnal3"
                If ds.Tables.Count > 0 Then
                    Return ds
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function SampleInventoryTatalC_GetList(ByVal PM_M_Code As String, ByVal MaterialTypeID As String, ByVal BitPutInTotalQty As String) As DataSet
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleInventoryTatalC_GetList")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
                db.AddInParameter(dbComm, "@BitPutInTotalQty", DbType.Boolean, BitPutInTotalQty)


                ds = db.ExecuteDataSet(dbComm)
                ds.Tables(0).TableName = "SampleInventoryTatalC"
                If ds.Tables.Count > 0 Then
                    Return ds
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function SampleInventoryTatalD_GetList(ByVal M_Code_Type As String, ByVal MaterialTypeID As String, ByVal D_ID As String) As DataTable
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleInventoryTatalD_GetList")
                db.AddInParameter(dbComm, "@M_Code_Type", DbType.String, M_Code_Type)
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)

                ds = db.ExecuteDataSet(dbComm)
                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function
        Public Function SampleInventoryTatalE_GetList(ByVal PM_M_Code As String, ByVal MaterialTypeID As String, ByVal BitPutInTotalQty As String) As DataTable
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleInventoryTatalE_GetList")
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@MaterialTypeID", DbType.String, MaterialTypeID)
                db.AddInParameter(dbComm, "@BitPutInTotalQty", DbType.Boolean, BitPutInTotalQty)


                ds = db.ExecuteDataSet(dbComm)
                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function



        Public Function SampInventoryCheck_Delete(ByVal AutoID As String, ByVal CheckNO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheck_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@CheckNO", DbType.String, CheckNO)

                db.ExecuteNonQuery(dbComm)
                SampInventoryCheck_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampInventoryCheck_Delete = False
            End Try
        End Function

        Public Function SampInventoryCheck_UpdateCheck(ByVal objinfo As SampInventoryCheckInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheck_UpdateCheck")

                db.AddInParameter(dbComm, "@CheckNO", DbType.String, objinfo.CheckNO)
                db.AddInParameter(dbComm, "@CCheck", DbType.Boolean, objinfo.CCheck)
                db.AddInParameter(dbComm, "@CCheckAction", DbType.String, objinfo.CCheckAction)
                db.AddInParameter(dbComm, "@CCheckDate", DbType.String, objinfo.CCheckDate)

                db.ExecuteNonQuery(dbComm)
                SampInventoryCheck_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampInventoryCheck_UpdateCheck = False
            End Try
        End Function
        Public Function SampInventoryCheck_UpdateAnalysis(ByVal objinfo As SampInventoryCheckInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheck_UpdateAnalysis")

                db.AddInParameter(dbComm, "@CheckNO", DbType.String, objinfo.CheckNO)
                db.AddInParameter(dbComm, "@AnalysisCheck", DbType.Boolean, objinfo.AnalysisCheck)
                db.AddInParameter(dbComm, "@AnalysisAction", DbType.String, objinfo.AnalysisAction)
                db.AddInParameter(dbComm, "@AnalysisDate", DbType.String, objinfo.AnalysisDate)

                db.ExecuteNonQuery(dbComm)
                SampInventoryCheck_UpdateAnalysis = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampInventoryCheck_UpdateAnalysis = False
            End Try
        End Function


        Public Function SampInventoryCheck_GetID(ByVal CheckNOType As String) As SampInventoryCheckInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheck_GetID")
            db.AddInParameter(dbComm, "@CheckNOType", DbType.String, CheckNOType)
            Dim FeatureList As New SampInventoryCheckInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.CheckNO = reader("CheckNO").ToString
                End While
                Return FeatureList
            End Using
        End Function


        Public Function SampInventoryCheck_GetList(ByVal AutoID As String, ByVal CheckNO As String, ByVal Code_ID As String, ByVal CheckDate1 As String, ByVal CheckDate2 As String, ByVal CCheck As String) As List(Of SampInventoryCheckInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheck_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@CheckNO", DbType.String, CheckNO)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)

            db.AddInParameter(dbComm, "@CheckDate1", DbType.String, CheckDate1)
            db.AddInParameter(dbComm, "@CheckDate2", DbType.String, CheckDate2)
            db.AddInParameter(dbComm, "@CCheck", DbType.String, CCheck)

            Dim FeatureList As New List(Of SampInventoryCheckInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampInventoryCheck(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function SampInventoryCheckUpdate_GetList(ByVal Code_ID As String) As List(Of SampInventoryCheckInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckUpdate_GetList")

            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)

            Dim FeatureList As New List(Of SampInventoryCheckInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampInventoryCheck(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampInventoryCheckMain_GetList(ByVal CheckNO As String) As List(Of SampInventoryCheckInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckMain_GetList")
            db.AddInParameter(dbComm, "@CheckNO", DbType.String, CheckNO)

            Dim FeatureList As New List(Of SampInventoryCheckInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampInventoryCheck(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function FillSampInventoryCheck(ByVal reader As IDataReader) As SampInventoryCheckInfo
            On Error Resume Next

            Dim objInfo As New SampInventoryCheckInfo
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.CheckNO = reader("CheckNO").ToString
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.Qty = reader("Qty")
            objInfo.CheckDate = CDate(reader("CheckDate").ToString)

            objInfo.CheckAction = reader("CheckAction").ToString
            objInfo.CheckActionName = reader("CheckActionName").ToString
            objInfo.CCheckActionName = reader("CCheckActionName").ToString

            objInfo.AnalysisCheck = reader("AnalysisCheck")
            objInfo.AnalysisAction = reader("AnalysisAction").ToString
            objInfo.AnalysisDate = CDate(reader("AnalysisDate").ToString)
            objInfo.AnalysisActionName = reader("AnalysisActionName").ToString

            objInfo.Remark = reader("Remark").ToString


            objInfo.CCheck = reader("CCheck")
            objInfo.CCheckAction = reader("CCheckAction").ToString
            objInfo.CCheckDate = CDate(reader("CCheckDate").ToString)
            objInfo.D_ID = reader("D_ID").ToString
            objInfo.D_Dep = reader("D_Dep").ToString



            ''0-----------------------------------

            objInfo.OutD_ID = reader("OutD_ID").ToString
            objInfo.InD_ID = reader("InD_ID").ToString
            objInfo.OutPS_NO = reader("OutPS_NO").ToString
            objInfo.InPS_NO = reader("InPS_NO").ToString
            objInfo.AddDate = reader("AddDate")
            objInfo.AddAction = reader("AddAction").ToString

            objInfo.OutD_ID_Name = reader("OutD_ID_Name").ToString
            objInfo.InD_ID_Name = reader("InD_ID_Name").ToString
            objInfo.OutPS_Name = reader("OutPS_Name").ToString
            objInfo.InPS_Name = reader("InPS_Name").ToString
            objInfo.AddActionName = reader("AddActionName").ToString


            Return objInfo
        End Function

#Region "ªì¨Ï¤Æ"
        Public Function SampInventoryCheckLogin_GetList(ByVal Code_ID As String, ByVal OutD_ID As String, ByVal InD_ID As String, ByVal OutPS_NO As String, ByVal InPS_NO As String, ByVal AddDateS As String, ByVal AddDateE As String) As List(Of SampInventoryCheckInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckLogin_GetList")


            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@OutD_ID", DbType.String, OutD_ID)
            db.AddInParameter(dbComm, "@InD_ID", DbType.String, InD_ID)

            db.AddInParameter(dbComm, "@OutPS_NO", DbType.String, OutPS_NO)
            db.AddInParameter(dbComm, "@InPS_NO", DbType.String, InPS_NO)
            db.AddInParameter(dbComm, "@AddDateS", DbType.String, AddDateS)

            db.AddInParameter(dbComm, "@AddDateE", DbType.String, AddDateE)

            Dim FeatureList As New List(Of SampInventoryCheckInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampInventoryCheck(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampInventoryCheckLoginTime_GetList(ByVal Code_ID As String) As List(Of SampInventoryCheckInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckLoginTime_GetList")

            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)

            Dim FeatureList As New List(Of SampInventoryCheckInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampInventoryCheck(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampInventoryCheckLogin_Add(ByVal objinfo As SampInventoryCheckInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckLogin_Add")

                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@OutD_ID", DbType.String, objinfo.OutD_ID)
                db.AddInParameter(dbComm, "@InD_ID", DbType.String, objinfo.InD_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int32, objinfo.Qty)
                db.AddInParameter(dbComm, "@OutPS_NO", DbType.String, objinfo.OutPS_NO)

                db.AddInParameter(dbComm, "@InPS_NO", DbType.String, objinfo.InPS_NO)
                db.AddInParameter(dbComm, "@AddDate", DbType.DateTime, objinfo.AddDate)
                db.AddInParameter(dbComm, "@AddAction", DbType.String, objinfo.AddAction)

                db.ExecuteNonQuery(dbComm)
                SampInventoryCheckLogin_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampInventoryCheckLogin_Add = False
            End Try
        End Function



#End Region





#Region "®t²§¤ÀªR"
        Public Function SampInventoryCheckChaYi_Add(ByVal objinfo As SampInventoryCheckInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckChaYi_Add")

                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int32, objinfo.Qty)
                db.AddInParameter(dbComm, "@CheckNO", DbType.String, objinfo.CheckNO)
                db.AddInParameter(dbComm, "@Status", DbType.String, objinfo.Status)

                db.ExecuteNonQuery(dbComm)
                SampInventoryCheckChaYi_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampInventoryCheckChaYi_Add = False
            End Try
        End Function

        Public Function SampInventoryCheckChaYi_Delete(ByVal CheckNO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckChaYi_Delete")

                db.AddInParameter(dbComm, "@CheckNO", DbType.String, CheckNO)

                db.ExecuteNonQuery(dbComm)
                SampInventoryCheckChaYi_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampInventoryCheckChaYi_Delete = False
            End Try
        End Function

        Public Function SampInventoryCheckChaYi_GetList(ByVal CheckNO As String, ByVal Code_ID As String) As List(Of SampInventoryCheckInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckChaYi_GetList")

            db.AddInParameter(dbComm, "@CheckNO", DbType.String, CheckNO)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)

            Dim FeatureList As New List(Of SampInventoryCheckInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampInventoryCheckChaYi(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampInventoryCheckChaYiFX_GetList(ByVal CheckNO As String) As List(Of SampInventoryCheckInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckChaYiFX_GetList")

            db.AddInParameter(dbComm, "@CheckNO", DbType.String, CheckNO)

            Dim FeatureList As New List(Of SampInventoryCheckInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampInventoryCheckChaYi(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampInventoryCheckChaYiFX_GetList1(ByVal CheckNO As String, ByVal Type As String) As List(Of SampInventoryCheckInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampInventoryCheckChaYiFX_GetList1")

            db.AddInParameter(dbComm, "@CheckNO", DbType.String, CheckNO)
            db.AddInParameter(dbComm, "@Type", DbType.String, Type)

            Dim FeatureList As New List(Of SampInventoryCheckInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampInventoryCheckChaYi(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillSampInventoryCheckChaYi(ByVal reader As IDataReader) As SampInventoryCheckInfo
            On Error Resume Next

            Dim objInfo As New SampInventoryCheckInfo
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.CheckNO = reader("CheckNO").ToString
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.Qty = reader("Qty")
            objInfo.Status = reader("Status").ToString

            objInfo.InVentQty = reader("InVentQty")
            objInfo.QtyReal = reader("QtyReal")

            Return objInfo
        End Function




#End Region


    End Class
End Namespace








   

 



Namespace LFERP.Library.ProductionRetrocede

    Public Class ProductionRetrocedeControl
        ''' <summary>
        ''' 退貨單號
        ''' </summary>
        ''' <param name="NDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionRetrocede_GetRNO(ByVal NDate As String) As ProductionRetrocedeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_GetRNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionRetrocede(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 補退貨單號
        ''' </summary>
        ''' <param name="NDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionRetrocede_GetMRNO(ByVal NDate As String) As ProductionRetrocedeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_GetMRNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionRetrocede(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionRetrocede_Add(ByVal objinfo As ProductionRetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_Add")

                db.AddInParameter(dbComm, "@R_NO", DbType.String, objinfo.R_NO)
                db.AddInParameter(dbComm, "@R_Type", DbType.String, objinfo.R_Type)
                db.AddInParameter(dbComm, "@WH_OutID", DbType.String, objinfo.WH_OutID)
                db.AddInParameter(dbComm, "@WH_InID", DbType.String, objinfo.WH_InID)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@R_NoSendQty", DbType.Single, objinfo.R_NoSendQty)
                db.AddInParameter(dbComm, "@R_Qty", DbType.Single, objinfo.R_Qty)
                db.AddInParameter(dbComm, "@R_Remark", DbType.String, objinfo.R_Remark)
                db.AddInParameter(dbComm, "@R_Date", DbType.Date, objinfo.R_Date)
                db.AddInParameter(dbComm, "@R_Detail", DbType.String, objinfo.R_Detail)
                db.AddInParameter(dbComm, "@R_Action", DbType.String, objinfo.R_Action)

                db.ExecuteNonQuery(dbComm)
                ProductionRetrocede_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionRetrocede_Add = False
            End Try

        End Function

        Public Function ProductionRetrocede_Update(ByVal objinfo As ProductionRetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_Update")


                db.AddInParameter(dbComm, "@IndexNO", DbType.String, objinfo.IndexNO)
                db.AddInParameter(dbComm, "@R_NO", DbType.String, objinfo.R_NO)
                db.AddInParameter(dbComm, "@R_Type", DbType.String, objinfo.R_Type)
                db.AddInParameter(dbComm, "@WH_OutID", DbType.String, objinfo.WH_OutID)
                db.AddInParameter(dbComm, "@WH_InID", DbType.String, objinfo.WH_InID)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@R_NoSendQty", DbType.Single, objinfo.R_NoSendQty)
                db.AddInParameter(dbComm, "@R_Qty", DbType.Single, objinfo.R_Qty)
                db.AddInParameter(dbComm, "@R_Remark", DbType.String, objinfo.R_Remark)
                db.AddInParameter(dbComm, "@R_Date", DbType.Date, objinfo.R_Date)
                db.AddInParameter(dbComm, "@R_Detail", DbType.String, objinfo.R_Detail)
                db.AddInParameter(dbComm, "@R_Action", DbType.String, objinfo.R_Action)

                db.ExecuteNonQuery(dbComm)
                ProductionRetrocede_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionRetrocede_Update = False
            End Try

        End Function

        Public Function ProductionRetrocede_Delete(ByVal IndexNO As String, ByVal R_NO As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_Delete")

                db.AddInParameter(dbComm, "@IndexNO", DbType.String, IndexNO)
                db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionRetrocede_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionRetrocede_Delete = False
            End Try

        End Function

        Public Function ProductionRetrocede_UpdateCheck(ByVal objinfo As ProductionRetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_UpdateCheck")

                db.AddInParameter(dbComm, "@IndexNO", DbType.String, objinfo.IndexNO)
                db.AddInParameter(dbComm, "@R_Check", DbType.Boolean, objinfo.R_Check)
                db.AddInParameter(dbComm, "@R_CheckAction", DbType.String, objinfo.R_CheckAction)
                db.AddInParameter(dbComm, "@R_CheckDate", DbType.Date, objinfo.R_CheckDate)
                db.AddInParameter(dbComm, "@R_CheckRemark", DbType.String, objinfo.R_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionRetrocede_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionRetrocede_UpdateCheck = False
            End Try
        End Function

        Public Function ProductionRetrocede_GetList(ByVal R_NO As String, ByVal IndexNO As String, ByVal R_Type As String, ByVal WH_OutID As String, ByVal WH_InID As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal R_Check As String) As List(Of ProductionRetrocedeInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_GetList")


            db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbComm, "@IndexNO", DbType.String, IndexNO)
            db.AddInParameter(dbComm, "@R_Type", DbType.String, R_Type)
            db.AddInParameter(dbComm, "@WH_OutID", DbType.String, WH_OutID)
            db.AddInParameter(dbComm, "@WH_InID", DbType.String, WH_InID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@R_Check", DbType.String, R_Check)

            Dim FeatureList As New List(Of ProductionRetrocedeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionRetrocede(reader))
                End While
                Return FeatureList
            End Using


        End Function


        Public Function FillProductionRetrocede(ByVal reader As IDataReader) As ProductionRetrocedeInfo
            On Error Resume Next

            Dim pri As New ProductionRetrocedeInfo

            pri.IndexNO = reader("IndexNO").ToString
            pri.R_NO = reader("R_NO").ToString
            pri.R_Type = reader("R_Type").ToString
            pri.WH_OutID = reader("WH_OutID").ToString
            pri.WH_InID = reader("WH_InID").ToString
            pri.Pro_Type = reader("Pro_Type").ToString
            pri.PM_M_Code = reader("PM_M_Code").ToString
            pri.PM_Type = reader("PM_Type").ToString
            'pri.Pro_NO = reader("Pro_NO").ToString

            pri.R_Qty = CSng(reader("R_Qty").ToString)
            pri.R_NoSendQty = CSng(reader("R_NoSendQty").ToString)

            If reader("R_Date") Is DBNull.Value Then
                pri.R_Date = Nothing
            Else
                pri.R_Date = CStr(reader("R_Date"))
            End If

            pri.R_Detail = reader("R_Detail").ToString
            pri.R_Remark = reader("R_Remark").ToString
            pri.R_Action = reader("R_Action").ToString

            If reader("R_Check") Is DBNull.Value Then
                pri.R_Check = Nothing
            Else
                pri.R_Check = CStr(reader("R_Check"))
            End If
            pri.R_CheckAction = reader("R_CheckAction").ToString

            If reader("R_CheckDate") Is DBNull.Value Then
                pri.R_CheckDate = Nothing
            Else
                pri.R_CheckDate = CStr(reader("R_CheckDate"))
            End If
            pri.R_CheckRemark = reader("R_CheckRemark").ToString

            pri.ActionName = reader("ActionName").ToString

            pri.CheckActionName = reader("CheckActionName").ToString
            pri.WH_Name = reader("WH_Name").ToString
            pri.WH_InName = reader("WH_InName").ToString
            'pri.PS_Name = reader("PS_Name").ToString

            pri.R_InCheck = reader("R_InCheck")
            pri.R_InCheckAction = reader("R_InCheckAction").ToString
            pri.R_InCheckDate = reader("R_InCheckDate")
            pri.R_InCheckRemark = reader("R_InCheckRemark").ToString
            pri.R_InCheckActionName = reader("R_InCheckActionName").ToString


            Return pri

        End Function


#Region "收料"
        Public Function ProductionRetrocede_UpdateInCheck(ByVal objinfo As ProductionRetrocedeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_UpdateInCheck")

                db.AddInParameter(dbComm, "@IndexNO", DbType.String, objinfo.IndexNO)
                db.AddInParameter(dbComm, "@R_InCheck", DbType.Boolean, objinfo.R_InCheck)
                db.AddInParameter(dbComm, "@R_InCheckAction", DbType.String, objinfo.R_InCheckAction)
                db.AddInParameter(dbComm, "@R_InCheckDate", DbType.Date, objinfo.R_InCheckDate)
                db.AddInParameter(dbComm, "@R_InCheckRemark", DbType.String, objinfo.R_InCheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionRetrocede_UpdateInCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionRetrocede_UpdateInCheck = False
            End Try
        End Function


        Public Function ProductionRetrocede_GetList1(ByVal R_NO As String, ByVal IndexNO As String, ByVal R_Type As String, ByVal WH_OutID As String, ByVal WH_InID As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal R_Check As String, ByVal R_InCheck As String) As List(Of ProductionRetrocedeInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_GetList1")


            db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbComm, "@IndexNO", DbType.String, IndexNO)
            db.AddInParameter(dbComm, "@R_Type", DbType.String, R_Type)
            db.AddInParameter(dbComm, "@WH_OutID", DbType.String, WH_OutID)
            db.AddInParameter(dbComm, "@WH_InID", DbType.String, WH_InID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@R_Check", DbType.String, R_Check)

            db.AddInParameter(dbComm, "@R_InCheck", DbType.String, R_InCheck)

            Dim FeatureList As New List(Of ProductionRetrocedeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionRetrocede(reader))
                End While
                Return FeatureList
            End Using


        End Function


        Public Function ProductionRetrocede_GetList2(ByVal R_NO As String, ByVal IndexNO As String, ByVal R_Type As String, ByVal WH_OutID As String, _
        ByVal WH_InID As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, _
        ByVal R_Check As String, ByVal R_InCheck As String, ByVal Type As String, ByVal R_Date1 As String, ByVal R_Date2 As String) As List(Of ProductionRetrocedeInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_GetList2")

            db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbComm, "@IndexNO", DbType.String, IndexNO)
            db.AddInParameter(dbComm, "@R_Type", DbType.String, R_Type)
            db.AddInParameter(dbComm, "@WH_OutID", DbType.String, WH_OutID)
            db.AddInParameter(dbComm, "@WH_InID", DbType.String, WH_InID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@R_Check", DbType.String, R_Check)

            db.AddInParameter(dbComm, "@R_InCheck", DbType.String, R_InCheck)
            db.AddInParameter(dbComm, "@Type", DbType.String, Type)
            db.AddInParameter(dbComm, "@R_Date1", DbType.String, R_Date1)
            db.AddInParameter(dbComm, "@R_Date2", DbType.String, R_Date2)

            Dim FeatureList As New List(Of ProductionRetrocedeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionRetrocede(reader))
                End While
                Return FeatureList
            End Using
        End Function



#End Region



    End Class

End Namespace






Namespace LFERP.Library.ProductionReturn

    Public Class ProductionReturnControl

        ''' <summary>
        ''' 接收退貨單號
        ''' </summary>
        ''' <param name="NDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionReturn_GetRNO(ByVal NDate As String) As ProductionReturnInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_GetRNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionReturn(reader)
                End While
                Return Nothing
            End Using
        End Function

        ''' <summary>
        ''' 接收補退貨單號
        ''' </summary>
        ''' <param name="NDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionReturn_GetMRNO(ByVal NDate As String) As ProductionReturnInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_GetMRNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionReturn(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionReturn_Add(ByVal objinfo As ProductionReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_Add")

                db.AddInParameter(dbComm, "@AR_NO", DbType.String, objinfo.AR_NO)
                db.AddInParameter(dbComm, "@R_NO", DbType.String, objinfo.R_NO)
                db.AddInParameter(dbComm, "@AR_Type", DbType.String, objinfo.AR_Type)
                db.AddInParameter(dbComm, "@WH_OutID", DbType.String, objinfo.WH_OutID)
                db.AddInParameter(dbComm, "@WH_InID", DbType.String, objinfo.WH_InID)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                'db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@AR_Qty", DbType.Single, objinfo.AR_Qty)
                db.AddInParameter(dbComm, "@AR_Remark", DbType.String, objinfo.AR_Remark)
                db.AddInParameter(dbComm, "@AR_Date", DbType.Date, objinfo.AR_Date)
                db.AddInParameter(dbComm, "@AR_Detail", DbType.String, objinfo.AR_Detail)
                db.AddInParameter(dbComm, "@AR_Action", DbType.String, objinfo.AR_Action)

                db.ExecuteNonQuery(dbComm)
                ProductionReturn_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionReturn_Add = False
            End Try

        End Function

        Public Function ProductionReturn_Update(ByVal objinfo As ProductionReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@AR_NO", DbType.String, objinfo.AR_NO)
                db.AddInParameter(dbComm, "@R_NO", DbType.String, objinfo.R_NO)
                db.AddInParameter(dbComm, "@AR_Type", DbType.String, objinfo.AR_Type)
                db.AddInParameter(dbComm, "@WH_OutID", DbType.String, objinfo.WH_OutID)
                db.AddInParameter(dbComm, "@WH_InID", DbType.String, objinfo.WH_InID)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                'db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@AR_Qty", DbType.Single, objinfo.AR_Qty)
                db.AddInParameter(dbComm, "@AR_Remark", DbType.String, objinfo.AR_Remark)
                db.AddInParameter(dbComm, "@AR_Date", DbType.Date, objinfo.AR_Date)
                db.AddInParameter(dbComm, "@AR_Detail", DbType.String, objinfo.AR_Detail)
                db.AddInParameter(dbComm, "@AR_Action", DbType.String, objinfo.AR_Action)

                db.ExecuteNonQuery(dbComm)
                ProductionReturn_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionReturn_Update = False

            End Try

        End Function

        Public Function ProductionReturn_Delete(ByVal AutoID As String, ByVal AR_NO As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_Delete")


                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@AR_NO", DbType.String, AR_NO)

                db.ExecuteNonQuery(dbComm)

                ProductionReturn_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionReturn_Delete = False
            End Try

        End Function

        Public Function ProductionReturn_UpdateCheck(ByVal objinfo As ProductionReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_UpdateCheck")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@AR_Check", DbType.Boolean, objinfo.AR_Check)
                db.AddInParameter(dbComm, "@AR_CheckAction", DbType.String, objinfo.AR_CheckAction)
                db.AddInParameter(dbComm, "@AR_CheckDate", DbType.Date, objinfo.AR_CheckDate)
                db.AddInParameter(dbComm, "@AR_CheckRemark", DbType.String, objinfo.AR_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionReturn_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionReturn_UpdateCheck = False

            End Try
        End Function

        Public Function ProductionReturn_GetList(ByVal AR_NO As String, ByVal R_NO As String, ByVal AR_Type As String, ByVal WH_OutID As String, ByVal WH_InID As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal AR_Check As String) As List(Of ProductionReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_GetList")


            db.AddInParameter(dbComm, "@AR_NO", DbType.String, AR_NO)
            db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbComm, "@AR_Type", DbType.String, AR_Type)
            db.AddInParameter(dbComm, "@WH_OutID", DbType.String, WH_OutID)
            db.AddInParameter(dbComm, "@WH_InID", DbType.String, WH_InID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@AR_Check", DbType.String, AR_Check)

            Dim FeatureList As New List(Of ProductionReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionReturn(reader))
                End While
                Return FeatureList
            End Using


        End Function

        Public Function FillProductionReturn(ByVal reader As IDataReader) As ProductionReturnInfo

            On Error Resume Next

            Dim pri As New ProductionReturnInfo

            pri.AutoID = reader("AutoID").ToString
            pri.AR_NO = reader("AR_NO").ToString
            pri.R_NO = reader("R_NO").ToString
            pri.AR_Type = reader("AR_Type").ToString
            pri.WH_OutID = reader("WH_OutID").ToString
            pri.WH_InID = reader("WH_InID").ToString
            pri.Pro_Type = reader("Pro_Type").ToString
            pri.PM_M_Code = reader("PM_M_Code").ToString
            pri.PM_Type = reader("PM_Type").ToString
            'pri.Pro_NO = reader("Pro_NO").ToString

            pri.AR_Qty = CSng(reader("AR_Qty").ToString)

            If reader("AR_Date") Is DBNull.Value Then
                pri.AR_Date = Nothing
            Else
                pri.AR_Date = CStr(reader("AR_Date"))
            End If

            pri.AR_Detail = reader("AR_Detail").ToString
            pri.AR_Remark = reader("AR_Remark").ToString
            pri.AR_Action = reader("AR_Action").ToString

            If reader("AR_Check") Is DBNull.Value Then
                pri.AR_Check = Nothing
            Else
                pri.AR_Check = CStr(reader("AR_Check"))
            End If
            pri.AR_CheckAction = reader("AR_CheckAction").ToString

            If reader("AR_CheckDate") Is DBNull.Value Then
                pri.AR_CheckDate = Nothing
            Else
                pri.AR_CheckDate = CStr(reader("AR_CheckDate"))
            End If
            pri.AR_CheckRemark = reader("AR_CheckRemark").ToString


            pri.ActionName = reader("ActionName").ToString
            pri.CheckActionName = reader("CheckActionName").ToString
            pri.WH_Name = reader("WH_Name").ToString
            pri.WH_InName = reader("WH_InName").ToString
            'pri.PS_Name = reader("PS_Name").ToString

            pri.AR_InCheck = reader("AR_InCheck").ToString
            pri.AR_InCheckDate = reader("AR_InCheckDate")
            pri.AR_InCheckRemark = reader("AR_InCheckRemark").ToString
            pri.AR_InCheckActionName = reader("AR_InCheckActionName").ToString

            pri.SumR_Qty = reader("SumR_Qty")
            pri.SumR_NoSendQty = reader("SumR_NoSendQty")
            pri.AR_RInfo = reader("AR_RInfo").ToString

            Return pri

        End Function


#Region "收料"

        Public Function ProductionReturn_UpdateInCheck(ByVal objinfo As ProductionReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_UpdateInCheck")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@AR_InCheck", DbType.Boolean, objinfo.AR_InCheck)
                db.AddInParameter(dbComm, "@AR_InCheckAction", DbType.String, objinfo.AR_InCheckAction)
                db.AddInParameter(dbComm, "@AR_InCheckDate", DbType.Date, objinfo.AR_InCheckDate)
                db.AddInParameter(dbComm, "@AR_InCheckRemark", DbType.String, objinfo.AR_InCheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionReturn_UpdateInCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionReturn_UpdateInCheck = False
            End Try
        End Function

        Public Function ProductionReturn_GetList1(ByVal AR_NO As String, ByVal R_NO As String, ByVal AR_Type As String, ByVal WH_OutID As String, ByVal WH_InID As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal AR_Check As String, ByVal AR_InCheck As String) As List(Of ProductionReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_GetList1")

            db.AddInParameter(dbComm, "@AR_NO", DbType.String, AR_NO)
            db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbComm, "@AR_Type", DbType.String, AR_Type)
            db.AddInParameter(dbComm, "@WH_OutID", DbType.String, WH_OutID)
            db.AddInParameter(dbComm, "@WH_InID", DbType.String, WH_InID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@AR_Check", DbType.String, AR_Check)
            db.AddInParameter(dbComm, "@AR_InCheck", DbType.String, AR_InCheck) 'AR_InCheck 

            Dim FeatureList As New List(Of ProductionReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function






#End Region

        ''' <summary>
        ''' 獲取生產總退貨與未歸還數
        ''' </summary>
        ''' <param name="Pro_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="WH_OutID"></param>
        ''' <param name="WH_InID"></param>
        ''' <param name="R_InCheck"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionRetrocede_GetNOReturnList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal WH_OutID As String, ByVal WH_InID As String, ByVal R_InCheck As String) As List(Of ProductionReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionRetrocede_GetNOReturnList")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@WH_OutID", DbType.String, WH_OutID)
            db.AddInParameter(dbComm, "@WH_InID", DbType.String, WH_InID)
            db.AddInParameter(dbComm, "@R_InCheck", DbType.String, R_InCheck)

            Dim FeatureList As New List(Of ProductionReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionReturn(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function ProductionReturnFIFO(ByVal objinfo As ProductionReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturnFIFO")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@WH_OutID", DbType.String, objinfo.WH_OutID)
                db.AddInParameter(dbComm, "@WH_InID", DbType.String, objinfo.WH_InID)

                db.AddInParameter(dbComm, "@AR_Qty", DbType.Double, objinfo.AR_Qty)

                db.ExecuteNonQuery(dbComm)
                ProductionReturnFIFO = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionReturnFIFO = False

            End Try
        End Function


        Public Function ProductionReturn_GetList2(ByVal AR_NO As String, ByVal R_NO As String, ByVal AR_Type As String, ByVal WH_OutID As String, _
        ByVal WH_InID As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, _
        ByVal PM_Type As String, ByVal AR_Check As String, ByVal AR_InCheck As String, ByVal AR_RInfo As String, ByVal AR_RInfoAutoID As String) As List(Of ProductionReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionReturn_GetList2")

            db.AddInParameter(dbComm, "@AR_NO", DbType.String, AR_NO)
            db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbComm, "@AR_Type", DbType.String, AR_Type)
            db.AddInParameter(dbComm, "@WH_OutID", DbType.String, WH_OutID)
            db.AddInParameter(dbComm, "@WH_InID", DbType.String, WH_InID)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@AR_Check", DbType.String, AR_Check)
            db.AddInParameter(dbComm, "@AR_InCheck", DbType.String, AR_InCheck) 'AR_InCheck 

            db.AddInParameter(dbComm, "@AR_RInfo", DbType.String, AR_RInfo)
            db.AddInParameter(dbComm, "@AR_RInfoAutoID", DbType.String, AR_RInfoAutoID)


            Dim FeatureList As New List(Of ProductionReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function



    End Class


End Namespace



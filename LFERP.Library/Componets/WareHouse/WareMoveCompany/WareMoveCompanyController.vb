Namespace LFERP.Library.WareHouse.WareMoveCompany

    Public Class WareMoveCompanyController

        Public Function WareMoveCompany_Add(ByVal objFile1 As WareMoveCompanyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_Add")
                db.AddInParameter(dbComm, "@MC_Num", DbType.String, objFile1.MC_Num)
                db.AddInParameter(dbComm, "@MC_NO", DbType.String, objFile1.MC_NO)
                db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, objFile1.MC_OUT_Company)
                db.AddInParameter(dbComm, "@MC_OUT_WHID", DbType.String, objFile1.MC_OUT_WHID)
                db.AddInParameter(dbComm, "@MC_IN_Company", DbType.String, objFile1.MC_IN_Company)

                db.AddInParameter(dbComm, "@MC_IN_WHID", DbType.String, objFile1.MC_IN_WHID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@MC_Qty", DbType.Double, objFile1.MC_Qty)
                db.AddInParameter(dbComm, "@MC_AddAction", DbType.String, objFile1.MC_AddAction)
                db.AddInParameter(dbComm, "@MC_AddActionName", DbType.String, objFile1.MC_AddActionName)

                db.AddInParameter(dbComm, "@MC_AddDate", DbType.String, objFile1.MC_AddDate)
                db.AddInParameter(dbComm, "@MC_Remark", DbType.String, objFile1.MC_Remark)
                db.AddInParameter(dbComm, "@MC_OUT_WHName", DbType.String, objFile1.MC_OUT_WHName)
                db.AddInParameter(dbComm, "@MC_IN_WHName", DbType.String, objFile1.MC_IN_WHName)

                db.ExecuteNonQuery(dbComm)
                WareMoveCompany_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMoveCompany_Add = False
            End Try
        End Function

        ''' <summary>
        ''' 2014-04-01 姚駿
        ''' 添加副本
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMoveCompany_AddOne(ByVal objFile1 As WareMoveCompanyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_AddOne")
                db.AddInParameter(dbComm, "@MC_Num", DbType.String, objFile1.MC_Num)
                db.AddInParameter(dbComm, "@MC_NO", DbType.String, objFile1.MC_NO)
                db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, objFile1.MC_OUT_Company)
                db.AddInParameter(dbComm, "@MC_OUT_WHID", DbType.String, objFile1.MC_OUT_WHID)
                db.AddInParameter(dbComm, "@MC_IN_Company", DbType.String, objFile1.MC_IN_Company)

                db.AddInParameter(dbComm, "@MC_IN_WHID", DbType.String, objFile1.MC_IN_WHID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@MC_Qty", DbType.Double, objFile1.MC_Qty)
                db.AddInParameter(dbComm, "@MC_AddAction", DbType.String, objFile1.MC_AddAction)
                db.AddInParameter(dbComm, "@MC_AddActionName", DbType.String, objFile1.MC_AddActionName)

                db.AddInParameter(dbComm, "@MC_AddDate", DbType.String, objFile1.MC_AddDate)
                db.AddInParameter(dbComm, "@MC_Remark", DbType.String, objFile1.MC_Remark)
                db.AddInParameter(dbComm, "@MC_OUT_WHName", DbType.String, objFile1.MC_OUT_WHName)
                db.AddInParameter(dbComm, "@MC_IN_WHName", DbType.String, objFile1.MC_IN_WHName)


                db.AddInParameter(dbComm, "@WTypeName", DbType.String, objFile1.WTypeName)

                db.ExecuteNonQuery(dbComm)
                WareMoveCompany_AddOne = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMoveCompany_AddOne = False
            End Try
        End Function

        Public Function WareMoveCompany_Update(ByVal objFile1 As WareMoveCompanyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objFile1.AutoID)

                db.AddInParameter(dbComm, "@MC_Num", DbType.String, objFile1.MC_Num)
                db.AddInParameter(dbComm, "@MC_NO", DbType.String, objFile1.MC_NO)
                db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, objFile1.MC_OUT_Company)
                db.AddInParameter(dbComm, "@MC_OUT_WHID", DbType.String, objFile1.MC_OUT_WHID)
                db.AddInParameter(dbComm, "@MC_IN_Company", DbType.String, objFile1.MC_IN_Company)

                db.AddInParameter(dbComm, "@MC_IN_WHID", DbType.String, objFile1.MC_IN_WHID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@MC_Qty", DbType.Double, objFile1.MC_Qty)
                db.AddInParameter(dbComm, "@MC_AddAction", DbType.String, objFile1.MC_AddAction)
                db.AddInParameter(dbComm, "@MC_AddActionName", DbType.String, objFile1.MC_AddActionName)

                db.AddInParameter(dbComm, "@MC_AddDate", DbType.String, objFile1.MC_AddDate)
                db.AddInParameter(dbComm, "@MC_Remark", DbType.String, objFile1.MC_Remark)
                db.AddInParameter(dbComm, "@MC_OUT_WHName", DbType.String, objFile1.MC_OUT_WHName)
                db.AddInParameter(dbComm, "@MC_IN_WHName", DbType.String, objFile1.MC_IN_WHName)

                db.ExecuteNonQuery(dbComm)
                WareMoveCompany_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMoveCompany_Update = False
            End Try
        End Function

        ''' <summary>
        ''' 修改副本
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMoveCompany_UpdateOne(ByVal objFile1 As WareMoveCompanyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_UpdateOne")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objFile1.AutoID)

                db.AddInParameter(dbComm, "@MC_Num", DbType.String, objFile1.MC_Num)
                db.AddInParameter(dbComm, "@MC_NO", DbType.String, objFile1.MC_NO)
                db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, objFile1.MC_OUT_Company)
                db.AddInParameter(dbComm, "@MC_OUT_WHID", DbType.String, objFile1.MC_OUT_WHID)
                db.AddInParameter(dbComm, "@MC_IN_Company", DbType.String, objFile1.MC_IN_Company)

                db.AddInParameter(dbComm, "@MC_IN_WHID", DbType.String, objFile1.MC_IN_WHID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@MC_Qty", DbType.Double, objFile1.MC_Qty)
                db.AddInParameter(dbComm, "@MC_AddAction", DbType.String, objFile1.MC_AddAction)
                db.AddInParameter(dbComm, "@MC_AddActionName", DbType.String, objFile1.MC_AddActionName)

                db.AddInParameter(dbComm, "@MC_AddDate", DbType.String, objFile1.MC_AddDate)
                db.AddInParameter(dbComm, "@MC_Remark", DbType.String, objFile1.MC_Remark)
                db.AddInParameter(dbComm, "@MC_OUT_WHName", DbType.String, objFile1.MC_OUT_WHName)
                db.AddInParameter(dbComm, "@MC_IN_WHName", DbType.String, objFile1.MC_IN_WHName)

                db.AddInParameter(dbComm, "@WTypeName", DbType.String, objFile1.WTypeName)

                db.ExecuteNonQuery(dbComm)
                WareMoveCompany_UpdateOne = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMoveCompany_UpdateOne = False
            End Try
        End Function


        Public Function WareMoveCompany_Check(ByVal objFile1 As WareMoveCompanyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_Check")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objFile1.AutoID)

                db.AddInParameter(dbComm, "@MC_Num", DbType.String, objFile1.MC_Num)
                db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, objFile1.MC_OUT_Company)
                db.AddInParameter(dbComm, "@MC_Check", DbType.Boolean, objFile1.MC_Check)
                db.AddInParameter(dbComm, "@MC_CheckAction", DbType.String, objFile1.MC_CheckAction)
                db.AddInParameter(dbComm, "@MC_CheckActionName", DbType.String, objFile1.MC_CheckActionName)

                db.AddInParameter(dbComm, "@MC_CheckDate", DbType.String, objFile1.MC_CheckDate)
                db.AddInParameter(dbComm, "@MC_CheckRemark", DbType.String, objFile1.MC_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                WareMoveCompany_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMoveCompany_Check = False
            End Try
        End Function

        Public Function WareMoveCompany_Delete(ByVal AutoID As String, ByVal MC_Num As String, ByVal MC_NO As String, ByVal MC_OUT_Company As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@MC_Num", DbType.String, MC_Num)
                db.AddInParameter(dbComm, "@MC_NO", DbType.String, MC_NO)
                db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, MC_OUT_Company)

                db.ExecuteNonQuery(dbComm)
                WareMoveCompany_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMoveCompany_Delete = False
            End Try
        End Function

#Region "載入數據"

        Public Function WareMoveCompany_GetList(ByVal MC_Num As String, ByVal MC_NO As String, ByVal MC_OUT_Company As String, ByVal MC_OUT_WHID As String, ByVal MC_IN_Company As String, _
                                                ByVal MC_IN_WHID As String, ByVal M_Code As String, ByVal MC_AddDate1 As String, ByVal MC_AddDate2 As String, ByVal MC_Check As String, ByVal MC_InCheck As String) As List(Of WareMoveCompanyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_GetList")
            db.AddInParameter(dbComm, "@MC_Num", DbType.String, MC_Num)
            db.AddInParameter(dbComm, "@MC_NO", DbType.String, MC_NO)
            db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, MC_OUT_Company)
            db.AddInParameter(dbComm, "@MC_OUT_WHID", DbType.String, MC_OUT_WHID)
            db.AddInParameter(dbComm, "@MC_IN_Company", DbType.String, MC_IN_Company)

            db.AddInParameter(dbComm, "@MC_IN_WHID", DbType.String, MC_IN_WHID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@MC_AddDate1", DbType.String, MC_AddDate1)
            db.AddInParameter(dbComm, "@MC_AddDate2", DbType.String, MC_AddDate2)
            db.AddInParameter(dbComm, "@MC_Check", DbType.String, MC_Check)

            db.AddInParameter(dbComm, "@MC_InCheck", DbType.String, MC_InCheck)

            Dim FeatureList As New List(Of WareMoveCompanyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMoveCompany(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 獲取調撥類型
        ''' 2014-04-01    姚駿
        ''' </summary>
        ''' <param name="WTypeID"></param>
        ''' <param name="WTypeName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareMoveCompanyType_GetList(ByVal WTypeID As String, ByVal WTypeName As String) As List(Of WareMoveCompanyInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompanyType_GetList")
            db.AddInParameter(dbComm, "@WTypeID", DbType.String, WTypeID)
            db.AddInParameter(dbComm, "@WTypeName", DbType.String, WTypeName)

            Dim FeatureList As New List(Of WareMoveCompanyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMoveCompany(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Function FillWareMoveCompany(ByVal reader As IDataReader) As WareMoveCompanyInfo
            On Error Resume Next
            Dim objInfo As New WareMoveCompanyInfo

            objInfo.AutoID = reader("AutoID")
            objInfo.MC_Num = reader("MC_Num").ToString
            objInfo.MC_NO = reader("MC_NO").ToString
            objInfo.MC_OUT_Company = reader("MC_OUT_Company").ToString
            objInfo.MC_OUT_WHID = reader("MC_OUT_WHID").ToString

            objInfo.MC_IN_Company = reader("MC_IN_Company").ToString
            objInfo.MC_IN_WHID = reader("MC_IN_WHID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.MC_Qty = reader("MC_Qty")
            objInfo.MC_AddAction = reader("MC_AddAction").ToString

            objInfo.MC_AddActionName = reader("MC_AddActionName").ToString
            objInfo.MC_AddDate = reader("MC_AddDate")
            objInfo.MC_Remark = reader("MC_Remark").ToString
            objInfo.MC_Check = reader("MC_Check")
            objInfo.MC_CheckAction = reader("MC_CheckAction").ToString

            objInfo.MC_CheckActionName = reader("MC_CheckActionName").ToString
            objInfo.MC_CheckDate = reader("MC_CheckDate")
            objInfo.MC_CheckRemark = reader("MC_CheckRemark").ToString
            objInfo.MC_InCheck = reader("MC_InCheck")
            objInfo.MC_InAction = reader("MC_InAction").ToString

            objInfo.MC_InActionName = reader("MC_InActionName").ToString
            objInfo.MC_InDate = reader("MC_InDate")
            objInfo.MC_InRemark = reader("MC_InRemark").ToString
            objInfo.MC_OUT_EndQty = reader("MC_OUT_EndQty")
            objInfo.MC_IN_EndQty = reader("MC_IN_EndQty")

            objInfo.MC_OUT_WHName = reader("MC_OUT_WHName")
            objInfo.MC_IN_WHName = reader("MC_IN_WHName").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString

            '2014-04-01    姚駿
            objInfo.WTypeID = reader("WTypeID").ToString
            objInfo.WTypeName = reader("WTypeName").ToString



            Return objInfo
        End Function


        Public Function WareMoveCompany_GetNum(ByVal NDate As String, ByVal MC_OUT_Company As String) As List(Of WareMoveCompanyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_GetNum")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, MC_OUT_Company)

            Dim FeatureList As New List(Of WareMoveCompanyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMoveCompanyNum(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Function FillWareMoveCompanyNum(ByVal reader As IDataReader) As WareMoveCompanyInfo
            On Error Resume Next
            Dim objInfo As New WareMoveCompanyInfo
            objInfo.MC_Num = reader("MC_Num").ToString
            Return objInfo
        End Function

        Public Function WareMoveCompany_GetNO(ByVal NDate As String, ByVal MC_OUT_Company As String) As List(Of WareMoveCompanyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, MC_OUT_Company)

            Dim FeatureList As New List(Of WareMoveCompanyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareMoveCompanyNO(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Function FillWareMoveCompanyNO(ByVal reader As IDataReader) As WareMoveCompanyInfo
            On Error Resume Next
            Dim objInfo As New WareMoveCompanyInfo
            objInfo.MC_NO = reader("MC_NO").ToString
            Return objInfo
        End Function

        Public Function WareMoveCompanyCenterSetting_GetList() As List(Of WareMoveCompanyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompanyCenterSetting_GetList")

            Dim FeatureList As New List(Of WareMoveCompanyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillCompanyCenterSetting(reader))
                End While
                Return FeatureList
            End Using


        End Function

        Function FillCompanyCenterSetting(ByVal reader As IDataReader) As WareMoveCompanyInfo
            On Error Resume Next
            Dim objInfo As New WareMoveCompanyInfo
            objInfo.ServerIP = reader("ServerIP").ToString
            objInfo.DataBaseName = reader("DataBaseName").ToString
            objInfo.UserID = reader("UserID").ToString
            objInfo.PassWord = reader("PassWord").ToString

            Return objInfo
        End Function


#End Region

        Public Function WareMoveCompany_INCheck(ByVal objFile1 As WareMoveCompanyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareMoveCompany_INCheck")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objFile1.AutoID)
                db.AddInParameter(dbComm, "@MC_Num", DbType.String, objFile1.MC_Num)
                db.AddInParameter(dbComm, "@MC_OUT_Company", DbType.String, objFile1.MC_OUT_Company)

                db.AddInParameter(dbComm, "@MC_InRemark", DbType.String, objFile1.MC_InRemark)
                db.AddInParameter(dbComm, "@MC_InDate", DbType.String, objFile1.MC_InDate)
                db.AddInParameter(dbComm, "@MC_InActionName", DbType.String, objFile1.MC_InActionName)

                db.AddInParameter(dbComm, "@MC_InAction", DbType.String, objFile1.MC_InAction)
                db.AddInParameter(dbComm, "@MC_InCheck", DbType.Boolean, objFile1.MC_InCheck)

                db.ExecuteNonQuery(dbComm)
                WareMoveCompany_INCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareMoveCompany_INCheck = False
            End Try
        End Function

    End Class

End Namespace

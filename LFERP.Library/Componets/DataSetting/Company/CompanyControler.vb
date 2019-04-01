
Namespace LFERP.DataSetting
    Public Class CompanyControler

        ''' <summary>
        '''新增公司
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Company_Add(ByVal objFile1 As CompanyInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Company_Add")

                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@CO_ID", DbType.String, objFile1.CO_ID)
                db.AddInParameter(dbComm, "@CO_ChsName", DbType.String, objFile1.CO_ChsName)
                db.AddInParameter(dbComm, "@CO_EngName", DbType.String, objFile1.CO_EngName)
                db.AddInParameter(dbComm, "@CO_ChsAddress", DbType.String, objFile1.CO_ChsAddress)
                db.AddInParameter(dbComm, "@CO_EngAddress", DbType.String, objFile1.CO_EngAddress)
                db.AddInParameter(dbComm, "@CO_ChsTel", DbType.String, objFile1.CO_ChsTel)
                db.AddInParameter(dbComm, "@CO_EngTel", DbType.String, objFile1.CO_EngTel)
                db.AddInParameter(dbComm, "@CO_ChsFax", DbType.String, objFile1.CO_ChsFax)
                db.AddInParameter(dbComm, "@CO_EngFax", DbType.String, objFile1.CO_EngFax)

                db.AddInParameter(dbComm, "@CO_ChsShipTo", DbType.String, objFile1.CO_ChsShipTo)
                db.AddInParameter(dbComm, "@CO_EngShipTo", DbType.String, objFile1.CO_EngShipTo)
                db.AddInParameter(dbComm, "@CO_ChsDeliverTo", DbType.String, objFile1.CO_ChsDeliverTo)
                db.AddInParameter(dbComm, "@CO_ChsDeliverTel", DbType.String, objFile1.CO_ChsDeliverTel)
                db.AddInParameter(dbComm, "@CO_ChsDeliverFax", DbType.String, objFile1.CO_ChsDeliverFax)
                db.AddInParameter(dbComm, "@CO_EngDeliverTo", DbType.String, objFile1.CO_EngDeliverTo)
                db.AddInParameter(dbComm, "@CO_EngDeliverTel", DbType.String, objFile1.CO_EngDeliverTel)
                db.AddInParameter(dbComm, "@CO_EngDeliverFax", DbType.String, objFile1.CO_EngDeliverFax)
                db.AddInParameter(dbComm, "@CO_Logo", DbType.Binary, objFile1.CO_Logo)


                db.ExecuteNonQuery(dbComm)
                Company_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Company_Add = False
            End Try

        End Function

        ''' <summary>
        '''修改公司 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Company_Update(ByVal objFile1 As CompanyInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Company_Update")

                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@CO_ID", DbType.String, objFile1.CO_ID)
                db.AddInParameter(dbComm, "@CO_ChsName", DbType.String, objFile1.CO_ChsName)
                db.AddInParameter(dbComm, "@CO_EngName", DbType.String, objFile1.CO_EngName)
                db.AddInParameter(dbComm, "@CO_ChsAddress", DbType.String, objFile1.CO_ChsAddress)
                db.AddInParameter(dbComm, "@CO_EngAddress", DbType.String, objFile1.CO_EngAddress)
                db.AddInParameter(dbComm, "@CO_ChsTel", DbType.String, objFile1.CO_ChsTel)
                db.AddInParameter(dbComm, "@CO_EngTel", DbType.String, objFile1.CO_EngTel)
                db.AddInParameter(dbComm, "@CO_ChsFax", DbType.String, objFile1.CO_ChsFax)
                db.AddInParameter(dbComm, "@CO_EngFax", DbType.String, objFile1.CO_EngFax)

                db.AddInParameter(dbComm, "@CO_ChsShipTo", DbType.String, objFile1.CO_ChsShipTo)
                db.AddInParameter(dbComm, "@CO_EngShipTo", DbType.String, objFile1.CO_EngShipTo)
                db.AddInParameter(dbComm, "@CO_ChsDeliverTo", DbType.String, objFile1.CO_ChsDeliverTo)
                db.AddInParameter(dbComm, "@CO_ChsDeliverTel", DbType.String, objFile1.CO_ChsDeliverTel)
                db.AddInParameter(dbComm, "@CO_ChsDeliverFax", DbType.String, objFile1.CO_ChsDeliverFax)
                db.AddInParameter(dbComm, "@CO_EngDeliverTo", DbType.String, objFile1.CO_EngDeliverTo)
                db.AddInParameter(dbComm, "@CO_EngDeliverTel", DbType.String, objFile1.CO_EngDeliverTel)
                db.AddInParameter(dbComm, "@CO_EngDeliverFax", DbType.String, objFile1.CO_EngDeliverFax)
                db.AddInParameter(dbComm, "@CO_Logo", DbType.Binary, objFile1.CO_Logo)


                db.ExecuteNonQuery(dbComm)
                Company_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Company_Update = False
            End Try

        End Function

        ''' <summary>
        ''' 刪除公司
        ''' </summary>
        ''' <param name="objfile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Company_Del(ByVal objfile1 As CompanyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Company_Delete")

                db.AddInParameter(dbComm, "@CO_ID", DbType.String, objfile1.CO_ID)
                db.ExecuteNonQuery(dbComm)
                Company_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Company_Del = False
            End Try

        End Function

        ''' <summary>
        ''' 取得公司信息
        ''' </summary>
        ''' <param name="CO_ID"></param>
        ''' <param name="CO_ChsName"></param>
        ''' <param name="CO_EngName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Company_Getlist(ByVal DPT_ID As String, ByVal CO_ID As String, ByVal CO_ChsName As String, ByVal CO_EngName As String) As List(Of CompanyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Company_Getlist")

            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@CO_ID", DbType.String, CO_ID)
            db.AddInParameter(dbComm, "@CO_ChsName", DbType.String, CO_ChsName)
            db.AddInParameter(dbComm, "@CO_EngName", DbType.String, CO_EngName)

            Dim FeatureList As New List(Of CompanyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillCompany(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Friend Function FillCompany(ByVal reader As IDataReader) As CompanyInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New CompanyInfo
            objInfo.CO_ID = reader("CO_ID").ToString
            objInfo.CO_ChsName = reader("CO_ChsName").ToString
            objInfo.CO_EngName = reader("CO_EngName").ToString
            objInfo.CO_ChsAddress = reader("CO_ChsAddress").ToString
            objInfo.CO_EngAddress = reader("CO_EngAddress").ToString
            objInfo.CO_ChsTel = reader("CO_ChsTel").ToString
            objInfo.CO_EngTel = reader("CO_EngTel").ToString
            objInfo.CO_ChsFax = reader("CO_ChsFax").ToString

            objInfo.CO_EngFax = reader("CO_EngFax").ToString
            objInfo.CO_ChsShipTo = reader("CO_ChsShipTo").ToString
            objInfo.CO_EngShipTo = reader("CO_EngShipTo").ToString
            objInfo.CO_ChsDeliverTo = reader("CO_ChsDeliverTo").ToString
            objInfo.CO_ChsDeliverTel = reader("CO_ChsDeliverTel").ToString
            objInfo.CO_ChsDeliverFax = reader("CO_ChsDeliverFax").ToString
            objInfo.CO_EngDeliverTo = reader("CO_EngDeliverTo").ToString
            objInfo.CO_EngDeliverTel = reader("CO_EngDeliverTel").ToString
            objInfo.CO_EngDeliverFax = reader("CO_EngDeliverFax").ToString
            If reader("CO_Logo") Is DBNull.Value Then
                objInfo.CO_Logo = Nothing
            Else
                objInfo.CO_Logo = reader("CO_Logo")
            End If

            objInfo.DPT_ID = reader("DPT_ID").ToString

            objInfo.CO_KaoQinConn = reader("CO_KaoQinConn").ToString

            Return objInfo

        End Function



    End Class
End Namespace


Namespace LFERP.Library.Purchase.WareQuality

    Public Class WareQualityController
        ''' <summary>
        ''' 新增物料品質反饋單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareQuality_Add(ByVal objinfo As WareQualityInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareQuality_Add")

                db.AddInParameter(dbcomm, "@WQ_Code", DbType.String, objinfo.WQ_Code)
                db.AddInParameter(dbcomm, "@WQ_Dpt", DbType.String, objinfo.WQ_Dpt)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@M_Name", DbType.String, objinfo.M_Name)
                db.AddInParameter(dbcomm, "@M_Gauge", DbType.String, objinfo.M_Gauge)

                db.AddInParameter(dbcomm, "@WO_Qty", DbType.Single, objinfo.WO_Qty)
                db.AddInParameter(dbcomm, "@M_Unit", DbType.String, objinfo.M_Unit)
                db.AddInParameter(dbcomm, "@WO_ID", DbType.String, objinfo.WO_ID)
                db.AddInParameter(dbcomm, "@WQ_Description", DbType.String, objinfo.WQ_Description)
                db.AddInParameter(dbcomm, "@WQ_UserName", DbType.String, objinfo.WQ_UserName)

                db.AddInParameter(dbcomm, "@PS_Opinion", DbType.String, objinfo.PS_Opinion)
                db.AddInParameter(dbcomm, "@PS_UserName", DbType.String, objinfo.PS_UserName)
                db.AddInParameter(dbcomm, "@ACC_Opinion", DbType.String, objinfo.ACC_Opinion)
                db.AddInParameter(dbcomm, "@AddUser", DbType.String, objinfo.AddUser)
                db.AddInParameter(dbcomm, "@AddDate", DbType.String, objinfo.AddDate)

                db.AddInParameter(dbcomm, "@CostAcc_Opinion", DbType.String, objinfo.CostAcc_Opinion)
                db.AddInParameter(dbcomm, "@PD_Opinion", DbType.String, objinfo.PD_Opinion)

                db.ExecuteNonQuery(dbcomm)
                WareQuality_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareQuality_Add = False

            End Try
        End Function

        ''' <summary>
        ''' 修改物料品質反饋單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareQuality_Update(ByVal objinfo As WareQualityInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareQuality_Update")

                db.AddInParameter(dbcomm, "@WQ_Code", DbType.String, objinfo.WQ_Code)
                db.AddInParameter(dbcomm, "@WQ_Dpt", DbType.String, objinfo.WQ_Dpt)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@M_Name", DbType.String, objinfo.M_Name)
                db.AddInParameter(dbcomm, "@M_Gauge", DbType.String, objinfo.M_Gauge)

                db.AddInParameter(dbcomm, "@WO_Qty", DbType.Single, objinfo.WO_Qty)
                db.AddInParameter(dbcomm, "@M_Unit", DbType.String, objinfo.M_Unit)
                db.AddInParameter(dbcomm, "@WO_ID", DbType.String, objinfo.WO_ID)
                db.AddInParameter(dbcomm, "@WQ_Description", DbType.String, objinfo.WQ_Description)
                db.AddInParameter(dbcomm, "@WQ_UserName", DbType.String, objinfo.WQ_UserName)

                db.AddInParameter(dbcomm, "@PS_Opinion", DbType.String, objinfo.PS_Opinion)
                db.AddInParameter(dbcomm, "@PS_UserName", DbType.String, objinfo.PS_UserName)
                db.AddInParameter(dbcomm, "@ACC_Opinion", DbType.String, objinfo.ACC_Opinion)
                db.AddInParameter(dbcomm, "@ModifyUser", DbType.String, objinfo.ModifyUser)
                db.AddInParameter(dbcomm, "@ModifyDate", DbType.String, objinfo.ModifyDate)

                db.AddInParameter(dbcomm, "@CostAcc_Opinion", DbType.String, objinfo.CostAcc_Opinion)
                db.AddInParameter(dbcomm, "@PD_Opinion", DbType.String, objinfo.PD_Opinion)

                db.ExecuteNonQuery(dbcomm)
                WareQuality_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareQuality_Update = False

            End Try
        End Function

        ''' <summary>
        ''' 刪除物料品質反饋單
        ''' </summary>
        ''' <param name="WQ_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareQuality_Delete(ByVal WQ_Code As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareQuality_Delete")

                db.AddInParameter(dbcomm, "@WQ_Code", DbType.String, WQ_Code)
                db.ExecuteNonQuery(dbcomm)
                WareQuality_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareQuality_Delete = False
            End Try
        End Function

        ''' <summary>
        ''' 按條件查詢物料反饋單
        ''' </summary>
        ''' <param name="WQ_Code"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="M_Gauge"></param>
        ''' <param name="WO_ID"></param>
        ''' <param name="AddDateBegin"></param>
        ''' <param name="AddDateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareQuality_GetList(ByVal WQ_Code As String, ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal WO_ID As String, ByVal AddDateBegin As String, ByVal AddDateEnd As String) As List(Of WareQualityInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareQuality_GetList")
            db.AddInParameter(dbComm, "@WQ_Code", DbType.String, WQ_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@AddDateBegin", DbType.String, AddDateBegin)
            db.AddInParameter(dbComm, "@AddDateEnd", DbType.String, AddDateEnd)

            Dim FeatureList As New List(Of WareQualityInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareQuality(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 獲取字段值
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillWareQuality(ByVal reader As IDataReader) As WareQualityInfo

            On Error Resume Next

            Dim wqi As New WareQualityInfo

            wqi.WQ_Code = reader("WQ_Code").ToString
            wqi.WQ_Dpt = reader("WQ_Dpt").ToString
            wqi.AP_ApplyDptName = reader("AP_UpDptName").ToString & "-" & reader("AP_ApplyDptName").ToString
            wqi.M_Code = reader("M_Code").ToString
            wqi.M_Gauge = reader("M_Gauge").ToString
            wqi.M_Name = reader("M_Name").ToString
            wqi.WO_Qty = CSng(reader("WO_Qty").ToString)
            wqi.M_Unit = reader("M_Unit").ToString
            wqi.WO_ID = reader("WO_ID").ToString
            wqi.WQ_Description = reader("WQ_Description").ToString
            wqi.WQ_UserName = reader("WQ_UserName").ToString
            wqi.PS_Opinion = reader("PS_Opinion").ToString
            wqi.PS_UserName = reader("PS_UserName").ToString
            wqi.ACC_Opinion = reader("ACC_Opinion").ToString
            wqi.AddUser = reader("AddUser").ToString
            wqi.AddDate = reader("AddDate").ToString
            'wqi.AddDate = Format(reader("AddDate"), "yyyy/MM/dd").ToString
            'wqi.ModifyUser = reader("ModifyUser").ToString
            'wqi.ModifyDate = Format(reader("ModifyDate"), "yyyy/MM/dd").ToString

            If reader("ModifyUser") Is DBNull.Value Then
                wqi.ModifyUser = Nothing
            Else
                wqi.ModifyUser = reader("ModifyUser")
            End If

            If reader("ModifyDate") Is DBNull.Value Then
                wqi.ModifyDate = Nothing
            Else
                wqi.ModifyDate = Format(reader("ModifyDate"), "yyyy/MM/dd").ToString
            End If

            wqi.CostAcc_Opinion = reader("CostAcc_Opinion").ToString
            wqi.PD_Opinion = reader("PD_Opinion").ToString
            Return wqi
        End Function
    End Class

End Namespace
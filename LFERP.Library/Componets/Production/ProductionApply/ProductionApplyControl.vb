Namespace LFERP.Library.ProductionApply
    Public Class ProductionApplyControl
        ''' <summary>
        ''' 新增申購單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionApply_Add(ByVal objinfo As ProductionApplyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionApply_Add")

                db.AddInParameter(dbcomm, "@PA_ID", DbType.String, objinfo.PA_ID)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@M_Name", DbType.String, objinfo.M_Name)
                db.AddInParameter(dbcomm, "@M_Gauge", DbType.String, objinfo.M_Gauge)

                db.AddInParameter(dbcomm, "@M_Unit", DbType.String, objinfo.M_Unit)
                db.AddInParameter(dbcomm, "@PA_Qty", DbType.Single, objinfo.PA_Qty)
                db.AddInParameter(dbcomm, "@Dpt_ID", DbType.String, objinfo.Dpt_ID)
                db.AddInParameter(dbcomm, "@PA_ApplyReason", DbType.String, objinfo.PA_ApplyReason)
                db.AddInParameter(dbcomm, "@PA_ApplyPersonName", DbType.String, objinfo.PA_ApplyPersonName)

                db.AddInParameter(dbcomm, "@PA_ApplyDate", DbType.Date, objinfo.PA_ApplyDate)
                db.AddInParameter(dbcomm, "@PA_AddUserID", DbType.String, objinfo.PA_AddUserID)
                db.AddInParameter(dbcomm, "@PA_AddDate", DbType.Date, objinfo.PA_AddDate)
                db.AddInParameter(dbcomm, "@PA_Remark", DbType.String, objinfo.PA_Remark)

                db.ExecuteNonQuery(dbcomm)
                ProductionApply_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionApply_Add = False

            End Try
        End Function
        ''' <summary>
        ''' 修改申購單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionApply_Update(ByVal objinfo As ProductionApplyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionApply_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbcomm, "@PA_ID", DbType.String, objinfo.PA_ID)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@M_Name", DbType.String, objinfo.M_Name)

                db.AddInParameter(dbcomm, "@M_Gauge", DbType.String, objinfo.M_Gauge)
                db.AddInParameter(dbcomm, "@M_Unit", DbType.String, objinfo.M_Unit)
                db.AddInParameter(dbcomm, "@PA_Qty", DbType.Single, objinfo.PA_Qty)
                db.AddInParameter(dbcomm, "@Dpt_ID", DbType.String, objinfo.Dpt_ID)
                db.AddInParameter(dbcomm, "@PA_ApplyReason", DbType.String, objinfo.PA_ApplyReason)

                db.AddInParameter(dbcomm, "@PA_ApplyPersonName", DbType.String, objinfo.PA_ApplyPersonName)
                db.AddInParameter(dbcomm, "@PA_ApplyDate", DbType.Date, objinfo.PA_ApplyDate)
                db.AddInParameter(dbcomm, "@PA_ModifyUserID", DbType.String, objinfo.PA_ModifyUserID)
                db.AddInParameter(dbcomm, "@PA_ModifyDate", DbType.Date, objinfo.PA_ModifyDate)
                db.AddInParameter(dbcomm, "@PA_Remark", DbType.String, objinfo.PA_Remark)

                db.ExecuteNonQuery(dbcomm)
                ProductionApply_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionApply_Update = False

            End Try
        End Function
        ''' <summary>
        ''' 刪除申購單（或刪除申購單中某條申購記錄）
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="PA_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionApply_Delete(ByVal AutoID As String, ByVal PA_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionApply_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbcomm, "@PA_ID", DbType.String, PA_ID)

                db.ExecuteNonQuery(dbcomm)
                ProductionApply_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionApply_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' 申購單審核
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionApply_Check(ByVal objinfo As ProductionApplyInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionApply_Check")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PA_ID", DbType.String, objinfo.PA_ID)
                db.AddInParameter(dbComm, "@PA_Check", DbType.Boolean, objinfo.PA_Check)
                db.AddInParameter(dbComm, "@PA_CheckDate", DbType.Date, objinfo.PA_CheckDate)
                db.AddInParameter(dbComm, "@PA_CheckUserID", DbType.String, objinfo.PA_CheckUserID)
                db.AddInParameter(dbComm, "@PA_CheckType", DbType.String, objinfo.PA_CheckType)
                db.AddInParameter(dbComm, "@PA_CheckRemark", DbType.String, objinfo.PA_CheckRemark)
                db.ExecuteNonQuery(dbComm)

                ProductionApply_Check = True

            Catch ex As Exception
                ProductionApply_Check = False
                MsgBox(ex.Message)
            End Try
        End Function
        ''' <summary>
        ''' 按條件查詢申購單
        ''' </summary>
        ''' <param name="PA_ID"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="M_Gauge"></param>
        ''' <param name="Dpt_ID"></param>
        ''' <param name="PA_ApplyDateBegin"></param>
        ''' <param name="PA_ApplyDateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionApply_GetList(ByVal PA_ID As String, ByVal PM_M_Code As String, ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal Dpt_ID As String, ByVal PA_ApplyDateBegin As String, ByVal PA_ApplyDateEnd As String) As List(Of ProductionApplyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionApply_GetList")

            db.AddInParameter(dbComm, "@PA_ID", DbType.String, PA_ID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@Dpt_ID", DbType.String, Dpt_ID)
            db.AddInParameter(dbComm, "@PA_ApplyDateBegin", DbType.String, PA_ApplyDateBegin)
            db.AddInParameter(dbComm, "@PA_ApplyDateEnd", DbType.String, PA_ApplyDateEnd)

            Dim FeatureList As New List(Of ProductionApplyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionApply(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 申購數據返回
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionApply_GetList1() As List(Of ProductionApplyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionApply_GetList1")

            Dim FeatureList As New List(Of ProductionApplyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionApply(reader))
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
        Public Function FillProductionApply(ByVal reader As IDataReader) As ProductionApplyInfo

            'On Error Resume Next

            Dim pai As New ProductionApplyInfo

            pai.AutoID = reader("AutoID").ToString
            pai.PA_ID = reader("PA_ID").ToString
            pai.PM_M_Code = reader("PM_M_Code").ToString
            pai.M_Code = reader("M_Code").ToString
            pai.M_Gauge = reader("M_Gauge").ToString

            pai.M_Unit = reader("M_Unit").ToString
            pai.M_Name = reader("M_Name").ToString
            pai.PA_Qty = CSng(reader("PA_Qty"))
            pai.PA_ApplyPersonName = reader("PA_ApplyPersonName").ToString
            pai.PA_ApplyDate = reader("PA_ApplyDate")

            pai.Dpt_ID = reader("Dpt_ID").ToString
            pai.Dpt_Name = reader("Dpt_NameUp").ToString & "-" & reader("Dpt_NameDown").ToString
            pai.PA_ApplyReason = reader("PA_ApplyReason")
            pai.PA_Remark = reader("PA_Remark")

            If reader("PA_CheckDate") Is DBNull.Value Then
                pai.PA_CheckDate = Nothing
            Else
                pai.PA_CheckDate = reader("PA_CheckDate")
            End If

            pai.PA_Check = reader("PA_Check")

            If reader("PA_CheckUserID") Is DBNull.Value Then
                pai.PA_CheckUserID = Nothing
            Else
                pai.PA_CheckUserID = reader("PA_CheckUserID")
            End If

            If reader("PA_CheckUserName") Is DBNull.Value Then
                pai.PA_CheckUserName = Nothing
            Else
                pai.PA_CheckUserName = reader("PA_CheckUserName")
            End If

            If reader("PA_CheckType") Is DBNull.Value Then
                pai.PA_CheckType = Nothing
            Else
                pai.PA_CheckType = reader("PA_CheckType")
            End If

            If reader("PA_CheckRemark") Is DBNull.Value Then
                pai.PA_CheckRemark = Nothing
            Else
                pai.PA_CheckRemark = reader("PA_CheckRemark")
            End If

            Return pai
        End Function

    End Class
End Namespace

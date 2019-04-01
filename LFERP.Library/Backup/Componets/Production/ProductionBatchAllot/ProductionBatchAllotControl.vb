Namespace LFERP.Library.ProductionBatchAllot
    Public Class ProductionBatchAllotControl
        Public Function ProductionBatchAllot_Add(ByVal obj As ProductionBatchAllotInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionBatchAllot_Add")

                db.AddInParameter(dbcomm, "@PBA_ID", DbType.String, obj.PBA_ID) '派工單號
                db.AddInParameter(dbcomm, "@OS_BatchID", DbType.String, obj.OS_BatchID) '批次編號
                db.AddInParameter(dbcomm, "@PBA_AddUserID", DbType.String, obj.PBA_AddUserID) '添加人ID
                db.AddInParameter(dbcomm, "@PBA_AddDate", DbType.String, obj.PBA_AddDate) '添加日期
                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) '廠別

                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code) '物料編碼
                db.AddInParameter(dbcomm, "@PBA_Qty", DbType.String, obj.PBA_Qty) '分派數量
                db.AddInParameter(dbcomm, "@PBA_Remark", DbType.String, obj.PBA_Remark) '備注

                db.ExecuteNonQuery(dbcomm)
                ProductionBatchAllot_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionBatchAllot_Add = False
            End Try
        End Function

        Public Function ProductionBatchAllot_Update(ByVal obj As ProductionBatchAllotInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionBatchAllot_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, obj.AutoID) '自動編號
                db.AddInParameter(dbcomm, "@PBA_ID", DbType.String, obj.PBA_ID) '派工單號
                db.AddInParameter(dbcomm, "@OS_BatchID", DbType.String, obj.OS_BatchID) '批次編號
                db.AddInParameter(dbcomm, "@PBA_ModifyUserID", DbType.String, obj.PBA_AddUserID) '修改人ID
                db.AddInParameter(dbcomm, "@PBA_ModifyDate", DbType.String, obj.PBA_AddDate) '修改日期

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) '廠別
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code) '物料編碼
                db.AddInParameter(dbcomm, "@PBA_Qty", DbType.String, obj.PBA_Qty) '分派數量
                db.AddInParameter(dbcomm, "@PBA_Remark", DbType.String, obj.PBA_Remark) '備注

                db.ExecuteNonQuery(dbcomm)
                ProductionBatchAllot_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionBatchAllot_Update = False
            End Try
        End Function

        Public Function ProductionBatchAllot_Delete(ByVal AutoID As String, ByVal PBA_ID As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionBatchAllot_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@PBA_ID", DbType.String, PBA_ID)

                db.ExecuteNonQuery(dbComm)
                ProductionBatchAllot_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionBatchAllot_Delete = False
            End Try
        End Function

        Public Function ProductionBatchAllot_UpdateCheck(ByVal objinfo As ProductionBatchAllotInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionBatchAllot_UpdateCheck")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PBA_Check", DbType.String, objinfo.PBA_Check)
                db.AddInParameter(dbComm, "@PBA_CheckUserID", DbType.String, objinfo.PBA_CheckUserID)
                db.AddInParameter(dbComm, "@PBA_CheckDate", DbType.String, objinfo.PBA_CheckDate)

                db.ExecuteNonQuery(dbComm)
                ProductionBatchAllot_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionBatchAllot_UpdateCheck = False
            End Try
        End Function

        Public Function ProductionBatchAllot_GetList(ByVal PBA_ID As String, ByVal OS_BatchID As String, ByVal FacID As String, _
        ByVal M_Code As String, ByVal M_Name As String, ByVal PBA_AddDateBegin As String, ByVal PBA_AddDateEnd As String, _
        ByVal PBA_Check As String) As List(Of ProductionBatchAllotInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionBatchAllot_GetList")

            db.AddInParameter(dbcomm, "@PBA_ID", DbType.String, PBA_ID) '派工單號
            db.AddInParameter(dbcomm, "@OS_BatchID", DbType.String, OS_BatchID) '批次編號
            db.AddInParameter(dbcomm, "@FacID", DbType.String, FacID) '廠別
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code) '物料編碼
            db.AddInParameter(dbcomm, "@M_Name", DbType.String, M_Name) '物料名稱

            db.AddInParameter(dbcomm, "@PBA_AddDateBegin", DbType.String, PBA_AddDateBegin) '添加日期
            db.AddInParameter(dbcomm, "@PBA_AddDateEnd", DbType.String, PBA_AddDateEnd) '修改日期
            db.AddInParameter(dbcomm, "@PBA_Check", DbType.String, PBA_Check) '審核


            Dim FeatureList As New List(Of ProductionBatchAllotInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillProductionBatchAllot(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionBatchAllot_GetID(ByVal PBA_ID As String) As ProductionBatchAllotInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionBatchAllot_GetID")

            db.AddInParameter(dbcomm, "@PBA_ID", DbType.String, PBA_ID) '派工單號

            Dim FeatureList As New List(Of ProductionBatchAllotInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    Return FillProductionBatchAllot(reader)
                End While
            End Using
        End Function

        Public Function ProductionBatchAllot_GetOS_BatchID() As List(Of ProductionBatchAllotInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionBatchAllot_GetOS_BatchID")

            Dim FeatureList As New List(Of ProductionBatchAllotInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillProductionBatchAllot(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionBatchAllot(ByVal reader As IDataReader) As ProductionBatchAllotInfo
            On Error Resume Next

            Dim ai As New ProductionBatchAllotInfo

            If reader("AutoID") Is DBNull.Value Then
                ai.AutoID = Nothing
            Else
                ai.AutoID = reader("AutoID")     '自動編號
            End If

            If reader("PBA_ID") Is DBNull.Value Then
                ai.PBA_ID = Nothing
            Else
                ai.PBA_ID = reader("PBA_ID").ToString     '派工單號
            End If

            If reader("OS_BatchID") Is DBNull.Value Then
                ai.OS_BatchID = Nothing
            Else
                ai.OS_BatchID = reader("OS_BatchID").ToString     '批次編號
            End If

            If reader("PBA_AddUserID") Is DBNull.Value Then
                ai.PBA_AddUserID = Nothing
            Else
                ai.PBA_AddUserID = reader("PBA_AddUserID").ToString     '添加人ID
            End If

            If reader("PBA_AddUserName") Is DBNull.Value Then
                ai.PBA_AddUserName = Nothing
            Else
                ai.PBA_AddUserName = reader("PBA_AddUserName").ToString     '添加人姓名
            End If

            If reader("PBA_AddDate") Is DBNull.Value Then
                ai.PBA_AddDate = Nothing
            Else
                ai.PBA_AddDate = Format(reader("PBA_AddDate"), "yyyy/MM/dd")     '添加日期
            End If

            If reader("PBA_ModifyUserID") Is DBNull.Value Then
                ai.PBA_ModifyUserID = Nothing
            Else
                ai.PBA_ModifyUserID = reader("PBA_ModifyUserID").ToString     '修改人
            End If

            If reader("PBA_ModifyUserName") Is DBNull.Value Then
                ai.PBA_ModifyUserName = Nothing
            Else
                ai.PBA_ModifyUserName = reader("PBA_ModifyUserName").ToString     '修改人姓名
            End If

            If reader("PBA_ModifyDate") Is DBNull.Value Then
                ai.PBA_ModifyDate = Nothing
            Else
                ai.PBA_ModifyDate = reader("PBA_ModifyDate").ToString     '修改日期
            End If

            If reader("PBA_Check") Is DBNull.Value Then
                ai.PBA_Check = Nothing
            Else
                ai.PBA_Check = reader("PBA_Check")     '審核
            End If

            If reader("PBA_CheckUserID") Is DBNull.Value Then
                ai.PBA_CheckUserID = Nothing
            Else
                ai.PBA_CheckUserID = reader("PBA_CheckUserID").ToString     '審核人ID
            End If

            If reader("PBA_CheckUserName") Is DBNull.Value Then
                ai.PBA_CheckUserName = Nothing
            Else
                ai.PBA_CheckUserName = reader("PBA_CheckUserName").ToString     '審核人姓名
            End If

            If reader("PBA_CheckDate") Is DBNull.Value Then
                ai.PBA_CheckDate = Nothing
            Else
                ai.PBA_CheckDate = reader("PBA_CheckDate").ToString     '審核日期
            End If

            If reader("FacID") Is DBNull.Value Then
                ai.FacID = Nothing
            Else
                ai.FacID = reader("FacID").ToString     '廠別編號
            End If

            If reader("FacName") Is DBNull.Value Then
                ai.FacName = Nothing
            Else
                ai.FacName = reader("FacName").ToString     '廠別名稱
            End If

            If reader("M_Code") Is DBNull.Value Then
                ai.M_Code = Nothing
            Else
                ai.M_Code = reader("M_Code").ToString     '物料編碼
            End If

            If reader("M_Name") Is DBNull.Value Then
                ai.M_Name = Nothing
            Else
                ai.M_Name = reader("M_Name").ToString     '物料名稱
            End If

            If reader("M_Gauge") Is DBNull.Value Then
                ai.M_Gauge = Nothing
            Else
                ai.M_Gauge = reader("M_Gauge").ToString     '物料規格
            End If

            If reader("M_Unit") Is DBNull.Value Then
                ai.M_Unit = Nothing
            Else
                ai.M_Unit = reader("M_Unit").ToString     '物料單位
            End If

            If reader("ON_NeedQty") Is DBNull.Value Then
                ai.ON_NeedQty = 0
            Else
                ai.ON_NeedQty = reader("ON_NeedQty").ToString     '物料單位
            End If

            If reader("PBA_Qty") Is DBNull.Value Then
                ai.PBA_Qty = 0
            Else
                ai.PBA_Qty = reader("PBA_Qty").ToString     '分派數量
            End If

            If reader("PBA_Remark") Is DBNull.Value Then
                ai.PBA_Remark = Nothing
            Else
                ai.PBA_Remark = reader("PBA_Remark").ToString     '備注
            End If


            Return ai
        End Function
    End Class
End Namespace


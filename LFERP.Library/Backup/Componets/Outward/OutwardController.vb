
Namespace LFERP.Library.Outward

    Public Class OutwardController

        ''' <summary>
        ''' 獲得主表單號的最大值
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardMain_GetNum(ByVal Ndate As String) As OutwardInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardMain_GetNum")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOutward(reader)
                End While
                Return Nothing
            End Using
        End Function

        ''' <summary>
        ''' 獲得主表單號的最大值
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardReWork_GetNum(ByVal Ndate As String) As OutwardInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardReWork_GetNum")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOutward(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 獲得子表中流水號最大值
        ''' </summary>
        ''' <param name="O_NOsub"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardSub_GetNo(ByVal O_NOsub As String) As OutwardInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardSub_GetNo")
            db.AddInParameter(dbComm, "@O_NOsub", DbType.String, O_NOsub)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillOutward(reader)
                End While
                Return Nothing
            End Using
        End Function
        '--------------------------------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' 主表信息---增加
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardMain_Add(ByVal objinfo As OutwardInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardMain_Add")

                db.AddInParameter(dbComm, "@O_NO", DbType.String, objinfo.O_NO)
                db.AddInParameter(dbComm, "@O_Type", DbType.String, objinfo.O_Type)
                If objinfo.O_Date = Nothing Then
                    db.AddInParameter(dbComm, "@O_Date", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@O_Date", DbType.Date, objinfo.O_Date)
                End If
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objinfo.S_Supplier)
                db.AddInParameter(dbComm, "@O_Action", DbType.String, objinfo.O_Action)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@O_Remark", DbType.String, objinfo.O_Remark)

                db.ExecuteNonQuery(dbComm)
                OutwardMain_Add = True

            Catch ex As Exception

                MsgBox(ex.Message)
                OutwardMain_Add = False
            End Try

        End Function
        ''' <summary>
        ''' 主表信息---修改
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardMain_Update(ByVal objinfo As OutwardInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardMain_Update")

                db.AddInParameter(dbComm, "@O_Action", DbType.String, objinfo.O_Action)
                db.AddInParameter(dbComm, "@O_Type", DbType.String, objinfo.O_Type)
                db.AddInParameter(dbComm, "@O_Remark", DbType.String, objinfo.O_Remark)
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objinfo.S_Supplier)
                db.AddInParameter(dbComm, "@O_NO", DbType.String, objinfo.O_NO)

                db.ExecuteNonQuery(dbComm)
                OutwardMain_Update = True

            Catch ex As Exception

                MsgBox(ex.Message)
                OutwardMain_Update = False

            End Try

        End Function
        ''' <summary>
        ''' 主表信息---刪除
        ''' </summary>
        ''' <param name="O_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardMain_Delete(ByVal O_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardMain_Delete")

                db.AddInParameter(dbComm, "@O_NO", DbType.String, O_NO)

                db.ExecuteNonQuery(dbComm)
                OutwardMain_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardMain_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' 主表信息---查詢
        ''' </summary>
        ''' <param name="O_NO"></param>
        ''' <param name="O_Type"></param>
        ''' <param name="O_Date1"></param>
        ''' <param name="O_Date2"></param>
        ''' <param name="O_Action"></param>
        ''' <param name="WH_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardMain_GetList(ByVal O_NO As String, ByVal O_Type As String, ByVal S_Supplier As String, ByVal OS_ItemType As String, ByVal M_Name As String, ByVal O_Date1 As String, ByVal O_Date2 As String, ByVal O_Action As String, ByVal WH_ID As String, ByVal OS_BatchID As String, ByVal O_Check As String, ByVal NoSendQtyZero As String) As List(Of OutwardInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardMain_GetList")

            db.AddInParameter(dbComm, "@O_NO", DbType.String, O_NO)
            db.AddInParameter(dbComm, "@O_Type", DbType.String, O_Type)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)
            db.AddInParameter(dbComm, "@OS_ItemType", DbType.String, OS_ItemType)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)

            db.AddInParameter(dbComm, "@O_Date1", DbType.String, O_Date1)
            db.AddInParameter(dbComm, "@O_Date2", DbType.String, O_Date2)
            db.AddInParameter(dbComm, "@O_Action", DbType.String, O_Action)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@O_Check", DbType.String, O_Check)
            db.AddInParameter(dbComm, "@NoSendQtyZero", DbType.String, NoSendQtyZero)

            Dim FeatureList As New List(Of OutwardInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutward(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 審核---修改
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardMain_UpdateCheck(ByVal objinfo As OutwardInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardMain_UpdateCheck")

                db.AddInParameter(dbComm, "@O_NO", DbType.String, objinfo.O_NO)
                db.AddInParameter(dbComm, "@O_Check", DbType.Boolean, objinfo.O_Check)
                db.AddInParameter(dbComm, "@O_CheckAction", DbType.String, objinfo.O_CheckAction)
                If objinfo.O_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@O_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@O_CheckDate", DbType.Date, objinfo.O_CheckDate)
                End If
                db.AddInParameter(dbComm, "@O_CheckRemark", DbType.String, objinfo.O_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                OutwardMain_UpdateCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                OutwardMain_UpdateCheck = False

            End Try
        End Function
        ''' <summary>
        ''' 複核---修改
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardMain_UpdateAccCheck(ByVal objinfo As OutwardInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardMain_UpdateAccCheck")

                db.AddInParameter(dbComm, "@O_NO", DbType.String, objinfo.O_NO)
                db.AddInParameter(dbComm, "@O_AccCheck", DbType.Boolean, objinfo.O_AccCheck)
                db.AddInParameter(dbComm, "@O_AccCheckAction", DbType.String, objinfo.O_AccCheckAction)
                If objinfo.O_AccCheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@O_AccCheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@O_AccCheckDate", DbType.Date, objinfo.O_AccCheckDate)
                End If
                db.AddInParameter(dbComm, "@O_AccCheckRemark", DbType.String, objinfo.O_AccCheckRemark)
                db.AddInParameter(dbComm, "@O_AccCheckType", DbType.String, objinfo.O_AccCheckType)

                db.ExecuteNonQuery(dbComm)
                OutwardMain_UpdateAccCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                OutwardMain_UpdateAccCheck = False

            End Try
        End Function
        '--------------------------------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' 子表信息---新增
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardSub_Add(ByVal objinfo As OutwardInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardSub_Add")

                db.AddInParameter(dbComm, "@O_NO", DbType.String, objinfo.O_NO)
                db.AddInParameter(dbComm, "@O_NOsub", DbType.String, objinfo.O_NOsub)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@OS_Qty", DbType.Double, objinfo.OS_Qty)
                db.AddInParameter(dbComm, "@OS_NoSendQty", DbType.Double, objinfo.OS_NoSendQty)
                db.AddInParameter(dbComm, "@OS_Price", DbType.Double, objinfo.OS_Price)
                db.AddInParameter(dbComm, "@OS_ItemType", DbType.String, objinfo.OS_ItemType)
                db.AddInParameter(dbComm, "@OS_Depict", DbType.String, objinfo.OS_Depict)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@OS_Remark", DbType.String, objinfo.OS_Remark)
                db.AddInParameter(dbComm, "@OP_NO", DbType.String, objinfo.OP_NO)
                db.AddInParameter(dbComm, "@ExtraName", DbType.String, objinfo.ExtraName)

                db.ExecuteNonQuery(dbComm)
                OutwardSub_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardSub_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 子表信息---修改
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardSub_Update(ByVal objinfo As OutwardInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardSub_Update")

                db.AddInParameter(dbComm, "@O_NO", DbType.String, objinfo.O_NO)
                db.AddInParameter(dbComm, "@O_NOsub", DbType.String, objinfo.O_NOsub)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@OS_Qty", DbType.Double, objinfo.OS_Qty)
                db.AddInParameter(dbComm, "@OS_NoSendQty", DbType.Double, objinfo.OS_NoSendQty)
                db.AddInParameter(dbComm, "@OS_Price", DbType.Double, objinfo.OS_Price)
                db.AddInParameter(dbComm, "@OS_ItemType", DbType.String, objinfo.OS_ItemType)
                db.AddInParameter(dbComm, "@OS_Depict", DbType.String, objinfo.OS_Depict)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@OS_Remark", DbType.String, objinfo.OS_Remark)
                db.AddInParameter(dbComm, "@OP_NO", DbType.String, objinfo.OP_NO)
                db.AddInParameter(dbComm, "@ExtraName", DbType.String, objinfo.ExtraName)

                db.ExecuteNonQuery(dbComm)
                OutwardSub_Update = True
            Catch ex As Exception

                MsgBox(ex.Message)
                OutwardSub_Update = False
            End Try
        End Function
        ''' <summary>
        ''' 子表信息---刪除
        ''' </summary>
        ''' <param name="O_NO"></param>
        ''' <param name="O_NOsub"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardSub_Delete(ByVal O_NO As String, ByVal O_NOsub As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardSub_Delete")

                db.AddInParameter(dbComm, "@O_NO", DbType.String, O_NO)
                db.AddInParameter(dbComm, "@O_NOsub", DbType.String, O_NOsub)

                db.ExecuteNonQuery(dbComm)
                OutwardSub_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                OutwardSub_Delete = False
            End Try

        End Function
        ''' <summary>
        ''' 子表信息---查詢
        ''' </summary>
        ''' <param name="O_No"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="OS_ItemType"></param>
        ''' <param name="OS_BatchID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function OutwardSub_GetList(ByVal O_NO As String, ByVal O_NOsub As String, ByVal M_Code As String, ByVal OS_ItemType As String, ByVal OS_BatchID As String) As List(Of OutwardInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardSub_GetList")

            db.AddInParameter(dbComm, "@O_NO", DbType.String, O_NO)
            db.AddInParameter(dbComm, "@O_NOsub", DbType.String, O_NOsub)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@OS_ItemType", DbType.String, OS_ItemType)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)

            Dim FeatureList As New List(Of OutwardInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutward(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function OutwardType_GetList(ByVal OT_NO As String, ByVal OT_PType As String) As List(Of OutwardInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardType_GetList")

            db.AddInParameter(dbComm, "@OT_NO", DbType.String, OT_NO)
            db.AddInParameter(dbComm, "@OT_PType", DbType.String, OT_PType)

            Dim FeatureList As New List(Of OutwardInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutward(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function OutwardType_GetName(ByVal OT_PType As String) As List(Of OutwardInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardType_GetName")

            db.AddInParameter(dbComm, "@OT_PType", DbType.String, OT_PType)

            Dim FeatureList As New List(Of OutwardInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutward(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function LookUpEdit_Get(ByVal OT_PType As String) As DataSet

            Using sqlconn As SqlConnection = New SqlConnection(ConnStr)

                Dim sqlcomd As New SqlCommand
                sqlcomd.Connection = sqlconn
                sqlcomd.CommandText = "OutwardType_GetName"
                sqlcomd.CommandType = CommandType.StoredProcedure
                Dim para As SqlParameter = New SqlParameter("@OT_PType", SqlDbType.NVarChar, 50)
                para.Value = OT_PType
                sqlcomd.Parameters.Add(para)
                Dim sqldt As New SqlDataAdapter(sqlcomd)
                Dim ds As New DataSet
                sqldt.Fill(ds)
                Return ds
            End Using

        End Function

        Public Function OutwardProperty_GetList(ByVal O_Type As String) As List(Of OutwardInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutwardProperty_GetList")

            db.AddInParameter(dbComm, "@O_Type", DbType.String, O_Type)

            Dim FeatureList As New List(Of OutwardInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOutward(reader))
                End While
                Return FeatureList
            End Using
        
        End Function
        ''' <summary>
        ''' 所有已申明字段的讀取
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillOutward(ByVal reader As IDataReader) As OutwardInfo
            '對應取得的數據
            On Error Resume Next
            Dim oi As New OutwardInfo

            '--------------------------------------------------------
            oi.O_NO = reader("O_NO").ToString
            If reader("O_Date") Is DBNull.Value Then
                oi.O_Date = Nothing
            Else
                oi.O_Date = CStr(reader("O_Date"))
            End If
            oi.O_Type = reader("O_Type").ToString
            oi.O_Action = reader("O_Action").ToString
            oi.WH_ID = reader("WH_ID").ToString
            oi.O_Remark = reader("O_Remark").ToString
            oi.S_Supplier = reader("S_Supplier").ToString

            '--------------------------------------------------------
            If reader("O_Check") Is DBNull.Value Then
                oi.O_Check = Nothing
            Else
                oi.O_Check = reader("O_Check")
            End If
            oi.O_CheckAction = reader("O_CheckAction").ToString
            If reader("O_CheckDate") Is DBNull.Value Then
                oi.O_CheckDate = Nothing
            Else
                oi.O_CheckDate = CStr(reader("O_CheckDate"))
            End If
            oi.O_CheckRemark = reader("O_CheckRemark").ToString

            '---------------------------------------------------------
            If reader("O_AccCheck") Is DBNull.Value Then
                oi.O_AccCheck = Nothing
            Else
                oi.O_AccCheck = reader("O_AccCheck")
            End If
            oi.O_AccCheckAction = reader("O_AccCheckAction").ToString
            If reader("O_AccCheckDate") Is DBNull.Value Then
                oi.O_AccCheckDate = Nothing
            Else
                oi.O_AccCheckDate = CStr(reader("O_AccCheckDate"))
            End If
            oi.O_AccCheckRemark = reader("O_AccCheckRemark").ToString
            oi.O_AccCheckType = reader("O_AccCheckType").ToString
            '---------------------------------------------------------
            oi.O_NOsub = reader("O_NOsub").ToString
            oi.M_Code = reader("M_Code").ToString
            oi.PM_M_Code = reader("PM_M_Code").ToString
            If reader("OS_Qty") Is DBNull.Value Then
                oi.OS_Qty = Nothing
            Else
                oi.OS_Qty = CDbl(reader("OS_Qty").ToString)
            End If
            If reader("OS_NoSendQty") Is DBNull.Value Then
                oi.OS_NoSendQty = Nothing
            Else
                oi.OS_NoSendQty = CDbl(reader("OS_NoSendQty").ToString)
            End If
            If reader("OS_Price") Is DBNull.Value Then
                oi.OS_Price = Nothing
            Else
                oi.OS_Price = CDbl(reader("OS_Price").ToString)
            End If
            oi.OS_ItemType = reader("OS_ItemType").ToString
            oi.OS_Depict = reader("OS_Depict").ToString
            oi.OS_BatchID = reader("OS_BatchID").ToString
            oi.OS_Remark = reader("OS_Remark").ToString

            '-----------------------------------------------------
            oi.M_Name = reader("M_Name").ToString
            oi.M_Gauge = reader("M_Gauge").ToString
            oi.M_Unit = reader("M_Unit").ToString
            oi.SupplierName = reader("SupplierName").ToString
            oi.ItemType = reader("ItemType").ToString
            '-----------------------------------------------------
            oi.OT_NO = reader("OT_NO").ToString
            oi.OT_Name = reader("OT_Name").ToString
            oi.OT_PType = reader("OT_PType").ToString
            oi.ActionName = reader("ActionName").ToString
            oi.CheckActionName = reader("CheckActionName").ToString
            oi.AccCheckActionName = reader("AccCheckActionName").ToString
            oi.WH_Name = reader("WH_Name").ToString

            oi.OP_Name = reader("OP_Name").ToString
            oi.OP_NO = reader("OP_NO").ToString
            oi.ExtraName = reader("ExtraName").ToString

            Return oi

        End Function

    End Class

End Namespace



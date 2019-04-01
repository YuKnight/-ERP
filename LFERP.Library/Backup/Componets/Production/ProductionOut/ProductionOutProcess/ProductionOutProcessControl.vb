Namespace LFERP.Library.ProductionOutProcess
    Public Class ProductionOutProcessControl
        ''' <summary>
        ''' 新增外發加工單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOutProcess_Add(ByVal objinfo As ProductionOutProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOutProcess_Add")

                db.AddInParameter(dbcomm, "@PO_ID", DbType.String, objinfo.PO_ID)
                db.AddInParameter(dbcomm, "@PO_Type", DbType.String, objinfo.PO_Type)
                db.AddInParameter(dbcomm, "@PO_OutDate", DbType.Date, objinfo.PO_OutDate)
                db.AddInParameter(dbcomm, "@PO_UserName", DbType.String, objinfo.PO_UserName)
                db.AddInParameter(dbcomm, "@S_Supplier", DbType.String, objinfo.S_Supplier)

                db.AddInParameter(dbcomm, "@PO_Remark", DbType.String, objinfo.PO_Remark)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbcomm, "@PO_ProAttribute", DbType.String, objinfo.PO_ProAttribute)
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, objinfo.PS_NO)

                db.AddInParameter(dbcomm, "@PS_Name", DbType.String, objinfo.PS_Name)
                db.AddInParameter(dbcomm, "@OW_Do", DbType.String, objinfo.OW_Do)
                db.AddInParameter(dbcomm, "@PO_Qty", DbType.Single, objinfo.PO_Qty)
                db.AddInParameter(dbcomm, "@PO_PM_Remark", DbType.String, objinfo.PO_PM_Remark)
                db.AddInParameter(dbcomm, "@AddUserID", DbType.String, objinfo.AddUserID)

                db.AddInParameter(dbcomm, "@AddDate", DbType.Date, objinfo.AddDate)

                db.ExecuteNonQuery(dbcomm)
                ProductionOutProcess_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutProcess_Add = False

            End Try
        End Function

        ''' <summary>
        ''' 添加備註
        '''  '2014-04-04  姚駿
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOutProcessRemark_Add(ByVal objinfo As ProductionOutProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOutProcessRemark_Add")

                db.AddInParameter(dbcomm, "@PO_PM_NO", DbType.String, objinfo.PO_PM_NO)
                db.AddInParameter(dbcomm, "@PO_PM_Type", DbType.String, objinfo.PO_PM_Type)
                db.AddInParameter(dbcomm, "@PO_PM_People", DbType.String, objinfo.PO_People)
                db.AddInParameter(dbcomm, "@PO_PM_BefRemark", DbType.String, objinfo.PO_PM_BefRemark)
                db.AddInParameter(dbcomm, "@PO_PM_LstRemark", DbType.String, objinfo.PO_PM_LstRemark)
                db.AddInParameter(dbcomm, "@PM_RemarkTime", DbType.String, objinfo.PM_RemarkTime)
                db.ExecuteNonQuery(dbcomm)
                ProductionOutProcessRemark_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutProcessRemark_Add = False

            End Try
        End Function


        ''' <summary>
        ''' 更改備註
        ''' '2014-04-04  姚駿
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOutProcess_UpdateRemark(ByVal objinfo As ProductionOutProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOutProcess_UpdateRemark")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbcomm, "@PO_PM_Remark", DbType.String, objinfo.PO_PM_Remark)
                db.ExecuteNonQuery(dbcomm)
                ProductionOutProcess_UpdateRemark = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutProcess_UpdateRemark = False

            End Try
        End Function


        ''' <summary>
        ''' 修改外發加工單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOutProcess_Update(ByVal objinfo As ProductionOutProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOutProcess_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbcomm, "@PO_ID", DbType.String, objinfo.PO_ID)
                db.AddInParameter(dbcomm, "@PO_Type", DbType.String, objinfo.PO_Type)
                db.AddInParameter(dbcomm, "@PO_OutDate", DbType.Date, objinfo.PO_OutDate)
                db.AddInParameter(dbcomm, "@PO_UserName", DbType.String, objinfo.PO_UserName)

                db.AddInParameter(dbcomm, "@S_Supplier", DbType.String, objinfo.S_Supplier)
                db.AddInParameter(dbcomm, "@PO_Remark", DbType.String, objinfo.PO_Remark)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbcomm, "@PO_ProAttribute", DbType.String, objinfo.PO_ProAttribute)

                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbcomm, "@PS_Name", DbType.String, objinfo.PS_Name)
                db.AddInParameter(dbcomm, "@OW_Do", DbType.String, objinfo.OW_Do)
                db.AddInParameter(dbcomm, "@PO_Qty", DbType.Int32, objinfo.PO_Qty)
                db.AddInParameter(dbcomm, "@PO_NoSendQty", DbType.Int32, objinfo.PO_NoSendQty)

                db.AddInParameter(dbcomm, "@PO_PM_Remark", DbType.String, objinfo.PO_PM_Remark)
                db.AddInParameter(dbcomm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbcomm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbcomm)
                ProductionOutProcess_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutProcess_Update = False

            End Try
        End Function
        ''' <summary>
        ''' 刪除外發加工單（或刪除外發加工單中某條外發記錄）
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="PO_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOutProcess_Delete(ByVal AutoID As String, ByVal PO_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOutProcess_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbcomm, "@PO_ID", DbType.String, PO_ID)

                db.ExecuteNonQuery(dbcomm)
                ProductionOutProcess_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutProcess_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' 外發加工單審核
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOutProcess_Check(ByVal objinfo As ProductionOutProcessInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutProcess_Check")

                'db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PO_ID", DbType.String, objinfo.PO_ID)
                db.AddInParameter(dbComm, "@PO_Check", DbType.Boolean, objinfo.PO_Check)
                db.AddInParameter(dbComm, "@PO_CheckDate", DbType.Date, objinfo.PO_CheckDate)
                db.AddInParameter(dbComm, "@PO_CheckUserID", DbType.String, objinfo.PO_CheckUserID)
                db.AddInParameter(dbComm, "@PO_CheckRemark", DbType.String, objinfo.PO_CheckRemark)
                db.ExecuteNonQuery(dbComm)

                ProductionOutProcess_Check = True

            Catch ex As Exception
                ProductionOutProcess_Check = False
                MsgBox(ex.Message)
            End Try
        End Function
        ''' <summary>
        ''' 按條件查詢外發加工單
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="PO_ID"></param>
        ''' <param name="PO_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="PS_NO"></param>
        ''' <param name="S_Supplier"></param>
        ''' <param name="PO_OutDateBegin"></param>
        ''' <param name="PO_OutDateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOutProcess_GetList(ByVal AutoID As String, ByVal PO_ID As String, ByVal PO_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_NO As String, ByVal S_Supplier As String, ByVal PO_OutDateBegin As String, ByVal PO_OutDateEnd As String, ByVal PO_NoSendQty As Int32) As List(Of ProductionOutProcessInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutProcess_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PO_ID", DbType.String, PO_ID)
            db.AddInParameter(dbComm, "@PO_Type", DbType.String, PO_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)

            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)
            db.AddInParameter(dbComm, "@PO_OutDateBegin", DbType.String, PO_OutDateBegin)
            db.AddInParameter(dbComm, "@PO_OutDateEnd", DbType.String, PO_OutDateEnd)

            db.AddInParameter(dbComm, "@PO_NoSendQty", DbType.Int32, PO_NoSendQty)

            Dim FeatureList As New List(Of ProductionOutProcessInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionOutProcess(reader))
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
        Public Function FillProductionOutProcess(ByVal reader As IDataReader) As ProductionOutProcessInfo

            'On Error Resume Next

            Dim pai As New ProductionOutProcessInfo


            If reader("PM_JiYu") Is DBNull.Value Then
                pai.PM_JiYu = Nothing
            Else
                pai.PM_JiYu = reader("PM_JiYu")
            End If

            pai.AutoID = reader("AutoID").ToString
            pai.PO_ID = reader("PO_ID").ToString
            pai.PO_Type = reader("PO_Type").ToString
            pai.PO_OutDate = reader("PO_OutDate").ToString
            pai.PO_UserName = reader("PO_UserName").ToString

            pai.S_Supplier = reader("S_Supplier").ToString
            pai.S_SupplierName = reader("S_SupplierName").ToString
            If reader("PO_Remark") Is DBNull.Value Then
                pai.PO_Remark = Nothing
            Else
                pai.PO_Remark = reader("PO_Remark")
            End If
            pai.PM_M_Code = reader("PM_M_Code").ToString
            pai.PM_Type = reader("PM_Type").ToString

            pai.PO_ProAttribute = reader("PO_ProAttribute").ToString
            pai.PS_NO = reader("PS_NO").ToString
            pai.PS_Name = reader("PS_Name").ToString
            pai.OW_Do = reader("OW_Do")
            pai.PO_Qty = CInt(reader("PO_Qty"))

            pai.PO_NoSendQty = CInt(reader("PO_NoSendQty"))
            If reader("PO_PM_Remark") Is DBNull.Value Then
                pai.PO_PM_Remark = Nothing
            Else
                pai.PO_PM_Remark = reader("PO_PM_Remark")
            End If

            If reader("PO_Check") Is DBNull.Value Then
                pai.PO_Check = False
            Else
                pai.PO_Check = reader("PO_Check")
            End If

            If reader("PO_CheckDate") Is DBNull.Value Then
                pai.PO_CheckDate = Nothing
            Else
                pai.PO_CheckDate = reader("PO_CheckDate")
            End If

            If reader("PO_CheckUserID") Is DBNull.Value Then
                pai.PO_CheckUserID = Nothing
            Else
                pai.PO_CheckUserID = reader("PO_CheckUserID")
            End If

            If reader("PO_CheckUserName") Is DBNull.Value Then
                pai.PO_CheckUserName = Nothing
            Else
                pai.PO_CheckUserName = reader("PO_CheckUserName")
            End If

            If reader("PO_CheckRemark") Is DBNull.Value Then
                pai.PO_CheckRemark = Nothing
            Else
                pai.PO_CheckRemark = reader("PO_CheckRemark")
            End If

            Return pai
        End Function

        ''' <summary>
        ''' 增加更改單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOutRetrocede_Add(ByVal objinfo As ProductionOutProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOutRetrocede_Add")

                db.AddInParameter(dbcomm, "@RecordNO", DbType.String, objinfo.RecordNO)
                db.AddInParameter(dbcomm, "@R_Qty", DbType.Double, objinfo.R_Qty)
                db.AddInParameter(dbcomm, "@N_Qty", DbType.Double, objinfo.N_Qty)

                db.AddInParameter(dbcomm, "@R_Action", DbType.String, objinfo.R_Action)
                db.AddInParameter(dbcomm, "@R_Date", DbType.Date, objinfo.R_Date)
                db.AddInParameter(dbcomm, "@R_Remark", DbType.String, objinfo.R_Remark)

                db.ExecuteNonQuery(dbcomm)
                ProductionOutRetrocede_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutRetrocede_Add = False

            End Try
        End Function
        ''' <summary>
        ''' 查詢記錄
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="RecordNO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOutRetrocede_GetList(ByVal AutoID As String, ByVal RecordNO As String) As List(Of ProductionOutProcessInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutRetrocede_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@RecordNO", DbType.String, RecordNO)


            Dim FeatureList As New List(Of ProductionOutProcessInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionOutRetrocede(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 載入更改單記錄
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionOutRetrocede(ByVal reader As IDataReader) As ProductionOutProcessInfo

            'On Error Resume Next

            Dim pai As New ProductionOutProcessInfo



            pai.AutoID = reader("AutoID").ToString
            pai.RecordNO = reader("RecordNO").ToString

            pai.R_Qty = reader("R_Qty")
            pai.N_Qty = reader("N_Qty")

            If reader("R_Action") Is DBNull.Value Then
                pai.R_Action = Nothing
            Else
                pai.R_Action = reader("R_Action").ToString
            End If

            If reader("R_ActionName") Is DBNull.Value Then
                pai.R_ActionName = Nothing
            Else
                pai.R_ActionName = reader("R_ActionName").ToString
            End If

            If reader("R_Date") Is DBNull.Value Then
                pai.R_Date = Nothing
            Else
                pai.R_Date = reader("R_Date")
            End If

            If reader("R_Remark") Is DBNull.Value Then
                pai.R_Remark = Nothing
            Else
                pai.R_Remark = reader("R_Remark").ToString
            End If

            If reader("PM_M_Code") Is DBNull.Value Then
                pai.PM_M_Code = Nothing
            Else
                pai.PM_M_Code = reader("PM_M_Code").ToString
            End If

            If reader("PM_Type") Is DBNull.Value Then
                pai.PM_Type = Nothing
            Else
                pai.PM_Type = reader("PM_Type").ToString
            End If

            Return pai
        End Function

    End Class
End Namespace


Namespace LFERP.Library.Purchase.ApplyPurchase

    Public Class ApplyPurchaseControl
        ''' <summary>
        ''' 新增申購單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ApplyPurchase_Add(ByVal objinfo As ApplyPurchaseInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_Add")

                db.AddInParameter(dbcomm, "@AP_ID", DbType.String, objinfo.AP_ID)
                db.AddInParameter(dbcomm, "@AP_ApplyID", DbType.String, objinfo.AP_ApplyID)
                db.AddInParameter(dbcomm, "@AP_M_Code", DbType.String, objinfo.AP_M_Code)
                db.AddInParameter(dbcomm, "@AP_M_Name", DbType.String, objinfo.AP_M_Name)
                db.AddInParameter(dbcomm, "@AP_M_Gauge", DbType.String, objinfo.AP_M_Gauge)
                db.AddInParameter(dbcomm, "@AP_M_Unit", DbType.String, objinfo.AP_M_Unit)
                db.AddInParameter(dbcomm, "@AP_Num", DbType.String, objinfo.AP_Num)
                db.AddInParameter(dbcomm, "@AP_Qty", DbType.Single, objinfo.AP_Qty)
                db.AddInParameter(dbcomm, "@AP_Applyreason", DbType.String, objinfo.AP_Applyreason)
                db.AddInParameter(dbcomm, "@AP_ApplyDate", DbType.String, objinfo.AP_ApplyDate)
                db.AddInParameter(dbcomm, "@AP_ApplyDptID", DbType.String, objinfo.AP_ApplyDptID)
                db.AddInParameter(dbcomm, "@AP_ApplyPerson", DbType.String, objinfo.AP_ApplyPerson)
                db.AddInParameter(dbcomm, "@AP_ApplyPersonName", DbType.String, objinfo.AP_ApplyPersonName)
                db.AddInParameter(dbcomm, "@AP_Action", DbType.String, objinfo.AP_Action)
                db.AddInParameter(dbcomm, "@AP_CheckWare", DbType.Boolean, objinfo.AP_CheckWare)
                db.AddInParameter(dbcomm, "@AP_Check", DbType.Boolean, objinfo.AP_Check)
                db.AddInParameter(dbcomm, "@AP_CheckDate", DbType.String, objinfo.AP_CheckDate)
                db.AddInParameter(dbcomm, "@AP_CheckAction", DbType.String, objinfo.AP_CheckAction)
                db.AddInParameter(dbcomm, "@AP_CheckType", DbType.String, objinfo.AP_CheckType)
                db.AddInParameter(dbcomm, "@AP_CheckRemark", DbType.String, objinfo.AP_CheckRemark)
                db.AddInParameter(dbcomm, "@AP_ReCheck", DbType.Boolean, objinfo.AP_ReCheck)
                db.AddInParameter(dbcomm, "@AP_ReCheckDate", DbType.String, objinfo.AP_ReCheckDate)
                db.AddInParameter(dbcomm, "@AP_ReCheckAction", DbType.String, objinfo.AP_ReCheckAction)
                db.AddInParameter(dbcomm, "@AP_ReCheckType", DbType.String, objinfo.AP_ReCheckType)
                db.AddInParameter(dbcomm, "@AP_ReCheckRemark", DbType.String, objinfo.AP_ReCheckRemark)

                db.ExecuteNonQuery(dbcomm)
                ApplyPurchase_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ApplyPurchase_Add = False

            End Try
        End Function
        ''' <summary>
        ''' 修改申購單
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ApplyPurchase_Update(ByVal objinfo As ApplyPurchaseInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_Update")

                db.AddInParameter(dbcomm, "@AP_ID", DbType.String, objinfo.AP_ID)
                db.AddInParameter(dbcomm, "@AP_ApplyID", DbType.String, objinfo.AP_ApplyID)
                db.AddInParameter(dbcomm, "@AP_M_Code", DbType.String, objinfo.AP_M_Code)
                db.AddInParameter(dbcomm, "@AP_M_Name", DbType.String, objinfo.AP_M_Name)
                db.AddInParameter(dbcomm, "@AP_M_Gauge", DbType.String, objinfo.AP_M_Gauge)
                db.AddInParameter(dbcomm, "@AP_M_Unit", DbType.String, objinfo.AP_M_Unit)
                db.AddInParameter(dbcomm, "@AP_Num", DbType.String, objinfo.AP_Num)
                db.AddInParameter(dbcomm, "@AP_Qty", DbType.Single, objinfo.AP_Qty)
                db.AddInParameter(dbcomm, "@AP_Applyreason", DbType.String, objinfo.AP_Applyreason)
                db.AddInParameter(dbcomm, "@AP_ApplyDate", DbType.String, objinfo.AP_ApplyDate)
                db.AddInParameter(dbcomm, "@AP_ApplyDptID", DbType.String, objinfo.AP_ApplyDptID)
                db.AddInParameter(dbcomm, "@AP_ApplyPerson", DbType.String, objinfo.AP_ApplyPerson)
                db.AddInParameter(dbcomm, "@AP_ApplyPersonName", DbType.String, objinfo.AP_ApplyPersonName)
                db.AddInParameter(dbcomm, "@AP_Action", DbType.String, objinfo.AP_Action)
                'db.AddInParameter(dbcomm, "@AP_CheckWare", DbType.Boolean, objinfo.AP_CheckWare)
                db.ExecuteNonQuery(dbcomm)
                ApplyPurchase_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ApplyPurchase_Update = False
            End Try
        End Function
        ''' <summary>
        ''' 刪除申購單（或刪除申購單中某條申購記錄）
        ''' </summary>
        ''' <param name="AP_ID"></param>
        ''' <param name="AP_Num"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ApplyPurchase_Delete(ByVal AP_ID As String, ByVal AP_Num As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_Delete")

                db.AddInParameter(dbcomm, "@AP_ID", DbType.String, AP_ID)
                db.AddInParameter(dbcomm, "@AP_Num", DbType.String, AP_Num)
                db.ExecuteNonQuery(dbcomm)
                ApplyPurchase_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ApplyPurchase_Delete = False
            End Try
        End Function
        Public Function ApplyPurchase_Get(ByVal AP_Num As String) As ApplyPurchaseInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_Get")

            db.AddInParameter(dbComm, "@AP_Num", DbType.String, AP_Num)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillApplyPurchase(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 按條件查詢申購單
        ''' </summary>
        ''' <param name="AP_ID"></param>
        ''' <param name="AP_M_Code"></param>
        ''' <param name="AP_M_Name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Function ApplyPurchase_GetList(ByVal AP_ID As String, ByVal AP_M_Code As String, ByVal AP_M_Name As String) As List(Of ApplyPurchaseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_GetList")
            db.AddInParameter(dbComm, "@AP_ID", DbType.String, AP_ID)
            db.AddInParameter(dbComm, "@AP_M_Code", DbType.String, AP_M_Code)
            db.AddInParameter(dbComm, "@AP_M_Name", DbType.String, AP_M_Name)

            Dim FeatureList As New List(Of ApplyPurchaseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillApplyPurchase(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 按條件查詢申購單
        ''' </summary>
        ''' <param name="AP_ID"></param>
        ''' <param name="AP_M_Code"></param>
        ''' <param name="AP_M_Name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Function ApplyPurchase_GetList1(ByVal AP_ID As String, ByVal AP_M_Code As String, ByVal AP_M_Name As String, ByVal AP_M_Gauge As String, ByVal AP_ApplyDptID As String, ByVal AP_ApplyDateStart As String, ByVal AP_ApplyDateEnd As String) As List(Of ApplyPurchaseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_GetList1")
            db.AddInParameter(dbComm, "@AP_ID", DbType.String, AP_ID)
            db.AddInParameter(dbComm, "@AP_M_Code", DbType.String, AP_M_Code)
            db.AddInParameter(dbComm, "@AP_M_Name", DbType.String, AP_M_Name)
            db.AddInParameter(dbComm, "@AP_M_Gauge", DbType.String, AP_M_Gauge)
            db.AddInParameter(dbComm, "@AP_ApplyDptID", DbType.String, AP_ApplyDptID)
            db.AddInParameter(dbComm, "@AP_ApplyDateStart", DbType.String, AP_ApplyDateStart)
            db.AddInParameter(dbComm, "@AP_ApplyDateEnd", DbType.String, AP_ApplyDateEnd)

            Dim FeatureList As New List(Of ApplyPurchaseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillApplyPurchase(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 按條件查詢申購單
        ''' </summary>
        ''' <param name="AP_ID"></param>
        ''' <param name="AP_M_Code"></param>
        ''' <param name="AP_M_Name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        ''' 
        Public Function ApplyPurchase_GetList2(ByVal AP_ID As String, ByVal AP_M_Code As String, ByVal AP_M_Name As String) As List(Of ApplyPurchaseInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_GetList2")
            db.AddInParameter(dbComm, "@AP_ID", DbType.String, AP_ID)
            db.AddInParameter(dbComm, "@AP_M_Code", DbType.String, AP_M_Code)
            db.AddInParameter(dbComm, "@AP_M_Name", DbType.String, AP_M_Name)

            Dim FeatureList As New List(Of ApplyPurchaseInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillApplyPurchase(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ApplyPurchase_GetID(ByVal Ndate As String) As ApplyPurchaseInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_GetID")
            db.AddInParameter(dbComm, "@Ndate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillApplyPurchase(reader)
                End While
                Return Nothing
            End Using

        End Function
        Public Function ApplyPurchase_GetNum(ByVal AP_Num As String) As ApplyPurchaseInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_GetNum")
            db.AddInParameter(dbComm, "@AP_Num", DbType.String, AP_Num)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillApplyPurchase(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ApplyPurchase_UpdateCheck(ByVal objinfo As ApplyPurchaseInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_UpdateCheck")

                db.AddInParameter(dbComm, "@AP_ID", DbType.String, objinfo.AP_ID)
                db.AddInParameter(dbComm, "@AP_Num", DbType.String, objinfo.AP_Num)
                db.AddInParameter(dbComm, "@AP_CheckWare", DbType.Boolean, objinfo.AP_CheckWare)
                db.AddInParameter(dbComm, "@AP_Check", DbType.Boolean, objinfo.AP_Check)
                db.AddInParameter(dbComm, "@AP_CheckDate", DbType.String, objinfo.AP_CheckDate)
                db.AddInParameter(dbComm, "@AP_CheckAction", DbType.String, objinfo.AP_CheckAction)
                db.AddInParameter(dbComm, "@AP_CheckType", DbType.String, objinfo.AP_CheckType)
                db.AddInParameter(dbComm, "@AP_CheckRemark", DbType.String, objinfo.AP_CheckRemark)
                db.ExecuteNonQuery(dbComm)

                ApplyPurchase_UpdateCheck = True

            Catch ex As Exception
                ApplyPurchase_UpdateCheck = False
                MsgBox(ex.Message)

            End Try
          

        End Function
        Public Function ApplyPurchase_UpdateReCheck(ByVal objinfo As ApplyPurchaseInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ApplyPurchase_UpdateReCheck")

                db.AddInParameter(dbComm, "@AP_ID", DbType.String, objinfo.AP_ID)
                db.AddInParameter(dbComm, "@AP_Num", DbType.String, objinfo.AP_Num)
                db.AddInParameter(dbComm, "@AP_CheckWare", DbType.Boolean, objinfo.AP_CheckWare)
                db.AddInParameter(dbComm, "@AP_ReCheck", DbType.Boolean, objinfo.AP_ReCheck)
                db.AddInParameter(dbComm, "@AP_ReCheckDate", DbType.String, objinfo.AP_ReCheckDate)
                db.AddInParameter(dbComm, "@AP_ReCheckAction", DbType.String, objinfo.AP_ReCheckAction)
                db.AddInParameter(dbComm, "@AP_ReCheckType", DbType.String, objinfo.AP_ReCheckType)
                db.AddInParameter(dbComm, "@AP_ReCheckRemark", DbType.String, objinfo.AP_ReCheckRemark)
                db.ExecuteNonQuery(dbComm)

                ApplyPurchase_UpdateReCheck = True

            Catch ex As Exception
                ApplyPurchase_UpdateReCheck = False
                MsgBox(ex.Message)
            End Try
          

        End Function
        ''' <summary>
        ''' 獲取字段值
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillApplyPurchase(ByVal reader As IDataReader) As ApplyPurchaseInfo

            On Error Resume Next

            Dim api As New ApplyPurchaseInfo

            api.AP_ID = reader("AP_ID").ToString
            api.AP_Num = reader("AP_Num").ToString
            api.AP_ApplyID = reader("AP_ApplyID").ToString
            api.AP_M_Code = reader("AP_M_Code").ToString
            api.AP_M_Gauge = reader("AP_M_Gauge").ToString
            api.AP_M_Unit = reader("AP_M_Unit").ToString
            api.AP_M_Name = reader("AP_M_Name").ToString
            api.AP_Qty = CSng(reader("AP_Qty").ToString)
            api.AP_P_Qty = CSng(reader("AP_P_Qty").ToString)
            api.AP_Applyreason = reader("AP_Applyreason").ToString
            api.AP_ApplyDate = Format(reader("AP_ApplyDate"), "yyyy/MM/dd").ToString
            'api.AP_ApplyDate = reader("AP_ApplyDate").ToString
            api.AP_ApplyDptID = reader("AP_ApplyDptID").ToString
            api.AP_ApplyDptName = reader("AP_UpDptName").ToString & "-" & reader("AP_ApplyDptName").ToString
            'api.AP_ApplyDptName = reader("AP_ApplyDptName").ToString
            api.AP_ApplyPerson = reader("AP_ApplyPerson").ToString
            api.AP_ApplyPersonName = reader("AP_ApplyPersonName").ToString
            api.AP_Action = reader("AP_Action").ToString

            If reader("AP_CheckWare") Is DBNull.Value Then
                api.AP_CheckWare = Nothing
            Else
                api.AP_CheckWare = reader("AP_CheckWare")
            End If
            If reader("AP_Check") Is DBNull.Value Then
                api.AP_Check = Nothing
            Else
                api.AP_Check = reader("AP_Check")
            End If

            If reader("AP_CheckDate") Is DBNull.Value Then
                api.AP_CheckDate = Nothing
            Else
                api.AP_CheckDate = CStr(reader("AP_CheckDate"))
            End If

            api.AP_CheckAction = reader("AP_CheckAction").ToString
            api.AP_CheckType = reader("AP_CheckType").ToString
            api.AP_CheckRemark = reader("AP_CheckRemark").ToString

            If reader("AP_ReCheck") Is DBNull.Value Then
                api.AP_ReCheck = Nothing
            Else
                api.AP_ReCheck = reader("AP_ReCheck")
            End If

            If reader("AP_ReCheckDate") Is DBNull.Value Then
                api.AP_ReCheckDate = Nothing
            Else
                api.AP_ReCheckDate = CStr(reader("AP_ReCheckDate"))
            End If

            api.AP_ReCheckAction = reader("AP_ReCheckAction").ToString
            api.AP_ReCheckType = reader("AP_ReCheckType").ToString
            api.AP_ReCheckRemark = reader("AP_ReCheckRemark").ToString

            Return api
        End Function

    End Class

End Namespace

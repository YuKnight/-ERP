

Namespace LFERP.Library.Purchase.Change

    Public Class ChangeControl
        ''' <summary>
        ''' 更改單新增
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Change_Add(ByVal objinfo As ChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Change_Add")

                db.AddInParameter(dbcomm, "@C_ChangeNO", DbType.String, objinfo.C_ChangeNO)
                db.AddInParameter(dbcomm, "@C_Type", DbType.String, objinfo.C_Type)
                db.AddInParameter(dbcomm, "@PM_NO", DbType.String, objinfo.PM_NO)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@C_NoSendQty", DbType.Double, objinfo.C_NoSendQty)
                db.AddInParameter(dbcomm, "@C_Price", DbType.Double, objinfo.C_Price)
                db.AddInParameter(dbcomm, "@C_Date", DbType.Date, objinfo.C_Date)
                db.AddInParameter(dbcomm, "@C_Remark", DbType.String, objinfo.C_Remark)
                db.AddInParameter(dbcomm, "@C_Action", DbType.String, objinfo.C_Action)
                db.AddInParameter(dbcomm, "@C_Reason", DbType.String, objinfo.C_Reason)
                db.AddInParameter(dbcomm, "@PM_Qty", DbType.Double, objinfo.PM_Qty)
                db.AddInParameter(dbcomm, "@PM_PurchaseQty", DbType.Double, objinfo.PM_PurchaseQty)
                db.AddInParameter(dbcomm, "@S_Supplier", DbType.String, objinfo.S_Supplier)

                db.AddInParameter(dbcomm, "@C_Qty", DbType.Double, objinfo.C_Qty)

                db.ExecuteNonQuery(dbcomm)
                Change_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Change_Add = False

            End Try

        End Function
        ''' <summary>
        ''' 更改單修改
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Change_Update(ByVal objinfo As ChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Change_Update")

                db.AddInParameter(dbcomm, "@IndexNO", DbType.String, objinfo.IndexNO)
                db.AddInParameter(dbcomm, "@C_Type", DbType.String, objinfo.C_Type)
                db.AddInParameter(dbcomm, "@C_Date", DbType.Date, objinfo.C_Date)
                db.AddInParameter(dbcomm, "@C_NoSendQty", DbType.Double, objinfo.C_NoSendQty)
                db.AddInParameter(dbcomm, "@C_Price", DbType.Double, objinfo.C_Price)
                db.AddInParameter(dbcomm, "@C_Action", DbType.String, objinfo.C_Action)
                db.AddInParameter(dbcomm, "@C_Reason", DbType.String, objinfo.C_Reason)

                db.AddInParameter(dbcomm, "@C_Qty", DbType.Double, objinfo.C_Qty)

                db.ExecuteNonQuery(dbcomm)
                Change_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Change_Update = False
            End Try
        End Function
        ''' <summary>
        ''' 更改單審核
        ''' </summary>
        ''' <param name="objinfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Change_Check(ByVal objinfo As ChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Change_Check")

                db.AddInParameter(dbcomm, "@C_ChangeNO", DbType.String, objinfo.C_ChangeNO)
                db.AddInParameter(dbcomm, "@C_Check", DbType.Boolean, objinfo.C_Check)
                db.AddInParameter(dbcomm, "@C_CheckDate", DbType.Date, objinfo.C_CheckDate)
                db.AddInParameter(dbcomm, "@C_CheckType", DbType.String, objinfo.C_CheckType)
                db.AddInParameter(dbcomm, "@C_CheckRemark", DbType.String, objinfo.C_CheckRemark)
                db.AddInParameter(dbcomm, "@C_CheckAction", DbType.String, objinfo.C_CheckAction)

                db.ExecuteNonQuery(dbcomm)
                Change_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Change_Check = False
            End Try
        End Function
        ''' <summary>
        ''' 更改單刪除（整個採購單）
        ''' </summary>
        ''' <param name="PM_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Change_Del(ByVal C_ChangeNO As String, ByVal PM_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Change_Del")

                db.AddInParameter(dbcomm, "@C_ChangeNO", DbType.String, C_ChangeNO)
                db.AddInParameter(dbcomm, "@PM_NO", DbType.String, PM_NO)

                db.ExecuteNonQuery(dbcomm)
                Change_Del = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Change_Del = False

            End Try

        End Function
        ''' <summary>
        ''' 更改單刪除（採購單中某一條記錄）
        ''' </summary>
        ''' <param name="IndexNo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Change_DelIndexNo(ByVal IndexNO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Change_DelIndexNo")

                db.AddInParameter(dbcomm, "@IndexNO", DbType.String, IndexNO)
                db.ExecuteNonQuery(dbcomm)
                Change_DelIndexNo = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Change_DelIndexNo = False

            End Try
        End Function
        Public Function Change_GetNo(ByVal Ndate As String) As ChangeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Change_GetNo")
            db.AddInParameter(dbComm, "@Ndate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillChange(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 更改單查詢
        ''' </summary>
        ''' <param name="PM_NO"></param>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Change_GetList(ByVal C_ChangeNO As String, ByVal PM_NO As String, ByVal M_Code As String, ByVal C_Check As String) As List(Of ChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Change_GetList")

            db.AddInParameter(dbComm, "@C_ChangeNO", DbType.String, C_ChangeNO)
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
          
            db.AddInParameter(dbComm, "@C_Check", DbType.String, C_Check)

            Dim FeatureList As New List(Of ChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillChange(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 更改單報表匯總查詢
        ''' </summary>
        ''' <param name="C_Date1"></param>
        ''' <param name="C_Date2"></param>
        ''' <param name="S_Supplier"></param>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

      
        Public Function ChangeGroup_GetList(ByVal C_Date1 As String, ByVal C_Date2 As String, ByVal S_Supplier As String, ByVal M_Code As String) As List(Of ChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ChangeGroup_GetList")

            db.AddInParameter(dbComm, "@C_Date1", DbType.String, C_Date1)
            db.AddInParameter(dbComm, "@C_Date2", DbType.String, C_Date2)
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of ChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillChange(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 更改單讀取字段值
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillChange(ByVal reader As IDataReader) As ChangeInfo
            '對應取得的數據
            On Error Resume Next

            Dim ci As New ChangeInfo

            ci.IndexNO = reader("IndexNO").ToString

            '--------------------------------------------------------------------
            ci.C_ChangeNO = reader("C_ChangeNO").ToString
            ci.C_Type = reader("C_Type").ToString
            ci.PM_NO = reader("PM_NO").ToString
            ci.M_Code = reader("M_Code").ToString
            ci.C_Remark = reader("C_Remark").ToString

            If reader("C_NoSendQty") Is DBNull.Value Then
                ci.C_NoSendQty = Nothing
            Else
                ci.C_NoSendQty = CDbl(reader("C_NoSendQty").ToString)
            End If
            If reader("C_Price") Is DBNull.Value Then
                ci.C_Price = Nothing
            Else
                ci.C_Price = CDbl(reader("C_Price").ToString)
            End If
            If reader("C_Date") Is DBNull.Value Then
                ci.C_Date = Nothing
            Else
                ci.C_Date = CStr(reader("C_Date"))
            End If
            ci.C_Action = reader("C_Action").ToString
            If reader("PM_Qty") Is DBNull.Value Then
                ci.PM_Qty = Nothing
            Else
                ci.PM_Qty = CDbl(reader("PM_Qty").ToString)
            End If
            If reader("PM_PurchaseQty") Is DBNull.Value Then
                ci.PM_PurchaseQty = Nothing
            Else
                ci.PM_PurchaseQty = CDbl(reader("PM_PurchaseQty").ToString)
            End If
            '--------------------------------------------------------------------
            If reader("C_Check") Is DBNull.Value Then
                ci.C_Check = False
            Else
                ci.C_Check = reader("C_Check")
            End If
            If reader("C_CheckDate") Is DBNull.Value Then
                ci.C_CheckDate = Nothing
            Else
                ci.C_CheckDate = CStr(reader("C_CheckDate"))
            End If
            ci.C_CheckType = reader("C_CheckType").ToString
            ci.C_CheckRemark = reader("C_CheckRemark").ToString
            ci.C_CheckAction = reader("C_CheckAction").ToString

            '---------------------------------------------------------------------
            ci.M_Gauge = reader("M_Gauge").ToString
            ci.M_Name = reader("M_Name").ToString
            ci.M_Unit = reader("M_Unit").ToString
            ci.ActionName = reader("ActionName").ToString
            ci.CheckActionName = reader("CheckActionName").ToString

            ci.C_Reason = reader("C_Reason").ToString
            ci.S_Supplier = reader("S_Supplier").ToString
            ci.S_SupplierName = reader("S_SupplierName").ToString


            If reader("C_Qty") Is DBNull.Value Then
                ci.C_Qty = Nothing
            Else
                ci.C_Qty = CDbl(reader("C_Qty").ToString)
            End If

            Return ci

        End Function

    End Class

End Namespace


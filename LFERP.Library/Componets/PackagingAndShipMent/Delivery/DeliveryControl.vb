
Namespace LFERP.Library.Delivery

    Public Class DeliveryControl
        '送貨單添加
        Public Function DeliveryNote_Add(ByVal objinfo As DeliveryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryNote_Add")

                db.AddInParameter(dbComm, "@DN_ID", DbType.String, objinfo.DN_ID)
                db.AddInParameter(dbComm, "@DN_Date", DbType.Date, objinfo.DN_Date)
                db.AddInParameter(dbComm, "@DN_Remark", DbType.String, objinfo.DN_Remark)
                db.AddInParameter(dbComm, "@DN_Action", DbType.String, objinfo.DN_Action)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@DN_CusterNO", DbType.String, objinfo.DN_CusterNO)
                db.AddInParameter(dbComm, "@DN_Type", DbType.String, objinfo.DN_Type)
                db.AddInParameter(dbComm, "@DN_Charge", DbType.String, objinfo.DN_Charge)
                db.AddInParameter(dbComm, "@DN_Invoice", DbType.Boolean, objinfo.DN_Invoice)
                db.AddInParameter(dbComm, "@DN_Return", DbType.Boolean, objinfo.DN_Return)

                db.ExecuteNonQuery(dbComm)
                DeliveryNote_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryNote_Add = False
            End Try
         
        End Function
        '送貨單修改
        Public Function DeliveryNote_Update(ByVal objinfo As DeliveryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryNote_Update")

                db.AddInParameter(dbComm, "@DN_ID", DbType.String, objinfo.DN_ID)
                db.AddInParameter(dbComm, "@DN_Date", DbType.Date, objinfo.DN_Date)
                db.AddInParameter(dbComm, "@DN_Remark", DbType.String, objinfo.DN_Remark)
                db.AddInParameter(dbComm, "@DN_Action", DbType.String, objinfo.DN_Action)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@DN_CusterNO", DbType.String, objinfo.DN_CusterNO)
                db.AddInParameter(dbComm, "@DN_Type", DbType.String, objinfo.DN_Type)
                db.AddInParameter(dbComm, "@DN_Charge", DbType.String, objinfo.DN_Charge)
                db.AddInParameter(dbComm, "@DN_Invoice", DbType.Boolean, objinfo.DN_Invoice)
                db.AddInParameter(dbComm, "@DN_Return", DbType.Boolean, objinfo.DN_Return)

                db.ExecuteNonQuery(dbComm)
                DeliveryNote_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryNote_Update = False
            End Try
        End Function
        '送貨單刪除
        Public Function DeliveryNote_Delete(ByVal DN_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryNote_Delete")

                db.AddInParameter(dbComm, "@DN_ID", DbType.String, DN_ID)

                db.ExecuteNonQuery(dbComm)
                DeliveryNote_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryNote_Delete = True
            End Try
        End Function
        '取得送貨單最大一條ID記錄
        Public Function DeliveryNote_GetNO(ByVal Ndate As String) As DeliveryInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryNote_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillDelivery(reader)
                End While
                Return Nothing
            End Using
        End Function
        '送貨單查詢
        Public Function DeliveryNote_GetList(ByVal DN_ID As String, ByVal DN_Date1 As String, ByVal DN_Date2 As String, ByVal DN_Action As String, ByVal WH_ID As String, ByVal DN_CusterNO As String, ByVal DN_Check As String, ByVal DN_AccCheck As String) As List(Of DeliveryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryNote_GetList")

            db.AddInParameter(dbComm, "@DN_ID", DbType.String, DN_ID)
            db.AddInParameter(dbComm, "@DN_Date1", DbType.String, DN_Date1)
            db.AddInParameter(dbComm, "@DN_Date2", DbType.String, DN_Date2)
            db.AddInParameter(dbComm, "@DN_Action", DbType.String, DN_Action)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DN_CusterNO", DbType.String, DN_CusterNO)
            db.AddInParameter(dbComm, "@DN_Check", DbType.String, DN_Check)
            db.AddInParameter(dbComm, "@DN_AccCheck", DbType.String, DN_AccCheck)

            Dim FeatureList As New List(Of DeliveryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillDelivery(reader))
                End While
                Return FeatureList
            End Using

        End Function
        '送貨單審核
        Public Function DeliveryNote_UpdateCheck(ByVal Objinfo As DeliveryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryNote_UpdateCheck")

                db.AddInParameter(dbComm, "@DN_ID", DbType.String, Objinfo.DN_ID)
                db.AddInParameter(dbComm, "@DN_Check", DbType.Boolean, Objinfo.DN_Check)
                db.AddInParameter(dbComm, "@DN_CheckAction", DbType.String, Objinfo.DN_CheckAction)
                db.AddInParameter(dbComm, "@DN_CheckDate", DbType.Date, Objinfo.DN_CheckDate)
                db.AddInParameter(dbComm, "@DN_CheckRemark", DbType.String, Objinfo.DN_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                DeliveryNote_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryNote_UpdateCheck = False
            End Try
        End Function
        '送貨單復核
        Public Function DeliveryNote_UpdateAccCheck(ByVal Objinfo As DeliveryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryNote_UpdateAccCheck")


                db.AddInParameter(dbComm, "@DN_ID", DbType.String, Objinfo.DN_ID)
                db.AddInParameter(dbComm, "@DN_Check", DbType.Boolean, Objinfo.DN_AccCheck)
                db.AddInParameter(dbComm, "@DN_CheckAction", DbType.String, Objinfo.DN_AccCheckAction)
                db.AddInParameter(dbComm, "@DN_CheckDate", DbType.Date, Objinfo.DN_AccCheckDate)
                db.AddInParameter(dbComm, "@DN_AccCheckType", DbType.String, Objinfo.DN_AccCheckType)
                db.AddInParameter(dbComm, "@DN_CheckRemark", DbType.String, Objinfo.DN_AccCheckRemark)

                db.ExecuteNonQuery(dbComm)
                DeliveryNote_UpdateAccCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryNote_UpdateAccCheck = False
            End Try
        End Function
        '送貨單裝箱表添加
        Public Function DeliveryPacking_Add(ByVal Objinfo As DeliveryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryPacking_Add")

                db.AddInParameter(dbComm, "@DN_ID", DbType.String, Objinfo.DN_ID)
                db.AddInParameter(dbComm, "@P_NO", DbType.String, Objinfo.P_NO)
                db.AddInParameter(dbComm, "@DNS_NO", DbType.String, Objinfo.DNS_NO)
                db.AddInParameter(dbComm, "@P_Type", DbType.String, Objinfo.P_Type)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, Objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@DN_Qty", DbType.Double, Objinfo.DN_Qty)
                db.AddInParameter(dbComm, "@DN_SP", DbType.Double, Objinfo.DN_SP)
                db.AddInParameter(dbComm, "@DN_Help", DbType.String, Objinfo.DN_Help)
                db.AddInParameter(dbComm, "@R_NO", DbType.String, Objinfo.R_NO)

                db.ExecuteNonQuery(dbComm)
                DeliveryPacking_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryPacking_Add = False
            End Try
        End Function
        '送貨單裝箱表修改
        Public Function DeliveryPacking_Update(ByVal Objinfo As DeliveryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryPacking_Update")

                db.AddInParameter(dbComm, "@IndexNO", DbType.Int32, Objinfo.IndexNO)
                db.AddInParameter(dbComm, "@DN_ID", DbType.String, Objinfo.DN_ID)
                db.AddInParameter(dbComm, "@P_NO", DbType.String, Objinfo.P_NO)
                db.AddInParameter(dbComm, "@DNS_NO", DbType.String, Objinfo.DNS_NO)
                db.AddInParameter(dbComm, "@P_Type", DbType.String, Objinfo.P_Type)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, Objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@DN_Qty", DbType.Double, Objinfo.DN_Qty)
                db.AddInParameter(dbComm, "@DN_SP", DbType.Double, Objinfo.DN_SP)
                db.AddInParameter(dbComm, "@DN_Help", DbType.String, Objinfo.DN_Help)
                db.AddInParameter(dbComm, "@R_NO", DbType.String, Objinfo.R_NO)

                db.ExecuteNonQuery(dbComm)
                DeliveryPacking_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryPacking_Update = False
            End Try
        End Function
        '送貨單裝箱表刪除
        Public Function DeliveryPacking_Delete(ByVal DN_ID As String, ByVal DNS_NO As String, ByVal P_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryPacking_Delete")

                db.AddInParameter(dbComm, "@DN_ID", DbType.String, DN_ID)
                db.AddInParameter(dbComm, "@P_NO", DbType.String, P_NO)
                db.AddInParameter(dbComm, "@DNS_NO", DbType.String, DNS_NO)


                db.ExecuteNonQuery(dbComm)
                DeliveryPacking_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryPacking_Delete = False

            End Try
        End Function
        '送貨單裝箱表查詢
        Public Function DeliveryPacking_GetList(ByVal DN_ID As String, ByVal DNS_NO As String, ByVal P_NO As String, ByVal OS_BatchID As String, ByVal M_Code As String) As List(Of DeliveryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryPacking_GetList")

            db.AddInParameter(dbComm, "@DN_ID", DbType.String, DN_ID)
            db.AddInParameter(dbComm, "@P_NO", DbType.String, P_NO)
            db.AddInParameter(dbComm, "@DNS_NO", DbType.String, DNS_NO)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of DeliveryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillDelivery(reader))
                End While
                Return FeatureList
            End Using

        End Function
        '送貨單配件表新增
        Public Function DeliveryPackingSub_Add(ByVal objinfo As DeliveryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryPackingSub_Add")

                db.AddInParameter(dbComm, "@DNS_NO", DbType.String, objinfo.DNS_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@DS_Qty", DbType.Double, objinfo.DS_Qty)
                db.AddInParameter(dbComm, "@DS_SP", DbType.Double, objinfo.DS_SP)

                db.ExecuteNonQuery(dbComm)
                DeliveryPackingSub_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryPackingSub_Add = False
            End Try
        End Function
        '送貨單配件表修改
        Public Function DeliveryPackingSub_Update(ByVal Objinfo As DeliveryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryPackingSub_Update")

                db.AddInParameter(dbComm, "@DNS_NO", DbType.String, Objinfo.DNS_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@DS_Qty", DbType.Double, Objinfo.DS_Qty)
                db.AddInParameter(dbComm, "@DS_SP", DbType.Double, Objinfo.DS_SP)

                db.ExecuteNonQuery(dbComm)
                DeliveryPackingSub_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryPackingSub_Update = False
            End Try
        End Function
        '送貨單配件表刪除
        Public Function DeliveryPackingSub_Delete(ByVal DNS_NO As String, ByVal M_Code As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryPackingSub_Delete")

                db.AddInParameter(dbComm, "@DNS_NO", DbType.String, DNS_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

                db.ExecuteNonQuery(dbComm)
                DeliveryPackingSub_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                DeliveryPackingSub_Delete = False
            End Try
        End Function
        '送貨單配件表查詢
        Public Function DeliveryPackingSub_GetList(ByVal DNS_NO As String, ByVal M_Code As String) As List(Of DeliveryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("DeliveryPackingSub_GetList")

            db.AddInParameter(dbComm, "@DNS_NO", DbType.String, DNS_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)


            Dim FeatureList As New List(Of DeliveryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillDelivery(reader))
                End While
                Return FeatureList
            End Using

        End Function
        '取得當前模塊所有字段的值
        Public Function FillDelivery(ByVal reader As IDataReader) As DeliveryInfo

            On Error Resume Next

            Dim di As New DeliveryInfo

            di.DN_ID = reader("DN_ID").ToString

            If reader("DN_Date") Is DBNull.Value Then
                di.DN_Date = Nothing
            Else
                di.DN_Date = CStr(reader("DN_Date"))
            End If

            di.DN_Remark = reader("DN_Remark").ToString
            di.DN_Action = reader("DN_Action").ToString
            di.WH_ID = reader("WH_ID").ToString
            di.DN_CusterNO = reader("DN_CusterNO").ToString
            di.DN_Type = reader("DN_Type").ToString
            di.DN_Charge = reader("DN_Charge").ToString

            If reader("DN_Invoice") Is DBNull.Value Then
                di.DN_Invoice = Nothing
            Else
                di.DN_Invoice = reader("DN_Invoice")
            End If
            If reader("DN_Return") Is DBNull.Value Then
                di.DN_Return = Nothing
            Else
                di.DN_Return = reader("DN_Return")
            End If
            '-----------------------------------------------------------------------送貨基本信息
            If reader("DN_Check") Is DBNull.Value Then
                di.DN_Check = Nothing
            Else
                di.DN_Check = reader("DN_Check")
            End If

            di.DN_CheckAction = reader("DN_CheckAction").ToString

            If reader("DN_CheckDate") Is DBNull.Value Then
                di.DN_CheckDate = Nothing
            Else
                di.DN_CheckDate = CStr(reader("DN_CheckDate"))
            End If
            di.DN_CheckRemark = reader("DN_CheckRemark").ToString
            '-----------------------------------------------------------------------送貨審核信息
            If reader("DN_AccCheck") Is DBNull.Value Then
                di.DN_AccCheck = Nothing
            Else
                di.DN_AccCheck = reader("DN_AccCheck")
            End If

            di.DN_AccCheckAction = reader("DN_AccCheckAction").ToString

            If reader("DN_AccCheckDate") Is DBNull.Value Then
                di.DN_AccCheckDate = Nothing
            Else
                di.DN_AccCheckDate = CStr(reader("DN_AccCheckDate"))
            End If

            di.DN_AccCheckRemark = reader("DN_AccCheckRemark").ToString
            di.DN_AccCheckType = reader("DN_AccCheckType").ToString
            '-----------------------------------------------------------------------送貨復核信息
            di.P_NO = reader("P_NO").ToString
            di.DNS_NO = reader("DNS_NO").ToString
            di.P_Type = reader("P_Type").ToString
            di.OS_BatchID = reader("OS_BatchID").ToString
            di.M_Code = reader("M_Code").ToString

            If reader("DN_Qty") Is DBNull.Value Then
                di.DN_Qty = Nothing
            Else
                di.DN_Qty = CDbl(reader("DN_Qty").ToString)
            End If
            If reader("DN_SP") Is DBNull.Value Then
                di.DN_SP = Nothing
            Else
                di.DN_SP = CDbl(reader("DN_SP").ToString)
            End If

            di.DN_Help = reader("DN_Help").ToString
            di.R_NO = reader("R_NO").ToString
            '-----------------------------------------------------------------------送貨裝箱信息
            If reader("DS_Qty") Is DBNull.Value Then
                di.DS_Qty = Nothing
            Else
                di.DS_Qty = CDbl(reader("DS_Qty").ToString)
            End If
            If reader("DS_SP") Is DBNull.Value Then
                di.DS_SP = Nothing
            Else
                di.DS_SP = CDbl(reader("DS_SP").ToString)
            End If
            '-----------------------------------------------------------------------送貨配件信息
            di.M_Gauge = reader("M_Gauge").ToString
            di.M_Name = reader("M_Name").ToString
            di.ActionName = reader("ActionName").ToString
            di.CheckActionName = reader("CheckActionName").ToString
            di.AccCheckActionName = reader("AccCheckActionName").ToString

            di.AutoID = CInt(reader("AutoID").ToString)
            di.IndexNO = CInt(reader("IndexNO").ToString)
            di.IndexNum = CInt(reader("IndexNum").ToString)
            '-----------------------------------------------------------------------輔助調用字段
            di.WH_Name = reader("WH_Name").ToString

            Return di
        End Function

    End Class

End Namespace




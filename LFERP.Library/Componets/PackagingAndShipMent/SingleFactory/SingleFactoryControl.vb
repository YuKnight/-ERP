Imports LFERP.Library.SingleFactory


Namespace LFERP.Library.SingleFactory

    Public Class SingleFactoryControl

        Public Function SingleFactory_Add(ByVal objinfo As SingleFactoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SingleFactory_Add")

                db.AddInParameter(dbComm, "@SF_ID", DbType.String, objinfo.SF_ID)
                db.AddInParameter(dbComm, "@SF_Address", DbType.String, objinfo.SF_Address)
                db.AddInParameter(dbComm, "@SF_Date", DbType.Date, objinfo.SF_Date)
                db.AddInParameter(dbComm, "@SF_Remark", DbType.String, objinfo.SF_Remark)
                db.AddInParameter(dbComm, "@SF_Action", DbType.String, objinfo.SF_Action)
                db.AddInParameter(dbComm, "@ID", DbType.String, objinfo.ID)
                db.AddInParameter(dbComm, "@P_NO", DbType.String, objinfo.P_NO)
                db.AddInParameter(dbComm, "@P_Detail", DbType.String, objinfo.P_Detail)
                db.AddInParameter(dbComm, "@P_Remark", DbType.String, objinfo.P_Remark)

                db.ExecuteNonQuery(dbComm)
                SingleFactory_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                SingleFactory_Add = False
            End Try
        End Function
        Public Function SingleFactory_Update(ByVal objinfo As SingleFactoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SingleFactory_Update")

                db.AddInParameter(dbComm, "@SF_ID", DbType.String, objinfo.SF_ID)
                db.AddInParameter(dbComm, "@SF_Address", DbType.String, objinfo.SF_Address)
                db.AddInParameter(dbComm, "@SF_Date", DbType.Date, objinfo.SF_Date)
                db.AddInParameter(dbComm, "@SF_Remark", DbType.String, objinfo.SF_Remark)
                db.AddInParameter(dbComm, "@SF_Action", DbType.String, objinfo.SF_Action)
                db.AddInParameter(dbComm, "@P_NO", DbType.String, objinfo.P_NO)
                db.AddInParameter(dbComm, "@P_Detail", DbType.String, objinfo.P_Detail)
                db.AddInParameter(dbComm, "@P_Remark", DbType.String, objinfo.P_Remark)

                db.ExecuteNonQuery(dbComm)
                SingleFactory_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                SingleFactory_Update = False
            End Try
        End Function
        Public Function SingleFactory_UpdateCheck(ByVal objinfo As SingleFactoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SingleFactory_UpdateCheck")

                db.AddInParameter(dbComm, "@SF_ID", DbType.String, objinfo.SF_ID)
                db.AddInParameter(dbComm, "@SF_Check", DbType.Boolean, objinfo.SF_Check)
                db.AddInParameter(dbComm, "@SF_CheckAction", DbType.String, objinfo.SF_CheckAction)
                db.AddInParameter(dbComm, "@SF_CheckDate", DbType.Date, objinfo.SF_CheckDate)
                db.AddInParameter(dbComm, "@SF_CheckRemark", DbType.String, objinfo.SF_CheckRemark)
                db.AddInParameter(dbComm, "@SF_CheckType", DbType.String, objinfo.SF_CheckType)

                db.ExecuteNonQuery(dbComm)
                SingleFactory_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                SingleFactory_UpdateCheck = False
            End Try
        End Function
        Public Function SingleFactory_Delete(ByVal SF_ID As String, ByVal ID As String, ByVal P_NO As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SingleFactory_Delete")

                db.AddInParameter(dbComm, "@SF_ID", DbType.String, SF_ID)
                db.AddInParameter(dbComm, "@ID", DbType.String, ID)
                db.AddInParameter(dbComm, "@P_NO", DbType.String, P_NO)

                db.ExecuteNonQuery(dbComm)
                SingleFactory_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SingleFactory_Delete = False
            End Try

        End Function

        Public Function SingleFactory_GetNO(ByVal NDate As String) As SingleFactoryInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SingleFactory_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillSingleFactory(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function SingleFactory_GetList(ByVal SF_ID As String, ByVal SF_Date As String, ByVal SF_DateVal As String, ByVal SF_Action As String, ByVal SF_Check As String, ByVal P_NO As String) As List(Of SingleFactoryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SingleFactory_GetList")

            db.AddInParameter(dbComm, "@SF_ID", DbType.String, SF_ID)

            db.AddInParameter(dbComm, "@SF_Date", DbType.String, SF_Date)
            db.AddInParameter(dbComm, "@SF_DateVal", DbType.String, SF_DateVal)
            db.AddInParameter(dbComm, "@SF_Action", DbType.String, SF_Action)
            db.AddInParameter(dbComm, "@SF_Check", DbType.String, SF_Check)
            db.AddInParameter(dbComm, "@P_NO", DbType.String, P_NO)

            Dim FeatureList As New List(Of SingleFactoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSingleFactory(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function Packing_Add(ByVal objinfo As SingleFactoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Packing_Add")

                db.AddInParameter(dbComm, "@P_NO", DbType.String, objinfo.P_NO)
                db.AddInParameter(dbComm, "@PB_NO", DbType.String, objinfo.PB_NO)
                db.AddInParameter(dbComm, "@IDSub", DbType.String, objinfo.IDSub)
                db.AddInParameter(dbComm, "@P_Type", DbType.String, objinfo.P_Type)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@P_Qty", DbType.Double, objinfo.P_Qty)
                db.AddInParameter(dbComm, "@P_SP", DbType.Double, objinfo.P_SP)
                db.AddInParameter(dbComm, "@P_Help", DbType.String, objinfo.P_Help)

                db.ExecuteNonQuery(dbComm)
                Packing_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Packing_Add = False
            End Try
        End Function
        Public Function Packing_Update(ByVal objinfo As SingleFactoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Packing_Update")

                db.AddInParameter(dbComm, "@P_NO", DbType.String, objinfo.P_NO)
                db.AddInParameter(dbComm, "@PB_NO", DbType.String, objinfo.PB_NO)
                db.AddInParameter(dbComm, "@P_Type", DbType.String, objinfo.P_Type)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objinfo.OS_BatchID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@P_Qty", DbType.Double, objinfo.P_Qty)
                db.AddInParameter(dbComm, "@P_SP", DbType.Double, objinfo.P_SP)
                db.AddInParameter(dbComm, "@P_Help", DbType.String, objinfo.P_Help)

                db.ExecuteNonQuery(dbComm)
                Packing_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Packing_Update = False
            End Try
        End Function
        Public Function Packing_Delete(ByVal P_NO As String, ByVal PB_NO As String, ByVal IDSub As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Packing_Delete")

                db.AddInParameter(dbComm, "@P_NO", DbType.String, P_NO)
                db.AddInParameter(dbComm, "@PB_NO", DbType.String, PB_NO)
                db.AddInParameter(dbComm, "@IDSub", DbType.String, IDSub)

                db.ExecuteNonQuery(dbComm)
                Packing_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Packing_Delete = False

            End Try
        End Function
        '當前出廠單下的裝箱編號最大值
        Public Function Packing_GetPNO(ByVal SF_ID As String) As SingleFactoryInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Packing_GetPNO")

            db.AddInParameter(dbComm, "@SF_ID", DbType.String, SF_ID)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillSingleFactory(reader)
                End While
                Return Nothing
            End Using

        End Function
        '當前裝箱編號下的裝箱項目編號最大值
        Public Function Packing_GetNo(ByVal P_NO As String) As SingleFactoryInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Packing_GetNo")

            db.AddInParameter(dbComm, "@P_NO", DbType.String, P_NO)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillSingleFactory(reader)
                End While
                Return Nothing
            End Using

        End Function

        Public Function Packing_GetList(ByVal P_NO As String, ByVal OS_BatchID As String, ByVal M_Code As String) As List(Of SingleFactoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Packing_GetList")

            db.AddInParameter(dbComm, "@P_NO", DbType.String, P_NO)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of SingleFactoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSingleFactory(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function PackingSub_Add(ByVal objinfo As SingleFactoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PackingSub_Add")

                db.AddInParameter(dbComm, "@PB_NO", DbType.String, objinfo.PB_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PB_Qty", DbType.Double, objinfo.PB_Qty)
                db.AddInParameter(dbComm, "@PB_SP", DbType.Double, objinfo.PB_SP)

                db.ExecuteNonQuery(dbComm)
                PackingSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PackingSub_Add = False
            End Try
        End Function
        Public Function PackingSub_Update(ByVal objinfo As SingleFactoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PackingSub_Update")

                db.AddInParameter(dbComm, "@PB_NO", DbType.String, objinfo.PB_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PB_Qty", DbType.Double, objinfo.PB_Qty)
                db.AddInParameter(dbComm, "@PB_SP", DbType.Double, objinfo.PB_SP)

                db.ExecuteNonQuery(dbComm)
                PackingSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PackingSub_Update = False
            End Try
        End Function
        Public Function PackingSub_Delete(ByVal PB_NO As String, ByVal M_Code As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PackingSub_Delete")

                db.AddInParameter(dbComm, "@PB_NO", DbType.String, PB_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

                db.ExecuteNonQuery(dbComm)
                PackingSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PackingSub_Delete = False
            End Try
        End Function
        Public Function PackingSub_GetList(ByVal PB_NO As String, ByVal M_Code As String) As List(Of SingleFactoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PackingSub_GetList")

            db.AddInParameter(dbComm, "@PB_NO", DbType.String, PB_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of SingleFactoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSingleFactory(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function FillSingleFactory(ByVal reader As IDataReader) As SingleFactoryInfo

            On Error Resume Next
            Dim sfi As New SingleFactoryInfo

            sfi.SF_ID = reader("SF_ID").ToString
            sfi.SF_Address = reader("SF_Address").ToString
            If reader("SF_Date") Is DBNull.Value Then
                sfi.SF_Date = Nothing
            Else
                sfi.SF_Date = CStr(reader("SF_Date"))
            End If
            sfi.SF_Remark = reader("SF_Remark").ToString
            If reader("SF_Check") Is DBNull.Value Then
                sfi.SF_Check = Nothing
            Else
                sfi.SF_Check = reader("SF_Check")
            End If
            sfi.SF_CheckAction = reader("SF_CheckAction").ToString


            If reader("SF_CheckDate") Is DBNull.Value Then
                sfi.SF_CheckDate = Nothing
            Else
                sfi.SF_CheckDate = CStr(reader("SF_CheckDate"))
            End If

            sfi.SF_CheckRemark = reader("SF_CheckRemark").ToString
            sfi.SF_CheckType = reader("SF_CheckType").ToString
            sfi.SF_Action = reader("SF_Action").ToString
            '-----------------------------------------------------------------------
            sfi.P_NO = reader("P_NO").ToString
            sfi.P_Detail = reader("P_Detail").ToString
            sfi.P_Remark = reader("P_Remark").ToString
            '--------------------------------------------
            sfi.PB_NO = reader("PB_NO").ToString
            sfi.P_Type = reader("P_Type").ToString
            sfi.OS_BatchID = reader("OS_BatchID").ToString
            sfi.M_Code = reader("M_Code").ToString

            If reader("P_Qty") Is DBNull.Value Then
                sfi.P_Qty = Nothing
            Else
                sfi.P_Qty = CDbl(reader("P_Qty").ToString)
            End If
            If reader("P_SP") Is DBNull.Value Then
                sfi.P_SP = Nothing
            Else
                sfi.P_SP = CDbl(reader("P_SP").ToString)
            End If

            sfi.P_Help = reader("P_Help").ToString
            '--------------------------------------------
            If reader("PB_Qty") Is DBNull.Value Then
                sfi.PB_Qty = Nothing
            Else
                sfi.PB_Qty = CDbl(reader("PB_Qty").ToString)
            End If
            If reader("PB_SP") Is DBNull.Value Then
                sfi.PB_SP = Nothing
            Else
                sfi.PB_SP = CDbl(reader("PB_SP").ToString)
            End If
            '------------------------------------------------------------------

            sfi.SF_ActionName = reader("SF_ActionName").ToString
            sfi.SF_CheckActionName = reader("SF_CheckActionName").ToString
            sfi.M_Gauge = reader("M_Gauge").ToString
            sfi.M_Name = reader("M_Name").ToString

            sfi.AutoID = CInt(reader("AutoID").ToString)
            sfi.IndexNO = CInt(reader("IndexNO").ToString)
            sfi.IndexNum = CInt(reader("IndexNum").ToString)
            sfi.ID = reader("ID").ToString
            sfi.IDSub = reader("IDSub").ToString

            Return sfi

        End Function


    End Class

End Namespace




Namespace LFERP.Library.ProductionField
    Public Class ProductionFieldControl
        Public Function ProductionField_GetNO(ByVal NDate As String) As ProductionFieldInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionField(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductionField_GetNum(ByVal NDate As String) As ProductionFieldInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_GetNum")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionField(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function ProductionField_GetOutNO(ByVal NDate As String) As ProductionFieldInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_GetOutNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionField(reader)
                End While
                Return Nothing
            End Using
        End Function

        '物料收發 ---工藝流程第一步 --開料
        Public Function ProductionField_InAdd(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_InAdd")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@FP_Num", DbType.String, objinfo.FP_Num)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)

                db.AddInParameter(dbComm, "@FP_Qty", DbType.Int32, objinfo.FP_Qty)
                db.AddInParameter(dbComm, "@FP_Weight", DbType.Single, objinfo.FP_Weight)

                db.AddInParameter(dbComm, "@FP_Date", DbType.Date, objinfo.FP_Date)
                db.AddInParameter(dbComm, "@FP_Detail", DbType.String, objinfo.FP_Detail)
                'db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@FP_OutAction", DbType.String, objinfo.FP_OutAction)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
                db.AddInParameter(dbComm, "@FP_Remark", DbType.String, objinfo.FP_Remark)
                db.AddInParameter(dbComm, "@IW_NO", DbType.String, objinfo.IW_NO)  '聯豐單號

                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)  '刷卡人

                db.ExecuteNonQuery(dbComm)
                ProductionField_InAdd = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionField_InAdd = False
            End Try
        End Function
        '物料收發-----發送損耗等
        Public Function ProductionField_OutAdd(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_OutAdd")


                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@FP_Num", DbType.String, objinfo.FP_Num)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@FP_Qty", DbType.Int32, objinfo.FP_Qty)
                db.AddInParameter(dbComm, "@FP_Weight", DbType.Single, objinfo.FP_Weight)
                db.AddInParameter(dbComm, "@FP_Date", DbType.Date, objinfo.FP_Date)
                db.AddInParameter(dbComm, "@FP_Detail", DbType.String, objinfo.FP_Detail)

                db.AddInParameter(dbComm, "@FP_OutAction", DbType.String, objinfo.FP_OutAction)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
                db.AddInParameter(dbComm, "@FP_Remark", DbType.String, objinfo.FP_Remark)
                db.AddInParameter(dbComm, "@OW_NO", DbType.String, objinfo.OW_NO)

                db.AddInParameter(dbComm, "@FP_SubtractReQty", DbType.Boolean, objinfo.FP_SubtractReQty)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)  '刷卡人

                db.ExecuteNonQuery(dbComm)
                ProductionField_OutAdd = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionField_OutAdd = False

            End Try

        End Function

        '2014-02-24  姚駿
        Public Function ProductionFieldControl_GetListOne(ByVal Pro_NO As String, ByVal PM_M_Code As String, ByVal FP_OutDep As String, ByVal FP_Date1 As String, ByVal FP_Date2 As String) As List(Of ProductionFieldInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldControl_GetListOne")

            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FP_Date1", DbType.String, FP_Date1)
            db.AddInParameter(dbComm, "@FP_Date2", DbType.String, FP_Date2)


            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using



        End Function

        '2014-03-11  姚駿
        Public Function ProductionFieldDayDPTData_GetList(ByVal PM_M_Code As String, ByVal FP_OutDep As String, ByVal FP_Date As String, ByVal FP_Date1 As String) As List(Of ProductionFieldInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDayDPTData_GetList")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FP_Date", DbType.String, FP_Date)
            db.AddInParameter(dbComm, "@FP_Date1", DbType.String, FP_Date1)


            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDayDPTData(reader))
                End While
                Return FeatureList
            End Using



        End Function

        '2014-03-11  姚駿
        Public Function FillProductionFieldDayDPTData(ByVal reader As IDataReader) As ProductionFieldInfo
            On Error Resume Next
            Dim pfi As New ProductionFieldInfo

            pfi.DepOutName = reader("DepOutName")
            pfi.NowQty = reader("NowQty")
            pfi.M_Name = reader("M_Name")
            pfi.PM_M_Code = reader("PM_M_Code")
            pfi.M_Gauge = reader("M_Gauge")
            pfi.PM_Date = reader("PM_Date")
            pfi.FP_OutDep = reader("FP_OutDep").ToString


            If reader("ShouRu") Is DBNull.Value Then
                pfi.ShouRu = Nothing
            Else
                pfi.ShouRu = reader("ShouRu")
            End If

            If reader("FaChu") Is DBNull.Value Then
                pfi.FaChu = Nothing
            Else
                pfi.FaChu = reader("FaChu")
            End If

            If reader("ShunHuai") Is DBNull.Value Then
                pfi.ShunHuai = Nothing
            Else
                pfi.ShunHuai = reader("ShunHuai")
            End If

            If reader("YesterdayQty") Is DBNull.Value Then
                pfi.YesterdayQty = Nothing
            Else
                pfi.YesterdayQty = reader("YesterdayQty")
            End If

            If reader("DayQty") Is DBNull.Value Then
                pfi.DayQty = Nothing
            Else
                pfi.DayQty = reader("DayQty")
            End If

            pfi.FP_Remark = reader("FP_Remark").ToString

            pfi.FacInName = reader("FacInName").ToString
            pfi.FacOutName = reader("FacOutName").ToString
            pfi.DepInName = reader("FacInName").ToString & "-" & reader("DepInName").ToString
            pfi.DepOutName = reader("FacOutName").ToString & "-" & reader("DepOutName").ToString

            Return pfi
        End Function


        '正常物料收發
        Public Function ProductionField_Add(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_Add")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@FP_Num", DbType.String, objinfo.FP_Num)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.AddInParameter(dbComm, "@Pro_Type1", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code1", DbType.String, objinfo.PM_M_Code1)
                db.AddInParameter(dbComm, "@PM_Type1", DbType.String, objinfo.PM_Type1)

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@Pro_NO1", DbType.String, objinfo.Pro_NO1)


                db.AddInParameter(dbComm, "@FP_Qty", DbType.Int32, objinfo.FP_Qty)
                db.AddInParameter(dbComm, "@FP_Weight", DbType.Single, objinfo.FP_Weight)

                db.AddInParameter(dbComm, "@FP_Date", DbType.Date, objinfo.FP_Date)

                db.AddInParameter(dbComm, "@FP_Detail", DbType.String, objinfo.FP_Detail)
                db.AddInParameter(dbComm, "@FP_OutAction", DbType.String, objinfo.FP_OutAction)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
                db.AddInParameter(dbComm, "@FP_Remark", DbType.String, objinfo.FP_Remark)


                db.AddInParameter(dbComm, "@FP_SendType", DbType.String, objinfo.FP_SendType)
                db.AddInParameter(dbComm, "@FP_Qty1", DbType.Single, objinfo.FP_Qty1)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)  '刷卡人
                db.AddInParameter(dbComm, "@FP_OutType", DbType.String, objinfo.FP_OutType)

                db.AddInParameter(dbComm, "@FP_SubtractReQty", DbType.Boolean, objinfo.FP_SubtractReQty)
                db.AddInParameter(dbComm, "@FP_OutOK", DbType.Boolean, objinfo.FP_OutOK)


                db.ExecuteNonQuery(dbComm)
                ProductionField_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionField_Add = False
            End Try
        End Function

        Public Function ProductionField_Update(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_Update")

                db.AddInParameter(dbComm, "@FP_Num", DbType.String, objinfo.FP_Num)
                'db.AddInParameter(dbComm, "@PS_Num1", DbType.Int32, objinfo.PS_Num1)

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_Type1", DbType.String, objinfo.Pro_Type1)
                db.AddInParameter(dbComm, "@PM_M_Code1", DbType.String, objinfo.PM_M_Code1)
                db.AddInParameter(dbComm, "@PM_Type1", DbType.String, objinfo.PM_Type1)

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@Pro_NO1", DbType.String, objinfo.Pro_NO1)
                db.AddInParameter(dbComm, "@FP_Qty", DbType.Int32, objinfo.FP_Qty)

                db.AddInParameter(dbComm, "@FP_Weight", DbType.Single, objinfo.FP_Weight)

                db.AddInParameter(dbComm, "@FP_Date", DbType.Date, objinfo.FP_Date)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@FP_OutAction", DbType.String, objinfo.FP_OutAction)
                db.AddInParameter(dbComm, "@FP_Remark", DbType.String, objinfo.FP_Remark)

                db.AddInParameter(dbComm, "@FP_SendType", DbType.String, objinfo.FP_SendType)
                db.AddInParameter(dbComm, "@FP_Qty1", DbType.Single, objinfo.FP_Qty1)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)  '刷卡人
                db.AddInParameter(dbComm, "@FP_OutType", DbType.String, objinfo.FP_OutType)

                db.AddInParameter(dbComm, "@FP_SubtractReQty", DbType.Boolean, objinfo.FP_SubtractReQty)
                db.AddInParameter(dbComm, "@FP_OutOK", DbType.Boolean, objinfo.FP_OutOK)

                db.ExecuteNonQuery(dbComm)
                ProductionField_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionField_Update = False

            End Try
        End Function

        Public Function ProductionField_InUpdate(ByVal objinfo As ProductionFieldInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_InUpdate")

                db.AddInParameter(dbComm, "@FP_Num", DbType.String, objinfo.FP_Num)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@FP_Qty", DbType.Int32, objinfo.FP_Qty)
                db.AddInParameter(dbComm, "@FP_Weight", DbType.Single, objinfo.FP_Weight)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@FP_Date", DbType.Date, objinfo.FP_Date)
                db.AddInParameter(dbComm, "@FP_Detail", DbType.String, objinfo.FP_Detail)
                db.AddInParameter(dbComm, "@FP_OutAction", DbType.String, objinfo.FP_OutAction)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
                db.AddInParameter(dbComm, "@FP_Remark", DbType.String, objinfo.FP_Remark)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)  '刷卡人

                db.ExecuteNonQuery(dbComm)
                ProductionField_InUpdate = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionField_InUpdate = False
            End Try

        End Function

        Public Function ProductionField_OutUpdate(ByVal objinfo As ProductionFieldInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_OutUpdate")

                db.AddInParameter(dbComm, "@FP_Num", DbType.String, objinfo.FP_Num)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@FP_Qty", DbType.Int32, objinfo.FP_Qty)
                db.AddInParameter(dbComm, "@FP_Weight", DbType.Single, objinfo.FP_Weight)
                db.AddInParameter(dbComm, "@FP_Date", DbType.Date, objinfo.FP_Date)
                db.AddInParameter(dbComm, "@FP_Detail", DbType.String, objinfo.FP_Detail)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@FP_OutAction", DbType.String, objinfo.FP_OutAction)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
                db.AddInParameter(dbComm, "@FP_Remark", DbType.String, objinfo.FP_Remark)
                db.AddInParameter(dbComm, "@FP_SubtractReQty", DbType.Boolean, objinfo.FP_SubtractReQty)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)  '刷卡人

                db.ExecuteNonQuery(dbComm)
                ProductionField_OutUpdate = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionField_OutUpdate = False
            End Try

        End Function

        Public Function ProductionField_UpdateInCheck(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_UpdateInCheck")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@FP_Type", DbType.String, objinfo.FP_Type)
                db.AddInParameter(dbComm, "@FP_InAction", DbType.String, objinfo.FP_InAction)
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.Boolean, objinfo.FP_InCheck)
                db.AddInParameter(dbComm, "@FP_InCheckDate", DbType.Date, objinfo.FP_InCheckDate)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)

                db.ExecuteNonQuery(dbComm)
                ProductionField_UpdateInCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionField_UpdateInCheck = False
            End Try

        End Function


        Public Function ProductionField_UpdateInCheck1(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_UpdateInCheck1")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@FP_Type", DbType.String, objinfo.FP_Type)
                db.AddInParameter(dbComm, "@FP_InAction", DbType.String, objinfo.FP_InAction)
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.Boolean, objinfo.FP_InCheck)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)

                db.AddInParameter(dbComm, "@FP_Check", DbType.Boolean, objinfo.FP_Check)
                db.AddInParameter(dbComm, "@FP_CheckAction", DbType.String, objinfo.FP_CheckAction)

                db.ExecuteNonQuery(dbComm)
                ProductionField_UpdateInCheck1 = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionField_UpdateInCheck1 = False
            End Try

        End Function

        Public Function ProductionField_UpdateCheck(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_UpdateCheck")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@FP_CheckAction", DbType.String, objinfo.FP_CheckAction)
                db.AddInParameter(dbComm, "@FP_Check", DbType.Boolean, objinfo.FP_Check)
                db.AddInParameter(dbComm, "@FP_CheckRemark", DbType.String, objinfo.FP_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionField_UpdateCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionField_UpdateCheck = False
            End Try

        End Function
        ''收料過程中結餘數變更
        'Public Function ProductionField_UpdateInEndQty(ByVal objinfo As ProductionFieldInfo) As Boolean
        '    Try
        '        Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        '        Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_UpdateInEndQty")

        '        db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
        '        db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
        '        db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
        '        db.AddInParameter(dbComm, "@FP_Type", DbType.String, objinfo.FP_Type)
        '        db.AddInParameter(dbComm, "@FP_EndQty", DbType.Single, objinfo.FP_EndQty)
        '        db.AddInParameter(dbComm, "@FP_EndReQty", DbType.Single, objinfo.FP_EndReQty)

        '        db.ExecuteNonQuery(dbComm)
        '        ProductionField_UpdateInEndQty = True

        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '        ProductionField_UpdateInEndQty = False
        '    End Try
        'End Function

        '結餘數變更
        Public Function ProductionField_UpdateEndQty(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_UpdateEndQty")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@FP_Type", DbType.String, objinfo.FP_Type)
                db.AddInParameter(dbComm, "@FP_EndQty", DbType.Decimal, objinfo.FP_EndQty)
                db.AddInParameter(dbComm, "@FP_EndReQty", DbType.Decimal, objinfo.FP_EndReQty)

                db.ExecuteNonQuery(dbComm)
                ProductionField_UpdateEndQty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionField_UpdateEndQty = False
            End Try
        End Function

        Public Function ProductionField_Delete(ByVal FP_NO As String, ByVal FP_Num As String) As Boolean

            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_Delete")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)
                db.AddInParameter(dbComm, "@FP_Num", DbType.String, FP_Num)

                db.ExecuteNonQuery(dbComm)
                ProductionField_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionField_Delete = False
            End Try

        End Function

        Public Function ProductionField_GetList(ByVal FP_NO As String, ByVal Pro_NO As String, ByVal FP_Type As String, ByVal FP_InDep As String, ByVal FP_OutDep As String, ByVal FP_Detail As String, ByVal FP_InCheck As String, ByVal FP_Check As String, ByVal FP_Date As String, ByVal FP_DateVal As String, ByVal Mode As String, ByVal FP_OutType As String, ByVal FP_OutOK As String) As List(Of ProductionFieldInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_GetList")

            db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@FP_Type", DbType.String, FP_Type)
            db.AddInParameter(dbComm, "@FP_InDep", DbType.String, FP_InDep)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FP_Detail", DbType.String, FP_Detail)

            If FP_InCheck = Nothing Then
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, FP_InCheck)
            End If

            If FP_Check = Nothing Then
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, FP_Check)
            End If

            db.AddInParameter(dbComm, "@FP_Date", DbType.String, FP_Date)
            db.AddInParameter(dbComm, "@FP_DateVal", DbType.String, FP_DateVal)

            db.AddInParameter(dbComm, "@Mode", DbType.String, Mode)
            db.AddInParameter(dbComm, "@FP_OutType", DbType.String, FP_OutType)
            db.AddInParameter(dbComm, "@FP_OutOK", DbType.String, FP_OutOK)

            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function ProductionDetail_GetList(ByVal Pro_Type As String, ByVal FP_OutDep As String, ByVal FP_Date1 As String, ByVal FP_Date2 As String) As List(Of ProductionFieldInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionDetail_GetList")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FP_Date1", DbType.String, FP_Date1)
            db.AddInParameter(dbComm, "@FP_Date2", DbType.String, FP_Date2)

            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function ProductionField_GetList1(ByVal FP_NO As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal FP_Type As String, ByVal FP_InDep As String, ByVal FP_OutDep As String, ByVal FP_Detail As String, ByVal FP_InCheck As String, ByVal FP_Check As String, ByVal FP_Date1 As String, ByVal FP_Date2 As String, ByVal CardID As String, ByVal FP_OutType As String) As List(Of ProductionFieldInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_GetList1")

            db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@FP_Type", DbType.String, FP_Type)
            db.AddInParameter(dbComm, "@FP_InDep", DbType.String, FP_InDep)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FP_Detail", DbType.String, FP_Detail)

            If FP_InCheck = Nothing Then
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, FP_InCheck)
            End If

            If FP_Check = Nothing Then
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, FP_Check)
            End If

            db.AddInParameter(dbComm, "@FP_Date1", DbType.String, FP_Date1)
            db.AddInParameter(dbComm, "@FP_Date2", DbType.String, FP_Date2) '

            db.AddInParameter(dbComm, "@CardID", DbType.String, CardID) ''刷卡號   2012-5-25
            db.AddInParameter(dbComm, "@FP_OutType", DbType.String, FP_OutType) ''外發類型   2012-6-11

            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function ProductionField_Getlist5(ByVal Pro_NO As String) As List(Of ProductionFieldInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_Getlist5")

            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionField_GetList2(ByVal FP_NO As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal FP_Type As String, ByVal FP_InDep As String, ByVal FP_OutDep As String, ByVal FP_Detail As String, ByVal FP_InCheck As String, ByVal FP_Check As String, ByVal FP_Date1 As String, ByVal FP_Date2 As String, ByVal CardID As String, ByVal FP_OutType As String, ByVal FP_OutOK As String) As List(Of ProductionFieldInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_GetList1")

            db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@FP_Type", DbType.String, FP_Type)
            db.AddInParameter(dbComm, "@FP_InDep", DbType.String, FP_InDep)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FP_Detail", DbType.String, FP_Detail)

            If FP_InCheck = Nothing Then
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, FP_InCheck)
            End If

            If FP_Check = Nothing Then
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, FP_Check)
            End If

            db.AddInParameter(dbComm, "@FP_Date1", DbType.String, FP_Date1)
            db.AddInParameter(dbComm, "@FP_Date2", DbType.String, FP_Date2) '

            db.AddInParameter(dbComm, "@CardID", DbType.String, CardID)
            db.AddInParameter(dbComm, "@FP_OutType", DbType.String, FP_OutType)
            db.AddInParameter(dbComm, "@FP_OutOK", DbType.String, FP_OutOK)

            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function ProductionFieldSub_Add(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldSub_Add")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objinfo.PB_ID)
                db.AddInParameter(dbComm, "@BadnessQty", DbType.String, objinfo.BadnessQty)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldSub_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldSub_Add = False
            End Try
        End Function

        Public Function ProductionFieldSub_Update(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldSub_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objinfo.PB_ID)
                db.AddInParameter(dbComm, "@BadnessQty", DbType.String, objinfo.BadnessQty)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldSub_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldSub_Update = False
            End Try
        End Function

        Public Function ProductionFieldSub_Delete(ByVal AutoID As String, ByVal FP_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldSub_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldSub_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldSub_Delete = False
            End Try
        End Function

        Public Function ProductionFieldSub_GetList(ByVal FP_NO As String) As List(Of ProductionFieldInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldSub_GetList")

            db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)

            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function ProductionFieldSub_GetList1(ByVal FP_NO As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, _
        ByVal Pro_NO As String, ByVal FP_Type As String, ByVal FP_InDep As String, ByVal FP_OutDep As String, ByVal FP_Detail As String, _
        ByVal FP_InCheck As String, ByVal FP_Check As String, ByVal FP_Date1 As String, ByVal FP_Date2 As String, ByVal CardID As String, _
        ByVal FP_OutType As String, ByVal FP_OutOK As String, ByVal PB_ID As String) As List(Of ProductionFieldInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldSub_GetList1")

            db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@FP_Type", DbType.String, FP_Type)
            db.AddInParameter(dbComm, "@FP_InDep", DbType.String, FP_InDep)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FP_Detail", DbType.String, FP_Detail)

            If FP_InCheck = Nothing Then
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, FP_InCheck)
            End If

            If FP_Check = Nothing Then
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, FP_Check)
            End If

            db.AddInParameter(dbComm, "@FP_Date1", DbType.String, FP_Date1)
            db.AddInParameter(dbComm, "@FP_Date2", DbType.String, FP_Date2) '

            db.AddInParameter(dbComm, "@CardID", DbType.String, CardID)
            db.AddInParameter(dbComm, "@FP_OutType", DbType.String, FP_OutType)
            db.AddInParameter(dbComm, "@FP_OutOK", DbType.String, FP_OutOK)
            db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionField(ByVal reader As IDataReader) As ProductionFieldInfo
            On Error Resume Next
            Dim pfi As New ProductionFieldInfo
            pfi.M_Name = reader("M_Name")
            If reader("PM_JiYu") Is DBNull.Value Then
                pfi.PM_JiYu = Nothing
            Else
                pfi.PM_JiYu = reader("PM_JiYu")
            End If
            pfi.AutoID = reader("AutoID")
            pfi.FP_NO = reader("FP_NO").ToString
            pfi.FP_Num = reader("FP_Num").ToString
            pfi.Pro_NO = reader("Pro_NO").ToString
            pfi.Pro_NO1 = reader("Pro_NO1").ToString
            pfi.Pro_Type = reader("Pro_Type").ToString
            pfi.PM_M_Code = reader("PM_M_Code").ToString
            pfi.PM_Type = reader("PM_Type").ToString
            pfi.Pro_Type1 = reader("Pro_Type1").ToString
            pfi.PM_M_Code1 = reader("PM_M_Code1").ToString
            pfi.PM_Type1 = reader("PM_Type1").ToString

            If reader("FP_Qty") Is DBNull.Value Then
                pfi.FP_Qty = 0
            Else
                pfi.FP_Qty = CInt(reader("FP_Qty"))
            End If

            If reader("FP_Weight") Is DBNull.Value Then
                pfi.FP_Weight = 0
            Else
                pfi.FP_Weight = CSng(reader("FP_Weight"))
            End If


            If reader("FP_Date") Is DBNull.Value Then
                pfi.FP_Date = Nothing
            Else
                pfi.FP_Date = CStr(reader("FP_Date"))
            End If

            pfi.Pro_M_NO = reader("Pro_M_NO").ToString

            If reader("PS_Num") Is DBNull.Value Then
                pfi.PS_Num = 0
            Else
                pfi.PS_Num = CInt(reader("PS_Num"))
            End If

            If reader("PS_Num1") Is DBNull.Value Then
                pfi.PS_Num1 = 0
            Else
                pfi.PS_Num1 = CInt(reader("PS_Num1"))
            End If


            pfi.FP_Type = reader("FP_Type").ToString

            pfi.FP_InDep = reader("FP_InDep").ToString
            pfi.FP_OutDep = reader("FP_OutDep").ToString

            pfi.FP_Detail = reader("FP_Detail").ToString
            pfi.FP_InAction = reader("FP_InAction").ToString
            pfi.FP_OutAction = reader("FP_OutAction").ToString

            If reader("FP_InCheck") Is DBNull.Value Then
                pfi.FP_InCheck = Nothing
            Else
                pfi.FP_InCheck = CStr(reader("FP_InCheck"))
            End If
            If reader("FP_Check") Is DBNull.Value Then
                pfi.FP_Check = Nothing
            Else
                pfi.FP_Check = CStr(reader("FP_Check"))
            End If

            pfi.FP_CheckAction = reader("FP_CheckAction").ToString
            pfi.FP_Remark = reader("FP_Remark").ToString
            pfi.FP_CheckRemark = reader("FP_CheckRemark").ToString

            pfi.FP_OutActionName = reader("FP_OutActionName").ToString
            pfi.FP_CheckActionName = reader("FP_CheckActionName").ToString
            pfi.FP_InActionName = reader("FP_InActionName").ToString

            pfi.PS_Name = reader("PS_Name").ToString
            '------------------------------------------------------------------------
            pfi.PH_ID = reader("PH_ID").ToString
            pfi.M_Code = reader("M_Code").ToString

            If reader("PI_Qty") Is DBNull.Value Then
                pfi.PI_Qty = 0
            Else
                pfi.PI_Qty = CInt(reader("PI_Qty"))
            End If
            '------------------------------------------------------------------------
            pfi.FacInName = reader("FacInName").ToString
            pfi.FacOutName = reader("FacOutName").ToString
            pfi.DepInName = reader("FacInName").ToString & "-" & reader("DepInName").ToString
            pfi.DepOutName = reader("FacOutName").ToString & "-" & reader("DepOutName").ToString
            pfi.PS_Name1 = reader("PS_Name1").ToString
            pfi.PT_Type = reader("PT_Type").ToString
            '------------------------------------------------------------------------
            If reader("FP_Qty1") Is DBNull.Value Then
                pfi.FP_Qty1 = 0
            Else
                pfi.FP_Qty1 = CInt(reader("FP_Qty1"))
            End If

            pfi.FP_SendType = reader("FP_SendType").ToString
            '------------------------------------------------------------------------

            pfi.OW_NO = reader("OW_NO").ToString   '米亞外發聯豐單號
            pfi.IW_NO = reader("IW_NO").ToString   '聯豐送回單號

            If reader("FP_InCheckDate") Is DBNull.Value Then
                pfi.FP_InCheckDate = Nothing
                pfi.FP_InCheckDates = ""
            Else
                pfi.FP_InCheckDate = CStr(reader("FP_InCheckDate"))
                pfi.FP_InCheckDates = CStr(reader("FP_InCheckDate"))
            End If

            If reader("FP_EndQty") Is DBNull.Value Then
                pfi.FP_EndQty = 0
            Else
                pfi.FP_EndQty = reader("FP_EndQty")
            End If
            If reader("FP_EndReQty") Is DBNull.Value Then
                pfi.FP_EndReQty = 0
            Else
                pfi.FP_EndReQty = reader("FP_EndReQty")
            End If

            If reader("FP_SubtractReQty") Is DBNull.Value Then
                pfi.FP_SubtractReQty = Nothing
            Else
                pfi.FP_SubtractReQty = reader("FP_SubtractReQty")
            End If

            pfi.CardID = reader("CardID").ToString
            pfi.FP_OutType = reader("FP_OutType").ToString

            If reader("FP_OutOK") Is DBNull.Value Then
                pfi.FP_OutOK = Nothing
            Else
                pfi.FP_OutOK = reader("FP_OutOK")
            End If

            pfi.PB_ID = reader("PB_ID").ToString
            pfi.PB_Cause = reader("PB_Cause").ToString
            pfi.BadnessQty = reader("BadnessQty")
            pfi.Remark = reader("Remark").ToString


            pfi.LBFP_NO = reader("LBFP_NO").ToString
            pfi.LBQty = reader("LBQty")
            pfi.JCFP_NO = reader("JCFP_NO").ToString
            pfi.JCQty = reader("JCQty").ToString
            pfi.JCLBCheck = reader("JCLBCheck")

            pfi.ReturnQty = CInt(reader("ReturnQty"))

            pfi.M_Gauge = reader("M_Gauge").ToString

            If reader("FP_Type").ToString = "發料" Then
                pfi.FP_QtyS = -CInt(reader("FP_Qty"))
            Else
                pfi.FP_QtyS = CInt(reader("FP_Qty"))
            End If

            Return pfi
        End Function

        Public Function ProductionField_GetList3(ByVal FP_NO As String, ByVal Pro_NO As String, ByVal FP_Type As String, _
        ByVal FP_InDep As String, ByVal FP_OutDep As String, ByVal FP_Detail As String, ByVal FP_InCheck As String, _
        ByVal FP_Check As String, ByVal FP_Date As String, ByVal FP_DateVal As String, ByVal Mode As String, _
        ByVal FP_OutType As String, ByVal FP_OutOK As String, ByVal Pro_Type As String, ByVal Pro_Type1 As String) As List(Of ProductionFieldInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionField_GetList3")

            db.AddInParameter(dbComm, "@FP_NO", DbType.String, FP_NO)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@FP_Type", DbType.String, FP_Type)
            db.AddInParameter(dbComm, "@FP_InDep", DbType.String, FP_InDep)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FP_Detail", DbType.String, FP_Detail)

            If FP_InCheck = Nothing Then
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.String, FP_InCheck)
            End If

            If FP_Check = Nothing Then
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, DBNull.Value)
            Else
                db.AddInParameter(dbComm, "@FP_Check", DbType.String, FP_Check)
            End If

            db.AddInParameter(dbComm, "@FP_Date", DbType.String, FP_Date)
            db.AddInParameter(dbComm, "@FP_DateVal", DbType.String, FP_DateVal)

            db.AddInParameter(dbComm, "@Mode", DbType.String, Mode)
            db.AddInParameter(dbComm, "@FP_OutType", DbType.String, FP_OutType)
            db.AddInParameter(dbComm, "@FP_OutOK", DbType.String, FP_OutOK)

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@Pro_Type1", DbType.String, Pro_Type1)

            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using

        End Function

#Region "留辦-加存相關聯"

        Public Function ProductionFieldJCLB_Add(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldJCLB_Add")

                db.AddInParameter(dbComm, "@LBFP_NO", DbType.String, objinfo.LBFP_NO)
                db.AddInParameter(dbComm, "@LBQty", DbType.Int32, objinfo.LBQty)
                db.AddInParameter(dbComm, "@JCFP_NO", DbType.String, objinfo.JCFP_NO)
                db.AddInParameter(dbComm, "@JCQty", DbType.Int32, objinfo.JCQty)
                db.AddInParameter(dbComm, "@JCLBCheck", DbType.Boolean, objinfo.JCLBCheck)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldJCLB_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldJCLB_Add = False
            End Try
        End Function

        Public Function ProductionFieldJCLB_Check(ByVal objinfo As ProductionFieldInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldJCLB_Check")

                db.AddInParameter(dbComm, "@LBFP_NO", DbType.String, objinfo.LBFP_NO)
                db.AddInParameter(dbComm, "@JCFP_NO", DbType.String, objinfo.JCFP_NO)
                db.AddInParameter(dbComm, "@JCLBCheck", DbType.Boolean, objinfo.JCLBCheck)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldJCLB_Check = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldJCLB_Check = False
            End Try
        End Function

        Public Function ProductionFieldJCLB_GetList(ByVal LBFP_NO As String, ByVal JCFP_NO As String, ByVal JCLBCheck As String) As List(Of ProductionFieldInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldJCLB_GetList")

            db.AddInParameter(dbComm, "@LBFP_NO", DbType.String, LBFP_NO)
            db.AddInParameter(dbComm, "@JCFP_NO", DbType.String, JCFP_NO)
            db.AddInParameter(dbComm, "@JCLBCheck", DbType.String, JCLBCheck)

            Dim FeatureList As New List(Of ProductionFieldInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionField(reader))
                End While
                Return FeatureList
            End Using

        End Function


        Public Function ProductionFieldJCLB_Delete(ByVal JCFP_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldJCLB_Delete")

                db.AddInParameter(dbComm, "@JCFP_NO", DbType.String, JCFP_NO)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldJCLB_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldJCLB_Delete = False
            End Try
        End Function



#End Region








    End Class

End Namespace



Namespace LFERP.Library.Production.ProductionFieldDaySummaryCreat

    Public Class ProductionFieldDaySummaryCreatControl
        ''' <summary>
        ''' 載入默認工序
        ''' </summary>
        ''' <param name="Pro_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="PS_NO"></param>
        ''' <param name="GoIN"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummary_GoIN_GetList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_NO As String, ByVal GoIN As String) As List(Of ProductionFieldDaySummaryCreatInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummary_GoIN_GetList")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)

            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@GoIN", DbType.String, GoIN)



            Dim FeatureList As New List(Of ProductionFieldDaySummaryCreatInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummary_GoIN(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function FillProductionFieldDaySummary_GoIN(ByVal reader As IDataReader) As ProductionFieldDaySummaryCreatInfo

            Dim ai As New ProductionFieldDaySummaryCreatInfo


            If reader("Pro_Type") Is DBNull.Value Then
                ai.Pro_Type = Nothing
            Else
                ai.Pro_Type = reader("Pro_Type")
            End If

            If reader("PM_M_Code") Is DBNull.Value Then
                ai.PM_M_Code = Nothing
            Else
                ai.PM_M_Code = reader("PM_M_Code")
            End If

            If reader("PM_Type") Is DBNull.Value Then
                ai.PM_Type = Nothing
            Else
                ai.PM_Type = reader("PM_Type")
            End If

            If reader("GoIN") Is DBNull.Value Then
                ai.GoIN = False
            Else
                ai.GoIN = reader("GoIN")
            End If

            If reader("PS_NO") Is DBNull.Value Then
                ai.PS_NO = Nothing
            Else
                ai.PS_NO = reader("PS_NO")
            End If



            Return ai
        End Function

        Public Function ProductionFieldDaySummary_GoIN_Add(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_NO As String, ByVal GoIN As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummary_GoIN_Add")

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
                db.AddInParameter(dbComm, "@GoIN", DbType.String, GoIN)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldDaySummary_GoIN_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldDaySummary_GoIN_Add = False
            End Try

        End Function

        ''' <summary>
        ''' 查詢表中是否存在指定字段
        ''' </summary>
        ''' <param name="FieldName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryTempColl_GetList(ByVal TableName As String, ByVal FieldName As String) As List(Of ProductionFieldDaySummaryCreatInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryTempColl")

            db.AddInParameter(dbComm, "@FieldName", DbType.String, FieldName)
            db.AddInParameter(dbComm, "@TableName", DbType.String, TableName)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryCreatInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummaryTempColl(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionFieldDaySummaryTempColl(ByVal reader As IDataReader) As ProductionFieldDaySummaryCreatInfo

            Dim ai As New ProductionFieldDaySummaryCreatInfo

            If reader("name") Is DBNull.Value Then
                ai.Name = Nothing
            Else
                ai.Name = reader("Name")
            End If
            Return ai
        End Function
        ''' <summary>
        ''' 修改表結構
        ''' </summary>
        ''' <param name="StrAlter"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryTempAlter(ByVal TableName As String, ByVal StrAlter As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryTempAlter")

                db.AddInParameter(dbComm, "@StrAlter", DbType.String, StrAlter)
                db.AddInParameter(dbComm, "@TableName", DbType.String, TableName)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldDaySummaryTempAlter = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldDaySummaryTempAlter = False
            End Try

        End Function
        ''' <summary>
        ''' 查詢數據
        ''' </summary>
        ''' <param name="Pro_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="FiledDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryTemp_GetList(ByVal TableName As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal FiledDate As String) As List(Of ProductionFieldDaySummaryCreatInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryTemp_GetList")

            db.AddInParameter(dbComm, "@TableName", DbType.String, TableName)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@FiledDate", DbType.String, FiledDate)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryCreatInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummaryTemp_GetList(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function FillProductionFieldDaySummaryTemp_GetList(ByVal reader As IDataReader) As ProductionFieldDaySummaryCreatInfo

            Dim ai As New ProductionFieldDaySummaryCreatInfo


            If reader("Pro_Type") Is DBNull.Value Then
                ai.Pro_Type = Nothing
            Else
                ai.Pro_Type = reader("Pro_Type")
            End If

            If reader("PM_M_Code") Is DBNull.Value Then
                ai.PM_M_Code = Nothing
            Else
                ai.PM_M_Code = reader("PM_M_Code")
            End If

            Return ai
        End Function
        ''' <summary>
        ''' 添加/修改數據
        ''' </summary>
        ''' <param name="AddUpdate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryTempAddUpdate(ByVal AddUpdate As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummaryTempAddUpdate")

                db.AddInParameter(dbComm, "@AddUpdate", DbType.String, AddUpdate)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldDaySummaryTempAddUpdate = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldDaySummaryTempAddUpdate = False
            End Try

        End Function


        ''' <summary>
        ''' 查詢出表是不是存在
        ''' </summary>
        ''' <param name="TableName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummaryTempTable_GetList(ByVal TableName As String) As List(Of ProductionFieldDaySummaryCreatInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("productionFieldDaySummaryTempTable")

            db.AddInParameter(dbComm, "@TableName", DbType.String, TableName)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryCreatInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummaryTempTable(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionFieldDaySummaryTempTable(ByVal reader As IDataReader) As ProductionFieldDaySummaryCreatInfo

            Dim ai As New ProductionFieldDaySummaryCreatInfo


            If reader("name") Is DBNull.Value Then
                ai.Name = Nothing
            Else
                ai.Name = reader("name")
            End If
            Return ai
        End Function



        ''' <summary>
        ''' 去除產品工藝流程中 產品紡號的重復記錄 
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummarySF_ProcessMainGetList(ByVal PM_M_Code As String) As List(Of ProductionFieldDaySummaryCreatInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummarySF_ProcessMainGetList")
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryCreatInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummarySF_ProcessMainGetList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionFieldDaySummarySF_ProcessMainGetList(ByVal reader As IDataReader) As ProductionFieldDaySummaryCreatInfo
            On Error Resume Next

            Dim ai As New ProductionFieldDaySummaryCreatInfo


            If reader("PM_M_Code") Is DBNull.Value Then
                ai.PM_M_Code = Nothing
            Else
                ai.PM_M_Code = reader("PM_M_Code")
            End If

            If reader("PM_Type") Is DBNull.Value Then
                ai.PM_Type = Nothing
            Else
                ai.PM_Type = reader("PM_Type")
            End If

            ''PM_JiYu 機玉

            If reader("PM_JiYu") Is DBNull.Value Then
                ai.PM_JiYu = Nothing
            Else
                ai.PM_JiYu = reader("PM_JiYu")
            End If

            If reader("Pro_Type") Is DBNull.Value Then
                ai.Pro_Type = Nothing
            Else
                ai.Pro_Type = reader("Pro_Type")
            End If




            Return ai
        End Function
        ''' <summary>
        ''' 去除產品工藝流程中 產品紡號.類型.的重復記錄  
        ''' </summary>
        ''' <param name="Pro_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionFieldDaySummarySF_ProcessMainGetList1(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String) As List(Of ProductionFieldDaySummaryCreatInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummarySF_ProcessMainGetList1")
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryCreatInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummarySF_ProcessMainGetList(reader))
                End While
                Return FeatureList
            End Using

        End Function

    End Class

End Namespace
Namespace LFERP.DataSetting
    Public Class CurrencyControler
        ''' <summary>
        ''' 取得貨幣清單
        ''' </summary>
        ''' <param name="C_IDList">貨幣代號列表,nothing為顯示所有</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function GetCurrencyList(ByVal C_IDList As String) As List(Of CurrencyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Currency_GetList")
            db.AddInParameter(dbComm, "@C_ID", DbType.String, C_IDList)
            Dim FeatureList As New List(Of CurrencyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillCurrencyType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ExChangeRate_Add(ByVal objinfo As CurrencyInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ExChangeRate_Add")

                db.AddInParameter(dbComm, "StrYM", DbType.String, objinfo.StrYM)
                db.AddInParameter(dbComm, "C_ID", DbType.String, objinfo.C_ID)
                db.AddInParameter(dbComm, "C_Name", DbType.String, objinfo.C_Name)
                db.AddInParameter(dbComm, "Ex_Rate", DbType.Double, objinfo.Ex_Rate)
                db.ExecuteNonQuery(dbComm)
                ExChangeRate_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ExChangeRate_Add = False
            End Try

        End Function

        Public Function ExChangeRate_Update(ByVal objinfo As CurrencyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ExChangeRate_Update")

                db.AddInParameter(dbComm, "StrYM", DbType.String, objinfo.StrYM)
                db.AddInParameter(dbComm, "C_ID", DbType.String, objinfo.C_ID)
                db.AddInParameter(dbComm, "C_Name", DbType.String, objinfo.C_Name)
                db.AddInParameter(dbComm, "Ex_Rate", DbType.Double, objinfo.Ex_Rate)
                db.ExecuteNonQuery(dbComm)
                ExChangeRate_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ExChangeRate_Update = False
            End Try
        End Function

        Public Function ExChangeRate_UpdateYear(ByVal objinfo As CurrencyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ExChangeRate_UpdateYear")

                db.AddInParameter(dbComm, "StrYM", DbType.String, objinfo.StrYM)
                db.AddInParameter(dbComm, "C_ID", DbType.String, objinfo.C_ID)
                db.AddInParameter(dbComm, "C_Name", DbType.String, objinfo.C_Name)
                db.AddInParameter(dbComm, "Ex_Rate", DbType.Double, objinfo.Ex_Rate)
                db.ExecuteNonQuery(dbComm)
                ExChangeRate_UpdateYear = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ExChangeRate_UpdateYear = False
            End Try
        End Function

        Public Function ExChangeRate_Delete(ByVal AutoID As String) As Boolean

            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ExChangeRate_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                ExChangeRate_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ExChangeRate_Delete = False

            End Try
        End Function

        Public Function ExChangeRate_GetList(ByVal AutoID As String, ByVal StrYM As String, ByVal C_ID As String, ByVal C_Name As String) As List(Of CurrencyInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ExChangeRate_GetList")


            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@StrYM", DbType.String, StrYM)
            db.AddInParameter(dbComm, "@C_ID", DbType.String, C_ID)
            db.AddInParameter(dbComm, "@C_Name", DbType.String, C_Name)

            Dim FeatureList As New List(Of CurrencyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillCurrencyType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillCurrencyType(ByVal reader As IDataReader) As CurrencyInfo
            '對應取得的數據
            On Error Resume Next

            Dim objInfo As New CurrencyInfo
            objInfo.C_ID = reader("C_ID").ToString
            objInfo.C_Name = reader("C_Name").ToString

            objInfo.AutoID = reader("AutoID").ToString
            objInfo.Ex_Rate = CDbl(reader("Ex_Rate").ToString)
            objInfo.StrYM = reader("StrYM").ToString

            Return objInfo
        End Function

    End Class

End Namespace


Namespace LFERP.Library.Production.ProductionDetailMainMonthSum

    Public Class ProductionDetailMainMonthSumControl
        ''' <summary>
        ''' 查詢ProductionDetailMainMonthSum中記錄
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="FiledDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionDetailMainMonthSum_GetList(ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal FiledDate As String) As List(Of ProductionDetailMainMonthSumInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionDetailMainMonthSum_GetList")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@FiledDate", DbType.String, FiledDate)


            Dim FeatureList As New List(Of ProductionDetailMainMonthSumInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionDetailMainMonthSum_GetList(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionDetailMainMonthSum_GetList(ByVal reader As IDataReader) As ProductionDetailMainMonthSumInfo

            Dim ai As New ProductionDetailMainMonthSumInfo


            If reader("PM_M_Code") Is DBNull.Value Then
                ai.PM_M_Code = Nothing
            Else
                ai.PM_M_Code = reader("PM_M_Code")
            End If
            Return ai
        End Function

        ''' <summary>
        ''' 統計出數據
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="StrdateS"></param>
        ''' <param name="StrdateE"></param>
        ''' <param name="Modle"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionDetailMainMonthSum_Qty(ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal StrdateS As String, ByVal StrdateE As String, ByVal Modle As String) As List(Of ProductionDetailMainMonthSumInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionDetailMainMonthSum_Qty")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@StrdateS", DbType.String, StrdateS)
            db.AddInParameter(dbComm, "@StrdateE", DbType.String, StrdateE)
            db.AddInParameter(dbComm, "@Modle", DbType.String, Modle)


            Dim FeatureList As New List(Of ProductionDetailMainMonthSumInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionDetailMainMonthSum_Qty(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionDetailMainMonthSum_Qty(ByVal reader As IDataReader) As ProductionDetailMainMonthSumInfo

            Dim ai As New ProductionDetailMainMonthSumInfo



            If reader("Qty") Is DBNull.Value Then
                ai.Qty = 0
            Else
                ai.Qty = CDbl(reader("Qty"))
            End If

            Return ai
        End Function
    End Class

End Namespace
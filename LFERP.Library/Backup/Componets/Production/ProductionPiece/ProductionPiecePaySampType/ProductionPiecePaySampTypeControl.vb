Namespace LFERP.Library.ProductionPiecePaySampType
    Public Class ProductionPiecePaySampTypeControl


        Public Function ProductionPiecePaySampType_GetList(ByVal SampID As String, ByVal SampName As String, ByVal SampCheck As String, ByVal DepID As String) As List(Of ProductionPiecePaySampTypeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePaySampType_GetList")

            db.AddInParameter(dbcomm, "@SampID", DbType.String, SampID)
            db.AddInParameter(dbcomm, "@SampName", DbType.String, SampName)
            db.AddInParameter(dbcomm, "@SampCheck", DbType.String, SampCheck)
            db.AddInParameter(dbcomm, "@DepID", DbType.String, DepID)

            Dim FeatureList As New List(Of ProductionPiecePaySampTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillProductionPiecePaySampType(reader))
                End While
                Return FeatureList
            End Using
        End Function



        Public Function FillProductionPiecePaySampType(ByVal reader As IDataReader) As ProductionPiecePaySampTypeInfo
            Dim ai As New ProductionPiecePaySampTypeInfo

            If reader("SampID") Is DBNull.Value Then
                ai.SampID = Nothing
            Else
                ai.SampID = reader("SampID").ToString
            End If

            If reader("SampName") Is DBNull.Value Then
                ai.SampName = Nothing
            Else
                ai.SampName = reader("SampName").ToString
            End If

            If reader("SampPrice") Is DBNull.Value Then
                ai.SampPrice = 0
            Else
                ai.SampPrice = reader("SampPrice")
            End If

            If reader("SampCheck") Is DBNull.Value Then
                ai.SampCheck = Nothing
            Else
                ai.SampCheck = reader("SampCheck")
            End If

            Return ai
        End Function
    End Class
End Namespace


Namespace LFERP.Library.NmetalSampleManager.NmetalSampleReWaste


    Public Class NmetalSampleReWasteSubControl
        Public Function NmetalSampleReWasteSub_Add(ByVal objinfo As NmetalSampleReWasteSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleReWasteSub_Add")

                db.AddInParameter(dbComm, "@ReNO", DbType.String, objinfo.ReNO)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int16, objinfo.Qty)
                db.AddInParameter(dbComm, "@WeightS", DbType.Decimal, objinfo.WeightS)

                db.AddInParameter(dbComm, "@InQty", DbType.Int16, objinfo.InQty)
                db.AddInParameter(dbComm, "@InWeightS", DbType.Decimal, objinfo.InWeightS)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleReWasteSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleReWasteSub_Add = False
            End Try
        End Function

        ''' <summary>
        ''' н╫зя
        ''' Mark
        ''' 2014-08-01
        ''' </summary>
        ''' <remarks></remarks>
        Public Function NmetalSampleReWasteSub_Update(ByVal AutoID As String, ByVal InQty As Int16, ByVal InWeightS As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleReWasteSub_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@InQty", DbType.Int16, InQty)
                db.AddInParameter(dbComm, "@InWeightS", DbType.Decimal, InWeightS)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleReWasteSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleReWasteSub_Update = False
            End Try
        End Function


        Public Function NmetalSampleReWasteSub_Delete(ByVal AutoID As String, ByVal ReNO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleReWasteSub_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@ReNO", DbType.String, ReNO)

                db.ExecuteNonQuery(dbComm)
                NmetalSampleReWasteSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleReWasteSub_Delete = False
            End Try
        End Function


        Public Function NmetalSampleReWasteSub_GetList(ByVal AutoID As String, ByVal ReNO As String) As List(Of NmetalSampleReWasteSubInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleReWasteSub_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@ReNO", DbType.String, ReNO)


            Dim FeatureList As New List(Of NmetalSampleReWasteSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleReWasteSub(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillNmetalSampleReWasteSub(ByVal reader As IDataReader) As NmetalSampleReWasteSubInfo
            On Error Resume Next

            Dim objInfo As New NmetalSampleReWasteSubInfo

            objInfo.AutoID = reader("AutoID")
            objInfo.ReNO = reader("ReNO").ToString
            objInfo.Qty = reader("Qty")
            objInfo.WeightS = reader("WeightS")
            objInfo.Code_ID = reader("Code_ID")

            objInfo.InWeightS = reader("InWeightS")
            objInfo.InQty = reader("InQty")

            Return objInfo
        End Function

    End Class
End Namespace
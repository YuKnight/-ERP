Namespace LFERP.Library.ProductionSumLock


    Public Class ProductionSumLockControl
        Public Function ProductionSumLock_Add(ByVal objinfo As ProductionSumLockInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumLock_Add")

                db.AddInParameter(dbcomm, "@FacID", DbType.String, objinfo.FacID)
                db.AddInParameter(dbcomm, "@DepID", DbType.String, objinfo.DepID)
                db.AddInParameter(dbcomm, "@LockYYYYMM", DbType.String, objinfo.LockYYYYMM)

                db.AddInParameter(dbcomm, "@LockCheck", DbType.Boolean, objinfo.LockCheck)
                db.AddInParameter(dbcomm, "@AddDate", DbType.Date, objinfo.AddDate)
                db.AddInParameter(dbcomm, "@AddAction", DbType.String, objinfo.AddAction)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumLock_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumLock_Add = False

            End Try
        End Function


        Public Function ProductionSumLock_Update(ByVal objinfo As ProductionSumLockInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumLock_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbcomm, "@FacID", DbType.String, objinfo.FacID)
                db.AddInParameter(dbcomm, "@DepID", DbType.String, objinfo.DepID)
                db.AddInParameter(dbcomm, "@LockYYYYMM", DbType.String, objinfo.LockYYYYMM)

                db.AddInParameter(dbcomm, "@LockCheck", DbType.Boolean, objinfo.LockCheck)
                db.AddInParameter(dbcomm, "@AddDate", DbType.Date, objinfo.AddDate)
                db.AddInParameter(dbcomm, "@AddAction", DbType.String, objinfo.AddAction)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumLock_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumLock_Update = False

            End Try
        End Function

        Public Function ProductionSumLock_GetList(ByVal AutoID As String, ByVal FacID As String, ByVal DepID As String, ByVal LockYYYYMM As String) As List(Of ProductionSumLockInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumLock_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@LockYYYYMM", DbType.String, LockYYYYMM)
         
            Dim FeatureList As New List(Of ProductionSumLockInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPieceProcess(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionPieceProcess(ByVal reader As IDataReader) As ProductionSumLockInfo


            'Private _AutoID As String
            'Private _FacID As String
            'Private _DepID As String
            'Private _LockYYYYMM As String
            'Private _LockCheck As Boolean
            'Private _AddDate As Date
            'Private _AddAction As String
            'Private _DepName As String
            'Private _FacName As String
            'Private _U_Name As String

            Dim pai As New ProductionSumLockInfo

            If reader("AutoID") Is DBNull.Value Then
                pai.AutoID = False
            Else
                pai.AutoID = reader("AutoID")
            End If
            If reader("FacID") Is DBNull.Value Then
                pai.FacID = Nothing
            Else
                pai.FacID = reader("FacID").ToString
            End If
      
            If reader("DepID") Is DBNull.Value Then
                pai.DepID = Nothing
            Else
                pai.DepID = reader("DepID").ToString
            End If

            If reader("LockYYYYMM") Is DBNull.Value Then
                pai.LockYYYYMM = Nothing
            Else
                pai.LockYYYYMM = reader("LockYYYYMM").ToString
            End If

            If reader("LockCheck") Is DBNull.Value Then
                pai.LockCheck = False
            Else
                pai.LockCheck = reader("LockCheck").ToString
            End If

            If reader("AddDate") Is DBNull.Value Then
                pai.AddDate = Nothing
            Else
                pai.AddDate = reader("AddDate").ToString
            End If

            If reader("AddAction") Is DBNull.Value Then
                pai.AddAction = Nothing
            Else
                pai.AddAction = reader("AddAction").ToString
            End If

            If reader("DepName") Is DBNull.Value Then
                pai.DepName = Nothing
            Else
                pai.DepName = reader("DepName").ToString
            End If

            If reader("FacName") Is DBNull.Value Then
                pai.FacName = Nothing
            Else
                pai.FacName = reader("FacName").ToString
            End If

            If reader("U_Name") Is DBNull.Value Then
                pai.U_Name = Nothing
            Else
                pai.U_Name = reader("U_Name").ToString
            End If

            Return pai
        End Function


        Public Function ProductionSumLock_Delete(ByVal AutoID As String, ByVal PP_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumLock_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)


                db.ExecuteNonQuery(dbcomm)
                ProductionSumLock_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumLock_Delete = False
            End Try
        End Function

    End Class
End Namespace
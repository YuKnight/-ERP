Namespace LFERP.Library.ProductionController

    Public Class ProductionFieldControl

        Public Function ProductionFieldControl_Add(ByVal objinfo As ProductionFieldControlInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldControl_Add")

                db.AddInParameter(dbComm, "@UserID", DbType.String, objinfo.UserID)
                db.AddInParameter(dbComm, "@ControlDep", DbType.String, objinfo.ControlDep)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldControl_Add = True
            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionFieldControl_Add = False
            End Try

        End Function

        Public Function ProductionFieldControl_Delete(ByVal UserID As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldControl_Delete")

                db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldControl_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldControl_Delete = False
            End Try

        End Function

        Public Function ProductionFieldControl_GetList(ByVal UserID As String, ByVal ControlDep As String) As List(Of ProductionFieldControlInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldControl_GetList")

            db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
            db.AddInParameter(dbComm, "@ControlDep", DbType.String, ControlDep)


            Dim FeatureList As New List(Of ProductionFieldControlInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldControl(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionFieldControl_GetList1(ByVal UserID As String, ByVal ControlDep As String, ByVal FacID As String) As List(Of ProductionFieldControlInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldControl_GetList1")

            db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
            db.AddInParameter(dbComm, "@ControlDep", DbType.String, ControlDep)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)

            Dim FeatureList As New List(Of ProductionFieldControlInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldControl(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionFieldControl(ByVal reader As IDataReader) As ProductionFieldControlInfo
            On Error Resume Next

            Dim pi As New ProductionFieldControlInfo

            pi.UserID = reader("UserID").ToString
            pi.ControlDep = reader("ControlDep").ToString
            pi.DepName = reader("DepName").ToString

            Return pi

        End Function
    End Class

End Namespace


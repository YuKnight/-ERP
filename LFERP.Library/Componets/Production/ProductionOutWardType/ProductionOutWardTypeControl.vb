
Namespace LFERP.Library.Production.ProductionType

    Public Class ProductionOutWardTypeControl

        Public Function ProductionOutWardType_Add(ByVal objinfo As ProductionOutWardTypeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWardType_Add")

                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@OW_Do", DbType.String, objinfo.OW_Do)
                db.AddInParameter(dbComm, "@OW_Return", DbType.String, objinfo.OW_Return)
                db.AddInParameter(dbComm, "@OW_ReQty", DbType.Int32, objinfo.OW_ReQty)

      

                db.ExecuteNonQuery(dbComm)
                ProductionOutWardType_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutWardType_Add = False
            End Try

        End Function
        Public Function ProductionOutWardType_Update(ByVal objinfo As ProductionOutWardTypeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWardType_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@OW_Do", DbType.String, objinfo.OW_Do)
                db.AddInParameter(dbComm, "@OW_Return", DbType.String, objinfo.OW_Return)
                db.AddInParameter(dbComm, "@OW_ReQty", DbType.Int32, objinfo.OW_ReQty)



                db.ExecuteNonQuery(dbComm)
                ProductionOutWardType_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutWardType_Update = False
            End Try

        End Function
        Public Function ProductionOutWardType_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWardType_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                ProductionOutWardType_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutWardType_Delete = False
            End Try

        End Function

        Public Function ProductionOutWardType_UpdateQty(ByVal objinfo As ProductionOutWardTypeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWardType_UpdateQty")


                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@OW_Do", DbType.String, objinfo.OW_Do)
                db.AddInParameter(dbComm, "@OW_Return", DbType.String, objinfo.OW_Return)
                db.AddInParameter(dbComm, "@OW_ReQty", DbType.Int32, objinfo.OW_ReQty)

                db.ExecuteNonQuery(dbComm)
                ProductionOutWardType_UpdateQty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOutWardType_UpdateQty = False
            End Try

        End Function
        Public Function ProductionOutWardType_GetList(ByVal AutoID As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal OW_Do As String, ByVal OW_Return As String) As List(Of ProductionOutWardTypeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOutWardType_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@OW_Do", DbType.String, OW_Do)
            db.AddInParameter(dbComm, "@OW_Return", DbType.String, OW_Return)


            Dim FeatureList As New List(Of ProductionOutWardTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionOutWardType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionOutWardType(ByVal reader As IDataReader) As ProductionOutWardTypeInfo

            On Error Resume Next
            Dim pi As New ProductionOutWardTypeInfo


            If reader("PM_JiYu") Is DBNull.Value Then
                pi.PM_JiYu = Nothing
            Else
                pi.PM_JiYu = reader("PM_JiYu")
            End If

            pi.AutoID = reader("AutoID").ToString
            pi.PM_M_Code = reader("PM_M_Code").ToString
            pi.PM_Type = reader("PM_Type").ToString

            pi.OW_Do = reader("OW_Do").ToString
            pi.OW_Return = reader("OW_Return").ToString
            pi.OW_ReQty = CInt(reader("OW_ReQty").ToString)

            Return pi

        End Function

    End Class

End Namespace


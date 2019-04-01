Namespace LFERP.Library.Production.ProductionProductInner

    Public Class ProductionProductInnerControl

        Public Function ProductionProductInner_Add(ByVal objinfo As ProductionProductInnerInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionProductInner_Add")

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_Type1", DbType.String, objinfo.Pro_Type1)
                db.AddInParameter(dbComm, "@PM_M_Code1", DbType.String, objinfo.PM_M_Code1)

                db.AddInParameter(dbComm, "@PM_Type1", DbType.String, objinfo.PM_Type1)
                db.AddInParameter(dbComm, "@AddDate", DbType.Date, objinfo.AddDate)
                db.AddInParameter(dbComm, "@AddAction", DbType.String, objinfo.AddAction)
                db.AddInParameter(dbComm, "@YesOrNo", DbType.Boolean, objinfo.YesOrNo)

                db.ExecuteNonQuery(dbComm)
                ProductionProductInner_Add = True
            Catch ex As Exception
                ProductionProductInner_Add = False
                MsgBox(ex.Message)
            End Try
        End Function

        Public Function ProductionProductInner_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionProductInner_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                ProductionProductInner_Delete = True
            Catch ex As Exception
                ProductionProductInner_Delete = False
                MsgBox(ex.Message)
            End Try

        End Function

        Public Function ProductionProductInner_GetList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, _
        ByVal Pro_Type1 As String, ByVal PM_M_Code1 As String, ByVal PM_Type1 As String) As List(Of ProductionProductInnerInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionProductInner_GetList")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)

            db.AddInParameter(dbComm, "@Pro_Type1", DbType.String, Pro_Type1)
            db.AddInParameter(dbComm, "@PM_M_Code1", DbType.String, PM_M_Code1)
            db.AddInParameter(dbComm, "@PM_Type1", DbType.String, PM_Type1)

            Dim FeatureList As New List(Of ProductionProductInnerInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionProductInner(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionProductInner(ByVal reader As IDataReader) As ProductionProductInnerInfo
            On Error Resume Next

            Dim fi As New ProductionProductInnerInfo

            fi.AutoID = reader("AutoID")
            fi.Pro_Type = reader("Pro_Type").ToString
            fi.PM_M_Code = reader("PM_M_Code").ToString
            fi.PM_Type = reader("PM_Type").ToString
            fi.Pro_Type1 = reader("Pro_Type1").ToString

            fi.PM_M_Code1 = reader("PM_M_Code1").ToString
            fi.PM_Type1 = reader("PM_Type1").ToString
            fi.AddDate = reader("AddDate")
            fi.AddAction = reader("AddAction").ToString
            fi.YesOrNo = reader("YesOrNo")

            Return fi

        End Function



    End Class


End Namespace
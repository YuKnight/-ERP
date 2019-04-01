
Namespace LFERP.Library.Production.ProductionFieldReturnMaterial
    Public Class ProductionFieldReturnMaterialControl
        Public Function ProductionFieldReturnMaterial_Add(ByVal obj As ProductionFieldReturnMaterialInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldReturnMaterial_Add")

                db.AddInParameter(dbcomm, "@R_NO", DbType.String, obj.R_NO)
                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, obj.Pro_Type)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code)
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type)
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, obj.PS_NO)

                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID)
                db.AddInParameter(dbcomm, "@RQty", DbType.Int32, obj.RQty)
                db.AddInParameter(dbcomm, "@RWeight", DbType.Double, obj.RWeight)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code)

                db.AddInParameter(dbcomm, "@RDate", DbType.String, obj.RDate)
                db.AddInParameter(dbcomm, "@RAction", DbType.String, obj.RAction)
                db.AddInParameter(dbcomm, "@RRemark", DbType.String, obj.RRemark)

                db.ExecuteNonQuery(dbcomm)
                ProductionFieldReturnMaterial_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldReturnMaterial_Add = False
            End Try
        End Function


        Public Function ProductionFieldReturnMaterial_Update(ByVal obj As ProductionFieldReturnMaterialInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldReturnMaterial_Update")

                db.AddInParameter(dbcomm, "@R_NO", DbType.String, obj.R_NO)
                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, obj.Pro_Type)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code)
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type)
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, obj.PS_NO)

                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID)
                db.AddInParameter(dbcomm, "@RQty", DbType.Int32, obj.RQty)
                db.AddInParameter(dbcomm, "@RWeight", DbType.Double, obj.RWeight)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code)

                db.AddInParameter(dbcomm, "@RDate", DbType.String, obj.RDate)
                db.AddInParameter(dbcomm, "@RAction", DbType.String, obj.RAction)
                db.AddInParameter(dbcomm, "@RRemark", DbType.String, obj.RRemark)

                db.ExecuteNonQuery(dbcomm)
                ProductionFieldReturnMaterial_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldReturnMaterial_Update = False
            End Try
        End Function

        Public Function ProductionFieldReturnMaterial_Check(ByVal obj As ProductionFieldReturnMaterialInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldReturnMaterial_Check")

                db.AddInParameter(dbcomm, "@R_NO", DbType.String, obj.R_NO)
                db.AddInParameter(dbcomm, "@RCheck", DbType.String, obj.RCheck)
                db.AddInParameter(dbcomm, "@RCheckDate", DbType.String, obj.RCheckDate)

                db.AddInParameter(dbcomm, "@RCheckAction", DbType.String, obj.RCheckAction)
                db.AddInParameter(dbcomm, "@RCheckReamrk", DbType.String, obj.RCheckReamrk)

                db.ExecuteNonQuery(dbcomm)
                ProductionFieldReturnMaterial_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldReturnMaterial_Check = False
            End Try
        End Function

        Public Function ProductionFieldReturnMaterial_Delete(ByVal R_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldReturnMaterial_Delete")

                db.AddInParameter(dbcomm, "@R_NO", DbType.String, R_NO)

                db.ExecuteNonQuery(dbcomm)
                ProductionFieldReturnMaterial_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldReturnMaterial_Delete = False
            End Try
        End Function

        Public Function ProductionFieldReturnMaterial_GetNO(ByVal NDate As String) As ProductionFieldReturnMaterialInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldReturnMaterial_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionFieldReturnMaterialNO(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function FillProductionFieldReturnMaterialNO(ByVal reader As IDataReader) As ProductionFieldReturnMaterialInfo
            On Error Resume Next
            Dim Pi As New ProductionFieldReturnMaterialInfo
            PI.R_NO = reader("R_NO").ToString

            Return Pi

        End Function


        Public Function ProductionFieldReturnMaterial_GetList(ByVal R_NO As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_NO As String, _
        ByVal DepID As String, ByVal WH_ID As String, ByVal M_Code As String, ByVal RDate1 As String, ByVal RDate2 As String, ByVal RCheck As String, ByVal RInCheck As String) As List(Of ProductionFieldReturnMaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldReturnMaterial_GetList")

            db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@RDate1", DbType.String, RDate1)
            db.AddInParameter(dbComm, "@RDate2", DbType.String, RDate2)

            db.AddInParameter(dbComm, "@RCheck", DbType.Boolean, RCheck)
            db.AddInParameter(dbComm, "@RInCheck", DbType.Boolean, RInCheck)


            Dim FeatureList As New List(Of ProductionFieldReturnMaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldReturnMaterial(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionFieldReturnMaterial(ByVal reader As IDataReader) As ProductionFieldReturnMaterialInfo
            On Error Resume Next
            Dim Pi As New ProductionFieldReturnMaterialInfo
            Pi.AutoID = reader("AutoID").ToString
            Pi.R_NO = reader("R_NO").ToString
            Pi.Pro_Type = reader("Pro_Type").ToString
            Pi.PM_M_Code = reader("PM_M_Code").ToString
            Pi.PM_Type = reader("PM_Type").ToString

            Pi.DepID = reader("DepID").ToString
            Pi.PS_NO = reader("PS_NO").ToString
            Pi.RQty = reader("RQty")
            Pi.RWeight = reader("RWeight")
            Pi.WH_ID = reader("WH_ID").ToString


            Pi.M_Code = reader("M_Code").ToString
            Pi.RDate = Format(CDate(reader("RDate")), "yyyy/MM/dd HH:mm:ss")
            Pi.RAction = reader("RAction").ToString
            Pi.RRemark = reader("RRemark").ToString
            Pi.RCheck = reader("RCheck")

            Pi.RCheckDate = Format(CDate(reader("RCheckDate")), "yyyy/MM/dd HH:mm:ss")
            Pi.RCheckAction = reader("RCheckAction").ToString
            Pi.RCheckReamrk = reader("RCheckReamrk").ToString
            Pi.RInCheck = reader("RInCheck")
            Pi.RIncheckDate = Format(CDate(reader("RIncheckDate")), "yyyy/MM/dd HH:mm:ss")

            Pi.RIncheckAction = reader("RIncheckAction").ToString
            Pi.RIncheckRemark = reader("RIncheckRemark").ToString
            Pi.EndRQty = reader("EndRQty")
            Pi.EndRWeight = reader("EndRWeight")
            '---------------------------------------------------------------

            Pi.M_Name = reader("M_Name").ToString
            Pi.M_Gauge = reader("M_Gauge").ToString
            Pi.M_Unit = reader("M_Unit").ToString
            Pi.WH_Name = reader("WH_Name").ToString
            Pi.WH_PName = reader("WH_PName").ToString

            Pi.RActionName = reader("RActionName").ToString
            Pi.RCheckActionName = reader("RCheckActionName").ToString
            Pi.RIncheckActionName = reader("RIncheckActionName").ToString
            Pi.WH_Name = reader("WH_Name").ToString
            Pi.WH_PName = reader("WH_PName").ToString

            Pi.PS_Name = reader("PS_Name").ToString
            Pi.DepName = reader("DepName").ToString

            Return Pi

        End Function


        Public Function ProductionFieldReturnMaterial_InCheck(ByVal obj As ProductionFieldReturnMaterialInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionFieldReturnMaterial_InCheck")

                db.AddInParameter(dbcomm, "@R_NO", DbType.String, obj.R_NO)
                db.AddInParameter(dbcomm, "@RInCheck", DbType.String, obj.RInCheck)
                db.AddInParameter(dbcomm, "@RIncheckDate", DbType.DateTime, obj.RIncheckDate)

                db.AddInParameter(dbcomm, "@RIncheckAction", DbType.String, obj.RIncheckAction)
                db.AddInParameter(dbcomm, "@RIncheckRemark", DbType.String, obj.RIncheckRemark)

                db.AddInParameter(dbcomm, "@FP_NO", DbType.String, obj.FP_NO)
                db.AddInParameter(dbcomm, "@FP_Num", DbType.String, obj.FP_Num)
                db.AddInParameter(dbcomm, "@TuiLiao", DbType.Int16, obj.TuiLiao)

                db.ExecuteNonQuery(dbcomm)
                ProductionFieldReturnMaterial_InCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldReturnMaterial_InCheck = False
            End Try
        End Function

    End Class
End Namespace

Namespace LFERP.Library.ProductionKaiLiaoReturn
    Public Class ProductionKaiLiaoReturnControl

        Public Function ProductionKaiLiaoReturn_GetList(ByVal AutoID As String, ByVal R_NO As String, ByVal WH_ID As String, ByVal C_NO As String, ByVal M_Code As String, _
        ByVal RDate1 As String, ByVal RDate2 As String, ByVal RCheck As String, ByVal KailiaoAutoID As String, ByVal RC_Dep As String, _
        ByVal PM_Type As String, ByVal PM_M_Code As String, ByVal Pro_Type As String) As List(Of ProductionKaiLiaoReturnInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoReturn_GetList")
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@C_NO", DbType.String, C_NO)

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@RDate1", DbType.String, RDate1)
            db.AddInParameter(dbComm, "@RDate2", DbType.String, RDate2)

            db.AddInParameter(dbComm, "@RCheck", DbType.String, RCheck)
            db.AddInParameter(dbComm, "@KailiaoAutoID", DbType.String, KailiaoAutoID)

            db.AddInParameter(dbComm, "@RC_Dep", DbType.String, RC_Dep)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)

            Dim FeatureList As New List(Of ProductionKaiLiaoReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionKaiLiaoReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function ProductionKaiLiaoReturn_GetNO(ByVal Ndate As String) As ProductionKaiLiaoReturnInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoReturn_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionKaiLiaoReturn(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function FillProductionKaiLiaoReturn(ByVal reader As IDataReader) As ProductionKaiLiaoReturnInfo

            On Error Resume Next
            Dim pi As New ProductionKaiLiaoReturnInfo

            pi.AutoID = reader("AutoID").ToString
            pi.R_NO = reader("R_NO").ToString
            pi.WH_ID = reader("WH_ID").ToString
            pi.C_NO = reader("C_NO").ToString
            pi.M_Code = reader("M_Code").ToString

            pi.RQty = reader("RQty")
            pi.RRemark = reader("RRemark").ToString
            pi.RAction = reader("RAction").ToString
            pi.RDate = Format(CDate(reader("RDate")), "yyyy/MM/dd")
            pi.RCheck = reader("RCheck")


            pi.RCheckAction = reader("RCheckAction").ToString
            pi.RCheckDate = Format(CDate(reader("RCheckDate")), "yyyy/MM/dd")
            pi.RCheckRemark = reader("RCheckRemark").ToString
            pi.R_ActQty = reader("R_ActQty")

            pi.RCheck = reader("RCheck").ToString
            pi.M_Name = reader("M_Name").ToString
            pi.M_Gauge = reader("M_Gauge").ToString
            pi.M_Unit = reader("M_Unit").ToString
            pi.WH_Name = reader("WH_Name").ToString
            pi.WH_PName = reader("WH_PName").ToString

            pi.RActionName = reader("RActionName").ToString
            pi.RCheckActionName = reader("RCheckActionName").ToString

            '----------------------------------------------------
            pi.RC_Action = reader("RC_Action").ToString
            pi.RC_Dep = reader("RC_Dep").ToString
            pi.PM_Type = reader("PM_Type").ToString
            pi.PM_M_Code = reader("PM_M_Code").ToString
            pi.Pro_Type = reader("Pro_Type").ToString

            pi.FacName = reader("FacName").ToString
            pi.BriName = reader("BriName").ToString

            pi.KailiaoAutoID = reader("KailiaoAutoID").ToString

            Return pi

        End Function


        Public Function ProductionKaiLiaoReturn_Add(ByVal Objinfo As ProductionKaiLiaoReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoReturn_Add")

                db.AddInParameter(dbComm, "@R_NO", DbType.String, Objinfo.R_NO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, Objinfo.WH_ID)
                db.AddInParameter(dbComm, "@C_NO", DbType.String, Objinfo.C_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)
                db.AddInParameter(dbComm, "@RQty", DbType.Double, Objinfo.RQty)

                db.AddInParameter(dbComm, "@RRemark", DbType.String, Objinfo.RRemark)
                db.AddInParameter(dbComm, "@RAction", DbType.String, Objinfo.RAction)
                db.AddInParameter(dbComm, "@RDate", DbType.DateTime, Objinfo.RDate)

                db.AddInParameter(dbComm, "@RC_Action", DbType.String, Objinfo.RC_Action)
                db.AddInParameter(dbComm, "@RC_Dep", DbType.String, Objinfo.RC_Dep)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, Objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Objinfo.Pro_Type)

                db.AddInParameter(dbComm, "@KailiaoAutoID", DbType.String, Objinfo.KailiaoAutoID)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiaoReturn_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiaoReturn_Add = False
            End Try
        End Function

        Public Function ProductionKaiLiaoReturn_Update(ByVal Objinfo As ProductionKaiLiaoReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoReturn_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, Objinfo.AutoID)
                db.AddInParameter(dbComm, "@R_NO", DbType.String, Objinfo.R_NO)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, Objinfo.WH_ID)
                db.AddInParameter(dbComm, "@C_NO", DbType.String, Objinfo.C_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)

                db.AddInParameter(dbComm, "@RQty", DbType.Double, Objinfo.RQty)
                db.AddInParameter(dbComm, "@RRemark", DbType.String, Objinfo.RRemark)
                db.AddInParameter(dbComm, "@RAction", DbType.String, Objinfo.RAction)
                db.AddInParameter(dbComm, "@RDate", DbType.DateTime, Objinfo.RDate)


                db.AddInParameter(dbComm, "@RC_Action", DbType.String, Objinfo.RC_Action)
                db.AddInParameter(dbComm, "@RC_Dep", DbType.String, Objinfo.RC_Dep)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, Objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Objinfo.Pro_Type)

                db.AddInParameter(dbComm, "@KailiaoAutoID", DbType.String, Objinfo.KailiaoAutoID)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiaoReturn_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiaoReturn_Update = False
            End Try

        End Function

        Public Function ProductionKaiLiaoReturn_UpdateR_ActQty(ByVal Objinfo As ProductionKaiLiaoReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoReturn_UpdateR_ActQty")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, Objinfo.AutoID)
                db.AddInParameter(dbComm, "@R_ActQty", DbType.Double, Objinfo.R_ActQty)
                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiaoReturn_UpdateR_ActQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiaoReturn_UpdateR_ActQty = False
            End Try
        End Function

        Public Function ProductionKaiLiaoReturn_Delete(ByVal AutoID As String, ByVal R_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoReturn_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@R_NO", DbType.String, R_NO)
                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiaoReturn_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiaoReturn_Delete = False
            End Try
        End Function

        Public Function ProductionKaiLiaoReturn_Check(ByVal Objinfo As ProductionKaiLiaoReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionKaiLiaoReturn_Check")

                db.AddInParameter(dbComm, "@R_NO", DbType.String, Objinfo.R_NO)
                db.AddInParameter(dbComm, "@RCheck", DbType.Boolean, Objinfo.RCheck)

                db.AddInParameter(dbComm, "@RCheckAction", DbType.String, Objinfo.RCheckAction)
                db.AddInParameter(dbComm, "@RCheckDate", DbType.DateTime, Objinfo.RCheckDate)
                db.AddInParameter(dbComm, "@RCheckRemark", DbType.String, Objinfo.RCheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionKaiLiaoReturn_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionKaiLiaoReturn_Check = False
            End Try
        End Function



    End Class
End Namespace

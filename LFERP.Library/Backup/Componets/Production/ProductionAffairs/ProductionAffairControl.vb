Namespace LFERP.Library.Production.ProductionAffair

    Public Class ProductionAffairControl
        Public Function UpdateProductionCheck_Qty(ByVal objinfo As ProductionAffairInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateProductionCheck_Qty")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@FP_Type", DbType.String, objinfo.FP_Type)
                db.AddInParameter(dbComm, "@FP_InAction", DbType.String, objinfo.FP_InAction)
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.Boolean, objinfo.FP_InCheck)
                db.AddInParameter(dbComm, "@FP_InCheckDate", DbType.Date, objinfo.FP_InCheckDate)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_Type1", DbType.String, objinfo.Pro_Type1)
                db.AddInParameter(dbComm, "@PM_M_Code1", DbType.String, objinfo.PM_M_Code1)
                db.AddInParameter(dbComm, "@PM_Type1", DbType.String, objinfo.PM_Type1)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@Pro_NO1", DbType.String, objinfo.Pro_NO1)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
                db.AddInParameter(dbComm, "@FP_Detail", DbType.String, objinfo.FP_Detail)
                db.AddInParameter(dbComm, "@Type", DbType.String, objinfo.Type)

                db.AddInParameter(dbComm, "@ShouLiao", DbType.Int32, objinfo.ShouLiao)
                db.AddInParameter(dbComm, "@JiaCun", DbType.Int32, objinfo.JiaCun)
                db.AddInParameter(dbComm, "@QuCun", DbType.Int32, objinfo.QuCun)
                db.AddInParameter(dbComm, "@FaLiao", DbType.Int32, objinfo.FaLiao)
                db.AddInParameter(dbComm, "@CunHuo", DbType.Int32, objinfo.CunHuo)
                db.AddInParameter(dbComm, "@FanXiuIn", DbType.Int32, objinfo.FanXiuIn)
                db.AddInParameter(dbComm, "@FanXiuOut", DbType.Int32, objinfo.FanXiuOut)
                db.AddInParameter(dbComm, "@LiuBan", DbType.Int32, objinfo.LiuBan)
                db.AddInParameter(dbComm, "@SunHuai", DbType.Int32, objinfo.SunHuai)
                db.AddInParameter(dbComm, "@DiuShi", DbType.Int32, objinfo.DiuShi)
                db.AddInParameter(dbComm, "@BuNiang", DbType.Int32, objinfo.BuNiang)
                db.AddInParameter(dbComm, "@CunCang", DbType.Int32, objinfo.CunCang)
                db.AddInParameter(dbComm, "@QuCang", DbType.Int32, objinfo.QuCang)
                db.AddInParameter(dbComm, "@ChuHuo", DbType.Int32, objinfo.ChuHuo)
                db.AddInParameter(dbComm, "@WaiFaIn", DbType.Int32, objinfo.WaiFaIn)
                db.AddInParameter(dbComm, "@WaiFaOut", DbType.Int32, objinfo.WaiFaOut)
                db.AddInParameter(dbComm, "@AccIn", DbType.Int32, objinfo.AccIn)
                db.AddInParameter(dbComm, "@AccOut", DbType.Int32, objinfo.AccOut)
                db.AddInParameter(dbComm, "@RePairOut", DbType.Int32, objinfo.RePairOut)
                db.AddInParameter(dbComm, "@ZuheOut", DbType.Int32, objinfo.ZuheOut)

                db.AddInParameter(dbComm, "@ShouLiao1", DbType.Int32, objinfo.ShouLiao1)
                db.AddInParameter(dbComm, "@JiaCun1", DbType.Int32, objinfo.JiaCun1)
                db.AddInParameter(dbComm, "@QuCun1", DbType.Int32, objinfo.QuCun1)
                db.AddInParameter(dbComm, "@FaLiao1", DbType.Int32, objinfo.FaLiao1)
                db.AddInParameter(dbComm, "@CunHuo1", DbType.Int32, objinfo.CunHuo1)
                db.AddInParameter(dbComm, "@FanXiuIn1", DbType.Int32, objinfo.FanXiuIn1)
                db.AddInParameter(dbComm, "@FanXiuOut1", DbType.Int32, objinfo.FanXiuOut1)
                db.AddInParameter(dbComm, "@LiuBan1", DbType.Int32, objinfo.LiuBan1)
                db.AddInParameter(dbComm, "@SunHuai1", DbType.Int32, objinfo.SunHuai1)
                db.AddInParameter(dbComm, "@DiuShi1", DbType.Int32, objinfo.DiuShi1)
                db.AddInParameter(dbComm, "@BuNiang1", DbType.Int32, objinfo.BuNiang1)
                db.AddInParameter(dbComm, "@CunCang1", DbType.Int32, objinfo.CunCang1)
                db.AddInParameter(dbComm, "@QuCang1", DbType.Int32, objinfo.QuCang1)
                db.AddInParameter(dbComm, "@ChuHuo1", DbType.Int32, objinfo.ChuHuo1)
                db.AddInParameter(dbComm, "@WaiFaIn1", DbType.Int32, objinfo.WaiFaIn1)
                db.AddInParameter(dbComm, "@WaiFaOut1", DbType.Int32, objinfo.WaiFaOut1)
                db.AddInParameter(dbComm, "@AccIn1", DbType.Int32, objinfo.AccIn1)
                db.AddInParameter(dbComm, "@AccOut1", DbType.Int32, objinfo.AccOut1)
                db.AddInParameter(dbComm, "@RePairOut1", DbType.Int32, objinfo.RePairOut1)
                db.AddInParameter(dbComm, "@ZuheOut1", DbType.Int32, objinfo.ZuheOut1)

                db.AddInParameter(dbComm, "@PM_Date", DbType.Date, objinfo.PM_Date)
                db.AddInParameter(dbComm, "@WI_Qty", DbType.Int32, objinfo.WI_Qty)
                db.AddInParameter(dbComm, "@WI_ReQty", DbType.Int32, objinfo.WI_ReQty)
                db.AddInParameter(dbComm, "@WI_Qty1", DbType.Int32, objinfo.WI_Qty1)
                db.AddInParameter(dbComm, "@WI_ReQty1", DbType.Int32, objinfo.WI_ReQty1)

                db.ExecuteNonQuery(dbComm)
                UpdateProductionCheck_Qty = True
            Catch ex As Exception

                MsgBox(ex.Message)
                UpdateProductionCheck_Qty = False
            End Try

        End Function


        Public Function UpdateProductionCheck_Qty1(ByVal objinfo As ProductionAffairInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateProductionCheck_Qty1")

                db.AddInParameter(dbComm, "@FP_NO", DbType.String, objinfo.FP_NO)
                db.AddInParameter(dbComm, "@FP_Type", DbType.String, objinfo.FP_Type)
                db.AddInParameter(dbComm, "@FP_InAction", DbType.String, objinfo.FP_InAction)
                db.AddInParameter(dbComm, "@FP_InCheck", DbType.Boolean, objinfo.FP_InCheck)
                db.AddInParameter(dbComm, "@FP_InCheckDate", DbType.Date, objinfo.FP_InCheckDate)
                db.AddInParameter(dbComm, "@CardID", DbType.String, objinfo.CardID)

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_Type1", DbType.String, objinfo.Pro_Type1)
                db.AddInParameter(dbComm, "@PM_M_Code1", DbType.String, objinfo.PM_M_Code1)
                db.AddInParameter(dbComm, "@PM_Type1", DbType.String, objinfo.PM_Type1)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@Pro_NO1", DbType.String, objinfo.Pro_NO1)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@FP_InDep", DbType.String, objinfo.FP_InDep)
                db.AddInParameter(dbComm, "@FP_Detail", DbType.String, objinfo.FP_Detail)
                db.AddInParameter(dbComm, "@Type", DbType.String, objinfo.Type)

                db.AddInParameter(dbComm, "@ShouLiao", DbType.Int32, objinfo.ShouLiao)
                db.AddInParameter(dbComm, "@JiaCun", DbType.Int32, objinfo.JiaCun)
                db.AddInParameter(dbComm, "@QuCun", DbType.Int32, objinfo.QuCun)
                db.AddInParameter(dbComm, "@FaLiao", DbType.Int32, objinfo.FaLiao)
                db.AddInParameter(dbComm, "@CunHuo", DbType.Int32, objinfo.CunHuo)
                db.AddInParameter(dbComm, "@FanXiuIn", DbType.Int32, objinfo.FanXiuIn)
                db.AddInParameter(dbComm, "@FanXiuOut", DbType.Int32, objinfo.FanXiuOut)
                db.AddInParameter(dbComm, "@LiuBan", DbType.Int32, objinfo.LiuBan)
                db.AddInParameter(dbComm, "@SunHuai", DbType.Int32, objinfo.SunHuai)
                db.AddInParameter(dbComm, "@DiuShi", DbType.Int32, objinfo.DiuShi)
                db.AddInParameter(dbComm, "@BuNiang", DbType.Int32, objinfo.BuNiang)
                db.AddInParameter(dbComm, "@CunCang", DbType.Int32, objinfo.CunCang)
                db.AddInParameter(dbComm, "@QuCang", DbType.Int32, objinfo.QuCang)
                db.AddInParameter(dbComm, "@ChuHuo", DbType.Int32, objinfo.ChuHuo)
                db.AddInParameter(dbComm, "@WaiFaIn", DbType.Int32, objinfo.WaiFaIn)
                db.AddInParameter(dbComm, "@WaiFaOut", DbType.Int32, objinfo.WaiFaOut)
                db.AddInParameter(dbComm, "@AccIn", DbType.Int32, objinfo.AccIn)
                db.AddInParameter(dbComm, "@AccOut", DbType.Int32, objinfo.AccOut)
                db.AddInParameter(dbComm, "@RePairOut", DbType.Int32, objinfo.RePairOut)
                db.AddInParameter(dbComm, "@ZuheOut", DbType.Int32, objinfo.ZuheOut)
                db.AddInParameter(dbComm, "@TuiLiao", DbType.Int32, objinfo.TuiLiao)

                db.AddInParameter(dbComm, "@ShouLiao1", DbType.Int32, objinfo.ShouLiao1)
                db.AddInParameter(dbComm, "@JiaCun1", DbType.Int32, objinfo.JiaCun1)
                db.AddInParameter(dbComm, "@QuCun1", DbType.Int32, objinfo.QuCun1)
                db.AddInParameter(dbComm, "@FaLiao1", DbType.Int32, objinfo.FaLiao1)
                db.AddInParameter(dbComm, "@CunHuo1", DbType.Int32, objinfo.CunHuo1)
                db.AddInParameter(dbComm, "@FanXiuIn1", DbType.Int32, objinfo.FanXiuIn1)
                db.AddInParameter(dbComm, "@FanXiuOut1", DbType.Int32, objinfo.FanXiuOut1)
                db.AddInParameter(dbComm, "@LiuBan1", DbType.Int32, objinfo.LiuBan1)
                db.AddInParameter(dbComm, "@SunHuai1", DbType.Int32, objinfo.SunHuai1)
                db.AddInParameter(dbComm, "@DiuShi1", DbType.Int32, objinfo.DiuShi1)
                db.AddInParameter(dbComm, "@BuNiang1", DbType.Int32, objinfo.BuNiang1)
                db.AddInParameter(dbComm, "@CunCang1", DbType.Int32, objinfo.CunCang1)
                db.AddInParameter(dbComm, "@QuCang1", DbType.Int32, objinfo.QuCang1)
                db.AddInParameter(dbComm, "@ChuHuo1", DbType.Int32, objinfo.ChuHuo1)
                db.AddInParameter(dbComm, "@WaiFaIn1", DbType.Int32, objinfo.WaiFaIn1)
                db.AddInParameter(dbComm, "@WaiFaOut1", DbType.Int32, objinfo.WaiFaOut1)
                db.AddInParameter(dbComm, "@AccIn1", DbType.Int32, objinfo.AccIn1)
                db.AddInParameter(dbComm, "@AccOut1", DbType.Int32, objinfo.AccOut1)
                db.AddInParameter(dbComm, "@RePairOut1", DbType.Int32, objinfo.RePairOut1)
                db.AddInParameter(dbComm, "@ZuheOut1", DbType.Int32, objinfo.ZuheOut1)
                db.AddInParameter(dbComm, "@TuiLiao1", DbType.Int32, objinfo.TuiLiao1)

                db.AddInParameter(dbComm, "@PM_Date", DbType.Date, objinfo.PM_Date)
                db.AddInParameter(dbComm, "@WI_Qty", DbType.Int32, objinfo.WI_Qty)
                db.AddInParameter(dbComm, "@WI_ReQty", DbType.Int32, objinfo.WI_ReQty)
                db.AddInParameter(dbComm, "@WI_Qty1", DbType.Int32, objinfo.WI_Qty1)
                db.AddInParameter(dbComm, "@WI_ReQty1", DbType.Int32, objinfo.WI_ReQty1)

                db.ExecuteNonQuery(dbComm)
                UpdateProductionCheck_Qty1 = True
            Catch ex As Exception

                MsgBox(ex.Message)
                UpdateProductionCheck_Qty1 = False
            End Try

        End Function

    End Class




End Namespace



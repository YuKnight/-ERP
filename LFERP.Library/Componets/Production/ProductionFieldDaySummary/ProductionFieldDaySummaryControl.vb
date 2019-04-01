

Namespace LFERP.Library.Production.ProductionFieldDaySummary

    Public Class ProductionFieldDaySummaryControl

        '記錄當前工序是否存在有數據記錄--沒有則刪除當天此條記錄(有可能是錯誤收發,有可能是收發后取消--刪除后的記錄)
        Public Function ProductionFieldDaySummary_Delete(ByVal objinfo As ProductionFieldDaySummaryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummary_Delete")

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@PM_Date", DbType.String, objinfo.PM_Date)

                db.ExecuteNonQuery(dbComm)
                ProductionFieldDaySummary_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionFieldDaySummary_Delete = False
            End Try

        End Function
        Public Function ProductionFieldDaySummary_GetList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal FP_OutDep As String, ByVal FacName As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String) As List(Of ProductionFieldDaySummaryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummary_GetList")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummary(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionFieldDaySummary_GetList1(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal FP_OutDep As String, ByVal FacName As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String) As List(Of ProductionFieldDaySummaryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummary_GetList1")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummary(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionFieldDaySummary_GetList2(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal FP_OutDep As String, ByVal FacName As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String) As List(Of ProductionFieldDaySummaryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummary_GetList2")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummary(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionFieldDaySummary_ComGetList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String) As List(Of ProductionFieldDaySummaryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummary_ComGetList")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummary(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function ProductionFieldDaySummary_FacGetList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal FacID As String, ByVal FacName As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String) As List(Of ProductionFieldDaySummaryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummary_FacGetList")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummary(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function UpdateProductionDaySummary_Qty(ByVal objinfo As ProductionFieldDaySummaryInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateProductionDaySummary_Qty")

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)

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
                db.AddInParameter(dbComm, "@WaiFaOut", DbType.Int32, objinfo.WaiFaOut)
                db.AddInParameter(dbComm, "@WaiFaIn", DbType.Int32, objinfo.WaiFaIn)
                db.AddInParameter(dbComm, "@AccIn", DbType.Int32, objinfo.AccIn)
                db.AddInParameter(dbComm, "@AccOut", DbType.Int32, objinfo.AccOut)
                db.AddInParameter(dbComm, "@RePairOut", DbType.Int32, objinfo.RePairOut)

                db.AddInParameter(dbComm, "@PM_Date", DbType.Date, objinfo.PM_Date)
                db.AddInParameter(dbComm, "@Type", DbType.String, objinfo.Type)

                db.ExecuteNonQuery(dbComm)
                UpdateProductionDaySummary_Qty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                UpdateProductionDaySummary_Qty = False
            End Try

        End Function

        Public Function UpdateProductionDaySummary_Qty1(ByVal objinfo As ProductionFieldDaySummaryInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateProductionDaySummary_Qty1")

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)

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
                db.AddInParameter(dbComm, "@WaiFaOut", DbType.Int32, objinfo.WaiFaOut)
                db.AddInParameter(dbComm, "@WaiFaIn", DbType.Int32, objinfo.WaiFaIn)
                db.AddInParameter(dbComm, "@AccIn", DbType.Int32, objinfo.AccIn)
                db.AddInParameter(dbComm, "@AccOut", DbType.Int32, objinfo.AccOut)
                db.AddInParameter(dbComm, "@RePairOut", DbType.Int32, objinfo.RePairOut)
                db.AddInParameter(dbComm, "@ZuheOut", DbType.Int32, objinfo.ZuheOut)

                db.AddInParameter(dbComm, "@PM_Date", DbType.Date, objinfo.PM_Date)


                db.ExecuteNonQuery(dbComm)
                UpdateProductionDaySummary_Qty1 = True
            Catch ex As Exception
                MsgBox(ex.Message)
                UpdateProductionDaySummary_Qty1 = False
            End Try

        End Function

        '記錄臨時日期
        Public Function Temp3_Add(ByVal objinfo As ProductionFieldDaySummaryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Temp3_Add")

                db.AddInParameter(dbComm, "@Str1", DbType.Date, objinfo.Str1)
                db.AddInParameter(dbComm, "@Str2", DbType.Date, objinfo.Str2)

                db.ExecuteNonQuery(dbComm)
                Temp3_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Temp3_Add = False
            End Try
        End Function

        Public Function Temp3_GetList(ByVal date1 As String, ByVal date2 As String) As List(Of ProductionFieldDaySummaryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Temp3_GetList")

            db.AddInParameter(dbComm, "@date1", DbType.String, date1)
            db.AddInParameter(dbComm, "@date2", DbType.String, date2)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummary(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionFieldDaySummary(ByVal reader As IDataReader) As ProductionFieldDaySummaryInfo

            On Error Resume Next

            Dim fi As New ProductionFieldDaySummaryInfo

            fi.Pro_Type = reader("Pro_Type").ToString
            fi.PM_M_Code = reader("PM_M_Code").ToString
            fi.PM_Type = reader("PM_Type").ToString
            fi.Pro_NO = reader("Pro_NO").ToString
            fi.FP_OutDep = reader("FP_OutDep").ToString


            If reader("ShouLiao") Is DBNull.Value Then
                fi.ShouLiao = 0
            Else
                fi.ShouLiao = CInt(reader("ShouLiao").ToString)
            End If
            If reader("JiaCun") Is DBNull.Value Then
                fi.JiaCun = 0
            Else
                fi.JiaCun = CInt(reader("JiaCun").ToString)
            End If
            If reader("QuCun") Is DBNull.Value Then
                fi.QuCun = 0
            Else
                fi.QuCun = CInt(reader("QuCun").ToString)
            End If
            If reader("FaLiao") Is DBNull.Value Then
                fi.FaLiao = 0
            Else
                fi.FaLiao = CInt(reader("FaLiao").ToString)
            End If
            If reader("CunHuo") Is DBNull.Value Then
                fi.CunHuo = 0
            Else
                fi.CunHuo = CInt(reader("CunHuo").ToString)
            End If
            If reader("FanXiuIn") Is DBNull.Value Then
                fi.FanXiuIn = 0
            Else
                fi.FanXiuIn = CInt(reader("FanXiuIn").ToString)
            End If
            If reader("FanXiuOut") Is DBNull.Value Then
                fi.FanXiuOut = 0
            Else
                fi.FanXiuOut = CInt(reader("FanXiuOut").ToString)
            End If
            If reader("LiuBan") Is DBNull.Value Then
                fi.LiuBan = 0
            Else
                fi.LiuBan = CInt(reader("LiuBan").ToString)
            End If
            If reader("SunHuai") Is DBNull.Value Then
                fi.SunHuai = 0
            Else
                fi.SunHuai = CInt(reader("SunHuai").ToString)
            End If
            If reader("DiuShi") Is DBNull.Value Then
                fi.DiuShi = 0
            Else
                fi.DiuShi = CInt(reader("DiuShi").ToString)
            End If
            If reader("BuNiang") Is DBNull.Value Then
                fi.BuNiang = 0
            Else
                fi.BuNiang = CInt(reader("BuNiang").ToString)
            End If
            If reader("CunCang") Is DBNull.Value Then
                fi.CunCang = 0
            Else
                fi.CunCang = CInt(reader("CunCang").ToString)
            End If
            If reader("QuCang") Is DBNull.Value Then
                fi.QuCang = 0
            Else
                fi.QuCang = CInt(reader("QuCang").ToString)
            End If

            If reader("ChuHuo") Is DBNull.Value Then
                fi.ChuHuo = 0
            Else
                fi.ChuHuo = CInt(reader("ChuHuo").ToString)
            End If

            If reader("WaiFaOut") Is DBNull.Value Then
                fi.WaiFaOut = 0
            Else
                fi.WaiFaOut = CInt(reader("WaiFaOut").ToString)
            End If

            If reader("WaiFaIn") Is DBNull.Value Then
                fi.WaiFaIn = 0
            Else
                fi.WaiFaIn = CInt(reader("WaiFaIn").ToString)
            End If

            If reader("AccIn") Is DBNull.Value Then
                fi.AccIn = 0
            Else
                fi.AccIn = CInt(reader("AccIn").ToString)
            End If
            If reader("AccOut") Is DBNull.Value Then
                fi.AccOut = 0
            Else
                fi.AccOut = CInt(reader("AccOut").ToString)
            End If

            If reader("PM_Date") Is DBNull.Value Then
                fi.PM_Date = Nothing
            Else
                fi.PM_Date = CStr(reader("PM_Date"))
            End If

            fi.Type = reader("Type").ToString

            fi.FacName = reader("FacName").ToString
            fi.DepName = reader("FacName").ToString & "-" & reader("DepName").ToString
            fi.DepName1 = reader("DepName1").ToString
            fi.PS_Name = reader("PS_Name").ToString
            fi.PS_Num = reader("PS_Num").ToString

            If reader("RemainQty") Is DBNull.Value Then
                fi.RemainQty = 0
            Else
                fi.RemainQty = CInt(reader("RemainQty").ToString)
            End If

            If reader("ReturnQty") Is DBNull.Value Then
                fi.ReturnQty = 0
            Else
                fi.ReturnQty = CInt(reader("ReturnQty").ToString)
            End If

            If reader("DayNumber") Is DBNull.Value Then
                fi.DayNumber = 0
            Else
                fi.DayNumber = CInt(reader("DayNumber").ToString)
            End If

            If reader("ActualNumber") Is DBNull.Value Then
                fi.ActualNumber = 0
            Else
                fi.ActualNumber = CInt(reader("ActualNumber").ToString)
            End If

            If reader("TotalQty") Is DBNull.Value Then
                fi.TotalQty = 0
            Else
                fi.TotalQty = CInt(reader("TotalQty").ToString)
            End If

            If reader("RePairOut") Is DBNull.Value Then  '補返修數量
                fi.RePairOut = 0
            Else
                fi.RePairOut = CInt(reader("RePairOut").ToString)
            End If
            If reader("ZuheOut") Is DBNull.Value Then  '補返修數量
                fi.ZuheOut = 0
            Else
                fi.ZuheOut = CInt(reader("ZuheOut").ToString)
            End If
            '------------------------------------------------------------------------
            fi.Str1 = CStr(reader("Str1").ToString)
            fi.Str2 = CStr(reader("Str2").ToString)
            fi.P_ID = reader("P_ID").ToString

            If reader("WI_Qty") Is DBNull.Value Then  '補返修數量
                fi.WI_Qty = 0
            Else
                fi.WI_Qty = CInt(reader("WI_Qty").ToString)
            End If
            If reader("WI_ReQty") Is DBNull.Value Then  '補返修數量
                fi.WI_ReQty = 0
            Else
                fi.WI_ReQty = CInt(reader("WI_ReQty").ToString)
            End If


            fi.OutINSum = fi.ShouLiao + fi.JiaCun - fi.FaLiao - fi.CunHuo - fi.FanXiuOut - fi.WaiFaOut + fi.WaiFaIn - fi.SunHuai - fi.DiuShi - fi.BuNiang
            fi.OutINSum = fi.OutINSum + fi.FanXiuIn + fi.CunCang + fi.AccIn - fi.AccOut - fi.RePairOut - fi.ZuheOut


            fi.OutUpdate = CInt(reader("OutUpdate").ToString)
            fi.InUpdate = CInt(reader("InUpdate").ToString)


            fi.WaiFaASS = CInt(reader("WaiFaASS").ToString)
            fi.WareFaLiao = CInt(reader("WareFaLiao").ToString)
            fi.ASSBuNiang = CInt(reader("ASSBuNiang").ToString)

            fi.TuiLiao = CInt(reader("TuiLiao").ToString)


            Return fi

        End Function



        Public Function ProductionFieldDaySummary_GetList3(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_NO As String, ByVal FP_OutDep As String, ByVal FacName As String, ByVal PM_Date1 As String, ByVal PM_Date2 As String) As List(Of ProductionFieldDaySummaryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionFieldDaySummary_GetList3")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, FP_OutDep)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@PM_Date1", DbType.String, PM_Date1)
            db.AddInParameter(dbComm, "@PM_Date2", DbType.String, PM_Date2)

            Dim FeatureList As New List(Of ProductionFieldDaySummaryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionFieldDaySummary(reader))
                End While
                Return FeatureList
            End Using
        End Function



        ''------------------------------------------------------------------------

        Public Function UpdateProductionDaySummary_QtyASS(ByVal objinfo As ProductionFieldDaySummaryInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateProductionDaySummary_QtyASS")

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@FP_OutDep", DbType.String, objinfo.FP_OutDep)
                db.AddInParameter(dbComm, "@PM_Date", DbType.Date, objinfo.PM_Date)

                db.AddInParameter(dbComm, "@WaiFaASS", DbType.Int32, objinfo.WaiFaASS)
                db.AddInParameter(dbComm, "@WareFaLiao", DbType.Int32, objinfo.WareFaLiao)
                db.AddInParameter(dbComm, "@ASSBuNiang", DbType.Int32, objinfo.ASSBuNiang)


                db.ExecuteNonQuery(dbComm)
                UpdateProductionDaySummary_QtyASS = True
            Catch ex As Exception
                MsgBox(ex.Message)
                UpdateProductionDaySummary_QtyASS = False
            End Try

        End Function


    End Class

End Namespace




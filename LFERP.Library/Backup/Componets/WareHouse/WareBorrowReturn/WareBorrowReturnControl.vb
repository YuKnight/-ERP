Namespace LFERP.Library.WareHouse.WareBorrowReturn

    Public Class WareBorrowReturnControl

        Public Function WareBorrowReturn_GetNUM(ByVal NDate As String) As WareBorrowReturnInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_GetNUM")

            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillBorrowReturnNO(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function WareBorrowReturn_GetID(ByVal NDate As String) As WareBorrowReturnInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_GetID")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillBorrowReturnNO(reader)
                End While
                Return Nothing
            End Using
        End Function


        Public Function FillBorrowReturnNO(ByVal reader As IDataReader) As WareBorrowReturnInfo
            Dim ci As New WareBorrowReturnInfo
            '流水號
            ci.WB_NUM = reader("WB_NUM").ToString
            ci.WB_NO = reader("WB_NO").ToString
            Return ci

        End Function

        Public Function WareBorrowReturn_Add(ByVal objinfo As WareBorrowReturnInfo) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_Add")

                db.AddInParameter(dbcomm, "@WB_NUM", DbType.String, objinfo.WB_NUM)
                db.AddInParameter(dbcomm, "@WB_NO", DbType.String, objinfo.WB_NO)
                db.AddInParameter(dbcomm, "@WB_Type", DbType.String, objinfo.WB_Type)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@Qty", DbType.Double, objinfo.Qty)

                db.AddInParameter(dbcomm, "@NO_ReQty", DbType.Double, objinfo.NO_ReQty)
                db.AddInParameter(dbcomm, "@DPT_ID", DbType.String, objinfo.DPT_ID)
                db.AddInParameter(dbcomm, "@WB_PerID", DbType.String, objinfo.WB_PerID)
                db.AddInParameter(dbcomm, "@WB_PerName", DbType.String , objinfo.WB_PerName)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, objinfo.WH_ID)

                db.AddInParameter(dbcomm, "@WB_Action", DbType.String, objinfo.WB_Action)
                db.AddInParameter(dbcomm, "@WB_Date", DbType.Date, objinfo.WB_Date)
                db.AddInParameter(dbcomm, "@RR_PerID", DbType.String, objinfo.RR_PerID)
                db.AddInParameter(dbcomm, "@RR_PerName", DbType.String, objinfo.RR_PerName)
                db.AddInParameter(dbcomm, "@Remark", DbType.String, objinfo.Remark)

                db.AddInParameter(dbcomm, "@WB_EndQty", DbType.Double, objinfo.WB_EndQty)


                db.ExecuteNonQuery(dbcomm)
                WareBorrowReturn_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareBorrowReturn_Add = False
            End Try

        End Function

        Public Function WareBorrowReturn_Update(ByVal objinfo As WareBorrowReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.Int32, objinfo.AutoID)

                db.AddInParameter(dbcomm, "@WB_NUM", DbType.String, objinfo.WB_NUM)
                db.AddInParameter(dbcomm, "@WB_NO", DbType.String, objinfo.WB_NO)
                db.AddInParameter(dbcomm, "@WB_Type", DbType.String, objinfo.WB_Type)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@Qty", DbType.Double, objinfo.Qty)

                db.AddInParameter(dbcomm, "@NO_ReQty", DbType.Double, objinfo.NO_ReQty)
                db.AddInParameter(dbcomm, "@DPT_ID", DbType.String, objinfo.DPT_ID)
                db.AddInParameter(dbcomm, "@WB_PerID", DbType.String, objinfo.WB_PerID)
                db.AddInParameter(dbcomm, "@WB_PerName", DbType.String, objinfo.WB_PerName)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, objinfo.WH_ID)

                db.AddInParameter(dbcomm, "@WB_Action", DbType.String, objinfo.WB_Action)
                db.AddInParameter(dbcomm, "@WB_Date", DbType.Date, objinfo.WB_Date)
                db.AddInParameter(dbcomm, "@RR_PerID", DbType.String, objinfo.RR_PerID)
                db.AddInParameter(dbcomm, "@RR_PerName", DbType.String, objinfo.RR_PerName)
                db.AddInParameter(dbcomm, "@Remark", DbType.String, objinfo.Remark)

                db.AddInParameter(dbcomm, "@WB_EndQty", DbType.Double, objinfo.WB_EndQty)

                db.ExecuteNonQuery(dbcomm)
                WareBorrowReturn_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareBorrowReturn_Update = False
            End Try

        End Function


        Public Function WareBorrowReturn_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbcomm)
                WareBorrowReturn_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareBorrowReturn_Delete = False

            End Try
        End Function

        Public Function WareBorrowReturn_GetList(ByVal WB_NUM As String, ByVal WB_NO As String, ByVal WB_Type As String, ByVal M_Code As String, _
        ByVal NO_ReQty As Double, ByVal DPT_ID As String, ByVal WB_PerID As String, ByVal WH_ID As String, ByVal WB_Action As String, ByVal WB_DateS As String, ByVal WB_DateE As String, ByVal RR_PerID As String, ByVal WBR_NO As String) As List(Of WareBorrowReturnInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_GetList")

            db.AddInParameter(dbComm, "@WB_NUM", DbType.String, WB_NUM)
            db.AddInParameter(dbComm, "@WB_NO", DbType.String, WB_NO)
            db.AddInParameter(dbComm, "@WB_Type", DbType.String, WB_Type)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            db.AddInParameter(dbComm, "@NO_ReQty", DbType.Double, NO_ReQty)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WB_PerID", DbType.String, WB_PerID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)

            db.AddInParameter(dbComm, "@WB_Action", DbType.String, WB_Action)
            db.AddInParameter(dbComm, "@WB_DateS", DbType.String, WB_DateS)
            db.AddInParameter(dbComm, "@WB_DateE", DbType.String, WB_DateE)
            db.AddInParameter(dbComm, "@RR_PerID", DbType.String, RR_PerID)

            db.AddInParameter(dbComm, "@WBR_NO", DbType.String, WBR_NO)


            Dim FeatureList As New List(Of WareBorrowReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBorrowReturn(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 停用
        ''' </summary>
        ''' <param name="WB_NUM"></param>
        ''' <param name="WB_NO"></param>
        ''' <param name="WB_Type"></param>
        ''' <param name="WBR_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WareBorrowReturn_GetListBR(ByVal WB_NUM As String, ByVal WB_NO As String, ByVal WB_Type As String, ByVal WBR_NO As String) As List(Of WareBorrowReturnInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_GetListBR")

            db.AddInParameter(dbComm, "@WB_NUM", DbType.String, WB_NUM)
            db.AddInParameter(dbComm, "@WB_NO", DbType.String, WB_NO)
            db.AddInParameter(dbComm, "@WB_Type", DbType.String, WB_Type)
            db.AddInParameter(dbComm, "@WBR_NO", DbType.String, WBR_NO)


            Dim FeatureList As New List(Of WareBorrowReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBorrowReturn(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillBorrowReturn(ByVal reader As IDataReader) As WareBorrowReturnInfo
            On Error Resume Next

            Dim ci As New WareBorrowReturnInfo

            '流水號
            ci.WB_NUM = reader("WB_NUM").ToString
            ci.WB_NO = reader("WB_NO").ToString
            ci.AutoID = reader("AutoID").ToString
            ci.WB_Type = reader("WB_Type").ToString

            ci.M_Code = reader("M_Code").ToString

            If reader("Qty") Is DBNull.Value Then
                ci.Qty = 0
            Else
                ci.Qty = CDbl(reader("Qty").ToString)
            End If

            If reader("NO_ReQty") Is DBNull.Value Then
                ci.NO_ReQty = 0
            Else
                ci.NO_ReQty = CDbl(reader("NO_ReQty").ToString)
            End If

            If reader("WB_EndQty") Is DBNull.Value Then
                ci.WB_EndQty = 0
            Else
                ci.WB_EndQty = CDbl(reader("WB_EndQty").ToString)
            End If

            If reader("DPT_ID") Is DBNull.Value Then
                ci.DPT_ID = Nothing
            Else
                ci.DPT_ID = reader("DPT_ID").ToString
            End If

            '-------------------------------------------------------
            If reader("WB_PerID") Is DBNull.Value Then
                ci.WB_PerID = Nothing
            Else
                ci.WB_PerID = reader("WB_PerID").ToString
            End If

            If reader("WB_PerName") Is DBNull.Value Then
                ci.WB_PerName = Nothing
            Else
                ci.WB_PerName = reader("WB_PerName").ToString
            End If

            If reader("WH_ID") Is DBNull.Value Then
                ci.WH_ID = Nothing
            Else
                ci.WH_ID = reader("WH_ID").ToString
            End If

            If reader("WB_Action") Is DBNull.Value Then
                ci.WB_Action = Nothing
            Else
                ci.WB_Action = reader("WB_Action").ToString
            End If

            If reader("WB_Date") Is DBNull.Value Then
                ci.WB_Date = Nothing
            Else
                ci.WB_Date = CStr(reader("WB_Date").ToString)
            End If

            If reader("RR_PerID") Is DBNull.Value Then
                ci.RR_PerID = Nothing
            Else
                ci.RR_PerID = reader("RR_PerID").ToString
            End If
            '-------------------------------------------------------

            If reader("RR_PerName") Is DBNull.Value Then
                ci.RR_PerName = Nothing
            Else
                ci.RR_PerName = reader("RR_PerName").ToString
            End If

            If reader("Remark") Is DBNull.Value Then
                ci.Remark = Nothing
            Else
                ci.Remark = reader("Remark").ToString
            End If

            If reader("M_Name") Is DBNull.Value Then
                ci.M_Name = Nothing
            Else
                ci.M_Name = reader("M_Name").ToString
            End If

            If reader("M_Gauge") Is DBNull.Value Then
                ci.M_Gauge = Nothing
            Else
                ci.M_Gauge = reader("M_Gauge").ToString
            End If
            '-------------------------------------------------------
            If reader("M_Unit") Is DBNull.Value Then
                ci.M_Unit = Nothing
            Else
                ci.M_Unit = reader("M_Unit").ToString
            End If

            If reader("WB_ActionName") Is DBNull.Value Then
                ci.WB_ActionName = Nothing
            Else
                ci.WB_ActionName = reader("WB_ActionName").ToString
            End If

            If reader("WH_Name") Is DBNull.Value Then
                ci.WH_Name = Nothing
            Else
                ci.WH_Name = reader("WH_Name").ToString
            End If

            If reader("WH_PName") Is DBNull.Value Then
                ci.WH_PName = Nothing
            Else
                ci.WH_PName = reader("WH_PName").ToString
            End If

            If reader("DPT_Name") Is DBNull.Value Then
                ci.DPT_Name = Nothing
            Else
                ci.DPT_Name = reader("DPT_Name").ToString
            End If
            '
            If reader("WBR_NO") Is DBNull.Value Then
                ci.WBR_NO = Nothing
            Else
                ci.WBR_NO = reader("WBR_NO").ToString
            End If

            If reader("DPT_PName") Is DBNull.Value Then
                ci.DPT_PName = Nothing
            Else
                ci.DPT_PName = reader("DPT_PName").ToString
            End If

            ''
            If reader("WBR_QtyStr") Is DBNull.Value Then
                ci.WBR_QtyStr = Nothing
            Else
                ci.WBR_QtyStr = reader("WBR_QtyStr").ToString
            End If

            ci.QtyReal = 0 '默認為0，需要此結構
            ci.RemarkReal = Nothing

            ci.WR_NUM = reader("WR_NUM").ToString


            If reader("DelayDate") Is DBNull.Value Then
                ci.DelayDate = Nothing
            Else
                ci.DelayDate = CStr(reader("DelayDate").ToString)
            End If

            If reader("DelayAction") Is DBNull.Value Then
                ci.DelayAction = Nothing
            Else
                ci.DelayAction = reader("DelayAction").ToString
            End If

            If reader("DelayRemark") Is DBNull.Value Then
                ci.DelayRemark = Nothing
            Else
                ci.DelayRemark = reader("DelayRemark").ToString
            End If

            If reader("DelayActionName") Is DBNull.Value Then
                ci.DelayActionName = Nothing
            Else
                ci.DelayActionName = reader("DelayActionName").ToString
            End If

            Return ci

        End Function

        Public Function WareBorrowReturn_Sum(ByVal WB_Type As String, ByVal M_Code As String, ByVal WB_PerID As String, ByVal WB_NO As String) As List(Of WareBorrowReturnInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_Sum")

            db.AddInParameter(dbComm, "@WB_Type", DbType.String, WB_Type)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WB_PerID", DbType.String, WB_PerID)
            db.AddInParameter(dbComm, "@WB_NO", DbType.String, WB_NO)

            Dim FeatureList As New List(Of WareBorrowReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBorrowReturnSum(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillBorrowReturnSum(ByVal reader As IDataReader) As WareBorrowReturnInfo
            Dim ci As New WareBorrowReturnInfo

            On Error Resume Next

            If reader("SumQty") Is DBNull.Value Then
                ci.M_Code = Nothing
            Else
                ci.M_Code = reader("M_Code").ToString
            End If


            If reader("SumQty") Is DBNull.Value Then
                ci.SumQty = 0
            Else
                ci.SumQty = CDbl(reader("SumQty").ToString)
            End If

            If reader("SumNO_ReQty") Is DBNull.Value Then
                ci.SumNO_ReQty = 0
            Else
                ci.SumNO_ReQty = CDbl(reader("SumNO_ReQty").ToString)
            End If


            If reader("M_Name") Is DBNull.Value Then
                ci.M_Name = Nothing
            Else
                ci.M_Name = reader("M_Name").ToString
            End If

            If reader("M_Gauge") Is DBNull.Value Then
                ci.M_Gauge = Nothing
            Else
                ci.M_Gauge = reader("M_Gauge").ToString
            End If

            If reader("M_Unit") Is DBNull.Value Then
                ci.M_Unit = Nothing
            Else
                ci.M_Unit = reader("M_Unit").ToString
            End If


            Return ci

        End Function



        Public Function WareBorrowReturn_UpdateNO_ReQty(ByVal objinfo As WareBorrowReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_UpdateNO_ReQty")

                db.AddInParameter(dbcomm, "@WB_NUM", DbType.String, objinfo.WB_NUM)
                db.AddInParameter(dbcomm, "@NO_ReQty", DbType.Double, objinfo.NO_ReQty)
                db.AddInParameter(dbcomm, "@WBR_NO", DbType.String, objinfo.WBR_NO)
                db.AddInParameter(dbcomm, "@WBR_QtyStr", DbType.String, objinfo.WBR_QtyStr)

                db.ExecuteNonQuery(dbcomm)
                WareBorrowReturn_UpdateNO_ReQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareBorrowReturn_UpdateNO_ReQty = False
            End Try

        End Function

        Public Function WareBorrowReturn_UpdateDelay(ByVal objinfo As WareBorrowReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareBorrowReturn_UpdateDelay")

                db.AddInParameter(dbcomm, "@WB_NUM", DbType.String, objinfo.WB_NUM)
                db.AddInParameter(dbcomm, "@DelayDate", DbType.Date, objinfo.DelayDate)
                db.AddInParameter(dbcomm, "@DelayRemark", DbType.String, objinfo.DelayRemark)
                db.AddInParameter(dbcomm, "@DelayAction", DbType.String, objinfo.DelayAction)

                db.ExecuteNonQuery(dbcomm)
                WareBorrowReturn_UpdateDelay = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareBorrowReturn_UpdateDelay = False
            End Try

        End Function

        Public Function WareBorrowReturnSub_Add(ByVal objinfo As WareBorrowReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WareBorrowReturnSub_Add")

                db.AddInParameter(dbcomm, "@WB_NUM", DbType.String, objinfo.WB_NUM)
                db.AddInParameter(dbcomm, "@WR_NUM", DbType.String, objinfo.WR_NUM)
                db.AddInParameter(dbcomm, "@Qty", DbType.Double, objinfo.Qty)

                db.ExecuteNonQuery(dbcomm)
                WareBorrowReturnSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareBorrowReturnSub_Add = False
            End Try
        End Function



        Public Function WareBorrowReturnSub_GetList(ByVal WB_NUM As String, ByVal WR_NUM As String, ByVal Modle As String) As List(Of WareBorrowReturnInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowReturnSub_GetList")

            db.AddInParameter(dbComm, "@WB_NUM", DbType.String, WB_NUM)
            db.AddInParameter(dbComm, "@WR_NUM", DbType.String, WR_NUM)
            db.AddInParameter(dbComm, "@Modle", DbType.String, Modle)
            
            Dim FeatureList As New List(Of WareBorrowReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBorrowReturn(reader))
                End While
                Return FeatureList
            End Using

        End Function



        ''[WareBorrowReturnNOReturn_GetList]

        Public Function WareBorrowReturnNOReturn_GetList(ByVal DelayDate As String, ByVal DPT_ID As String) As List(Of WareBorrowReturnInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowReturnNOReturn_GetList")

            db.AddInParameter(dbComm, "@DelayDate", DbType.String, DelayDate)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)

            Dim FeatureList As New List(Of WareBorrowReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBorrowReturn(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function WareBorrowReturnNOReturn_GetList1(ByVal DelayDate As String, ByVal DPT_ID As String, ByVal WB_PerID As String) As List(Of WareBorrowReturnInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareBorrowReturnNOReturn_GetList1")

            db.AddInParameter(dbComm, "@DelayDate", DbType.String, DelayDate)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WB_PerID", DbType.String, WB_PerID)

            Dim FeatureList As New List(Of WareBorrowReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBorrowReturn(reader))
                End While
                Return FeatureList
            End Using

        End Function


    End Class

End Namespace

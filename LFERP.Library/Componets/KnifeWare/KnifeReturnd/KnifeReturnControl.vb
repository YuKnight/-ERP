Imports System.Data.Common
Namespace LFERP.Library.KnifeWare
    Public Class KnifeReturnControl
        Public Function KnifeReturn_GetNUM(ByVal NDate As String) As KnifeReturnInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeReturn_GetNUM")

            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillKnifeReturn_GetNUMID(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function KnifeReturn_GetID(ByVal NDate As String) As KnifeReturnInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeReturn_GetID")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillKnifeReturn_GetNUMID(reader)
                End While
                Return Nothing
            End Using
        End Function


        Public Function FillKnifeReturn_GetNUMID(ByVal reader As IDataReader) As KnifeReturnInfo
            Dim ci As New KnifeReturnInfo
            '流水號
            ci.R_NUM = reader("R_NUM").ToString
            ci.R_NO = reader("R_NO").ToString
            Return ci

        End Function

        Public Function KnifeReturn_Add(ByVal obj As KnifeReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeReturn_Add")

                db.AddInParameter(dbcomm, "@R_NUM", DbType.String, obj.R_NUM)
                db.AddInParameter(dbcomm, "@R_NO", DbType.String, obj.R_NO)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code)
                db.AddInParameter(dbcomm, "@R_Qty", DbType.Double, obj.R_Qty)
                db.AddInParameter(dbcomm, "@RPer_ID", DbType.String, obj.RPer_ID)

                db.AddInParameter(dbcomm, "@RPer_Name", DbType.String, obj.RPer_Name)
                db.AddInParameter(dbcomm, "@RRPer_ID", DbType.String, obj.RRPer_ID)
                db.AddInParameter(dbcomm, "@RRPer_Name", DbType.String, obj.RRPer_Name)
                db.AddInParameter(dbcomm, "@R_Type", DbType.String, obj.R_Type)
                db.AddInParameter(dbcomm, "@R_Date", DbType.Date, obj.R_Date)

                db.AddInParameter(dbcomm, "@RR_Mark", DbType.String, obj.RR_Mark)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID)
                db.AddInParameter(dbcomm, "@R_Action", DbType.String, obj.R_Action)
                db.AddInParameter(dbcomm, "@R_EndQty", DbType.String, obj.R_EndQty)
                db.AddInParameter(dbcomm, "@R_AllEndQty", DbType.String, obj.R_AllEndQty)

                db.ExecuteNonQuery(dbcomm)
                KnifeReturn_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeReturn_Add = False
            End Try
        End Function

        Public Function KnifeReturn_Update(ByVal obj As KnifeReturnInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeReturn_Update")

                db.AddInParameter(dbcomm, "@R_NUM", DbType.String, obj.R_NUM)
                db.AddInParameter(dbcomm, "@R_NO", DbType.String, obj.R_NO)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code)
                db.AddInParameter(dbcomm, "@R_Qty", DbType.Double, obj.R_Qty)
                db.AddInParameter(dbcomm, "@RPer_ID", DbType.String, obj.RPer_ID)

                db.AddInParameter(dbcomm, "@RPer_Name", DbType.String, obj.RPer_Name)
                db.AddInParameter(dbcomm, "@RRPer_ID", DbType.String, obj.RRPer_ID)
                db.AddInParameter(dbcomm, "@RRPer_Name", DbType.String, obj.RRPer_Name)
                db.AddInParameter(dbcomm, "@R_Type", DbType.String, obj.R_Type)
                db.AddInParameter(dbcomm, "@R_Date", DbType.String, obj.R_Date)

                db.AddInParameter(dbcomm, "@RR_Mark", DbType.String, obj.RR_Mark)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID)
                db.AddInParameter(dbcomm, "@R_Action", DbType.String, obj.R_Action)

                db.AddInParameter(dbcomm, "@R_EndQty", DbType.String, obj.R_EndQty)
                db.AddInParameter(dbcomm, "@R_AllEndQty", DbType.String, obj.R_AllEndQty)

                db.ExecuteNonQuery(dbcomm)
                KnifeReturn_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeReturn_Update = False
            End Try
        End Function

        Public Function KnifeReturn_GetList(ByVal R_Num As String, ByVal R_NO As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal RPer_ID As String, ByVal R_DateStart As String, _
                                            ByVal R_DateEnd As String, ByVal R_Type As String, ByVal Type3ID As String, ByVal M_Name As String) As List(Of KnifeReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeReturn_GetList")

            db.AddInParameter(dbcomm, "@R_Num", DbType.String, R_Num)
            db.AddInParameter(dbcomm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@RPer_ID", DbType.String, RPer_ID)

            db.AddInParameter(dbcomm, "@R_DateStart", DbType.String, R_DateStart)
            db.AddInParameter(dbcomm, "@R_DateEnd", DbType.String, R_DateEnd)
            db.AddInParameter(dbcomm, "@R_Type", DbType.String, R_Type)
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbcomm, "@M_Name", DbType.String, M_Name)



            Dim FeatureList As New List(Of KnifeReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 2014-05-28
        ''' 姚      駿
        ''' 刀具歸還記錄
        ''' </summary>
        ''' <param name="R_Num"></param>
        ''' <param name="R_NO"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="RPer_ID"></param>
        ''' <param name="R_DateStart"></param>
        ''' <param name="R_DateEnd"></param>
        ''' <param name="R_Type"></param>
        ''' <param name="Type3ID"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="FacName"></param>
        ''' <param name="DepName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeReturn_GetListOne(ByVal R_Num As String, ByVal R_NO As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal RPer_ID As String, ByVal R_DateStart As String, _
                                         ByVal R_DateEnd As String, ByVal R_Type As String, ByVal Type3ID As String, ByVal M_Name As String, ByVal FacName As String, ByVal DepName As String) As List(Of KnifeReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeReturn_GetListOne")

            db.AddInParameter(dbcomm, "@R_Num", DbType.String, R_Num)
            db.AddInParameter(dbcomm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@RPer_ID", DbType.String, RPer_ID)

            db.AddInParameter(dbcomm, "@R_DateStart", DbType.String, R_DateStart)
            db.AddInParameter(dbcomm, "@R_DateEnd", DbType.String, R_DateEnd)
            db.AddInParameter(dbcomm, "@R_Type", DbType.String, R_Type)
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbcomm, "@M_Name", DbType.String, M_Name)

            db.AddInParameter(dbcomm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbcomm, "@DepName", DbType.String, DepName)

            Dim FeatureList As New List(Of KnifeReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 還回未還刀分組數量
        ''' </summary>
        ''' <param name="BPer_ID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="B_Type"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeBorrow_NOReturnGroupGetList(ByVal BPer_ID As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal B_Type As String, ByVal Type3ID As String) As List(Of KnifeReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_NOReturnGroupGetList")

            db.AddInParameter(dbcomm, "@BPer_ID", DbType.String, BPer_ID)
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@B_Type", DbType.String, B_Type)
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of KnifeReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function KnifeBorrow_NOReturnGetList(ByVal BPer_ID As String, ByVal M_Code As String, ByVal WH_ID As String) As List(Of KnifeReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_NOReturnGetList")

            db.AddInParameter(dbcomm, "@BPer_ID", DbType.String, BPer_ID)
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)

            Dim FeatureList As New List(Of KnifeReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 統計出所有已還刀數量 
        ''' </summary>
        ''' <param name="rPer_ID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="B_Type"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeReturn_ALLSum(ByVal RPer_ID As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal B_Type As String) As List(Of KnifeReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeReturn_ALLSum")

            db.AddInParameter(dbcomm, "@RPer_ID", DbType.String, RPer_ID)
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@B_Type", DbType.String, B_Type)

            Dim FeatureList As New List(Of KnifeReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''

        Public Function FillKnifeReturn(ByVal reader As IDataReader) As KnifeReturnInfo
            Dim ci As New KnifeReturnInfo
            '流水號
            On Error Resume Next
            ci.AutoID = reader("R_NUM").ToString

            ci.R_NUM = reader("R_NUM").ToString
            ci.R_NO = reader("R_NO").ToString
            ci.M_Code = reader("M_Code").ToString
            ci.R_Qty = reader("R_Qty")
            ci.RPer_ID = reader("RPer_ID").ToString

            ci.RPer_Name = reader("RPer_Name").ToString
            ci.RRPer_ID = reader("RRPer_ID").ToString
            ci.RRPer_Name = reader("RRPer_Name").ToString
            ci.R_Type = reader("R_Type").ToString
            ci.R_Date = reader("R_Date").ToString

            ci.RR_Mark = reader("RR_Mark").ToString
            ci.WH_ID = reader("WH_ID").ToString
            ci.R_Action = reader("R_Action").ToString

            ci.M_Name = reader("M_Name").ToString
            ci.R_ActionName = reader("R_ActionName").ToString
            ci.R_Action = reader("R_Action").ToString
            ci.WH_Name = reader("WH_Name").ToString
            ci.WH_PName = reader("WH_PName").ToString

            ''----------------------------
            ci.SumB_QTY = reader("SumB_QTY")
            ci.SumR_QTY = reader("SumR_QTY")
            ci.SumNOReturn = reader("SumNOReturn")
            ci.SumCountR_Qty = reader("SumCountR_Qty")
            ci.M_Gauge = reader("M_Gauge").ToString
            ci.R_Check = reader("R_Check")

            ci.R_EndQty = reader("R_EndQty")
            ci.R_AllEndQty = reader("R_AllEndQty")
            ci.M_Unit = reader("M_Unit").ToString

            '2014-05-05-28 姚駿
            ci.FacName = reader("FacName").ToString
            ci.DepName = reader("DepName").ToString
            Return ci

        End Function

        ''' <summary>
        ''' 刪除數據
        ''' </summary>
        ''' <param name="B_Num"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeReturn_Delete(ByVal B_Num As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeReturn_Delete")
                db.AddInParameter(dbcomm, "@B_Num", DbType.String, B_Num)
                db.ExecuteNonQuery(dbcomm)
                KnifeReturn_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeReturn_Delete = False
            End Try
        End Function

        ''' <summary>
        ''' 更新狀態
        ''' </summary>
        ''' <param name="R_Num"></param>
        ''' <param name="R_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeReturnDedu_Update(ByVal R_Num As String, ByVal R_Check As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeReturnDedu_Update")
                db.AddInParameter(dbcomm, "@R_Num", DbType.String, R_Num)
                db.AddInParameter(dbcomm, "@R_Check", DbType.Boolean, R_Check)
                db.ExecuteNonQuery(dbcomm)
                KnifeReturnDedu_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeReturnDedu_Update = False
            End Try
        End Function

        Public Function KnifeReturn_GetListTop100(ByVal R_Num As String, ByVal R_NO As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal RPer_ID As String, ByVal R_DateStart As String, _
                                    ByVal R_DateEnd As String, ByVal R_Type As String, ByVal Type3ID As String, ByVal M_Name As String) As List(Of KnifeReturnInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeReturn_GetListTop100")

            db.AddInParameter(dbcomm, "@R_Num", DbType.String, R_Num)
            db.AddInParameter(dbcomm, "@R_NO", DbType.String, R_NO)
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@RPer_ID", DbType.String, RPer_ID)

            db.AddInParameter(dbcomm, "@R_DateStart", DbType.String, R_DateStart)
            db.AddInParameter(dbcomm, "@R_DateEnd", DbType.String, R_DateEnd)
            db.AddInParameter(dbcomm, "@R_Type", DbType.String, R_Type)
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID)
            db.AddInParameter(dbcomm, "@M_Name", DbType.String, M_Name)



            Dim FeatureList As New List(Of KnifeReturnInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeReturn(reader))
                End While
                Return FeatureList
            End Using
        End Function

    End Class


End Namespace
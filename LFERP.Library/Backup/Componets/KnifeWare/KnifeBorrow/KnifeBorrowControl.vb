Imports System.Data.Common
Namespace LFERP.Library.KnifeWare
    Public Class KnifeBorrowControl

        Public Function KnifeBorrow_GetNUM(ByVal NDate As String) As KnifeBorrowInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_GetNUM")

            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillKnifeBorrowID(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function KnifeBorrow_GetID(ByVal NDate As String) As KnifeBorrowInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_GetID")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillKnifeBorrowID(reader)
                End While
                Return Nothing
            End Using
        End Function


        Public Function FillKnifeBorrowID(ByVal reader As IDataReader) As KnifeBorrowInfo
            Dim ci As New KnifeBorrowInfo
            '流水號
            ci.B_Num = reader("B_NUM").ToString
            ci.B_NO = reader("B_NO").ToString
            Return ci

        End Function
        'KnifeBorrow_UpdateRQty]
        Public Function KnifeBorrow_UpdateRQty(ByVal obj As KnifeBorrowInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_UpdateRQty")

                db.AddInParameter(dbcomm, "@B_Num", DbType.String, obj.B_Num)
                db.AddInParameter(dbcomm, "@R_Qty", DbType.Double, obj.R_Qty)
                db.AddInParameter(dbcomm, "@R_Date", DbType.String, obj.R_Date)
                db.AddInParameter(dbcomm, "@NOReturn", DbType.Double, obj.NOReturn)

                db.ExecuteNonQuery(dbcomm)
                KnifeBorrow_UpdateRQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeBorrow_UpdateRQty = False
            End Try
        End Function
        ''' <summary>
        ''' 更改單中 更改借刀,還刀,未歸還數
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeBorrow_UpdateChangeBRQty(ByVal obj As KnifeBorrowInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_UpdateChangeBRQty")

                db.AddInParameter(dbcomm, "@B_Num", DbType.String, obj.B_Num)
                db.AddInParameter(dbcomm, "@R_Qty", DbType.Double, obj.R_Qty)
                db.AddInParameter(dbcomm, "@B_Qty", DbType.Double, obj.B_Qty)
                db.AddInParameter(dbcomm, "@NOReturn", DbType.Double, obj.NOReturn)

                db.ExecuteNonQuery(dbcomm)
                KnifeBorrow_UpdateChangeBRQty = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeBorrow_UpdateChangeBRQty = False
            End Try
        End Function
        Public Function KnifeBorrow_Add(ByVal obj As KnifeBorrowInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_Add")

                db.AddInParameter(dbcomm, "@B_Num", DbType.String, obj.B_Num) '借刀流水號
                db.AddInParameter(dbcomm, "@B_NO", DbType.String, obj.B_NO) '借刀單號
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code) '刀具編碼
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID) '倉庫代號
                db.AddInParameter(dbcomm, "@BPer_ID", DbType.String, obj.BPer_ID) '借刀人

                db.AddInParameter(dbcomm, "@BPer_Name", DbType.String, obj.BPer_Name) '借刀姓名
                db.AddInParameter(dbcomm, "@B_Qty", DbType.Double, obj.B_Qty) '借刀數
                db.AddInParameter(dbcomm, "@R_Qty", DbType.Double, obj.R_Qty) '還刀數
                db.AddInParameter(dbcomm, "@B_Date", DbType.String, obj.B_Date) '借刀日期
                db.AddInParameter(dbcomm, "@R_Date", DbType.String, obj.R_Date) '還刀日期

                db.AddInParameter(dbcomm, "@B_Action", DbType.String, obj.B_Action) '操作員
                db.AddInParameter(dbcomm, "@B_Remark", DbType.String, obj.B_Remark) '備注
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) '組別編號
                db.AddInParameter(dbcomm, "@B_Type", DbType.String, obj.B_Type) '發刀屬性
                db.AddInParameter(dbcomm, "@B_EndQty", DbType.Double, obj.B_EndQty)

                db.AddInParameter(dbcomm, "@NOReturn", DbType.Double, obj.NOReturn)
                db.AddInParameter(dbcomm, "@B_AllEndQty", DbType.Double, obj.B_AllEndQty)

                db.ExecuteNonQuery(dbcomm)
                KnifeBorrow_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeBorrow_Add = False
            End Try
        End Function


        Public Function KnifeBorrow_GetList(ByVal B_Num As String, ByVal B_NO As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal BPer_ID As String, ByVal B_DateStart As String, ByVal B_DateEnd As String, ByVal G_NO As String, ByVal B_Type As String, ByVal Type3ID As String, ByVal Type As String, ByVal M_Name As String) As List(Of KnifeBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_GetList")

            db.AddInParameter(dbcomm, "@B_Num", DbType.String, B_Num) '借刀流水號
            db.AddInParameter(dbcomm, "@B_NO", DbType.String, B_NO) '借刀單號
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code) '刀具編碼
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID) '倉庫代號
            db.AddInParameter(dbcomm, "@BPer_ID", DbType.String, BPer_ID) '借刀人

            db.AddInParameter(dbcomm, "@B_DateStart", DbType.String, B_DateStart) '借刀日期
            db.AddInParameter(dbcomm, "@B_DateEnd", DbType.String, B_DateEnd) '借刀日期
            db.AddInParameter(dbcomm, "@G_NO", DbType.String, G_NO) '組別編號
            db.AddInParameter(dbcomm, "@B_Type", DbType.String, B_Type) '發刀屬性
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID) '刀具類別編碼
            db.AddInParameter(dbcomm, "@Type", DbType.String, Type) '發刀屬性
            db.AddInParameter(dbcomm, "@M_Name", DbType.String, M_Name)

            Dim FeatureList As New List(Of KnifeBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 2014-06-09
        ''' 姚     駿
        ''' 借刀列表
        ''' </summary>
        ''' <param name="B_Num"></param>
        ''' <param name="B_NO"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="BPer_ID"></param>
        ''' <param name="B_DateStart"></param>
        ''' <param name="B_DateEnd"></param>
        ''' <param name="G_NO"></param>
        ''' <param name="B_Type"></param>
        ''' <param name="Type3ID"></param>
        ''' <param name="Type"></param>
        ''' <param name="M_Name"></param>
        ''' <param name="FacName"></param>
        ''' <param name="DepName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeBorrow_GetListOne(ByVal B_Num As String, ByVal B_NO As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal BPer_ID As String, ByVal B_DateStart As String, ByVal B_DateEnd As String, ByVal G_NO As String, ByVal B_Type As String, ByVal Type3ID As String, ByVal Type As String, ByVal M_Name As String, ByVal FacName As String, ByVal DepName As String) As List(Of KnifeBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_GetListOne")

            db.AddInParameter(dbcomm, "@B_Num", DbType.String, B_Num) '借刀流水號
            db.AddInParameter(dbcomm, "@B_NO", DbType.String, B_NO) '借刀單號
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code) '刀具編碼
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID) '倉庫代號
            db.AddInParameter(dbcomm, "@BPer_ID", DbType.String, BPer_ID) '借刀人

            db.AddInParameter(dbcomm, "@B_DateStart", DbType.String, B_DateStart) '借刀日期
            db.AddInParameter(dbcomm, "@B_DateEnd", DbType.String, B_DateEnd) '借刀日期
            db.AddInParameter(dbcomm, "@G_NO", DbType.String, G_NO) '組別編號
            db.AddInParameter(dbcomm, "@B_Type", DbType.String, B_Type) '發刀屬性
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID) '刀具類別編碼
            db.AddInParameter(dbcomm, "@Type", DbType.String, Type) '發刀屬性
            db.AddInParameter(dbcomm, "@M_Name", DbType.String, M_Name)

            db.AddInParameter(dbcomm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbcomm, "@DepName", DbType.String, DepName)

            Dim FeatureList As New List(Of KnifeBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 查詢出未還數量
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="BPer_ID"></param>
        ''' <param name="Type"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeBorrowDedu_GetList(ByVal M_Code As String, ByVal WH_ID As String, ByVal BPer_ID As String, ByVal Type As String) As List(Of KnifeBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrowDedu_GetList")

            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@BPer_ID", DbType.String, BPer_ID)
            db.AddInParameter(dbcomm, "@Type", DbType.String, Type)

            Dim FeatureList As New List(Of KnifeBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function


        ''' <summary>
        ''' 得到出庫總數
        ''' </summary>
        ''' <param name="WH_ID"></param>
        ''' <param name="Type3ID"></param>
        ''' <param name="B_DateStart"></param>
        ''' <param name="B_DateEnd"></param>
        ''' <param name="B_Type"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeBorrowSumB_Qty_GetList(ByVal WH_ID As String, ByVal Type3ID As String, ByVal B_DateStart As String, ByVal B_DateEnd As String, ByVal B_Type As String) As List(Of KnifeBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrowSumB_Qty_GetList")

            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID) '
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID) '
            db.AddInParameter(dbcomm, "@B_DateStart", DbType.String, B_DateStart) '
            db.AddInParameter(dbcomm, "@B_DateEnd", DbType.String, B_DateEnd) '
            db.AddInParameter(dbcomm, "@B_Type", DbType.String, B_Type) '


            Dim FeatureList As New List(Of KnifeBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function KnifeBorrow_Update(ByVal obj As KnifeBorrowInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, obj.AutoID) '自動編號ID
                db.AddInParameter(dbcomm, "@B_Num", DbType.String, obj.B_Num) '借刀流水號
                db.AddInParameter(dbcomm, "@B_NO", DbType.String, obj.B_NO) '借刀單號
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, obj.M_Code) '刀具編碼
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID) '倉庫代號

                db.AddInParameter(dbcomm, "@BPer_ID", DbType.String, obj.BPer_ID) '借刀人
                db.AddInParameter(dbcomm, "@BPer_Name", DbType.String, obj.BPer_Name) '借刀姓名
                db.AddInParameter(dbcomm, "@B_Qty", DbType.Double, obj.B_Qty) '借刀數
                db.AddInParameter(dbcomm, "@R_Qty", DbType.Double, obj.R_Qty) '還刀數
                db.AddInParameter(dbcomm, "@B_Date", DbType.String, obj.B_Date) '借刀日期

                db.AddInParameter(dbcomm, "@R_Date", DbType.String, obj.R_Date) '還刀日期
                db.AddInParameter(dbcomm, "@B_Action", DbType.String, obj.B_Action) '操作員
                db.AddInParameter(dbcomm, "@B_Remark", DbType.String, obj.B_Remark) '備注
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) '組別編號
                db.AddInParameter(dbcomm, "@B_Type", DbType.String, obj.B_Type) '發刀屬性

                db.AddInParameter(dbcomm, "@B_EndQty", DbType.Double, obj.B_EndQty)
                db.AddInParameter(dbcomm, "@NOReturn", DbType.Double, obj.NOReturn)
                db.AddInParameter(dbcomm, "@B_AllEndQty", DbType.Double, obj.B_AllEndQty)

                db.ExecuteNonQuery(dbcomm)
                KnifeBorrow_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeBorrow_Update = False
            End Try
        End Function

        Public Function FillKnifeBorrow(ByVal reader As IDataReader) As KnifeBorrowInfo
            Dim ai As New KnifeBorrowInfo

            On Error Resume Next

            If reader("AutoID") Is DBNull.Value Then
                ai.AutoID = Nothing
            Else
                ai.AutoID = reader("AutoID").ToString     '自動編號ID
            End If

            If reader("B_Num") Is DBNull.Value Then
                ai.B_Num = Nothing
            Else
                ai.B_Num = reader("B_Num").ToString     '借刀流水號
            End If

            If reader("B_NO") Is DBNull.Value Then
                ai.B_NO = Nothing
            Else
                ai.B_NO = reader("B_NO").ToString     '借刀單號
            End If

            If reader("M_Code") Is DBNull.Value Then
                ai.M_Code = Nothing
            Else
                ai.M_Code = reader("M_Code").ToString     '刀具編碼
            End If

            If reader("WH_ID") Is DBNull.Value Then
                ai.WH_ID = Nothing
            Else
                ai.WH_ID = reader("WH_ID").ToString     '倉庫代號
            End If

            If reader("BPer_ID") Is DBNull.Value Then
                ai.BPer_ID = Nothing
            Else
                ai.BPer_ID = reader("BPer_ID").ToString     '借刀人
            End If

            If reader("BPer_Name") Is DBNull.Value Then
                ai.BPer_Name = Nothing
            Else
                ai.BPer_Name = reader("BPer_Name").ToString     '借刀姓名
            End If

            If reader("B_Qty") Is DBNull.Value Then
                ai.B_Qty = 0
            Else
                ai.B_Qty = reader("B_Qty")     '借刀數
            End If

            If reader("R_Qty") Is DBNull.Value Then
                ai.R_Qty = 0
            Else
                ai.R_Qty = reader("R_Qty")     '還刀數
            End If

            If reader("B_Date") Is DBNull.Value Then
                ai.B_Date = Nothing
            Else
                ai.B_Date = reader("B_Date").ToString    '借刀日期
            End If

            If reader("R_Date") Is DBNull.Value Then
                ai.R_Date = Nothing
            Else
                ai.R_Date = reader("R_Date").ToString     '還刀日期
            End If

            If reader("B_Action") Is DBNull.Value Then
                ai.B_Action = Nothing
            Else
                ai.B_Action = reader("B_Action").ToString     '操作員
            End If

            If reader("B_Remark") Is DBNull.Value Then
                ai.B_Remark = Nothing
            Else
                ai.B_Remark = reader("B_Remark").ToString     '備注
            End If

            If reader("G_NO") Is DBNull.Value Then
                ai.G_NO = Nothing
            Else
                ai.G_NO = reader("G_NO").ToString     '組別編號
            End If

            If reader("B_Type") Is DBNull.Value Then
                ai.B_Type = Nothing
            Else
                ai.B_Type = reader("B_Type").ToString     '發刀屬性
            End If

            If reader("M_Name") Is DBNull.Value Then
                ai.M_Name = Nothing
            Else
                ai.M_Name = reader("M_Name").ToString     '刀具名稱---------------
            End If

            If reader("WH_Name") Is DBNull.Value Then
                ai.WH_Name = Nothing
            Else
                ai.WH_Name = reader("WH_Name").ToString     '倉庫名稱
            End If

            If reader("WH_PName") Is DBNull.Value Then
                ai.WH_PName = Nothing
            Else
                ai.WH_PName = reader("WH_PName").ToString     '父倉庫名稱
            End If

            If reader("B_ActionName") Is DBNull.Value Then
                ai.B_ActionName = Nothing
            Else
                ai.B_ActionName = reader("B_ActionName").ToString     '操作員名稱
            End If

            If reader("G_Name") Is DBNull.Value Then
                ai.G_Name = Nothing
            Else
                ai.G_Name = reader("G_Name").ToString     '組別名稱
            End If

            ai.M_Gauge = reader("M_Gauge").ToString
            ai.NOReturn = reader("NOReturn").ToString
            ai.B_AllEndQty = reader("B_AllEndQty")


            ai.Type3ID = reader("Type3ID").ToString
            ai.Type3Name = reader("Type3Name").ToString

            ai.M_Unit = reader("M_Unit").ToString

            '2014-05-05-28 姚駿
            ai.FacName = reader("FacName").ToString
            ai.DepName = reader("DepName").ToString

            Return ai
        End Function


        Public Function KnifeBorrow_Delete(ByVal B_Num As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_Delete")
                db.AddInParameter(dbcomm, "@B_Num", DbType.String, B_Num)
                db.ExecuteNonQuery(dbcomm)
                KnifeBorrow_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeBorrow_Delete = False
            End Try
        End Function



        ''' <summary>
        ''' 根據組號查詢借刀清單
        ''' </summary>
        ''' <param name="B_Num"></param>
        ''' <param name="B_NO"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="BPer_ID"></param>
        ''' <param name="B_DateStart"></param>
        ''' <param name="B_DateEnd"></param>
        ''' <param name="G_NO"></param>
        ''' <param name="B_Type"></param>
        ''' <param name="Type3ID"></param>
        ''' <param name="Type"></param>
        ''' <param name="M_Name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeBorrow_GetListByGNO(ByVal B_Num As String, ByVal B_NO As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal BPer_ID As String, ByVal B_DateStart As String, ByVal B_DateEnd As String, ByVal G_NO As String, ByVal B_Type As String, ByVal Type3ID As String, ByVal Type As String, ByVal M_Name As String) As List(Of KnifeBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrow_GetListByGNO")

            db.AddInParameter(dbcomm, "@B_Num", DbType.String, B_Num) '借刀流水號
            db.AddInParameter(dbcomm, "@B_NO", DbType.String, B_NO) '借刀單號
            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code) '刀具編碼
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID) '倉庫代號
            db.AddInParameter(dbcomm, "@BPer_ID", DbType.String, BPer_ID) '借刀人

            db.AddInParameter(dbcomm, "@B_DateStart", DbType.String, B_DateStart) '借刀日期
            db.AddInParameter(dbcomm, "@B_DateEnd", DbType.String, B_DateEnd) '借刀日期
            db.AddInParameter(dbcomm, "@G_NO", DbType.String, G_NO) '組別編號
            db.AddInParameter(dbcomm, "@B_Type", DbType.String, B_Type) '發刀屬性
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID) '刀具類別編碼
            db.AddInParameter(dbcomm, "@Type", DbType.String, Type) '發刀屬性
            db.AddInParameter(dbcomm, "@M_Name", DbType.String, M_Name)

            Dim FeatureList As New List(Of KnifeBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

    End Class
End Namespace

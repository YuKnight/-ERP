Imports System.Data.Common
Namespace LFERP.Library.ProductionSumTimePersonnel
    Public Class ProductionSumTimePersonnelControl
        ''' <summary>
        ''' 查詢員工計時統計
        ''' </summary>
        ''' <param name="PT_NO"></param>
        ''' <param name="Per_NO"></param>
        ''' <param name="G_NO"></param>
        ''' <param name="DepID"></param>
        ''' <param name="FacID"></param>
        ''' <param name=" PT_DateStart"></param>
        ''' <param name="PT_Action"></param>
        ''' <param name=" PT_DateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionSumTimePersonnel_GetList(ByVal PT_NO As String, ByVal Per_NO As String, ByVal G_NO As String, ByVal DepID As String, ByVal FacID As String, ByVal PT_DateStart As String, _
                                                    ByVal PT_Action As String, ByVal PT_DateEnd As String, ByVal Model As String, ByVal Print_Action As String, ByVal PP_NO As String) As List(Of ProductionSumTimePersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumTimePersonnel_GetList") ' PT_DateEnd   PT_DateStart Print_Action

            db.AddInParameter(dbComm, "@PT_NO", DbType.String, PT_NO) ' 
            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO) '
            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO) '
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID) '-- /部門編號

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID) '-- /廠別
            db.AddInParameter(dbComm, "@PT_DateStart", DbType.String, PT_DateStart) '--/建立日期
            db.AddInParameter(dbComm, "@PT_Action", DbType.String, PT_Action) ' --/操作人
            db.AddInParameter(dbComm, "@PT_DateEnd", DbType.String, PT_DateEnd) '  --> < =
            db.AddInParameter(dbComm, "@Model", DbType.String, Model)
            db.AddInParameter(dbComm, "@PP_NO", DbType.String, PP_NO)


            Dim FeatureList As New List(Of ProductionSumTimePersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSumTimePersonnel(reader, PT_DateStart, PT_DateEnd, Print_Action))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 獲取組別計時統計時指定記錄
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionSumTimePersonnel(ByVal reader As IDataReader, ByVal FPT_DateStart As String, ByVal FPT_DateEnd As String, ByVal FPrint_Action As String) As ProductionSumTimePersonnelInfo
            Dim ai As New ProductionSumTimePersonnelInfo
            On Error Resume Next

            ''只用在打印時
            ai.PT_DateStart = FPT_DateStart
            ai.PT_DateEnd = FPT_DateEnd
            ai.Print_Action = FPrint_Action



            If reader("PT_NO") Is DBNull.Value Then
                ai.PT_NO = Nothing
            Else
                ai.PT_NO = reader("PT_NO").ToString  '      PT_NO             *  nvarchar(50)                /計時單號
            End If

            If reader("Per_NO") Is DBNull.Value Then
                ai.Per_NO = Nothing
            Else
                ai.Per_NO = reader("Per_NO").ToString  '              *  nvarchar(50)                  /員工工號
            End If

            If reader("G_NO") Is DBNull.Value Then
                ai.G_NO = Nothing
            Else
                ai.G_NO = reader("G_NO").ToString  ''G_NO                *  nvarchar(50)                  /組別編號
            End If

            If reader("DepID") Is DBNull.Value Then
                ai.DepID = Nothing
            Else
                ai.DepID = reader("DepID").ToString  ' 'DPT_ID              *  nvarchar(50)                  /部門編號
            End If

            If reader("FacID") Is DBNull.Value Then
                ai.FacID = Nothing
            Else
                ai.FacID = reader("FacID").ToString  ''DPT_PID             *  nvarchar(50)                  /廠別
            End If

            ''---------------------------------------------------------------------

            If reader("PT_BeginTime") Is DBNull.Value Then
                ai.PT_BeginTime = Nothing
            Else
                ai.PT_BeginTime = reader("PT_BeginTime").ToString  '  GT_BeginTime      *  nvarchar(50)                /計時開始時間
            End If

            If reader("PT_EndTime") Is DBNull.Value Then
                ai.PT_EndTime = Nothing
            Else
                ai.PT_EndTime = reader("PT_EndTime").ToString  ' 'GT_EndTime        *  nvarchar(50)                /計時結束時間
            End If

            If reader("PT_Total") Is DBNull.Value Then
                ai.PT_Total = Nothing
            Else
                ai.PT_Total = reader("PT_Total").ToString  ''GT_Total          *  float                       /總計時間    
            End If

            If reader("PT_Date") Is DBNull.Value Then
                ai.PT_Date = Nothing
            Else
                ai.PT_Date = CStr(reader("PT_Date"))  'GT_Date           *  datetime                    /建立日期
            End If

            If reader("PT_Action") Is DBNull.Value Then
                ai.PT_Action = Nothing
            Else
                ai.PT_Action = CStr(reader("PT_Action"))  'GT_Action         *  nvarchar(50)                /操作人
            End If

            If reader("PT_Remark") Is DBNull.Value Then
                ai.PT_Remark = Nothing
            Else
                ai.PT_Remark = CStr(reader("PT_Remark"))   'GT_Remark         *  nvarchar(MAX)               /備注
            End If

            ''外表字段
            If reader("PT_ActionName") Is DBNull.Value Then 'GT_ActionName(操作員名)
                ai.PT_ActionName = Nothing
            Else
                ai.PT_ActionName = reader("PT_ActionName")
            End If

            If reader("PT_Per_Name") Is DBNull.Value Then 'GT_Per_Name(員工名姓名(ProductionPiecePersonnel))
                ai.PT_Per_Name = Nothing
            Else
                ai.PT_Per_Name = reader("PT_Per_Name").ToString
            End If

            If reader("PT_DepName") Is DBNull.Value Then 'GT_DepName(部門名)
                ai.PT_DepName = Nothing
            Else
                ai.PT_DepName = reader("PT_DepName").ToString
            End If

            If reader("PT_FacName") Is DBNull.Value Then        'GT_FacName(廠別名)
                ai.PT_FacName = Nothing
            Else
                ai.PT_FacName = reader("PT_FacName").ToString
            End If

            If reader("PT_G_Name") Is DBNull.Value Then        'GT_G_Name(組別名(ProductionPieceWorkGroup))
                ai.PT_G_Name = Nothing
            Else
                ai.PT_G_Name = reader("PT_G_Name")
            End If

            '-----------------------------------------------------------------------------------------

            If reader("SampID") Is DBNull.Value Then
                ai.SampID = Nothing
            Else
                ai.SampID = reader("SampID").ToString
            End If

            If reader("SampPrice") Is DBNull.Value Then
                ai.SampPrice = 0
            Else
                ai.SampPrice = reader("SampPrice")
            End If

            If reader("SampName") Is DBNull.Value Then
                ai.SampName = Nothing
            Else
                ai.SampName = reader("SampName").ToString
            End If


            Return ai

        End Function

        ''' <summary>
        ''' 增加組別計時統計時記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumTimePersonnel_Add(ByVal obj As ProductionSumTimePersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimePersonnel_Add")

                db.AddInParameter(dbcomm, "@PT_NO", DbType.String, obj.PT_NO) '--/計時單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工編號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別
                db.AddInParameter(dbcomm, "@PT_BeginTime", DbType.String, obj.PT_BeginTime)  '/計時開始時間
                db.AddInParameter(dbcomm, "@PT_EndTime", DbType.String, obj.PT_EndTime) ' - /計時結束時間
                db.AddInParameter(dbcomm, "@PT_Total", DbType.Double, obj.PT_Total) ' -- /總計時間    

                db.AddInParameter(dbcomm, "@PT_Date", DbType.String, obj.PT_Date) '  -- /統計日期
                db.AddInParameter(dbcomm, "@PT_Action", DbType.String, obj.PT_Action) '--/操作人
                db.AddInParameter(dbcomm, "@PT_Remark", DbType.String, obj.PT_Remark) '--/備注


                db.AddInParameter(dbcomm, "@PP_NO", DbType.String, obj.PP_NO) '--/備注


                db.AddInParameter(dbcomm, "@SampID", DbType.String, obj.SampID)
                db.AddInParameter(dbcomm, "@SampPrice", DbType.Double, obj.SampPrice)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimePersonnel_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimePersonnel_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 更新個人計時統計時記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumTimePersonnel_Update(ByVal obj As ProductionSumTimePersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimePersonnel_Update")

                db.AddInParameter(dbcomm, "@PT_NO", DbType.String, obj.PT_NO) '--/計時單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工編號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別
                db.AddInParameter(dbcomm, "@PT_BeginTime", DbType.String, obj.PT_BeginTime)  '/計時開始時間
                db.AddInParameter(dbcomm, "@PT_EndTime", DbType.String, obj.PT_EndTime) ' - /計時結束時間
                db.AddInParameter(dbcomm, "@PT_Total", DbType.Double, obj.PT_Total) ' -- /總計時間    

                db.AddInParameter(dbcomm, "@PT_Date", DbType.String, obj.PT_Date) '  -- /統計日期
                db.AddInParameter(dbcomm, "@PT_Action", DbType.String, obj.PT_Action) '--/操作人
                db.AddInParameter(dbcomm, "@pT_Remark", DbType.String, obj.PT_Remark) '--/備注

                db.AddInParameter(dbcomm, "@SampID", DbType.String, obj.SampID)
                db.AddInParameter(dbcomm, "@SampPrice", DbType.Double, obj.SampPrice)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimePersonnel_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimePersonnel_Update = False
            End Try
        End Function

        ''' <summary>
        ''' 刪除個人計時統計時記錄
        ''' </summary>
        ''' <param name="PT_NO "></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionSumTimePersonnel_Delete(ByVal PT_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimePersonnel_Delete")

                db.AddInParameter(dbcomm, "@PT_NO", DbType.String, PT_NO)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimePersonnel_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimePersonnel_Delete = False
            End Try
        End Function


        ''' <summary>
        ''' 獲取驗收單號 FillProductionSumTimePersonnel1 一起單獨使有
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionSumTimePersonnel_GetNO(ByVal Ndate As String) As ProductionSumTimePersonnelInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumTimePersonnel_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionSumTimePersonnel1(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 返回TOP1組別單號(因要載入的數據不多單獨定一函數)以提高速度
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionSumTimePersonnel1(ByVal reader As IDataReader) As ProductionSumTimePersonnelInfo
            Dim ai1 As New ProductionSumTimePersonnelInfo
            If reader("PT_NO") Is DBNull.Value Then ai1.PT_NO = Nothing Else ai1.PT_NO = reader("PT_NO").ToString '
            Return ai1

        End Function
        ''--------------------------------------------------------------------------------

        ''' <summary>
        ''' 打印時無數據時，調用此函數
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NothingNew() As List(Of ProductionSumTimePersonnelInfo)
            Dim pi As New ProductionSumTimePersonnelInfo
            Dim FeatureList As New List(Of ProductionSumTimePersonnelInfo)
            FeatureList.Add(NothingFillProductionSumTimePersonnel())
            Return FeatureList
        End Function

        Public Function NothingFillProductionSumTimePersonnel() As ProductionSumTimePersonnelInfo
            Dim ai1 As New ProductionSumTimePersonnelInfo
            ai1.PT_NO = Nothing
            ai1.Per_NO = Nothing
            ai1.G_NO = Nothing
            ai1.DepID = Nothing
            ai1.FacID = Nothing

            ai1.PT_BeginTime = Nothing
            ai1.PT_EndTime = Nothing
            ai1.PT_Total = 0
            ai1.PT_Date = Nothing
            ai1.PT_Action = Nothing

            ai1.PT_Remark = Nothing

            '外表字段
            ai1.PT_ActionName = Nothing
            ai1.PT_Per_Name = Nothing
            ai1.PT_DepName = Nothing
            ai1.PT_FacName = Nothing
            ai1.PT_G_Name = Nothing

            ai1.PT_DateEnd = Nothing
            ai1.PT_DateStart = Nothing
            ai1.Print_Action = Nothing
            Return ai1

        End Function


        ''---2013-5-15更新做辦計時----------------------------------------------

        Public Function ProductionSumTimePersonnelSamp_Update(ByVal PT_NO As String, ByVal SampID As String, ByVal SampPrice As Double) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimePersonnelSamp_Update")

                db.AddInParameter(dbcomm, "@PT_NO", DbType.String, PT_NO)
                db.AddInParameter(dbcomm, "@SampID", DbType.String, SampID)
                db.AddInParameter(dbcomm, "@SampPrice", DbType.Double, SampPrice)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimePersonnelSamp_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimePersonnelSamp_Update = False
            End Try
        End Function


    End Class
End Namespace
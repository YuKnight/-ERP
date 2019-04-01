Imports System.Data.Common

Namespace LFERP.Library.ProductionSumTimeWorkGroup


    Public Class ProductionSumTimeWorkGroupControl

        ''' <summary>
        ''' 查詢組別計時統計
        ''' </summary>
        ''' <param name="GT_NO"></param>
        ''' <param name="Per_NO"></param>
        ''' <param name="G_NO"></param>
        ''' <param name="DepID"></param>
        ''' <param name="FacID"></param>
        ''' <param name="GT_DateStart "></param>
        ''' <param name="GT_Action"></param>
        ''' <param name="GT_DateEnd "></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionSumTimeWorkGroup_GetList(ByVal GT_NO As String, ByVal Per_NO As String, ByVal G_NO As String, ByVal DepID As String, ByVal FacID As String, ByVal GT_DateStart As String, _
                                                    ByVal GT_Action As String, ByVal GT_DateEnd As String, ByVal Model As String, ByVal Print_Action As String) As List(Of ProductionSumTimeWorkGroupInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeWorkGroup_GetList")

            db.AddInParameter(dbComm, "@GT_NO", DbType.String, GT_NO) ' 
            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO) '
            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO) '
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID) '-- /部門編號

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID) '-- /廠別
            db.AddInParameter(dbComm, "@GT_Datestart", DbType.String, GT_DateStart) '--/建立日期
            db.AddInParameter(dbComm, "@GT_Action", DbType.String, GT_Action) ' --/操作人
            db.AddInParameter(dbComm, "@GT_DateEnd", DbType.String, GT_DateEnd) '  --> < = 
            db.AddInParameter(dbComm, "@Model", DbType.String, Model)

            Dim FeatureList As New List(Of ProductionSumTimeWorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSumTimeWorkGroup(reader, GT_DateStart, GT_DateEnd, Print_Action))
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
        Public Function FillProductionSumTimeWorkGroup(ByVal reader As IDataReader, ByVal FGT_Datestart As String, ByVal FGT_DateEnd As String, ByVal FPrint_Action As String) As ProductionSumTimeWorkGroupInfo

            On Error Resume Next

            Dim ai As New ProductionSumTimeWorkGroupInfo

            ''只用在打印時
            ai.GT_DateStart = FGT_Datestart
            ai.GT_DateEnd = FGT_DateEnd
            ai.Print_Action = FPrint_Action


            If reader("GT_NO") Is DBNull.Value Then
                ai.GT_NO = Nothing
            Else
                ai.GT_NO = reader("GT_NO").ToString  '      GT_NO             *  nvarchar(50)                /計時單號
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

            If reader("GT_BeginTime") Is DBNull.Value Then
                ai.GT_BeginTime = Nothing
            Else
                ai.GT_BeginTime = reader("GT_BeginTime").ToString  '  GT_BeginTime      *  nvarchar(50)                /計時開始時間
            End If

            If reader("GT_EndTime") Is DBNull.Value Then
                ai.GT_EndTime = Nothing
            Else
                ai.GT_EndTime = reader("GT_EndTime").ToString  ' 'GT_EndTime        *  nvarchar(50)                /計時結束時間
            End If

            If reader("GT_Total") Is DBNull.Value Then
                ai.GT_Total = Nothing
            Else
                ai.GT_Total = reader("GT_Total").ToString  ''GT_Total          *  float                       /總計時間    
            End If

            If reader("GT_Date") Is DBNull.Value Then
                ai.GT_Date = Nothing
            Else
                ai.GT_Date = CStr(reader("GT_Date"))  'GT_Date           *  datetime                    /建立日期
            End If

            If reader("GT_Action") Is DBNull.Value Then
                ai.GT_Action = Nothing
            Else
                ai.GT_Action = CStr(reader("GT_Action"))  'GT_Action         *  nvarchar(50)                /操作人
            End If

            If reader("GT_Remark") Is DBNull.Value Then
                ai.GT_Remark = Nothing
            Else
                ai.GT_Remark = CStr(reader("GT_Remark"))   'GT_Remark         *  nvarchar(MAX)               /備注
            End If

            ''外表字段
            If reader("GT_ActionName") Is DBNull.Value Then 'GT_ActionName(操作員名)
                ai.GT_ActionName = Nothing
            Else
                ai.GT_ActionName = reader("GT_ActionName")
            End If

            If reader("GT_Per_Name") Is DBNull.Value Then 'GT_Per_Name(員工名姓名(ProductionPiecePersonnel))
                ai.GT_Per_Name = Nothing
            Else
                ai.GT_Per_Name = reader("GT_Per_Name").ToString
            End If

            If reader("GT_DepName") Is DBNull.Value Then 'GT_DepName(部門名)
                ai.GT_DepName = Nothing
            Else
                ai.GT_DepName = reader("GT_DepName").ToString
            End If

            If reader("GT_FacName") Is DBNull.Value Then        'GT_FacName(廠別名)
                ai.GT_FacName = Nothing
            Else
                ai.GT_FacName = reader("GT_FacName")
            End If

            If reader("GT_G_Name") Is DBNull.Value Then        'GT_G_Name(組別名(ProductionPieceWorkGroup))
                ai.GT_G_Name = Nothing
            Else
                ai.GT_G_Name = reader("GT_G_Name")
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
        Public Function ProductionSumTimeWorkGroup_Add(ByVal obj As ProductionSumTimeWorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeWorkGroup_Add")

                db.AddInParameter(dbcomm, "@GT_NO", DbType.String, obj.GT_NO) '--/計時單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工編號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別
                db.AddInParameter(dbcomm, "@GT_BeginTime", DbType.String, obj.GT_BeginTime)  '/計時開始時間
                db.AddInParameter(dbcomm, "@GT_EndTime", DbType.String, obj.GT_EndTime) ' - /計時結束時間
                db.AddInParameter(dbcomm, "@GT_Total", DbType.Double, obj.GT_Total) ' -- /總計時間    

                db.AddInParameter(dbcomm, "@GT_Date", DbType.String, obj.GT_Date) '  -- /統計日期
                db.AddInParameter(dbcomm, "@GT_Action", DbType.String, obj.GT_Action) '--/操作人
                db.AddInParameter(dbcomm, "@GT_Remark", DbType.String, obj.GT_Remark) '--/備注

                db.AddInParameter(dbcomm, "@SampID", DbType.String, obj.SampID)
                db.AddInParameter(dbcomm, "@SampPrice", DbType.Double, obj.SampPrice)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimeWorkGroup_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimeWorkGroup_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 更新組別計時統計時記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumTimeWorkGroup_Update(ByVal obj As ProductionSumTimeWorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeWorkGroup_Update")

                db.AddInParameter(dbcomm, "@GT_NO", DbType.String, obj.GT_NO) '--/計時單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工編號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別
                db.AddInParameter(dbcomm, "@GT_BeginTime", DbType.String, obj.GT_BeginTime)  '/計時開始時間
                db.AddInParameter(dbcomm, "@GT_EndTime", DbType.String, obj.GT_EndTime) ' - /計時結束時間
                db.AddInParameter(dbcomm, "@GT_Total", DbType.Double, obj.GT_Total) ' -- /總計時間    

                db.AddInParameter(dbcomm, "@GT_Date", DbType.String, obj.GT_Date) '  -- /統計日期
                db.AddInParameter(dbcomm, "@GT_Action", DbType.String, obj.GT_Action) '--/操作人
                db.AddInParameter(dbcomm, "@GT_Remark", DbType.String, obj.GT_Remark) '--/備注

                db.AddInParameter(dbcomm, "@SampID", DbType.String, obj.SampID)
                db.AddInParameter(dbcomm, "@SampPrice", DbType.Double, obj.SampPrice)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimeWorkGroup_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimeWorkGroup_Update = False
            End Try
        End Function

        ''' <summary>
        ''' 刪除組別計時統計時記錄
        ''' </summary>
        ''' <param name="GT_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionSumTimeWorkGroup_Delete(ByVal GT_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeWorkGroup_Delete")

                db.AddInParameter(dbcomm, "@GT_NO", DbType.String, GT_NO)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimeWorkGroup_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimeWorkGroup_Delete = False
            End Try
        End Function


        ''' <summary>
        ''' 獲取驗收單號 FillProductionSumTimeWorkGroup1 一起單獨使有
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionSumTimeWorkGroup_GetNO(ByVal Ndate As String) As ProductionSumTimeWorkGroupInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeWorkGroup_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionSumTimeWorkGroup1(reader)
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
        Public Function FillProductionSumTimeWorkGroup1(ByVal reader As IDataReader) As ProductionSumTimeWorkGroupInfo
            Dim ai1 As New ProductionSumTimeWorkGroupInfo
            If reader("GT_NO") Is DBNull.Value Then ai1.GT_NO = Nothing Else ai1.GT_NO = reader("GT_NO").ToString '
            Return ai1

        End Function


        ''------------------
        ''' <summary>
        ''' 打印時無數據時，調用此函數
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NothingNew() As List(Of ProductionSumTimeWorkGroupInfo)
            Dim pi As New ProductionSumTimeWorkGroupInfo
            Dim FeatureList As New List(Of ProductionSumTimeWorkGroupInfo)
            FeatureList.Add(NothingFillProductionSumTimeWorkGroup())
            Return FeatureList
        End Function

        Public Function NothingFillProductionSumTimeWorkGroup() As ProductionSumTimeWorkGroupInfo
            Dim ai1 As New ProductionSumTimeWorkGroupInfo
            ai1.GT_NO = Nothing '             *  nvarchar(50)                /計時單號
            ai1.Per_NO = Nothing '            *  nvarchar(50)                /員工編號
            ai1.G_NO = Nothing '              *  nvarchar(50)                /組別編號
            ai1.DepID = Nothing '             *  nvarchar(50)                /部門編號
            ai1.FacID = Nothing '             *  nvarchar(50)                /廠別

            ai1.GT_BeginTime = Nothing '       *  nvarchar(50)                /計時開始時間
            ai1.GT_EndTime = Nothing '         *  nvarchar(50)                /計時結束時間
            ai1.GT_Total = 0 '         *  float                       /總計時間    
            ai1.GT_Date = Nothing '           *  datetime                    /建立日期
            ai1.GT_Action = Nothing '        *  nvarchar(50)                /操作人

            ai1.GT_Remark = Nothing '         *  nvarchar(MAX)               /備注

            '外表字段
            ai1.GT_ActionName = Nothing '  操作員名 
            ai1.GT_Per_Name = Nothing '    員工名姓名(ProductionPiecePersonnel)
            ai1.GT_DepName = Nothing '     部門名
            ai1.GT_FacName = Nothing '     廠別名
            ai1.GT_G_Name = Nothing '      組別名(ProductionPieceWorkGroup)

            ai1.GT_DateStart = Nothing  ''打印用
            ai1.GT_DateEnd = Nothing
            ai1.Print_Action = Nothing
            Return ai1

        End Function


        ''---2013-5-15更新做辦計時----------------------------------------------

        Public Function ProductionSumTimeWorkGroupSamp_Update(ByVal GT_NO As String, ByVal SampID As String, ByVal SampPrice As Double) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumTimeWorkGroupSamp_Update")

                db.AddInParameter(dbcomm, "@GT_NO", DbType.String, GT_NO)
                db.AddInParameter(dbcomm, "@SampID", DbType.String, SampID)
                db.AddInParameter(dbcomm, "@SampPrice", DbType.Double, SampPrice)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumTimeWorkGroupSamp_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumTimeWorkGroupSamp_Update = False
            End Try
        End Function


    End Class

End Namespace
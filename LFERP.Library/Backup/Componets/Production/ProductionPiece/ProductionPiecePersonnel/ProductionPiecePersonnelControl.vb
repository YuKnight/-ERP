Imports System.Data.Common

Namespace LFERP.Library.ProductionPiecePersonnel

    Public Class ProductionPiecePersonnelControl
        ''' <summary>
        ''' 讀取記錄
        ''' </summary>
        ''' <param name="Per_NO"></param>
        ''' <param name="G_NO"></param>
        ''' <param name="DepID"></param>
        ''' <param name="FacID"></param>
        ''' <param name="Per_PayType"></param>
        ''' <param name=" Per_DateStart  "></param>
        ''' <param name="Per_Action"></param>
        ''' <param name="Per_Resign"></param>
        ''' <param name=" Per_DateEnd "></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionPiecePersonnel_GetList(ByVal AutoID As String, ByVal Per_NO As String, ByVal Per_Name As String, ByVal G_NO As String, ByVal DepID As String, ByVal FacID As String, ByVal Per_PayType As String, _
                                                    ByVal Per_DateStart As String, ByVal Per_Action As String, ByVal Per_Resign As String, ByVal Per_DateEnd As String, ByVal Per_Class As String) As List(Of ProductionPiecePersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnel_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.Int32, AutoID) ' 

            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO) ' --/員工工號
            db.AddInParameter(dbComm, "@Per_Name", DbType.String, Per_Name) ' --/員工名稱
            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO) '-- /組別編號
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID) '-- /部門編號

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID) '-- /廠別
            db.AddInParameter(dbComm, "@Per_PayType", DbType.String, Per_PayType) '--/薪金類型
            db.AddInParameter(dbComm, "@Per_DateStart", DbType.String, Per_DateStart) '--/建立日期

            db.AddInParameter(dbComm, "@Per_Action", DbType.String, Per_Action) ' --/操作人
            db.AddInParameter(dbComm, "@Per_Resign", DbType.String, Per_Resign) '-/是否已辭工
            db.AddInParameter(dbComm, "@Per_DateEnd", DbType.String, Per_DateEnd) '  --> < =
            db.AddInParameter(dbComm, "@Per_Class", DbType.String, Per_Class) ' 班制

            Dim FeatureList As New List(Of ProductionPiecePersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPiecePersonnel(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function ProductionPiecePersonnel_GetList2(ByVal AutoID As String, ByVal Per_NO As String, ByVal Per_Name As String, ByVal G_NO As String, ByVal DepID As String, ByVal FacID As String, ByVal Per_PayType As String, _
                                                    ByVal Per_DateStart As String, ByVal Per_Action As String, ByVal Per_Resign As String, ByVal Per_DateEnd As String, ByVal Per_Class As String,KQClass as String ) As List(Of ProductionPiecePersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnel_GetList2")

            db.AddInParameter(dbComm, "@AutoID", DbType.Int32, AutoID) ' 

            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO) ' --/員工工號
            db.AddInParameter(dbComm, "@Per_Name", DbType.String, Per_Name) ' --/員工名稱
            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO) '-- /組別編號
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID) '-- /部門編號

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID) '-- /廠別
            db.AddInParameter(dbComm, "@Per_PayType", DbType.String, Per_PayType) '--/薪金類型
            db.AddInParameter(dbComm, "@Per_DateStart", DbType.String, Per_DateStart) '--/建立日期

            db.AddInParameter(dbComm, "@Per_Action", DbType.String, Per_Action) ' --/操作人
            db.AddInParameter(dbComm, "@Per_Resign", DbType.String, Per_Resign) '-/是否已辭工
            db.AddInParameter(dbComm, "@Per_DateEnd", DbType.String, Per_DateEnd) '  --> < =
            db.AddInParameter(dbComm, "@Per_Class", DbType.String, Per_Class) ' 班制

            db.AddInParameter(dbComm, "@KQClass", DbType.String, KQClass)



            Dim FeatureList As New List(Of ProductionPiecePersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPiecePersonnel(reader))
                End While
                Return FeatureList
            End Using

        End Function



        ''' <summary>
        ''' 載入數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPiecePersonnel(ByVal reader As IDataReader) As ProductionPiecePersonnelInfo

            On Error Resume Next
            Dim ai As New ProductionPiecePersonnelInfo

            ai.AutoID = reader("AutoID").ToString

            If reader("Per_NO") Is DBNull.Value Then
                ai.Per_NO = Nothing
            Else
                ai.Per_NO = reader("Per_NO").ToString  '              *  nvarchar(50)                  /員工工號
            End If

            If reader("Per_Name") Is DBNull.Value Then
                ai.Per_Name = Nothing
            Else
                ai.Per_Name = reader("Per_Name").ToString  '  'Per_Name            *  nvarchar(50)                  /員工名稱
            End If

            ai.Per_NOName = ai.Per_NO + Space(2) + ai.Per_Name

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

            If reader("Per_PayType") Is DBNull.Value Then
                ai.Per_PayType = Nothing
            Else
                ai.Per_PayType = reader("Per_PayType").ToString  'Per_PayType         *  nvarchar(50)                  /薪金類型
            End If

            If reader("Per_Date") Is DBNull.Value Then
                ai.Per_Date = Nothing
            Else
                ai.Per_Date = reader("Per_Date")  ' 'Per_Date            *  datetime                      /建立日期
            End If

            If reader("Per_Action") Is DBNull.Value Then
                ai.Per_Action = Nothing
            Else
                ai.Per_Action = reader("Per_Action").ToString  'Per_Action          *  nvarchar(50)                  /操作人
            End If

            If reader("Per_Remark") Is DBNull.Value Then
                ai.Per_Remark = Nothing
            Else
                ai.Per_Remark = reader("Per_Remark").ToString  ''Per_Remark          *  nvarchar(MAX)                 /備注
            End If

            If reader("Per_Resign") Is DBNull.Value Then
                ai.Per_Resign = Nothing
            Else
                ai.Per_Resign = reader("Per_Resign") 'Per_Resign          *  bit                           /是否已辭工
            End If

            'Per_ActionName(人員基本信息人名)
            If reader("Per_ActionName") Is DBNull.Value Then
                ai.Per_ActionName = Nothing
            Else
                ai.Per_ActionName = reader("Per_ActionName")
            End If

            'Per_G_Name(組別名稱) '
            If reader("Per_G_Name") Is DBNull.Value Then
                ai.Per_G_Name = Nothing
            Else
                ai.Per_G_Name = reader("Per_G_Name")
            End If

            'Per_DepName(部門名稱)
            If reader("Per_DepName") Is DBNull.Value Then
                ai.Per_DepName = Nothing
            Else
                ai.Per_DepName = reader("Per_DepName").ToString
            End If

            'Per_FacName(廠別名稱)
            If reader("Per_FacName") Is DBNull.Value Then
                ai.Per_FacName = Nothing
            Else
                ai.Per_FacName = reader("Per_FacName").ToString
            End If

            'Per_DayPrice
            If reader("Per_DayPrice") Is DBNull.Value Then
                ai.Per_DayPrice = 0
            Else
                ai.Per_DayPrice = FormatNumber(reader("Per_DayPrice"), 1, TriState.True)
            End If



            If reader("Per_Class") Is DBNull.Value Then
                ai.Per_Class = Nothing
            Else
                ai.Per_Class = reader("Per_Class")
            End If


            ai.KQMonth = reader("KQMonth").ToString
            ai.KQClass = reader("KQClass").ToString



            Return ai

        End Function
        ''' <summary>
        ''' 數據增加
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionPiecePersonnel_Add(ByVal obj As ProductionPiecePersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnel_Add")

                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工工號
                db.AddInParameter(dbcomm, "@Per_Name", DbType.String, obj.Per_Name) '-- /員工名稱
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別
                db.AddInParameter(dbcomm, "@Per_PayType", DbType.String, obj.Per_PayType) ' --/薪金類型
                db.AddInParameter(dbcomm, "@Per_Date", DbType.String, obj.Per_Date) ' --/建立日期
                db.AddInParameter(dbcomm, "@Per_Action", DbType.String, obj.Per_Action) ' --/操作人

                db.AddInParameter(dbcomm, "@Per_Remark", DbType.String, obj.Per_Remark) '  --/備注
                db.AddInParameter(dbcomm, "@Per_Resign", DbType.Boolean, obj.Per_Resign) '--/是否已辭工

                db.AddInParameter(dbcomm, "@Per_DayPrice", DbType.Double, obj.Per_DayPrice) '--/日薪
                db.AddInParameter(dbcomm, "@Per_Class", DbType.String, obj.Per_Class) '--/班制

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePersonnel_Add = True


            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePersonnel_Add = False
            End Try
        End Function

        ''' <summary>
        ''' 更新記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePersonnel_Update(ByVal obj As ProductionPiecePersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnel_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, obj.AutoID) '-- /員工工號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工工號
                db.AddInParameter(dbcomm, "@Per_Name", DbType.String, obj.Per_Name) '-- /員工名稱
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別
                db.AddInParameter(dbcomm, "@Per_PayType", DbType.String, obj.Per_PayType) ' --/薪金類型
                db.AddInParameter(dbcomm, "@Per_Date", DbType.String, obj.Per_Date) ' --/建立日期
                db.AddInParameter(dbcomm, "@Per_Action", DbType.String, obj.Per_Action) ' --/操作人

                db.AddInParameter(dbcomm, "@Per_Remark", DbType.String, obj.Per_Remark) '  --/備注
                db.AddInParameter(dbcomm, "@Per_Resign", DbType.Boolean, obj.Per_Resign) '--/是否已辭工

                db.AddInParameter(dbcomm, "@Per_DayPrice", DbType.Double, obj.Per_DayPrice) '--/日薪
                db.AddInParameter(dbcomm, "@Per_Class", DbType.String, obj.Per_Class) '--/班制

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePersonnel_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePersonnel_Update = False
            End Try
        End Function

        ''' <summary>
        ''' 刪除記錄
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePersonnel_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnel_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePersonnel_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePersonnel_Delete = False
            End Try
        End Function
        ''' <summary>
        '''員工辭工處理
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePersonnel_ResignUpdate(ByVal obj As ProductionPiecePersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnel_ResignUpdate")

                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工工號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號

                db.AddInParameter(dbcomm, "@Per_Date", DbType.String, obj.Per_Date) ' --/建立日期
                db.AddInParameter(dbcomm, "@Per_Action", DbType.String, obj.Per_Action) ' --/操作人

                db.AddInParameter(dbcomm, "@Per_Resign", DbType.String, obj.Per_Resign) '--/是否已辭工

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePersonnel_ResignUpdate = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePersonnel_ResignUpdate = False
            End Try
        End Function

        'Now_Date  Load_Date
        ''' <summary>
        ''' 日更新名工名單(停用)
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePersonnel_DayUpdate(ByVal obj As ProductionPiecePersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnel_DayUpdate")

                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工工號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@Load_Date", DbType.String, obj.Load_Date) ' --/建立日期
                db.AddInParameter(dbcomm, "@Now_Date", DbType.String, obj.Now_Date) ' --當前時間

                db.AddInParameter(dbcomm, "@Per_Action", DbType.String, obj.Per_Action) ' --操作員

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePersonnel_DayUpdate = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePersonnel_DayUpdate = False
            End Try
        End Function



        Public Function ProductionPiecePersonnel_GetList1(ByVal G_NO As String, ByVal Per_PayType As String, ByVal Per_NO As String, ByVal DepID As String, ByVal FacID As String, _
                                                          ByVal Per_DateStart As String, ByVal Per_Resign As String, ByVal Per_DateEnd As String, ByVal Modle As String) As List(Of ProductionPiecePersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnel_GetList1")

            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO)
            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO) ' --/員工工號
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID) '-- /部門編號
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID) '-- /廠別
            db.AddInParameter(dbComm, "@Per_DateStart", DbType.String, Per_DateStart) '--/建立日期
            db.AddInParameter(dbComm, "@Per_Resign", DbType.String, Per_Resign) '-/是否已辭工
            db.AddInParameter(dbComm, "@Per_DateEnd", DbType.String, Per_DateEnd) '  --> < =

            db.AddInParameter(dbComm, "@Modle", DbType.String, Modle) '
            db.AddInParameter(dbComm, "@Per_PayType", DbType.String, Per_PayType)

            Dim FeatureList As New List(Of ProductionPiecePersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPiecePersonnel1(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 載入數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPiecePersonnel1(ByVal reader As IDataReader) As ProductionPiecePersonnelInfo
            Dim ai1 As New ProductionPiecePersonnelInfo

            If reader("Per_NO") Is DBNull.Value Then
                ai1.Per_NO = Nothing
            Else
                ai1.Per_NO = reader("Per_NO").ToString  '              *  nvarchar(50)                  /員工工號
            End If

            If reader("Per_Name") Is DBNull.Value Then
                ai1.Per_Name = Nothing
            Else
                ai1.Per_Name = reader("Per_Name").ToString  '  'Per_Name            *  nvarchar(50)                  /員工名稱
            End If

            ai1.Per_NOName = ai1.Per_NO + Space(2) + ai1.Per_Name

            'Per_DepName(部門名稱)
            If reader("Per_DepName") Is DBNull.Value Then
                ai1.Per_DepName = Nothing
            Else
                ai1.Per_DepName = reader("Per_DepName").ToString
            End If

            'Per_FacName(廠別名稱)
            If reader("Per_FacName") Is DBNull.Value Then
                ai1.Per_FacName = Nothing
            Else
                ai1.Per_FacName = reader("Per_FacName").ToString
            End If

            If reader("DepID") Is DBNull.Value Then
                ai1.DepID = Nothing
            Else
                ai1.DepID = reader("DepID").ToString  ' 'DPT_ID              *  nvarchar(50)                  /部門編號
            End If

            If reader("FacID") Is DBNull.Value Then
                ai1.FacID = Nothing
            Else
                ai1.FacID = reader("FacID").ToString  ''DPT_PID             *  nvarchar(50)                  /廠別
            End If

            'ai1.Per_Class = reader("Per_Class").ToString

            Return ai1

        End Function

        ''' <summary>
        ''' 2013-8-5 員工考勤班制
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionPiecePersonnelKaoQin_Update(ByVal obj As ProductionPiecePersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnelKaoQin_Update")

                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工工號
                db.AddInParameter(dbcomm, "@KQMonth", DbType.String, obj.KQMonth) '-- /員工工號
                db.AddInParameter(dbcomm, "@KQClass", DbType.String, obj.KQClass) '-- /員工工號

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePersonnelKaoQin_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePersonnelKaoQin_Update = False
            End Try
        End Function


    End Class
End Namespace
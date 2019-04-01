Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.NmetalSampleManager.NmetalSamplePace
    Public Class NmetalSamplePaceQueryController
        Friend Function FillNmetalSamplePaceBarCode(ByVal reader As IDataReader) As NmetalSamplePaceQueryInfo
            On Error Resume Next
            Dim objInfo As New NmetalSamplePaceQueryInfo
            objInfo.Code_ID = reader("Code_ID").ToString
            Return objInfo
        End Function

        Friend Function FillNmetalSamplePaceQuery(ByVal reader As IDataReader) As NmetalSamplePaceQueryInfo
            On Error Resume Next
            Dim objInfo As New NmetalSamplePaceQueryInfo
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.SE_OutD_Dep = reader("SE_OutD_Dep").ToString


            objInfo.SE_OutPS_Name = reader("SE_OutPS_Name").ToString
            If reader("SE_OutTime") Is DBNull.Value Then
                objInfo.SE_OutTime = Nothing
            Else
                objInfo.SE_OutTime = Format(CDate(reader("SE_OutTime")), "yyyy/MM/dd HH:mm:ss")
            End If
            objInfo.SE_InD_Dep = reader("SE_InD_Dep").ToString
            objInfo.SE_InPS_Name = reader("SE_InPS_Name").ToString
            If reader("SE_InTime") Is DBNull.Value Then
                objInfo.SE_InTime = Nothing
            Else
                objInfo.SE_InTime = Format(CDate(reader("SE_InTime")), "yyyy/MM/dd HH:mm:ss")
            End If
            objInfo.SE_InCheck = reader("SE_InCheck")
            objInfo.SE_InCheckActionName = reader("SE_InCheckActionName").ToString
            objInfo.SE_InCardIDName = reader("SE_InCardIDName").ToString
            objInfo.SE_OutCardIDName = reader("SE_OutCardIDName").ToString
            objInfo.SE_TypeName = reader("SE_TypeName").ToString
            objInfo.SE_ID = reader("SE_ID").ToString
            objInfo.SO_SampleID = reader("SO_SampleID").ToString

            objInfo.InWeighing = reader("InWeighing")
            objInfo.OutWeighing = reader("OutWeighing")

            objInfo.OutQtying = reader("OutQtying")
            objInfo.InQtying = reader("InQtying")

            objInfo.OutQty = reader("OutQty")
            objInfo.OutWeight = reader("OutWeight")
            objInfo.InQty = reader("InQty")
            objInfo.InWeight = reader("InWeight")

            objInfo.OutEndQty = reader("OutEndQty")
            objInfo.OutEndWeight = reader("OutEndWeight")

            If objInfo.OutWeight = 0 Then
                objInfo.OutWightChaYi = objInfo.OutEndWeight - objInfo.InWeight
            Else
                objInfo.OutWightChaYi = objInfo.OutEndWeight - objInfo.OutWeight
            End If

            '2014-07-24 Mark
            objInfo.D_ID = reader("D_ID").ToString
            objInfo.D_Dep = reader("D_Dep").ToString
            objInfo.IWeight = reader("IWeight")
            objInfo.TWeight = reader("TWeight")
            objInfo.StatusType = reader("StatusType").ToString

            objInfo.PS_NO = reader("PS_NO").ToString
            objInfo.PS_Name = reader("PS_Name").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.SO_SampeleID = reader("SO_SampeleID").ToString
            objInfo.SE_Type = reader("SE_Type").ToString

            objInfo.SE_InD_ID = reader("SE_InD_ID").ToString
            objInfo.SE_OutPS_NO = reader("SE_OutPS_NO").ToString
            objInfo.SE_OutD_ID = reader("SE_OutD_ID").ToString
            objInfo.SE_InPS_NO = reader("SE_InPS_NO").ToString
            objInfo.OutWeighingEnd = reader("OutWeighingEnd")

            objInfo.StatusTypeName = reader("StatusTypeName").ToString

            Return objInfo
        End Function
        Public Function NmetalSamplePaceBarCode_GetList(ByVal SO_ID As String) As List(Of NmetalSamplePaceQueryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePaceBarCode_GetList1")
            db.AddInParameter(dbComm, "@SO_ID", DbType.String, SO_ID)
            Dim FeatureList As New List(Of NmetalSamplePaceQueryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePaceBarCode(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSamplePaceQuery_Getlist(ByVal SO_ID As String, ByVal SE_ID As String, ByVal Code_ID As String, ByVal SS_Edition As String, ByVal StartDate As String, ByVal EndDate As String, ByVal SE_InCheck As String) As List(Of NmetalSamplePaceQueryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePaceQuery_Getlist")
            db.AddInParameter(dbComm, "@SO_ID", DbType.String, SO_ID)
            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@SS_Edition", DbType.String, SS_Edition)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@SE_InCheck", DbType.Boolean, SE_InCheck)
            Dim FeatureList As New List(Of NmetalSamplePaceQueryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePaceQuery(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSamplePaceQueryA_Getlist(ByVal Code_ID As String) As List(Of NmetalSamplePaceQueryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePaceQueryA_Getlist")

            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)

            Dim FeatureList As New List(Of NmetalSamplePaceQueryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePaceQuery(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 單個條碼記錄
        ''' </summary>
        ''' <param name="Code_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSamplePaceQueryB_Getlist(ByVal Code_ID As String) As List(Of NmetalSamplePaceQueryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePaceQueryB_Getlist")

            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)

            Dim FeatureList As New List(Of NmetalSamplePaceQueryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePaceQuery(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' Mark
        ''' 2014-07-27
        ''' </summary>
        ''' <param name="SO_SampleID"></param>
        ''' <param name="D_ID"></param>
        ''' <param name="StatusType"></param>
        ''' <param name="StartDate"></param>
        ''' <param name="EndDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NmetalSampleCollection_GetListQueryCondition(ByVal SO_SampleID As String, ByVal D_ID As String, ByVal StatusType As String, ByVal StartDate As String, ByVal EndDate As String) As List(Of NmetalSamplePaceQueryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleCollection_GetListQueryCondition")

            db.AddInParameter(dbComm, "@SO_SampleID", DbType.String, SO_SampleID)
            db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)
            db.AddInParameter(dbComm, "@StatusType", DbType.String, StatusType)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)

            Dim FeatureList As New List(Of NmetalSamplePaceQueryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePaceQuery(reader))
                End While
                Return FeatureList
            End Using
        End Function
    End Class
End Namespace
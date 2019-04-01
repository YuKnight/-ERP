Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.SampleManager.SamplePace
    Public Class SamplePaceQueryController
        Friend Function FillSamplePaceBarCode(ByVal reader As IDataReader) As SamplePaceQueryInfo
            On Error Resume Next
            Dim objInfo As New SamplePaceQueryInfo
            objInfo.Code_ID = reader("Code_ID").ToString
            Return objInfo
        End Function

        Friend Function FillSamplePaceQuery(ByVal reader As IDataReader) As SamplePaceQueryInfo
            On Error Resume Next
            Dim objInfo As New SamplePaceQueryInfo
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.SE_OutD_Dep = reader("SE_OutD_Dep").ToString


            objInfo.SE_OutPS_Name = reader("SE_OutPS_Name").ToString
            If reader("SE_OutTime") Is DBNull.Value Then
                objInfo.SE_OutTime = Nothing
            Else
                objInfo.SE_OutTime = reader("SE_OutTime")
            End If
            objInfo.SE_InD_Dep = reader("SE_InD_Dep").ToString
            objInfo.SE_InPS_Name = reader("SE_InPS_Name").ToString
            If reader("SE_InTime") Is DBNull.Value Then
                objInfo.SE_InTime = Nothing
            Else
                objInfo.SE_InTime = reader("SE_InTime")
            End If
            objInfo.SE_InCheck = reader("SE_InCheck")
            objInfo.SE_InCheckActionName = reader("SE_InCheckActionName").ToString
            objInfo.SE_InCardIDName = reader("SE_InCardIDName").ToString
            objInfo.SE_OutCardIDName = reader("SE_OutCardIDName").ToString
            objInfo.SE_TypeName = reader("SE_TypeName").ToString
            objInfo.SE_ID = reader("SE_ID").ToString
            objInfo.SO_SampleID = reader("SO_SampleID").ToString

            Return objInfo
        End Function
        Public Function SamplePaceBarCode_GetList(ByVal SO_ID As String) As List(Of SamplePaceQueryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceBarCode_GetList1")
            db.AddInParameter(dbComm, "@SO_ID", DbType.String, SO_ID)
            Dim FeatureList As New List(Of SamplePaceQueryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceBarCode(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePaceQuery_Getlist(ByVal SO_ID As String, ByVal SE_ID As String, ByVal Code_ID As String, ByVal SS_Edition As String, ByVal StartDate As String, ByVal EndDate As String, ByVal SE_InCheck As String) As List(Of SamplePaceQueryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceQuery_Getlist")
            db.AddInParameter(dbComm, "@SO_ID", DbType.String, SO_ID)
            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@SS_Edition", DbType.String, SS_Edition)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@SE_InCheck", DbType.Boolean, SE_InCheck)
            Dim FeatureList As New List(Of SamplePaceQueryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceQuery(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePaceQueryA_Getlist(ByVal Code_ID As String) As List(Of SamplePaceQueryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceQueryA_Getlist")

            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)

            Dim FeatureList As New List(Of SamplePaceQueryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceQuery(reader))
                End While
                Return FeatureList
            End Using
        End Function

    End Class
End Namespace
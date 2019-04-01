Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms

Namespace MProcessSub
    Public Class MProcessSubController
        Public Function MProcessSub_Add(ByVal objinfo As MProcessSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessSub_Add")

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, objinfo.PS_Num)
                db.AddInParameter(dbComm, "@PS_Cixu", DbType.String, objinfo.PS_Cixu)
                db.AddInParameter(dbComm, "@PS_DPT_ID", DbType.String, objinfo.PS_DPT_ID)
                db.AddInParameter(dbComm, "@PS_Name", DbType.String, objinfo.PS_Name)
                db.AddInParameter(dbComm, "@PS_PaiXu", DbType.String, objinfo.PS_PaiXu)
                db.AddInParameter(dbComm, "@PS_Enable", DbType.String, objinfo.PS_Enable)
                db.AddInParameter(dbComm, "@PS_OutPut", DbType.String, objinfo.PS_OutPut)
                db.AddInParameter(dbComm, "@PS_Remark", DbType.String, objinfo.PS_Remark)
                db.AddInParameter(dbComm, "@PS_Check", DbType.String, objinfo.PS_Check)

                db.ExecuteNonQuery(dbComm)
                MProcessSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MProcessSub_Add = False
            End Try
        End Function
        Public Function MProcessSub_Update(ByVal objinfo As MProcessSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessSub_Update")

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, objinfo.PS_Num)
                'db.AddInParameter(dbComm, "@PS_Cixu", DbType.String, objinfo.PS_Cixu)
                db.AddInParameter(dbComm, "@PS_DPT_ID", DbType.String, objinfo.PS_DPT_ID)
                db.AddInParameter(dbComm, "@PS_Name", DbType.String, objinfo.PS_Name)
                db.AddInParameter(dbComm, "@PS_PaiXu", DbType.String, objinfo.PS_PaiXu)
                db.AddInParameter(dbComm, "@PS_Enable", DbType.String, objinfo.PS_Enable)
                db.AddInParameter(dbComm, "@PS_OutPut", DbType.String, objinfo.PS_OutPut)
                db.AddInParameter(dbComm, "@PS_Remark", DbType.String, objinfo.PS_Remark)
                db.AddInParameter(dbComm, "@PS_Check", DbType.String, objinfo.PS_Check)

                db.ExecuteNonQuery(dbComm)
                MProcessSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MProcessSub_Update = False
            End Try
        End Function
        Public Function MProcessSub_Delete(ByVal Pro_NO As String, ByVal PS_Num As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessSub_Delete")

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, PS_Num)

                db.ExecuteNonQuery(dbComm)
                MProcessSub_Delete = True
            Catch ex As Exception
                MProcessSub_Delete = False
            End Try
        End Function
        Public Function MProcessSub_GetList(ByVal Pro_NO As String, ByVal PS_Num As String) As List(Of MProcessSubInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessSub_GetList")

            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@PS_Num", DbType.String, PS_Num)

            Dim FeatureList As New List(Of MProcessSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMProcessSub(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function MProcessSub_GetNum(ByVal PM_NO As String) As MProcessSubInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessSub_GetNum")
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMProcessSub(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function FillMProcessSub(ByVal reader As IDataReader) As MProcessSubInfo

            On Error Resume Next
            Dim psi As New MProcessSubInfo

            psi.Pro_NO = reader("Pro_NO").ToString
            psi.PS_Num = reader("PS_Num").ToString
            psi.PS_Cixu = reader("PS_Cixu").ToString
            psi.PS_DPT_ID = reader("PS_DPT_ID").ToString
            psi.PS_Name = reader("PS_Name").ToString
            psi.PS_PaiXu = reader("PS_PaiXu").ToString
            If reader("PS_Enable") Is DBNull.Value Then
                psi.PS_Enable = Nothing
            Else
                psi.PS_Enable = reader("PS_Enable")
            End If

            psi.PS_OutPut = reader("PS_OutPut")
            psi.PS_Remark = reader("PS_Remark").ToString

            If reader("PS_Check") Is DBNull.Value Then
                psi.PS_Check = Nothing
            Else
                psi.PS_Check = reader("PS_Check")
            End If

            Return psi
        End Function
    End Class
End Namespace


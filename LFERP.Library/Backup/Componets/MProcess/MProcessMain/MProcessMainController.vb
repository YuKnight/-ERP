Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms
Namespace MProcessMain
    Public Class MProcessMainController
        Public Function MProcessMain_Add(ByVal objinfo As MProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessMain_Add")

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PM_Sort", DbType.String, objinfo.PM_Sort)
                db.AddInParameter(dbComm, "@PM_AddDate", DbType.String, objinfo.PM_AddDate)
                db.AddInParameter(dbComm, "@PM_EditDate", DbType.String, objinfo.PM_EditDate)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, objinfo.PM_Action)
                db.AddInParameter(dbComm, "@PM_Remark", DbType.String, objinfo.PM_Remark)
                db.AddInParameter(dbComm, "@PM_Check", DbType.String, objinfo.PM_Check)
                db.AddInParameter(dbComm, "@PM_CheckActor", DbType.String, objinfo.PM_CheckActor)
                db.AddInParameter(dbComm, "@PM_Photo", DbType.String, objinfo.PM_Photo)
                db.AddInParameter(dbComm, "@PM_CheckDate", DbType.String, objinfo.PM_CheckDate)
                db.AddInParameter(dbComm, "@PM_CheckRemark", DbType.String, objinfo.PM_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                MProcessMain_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MProcessMain_Add = False
            End Try
        End Function
        Public Function MProcessMain_Update(ByVal objinfo As MProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessMain_Update")

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@PM_Sort", DbType.String, objinfo.PM_Sort)
                db.AddInParameter(dbComm, "@PM_AddDate", DbType.Date, objinfo.PM_AddDate)
                db.AddInParameter(dbComm, "@PM_EditDate", DbType.Date, objinfo.PM_EditDate)
                db.AddInParameter(dbComm, "@PM_Action", DbType.String, objinfo.PM_Action)
                db.AddInParameter(dbComm, "@PM_Remark", DbType.String, objinfo.PM_Remark)
                db.AddInParameter(dbComm, "@PM_Photo", DbType.Binary, objinfo.PM_Photo)
               
                db.ExecuteNonQuery(dbComm)
                MProcessMain_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MProcessMain_Update = False
            End Try
        End Function
        Public Function MProcessMain_UpdateCheck(ByVal objinfo As MProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessMain_UpdateCheck")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Check", DbType.String, objinfo.PM_Check)
                db.AddInParameter(dbComm, "@PM_CheckActor", DbType.String, objinfo.PM_CheckActor)
                db.AddInParameter(dbComm, "@PM_CheckDate", DbType.Date, objinfo.PM_CheckDate)
                db.AddInParameter(dbComm, "@PM_CheckRemark", DbType.Date, objinfo.PM_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                MProcessMain_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MProcessMain_UpdateCheck = False
            End Try
        End Function
        Public Function MProcessMain_Delete(ByVal PM_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessMain_Delete")

                db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)

                db.ExecuteNonQuery(dbComm)
                MProcessMain_Delete = True
            Catch ex As Exception
                MProcessMain_Delete = False
            End Try
        End Function
        Public Function MProcessMain_GetNO(ByVal Ndate As String) As MProcessMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessMain_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMProcessMain(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function MProcessMain_GetList(ByVal Pro_NO As String, ByVal PM_NO As String, ByVal PM_Type As String, ByVal PM_Check As String) As List(Of MProcessMainInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcessMain_GetList")

            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PM_Check", DbType.String, PM_Check)

            Dim FeatureList As New List(Of MProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMProcessMain(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function FillMProcessMain(ByVal reader As IDataReader) As MProcessMainInfo
            On Error Resume Next
            Dim pmi As New MProcessMainInfo
            pmi.Pro_NO = reader("Pro_NO").ToString
            pmi.PM_NO = reader("PM_NO").ToString
            pmi.PM_Type = reader("PM_Type").ToString
            pmi.PM_Sort = reader("PM_Sort").ToString

            If reader("PM_AddDate") Is DBNull.Value Then
                pmi.PM_AddDate = Nothing
            Else
                pmi.PM_AddDate = CDate(reader("PM_AddDate").ToString)
            End If
            If reader("PM_EditDate") Is DBNull.Value Then
                pmi.PM_AddDate = Nothing
            Else
                pmi.PM_AddDate = CDate(reader("PM_EditDate").ToString)
            End If
            pmi.PM_Action = reader("PM_Action").ToString
            pmi.PM_Remark = reader("PM_Remark").ToString
            If reader("PM_Check") Is DBNull.Value Then
                pmi.PM_Check = Nothing
            Else
                pmi.PM_Check = reader("PM_Check")
            End If

            pmi.PM_CheckActor = reader("PM_CheckActor").ToString
            If reader("PM_Check") Is DBNull.Value Then
                pmi.PM_Photo = Nothing
            Else
                pmi.PM_Photo = reader("PM_Photo")
            End If

            If reader("PM_CheckDate") Is DBNull.Value Then
                pmi.PM_AddDate = Nothing
            Else
                pmi.PM_AddDate = CDate(reader("PM_CheckDate").ToString)
            End If
            pmi.PM_CheckRemark = reader("PM_CheckRemark").ToString

            pmi.M_Code = reader("M_Code").ToString
            pmi.M_Name = reader("M_Name").ToString
            pmi.M_Gauge = reader("M_Gauge").ToString
            pmi.ActionName = reader("ActionName").ToString
            pmi.CheckActionName = reader("CheckActionName").ToString
            Return pmi
        End Function
    End Class
End Namespace


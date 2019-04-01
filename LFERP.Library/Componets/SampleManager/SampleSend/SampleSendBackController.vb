Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.SampleManager.SampleSend
    Public Class SampleSendBackControler
        Friend Function FillSampleSendBack(ByVal reader As IDataReader) As SampleSendBackInfo
            Dim objInfo As New SampleSendBackInfo
            objInfo.SB_ID = reader("SB_ID").ToString
            objInfo.SO_ID = reader("SO_ID").ToString
            objInfo.SS_Edition = reader("SS_Edition").ToString
            objInfo.SB_Qty = reader("SB_Qty").ToString
            objInfo.SB_CusterID = reader("SB_CusterID").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.D_ID = reader("D_ID").ToString
            objInfo.D_Dep = reader("D_Dep").ToString
            objInfo.PS_NO = reader("PS_NO").ToString
            objInfo.PS_Name = reader("PS_Name").ToString
            objInfo.ClientBarcode = reader("ClientBarcode").ToString
            objInfo.SB_Remark = reader("SB_Remark").ToString
            If reader("SB_SendBackDate") Is DBNull.Value Then
                objInfo.SB_SendBackDate = Nothing
            Else
                objInfo.SB_SendBackDate = CStr(reader("SB_SendBackDate"))
            End If
            objInfo.SB_AddUserID = reader("SB_AddUserID").ToString
            If reader("SB_AddDate") Is DBNull.Value Then
                objInfo.SB_AddDate = Nothing
            Else
                objInfo.SB_AddDate = CStr(reader("SB_AddDate"))
            End If
            objInfo.SB_ModifyUserID = reader("SB_ModifyUserID").ToString
            If reader("SB_ModifyDate") Is DBNull.Value Then
                objInfo.SB_ModifyDate = Nothing
            Else
                objInfo.SB_ModifyDate = CStr(reader("SB_ModifyDate"))
            End If
            objInfo.SB_CheckUserID = reader("SB_CheckUserID").ToString
            If reader("SB_Check") Is DBNull.Value Then
                objInfo.SB_Check = Nothing
            Else
                objInfo.SB_Check = reader("SB_Check")
            End If
            If reader("SB_CheckDate") Is DBNull.Value Then
                objInfo.SB_CheckDate = Nothing
            Else
                objInfo.SB_CheckDate = CStr(reader("SB_CheckDate"))
            End If
            objInfo.SB_CheckRemark = reader("SB_CheckRemark").ToString
            objInfo.SE_TypeName = reader("SE_TypeName").ToString
            objInfo.SO_SampleID = reader("SO_SampleID").ToString
            Return objInfo
        End Function

        Public Function SampleSendBack_GetList(ByVal SO_ID As String, ByVal SB_ID As String) As List(Of SampleSendBackInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendBack_GetList")
            'dbComm.CommandTimeout = 0
            db.AddInParameter(dbComm, "@SO_ID", DbType.String, SO_ID)
            db.AddInParameter(dbComm, "@SB_ID", DbType.String, SB_ID)

            Dim FeatureList As New List(Of SampleSendBackInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleSendBack(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleSendBack_Delete(ByVal SB_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendBack_Delete")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@SB_ID", DbType.String, SB_ID)

                db.ExecuteNonQuery(dbComm)
                SampleSendBack_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleSendBack_Delete = False
            End Try
        End Function

        Public Function SampleSendBack_GetID(ByVal SB_ID As String) As SampleSendBackInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendBack_GetID")
            dbComm.CommandTimeout = 0
            db.AddInParameter(dbComm, "@SB_ID", DbType.String, SB_ID)
            Dim FeatureList As New SampleSendBackInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.SB_ID = reader("SB_ID").ToString
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleSendBack_Update(ByVal objinfo As SampleSendBackInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendBack_Update")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, objinfo.AutoID)
                db.AddInParameter(dbComm, "@SB_ID", DbType.String, objinfo.SB_ID)
                db.AddInParameter(dbComm, "@SO_ID", DbType.String, objinfo.SO_ID)
                db.AddInParameter(dbComm, "@SS_Edition", DbType.String, objinfo.SS_Edition)
                db.AddInParameter(dbComm, "@SB_Qty", DbType.Int64, objinfo.SB_Qty)
                db.AddInParameter(dbComm, "@SB_CusterID", DbType.String, objinfo.SB_CusterID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objinfo.D_ID)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@SB_Remark", DbType.String, objinfo.SB_Remark)
                db.AddInParameter(dbComm, "@SE_TypeName", DbType.String, objinfo.SE_TypeName)

                If objinfo.SB_SendBackDate = Nothing Then
                    db.AddInParameter(dbComm, "@SB_SendBackDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@SB_SendBackDate", DbType.Date, objinfo.SB_SendBackDate)
                End If

                db.AddInParameter(dbComm, "@SB_ModifyUserID", DbType.String, objinfo.SB_ModifyUserID)
                If objinfo.SB_ModifyDate = Nothing Then
                    db.AddInParameter(dbComm, "@SB_ModifyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@SB_ModifyDate", DbType.Date, objinfo.SB_ModifyDate)
                End If
 
                db.ExecuteNonQuery(dbComm)
                SampleSendBack_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleSendBack_Update = False
            End Try
        End Function


        Public Function SampleSendBack_Add(ByVal objInfo As SampleSendBackInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendBack_Add")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@SB_ID", DbType.String, objInfo.SB_ID)
                db.AddInParameter(dbComm, "@SO_ID", DbType.String, objInfo.SO_ID)
                db.AddInParameter(dbComm, "@SS_Edition", DbType.String, objInfo.SS_Edition)
                db.AddInParameter(dbComm, "@SB_Qty", DbType.Int64, objInfo.SB_Qty)
                db.AddInParameter(dbComm, "@SB_CusterID", DbType.String, objInfo.SB_CusterID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objInfo.Code_ID)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objInfo.D_ID)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objInfo.PS_NO)
                db.AddInParameter(dbComm, "@SB_Remark", DbType.String, objInfo.SB_Remark)
                db.AddInParameter(dbComm, "@SE_TypeName", DbType.String, objInfo.SE_TypeName)
                If objInfo.SB_SendBackDate = Nothing Then
                    db.AddInParameter(dbComm, "@SB_SendBackDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@SB_SendBackDate", DbType.Date, objInfo.SB_SendBackDate)
                End If

                db.AddInParameter(dbComm, "@SB_AddUserID", DbType.String, objInfo.SB_AddUserID)
                If objInfo.SB_AddDate = Nothing Then
                    db.AddInParameter(dbComm, "@SB_AddDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@SB_AddDate", DbType.Date, objInfo.SB_AddDate)
                End If

                db.ExecuteNonQuery(dbComm)
                SampleSendBack_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleSendBack_Add = False
            End Try
        End Function
    End Class
End Namespace


Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms

Namespace LFERP.Library.MessageMain


    'Private MS_ID As String
    'Private MS_Priority As String
    'Private MS_Read As String
    'Private MS_Attachment As String
    'Private MS_Subject As String
    'Private MS_From As String
    'Private MS_To As String
    'Private MS_SendDate As Date
    'Private MS_ReceivedDate As Date
    'Private MS_TypeID As String
    'Private MS_Content As String

    'Private MS_AttachID As String
    'Private MS_ModuleID As String
    'Private MS_DanJuID As String
    'Private MS_AttachName As String
    'Private MS_SendType As String

    Public Class MessageMainControl

        Friend Function FillMessageMain(ByVal reader As IDataReader) As MessageMainInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New MessageMainInfo
            objInfo.MS_ID = reader("MS_ID").ToString
            objInfo.MS_Priority = reader("MS_Priority").ToString
            objInfo.MS_Read = reader("MS_Read").ToString

            objInfo.MS_Attachment = reader("MS_Attachment").ToString
            objInfo.MS_Subject = reader("MS_Subject").ToString
            objInfo.MS_From = reader("MS_From").ToString
            objInfo.MS_FromName = reader("MS_FromName").ToString
            objInfo.MS_To = reader("MS_To").ToString
            If reader("MS_SendDate") Is DBNull.Value Then
                objInfo.MS_SendDate = Nothing
            Else
                objInfo.MS_SendDate = CStr(reader("MS_SendDate"))
            End If
            If reader("MS_ReceivedDate") Is DBNull.Value Then
                objInfo.MS_ReceivedDate = Nothing
            Else
                objInfo.MS_ReceivedDate = CStr(reader("MS_ReceivedDate"))
            End If
            objInfo.MS_TypeID = reader("MS_TypeID").ToString
            objInfo.MS_Content = reader("MS_Content").ToString
            objInfo.MS_InUserID = reader("MS_InUserID").ToString

            objInfo.MS_AttachID = reader("MS_AttachID").ToString
            objInfo.MS_ModuleID = reader("MS_ModuleID").ToString
            objInfo.MS_DanJuID = reader("MS_DanJuID").ToString
            objInfo.MS_AttachName = reader("MS_AttachName").ToString
            objInfo.MS_SendType = reader("MS_SendType").ToString

            Return objInfo

        End Function

        Public Function MessageMain_add(ByVal objFile1 As MessageMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MessageMain_add")

                db.AddInParameter(dbComm, "@MS_ID", DbType.String, objFile1.MS_ID)
                db.AddInParameter(dbComm, "@MS_Priority", DbType.String, objFile1.MS_Priority)
                db.AddInParameter(dbComm, "@MS_Read", DbType.String, objFile1.MS_Read)

                db.AddInParameter(dbComm, "@MS_Attachment", DbType.String, objFile1.MS_Attachment)
                db.AddInParameter(dbComm, "@MS_Subject", DbType.String, objFile1.MS_Subject)
                db.AddInParameter(dbComm, "@MS_From", DbType.String, objFile1.MS_From)
                db.AddInParameter(dbComm, "@MS_To", DbType.String, objFile1.MS_To)
                If objFile1.MS_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@MS_SendDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MS_SendDate", DbType.Date, objFile1.MS_SendDate)
                End If
                If objFile1.MS_ReceivedDate = Nothing Then
                    db.AddInParameter(dbComm, "@MS_ReceivedDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MS_ReceivedDate", DbType.Date, objFile1.MS_ReceivedDate)
                End If
                db.AddInParameter(dbComm, "@MS_TypeID", DbType.String, objFile1.MS_TypeID)
                db.AddInParameter(dbComm, "@MS_Content", DbType.String, objFile1.MS_Content)
                db.AddInParameter(dbComm, "@MS_InUserID", DbType.String, objFile1.MS_InUserID)
                'db.AddInParameter(dbComm, "@MS_AttachID", DbType.Int16, objFile1.MS_AttachID)
                'db.AddInParameter(dbComm, "@MS_ModuleID", DbType.String, objFile1.MS_ModuleID)
                'db.AddInParameter(dbComm, "@MS_DanJuID", DbType.String, objFile1.MS_DanJuID)
                'db.AddInParameter(dbComm, "@MS_AttachName", DbType.String, objFile1.MS_AttachName)
                'db.AddInParameter(dbComm, "@MS_SendType", DbType.String, objFile1.MS_SendType)
                db.ExecuteNonQuery(dbComm)
                MessageMain_add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MessageMain_add = False
            End Try
        End Function


        Public Function MessageMain_Update(ByVal objFile1 As MessageMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MessageMain_Update")

                db.AddInParameter(dbComm, "@MS_ID", DbType.String, objFile1.MS_ID)
                db.AddInParameter(dbComm, "@MS_Priority", DbType.String, objFile1.MS_Priority)
                db.AddInParameter(dbComm, "@MS_Read", DbType.String, objFile1.MS_Read)

                db.AddInParameter(dbComm, "@MS_Attachment", DbType.String, objFile1.MS_Attachment)
                db.AddInParameter(dbComm, "@MS_Subject", DbType.String, objFile1.MS_Subject)
                db.AddInParameter(dbComm, "@MS_From", DbType.String, objFile1.MS_From)
                db.AddInParameter(dbComm, "@MS_To", DbType.String, objFile1.MS_To)
                If objFile1.MS_SendDate = Nothing Then
                    db.AddInParameter(dbComm, "@MS_SendDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MS_SendDate", DbType.Date, objFile1.MS_SendDate)
                End If
                If objFile1.MS_ReceivedDate = Nothing Then
                    db.AddInParameter(dbComm, "@MS_ReceivedDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@MS_ReceivedDate", DbType.Date, objFile1.MS_ReceivedDate)
                End If
                db.AddInParameter(dbComm, "@MS_TypeID", DbType.String, objFile1.MS_TypeID)
                db.AddInParameter(dbComm, "@MS_Content", DbType.String, objFile1.MS_Content)
                db.AddInParameter(dbComm, "@MS_InUserID", DbType.String, objFile1.MS_InUserID)

                'db.AddInParameter(dbComm, "@MS_AttachID", DbType.Int16, objFile1.MS_AttachID)
                'db.AddInParameter(dbComm, "@MS_ModuleID", DbType.String, objFile1.MS_ModuleID)
                'db.AddInParameter(dbComm, "@MS_DanJuID", DbType.String, objFile1.MS_DanJuID)
                'db.AddInParameter(dbComm, "@MS_AttachName", DbType.String, objFile1.MS_AttachName)
                'db.AddInParameter(dbComm, "@MS_SendType", DbType.String, objFile1.MS_SendType)

                db.ExecuteNonQuery(dbComm)
                MessageMain_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MessageMain_Update = False
            End Try
        End Function


        Public Function MessageMain_Delete(ByVal MS_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MessageMain_Delete")
                db.AddInParameter(dbComm, "@MS_ID", DbType.String, MS_ID)
                db.ExecuteNonQuery(dbComm)
                MessageMain_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MessageMain_Delete = False
            End Try
        End Function


        Public Function MessageMain_Getlist(ByVal MS_ID As String, ByVal MS_Priority As String, ByVal MS_Read As String, ByVal MS_From As String, ByVal MS_To As String, ByVal MS_TypeID As String, ByVal MS_InUserID As String) As List(Of MessageMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MessageMain_Getlist")
            db.AddInParameter(dbComm, "@MS_ID", DbType.String, MS_ID)
            db.AddInParameter(dbComm, "@MS_Priority", DbType.String, MS_Priority)
            db.AddInParameter(dbComm, "@MS_Read", DbType.String, MS_Read)
            db.AddInParameter(dbComm, "@MS_From", DbType.String, MS_From)
            db.AddInParameter(dbComm, "@MS_To", DbType.String, MS_To)
            db.AddInParameter(dbComm, "@MS_TypeID", DbType.String, MS_TypeID)
            db.AddInParameter(dbComm, "@MS_InUserID", DbType.String, MS_InUserID)

            Dim FeatureList As New List(Of MessageMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMessageMain(reader))
                End While
                Return FeatureList
            End Using

        End Function


        Public Function MessageMain_Get(ByVal MS_ID As String) As MessageMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MessageMain_Get")
            db.AddInParameter(dbComm, "@MS_ID", DbType.String, MS_ID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMessageMain(reader)
                End While
                Return Nothing
            End Using

        End Function


        Public Function Attachment_add(ByVal objFile1 As MessageMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Attachment_add")

                db.AddInParameter(dbComm, "@MS_ID", DbType.String, objFile1.MS_ID)

                db.AddInParameter(dbComm, "@MS_AttachID", DbType.String, objFile1.MS_AttachID)
                db.AddInParameter(dbComm, "@MS_ModuleID", DbType.String, objFile1.MS_ModuleID)
                db.AddInParameter(dbComm, "@MS_DanJuID", DbType.String, objFile1.MS_DanJuID)
                db.AddInParameter(dbComm, "@MS_AttachName", DbType.String, objFile1.MS_AttachName)
                db.AddInParameter(dbComm, "@MS_SendType", DbType.String, objFile1.MS_SendType)
                db.ExecuteNonQuery(dbComm)
                Attachment_add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Attachment_add = False
            End Try
        End Function


        Public Function Attachment_Update(ByVal objFile1 As MessageMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Attachment_Update")

                db.AddInParameter(dbComm, "@MS_ID", DbType.String, objFile1.MS_ID)
                db.AddInParameter(dbComm, "@MS_AttachID", DbType.String, objFile1.MS_AttachID)
                db.AddInParameter(dbComm, "@MS_ModuleID", DbType.String, objFile1.MS_ModuleID)
                db.AddInParameter(dbComm, "@MS_DanJuID", DbType.String, objFile1.MS_DanJuID)
                db.AddInParameter(dbComm, "@MS_AttachName", DbType.String, objFile1.MS_AttachName)
                db.AddInParameter(dbComm, "@MS_SendType", DbType.String, objFile1.MS_SendType)
                db.ExecuteNonQuery(dbComm)
                Attachment_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Attachment_Update = False
            End Try


        End Function


        Public Function Attachment_Delete(ByVal MS_ID As String, ByVal MS_AttachID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Attachment_Delete")
                db.AddInParameter(dbComm, "@MS_ID", DbType.String, MS_ID)
                db.AddInParameter(dbComm, "@MS_AttachID", DbType.String, MS_AttachID)
                db.ExecuteNonQuery(dbComm)
                Attachment_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Attachment_Delete = False
            End Try
        End Function


        Public Function Attachment_GetList(ByVal MS_ID As String) As List(Of MessageMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Attachment_GetList")
            db.AddInParameter(dbComm, "@MS_ID", DbType.String, MS_ID)

            Dim FeatureList As New List(Of MessageMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMessageMain(reader))
                End While
                Return FeatureList
            End Using

        End Function


    End Class

End Namespace
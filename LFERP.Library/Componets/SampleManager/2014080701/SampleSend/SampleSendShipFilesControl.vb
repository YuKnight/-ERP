Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.SampleManager.SampleSend
    Public Class SampleSendShipFilesControl
        Public Function SampleSendShipFiles_Add(ByVal objinfo As SampleSendShipFilesInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendShipFiles_Add")

                db.AddInParameter(dbComm, "@SP_ID", DbType.String, objinfo.SP_ID)
                db.AddInParameter(dbComm, "@SP_Qty", DbType.Int32, objinfo.SP_Qty)
                db.AddInParameter(dbComm, "@BoxID", DbType.String, objinfo.BoxID)
                db.AddInParameter(dbComm, "@PartName", DbType.String, objinfo.PartName)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PalletID", DbType.String, objinfo.PalletID)
                db.AddInParameter(dbComm, "@Weighing", DbType.Double, objinfo.Weighing)
                db.AddInParameter(dbComm, "@AddUserID", DbType.String, objinfo.AddUserID)
                db.AddInParameter(dbComm, "@AddDate", DbType.Date, objinfo.AddDate)
                db.AddInParameter(dbComm, "@CO_ID", DbType.String, objinfo.CO_ID)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@QPN", DbType.String, objinfo.QPN)
                db.AddInParameter(dbComm, "@LC", DbType.String, objinfo.LC)

                db.AddInParameter(dbComm, "@Addressee", DbType.String, objinfo.Addressee)
                db.AddInParameter(dbComm, "@Project", DbType.String, objinfo.Project)
                db.AddInParameter(dbComm, "@Handle", DbType.String, objinfo.Handle)
                db.ExecuteNonQuery(dbComm)
                SampleSendShipFiles_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleSendShipFiles_Add = False
            End Try
        End Function

        Public Function SampleSendShipFiles_Update(ByVal objinfo As SampleSendShipFilesInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendShipFiles_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@SP_ID", DbType.String, objinfo.SP_ID)
                db.AddInParameter(dbComm, "@SP_Qty", DbType.Int32, objinfo.SP_Qty)
                db.AddInParameter(dbComm, "@BoxID", DbType.String, objinfo.BoxID)
                db.AddInParameter(dbComm, "@PartName", DbType.String, objinfo.PartName)
                db.AddInParameter(dbComm, "@PalletID", DbType.String, objinfo.PalletID)
                db.AddInParameter(dbComm, "@Weighing", DbType.Double, objinfo.Weighing)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                db.AddInParameter(dbComm, "@CO_ID", DbType.String, objinfo.CO_ID)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@QPN", DbType.String, objinfo.QPN)
                db.AddInParameter(dbComm, "@LC", DbType.String, objinfo.LC)

                db.AddInParameter(dbComm, "@Addressee", DbType.String, objinfo.Addressee)
                db.AddInParameter(dbComm, "@Project", DbType.String, objinfo.Project)
                db.AddInParameter(dbComm, "@Handle", DbType.String, objinfo.Handle)

                db.ExecuteNonQuery(dbComm)
                SampleSendShipFiles_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleSendShipFiles_Update = False
            End Try
        End Function

        Public Function SampleSendShipFiles_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendShipFiles_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                SampleSendShipFiles_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                SampleSendShipFiles_Delete = False
            End Try
        End Function

        Public Function SampleSendShipFiles_GetList(ByVal SP_ID As String, ByVal AutoID As String, ByVal PM_M_Code As String) As List(Of SampleSendShipFilesInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendShipFiles_GetList")

            db.AddInParameter(dbComm, "@SP_ID", DbType.String, SP_ID)
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            Dim FeatureList As New List(Of SampleSendShipFilesInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleSendShipFiles(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleSendShipFiles_DTGetList(ByVal SP_ID As String, ByVal AutoID As String, ByVal PM_M_Code As String) As DataTable
            Try
                Dim ds As New DataSet
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleSendShipFiles_GetList")
                db.AddInParameter(dbComm, "@SP_ID", DbType.String, SP_ID)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

                ds = db.ExecuteDataSet(dbComm)
                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function FillSampleSendShipFiles(ByVal reader As IDataReader) As SampleSendShipFilesInfo
            On Error Resume Next
            Dim ObjectID As New SampleSendShipFilesInfo
            ObjectID.AutoID = reader("AutoID")
            ObjectID.SP_ID = reader("SP_ID").ToString
            ObjectID.SP_Qty = reader("SP_Qty")
            ObjectID.BoxID = reader("BoxID").ToString
            ObjectID.PartName = reader("PartName").ToString
            ObjectID.PalletID = reader("PalletID").ToString
            ObjectID.Weighing = reader("Weighing")
            ObjectID.AddUserID = reader("AddUserID").ToString
            ObjectID.AddDate = reader("AddDate")
            ObjectID.ModifyUserID = reader("ModifyUserID").ToString
            ObjectID.ModifyDate = reader("ModifyDate")
            ObjectID.CO_ID = reader("CO_ID").ToString
            ObjectID.PM_M_Code = reader("PM_M_Code").ToString
            ObjectID.CheckBit = reader("CheckBit")
            ObjectID.CheckDate = reader("CheckDate")
            ObjectID.Code_ID = reader("Code_ID").ToString
            ObjectID.QPN = reader("QPN").ToString
            ObjectID.LC = reader("LC").ToString
            ObjectID.Addressee = reader("Addressee").ToString
            ObjectID.Project = reader("Project").ToString
            ObjectID.Handle = reader("Handle").ToString
            ObjectID.SP_CusterID = reader("SP_CusterID").ToString
            ObjectID.SP_SendDate = reader("SP_SendDate")
            Return ObjectID
        End Function
    End Class
End Namespace
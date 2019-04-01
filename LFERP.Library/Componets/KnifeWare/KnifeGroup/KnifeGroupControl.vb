Imports System.Data.Common
Namespace LFERP.Library.KnifeWare
    Public Class KnifeGroupControl
        Public Function KnifeGroup_GetList(ByVal G_NO As String, ByVal G_Name As String, ByVal WH_ID As String) As List(Of KnifeGroupInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeGroup_GetList")
            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO)
            db.AddInParameter(dbComm, "@G_Name", DbType.String, G_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)

            Dim FeatureList As New List(Of KnifeGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeGroup(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function FillKnifeGroup(ByVal reader As IDataReader) As KnifeGroupInfo
            Dim ci As New KnifeGroupInfo
            '¬y¤ô¸¹
            On Error Resume Next
            ci.AutoID = reader("AutoID").ToString
            ci.G_Name = reader("G_Name").ToString

            ci.G_NO = reader("G_NO").ToString
            ci.WH_ID = reader("WH_ID").ToString
            ci.Remark = reader("Remark").ToString
            Return ci

        End Function

        Public Function KnifeGroup_Add(ByVal obj As KnifeGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeGroup_Add")

                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO)
                db.AddInParameter(dbcomm, "@G_Name", DbType.String, obj.G_Name)
                db.AddInParameter(dbcomm, "@Remark", DbType.String, obj.Remark)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID)

                db.ExecuteNonQuery(dbcomm)
                KnifeGroup_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeGroup_Add = False
            End Try
        End Function

        Public Function KnifeGroup_Update(ByVal obj As KnifeGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeGroup_Update")

                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO)
                db.AddInParameter(dbcomm, "@G_Name", DbType.String, obj.G_Name)
                db.AddInParameter(dbcomm, "@Remark", DbType.String, obj.Remark)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, obj.WH_ID)

                db.ExecuteNonQuery(dbcomm)
                KnifeGroup_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeGroup_Update = False
            End Try
        End Function

        Public Function KnifeGroup_Delete(ByVal G_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeGroup_Delete")
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, G_NO)
                db.ExecuteNonQuery(dbcomm)
                KnifeGroup_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeGroup_Delete = False
            End Try
        End Function

    End Class
End Namespace

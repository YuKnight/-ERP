Imports System.Data.Common
Namespace LFERP.Library.KnifeWare
    Public Class KnifeTypeGroupControl

        Public Function KnifeTypeGroup_GetID(ByVal KnifePID As String) As KnifeTypeGroupInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeTypeGroup_GetID")
            db.AddInParameter(dbComm, "@KnifePID", DbType.String, KnifePID)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillKnifeTypeGroupID(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function FillKnifeTypeGroupID(ByVal reader As IDataReader) As KnifeTypeGroupInfo
            Dim ci As New KnifeTypeGroupInfo
            '流水號
            ci.KnifeID = reader("KnifeID").ToString
            Return ci
        End Function

        Public Function KnifeTypeGroup_Add(ByVal obj As KnifeTypeGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeTypeGroup_Add")

                db.AddInParameter(dbcomm, "@KnifeType", DbType.String, obj.KnifeType)
                db.AddInParameter(dbcomm, "@KnifePID", DbType.String, obj.KnifePID)
                db.AddInParameter(dbcomm, "@KnifeID", DbType.String, obj.KnifeID)

                db.ExecuteNonQuery(dbcomm)
                KnifeTypeGroup_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeTypeGroup_Add = False
            End Try
        End Function

        Public Function KnifeTypeGroup_Update(ByVal obj As KnifeTypeGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeTypeGroup_Update")

                db.AddInParameter(dbcomm, "@KnifeType", DbType.String, obj.KnifeType)
                db.AddInParameter(dbcomm, "@KnifePID", DbType.String, obj.KnifePID)
                db.AddInParameter(dbcomm, "@KnifeID", DbType.String, obj.KnifeID)

                db.ExecuteNonQuery(dbcomm)
                KnifeTypeGroup_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeTypeGroup_Update = False
            End Try
        End Function

        Public Function KnifeTypeGroup_Delete(ByVal KnifeID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeTypeGroup_Delete")

                db.AddInParameter(dbcomm, "@KnifeID", DbType.String, KnifeID)

                db.ExecuteNonQuery(dbcomm)
                KnifeTypeGroup_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeTypeGroup_Delete = False
            End Try
        End Function

        Public Function KnifeTypeGroup_GetList(ByVal AutoID As String, ByVal KnifeType As String, ByVal KnifePID As String, ByVal KnifeID As String) As List(Of KnifeTypeGroupInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeTypeGroup_GetList")

            db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbcomm, "@KnifeType", DbType.String, KnifeType)
            db.AddInParameter(dbcomm, "@KnifePID", DbType.String, KnifePID)
            db.AddInParameter(dbcomm, "@KnifeID", DbType.String, KnifeID)

            Dim FeatureList As New List(Of KnifeTypeGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeTypeGroup(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillKnifeTypeGroup(ByVal reader As IDataReader) As KnifeTypeGroupInfo
            Dim ci As New KnifeTypeGroupInfo
            '流水號
            On Error Resume Next
            ci.AutoID = reader("AutoID").ToString
            ci.KnifeID = reader("KnifeID").ToString
            ci.KnifePID = reader("KnifePID").ToString
            ci.KnifeType = reader("KnifeType").ToString

            ci.M_Code = reader("M_Code").ToString
            ci.M_Gauge = reader("M_Gauge").ToString
            ci.M_Name = reader("M_Name").ToString
            ci.KnifePIDName = reader("KnifePIDName").ToString
            ci.KnifeIDName = reader("KnifeIDName").ToString

            Return ci

        End Function


#Region "更新物料表"
        ''


        ''' <summary>
        ''' 根據物料類別查詢出，去重復的自定義刀具類
        ''' </summary>
        ''' <param name="KnifeID"></param>
        ''' <param name="Type3ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeMaterialCode_DistGetList(ByVal KnifeID As String, ByVal Type3ID As String) As List(Of KnifeTypeGroupInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeMaterialCode_DistGetList")

            db.AddInParameter(dbcomm, "@KnifeID", DbType.String, KnifeID)
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of KnifeTypeGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeTypeGroup(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function KnifeMaterialCode_GetList(ByVal M_Code As String, ByVal KnifeID As String, ByVal Type3ID As String) As List(Of KnifeTypeGroupInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeMaterialCode_GetList")

            db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbcomm, "@KnifeID", DbType.String, KnifeID)
            db.AddInParameter(dbcomm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of KnifeTypeGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillKnifeTypeGroup(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 更新物料表的中刀具自定義規格
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="KnifeID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeMaterialCode_UpdateType(ByVal M_Code As String, ByVal KnifeID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeMaterialCode_UpdateType")

                db.AddInParameter(dbcomm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbcomm, "@KnifeID", DbType.String, KnifeID)

                db.ExecuteNonQuery(dbcomm)
                KnifeMaterialCode_UpdateType = True
            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeMaterialCode_UpdateType = False
            End Try
        End Function

#End Region


    End Class
End Namespace
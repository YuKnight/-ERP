Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.BomGroup
    Public Class BOMGroupController
        Friend Function FillBOMGroup(ByVal reader As IDataReader) As BOMGroupInfo
            Dim objInfo As New BOMGroupInfo

            If reader("AutoID") Is DBNull.Value Then
                objInfo.AutoID = Nothing
            Else
                objInfo.AutoID = reader("AutoID")
            End If

            If reader("ParentAutoID") Is DBNull.Value Then
                objInfo.ParentAutoID = Nothing
            Else
                objInfo.ParentAutoID = reader("ParentAutoID")
            End If

            If reader("GroupNumber") Is DBNull.Value Then
                objInfo.GroupNumber = Nothing
            Else
                objInfo.GroupNumber = reader("GroupNumber")
            End If

            If reader("GroupName") Is DBNull.Value Then
                objInfo.GroupName = Nothing
            Else
                objInfo.GroupName = reader("GroupName")
            End If

            If reader("GroupParentID") Is DBNull.Value Then
                objInfo.GroupParentID = Nothing
            Else
                objInfo.GroupParentID = reader("GroupParentID").ToString
            End If

            If reader("GroupParentName") Is DBNull.Value Then
                objInfo.GroupParentName = Nothing
            Else
                objInfo.GroupParentName = reader("GroupParentName").ToString
            End If

            If reader("CreateUserID") Is DBNull.Value Then
                objInfo.CreateUserID = Nothing
            Else
                objInfo.CreateUserID = reader("CreateUserID").ToString
            End If

            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = String.Empty
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If

            If reader("ModifyUserID") Is DBNull.Value Then
                objInfo.ModifyUserID = Nothing
            Else
                objInfo.ModifyUserID = reader("ModifyUserID").ToString
            End If

            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = String.Empty
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            Return objInfo
        End Function



        Public Function BOMGroup_GetList(ByVal AutoID As String, ByVal GroupNumber As String, ByVal ParentAutoID As String) As List(Of BOMGroupInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("BOMGroup_GetList")
            db.AddInParameter(dbComm, "@ParentAutoID", DbType.Int32, ParentAutoID)
            db.AddInParameter(dbComm, "@AutoID", DbType.Int32, AutoID)
            db.AddInParameter(dbComm, "@GroupNumber", DbType.String, GroupNumber)
            Dim FeatureList As New List(Of BOMGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBOMGroup(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function BOMGroup_Delete(ByVal AutoID As String, ByVal GroupParentID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("BOMGroup_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                db.AddInParameter(dbComm, "@GroupParentID", DbType.Decimal, GroupParentID)
                db.ExecuteNonQuery(dbComm)
                BOMGroup_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                BOMGroup_Delete = False
            End Try
        End Function

        Public Function BOMGroup_Update(ByVal objinfo As BOMGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)

                Dim dbComm As DbCommand = db.GetStoredProcCommand("BOMGroup_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.Int32, objinfo.AutoID)
                db.AddInParameter(dbComm, "@GroupNumber", DbType.String, objinfo.GroupNumber)
                db.AddInParameter(dbComm, "@GroupName", DbType.String, objinfo.GroupName)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                If objinfo.CreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                End If
                db.ExecuteNonQuery(dbComm)
                BOMGroup_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                BOMGroup_Update = False
            End Try
        End Function


        Public Function BOMGroup_Add(ByVal objInfo As BOMGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("BOMGroup_Add")
                db.AddInParameter(dbComm, "@GroupNumber", DbType.String, objInfo.GroupNumber)
                db.AddInParameter(dbComm, "@GroupName", DbType.String, objInfo.GroupName)
                db.AddInParameter(dbComm, "@ParentAutoID", DbType.Int32, objInfo.ParentAutoID)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                If objInfo.CreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                End If
                db.ExecuteNonQuery(dbComm)
                BOMGroup_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                BOMGroup_Add = False
            End Try
        End Function
    End Class
End Namespace
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.KnifeWare
    Public Class KnifeWhiteUserController

        ''' <summary>
        ''' 功能：增加白名單
        ''' 添加人：丁華普
        ''' 添加日期：2013-07-01
        ''' </summary>
        ''' <param name="winfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUser_Add(ByVal winfo As KnifeWhiteUserInfo) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_Add")

                db.AddInParameter(dbcomm, "@DPT_ID", DbType.String, winfo.DPT_ID)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, winfo.WH_ID)
                db.AddInParameter(dbcomm, "@W_UserID", DbType.String, winfo.W_UserID)
                db.AddInParameter(dbcomm, "@W_UserName", DbType.String, winfo.W_UserName)
                db.AddInParameter(dbcomm, "@W_Remark", DbType.String, winfo.W_Remark)
                db.AddInParameter(dbcomm, "@DepName", DbType.String, winfo.DepName)
                db.AddInParameter(dbcomm, "@FacName", DbType.String, winfo.FacName)
                db.AddInParameter(dbcomm, "@WType", DbType.String, winfo.WType)
                db.AddInParameter(dbcomm, "@WMax", DbType.Double, winfo.WMax)
                db.AddInParameter(dbcomm, "@GNO", DbType.String, winfo.GNO)
                db.AddInParameter(dbcomm, "@QuitBit", DbType.Boolean, winfo.QuitBit)

                db.ExecuteNonQuery(dbcomm)
                WhiteUser_Add = True

            Catch ex As Exception

                MsgBox(ex.Message)
                WhiteUser_Add = False

            End Try
        End Function


        Public Function WhiteUser_Delete(ByVal AutoID As String) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbcomm)
                WhiteUser_Delete = True

            Catch ex As Exception

                MsgBox(ex.Message)
                WhiteUser_Delete = False

            End Try
        End Function

        ''' <summary>
        ''' 功能：修改數據
        ''' 添加人：丁華普
        ''' 添加日期：2013-07-01
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUser_Update(ByVal AutoID As String, ByVal W_Remark As String, ByVal WMax As Double) As Boolean
            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbcomm, "@W_Remark", DbType.String, W_Remark)
                db.AddInParameter(dbcomm, "@WMax", DbType.Double, WMax)

                db.ExecuteNonQuery(dbcomm)
                WhiteUser_Update = True

            Catch ex As Exception

                MsgBox(ex.Message)
                WhiteUser_Update = False

            End Try
        End Function

        'WhiteUser_UpdateGNO

        Public Function WhiteUser_UpdateGNO(ByVal AutoID As String, ByVal GNO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_UpdateGNO")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbcomm, "@GNO", DbType.String, GNO)

                db.ExecuteNonQuery(dbcomm)
                WhiteUser_UpdateGNO = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WhiteUser_UpdateGNO = False
            End Try
        End Function

        ''' <summary>
        ''' 功能：批量更新
        ''' 添加人：丁華普
        ''' 添加日期：2013-07-03
        ''' </summary>
        ''' <param name="W_UserID"></param>
        ''' <param name="W_UserName"></param>
        ''' <param name="FacName"></param>
        ''' <param name="DepName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUser_AllUpdate(ByVal W_UserID As String, ByVal W_UserName As String, ByVal FacName As String, ByVal DepName As String, ByVal AutoID As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_AllUpdate")

                db.AddInParameter(dbcomm, "@W_UserID", DbType.String, W_UserID)
                db.AddInParameter(dbcomm, "@W_UserName", DbType.String, W_UserName)
                db.AddInParameter(dbcomm, "@FacName", DbType.String, FacName)
                db.AddInParameter(dbcomm, "@DepName", DbType.String, DepName)
                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbcomm)
                WhiteUser_AllUpdate = True

            Catch ex As Exception

                MsgBox(ex.Message)
                WhiteUser_AllUpdate = False

            End Try

        End Function

        ''' <summary>
        ''' 功能：獲取白名單數據表中的數據
        ''' 添加人：丁華普
        ''' 添加日期：2013-07-01 
        ''' </summary>
        ''' <param name="W_UserID"></param>
        ''' <param name="WH_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUser_GetList(ByVal AutoID As String, ByVal W_UserID As String, ByVal WH_ID As String, ByVal KnifeWare As String, ByVal GNO As String, ByVal QuitBit As String) As List(Of KnifeWhiteUserInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_GetList")

            db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbcomm, "@W_UserID", DbType.String, W_UserID)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@KnifeWare", DbType.String, KnifeWare)
            db.AddInParameter(dbcomm, "@GNO", DbType.String, GNO)
            db.AddInParameter(dbcomm, "@QuitBit", DbType.String, QuitBit)

            Dim FeatureList As New List(Of KnifeWhiteUserInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillWhiteUser(reader))
                End While
            End Using
            Return FeatureList
        End Function
        ''' <summary>
        ''' '功能：獲取所有白名單數據表中的數據
        ''' '添加人：姚駿
        ''' '添加日期：2013-11-07 
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="W_UserID"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="KnifeWare"></param>
        ''' <param name="GNO"></param>
        ''' <param name="QuitBit"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUser_GetListAll(ByVal AutoID As String, ByVal W_UserID As String, ByVal WH_ID As String, ByVal KnifeWare As String, ByVal GNO As String, ByVal QuitBit As String) As List(Of KnifeWhiteUserInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_GetListAll")

            db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbcomm, "@W_UserID", DbType.String, W_UserID)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@KnifeWare", DbType.String, KnifeWare)
            db.AddInParameter(dbcomm, "@GNO", DbType.String, GNO)
            db.AddInParameter(dbcomm, "@QuitBit", DbType.String, QuitBit)

            Dim FeatureList As New List(Of KnifeWhiteUserInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillWhiteUser(reader))
                End While
            End Using
            Return FeatureList
        End Function

        ''' <summary>
        ''' 功能:獲取刀具領取歸還記錄的白名單
        ''' 添加人:姚駿
        ''' 添加日期:2013-11-14
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="W_UserID"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="KnifeWare"></param>
        ''' <param name="GNO"></param>
        ''' <param name="QuitBit"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUserSeting_GetListAll(ByVal AutoID As String, ByVal W_UserID As String, ByVal WH_ID As String, ByVal KnifeWare As String, ByVal GNO As String, ByVal wh_Name As String, ByVal QuitBit As String) As List(Of KnifeWhiteUserInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUserSeting_GetListAll")

            db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbcomm, "@W_UserID", DbType.String, W_UserID)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@KnifeWare", DbType.String, KnifeWare)
            db.AddInParameter(dbcomm, "@GNO", DbType.String, GNO)
            db.AddInParameter(dbcomm, "@WH_Name", DbType.String, wh_Name)
            db.AddInParameter(dbcomm, "@QuitBit", DbType.String, QuitBit)

            Dim FeatureList As New List(Of KnifeWhiteUserInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillWhiteUser(reader))
                End While
            End Using
            Return FeatureList
        End Function

        ''' <summary>
        ''' 功能：獲取廠別和部門
        ''' 添加人：姚駿
        ''' 添加日期：2014-05-28
        ''' </summary>
        ''' <param name="FacName"></param>
        ''' <param name="DepName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUserList_GetListByFacName(ByVal FacName As String, ByVal DepName As String) As List(Of KnifeWhiteUserInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUserList_GetListByFacName")

            db.AddInParameter(dbcomm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbcomm, "@DepName", DbType.String, DepName)

            Dim FeatureList As New List(Of KnifeWhiteUserInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillWhiteUser(reader))
                End While
            End Using
            Return FeatureList
        End Function

        ''' <summary>
        ''' 功能：模糊查詢獲取數據
        ''' 添加人：丁華普
        ''' 添加日期：2013-07-06
        ''' </summary>
        ''' <param name="W_UserID"></param>
        ''' <param name="W_UserName"></param>
        ''' <param name="FacName"></param>
        ''' <param name="DepName"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="WMax"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUser_SelectGetList(ByVal W_UserID As String, ByVal W_UserName As String, ByVal FacName As String, ByVal DepName As String, ByVal WH_ID As String, ByVal WMax As Double) As List(Of KnifeWhiteUserInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_SelectGetList")

            db.AddInParameter(dbcomm, "@W_UserID", DbType.String, W_UserID)
            db.AddInParameter(dbcomm, "@W_UserName", DbType.String, W_UserName)
            db.AddInParameter(dbcomm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbcomm, "@DepName", DbType.String, DepName)
            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@WMax", DbType.Double, WMax)
            'db.AddInParameter(dbcomm, "@KnifeWare", DbType.String, KnifeWare)

            Dim FeatureList As New List(Of KnifeWhiteUserInfo)

            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillWhiteUser(reader))
                End While
            End Using

            Return FeatureList

        End Function

        ''' <summary>
        ''' 功能：將讀到的數據寫入一個集合中
        ''' 添加人：丁華普
        ''' 添加日期：2013-07-01 
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillWhiteUser(ByVal reader As IDataReader) As KnifeWhiteUserInfo

            Dim winfo As New KnifeWhiteUserInfo

            On Error Resume Next

            winfo.Per_ID = reader("Per_ID").ToString
            winfo.Per_Name = reader("Per_Name").ToString
            winfo.DPT_ID = reader("DPT_ID").ToString
            winfo.WH_ID = reader("WH_ID").ToString
            winfo.W_UserID = reader("W_UserID").ToString
            winfo.W_UserName = reader("W_UserName").ToString
            winfo.W_Remark = reader("W_Remark").ToString
            winfo.DepName = reader("DepName").ToString
            winfo.FacName = reader("FacName").ToString
            winfo.WType = reader("WType").ToString
            If IsDBNull(reader("WMax")) = True Then
                winfo.WMax = 0
            Else
                winfo.WMax = CDbl(reader("WMax").ToString)
            End If
            winfo.WH_Name = reader("WH_Name").ToString
            If reader("GNO").ToString = "init" Then
                winfo.GNO = ""
            Else
                winfo.GNO = reader("GNO").ToString
            End If
            winfo.GName = reader("GName").ToString
            winfo.AutoID = reader("AutoID").ToString
            winfo.QuitBit = reader("QuitBit")

            Return winfo

        End Function
        ''' <summary>
        ''' 辭工處理
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="QuitBit"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUser_QuitBitUpdate(ByVal AutoID As String, ByVal QuitBit As Boolean) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_QuitBitUpdate")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbcomm, "@QuitBit", DbType.Boolean, QuitBit)

                db.ExecuteNonQuery(dbcomm)
                WhiteUser_QuitBitUpdate = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WhiteUser_QuitBitUpdate = False
            End Try
        End Function

        ''' <summary>
        ''' 查詢夜班倉
        ''' </summary>
        ''' <param name="WH_ID"></param>
        ''' <param name="W_UserID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function WhiteUser_NightGetList(ByVal WH_ID As String, ByVal W_UserID As String) As List(Of KnifeWhiteUserInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_NightGetList")

            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@W_UserID", DbType.String, W_UserID)

            Dim FeatureList As New List(Of KnifeWhiteUserInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillWhiteUser(reader))
                End While
            End Using

            Return FeatureList

        End Function

        ''KnifeBorrowWhiteUser   載入未還完人員
        Public Function KnifeBorrowWhiteUser(ByVal WH_ID As String, ByVal G_NO As String) As List(Of KnifeWhiteUserInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetStoredProcCommand("KnifeBorrowWhiteUser")

            db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbcomm, "@G_NO", DbType.String, G_NO)

            Dim FeatureList As New List(Of KnifeWhiteUserInfo)
            Using reader As IDataReader = db.ExecuteReader(dbcomm)
                While reader.Read
                    FeatureList.Add(FillWhiteUser(reader))
                End While
            End Using

            Return FeatureList

        End Function


        '@W_UserID		     nvarchar(20),
        '	@WH_ID		         nvarchar(20),
        '	@GNO		         nvarchar(20)

        Public Function WhiteUser_UpdateGNOA(ByVal W_UserID As String, ByVal WH_ID As String, ByVal GNO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("WhiteUser_UpdateGNOA")

                db.AddInParameter(dbcomm, "@W_UserID", DbType.String, W_UserID)
                db.AddInParameter(dbcomm, "@WH_ID", DbType.String, WH_ID)
                db.AddInParameter(dbcomm, "@GNO", DbType.String, GNO)

                db.ExecuteNonQuery(dbcomm)
                WhiteUser_UpdateGNOA = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WhiteUser_UpdateGNOA = False
            End Try
        End Function





    End Class
End Namespace
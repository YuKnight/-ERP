Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
'Imports System.Data.Sql
Imports System.Windows.Forms
Namespace LFERP.Library.MaterialParam
    Public Class MaterialParamController

#Region "物料參數詳細"
        ''' <summary>
        ''' 建立新的物料參數,需先調用MaterialParam_Delete刪除原有數據然后再建立新參數
        ''' </summary>
        ''' <param name="objMaterialParamInfo"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MaterialParam_Add(ByVal objMaterialParamInfo As MaterialParamInfo) As Boolean
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialParam_Add")
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, objMaterialParamInfo.Type3ID)
            db.AddInParameter(dbComm, "@ParamID", DbType.String, objMaterialParamInfo.ParamID)
            db.AddInParameter(dbComm, "@ParamName", DbType.String, objMaterialParamInfo.ParamName)
            db.AddInParameter(dbComm, "@ParamGauge", DbType.String, objMaterialParamInfo.ParamGauge)
            db.ExecuteNonQuery(dbComm)
        End Function

        Public Function MaterialParam_Get(ByVal Type3ID As String) As List(Of MaterialParamInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialParam_Get")
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
            Dim FeatureList As New List(Of MaterialParamInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialParamInfo(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillMaterialParamInfo(ByVal reader As IDataReader) As MaterialParamInfo
            '對應取得的數據
            Dim objMaterialParamInfo As New MaterialParamInfo
            objMaterialParamInfo.Type3ID = reader("Type3ID").ToString
            objMaterialParamInfo.ParamID = reader("ParamID").ToString
            objMaterialParamInfo.ParamName = reader("ParamName").ToString
            objMaterialParamInfo.ParamGauge = reader("ParamGauge").ToString
            Return objMaterialParamInfo
        End Function

        Public Function MaterialParam_Delete(ByVal Type3ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialParam_Delete")
                db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)
                db.ExecuteNonQuery(dbComm)
                MaterialParam_Delete = True
            Catch ex As Exception
                MaterialParam_Delete = False
            End Try
        End Function

#End Region

#Region "物料規格"
        Public Function MaterialParamType_Add(ByVal objMaterialParamTypeInfo As MaterialParamTypeInfo) As Boolean
            '檢查物料編碼編號是否已存在
            Dim objMaterialInfo As MaterialParamTypeInfo = MaterialParamType_Get(objMaterialParamTypeInfo.ParamTypeID)
            If objMaterialInfo Is Nothing Then
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialParamType_Add")
                db.AddInParameter(dbComm, "@ParamTypeName", DbType.String, objMaterialParamTypeInfo.ParamTypeName)
                db.AddInParameter(dbComm, "@ParamTypeGauge", DbType.String, objMaterialParamTypeInfo.ParamTypeGauge)

                db.ExecuteNonQuery(dbComm)
                MaterialParamType_Add = True
            Else
                MaterialParamType_Add = False
            End If
        End Function
        Public Function MaterialParamType_Get(ByVal ParamTypeID As Integer) As MaterialParamTypeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialParamType_Get")
            db.AddInParameter(dbComm, "@ParamTypeID", DbType.Int16, ParamTypeID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillMaterialParamType(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function MaterialParamType_GetList() As List(Of MaterialParamTypeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialParamType_Get")
            db.AddInParameter(dbComm, "@ParamTypeID", DbType.Int16, DBNull.Value)
            Dim FeatureList As New List(Of MaterialParamTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMaterialParamType(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Friend Function FillMaterialParamType(ByVal reader As IDataReader) As MaterialParamTypeInfo
            '對應取得的數據
            Dim objMaterialParamTypeInfo As New MaterialParamTypeInfo
            objMaterialParamTypeInfo.ParamTypeID = CInt(reader("ParamTypeID"))
            objMaterialParamTypeInfo.ParamTypeName = reader("ParamTypeName").ToString
            objMaterialParamTypeInfo.ParamTypeGauge = reader("ParamTypeGauge").ToString
            Return objMaterialParamTypeInfo
        End Function
        Public Function MaterialParamType_Update(ByVal objMaterialParamTypeInfo As MaterialParamTypeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialParamType_Update")
                db.AddInParameter(dbComm, "@ParamTypeID", DbType.Int16, objMaterialParamTypeInfo.ParamTypeID)
                db.AddInParameter(dbComm, "@ParamTypeName", DbType.String, objMaterialParamTypeInfo.ParamTypeName)
                db.AddInParameter(dbComm, "@ParamTypeGauge", DbType.String, objMaterialParamTypeInfo.ParamTypeGauge)

                db.ExecuteNonQuery(dbComm)
                MaterialParamType_Update = True
            Catch ex As Exception
                MaterialParamType_Update = False
            End Try

        End Function
        Public Function MaterialParamType_Delete(ByVal ParamTypeID As Integer) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MaterialParamType_Delete")
                db.AddInParameter(dbComm, "@ParamTypeID", DbType.Int16, ParamTypeID)
                db.ExecuteNonQuery(dbComm)
                MaterialParamType_Delete = True
            Catch ex As Exception
                MaterialParamType_Delete = False
            End Try
        End Function

#End Region


    End Class
End Namespace


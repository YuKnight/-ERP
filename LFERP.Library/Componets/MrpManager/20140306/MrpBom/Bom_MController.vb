Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.Bom_M
    Public Class Bom_MController
        Friend Function FillBom_M(ByVal reader As IDataReader) As Bom_MInfo
            On Error Resume Next
            Dim objInfo As New Bom_MInfo
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.ParentGroup = reader("ParentGroup").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.SourceID = reader("SourceID").ToString
            objInfo.M_Source = reader("M_Source").ToString
            If IsDBNull(reader("CheckDate")) = True Then
                objInfo.CheckDate = Nothing
            Else
                objInfo.CheckDate = Format(CDate(reader("CheckDate")), "yyyy/MM/dd")
            End If
            objInfo.M_Unit = reader("M_Unit").ToString
            If IsDBNull(reader("EffectiveDate")) = True Then
                objInfo.EffectiveDate = Nothing
            Else
                objInfo.EffectiveDate = Format(CDate(reader("EffectiveDate")), "yyyy/MM/dd")
            End If
            If IsDBNull(reader("InvalidDate")) = True Then
                objInfo.InvalidDate = Nothing
            Else
                objInfo.InvalidDate = Format(CDate(reader("InvalidDate")), "yyyy/MM/dd")
            End If
            objInfo.Version = reader("Version").ToString
            objInfo.CheckUserID = reader("CheckUserID").ToString

            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.CheckUserName = reader("CheckUserName").ToString

            objInfo.CheckBit = reader("CheckBit")
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If IsDBNull(reader("CreateDate")) = True Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If IsDBNull(reader("ModifyDate")) = True Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            Return objInfo
        End Function



        Public Function Bom_M_GetList(ByVal ParentGroup As String, ByVal Version As String, ByVal BeginDate As String, ByVal CheckType As String, ByVal CreateUserID As String, ByVal SourceID As String) As List(Of Bom_MInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_GetList")
            db.AddInParameter(dbComm, "@ParentGroup", DbType.String, ParentGroup)
            db.AddInParameter(dbComm, "@Version", DbType.String, Version)
            db.AddInParameter(dbComm, "@SourceID", DbType.String, SourceID)
            db.AddInParameter(dbComm, "@BeginDate", DbType.DateTime, BeginDate)
            db.AddInParameter(dbComm, "@CheckType", DbType.String, CheckType)
            db.AddInParameter(dbComm, "@CreateUserID", DbType.String, CreateUserID)
            Dim FeatureList As New List(Of Bom_MInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBom_M(reader))
                End While
                Return FeatureList
            End Using
        End Function

        'Public Function Bom_M_GetListSelect(ByVal ParentGroup As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal SourceID As String, ByVal EffectiveDate1 As String, ByVal EffectiveDate2 As String, ByVal InvalidDate1 As String, ByVal InvalidDate2 As String, ByVal CheckBit As String) As List(Of Bom_MInfo)
        '    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        '    Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_GetListSelect")
        '    db.AddInParameter(dbComm, "@ParentGroup", DbType.String, ParentGroup)
        '    db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
        '    db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
        '    db.AddInParameter(dbComm, "@SourceID", DbType.String, SourceID)
        '    db.AddInParameter(dbComm, "@EffectiveDate1", DbType.Date, EffectiveDate1)
        '    db.AddInParameter(dbComm, "@EffectiveDate2", DbType.Date, EffectiveDate2)
        '    db.AddInParameter(dbComm, "@InvalidDate1", DbType.Date, InvalidDate1)
        '    db.AddInParameter(dbComm, "@InvalidDate2", DbType.Date, InvalidDate2)
        '    db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
        '    Dim FeatureList As New List(Of Bom_MInfo)
        '    Using reader As IDataReader = db.ExecuteReader(dbComm)
        '        While reader.Read
        '            FeatureList.Add(FillBom_M(reader))
        '        End While
        '        Return FeatureList
        '    End Using
        'End Function


        Public Function Bom_M_Delete(ByVal AutoID As Decimal, ByVal ParentGroup As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                db.AddInParameter(dbComm, "@ParentGroup", DbType.String, ParentGroup)
                db.ExecuteNonQuery(dbComm)
                Bom_M_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_M_Delete = False
            End Try
        End Function


        Public Function Bom_M_Update(ByVal objinfo As Bom_MInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_Update")
                'db.AddInParameter(dbComm, "@SourceID", DbType.String, objinfo.SourceID)
                'db.AddInParameter(dbComm, "@EffectiveDate", DbType.DateTime, objinfo.EffectiveDate)
                db.AddInParameter(dbComm, "@InvalidDate", DbType.DateTime, objinfo.InvalidDate)
                db.AddInParameter(dbComm, "@Version", DbType.String, objinfo.Version)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                Bom_M_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_M_Update = False
            End Try
        End Function

        Public Function Bom_M_Check(ByVal objinfo As Bom_MInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_Check")
                db.AddInParameter(dbComm, "@CheckDate", DbType.Date, objinfo.CheckDate)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                Bom_M_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_M_Check = False
            End Try
        End Function


        Public Function Bom_M_Add(ByVal objInfo As Bom_MInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_Add")
                db.AddInParameter(dbComm, "@ParentGroup", DbType.String, objInfo.ParentGroup)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objInfo.M_Gauge)
                'db.AddInParameter(dbComm, "@SourceID", DbType.String, objInfo.SourceID)
                'db.AddInParameter(dbComm, "@ProductionUnit", DbType.String, objInfo.ProductionUnit)
                db.AddInParameter(dbComm, "@EffectiveDate", DbType.DateTime, objInfo.EffectiveDate)
                'db.AddInParameter(dbComm, "@InvalidDate", DbType.DateTime, objInfo.InvalidDate)
                db.AddInParameter(dbComm, "@Version", DbType.String, objInfo.Version)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objInfo.CheckBit)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                db.ExecuteNonQuery(dbComm)
                Bom_M_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_M_Add = False
            End Try
        End Function
    End Class
End Namespace
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
            objInfo.SoureName = reader("SoureName").ToString
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
            objInfo.Version = reader("Version")
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
            objInfo.BomNumber = reader("BomNumber").ToString
            objInfo.GroupAutoID = reader("GroupAutoID").ToString
            objInfo.GroupNumber = reader("GroupNumber").ToString
            objInfo.GroupName = reader("GroupName").ToString
            objInfo.UseStatus = reader("UseStatus")
            objInfo.Qty = reader("Qty")
            objInfo.Yield = reader("Yield")
            objInfo.CustomerNumber = reader("CustomerNumber").ToString
            Return objInfo
        End Function

        Public Function Bom_M_GetList(ByVal AutoID As String, ByVal GroupAutoID As Integer, ByVal BomNumber As String, ByVal ParentGroup As String, ByVal Version As String, ByVal BeginDate As String, ByVal EndDate As String, ByVal CheckType As String, ByVal CreateUserID As String, ByVal CheckBit As String, ByVal UseStatus As String, ByVal DisplayNum As String) As List(Of Bom_MInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_GetList")
            If AutoID <> Nothing Then
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
            End If
            If GroupAutoID <> 0 Then
                db.AddInParameter(dbComm, "@GroupAutoID", DbType.Int32, GroupAutoID)
            End If
            If BomNumber <> Nothing Then
                db.AddInParameter(dbComm, "@BomNumber", DbType.String, BomNumber)
            End If
            If ParentGroup <> Nothing Then
                db.AddInParameter(dbComm, "@ParentGroup", DbType.String, ParentGroup)
            End If
            If Version <> Nothing Then
                db.AddInParameter(dbComm, "@Version", DbType.Int32, Version)
            End If
            If BeginDate <> Nothing Then
                db.AddInParameter(dbComm, "@BeginDate", DbType.DateTime, BeginDate)
            End If
            If EndDate <> Nothing Then
                db.AddInParameter(dbComm, "@EndDate", DbType.DateTime, EndDate)
            End If
            If CheckType <> Nothing Then
                db.AddInParameter(dbComm, "@CheckType", DbType.String, CheckType)
            End If
            If UseStatus <> Nothing Then
                db.AddInParameter(dbComm, "@UseStatus", DbType.Boolean, UseStatus)
            End If
            If CreateUserID <> Nothing Then
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, CreateUserID)
            End If
            If CheckBit <> Nothing Then
                db.AddInParameter(dbComm, "@CheckBit ", DbType.Boolean, CheckBit)
            End If
            db.AddInParameter(dbComm, "@DisplayNum ", DbType.Decimal, DisplayNum)
            Dim FeatureList As New List(Of Bom_MInfo)
            Try
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    While reader.Read
                        FeatureList.Add(FillBom_M(reader))
                    End While
                    Return FeatureList
                End Using
            Catch ex As Exception

            End Try
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


        Public Function Bom_M_PreDelete(ByVal ParentGroup As String) As Boolean
            Dim list As New List(Of String)
            list.Add("select ForecastID from MrpForecastOrder where M_Code ='" + ParentGroup + "'")
            list.Add("的預測訂單中存在該產品編號(" + ParentGroup + ")，無法刪除")

            list.Add("select MO from MrpMps where M_Code ='" + ParentGroup + "'")
            list.Add("的主生產計劃中存在該產品編號(" + ParentGroup + ")，無法刪除")

            list.Add("select MRP_ID  from MrpIndReq where M_Code ='" + ParentGroup + "'")
            list.Add("的需求運算中存在該產品編號(" + ParentGroup + ")，無法刪除")

            Return MRP_PreDelete(list)
        End Function

        Public Function Bom_M_Delete(ByVal AutoID As Decimal, ByVal ParentGroup As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_Delete")
                If AutoID = Nothing Then
                    db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, Nothing)
                Else
                    db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                End If
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
                db.AddInParameter(dbComm, "@InvalidDate", DbType.DateTime, objinfo.InvalidDate)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                db.AddInParameter(dbComm, "@CustomerNumber", DbType.String, objinfo.CustomerNumber)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objinfo.Qty)
                db.AddInParameter(dbComm, "@Yield", DbType.Decimal, objinfo.Yield)
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
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                Bom_M_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_M_Check = False
            End Try
        End Function


        Public Function Bom_M_Add(ByVal objInfo As Bom_MInfo) As Int32
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_Add")
                db.AddInParameter(dbComm, "@ParentGroup", DbType.String, objInfo.ParentGroup)
                db.AddInParameter(dbComm, "@EffectiveDate", DbType.DateTime, objInfo.EffectiveDate)
                db.AddInParameter(dbComm, "@Version", DbType.Int32, objInfo.Version)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                db.AddInParameter(dbComm, "@BomNumber", DbType.String, objInfo.BomNumber)
                db.AddInParameter(dbComm, "@CustomerNumber", DbType.String, objInfo.CustomerNumber)
                db.AddInParameter(dbComm, "@GroupAutoID", DbType.Int32, objInfo.GroupAutoID)
                db.AddInParameter(dbComm, "@UseStatus", DbType.Boolean, objInfo.UseStatus)
                db.AddInParameter(dbComm, "@Qty", DbType.Decimal, objInfo.Qty)
                db.AddInParameter(dbComm, "@Yield", DbType.Decimal, objInfo.Yield)
                Bom_M_Add = CInt(db.ExecuteScalar(dbComm))
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_M_Add = 0
            End Try
        End Function

        Public Function Bom_M_IsChecked(ByVal parentGroup As String) As Boolean
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetSqlStringCommand("select CheckBit from Bom_M where ParentGroup='" + parentGroup + "'")
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return reader("CheckBit")
                End While
            End Using
        End Function
        '鄭少釗新增----
        Public Function BOM_M_GetBomNumber(ByVal BOM As String) As String
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("BOM_M_GetBomNumber")
            Dim BomNumber As String = ""
            db.AddInParameter(dbComm, "@BOM", DbType.String, BOM)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    BomNumber = IIf(IsDBNull(reader("BomNumber")), String.Empty, reader("BomNumber").ToString)
                End While
                Return BomNumber
            End Using
        End Function
        '---------
        Public Function Bom_M_UpdateUseStatus(ByVal AutoID As String, ByVal UseStatus As Boolean) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Bom_M_UpdateUseStatus")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@UseStatus", DbType.Boolean, UseStatus)
                '-----------------
                db.ExecuteNonQuery(dbComm)
                Bom_M_UpdateUseStatus = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Bom_M_UpdateUseStatus = False
            End Try
        End Function

    End Class
End Namespace
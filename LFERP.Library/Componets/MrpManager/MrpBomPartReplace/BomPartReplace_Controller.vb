Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.BomPartReplace
    Public Class BomPartReplaceController
        Friend Function FillBomPartReplace(ByVal reader As IDataReader) As BomPartReplaceInfo
            Dim objInfo As New BomPartReplaceInfo

            If reader("AutoID") Is DBNull.Value Then
                objInfo.AutoID = Nothing
            Else
                objInfo.AutoID = CInt(reader("AutoID").ToString)
            End If

            If reader("PartReplaceNumber") Is DBNull.Value Then
                objInfo.PartReplaceNumber = Nothing
            Else
                objInfo.PartReplaceNumber = reader("PartReplaceNumber").ToString
            End If

            If reader("OldPartNumber") Is DBNull.Value Then
                objInfo.OldPartNumber = Nothing
            Else
                objInfo.OldPartNumber = reader("OldPartNumber").ToString
            End If

            If reader("OldPart_M_Name") Is DBNull.Value Then
                objInfo.OldPart_M_Name = Nothing
            Else
                objInfo.OldPart_M_Name = reader("OldPart_M_Name").ToString
            End If

            If reader("OldPart_M_Gauge") Is DBNull.Value Then
                objInfo.OldPart_M_Gauge = Nothing
            Else
                objInfo.OldPart_M_Gauge = reader("OldPart_M_Gauge").ToString
            End If

            If reader("OldPart_M_Unit") Is DBNull.Value Then
                objInfo.OldPart_M_Unit = Nothing
            Else
                objInfo.OldPart_M_Unit = reader("OldPart_M_Unit").ToString
            End If

            If reader("OldPart_SoureName") Is DBNull.Value Then
                objInfo.OldPart_SoureName = Nothing
            Else
                objInfo.OldPart_SoureName = reader("OldPart_SoureName").ToString
            End If

            If reader("NewPartNumber") Is DBNull.Value Then
                objInfo.NewPartNumber = Nothing
            Else
                objInfo.NewPartNumber = reader("NewPartNumber").ToString
            End If

            If reader("NewPart_M_Name") Is DBNull.Value Then
                objInfo.NewPart_M_Name = Nothing
            Else
                objInfo.NewPart_M_Name = reader("NewPart_M_Name").ToString
            End If

            If reader("NewPart_M_Gauge") Is DBNull.Value Then
                objInfo.NewPart_M_Gauge = Nothing
            Else
                objInfo.NewPart_M_Gauge = reader("NewPart_M_Gauge").ToString
            End If

            If reader("NewPart_M_Unit") Is DBNull.Value Then
                objInfo.NewPart_M_Unit = Nothing
            Else
                objInfo.NewPart_M_Unit = reader("NewPart_M_Unit").ToString
            End If

            If reader("NewPart_SoureName") Is DBNull.Value Then
                objInfo.NewPart_SoureName = Nothing
            Else
                objInfo.NewPart_SoureName = reader("NewPart_SoureName").ToString
            End If

            If reader("TwoWayReplace") Is DBNull.Value Then
                objInfo.TwoWayReplace = Nothing
            Else
                objInfo.TwoWayReplace = reader("TwoWayReplace")
            End If
            If reader("EffectiveDate") Is DBNull.Value Then
                objInfo.EffectiveDate = Nothing
            Else
                objInfo.EffectiveDate = Format(CDate(reader("EffectiveDate")), "yyyy/MM/dd")
            End If

            If reader("BOMNumber") Is DBNull.Value Then
                objInfo.BOMNumber = Nothing
            Else
                objInfo.BOMNumber = reader("BOMNumber").ToString
            End If

            If reader("BOMAutoID") Is DBNull.Value Then
                objInfo.BOMAutoID = Nothing
            Else
                objInfo.BOMAutoID = CDbl(reader("BOMAutoID").ToString)
            End If

            If reader("OldQty") Is DBNull.Value Then
                objInfo.OldQty = Nothing
            Else
                objInfo.OldQty = CDbl(reader("OldQty").ToString)
            End If

            If reader("NewQty") Is DBNull.Value Then
                objInfo.NewQty = Nothing
            Else
                objInfo.NewQty = CDbl(reader("NewQty").ToString)
            End If

            If reader("Status") Is DBNull.Value Then
                objInfo.Status = Nothing
            Else
                objInfo.Status = reader("Status")
            End If

            If reader("Percentage") Is DBNull.Value Then
                objInfo.Percentage = Nothing
            Else
                objInfo.Percentage = CDbl(reader("Percentage").ToString)
            End If

            If reader("Remark") Is DBNull.Value Then
                objInfo.Remark = Nothing
            Else
                objInfo.Remark = reader("Remark")
            End If

            If reader("CreateUserID") Is DBNull.Value Then
                objInfo.CreateUserID = Nothing
            Else
                objInfo.CreateUserID = reader("CreateUserID")
            End If

            If reader("CreateUserName") Is DBNull.Value Then
                objInfo.CreateUserName = Nothing
            Else
                objInfo.CreateUserName = reader("CreateUserName")
            End If

            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If

            If reader("ModifyUserID") Is DBNull.Value Then
                objInfo.ModifyUserID = Nothing
            Else
                objInfo.ModifyUserID = reader("ModifyUserID")
            End If

            If reader("ModifyUserName") Is DBNull.Value Then
                objInfo.ModifyUserName = Nothing
            Else
                objInfo.ModifyUserName = reader("ModifyUserName")
            End If

            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If

            If reader("CheckBit") Is DBNull.Value Then
                objInfo.CheckBit = Nothing
            Else
                objInfo.CheckBit = reader("CheckBit")
            End If

            If reader("CheckUserID") Is DBNull.Value Then
                objInfo.CheckUserID = Nothing
            Else
                objInfo.CheckUserID = reader("CheckUserID")
            End If

            If reader("CheckUserName") Is DBNull.Value Then
                objInfo.CheckUserName = Nothing
            Else
                objInfo.CheckUserName = reader("CheckUserName")
            End If

            If reader("CheckDate") Is DBNull.Value Then
                objInfo.CheckDate = Nothing
            Else
                objInfo.CheckDate = Format(CDate(reader("CheckDate")), "yyyy/MM/dd")
            End If

            If reader("CheckRemark") Is DBNull.Value Then
                objInfo.CheckRemark = Nothing
            Else
                objInfo.CheckRemark = reader("CheckRemark")
            End If

            Return objInfo
        End Function



        Public Function BomPartReplace_GetList(ByVal AutoID As String, ByVal PartReplaceNumber As String, ByVal BOMAutoID As String, ByVal OldPartNumber As String, ByVal NewPartNumber As String, ByVal TwoWayReplace As String, ByVal EffectiveDate As String, ByVal Status As String, ByVal CheckBit As String) As List(Of BomPartReplaceInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("BomPartReplace_GetList")
            db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
            db.AddInParameter(dbComm, "@PartReplaceNumber", DbType.String, PartReplaceNumber)
            db.AddInParameter(dbComm, "@BOMAutoID", DbType.Decimal, BOMAutoID)
            db.AddInParameter(dbComm, "@OldPartNumber", DbType.String, OldPartNumber)
            db.AddInParameter(dbComm, "@NewPartNumber", DbType.String, NewPartNumber)
            db.AddInParameter(dbComm, "@TwoWayReplace", DbType.Boolean, TwoWayReplace)
            db.AddInParameter(dbComm, "@EffectiveDate", DbType.DateTime, EffectiveDate)
            db.AddInParameter(dbComm, "@Status", DbType.Boolean, Status)
            db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
            Dim FeatureList As New List(Of BomPartReplaceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillBomPartReplace(reader))
                End While
                Return FeatureList
            End Using
        End Function




        Public Function BomPartReplace_Delete(ByVal BOMAutoID As Decimal, ByVal OldPartNumber As String, ByVal NewPartNumber As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("BomPartReplace_Delete")
                db.AddInParameter(dbComm, "@BOMAutoID", DbType.Decimal, BOMAutoID)
                db.AddInParameter(dbComm, "@OldPartNumber", DbType.String, OldPartNumber)
                db.AddInParameter(dbComm, "@NewPartNumber", DbType.String, NewPartNumber)
                db.ExecuteNonQuery(dbComm)
                BomPartReplace_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                BomPartReplace_Delete = False
            End Try
        End Function


        Public Function BomPartReplace_Update(ByVal objinfo As BomPartReplaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("BomPartReplace_Update")
                db.AddInParameter(dbComm, "@PartReplaceNumber", DbType.String, objinfo.PartReplaceNumber)
                db.AddInParameter(dbComm, "@OldPartNumber", DbType.String, objinfo.OldPartNumber)
                db.AddInParameter(dbComm, "@NewPartNumber", DbType.String, objinfo.NewPartNumber)
                db.AddInParameter(dbComm, "@TwoWayReplace", DbType.Boolean, objinfo.TwoWayReplace)
                db.AddInParameter(dbComm, "@EffectiveDate", DbType.DateTime, objinfo.EffectiveDate)
                db.AddInParameter(dbComm, "@BOMAutoID", DbType.String, objinfo.BOMAutoID)
                db.AddInParameter(dbComm, "@OldQty", DbType.Decimal, objinfo.OldQty)
                db.AddInParameter(dbComm, "@NewQty", DbType.Decimal, objinfo.NewQty)
                db.AddInParameter(dbComm, "@Status", DbType.Boolean, objinfo.Status)
                db.AddInParameter(dbComm, "@Percentage", DbType.Decimal, objinfo.Percentage)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objinfo.CreateUserID)
                If objinfo.CreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objinfo.CreateDate)
                End If
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                If objinfo.ModifyDate = Nothing Then
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                End If
                db.ExecuteNonQuery(dbComm)
                BomPartReplace_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                BomPartReplace_Update = False
            End Try
        End Function

        Public Function BomPartReplace_Check(ByVal objinfo As BomPartReplaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("BomPartReplace_Check")
                db.AddInParameter(dbComm, "@CheckDate", DbType.Date, objinfo.CheckDate)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                BomPartReplace_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                BomPartReplace_Check = False
            End Try
        End Function

        Public Function BomPartReplace_Add(ByVal objInfo As BomPartReplaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("BomPartReplace_Add")
                db.AddInParameter(dbComm, "@PartReplaceNumber", DbType.String, objInfo.PartReplaceNumber)
                db.AddInParameter(dbComm, "@OldPartNumber", DbType.String, objInfo.OldPartNumber)
                db.AddInParameter(dbComm, "@NewPartNumber", DbType.String, objInfo.NewPartNumber)
                db.AddInParameter(dbComm, "@TwoWayReplace", DbType.Boolean, objInfo.TwoWayReplace)
                db.AddInParameter(dbComm, "@EffectiveDate", DbType.DateTime, objInfo.EffectiveDate)
                db.AddInParameter(dbComm, "@BOMAutoID", DbType.String, objInfo.BOMAutoID)
                db.AddInParameter(dbComm, "@OldQty", DbType.Decimal, objInfo.OldQty)
                db.AddInParameter(dbComm, "@NewQty", DbType.Decimal, objInfo.NewQty)
                db.AddInParameter(dbComm, "@Status", DbType.Boolean, objInfo.Status)
                db.AddInParameter(dbComm, "@Percentage", DbType.Decimal, objInfo.Percentage)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                If objInfo.CreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                End If
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objInfo.ModifyUserID)
                If objInfo.ModifyDate = Nothing Then
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objInfo.ModifyDate)
                End If
                db.ExecuteNonQuery(dbComm)
                BomPartReplace_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                BomPartReplace_Add = False
            End Try
        End Function

        Public Function BomPartReplace_GetPartReplaceNumber(ByVal BPR As String) As String
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("BomPartReplace_GetPartReplaceNumber")
            'Dim ym, s, str As String
            Dim PartReplaceNumber As String = ""
            db.AddInParameter(dbComm, "@BPR", DbType.String, BPR)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    PartReplaceNumber = IIf(IsDBNull(reader("PartReplaceNumber")), String.Empty, reader("PartReplaceNumber").ToString)
                End While
                Return PartReplaceNumber
            End Using
        End Function
    End Class
End Namespace
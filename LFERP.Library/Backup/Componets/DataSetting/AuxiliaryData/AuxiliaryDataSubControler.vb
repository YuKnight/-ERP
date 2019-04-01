Namespace LFERP.DataSetting
    Public Class AuxiliaryDataSubControler
        Friend Function FillAuxiliaryDataSub(ByVal reader As IDataReader) As AuxiliaryDataSubInfo
            Dim objInfo As New AuxiliaryDataSubInfo
            objInfo.BasicSubType = reader("BasicSubType")
            objInfo.BasicSubName = reader("BasicSubName").ToString
            objInfo.BasicMainName = reader("BasicMainName").ToString
            objInfo.BasicSubDescription = reader("BasicSubDescription").ToString
            objInfo.BasicSubFieldType = reader("BasicSubFieldType").ToString
            If reader("BasicMainType") Is DBNull.Value Then
                objInfo.BasicMainType = Nothing
            Else
                objInfo.BasicMainType = CDbl(reader("BasicMainType").ToString)
            End If
            objInfo.Sequence = reader("Sequence").ToString
            If reader("IsEnable") Is DBNull.Value Then
                objInfo.IsEnable = Nothing
            Else
                objInfo.IsEnable = reader("IsEnable")
            End If
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If
            objInfo.Remark = reader("Remark").ToString
            If reader("IsSysDefault") Is DBNull.Value Then
                objInfo.IsSysDefault = Nothing
            Else
                objInfo.IsSysDefault = reader("IsSysDefault")
            End If
            Return objInfo
        End Function



        Public Function AuxiliaryDataSub_GetList(ByVal BasicSubType As Decimal, ByVal BasicSubName As String, ByVal BasicMainType As Decimal, ByVal Sequence As Int32) As List(Of AuxiliaryDataSubInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryDataSub_GetList")
            If BasicSubType <> 0 Then
                db.AddInParameter(dbComm, "@BasicSubType", DbType.Decimal, BasicSubType)
            End If
            db.AddInParameter(dbComm, "@BasicSubName", DbType.String, BasicSubName)
            If BasicMainType <> 0 Then
                db.AddInParameter(dbComm, "@BasicMainType", DbType.Decimal, BasicMainType)
            End If
            If Sequence <> 0 Then
                db.AddInParameter(dbComm, "@Sequence", DbType.Int32, Sequence)
            End If
            Dim FeatureList As New List(Of AuxiliaryDataSubInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillAuxiliaryDataSub(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function AuxiliaryDataSub_GetControlList(ByVal BasicMainType As Decimal) As DataTable
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim ds As New DataSet
            Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryDataSub_GetControlList")
            db.AddInParameter(dbComm, "@BasicMainType", DbType.Decimal, BasicMainType)
            ds = db.ExecuteDataSet(dbComm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function


        Public Function AuxiliaryDataSub_Delete(ByVal BasicSubType As Decimal, ByVal BasicMainType As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryDataSub_Delete")
                If BasicSubType <> 0 Then
                    db.AddInParameter(dbComm, "@BasicSubType", DbType.Decimal, BasicSubType)
                End If
                If BasicMainType <> 0 Then
                    db.AddInParameter(dbComm, "@BasicMainType", DbType.Decimal, BasicMainType)
                End If
                db.ExecuteNonQuery(dbComm)
                AuxiliaryDataSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                AuxiliaryDataSub_Delete = False
            End Try
        End Function


        Public Function AuxiliaryDataSub_Update(ByVal objinfo As AuxiliaryDataSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryDataSub_Update")
                db.AddInParameter(dbComm, "@BasicSubType", DbType.Decimal, objinfo.BasicSubType)
                db.AddInParameter(dbComm, "@BasicSubName", DbType.String, objinfo.BasicSubName)
                db.AddInParameter(dbComm, "@BasicSubDescription", DbType.String, objinfo.BasicSubDescription)
                db.AddInParameter(dbComm, "@BasicSubFieldType", DbType.String, objinfo.BasicSubFieldType)
                db.AddInParameter(dbComm, "@BasicMainType", DbType.Decimal, objinfo.BasicMainType)
                db.AddInParameter(dbComm, "@Sequence", DbType.Int64, objinfo.Sequence)
                db.AddInParameter(dbComm, "@IsEnable", DbType.Boolean, objinfo.IsEnable) 
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.ExecuteNonQuery(dbComm)
                AuxiliaryDataSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                AuxiliaryDataSub_Update = False
            End Try
        End Function

        Public Function AuxiliaryDataSub_Stop(ByVal BasicSubType As Decimal, ByVal IsEnable As Boolean) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryDataSub_Stop")
                db.AddInParameter(dbComm, "@BasicSubType", DbType.Decimal, BasicSubType)
                db.AddInParameter(dbComm, "@IsEnable", DbType.Boolean, IsEnable)
                db.ExecuteNonQuery(dbComm)
                AuxiliaryDataSub_Stop = True
            Catch ex As Exception
                MsgBox(ex.Message)
                AuxiliaryDataSub_Stop = False
            End Try
        End Function

        Public Function AuxiliaryDataSub_Add(ByVal objInfo As AuxiliaryDataSubInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryDataSub_Add")
                db.AddInParameter(dbComm, "@BasicSubName", DbType.String, objInfo.BasicSubName)
                db.AddInParameter(dbComm, "@BasicSubDescription", DbType.String, objInfo.BasicSubDescription)
                db.AddInParameter(dbComm, "@BasicSubFieldType", DbType.String, objInfo.BasicSubFieldType)
                db.AddInParameter(dbComm, "@BasicMainType", DbType.Decimal, objInfo.BasicMainType)
                db.AddInParameter(dbComm, "@Sequence", DbType.Int64, objInfo.Sequence)
                db.AddInParameter(dbComm, "@IsEnable", DbType.Boolean, objInfo.IsEnable)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)
                db.AddInParameter(dbComm, "@IsSysDefault", DbType.Boolean, objInfo.IsSysDefault)
                db.ExecuteNonQuery(dbComm)
                AuxiliaryDataSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                AuxiliaryDataSub_Add = False
            End Try
        End Function
    End Class
End Namespace

Namespace LFERP.DataSetting

    Public Class AuxiliaryDataControler
        Friend Function FillAuxiliaryData(ByVal reader As IDataReader) As AuxiliaryDataInfo
            Dim objInfo As New AuxiliaryDataInfo
            objInfo.BasicMainType = reader("BasicMainType")
            objInfo.BasicMainName = reader("BasicMainName").ToString
            objInfo.BasicMainDescription = reader("BasicMainDescription").ToString
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
            Return objInfo
        End Function



        Public Function AuxiliaryData_GetList(ByVal BasicMainType As Decimal, ByVal BasicMainName As String) As List(Of AuxiliaryDataInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryData_GetList")
            If BasicMainType <> 0 Then
                db.AddInParameter(dbComm, "@BasicMainType", DbType.Decimal, BasicMainType)
            End If
            db.AddInParameter(dbComm, "@BasicMainName", DbType.String, BasicMainName)
            Dim FeatureList As New List(Of AuxiliaryDataInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillAuxiliaryData(reader))
                End While
                Return FeatureList
            End Using
        End Function




        Public Function AuxiliaryData_Delete(ByVal BasicMainType As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryData_Delete")
                db.AddInParameter(dbComm, "@BasicMainType", DbType.Decimal, BasicMainType)
                db.ExecuteNonQuery(dbComm)
                AuxiliaryData_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                AuxiliaryData_Delete = False
            End Try
        End Function


        Public Function AuxiliaryData_Update(ByVal objinfo As AuxiliaryDataInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryData_Update")
                db.AddInParameter(dbComm, "@BasicMainType", DbType.Decimal, objinfo.BasicMainType)
                db.AddInParameter(dbComm, "@BasicMainName", DbType.String, objinfo.BasicMainName)
                db.AddInParameter(dbComm, "@BasicMainDescription", DbType.String, objinfo.BasicMainDescription)

                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.ExecuteNonQuery(dbComm)
                AuxiliaryData_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                AuxiliaryData_Update = False
            End Try
        End Function


        Public Function AuxiliaryData_Add(ByVal objInfo As AuxiliaryDataInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("AuxiliaryData_Add")
                db.AddInParameter(dbComm, "@BasicMainName", DbType.String, objInfo.BasicMainName)
                db.AddInParameter(dbComm, "@BasicMainDescription", DbType.String, objInfo.BasicMainDescription)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)
                db.ExecuteNonQuery(dbComm)
                AuxiliaryData_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                AuxiliaryData_Add = False
            End Try
        End Function
    End Class
End Namespace

Namespace LFERP.Library.WareHouse.WareInventoryNGType


    Public Class WareInventoryNGTypeControl

        Public Function WareInventoryNGType_Add(ByVal objinfo As WareInventoryNGTypeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventoryNGType_Add")

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@NGType", DbType.String, objinfo.NGType)
                db.AddInParameter(dbComm, "@NGName", DbType.String, objinfo.NGName)
                db.AddInParameter(dbComm, "@NGMaterial", DbType.String, objinfo.NGMaterial)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)

                db.AddInParameter(dbComm, "@AddAction", DbType.String, objinfo.AddAction)
                db.AddInParameter(dbComm, "@AddDate", DbType.Date, objinfo.AddDate)

                db.ExecuteNonQuery(dbComm)
                WareInventoryNGType_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareInventoryNGType_Add = False
            End Try
        End Function

        Public Function WareInventoryNGType_Update(ByVal objinfo As WareInventoryNGTypeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventoryNGType_Update")

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@NGType", DbType.String, objinfo.NGType)
                db.AddInParameter(dbComm, "@NGName", DbType.String, objinfo.NGName)
                db.AddInParameter(dbComm, "@NGMaterial", DbType.String, objinfo.NGMaterial)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)

                db.AddInParameter(dbComm, "@UpdateAction", DbType.String, objinfo.UpdateAction)
                db.AddInParameter(dbComm, "@UpdateDate", DbType.Date, objinfo.UpdateDate)

                db.ExecuteNonQuery(dbComm)
                WareInventoryNGType_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                WareInventoryNGType_Update = False
            End Try

        End Function


        Public Function WareInventoryNGType_GetList(ByVal M_Code As String) As List(Of WareInventoryNGTypeInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareInventoryNGType_GetList")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of WareInventoryNGTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareInventoryNGType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillWareInventoryNGType(ByVal reader As IDataReader) As WareInventoryNGTypeInfo
            On Error Resume Next
            Dim objInfo As New WareInventoryNGTypeInfo

            objInfo.M_Code = reader("M_Code").ToString
            objInfo.AutoID = reader("AutoID")
            objInfo.NGType = reader("NGType").ToString
            objInfo.NGName = reader("NGName").ToString

            objInfo.NGMaterial = reader("NGMaterial").ToString
            objInfo.Remark = reader("Remark").ToString
            objInfo.AddAction = reader("AddAction").ToString
            objInfo.AddDate = reader("AddDate")

            objInfo.UpdateAction = reader("UpdateAction").ToString
            objInfo.UpdateDate = reader("UpdateDate")

            objInfo.AddActionName = reader("AddActionName").ToString
            objInfo.UpdateActionName = reader("UpdateActionName").ToString

            Return objInfo
        End Function


    End Class
End Namespace
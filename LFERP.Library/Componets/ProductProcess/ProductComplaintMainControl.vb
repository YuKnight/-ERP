
Namespace LFERP.Library.ProductProcess

    Public Class ProductComplaintMainControl

        Public Function ProductComplaintMain_Add(ByVal objinfo As ProductComplaintMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductComplaintMain_Add")

                db.AddInParameter(dbComm, "@PC_NO", DbType.String, objinfo.PC_NO)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PC_Remark", DbType.String, objinfo.PC_Remark)
                db.AddInParameter(dbComm, "@PC_Action", DbType.String, objinfo.PC_Action)
                db.AddInParameter(dbComm, "@PC_AddDate", DbType.Date, objinfo.PC_AddDate)
                db.AddInParameter(dbComm, "@PC_EditDate", DbType.Date, objinfo.PC_EditDate)

                db.ExecuteNonQuery(dbComm)
                ProductComplaintMain_Add = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductComplaintMain_Add = False
            End Try

        End Function

        Public Function ProductComplaintMain_Update(ByVal objinfo As ProductComplaintMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductComplaintMain_Update")

                db.AddInParameter(dbComm, "@PC_NO", DbType.String, objinfo.PC_NO)
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PC_Remark", DbType.String, objinfo.PC_Remark)
                db.AddInParameter(dbComm, "@PC_Action", DbType.String, objinfo.PC_Action)
                db.AddInParameter(dbComm, "@PC_EditDate", DbType.Date, objinfo.PC_EditDate)


                db.ExecuteNonQuery(dbComm)
                ProductComplaintMain_Update = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductComplaintMain_Update = False
            End Try
        End Function

        Public Function ProductComplaintMain_Delete(ByVal PC_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductComplaintMain_Delete")

                db.AddInParameter(dbComm, "@PC_NO", DbType.String, PC_NO)

                db.ExecuteNonQuery(dbComm)
                ProductComplaintMain_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductComplaintMain_Delete = False
            End Try
        End Function

        Public Function ProductComplaintMain_GetNO(ByVal NDate As String) As ProductComplaintMainInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductComplaintMain_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillComplaint(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function ProductComplaintMain_GetList(ByVal PC_NO As String, ByVal Pro_NO As String, ByVal PM_M_Code As String) As List(Of ProductComplaintMainInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductComplaintMain_GetList")

            db.AddInParameter(dbComm, "@PC_NO", DbType.String, PC_NO)
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

            Dim FeatureList As New List(Of ProductComplaintMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillComplaint(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function ProductComplaintSub_Add(ByVal objinfo As ProductComplaintMainInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductComplaintSub_Add")

                db.AddInParameter(dbComm, "@PC_NO", DbType.String, objinfo.PC_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, objinfo.PS_Num)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PS_Name", DbType.String, objinfo.PS_Name)
                db.AddInParameter(dbComm, "@D_Name", DbType.String, objinfo.D_Name)
                db.AddInParameter(dbComm, "@PS_Question", DbType.String, objinfo.PS_Question)
                db.AddInParameter(dbComm, "@PS_Photo", DbType.Binary, objinfo.PS_Photo)

                db.ExecuteNonQuery(dbComm)
                ProductComplaintSub_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductComplaintSub_Add = False
            End Try

        End Function

        Public Function ProductComplaintSub_Update(ByVal objinfo As ProductComplaintMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductComplaintSub_Update")

                db.AddInParameter(dbComm, "@PC_NO", DbType.String, objinfo.PC_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, objinfo.PS_Num)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PS_Name", DbType.String, objinfo.PS_Name)
                db.AddInParameter(dbComm, "@D_Name", DbType.String, objinfo.D_Name)
                db.AddInParameter(dbComm, "@PS_Question", DbType.String, objinfo.PS_Question)
                db.AddInParameter(dbComm, "@PS_Photo", DbType.Binary, objinfo.PS_Photo)

                db.ExecuteNonQuery(dbComm)
                ProductComplaintSub_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductComplaintSub_Update = False
            End Try

        End Function

        Public Function ProductComplaintSub_Delete(ByVal PC_NO As String, ByVal PS_Num As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductComplaintSub_Delete")

                db.AddInParameter(dbComm, "@PC_NO", DbType.String, PC_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, PS_Num)

                db.ExecuteNonQuery(dbComm)
                ProductComplaintSub_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductComplaintSub_Delete = False
            End Try
        End Function

        Public Function ProductComplaintSub_GetList(ByVal PC_NO As String, ByVal PS_NO As String, ByVal PS_Name As String) As List(Of ProductComplaintMainInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductComplaintSub_GetList")

            db.AddInParameter(dbComm, "@PC_NO", DbType.String, PC_NO)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@PS_Name", DbType.String, PS_Name)

            Dim FeatureList As New List(Of ProductComplaintMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillComplaint(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillComplaint(ByVal reader As IDataReader) As ProductComplaintMainInfo

            On Error Resume Next

            Dim pci As New ProductComplaintMainInfo

            pci.PC_NO = reader("PC_NO").ToString

            pci.Pro_NO = reader("Pro_NO").ToString
            pci.PM_M_Code = reader("PM_M_Code").ToString
            pci.PC_Remark = reader("PC_Remark").ToString
            pci.PC_Action = reader("PC_Action").ToString

            If reader("PC_AddDate") Is DBNull.Value Then
                pci.PC_AddDate = Nothing
            Else
                pci.PC_AddDate = CStr(reader("PC_AddDate"))
            End If
            If reader("PC_EditDate") Is DBNull.Value Then
                pci.PC_EditDate = Nothing
            Else
                pci.PC_EditDate = CStr(reader("PC_EditDate"))
            End If
            If reader("PS_Photo") Is DBNull.Value Then
            Else
                pci.PS_Photo = reader("PS_Photo")
            End If

            pci.PS_Num = reader("PS_Num").ToString
            pci.PS_NO = reader("PS_NO").ToString
            pci.PS_Name = reader("PS_Name").ToString
            pci.D_Name = reader("D_Name").ToString
            pci.PS_Question = reader("PS_Question").ToString

            pci.ActionName = reader("ActionName").ToString
            pci.IndexNO = reader("IndexNO").ToString
            pci.D_ID = reader("D_ID").ToString
            pci.D_Dep = reader("D_Dep").ToString

            Return pci

        End Function

    End Class

End Namespace


Namespace LFERP.Library.PieceProcess
    Public Class WorkGroupControl

        Public Function PieceMoWorkGroup_GetNO(ByVal Ndate As String) As WorkGroupInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoWorkGroup_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWorkGroup(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function PieceMoWorkGroup_Add(ByVal Objinfo As WorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoWorkGroup_Add")

                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Objinfo.Wg_NO)
                db.AddInParameter(dbComm, "@Wg_Name", DbType.String, Objinfo.Wg_Name)
                db.AddInParameter(dbComm, "@Wg_Manager", DbType.String, Objinfo.Wg_Manager)
                db.AddInParameter(dbComm, "@DepNO", DbType.String, Objinfo.DepNO)
                db.AddInParameter(dbComm, "@Wg_Remark", DbType.String, Objinfo.Wg_Remark)
                db.AddInParameter(dbComm, "@Wg_AddDate", DbType.String, Objinfo.Wg_AddDate)
                db.AddInParameter(dbComm, "@Wg_Action", DbType.String, Objinfo.Wg_Action)

                db.ExecuteNonQuery(dbComm)
                PieceMoWorkGroup_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceMoWorkGroup_Add = False
            End Try
        End Function
        Public Function PieceMoWorkGroup_Update(ByVal Objinfo As WorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoWorkGroup_Update")

                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Objinfo.Wg_NO)
                db.AddInParameter(dbComm, "@Wg_Name", DbType.String, Objinfo.Wg_Name)
                db.AddInParameter(dbComm, "@Wg_Manager", DbType.String, Objinfo.Wg_Manager)
                db.AddInParameter(dbComm, "@DepNO", DbType.String, Objinfo.DepNO)
                db.AddInParameter(dbComm, "@Wg_Remark", DbType.String, Objinfo.Wg_Remark)
                db.AddInParameter(dbComm, "@Wg_AddDate", DbType.String, Objinfo.Wg_AddDate)
                db.AddInParameter(dbComm, "@Wg_Action", DbType.String, Objinfo.Wg_Action)

                db.ExecuteNonQuery(dbComm)
                PieceMoWorkGroup_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PieceMoWorkGroup_Update = False
            End Try
        End Function
        Public Function PieceMoWorkGroup_Del(ByVal Wg_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoWorkGroup_Del")

                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Wg_NO)

                db.ExecuteNonQuery(dbComm)
                PieceMoWorkGroup_Del = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceMoWorkGroup_Del = False
            End Try
        End Function
        Public Function PieceMoWorkGroup_GetList(ByVal Wg_NO As String, ByVal Wg_Manager As String, ByVal DepNO As String, ByVal Wg_AddDate1 As String, ByVal Wg_AddDate2 As String, ByVal Wg_Action As String) As List(Of WorkGroupInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoWorkGroup_GetList")

            db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Wg_NO)
            db.AddInParameter(dbComm, "@Wg_Manager", DbType.String, Wg_Manager)
            db.AddInParameter(dbComm, "@DepNO", DbType.String, DepNO)
            db.AddInParameter(dbComm, "@Wg_AddDate1", DbType.String, Wg_AddDate1)
            db.AddInParameter(dbComm, "@Wg_AddDate2", DbType.String, Wg_AddDate2)
            db.AddInParameter(dbComm, "@Wg_Action", DbType.String, Wg_Action)

            Dim FeatureList As New List(Of WorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWorkGroup(reader))
                End While
                Return FeatureList
            End Using

        End Function
        '........................................................................................................
        Public Function PieceSumWorkGroup_GetNO(ByVal Ndate As String) As WorkGroupInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumWorkGroup_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWorkGroup(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function PieceSumWorkGroup_Add(ByVal Objinfo As WorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumWorkGroup_Add")

                db.AddInParameter(dbComm, "@PG_NO", DbType.String, Objinfo.PG_NO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, Objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Num", DbType.String, Objinfo.PM_Num)
                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Objinfo.Wg_NO)
                db.AddInParameter(dbComm, "@PG_Qty", DbType.String, Objinfo.PG_Qty)
                db.AddInParameter(dbComm, "@PG_Factor", DbType.String, Objinfo.PG_Factor)
                db.AddInParameter(dbComm, "@PG_AddDate", DbType.String, Objinfo.PG_AddDate)
                db.AddInParameter(dbComm, "@PG_Remark", DbType.String, Objinfo.PG_Remark)
                db.AddInParameter(dbComm, "@PG_Action", DbType.String, Objinfo.PG_Action)

                db.ExecuteNonQuery(dbComm)
                PieceSumWorkGroup_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceSumWorkGroup_Add = False
            End Try
        End Function
        Public Function PieceSumWorkGroup_Update(ByVal Objinfo As WorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumWorkGroup_Update")

                db.AddInParameter(dbComm, "@PG_NO", DbType.String, Objinfo.PG_NO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, Objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Num", DbType.String, Objinfo.PM_Num)
                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Objinfo.Wg_NO)
                db.AddInParameter(dbComm, "@PG_Qty", DbType.String, Objinfo.PG_Qty)
                db.AddInParameter(dbComm, "@PG_Factor", DbType.String, Objinfo.PG_Factor)
                db.AddInParameter(dbComm, "@PG_AddDate", DbType.String, Objinfo.PG_AddDate)
                db.AddInParameter(dbComm, "@PG_Remark", DbType.String, Objinfo.PG_Remark)
                db.AddInParameter(dbComm, "@PG_Action", DbType.String, Objinfo.PG_Action)

                db.ExecuteNonQuery(dbComm)
                PieceSumWorkGroup_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PieceSumWorkGroup_Update = False
            End Try
        End Function
        Public Function PieceSumWorkGroup_Del(ByVal PG_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumWorkGroup_Del")

                db.AddInParameter(dbComm, "@PG_NO", DbType.String, PG_NO)

                db.ExecuteNonQuery(dbComm)
                PieceSumWorkGroup_Del = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceSumWorkGroup_Del = False
            End Try
        End Function
        Public Function PieceSumWorkGroup_GetList(ByVal PG_NO As String, ByVal Wg_NO As String, ByVal PG_Qty As String, ByVal PG_AddDate1 As String, ByVal PG_AddDate2 As String) As List(Of WorkGroupInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumWorkGroup_GetList")

            db.AddInParameter(dbComm, "@PG_NO", DbType.String, PG_NO)
            db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Wg_NO)
            db.AddInParameter(dbComm, "@PG_Qty", DbType.String, PG_Qty)
            db.AddInParameter(dbComm, "@PG_AddDate1", DbType.String, PG_AddDate1)
            db.AddInParameter(dbComm, "@PG_AddDate2", DbType.String, PG_AddDate2)

            Dim FeatureList As New List(Of WorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWorkGroup(reader))
                End While
                Return FeatureList
            End Using

        End Function
        '..........................................................................................
        Public Function PieceTimeWorkGroup_GetNO(ByVal Ndate As String) As WorkGroupInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimeWorkGroup_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillWorkGroup(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function PieceTimeWorkGroup_Add(ByVal Objinfo As WorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimeWorkGroup_Add")

                db.AddInParameter(dbComm, "@PT_NO", DbType.String, Objinfo.PT_NO)
                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Objinfo.Per_NO)
                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Objinfo.Wg_NO)
                db.AddInParameter(dbComm, "@PT_AddDate", DbType.String, Objinfo.PT_AddDate)
                db.AddInParameter(dbComm, "@PT_BeginDate", DbType.String, Objinfo.PT_BeginDate)
                db.AddInParameter(dbComm, "@PT_EndDate", DbType.String, Objinfo.PT_EndDate)
                db.AddInParameter(dbComm, "@PT_QtyTime", DbType.String, Objinfo.PT_QtyTime)
                db.AddInParameter(dbComm, "@PT_Remark", DbType.String, Objinfo.PT_Remark)
                db.AddInParameter(dbComm, "@PT_Action", DbType.String, Objinfo.PT_Action)

                db.ExecuteNonQuery(dbComm)
                PieceTimeWorkGroup_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceTimeWorkGroup_Add = False
            End Try
        End Function
        Public Function PieceTimeWorkGroup_Update(ByVal Objinfo As WorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimeWorkGroup_Update")

                db.AddInParameter(dbComm, "@PT_NO", DbType.String, Objinfo.PT_NO)
                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Objinfo.Per_NO)
                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Objinfo.Wg_NO)
                db.AddInParameter(dbComm, "@PT_EditDate", DbType.String, Objinfo.PT_EditDate)
                db.AddInParameter(dbComm, "@PT_BeginDate", DbType.String, Objinfo.PT_BeginDate)
                db.AddInParameter(dbComm, "@PT_EndDate", DbType.String, Objinfo.PT_EndDate)
                db.AddInParameter(dbComm, "@PT_QtyTime", DbType.String, Objinfo.PT_QtyTime)
                db.AddInParameter(dbComm, "@PT_Remark", DbType.String, Objinfo.PT_Remark)
                db.AddInParameter(dbComm, "@PT_Action", DbType.String, Objinfo.PT_Action)


                db.ExecuteNonQuery(dbComm)
                PieceTimeWorkGroup_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PieceTimeWorkGroup_Update = False
            End Try
        End Function
        Public Function PieceTimeWorkGroup_Del(ByVal PT_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimeWorkGroup_Del")

                db.AddInParameter(dbComm, "@PT_NO", DbType.String, PT_NO)

                db.ExecuteNonQuery(dbComm)
                PieceTimeWorkGroup_Del = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceTimeWorkGroup_Del = False
            End Try
        End Function
        Public Function PieceTimeWorkGroup_GetList(ByVal PT_NO As String, ByVal Per_NO As String, ByVal Wg_NO As String) As List(Of WorkGroupInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimeWorkGroup_GetList")

            db.AddInParameter(dbComm, "@PT_NO", DbType.String, PT_NO)
            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO)
            db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Wg_NO)

            Dim FeatureList As New List(Of WorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWorkGroup(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function FacBriSearch_GetList(ByVal FacID As String, ByVal FacName As String, ByVal DepID As String, ByVal DepName As String, ByVal ArtType As String) As List(Of WorkGroupInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("FacBriSearch_GetList")

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@DepName", DbType.String, DepName)
            db.AddInParameter(dbComm, "@ArtType", DbType.String, ArtType)


            Dim FeatureList As New List(Of WorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWorkGroup(reader))
                End While
                Return FeatureList
            End Using
        End Function
        '...................................................................
        Public Function FillWorkGroup(ByVal reader As IDataReader) As WorkGroupInfo
            On Error Resume Next
            Dim wgi As New WorkGroupInfo
            '組別資料
            wgi.Wg_NO = reader("Wg_NO").ToString
            wgi.Wg_Name = reader("Wg_Name").ToString
            wgi.Wg_Manager = reader("Wg_Manager").ToString
            wgi.DepNO = reader("DepNO").ToString
            wgi.Wg_Remark = reader("Wg_Remark").ToString
            If reader("Wg_AddDate") = Nothing Then
                wgi.Wg_AddDate = Nothing
            Else
                wgi.Wg_AddDate = CStr(reader("Wg_AddDate"))
            End If
            wgi.Wg_Action = reader("Wg_Action").ToString
            wgi.Wg_ActionName = reader("Wg_ActionName").ToString
            '....................................................................
            '組別計件
            wgi.PG_NO = reader("PG_NO").ToString
            wgi.Wg_NO = reader("Wg_NO").ToString
            wgi.PM_NO = reader("PM_NO").ToString
            wgi.PM_Num = reader("PM_Num").ToString
            wgi.PM_Name = reader("PM_Name").ToString
            wgi.PM_DepName = reader("PM_DepName").ToString
            wgi.PG_Qty = reader("PG_Qty").ToString
            If reader("PG_AddDate") = Nothing Then
                wgi.PG_AddDate = Nothing
            Else
                wgi.PG_AddDate = CStr(reader("PG_AddDate"))
            End If
            wgi.PG_Factor = reader("PG_Factor")
            wgi.PG_Remark = reader("PG_Remark").ToString
            wgi.PG_Action = reader("PG_Action").ToString
            wgi.PG_ActionName = reader("PG_ActionName").ToString
            '....................................................................
            '組比計時
            wgi.PT_NO = reader("PT_NO").ToString
            wgi.Per_NO = reader("Per_NO").ToString
            wgi.Per_Name = reader("Per_Name").ToString
            wgi.Wg_NO = reader("Wg_NO").ToString

            If reader("PT_AddDate") = Nothing Then
                wgi.PT_AddDate = Nothing
            Else
                wgi.PT_AddDate = CStr(reader("PT_AddDate"))
            End If
            If reader("PT_EditDate") = Nothing Then
                wgi.PT_EditDate = Nothing
            Else
                wgi.PT_EditDate = CStr(reader("PT_EditDate"))
            End If
          
            wgi.PT_BeginDate = reader("PT_BeginDate").ToString
            wgi.PT_EndDate = reader("PT_EndDate").ToString


            wgi.PT_QtyTime = reader("PT_QtyTime").ToString
            wgi.PT_Remark = reader("PT_Remark").ToString
            wgi.PT_Action = reader("PT_Action").ToString
            wgi.PT_ActionName = reader("PT_ActionName").ToString

            '......................................................................
            wgi.FacID = reader("FacID").ToString
            wgi.FacName = reader("FacName").ToString
            wgi.DepID = reader("DepID").ToString
            wgi.DepName = reader("DepName").ToString

            Return wgi

        End Function

    End Class
End Namespace


Namespace LFERP.Library.PieceProcess
    Public Class PersonnelControl
        Public Function PieceMoPersonnel_Add(ByVal Objinfo As PersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoPersonnel_Add")

                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Objinfo.Per_NO)
                db.AddInParameter(dbComm, "@Per_Name", DbType.String, Objinfo.Per_Name)
                db.AddInParameter(dbComm, "@DepNO", DbType.String, Objinfo.DepNO)
                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Objinfo.Wg_NO)
                db.AddInParameter(dbComm, "@Per_Pay", DbType.String, Objinfo.Per_Pay)
                db.AddInParameter(dbComm, "@Per_DisMiss", DbType.String, Objinfo.Per_Dismiss)
                db.AddInParameter(dbComm, "@Per_Remark", DbType.String, Objinfo.Per_Remark)
                db.AddInParameter(dbComm, "@Per_PayType", DbType.String, Objinfo.Per_PayType)
                db.AddInParameter(dbComm, "@Per_AddDate", DbType.Date, Objinfo.Per_AddDate)
                db.AddInParameter(dbComm, "@Per_Action", DbType.String, Objinfo.Per_Action)

                db.ExecuteNonQuery(dbComm)
                PieceMoPersonnel_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceMoPersonnel_Add = False
            End Try
        End Function
        Public Function PieceMoPersonnel_Update(ByVal Objinfo As PersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoPersonnel_Update")

                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Objinfo.Per_NO)
                db.AddInParameter(dbComm, "@Per_Name", DbType.String, Objinfo.Per_Name)
                db.AddInParameter(dbComm, "@DepNO", DbType.String, Objinfo.DepNO)
                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Objinfo.Wg_NO)
                db.AddInParameter(dbComm, "@Per_Pay", DbType.String, Objinfo.Per_Pay)
                db.AddInParameter(dbComm, "@Per_DisMiss", DbType.String, Objinfo.Per_Dismiss)
                db.AddInParameter(dbComm, "@Per_Remark", DbType.String, Objinfo.Per_Remark)
                db.AddInParameter(dbComm, "@Per_PayType", DbType.String, Objinfo.Per_PayType)
                db.AddInParameter(dbComm, "@Per_Action", DbType.String, Objinfo.Per_Action)

                db.ExecuteNonQuery(dbComm)
                PieceMoPersonnel_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PieceMoPersonnel_Update = False
            End Try
        End Function
        Public Function PieceMoPersonnel2_Update(ByVal Objinfo As PersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoPersonnel2_Update")

                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Objinfo.Per_NO)
                db.AddInParameter(dbComm, "@Per_DisMiss", DbType.String, Objinfo.Per_Dismiss)
               
                db.ExecuteNonQuery(dbComm)
                PieceMoPersonnel2_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PieceMoPersonnel2_Update = False
            End Try
        End Function
        Public Function PieceMoPersonnel_Del(ByVal Per_NO As String, ByVal Wg_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoPersonnel_Del")

                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO)
                db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Wg_NO)

                db.ExecuteNonQuery(dbComm)
                PieceMoPersonnel_Del = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceMoPersonnel_Del = False
            End Try
        End Function
        Public Function PieceMoPersonnel_GetList(ByVal Per_NO As String, ByVal DepNO As String, ByVal Wg_NO As String, ByVal Per_PayType As String, ByVal Per_DisMiss As String, ByVal Per_AddDate1 As String, ByVal Per_AddDate2 As String, ByVal Per_Action As String) As List(Of PersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceMoPersonnel_GetList")

            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO)
            db.AddInParameter(dbComm, "@DepNO", DbType.String, DepNO)
            db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Wg_NO)
            db.AddInParameter(dbComm, "@Per_PayType", DbType.String, Per_PayType)
            db.AddInParameter(dbComm, "@Per_DisMiss", DbType.Boolean, Per_DisMiss)
            db.AddInParameter(dbComm, "@Per_AddDate1", DbType.String, Per_AddDate1)
            db.AddInParameter(dbComm, "@Per_AddDate2", DbType.String, Per_AddDate2)
            db.AddInParameter(dbComm, "@Per_Action", DbType.String, Per_Action)

            Dim FeatureList As New List(Of PersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPersonnel(reader))
                End While
                Return FeatureList
            End Using

        End Function
        '........................................................................................................

        Public Function PieceSumPersonnel_GetNO(ByVal Ndate As String) As PersonnelInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumPersonnel_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPersonnel(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function PieceSumPersonnel_Add(ByVal Objinfo As PersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumPersonnel_Add")

                db.AddInParameter(dbComm, "@PP_NO", DbType.String, Objinfo.PP_NO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, Objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Num", DbType.String, Objinfo.PM_Num)
                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Objinfo.Per_NO)
                db.AddInParameter(dbComm, "@PP_Qty", DbType.String, Objinfo.PP_Qty)
                db.AddInParameter(dbComm, "@PP_AddDate", DbType.String, Objinfo.PP_AddDate)
                db.AddInParameter(dbComm, "@PP_Remark", DbType.String, Objinfo.PP_Remark)
                db.AddInParameter(dbComm, "@PP_Action", DbType.String, Objinfo.PP_Action)

                db.ExecuteNonQuery(dbComm)
                PieceSumPersonnel_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceSumPersonnel_Add = False
            End Try
        End Function
        Public Function PieceSumPersonnel_Update(ByVal Objinfo As PersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumPersonnel_Update")

                db.AddInParameter(dbComm, "@PP_NO", DbType.String, Objinfo.PP_NO)
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, Objinfo.PM_NO)
                db.AddInParameter(dbComm, "@PM_Num", DbType.String, Objinfo.PM_Num)
                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Objinfo.Per_NO)
                db.AddInParameter(dbComm, "@PP_Qty", DbType.String, Objinfo.PP_Qty)
                db.AddInParameter(dbComm, "@PP_AddDate", DbType.String, Objinfo.PP_AddDate)
                db.AddInParameter(dbComm, "@PP_Remark", DbType.String, Objinfo.PP_Remark)
                db.AddInParameter(dbComm, "@PP_Action", DbType.String, Objinfo.PP_Action)

                db.ExecuteNonQuery(dbComm)
                PieceSumPersonnel_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PieceSumPersonnel_Update = False
            End Try
        End Function
        Public Function PieceSumPersonnel_Del(ByVal PP_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumPersonnel_Del")

                db.AddInParameter(dbComm, "@PP_NO", DbType.String, PP_NO)

                db.ExecuteNonQuery(dbComm)
                PieceSumPersonnel_Del = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceSumPersonnel_Del = False
            End Try
        End Function
        Public Function PieceSumPersonnel_GetList(ByVal PP_NO As String, ByVal PM_NO As String, ByVal PM_Num As String, ByVal Per_NO As String, ByVal PP_Qty As String, ByVal PP_AddDate1 As String, ByVal PP_AddDate2 As String, ByVal Per_AddDate1 As String, ByVal Per_AddDate2 As String, ByVal PP_Action As String) As List(Of PersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSumPersonnel_GetList")

            db.AddInParameter(dbComm, "@PP_NO", DbType.String, PP_NO)
            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@PM_Num", DbType.String, PM_Num)
            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO)
            db.AddInParameter(dbComm, "@PP_Qty", DbType.String, PP_Qty)
            db.AddInParameter(dbComm, "@PP_AddDate1", DbType.String, PP_AddDate1)
            db.AddInParameter(dbComm, "@PP_AddDate2", DbType.String, PP_AddDate2)
            db.AddInParameter(dbComm, "@PP_Action", DbType.String, PP_Action)

            Dim FeatureList As New List(Of PersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPersonnel(reader))
                End While
                Return FeatureList
            End Using

        End Function
        '..........................................................................................

        Public Function PieceTimePersonnel_GetNO(ByVal Ndate As String) As PersonnelInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimePersonnel_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillPersonnel(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function PieceTimePersonnel_Add(ByVal Objinfo As PersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimePersonnel_Add")

                db.AddInParameter(dbComm, "@PT_NO", DbType.String, Objinfo.PT_NO)
                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Objinfo.Per_NO)
                db.AddInParameter(dbComm, "@PT_AddDate", DbType.String, Objinfo.PT_AddDate)
                db.AddInParameter(dbComm, "@PT_BeginDate", DbType.String, Objinfo.PT_BeginDate)
                db.AddInParameter(dbComm, "@PT_EndDate", DbType.String, Objinfo.PT_EndDate)
                db.AddInParameter(dbComm, "@PT_QtyDate", DbType.String, Objinfo.PT_QtyDate)
                db.AddInParameter(dbComm, "@PT_Remark", DbType.String, Objinfo.PT_Remark)
                db.AddInParameter(dbComm, "@PT_Action", DbType.String, Objinfo.PT_Action)

                db.ExecuteNonQuery(dbComm)
                PieceTimePersonnel_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceTimePersonnel_Add = False
            End Try
        End Function
        Public Function PieceTimePersonnel_Update(ByVal Objinfo As PersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimePersonnel_Update")

                db.AddInParameter(dbComm, "@PT_NO", DbType.String, Objinfo.PT_NO)
                db.AddInParameter(dbComm, "@Per_NO", DbType.String, Objinfo.Per_NO)
                db.AddInParameter(dbComm, "@PT_EditDate", DbType.String, Objinfo.PT_EditDate)
                db.AddInParameter(dbComm, "@PT_BeginDate", DbType.String, Objinfo.PT_BeginDate)
                db.AddInParameter(dbComm, "@PT_EndDate", DbType.String, Objinfo.PT_EndDate)
                db.AddInParameter(dbComm, "@PT_QtyDate", DbType.String, Objinfo.PT_QtyDate)
                db.AddInParameter(dbComm, "@PT_Remark", DbType.String, Objinfo.PT_Remark)
                db.AddInParameter(dbComm, "@PT_Action", DbType.String, Objinfo.PT_Action)


                db.ExecuteNonQuery(dbComm)
                PieceTimePersonnel_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PieceTimePersonnel_Update = False
            End Try
        End Function
        Public Function PieceTimePersonnel_Del(ByVal PT_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimePersonnel_Del")

                db.AddInParameter(dbComm, "@PT_NO", DbType.String, PT_NO)

                db.ExecuteNonQuery(dbComm)
                PieceTimePersonnel_Del = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PieceTimePersonnel_Del = False
            End Try
        End Function
        Public Function PieceTimePersonnel_GetList(ByVal PT_NO As String, ByVal Per_NO As String) As List(Of PersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceTimePersonnel_GetList")

            db.AddInParameter(dbComm, "@PT_NO", DbType.String, Pt_NO)
            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO)

            Dim FeatureList As New List(Of PersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPersonnel(reader))
                End While
                Return FeatureList
            End Using
        End Function
      
        Public Function FacBriSearch_GetList(ByVal FacID As String, ByVal FacName As String, ByVal DepID As String, ByVal DepName As String) As List(Of PersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("FacBriSearch_GetList")

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@DepName", DbType.String, DepName)

            Dim FeatureList As New List(Of PersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPersonnel(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FacBriSearch_GetListA(ByVal FacID As String, ByVal FacName As String, ByVal DepID As String, ByVal DepName As String, ByVal DepType As String) As List(Of PersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("FacBriSearch_GetListA")

            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@DepName", DbType.String, DepName)
            db.AddInParameter(dbComm, "@DepType", DbType.String, DepType)

            Dim FeatureList As New List(Of PersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPersonnel(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function DepFac_GetList(ByVal DepID As String, ByVal DepName As String, ByVal FacID As String, ByVal FacName As String) As List(Of PersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("DepFac_GetList")

            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@DepName", DbType.String, DepName)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)

            Dim FeatureList As New List(Of PersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPersonnel(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function DepFacUser_GetList(ByVal DepID As String, ByVal DepName As String, ByVal FacID As String, ByVal FacName As String, ByVal UserID As String, ByVal UserName As String, ByVal UserRank As String) As List(Of PersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("DepFacUser_GetList")

            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@DepName", DbType.String, DepName)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
            db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
            db.AddInParameter(dbComm, "@UserName", DbType.String, UserName)
            db.AddInParameter(dbComm, "@UserRank", DbType.String, UserRank)

            Dim FeatureList As New List(Of PersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPersonnel(reader))
                End While
                Return FeatureList
            End Using
        End Function
        '...................................................................
        Public Function FillPersonnel(ByVal reader As IDataReader) As PersonnelInfo
            On Error Resume Next
            Dim psi As New PersonnelInfo
            '個人資料
            psi.Per_NO = reader("Per_NO").ToString
            psi.Per_Name = reader("Per_Name").ToString
            psi.DepNO = reader("DepNO").ToString
            psi.Wg_NO = reader("Wg_NO").ToString
            psi.Wg_Name = reader("Wg_Name").ToString
            psi.Per_Pay = reader("Per_Pay").ToString
            If reader("Per_DisMiss") = Nothing Then
                psi.Per_Dismiss = False
            Else
                psi.Per_Dismiss = reader("Per_DisMiss")
            End If

            psi.Per_Remark = reader("Per_Remark").ToString
            psi.Per_PayType = reader("Per_PayType").ToString
            If reader("Per_AddDate") = Nothing Then
                psi.Per_AddDate = Nothing
            Else
                psi.Per_AddDate = CStr(reader("Per_AddDate"))
            End If
            psi.Per_Action = reader("Per_Action").ToString
            psi.Per_ActionName = reader("Per_ActionName").ToString
            '....................................................................
            '個人計件
            psi.PP_NO = reader("PP_NO").ToString
            psi.PM_NO = reader("PM_NO").ToString
            psi.PM_Num = reader("PM_Num").ToString
            psi.PM_Name = reader("PM_Name").ToString
            psi.PM_DepName = reader("PM_DepName").ToString
            psi.Per_NO = reader("Per_NO").ToString
            psi.PP_Qty = reader("PP_Qty").ToString
            If reader("PP_AddDate") = Nothing Then
                psi.PP_AddDate = Nothing
            Else
                psi.PP_AddDate = CStr(reader("PP_AddDate"))
            End If

            psi.PP_AddDate = reader("PP_AddDate")
            psi.PP_Remark = reader("PP_Remark").ToString
            psi.PP_Action = reader("PP_Action").ToString
            psi.PP_ActionName = reader("PP_ActionName").ToString
            '....................................................................
            '個人計時
            psi.PT_NO = reader("PT_NO").ToString

            If reader("PT_AddDate") = Nothing Then
                psi.PT_AddDate = Nothing
            Else
                psi.PT_AddDate = CStr(reader("PT_AddDate"))
            End If
            If reader("PT_EditDate") = Nothing Then
                psi.PT_EditDate = Nothing
            Else
                psi.PT_EditDate = CStr(reader("PT_EditDate"))
            End If
            psi.PT_BeginDate = reader("PT_BeginDate").ToString
            psi.PT_EndDate = reader("PT_EndDate").ToString
            psi.PT_QtyDate = reader("PT_QtyDate").ToString
            psi.PT_Remark = reader("PT_Remark").ToString
            psi.PT_Action = reader("PT_Action").ToString
            psi.PT_ActionName = reader("PT_ActionName").ToString
            '......................................................................
            psi.FacID = reader("FacID").ToString
            psi.FacName = reader("FacName").ToString
            psi.DepID = reader("DepID").ToString
            psi.DepName = reader("DepName").ToString
            psi.UserID = reader("UserID").ToString
            psi.UserName = reader("UserName").ToString
            psi.UserRank = reader("UserRank").ToString


            psi.ArtType = reader("ArtType").ToString

            Return psi

        End Function
           


    End Class
End Namespace


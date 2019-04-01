Namespace LFERP.Library.PieceProcess
    Public Class PieceSelectControl
        Public Function PieceSelect(ByVal PieceType As String, ByVal strWhere As String) As List(Of PieceSelectInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PieceSelect")

            db.AddInParameter(dbComm, "@PieceType", DbType.String, PieceType)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere)

            Dim FeatureList As New List(Of PieceSelectInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPieceProcessMoSub(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function FillPieceProcessMoSub(ByVal reader As IDataReader) As PieceSelectInfo
            On Error Resume Next
            Dim psi As New PieceSelectInfo
            '個人資料
            psi.Per_NO = reader("Per_NO").ToString
            psi.Per_Name = reader("Per_Name").ToString
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
            psi.Wg_NO = reader("Wg_NO").ToString
            psi.Wg_Name = reader("Wg_Name").ToString
            psi.Wg_Manager = reader("Wg_Manager").ToString
            psi.Wg_Remark = reader("Wg_Remark").ToString
            If reader("Wg_AddDate") = Nothing Then
                psi.Wg_AddDate = Nothing
            Else
                psi.Wg_AddDate = CStr(reader("Wg_AddDate"))
            End If
            psi.Wg_Action = reader("Wg_Action").ToString
            psi.Wg_ActionName = reader("Wg_ActionName").ToString
            '....................................................................
            '組別計件
            psi.PG_NO = reader("PG_NO").ToString
            psi.PM_NO = reader("PM_NO").ToString
            psi.PM_Num = reader("PM_Num").ToString
            psi.PM_Name = reader("PM_Name").ToString
            psi.PM_DepName = reader("PM_DepName").ToString
            psi.PG_Qty = reader("PG_Qty").ToString
            If reader("PG_AddDate") = Nothing Then
                psi.PG_AddDate = Nothing
            Else
                psi.PG_AddDate = CStr(reader("PG_AddDate"))
            End If
            psi.PG_Factor = reader("PG_Factor")
            psi.PG_Remark = reader("PG_Remark").ToString
            psi.PG_Action = reader("PG_Action").ToString
            psi.PG_ActionName = reader("PG_ActionName").ToString
            '....................................................................
            '組比計時
            psi.PT_NO = reader("PT_NO").ToString
            psi.Per_NO = reader("Per_NO").ToString
            psi.Per_Name = reader("Per_Name").ToString

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

            psi.FacID = reader("FacID").ToString
            psi.FacName = reader("FacName").ToString
            psi.DepID = reader("DepID").ToString
            psi.DepName = reader("DepName").ToString
            psi.UserID = reader("UserID").ToString
            psi.UserName = reader("UserName").ToString
            psi.UserRank = reader("UserRank").ToString
            Return psi
        End Function
    End Class
End Namespace


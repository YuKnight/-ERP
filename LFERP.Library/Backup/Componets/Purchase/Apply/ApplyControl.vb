
Namespace LFERP.Library.Purchase.Apply

    Public Class ApplyControl

        Public Function Apply_Update(ByVal objinfo As ApplyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Apply_Update")

                db.AddInParameter(dbcomm, "@AM_ID", DbType.String, objinfo.AM_ID)
                db.AddInParameter(dbcomm, "@M_ID", DbType.String, objinfo.M_ID)
                db.AddInParameter(dbcomm, "@M_Type", DbType.String, objinfo.M_Type)

                db.ExecuteNonQuery(dbcomm)
                Apply_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                Apply_Update = False
            End Try
        End Function
        Public Function Apply_UpdateQty(ByVal objinfo As ApplyInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("Apply_UpdateQty")

                db.AddInParameter(dbcomm, "@AM_ID", DbType.String, objinfo.AM_ID)
                db.AddInParameter(dbcomm, "@M_ID", DbType.String, objinfo.M_ID)
                db.AddInParameter(dbcomm, "@M_SendQty", DbType.Double, objinfo.M_SendQty)
                db.AddInParameter(dbcomm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbcomm, "@M_Qty ", DbType.Double, objinfo.M_Qty)

                db.ExecuteNonQuery(dbcomm)
                Apply_UpdateQty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Apply_UpdateQty = False

            End Try
        End Function

        Public Function Apply_GetList(ByVal AM_ID As String, ByVal M_ID As String, ByVal M_Code As String, ByVal M_Name As String) As List(Of ApplyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Apply_GetList")

            db.AddInParameter(dbComm, "@AM_ID", DbType.String, AM_ID)
            db.AddInParameter(dbComm, "@M_ID", DbType.String, M_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)

            Dim FeatureList As New List(Of ApplyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillApply(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function Apply_GetList1(ByVal AM_ID As String, ByVal M_ID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal M_Department As String, ByVal M_UserID As String, ByVal M_Type As String, ByVal AM_ID_Pri As String, ByVal M_Department_Pri As String, ByVal M_UserID_Pri As String) As List(Of ApplyInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Apply_GetList1")

            db.AddInParameter(dbComm, "@AM_ID", DbType.String, AM_ID)
            db.AddInParameter(dbComm, "@M_ID", DbType.String, M_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@M_Department", DbType.String, M_Department)
            db.AddInParameter(dbComm, "@M_UserID", DbType.String, M_UserID)
            db.AddInParameter(dbComm, "@M_Type", DbType.String, M_Type)
            db.AddInParameter(dbComm, "@AM_ID_Pri", DbType.String, AM_ID_Pri)
            db.AddInParameter(dbComm, "@M_Department_Pri", DbType.String, M_Department_Pri)
            db.AddInParameter(dbComm, "@M_UserID_Pri", DbType.String, M_UserID_Pri)

            Dim FeatureList As New List(Of ApplyInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillApply(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function FillApply(ByVal reader As IDataReader) As ApplyInfo

            On Error Resume Next

            Dim ai As New ApplyInfo

            ai.AM_ID = reader("AM_ID").ToString
            ai.M_ID = reader("M_ID").ToString
            ai.M_Code = reader("M_Code").ToString
            ai.M_Name = reader("M_Name").ToString
            ai.M_Gauge = reader("M_Gauge").ToString
            ai.M_Unit = reader("M_Unit").ToString

            If reader("M_Qty") Is DBNull.Value Then
                ai.M_Qty = Nothing
            Else
                ai.M_Qty = CDbl(reader("M_Qty").ToString)
            End If
            If reader("M_SendQty") Is DBNull.Value Then
                ai.M_SendQty = Nothing
            Else
                ai.M_SendQty = CDbl(reader("M_SendQty").ToString)
            End If
      
            ai.M_Useful = reader("M_Useful").ToString
            ai.M_Remark = reader("M_Remark").ToString
            ai.M_Department = reader("M_Department").ToString
            ai.M_UserID = reader("M_UserID").ToString

            If reader("AM_Date") Is DBNull.Value Then
                ai.AM_Date = Nothing
            Else
                ai.AM_Date = CStr(reader("AM_Date"))
            End If
            ai.Temp_Code = reader("Temp_Code").ToString
            ai.M_Type = reader("M_Type").ToString

            ai.AM_ID_Pri = reader("AM_ID_Pri").ToString
            ai.M_Department_Pri = reader("M_Department_Pri").ToString
            ai.M_UserID_Pri = reader("M_UserID_Pri").ToString

            If reader("Tuihuanhuonum") Is DBNull.Value Then
                ai.Tuihuanhuonum = 0
            Else
                ai.Tuihuanhuonum = CDbl(reader("Tuihuanhuonum"))
            End If


            Return ai

        End Function
    End Class

End Namespace

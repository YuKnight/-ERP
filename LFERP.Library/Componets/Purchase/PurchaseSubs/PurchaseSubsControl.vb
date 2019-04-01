
Namespace LFERP.Library.Purchase.Purchase

    Public Class PurchaseSubsControl

        Public Function PurchaseSubs_Add(ByVal obj As PurchaseSubsInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSubs_Add")
                db.AddInParameter(dbComm, "@PM_NO", DbType.String, obj.PM_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, obj.M_Code)
                db.AddInParameter(dbComm, "@PSs_Date", DbType.String, obj.PSs_Date)
                db.AddInParameter(dbComm, "@PSs_Remark", DbType.String, obj.PSs_Remark)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, obj.OS_BatchID)
                db.ExecuteNonQuery(dbComm)
                PurchaseSubs_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseSubs_Add = False
            End Try
        End Function
        Public Function PurchaseSubs_Delete(ByVal AutoID As Integer) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSubs_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.ExecuteNonQuery(dbComm)
                PurchaseSubs_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                PurchaseSubs_Delete = False
            End Try
        End Function
        Public Function PurchaseSubs_GetList(ByVal PM_NO As String, ByVal M_Code As String, ByVal OS_BatchID As String) As List(Of PurchaseSubsInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSubs_GetList")

            db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)

            Dim FeatureList As New List(Of PurchaseSubsInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPurchaseSubs(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillPurchaseSubs(ByVal reader As IDataReader) As PurchaseSubsInfo
            Dim fps As New PurchaseSubsInfo

            fps.AutoID = reader("AutoID")
            fps.PM_NO = reader("PM_NO").ToString
            fps.M_Code = reader("M_Code").ToString
            If reader("PSs_Date") Is DBNull.Value Then
                fps.PSs_Date = Nothing
            Else
                fps.PSs_Date = CDate(reader("PSs_Date").ToString)
            End If

            fps.PSs_Remark = reader("PSs_Remark").ToString
            fps.OS_BatchID = reader("OS_BatchID").ToString
            Return fps

        End Function
    End Class

End Namespace


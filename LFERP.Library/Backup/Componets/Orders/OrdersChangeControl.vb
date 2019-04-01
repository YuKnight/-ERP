Namespace LFERP.Library.OrdersChange

    Public Class OrdersChangeControl

        Public Function OrdersChange_Add(ByVal objFile1 As OrdersChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersChange_Add")
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objFile1.OM_ID)
                db.AddInParameter(dbComm, "@PM_M_CodeOld", DbType.String, objFile1.PM_M_CodeOld)
                db.AddInParameter(dbComm, "@PM_M_CodeNew", DbType.String, objFile1.PM_M_CodeNew)

                db.AddInParameter(dbComm, "@Remark", DbType.String, objFile1.Remark)
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
                db.AddInParameter(dbComm, "@OrderDate", DbType.Date, objFile1.OrderDate)

                db.ExecuteNonQuery(dbComm)
                OrdersChange_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersChange_Add = False
            End Try
        End Function
        Public Function OrdersChange_Add1(ByVal objFile1 As OrdersChangeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersChange_Add1")
                db.AddInParameter(dbComm, "@OM_ID", DbType.String, objFile1.OM_ID)
                db.AddInParameter(dbComm, "@PM_M_CodeOld", DbType.String, objFile1.PM_M_CodeOld)
                db.AddInParameter(dbComm, "@PM_M_CodeNew", DbType.String, objFile1.PM_M_CodeNew)

                db.AddInParameter(dbComm, "@Remark", DbType.String, objFile1.Remark)
                db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
                db.AddInParameter(dbComm, "@OrderDate", DbType.Date, objFile1.OrderDate)
                db.AddInParameter(dbComm, "@ChangeType", DbType.String, objFile1.ChangeType)

                db.ExecuteNonQuery(dbComm)
                OrdersChange_Add1 = True
            Catch ex As Exception
                MsgBox(ex.Message)
                OrdersChange_Add1 = False
            End Try
        End Function

        Public Function OrdersChange_GetList(ByVal OM_ID As String) As List(Of OrdersChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersChange_GetList")

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)

            Dim FeatureList As New List(Of OrdersChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersChange(reader))
                End While
                Return FeatureList
            End Using


        End Function
        Public Function OrdersChange_GetList1(ByVal OM_ID As String, ByVal ChangeType As String) As List(Of OrdersChangeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OrdersChange_GetList1")

            db.AddInParameter(dbComm, "@OM_ID", DbType.String, OM_ID)
            db.AddInParameter(dbComm, "@ChangeType", DbType.String, ChangeType)

            Dim FeatureList As New List(Of OrdersChangeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillOrdersChange(reader))
                End While
                Return FeatureList
            End Using


        End Function

        ''' <summary>
        ''' 取得對應數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillOrdersChange(ByVal reader As IDataReader) As OrdersChangeInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New OrdersChangeInfo
            objInfo.OM_ID = reader("OM_ID").ToString
            objInfo.PM_M_CodeOld = reader("PM_M_CodeOld").ToString
            objInfo.PM_M_CodeNew = reader("PM_M_CodeNew").ToString
            objInfo.Remark = reader("Remark").ToString

            objInfo.OrderDate = reader("OrderDate").ToString
            objInfo.U_Name = reader("U_Name").ToString
            objInfo.ChangeType = reader("ChangeType").ToString
            objInfo.ChangeTypeName = reader("ChangeTypeName").ToString

            Return objInfo
        End Function



    End Class


End Namespace
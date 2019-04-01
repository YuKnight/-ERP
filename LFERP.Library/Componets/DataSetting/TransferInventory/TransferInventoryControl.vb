Namespace LFERP.DataSetting

    Public Class TransferInventoryControl

        Public Function TransferInventory_Add(ByVal objinfo As TransferInventoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("TransferInventory_Add")

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@M_Qty", DbType.Single, objinfo.M_Qty)
                db.AddInParameter(dbComm, "@M_Bit", DbType.Boolean, objinfo.M_Bit)

                db.ExecuteNonQuery(dbComm)
                TransferInventory_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                TransferInventory_Add = False

            End Try
        End Function

        Public Function TransferInventory_Update(ByVal objinfo As TransferInventoryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("TransferInventory_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@M_Bit", DbType.Boolean, objinfo.M_Bit)

                db.ExecuteNonQuery(dbComm)
                TransferInventory_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                TransferInventory_Update = False

            End Try
        End Function
        Public Function TransferInventory_GetList(ByVal AutoID As String, ByVal M_Code As String, ByVal M_Bit As String) As List(Of TransferInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("TransferInventory_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Bit", DbType.String, M_Bit)

            Dim FeatureList As New List(Of TransferInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillTransferInventory(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillTransferInventory(ByVal reader As IDataReader) As TransferInventoryInfo

            On Error Resume Next

            Dim ti As New TransferInventoryInfo

            ti.AutoID = reader("AutoID").ToString
            ti.M_Code = reader("M_Code").ToString

            If reader("M_Qty") Is DBNull.Value Then
                ti.M_Qty = Nothing
            Else
                ti.M_Qty = CSng(reader("M_Qty"))
            End If

            If reader("M_Bit") Is DBNull.Value Then
                ti.M_Bit = Nothing
            Else
                ti.M_Bit = reader("M_Bit")
            End If

            Return ti

        End Function
    End Class

End Namespace




Namespace LFERP.Library.ProductionWareInventory

    Public Class ProductionWareInventoryControl

        Public Function ProductionWareInventory_GetList(ByVal PH_ID As String, ByVal M_Code As String) As List(Of ProductionWareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionWareInventory_GetList")

            db.AddInParameter(dbComm, "@PH_ID", DbType.String, PH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of ProductionWareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareInventory(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function UpdateProductionWareInventory_PIQty(ByVal objinfo As ProductionWareInventoryInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateProductionWareInventory_PIQty")

                db.AddInParameter(dbComm, "@PH_ID", DbType.String, objinfo.PH_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PI_Qty", DbType.Int32, objinfo.PI_Qty)

                db.ExecuteNonQuery(dbComm)
                UpdateProductionWareInventory_PIQty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                UpdateProductionWareInventory_PIQty = False
            End Try

        End Function

        Public Function FillProductionWareInventory(ByVal reader As IDataReader) As ProductionWareInventoryInfo

            On Error Resume Next

            Dim pi As New ProductionWareInventoryInfo

            pi.PH_ID = reader("PH_ID").ToString
            pi.M_Code = reader("M_Code").ToString

            pi.PI_Qty = CInt(reader("PI_Qty"))

            pi.M_Name = reader("M_Name").ToString
            pi.M_Gauge = reader("M_Gauge").ToString
            pi.M_Unit = reader("M_Unit").ToString
            pi.PH_Name = reader("PH_Name").ToString

            pi.PM_JiYu = reader("PM_JiYu").ToString
            Return pi

        End Function

    End Class

End Namespace





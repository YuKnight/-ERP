
Namespace LFERP.Library.WareHouse.WareHouseSplit

    Public Class WareHouseSplitControl

        Public Function WareHouseSplit_Add(ByVal objinfo As WareHouseSplitInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseSplit_Add")

                db.AddInParameter(dbComm, "@S_ID", DbType.String, objinfo.S_ID)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@M_LCode", DbType.String, objinfo.M_LCode)
                db.AddInParameter(dbComm, "@M_SCode", DbType.String, objinfo.M_SCode)
                db.AddInParameter(dbComm, "@S_Type", DbType.String, objinfo.S_Type)

                db.AddInParameter(dbComm, "@S_Qty", DbType.Double, objinfo.S_Qty)
                db.AddInParameter(dbComm, "@S_Ratio", DbType.String, objinfo.S_Ratio)
                db.AddInParameter(dbComm, "@WI_LQty", DbType.Double, objinfo.WI_LQty)
                db.AddInParameter(dbComm, "@WI_SQty", DbType.Double, objinfo.WI_SQty)
                db.AddInParameter(dbComm, "@S_AddDate", DbType.Date, objinfo.S_AddDate)

                db.AddInParameter(dbComm, "@S_Remark", DbType.String, objinfo.S_Remark)
                db.AddInParameter(dbComm, "@S_Action", DbType.String, objinfo.S_Action)
                db.ExecuteNonQuery(dbComm)
                WareHouseSplit_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                WareHouseSplit_Add = False

            End Try

        End Function

        Public Function WareHouseSplit_GetList(ByVal S_ID As String, ByVal M_LCode As String, ByVal M_SCode As String, ByVal M_Name As String, ByVal S_Type As String, ByVal S_Action As String) As List(Of WareHouseSplitInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("WareHouseSplit_GetList")

            db.AddInParameter(dbComm, "@S_ID", DbType.String, S_ID)
            db.AddInParameter(dbComm, "@M_LCode", DbType.String, M_LCode)
            db.AddInParameter(dbComm, "@M_SCode", DbType.String, M_SCode)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@S_Type", DbType.String, S_Type)
            db.AddInParameter(dbComm, "@S_Action", DbType.String, S_Action)


            Dim FeatureList As New List(Of WareHouseSplitInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillWareHouseSplit(reader))
                End While
                Return FeatureList
            End Using


        End Function

        Public Function FillWareHouseSplit(ByVal reader As IDataReader) As WareHouseSplitInfo

            On Error Resume Next
            Dim wsi As New WareHouseSplitInfo

            wsi.S_ID = reader("S_ID").ToString
            wsi.WH_ID = reader("WH_ID").ToString
            wsi.M_LCode = reader("M_LCode").ToString
            wsi.M_SCode = reader("M_SCode").ToString
            wsi.S_Type = reader("S_Type").ToString

            If reader("S_Qty") Is DBNull.Value Then
                wsi.S_Qty = Nothing
            Else
                wsi.S_Qty = CDbl(reader("S_Qty").ToString)
            End If

            wsi.S_Ratio = reader("S_Ratio").ToString

            If reader("WI_LQty") Is DBNull.Value Then
                wsi.WI_LQty = Nothing
            Else
                wsi.WI_LQty = CDbl(reader("WI_LQty").ToString)
            End If
            If reader("WI_SQty") Is DBNull.Value Then
                wsi.WI_SQty = Nothing
            Else
                wsi.WI_SQty = CDbl(reader("WI_SQty").ToString)
            End If

            If reader("S_AddDate") Is DBNull.Value Then
                wsi.S_AddDate = Nothing
            Else
                wsi.S_AddDate = CStr(reader("S_AddDate"))
            End If

            wsi.S_Action = reader("S_Remark").ToString
            wsi.S_Action = reader("S_Action").ToString


            wsi.M_Name = reader("M_Name").ToString
            wsi.Unit1 = reader("Unit1").ToString
            wsi.Unit2 = reader("Unit2").ToString


            Return wsi

        End Function

    End Class

End Namespace


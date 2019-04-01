

Namespace LFERP.Library.ProductionMaterial

    Public Class ProductionMaterialControl

        Public Function UpdateProductionMaterialQty(ByVal objinfo As ProductionMaterialInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateProductionMaterialQty")

                db.AddInParameter(dbComm, "@Pro_Type", DbType.String, objinfo.Pro_Type)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@M_Qty", DbType.Single, objinfo.M_Qty)

                db.ExecuteNonQuery(dbComm)
                UpdateProductionMaterialQty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                UpdateProductionMaterialQty = False
            End Try

        End Function

        Public Function ProductionMaterial_GetList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal M_Code As String) As List(Of ProductionMaterialInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionMaterial_GetList")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of ProductionMaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionMaterial(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function ProductionMaterialDayDetail_GetList(ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal M_Code As String, ByVal M_Date As String) As List(Of ProductionMaterialInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionMaterialDayDetail_GetList")

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Date", DbType.String, M_Date)

            Dim FeatureList As New List(Of ProductionMaterialInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionMaterial(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillProductionMaterial(ByVal reader As IDataReader) As ProductionMaterialInfo

            On Error Resume Next

            Dim pi As New ProductionMaterialInfo


            pi.Pro_Type = reader("Pro_Type").ToString
            pi.PM_M_Code = reader("PM_M_Code").ToString
            pi.PM_Type = reader("PM_Type").ToString

            pi.M_Code = reader("M_Code").ToString

            pi.M_Qty = CSng(reader("M_Qty").ToString)

            pi.M_Name = reader("M_Name").ToString
            pi.M_Gauge = reader("M_Gauge").ToString
            pi.M_Unit = reader("M_Unit").ToString
            pi.Pro_Rate = CSng(reader("Pro_Rate").ToString)

            If reader("M_Date") Is DBNull.Value Then
                pi.M_Date = Nothing
            Else
                pi.M_Date = CStr(reader("M_Date"))
            End If

            Return pi

        End Function

        ''' <summary>
        ''' 2012-6-13打印時，如果指定條件中沒有數據時，載入此處
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NothingNew() As List(Of ProductionMaterialInfo)
            Dim pi As New ProductionMaterialInfo
            Dim FeatureList As New List(Of ProductionMaterialInfo)
            FeatureList.Add(NothingFillProductionMaterial())
            Return FeatureList
        End Function

        Public Function NothingFillProductionMaterial() As ProductionMaterialInfo
            On Error Resume Next
            Dim pi As New ProductionMaterialInfo
            pi.Pro_Type = Nothing
            pi.PM_M_Code = Nothing
            pi.PM_Type = Nothing

            pi.M_Code = Nothing

            pi.M_Qty = 0

            pi.M_Name = Nothing
            pi.M_Gauge = Nothing
            pi.M_Unit = Nothing
            pi.Pro_Rate = 0

            pi.M_Date = Nothing
            Return pi
        End Function
    End Class



End Namespace



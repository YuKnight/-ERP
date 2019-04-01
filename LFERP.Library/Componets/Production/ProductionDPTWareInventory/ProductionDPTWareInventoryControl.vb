

Namespace LFERP.Library.ProductionDPTWareInventory


    Public Class ProductionDPTWareInventoryControl

        Public Function ProductionDPTWareInventory_GetList(ByVal DPT_ID As String, ByVal M_Code As String, ByVal M_Name As String) As List(Of ProductionDPTWareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionDPTWareInventory_GetList")

            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)

            Dim FeatureList As New List(Of ProductionDPTWareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareInventory(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function UpdateProductionField_Qty(ByVal objinfo As ProductionDPTWareInventoryInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("UpdateProductionField_Qty")

                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objinfo.DPT_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WI_Qty", DbType.Single, objinfo.WI_Qty)
                db.AddInParameter(dbComm, "@WI_ReQty", DbType.Single, objinfo.WI_ReQty)
                'db.AddInParameter(dbComm, "@Type", DbType.String, objinfo.Type)

                db.ExecuteNonQuery(dbComm)
                UpdateProductionField_Qty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                UpdateProductionField_Qty = False
            End Try

        End Function

        Public Function ProductionDayDPTWareInventory_GetList(ByVal DPT_ID As String, ByVal M_Code As String, ByVal WI_Date As String) As List(Of ProductionDPTWareInventoryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionDayDPTWareInventory_GetList")

            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WI_Date", DbType.String, WI_Date)

            Dim FeatureList As New List(Of ProductionDPTWareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareInventory(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 2014.5.6 鄭少釗新增 部門匯總
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionDPTWareInventory_GetList_New(ByVal PM_M_Code As String, ByVal DPT_ID As String) As List(Of ProductionDPTWareInventoryInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionDPTWareInventory_GetList_New")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)

            Dim FeatureList As New List(Of ProductionDPTWareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareInventory(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionWareInventory(ByVal reader As IDataReader) As ProductionDPTWareInventoryInfo

            On Error Resume Next

            Dim pi As New ProductionDPTWareInventoryInfo

            pi.DPT_ID = reader("DPT_ID").ToString
            pi.M_Code = reader("M_Code").ToString

            pi.WI_Qty = CDbl(reader("WI_Qty"))
            pi.WI_ReQty = CDbl(reader("WI_ReQty"))
            pi.DayQty = CDbl(reader("DayQty"))

            pi.M_Name = reader("M_Name").ToString
            pi.M_Gauge = reader("M_Gauge").ToString
            pi.M_Unit = reader("M_Unit").ToString
            pi.DPT_Name = reader("DPT_Name").ToString
            pi.Type = reader("Type").ToString

            pi.PM_M_Code = reader("PM_M_Code").ToString

            If reader("WI_Date") Is DBNull.Value Then
                pi.WI_Date = Nothing
            Else
                pi.WI_Date = CStr(reader("WI_Date"))
            End If
            If InStr(reader("M_Name").ToString, "_", CompareMethod.Text) > 0 Then
                pi.M_NameS = Trim(Mid(reader("M_Name").ToString, InStr(reader("M_Name").ToString, "_", CompareMethod.Text) + 1, Len(reader("M_Name").ToString) - InStr(reader("M_Name").ToString, "_", CompareMethod.Text)))
            Else
                pi.M_NameS = reader("M_Name").ToString
            End If
            pi.Type3ID = reader("Type3ID").ToString()
            Return pi
        End Function
        ''' <summary>
        '''  20130315返修等於0并大貨也大於0的不顯示
        ''' </summary>
        ''' <param name="DPT_ID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="M_Name"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionDPTWareInventory_GetList1(ByVal DPT_ID As String, ByVal M_Code As String, ByVal M_Name As String) As List(Of ProductionDPTWareInventoryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionDPTWareInventory_GetList1")

            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)

            Dim FeatureList As New List(Of ProductionDPTWareInventoryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionWareInventory(reader))
                End While
                Return FeatureList
            End Using
        End Function
    End Class
End Namespace


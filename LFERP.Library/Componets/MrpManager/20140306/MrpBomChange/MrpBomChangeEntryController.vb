Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.MrpManager.MrpBomChange
    Public Class MrpBomChangeEntryController
        Friend Function FillMrpBomChangeEntry(ByVal reader As IDataReader) As MrpBomChangeEntryInfo
            Dim objInfo As New MrpBomChangeEntryInfo
            objInfo.AutoID = reader("AutoID")
            objInfo.ChangeOrderNo = reader("ChangeOrderNo").ToString
            objInfo.EntryID = reader("EntryID").ToString
            objInfo.ChangeType = reader("ChangeType").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.PS_NO = reader("PS_NO").ToString 
            objInfo.Mount = reader("Mount").ToString
            objInfo.Tmrtc = reader("Tmrtc").ToString
            If reader("UnitQty") Is DBNull.Value Then
                objInfo.UnitQty = Nothing
            Else
                objInfo.UnitQty = CDbl(reader("UnitQty").ToString)
            End If
            If reader("LossRate") Is DBNull.Value Then
                objInfo.LossRate = Nothing
            Else
                objInfo.LossRate = CDbl(reader("LossRate").ToString)
            End If
            objInfo.Remarks = reader("Remarks").ToString
            objInfo.Bom_Code = reader("Bom_Code").ToString
            objInfo.Bom_MID = reader("Bom_MID").ToString

            objInfo.PS_Name = reader("PS_Name").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Bom_Name = reader("Bom_Name").ToString
            objInfo.Bom_Gauge = reader("Bom_Gauge").ToString
            objInfo.Bom_Unit = reader("Bom_Unit").ToString
            objInfo.BomAddVersion = Convert.ToBoolean(reader("BomAddVersion"))
            objInfo.BomVersion = reader("BomVersion").ToString
            objInfo.AlterType = reader("AlterType").ToString
            objInfo.DisableTactic = reader("DisableTactic").ToString
            objInfo.ChangeTypeName = reader("ChangeTypeName").ToString
            objInfo.AlterTypeName = reader("AlterTypeName").ToString
            objInfo.DisableTacticName = reader("DisableTacticName").ToString
            Return objInfo
        End Function

        Public Function MrpBomChangeEntry_GetList(ByVal ChangeOrderNo As String) As List(Of MrpBomChangeEntryInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChangeEntry_GetList")
            db.AddInParameter(dbComm, "@ChangeOrderNo", DbType.String, ChangeOrderNo)
            Dim FeatureList As New List(Of MrpBomChangeEntryInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMrpBomChangeEntry(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function MrpBomChangeEntry_Delete(ByVal AutoID As String, ByVal ChangeOrderNo As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChangeEntry_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@ChangeOrderNo", DbType.String, ChangeOrderNo)
                db.ExecuteNonQuery(dbComm)
                MrpBomChangeEntry_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChangeEntry_Delete = False
            End Try
        End Function

        Public Function MrpBomChangeEntry_Update(ByVal objinfo As MrpBomChangeEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChangeEntry_Update")
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, objinfo.AutoID)
                db.AddInParameter(dbComm, "@EntryID", DbType.Int64, objinfo.EntryID)
                db.AddInParameter(dbComm, "@ChangeType", DbType.String, objinfo.ChangeType)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO) 
                db.AddInParameter(dbComm, "@Mount", DbType.Int64, objinfo.Mount)
                db.AddInParameter(dbComm, "@Tmrtc", DbType.Int64, objinfo.Tmrtc)
                db.AddInParameter(dbComm, "@UnitQty", DbType.Decimal, objinfo.UnitQty)
                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objinfo.LossRate)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.AddInParameter(dbComm, "@Bom_MID", DbType.Decimal, objinfo.Bom_MID)
                db.AddInParameter(dbComm, "@BomAddVersion", DbType.Boolean, objinfo.BomAddVersion)
                db.AddInParameter(dbComm, "@AlterType", DbType.Int32, objinfo.AlterType)
                db.AddInParameter(dbComm, "@Disabletactic", DbType.Int32, objinfo.DisableTactic)
                db.ExecuteNonQuery(dbComm)
                MrpBomChangeEntry_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChangeEntry_Update = False
            End Try
        End Function

        Public Function MrpBomChangeEntry_Add(ByVal objInfo As MrpBomChangeEntryInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChangeEntry_Add")
                db.AddInParameter(dbComm, "@ChangeOrderNo", DbType.String, objInfo.ChangeOrderNo)
                db.AddInParameter(dbComm, "@EntryID", DbType.Int64, objInfo.EntryID)
                db.AddInParameter(dbComm, "@ChangeType", DbType.String, objInfo.ChangeType)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objInfo.M_Code)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objInfo.PS_NO) 
                db.AddInParameter(dbComm, "@Mount", DbType.Int64, objInfo.Mount)
                db.AddInParameter(dbComm, "@Tmrtc", DbType.Int64, objInfo.Tmrtc)
                db.AddInParameter(dbComm, "@UnitQty", DbType.Decimal, objInfo.UnitQty)
                db.AddInParameter(dbComm, "@LossRate", DbType.Decimal, objInfo.LossRate)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.AddInParameter(dbComm, "@Bom_MID", DbType.Decimal, objInfo.Bom_MID)
                db.AddInParameter(dbComm, "@BomAddVersion", DbType.Boolean, objInfo.BomAddVersion)
                db.AddInParameter(dbComm, "@AlterType", DbType.Int32, objInfo.AlterType)
                db.AddInParameter(dbComm, "@Disabletactic", DbType.Int32, objInfo.DisableTactic)
                db.ExecuteNonQuery(dbComm)
                MrpBomChangeEntry_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChangeEntry_Add = False
            End Try
        End Function

        Public Function MrpBomChangeEntry_GetProcess() As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetSqlStringCommand("select PS_NO,PS_Name from processsub ")

                Dim ds As New DataSet
                ds = db.ExecuteDataSet(dbComm)
                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                Else
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChangeEntry_GetProcess = Nothing
            End Try
        End Function

        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="M_Code"></param>
        ''' <param name="IsAdd">是否是增加材料</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function MrpBomChangeEntry_GetBomInfo(ByVal IsAdd As Boolean, ByVal M_Code As String, ByVal AfterM_Code As String) As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MrpBomChangeEntry_GetBomInfo")
                db.AddInParameter(dbComm, "@IsAdd", DbType.Boolean, IsAdd)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
                db.AddInParameter(dbComm, "@AfterM_Code", DbType.String, AfterM_Code)
                Dim ds As New DataSet
                ds = db.ExecuteDataSet(dbComm)
                If ds.Tables.Count > 0 Then
                    Return ds.Tables(0)
                End If
                Return Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
                MrpBomChangeEntry_GetBomInfo = Nothing
            End Try
        End Function

    End Class
End Namespace
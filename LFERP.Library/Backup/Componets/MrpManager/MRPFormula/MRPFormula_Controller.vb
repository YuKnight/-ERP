Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.MrpManager.MrpFormula
    Public Class MRPFormulaController
        Friend Function FillMRPFormula(ByVal reader As IDataReader) As MRPFormulaInfo
            Dim objInfo As New MRPFormulaInfo

            'objInfo.AutoID = reader("AutoID").ToString
            objInfo.FormulaID = reader("FormulaID").ToString
            objInfo.FormulaName = reader("FormulaName").ToString
            objInfo.Formula_CH = reader("Formula_CH").ToString
            objInfo.Formula_EN = reader("Formula_EN").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = CStr(reader("CreateDate"))
            End If
            objInfo.Remarks = reader("Remarks").ToString
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = CStr(reader("ModifyDate"))
            End If

            If reader("InCheck") Is DBNull.Value Then
                objInfo.InCheck = Nothing
            Else
                objInfo.InCheck = reader("InCheck")
            End If
            Return objInfo
        End Function



        Public Function MRPFormula_GetList() As List(Of MRPFormulaInfo)
            'ByVal AutoID As Double, ByVal FormulaID As String, ByVal FormulaName As String, ByVal Formula As String, ByVal CreateUserID As String, ByVal CreateDate As DateTime, ByVal Remarks As String, ByVal ModifyUserID As String, ByVal ModifyDate As DateTime) As List(Of MRPFormulaInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MRPFormula_GetList")
            'db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
            'db.AddInParameter(dbComm, "@FormulaID", DbType.String, FormulaID)
            'db.AddInParameter(dbComm, "@FormulaName", DbType.String, FormulaName)
            'db.AddInParameter(dbComm, "@Formula", DbType.String, Formula)
            'db.AddInParameter(dbComm, "@CreateUserID", DbType.String, CreateUserID)
            'db.AddInParameter(dbComm, "@CreateDate", DbType.DateTime, CreateDate)
            'db.AddInParameter(dbComm, "@Remarks", DbType.String, Remarks)
            'db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, ModifyUserID)
            'db.AddInParameter(dbComm, "@ModifyDate", DbType.DateTime, ModifyDate)

            Dim FeatureList As New List(Of MRPFormulaInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMRPFormula(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function MRPFormula_Delete(ByVal FormulaID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MRPFormula_Delete")
                db.AddInParameter(dbComm, "@FormulaID", DbType.String, FormulaID)
                db.ExecuteNonQuery(dbComm)
                MRPFormula_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MRPFormula_Delete = False
            End Try
        End Function


        Public Function MRPFormula_Update(ByVal objinfo As MRPFormulaInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MRPFormula_Update")
                'db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@FormulaID", DbType.String, objinfo.FormulaID)
                db.AddInParameter(dbComm, "@FormulaName", DbType.String, objinfo.FormulaName)
                db.AddInParameter(dbComm, "@Formula_CH", DbType.String, objinfo.Formula_CH)
                db.AddInParameter(dbComm, "@Formula_EN", DbType.String, objinfo.Formula_EN)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objinfo.Remarks)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                If objinfo.ModifyDate = Nothing Then
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)
                End If
                If objinfo.InCheck = Nothing Then
                    db.AddInParameter(dbComm, "@InCheck", DbType.Boolean, False)
                Else
                    db.AddInParameter(dbComm, "@InCheck", DbType.Boolean, objinfo.InCheck)
                End If
                db.ExecuteNonQuery(dbComm)
                MRPFormula_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MRPFormula_Update = False
            End Try
        End Function


        Public Function MRPFormula_Add(ByVal objInfo As MRPFormulaInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MRPFormula_Add")
                'db.AddInParameter(dbComm, "@FormulaID", DbType.String, objInfo.FormulaID)
                db.AddInParameter(dbComm, "@FormulaName", DbType.String, objInfo.FormulaName)
                db.AddInParameter(dbComm, "@Formula_CH", DbType.String, objInfo.Formula_CH)
                db.AddInParameter(dbComm, "@Formula_EN", DbType.String, objInfo.Formula_EN)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                If objInfo.CreateDate = Nothing Then
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)
                End If
                If objInfo.InCheck = Nothing Then
                    db.AddInParameter(dbComm, "@InCheck", DbType.Boolean, False)
                Else
                    db.AddInParameter(dbComm, "@InCheck", DbType.Boolean, objInfo.InCheck)
                End If
                db.ExecuteNonQuery(dbComm)
                MRPFormula_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MRPFormula_Add = False
            End Try
        End Function

    End Class
End Namespace
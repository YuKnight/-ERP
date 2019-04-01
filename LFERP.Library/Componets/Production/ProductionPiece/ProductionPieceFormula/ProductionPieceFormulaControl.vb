
Imports System.Data.Common
Namespace LFERP.Library.ProductionPieceFormula
    Public Class ProductionPieceFormulaControl

        ''' <summary>
        '''查詢出 
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="FormulaID"></param>
        ''' <param name="FormulaName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionPieceFormula_GetList(ByVal AutoID As String, ByVal FormulaID As String, ByVal FormulaName As String, ByVal InCheck As String) As List(Of ProductionPieceFormulaInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceFormula_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@FormulaID", DbType.String, FormulaID)
            db.AddInParameter(dbComm, "@FormulaName", DbType.String, FormulaName) '
            db.AddInParameter(dbComm, "@InCheck", DbType.String, InCheck) 'InCheck

            Dim FeatureList As New List(Of ProductionPieceFormulaInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPieceFormula(reader))
                End While
                Return FeatureList
            End Using
        End Function

        ''' <summary>
        ''' 加載數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPieceFormula(ByVal reader As IDataReader) As ProductionPieceFormulaInfo
            ' On Error Resume Next
            Dim ai As New ProductionPieceFormulaInfo

            If reader("AutoID") Is DBNull.Value Then
                ai.AutoID = Nothing
            Else
                ai.AutoID = reader("AutoID").ToString
            End If

            If reader("FormulaID") Is DBNull.Value Then
                ai.FormulaID = Nothing
            Else
                ai.FormulaID = reader("FormulaID").ToString
            End If

            If reader("FormulaName") Is DBNull.Value Then
                ai.FormulaName = Nothing
            Else
                ai.FormulaName = reader("FormulaName").ToString
            End If

            If reader("Formula") Is DBNull.Value Then
                ai.Formula = Nothing
            Else
                ai.Formula = reader("Formula").ToString
            End If

            If reader("InCheck") Is DBNull.Value Then
                ai.InCheck = Nothing
            Else
                ai.InCheck = reader("InCheck")
            End If


            Return ai

        End Function


        ''' <summary>
        ''' 增加
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceFormula_Add(ByVal obj As ProductionPieceFormulaInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceFormula_Add")

                db.AddInParameter(dbcomm, "@FormulaID", DbType.String, obj.FormulaID)
                db.AddInParameter(dbcomm, "@FormulaName", DbType.String, obj.FormulaName)
                db.AddInParameter(dbcomm, "@Formula", DbType.String, obj.Formula)
                db.AddInParameter(dbcomm, "@InCheck", DbType.Boolean, obj.InCheck)

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceFormula_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceFormula_Add = False
            End Try
        End Function

        ''' <summary>
        ''' 修改
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceFormula_Update(ByVal obj As ProductionPieceFormulaInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceFormula_Update")


                db.AddInParameter(dbcomm, "@FormulaID", DbType.String, obj.FormulaID)
                db.AddInParameter(dbcomm, "@FormulaName", DbType.String, obj.FormulaName)
                db.AddInParameter(dbcomm, "@Formula", DbType.String, obj.Formula)
                db.AddInParameter(dbcomm, "@InCheck", DbType.Boolean, obj.InCheck)

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceFormula_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceFormula_Update = False
            End Try
        End Function


        ''' <summary>
        ''' 刪除
        ''' </summary>
        ''' <param name="AutoID"></param>
        ''' <param name="FormulaName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceFormula_Delete(ByVal AutoID As String, ByVal FormulaName As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceFormula_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbcomm, "@FormulaName", DbType.String, FormulaName)

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceFormula_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceFormula_Delete = False
            End Try
        End Function
    End Class
End Namespace
Imports System.Data.Common
Imports LFERP.Library.ProductionPieceWorkGroup
Imports LFERP.Library.ProductionPiecePersonnel
Imports LFERP.Library.ProductionSumPiecePersonnel
Imports LFERP.Library.ProductionSumTimePersonnel
Imports LFERP.Library.ProductionSumPieceWorkGroup
Imports LFERP.Library.ProductionSumTimeWorkGroup
Imports LFERP.Library.ProductionPiecePayPersonnel
Imports LFERP.Library.ProductionPiecePayWGMain
Imports LFERP.Library.ProductionPieceProcess



Namespace LFERP.Library.ProductionPiece_Select
    Public Class ProductionPiece_SelectControl
        ''' <summary>
        ''' 組別名單查詢
        ''' </summary>
        ''' <param name="ProductionModule"></param>
        ''' <param name="strWhere"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceWorkGroup_GetListSelect(ByVal ProductionModule As String, ByVal strWhere As String) As List(Of ProductionPieceWorkGroupInfo)
            Dim PPWC As New ProductionPieceWorkGroupControl


            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiece_Select")

            db.AddInParameter(dbComm, "@ProductionModule", DbType.String, ProductionModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere) '

            Dim FeatureList As New List(Of ProductionPieceWorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(PPWC.FillProductionPieceWorkGroup(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 個人名單
        ''' </summary>
        ''' <param name="ProductionModule"></param>
        ''' <param name="strWhere"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePersonnel_GetListSelect(ByVal ProductionModule As String, ByVal strWhere As String) As List(Of ProductionPiecePersonnelInfo)
            Dim PPP As New ProductionPiecePersonnelControl

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiece_Select")

            db.AddInParameter(dbComm, "@ProductionModule", DbType.String, ProductionModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere) '

            Dim FeatureList As New List(Of ProductionPiecePersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(PPP.FillProductionPiecePersonnel(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 個人計件
        ''' </summary>
        ''' <param name="ProductionModule"></param>
        ''' <param name="strWhere"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumPiecePersonnel_GetListSelect(ByVal ProductionModule As String, ByVal strWhere As String) As List(Of ProductionSumPiecePersonnelInfo)
            Dim PPP As New ProductionSumPiecePersonnelControl

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiece_Select")

            db.AddInParameter(dbComm, "@ProductionModule", DbType.String, ProductionModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere) '

            Dim FeatureList As New List(Of ProductionSumPiecePersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(PPP.FillProductionSumPiecePersonnel(reader, Nothing, Nothing, Nothing))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 個人計時
        ''' </summary>
        ''' <param name="ProductionModule"></param>
        ''' <param name="strWhere"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumTimePersonnel_GetListSelect(ByVal ProductionModule As String, ByVal strWhere As String) As List(Of ProductionSumTimePersonnelInfo)
            Dim PPP As New ProductionSumTimePersonnelControl

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiece_Select")

            db.AddInParameter(dbComm, "@ProductionModule", DbType.String, ProductionModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere) '

            Dim FeatureList As New List(Of ProductionSumTimePersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(PPP.FillProductionSumTimePersonnel(reader, Nothing, Nothing, Nothing))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 組別計件
        ''' </summary>
        ''' <param name="ProductionModule"></param>
        ''' <param name="strWhere"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumPieceWorkGroup_GetListSelect(ByVal ProductionModule As String, ByVal strWhere As String) As List(Of ProductionSumPieceWorkGroupInfo)
            Dim PPP As New ProductionSumPieceWorkGroupControl

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiece_Select")

            db.AddInParameter(dbComm, "@ProductionModule", DbType.String, ProductionModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere) '

            Dim FeatureList As New List(Of ProductionSumPieceWorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(PPP.FillProductionSumPieceWorkGroup(reader, Nothing, Nothing, Nothing))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 組別計時
        ''' </summary>
        ''' <param name="ProductionModule"></param>
        ''' <param name="strWhere"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumTimeWorkGroup_GetListSelect(ByVal ProductionModule As String, ByVal strWhere As String) As List(Of ProductionSumTimeWorkGroupInfo)
            Dim PPP As New ProductionSumTimeWorkGroupControl

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiece_Select")

            db.AddInParameter(dbComm, "@ProductionModule", DbType.String, ProductionModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere) '

            Dim FeatureList As New List(Of ProductionSumTimeWorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(PPP.FillProductionSumTimeWorkGroup(reader, Nothing, Nothing, Nothing))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 個人薪金
        ''' </summary>
        ''' <param name="ProductionModule"></param>
        ''' <param name="strWhere"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayPersonnel_GetListSelect(ByVal ProductionModule As String, ByVal strWhere As String) As List(Of ProductionPiecePayPersonnelInfo)
            Dim PPP As New ProductionPiecePayPersonnelContol

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiece_Select")

            db.AddInParameter(dbComm, "@ProductionModule", DbType.String, ProductionModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere) '

            Dim FeatureList As New List(Of ProductionPiecePayPersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(PPP.FillProductionPiecePayPersonnel(reader, Nothing, Nothing, Nothing))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 組別薪金
        ''' </summary>
        ''' <param name="ProductionModule"></param>
        ''' <param name="strWhere"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePayWGMain_GetListSelect(ByVal ProductionModule As String, ByVal strWhere As String) As List(Of ProductionPiecePayWGMainInfo)
            Dim PPP As New ProductionPiecePayWGMainControl

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiece_Select")

            db.AddInParameter(dbComm, "@ProductionModule", DbType.String, ProductionModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere) '

            Dim FeatureList As New List(Of ProductionPiecePayWGMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(PPP.FillProductionPiecePayWGMain(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 計件工藝查詢
        ''' </summary>
        ''' <param name="ProductionModule"></param>
        ''' <param name="strWhere"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceProcess_GetListSelect(ByVal ProductionModule As String, ByVal strWhere As String) As List(Of ProductionPieceProcessInfo)
            Dim PPWC As New ProductionPieceProcessControl

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiece_Select")

            db.AddInParameter(dbComm, "@ProductionModule", DbType.String, ProductionModule)
            db.AddInParameter(dbComm, "@strWhere", DbType.String, strWhere) '

            Dim FeatureList As New List(Of ProductionPieceProcessInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(PPWC.FillProductionPieceProcess(reader))
                End While
                Return FeatureList
            End Using

        End Function


    End Class
End Namespace


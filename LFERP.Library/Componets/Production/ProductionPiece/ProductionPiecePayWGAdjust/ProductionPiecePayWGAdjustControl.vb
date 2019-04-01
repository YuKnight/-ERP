Imports System.Data.Common

Namespace LFERP.Library.ProductionPiecePayWGAdjust
    Public Class ProductionPiecePayWGAdjustControl

        Public Function ProductionPiecePayWGAdjust_GetList(ByVal AutoID As String, ByVal OUT_G_NO As String, ByVal OUT_FacID As String, ByVal OUT_DepID As String, ByVal IN_G_NO As String, ByVal IN_FacID As String, ByVal IN_DepID As String, ByVal Ad_YYMM As String, _
                                                    ByVal AddDateS As String, ByVal AddDateE As String, ByVal Ad_Check As String) As List(Of ProductionPiecePayWGAdjustInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGAdjust_GetList")

            db.AddInParameter(dbComm, "@AutoID", DbType.Int32, AutoID) ' 

            db.AddInParameter(dbComm, "@OUT_G_NO", DbType.String, OUT_G_NO)
            db.AddInParameter(dbComm, "@OUT_FacID", DbType.String, OUT_FacID)
            db.AddInParameter(dbComm, "@OUT_DepID", DbType.String, OUT_DepID)

            db.AddInParameter(dbComm, "@IN_G_NO", DbType.String, IN_G_NO) '
            db.AddInParameter(dbComm, "@IN_FacID", DbType.String, IN_FacID)
            db.AddInParameter(dbComm, "@IN_DepID", DbType.String, IN_DepID)

            db.AddInParameter(dbComm, "@Ad_YYMM", DbType.String, Ad_YYMM)
            db.AddInParameter(dbComm, "@AddDateS", DbType.String, AddDateS)
            db.AddInParameter(dbComm, "@AddDateE", DbType.String, AddDateE)
            db.AddInParameter(dbComm, "@Ad_Check", DbType.Boolean, Ad_Check)

            Dim FeatureList As New List(Of ProductionPiecePayWGAdjustInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPiecePayWGAdjust(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' ¸ü¤J¼Æ¾Ú
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPiecePayWGAdjust(ByVal reader As IDataReader) As ProductionPiecePayWGAdjustInfo
            Dim ai As New ProductionPiecePayWGAdjustInfo

            ai.AutoID = reader("AutoID").ToString

            If reader("OUT_G_NO") Is DBNull.Value Then
                ai.OUT_G_NO = Nothing
            Else
                ai.OUT_G_NO = reader("OUT_G_NO").ToString
            End If

            If reader("OUT_FacID") Is DBNull.Value Then
                ai.OUT_FacID = Nothing
            Else
                ai.OUT_FacID = reader("OUT_FacID").ToString
            End If

            If reader("OUT_DepID") Is DBNull.Value Then
                ai.OUT_DepID = Nothing
            Else
                ai.OUT_DepID = reader("OUT_DepID").ToString
            End If

            If reader("IN_G_NO") Is DBNull.Value Then
                ai.IN_G_NO = Nothing
            Else
                ai.IN_G_NO = reader("IN_G_NO").ToString
            End If

            If reader("IN_FacID") Is DBNull.Value Then
                ai.IN_FacID = Nothing
            Else
                ai.IN_FacID = reader("IN_FacID").ToString
            End If

            If reader("IN_DepID") Is DBNull.Value Then
                ai.IN_DepID = Nothing
            Else
                ai.IN_DepID = reader("IN_DepID").ToString
            End If

            If reader("Amount") Is DBNull.Value Then
                ai.Amount = 0
            Else
                ai.Amount = CDbl(reader("Amount").ToString)
            End If

            If reader("Ad_YYMM") Is DBNull.Value Then
                ai.Ad_YYMM = Nothing
            Else
                ai.Ad_YYMM = reader("Ad_YYMM").ToString
            End If

            If reader("Ad_Reason") Is DBNull.Value Then
                ai.Ad_Reason = Nothing
            Else
                ai.Ad_Reason = reader("Ad_Reason").ToString
            End If

            If reader("AddUserID") Is DBNull.Value Then
                ai.AddUserID = Nothing
            Else
                ai.AddUserID = reader("AddUserID").ToString
            End If

            If reader("AddDate") Is DBNull.Value Then
                ai.AddDate = Nothing
            Else
                ai.AddDate = reader("AddDate").ToString
            End If

            If reader("Ad_Check") Is DBNull.Value Then
                ai.Ad_Check = False
            Else
                ai.Ad_Check = reader("Ad_Check")
            End If

            If reader("Ad_CheckDate") Is DBNull.Value Then
                ai.Ad_CheckDate = Nothing
            Else
                ai.Ad_CheckDate = reader("Ad_CheckDate").ToString
            End If

            If reader("Ad_CheckUserID") Is DBNull.Value Then
                ai.Ad_CheckUserID = Nothing
            Else
                ai.Ad_CheckUserID = reader("Ad_CheckUserID").ToString
            End If

            If reader("OUT_G_Name") Is DBNull.Value Then
                ai.OUT_G_Name = Nothing
            Else
                ai.OUT_G_Name = reader("OUT_G_Name").ToString
            End If

            If reader("OUT_FacName") Is DBNull.Value Then
                ai.OUT_FacName = Nothing
            Else
                ai.OUT_FacName = reader("OUT_FacName").ToString
            End If

            If reader("OUT_DepName") Is DBNull.Value Then
                ai.OUT_DepName = Nothing
            Else
                ai.OUT_DepName = reader("OUT_DepName").ToString
            End If

            If reader("IN_G_Name") Is DBNull.Value Then
                ai.IN_G_Name = Nothing
            Else
                ai.IN_G_Name = reader("IN_G_Name").ToString
            End If

            If reader("IN_FacName") Is DBNull.Value Then
                ai.IN_FacName = Nothing
            Else
                ai.IN_FacName = reader("IN_FacName").ToString
            End If

            If reader("IN_DepName") Is DBNull.Value Then
                ai.IN_DepName = Nothing
            Else
                ai.IN_DepName = reader("IN_DepName").ToString
            End If

            If reader("AddUserIDName") Is DBNull.Value Then
                ai.AddUserIDName = Nothing
            Else
                ai.AddUserIDName = reader("AddUserIDName").ToString
            End If

            If reader("Ad_CheckUserName") Is DBNull.Value Then
                ai.Ad_CheckUserName = Nothing
            Else
                ai.Ad_CheckUserName = reader("Ad_CheckUserName").ToString
            End If

            Return ai

        End Function


        Public Function ProductionPiecePayWGAdjust_Add(ByVal obj As ProductionPiecePayWGAdjustInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGAdjust_Add")

                db.AddInParameter(dbcomm, "@OUT_G_NO", DbType.String, obj.OUT_G_NO)
                db.AddInParameter(dbcomm, "@OUT_FacID", DbType.String, obj.OUT_FacID)
                db.AddInParameter(dbcomm, "@OUT_DepID", DbType.String, obj.OUT_DepID)

                db.AddInParameter(dbcomm, "@IN_G_NO", DbType.String, obj.IN_G_NO)
                db.AddInParameter(dbcomm, "@IN_FacID", DbType.String, obj.IN_FacID)
                db.AddInParameter(dbcomm, "@IN_DepID", DbType.String, obj.IN_DepID)

                db.AddInParameter(dbcomm, "@Amount", DbType.Double, obj.Amount)
                db.AddInParameter(dbcomm, "@Ad_YYMM", DbType.String, obj.Ad_YYMM)
                db.AddInParameter(dbcomm, "@Ad_Reason", DbType.String, obj.Ad_Reason)

                db.AddInParameter(dbcomm, "@AddUserID", DbType.String, obj.AddUserID)
                db.AddInParameter(dbcomm, "@AddDate", DbType.Date, obj.AddDate)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGAdjust_Add = True


            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGAdjust_Add = False
            End Try
        End Function

        Public Function ProductionPiecePayWGAdjust_Update(ByVal obj As ProductionPiecePayWGAdjustInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGAdjust_Update")

                db.AddInParameter(dbcomm, "@AutoID", DbType.Int32, obj.AutoID) ' 

                db.AddInParameter(dbcomm, "@OUT_G_NO", DbType.String, obj.OUT_G_NO)
                db.AddInParameter(dbcomm, "@OUT_FacID", DbType.String, obj.OUT_FacID)
                db.AddInParameter(dbcomm, "@OUT_DepID", DbType.String, obj.OUT_DepID)

                db.AddInParameter(dbcomm, "@IN_G_NO", DbType.String, obj.IN_G_NO)
                db.AddInParameter(dbcomm, "@IN_FacID", DbType.String, obj.IN_FacID)
                db.AddInParameter(dbcomm, "@IN_DepID", DbType.String, obj.IN_DepID)

                db.AddInParameter(dbcomm, "@Amount", DbType.Double, obj.Amount)
                db.AddInParameter(dbcomm, "@Ad_YYMM", DbType.String, obj.Ad_YYMM)
                db.AddInParameter(dbcomm, "@Ad_Reason", DbType.String, obj.Ad_Reason)

                db.AddInParameter(dbcomm, "@AddUserID", DbType.String, obj.AddUserID)
                db.AddInParameter(dbcomm, "@AddDate", DbType.Date, obj.AddDate)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGAdjust_Update = True


            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGAdjust_Update = False
            End Try
        End Function

        Public Function ProductionPiecePayWGAdjust_Delete(ByVal AutoID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGAdjust_Delete")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGAdjust_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGAdjust_Delete = False
            End Try
        End Function

        Public Function ProductionPiecePayWGAdjust_UpdateCheck(ByVal obj As ProductionPiecePayWGAdjustInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePayWGAdjust_UpdateCheck")

                db.AddInParameter(dbcomm, "@AutoID", DbType.Int32, obj.AutoID) ' 

                db.AddInParameter(dbcomm, "@Ad_Check", DbType.Boolean, obj.Ad_Check)
                db.AddInParameter(dbcomm, "@Ad_CheckDate", DbType.Date, obj.Ad_CheckDate)
                db.AddInParameter(dbcomm, "@Ad_CheckUserID", DbType.String, obj.Ad_CheckUserID)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePayWGAdjust_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePayWGAdjust_UpdateCheck = False
            End Try
        End Function


    End Class

End Namespace



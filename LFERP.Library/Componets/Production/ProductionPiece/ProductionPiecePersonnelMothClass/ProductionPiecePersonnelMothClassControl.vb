Namespace LFERP.Library.ProductionPiecePersonnelMothClass

    Public Class ProductionPiecePersonnelMothClassControl

        Public Function ProductionPiecePersonnelMothClass_GetList(ByVal Per_NO As String, ByVal Per_Date As String, ByVal Per_Class As String) As List(Of ProductionPiecePersonnelMothClassInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnelMothClass_GetList")

            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO)
            db.AddInParameter(dbComm, "@Per_Date", DbType.String, Per_Date)
            db.AddInParameter(dbComm, "@Per_Class", DbType.String, Per_Class)

            Dim FeatureList As New List(Of ProductionPiecePersonnelMothClassInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPiecePersonnelMothClass(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 載入數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPiecePersonnelMothClass(ByVal reader As IDataReader) As ProductionPiecePersonnelMothClassInfo
            Dim ai As New ProductionPiecePersonnelMothClassInfo

            ai.AutoID = reader("AutoID").ToString

            If reader("Per_NO") Is DBNull.Value Then
                ai.Per_NO = Nothing
            Else
                ai.Per_NO = reader("Per_NO").ToString
            End If

            If reader("Per_Name") Is DBNull.Value Then
                ai.Per_Name = Nothing
            Else
                ai.Per_Name = reader("Per_Name").ToString
            End If

            If reader("Per_Date") Is DBNull.Value Then
                ai.Per_Date = Nothing
            Else
                ai.Per_Date = reader("Per_Date").ToString
            End If

            If reader("Per_Class") Is DBNull.Value Then
                ai.Per_Class = Nothing
            Else
                ai.Per_Class = reader("Per_Class").ToString
            End If

            Return ai

        End Function
        ''' <summary>
        ''' 數據增加
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionPiecePersonnelMothClass_Add(ByVal obj As ProductionPiecePersonnelMothClassInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnelMothClass_Add")

                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO)
                db.AddInParameter(dbcomm, "@Per_Date", DbType.String, obj.Per_Date)
                db.AddInParameter(dbcomm, "@Per_Class", DbType.String, obj.Per_Class)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePersonnelMothClass_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPiecePersonnelMothClass_Add = False
            End Try
        End Function

        ''' <summary>
        ''' 更新記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPiecePersonnelMothClass_Update(ByVal obj As ProductionPiecePersonnelMothClassInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPiecePersonnelMothClass_Update")

                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO)
                db.AddInParameter(dbcomm, "@Per_Date", DbType.String, obj.Per_Date)
                db.AddInParameter(dbcomm, "@Per_Class", DbType.String, obj.Per_Class)

                db.ExecuteNonQuery(dbcomm)
                ProductionPiecePersonnelMothClass_Update = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionPiecePersonnelMothClass_Update = False
            End Try
        End Function

    End Class
End Namespace
Namespace LFERP.Library.ProductProcess
    Public Class ProcessTypeControl
        ''' <summary>
        ''' 琩高眔场獺
        ''' </summary>
        Public Function ProcessType_GetList(ByVal D_TypeID As String, ByVal D_Type As String, ByVal D_IsSub As String) As List(Of ProcessTypeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProcessType_GetList")

            db.AddInParameter(dbComm, "@D_TypeID", DbType.String, D_TypeID)
            db.AddInParameter(dbComm, "@D_Type", DbType.String, D_Type)
            db.AddInParameter(dbComm, "@D_IsSub", DbType.String, D_IsSub)

            Dim FeatureList As New List(Of ProcessTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProcessType(reader))
                End While
                Return FeatureList
            End Using
        End Function
        ''' <summary>
        ''' 琩高眔场獺
        ''' </summary>
        Public Function ProcessTypeA_GetList(ByVal D_TypeID As String, ByVal D_Type As String) As List(Of ProcessTypeInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProcessTypeA_GetList")

            db.AddInParameter(dbComm, "@D_TypeID", DbType.String, D_TypeID)
            db.AddInParameter(dbComm, "@D_Type", DbType.String, D_Type)

            Dim FeatureList As New List(Of ProcessTypeInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProcessType(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function FillProcessType(ByVal reader As IDataReader) As ProcessTypeInfo
            On Error Resume Next
            Dim fpty As New ProcessTypeInfo
            fpty.AutoID = CDbl(reader("AutoID").ToString)
            fpty.D_TypeID = reader("D_TypeID").ToString.Trim
            fpty.D_Dep = reader("D_Dep").ToString.Trim
            fpty.D_ID = reader("D_ID").ToString.Trim
            fpty.NumberID = CInt(reader("NumberID").ToString)
            fpty.D_IsSub = CBool(reader("D_IsSub").ToString)
            fpty.D_ProcessName = reader("D_ProcessName").ToString
            fpty.D_Type = reader("D_Type").ToString.Trim
            fpty.Remarks = reader("Remarks").ToString
            Return fpty
        End Function


        Public Function ProcessType_Delete(ByVal D_TypeID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProcessType_Delete")
                db.AddInParameter(dbComm, "@D_TypeID", DbType.String, D_TypeID)
                db.ExecuteNonQuery(dbComm)
                ProcessType_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProcessType_Delete = False
            End Try
        End Function

        Public Function ProcessType_Add(ByVal objInfo As ProcessTypeInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProcessType_Add")
                db.AddInParameter(dbComm, "@NumberID", DbType.Int64, objInfo.NumberID)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objInfo.D_ID)
                db.AddInParameter(dbComm, "@D_TypeID", DbType.String, objInfo.D_TypeID)
                db.AddInParameter(dbComm, "@D_Type", DbType.String, objInfo.D_Type)
                db.AddInParameter(dbComm, "@D_Dep", DbType.String, objInfo.D_Dep)
                db.AddInParameter(dbComm, "@D_ProcessName", DbType.String, objInfo.D_ProcessName)
                db.AddInParameter(dbComm, "@D_IsSub", DbType.Boolean, objInfo.D_IsSub)
                db.AddInParameter(dbComm, "@Remarks", DbType.String, objInfo.Remarks)
                db.ExecuteNonQuery(dbComm)
                ProcessType_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProcessType_Add = False
            End Try
        End Function

        Public Function ProcessType_GetID() As String
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProcessType_GetID")
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        Return reader("D_TypeID").ToString
                    Else
                        Return Nothing
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "い丁糷:ProcessType_GetIDよ猭岿")
                Return Nothing
            End Try
        End Function

        Public Function ProcessType_TypeIsExists(ByVal D_Type As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProcessType_TypeIsExists")
                db.AddInParameter(dbComm, "@D_Type", DbType.String, D_Type)
                If db.ExecuteNonQuery(dbComm) > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return True
            End Try
        End Function

    End Class
End Namespace


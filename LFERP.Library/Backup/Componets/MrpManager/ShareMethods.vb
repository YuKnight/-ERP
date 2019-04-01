Module ShareMethods

    'Public Function MRP_PreDelete(ByVal sqlStr As String, ByVal msgInfo As String) As Boolean

    '    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
    '    Dim dbComm As DbCommand = db.GetSqlStringCommand(sqlStr)
    '    Using reader As IDataReader = db.ExecuteReader(dbComm)
    '        If reader.Read Then
    '            MsgBox(msgInfo, MsgBoxStyle.Information, "提示")
    '            Return False
    '        End If
    '    End Using
    '    Return True
    'End Function

    Public Function MRP_PreDelete(ByVal list As List(Of String)) As Boolean
        Try
            For i As Int16 = 0 To list.Count - 1 Step 2
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetSqlStringCommand(list(i))
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        MsgBox("編號為" + reader(0) + list(i + 1), MsgBoxStyle.Information, "提示")
                        Return False
                    End If
                End Using
            Next
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "MRP_PreDelete方法出錯")
            Return False
        End Try
    End Function

End Module

Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class GetPerAndTeamControllerKnife

        Public Function GetTeam(ByVal whid As String) As List(Of GetPerAndTeamInfoKnife)
            Dim sql As String = "select G_NO ,G_Name  from KnifeGroup"
            Dim str As String
            If whid = Nothing Then
                str = Nothing
            Else
                str = " where WH_ID  ='" + whid + "'"
            End If
            sql = sql + str
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of GetPerAndTeamInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillGetTeam(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        Friend Function FillGetTeam(ByVal reader As IDataReader) As GetPerAndTeamInfoKnife
            Dim gpinfo As New GetPerAndTeamInfoKnife
            gpinfo.G_NO = IIf(IsDBNull(reader("G_NO")), Nothing, reader("G_NO"))
            gpinfo.G_Name = IIf(IsDBNull(reader("G_Name")), Nothing, reader("G_Name"))
            Return gpinfo
        End Function

        Public Function GetPerByTeam(ByVal team As String, ByVal whid As String) As List(Of GetPerAndTeamInfoKnife)
            Dim sql As String = "select W_UserID as Per_ID,W_UserName as Per_Name from WhiteUserList where GNO  ='" + team + "'"
            Dim str As String
            If whid = Nothing Then
                str = Nothing
            Else
                str = " and WH_ID ='" + whid + "'"
            End If
            sql = sql + str
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of GetPerAndTeamInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillGetPer(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        Public Function GetPerByWHID(ByVal whid As String) As List(Of GetPerAndTeamInfoKnife)
            Dim sql As String = "select W_UserID as Per_ID,W_UserName as Per_Name from WhiteUserList where WH_ID ='" + whid + "' ORDER BY Per_ID ASC"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of GetPerAndTeamInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillGetPer(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        Friend Function FillGetPer(ByVal reader As IDataReader) As GetPerAndTeamInfoKnife
            Dim gpinfo As New GetPerAndTeamInfoKnife
            gpinfo.Per_ID = IIf(IsDBNull(reader("Per_ID")), Nothing, reader("Per_ID"))
            gpinfo.Per_Name = IIf(IsDBNull(reader("Per_Name")), Nothing, reader("Per_Name"))
            Return gpinfo
        End Function

    End Class
End Namespace
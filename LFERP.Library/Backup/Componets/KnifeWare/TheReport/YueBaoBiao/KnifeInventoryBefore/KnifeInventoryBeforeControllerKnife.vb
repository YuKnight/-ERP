Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class KnifeInventoryBeforeControllerKnife

        Public Function GetKnifeInventoryBeforeM_Name() As List(Of KnifeInventoryBeforeInfoKnife)
            Dim sql As String = "select distinct MaterialCode.M_Name  from MaterialCode inner join KnifeWareInventorySub on MaterialCode .M_Code = KnifeWareInventorySub.M_Code "
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim mycommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim mydatareader As IDataReader = mycommand.ExecuteReader
            Dim featurelist As New List(Of KnifeInventoryBeforeInfoKnife)
            While mydatareader.Read
                featurelist.Add(FillKnifeInventoryBeforeM_Name(mydatareader))
            End While
            conn.Close()
            mydatareader.Close()
            Return featurelist
        End Function

        Public Function GetKnifeInventoryBeforeM_Gauge(ByVal str As String) As List(Of KnifeInventoryBeforeInfoKnife)
            Dim sql As String = "select distinct MaterialCode.M_Gauge  from MaterialCode where MaterialCode.M_Name ='" + str + "' "
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim mycommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim mydatareader As IDataReader = mycommand.ExecuteReader
            Dim featurelist As New List(Of KnifeInventoryBeforeInfoKnife)
            While mydatareader.Read
                featurelist.Add(FillKnifeInventoryBeforeM_Gauge(mydatareader))
            End While
            conn.Close()
            mydatareader.Close()
            Return featurelist
        End Function

        Friend Function FillKnifeInventoryBeforeM_Name(ByVal reader As IDataReader) As KnifeInventoryBeforeInfoKnife
            Dim kibinfo As New KnifeInventoryBeforeInfoKnife
            kibinfo.M_Name = reader("M_Name").ToString
            Return kibinfo
        End Function

        Friend Function FillKnifeInventoryBeforeM_Gauge(ByVal reader As IDataReader) As KnifeInventoryBeforeInfoKnife
            Dim kibinfo As New KnifeInventoryBeforeInfoKnife
            kibinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            Return kibinfo
        End Function

    End Class
End Namespace
Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class InventoryKnifeMoneyControllerKnife

        Public Function GetInventoryKnifeMoney(ByVal whid As String) As List(Of InventoryKnifeMoneyInfoKnife)
            Dim sql As String = "select distinct KnifeWareInventorySub.WH_ID ,(select WareHouse .WH_Type  from WareHouse where WareHouse .WH_ID =KnifeWareInventorySub.WH_ID) as WH_Type,(select WareHouse .WH_Name from WareHouse where WareHouse .WH_ID =KnifeWareInventorySub.WH_ID) as WH_Name, MaterialCode.M_Name ,MaterialCode.M_Gauge ,MaterialCode.M_Price ,MaterialCode.M_Unit  from MaterialCode inner join KnifeWareInventorySub on MaterialCode.M_Code =KnifeWareInventorySub .M_Code "
            Dim str As String
            If whid = "all" Then
                str = Nothing
            Else
                str = " and WH_ID = '" + whid + "'"
            End If
            sql = sql + str
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim mycommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim mydatareader As IDataReader = mycommand.ExecuteReader
            Dim featurelist As New List(Of InventoryKnifeMoneyInfoKnife)
            While mydatareader.Read
                featurelist.Add(FillInventoryKnifeMoney(mydatareader))
            End While
            conn.Close()
            mydatareader.Close()
            Return featurelist
        End Function

        Friend Function FillInventoryKnifeMoney(ByVal reader As IDataReader) As InventoryKnifeMoneyInfoKnife
            Dim ikminfo As New InventoryKnifeMoneyInfoKnife
            ikminfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            ikminfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            ikminfo.M_Price = IIf(IsDBNull(reader("M_Price")), Nothing, reader("M_Price"))
            ikminfo.M_Unit = IIf(IsDBNull(reader("M_Unit")), Nothing, reader("M_Unit").ToString)
            ikminfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            ikminfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            ikminfo.WH_Type = IIf(IsDBNull(reader("WH_Type")), Nothing, reader("WH_Type").ToString)
            Return ikminfo
        End Function

    End Class
End Namespace
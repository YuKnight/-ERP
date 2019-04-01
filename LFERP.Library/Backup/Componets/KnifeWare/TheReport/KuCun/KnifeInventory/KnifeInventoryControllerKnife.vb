Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class KnifeInventoryControllerKnife

        Public Function GetKnifeInventory(ByVal whid As String) As List(Of KnifeInventoryInfoKnife)

            Dim sql As String
            If whid = "all" Then
                sql = "select KnifeWareInventorySub.WH_ID,(select WareHouse.WH_Name from WareHouse where WareHouse .WH_ID =KnifeWareInventorySub .WH_ID) as WH_Name,KnifeWareInventorySub.WI_SQty ,KnifeWareInventorySub.WI_SReQty ,MaterialCode.M_Name ,materialtype3.Type3Name as M_Type,MaterialCode.M_Gauge ,MaterialCode.M_Unit ,  MaterialCode.M_Remark from MaterialCode inner join MaterialType3 on MaterialCode.Type3ID=materialtype3.Type3ID  COLLATE Chinese_Taiwan_Stroke_CI_AS  inner join KnifeWareInventorySub on MaterialCode.M_Code=KnifeWareInventorySub.M_Code"
            Else
                sql = "select KnifeWareInventorySub.WH_ID,(select WareHouse.WH_Name from WareHouse where WareHouse .WH_ID =KnifeWareInventorySub .WH_ID) as WH_Name,KnifeWareInventorySub.WI_SQty ,KnifeWareInventorySub.WI_SReQty ,MaterialCode.M_Name ,materialtype3.Type3Name as M_Type,MaterialCode.M_Gauge ,MaterialCode.M_Unit , MaterialCode.M_Remark   from MaterialCode inner join MaterialType3 on MaterialCode.Type3ID=materialtype3.Type3ID  COLLATE Chinese_Taiwan_Stroke_CI_AS   inner join KnifeWareInventorySub on MaterialCode.M_Code=KnifeWareInventorySub.M_Code  where KnifeWareInventorySub.WH_ID ='" + whid + "'"
            End If
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeInventoryInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeInventory(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        Friend Function FillKnifeInventory(ByVal reader As IDataReader) As KnifeInventoryInfoKnife

            Dim kiinfo As New KnifeInventoryInfoKnife
            kiinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            kiinfo.M_Type = IIf(IsDBNull(reader("M_Type")), Nothing, reader("M_Type").ToString)
            kiinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            kiinfo.WI_SQty = IIf(IsDBNull(reader("WI_SQty")), 0, reader("WI_SQty"))
            kiinfo.WI_SReQty = IIf(IsDBNull(reader("WI_SReQty")), 0, reader("WI_SReQty"))
            kiinfo.M_Unit = IIf(IsDBNull(reader("M_Unit")), Nothing, reader("M_Unit").ToString)
            kiinfo.M_Remark = IIf(IsDBNull(reader("M_Remark")), Nothing, reader("M_Remark").ToString)
            kiinfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            kiinfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            Return kiinfo

        End Function

        Public Function GetKnifeInventoryWH() As List(Of KnifeInventoryInfoKnife)

            Dim sql As String = "SELECT distinct KnifeWareInventorySub.WH_ID,WareHouse .WH_Name from KnifeWareInventorySub inner join WareHouse on  WareHouse .WH_ID = KnifeWareInventorySub.WH_ID order by WH_ID asc"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeInventoryInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeInventoryWH(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            If FeatureList.Count > 0 Then
                FeatureList.Add(FillKnifeInventoryWHall())
            End If
            Return FeatureList

        End Function

        Friend Function FillKnifeInventoryWH(ByVal reader As IDataReader) As KnifeInventoryInfoKnife

            Dim kiinfo As New KnifeInventoryInfoKnife
            kiinfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            kiinfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            Return kiinfo

        End Function

        Friend Function FillKnifeInventoryWHall() As KnifeInventoryInfoKnife

            Dim kiinfo As New KnifeInventoryInfoKnife
            kiinfo.WH_Name = "¥þ³¡"
            kiinfo.WH_ID = "all"
            Return kiinfo

        End Function

    End Class
End Namespace
Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare

    Public Class ScatterInventoryControllerKnife

        Public Function GetScatteInventory(ByVal themonth As Date) As List(Of ScatterInventoryInfoKnife)

            Dim sql As String = "SELECT KnifeWareInventorySubBackup.WH_ID,KnifeWareInventorySubBackup.ScatterTime,KnifeWareInventorySubBackup.WI_SQty ,KnifeWareInventorySubBackup.WI_SReQty ,MaterialCode.M_Name ,MaterialCode.M_Type ,MaterialCode.M_Gauge ,MaterialCode.M_Unit ,MaterialCode.M_Remark  FROM KnifeWareInventorySubBackup inner join MaterialCode on MaterialCode.M_Code = KnifeWareInventorySubBackup.M_Code and KnifeWareInventorySubBackup.scattertime= '" + themonth + "'"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of ScatterInventoryInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillScatteInventory(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        Friend Function FillScatteInventory(ByVal reader As IDataReader) As ScatterInventoryInfoKnife

            Dim kiinfo As New ScatterInventoryInfoKnife
            kiinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            kiinfo.M_Type = IIf(IsDBNull(reader("M_Type")), Nothing, reader("M_Type").ToString)
            kiinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            kiinfo.WI_SQty = IIf(IsDBNull(reader("WI_SQty")), 0, reader("WI_SQty"))
            kiinfo.WI_SReQty = IIf(IsDBNull(reader("WI_SReQty")), 0, reader("WI_SReQty"))
            kiinfo.M_Unit = IIf(IsDBNull(reader("M_Unit")), Nothing, reader("M_Unit").ToString)
            kiinfo.M_Remark = IIf(IsDBNull(reader("M_Remark")), Nothing, reader("M_Remark").ToString)
            kiinfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            kiinfo.ScatterTime = IIf(IsDBNull(reader("ScatterTime")), Nothing, reader("ScatterTime"))
            Return kiinfo

        End Function

    End Class
End Namespace
Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class TheTimeNoReturnControllerKnife

        Public Function GetTheTimeNoReturn(ByVal bperid As String, ByVal bdate As Date) As List(Of TheTimeNoReturnInfoKnife)
            Dim sql As String = "select KnifeBorrow.B_Qty ,KnifeBorrow .BPer_ID ,KnifeBorrow .BPer_Name ,KnifeBorrow .NOReturn ,KnifeBorrow .R_Qty ,KnifeBorrow .B_Date ,null as MissQty,null as Reason,knifeborrow.WH_ID ,(select WareHouse.WH_Name  from WareHouse where WareHouse.WH_ID =KnifeBorrow .WH_ID ) as WH_Name,(select WareHouse.WH_Type from WareHouse where WareHouse.WH_ID =KnifeBorrow .WH_ID ) as WH_Type,(select MaterialCode.M_Name from MaterialCode where MaterialCode.M_Code =KnifeBorrow .M_Code) as M_Name,(select MaterialCode.M_Gauge from MaterialCode where MaterialCode.M_Code =KnifeBorrow .M_Code) as M_Gauge from KnifeBorrow where R_Date is null and B_Date <= '" + bdate + "'"
            Dim str As String
            Dim str1 As String
            If bperid = Nothing Then
                str = Nothing
            Else
                str = " and BPer_ID = '" + bperid + "'"
            End If
            str1 = " order by B_Date asc"
            sql = sql + str + str1
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of TheTimeNoReturnInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillTheTimeNoReturn(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList
        End Function

        Friend Function FillTheTimeNoReturn(ByVal reader As IDataReader) As TheTimeNoReturnInfoKnife
            Dim ttrinfo As New TheTimeNoReturnInfoKnife
            ttrinfo.B_Date = IIf(IsDBNull(reader("B_Date")), Nothing, reader("B_Date"))
            ttrinfo.B_Qty = IIf(IsDBNull(reader("B_Qty")), 0, reader("B_Qty"))
            ttrinfo.BPer_ID = IIf(IsDBNull(reader("BPer_ID")), Nothing, reader("BPer_ID").ToString)
            ttrinfo.BPer_Name = IIf(IsDBNull(reader("BPer_Name")), Nothing, reader("BPer_Name").ToString)
            ttrinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            ttrinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            ttrinfo.MissQty = IIf(IsDBNull(reader("MissQty")), 0, reader("MissQty"))
            ttrinfo.NOReturn = IIf(IsDBNull(reader("NOReturn")), 0, reader("NOReturn"))
            ttrinfo.R_Qty = IIf(IsDBNull(reader("R_Qty")), 0, reader("R_Qty"))
            ttrinfo.Reason = IIf(IsDBNull(reader("Reason")), Nothing, reader("Reason").ToString)
            ttrinfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            ttrinfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            ttrinfo.WH_Type = IIf(IsDBNull(reader("WH_Type")), Nothing, reader("WH_Type").ToString)
            Return ttrinfo
        End Function

    End Class
End Namespace
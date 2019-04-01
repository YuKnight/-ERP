Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class MonthUseKnifeMoneyControllerKnife

        Public Function GetMonthUseKnifeMoney(ByVal themonth As Date, ByVal whid As String, ByVal btype As String) As List(Of MonthUseKnifeMoneyInfoKnife)
            Dim sql As String = "select KnifeBorrow .B_Type ,KnifeBorrow .WH_ID ,KnifeBorrow .B_Date ,KnifeBorrow .BPer_Name ,KnifeBorrow .B_NO ,(select WareHouse .WH_Name from WareHouse where WareHouse .WH_ID =KnifeBorrow .WH_ID) as WH_Name,KnifeBorrow .B_Qty ,MaterialCode.M_Price from KnifeBorrow inner join MaterialCode on MaterialCode.M_Code = KnifeBorrow .M_Code "
            Dim str1 As String
            Dim str2 As String
            Dim str3 As String
            Dim str4 As String
            Dim date1 As Date
            Dim date2 As Date
            If whid = "all" Then
                str1 = Nothing
            Else
                str1 = " and WH_ID='" + whid + "'"
            End If
            date1 = themonth
            date2 = themonth.AddMonths(1)
            str2 = " and B_Date>='" + date1 + "' and B_Date<'" + date2 + "'"
            str3 = " and B_Type='" + btype + "'"
            str4 = " order by B_Date asc "
            sql = sql + str1 + str2 + str3 + str4
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of MonthUseKnifeMoneyInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillMonthUseKnifeMoney(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList
        End Function

        Friend Function FillMonthUseKnifeMoney(ByVal reader As IDataReader) As MonthUseKnifeMoneyInfoKnife
            Dim mukminfo As New MonthUseKnifeMoneyInfoKnife
            mukminfo.B_Date = IIf(IsDBNull(reader("B_Date")), Nothing, reader("B_Date"))
            mukminfo.B_NO = IIf(IsDBNull(reader("B_NO")), Nothing, reader("B_NO").ToString)
            mukminfo.BPer_Name = IIf(IsDBNull(reader("BPer_Name")), Nothing, reader("BPer_Name").ToString)
            mukminfo.B_Type = IIf(IsDBNull(reader("B_Type")), Nothing, reader("B_Type").ToString)
            mukminfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            mukminfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            mukminfo.Price = IIf(IsDBNull(reader("B_Qty")), 0, reader("B_Qty")) * IIf(IsDBNull(reader("M_Price")), 0, reader("M_Price"))
            Return mukminfo
        End Function


    End Class
End Namespace
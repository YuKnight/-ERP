Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class StaffKnifeMoneyControllerKnife

        Public Function GetStaffKnifeMoney(ByVal whid As String, ByVal thedate As Date, ByVal perno As String) As List(Of StaffKnifeMoneyInfoKnife)
            Dim sql As String = "select KnifeBorrow.WH_ID ,KnifeBorrow.BPer_ID ,KnifeBorrow.BPer_Name ,KnifeBorrow.B_Qty ,KnifeBorrow.B_Date ,KnifeBorrow.B_Type ,(select WareHouse .WH_Type from WareHouse where KnifeBorrow.WH_ID =WareHouse .WH_ID ) as WH_Type,(select WareHouse .WH_Name  from WareHouse where KnifeBorrow.WH_ID =WareHouse .WH_ID) as WH_Name,(select MaterialCode.M_Name from MaterialCode where MaterialCode.M_Code =KnifeBorrow .M_Code) as M_Name,(select MaterialCode.M_Gauge from MaterialCode where MaterialCode.M_Code =KnifeBorrow .M_Code) as M_Gauge,(select MaterialCode.M_Unit from MaterialCode where MaterialCode.M_Code =KnifeBorrow .M_Code) as M_Unit,(select MaterialCode.M_Price from MaterialCode where MaterialCode.M_Code =KnifeBorrow .M_Code) as M_Price from KnifeBorrow"
            Dim str1 As String
            Dim str2 As String
            Dim str3 As String
            Dim date1 As Date
            Dim date2 As Date
            date1 = thedate
            date2 = thedate.AddMonths(1)
            str1 = " where B_Date>='" + date1 + "' and B_Date<'" + date2 + "'"
            If whid = "all" Then
                str2 = Nothing
            Else
                str2 = " and WH_ID='" + whid + "'"
            End If
            str3 = " and BPer_ID='" + perno + "'"
            sql = sql + str1 + str2 + str3
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim mycommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim datareader As IDataReader = mycommand.ExecuteReader
            Dim featurelist As New List(Of StaffKnifeMoneyInfoKnife)
            While datareader.Read
                featurelist.Add(FillStaffKnifeMoney(datareader))
            End While
            conn.Close()
            datareader.Close()
            Return featurelist
        End Function

        Friend Function FillStaffKnifeMoney(ByVal reader As IDataReader) As StaffKnifeMoneyInfoKnife
            Dim skminfo As New StaffKnifeMoneyInfoKnife
            skminfo.B_Date = IIf(IsDBNull(reader("B_Date")), Nothing, reader("B_Date"))
            skminfo.B_Qty = IIf(IsDBNull(reader("B_Qty")), 0, reader("B_Qty"))
            skminfo.B_Type = IIf(IsDBNull(reader("B_Type")), Nothing, reader("B_Type").ToString)
            skminfo.BPer_ID = IIf(IsDBNull(reader("BPer_ID")), Nothing, reader("BPer_ID").ToString)
            skminfo.BPer_Name = IIf(IsDBNull(reader("BPer_Name")), Nothing, reader("BPer_Name").ToString)
            skminfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            skminfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            skminfo.M_Price = IIf(IsDBNull(reader("M_Price")), 0, reader("M_Price"))
            skminfo.M_Unit = IIf(IsDBNull(reader("M_Unit")), Nothing, reader("M_Unit").ToString)
            'skminfo.Team_ID = IIf(IsDBNull(reader("Team_ID")), Nothing, reader("Team_ID"))
            skminfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            skminfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            skminfo.WH_Type = IIf(IsDBNull(reader("WH_Type")), Nothing, reader("WH_Type").ToString)
            skminfo.Total_Price = IIf(IsDBNull(reader("M_Price")), 0, reader("M_Price")) * IIf(IsDBNull(reader("B_Qty")), 0, reader("B_Qty"))
            Return skminfo
        End Function

        Public Function GetStaffKnifeMoneyPer(ByVal whid As String) As List(Of StaffKnifeMoneyInfoKnife)
            Dim sql As String = "select distinct BPer_ID as Per_ID,BPer_Name as Per_Name from KnifeBorrow where WH_ID='" + whid + "'"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim mycommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim datareader As IDataReader = mycommand.ExecuteReader
            Dim featurelist As New List(Of StaffKnifeMoneyInfoKnife)
            While datareader.Read
                featurelist.Add(FillStaffKnifeMoneyPer(datareader))
            End While
            conn.Close()
            datareader.Close()
            Return featurelist
        End Function

        Friend Function FillStaffKnifeMoneyPer(ByVal reader As IDataReader) As StaffKnifeMoneyInfoKnife
            Dim skminfo As New StaffKnifeMoneyInfoKnife
            skminfo.Per_ID = IIf(IsDBNull(reader("Per_ID")), Nothing, reader("Per_ID").ToString)
            skminfo.Per_Name = IIf(IsDBNull(reader("Per_Name")), Nothing, reader("Per_Name").ToString)
            Return skminfo
        End Function

    End Class
End Namespace
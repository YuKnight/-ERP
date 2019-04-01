Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class KnifeUseConditionControllerKnife

        Public Function GetKnifeUseCondition(ByVal thedate As Date, ByVal whid As String, ByVal btype As String) As List(Of KnifeUseConditionInfoKnife)

            Dim sql As String = "select KnifeBorrow .B_Type ,KnifeBorrow .B_Qty ,KnifeBorrow .B_Date ,(select WareHouse .WH_Name from WareHouse where WareHouse .WH_ID = KnifeBorrow .WH_ID ) as WH_Name,KnifeBorrow .B_NO ,KnifeBorrow .B_Action ,MaterialCode.M_Name ,MaterialCode.M_Gauge ,MaterialCode.M_Unit ,MaterialCode.M_Price from KnifeBorrow inner join MaterialCode  on MaterialCode.M_Code =KnifeBorrow .M_Code"
            Dim str1 As String
            Dim str2 As String
            Dim str3 As String
            Dim date1 As Date
            Dim date2 As Date
            date1 = thedate
            date2 = thedate.AddMonths(1)
            str1 = " and B_Date>='" + date1 + "' and B_Date<'" + date2 + "'"
            If whid = "all" Then
                str2 = Nothing
            Else
                str2 = " and WH_ID='" + whid + "'"
            End If
            str3 = " and B_Type='" + btype + "'"
            sql = sql + str1 + str2 + str3
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeUseConditionInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeUseCondition(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        Friend Function FillKnifeUseCondition(ByVal reader As IDataReader) As KnifeUseConditionInfoKnife

            Dim kucinfo As New KnifeUseConditionInfoKnife
            kucinfo.B_Action = IIf(IsDBNull(reader("B_Action")), Nothing, reader("B_Action").ToString)
            kucinfo.B_Date = IIf(IsDBNull(reader("B_Date")), Nothing, reader("B_Date"))
            kucinfo.B_NO = IIf(IsDBNull(reader("B_NO")), Nothing, reader("B_NO").ToString)
            kucinfo.B_Qty = IIf(IsDBNull(reader("B_Qty")), 0, reader("B_Qty"))
            kucinfo.B_Type = IIf(IsDBNull(reader("B_Type")), Nothing, reader("B_Type").ToString)
            kucinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            kucinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            kucinfo.M_Price = (IIf(IsDBNull(reader("M_Price")), 0, reader("M_Price")))
            kucinfo.M_Unit = IIf(IsDBNull(reader("M_Unit")), Nothing, reader("M_Unit").ToString)
            kucinfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            kucinfo.TotalMoney = IIf(IsDBNull(reader("B_Qty")), 0, reader("B_Qty")) * (IIf(IsDBNull(reader("M_Price")), 0, reader("M_Price")))
            Return kucinfo

        End Function

    End Class
End Namespace
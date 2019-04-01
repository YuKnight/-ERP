Imports System.IO
Imports System.Data.SqlClient
Imports system.data.oledb
Namespace LFERP.Library.KnifeWare
    Public Class KnifeBorrowControllerKnife

        'Public Function GetKnifeBorrow(ByVal themonthStart As Date, ByVal themonthEnd As Date, ByVal whid As String, ByVal btype As String, ByVal bPer_ID As String) As List(Of KnifeBorrowInfoKnife)
        '    Dim sql As String = "select KnifeBorrow .B_Type ,(select WareHouse .WH_Name from WareHouse where WareHouse .WH_ID =KnifeBorrow .WH_ID )  as WH_Name,KnifeBorrow.B_Date, KnifeBorrow.BPer_Name, KnifeBorrow.B_Qty, KnifeBorrow.B_NO, KnifeBorrow.B_Action, KnifeBorrow.B_Remark,MaterialCode.M_Name,MaterialCode.M_Gauge,MaterialCode.M_Unit from KnifeBorrow inner join MaterialCode on MaterialCode.M_Code = KnifeBorrow.M_Code"
        '    Dim str1 As String
        '    Dim str2 As String
        '    Dim str3 As String
        '    Dim str4 As String
        '    Dim date1 As Date
        '    Dim date2 As Date
        '    date1 = themonthStart
        '    date2 = themonthEnd.AddDays(1)
        '    str1 = " and B_Date>='" + date1 + "' and B_Date<'" + date2 + "'"
        '    If whid = "all" Then
        '        str2 = Nothing
        '    Else
        '        str2 = " and WH_ID='" + whid + "'"
        '    End If
        '    str3 = " and B_Type='" + btype + "'"
        '    str4 = " and BPer_ID='" + bPer_ID + "'"
        '    ''''''''2013-11-6 姚駿新增''''''''
        '    If btype <> "所有刀具" Then
        '        sql = sql + str1 + str2 + str3 + str4
        '    Else
        '        sql = sql + str1 + str2 + str4
        '    End If

        '    ''''''''''''''''''''''''''''''''''

        '    Dim conn As SqlConnection = New SqlConnection
        '    conn.ConnectionString = ConnStr()
        '    conn.Open()
        '    Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
        '    Dim myDataReader As SqlDataReader
        '    myDataReader = myCommand.ExecuteReader
        '    Dim FeatureList As New List(Of KnifeBorrowInfoKnife)
        '    While (myDataReader.Read)
        '        FeatureList.Add(FillKnifeBorrow(myDataReader))
        '    End While
        '    conn.Close()
        '    myDataReader.Close()
        '    Return FeatureList
        'End Function

        Public Function GetKnifeBorrow(ByVal themonthStart As Date, ByVal themonthEnd As Date, ByVal whid As String, ByVal btype As String, ByVal bPer_ID As String, ByVal bM_Code As String) As List(Of KnifeBorrowInfoKnife)
            Dim sql As String = "select KnifeBorrow .B_Type ,(select WareHouse .WH_Name from WareHouse where WareHouse .WH_ID =KnifeBorrow .WH_ID )  as WH_Name,KnifeBorrow.B_Date, KnifeBorrow.BPer_Name, KnifeBorrow.B_Qty, KnifeBorrow.B_NO, KnifeBorrow.B_Action, KnifeBorrow.B_Remark,MaterialCode.M_Name,MaterialCode.M_Gauge,MaterialCode.M_Unit from KnifeBorrow inner join MaterialCode on MaterialCode.M_Code = KnifeBorrow.M_Code"
            Dim str1 As String
            Dim str2 As String
            Dim str3 As String
            Dim str4 As String
            Dim str5 As String
            Dim date1 As Date
            Dim date2 As Date
            date1 = themonthStart
            date2 = themonthEnd.AddDays(1)
            str1 = " and B_Date>='" + date1 + "' and B_Date<'" + date2 + "'"
            If whid = "all" Then
                str2 = Nothing
            Else
                str2 = " and WH_ID='" + whid + "'"
            End If
            str3 = " and B_Type='" + btype + "'"
            str4 = " and BPer_ID='" + bPer_ID + "'"
            str5 = " and KnifeBorrow.M_Code like '%" + bM_Code + "%'"

            ''''''''2013-11-6 姚駿新增''''''''
            If btype <> "所有刀具" Then
                sql = sql + str1 + str2 + str3 + str4 + str5
            Else
                sql = sql + str1 + str2 + str4 + str5
            End If

            ''''''''''''''''''''''''''''''''''

            Dim conn As SqlConnection = New SqlConnection
            conn.ConnectionString = ConnStr()
            conn.Open()
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            Dim myDataReader As SqlDataReader
            myDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeBorrowInfoKnife)
            While (myDataReader.Read)
                FeatureList.Add(FillKnifeBorrow(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList
        End Function


        Friend Function FillKnifeBorrow(ByVal reader As IDataReader) As KnifeBorrowInfoKnife

            Dim kbinfo As New KnifeBorrowInfoKnife
            kbinfo.B_NO = IIf(IsDBNull(reader("B_NO")), Nothing, reader("B_NO").ToString)
            kbinfo.BPer_Name = IIf(IsDBNull(reader("BPer_Name")), Nothing, reader("BPer_Name").ToString)
            kbinfo.B_Qty = IIf(IsDBNull(reader("B_Qty")), 0, reader("B_Qty"))
            kbinfo.B_Date = IIf(IsDBNull(reader("B_Date")), Nothing, reader("B_Date"))
            kbinfo.B_Action = IIf(IsDBNull(reader("B_Action")), Nothing, reader("B_Action").ToString)
            kbinfo.B_Remark = IIf(IsDBNull(reader("B_Remark")), Nothing, reader("B_Remark").ToString)
            kbinfo.B_Type = IIf(IsDBNull(reader("B_Type")), Nothing, reader("B_Type").ToString)
            kbinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            kbinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            kbinfo.M_Unit = IIf(IsDBNull(reader("M_Unit")), Nothing, reader("M_Unit").ToString)
            kbinfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            Return kbinfo
        End Function
    End Class
End Namespace
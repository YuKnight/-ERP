Imports system.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class KnifeReturnControllerKnife

        'Public Function GetKnifeReturn(ByVal themonthStart As Date, ByVal themonthEnd As Date, ByVal whid As String, ByVal btype As String, ByVal bPer_ID As String) As List(Of KnifeReturnInfoKnife)
        '    Dim sql As String = "select KnifeReturn .R_Type ,(select WareHouse .WH_Name from WareHouse where WareHouse .WH_ID =KnifeReturn .WH_ID ) as WH_Name,KnifeReturn .R_Date ,KnifeReturn .RPer_Name ,KnifeReturn .R_Qty ,KnifeReturn .R_NO ,KnifeReturn .RRPer_Name ,KnifeReturn .R_Action , KnifeReturn.RR_Mark,MaterialCode.M_Name,MaterialCode.M_Gauge,MaterialCode.M_Unit from KnifeReturn inner join MaterialCode on MaterialCode.M_Code = KnifeReturn.M_Code"
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
        '    Dim conn As SqlConnection = New SqlConnection(ConnStr)
        '    Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
        '    conn.Open()
        '    Dim myDataReader As IDataReader = myCommand.ExecuteReader
        '    Dim FeatureList As New List(Of KnifeReturnInfoKnife)
        '    While (myDataReader.Read)
        '        FeatureList.Add(FillKnifeReturn(myDataReader))
        '    End While
        '    conn.Close()
        '    myDataReader.Close()
        '    Return FeatureList
        'End Function

        Public Function GetKnifeReturn(ByVal themonthStart As Date, ByVal themonthEnd As Date, ByVal whid As String, ByVal btype As String, ByVal bPer_ID As String, ByVal bM_Code As String) As List(Of KnifeReturnInfoKnife)
            Dim sql As String = "select KnifeReturn .R_Type ,(select WareHouse .WH_Name from WareHouse where WareHouse .WH_ID =KnifeReturn .WH_ID ) as WH_Name,KnifeReturn .R_Date ,KnifeReturn .RPer_Name ,KnifeReturn .R_Qty ,KnifeReturn .R_NO ,KnifeReturn .RRPer_Name ,KnifeReturn .R_Action , KnifeReturn.RR_Mark,MaterialCode.M_Name,MaterialCode.M_Gauge,MaterialCode.M_Unit from KnifeReturn inner join MaterialCode on MaterialCode.M_Code = KnifeReturn.M_Code"
            Dim str1 As String
            Dim str2 As String
            Dim str3 As String
            Dim str4 As String
            Dim str5 As String
            Dim date1 As Date
            Dim date2 As Date
            date1 = themonthStart
            date2 = themonthEnd.AddDays(1)
            str1 = " and R_Date>='" + date1 + "' and R_Date<'" + date2 + "'"
            If whid = "all" Then
                str2 = Nothing
            Else
                str2 = " and WH_ID='" + whid + "'"
            End If
            str3 = " and R_Type='" + btype + "'"
            str4 = " and RPer_ID='" + bPer_ID + "'"
            str5 = " and KnifeReturn.M_Code like '%" + bM_Code + "%'"
            ''''''''2013-11-6 姚駿新增''''''''
            If btype <> "所有刀具" Then
                sql = sql + str1 + str2 + str3 + str4 + str5
            Else
                sql = sql + str1 + str2 + str4 + str5
            End If

            ''''''''''''''''''''''''''''''''''
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeReturnInfoKnife)
            While (myDataReader.Read)
                FeatureList.Add(FillKnifeReturn(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList
        End Function



        Friend Function FillKnifeReturn(ByVal reader As IDataReader) As KnifeReturnInfoKnife
            Dim krinfo As New KnifeReturnInfoKnife

            krinfo.R_NO = IIf(IsDBNull("R_NO"), Nothing, reader("R_NO").ToString)
            krinfo.R_Qty = IIf(IsDBNull("R_Qty"), Nothing, reader("R_Qty"))
            krinfo.RPer_Name = IIf(IsDBNull("RPer_Name"), Nothing, reader("RPer_Name").ToString)
            krinfo.RRPer_Name = IIf(IsDBNull("RRPer_Name"), Nothing, reader("RRPer_Name").ToString)
            krinfo.R_Type = IIf(IsDBNull("R_Type"), Nothing, reader("R_Type").ToString)
            krinfo.R_Date = IIf(IsDBNull("R_Date"), Nothing, reader("R_Date"))
            krinfo.RR_Mark = IIf(IsDBNull("RR_Mark"), Nothing, reader("RR_Mark").ToString)
            krinfo.R_Action = IIf(IsDBNull("R_Action"), Nothing, reader("R_Action").ToString)
            krinfo.M_Name = IIf(IsDBNull("M_Name"), Nothing, reader("M_Name").ToString)
            krinfo.M_Gauge = IIf(IsDBNull("M_Gauge"), Nothing, reader("M_Gauge").ToString)
            krinfo.M_Unit = IIf(IsDBNull("M_Unit"), Nothing, reader("M_Unit").ToString)
            krinfo.WH_Name = IIf(IsDBNull("WH_Name"), Nothing, reader("WH_Name").ToString)

            Return krinfo
        End Function

    End Class
End Namespace

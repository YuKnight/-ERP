Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class KnifeCheckControllerKnife

        Public Function GetKnifeCheck(ByVal whid As String, ByVal mname As String, ByVal mgauge As String) As List(Of KnifeCheckInfoKnife)
            Dim sql As String = "select KnifeBorrow .NOReturn ,MaterialCode.M_Name ,materialtype3.Type3Name as M_Type ,MaterialCode.M_Gauge,(select WI_Qty from WareInventory where KnifeBorrow.M_Code =WareInventory.M_Code and KnifeBorrow.WH_ID =WareInventory.WH_ID) as WI_Qty from KnifeBorrow inner join MaterialCode on KnifeBorrow.M_Code = MaterialCode.M_Code inner join MaterialType3 on materialtype3.Type3ID = MaterialCode .Type3ID collate Chinese_Taiwan_Stroke_CS_AS_KS_WS"
            Dim str1 As String
            Dim str2 As String
            Dim str3 As String
            If whid = "all" Then
                str1 = Nothing
            Else
                str1 = " and WH_ID = '" + whid + "' "
            End If
            If mname = "all" Then
                str2 = Nothing
            Else
                str2 = " and M_Name = '" + mname + "' "
            End If
            If mgauge = "all" Then
                str3 = Nothing
            Else
                str3 = " and M_Gauge = '" + mgauge + "'"
            End If
            sql = sql + str1 + str2 + str3
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeCheckInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeCheck(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList
        End Function

        Friend Function FillKnifeCheck(ByVal reader As IDataReader) As KnifeCheckInfoKnife
            Dim kcinfo As New KnifeCheckInfoKnife
            kcinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            kcinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            kcinfo.M_Type = IIf(IsDBNull(reader("M_Type")), Nothing, reader("M_Type").ToString)
            kcinfo.NOReturn = IIf(IsDBNull(reader("NOReturn")), 0, reader("NOReturn"))
            kcinfo.WI_Qty = IIf(IsDBNull(reader("WI_Qty")), 0, reader("WI_Qty"))
            Return kcinfo
        End Function

        Public Function GetKnifeCheckMName(ByVal whid As String) As List(Of KnifeCheckInfoKnife)
            Dim sql As String
            If whid = "all" Then
                sql = "select distinct MaterialCode.M_Name from MaterialCode where M_Code in (select KnifeBorrow .M_Code  from KnifeBorrow)"
            Else
                sql = "select distinct MaterialCode.M_Name from MaterialCode where M_Code in (select KnifeBorrow .M_Code  from KnifeBorrow where KnifeBorrow .WH_ID ='" + whid + "') "
            End If
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeCheckInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeCheckMName(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            If FeatureList.Count > 0 Then
                FeatureList.Add(FillKnifeCheckMNameall(myDataReader))
            End If
            Return FeatureList
        End Function

        Friend Function FillKnifeCheckMName(ByVal reader As IDataReader) As KnifeCheckInfoKnife
            Dim kcinfo As New KnifeCheckInfoKnife
            kcinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name"))
            Return kcinfo
        End Function

        Friend Function FillKnifeCheckMNameall(ByVal reader As IDataReader) As KnifeCheckInfoKnife
            Dim kcinfo As New KnifeCheckInfoKnife
            kcinfo.M_Name = "all"
            Return kcinfo
        End Function

        Public Function GetKnifeCheckMGauge(ByVal mname As String) As List(Of KnifeCheckInfoKnife)
            Dim sql As String
            If mname = "all" Then
                sql = "select distinct MaterialCode.M_Gauge  from MaterialCode where MaterialCode.M_Name in (select distinct MaterialCode.M_Name from MaterialCode where M_Code in (select KnifeBorrow .M_Code  from KnifeBorrow))"
            Else
                sql = "select distinct MaterialCode.M_Gauge  from MaterialCode where MaterialCode.M_Name  ='" + mname + "' "
            End If
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeCheckInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeCheckGauge(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            If FeatureList.Count > 0 Then
                FeatureList.Add(FillKnifeCheckGaugeall(myDataReader))
            End If
            Return FeatureList
        End Function

        Friend Function FillKnifeCheckGauge(ByVal reader As IDataReader) As KnifeCheckInfoKnife
            Dim kcinfo As New KnifeCheckInfoKnife
            kcinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge"))
            Return kcinfo
        End Function

        Friend Function FillKnifeCheckGaugeall(ByVal reader As IDataReader) As KnifeCheckInfoKnife
            Dim kcinfo As New KnifeCheckInfoKnife
            kcinfo.M_Gauge = "all"
            Return kcinfo
        End Function

    End Class
End Namespace
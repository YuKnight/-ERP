Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class UseKnifeQtyControllerKnife

        Public Function GetUseKnifeQty(ByVal whid As String, ByVal mname As String) As List(Of UseKnifeQtyInfoKnife)
            Dim sql As String = "select KnifeBorrow.B_Qty ,knifeborrow.WH_ID ,MaterialCode.M_Name,(select WareHouse.WH_Name  from WareHouse where WareHouse.WH_ID =KnifeBorrow .WH_ID ) as WH_Name,(select WareHouse.WH_Action from WareHouse where WareHouse.WH_ID =KnifeBorrow .WH_ID )as WH_Action,(select WareHouse.WH_Type from WareHouse where WareHouse.WH_ID =KnifeBorrow .WH_ID ) as WH_Type,(select MaterialCode.M_Gauge from MaterialCode where MaterialCode.M_Code =KnifeBorrow .M_Code) as M_Gauge from KnifeBorrow inner join MaterialCode on MaterialCode.M_Code =KnifeBorrow .M_Code"
            Dim str1 As String
            Dim str2 As String
            If whid = "all" Then
                str1 = Nothing
            Else
                str1 = " and WH_ID ='" + whid + "'"
            End If
            If mname = "all" Then
                str2 = Nothing
            Else
                str2 = " and M_Name ='" + mname + "'"
            End If
            sql = sql + str1 + str2
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of UseKnifeQtyInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillUseKnifeQty(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList
        End Function

        Friend Function FillUseKnifeQty(ByVal reader As IDataReader) As UseKnifeQtyInfoKnife
            Dim ukqinfo As New UseKnifeQtyInfoKnife
            ukqinfo.B_Qty = IIf(IsDBNull(reader("B_Qty")), 0, reader("B_Qty"))
            ukqinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            ukqinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            ukqinfo.WH_Action = IIf(IsDBNull(reader("WH_Action")), Nothing, reader("WH_Action").ToString)
            ukqinfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            ukqinfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            ukqinfo.WH_Type = IIf(IsDBNull(reader("WH_Type")), Nothing, reader("WH_Type").ToString)
            Return ukqinfo
        End Function

        Public Function GetUseKnifeQtyMname(ByVal whid As String) As List(Of UseKnifeQtyInfoKnife)
            Dim str As String
            If whid = "all" Then
                str = Nothing
            Else
                str = " where KnifeBorrow .WH_ID ='" + whid + "'"
            End If
            Dim sql As String = "select distinct MaterialCode.M_Name from MaterialCode where MaterialCode.M_Code in (select KnifeBorrow .M_Code from KnifeBorrow" + str + ")"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of UseKnifeQtyInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillUseKnifeQtyMname(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            If FeatureList.Count > 0 Then
                FeatureList.Add(FillUseKnifeQtyMname1())
            End If
            Return FeatureList
        End Function

        Friend Function FillUseKnifeQtyMname(ByVal reader As IDataReader) As UseKnifeQtyInfoKnife
            Dim ukqinfo As New UseKnifeQtyInfoKnife
            ukqinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            Return ukqinfo
        End Function

        Friend Function FillUseKnifeQtyMname1() As UseKnifeQtyInfoKnife
            Dim ukqinfo As New UseKnifeQtyInfoKnife
            ukqinfo.M_Name = "all"
            Return ukqinfo
        End Function

    End Class
End Namespace
Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class UseKnifeScatterControllerKnife

        Public Function GetUseKnifeScatter(ByVal whid As String, ByVal mname As String) As List(Of UseKnifeScatterInfoKnife)

            Dim sql As String = "select KnifeBorrow.B_Qty ,KnifeBorrow .BPer_ID ,KnifeBorrow .BPer_Name ,knifeborrow.WH_ID ,(select WareHouse.WH_Name  from WareHouse where WareHouse.WH_ID =KnifeBorrow .WH_ID ) as WH_Name,(select WareHouse.WH_Action from WareHouse where WareHouse.WH_ID =KnifeBorrow .WH_ID )as WH_Action,(select WareHouse.WH_Type from WareHouse where WareHouse.WH_ID =KnifeBorrow .WH_ID ) as WH_Type,MaterialCode.M_Name,(select MaterialCode.M_Gauge from MaterialCode where MaterialCode.M_Code =KnifeBorrow .M_Code) as M_Gauge  from KnifeBorrow inner join MaterialCode on  MaterialCode.M_Code =KnifeBorrow .M_Code and WH_ID ='" + whid + "' and M_Name ='" + mname + "' order by BPer_ID asc"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of UseKnifeScatterInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillUseKnifeScatter(myDataReader))
            End While
            Return FeatureList

        End Function

        Public Function GetUseKnifeScatterMname(ByVal whid As String) As List(Of UseKnifeScatterInfoKnife)

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
            Dim FeatureList As New List(Of UseKnifeScatterInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillUseKnifeScatterMname(myDataReader))
            End While
            Return FeatureList

        End Function

        Friend Function FillUseKnifeScatter(ByVal reader As IDataReader) As UseKnifeScatterInfoKnife

            Dim uksinfo As New UseKnifeScatterInfoKnife
            uksinfo.B_Qty = IIf(IsDBNull(reader("B_Qty")), 0, reader("B_Qty"))
            uksinfo.BPer_ID = IIf(IsDBNull(reader("BPer_ID")), Nothing, reader("BPer_ID").ToString)
            uksinfo.BPer_Name = IIf(IsDBNull(reader("BPer_Name")), Nothing, reader("BPer_Name").ToString)
            uksinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            uksinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            uksinfo.WH_Action = IIf(IsDBNull(reader("WH_Action")), Nothing, reader("WH_Action").ToString)
            uksinfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            uksinfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            uksinfo.WH_Type = IIf(IsDBNull(reader("WH_Type")), Nothing, reader("WH_Type").ToString)
            Return uksinfo

        End Function

        Friend Function FillUseKnifeScatterMname(ByVal reader As IDataReader) As UseKnifeScatterInfoKnife

            Dim uksinfo As New UseKnifeScatterInfoKnife
            uksinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            Return uksinfo

        End Function

    End Class
End Namespace
Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class SomeoneNoReturnControllerKnife

        Public Function GetSomeoneNoReturn(ByVal bperid As String) As List(Of SomeoneNoReturnInfoKnife)

            Dim sql As String = "select KnifeBorrow.B_NO,KnifeBorrow.BPer_Name ,KnifeBorrow.BPer_ID,KnifeBorrow.WH_ID ,KnifeBorrow.NOReturn ,(select MaterialCode.M_Gauge  from MaterialCode where MaterialCode.M_Code=KnifeBorrow.M_Code) as M_Gauge,(select MaterialCode.M_Name  from MaterialCode where MaterialCode.M_Code=KnifeBorrow.M_Code) as M_Name,(select WareHouse .WH_Name from WareHouse where WareHouse .WH_ID = KnifeBorrow .WH_ID ) as WH_Name from KnifeBorrow where BPer_ID ='" + bperid + "'"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of SomeoneNoReturnInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillSomeoneNoReturn(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        Friend Function FillSomeoneNoReturn(ByVal reader As IDataReader) As SomeoneNoReturnInfoKnife

            Dim snrinfo As New SomeoneNoReturnInfoKnife
            snrinfo.BPer_ID = IIf(IsDBNull(reader("BPer_ID")), Nothing, reader("BPer_ID").ToString)
            snrinfo.BPer_Name = IIf(IsDBNull(reader("BPer_Name")), Nothing, reader("BPer_Name").ToString)
            snrinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            snrinfo.NOReturn = IIf(IsDBNull(reader("NOReturn")), 0, reader("NOReturn"))
            snrinfo.WH_ID = IIf(IsDBNull(reader("WH_ID")), Nothing, reader("WH_ID").ToString)
            snrinfo.WH_Name = IIf(IsDBNull(reader("WH_Name")), Nothing, reader("WH_Name").ToString)
            snrinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            snrinfo.B_NO = IIf(IsDBNull(reader("B_NO")), Nothing, reader("B_NO").ToString)
            Return snrinfo

        End Function

        Public Function GetSomeoneNoReturnPer() As List(Of SomeoneNoReturnInfoKnife)

            Dim sql As String = "select distinct KnifeBorrow .BPer_ID as Per_ID,KnifeBorrow .BPer_Name as Per_Name from KnifeBorrow"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of SomeoneNoReturnInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillSomeoneNoReturnPer(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        Friend Function FillSomeoneNoReturnPer(ByVal reader As IDataReader) As SomeoneNoReturnInfoKnife

            Dim snrinfo As New SomeoneNoReturnInfoKnife
            snrinfo.Per_ID = IIf(IsDBNull(reader("Per_ID")), Nothing, reader("Per_ID").ToString)
            snrinfo.Per_Name = IIf(IsDBNull(reader("Per_Name")), Nothing, reader("Per_Name").ToString)
            Return snrinfo

        End Function

    End Class
End Namespace
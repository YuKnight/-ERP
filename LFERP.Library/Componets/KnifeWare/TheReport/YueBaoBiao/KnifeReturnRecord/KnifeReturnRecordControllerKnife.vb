Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class KnifeReturnRecordControllerKnife

        Public Function GetKnifeReturnRecord(ByVal thmonth As Date) As List(Of KnifeReturnRecordInfoKnife)

            Dim sql As String = "select KnifeReturn.R_NO ,KnifeReturn.R_Qty ,KnifeReturn.R_Type ,KnifeReturn.R_Action ,KnifeReturn.R_Date ,KnifeReturn.RR_Mark ,KnifeReturn.R_Check ,MaterialCode.M_Name, MaterialCode.M_Gauge from KnifeReturn  inner join MaterialCode on KnifeReturn .M_Code =MaterialCode.M_Code "
            Dim str1 As String
            Dim str2 As String
            Dim date1 As Date
            Dim date2 As Date
            date1 = thmonth
            date2 = thmonth.AddMonths(1)
            str1 = " and R_Date>='" + date1 + "' and R_Date<'" + date2 + "'"
            str2 = " order by R_NO asc"
            sql = sql + str1 + str2
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeReturnRecordInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeReturnRecord(myDataReader))
            End While
            Return FeatureList

        End Function

        Friend Function FillKnifeReturnRecord(ByVal reader As IDataReader) As KnifeReturnRecordInfoKnife

            Dim krrinfo As New KnifeReturnRecordInfoKnife
            krrinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            krrinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            krrinfo.R_Action = IIf(IsDBNull(reader("R_Action")), Nothing, reader("R_Action").ToString)
            krrinfo.R_Check = IIf(IsDBNull(reader("R_Check")), False, reader("R_Check"))
            krrinfo.R_Date = IIf(IsDBNull(reader("R_Date")), Nothing, reader("R_Date"))
            krrinfo.R_NO = IIf(IsDBNull(reader("R_NO")), Nothing, reader("R_NO").ToString)
            krrinfo.R_Qty = IIf(IsDBNull(reader("R_Qty")), 0, reader("R_Qty"))
            krrinfo.R_Type = IIf(IsDBNull(reader("R_Type")), Nothing, reader("R_Type").ToString)
            krrinfo.RR_Mark = IIf(IsDBNull(reader("RR_Mark")), Nothing, reader("RR_Mark").ToString)
            Return krrinfo

        End Function

    End Class
End Namespace
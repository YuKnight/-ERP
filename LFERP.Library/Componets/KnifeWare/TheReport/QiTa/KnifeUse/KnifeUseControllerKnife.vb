Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class KnifeUseControllerKnife

        Public Function GetKnifeUse(ByVal mname As String) As List(Of KnifeUseInfoKnife)
            Dim sql As String = "select distinct KnifeReturn .M_Code ,KnifeReturn.R_Type ,KnifeReturn.WH_ID ,(select MaterialCode.M_Name from MaterialCode where MaterialCode .M_Code = KnifeWareInventorySub .M_Code ) as M_Name,(select MaterialCode .M_Gauge from MaterialCode where MaterialCode .M_Code = KnifeWareInventorySub .M_Code ) as  M_Gauge,(select SUM(KnifeWareInventorySub .WI_SQty ) from KnifeWareInventorySub where KnifeReturn .M_Code =KnifeWareInventorySub.M_Code and SUBSTRING(KnifeWareInventorySub.WH_ID ,1,3)='W50' ) as WI_SQtySub,(select SUM(KnifeWareInventorySub.WI_SReQty  ) from KnifeWareInventorySub  where KnifeReturn .M_Code =KnifeWareInventorySub.M_Code and SUBSTRING(KnifeWareInventorySub.WH_ID ,1,3)='W50') as WI_SReQtySub,(select SUM(KnifeWareInventorySub .WI_SQty ) from KnifeWareInventorySub  where KnifeReturn .M_Code =KnifeWareInventorySub.M_Code and SUBSTRING(KnifeWareInventorySub.WH_ID ,1,3)='W40') as WI_SQtyMain,(select SUM(KnifeWareInventorySub .WI_SReQty ) from KnifeWareInventorySub  where KnifeReturn .M_Code =KnifeWareInventorySub.M_Code and SUBSTRING(KnifeWareInventorySub.WH_ID ,1,3)='W40') as WI_SReQtyMain from KnifeWareInventorySub inner join KnifeReturn on KnifeReturn .M_Code =KnifeWareInventorySub.M_Code and (select MaterialCode.M_Name from MaterialCode where MaterialCode .M_Code = KnifeWareInventorySub .M_Code)='" + mname + "'"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeUseInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeUse(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList
        End Function

        Public Function GetKnifeUseSub(ByVal datestart As Date, ByVal dateend As Date) As List(Of KnifeUseInfoKnife)
            Dim sql As String = "select KnifeReturn .R_Date ,KnifeReturn .M_Code,KnifeReturn .R_Qty,(select MaterialCode .M_Gauge from MaterialCode where MaterialCode .M_Code = KnifeReturn  .M_Code ) as  M_Gauge from KnifeReturn where KnifeReturn .R_Type like '%«İ³B²z%' "
            Dim str1 As String
            Dim str2 As String
            If datestart = Nothing Then
                str1 = Nothing
            Else
                str1 = " and R_Date >='" + datestart + "'"
            End If
            If dateend = Nothing Then
                str2 = Nothing
            Else
                str2 = " and R_Date<='" + dateend + "'"
            End If
            sql = sql + str1 + str2
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeUseInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeUseSub(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList
        End Function

        Public Function GetKnifeUseMname() As List(Of KnifeUseInfoKnife)
            Dim sql As String = "select distinct MaterialCode.M_Name from MaterialCode where MaterialCode .M_Code in (select KnifeWareInventorySub.M_Code from  KnifeWareInventorySub)"
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of KnifeUseInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillKnifeUseMname(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList
        End Function

        Friend Function FillKnifeUse(ByVal reader As IDataReader) As KnifeUseInfoKnife

            Dim kuinfo As New KnifeUseInfoKnife
            kuinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            kuinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            kuinfo.WI_SQtyMain = IIf(IsDBNull(reader("WI_SQtyMain")), 0, reader("WI_SQtyMain"))
            kuinfo.WI_SQtySub = IIf(IsDBNull(reader("WI_SQtySub")), 0, reader("WI_SQtySub"))
            kuinfo.WI_SReQtyMain = IIf(IsDBNull(reader("WI_SReQtyMain")), 0, reader("WI_SReQtyMain"))
            kuinfo.WI_SReQtySub = IIf(IsDBNull(reader("WI_SReQtySub")), 0, reader("WI_SReQtySub"))
            kuinfo.M_Code = IIf(IsDBNull(reader("M_Code")), Nothing, reader("M_Code").ToString)
            Return kuinfo

        End Function

        Friend Function FillKnifeUseSub(ByVal reader As IDataReader) As KnifeUseInfoKnife

            Dim kuinfo As New KnifeUseInfoKnife
            kuinfo.R_Date = IIf(IsDBNull(reader("R_Date")), Nothing, reader("R_Date"))
            kuinfo.R_Qty = IIf(IsDBNull(reader("R_Qty")), 0, reader("R_Qty"))
            kuinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            kuinfo.M_Code = IIf(IsDBNull(reader("M_Code")), Nothing, reader("M_Code").ToString)
            Return kuinfo

        End Function

        Friend Function FillKnifeUseMname(ByVal reader As IDataReader) As KnifeUseInfoKnife

            Dim kuinfo As New KnifeUseInfoKnife
            kuinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            Return kuinfo

        End Function

    End Class
End Namespace
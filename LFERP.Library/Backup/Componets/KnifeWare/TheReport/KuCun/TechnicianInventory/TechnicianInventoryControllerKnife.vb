Imports System.Data.OleDb
Imports System.Data.SqlClient
Namespace LFERP.Library.KnifeWare
    Public Class TechnicianInventoryControllerKnife


        Public Function GetTechnicianInventory(ByVal whid As String, ByVal bperid As String, ByVal btype As String, ByVal bM_Code As String) As List(Of TechnicianInventoryInfoKnife)
            'Dim sql As String = "SELECT KnifeBorrow.B_Type ,KnifeBorrow.BPer_Name ,KnifeBorrow.BPer_ID,KnifeBorrow.NOReturn ,KnifeBorrow.B_NO ,KnifeBorrow.B_Remark ,  MaterialCode.M_Name ,materialtype3.Type3Name as M_Type,MaterialCode.M_Gauge FROM MaterialCode  inner join materialtype3 on MaterialCode.Type3ID=materialtype3.Type3ID  COLLATE Chinese_Taiwan_Stroke_CI_AS  inner join KnifeBorrow  on   MaterialCode.M_Code =KnifeBorrow.M_Code and WH_ID ='" + whid + "' and BPer_ID ='" + bperid + "' and B_Type ='" + btype + "' "
            ''''''''''''''''''''2013-11-7姚駿新增'''''''''''''''''
            Dim sql As String
            If btype <> "所有刀具" Then
                sql = "SELECT KnifeBorrow.B_Type ,KnifeBorrow.BPer_Name ,KnifeBorrow.BPer_ID,KnifeBorrow.NOReturn ,KnifeBorrow.B_NO ,KnifeBorrow.B_Remark ,  MaterialCode.M_Name ,materialtype3.Type3Name as M_Type,MaterialCode.M_Gauge FROM MaterialCode  inner join materialtype3 on MaterialCode.Type3ID=materialtype3.Type3ID  COLLATE Chinese_Taiwan_Stroke_CI_AS  inner join KnifeBorrow  on   MaterialCode.M_Code =KnifeBorrow.M_Code and WH_ID ='" + whid + "' and BPer_ID ='" + bperid + "' and B_Type ='" + btype + "'" + " and KnifeBorrow.M_Code like '%" + bM_Code + "%'"
            Else
                sql = "SELECT KnifeBorrow.B_Type ,KnifeBorrow.BPer_Name ,KnifeBorrow.BPer_ID,KnifeBorrow.NOReturn ,KnifeBorrow.B_NO ,KnifeBorrow.B_Remark ,  MaterialCode.M_Name ,materialtype3.Type3Name as M_Type,MaterialCode.M_Gauge FROM MaterialCode  inner join materialtype3 on MaterialCode.Type3ID=materialtype3.Type3ID  COLLATE Chinese_Taiwan_Stroke_CI_AS  inner join KnifeBorrow  on   MaterialCode.M_Code =KnifeBorrow.M_Code and WH_ID ='" + whid + "' and BPer_ID ='" + bperid + "'" + " and KnifeBorrow.M_Code like '%" + bM_Code + "%'"
            End If
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of TechnicianInventoryInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillTechnicianInventory(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        'Public Function GetTechnicianInventory(ByVal whid As String, ByVal bperid As String, ByVal btype As String) As List(Of TechnicianInventoryInfoKnife)
        '    'Dim sql As String = "SELECT KnifeBorrow.B_Type ,KnifeBorrow.BPer_Name ,KnifeBorrow.BPer_ID,KnifeBorrow.NOReturn ,KnifeBorrow.B_NO ,KnifeBorrow.B_Remark ,  MaterialCode.M_Name ,materialtype3.Type3Name as M_Type,MaterialCode.M_Gauge FROM MaterialCode  inner join materialtype3 on MaterialCode.Type3ID=materialtype3.Type3ID  COLLATE Chinese_Taiwan_Stroke_CI_AS  inner join KnifeBorrow  on   MaterialCode.M_Code =KnifeBorrow.M_Code and WH_ID ='" + whid + "' and BPer_ID ='" + bperid + "' and B_Type ='" + btype + "' "
        '    ''''''''''''''''''''2013-11-7姚駿新增'''''''''''''''''
        '    Dim sql As String
        '    If btype <> "所有刀具" Then
        '        sql = "SELECT KnifeBorrow.B_Type ,KnifeBorrow.BPer_Name ,KnifeBorrow.BPer_ID,KnifeBorrow.NOReturn ,KnifeBorrow.B_NO ,KnifeBorrow.B_Remark ,  MaterialCode.M_Name ,materialtype3.Type3Name as M_Type,MaterialCode.M_Gauge FROM MaterialCode  inner join materialtype3 on MaterialCode.Type3ID=materialtype3.Type3ID  COLLATE Chinese_Taiwan_Stroke_CI_AS  inner join KnifeBorrow  on   MaterialCode.M_Code =KnifeBorrow.M_Code and WH_ID ='" + whid + "' and BPer_ID ='" + bperid + "' and B_Type ='" + btype + "' "
        '    Else
        '        sql = "SELECT KnifeBorrow.B_Type ,KnifeBorrow.BPer_Name ,KnifeBorrow.BPer_ID,KnifeBorrow.NOReturn ,KnifeBorrow.B_NO ,KnifeBorrow.B_Remark ,  MaterialCode.M_Name ,materialtype3.Type3Name as M_Type,MaterialCode.M_Gauge FROM MaterialCode  inner join materialtype3 on MaterialCode.Type3ID=materialtype3.Type3ID  COLLATE Chinese_Taiwan_Stroke_CI_AS  inner join KnifeBorrow  on   MaterialCode.M_Code =KnifeBorrow.M_Code and WH_ID ='" + whid + "' and BPer_ID ='" + bperid + "'"
        '    End If
        '    ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '    Dim conn As SqlConnection = New SqlConnection(ConnStr)
        '    Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
        '    conn.Open()
        '    Dim myDataReader As IDataReader = myCommand.ExecuteReader
        '    Dim FeatureList As New List(Of TechnicianInventoryInfoKnife)
        '    While myDataReader.Read
        '        FeatureList.Add(FillTechnicianInventory(myDataReader))
        '    End While
        '    conn.Close()
        '    myDataReader.Close()
        '    Return FeatureList

        'End Function

        Friend Function FillTechnicianInventory(ByVal reader As IDataReader) As TechnicianInventoryInfoKnife

            Dim tiinfo As New TechnicianInventoryInfoKnife

            tiinfo.B_NO = IIf(IsDBNull(reader("B_NO")), Nothing, reader("B_NO").ToString)
            tiinfo.B_Remark = IIf(IsDBNull(reader("B_Remark")), Nothing, reader("B_Remark").ToString)
            tiinfo.B_Type = IIf(IsDBNull(reader("B_Type")), Nothing, reader("B_Type").ToString)
            tiinfo.BPer_ID = IIf(IsDBNull(reader("BPer_ID")), Nothing, reader("BPer_ID").ToString)
            tiinfo.BPer_Name = IIf(IsDBNull(reader("BPer_Name")), Nothing, reader("BPer_Name").ToString)
            tiinfo.M_Gauge = IIf(IsDBNull(reader("M_Gauge")), Nothing, reader("M_Gauge").ToString)
            tiinfo.M_Name = IIf(IsDBNull(reader("M_Name")), Nothing, reader("M_Name").ToString)
            tiinfo.M_Type = IIf(IsDBNull(reader("M_Type")), Nothing, reader("M_Type").ToString)
            tiinfo.NOReturn = IIf(IsDBNull(reader("NOReturn")), 0, reader("NOReturn"))

            Return tiinfo

        End Function

        Public Function GetTechnicianInventoryPER(ByVal whid As String) As List(Of TechnicianInventoryInfoKnife)
            Dim sql As String
            If whid = "all" Then
                sql = "select distinct KnifeBorrow.BPer_Name as Per_Name ,KnifeBorrow.BPer_ID as Per_ID from KnifeBorrow"
            Else
                sql = "select distinct KnifeBorrow.BPer_Name as Per_Name,KnifeBorrow.BPer_ID as Per_ID from KnifeBorrow where WH_ID = '" + whid + "'"
            End If
            Dim conn As SqlConnection = New SqlConnection(ConnStr)
            Dim myCommand As SqlCommand = New SqlCommand(sql, conn)
            conn.Open()
            Dim myDataReader As IDataReader = myCommand.ExecuteReader
            Dim FeatureList As New List(Of TechnicianInventoryInfoKnife)
            While myDataReader.Read
                FeatureList.Add(FillTechnicianInventorPERy(myDataReader))
            End While
            conn.Close()
            myDataReader.Close()
            Return FeatureList

        End Function

        Friend Function FillTechnicianInventorPERy(ByVal reader As IDataReader) As TechnicianInventoryInfoKnife

            Dim tiinfo As New TechnicianInventoryInfoKnife

            tiinfo.Per_ID = IIf(IsDBNull(reader("Per_ID")), Nothing, reader("Per_ID"))
            tiinfo.Per_Name = IIf(IsDBNull(reader("Per_Name")), Nothing, reader("Per_Name"))

            Return tiinfo

        End Function

    End Class
End Namespace

Imports System.Data.Common
Namespace LFERP.Library.KnifeWare
    Public Class KnifeManagerControl
        Public Function KnifeManagerInventorySub_GetList(ByVal M_Code As String, ByVal KnifeID As String, ByVal Type3ID As String) As List(Of KnifeManagerInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeManagerInventorySub_GetList")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@KnifeID", DbType.String, KnifeID)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of KnifeManagerInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillKnifeWareInventorySub(ByVal reader As IDataReader) As KnifeManagerInfo
            Dim ai As New KnifeManagerInfo

            On Error Resume Next

            ai.Qty = reader("WI_SQty") + reader("WI_SReQty")
            ai.WI_SQty = reader("WI_SQty")
            ai.WI_SReQty = reader("WI_SReQty")

            ai.M_Code = reader("M_code").ToString
            ai.M_Name = reader("M_Name").ToString
            ai.M_Gauge = reader("M_Gauge").ToString

            ai.NOReturn = reader("NOReturn")
            ai.FacName = reader("FacName").ToString
            ai.DepName = reader("DepName").ToString

            Return ai
        End Function

        '

        Public Function KnifeManagerNoReurnUser_GetList() As List(Of KnifeManagerInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeManagerNoReurnUser_GetList")

            Dim FeatureList As New List(Of KnifeManagerInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareInventorySub(reader))
                End While
                Return FeatureList
            End Using
        End Function
    End Class
End Namespace

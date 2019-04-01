Imports LFERP.Library.PieceProcess.PersonnelInfo
Imports LFERP.Library.PieceProcess.WorkGroupInfo


Namespace PieceSum
    Public Class PieceSumController
        Public Function PiecePersonnelGroup_GetList(ByVal Per_NO As String, ByVal Wg_NO As String, ByVal DepID As String, ByVal FacID As String, ByVal Per_DisMiss As String) As List(Of PieceSumInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("PiecePersonnelGroup_GetList")

            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO)
            db.AddInParameter(dbComm, "@Wg_NO", DbType.String, Wg_NO)
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@Per_DisMiss", DbType.String, Per_DisMiss)

            Dim FeatureList As New List(Of PieceSumInfo)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPiecePersonnelGroup(reader))
                End While
                Return FeatureList
            End Using

        End Function
        Public Function FillPiecePersonnelGroup(ByVal reader As IDataReader) As PieceSumInfo
            On Error Resume Next
            Dim psi As New PieceSumInfo
            '組別資料
            psi.Per_NO = reader("Per_NO").ToString
            psi.Per_PayType = reader("Per_PayType").ToString
            If IsDBNull(psi.Per_Dismiss) Or psi.Per_Dismiss = 0 Then
                psi.Per_Dismiss = reader("Per_Dismiss") = False
            Else
                psi.Per_Dismiss = reader("Per_Dismiss") = True
            End If
            Return psi
        End Function
    End Class

End Namespace


Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms
Namespace MProcess
    Public Class MProcessController
        Public Function MProcess_Add(ByVal Objinfo As MProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcess_Add")

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)

                db.ExecuteNonQuery(dbComm)
                MProcess_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MProcess_Add = False
            End Try

        End Function
        Public Function MProcess_Update(ByVal Objinfo As MProcessInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcess_Update")

                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Objinfo.Pro_NO)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, Objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, Objinfo.M_Code)

                db.ExecuteNonQuery(dbComm)
                MProcess_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                MProcess_Update = False
            End Try

        End Function
        Public Function MProcess_GetList(ByVal Pro_NO As String, ByVal PM_M_Code As String, ByVal M_Code As String) As List(Of MProcessInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("MProcess_GetList")

            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

            Dim FeatureList As New List(Of MProcessInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillMProcess(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function FillMProcess(ByVal reader As IDataReader) As MProcessInfo

            On Error Resume Next
            Dim mpi As New MProcessInfo

            mpi.PM_M_Code = reader("PM_M_Code").ToString
            mpi.Pro_NO = reader("Pro_NO").ToString
            mpi.M_Code = reader("M_Code").ToString

            Return mpi
        End Function
       
    End Class
End Namespace


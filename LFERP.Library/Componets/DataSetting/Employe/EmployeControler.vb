Namespace LFERP.DataSetting



    Public Class EmployeControler
        Public Function Employe_Get(ByVal Employe_ID As String) As EmployeInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStrPersonnal)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("OutCard_Seek")
            db.AddInParameter(dbComm, "@emp_no", DbType.String, Employe_ID)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillEmploye(reader)
                End While
                Return Nothing
            End Using

        End Function


        Friend Function FillEmploye(ByVal reader As IDataReader) As EmployeInfo
            '對應取得的數據
            Dim objInfo As New EmployeInfo
            objInfo.Employe_ID = reader("emp_no").ToString
            objInfo.Employe_Name = reader("emp_name").ToString

            Return objInfo
        End Function


    End Class



End Namespace

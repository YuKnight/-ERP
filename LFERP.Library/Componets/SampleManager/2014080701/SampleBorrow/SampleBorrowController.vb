Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.SampleManager.SampleBorrow

    Public Class SampleBorrowController
        Friend Function FillSampleBorrow(ByVal reader As IDataReader) As SampleBorrowInfo
            On Error Resume Next
            Dim objInfo As New SampleBorrowInfo
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.BorrowID = reader("BorrowID").ToString
            objInfo.D_ID = reader("D_ID").ToString
            objInfo.BorrowDate = IIf(IsDBNull(reader("BorrowDate")), Nothing, Format(CDate(reader("BorrowDate")), "yyyy/MM/dd HH:mm:ss"))
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.PS_NO = reader("PS_NO").ToString
            objInfo.SO_ID = reader("SO_ID").ToString
            If IsDBNull(reader("Borrow_Qty")) = False Then
                objInfo.Borrow_Qty = reader("Borrow_Qty")
            End If
            If IsDBNull(reader("NoBorrow_Qty")) = False Then
                objInfo.NoBorrow_Qty = reader("NoBorrow_Qty")
            End If

            objInfo.OutCardID = reader("OutCardID").ToString
            If reader("CheckBit") Is DBNull.Value Then
                objInfo.CheckBit = Nothing
            Else
                objInfo.CheckBit = reader("CheckBit")
            End If

            If reader("CheckDate") Is DBNull.Value Then
                objInfo.CheckDate = Nothing
            Else
                objInfo.CheckDate = Format(CDate(reader("CheckDate")), "yyyy/MM/dd")
            End If

            objInfo.CheckUserID = reader("CheckUserID").ToString
            objInfo.CreateUserID = reader("CreateUserID").ToString
            If reader("CreateDate") Is DBNull.Value Then
                objInfo.CreateDate = Nothing
            Else
                objInfo.CreateDate = Format(CDate(reader("CreateDate")), "yyyy/MM/dd")
            End If

            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            If reader("ModifyDate") Is DBNull.Value Then
                objInfo.ModifyDate = Nothing
            Else
                objInfo.ModifyDate = Format(CDate(reader("ModifyDate")), "yyyy/MM/dd")
            End If

            objInfo.CheckUserName = reader("CheckUserName").ToString
            objInfo.CreateUserName = reader("CreateUserName").ToString
            objInfo.D_Dep = reader("D_Dep").ToString
            objInfo.Remark = reader("Remark").ToString
            objInfo.MaterialTypeID = reader("MaterialTypeID").ToString
            objInfo.MaterialTypeName = reader("MaterialTypeName").ToString
            objInfo.SO_SampleID = reader("SO_SampleID").ToString
            objInfo.RepayQty = reader("RepayQty")
            objInfo.PS_Name = reader("PS_Name").ToString

            objInfo.Qty = reader("Qty")
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.BorrowBit = reader("BorrowBit")
            objInfo.InputID = reader("InputID").ToString
            objInfo.InputType = reader("InputType").ToString

            Return objInfo
        End Function

        Public Function SampleBorrowSE_GetList(ByVal D_ID As String, ByVal PS_NO As String, ByVal SE_ID As String) As List(Of SampleBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrowSE_GetList")
            db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)

            Dim FeatureList As New List(Of SampleBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleBorrowD_ID_GetList(ByVal D_ID As String) As List(Of SampleBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrowD_ID_GetList")

            If D_ID <> Nothing Then
                db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)
            End If
            Dim FeatureList As New List(Of SampleBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleBorrowM_Code_GetList(ByVal OutD_ID As String, ByVal InD_ID As String) As List(Of SampleBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrowM_Code_GetList")

            If OutD_ID <> Nothing Then
                db.AddInParameter(dbComm, "@OutD_ID", DbType.String, OutD_ID)
            End If

            If InD_ID <> Nothing Then
                db.AddInParameter(dbComm, "@InD_ID", DbType.String, InD_ID)
            End If

            Dim FeatureList As New List(Of SampleBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleBorrowPM_M_Code_GetList(ByVal PM_M_Code As String) As List(Of SampleBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrowPM_M_Code_GetList")

            If PM_M_Code <> Nothing Then
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            End If

            Dim FeatureList As New List(Of SampleBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleBorrow_GetList(ByVal BorrowID As String, ByVal D_ID As String, ByVal PS_NO As String, ByVal PM_M_Code As String, ByVal OutCardID As String, ByVal Where As String, ByVal ReportEmpty As Boolean) As List(Of SampleBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrow_GetList")
            db.AddInParameter(dbComm, "@BorrowID", DbType.String, BorrowID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OutCardID", DbType.String, OutCardID)
            db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Where", DbType.String, Where)

            Dim FeatureList As New List(Of SampleBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleBorrow(reader))
                End While
                If FeatureList.Count <= 0 And ReportEmpty Then
                    FeatureList.Add(New SampleBorrowInfo())
                End If
                Return FeatureList
            End Using
        End Function

        Public Function SampleBorrowTatal_GetList(ByVal PM_M_Code As String, ByVal D_ID As String, ByVal OutCardID As String) As List(Of SampleBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrowTatal_GetList")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OutCardID", DbType.String, OutCardID)
            db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)

            Dim FeatureList As New List(Of SampleBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SampleBorrowView_GetList(ByVal BorrowID As String, ByVal D_ID As String, ByVal PS_NO As String, ByVal PM_M_Code As String, ByVal OutCardID As String, ByVal Code_ID As String, ByVal BorrowBit As String, ByVal Where As String, ByVal ReportEmpty As Boolean) As List(Of SampleBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrowView_GetList")
            db.AddInParameter(dbComm, "@BorrowID", DbType.String, BorrowID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OutCardID", DbType.String, OutCardID)
            db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@BorrowBit", DbType.Boolean, BorrowBit)
            db.AddInParameter(dbComm, "@Where", DbType.String, Where)

            Dim FeatureList As New List(Of SampleBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleBorrow(reader))
                End While
                If FeatureList.Count <= 0 And ReportEmpty Then
                    FeatureList.Add(New SampleBorrowInfo())
                End If
                Return FeatureList
            End Using
        End Function

        Public Function SampleBorrowA_GetList(ByVal D_ID As String, ByVal PS_NO As String, ByVal PM_M_Code As String, ByVal OutCardID As String, ByVal Where As String, ByVal ReportEmpty As Boolean) As List(Of SampleBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrowA_GetList")

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@OutCardID", DbType.String, OutCardID)
            db.AddInParameter(dbComm, "@D_ID", DbType.String, D_ID)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Where", DbType.String, Where)


            Dim FeatureList As New List(Of SampleBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleBorrow(reader))
                End While
                If FeatureList.Count <= 0 And ReportEmpty Then
                    FeatureList.Add(New SampleBorrowInfo())
                End If
                Return FeatureList
            End Using
        End Function

        Public Function SampleBorrow_Delete(ByVal AutoID As Decimal, ByVal BorrowID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrow_Delete")
                If AutoID <> Nothing Then
                    db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
                End If
                If BorrowID <> Nothing Then
                    db.AddInParameter(dbComm, "@BorrowID", DbType.String, BorrowID)
                End If
                db.ExecuteNonQuery(dbComm)
                SampleBorrow_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleBorrow_Delete = False
            End Try
        End Function


        Public Function SampleBorrow_Update(ByVal objinfo As SampleBorrowInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrow_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@SO_ID", DbType.String, objinfo.SO_ID)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objinfo.D_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objinfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@BorrowBit", DbType.Boolean, objinfo.BorrowBit)
                db.AddInParameter(dbComm, "@BorrowDate", DbType.Date, objinfo.BorrowDate)
                db.AddInParameter(dbComm, "@OutCardID", DbType.String, objinfo.OutCardID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.Date, objinfo.ModifyDate)

                db.ExecuteNonQuery(dbComm)
                SampleBorrow_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleBorrow_Update = False
            End Try
        End Function

        Public Function SampleBorrow_UpdateCheck(ByVal objinfo As SampleBorrowInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrow_Update")
                If objinfo.AutoID <> Nothing Then
                    db.AddInParameter(dbComm, "@AutoID ", DbType.Decimal, objinfo.AutoID)
                End If
                If objinfo.BorrowID <> Nothing Then
                    db.AddInParameter(dbComm, "@BorrowID", DbType.String, objinfo.BorrowID)
                End If
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                If objinfo.ModifyDate <> Nothing Then
                    db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                End If
                db.ExecuteNonQuery(dbComm)
                SampleBorrow_UpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleBorrow_UpdateCheck = False
            End Try
        End Function

        Public Function SampleBorrow_GetNewID() As String
            Try
                Dim ndate = "RB" + Format(Now(), "yyMM")
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrow_GetID")
                Using reader As IDataReader = db.ExecuteReader(dbComm)
                    If reader.Read Then
                        Return ndate + Mid((CInt(Mid(reader("BorrowID").ToString, 7)) + 100001), 2)
                    Else
                        Return ndate + "00001"
                    End If
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try
        End Function

        Public Function GetMaterialInfo() As DataTable
            Dim ds As New DataSet
            Dim sqlStr As String = "select M_Code,M_Name,M_Gauge,M_Unit  from MaterialCode  "
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetSqlStringCommand(sqlStr)
            ds = db.ExecuteDataSet(dbcomm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function
        Public Function GetDeptInfo() As DataTable
            Dim ds As New DataSet
            Dim sqlStr As String = "select DPT_ID as DeptID,DPT_Name as DeptName from Department  "
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbcomm As DbCommand = db.GetSqlStringCommand(sqlStr)
            ds = db.ExecuteDataSet(dbcomm)
            If ds.Tables.Count > 0 Then
                Return ds.Tables(0)
            Else
                Return Nothing
            End If
        End Function


        Public Function SampleBorrow_Add(ByVal objInfo As SampleBorrowInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrow_Add")

                db.AddInParameter(dbComm, "@BorrowID", DbType.String, objInfo.BorrowID)
                db.AddInParameter(dbComm, "@SO_ID", DbType.String, objInfo.SO_ID)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objInfo.D_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objInfo.PS_NO)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objInfo.Qty)
                db.AddInParameter(dbComm, "@BorrowDate", DbType.Date, objInfo.BorrowDate)
                db.AddInParameter(dbComm, "@OutCardID", DbType.String, objInfo.OutCardID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objInfo.Code_ID)
                db.AddInParameter(dbComm, "@InputType", DbType.String, objInfo.InputType)
                db.AddInParameter(dbComm, "@InputID", DbType.String, objInfo.InputID)
                db.AddInParameter(dbComm, "@CreateUserID", DbType.String, objInfo.CreateUserID)
                db.AddInParameter(dbComm, "@CreateDate", DbType.Date, objInfo.CreateDate)

                db.ExecuteNonQuery(dbComm)
                SampleBorrow_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleBorrow_Add = False
            End Try
        End Function

        Public Function SampleBorrow_UpdateCardID(ByVal AutoID As String, ByVal NowCardID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleBorrow_UpdateCardID")
                db.AddInParameter(dbComm, "@NowCardID", DbType.String, NowCardID)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)

                db.ExecuteNonQuery(dbComm)
                SampleBorrow_UpdateCardID = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SampleBorrow_UpdateCardID = False
            End Try
        End Function

        Public Function SampleThrough_GetList(ByVal AutoID As Decimal, ByVal BorrowID As String, ByVal OutD_ID As String, ByVal InD_ID As String, ByVal PM_M_Code As String, ByVal OutCardID As String, ByVal CheckBit As String, ByVal OutDate As Date, ByVal Indate As Date) As List(Of SampleBorrowInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SampleThrough_GetList")

            If AutoID <> Nothing Then
                db.AddInParameter(dbComm, "@AutoID", DbType.Decimal, AutoID)
            End If
            If BorrowID <> Nothing Then
                db.AddInParameter(dbComm, "@BorrowID", DbType.String, BorrowID)
            End If
            If OutD_ID <> Nothing Then
                db.AddInParameter(dbComm, "@OutD_ID", DbType.String, OutD_ID)
            End If
            If InD_ID <> Nothing Then
                db.AddInParameter(dbComm, "@InD_ID", DbType.String, InD_ID)
            End If
            If PM_M_Code <> Nothing Then
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            End If
            If OutCardID <> Nothing Then
                db.AddInParameter(dbComm, "@OutCardID", DbType.String, OutCardID)
            End If
            If CheckBit <> Nothing Then
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, CheckBit)
            End If
            If OutDate <> Nothing Then
                db.AddInParameter(dbComm, "@OutDate", DbType.Date, OutDate)
            End If

            Dim FeatureList As New List(Of SampleBorrowInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSampleBorrow(reader))
                End While
                Return FeatureList
            End Using
        End Function
    End Class
End Namespace
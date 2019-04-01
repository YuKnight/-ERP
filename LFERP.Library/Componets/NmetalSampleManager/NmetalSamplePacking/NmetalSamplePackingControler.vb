Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.NmetalSampleManager.NmetalSamplePacking
    Public Class NmetalSamplePackingController
        Friend Function FillNmetalSamplePacking(ByVal reader As IDataReader) As NmetalSamplePackingInfo

            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New NmetalSamplePackingInfo
            objInfo.PK_ID = reader("PK_ID").ToString
            objInfo.Shelves_ID = reader("Shelves_ID").ToString
            objInfo.Qty = reader("Qty").ToString
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.Remark = reader("Remark").ToString
            objInfo.PackingType = reader("PackingType").ToString
            objInfo.PackingUserID = reader("PackingUserID").ToString
            objInfo.PackingDate = reader("PackingDate").ToString
            objInfo.AddUserID = reader("AddUserID").ToString
            objInfo.AddDate = reader("AddDate").ToString
            objInfo.ModifyUserID = reader("ModifyUserID").ToString
            objInfo.ModifyDate = reader("ModifyDate").ToString
            objInfo.CheckUserID = reader("CheckUserID").ToString
            objInfo.CheckBit = reader("CheckBit").ToString
            objInfo.CheckDate = reader("CheckDate").ToString
            objInfo.CheckRemark = reader("CheckRemark").ToString
            objInfo.CheckUserName = reader("CheckUserName").ToString
            objInfo.AddUserName = reader("AddUserName").ToString
            objInfo.AutoID = reader("AutoID").ToString
            objInfo.PB_ID = reader("PB_ID").ToString
            objInfo.D_ID = reader("D_ID").ToString
            objInfo.D_Dep = reader("D_Dep").ToString
            objInfo.SO_SampleID = reader("SO_SampleID").ToString
            objInfo.SE_ID = reader("SE_ID").ToString
            objInfo.SE_IDNO = reader("SE_IDNO").ToString
            objInfo.BitNeed = reader("BitNeed")
            objInfo.SealCode_ID = reader("SealCode_ID").ToString
            objInfo.UseCount = reader("UseCount")
            objInfo.UsePKCount = reader("UsePKCount")
            Return objInfo
        End Function

        Public Function NmetalSamplePacking_Add(ByVal objInfo As NmetalSamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePacking_Add")
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objInfo.PK_ID)
                db.AddInParameter(dbComm, "@Shelves_ID", DbType.String, objInfo.Shelves_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objInfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objInfo.Code_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objInfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)
                db.AddInParameter(dbComm, "@PackingType", DbType.String, objInfo.PackingType)
                db.AddInParameter(dbComm, "@PackingUserID", DbType.String, objInfo.PackingUserID)
                db.AddInParameter(dbComm, "@PackingDate", DbType.DateTime, objInfo.PackingDate)
                db.AddInParameter(dbComm, "@AddUserID", DbType.String, objInfo.AddUserID)
                db.AddInParameter(dbComm, "@AddDate", DbType.DateTime, objInfo.AddDate)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objInfo.D_ID)
                db.AddInParameter(dbComm, "@SE_ID", DbType.String, objInfo.SE_ID)
                db.AddInParameter(dbComm, "@SealCode_ID", DbType.String, objInfo.SealCode_ID)
                db.AddInParameter(dbComm, "@UseCount", DbType.String, objInfo.UseCount)
                db.AddInParameter(dbComm, "@UsePKCount", DbType.String, objInfo.UsePKCount)

                db.ExecuteNonQuery(dbComm)

                NmetalSamplePacking_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePacking_Add = False
            End Try
        End Function

        Public Function NmetalSamplePacking_Update(ByVal objinfo As NmetalSamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePacking_Update")
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objinfo.PK_ID)
                db.AddInParameter(dbComm, "@Shelves_ID", DbType.String, objinfo.Shelves_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objinfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbComm, "@PackingType", DbType.String, objinfo.PackingType)
                db.AddInParameter(dbComm, "@PackingUserID", DbType.String, objinfo.PackingUserID)
                db.AddInParameter(dbComm, "@PackingDate", DbType.DateTime, objinfo.PackingDate)
                db.AddInParameter(dbComm, "@ModifyUserID", DbType.String, objinfo.ModifyUserID)
                db.AddInParameter(dbComm, "@ModifyDate", DbType.DateTime, objinfo.ModifyDate)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@D_ID", DbType.String, objinfo.D_ID)
                db.AddInParameter(dbComm, "@SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "@SealCode_ID", DbType.String, objinfo.SealCode_ID)

                db.AddInParameter(dbComm, "@UseCount", DbType.String, objinfo.UseCount)
                db.AddInParameter(dbComm, "@UsePKCount", DbType.String, objinfo.UsePKCount)
                db.ExecuteNonQuery(dbComm)
                NmetalSamplePacking_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePacking_Update = False
            End Try
        End Function

        Public Function NmetalSamplePacking_Delete(ByVal AutoID As String, ByVal PK_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePacking_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)

                db.ExecuteNonQuery(dbComm)
                NmetalSamplePacking_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePacking_Delete = False
            End Try
        End Function

        Public Function NmetalSamplePackingSub_Delete(ByVal AutoID As String, ByVal PK_ID As String, ByVal PB_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePackingSub_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

                db.ExecuteNonQuery(dbComm)
                NmetalSamplePackingSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePackingSub_Delete = False
            End Try
        End Function

        Public Function NmetalSamplePackingSubB_Delete(ByVal AutoID As String, ByVal PK_ID As String, ByVal PB_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePackingSubB_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

                db.ExecuteNonQuery(dbComm)
                NmetalSamplePackingSubB_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePackingSubB_Delete = False
            End Try
        End Function


        Public Function NmetalSamplePacking_GetList(ByVal AutoID As String, ByVal PK_ID As String, ByVal Shelves_ID As String, ByVal Code_ID As String, ByVal PM_M_Code As String, ByVal PackingDateStrat As String, ByVal PackingDateEnd As String, ByVal SE_ID As String) As List(Of NmetalSamplePackingInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePacking_GetList")
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
            db.AddInParameter(dbComm, "@Shelves_ID", DbType.String, Shelves_ID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

            db.AddInParameter(dbComm, "@PackingDateStrat", DbType.Date, PackingDateStrat)
            db.AddInParameter(dbComm, "@PackingDateEnd", DbType.Date, PackingDateEnd)
            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)

            Dim FeatureList As New List(Of NmetalSamplePackingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePacking(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSamplePackingSub_Add(ByVal objInfo As NmetalSamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePackingSub_Add")
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objInfo.PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objInfo.PB_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objInfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objInfo.Code_ID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)

                db.ExecuteNonQuery(dbComm)
                NmetalSamplePackingSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePackingSub_Add = False
            End Try
        End Function

        Public Function NmetalSamplePackingSub_Update(ByVal objinfo As NmetalSamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePackingSub_Update")
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objinfo.PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objinfo.PB_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objinfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                NmetalSamplePackingSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePackingSub_Update = False
            End Try
        End Function

        Public Function NmetalSamplePackingSubB_Add(ByVal objInfo As NmetalSamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePackingSubB_Add")
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objInfo.PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objInfo.PB_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objInfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objInfo.Code_ID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)

                db.ExecuteNonQuery(dbComm)
                NmetalSamplePackingSubB_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePackingSubB_Add = False
            End Try
        End Function

        Public Function NmetalSamplePackingSubB_Update(ByVal objinfo As NmetalSamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePackingSubB_Update")
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objinfo.PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objinfo.PB_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objinfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                NmetalSamplePackingSubB_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePackingSubB_Update = False
            End Try
        End Function

        Public Function NmetalSamplePackingSub_GetList(ByVal AutoID As String, ByVal PK_ID As String, ByVal Code_ID As String, ByVal PB_ID As String) As List(Of NmetalSamplePackingInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePackingSub_GetList")
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

            Dim FeatureList As New List(Of NmetalSamplePackingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePacking(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSamplePackingSubB_GetList(ByVal AutoID As String, ByVal PK_ID As String, ByVal Code_ID As String, ByVal PB_ID As String) As List(Of NmetalSamplePackingInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePackingSubB_GetList")
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

            Dim FeatureList As New List(Of NmetalSamplePackingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSamplePacking(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSamplePacking_Get(ByVal SP_ID As String) As NmetalSamplePackingInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePacking_Get")
            db.AddInParameter(dbComm, "@PK_ID", DbType.String, SP_ID)
            Dim FeatureList As New NmetalSamplePackingInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.PK_ID = reader("PK_ID").ToString
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSamplePackingSub_Get(ByVal PB_ID As String) As NmetalSamplePackingInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalNmetalSamplePackingSub_Get")
            db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)
            Dim FeatureList As New NmetalSamplePackingInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.PB_ID = reader("PB_ID").ToString
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSamplePacking_UpdateCheck(ByVal objinfo As NmetalSamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePacking_UpdateCheck")

                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objinfo.PK_ID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckDate", DbType.Date, objinfo.CheckDate)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.ExecuteNonQuery(dbComm)
                NmetalSamplePacking_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePacking_UpdateCheck = False
            End Try
        End Function

        Public Function NmetalSamplePacking_InUpdateCheck(ByVal objinfo As NmetalSamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSamplePacking_InUpdateCheck")

                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@BitNeed", DbType.Boolean, objinfo.BitNeed)
                db.AddInParameter(dbComm, "@UsePKCount", DbType.Boolean, objinfo.UsePKCount)
                db.ExecuteNonQuery(dbComm)
                NmetalSamplePacking_InUpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSamplePacking_InUpdateCheck = False
            End Try
        End Function

    End Class
End Namespace



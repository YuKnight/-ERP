Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.SampleManager.SamplePacking
    Public Class SamplePackingController
        Friend Function FillSamplePacking(ByVal reader As IDataReader) As SamplePackingInfo

            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New SamplePackingInfo
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

        Public Function SamplePacking_Add(ByVal objInfo As SamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePacking_Add")
                dbComm.CommandTimeout = 0
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

                SamplePacking_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePacking_Add = False
            End Try
        End Function

        Public Function SamplePacking_Update(ByVal objinfo As SamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePacking_Update")
                dbComm.CommandTimeout = 0
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
                SamplePacking_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePacking_Update = False
            End Try
        End Function

        Public Function SamplePacking_Delete(ByVal AutoID As String, ByVal PK_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePacking_Delete")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)

                db.ExecuteNonQuery(dbComm)
                SamplePacking_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePacking_Delete = False
            End Try
        End Function

        Public Function SamplePackingSub_Delete(ByVal AutoID As String, ByVal PK_ID As String, ByVal PB_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePackingSub_Delete")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

                db.ExecuteNonQuery(dbComm)
                SamplePackingSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePackingSub_Delete = False
            End Try
        End Function

        Public Function SamplePackingSubB_Delete(ByVal AutoID As String, ByVal PK_ID As String, ByVal PB_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePackingSubB_Delete")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@AutoID", DbType.Double, AutoID)
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

                db.ExecuteNonQuery(dbComm)
                SamplePackingSubB_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePackingSubB_Delete = False
            End Try
        End Function


        Public Function SamplePacking_GetList(ByVal AutoID As String, ByVal PK_ID As String, ByVal Shelves_ID As String, ByVal Code_ID As String, ByVal PM_M_Code As String, ByVal PackingDateStrat As String, ByVal PackingDateEnd As String, ByVal SE_ID As String) As List(Of SamplePackingInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePacking_GetList")
            dbComm.CommandTimeout = 0
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
            db.AddInParameter(dbComm, "@Shelves_ID", DbType.String, Shelves_ID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)

            db.AddInParameter(dbComm, "@PackingDateStrat", DbType.Date, PackingDateStrat)
            db.AddInParameter(dbComm, "@PackingDateEnd", DbType.Date, PackingDateEnd)
            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)

            Dim FeatureList As New List(Of SamplePackingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePacking(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePackingSub_Add(ByVal objInfo As SamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePackingSub_Add")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objInfo.PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objInfo.PB_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objInfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objInfo.Code_ID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)

                db.ExecuteNonQuery(dbComm)
                SamplePackingSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePackingSub_Add = False
            End Try
        End Function

        Public Function SamplePackingSub_Update(ByVal objinfo As SamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePackingSub_Update")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objinfo.PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objinfo.PB_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objinfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                SamplePackingSub_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePackingSub_Update = False
            End Try
        End Function

        Public Function SamplePackingSubB_Add(ByVal objInfo As SamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePackingSubB_Add")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objInfo.PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objInfo.PB_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objInfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objInfo.Code_ID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objInfo.Remark)

                db.ExecuteNonQuery(dbComm)
                SamplePackingSubB_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePackingSubB_Add = False
            End Try
        End Function

        Public Function SamplePackingSubB_Update(ByVal objinfo As SamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePackingSubB_Update")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objinfo.PK_ID)
                db.AddInParameter(dbComm, "@PB_ID", DbType.String, objinfo.PB_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int64, objinfo.Qty)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@Remark", DbType.String, objinfo.Remark)
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.ExecuteNonQuery(dbComm)
                SamplePackingSubB_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePackingSubB_Update = False
            End Try
        End Function

        Public Function SamplePackingSub_GetList(ByVal AutoID As String, ByVal PK_ID As String, ByVal Code_ID As String, ByVal PB_ID As String) As List(Of SamplePackingInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePackingSub_GetList")
            dbComm.CommandTimeout = 0
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

            Dim FeatureList As New List(Of SamplePackingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePacking(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePackingSubB_GetList(ByVal AutoID As String, ByVal PK_ID As String, ByVal Code_ID As String, ByVal PB_ID As String) As List(Of SamplePackingInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePackingSubB_GetList")
            dbComm.CommandTimeout = 0
            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@PK_ID", DbType.String, PK_ID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)

            Dim FeatureList As New List(Of SamplePackingInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePacking(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePacking_Get(ByVal SP_ID As String) As SamplePackingInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePacking_Get")
            dbComm.CommandTimeout = 0
            db.AddInParameter(dbComm, "@PK_ID", DbType.String, SP_ID)
            Dim FeatureList As New SamplePackingInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.PK_ID = reader("PK_ID").ToString
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePackingSub_Get(ByVal PB_ID As String) As SamplePackingInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePackingSub_Get")
            dbComm.CommandTimeout = 0
            db.AddInParameter(dbComm, "@PB_ID", DbType.String, PB_ID)
            Dim FeatureList As New SamplePackingInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.PB_ID = reader("PB_ID").ToString
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePacking_UpdateCheck(ByVal objinfo As SamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePacking_UpdateCheck")
                dbComm.CommandTimeout = 0
                db.AddInParameter(dbComm, "@PK_ID", DbType.String, objinfo.PK_ID)
                db.AddInParameter(dbComm, "@CheckBit", DbType.Boolean, objinfo.CheckBit)
                db.AddInParameter(dbComm, "@CheckDate", DbType.Date, objinfo.CheckDate)
                db.AddInParameter(dbComm, "@CheckUserID", DbType.String, objinfo.CheckUserID)
                db.AddInParameter(dbComm, "@CheckRemark", DbType.String, objinfo.CheckRemark)
                db.ExecuteNonQuery(dbComm)
                SamplePacking_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePacking_UpdateCheck = False
            End Try
        End Function

        Public Function SamplePacking_InUpdateCheck(ByVal objinfo As SamplePackingInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePacking_InUpdateCheck")
                dbComm.CommandTimeout = 0

                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@BitNeed", DbType.Boolean, objinfo.BitNeed)
                db.AddInParameter(dbComm, "@UsePKCount", DbType.Boolean, objinfo.UsePKCount)
                db.ExecuteNonQuery(dbComm)
                SamplePacking_InUpdateCheck = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePacking_InUpdateCheck = False
            End Try
        End Function

    End Class
End Namespace



Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.NmetalSampleManager.NmetalSampleProcessMain
    Public Class NmetalSampleProcessMainControler
        Public Function NmetalSampleProcess_Add(ByVal saminfo As NmetalSampleProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessMain_Add")
                db.AddInParameter(dbComm, "PM_M_Code", DbType.String, saminfo.PM_M_Code)
                db.AddInParameter(dbComm, "Pro_NO", DbType.String, saminfo.Pro_NO)
                db.AddInParameter(dbComm, "M_Code", DbType.String, saminfo.M_Code)
                db.AddInParameter(dbComm, "Pro_Type", DbType.String, saminfo.Pro_Type)
                db.AddInParameter(dbComm, "Type3ID", DbType.String, saminfo.Type3ID)
                db.AddInParameter(dbComm, "PM_Type", DbType.String, saminfo.PM_Type)
                db.AddInParameter(dbComm, "Pro_Weight", DbType.String, saminfo.Pro_Weight)
                db.AddInParameter(dbComm, "Pro_Remark", DbType.String, saminfo.Pro_Remark)
                db.AddInParameter(dbComm, "Pro_Action", DbType.String, saminfo.Pro_Action)
                db.AddInParameter(dbComm, "Pro_AddDate", DbType.String, saminfo.Pro_AddDate)
                db.AddInParameter(dbComm, "Pro_Check", DbType.String, saminfo.Pro_Check)
                db.AddInParameter(dbComm, "Pro_Describe", DbType.String, saminfo.Pro_Describe)
                db.AddInParameter(dbComm, "M_CodeMouldNO", DbType.String, saminfo.M_CodeMouldNO)
                db.AddInParameter(dbComm, "Pro_Rate", DbType.String, saminfo.Pro_Rate)
                db.ExecuteNonQuery(dbComm)
                NmetalSampleProcess_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleProcess_Add = False
            End Try
        End Function

        Public Function NmetalSampleProcessSub_Add(ByVal saminfo As NmetalSampleProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessSub_Add")
                db.AddInParameter(dbComm, "Pro_NO", DbType.String, saminfo.Pro_NO)
                db.AddInParameter(dbComm, "PS_NO", DbType.String, saminfo.PS_NO)
                db.AddInParameter(dbComm, "PS_Num", DbType.String, saminfo.PS_Num)
                db.AddInParameter(dbComm, "D_Name", DbType.String, saminfo.D_Name)
                db.AddInParameter(dbComm, "PS_Name", DbType.String, saminfo.PS_Name)
                db.AddInParameter(dbComm, "PS_Type", DbType.String, saminfo.PS_Type)
                db.AddInParameter(dbComm, "PS_Remark", DbType.String, saminfo.PS_Remark)
                db.AddInParameter(dbComm, "PS_Check", DbType.String, saminfo.PS_Check)
                db.AddInParameter(dbComm, "PS_Enable", DbType.String, saminfo.PS_Enable)
                db.AddInParameter(dbComm, "PS_OutPut", DbType.String, saminfo.PS_OutPut)
                db.AddInParameter(dbComm, "PS_Weight", DbType.String, CInt(saminfo.PS_Weight))
                db.ExecuteNonQuery(dbComm)
                NmetalSampleProcessSub_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleProcessSub_Add = False
            End Try
        End Function

        Public Function NmetalSampleProcess_Update(ByVal saminfo As NmetalSampleProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessMain_Update")
                db.AddInParameter(dbComm, "Pro_NO", DbType.String, saminfo.Pro_NO)
                db.AddInParameter(dbComm, "Pro_Weight", DbType.String, saminfo.Pro_Weight)
                db.AddInParameter(dbComm, "Pro_Rate", DbType.String, saminfo.Pro_Rate)
                db.AddInParameter(dbComm, "Pro_Remark", DbType.String, saminfo.Pro_Remark)
                db.AddInParameter(dbComm, "Pro_Describe", DbType.String, saminfo.Pro_Describe)
                db.ExecuteNonQuery(dbComm)
                NmetalSampleProcess_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleProcess_Update = False
            End Try
        End Function

        Public Function NmetalSampleProcess_Delete(ByVal saminfo As NmetalSampleProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessMain_Delete")
                db.AddInParameter(dbComm, "Pro_NO", DbType.String, saminfo.Pro_NO)
                db.ExecuteNonQuery(dbComm)
                NmetalSampleProcess_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleProcess_Delete = False
            End Try
        End Function

        Public Function NmetalSampleProcessSub_GetReport(ByVal Pro_NO As String, ByVal PS_NO As String, ByVal D_Name As String, ByVal PS_Name As String, ByVal PS_Type As String, ByVal PS_Enable As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessSub_GetReport")
            db.AddInParameter(dbComm, "Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "D_Name", DbType.String, D_Name)
            db.AddInParameter(dbComm, "PS_Name", DbType.String, PS_Name)
            db.AddInParameter(dbComm, "PS_Type", DbType.String, PS_Type)
            db.AddInParameter(dbComm, "PS_Enable", DbType.String, PS_Enable)
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSampleProcessSub_Delete(ByVal Pro_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessSub_Delete")
                db.AddInParameter(dbComm, "Pro_NO", DbType.String, Pro_NO)
                db.ExecuteNonQuery(dbComm)
                NmetalSampleProcessSub_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleProcessSub_Delete = False
            End Try
        End Function

        Public Function NmetalSampleProcess_GetgItem(ByVal PM_M_Code As String, ByVal M_Code As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcess_GetgItem")
            db.AddInParameter(dbComm, "PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "M_Code", DbType.String, M_Code)
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function NmetalSampleProcessSub_GetItem(ByVal Pro_NO As String, ByVal PS_NO As String, ByVal D_Name As String, ByVal PS_Name As String, ByVal PS_Type As String, ByVal PS_Enable As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessSub_GetItem")
            db.AddInParameter(dbComm, "Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "D_Name", DbType.String, D_Name)
            db.AddInParameter(dbComm, "PS_Name", DbType.String, PS_Name)
            db.AddInParameter(dbComm, "PS_Type", DbType.String, PS_Type)
            db.AddInParameter(dbComm, "PS_Enable", DbType.String, PS_Enable)
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function NmetalSampleProcess_GetPro_NO(ByVal Pro_NO As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessMain_GetPro_NO")
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function NmetalSampleProcessSub_GetPro_NO(ByVal Pro_NO As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalsampleProcessSub_Pro_No")
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSampleProcessSub_GetPS_Num(ByVal Pro_NO As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessSub_PS_Num")
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSampleProcess_GetList(ByVal Pro_NO As String, ByVal Pro_Type As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal Pro_Action As String, ByVal Pro_AddDate As String, ByVal Pro_Check As String, ByVal Pro_CheckAction As String, ByVal Pro_CheckDate As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessMain_GetListding")
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@Pro_Action", DbType.String, Pro_Action)
            db.AddInParameter(dbComm, "@Pro_AddDate", DbType.String, Pro_AddDate)
            db.AddInParameter(dbComm, "@Pro_Check", DbType.Boolean, Pro_Check)
            db.AddInParameter(dbComm, "@Pro_CheckAction", DbType.String, Pro_CheckAction)
            db.AddInParameter(dbComm, "@Pro_CheckDate", DbType.String, Pro_CheckDate)
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSampleProcessSub_GetList(ByVal Pro_NO As String, ByVal PS_Num As String, ByVal PS_NO As String, ByVal D_Name As String, ByVal PS_Name As String, ByVal PS_Type As String, ByVal PS_Weight As String, ByVal PS_Remark As String, ByVal PS_OutPut As String, ByVal PS_Enable As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessSub_GetListding")
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@PS_Num", DbType.String, PS_Num)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@D_Name", DbType.String, D_Name)
            db.AddInParameter(dbComm, "@PS_Name", DbType.String, PS_Name)
            db.AddInParameter(dbComm, "@PS_Type", DbType.String, PS_Type)
            db.AddInParameter(dbComm, "@PS_Weight", DbType.String, PS_Weight)
            db.AddInParameter(dbComm, "@PS_Remark", DbType.String, PS_Remark)
            db.AddInParameter(dbComm, "@PS_OutPut", DbType.String, PS_OutPut)
            db.AddInParameter(dbComm, "@PS_Enable", DbType.Boolean, PS_Enable)
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSampleProcessSubItem_Delete(ByVal saminfo As NmetalSampleProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessSubItem_Delete")
                db.AddInParameter(dbComm, "PS_Num", DbType.String, saminfo.PS_Num)
                db.AddInParameter(dbComm, "Pro_NO", DbType.String, saminfo.Pro_NO)
                db.ExecuteNonQuery(dbComm)
                NmetalSampleProcessSubItem_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleProcessSubItem_Delete = False
            End Try
        End Function

        Public Function NmetalSampleProcess_GetP_M_Code(ByVal PM_M_Code As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcess_GetP_M_Code")
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSampleProcess_GetListUpdate(ByVal sam As NmetalSampleProcessMainInfo, ByVal Pro_NO As String) As List(Of NmetalSampleProcessMainInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessMain_GetListUpdate")
            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, sam.PM_M_Code)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, sam.M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, sam.PM_Type)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, sam.Type3ID)
            db.AddInParameter(dbComm, "@Pro_Weight", DbType.String, sam.Pro_Weight)
            db.AddInParameter(dbComm, "@Pro_Rate", DbType.String, sam.Pro_Rate)
            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, sam.Pro_Type)
            db.AddInParameter(dbComm, "@M_CodeMouldNO", DbType.String, sam.M_CodeMouldNO)
            db.AddInParameter(dbComm, "@Pro_Remark", DbType.String, sam.Pro_Remark)
            db.AddInParameter(dbComm, "@Pro_Describe", DbType.String, sam.Pro_Describe)
            db.AddInParameter(dbComm, "@Pro_Check", DbType.String, sam.Pro_Type)
            db.AddInParameter(dbComm, "@Pro_CheckDate", DbType.String, sam.M_CodeMouldNO)
            db.AddInParameter(dbComm, "@Pro_CheckRemark", DbType.String, sam.Pro_Remark)
            db.AddInParameter(dbComm, "@Pro_CheckAction", DbType.String, sam.Pro_CheckAction)
            db.ExecuteNonQuery(dbComm)
            Dim FeatureList As New List(Of NmetalSampleProcessMainInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillNmetalSampleType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function NmetalSampleProcessSub_UpdateSub(ByVal sam As NmetalSampleProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessSub_UpdateSub")
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, sam.Pro_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, sam.PS_Num)
                db.AddInParameter(dbComm, "@PS_Name", DbType.String, sam.PS_Name)
                db.AddInParameter(dbComm, "@D_Name", DbType.String, sam.D_Name)
                db.AddInParameter(dbComm, "@PS_Type", DbType.String, sam.PS_Type)
                db.AddInParameter(dbComm, "@PS_Weight", DbType.String, sam.PS_Weight)
                db.AddInParameter(dbComm, "@PS_Remark", DbType.String, sam.PS_Remark)
                db.AddInParameter(dbComm, "@PS_OutPut", DbType.String, sam.PS_OutPut)
                db.AddInParameter(dbComm, "@PS_Enable", DbType.String, sam.PS_Enable)
                db.ExecuteNonQuery(dbComm)
                NmetalSampleProcessSub_UpdateSub = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleProcessSub_UpdateSub = False
            End Try
        End Function

        Public Function NmetalSampleProcessSub_UpdatePS_Num(ByVal Pro_NO As String, ByVal PS_Num As String, ByVal PaiXu As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessSub_UpdatePS_Num")
                db.AddInParameter(dbComm, "@Pro_NO", DbType.String, Pro_NO)
                db.AddInParameter(dbComm, "@PS_Num", DbType.String, CInt(PS_Num))
                db.AddInParameter(dbComm, "@PS_PaiXu", DbType.String, CInt(PaiXu))
                db.ExecuteNonQuery(dbComm)
                NmetalSampleProcessSub_UpdatePS_Num = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleProcessSub_UpdatePS_Num = False
            End Try
        End Function

        Public Function NmetalSampleProcess_Check(ByVal samifon As NmetalSampleProcessMainInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("NmetalSampleProcessMain_Check")
                db.AddInParameter(dbComm, "Pro_Weight", DbType.String, samifon.Pro_Weight)
                db.AddInParameter(dbComm, "Pro_Rate", DbType.String, samifon.Pro_Rate)
                db.AddInParameter(dbComm, "Pro_Check", DbType.Boolean, samifon.Pro_Check)
                db.AddInParameter(dbComm, "Pro_CheckDate", DbType.String, samifon.Pro_CheckDate)
                db.AddInParameter(dbComm, "Pro_CheckAction", DbType.String, samifon.Pro_CheckAction)
                db.AddInParameter(dbComm, "Pro_CheckRemark", DbType.String, samifon.Pro_CheckRemark)
                db.AddInParameter(dbComm, "Pro_NO", DbType.String, samifon.Pro_NO)
                db.ExecuteNonQuery(dbComm)
                NmetalSampleProcess_Check = True
            Catch ex As Exception
                MsgBox(ex.Message)
                NmetalSampleProcess_Check = False
            End Try
        End Function

        Friend Function FillNmetalSampleType(ByVal reader As IDataReader) As NmetalSampleProcessMainInfo
            On Error Resume Next
            Dim samInfo As New NmetalSampleProcessMainInfo
            samInfo.Auto_ID = reader("Auto_ID").ToString
            samInfo.Pro_NO = reader("Pro_NO").ToString
            samInfo.Pro_Type = reader("Pro_Type").ToString
            samInfo.PM_M_Code = reader("PM_M_Code").ToString
            samInfo.PM_Type = reader("PM_Type").ToString
            samInfo.Pro_Action = reader("Pro_Action").ToString
            samInfo.Pro_AddDate = CDate(reader("Pro_AddDate").ToString)
            'samInfo.Pro_Check = CBool(reader("Pro_Check").ToString)
            samInfo.Pro_CheckAction = reader("Pro_CheckAction").ToString
            samInfo.Pro_CheckDate = CDate(reader("Pro_CheckDate").ToString)
            samInfo.Type3ID = reader("Type3ID").ToString
            samInfo.M_Code = reader("M_Code").ToString
            samInfo.Pro_Weight = reader("Pro_Weight").ToString
            samInfo.Pro_Rate = reader("Pro_Rate").ToString
            samInfo.M_CodeMouldNO = reader("M_CodeMouldNO").ToString
            samInfo.Pro_Remark = reader("Pro_Remark").ToString
            samInfo.Pro_Describe = reader("Pro_Describe").ToString
            samInfo.Pro_CheckDate = CDate(reader("Pro_CheckDate").ToString)
            samInfo.Pro_CheckRemark = reader("Pro_CheckRemark").ToString
            samInfo.Pro_CheckAction = reader("Pro_CheckAction").ToString
            samInfo.PS_Num = reader("PS_Num").ToString
            samInfo.PS_NO = reader("PS_NO").ToString
            samInfo.D_Name = reader("D_Name").ToString
            samInfo.PS_Name = reader("PS_Name").ToString
            samInfo.PS_Type = reader("PS_Type").ToString
            samInfo.PS_Weight = reader("PS_Weight").ToString
            samInfo.PS_Remark = reader("PS_Remark").ToString
            samInfo.PS_OutPut = reader("PS_OutPut").ToString
            samInfo.D_Dep = reader("D_Dep").ToString
            samInfo.PS_Enable = CBool(reader("PS_Enable").ToString)
            samInfo.PS_File = reader("PS_File").ToString
            samInfo.SO_SampleID = reader("SO_SampleID").ToString
            samInfo.PS_BarCodeBit = reader("PS_BarCodeBit")
            samInfo.UseCount = reader("UseCount")
            samInfo.SWI_Qty = reader("SWI_Qty")
            samInfo.PS_ShowReportBit = reader("PS_ShowReportBit")
            samInfo.PS_OtherWeight = reader("PS_OtherWeight")               '±i°¶    2014-07-07
            Return samInfo
        End Function

    End Class

End Namespace





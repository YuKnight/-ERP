Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql

Namespace LFERP.Library.SampleManager.SamplePace

    Public Class SamplePaceControler
        Public Function SamplePace_Add(ByVal objinfo As SamplePaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_Add")

                db.AddInParameter(dbComm, "SO_ID", DbType.String, objinfo.SO_ID)
                db.AddInParameter(dbComm, "SS_Edition", DbType.String, objinfo.SS_Edition)
                db.AddInParameter(dbComm, "PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "SE_PaceDescribe", DbType.String, objinfo.SE_PaceDescribe)
                db.AddInParameter(dbComm, "State", DbType.String, objinfo.State)
                db.AddInParameter(dbComm, "SE_AddUserID", DbType.String, objinfo.SE_AddUserID)
                db.AddInParameter(dbComm, "SE_AddDate", DbType.DateTime, CDate(objinfo.SE_AddDate))
                'db.AddInParameter(dbComm, "SE_ModifyUserID", DbType.String, objinfo.SE_ModifyUserID)
                'db.AddInParameter(dbComm, "SE_ModifyDate", DbType.DateTime, objinfo.SE_ModifyDate)
                db.AddInParameter(dbComm, "PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "M_Code", DbType.String, objinfo.M_Code)

                db.AddInParameter(dbComm, "SE_Type", DbType.String, objinfo.SE_Type)
                db.AddInParameter(dbComm, "SE_Qty", DbType.Int32, objinfo.SE_Qty)
                db.AddInParameter(dbComm, "SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "SPID", DbType.String, objinfo.SPID)
                db.AddInParameter(dbComm, "SE_OutInType", DbType.String, objinfo.SE_OutInType)

                db.AddInParameter(dbComm, "SE_OutD_ID", DbType.String, objinfo.SE_OutD_ID)
                db.AddInParameter(dbComm, "SE_OutPS_NO", DbType.String, objinfo.SE_OutPS_NO)
                db.AddInParameter(dbComm, "SE_OutTime", DbType.DateTime, objinfo.SE_OutTime)
                db.AddInParameter(dbComm, "SE_InD_ID", DbType.String, objinfo.SE_InD_ID)
                db.AddInParameter(dbComm, "SE_InPS_NO", DbType.String, objinfo.SE_InPS_NO)
                db.AddInParameter(dbComm, "SE_OutCardID", DbType.String, objinfo.SE_OutCardID)

                db.AddInParameter(dbComm, "SE_Remark", DbType.String, objinfo.SE_Remark)
                db.AddInParameter(dbComm, "SE_LoanID", DbType.String, objinfo.SE_LoanID)
                db.AddInParameter(dbComm, "SE_BorrowType", DbType.String, objinfo.SE_BorrowType)
                db.AddInParameter(dbComm, "SE_BarCodeType", DbType.String, objinfo.SE_BarCodeType)

                db.ExecuteNonQuery(dbComm)
                SamplePace_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePace_Add = False
            End Try
        End Function

        Public Function SamplePace_GetOrdersID(ByVal soid As String) As Boolean
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_GetOrdersID")
            db.AddInParameter(dbComm, "@SO_ID", DbType.String, soid)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                reader.Read()
                If reader.FieldCount > 1 Then
                    Return True
                Else
                    Return False
                End If
            End Using
        End Function

        Public Function SamplePace_Update(ByVal objinfo As SamplePaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_Update")

                db.AddInParameter(dbComm, "SO_ID", DbType.String, objinfo.SO_ID)
                db.AddInParameter(dbComm, "SS_Edition", DbType.String, objinfo.SS_Edition)
                db.AddInParameter(dbComm, "PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "SE_PaceDescribe", DbType.String, objinfo.SE_PaceDescribe)
                db.AddInParameter(dbComm, "State", DbType.String, objinfo.State)
                db.AddInParameter(dbComm, "SE_ModifyUserID", DbType.String, objinfo.SE_ModifyUserID)
                db.AddInParameter(dbComm, "SE_ModifyDate", DbType.DateTime, CDate(objinfo.SE_ModifyDate))
                db.AddInParameter(dbComm, "PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "AutoID", DbType.String, objinfo.AutoID)

                db.AddInParameter(dbComm, "SE_Type", DbType.String, objinfo.SE_Type)
                db.AddInParameter(dbComm, "SE_Qty", DbType.Int32, objinfo.SE_Qty)
                db.AddInParameter(dbComm, "SE_AddDate", DbType.DateTime, CDate(objinfo.SE_AddDate))
                db.AddInParameter(dbComm, "SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "SPID", DbType.String, objinfo.SPID)
                db.AddInParameter(dbComm, "SE_OutInType", DbType.String, objinfo.SE_OutInType)

                db.AddInParameter(dbComm, "SE_OutD_ID", DbType.String, objinfo.SE_OutD_ID)
                db.AddInParameter(dbComm, "SE_OutPS_NO", DbType.String, objinfo.SE_OutPS_NO)
                db.AddInParameter(dbComm, "SE_InD_ID", DbType.String, objinfo.SE_InD_ID)
                db.AddInParameter(dbComm, "SE_InPS_NO", DbType.String, objinfo.SE_InPS_NO)
                db.AddInParameter(dbComm, "SE_OutCardID", DbType.String, objinfo.SE_OutCardID)

                db.AddInParameter(dbComm, "SE_Remark", DbType.String, objinfo.SE_Remark)
                db.AddInParameter(dbComm, "SE_LoanID", DbType.String, objinfo.SE_LoanID)
                db.AddInParameter(dbComm, "SE_BorrowType", DbType.String, objinfo.SE_BorrowType)
                db.AddInParameter(dbComm, "SE_BarCodeType", DbType.String, objinfo.SE_BarCodeType)

                db.ExecuteNonQuery(dbComm)
                SamplePace_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePace_Update = False
            End Try
        End Function

        Public Function SamplePacePk_Update(ByVal objinfo As SamplePaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePacePk_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@PK_Code_ID", DbType.String, objinfo.PK_Code_ID)
                db.AddInParameter(dbComm, "@SealCode_ID", DbType.String, objinfo.SealCode_ID)
                db.ExecuteNonQuery(dbComm)
                SamplePacePk_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePacePk_Update = False
            End Try
        End Function

        Public Function SamplePace_Delete(ByVal AutoID As Decimal) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_DeleteAutoID")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.ExecuteNonQuery(dbComm)
                SamplePace_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePace_Delete = False
            End Try
        End Function

        Public Function SamplePace_Delete(ByVal SO_ID As String, ByVal SS_Edition As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_Delete")
                db.AddInParameter(dbComm, "@SO_ID", DbType.String, SO_ID)
                db.AddInParameter(dbComm, "@SS_Edition", DbType.String, SS_Edition)
                db.ExecuteNonQuery(dbComm)
                SamplePace_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePace_Delete = False
            End Try
        End Function

        Public Function SamplePace_DeleteSE_ID(ByVal SE_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_DeleteSE_ID")
                db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)
                db.ExecuteNonQuery(dbComm)
                SamplePace_DeleteSE_ID = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePace_DeleteSE_ID = False
            End Try
        End Function

        Public Function SamplePace_Getlist(ByVal AutoID As String, ByVal SO_ID As String, ByVal SS_Edition As String, ByVal M_Code As String, ByVal PM_M_Code As String, ByVal StartDate As String, ByVal EndDate As String, ByVal SO_IDCheck As Boolean, ByVal SE_OutInType As String, ByVal SE_OutD_ID As String, ByVal SE_InD_ID As String, ByVal SE_Check As String, ByVal SE_InCheck As String, ByVal SE_AddUserID As String) As List(Of SamplePaceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_Getlist")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@SO_ID", DbType.String, SO_ID)
            db.AddInParameter(dbComm, "@SS_Edition", DbType.String, SS_Edition)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@SO_IDCheck", DbType.Boolean, SO_IDCheck)

            db.AddInParameter(dbComm, "@SE_OutInType", DbType.String, SE_OutInType)
            db.AddInParameter(dbComm, "@SE_OutD_ID", DbType.String, SE_OutD_ID)
            db.AddInParameter(dbComm, "@SE_InD_ID", DbType.String, SE_InD_ID)
            db.AddInParameter(dbComm, "@SE_Check", DbType.String, SE_Check)
            db.AddInParameter(dbComm, "@SE_InCheck", DbType.String, SE_InCheck)
            db.AddInParameter(dbComm, "@SE_AddUserID", DbType.String, SE_AddUserID)

            Dim FeatureList As New List(Of SamplePaceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePace_Getlist2(ByVal AutoID As String, ByVal SO_ID As String, ByVal SS_Edition As String, ByVal M_Code As String, ByVal PM_M_Code As String, ByVal StartDate As String, ByVal EndDate As String, ByVal SO_IDCheck As Boolean, ByVal SE_OutInType As String, ByVal SE_OutD_ID As String, ByVal SE_InD_ID As String, ByVal SE_Check As String, ByVal SE_InCheck As String) As List(Of SamplePaceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_Getlist2")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@SO_ID", DbType.String, SO_ID)
            db.AddInParameter(dbComm, "@SS_Edition", DbType.String, SS_Edition)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@SO_IDCheck", DbType.Boolean, SO_IDCheck)

            db.AddInParameter(dbComm, "@SE_OutInType", DbType.String, SE_OutInType)
            db.AddInParameter(dbComm, "@SE_OutD_ID", DbType.String, SE_OutD_ID)
            db.AddInParameter(dbComm, "@SE_InD_ID", DbType.String, SE_InD_ID)
            db.AddInParameter(dbComm, "@SE_Check", DbType.String, SE_Check)
            db.AddInParameter(dbComm, "@SE_InCheck", DbType.String, SE_InCheck)

            Dim FeatureList As New List(Of SamplePaceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceType(reader))
                End While
                Return FeatureList
            End Using
        End Function


        Public Function SamplePace_Getlist1(ByVal AutoID As String, ByVal SO_ID As String, ByVal SS_Edition As String, ByVal M_Code As String, ByVal PM_M_Code As String, ByVal StartDate As String, ByVal EndDate As String, ByVal SO_IDCheck As String, ByVal SE_ID As String, ByVal SE_Check As String) As List(Of SamplePaceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_Getlist1")

            db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
            db.AddInParameter(dbComm, "@SO_ID", DbType.String, SO_ID)
            db.AddInParameter(dbComm, "@SS_Edition", DbType.String, SS_Edition)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@StartDate", DbType.String, StartDate)
            db.AddInParameter(dbComm, "@EndDate", DbType.String, EndDate)
            db.AddInParameter(dbComm, "@SO_IDCheck", DbType.String, SO_IDCheck)

            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)
            db.AddInParameter(dbComm, "@SE_Check", DbType.String, SE_Check)

            Dim FeatureList As New List(Of SamplePaceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePace_Getlist3(ByVal PS_NO As String) As List(Of SamplePaceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_Getlist3")

            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)

            Dim FeatureList As New List(Of SamplePaceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePace_Get(ByVal SP_ID As String) As SamplePaceInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_Get")
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, SP_ID)
            Dim FeatureList As New SamplePaceInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.PS_NO = reader("PS_NO").ToString
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillSamplePaceType(ByVal reader As IDataReader) As SamplePaceInfo
            On Error Resume Next

            Dim objInfo As New SamplePaceInfo

            objInfo.SO_ID = reader("SO_ID").ToString
            objInfo.SS_Edition = reader("SS_Edition").ToString
            objInfo.PS_NO = reader("PS_NO").ToString
            objInfo.SE_AddDate = CDate(reader("SE_AddDate").ToString)
            objInfo.SE_PaceDescribe = reader("SE_PaceDescribe").ToString
            objInfo.State = reader("State").ToString
            objInfo.SE_AddUserID = reader("SE_AddUserID").ToString
            objInfo.SE_AddDate = CDate(reader("SE_AddDate").ToString)
            objInfo.SE_ModifyUserID = reader("SE_ModifyUserID").ToString
            objInfo.SE_ModifyDate = CDate(reader("SE_ModifyDate").ToString)
            objInfo.PM_M_Code = reader("PM_M_Code").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.AutoID = CDbl(reader("AutoID").ToString)
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.SE_AddUserName = reader("SE_AddUserName").ToString
            objInfo.PS_Name = reader("PS_Name").ToString

            objInfo.SE_Type = reader("SE_Type").ToString
            objInfo.SE_TypeName = reader("SE_TypeName").ToString

            objInfo.SE_Qty = reader("SE_Qty")

            objInfo.SE_Check = reader("SE_Check")
            objInfo.SE_CheckAction = reader("SE_CheckAction").ToString
            objInfo.SE_CheckActionName = reader("SE_CheckActionName").ToString
            objInfo.SE_CheckDate = CDate(reader("SE_CheckDate").ToString)
            objInfo.SE_ID = reader("SE_ID").ToString

            objInfo.SE_OutInType = reader("SE_OutInType").ToString
            objInfo.SPID = reader("SPID").ToString
            objInfo.Code_ID = reader("Code_ID").ToString
            objInfo.Qty = CInt(reader("Qty").ToString)
            objInfo.ClientBarcode = reader("ClientBarcode").ToString

            objInfo.SE_OutD_ID = reader("SE_OutD_ID").ToString
            objInfo.SE_OutPS_NO = reader("SE_OutPS_NO").ToString
            objInfo.SE_OutTime = reader("SE_OutTime")
            objInfo.SE_InD_ID = reader("SE_InD_ID").ToString
            objInfo.SE_InPS_NO = reader("SE_InPS_NO").ToString
            objInfo.SE_InTime = reader("SE_InTime")

            objInfo.SE_InD_Dep = reader("SE_InD_Dep").ToString
            objInfo.SE_OutD_Dep = reader("SE_OutD_Dep").ToString
            objInfo.SE_OutPS_Name = reader("SE_OutPS_Name").ToString
            objInfo.SE_InPS_Name = reader("SE_InPS_Name").ToString

            objInfo.SE_InCardID = reader("SE_InCardID").ToString
            objInfo.SE_OutCardID = reader("SE_OutCardID").ToString
            objInfo.SE_InCardIDName = reader("SE_InCardIDName").ToString
            objInfo.SE_OutCardIDName = reader("SE_OutCardIDName").ToString


            objInfo.SE_InCheck = reader("SE_InCheck")
            objInfo.SE_OutVisible = reader("SE_OutVisible")
            objInfo.SE_InVisible = reader("SE_InVisible")


            objInfo.SE_OutEnabled = reader("SE_OutEnabled")
            objInfo.SE_InEnabled = reader("SE_InEnabled")
            objInfo.SE_OutPSEnabled = reader("SE_OutPSEnabled")
            objInfo.SE_InPSEnabled = reader("SE_InPSEnabled")
            objInfo.SE_InCheckBarcode = reader("SE_InCheckBarcode")
            objInfo.StatusType = reader("StatusType").ToString


            objInfo.SE_IncheckAction = reader("SE_IncheckAction").ToString
            objInfo.SE_InCheckActionName = reader("SE_InCheckActionName").ToString

            objInfo.InCheck = reader("InCheck")
            objInfo.InCheckDate = reader("InCheckDate").ToString
            objInfo.SO_SampleID = reader("SO_SampleID").ToString

            objInfo.SE_Remark = reader("SE_Remark").ToString
            objInfo.SE_LoanID = reader("SE_LoanID").ToString
            objInfo.BarCodeCount = reader("BarCodeCount")

            objInfo.SE_BorrowType = reader("SE_BorrowType").ToString
            objInfo.MaterialTypeName = reader("MaterialTypeName").ToString
            objInfo.PK_Code_ID = reader("PK_Code_ID").ToString
            objInfo.SealCode_ID = reader("SealCode_ID").ToString
            objInfo.SE_BarcodeLink = reader("SE_BarcodeLink").ToString
            objInfo.SE_BarCodeType = reader("SE_BarCodeType").ToString
            objInfo.SE_BarCodeAuto = reader("SE_BarCodeAuto")
            objInfo.SE_EditInD_ID = reader("SE_EditInD_ID")

            Return objInfo
        End Function

        ''' <summary>
        ''' 載入類理
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SamplePaceType_Getlist(ByVal SE_Type As String) As List(Of SamplePaceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceType_Getlist")
            db.AddInParameter(dbComm, "@SE_Type", DbType.String, SE_Type)

            Dim FeatureList As New List(Of SamplePaceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceType(reader))
                End While
                Return FeatureList
            End Using
        End Function



        Public Function SamplePace_UpdateCheck(ByVal objinfo As SamplePaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_UpdateCheck")

                db.AddInParameter(dbComm, "@SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "@SE_Check", DbType.Boolean, objinfo.SE_Check)
                db.AddInParameter(dbComm, "@SE_CheckDate", DbType.Date, objinfo.SE_CheckDate)
                db.AddInParameter(dbComm, "@SE_CheckAction", DbType.String, objinfo.SE_CheckAction)

                db.ExecuteNonQuery(dbComm)
                SamplePace_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePace_UpdateCheck = False
            End Try
        End Function
        Public Function SamplePace_UpdateInCheck(ByVal objinfo As SamplePaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_UpdateInCheck")

                db.AddInParameter(dbComm, "@SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "@SE_InCheck", DbType.Boolean, objinfo.SE_InCheck)
                db.AddInParameter(dbComm, "@SE_InCheckAction", DbType.String, objinfo.SE_IncheckAction)
                db.AddInParameter(dbComm, "@SE_InCardID", DbType.String, objinfo.SE_InCardID)

                db.ExecuteNonQuery(dbComm)
                SamplePace_UpdateInCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePace_UpdateInCheck = False
            End Try
        End Function

        Public Function SamplePace_GetID(ByVal SE_ID As String) As SamplePaceInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_GetID")
            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)
            Dim FeatureList As New SamplePaceInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.SE_ID = reader("SE_ID").ToString
                End While
                Return FeatureList
            End Using
        End Function


        Protected Overrides Sub Finalize()
            MyBase.Finalize()
        End Sub

#Region "半成品條碼"
        Public Function SamplePaceBarCode_Add(ByVal objinfo As SamplePaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceBarCode_Add")

                db.AddInParameter(dbComm, "@SPID", DbType.String, objinfo.SPID)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@Qty", DbType.Int32, objinfo.Qty)
                db.AddInParameter(dbComm, "@SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "@SE_AddDate", DbType.DateTime, objinfo.SE_AddDate)
                db.AddInParameter(dbComm, "@SE_AddUserID", DbType.String, objinfo.SE_AddUserID)
                db.AddInParameter(dbComm, "@ClientBarcode", DbType.String, objinfo.ClientBarcode)
                db.AddInParameter(dbComm, "@SE_Type", DbType.String, objinfo.SE_Type)

                db.ExecuteNonQuery(dbComm)
                SamplePaceBarCode_Add = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePaceBarCode_Add = False
            End Try

        End Function

        Public Function SamplePaceBarCode_Update(ByVal objinfo As SamplePaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceBarCode_Update")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objinfo.AutoID)
                db.AddInParameter(dbComm, "@InCheck", DbType.String, objinfo.InCheck)
                db.AddInParameter(dbComm, "@InCheckDate", DbType.DateTime, objinfo.InCheckDate)

                db.ExecuteNonQuery(dbComm)
                SamplePaceBarCode_Update = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePaceBarCode_Update = False
            End Try
        End Function
        Public Function SamplePaceBarCode_UpdateA(ByVal objinfo As SamplePaceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceBarCode_UpdateA")

                db.AddInParameter(dbComm, "@SE_ID", DbType.String, objinfo.SE_ID)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, objinfo.Code_ID)
                db.AddInParameter(dbComm, "@SE_Type", DbType.String, objinfo.SE_Type)

                db.ExecuteNonQuery(dbComm)
                SamplePaceBarCode_UpdateA = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePaceBarCode_UpdateA = False
            End Try
        End Function
        Public Function SamplePaceBarCode_Delete(ByVal AutoID As String, ByVal SE_ID As String, ByVal Code_ID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceBarCode_Delete")

                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)
                db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)


                db.ExecuteNonQuery(dbComm)
                SamplePaceBarCode_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                SamplePaceBarCode_Delete = False
            End Try
        End Function

        Public Function SamplePaceBarCode_Getlist(ByVal SPID As String, ByVal Code_ID As String, ByVal SE_ID As String) As List(Of SamplePaceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceBarCode_Getlist")

            db.AddInParameter(dbComm, "@SPID", DbType.String, SPID)
            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)

            Dim FeatureList As New List(Of SamplePaceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceType(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function SamplePaceBarCode_Getlist2(ByVal Code_ID As String, ByVal SE_ID As String) As List(Of SamplePaceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePaceBarCode_Getlist2")

            db.AddInParameter(dbComm, "@Code_ID", DbType.String, Code_ID)
            db.AddInParameter(dbComm, "@SE_ID", DbType.String, SE_ID)

            Dim FeatureList As New List(Of SamplePaceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SamplePace_GetIDA(ByVal SPID As String) As SamplePaceInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_GetIDA")
            db.AddInParameter(dbComm, "@SPID", DbType.String, SPID)
            Dim FeatureList As New SamplePaceInfo
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.SPID = reader("SPID").ToString
                End While
                Return FeatureList
            End Using
        End Function
#End Region


#Region "報警-在指定時間內未收料確認時提示"

        Public Function SamplePace_GetlistWarning(ByVal SE_InD_ID As String, ByVal SE_OutD_ID As String) As List(Of SamplePaceInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SamplePace_GetlistWarning")

            db.AddInParameter(dbComm, "@SE_InD_ID", DbType.String, SE_InD_ID)
            db.AddInParameter(dbComm, "@SE_OutD_ID", DbType.String, SE_OutD_ID)

            Dim FeatureList As New List(Of SamplePaceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSamplePaceType(reader))
                End While
                Return FeatureList
            End Using
        End Function
#End Region


    End Class

End Namespace



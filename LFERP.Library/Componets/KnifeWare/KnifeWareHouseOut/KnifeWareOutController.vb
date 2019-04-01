Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Namespace LFERP.Library.KnifeWare
    Public Class KnifeWareOutController
        ''' <summary>
        ''' 新增
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_Add(ByVal objFile1 As KnifeWareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_Add")

                db.AddInParameter(dbComm, "@WO_NUM", DbType.String, objFile1.WO_NUM)
                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)
                db.AddInParameter(dbComm, "@WO_Type", DbType.String, objFile1.WO_Type)
                db.AddInParameter(dbComm, "@AP_NO", DbType.String, objFile1.AP_NO)
                db.AddInParameter(dbComm, "@OP_NO", DbType.String, objFile1.OP_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                db.AddInParameter(dbComm, "@WO_Qty", DbType.Single, objFile1.WO_Qty)

                If objFile1.WO_AddDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_AddDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_AddDate", DbType.Date, objFile1.WO_AddDate)
                End If

                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objFile1.WH_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@WO_Action", DbType.String, objFile1.WO_Action)

                If objFile1.WO_EditDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_EditDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_EditDate", DbType.Date, objFile1.WO_EditDate)
                End If

                db.AddInParameter(dbComm, "@WO_Remark", DbType.String, objFile1.WO_Remark)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@WO_PerID", DbType.String, objFile1.WO_PerID)
                db.AddInParameter(dbComm, "@WO_PerName", DbType.String, objFile1.WO_PerName)
                db.AddInParameter(dbComm, "@WO_Check", DbType.Boolean, objFile1.WO_Check)
                db.AddInParameter(dbComm, "@WO_CheckAction", DbType.String, objFile1.WO_CheckAction)

                If objFile1.WO_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, objFile1.WO_CheckDate)
                End If

                db.AddInParameter(dbComm, "@WO_CheckRemark", DbType.String, objFile1.WO_CheckRemark)
                db.AddInParameter(dbComm, "@M_ID", DbType.String, objFile1.M_ID)
                db.AddInParameter(dbComm, "@Temp_Code", DbType.String, objFile1.Temp_Code)
                db.AddInParameter(dbComm, "@KnifeType", DbType.String, objFile1.KnifeType)

                db.ExecuteNonQuery(dbComm)
                KnifeWareOut_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeWareOut_Add = False
            End Try

        End Function

        ''' <summary>
        ''' 修改 
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_Update(ByVal objFile1 As KnifeWareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_Update")

                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)
                db.AddInParameter(dbComm, "@WO_NUM", DbType.String, objFile1.WO_NUM)
                db.AddInParameter(dbComm, "@WO_Type", DbType.String, objFile1.WO_Type)
                db.AddInParameter(dbComm, "@AP_NO", DbType.String, objFile1.AP_NO)
                db.AddInParameter(dbComm, "@OP_NO", DbType.String, objFile1.OP_NO)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                db.AddInParameter(dbComm, "@WO_Qty", DbType.Single, objFile1.WO_Qty)

                If objFile1.WO_AddDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_AddDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_AddDate", DbType.Date, objFile1.WO_AddDate)
                End If

                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objFile1.WH_ID)
                db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
                db.AddInParameter(dbComm, "@WO_Action", DbType.String, objFile1.WO_Action)

                If objFile1.WO_EditDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_EditDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_EditDate", DbType.Date, objFile1.WO_EditDate)
                End If

                db.AddInParameter(dbComm, "@WO_Remark", DbType.String, objFile1.WO_Remark)
                db.AddInParameter(dbComm, "@DPT_ID", DbType.String, objFile1.DPT_ID)
                db.AddInParameter(dbComm, "@WO_PerID", DbType.String, objFile1.WO_PerID)
                db.AddInParameter(dbComm, "@WO_PerName", DbType.String, objFile1.WO_PerName)
                db.AddInParameter(dbComm, "@WO_Check", DbType.Boolean, objFile1.WO_Check)
                db.AddInParameter(dbComm, "@WO_CheckAction", DbType.String, objFile1.WO_CheckAction)

                If objFile1.WO_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, objFile1.WO_CheckDate)
                End If

                db.AddInParameter(dbComm, "@WO_CheckRemark", DbType.String, objFile1.WO_CheckRemark)
                db.AddInParameter(dbComm, "@M_ID", DbType.String, objFile1.M_ID)
                db.AddInParameter(dbComm, "@Temp_Code", DbType.String, objFile1.Temp_Code)

                db.ExecuteNonQuery(dbComm)
                KnifeWareOut_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeWareOut_Update = False
            End Try

        End Function

        ''' <summary>
        ''' 修改審核  (具體到取消審核)
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_UpdateCheck(ByVal objFile1 As KnifeWareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_UpdateCheck")

                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)
                db.AddInParameter(dbComm, "@WO_Check", DbType.Boolean, objFile1.WO_Check)
                db.AddInParameter(dbComm, "@WO_CheckAction", DbType.String, objFile1.WO_CheckAction)
                db.AddInParameter(dbComm, "@WO_CheckRemark", DbType.String, objFile1.WO_CheckRemark)

                If objFile1.WO_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_CheckDate", DbType.Date, objFile1.WO_CheckDate)
                End If

                db.ExecuteNonQuery(dbComm)
                KnifeWareOut_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeWareOut_UpdateCheck = False
            End Try

        End Function

        ''' <summary>
        ''' 刪除
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="WO_NUM"></param>
        ''' <param name="WO_ID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_Delete(ByVal WO_NUM As String, ByVal WO_ID As String) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_Delete")
                db.AddInParameter(dbComm, "@WO_NUM", DbType.String, WO_NUM)
                db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)

                db.ExecuteNonQuery(dbComm)
                KnifeWareOut_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeWareOut_Delete = False
            End Try

        End Function

        ''' <summary>
        ''' 取得當前最大的ID。隻用於生成新的ID用
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="NDate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_GetID(ByVal NDate As String) As KnifeWareOutInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_GetID")

            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillKnifeWareOut(reader)
                End While
                Return Nothing
            End Using

        End Function

        ''' <summary>
        ''' 取得一條最大WO_NUM記錄
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="WO_NUM"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_GetNUM(ByVal WO_NUM As String) As KnifeWareOutInfo

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_GetNUM")
            db.AddInParameter(dbComm, "@WO_NUM", DbType.String, WO_NUM)

            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillKnifeWareOut(reader)
                End While
                Return Nothing
            End Using

        End Function

        ''' <summary>
        ''' 復核(會計部操作)
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_UpdateReCheck(ByVal objFile1 As KnifeWareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_UpdateReCheck")

                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)
                db.AddInParameter(dbComm, "@WO_ReCheck", DbType.Boolean, objFile1.WO_ReCheck)
                db.AddInParameter(dbComm, "@WO_ReCheckAction", DbType.String, objFile1.WO_ReCheckAction)
                db.AddInParameter(dbComm, "@WO_ReCheckRemark", DbType.String, objFile1.WO_ReCheckRemark)

                If objFile1.WO_ReCheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@WO_ReCheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@WO_ReCheckDate", DbType.Date, objFile1.WO_ReCheckDate)
                End If

                db.ExecuteNonQuery(dbComm)
                KnifeWareOut_UpdateReCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeWareOut_UpdateReCheck = False
            End Try

        End Function

        Public Function KnifeWareOut_Getlist(ByVal WO_ID As String, ByVal OS_BatchID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WO_PerID As String, ByVal WO_AddDate As String, ByVal WO_AddDateVal As String, ByVal WO_Check As String, ByVal WO_ReCheck As String, ByVal Type3ID As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_Getlist")

            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WO_PerID", DbType.String, WO_PerID)
            db.AddInParameter(dbComm, "@WO_AddDate", DbType.String, WO_AddDate)
            db.AddInParameter(dbComm, "@WO_AddDateVal", DbType.String, WO_AddDateVal)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)
            db.AddInParameter(dbComm, "@WO_ReCheck", DbType.String, WO_ReCheck)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' '導出出庫報表的存儲過程
        ''' 姚駿
        ''' 2013-11-11
        ''' </summary>
        ''' <param name="WH_ID"></param>
        ''' <param name="WO_AddDate"></param>
        ''' <param name="WO_AddDateAll"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOutExportReport_GetList(ByVal WH_ID As String, ByVal WO_AddDate As String, ByVal WO_AddDateAll As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOutExportReport_GetList")


            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WO_AddDate", DbType.String, WO_AddDate)
            db.AddInParameter(dbComm, "@WO_AddDateAll", DbType.String, WO_AddDateAll)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function KnifeWareOut_GetList5(ByVal WO_ID As String, ByVal OS_BatchID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WO_PerID As String, ByVal WO_AddDate As String, ByVal WO_AddDateVal As String, ByVal WO_Check As String, ByVal WO_ReCheck As String, ByVal Type3ID As String) As List(Of KnifeWareOutInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_GetList5")

            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WO_PerID", DbType.String, WO_PerID)
            db.AddInParameter(dbComm, "@WO_AddDate", DbType.String, WO_AddDate)
            db.AddInParameter(dbComm, "@WO_AddDateVal", DbType.String, WO_AddDateVal)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)
            db.AddInParameter(dbComm, "@WO_ReCheck", DbType.String, WO_ReCheck)
            db.AddInParameter(dbComm, "@Type3ID", DbType.String, Type3ID)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function KnifeWareOut_GetList1(ByVal WO_ID As String, ByVal WH_ID As String, ByVal M_Code As String, ByVal DPT_ID As String, ByVal M_Name As String, ByVal WO_Date1 As String, ByVal WO_Date2 As String, ByVal WO_PerID As String, ByVal WO_Check As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_GetList1")

            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@WO_Date1", DbType.String, WO_Date1)
            db.AddInParameter(dbComm, "@WO_Date2", DbType.String, WO_Date2)
            db.AddInParameter(dbComm, "@WO_PerID", DbType.String, WO_PerID)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function KnifeWareOutExport_Getlist(ByVal WH_ID As String, ByVal DPT_ID As String, ByVal WO_AddDate1 As String, ByVal WO_AddDate2 As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOutExport_Getlist")
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DPT_ID", DbType.String, DPT_ID)
            db.AddInParameter(dbComm, "@WO_AddDate1", DbType.String, WO_AddDate1)
            db.AddInParameter(dbComm, "@WO_AddDate2", DbType.String, WO_AddDate2)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        '''  匯總當前倉庫當前批次指定物料的出庫總數
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="WO_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_GetQty(ByVal OS_BatchID As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal WO_Check As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_GetQty")

            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 匯總當前倉庫指定物料在所有批次中分別出庫總數量
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="OS_BatchID"></param>
        ''' <param name="M_Code"></param>
        ''' <param name="WH_ID"></param>
        ''' <param name="WO_Check"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_GetQty1(ByVal OS_BatchID As String, ByVal M_Code As String, ByVal WH_ID As String, ByVal WO_Check As String, ByVal WO_Date1 As String, ByVal WO_Date2 As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_GetQty1")

            db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, OS_BatchID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)
            db.AddInParameter(dbComm, "@WO_Date1", DbType.String, WO_Date1)
            db.AddInParameter(dbComm, "@WO_Date2", DbType.String, WO_Date2)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function KnifeWareOut_GetQty2(ByVal M_Code As String, ByVal WH_ID As String, ByVal WO_Check As String, ByVal WO_Date1 As String, ByVal WO_Date2 As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_GetQty2")

            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@WO_Check", DbType.String, WO_Check)
            db.AddInParameter(dbComm, "@WO_Date1", DbType.String, WO_Date1)
            db.AddInParameter(dbComm, "@WO_Date2", DbType.String, WO_Date2)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function KnifeWareOut_GetQty3(ByVal WO_ID As String, ByVal M_Code As String, ByVal OP_NO As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_GetQty3")

            db.AddInParameter(dbComm, "@WO_ID", DbType.String, WO_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@OP_NO", DbType.String, OP_NO)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function KnifeWareOut_ProductionGetList(ByVal WO_Type As String, ByVal AP_NO As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_ProductionGetList")

            db.AddInParameter(dbComm, "@WO_Type", DbType.String, WO_Type)
            db.AddInParameter(dbComm, "@AP_NO", DbType.String, AP_NO)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function KnifeWareOut_UpdateEndQty(ByVal objinfo As KnifeWareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_UpdateEndQty")

                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objinfo.WO_ID)
                db.AddInParameter(dbComm, "@WH_ID", DbType.String, objinfo.WH_ID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@WO_EndQty", DbType.Single, objinfo.WO_EndQty)

                db.ExecuteNonQuery(dbComm)
                KnifeWareOut_UpdateEndQty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeWareOut_UpdateEndQty = False
            End Try

        End Function


        Public Function KnifeWareOut_HalfYearGetList(ByVal WH_ID As String, ByVal M_Code As String, ByVal WO_AddDate As String, ByVal WO_AddDateVal As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_HalfYearGetList")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@WO_AddDate", DbType.String, WO_AddDate)
            db.AddInParameter(dbComm, "@WO_AddDateVal", DbType.String, WO_AddDateVal)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 出庫匯總信息 2012-11-20
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="WH_ID"></param>
        ''' <param name="DateStart"></param>
        ''' <param name="DateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_Getlist4(ByVal WH_ID As String, ByVal DateStart As String, ByVal DateEnd As String) As List(Of KnifeWareOutInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_GetList4")

            db.AddInParameter(dbComm, "@WH_ID", DbType.String, WH_ID)
            db.AddInParameter(dbComm, "@DateStart", DbType.String, DateStart)
            db.AddInParameter(dbComm, "@DateEnd", DbType.String, DateEnd)

            Dim FeatureList As New List(Of KnifeWareOutInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillKnifeWareOut(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 只修改備注信息
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function KnifeWareOut_UpdateRemark(ByVal objFile1 As KnifeWareOutInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("KnifeWareOut_UpdateRemark")

                db.AddInParameter(dbComm, "@WO_ID", DbType.String, objFile1.WO_ID)
                db.AddInParameter(dbComm, "@WO_NUM", DbType.String, objFile1.WO_NUM)
                db.AddInParameter(dbComm, "@WO_Remark", DbType.String, objFile1.WO_Remark)

                db.ExecuteNonQuery(dbComm)
                KnifeWareOut_UpdateRemark = True

            Catch ex As Exception
                MsgBox(ex.Message)
                KnifeWareOut_UpdateRemark = False
            End Try

        End Function

        ''' <summary>
        ''' 對應取得的數據
        ''' 添加人：丁華普
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Friend Function FillKnifeWareOut(ByVal reader As IDataReader) As KnifeWareOutInfo

            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New KnifeWareOutInfo

            objInfo.SumHKD = reader("SumHKD")
            objInfo.HKDRate = reader("HKDRate")
            objInfo.WO_NUM = reader("WO_NUM").ToString
            objInfo.WO_ID = reader("WO_ID").ToString
            objInfo.WO_Type = reader("WO_Type").ToString
            objInfo.AP_NO = reader("AP_NO").ToString
            objInfo.OP_NO = reader("OP_NO").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.KnifeType = reader("KnifeType").ToString
            objInfo.WH_ID = reader("WH_ID").ToString
            objInfo.OS_BatchID = reader("OS_BatchID").ToString
            objInfo.WO_Action = reader("WO_Action").ToString
            objInfo.WO_Remark = reader("WO_Remark").ToString
            objInfo.DPT_ID = reader("DPT_ID").ToString
            objInfo.WO_PerID = reader("WO_PerID").ToString
            objInfo.WO_PerName = reader("WO_PerName").ToString
            objInfo.WO_CheckAction = reader("WO_CheckAction").ToString
            objInfo.WO_CheckRemark = reader("WO_CheckRemark").ToString
            objInfo.WO_ReCheckAction = reader("WO_ReCheckAction").ToString
            objInfo.WO_ReCheckRemark = reader("WO_ReCheckRemark").ToString
            objInfo.WO_ActionName = reader("WO_ActionName").ToString
            objInfo.WO_CheckActionName = reader("WO_CheckActionName").ToString
            objInfo.WH_Name = reader("WH_Name").ToString
            objInfo.WH_PName = reader("WH_PName").ToString
            objInfo.DPT_Name = reader("DPT_PName").ToString & "-" & reader("DPT_Name").ToString
            objInfo.DPT_PName = reader("DPT_PName").ToString
            objInfo.M_ID = reader("M_ID").ToString
            objInfo.Temp_Code = reader("Temp_Code").ToString
            objInfo.strDate = CStr(reader("strDate").ToString)
            objInfo.TypeAllName = reader("Type1Name") & "-" & reader("Type2Name") & "-" & reader("Type3Name")
            objInfo.M_Currency = CStr(reader("M_Currency").ToString)
            objInfo.M_ID = reader("M_ID").ToString
            objInfo.Temp_Code = reader("Temp_Code").ToStringobjInfo.WH_AllName = reader("WH_PName").ToString & "-" & reader("WH_Name").ToString

            If reader("M_Price") Is DBNull.Value Then
                objInfo.M_Price = Nothing
            Else
                objInfo.M_Price = FormatNumber(CDbl(reader("M_Price")), 4, TriState.True)
            End If

            If reader("WO_Qty") Is DBNull.Value Then
                objInfo.WO_Qty = Nothing
            Else
                objInfo.WO_Qty = CDbl(reader("WO_Qty").ToString)
            End If

            If reader("WO_AddDate") Is DBNull.Value Then
                objInfo.WO_AddDate = Nothing
            Else
                objInfo.WO_AddDate = CStr(reader("WO_AddDate"))
            End If

            If reader("WO_EditDate") Is DBNull.Value Then
                objInfo.WO_EditDate = Nothing
            Else
                objInfo.WO_EditDate = CStr(reader("WO_EditDate"))
            End If

            If reader("WO_Check") Is DBNull.Value Then
                objInfo.WO_Check = Nothing
            Else
                objInfo.WO_Check = reader("WO_Check")
            End If

            If reader("WO_CheckDate") Is DBNull.Value Then
                objInfo.WO_CheckDate = Nothing
            Else
                objInfo.WO_CheckDate = CStr(reader("WO_CheckDate"))
            End If

            If reader("WO_ReCheck") Is DBNull.Value Then
                objInfo.WO_ReCheck = Nothing
            Else
                objInfo.WO_ReCheck = reader("WO_ReCheck")
            End If

            If reader("WO_ReCheckDate") Is DBNull.Value Then
                objInfo.WO_ReCheckDate = Nothing
            Else
                objInfo.WO_ReCheckDate = CStr(reader("WO_ReCheckDate"))
            End If

            If reader("OutGetQty") Is DBNull.Value Then
                objInfo.OutGetQty = Nothing
            Else
                objInfo.OutGetQty = CDbl(reader("OutGetQty").ToString)
            End If

            If reader("OutGetQty1") Is DBNull.Value Then
                objInfo.OutGetQty1 = Nothing
            Else
                objInfo.OutGetQty1 = CDbl(reader("OutGetQty1").ToString)
            End If

            If reader("WO_EndQty") Is DBNull.Value Then   '出庫后的期末結餘數
                objInfo.WO_EndQty = 0
            Else
                objInfo.WO_EndQty = CDbl(reader("WO_EndQty").ToString)
            End If

            If reader("AllQty") Is DBNull.Value Then
                objInfo.AllQty = 0
            Else
                objInfo.AllQty = reader("AllQty")
            End If

            objInfo.WO_PerNameS = reader("WO_PerNameS").ToString

            Return objInfo
        End Function
    End Class
End Namespace
Imports System.Data.Common

Namespace LFERP.Library.ProductionOWPAcceptance
    Public Class ProductionOWPAcceptanceControl

        ''' <summary>
        ''' 查產品工序外發加工單
        ''' </summary>
        ''' <param name="A_AcceptanceNO"></param>
        ''' <param name="O_NO"></param>
        ''' <param name="ASend_NO"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="PS_NO"></param>
        ''' <param name="S_Supplier"></param>
        ''' <param name="A_Action"></param>
        ''' <param name="A_CheckAction"></param>
        ''' <param name="A_SendDateStart"></param>
        ''' <param name="A_SendDateEnd"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOWPAcceptance_GetList(ByVal OPAutoID As String, ByVal A_AcceptanceNO As String, ByVal O_NO As String, ByVal ASend_NO As String, ByVal PM_M_Code As String, ByVal PM_Type As String, _
                                                  ByVal PS_NO As String, ByVal S_Supplier As String, ByVal A_Action As String, ByVal A_CheckAction As String, _
                                                  ByVal A_SendDateStart As String, ByVal A_SendDateEnd As String, ByVal A_Check As String, ByVal A_AccCheck As String) As List(Of ProductionOWPAcceptanceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_GetList")

            db.AddInParameter(dbComm, "@OPAutoID", DbType.String, OPAutoID)  ''2013

            db.AddInParameter(dbComm, "@A_AcceptanceNO", DbType.String, A_AcceptanceNO)
            db.AddInParameter(dbComm, "@O_NO", DbType.String, O_NO)
            db.AddInParameter(dbComm, "@ASend_NO", DbType.String, ASend_NO)

            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)

            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, S_Supplier)
            db.AddInParameter(dbComm, "@A_Action", DbType.String, A_Action)
            db.AddInParameter(dbComm, "@A_CheckAction", DbType.String, A_CheckAction)

            db.AddInParameter(dbComm, "@A_SendDateStart", DbType.String, A_SendDateStart)
            db.AddInParameter(dbComm, "@A_SendDateEnd", DbType.String, A_SendDateEnd)

            db.AddInParameter(dbComm, "@A_Check", DbType.String, A_Check)
            db.AddInParameter(dbComm, "@A_AccCheck", DbType.String, A_AccCheck)


            Dim FeatureList As New List(Of ProductionOWPAcceptanceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionOWPAcceptance(reader))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 讀取數據信息
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function FillProductionOWPAcceptance(ByVal reader As IDataReader) As ProductionOWPAcceptanceInfo
            ' On Error Resume Next
            Dim ai As New ProductionOWPAcceptanceInfo

            'PM_JiYu
            If reader("PM_JiYu") Is DBNull.Value Then ai.PM_JiYu = Nothing Else ai.PM_JiYu = reader("PM_JiYu").ToString

            If reader("OPAutoID") Is DBNull.Value Then ai.OPAutoID = Nothing Else ai.OPAutoID = reader("OPAutoID").ToString 'ai.A_AcceptanceNO  '流水號 

            If reader("A_AcceptanceNO") Is DBNull.Value Then ai.A_AcceptanceNO = Nothing Else ai.A_AcceptanceNO = reader("A_AcceptanceNO").ToString 'ai.A_AcceptanceNO  '流水號 
            If reader("A_NO") Is DBNull.Value Then ai.A_NO = Nothing Else ai.A_NO = reader("A_NO").ToString '/驗收編號
            If reader("O_NO") Is DBNull.Value Then ai.O_NO = Nothing Else ai.O_NO = reader("O_NO").ToString 'ai.O_NO  '外發單號 end if
            If reader("ASend_NO") Is DBNull.Value Then ai.ASend_NO = Nothing Else ai.ASend_NO = reader("ASend_NO").ToString ' ' /送貨單號

            If reader("DPT_ID") Is DBNull.Value Then ai.DPT_ID = Nothing Else ai.DPT_ID = reader("DPT_ID").ToString ' '  /外發部門ID 此處固定為外發部
            If reader("PM_M_Code") Is DBNull.Value Then ai.PM_M_Code = Nothing Else ai.PM_M_Code = reader("PM_M_Code").ToString '/產品名稱
            If reader("PM_Type") Is DBNull.Value Then ai.PM_Type = Nothing Else ai.PM_Type = reader("PM_Type").ToString 'ai.PM_Type = Nothing '/類型

            If reader("PS_NO") Is DBNull.Value Then ai.PS_NO = Nothing Else ai.PS_NO = reader("PS_NO").ToString '外發工序
            If reader("S_Supplier") Is DBNull.Value Then ai.S_Supplier = Nothing Else ai.S_Supplier = reader("S_Supplier").ToString '/供貨商編號
            If reader("A_OK_Qty") Is DBNull.Value Then ai.A_OK_Qty = Nothing Else ai.A_OK_Qty = CDbl(reader("A_OK_Qty").ToString) '/驗收ok數量

            If reader("A_QQ_Qty") Is DBNull.Value Then ai.A_QQ_Qty = Nothing Else ai.A_QQ_Qty = CDbl(reader("A_QQ_Qty").ToString) '/驗收前Q數量
            If reader("A_TC_Qty") Is DBNull.Value Then ai.A_TC_Qty = Nothing Else ai.A_TC_Qty = CDbl(reader("A_TC_Qty").ToString) '/驗收退次數量'
            If reader("A_QT_Qty") Is DBNull.Value Then ai.A_QT_Qty = Nothing Else ai.A_QT_Qty = CDbl(reader("A_QT_Qty").ToString) '/驗收其它數量

            If reader("A_Ver") Is DBNull.Value Then ai.A_Ver = Nothing Else ai.A_Ver = CDbl(reader("A_Ver").ToString) '/驗收其它數量
            If reader("A_Detail") Is DBNull.Value Then ai.A_Detail = Nothing Else ai.A_Detail = reader("A_Detail").ToString '/操作類型(暫收/驗收)
            If reader("A_Action") Is DBNull.Value Then ai.A_Action = Nothing Else ai.A_Action = reader("A_Action").ToString '/暫收人編號

            If reader("A_SendDate") Is DBNull.Value Then ai.A_SendDate = Nothing Else ai.A_SendDate = CStr(reader("A_SendDate")) '記錄添加時間
            If reader("A_Remark") Is DBNull.Value Then ai.A_Remark = Nothing Else ai.A_Remark = reader("A_Remark").ToString '操作備注
            If reader("A_Check") Is DBNull.Value Then ai.A_Check = Nothing Else ai.A_Check = reader("A_Check") '審核

            If reader("A_CheckAction") Is DBNull.Value Then ai.A_CheckAction = Nothing Else ai.A_CheckAction = reader("A_CheckAction").ToString '審核人ID
            If reader("A_CheckDate") Is DBNull.Value Then ai.A_CheckDate = Nothing Else ai.A_CheckDate = CStr(reader("A_CheckDate")) '審核時間
            If reader("A_CheckRemark") Is DBNull.Value Then ai.A_CheckRemark = Nothing Else ai.A_CheckRemark = reader("A_CheckRemark").ToString '審核備注

            If reader("A_AccCheck") Is DBNull.Value Then ai.A_AccCheck = Nothing Else ai.A_AccCheck = reader("A_AccCheck") '復審核否
            If reader("A_AccCheckAction") Is DBNull.Value Then ai.A_AccCheckAction = Nothing Else ai.A_AccCheckAction = reader("A_AccCheckAction").ToString '復審核人ID
            If reader("A_AccCheckDate") Is DBNull.Value Then ai.A_AccCheckDate = Nothing Else ai.A_AccCheckDate = CStr(reader("A_AccCheckDate")) '復審核時間

            If reader("A_ACCCheckRemark") Is DBNull.Value Then ai.A_ACCCheckRemark = Nothing Else ai.A_ACCCheckRemark = reader("A_ACCCheckRemark").ToString '復審核備注
            If reader("A_AccCheckType") Is DBNull.Value Then ai.A_AccCheckType = Nothing Else ai.A_AccCheckType = reader("A_AccCheckType").ToString ' / 復審核備注類型(無效, 確認無誤, 待復)
            If reader("A_UpdateDate") Is DBNull.Value Then ai.A_UpdateDate = Nothing Else ai.A_UpdateDate = CStr(reader("A_UpdateDate")) '修改日期

            ' ''其它表中的數據
            If reader("A_ActionName") Is DBNull.Value Then ai.A_ActionName = Nothing Else ai.A_ActionName = reader("A_ActionName").ToString
            If reader("A_CheckActionName") Is DBNull.Value Then ai.A_CheckActionName = Nothing Else ai.A_CheckActionName = reader("A_CheckActionName").ToString
            If reader("A_AccCheckActionName") Is DBNull.Value Then ai.A_AccCheckActionName = Nothing Else ai.A_AccCheckActionName = reader("A_AccCheckActionName").ToString

            If reader("A_PS_Name") Is DBNull.Value Then ai.A_PS_Name = Nothing Else ai.A_PS_Name = reader("A_PS_Name").ToString
            If reader("A_SupplierName") Is DBNull.Value Then ai.A_SupplierName = Nothing Else ai.A_SupplierName = reader("A_SupplierName").ToString

            If reader("A_PS_Name_Next") Is DBNull.Value Then ai.A_PS_Name_Next = Nothing Else ai.A_PS_Name_Next = reader("A_PS_Name_Next").ToString
            If reader("PS_NO_Next") Is DBNull.Value Then ai.PS_NO_Next = Nothing Else ai.PS_NO_Next = reader("PS_NO_Next").ToString


            If reader("A_OW_Do") Is DBNull.Value Then ai.A_OW_Do = Nothing Else ai.A_OW_Do = reader("A_OW_Do").ToString

            Return ai

        End Function

        ''' <summary>
        ''' 產品工序外發加工增加
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOWPAcceptance_Add(ByVal obj As ProductionOWPAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_Add")

                'A_NO,O_NO,ASend_NO,DPT_ID,PM_M_Code,
                'PM_Type, PS_NO, S_Supplier, A_OK_Qty, A_QQ_Qty, 
                'A_TC_Qty, A_QT_Qty, A_Ver, A_Detail, A_Action, A_SendDate, A_Remark

                db.AddInParameter(dbcomm, "@OPAutoID", DbType.String, obj.OPAutoID)
                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, obj.A_AcceptanceNO)

                db.AddInParameter(dbcomm, "@A_NO", DbType.String, obj.A_NO)
                db.AddInParameter(dbcomm, "@O_NO", DbType.String, obj.O_NO)
                db.AddInParameter(dbcomm, "@ASend_NO", DbType.String, obj.ASend_NO)
                db.AddInParameter(dbcomm, "@DPT_ID", DbType.String, obj.DPT_ID)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code)

                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type)
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, obj.PS_NO)
                db.AddInParameter(dbcomm, "@S_Supplier", DbType.String, obj.S_Supplier)
                db.AddInParameter(dbcomm, "@A_OK_Qty", DbType.Int32, obj.A_OK_Qty)
                db.AddInParameter(dbcomm, "@A_QQ_Qty", DbType.Int32, obj.A_QQ_Qty)

                db.AddInParameter(dbcomm, "@A_TC_Qty", DbType.Int32, obj.A_TC_Qty)
                db.AddInParameter(dbcomm, "@A_QT_Qty", DbType.Int32, obj.A_QT_Qty)
                db.AddInParameter(dbcomm, "@A_Ver", DbType.Int32, obj.A_Ver)
                db.AddInParameter(dbcomm, "@A_Detail", DbType.String, obj.A_Detail)
                db.AddInParameter(dbcomm, "@A_Action", DbType.String, obj.A_Action)

                db.AddInParameter(dbcomm, "@A_SendDate", DbType.String, obj.A_SendDate)
                db.AddInParameter(dbcomm, "@A_Remark", DbType.String, obj.A_Remark)

                db.AddInParameter(dbcomm, "@PS_NO_Next", DbType.String, obj.PS_NO_Next)

                db.ExecuteNonQuery(dbcomm)


                ProductionOWPAcceptance_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOWPAcceptance_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 驗收單數據修改更新
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOWPAcceptance_Update(ByVal obj As ProductionOWPAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_Update")

                db.AddInParameter(dbcomm, "@OPAutoID", DbType.String, obj.OPAutoID)
                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, obj.A_AcceptanceNO)

                db.AddInParameter(dbcomm, "@A_NO", DbType.String, obj.A_NO)
                db.AddInParameter(dbcomm, "@O_NO", DbType.String, obj.O_NO)
                db.AddInParameter(dbcomm, "@ASend_NO", DbType.String, obj.ASend_NO)
                db.AddInParameter(dbcomm, "@DPT_ID", DbType.String, obj.DPT_ID)
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code)

                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type)
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, obj.PS_NO)
                db.AddInParameter(dbcomm, "@S_Supplier", DbType.String, obj.S_Supplier)
                db.AddInParameter(dbcomm, "@A_OK_Qty", DbType.Int32, obj.A_OK_Qty)
                db.AddInParameter(dbcomm, "@A_QQ_Qty", DbType.Int32, obj.A_QQ_Qty)

                db.AddInParameter(dbcomm, "@A_TC_Qty", DbType.Int32, obj.A_TC_Qty)
                db.AddInParameter(dbcomm, "@A_QT_Qty", DbType.Int32, obj.A_QT_Qty)
                db.AddInParameter(dbcomm, "@A_Ver", DbType.Int32, obj.A_Ver)
                db.AddInParameter(dbcomm, "@A_Detail", DbType.String, obj.A_Detail)
                db.AddInParameter(dbcomm, "@A_Action", DbType.String, obj.A_Action)

                db.AddInParameter(dbcomm, "@A_SendDate", DbType.String, obj.A_SendDate)
                db.AddInParameter(dbcomm, "@A_Remark", DbType.String, obj.A_Remark)
                db.AddInParameter(dbcomm, "@A_UpdateDate", DbType.String, obj.A_UpdateDate)
                db.AddInParameter(dbcomm, "@PS_NO_Next", DbType.String, obj.PS_NO_Next)


                db.ExecuteNonQuery(dbcomm)
                ProductionOWPAcceptance_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOWPAcceptance_Update = False
            End Try
        End Function
        ''' <summary>
        ''' 驗收（審核更新）
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionOWPAcceptance_UpdateCheck(ByVal obj As ProductionOWPAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_UpdateCheck")

                db.AddInParameter(dbcomm, "@A_NO", DbType.String, obj.A_NO)
                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, obj.A_AcceptanceNO)
                db.AddInParameter(dbcomm, "@A_Check", DbType.Boolean, obj.A_Check)
                db.AddInParameter(dbcomm, "@A_CheckAction", DbType.String, obj.A_CheckAction)
                db.AddInParameter(dbcomm, "@A_CheckDate", DbType.String, obj.A_CheckDate)
                db.AddInParameter(dbcomm, "@A_Detail", DbType.String, obj.A_Detail)
                db.AddInParameter(dbcomm, "@A_CheckRemark", DbType.String, obj.A_CheckRemark)

                db.ExecuteNonQuery(dbcomm)
                ProductionOWPAcceptance_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOWPAcceptance_UpdateCheck = False
            End Try
        End Function

        ''' <summary>
        ''' 外發加工工序復核
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOWPAcceptance_UpdateAccCheck(ByVal obj As ProductionOWPAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_UpdateAccCheck")

                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, obj.A_AcceptanceNO)
                db.AddInParameter(dbcomm, "@A_AccCheck", DbType.Boolean, obj.A_AccCheck)
                db.AddInParameter(dbcomm, "@A_AccCheckAction", DbType.String, obj.A_AccCheckAction)
                db.AddInParameter(dbcomm, "@A_AccCheckDate", DbType.String, obj.A_AccCheckDate)
                db.AddInParameter(dbcomm, "@A_ACCCheckRemark", DbType.String, obj.A_ACCCheckRemark)
                db.AddInParameter(dbcomm, "@A_AccCheckType", DbType.String, obj.A_AccCheckType)

                db.ExecuteNonQuery(dbcomm)
                ProductionOWPAcceptance_UpdateAccCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOWPAcceptance_UpdateAccCheck = False
            End Try
        End Function
        ''' <summary>
        ''' 獲取驗收單號 FillProductionOWPAcceptance1 一起單獨使有
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionOWPAcceptance_GetNO(ByVal Ndate As String) As ProductionOWPAcceptanceInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionOWPAcceptance1(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 獲取驗收流水號 FillProductionOWPAcceptance1 一起單獨使有
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOWPAcceptance_GetNum(ByVal Ndate As String) As ProductionOWPAcceptanceInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_GetNum")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionOWPAcceptance1(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 返回TOP1驗收單號--載入數據(因要載入的數據不多單獨定一函數)以提高速度
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionOWPAcceptance1(ByVal reader As IDataReader) As ProductionOWPAcceptanceInfo
            Dim ai1 As New ProductionOWPAcceptanceInfo
            If reader("A_NO") Is DBNull.Value Then ai1.A_NO = Nothing Else ai1.A_NO = reader("A_NO").ToString '/驗收編號
            If reader("A_AcceptanceNO") Is DBNull.Value Then ai1.A_AcceptanceNO = Nothing Else ai1.A_AcceptanceNO = reader("A_AcceptanceNO").ToString 'ai.A_AcceptanceNO  '流水號 
            Return ai1

        End Function
        ''' <summary>
        ''' 刪除記錄
        ''' </summary>
        ''' <param name="A_AcceptanceNO"></param>
        ''' <param name="A_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOWPAcceptance_Delete(ByVal A_AcceptanceNO As String, ByVal A_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_Delete")
                db.AddInParameter(dbcomm, "@A_NO", DbType.String, A_NO)
                db.AddInParameter(dbcomm, "@A_AcceptanceNO", DbType.String, A_AcceptanceNO)

                db.ExecuteNonQuery(dbcomm)
                ProductionOWPAcceptance_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOWPAcceptance_Delete = False
            End Try
        End Function


        ''' <summary>
        ''' 讀取查詢模快中“控件”下拉的內容
        ''' </summary>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="PS_NO"></param>
        ''' <param name="S_Supplier"></param>
        ''' <param name="Group_Sign"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionOWPAcceptance_GetList1(ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_NO As String, ByVal S_Supplier As String, ByVal Group_Sign As Int32) As List(Of ProductionOWPAcceptanceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_GetList1")



            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@Group_Sign", DbType.String, Group_Sign)


            Dim FeatureList As New List(Of ProductionOWPAcceptanceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionOWPAcceptance2(reader, Group_Sign))
                End While
                Return FeatureList
            End Using

        End Function
        ''' <summary>
        ''' 載入數據(因要載入的數據不多單獨定一函數)以提高速度
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <param name="Group_Sign"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionOWPAcceptance2(ByVal reader As IDataReader, ByVal Group_Sign As Int32) As ProductionOWPAcceptanceInfo
            Dim ai2 As New ProductionOWPAcceptanceInfo
            Select Case Group_Sign
                Case 1
                    If reader("PM_M_Code") Is DBNull.Value Then
                        ai2.PM_M_Code = Nothing
                    Else
                        ai2.PM_M_Code = reader("PM_M_Code").ToString '/產品名稱
                    End If

                    If reader("PM_JiYu") Is DBNull.Value Then
                        ai2.PM_JiYu = Nothing
                    Else
                        ai2.PM_JiYu = reader("PM_JiYu").ToString '/產品名稱
                    End If



                Case 2
                    If reader("PM_Type") Is DBNull.Value Then
                        ai2.PM_Type = Nothing
                    Else
                        ai2.PM_Type = reader("PM_Type").ToString 'ai.PM_Type = Nothing '/類型
                    End If
                Case 3
                    If reader("PS_NO") Is DBNull.Value Then
                        ai2.PS_NO = Nothing
                    Else
                        ai2.PS_NO = reader("PS_NO").ToString '外發工序
                    End If

                    If reader("A_PS_Name") Is DBNull.Value Then
                        ai2.A_PS_Name = Nothing
                    Else
                        ai2.A_PS_Name = reader("A_PS_Name").ToString
                    End If

                Case 4
                    If reader("S_Supplier") Is DBNull.Value Then
                        ai2.S_Supplier = Nothing
                    Else
                        ai2.S_Supplier = reader("S_Supplier").ToString '/供貨商編號
                    End If
            End Select


            Return ai2

        End Function
        ''' <summary>
        ''' 外發單 中未交數更新
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOWPAcceptance_NoSendQty(ByVal obj As ProductionOWPAcceptanceInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_NoSendQty")

                db.AddInParameter(dbcomm, "@AutoID", DbType.String, obj.OPAutoID)
                db.AddInParameter(dbcomm, "@PO_NoSendQty", DbType.String, obj.PO_NoSendQty)
                db.AddInParameter(dbcomm, "@PO_ID", DbType.String, obj.O_NO)

                db.ExecuteNonQuery(dbcomm)
                ProductionOWPAcceptance_NoSendQty = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionOWPAcceptance_NoSendQty = False
            End Try
        End Function


        ''' <summary>
        ''' 查詢ProcessSub表中的下一工序
        ''' </summary>
        ''' <param name="A_Pro_NO"></param>
        ''' <param name="A_PS_NO"></param>
        ''' <param name="A_PS_Name"></param>
        ''' <param name="A_PS_Num"></param>
        ''' <param name="A_PS_Enable"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionOWPAcceptance_Next_Process(ByVal A_Pro_NO As String, ByVal A_PS_NO As String, ByVal A_PS_Name As String, ByVal A_PS_Num As String, ByVal A_PS_Enable As String) As List(Of ProductionOWPAcceptanceInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionOWPAcceptance_Next_Process")

            db.AddInParameter(dbComm, "@Pro_NO", DbType.String, A_Pro_NO)
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, A_PS_NO)
            db.AddInParameter(dbComm, "@PS_Name", DbType.String, A_PS_Name)

            db.AddInParameter(dbComm, "@PS_Num", DbType.String, A_PS_Num)
            db.AddInParameter(dbComm, "@PS_Enable", DbType.String, A_PS_Enable)

            Dim FeatureList As New List(Of ProductionOWPAcceptanceInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionOWPAcceptance3(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionOWPAcceptance3(ByVal reader As IDataReader) As ProductionOWPAcceptanceInfo
            'On Error Resume Next

            Dim ai3 As New ProductionOWPAcceptanceInfo

            ai3.Pro_NO = reader("Pro_NO").ToString '
            ai3.PS_NO = reader("PS_NO").ToString
            ai3.A_PS_Name = reader("PS_Name").ToString

            ai3.PS_Num = reader("PS_Num")
            ai3.PS_Enable = reader("PS_Enable").ToString

            Return ai3

        End Function


    End Class

End Namespace
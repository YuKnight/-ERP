
Imports System
Imports System.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.SqlClient
Imports System.Data.Common
Imports System.Data.Sql
Imports System.Windows.Forms

Namespace LFERP.Library.Purchase.Quotation

    Public Class QuotationController

        ''' <summary>
        ''' 取得報價單記錄
        ''' </summary>
        ''' <param name="Q_QuoID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Quotation_Getlist(ByVal Q_QuoID As String, ByVal M_Code As String, ByVal M_Name As String, ByVal M_Gauge As String, ByVal Q_Type As String, ByVal Q_AddDate As String, ByVal Q_AddDateVal As String, ByVal Q_Supplier As String, ByVal Q_Check As String, ByVal Q_AccCheck As String, ByVal M_TESU As String) As List(Of QuotationInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_GetList")
            db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, Q_QuoID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@M_Name", DbType.String, M_Name)
            db.AddInParameter(dbComm, "@M_Gauge", DbType.String, M_Gauge)
            db.AddInParameter(dbComm, "@Q_Type", DbType.String, Q_Type)
            db.AddInParameter(dbComm, "@Q_AddDate", DbType.String, Q_AddDate)
            db.AddInParameter(dbComm, "@Q_AddDateVal", DbType.String, Q_AddDateVal)
            db.AddInParameter(dbComm, "@Q_Supplier", DbType.String, Q_Supplier)

            db.AddInParameter(dbComm, "@Q_Check", DbType.String, Q_Check)
            db.AddInParameter(dbComm, "@Q_AccCheck", DbType.String, Q_AccCheck)
            db.AddInParameter(dbComm, "@M_TeSu", DbType.String, M_TESU)
            Dim FeatureList As New List(Of QuotationInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillQuotation(reader))
                End While
                Return FeatureList
            End Using
        End Function

        'Public Function Quotation_GetlistTop1(ByVal Q_QuoID As String, ByVal M_Code As String, ByVal Q_AddDate As String, ByVal Q_AddDateVal As String, ByVal Q_Supplier As String, ByVal Q_Check As String, ByVal Q_AccCheck As String) As List(Of QuotationInfo)
        '    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        '    Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_GetListTop1")
        '    db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, Q_QuoID)
        '    db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
        '    db.AddInParameter(dbComm, "@Q_AddDate", DbType.String, Q_AddDate)
        '    db.AddInParameter(dbComm, "@Q_AddDateVal", DbType.String, Q_AddDateVal)
        '    db.AddInParameter(dbComm, "@Q_Supplier", DbType.String, Q_Supplier)

        '    db.AddInParameter(dbComm, "@Q_Check", DbType.String, Q_Check)
        '    db.AddInParameter(dbComm, "@Q_AccCheck", DbType.String, Q_AccCheck)

        '    Dim FeatureList As New List(Of QuotationInfo)
        '    Using reader As IDataReader = db.ExecuteReader(dbComm)
        '        While reader.Read
        '            FeatureList.Add(FillQuotation(reader))
        '        End While
        '        Return FeatureList
        '    End Using
        'End Function

        Public Function Quotation_GetlistTop10(ByVal Q_QuoID As String, ByVal M_Code As String, ByVal Q_Supplier As String, ByVal Q_Check As String, ByVal Q_AccCheck As String) As List(Of QuotationInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_GetListTop10")
            db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, Q_QuoID)
            db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)
            db.AddInParameter(dbComm, "@Q_Supplier", DbType.String, Q_Supplier)
            db.AddInParameter(dbComm, "@Q_Check", DbType.String, Q_Check)

            db.AddInParameter(dbComm, "@Q_AccCheck", DbType.String, Q_AccCheck)


            Dim FeatureList As New List(Of QuotationInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillQuotation(reader))
                End While
                Return FeatureList
            End Using
        End Function


        ''' <summary>
        ''' 取得當前數據庫中最大的報價單ID
        ''' </summary>
        ''' <param name="tt"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Quotation_GetID(ByVal tt As String) As QuotationInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_GetID")
            db.AddInParameter(dbComm, "@tt", DbType.String, tt)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillQuotation(reader)
                End While
                Return Nothing
            End Using
        End Function


        ''' <summary>
        ''' 取得一條記錄
        ''' </summary>
        ''' <param name="Q_QuoID"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Quotation_Get(ByVal Q_QuoID As String) As QuotationInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_Get")
            db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, Q_QuoID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillQuotation(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function QuotationFW_Add(ByVal objinfo As QuotationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("QuotationFW_Add")

                db.AddInParameter(dbcomm, "@CodeMain", DbType.String, objinfo.CodeMain)
                db.AddInParameter(dbcomm, "@CodeSub", DbType.String, objinfo.CodeSub)
                db.AddInParameter(dbcomm, "@TagID", DbType.String, objinfo.TagID)
                db.AddInParameter(dbcomm, "@UserID", DbType.String, objinfo.UserID)
                db.AddInParameter(dbcomm, "@Checked", DbType.String, objinfo.Checked)
                db.AddInParameter(dbcomm, "@QuotationID", DbType.String, objinfo.QuotationID)

                db.ExecuteNonQuery(dbcomm)
                QuotationFW_Add = True
            Catch ex As Exception
                QuotationFW_Add = False
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function QuotationFW_Update(ByVal objinfo As QuotationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("QuotationFW_Update")

                db.AddInParameter(dbcomm, "@CodeMain", DbType.String, objinfo.CodeMain)
                db.AddInParameter(dbcomm, "@CodeSub", DbType.String, objinfo.CodeSub)
                db.AddInParameter(dbcomm, "@TagID", DbType.String, objinfo.TagID)
                db.AddInParameter(dbcomm, "@UserID", DbType.String, objinfo.UserID)
                db.AddInParameter(dbcomm, "@QuotationID", DbType.String, objinfo.QuotationID)

                db.ExecuteNonQuery(dbcomm)
                QuotationFW_Update = True
            Catch ex As Exception
                QuotationFW_Update = False
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function QuotationFW_Checked(ByVal objinfo As QuotationInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("QuotationFW_Checked")

                db.AddInParameter(dbcomm, "@Checked", DbType.String, objinfo.Checked)
                db.AddInParameter(dbcomm, "@TagID", DbType.String, objinfo.TagID)
                db.AddInParameter(dbcomm, "@QuotationID", DbType.String, objinfo.QuotationID)

                db.ExecuteNonQuery(dbcomm)
                QuotationFW_Checked = True
            Catch ex As Exception
                QuotationFW_Checked = False
                MsgBox(ex.Message)
            End Try
        End Function


        Public Function QuotationFW_SubDelete(ByVal CodeMain As String, ByVal TagID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("QuotationFW_SubDelete")

                db.AddInParameter(dbcomm, "@CodeMain", DbType.String, CodeMain)
                db.AddInParameter(dbcomm, "@TagID", DbType.String, TagID)

                db.ExecuteNonQuery(dbcomm)
                QuotationFW_SubDelete = True
            Catch ex As Exception
                QuotationFW_SubDelete = False
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function QuotationFW_Delete(ByVal QuotationID As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("QuotationFW_Delete")
                db.AddInParameter(dbcomm, "@QuotationID", DbType.String, QuotationID)
                'db.AddInParameter(dbcomm, "@CodeMain", DbType.String, CodeMain)
                'db.AddInParameter(dbcomm, "@TagID", DbType.String, TagID)

                db.ExecuteNonQuery(dbcomm)
                QuotationFW_Delete = True
            Catch ex As Exception
                QuotationFW_Delete = False
                MsgBox(ex.Message)
            End Try
        End Function
        Public Function QuotationFW_GetID(ByVal Ndate As String) As QuotationInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("QuotationFW_GetID")
            db.AddInParameter(dbComm, "@Ndate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillQuotation(reader)
                End While
                Return Nothing
            End Using
        End Function
        Public Function QuotationFW_GetNum(ByVal QuotationID As String) As QuotationInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("QuotationFW_GetNum")
            db.AddInParameter(dbComm, "@QuotationID", DbType.String, QuotationID)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillQuotation(reader)
                End While
                Return Nothing
            End Using
        End Function

        Public Function QuotationFW_GetList(ByVal CodeMain As String, ByVal CodeSub As String, ByVal QuotationID As String, ByVal Checked As String, ByVal CodeMain_Name As String, ByVal CodeMain_Gauge As String, ByVal CodeSub_Name As String, ByVal CodeSub_Gauge As String, ByVal UserID As String) As List(Of QuotationInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("QuotationFW_GetList")

            db.AddInParameter(dbComm, "@CodeMain", DbType.String, CodeMain)
            db.AddInParameter(dbComm, "@CodeSub", DbType.String, CodeSub)
            db.AddInParameter(dbComm, "@QuotationID", DbType.String, QuotationID)
            db.AddInParameter(dbComm, "@Checked", DbType.String, Checked)
            db.AddInParameter(dbComm, "@CodeMain_Name", DbType.String, CodeMain_Name)
            db.AddInParameter(dbComm, "@CodeMain_Gauge", DbType.String, CodeMain_Gauge)
            db.AddInParameter(dbComm, "@CodeSub_Name", DbType.String, CodeSub_Name)
            db.AddInParameter(dbComm, "@CodeSub_Gauge", DbType.String, CodeSub_Gauge)
            db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
            Dim FeatureList As New List(Of QuotationInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillQuotation(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Friend Function FillQuotation(ByVal reader As IDataReader) As QuotationInfo
            On Error Resume Next
            '對應取得的數據
            Dim objInfo As New QuotationInfo

            If reader("Q_XH") Is DBNull.Value Then  '2012-5-16
                objInfo.Q_XH = 0
            Else
                objInfo.Q_XH = CSng(reader("Q_XH").ToString)
            End If

            If reader("HKDRate") Is DBNull.Value Then
                objInfo.HKDRate = 0
            Else
                objInfo.HKDRate = CDbl(reader("HKDRate").ToString)
            End If


            objInfo.AutoID = reader("AutoID").ToString
            objInfo.Q_QuoID = reader("Q_QuoID").ToString
            objInfo.M_Code = reader("M_Code").ToString
            objInfo.M_Name = reader("M_Name").ToString
            objInfo.M_Gauge = reader("M_Gauge").ToString
            objInfo.M_Unit = reader("M_Unit").ToString
            objInfo.Q_Supplier = reader("Q_Supplier").ToString
            objInfo.Q_SupplierNo = reader("Q_SupplierNo").ToString
            objInfo.Q_Type = reader("Q_Type").ToString
            If reader("Q_Price") Is DBNull.Value Then
                objInfo.Q_Price = Nothing
            Else
                objInfo.Q_Price = CDbl(reader("Q_Price").ToString)
            End If



            objInfo.Q_Currency = reader("Q_Currency").ToString

            If reader("Q_AddDate") Is DBNull.Value Then
                objInfo.Q_AddDate = Nothing
            Else
                objInfo.Q_AddDate = CStr(reader("Q_AddDate"))
            End If
            If reader("Q_EditDate") Is DBNull.Value Then
                objInfo.Q_EditDate = Nothing
            Else
                objInfo.Q_EditDate = CStr(reader("Q_EditDate"))
            End If

            objInfo.Q_Associate = reader("Q_Associate").ToString

            If reader("Q_Edition") Is DBNull.Value Then
                objInfo.Q_Edition = 0
            Else
                objInfo.Q_Edition = CSng(reader("Q_Edition").ToString)
            End If



            If reader("Q_Check") Is DBNull.Value Then
                objInfo.Q_Check = Nothing
            Else
                objInfo.Q_Check = reader("Q_Check")
            End If


            objInfo.Q_CheckAction = reader("Q_CheckAction").ToString

            If reader("Q_CheckDate") Is DBNull.Value Then
                objInfo.Q_CheckDate = Nothing
            Else
                objInfo.Q_CheckDate = CStr(reader("Q_CheckDate"))
            End If


            objInfo.Q_CheckRemark = reader("Q_CheckRemark").ToString
            objInfo.Q_CheckType = reader("Q_CheckType").ToString

            If reader("Q_AccCheck") Is DBNull.Value Then
                objInfo.Q_AccCheck = Nothing
            Else
                objInfo.Q_AccCheck = reader("Q_AccCheck")
            End If

            If reader("Q_AccCheckDate") Is DBNull.Value Then
                objInfo.Q_AccCheckDate = Nothing
            Else
                objInfo.Q_AccCheckDate = CStr(reader("Q_AccCheckDate"))
            End If

            objInfo.Q_AccCheckRemark = reader("Q_AccCheckRemark").ToString
            objInfo.Q_AccCheckType = reader("Q_AccCheckType").ToString
            objInfo.Q_AccCheckAction = reader("Q_AccCheckAction").ToString

            objInfo.Q_Action = reader("Q_Action").ToString
            objInfo.Q_Remark = reader("Q_Remark").ToString
            objInfo.Q_RetrDate = reader("Q_RetrDate").ToString
            objInfo.CO_ID = reader("CO_ID").ToString


            If reader("Q_Qty") Is DBNull.Value Then
                objInfo.Q_Qty = Nothing
            Else
                objInfo.Q_Qty = CDbl(reader("Q_Qty").ToString)
            End If


            objInfo.Q_Depict = reader("Q_Depict").ToString
            objInfo.PN_NO = reader("PN_NO").ToString

            objInfo.Q_ActionName = reader("Q_ActionName").ToString
            objInfo.Q_CheckActionName = reader("Q_CheckActionName").ToString
            objInfo.Q_AccCheckActionName = reader("Q_AccCheckActionName").ToString

            If reader("Q_SupplierName") Is DBNull.Value Then
                objInfo.Q_SupplierName = Nothing
            Else
                objInfo.Q_SupplierName = reader("Q_SupplierName").ToString
            End If


            If reader("Q_Brand") Is DBNull.Value Then
                objInfo.Q_Brand = Nothing
            Else
                objInfo.Q_Brand = reader("Q_Brand").ToString
            End If

            If reader("Q_Origine") Is DBNull.Value Then
                objInfo.Q_Origine = Nothing
            Else
                objInfo.Q_Origine = reader("Q_Origine").ToString
            End If

            If reader("Q_StandardPack") Is DBNull.Value Then
                objInfo.Q_StandardPack = Nothing
            Else
                objInfo.Q_StandardPack = reader("Q_StandardPack").ToString
            End If


            If reader("Q_MOQ") Is DBNull.Value Then
                objInfo.Q_MOQ = Nothing
            Else
                objInfo.Q_MOQ = reader("Q_MOQ").ToString
            End If


            If reader("Q_ProductionCycle") Is DBNull.Value Then
                objInfo.Q_ProductionCycle = Nothing
            Else
                objInfo.Q_ProductionCycle = reader("Q_ProductionCycle").ToString
            End If

            If reader("Q_DeliveredCycle") Is DBNull.Value Then
                objInfo.Q_DeliveredCycle = Nothing
            Else
                objInfo.Q_DeliveredCycle = reader("Q_DeliveredCycle").ToString
            End If


            If reader("Q_DeliveredAddress") Is DBNull.Value Then
                objInfo.Q_DeliveredAddress = Nothing
            Else
                objInfo.Q_DeliveredAddress = reader("Q_DeliveredAddress").ToString
            End If

            If reader("Q_ExchangeRate") Is DBNull.Value Then
                objInfo.Q_ExchangeRate = Nothing
            Else
                objInfo.Q_ExchangeRate = reader("Q_ExchangeRate").ToString
            End If


            If reader("Q_Validity") Is DBNull.Value Then
                objInfo.Q_Validity = Nothing
            Else
                objInfo.Q_Validity = reader("Q_Validity").ToString
            End If


            If reader("Q_MoldExpense") Is DBNull.Value Then
                objInfo.Q_MoldExpense = Nothing
            Else
                objInfo.Q_MoldExpense = reader("Q_MoldExpense").ToString
            End If

            If reader("Q_PriceType") Is DBNull.Value Then
                objInfo.Q_PriceType = Nothing
            Else
                objInfo.Q_PriceType = reader("Q_PriceType").ToString
            End If
            If reader("Q_ToForm") Is DBNull.Value Then
                objInfo.Q_ToForm = Nothing
            Else
                objInfo.Q_ToForm = reader("Q_ToForm").ToString
            End If
            If reader("Q_Tarriff") Is DBNull.Value Then
                objInfo.Q_Tarriff = Nothing
            Else
                objInfo.Q_Tarriff = CSng(reader("Q_Tarriff").ToString)
            End If

            '--------------------------------------------------------------------------------------------------------
            objInfo.CodeMain = reader("CodeMain").ToString
         
            objInfo.CodeMain_Gauge = reader("CodeMain_Gauge").ToString

            objInfo.CodeMain_Name = reader("CodeMain_Name").ToString
            objInfo.CodeMain_Unit = reader("CodeMain_Unit").ToString
            objInfo.CodeSub = reader("CodeSub").ToString
            If reader("CodeSub_Gauge") Is DBNull.Value Then
                objInfo.CodeSub_Gauge = Nothing
            Else
                objInfo.CodeSub_Gauge = reader("CodeSub_Gauge").ToString
            End If

            objInfo.CodeSub_Name = reader("CodeSub_Name").ToString
            objInfo.CodeSub_Unit = reader("CodeSub_Unit").ToString
            objInfo.TagID = reader("TagID").ToString

            objInfo.UserID = reader("UserID").ToString
            objInfo.Code_UserName = reader("Code_UserName").ToString
            objInfo.QuotationID = reader("QuotationID").ToString
            If reader("Checked") Is DBNull.Value Then
                objInfo.Checked = False
            Else
                objInfo.Checked = reader("Checked")
            End If

            objInfo.Type3Name = reader("Type3Name").ToString

            If reader("Q_Total") Is DBNull.Value Then
                objInfo.Q_Total = 0
            Else
                objInfo.Q_Total = CSng(reader("Q_Total").ToString)
            End If

            If reader("Q_SubTotal") Is DBNull.Value Then
                objInfo.Q_SubTotal = 0
            Else
                objInfo.Q_SubTotal = CSng(reader("Q_SubTotal").ToString)
            End If

            Return objInfo
        End Function


        ''' <summary>
        '''報價單新增 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Quotation_Add(ByVal objFile1 As QuotationInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_Add")

                db.AddInParameter(dbComm, "@Q_XH", DbType.Int32, objFile1.Q_XH) '2012-5-16

                db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, objFile1.Q_QuoID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                db.AddInParameter(dbComm, "@Q_Supplier", DbType.String, objFile1.Q_Supplier)
                db.AddInParameter(dbComm, "@Q_SupplierNo", DbType.String, objFile1.Q_SupplierNo)
                db.AddInParameter(dbComm, "@Q_Type", DbType.String, objFile1.Q_Type)
                db.AddInParameter(dbComm, "@Q_Price", DbType.Double, objFile1.Q_Price)
                db.AddInParameter(dbComm, "@Q_Currency", DbType.String, objFile1.Q_Currency)

                db.AddInParameter(dbComm, "@Q_Brand", DbType.String, objFile1.Q_Brand)
                db.AddInParameter(dbComm, "@Q_Origine", DbType.String, objFile1.Q_Origine)
                db.AddInParameter(dbComm, "@Q_StandardPack", DbType.String, objFile1.Q_StandardPack)
                db.AddInParameter(dbComm, "@Q_MOQ", DbType.String, objFile1.Q_MOQ)
                db.AddInParameter(dbComm, "@Q_ProductionCycle", DbType.String, objFile1.Q_ProductionCycle)
                db.AddInParameter(dbComm, "@Q_DeliveredCycle", DbType.String, objFile1.Q_DeliveredCycle)
                db.AddInParameter(dbComm, "@Q_DeliveredAddress", DbType.String, objFile1.Q_DeliveredAddress)
                db.AddInParameter(dbComm, "@Q_ExchangeRate", DbType.String, objFile1.Q_ExchangeRate)
                db.AddInParameter(dbComm, "@Q_Validity", DbType.String, objFile1.Q_Validity)
                db.AddInParameter(dbComm, "@Q_MoldExpense", DbType.String, objFile1.Q_MoldExpense)
                db.AddInParameter(dbComm, "@Q_PriceType", DbType.String, objFile1.Q_PriceType)
                db.AddInParameter(dbComm, "@Q_ToForm", DbType.String, objFile1.Q_ToForm)
                db.AddInParameter(dbComm, "@Q_Tarriff", DbType.String, objFile1.Q_Tarriff)

                If objFile1.Q_AddDate = Nothing Then
                    db.AddInParameter(dbComm, "@Q_AddDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Q_AddDate", DbType.Date, objFile1.Q_AddDate)
                End If

                If objFile1.Q_EditDate = Nothing Then
                    db.AddInParameter(dbComm, "@Q_EditDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Q_EditDate", DbType.Date, objFile1.Q_EditDate)
                End If

                db.AddInParameter(dbComm, "@Q_Associate", DbType.String, objFile1.Q_Associate)
                db.AddInParameter(dbComm, "@Q_Edition", DbType.Int16, objFile1.Q_Edition)
                db.AddInParameter(dbComm, "@Q_Check", DbType.Boolean, objFile1.Q_Check)
                db.AddInParameter(dbComm, "@Q_CheckAction", DbType.String, objFile1.Q_CheckAction)

                If objFile1.Q_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@Q_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Q_CheckDate", DbType.Date, objFile1.Q_CheckDate)
                End If

                db.AddInParameter(dbComm, "@Q_CheckRemark", DbType.String, objFile1.Q_CheckRemark)
                db.AddInParameter(dbComm, "@Q_CheckType", DbType.String, objFile1.Q_CheckType)
                db.AddInParameter(dbComm, "@Q_AccCheck", DbType.Boolean, objFile1.Q_AccCheck)

                If objFile1.Q_AccCheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@Q_AccCheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Q_AccCheckDate", DbType.Date, objFile1.Q_AccCheckDate)
                End If


                db.AddInParameter(dbComm, "@Q_AccCheckRemark", DbType.String, objFile1.Q_AccCheckRemark)
                db.AddInParameter(dbComm, "@Q_AccCheckType", DbType.String, objFile1.Q_AccCheckType)
                db.AddInParameter(dbComm, "@Q_AccCheckAction", DbType.String, objFile1.Q_AccCheckAction)
                db.AddInParameter(dbComm, "@Q_Action", DbType.String, objFile1.Q_Action)
                db.AddInParameter(dbComm, "@Q_Remark", DbType.String, objFile1.Q_Remark)
                db.AddInParameter(dbComm, "@Q_RetrDate", DbType.String, objFile1.Q_RetrDate)
                db.AddInParameter(dbComm, "@CO_ID", DbType.String, objFile1.CO_ID)
                db.AddInParameter(dbComm, "@Q_Qty", DbType.Double, objFile1.Q_Qty)
                db.AddInParameter(dbComm, "@Q_Depict", DbType.String, objFile1.Q_Depict)
                db.AddInParameter(dbComm, "@PN_NO", DbType.String, objFile1.PN_NO)
                db.ExecuteNonQuery(dbComm)
                Quotation_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Quotation_Add = False
            End Try

        End Function


        ''' <summary>
        '''報價單修改 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Quotation_Update(ByVal objFile1 As QuotationInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_Update")

                db.AddInParameter(dbComm, "@Q_XH", DbType.Int32, objFile1.Q_XH) '2012-5-16

                db.AddInParameter(dbComm, "@AutoID", DbType.String, objFile1.AutoID)
                db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, objFile1.Q_QuoID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                'db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
                'db.AddInParameter(dbComm, "@M_Gauge", DbType.String, objFile1.M_Gauge)
                'db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
                db.AddInParameter(dbComm, "@Q_Supplier", DbType.String, objFile1.Q_Supplier)
                db.AddInParameter(dbComm, "@Q_SupplierNo", DbType.String, objFile1.Q_SupplierNo)
                db.AddInParameter(dbComm, "@Q_Type", DbType.String, objFile1.Q_Type)
                db.AddInParameter(dbComm, "@Q_Price", DbType.Double, objFile1.Q_Price)
                db.AddInParameter(dbComm, "@Q_Currency", DbType.String, objFile1.Q_Currency)

                If objFile1.Q_EditDate = Nothing Then
                    db.AddInParameter(dbComm, "@Q_EditDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Q_EditDate", DbType.Date, objFile1.Q_EditDate)
                End If

                db.AddInParameter(dbComm, "@Q_Associate", DbType.String, objFile1.Q_Associate)
                db.AddInParameter(dbComm, "@Q_Edition", DbType.Int16, objFile1.Q_Edition)
                db.AddInParameter(dbComm, "@Q_Action", DbType.String, objFile1.Q_Action)
                db.AddInParameter(dbComm, "@Q_Remark", DbType.String, objFile1.Q_Remark)
                db.AddInParameter(dbComm, "@Q_RetrDate", DbType.String, objFile1.Q_RetrDate)
                db.AddInParameter(dbComm, "@CO_ID", DbType.String, objFile1.CO_ID)
                db.AddInParameter(dbComm, "@Q_Qty", DbType.Double, objFile1.Q_Qty)
                db.AddInParameter(dbComm, "@Q_Depict", DbType.String, objFile1.Q_Depict)
                db.AddInParameter(dbComm, "@PN_NO", DbType.String, objFile1.PN_NO)


                db.AddInParameter(dbComm, "@Q_Brand", DbType.String, objFile1.Q_Brand)
                db.AddInParameter(dbComm, "@Q_Origine", DbType.String, objFile1.Q_Origine)
                db.AddInParameter(dbComm, "@Q_StandardPack", DbType.String, objFile1.Q_StandardPack)
                db.AddInParameter(dbComm, "@Q_MOQ", DbType.String, objFile1.Q_MOQ)
                db.AddInParameter(dbComm, "@Q_ProductionCycle", DbType.String, objFile1.Q_ProductionCycle)
                db.AddInParameter(dbComm, "@Q_DeliveredCycle", DbType.String, objFile1.Q_DeliveredCycle)
                db.AddInParameter(dbComm, "@Q_DeliveredAddress", DbType.String, objFile1.Q_DeliveredAddress)
                db.AddInParameter(dbComm, "@Q_ExchangeRate", DbType.String, objFile1.Q_ExchangeRate)
                db.AddInParameter(dbComm, "@Q_Validity", DbType.String, objFile1.Q_Validity)
                db.AddInParameter(dbComm, "@Q_MoldExpense", DbType.String, objFile1.Q_MoldExpense)
                db.AddInParameter(dbComm, "@Q_PriceType", DbType.String, objFile1.Q_PriceType)
                db.AddInParameter(dbComm, "@Q_ToForm", DbType.String, objFile1.Q_ToForm)
                db.AddInParameter(dbComm, "@Q_Tarriff", DbType.String, objFile1.Q_Tarriff)

                db.ExecuteNonQuery(dbComm)
                Quotation_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Quotation_Update = False
            End Try

        End Function


        ''' <summary>
        '''報價單審核修改 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Quotation_UpdateCheck(ByVal objFile1 As QuotationInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_UpdateCheck")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, objFile1.AutoID)
                db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, objFile1.Q_QuoID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
                db.AddInParameter(dbComm, "@Q_Check", DbType.Boolean, objFile1.Q_Check)
                db.AddInParameter(dbComm, "@Q_CheckAction", DbType.String, objFile1.Q_CheckAction)
                If objFile1.Q_CheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@Q_CheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Q_CheckDate", DbType.Date, objFile1.Q_CheckDate)
                End If

                db.AddInParameter(dbComm, "@Q_CheckRemark", DbType.String, objFile1.Q_CheckRemark)
                db.AddInParameter(dbComm, "@Q_CheckType", DbType.String, objFile1.Q_CheckType)


                'db.AddInParameter(dbComm, "@Q_AccCheck", DbType.Boolean, objFile1.Q_AccCheck)
                'If objFile1.Q_AccCheckDate = Nothing Then
                '    db.AddInParameter(dbComm, "@Q_AccCheckDate", DbType.Date, DBNull.Value)
                'Else
                '    db.AddInParameter(dbComm, "@Q_AccCheckDate", DbType.Date, objFile1.Q_AccCheckDate)
                'End If
                'db.AddInParameter(dbComm, "@Q_AccCheckRemark", DbType.String, objFile1.Q_AccCheckRemark)
                'db.AddInParameter(dbComm, "@Q_AccCheckType", DbType.String, objFile1.Q_AccCheckType)
                'db.AddInParameter(dbComm, "@Q_AccCheckAction", DbType.String, objFile1.Q_AccCheckAction)

                db.ExecuteNonQuery(dbComm)
                Quotation_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Quotation_UpdateCheck = False
            End Try

        End Function


        ''' <summary>
        '''報價單會計審核修改 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Quotation_UpdateAccCheck(ByVal objFile1 As QuotationInfo) As Boolean

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_UpdateAccCheck")
                db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, objFile1.Q_QuoID)

                db.AddInParameter(dbComm, "@Q_Edition", DbType.Int16, objFile1.Q_Edition)
                db.AddInParameter(dbComm, "@Q_AccCheck", DbType.Boolean, objFile1.Q_AccCheck)
                If objFile1.Q_AccCheckDate = Nothing Then
                    db.AddInParameter(dbComm, "@Q_AccCheckDate", DbType.Date, DBNull.Value)
                Else
                    db.AddInParameter(dbComm, "@Q_AccCheckDate", DbType.Date, objFile1.Q_AccCheckDate)
                End If
                db.AddInParameter(dbComm, "@Q_AccCheckRemark", DbType.String, objFile1.Q_AccCheckRemark)
                db.AddInParameter(dbComm, "@Q_AccCheckType", DbType.String, objFile1.Q_AccCheckType)
                db.AddInParameter(dbComm, "@Q_AccCheckAction", DbType.String, objFile1.Q_AccCheckAction)

                db.ExecuteNonQuery(dbComm)
                Quotation_UpdateAccCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Quotation_UpdateAccCheck = False
            End Try

        End Function


        ''' <summary>
        '''  報價單刪除
        ''' </summary>
        ''' <param name="Q_QuoID"></param>
        ''' <param name="M_Code"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Quotation_Delete(ByVal AutoID As String, ByVal Q_QuoID As String, ByVal M_Code As String) As Boolean


            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Quotation_Delete")
                db.AddInParameter(dbComm, "@AutoID", DbType.String, AutoID)
                db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, Q_QuoID)
                db.AddInParameter(dbComm, "@M_Code", DbType.String, M_Code)

                db.ExecuteNonQuery(dbComm)
                Quotation_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Quotation_Delete = False

            End Try
        End Function

    End Class
End Namespace

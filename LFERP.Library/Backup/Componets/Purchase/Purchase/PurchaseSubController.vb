'Imports System
'Imports System.Data
'Imports Microsoft.Practices.EnterpriseLibrary.Common
'Imports Microsoft.Practices.EnterpriseLibrary.Data
'Imports System.Data.SqlClient
'Imports System.Data.Common
'Imports System.Data.Sql
'Imports System.Windows.Forms

'Namespace LFERP.Library.Purchase.Purchase
'    Public Class PurchaseSubController

'        'PS_NO As String
'        'PM_NO As String
'        'Q_QuoID As String
'        'M_Code As String
'        'S_SupplierNo As String
'        'OS_BatchID As String
'        'M_Unit As String
'        'M_Name As String
'        'M_Gauge As String
'        'PN_NO As String
'        'DPT_ID As String
'        'U_ID As String
'        'PS_NeedPurchaseUse As String
'        'C_ID As String
'        'PS_QTY As Long
'        'PS_NoSendQty As Long
'        'PS_Price As Single
'        'PS_SendDate As Date
'        'PS_Depict As String
'        'PS_Detail As String
'        'PS_Tarriff As Single
'        'PS_TffCost As Single
'        'PS_AmountBf As Single
'        'PS_AmountAf As Single




'        'Public Function PurchaseSub_GetList(ByVal PM_NO As String) As List(Of PurchaseSubInfo)
'        '    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
'        '    Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_GetList")
'        '    db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)

'        '    Dim FeatureList As New List(Of PurchaseSubInfo)
'        '    Using reader As IDataReader = db.ExecuteReader(dbComm)
'        '        While reader.Read
'        '            FeatureList.Add(FillPurchaseSub(reader))
'        '        End While
'        '        Return FeatureList
'        '    End Using
'        'End Function


'        'Friend Function FillPurchaseSub(ByVal reader As IDataReader) As PurchaseSubInfo
'        '    '對應取得的數據
'        '    Dim objInfo As New PurchaseSubInfo
'        '    objInfo.PS_NO = reader("PS_NO").ToString
'        '    objInfo.PM_NO = reader("PM_NO").ToString
'        '    objInfo.Q_QuoID = reader("Q_QuoID").ToString
'        '    objInfo.M_Code = reader("M_Code").ToString
'        '    objInfo.S_SupplierNo = reader("S_SupplierNo").ToString

'        '    objInfo.OS_BatchID = reader("OS_BatchID").ToString
'        '    objInfo.M_Unit = reader("M_Unit").ToString
'        '    objInfo.M_Name = reader("M_Name").ToString
'        '    objInfo.M_Gauge = reader("M_Gauge").ToString
'        '    objInfo.PN_NO = reader("PN_NO").ToString


'        '    objInfo.DPT_ID = reader("DPT_ID").ToString
'        '    objInfo.U_ID = reader("U_ID").ToString
'        '    objInfo.PS_NeedPurchaseUse = reader("PS_NeedPurchaseUse").ToString

'        '    objInfo.C_ID = reader("C_ID").ToString
'        '    If reader("PS_QTY") Is DBNull.Value Then
'        '        objInfo.PS_QTY = Nothing
'        '    Else
'        '        objInfo.PS_QTY = CLng(reader("PS_QTY").ToString)
'        '    End If
'        '    If reader("PS_NoSendQty") Is DBNull.Value Then
'        '        objInfo.PS_NoSendQty = Nothing
'        '    Else
'        '        objInfo.PS_NoSendQty = CLng(reader("PS_NoSendQty").ToString)
'        '    End If
'        '    If reader("PS_Price") Is DBNull.Value Then
'        '        objInfo.PS_Price = Nothing
'        '    Else
'        '        objInfo.PS_Price = CSng(reader("PS_Price").ToString)
'        '    End If
'        '    If reader("PS_SendDate") Is DBNull.Value Then
'        '        objInfo.PS_SendDate = Nothing
'        '    Else
'        '        objInfo.PS_SendDate = CStr(reader("PS_SendDate"))
'        '    End If

'        '    objInfo.PS_Depict = reader("PS_Depict").ToString
'        '    objInfo.PS_Detail = reader("PS_Detail").ToString

'        '    If reader("PS_Tarriff") Is DBNull.Value Then
'        '        objInfo.PS_Tarriff = Nothing
'        '    Else
'        '        objInfo.PS_Tarriff = CSng(reader("PS_Tarriff").ToString)
'        '    End If

'        '    If reader("PS_TffCost") Is DBNull.Value Then
'        '        objInfo.PS_TffCost = Nothing
'        '    Else
'        '        objInfo.PS_TffCost = CSng(reader("PS_TffCost").ToString)
'        '    End If

'        '    If reader("PS_AmountBf") Is DBNull.Value Then
'        '        objInfo.PS_AmountBf = Nothing
'        '    Else
'        '        objInfo.PS_AmountBf = CSng(reader("PS_AmountBf").ToString)
'        '    End If

'        '    If reader("PS_AmountAf") Is DBNull.Value Then
'        '        objInfo.PS_AmountAf = Nothing
'        '    Else
'        '        objInfo.PS_AmountAf = CSng(reader("PS_AmountAf").ToString)
'        '    End If


'        '    Return objInfo

'        'End Function



'        '''' <summary>
'        ''''新增 
'        '''' </summary>
'        '''' <param name="objFile1"></param>
'        '''' <returns></returns>
'        '''' <remarks></remarks>
'        'Public Function PurchaseSub_Add(ByVal objFile1 As PurchaseSubInfo) As Boolean

'        '    Try
'        '        Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
'        '        Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_Add")

'        '        db.AddInParameter(dbComm, "@PS_NO", DbType.String, objFile1.PS_NO)
'        '        db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
'        '        db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, objFile1.Q_QuoID)
'        '        db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
'        '        db.AddInParameter(dbComm, "@S_SupplierNo", DbType.String, objFile1.S_SupplierNo)
'        '        db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
'        '        db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
'        '        db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
'        '        db.AddInParameter(dbComm, "@M_Gauge", DbType.Int16, objFile1.M_Gauge)

'        '        db.AddInParameter(dbComm, "@PN_NO", DbType.String, objFile1.PN_NO)
'        '        db.AddInParameter(dbComm, "@DPT_ID", DbType.Boolean, objFile1.DPT_ID)
'        '        db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
'        '        db.AddInParameter(dbComm, "@PS_NeedPurchaseUse", DbType.String, objFile1.PS_NeedPurchaseUse)
'        '        db.AddInParameter(dbComm, "@PS_QTY", DbType.Int32, objFile1.PS_QTY)

'        '        db.AddInParameter(dbComm, "@PS_NoSendQty", DbType.Int32, objFile1.PS_NoSendQty)
'        '        db.AddInParameter(dbComm, "@PS_Price", DbType.Single, objFile1.PS_Price)
'        '        db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
'        '        db.AddInParameter(dbComm, "@PS_NeedPurchaseUse", DbType.String, objFile1.PS_NeedPurchaseUse)
'        '        db.AddInParameter(dbComm, "@PS_QTY", DbType.Int32, objFile1.PS_QTY)
'        '        If objFile1.PS_SendDate = Nothing Then
'        '            db.AddInParameter(dbComm, "@PS_SendDate", DbType.Date, DBNull.Value)
'        '        Else
'        '            db.AddInParameter(dbComm, "@PS_SendDate", DbType.Date, objFile1.PS_SendDate)
'        '        End If

'        '        db.AddInParameter(dbComm, "@PS_Depict", DbType.String, objFile1.PS_Depict)
'        '        db.AddInParameter(dbComm, "@PS_Detail", DbType.String, objFile1.PS_Detail)

'        '        db.AddInParameter(dbComm, "@PS_Tarriff", DbType.Single, objFile1.PS_Tarriff)
'        '        db.AddInParameter(dbComm, "@PS_TffCost", DbType.Single, objFile1.PS_TffCost)
'        '        db.AddInParameter(dbComm, "@PS_AmountBf", DbType.Single, objFile1.PS_AmountBf)
'        '        db.AddInParameter(dbComm, "@PS_AmountAf", DbType.Single, objFile1.PS_AmountAf)
'        '        db.ExecuteNonQuery(dbComm)
'        '        PurchaseSub_Add = True

'        '    Catch ex As Exception
'        '        MsgBox(ex.Message)
'        '        PurchaseSub_Add = False
'        '    End Try

'        'End Function
'        '''' <summary>
'        ''''修改 
'        '''' </summary>
'        '''' <param name="objFile1"></param>
'        '''' <returns></returns>
'        '''' <remarks></remarks>
'        'Public Function PurchaseSub_Update(ByVal objFile1 As PurchaseSubInfo) As Boolean

'        '    Try
'        '        Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
'        '        Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_Update")

'        '        db.AddInParameter(dbComm, "@PS_NO", DbType.String, objFile1.PS_NO)
'        '        db.AddInParameter(dbComm, "@PM_NO", DbType.String, objFile1.PM_NO)
'        '        db.AddInParameter(dbComm, "@Q_QuoID", DbType.String, objFile1.Q_QuoID)
'        '        db.AddInParameter(dbComm, "@M_Code", DbType.String, objFile1.M_Code)
'        '        db.AddInParameter(dbComm, "@S_SupplierNo", DbType.String, objFile1.S_SupplierNo)
'        '        db.AddInParameter(dbComm, "@OS_BatchID", DbType.String, objFile1.OS_BatchID)
'        '        db.AddInParameter(dbComm, "@M_Unit", DbType.String, objFile1.M_Unit)
'        '        db.AddInParameter(dbComm, "@M_Name", DbType.String, objFile1.M_Name)
'        '        db.AddInParameter(dbComm, "@M_Gauge", DbType.Int16, objFile1.M_Gauge)

'        '        db.AddInParameter(dbComm, "@PN_NO", DbType.String, objFile1.PN_NO)
'        '        db.AddInParameter(dbComm, "@DPT_ID", DbType.Boolean, objFile1.DPT_ID)
'        '        db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
'        '        db.AddInParameter(dbComm, "@PS_NeedPurchaseUse", DbType.String, objFile1.PS_NeedPurchaseUse)
'        '        db.AddInParameter(dbComm, "@PS_QTY", DbType.Int32, objFile1.PS_QTY)

'        '        db.AddInParameter(dbComm, "@PS_NoSendQty", DbType.Int32, objFile1.PS_NoSendQty)
'        '        db.AddInParameter(dbComm, "@PS_Price", DbType.Single, objFile1.PS_Price)
'        '        db.AddInParameter(dbComm, "@U_ID", DbType.String, objFile1.U_ID)
'        '        db.AddInParameter(dbComm, "@PS_NeedPurchaseUse", DbType.String, objFile1.PS_NeedPurchaseUse)
'        '        db.AddInParameter(dbComm, "@PS_QTY", DbType.Int32, objFile1.PS_QTY)
'        '        If objFile1.PS_SendDate = Nothing Then
'        '            db.AddInParameter(dbComm, "@PS_SendDate", DbType.Date, DBNull.Value)
'        '        Else
'        '            db.AddInParameter(dbComm, "@PS_SendDate", DbType.Date, objFile1.PS_SendDate)
'        '        End If

'        '        db.AddInParameter(dbComm, "@PS_Depict", DbType.String, objFile1.PS_Depict)
'        '        db.AddInParameter(dbComm, "@PS_Detail", DbType.String, objFile1.PS_Detail)

'        '        db.AddInParameter(dbComm, "@PS_Tarriff", DbType.Single, objFile1.PS_Tarriff)
'        '        db.AddInParameter(dbComm, "@PS_TffCost", DbType.Single, objFile1.PS_TffCost)
'        '        db.AddInParameter(dbComm, "@PS_AmountBf", DbType.Single, objFile1.PS_AmountBf)
'        '        db.AddInParameter(dbComm, "@PS_AmountAf", DbType.Single, objFile1.PS_AmountAf)
'        '        db.ExecuteNonQuery(dbComm)
'        '        PurchaseSub_Update = True

'        '    Catch ex As Exception
'        '        MsgBox(ex.Message)
'        '        PurchaseSub_Update = False
'        '    End Try

'        'End Function
'        '''' <summary>
'        '''' 刪除
'        '''' </summary>
'        '''' <param name="PM_NO"></param>
'        '''' <returns></returns>
'        '''' <remarks></remarks>
'        'Public Function PurchaseSub_Delete(ByVal PM_NO As String) As Boolean
'        '    Try
'        '        Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
'        '        Dim dbComm As DbCommand = db.GetStoredProcCommand("PurchaseSub_Delete")
'        '        db.AddInParameter(dbComm, "@PM_NO", DbType.String, PM_NO)
'        '        db.ExecuteNonQuery(dbComm)
'        '        PurchaseSub_Delete = True
'        '    Catch ex As Exception
'        '        MsgBox(ex.Message)
'        '        PurchaseSub_Delete = False
'        '    End Try
'        'End Function
'    End Class
'End Namespace


'Imports System
'Imports System.Data
'Imports Microsoft.Practices.EnterpriseLibrary.Common
'Imports Microsoft.Practices.EnterpriseLibrary.Data
'Imports System.Data.SqlClient
'Imports System.Data.Common
'Imports System.Data.Sql

Namespace LFERP.Library.ProductionShipment

    Public Class ProductionShipmentControl

        Public Function ProductionShipment_GetList(ByVal PS_NO As String, ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_WareID As String, ByVal PS_Type As String, ByVal PS_Date As String, ByVal PS_CheckDate As String, ByVal PS_Check As String, ByVal PS_DateVal As String, ByVal PS_Action As String, ByVal PS_M_Name As String) As List(Of ProductionShipmentInfo)

            ''@PS_NO nvarchar(20)=null,--出貨單號
            ''@PM_M_Code nvarchar(20)=null,--產品編號 
            ''@PM_Type nvarchar(20)=null,--產品類型 
            ''@PS_WareID nvarchar(20)=null, --出貨倉庫

            ''@PS_Type nvarchar(50)=null,--出貨類型
            ''@PS_Date smalldatetime=null,--出貨日期
            ''@PS_CheckDate smalldatetime=null,--審核日期
            ''@PS_Check nvarchar(50)=null--審核（是否確認出貨）



            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionShipment_GetList")

            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code)
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type)
            db.AddInParameter(dbComm, "@PS_WareID", DbType.String, PS_WareID)

            db.AddInParameter(dbComm, "@PS_Type", DbType.String, PS_Type)
            db.AddInParameter(dbComm, "@PS_Date", DbType.String, PS_Date)
            db.AddInParameter(dbComm, "@PS_CheckDate", DbType.String, PS_CheckDate)
            db.AddInParameter(dbComm, "@PS_Check", DbType.String, PS_Check)

            db.AddInParameter(dbComm, "@PS_DateVal", DbType.String, PS_DateVal)
            db.AddInParameter(dbComm, "@PS_Action", DbType.String, PS_Action)

            db.AddInParameter(dbComm, "@PS_M_Name", DbType.String, PS_M_Name)

            Dim FeatureList As New List(Of ProductionShipmentInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionShipment(reader))
                End While
                Return FeatureList
            End Using

        End Function


        Public Function FillProductionShipment(ByVal reader As IDataReader) As ProductionShipmentInfo

            On Error Resume Next
            Dim p As New ProductionShipmentInfo

            p.PS_NO = reader("PS_NO").ToString
            p.PM_M_Code = reader("PM_M_Code").ToString
            p.PM_Type = reader("PM_Type").ToString
            p.M_Code = reader("M_Code").ToString
            p.PS_WareID = reader("PS_WareID").ToString

            If reader("PS_Qty") Is DBNull.Value Then
                p.PS_Qty = 0
            Else
                p.PS_Qty = CInt(reader("PS_Qty"))
            End If

            p.PS_Type = reader("PS_Type").ToString
            p.PS_Action = reader("PS_Action").ToString

            If reader("PS_Date") Is DBNull.Value Then
                p.PS_Date = Nothing
            Else
                p.PS_Date = CStr(reader("PS_Date"))
            End If

            p.PS_Remark = reader("PS_Remark").ToString

            If reader("PS_Check") Is DBNull.Value Then
                p.PS_Check = Nothing
            Else
                p.PS_Check = reader("PS_Check")
            End If


            'p.PS_Check = reader("PS_Check").ToString
            p.PS_CheckAction = reader("PS_CheckAction").ToString

            If reader("PS_CheckDate") Is DBNull.Value Then
                p.PS_CheckDate = Nothing
            Else
                p.PS_CheckDate = CStr(reader("PS_CheckDate"))
            End If

            p.PS_CheckRemark = reader("PS_CheckRemark").ToString

            ' 在與其它表相連接的字段
            p.PS_OutName = reader("PS_OutName").ToString
            p.PS_M_Unit = reader("PS_M_Unit").ToString
            p.PS_CheckAction_N = reader("PS_CheckAction_N").ToString
            p.PS_Action_N = reader("PS_Action_N").ToString
            p.PS_M_Gauge = reader("PS_M_Gauge").ToString
            p.PS_M_Name = reader("PS_M_Name").ToString

            p.PS_NO_Sub = reader("PS_NO_Sub").ToString
            p.PS_Detail = reader("PS_Detail").ToString
            p.PS_SubRemark = reader("PS_SubRemark").ToString


            Return p

        End Function




        Public Function ProductionShipment_Add(ByVal objinfo As ProductionShipmentInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionShipment_Add")

                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PS_WareID", DbType.String, objinfo.PS_WareID)
                db.AddInParameter(dbComm, "@PS_Qty", DbType.Int32, objinfo.PS_Qty)

                db.AddInParameter(dbComm, "@PS_Type ", DbType.String, objinfo.PS_Type)
                db.AddInParameter(dbComm, "@PS_Action", DbType.String, objinfo.PS_Action)
                db.AddInParameter(dbComm, "@PS_Date", DbType.String, objinfo.PS_Date)

                db.AddInParameter(dbComm, "@PS_Remark ", DbType.String, objinfo.PS_Remark)
                db.AddInParameter(dbComm, "@PS_Check", DbType.String, objinfo.PS_Check)
                db.AddInParameter(dbComm, "@PS_CheckAction", DbType.String, objinfo.PS_CheckAction)

                db.AddInParameter(dbComm, "@PS_CheckDate", DbType.String, objinfo.PS_CheckDate)
                db.AddInParameter(dbComm, "@PS_CheckRemark", DbType.String, objinfo.PS_CheckRemark)

                db.AddInParameter(dbComm, "@PS_NO_Sub", DbType.String, objinfo.PS_NO_Sub)
                db.AddInParameter(dbComm, "@PS_Detail", DbType.String, objinfo.PS_Detail)
                db.AddInParameter(dbComm, "@PS_SubRemark", DbType.String, objinfo.PS_SubRemark)


                ''MsgBox(objinfo.PS_CheckDate)


                db.ExecuteNonQuery(dbComm)

                ProductionShipment_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionShipment_Add = False
            End Try
        End Function

        Public Function ProductionShipment_GetNO(ByVal NDate As String) As ProductionShipmentInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionShipment_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionShipment(reader)
                End While
                Return Nothing
            End Using

        End Function

        Public Function ProductionShipment_GetSubNO(ByVal NDate As String) As ProductionShipmentInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionShipment_GetSubNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, NDate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionShipment(reader)
                End While
                Return Nothing
            End Using
        End Function


        Public Function ProductionShipment_Delete(ByVal PS_NO As String, ByVal PS_NO_Sub As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionShipment_Delete")


                db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO)
                db.AddInParameter(dbComm, "@PS_NO_Sub", DbType.String, PS_NO_Sub)

                db.ExecuteNonQuery(dbComm)
                ProductionShipment_Delete = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionShipment_Delete = False
            End Try

        End Function



        Public Function ProductionShipment_UpdateCheck(ByVal objinfo As ProductionShipmentInfo) As Boolean  ''審核更新
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionShipment_UpdateCheck")

                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PS_Check", DbType.Boolean, objinfo.PS_Check)
                db.AddInParameter(dbComm, "@PS_CheckDate", DbType.Date, objinfo.PS_CheckDate)
                db.AddInParameter(dbComm, "@PS_CheckAction", DbType.String, objinfo.PS_CheckAction)
                db.AddInParameter(dbComm, "@PS_CheckRemark", DbType.String, objinfo.PS_CheckRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionShipment_UpdateCheck = True

            Catch ex As Exception

                MsgBox(ex.Message)
                ProductionShipment_UpdateCheck = False
            End Try
        End Function



        Public Function ProductionShipment_update(ByVal objinfo As ProductionShipmentInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionShipment_update")

                db.AddInParameter(dbComm, "@PS_NO", DbType.String, objinfo.PS_NO)
                db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, objinfo.PM_M_Code)
                db.AddInParameter(dbComm, "@PM_Type", DbType.String, objinfo.PM_Type)

                db.AddInParameter(dbComm, "@M_Code", DbType.String, objinfo.M_Code)
                db.AddInParameter(dbComm, "@PS_WareID", DbType.String, objinfo.PS_WareID)
                db.AddInParameter(dbComm, "@PS_Qty", DbType.Int32, objinfo.PS_Qty)

                db.AddInParameter(dbComm, "@PS_Type ", DbType.String, objinfo.PS_Type)
                db.AddInParameter(dbComm, "@PS_Action", DbType.String, objinfo.PS_Action)
                db.AddInParameter(dbComm, "@PS_Date", DbType.String, objinfo.PS_Date)

                db.AddInParameter(dbComm, "@PS_Remark ", DbType.String, objinfo.PS_Remark)
                db.AddInParameter(dbComm, "@PS_Check", DbType.String, objinfo.PS_Check)
                db.AddInParameter(dbComm, "@PS_CheckAction", DbType.String, objinfo.PS_CheckAction)

                db.AddInParameter(dbComm, "@PS_CheckDate", DbType.String, objinfo.PS_CheckDate)
                db.AddInParameter(dbComm, "@PS_CheckRemark", DbType.String, objinfo.PS_CheckRemark)

                db.AddInParameter(dbComm, "@PS_NO_Sub", DbType.String, objinfo.PS_NO_Sub)
                db.AddInParameter(dbComm, "@PS_Detail", DbType.String, objinfo.PS_Detail)
                db.AddInParameter(dbComm, "@PS_SubRemark", DbType.String, objinfo.PS_SubRemark)

                db.ExecuteNonQuery(dbComm)
                ProductionShipment_update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionShipment_update = False
            End Try

        End Function

        Public Function ProductionShipment_Get() As List(Of ProductionShipmentInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionShipment_Get")

            Dim FeatureList As New List(Of ProductionShipmentInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionShipment1(reader))
                End While
                Return FeatureList
            End Using

        End Function

        Public Function FillProductionShipment1(ByVal reader As IDataReader) As ProductionShipmentInfo
            ''因讀出的不是全部字段，所以就不用全部列出
            On Error Resume Next
            Dim p As New ProductionShipmentInfo

            p.M_Code = reader("M_Code").ToString
            p.PS_M_Name = reader("PS_M_Name").ToString

            Return p

        End Function


    End Class
End Namespace
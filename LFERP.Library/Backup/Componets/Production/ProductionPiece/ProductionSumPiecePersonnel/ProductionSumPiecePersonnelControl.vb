Imports System.Data.Common
Namespace LFERP.Library.ProductionSumPiecePersonnel


    Public Class ProductionSumPiecePersonnelControl
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="PP_AutoID">工藝表中的AutoID</param>
        ''' <param name="PP_NO"></param>
        ''' <param name="Per_NO"></param>
        ''' <param name="G_NO"></param>
        ''' <param name="DepID"></param>
        ''' <param name="FacID"></param>
        ''' <param name="Pro_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="PS_NO"></param>
        ''' <param name="PS_NameS"></param>
        ''' <param name="PP_DateStart"></param>
        ''' <param name="PP_Action"></param>
        ''' <param name="PP_DateEnd"></param>
        ''' <param name="Print_Action">供打印使用 </param>
        ''' <returns></returns>
        ''' <remarks></remarks>


        Public Function ProductionSumPiecePersonnel_GetList(ByVal PP_AutoID As String, ByVal PP_NO As String, ByVal Per_NO As String, ByVal G_NO As String, ByVal DepID As String, ByVal FacID As String, ByVal Pro_Type As String, _
                                                            ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_NO As String, ByVal PS_NameS As String, ByVal PP_DateStart As String, _
                                                            ByVal PP_Action As String, ByVal PP_DateEnd As String, ByVal Print_Action As String) As List(Of ProductionSumPiecePersonnelInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumPiecePersonnel_GetList")

            db.AddInParameter(dbComm, "@PP_AutoID", DbType.String, PP_AutoID) ' --/工藝編號

            db.AddInParameter(dbComm, "@PP_NO", DbType.String, PP_NO) ' --/計件單號
            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO) '--/員工編號
            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO) ' --/組別編號
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID) '-- /部門編號
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID) '-- /廠別

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type) '--/工藝類型
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code) ' -產品編號
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type) ' /配件名稱
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO) '大工序名稱
            db.AddInParameter(dbComm, "@PS_NameS", DbType.String, PS_NameS) '小工序名稱

            db.AddInParameter(dbComm, "@PP_DateStart", DbType.String, PP_DateStart) '/計件日期
            db.AddInParameter(dbComm, "@PP_Action", DbType.String, PP_Action) '-/操作人
            db.AddInParameter(dbComm, "@PP_DateEnd", DbType.String, PP_DateEnd) ' --> < =


            Dim FeatureList As New List(Of ProductionSumPiecePersonnelInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSumPiecePersonnel(reader, PP_DateStart, PP_DateEnd, Print_Action))
                End While
                Return FeatureList
            End Using

        End Function


        ''' <summary>
        ''' 獲取組別計時統計時指定記錄
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionSumPiecePersonnel(ByVal reader As IDataReader, ByVal FPP_DateStart As String, ByVal FPP_DateEnd As String, ByVal FPrint_Action As String) As ProductionSumPiecePersonnelInfo
            Dim ai As New ProductionSumPiecePersonnelInfo
            ''傳遞給打印
            ai.PP_DateEnd = FPP_DateEnd
            ai.PP_DateStart = FPP_DateStart
            ai.Print_Action = FPrint_Action

            If reader("Per_Class") Is DBNull.Value Then
                ai.Per_Class = Nothing
            Else
                ai.Per_Class = reader("Per_Class").ToString
            End If


            If reader("PP_NO") Is DBNull.Value Then ' /計件單號
                ai.PP_NO = Nothing
            Else
                ai.PP_NO = reader("PP_NO").ToString
            End If

            If reader("Per_NO") Is DBNull.Value Then ' /員工編號
                ai.Per_NO = Nothing
            Else
                ai.Per_NO = reader("Per_NO").ToString
            End If

            If reader("G_NO") Is DBNull.Value Then ' /組別編號
                ai.G_NO = Nothing
            Else
                ai.G_NO = reader("G_NO").ToString
            End If

            If reader("DepID") Is DBNull.Value Then ' /部門編號
                ai.DepID = Nothing
            Else
                ai.DepID = reader("DepID").ToString
            End If

            If reader("FacID") Is DBNull.Value Then ' /廠別
                ai.FacID = Nothing
            Else
                ai.FacID = reader("FacID").ToString
            End If

            ''-------------------------
            If reader("Pro_Type") Is DBNull.Value Then ' /工藝類型   ''本表中的記錄
                ai.Pro_Type = Nothing
            Else
                ai.Pro_Type = reader("Pro_Type").ToString
            End If

            If reader("PM_M_Code") Is DBNull.Value Then ' /產品編號''本表中的記錄
                ai.PM_M_Code = Nothing
            Else
                ai.PM_M_Code = reader("PM_M_Code").ToString
            End If

            If reader("PM_Type") Is DBNull.Value Then ' /配件名稱''本表中的記錄
                ai.PM_Type = Nothing
            Else
                ai.PM_Type = reader("PM_Type").ToString
            End If

            If reader("PS_NO") Is DBNull.Value Then ' /大工序名稱 ''本表中的記錄
                ai.PS_NO = Nothing
            Else
                ai.PS_NO = reader("PS_NO").ToString
            End If



            If reader("PS_NameS") Is DBNull.Value Then ' /小工序名稱''本表中的記錄
                ai.PS_NameS = Nothing
            Else
                ai.PS_NameS = reader("PS_NameS").ToString
            End If
            ''-------------------------------------------------------

            If reader("PP_factor") Is DBNull.Value Then ' /承包系數
                ai.PP_factor = Nothing
            Else
                ai.PP_factor = reader("PP_factor").ToString
            End If

            If reader("PP_factor") Is DBNull.Value Then ' /承包系數
                ai.PP_factor = Nothing
            Else
                ai.PP_factor = reader("PP_factor")
            End If

            If reader("PP_Qty") Is DBNull.Value Then ' /數量
                ai.PP_Qty = Nothing
            Else
                ai.PP_Qty = reader("PP_Qty")
            End If

            If reader("PP_Date") Is DBNull.Value Then ' /計件日期
                ai.PP_Date = Nothing
            Else
                ai.PP_Date = reader("PP_Date")
            End If

            If reader("PP_AddDate") Is DBNull.Value Then ' /記錄日期
                ai.PP_AddDate = Nothing
            Else
                ai.PP_AddDate = reader("PP_AddDate")
            End If

            If reader("PP_Action") Is DBNull.Value Then ' /操作人
                ai.PP_Action = Nothing
            Else
                ai.PP_Action = reader("PP_Action")
            End If

            If reader("PP_Remark") Is DBNull.Value Then ' /備注
                ai.PP_Remark = Nothing
            Else
                ai.PP_Remark = reader("PP_Remark").ToString
            End If
            '1''--------------------------外表字段
            If reader("PP_ActionName") Is DBNull.Value Then ' /操作員名
                ai.PP_ActionName = Nothing
            Else
                ai.PP_ActionName = reader("PP_ActionName").ToString
            End If

            If reader("PP_Per_Name") Is DBNull.Value Then ' /員工名姓名
                ai.PP_Per_Name = Nothing
            Else
                ai.PP_Per_Name = reader("PP_Per_Name").ToString
            End If

            If reader("PP_DepName") Is DBNull.Value Then ' /部門名
                ai.PP_DepName = Nothing
            Else
                ai.PP_DepName = reader("PP_DepName").ToString
            End If

            If reader("PP_FacName") Is DBNull.Value Then ' /廠別名
                ai.PP_FacName = Nothing
            Else
                ai.PP_FacName = reader("PP_FacName").ToString
            End If

            If reader("PP_G_Name") Is DBNull.Value Then ' /組別名
                ai.PP_G_Name = Nothing
            Else
                ai.PP_G_Name = reader("PP_G_Name").ToString
            End If

            If reader("PS_Name") Is DBNull.Value Then ' /大工序名稱
                ai.PS_Name = Nothing
            Else
                ai.PS_Name = reader("PS_Name").ToString
            End If


            If reader("PP_AutoID") Is DBNull.Value Then ' 工藝表中的AUTOID
                ai.PP_AutoID = Nothing
            Else
                ai.PP_AutoID = reader("PP_AutoID").ToString
            End If

            If reader("PP_Price") Is DBNull.Value Then ' 工價
                ai.PP_Price = Nothing
            Else
                ai.PP_Price = reader("PP_Price")
            End If




            Return ai

        End Function
        ''' <summary>
        ''' 增加記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumPiecePersonnel_Add(ByVal obj As ProductionSumPiecePersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumPiecePersonnel_Add")


                db.AddInParameter(dbcomm, "@PP_AutoID", DbType.String, obj.PP_AutoID) '--/工藝流程中的編號
                db.AddInParameter(dbcomm, "@PP_Price", DbType.Double, obj.PP_Price) '--/工價

                db.AddInParameter(dbcomm, "@PP_NO", DbType.String, obj.PP_NO) '--/計件單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工編號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號
                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別

                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, obj.Pro_Type)  '/工藝類型
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code) ' - /產品編號
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type) ' -- /配件名稱    
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, obj.PS_NO) '  -- /大工序名稱
                db.AddInParameter(dbcomm, "@PS_NameS", DbType.String, obj.PS_NameS) '--/操作人

                db.AddInParameter(dbcomm, "@PP_factor", DbType.Double, obj.PP_factor) '--/承包系數
                db.AddInParameter(dbcomm, "@PP_Qty", DbType.Int32, obj.PP_Qty) ' - /數量
                db.AddInParameter(dbcomm, "@PP_Date", DbType.String, obj.PP_Date) ' -- /計件日期    
                db.AddInParameter(dbcomm, "@PP_AddDate", DbType.String, obj.PP_AddDate) '  -- /記錄日期
                db.AddInParameter(dbcomm, "@PP_Action", DbType.String, obj.PP_Action) '--/操作人

                db.AddInParameter(dbcomm, "@PP_Remark", DbType.String, obj.PP_Remark) '--/備注


                db.ExecuteNonQuery(dbcomm)
                ProductionSumPiecePersonnel_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumPiecePersonnel_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 更新記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumPiecePersonnel_Update(ByVal obj As ProductionSumPiecePersonnelInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumPiecePersonnel_Update")

                db.AddInParameter(dbcomm, "@PP_AutoID", DbType.String, obj.PP_AutoID) '--/工藝流程中的編號
                db.AddInParameter(dbcomm, "@PP_Price", DbType.Double, obj.PP_Price) '--/工價

                db.AddInParameter(dbcomm, "@PP_NO", DbType.String, obj.PP_NO) '--/計件單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工編號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號
                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別

                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, obj.Pro_Type)  '/工藝類型
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code) ' - /產品編號
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type) ' -- /配件名稱    
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, obj.PS_NO) '  -- /大工序名稱
                db.AddInParameter(dbcomm, "@PS_NameS", DbType.String, obj.PS_NameS) '--/操作人

                db.AddInParameter(dbcomm, "@PP_factor", DbType.Double, obj.PP_factor) '--/承包系數
                db.AddInParameter(dbcomm, "@PP_Qty", DbType.Int32, obj.PP_Qty) ' - /數量
                db.AddInParameter(dbcomm, "@PP_Date", DbType.String, obj.PP_Date) ' -- /計件日期    
                db.AddInParameter(dbcomm, "@PP_AddDate", DbType.String, obj.PP_AddDate) '  -- /記錄日期
                db.AddInParameter(dbcomm, "@PP_Action", DbType.String, obj.PP_Action) '--/操作人

                db.AddInParameter(dbcomm, "@PP_Remark", DbType.String, obj.PP_Remark) '--/備注


                db.ExecuteNonQuery(dbcomm)
                ProductionSumPiecePersonnel_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumPiecePersonnel_Update = False
            End Try
        End Function
        ''' <summary>
        ''' 刪除個人計件名單
        ''' </summary>
        ''' <param name="PP_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumPiecePersonnel_Delete(ByVal PP_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumPiecePersonnel_Delete")

                db.AddInParameter(dbcomm, "@PP_NO", DbType.String, PP_NO)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumPiecePersonnel_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumPiecePersonnel_Delete = False
            End Try
        End Function


        ''' <summary>
        ''' 獲取驗收單號 FillProductionSumPiecePersonnel1 一起單獨使有
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionSumPiecePersonnel_GetNO(ByVal Ndate As String) As ProductionSumPiecePersonnelInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumPiecePersonnel_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionSumPiecePersonnel1(reader)
                End While
                Return Nothing
            End Using
        End Function
        ''' <summary>
        ''' 返回TOP1組別單號(因要載入的數據不多單獨定一函數)以提高速度
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionSumPiecePersonnel1(ByVal reader As IDataReader) As ProductionSumPiecePersonnelInfo
            Dim ai1 As New ProductionSumPiecePersonnelInfo
            If reader("PP_NO") Is DBNull.Value Then ai1.PP_NO = Nothing Else ai1.PP_NO = reader("PP_NO").ToString '
            Return ai1

        End Function

        ''' <summary>
        ''' 打印時無數據時，調用此函數
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NothingNew() As List(Of ProductionSumPiecePersonnelInfo)
            Dim pi As New ProductionSumPiecePersonnelInfo
            Dim FeatureList As New List(Of ProductionSumPiecePersonnelInfo)
            FeatureList.Add(NothingFillProductionSumPiecePersonnel())
            Return FeatureList
        End Function

        Public Function NothingFillProductionSumPiecePersonnel() As ProductionSumPiecePersonnelInfo
            Dim ai1 As New ProductionSumPiecePersonnelInfo
            ai1.PP_NO = Nothing '            *  nvarchar(50)                /計件單號
            ai1.Per_NO = Nothing '           *  nvarchar(50)                /員工編號
            ai1.G_NO = Nothing '              *  nvarchar(50)                /組別編號
            ai1.DepID = Nothing '             *  nvarchar(50)                /部門編號
            ai1.FacID = Nothing '             *  nvarchar(50)                /廠別

            ai1.Pro_Type = Nothing '          *  nvarchar(50)                /工藝類型
            ai1.PM_M_Code = Nothing '         *  nvarchar(50)                /產品編號
            ai1.PM_Type = Nothing '          *  nvarchar(50)                /配件名稱

            ai1.PS_NameS = Nothing '          *  nvarchar(50)                /小工序名稱

            ai1.PP_factor = 0 '         *  float                       /承包系數
            ai1.PP_Qty = 0 '            *  int                         /數量 
            ai1.PP_Date = Nothing '           *  datetime                    /計件日期
            ai1.PP_AddDate = Nothing '        *  datetime                 /記錄日期
            ai1.PP_Action = Nothing  '        *  nvarchar(50)                /操作人

            ai1.PP_Remark = Nothing '         *  nvarchar(MAX)               /備注

            '外表字段
            ai1.PP_ActionName = Nothing ' 操作員名 (SystemUser)
            ai1.PP_Per_Name = Nothing '    員工名姓名(ProductionPiecePersonnel)
            ai1.PP_DepName = Nothing '    部門名
            ai1.PP_FacName = Nothing '    廠別名
            ai1.PP_G_Name = Nothing '      組別名(ProductionPieceWorkGroup)    本模不用

            ai1.PS_Name = Nothing                    '    /大工序名稱  ProcessSub
            ai1.PS_NO = Nothing                      '    大工序編號   ProductionPieceProcess

            ai1.PP_AutoID = Nothing ''工藝表中流程
            ai1.PP_Price = 0  ''工價

            ai1.PP_DateEnd = Nothing
            ai1.PP_DateStart = Nothing

            ai1.Print_Action = Nothing ''供打印使 用
            Return ai1

        End Function



    End Class
End Namespace
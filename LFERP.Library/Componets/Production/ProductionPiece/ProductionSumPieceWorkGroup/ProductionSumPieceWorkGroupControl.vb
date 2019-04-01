Imports System.Data.Common

Namespace LFERP.Library.ProductionSumPieceWorkGroup


    Public Class ProductionSumPieceWorkGroupControl


        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="PP_AutoID"></param>
        ''' <param name="GP_NO"></param>
        ''' <param name="Per_NO"></param>
        ''' <param name="G_NO"></param>
        ''' <param name="DepID"></param>
        ''' <param name="FacID"></param>
        ''' <param name="Pro_Type"></param>
        ''' <param name="PM_M_Code"></param>
        ''' <param name="PM_Type"></param>
        ''' <param name="PS_NO"></param>
        ''' <param name="PS_NameS"></param>
        ''' <param name="GP_DateStart"></param>
        ''' <param name="GP_Action"></param>
        ''' <param name="GP_DateEnd"></param>
        ''' <param name="Print_Action">打印專用</param>
        ''' <returns></returns>
        ''' <remarks></remarks>




        Public Function ProductionSumPieceWorkGroup_GetList(ByVal PP_AutoID As String, ByVal GP_NO As String, ByVal Per_NO As String, ByVal G_NO As String, ByVal DepID As String, ByVal FacID As String, ByVal Pro_Type As String, _
                                                            ByVal PM_M_Code As String, ByVal PM_Type As String, ByVal PS_NO As String, ByVal PS_NameS As String, ByVal GP_DateStart As String, _
                                                            ByVal GP_Action As String, ByVal GP_DateEnd As String, ByVal Print_Action As String) As List(Of ProductionSumPieceWorkGroupInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumPieceWorkGroup_GetList")

            db.AddInParameter(dbComm, "@PP_AutoID", DbType.String, PP_AutoID) ' --/工藝編號

            db.AddInParameter(dbComm, "@GP_NO", DbType.String, GP_NO) ' --/計件單號
            db.AddInParameter(dbComm, "@Per_NO", DbType.String, Per_NO) '--/員工編號
            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO) ' --/組別編號
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID) '-- /部門編號
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID) '-- /廠別

            db.AddInParameter(dbComm, "@Pro_Type", DbType.String, Pro_Type) '--/工藝類型
            db.AddInParameter(dbComm, "@PM_M_Code", DbType.String, PM_M_Code) ' -產品編號
            db.AddInParameter(dbComm, "@PM_Type", DbType.String, PM_Type) ' /配件名稱
            db.AddInParameter(dbComm, "@PS_NO", DbType.String, PS_NO) '大工序名稱
            db.AddInParameter(dbComm, "@PS_NameS", DbType.String, PS_NameS) '小工序名稱

            db.AddInParameter(dbComm, "@GP_DateStart", DbType.String, GP_DateStart) '/計件日期
            db.AddInParameter(dbComm, "@GP_Action", DbType.String, GP_Action) '-/操作人
            db.AddInParameter(dbComm, "@GP_DateEnd", DbType.String, GP_DateEnd) ' --> < =


            Dim FeatureList As New List(Of ProductionSumPieceWorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionSumPieceWorkGroup(reader, GP_DateStart, GP_DateEnd, Print_Action))
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
        Public Function FillProductionSumPieceWorkGroup(ByVal reader As IDataReader, ByVal FGP_DateStart As String, ByVal FGP_DateEnd As String, ByVal FPrint_Action As String) As ProductionSumPieceWorkGroupInfo
            Dim ai As New ProductionSumPieceWorkGroupInfo
            ''打印專用
            ai.Print_Action = FPrint_Action
            ai.GP_DateStart = FGP_DateStart
            ai.GP_DateEnd = FGP_DateEnd


            If reader("GP_NO") Is DBNull.Value Then ' /計件單號
                ai.GP_NO = Nothing
            Else
                ai.GP_NO = reader("GP_NO").ToString
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

            If reader("GP_factor") Is DBNull.Value Then ' /承包系數
                ai.GP_factor = Nothing
            Else
                ai.GP_factor = reader("GP_factor").ToString
            End If

            If reader("GP_factor") Is DBNull.Value Then ' /承包系數
                ai.GP_factor = Nothing
            Else
                ai.GP_factor = reader("GP_factor")
            End If

            If reader("GP_Qty") Is DBNull.Value Then ' /數量
                ai.GP_Qty = Nothing
            Else
                ai.GP_Qty = reader("GP_Qty")
            End If

            If reader("GP_Date") Is DBNull.Value Then ' /計件日期
                ai.GP_Date = Nothing
            Else
                ai.GP_Date = reader("GP_Date")
            End If

            If reader("GP_AddDate") Is DBNull.Value Then ' /記錄日期
                ai.GP_AddDate = Nothing
            Else
                ai.GP_AddDate = reader("GP_AddDate")
            End If

            If reader("GP_Action") Is DBNull.Value Then ' /操作人
                ai.GP_Action = Nothing
            Else
                ai.GP_Action = reader("GP_Action")
            End If

            If reader("GP_Remark") Is DBNull.Value Then ' /備注
                ai.GP_Remark = Nothing
            Else
                ai.GP_Remark = reader("GP_Remark").ToString
            End If
            '1''--------------------------外表字段
            If reader("GP_ActionName") Is DBNull.Value Then ' /操作員名
                ai.GP_ActionName = Nothing
            Else
                ai.GP_ActionName = reader("GP_ActionName").ToString
            End If

            If reader("GP_Per_Name") Is DBNull.Value Then ' /員工名姓名
                ai.GP_Per_Name = Nothing
            Else
                ai.GP_Per_Name = reader("GP_Per_Name").ToString
            End If

            If reader("GP_DepName") Is DBNull.Value Then ' /部門名
                ai.GP_DepName = Nothing
            Else
                ai.GP_DepName = reader("GP_DepName").ToString
            End If

            If reader("GP_FacName") Is DBNull.Value Then ' /廠別名
                ai.GP_FacName = Nothing
            Else
                ai.GP_FacName = reader("GP_FacName").ToString
            End If

            If reader("GP_G_Name") Is DBNull.Value Then ' /組別名
                ai.GP_G_Name = Nothing
            Else
                ai.GP_G_Name = reader("GP_G_Name").ToString
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

            If reader("GP_Price") Is DBNull.Value Then ' 工價
                ai.GP_Price = Nothing
            Else
                ai.GP_Price = reader("GP_Price")
            End If


            Return ai

        End Function
        ''' <summary>
        ''' 增加記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumPieceWorkGroup_Add(ByVal obj As ProductionSumPieceWorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumPieceWorkGroup_Add")


                db.AddInParameter(dbcomm, "@PP_AutoID", DbType.String, obj.PP_AutoID) '--/工藝流程中的編號
                db.AddInParameter(dbcomm, "@GP_Price", DbType.Double, obj.GP_Price) '--/工價

                db.AddInParameter(dbcomm, "@GP_NO", DbType.String, obj.GP_NO) '--/計件單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工編號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號
                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別

                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, obj.Pro_Type)  '/工藝類型
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code) ' - /產品編號
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type) ' -- /配件名稱    
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, obj.PS_NO) '  -- /大工序名稱
                db.AddInParameter(dbcomm, "@PS_NameS", DbType.String, obj.PS_NameS) '--/操作人

                db.AddInParameter(dbcomm, "@GP_factor", DbType.Double, obj.GP_factor) '--/承包系數
                db.AddInParameter(dbcomm, "@GP_Qty", DbType.Int32, obj.GP_Qty) ' - /數量
                db.AddInParameter(dbcomm, "@GP_Date", DbType.String, obj.GP_Date) ' -- /計件日期    
                db.AddInParameter(dbcomm, "@GP_AddDate", DbType.String, obj.GP_AddDate) '  -- /記錄日期
                db.AddInParameter(dbcomm, "@GP_Action", DbType.String, obj.GP_Action) '--/操作人

                db.AddInParameter(dbcomm, "@GP_Remark", DbType.String, obj.GP_Remark) '--/備注


                db.ExecuteNonQuery(dbcomm)
                ProductionSumPieceWorkGroup_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumPieceWorkGroup_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 更新記錄
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumPieceWorkGroup_Update(ByVal obj As ProductionSumPieceWorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumPieceWorkGroup_Update")

                db.AddInParameter(dbcomm, "@PP_AutoID", DbType.String, obj.PP_AutoID) '--/工藝流程中的編號
                db.AddInParameter(dbcomm, "@GP_Price", DbType.Double, obj.GP_Price) '--/工價

                db.AddInParameter(dbcomm, "@GP_NO", DbType.String, obj.GP_NO) '--/計件單號
                db.AddInParameter(dbcomm, "@Per_NO", DbType.String, obj.Per_NO) '-- /員工編號
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO) ' --/組別編號
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID) ' --/部門編號
                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID) ' --/廠別

                db.AddInParameter(dbcomm, "@Pro_Type", DbType.String, obj.Pro_Type)  '/工藝類型
                db.AddInParameter(dbcomm, "@PM_M_Code", DbType.String, obj.PM_M_Code) ' - /產品編號
                db.AddInParameter(dbcomm, "@PM_Type", DbType.String, obj.PM_Type) ' -- /配件名稱    
                db.AddInParameter(dbcomm, "@PS_NO", DbType.String, obj.PS_NO) '  -- /大工序名稱
                db.AddInParameter(dbcomm, "@PS_NameS", DbType.String, obj.PS_NameS) '--/操作人

                db.AddInParameter(dbcomm, "@GP_factor", DbType.Double, obj.GP_factor) '--/承包系數
                db.AddInParameter(dbcomm, "@GP_Qty", DbType.Int32, obj.GP_Qty) ' - /數量
                db.AddInParameter(dbcomm, "@GP_Date", DbType.String, obj.GP_Date) ' -- /計件日期    
                db.AddInParameter(dbcomm, "@GP_AddDate", DbType.String, obj.GP_AddDate) '  -- /記錄日期
                db.AddInParameter(dbcomm, "@GP_Action", DbType.String, obj.GP_Action) '--/操作人

                db.AddInParameter(dbcomm, "@GP_Remark", DbType.String, obj.GP_Remark) '--/備注


                db.ExecuteNonQuery(dbcomm)
                ProductionSumPieceWorkGroup_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumPieceWorkGroup_Update = False
            End Try
        End Function
        ''' <summary>
        ''' 刪除個人計件名單
        ''' </summary>
        ''' <param name="GP_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionSumPieceWorkGroup_Delete(ByVal GP_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionSumPieceWorkGroup_Delete")

                db.AddInParameter(dbcomm, "@GP_NO", DbType.String, GP_NO)

                db.ExecuteNonQuery(dbcomm)
                ProductionSumPieceWorkGroup_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionSumPieceWorkGroup_Delete = False
            End Try
        End Function


        ''' <summary>
        ''' 獲取驗收單號 FillProductionSumPieceWorkGroup1 一起單獨使有
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionSumPieceWorkGroup_GetNO(ByVal Ndate As String) As ProductionSumPieceWorkGroupInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionSumPieceWorkGroup_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionSumPieceWorkGroup1(reader)
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
        Public Function FillProductionSumPieceWorkGroup1(ByVal reader As IDataReader) As ProductionSumPieceWorkGroupInfo
            Dim ai1 As New ProductionSumPieceWorkGroupInfo
            If reader("GP_NO") Is DBNull.Value Then ai1.GP_NO = Nothing Else ai1.GP_NO = reader("GP_NO").ToString '
            Return ai1

        End Function

        '' <summary>
        ''' 打印時無數據時，調用此函數
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function NothingNew() As List(Of ProductionSumPieceWorkGroupInfo)
            Dim pi As New ProductionSumPieceWorkGroupInfo
            Dim FeatureList As New List(Of ProductionSumPieceWorkGroupInfo)
            FeatureList.Add(NothingFillProductionSumPieceWorkGroup())
            Return FeatureList
        End Function

        Public Function NothingFillProductionSumPieceWorkGroup() As ProductionSumPieceWorkGroupInfo
            Dim ai1 As New ProductionSumPieceWorkGroupInfo
            ai1.GP_NO = Nothing '            *  nvarchar(50)                /計件單號
            ai1.Per_NO = Nothing '           *  nvarchar(50)                /員工編號
            ai1.G_NO = Nothing '              *  nvarchar(50)                /組別編號
            ai1.DepID = Nothing '             *  nvarchar(50)                /部門編號
            ai1.FacID = Nothing '             *  nvarchar(50)                /廠別

            ai1.Pro_Type = Nothing '          *  nvarchar(50)                /工藝類型
            ai1.PM_M_Code = Nothing '         *  nvarchar(50)                /產品編號
            ai1.PM_Type = Nothing '          *  nvarchar(50)                /配件名稱

            ai1.PS_NameS = Nothing '          *  nvarchar(50)                /小工序名稱

            ai1.GP_factor = 0 '         *  float                       /承包系數
            ai1.GP_Qty = 0 '            *  int                         /數量 
            ai1.GP_Date = Nothing '           *  datetime                    /計件日期
            ai1.GP_AddDate = Nothing '        *  datetime                 /記錄日期
            ai1.GP_Action = Nothing  '        *  nvarchar(50)                /操作人

            ai1.GP_Remark = Nothing '         *  nvarchar(MAX)               /備注

            '外表字段
            ai1.GP_ActionName = Nothing ' 操作員名 (SystemUser)
            ai1.GP_Per_Name = Nothing '    員工名姓名(ProductionPiecePersonnel)
            ai1.GP_DepName = Nothing '    部門名
            ai1.GP_FacName = Nothing '    廠別名
            ai1.GP_G_Name = Nothing '      組別名(ProductionPieceWorkGroup)    本模不用

            ai1.PS_Name = Nothing                    '    /大工序名稱  ProcessSub
            ai1.PS_NO = Nothing                      '    大工序編號   ProductionPieceProcess

            ai1.PP_AutoID = Nothing ''工藝表中流程
            ai1.GP_Price = 0  ''工價

            ai1.GP_DateEnd = Nothing
            ai1.GP_DateStart = Nothing

            ai1.Print_Action = Nothing
            Return ai1
        End Function


    End Class

    '

End Namespace














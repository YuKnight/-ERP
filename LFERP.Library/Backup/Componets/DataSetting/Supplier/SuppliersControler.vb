
Namespace LFERP.DataSetting
    Public Class SuppliersControler
        Public Function GetSuppliersList(ByVal Supplier As String, ByVal SupplierName As String, ByVal S_TypeID As String, ByVal S_Rank As String, ByVal S_Type As String, ByVal S_Check As String, ByVal S_ReCheck As String) As List(Of SuppliersInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_GetList")
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, Supplier)
            db.AddInParameter(dbComm, "@S_SupplierName", DbType.String, SupplierName)
            db.AddInParameter(dbComm, "@S_TypeID", DbType.String, S_TypeID)
            db.AddInParameter(dbComm, "@S_Rank", DbType.String, S_Rank)
            db.AddInParameter(dbComm, "@S_Type", DbType.String, S_Type)
            db.AddInParameter(dbComm, "@S_Check", DbType.String, S_Check)
            db.AddInParameter(dbComm, "@S_ReCheck", DbType.String, S_ReCheck)

            Dim FeatureList As New List(Of SuppliersInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSuppliersType(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function SuppliersOldRecord_GetList(ByVal Supplier As String, ByVal SupplierName As String, ByVal S_TypeID As String, ByVal S_Rank As String, ByVal S_Type As String, ByVal S_Check As String, ByVal S_ReCheck As String) As List(Of SuppliersInfo)
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("SuppliersOldRecord_GetList")
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, Supplier)
            db.AddInParameter(dbComm, "@S_SupplierName", DbType.String, SupplierName)
            db.AddInParameter(dbComm, "@S_TypeID", DbType.String, S_TypeID)
            db.AddInParameter(dbComm, "@S_Rank", DbType.String, S_Rank)
            db.AddInParameter(dbComm, "@S_Type", DbType.String, S_Type)
            db.AddInParameter(dbComm, "@S_Check", DbType.String, S_Check)
            db.AddInParameter(dbComm, "@S_ReCheck", DbType.String, S_ReCheck)

            Dim FeatureList As New List(Of SuppliersInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillSuppliersType(reader))
                End While
                Return FeatureList
            End Using
        End Function
        Public Function Suppliers_GetDataTable(ByVal Supplier As String) As DataTable
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_GetDataTable")
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, Supplier)
                Return db.ExecuteDataSet(dbComm).Tables(0)
            Catch ex As Exception
                MsgBox(ex.Message)
                Return Nothing
            End Try

        End Function

        Public Function Suppliers_Get(ByVal Supplier As String, ByVal SupplierName As String) As SuppliersInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_Get")
            db.AddInParameter(dbComm, "@S_Supplier", DbType.String, Supplier)
            db.AddInParameter(dbComm, "@S_SupplierName", DbType.String, SupplierName)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillSuppliersType(reader)
                End While
                Return Nothing
            End Using
        End Function


        Friend Function FillSuppliersType(ByVal reader As IDataReader) As SuppliersInfo
            '對應取得的數據
            On Error Resume Next
            Dim objInfo As New SuppliersInfo
            objInfo.S_Supplier = reader("S_Supplier").ToString
            objInfo.S_SupplierName = reader("S_SupplierName").ToString
            objInfo.S_Associate = reader("S_Associate").ToString
            objInfo.S_Associate1 = reader("S_Associate1").ToString
            objInfo.S_Associate2 = reader("S_Associate2").ToString
            objInfo.S_Tel = reader("S_Tel").ToString
            objInfo.S_Tel1 = reader("S_Tel1").ToString
            objInfo.S_Tel2 = reader("S_Tel2").ToString
            objInfo.S_Phone = reader("S_Phone").ToString
            objInfo.S_Phone1 = reader("S_Phone1").ToString
            objInfo.S_Phone2 = reader("S_Phone2").ToString
            objInfo.S_Fax = reader("S_Fax").ToString
            objInfo.S_Fax1 = reader("S_Fax1").ToString
            objInfo.S_Fax2 = reader("S_Fax2").ToString
            objInfo.S_Email = reader("S_Email").ToString
            objInfo.S_Email1 = reader("S_Email1").ToString
            objInfo.S_Email2 = reader("S_Email2").ToString
            objInfo.S_Address = reader("S_Address").ToString
            objInfo.S_Address1 = reader("S_Address1").ToString
            objInfo.S_Address2 = reader("S_Address2").ToString
            objInfo.S_Web = reader("S_Web").ToString
            objInfo.S_TypeID = reader("S_TypeID").ToString
            objInfo.S_Currency = reader("S_Currency").ToString
            objInfo.S_Remark = reader("S_Remark").ToString
            objInfo.S_ToFrom = reader("S_ToFrom").ToString
            objInfo.S_Rank = reader("S_Rank").ToString
            objInfo.S_Check = reader("S_Check").ToString
            objInfo.S_Action = reader("S_Action").ToString
            objInfo.S_CheckAction = reader("S_CheckAction").ToString

            If IsDBNull(reader("S_AddDate")) Then
                objInfo.S_AddDate = Nothing
            Else
                objInfo.S_AddDate = Format(CDate(reader("S_AddDate").ToString), "yyyy/MM/dd")
            End If

            If IsDBNull(reader("S_EditDate")) Then
                objInfo.S_EditDate = Nothing
            Else
                objInfo.S_EditDate = Format(CDate(reader("S_EditDate").ToString), "yyyy/MM/dd")
            End If

            If IsDBNull(reader("S_CheckDate")) Then
                objInfo.S_CheckDate = Nothing
            Else
                objInfo.S_CheckDate = Format(CDate(reader("S_CheckDate").ToString), "yyyy/MM/dd")
            End If

            objInfo.S_RankRemark = reader("S_RankRemark").ToString
            objInfo.S_Type = reader("S_Type").ToString
            If IsDBNull(reader("S_ReCheck")) Then
                objInfo.S_ReCheck = False
            Else
                objInfo.S_ReCheck = reader("S_ReCheck")
            End If
            objInfo.S_ReCheckAction = reader("S_ReCheckAction").ToString

            If IsDBNull(reader("S_Recheckdate")) Then 'S_Recheckdate
                objInfo.S_ReCheckDate = Nothing
            Else
                objInfo.S_ReCheckDate = Format(CDate(reader("S_Recheckdate").ToString), "yyyy/MM/dd")
            End If



            objInfo.S_EditUser = reader("S_EditUser").ToString



            Return objInfo
        End Function

        ''' <summary>
        '''供應商新增 
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Suppliers_Add(ByVal objFile1 As SuppliersInfo) As Boolean
            '   檢查項目是否已存在()
            'Dim objSystemUserInfo As SuppliersInfo = Suppliers_Get(objFile1.S_Supplier)
            'If objSystemUserInfo Is Nothing Then

            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_Add")
                db.AddInParameter(dbComm, "@S_SupplierName", DbType.String, objFile1.S_SupplierName)
                db.AddInParameter(dbComm, "@S_Associate", DbType.String, objFile1.S_Associate)
                db.AddInParameter(dbComm, "@S_Associate1", DbType.String, objFile1.S_Associate1)
                db.AddInParameter(dbComm, "@S_Associate2", DbType.String, objFile1.S_Associate2)
                db.AddInParameter(dbComm, "@S_Tel", DbType.String, objFile1.S_Tel)
                db.AddInParameter(dbComm, "@S_Tel1", DbType.String, objFile1.S_Tel1)
                db.AddInParameter(dbComm, "@S_Tel2", DbType.String, objFile1.S_Tel2)
                db.AddInParameter(dbComm, "@S_Phone", DbType.String, objFile1.S_Phone)
                db.AddInParameter(dbComm, "@S_Phone1", DbType.String, objFile1.S_Phone1)
                db.AddInParameter(dbComm, "@S_Phone2", DbType.String, objFile1.S_Phone2)
                db.AddInParameter(dbComm, "@S_Fax", DbType.String, objFile1.S_Fax)
                db.AddInParameter(dbComm, "@S_Fax1", DbType.String, objFile1.S_Fax1)
                db.AddInParameter(dbComm, "@S_Fax2", DbType.String, objFile1.S_Fax2)
                db.AddInParameter(dbComm, "@S_Email", DbType.String, objFile1.S_Email)
                db.AddInParameter(dbComm, "@S_Email1", DbType.String, objFile1.S_Email1)
                db.AddInParameter(dbComm, "@S_Email2", DbType.String, objFile1.S_Email2)
                db.AddInParameter(dbComm, "@S_Address", DbType.String, objFile1.S_Address)
                db.AddInParameter(dbComm, "@S_Address1", DbType.String, objFile1.S_Address1)
                db.AddInParameter(dbComm, "@S_Address2", DbType.String, objFile1.S_Address2)
                db.AddInParameter(dbComm, "@S_Web", DbType.String, objFile1.S_Web)
                db.AddInParameter(dbComm, "@S_TypeID", DbType.String, objFile1.S_TypeID)
                db.AddInParameter(dbComm, "@S_Currency", DbType.String, objFile1.S_Currency)
                db.AddInParameter(dbComm, "@S_Remark", DbType.String, objFile1.S_Remark)
                db.AddInParameter(dbComm, "@S_ToFrom", DbType.String, objFile1.S_ToFrom)
                db.AddInParameter(dbComm, "@S_Rank", DbType.String, objFile1.S_Rank)
                db.AddInParameter(dbComm, "@S_RankRemark", DbType.String, objFile1.S_RankRemark)
                db.AddInParameter(dbComm, "@S_Check", DbType.Boolean, objFile1.S_Check)
                db.AddInParameter(dbComm, "@S_Action", DbType.String, objFile1.S_Action)
                db.AddInParameter(dbComm, "@S_CheckAction", DbType.String, objFile1.S_CheckAction)
                db.AddInParameter(dbComm, "@S_AddDate", DbType.Date, objFile1.S_AddDate)
                db.AddInParameter(dbComm, "@S_EditDate", DbType.Date, objFile1.S_EditDate)

                db.AddInParameter(dbComm, "@S_Type", DbType.String, objFile1.S_Type)

                db.ExecuteNonQuery(dbComm)
                Suppliers_Add = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Suppliers_Add = False

            End Try

            'Else
            'MsgBox("已存在此記錄,請檢查!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information)
            'End If
        End Function


        ''' <summary>
        ''' 供應商修改
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Suppliers_Update(ByVal objFile1 As SuppliersInfo) As Boolean

            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_Update")
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)
                db.AddInParameter(dbComm, "@S_SupplierName", DbType.String, objFile1.S_SupplierName)
                db.AddInParameter(dbComm, "@S_Associate", DbType.String, objFile1.S_Associate)
                db.AddInParameter(dbComm, "@S_Associate1", DbType.String, objFile1.S_Associate1)
                db.AddInParameter(dbComm, "@S_Associate2", DbType.String, objFile1.S_Associate2)
                db.AddInParameter(dbComm, "@S_Tel", DbType.String, objFile1.S_Tel)
                db.AddInParameter(dbComm, "@S_Tel1", DbType.String, objFile1.S_Tel1)
                db.AddInParameter(dbComm, "@S_Tel2", DbType.String, objFile1.S_Tel2)
                db.AddInParameter(dbComm, "@S_Phone", DbType.String, objFile1.S_Phone)
                db.AddInParameter(dbComm, "@S_Phone1", DbType.String, objFile1.S_Phone1)
                db.AddInParameter(dbComm, "@S_Phone2", DbType.String, objFile1.S_Phone2)
                db.AddInParameter(dbComm, "@S_Fax", DbType.String, objFile1.S_Fax)
                db.AddInParameter(dbComm, "@S_Fax1", DbType.String, objFile1.S_Fax1)
                db.AddInParameter(dbComm, "@S_Fax2", DbType.String, objFile1.S_Fax2)
                db.AddInParameter(dbComm, "@S_Email", DbType.String, objFile1.S_Email)
                db.AddInParameter(dbComm, "@S_Email1", DbType.String, objFile1.S_Email1)
                db.AddInParameter(dbComm, "@S_Email2", DbType.String, objFile1.S_Email2)
                db.AddInParameter(dbComm, "@S_Address", DbType.String, objFile1.S_Address)
                db.AddInParameter(dbComm, "@S_Address1", DbType.String, objFile1.S_Address1)
                db.AddInParameter(dbComm, "@S_Address2", DbType.String, objFile1.S_Address2)
                db.AddInParameter(dbComm, "@S_Web", DbType.String, objFile1.S_Web)
                db.AddInParameter(dbComm, "@S_TypeID", DbType.String, objFile1.S_TypeID)
                db.AddInParameter(dbComm, "@S_Currency", DbType.String, objFile1.S_Currency)
                db.AddInParameter(dbComm, "@S_Remark", DbType.String, objFile1.S_Remark)
                db.AddInParameter(dbComm, "@S_ToFrom", DbType.String, objFile1.S_ToFrom)
                db.AddInParameter(dbComm, "@S_Rank", DbType.String, objFile1.S_Rank)
                db.AddInParameter(dbComm, "@S_RankRemark", DbType.String, objFile1.S_RankRemark)
                db.AddInParameter(dbComm, "@S_Check", DbType.Boolean, objFile1.S_Check)
                'db.AddInParameter(dbComm, "@S_Action", DbType.String, objFile1.S_Action)
                db.AddInParameter(dbComm, "@S_CheckAction", DbType.String, objFile1.S_CheckAction)
                db.AddInParameter(dbComm, "@S_EditDate", DbType.Date, objFile1.S_EditDate)

                db.AddInParameter(dbComm, "@S_Type", DbType.String, objFile1.S_Type)
                db.AddInParameter(dbComm, "@S_EditUser", DbType.String, objFile1.S_EditUser)
                '

                db.ExecuteNonQuery(dbComm)
                Suppliers_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Suppliers_Update = False

            End Try
        End Function

        ''' <summary>
        ''' 審核保存
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Suppliers_UpdateCheck(ByVal objFile1 As SuppliersInfo) As Boolean

            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_UpdateCheck")
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)
          
                db.AddInParameter(dbComm, "@S_Rank", DbType.String, objFile1.S_Rank)
                db.AddInParameter(dbComm, "@S_RankRemark", DbType.String, objFile1.S_RankRemark)
                db.AddInParameter(dbComm, "@S_Check", DbType.Boolean, objFile1.S_Check)

                db.AddInParameter(dbComm, "@S_CheckAction", DbType.String, objFile1.S_CheckAction)
                db.AddInParameter(dbComm, "@S_CheckDate", DbType.String, objFile1.S_CheckDate)

                db.ExecuteNonQuery(dbComm)
                Suppliers_UpdateCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Suppliers_UpdateCheck = False

            End Try
        End Function

        ''' <summary>
        ''' 復核保存
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Suppliers_UpdateReCheck(ByVal objFile1 As SuppliersInfo) As Boolean

            Try

                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_UpdateReCheck")
                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)

                db.AddInParameter(dbComm, "@S_Rank", DbType.String, objFile1.S_Rank)
                db.AddInParameter(dbComm, "@S_RankRemark", DbType.String, objFile1.S_RankRemark)
                db.AddInParameter(dbComm, "@S_ReCheck", DbType.Boolean, objFile1.S_ReCheck)

                db.AddInParameter(dbComm, "@S_ReCheckAction", DbType.String, objFile1.S_ReCheckAction)
                db.AddInParameter(dbComm, "@S_ReCheckDate", DbType.String, objFile1.S_ReCheckDate)

                db.ExecuteNonQuery(dbComm)
                Suppliers_UpdateReCheck = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Suppliers_UpdateReCheck = False

            End Try
        End Function


        ''' <summary>
        ''' 供應商刪除
        ''' </summary>
        ''' <param name="objFile1"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function Suppliers_Delete(ByVal objFile1 As SuppliersInfo) As Boolean


            Try


                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbComm As DbCommand = db.GetStoredProcCommand("Suppliers_Delete")

                db.AddInParameter(dbComm, "@S_Supplier", DbType.String, objFile1.S_Supplier)

                db.ExecuteNonQuery(dbComm)
                Suppliers_Delete = True

            Catch ex As Exception
                MsgBox(ex.Message)
                Suppliers_Delete = False

            End Try
        End Function
       
    End Class
End Namespace

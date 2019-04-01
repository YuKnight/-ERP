Imports System.Data.Common
Namespace LFERP.Library.ProductionPieceWorkGroup

    Public Class ProductionPieceWorkGroupControl
        ''' <summary>
        ''' 查詢記錄
        ''' </summary>
        ''' <param name="G_NO"></param>
        ''' <param name="G_Manager"></param>
        ''' <param name="DepID"></param>
        ''' <param name="FacID"></param>
        ''' <param name="G_DateBegin"></param>
        ''' <param name="G_DateEnd"></param>
        ''' <param name="G_Action"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceWorkGroup_GetList(ByVal G_NO As String, ByVal G_Name As String, ByVal G_Manager As String, ByVal DepID As String, ByVal FacID As String, ByVal G_DateBegin As String, _
                                                          ByVal G_DateEnd As String, ByVal G_Action As String) As List(Of ProductionPieceWorkGroupInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceWorkGroup_GetList")

            db.AddInParameter(dbComm, "@G_NO", DbType.String, G_NO) '-- /組別編號
            db.AddInParameter(dbComm, "@G_Name", DbType.String, G_Name) '-- /組別名稱
            db.AddInParameter(dbComm, "@G_Manager", DbType.String, G_Manager) '-- /組別負責人
            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID) '部門編號
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID) '廠別

            db.AddInParameter(dbComm, "@G_DateBegin", DbType.String, G_DateBegin) '/建立日期
            db.AddInParameter(dbComm, "@G_DateEnd", DbType.String, G_DateEnd) '/建立日期
            db.AddInParameter(dbComm, "@G_Action", DbType.String, G_Action) '/操作人

            Dim FeatureList As New List(Of ProductionPieceWorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillProductionPieceWorkGroup(reader))
                End While
                Return FeatureList
            End Using

        End Function

        ''' <summary>
        ''' 讀取數據庫數據
        ''' </summary>
        ''' <param name="reader"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function FillProductionPieceWorkGroup(ByVal reader As IDataReader) As ProductionPieceWorkGroupInfo
            Dim ai As New ProductionPieceWorkGroupInfo

            If reader("G_NO") Is DBNull.Value Then
                ai.G_NO = Nothing
            Else
                ai.G_NO = reader("G_NO").ToString '  '組別編號
            End If

            If reader("G_Name") Is DBNull.Value Then
                ai.G_Name = Nothing
            Else
                ai.G_Name = reader("G_Name").ToString 'ai.A_AcceptanceNO  '組別名稱
            End If

            ai.G_NOName = Trim(ai.G_NO) & Space(2) & Trim(ai.G_Name) ''組別編號 名稱

            If reader("G_Manager") Is DBNull.Value Then
                ai.G_Manager = Nothing
            Else
                ai.G_Manager = reader("G_Manager").ToString ' --/組別負責人
            End If

            If reader("DepID") Is DBNull.Value Then
                ai.DepID = Nothing
            Else
                ai.DepID = reader("DepID").ToString ' -/部門編號
            End If

            If reader("FacID") Is DBNull.Value Then
                ai.FacID = Nothing
            Else
                ai.FacID = reader("FacID").ToString ' -/廠別
            End If

            If reader("G_Date") Is DBNull.Value Then
                ai.G_Date = Nothing
            Else
                ai.G_Date = CStr(reader("G_Date")) ' --/建立日期
            End If

            If reader("G_Action") Is DBNull.Value Then
                ai.G_Action = Nothing
            Else
                ai.G_Action = reader("G_Action").ToString ' --/操作人
            End If

            If reader("G_Remark") Is DBNull.Value Then
                ai.G_Remark = Nothing
            Else
                ai.G_Remark = reader("G_Remark").ToString ' --/備注
            End If

            ''連接外表字段
            If reader("G_ActionName") Is DBNull.Value Then
                ai.G_ActionName = Nothing
            Else
                ai.G_ActionName = reader("G_ActionName").ToString ' G_ActionName(操作人員姓名)
            End If

            If reader("G_DepName") Is DBNull.Value Then
                ai.G_DepName = Nothing
            Else
                ai.G_DepName = reader("G_DepName").ToString '   '(部門名稱)
            End If

            If reader("G_FacName") Is DBNull.Value Then
                ai.G_FacName = Nothing
            Else
                ai.G_FacName = reader("G_FacName").ToString ' - '(廠別名稱)
            End If


            Return ai

        End Function
        ''' <summary>
        '''添加組別信息
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceWorkGroup_Add(ByVal obj As ProductionPieceWorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceWorkGroup_Add")

                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO)
                db.AddInParameter(dbcomm, "@G_Name", DbType.String, obj.G_Name)
                db.AddInParameter(dbcomm, "@G_Manager", DbType.String, obj.G_Manager)
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID)

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID)
                db.AddInParameter(dbcomm, "@G_Date", DbType.String, obj.G_Date)
                db.AddInParameter(dbcomm, "@G_Action", DbType.String, obj.G_Action)
                db.AddInParameter(dbcomm, "@G_Remark", DbType.String, obj.G_Remark)

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceWorkGroup_Add = True


            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceWorkGroup_Add = False
            End Try
        End Function
        ''' <summary>
        ''' 更新組別信息
        ''' </summary>
        ''' <param name="obj"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceWorkGroup_Update(ByVal obj As ProductionPieceWorkGroupInfo) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceWorkGroup_Update")

                db.AddInParameter(dbcomm, "@G_NO", DbType.String, obj.G_NO)
                db.AddInParameter(dbcomm, "@G_Name", DbType.String, obj.G_Name)
                db.AddInParameter(dbcomm, "@G_Manager", DbType.String, obj.G_Manager)
                db.AddInParameter(dbcomm, "@DepID", DbType.String, obj.DepID)

                db.AddInParameter(dbcomm, "@FacID", DbType.String, obj.FacID)
                db.AddInParameter(dbcomm, "@G_Date", DbType.String, obj.G_Date)
                db.AddInParameter(dbcomm, "@G_Action", DbType.String, obj.G_Action)
                db.AddInParameter(dbcomm, "@G_Remark", DbType.String, obj.G_Remark)

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceWorkGroup_Update = True

            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceWorkGroup_Update = False
            End Try
        End Function

        ''' <summary>
        ''' 刪除組別記錄
        ''' </summary>
        ''' <param name="G_NO"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function ProductionPieceWorkGroup_Delete(ByVal G_NO As String) As Boolean
            Try
                Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
                Dim dbcomm As DbCommand = db.GetStoredProcCommand("ProductionPieceWorkGroup_Delete")
                db.AddInParameter(dbcomm, "@G_NO", DbType.String, G_NO)

                db.ExecuteNonQuery(dbcomm)
                ProductionPieceWorkGroup_Delete = True
            Catch ex As Exception
                MsgBox(ex.Message)
                ProductionPieceWorkGroup_Delete = False
            End Try
        End Function
        ''' <summary>
        ''' 獲取驗收單號 FillProductionPieceWorkGroup 一起單獨使有
        ''' </summary>
        ''' <param name="Ndate"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>

        Public Function ProductionPieceWorkGroup_GetNO(ByVal Ndate As String) As ProductionPieceWorkGroupInfo
            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("ProductionPieceWorkGroup_GetNO")
            db.AddInParameter(dbComm, "@NDate", DbType.String, Ndate)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    Return FillProductionPieceWorkGroup1(reader)
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
        Public Function FillProductionPieceWorkGroup1(ByVal reader As IDataReader) As ProductionPieceWorkGroupInfo
            Dim ai1 As New ProductionPieceWorkGroupInfo
            If reader("G_NO") Is DBNull.Value Then ai1.G_NO = Nothing Else ai1.G_NO = reader("G_NO").ToString '
            Return ai1

        End Function

        '''' <summary>
        '''' 根據用戶權限載入部門
        '''' </summary>
        '''' <param name="DepID"></param>
        '''' <param name="DepName"></param>
        '''' <param name="FacID"></param>
        '''' <param name="FacName"></param>
        '''' <param name="UserID"></param>
        '''' <param name="UserName"></param>
        '''' <param name="UserRank"></param>
        '''' <returns></returns>
        '''' <remarks></remarks>
        'Public Function DepFacUser_GetList1(ByVal DepID As String, ByVal DepName As String, ByVal FacID As String, ByVal FacName As String, ByVal UserID As String, ByVal UserName As String, ByVal UserRank As String) As List(Of ProductionPieceWorkGroupInfo)

        '    Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
        '    Dim dbComm As DbCommand = db.GetStoredProcCommand("DepFacUser_GetList")

        '    db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
        '    db.AddInParameter(dbComm, "@DepName", DbType.String, DepName)
        '    db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
        '    db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)
        '    db.AddInParameter(dbComm, "@UserID", DbType.String, UserID)
        '    db.AddInParameter(dbComm, "@UserName", DbType.String, UserName)
        '    db.AddInParameter(dbComm, "@UserRank", DbType.String, UserRank)

        '    Dim FeatureList As New List(Of ProductionPieceWorkGroupInfo)
        '    Using reader As IDataReader = db.ExecuteReader(dbComm)
        '        While reader.Read
        '            FeatureList.Add(FillPersonnel(reader))
        '        End While
        '        Return FeatureList
        '    End Using
        'End Function

        'Public Function FillPersonnel(ByVal reader As IDataReader) As ProductionPieceWorkGroupInfo
        '    ' On Error Resume Next
        '    Dim psi As New ProductionPieceWorkGroupInfo

        '    '.....................................................................

        '    psi.DepID = reader("DepID").ToString
        '    psi.G_DepName = reader("DepName").ToString

        '    psi.FacID = reader("FacID").ToString
        '    psi.G_FacName = reader("FacName").ToString

        '    psi.UserID = reader("UserID").ToString
        '    psi.UserName = reader("UserName").ToString

        '    psi.UserRank = reader("UserRank").ToString

        '    psi.UserDep_Fac = reader("DepID").ToString & Space(2) & reader("FacName").ToString & "--" & reader("DepName").ToString

        '    Return psi

        'End Function


        ''' <summary>
        ''' 載入全部部門
        ''' </summary>
        ''' <param name="DepID"></param>
        ''' <param name="DepName"></param>
        ''' <param name="FacID"></param>
        ''' <param name="FacName"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function DepFac_GetList1(ByVal DepID As String, ByVal DepName As String, ByVal FacID As String, ByVal FacName As String) As List(Of ProductionPieceWorkGroupInfo)

            Dim db As New Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(ConnStr)
            Dim dbComm As DbCommand = db.GetStoredProcCommand("DepFac_GetList1")

            db.AddInParameter(dbComm, "@DepID", DbType.String, DepID)
            db.AddInParameter(dbComm, "@DepName", DbType.String, DepName)
            db.AddInParameter(dbComm, "@FacID", DbType.String, FacID)
            db.AddInParameter(dbComm, "@FacName", DbType.String, FacName)

            Dim FeatureList As New List(Of ProductionPieceWorkGroupInfo)
            Using reader As IDataReader = db.ExecuteReader(dbComm)
                While reader.Read
                    FeatureList.Add(FillPersonnel1(reader))
                End While
                Return FeatureList
            End Using
        End Function

        Public Function FillPersonnel1(ByVal reader As IDataReader) As ProductionPieceWorkGroupInfo
            ' On Error Resume Next
            Dim psi As New ProductionPieceWorkGroupInfo
            '.....................................................................
            psi.DepID = reader("DepID").ToString
            psi.G_DepName = reader("DepName").ToString

            psi.FacID = reader("FacID").ToString
            psi.G_FacName = reader("FacName").ToString
            psi.UserDep_Fac = reader("DepID").ToString & Space(2) & reader("FacName").ToString & "--" & reader("DepName").ToString

            Return psi
        End Function

    End Class

End Namespace
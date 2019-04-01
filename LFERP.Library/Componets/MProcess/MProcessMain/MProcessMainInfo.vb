Namespace MProcessMain
    Public Class MProcessMainInfo
        Private _Pro_NO As String
        Private _PM_NO As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _PM_Sort As String
        Private _PM_EditDate As Date
        Private _PM_AddDate As Date
        Private _PM_Action As String
        Private _PM_Remark As String
        Private _PM_Check As Boolean
        Private _PM_CheckActor As String
        Private _PM_Photo As Byte()
        Private _PM_CheckDate As Date
        Private _PM_CheckRemark As String

        Private _M_Code As String
        Private _M_Name As String
        Private _M_Gauge As String

        Private _ActionName As String
        Private _CheckActionName As String

        Public Sub New()

            _Pro_NO = Nothing
            _PM_NO = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _PM_Sort = Nothing
            _PM_EditDate = Nothing
            _PM_AddDate = Nothing
            _PM_Action = Nothing
            _PM_Remark = Nothing
            _PM_Check = False
            _PM_CheckActor = Nothing
            _PM_Photo = Nothing
            _PM_CheckDate = Nothing
            _PM_CheckRemark = Nothing

            _M_Code = Nothing
            _M_Name = Nothing
            _M_Gauge = Nothing

            _ActionName = Nothing
            _CheckActionName = Nothing
        End Sub

        ''' <summary>
        ''' 工序單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 工序流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_NO() As String
            Get
                Return _PM_NO
            End Get
            Set(ByVal value As String)
                _PM_NO = value
            End Set
        End Property
        ''' <summary>
        ''' 聯豐編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        ''' <summary>
        ''' 工序類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property
        ''' <summary>
        ''' 胚類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Sort() As String
            Get
                Return _PM_Sort
            End Get
            Set(ByVal value As String)
                _PM_Sort = value
            End Set
        End Property
        ''' <summary>
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_AddDate() As Date
            Get
                Return _PM_AddDate
            End Get
            Set(ByVal value As Date)
                _PM_AddDate = value
            End Set
        End Property
        ''' <summary>
        ''' 修改日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_EditDate() As Date
            Get
                Return _PM_EditDate
            End Get
            Set(ByVal value As Date)
                _PM_EditDate = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Action() As String
            Get
                Return _PM_Action
            End Get
            Set(ByVal value As String)
                _PM_Action = value
            End Set
        End Property
        ''' <summary>
        ''' 備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Remark() As String
            Get
                Return _PM_Remark
            End Get
            Set(ByVal value As String)
                _PM_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Check() As Boolean
            Get
                Return _PM_Check
            End Get
            Set(ByVal value As Boolean)
                _PM_Check = value
            End Set
        End Property
        ''' <summary>
        ''' 審核人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CheckActor() As String
            Get
                Return _PM_CheckActor
            End Get
            Set(ByVal value As String)
                _PM_CheckActor = value
            End Set
        End Property
        ''' <summary>
        ''' 圖片
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_Photo() As Byte()
            Get
                Return _PM_Photo
            End Get
            Set(ByVal value As Byte())
                _PM_Photo = value
            End Set
        End Property
        ''' <summary>
        ''' 審核日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CheckDate() As Date
            Get
                Return _PM_CheckDate
            End Get
            Set(ByVal value As Date)
                _PM_CheckDate = value
            End Set
        End Property
        ''' <summary>
        ''' 審核備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_CheckRemark() As String
            Get
                Return _PM_CheckRemark
            End Get
            Set(ByVal value As String)
                _PM_CheckRemark = value
            End Set
        End Property
        ''' <summary>
        ''' 物料編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        ''' <summary>
        ''' 物料名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set

        End Property
        ''' <summary>
        ''' 物料規格
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property

        ''' <summary>
        ''' 操作人名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
            End Set
        End Property

        ''' <summary>
        ''' 審核人名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property CheckActionName() As String
            Get
                Return _CheckActionName
            End Get
            Set(ByVal value As String)
                _CheckActionName = value
            End Set
        End Property
    End Class

End Namespace


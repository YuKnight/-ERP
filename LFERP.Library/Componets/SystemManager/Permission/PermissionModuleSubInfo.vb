Namespace LFERP.SystemManager
    Public Class PermissionModuleSubInfo
        Private _PM_ID As String
        Private _PMS_ID As String
        Private _PMS_Name As String
        Private _PMS_Type As String
        Private _PMS_Value As String
        Private _PMS_ValueList As String
        Private _PMS_Remark As String


        Sub New()
            _PM_ID = Nothing
            _PMS_ID = Nothing
            _PMS_Name = Nothing
            _PMS_Type = Nothing
            _PMS_Value = Nothing
            _PMS_ValueList = Nothing
            _PMS_Remark = Nothing
        End Sub


        ''' <summary>
        ''' 項目ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_ID() As String
            Get
                Return _PM_ID
            End Get
            Set(ByVal value As String)
                _PM_ID = value
            End Set
        End Property

        ''' <summary>
        ''' 權限ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PMS_ID() As String
            Get
                Return _PMS_ID
            End Get
            Set(ByVal value As String)
                _PMS_ID = value
            End Set
        End Property

        ''' <summary>
        ''' 權限名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PMS_Name() As String
            Get
                Return _PMS_Name
            End Get
            Set(ByVal value As String)
                _PMS_Name = value
            End Set
        End Property

        ''' <summary>
        ''' 權限類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PMS_Type() As String
            Get
                Return _PMS_Type
            End Get
            Set(ByVal value As String)
                _PMS_Type = value
            End Set
        End Property

        ''' <summary>
        ''' 缺省直
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PMS_Value() As String
            Get
                Return _PMS_Value
            End Get
            Set(ByVal value As String)
                _PMS_Value = value
            End Set
        End Property


        ''' <summary>
        ''' 值列表
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PMS_ValueList() As String
            Get
                Return _PMS_ValueList
            End Get
            Set(ByVal value As String)
                _PMS_ValueList = value
            End Set
        End Property

        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PMS_Remark() As String
            Get
                Return _PMS_Remark
            End Get
            Set(ByVal value As String)
                _PMS_Remark = value
            End Set
        End Property

    End Class
End Namespace
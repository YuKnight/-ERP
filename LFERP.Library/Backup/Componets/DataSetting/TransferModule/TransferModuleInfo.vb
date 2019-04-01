
Namespace LFERP.DataSetting

    Public Class TransferModuleInfo
        Private _AutoID As String
        Private _ModuleID As String
        Private _ModuleDetail As String
        Private _ModuleBit As Boolean
        Private _ModuleTime As Date
        Private _ModuleRemark As String

        Sub New()
            _AutoID = 0
            _ModuleID = Nothing
            _ModuleDetail = Nothing
            _ModuleBit = False
            _ModuleTime = Nothing
            _ModuleRemark = Nothing
        End Sub

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        Public Property ModuleID() As String
            Get
                Return _ModuleID
            End Get
            Set(ByVal value As String)
                _ModuleID = value
            End Set
        End Property
        Public Property ModuleDetail() As String
            Get
                Return _ModuleDetail
            End Get
            Set(ByVal value As String)
                _ModuleDetail = value
            End Set
        End Property
        Public Property ModuleBit() As Boolean
            Get
                Return _ModuleBit
            End Get
            Set(ByVal value As Boolean)
                _ModuleBit = value
            End Set
        End Property
        Public Property ModuleTime() As Date
            Get
                Return _ModuleTime
            End Get
            Set(ByVal value As Date)
                _ModuleTime = value
            End Set
        End Property
        Public Property ModuleRemark() As String
            Get
                Return _ModuleRemark
            End Get
            Set(ByVal value As String)
                _ModuleRemark = value
            End Set
        End Property
    End Class

End Namespace


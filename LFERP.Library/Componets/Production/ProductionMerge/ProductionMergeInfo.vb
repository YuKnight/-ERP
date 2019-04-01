

Namespace LFERP.Library.ProductionMerge

    Public Class ProductionMergeInfo

        Private _PM_NO As String
        Private _Pro_MNO As String
        Private _Pro_MQty As Single
        Private _Pro_SNO As String
        Private _Pro_SQty As Single
        Private _PM_AddDate As Date
        Private _PM_Action As String
        Private _PM_Check As Boolean
        Private _FP_NO As String

        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String

        Private _MName As String
        Private _SName As String
        Private _ActionName As String

        Sub New()

            _PM_NO = Nothing
            _Pro_MNO = Nothing
            _Pro_MQty = 0
            _Pro_SNO = Nothing
            _Pro_SQty = 0
            _PM_AddDate = Nothing
            _PM_Action = Nothing
            _PM_Check = False
            _FP_NO = Nothing

            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _MName = Nothing
            _SName = Nothing
            _ActionName = Nothing

        End Sub

        Public Property PM_NO() As String
            Get
                Return _PM_NO
            End Get
            Set(ByVal value As String)
                _PM_NO = value
            End Set
        End Property
        Public Property Pro_MNO() As String
            Get
                Return _Pro_MNO
            End Get
            Set(ByVal value As String)
                _Pro_MNO = value
            End Set
        End Property
        Public Property Pro_MQty() As Single
            Get
                Return _Pro_MQty
            End Get
            Set(ByVal value As Single)
                _Pro_MQty = value
            End Set
        End Property
        Public Property Pro_SNO() As String
            Get
                Return _Pro_SNO
            End Get
            Set(ByVal value As String)
                _Pro_SNO = value
            End Set
        End Property
        Public Property Pro_SQty() As Single
            Get
                Return _Pro_SQty
            End Get
            Set(ByVal value As Single)
                _Pro_SQty = value
            End Set
        End Property
        Public Property PM_AddDate() As Date
            Get
                Return _PM_AddDate
            End Get
            Set(ByVal value As Date)
                _PM_AddDate = value
            End Set
        End Property
        Public Property PM_Action() As String
            Get
                Return _PM_Action
            End Get
            Set(ByVal value As String)
                _PM_Action = value
            End Set
        End Property
        Public Property PM_Check() As Boolean
            Get
                Return _PM_Check
            End Get
            Set(ByVal value As Boolean)
                _PM_Check = value
            End Set
        End Property
        Public Property FP_NO() As String
            Get
                Return _FP_NO
            End Get
            Set(ByVal value As String)
                _FP_NO = value
            End Set
        End Property

        Public Property Pro_Type() As String
            Get
                Return _Pro_Type
            End Get
            Set(ByVal value As String)
                _Pro_Type = value
            End Set
        End Property
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
            End Set
        End Property
        Public Property PM_Type() As String
            Get
                Return _PM_Type
            End Get
            Set(ByVal value As String)
                _PM_Type = value
            End Set
        End Property

        Public Property MName() As String
            Get
                Return _MName
            End Get
            Set(ByVal value As String)
                _SName = value
            End Set
        End Property
        Public Property SName() As String
            Get
                Return _SName
            End Get
            Set(ByVal value As String)
                _SName = value
            End Set
        End Property
        Public Property ActionName() As String
            Get
                Return _ActionName
            End Get
            Set(ByVal value As String)
                _ActionName = value
            End Set
        End Property

    End Class

End Namespace




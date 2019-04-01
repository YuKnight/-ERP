
Namespace LFERP.Library.ProductionCombination

    Public Class ProductionCombinationInfo
        Private _AutoID As String
        Private _M_ID As String
        Private _M_Type As String
        Private _M_Dep As String
        Private _Pro_Type As String

        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _Pro_NO As String
        Private _PS_Name As String '工序名稱

        Private _M_InQty As Integer
        Private _Pro_Type1 As String

        Private _PM_M_Code1 As String
        Private _PM_Type1 As String
        Private _Pro_NO1 As String
        Private _PS_Name1 As String  '工序名稱
        Private _M_OutQty As Integer
        Private _M_Date As Date

        Private _M_Action As String
        Private _M_Remark As String

        Private _M_DepName As String  '部門名稱
        Private _M_AllDepName As String  '部門全名
        Private _ActionName As String '操作員
        Private _CardID As String

        Private _PM_JiYu As String
        Private _PM_JiYu1 As String
     
        Sub New()
            _PM_JiYu = Nothing
            _PM_JiYu1 = Nothing


            _AutoID = 0
            _M_ID = Nothing
            _M_Type = Nothing
            _M_Dep = Nothing
            _Pro_Type = Nothing

            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _Pro_NO = Nothing
            _M_InQty = 0
            _Pro_Type1 = Nothing

            _PM_M_Code1 = Nothing
            _PM_Type1 = Nothing
            _Pro_NO1 = Nothing
            _M_OutQty = 0
            _M_Date = Nothing

            _M_Action = Nothing
            _M_Remark = Nothing

            _PS_Name = Nothing
            _PS_Name1 = Nothing
            _M_DepName = Nothing
            _M_AllDepName = Nothing
            _ActionName = Nothing
            _CardID = Nothing
        End Sub


        '_PM_JiYu = Nothing
        '   _PM_JiYu1 = Nothing

        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property

        Public Property PM_JiYu1() As String
            Get
                Return _PM_JiYu1
            End Get
            Set(ByVal value As String)
                _PM_JiYu1 = value
            End Set
        End Property



        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property

        Public Property M_ID() As String
            Get
                Return _M_ID
            End Get
            Set(ByVal value As String)
                _M_ID = value
            End Set
        End Property

        Public Property M_Type() As String
            Get
                Return _M_Type
            End Get
            Set(ByVal value As String)
                _M_Type = value
            End Set
        End Property

        Public Property M_Dep() As String
            Get
                Return _M_Dep
            End Get
            Set(ByVal value As String)
                _M_Dep = value
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

        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
            End Set
        End Property

        Public Property M_InQty() As Integer
            Get
                Return _M_InQty
            End Get
            Set(ByVal value As Integer)
                _M_InQty = value
            End Set
        End Property

        Public Property Pro_Type1() As String
            Get
                Return _Pro_Type1
            End Get
            Set(ByVal value As String)
                _Pro_Type1 = value
            End Set
        End Property


        Public Property PM_M_Code1() As String
            Get
                Return _PM_M_Code1
            End Get
            Set(ByVal value As String)
                _PM_M_Code1 = value
            End Set
        End Property

        Public Property PM_Type1() As String
            Get
                Return _PM_Type1
            End Get
            Set(ByVal value As String)
                _PM_Type1 = value
            End Set
        End Property

        Public Property Pro_NO1() As String
            Get
                Return _Pro_NO1
            End Get
            Set(ByVal value As String)
                _Pro_NO1 = value
            End Set
        End Property

        Public Property M_OutQty() As Integer
            Get
                Return _M_OutQty
            End Get
            Set(ByVal value As Integer)
                _M_OutQty = value
            End Set
        End Property

        Public Property M_Date() As Date
            Get
                Return _M_Date
            End Get
            Set(ByVal value As Date)
                _M_Date = value
            End Set
        End Property


        Public Property M_Action() As String
            Get
                Return _M_Action
            End Get
            Set(ByVal value As String)
                _M_Action = value
            End Set
        End Property

        Public Property M_Remark() As String
            Get
                Return _M_Remark
            End Get
            Set(ByVal value As String)
                _M_Remark = value
            End Set
        End Property

        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        Public Property PS_Name1() As String
            Get
                Return _PS_Name1
            End Get
            Set(ByVal value As String)
                _PS_Name1 = value
            End Set
        End Property
        Public Property M_DepName() As String
            Get
                Return _M_DepName
            End Get
            Set(ByVal value As String)
                _M_DepName = value
            End Set
        End Property
        Public Property M_AllDepName() As String
            Get
                Return _M_AllDepName
            End Get
            Set(ByVal value As String)
                _M_AllDepName = value
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

        Public Property CardID() As String
            Get
                Return _CardID
            End Get
            Set(ByVal value As String)
                _CardID = value
            End Set
        End Property
    End Class

End Namespace

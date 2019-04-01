Public Class PieceSumInfo

    Private _Per_NO As String   '個人計件
    Private _Per_Dismiss As Boolean
    Private _Per_PayType As String

    Private _D_AddDate As Date
    Private _D_Qty As Double
    Private _D_Price As Double
    Private _D_Check As Boolean
    Private _D_DateSalary As String
    Private _D_NorWork As String
    Private _D_OverWork As String
    Private _D_SumPiece As String
    Private _D_SumTime As String
    Private _D_Action As String

    Sub New()

        _Per_NO = Nothing
        _Per_Dismiss = False
        _Per_PayType = Nothing

        _D_AddDate = Nothing
        _D_Qty = Nothing
        _D_Price = Nothing
        _D_Check = False
        _D_DateSalary = Nothing
        _D_NorWork = Nothing
        _D_OverWork = Nothing
        _D_SumPiece = Nothing
        _D_SumTime = Nothing
        _D_Action = Nothing
    End Sub
    Public Property Per_NO() As String
        Get
            Return _Per_NO
        End Get
        Set(ByVal value As String)
            _Per_NO = value
        End Set
    End Property
    Public Property Per_Dismiss() As Boolean
        Get
            Return _Per_Dismiss
        End Get
        Set(ByVal value As Boolean)
            _Per_Dismiss = value
        End Set
    End Property
    Public Property Per_PayType() As String
        Get
            Return _Per_PayType
        End Get
        Set(ByVal value As String)
            _Per_PayType = value
        End Set
    End Property


    Public Property D_AddDate() As Date
        Get
            Return _D_AddDate
        End Get
        Set(ByVal value As Date)
            _D_AddDate = value
        End Set
    End Property
    Public Property D_Qty() As Double
        Get
            Return _D_Qty
        End Get
        Set(ByVal value As Double)
            _D_Qty = value
        End Set
    End Property
    Public Property D_Price() As Double
        Get
            Return _D_Price
        End Get
        Set(ByVal value As Double)
            _D_Price = value
        End Set
    End Property
    Public Property D_Check() As Boolean
        Get
            Return _D_Check
        End Get
        Set(ByVal value As Boolean)
            _D_Check = value
        End Set

    End Property
    Public Property D_DateSalary() As String
        Get
            Return _D_DateSalary
        End Get
        Set(ByVal value As String)
            _D_DateSalary = value
        End Set
    End Property
    Public Property D_NorWork() As String
        Get
            Return _D_NorWork
        End Get
        Set(ByVal value As String)
            _D_NorWork = value
        End Set
    End Property
    Public Property D_OverWork() As String
        Get
            Return _D_OverWork
        End Get
        Set(ByVal value As String)
            _D_OverWork = value
        End Set
    End Property
    Public Property D_SumPiece() As String
        Get
            Return _D_SumPiece
        End Get
        Set(ByVal value As String)
            _D_SumPiece = value
        End Set
    End Property
    Public Property D_SumTime() As String
        Get
            Return _D_SumTime
        End Get
        Set(ByVal value As String)
            _D_SumTime = value
        End Set

    End Property
    Public Property D_Action() As String
        Get
            Return _D_Action
        End Get
        Set(ByVal value As String)
            _D_Action = value
        End Set

    End Property

    '個人計件
End Class

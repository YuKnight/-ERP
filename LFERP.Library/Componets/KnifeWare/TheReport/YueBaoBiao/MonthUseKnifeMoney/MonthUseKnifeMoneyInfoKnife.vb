Namespace LFERP.Library.KnifeWare
    Public Class MonthUseKnifeMoneyInfoKnife

        Private _B_Type As String
        Private _WH_ID As String
        Private _B_Date As Date
        Private _BPer_Name As String
        Private _B_NO As String
        Private _Price As Double
        Private _WH_Name As String

        Public Sub New()
            _B_Type = Nothing
            _WH_ID = Nothing
            _B_Date = Nothing
            _BPer_Name = Nothing
            _B_NO = Nothing
            _Price = 0
            _WH_Name = Nothing
        End Sub

        Public Property B_Type() As String
            Get
                Return _B_Type
            End Get
            Set(ByVal value As String)
                _B_Type = value
            End Set
        End Property

        Public Property WH_ID() As String
            Get
                Return _WH_ID
            End Get
            Set(ByVal value As String)
                _WH_ID = value
            End Set
        End Property

        Public Property B_Date() As Date
            Get
                Return _B_Date
            End Get
            Set(ByVal value As Date)
                _B_Date = value
            End Set
        End Property

        Public Property BPer_Name() As String
            Get
                Return _BPer_Name
            End Get
            Set(ByVal value As String)
                _BPer_Name = value
            End Set
        End Property

        Public Property B_NO() As String
            Get
                Return _B_NO
            End Get
            Set(ByVal value As String)
                _B_NO = value
            End Set
        End Property

        Public Property Price() As Double
            Get
                Return _Price
            End Get
            Set(ByVal value As Double)
                _Price = value
            End Set
        End Property

        Public Property WH_Name() As String
            Get
                Return _WH_Name
            End Get
            Set(ByVal value As String)
                _WH_Name = value
            End Set
        End Property

    End Class
End Namespace
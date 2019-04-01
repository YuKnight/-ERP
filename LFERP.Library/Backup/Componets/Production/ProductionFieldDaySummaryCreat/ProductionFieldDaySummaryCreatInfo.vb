Namespace LFERP.Library.Production.ProductionFieldDaySummaryCreat


    Public Class ProductionFieldDaySummaryCreatInfo

        Private _Qty As Double
        Private _Pro_Type As String
        Private _PM_M_Code As String
        Private _PM_Type As String
        Private _PS_NO As String
        Private _GoIN As Boolean

        Private _Name As String

        Private _PM_JiYu As String



        Sub New()
            _PM_JiYu = Nothing
            _Name = Nothing
            _Qty = 0
            _Pro_Type = Nothing
            _PM_M_Code = Nothing
            _PM_Type = Nothing
            _PS_NO = Nothing
            _GoIN = False

        End Sub

        ''' <summary>
        ''' ¾÷¥É
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property




        Public Property Name() As String
            Get
                Return _Name
            End Get
            Set(ByVal value As String)
                _Name = value
            End Set
        End Property

        Public Property GoIN() As Boolean
            Get
                Return _GoIN
            End Get
            Set(ByVal value As Boolean)
                _GoIN = value
            End Set
        End Property

        Public Property PS_NO() As String
            Get
                Return _PS_NO
            End Get
            Set(ByVal value As String)
                _PS_NO = value
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

        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
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

        Public Property Qty() As Double
            Get
                Return _Qty
            End Get
            Set(ByVal value As Double)
                _Qty = value
            End Set
        End Property


    End Class
End Namespace

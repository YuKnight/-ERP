
Namespace LFERP.Library.ProductionException

    Public Class ProductionExceptionInfo
        Private _PE_User As String
        Private _PE_CardID As String
        Private _PE_CardName As String
        Private _PE_Remark As String
        Private _PE_Date As Date


        Private _PE_Name As String
        Private _PE_PSW As String


        Sub New()

            _PE_User = Nothing
            _PE_CardID = Nothing
            _PE_CardName = Nothing
            _PE_Remark = Nothing
            _PE_Date = Nothing

            _PE_Name = Nothing
            _PE_PSW = Nothing
        End Sub

        Property PE_User() As String
            Get
                Return _PE_User
            End Get
            Set(ByVal value As String)
                _PE_User = value
            End Set
        End Property
        Property PE_CardID() As String
            Get
                Return _PE_CardID
            End Get
            Set(ByVal value As String)
                _PE_CardID = value
            End Set
        End Property
        Property PE_CardName() As String
            Get
                Return _PE_CardName
            End Get
            Set(ByVal value As String)
                _PE_CardName = value
            End Set
        End Property
        Property PE_Remark() As String
            Get
                Return _PE_Remark
            End Get
            Set(ByVal value As String)
                _PE_Remark = value
            End Set
        End Property
        Property PE_Date() As Date
            Get
                Return _PE_Date
            End Get
            Set(ByVal value As Date)
                _PE_Date = value
            End Set
        End Property

        Property PE_Name() As String
            Get
                Return _PE_Name
            End Get
            Set(ByVal value As String)
                _PE_Name = Nothing
            End Set
        End Property

        Property PE_PSW() As String
            Get
                Return _PE_PSW
            End Get
            Set(ByVal value As String)
                _PE_PSW = value
            End Set
        End Property

    End Class

End Namespace


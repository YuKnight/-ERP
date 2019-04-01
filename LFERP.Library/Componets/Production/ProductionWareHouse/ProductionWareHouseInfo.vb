
Namespace LFERP.Library.ProductionWareHouse

    Public Class ProductionWareHouseInfo

        Private _PH_ID As String
        Private _PH_PID As String
        Private _PH_Name As String
        Private _PH_Key As String

        Sub New()

            _PH_ID = Nothing
            _PH_PID = Nothing
            _PH_Name = Nothing
            _PH_Key = Nothing

        End Sub

        Public Property PH_ID() As String
            Get
                Return _PH_ID
            End Get
            Set(ByVal value As String)
                _PH_ID = value
            End Set
        End Property

        Public Property PH_Name() As String
            Get
                Return _PH_Name
            End Get
            Set(ByVal value As String)
                _PH_Name = value
            End Set
        End Property
        Public Property PH_PID() As String
            Get
                Return _PH_PID
            End Get
            Set(ByVal value As String)
                _PH_PID = value
            End Set
        End Property
        Public Property PH_Key() As String
            Get
                Return _PH_Key
            End Get
            Set(ByVal value As String)
                _PH_Key = value
            End Set
        End Property


    End Class

End Namespace


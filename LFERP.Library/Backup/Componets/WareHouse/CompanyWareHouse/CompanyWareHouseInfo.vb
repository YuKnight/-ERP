Namespace LFERP.Library.CompanyWareHouse 
    Public Class CompanyWareHouseInfo

        Private _AutoID As Decimal
        Private _CompanyID As String
        Private _WH_ID As String
        Public Sub New()
            _AutoID = 0
            _CompanyID = Nothing
            _WH_ID = Nothing

        End Sub
        Public Property AutoID() As Decimal
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Decimal)
                _AutoID = value
            End Set
        End Property
        Public Property CompanyID() As String
            Get
                Return _CompanyID
            End Get
            Set(ByVal value As String)
                _CompanyID = value
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

    End Class
End Namespace
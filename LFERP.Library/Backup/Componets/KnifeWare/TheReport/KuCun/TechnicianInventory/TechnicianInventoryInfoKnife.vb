Namespace LFERP.Library.KnifeWare
    Public Class TechnicianInventoryInfoKnife

        Private _B_Type As String
        Private _BPer_Name As String
        Private _BPer_ID As String
        Private _Per_Name As String
        Private _Per_ID As String
        Private _M_Name As String
        Private _M_Type As String
        Private _M_Gauge As String
        Private _NOReturn As Double
        Private _B_NO As String
        Private _B_Remark As String

        Public Sub New()

            _B_Type = Nothing
            _BPer_Name = Nothing
            _BPer_ID = Nothing
            _Per_Name = Nothing
            _Per_ID = Nothing
            _M_Name = Nothing
            _M_Type = Nothing
            _M_Gauge = Nothing
            _NOReturn = 0
            _B_NO = Nothing
            _B_Remark = Nothing

        End Sub

        Public Property B_Type() As String
            Get
                Return _B_Type
            End Get
            Set(ByVal value As String)
                _B_Type = value
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

        Public Property BPer_ID() As String
            Get
                Return _BPer_ID
            End Get
            Set(ByVal value As String)
                _BPer_ID = value
            End Set
        End Property

        Public Property Per_Name() As String
            Get
                Return _Per_Name
            End Get
            Set(ByVal value As String)
                _Per_Name = value
            End Set
        End Property

        Public Property Per_ID() As String
            Get
                Return _Per_ID
            End Get
            Set(ByVal value As String)
                _Per_ID = value
            End Set
        End Property

        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
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

        Public Property M_Gauge() As String
            Get
                Return _M_Gauge
            End Get
            Set(ByVal value As String)
                _M_Gauge = value
            End Set
        End Property

        Public Property NOReturn() As String
            Get
                Return _NOReturn
            End Get
            Set(ByVal value As String)
                _NOReturn = value
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

        Public Property B_Remark() As String
            Get
                Return _B_Remark
            End Get
            Set(ByVal value As String)
                _B_Remark = value
            End Set
        End Property


    End Class
End Namespace
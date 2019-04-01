

Namespace LFERP.DataSetting

    Public Class MeGaShareInfo
        Private _Company_ID As String                  '英文簡寫
        Private _Company_Name As String            '中文簡稱
        Private _Company_NO As String                '數字代號        @2012/8/28  添加

        Private _Department_ID As String
        Private _Department_Name As String

        Sub New()
            _Company_ID = Nothing
            _Company_Name = Nothing
            _Company_NO = Nothing
            _Department_ID = Nothing
            _Department_Name = Nothing

        End Sub

        Public Property Company_ID() As String
            Get
                Return _Company_ID
            End Get
            Set(ByVal value As String)
                _Company_ID = value
            End Set
        End Property
        Public Property Company_Name() As String
            Get
                Return _Company_Name
            End Get
            Set(ByVal value As String)
                _Company_Name = value
            End Set
        End Property
        Public Property Company_NO() As String
            Get
                Return _Company_NO
            End Get
            Set(ByVal value As String)
                _Company_NO = value
            End Set
        End Property
        Public Property Department_ID() As String
            Get
                Return _Department_ID
            End Get
            Set(ByVal value As String)
                _Department_ID = value
            End Set
        End Property
        Public Property Department_Name() As String
            Get
                Return _Department_Name
            End Get
            Set(ByVal value As String)
                _Department_Name = value
            End Set
        End Property
    End Class

End Namespace


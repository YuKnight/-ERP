Namespace LFERP.Library.Production.Datasetting


    Public Class ProductionDataSettingInfo

        Private _UserID As String
        Private _PM_M_Code As String

        Private _FP_OutDep As String
        Private _Pro_Type As String
        Private _PM_Type As String
        Private _Pro_NO As String

        Private _FP_InDep As String
        Private _FP_InName As String  '³¡ªù¦WºÙ
        Private _PM_JiYu As String
        Private _PS_NO As String
        Private _PS_Name As String

    

        Sub New()

            _PM_JiYu = Nothing

            _UserID = Nothing
            _PM_M_Code = Nothing
            _FP_OutDep = Nothing
            _Pro_Type = Nothing
            _PM_Type = Nothing
            _Pro_NO = Nothing
            _FP_InDep = Nothing
            _FP_InName = Nothing
            _PS_NO = Nothing
            _PS_Name = Nothing

        End Sub

        Public Property PM_JiYu() As String
            Get
                Return _PM_JiYu
            End Get
            Set(ByVal value As String)
                _PM_JiYu = value
            End Set
        End Property

        Public Property UserID() As String
            Get
                Return _UserID
            End Get
            Set(ByVal value As String)
                _UserID = value
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
        Public Property FP_OutDep() As String
            Get
                Return _FP_OutDep
            End Get
            Set(ByVal value As String)
                _FP_OutDep = value
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
        Public Property FP_InDep() As String
            Get
                Return _FP_InDep
            End Get
            Set(ByVal value As String)
                _FP_InDep = value
            End Set
        End Property
        Public Property FP_InName() As String
            Get
                Return _FP_InName
            End Get
            Set(ByVal value As String)
                _FP_InName = value
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
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
    End Class

End Namespace
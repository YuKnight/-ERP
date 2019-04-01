Namespace MProcessSub
    Public Class MProcessSubInfo
        Private _Pro_NO As String
        Private _PS_Num As String
        Private _PS_Cixu As String
        Private _PS_DPT_ID As String
        Private _PS_Name As String
        Private _PS_PaiXu As String
        Private _PS_Enable As Boolean
        Private _PS_OutPut As Double
        Private _PS_Remark As String
        Private _PS_Check As Boolean
        Public Sub New()
            _Pro_NO = Nothing
            _PS_Num = Nothing
            _PS_Cixu = Nothing
            _PS_DPT_ID = Nothing
            _PS_Name = Nothing
            _PS_PaiXu = Nothing
            _PS_Enable = False
            _PS_OutPut = Nothing
            _PS_Remark = Nothing
            _PS_Check = False
        End Sub
        ''' <summary>
        ''' 工藝單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Pro_NO() As String
            Get
                Return _Pro_NO
            End Get
            Set(ByVal value As String)
                _Pro_NO = value
            End Set
        End Property

        ''' <summary>
        ''' 工序流水號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Num() As String
            Get
                Return _PS_Num
            End Get
            Set(ByVal value As String)
                _PS_Num = value
            End Set
        End Property

        ''' <summary>
        ''' 工序次序
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Cixu() As String
            Get
                Return _PS_Cixu
            End Get
            Set(ByVal value As String)
                _PS_Cixu = value
            End Set
        End Property
        ''' <summary>
        ''' 部門編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_DPT_ID() As String
            Get
                Return _PS_DPT_ID
            End Get
            Set(ByVal value As String)
                _PS_DPT_ID = value
            End Set
        End Property
        ''' <summary>
        ''' 工序名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Name() As String
            Get
                Return _PS_Name
            End Get
            Set(ByVal value As String)
                _PS_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 排序序號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_PaiXu() As String
            Get
                Return _PS_PaiXu
            End Get
            Set(ByVal value As String)
                _PS_PaiXu = value
            End Set
        End Property
        ''' <summary>
        ''' 是否啟用
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Enable() As Boolean
            Get
                Return _PS_Enable
            End Get
            Set(ByVal value As Boolean)
                _PS_Enable = value
            End Set
        End Property
        ''' <summary>
        ''' 日產量
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_OutPut() As Double
            Get
                Return _PS_OutPut
            End Get
            Set(ByVal value As Double)
                _PS_OutPut = value
            End Set
        End Property
        ''' <summary>
        ''' 注意事項
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Remark() As String
            Get
                Return _PS_Remark
            End Get
            Set(ByVal value As String)
                _PS_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 是否審核
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PS_Check() As Boolean
            Get
                Return _PS_Check
            End Get
            Set(ByVal value As Boolean)
                _PS_Check = value
            End Set
        End Property
    End Class
End Namespace


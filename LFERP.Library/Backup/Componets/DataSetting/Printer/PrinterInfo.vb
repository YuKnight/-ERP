Namespace LFERP.DataSetting

    Public Class PrinterInfo
        Private _p_ip As String
        Private _p_name As String
        Private _p_remark As String
        Sub New()
            _p_ip = ""
            _p_name = ""
            _p_remark = ""
        End Sub
        Public Property P_IP() As String
            Get
                Return _p_ip
            End Get
            Set(ByVal value As String)
                _p_ip = value
            End Set
        End Property
        Public Property P_Name() As String
            Get
                Return _p_name
            End Get
            Set(ByVal value As String)
                _p_name = value
            End Set
        End Property
        Public Property P_Remark() As String
            Get
                Return _p_remark
            End Get
            Set(ByVal value As String)
                _p_remark = value
            End Set
        End Property

    End Class

End Namespace


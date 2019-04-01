

Namespace LFERP.DataSetting
    Public Class TarriffInfo
        Private _Tarriff_Value As String
        Private _Tarriff_Name As String

        Sub New()
            _Tarriff_Value = ""
            _Tarriff_Name = ""
        End Sub


        Public Property Tarriff_Value() As String
            Get
                Return _Tarriff_Value
            End Get
            Set(ByVal value As String)
                _Tarriff_Value = value
            End Set
        End Property


        Public Property Tarriff_Name() As String
            Get
                Return _Tarriff_Name
            End Get
            Set(ByVal value As String)
                _Tarriff_Name = value
            End Set
        End Property

    End Class
End Namespace
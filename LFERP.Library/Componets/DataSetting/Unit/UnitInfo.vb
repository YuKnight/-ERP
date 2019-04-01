
Namespace LFERP.DataSetting
    Public Class UnitInfo
        Private _u_id As String
        Private _u_name As String

        Public Sub New()
            _u_id = ""
            _u_name = ""
        End Sub
        ''' <summary>
        ''' 單位代號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property U_ID() As String
            Get
                Return _u_id
            End Get
            Set(ByVal value As String)
                _u_id = value
            End Set
        End Property
        ''' <summary>
        ''' 單位名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property U_Name() As String
            Get
                Return _u_name
            End Get
            Set(ByVal value As String)
                _u_name = value
            End Set
        End Property
    End Class
End Namespace



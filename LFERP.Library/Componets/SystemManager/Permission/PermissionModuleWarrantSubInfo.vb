Namespace LFERP.SystemManager
    Public Class PermissionModuleWarrantSubInfo
        Private _U_ID As String
        Private _PMS_ID As String
        Private _PMWS_Value As String


        Sub New()
            _U_ID = Nothing
            _PMS_ID = Nothing
            _PMWS_Value = Nothing
        End Sub

        ''' <summary>
        ''' •Œ§·ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property U_ID() As String
            Get
                Return _U_ID
            End Get
            Set(ByVal value As String)
                _U_ID = value
            End Set
        End Property

        ''' <summary>
        ''' ≈v≠≠ID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PMS_ID() As String
            Get
                Return _PMS_ID
            End Get
            Set(ByVal value As String)
                _PMS_ID = value
            End Set
        End Property

        ''' <summary>
        ''' ≈v≠≠≠»
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PMWS_Value() As String
            Get
                Return _PMWS_Value
            End Get
            Set(ByVal value As String)
                _PMWS_Value = value
            End Set
        End Property
    End Class
End Namespace
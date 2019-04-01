
Namespace LFERP.Library.SampleManager.SamplePace
    Public Class SamplePaceQueryInfo
        Private _SO_ID As String
        Private _SE_OutD_Dep As String
        Private _SE_OutPS_Name As String
        Private _SE_OutTime As Date
        Private _SE_InD_Dep As String
        Private _SE_InPS_Name As String
        Private _SE_InTime As Date
        Private _SE_InCheck As Boolean
        Private _SE_InCheckActionName As String
        Private _Code_ID As String
        Private _SE_OutCardIDName As String
        Private _SE_InCardIDName As String
        Private _SE_TypeName As String
        Private _SE_ID As String
        Private _SO_SampleID As String

        Public Sub New()
            _SO_ID = Nothing
            _SE_OutD_Dep = Nothing
            _SE_OutPS_Name = Nothing
            _SE_OutTime = Nothing
            _SE_InD_Dep = Nothing
            _SE_InPS_Name = Nothing
            _SE_InTime = Nothing
            _SE_InCheck = Nothing
            _SE_InCheckActionName = Nothing
            _Code_ID = Nothing
            _SE_OutCardIDName = Nothing
            _SE_InCardIDName = Nothing
            _SE_TypeName = Nothing
            _SE_ID = Nothing
            _SO_SampleID = Nothing
        End Sub
        Public Property SO_SampleID() As String
            Get
                Return _SO_SampleID
            End Get
            Set(ByVal value As String)
                _SO_SampleID = value
            End Set
        End Property
        Public Property SE_ID() As String
            Get
                Return _SE_ID
            End Get
            Set(ByVal value As String)
                _SE_ID = value
            End Set
        End Property
        Public Property SE_TypeName() As String
            Get
                Return _SE_TypeName
            End Get
            Set(ByVal value As String)
                _SE_TypeName = value
            End Set
        End Property
        Public Property SE_InCardIDName() As String
            Get
                Return _SE_InCardIDName
            End Get
            Set(ByVal value As String)
                _SE_InCardIDName = value
            End Set
        End Property

        Public Property SE_OutCardIDName() As String
            Get
                Return _SE_OutCardIDName
            End Get
            Set(ByVal value As String)
                _SE_OutCardIDName = value
            End Set
        End Property

        Public Property SO_ID() As String
            Get
                Return _SO_ID
            End Get
            Set(ByVal value As String)
                _SO_ID = value
            End Set
        End Property
        Public Property SE_OutD_Dep() As String
            Get
                Return _SE_OutD_Dep
            End Get
            Set(ByVal value As String)
                _SE_OutD_Dep = value
            End Set
        End Property
        Public Property SE_OutPS_Name() As String
            Get
                Return _SE_OutPS_Name
            End Get
            Set(ByVal value As String)
                _SE_OutPS_Name = value
            End Set
        End Property
        Public Property SE_OutTime() As Date
            Get
                Return _SE_OutTime
            End Get
            Set(ByVal value As Date)
                _SE_OutTime = value
            End Set
        End Property
        Public Property SE_InD_Dep() As String
            Get
                Return _SE_InD_Dep
            End Get
            Set(ByVal value As String)
                _SE_InD_Dep = value
            End Set
        End Property
        Public Property SE_InPS_Name() As String
            Get
                Return _SE_InPS_Name
            End Get
            Set(ByVal value As String)
                _SE_InPS_Name = value
            End Set
        End Property

        Public Property SE_InTime() As Date
            Get
                Return _SE_InTime
            End Get
            Set(ByVal value As Date)
                _SE_InTime = value
            End Set
        End Property
        Public Property SE_InCheck() As Boolean
            Get
                Return _SE_InCheck
            End Get
            Set(ByVal value As Boolean)
                _SE_InCheck = value
            End Set
        End Property
        Public Property SE_InCheckActionName() As String
            Get
                Return _SE_InCheckActionName
            End Get
            Set(ByVal value As String)
                _SE_InCheckActionName = value
            End Set
        End Property
        Public Property Code_ID() As String
            Get
                Return _Code_ID
            End Get
            Set(ByVal value As String)
                _Code_ID = value
            End Set
        End Property

    End Class
End Namespace
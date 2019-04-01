
Namespace LFERP.Library.MessageMain


    Public Class MessageMainInfo


        Private _MS_ID As String
        Private _MS_Priority As String
        Private _MS_Read As String
        Private _MS_Attachment As String
        Private _MS_Subject As String
        Private _MS_From As String
        Private _MS_To As String
        Private _MS_SendDate As Date
        Private _MS_ReceivedDate As Date
        Private _MS_TypeID As String
        Private _MS_Content As String
        Private _MS_FromName As String
        Private _MS_InUserID As String

        Private _MS_AttachID As String
        Private _MS_ModuleID As String
        Private _MS_DanJuID As String
        Private _MS_AttachName As String
        Private _MS_SendType As String




        Public Sub New()
            _MS_ID = Nothing
            _MS_Priority = "0"
            _MS_Read = "0"
            _MS_Attachment = "0"
            _MS_Subject = Nothing
            _MS_From = Nothing
            _MS_To = Nothing
            _MS_SendDate = Nothing
            _MS_ReceivedDate = Nothing
            _MS_TypeID = Nothing
            _MS_Content = ""
            _MS_InUserID = Nothing
            _MS_FromName = Nothing

            _MS_AttachID = Nothing
            _MS_ModuleID = Nothing
            _MS_DanJuID = Nothing
            _MS_AttachName = Nothing
            _MS_SendType = Nothing


        End Sub

        ''' <summary>
        ''' ³æ¸¹
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property MS_ID() As String
            Get
                Return _MS_ID
            End Get
            Set(ByVal value As String)
                _MS_ID = value
            End Set
        End Property

        Public Property MS_Priority() As String
            Get
                Return _MS_Priority
            End Get
            Set(ByVal value As String)
                _MS_Priority = value
            End Set
        End Property
        Public Property MS_Read() As String
            Get
                Return _MS_Read
            End Get
            Set(ByVal value As String)
                _MS_Read = value
            End Set
        End Property
        Public Property MS_Attachment() As String
            Get
                Return _MS_Attachment
            End Get
            Set(ByVal value As String)
                _MS_Attachment = value
            End Set
        End Property
        Public Property MS_Subject() As String
            Get
                Return _MS_Subject
            End Get
            Set(ByVal value As String)
                _MS_Subject = value
            End Set
        End Property
        Public Property MS_From() As String
            Get
                Return _MS_From
            End Get
            Set(ByVal value As String)
                _MS_From = value
            End Set
        End Property
        Public Property MS_To() As String
            Get
                Return _MS_To
            End Get
            Set(ByVal value As String)
                _MS_To = value
            End Set
        End Property
        Public Property MS_SendDate() As Date
            Get
                Return _MS_SendDate
            End Get
            Set(ByVal value As Date)
                _MS_SendDate = value
            End Set
        End Property
        Public Property MS_ReceivedDate() As Date
            Get
                Return _MS_ReceivedDate
            End Get
            Set(ByVal value As Date)
                _MS_ReceivedDate = value
            End Set
        End Property
        Public Property MS_TypeID() As String
            Get
                Return _MS_TypeID
            End Get
            Set(ByVal value As String)
                _MS_TypeID = value
            End Set

        End Property

        Public Property MS_Content() As String
            Get
                Return _MS_Content
            End Get
            Set(ByVal value As String)
                _MS_Content = value
            End Set

        End Property

        Public Property MS_FromName() As String
            Get
                Return _MS_FromName
            End Get
            Set(ByVal value As String)
                _MS_FromName = value
            End Set
        End Property
        Public Property MS_InUserID() As String
            Get
                Return _MS_InUserID
            End Get
            Set(ByVal value As String)
                _MS_InUserID = value
            End Set
        End Property

        Public Property MS_AttachID() As String
            Get
                Return _MS_AttachID
            End Get
            Set(ByVal value As String)
                _MS_AttachID = value
            End Set

        End Property
        Public Property MS_ModuleID() As String
            Get
                Return _MS_ModuleID
            End Get
            Set(ByVal value As String)
                _MS_ModuleID = value
            End Set

        End Property
        Public Property MS_DanJuID() As String
            Get
                Return _MS_DanJuID
            End Get
            Set(ByVal value As String)
                _MS_DanJuID = value
            End Set

        End Property
        Public Property MS_AttachName() As String
            Get
                Return _MS_AttachName
            End Get
            Set(ByVal value As String)
                _MS_AttachName = value
            End Set

        End Property
        Public Property MS_SendType() As String
            Get
                Return _MS_SendType
            End Get
            Set(ByVal value As String)
                _MS_SendType = value
            End Set

        End Property






    End Class



End Namespace
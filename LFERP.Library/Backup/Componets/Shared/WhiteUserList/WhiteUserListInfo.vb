
Namespace LFERP.Library.Shared

    Public Class WhiteuserListInfo

        Private _w_userid As String
        Private _dpt_id As String
        Private _wh_id As String
        Private _w_username As String
        Private _w_remark As String

        Private _dpt_name As String
        Private _dpt_pid As String


        Private _WareIn As Boolean
        Private _WareOut As Boolean
        Private _WareChange As Boolean


        Sub New()
            _w_userid = ""
            _dpt_id = ""
            _wh_id = ""
            _w_username = ""
            _w_remark = ""

            _dpt_name = ""
            _dpt_pid = ""

            _WareIn = False
            _WareOut = False
            _WareChange = False

        End Sub
        ''' <summary>
        ''' 工號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property W_UserID() As String
            Get
                Return _w_userid
            End Get
            Set(ByVal value As String)
                _w_userid = value
            End Set
        End Property
        ''' <summary>
        ''' 部門編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DPT_ID() As String
            Get
                Return _dpt_id
            End Get
            Set(ByVal value As String)
                _dpt_id = value
            End Set
        End Property
        ''' <summary>
        ''' 倉庫編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property WH_ID() As String
            Get
                Return _wh_id
            End Get
            Set(ByVal value As String)
                _wh_id = value
            End Set
        End Property
        ''' <summary>
        ''' 員工姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property W_UserName() As String
            Get
                Return _w_username
            End Get
            Set(ByVal value As String)
                _w_username = value
            End Set
        End Property
        ''' <summary>
        ''' 備註
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property W_Remark() As String
            Get
                Return _w_remark
            End Get
            Set(ByVal value As String)
                _w_remark = value
            End Set
        End Property

        Public Property DPT_Name() As String
            Get
                Return _dpt_name
            End Get
            Set(ByVal value As String)
                _dpt_name = value
            End Set
        End Property
        Public Property DPT_PID() As String
            Get
                Return _dpt_pid
            End Get
            Set(ByVal value As String)
                _dpt_pid = value
            End Set
        End Property

        Public Property WareIn() As Boolean
            Get
                Return _WareIn
            End Get
            Set(ByVal value As Boolean)
                _WareIn = value
            End Set
        End Property

        Public Property WareOut() As Boolean
            Get
                Return _WareOut
            End Get
            Set(ByVal value As Boolean)
                _WareOut = value
            End Set
        End Property

        Public Property WareChange() As Boolean
            Get
                Return _WareChange
            End Get
            Set(ByVal value As Boolean)
                _WareChange = value
            End Set
        End Property


    End Class

End Namespace


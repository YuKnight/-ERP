Namespace LFERP.Library.WareHouse
    Public Class WareHouseInfo
        Private _wh_id As String
        Private _wh_name As String
        Private _wh_pid As String
        Private _wh_key As String
        Private _wh_remark As String
        Private _wh_action As String
        Private _co_id As String
        Private _NeedCheck As Boolean
        Private _PrintBulk As String
        Private _WH_AllName As String

        Private _NeedCheckInput As Boolean '2013-5-13針對磨刀部,入庫指定倉庫刷卡

        Public Sub New()
            _wh_id = ""
            _wh_name = ""
            _wh_pid = ""
            _wh_key = ""
            _wh_remark = ""
            _wh_action = ""
            _co_id = ""
            _NeedCheck = Nothing
            _PrintBulk = Nothing
            _WH_AllName = Nothing


            _NeedCheckInput = False
        End Sub


        Public Property NeedCheckInput() As Boolean
            Get
                Return _NeedCheckInput
            End Get
            Set(ByVal value As Boolean)
                _NeedCheckInput = value
            End Set
        End Property
        Public Property WH_AllName() As String
            Get
                Return _WH_AllName
            End Get
            Set(ByVal value As String)
                _WH_AllName = value
            End Set
        End Property
 
        Public Property WH_ID() As String
            Get
                Return _wh_id
            End Get
            Set(ByVal value As String)
                _wh_id = value
            End Set
        End Property
        Public Property WH_Name() As String
            Get
                Return _wh_name
            End Get
            Set(ByVal value As String)
                _wh_name = value
            End Set
        End Property
        Public Property WH_PID() As String
            Get
                Return _wh_pid
            End Get
            Set(ByVal value As String)
                _wh_pid = value
            End Set
        End Property
        Public Property WH_Key() As String
            Get
                Return _wh_key
            End Get
            Set(ByVal value As String)
                _wh_key = value
            End Set
        End Property
        Public Property WH_Remark() As String
            Get
                Return _wh_remark
            End Get
            Set(ByVal value As String)
                _wh_remark = value
            End Set
        End Property
        Public Property WH_Action() As String
            Get
                Return _wh_action
            End Get
            Set(ByVal value As String)
                _wh_action = value
            End Set
        End Property
        Public Property CO_ID() As String
            Get
                Return _co_id
            End Get
            Set(ByVal value As String)
                _co_id = value
            End Set
        End Property


        Public Property NeedCheck() As Boolean
            Get
                Return _NeedCheck
            End Get
            Set(ByVal value As Boolean)
                _NeedCheck = value
            End Set
        End Property



        Public Property PrintBulk() As String
            Get
                Return _PrintBulk
            End Get
            Set(ByVal value As String)
                _PrintBulk = value
            End Set
        End Property
    End Class
End Namespace


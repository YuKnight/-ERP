Namespace LFERP.Library.ProductionPiecePersonnelDay

    Public Class ProductionPiecePersonnelDayInfo
        Private _AutoID As String
        Private _Per_NO As String '              *  nvarchar(50)                  /員工工號
        Private _Per_Name As String '            *  nvarchar(50)                  /員工名稱
        Private _G_NO As String '             *  nvarchar(50)                  /組別編號
        Private _DepID As String '             *  nvarchar(50)                  /部門編號
        Private _FacID As String '             *  nvarchar(50)                  /廠別
        Private _Per_PayType As String '        *  nvarchar(50)                  /薪金類型
        Private _Per_Date As String      '      *  datetime                      /建立日期
        Private _Per_Action As String ''       *  nvarchar(50)                  /操作人
        Private _Per_Remark As String       ' *  nvarchar(MAX)                 /備注
        Private _Per_Resign As Boolean         ' *  bit                           /是否已辭工
        Private _Per_DayPrice As Double '日薪

        Private _Per_ActionName As String '  人員基本信息人名
        Private _Per_G_Name As String '      組別名稱'
        Private _Per_DepName As String '  部門名稱
        Private _Per_FacName As String '廠別名稱

        '
        Private _Now_Date As String  ''日更新員工名單時的日期
        Private _Load_Date As String '要求導入的指定日期

        Private _Per_Num As String

        Private _Per_NOName As String  '工號 姓名

        Private _Per_Class As String    '班制

        Sub New()
            _Per_NO = Nothing
            _Per_Name = Nothing
            _G_NO = Nothing
            _DepID = Nothing
            _FacID = Nothing

            _Per_PayType = Nothing
            _Per_Date = Nothing
            _Per_Action = Nothing
            _Per_Remark = Nothing

            _Per_Resign = False
            _Per_ActionName = Nothing
            _Per_G_Name = Nothing
            _Per_DepName = Nothing

            _Per_FacName = Nothing
            _Per_DayPrice = 0
            _AutoID = Nothing

            _Per_Num = Nothing
            _Per_NOName = Nothing

            _Per_Class = Nothing

        End Sub
        ''' <summary>
        ''' 工號-姓名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_NOName() As String
            Get
                Return _Per_NOName
            End Get
            Set(ByVal value As String)
                _Per_NOName = value
            End Set
        End Property

        ''' <summary>
        ''' 同一批導入的員工自編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Num() As String
            Get
                Return _Per_Num
            End Get
            Set(ByVal value As String)
                _Per_Num = value
            End Set
        End Property

        Public Property AutoID() As String
            Get
                Return _AutoID
            End Get
            Set(ByVal value As String)
                _AutoID = value
            End Set
        End Property
        ''' <summary>
        ''' 員工編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_NO() As String
            Get
                Return _Per_NO
            End Get
            Set(ByVal value As String)
                _Per_NO = value
            End Set
        End Property

        ''' <summary>
        ''' 員工名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Name() As String
            Get
                Return _Per_Name
            End Get
            Set(ByVal value As String)
                _Per_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 組別編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property G_NO() As String
            Get
                Return _G_NO
            End Get
            Set(ByVal value As String)
                _G_NO = value
            End Set
        End Property

        ''' <summary>
        ''' 部門編號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DepID() As String
            Get
                Return _DepID
            End Get
            Set(ByVal value As String)
                _DepID = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property FacID() As String
            Get
                Return _FacID
            End Get
            Set(ByVal value As String)
                _FacID = value
            End Set
        End Property
        ''' <summary>
        ''' 蔪金類型
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_PayType() As String
            Get
                Return _Per_PayType
            End Get
            Set(ByVal value As String)
                _Per_PayType = value
            End Set
        End Property

        ''' <summary>
        ''' 建 立時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Date() As String
            Get
                Return _Per_Date
            End Get
            Set(ByVal value As String)
                _Per_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員號碼
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Action() As String
            Get
                Return _Per_Action
            End Get
            Set(ByVal value As String)
                _Per_Action = value
            End Set
        End Property
        ''' <summary>
        ''' 備注信息
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Remark() As String
            Get
                Return _Per_Remark
            End Get
            Set(ByVal value As String)
                _Per_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 是否已辭工
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Resign() As Boolean
            Get
                Return _Per_Resign
            End Get
            Set(ByVal value As Boolean)
                _Per_Resign = value
            End Set
        End Property
        '--------------------連接字段

        ''' <summary>
        '''    'Per_ActionName  人員基本信息人名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_ActionName() As String
            Get
                Return _Per_ActionName
            End Get
            Set(ByVal value As String)
                _Per_ActionName = value
            End Set
        End Property

        ''' <summary>
        '''Per_G_Name      組別名稱'
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_G_Name() As String
            Get
                Return _Per_G_Name
            End Get
            Set(ByVal value As String)
                _Per_G_Name = value
            End Set
        End Property

        ''' <summary>
        '''     'Per_DPT_ID_Name  部門名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_DepName() As String
            Get
                Return _Per_DepName
            End Get
            Set(ByVal value As String)
                _Per_DepName = value
            End Set
        End Property
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_FacName() As String
            Get
                Return _Per_FacName
            End Get
            Set(ByVal value As String)
                _Per_FacName = value
            End Set
        End Property
        ''' <summary>
        ''' 日薪
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_DayPrice() As Double
            Get
                Return _Per_DayPrice
            End Get
            Set(ByVal value As Double)
                _Per_DayPrice = value
            End Set
        End Property

        'Private _Now_Date As String  ''日更新員工名單時的日期
        'Private _Load_Date As String '要求導入的指定日期
        ''' <summary>
        ''' 要求導入員工信息的時間，一般為當前日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Now_Date() As String
            Get
                Return _Now_Date
            End Get
            Set(ByVal value As String)
                _Now_Date = value
            End Set
        End Property

        ''' <summary>
        ''' 被導入的員工信息日期，一般為前一工作日
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Load_Date() As String
            Get
                Return _Load_Date
            End Get
            Set(ByVal value As String)
                _Load_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 班制
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Per_Class() As String
            Get
                Return _Per_Class
            End Get
            Set(ByVal value As String)
                _Per_Class = value
            End Set
        End Property

    End Class
End Namespace
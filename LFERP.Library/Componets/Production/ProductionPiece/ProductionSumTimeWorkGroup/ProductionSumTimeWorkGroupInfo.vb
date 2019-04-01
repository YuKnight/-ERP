Namespace LFERP.Library.ProductionSumTimeWorkGroup

    Public Class ProductionSumTimeWorkGroupInfo

        Private _GT_NO As String '             *  nvarchar(50)                /計時單號
        Private _Per_NO As String '            *  nvarchar(50)                /員工編號
        Private _G_NO As String '              *  nvarchar(50)                /組別編號
        Private _DepID As String '             *  nvarchar(50)                /部門編號
        Private _FacID As String '             *  nvarchar(50)                /廠別

        Private _GT_BeginTime As String '       *  nvarchar(50)                /計時開始時間
        Private _GT_EndTime As String '         *  nvarchar(50)                /計時結束時間
        Private _GT_Total As Double '         *  float                       /總計時間    
        Private _GT_Date As String '           *  datetime                    /建立日期
        Private _GT_Action As String '        *  nvarchar(50)                /操作人

        Private _GT_Remark As String '         *  nvarchar(MAX)               /備注

        '外表字段
        Private _GT_ActionName As String '  操作員名 
        Private _GT_Per_Name As String '    員工名姓名(ProductionPiecePersonnel)
        Private _GT_DepName As String '     部門名
        Private _GT_FacName As String '     廠別名
        Private _GT_G_Name As String '      組別名(ProductionPieceWorkGroup)

        Private _GT_DateStart As String  ''打印用
        Private _GT_DateEnd As String
        Private _Print_Action As String

        Private _SampPrice As Double
        Private _SampID As String
        Private _SampName As String

        Sub New()

            _GT_DateStart = Nothing
            _GT_DateEnd = Nothing
            _Print_Action = Nothing


            _GT_NO = Nothing
            _Per_NO = Nothing
            _G_NO = Nothing
            _DepID = Nothing
            _FacID = Nothing

            _GT_BeginTime = Nothing
            _GT_EndTime = Nothing
            _GT_Total = 0
            _GT_Date = Nothing
            _GT_Action = Nothing

            _GT_Remark = Nothing

            ''外表
            _GT_ActionName = Nothing
            _GT_Per_Name = Nothing
            _GT_DepName = Nothing
            _GT_FacName = Nothing
            _GT_G_Name = Nothing

            _SampID = Nothing
            _SampPrice = 0
            _SampName = Nothing

        End Sub

        Public Property SampPrice() As Double
            Get
                Return _SampPrice
            End Get
            Set(ByVal value As Double)
                _SampPrice = value
            End Set
        End Property

        Public Property SampID() As String
            Get
                Return _SampID
            End Get
            Set(ByVal value As String)
                _SampID = value
            End Set
        End Property

        Public Property SampName() As String
            Get
                Return _SampName
            End Get
            Set(ByVal value As String)
                _SampName = value
            End Set
        End Property

        ''' <summary>
        ''' 打印時間段
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_DateStart() As String
            Get
                Return _GT_DateStart
            End Get
            Set(ByVal value As String)
                _GT_DateStart = value
            End Set
        End Property

        ''' <summary>
        ''' 打印時間段
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_DateEnd() As String
            Get
                Return _GT_DateEnd
            End Get
            Set(ByVal value As String)
                _GT_DateEnd = value
            End Set
        End Property

        ''' <summary>
        ''' 打印人名稱
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Print_Action() As String
            Get
                Return _Print_Action
            End Get
            Set(ByVal value As String)
                _Print_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 計時單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_NO() As String
            Get
                Return _GT_NO
            End Get
            Set(ByVal value As String)
                _GT_NO = value
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
        ''' 計時開始時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_BeginTime() As String
            Get
                Return _GT_BeginTime
            End Get
            Set(ByVal value As String)
                _GT_BeginTime = value
            End Set
        End Property
        ''' <summary>
        ''' 計時結束時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_EndTime() As String
            Get
                Return _GT_EndTime
            End Get
            Set(ByVal value As String)
                _GT_EndTime = value
            End Set
        End Property

        ''' <summary>
        ''' 總計時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_Total() As Double
            Get
                Return _GT_Total
            End Get
            Set(ByVal value As Double)
                _GT_Total = value
            End Set
        End Property

        ''' <summary>
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_Date() As String
            Get
                Return _GT_Date
            End Get
            Set(ByVal value As String)
                _GT_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_Action() As String
            Get
                Return _GT_Action
            End Get
            Set(ByVal value As String)
                _GT_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_Remark() As String
            Get
                Return _GT_Remark
            End Get
            Set(ByVal value As String)
                _GT_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_ActionName() As String
            Get
                Return _GT_ActionName
            End Get
            Set(ByVal value As String)
                _GT_ActionName = value
            End Set
        End Property
        ''' <summary>
        ''' 員工名姓名(ProductionPiecePersonnel)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_Per_Name() As String
            Get
                Return _GT_Per_Name
            End Get
            Set(ByVal value As String)
                _GT_Per_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 部門名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_DepName() As String
            Get
                Return _GT_DepName
            End Get
            Set(ByVal value As String)
                _GT_DepName = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_FacName() As String
            Get
                Return _GT_FacName
            End Get
            Set(ByVal value As String)
                _GT_FacName = value
            End Set
        End Property
        ''' <summary>
        '''  組別名(ProductionPieceWorkGroup)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property GT_G_Name() As String
            Get
                Return _GT_G_Name
            End Get
            Set(ByVal value As String)
                _GT_G_Name = value
            End Set
        End Property

    End Class
End Namespace
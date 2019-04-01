Namespace LFERP.Library.ProductionSumTimePersonnel



    Public Class ProductionSumTimePersonnelInfo
        Private _PT_NO As String '             *  nvarchar(50)                /計時單號
        Private _Per_NO As String '            *  nvarchar(50)                /員工編號
        Private _G_NO As String '              *  nvarchar(50)                /組別編號
        Private _DepID As String '             *  nvarchar(50)                /部門編號
        Private _FacID As String '             *  nvarchar(50)                /廠別

        Private _PT_BeginTime As String '       *  nvarchar(50)                /計時開始時間
        Private _PT_EndTime As String '         *  nvarchar(50)                /計時結束時間
        Private _PT_Total As Double '         *  float                       /總計時間    
        Private _PT_Date As String '           *  datetime                    /建立日期
        Private _PT_Action As String '        *  nvarchar(50)                /操作人

        Private _PT_Remark As String '         *  nvarchar(MAX)               /備注

        '外表字段
        Private _PT_ActionName As String '  操作員名 
        Private _PT_Per_Name As String '    員工名姓名(ProductionPiecePersonnel)
        Private _PT_DepName As String '     部門名
        Private _PT_FacName As String '     廠別名
        Private _PT_G_Name As String '      組別名(ProductionPieceWorkGroup)

        Private _PT_DateEnd As String  ''打印用開始時間
        Private _PT_DateStart As String
        Private _Print_Action As String

        Private _PP_NO As String

        Private _SampID As String
        Private _SampPrice As Double
        Private _SampName As String '2014-07-24

        Sub New()

            _PT_DateEnd = Nothing
            _PT_DateStart = Nothing
            _Print_Action = Nothing

            _PT_NO = Nothing
            _Per_NO = Nothing
            _G_NO = Nothing
            _DepID = Nothing
            _FacID = Nothing

            _PT_BeginTime = Nothing
            _PT_EndTime = Nothing
            _PT_Total = 0
            _PT_Date = Nothing
            _PT_Action = Nothing

            _PT_Remark = Nothing

            ''外表
            _PT_ActionName = Nothing
            _PT_Per_Name = Nothing
            _PT_DepName = Nothing
            _PT_FacName = Nothing
            _PT_G_Name = Nothing


            _PP_NO = Nothing

            _SampPrice = 0
            _SampID = Nothing
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


        Public Property PP_NO() As String
            Get
                Return _PP_NO
            End Get
            Set(ByVal value As String)
                _PP_NO = value
            End Set
        End Property

        ''' <summary>
        ''' 打印人名
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
        ''' 打印結束時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_DateStart() As String
            Get
                Return _PT_DateStart
            End Get
            Set(ByVal value As String)
                _PT_DateStart = value
            End Set
        End Property
        ''' <summary>
        ''' 打印用開始時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_DateEnd() As String
            Get
                Return _PT_DateEnd
            End Get
            Set(ByVal value As String)
                _PT_DateEnd = value
            End Set
        End Property
        ''' <summary>
        ''' 計時單號
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_NO() As String
            Get
                Return _PT_NO
            End Get
            Set(ByVal value As String)
                _PT_NO = value
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
        Public Property PT_BeginTime() As String
            Get
                Return _PT_BeginTime
            End Get
            Set(ByVal value As String)
                _PT_BeginTime = value
            End Set
        End Property
        ''' <summary>
        ''' 計時結束時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_EndTime() As String
            Get
                Return _PT_EndTime
            End Get
            Set(ByVal value As String)
                _PT_EndTime = value
            End Set
        End Property

        ''' <summary>
        ''' 總計時間
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_Total() As Double
            Get
                Return _PT_Total
            End Get
            Set(ByVal value As Double)
                _PT_Total = value
            End Set
        End Property

        ''' <summary>
        ''' 建立日期
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_Date() As String
            Get
                Return _PT_Date
            End Get
            Set(ByVal value As String)
                _PT_Date = value
            End Set
        End Property
        ''' <summary>
        ''' 操作人
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_Action() As String
            Get
                Return _PT_Action
            End Get
            Set(ByVal value As String)
                _PT_Action = value
            End Set
        End Property

        ''' <summary>
        ''' 備注
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_Remark() As String
            Get
                Return _PT_Remark
            End Get
            Set(ByVal value As String)
                _PT_Remark = value
            End Set
        End Property
        ''' <summary>
        ''' 操作員名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_ActionName() As String
            Get
                Return _PT_ActionName
            End Get
            Set(ByVal value As String)
                _PT_ActionName = value
            End Set
        End Property
        ''' <summary>
        ''' 員工名姓名(ProductionPiecePersonnel)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_Per_Name() As String
            Get
                Return _PT_Per_Name
            End Get
            Set(ByVal value As String)
                _PT_Per_Name = value
            End Set
        End Property
        ''' <summary>
        ''' 部門名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_DepName() As String
            Get
                Return _PT_DepName
            End Get
            Set(ByVal value As String)
                _PT_DepName = value
            End Set
        End Property
        ''' <summary>
        ''' 廠別名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_FacName() As String
            Get
                Return _PT_FacName
            End Get
            Set(ByVal value As String)
                _PT_FacName = value
            End Set
        End Property
        ''' <summary>
        '''  組別名(ProductionPieceWorkGroup)
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property PT_G_Name() As String
            Get
                Return _PT_G_Name
            End Get
            Set(ByVal value As String)
                _PT_G_Name = value
            End Set
        End Property
    End Class
End Namespace
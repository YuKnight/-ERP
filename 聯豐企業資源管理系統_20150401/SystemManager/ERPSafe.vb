Public Class ERPSafe
    Private _materialtype As String
    Private _suppliertype As String
    Private _warehouselist As String

    Private _DepID As String
    Private _FacID As String

    Public Sub New()
        _materialtype = Nothing
        _suppliertype = Nothing
        _warehouselist = Nothing

        _DepID = ""
        _FacID = Nothing
    End Sub

    ''' <summary>
    ''' 充許查看的物料類別
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property MaterialType() As String
        Get
            Return _materialtype
        End Get
        Set(ByVal value As String)
            _materialtype = value
        End Set

    End Property
    ''' <summary>
    ''' 可查看供應商類型用,分開,如 采購部,包裝部
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SupplierType() As String
        Get
            Return _suppliertype
        End Get
        Set(ByVal value As String)
            _suppliertype = value
        End Set

    End Property
    ''' <summary>
    ''' 允許查看的倉庫列表,格式如：'倉庫1','倉庫2'
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property WareHouseList() As String
        Get
            Return _warehouselist
        End Get
        Set(ByVal value As String)
            _warehouselist = value
        End Set

    End Property


    ''' <summary>
    ''' 允許查看的部門
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
    ''' 允許查看的廠別
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

End Class

Namespace LFERP.Library.Purchase.Purchase

    Public Class PurchaseSubsInfo
        Private _PM_NO As String
        Private _M_Code As String
        Private _PSs_Date As String
        Private _PSs_Remark As String
        Private _OS_BatchID As String
        Private _AutoID As Integer

        Sub New()
            _PM_NO = Nothing
            _M_Code = Nothing
            _PSs_Date = Nothing
            _PSs_Remark = Nothing
            _OS_BatchID = Nothing
            _AutoID = 0

        End Sub
        Public Property PM_NO() As String
            Get
                Return _PM_NO
            End Get
            Set(ByVal value As String)
                _PM_NO = value
            End Set
        End Property
        Public Property M_Code() As String
            Get
                Return _M_Code
            End Get
            Set(ByVal value As String)
                _M_Code = value
            End Set
        End Property
        Public Property PSs_Date() As String
            Get
                Return _PSs_Date
            End Get
            Set(ByVal value As String)
                _PSs_Date = value
            End Set
        End Property
        Public Property PSs_Remark() As String
            Get
                Return _PSs_Remark
            End Get
            Set(ByVal value As String)
                _PSs_Remark = value
            End Set
        End Property
        Public Property OS_BatchID() As String
            Get
                Return _OS_BatchID
            End Get
            Set(ByVal value As String)
                _OS_BatchID = value
            End Set
        End Property
        Public Property AutoID() As Integer
            Get
                Return _AutoID
            End Get
            Set(ByVal value As Integer)
                _AutoID = value
            End Set
        End Property
    End Class

End Namespace


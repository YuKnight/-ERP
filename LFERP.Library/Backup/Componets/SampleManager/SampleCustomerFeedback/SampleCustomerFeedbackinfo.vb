Namespace LFERP.Library.SampleManager.SampleCustomerFeedback



    Public Class SampleCustomerFeedbackinfo

        Private _so_id As String
        Private _sc_edition As String
        Private _SC_customerid As String
        Private _sc_description As String
        Private _sc_confirmation As String
        Private _sc_confirmationdate As String
        Private _sc_adduserID As String
        Private _sc_adduserdate As Date
        Private _sc_modifyuserID As String
        Private _sc_modifydate As Date
        Private _autoid As Integer
        Private _sc_process As String
        Private _sc_picture As String
        Private _SC_ConfirmationQty As Integer
        Private _PM_M_Code As String
        Private _M_Code As String
        Private _SO_Gauge As String
        Private _SC_Adddate As Date
        Private _SO_CusterID As String
        Private _SO_CusterPO As String
        Private _SO_CusterNo As String
        Private _SS_Edition As String
        Private _flag As String
        Private _SC_Remark As String

        Private _SC_FileID As String
        Private _SC_FileName As String
        Private _SC_Path As String
        Private _SC_SendNo As String
        Private _M_Name As String
        Private _SO_OrderQty As Integer
        Private _SP_Qty As Integer
        Public Sub New()
            _flag = ""
            _so_id = Nothing
            _sc_edition = Nothing
            _SC_customerid = Nothing
            _sc_description = Nothing
            _sc_confirmation = Nothing
            _sc_confirmationdate = Nothing
            _sc_adduserID = Nothing
            _sc_adduserdate = Nothing
            _sc_modifyuserID = Nothing
            _sc_modifydate = Nothing
            _autoid = Nothing
            _sc_process = Nothing
            _sc_picture = Nothing
            _SC_customerid = Nothing

        End Sub

        Public Property SO_ID() As String
            Get
                Return (_so_id)
            End Get
            Set(ByVal value As String)
                _so_id = value
            End Set
        End Property
        Public Property SC_Edition() As String
            Get
                Return (_sc_edition)
            End Get
            Set(ByVal value As String)
                _sc_edition = value
            End Set
        End Property
        Public Property SC_customerid() As String
            Get
                Return _SC_customerid
            End Get
            Set(ByVal value As String)
                _SC_customerid = value
            End Set
        End Property
        Public Property SC_Description() As String
            Get
                Return _sc_description
            End Get
            Set(ByVal value As String)
                _sc_description = value
            End Set
        End Property
        Public Property SC_Confirmation() As String
            Get
                Return _sc_confirmation
            End Get
            Set(ByVal value As String)
                _sc_confirmation = value
            End Set
        End Property
        Public Property SC_Confirmationdate() As String
            Get
                Return _sc_confirmationdate
            End Get
            Set(ByVal value As String)
                _sc_confirmationdate = value
            End Set
        End Property
        Public Property SC_AdduserID() As String
            Get
                Return _sc_adduserID
            End Get
            Set(ByVal value As String)
                _sc_adduserID = value
            End Set
        End Property
        Public Property SC_Adduserdate() As String
            Get
                Return _sc_adduserdate
            End Get
            Set(ByVal value As String)
                _sc_adduserdate = value
            End Set
        End Property
        Public Property SC_ModifyuserID() As String
            Get
                Return _sc_modifyuserID
            End Get
            Set(ByVal value As String)
                _sc_modifyuserID = value
            End Set
        End Property
        Public Property SC_Modifydate() As String
            Get
                Return _sc_modifydate
            End Get
            Set(ByVal value As String)
                _sc_modifydate = value
            End Set
        End Property
        Public Property AutoID() As Integer
            Get
                Return _autoid
            End Get
            Set(ByVal value As Integer)
                _autoid = value
            End Set
        End Property
        Public Property SC_Process() As String
            Get
                Return _sc_process
            End Get
            Set(ByVal value As String)
                _sc_process = value
            End Set
        End Property
        Public Property SC_Picture() As String
            Get
                Return _sc_picture
            End Get
            Set(ByVal value As String)
                _sc_picture = value
            End Set
        End Property
        Public Property SC_ConfirmationQty() As Integer
            Get
                Return _SC_ConfirmationQty
            End Get
            Set(ByVal value As Integer)
                _SC_ConfirmationQty = value
            End Set
        End Property
        Public Property PM_M_Code() As String
            Get
                Return _PM_M_Code
            End Get
            Set(ByVal value As String)
                _PM_M_Code = value
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
        Public Property SC_Adddate() As Date
            Get
                Return _SC_Adddate
            End Get
            Set(ByVal value As Date)
                _SC_Adddate = value
            End Set
        End Property
        Public Property SO_CusterID() As String
            Get
                Return _SO_CusterID
            End Get
            Set(ByVal value As String)
                _SO_CusterID = value
            End Set
        End Property
        Public Property SO_CusterPO() As String
            Get
                Return _SO_CusterPO
            End Get
            Set(ByVal value As String)
                _SO_CusterPO = value
            End Set
        End Property
        Public Property SO_CusterNo() As String
            Get
                Return _SO_CusterNo
            End Get
            Set(ByVal value As String)
                _SO_CusterNo = value
            End Set
        End Property
        Public Property SO_Gauge() As String
            Get
                Return _SO_Gauge
            End Get
            Set(ByVal value As String)
                _SO_Gauge = value
            End Set
        End Property
        Public Property SS_Edition() As String
            Get
                Return _SS_Edition
            End Get
            Set(ByVal value As String)
                _SS_Edition = value
            End Set
        End Property
        Public Property flag() As String
            Get
                Return _flag
            End Get
            Set(ByVal value As String)
                _flag = value
            End Set
        End Property
        Public Property SC_FileID() As String
            Get
                Return _SC_FileID
            End Get
            Set(ByVal value As String)
                _SC_FileID = value
            End Set
        End Property
        Public Property SC_FileName() As String
            Get
                Return _SC_FileName
            End Get
            Set(ByVal value As String)
                _SC_FileName = value
            End Set
        End Property
        Public Property SC_Path() As String
            Get
                Return _SC_Path
            End Get
            Set(ByVal value As String)
                _SC_Path = value
            End Set
        End Property
        Public Property SC_SendNo() As String
            Get
                Return _SC_SendNo
            End Get
            Set(ByVal value As String)
                _SC_SendNo = value
            End Set
        End Property

        Public Property M_Name() As String
            Get
                Return _M_Name
            End Get
            Set(ByVal value As String)
                _M_Name = value
            End Set
        End Property
        Public Property SO_OrderQty() As String
            Get
                Return _SO_OrderQty
            End Get
            Set(ByVal value As String)
                _SO_OrderQty = value
            End Set
        End Property

        Public Property SP_Qty() As String
            Get
                Return _SP_Qty
            End Get
            Set(ByVal value As String)
                _SP_Qty = value
            End Set
        End Property
        Public Property SC_Remark() As String
            Get
                Return _SC_Remark
            End Get
            Set(ByVal value As String)
                _SC_Remark = value
            End Set
        End Property


    End Class
End Namespace
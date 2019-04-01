Imports System.Data.SqlClient
Imports EncodeMy

Module mblShareData
    ''' <summary>
    ''' 將圖片轉換為二進制流，可存入SQL的image字段
    ''' </summary>
    ''' <param name="Image">圖片,如PictureBox.image</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ImageToByte(ByVal Image As System.Drawing.Image) As Byte()
        '將圖片轉換為二進制
        Dim fs As IO.FileStream
        fs = Nothing
        If Image Is Nothing Then
            ImageToByte = Nothing
        Else
            If fs Is Nothing Then
                Dim output As New IO.MemoryStream
                Dim iImage As Drawing.Image = Nothing
                Dim mem As New IO.MemoryStream
                Dim myBitmap As New Bitmap(Image)
                myBitmap.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim Buf(CInt(mem.Length - 1)) As Byte

                mem.Position = 0
                mem.Read(Buf, 0, CInt(mem.Length))
                mem.Close()
                ImageToByte = Buf
            Else
                Dim photoData(fs.Length) As Byte
                fs.Read(photoData, 0, Int(fs.Length))
                fs.Close()
                ImageToByte = photoData
            End If

        End If
    End Function
    ''' <summary>
    ''' 將SQL的image字段轉換為圖片
    ''' </summary>
    ''' <param name="ImageByte">二進制流</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ByteToImage(ByVal ImageByte As Byte()) As System.Drawing.Image
        '將二進制圖片轉換為圖型
        If ImageByte Is Nothing Then
            ByteToImage = Nothing
        Else
            Dim stmphoto As New IO.MemoryStream(ImageByte)
            ByteToImage = Image.FromStream(stmphoto)
        End If
    End Function

    '依選擇的項目建立對應欄
    Public Sub SetSelectTypeGrid(ByVal M_Code As String, ByVal SelectType As String, ByVal GridView As System.Windows.Forms.DataGridView)
        If M_Code = Nothing Or M_Code = "" Then Exit Sub
        Select Case SelectType
            Case "產品資料共用"
                Dim mcProduct As New LFERP.Library.Product.ProductController
                GridView.DataSource = mcProduct.Product_GetListCodeShare(M_Code)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 15
                AddColumns("PM_M_Code", "產品編號", "PM_M_Code", 80, GridView)
                AddColumns("PM_CusterID", "客戶代號", "PM_CusterID", 80, GridView)
                AddColumns("PM_CusterNO", "客戶編號", "PM_CusterNO", 80, GridView)
                AddColumns("PM_JiYu", strJIYU, "PM_JiYu", 60, GridView)
                AddColumns("PM_Rank", "等級", "PM_Rank", 60, GridView)
                AddColumns("PM_AddDate", "建立日期", "PM_AddDate", 120, GridView)
                AddColumns("PM_EditDate", "最后修改日期", "PM_EditDate", 120, GridView)
                AddColumns("PM_Action", "操作員", "PM_Action", 80, GridView)
            Case "批次共用"
                Dim mcOrdersBom As New LFERP.Library.Orders.OrdersBomController
                GridView.DataSource = mcOrdersBom.OrdersBom_GetList(M_Code, Nothing, Nothing, Nothing)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 15
                AddColumns("OS_BatchID", "批次編號", "OS_BatchID", 100, GridView)
                AddColumns("PM_M_Code", "產品編號", "PM_M_Code", 80, GridView)
                AddColumns("OS_AddDate", "建立日期", "OS_AddDate", 120, GridView)
                AddColumns("OS_EditDate", "修改日期", "OS_EditDate", 120, GridView)
                AddColumns("OS_Check", "批次審核", "OS_Check", 80, GridView)

            Case "報價單"
                Dim mcQuotation As New LFERP.Library.Purchase.Quotation.QuotationController
                GridView.DataSource = mcQuotation.Quotation_GetlistTop10(Nothing, M_Code, Nothing, True, True)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 15
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("Q_QuoID", "報價單", "Q_QuoID", 80, GridView)
                AddColumns("Q_SupplierName", "供應商", "Q_SupplierName", 80, GridView)
                AddColumns("Q_SupplierNo", "供應商編號", "Q_SupplierNo", 110, GridView)
                'AddColumns("Q_Price", "單價", "Q_Price", 80, GridView)
                'AddColumns("Q_Currency", "幣別", "Q_Currency", 80, GridView)
                AddColumns("Q_Depict", "備注", "Q_Depict", 80, GridView)
                AddColumns("Q_ActionName", "報價員", "Q_ActionName", 80, GridView)
                AddColumns("Q_Check", "部門審核", "Q_Check", 80, GridView)
                AddColumns("Q_AccCheck", "會計審核", "Q_AccCheck", 80, GridView)


            Case "採購單"
                Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
                GridView.DataSource = mcPurchase.PurchaseMain_Getlist(Nothing, Nothing, Nothing, M_Code, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 1, True)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 15
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("PM_NO", "採購單號", "PM_NO", 80, GridView)
                AddColumns("S_SupplierName", "供應商", "S_SupplierName", 80, GridView)
                AddColumns("S_SupplierNO", "供應商編號", "S_SupplierNO", 110, GridView)
                AddColumns("PS_Qty", "數量", "PS_Qty", 80, GridView)
                'AddColumns("PS_Price", "單價", "PS_Price", 80, GridView)
                AddColumns("PS_SendDate", "交貨日期", "PS_SendDate", 80, GridView)
                AddColumns("PM_ActionName", "採購員", "PM_ActionName", 80, GridView)
                AddColumns("PM_Check", "部門審核", "PM_Check", 80, GridView)
                AddColumns("PM_AccountCheck", "會計審核", "PM_AccountCheck", 80, GridView)

            Case "採購單(未交完)"
                Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
                GridView.DataSource = mcPurchase.PurchaseMain_Getlist(Nothing, Nothing, Nothing, M_Code, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, 0, True)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 15
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("PM_NO", "採購單號", "PM_NO", 80, GridView)
                AddColumns("S_SupplierName", "供應商", "S_SupplierName", 80, GridView)
                AddColumns("S_SupplierNO", "供應商編號", "S_SupplierNO", 110, GridView)
                AddColumns("PS_Qty", "數量", "PS_Qty", 80, GridView)
                AddColumns("PS_NoSendQty", "未購回數量", "PS_NoSendQty", 110, GridView)
                AddColumns("PS_SendDate", "交貨日期", "PS_SendDate", 80, GridView)
                AddColumns("PM_ActionName", "採購員", "PM_ActionName", 80, GridView)
                AddColumns("PM_Check", "部門審核", "PM_Check", 80, GridView)

            Case "庫存"
                Dim mcInventory As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                Dim strCode As String
                strCode = "'" & M_Code & "'"
                GridView.DataSource = mcInventory.WareInventory_GetMaterial(Nothing, Nothing, strCode)

                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 15

                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("WI_Qty", "庫存數量", "WI_Qty", 120, GridView)
                'AddColumns("WH_ID", "倉庫編號", "WH_ID", 120, GridView)
                AddColumns("WH_Name", "主倉庫名稱", "WH_Name", 120, GridView)
                AddColumns("WH_SName", "子倉庫名稱", "WH_SName", 120, GridView)
            Case "送貨單"
                Dim acc As New LFERP.Library.Purchase.Acceptance.AcceptanceController
                GridView.DataSource = acc.Acceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, True, Nothing, M_Code, Nothing, Nothing, Nothing, Nothing, Nothing)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 15

                AddColumns("PM_NO", "採購單號", "PM_NO", 120, GridView)
                AddColumns("A_AcceptanceNO", "驗收單號", "A_AcceptanceNO", 120, GridView)
                AddColumns("A_Qty", "驗收數量", "A_Qty", 120, GridView)
                AddColumns("A_SendNO", "送貨單號", "A_SendNO", 120, GridView)
            Case "物料品質反饋"
                Dim wqc As New LFERP.Library.Purchase.WareQuality.WareQualityController
                GridView.DataSource = wqc.WareQuality_GetList(Nothing, M_Code, Nothing, Nothing, Nothing, Nothing, Nothing)

                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 15

                AddColumns("WQ_Code", "單號信息", "WQ_Code", 100, GridView)
                AddColumns("WQ_Description", "質量描述", "WQ_Description", 150, GridView)
                AddColumns("PS_Opinion", "調查結果", "PS_Opinion", 150, GridView)
                AddColumns("ACC_Opinion", "審計意見", "ACC_Opinion", 150, GridView)


        End Select


    End Sub
    Public Sub SetSelectBatchGrid(ByVal BatchID As String, ByVal M_Code As String, ByVal SelectType As String, ByVal GridView As System.Windows.Forms.DataGridView)
        If BatchID = "" Or M_Code = "" Then Exit Sub '------所有的查詢條件(除了庫存)都得添加一批次查詢！！！
        Select Case SelectType
            Case "採購信息"
                Dim mcPurchase As New LFERP.Library.Purchase.Purchase.PurchaseMainController
                GridView.DataSource = mcPurchase.PurchaseSub_GetBatchList(Nothing, M_Code, BatchID)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 5
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("OS_BatchID", "批次編號", "OS_BatchID", 120, GridView)
                AddColumns("PM_NO", "採購單號", "PM_NO", 120, GridView)
                AddColumns("PS_QTY", "採購數量", "PS_QTY", 100, GridView)
                AddColumns("PS_NoSendQty", "採購未交數", "PS_NoSendQty", 100, GridView)
                AddColumns("PM_Check", "審核", "PM_Check", 100, GridView)
            Case "採購驗收信息"
                Dim mcPurchaseAcc As New LFERP.Library.Purchase.Acceptance.AcceptanceController
                GridView.DataSource = mcPurchaseAcc.Acceptance_GetList(Nothing, Nothing, Nothing, BatchID, Nothing, Nothing, Nothing, M_Code, Nothing, Nothing, Nothing, Nothing, Nothing)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 5
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("OS_BatchID", "批次編號", "OS_BatchID", 120, GridView)
                AddColumns("A_AcceptanceNO", "驗收單號", "A_AcceptanceNO", 120, GridView)
                AddColumns("A_Qty", "驗收數量", "A_Qty", 100, GridView)
                AddColumns("A_Check", "審核", "A_Check", 80, GridView)
            Case "採購退貨信息"
                Dim mcPurchaseRet As New LFERP.Library.Purchase.Retrocede.RetrocedeController
                GridView.DataSource = mcPurchaseRet.Retrocede_GetList(Nothing, Nothing, Nothing, BatchID, Nothing, Nothing, Nothing, Nothing, M_Code, Nothing, Nothing, Nothing)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 5
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("OS_BatchID", "批次編號", "OS_BatchID", 120, GridView)
                AddColumns("R_RetrocedeNO", "退貨單號", "R_RetrocedeNO", 80, GridView)
                AddColumns("R_Qty", "退貨數", "R_Qty", 80, GridView)
                AddColumns("R_Check", "退貨審核", "R_Check", 80, GridView)
            Case "外發加工信息"
                Dim mcOutward As New LFERP.Library.Outward.OutwardController
                GridView.DataSource = mcOutward.OutwardSub_GetList(Nothing, Nothing, M_Code, Nothing, BatchID)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 5
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("OS_BatchID", "批次編號", "OS_BatchID", 120, GridView)
                AddColumns("O_NO", "外發單號", "O_NO", 100, GridView)
                AddColumns("OS_Qty", "外發數量", "OS_Qty", 80, GridView)
                AddColumns("OS_NoSendQty", "外發未交數", "OS_NoSendQty", 120, GridView)
                AddColumns("O_Check", "審核", "O_Check", 80, GridView)
                AddColumns("OS_ItemType", "項目類型", "OS_ItemType", 80, GridView)

            Case "外發驗收信息"
                Dim mcOutwardAcc As New LFERP.Library.Outward.OutwardAcceptance.OutwardAcceptanceControl
                GridView.DataSource = mcOutwardAcc.OutwardAcceptance_GetList(Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, M_Code, Nothing, BatchID, Nothing, Nothing)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 5
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("OS_BatchID", "批次編號", "OS_BatchID", 120, GridView)
                AddColumns("A_AcceptanceNO", "驗收單號", "A_AcceptanceNO", 100, GridView)
                AddColumns("A_Qty", "驗貨數量", "A_Qty", 80, GridView)
                AddColumns("A_Check", "審核", "A_Check", 80, GridView)

            Case "外發退貨信息"
                Dim mcOutwardRet As New LFERP.Library.Outward.OutwardRetrocedeControl
                GridView.DataSource = mcOutwardRet.OutwardRetrocede_GetList(Nothing, Nothing, Nothing, Nothing, M_Code, BatchID)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 5
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("OS_BatchID", "批次編號", "OS_BatchID", 120, GridView)
                AddColumns("R_RetrocedeNO", "退貨單號", "R_RetrocedeNO", 80, GridView)
                AddColumns("R_Qty", "退貨數", "R_Qty", 80, GridView)
                AddColumns("R_Check", "退貨審核", "R_Check", 80, GridView)

            Case "庫存信息"
                Dim mcInventory As New LFERP.Library.WareHouse.WareInventory.WareInventoryMTController
                Dim strCode As String
                strCode = "'" & M_Code & "'"
                GridView.DataSource = mcInventory.WareInventory_GetMaterial(Nothing, Nothing, strCode)

                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 5

                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("WI_Qty", "庫存數量", "WI_Qty", 120, GridView)
                AddColumns("WH_ID", "倉庫編號", "WH_ID", 120, GridView)
            Case "生產狀況"

            Case "供應商復回信息"
                Dim mcSupplier As New LFERP.Library.Purchase.Purchase.PurchaseSubsControl
                GridView.DataSource = mcSupplier.PurchaseSubs_GetList(Nothing, M_Code, BatchID)
                GridView.Columns.Clear()
                GridView.RowHeadersWidth = 5
                AddColumns("M_Code", "物料編碼", "M_Code", 120, GridView)
                AddColumns("OS_BatchID", "批次編號", "OS_BatchID", 80, GridView)
                AddColumns("PM_NO", "採購單號", "PM_NO", 100, GridView)
                AddColumns("PSs_Date", "復回日期", "PSs_Date", 120, GridView)
                AddColumns("PSs_Remark", "復回備註", "PSs_Remark", 120, GridView)
        End Select
    End Sub
    Sub AddColumns(ByVal ColumnsName As String, ByVal HeadTxt As String, ByVal FieldName As String, _
    ByVal ColumnsWith As Integer, ByVal Grid As System.Windows.Forms.DataGridView)
        Dim objCol As New System.Windows.Forms.DataGridViewTextBoxColumn
        objCol.Name = ColumnsName
        objCol.HeaderText = HeadTxt
        objCol.DataPropertyName = FieldName
        objCol.Width = ColumnsWith
        Grid.Columns.AddRange(objCol)

    End Sub


    Public Function ArrayToString(ByVal arr As Integer()) As String
        '轉換Array類型為String ,在使用DataGrid時會用到
        Dim s As String = ""
        If arr Is Nothing Then
            s = "Empty..."
        Else
            Dim i As Integer
            For Each i In arr
                s += (IIf(s = "", "", ";")) + i.ToString()
            Next
            s += "."
        End If
        Return s
    End Function

    ''' <summary>
    ''' 計算文件大小
    ''' </summary>
    ''' <param name="FileLength"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFileLength(ByVal FileLength As Long) As String
        If Math.Round(FileLength / (1024 * 1024 * 1024), 2) >= 0.98 Then
            GetFileLength = CStr(Math.Round(FileLength / (1024 * 1024 * 1024), 2)) + "GB"
        ElseIf Math.Round(FileLength / (1024 * 1024), 2) >= 0.98 Then
            GetFileLength = CStr(Math.Round(FileLength / (1024 * 1024), 2)) + "MB"
        Else
            GetFileLength = CStr(Math.Round((FileLength / 1024), 2)) + "KB"
        End If
    End Function

    Public Function KaoQinConn() As String
        KaoQinConn = ""
        If Mid(strInDPT_ID, 1, 4) = "1001" Then
            '----聯豐考勤  
            KaoQinConn = "Data Source=dataserver;Initial Catalog=KaoQin;user id=sa;password=lpflpf"
        ElseIf Mid(strInDPT_ID, 1, 4) = "1002" Then
            '----米亞考勤 
            KaoQinConn = "Data Source=192.168.5.11;Initial Catalog=KaoQin;user id=sa;password=lpflpf"
        ElseIf Mid(strInDPT_ID, 1, 4) = "1003" Then
            '----瓦克考勤
            KaoQinConn = "Data Source=192.168.20.5;Initial Catalog=KaoQin;user id=mguser;password=wkpass"
        ElseIf Mid(strInDPT_ID, 1, 4) = "1004" Then
            '----米亞二廠考勤 
            KaoQinConn = "Data Source=192.168.30.9;Initial Catalog=KaoQin;user id=sa;password=lpflpf"
        End If
    End Function

    Public Function GetName(ByVal strCardID As String) As String
        GetName = ""
        'Dim strConn As String = ""
        Dim myCommand As SqlCommand
        Dim strSql As String

        Dim myConn As New SqlConnection(KaoQinConn)

        myConn.Open()
        strSql = "select * from EmployeeFull where BadgeID='" & strCardID & "'"
        myCommand = New SqlCommand(strSql, myConn)
        Dim rdr As SqlDataReader = myCommand.ExecuteReader
        If rdr.HasRows = True Then      '判斷是否存在符合條件的記錄
            Do While rdr.Read()
                GetName = rdr("name")
                strDepID = rdr("bri_NO")
                strPayType = rdr("Pay_Name")
            Loop
        Else
            GetName = ""
        End If
        myConn.Close()
    End Function

    Public Function ReadCard() As String


        ReadComm = Val(GetIni("CommSet", "ER900"))
        If ReadComm = 0 Then
            ReadComm = 1
        End If

        Dim portptr As IntPtr = ReadWriteCard.readwriteDll.OpenCommPort(ReadComm, 9600)
        Dim port As Integer = Int32.Parse(portptr.ToString())
        Dim isclock As Boolean



        If port <> -1 AndAlso port <> 0 Then
            isclock = ReadWriteCard.readwriteDll.CallClock(portptr, Int32.Parse(0))
            If isclock Then


                Dim temp As New ReadWriteCard.info
                temp.CardNo = New Byte(16) {}
                temp.CardName = New Byte(16) {}
                temp.Money = 0
                temp.Times = 0
                temp.Ver = 0
                Try
                    Dim suc As Boolean = ReadWriteCard.readwriteDll.ReadICCard(portptr, temp.CardNo, temp.CardName, temp.Money, temp.Times, temp.Ver)

                    If suc Then
                        If Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 9, 1) = "2" Then

                            ' ReadCard = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 8) & "-" & GetName(Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 8))
                            'GBTOBIG5(System.Text.Encoding.GetEncoding("Gb2312").GetString(name1))
                            ReadCard = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 8) & "-" & GBTOBIG5(System.Text.Encoding.GetEncoding("Gb2312").GetString(temp.CardName))
                        Else
                            ' ReadCard = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 7) & "-" & GetName(Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 7))
                            ReadCard = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 7) & "-" & GBTOBIG5(System.Text.Encoding.GetEncoding("Gb2312").GetString(temp.CardName))

                        End If
                    Else
                        MessageBox.Show("無法偵測工卡或刷卡機未連接！")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                ReadWriteCard.readwriteDll.CloseCommPort(ReadComm)
            Else
                MessageBox.Show("聯機失敗!")
                ReadCard = ""
            End If
        ElseIf port = 0 Then
            MessageBox.Show("無法打開端口!")
        ElseIf port = -1 Then

            MessageBox.Show("端口無效或正在使用!")

        End If

    End Function

    Public Function ReadCard1() As String

        ReadComm = Val(GetIni("CommSet", "ER900"))
        If ReadComm = 0 Then
            ReadComm = 1
        End If

        Dim portptr As IntPtr = ReadWriteCard.readwriteDll.OpenCommPort(ReadComm, 9600)
        Dim port As Integer = Int32.Parse(portptr.ToString())
        Dim isclock As Boolean



        If port <> -1 AndAlso port <> 0 Then
            isclock = ReadWriteCard.readwriteDll.CallClock(portptr, Int32.Parse(0))
            If isclock Then


                Dim temp As New ReadWriteCard.info
                temp.CardNo = New Byte(16) {}
                temp.CardName = New Byte(16) {}
                temp.Money = 0
                temp.Times = 0
                temp.Ver = 0
                Try
                    Dim suc As Boolean = ReadWriteCard.readwriteDll.ReadICCard(portptr, temp.CardNo, temp.CardName, temp.Money, temp.Times, temp.Ver)

                    If suc Then
                        If Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 9, 1) = "2" Then

                            ' ReadCard = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 8) & "-" & GetName(Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 8))
                            'GBTOBIG5(System.Text.Encoding.GetEncoding("Gb2312").GetString(name1))
                            ReadCard1 = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 8)
                        Else
                            ' ReadCard = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 7) & "-" & GetName(Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 7))
                            ReadCard1 = Mid(System.Text.Encoding.ASCII.GetString(temp.CardNo), 1, 7)

                        End If
                    Else
                        MessageBox.Show("無法偵測工卡或刷卡機未連接！")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                ReadWriteCard.readwriteDll.CloseCommPort(ReadComm)
            Else
                MessageBox.Show("聯機失敗!")
                ReadCard1 = ""
            End If
        ElseIf port = 0 Then
            MessageBox.Show("無法打開端口!")
        ElseIf port = -1 Then

            MessageBox.Show("端口無效或正在使用!")

        End If

    End Function
    Function GBTOBIG5(ByVal GBCode As String) As String
        '轉碼繁體轉簡體
        Dim gb As New EncodeRobert
        GBTOBIG5 = gb.SCTCConvert(ConvertType.Simplified, ConvertType.Traditional, GBCode)
    End Function

    Function BIG5TOGBA(ByVal GBCode As String) As String
        '轉碼繁體轉簡體
        Dim gb As New EncodeRobert
        BIG5TOGBA = gb.SCTCConvert(ConvertType.Traditional, ConvertType.Simplified, GBCode)
    End Function



    ''讀取考勤信息-------------------------
    Public Function LoadKQSumMonth(ByVal strPerNO As String, ByVal _Date_YYMM As String) As String

        On Error Resume Next

        'Dim strConn As String
        Dim myCommand As SqlCommand
        Dim strSql As String

        LoadKQSumMonth = ""
        'strConn = ""

        DoubleNormalDays = 0
        DoubleExtraHours = 0
        DoubleWeekTime = 0

        'If Mid(strInDPT_ID, 1, 4) = "1001" Then
        '    '----聯豐考勤  
        '    strConn = "Data Source=dataserver;Initial Catalog=KaoQin;user id=sa;password=lpflpf"
        'ElseIf Mid(strInDPT_ID, 1, 4) = "1002" Then
        '    '----米亞考勤 
        '    strConn = "Data Source=192.168.5.11;Initial Catalog=KaoQin;user id=sa;password=lpflpf"
        'ElseIf Mid(strInDPT_ID, 1, 4) = "1003" Then
        '    '----瓦克考勤
        '    strConn = "Data Source=192.168.20.5;Initial Catalog=KaoQin;user id=mguser;password=wkpass"
        'ElseIf Mid(strInDPT_ID, 1, 4) = "1004" Then
        '    '----米亞二廠考勤 
        '    strConn = "Data Source=192.168.30.9;Initial Catalog=KaoQin;user id=sa;password=lpflpf"
        'End If

        Dim myConn As New SqlConnection(KaoQinConn)
        myConn.Open()

        'strSql = "SELECT NormalDays,ExtraHours,(WeekTime-QJHours-SWHours) as WeekTime FROM KQSumMonth " _
        '  & " WHERE BadgeID='" & strPerNO & "' AND YM='" & _Date_YYMM & "'"

        '米亞與聯豐的不同2013-5-14

        'strSql = "SELECT NormalDays,(ExtraHours-QJHours-SWHours) as ExtraHours,WeekTime FROM KQSumMonth " _
        '           & " WHERE BadgeID='" & strPerNO & "' AND YM='" & _Date_YYMM & "'"

        strSql = "SELECT NormalDays,(ExtraHours-QJHours-SWHours) as ExtraHours,(WeekTime+JRTime) as WeekTime FROM KQSumMonth " _
                   & " WHERE BadgeID='" & strPerNO & "' AND YM='" & _Date_YYMM & "'"


        'MsgBox(strSql)
        myCommand = New SqlCommand(strSql, myConn)
        Dim rdr As SqlDataReader = myCommand.ExecuteReader
        If rdr.HasRows = True Then      '判斷是否存在符合條件的記錄
            Do While rdr.Read()

                If rdr("NormalDays") Is DBNull.Value = True Then '上班天數
                    DoubleNormalDays = 0
                Else
                    DoubleNormalDays = rdr("NormalDays")
                End If

                If rdr("ExtraHours") Is DBNull.Value = True Then '平時加班
                    DoubleExtraHours = 0
                Else
                    DoubleExtraHours = rdr("ExtraHours")
                End If

                If rdr("WeekTime") Is DBNull.Value = True Then '假日加班
                    DoubleWeekTime = 0
                Else
                    DoubleWeekTime = rdr("WeekTime")
                End If

            Loop
        Else
            LoadKQSumMonth = ""
        End If
        myConn.Close()
    End Function


    ''' <summary>
    ''' 復制 GridView 選中的多行文件
    ''' </summary>
    ''' <param name="GView"></param>
    ''' <param name="FiledName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GridViewCopyMulitRow(ByVal GView As DevExpress.XtraGrid.Views.Grid.GridView, ByVal FiledName As String, ByVal Type As String) As String
        GridViewCopyMulitRow = ""

        Dim n, i As Integer
        If Type = "ALL" Then
            n = GView.RowCount - 1
        End If

        Dim arr(n) As Integer

        If Type = "ALL" Then
            If GView.RowCount <= 0 Then
                Exit Function
            End If


            Dim j1 As Integer
            For j1 = 0 To GView.RowCount - 1
                arr(j1) = j1
            Next
        Else
            arr = GView.GetSelectedRows()
        End If




        n = arr.Length
        If n > 0 Then
        Else
            Exit Function
        End If
        ''--------------------------------------------------------------------------------------
        Dim m, j As Integer
        Dim arr1(n) As String
        arr1 = Split(FiledName, ",")
        m = arr1.Length
        If m > 0 Then
        Else
            Exit Function
        End If
        ''--------------------------------------------------------------------------------------

        Dim LsStr As String = ""
        Dim k As Integer

        For k = 0 To m - 1
            LsStr = LsStr + GView.Columns(arr1(k)).Caption.ToString & Chr(9)
        Next

        LsStr = LsStr + vbCrLf
        ''--------------------------------------------------------------------------------------


        For i = 0 To n - 1
            For j = 0 To m - 1
                'M_Gauge
                If arr1(j) = "M_Gauge" Then
                    LsStr = LsStr + Replace(GView.GetRowCellValue(arr(i), arr1(j)).ToString, vbCrLf, "") & Chr(9)
                Else
                    If GView.GetRowCellValue(arr(i), arr1(j)) Is DBNull.Value Then
                        LsStr = LsStr + "" & Chr(9)
                    Else
                        '   MsgBox(GView.GetRowCellValue(arr(i), arr1(j)))
                        LsStr = LsStr + CStr(GView.GetRowCellValue(arr(i), arr1(j))) & Chr(9)
                    End If
                End If


            Next
            LsStr = LsStr & vbCrLf
        Next

        Clipboard.SetText(LsStr)
    End Function

End Module

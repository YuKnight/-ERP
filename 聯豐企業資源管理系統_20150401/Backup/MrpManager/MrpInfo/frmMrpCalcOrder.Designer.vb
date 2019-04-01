<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMrpCalcOrder
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Mrp_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MrpCalcBeginDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MrpCalcEndDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.UsedTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CreateUserName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MrpCalcDateTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ProductNum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PurchaseNum = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grid1
        '
        Me.Grid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.Location = New System.Drawing.Point(0, 36)
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(662, 327)
        Me.Grid1.TabIndex = 0
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Mrp_ID, Me.MrpCalcBeginDate, Me.MrpCalcEndDate, Me.UsedTime, Me.CreateUserName, Me.MrpCalcDateTime, Me.ProductNum, Me.PurchaseNum})
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'Mrp_ID
        '
        Me.Mrp_ID.Caption = "運算單號"
        Me.Mrp_ID.FieldName = "Mrp_ID"
        Me.Mrp_ID.Name = "Mrp_ID"
        Me.Mrp_ID.Visible = True
        Me.Mrp_ID.VisibleIndex = 0
        Me.Mrp_ID.Width = 94
        '
        'MrpCalcBeginDate
        '
        Me.MrpCalcBeginDate.Caption = "開始時間"
        Me.MrpCalcBeginDate.DisplayFormat.FormatString = "HH:mm:ss"
        Me.MrpCalcBeginDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MrpCalcBeginDate.FieldName = "MrpCalcBeginDate"
        Me.MrpCalcBeginDate.Name = "MrpCalcBeginDate"
        Me.MrpCalcBeginDate.Visible = True
        Me.MrpCalcBeginDate.VisibleIndex = 1
        '
        'MrpCalcEndDate
        '
        Me.MrpCalcEndDate.Caption = "結束時間"
        Me.MrpCalcEndDate.DisplayFormat.FormatString = "HH:mm:ss"
        Me.MrpCalcEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MrpCalcEndDate.FieldName = "MrpCalcEndDate"
        Me.MrpCalcEndDate.Name = "MrpCalcEndDate"
        Me.MrpCalcEndDate.Visible = True
        Me.MrpCalcEndDate.VisibleIndex = 2
        '
        'UsedTime
        '
        Me.UsedTime.Caption = "總耗時（分）"
        Me.UsedTime.FieldName = "UsedTime"
        Me.UsedTime.Name = "UsedTime"
        Me.UsedTime.Visible = True
        Me.UsedTime.VisibleIndex = 3
        Me.UsedTime.Width = 97
        '
        'CreateUserName
        '
        Me.CreateUserName.Caption = "運算人員"
        Me.CreateUserName.FieldName = "CreateUserName"
        Me.CreateUserName.Name = "CreateUserName"
        Me.CreateUserName.Visible = True
        Me.CreateUserName.VisibleIndex = 4
        '
        'MrpCalcDateTime
        '
        Me.MrpCalcDateTime.Caption = "運算日期"
        Me.MrpCalcDateTime.DisplayFormat.FormatString = "yyyy/MM/dd"
        Me.MrpCalcDateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.MrpCalcDateTime.FieldName = "MrpCalcDateTime"
        Me.MrpCalcDateTime.Name = "MrpCalcDateTime"
        Me.MrpCalcDateTime.Visible = True
        Me.MrpCalcDateTime.VisibleIndex = 5
        '
        'ProductNum
        '
        Me.ProductNum.Caption = "產品數量"
        Me.ProductNum.FieldName = "ProductNum"
        Me.ProductNum.Name = "ProductNum"
        Me.ProductNum.Visible = True
        Me.ProductNum.VisibleIndex = 6
        Me.ProductNum.Width = 71
        '
        'PurchaseNum
        '
        Me.PurchaseNum.Caption = "請購數量"
        Me.PurchaseNum.FieldName = "PurchaseNum"
        Me.PurchaseNum.Name = "PurchaseNum"
        Me.PurchaseNum.Visible = True
        Me.PurchaseNum.VisibleIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 21)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "MRP運算記錄表"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(662, 36)
        Me.PictureBox1.TabIndex = 173
        Me.PictureBox1.TabStop = False
        '
        'frmMrpCalcOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 363)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Grid1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMrpCalcOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MRP運算記錄表"
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Mrp_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MrpCalcBeginDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MrpCalcEndDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UsedTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CreateUserName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MrpCalcDateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PurchaseNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

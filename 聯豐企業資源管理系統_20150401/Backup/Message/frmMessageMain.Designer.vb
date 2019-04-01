<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageMain
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessageMain))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.MS_Read = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.imageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.MS_Attachment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repositoryItemImageComboBox3 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.tv1 = New System.Windows.Forms.TreeView
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl
        Me.popMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.popmsgdel = New System.Windows.Forms.ToolStripMenuItem
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.MS_Priority = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Me.MS_Subject = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MS_FromName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MS_To = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MS_SendDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.MS_ReceivedDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MS_ID = New DevExpress.XtraGrid.Columns.GridColumn
        Me.MS_Content = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.MsgAdd = New System.Windows.Forms.ToolStripButton
        Me.EditDraft = New System.Windows.Forms.ToolStripButton
        Me.MsgReply = New System.Windows.Forms.ToolStripButton
        Me.MsgZF = New System.Windows.Forms.ToolStripButton
        Me.ReplyAll = New System.Windows.Forms.ToolStripButton
        Me.ReceiveSend = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.MS_AttachName = New System.Windows.Forms.ColumnHeader
        Me.MS_DanJuID = New System.Windows.Forms.ColumnHeader
        Me.MS_ModuleID = New System.Windows.Forms.ColumnHeader
        Me.MS_SendType = New System.Windows.Forms.ColumnHeader
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popMenu.SuspendLayout()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MS_Read
        '
        Me.MS_Read.Caption = "Read"
        Me.MS_Read.ColumnEdit = Me.repositoryItemImageComboBox2
        Me.MS_Read.FieldName = "MS_Read"
        Me.MS_Read.ImageIndex = 1
        Me.MS_Read.Name = "MS_Read"
        Me.MS_Read.OptionsColumn.AllowEdit = False
        Me.MS_Read.OptionsColumn.AllowMove = False
        Me.MS_Read.OptionsColumn.AllowSize = False
        Me.MS_Read.OptionsColumn.FixedWidth = True
        Me.MS_Read.OptionsColumn.ShowCaption = False
        Me.MS_Read.ToolTip = "Read"
        Me.MS_Read.Visible = True
        Me.MS_Read.VisibleIndex = 1
        Me.MS_Read.Width = 25
        '
        'repositoryItemImageComboBox2
        '
        Me.repositoryItemImageComboBox2.AutoHeight = False
        Me.repositoryItemImageComboBox2.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.repositoryItemImageComboBox2.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Unread", "0", 3), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Read", "1", 2)})
        Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
        Me.repositoryItemImageComboBox2.SmallImages = Me.imageList2
        '
        'imageList2
        '
        Me.imageList2.ImageStream = CType(resources.GetObject("imageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList2.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList2.Images.SetKeyName(0, "")
        Me.imageList2.Images.SetKeyName(1, "")
        Me.imageList2.Images.SetKeyName(2, "")
        Me.imageList2.Images.SetKeyName(3, "")
        Me.imageList2.Images.SetKeyName(4, "")
        '
        'MS_Attachment
        '
        Me.MS_Attachment.Caption = "Attachment"
        Me.MS_Attachment.ColumnEdit = Me.repositoryItemImageComboBox3
        Me.MS_Attachment.FieldName = "MS_Attachment"
        Me.MS_Attachment.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.MS_Attachment.ImageIndex = 2
        Me.MS_Attachment.Name = "MS_Attachment"
        Me.MS_Attachment.OptionsColumn.AllowEdit = False
        Me.MS_Attachment.OptionsColumn.AllowMove = False
        Me.MS_Attachment.OptionsColumn.AllowSize = False
        Me.MS_Attachment.OptionsColumn.FixedWidth = True
        Me.MS_Attachment.OptionsColumn.ShowCaption = False
        Me.MS_Attachment.ToolTip = "Attachment"
        Me.MS_Attachment.Visible = True
        Me.MS_Attachment.VisibleIndex = 2
        Me.MS_Attachment.Width = 27
        '
        'repositoryItemImageComboBox3
        '
        Me.repositoryItemImageComboBox3.AutoHeight = False
        Me.repositoryItemImageComboBox3.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.repositoryItemImageComboBox3.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Attachment", "1", 4), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Empty", 1, -1)})
        Me.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3"
        Me.repositoryItemImageComboBox3.SmallImages = Me.imageList2
        '
        'tv1
        '
        Me.tv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.tv1.HideSelection = False
        Me.tv1.Location = New System.Drawing.Point(0, 0)
        Me.tv1.Name = "tv1"
        Me.tv1.Size = New System.Drawing.Size(129, 495)
        Me.tv1.TabIndex = 37
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "SharingOpenMailFolder.png")
        Me.ImageList3.Images.SetKeyName(1, "INBOX.png")
        Me.ImageList3.Images.SetKeyName(2, "editmsg.png")
        Me.ImageList3.Images.SetKeyName(3, "SaveBACKUP.png")
        Me.ImageList3.Images.SetKeyName(4, "DELETEBAOX_16.png")
        '
        'imageList1
        '
        Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
        Me.imageList1.Images.SetKeyName(0, "")
        Me.imageList1.Images.SetKeyName(1, "")
        Me.imageList1.Images.SetKeyName(2, "")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("標楷體", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 24)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "消息管理"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(4, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(865, 36)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'gridControl1
        '
        Me.gridControl1.ContextMenuStrip = Me.popMenu
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.EmbeddedNavigator.Name = ""
        Me.gridControl1.Location = New System.Drawing.Point(0, 0)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemDateEdit1, Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemImageComboBox3, Me.RepositoryItemMemoExEdit1})
        Me.gridControl1.Size = New System.Drawing.Size(732, 214)
        Me.gridControl1.TabIndex = 38
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'popMenu
        '
        Me.popMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.popmsgdel})
        Me.popMenu.Name = "popFileShow"
        Me.popMenu.Size = New System.Drawing.Size(169, 26)
        '
        'popmsgdel
        '
        Me.popmsgdel.Image = Global.LFERP.My.Resources.Resources.QueryDelete
        Me.popmsgdel.Name = "popmsgdel"
        Me.popmsgdel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.popmsgdel.Size = New System.Drawing.Size(168, 22)
        Me.popmsgdel.Text = "刪除(&D)"
        '
        'gridView1
        '
        Me.gridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.MS_Priority, Me.MS_Read, Me.MS_Attachment, Me.MS_Subject, Me.MS_FromName, Me.MS_To, Me.MS_SendDate, Me.MS_ReceivedDate, Me.MS_ID, Me.MS_Content})
        Me.gridView1.CustomizationFormBounds = New System.Drawing.Rectangle(816, 421, 208, 175)
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.MS_Read
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "0"
        Me.gridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.GroupFormat = ""
        Me.gridView1.Images = Me.imageList1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gridView1.OptionsBehavior.Editable = False
        Me.gridView1.OptionsCustomization.AllowColumnMoving = False
        Me.gridView1.OptionsCustomization.AllowFilter = False
        Me.gridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridView1.OptionsView.ShowGroupPanel = False
        Me.gridView1.OptionsView.ShowIndicator = False
        Me.gridView1.OptionsView.ShowVertLines = False
        '
        'MS_Priority
        '
        Me.MS_Priority.Caption = "Priority"
        Me.MS_Priority.ColumnEdit = Me.repositoryItemImageComboBox1
        Me.MS_Priority.FieldName = "MS_Priority"
        Me.MS_Priority.ImageAlignment = System.Drawing.StringAlignment.Center
        Me.MS_Priority.ImageIndex = 0
        Me.MS_Priority.Name = "MS_Priority"
        Me.MS_Priority.OptionsColumn.AllowMove = False
        Me.MS_Priority.OptionsColumn.AllowSize = False
        Me.MS_Priority.OptionsColumn.FixedWidth = True
        Me.MS_Priority.OptionsColumn.ShowCaption = False
        Me.MS_Priority.ToolTip = "Importance"
        Me.MS_Priority.Visible = True
        Me.MS_Priority.VisibleIndex = 0
        Me.MS_Priority.Width = 25
        '
        'repositoryItemImageComboBox1
        '
        Me.repositoryItemImageComboBox1.AutoHeight = False
        Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemImageComboBox1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", "0", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("Medium", "1", -1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", "2", 1)})
        Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
        Me.repositoryItemImageComboBox1.SmallImages = Me.imageList2
        '
        'MS_Subject
        '
        Me.MS_Subject.Caption = "主旨"
        Me.MS_Subject.FieldName = "MS_Subject"
        Me.MS_Subject.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Alphabetical
        Me.MS_Subject.Name = "MS_Subject"
        Me.MS_Subject.Visible = True
        Me.MS_Subject.VisibleIndex = 3
        Me.MS_Subject.Width = 300
        '
        'MS_FromName
        '
        Me.MS_FromName.Caption = "發送人"
        Me.MS_FromName.FieldName = "MS_FromName"
        Me.MS_FromName.Name = "MS_FromName"
        Me.MS_FromName.Visible = True
        Me.MS_FromName.VisibleIndex = 4
        Me.MS_FromName.Width = 146
        '
        'MS_To
        '
        Me.MS_To.Caption = "接收人"
        Me.MS_To.FieldName = "MS_To"
        Me.MS_To.Name = "MS_To"
        '
        'MS_SendDate
        '
        Me.MS_SendDate.Caption = "日期"
        Me.MS_SendDate.ColumnEdit = Me.repositoryItemDateEdit1
        Me.MS_SendDate.FieldName = "MS_SendDate"
        Me.MS_SendDate.Name = "MS_SendDate"
        Me.MS_SendDate.Visible = True
        Me.MS_SendDate.VisibleIndex = 5
        Me.MS_SendDate.Width = 126
        '
        'repositoryItemDateEdit1
        '
        Me.repositoryItemDateEdit1.AutoHeight = False
        Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repositoryItemDateEdit1.DisplayFormat.FormatString = "g"
        Me.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.repositoryItemDateEdit1.Mask.EditMask = "g"
        Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
        '
        'MS_ReceivedDate
        '
        Me.MS_ReceivedDate.Caption = "讀取日期"
        Me.MS_ReceivedDate.ColumnEdit = Me.repositoryItemDateEdit1
        Me.MS_ReceivedDate.FieldName = "MS_ReceivedDate"
        Me.MS_ReceivedDate.Name = "MS_ReceivedDate"
        Me.MS_ReceivedDate.Width = 205
        '
        'MS_ID
        '
        Me.MS_ID.Caption = "編號"
        Me.MS_ID.FieldName = "MS_ID"
        Me.MS_ID.Name = "MS_ID"
        '
        'MS_Content
        '
        Me.MS_Content.Caption = "內容"
        Me.MS_Content.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.MS_Content.FieldName = "MS_Content"
        Me.MS_Content.Name = "MS_Content"
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MsgAdd, Me.EditDraft, Me.MsgReply, Me.MsgZF, Me.ReplyAll, Me.ReceiveSend})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 42)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(379, 25)
        Me.ToolStrip1.TabIndex = 39
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'MsgAdd
        '
        Me.MsgAdd.Image = Global.LFERP.My.Resources.Resources.newSendToMailRecipient
        Me.MsgAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MsgAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MsgAdd.Name = "MsgAdd"
        Me.MsgAdd.Size = New System.Drawing.Size(55, 22)
        Me.MsgAdd.Text = " 新增 "
        '
        'EditDraft
        '
        Me.EditDraft.Image = Global.LFERP.My.Resources.Resources.editmsg
        Me.EditDraft.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditDraft.Name = "EditDraft"
        Me.EditDraft.Size = New System.Drawing.Size(55, 22)
        Me.EditDraft.Text = " 修改 "
        '
        'MsgReply
        '
        Me.MsgReply.Image = Global.LFERP.My.Resources.Resources.Reply1
        Me.MsgReply.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MsgReply.Name = "MsgReply"
        Me.MsgReply.Size = New System.Drawing.Size(55, 22)
        Me.MsgReply.Text = " 回復 "
        '
        'MsgZF
        '
        Me.MsgZF.Image = Global.LFERP.My.Resources.Resources.Forward
        Me.MsgZF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.MsgZF.Name = "MsgZF"
        Me.MsgZF.Size = New System.Drawing.Size(49, 22)
        Me.MsgZF.Text = "轉發"
        '
        'ReplyAll
        '
        Me.ReplyAll.Image = Global.LFERP.My.Resources.Resources.ReplyAll
        Me.ReplyAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReplyAll.Name = "ReplyAll"
        Me.ReplyAll.Size = New System.Drawing.Size(73, 22)
        Me.ReplyAll.Text = "全部回復"
        '
        'ReceiveSend
        '
        Me.ReceiveSend.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReceiveSend.Image = Global.LFERP.My.Resources.Resources.GroupAppointmentOptions
        Me.ReceiveSend.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ReceiveSend.Name = "ReceiveSend"
        Me.ReceiveSend.Size = New System.Drawing.Size(82, 22)
        Me.ReceiveSend.Text = " 接收/發送 "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 70)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tv1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(865, 495)
        Me.SplitContainer1.SplitterDistance = 129
        Me.SplitContainer1.TabIndex = 40
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.gridControl1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer2.Panel2.Controls.Add(Me.LabelControl1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.PictureEdit1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer2.Panel2.ForeColor = System.Drawing.Color.Black
        Me.SplitContainer2.Size = New System.Drawing.Size(732, 495)
        Me.SplitContainer2.SplitterDistance = 214
        Me.SplitContainer2.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 14)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "附件:"
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MS_AttachName, Me.MS_DanJuID, Me.MS_ModuleID, Me.MS_SendType})
        Me.ListView1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ListView1.LargeImageList = Me.ImageList3
        Me.ListView1.Location = New System.Drawing.Point(49, 8)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(672, 16)
        Me.ListView1.SmallImageList = Me.ImageList3
        Me.ListView1.StateImageList = Me.imageList2
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'MS_AttachName
        '
        Me.MS_AttachName.Text = "MS_AttachName"
        Me.MS_AttachName.Width = 250
        '
        'MS_DanJuID
        '
        Me.MS_DanJuID.Text = "MS_DanJuID"
        '
        'MS_ModuleID
        '
        Me.MS_ModuleID.Text = "MS_ModuleID"
        '
        'MS_SendType
        '
        Me.MS_SendType.Text = "MS_SendType"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureEdit1.Location = New System.Drawing.Point(5, 30)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Size = New System.Drawing.Size(721, 1)
        Me.PictureEdit1.TabIndex = 3
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(10, 37)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(711, 229)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'frmMessageMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMessageMain"
        Me.ShowInTaskbar = False
        Me.Text = "消息管理"
        CType(Me.repositoryItemImageComboBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemImageComboBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popMenu.ResumeLayout(False)
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tv1 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents gridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private WithEvents MS_Priority As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Private WithEvents imageList2 As System.Windows.Forms.ImageList
    Private WithEvents MS_Read As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Private WithEvents MS_Attachment As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents repositoryItemImageComboBox3 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Private WithEvents MS_Subject As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MS_FromName As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MS_To As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents MS_SendDate As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Private WithEvents MS_ReceivedDate As DevExpress.XtraGrid.Columns.GridColumn
    Private WithEvents imageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents MsgAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents MsgReply As System.Windows.Forms.ToolStripButton
    Friend WithEvents MsgZF As System.Windows.Forms.ToolStripButton
    Friend WithEvents ReceiveSend As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MS_AttachName As System.Windows.Forms.ColumnHeader
    Friend WithEvents MS_ID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents MS_Content As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ReplyAll As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditDraft As System.Windows.Forms.ToolStripButton
    Friend WithEvents popMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents popmsgdel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MS_DanJuID As System.Windows.Forms.ColumnHeader
    Friend WithEvents MS_ModuleID As System.Windows.Forms.ColumnHeader
    Friend WithEvents MS_SendType As System.Windows.Forms.ColumnHeader
    Friend WithEvents ImageList3 As System.Windows.Forms.ImageList
End Class

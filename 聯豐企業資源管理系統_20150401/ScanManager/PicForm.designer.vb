<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PicForm
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
        Me.components = New System.ComponentModel.Container
        Me.picformMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuMainFilePic = New System.Windows.Forms.MenuItem
        Me.menuItemInfo = New System.Windows.Forms.MenuItem
        Me.menuItemSaveAs = New System.Windows.Forms.MenuItem
        Me.menuItemClose = New System.Windows.Forms.MenuItem
        Me.menuItemSepPic = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'picformMenu
        '
        Me.picformMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuMainFilePic})
        '
        'menuMainFilePic
        '
        Me.menuMainFilePic.Index = 0
        Me.menuMainFilePic.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemInfo, Me.menuItemSaveAs, Me.menuItemClose, Me.menuItemSepPic})
        Me.menuMainFilePic.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.menuMainFilePic.Text = "&File"
        '
        'menuItemInfo
        '
        Me.menuItemInfo.Index = 0
        Me.menuItemInfo.MergeOrder = 1
        Me.menuItemInfo.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.menuItemInfo.Text = "&Info..."
        '
        'menuItemSaveAs
        '
        Me.menuItemSaveAs.Index = 1
        Me.menuItemSaveAs.MergeOrder = 2
        Me.menuItemSaveAs.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.menuItemSaveAs.Text = "&Save As..."
        '
        'menuItemClose
        '
        Me.menuItemClose.Index = 2
        Me.menuItemClose.MergeOrder = 3
        Me.menuItemClose.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.menuItemClose.Text = "&Close"
        '
        'menuItemSepPic
        '
        Me.menuItemSepPic.Index = 3
        Me.menuItemSepPic.MergeOrder = 4
        Me.menuItemSepPic.MergeType = System.Windows.Forms.MenuMerge.MergeItems
        Me.menuItemSepPic.Text = "-"
        '
        'PicForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(423, 303)
        Me.Menu = Me.picformMenu
        Me.Name = "PicForm"
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.Text = "PicForm"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents picformMenu As System.Windows.Forms.MainMenu
    Private WithEvents menuMainFilePic As System.Windows.Forms.MenuItem
    Private WithEvents menuItemInfo As System.Windows.Forms.MenuItem
    Private WithEvents menuItemSaveAs As System.Windows.Forms.MenuItem
    Private WithEvents menuItemClose As System.Windows.Forms.MenuItem
    Private WithEvents menuItemSepPic As System.Windows.Forms.MenuItem

End Class

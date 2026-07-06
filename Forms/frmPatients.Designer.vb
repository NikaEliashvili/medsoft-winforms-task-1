<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gcPatients = New DevExpress.XtraGrid.GridControl()
        Me.gvPatients = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsBtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnDelete = New System.Windows.Forms.ToolStripButton()
        CType(Me.gcPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcPatients
        '
        Me.gcPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPatients.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gcPatients.Location = New System.Drawing.Point(0, 45)
        Me.gcPatients.MainView = Me.gvPatients
        Me.gcPatients.Margin = New System.Windows.Forms.Padding(4)
        Me.gcPatients.Name = "gcPatients"
        Me.gcPatients.Size = New System.Drawing.Size(1378, 580)
        Me.gcPatients.TabIndex = 1
        Me.gcPatients.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPatients})
        '
        'gvPatients
        '
        Me.gvPatients.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.gvPatients.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.gvPatients.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.gvPatients.Appearance.DetailTip.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.DetailTip.Options.UseFont = True
        Me.gvPatients.Appearance.Empty.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.Empty.Options.UseFont = True
        Me.gvPatients.Appearance.EvenRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.EvenRow.Options.UseFont = True
        Me.gvPatients.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FilterCloseButton.Options.UseFont = True
        Me.gvPatients.Appearance.FilterPanel.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FilterPanel.Options.UseFont = True
        Me.gvPatients.Appearance.FixedLine.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FixedLine.Options.UseFont = True
        Me.gvPatients.Appearance.FocusedCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FocusedCell.Options.UseFont = True
        Me.gvPatients.Appearance.FocusedRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FocusedRow.Options.UseFont = True
        Me.gvPatients.Appearance.FooterPanel.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.FooterPanel.Options.UseFont = True
        Me.gvPatients.Appearance.GroupButton.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.GroupButton.Options.UseFont = True
        Me.gvPatients.Appearance.GroupFooter.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.GroupFooter.Options.UseFont = True
        Me.gvPatients.Appearance.GroupPanel.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.GroupPanel.Options.UseFont = True
        Me.gvPatients.Appearance.GroupRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.GroupRow.Options.UseFont = True
        Me.gvPatients.Appearance.HeaderPanel.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvPatients.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.HideSelectionRow.Options.UseFont = True
        Me.gvPatients.Appearance.HorzLine.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.HorzLine.Options.UseFont = True
        Me.gvPatients.Appearance.HotTrackedRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.HotTrackedRow.Options.UseFont = True
        Me.gvPatients.Appearance.OddRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.OddRow.Options.UseFont = True
        Me.gvPatients.Appearance.Preview.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.Preview.Options.UseFont = True
        Me.gvPatients.Appearance.Row.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.Row.Options.UseFont = True
        Me.gvPatients.Appearance.RowSeparator.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.RowSeparator.Options.UseFont = True
        Me.gvPatients.Appearance.SelectedRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.SelectedRow.Options.UseFont = True
        Me.gvPatients.Appearance.TopNewRow.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.TopNewRow.Options.UseFont = True
        Me.gvPatients.Appearance.VertLine.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.VertLine.Options.UseFont = True
        Me.gvPatients.Appearance.ViewCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvPatients.Appearance.ViewCaption.Options.UseFont = True
        Me.gvPatients.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colFullName, Me.colDob, Me.colGender, Me.colPhone, Me.colAddress})
        Me.gvPatients.DetailHeight = 455
        Me.gvPatients.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvPatients.GridControl = Me.gcPatients
        Me.gvPatients.Name = "gvPatients"
        Me.gvPatients.OptionsSelection.MultiSelect = True
        Me.gvPatients.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 40
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 149
        '
        'colFullName
        '
        Me.colFullName.Caption = "პაციენტის გვარი სახელი"
        Me.colFullName.FieldName = "FullName"
        Me.colFullName.MinWidth = 40
        Me.colFullName.Name = "colFullName"
        Me.colFullName.OptionsColumn.AllowEdit = False
        Me.colFullName.Visible = True
        Me.colFullName.VisibleIndex = 1
        Me.colFullName.Width = 149
        '
        'colDob
        '
        Me.colDob.Caption = "დაბ. თარიღი"
        Me.colDob.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.colDob.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDob.FieldName = "Dob"
        Me.colDob.MinWidth = 40
        Me.colDob.Name = "colDob"
        Me.colDob.OptionsColumn.AllowEdit = False
        Me.colDob.Visible = True
        Me.colDob.VisibleIndex = 2
        Me.colDob.Width = 149
        '
        'colGender
        '
        Me.colGender.Caption = "სქესი"
        Me.colGender.FieldName = "Gender"
        Me.colGender.MinWidth = 40
        Me.colGender.Name = "colGender"
        Me.colGender.OptionsColumn.AllowEdit = False
        Me.colGender.Visible = True
        Me.colGender.VisibleIndex = 3
        Me.colGender.Width = 149
        '
        'colPhone
        '
        Me.colPhone.Caption = "მობ. ნომერი"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.MinWidth = 40
        Me.colPhone.Name = "colPhone"
        Me.colPhone.OptionsColumn.AllowEdit = False
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 4
        Me.colPhone.Width = 149
        '
        'colAddress
        '
        Me.colAddress.Caption = "მისამართი"
        Me.colAddress.FieldName = "Address"
        Me.colAddress.MinWidth = 40
        Me.colAddress.Name = "colAddress"
        Me.colAddress.OptionsColumn.AllowEdit = False
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 5
        Me.colAddress.Width = 149
        '
        'tsMenu
        '
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(36, 36)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnAdd, Me.tsBtnEdit, Me.tsBtnDelete})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.tsMenu.Size = New System.Drawing.Size(1378, 45)
        Me.tsMenu.TabIndex = 2
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsBtnAdd
        '
        Me.tsBtnAdd.Image = Global.patients_crud_app.My.Resources.Resources.add
        Me.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAdd.Name = "tsBtnAdd"
        Me.tsBtnAdd.Size = New System.Drawing.Size(140, 40)
        Me.tsBtnAdd.Text = "დამატება"
        '
        'tsBtnEdit
        '
        Me.tsBtnEdit.Image = Global.patients_crud_app.My.Resources.Resources.edit
        Me.tsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnEdit.Name = "tsBtnEdit"
        Me.tsBtnEdit.Size = New System.Drawing.Size(180, 40)
        Me.tsBtnEdit.Text = "რედაქტირება"
        '
        'tsBtnDelete
        '
        Me.tsBtnDelete.Image = Global.patients_crud_app.My.Resources.Resources.delete
        Me.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnDelete.Name = "tsBtnDelete"
        Me.tsBtnDelete.Size = New System.Drawing.Size(112, 40)
        Me.tsBtnDelete.Text = "წაშლა"
        '
        'frmPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1378, 625)
        Me.Controls.Add(Me.gcPatients)
        Me.Controls.Add(Me.tsMenu)
        Me.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPatients"
        Me.Text = "პაციენტები"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gcPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcPatients As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPatients As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGender As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tsMenu As ToolStrip
    Friend WithEvents tsBtnAdd As ToolStripButton
    Friend WithEvents tsBtnEdit As ToolStripButton
    Friend WithEvents tsBtnDelete As ToolStripButton
End Class

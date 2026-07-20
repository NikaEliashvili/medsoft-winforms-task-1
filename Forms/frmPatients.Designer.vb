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
        Me.colPersonalNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colInsurance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAddressAndEmail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsBtnAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnPanelToggle = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnExport = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnDetailExport = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnTop50 = New System.Windows.Forms.ToolStripButton()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPatientStatus = New System.Windows.Forms.ComboBox()
        Me.txtPatientEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPatientPersonalNumber = New System.Windows.Forms.TextBox()
        Me.lblPersonalNumber = New System.Windows.Forms.Label()
        Me.txtPatientFullName = New System.Windows.Forms.TextBox()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.lbID = New System.Windows.Forms.Label()
        CType(Me.gcPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'gcPatients
        '
        Me.gcPatients.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPatients.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(14)
        Me.gcPatients.Location = New System.Drawing.Point(0, 134)
        Me.gcPatients.MainView = Me.gvPatients
        Me.gcPatients.Margin = New System.Windows.Forms.Padding(14)
        Me.gcPatients.Name = "gcPatients"
        Me.gcPatients.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1, Me.RepositoryItemMemoEdit2})
        Me.gcPatients.Size = New System.Drawing.Size(1416, 516)
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
        Me.gvPatients.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colID, Me.colFullName, Me.colPersonalNumber, Me.colEmail, Me.colPhone, Me.colGender, Me.colDob, Me.colAddress, Me.colInsurance, Me.colIsActive, Me.colAddressAndEmail})
        Me.gvPatients.DetailHeight = 1534
        Me.gvPatients.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gvPatients.GridControl = Me.gcPatients
        Me.gvPatients.Name = "gvPatients"
        Me.gvPatients.OptionsSelection.MultiSelect = True
        Me.gvPatients.OptionsView.RowAutoHeight = True
        Me.gvPatients.OptionsView.ShowGroupPanel = False
        '
        'colID
        '
        Me.colID.AccessibleName = ""
        Me.colID.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colID.AppearanceCell.Options.UseFont = True
        Me.colID.Caption = "ID"
        Me.colID.FieldName = "ID"
        Me.colID.MinWidth = 45
        Me.colID.Name = "colID"
        Me.colID.OptionsColumn.AllowEdit = False
        Me.colID.OptionsColumn.ReadOnly = True
        Me.colID.Visible = True
        Me.colID.VisibleIndex = 0
        Me.colID.Width = 142
        '
        'colFullName
        '
        Me.colFullName.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colFullName.AppearanceCell.Options.UseFont = True
        Me.colFullName.Caption = "პაციენტის გვარი, სახელი"
        Me.colFullName.FieldName = "FullName"
        Me.colFullName.MinWidth = 45
        Me.colFullName.Name = "colFullName"
        Me.colFullName.OptionsColumn.AllowEdit = False
        Me.colFullName.OptionsColumn.ReadOnly = True
        Me.colFullName.Visible = True
        Me.colFullName.VisibleIndex = 1
        Me.colFullName.Width = 142
        '
        'colPersonalNumber
        '
        Me.colPersonalNumber.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPersonalNumber.AppearanceCell.Options.UseFont = True
        Me.colPersonalNumber.Caption = "პირ. ნომერი"
        Me.colPersonalNumber.FieldName = "PersonalNumber"
        Me.colPersonalNumber.MinWidth = 45
        Me.colPersonalNumber.Name = "colPersonalNumber"
        Me.colPersonalNumber.OptionsColumn.AllowEdit = False
        Me.colPersonalNumber.OptionsColumn.ReadOnly = True
        Me.colPersonalNumber.Visible = True
        Me.colPersonalNumber.VisibleIndex = 2
        Me.colPersonalNumber.Width = 142
        '
        'colEmail
        '
        Me.colEmail.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colEmail.AppearanceCell.Options.UseFont = True
        Me.colEmail.Caption = "ელ. ფოსტა"
        Me.colEmail.FieldName = "Email"
        Me.colEmail.MinWidth = 45
        Me.colEmail.Name = "colEmail"
        Me.colEmail.OptionsColumn.AllowEdit = False
        Me.colEmail.OptionsColumn.ReadOnly = True
        Me.colEmail.Visible = True
        Me.colEmail.VisibleIndex = 3
        Me.colEmail.Width = 142
        '
        'colPhone
        '
        Me.colPhone.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPhone.AppearanceCell.Options.UseFont = True
        Me.colPhone.Caption = "მობ. ნომერი"
        Me.colPhone.FieldName = "Phone"
        Me.colPhone.MinWidth = 45
        Me.colPhone.Name = "colPhone"
        Me.colPhone.OptionsColumn.AllowEdit = False
        Me.colPhone.OptionsColumn.ReadOnly = True
        Me.colPhone.Visible = True
        Me.colPhone.VisibleIndex = 4
        Me.colPhone.Width = 142
        '
        'colGender
        '
        Me.colGender.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colGender.AppearanceCell.Options.UseFont = True
        Me.colGender.Caption = "სქესი"
        Me.colGender.FieldName = "Gender"
        Me.colGender.MinWidth = 45
        Me.colGender.Name = "colGender"
        Me.colGender.OptionsColumn.AllowEdit = False
        Me.colGender.OptionsColumn.ReadOnly = True
        Me.colGender.Visible = True
        Me.colGender.VisibleIndex = 5
        Me.colGender.Width = 142
        '
        'colDob
        '
        Me.colDob.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDob.AppearanceCell.Options.UseFont = True
        Me.colDob.Caption = "დაბ. თარიღი"
        Me.colDob.DisplayFormat.FormatString = "dd.MM.yyyy"
        Me.colDob.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDob.FieldName = "Dob"
        Me.colDob.MinWidth = 45
        Me.colDob.Name = "colDob"
        Me.colDob.OptionsColumn.AllowEdit = False
        Me.colDob.OptionsColumn.ReadOnly = True
        Me.colDob.Visible = True
        Me.colDob.VisibleIndex = 6
        Me.colDob.Width = 142
        '
        'colAddress
        '
        Me.colAddress.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAddress.AppearanceCell.Options.UseFont = True
        Me.colAddress.Caption = "მისამართი"
        Me.colAddress.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colAddress.FieldName = "Address"
        Me.colAddress.MinWidth = 45
        Me.colAddress.Name = "colAddress"
        Me.colAddress.OptionsColumn.AllowEdit = False
        Me.colAddress.OptionsColumn.ReadOnly = True
        Me.colAddress.Visible = True
        Me.colAddress.VisibleIndex = 7
        Me.colAddress.Width = 142
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colInsurance
        '
        Me.colInsurance.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colInsurance.AppearanceCell.Options.UseFont = True
        Me.colInsurance.Caption = "დაზღვევა"
        Me.colInsurance.FieldName = "InsuranceName"
        Me.colInsurance.MinWidth = 30
        Me.colInsurance.Name = "colInsurance"
        Me.colInsurance.OptionsColumn.AllowEdit = False
        Me.colInsurance.OptionsColumn.ReadOnly = True
        Me.colInsurance.Visible = True
        Me.colInsurance.VisibleIndex = 8
        Me.colInsurance.Width = 140
        '
        'colIsActive
        '
        Me.colIsActive.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colIsActive.AppearanceCell.Options.UseFont = True
        Me.colIsActive.Caption = "სტატუსი"
        Me.colIsActive.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colIsActive.FieldName = "IsActive"
        Me.colIsActive.MinWidth = 45
        Me.colIsActive.Name = "colIsActive"
        Me.colIsActive.OptionsColumn.AllowEdit = False
        Me.colIsActive.OptionsColumn.ReadOnly = True
        Me.colIsActive.UnboundDataType = GetType(Boolean)
        Me.colIsActive.UnboundExpression = "[IsDelete]==False"
        Me.colIsActive.Visible = True
        Me.colIsActive.VisibleIndex = 9
        Me.colIsActive.Width = 104
        '
        'colAddressAndEmail
        '
        Me.colAddressAndEmail.AppearanceCell.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAddressAndEmail.AppearanceCell.Options.UseFont = True
        Me.colAddressAndEmail.Caption = "მისამართი და ელ. ფოსტა"
        Me.colAddressAndEmail.ColumnEdit = Me.RepositoryItemMemoEdit2
        Me.colAddressAndEmail.FieldName = "AddressAndEmail"
        Me.colAddressAndEmail.MinWidth = 30
        Me.colAddressAndEmail.Name = "colAddressAndEmail"
        Me.colAddressAndEmail.OptionsColumn.AllowEdit = False
        Me.colAddressAndEmail.OptionsColumn.ReadOnly = True
        Me.colAddressAndEmail.Visible = True
        Me.colAddressAndEmail.VisibleIndex = 10
        Me.colAddressAndEmail.Width = 112
        '
        'RepositoryItemMemoEdit2
        '
        Me.RepositoryItemMemoEdit2.Name = "RepositoryItemMemoEdit2"
        '
        'tsMenu
        '
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsBtnAdd, Me.tsBtnEdit, Me.tsBtnDelete, Me.tsBtnPanelToggle, Me.tsBtnExport, Me.tsBtnDetailExport, Me.tsBtnTop50})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.tsMenu.Size = New System.Drawing.Size(1416, 41)
        Me.tsMenu.TabIndex = 2
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsBtnAdd
        '
        Me.tsBtnAdd.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBtnAdd.Image = Global.patients_crud_app.My.Resources.Resources.add
        Me.tsBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnAdd.Name = "tsBtnAdd"
        Me.tsBtnAdd.Size = New System.Drawing.Size(136, 36)
        Me.tsBtnAdd.Text = "დამატება"
        '
        'tsBtnEdit
        '
        Me.tsBtnEdit.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBtnEdit.Image = Global.patients_crud_app.My.Resources.Resources.edit
        Me.tsBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnEdit.Name = "tsBtnEdit"
        Me.tsBtnEdit.Size = New System.Drawing.Size(174, 36)
        Me.tsBtnEdit.Text = "რედაქტირება"
        '
        'tsBtnDelete
        '
        Me.tsBtnDelete.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBtnDelete.Image = Global.patients_crud_app.My.Resources.Resources.delete
        Me.tsBtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnDelete.Name = "tsBtnDelete"
        Me.tsBtnDelete.Size = New System.Drawing.Size(105, 36)
        Me.tsBtnDelete.Text = "წაშლა"
        '
        'tsBtnPanelToggle
        '
        Me.tsBtnPanelToggle.Image = Global.patients_crud_app.My.Resources.Resources.search
        Me.tsBtnPanelToggle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnPanelToggle.Name = "tsBtnPanelToggle"
        Me.tsBtnPanelToggle.RightToLeftAutoMirrorImage = True
        Me.tsBtnPanelToggle.Size = New System.Drawing.Size(99, 36)
        Me.tsBtnPanelToggle.Text = "ძიება"
        '
        'tsBtnExport
        '
        Me.tsBtnExport.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBtnExport.Image = Global.patients_crud_app.My.Resources.Resources.print
        Me.tsBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnExport.Name = "tsBtnExport"
        Me.tsBtnExport.Size = New System.Drawing.Size(207, 36)
        Me.tsBtnExport.Text = "ცხრილში ბეჭდვა"
        '
        'tsBtnDetailExport
        '
        Me.tsBtnDetailExport.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsBtnDetailExport.Image = Global.patients_crud_app.My.Resources.Resources.print
        Me.tsBtnDetailExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnDetailExport.Name = "tsBtnDetailExport"
        Me.tsBtnDetailExport.Size = New System.Drawing.Size(216, 36)
        Me.tsBtnDetailExport.Text = "პაციენტის ბეჭდვა"
        '
        'tsBtnTop50
        '
        Me.tsBtnTop50.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsBtnTop50.Image = Global.patients_crud_app.My.Resources.Resources.top_50
        Me.tsBtnTop50.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnTop50.Name = "tsBtnTop50"
        Me.tsBtnTop50.Size = New System.Drawing.Size(36, 36)
        Me.tsBtnTop50.Text = "TOP 50"
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1228, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(307, 338)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'pnlSearch
        '
        Me.pnlSearch.Controls.Add(Me.btnClear)
        Me.pnlSearch.Controls.Add(Me.btnSearch)
        Me.pnlSearch.Controls.Add(Me.Label1)
        Me.pnlSearch.Controls.Add(Me.cbPatientStatus)
        Me.pnlSearch.Controls.Add(Me.txtPatientEmail)
        Me.pnlSearch.Controls.Add(Me.lblEmail)
        Me.pnlSearch.Controls.Add(Me.txtPatientPersonalNumber)
        Me.pnlSearch.Controls.Add(Me.lblPersonalNumber)
        Me.pnlSearch.Controls.Add(Me.txtPatientFullName)
        Me.pnlSearch.Controls.Add(Me.lblFullName)
        Me.pnlSearch.Controls.Add(Me.txtPatientID)
        Me.pnlSearch.Controls.Add(Me.lbID)
        Me.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearch.Location = New System.Drawing.Point(0, 41)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Size = New System.Drawing.Size(1416, 93)
        Me.pnlSearch.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = Global.patients_crud_app.My.Resources.Resources.trash_can
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Location = New System.Drawing.Point(974, 49)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(234, 38)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "გასუფთავება"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.patients_crud_app.My.Resources.Resources.search
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(974, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(234, 38)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "ძებნა"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(712, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 26)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "სტატუსი:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPatientStatus
        '
        Me.cbPatientStatus.FormattingEnabled = True
        Me.cbPatientStatus.Items.AddRange(New Object() {"აქტიური", "პასიური", "ყველა"})
        Me.cbPatientStatus.Location = New System.Drawing.Point(828, 8)
        Me.cbPatientStatus.Name = "cbPatientStatus"
        Me.cbPatientStatus.Size = New System.Drawing.Size(140, 34)
        Me.cbPatientStatus.TabIndex = 8
        '
        'txtPatientEmail
        '
        Me.txtPatientEmail.Location = New System.Drawing.Point(513, 53)
        Me.txtPatientEmail.Name = "txtPatientEmail"
        Me.txtPatientEmail.Size = New System.Drawing.Size(194, 34)
        Me.txtPatientEmail.TabIndex = 7
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(381, 57)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(127, 26)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "ელ. ფოსტა:"
        '
        'txtPatientPersonalNumber
        '
        Me.txtPatientPersonalNumber.Location = New System.Drawing.Point(513, 8)
        Me.txtPatientPersonalNumber.Name = "txtPatientPersonalNumber"
        Me.txtPatientPersonalNumber.Size = New System.Drawing.Size(194, 34)
        Me.txtPatientPersonalNumber.TabIndex = 5
        '
        'lblPersonalNumber
        '
        Me.lblPersonalNumber.AutoSize = True
        Me.lblPersonalNumber.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonalNumber.Location = New System.Drawing.Point(366, 12)
        Me.lblPersonalNumber.Name = "lblPersonalNumber"
        Me.lblPersonalNumber.Size = New System.Drawing.Size(142, 26)
        Me.lblPersonalNumber.TabIndex = 4
        Me.lblPersonalNumber.Text = "პირ. ნომერი:"
        '
        'txtPatientFullName
        '
        Me.txtPatientFullName.Location = New System.Drawing.Point(167, 49)
        Me.txtPatientFullName.Name = "txtPatientFullName"
        Me.txtPatientFullName.Size = New System.Drawing.Size(194, 34)
        Me.txtPatientFullName.TabIndex = 3
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.Location = New System.Drawing.Point(3, 53)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(164, 26)
        Me.lblFullName.TabIndex = 2
        Me.lblFullName.Text = "გვარი, სახელი:"
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(167, 8)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(194, 34)
        Me.txtPatientID.TabIndex = 1
        '
        'lbID
        '
        Me.lbID.AutoSize = True
        Me.lbID.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(119, 11)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(42, 26)
        Me.lbID.TabIndex = 0
        Me.lbID.Text = "ID:"
        '
        'frmPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1416, 650)
        Me.Controls.Add(Me.gcPatients)
        Me.Controls.Add(Me.pnlSearch)
        Me.Controls.Add(Me.tsMenu)
        Me.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPatients"
        Me.Text = "პაციენტები"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gcPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcPatients As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPatients As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tsMenu As ToolStrip
    Friend WithEvents tsBtnAdd As ToolStripButton
    Friend WithEvents tsBtnEdit As ToolStripButton
    Friend WithEvents tsBtnDelete As ToolStripButton
    Friend WithEvents colID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonalNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGender As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddress As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents tsBtnDetailExport As ToolStripButton
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents pnlSearch As Panel
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents lbID As Label
    Friend WithEvents txtPatientFullName As TextBox
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtPatientEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtPatientPersonalNumber As TextBox
    Friend WithEvents lblPersonalNumber As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbPatientStatus As ComboBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents tsBtnExport As ToolStripButton
    Friend WithEvents tsBtnPanelToggle As ToolStripButton
    Friend WithEvents tsBtnTop50 As ToolStripButton
    Friend WithEvents colInsurance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAddressAndEmail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class

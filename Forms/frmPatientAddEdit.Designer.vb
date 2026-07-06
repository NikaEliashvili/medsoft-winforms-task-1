<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientAddEdit
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.dpDob = New System.Windows.Forms.DateTimePicker()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtLastName = New DevExpress.XtraEditors.TextEdit()
        Me.txtFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.lciFirstName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lciLastName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPhone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciAddress = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciGender = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDob = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.dpDob)
        Me.LayoutControl1.Controls.Add(Me.cbGender)
        Me.LayoutControl1.Controls.Add(Me.btnSave)
        Me.LayoutControl1.Controls.Add(Me.btnCancel)
        Me.LayoutControl1.Controls.Add(Me.txtAddress)
        Me.LayoutControl1.Controls.Add(Me.txtPhone)
        Me.LayoutControl1.Controls.Add(Me.txtLastName)
        Me.LayoutControl1.Controls.Add(Me.txtFirstName)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1396, 66, 975, 600)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1067, 585)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'dpDob
        '
        Me.dpDob.CustomFormat = "dd.MM.yyyy"
        Me.dpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDob.Location = New System.Drawing.Point(128, 80)
        Me.dpDob.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dpDob.Name = "dpDob"
        Me.dpDob.Size = New System.Drawing.Size(923, 34)
        Me.dpDob.TabIndex = 13
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Location = New System.Drawing.Point(128, 116)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(923, 34)
        Me.cbGender.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = Global.patients_crud_app.My.Resources.Resources.save
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(536, 533)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(515, 36)
        Me.btnSave.StyleController = Me.LayoutControl1
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "შენახვა"
        '
        'btnCancel
        '
        Me.btnCancel.ImageOptions.Image = Global.patients_crud_app.My.Resources.Resources.delete
        Me.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCancel.Location = New System.Drawing.Point(16, 533)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(514, 36)
        Me.btnCancel.StyleController = Me.LayoutControl1
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "გაუქმება"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(128, 185)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(923, 26)
        Me.txtAddress.StyleController = Me.LayoutControl1
        Me.txtAddress.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(128, 153)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(923, 26)
        Me.txtPhone.StyleController = Me.LayoutControl1
        Me.txtPhone.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(128, 16)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(923, 26)
        Me.txtLastName.StyleController = Me.LayoutControl1
        Me.txtLastName.TabIndex = 7
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(128, 48)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(923, 26)
        Me.txtFirstName.StyleController = Me.LayoutControl1
        Me.txtFirstName.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.lciLastName, Me.lciPhone, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.lciGender, Me.lciDob, Me.lciFirstName, Me.lciAddress})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1067, 585)
        Me.Root.TextVisible = False
        '
        'lciFirstName
        '
        Me.lciFirstName.Control = Me.txtFirstName
        Me.lciFirstName.Location = New System.Drawing.Point(0, 32)
        Me.lciFirstName.Name = "lciFirstName"
        Me.lciFirstName.Size = New System.Drawing.Size(1041, 32)
        Me.lciFirstName.Text = "სახელი"
        Me.lciFirstName.TextSize = New System.Drawing.Size(96, 19)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.AppearanceItemCaptionDisabled.Options.UseTextOptions = True
        Me.EmptySpaceItem1.AppearanceItemCaptionDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem1.AppearanceItemCaptionDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 201)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1041, 316)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lciLastName
        '
        Me.lciLastName.Control = Me.txtLastName
        Me.lciLastName.Location = New System.Drawing.Point(0, 0)
        Me.lciLastName.Name = "lciLastName"
        Me.lciLastName.Size = New System.Drawing.Size(1041, 32)
        Me.lciLastName.Text = "გვარი"
        Me.lciLastName.TextSize = New System.Drawing.Size(96, 19)
        '
        'lciPhone
        '
        Me.lciPhone.Control = Me.txtPhone
        Me.lciPhone.Location = New System.Drawing.Point(0, 137)
        Me.lciPhone.Name = "lciPhone"
        Me.lciPhone.Size = New System.Drawing.Size(1041, 32)
        Me.lciPhone.Text = "მობ. ნომერი"
        Me.lciPhone.TextSize = New System.Drawing.Size(96, 19)
        '
        'lciAddress
        '
        Me.lciAddress.Control = Me.txtAddress
        Me.lciAddress.Location = New System.Drawing.Point(0, 169)
        Me.lciAddress.Name = "lciAddress"
        Me.lciAddress.Size = New System.Drawing.Size(1041, 32)
        Me.lciAddress.Text = "მისამართი"
        Me.lciAddress.TextSize = New System.Drawing.Size(96, 19)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnCancel
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 517)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(520, 42)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnSave
        Me.LayoutControlItem2.Location = New System.Drawing.Point(520, 517)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(521, 42)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'lciGender
        '
        Me.lciGender.Control = Me.cbGender
        Me.lciGender.Location = New System.Drawing.Point(0, 100)
        Me.lciGender.Name = "lciGender"
        Me.lciGender.Size = New System.Drawing.Size(1041, 37)
        Me.lciGender.Text = "სქესი"
        Me.lciGender.TextSize = New System.Drawing.Size(96, 19)
        '
        'lciDob
        '
        Me.lciDob.Control = Me.dpDob
        Me.lciDob.Location = New System.Drawing.Point(0, 64)
        Me.lciDob.Name = "lciDob"
        Me.lciDob.Size = New System.Drawing.Size(1041, 36)
        Me.lciDob.Text = "დაბ. თარიღი"
        Me.lciDob.TextSize = New System.Drawing.Size(96, 19)
        '
        'frmPatientAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 585)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPatientAddEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents txtAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lciFirstName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lciLastName As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciPhone As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciAddress As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents lciGender As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dpDob As DateTimePicker
    Friend WithEvents lciDob As DevExpress.XtraLayout.LayoutControlItem
End Class

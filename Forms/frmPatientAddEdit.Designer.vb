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
        Me.cbStatus = New System.Windows.Forms.CheckBox()
        Me.dpDob = New System.Windows.Forms.DateTimePicker()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtLastName = New DevExpress.XtraEditors.TextEdit()
        Me.txtFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lciLastName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPhone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciGender = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciDob = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciFirstName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciAddress = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.txtPersonalNumber = New DevExpress.XtraEditors.TextEdit()
        Me.lciPersonalNumber = New DevExpress.XtraLayout.LayoutControlItem()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.lciEmail = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciDob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAddress, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPersonalNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPersonalNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.txtEmail)
        Me.LayoutControl1.Controls.Add(Me.txtPersonalNumber)
        Me.LayoutControl1.Controls.Add(Me.cbStatus)
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
        Me.LayoutControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1396, 66, 975, 600)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(455, 497)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'cbStatus
        '
        Me.cbStatus.Location = New System.Drawing.Point(306, 305)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbStatus.Size = New System.Drawing.Size(137, 30)
        Me.cbStatus.TabIndex = 14
        Me.cbStatus.Text = "აქტიური"
        Me.cbStatus.UseVisualStyleBackColor = True
        '
        'dpDob
        '
        Me.dpDob.CustomFormat = "dd.MM.yyyy"
        Me.dpDob.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDob.Location = New System.Drawing.Point(151, 156)
        Me.dpDob.Margin = New System.Windows.Forms.Padding(4)
        Me.dpDob.Name = "dpDob"
        Me.dpDob.Size = New System.Drawing.Size(292, 34)
        Me.dpDob.TabIndex = 13
        '
        'cbGender
        '
        Me.cbGender.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Location = New System.Drawing.Point(151, 194)
        Me.cbGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(292, 34)
        Me.cbGender.TabIndex = 12
        '
        'btnSave
        '
        Me.btnSave.Appearance.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Appearance.Options.UseFont = True
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.ImageOptions.Image = Global.patients_crud_app.My.Resources.Resources.save
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(257, 449)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(186, 36)
        Me.btnSave.StyleController = Me.LayoutControl1
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "შენახვა"
        '
        'btnCancel
        '
        Me.btnCancel.Appearance.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Appearance.Options.UseFont = True
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.ImageOptions.Image = Global.patients_crud_app.My.Resources.Resources.delete
        Me.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCancel.Location = New System.Drawing.Point(120, 449)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 36)
        Me.btnCancel.StyleController = Me.LayoutControl1
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "გაუქმება"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(151, 269)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Properties.Appearance.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Properties.Appearance.Options.UseFont = True
        Me.txtAddress.Size = New System.Drawing.Size(292, 32)
        Me.txtAddress.StyleController = Me.LayoutControl1
        Me.txtAddress.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(151, 233)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Properties.Appearance.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Properties.Appearance.Options.UseFont = True
        Me.txtPhone.Size = New System.Drawing.Size(292, 32)
        Me.txtPhone.StyleController = Me.LayoutControl1
        Me.txtPhone.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(151, 12)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Properties.Appearance.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Properties.Appearance.Options.UseFont = True
        Me.txtLastName.Size = New System.Drawing.Size(292, 32)
        Me.txtLastName.StyleController = Me.LayoutControl1
        Me.txtLastName.TabIndex = 7
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(151, 48)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Properties.Appearance.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Properties.Appearance.Options.UseFont = True
        Me.txtFirstName.Size = New System.Drawing.Size(292, 32)
        Me.txtFirstName.StyleController = Me.LayoutControl1
        Me.txtFirstName.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.EmptySpaceItem1, Me.lciLastName, Me.lciPhone, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.lciGender, Me.lciDob, Me.lciFirstName, Me.lciAddress, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.EmptySpaceItem3, Me.lciPersonalNumber, Me.lciEmail})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(455, 497)
        Me.Root.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.AppearanceItemCaptionDisabled.Options.UseTextOptions = True
        Me.EmptySpaceItem1.AppearanceItemCaptionDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem1.AppearanceItemCaptionDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 327)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(435, 110)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'lciLastName
        '
        Me.lciLastName.AppearanceItemCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lciLastName.AppearanceItemCaption.Options.UseFont = True
        Me.lciLastName.Control = Me.txtLastName
        Me.lciLastName.Location = New System.Drawing.Point(0, 0)
        Me.lciLastName.Name = "lciLastName"
        Me.lciLastName.Size = New System.Drawing.Size(435, 36)
        Me.lciLastName.Text = "გვარი:"
        Me.lciLastName.TextSize = New System.Drawing.Size(127, 26)
        '
        'lciPhone
        '
        Me.lciPhone.AppearanceItemCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lciPhone.AppearanceItemCaption.Options.UseFont = True
        Me.lciPhone.Control = Me.txtPhone
        Me.lciPhone.Location = New System.Drawing.Point(0, 221)
        Me.lciPhone.Name = "lciPhone"
        Me.lciPhone.Size = New System.Drawing.Size(435, 36)
        Me.lciPhone.Text = "მობ. ნომერი:"
        Me.lciPhone.TextSize = New System.Drawing.Size(127, 26)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnCancel
        Me.LayoutControlItem1.Location = New System.Drawing.Point(108, 437)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(137, 40)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnSave
        Me.LayoutControlItem2.Location = New System.Drawing.Point(245, 437)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(0, 80)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(116, 40)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(190, 40)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'lciGender
        '
        Me.lciGender.AppearanceItemCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lciGender.AppearanceItemCaption.Options.UseFont = True
        Me.lciGender.Control = Me.cbGender
        Me.lciGender.Location = New System.Drawing.Point(0, 182)
        Me.lciGender.Name = "lciGender"
        Me.lciGender.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 6)
        Me.lciGender.Size = New System.Drawing.Size(435, 39)
        Me.lciGender.Text = "სქესი:"
        Me.lciGender.TextSize = New System.Drawing.Size(127, 26)
        '
        'lciDob
        '
        Me.lciDob.AppearanceItemCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lciDob.AppearanceItemCaption.Options.UseFont = True
        Me.lciDob.Control = Me.dpDob
        Me.lciDob.Location = New System.Drawing.Point(0, 144)
        Me.lciDob.Name = "lciDob"
        Me.lciDob.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 6)
        Me.lciDob.Size = New System.Drawing.Size(435, 38)
        Me.lciDob.Text = "დაბ. თარიღი:"
        Me.lciDob.TextSize = New System.Drawing.Size(127, 26)
        '
        'lciFirstName
        '
        Me.lciFirstName.AppearanceItemCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lciFirstName.AppearanceItemCaption.Options.UseFont = True
        Me.lciFirstName.Control = Me.txtFirstName
        Me.lciFirstName.Location = New System.Drawing.Point(0, 36)
        Me.lciFirstName.Name = "lciFirstName"
        Me.lciFirstName.Size = New System.Drawing.Size(435, 36)
        Me.lciFirstName.Text = "სახელი:"
        Me.lciFirstName.TextSize = New System.Drawing.Size(127, 26)
        '
        'lciAddress
        '
        Me.lciAddress.AppearanceItemCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lciAddress.AppearanceItemCaption.Options.UseFont = True
        Me.lciAddress.Control = Me.txtAddress
        Me.lciAddress.Location = New System.Drawing.Point(0, 257)
        Me.lciAddress.Name = "lciAddress"
        Me.lciAddress.Size = New System.Drawing.Size(435, 36)
        Me.lciAddress.Text = "მისამართი:"
        Me.lciAddress.TextSize = New System.Drawing.Size(127, 26)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.cbStatus
        Me.LayoutControlItem3.Location = New System.Drawing.Point(294, 293)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(141, 34)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 437)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(108, 40)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 293)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(294, 34)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'txtPersonalNumber
        '
        Me.txtPersonalNumber.Location = New System.Drawing.Point(151, 84)
        Me.txtPersonalNumber.Name = "txtPersonalNumber"
        Me.txtPersonalNumber.Properties.Appearance.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonalNumber.Properties.Appearance.Options.UseFont = True
        Me.txtPersonalNumber.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txtPersonalNumber.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.txtPersonalNumber.Properties.MaskSettings.Set("mask", "d")
        Me.txtPersonalNumber.Size = New System.Drawing.Size(292, 32)
        Me.txtPersonalNumber.StyleController = Me.LayoutControl1
        Me.txtPersonalNumber.TabIndex = 15
        '
        'lciPersonalNumber
        '
        Me.lciPersonalNumber.AppearanceItemCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lciPersonalNumber.AppearanceItemCaption.Options.UseFont = True
        Me.lciPersonalNumber.Control = Me.txtPersonalNumber
        Me.lciPersonalNumber.Location = New System.Drawing.Point(0, 72)
        Me.lciPersonalNumber.Name = "lciPersonalNumber"
        Me.lciPersonalNumber.Size = New System.Drawing.Size(435, 36)
        Me.lciPersonalNumber.Text = "პირ. ნომერი:"
        Me.lciPersonalNumber.TextSize = New System.Drawing.Size(127, 26)
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(151, 120)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.Appearance.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Properties.Appearance.Options.UseFont = True
        Me.txtEmail.Size = New System.Drawing.Size(292, 32)
        Me.txtEmail.StyleController = Me.LayoutControl1
        Me.txtEmail.TabIndex = 16
        '
        'lciEmail
        '
        Me.lciEmail.AppearanceItemCaption.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lciEmail.AppearanceItemCaption.Options.UseFont = True
        Me.lciEmail.Control = Me.txtEmail
        Me.lciEmail.Location = New System.Drawing.Point(0, 108)
        Me.lciEmail.Name = "lciEmail"
        Me.lciEmail.Size = New System.Drawing.Size(435, 36)
        Me.lciEmail.Text = "ელ. ფოსტა:"
        Me.lciEmail.TextSize = New System.Drawing.Size(127, 26)
        '
        'frmPatientAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 497)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Font = New System.Drawing.Font("Sylfaen", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPatientAddEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciDob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAddress, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPersonalNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPersonalNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciEmail, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbStatus As CheckBox
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPersonalNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lciPersonalNumber As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lciEmail As DevExpress.XtraLayout.LayoutControlItem
End Class

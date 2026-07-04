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
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.txtAddress = New DevExpress.XtraEditors.TextEdit()
        Me.txtPhone = New DevExpress.XtraEditors.TextEdit()
        Me.txtLastName = New DevExpress.XtraEditors.TextEdit()
        Me.txtFirstName = New DevExpress.XtraEditors.TextEdit()
        Me.lciFirstName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciLastName = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciPhone = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lciAddress = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.lciGender = New DevExpress.XtraLayout.LayoutControlItem()
        Me.dpDob = New System.Windows.Forms.DateTimePicker()
        Me.lciDob = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lciAddress, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1396, 66, 975, 600)
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(800, 450)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciFirstName, Me.EmptySpaceItem1, Me.lciLastName, Me.lciPhone, Me.lciAddress, Me.LayoutControlItem1, Me.LayoutControlItem2, Me.lciGender, Me.lciDob})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(800, 450)
        Me.Root.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.AppearanceItemCaptionDisabled.Options.UseTextOptions = True
        Me.EmptySpaceItem1.AppearanceItemCaptionDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.EmptySpaceItem1.AppearanceItemCaptionDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 189)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(780, 201)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'btnCancel
        '
        Me.btnCancel.ImageOptions.Image = Global.patients_crud_app.My.Resources.Resources.delete
        Me.btnCancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnCancel.Location = New System.Drawing.Point(12, 402)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(386, 36)
        Me.btnCancel.StyleController = Me.LayoutControl1
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "გაუქმება"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnCancel
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 390)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(390, 40)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'btnSave
        '
        Me.btnSave.ImageOptions.Image = Global.patients_crud_app.My.Resources.Resources.save
        Me.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btnSave.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSave.Location = New System.Drawing.Point(402, 402)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(386, 36)
        Me.btnSave.StyleController = Me.LayoutControl1
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "შენახვა"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(120, 171)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(668, 26)
        Me.txtAddress.StyleController = Me.LayoutControl1
        Me.txtAddress.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(120, 141)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(668, 26)
        Me.txtPhone.StyleController = Me.LayoutControl1
        Me.txtPhone.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(120, 42)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(668, 26)
        Me.txtLastName.StyleController = Me.LayoutControl1
        Me.txtLastName.TabIndex = 7
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(120, 12)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(668, 26)
        Me.txtFirstName.StyleController = Me.LayoutControl1
        Me.txtFirstName.TabIndex = 4
        '
        'lciFirstName
        '
        Me.lciFirstName.Control = Me.txtFirstName
        Me.lciFirstName.Location = New System.Drawing.Point(0, 0)
        Me.lciFirstName.Name = "lciFirstName"
        Me.lciFirstName.Size = New System.Drawing.Size(780, 30)
        Me.lciFirstName.Text = "სახელი"
        Me.lciFirstName.TextSize = New System.Drawing.Size(96, 19)
        '
        'lciLastName
        '
        Me.lciLastName.Control = Me.txtLastName
        Me.lciLastName.Location = New System.Drawing.Point(0, 30)
        Me.lciLastName.Name = "lciLastName"
        Me.lciLastName.Size = New System.Drawing.Size(780, 30)
        Me.lciLastName.Text = "გვარი"
        Me.lciLastName.TextSize = New System.Drawing.Size(96, 19)
        '
        'lciPhone
        '
        Me.lciPhone.Control = Me.txtPhone
        Me.lciPhone.Location = New System.Drawing.Point(0, 129)
        Me.lciPhone.Name = "lciPhone"
        Me.lciPhone.Size = New System.Drawing.Size(780, 30)
        Me.lciPhone.Text = "მობ. ნომერი"
        Me.lciPhone.TextSize = New System.Drawing.Size(96, 19)
        '
        'lciAddress
        '
        Me.lciAddress.Control = Me.txtAddress
        Me.lciAddress.Location = New System.Drawing.Point(0, 159)
        Me.lciAddress.Name = "lciAddress"
        Me.lciAddress.Size = New System.Drawing.Size(780, 30)
        Me.lciAddress.Text = "მისამართი"
        Me.lciAddress.TextSize = New System.Drawing.Size(96, 19)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnSave
        Me.LayoutControlItem2.Location = New System.Drawing.Point(390, 390)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(390, 40)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'cbGender
        '
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Location = New System.Drawing.Point(120, 106)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(668, 28)
        Me.cbGender.TabIndex = 12
        '
        'lciGender
        '
        Me.lciGender.Control = Me.cbGender
        Me.lciGender.Location = New System.Drawing.Point(0, 94)
        Me.lciGender.Name = "lciGender"
        Me.lciGender.Size = New System.Drawing.Size(780, 35)
        Me.lciGender.Text = "სქესი"
        Me.lciGender.TextSize = New System.Drawing.Size(96, 19)
        '
        'dpDob
        '
        Me.dpDob.Location = New System.Drawing.Point(120, 72)
        Me.dpDob.Name = "dpDob"
        Me.dpDob.Size = New System.Drawing.Size(668, 26)
        Me.dpDob.TabIndex = 13
        '
        'lciDob
        '
        Me.lciDob.Control = Me.dpDob
        Me.lciDob.Location = New System.Drawing.Point(0, 60)
        Me.lciDob.Name = "lciDob"
        Me.lciDob.Size = New System.Drawing.Size(780, 34)
        Me.lciDob.Text = "დაბ. თარიღი"
        Me.lciDob.TextSize = New System.Drawing.Size(96, 19)
        '
        'frmPatientAddEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmPatientAddEdit"
        Me.Text = "frmPatientAddEdit"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLastName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFirstName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciFirstName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciLastName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lciAddress, System.ComponentModel.ISupportInitialize).EndInit()
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

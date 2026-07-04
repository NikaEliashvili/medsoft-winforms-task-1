Public Class frmPatientAddEdit
    Private handler As New PatientsHandler()
    Private currentPatientID As Integer = 0

    Public Sub New(PatientID As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        currentPatientID = PatientID
    End Sub

    Private Sub frmPatientAddEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        handler.GetGenders(cbGender)
        Dim PatientData As New PatientsModel
        If currentPatientID > 0 Then
            PatientData = handler.GetPatientByID(currentPatientID)
            LastName() = PatientData.FullName.Split(" ")(0)
            FirstName() = PatientData.FullName.Split(" ")(1)
            Dob() = PatientData.Dob
            GenderID() = PatientData.GenderID
            Phone() = PatientData.Phone
            Address() = PatientData.Address
        End If

    End Sub

#Region "Properties"
    Public Property FirstName() As String
        Get
            Return txtFirstName.Text.Trim()
        End Get
        Set(value As String)
            txtFirstName.Text = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return txtLastName.Text.Trim()
        End Get
        Set(value As String)
            txtLastName.Text = value
        End Set
    End Property

    Public ReadOnly Property FullName() As String
        Get
            Return $"{LastName()} {FirstName()}"
        End Get
    End Property

    Public Property Dob() As DateTime
        Get
            Return dpDob.Value
        End Get
        Set(value As DateTime)
            dpDob.Value = value
        End Set
    End Property

    Public Property GenderID() As Integer
        Get
            Return cbGender.SelectedValue
        End Get
        Set(value As Integer)
            cbGender.SelectedValue = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return txtPhone.Text
        End Get
        Set(value As String)
            txtPhone.Text = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return txtAddress.Text
        End Get
        Set(value As String)
            txtAddress.Text = value
        End Set
    End Property
#End Region

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Not Phone.StartsWith("5") Then
            MessageBox.Show($"მობ. ნომერი უნდა იწყებოდეს 5-ით.")
            Return
        End If
        If Phone.Length <> 9 Then
            MessageBox.Show($"მობ. ნომერი აუცილებლად უნდა შეიცავდეს 9 ციფრს.")
            Return
        End If

        Dim savedItemID As Integer = handler.SavePatient(currentPatientID, FullName(), Dob(), GenderID(), Phone(), Address())

        If savedItemID > 0 Then
            MessageBox.Show($"პაციენტის მონაცემები შენახულია.")
        End If

    End Sub




End Class
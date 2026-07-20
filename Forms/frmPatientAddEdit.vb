Imports System.Text.RegularExpressions

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
        handler.GetInsurance(cbInsurance)
        Dim PatientData As New PatientsModel
        If currentPatientID > 0 Then
            Me.Text = "პაციენტის რედაქტირება"
            PatientData = handler.GetPatientByID(currentPatientID)
            LastName = PatientData.FullName.Split(" ")(0)
            FirstName = PatientData.FullName.Split(" ")(1)
            PersonalNumber = PatientData.PersonalNumber
            Email = PatientData.Email
            Dob = PatientData.Dob
            GenderID = PatientData.GenderID
            Phone = PatientData.Phone
            Address = PatientData.Address
            InsuranceID = If(IsDBNull(PatientData.InsuranceID), 0, PatientData.InsuranceID)
            IsActive = Not PatientData.IsDelete
        Else
            Me.Text = "პაციენტის დამატება"
            LastName = ""
            FirstName = ""
            PersonalNumber = ""
            Email = ""
            GenderID = 1
            Phone = ""
            Address = ""
            InsuranceID = 0
            IsActive = True
        End If

    End Sub

#Region "Properties"
    Public Property FirstName As String
        Get
            Return txtFirstName.Text.Trim()
        End Get
        Set(value As String)
            txtFirstName.Text = value.Trim()
        End Set
    End Property

    Public Property LastName As String
        Get
            Return txtLastName.Text.Trim()
        End Get
        Set(value As String)
            txtLastName.Text = value.Trim()
        End Set
    End Property
    Public ReadOnly Property FullName As String
        Get
            Return $"{LastName} {FirstName}"
        End Get
    End Property

    Public Property PersonalNumber As String
        Get
            Return txtPersonalNumber.Text.Trim()
        End Get
        Set(value As String)
            txtPersonalNumber.Text = value.Trim()
    End Set
    End Property
    Public Property Email As String
        Get
            Return txtEmail.Text.Trim()
        End Get
        Set(value As String)
            txtEmail.Text = value.Trim()
        End Set
    End Property


    Public Property Dob As DateTime
        Get
            Return dpDob.Value
        End Get
        Set(value As DateTime)
            dpDob.Value = value
        End Set
    End Property

    Public Property GenderID As Integer
        Get
            Return cbGender.SelectedValue
        End Get
        Set(value As Integer)
            cbGender.SelectedValue = value
        End Set
    End Property

    Public Property Phone As String
        Get
            Return txtPhone.Text.Trim()
        End Get
        Set(value As String)
            If Not String.IsNullOrWhiteSpace(value) Then
                txtPhone.Text = value.Trim()
            Else
                txtPhone.Text = String.Empty
            End If
        End Set
    End Property

    Public Property Address As String
        Get
            Return txtAddress.Text.Trim()
        End Get
        Set(value As String)
            txtAddress.Text = value.Trim()
        End Set
    End Property
    Public Property InsuranceID As Integer
        Get
            Return cbInsurance.SelectedValue
        End Get
        Set(value As Integer)
            cbInsurance.SelectedValue = value
        End Set
    End Property

    Public Property IsActive As Boolean
        Get
            Return cbStatus.Checked
        End Get
        Set(value As Boolean)
            cbStatus.Checked = value
        End Set
    End Property
#End Region

    ''' <summary>
    ''' ამოწმებს ელ. ფოსტის ვალიდურობას RegEx-ის პატერნით.
    ''' </summary>
    ''' <param name="email"></param>
    ''' <returns>აბსუნებს Boolean-ს. თუ ვალიდურია => True, თუ არ არის => False</returns>
    Private Function IsEmailValid(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then
            Return True
        End If

        Dim emailPattern As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"

        Return Regex.IsMatch(email, emailPattern)

    End Function


    Public Function hasValidationErrors() As Boolean
        Dim ValidationErrors As New List(Of String)
        'ვამოწმებთ გვარის ველს
        If String.IsNullOrWhiteSpace(LastName) Then
            ValidationErrors.Add("გვარი")
        End If
        'ვამოწმებთ სახელის ველს
        If String.IsNullOrWhiteSpace(FirstName) Then
            ValidationErrors.Add("სახელი")
        End If
        'ვამოწმებთ დაბადების დღეს
        If Not IsDate(Dob) Then
            ValidationErrors.Add("დაბ. თარიღი")
        End If

        'ვამოწმებთ ერორებს და ვაგენერირებს მესიჯს
        Dim JoinedErrors As String = String.Join(", ", ValidationErrors)
        If ValidationErrors.Count > 0 Then
            MessageBox.Show($"გთხოვთ შეავსოთ აუცილებელი {If(ValidationErrors.Count > 1, "ველები", "ველი")}: {JoinedErrors}", "ვალიდაციის ერორი!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If

        'ვამოწმებთ პირ. ნომერს თუ მითითებულია (არა სავალდებულო ველი), ვამოწმებთ პირადი ნომრის სიგრძეს (11 სიმბ.).
        If Not String.IsNullOrWhiteSpace(PersonalNumber) Then
            If PersonalNumber.Length <> 11 Then
                MessageBox.Show("პირ. ნომერი უნდა შეიცავდეს 11 ციფრს.", "ვალიდაციის ერორი!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return True
            End If
        End If

        'ვამოწმებთ ელ. ფოსტას თუ მითითებულია (არა სავალდებულო ველი), ვამოწმებთ ელ. ფოსტის პატერნს.
        If Not IsEmailValid(Email) Then
            MessageBox.Show("გთხოვთ მიუთითოთ სწორი ელ. ფოსტა.", "ვალიდაციის ერორი!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If


        'ვამოწმებთ მობ. ნომერს. თუ ნომერი მითითებულია (არა სავალდებულო ველი), ვამოწმებთ მის ფორმატირების წესს. 
        If Not String.IsNullOrWhiteSpace(Phone) Then
            If Not Phone.StartsWith("5") Then
                MessageBox.Show("მობ. ნომერი უნდა იწყებოდეს 5-ით.", "ვალიდაციის ერორი!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPhone.Focus()
                Return True
            End If

            If Phone.Length <> 9 Then
                MessageBox.Show("მობ. ნომერი აუცილებლად უნდა შეიცავდეს 9 ციფრს.", "ვალიდაციის ერორი!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPhone.Focus()
                Return True
            End If
        End If
        Return False
    End Function



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If hasValidationErrors() Then
            Return
        End If
        Dim patientObj As New PatientsModel()

        patientObj.ID = currentPatientID
        patientObj.FullName = FullName
        patientObj.PersonalNumber = PersonalNumber
        patientObj.Email = Email
        patientObj.Dob = Dob
        patientObj.GenderID = GenderID
        patientObj.Phone = Phone
        patientObj.Address = Address
        patientObj.InsuranceID = InsuranceID
        patientObj.IsDelete = Not IsActive



        Dim savedItemID As Integer = handler.SavePatient(patientObj)

        If savedItemID > 0 Then
            If currentPatientID > 0 Then
                MessageBox.Show("პაციენტის მონაცემები წარმატებით განახლდა.",
                "ოპერაცია წარმატებულია",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information)
            Else
                MessageBox.Show("ახალი პაციენტის მონაცემები წარმატებით დაემატა.", "ოპერაცია წარმატებულია", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If

    End Sub

End Class
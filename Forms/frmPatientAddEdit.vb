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
        Me.Text = "პაციენტის დამატება"
        handler.GetGenders(cbGender)
        Dim PatientData As New PatientsModel
        If currentPatientID > 0 Then
            Me.Text = "პაციენტის რედაქტირება"
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
            txtFirstName.Text = value.Trim()
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return txtLastName.Text.Trim()
        End Get
        Set(value As String)
            txtLastName.Text = value.Trim()
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

    Public Property Address() As String
        Get
            Return txtAddress.Text
        End Get
        Set(value As String)
            txtAddress.Text = value
        End Set
    End Property
#End Region


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

        'ვამოწმებთ მობ. ნომერს. თუ ნომერი მითითებულია, ვამოწმებთ მის ფორმატირების წესს. 
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

        Dim savedItemID As Integer = handler.SavePatient(currentPatientID, FullName(), Dob(), GenderID(), Phone(), Address())

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
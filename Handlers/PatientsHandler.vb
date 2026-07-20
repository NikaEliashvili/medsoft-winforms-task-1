Imports System.Data.SqlClient

Public Class PatientsHandler
    ''' <summary>
    ''' ეძებს პაციენტს ID-ის მიხედვით და აბრუნებს კონკრეტული პაციენტის მონაცამებს. 
    ''' </summary>
    ''' <param name="PatientID"></param>
    ''' <returns>აბრუნებს შესაბამისი პაციენტის მონაცემებს.</returns>
    Public Function GetPatientByID(PatientID As Integer) As PatientsModel
        Dim dt As New DataTable()
        Dim patientModel As New PatientsModel

        Try
            Using Sa As New SqlDataAdapter("dbo.PatientGet", Database.GetConnectionString())
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.SelectCommand.Parameters.AddWithValue("@PatientID", PatientID)
                Sa.Fill(dt)
            End Using

            If dt.Rows.Count > 0 Then
                patientModel.ID = CInt(dt.Rows(0)("ID"))
                patientModel.FullName = dt.Rows(0)("FullName")
                patientModel.Dob = Convert.ToDateTime(dt.Rows(0)("Dob"))
                patientModel.GenderID = CInt(dt.Rows(0)("GenderID"))
                patientModel.Gender = dt.Rows(0)("Gender")
                patientModel.Phone = dt.Rows(0)("Phone").ToString()
                patientModel.Address = dt.Rows(0)("Address").ToString()
                patientModel.Email = dt.Rows(0)("Email").ToString()
                patientModel.InsuranceID = CInt(If(IsDBNull(dt.Rows(0)("InsuranceID")), 0, dt.Rows(0)("InsuranceID")))
                patientModel.InsuranceName = dt.Rows(0)("InsuranceName").ToString()
                patientModel.PersonalNumber = dt.Rows(0)("PersonalNumber").ToString()
                patientModel.IsDelete = dt.Rows(0)("IsDelete")
            End If

        Catch ex As Exception
            MessageBox.Show($"პაციენტის მონაცემების ვერ ჩაიტვირთა. ერორი: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return patientModel
    End Function

    ''' <summary>
    ''' ეძებს პაციენტებს შესაბამისი პარამეტრების მიხედვით. 
    ''' </summary>
    ''' <param name="ID">პაციენტის ID</param>
    ''' <param name="FullName">პაციენტის გვარი სახელი</param>
    ''' <param name="PersonalNumber">პაციენტის პირადი ნომერი</param>
    ''' <param name="Email">პაციენტის ელ. ფოსტა</param>
    ''' <param name="IsDelete">არის თუ არა პაციენტი აქტიური (True/False)</param>
    ''' <returns>აბრუნებს მოძებნილ პაციენტებს.</returns>
    Public Function GetPatientsList(ID As Integer, FullName As String, PersonalNumber As String, Email As String, IsDelete As Integer, Optional Top_50 As Boolean? = Nothing) As DataTable
        Dim dt As New DataTable()

        Try
            Using Sa As New SqlDataAdapter("dbo.PatientListGet", Database.GetConnectionString())
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.SelectCommand.Parameters.AddWithValue("@ID", ID)
                Sa.SelectCommand.Parameters.AddWithValue("@FullName", If(String.IsNullOrWhiteSpace(FullName), "", FullName))
                Sa.SelectCommand.Parameters.AddWithValue("@PersonalNumber", If(String.IsNullOrWhiteSpace(PersonalNumber), "", PersonalNumber))
                Sa.SelectCommand.Parameters.AddWithValue("@Email", If(String.IsNullOrWhiteSpace(Email), "", Email))
                Sa.SelectCommand.Parameters.AddWithValue("@IsDelete", IsDelete)
                Sa.SelectCommand.Parameters.AddWithValue("@TOP_50", If(Top_50.HasValue, Top_50, DBNull.Value))
                Sa.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show($"პაციენტები ვერ ჩაიტვირთა. ერორი: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ''' <summary>
    ''' პაციენტების ID-ების მიხედვით ეძებს კონკრეტულ ჩანაწერებს.
    ''' </summary>
    ''' <param name="idsList">ID-ების ლისტი (DateTable)</param>
    ''' <returns>აბრუნებს მოძებნილი პაციენტების ცხრილს (DateTable)</returns>
    Public Function GetPatientsListByIds(idsList As DataTable) As dsPatientsReport
        Dim ds As New dsPatientsReport()
        Try
            Using Sa As New SqlDataAdapter("dbo.PatientsListGetByIdsReport", Database.GetConnectionString())
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.SelectCommand.Parameters.AddWithValue("@IdsList", idsList)
                Sa.TableMappings.Add("Table", ds.dtPatients.TableName)
                Sa.Fill(ds)
            End Using
        Catch ex As Exception
            MessageBox.Show($"პაციენტები ვერ ჩაიტვირთა. ერორი: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return ds
    End Function



    ''' <summary>
    ''' ინახავს პაციენტის მონაცემებს ბაზაში (მოიცავს ახლის დამატებასა და კონკრეტული ჩანაწერის განახლებას.)
    ''' </summary>
    ''' <param name="patient">პაციენტის მოდელი PatientsModel</param>
    ''' <returns>აბრუნებს შენახული პაციენტის ID-ის.</returns>
    Public Function SavePatient(patient As PatientsModel) As Integer
        Dim updatedPatientID As Integer
        Try
            Using Sc As New SqlCommand("dbo.PatientSet", Database.GetConnectionString())
                Sc.CommandType = CommandType.StoredProcedure

                Sc.Parameters.AddWithValue("@ID", patient.ID)
                Sc.Parameters.AddWithValue("@FullName", patient.FullName)
                Sc.Parameters.AddWithValue("@Dob", patient.Dob)
                Sc.Parameters.AddWithValue("@GenderID", patient.GenderID)
                Sc.Parameters.AddWithValue("@Phone", patient.Phone)
                Sc.Parameters.AddWithValue("@Address", patient.Address)
                Sc.Parameters.AddWithValue("@Email", patient.Email)
                Sc.Parameters.AddWithValue("@PersonalNumber", patient.PersonalNumber)
                Sc.Parameters.AddWithValue("@InsuranceID", If(patient.InsuranceID = 0, DBNull.Value, patient.InsuranceID))
                Sc.Parameters.AddWithValue("@IsDelete", patient.IsDelete)

                If Sc.Connection.State = ConnectionState.Closed Then Sc.Connection.Open()

                updatedPatientID = Convert.ToInt32(Sc.ExecuteScalar())
            End Using
        Catch ex As Exception
            MessageBox.Show($"პაციენტის განახლება ვერ მოხერხდა. ერორი: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw New Exception($"პაციენტის მონაცემების შენახვა ვერ მოხერხდა. ერორი: {ex.Message}")
        End Try
        Return updatedPatientID
    End Function

    ''' <summary>
    ''' შლის პაციენტებს შესაბამისი ID-ების მიხედვით.
    ''' </summary>
    ''' <param name="PatientsIDList"> პაციენტების ID-ების სია </param>
    ''' <returns>აბრუნებს წაშლილი პაციენტების რაოდენობას.</returns>
    Public Function DeletePatients(PatientsIDList As DataTable) As Integer
        If PatientsIDList Is Nothing OrElse PatientsIDList.Rows.Count = 0 Then Return 0
        Dim DeletedRows As Integer = 0

        Try
            Using Sc As New SqlCommand("dbo.PatientDelete", Database.GetConnectionString())
                Sc.CommandType = CommandType.StoredProcedure
                Sc.Parameters.AddWithValue("@PatientsIDList", PatientsIDList)
                Sc.Parameters("@PatientsIDList").TypeName = "dbo.PatientsIDList"

                If Sc.Connection.State = ConnectionState.Closed Then Sc.Connection.Open()
                DeletedRows = Sc.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            MessageBox.Show($"წაშლა ვერ მოხერხდა. ერორი: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw New Exception($"წაშლა ვერ მოხერხდა. ერორი: {ex.Message}")
        End Try
        Return DeletedRows
    End Function

    ''' <summary>
    ''' ტვირთავს Gender List-ს კომბობოქსში.
    ''' </summary>
    ''' <param name="ComboBoxGender"></param>
    Public Sub GetGenders(ComboBoxGender As ComboBox)
        Try
            Using Sa As New SqlDataAdapter("dbo.GenderListGet", Database.GetConnectionString())
                Dim dt As New DataTable()
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.Fill(dt)
                ComboBoxGender.DataSource = dt
                ComboBoxGender.ValueMember = "GenderID"
                ComboBoxGender.DisplayMember = "GenderName"
            End Using
        Catch ex As Exception
            MessageBox.Show($"სქესის ჩატვირთვა ვერ მოხერხდა. შეცდომა: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' ტვირთავს Insurance List-ს კომბობოქსში.
    ''' </summary>
    ''' <param name="ComboBoxGender"></param>
    Public Sub GetInsurance(ComboBoxInsurance As ComboBox)
        Try
            Using Sa As New SqlDataAdapter("dbo.InsuranceListGet", Database.GetConnectionString())
                Dim dt As New DataTable()
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.Fill(dt)

                'ვამატებთ Default მნიშვნელობას, თუ მომხმ.-ს არ აქვს დაზღვევა.
                Dim defaultRow As DataRow = dt.NewRow()
                defaultRow("ID") = 0
                defaultRow("InsuranceName") = "არ აქვს"
                dt.Rows.InsertAt(defaultRow, 0)

                ComboBoxInsurance.DataSource = dt
                ComboBoxInsurance.ValueMember = "ID"
                ComboBoxInsurance.DisplayMember = "InsuranceName"
            End Using
        Catch ex As Exception
            MessageBox.Show($"სქესის ჩატვირთვა ვერ მოხერხდა. შეცდომა: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class

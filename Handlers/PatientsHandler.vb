Imports System.Data.SqlClient

Public Class PatientsHandler

    Public Function GetPatientByID(PatientID As Integer) As PatientsModel
        Dim dt As New DataTable()
        Dim model As New PatientsModel

        Try
            Using Sa As New SqlDataAdapter("dbo.PatientGet", Database.GetConnectionString())
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.SelectCommand.Parameters.AddWithValue("@PatientID", PatientID)
                Sa.Fill(dt)
            End Using

            If dt.Rows.Count > 0 Then
                model.ID = CInt(dt.Rows(0)("ID"))
                model.FullName = dt.Rows(0)("FullName")
                model.Dob = Convert.ToDateTime(dt.Rows(0)("Dob"))
                model.GenderID = CInt(dt.Rows(0)("GenderID"))
                model.Gender = dt.Rows(0)("Gender")
                model.Phone = dt.Rows(0)("Phone")
                model.Address = dt.Rows(0)("Address")
            End If

        Catch ex As Exception
            MessageBox.Show($"პაციენტის მონაცემების ვერ ჩაიტვირთა. ერორი: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return model
    End Function


    Public Function GetPatientsList() As DataTable
        Dim dt As New DataTable()

        Try
            Using Sa As New SqlDataAdapter("dbo.PatientListGet", Database.GetConnectionString())
                Sa.SelectCommand.CommandType = CommandType.StoredProcedure
                Sa.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show($"პაციენტები ვერ ჩაიტვირთა. ერორი: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Protected Friend Function SavePatient(PatientID As Integer, FullName As String, Dob As DateTime, GenderID As Integer, Phone As String, Address As String) As Integer
        Dim updatedPatientID As Integer
        Try
            Using conn As SqlConnection = Database.GetConnectionString()

                Using Sc As New SqlCommand("dbo.PatientSet", conn)
                    Sc.CommandType = CommandType.StoredProcedure

                    Sc.Parameters.AddWithValue("@ID", PatientID)
                    Sc.Parameters.AddWithValue("@FullName", FullName)
                    Sc.Parameters.AddWithValue("@Dob", Dob)
                    Sc.Parameters.AddWithValue("@GenderID", GenderID)
                    Sc.Parameters.AddWithValue("@Phone", Phone)
                    Sc.Parameters.AddWithValue("@Address", Address)

                    conn.Open()

                    updatedPatientID = Convert.ToInt32(Sc.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"პაციენტის განახლება ვერ მოხერხდა. ერორი: {ex.Message}", "დაფიქსირდა შეცდომა", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Throw New Exception($"პაციენტის მონაცემების შენახვა ვერ მოხერხდა. ერორი: {ex.Message}")
        End Try
        Return updatedPatientID
    End Function


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


End Class

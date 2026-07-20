Public Class PatientsModel
    Public Property ID As Integer = 0
    Public Property FullName As String = ""
    Public Property Dob As Date
    Public Property GenderID As Integer
    Public Property Gender As String = ""
    Public Property Phone As String = ""
    Public Property Address As String = ""
    Public Property PersonalNumber As String = ""
    Public Property Email As String = ""
    Public Property InsuranceID As Integer = Nothing
    Public Property InsuranceName As String = ""
    Public Property AddressAndEmail As String = ""
    Public Property IsDelete As Boolean = False
End Class

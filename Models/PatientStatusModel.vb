Public Class PatientStatusModel
    Public Enum PatientStatusEnum
        Active = 1
        Inactive = 0
        All = -1
    End Enum

    Public Sub FillCBWithPatientStatuses(cb As ComboBox)
        Dim AllStatuses As New Dictionary(Of Integer, String) From {
        {PatientStatusEnum.Active, "აქტიური"},
        {PatientStatusEnum.Inactive, "პასიური"},
        {PatientStatusEnum.All, "ყველა"}
        }
        cb.DataSource = AllStatuses.ToList()
        cb.DisplayMember = "Value"
        cb.ValueMember = "Key"
    End Sub


End Class

Public Class frmPatients


    Dim handler As New PatientsHandler()

    Private Sub frmPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gvPatients.OptionsBehavior.AutoPopulateColumns = False
        gcPatients.DataSource = handler.GetPatientsList()
        gvPatients.BestFitColumns()
    End Sub

    Private Sub tsBtnAdd_Click(sender As Object, e As EventArgs) Handles tsBtnAdd.Click
        Dim frmAddEdit As New frmPatientAddEdit(0)
        frmAddEdit.ShowDialog()

    End Sub

    Private Sub tsBtnEdit_Click(sender As Object, e As EventArgs) Handles tsBtnEdit.Click
        Dim patientID As Integer = gvPatients.GetFocusedRowCellValue(colID)
        Dim frmAddEdit As New frmPatientAddEdit(patientID)
        frmAddEdit.ShowDialog()

    End Sub
End Class

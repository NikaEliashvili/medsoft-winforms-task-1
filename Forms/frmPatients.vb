Public Class frmPatients


    Dim handler As New PatientsHandler()

    Private Sub frmPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gcPatients.DataSource = handler.GetPatientsList()
        gvPatients.BestFitColumns()
    End Sub

    Private Sub tsBtnAdd_Click(sender As Object, e As EventArgs) Handles tsBtnAdd.Click
        openAddEditForm(0)
    End Sub

    Private Sub tsBtnEdit_Click(sender As Object, e As EventArgs) Handles tsBtnEdit.Click
        Dim patientID As Integer = gvPatients.GetFocusedRowCellValue(colID)
        openAddEditForm(patientID)
    End Sub

    Private Sub tsBtnDelete_Click(sender As Object, e As EventArgs) Handles tsBtnDelete.Click
        Dim SelectedRows() As Integer = gvPatients.GetSelectedRows()
        Dim IsDialogConfirmed As DialogResult
        If SelectedRows.Length = 0 Then
            MessageBox.Show("აირჩიეთ მინიმუმ 1 პაციენტი.", "ვალიდაციის ერორი", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            IsDialogConfirmed = MessageBox.Show("გსურთ ჩანაწერის წაშლა?", "დადასტურება", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        End If

        If IsDialogConfirmed <> DialogResult.Yes Then
            Return
        End If

        Dim idsList As New DataTable()
        idsList.Columns.Add("ID", GetType(Integer))

        For Each row As Integer In SelectedRows
            If Not gvPatients.IsGroupRow(row) Then
                Dim patientID As Object = gvPatients.GetRowCellValue(row, "ID")
                If patientID IsNot Nothing AndAlso IsNumeric(patientID) Then
                    idsList.Rows.Add(CInt(patientID))
                End If
            End If
        Next

        Dim DeletedRowsCount As Integer = handler.DeletePatients(idsList)

        If DeletedRowsCount <> 0 Then
            gcPatients.DataSource = handler.GetPatientsList()
            MessageBox.Show($"{If(DeletedRowsCount > 0, "პაციენტები", "პაციენტი")} წარმატებით წაიშალა.", "პროცესი წარმატებულია", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("ჩანაწერები ვერ მოიძებნა.", "ერორი", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub openAddEditForm(patientID As Integer)
        Dim frmAddEdit As New frmPatientAddEdit(patientID)
        If frmAddEdit.ShowDialog() = DialogResult.OK Then
            gcPatients.DataSource = handler.GetPatientsList()
        End If
    End Sub

End Class

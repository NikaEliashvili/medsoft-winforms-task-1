Imports DevExpress.XtraReports.UI

Public Class frmPatients

    Dim handler As New PatientsHandler()

    Public Sub New()
        ' ის გაეშვება მანამ, სანამ შენი frmPatients ფორმა საერთოდ გაიღვიძებს.
        DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub frmPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Default მნიშვნელობის მინიჭება ComboBox-ზე.
        cbPatientStatus.SelectedIndex = 0

        updateGCPatients()
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
        Dim patientIdsList As DataTable = FillIdsList(SelectedRows, "ID")
        Dim DeletedRowsCount As Integer = handler.DeletePatients(patientIdsList)

        If DeletedRowsCount <> 0 Then
            updateGCPatients()
            FocusUpdatedPatient(patientIdsList.Rows(0)("ID"))
            MessageBox.Show($"{If(DeletedRowsCount > 0, "პაციენტები", "პაციენტი")} წარმატებით წაიშალა.", "პროცესი წარმატებულია", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("ჩანაწერები ვერ მოიძებნა.", "ერორი", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub openAddEditForm(patientID As Integer)
        Dim frmAddEdit As New frmPatientAddEdit(patientID)
        If frmAddEdit.ShowDialog() = DialogResult.OK Then
            updateGCPatients()
            If patientID > 0 Then
                FocusUpdatedPatient(patientID)
            End If
        End If
    End Sub

    Private Sub FocusUpdatedPatient(patientID As Integer)
        gvPatients.ClearSelection()

        Dim rowHandle As Integer = gvPatients.LocateByValue("ID", patientID)
        gvPatients.SelectRow(rowHandle)
        gvPatients.FocusedRowHandle = rowHandle
    End Sub

    Private Sub updateGCPatients(Optional Top_50 As Boolean? = Nothing)
        Dim ID As Integer
        Integer.TryParse(txtPatientID.Text, ID)
        Dim FullName As String = txtPatientFullName.Text.Trim()
        Dim PersonalNumber As String = txtPatientPersonalNumber.Text.Trim()
        Dim Email As String = txtPatientEmail.Text.Trim()
        Dim Status As Integer = cbPatientStatus.SelectedIndex
        gcPatients.DataSource = handler.GetPatientsList(ID, FullName, PersonalNumber, Email, Status)
    End Sub

    Private Sub ExportPatientData(PatientID As Integer)
        Dim dtPatientID As New DataTable()
        dtPatientID.Columns.Add("ID", GetType(Integer))
        dtPatientID.Rows.Add(PatientID)

        Dim patientData As dsPatientsReport = handler.GetPatientsListByIds(dtPatientID)

        Dim printReport As New XtraPatientReport()
        printReport.DataSource = patientData
        printReport.ShowRibbonPreviewDialog()
    End Sub

    Private Sub ExportPatientsDataTable(idsList As DataTable)
        Dim patientsTable As dsPatientsReport = handler.GetPatientsListByIds(idsList)
        Dim printReport As New XtraPatientsCouple()

        printReport.DataSource = patientsTable

        printReport.ShowRibbonPreviewDialog()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        updateGCPatients()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPatientID.Text = String.Empty
        txtPatientFullName.Text = String.Empty
        txtPatientPersonalNumber.Text = String.Empty
        txtPatientEmail.Text = String.Empty
        cbPatientStatus.SelectedIndex = 0
        updateGCPatients()
    End Sub

    Private Sub tsBtnExport_Click_1(sender As Object, e As EventArgs) Handles tsBtnExport.Click
        Dim selectedPatientsRows() As Integer = gvPatients.GetSelectedRows()

        If selectedPatientsRows.Count = 0 Then
            MessageBox.Show("გთხოვთ აირჩიოთ ერთი ან რამდენიმე პაციენტი.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'გაეშვება რამდენიმე პაციენტისთვის განკუთვნილი ფუნქცია.
        ExportPatientsDataTable(FillIdsList(selectedPatientsRows, "ID"))
        Exit Sub
    End Sub

    Private Sub tsBtnDetailExport_Click(sender As Object, e As EventArgs) Handles tsBtnDetailExport.Click
        Dim selectedPatientRowVal = gvPatients.GetFocusedRowCellValue(colID)
        Dim selectedPatientID As Integer
        If selectedPatientRowVal IsNot Nothing AndAlso IsNumeric(selectedPatientRowVal) Then
            selectedPatientID = CInt(selectedPatientRowVal)
        Else
            MessageBox.Show("გთხოვთ აირჩიოთ პაციენტი.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'გაეშვება ერთი ჩანაწერისთვის განკუთვნილი ფუნქცია.
        ExportPatientData(selectedPatientID)
    End Sub

    Private Sub tsBtnPanelToggle_Click(sender As Object, e As EventArgs) Handles tsBtnPanelToggle.Click
        If pnlSearch.Visible = True Then
            pnlSearch.Visible = False
        Else
            pnlSearch.Visible = True
        End If
    End Sub

    Private Sub tsBtnTop50_Click(sender As Object, e As EventArgs) Handles tsBtnTop50.Click
        If tsBtnTop50.Checked = False Then
            tsBtnTop50.Checked = True
            updateGCPatients(True)
        Else
            tsBtnTop50.Checked = False
            updateGCPatients()
        End If
    End Sub

    ''' <summary>
    ''' ავსებს მონაცემთა ცხრილს დინამიურად. 
    ''' </summary>
    ''' <param name="rows">არჩეული სტრიქონები</param>
    ''' <param name="columnName">სვეტის დასახელება</param>
    ''' <returns>აბრუნებს შევსებულ ცხრილს, გადაცემული სტრიქონების მიხედვით</returns>
    Private Function FillIdsList(rows() As Integer, Optional columnName As String = "ID") As DataTable
        Dim idsList As New DataTable()
        idsList.Columns.Add(columnName, GetType(Integer))

        For Each rowHadle In rows
            Dim rowValue As Object = gvPatients.GetRowCellValue(rowHadle, colID)
            If rowValue IsNot Nothing And IsNumeric(rowValue) Then
                idsList.Rows.Add(CInt(rowValue))
            End If
        Next

        Return idsList
    End Function

End Class

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
        Dim PatientStatus As New PatientStatusModel()

        'კომბობოქსის შევსება - პაციენტის სტატუსებით
        PatientStatus.FillCBWithPatientStatuses(cbPatientStatus)
        'Default მნიშვნელობის მინიჭება ComboBox-ზე.
        cbPatientStatus.SelectedValue = 1

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

        Dim idsList As New DataTable()
        idsList.Columns.Add("ID", GetType(Integer))

        For Each row As Integer In SelectedRows
            Dim patientID As Object = gvPatients.GetRowCellValue(row, "ID")
            If patientID IsNot Nothing AndAlso IsNumeric(patientID) Then
                idsList.Rows.Add(CInt(patientID))
            End If
        Next

        Dim DeletedRowsCount As Integer = handler.DeletePatients(idsList)

        If DeletedRowsCount <> 0 Then
            updateGCPatients()
            MessageBox.Show($"{If(DeletedRowsCount > 0, "პაციენტები", "პაციენტი")} წარმატებით წაიშალა.", "პროცესი წარმატებულია", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("ჩანაწერები ვერ მოიძებნა.", "ერორი", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub openAddEditForm(patientID As Integer)
        Dim frmAddEdit As New frmPatientAddEdit(patientID)
        If frmAddEdit.ShowDialog() = DialogResult.OK Then
            updateGCPatients()
        End If
    End Sub

    Private Sub updateGCPatients(Optional Top_50 As Boolean? = Nothing)
        Dim ID As Integer
        Integer.TryParse(txtPatientID.Text, ID)
        Dim FullName As String = txtPatientFullName.Text.Trim()
        Dim PersonalNumber As String = txtPatientPersonalNumber.Text.Trim()
        Dim Email As String = txtPatientEmail.Text.Trim()
        Dim Status As Integer = Convert.ToInt32(cbPatientStatus.SelectedValue)
        gcPatients.DataSource = handler.GetPatientsList(ID, FullName, PersonalNumber, Email, Status)
    End Sub






    Private Sub ExportPatientData(PatientID As Integer)
        'Dim patientData As DataTable = handler.GetPatientsList(PatientID, String.Empty, String.Empty, String.Empty, -1)
        Dim patientData As PatientsModel = handler.GetPatientByID(PatientID)

        Dim printReport As New XtraPatientReport()

        printReport.DataSource = patientData

        Dim printTool As New ReportPrintTool(printReport)

        printTool.ShowRibbonPreviewDialog()
    End Sub

    Private Sub ExportPatientsDataTable(idsList As DataTable)
        Dim patientsTable As dsPatientsReport = handler.GetPatientsListByIds(idsList)
        Dim printReport As New XtraPatientsCouple()

        printReport.DataSource = patientsTable
        Dim printTool As New ReportPrintTool(printReport)

        printTool.ShowRibbonPreviewDialog()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        updateGCPatients()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPatientID.Text = String.Empty
        txtPatientFullName.Text = String.Empty
        txtPatientPersonalNumber.Text = String.Empty
        txtPatientEmail.Text = String.Empty
        cbPatientStatus.SelectedValue = 1
        updateGCPatients()
    End Sub

    Private Sub tsBtnExport_Click_1(sender As Object, e As EventArgs) Handles tsBtnExport.Click
        Dim selectedPatientsRows() As Integer = gvPatients.GetSelectedRows()

        If selectedPatientsRows.Length = 0 Then
            MessageBox.Show("გთხოვთ აირჩიოთ ერთი ან რამდენიმე პაციენტი.", "გაფრთხილება", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idsList As New DataTable()
        idsList.Columns.Add("ID", GetType(Integer))

        For Each rowHandle In selectedPatientsRows
            Dim patientID As Object = gvPatients.GetRowCellValue(rowHandle, colID)
            If patientID IsNot Nothing And IsNumeric(patientID) Then
                idsList.Rows.Add(CInt(patientID))
            End If
        Next

        'გაეშვება რამდენიმე პაციენტისთვის განკუთვნილი ფუნქცია.
        ExportPatientsDataTable(idsList)
        Exit Sub
    End Sub

    Private Sub tsBtnDetailExport_Click(sender As Object, e As EventArgs) Handles tsBtnDetailExport.Click
        Dim selectedPatientRowVal As Object = gvPatients.GetFocusedRowCellValue(colID)
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
End Class

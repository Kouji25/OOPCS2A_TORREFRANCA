Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
        txtFNameSearch.Enabled = False
        txtLNameSearch.Enabled = False
        txtCourseSearch.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        SaveRecord()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchData()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ans As DialogResult = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = DialogResult.Yes Then
            UpdateRecord(txtUserID.Text, txtFNameSearch.Text, txtLNameSearch.Text, txtCourseSearch.Text)
            MsgBox("Update Successful")
        Else
            MsgBox("Update Cancelled")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim ans As DialogResult = MessageBox.Show("Do you want to delete record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = DialogResult.Yes Then
            DeleteRecord(txtUserID.Text)
            MsgBox("Deletion Successful")
        Else
            MsgBox("Deletion Cancelled")
        End If

    End Sub
End Class

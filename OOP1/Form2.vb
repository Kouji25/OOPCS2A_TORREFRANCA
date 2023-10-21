Public Class Form2
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Dispose()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConnectDbase()
        LoadCourse()
        LoadAllData()

        With dgvData
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeColumns = False
            .AllowUserToResizeRows = False
            .RowsDefaultCellStyle.BackColor = Color.LightBlue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightSteelBlue
        End With
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        If cboCourse.SelectedIndex = 0 Then
            DisplayData("BSIT")
        ElseIf cboCourse.SelectedIndex = 1 Then
            DisplayData("BSCS")
        ElseIf cboCourse.SelectedIndex = 2 Then
            DisplayData("COA")
        ElseIf cboCourse.SelectedIndex = 3 Then
            DisplayData("CBA")
        Else
            MsgBox("No Record Found")

        End If

    End Sub
End Class
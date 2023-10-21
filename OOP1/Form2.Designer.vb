<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        cboCourse = New ComboBox()
        btnDisplay = New Button()
        dgvData = New DataGridView()
        btnBack = New Button()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cboCourse
        ' 
        cboCourse.FormattingEnabled = True
        cboCourse.Location = New Point(67, 101)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(214, 23)
        cboCourse.TabIndex = 0
        ' 
        ' btnDisplay
        ' 
        btnDisplay.Location = New Point(368, 101)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(132, 40)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = True
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(67, 147)
        dgvData.Name = "dgvData"
        dgvData.RowTemplate.Height = 25
        dgvData.Size = New Size(436, 234)
        dgvData.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(254, 421)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 3
        btnBack.Text = "Home"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(653, 502)
        ControlBox = False
        Controls.Add(btnBack)
        Controls.Add(dgvData)
        Controls.Add(btnDisplay)
        Controls.Add(cboCourse)
        Name = "Form2"
        Text = "Form2"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cboCourse As ComboBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents btnBack As Button
End Class

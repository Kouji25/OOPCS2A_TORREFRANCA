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
        cboCourse.Location = New Point(69, 68)
        cboCourse.Name = "cboCourse"
        cboCourse.Size = New Size(202, 25)
        cboCourse.TabIndex = 0
        ' 
        ' btnDisplay
        ' 
        btnDisplay.BackColor = Color.SteelBlue
        btnDisplay.FlatStyle = FlatStyle.Flat
        btnDisplay.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnDisplay.ForeColor = Color.White
        btnDisplay.Location = New Point(292, 62)
        btnDisplay.Name = "btnDisplay"
        btnDisplay.Size = New Size(130, 34)
        btnDisplay.TabIndex = 1
        btnDisplay.Text = "Display"
        btnDisplay.UseVisualStyleBackColor = False
        ' 
        ' dgvData
        ' 
        dgvData.BackgroundColor = Color.LightBlue
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.GridColor = Color.LightBlue
        dgvData.Location = New Point(69, 119)
        dgvData.Name = "dgvData"
        dgvData.RowTemplate.Height = 25
        dgvData.Size = New Size(353, 250)
        dgvData.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.SteelBlue
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(195, 398)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(108, 42)
        btnBack.TabIndex = 3
        btnBack.Text = "Home"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(496, 497)
        ControlBox = False
        Controls.Add(btnBack)
        Controls.Add(dgvData)
        Controls.Add(btnDisplay)
        Controls.Add(cboCourse)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point)
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

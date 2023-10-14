<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        btnInsert = New Button()
        txtCourse = New TextBox()
        txtLName = New TextBox()
        txtFName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightBlue
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btnInsert)
        GroupBox1.Controls.Add(txtCourse)
        GroupBox1.Controls.Add(txtLName)
        GroupBox1.Controls.Add(txtFName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(40, 43)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(273, 217)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Save Records"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 108)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 17)
        Label3.TabIndex = 2
        Label3.Text = "Course"
        ' 
        ' btnInsert
        ' 
        btnInsert.BackColor = Color.SteelBlue
        btnInsert.FlatStyle = FlatStyle.Flat
        btnInsert.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnInsert.ForeColor = SystemColors.ControlLightLight
        btnInsert.Location = New Point(70, 147)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(122, 26)
        btnInsert.TabIndex = 5
        btnInsert.Text = "Save Record"
        btnInsert.UseVisualStyleBackColor = False
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(118, 104)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(114, 23)
        txtCourse.TabIndex = 4
        ' 
        ' txtLName
        ' 
        txtLName.Location = New Point(118, 69)
        txtLName.Name = "txtLName"
        txtLName.Size = New Size(114, 23)
        txtLName.TabIndex = 3
        ' 
        ' txtFName
        ' 
        txtFName.BackColor = Color.White
        txtFName.Location = New Point(118, 33)
        txtFName.Name = "txtFName"
        txtFName.Size = New Size(114, 23)
        txtFName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 17)
        Label2.TabIndex = 1
        Label2.Text = "Last Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 17)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(354, 307)
        Controls.Add(GroupBox1)
        Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents btnInsert As Button
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents txtLName As TextBox
    Friend WithEvents txtFName As TextBox
End Class

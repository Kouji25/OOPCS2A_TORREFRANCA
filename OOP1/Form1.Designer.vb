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
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        txtUserID = New TextBox()
        Label4 = New Label()
        btnSearch = New Button()
        txtCourseSearch = New TextBox()
        txtLNameSearch = New TextBox()
        txtFNameSearch = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
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
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.LightBlue
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(txtUserID)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(btnSearch)
        GroupBox2.Controls.Add(txtCourseSearch)
        GroupBox2.Controls.Add(txtLNameSearch)
        GroupBox2.Controls.Add(txtFNameSearch)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Location = New Point(331, 43)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(273, 217)
        GroupBox2.TabIndex = 6
        GroupBox2.TabStop = False
        GroupBox2.Text = "Search Records"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(38, 36)
        Label7.Name = "Label7"
        Label7.Size = New Size(74, 17)
        Label7.TabIndex = 7
        Label7.Text = "Student ID"
        ' 
        ' txtUserID
        ' 
        txtUserID.BackColor = Color.White
        txtUserID.Location = New Point(129, 33)
        txtUserID.Name = "txtUserID"
        txtUserID.Size = New Size(114, 23)
        txtUserID.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 17)
        Label4.TabIndex = 2
        Label4.Text = "Course"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.SteelBlue
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSearch.ForeColor = SystemColors.ControlLightLight
        btnSearch.Location = New Point(70, 172)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(122, 26)
        btnSearch.TabIndex = 5
        btnSearch.Text = "Search Record"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtCourseSearch
        ' 
        txtCourseSearch.Location = New Point(129, 138)
        txtCourseSearch.Name = "txtCourseSearch"
        txtCourseSearch.Size = New Size(114, 23)
        txtCourseSearch.TabIndex = 4
        ' 
        ' txtLNameSearch
        ' 
        txtLNameSearch.Location = New Point(129, 103)
        txtLNameSearch.Name = "txtLNameSearch"
        txtLNameSearch.Size = New Size(114, 23)
        txtLNameSearch.TabIndex = 3
        ' 
        ' txtFNameSearch
        ' 
        txtFNameSearch.BackColor = Color.White
        txtFNameSearch.Location = New Point(129, 67)
        txtFNameSearch.Name = "txtFNameSearch"
        txtFNameSearch.Size = New Size(114, 23)
        txtFNameSearch.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(36, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 17)
        Label5.TabIndex = 1
        Label5.Text = "Last Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(36, 70)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 17)
        Label6.TabIndex = 0
        Label6.Text = "First Name"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SkyBlue
        ClientSize = New Size(639, 312)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label4 As Label
    Private WithEvents btnSearch As Button
    Friend WithEvents txtCourseSearch As TextBox
    Friend WithEvents txtLNameSearch As TextBox
    Friend WithEvents txtFNameSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

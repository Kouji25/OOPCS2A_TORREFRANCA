Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.Design
Imports K4os.Compression.LZ4.Streams
Imports MySql.Data.MySqlClient

Module Module1

    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String
    Dim dbTable As New DataTable
    Dim adapter As New MySqlDataAdapter

    Public Sub ConnectDbase()
        host = "127.0.0.1"
        dbname = "cs2aoop"
        uname = "root"
        pwd = "password"

        If Not con Is Nothing Then
            con.Close()
            con.ConnectionString = "server =" & host & "; user id =" & uname & "; password =" & pwd & "; database =" & dbname & ""

            Try
                con.Open()
                MessageBox.Show("Connected!")
            Catch ex As Exception

            End Try

        End If
    End Sub

    Public Sub SaveRecord()

        Dim fname = Form1.txtFName.Text
        Dim lname = Form1.txtLName.Text
        Dim course = Form1.txtCourse.Text

        sqlquery = "INSERT INTO students(studFname, studLname, course) VALUES (@fname, @lname, @course)"

        mysqlcmd = New MySqlCommand(sqlquery, con)

        mysqlcmd.Parameters.AddWithValue("@fname", fname)
        mysqlcmd.Parameters.AddWithValue("@lname", lname)
        mysqlcmd.Parameters.AddWithValue("@course", course)

        Try
            mysqlcmd.ExecuteNonQuery()
            MsgBox("Record Saved Successfully")

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        Finally
            Form1.txtFName.Clear()
            Form1.txtLName.Clear()
            Form1.txtCourse.Clear()
        End Try

    End Sub

    Public Sub SearchData()

        Dim uid As String

        sqlquery = "SELECT * FROM students WHERE studid = @uid"
        mysqlcmd = New MySqlCommand(sqlquery, con)
        uid = Form1.txtUserID.Text
        mysqlcmd.Parameters.AddWithValue("@uid", uid)

        Try
            reader = mysqlcmd.ExecuteReader
            If reader.Read Then
                Form1.txtFNameSearch.Text = reader("studFname").ToString
                Form1.txtLNameSearch.Text = reader("studLname").ToString
                Form1.txtCourseSearch.Text = reader("course").ToString
                Form1.btnUpdate.Enabled = True
                Form1.btnDelete.Enabled = True
                Form1.txtFName.Enabled = True
                Form1.txtLName.Enabled = True
                Form1.txtCourse.Enabled = True
            Else
                MsgBox("No Record")
            End If

        Catch ex As Exception
            MsgBox("yayayaya")

        Finally
            reader.Close()

        End Try

    End Sub

    Public Sub LoadAllData()
        sqlquery = "SELECT * FROM students"
        adapter = New MySqlDataAdapter(sqlquery, con)


        Try


            'display the record in your datagridview
            dbTable = New DataTable
            adapter.Fill(dbTable)

            With Form2.dgvData
                .DataSource = dbTable
                .AutoResizeColumns()

            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Public Sub LoadCourse()
        sqlquery = "SELECT course FROM students"

        Try
            mysqlcmd = New MySqlCommand(sqlquery, con)
            reader = mysqlcmd.ExecuteReader

            While reader.Read
                Form2.cboCourse.Items.Add(reader("course").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Public Sub DisplayData(kurso As String)
        sqlquery = "SELECT * FROM students WHERE course = @kurso"
        adapter = New MySqlDataAdapter(sqlquery, con)
        adapter.SelectCommand.Parameters.AddWithValue("@kurso", kurso)

        Try
            'display the record in your datagridview
            dbTable = New DataTable
            adapter.Fill(dbTable)

            With Form2.dgvData
                .DataSource = dbTable
                .AutoResizeColumns()

            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
    End Sub

    Public Sub UpdateRecord(studid As String, fname As String, lname As String, course As String)

        sqlquery = "UPDATE students  set studFname = @fname, studLname = @lname, course = @course WHERE studid = @studid"

        Try
            Using cmd As New MySqlCommand(sqlquery, con)
                cmd.Parameters.AddWithValue("@fname", fname)
                cmd.Parameters.AddWithValue("@lname", lname)
                cmd.Parameters.AddWithValue("@course", course)
                cmd.Parameters.AddWithValue("@studid", studid)

                cmd.ExecuteNonQuery()

            End Using

            MsgBox("Update Successful", vbInformation, "Update Message")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, vbInformation, "Error Message")
        Finally
            Form1.txtFName.Clear()
            Form1.txtLName.Clear()
            Form1.txtCourse.Clear()
            Form1.txtUserID.Clear()

        End Try
    End Sub

End Module

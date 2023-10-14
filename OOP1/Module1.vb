Imports System.Windows.Forms.Design
Imports MySql.Data.MySqlClient

Module Module1

    Dim con As New MySqlConnection
    Dim reader As MySqlDataReader
    Dim mysqlcmd As New MySqlCommand
    Dim host, uname, pwd, dbname As String
    Dim sqlquery As String


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

        sqlquery = "INSERT INTO students(studFName, studLName, Course) VALUES (@fname, @lname, @course)"

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

End Module

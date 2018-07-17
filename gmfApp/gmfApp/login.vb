Imports MySql.Data.MySqlClient

Public Class login
    Private Sub login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tbUsername.MaxLength = 20
        tbPassword.PasswordChar = "*"
        tbUsername.Clear()
        tbPassword.Clear()
    End Sub

    Private Sub buttonLogin_Click(sender As System.Object, e As System.EventArgs) Handles buttonLogin.Click
        If tbUsername.Text = "" Or tbPassword.Text = "" Then
            MsgBox("Insert username and password.")
            Exit Sub
        Else
            Call bukaDB()
            CMD = New MySqlCommand("select * from admin where username='" & tbUsername.Text & "' and password ='" & tbPassword.Text & "'", Conn)
            RD = CMD.ExecuteReader
            RD.Read()
            If RD.HasRows Then
                MessageBox.Show("Login Successful!")
                landingPageMaterial.Show()
                Me.Visible = False
            Else
                MsgBox("Username or Password not valid.")
            End If
        End If

        
    End Sub

   
End Class
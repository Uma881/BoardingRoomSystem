Imports MySql.Data.MySqlClient

Public Class LoginForm

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Focus()
        ApplyTheme()
    End Sub

    Private Sub ApplyTheme()
        If DBConnection.isDarkMode Then
            Me.BackColor = Color.FromArgb(30, 30, 35)
            pnlMain.BackColor = Color.FromArgb(45, 45, 50)   ' Change Panel1 to your actual Panel name
        Else
            Me.BackColor = Color.White
            pnlMain.BackColor = Color.White
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtEmail.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter email and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim hashedPassword As String = DBConnection.HashPassword(txtPassword.Text)

            Dim query As String = "SELECT * FROM users WHERE email = '" & txtEmail.Text.Replace("'", "''") &
                                "' AND password = '" & hashedPassword & "'"

            Dim dt As DataTable = DBConnection.ExecuteQuery(query)

            If dt.Rows.Count > 0 Then
                DBConnection.currentUser = dt
                Dim userId As Integer = Convert.ToInt32(dt.Rows(0)("user_id"))
                DBConnection.LogActivity(userId, "Login", "User logged in")

                MessageBox.Show("Welcome " & dt.Rows(0)("name").ToString() & "!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim role As String = dt.Rows(0)("role").ToString().ToLower()

                ' Temporary - Until other forms are ready
                If role = "admin" Then
                    MessageBox.Show("Admin login successful (Dashboard coming soon)", "Info")
                ElseIf role = "owner" Then
                    MessageBox.Show("Owner login successful (Dashboard coming soon)", "Info")
                Else
                    MessageBox.Show("Student login successful (Dashboard coming soon)", "Info")
                End If

                ' Me.Hide()   ' Uncomment when other forms are created

            Else
                MessageBox.Show("Invalid email or password!", "Login Failed",
                              MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Clear()
                txtPassword.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim regForm As New RegisterForm()
        regForm.ShowDialog()
    End Sub

    Private Sub chkDarkMode_CheckedChanged(sender As Object, e As EventArgs) Handles chkDarkMode.CheckedChanged
        DBConnection.isDarkMode = chkDarkMode.Checked
        ApplyTheme()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Application.Exit()
    End Sub

End Class
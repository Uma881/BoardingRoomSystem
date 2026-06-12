Public Class RegisterForm
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' ... validation same as original ...

        Dim checkQuery As String = "SELECT COUNT(*) FROM users WHERE email = @email"
        Dim params As New Dictionary(Of String, Object) From {{"@email", txtName.Text}}
        Dim dt As DataTable = ExecuteParamQuery(checkQuery, params)

        If Convert.ToInt32(dt.Rows(0)(0)) > 0 Then
            MessageBox.Show("Email already exists!")
            Return
        End If

        Dim hashed As String = HashPassword(txtPassword.Text)
        Dim role As String = If(cmbRole.SelectedItem?.ToString() = "Room Owner", "owner", "student")

        Dim insertQuery As String = "INSERT INTO users (name, email, password, phone, role) VALUES (@name, @email, @pass, @phone, @role)"
        Dim insertParams As New Dictionary(Of String, Object) From {
            {"@name", txtName.Text}, {"@email", txtName.Text},
            {"@pass", hashed}, {"@phone", txtPhone.Text}, {"@role", role}
        }

        If ExecuteNonQueryParam(insertQuery, insertParams) > 0 Then
            MessageBox.Show("Registration successful!")
            Me.Close()
        End If
    End Sub
End Class
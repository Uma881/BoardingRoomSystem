Imports System.Windows.Forms

Public Class AddRoomForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validation
        If String.IsNullOrWhiteSpace(txtTitle.Text) Then
            MessageBox.Show("Please enter room title!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTitle.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtLocation.Text) Then
            MessageBox.Show("Please enter location!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtLocation.Focus()
            Return
        End If

        If nudPrice.Value < 500 Then
            MessageBox.Show("Price must be at least Rs. 500!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Get owner ID
        Dim ownerId As Integer = Convert.ToInt32(currentUser.Rows(0)("user_id"))

        ' Escape quotes to prevent SQL errors
        Dim title As String = txtTitle.Text.Replace("'", "''")
        Dim location As String = txtLocation.Text.Replace("'", "''")
        Dim description As String = txtDescription.Text.Replace("'", "''")
        Dim rules As String = txtRules.Text.Replace("'", "''")
        Dim price As Decimal = nudPrice.Value

        ' Insert query
        Dim query As String = "INSERT INTO rooms (owner_id, title, price, location, description, rules, status) VALUES (" &
                              ownerId & ", '" & title & "', " & price & ", '" & location & "', '" & description & "', '" & rules & "', 'available')"

        Try
            Dim result As Integer = ExecuteNonQuery(query)
            If result > 0 Then
                MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Failed to add room. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
Imports System.Windows.Forms

Public Class OwnerRequestsForm
    Private Sub OwnerRequestsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRequests()
    End Sub

    Private Sub LoadRequests()
        Dim ownerId As Integer = Convert.ToInt32(currentUser.Rows(0)("user_id"))

        Dim query As String = "SELECT b.booking_id, r.title AS room_title, u.name AS student_name, " &
                              "u.phone AS student_phone, b.message, b.request_date, b.status " &
                              "FROM bookings b " &
                              "INNER JOIN rooms r ON b.room_id = r.room_id " &
                              "INNER JOIN users u ON b.student_id = u.user_id " &
                              "WHERE b.owner_id = " & ownerId & " AND b.status = 'pending' " &
                              "ORDER BY b.request_date DESC"

        dgvRequests.DataSource = ExecuteQuery(query)

        ' Hide booking_id column
        If dgvRequests.Columns.Contains("booking_id") Then
            dgvRequests.Columns("booking_id").Visible = False
        End If

        ' Set column headers
        If dgvRequests.Columns.Contains("room_title") Then
            dgvRequests.Columns("room_title").HeaderText = "Room Title"
            dgvRequests.Columns("room_title").Width = 200
        End If
        If dgvRequests.Columns.Contains("student_name") Then
            dgvRequests.Columns("student_name").HeaderText = "Student Name"
            dgvRequests.Columns("student_name").Width = 150
        End If
        If dgvRequests.Columns.Contains("student_phone") Then
            dgvRequests.Columns("student_phone").HeaderText = "Phone"
            dgvRequests.Columns("student_phone").Width = 120
        End If
        If dgvRequests.Columns.Contains("request_date") Then
            dgvRequests.Columns("request_date").HeaderText = "Request Date"
            dgvRequests.Columns("request_date").Width = 120
        End If
        If dgvRequests.Columns.Contains("message") Then
            dgvRequests.Columns("message").HeaderText = "Message"
            dgvRequests.Columns("message").Width = 200
        End If
        If dgvRequests.Columns.Contains("status") Then
            dgvRequests.Columns("status").HeaderText = "Status"
            dgvRequests.Columns("status").Width = 80
        End If

        dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Update instruction based on count
        If dgvRequests.Rows.Count = 0 Then
            lblInstruction.Text = "No pending requests found."
        Else
            lblInstruction.Text = "Select a request and click Accept or Reject (" & dgvRequests.Rows.Count & " pending)"
        End If
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If dgvRequests.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a request first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bookingId As Integer = Convert.ToInt32(dgvRequests.CurrentRow.Cells("booking_id").Value)
        Dim roomTitle As String = dgvRequests.CurrentRow.Cells("room_title").Value.ToString()
        Dim studentName As String = dgvRequests.CurrentRow.Cells("student_name").Value.ToString()

        Dim confirm As DialogResult = MessageBox.Show("Accept " & studentName & "'s request for '" & roomTitle & "'?",
                                                      "Confirm Acceptance", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Try
                Dim updateBooking As String = "UPDATE bookings SET status = 'accepted' WHERE booking_id = " & bookingId
                ExecuteNonQuery(updateBooking)

                Dim getRoomId As String = "SELECT room_id FROM bookings WHERE booking_id = " & bookingId
                Dim roomId As Integer = Convert.ToInt32(ExecuteQuery(getRoomId).Rows(0)(0))
                Dim updateRoom As String = "UPDATE rooms SET status = 'booked' WHERE room_id = " & roomId
                ExecuteNonQuery(updateRoom)

                MessageBox.Show("Request accepted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRequests()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If dgvRequests.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a request first!", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim bookingId As Integer = Convert.ToInt32(dgvRequests.CurrentRow.Cells("booking_id").Value)
        Dim studentName As String = dgvRequests.CurrentRow.Cells("student_name").Value.ToString()

        Dim confirm As DialogResult = MessageBox.Show("Reject " & studentName & "'s request?",
                                                      "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If confirm = DialogResult.Yes Then
            Try
                Dim updateBooking As String = "UPDATE bookings SET status = 'rejected' WHERE booking_id = " & bookingId
                ExecuteNonQuery(updateBooking)

                MessageBox.Show("Request rejected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadRequests()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRequests()
    End Sub
End Class
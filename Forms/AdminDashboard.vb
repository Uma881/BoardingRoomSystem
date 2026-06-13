Public Class AdminDashboard
    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & currentUser.Rows(0)("name").ToString()
        LoadUsers()
        LoadRooms()
        LoadStatistics()
    End Sub

    Private Sub LoadUsers()
        Dim query As String = "SELECT user_id, name, email, phone, role, DATE(created_at) as reg_date " &
                              "FROM users ORDER BY created_at DESC"
        dgvUsers.DataSource = ExecuteQuery(query)

        If dgvUsers.Columns.Contains("user_id") Then dgvUsers.Columns("user_id").Visible = False
        If dgvUsers.Columns.Contains("name") Then dgvUsers.Columns("name").HeaderText = "Name"
        If dgvUsers.Columns.Contains("email") Then dgvUsers.Columns("email").HeaderText = "Email"
        If dgvUsers.Columns.Contains("phone") Then dgvUsers.Columns("phone").HeaderText = "Phone"
        If dgvUsers.Columns.Contains("role") Then dgvUsers.Columns("role").HeaderText = "Role"
        If dgvUsers.Columns.Contains("reg_date") Then dgvUsers.Columns("reg_date").HeaderText = "Registered"

        dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub LoadRooms()
        Dim query As String = "SELECT r.room_id, r.title, r.price, r.location, r.status, " &
                              "u.name as owner_name, DATE(r.created_at) as listed_date " &
                              "FROM rooms r INNER JOIN users u ON r.owner_id = u.user_id " &
                              "ORDER BY r.created_at DESC"
        dgvRooms.DataSource = ExecuteQuery(query)

        If dgvRooms.Columns.Contains("room_id") Then dgvRooms.Columns("room_id").Visible = False
        If dgvRooms.Columns.Contains("title") Then dgvRooms.Columns("title").HeaderText = "Room Title"
        If dgvRooms.Columns.Contains("price") Then dgvRooms.Columns("price").HeaderText = "Price (Rs.)"
        If dgvRooms.Columns.Contains("location") Then dgvRooms.Columns("location").HeaderText = "Location"
        If dgvRooms.Columns.Contains("status") Then dgvRooms.Columns("status").HeaderText = "Status"
        If dgvRooms.Columns.Contains("owner_name") Then dgvRooms.Columns("owner_name").HeaderText = "Owner"
        If dgvRooms.Columns.Contains("listed_date") Then dgvRooms.Columns("listed_date").HeaderText = "Listed On"

        dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub LoadStatistics()
        ' Total Users
        lblTotalUsers.Text = ExecuteQuery("SELECT COUNT(*) FROM users").Rows(0)(0).ToString()

        ' Total Rooms
        lblTotalRooms.Text = ExecuteQuery("SELECT COUNT(*) FROM rooms").Rows(0)(0).ToString()

        ' Total Bookings
        lblTotalBookings.Text = ExecuteQuery("SELECT COUNT(*) FROM bookings").Rows(0)(0).ToString()

        ' Total Owners
        lblTotalOwners.Text = ExecuteQuery("SELECT COUNT(*) FROM users WHERE role = 'owner'").Rows(0)(0).ToString()

        ' Total Students
        lblTotalStudents.Text = ExecuteQuery("SELECT COUNT(*) FROM users WHERE role = 'student'").Rows(0)(0).ToString()

        ' Total Reviews
        lblTotalReviews.Text = ExecuteQuery("SELECT COUNT(*) FROM reviews").Rows(0)(0).ToString()

        ' Room Status
        Dim available As Integer = ExecuteQuery("SELECT COUNT(*) FROM rooms WHERE status = 'available'").Rows(0)(0)
        Dim booked As Integer = ExecuteQuery("SELECT COUNT(*) FROM rooms WHERE status = 'booked'").Rows(0)(0)
        Dim totalRooms As Integer = available + booked

        lblAvailableRooms.Text = "Available Rooms: " & available & " / " & totalRooms
        lblBookedRooms.Text = "Booked Rooms: " & booked & " / " & totalRooms

        If totalRooms > 0 Then
            pbAvailable.Value = CInt((available / totalRooms) * 100)
            pbBooked.Value = CInt((booked / totalRooms) * 100)
        End If
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If dgvUsers.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a user to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userId As Integer = Convert.ToInt32(dgvUsers.CurrentRow.Cells("user_id").Value)
        Dim userName As String = dgvUsers.CurrentRow.Cells("name").Value.ToString()
        Dim userRole As String = dgvUsers.CurrentRow.Cells("role").Value.ToString()

        If userRole = "admin" Then
            MessageBox.Show("Cannot delete admin user!", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("Delete user '" & userName & "'? This will delete all their rooms and bookings!",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            ExecuteNonQuery("DELETE FROM users WHERE user_id = " & userId)
            MessageBox.Show("User deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadUsers()
            LoadStatistics()
        End If
    End Sub

    Private Sub btnDeleteRoom_Click(sender As Object, e As EventArgs) Handles btnDeleteRoom.Click
        If dgvRooms.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a room to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim roomId As Integer = Convert.ToInt32(dgvRooms.CurrentRow.Cells("room_id").Value)
        Dim roomTitle As String = dgvRooms.CurrentRow.Cells("title").Value.ToString()

        Dim confirm As DialogResult = MessageBox.Show("Delete room '" & roomTitle & "'? This will delete all bookings and reviews!",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            ExecuteNonQuery("DELETE FROM rooms WHERE room_id = " & roomId)
            MessageBox.Show("Room deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadRooms()
            LoadStatistics()
        End If
    End Sub

    Private Sub btnRefreshStats_Click(sender As Object, e As EventArgs) Handles btnRefreshStats.Click
        LoadStatistics()
        MessageBox.Show("Statistics refreshed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        currentUser = Nothing
        Me.Close()
        Dim login As New LoginForm()
        login.Show()
    End Sub


End Class
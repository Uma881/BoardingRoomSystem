Public Class OwnerDashboard
    Private Sub OwnerDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome, " & currentUser.Rows(0)("name").ToString()
        LoadMyRooms()
        LoadStatistics()
    End Sub

    Private Sub LoadMyRooms()
        Dim ownerId As Integer = Convert.ToInt32(currentUser.Rows(0)("user_id"))
        Dim query As String = "SELECT room_id, title, price, location, status FROM rooms WHERE owner_id = " & ownerId & " ORDER BY created_at DESC"
        dgvRooms.DataSource = ExecuteQuery(query)

        ' Hide room_id column
        If dgvRooms.Columns.Contains("room_id") Then
            dgvRooms.Columns("room_id").Visible = False
        End If

        ' Set column headers
        If dgvRooms.Columns.Contains("title") Then dgvRooms.Columns("title").HeaderText = "Room Title"
        If dgvRooms.Columns.Contains("price") Then dgvRooms.Columns("price").HeaderText = "Price (Rs.)"
        If dgvRooms.Columns.Contains("location") Then dgvRooms.Columns("location").HeaderText = "Location"
        If dgvRooms.Columns.Contains("status") Then dgvRooms.Columns("status").HeaderText = "Status"

        dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub LoadStatistics()
        Dim ownerId As Integer = Convert.ToInt32(currentUser.Rows(0)("user_id"))

        ' Count rooms
        Dim roomQuery As String = "SELECT COUNT(*) FROM rooms WHERE owner_id = " & ownerId
        lblRoomCount.Text = ExecuteQuery(roomQuery).Rows(0)(0).ToString()

        ' Count pending requests
        Dim reqQuery As String = "SELECT COUNT(*) FROM bookings WHERE owner_id = " & ownerId & " AND status = 'pending'"
        lblRequestCount.Text = ExecuteQuery(reqQuery).Rows(0)(0).ToString()
    End Sub

    Private Sub btnAddRoom_Click(sender As Object, e As EventArgs) Handles btnAddRoom.Click
        Dim addRoomForm As New AddRoomForm()
        addRoomForm.ShowDialog()
        LoadMyRooms()
        LoadStatistics()
    End Sub

    Private Sub btnViewRequests_Click(sender As Object, e As EventArgs) Handles btnViewRequests.Click
        Dim requestsForm As New OwnerRequestsForm()
        requestsForm.ShowDialog()
        LoadStatistics()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadMyRooms()
        LoadStatistics()
        MessageBox.Show("Refreshed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        currentUser = Nothing
        Me.Close()
        Dim loginForm As New LoginForm()
        loginForm.Show()
    End Sub
End Class
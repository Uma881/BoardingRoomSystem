Public Class MyRequestsForm
    Private Sub MyRequestsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMyRequests()
    End Sub

    Private Sub LoadMyRequests()
        Dim studentId As Integer = Convert.ToInt32(currentUser.Rows(0)("user_id"))

        Dim query As String = "SELECT b.booking_id, b.room_id, r.title, r.price, r.location, " &
                              "b.status, b.request_date, b.review_given " &
                              "FROM bookings b " &
                              "INNER JOIN rooms r ON b.room_id = r.room_id " &
                              "WHERE b.student_id = " & studentId & " " &
                              "ORDER BY b.request_date DESC"

        dgvRequests.DataSource = ExecuteQuery(query)

        ' Hide ID columns
        If dgvRequests.Columns.Contains("booking_id") Then dgvRequests.Columns("booking_id").Visible = False
        If dgvRequests.Columns.Contains("room_id") Then dgvRequests.Columns("room_id").Visible = False

        ' Set column headers
        If dgvRequests.Columns.Contains("title") Then dgvRequests.Columns("title").HeaderText = "Room Title"
        If dgvRequests.Columns.Contains("price") Then dgvRequests.Columns("price").HeaderText = "Price (Rs.)"
        If dgvRequests.Columns.Contains("location") Then dgvRequests.Columns("location").HeaderText = "Location"
        If dgvRequests.Columns.Contains("status") Then dgvRequests.Columns("status").HeaderText = "Status"
        If dgvRequests.Columns.Contains("request_date") Then dgvRequests.Columns("request_date").HeaderText = "Request Date"
        If dgvRequests.Columns.Contains("review_given") Then dgvRequests.Columns("review_given").Visible = False

        ' Add Review Button Column
        If Not dgvRequests.Columns.Contains("btnReview") Then
            Dim btnCol As New DataGridViewButtonColumn()
            btnCol.Name = "btnReview"
            btnCol.HeaderText = "Action"
            btnCol.Text = "WRITE REVIEW"
            btnCol.UseColumnTextForButtonValue = True
            btnCol.Width = 120
            dgvRequests.Columns.Add(btnCol)
        End If

        dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRequests.AllowUserToAddRows = False
        dgvRequests.ReadOnly = True

        UpdateInstructionLabel()
    End Sub

    Private Sub UpdateInstructionLabel()
        ' Count how many accepted bookings without review
        Dim studentId As Integer = Convert.ToInt32(currentUser.Rows(0)("user_id"))
        Dim query As String = "SELECT COUNT(*) FROM bookings b " &
                              "WHERE b.student_id = " & studentId & " " &
                              "AND b.status = 'accepted' AND b.review_given = FALSE"

        Dim count As Integer = Convert.ToInt32(ExecuteQuery(query).Rows(0)(0))

        If count > 0 Then
            lblInstruction.Text = "📝 You have " & count & " completed booking(s) ready for review! Click 'WRITE REVIEW' button."
            lblInstruction.ForeColor = Color.Green
            lblInstruction.Font = New Font(lblInstruction.Font, FontStyle.Bold)
        Else
            lblInstruction.Text = "✅ No pending reviews. Come back after your booking is accepted!"
            lblInstruction.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub dgvRequests_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequests.CellClick
        ' Check if clicked on button column
        If e.RowIndex < 0 Then Return

        If dgvRequests.Columns(e.ColumnIndex).Name = "btnReview" Then
            Dim status As String = dgvRequests.Rows(e.RowIndex).Cells("status").Value.ToString()
            Dim reviewGiven As Boolean = False

            ' Check if review_given column exists
            If dgvRequests.Columns.Contains("review_given") Then
                reviewGiven = Convert.ToBoolean(dgvRequests.Rows(e.RowIndex).Cells("review_given").Value)
            End If

            ' Only allow review if status is 'accepted' and review not given
            If status = "accepted" AndAlso Not reviewGiven Then
                Dim bookingId As Integer = Convert.ToInt32(dgvRequests.Rows(e.RowIndex).Cells("booking_id").Value)
                Dim roomId As Integer = Convert.ToInt32(dgvRequests.Rows(e.RowIndex).Cells("room_id").Value)
                Dim roomTitle As String = dgvRequests.Rows(e.RowIndex).Cells("title").Value.ToString()

                ' Open review form
                Dim reviewForm As New AddReviewForm(bookingId, roomId, roomTitle)
                reviewForm.ShowDialog()

                ' Refresh the list after review is submitted
                LoadMyRequests()
            ElseIf status <> "accepted" Then
                MessageBox.Show("You can only review bookings that have been ACCEPTED by the owner.",
                                "Cannot Review", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf reviewGiven Then
                MessageBox.Show("You have already submitted a review for this booking.",
                                "Review Already Given", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
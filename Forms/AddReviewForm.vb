Public Class AddReviewForm
    Private bookingId As Integer
    Private roomId As Integer
    Private roomTitle As String

    Public Sub New(bId As Integer, rId As Integer, title As String)
        InitializeComponent()
        bookingId = bId
        roomId = rId
        roomTitle = title
    End Sub

    Private Sub AddReviewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRoomTitle.Text = "WRITE REVIEW FOR: " & roomTitle.ToUpper()
        nudRating.Value = 5
        UpdateRatingDisplay()
    End Sub

    Private Sub UpdateRatingDisplay()
        Dim rating As Integer = Convert.ToInt32(nudRating.Value)
        Dim stars As String = ""
        For i As Integer = 1 To rating
            stars &= "⭐"
        Next
        For i As Integer = rating + 1 To 5
            stars &= "☆"
        Next
        lblStars.Text = stars
    End Sub

    Private Sub nudRating_ValueChanged(sender As Object, e As EventArgs) Handles nudRating.ValueChanged
        UpdateRatingDisplay()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Validation
        If String.IsNullOrWhiteSpace(txtReview.Text) Then
            MessageBox.Show("Please write your review!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtReview.Focus()
            Return
        End If

        If txtReview.Text.Length < 10 Then
            MessageBox.Show("Please write at least 10 characters for your review!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtReview.Focus()
            Return
        End If

        Try
            Dim studentId As Integer = Convert.ToInt32(currentUser.Rows(0)("user_id"))
            Dim rating As Integer = Convert.ToInt32(nudRating.Value)
            Dim reviewText As String = txtReview.Text.Replace("'", "''")

            ' Get owner ID from room
            Dim ownerQuery As String = "SELECT owner_id FROM rooms WHERE room_id = " & roomId
            Dim ownerId As Integer = Convert.ToInt32(ExecuteQuery(ownerQuery).Rows(0)(0))

            ' Check if review already exists (double protection)
            Dim checkQuery As String = "SELECT COUNT(*) FROM reviews WHERE booking_id = " & bookingId
            Dim existingCount As Integer = Convert.ToInt32(ExecuteQuery(checkQuery).Rows(0)(0))

            If existingCount > 0 Then
                MessageBox.Show("You have already submitted a review for this booking!",
                                "Duplicate Review", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Return
            End If

            ' Insert review
            Dim insertQuery As String = "INSERT INTO reviews (booking_id, room_id, student_id, owner_id, rating, review_text) " &
                                        "VALUES (" & bookingId & ", " & roomId & ", " & studentId & ", " & ownerId & ", " & rating & ", '" & reviewText & "')"

            Dim result As Integer = ExecuteNonQuery(insertQuery)

            If result > 0 Then
                ' Update booking to mark review as given
                ExecuteNonQuery("UPDATE bookings SET review_given = TRUE WHERE booking_id = " & bookingId)

                MessageBox.Show("✅ Review submitted successfully! Thank you for your feedback.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Failed to submit review. Please try again!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
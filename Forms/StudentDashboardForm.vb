Imports MySql.Data.MySqlClient

Public Class StudentDashboardForm
    Inherits System.Windows.Forms.Form

    Private allRooms As DataTable

    Private Sub StudentDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserName.Text = "Welcome, " & DBConnection.currentUser.Rows(0)("name").ToString()
        LoadAvailableRooms()
        ApplyTheme()
    End Sub

    Private Sub ApplyTheme()
        If DBConnection.isDarkMode Then
            Me.BackColor = Color.FromArgb(30, 30, 35)
            For Each ctrl As Control In Me.Controls
                ApplyDarkStyle(ctrl)
            Next
        Else
            Me.BackColor = Color.White
            For Each ctrl As Control In Me.Controls
                ApplyLightStyle(ctrl)
            Next
        End If
    End Sub

    Private Sub ApplyDarkStyle(ctrl As Control)
        If TypeOf ctrl Is Label Then ctrl.ForeColor = Color.White
        If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox OrElse TypeOf ctrl Is NumericUpDown Then
            ctrl.BackColor = Color.FromArgb(50, 50, 55)
            ctrl.ForeColor = Color.White
        End If
        If TypeOf ctrl Is Button Then
            ctrl.BackColor = Color.FromArgb(70, 70, 75)
            ctrl.ForeColor = Color.White
        End If
        If TypeOf ctrl Is DataGridView Then
            Dim dgv = CType(ctrl, DataGridView)
            dgv.BackgroundColor = Color.FromArgb(40, 40, 45)
            dgv.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 50)
            dgv.DefaultCellStyle.ForeColor = Color.White
        End If
    End Sub

    Private Sub ApplyLightStyle(ctrl As Control)
        If TypeOf ctrl Is Label Then ctrl.ForeColor = Color.Black
        If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox OrElse TypeOf ctrl Is NumericUpDown Then
            ctrl.BackColor = Color.White
            ctrl.ForeColor = Color.Black
        End If
        If TypeOf ctrl Is Button Then
            ctrl.BackColor = SystemColors.Control
            ctrl.ForeColor = Color.Black
        End If
    End Sub

    Private Sub LoadAvailableRooms()
        Dim query As String = "SELECT r.room_id, r.title, r.price, r.location, r.description, r.rules, " &
                             "r.avg_rating, r.total_reviews, u.name as owner_name, u.phone as owner_phone " &
                             "FROM rooms r INNER JOIN users u ON r.owner_id = u.user_id " &
                             "WHERE r.status = 'available' ORDER BY r.created_at DESC"
        allRooms = DBConnection.ExecuteQuery(query)
        ApplyFilters()
        LoadLocations()
    End Sub

    Private Sub LoadLocations()
        cmbLocation.Items.Clear()
        cmbLocation.Items.Add("All Locations")
        For Each row As DataRow In allRooms.Rows
            Dim loc As String = row("location").ToString()
            If Not cmbLocation.Items.Contains(loc) Then cmbLocation.Items.Add(loc)
        Next
        cmbLocation.SelectedIndex = 0
    End Sub

    Private Sub ApplyFilters()
        ' Filter logic...
        Dim filtered As DataTable = allRooms.Clone()
        ' ... (full filter code from earlier message)
        dgvRooms.DataSource = filtered
    End Sub

    ' Add other button events (btnViewDetails_Click, btnLogout_Click etc.) as per previous messages

End Class
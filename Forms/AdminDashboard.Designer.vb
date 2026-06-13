<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.tpUsers = New System.Windows.Forms.TabPage()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.tpRooms = New System.Windows.Forms.TabPage()
        Me.btnDeleteRoom = New System.Windows.Forms.Button()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.tpStats = New System.Windows.Forms.TabPage()
        Me.btnRefreshStats = New System.Windows.Forms.Button()
        Me.lblBookedRooms = New System.Windows.Forms.Label()
        Me.lblTotalOwners = New System.Windows.Forms.Label()
        Me.lblTotalStudents = New System.Windows.Forms.Label()
        Me.lblTotalBookings = New System.Windows.Forms.Label()
        Me.lblTotalRooms = New System.Windows.Forms.Label()
        Me.lblAvailableRooms = New System.Windows.Forms.Label()
        Me.lblTotalUsers = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.lblTotalReviews = New System.Windows.Forms.Label()
        Me.pbAvailable = New System.Windows.Forms.ProgressBar()
        Me.pbBooked = New System.Windows.Forms.ProgressBar()
        Me.tabControl.SuspendLayout()
        Me.tpUsers.SuspendLayout()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRooms.SuspendLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWelcome.Font = New System.Drawing.Font("High Tower Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblWelcome.Location = New System.Drawing.Point(12, 26)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(264, 31)
        Me.lblWelcome.TabIndex = 3
        Me.lblWelcome.Text = "Welcome , Admin User"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Goudy Stout", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(253, 95)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(508, 43)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Admin Dashboard"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tpUsers)
        Me.tabControl.Controls.Add(Me.tpRooms)
        Me.tabControl.Controls.Add(Me.tpStats)
        Me.tabControl.Font = New System.Drawing.Font("MS PMincho", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(12, 175)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(1008, 485)
        Me.tabControl.TabIndex = 5
        '
        'tpUsers
        '
        Me.tpUsers.BackgroundImage = Global.BoardingRoomSystem.My.Resources.Resources.Watercolor_Water_Sea_LinkedIn_Article_Cover_Image
        Me.tpUsers.Controls.Add(Me.btnDeleteUser)
        Me.tpUsers.Controls.Add(Me.dgvUsers)
        Me.tpUsers.Font = New System.Drawing.Font("MS PMincho", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpUsers.Location = New System.Drawing.Point(4, 28)
        Me.tpUsers.Name = "tpUsers"
        Me.tpUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tpUsers.Size = New System.Drawing.Size(1000, 453)
        Me.tpUsers.TabIndex = 0
        Me.tpUsers.Text = "Manage Users"
        Me.tpUsers.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnDeleteUser.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteUser.Location = New System.Drawing.Point(371, 396)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(258, 40)
        Me.btnDeleteUser.TabIndex = 17
        Me.btnDeleteUser.Text = "Delete Selected Users"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(6, 36)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.RowHeadersWidth = 51
        Me.dgvUsers.RowTemplate.Height = 24
        Me.dgvUsers.Size = New System.Drawing.Size(991, 341)
        Me.dgvUsers.TabIndex = 1
        '
        'tpRooms
        '
        Me.tpRooms.BackgroundImage = Global.BoardingRoomSystem.My.Resources.Resources.Green_and_Beige_Watercolor_Floral_Background_Poster
        Me.tpRooms.Controls.Add(Me.btnDeleteRoom)
        Me.tpRooms.Controls.Add(Me.dgvRooms)
        Me.tpRooms.Location = New System.Drawing.Point(4, 28)
        Me.tpRooms.Name = "tpRooms"
        Me.tpRooms.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRooms.Size = New System.Drawing.Size(1000, 453)
        Me.tpRooms.TabIndex = 1
        Me.tpRooms.Text = "Manage Rooms"
        Me.tpRooms.UseVisualStyleBackColor = True
        '
        'btnDeleteRoom
        '
        Me.btnDeleteRoom.BackColor = System.Drawing.SystemColors.GrayText
        Me.btnDeleteRoom.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteRoom.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDeleteRoom.Location = New System.Drawing.Point(371, 392)
        Me.btnDeleteRoom.Name = "btnDeleteRoom"
        Me.btnDeleteRoom.Size = New System.Drawing.Size(258, 40)
        Me.btnDeleteRoom.TabIndex = 18
        Me.btnDeleteRoom.Text = "Delete Selected Room"
        Me.btnDeleteRoom.UseVisualStyleBackColor = False
        '
        'dgvRooms
        '
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(3, 33)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.RowHeadersWidth = 51
        Me.dgvRooms.RowTemplate.Height = 24
        Me.dgvRooms.Size = New System.Drawing.Size(991, 341)
        Me.dgvRooms.TabIndex = 2
        '
        'tpStats
        '
        Me.tpStats.BackgroundImage = Global.BoardingRoomSystem.My.Resources.Resources.Professional_background_image_for_student_dashboard_of_boarding_room_finding_system__clean_modern_interface_design__soft_gradients_in_blue_and_white_tones__subtle_geometric_patterns__minimalist_style__organized___1_
        Me.tpStats.Controls.Add(Me.pbBooked)
        Me.tpStats.Controls.Add(Me.pbAvailable)
        Me.tpStats.Controls.Add(Me.lblTotalReviews)
        Me.tpStats.Controls.Add(Me.btnRefreshStats)
        Me.tpStats.Controls.Add(Me.lblBookedRooms)
        Me.tpStats.Controls.Add(Me.lblTotalOwners)
        Me.tpStats.Controls.Add(Me.lblTotalStudents)
        Me.tpStats.Controls.Add(Me.lblTotalBookings)
        Me.tpStats.Controls.Add(Me.lblTotalRooms)
        Me.tpStats.Controls.Add(Me.lblAvailableRooms)
        Me.tpStats.Controls.Add(Me.lblTotalUsers)
        Me.tpStats.Location = New System.Drawing.Point(4, 28)
        Me.tpStats.Name = "tpStats"
        Me.tpStats.Padding = New System.Windows.Forms.Padding(3)
        Me.tpStats.Size = New System.Drawing.Size(1000, 453)
        Me.tpStats.TabIndex = 2
        Me.tpStats.Text = "Statistics"
        Me.tpStats.UseVisualStyleBackColor = True
        '
        'btnRefreshStats
        '
        Me.btnRefreshStats.BackColor = System.Drawing.SystemColors.Info
        Me.btnRefreshStats.Font = New System.Drawing.Font("Microsoft Uighur", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefreshStats.Location = New System.Drawing.Point(359, 404)
        Me.btnRefreshStats.Name = "btnRefreshStats"
        Me.btnRefreshStats.Size = New System.Drawing.Size(202, 43)
        Me.btnRefreshStats.TabIndex = 17
        Me.btnRefreshStats.Text = "Refresh Statistics"
        Me.btnRefreshStats.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRefreshStats.UseVisualStyleBackColor = False
        '
        'lblBookedRooms
        '
        Me.lblBookedRooms.BackColor = System.Drawing.Color.Transparent
        Me.lblBookedRooms.Font = New System.Drawing.Font("MS PMincho", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookedRooms.Location = New System.Drawing.Point(59, 316)
        Me.lblBookedRooms.Name = "lblBookedRooms"
        Me.lblBookedRooms.Size = New System.Drawing.Size(201, 71)
        Me.lblBookedRooms.TabIndex = 6
        Me.lblBookedRooms.Text = "Booked Rooms: 0"
        Me.lblBookedRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalOwners
        '
        Me.lblTotalOwners.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotalOwners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalOwners.Font = New System.Drawing.Font("MS PMincho", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalOwners.Location = New System.Drawing.Point(276, 38)
        Me.lblTotalOwners.Name = "lblTotalOwners"
        Me.lblTotalOwners.Size = New System.Drawing.Size(201, 71)
        Me.lblTotalOwners.TabIndex = 5
        Me.lblTotalOwners.Text = "Total Owners: 0"
        Me.lblTotalOwners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalStudents
        '
        Me.lblTotalStudents.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalStudents.Font = New System.Drawing.Font("MS PMincho", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalStudents.Location = New System.Drawing.Point(520, 38)
        Me.lblTotalStudents.Name = "lblTotalStudents"
        Me.lblTotalStudents.Size = New System.Drawing.Size(201, 71)
        Me.lblTotalStudents.TabIndex = 4
        Me.lblTotalStudents.Text = "Total Students: 0"
        Me.lblTotalStudents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalBookings
        '
        Me.lblTotalBookings.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotalBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalBookings.Font = New System.Drawing.Font("MS PMincho", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBookings.Location = New System.Drawing.Point(252, 154)
        Me.lblTotalBookings.Name = "lblTotalBookings"
        Me.lblTotalBookings.Size = New System.Drawing.Size(201, 71)
        Me.lblTotalBookings.TabIndex = 3
        Me.lblTotalBookings.Text = "Total Bookings: 0"
        Me.lblTotalBookings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalRooms
        '
        Me.lblTotalRooms.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotalRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalRooms.Font = New System.Drawing.Font("MS PMincho", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRooms.Location = New System.Drawing.Point(763, 38)
        Me.lblTotalRooms.Name = "lblTotalRooms"
        Me.lblTotalRooms.Size = New System.Drawing.Size(201, 71)
        Me.lblTotalRooms.TabIndex = 2
        Me.lblTotalRooms.Text = "Total Rooms: 0"
        Me.lblTotalRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAvailableRooms
        '
        Me.lblAvailableRooms.BackColor = System.Drawing.Color.Transparent
        Me.lblAvailableRooms.Font = New System.Drawing.Font("MS PMincho", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableRooms.Location = New System.Drawing.Point(68, 255)
        Me.lblAvailableRooms.Name = "lblAvailableRooms"
        Me.lblAvailableRooms.Size = New System.Drawing.Size(192, 61)
        Me.lblAvailableRooms.TabIndex = 1
        Me.lblAvailableRooms.Text = "Available Rooms: 0"
        Me.lblAvailableRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalUsers
        '
        Me.lblTotalUsers.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotalUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalUsers.Font = New System.Drawing.Font("MS PMincho", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsers.Location = New System.Drawing.Point(34, 38)
        Me.lblTotalUsers.Name = "lblTotalUsers"
        Me.lblTotalUsers.Size = New System.Drawing.Size(201, 71)
        Me.lblTotalUsers.TabIndex = 0
        Me.lblTotalUsers.Text = "Total Users: 0"
        Me.lblTotalUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Info
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(901, 26)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(96, 38)
        Me.btnLogout.TabIndex = 16
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'lblTotalReviews
        '
        Me.lblTotalReviews.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblTotalReviews.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalReviews.Font = New System.Drawing.Font("MS PMincho", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalReviews.Location = New System.Drawing.Point(544, 154)
        Me.lblTotalReviews.Name = "lblTotalReviews"
        Me.lblTotalReviews.Size = New System.Drawing.Size(201, 71)
        Me.lblTotalReviews.TabIndex = 18
        Me.lblTotalReviews.Text = "Total Reviews: 0"
        Me.lblTotalReviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbAvailable
        '
        Me.pbAvailable.Location = New System.Drawing.Point(308, 282)
        Me.pbAvailable.Name = "pbAvailable"
        Me.pbAvailable.Size = New System.Drawing.Size(645, 23)
        Me.pbAvailable.TabIndex = 19
        '
        'pbBooked
        '
        Me.pbBooked.Location = New System.Drawing.Point(308, 341)
        Me.pbBooked.Name = "pbBooked"
        Me.pbBooked.Size = New System.Drawing.Size(645, 23)
        Me.pbBooked.TabIndex = 20
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BoardingRoomSystem.My.Resources.Resources.Professional_dark_theme_background_image_for_student_dashboard_of_boarding_room_finding_system__modern_dark_interface_design__deep_navy_blue_and_dark_gray_tones__subtle_geometric_patterns__minimalist_style__orga__1_
        Me.ClientSize = New System.Drawing.Size(1019, 835)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblWelcome)
        Me.Name = "AdminDashboard"
        Me.Text = "AdminDashboard"
        Me.tabControl.ResumeLayout(False)
        Me.tpUsers.ResumeLayout(False)
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRooms.ResumeLayout(False)
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpStats.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents tabControl As TabControl
    Friend WithEvents tpUsers As TabPage
    Friend WithEvents tpRooms As TabPage
    Friend WithEvents tpStats As TabPage
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents dgvUsers As DataGridView
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnDeleteRoom As Button
    Friend WithEvents lblTotalUsers As Label
    Friend WithEvents lblTotalOwners As Label
    Friend WithEvents lblTotalStudents As Label
    Friend WithEvents lblTotalBookings As Label
    Friend WithEvents lblTotalRooms As Label
    Friend WithEvents lblAvailableRooms As Label
    Friend WithEvents lblBookedRooms As Label
    Friend WithEvents btnRefreshStats As Button
    Friend WithEvents lblTotalReviews As Label
    Friend WithEvents pbBooked As ProgressBar
    Friend WithEvents pbAvailable As ProgressBar
End Class

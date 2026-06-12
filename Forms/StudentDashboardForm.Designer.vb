<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentDashboardForm
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
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblMaxPrice = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.nudMaxPrice = New System.Windows.Forms.NumericUpDown()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.lblRoomCount = New System.Windows.Forms.Label()
        Me.btnViewDetails = New System.Windows.Forms.Button()
        Me.btnViewReviews = New System.Windows.Forms.Button()
        Me.btnMyRequests = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.nudMaxPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserName
        '
        Me.lblUserName.BackColor = System.Drawing.Color.SeaShell
        Me.lblUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUserName.Font = New System.Drawing.Font("Goudy Stout", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(12, 9)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(600, 60)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "Welcome , [Name]"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSearch
        '
        Me.lblSearch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblSearch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSearch.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(57, 119)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(200, 40)
        Me.lblSearch.TabIndex = 3
        Me.lblSearch.Text = "Search Rooms"
        Me.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMaxPrice
        '
        Me.lblMaxPrice.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblMaxPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaxPrice.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxPrice.Location = New System.Drawing.Point(338, 119)
        Me.lblMaxPrice.Name = "lblMaxPrice"
        Me.lblMaxPrice.Size = New System.Drawing.Size(200, 40)
        Me.lblMaxPrice.TabIndex = 4
        Me.lblMaxPrice.Text = "Max Price ( Rs )"
        Me.lblMaxPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLocation
        '
        Me.lblLocation.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLocation.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(609, 119)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(200, 40)
        Me.lblLocation.TabIndex = 5
        Me.lblLocation.Text = "Location"
        Me.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(57, 180)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 22)
        Me.txtSearch.TabIndex = 6
        '
        'nudMaxPrice
        '
        Me.nudMaxPrice.Location = New System.Drawing.Point(338, 182)
        Me.nudMaxPrice.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
        Me.nudMaxPrice.Minimum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudMaxPrice.Name = "nudMaxPrice"
        Me.nudMaxPrice.Size = New System.Drawing.Size(200, 22)
        Me.nudMaxPrice.TabIndex = 7
        Me.nudMaxPrice.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'cmbLocation
        '
        Me.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocation.FormattingEnabled = True
        Me.cmbLocation.Location = New System.Drawing.Point(609, 182)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.Size = New System.Drawing.Size(200, 24)
        Me.cmbLocation.TabIndex = 8
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.SystemColors.Info
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(841, 152)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(142, 40)
        Me.btnFilter.TabIndex = 9
        Me.btnFilter.Text = "Apply Filters"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'dgvRooms
        '
        Me.dgvRooms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRooms.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(140, 264)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.RowHeadersWidth = 51
        Me.dgvRooms.RowTemplate.Height = 24
        Me.dgvRooms.Size = New System.Drawing.Size(758, 261)
        Me.dgvRooms.TabIndex = 10
        '
        'lblRoomCount
        '
        Me.lblRoomCount.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.lblRoomCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRoomCount.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomCount.Location = New System.Drawing.Point(21, 548)
        Me.lblRoomCount.Name = "lblRoomCount"
        Me.lblRoomCount.Size = New System.Drawing.Size(200, 40)
        Me.lblRoomCount.TabIndex = 11
        Me.lblRoomCount.Text = "Found 0 rooms"
        Me.lblRoomCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnViewDetails
        '
        Me.btnViewDetails.BackColor = System.Drawing.SystemColors.Info
        Me.btnViewDetails.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewDetails.Location = New System.Drawing.Point(48, 647)
        Me.btnViewDetails.Name = "btnViewDetails"
        Me.btnViewDetails.Size = New System.Drawing.Size(258, 40)
        Me.btnViewDetails.TabIndex = 12
        Me.btnViewDetails.Text = "View Room Details"
        Me.btnViewDetails.UseVisualStyleBackColor = False
        '
        'btnViewReviews
        '
        Me.btnViewReviews.BackColor = System.Drawing.SystemColors.Info
        Me.btnViewReviews.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReviews.Location = New System.Drawing.Point(391, 647)
        Me.btnViewReviews.Name = "btnViewReviews"
        Me.btnViewReviews.Size = New System.Drawing.Size(236, 40)
        Me.btnViewReviews.TabIndex = 13
        Me.btnViewReviews.Text = "View Reviews"
        Me.btnViewReviews.UseVisualStyleBackColor = False
        '
        'btnMyRequests
        '
        Me.btnMyRequests.BackColor = System.Drawing.SystemColors.Info
        Me.btnMyRequests.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMyRequests.Location = New System.Drawing.Point(723, 647)
        Me.btnMyRequests.Name = "btnMyRequests"
        Me.btnMyRequests.Size = New System.Drawing.Size(239, 40)
        Me.btnMyRequests.TabIndex = 14
        Me.btnMyRequests.Text = "My Booking Requests"
        Me.btnMyRequests.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.SystemColors.Info
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(897, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(99, 40)
        Me.btnLogout.TabIndex = 15
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'StudentDashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BoardingRoomSystem.My.Resources.Resources.Watercolor_Water_Sea_LinkedIn_Article_Cover_Image
        Me.ClientSize = New System.Drawing.Size(1018, 792)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnMyRequests)
        Me.Controls.Add(Me.btnViewReviews)
        Me.Controls.Add(Me.btnViewDetails)
        Me.Controls.Add(Me.lblRoomCount)
        Me.Controls.Add(Me.dgvRooms)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cmbLocation)
        Me.Controls.Add(Me.nudMaxPrice)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblMaxPrice)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblUserName)
        Me.Name = "StudentDashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentDashboard -Boarding Room Finder"
        CType(Me.nudMaxPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUserName As Label
    Friend WithEvents lblSearch As Label
    Friend WithEvents lblMaxPrice As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents nudMaxPrice As NumericUpDown
    Friend WithEvents cmbLocation As ComboBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents lblRoomCount As Label
    Friend WithEvents btnViewDetails As Button
    Friend WithEvents btnViewReviews As Button
    Friend WithEvents btnMyRequests As Button
    Friend WithEvents btnLogout As Button
End Class

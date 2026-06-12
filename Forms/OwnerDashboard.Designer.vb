<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OwnerDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlStats = New System.Windows.Forms.Panel()
        Me.lblRoomCount = New System.Windows.Forms.Label()
        Me.lblRoomsLabel = New System.Windows.Forms.Label()
        Me.pnlRequest = New System.Windows.Forms.Panel()
        Me.lblRequestCount = New System.Windows.Forms.Label()
        Me.lblRequestsLabel = New System.Windows.Forms.Label()
        Me.dgvRooms = New System.Windows.Forms.DataGridView()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnViewRequests = New System.Windows.Forms.Button()
        Me.pnlStats.SuspendLayout()
        Me.pnlRequest.SuspendLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Goudy Stout", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(116, 22)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(600, 44)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "Owner Dashboard"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Cornsilk
        Me.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWelcome.Font = New System.Drawing.Font("Modern No. 20", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.Location = New System.Drawing.Point(12, 94)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(413, 40)
        Me.lblWelcome.TabIndex = 4
        Me.lblWelcome.Text = "Welcome , Owner"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Navy
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogout.Location = New System.Drawing.Point(592, 97)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(196, 40)
        Me.btnLogout.TabIndex = 13
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlStats
        '
        Me.pnlStats.BackColor = System.Drawing.Color.LightGray
        Me.pnlStats.Controls.Add(Me.lblRoomCount)
        Me.pnlStats.Controls.Add(Me.lblRoomsLabel)
        Me.pnlStats.Location = New System.Drawing.Point(55, 171)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Size = New System.Drawing.Size(280, 189)
        Me.pnlStats.TabIndex = 14
        '
        'lblRoomCount
        '
        Me.lblRoomCount.AutoSize = True
        Me.lblRoomCount.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomCount.Location = New System.Drawing.Point(122, 93)
        Me.lblRoomCount.Name = "lblRoomCount"
        Me.lblRoomCount.Size = New System.Drawing.Size(27, 28)
        Me.lblRoomCount.TabIndex = 1
        Me.lblRoomCount.Text = "0"
        '
        'lblRoomsLabel
        '
        Me.lblRoomsLabel.AutoSize = True
        Me.lblRoomsLabel.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomsLabel.Location = New System.Drawing.Point(73, 11)
        Me.lblRoomsLabel.Name = "lblRoomsLabel"
        Me.lblRoomsLabel.Size = New System.Drawing.Size(132, 28)
        Me.lblRoomsLabel.TabIndex = 0
        Me.lblRoomsLabel.Text = "My Rooms"
        '
        'pnlRequest
        '
        Me.pnlRequest.BackColor = System.Drawing.Color.LightGray
        Me.pnlRequest.Controls.Add(Me.lblRequestCount)
        Me.pnlRequest.Controls.Add(Me.lblRequestsLabel)
        Me.pnlRequest.Location = New System.Drawing.Point(473, 171)
        Me.pnlRequest.Name = "pnlRequest"
        Me.pnlRequest.Size = New System.Drawing.Size(280, 189)
        Me.pnlRequest.TabIndex = 15
        '
        'lblRequestCount
        '
        Me.lblRequestCount.AutoSize = True
        Me.lblRequestCount.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequestCount.Location = New System.Drawing.Point(122, 93)
        Me.lblRequestCount.Name = "lblRequestCount"
        Me.lblRequestCount.Size = New System.Drawing.Size(27, 28)
        Me.lblRequestCount.TabIndex = 1
        Me.lblRequestCount.Text = "0"
        '
        'lblRequestsLabel
        '
        Me.lblRequestsLabel.AutoSize = True
        Me.lblRequestsLabel.Font = New System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequestsLabel.Location = New System.Drawing.Point(12, 11)
        Me.lblRequestsLabel.Name = "lblRequestsLabel"
        Me.lblRequestsLabel.Size = New System.Drawing.Size(252, 28)
        Me.lblRequestsLabel.TabIndex = 0
        Me.lblRequestsLabel.Text = "Pending Requests"
        '
        'dgvRooms
        '
        Me.dgvRooms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRooms.Location = New System.Drawing.Point(116, 397)
        Me.dgvRooms.Name = "dgvRooms"
        Me.dgvRooms.RowHeadersWidth = 51
        Me.dgvRooms.RowTemplate.Height = 24
        Me.dgvRooms.Size = New System.Drawing.Size(561, 192)
        Me.dgvRooms.TabIndex = 16
        '
        'btnAddRoom
        '
        Me.btnAddRoom.BackColor = System.Drawing.Color.Navy
        Me.btnAddRoom.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddRoom.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAddRoom.Location = New System.Drawing.Point(24, 675)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(236, 40)
        Me.btnAddRoom.TabIndex = 17
        Me.btnAddRoom.Text = "Add New Room"
        Me.btnAddRoom.UseVisualStyleBackColor = False
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Navy
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnRefresh.Location = New System.Drawing.Point(552, 675)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(236, 40)
        Me.btnRefresh.TabIndex = 18
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnViewRequests
        '
        Me.btnViewRequests.BackColor = System.Drawing.Color.Navy
        Me.btnViewRequests.Font = New System.Drawing.Font("Microsoft Uighur", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewRequests.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnViewRequests.Location = New System.Drawing.Point(292, 675)
        Me.btnViewRequests.Name = "btnViewRequests"
        Me.btnViewRequests.Size = New System.Drawing.Size(236, 40)
        Me.btnViewRequests.TabIndex = 19
        Me.btnViewRequests.Text = "View Requests"
        Me.btnViewRequests.UseVisualStyleBackColor = False
        '
        'OwnerDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BoardingRoomSystem.My.Resources.Resources.Cream_and_Gold_Aesthetic_Watercolor_Poster
        Me.ClientSize = New System.Drawing.Size(800, 839)
        Me.Controls.Add(Me.btnViewRequests)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAddRoom)
        Me.Controls.Add(Me.dgvRooms)
        Me.Controls.Add(Me.pnlRequest)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "OwnerDashboard"
        Me.Text = "OwnerDashboard"
        Me.pnlStats.ResumeLayout(False)
        Me.pnlStats.PerformLayout()
        Me.pnlRequest.ResumeLayout(False)
        Me.pnlRequest.PerformLayout()
        CType(Me.dgvRooms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlStats As Panel
    Friend WithEvents lblRoomCount As Label
    Friend WithEvents lblRoomsLabel As Label
    Friend WithEvents pnlRequest As Panel
    Friend WithEvents lblRequestCount As Label
    Friend WithEvents lblRequestsLabel As Label
    Friend WithEvents dgvRooms As DataGridView
    Friend WithEvents btnAddRoom As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnViewRequests As Button
End Class

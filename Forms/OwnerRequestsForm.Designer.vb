<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnerRequestsForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblInstruction = New System.Windows.Forms.Label()
        Me.dgvRequests = New System.Windows.Forms.DataGridView()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnReject = New System.Windows.Forms.Button()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Goudy Stout", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(305, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(467, 65)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "booking requests"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInstruction
        '
        Me.lblInstruction.AutoSize = True
        Me.lblInstruction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruction.ForeColor = System.Drawing.Color.Firebrick
        Me.lblInstruction.Location = New System.Drawing.Point(338, 107)
        Me.lblInstruction.Name = "lblInstruction"
        Me.lblInstruction.Size = New System.Drawing.Size(402, 22)
        Me.lblInstruction.TabIndex = 5
        Me.lblInstruction.Text = "Select a Request and click Accept or Reject"
        '
        'dgvRequests
        '
        Me.dgvRequests.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequests.Location = New System.Drawing.Point(93, 184)
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.RowHeadersWidth = 51
        Me.dgvRequests.RowTemplate.Height = 24
        Me.dgvRequests.Size = New System.Drawing.Size(818, 215)
        Me.dgvRequests.TabIndex = 6
        '
        'pnlButtons
        '
        Me.pnlButtons.BackColor = System.Drawing.Color.Silver
        Me.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlButtons.Controls.Add(Me.btnRefresh)
        Me.pnlButtons.Controls.Add(Me.btnAccept)
        Me.pnlButtons.Controls.Add(Me.btnReject)
        Me.pnlButtons.Location = New System.Drawing.Point(249, 524)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(567, 64)
        Me.pnlButtons.TabIndex = 7
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnRefresh.Location = New System.Drawing.Point(401, 16)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(141, 36)
        Me.btnRefresh.TabIndex = 17
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnAccept
        '
        Me.btnAccept.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnAccept.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAccept.Location = New System.Drawing.Point(32, 16)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(149, 36)
        Me.btnAccept.TabIndex = 16
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = False
        '
        'btnReject
        '
        Me.btnReject.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnReject.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReject.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReject.Location = New System.Drawing.Point(217, 16)
        Me.btnReject.Name = "btnReject"
        Me.btnReject.Size = New System.Drawing.Size(149, 36)
        Me.btnReject.TabIndex = 15
        Me.btnReject.Text = "Reject"
        Me.btnReject.UseVisualStyleBackColor = False
        '
        'OwnerRequestsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BoardingRoomSystem.My.Resources.Resources.Green_and_Beige_Watercolor_Floral_Background_Poster
        Me.ClientSize = New System.Drawing.Size(1025, 691)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.dgvRequests)
        Me.Controls.Add(Me.lblInstruction)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "OwnerRequestsForm"
        Me.Text = "Booking Requests"
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblInstruction As Label
    Friend WithEvents dgvRequests As DataGridView
    Friend WithEvents pnlButtons As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnReject As Button
End Class

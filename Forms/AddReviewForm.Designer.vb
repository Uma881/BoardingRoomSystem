<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddReviewForm
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
        Me.lblRoomTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudRating = New System.Windows.Forms.NumericUpDown()
        Me.lblStars = New System.Windows.Forms.Label()
        Me.lblReview = New System.Windows.Forms.Label()
        Me.txtReview = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.nudRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.LightSlateGray
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("Goudy Stout", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(225, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(600, 60)
        Me.lblTitle.TabIndex = 3
        Me.lblTitle.Text = "write review"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRoomTitle
        '
        Me.lblRoomTitle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblRoomTitle.Font = New System.Drawing.Font("MingLiU_MSCS-ExtB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoomTitle.Location = New System.Drawing.Point(150, 121)
        Me.lblRoomTitle.Name = "lblRoomTitle"
        Me.lblRoomTitle.Size = New System.Drawing.Size(762, 48)
        Me.lblRoomTitle.TabIndex = 4
        Me.lblRoomTitle.Text = """"""
        Me.lblRoomTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("MingLiU_MSCS-ExtB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(254, 34)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rating 1-5 Stars : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudRating
        '
        Me.nudRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRating.Location = New System.Drawing.Point(415, 201)
        Me.nudRating.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudRating.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRating.Name = "nudRating"
        Me.nudRating.Size = New System.Drawing.Size(250, 30)
        Me.nudRating.TabIndex = 6
        Me.nudRating.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblStars
        '
        Me.lblStars.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblStars.Font = New System.Drawing.Font("MingLiU_MSCS-ExtB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStars.Location = New System.Drawing.Point(411, 262)
        Me.lblStars.Name = "lblStars"
        Me.lblStars.Size = New System.Drawing.Size(254, 34)
        Me.lblStars.TabIndex = 7
        Me.lblStars.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReview
        '
        Me.lblReview.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblReview.Font = New System.Drawing.Font("MingLiU_MSCS-ExtB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReview.Location = New System.Drawing.Point(46, 325)
        Me.lblReview.Name = "lblReview"
        Me.lblReview.Size = New System.Drawing.Size(254, 34)
        Me.lblReview.TabIndex = 8
        Me.lblReview.Text = "Your Review : "
        Me.lblReview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtReview
        '
        Me.txtReview.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReview.Location = New System.Drawing.Point(415, 333)
        Me.txtReview.Multiline = True
        Me.txtReview.Name = "txtReview"
        Me.txtReview.Size = New System.Drawing.Size(503, 107)
        Me.txtReview.TabIndex = 9
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Yi Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubmit.Location = New System.Drawing.Point(104, 584)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(317, 41)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit Review"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Yi Baiti", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(601, 574)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(317, 41)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'AddReviewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BoardingRoomSystem.My.Resources.Resources.Watercolor_Beige_Classic_Frame_LinkedIn_Article_Cover_Image
        Me.ClientSize = New System.Drawing.Size(1009, 732)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtReview)
        Me.Controls.Add(Me.lblReview)
        Me.Controls.Add(Me.lblStars)
        Me.Controls.Add(Me.nudRating)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblRoomTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "AddReviewForm"
        Me.Text = "AddReviewForm"
        CType(Me.nudRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblRoomTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents nudRating As NumericUpDown
    Friend WithEvents lblStars As Label
    Friend WithEvents lblReview As Label
    Friend WithEvents txtReview As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
End Class

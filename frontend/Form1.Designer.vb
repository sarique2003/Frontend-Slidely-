Imports System.Windows.Forms

Partial Class Form1
    Inherits System.Windows.Forms.Form

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents lblTitle As Label

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure that KeyPreview is set to True so the form receives key events
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle key events for Ctrl+V and Ctrl+N
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Ctrl+V pressed: Open New Submissions form
            Dim newSubmissionsForm As New FormCreateSubmission()
            newSubmissionsForm.Show()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl+N pressed: Open View Submissions form
            Dim viewSubmissionsForm As New FormViewSubmissions()
            viewSubmissionsForm.Show()
        End If
    End Sub

    Private Sub InitializeComponent()
        Me.btnViewSubmissions = New System.Windows.Forms.Button()
        Me.btnCreateSubmission = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        Me.btnViewSubmissions.BackColor = System.Drawing.Color.LightYellow
        Me.btnViewSubmissions.Location = New System.Drawing.Point(50, 88)
        Me.btnViewSubmissions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnViewSubmissions.Name = "btnViewSubmissions"
        Me.btnViewSubmissions.Size = New System.Drawing.Size(280, 60)
        Me.btnViewSubmissions.TabIndex = 0
        Me.btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + &V)"
        Me.btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        Me.btnCreateSubmission.BackColor = System.Drawing.Color.LightBlue
        Me.btnCreateSubmission.Location = New System.Drawing.Point(45, 162)
        Me.btnCreateSubmission.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCreateSubmission.Name = "btnCreateSubmission"
        Me.btnCreateSubmission.Size = New System.Drawing.Size(282, 60)
        Me.btnCreateSubmission.TabIndex = 1
        Me.btnCreateSubmission.Text = "CREATE NEW SUBMISSION (CTRL + &N)"
        Me.btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(47, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(324, 20)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Mohd Sarique, Slidely Task 2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 348)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnCreateSubmission)
        Me.Controls.Add(Me.btnViewSubmissions)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class

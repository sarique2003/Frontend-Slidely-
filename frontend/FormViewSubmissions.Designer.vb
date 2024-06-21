<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormViewSubmissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components Is Not Nothing Then
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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGithub = New System.Windows.Forms.TextBox()
        Me.txtStopwatch = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGithub = New System.Windows.Forms.Label()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 30)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(200, 22)
        Me.txtName.TabIndex = 0
        Me.txtName.BackColor = System.Drawing.Color.LightGray
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 70)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(200, 22)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.BackColor = System.Drawing.Color.LightGray
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 110)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(200, 22)
        Me.txtPhone.TabIndex = 2
        Me.txtPhone.BackColor = System.Drawing.Color.LightGray
        '
        'txtGithub
        '
        Me.txtGithub.Location = New System.Drawing.Point(150, 150)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.ReadOnly = True
        Me.txtGithub.Size = New System.Drawing.Size(200, 22)
        Me.txtGithub.TabIndex = 3
        Me.txtGithub.BackColor = System.Drawing.Color.LightGray
        '
        'txtStopwatch
        '
        Me.txtStopwatch.Location = New System.Drawing.Point(150, 190)
        Me.txtStopwatch.Name = "txtStopwatch"
        Me.txtStopwatch.ReadOnly = True
        Me.txtStopwatch.Size = New System.Drawing.Size(200, 22)
        Me.txtStopwatch.TabIndex = 4
        Me.txtStopwatch.BackColor = System.Drawing.Color.LightGray
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(30, 30)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(45, 17)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(30, 70)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(42, 17)
        Me.lblEmail.TabIndex = 6
        Me.lblEmail.Text = "Email"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(30, 110)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(77, 17)
        Me.lblPhone.TabIndex = 7
        Me.lblPhone.Text = "Phone Num"
        '
        'lblGithub
        '
        Me.lblGithub.AutoSize = True
        Me.lblGithub.Location = New System.Drawing.Point(30, 150)
        Me.lblGithub.Name = "lblGithub"
        Me.lblGithub.Size = New System.Drawing.Size(114, 17)
        Me.lblGithub.TabIndex = 8
        Me.lblGithub.Text = "Github Link"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Location = New System.Drawing.Point(30, 190)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(91, 17)
        Me.lblStopwatch.TabIndex = 9
        Me.lblStopwatch.Text = "Stopwatch time"
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.LightYellow
        Me.btnPrevious.Location = New System.Drawing.Point(30, 230)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(150, 30)
        Me.btnPrevious.TabIndex = 10
        Me.btnPrevious.Text = "PREVIOUS (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.LightBlue
        Me.btnNext.Location = New System.Drawing.Point(200, 230)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(150, 30)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "NEXT (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'FormViewSubmissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.lblGithub)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtStopwatch)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "FormViewSubmissions"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithub As TextBox
    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithub As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class

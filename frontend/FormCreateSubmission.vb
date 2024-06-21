Imports System.IO
Imports System.Text.Json

Public Class FormCreateSubmission

    Private WithEvents Timer1 As New Timer() ' Declare Timer1 with WithEvents

    Private stopwatch As New System.Diagnostics.Stopwatch()
    Private stopwatchRunning As Boolean = False

    Private Sub FormCreateSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize form components and setup
        txtName.Text = "sarique"
        txtEmail.Text = "shaarik.aslam@gmail.com"
        txtPhone.Text = "9099236374"
        txtGithub.Text = "https://github.com/sarique2003"

        ' Setup stopwatch button and event handler
        btnStopwatch.Text = "START STOPWATCH (CTRL + T)"
        AddHandler btnStopwatch.Click, AddressOf btnStopwatch_Click

        ' Set up Timer1 properties
        Timer1.Interval = 1000 ' Interval in milliseconds (1 second)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Handle submit button click (CTRL + S)
        SaveDataToJson()
    End Sub

    Private Sub SaveDataToJson()
        ' Example: Saving form data to JSON (you can customize this as needed)
        Dim submissionData As New Dictionary(Of String, Object)()
        submissionData.Add("Name", txtName.Text)
        submissionData.Add("Email", txtEmail.Text)
        submissionData.Add("Phone", txtPhone.Text)
        submissionData.Add("Github", txtGithub.Text)

        Dim json As String = JsonSerializer.Serialize(submissionData)
        Dim jsonFilePath As String = "submission_data.json"

        File.WriteAllText(jsonFilePath, json)

        MessageBox.Show("Data saved to JSON file: " & jsonFilePath, "Data Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs)
        ' Handle stopwatch button click to start/stop (CTRL + T)
        If Not stopwatchRunning Then
            ' Start stopwatch
            stopwatch.Start()
            stopwatchRunning = True
            btnStopwatch.Text = "STOP STOPWATCH (CTRL + T)"
            Timer1.Start() ' Start timer to update stopwatch display
        Else
            ' Stop stopwatch
            stopwatch.Stop()
            stopwatchRunning = False
            btnStopwatch.Text = "START STOPWATCH (CTRL + T)"
            Timer1.Stop() ' Stop timer
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update stopwatch display
        Dim ts As TimeSpan = stopwatch.Elapsed
        txtStopwatch.Text = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}"
    End Sub

    Private Sub FormCreateSubmission_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle key events for Ctrl+T (toggle stopwatch) and Ctrl+S (submit data)
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnStopwatch_Click(sender, e)
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit_Click(sender, e)
        End If
    End Sub

End Class

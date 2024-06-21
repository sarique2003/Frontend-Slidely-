Public Class FormViewSubmissions
    Private submissions As List(Of String) = New List(Of String) From {
        "Name: John Doe, Email: johndoe@gmail.com, Phone: 9876543210, GitHub: https://github.com/john_doe/my_slidely_task, Stopwatch: 00:01:19",
        "Name: Jane Smith, Email: janesmith@gmail.com, Phone: 1234567890, GitHub: https://github.com/jane_smith/my_slidely_task, Stopwatch: 00:02:25"
    } ' Example data
    Private currentIndex As Integer = 0

    Private Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplaySubmission()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub DisplaySubmission()
        Dim submission As String = submissions(currentIndex)
        Dim parts() As String = submission.Split(","c)
        txtName.Text = parts(0).Replace("Name: ", "").Trim()
        txtEmail.Text = parts(1).Replace("Email: ", "").Trim()
        txtPhone.Text = parts(2).Replace("Phone: ", "").Trim()
        txtGithub.Text = parts(3).Replace("GitHub: ", "").Trim()
        txtStopwatch.Text = parts(4).Replace("Stopwatch: ", "").Trim()
    End Sub
End Class

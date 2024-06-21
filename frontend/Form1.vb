Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure that KeyPreview is set to True so the form receives key events
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle key events for Ctrl+V and Ctrl+N
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Ctrl+V pressed: Open FormCreateSubmission
            Dim createForm As New FormCreateSubmission()
            createForm.Show()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl+N pressed: Open FormViewSubmissions
            Dim viewForm As New FormViewSubmissions()
            viewForm.Show()
        End If
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Click event handler for btnViewSubmissions
        Dim viewForm As New FormViewSubmissions()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        ' Click event handler for btnCreateSubmission
        Dim createForm As New FormCreateSubmission()
        createForm.Show()
    End Sub

End Class

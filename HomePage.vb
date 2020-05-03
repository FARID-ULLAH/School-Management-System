Public Class HomePage

    Dim classPage As Class_Rec
    Dim stuPage As Students
    Dim feePage As Fee
    Dim subPage As Subjects
    Dim facPage As Faculty
    Dim examPage As Examination
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Application.Exit()
    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub classBtn_Click(sender As Object, e As EventArgs) Handles classBtn.Click

        mainPanel.Controls.Clear()
        classPage = New Class_Rec()

        mainPanel.Controls.Add(classPage)

        classPage.Show()

    End Sub

    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

    End Sub

    Private Sub stuBtn_Click(sender As Object, e As EventArgs) Handles stuBtn.Click
        mainPanel.Controls.Clear()
        stuPage = New Students()

        mainPanel.Controls.Add(stuPage)
        ' mainPanel.Dock = DockStyle.Fill
        stuPage.Show()
    End Sub

    Private Sub feeBtn_Click(sender As Object, e As EventArgs) Handles feebtn.Click

        mainPanel.Controls.Clear()
        feePage = New Fee()

        mainPanel.Controls.Add(feePage)
        feePage.Show()

    End Sub

    Private Sub subBtn_Click(sender As Object, e As EventArgs)

        mainPanel.Controls.Clear()
        subPage = New Subjects()

        mainPanel.Controls.Add(subPage)
        subPage.Show()


    End Sub

    Private Sub facBtn_Click(sender As Object, e As EventArgs) Handles facBtn.Click

        mainPanel.Controls.Clear()
        facPage = New Faculty()

        mainPanel.Controls.Add(facPage)
        facPage.Show()

    End Sub

    Private Sub examBtn_Click(sender As Object, e As EventArgs) Handles examBtn.Click

        mainPanel.Controls.Clear()
        examPage = New Examination()

        mainPanel.Controls.Add(examPage)
        examPage.Show()

    End Sub
End Class
Public Class Dashboard
    Private Sub Activity1ToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmActivity1.Show()
        Me.Close()
    End Sub

    Private Sub Activity2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuStripActivity2.Click
        frmActivity2.Show()
        Me.Close()
    End Sub

    Private Sub Activity1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MenuStripActivity1.Click
        frmActivity1.Show()
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuStripLogout.Click
        LoginForm1.Show()
        Me.Close()
    End Sub

    Private Sub Activity3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuStripActivity3.Click
        frmActivity3.Show()
        Me.Close()

    End Sub


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub ABOUTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MenuStripAbout.Click
        About.Show()
        Me.Close()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = "Today is " & Date.Now.ToString("ddd MMM yyyy  hh:mm:ss")
    End Sub
    Private Sub ProgTask1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuStripProgTask1.Click
        ProgTask1.Show()
        Me.Close()
    End Sub

    Private Sub ProgTask2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuStripProgTask2.Click
        ProgTask2.Show()
        Me.Close()
    End Sub

    Private Sub ProgTask3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuStripProgTask3.Click
        ProgTask3.Show()
        Me.Close()
    End Sub
    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub About1ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblDateTime_Click(sender As Object, e As EventArgs) Handles lblDateTime.Click

    End Sub
    Private Sub Activity4ToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OurActivitiesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MenuStripActivities.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuStripReports.Click

    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProgTask11ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgTask11ToolStripMenuItem.Click
        ProgTask1_2.Show()
        Me.Close()

    End Sub

    Private Sub ProgTask12ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgTask12ToolStripMenuItem.Click
        ProgTask1_3.Show()
        Me.Close()
    End Sub

    Private Sub Activity22ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Activity22ToolStripMenuItem.Click
        frmActivity2_2.Show()
        Me.Close()
    End Sub
End Class


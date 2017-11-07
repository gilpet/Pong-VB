Public Class Pong

    Dim compScore As Integer = 0
    Dim plrScore As Integer = 0
    Dim speed As Single = 40 ' Ball Speed
    Dim rndInst As New Random() ' Random instance
    Dim xVel As Single = Math.Cos(rndInst.Next(5, 10)) * speed
    Dim yVel As Single = Math.Sin(rndInst.Next(5, 10)) * speed

    Private Sub Pong_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If e.Y > 5 And e.Y < Me.Height - 40 - Player.Height Then _
        Player.Location = New Point(Player.Location.X, e.Y)

    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

        Ball.Location = New Point(Ball.Location.X + xVel, Ball.Location.Y + yVel)
        If Ball.Location.Y > 5 And Ball.Location.Y < Me.Height - 40 _
        - Player.Height Then _
            Computer.Location = New Point(Computer.Location.X, Ball.Location.Y)
        ' Check for top wall.
        If Ball.Location.Y < 0 Then
            Ball.Location = New Point(Ball.Location.X, 0)
            yVel = -yVel
        End If
        ' Check for bottom wall.
        If Ball.Location.Y > Me.Height - Ball.Size.Height - 45 Then
            Ball.Location = New Point(Ball.Location.X, Me.Height - Ball.Size.Height - 45)
            yVel = -yVel
        End If
        ' Check for player paddle.
        If Ball.Bounds.IntersectsWith(Player.Bounds) Then
            Ball.Location = New Point(Player.Location.X - Ball.Size.Width,
            Ball.Location.Y)
            xVel = -xVel
        End If
        ' Check for computer paddle.
        If Ball.Bounds.IntersectsWith(Computer.Bounds) Then
            Ball.Location = New Point(Computer.Location.X + Computer.Size.Width + 1,
            Ball.Location.Y)
            xVel = -xVel
        End If
        ' Check for left wall.
        If Ball.Location.X < 0 Then
            plrScore += 1
            Ball.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            PlayerScore.Text = Convert.ToString(plrScore)
        End If
        ' Check for right wall.
        If Ball.Location.X > Me.Width - Ball.Size.Width - Player.Width Then
            compScore += 1
            Ball.Location = New Point(Me.Size.Width / 2, Me.Size.Height / 2)
            ComputerScore.Text = Convert.ToString(compScore)
        End If

        If compScore = 15 Or plrScore = 15 Then
            PauseGame()
            PlaySound()
            Dim result As Integer = MessageBox.Show("Play again?", "Game over", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                ResetScore()
                PauseGame()
            ElseIf result = DialogResult.No Then
                Me.Close()
            End If
        End If
    End Sub

    Sub ResetScore()
        compScore = 0
        ComputerScore.Text = Convert.ToString(compScore)
        plrScore = 0
        PlayerScore.Text = Convert.ToString(plrScore)
    End Sub

    Sub PlaySound()
        My.Computer.Audio.Play(My.Resources.gameover,
            AudioPlayMode.WaitToComplete)
    End Sub

    Sub PauseGame()
        If Timer.Enabled = True Then
            Timer.Enabled = False
        ElseIf Timer.Enabled = False Then
            Timer.Enabled = True
        End If
    End Sub

    ' Escape the game when escape has been pressed.
    Private Sub Pong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyValue = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyValue = Keys.P Then
            PauseGame()
        End If
    End Sub

End Class

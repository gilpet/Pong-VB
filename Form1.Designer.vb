<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pong
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pong))
        Me.ComputerScore = New System.Windows.Forms.Label()
        Me.PlayerScore = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Computer = New System.Windows.Forms.PictureBox()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Computer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComputerScore
        '
        Me.ComputerScore.AutoSize = True
        Me.ComputerScore.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComputerScore.Location = New System.Drawing.Point(47, 35)
        Me.ComputerScore.Name = "ComputerScore"
        Me.ComputerScore.Size = New System.Drawing.Size(26, 30)
        Me.ComputerScore.TabIndex = 3
        Me.ComputerScore.Text = "0"
        '
        'PlayerScore
        '
        Me.PlayerScore.AutoSize = True
        Me.PlayerScore.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerScore.Location = New System.Drawing.Point(548, 35)
        Me.PlayerScore.Name = "PlayerScore"
        Me.PlayerScore.Size = New System.Drawing.Size(26, 30)
        Me.PlayerScore.TabIndex = 4
        Me.PlayerScore.Text = "0"
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 20
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.Transparent
        Me.Ball.ErrorImage = Global.WindowsApplication7.My.Resources.Resources.tennisball
        Me.Ball.ImageLocation = "My.Resouces.ball"
        Me.Ball.InitialImage = Global.WindowsApplication7.My.Resources.Resources.tennisball
        Me.Ball.Location = New System.Drawing.Point(306, 189)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(20, 20)
        Me.Ball.TabIndex = 9
        Me.Ball.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Blue
        Me.Player.Location = New System.Drawing.Point(596, 141)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(16, 128)
        Me.Player.TabIndex = 8
        Me.Player.TabStop = False
        '
        'Computer
        '
        Me.Computer.BackColor = System.Drawing.Color.Red
        Me.Computer.Location = New System.Drawing.Point(12, 141)
        Me.Computer.Name = "Computer"
        Me.Computer.Size = New System.Drawing.Size(16, 128)
        Me.Computer.TabIndex = 7
        Me.Computer.TabStop = False
        '
        'Pong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Computer)
        Me.Controls.Add(Me.PlayerScore)
        Me.Controls.Add(Me.ComputerScore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Pong"
        Me.Text = "Pong"
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Computer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComputerScore As Label
    Friend WithEvents PlayerScore As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents Computer As PictureBox
    Friend WithEvents Player As PictureBox
    Friend WithEvents Ball As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MusicFiles = New System.Windows.Forms.ListBox()
        Me.lblSelectedFilePath = New System.Windows.Forms.Label()
        Me.Pause = New System.Windows.Forms.PictureBox()
        Me.Start = New System.Windows.Forms.PictureBox()
        Me.OpenFolder = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.End_thus = New System.Windows.Forms.PictureBox()
        Me.BunifuTrackbar1 = New Bunifu.Framework.UI.BunifuTrackbar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.Pause, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Start, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OpenFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.End_thus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1216, 98)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Music Player"
        '
        'MusicFiles
        '
        Me.MusicFiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.MusicFiles.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MusicFiles.ForeColor = System.Drawing.Color.White
        Me.MusicFiles.FormattingEnabled = True
        Me.MusicFiles.ItemHeight = 23
        Me.MusicFiles.Location = New System.Drawing.Point(12, 131)
        Me.MusicFiles.Name = "MusicFiles"
        Me.MusicFiles.Size = New System.Drawing.Size(392, 625)
        Me.MusicFiles.TabIndex = 6
        Me.MusicFiles.Tag = ""
        '
        'lblSelectedFilePath
        '
        Me.lblSelectedFilePath.AutoSize = True
        Me.lblSelectedFilePath.Location = New System.Drawing.Point(1186, 753)
        Me.lblSelectedFilePath.Name = "lblSelectedFilePath"
        Me.lblSelectedFilePath.Size = New System.Drawing.Size(41, 15)
        Me.lblSelectedFilePath.TabIndex = 7
        Me.lblSelectedFilePath.Text = "Label2"
        Me.lblSelectedFilePath.Visible = False
        '
        'Pause
        '
        Me.Pause.BackColor = System.Drawing.Color.Transparent
        Me.Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pause.Image = Global.Waves.My.Resources.Resources.pause1
        Me.Pause.Location = New System.Drawing.Point(757, 630)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(96, 97)
        Me.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pause.TabIndex = 8
        Me.Pause.TabStop = False
        '
        'Start
        '
        Me.Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Start.Image = Global.Waves.My.Resources.Resources.start
        Me.Start.Location = New System.Drawing.Point(514, 630)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(96, 97)
        Me.Start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Start.TabIndex = 10
        Me.Start.TabStop = False
        '
        'OpenFolder
        '
        Me.OpenFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OpenFolder.Image = Global.Waves.My.Resources.Resources.folders
        Me.OpenFolder.Location = New System.Drawing.Point(717, 225)
        Me.OpenFolder.Name = "OpenFolder"
        Me.OpenFolder.Size = New System.Drawing.Size(158, 157)
        Me.OpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OpenFolder.TabIndex = 11
        Me.OpenFolder.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(717, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 36)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Open Folder"
        '
        'Timer1
        '
        '
        'End_thus
        '
        Me.End_thus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.End_thus.Image = Global.Waves.My.Resources.Resources._stop
        Me.End_thus.Location = New System.Drawing.Point(1023, 630)
        Me.End_thus.Name = "End_thus"
        Me.End_thus.Size = New System.Drawing.Size(96, 97)
        Me.End_thus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.End_thus.TabIndex = 14
        Me.End_thus.TabStop = False
        '
        'BunifuTrackbar1
        '
        Me.BunifuTrackbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTrackbar1.BackgroudColor = System.Drawing.Color.DarkGray
        Me.BunifuTrackbar1.BorderRadius = 0
        Me.BunifuTrackbar1.IndicatorColor = System.Drawing.Color.SeaGreen
        Me.BunifuTrackbar1.Location = New System.Drawing.Point(514, 532)
        Me.BunifuTrackbar1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BunifuTrackbar1.MaximumValue = 100
        Me.BunifuTrackbar1.MinimumValue = 0
        Me.BunifuTrackbar1.Name = "BunifuTrackbar1"
        Me.BunifuTrackbar1.Size = New System.Drawing.Size(605, 33)
        Me.BunifuTrackbar1.SliderRadius = 0
        Me.BunifuTrackbar1.TabIndex = 15
        Me.BunifuTrackbar1.Value = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(996, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(996, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(996, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1239, 777)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuTrackbar1)
        Me.Controls.Add(Me.End_thus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OpenFolder)
        Me.Controls.Add(Me.MusicFiles)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Pause)
        Me.Controls.Add(Me.lblSelectedFilePath)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Pause, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Start, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OpenFolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.End_thus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MusicFiles As ListBox
    Friend WithEvents lblSelectedFilePath As Label
    Friend WithEvents Pause As PictureBox
    Friend WithEvents Start As PictureBox
    Friend WithEvents OpenFolder As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents End_thus As PictureBox
    Friend WithEvents BunifuTrackbar1 As Bunifu.Framework.UI.BunifuTrackbar
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

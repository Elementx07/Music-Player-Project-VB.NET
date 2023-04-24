Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports WMPLib

Public Class Form1
    Private WithEvents player As New WindowsMediaPlayer
    Private pausedPosition As Double




    Private Sub MusicFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MusicFiles.SelectedIndexChanged
        If MusicFiles.SelectedIndex >= 0 Then
            'Dim selectedMusicFile As String = Path.GetFileName()
            lblSelectedFilePath.Text = Path.GetFullPath(MusicFiles.SelectedItem.ToString())

        End If
    End Sub

    Private Sub Pause_Click(sender As Object, e As EventArgs) Handles Pause.Click
        If player.playState = WMPPlayState.wmppsPlaying Then
            Pause.ImageLocation = "C:\Users\jaysh\OneDrive\Desktop\Microprojects\GAD\MusicPlayer\MusicPlayer\play.png"
            player.controls.pause()
            pausedPosition = player.controls.currentPosition
        ElseIf player.playState = WMPPlayState.wmppsPaused Then

            Pause.ImageLocation = "C:\Users\jaysh\OneDrive\Desktop\Microprojects\GAD\MusicPlayer\MusicPlayer\pause.png"
            player.controls.play()
            pausedPosition = 0
        End If
    End Sub



    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        ' Play or resume the selected music file
        If MusicFiles.SelectedIndex >= 0 Then
            ' Set the URL property of the WindowsMediaPlayer object
            player.URL = lblSelectedFilePath.Text
            ' If there is a paused position, seek to that position

            If pausedPosition > 0 Then
                player.controls.currentPosition = pausedPosition
                pausedPosition = 0
            End If
            Try
                player.controls.play()
                Debug.Print("Player is playing")
            Catch ex As Exception
                Debug.Print("Error playing file: " & ex.Message)
            End Try
        Else
            MessageBox.Show("No music file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub OpenFolder_Click(sender As Object, e As EventArgs) Handles OpenFolder.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Multiselect = True
        openFileDialog.Filter = "Music Files|*.mp3;*.flac|All Files|*.*" ' Modify the filter to include both MP3 and FLAC files
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            MusicFiles.Items.Clear()
            For Each musicFile As String In openFileDialog.FileNames
                MusicFiles.Items.Add(Path.GetFullPath(musicFile))
            Next
        End If
    End Sub
    Private Sub player_PlayStateChange(newStatus As WMPLib.WMPPlayState) Handles player.PlayStateChange
        If player.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            BunifuTrackbar1.MaximumValue = CInt(player.controls.currentItem.duration)
            Timer1.Start()

        ElseIf player.playState = WMPLib.WMPPlayState.wmppsStopped Then

            Timer1.Stop()

            BunifuTrackbar1.Value = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If player.playState = WMPPlayState.wmppsPlaying Then


            Dim progress As Integer = CInt(player.controls.currentPosition / player.controls.currentItem.duration * BunifuTrackbar1.MaximumValue)

            'below labels are just for debug
            Label3.Text = player.controls.currentPosition.ToString
            Label4.Text = player.controls.currentItem.duration.ToString
            Label5.Text = BunifuTrackbar1.MaximumValue.ToString
            If progress < BunifuTrackbar1.MinimumValue Then
                BunifuTrackbar1.Value = BunifuTrackbar1.MinimumValue
            ElseIf progress > BunifuTrackbar1.MaximumValue Then
                BunifuTrackbar1.Value = BunifuTrackbar1.MaximumValue
            Else
                BunifuTrackbar1.Value = progress
            End If
        End If
    End Sub

    Private Sub End_thus_Click(sender As Object, e As EventArgs) Handles End_thus.Click
        player.controls.stop()
        pausedPosition = 0
    End Sub

    Private Sub BunifuTrackbar1_ValueChanged(sender As Object, e As EventArgs) Handles BunifuTrackbar1.ValueChanged
        player.controls.currentPosition = BunifuTrackbar1.Value
    End Sub


End Class

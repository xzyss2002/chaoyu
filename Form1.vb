Public Class Race

    Dim number As Integer

   
    Private Sub TmrMario_Tick(sender As Object, e As EventArgs) Handles TmrMario.Tick

        Randomize()
        number = Int(20 * Rnd() + 10)

        PicMario.Location = New Point(PicMario.Location.X + number, _
              PicMario.Location.Y)

        If PicMario.Location.X >= 1300 Then
            PicMario.Image = My.Resources.mario
            TmrMario.Enabled = False
            TmrBatman.Enabled = False
            PicBatman.Image = My.Resources.batman
            MsgBox("Mario Wins")
        End If
    End Sub

    Private Sub CmdStart_Click(sender As Object, e As EventArgs) Handles CmdStart.Click
        TmrMario.Enabled = True
        PicMario.Image = My.Resources.Mario_run

        TmrBatman.Enabled = True
        PicBatman.Image = My.Resources.running_batman_clipart_171
    End Sub

    Private Sub TmrBatman_Tick(sender As Object, e As EventArgs) Handles TmrBatman.Tick
        Randomize()
        number = Int(20 * Rnd() + 10)


        PicBatman.Location = New Point(PicBatman.Location.X + number, _
              PicBatman.Location.Y)

        If PicBatman.Location.X >= 1300 Then
            PicBatman.Image = My.Resources.batman
            TmrMario.Enabled = False
            TmrBatman.Enabled = False
            MsgBox("Batman Wins")
            PicMario.Image = My.Resources.mario
        End If
    End Sub

    Private Sub Cmdreset_Click(sender As Object, e As EventArgs) Handles Cmdreset.Click
        PicBatman.Location = New Point(-6, 277)
        PicMario.Location = New Point(-6, 410)
    End Sub
End Class

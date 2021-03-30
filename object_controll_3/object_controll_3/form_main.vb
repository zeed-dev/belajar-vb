Public Class form_main
    Private Sub KeluarAplikasiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarAplikasiToolStripMenuItem.Click
        Dim Tanya As DialogResult
        Tanya = MsgBox("Yakin Ingin Keluar ?", vbQuestion + vbYesNo, "Informasi") = vbYes = True
        If Tanya = True Then
            Application.Exit()
        End If
    End Sub

    Private Sub SettingDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingDatabaseToolStripMenuItem.Click
        form_setting_database.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelTanggal.Text = Format(Now, "dd-MM-yyyy")
        labelJam.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub
End Class
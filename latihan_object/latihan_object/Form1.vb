Public Class Form1
    Private Sub NamaPegawai()
        With cb1.Items
            .Add("Ayam Kampus")
            .Add("Ayam Rumah")
            .Add("Ayam Dusun")
        End With
    End Sub

    Private Sub NamaHewan()

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call NamaPegawai()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            MsgBox("Testx")
        End If
    End Sub

    Private Sub btnMahasiswa_Click(sender As Object, e As EventArgs) Handles btnMahasiswa.Click
        cb1.Items.Add(tb1.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cb1.Items.Clear()
    End Sub
End Class

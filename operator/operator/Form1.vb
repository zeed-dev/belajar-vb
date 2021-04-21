Public Class Form1

    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        Dim Nilai, Hasil As Integer
        Nilai = tx_2.Text
        Hasil = Nilai * ComboBox1.Text
        tx_1.Text = (Hasil)
    End Sub
End Class

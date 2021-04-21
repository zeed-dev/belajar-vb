Public Class Form2
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Nilai1, Nilai2, Hasil As Double

        Nilai1 = Val(TextBox1.Text)
        Nilai2 = Val(TextBox2.Text)


        Select Case ComboBox1.SelectedIndex
            Case 0
                Hasil = Nilai1 ^ Nilai2
                TextBox3.Text = Hasil
            Case 1
                Hasil = Nilai1 * Nilai2
                TextBox3.Text = Hasil
            Case 2
                Hasil = Nilai1 / Nilai2
                TextBox3.Text = Hasil
            Case 3
                Hasil = Nilai1 \ Nilai2
                TextBox3.Text = Hasil
            Case 4
                Hasil = Nilai1 + Nilai2
                TextBox3.Text = Hasil
            Case 5
                Hasil = Nilai1 - Nilai2
                TextBox3.Text = Hasil
            Case 6
                Hasil = Nilai1 Mod Nilai2
                TextBox3.Text = Hasil
        End Select
    End Sub
End Class
Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nilai As Integer
        Nilai = CInt(TextBox1.Text)

        TextBox2.Text = Nilai
        ListBox1.Items.Add(Nilai)
    End Sub
End Class
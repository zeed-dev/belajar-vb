Public Class Form2


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        Select Case ComboBox1.SelectedIndex
            Case 0
                TextBox3.Text = TextBox1.Text ^ TextBox2.Text
            Case 1
                TextBox3.Text = TextBox1.Text * TextBox2.Text
            Case 2
                TextBox3.Text = TextBox1.Text / TextBox2.Text
            Case 3
                TextBox3.Text = TextBox1.Text \ TextBox2.Text
            Case 4
                TextBox3.Text = TextBox1.Text + TextBox2.Text
            Case 5
                TextBox3.Text = TextBox1.Text - TextBox2.Text
            Case 6
                TextBox3.Text = TextBox1.Text Mod TextBox2.Text
        End Select
    End Sub
End Class
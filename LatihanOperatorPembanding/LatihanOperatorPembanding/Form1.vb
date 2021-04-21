Public Class Form1

    
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim a, b As Integer
        Dim hasil As Boolean

        a = TextBox1.Text
        b = TextBox2.Text

        Select Case ComboBox1.SelectedIndex
            Case 0
                hasil = a < b
            Case 1
                hasil = a > b
            Case 2
                hasil = a <= b
            Case 3
                hasil = a >= b
            Case 4
                hasil = a = b
            Case 5
                hasil = a <> b
            Case 6
                hasil = a Like b
        End Select
        TextBox3.Text = hasil
    End Sub
End Class

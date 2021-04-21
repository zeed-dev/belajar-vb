Public Class Form2

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim a, b As Boolean
        Dim c As Boolean

        a = ComboBox3.SelectedIndex
        b = ComboBox2.SelectedIndex

        Select Case ComboBox3.SelectedIndex
            Case 0
                a = True
            Case 1
                a = False
        End Select

        Select Case ComboBox2.SelectedIndex
            Case 0
                b = True
            Case 1
                b = False
        End Select

            Select Case ComboBox1.SelectedIndex
                Case 0
                    c = a And b
                Case 1
                    c = a Or b
                Case 2
                    c = Not a
                Case 3
                    c = Not b
            End Select
            TextBox3.Text = c
    End Sub
End Class
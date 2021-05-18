Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case True
            Case RadioButton1.Checked
                For i As Integer = CInt(TextBox1.Text) To CInt(TextBox2.Text)
                    TextBox3.Text &= i & " "
                Next
            Case RadioButton3.Checked
                Dim i As Integer
                i = CInt(TextBox1.Text)
                Do While i < CInt(TextBox2.Text)
                    TextBox3.Text &= i & " "
                    i = i + 1
                Loop
            Case RadioButton4.Checked
                Dim i As Integer
                i = CInt(TextBox1.Text)
                Do Until i > CInt(TextBox2.Text)
                    TextBox3.Text &= i & " "
                    i = i + 1
                Loop
            Case RadioButton5.Checked
                Dim i As Integer
                i = CInt(TextBox1.Text)
                Do
                    TextBox3.Text &= i & " "
                    i = i + 1
                Loop While i < CInt(TextBox2.Text)
            Case RadioButton6.Checked
                Dim i As Integer
                i = CInt(TextBox1.Text)
                Do
                    TextBox3.Text &= i & " "
                    i = i + 1
                Loop Until i > CInt(TextBox2.Text)
        End Select
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If RadioButton2.Checked = True Then
            If e.KeyCode = Keys.F1 Then
                Dim input As Object
                Dim mahasiswa(5) As String

                For i As Integer = 0 To 4
                    input = InputBox("Masukan Nama : ")
                    mahasiswa(i) = input
                Next

                For Each nama In mahasiswa
                    TextBox3.Text &= nama & " "
                Next

            End If
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class



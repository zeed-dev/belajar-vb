Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'For i As Integer = 2 To 10 Step 2
        '    ListBox1.Items.Add("Item ke -" & i)
        '    ComboBox1.Items.Add("Item ke -" & i)
        '    Console.Write(True)
        'Next


        'Dim Mahasiswa() As String = {"ziad", "puput", "mila", "wawan"}
        'For Each Nama In Mahasiswa
        '    ListBox1.Items.Add(Nama)
        '    ComboBox1.Items.Add(Nama)
        '    TextBox2.Text &= Nama & ", "
        'Next


        'Dim i As Integer
        'i = 1
        'Do While i < 10
        '    ListBox1.Items.Add("Kelas A -" & i)
        '    ComboBox1.Items.Add("Kelas B -" & i)
        '    i = i + 1
        'Loop


        'Dim i As Integer
        'i = 1
        'Do Until i > 10
        '    ListBox1.Items.Add("Kelas A -" & i)
        '    ComboBox1.Items.Add("Kelas B -" & i)
        '    i = i + 1
        'Loop

        'Dim i As Integer
        'i = 1
        'Do
        '    ListBox1.Items.Add("Kelas A -" & i)
        '    ComboBox1.Items.Add("Kelas B -" & i)
        '    i = i + 1
        'Loop While i < 5

        Dim i As Integer
        i = 1
        Do
            ListBox1.Items.Add("Kelas A -" & i)
            ComboBox1.Items.Add("Kelas B -" & i)
            i = i + 1
        Loop Until i > 5



    End Sub
End Class

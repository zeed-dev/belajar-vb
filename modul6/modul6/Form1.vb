Public Class Form1
    'Deklrasi Variabel
    Dim PorsenAkhir As Integer
    Dim NA As Double
    Dim Harian, UTS, UAS As Double

    'Prosedur ListPorsenHarian()
    Private Sub ListPorsenHarian()
        For i As Integer = 5 To 30 Step 5
            cbPorsen_Harian.Items.Add(i)
        Next
    End Sub
    'Prosedur validasi()
    Private Sub Validasi()

    End Sub
    'Prosedur ListPorsenUTS()
    Private Sub ListPorsenUTS()
        For i As Integer = 10 To 40 Step 5
            cbPorsen_UTS.Items.Add(i)
        Next
    End Sub
    'Prosedur ListPorsenUAS()
    Private Sub ListPorsenUAS()
        For i As Integer = 20 To 80 Step 5
            cbPorsen_UAS.Items.Add(i)
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call ListPorsenHarian()
        Call ListPorsenUTS()
        Call ListPorsenUAS()
    End Sub

    Private Sub cbPorsen_UAS_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPorsen_UAS.SelectedIndexChanged
        PorsenAkhir = CInt(cbPorsen_Harian.Text) + CInt(cbPorsen_UTS.Text) + CInt(cbPorsen_UAS.Text)
        If PorsenAkhir > 100 Then
            MsgBox("Data salah" & PorsenAkhir & "%", MsgBoxStyle.Exclamation, "WARNING!")
            cbPorsen_Harian.Text = ""
            cbPorsen_UTS.Text = ""
            cbPorsen_UAS.Text = ""
        Else
            Harian = CDbl(txtNilai_Harian.Text)
            UTS = CDbl(txtNilai_UTS.Text)
            UAS = CDbl(txtNilai_UAS.Text)

            NA = (Harian * CDbl(cbPorsen_Harian.Text) / 100) + (UTS * CDbl(cbPorsen_UTS.Text) / 100) + (UAS * CDbl(cbPorsen_UAS.Text) / 100)
            txtNilai_Akhir.Text = NA

            If NA >= 81 And NA <= 100 Then
                txtGrade.Text = "A"
            ElseIf NA >= 75 And NA <= 80 Then
                txtGrade.Text = "B+"
            ElseIf NA >= 61 And NA <= 74 Then
                txtGrade.Text = "B"
            End If
        End If

    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Nim, Nama, Kelas_Prodi, Grade As String
        Dim Jk As Char

        Nim = txtNim.Text
        Nama = txtNama.Text
        Kelas_Prodi = cbKelas.Text & "" & cbProdi.Text


        If rbLaki.Checked = True Then
            Jk = "L"
        ElseIf rbPerempuan.Checked Then
            Jk = "P"
        End If

        Grade = txtGrade.Text

        DataGridView1.Rows.Add(Nim, Nama, Kelas_Prodi, Jk, NA, Grade)
    End Sub


    Private Sub HapusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusToolStripMenuItem.Click
        Dim Tanya As Object
        Tanya = MsgBox("Yakin Tie Mele Side Hapus..?", vbQuestion + vbYesNo, "Info") = vbYes = True
        If Tanya = True Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
        End If
    End Sub
End Class

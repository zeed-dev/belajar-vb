Public Class Form1

    'DEKLARASI VARIABEL
    Dim tunjangan As Double
    Dim angsuran As Double
    Dim gajiBersih As Double

    Private Sub txtGajiPokok_TextChanged(sender As Object, e As EventArgs) Handles txtGajiPokok.TextChanged
        If cbStatusKawin.Text = "BELUM MENIKAH" Then
            tunjangan = 750000
        ElseIf cbStatusKawin.Text = "MENIKAH" Then
            If txtJmlhAnak.Text = "" Then
                tunjangan = 1000000
            ElseIf txtJmlhAnak.Text <= 2 Then
                tunjangan = 1500000
            ElseIf txtJmlhAnak.Text > 2 Then
                tunjangan = 2250000
            End If
        End If

        gajiBersih = CInt(txtGajiPokok.Text) - angsuran + tunjangan
        txtGajiBersih.Text = gajiBersih

    End Sub

    Private Sub cbStatusAng_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatusAng.SelectedIndexChanged
        If cbStatusAng.Text = "RUMAH " Then
            angsuran = 1500000
        ElseIf cbStatusAng.Text = "KENDARAAN" Then
            angsuran = 1000000
        ElseIf cbStatusAng.Text = "LISTRIK + AIR " Then
            angsuran = 200000
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim Nip, Nama, tgl_lahir, statusKawin, statusAng As String
        Dim Jk As Char
        Dim gaji_pokok As Integer

        Nip = txtNIP.Text
        Nama = txtNama.Text
        tgl_lahir = txtTGL.Text
        gaji_pokok = txtGajiPokok.Text
        statusKawin = cbStatusKawin.Text
        statusAng = cbStatusAng.Text


        If rbLaki.Checked = True Then
            Jk = "L"
        ElseIf rbPerempuan.Checked Then
            Jk = "P"
        End If

        DataGridView1.Rows.Add(Nip, Nama, Jk, Jk, tgl_lahir, gaji_pokok, statusAng, gajiBersih)
    End Sub
End Class






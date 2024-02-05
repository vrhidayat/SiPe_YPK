Imports System.Data.Odbc
Imports System.Security.Cryptography

Public Class DataTransaksi

    Dim _nisn, _nama, _kelas, _angkatan, _petugas As String
    Private Sub PnDashboard_Click(sender As Object, e As EventArgs) Handles PnDashboard.Click
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub PnJurusan_Click(sender As Object, e As EventArgs) Handles PnJurusan.Click
        DataJurusan.Show()
        Me.Close()
    End Sub

    Private Sub PnKelas_Click(sender As Object, e As EventArgs) Handles PnKelas.Click
        DataKelas.Show()
        Me.Close()
    End Sub

    Private Sub PnSiswa_Click(sender As Object, e As EventArgs) Handles PnSiswa.Click
        DataSiswa.Show()
        Me.Close()
    End Sub

    Private Sub PnPetugas_Click(sender As Object, e As EventArgs) Handles PnPetugas.Click
        DataPetugas.Show()
        Me.Close()
    End Sub

    Private Sub DataTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_trSiswa()
    End Sub
    Sub buatIdTransaksi()
        Try
            Call openConn()
            CMD =
                New OdbcCommand("SELECT MAX(id_pembayaran) FROM pembayaran", Conn)
            Dim Hasil As String = ""
            Dim maxTRNS As Object = CMD.ExecuteScalar

            'fungsi if 2018+04+006
            If maxTRNS Is DBNull.Value Then
                Hasil = "TRNS" + "0001"
                LbNoTransaksi.Text = Hasil
            Else
                Dim lastNumber As Integer = Integer.Parse(maxTRNS.ToString().Substring(4))
                If lastNumber >= "9999" Then
                    Hasil = "TRNS" + "0001"
                Else
                    Dim nextNumber As Integer = lastNumber + 1
                    Hasil = "TRNS" + nextNumber.ToString("0000")
                End If
            End If
            LbNoTransaksi.Text = Hasil
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Call closeConn()
        End Try
    End Sub

    Private Sub DataGridSiswa_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridSiswa.SelectionChanged
        Try
            Dim i As Integer = DataGridSiswa.CurrentRow.Index
            Dim selectedYear As String = Convert.ToString(DataGridSiswa.Item(0, i).Value)

            _nisn = Convert.ToString(DataGridSiswa.Item(0, i).Value)
            _nama = Convert.ToString(DataGridSiswa.Item(2, i).Value)
            _kelas = Convert.ToString(DataGridSiswa.Item(3, i).Value)
            _angkatan = Convert.ToString(DataGridSiswa.Item(7, i).Value)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridSiswa_Click(sender As Object, e As EventArgs) Handles DataGridSiswa.Click
        buatIdTransaksi()
        getKelas(_kelas)
        getAngkatan(_angkatan)
        LbNISN.Text = _nisn
        LbNama.Text = _nama
        LbKelas.Text = _kelas
        LbAngkatan.Text = _angkatan
        LbPetugas.Text = LbAdmin.Text
        LbStsByrNama.Text = _nama
    End Sub

    Private Sub TbCariData_TextChanged(sender As Object, e As EventArgs) Handles TbCariData.TextChanged
        Try
            openConn()
            DA =
                New OdbcDataAdapter($"SELECT siswa.nisn, siswa.nis, siswa.nama,
                siswa.id_kelas, kelas.nama_kelas, siswa.alamat, siswa.no_telp, siswa.id_spp, spp.tahun 
                FROM siswa INNER JOIN kelas ON siswa.id_kelas = kelas.id_kelas INNER JOIN spp
                ON siswa.id_spp = spp.id_spp WHERE siswa.nisn like '%{TbCariData.Text}%' 
                OR siswa.nis LIKE '%{TbCariData.Text}%' OR siswa.nama LIKE '%{TbCariData.Text}%'
                OR kelas.nama_kelas LIKE '%{TbCariData.Text}%' OR spp.tahun LIKE '%{TbCariData.Text}%'", Conn)

            DS = New DataSet
            DA.Fill(DS)
            DataGridSiswa.DataSource = DS.Tables(0)
        Catch ex As Exception
            MessageBox.Show("err: " + ex.Message)
        Finally
            closeConn()
        End Try
    End Sub
End Class